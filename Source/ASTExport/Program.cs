﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using CA = Microsoft.CodeAnalysis;

namespace ASTExport;

abstract class PrettyPrintable {
  protected virtual string ChildIndent => "  ";
  protected virtual string ChildSeparator => Environment.NewLine;

  protected void PpChild(TextWriter wr, string indent, string child) {
    wr.WriteLine($"{indent}{ChildIndent}{child}");
  }

  protected void PpChildren(TextWriter wr, string indent, IEnumerable<PrettyPrintable> children)
  {
    indent += ChildIndent;
    var childrenList = children.ToList();
    for (var idx = 0; idx < childrenList.Count; idx++) {
      childrenList[idx].Pp(wr, indent);
      if (idx < childrenList.Count - 1) {
        wr.Write(ChildSeparator);
      }
    }
  }

  private string FmtAttrs(IDictionary<string, string?> attrs) {
    return String.Join(" ", attrs.Select((kv) =>
      String.IsNullOrEmpty(kv.Value) ? $"{{:{kv.Key}}}" : $"{{:{kv.Key} {kv.Value}}}"));
  }

  protected void PpBlockOpen(TextWriter wr, string indent, object? kind, Name name,
    IEnumerable<string>? parameters,
    Dictionary<string, string?>? attrs,
    IEnumerable<Type>? inheritance)
  {
    var parts = new List<string>();
    parts.Add($"{kind}");
    if (attrs != null) {
      parts.Add(FmtAttrs(attrs));
    }
    var paramsStr = parameters == null ? "" : $"<{String.Join(", ", parameters)}>";
    parts.Add($"{name.AsDecl(forceExtern: true)}{paramsStr}");
    if (inheritance != null) {
      parts.Add($"extends {String.Join(", ", inheritance.Select(t => t.ToString()))}");
    }
    wr.WriteLine($"{indent}{String.Join(" ", parts)} {{");
  }

  protected void PpBlockClose(TextWriter wr, string indent) {
    wr.WriteLine($"{indent}}}");
  }

  public abstract void Pp(TextWriter wr, string indent);
}

internal class SemanticModel {
  private readonly string cSharpRootNS;
  private readonly CA.SemanticModel model;

  public SemanticModel(string cSharpRootNS, CA.SemanticModel model) {
    this.cSharpRootNS = cSharpRootNS;
    this.model = model;
  }

  private Name GetName(ISymbol? symbol, string fallback) {
    if (symbol == null) {
      return new Name(fallback);
    }

    string WithNs(string ns) => ns == "" ? symbol.Name : $"{ns}.{symbol.Name}";

    // Not ToString() because that includes type parameters (e.g. System.Collections.Generic.List<T>)
    var ns = symbol.ContainingSymbol switch {
      INamespaceSymbol {IsGlobalNamespace: true} => "",
      var s => s.ToString() ?? ""
    };

    if (ns.StartsWith(cSharpRootNS)) {
      // For local names return a complete path minus the current module prefix
      var fullName = WithNs(ns.Substring(cSharpRootNS.Length).TrimStart('.'));
      return new Name(fullName, fullName.Replace(".", "__"));
    }

    // For global names use the fully qualified name
    return new Name(WithNs(ns));
  }

  public Name GetName(SyntaxNode node) {
    return node switch {
      EnumMemberDeclarationSyntax s => new Name(s.Identifier),
      EnumDeclarationSyntax s => GetName(model.GetDeclaredSymbol(s), $"[UNKNOWN ENUM {s.Identifier.Text}]"),
      TypeDeclarationSyntax s => GetName(model.GetDeclaredSymbol(s), $"[UNKNOWN DECL {s.Identifier.Text}]"),
      _ => GetName(model.GetSymbolInfo(node).Symbol, $"[UNKNOWN {node.GetType()} {node}]")
    };
  }
}

class AST : PrettyPrintable {
  private readonly string cSharpRootNS;
  private readonly string dafnyRootModule;
  private readonly SyntaxTree syntax;
  private readonly SemanticModel model;

  public AST(string cSharpRootNS, string dafnyRootModule, SyntaxTree syntax, SemanticModel model) {
    this.syntax = syntax;
    this.model = model;
    this.cSharpRootNS = cSharpRootNS;
    this.dafnyRootModule = dafnyRootModule;
  }

