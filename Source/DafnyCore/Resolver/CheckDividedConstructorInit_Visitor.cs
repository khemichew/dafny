using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Microsoft.Boogie;
namespace MutateCSharp
{
    internal class Schemata388
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT388");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static string ReplaceStringConstant_5(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static int ReplaceNumericConstant_3(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBooleanConstant_4(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.MemberSelectExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.ThisExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public
class CheckDividedConstructorInit_Visitor : ResolverTopDownVisitor<int>
    {
        public CheckDividedConstructorInit_Visitor(ErrorReporter reporter)
          : base(reporter)
        {
            Contract.Requires(reporter != null);
        }
        public void CheckInit(List<Statement> initStmts)
        {
            Contract.Requires(initStmts != null);
            initStmts.ForEach(CheckInit);
        }
        /// <summary>
        /// This method almost does what Visit(Statement) does, except that it handles assignments to
        /// fields differently.
        /// </summary>
        void CheckInit(Statement stmt)
        {
            Contract.Requires(stmt != null);
            // Visit(stmt) would do:
            //     stmt.SubExpressions.Iter(Visit);    (*)
            //     stmt.SubStatements.Iter(Visit);     (**)
            //     VisitOneStmt(stmt);                 (***)
            // We may do less for (*), we always use CheckInit instead of Visit in (**), and we do (***) the same.
            if (stmt is AssignStmt)
            {
                var s = stmt as AssignStmt;
                // The usual visitation of s.SubExpressions.Iter(Visit) would do the following:
                //   Attributes.SubExpressions(s.Attributes).Iter(Visit);  (+)
                //   Visit(s.Lhs);                                         (++)
                //   s.Rhs.SubExpressions.Iter(Visit);                     (+++)
                // Here, we may do less; in particular, we may omit (++).
                Attributes.SubExpressions(s.Attributes).ForEach(VisitExpr);  // (+)
                var mse = s.Lhs as MemberSelectExpr;
                if (MutateCSharp.Schemata388.ReplaceBinExprOp_2(3L, () => MutateCSharp.Schemata388.ReplaceBinExprOp_0(1L, mse, null), () => MutateCSharp.Schemata388.ReplaceBinExprOp_1(2L, Expression.AsThis(mse.Obj), null)))
                {
                    if (s.Rhs is ExprRhs)
                    {
                        // This is a special case we allow.  Omit s.Lhs in the recursive visits.  That is, we omit (++).
                        // Furthermore, because the assignment goes to a field of "this" and won't be available until after
                        // the "new;", we can allow certain specific (and useful) uses of "this" in the RHS.
                        s.Rhs.SubExpressions.ForEach(LiberalRHSVisit);  // (+++)
                    }
                    else
                    {
                        s.Rhs.SubExpressions.ForEach(VisitExpr);  // (+++)
                    }
                }
                else
                {
                    VisitExpr(s.Lhs);  // (++)
                    s.Rhs.SubExpressions.ForEach(VisitExpr);  // (+++)
                }
            }
            else
            {
                stmt.SubExpressions.ForEach(VisitExpr);  // (*)
            }
            stmt.SubStatements.ForEach(CheckInit);  // (**)
            int dummy = MutateCSharp.Schemata388.ReplaceNumericConstant_3(9L, 0);
            VisitOneStmt(stmt, ref dummy);  // (***)
        }
        void VisitExpr(Expression expr)
        {
            Contract.Requires(expr != null);
            Visit(expr, MutateCSharp.Schemata388.ReplaceNumericConstant_3(13L, 0));
        }
        protected override bool VisitOneExpr(Expression expr, ref int unused)
        {
            if (expr is MemberSelectExpr)
            {
                var e = (MemberSelectExpr)expr;
                if (MutateCSharp.Schemata388.ReplaceBinExprOp_2(18L, () => e.Member.IsInstanceIndependentConstant, () => MutateCSharp.Schemata388.ReplaceBinExprOp_1(17L, Expression.AsThis(e.Obj), null)))
                {
                    return MutateCSharp.Schemata388.ReplaceBooleanConstant_4(24L, false);  // don't continue the recursion
                }
            }
            else if (MutateCSharp.Schemata388.ReplaceBinExprOp_2(25L, () => expr is ThisExpr, () => !(expr is ImplicitThisExpr_ConstructorCall)))
            {
                reporter.Error(MessageSource.Resolver, expr.tok, MutateCSharp.Schemata388.ReplaceStringConstant_5(31L, "in the first division of the constructor body (before 'new;'), 'this' can only be used to assign to its fields"));
            }
            return base.VisitOneExpr(expr, ref unused);
        }
        void LiberalRHSVisit(Expression expr)
        {
            Contract.Requires(expr != null);
            // It is important not to allow "this" to flow into something that can be used (for compilation or
            // verification purposes) before the "new;", because, to the verifier, "this" has not yet been allocated.
            // The verifier is told that everything reachable from the heap is expected to be allocated and satisfy all
            // the usual properties, so "this" had better not become reachable from the heap until after the "new;"
            // that does the actual allocation of "this".
            // Within these restrictions, we can allow the (not yet fully available) value "this" to flow into values
            // stored in fields of "this".  Such values are naked occurrences of "this" and "this" occurring
            // as part of constructing a value type.  Since by this rule, "this" may be part of the value stored in
            // a field of "this", we must apply the same rules to uses of the values of fields of "this".
            if (expr is ConcreteSyntaxExpression)
            {
            }
            else if (expr is ThisExpr)
            {
            }
            else if (MutateCSharp.Schemata388.ReplaceBinExprOp_2(32L, () => expr is MemberSelectExpr, () => IsThisDotField((MemberSelectExpr)expr)))
            {
            }
            else if (expr is SetDisplayExpr)
            {
            }
            else if (expr is MultiSetDisplayExpr)
            {
            }
            else if (expr is SeqDisplayExpr)
            {
            }
            else if (expr is MapDisplayExpr)
            {
            }
            else if (MutateCSharp.Schemata388.ReplaceBinExprOp_2(38L, () => expr is BinaryExpr, () => IsCollectionOperator(((BinaryExpr)expr).ResolvedOp)))
            {
            }
            else if (expr is DatatypeValue)
            {
            }
            else if (expr is ITEExpr)
            {
                var e = (ITEExpr)expr;
                VisitExpr(e.Test);
                LiberalRHSVisit(e.Thn);
                LiberalRHSVisit(e.Els);
                return;
            }
            else
            {
                // defer to the usual Visit
                VisitExpr(expr);
                return;
            }
            expr.SubExpressions.ForEach(LiberalRHSVisit);
        }
        static bool IsThisDotField(MemberSelectExpr expr)
        {
            Contract.Requires(expr != null);
            return MutateCSharp.Schemata388.ReplaceBinExprOp_2(45L, () => MutateCSharp.Schemata388.ReplaceBinExprOp_1(44L, Expression.AsThis(expr.Obj), null), () => expr.Member is Field);
        }
        static bool IsCollectionOperator(BinaryExpr.ResolvedOpcode op)
        {
            switch (op)
            {
                // sets:  +, *, -
                case BinaryExpr.ResolvedOpcode.Union:
                case BinaryExpr.ResolvedOpcode.Intersection:
                case BinaryExpr.ResolvedOpcode.SetDifference:
                // multisets: +, *, -
                case BinaryExpr.ResolvedOpcode.MultiSetUnion:
                case BinaryExpr.ResolvedOpcode.MultiSetIntersection:
                case BinaryExpr.ResolvedOpcode.MultiSetDifference:
                // sequences: +
                case BinaryExpr.ResolvedOpcode.Concat:
                // maps: +, -
                case BinaryExpr.ResolvedOpcode.MapMerge:
                case BinaryExpr.ResolvedOpcode.MapSubtraction:
                    return true;
                    break;
                default:
                    return false;
                    break;
            }

            return default;
        }
    }
}