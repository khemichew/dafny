using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata399
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT399");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.BoundedPool argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_3(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.UnaryOpExpr.Opcode argument1, Microsoft.Dafny.UnaryOpExpr.Opcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.ExtremePredicate.KType argument1, Microsoft.Dafny.ExtremePredicate.KType argument2)
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

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.CallingPosition argument1, Microsoft.Dafny.CallingPosition argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public enum CallingPosition { Positive, Negative, Neither }

    public
    class FindFriendlyCalls_Visitor : ResolverTopDownVisitor<CallingPosition>
    {
        public readonly bool IsCoContext;
        public readonly bool ContinuityIsImportant;
        public FindFriendlyCalls_Visitor(ErrorReporter reporter, bool co, bool continuityIsImportant)
          : base(reporter)
        {
            Contract.Requires(reporter != null);
            this.IsCoContext = co;
            this.ContinuityIsImportant = continuityIsImportant;
        }

        public void KNatMismatchError(IToken tok, string contextName, ExtremePredicate.KType contextK, ExtremePredicate.KType calleeK)
        {
            var hint = MutateCSharp.Schemata399.ReplaceBinExprOp_0(1L, contextK, ExtremePredicate.KType.Unspecified) ? string.Format(MutateCSharp.Schemata399.ReplaceStringConstant_1(2L, " (perhaps try declaring '{0}' as '{0}[nat]')"), contextName) : "";
            reporter.Error(MessageSource.Resolver, tok,
        MutateCSharp.Schemata399.ReplaceStringConstant_1(3L, "this call does not type check, because the context uses a _k parameter of type {0} whereas the callee uses a _k parameter of type {1}{2}"),
        MutateCSharp.Schemata399.ReplaceBinExprOp_0(4L, contextK, ExtremePredicate.KType.Nat) ? MutateCSharp.Schemata399.ReplaceStringConstant_1(5L, "nat") : MutateCSharp.Schemata399.ReplaceStringConstant_1(6L, "ORDINAL"),
        MutateCSharp.Schemata399.ReplaceBinExprOp_0(7L, calleeK, ExtremePredicate.KType.Nat) ? MutateCSharp.Schemata399.ReplaceStringConstant_1(8L, "nat") : MutateCSharp.Schemata399.ReplaceStringConstant_1(9L, "ORDINAL"),
              hint);
        }

        static CallingPosition Invert(CallingPosition cp)
        {
            switch (cp)
            {
                case CallingPosition.Positive:
                    return CallingPosition.Negative;
                    break;
                case CallingPosition.Negative:
                    return CallingPosition.Positive;
                    break;
                default:
                    return CallingPosition.Neither;
                    break;
            }

            return default;
        }

        protected override bool VisitOneExpr(Expression expr, ref CallingPosition cp)
        {
            if (expr is UnaryOpExpr)
            {
                var e = (UnaryOpExpr)expr;
                if (MutateCSharp.Schemata399.ReplaceBinExprOp_2(10L, e.Op, UnaryOpExpr.Opcode.Not))
                {
                    // for the sub-parts, use Invert(cp)
                    cp = Invert(cp);
                    return MutateCSharp.Schemata399.ReplaceBooleanConstant_3(11L, true);
                }
            }
            else if (expr is BinaryExpr)
            {
                var e = (BinaryExpr)expr;
                switch (e.ResolvedOp)
                {
                    case BinaryExpr.ResolvedOpcode.And:
                    case BinaryExpr.ResolvedOpcode.Or:
                        return true;  // do the sub-parts with the same "cp"
                        break;
                    case BinaryExpr.ResolvedOpcode.Imp:
                        Visit(e.E0, Invert(cp));
                        Visit(e.E1, cp);
                        return false;  // don't recurse (again) on the sub-parts
                        break;
                    default:
                        break;
                        break;
                }
            }
            else if (expr is NestedMatchExpr)
            {
                var e = (NestedMatchExpr)expr;
                Visit(e.Source, CallingPosition.Neither);
                var theCp = cp;
                e.Cases.ForEach(kase => Visit((Expression)kase.Body, theCp));
                return MutateCSharp.Schemata399.ReplaceBooleanConstant_3(12L, false);
            }
            else if (expr is MatchExpr)
            {
                var e = (MatchExpr)expr;
                Visit(e.Source, CallingPosition.Neither);
                var theCp = cp;
                e.Cases.ForEach(kase => Visit(kase.Body, theCp));
                return MutateCSharp.Schemata399.ReplaceBooleanConstant_3(13L, false);
            }
            else if (expr is ITEExpr)
            {
                var e = (ITEExpr)expr;
                Visit(e.Test, CallingPosition.Neither);
                Visit(e.Thn, cp);
                Visit(e.Els, cp);
                return MutateCSharp.Schemata399.ReplaceBooleanConstant_3(14L, false);
            }
            else if (expr is LetExpr)
            {
                var e = (LetExpr)expr;
                foreach (var rhs in e.RHSs)
                {
                    Visit(rhs, CallingPosition.Neither);
                }
                var cpBody = cp;
                if (!e.Exact)
                {
                    // a let-such-that expression introduces an existential that may depend on the _k in a least/greatest predicate, so we disallow recursive calls in the body of the let-such-that
                    if (IsCoContext && MutateCSharp.Schemata399.ReplaceBinExprOp_4(15L, cp, CallingPosition.Positive))
                    {
                        cpBody = CallingPosition.Neither;
                    }
                    else if (!IsCoContext && MutateCSharp.Schemata399.ReplaceBinExprOp_4(16L, cp, CallingPosition.Negative))
                    {
                        cpBody = CallingPosition.Neither;
                    }
                }
                Visit(e.Body, cpBody);
                return MutateCSharp.Schemata399.ReplaceBooleanConstant_3(17L, false);
            }
            else if (expr is QuantifierExpr)
            {
                var e = (QuantifierExpr)expr;
                Contract.Assert(e.SplitQuantifier == null); // No split quantifiers during resolution
                var cpos = IsCoContext ? cp : Invert(cp);
                if (ContinuityIsImportant)
                {
                    if (MutateCSharp.Schemata399.ReplaceBinExprOp_6(32L, () => (MutateCSharp.Schemata399.ReplaceBinExprOp_5(19L, () => MutateCSharp.Schemata399.ReplaceBinExprOp_4(18L, cpos, CallingPosition.Positive), () => e is ExistsExpr)), () => (MutateCSharp.Schemata399.ReplaceBinExprOp_5(26L, () => MutateCSharp.Schemata399.ReplaceBinExprOp_4(25L, cpos, CallingPosition.Negative), () => e is ForallExpr))))
                    {
                        if (e.Bounds.Exists(bnd => MutateCSharp.Schemata399.ReplaceBinExprOp_6(39L, () => MutateCSharp.Schemata399.ReplaceBinExprOp_7(38L, bnd, null), () => (bnd.Virtues & BoundedPool.PoolVirtues.Finite) == 0)))
                        {
                            // To ensure continuity of extreme predicates, don't allow calls under an existential (resp. universal) quantifier
                            // for greatest (resp. least) predicates).
                            cp = CallingPosition.Neither;
                        }
                    }
                }
                Visit(e.LogicalBody(), cp);
                return MutateCSharp.Schemata399.ReplaceBooleanConstant_3(45L, false);
            }
            else if (expr is StmtExpr)
            {
                var e = (StmtExpr)expr;
                Visit(e.E, cp);
                Visit(e.S, CallingPosition.Neither);
                return MutateCSharp.Schemata399.ReplaceBooleanConstant_3(46L, false);
            }
            else if (expr is ConcreteSyntaxExpression)
            {
                // do the sub-parts with the same "cp"
                return MutateCSharp.Schemata399.ReplaceBooleanConstant_3(47L, true);
            }
            // do the sub-parts with cp := Neither
            cp = CallingPosition.Neither;
            return MutateCSharp.Schemata399.ReplaceBooleanConstant_3(48L, true);
        }
    }
}