using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.Contracts;
using System.Linq;
using Microsoft.Dafny.Auditor;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
namespace MutateCSharp
{
    internal class Schemata127
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT127");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_11(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, Microsoft.Dafny.ModuleDefinition argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBooleanConstant_8(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.DefaultClassDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_23(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, Microsoft.Dafny.ModuleKindEnum argument1, Microsoft.Dafny.ModuleKindEnum argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.Implements argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceNumericConstant_1(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_25(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_3(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, Microsoft.Dafny.ModuleDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.PrefixNameModule> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, Microsoft.Dafny.ICallable argument1, Microsoft.Dafny.ICallable argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.Function argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.TopLevelDeclWithMembers argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_24(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_27(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1--; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1++; }
            return argument1--;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, Microsoft.Dafny.Declaration argument1, Microsoft.Dafny.Declaration argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_28(long mutantId, Microsoft.Dafny.CommonOptionBag.GeneralTraitsOptions argument1, Microsoft.Dafny.CommonOptionBag.GeneralTraitsOptions argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_26(long mutantId, Microsoft.Dafny.ModuleSignature argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public record PrefixNameModule(DafnyOptions Options, IReadOnlyList<IToken> Parts, LiteralModuleDecl Module);

    public enum ModuleKindEnum
    {
        Concrete,
        Abstract,
        Replaceable
    }

    public enum ImplementationKind
    {
        Refinement,
        Replacement
    }

    public record Implements(ImplementationKind Kind, ModuleQualifiedId Target);

    public class ModuleDefinition : RangeNode, IAttributeBearingDeclaration, ICloneable<ModuleDefinition>, IHasSymbolChildren
    {
        public IToken BodyStartTok = Token.NoToken;
        public IToken TokenWithTrailingDocString = Token.NoToken;
        public string DafnyName => NameNode.StartToken.val; // The (not-qualified) name as seen in Dafny source code
        public Name NameNode; // (Last segment of the) module name

        public override IToken Tok => NameNode.StartToken;

        public string Name => NameNode.Value;
        public string FullDafnyName
        {
            get
            {
                if (MutateCSharp.Schemata127.ReplaceBinExprOp_0(1L, EnclosingModule, null))
                {
                    return "";
                }

                string n = EnclosingModule.FullDafnyName;
                return (MutateCSharp.Schemata127.ReplaceBinExprOp_2(6L, n.Length, MutateCSharp.Schemata127.ReplaceNumericConstant_1(2L, 0)) ? n : (n + MutateCSharp.Schemata127.ReplaceStringConstant_3(11L, "."))) + DafnyName;
            }
        }

        public string FullName
        {
            get
            {
                if (MutateCSharp.Schemata127.ReplaceBinExprOp_4(13L, () => MutateCSharp.Schemata127.ReplaceBinExprOp_0(12L, EnclosingModule, null), () => EnclosingModule.TryToAvoidName))
                {
                    return Name;
                }
                else
                {
                    return EnclosingModule.FullName + MutateCSharp.Schemata127.ReplaceStringConstant_3(19L, ".") + Name;
                }

                return default;
            }
        }

        public readonly List<IToken> PrefixIds; // The qualified module name, except the last segment when a
                                                // nested module declaration is outside its enclosing module
        public ModuleDefinition EnclosingModule;  // readonly, except can be changed by resolver for prefix-named modules when the real parent is discovered
        public Attributes Attributes { get; set; }

        public readonly Implements Implements; // null if no refinement base
        public bool SuccessfullyResolved;  // set to true upon successful resolution; modules that import an unsuccessfully resolved module are not themselves resolved
        public readonly ModuleKindEnum ModuleKind;
        public readonly bool IsFacade; // True iff this module represents a module facade (that is, an abstract interface)
        private bool IsBuiltinName => Name is "_System" or "_module"; // true if this is something like _System that shouldn't have it's name mangled.

        public DefaultClassDecl DefaultClass { get; set; }

        public readonly List<TopLevelDecl> SourceDecls = new();
        [FilledInDuringResolution]
        public readonly List<TopLevelDecl> ResolvedPrefixNamedModules = new();
        [FilledInDuringResolution]
        public readonly List<PrefixNameModule> PrefixNamedModules = new();  // filled in by the parser; emptied by the resolver

        public CallRedirector CallRedirector { get; set; }

        public IEnumerable<TopLevelDecl> TopLevelDecls => DefaultClasses.
              Concat(SourceDecls).
              Concat(ResolvedPrefixNamedModules);

        public IEnumerable<IPointer<TopLevelDecl>> TopLevelDeclPointers =>
          (MutateCSharp.Schemata127.ReplaceBinExprOp_5(20L, DefaultClass, null
      ) ? Enumerable.Empty<Pointer<TopLevelDecl>>()
            : new[] { new Pointer<TopLevelDecl>(() => DefaultClass, v => DefaultClass = (DefaultClassDecl)v) }).
          Concat(SourceDecls.ToPointers()).Concat(ResolvedPrefixNamedModules.ToPointers());

        public IEnumerable<TopLevelDecl> DefaultClasses
        {
            get { return MutateCSharp.Schemata127.ReplaceBinExprOp_5(21L, DefaultClass, null) ? Enumerable.Empty<TopLevelDecl>() : new TopLevelDecl[] { DefaultClass }; }
        }

        [FilledInDuringResolution]
        public readonly Graph<ICallable> CallGraph = new();

        // This field is only populated if `defaultFunctionOpacity` is set to something other than transparent
        [FilledInDuringResolution]
        public readonly Graph<ICallable> InterModuleCallGraph = new();

        [FilledInDuringResolution]
        public int Height;  // height in the topological sorting of modules;

        [FilledInDuringResolution]
        public Dictionary<Declaration, AccessibleMember> AccessibleMembers = new();

        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(cce.NonNullElements(TopLevelDecls));
            Contract.Invariant(CallGraph != null);
        }

        public ModuleDefinition(Cloner cloner, ModuleDefinition original, Name name) : this(cloner, original)
        {
            NameNode = name;
        }

        public ModuleDefinition(Cloner cloner, ModuleDefinition original) : base(cloner, original)
        {
            NameNode = original.NameNode;
            PrefixIds = original.PrefixIds.Select(cloner.Tok).ToList();
            IsFacade = original.IsFacade;
            Attributes = original.Attributes;
            ModuleKind = original.ModuleKind;
            Implements = MutateCSharp.Schemata127.ReplaceBinExprOp_6(22L, original.Implements, null) ? null : original.Implements with { Target = new ModuleQualifiedId(cloner, original.Implements.Target) };
            foreach (var d in original.SourceDecls)
            {
                SourceDecls.Add(cloner.CloneDeclaration(d, this));
            }

            DefaultClass = (DefaultClassDecl)cloner.CloneDeclaration(original.DefaultClass, this);
            foreach (var tup in original.PrefixNamedModules)
            {
                var newTup = tup with
                {
                    Module = (LiteralModuleDecl)cloner.CloneDeclaration(tup.Module, this)
                };
                PrefixNamedModules.Add(newTup);
            }

            // For cloning modules into their compiled variants, we don't want to copy resolved fields, but we do need to copy this.
            // We're hoping to remove the copying of modules into compiled variants altogether,
            // and then this can be moved to inside the `if (cloner.CloneResolvedFields)` block
            foreach (var tup in original.ResolvedPrefixNamedModules)
            {
                ResolvedPrefixNamedModules.Add(cloner.CloneDeclaration(tup, this));
            }

            if (cloner.CloneResolvedFields)
            {
                Height = original.Height;
            }
        }

        public ModuleDefinition(RangeToken tok, Name name, List<IToken> prefixIds, ModuleKindEnum moduleKind, bool isFacade,
          Implements implements, ModuleDefinition parent, Attributes attributes) : base(tok)
        {
            Contract.Requires(tok != null);
            Contract.Requires(name != null);
            this.NameNode = name;
            this.PrefixIds = prefixIds;
            this.Attributes = attributes;
            this.EnclosingModule = parent;
            this.Implements = implements;
            this.ModuleKind = moduleKind;
            this.IsFacade = isFacade;

            if (MutateCSharp.Schemata127.ReplaceBinExprOp_7(24L, Name, MutateCSharp.Schemata127.ReplaceStringConstant_3(23L, "_System")))
            {
                DefaultClass = new DefaultClassDecl(this, new List<MemberDecl>());
            }
        }

        private VisibilityScope visibilityScope;
        public VisibilityScope VisibilityScope =>
          visibilityScope ??= new VisibilityScope(this.SanitizedName);

        public virtual bool IsDefaultModule => MutateCSharp.Schemata127.ReplaceBooleanConstant_8(25L, false);

        public virtual bool TryToAvoidName => MutateCSharp.Schemata127.ReplaceBooleanConstant_8(26L, false);

        private string sanitizedName = null;

        public void ClearNameCache()
        {
            sanitizedName = null;
            compileName = null;
        }

        public string SanitizedName
        {
            get
            {
                if (sanitizedName == null)
                {
                    if (IsBuiltinName)
                    {
                        sanitizedName = Name;
                    }
                    else if (MutateCSharp.Schemata127.ReplaceBinExprOp_10(30L, () => MutateCSharp.Schemata127.ReplaceBinExprOp_9(27L, EnclosingModule, null), () => MutateCSharp.Schemata127.ReplaceBinExprOp_7(29L, EnclosingModule.Name, MutateCSharp.Schemata127.ReplaceStringConstant_3(28L, "_module"))))
                    {
                        // Include all names in the module tree path, to disambiguate when compiling
                        // a flat list of modules.
                        // Use an "underscore-escaped" character as a module name separator, since
                        // underscores are already used as escape characters in SanitizeName()
                        sanitizedName = EnclosingModule.SanitizedName + MutateCSharp.Schemata127.ReplaceStringConstant_3(36L, "_m") + NonglobalVariable.SanitizeName(Name);
                    }
                    else
                    {
                        sanitizedName = NonglobalVariable.SanitizeName(Name);
                    }
                }
                return sanitizedName;
            }
        }

        string compileName;

        public string GetCompileName(DafnyOptions options)
        {
            if (compileName != null)
            {
                return compileName;
            }

            if (Implements is { Kind: ImplementationKind.Replacement })
            {
                return Implements.Target.Def.GetCompileName(options);
            }

            var externArgs = options.DisallowExterns ? null : Attributes.FindExpressions(this.Attributes, MutateCSharp.Schemata127.ReplaceStringConstant_3(37L, "extern"));
            var nonExternSuffix = (MutateCSharp.Schemata127.ReplaceBinExprOp_10(48L, () => MutateCSharp.Schemata127.ReplaceBinExprOp_10(40L, () => options.Get(CommonOptionBag.AddCompileSuffix), () => MutateCSharp.Schemata127.ReplaceBinExprOp_7(39L, Name, MutateCSharp.Schemata127.ReplaceStringConstant_3(38L, "_module"))), () => MutateCSharp.Schemata127.ReplaceBinExprOp_7(47L, Name, MutateCSharp.Schemata127.ReplaceStringConstant_3(46L, "_System"))) ? MutateCSharp.Schemata127.ReplaceStringConstant_3(54L, "_Compile") : "");
            if (MutateCSharp.Schemata127.ReplaceBinExprOp_10(75L, () => MutateCSharp.Schemata127.ReplaceBinExprOp_10(65L, () => MutateCSharp.Schemata127.ReplaceBinExprOp_11(55L, externArgs, null), () => MutateCSharp.Schemata127.ReplaceBinExprOp_12(60L, MutateCSharp.Schemata127.ReplaceNumericConstant_1(56L, 1), externArgs.Count)), () => externArgs[MutateCSharp.Schemata127.ReplaceNumericConstant_1(71L, 0)] is StringLiteralExpr))
            {
                compileName = (string)((StringLiteralExpr)externArgs[MutateCSharp.Schemata127.ReplaceNumericConstant_1(81L, 0)]).Value;
            }
            else if (MutateCSharp.Schemata127.ReplaceBinExprOp_11(85L, externArgs, null))
            {
                compileName = Name + nonExternSuffix;
            }
            else
            {

                if (IsBuiltinName)
                {
                    compileName = Name;
                }
                else if (EnclosingModule is { TryToAvoidName: false })
                {
                    // Include all names in the module tree path, to disambiguate when compiling
                    // a flat list of modules.
                    // Use an "underscore-escaped" character as a module name separator, since
                    // underscores are already used as escape characters in SanitizeName()
                    compileName = EnclosingModule.GetCompileName(options) + options.Backend.ModuleSeparator + NonglobalVariable.SanitizeName(Name);
                }
                else
                {
                    compileName = NonglobalVariable.SanitizeName(Name);
                }

                compileName += nonExternSuffix;
            }

            return compileName;
        }

        /// <summary>
        /// Determines if "a" and "b" are in the same strongly connected component of the call graph, that is,
        /// if "a" and "b" are mutually recursive.
        /// Assumes that CallGraph has already been filled in for the modules containing "a" and "b".
        /// </summary>
        public static bool InSameSCC(ICallable a, ICallable b)
        {
            Contract.Requires(a != null);
            Contract.Requires(b != null);
            if (MutateCSharp.Schemata127.ReplaceBinExprOp_4(86L, () => a is SpecialFunction, () => b is SpecialFunction)) { return MutateCSharp.Schemata127.ReplaceBooleanConstant_8(92L, false); }
            var module = a.EnclosingModule;
            return MutateCSharp.Schemata127.ReplaceBinExprOp_10(95L, () => MutateCSharp.Schemata127.ReplaceBinExprOp_13(93L, module, b.EnclosingModule), () => MutateCSharp.Schemata127.ReplaceBinExprOp_14(94L, module.CallGraph.GetSCCRepresentative(a), module.CallGraph.GetSCCRepresentative(b)));
        }

        /// <summary>
        /// Return the representative elements of the SCCs that contain any member declaration in a
        /// class in "declarations".
        /// Note, the representative element may in some cases be a Method, not necessarily a Function.
        /// </summary>
        public static IEnumerable<ICallable> AllFunctionSCCs(List<TopLevelDecl> declarations)
        {
            var set = new HashSet<ICallable>();
            foreach (var d in declarations)
            {
                var cl = d as TopLevelDeclWithMembers;
                if (MutateCSharp.Schemata127.ReplaceBinExprOp_15(101L, cl, null))
                {
                    var module = cl.EnclosingModuleDefinition;
                    foreach (var member in cl.Members)
                    {
                        var fn = member as Function;
                        if (MutateCSharp.Schemata127.ReplaceBinExprOp_16(102L, fn, null))
                        {
                            var repr = module.CallGraph.GetSCCRepresentative(fn);
                            set.Add(repr);
                        }
                    }
                }
            }
            return set;
        }

        public static IEnumerable<Function> AllFunctions(List<TopLevelDecl> declarations)
        {
            foreach (var d in declarations)
            {
                var cl = d as TopLevelDeclWithMembers;
                if (MutateCSharp.Schemata127.ReplaceBinExprOp_15(103L, cl, null))
                {
                    foreach (var member in cl.Members)
                    {
                        var fn = member as Function;
                        if (MutateCSharp.Schemata127.ReplaceBinExprOp_16(104L, fn, null))
                        {
                            yield return fn;
                        }
                    }
                }
            }

            yield break;
        }

        public static IEnumerable<Field> AllFields(IEnumerable<TopLevelDecl> declarations)
        {
            foreach (var d in declarations)
            {
                if (d is TopLevelDeclWithMembers cl)
                {
                    foreach (var member in cl.Members)
                    {
                        if (member is Field fn)
                        {
                            yield return fn;
                        }
                    }
                }
            }

            yield break;
        }

        public static IEnumerable<TopLevelDeclWithMembers> AllTypesWithMembers(List<TopLevelDecl> declarations)
        {
            foreach (var d in declarations)
            {
                if (d is TopLevelDeclWithMembers cl)
                {
                    yield return cl;
                }
            }

            yield break;
        }

        /// <summary>
        /// Yields all functions and methods that are members of some type in the given list of
        /// declarations.
        /// Note, an iterator declaration is a type, in this sense.
        /// Note, if the given list are the top-level declarations of a module, the yield will include
        /// extreme predicates/lemmas but not their associated prefix predicates/lemmas (which are tucked
        /// into the extreme predicate/lemma's PrefixPredicate/PrefixLemma field).
        /// </summary>
        public static IEnumerable<ICallable> AllCallables(IEnumerable<TopLevelDecl> declarations)
        {
            foreach (var d in declarations)
            {
                if (d is TopLevelDeclWithMembers cl)
                {
                    foreach (var member in cl.Members.Where(member => member is ICallable and not ConstantField))
                    {
                        yield return (ICallable)member;
                        if (member is Function { ByMethodDecl: { } } f)
                        {
                            yield return f.ByMethodDecl;
                        }
                    }
                }
            }

            yield break;
        }

        /// <summary>
        /// Yields all functions and methods that are members of some type in the given list of
        /// declarations, including prefix lemmas and prefix predicates.
        /// </summary>
        public static IEnumerable<ICallable> AllCallablesIncludingPrefixDeclarations(IEnumerable<TopLevelDecl> declarations)
        {
            foreach (var decl in AllCallables(declarations))
            {
                yield return decl;
                if (decl is ExtremeLemma extremeLemma)
                {
                    yield return extremeLemma.PrefixLemma;
                }
                else if (decl is ExtremePredicate extremePredicate)
                {
                    yield return extremePredicate.PrefixPredicate;
                }
            }

            yield break;
        }

        /// <summary>
        /// Yields all functions and methods that are members of some non-iterator type in the given
        /// list of declarations, as well as any IteratorDecl's in that list.
        /// </summary>
        public static IEnumerable<ICallable> AllItersAndCallables(IEnumerable<TopLevelDecl> declarations)
        {
            foreach (var d in declarations)
            {
                if (d is IteratorDecl)
                {
                    yield return (IteratorDecl)d;
                }
                else if (d is TopLevelDeclWithMembers cl)
                {
                    foreach (var member in cl.Members.Where(member => member is ICallable))
                    {
                        yield return (ICallable)member;
                        if (member is Function { ByMethodDecl: { } } f)
                        {
                            yield return f.ByMethodDecl;
                        }
                    }
                }
            }

            yield break;
        }

        /// <summary>
        /// Emits the declarations in "declarations", but for each such declaration that is a class with
        /// a corresponding non-null type, also emits that non-null type *after* the class declaration.
        /// </summary>
        public static IEnumerable<TopLevelDecl> AllDeclarationsAndNonNullTypeDecls(IEnumerable<TopLevelDecl> declarations)
        {
            foreach (var d in declarations)
            {
                yield return d;
                if (d is ClassLikeDecl { NonNullTypeDecl: { } } cl)
                {
                    yield return cl.NonNullTypeDecl;
                }
            }

            yield break;
        }

        public static IEnumerable<ExtremeLemma> AllExtremeLemmas(List<TopLevelDecl> declarations)
        {
            foreach (var d in declarations)
            {
                if (d is TopLevelDeclWithMembers cl)
                {
                    foreach (var member in cl.Members)
                    {
                        if (member is ExtremeLemma extremeLemma)
                        {
                            yield return extremeLemma;
                        }
                    }
                }
            }

            yield break;
        }

        public bool IsEssentiallyEmptyModuleBody()
        {
            return TopLevelDecls.All(decl => decl.IsEssentiallyEmpty());
        }

        public IToken NameToken => tok;
        public override IEnumerable<INode> Children =>
          (MutateCSharp.Schemata127.ReplaceBinExprOp_17(105L, Attributes, null) ? new List<Node> { Attributes } : Enumerable.Empty<Node>()).
          Concat(DefaultClasses).
          Concat(SourceDecls).
          Concat(PrefixNamedModules.Any() ? PrefixNamedModules.Select(m => m.Module) : ResolvedPrefixNamedModules).
          Concat(MutateCSharp.Schemata127.ReplaceBinExprOp_6(106L, Implements, null) ? Enumerable.Empty<Node>() : new Node[] { Implements.Target });

        private IEnumerable<Node> preResolveTopLevelDecls;
        private IEnumerable<Node> preResolvePrefixNamedModules;

        public override IEnumerable<INode> PreResolveChildren
        {
            get
            {
                var attributes = MutateCSharp.Schemata127.ReplaceBinExprOp_17(107L, Attributes, null) ? new List<Node> { Attributes } : Enumerable.Empty<Node>();
                return attributes.Concat(preResolveTopLevelDecls ?? TopLevelDecls).
                  Concat(preResolvePrefixNamedModules ?? PrefixNamedModules.Select(tuple => tuple.Module));
            }
        }

        public void PreResolveSnapshotForFormatter()
        {
            preResolveTopLevelDecls = TopLevelDecls.ToImmutableList();
            preResolvePrefixNamedModules = PrefixNamedModules.Select(tuple => tuple.Module).ToImmutableList();
        }

        public override IEnumerable<Assumption> Assumptions(Declaration decl)
        {
            return TopLevelDecls.SelectMany(m => m.Assumptions(decl));
        }

        public ModuleDefinition Clone(Cloner cloner)
        {
            return new ModuleDefinition(cloner, this);
        }

        /// <summary>
        /// Resolves the module definition.
        /// A return code of "false" is an indication of an error that may or may not have
        /// been reported in an error message. So, in order to figure out if m was successfully
        /// resolved, a caller has to check for both a change in error count and a "false"
        /// return value.
        /// </summary>
        public bool Resolve(ModuleSignature sig, ModuleResolver resolver, string exportSetName = null)
        {
            Contract.Requires(resolver.AllTypeConstraints.Count == 0);
            Contract.Ensures(resolver.AllTypeConstraints.Count == 0);

            sig.VisibilityScope.Augment(resolver.ProgramResolver.SystemModuleManager.systemNameInfo.VisibilityScope);
            // make sure all imported modules were successfully resolved
            foreach (var d in TopLevelDecls)
            {
                if (d is AliasModuleDecl importDecl)
                {
                    var importSig = MutateCSharp.Schemata127.ReplaceBinExprOp_18(108L, importDecl.TargetQId.Root, null) ? importDecl.TargetQId.Root.Signature : importDecl.Signature;
                    if (importSig is not { ModuleDef: { SuccessfullyResolved: true } })
                    {
                        return MutateCSharp.Schemata127.ReplaceBooleanConstant_8(109L, false);
                    }
                }
                else if (d is AbstractModuleDecl abstractImportDecl)
                {
                    var importSig = abstractImportDecl.OriginalSignature;
                    if (importSig is not { ModuleDef: { SuccessfullyResolved: true } })
                    {
                        return MutateCSharp.Schemata127.ReplaceBooleanConstant_8(110L, false);
                    }
                }
                else if (d is LiteralModuleDecl nestedModuleDecl)
                {
                    if (!nestedModuleDecl.ModuleDef.SuccessfullyResolved)
                    {
                        if (!IsEssentiallyEmptyModuleBody())
                        {
                            // say something only if this will cause any testing to be omitted
                            resolver.reporter.Error(MessageSource.Resolver, nestedModuleDecl,
                MutateCSharp.Schemata127.ReplaceStringConstant_3(111L, "not resolving module '{0}' because there were errors in resolving its nested module '{1}'"), Name,
                              nestedModuleDecl.Name);
                        }

                        return MutateCSharp.Schemata127.ReplaceBooleanConstant_8(112L, false);
                    }
                }
            }

            var oldModuleInfo = resolver.moduleInfo;
            resolver.moduleInfo = ModuleResolver.MergeSignature(sig, resolver.ProgramResolver.SystemModuleManager.systemNameInfo);
            Type.PushScope(resolver.moduleInfo.VisibilityScope);
            ModuleResolver.ResolveOpenedImports(resolver.moduleInfo, this, resolver.Reporter, resolver); // opened imports do not persist
            var datatypeDependencies = new Graph<IndDatatypeDecl>();
            var codatatypeDependencies = new Graph<CoDatatypeDecl>();
            var allDeclarations = AllDeclarationsAndNonNullTypeDecls(TopLevelDecls).ToList();
            int prevErrorCount = resolver.reporter.Count(ErrorLevel.Error);
            resolver.ResolveTopLevelDecls_Signatures(this, sig, allDeclarations, datatypeDependencies, codatatypeDependencies);
            Contract.Assert(resolver.AllTypeConstraints.Count == 0); // signature resolution does not add any type constraints

            resolver.scope.PushMarker();
            resolver.scope.AllowInstance = MutateCSharp.Schemata127.ReplaceBooleanConstant_8(113L, false);
            resolver.ResolveAttributes(this, new ResolutionContext(new NoContext(EnclosingModule), MutateCSharp.Schemata127.ReplaceBooleanConstant_8(114L, false)), MutateCSharp.Schemata127.ReplaceBooleanConstant_8(115L, true)); // Must follow ResolveTopLevelDecls_Signatures, in case attributes refer to members
            resolver.scope.PopMarker();

            if (MutateCSharp.Schemata127.ReplaceBinExprOp_2(116L, resolver.reporter.Count(ErrorLevel.Error), prevErrorCount))
            {
                resolver.ResolveTopLevelDecls_Core(allDeclarations, datatypeDependencies, codatatypeDependencies,
                  exportSetName == null ? Name : $"{Name} export {exportSetName}", exportSetName != null);
            }

            Type.PopScope(resolver.moduleInfo.VisibilityScope);
            resolver.moduleInfo = oldModuleInfo;


            // Build the AccessibleMembers dictionary
            foreach (var d in TopLevelDecls)
            {
                if (MutateCSharp.Schemata127.ReplaceBinExprOp_4(121L, () => d is AliasModuleDecl, () => d is AbstractModuleDecl))
                {
                    ModuleSignature importSig;
                    if (d is AliasModuleDecl alias)
                    {
                        if (alias.TargetQId.Decl is not null)
                        {
                            importSig = alias.TargetQId.Decl.Signature;
                        }
                        else if (alias.TargetQId.Root is not null)
                        {
                            importSig = alias.TargetQId.Root.Signature;
                        }
                        else
                        {
                            importSig = alias.Signature;
                        }
                    }
                    else
                    {
                        importSig = ((AbstractModuleDecl)d).OriginalSignature;
                    }

                    var origMod = importSig.ModuleDef;

                    var exports = d is AliasModuleDecl ? ((AliasModuleDecl)d).Exports : ((AbstractModuleDecl)d).Exports;
                    var exportSet = exports.Any() ? exports.First().val : null;

                    foreach (var (decl, accMember) in origMod.AccessibleMembers)
                    {
                        if (isDeclExported(origMod, exportSet, decl, out var isDeclRevealed))
                        {
                            var newAccMember = accMember.Clone();

                            newAccMember.AccessPath.Insert(MutateCSharp.Schemata127.ReplaceNumericConstant_1(127L, 0), TopLevelDeclToNameSegment(d, d.Tok));
                            newAccMember.IsRevealed = MutateCSharp.Schemata127.ReplaceBinExprOp_10(131L, () => newAccMember.IsRevealed, () => isDeclRevealed);
                            AddAccessibleMember(decl, newAccMember);
                        }
                    }

                    var newAccessibleMember = new AccessibleMember();
                    AddAccessibleMember(d, newAccessibleMember);

                }
                else if (d is LiteralModuleDecl)
                {
                    var nested = (LiteralModuleDecl)d;

                    foreach (var (decl, accMember) in nested.ModuleDef.AccessibleMembers)
                    {
                        if (isDeclExported(nested.ModuleDef, null, decl, out var isDeclRevealed))
                        {
                            var newAccMember = accMember.Clone();

                            newAccMember.AccessPath.Insert(MutateCSharp.Schemata127.ReplaceNumericConstant_1(137L, 0), TopLevelDeclToNameSegment(d, d.Tok));
                            newAccMember.IsRevealed = MutateCSharp.Schemata127.ReplaceBinExprOp_10(141L, () => newAccMember.IsRevealed, () => isDeclRevealed);

                            AddAccessibleMember(decl, newAccMember);
                        }
                    }

                    var newAccessibleMember = new AccessibleMember();
                    AddAccessibleMember(d, newAccessibleMember);

                }
                else if (d is TopLevelDeclWithMembers tld)
                {
                    var memberList = tld.Members;

                    foreach (var mem in memberList)
                    {
                        var accessPath = new List<NameSegment> { TopLevelDeclToNameSegment(d, d.Tok) };
                        var newAccessibleMember = new AccessibleMember(accessPath);
                        AddAccessibleMember(mem, newAccessibleMember);
                    }
                }
            }

            return MutateCSharp.Schemata127.ReplaceBooleanConstant_8(147L, true);
        }

        private static NameSegment TopLevelDeclToNameSegment(TopLevelDecl decl, IToken tok)
        {
            var typeArgs = new List<Type>();

            foreach (var arg in decl.TypeArgs)
            {
                typeArgs.Add(new IntType());
            }

            return new NameSegment(tok, decl.Name, typeArgs);
        }

        private bool isDeclExported(ModuleDefinition moduleDefinition, string exportSetName, Declaration decl, out bool isItRevealed)
        {
            isItRevealed = MutateCSharp.Schemata127.ReplaceBooleanConstant_8(148L, true);

            exportSetName ??= moduleDefinition.Name;

            var moduleExports = moduleDefinition.TopLevelDecls.Where(decl => MutateCSharp.Schemata127.ReplaceBinExprOp_10(150L, () => decl is ModuleExportDecl, () => MutateCSharp.Schemata127.ReplaceBinExprOp_19(149L, decl.Name, exportSetName)));

            if (!moduleExports.Any())
            {
                return MutateCSharp.Schemata127.ReplaceBooleanConstant_8(156L, true);
            }

            var exportSignatures = ((ModuleExportDecl)moduleExports.First()).Exports.Where(export => MutateCSharp.Schemata127.ReplaceBinExprOp_20(157L, export.Decl, decl));

            if (!exportSignatures.Any())
            {
                return MutateCSharp.Schemata127.ReplaceBooleanConstant_8(158L, false);
            }

            isItRevealed = !exportSignatures.First().Opaque;
            return MutateCSharp.Schemata127.ReplaceBooleanConstant_8(159L, true);
        }

        private void AddAccessibleMember(Declaration accessibleDecl, AccessibleMember newVal)
        {
            if (AccessibleMembers.TryGetValue(accessibleDecl, out var oldVal))
            {
                newVal = MutateCSharp.Schemata127.ReplaceBinExprOp_10(160L, () => !oldVal.IsRevealed, () => newVal.IsRevealed) ? newVal : oldVal;
            }

            AccessibleMembers[accessibleDecl] = newVal;
        }

        public void ProcessPrefixNamedModules()
        {
            // moduleDecl.PrefixNamedModules is a list of pairs like:
            //     A.B.C  ,  module D { ... }
            // We collect these according to the first component of the prefix, like so:
            //     "A"   ->   (A.B.C  ,  module D { ... })
            var prefixModulesByFirstPart = PrefixNamedModules.
              GroupBy(prefixNameModule => prefixNameModule.Parts[MutateCSharp.Schemata127.ReplaceNumericConstant_1(166L, 0)].val).
              ToDictionary(g => g.Key, g => g.ToList());

            PrefixNamedModules.Clear();

            // First, register all literal modules, and transferring their prefix-named modules downwards
            foreach (var subDecl in TopLevelDecls.OfType<LiteralModuleDecl>())
            {
                // Transfer prefix-named modules downwards into the sub-module
                if (prefixModulesByFirstPart.TryGetValue(subDecl.Name, out var prefixModules))
                {
                    prefixModulesByFirstPart.Remove(subDecl.Name);
                    prefixModules = prefixModules.ConvertAll(ShortenPrefix);
                }

                ProcessPrefixNamedModules(prefixModules, subDecl);
            }

            // Next, add new modules for any remaining entries in "prefixNames".
            foreach (var (name, prefixNamedModules) in prefixModulesByFirstPart)
            {
                var prefixNameModule = prefixNamedModules.First();
                var firstPartToken = prefixNameModule.Parts[MutateCSharp.Schemata127.ReplaceNumericConstant_1(170L, 0)];
                var modDef = new ModuleDefinition(RangeToken.NoToken, new Name(firstPartToken.ToRange(), name), new List<IToken>(), ModuleKindEnum.Concrete,
          MutateCSharp.Schemata127.ReplaceBooleanConstant_8(174L, false), null, this, null);
                // Add the new module to the top-level declarations of its parent and then bind its names as usual

                // Use an empty cloneId because these are empty module declarations.
                var cloneId = Guid.Empty;
                var subDecl = new LiteralModuleDecl(prefixNameModule.Options, modDef, this, cloneId);
                ResolvedPrefixNamedModules.Add(subDecl);
                // only set the range on the last submodule of the chain, since the others can be part of multiple files
                ProcessPrefixNamedModules(prefixNamedModules.ConvertAll(ShortenPrefix), subDecl);
            }
        }

        private static void ProcessPrefixNamedModules(List<PrefixNameModule> prefixModules, LiteralModuleDecl subDecl)
        {
            // Transfer prefix-named modules downwards into the sub-module
            if (MutateCSharp.Schemata127.ReplaceBinExprOp_21(175L, prefixModules, null))
            {
                foreach (var prefixModule in prefixModules)
                {
                    if (MutateCSharp.Schemata127.ReplaceBinExprOp_2(180L, prefixModule.Parts.Count, MutateCSharp.Schemata127.ReplaceNumericConstant_1(176L, 0)))
                    {
                        // change the parent, now that we have found the right parent module for the prefix-named module
                        prefixModule.Module.ModuleDef.EnclosingModule = subDecl.ModuleDef;
                        var sm = new LiteralModuleDecl(prefixModule.Options, prefixModule.Module.ModuleDef, subDecl.ModuleDef,
                          prefixModule.Module.CloneId);
                        subDecl.ModuleDef.ResolvedPrefixNamedModules.Add(sm);
                    }
                    else
                    {
                        subDecl.ModuleDef.PrefixNamedModules.Add(prefixModule);
                    }
                }
            }

            subDecl.ModuleDef.ProcessPrefixNamedModules();
        }

        public ModuleBindings BindModuleNames(ProgramResolver resolver, ModuleBindings parentBindings)
        {
            var bindings = new ModuleBindings(parentBindings);

            foreach (var subLiteral in TopLevelDecls.OfType<LiteralModuleDecl>())
            {
                subLiteral.BindModuleNames(resolver, bindings);
            }

            // Go through import declarations (that is, AbstractModuleDecl's and AliasModuleDecl's).
            foreach (var subDecl in TopLevelDecls.OfType<ModuleDecl>())
            {
                if (subDecl is not (AbstractModuleDecl or AliasModuleDecl))
                {
                    continue;
                }

                if (bindings.BindName(subDecl.Name, subDecl, null))
                {
                    // the add was successful
                }
                else
                {
                    // there's already something with this name
                    var existingModuleIsFound = bindings.TryLookup(subDecl.Name, out var prevDecl);
                    Contract.Assert(existingModuleIsFound);
                    if (MutateCSharp.Schemata127.ReplaceBinExprOp_4(185L, () => prevDecl is AbstractModuleDecl, () => prevDecl is AliasModuleDecl))
                    {
                        resolver.Reporter.Error(MessageSource.Resolver, subDecl.tok, MutateCSharp.Schemata127.ReplaceStringConstant_3(191L, "Duplicate name of import: {0}"), subDecl.Name);
                    }
                    else if (subDecl is AliasModuleDecl { Opened: true } importDecl && importDecl.TargetQId.Path.Count == 1 &&
            MutateCSharp.Schemata127.ReplaceBinExprOp_19(192L, importDecl.Name, importDecl.TargetQId.RootName()))
                    {
                        importDecl.ShadowsLiteralModule = MutateCSharp.Schemata127.ReplaceBooleanConstant_8(193L, true);
                    }
                    else
                    {
                        resolver.Reporter.Error(MessageSource.Resolver, subDecl.tok,
              MutateCSharp.Schemata127.ReplaceStringConstant_3(194L, "Import declaration uses same name as a module in the same scope: {0}"), subDecl.Name);
                    }
                }
            }

            return bindings;
        }

        private static PrefixNameModule ShortenPrefix(PrefixNameModule prefixNameModule)
        {
            Contract.Requires(prefixNameModule.Parts.Count != 0);
            var rest = prefixNameModule.Parts.Skip(MutateCSharp.Schemata127.ReplaceNumericConstant_1(195L, 1)).ToList();
            return prefixNameModule with { Parts = rest };
        }

        private static readonly List<(string, string)> incompatibleAttributePairs =
          new() {
      (MutateCSharp.Schemata127.ReplaceStringConstant_3(199L, "rlimit"), MutateCSharp.Schemata127.ReplaceStringConstant_3(200L, "resource_limit"))
          };

        private void CheckIncompatibleAttributes(ModuleResolver resolver, Attributes attrs)
        {
            foreach (var pair in incompatibleAttributePairs)
            {
                var attr1 = Attributes.Find(attrs, pair.Item1);
                var attr2 = Attributes.Find(attrs, pair.Item2);
                if (MutateCSharp.Schemata127.ReplaceBinExprOp_10(201L, () => attr1 is not null, () => attr2 is not null))
                {
                    resolver.reporter.Error(MessageSource.Resolver, attr1.tok,
                        $"the {pair.Item1} and {pair.Item2} attributes cannot be used together");
                }
            }
        }

        public ModuleSignature RegisterTopLevelDecls(ModuleResolver resolver, bool useImports)
        {
            Contract.Requires(this != null);
            var sig = new ModuleSignature();
            sig.ModuleDef = this;
            sig.IsAbstract = MutateCSharp.Schemata127.ReplaceBinExprOp_22(207L, ModuleKind, ModuleKindEnum.Abstract);
            sig.VisibilityScope = new VisibilityScope();
            sig.VisibilityScope.Augment(VisibilityScope);

            // This is solely used to detect duplicates amongst the various e
            Dictionary<string, INode> toplevels = new();
            // Now add the things present
            var anonymousImportCount = MutateCSharp.Schemata127.ReplaceNumericConstant_1(208L, 0);
            foreach (TopLevelDecl d in TopLevelDecls)
            {
                Contract.Assert(d != null);

                if (d is RevealableTypeDecl)
                {
                    resolver.revealableTypes.Add((RevealableTypeDecl)d);
                }

                // register the class/datatype/module name
                TopLevelDecl registerThisDecl = null;
                string registerUnderThisName = null;
                if (d is ModuleExportDecl export)
                {
                    if (sig.ExportSets.ContainsKey(d.Name))
                    {
                        resolver.reporter.Error(MessageSource.Resolver, d, MutateCSharp.Schemata127.ReplaceStringConstant_3(212L, "duplicate name of export set: {0}"), d.Name);
                    }
                    else
                    {
                        sig.ExportSets[d.Name] = export;
                    }
                }
                else if (d is AliasModuleDecl importDecl && importDecl.ShadowsLiteralModule)
                {
                    // add under an anonymous name
                    registerThisDecl = d;
                    registerUnderThisName = string.Format(MutateCSharp.Schemata127.ReplaceStringConstant_3(213L, "{0}#{1}"), d.Name, anonymousImportCount);
                    MutateCSharp.Schemata127.ReplacePostfixUnaryExprOp_23(214L, ref anonymousImportCount);
                }
                else if (toplevels.TryGetValue(d.Name, out var existingTopLevel))
                {
                    resolver.reporter.Error(MessageSource.Resolver, new NestedToken(d.Tok, existingTopLevel.Tok),
            MutateCSharp.Schemata127.ReplaceStringConstant_3(215L, "duplicate name of top-level declaration: {0}"), d.Name);
                }
                else if (d is ClassLikeDecl { NonNullTypeDecl: { } nntd })
                {
                    registerThisDecl = nntd;
                    registerUnderThisName = d.Name;
                }
                else
                {
                    // Register each class and trait C under its own name, C. Below, we will change this for reference types (which includes all classes
                    // and some of the traits), so that C? maps to the class/trait and C maps to the corresponding NonNullTypeDecl. We will need these
                    // initial mappings in order to look through the parent traits of traits, below.
                    registerThisDecl = d;
                    registerUnderThisName = d.Name;
                }

                if (MutateCSharp.Schemata127.ReplaceBinExprOp_24(216L, registerThisDecl, null))
                {
                    toplevels[registerUnderThisName] = d;
                    sig.TopLevels[registerUnderThisName] = registerThisDecl;
                }

                if (d is ModuleDecl)
                {
                    // nothing to do
                }
                else if (d is TypeSynonymDecl)
                {
                    // nothing more to register
                }
                else if (MutateCSharp.Schemata127.ReplaceBinExprOp_4(217L, () => d is NewtypeDecl, () => d is AbstractTypeDecl))
                {
                    var cl = (TopLevelDeclWithMembers)d;
                    // register the names of the type members
                    var members = new Dictionary<string, MemberDecl>();
                    resolver.AddClassMembers(cl, members);
                    cl.RegisterMembers(resolver, members);
                }
                else if (d is IteratorDecl)
                {
                    var iter = (IteratorDecl)d;
                    iter.Resolve(resolver);

                }
                else if (d is DefaultClassDecl defaultClassDecl)
                {
                    var preMemberErrs = resolver.reporter.Count(ErrorLevel.Error);

                    // register the names of the class members
                    var members = new Dictionary<string, MemberDecl>();
                    resolver.AddClassMembers(defaultClassDecl, members);
                    defaultClassDecl.RegisterMembers(resolver, members);

                    Contract.Assert(preMemberErrs != resolver.reporter.Count(ErrorLevel.Error) || !defaultClassDecl.Members.Except(members.Values).Any());

                    foreach (MemberDecl m in members.Values)
                    {
                        Contract.Assert(!m.HasStaticKeyword || Attributes.Contains(m.Attributes, "opaque_reveal"));

                        CheckIncompatibleAttributes(resolver, m.Attributes);

                        if (m is Function or Method or ConstantField)
                        {
                            sig.StaticMembers[m.Name] = m;
                        }

                        if (toplevels.ContainsKey(m.Name))
                        {
                            resolver.reporter.Error(MessageSource.Resolver, m.tok, $"duplicate declaration for name {m.Name}");
                        }
                        else
                        {
                            toplevels.Add(m.Name, m);
                        }
                    }

                }
                else if (d is ClassLikeDecl)
                {
                    var cl = (ClassLikeDecl)d;
                    var preMemberErrs = resolver.reporter.Count(ErrorLevel.Error);

                    // register the names of the class members
                    var members = new Dictionary<string, MemberDecl>();
                    resolver.AddClassMembers(cl, members);
                    cl.RegisterMembers(resolver, members);

                    Contract.Assert(preMemberErrs != resolver.reporter.Count(ErrorLevel.Error) || !cl.Members.Except(members.Values).Any());

                }
                else if (d is DatatypeDecl)
                {
                    var dt = (DatatypeDecl)d;

                    // register the names of the constructors
                    dt.ConstructorsByName = new();
                    // ... and of the other members
                    var members = new Dictionary<string, MemberDecl>();
                    resolver.AddClassMembers(dt, members);

                    foreach (DatatypeCtor ctor in dt.Ctors)
                    {
                        if (ctor.Name.EndsWith(MutateCSharp.Schemata127.ReplaceStringConstant_3(223L, "?")))
                        {
                            resolver.reporter.Error(MessageSource.Resolver, ctor,
                MutateCSharp.Schemata127.ReplaceStringConstant_3(224L, "a datatype constructor name is not allowed to end with '?'"));
                        }
                        else if (dt.ConstructorsByName.ContainsKey(ctor.Name))
                        {
                            resolver.reporter.Error(MessageSource.Resolver, ctor, MutateCSharp.Schemata127.ReplaceStringConstant_3(225L, "Duplicate datatype constructor name: {0}"), ctor.Name);
                        }
                        else
                        {
                            dt.ConstructorsByName.Add(ctor.Name, ctor);
                            ctor.InheritVisibility(dt);

                            // create and add the query "method" (field, really)
                            var queryName = ctor.NameNode.Append(MutateCSharp.Schemata127.ReplaceStringConstant_3(226L, "?"));
                            var query = new DatatypeDiscriminator(ctor.RangeToken, queryName, SpecialField.ID.UseIdParam, MutateCSharp.Schemata127.ReplaceStringConstant_3(227L, "is_") + ctor.GetCompileName(resolver.Options),
                              ctor.IsGhost, Type.Bool, null);
                            query.InheritVisibility(dt);
                            query.EnclosingClass = dt; // resolve here
                            members.Add(queryName.Value, query);
                            ctor.QueryField = query;

                            // also register the constructor name globally
                            Tuple<DatatypeCtor, bool> pair;
                            if (sig.Ctors.TryGetValue(ctor.Name, out pair))
                            {
                                // mark it as a duplicate
                                sig.Ctors[ctor.Name] = new Tuple<DatatypeCtor, bool>(pair.Item1, MutateCSharp.Schemata127.ReplaceBooleanConstant_8(228L, true));
                            }
                            else
                            {
                                // add new
                                sig.Ctors.Add(ctor.Name, new Tuple<DatatypeCtor, bool>(ctor, MutateCSharp.Schemata127.ReplaceBooleanConstant_8(229L, false)));
                            }
                        }
                    }

                    // add deconstructors now (that is, after the query methods have been added)
                    foreach (DatatypeCtor ctor in dt.Ctors)
                    {
                        var formalsUsedInThisCtor = new HashSet<string>();
                        var duplicates = new HashSet<Formal>();
                        foreach (var formal in ctor.Formals)
                        {
                            MemberDecl previousMember = null;
                            var localDuplicate = MutateCSharp.Schemata127.ReplaceBooleanConstant_8(230L, false);
                            if (formal.HasName)
                            {
                                if (members.TryGetValue(formal.Name, out previousMember))
                                {
                                    localDuplicate = formalsUsedInThisCtor.Contains(formal.Name);
                                    if (localDuplicate)
                                    {
                                        resolver.reporter.Error(MessageSource.Resolver, ctor,
                      MutateCSharp.Schemata127.ReplaceStringConstant_3(231L, "Duplicate use of deconstructor name in the same constructor: {0}"), formal.Name);
                                        duplicates.Add(formal);
                                    }
                                    else if (previousMember is DatatypeDestructor)
                                    {
                                        // this is okay, if the destructor has the appropriate type; this will be checked later, after type checking
                                    }
                                    else
                                    {
                                        resolver.reporter.Error(MessageSource.Resolver, ctor,
                      MutateCSharp.Schemata127.ReplaceStringConstant_3(232L, "Name of deconstructor is used by another member of the datatype: {0}"), formal.Name);
                                    }
                                }

                                formalsUsedInThisCtor.Add(formal.Name);
                            }

                            DatatypeDestructor dtor;
                            if (MutateCSharp.Schemata127.ReplaceBinExprOp_10(233L, () => !localDuplicate, () => previousMember is DatatypeDestructor))
                            {
                                // a destructor with this name already existed in (a different constructor in) the datatype
                                dtor = (DatatypeDestructor)previousMember;
                                dtor.AddAnotherEnclosingCtor(ctor, formal);
                            }
                            else
                            {
                                // either the destructor has no explicit name, or this constructor declared another destructor with this name, or no previous destructor had this name
                                dtor = new DatatypeDestructor(formal.RangeToken, ctor, formal, new Name(formal.RangeToken, formal.Name), MutateCSharp.Schemata127.ReplaceStringConstant_3(239L, "dtor_") + formal.CompileName,
                                  formal.IsGhost, formal.Type, null);
                                dtor.InheritVisibility(dt);
                                dtor.EnclosingClass = dt; // resolve here
                                if (MutateCSharp.Schemata127.ReplaceBinExprOp_10(247L, () => MutateCSharp.Schemata127.ReplaceBinExprOp_10(240L, () => formal.HasName, () => !localDuplicate), () => MutateCSharp.Schemata127.ReplaceBinExprOp_25(246L, previousMember, null)))
                                {
                                    // the destructor has an explict name and there was no member at all with this name before
                                    members.Add(formal.Name, dtor);
                                }
                            }

                            ctor.Destructors.Add(dtor);
                        }

                        foreach (var duplicate in duplicates)
                        {
                            ctor.Formals.Remove(duplicate);
                        }
                    }

                    // finally, add any additional user-defined members
                    dt.RegisterMembers(resolver, members);

                }
                else
                {
                    var cl = (ValuetypeDecl)d;
                    // register the names of the type members
                    var members = new Dictionary<string, MemberDecl>();
                    resolver.AddClassMembers(cl, members);
                    cl.RegisterMembers(resolver, members);
                }
            }

            DetermineReferenceTypes(resolver, sig);

            // Now, for each reference type (class and some traits), register its possibly-null type.
            // In the big loop above, each class and trait was registered under its own name. We're now going to change that for the reference types.
            foreach (TopLevelDecl d in TopLevelDecls)
            {
                if (d is ClassLikeDecl { NonNullTypeDecl: { } nntd })
                {
                    var name = d.Name + MutateCSharp.Schemata127.ReplaceStringConstant_3(253L, "?");
                    if (toplevels.ContainsKey(name))
                    {
                        resolver.reporter.Error(MessageSource.Resolver, d,
              MutateCSharp.Schemata127.ReplaceStringConstant_3(254L, "a module that already contains a top-level declaration '{0}' is not allowed to declare a reference type ({1}) '{2}'"),
                          name, d.WhatKind, d.Name);
                    }
                    else
                    {
                        toplevels[name] = d;
                        toplevels[d.Name] = d;
                        // change the mapping of d.Name to d.NonNullTypeDecl
                        sig.TopLevels[d.Name] = nntd;
                        sig.TopLevels[name] = d;
                    }
                }
            }

            return sig;
        }

        private void DetermineReferenceTypes(ModuleResolver resolver, ModuleSignature sig)
        {
            // Figure out which TraitDecl's are reference types, and for each of these, create a corresponding NonNullTypeDecl.
            // To figure this out, we need to look at the parents of each TraitDecl, but those parents have not yet been resolved.
            // Since we just need the head of each parent, we'll do that name resolution here (and will redo it later, when each parent
            // type is resolved properly).
            //
            // Some inaccuracies can occur here, since possibly-null types have not yet been registered. However, since such types aren't allowed
            // as parents, it doesn't matter that they aren't available yet.
            //
            // If the head of a parent trait cannot be resolved, it is ignored here. An error will be reported later, when trait declarations are
            // resolved properly. Similarly, any cycle detected among the trait-parent heads is ignored. Cycles are detected (again) later and an
            // error will be reported then (in the meantime, we may have computed incorrectly whether or not a TraitDecl is a reference type, but
            // the cycle still remains, so an error will be reported later). (Btw, the later cycle detection detects not only cycles among parent
            // heads, but also among the type arguments of parent traits.)
            //
            // In the following dictionary, a TraitDecl not being present among the keys means it has not been visited in the InheritsFromObject traversal.
            // If a TraitDecl is a key and maps to "false", then it is currently being visited.
            // If a TraitDecl is a key and maps to "true", then its .IsReferenceTypeDecl has been computed and is ready to be used.
            var openedImports = TopLevelDecls.OfType<ModuleDecl>().Where(d => d.Opened).ToList();
            var traitsProgress = new Dictionary<TraitDecl, bool>();
            foreach (var decl in TopLevelDecls.Where(d => d is TraitDecl))
            {
                // Resolve a "path" to a top-level declaration, if possible. On error, return null.
                // The path is expected to consist of NameSegment or ExprDotName nodes.
                TopLevelDecl ResolveNamePath(Expression path)
                {
                    // A single NameSegment is a little different, because it may refer to built-in type (of interest here: "object").
                    if (path is NameSegment nameSegment)
                    {
                        if (sig.TopLevels.TryGetValue(nameSegment.Name, out var topLevelDecl))
                        {
                            return topLevelDecl;
                        }
                        else if (MutateCSharp.Schemata127.ReplaceBinExprOp_26(255L, resolver.moduleInfo, null) && resolver.moduleInfo.TopLevels.TryGetValue(nameSegment.Name, out topLevelDecl))
                        {
                            // For "object" and other reference-type declarations from other modules, we're picking up the NonNullTypeDecl; if so, return
                            // the original declaration.
                            return topLevelDecl is NonNullTypeDecl nntd ? nntd.ViewAsClass : topLevelDecl;
                        }
                        else if (resolver.ProgramResolver.SystemModuleManager.systemNameInfo.TopLevels.TryGetValue(nameSegment.Name, out topLevelDecl))
                        {
                            // For "object" and other reference-type declarations from other modules, we're picking up the NonNullTypeDecl; if so, return
                            // the original declaration.
                            return topLevelDecl is NonNullTypeDecl nntd ? nntd.ViewAsClass : topLevelDecl;
                        }
                        // Look through opened imports (which haven't yet been added to the module's signature). There may be ambiguities among the declarations
                        // of these opened imports. Still, we'll just pick the first declaration that matches, if any. If this declaration turns out to be
                        // ambiguous, then an error will be reported later; in the meantime, all that would have happened is that the resolved name path here
                        // is referring to some top-level declaration that won't accurately answer the question of whether "path" is referring to a reference
                        // type or not.
                        foreach (var importDecl in openedImports)
                        {
                            Contract.Assert(importDecl is AliasModuleDecl or AbstractModuleDecl); // only these ModuleDecl's can be .Opened
                            if (importDecl.AccessibleSignature(MutateCSharp.Schemata127.ReplaceBooleanConstant_8(256L, false)).TopLevels.TryGetValue(nameSegment.Name, out topLevelDecl))
                            {
                                // For "object" and other reference-type declarations from other modules, we're picking up the NonNullTypeDecl; if so, return
                                // the original declaration.
                                return topLevelDecl is NonNullTypeDecl nntd ? nntd.ViewAsClass : topLevelDecl;
                            }
                        }
                        // We didn't find "path"
                        return null;
                    }

                    // convert the ExprDotName to a list of strings
                    var names = new List<string>();
                    while (path is ExprDotName exprDotName)
                    {
                        names.Add(exprDotName.SuffixName);
                        path = exprDotName.Lhs;
                    }
                    names.Add(((NameSegment)path).Name);
                    var s = sig;
                    var i = names.Count;
                    while (MutateCSharp.Schemata127.ReplaceBooleanConstant_8(257L, true))
                    {
                        MutateCSharp.Schemata127.ReplacePostfixUnaryExprOp_27(258L, ref i);
                        if (!s.TopLevels.TryGetValue(names[i], out var topLevelDecl))
                        {
                            return null;
                        }
                        else if (MutateCSharp.Schemata127.ReplaceBinExprOp_2(263L, i, MutateCSharp.Schemata127.ReplaceNumericConstant_1(259L, 0)))
                        {
                            // For reference-type declarations from other modules, we're picking up the NonNullTypeDecl; if so, return
                            // the original declaration.
                            return topLevelDecl is NonNullTypeDecl nntd ? nntd.ViewAsClass : topLevelDecl;
                        }
                        else if (topLevelDecl is ModuleDecl moduleDecl)
                        {
                            var signature = moduleDecl.AccessibleSignature(MutateCSharp.Schemata127.ReplaceBooleanConstant_8(268L, false));
                            s = resolver.GetSignature(signature);
                        }
                        else
                        {
                            return null;
                        }
                    }

                    return default;
                }

                bool InheritsFromObject(TraitDecl traitDecl)
                {
                    if (traitsProgress.TryGetValue(traitDecl, out var isDone))
                    {
                        if (isDone)
                        {
                            return traitDecl.IsReferenceTypeDecl;
                        }
                        else
                        {
                            // there is a cycle among the parents, so we'll suppose the trait does inherit from "object"
                            return MutateCSharp.Schemata127.ReplaceBooleanConstant_8(269L, true);
                        }
                    }
                    traitsProgress[traitDecl] = MutateCSharp.Schemata127.ReplaceBooleanConstant_8(270L, false); // indicate that traitDecl is currently being visited

                    var inheritsFromObject = traitDecl.IsObjectTrait;
                    foreach (var parent in traitDecl.ParentTraits)
                    {
                        if (parent is UserDefinedType udt)
                        {
                            if (ResolveNamePath(udt.NamePath) is TraitDecl parentTrait)
                            {
                                if (MutateCSharp.Schemata127.ReplaceBinExprOp_13(271L, parentTrait.EnclosingModuleDefinition, this))
                                {
                                    inheritsFromObject = MutateCSharp.Schemata127.ReplaceBinExprOp_4(272L, () => InheritsFromObject(parentTrait), () => inheritsFromObject);
                                }
                                else
                                {
                                    inheritsFromObject = MutateCSharp.Schemata127.ReplaceBinExprOp_4(278L, () => parentTrait.IsReferenceTypeDecl, () => inheritsFromObject);
                                }
                            }
                        }
                    }

                    traitDecl.SetUpAsReferenceType(MutateCSharp.Schemata127.ReplaceBinExprOp_4(285L, () => MutateCSharp.Schemata127.ReplaceBinExprOp_28(284L, resolver.Options.Get(CommonOptionBag.GeneralTraits), CommonOptionBag.GeneralTraitsOptions.Legacy), () => inheritsFromObject));
                    traitsProgress[traitDecl] = MutateCSharp.Schemata127.ReplaceBooleanConstant_8(291L, true); // indicate that traitDecl.IsReferenceTypeDecl can now be called
                    return inheritsFromObject;
                }

                InheritsFromObject((TraitDecl)decl);
            }

        }

        public IEnumerable<ISymbol> ChildSymbols => TopLevelDecls.SelectMany(decl =>
        {
            if (decl is DefaultClassDecl defaultClassDecl)
            {
                return defaultClassDecl.Members.OfType<ISymbol>();
            }

            if (decl is ISymbol symbol)
            {
                return new[] { symbol };
            }

            return Enumerable.Empty<ISymbol>();
        });

        public SymbolKind Kind => SymbolKind.Namespace;
        public string GetDescription(DafnyOptions options)
        {
            return $"module {Name}";
        }
    }
}