using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata397
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT397");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_1(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.CallingPosition argument1, Microsoft.Dafny.CallingPosition argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.CallingPosition argument1, Microsoft.Dafny.CallingPosition argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_4(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public
class ExtremePredicateChecks_Visitor : FindFriendlyCalls_Visitor
    {
        readonly ExtremePredicate context;
        public ExtremePredicateChecks_Visitor(ErrorReporter reporter, ExtremePredicate context)
          : base(reporter, context is GreatestPredicate, context.KNat)
        {
            Contract.Requires(reporter != null);
            Contract.Requires(context != null);
            this.context = context;
        }
        protected override bool VisitOneExpr(Expression expr, ref CallingPosition cp)
        {
            if (expr is FunctionCallExpr)
            {
                var e = (FunctionCallExpr)expr;
                if (ModuleDefinition.InSameSCC(context, e.Function))
                {
                    // we're looking at a recursive call
                    if (!(context is LeastPredicate ? e.Function is LeastPredicate : e.Function is GreatestPredicate))
                    {
                        reporter.Error(MessageSource.Resolver, e, MutateCSharp.Schemata397.ReplaceStringConstant_0(1L, "a recursive call from a {0} can go only to other {0}s"), context.WhatKind);
                    }
                    else if (MutateCSharp.Schemata397.ReplaceBinExprOp_1(2L, () => context.KNat, () => ((ExtremePredicate)e.Function).KNat))
                    {
                        KNatMismatchError(e.tok, context.Name, context.TypeOfK, ((ExtremePredicate)e.Function).TypeOfK);
                    }
                    else if (MutateCSharp.Schemata397.ReplaceBinExprOp_2(8L, cp, CallingPosition.Positive))
                    {
                        var msg = $"a {context.WhatKind} can be called recursively only in positive positions";
                        if (ContinuityIsImportant && MutateCSharp.Schemata397.ReplaceBinExprOp_3(9L, cp, CallingPosition.Neither))
                        {
                            // this may be inside an non-friendly quantifier
                            msg +=
                              $" and cannot sit inside an unbounded {(context is LeastPredicate ? MutateCSharp.Schemata397.ReplaceStringConstant_0(10L, "universal") : MutateCSharp.Schemata397.ReplaceStringConstant_0(11L, "existential"))} quantifier";
                        }
                        else
                        {
                            // we don't care about the continuity restriction or
                            // the extreme-call is not inside an quantifier, so don't bother mentioning the part of existentials/universals in the error message
                        }
                        reporter.Error(MessageSource.Resolver, e, msg);
                    }
                    else
                    {
                        e.CoCall = FunctionCallExpr.CoCallResolution.Yes;
                        reporter.Info(MessageSource.Resolver, e.tok, e.Function.Name + MutateCSharp.Schemata397.ReplaceStringConstant_0(12L, "#[_k - 1]"));
                    }
                }
                // do the sub-parts with cp := Neither
                cp = CallingPosition.Neither;
                return MutateCSharp.Schemata397.ReplaceBooleanConstant_4(13L, true);
            }
            return base.VisitOneExpr(expr, ref cp);
        }
        protected override bool VisitOneStmt(Statement stmt, ref CallingPosition st)
        {
            if (stmt is CallStmt)
            {
                var s = (CallStmt)stmt;
                if (ModuleDefinition.InSameSCC(context, s.Method))
                {
                    // we're looking at a recursive call
                    reporter.Error(MessageSource.Resolver, stmt.Tok, MutateCSharp.Schemata397.ReplaceStringConstant_0(14L, "a recursive call from a {0} can go only to other {0}s"), context.WhatKind);
                }
                // do the sub-parts with the same "cp"
                return MutateCSharp.Schemata397.ReplaceBooleanConstant_4(15L, true);
            }
            else
            {
                return base.VisitOneStmt(stmt, ref st);
            }

            return default;
        }
    }
}