using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata393
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT393");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.CallingPosition argument1, Microsoft.Dafny.CallingPosition argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() != argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() == argument2(); }
            return argument1() != argument2();
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument1, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument2)
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

        internal static bool ReplaceBinExprOp_3(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

    }
}

namespace Microsoft.Dafny
{
    public
class CollectFriendlyCallsInSpec_Visitor : FindFriendlyCalls_Visitor
    {
        readonly ISet<Expression> friendlyCalls;
        readonly ExtremeLemma Context;
        public CollectFriendlyCallsInSpec_Visitor(ErrorReporter reporter, ISet<Expression> friendlyCalls, bool co, ExtremeLemma context)
          : base(reporter, co, context.KNat)
        {
            Contract.Requires(reporter != null);
            Contract.Requires(friendlyCalls != null);
            Contract.Requires(context != null);
            this.friendlyCalls = friendlyCalls;
            this.Context = context;
        }
        protected override bool VisitOneExpr(Expression expr, ref CallingPosition cp)
        {
            if (MutateCSharp.Schemata393.ReplaceBinExprOp_0(1L, cp, CallingPosition.Neither))
            {
                // no friendly calls in "expr"
                return MutateCSharp.Schemata393.ReplaceBooleanConstant_1(2L, false);  // don't recurse into subexpressions
            }
            if (expr is FunctionCallExpr)
            {
                if (MutateCSharp.Schemata393.ReplaceBinExprOp_0(3L, cp, CallingPosition.Positive))
                {
                    var fexp = (FunctionCallExpr)expr;
                    if (IsCoContext ? fexp.Function is GreatestPredicate : fexp.Function is LeastPredicate)
                    {
                        if (MutateCSharp.Schemata393.ReplaceBinExprOp_2(4L, () => Context.KNat, () => ((ExtremePredicate)fexp.Function).KNat))
                        {
                            KNatMismatchError(expr.tok, Context.Name, Context.TypeOfK, ((ExtremePredicate)fexp.Function).TypeOfK);
                        }
                        else
                        {
                            friendlyCalls.Add(fexp);
                        }
                    }
                }
                return MutateCSharp.Schemata393.ReplaceBooleanConstant_1(10L, false);  // don't explore subexpressions any further
            }
            else if (MutateCSharp.Schemata393.ReplaceBinExprOp_3(11L, () => expr is BinaryExpr, () => IsCoContext))
            {
                var bin = (BinaryExpr)expr;
                if (MutateCSharp.Schemata393.ReplaceBinExprOp_0(17L, cp, CallingPosition.Positive) && MutateCSharp.Schemata393.ReplaceBinExprOp_4(18L, bin.ResolvedOp, BinaryExpr.ResolvedOpcode.EqCommon) && bin.E0.Type.IsCoDatatype)
                {
                    friendlyCalls.Add(bin);
                    return MutateCSharp.Schemata393.ReplaceBooleanConstant_1(19L, false);  // don't explore subexpressions any further
                }
                else if (MutateCSharp.Schemata393.ReplaceBinExprOp_0(20L, cp, CallingPosition.Negative) && MutateCSharp.Schemata393.ReplaceBinExprOp_4(21L, bin.ResolvedOp, BinaryExpr.ResolvedOpcode.NeqCommon) && bin.E0.Type.IsCoDatatype)
                {
                    friendlyCalls.Add(bin);
                    return MutateCSharp.Schemata393.ReplaceBooleanConstant_1(22L, false);  // don't explore subexpressions any further
                }
            }
            return base.VisitOneExpr(expr, ref cp);
        }
    }
}