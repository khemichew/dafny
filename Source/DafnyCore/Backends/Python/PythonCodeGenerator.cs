using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Numerics;
using DafnyCore.Backends.Python;
using JetBrains.Annotations;
using Microsoft.BaseTypes;
namespace MutateCSharp
{
    internal class Schemata241
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT241");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplacePostfixUnaryExprOp_18(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.TopLevelDeclWithMembers argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() && argument2();
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, Microsoft.Dafny.ModuleDefinition argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.SubsetTypeDecl.WKind argument1, Microsoft.Dafny.SubsetTypeDecl.WKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, Microsoft.Dafny.ModuleDefinition argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.NewtypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, Microsoft.Dafny.NativeType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_20(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 + argument2;
        }

        internal static int ReplaceNumericConstant_2(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.DatatypeCtor argument1, Microsoft.Dafny.DatatypeCtor argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_6(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() || argument2();
        }

    }
}

namespace Microsoft.Dafny.Compilers
{
    public
      class PythonCodeGenerator : SinglePassCodeGenerator
    {
        public PythonCodeGenerator(DafnyOptions options, ErrorReporter reporter) : base(options, reporter)
        {
            if (Options?.CoverageLegendFile != null)
            {
                Imports.Add(MutateCSharp.Schemata241.ReplaceStringConstant_0(1L, "DafnyProfiling"));
            }
        }

        private readonly List<string> Imports = new() { DafnyDefaultModule };

        public override IReadOnlySet<Feature> UnsupportedFeatures => new HashSet<Feature> {
      Feature.SubsetTypeTests,
      Feature.MethodSynthesis,
      Feature.RuntimeCoverageReport
    };

        public override string ModuleSeparator => MutateCSharp.Schemata241.ReplaceStringConstant_0(2L, "_");

        private const string DafnyRuntimeModule = "_dafny";
        private const string DafnyDefaultModule = "module_";
        const string DafnySetClass = $"{DafnyRuntimeModule}.Set";
        const string DafnyMultiSetClass = $"{DafnyRuntimeModule}.MultiSet";
        const string DafnySeqClass = $"{DafnyRuntimeModule}.Seq";
        private string DafnySeqMakerFunction => UnicodeCharEnabled ? $"{DafnyRuntimeModule}.SeqWithoutIsStrInference" : DafnySeqClass;
        const string DafnyArrayClass = $"{DafnyRuntimeModule}.Array";
        const string DafnyMapClass = $"{DafnyRuntimeModule}.Map";
        const string DafnyDefaults = $"{DafnyRuntimeModule}.defaults";
        string FormatDefaultTypeParameterValue(TopLevelDecl tp)
        {
            Contract.Requires(tp is TypeParameter or AbstractTypeDecl);
            return $"default_{tp.GetCompileName(Options)}";
        }
        protected override string StmtTerminator { get => ""; }
        protected override string True { get => MutateCSharp.Schemata241.ReplaceStringConstant_0(3L, "True"); }
        protected override string False { get => MutateCSharp.Schemata241.ReplaceStringConstant_0(4L, "False"); }
        protected override string Conj { get => MutateCSharp.Schemata241.ReplaceStringConstant_0(5L, "and"); }