  public static AST FromFile(string projectPath, string filePath, string cSharpRootNS, string dafnyRootModule) {
    // https://github.com/dotnet/roslyn/issues/44586
    MSBuildLocator.RegisterDefaults();
    var workspace = Microsoft.CodeAnalysis.MSBuild.MSBuildWorkspace.Create();
    workspace.LoadMetadataForReferencedProjects = true;

    var project = workspace.OpenProjectAsync(projectPath).Result;

    //var errors = workspace.Diagnostics.Select()
    if (!workspace.Diagnostics.IsEmpty) {
      foreach(var diagnostic in workspace.Diagnostics) {
        Console.WriteLine("Error in project: {0}", diagnostic.Message);
      }
      throw new Exception("Unexpected errors while building DafnyPipeline.csproj");
    }

    var compilation = project.GetCompilationAsync().Result!;
    var fullPath = Path.GetFullPath(filePath);
    var syntax = compilation.SyntaxTrees.First(st => Path.GetFullPath(st.FilePath) == fullPath);
    var model = compilation.GetSemanticModel(syntax);
    return new AST(cSharpRootNS, dafnyRootModule, syntax, new SemanticModel(cSharpRootNS, model));
  }

  private CompilationUnitSyntax Root => syntax.GetCompilationUnitRoot();

  private IEnumerable<PrettyPrintable> Decls =>
    Enumerable.Empty<PrettyPrintable>()
      .Concat(Root.DescendantNodes().OfType<EnumDeclarationSyntax>().Select(s => new Enum(s, model)))
      .Concat(Root.DescendantNodes().OfType<TypeDeclarationSyntax>().Select(s => new TypeDecl(s, model)));

  public override void Pp(TextWriter wr, string indent) {
    wr.WriteLine("include \"CSharpCompat.dfy\"");
    wr.WriteLine();

    PpBlockOpen(wr, indent, "module", new Name(cSharpRootNS, dafnyRootModule),
      null, null, null);

    PpChild(wr, indent, "import System");
    PpChild(wr, indent, "import opened Dafny");
    wr.WriteLine();

    PpChildren(wr, indent, Decls);

    PpBlockClose(wr, indent);
  }
}

class TypeDecl : PrettyPrintable {
  private readonly TypeDeclarationSyntax syntax;
  private readonly SemanticModel model;

  protected override string ChildSeparator => "";

  public TypeDecl(TypeDeclarationSyntax syntax, SemanticModel model) {
    this.syntax = syntax;
    this.model = model;
  }

  private IEnumerable<PrettyPrintable> Fields =>
    syntax.ChildNodes().OfType<FieldDeclarationSyntax>().Select(s => new Field(s, model));

  public override void Pp(TextWriter wr, string indent) {
    PpBlockOpen(wr, indent, "trait", Name.OfSyntax(syntax, model),
      syntax.TypeParameterList?.Parameters.Select(s => new Name(s.Identifier).DafnyId),
      new Dictionary<string, string?> {{"compile", "false"}},
      syntax.BaseList?.Types.Select(t => new Type(t.Type, model)));
    PpChildren(wr, indent, Fields);
    PpBlockClose(wr, indent);
  }
}

class Enum : PrettyPrintable {
  private readonly EnumDeclarationSyntax syntax;
  private readonly SemanticModel model;

  protected override string ChildSeparator => "";

  public Enum(EnumDeclarationSyntax syntax, SemanticModel model) {
    this.syntax = syntax;
    this.model = model;
  }

  private IEnumerable<EnumMember> Members =>
    syntax.Members.Select(m => new EnumMember(m, model));

  public override void Pp(TextWriter wr, string indent) {
    var nm = Name.OfSyntax(syntax, model);
    PpBlockOpen(wr, indent, "class", nm, null, null, null);
    PpChildren(wr, indent, Members);
    PpChild(wr, indent, $"function method {{:extern}} Equals(other: {nm.DafnyId}): bool");
    PpBlockClose(wr, indent);
  }
}


class EnumMember : PrettyPrintable {
  private readonly EnumMemberDeclarationSyntax syntax;
  private readonly SemanticModel model;

  public EnumMember(EnumMemberDeclarationSyntax syntax, SemanticModel model) {
    this.syntax = syntax;
    this.model = model;
  }

  public override void Pp(TextWriter wr, string indent) {
    var decl = Name.OfSyntax(syntax, model).AsDecl(forceExtern: true);
    var type = Name.OfSyntax(this.syntax.Parent!, model).DafnyId;
    wr.WriteLine($"{indent}static const {decl}: {type}");
  }
}

class Field : PrettyPrintable {
  private readonly FieldDeclarationSyntax syntax;
  private readonly SemanticModel model;

  protected override string ChildSeparator => "";
  protected override string ChildIndent => "";

