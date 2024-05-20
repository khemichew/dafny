using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata472
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT472");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.Attributes argument1, Microsoft.Dafny.Attributes argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.BoundedPool> argument1, System.Collections.Generic.List<Microsoft.Dafny.BoundedPool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_7(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.BoundedPool> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, System.Tuple<Microsoft.Dafny.Expression, Microsoft.Dafny.IdentifierExpr> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.Expression argument1, Microsoft.Dafny.Expression argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class ExprSubstituter : Substituter
    {
        readonly List<Tuple<Expression, IdentifierExpr>> exprSubstMap;
        List<Tuple<Expression, IdentifierExpr>> usedSubstMap;

        public ExprSubstituter(List<Tuple<Expression, IdentifierExpr>> exprSubstMap)
          : base(null, new Dictionary<IVariable, Expression>(), new Dictionary<TypeParameter, Type>())
        {
            this.exprSubstMap = exprSubstMap;
            this.usedSubstMap = new List<Tuple<Expression, IdentifierExpr>>();
        }

        public bool TryGetExprSubst(Expression expr, out IdentifierExpr ie)
        {
            var entry = usedSubstMap.Find(x => Triggers.ExprExtensions.ExpressionEq(expr, x.Item1));
            if (MutateCSharp.Schemata472.ReplaceBinExprOp_0(1L, entry, null))
            {
                ie = entry.Item2;
                return MutateCSharp.Schemata472.ReplaceBooleanConstant_1(2L, true);
            }
            entry = exprSubstMap.Find(x => Triggers.ExprExtensions.ExpressionEq(expr, x.Item1));
            if (MutateCSharp.Schemata472.ReplaceBinExprOp_0(3L, entry, null))
            {
                usedSubstMap.Add(entry);
                ie = entry.Item2;
                return MutateCSharp.Schemata472.ReplaceBooleanConstant_1(4L, true);
            }
            else
            {
                ie = null;
                return MutateCSharp.Schemata472.ReplaceBooleanConstant_1(5L, false);
            }

            return default;
        }

        public override Expression Substitute(Expression expr)
        {
            if (TryGetExprSubst(expr, out var ie))
            {
                Contract.Assert(ie != null);
                return ie;
            }
            if (expr is QuantifierExpr e)
            {
                var newAttrs = SubstAttributes(e.Attributes);
                var newRange = MutateCSharp.Schemata472.ReplaceBinExprOp_2(6L, e.Range, null) ? null : Substitute(e.Range);
                var newTerm = Substitute(e.Term);
                var newBounds = SubstituteBoundedPoolList(e.Bounds);
                if (MutateCSharp.Schemata472.ReplaceBinExprOp_5(23L, () => MutateCSharp.Schemata472.ReplaceBinExprOp_5(16L, () => MutateCSharp.Schemata472.ReplaceBinExprOp_5(9L, () => MutateCSharp.Schemata472.ReplaceBinExprOp_3(7L, newAttrs, e.Attributes), () => MutateCSharp.Schemata472.ReplaceBinExprOp_4(8L, newRange, e.Range)), () => MutateCSharp.Schemata472.ReplaceBinExprOp_4(15L, newTerm, e.Term)), () => MutateCSharp.Schemata472.ReplaceBinExprOp_6(22L, newBounds, e.Bounds)))
                {
                    return e;
                }

                var newBoundVars = new List<BoundVar>(e.BoundVars);
                if (MutateCSharp.Schemata472.ReplaceBinExprOp_7(29L, newBounds, null))
                {
                    newBounds = new List<BoundedPool>();
                }
                else if (MutateCSharp.Schemata472.ReplaceBinExprOp_6(30L, newBounds, e.Bounds))
                {
                    // create a new list with the same elements, since the .Add operations below would otherwise add elements to the original e.Bounds
                    newBounds = new List<BoundedPool>(newBounds);
                }

                // conjoin all the new equalities to the range of the quantifier
                foreach (var entry in usedSubstMap)
                {
                    var eq = new BinaryExpr(e.tok, BinaryExpr.ResolvedOpcode.EqCommon, entry.Item2, entry.Item1);
                    newRange = MutateCSharp.Schemata472.ReplaceBinExprOp_2(31L, newRange, null) ? eq : new BinaryExpr(e.tok, BinaryExpr.ResolvedOpcode.And, eq, newRange);
                    newBoundVars.Add((BoundVar)entry.Item2.Var);
                    newBounds.Add(new ExactBoundedPool(entry.Item1));
                }

                QuantifierExpr newExpr;
                if (expr is ForallExpr)
                {
                    newExpr = new ForallExpr(e.tok, e.RangeToken, newBoundVars, newRange, newTerm, newAttrs) { Bounds = newBounds };
                }
                else
                {
                    Contract.Assert(expr is ExistsExpr);
                    newExpr = new ExistsExpr(e.tok, e.RangeToken, newBoundVars, newRange, newTerm, newAttrs) { Bounds = newBounds };
                }
                usedSubstMap.Clear();

                newExpr.Type = expr.Type;
                return newExpr;
            }
            return base.Substitute(expr);
        }
    }
}