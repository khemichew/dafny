using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata35
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT35");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.IdentifierExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_5(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static int ReplaceNumericConstant_2(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public class SetComprehension : ComprehensionExpr, ICloneable<SetComprehension>
    {
        public override string WhatKind => MutateCSharp.Schemata35.ReplaceStringConstant_0(1L, "set comprehension");

        public readonly bool Finite;
        public readonly bool TermIsImplicit;  // records the given syntactic form
        public bool TermIsSimple
        {
            get
            {
                var term = Term as IdentifierExpr;
                var r = MutateCSharp.Schemata35.ReplaceBinExprOp_4(23L, () => MutateCSharp.Schemata35.ReplaceBinExprOp_4(12L, () => MutateCSharp.Schemata35.ReplaceBinExprOp_1(2L, term, null), () => MutateCSharp.Schemata35.ReplaceBinExprOp_3(7L, BoundVars.Count, MutateCSharp.Schemata35.ReplaceNumericConstant_2(3L, 1))), () => MutateCSharp.Schemata35.ReplaceBinExprOp_5(22L, BoundVars[MutateCSharp.Schemata35.ReplaceNumericConstant_2(18L, 0)].Name, term.Name));
                Contract.Assert(!TermIsImplicit || r);  // TermIsImplicit ==> r
                Contract.Assert(!r || term.Var == null || term.Var == BoundVars[0]);  // if the term is simple and it has been resolved, then it should have resolved to BoundVars[0]
                return r;
            }
        }

        public SetComprehension Clone(Cloner cloner)
        {
            return new SetComprehension(cloner, this);
        }

        public SetComprehension(Cloner cloner, SetComprehension original) : base(cloner, original)
        {
            TermIsImplicit = original.TermIsImplicit;
            Finite = original.Finite;
        }

        public SetComprehension(IToken tok, RangeToken rangeToken, bool finite, List<BoundVar> bvars, Expression range, Expression/*?*/ term, Attributes attrs)
          : base(tok, rangeToken, bvars, range, term ?? new IdentifierExpr(tok, bvars[MutateCSharp.Schemata35.ReplaceNumericConstant_2(29L, 0)].Name), attrs)
        {
            Contract.Requires(tok != null);
            Contract.Requires(cce.NonNullElements(bvars));
            Contract.Requires(1 <= bvars.Count);
            Contract.Requires(range != null);
            Contract.Requires(term != null || bvars.Count == 1);

            TermIsImplicit = MutateCSharp.Schemata35.ReplaceBinExprOp_6(33L, term, null);
            Finite = finite;
        }
    }
}