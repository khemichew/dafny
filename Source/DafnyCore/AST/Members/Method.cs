using System.Collections.Generic;
using System.CommandLine;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Numerics;
using DafnyCore;
using DafnyCore.Options;
using Microsoft.Dafny.Auditor;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
namespace MutateCSharp
{
    internal class Schemata108
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT108");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.Method argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_20(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.ModuleKindEnum argument1, Microsoft.Dafny.ModuleKindEnum argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, Microsoft.Dafny.AssertLabel argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, Microsoft.Dafny.Label argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.Node argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, Microsoft.Dafny.PrefixLemma argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceBinExprOp_14(long mutantId, int argument1, int argument2)
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

        internal static int ReplaceNumericConstant_7(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Formal> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

namespace Microsoft.Dafny
{
    public class Method : MethodOrFunction, TypeParameter.ParentType,
      IMethodCodeContext, ICanFormat, IHasDocstring, IHasSymbolChildren, ICanAutoRevealDependencies, ICanVerify
    {

        public static readonly Option<bool> ReadsClausesOnMethods = new(MutateCSharp.Schemata108.ReplaceStringConstant_0(1L, "--reads-clauses-on-methods"),
      MutateCSharp.Schemata108.ReplaceStringConstant_0(2L, "Allows reads clauses on methods (with a default of 'reads *') as well as functions."
      ));

        static Method()
        {
            DafnyOptions.RegisterLegacyUi(ReadsClausesOnMethods, DafnyOptions.ParseBoolean, MutateCSharp.Schemata108.ReplaceStringConstant_0(3L, "Language feature selection"), MutateCSharp.Schemata108.ReplaceStringConstant_0(4L, "readsClausesOnMethods"), MutateCSharp.Schemata108.ReplaceStringConstant_0(5L, @"
0 (default) - Reads clauses on methods are forbidden.
1 - Reads clauses on methods are permitted (with a default of 'reads *').").TrimStart(), defaultValue: MutateCSharp.Schemata108.ReplaceBooleanConstant_1(6L, false));
            DooFile.RegisterLibraryCheck(ReadsClausesOnMethods, OptionCompatibility.CheckOptionLocalImpliesLibrary);
        }

        public override IEnumerable<INode> Children => new Node[] { Body, Decreases }.Where(x => MutateCSharp.Schemata108.ReplaceBinExprOp_2(7L, x, null)).
          Concat(Ins).Concat(Outs).Concat<Node>(TypeArgs).
          Concat(Req).Concat(Ens).Concat(Reads.Expressions).Concat(Mod.Expressions);
        public override IEnumerable<INode> PreResolveChildren => Children;

        public override string WhatKind => MutateCSharp.Schemata108.ReplaceStringConstant_0(8L, "method");
        public bool SignatureIsOmitted
        {
            get { return MutateCSharp.Schemata108.ReplaceBinExprOp_3(9L, SignatureEllipsis, null); }
        }

        public readonly IToken SignatureEllipsis;
        public readonly bool IsByMethod;
        public bool MustReverify;
        public bool IsEntryPoint = MutateCSharp.Schemata108.ReplaceBooleanConstant_1(10L, false);
        public readonly List<Formal> Outs;
        public readonly Specification<FrameExpression> Reads;
        public readonly Specification<FrameExpression> Mod;
        [FilledInDuringResolution] public bool IsRecursive;
        [FilledInDuringResolution] public bool IsTailRecursive;
        [FilledInDuringResolution] public Function FunctionFromWhichThisIsByMethodDecl;
        public readonly ISet<IVariable> AssignedAssumptionVariables = new HashSet<IVariable>();
        public Method OverriddenMethod;
        public Method Original => MutateCSharp.Schemata108.ReplaceBinExprOp_4(11L, OverriddenMethod, null) ? this : OverriddenMethod.Original;
        public override bool IsOverrideThatAddsBody => MutateCSharp.Schemata108.ReplaceBinExprOp_6(13L, () => base.IsOverrideThatAddsBody, () => MutateCSharp.Schemata108.ReplaceBinExprOp_5(12L, Body, null));

        public override bool HasPostcondition => MutateCSharp.Schemata108.ReplaceBinExprOp_9(28L, () => MutateCSharp.Schemata108.ReplaceBinExprOp_8(23L, Ens.Count, MutateCSharp.Schemata108.ReplaceNumericConstant_7(19L, 0
                                                 )), () => Outs.Any(f => f.Type.AsSubsetType is not null));

        public override IEnumerable<Assumption> Assumptions(Declaration decl)
        {
            foreach (var a in base.Assumptions(this))
            {
                yield return a;
            }

            if (MutateCSharp.Schemata108.ReplaceBinExprOp_6(53L, () => MutateCSharp.Schemata108.ReplaceBinExprOp_6(47L, () => MutateCSharp.Schemata108.ReplaceBinExprOp_6(41L, () => MutateCSharp.Schemata108.ReplaceBinExprOp_6(34L, () => Body is null, () => HasPostcondition), () => MutateCSharp.Schemata108.ReplaceBinExprOp_10(40L, EnclosingClass.EnclosingModuleDefinition.ModuleKind, ModuleKindEnum.Concrete)), () => !HasExternAttribute), () => !HasAxiomAttribute))
            {
                yield return new Assumption(this, tok, AssumptionDescription.NoBody(IsGhost));
            }

            if (MutateCSharp.Schemata108.ReplaceBinExprOp_6(65L, () => MutateCSharp.Schemata108.ReplaceBinExprOp_6(59L, () => HasExternAttribute, () => HasPostcondition), () => !HasAxiomAttribute))
            {
                yield return new Assumption(this, tok, AssumptionDescription.ExternWithPostcondition);
            }

            if (MutateCSharp.Schemata108.ReplaceBinExprOp_6(77L, () => MutateCSharp.Schemata108.ReplaceBinExprOp_6(71L, () => HasExternAttribute, () => HasPrecondition), () => !HasAxiomAttribute))
            {
                yield return new Assumption(this, tok, AssumptionDescription.ExternWithPrecondition);
            }

            if (Attributes.Contains(Reads.Attributes, Attributes.AssumeConcurrentAttributeName))
            {
                yield return new Assumption(this, tok, AssumptionDescription.HasAssumeConcurrentAttribute(MutateCSharp.Schemata108.ReplaceBooleanConstant_1(83L, false)));
            }
            if (Attributes.Contains(Mod.Attributes, Attributes.AssumeConcurrentAttributeName))
            {
                yield return new Assumption(this, tok, AssumptionDescription.HasAssumeConcurrentAttribute(MutateCSharp.Schemata108.ReplaceBooleanConstant_1(84L, true)));
            }

            if (AllowsNontermination)
            {
                yield return new Assumption(this, tok, AssumptionDescription.MayNotTerminate);
            }

            foreach (var c in this.Descendants())
            {
                foreach (var a in (c as Node)?.Assumptions(this) ?? Enumerable.Empty<Assumption>())
                {
                    yield return a;
                }
            }

            yield break;
        }

        public override IEnumerable<Expression> SubExpressions
        {
            get
            {
                foreach (var formal in Ins.Where(f => MutateCSharp.Schemata108.ReplaceBinExprOp_11(85L, f.DefaultValue, null)))
                {
                    yield return formal.DefaultValue;
                }
                foreach (var e in Req)
                {
                    yield return e.E;
                }
                foreach (var e in Reads.Expressions)
                {
                    yield return e.E;
                }
                foreach (var e in Mod.Expressions)
                {
                    yield return e.E;
                }
                foreach (var e in Ens)
                {
                    yield return e.E;
                }
                foreach (var e in Decreases.Expressions)
                {
                    yield return e;
                }

                yield break;
            }
        }

        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(cce.NonNullElements(TypeArgs));
            Contract.Invariant(cce.NonNullElements(Ins));
            Contract.Invariant(cce.NonNullElements(Outs));
            Contract.Invariant(cce.NonNullElements(Req));
            Contract.Invariant(Reads != null);
            Contract.Invariant(Mod != null);
            Contract.Invariant(cce.NonNullElements(Ens));
            Contract.Invariant(Decreases != null);
        }

        public Method(Cloner cloner, Method original) : base(cloner, original)
        {
            if (MutateCSharp.Schemata108.ReplaceBinExprOp_12(86L, original.Outs, null))
            {
                this.Outs = original.Outs.ConvertAll(p => cloner.CloneFormal(p, MutateCSharp.Schemata108.ReplaceBooleanConstant_1(87L, false)));
            }

            this.Reads = cloner.CloneSpecFrameExpr(original.Reads);
            this.Mod = cloner.CloneSpecFrameExpr(original.Mod);
            this.Body = cloner.CloneMethodBody(original);
            this.SignatureEllipsis = original.SignatureEllipsis;
            this.IsByMethod = original.IsByMethod;
        }

        public Method(RangeToken rangeToken, Name name,
          bool hasStaticKeyword, bool isGhost,
          [Captured] List<TypeParameter> typeArgs,
          [Captured] List<Formal> ins, [Captured] List<Formal> outs,
          [Captured] List<AttributedExpression> req,
          [Captured] Specification<FrameExpression> reads,
          [Captured] Specification<FrameExpression> mod,
          [Captured] List<AttributedExpression> ens,
          [Captured] Specification<Expression> decreases,
          [Captured] BlockStmt body,
          Attributes attributes, IToken signatureEllipsis, bool isByMethod = false)
          : base(rangeToken, name, hasStaticKeyword, isGhost, attributes, MutateCSharp.Schemata108.ReplaceBinExprOp_3(88L, signatureEllipsis, null),
            typeArgs, ins, req, ens, decreases)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            Contract.Requires(cce.NonNullElements(typeArgs));
            Contract.Requires(cce.NonNullElements(ins));
            Contract.Requires(cce.NonNullElements(outs));
            Contract.Requires(cce.NonNullElements(req));
            Contract.Requires(reads != null);
            Contract.Requires(mod != null);
            Contract.Requires(cce.NonNullElements(ens));
            Contract.Requires(decreases != null);
            this.Outs = outs;
            this.Reads = reads;
            this.Mod = mod;
            Body = body;
            this.SignatureEllipsis = signatureEllipsis;
            this.IsByMethod = isByMethod;
            MustReverify = MutateCSharp.Schemata108.ReplaceBooleanConstant_1(89L, false);
        }

        bool ICodeContext.IsGhost
        {
            get { return this.IsGhost; }
        }

        List<TypeParameter> ICodeContext.TypeArgs
        {
            get { return this.TypeArgs; }
        }

        List<Formal> ICodeContext.Ins
        {
            get { return this.Ins; }
        }

        List<Formal> IMethodCodeContext.Outs
        {
            get { return this.Outs; }
        }

        Specification<FrameExpression> IMethodCodeContext.Modifies
        {
            get { return Mod; }
        }

        string ICallable.NameRelativeToModule
        {
            get
            {
                if (EnclosingClass is DefaultClassDecl)
                {
                    return Name;
                }
                else
                {
                    return EnclosingClass.Name + MutateCSharp.Schemata108.ReplaceStringConstant_0(90L, ".") + Name;
                }

                return default;
            }
        }

        Specification<Expression> ICallable.Decreases
        {
            get { return this.Decreases; }
        }

        bool _inferredDecr;
        bool ICallable.InferredDecreases
        {
            set { _inferredDecr = value; }
            get { return _inferredDecr; }
        }

        public virtual bool AllowsAllocation => MutateCSharp.Schemata108.ReplaceBooleanConstant_1(91L, true);

        ModuleDefinition IASTVisitorContext.EnclosingModule
        {
            get
            {
                Contract.Assert(this.EnclosingClass != null);  // this getter is supposed to be called only after signature-resolution is complete
                return this.EnclosingClass.EnclosingModuleDefinition;
            }
        }

        bool ICodeContext.MustReverify
        {
            get { return this.MustReverify; }
        }

        public bool AllowsNontermination
        {
            get
            {
                return Contract.Exists(Decreases.Expressions, e => e is WildcardExpr);
            }
        }

        public override string GetCompileName(DafnyOptions options)
        {
            var nm = base.GetCompileName(options);
            if (MutateCSharp.Schemata108.ReplaceBinExprOp_6(99L, () => MutateCSharp.Schemata108.ReplaceBinExprOp_6(93L, () => MutateCSharp.Schemata108.ReplaceBinExprOp_13(92L, nm, Dafny.Compilers.SinglePassCodeGenerator.DefaultNameMain), () => IsStatic), () => !IsEntryPoint))
            {
                // for a static method that is named "Main" but is not a legal "Main" method,
                // change its name.
                nm = EnclosingClass.Name + MutateCSharp.Schemata108.ReplaceStringConstant_0(105L, "_") + nm;
            }

            return nm;
        }

        public BlockStmt Body { get; set; }

        public bool IsLemmaLike => MutateCSharp.Schemata108.ReplaceBinExprOp_9(118L, () => MutateCSharp.Schemata108.ReplaceBinExprOp_9(112L, () => MutateCSharp.Schemata108.ReplaceBinExprOp_9(106L, () => this is Lemma, () => this is TwoStateLemma), () => this is ExtremeLemma), () => this is PrefixLemma);

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            formatter.SetMethodLikeIndent(StartToken, OwnedTokens, indentBefore);
            if (MutateCSharp.Schemata108.ReplaceBinExprOp_8(128L, BodyStartTok.line, MutateCSharp.Schemata108.ReplaceNumericConstant_7(124L, 0)))
            {
                formatter.SetDelimiterIndentedRegions(BodyStartTok, indentBefore);
            }

            formatter.SetFormalsIndentation(Ins);
            formatter.SetFormalsIndentation(Outs);
            foreach (var req in Req)
            {
                formatter.SetAttributedExpressionIndentation(req, MutateCSharp.Schemata108.ReplaceBinExprOp_14(133L, indentBefore, formatter.SpaceTab));
            }

            foreach (var read in Reads.Expressions)
            {
                formatter.SetFrameExpressionIndentation(read, MutateCSharp.Schemata108.ReplaceBinExprOp_14(142L, indentBefore, formatter.SpaceTab));
            }

            foreach (var mod in Mod.Expressions)
            {
                formatter.SetFrameExpressionIndentation(mod, MutateCSharp.Schemata108.ReplaceBinExprOp_14(151L, indentBefore, formatter.SpaceTab));
            }

            foreach (var ens in Ens)
            {
                formatter.SetAttributedExpressionIndentation(ens, MutateCSharp.Schemata108.ReplaceBinExprOp_14(160L, indentBefore, formatter.SpaceTab));
            }

            foreach (var dec in Decreases.Expressions)
            {
                formatter.SetDecreasesExpressionIndentation(dec, MutateCSharp.Schemata108.ReplaceBinExprOp_14(169L, indentBefore, formatter.SpaceTab));
                formatter.SetExpressionIndentation(dec);
            }

            if (MutateCSharp.Schemata108.ReplaceBinExprOp_5(178L, Body, null))
            {
                formatter.SetStatementIndentation(this.Body);
            }

            return MutateCSharp.Schemata108.ReplaceBooleanConstant_1(179L, true);
        }

        protected override bool Bodyless => MutateCSharp.Schemata108.ReplaceBinExprOp_15(180L, Body, null);
        protected override string TypeName => MutateCSharp.Schemata108.ReplaceStringConstant_0(181L, "method");

        /// <summary>
        /// Assumes type parameters have already been pushed
        /// </summary>
        public override void Resolve(ModuleResolver resolver)
        {
            Contract.Requires(this != null);
            Contract.Requires(resolver.AllTypeConstraints.Count == 0);
            Contract.Ensures(resolver.AllTypeConstraints.Count == 0);

            ResolveMethodOrFunction(resolver);

            try
            {
                resolver.currentMethod = this;

                // make note of the warnShadowing attribute
                bool warnShadowingOption = resolver.Options.WarnShadowing;  // save the original warnShadowing value
                bool warnShadowing = MutateCSharp.Schemata108.ReplaceBooleanConstant_1(182L, true);
                if (Attributes.ContainsBool(Attributes, MutateCSharp.Schemata108.ReplaceStringConstant_0(183L, "warnShadowing"), ref warnShadowing))
                {
                    resolver.Options.WarnShadowing = warnShadowing;  // set the value according to the attribute
                }

                // Add in-parameters to the scope, but don't care about any duplication errors, since they have already been reported
                resolver.scope.PushMarker();
                if (MutateCSharp.Schemata108.ReplaceBinExprOp_9(184L, () => IsStatic, () => this is Constructor))
                {
                    resolver.scope.AllowInstance = MutateCSharp.Schemata108.ReplaceBooleanConstant_1(190L, false);
                }
                foreach (Formal p in Ins)
                {
                    resolver.scope.Push(p.Name, p);
                }

                resolver.ResolveParameterDefaultValues(Ins, new ResolutionContext(this, this is TwoStateLemma));

                // Start resolving specification...
                foreach (AttributedExpression e in Req)
                {
                    resolver.ResolveAttributes(e, new ResolutionContext(this, this is TwoStateLemma));
                    resolver.ResolveExpression(e.E, new ResolutionContext(this, this is TwoStateLemma));
                    Contract.Assert(e.E.Type != null);  // follows from postcondition of ResolveExpression
                    resolver.ConstrainTypeExprBool(e.E, MutateCSharp.Schemata108.ReplaceStringConstant_0(191L, "Precondition must be a boolean (got {0})"));
                }

                resolver.ResolveAttributes(Reads, new ResolutionContext(this, MutateCSharp.Schemata108.ReplaceBooleanConstant_1(192L, false)));
                foreach (FrameExpression fe in Reads.Expressions)
                {
                    resolver.ResolveFrameExpressionTopLevel(fe, FrameExpressionUse.Reads, this);
                }

                resolver.ResolveAttributes(Mod, new ResolutionContext(this, MutateCSharp.Schemata108.ReplaceBooleanConstant_1(193L, false)));
                foreach (FrameExpression fe in Mod.Expressions)
                {
                    resolver.ResolveFrameExpressionTopLevel(fe, FrameExpressionUse.Modifies, this);
                }

                resolver.ResolveAttributes(Decreases, new ResolutionContext(this, MutateCSharp.Schemata108.ReplaceBooleanConstant_1(194L, false)));
                foreach (Expression e in Decreases.Expressions)
                {
                    resolver.ResolveExpression(e, new ResolutionContext(this, this is TwoStateLemma));
                    // any type is fine
                }

                if (this is Constructor)
                {
                    resolver.scope.PopMarker();
                    // start the scope again, but this time allowing instance
                    resolver.scope.PushMarker();
                    foreach (Formal p in Ins)
                    {
                        resolver.scope.Push(p.Name, p);
                    }
                }

                // Add out-parameters to a new scope that will also include the outermost-level locals of the body
                // Don't care about any duplication errors among the out-parameters, since they have already been reported
                resolver.scope.PushMarker();
                if (MutateCSharp.Schemata108.ReplaceBinExprOp_6(204L, () => this is ExtremeLemma, () => MutateCSharp.Schemata108.ReplaceBinExprOp_16(199L, Outs.Count, MutateCSharp.Schemata108.ReplaceNumericConstant_7(195L, 0))))
                {
                    resolver.reporter.Error(MessageSource.Resolver, Outs[MutateCSharp.Schemata108.ReplaceNumericConstant_7(210L, 0)].tok, MutateCSharp.Schemata108.ReplaceStringConstant_0(214L, "{0}s are not allowed to have out-parameters"), WhatKind);
                }
                else
                {
                    foreach (Formal p in Outs)
                    {
                        resolver.scope.Push(p.Name, p);
                    }
                }

                // ... continue resolving specification
                foreach (AttributedExpression e in Ens)
                {
                    resolver.ResolveAttributes(e, new ResolutionContext(this, MutateCSharp.Schemata108.ReplaceBooleanConstant_1(215L, true)));
                    resolver.ResolveExpression(e.E, new ResolutionContext(this, MutateCSharp.Schemata108.ReplaceBooleanConstant_1(216L, true)));
                    Contract.Assert(e.E.Type != null);  // follows from postcondition of ResolveExpression
                    resolver.ConstrainTypeExprBool(e.E, MutateCSharp.Schemata108.ReplaceStringConstant_0(217L, "Postcondition must be a boolean (got {0})"));
                }

                resolver.SolveAllTypeConstraints(); // solve type constraints for specification

                // Resolve body
                if (MutateCSharp.Schemata108.ReplaceBinExprOp_5(218L, Body, null))
                {
                    if (this is ExtremeLemma com && MutateCSharp.Schemata108.ReplaceBinExprOp_17(219L, com.PrefixLemma, null))
                    {
                        // The body may mentioned the implicitly declared parameter _k.  Throw it into the
                        // scope before resolving the body.
                        var k = com.PrefixLemma.Ins[MutateCSharp.Schemata108.ReplaceNumericConstant_7(220L, 0)];
                        resolver.scope.Push(k.Name, k);  // we expect no name conflict for _k
                    }

                    resolver.DominatingStatementLabels.PushMarker();
                    foreach (var req in Req)
                    {
                        if (MutateCSharp.Schemata108.ReplaceBinExprOp_18(224L, req.Label, null))
                        {
                            if (MutateCSharp.Schemata108.ReplaceBinExprOp_19(225L, resolver.DominatingStatementLabels.Find(req.Label.Name), null))
                            {
                                resolver.reporter.Error(MessageSource.Resolver, req.Label.Tok, MutateCSharp.Schemata108.ReplaceStringConstant_0(226L, "assert label shadows a dominating label"));
                            }
                            else
                            {
                                var rr = resolver.DominatingStatementLabels.Push(req.Label.Name, req.Label);
                                Contract.Assert(rr == Scope<Label>.PushResult.Success);  // since we just checked for duplicates, we expect the Push to succeed
                            }
                        }
                    }

                    resolver.ResolveBlockStatement(Body, ResolutionContext.FromCodeContext(this));
                    resolver.DominatingStatementLabels.PopMarker();
                    resolver.SolveAllTypeConstraints();
                }

                // attributes are allowed to mention both in- and out-parameters (including the implicit _k, for greatest lemmas)
                resolver.ResolveAttributes(this, new ResolutionContext(this, this is TwoStateLemma), MutateCSharp.Schemata108.ReplaceBooleanConstant_1(227L, true));

                resolver.Options.WarnShadowing = warnShadowingOption; // restore the original warnShadowing value
                resolver.scope.PopMarker();  // for the out-parameters and outermost-level locals
                resolver.scope.PopMarker();  // for the in-parameters

            }
            finally
            {
                resolver.currentMethod = null;
            }
        }

        public string GetTriviaContainingDocstring()
        {
            IToken lastClosingParenthesis = null;
            foreach (var token in OwnedTokens)
            {
                if (MutateCSharp.Schemata108.ReplaceBinExprOp_13(229L, token.val, MutateCSharp.Schemata108.ReplaceStringConstant_0(228L, ")")))
                {
                    lastClosingParenthesis = token;
                }
            }

            if (MutateCSharp.Schemata108.ReplaceBinExprOp_6(232L, () => MutateCSharp.Schemata108.ReplaceBinExprOp_3(230L, lastClosingParenthesis, null), () => MutateCSharp.Schemata108.ReplaceBinExprOp_20(231L, lastClosingParenthesis.TrailingTrivia.Trim(), "")))
            {
                return lastClosingParenthesis.TrailingTrivia;
            }

            return GetTriviaContainingDocstringFromStartTokenOrNull();
        }

        public virtual SymbolKind Kind => SymbolKind.Method;
        public string GetDescription(DafnyOptions options)
        {
            var qualifiedName = GetQualifiedName();
            var signatureWithoutReturn = $"{WhatKind} {qualifiedName}({string.Join(MutateCSharp.Schemata108.ReplaceStringConstant_0(238L, ", "), Ins.Select(i => i.AsText()))})";
            if (MutateCSharp.Schemata108.ReplaceBinExprOp_21(243L, Outs.Count, MutateCSharp.Schemata108.ReplaceNumericConstant_7(239L, 0)))
            {
                return signatureWithoutReturn;
            }
            return $"{signatureWithoutReturn} returns ({string.Join(MutateCSharp.Schemata108.ReplaceStringConstant_0(248L, ", "), Outs.Select(o => o.AsText()))})";
        }

        protected virtual string GetQualifiedName()
        {
            return $"{AstExtensions.GetMemberQualification(this)}{Name}";
        }

        public IEnumerable<ISymbol> ChildSymbols
        {
            get
            {
                IEnumerable<INode> childStatements = Body?.Visit(node => node is Statement) ?? Enumerable.Empty<INode>();
                return Outs.Concat(childStatements.OfType<VarDeclStmt>().SelectMany(v => (IEnumerable<ISymbol>)v.Locals));
            }
        }

        public bool ShouldVerify => MutateCSharp.Schemata108.ReplaceBooleanConstant_1(249L, true); // This could be made more accurate
        public ModuleDefinition ContainingModule => EnclosingClass.EnclosingModuleDefinition;

        public void AutoRevealDependencies(AutoRevealFunctionDependencies Rewriter, DafnyOptions Options,
          ErrorReporter Reporter)
        {
            if (Body is null)
            {
                return;
            }

            object autoRevealDepsVal = null;
            bool autoRevealDeps = Attributes.ContainsMatchingValue(Attributes, MutateCSharp.Schemata108.ReplaceStringConstant_0(250L, "autoRevealDependencies"),
              ref autoRevealDepsVal, new List<Attributes.MatchingValueOption> {
        Attributes.MatchingValueOption.Bool,
        Attributes.MatchingValueOption.Int
              }, s => Reporter.Error(MessageSource.Rewriter, ErrorLevel.Error, Tok, s));

            // Default behavior is reveal all dependencies
            int autoRevealDepth = int.MaxValue;

            if (autoRevealDeps)
            {
                if (autoRevealDepsVal is false)
                {
                    autoRevealDepth = MutateCSharp.Schemata108.ReplaceNumericConstant_7(251L, 0);
                }
                else if (autoRevealDepsVal is BigInteger i)
                {
                    autoRevealDepth = (int)i;
                }
            }

            var currentClass = EnclosingClass;
            List<AutoRevealFunctionDependencies.RevealStmtWithDepth> addedReveals = new();

            foreach (var func in Rewriter.GetEnumerator(this, currentClass, SubExpressions))
            {
                var revealStmt =
                  AutoRevealFunctionDependencies.BuildRevealStmt(func.Function, Tok, EnclosingClass.EnclosingModuleDefinition);

                if (revealStmt is not null)
                {
                    addedReveals.Add(new AutoRevealFunctionDependencies.RevealStmtWithDepth(revealStmt, func.Depth));
                }
            }

            if (MutateCSharp.Schemata108.ReplaceBinExprOp_8(259L, autoRevealDepth, MutateCSharp.Schemata108.ReplaceNumericConstant_7(255L, 0)))
            {
                Expression reqExpr = Expression.CreateBoolLiteral(Tok, MutateCSharp.Schemata108.ReplaceBooleanConstant_1(264L, true));

                foreach (var revealStmt in addedReveals)
                {
                    if (MutateCSharp.Schemata108.ReplaceBinExprOp_22(265L, revealStmt.Depth, autoRevealDepth))
                    {
                        if (this is Constructor c)
                        {
                            c.BodyInit.Insert(MutateCSharp.Schemata108.ReplaceNumericConstant_7(270L, 0), revealStmt.RevealStmt);
                        }
                        else
                        {
                            Body.Body.Insert(MutateCSharp.Schemata108.ReplaceNumericConstant_7(274L, 0), revealStmt.RevealStmt);
                        }

                        reqExpr = new StmtExpr(reqExpr.tok, revealStmt.RevealStmt, reqExpr)
                        {
                            Type = Type.Bool
                        };
                    }
                    else
                    {
                        break;
                    }
                }

                if (MutateCSharp.Schemata108.ReplaceBinExprOp_9(278L, () => Req.Any(), () => Ens.Any()))
                {
                    Req.Insert(MutateCSharp.Schemata108.ReplaceNumericConstant_7(284L, 0), new AttributedExpression(reqExpr));
                }
            }

            if (addedReveals.Any())
            {
                Reporter.Message(MessageSource.Rewriter, ErrorLevel.Info, null, tok,
                  AutoRevealFunctionDependencies.GenerateMessage(addedReveals, autoRevealDepth));
            }
        }
        public string Designator => WhatKind;

        public void ResolveNewOrOldPart(INewOrOldResolver resolver)
        {
            ResolveMethodOrFunction(resolver);
        }
    }
}