        private static readonly IEnumerable<string> Keywords = new HashSet<string>
        {
            MutateCSharp.Schemata241.ReplaceStringConstant_0(6L, "False"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(7L, "None"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(8L, "True"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(9L, "and"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(10L, "as"
    ),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(11L, "assert"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(12L, "async"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(13L, "await"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(14L, "break"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(15L, "class"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(16L, "continue"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(17L, "def"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(18L, "del"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(19L, "enum"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(20L, "elif"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(21L, "else"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(22L, "except"
    ),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(23L, "finally"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(24L, "for"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(25L, "from"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(26L, "global"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(27L, "if"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(28L, "import"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(29L, "in"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(30L, "is"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(31L, "lambda"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(32L, "nonlocal"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(33L, "not"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(34L, "or"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(35L, "pass"
    ),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(36L, "raise"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(37L, "return"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(38L, "try"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(39L, "while"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(40L, "with"),
            MutateCSharp.Schemata241.ReplaceStringConstant_0(41L, "yield")
        };
        protected override void EmitHeader(Program program, ConcreteSyntaxTree wr)
        {
            wr.WriteLine($"# Dafny program {program.Name} compiled into Python");
            if (Options.IncludeRuntime)
            {
                EmitRuntimeSource(MutateCSharp.Schemata241.ReplaceStringConstant_0(42L, "DafnyRuntimePython"), wr);
            }
            if (Options.Get(CommonOptionBag.UseStandardLibraries))
            {
                EmitRuntimeSource(MutateCSharp.Schemata241.ReplaceStringConstant_0(43L, "DafnyStandardLibraries_py"), wr);
            }

            Imports.Add(DafnyRuntimeModule);
            EmitImports(null, wr);
            wr.WriteLine();
        }

        public override void EmitCallToMain(Method mainMethod, string baseName, ConcreteSyntaxTree wr)
        {
            Coverage.EmitSetup(wr);
            var moduleName = IdProtect(mainMethod.EnclosingClass.EnclosingModuleDefinition.GetCompileName(Options));
            if (MutateCSharp.Schemata241.ReplaceBinExprOp_1(44L, moduleName, DafnyDefaultModule))
            {
                wr.WriteLine($"import {moduleName}");
            }
            wr.NewBlockPy(MutateCSharp.Schemata241.ReplaceStringConstant_0(45L, "try:"))
              .WriteLine($"dafnyArgs = [{DafnyRuntimeModule}.Seq(a) for a in sys.argv]")
              .WriteLine($"{mainMethod.EnclosingClass.GetFullCompileName(Options)}.{(IssueCreateStaticMain(mainMethod) ? MutateCSharp.Schemata241.ReplaceStringConstant_0(46L, "StaticMain") : IdName(mainMethod))}(dafnyArgs)");
            wr.NewBlockPy($"except {DafnyRuntimeModule}.HaltException as e:")
              .WriteLine($"{DafnyRuntimeModule}.print(\"[Program halted] \" + e.message + \"\\n\")")
              .WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(47L, "sys.exit(1)"));
            Coverage.EmitTearDown(wr);
        }

        protected override ConcreteSyntaxTree CreateStaticMain(IClassWriter cw, string argsParameterName)
        {
            var mw = ((ClassWriter)cw).MethodWriter.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(48L, "@staticmethod"));
            return mw.NewBlockPy($"def StaticMain({argsParameterName}):");
        }

        protected override ConcreteSyntaxTree CreateModule(string moduleName, bool isDefault, ModuleDefinition externModule,
          string libraryName, ConcreteSyntaxTree wr)
        {
            moduleName = IdProtect(moduleName);
            var file = wr.NewFile($"{moduleName}.py");
            EmitImports(moduleName, file);
            return file;
        }

        protected override void DependOnModule(Program program, ModuleDefinition module, ModuleDefinition externModule,
          string libraryName)
        {
            var moduleName = IdProtect(module.GetCompileName(Options));
            Imports.Add(moduleName);
        }

        private void EmitImports(string moduleName, ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(49L, "import sys"));
            wr.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(50L, "from typing import Callable, Any, TypeVar, NamedTuple"));
            wr.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(51L, "from math import floor"));
            wr.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(52L, "from itertools import count"));
            wr.WriteLine();
            Imports.ForEach(module => wr.WriteLine($"import {module}"));
            if (moduleName != null)
            {
                wr.WriteLine();
                wr.WriteLine($"# Module: {moduleName}");
                Imports.Add(moduleName);
            }
        }

        protected override string GetHelperModuleName() => DafnyRuntimeModule;

        private static string MangleName(string name)
        {
            if (Keywords.Contains(name))
            {
                name = $"{name}_";
            }
            else
            {
                while (name.StartsWith(MutateCSharp.Schemata241.ReplaceStringConstant_0(53L, "_")))
                {
                    name = $"{name[1..]}_";
                }
                if (MutateCSharp.Schemata241.ReplaceBinExprOp_4(67L, () => MutateCSharp.Schemata241.ReplaceBinExprOp_3(58L, name.Length, MutateCSharp.Schemata241.ReplaceNumericConstant_2(54L, 0)), () => char.IsDigit(name[MutateCSharp.Schemata241.ReplaceNumericConstant_2(63L, 0)])))
                {
                    name = $"d_{name}";
                }
            }
            return name;
        }

        protected override IClassWriter CreateClass(string moduleName, string name, bool isExtern, string/*?*/ fullPrintName,
          List<TypeParameter> typeParameters, TopLevelDecl cls, List<Type> superClasses, IToken tok, ConcreteSyntaxTree wr)
        {
            var realSuperClasses = superClasses?.Where(trait => !trait.IsObject).ToList() ?? new List<Type>();
            var baseClasses = realSuperClasses.Any()
              ? $"({realSuperClasses.Comma(trait => TypeName(trait, wr, tok))})"
              : "";
            var methodWriter = wr.NewBlockPy(header: $"class {IdProtect(name)}{baseClasses}:");

            var relevantTypeParameters = typeParameters.Where(NeedsTypeDescriptor).ToList();
            var args = relevantTypeParameters.Comma(tp => tp.GetCompileName(Options));
            if (!string.IsNullOrEmpty(args)) { args = $", {args}"; }
            var isNewtypeWithTraits = cls is NewtypeDecl { ParentTraits: { Count: > 0 } };
            if (isNewtypeWithTraits)
            {
                args += MutateCSharp.Schemata241.ReplaceStringConstant_0(73L, ", value");
            }
            var block = methodWriter.NewBlockPy(header: $"def  __init__(self{args}):", close: BlockStyle.Newline);
            foreach (var tp in relevantTypeParameters)
            {
                block.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(74L, "self.{0} = {0}"), tp.GetCompileName(Options));
            }
            var constructorWriter = block.Fork();
            block.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(75L, "pass"));

            if (MutateCSharp.Schemata241.ReplaceBinExprOp_4(82L, () => cls is not DefaultClassDecl, () => (MutateCSharp.Schemata241.ReplaceBinExprOp_5(76L, () => fullPrintName != null, () => isNewtypeWithTraits))))
            {
                var wBody = methodWriter.NewBlockPy(MutateCSharp.Schemata241.ReplaceStringConstant_0(88L, "def __dafnystr__(self) -> str:"));
                if (isNewtypeWithTraits)
                {
                    wBody.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(89L, "return _dafny.string_of(self._value)"));
                }
                else
                {
                    wBody.WriteLine($"return \"{fullPrintName}\"");
                }
            }

            return new ClassWriter(this, constructorWriter, methodWriter);
        }

        protected override IClassWriter CreateTrait(string name, bool isExtern, List<TypeParameter> typeParameters,
          TraitDecl trait, List<Type> superClasses, IToken tok, ConcreteSyntaxTree wr)
        {
            var methodWriter = wr.NewBlockPy(header: $"class {IdProtect(name)}:");
            // Avoids problems with member-less traits 
            if (trait is TraitDecl tr && tr.Members.All(m => MutateCSharp.Schemata241.ReplaceBinExprOp_5(90L, () => m.IsGhost, () => !m.IsStatic)))
            {
                methodWriter.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(96L, "pass"));
            }
            return new ClassWriter(this, methodWriter, methodWriter);
        }

        protected override ConcreteSyntaxTree CreateIterator(IteratorDecl iter, ConcreteSyntaxTree wr)
        {
            var cw = (ClassWriter)CreateClass(IdProtect(iter.EnclosingModuleDefinition.GetCompileName(Options)), IdName(iter), MutateCSharp.Schemata241.ReplaceBooleanConstant_6(97L, false),
              iter.FullName, iter.TypeArgs, iter, null, iter.tok, wr);
            var constructorWriter = cw.ConstructorWriter;
            var w = cw.MethodWriter;
            // here come the fields
            Constructor ct = null;
            foreach (var member in iter.Members)
            {
                switch (member)
                {
                    case Field { IsGhost: false } f:
                        DeclareField(IdName(f), false, false, f.Type, f.tok, PlaceboValue(f.Type, constructorWriter, f.tok, true), constructorWriter);
                        break;
                        break;
                    case Constructor constructor:
                        Contract.Assert(ct == null);  // we're expecting just one constructor
                        ct = constructor;
                        break;
                        break;
                }
            }
            Contract.Assert(ct != null);  // we do expect a constructor
            constructorWriter.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(98L, "self._iter = None"));

            var nonNullIns = ct.Ins.Where(f => !f.IsGhost).ToList();
            var args = nonNullIns.Select(IdName).Prepend(MutateCSharp.Schemata241.ReplaceStringConstant_0(99L, "self")).Comma();
            var wCtor = w.NewBlockPy($"def {IdName(ct)}({args}):");
            foreach (var p in nonNullIns)
            {
                wCtor.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(100L, "self.{0} = {0}"), IdName(p));
            }
            wCtor.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(101L, "self._iter = self.TheIterator()"));

            var wMoveNext = w.NewBlockPy(MutateCSharp.Schemata241.ReplaceStringConstant_0(102L, "def MoveNext(self):"));
            wMoveNext.NewBlockPy(MutateCSharp.Schemata241.ReplaceStringConstant_0(103L, "try:"))
              .WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(104L, "next(self._iter)"))
              .WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(105L, "return True"));
            wMoveNext.NewBlockPy(MutateCSharp.Schemata241.ReplaceStringConstant_0(106L, "except (StopIteration, TypeError) as e:"))
              .WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(107L, "return False"));

            return w.NewBlockPy(MutateCSharp.Schemata241.ReplaceStringConstant_0(108L, "def TheIterator(self):"));
        }

        protected override IClassWriter DeclareDatatype(DatatypeDecl dt, ConcreteSyntaxTree wr)
        {

            if (dt is TupleTypeDecl)
            {
                return null;
            }

            var DtT = IdProtect(dt.GetCompileName(Options));

            var baseClasses = dt.ParentTypeInformation.UniqueParentTraits().Any()
              ? $"({dt.ParentTypeInformation.UniqueParentTraits().Comma(trait => TypeName(trait, wr, dt.tok))})"
              : "";
            var btw = wr.NewBlockPy($"class {DtT}{baseClasses}:", close: BlockStyle.Newline);

            if (dt.HasFinitePossibleValues)
            {
                btw.WriteLine($"@{DafnyRuntimeModule}.classproperty");
                var w = btw.NewBlockPy(
                  $"def AllSingletonConstructors(cls):");
                var values = dt.Ctors.Select(ctor =>
                  ctor.IsGhost
                  ? ForcePlaceboValue(UserDefinedType.FromTopLevelDecl(dt.tok, dt), w, dt.tok)
                  : $"{DtCtorDeclarationName(ctor)}()");
                w.WriteLine($"return [{values.Comma()}]");
            }

            btw.WriteLine($"@classmethod");
            var wDefault = btw.NewBlockPy($"def default(cls, {UsedTypeParameters(dt, MutateCSharp.Schemata241.ReplaceBooleanConstant_6(109L, true)).Comma(FormatDefaultTypeParameterValue)}):");
            var groundingCtor = dt.GetGroundingCtor();
            if (groundingCtor.IsGhost)
            {
                wDefault.WriteLine($"return lambda: {ForcePlaceboValue(UserDefinedType.FromTopLevelDecl(dt.tok, dt), wDefault, dt.tok)}");
            }
            else if (DatatypeWrapperEraser.GetInnerTypeOfErasableDatatypeWrapper(Options, dt, out var innerType))
            {
                wDefault.WriteLine($"return lambda: {DefaultValue(innerType, wDefault, dt.tok)}");
            }
            else
            {
                var wTypeDescriptors = new ConcreteSyntaxTree();
                var typeDescriptorComma = "";
                WriteRuntimeTypeDescriptorsFormals(TypeArgumentInstantiation.ListFromFormals(dt.TypeArgs),
                  wTypeDescriptors, ref typeDescriptorComma, FormatDefaultTypeParameterValue);
                var typeDescriptorUses = wTypeDescriptors.ToString();

                var nonGhostFormals = groundingCtor.Formals.Where(f => !f.IsGhost).ToList();
                var arguments = nonGhostFormals.Comma(f => DefaultValue(f.Type, wDefault, f.tok));
                wDefault.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(110L, "return lambda: "));
                EmitDatatypeValue(dt, groundingCtor, dt is CoDatatypeDecl, typeDescriptorUses, arguments, wDefault, MutateCSharp.Schemata241.ReplaceBooleanConstant_6(111L, false));
                wDefault.WriteLine();
            }

            // Ensures the inequality is based on equality defined in the constructor
            btw.NewBlockPy(MutateCSharp.Schemata241.ReplaceStringConstant_0(112L, "def __ne__(self, __o: object) -> bool:"))
              .WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(113L, "return not self.__eq__(__o)"));

            if (dt is CoDatatypeDecl)
            {
                var w = wr.NewBlockPy($"class {dt.GetCompileName(Options)}__Lazy({IdName(dt)}):");
                w.NewBlockPy(MutateCSharp.Schemata241.ReplaceStringConstant_0(114L, "def __init__(self, _c):"))
                  .WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(115L, "self._c = _c"))
                  .WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(116L, "self._d = None"));
                var get = w.NewBlockPy($"def _get(self):");
                get.NewBlockPy(MutateCSharp.Schemata241.ReplaceStringConstant_0(117L, "if self._c is not None:"))
                  .WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(118L, "self._d = self._c()"))
                  .WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(119L, "self._c = None"));
                get.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(120L, "return self._d"));
                w.NewBlockPy(MutateCSharp.Schemata241.ReplaceStringConstant_0(121L, "def __dafnystr__(self) -> str:"))
                  .WriteLine($"return {DafnyRuntimeModule}.string_of(self._get())");
                foreach (var destructor in from ctor in dt.Ctors
                                           let index = MutateCSharp.Schemata241.ReplaceNumericConstant_2(122L, 0
        )
                                           from dtor in ctor.Destructors
                                           where MutateCSharp.Schemata241.ReplaceBinExprOp_7(130L, dtor.EnclosingCtors[MutateCSharp.Schemata241.ReplaceNumericConstant_2(126L, 0)], ctor
        )
                                           select dtor.CorrespondingFormals[MutateCSharp.Schemata241.ReplaceNumericConstant_2(131L, 0)] into arg
                                           where !arg.IsGhost
                                           select IdProtect(arg.CompileName))
                {
                    w.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(135L, "@property"));
                    w.NewBlockPy($"def {destructor}(self):")
                      .WriteLine($"return self._get().{destructor}");
                }
            }

            foreach (var ctor in dt.Ctors.Where(ctor => !ctor.IsGhost))
            {
                // Class-level fields don't work in all python version due to metaclasses.
                // Adding a more restrictive type would be desirable, but Python expects their definition to precede this.
                var argListX = dt.TypeArgs.Where(NeedsTypeDescriptor)
                  .Select(tp => $"('{IdProtect(tp.GetCompileName(Options))}', Any)");
                var argListY = ctor.Destructors.Where(d => !d.IsGhost)
                  .Select(d => $"('{IdProtect(d.GetCompileName(Options))}', Any)");
                var argList = argListX.Concat(argListY).Comma();
                var namedtuple = $"NamedTuple('{IdProtect(ctor.GetCompileName(Options))}', [{argList}])";
                var header = $"class {DtCtorDeclarationName(ctor)}({DtT}, {namedtuple}):";
                var constructor = wr.NewBlockPy(header, close: BlockStyle.Newline);
                DatatypeFieldsAndConstructor(ctor, constructor);

                // @property
                // def is_Ctor0(self) -> bool:
                //   return isinstance(self, Dt_Ctor0) }
                btw.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(136L, "@property"));
                btw.NewBlockPy($"def is_{ctor.GetCompileName(Options)}(self) -> bool:")
                  .WriteLine($"return isinstance(self, {DtCtorDeclarationName(ctor)})");
            }

            return new ClassWriter(this, btw, btw);
        }

        private void DatatypeFieldsAndConstructor(DatatypeCtor ctor, ConcreteSyntaxTree wr)
        {
            var dt = ctor.EnclosingDatatype;

            // Dt.Ctor
            var fString = (dt.EnclosingModuleDefinition.TryToAvoidName ? "" : dt.EnclosingModuleDefinition.Name + MutateCSharp.Schemata241.ReplaceStringConstant_0(137L, ".")) +
                      dt.Name + MutateCSharp.Schemata241.ReplaceStringConstant_0(138L, ".") + ctor.Name;

            // {self.Dtor0}, {self.Dtor1}, ..., {self.DtorN}
            var args = ctor.Formals
              .Where(f => !f.IsGhost)
              .Select(f =>
              {
                  if (MutateCSharp.Schemata241.ReplaceBinExprOp_4(139L, () => f.Type.IsStringType, () => UnicodeCharEnabled))
                  {
                      return $"{{self.{IdProtect(f.CompileName)}.VerbatimString(True)}}";
                  }
                  else
                  {
                      return $"{{{DafnyRuntimeModule}.string_of(self.{IdProtect(f.CompileName)})}}";
                  }

                  return default;
              })
              .Comma();

            if (MutateCSharp.Schemata241.ReplaceBinExprOp_4(154L, () => MutateCSharp.Schemata241.ReplaceBinExprOp_3(149L, args.Length, MutateCSharp.Schemata241.ReplaceNumericConstant_2(145L, 0)), () => dt is not CoDatatypeDecl))
            {
                fString += $"({args})";
            }

            wr.NewBlockPy(MutateCSharp.Schemata241.ReplaceStringConstant_0(160L, "def __dafnystr__(self) -> str:"))
              .WriteLine($"return f\'{fString.Replace(MutateCSharp.Schemata241.ReplaceStringConstant_0(161L, "\'"), MutateCSharp.Schemata241.ReplaceStringConstant_0(162L, "\\\'"))}\'");

            var argList = ctor.Formals
              .Where(f => !f.IsGhost)
              .Select(f => $"self.{IdProtect(f.CompileName)} == __o.{IdProtect(f.CompileName)}");
            var suffix = MutateCSharp.Schemata241.ReplaceBinExprOp_3(167L, args.Length, MutateCSharp.Schemata241.ReplaceNumericConstant_2(163L, 0)) ? $" and {string.Join(MutateCSharp.Schemata241.ReplaceStringConstant_0(172L, " and "), argList)}" : "";

            wr.NewBlockPy(MutateCSharp.Schemata241.ReplaceStringConstant_0(173L, "def __eq__(self, __o: object) -> bool:"))
              .WriteLine($"return isinstance(__o, {DtCtorDeclarationName(ctor)}){suffix}");

            wr.NewBlockPy(MutateCSharp.Schemata241.ReplaceStringConstant_0(174L, "def __hash__(self) -> int:"))
              .WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(175L, "return super().__hash__()"));
        }

        private string DtCtorDeclarationName(DatatypeCtor ctor, bool full = false)
        {
            var dt = ctor.EnclosingDatatype;
            return $"{(full ? dt.GetFullCompileName(Options) : dt.GetCompileName(Options))}_{ctor.GetCompileName(Options)}";
        }

        protected IClassWriter DeclareType(TopLevelDecl d, SubsetTypeDecl.WKind witnessKind, Expression witness, ConcreteSyntaxTree wr)
        {
            Contract.Requires(d is SubsetTypeDecl or NewtypeDecl);

            var cw = (ClassWriter)CreateClass(IdProtect(d.EnclosingModuleDefinition.GetCompileName(Options)), IdName(d), d, wr);
            var w = cw.MethodWriter;
            var udt = UserDefinedType.FromTopLevelDecl(d.tok, d);
            w.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(176L, "@staticmethod"));
            var block = w.NewBlockPy(MutateCSharp.Schemata241.ReplaceStringConstant_0(177L, "def default():"));
            var wStmts = block.Fork();
            block.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(178L, "return "));
            if (MutateCSharp.Schemata241.ReplaceBinExprOp_8(179L, witnessKind, SubsetTypeDecl.WKind.Compiled))
            {
                block.Append(Expr(witness, MutateCSharp.Schemata241.ReplaceBooleanConstant_6(180L, false), wStmts));
            }
            else
            {
                block.Write(TypeInitializationValue(udt, wr, d.tok, MutateCSharp.Schemata241.ReplaceBooleanConstant_6(181L, false), MutateCSharp.Schemata241.ReplaceBooleanConstant_6(182L, false)));
            }
            block.WriteLine();

            GenerateIsMethod((RedirectingTypeDecl)d, w);

            if (d is NewtypeDecl newtypeDecl && MutateCSharp.Schemata241.ReplaceBinExprOp_9(187L, newtypeDecl.ParentTraits.Count, MutateCSharp.Schemata241.ReplaceNumericConstant_2(183L, 0)))
            {
                // in constructor:
                //   self._value = value
                cw.ConstructorWriter.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(192L, "self._value = value"));
            }

            return cw;
        }

        protected override IClassWriter DeclareNewtype(NewtypeDecl nt, ConcreteSyntaxTree wr)
        {
            return DeclareType(nt, nt.WitnessKind, nt.Witness, wr);
        }

        protected override void DeclareSubsetType(SubsetTypeDecl sst, ConcreteSyntaxTree wr)
        {
            DeclareType(sst, sst.WitnessKind, sst.Witness, wr);
        }

        void GenerateIsMethod(RedirectingTypeDecl declWithConstraints, ConcreteSyntaxTree wr)
        {
            Contract.Requires(declWithConstraints is SubsetTypeDecl or NewtypeDecl);

            if (declWithConstraints.ConstraintIsCompilable)
            {
                var type = UserDefinedType.FromTopLevelDecl(declWithConstraints.tok, (TopLevelDecl)declWithConstraints);

                wr.Write($"def {IsMethodName}(");

                var sep = "";
                var count = WriteRuntimeTypeDescriptorsFormals(TypeArgumentInstantiation.ListFromFormals(declWithConstraints.TypeArgs), wr, ref sep,
                  FormatDefaultTypeParameterValue);
                wr.Write(sep);

                var sourceFormal = new Formal(declWithConstraints.tok, MutateCSharp.Schemata241.ReplaceStringConstant_0(193L, "_source"), type, MutateCSharp.Schemata241.ReplaceBooleanConstant_6(194L, true), MutateCSharp.Schemata241.ReplaceBooleanConstant_6(195L, false), null);
                var wrBody = wr.NewBlockPy($"{IdName(sourceFormal)}):");
                GenerateIsMethodBody(declWithConstraints, sourceFormal, wrBody);
            }
        }

        protected override void GetNativeInfo(NativeType.Selection sel, out string name, out string literalSuffix, out bool needsCastAfterArithmetic)
        {
            literalSuffix = "";
            needsCastAfterArithmetic = MutateCSharp.Schemata241.ReplaceBooleanConstant_6(196L, false);
            switch (sel)
            {
                case NativeType.Selection.Byte:
                case NativeType.Selection.SByte:
                case NativeType.Selection.UShort:
                case NativeType.Selection.Short:
                case NativeType.Selection.UInt:
                case NativeType.Selection.Int:
                case NativeType.Selection.Number:
                case NativeType.Selection.ULong:
                case NativeType.Selection.Long:
                    name = "int"; break;
                    break;
                default:
                    Contract.Assert(false); // unexpected native type
                    throw new cce.UnreachableException(); // to please the compiler
                    break;
            }
        }

        public class ClassWriter : IClassWriter
        {
            private readonly PythonCodeGenerator Compiler;
            public readonly ConcreteSyntaxTree ConstructorWriter;
            public readonly ConcreteSyntaxTree MethodWriter;

            public ClassWriter(PythonCodeGenerator compiler, ConcreteSyntaxTree constructorWriter, ConcreteSyntaxTree methodWriter)
            {
                Contract.Requires(compiler != null);
                Contract.Requires(methodWriter != null);
                Contract.Requires(constructorWriter != null);
                Compiler = compiler;
                ConstructorWriter = constructorWriter;
                MethodWriter = methodWriter;
            }

            public ConcreteSyntaxTree CreateMethod(Method m, List<TypeArgumentInstantiation> typeArgs, bool createBody,
              bool forBodyInheritance, bool lookasideBody)
            {
                return Compiler.CreateMethod(m, typeArgs, createBody, MethodWriter, forBodyInheritance, lookasideBody);
            }

            public ConcreteSyntaxTree SynthesizeMethod(Method m, List<TypeArgumentInstantiation> typeArgs, bool createBody, bool forBodyInheritance, bool lookasideBody)
            {
                throw new UnsupportedFeatureException(Token.NoToken, Feature.MethodSynthesis);
                return default;
            }

            public ConcreteSyntaxTree CreateFunction(string name, List<TypeArgumentInstantiation> typeArgs,
                List<Formal> formals, Type resultType, IToken tok, bool isStatic, bool createBody, MemberDecl member,
                bool forBodyInheritance, bool lookasideBody)
            {
                return Compiler.CreateFunction(name, typeArgs, formals, resultType, tok, isStatic, createBody, member,
                  MethodWriter, forBodyInheritance, lookasideBody);
            }

            public ConcreteSyntaxTree CreateGetter(string name, TopLevelDecl enclosingDecl, Type resultType, IToken tok,
                bool isStatic, bool isConst, bool createBody, MemberDecl member, bool forBodyInheritance)
            {
                return Compiler.CreateGetter(name, resultType, tok, isStatic, createBody, MethodWriter);
            }

            public ConcreteSyntaxTree CreateGetterSetter(string name, Type resultType, IToken tok,
                bool createBody, MemberDecl member, out ConcreteSyntaxTree setterWriter, bool forBodyInheritance)
            {
                return Compiler.CreateGetterSetter(name, createBody, out setterWriter, methodWriter: MethodWriter);
            }

            public void DeclareField(string name, TopLevelDecl enclosingDecl, bool isStatic, bool isConst, Type type,
                IToken tok, string rhs, Field field)
            {
                Compiler.DeclareField(name, isStatic, isConst, type, tok, rhs, ConstructorWriter);
            }

            public void InitializeField(Field field, Type instantiatedFieldType, TopLevelDeclWithMembers enclosingClass)
            {
                throw new cce.UnreachableException();
            }

            public ConcreteSyntaxTree ErrorWriter() => MethodWriter;

            public void Finish()
            {

            }
        }

        protected override string CompanionMemberIdName(MemberDecl member)
        {
            if (MutateCSharp.Schemata241.ReplaceBinExprOp_4(198L, () => member.EnclosingClass is NewtypeDecl, () => MutateCSharp.Schemata241.ReplaceBinExprOp_10(197L, member.OverriddenMember, null)))
            {
                return MutateCSharp.Schemata241.ReplaceStringConstant_0(204L, "_Companion_") + IdName(member);
            }
            return base.CompanionMemberIdName(member);
        }

        private void DeclareField(string name, bool isStatic, bool isConst, Type type, IToken tok, string rhs,
            ConcreteSyntaxTree fieldWriter)
        {
            fieldWriter.Write($"self.{name}: {TypeName(type, fieldWriter, tok)}");
            if (rhs != null)
            {
                fieldWriter.Write($" = {rhs}");
            }
            fieldWriter.WriteLine();
        }

        private ConcreteSyntaxTree CreateGetterSetter(string name, bool createBody, out ConcreteSyntaxTree setterWriter, ConcreteSyntaxTree methodWriter)
        {
            methodWriter.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(205L, "@property"));
            var getterWriter = methodWriter.NewBlockPy(header: $"def {name}(self):");
            methodWriter.WriteLine($"@{name}.setter");
            setterWriter = methodWriter.NewBlockPy(header: $"def {name}(self, value):");
            if (createBody)
            {
                return getterWriter;
            }
            getterWriter.WriteLine($"return self._{name}");
            setterWriter.WriteLine($"self._{name} = value");
            setterWriter = null;
            return null;
        }

        private ConcreteSyntaxTree CreateGetter(string name, Type resultType, IToken tok, bool isStatic, bool createBody, ConcreteSyntaxTree methodWriter)
        {
            if (!createBody) { return null; }
            methodWriter.WriteLine(isStatic ? $"@{DafnyRuntimeModule}.classproperty" : MutateCSharp.Schemata241.ReplaceStringConstant_0(206L, "@property"));
            return methodWriter.NewBlockPy(header: $"def {name}({(isStatic ? MutateCSharp.Schemata241.ReplaceStringConstant_0(207L, "instance") : MutateCSharp.Schemata241.ReplaceStringConstant_0(208L, "self"))}):");
        }

        private ConcreteSyntaxTree CreateMethod(Method m, List<TypeArgumentInstantiation> typeArgs, bool createBody,
            ConcreteSyntaxTree wr, bool forBodyInheritance, bool lookasideBody)
        {
            var customReceiver = MutateCSharp.Schemata241.ReplaceBinExprOp_4(209L, () => !forBodyInheritance, () => NeedsCustomReceiver(m));
            if (MutateCSharp.Schemata241.ReplaceBinExprOp_5(215L, () => m.IsStatic, () => customReceiver)) { wr.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(221L, "@staticmethod")); }
            var protectedName = !forBodyInheritance ? CompanionMemberIdName(m) : IdName(m);
            wr.Write($"def {protectedName}(");
            var sep = "";
            WriteFormals(ForTypeDescriptors(typeArgs, m.EnclosingClass, m, lookasideBody), m.Ins, m.IsStatic, customReceiver, ref sep, wr);
            var body = wr.NewBlockPy(MutateCSharp.Schemata241.ReplaceStringConstant_0(222L, "):"), close: BlockStyle.Newline);
            if (createBody)
            {
                if (m.Body.Body.All(s => s.IsGhost))
                {
                    body.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(223L, "pass"));
                }
                return body;
            }
            body.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(224L, "pass"));
            return null;
        }

