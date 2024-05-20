using System.Collections.Generic;
using System.CommandLine;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Numerics;
using DafnyCore;
using Microsoft.Dafny.Auditor;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
namespace MutateCSharp
{
    internal class Schemata103
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT103");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.Formal argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.Function.TailStatus argument1, Microsoft.Dafny.Function.TailStatus argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.CommonOptionBag.DefaultFunctionOpacityOptions argument1, Microsoft.Dafny.CommonOptionBag.DefaultFunctionOpacityOptions argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, string argument1, string argument2)
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

        internal static bool ReplaceBinExprOp_21(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, Microsoft.Dafny.Function argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.FunctionSyntaxOptions argument1, Microsoft.Dafny.FunctionSyntaxOptions argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.ModuleKindEnum argument1, Microsoft.Dafny.ModuleKindEnum argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_27(long mutantId, Microsoft.Dafny.AssertLabel argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_28(long mutantId, Microsoft.Dafny.Label argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_29(long mutantId, Microsoft.Dafny.Method argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_23(long mutantId, Microsoft.Dafny.LiteralExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_30(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_26(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_18(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceNumericConstant_9(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_8(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_24(long mutantId, Microsoft.Dafny.Function argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_25(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_31(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.FunctionSyntaxOptions argument1, Microsoft.Dafny.FunctionSyntaxOptions argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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
    public class Function : MethodOrFunction, TypeParameter.ParentType, ICallable, ICanFormat, IHasDocstring,
      ICanAutoRevealDependencies, ICanVerify
    {
        public override string WhatKind => MutateCSharp.Schemata103.ReplaceStringConstant_0(1L, "function");

        public string GetFunctionDeclarationKeywords(DafnyOptions options)
        {
            string k;
            if (MutateCSharp.Schemata103.ReplaceBinExprOp_1(9L, () => MutateCSharp.Schemata103.ReplaceBinExprOp_1(2L, () => this is TwoStateFunction, () => this is ExtremePredicate), () => MutateCSharp.Schemata103.ReplaceBinExprOp_2(8L, this.ByMethodBody, null)))
            {
                k = WhatKind;
            }
            else if (this is PrefixPredicate)
            {
                k = MutateCSharp.Schemata103.ReplaceStringConstant_0(15L, "predicate");
            }
            else if (MutateCSharp.Schemata103.ReplaceBinExprOp_4(23L, () => MutateCSharp.Schemata103.ReplaceBinExprOp_3(16L, options.FunctionSyntax, FunctionSyntaxOptions.ExperimentalPredicateAlwaysGhost), () => (MutateCSharp.Schemata103.ReplaceBinExprOp_1(17L, () => this is Predicate, () => !IsGhost))))
            {
                k = WhatKind;
            }
            else if (MutateCSharp.Schemata103.ReplaceBinExprOp_4(30L, () => MutateCSharp.Schemata103.ReplaceBinExprOp_5(29L, options.FunctionSyntax, FunctionSyntaxOptions.Version4), () => !IsGhost))
            {
                k = WhatKind + MutateCSharp.Schemata103.ReplaceStringConstant_0(36L, " method");
            }
            else if (MutateCSharp.Schemata103.ReplaceBinExprOp_4(38L, () => MutateCSharp.Schemata103.ReplaceBinExprOp_5(37L, options.FunctionSyntax, FunctionSyntaxOptions.Version3), () => IsGhost))
            {
                k = MutateCSharp.Schemata103.ReplaceStringConstant_0(44L, "ghost ") + WhatKind;
            }
            else
            {
                k = WhatKind;
            }

            // If this function is opaque due to the opaque keyword, include it.
            k = (MutateCSharp.Schemata103.ReplaceBinExprOp_4(46L, () => IsOpaque, () => !Attributes.Contains(Attributes, MutateCSharp.Schemata103.ReplaceStringConstant_0(45L, "opaque")))) ? MutateCSharp.Schemata103.ReplaceStringConstant_0(52L, "opaque ") + k : k;
            return HasStaticKeyword ? MutateCSharp.Schemata103.ReplaceStringConstant_0(53L, "static ") + k : k;
        }

        public override bool IsOpaque { get; }

        public bool IsMadeImplicitlyOpaque(DafnyOptions options)
        {
            return MutateCSharp.Schemata103.ReplaceBinExprOp_4(97L, () => MutateCSharp.Schemata103.ReplaceBinExprOp_4(90L, () => MutateCSharp.Schemata103.ReplaceBinExprOp_4(82L, () => MutateCSharp.Schemata103.ReplaceBinExprOp_4(74L, () => MutateCSharp.Schemata103.ReplaceBinExprOp_4(68L, () => MutateCSharp.Schemata103.ReplaceBinExprOp_4(62L, () => MutateCSharp.Schemata103.ReplaceBinExprOp_4(55L, () => !IsOpaque, () => !Attributes.Contains(Attributes, MutateCSharp.Schemata103.ReplaceStringConstant_0(54L, "opaque"))), () => MutateCSharp.Schemata103.ReplaceBinExprOp_6(61L, options.Get(CommonOptionBag.DefaultFunctionOpacity), CommonOptionBag.DefaultFunctionOpacityOptions.Transparent
                   )), () => this is not ExtremePredicate
                   ), () => this is not PrefixPredicate
                   ), () => MutateCSharp.Schemata103.ReplaceBinExprOp_7(81L, Name, MutateCSharp.Schemata103.ReplaceStringConstant_0(80L, "reads"))), () => MutateCSharp.Schemata103.ReplaceBinExprOp_7(89L, Name, MutateCSharp.Schemata103.ReplaceStringConstant_0(88L, "requires"
                   ))), () => !Attributes.Contains(this.Attributes, MutateCSharp.Schemata103.ReplaceStringConstant_0(96L, "transparent")));
        }

        public override bool CanBeRevealed()
        {
            return MutateCSharp.Schemata103.ReplaceBooleanConstant_8(103L, true);
        }

        public override bool HasPostcondition => MutateCSharp.Schemata103.ReplaceBinExprOp_1(113L, () => MutateCSharp.Schemata103.ReplaceBinExprOp_10(108L, Ens.Count, MutateCSharp.Schemata103.ReplaceNumericConstant_9(104L, 0)), () => ResultType.AsSubsetType is not null);

        public override IEnumerable<Assumption> Assumptions(Declaration decl)
        {
            foreach (var a in base.Assumptions(this))
            {
                yield return a;
            }

            if (MutateCSharp.Schemata103.ReplaceBinExprOp_4(138L, () => MutateCSharp.Schemata103.ReplaceBinExprOp_4(132L, () => MutateCSharp.Schemata103.ReplaceBinExprOp_4(126L, () => MutateCSharp.Schemata103.ReplaceBinExprOp_4(119L, () => Body is null, () => HasPostcondition), () => MutateCSharp.Schemata103.ReplaceBinExprOp_11(125L, EnclosingClass.EnclosingModuleDefinition.ModuleKind, ModuleKindEnum.Concrete)), () => !HasExternAttribute), () => !HasAxiomAttribute))
            {
                yield return new Assumption(this, tok, AssumptionDescription.NoBody(IsGhost));
            }

            if (HasExternAttribute)
            {
                yield return new Assumption(this, tok, AssumptionDescription.ExternFunction);
                if (MutateCSharp.Schemata103.ReplaceBinExprOp_4(144L, () => HasPostcondition, () => !HasAxiomAttribute))
                {
                    yield return new Assumption(this, tok, AssumptionDescription.ExternWithPostcondition);
                }
            }

            if (MutateCSharp.Schemata103.ReplaceBinExprOp_4(156L, () => MutateCSharp.Schemata103.ReplaceBinExprOp_4(150L, () => HasExternAttribute, () => HasPrecondition), () => !HasAxiomAttribute))
            {
                yield return new Assumption(this, tok, AssumptionDescription.ExternWithPrecondition);
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

        [FilledInDuringResolution] public bool IsRecursive;

        [FilledInDuringResolution]
        public TailStatus
          TailRecursion =
            TailStatus.NotTailRecursive; // NotTailRecursive = no tail recursion; TriviallyTailRecursive is never used here

        public bool IsTailRecursive => MutateCSharp.Schemata103.ReplaceBinExprOp_12(162L, TailRecursion, TailStatus.NotTailRecursive);
        public bool IsAccumulatorTailRecursive => MutateCSharp.Schemata103.ReplaceBinExprOp_4(164L, () => IsTailRecursive, () => MutateCSharp.Schemata103.ReplaceBinExprOp_12(163L, TailRecursion, TailStatus.TailRecursive));
        [FilledInDuringResolution] public bool IsFueled; // if anyone tries to adjust this function's fuel
        public readonly Formal Result;
        public PreType ResultPreType;
        public readonly Type ResultType;
        public readonly Specification<FrameExpression> Reads;
        public Expression Body; // an extended expression; Body is readonly after construction, except for any kind of rewrite that may take place around the time of resolution
        public IToken /*?*/ ByMethodTok; // null iff ByMethodBody is null
        public BlockStmt /*?*/ ByMethodBody;
        [FilledInDuringResolution] public Method /*?*/ ByMethodDecl; // if ByMethodBody is non-null
        public bool SignatureIsOmitted => MutateCSharp.Schemata103.ReplaceBinExprOp_13(170L, SignatureEllipsis, null); // is "false" for all Function objects that survive into resolution
        public readonly IToken SignatureEllipsis;
        public Function OverriddenFunction;
        public Function Original => MutateCSharp.Schemata103.ReplaceBinExprOp_14(171L, OverriddenFunction, null) ? this : OverriddenFunction.Original;
        public override bool IsOverrideThatAddsBody => MutateCSharp.Schemata103.ReplaceBinExprOp_4(173L, () => base.IsOverrideThatAddsBody, () => MutateCSharp.Schemata103.ReplaceBinExprOp_15(172L, Body, null));
        public bool AllowsAllocation => MutateCSharp.Schemata103.ReplaceBooleanConstant_8(179L, true);
        public bool containsQuantifier;

        public bool ContainsQuantifier
        {
            set { containsQuantifier = value; }
            get { return containsQuantifier; }
        }

        public enum TailStatus
        {
            TriviallyTailRecursive, // contains no recursive calls (in non-ghost expressions)
            TailRecursive, // all recursive calls (in non-ghost expressions) are tail calls
            NotTailRecursive, // contains some non-ghost recursive call outside of a tail-call position
                              // E + F or F + E, where E has no tail call and F is a tail call
            Accumulate_Add,
            AccumulateRight_Sub,
            Accumulate_Mul,
            Accumulate_SetUnion,
            AccumulateRight_SetDifference,
            Accumulate_MultiSetUnion,
            AccumulateRight_MultiSetDifference,
            AccumulateLeft_Concat,
            AccumulateRight_Concat,
        }

        public override IEnumerable<INode> Children => new[] { ByMethodBody }.Where(x => MutateCSharp.Schemata103.ReplaceBinExprOp_2(180L, x, null)).
          Concat<Node>(TypeArgs).
          Concat<Node>(Reads.Expressions).
          Concat<Node>(Req).
          Concat(Ens.Select(e => e.E)).
          Concat(Decreases.Expressions).
          Concat(Ins).
          Concat(MutateCSharp.Schemata103.ReplaceBinExprOp_16(181L, Result, null) ? new List<Node>() { Result } : new List<Node>()).
          Concat(MutateCSharp.Schemata103.ReplaceBinExprOp_17(182L, ResultType, null) ? new List<Node>() { ResultType } : new List<Node>()).
          Concat(MutateCSharp.Schemata103.ReplaceBinExprOp_18(183L, Body, null) ? Enumerable.Empty<Node>() : new[] { Body });

        public override IEnumerable<INode> PreResolveChildren =>
          TypeArgs.
          Concat<Node>(Reads.Expressions).
          Concat<Node>(Req).
          Concat(Ens).
          Concat(Decreases.Expressions.Where(expression => expression is not AutoGeneratedExpression)).
          Concat(Ins).Concat(MutateCSharp.Schemata103.ReplaceBinExprOp_4(194L, () => MutateCSharp.Schemata103.ReplaceBinExprOp_17(184L, ResultType, null), () => MutateCSharp.Schemata103.ReplaceBinExprOp_10(189L, ResultType.tok.line, MutateCSharp.Schemata103.ReplaceNumericConstant_9(185L, 0))) ? new List<Node>() { ResultType } : new List<Node>()).
          Concat(MutateCSharp.Schemata103.ReplaceBinExprOp_18(200L, Body, null) ? Enumerable.Empty<Node>() : new[] { Body }).
          Concat(MutateCSharp.Schemata103.ReplaceBinExprOp_19(201L, ByMethodBody, null) ? Enumerable.Empty<Node>() : new[] { ByMethodBody });

        public override IEnumerable<Expression> SubExpressions
        {
            get
            {
                foreach (var formal in Ins.Where(f => MutateCSharp.Schemata103.ReplaceBinExprOp_15(202L, f.DefaultValue, null)))
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
                foreach (var e in Ens)
                {
                    yield return e.E;
                }
                foreach (var e in Decreases.Expressions)
                {
                    yield return e;
                }
                if (MutateCSharp.Schemata103.ReplaceBinExprOp_15(203L, Body, null))
                {
                    yield return Body;
                }

                yield break;
            }
        }

        public Type GetMemberType(ArrowTypeDecl atd)
        {
            Contract.Requires(atd != null);
            Contract.Requires(atd.Arity == Ins.Count);

            // Note, the following returned type can contain type parameters from the function and its enclosing class
            return new ArrowType(tok, atd, Ins.ConvertAll(f => f.Type), ResultType);
        }

        public bool AllowsNontermination
        {
            get
            {
                return Contract.Exists(Decreases.Expressions, e => e is WildcardExpr);
            }
        }

        /// <summary>
        /// The "AllCalls" field is used for non-ExtremePredicate, non-PrefixPredicate functions only (so its value should not be relied upon for ExtremePredicate and PrefixPredicate functions).
        /// It records all function calls made by the Function, including calls made in the body as well as in the specification.
        /// The field is filled in during resolution (and used toward the end of resolution, to attach a helpful "decreases" prefix to functions in clusters
        /// with co-recursive calls.
        /// </summary>
        public readonly List<FunctionCallExpr> AllCalls = new List<FunctionCallExpr>();
        public enum CoCallClusterInvolvement
        {
            None,  // the SCC containing the function does not involve any co-recursive calls
            IsMutuallyRecursiveTarget,  // the SCC contains co-recursive calls, and this function is the target of some non-self recursive call
            CoRecursiveTargetAllTheWay,  // the SCC contains co-recursive calls, and this function is the target only of self-recursive calls and co-recursive calls
        }
        public CoCallClusterInvolvement CoClusterTarget = CoCallClusterInvolvement.None;

        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(cce.NonNullElements(TypeArgs));
            Contract.Invariant(cce.NonNullElements(Ins));
            Contract.Invariant(ResultType != null);
            Contract.Invariant(cce.NonNullElements(Req));
            Contract.Invariant(Reads != null);
            Contract.Invariant(cce.NonNullElements(Ens));
            Contract.Invariant(Decreases != null);
        }

        public Function(RangeToken range, Name name, bool hasStaticKeyword, bool isGhost, bool isOpaque,
          List<TypeParameter> typeArgs, List<Formal> ins, Formal result, Type resultType,
          List<AttributedExpression> req, Specification<FrameExpression> reads, List<AttributedExpression> ens, Specification<Expression> decreases,
          Expression/*?*/ body, IToken/*?*/ byMethodTok, BlockStmt/*?*/ byMethodBody,
          Attributes attributes, IToken/*?*/ signatureEllipsis)
          : base(range, name, hasStaticKeyword, isGhost, attributes, MutateCSharp.Schemata103.ReplaceBinExprOp_13(204L, signatureEllipsis, null), typeArgs, ins, req, ens, decreases)
        {

            Contract.Requires(tok != null);
            Contract.Requires(name != null);
            Contract.Requires(cce.NonNullElements(typeArgs));
            Contract.Requires(cce.NonNullElements(ins));
            Contract.Requires(resultType != null);
            Contract.Requires(cce.NonNullElements(req));
            Contract.Requires(reads != null);
            Contract.Requires(cce.NonNullElements(ens));
            Contract.Requires(decreases != null);
            Contract.Requires(byMethodBody == null || (!isGhost && body != null)); // function-by-method has a ghost expr and non-ghost stmt, but to callers appears like a functiion-method
            this.IsFueled = MutateCSharp.Schemata103.ReplaceBooleanConstant_8(205L, false);  // Defaults to false.  Only set to true if someone mentions this function in a fuel annotation
            this.Result = result;
            this.ResultType = MutateCSharp.Schemata103.ReplaceBinExprOp_16(206L, result, null) ? result.Type : resultType;
            this.Reads = reads;
            this.Body = body;
            this.ByMethodTok = byMethodTok;
            this.ByMethodBody = byMethodBody;
            this.SignatureEllipsis = signatureEllipsis;
            this.IsOpaque = MutateCSharp.Schemata103.ReplaceBinExprOp_1(208L, () => isOpaque, () => Attributes.Contains(attributes, MutateCSharp.Schemata103.ReplaceStringConstant_0(207L, "opaque")));

            if (MutateCSharp.Schemata103.ReplaceBinExprOp_20(214L, attributes, null))
            {
                List<Expression> args = Attributes.FindExpressions(attributes, MutateCSharp.Schemata103.ReplaceStringConstant_0(215L, "fuel"));
                if (MutateCSharp.Schemata103.ReplaceBinExprOp_21(216L, args, null))
                {
                    if (MutateCSharp.Schemata103.ReplaceBinExprOp_22(221L, args.Count, MutateCSharp.Schemata103.ReplaceNumericConstant_9(217L, 1)))
                    {
                        LiteralExpr literal = args[MutateCSharp.Schemata103.ReplaceNumericConstant_9(226L, 0)] as LiteralExpr;
                        if (MutateCSharp.Schemata103.ReplaceBinExprOp_4(231L, () => MutateCSharp.Schemata103.ReplaceBinExprOp_23(230L, literal, null), () => literal.Value is BigInteger))
                        {
                            IsFueled = MutateCSharp.Schemata103.ReplaceBooleanConstant_8(237L, true);
                        }
                    }
                    else if (MutateCSharp.Schemata103.ReplaceBinExprOp_22(242L, args.Count, MutateCSharp.Schemata103.ReplaceNumericConstant_9(238L, 2)))
                    {
                        LiteralExpr literalLow = args[MutateCSharp.Schemata103.ReplaceNumericConstant_9(247L, 0)] as LiteralExpr;
                        LiteralExpr literalHigh = args[MutateCSharp.Schemata103.ReplaceNumericConstant_9(251L, 1)] as LiteralExpr;

                        if (MutateCSharp.Schemata103.ReplaceBinExprOp_4(269L, () => MutateCSharp.Schemata103.ReplaceBinExprOp_4(263L, () => MutateCSharp.Schemata103.ReplaceBinExprOp_4(256L, () => MutateCSharp.Schemata103.ReplaceBinExprOp_23(255L, literalLow, null), () => literalLow.Value is BigInteger), () => MutateCSharp.Schemata103.ReplaceBinExprOp_23(262L, literalHigh, null)), () => literalHigh.Value is BigInteger))
                        {
                            IsFueled = MutateCSharp.Schemata103.ReplaceBooleanConstant_8(275L, true);
                        }
                    }
                }
            }
        }

        bool ICodeContext.IsGhost
        {
            get { return IsGhost; }
        }

        List<TypeParameter> ICodeContext.TypeArgs
        {
            get { return TypeArgs; }
        }

        List<Formal> ICodeContext.Ins
        {
            get { return Ins; }
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
                    return EnclosingClass.Name + MutateCSharp.Schemata103.ReplaceStringConstant_0(276L, ".") + Name;
                }

                return default;
            }
        }

        Specification<Expression> ICallable.Decreases
        {
            get { return Decreases; }
        }

        bool _inferredDecr;
        bool ICallable.InferredDecreases
        {
            set { _inferredDecr = value; }
            get { return _inferredDecr; }
        }

        ModuleDefinition IASTVisitorContext.EnclosingModule
        {
            get { return EnclosingClass.EnclosingModuleDefinition; }
        }

        bool ICodeContext.MustReverify
        {
            get { return MutateCSharp.Schemata103.ReplaceBooleanConstant_8(277L, false); }
        }

        [Pure]
        public bool IsFuelAware() { return MutateCSharp.Schemata103.ReplaceBinExprOp_1(291L, () => MutateCSharp.Schemata103.ReplaceBinExprOp_1(278L, () => IsRecursive, () => IsFueled), () => (MutateCSharp.Schemata103.ReplaceBinExprOp_4(285L, () => MutateCSharp.Schemata103.ReplaceBinExprOp_24(284L, OverriddenFunction, null), () => OverriddenFunction.IsFuelAware()))); }
        public virtual bool ReadsHeap
        {
            get { return MutateCSharp.Schemata103.ReplaceBinExprOp_25(301L, Reads.Expressions.Count, MutateCSharp.Schemata103.ReplaceNumericConstant_9(297L, 0)); }
        }

        public static readonly Option<string> FunctionSyntaxOption = new(MutateCSharp.Schemata103.ReplaceStringConstant_0(306L, "--function-syntax"),
          () => MutateCSharp.Schemata103.ReplaceStringConstant_0(307L, "4"),
      MutateCSharp.Schemata103.ReplaceStringConstant_0(308L, @"
The syntax for functions changed from Dafny version 3 to version 4. This switch controls access to the new syntax, and also provides a mode to help with migration.

3 - Compiled functions are written `function method` and `predicate method`. Ghost functions are written `function` and `predicate`.
4 - Compiled functions are written `function` and `predicate`. Ghost functions are written `ghost function` and `ghost predicate`.
migration3to4 - Compiled functions are written `function method` and `predicate method`. Ghost functions are written `ghost function` and `ghost predicate`. To migrate from version 3 to version 4, use this flag on your version 3 program. This will give flag all occurrences of `function` and `predicate` as parsing errors. These are ghost functions, so change those into the new syntax `ghost function` and `ghost predicate`. Then, start using --functionSyntax:4. This will flag all occurrences of `function method` and `predicate method` as parsing errors. So, change those to just `function` and `predicate`. Now, your program uses version 4 syntax and has the exact same meaning as your previous version 3 program.
experimentalDefaultGhost - Like migration3to4, but allow `function` and `predicate` as alternatives to declaring ghost functions and predicates, respectively.
experimentalDefaultCompiled - Like migration3to4, but allow `function` and `predicate` as alternatives to declaring compiled
    functions and predicates, respectively.
experimentalPredicateAlwaysGhost - Compiled functions are written `function`. Ghost functions are written `ghost function`. Predicates are always ghost and are written `predicate`."
      ).TrimStart()
        )
        {
            ArgumentHelpName = MutateCSharp.Schemata103.ReplaceStringConstant_0(309L, "version"),
        };

        static Function()
        {
            var functionSyntaxOptionsMap = new Dictionary<string, FunctionSyntaxOptions> {
      { MutateCSharp.Schemata103.ReplaceStringConstant_0(310L, "3"), FunctionSyntaxOptions.Version3 },
      { MutateCSharp.Schemata103.ReplaceStringConstant_0(311L, "4"), FunctionSyntaxOptions.Version4 },
      { MutateCSharp.Schemata103.ReplaceStringConstant_0(312L, "migration3to4"), FunctionSyntaxOptions.Migration3To4 },
      { MutateCSharp.Schemata103.ReplaceStringConstant_0(313L, "experimentalDefaultGhost"), FunctionSyntaxOptions.ExperimentalTreatUnspecifiedAsGhost },
      { MutateCSharp.Schemata103.ReplaceStringConstant_0(314L, "experimentalDefaultCompiled"), FunctionSyntaxOptions.ExperimentalTreatUnspecifiedAsCompiled },
      { MutateCSharp.Schemata103.ReplaceStringConstant_0(315L, "experimentalPredicateAlwaysGhost"), FunctionSyntaxOptions.ExperimentalPredicateAlwaysGhost },
    };
            FunctionSyntaxOption = FunctionSyntaxOption.FromAmong(functionSyntaxOptionsMap.Keys.ToArray());
            DafnyOptions.RegisterLegacyBinding(FunctionSyntaxOption, (options, value) =>
            {
                options.FunctionSyntax = functionSyntaxOptionsMap[value];
            });
            DooFile.RegisterNoChecksNeeded(FunctionSyntaxOption, MutateCSharp.Schemata103.ReplaceBooleanConstant_8(316L, true));
        }

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            formatter.SetMethodLikeIndent(StartToken, OwnedTokens, indentBefore);
            if (MutateCSharp.Schemata103.ReplaceBinExprOp_10(321L, BodyStartTok.line, MutateCSharp.Schemata103.ReplaceNumericConstant_9(317L, 0)))
            {
                formatter.SetDelimiterIndentedRegions(BodyStartTok, indentBefore);
            }

            formatter.SetFormalsIndentation(Ins);
            if (Result is { } outFormal)
            {
                formatter.SetTypeIndentation(outFormal.SyntacticType);
            }

            foreach (var req in Req)
            {
                formatter.SetAttributedExpressionIndentation(req, MutateCSharp.Schemata103.ReplaceBinExprOp_26(326L, indentBefore, formatter.SpaceTab));
            }

            foreach (var frame in Reads.Expressions)
            {
                formatter.SetFrameExpressionIndentation(frame, MutateCSharp.Schemata103.ReplaceBinExprOp_26(335L, indentBefore, formatter.SpaceTab));
            }

            foreach (var ens in Ens)
            {
                formatter.SetAttributedExpressionIndentation(ens, MutateCSharp.Schemata103.ReplaceBinExprOp_26(344L, indentBefore, formatter.SpaceTab));
            }

            foreach (var dec in Decreases.Expressions)
            {
                formatter.SetDecreasesExpressionIndentation(dec, MutateCSharp.Schemata103.ReplaceBinExprOp_26(353L, indentBefore, formatter.SpaceTab));
            }

            if (ByMethodBody is { } byMethodBody)
            {
                formatter.SetDelimiterIndentedRegions(byMethodBody.StartToken, indentBefore);
                formatter.SetClosingIndentedRegion(byMethodBody.EndToken, indentBefore);
                formatter.SetStatementIndentation(byMethodBody);
            }

            formatter.SetExpressionIndentation(Body);
            return MutateCSharp.Schemata103.ReplaceBooleanConstant_8(362L, true);
        }

        protected override bool Bodyless => MutateCSharp.Schemata103.ReplaceBinExprOp_18(363L, Body, null);
        protected override string TypeName => MutateCSharp.Schemata103.ReplaceStringConstant_0(364L, "function");

        public void ResolveNewOrOldPart(INewOrOldResolver resolver)
        {
            ResolveMethodOrFunction(resolver);
        }

        /// <summary>
        /// Assumes type parameters have already been pushed
        /// </summary>
        public override void Resolve(ModuleResolver resolver)
        {
            Contract.Requires(this != null);
            Contract.Requires(resolver.AllTypeConstraints.Count == 0);
            Contract.Ensures(resolver.AllTypeConstraints.Count == 0);

            ResolveNewOrOldPart(resolver);

            // make note of the warnShadowing attribute
            bool warnShadowingOption = resolver.Options.WarnShadowing;  // save the original warnShadowing value
            bool warnShadowing = MutateCSharp.Schemata103.ReplaceBooleanConstant_8(365L, true);
            if (Attributes.ContainsBool(Attributes, MutateCSharp.Schemata103.ReplaceStringConstant_0(366L, "warnShadowing"), ref warnShadowing))
            {
                resolver.Options.WarnShadowing = warnShadowing;  // set the value according to the attribute
            }

            resolver.scope.PushMarker();
            if (IsStatic)
            {
                resolver.scope.AllowInstance = MutateCSharp.Schemata103.ReplaceBooleanConstant_8(367L, false);
            }

            foreach (Formal p in Ins)
            {
                resolver.scope.Push(p.Name, p);
            }

            resolver.ResolveParameterDefaultValues(Ins, ResolutionContext.FromCodeContext(this));

            foreach (var req in Req)
            {
                resolver.ResolveAttributes(req, new ResolutionContext(this, this is TwoStateFunction));
                Expression r = req.E;
                resolver.ResolveExpression(r, new ResolutionContext(this, this is TwoStateFunction));
                Contract.Assert(r.Type != null);  // follows from postcondition of ResolveExpression
                resolver.ConstrainTypeExprBool(r, MutateCSharp.Schemata103.ReplaceStringConstant_0(368L, "Precondition must be a boolean (got {0})"));
            }
            resolver.ResolveAttributes(Reads, new ResolutionContext(this, this is TwoStateFunction));
            foreach (FrameExpression fr in Reads.Expressions)
            {
                resolver.ResolveFrameExpressionTopLevel(fr, FrameExpressionUse.Reads, this);
            }

            resolver.scope.PushMarker();
            if (MutateCSharp.Schemata103.ReplaceBinExprOp_16(369L, Result, null))
            {
                resolver.scope.Push(Result.Name, Result);  // function return only visible in post-conditions (and in function attributes)
            }
            foreach (AttributedExpression e in Ens)
            {
                Expression r = e.E;
                resolver.ResolveAttributes(e, new ResolutionContext(this, this is TwoStateFunction));
                resolver.ResolveExpression(r, new ResolutionContext(this, this is TwoStateFunction) with { InFunctionPostcondition = MutateCSharp.Schemata103.ReplaceBooleanConstant_8(370L, true) });
                Contract.Assert(r.Type != null);  // follows from postcondition of ResolveExpression
                resolver.ConstrainTypeExprBool(r, MutateCSharp.Schemata103.ReplaceStringConstant_0(371L, "Postcondition must be a boolean (got {0})"));
            }
            resolver.scope.PopMarker(); // function result name

            resolver.ResolveAttributes(Decreases, new ResolutionContext(this, this is TwoStateFunction));
            foreach (Expression r in Decreases.Expressions)
            {
                resolver.ResolveExpression(r, new ResolutionContext(this, this is TwoStateFunction));
                // any type is fine
            }
            resolver.SolveAllTypeConstraints(); // solve type constraints in the specification

            if (MutateCSharp.Schemata103.ReplaceBinExprOp_15(372L, Body, null))
            {

                resolver.DominatingStatementLabels.PushMarker();
                foreach (var req in Req)
                {
                    if (MutateCSharp.Schemata103.ReplaceBinExprOp_27(373L, req.Label, null))
                    {
                        if (MutateCSharp.Schemata103.ReplaceBinExprOp_28(374L, resolver.DominatingStatementLabels.Find(req.Label.Name), null))
                        {
                            resolver.reporter.Error(MessageSource.Resolver, req.Label.Tok, MutateCSharp.Schemata103.ReplaceStringConstant_0(375L, "assert label shadows a dominating label"));
                        }
                        else
                        {
                            var rr = resolver.DominatingStatementLabels.Push(req.Label.Name, req.Label);
                            Contract.Assert(rr == Scope<Label>.PushResult.Success);  // since we just checked for duplicates, we expect the Push to succeed
                        }
                    }
                }
                resolver.ResolveExpression(Body, new ResolutionContext(this, this is TwoStateFunction));
                Contract.Assert(Body.Type != null);  // follows from postcondition of ResolveExpression
                resolver.AddAssignableConstraint(tok, ResultType, Body.Type, MutateCSharp.Schemata103.ReplaceStringConstant_0(376L, "Function body type mismatch (expected {0}, got {1})"));
                resolver.SolveAllTypeConstraints();
                resolver.DominatingStatementLabels.PopMarker();
            }

            resolver.scope.PushMarker();
            if (MutateCSharp.Schemata103.ReplaceBinExprOp_16(377L, Result, null))
            {
                resolver.scope.Push(Result.Name, Result);  // function return only visible in post-conditions (and in function attributes)
            }
            resolver.ResolveAttributes(this, new ResolutionContext(this, this is TwoStateFunction), MutateCSharp.Schemata103.ReplaceBooleanConstant_8(378L, true));
            resolver.scope.PopMarker(); // function result name

            resolver.scope.PopMarker(); // formals

            if (MutateCSharp.Schemata103.ReplaceBinExprOp_2(379L, ByMethodBody, null))
            {
                Contract.Assert(Body != null && !IsGhost); // assured by the parser and other callers of the Function constructor
                var method = ByMethodDecl;
                if (MutateCSharp.Schemata103.ReplaceBinExprOp_29(380L, method, null))
                {
                    method.Resolve(resolver);
                }
                else
                {
                    // method should have been filled in by now,
                    // unless there was a function by method and a method of the same name
                    // but then this error must have been reported.
                    Contract.Assert(resolver.Reporter.HasErrors);
                }
            }

            resolver.Options.WarnShadowing = warnShadowingOption; // restore the original warnShadowing value
        }

        public string GetTriviaContainingDocstring()
        {

            var endTokenDefinition =
              OwnedTokens.LastOrDefault(token => MutateCSharp.Schemata103.ReplaceBinExprOp_1(388L, () => MutateCSharp.Schemata103.ReplaceBinExprOp_30(382L, token.val, MutateCSharp.Schemata103.ReplaceStringConstant_0(381L, ")")), () => MutateCSharp.Schemata103.ReplaceBinExprOp_22(383L, token.pos, ResultType.EndToken.pos)))
              ?? EndToken;
            if (MutateCSharp.Schemata103.ReplaceBinExprOp_7(394L, endTokenDefinition.TrailingTrivia.Trim(), ""))
            {
                return endTokenDefinition.TrailingTrivia;
            }

            if (MutateCSharp.Schemata103.ReplaceBinExprOp_7(395L, StartToken.LeadingTrivia.Trim(), ""))
            {
                return StartToken.LeadingTrivia;
            }
            return null;
        }

        public SymbolKind Kind => SymbolKind.Function;
        public bool ShouldVerify => MutateCSharp.Schemata103.ReplaceBooleanConstant_8(396L, true); // This could be made more accurate
        public ModuleDefinition ContainingModule => EnclosingClass.EnclosingModuleDefinition;
        public string GetDescription(DafnyOptions options)
        {
            var formals = string.Join(MutateCSharp.Schemata103.ReplaceStringConstant_0(397L, ", "), Ins.Select(f => f.AsText()));
            var resultType = ResultType.TypeName(options, null, MutateCSharp.Schemata103.ReplaceBooleanConstant_8(398L, false));
            return $"{WhatKind} {AstExtensions.GetMemberQualification(this)}{Name}({formals}): {resultType}";
        }

        public void AutoRevealDependencies(AutoRevealFunctionDependencies Rewriter, DafnyOptions Options,
          ErrorReporter Reporter)
        {
            if (Body is null)
            {
                return;
            }

            if (ByMethodDecl is not null)
            {
                ByMethodDecl.AutoRevealDependencies(Rewriter, Options, Reporter);
            }

            object autoRevealDepsVal = null;
            bool autoRevealDeps = Attributes.ContainsMatchingValue(Attributes, MutateCSharp.Schemata103.ReplaceStringConstant_0(399L, "autoRevealDependencies"),
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
                    autoRevealDepth = MutateCSharp.Schemata103.ReplaceNumericConstant_9(400L, 0);
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

            if (MutateCSharp.Schemata103.ReplaceBinExprOp_10(408L, autoRevealDepth, MutateCSharp.Schemata103.ReplaceNumericConstant_9(404L, 0)))
            {
                Expression reqExpr = Expression.CreateBoolLiteral(Tok, MutateCSharp.Schemata103.ReplaceBooleanConstant_8(413L, true));

                var bodyExpr = Body;

                foreach (var revealStmt in addedReveals)
                {
                    if (MutateCSharp.Schemata103.ReplaceBinExprOp_31(414L, revealStmt.Depth, autoRevealDepth))
                    {
                        bodyExpr = new StmtExpr(Tok, revealStmt.RevealStmt, bodyExpr)
                        {
                            Type = bodyExpr.Type
                        };

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

                Body = bodyExpr;

                if (MutateCSharp.Schemata103.ReplaceBinExprOp_1(419L, () => Req.Any(), () => Ens.Any()))
                {
                    Req.Insert(MutateCSharp.Schemata103.ReplaceNumericConstant_9(425L, 0), new AttributedExpression(reqExpr));
                }
            }

            if (addedReveals.Any())
            {
                Reporter.Message(MessageSource.Rewriter, ErrorLevel.Info, null, tok,
                  AutoRevealFunctionDependencies.GenerateMessage(addedReveals, autoRevealDepth));
            }
        }
        public string Designator => WhatKind;
    }
}