  public Field(FieldDeclarationSyntax syntax, SemanticModel model) {
    this.syntax = syntax;
    this.model = model;
  }

  private IEnumerable<Variable> Variables =>
    syntax.Declaration.Variables.Select(v => new Variable(syntax.Declaration.Type, v, model));

  public override void Pp(TextWriter wr, string indent) {
    PpChildren(wr, indent, Variables);
  }
}

internal class Type {
  private readonly TypeSyntax syntax;
  private readonly SemanticModel model;

  public Type(TypeSyntax syntax, SemanticModel model) {
    this.syntax = syntax;
    this.model = model;
  }

  private string GenericNameToString(GenericNameSyntax s) {
    var name = s.Identifier.Text switch {
      "Tuple" => $"Tuple{s.TypeArgumentList.Arguments.Count}",
      _ => Name.OfSyntax(s, model).DafnyId
    };
    var typeArgs = String.Join(", ", s.TypeArgumentList.Arguments.Select(t => new Type(t, model)));
    return @$"{name}<{typeArgs}>";
  }

  public override string ToString() {
    return syntax switch {
      PredefinedTypeSyntax { Keyword: var kw } =>
        kw.Text, // FIXME: int, string?
      ArrayTypeSyntax s =>
        $"array<{new Type(s.ElementType, model)}>",
      GenericNameSyntax s =>
        GenericNameToString(s),
      SimpleNameSyntax { Identifier: { Text: "BigInteger" } } =>
        "int",
      _ =>
        Name.OfSyntax(syntax, model).DafnyId, // TODO
    };
  }
}

internal class Variable : PrettyPrintable {
  private readonly Type type;
  private readonly SyntaxToken identifier;

  public Variable(TypeSyntax type, VariableDeclaratorSyntax syntax, SemanticModel model) {
    this.type = new Type(type, model);
    this.identifier = syntax.Identifier;
  }

  public override void Pp(TextWriter wr, string indent) {
    wr.WriteLine($"{indent}var {new Name(identifier).AsDecl()}: {type}");
  }
}

internal class Name {
  private const string EscapePrefix = "CSharp_";
  private static readonly Regex DisallowedNameRe = new Regex("^(type$|ORDINAL$|_)");

  public readonly string DafnyId;
  public readonly string CSharpID;

  public Name(string cSharpID, string dafnyID) {
    this.CSharpID = cSharpID;
    this.DafnyId = dafnyID.StartsWith(EscapePrefix) || DisallowedNameRe.IsMatch(dafnyID) ?
      EscapePrefix + dafnyID : dafnyID;
  }

  public Name(string cSharpId) : this(cSharpId, cSharpId) {
  }

  public Name(SyntaxToken token) : this(token.Text) {
  }

  public static Name OfSyntax(SyntaxNode node, SemanticModel model) {
    return model.GetName(node);
  }

  //this.id =
  //model.GetDeclaredSymbol()

  public string AsDecl(bool forceExtern = false) {
    var attr = CSharpID != DafnyId ? $"{{:extern \"{CSharpID}\"}} " : forceExtern ? "{:extern} " : "";
    return $"{attr}{DafnyId}";
  }
}

public static class Program {
  public static void minimal() {
    // https://stackoverflow.com/questions/37542434/how-to-get-full-name-path-for-method-call-class-declaration-using-roslyn
      var syntaxTree = CSharpSyntaxTree.ParseText(File.ReadAllText("minimal.cs"));
      var syntaxTrees = new[] { syntaxTree }; // Add SyntaxTree array from project files.
      var compilation = CSharpCompilation.Create("tempAssembly", syntaxTrees);
      var semanticModel = compilation.GetSemanticModel(syntaxTree);

      //var caretPosition = 50;
      //var symbol = SymbolFinder.FindSymbolAtPositionAsync(semanticModel, caretPosition, new AdhocWorkspace()).Result;
      //var location = symbol.Locations.First();
      //var node = location.SourceTree?.GetRoot()?.FindNode(location.SourceSpan);
      //var fullName = symbol.ToString(); // fullName is "TestNamespace.Test"
      //Console.WriteLine(fullName);

      new AST("RootNS", "RootMod", syntaxTree, new SemanticModel("RootNS", semanticModel)).Pp(Console.Out, "");
  }
  public static void Main(string[] args) {
    //AST.FromFile(args[0], args[1], args[2]).Pp(Console.Out, "");
    //return;
    var ast = AST.FromFile(args[0], args[1], args[2], args[3]);
    ast.Pp(Console.Out, "");
  }
}