        protected override ConcreteSyntaxTree EmitMethodReturns(Method m, ConcreteSyntaxTree wr)
        {
            if (m.Outs.Any(f => !f.IsGhost))
            {
                var beforeReturnBlock = wr.Fork();
                EmitReturn(m.Outs, wr);
                return beforeReturnBlock;
            }
            return wr;
        }

        private void WriteFormals(List<TypeArgumentInstantiation> typeParams, List<Formal> formals, bool isStatic,
          bool customReceiver, ref string sep, ConcreteSyntaxTree wr)
        {
            if (MutateCSharp.Schemata241.ReplaceBinExprOp_4(225L, () => !isStatic, () => !customReceiver))
            {
                wr.Write(sep + MutateCSharp.Schemata241.ReplaceStringConstant_0(231L, "self"));
                sep = MutateCSharp.Schemata241.ReplaceStringConstant_0(232L, ", ");
            }
            WriteRuntimeTypeDescriptorsFormals(typeParams, wr, ref sep, FormatDefaultTypeParameterValue);
            if (customReceiver)
            {
                wr.Write(sep + MutateCSharp.Schemata241.ReplaceStringConstant_0(233L, "self"));
                sep = MutateCSharp.Schemata241.ReplaceStringConstant_0(234L, ", ");
            }
            WriteFormals(sep, formals, wr);
        }

        private ConcreteSyntaxTree CreateFunction(string name, List<TypeArgumentInstantiation> typeArgs,
          List<Formal> formals, Type resultType, IToken tok, bool isStatic, bool createBody, MemberDecl member,
          ConcreteSyntaxTree wr, bool forBodyInheritance, bool lookasideBody)
        {
            if (!createBody) { return null; }
            var customReceiver = MutateCSharp.Schemata241.ReplaceBinExprOp_4(235L, () => !forBodyInheritance, () => NeedsCustomReceiver(member));
            if (MutateCSharp.Schemata241.ReplaceBinExprOp_5(241L, () => isStatic, () => customReceiver)) { wr.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(247L, "@staticmethod")); }
            var protectedName = !forBodyInheritance ? CompanionMemberIdName(member) : IdName(member);
            wr.Write($"def {protectedName}(");
            var sep = "";
            WriteFormals(ForTypeDescriptors(typeArgs, member.EnclosingClass, member, lookasideBody), formals, isStatic, customReceiver, ref sep, wr);
            return wr.NewBlockPy(MutateCSharp.Schemata241.ReplaceStringConstant_0(248L, "):"), close: BlockStyle.Newline);
        }

        // Unlike the other compilers, we use lambdas to model type descriptors here.
        protected override string TypeDescriptor(Type type, ConcreteSyntaxTree wr, IToken tok)
        {
            Contract.Requires(type != null);
            Contract.Requires(tok != null);
            Contract.Requires(wr != null);

            var simplifiedType = DatatypeWrapperEraser.SimplifyTypeAndTrimSubsetTypes(Options, type);
            return simplifiedType switch
            {
                var x when x.IsBuiltinArrowType => $"{DafnyDefaults}.pointer",
                // unresolved proxy; just treat as bool, since no particular type information is apparently needed for this type
                BoolType or TypeProxy => $"{DafnyDefaults}.bool",
                CharType => UnicodeCharEnabled ? $"{DafnyDefaults}.codepoint" : $"{DafnyDefaults}.char",
                IntType or BitvectorType => $"{DafnyDefaults}.int",
                RealType => $"{DafnyDefaults}.real",
                SeqType or SetType or MultiSetType or MapType => TypeHelperName(simplifiedType.NormalizeExpandKeepConstraints()),
                UserDefinedType udt => udt.ResolvedClass switch
                {
                    TypeParameter tp => TypeParameterDescriptor(tp),
                    ClassLikeDecl or NonNullTypeDecl => $"{DafnyDefaults}.pointer",
                    DatatypeDecl => DatatypeDescriptor(udt, udt.TypeArgs, udt.tok),
                    NewtypeDecl or SubsetTypeDecl => CustomDescriptor(udt),
                    _ => throw new cce.UnreachableException()
                },
                _ => throw new cce.UnreachableException()
            };

            string TypeParameterDescriptor(TypeParameter typeParameter)
            {
                if (MutateCSharp.Schemata241.ReplaceBinExprOp_5(256L, () => (MutateCSharp.Schemata241.ReplaceBinExprOp_4(250L, () => MutateCSharp.Schemata241.ReplaceBinExprOp_11(249L, thisContext, null), () => typeParameter.Parent is TopLevelDeclWithMembers and not TraitDecl)), () => typeParameter.Parent is IteratorDecl))
                {
                    return $"self.{typeParameter.GetCompileName(Options)}";
                }
                if (MutateCSharp.Schemata241.ReplaceBinExprOp_11(262L, thisContext, null) && thisContext.ParentFormalTypeParametersToActuals.TryGetValue(typeParameter, out var instantiatedTypeParameter))
                {
                    return TypeDescriptor(instantiatedTypeParameter, wr, tok);
                }
                return FormatDefaultTypeParameterValue(type.AsTypeParameter);
            }

            string CustomDescriptor(UserDefinedType userDefinedType)
            {
                return $"{TypeName_UDT(FullTypeName(userDefinedType), userDefinedType, wr, userDefinedType.tok)}.default";
            }

            string DatatypeDescriptor(UserDefinedType udt, List<Type> typeArgs, IToken tok)
            {
                var dt = (DatatypeDecl)udt.ResolvedClass;
                var w = new ConcreteSyntaxTree();
                if (dt is TupleTypeDecl)
                {
                    w.Write($"{DafnyDefaults}.tuple(");
                }
                else
                {
                    w.Write($"{TypeName_UDT(FullTypeName(udt), udt, wr, tok)}.default(");
                }
                EmitTypeDescriptorsActuals(UsedTypeParameters(dt, typeArgs, MutateCSharp.Schemata241.ReplaceBooleanConstant_6(263L, true)), tok, w, MutateCSharp.Schemata241.ReplaceBooleanConstant_6(264L, true));
                w.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(265L, ")"));
                return w.ToString();
            }

            return default;
        }

        protected override ConcreteSyntaxTree EmitNullTest(bool testIsNull, ConcreteSyntaxTree wr)
        {
            var wrTarget = wr.ForkInParens();
            wr.Write(testIsNull ? MutateCSharp.Schemata241.ReplaceStringConstant_0(266L, " == None") : MutateCSharp.Schemata241.ReplaceStringConstant_0(267L, " != None"));
            return wrTarget;
        }

        protected override ConcreteSyntaxTree EmitTailCallStructure(MemberDecl member, ConcreteSyntaxTree wr)
        {
            if (!member.IsStatic)
            {
                wr.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(268L, "_this = self"));
            }
            wr = wr.NewBlockPy($"while True:").NewBlockPy($"with {DafnyRuntimeModule}.label():");
            var body = wr.Fork();
            wr.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(269L, "break"));
            return body;
        }

        protected override void EmitJumpToTailCallStart(ConcreteSyntaxTree wr)
        {
            wr.WriteLine($"raise {DafnyRuntimeModule}.TailCall()");
        }

        internal override string TypeName(Type type, ConcreteSyntaxTree wr, IToken tok, MemberDecl/*?*/ member = null)
        {
            Contract.Ensures(Contract.Result<string>() != null);
            Contract.Assume(type != null);  // precondition; this ought to be declared as a Requires in the superclass

            var xType = DatatypeWrapperEraser.SimplifyType(Options, type);

            if (xType.IsObjectQ)
            {
                return MutateCSharp.Schemata241.ReplaceStringConstant_0(270L, "object");
            }

            if (MutateCSharp.Schemata241.ReplaceBinExprOp_4(273L, () => MutateCSharp.Schemata241.ReplaceBinExprOp_12(271L, xType.AsNewtype, null), () => MutateCSharp.Schemata241.ReplaceBinExprOp_13(272L, member, null)))
            {
                // when member is given, use UserDefinedType case below
                var nativeType = xType.AsNewtype.NativeType;
                if (MutateCSharp.Schemata241.ReplaceBinExprOp_14(279L, nativeType, null))
                {
                    return GetNativeTypeName(nativeType);
                }
                return TypeName(xType.AsNewtype.BaseType, wr, tok, member);
            }

            switch (xType)
            {
                case BoolType:
                    return "bool";
                    break;
                case CharType:
                    return "str";
                    break;
                case IntType or BigOrdinalType or BitvectorType:
                    return "int";
                    break;
                case RealType:
                    return $"{DafnyRuntimeModule}.BigRational";
                    break;
                case UserDefinedType udt:
                    {
                        var s = FullTypeName(udt, member);
                        return TypeName_UDT(s, udt, wr, udt.tok);
                    }

                    break;
                case CollectionType:
                    return TypeHelperName(xType);
                    break;
            }

            // TODO: I'm not 100% sure this is exhaustive yet
            Contract.Assert(false);
            throw new cce.UnreachableException();
            return default;
        }

        private string FullName(TopLevelDecl decl)
        {
            var localDefinition = MutateCSharp.Schemata241.ReplaceBinExprOp_15(280L, decl.EnclosingModuleDefinition, enclosingModule);
            return IdProtect(localDefinition ? decl.GetCompileName(Options) : decl.GetFullCompileName(Options));
        }

        protected override string TypeInitializationValue(Type type, ConcreteSyntaxTree wr, IToken tok,
            bool usePlaceboValue, bool constructTypeParameterDefaultsFromTypeDescriptors)
        {

            if (usePlaceboValue)
            {
                return MutateCSharp.Schemata241.ReplaceStringConstant_0(281L, "None");
            }

            var xType = type.NormalizeExpandKeepConstraints();

            if (xType.IsObjectQ)
            {
                return MutateCSharp.Schemata241.ReplaceStringConstant_0(282L, "None");
            }

            switch (xType)
            {
                case BoolType:
                    return "False";
                    break;
                case CharType:
                    return UnicodeCharEnabled ? $"{DafnyRuntimeModule}.CodePoint({CharType.DefaultValueAsString})" : CharType.DefaultValueAsString;
                    break;
                case IntType or BigOrdinalType or BitvectorType:
                    return "int(0)";
                    break;
                case RealType:
                    return $"{DafnyRuntimeModule}.BigRational()";
                    break;
                case CollectionType:
                    if (xType is SeqType { Arg: { IsCharType: true } })
                    {
                        var wrString = new ConcreteSyntaxTree();
                        StringLiteralWrapper(wrString).Write("\"\"");
                        return wrString.ToString();
                    }
                    else
                    {
                        return $"{TypeHelperName(xType)}({{}})";
                    }

                    break;
                case UserDefinedType udt:
                    {
                        var cl = udt.ResolvedClass;
                        Contract.Assert(cl != null);
                        switch (cl)
                        {
                            case SubsetTypeDecl td:
                                switch (td.WitnessKind)
                                {
                                    case SubsetTypeDecl.WKind.Compiled:
                                        return TypeName_UDT(FullName(cl), udt, wr, udt.tok) + ".default()";
                                    case SubsetTypeDecl.WKind.Special:
                                        if (ArrowType.IsPartialArrowTypeName(td.Name))
                                        {
                                            return "None";
                                        }
                                        if (td is NonNullTypeDecl decl)
                                        {
                                            if (decl.Class is ArrayClassDecl arr)
                                            {
                                                return $"{DafnyArrayClass}(None, {Enumerable.Repeat("0", arr.Dims).Comma()})";
                                            }
                                            return "None";
                                        }
                                        Contract.Assert(udt.TypeArgs.Any() && ArrowType.IsTotalArrowTypeName(td.Name));
                                        var rangeDefaultValue = TypeInitializationValue(udt.TypeArgs.Last(), wr, tok, usePlaceboValue,
                                          constructTypeParameterDefaultsFromTypeDescriptors);
                                        // The final TypeArg contains the result type
                                        var arguments = udt.TypeArgs.SkipLast(1).Comma((_, i) => idGenerator.FreshId("x"));
                                        return $"(lambda {arguments}: {rangeDefaultValue})";
                                    default:
                                        return TypeInitializationValue(td.RhsWithArgument(udt.TypeArgs), wr, tok, usePlaceboValue,
                                          constructTypeParameterDefaultsFromTypeDescriptors);
                                }

                            case NewtypeDecl td:
                                if (td.Witness != null)
                                {
                                    return TypeName_UDT(FullName(cl), udt, wr, udt.tok) + ".default()";
                                }
                                else
                                {
                                    return TypeInitializationValue(td.BaseType, wr, tok, usePlaceboValue, constructTypeParameterDefaultsFromTypeDescriptors);
                                }

                            case DatatypeDecl dt:
                                var relevantTypeArgs = UsedTypeParameters(dt, udt.TypeArgs, true).ConvertAll(ta => ta.Actual);
                                return dt is TupleTypeDecl
                                  ? $"({relevantTypeArgs.Comma(arg => DefaultValue(arg, wr, tok, constructTypeParameterDefaultsFromTypeDescriptors))}{(relevantTypeArgs.Count == 1 ? "," : "")})"
                                  : $"{FullName(cl)}.default({relevantTypeArgs.Comma(arg => TypeDescriptor(arg, wr, tok))})()";

                            case TypeParameter tp:
                                return constructTypeParameterDefaultsFromTypeDescriptors
                                  ? $"{TypeDescriptor(udt, wr, tok)}()"
                                  : $"{FormatDefaultTypeParameterValue(tp)}()";

                            case AbstractTypeDecl opaque:
                                return FormatDefaultTypeParameterValue(opaque);

                            case ClassDecl:
                            case TraitDecl:
                            case ArrowTypeDecl:
                                return "None";
                        }
                        break;
                    }

                    break;
            }

            Contract.Assert(false);
            throw new cce.UnreachableException();  // unexpected type
            return default;
        }

        protected override string TypeName_UDT(string fullCompileName, List<TypeParameter.TPVariance> variance,
            List<Type> typeArgs, ConcreteSyntaxTree wr, IToken tok, bool omitTypeArguments)
        {
            return fullCompileName;
        }

        protected override string TypeName_Companion(Type type, ConcreteSyntaxTree wr, IToken tok, MemberDecl member)
        {
            type = UserDefinedType.UpcastToMemberEnclosingType(type, member);

            if (type.NormalizeExpandKeepConstraints() is UserDefinedType udt)
            {
                if ((udt.ResolvedClass is DatatypeDecl dt && DatatypeWrapperEraser.IsErasableDatatypeWrapper(Options, dt, out _)) ||
                    udt.ResolvedClass is SubsetTypeDecl or NewtypeDecl)
                {
                    var s = FullTypeName(udt, member);
                    return TypeName_UDT(s, udt, wr, udt.tok);
                }
            }
            return TypeName(type, wr, tok, member);
        }

        protected override void TypeArgDescriptorUse(bool isStatic, bool lookasideBody, TopLevelDeclWithMembers cl, out bool needsTypeParameter, out bool needsTypeDescriptor)
        {
            needsTypeDescriptor = MutateCSharp.Schemata241.ReplaceBooleanConstant_6(283L, false);
            needsTypeParameter = MutateCSharp.Schemata241.ReplaceBooleanConstant_6(284L, false);
            switch (cl)
            {
                case DatatypeDecl:
                    needsTypeDescriptor = true;
                    break;
                    break;
                case TraitDecl:
                    needsTypeDescriptor = isStatic || lookasideBody;
                    break;
                    break;
                case ClassDecl:
                    needsTypeDescriptor = isStatic;
                    break;
                    break;
            }
        }

        protected override bool DeclareFormal(string prefix, string name, Type type, IToken tok, bool isInParam, ConcreteSyntaxTree wr)
        {
            if (isInParam)
            {
                wr.Write($"{prefix}{name}");
                return MutateCSharp.Schemata241.ReplaceBooleanConstant_6(285L, true);
            }
            else
            {
                return MutateCSharp.Schemata241.ReplaceBooleanConstant_6(286L, false);
            }

            return default;
        }

        protected override void DeclareLocalVar(string name, Type type, IToken tok, bool leaveRoomForRhs, string rhs,
            ConcreteSyntaxTree wr)
        {
            wr.Write(name);
            if (MutateCSharp.Schemata241.ReplaceBinExprOp_16(287L, type, null)) { wr.Write($": {TypeName(type, wr, tok)}"); }
            if (rhs != null) { wr.Write($" = {rhs}"); }
            if (!leaveRoomForRhs)
            {
                wr.WriteLine();
            }
        }

        protected override ConcreteSyntaxTree DeclareLocalVar(string name, Type type, IToken tok, ConcreteSyntaxTree wr)
        {
            var w = new ConcreteSyntaxTree();
            wr.FormatLine($"{name} = {w}");
            return w;
        }

        protected override bool UseReturnStyleOuts(Method m, int nonGhostOutCount) => MutateCSharp.Schemata241.ReplaceBooleanConstant_6(288L, true);
        protected override bool SupportsMultipleReturns => MutateCSharp.Schemata241.ReplaceBooleanConstant_6(289L, true);

        protected override void DeclareLocalOutVar(string name, Type type, IToken tok, string rhs, bool useReturnStyleOuts,
            ConcreteSyntaxTree wr)
        {
            DeclareLocalVar(name, type, tok, MutateCSharp.Schemata241.ReplaceBooleanConstant_6(290L, false), rhs, wr);
        }

        protected override void EmitActualTypeArgs(List<Type> typeArgs, IToken tok, ConcreteSyntaxTree wr)
        {
            // emit nothing
        }

        protected override void EmitPrintStmt(ConcreteSyntaxTree wr, Expression arg)
        {
            var wStmts = wr.Fork();
            wr.Write($"{DafnyRuntimeModule}.print(");
            EmitToString(wr, arg, wStmts);
            wr.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(291L, ")"));
        }

        private void EmitToString(ConcreteSyntaxTree wr, Expression arg, ConcreteSyntaxTree wStmts)
        {
            if (MutateCSharp.Schemata241.ReplaceBinExprOp_4(292L, () => UnicodeCharEnabled, () => DatatypeWrapperEraser.SimplifyTypeAndTrimNewtypes(Options, arg.Type).IsStringType))
            {
                TrParenExpr(arg, wr, MutateCSharp.Schemata241.ReplaceBooleanConstant_6(298L, false), wStmts);
                wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(299L, ".VerbatimString(False)"));
            }
            else
            {
                wr.Write($"{DafnyRuntimeModule}.string_of(");
                wr.Append(Expr(arg, MutateCSharp.Schemata241.ReplaceBooleanConstant_6(300L, false), wStmts));
                wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(301L, ")"));
            }
        }

        protected override void EmitReturn(List<Formal> outParams, ConcreteSyntaxTree wr)
        {
            outParams = outParams.Where(f => !f.IsGhost).ToList();
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(302L, "return"));
            if (MutateCSharp.Schemata241.ReplaceBinExprOp_3(307L, outParams.Count, MutateCSharp.Schemata241.ReplaceNumericConstant_2(303L, 0)))
            {
                wr.Write($" {outParams.Comma(IdName)}");
            }
            wr.WriteLine();
        }

        protected override ConcreteSyntaxTree CreateLabeledCode(string label, bool createContinueLabel, ConcreteSyntaxTree wr)
        {
            var manager = createContinueLabel ? MutateCSharp.Schemata241.ReplaceStringConstant_0(312L, "c_label") : MutateCSharp.Schemata241.ReplaceStringConstant_0(313L, "label");
            var block = wr.NewBlockPy($"with {DafnyRuntimeModule}.{manager}(\"{label}\"):");
            var core = block.Fork();
            block.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(314L, "pass"));
            return core;
        }

        protected override void EmitBreak(string label, ConcreteSyntaxTree wr)
        {
            wr.WriteLine(label != null ? $"raise {DafnyRuntimeModule}.Break(\"{label}\")" : MutateCSharp.Schemata241.ReplaceStringConstant_0(315L, "break"));
        }

        protected override void EmitContinue(string label, ConcreteSyntaxTree wr)
        {
            wr.WriteLine($"raise {DafnyRuntimeModule}.Continue(\"{label}\")");
        }

        protected override void EmitYield(ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(316L, "yield"));
        }

        protected override void EmitAbsurd(string message, ConcreteSyntaxTree wr)
        {
            if (message == null)
            {
                message = MutateCSharp.Schemata241.ReplaceStringConstant_0(317L, "unexpected control point");
            }
            wr.WriteLine($"raise Exception(\"{message}\")");
        }

        protected override void EmitHalt(IToken tok, Expression messageExpr, ConcreteSyntaxTree wr)
        {
            Contract.Requires(tok != null);
            var wStmts = wr.Fork();
            wr.Write($"raise {DafnyRuntimeModule}.HaltException(");
            wr.Write($"\"{tok.TokenToString(Options)}: \" + ");
            EmitToString(wr, messageExpr, wStmts);
            wr.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(318L, ")"));
        }

        protected override ConcreteSyntaxTree EmitIf(out ConcreteSyntaxTree guardWriter, bool hasElse, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(319L, "if "));
            guardWriter = wr.Fork();
            return wr.NewBlockPy(MutateCSharp.Schemata241.ReplaceStringConstant_0(320L, ":"), hasElse ? MutateCSharp.Schemata241.ReplaceStringConstant_0(321L, "el") : "");
        }

        protected override ConcreteSyntaxTree EmitBlock(ConcreteSyntaxTree wr)
        {
            //This encoding does not provide a new scope
            return wr.NewBlockPy(MutateCSharp.Schemata241.ReplaceStringConstant_0(322L, "if True:"));
        }

        protected override ConcreteSyntaxTree EmitForStmt(IToken tok, IVariable loopIndex, bool goingUp, string endVarName,
          List<Statement> body, LList<Label> labels, ConcreteSyntaxTree wr)
        {
            string iterator;
            var lowWr = new ConcreteSyntaxTree();
            string argumentRemainder;
            if (endVarName == null)
            {
                iterator = MutateCSharp.Schemata241.ReplaceStringConstant_0(323L, "count");
                argumentRemainder = goingUp ? "" : MutateCSharp.Schemata241.ReplaceStringConstant_0(324L, "-1, -1");
            }
            else
            {
                iterator = MutateCSharp.Schemata241.ReplaceStringConstant_0(325L, "range");
                argumentRemainder = goingUp ? $", {endVarName}" : $"-1, {endVarName}-1, -1";
            }
            wr.Format($"for {IdName(loopIndex)} in {iterator}({lowWr}{argumentRemainder})");
            var bodyWr = wr.NewBlockPy($":");
            bodyWr = EmitContinueLabel(labels, bodyWr);
            TrStmtList(body, bodyWr);

            return lowWr;
        }

        protected override ConcreteSyntaxTree CreateWhileLoop(out ConcreteSyntaxTree guardWriter, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(326L, "while "));
            guardWriter = wr.Fork();
            var wBody = wr.NewBlockPy(MutateCSharp.Schemata241.ReplaceStringConstant_0(327L, ":"));
            return wBody;
        }

        protected override ConcreteSyntaxTree CreateForLoop(string indexVar, Action<ConcreteSyntaxTree> boundAction, ConcreteSyntaxTree wr, string start = null)
        {
            var lowerBound = start == null ? "" : start + MutateCSharp.Schemata241.ReplaceStringConstant_0(328L, ", ");
            var boundWriter = new ConcreteSyntaxTree();
            boundAction(boundWriter);
            var bound = boundWriter.ToString();
            return wr.NewBlockPy($"for {indexVar} in range({lowerBound}{bound}):");
        }

        protected override ConcreteSyntaxTree CreateDoublingForLoop(string indexVar, int start, ConcreteSyntaxTree wr)
        {
            return wr.NewBlockPy($"for {indexVar} in {DafnyRuntimeModule}.Doubler({start}):");
        }

        protected override void EmitIncrementVar(string varName, ConcreteSyntaxTree wr)
        {
            wr.WriteLine($"{varName} += 1");
        }

        protected override void EmitDecrementVar(string varName, ConcreteSyntaxTree wr)
        {
            wr.WriteLine($"{varName} -= 1");
        }

        protected override string GetQuantifierName(string bvType)
        {
            return $"{DafnyRuntimeModule}.quantifier";
        }

        protected override ConcreteSyntaxTree CreateForeachLoop(string tmpVarName, Type collectionElementType, IToken tok,
          out ConcreteSyntaxTree collectionWriter, ConcreteSyntaxTree wr)
        {
            collectionWriter = new ConcreteSyntaxTree();
            wr.WriteLine($"{tmpVarName}: {TypeName(collectionElementType, wr, tok)}")
              .Format($"for {tmpVarName} in {collectionWriter}:");
            return wr.NewBlockPy();
        }

        protected override void EmitDowncastVariableAssignment(string boundVarName, Type boundVarType, string tmpVarName,
          Type sourceType, bool introduceBoundVar, IToken tok, ConcreteSyntaxTree wr)
        {
            wr.WriteLine($"{boundVarName}{(introduceBoundVar ? $": {TypeName(boundVarType, wr, tok)}" : "")} = {tmpVarName}");
        }

        protected override ConcreteSyntaxTree CreateForeachIngredientLoop(string boundVarName, int L, string tupleTypeArgs,
            out ConcreteSyntaxTree collectionWriter, ConcreteSyntaxTree wr)
        {
            collectionWriter = new ConcreteSyntaxTree();
            return wr.Format($"for {boundVarName} in {collectionWriter}:").NewBlockPy();
        }

        protected override void EmitNew(Type type, IToken tok, CallStmt initCall, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var cl = ((UserDefinedType)type.NormalizeExpand()).ResolvedClass;
            var ctor = (Constructor)initCall?.Method;  // correctness of cast follows from precondition of "EmitNew"
            var sep = "";
            wr.Write($"{TypeName(type, wr, tok)}(");
            EmitTypeDescriptorsActuals(TypeArgumentInstantiation.ListFromClass(cl, type.TypeArgs), tok, wr, ref sep);
            wr.Write(ConstructorArguments(initCall, wStmts, ctor, sep));
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(329L, ")"));
        }

        protected override void EmitNewArray(Type elementType, IToken tok, List<string> dimensions,
          bool mustInitialize, [CanBeNull] string exampleElement, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var initValue = mustInitialize ? DefaultValue(elementType, wr, tok, MutateCSharp.Schemata241.ReplaceBooleanConstant_6(330L, true)) : MutateCSharp.Schemata241.ReplaceStringConstant_0(331L, "None");
            wr.Write($"{DafnyArrayClass}({initValue}, {dimensions.Comma(s => s)})");
        }

        protected static string TranslateEscapes(string s)
        {
            s = Util.ReplaceNullEscapesWithCharacterEscapes(s);

            s = Util.ExpandUnicodeEscapes(s, MutateCSharp.Schemata241.ReplaceBooleanConstant_6(332L, false));

            return s;
        }

        protected override void EmitLiteralExpr(ConcreteSyntaxTree wr, LiteralExpr e)
        {
            switch (e)
            {
                case CharLiteralExpr:
                    var escaped = TranslateEscapes((string)e.Value);
                    if (UnicodeCharEnabled)
                    {
                        wr.Write($"{DafnyRuntimeModule}.CodePoint('{escaped}')");
                    }
                    else
                    {
                        wr.Write($"'{escaped}'");
                    }
                    break;
                    break;
                case StringLiteralExpr str:
                    TrStringLiteral(str, StringLiteralWrapper(wr));
                    break;
                    break;
                case StaticReceiverExpr:
                    wr.Write(TypeName(e.Type, wr, e.tok));
                    break;
                    break;
                default:
                    switch (e.Value)
                    {
                        case null:
                            wr.Write("None");
                            break;
                        case bool value:
                            wr.Write($"{value}");
                            break;
                        case BigInteger integer:
                            wr.Write($"{integer}");
                            break;
                        case BigDec n:
                            wr.Write($"{DafnyRuntimeModule}.BigRational('{n.Mantissa}e{n.Exponent}')");
                            break;
                        default:
                            // TODO: This may not be exhaustive
                            throw new cce.UnreachableException();
                    }
                    break;
                    break;
            }
        }

        private ConcreteSyntaxTree StringLiteralWrapper(ConcreteSyntaxTree wr)
        {
            ConcreteSyntaxTree wrStringGoesHere;
            if (UnicodeCharEnabled)
            {
                wr.Write($"{DafnySeqMakerFunction}(map({DafnyRuntimeModule}.CodePoint, ");
                wrStringGoesHere = wr.Fork();
                wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(333L, "))"));
            }
            else
            {
                wr.Write($"{DafnySeqMakerFunction}(");
                wrStringGoesHere = wr.Fork();
                wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(334L, ")"));
            }
            return wrStringGoesHere;
        }

        protected override void EmitStringLiteral(string str, bool isVerbatim, ConcreteSyntaxTree wr)
        {
            if (!isVerbatim)
            {
                wr.Write($"\"{TranslateEscapes(str)}\"");
            }
            else
            {
                var n = str.Length;
                wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(335L, "\""));
                for (var i = MutateCSharp.Schemata241.ReplaceNumericConstant_2(336L, 0); MutateCSharp.Schemata241.ReplaceBinExprOp_17(340L, i, n); MutateCSharp.Schemata241.ReplacePostfixUnaryExprOp_18(345L, ref i))
                {
                    if (MutateCSharp.Schemata241.ReplaceBinExprOp_4(393L, () => MutateCSharp.Schemata241.ReplaceBinExprOp_4(369L, () => MutateCSharp.Schemata241.ReplaceBinExprOp_19(346L, str[i], '\"'), () => MutateCSharp.Schemata241.ReplaceBinExprOp_17(364L, MutateCSharp.Schemata241.ReplaceBinExprOp_20(355L, i, MutateCSharp.Schemata241.ReplaceNumericConstant_2(351L, 1)), n)), () => MutateCSharp.Schemata241.ReplaceBinExprOp_19(388L, str[MutateCSharp.Schemata241.ReplaceBinExprOp_20(379L, i, MutateCSharp.Schemata241.ReplaceNumericConstant_2(375L, 1))], '\"')))
                    {
                        wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(399L, "\\\""));
                        MutateCSharp.Schemata241.ReplacePostfixUnaryExprOp_18(400L, ref i);
                    }
                    else if (MutateCSharp.Schemata241.ReplaceBinExprOp_19(401L, str[i], '\\'))
                    {
                        wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(406L, "\\\\"));
                    }
                    else if (MutateCSharp.Schemata241.ReplaceBinExprOp_19(407L, str[i], '\n'))
                    {
                        wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(412L, "\\n"));
                    }
                    else if (MutateCSharp.Schemata241.ReplaceBinExprOp_19(413L, str[i], '\r'))
                    {
                        wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(418L, "\\r"));
                    }
                    else
                    {
                        wr.Write(str[i]);
                    }
                }
                wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(419L, "\""));
            }
        }

        protected override ConcreteSyntaxTree EmitBitvectorTruncation(BitvectorType bvType, [CanBeNull] NativeType nativeType,
          bool surroundByUnchecked, ConcreteSyntaxTree wr)
        {
            var vec = wr.ForkInParens();
            wr.Write($" & ((1 << {bvType.Width}) - 1)");
            return vec;
        }

        protected override void EmitRotate(Expression e0, Expression e1, bool isRotateLeft, ConcreteSyntaxTree wr,
            bool inLetExprBody, ConcreteSyntaxTree wStmts, FCE_Arg_Translator tr)
        {
            // (( e0 op1 e1) | (e0 op2 (width - e1)))
            wr = wr.ForkInParens();
            EmitShift(e0, e1, isRotateLeft ? MutateCSharp.Schemata241.ReplaceStringConstant_0(420L, "<<") : MutateCSharp.Schemata241.ReplaceStringConstant_0(421L, ">>"), isRotateLeft, MutateCSharp.Schemata241.ReplaceBooleanConstant_6(422L, true), wr.ForkInParens(), inLetExprBody, wStmts, tr);
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(423L, " | "));
            EmitShift(e0, e1, isRotateLeft ? MutateCSharp.Schemata241.ReplaceStringConstant_0(424L, ">>") : MutateCSharp.Schemata241.ReplaceStringConstant_0(425L, "<<"), !isRotateLeft, MutateCSharp.Schemata241.ReplaceBooleanConstant_6(426L, false), wr.ForkInParens(), inLetExprBody, wStmts, tr);
        }

        void EmitShift(Expression e0, Expression e1, string op, bool truncate, bool firstOp, ConcreteSyntaxTree wr,
            bool inLetExprBody, ConcreteSyntaxTree wStmts, FCE_Arg_Translator tr)
        {
            var bv = e0.Type.NormalizeToAncestorType().AsBitVectorType;
            if (truncate)
            {
                wr = EmitBitvectorTruncation(bv, null, MutateCSharp.Schemata241.ReplaceBooleanConstant_6(427L, true), wr);
            }
            tr(e0, wr, inLetExprBody, wStmts);
            wr.Write($" {op} ");
            if (!firstOp)
            {
                wr = wr.ForkInParens().Write($"{bv.Width} - ");
            }

            tr(e1, wr.ForkInParens(), inLetExprBody, wStmts);
        }

        protected override void EmitEmptyTupleList(string tupleTypeArgs, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(428L, "[]"));
        }

        protected override ConcreteSyntaxTree EmitAddTupleToList(string ingredients, string tupleTypeArgs, ConcreteSyntaxTree wr)
        {
            var wrTuple = new ConcreteSyntaxTree();
            wr.FormatLine($"{ingredients}.append(({wrTuple}))");
            return wrTuple;
        }

        protected override void EmitTupleSelect(string prefix, int i, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(429L, "{0}[{1}]"), prefix, i);
        }

        protected override string IdProtect(string name)
        {
            return PublicIdProtect(name);
        }

        public override string PublicIdProtect(string name)
        {
            Contract.Requires(name != null);
            return name switch
            {
                _ => MangleName(name)
            };
        }

        protected override string FullTypeName(UserDefinedType udt, MemberDecl member = null)
        {
            if (udt is ArrowType)
            {
                //TODO: Add deeper types
                return MutateCSharp.Schemata241.ReplaceStringConstant_0(430L, "Callable");
            }

            var cl = udt.ResolvedClass;
            return cl switch
            {
                TypeParameter => $"TypeVar(\'{IdProtect(cl.GetCompileName(Options))}\')",
                ArrayClassDecl => DafnyArrayClass,
                TupleTypeDecl => MutateCSharp.Schemata241.ReplaceStringConstant_0(431L, "tuple"),
                _ => FullName(cl)
            };
        }

        protected override void EmitThis(ConcreteSyntaxTree wr, bool callToInheritedMember)
        {
            var isTailRecursive = MutateCSharp.Schemata241.ReplaceBinExprOp_5(432L, () => enclosingMethod is { IsTailRecursive: true }, () => enclosingFunction is { IsTailRecursive: true });
            wr.Write(isTailRecursive ? MutateCSharp.Schemata241.ReplaceStringConstant_0(438L, "_this") : MutateCSharp.Schemata241.ReplaceStringConstant_0(439L, "self"));
        }

        protected override void EmitNull(Type _, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(440L, "None"));
        }

        protected override void EmitDatatypeValue(DatatypeValue dtv, string typeDescriptorArguments, string arguments, ConcreteSyntaxTree wr)
        {
            EmitDatatypeValue(dtv.Ctor.EnclosingDatatype, dtv.Ctor, dtv.IsCoCall, typeDescriptorArguments, arguments, wr);
        }

        void EmitDatatypeValue(DatatypeDecl dt, DatatypeCtor ctor, bool isCoCall, string typeDescriptorArguments, string arguments,
          ConcreteSyntaxTree wr, bool qualifiedName = true)
        {
            if (isCoCall)
            {
                wr.Write($"{FullName(dt)}__Lazy(lambda: ");
                var end = wr.Fork();
                wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(441L, ")"));
                wr = end;
            }
            if (dt is not TupleTypeDecl)
            {
                wr.Write($"{DtCtorDeclarationName(ctor, MutateCSharp.Schemata241.ReplaceBinExprOp_21(442L, dt.EnclosingModuleDefinition, enclosingModule))}");
            }
            else if (MutateCSharp.Schemata241.ReplaceBinExprOp_19(447L, ctor.Destructors.Count(d => !d.IsGhost), MutateCSharp.Schemata241.ReplaceNumericConstant_2(443L, 1)))
            {
                // 1-tuples need this this for disambiguation
                arguments += MutateCSharp.Schemata241.ReplaceStringConstant_0(452L, ",");
            }
            var sep = MutateCSharp.Schemata241.ReplaceBinExprOp_4(471L, () => MutateCSharp.Schemata241.ReplaceBinExprOp_9(457L, typeDescriptorArguments.Length, MutateCSharp.Schemata241.ReplaceNumericConstant_2(453L, 0)), () => MutateCSharp.Schemata241.ReplaceBinExprOp_9(466L, arguments.Length, MutateCSharp.Schemata241.ReplaceNumericConstant_2(462L, 0))) ? MutateCSharp.Schemata241.ReplaceStringConstant_0(477L, ", ") : "";
            wr.Write($"({typeDescriptorArguments}{sep}{arguments})");
        }

        protected override void GetSpecialFieldInfo(SpecialField.ID id, object idParam, Type receiverType,
            out string compiledName, out string preString, out string postString)
        {
            compiledName = "";
            preString = "";
            postString = "";
            switch (id)
            {
                case SpecialField.ID.UseIdParam:
                    compiledName = IdProtect((string)idParam);
                    break;
                    break;
                case SpecialField.ID.Keys:
                    compiledName = "keys";
                    break;
                    break;
                case SpecialField.ID.Values:
                    compiledName = "values";
                    break;
                    break;
                case SpecialField.ID.Items:
                    compiledName = "items";
                    break;
                    break;
                case SpecialField.ID.Floor:
                    preString = "floor(";
                    postString = ")";
                    break;
                    break;
                case SpecialField.ID.IsLimit:
                    preString = $"{DafnyRuntimeModule}.BigOrdinal.is_limit(";
                    postString = ")";
                    break;
                    break;
                case SpecialField.ID.IsSucc:
                    preString = $"{DafnyRuntimeModule}.BigOrdinal.is_succ(";
                    postString = ")";
                    break;
                    break;
                case SpecialField.ID.Offset:
                    preString = $"{DafnyRuntimeModule}.BigOrdinal.offset(";
                    postString = ")";
                    break;
                    break;
                case SpecialField.ID.IsNat:
                    preString = $"{DafnyRuntimeModule}.BigOrdinal.is_nat(";
                    postString = ")";
                    break;
                    break;
                case SpecialField.ID.ArrayLength:
                case SpecialField.ID.ArrayLengthInt:
                    var dim = idParam is int d and > 0 ? d : 0;
                    compiledName = $"length({dim})";
                    break;
                    break;
                default:
                    Contract.Assert(false); // unexpected ID
                    break;
                    break;
            }
        }

        protected override ILvalue EmitMemberSelect(Action<ConcreteSyntaxTree> obj, Type objType, MemberDecl member,
          List<TypeArgumentInstantiation> typeArgs, Dictionary<TypeParameter, Type> typeMap, Type expectedType,
          string additionalCustomParameter = null, bool internalAccess = false)
        {
            switch (DatatypeWrapperEraser.GetMemberStatus(Options, member))
            {
                case DatatypeWrapperEraser.MemberCompileStatus.Identity:
                    return SimpleLvalue(obj);
                    break;
                case DatatypeWrapperEraser.MemberCompileStatus.AlwaysTrue:
                    return StringLvalue(True);
                    break;
                default:
                    break;
                    break;
            }
            switch (member)
            {
                case DatatypeDestructor dd:
                    {
                        var dest = dd.EnclosingClass switch
                        {
                            TupleTypeDecl => $"[{dd.CorrespondingFormals[0].NameForCompilation}]",
                            _ => $".{IdProtect(dd.GetCompileName(Options))}"
                        };
                        return SuffixLvalue(obj, dest);
                    }

                    break;
                case SpecialField sf:
                    {
                        GetSpecialFieldInfo(sf.SpecialId, sf.IdParam, objType, out var compiledName, out _, out _);
                        return SimpleLvalue(w =>
                        {
                            var customReceiver = NeedsCustomReceiver(sf) && sf.EnclosingClass is not TraitDecl;
                            if (sf.IsStatic || customReceiver)
                            {
                                w.Write(TypeName_Companion(objType, w, member.tok, member));
                            }
                            else
                            {
                                obj(w);
                            }
                            if (compiledName.Length > 0)
                            {
                                w.Write($".{(sf is ConstantField && internalAccess ? "_" : "")}{compiledName}");
                            }
                            var sep = "(";
                            EmitTypeDescriptorsActuals(ForTypeDescriptors(typeArgs, member.EnclosingClass, member, false), member.tok, w, ref sep);
                            if (customReceiver)
                            {
                                w.Write(sep);
                                obj(w);
                                sep = ", ";
                            }
                            if (sep != "(")
                            {
                                w.Write(")");
                            }
                        });
                    }

                    break;
                case Field:
                    {
                        return SimpleLvalue(w =>
                        {
                            if (member.IsStatic) { w.Write(TypeName_Companion(objType, w, member.tok, member)); } else { obj(w); }
                            w.Write($".{IdName(member)}");
                        });
                    }

                    break;
                case Function fn:
                    {
                        if (additionalCustomParameter == null && typeArgs.Count == 0)
                        {
                            return SuffixLvalue(obj, $".{IdName(fn)}");
                        }
                        return SimpleLvalue(w =>
                        {
                            var args = fn.Ins
                              .Where(f => !f.IsGhost)
                              .Select(_ => ProtectedFreshId("_eta"))
                              .Comma();
                            w.Write($"lambda {args}: ");
                            obj(w);
                            w.Write($".{IdName(fn)}(");
                            var sep = "";
                            EmitTypeDescriptorsActuals(ForTypeDescriptors(typeArgs, member.EnclosingClass, member, false), fn.tok, w, ref sep);
                            if (additionalCustomParameter != null)
                            {
                                w.Write(sep + additionalCustomParameter);
                                sep = ", ";
                            }
                            if (args.Length > 0)
                            {
                                w.Write(sep);
                            }
                            w.Write(args + ")");
                        });
                    }

                    break;
                default:
                    return SimpleLvalue(w =>
                    {
                        w.Write($"{TypeName_Companion(objType, w, member.tok, member)}.{IdName(member)}({additionalCustomParameter ?? ""})");
                    });
                    break;
            }

            return default;
        }

        protected override ConcreteSyntaxTree EmitArraySelect(List<Action<ConcreteSyntaxTree>> indices, Type elmtType, ConcreteSyntaxTree wr)
        {
            Contract.Assert(indices is { Count: >= 1 });
            var w = wr.Fork();
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(478L, "["));
            for (var i = MutateCSharp.Schemata241.ReplaceNumericConstant_2(479L, 0); MutateCSharp.Schemata241.ReplaceBinExprOp_17(483L, i, indices.Count); MutateCSharp.Schemata241.ReplacePostfixUnaryExprOp_18(488L, ref i))
            {
                if (MutateCSharp.Schemata241.ReplaceBinExprOp_3(493L, i, MutateCSharp.Schemata241.ReplaceNumericConstant_2(489L, 0)))
                {
                    wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(498L, ", "));
                }
                indices[i](wr);
            }
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(499L, "]"));
            return w;
        }

        protected override ConcreteSyntaxTree EmitArraySelect(List<Expression> indices, Type elmtType, bool inLetExprBody,
            ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            Contract.Assert(indices != null);  // follows from precondition
            var strings = indices.Select<Expression, Action<ConcreteSyntaxTree>>(index => wr => EmitExpr(index, inLetExprBody, wr, wStmts));
            return EmitArraySelect(strings.ToList(), elmtType, wr);
        }

        protected override void EmitExprAsNativeInt(Expression expr, bool inLetExprBody, ConcreteSyntaxTree wr,
          ConcreteSyntaxTree wStmts)
        {
            // This is also used for bit shift operators, or more generally any binary operation where CompileBinOp()
            // sets the convertE1_to_int out parameter to true. This compiler always sets that to false, however,
            // so this method is only called for non-sequentializable forall statements.
            TrParenExpr(MutateCSharp.Schemata241.ReplaceStringConstant_0(500L, "int"), expr, wr, inLetExprBody, wStmts);
        }

        protected override void EmitIndexCollectionSelect(Expression source, Expression index, bool inLetExprBody,
          ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            TrParenExpr(source, wr, inLetExprBody, wStmts);
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(501L, "["));
            wr.Append(Expr(index, inLetExprBody, wStmts));
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(502L, "]"));
        }

        protected override void EmitIndexCollectionUpdate(Expression source, Expression index, Expression value,
          CollectionType resultCollectionType, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            TrParenExpr(source, wr, inLetExprBody, wStmts);
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(503L, ".set("));
            wr.Append(Expr(index, inLetExprBody, wStmts));
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(504L, ", "));
            wr.Append(CoercedExpr(value, resultCollectionType.ValueArg, inLetExprBody, wStmts));
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(505L, ")"));
        }

        protected override void EmitSeqSelectRange(Expression source, Expression lo, Expression hi, bool fromArray,
          bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write($"{DafnySeqMakerFunction}(");
            TrParenExpr(source, wr, inLetExprBody, wStmts);
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(506L, "["));
            if (MutateCSharp.Schemata241.ReplaceBinExprOp_22(507L, lo, null)) { wr.Append(Expr(lo, inLetExprBody, wStmts)); }
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(508L, ":"));
            if (MutateCSharp.Schemata241.ReplaceBinExprOp_22(509L, hi, null)) { wr.Append(Expr(hi, inLetExprBody, wStmts)); }

            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(510L, ":])"));
        }

        protected override void EmitSeqConstructionExpr(SeqConstructionExpr expr, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            ConcreteSyntaxTree valueExpression;
            var range = $"range({Expr(expr.N, inLetExprBody, wStmts)})";
            wr.Write(DafnySeqMakerFunction);
            if (expr.Initializer is LambdaExpr lam)
            {
                valueExpression = Expr(lam.Body, inLetExprBody, wStmts);
                var binder = IdProtect(lam.BoundVars[MutateCSharp.Schemata241.ReplaceNumericConstant_2(511L, 0)].CompileName);
                wr.Write($"([{valueExpression} for {binder} in {range}])");
            }
            else
            {
                valueExpression = Expr(expr.Initializer, inLetExprBody, wStmts);
                wr.Write($"(tuple(map({valueExpression}, {range})))");
            }
        }

        protected override void EmitMultiSetFormingExpr(MultiSetFormingExpr expr, bool inLetExprBody, ConcreteSyntaxTree wr,
          ConcreteSyntaxTree wStmts)
        {
            TrParenExpr(DafnyMultiSetClass, expr.E, wr, inLetExprBody, wStmts);
        }

        protected override void EmitApplyExpr(Type functionType, IToken tok, Expression function,
            List<Expression> arguments, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Append(Expr(function, inLetExprBody, wStmts));
            TrExprList(arguments, wr, inLetExprBody, wStmts);
        }

        protected override ConcreteSyntaxTree EmitBetaRedex(List<string> boundVars, List<Expression> arguments,
          List<Type> boundTypes, Type resultType, IToken resultTok, bool inLetExprBody, ConcreteSyntaxTree wr,
          ref ConcreteSyntaxTree wStmts)
        {
            var functionName = ProtectedFreshId(MutateCSharp.Schemata241.ReplaceStringConstant_0(515L, "_lambda"));
            wr.Write($"{functionName}");
            TrExprList(arguments, wr, inLetExprBody, wStmts);
            var wrBody = wStmts.NewBlockPy($"def {functionName}({boundVars.Comma()}):", close: BlockStyle.Newline);
            wStmts = wrBody.Fork();
            return EmitReturnExpr(wrBody);
        }

        protected override void EmitDestructor(Action<ConcreteSyntaxTree> source, Formal dtor, int formalNonGhostIndex, DatatypeCtor ctor,
            List<Type> typeArgs, Type bvType, ConcreteSyntaxTree wr)
        {
            source(wr);
            if (DatatypeWrapperEraser.IsErasableDatatypeWrapper(Options, ctor.EnclosingDatatype, out var coreDtor))
            {
                Contract.Assert(coreDtor.CorrespondingFormals.Count == 1);
                Contract.Assert(dtor == coreDtor.CorrespondingFormals[0]); // any other destructor is a ghost
            }
            else
            {
                wr.Write(ctor.EnclosingDatatype is TupleTypeDecl ? $"[{dtor.NameForCompilation}]" : $".{IdProtect(dtor.CompileName)}");
            }
        }

        protected override ConcreteSyntaxTree CreateLambda(List<Type> inTypes, IToken tok, List<string> inNames,
            Type resultType, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts, bool untyped = false)
        {
            var functionName = ProtectedFreshId(MutateCSharp.Schemata241.ReplaceStringConstant_0(516L, "_lambda"));
            wr.Write(functionName);
            return wStmts.NewBlockPy($"def {functionName}({inNames.Comma()}):", close: BlockStyle.Newline);
        }

        protected override void CreateIIFE(string bvName, Type bvType, IToken bvTok, Type bodyType, IToken bodyTok,
          ConcreteSyntaxTree wr, ref ConcreteSyntaxTree wStmts, out ConcreteSyntaxTree wrRhs, out ConcreteSyntaxTree wrBody)
        {
            wrRhs = new ConcreteSyntaxTree();
            var functionName = ProtectedFreshId(MutateCSharp.Schemata241.ReplaceStringConstant_0(517L, "_iife"));
            wr.Format($"{functionName}({wrRhs})");
            wrBody = wStmts.NewBlockPy($"def {functionName}({bvName}):");
            wStmts = wrBody.Fork();
            wrBody = EmitReturnExpr(wrBody);
        }

        protected override ConcreteSyntaxTree CreateIIFE0(Type resultType, IToken resultTok, ConcreteSyntaxTree wr,
            ConcreteSyntaxTree wStmts)
        {
            var functionName = ProtectedFreshId(MutateCSharp.Schemata241.ReplaceStringConstant_0(518L, "_iife"));
            wr.WriteLine($"{functionName}()");
            return wStmts.NewBlockPy($"def {functionName}():");
        }

        protected override ConcreteSyntaxTree CreateIIFE1(int source, Type resultType, IToken resultTok, string bvName,
            ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var functionName = ProtectedFreshId(MutateCSharp.Schemata241.ReplaceStringConstant_0(519L, "_iife"));
            wr.WriteLine($"{functionName}({source})");
            return wStmts.NewBlockPy($"def {functionName}({bvName}):");
        }

        protected override ConcreteSyntaxTree FromFatPointer(Type type, ConcreteSyntaxTree wr)
        {
            if (type.HasFatPointer)
            {
                var w = wr.ForkInParens();
                wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(520L, "._value"));
                return w;
            }
            else
            {
                return wr;
            }

            return default;
        }

        protected override ConcreteSyntaxTree ToFatPointer(Type type, ConcreteSyntaxTree wr)
        {
            if (type.HasFatPointer)
            {
                wr.Write(FullName(type.AsNewtype));
                return wr.ForkInParens();
            }
            else
            {
                return wr;
            }

            return default;
        }

        protected override void EmitUnaryExpr(ResolvedUnaryOp op, Expression expr, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            switch (op)
            {
                case ResolvedUnaryOp.Cardinality:
                    var multiset = expr.Type.NormalizeToAncestorType().AsMultiSetType != null;
                    if (!multiset) { wr.Write("len"); }
                    TrParenExpr(expr, wr, inLetExprBody, wStmts);
                    if (multiset) { wr.Write(".cardinality"); }
                    break;
                    break;
                case ResolvedUnaryOp.BitwiseNot:
                    TrParenExpr("~", expr, wr, inLetExprBody, wStmts);
                    break;
                    break;
                case ResolvedUnaryOp.BoolNot:
                    TrParenExpr("not", expr, wr, inLetExprBody, wStmts);
                    break;
                    break;
                default:
                    Contract.Assert(false); throw new cce.UnreachableException();  // unexpected unary expression
                    break;
            }
        }

        protected override void CompileBinOp(BinaryExpr.ResolvedOpcode op,
          Expression e0, Expression e1, IToken tok, Type resultType,
          out string opString,
          out string preOpString,
          out string postOpString,
          out string callString,
          out string staticCallString,
          out bool reverseArguments,
          out bool truncateResult,
          out bool convertE1_to_int,
          out bool coerceE1,
          ConcreteSyntaxTree errorWr)
        {

            opString = null;
            preOpString = "";
            postOpString = "";
            callString = null;
            staticCallString = null;
            reverseArguments = MutateCSharp.Schemata241.ReplaceBooleanConstant_6(521L, false);
            truncateResult = MutateCSharp.Schemata241.ReplaceBooleanConstant_6(522L, false);
            convertE1_to_int = MutateCSharp.Schemata241.ReplaceBooleanConstant_6(523L, false);
            coerceE1 = MutateCSharp.Schemata241.ReplaceBooleanConstant_6(524L, false);

            switch (op)
            {
                case BinaryExpr.ResolvedOpcode.And:
                    opString = "and";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Or:
                    opString = "or";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Imp:
                    preOpString = "not ";
                    opString = "or";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.LeftShift:
                    opString = "<<";
                    truncateResult = true;
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.RightShift:
                    opString = ">>";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Concat:
                    opString = "+";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Add:
                    if (resultType.IsCharType && !UnicodeCharEnabled)
                    {
                        staticCallString = $"{DafnyRuntimeModule}.plus_char";
                    }
                    else
                    {
                        opString = "+";
                        truncateResult = true;
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Sub:
                case BinaryExpr.ResolvedOpcode.SetDifference:
                case BinaryExpr.ResolvedOpcode.MultiSetDifference:
                case BinaryExpr.ResolvedOpcode.MapSubtraction:
                    if (resultType.IsCharType && !UnicodeCharEnabled)
                    {
                        staticCallString = $"{DafnyRuntimeModule}.minus_char";
                    }
                    else
                    {
                        opString = "-";
                        truncateResult = true;
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Mul:
                    opString = "*";
                    truncateResult = true;
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Div:
                    if (resultType.IsNumericBased(Type.NumericPersuasion.Int) || resultType.NormalizeToAncestorType().IsBitVectorType)
                    {
                        staticCallString = $"{DafnyRuntimeModule}.euclidian_division";
                    }
                    else
                    {
                        opString = "/";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Mod:
                    staticCallString = $"{DafnyRuntimeModule}.euclidian_modulus"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.ProperPrefix:
                    opString = "<"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Prefix:
                    opString = "<="; break;
                    break;
                case BinaryExpr.ResolvedOpcode.SeqEq:
                case BinaryExpr.ResolvedOpcode.SetEq:
                case BinaryExpr.ResolvedOpcode.MapEq:
                case BinaryExpr.ResolvedOpcode.EqCommon:
                case BinaryExpr.ResolvedOpcode.MultiSetEq:
                    opString = "=="; break;
                    break;
                case BinaryExpr.ResolvedOpcode.NeqCommon:
                case BinaryExpr.ResolvedOpcode.SeqNeq:
                case BinaryExpr.ResolvedOpcode.SetNeq:
                case BinaryExpr.ResolvedOpcode.MapNeq:
                case BinaryExpr.ResolvedOpcode.MultiSetNeq:
                    opString = "!="; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Union:
                case BinaryExpr.ResolvedOpcode.MultiSetUnion:
                case BinaryExpr.ResolvedOpcode.MapMerge:
                    opString = "|"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.InSet:
                case BinaryExpr.ResolvedOpcode.InMultiSet:
                case BinaryExpr.ResolvedOpcode.InSeq:
                case BinaryExpr.ResolvedOpcode.InMap:
                    opString = "in"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.NotInSet:
                case BinaryExpr.ResolvedOpcode.NotInMultiSet:
                case BinaryExpr.ResolvedOpcode.NotInSeq:
                case BinaryExpr.ResolvedOpcode.NotInMap:
                    opString = "not in"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Intersection:
                case BinaryExpr.ResolvedOpcode.MultiSetIntersection:
                    callString = "intersection"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Disjoint:
                case BinaryExpr.ResolvedOpcode.MultiSetDisjoint:
                    callString = "isdisjoint"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Subset:
                case BinaryExpr.ResolvedOpcode.MultiSubset:
                    callString = "issubset"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.ProperSubset:
                case BinaryExpr.ResolvedOpcode.ProperMultiSubset:
                    callString = "ispropersubset"; break;
                    break;
                default:
                    base.CompileBinOp(op, e0, e1, tok, resultType,
                      out opString, out preOpString, out postOpString, out callString, out staticCallString, out reverseArguments,
                      out truncateResult, out convertE1_to_int, out coerceE1,
                      errorWr);
                    break;
                    break;
            }
        }

        protected override void TrStmtList(List<Statement> stmts, ConcreteSyntaxTree writer)
        {
            Contract.Requires(cce.NonNullElements(stmts));
            Contract.Requires(writer != null);
            var listWriter = new ConcreteSyntaxTree();
            base.TrStmtList(stmts, listWriter);
            if (listWriter.Descendants.OfType<LineSegment>().Any())
            {
                writer.Append(listWriter);
            }
            else
            {
                writer.WriteLine(MutateCSharp.Schemata241.ReplaceStringConstant_0(525L, "pass"));
            }
        }

        protected override void EmitITE(Expression guard, Expression thn, Expression els, Type resultType, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            Contract.Requires(guard != null);
            Contract.Requires(thn != null);
            Contract.Requires(els != null);
            Contract.Requires(wr != null);

            ConcreteSyntaxTree Tree(Expression e) => Expr(e, inLetExprBody, wStmts);

            wr.Format($"({Tree(thn)} if {Tree(guard)} else {Tree(els)})");
        }

        protected override void EmitIsZero(string varName, ConcreteSyntaxTree wr)
        {
            wr.Write($"{varName} == 0");
        }

        protected override void EmitConversionExpr(Expression fromExpr, Type fromType, Type toType, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var (pre, post) = ("", "");
            if (MutateCSharp.Schemata241.ReplaceBinExprOp_5(532L, () => MutateCSharp.Schemata241.ReplaceBinExprOp_5(526L, () => fromType.IsNumericBased(Type.NumericPersuasion.Int), () => fromType.NormalizeToAncestorType().IsBitVectorType), () => fromType.IsBigOrdinalType))
            {
                if (toType.IsNumericBased(Type.NumericPersuasion.Real))
                {
                    (pre, post) = ($"{DafnyRuntimeModule}.BigRational(", MutateCSharp.Schemata241.ReplaceStringConstant_0(538L, ", 1)"));
                }
                else if (toType.IsCharType)
                {
                    if (UnicodeCharEnabled)
                    {
                        (pre, post) = ($"{DafnyRuntimeModule}.CodePoint(chr(", MutateCSharp.Schemata241.ReplaceStringConstant_0(539L, "))"));
                    }
                    else
                    {
                        (pre, post) = (MutateCSharp.Schemata241.ReplaceStringConstant_0(540L, "chr("), MutateCSharp.Schemata241.ReplaceStringConstant_0(541L, ")"));
                    }
                }
            }
            else if (fromType.IsCharType)
            {
                if (toType.IsCharType)
                {
                    // nothing to do
                }
                else if (MutateCSharp.Schemata241.ReplaceBinExprOp_5(548L, () => MutateCSharp.Schemata241.ReplaceBinExprOp_5(542L, () => toType.IsNumericBased(Type.NumericPersuasion.Int), () => toType.NormalizeToAncestorType().IsBitVectorType), () => toType.IsBigOrdinalType))
                {
                    (pre, post) = (MutateCSharp.Schemata241.ReplaceStringConstant_0(554L, "ord("), MutateCSharp.Schemata241.ReplaceStringConstant_0(555L, ")"));
                }
                else if (toType.IsNumericBased(Type.NumericPersuasion.Real))
                {
                    (pre, post) = ($"{DafnyRuntimeModule}.BigRational(ord(", MutateCSharp.Schemata241.ReplaceStringConstant_0(556L, "), 1)"));
                }
            }
            else if (fromType.IsNumericBased(Type.NumericPersuasion.Real))
            {
                if (MutateCSharp.Schemata241.ReplaceBinExprOp_5(563L, () => MutateCSharp.Schemata241.ReplaceBinExprOp_5(557L, () => toType.IsNumericBased(Type.NumericPersuasion.Int), () => toType.NormalizeToAncestorType().IsBitVectorType), () => toType.IsBigOrdinalType))
                {
                    (pre, post) = (MutateCSharp.Schemata241.ReplaceStringConstant_0(569L, "int("), MutateCSharp.Schemata241.ReplaceStringConstant_0(570L, ")"));
                }
                else if (toType.IsCharType)
                {
                    if (UnicodeCharEnabled)
                    {
                        (pre, post) = ($"{DafnyRuntimeModule}.CodePoint(chr(floor(", MutateCSharp.Schemata241.ReplaceStringConstant_0(571L, ")))"));
                    }
                    else
                    {
                        (pre, post) = (MutateCSharp.Schemata241.ReplaceStringConstant_0(572L, "chr(floor("), MutateCSharp.Schemata241.ReplaceStringConstant_0(573L, "))"));
                    }
                }
            }
            wr.Write(pre);
            wr.Append(Expr(fromExpr, inLetExprBody, wStmts));
            wr.Write(post);
        }

        protected override void EmitTypeTest(string localName, Type fromType, Type toType, IToken tok, ConcreteSyntaxTree wr)
        {
            if (MutateCSharp.Schemata241.ReplaceBinExprOp_4(574L, () => fromType.IsRefType, () => !fromType.IsNonNullRefType))
            {
                Contract.Assert(toType.IsRefType);
                wr = wr.Write($"{localName} is {(toType.IsNonNullRefType ? MutateCSharp.Schemata241.ReplaceStringConstant_0(580L, "not None and") : MutateCSharp.Schemata241.ReplaceStringConstant_0(581L, "None or"))} ").ForkInParens();
            }

            if (MutateCSharp.Schemata241.ReplaceBinExprOp_4(583L, () => fromType.IsTraitType, () => MutateCSharp.Schemata241.ReplaceBinExprOp_12(582L, toType.AsNewtype, null)))
            {
                wr.Write($"isinstance({localName}, {FullName(toType.AsNewtype)})");
            }
            else
            {
                wr.Write($"isinstance({localName}, {TypeName(toType, wr, tok)})");
            }
        }

        protected override void EmitIsIntegerTest(Expression source, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            EmitExpr(source, MutateCSharp.Schemata241.ReplaceBooleanConstant_6(589L, false), wr.ForkInParens(), wStmts);
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(590L, ".is_integer() and "));
        }

        protected override void EmitIsUnicodeScalarValueTest(Expression source, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(591L, "_dafny.CodePoint.is_code_point"));
            EmitExpr(source, MutateCSharp.Schemata241.ReplaceBooleanConstant_6(592L, false), wr.ForkInParens(), wStmts);
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(593L, " and "));
        }

        protected override void EmitIsInIntegerRange(Expression source, BigInteger lo, BigInteger hi, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            EmitLiteralExpr(wr, new LiteralExpr(source.tok, lo) { Type = Type.Int });
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(594L, " <= "));
            EmitExpr(source, MutateCSharp.Schemata241.ReplaceBooleanConstant_6(595L, false), wr.ForkInParens(), wStmts);
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(596L, " and "));

            EmitExpr(source, MutateCSharp.Schemata241.ReplaceBooleanConstant_6(597L, false), wr.ForkInParens(), wStmts);
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(598L, " < "));
            EmitLiteralExpr(wr, new LiteralExpr(source.tok, hi) { Type = Type.Int });
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(599L, " and "));
        }

        protected override void EmitCollectionDisplay(CollectionType ct, IToken tok, List<Expression> elements,
          bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var (open, close) = ct switch
            {
                SeqType or MultiSetType => (MutateCSharp.Schemata241.ReplaceStringConstant_0(600L, "["), MutateCSharp.Schemata241.ReplaceStringConstant_0(601L, "]")),
                _ => (MutateCSharp.Schemata241.ReplaceStringConstant_0(602L, "{"), MutateCSharp.Schemata241.ReplaceStringConstant_0(603L, "}"))
            };
            wr.Write(ct is SeqType ? DafnySeqMakerFunction : TypeHelperName(ct));
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(604L, "("));
            wr.Write(open);
            TrExprList(elements, wr, inLetExprBody, wStmts, typeAt: _ => ct.Arg, parens: MutateCSharp.Schemata241.ReplaceBooleanConstant_6(605L, false));
            wr.Write(close);
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(606L, ")"));
        }

        private static string TypeHelperName(Type ct)
        {
            return ct switch
            {
                SetType => DafnySetClass,
                SeqType => DafnySeqClass,
                MapType => DafnyMapClass,
                MultiSetType => DafnyMultiSetClass,
                _ => throw new NotImplementedException()
            };
        }

        protected override void EmitMapDisplay(MapType mt, IToken tok, List<ExpressionPair> elements, bool inLetExprBody,
          ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write($"{DafnyMapClass}({{");
            var sep = "";
            foreach (var p in elements)
            {
                wr.Write(sep);
                wr.Append(Expr(p.A, inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(607L, ": "));
                wr.Append(Expr(p.B, inLetExprBody, wStmts));
                sep = MutateCSharp.Schemata241.ReplaceStringConstant_0(608L, ", ");
            }
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(609L, "})"));
        }

        protected override void EmitSetBuilder_New(ConcreteSyntaxTree wr, SetComprehension e, string collectionName)
        {
            wr.WriteLine($"{collectionName} = {DafnySetClass}()");
        }

        protected override void EmitMapBuilder_New(ConcreteSyntaxTree wr, MapComprehension e, string collectionName)
        {
            wr.WriteLine($"{collectionName} = {DafnyMapClass}()");
        }

        protected override void EmitSetBuilder_Add(CollectionType ct, string collName, Expression elmt, bool inLetExprBody,
            ConcreteSyntaxTree wr)
        {
            var wStmts = wr.Fork();
            wr.WriteLine($"{collName} = {collName}.union({DafnySetClass}([{Expr(elmt, inLetExprBody, wStmts)}]))");
        }

        protected override ConcreteSyntaxTree EmitMapBuilder_Add(MapType mt, IToken tok, string collName, Expression term,
            bool inLetExprBody, ConcreteSyntaxTree wr)
        {
            var termLeftWriter = new ConcreteSyntaxTree();
            var wStmts = wr.Fork();
            wr.FormatLine($"{collName}[{termLeftWriter}] = {Expr(term, inLetExprBody, wStmts)}");
            return termLeftWriter;
        }

        [CanBeNull]
        protected override Action<ConcreteSyntaxTree> GetSubtypeCondition(string tmpVarName, Type boundVarType, IToken tok, ConcreteSyntaxTree wPreconditions)
        {
            if (!boundVarType.IsRefType)
            {
                return null;
            }

            var typeTest = MutateCSharp.Schemata241.ReplaceBinExprOp_5(610L, () => boundVarType.IsObject, () => boundVarType.IsObjectQ
      ) ? True
              : $"isinstance({tmpVarName}, {TypeName(boundVarType, wPreconditions, tok)})";
            return wr => wr.Write(boundVarType.IsNonNullRefType
              ? $"{tmpVarName} is not None and {typeTest}"
              : $"{tmpVarName} is None or {typeTest}");
        }

        protected override void GetCollectionBuilder_Build(CollectionType ct, IToken tok, string collName,
          ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmt)
        {
            wr.Write(TypeHelperName(ct) + $"({collName})");
        }

        protected override (Type, Action<ConcreteSyntaxTree>) EmitIntegerRange(Type type, Action<ConcreteSyntaxTree> wLo, Action<ConcreteSyntaxTree> wHi)
        {
            return (new IntType(), (wr) =>
            {
                wr.Write($"{DafnyRuntimeModule}.IntegerRange(");
                wLo(wr);
                wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(616L, ", "));
                wHi(wr);
                wr.Write(')');
            }
            );
        }

        protected override void EmitSingleValueGenerator(Expression e, bool inLetExprBody, string type,
          ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(617L, "["));
            wr.Append(Expr(e, inLetExprBody, wStmts));
            wr.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(618L, "]"));
        }

        protected override void EmitHaltRecoveryStmt(Statement body, string haltMessageVarName, Statement recoveryBody, ConcreteSyntaxTree wr)
        {
            var tryBlock = wr.NewBlockPy(MutateCSharp.Schemata241.ReplaceStringConstant_0(619L, "try:"));
            TrStmt(body, tryBlock);
            var exceptBlock = wr.NewBlockPy($"except {DafnyRuntimeModule}.HaltException as e:");
            exceptBlock.Write($"{IdProtect(haltMessageVarName)} = ");
            if (UnicodeCharEnabled)
            {
                exceptBlock.Write($"{DafnySeqMakerFunction}(map({DafnyRuntimeModule}.CodePoint, e.message))");
            }
            else
            {
                exceptBlock.Write(MutateCSharp.Schemata241.ReplaceStringConstant_0(620L, "e.message"));
            }
            exceptBlock.WriteLine();
            TrStmt(recoveryBody, exceptBlock);
        }
    }
}
