using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using Microsoft.Boogie;
namespace MutateCSharp
{
    internal class Schemata438
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT438");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
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

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, Microsoft.Dafny.Function.TailStatus argument1, Microsoft.Dafny.Function.TailStatus argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.Method argument1, Microsoft.Dafny.Method argument2)
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

        internal static int ReplacePostfixUnaryExprOp_16(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, Microsoft.Dafny.TypeParameter argument1, Microsoft.Dafny.TypeParameter argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.UpdateStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, Microsoft.Dafny.Function.TailStatus argument1, Microsoft.Dafny.Function.TailStatus argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
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

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.UpdateStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.ConcreteUpdateStatement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, Microsoft.Dafny.Function argument1, Microsoft.Dafny.Function argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, Microsoft.Dafny.MemberDecl argument1, Microsoft.Dafny.Function argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, Microsoft.Dafny.IVariable argument1, Microsoft.Dafny.Formal argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public
class TailRecursion
    {

        private readonly ErrorReporter reporter;

        public TailRecursion(ErrorReporter reporter)
        {
            this.reporter = reporter;
        }

        // ------------------------------------------------------------------------------------------------------
        // ----- CheckTailRecursive -----------------------------------------------------------------------------
        // ------------------------------------------------------------------------------------------------------
        #region CheckTailRecursive
        public void DetermineTailRecursion(Method m)
        {
            Contract.Requires(m != null);
            Contract.Requires(m.Body != null);
            bool tail = MutateCSharp.Schemata438.ReplaceBooleanConstant_0(1L, true);
            bool hasTailRecursionPreference = Attributes.ContainsBool(m.Attributes, MutateCSharp.Schemata438.ReplaceStringConstant_1(2L, "tailrecursion"), ref tail);
            if (MutateCSharp.Schemata438.ReplaceBinExprOp_2(3L, () => hasTailRecursionPreference, () => !tail))
            {
                // the user specifically requested no tail recursion, so do nothing else
            }
            else if (MutateCSharp.Schemata438.ReplaceBinExprOp_2(15L, () => MutateCSharp.Schemata438.ReplaceBinExprOp_2(9L, () => hasTailRecursionPreference, () => tail), () => m.IsGhost))
            {
                reporter.Error(MessageSource.Resolver, m.tok, MutateCSharp.Schemata438.ReplaceStringConstant_1(21L, "tail recursion can be specified only for methods that will be compiled, not for ghost methods"));
            }
            else
            {
                var module = m.EnclosingClass.EnclosingModuleDefinition;
                var sccSize = module.CallGraph.GetSCCSize(m);
                if (MutateCSharp.Schemata438.ReplaceBinExprOp_2(31L, () => hasTailRecursionPreference, () => MutateCSharp.Schemata438.ReplaceBinExprOp_4(26L, MutateCSharp.Schemata438.ReplaceNumericConstant_3(22L, 2), sccSize)))
                {
                    reporter.Error(MessageSource.Resolver, m.tok, MutateCSharp.Schemata438.ReplaceStringConstant_1(37L, "sorry, tail-call optimizations are not supported for mutually recursive methods"));
                }
                else if (MutateCSharp.Schemata438.ReplaceBinExprOp_6(47L, () => hasTailRecursionPreference, () => MutateCSharp.Schemata438.ReplaceBinExprOp_5(42L, sccSize, MutateCSharp.Schemata438.ReplaceNumericConstant_3(38L, 1))))
                {
                    Statement tailCall = null;
                    var status = CheckTailRecursive(m.Body.Body, m, ref tailCall, hasTailRecursionPreference);
                    if (MutateCSharp.Schemata438.ReplaceBinExprOp_2(54L, () => status != TailRecursionStatus.NotTailRecursive, () => MutateCSharp.Schemata438.ReplaceBinExprOp_7(53L, tailCall, null)))
                    {
                        // this means there was at least one recursive call
                        m.IsTailRecursive = MutateCSharp.Schemata438.ReplaceBooleanConstant_0(60L, true);
                        reporter.Info(MessageSource.Resolver, m.tok, MutateCSharp.Schemata438.ReplaceStringConstant_1(61L, "tail recursive"));
                    }
                }
            }
        }

        public
          enum TailRecursionStatus
        {
            NotTailRecursive, // contains code that makes the enclosing method body not tail recursive (in way that is supported)
            CanBeFollowedByAnything, // the code just analyzed does not do any recursive calls
            TailCallSpent, // the method body is tail recursive, provided that all code that follows it in the method body is ghost
        }

        /// <summary>
        /// Checks if "stmts" can be considered tail recursive, and (provided "reportError" is true) reports an error if not.
        /// Note, the current implementation is rather conservative in its analysis; upon need, the
        /// algorithm could be improved.
        /// In the current implementation, "enclosingMethod" is not allowed to be a mutually recursive method.
        ///
        /// The incoming value of "tailCall" is not used, but it's nevertheless a 'ref' parameter to allow the
        /// body to return the incoming value or to omit assignments to it.
        /// If the return value is CanBeFollowedByAnything, "tailCall" is unchanged.
        /// If the return value is TailCallSpent, "tailCall" shows one of the calls where the tail call was spent.  (Note,
        /// there could be several if the statements have branches.)
        /// If the return value is NoTailRecursive, "tailCall" could be anything.  In this case, an error
        /// message has been reported (provided "reportsErrors" is true).
        /// </summary>
        TailRecursionStatus CheckTailRecursive(List<Statement> stmts, Method enclosingMethod, ref Statement tailCall, bool reportErrors)
        {
            Contract.Requires(stmts != null);
            var status = TailRecursionStatus.CanBeFollowedByAnything;
            foreach (var s in stmts)
            {
                if (!s.IsGhost)
                {
                    if (MutateCSharp.Schemata438.ReplaceBinExprOp_2(63L, () => s is ReturnStmt, () => MutateCSharp.Schemata438.ReplaceBinExprOp_8(62L, ((ReturnStmt)s).HiddenUpdate, null)))
                    {
                        return status;
                    }
                    if (status == TailRecursionStatus.TailCallSpent)
                    {
                        // a tail call cannot be followed by non-ghost code
                        if (reportErrors)
                        {
                            reporter.Error(MessageSource.Resolver, tailCall.Tok, MutateCSharp.Schemata438.ReplaceStringConstant_1(69L, "this recursive call is not recognized as being tail recursive, because it is followed by non-ghost code"));
                        }
                        return TailRecursionStatus.NotTailRecursive;
                    }
                    status = CheckTailRecursive(s, enclosingMethod, ref tailCall, reportErrors);
                    if (status == TailRecursionStatus.NotTailRecursive)
                    {
                        return status;
                    }
                }
            }
            return status;
        }

        /// <summary>
        /// See CheckTailRecursive(List Statement, ...), including its description of "tailCall".
        /// In the current implementation, "enclosingMethod" is not allowed to be a mutually recursive method.
        /// </summary>
        TailRecursionStatus CheckTailRecursive(Statement stmt, Method enclosingMethod, ref Statement tailCall, bool reportErrors)
        {
            Contract.Requires(stmt != null);
            if (stmt.IsGhost)
            {
                return TailRecursionStatus.CanBeFollowedByAnything;
            }
            if (stmt is PrintStmt)
            {
            }
            else if (stmt is RevealStmt)
            {
            }
            else if (stmt is BreakStmt)
            {
            }
            else if (stmt is ReturnStmt)
            {
                var s = (ReturnStmt)stmt;
                if (MutateCSharp.Schemata438.ReplaceBinExprOp_9(70L, s.HiddenUpdate, null))
                {
                    return CheckTailRecursive(s.HiddenUpdate, enclosingMethod, ref tailCall, reportErrors);
                }
            }
            else if (stmt is AssignStmt)
            {
                var s = (AssignStmt)stmt;
                if (s.Rhs is TypeRhs tRhs && tRhs.InitCall != null && MutateCSharp.Schemata438.ReplaceBinExprOp_10(71L, tRhs.InitCall.Method, enclosingMethod))
                {
                    // It's a recursive call.  However, it is not a tail call, because after the "new" allocation
                    // and init call have taken place, the newly allocated object has yet to be assigned to
                    // the LHS of the assignment statement.
                    if (reportErrors)
                    {
                        reporter.Error(MessageSource.Resolver, tRhs.InitCall.Tok,
              MutateCSharp.Schemata438.ReplaceStringConstant_1(72L, "the recursive call to '{0}' is not tail recursive, because the assignment of the LHS happens after the call"),
                          tRhs.InitCall.Method.Name);
                    }
                    return TailRecursionStatus.NotTailRecursive;
                }
                else if (s.Rhs is ExprRhs eRhs && eRhs.Expr.Resolved is FunctionCallExpr fce && MutateCSharp.Schemata438.ReplaceBinExprOp_10(73L, fce.Function.ByMethodDecl, enclosingMethod))
                {
                    var status = ConfirmTailCall(s.Tok, enclosingMethod, fce.TypeApplication_JustFunction, new List<Expression>() { s.Lhs }, reportErrors);
                    if (status == TailRecursionStatus.TailCallSpent)
                    {
                        tailCall = s;
                        fce.Args.ForEach(ee => DisallowRecursiveCallsInExpressions(ee, enclosingMethod));
                    }
                    else
                    {
                        DisallowRecursiveCallsInExpressions(s.Lhs, enclosingMethod, reportErrors);
                        DisallowRecursiveCallsInExpressions(eRhs.Expr, enclosingMethod, reportErrors);
                    }
                    return status;
                }
            }
            else if (stmt is ModifyStmt)
            {
                var s = (ModifyStmt)stmt;
                if (MutateCSharp.Schemata438.ReplaceBinExprOp_11(74L, s.Body, null))
                {
                    return CheckTailRecursive(s.Body, enclosingMethod, ref tailCall, reportErrors);
                }
            }
            else if (stmt is CallStmt)
            {
                var s = (CallStmt)stmt;
                if (MutateCSharp.Schemata438.ReplaceBinExprOp_10(75L, s.Method, enclosingMethod))
                {
                    DisallowRecursiveCallsInExpressions(s, enclosingMethod, reportErrors);
                    var status = ConfirmTailCall(s.Tok, s.Method, s.MethodSelect.TypeApplication_JustMember, s.Lhs, reportErrors);
                    if (status == TailRecursionStatus.TailCallSpent)
                    {
                        tailCall = s;
                    }
                    return status;
                }
            }
            else if (stmt is BlockStmt)
            {
                var s = (BlockStmt)stmt;
                return CheckTailRecursive(s.Body, enclosingMethod, ref tailCall, reportErrors);
            }
            else if (stmt is IfStmt)
            {
                var s = (IfStmt)stmt;
                DisallowRecursiveCallsInExpressions(s.Guard, enclosingMethod, reportErrors);
                var stThen = CheckTailRecursive(s.Thn, enclosingMethod, ref tailCall, reportErrors);
                if (stThen == TailRecursionStatus.NotTailRecursive)
                {
                    return stThen;
                }
                var stElse = MutateCSharp.Schemata438.ReplaceBinExprOp_12(76L, s.Els, null) ? TailRecursionStatus.CanBeFollowedByAnything : CheckTailRecursive(s.Els, enclosingMethod, ref tailCall, reportErrors);
                if (stElse == TailRecursionStatus.NotTailRecursive)
                {
                    return stElse;
                }
                else if (MutateCSharp.Schemata438.ReplaceBinExprOp_6(77L, () => stThen == TailRecursionStatus.TailCallSpent, () => stElse == TailRecursionStatus.TailCallSpent))
                {
                    return TailRecursionStatus.TailCallSpent;
                }
            }
            else if (stmt is AlternativeStmt)
            {
                var s = (AlternativeStmt)stmt;
                var status = TailRecursionStatus.CanBeFollowedByAnything;
                foreach (var alt in s.Alternatives)
                {
                    DisallowRecursiveCallsInExpressions(alt.Guard, enclosingMethod, reportErrors);
                    var st = CheckTailRecursive(alt.Body, enclosingMethod, ref tailCall, reportErrors);
                    if (st == TailRecursionStatus.NotTailRecursive)
                    {
                        return st;
                    }
                    else if (st == TailRecursionStatus.TailCallSpent)
                    {
                        status = st;
                    }
                }
                return status;
            }
            else if (stmt is OneBodyLoopStmt)
            {
                var s = (OneBodyLoopStmt)stmt;
                if (s is WhileStmt wh)
                {
                    DisallowRecursiveCallsInExpressions(wh.Guard, enclosingMethod, reportErrors);
                }
                else if (s is ForLoopStmt forLoop)
                {
                    DisallowRecursiveCallsInExpressions(forLoop.Start, enclosingMethod, reportErrors);
                    DisallowRecursiveCallsInExpressions(forLoop.End, enclosingMethod, reportErrors);
                }
                var status = TailRecursionStatus.NotTailRecursive;
                if (MutateCSharp.Schemata438.ReplaceBinExprOp_11(83L, s.Body, null))
                {
                    status = CheckTailRecursive(s.Body, enclosingMethod, ref tailCall, reportErrors);
                }
                if (status != TailRecursionStatus.CanBeFollowedByAnything)
                {
                    if (status == TailRecursionStatus.NotTailRecursive)
                    {
                        // an error has already been reported
                    }
                    else if (reportErrors)
                    {
                        reporter.Error(MessageSource.Resolver, tailCall.Tok, MutateCSharp.Schemata438.ReplaceStringConstant_1(84L, "a recursive call inside a loop is not recognized as being a tail call"));
                    }
                    return TailRecursionStatus.NotTailRecursive;
                }
            }
            else if (stmt is AlternativeLoopStmt)
            {
                var s = (AlternativeLoopStmt)stmt;
                foreach (var alt in s.Alternatives)
                {
                    DisallowRecursiveCallsInExpressions(alt.Guard, enclosingMethod, reportErrors);
                    var status = CheckTailRecursive(alt.Body, enclosingMethod, ref tailCall, reportErrors);
                    if (status != TailRecursionStatus.CanBeFollowedByAnything)
                    {
                        if (status == TailRecursionStatus.NotTailRecursive)
                        {
                            // an error has already been reported
                        }
                        else if (reportErrors)
                        {
                            reporter.Error(MessageSource.Resolver, tailCall.Tok, MutateCSharp.Schemata438.ReplaceStringConstant_1(85L, "a recursive call inside a loop is not recognized as being a tail call"));
                        }
                        return TailRecursionStatus.NotTailRecursive;
                    }
                }
            }
            else if (stmt is ForallStmt)
            {
                var s = (ForallStmt)stmt;
                DisallowRecursiveCallsInExpressions(s.Range, enclosingMethod, reportErrors);
                var status = TailRecursionStatus.NotTailRecursive;
                if (MutateCSharp.Schemata438.ReplaceBinExprOp_7(86L, s.Body, null))
                {
                    status = CheckTailRecursive(s.Body, enclosingMethod, ref tailCall, reportErrors);
                }
                if (status != TailRecursionStatus.CanBeFollowedByAnything)
                {
                    if (status == TailRecursionStatus.NotTailRecursive)
                    {
                        // an error has already been reported
                    }
                    else if (reportErrors)
                    {
                        reporter.Error(MessageSource.Resolver, tailCall.Tok, MutateCSharp.Schemata438.ReplaceStringConstant_1(87L, "a recursive call inside a forall statement is not a tail call"));
                    }
                    return TailRecursionStatus.NotTailRecursive;
                }
            }
            else if (stmt is NestedMatchStmt nestedMatchStmt)
            {
                DisallowRecursiveCallsInExpressions(nestedMatchStmt.Source, enclosingMethod, reportErrors);
                var status = TailRecursionStatus.CanBeFollowedByAnything;
                foreach (var kase in nestedMatchStmt.Cases)
                {
                    var st = CheckTailRecursive(kase.Body, enclosingMethod, ref tailCall, reportErrors);
                    if (st == TailRecursionStatus.NotTailRecursive)
                    {
                        return st;
                    }
                    else if (st == TailRecursionStatus.TailCallSpent)
                    {
                        status = st;
                    }
                }
                return status;
            }
            else if (stmt is MatchStmt)
            {
                var s = (MatchStmt)stmt;
                DisallowRecursiveCallsInExpressions(s.Source, enclosingMethod, reportErrors);
                var status = TailRecursionStatus.CanBeFollowedByAnything;
                foreach (var kase in s.Cases)
                {
                    var st = CheckTailRecursive(kase.Body, enclosingMethod, ref tailCall, reportErrors);
                    if (st == TailRecursionStatus.NotTailRecursive)
                    {
                        return st;
                    }
                    else if (st == TailRecursionStatus.TailCallSpent)
                    {
                        status = st;
                    }
                }
                return status;
            }
            else if (stmt is AssignSuchThatStmt)
            {
            }
            else if (stmt is AssignOrReturnStmt)
            {
                // TODO this should be the conservative choice, but probably we can consider this to be tail-recursive
                // under some conditions? However, how does this interact with compiling to exceptions?
                return TailRecursionStatus.NotTailRecursive;
            }
            else if (stmt is UpdateStmt)
            {
                var s = (UpdateStmt)stmt;
                var ss = s.ResolvedStatements;
                if (MutateCSharp.Schemata438.ReplaceBinExprOp_5(92L, ss.Count, MutateCSharp.Schemata438.ReplaceNumericConstant_3(88L, 1)))
                {
                    return CheckTailRecursive(ss, enclosingMethod, ref tailCall, reportErrors);
                }
                else
                {
                    foreach (var r in ss)
                    {
                        DisallowRecursiveCallsInExpressions(r, enclosingMethod, reportErrors);
                    }
                }
            }
            else if (stmt is VarDeclStmt)
            {
                var s = (VarDeclStmt)stmt;
                if (MutateCSharp.Schemata438.ReplaceBinExprOp_13(97L, s.Update, null))
                {
                    return CheckTailRecursive(s.Update, enclosingMethod, ref tailCall, reportErrors);
                }
            }
            else if (stmt is VarDeclPattern)
            {
            }
            else if (stmt is ExpectStmt)
            {
            }
            else
            {
                Contract.Assert(false);  // unexpected statement type
            }
            DisallowRecursiveCallsInExpressions(stmt, enclosingMethod, reportErrors);
            return TailRecursionStatus.CanBeFollowedByAnything;
        }

        /// <summary>
        /// If "enclosingMethod" is a by-method, then look through "stmt" for any expression that
        /// calls the function corresponding to the by-method. Report an error if such a call is
        /// found.
        /// </summary>
        void DisallowRecursiveCallsInExpressions(Statement stmt, Method enclosingMethod, bool reportErrors)
        {
            Contract.Requires(stmt != null);
            Contract.Requires(enclosingMethod != null);

            if (MutateCSharp.Schemata438.ReplaceBinExprOp_2(98L, () => enclosingMethod.IsByMethod, () => reportErrors))
            {
                stmt.SubExpressions.ForEach(e => DisallowRecursiveCallsInExpressions(e, enclosingMethod));
            }
        }

        void DisallowRecursiveCallsInExpressions(Expression/*?*/ expr, Method enclosingMethod, bool reportErrors)
        {
            Contract.Requires(enclosingMethod != null);

            if (MutateCSharp.Schemata438.ReplaceBinExprOp_2(105L, () => MutateCSharp.Schemata438.ReplaceBinExprOp_14(104L, expr, null), () => reportErrors))
            {
                DisallowRecursiveCallsInExpressions(expr, enclosingMethod);
            }
        }

        void DisallowRecursiveCallsInExpressions(Expression expr, Method enclosingMethod)
        {
            Contract.Requires(expr != null);
            Contract.Requires(enclosingMethod != null);

            if (expr is FunctionCallExpr fce && MutateCSharp.Schemata438.ReplaceBinExprOp_10(111L, fce.Function.ByMethodDecl, enclosingMethod))
            {
                reporter.Error(MessageSource.Resolver, expr.tok, MutateCSharp.Schemata438.ReplaceStringConstant_1(112L, "a recursive call in this context is not recognized as a tail call"));
            }
            expr.SubExpressions.ForEach(ee => DisallowRecursiveCallsInExpressions(ee, enclosingMethod));
        }

        TailRecursionStatus ConfirmTailCall(IToken tok, Method method, List<Type> typeApplication_JustMember, List<Expression> lhss, bool reportErrors)
        {
            Contract.Requires(tok != null);
            Contract.Requires(method != null);
            Contract.Requires(typeApplication_JustMember != null);
            Contract.Requires(lhss != null);

            // It's a recursive call.  It can be considered a tail call only if the LHS of the call are the
            // formal out-parameters of the method
            for (int i = MutateCSharp.Schemata438.ReplaceNumericConstant_3(113L, 0); MutateCSharp.Schemata438.ReplaceBinExprOp_15(117L, i, lhss.Count); MutateCSharp.Schemata438.ReplacePostfixUnaryExprOp_16(122L, ref i))
            {
                var formal = method.Outs[i];
                if (!formal.IsGhost)
                {
                    if (lhss[i] is IdentifierExpr lhs && MutateCSharp.Schemata438.ReplaceBinExprOp_17(123L, lhs.Var, formal))
                    {
                        // all is good
                    }
                    else
                    {
                        if (reportErrors)
                        {
                            var outParamName = formal.HasName ? $" '{formal.Name}'" : "";
                            reporter.Error(MessageSource.Resolver, tok,
                MutateCSharp.Schemata438.ReplaceStringConstant_1(124L, "the recursive call to '{0}' is not tail recursive because the actual out-parameter{1} is not the formal out-parameter{2}"),
                              method.Name, MutateCSharp.Schemata438.ReplaceBinExprOp_5(129L, lhss.Count, MutateCSharp.Schemata438.ReplaceNumericConstant_3(125L, 1)) ? "" : MutateCSharp.Schemata438.ReplaceStringConstant_1(134L, " ") + i, outParamName);
                        }
                        return TailRecursionStatus.NotTailRecursive;
                    }
                }
            }
            // Moreover, it can be considered a tail recursive call only if the type parameters are the same
            // as in the caller.
            var classTypeParameterCount = method.EnclosingClass.TypeArgs.Count;
            Contract.Assert(typeApplication_JustMember.Count == method.TypeArgs.Count);
            for (int i = MutateCSharp.Schemata438.ReplaceNumericConstant_3(135L, 0); MutateCSharp.Schemata438.ReplaceBinExprOp_15(139L, i, method.TypeArgs.Count); MutateCSharp.Schemata438.ReplacePostfixUnaryExprOp_16(144L, ref i))
            {
                var formal = method.TypeArgs[i];
                var actual = typeApplication_JustMember[i].AsTypeParameter;
                if (MutateCSharp.Schemata438.ReplaceBinExprOp_18(145L, formal, actual))
                {
                    if (reportErrors)
                    {
                        reporter.Error(MessageSource.Resolver, tok,
              MutateCSharp.Schemata438.ReplaceStringConstant_1(146L, "the recursive call to '{0}' is not tail recursive because the actual type parameter{1} is not the formal type parameter '{2}'"),
                          method.Name, MutateCSharp.Schemata438.ReplaceBinExprOp_5(151L, method.TypeArgs.Count, MutateCSharp.Schemata438.ReplaceNumericConstant_3(147L, 1)) ? "" : MutateCSharp.Schemata438.ReplaceStringConstant_1(156L, " ") + i, formal.Name);
                    }
                    return TailRecursionStatus.NotTailRecursive;
                }
            }
            return TailRecursionStatus.TailCallSpent;
        }
        #endregion CheckTailRecursive

        // ------------------------------------------------------------------------------------------------------
        // ----- CheckTailRecursiveExpr -------------------------------------------------------------------------
        // ------------------------------------------------------------------------------------------------------
        #region CheckTailRecursiveExpr
        public void DetermineTailRecursion(Function f)
        {
            Contract.Requires(f != null);
            Contract.Requires(f.Body != null);
            bool tail = MutateCSharp.Schemata438.ReplaceBooleanConstant_0(157L, true);
            bool hasTailRecursionPreference = Attributes.ContainsBool(f.Attributes, MutateCSharp.Schemata438.ReplaceStringConstant_1(158L, "tailrecursion"), ref tail);
            if (MutateCSharp.Schemata438.ReplaceBinExprOp_2(159L, () => hasTailRecursionPreference, () => !tail))
            {
                // the user specifically requested no tail recursion, so do nothing else
            }
            else if (MutateCSharp.Schemata438.ReplaceBinExprOp_2(171L, () => MutateCSharp.Schemata438.ReplaceBinExprOp_2(165L, () => hasTailRecursionPreference, () => tail), () => f.IsGhost))
            {
                reporter.Error(MessageSource.Resolver, f.tok, MutateCSharp.Schemata438.ReplaceStringConstant_1(177L, "tail recursion can be specified only for functions that will be compiled, not for ghost functions"));
            }
            else
            {
                var module = f.EnclosingClass.EnclosingModuleDefinition;
                var sccSize = module.CallGraph.GetSCCSize(f);
                if (MutateCSharp.Schemata438.ReplaceBinExprOp_2(187L, () => hasTailRecursionPreference, () => MutateCSharp.Schemata438.ReplaceBinExprOp_4(182L, MutateCSharp.Schemata438.ReplaceNumericConstant_3(178L, 2), sccSize)))
                {
                    reporter.Error(MessageSource.Resolver, f.tok, MutateCSharp.Schemata438.ReplaceStringConstant_1(193L, "sorry, tail-call optimizations are not supported for mutually recursive functions"));
                }
                else if (MutateCSharp.Schemata438.ReplaceBinExprOp_6(203L, () => hasTailRecursionPreference, () => MutateCSharp.Schemata438.ReplaceBinExprOp_5(198L, sccSize, MutateCSharp.Schemata438.ReplaceNumericConstant_3(194L, 1))))
                {
                    var status = CheckTailRecursiveExpr(f.Body, f, MutateCSharp.Schemata438.ReplaceBooleanConstant_0(209L, true), hasTailRecursionPreference);
                    if (MutateCSharp.Schemata438.ReplaceBinExprOp_2(212L, () => MutateCSharp.Schemata438.ReplaceBinExprOp_19(210L, status, Function.TailStatus.TriviallyTailRecursive), () => MutateCSharp.Schemata438.ReplaceBinExprOp_19(211L, status, Function.TailStatus.NotTailRecursive)))
                    {
                        // this means there was at least one recursive call
                        f.TailRecursion = status;
                        if (MutateCSharp.Schemata438.ReplaceBinExprOp_20(218L, status, Function.TailStatus.TailRecursive))
                        {
                            reporter.Info(MessageSource.Resolver, f.tok, MutateCSharp.Schemata438.ReplaceStringConstant_1(219L, "tail recursive"));
                        }
                        else
                        {
                            reporter.Info(MessageSource.Resolver, f.tok, MutateCSharp.Schemata438.ReplaceStringConstant_1(220L, "auto-accumulator tail recursive"));
                        }
                    }
                }
            }
        }

        Function.TailStatus TRES_Or(Function.TailStatus a, Function.TailStatus b)
        {
            if (MutateCSharp.Schemata438.ReplaceBinExprOp_6(223L, () => MutateCSharp.Schemata438.ReplaceBinExprOp_20(221L, a, Function.TailStatus.NotTailRecursive), () => MutateCSharp.Schemata438.ReplaceBinExprOp_20(222L, b, Function.TailStatus.NotTailRecursive)))
            {
                return Function.TailStatus.NotTailRecursive;
            }
            else if (MutateCSharp.Schemata438.ReplaceBinExprOp_20(229L, a, Function.TailStatus.TriviallyTailRecursive))
            {
                return b;
            }
            else if (MutateCSharp.Schemata438.ReplaceBinExprOp_20(230L, b, Function.TailStatus.TriviallyTailRecursive))
            {
                return a;
            }
            else if (MutateCSharp.Schemata438.ReplaceBinExprOp_20(231L, a, Function.TailStatus.TailRecursive))
            {
                return b;
            }
            else if (MutateCSharp.Schemata438.ReplaceBinExprOp_20(232L, b, Function.TailStatus.TailRecursive))
            {
                return a;
            }
            else if (MutateCSharp.Schemata438.ReplaceBinExprOp_20(233L, a, b))
            {
                return a;
            }
            else
            {
                return Function.TailStatus.NotTailRecursive;
            }

            return default;
        }

        /// <summary>
        /// Checks if "expr" can be considered tail recursive, and (provided "reportError" is true) reports an error if not.
        /// Note, the current implementation is rather conservative in its analysis; upon need, the
        /// algorithm could be improved.
        /// In the current implementation, "enclosingFunction" is not allowed to be a mutually recursive function.
        ///
        /// If "allowAccumulator" is "true", then tail recursion also allows expressions of the form "E * F"
        /// and "F * E" where "F" is a tail-recursive expression without an accumulator, "E" has no occurrences
        /// of the enclosing function, and "*" is an associative and eager operator with a known (left or right, respectively)
        /// unit element. If "*" is such an operator, then "allowAccumulator" also allows expressions of
        /// the form "F - E', where "-" is an operator that satisfies "(A - X) - Y == A - (X * Y)".
        ///
        /// If "allowAccumulator" is "false", then this method returns one of these three values:
        ///     TriviallyTailRecursive, TailRecursive, NotTailRecursive
        /// </summary>
        Function.TailStatus CheckTailRecursiveExpr(Expression expr, Function enclosingFunction, bool allowAccumulator, bool reportErrors)
        {
            Contract.Requires(expr != null);
            Contract.Requires(enclosingFunction != null);

            expr = expr.Resolved;
            if (expr is FunctionCallExpr)
            {
                var e = (FunctionCallExpr)expr;
                var status = MutateCSharp.Schemata438.ReplaceBinExprOp_21(234L, e.Function, enclosingFunction) ? Function.TailStatus.TailRecursive : Function.TailStatus.TriviallyTailRecursive;
                for (var i = MutateCSharp.Schemata438.ReplaceNumericConstant_3(235L, 0); MutateCSharp.Schemata438.ReplaceBinExprOp_15(239L, i, e.Function.Ins.Count); MutateCSharp.Schemata438.ReplacePostfixUnaryExprOp_16(244L, ref i))
                {
                    if (!e.Function.Ins[i].IsGhost)
                    {
                        var s = CheckHasNoRecursiveCall(e.Args[i], enclosingFunction, reportErrors);
                        status = TRES_Or(status, s);
                    }
                }
                return status;

            }
            else if (expr is LetExpr)
            {
                var e = (LetExpr)expr;
                var status = Function.TailStatus.TriviallyTailRecursive;
                for (var i = MutateCSharp.Schemata438.ReplaceNumericConstant_3(245L, 0); MutateCSharp.Schemata438.ReplaceBinExprOp_15(249L, i, e.LHSs.Count); MutateCSharp.Schemata438.ReplacePostfixUnaryExprOp_16(254L, ref i))
                {
                    var pat = e.LHSs[i];
                    if (pat.Vars.ToList().Exists(bv => !bv.IsGhost))
                    {
                        if (e.Exact)
                        {
                            var s = CheckHasNoRecursiveCall(e.RHSs[i], enclosingFunction, reportErrors);
                            status = TRES_Or(status, s);
                        }
                        else
                        {
                            // We have detected the existence of a non-ghost LHS, so check the RHS
                            Contract.Assert(e.RHSs.Count == 1);
                            status = CheckHasNoRecursiveCall(e.RHSs[MutateCSharp.Schemata438.ReplaceNumericConstant_3(255L, 0)], enclosingFunction, reportErrors);
                            break;
                        }
                    }
                }
                var st = CheckTailRecursiveExpr(e.Body, enclosingFunction, allowAccumulator, reportErrors);
                return TRES_Or(status, st);

            }
            else if (expr is ITEExpr)
            {
                var e = (ITEExpr)expr;
                var s0 = CheckHasNoRecursiveCall(e.Test, enclosingFunction, reportErrors);
                var s1 = CheckTailRecursiveExpr(e.Thn, enclosingFunction, allowAccumulator, reportErrors);
                var s2 = CheckTailRecursiveExpr(e.Els, enclosingFunction, allowAccumulator, reportErrors);
                var status = TRES_Or(s0, TRES_Or(s1, s2));
                if (MutateCSharp.Schemata438.ReplaceBinExprOp_2(260L, () => reportErrors, () => MutateCSharp.Schemata438.ReplaceBinExprOp_20(259L, status, Function.TailStatus.NotTailRecursive)))
                {
                    // We get here for one of the following reasons:
                    //   *  e.Test mentions the function (in which case an error has already been reported),
                    //   *  either e.Thn or e.Els was determined to be NotTailRecursive (in which case an
                    //      error has already been reported),
                    //   *  e.Thn and e.Els have different kinds of accumulator needs
                    if (MutateCSharp.Schemata438.ReplaceBinExprOp_2(275L, () => MutateCSharp.Schemata438.ReplaceBinExprOp_2(268L, () => MutateCSharp.Schemata438.ReplaceBinExprOp_19(266L, s0, Function.TailStatus.NotTailRecursive), () => MutateCSharp.Schemata438.ReplaceBinExprOp_19(267L, s1, Function.TailStatus.NotTailRecursive)), () => MutateCSharp.Schemata438.ReplaceBinExprOp_19(274L, s2, Function.TailStatus.NotTailRecursive)))
                    {
                        reporter.Error(MessageSource.Resolver, expr, MutateCSharp.Schemata438.ReplaceStringConstant_1(281L, "if-then-else branches have different accumulator needs for tail recursion"));
                    }
                }
                return status;

            }
            else if (expr is NestedMatchExpr nestedMatchExpr)
            {
                var status = CheckHasNoRecursiveCall(nestedMatchExpr.Source, enclosingFunction, reportErrors);
                var newError = MutateCSharp.Schemata438.ReplaceBinExprOp_2(283L, () => reportErrors, () => MutateCSharp.Schemata438.ReplaceBinExprOp_19(282L, status, Function.TailStatus.NotTailRecursive));
                foreach (var kase in nestedMatchExpr.Cases)
                {
                    var s = CheckTailRecursiveExpr(kase.Body, enclosingFunction, allowAccumulator, reportErrors);
                    newError = MutateCSharp.Schemata438.ReplaceBinExprOp_2(290L, () => newError, () => MutateCSharp.Schemata438.ReplaceBinExprOp_19(289L, s, Function.TailStatus.NotTailRecursive));
                    status = TRES_Or(status, s);
                }
                if (MutateCSharp.Schemata438.ReplaceBinExprOp_2(297L, () => MutateCSharp.Schemata438.ReplaceBinExprOp_20(296L, status, Function.TailStatus.NotTailRecursive), () => newError))
                {
                    // see comments above for ITEExpr
                    // "newError" is "true" when: "reportErrors", and neither e.Source nor a kase.Body returned NotTailRecursive
                    reporter.Error(MessageSource.Resolver, expr, MutateCSharp.Schemata438.ReplaceStringConstant_1(303L, "cases have different accumulator needs for tail recursion"));
                }
                return status;
            }
            else if (expr is MatchExpr)
            {
                var e = (MatchExpr)expr;
                var status = CheckHasNoRecursiveCall(e.Source, enclosingFunction, reportErrors);
                var newError = MutateCSharp.Schemata438.ReplaceBinExprOp_2(305L, () => reportErrors, () => MutateCSharp.Schemata438.ReplaceBinExprOp_19(304L, status, Function.TailStatus.NotTailRecursive));
                foreach (var kase in e.Cases)
                {
                    var s = CheckTailRecursiveExpr(kase.Body, enclosingFunction, allowAccumulator, reportErrors);
                    newError = MutateCSharp.Schemata438.ReplaceBinExprOp_2(312L, () => newError, () => MutateCSharp.Schemata438.ReplaceBinExprOp_19(311L, s, Function.TailStatus.NotTailRecursive));
                    status = TRES_Or(status, s);
                }
                if (MutateCSharp.Schemata438.ReplaceBinExprOp_2(319L, () => MutateCSharp.Schemata438.ReplaceBinExprOp_20(318L, status, Function.TailStatus.NotTailRecursive), () => newError))
                {
                    // see comments above for ITEExpr
                    // "newError" is "true" when: "reportErrors", and neither e.Source nor a kase.Body returned NotTailRecursive
                    reporter.Error(MessageSource.Resolver, expr, MutateCSharp.Schemata438.ReplaceStringConstant_1(325L, "cases have different accumulator needs for tail recursion"));
                }
                return status;

            }
            else if (allowAccumulator && expr is BinaryExpr bin)
            {
                var accumulationOp = Function.TailStatus.TriviallyTailRecursive; // use TriviallyTailRecursive to mean bin.ResolvedOp does not support accumulation
                bool accumulatesOnlyOnRight = MutateCSharp.Schemata438.ReplaceBooleanConstant_0(326L, false);
                switch (bin.ResolvedOp)
                {
                    case BinaryExpr.ResolvedOpcode.Add:
                        if (enclosingFunction.ResultType.AsBitVectorType == null && !enclosingFunction.ResultType.IsCharType)
                        {
                            accumulationOp = Function.TailStatus.Accumulate_Add;
                        }
                        break;
                        break;
                    case BinaryExpr.ResolvedOpcode.Sub:
                        if (enclosingFunction.ResultType.AsBitVectorType == null && !enclosingFunction.ResultType.IsCharType)
                        {
                            accumulationOp = Function.TailStatus.AccumulateRight_Sub;
                            accumulatesOnlyOnRight = true;
                        }
                        break;
                        break;
                    case BinaryExpr.ResolvedOpcode.Mul:
                        if (enclosingFunction.ResultType.AsBitVectorType == null)
                        {
                            accumulationOp = Function.TailStatus.Accumulate_Mul;
                        }
                        break;
                        break;
                    case BinaryExpr.ResolvedOpcode.Union:
                        accumulationOp = Function.TailStatus.Accumulate_SetUnion;
                        break;
                        break;
                    case BinaryExpr.ResolvedOpcode.SetDifference:
                        accumulationOp = Function.TailStatus.AccumulateRight_SetDifference;
                        accumulatesOnlyOnRight = true;
                        break;
                        break;
                    case BinaryExpr.ResolvedOpcode.MultiSetUnion:
                        accumulationOp = Function.TailStatus.Accumulate_MultiSetUnion;
                        break;
                        break;
                    case BinaryExpr.ResolvedOpcode.MultiSetDifference:
                        accumulationOp = Function.TailStatus.AccumulateRight_MultiSetDifference;
                        accumulatesOnlyOnRight = true;
                        break;
                        break;
                    case BinaryExpr.ResolvedOpcode.Concat:
                        accumulationOp = Function.TailStatus.AccumulateLeft_Concat;  // could also be AccumulateRight_Concat--make more precise below
                        break;
                        break;
                    default:
                        break;
                        break;
                }
                if (MutateCSharp.Schemata438.ReplaceBinExprOp_19(327L, accumulationOp, Function.TailStatus.TriviallyTailRecursive))
                {
                    var s0 = CheckTailRecursiveExpr(bin.E0, enclosingFunction, MutateCSharp.Schemata438.ReplaceBooleanConstant_0(328L, false), reportErrors);
                    Function.TailStatus s1;
                    switch (s0)
                    {
                        case Function.TailStatus.NotTailRecursive:
                            // Any errors have already been reported, but still descend down bin.E1 (possibly reporting
                            // more errors) before returning with NotTailRecursive
                            s1 = CheckTailRecursiveExpr(bin.E1, enclosingFunction, false, reportErrors);
                            return s0;
                            break;
                        case Function.TailStatus.TriviallyTailRecursive:
                            // We are in a state that would allow AcculumateLeftTailRecursive. See what bin.E1 is like:
                            if (accumulatesOnlyOnRight)
                            {
                                s1 = CheckHasNoRecursiveCall(bin.E1, enclosingFunction, reportErrors);
                            }
                            else
                            {
                                s1 = CheckTailRecursiveExpr(bin.E1, enclosingFunction, false, reportErrors);
                            }
                            if (s1 == Function.TailStatus.TailRecursive)
                            {
                                bin.AccumulatesForTailRecursion = BinaryExpr.AccumulationOperand.Left;
                            }
                            else
                            {
                                Contract.Assert(s1 == Function.TailStatus.TriviallyTailRecursive || s1 == Function.TailStatus.NotTailRecursive);
                                return s1;
                            }
                            return accumulationOp;
                            break;
                        case Function.TailStatus.TailRecursive:
                            // We are in a state that would allow right-accumulative tail recursion. Check that the enclosing
                            // function is not mentioned in bin.E1.
                            s1 = CheckHasNoRecursiveCall(bin.E1, enclosingFunction, reportErrors);
                            if (s1 == Function.TailStatus.TriviallyTailRecursive)
                            {
                                bin.AccumulatesForTailRecursion = BinaryExpr.AccumulationOperand.Right;
                                if (accumulationOp == Function.TailStatus.AccumulateLeft_Concat)
                                {
                                    // switch to AccumulateRight_Concat, since we had approximated it as AccumulateLeft_Concat above
                                    return Function.TailStatus.AccumulateRight_Concat;
                                }
                                else
                                {
                                    return accumulationOp;
                                }
                            }
                            else
                            {
                                Contract.Assert(s1 == Function.TailStatus.NotTailRecursive);
                                return s1;
                            }

                            break;
                        default:
                            Contract.Assert(false); // unexpected case
                            throw new cce.UnreachableException();
                            break;
                    }
                }
                // not an operator that allows accumulation, so drop down below
            }
            else if (expr is StmtExpr)
            {
                var e = (StmtExpr)expr;
                // ignore the statement part, since it is ghost
                return CheckTailRecursiveExpr(e.E, enclosingFunction, allowAccumulator, reportErrors);
            }

            return CheckHasNoRecursiveCall(expr, enclosingFunction, reportErrors);
        }

        /// <summary>
        /// If "expr" contains a recursive call to "enclosingFunction" in some non-ghost subexpressions,
        /// then returns TailStatus.NotTailRecursive (and if "reportErrors" is "true", then
        /// reports an error about the recursive call), else returns TailStatus.TriviallyTailRecursive.
        /// </summary>
        Function.TailStatus CheckHasNoRecursiveCall(Expression expr, Function enclosingFunction, bool reportErrors)
        {
            Contract.Requires(expr != null);
            Contract.Requires(enclosingFunction != null);

            var status = Function.TailStatus.TriviallyTailRecursive;

            if (expr is FunctionCallExpr)
            {
                var e = (FunctionCallExpr)expr;
                if (MutateCSharp.Schemata438.ReplaceBinExprOp_21(329L, e.Function, enclosingFunction))
                {
                    if (reportErrors)
                    {
                        reporter.Error(MessageSource.Resolver, expr, MutateCSharp.Schemata438.ReplaceStringConstant_1(330L, "to be tail recursive, every use of this function must be part of a tail call or a simple accumulating tail call"));
                    }
                    status = Function.TailStatus.NotTailRecursive;
                }
                // skip ghost subexpressions
                for (var i = MutateCSharp.Schemata438.ReplaceNumericConstant_3(331L, 0); MutateCSharp.Schemata438.ReplaceBinExprOp_15(335L, i, e.Function.Ins.Count); MutateCSharp.Schemata438.ReplacePostfixUnaryExprOp_16(340L, ref i))
                {
                    if (!e.Function.Ins[i].IsGhost)
                    {
                        var s = CheckHasNoRecursiveCall(e.Args[i], enclosingFunction, reportErrors);
                        status = TRES_Or(status, s);
                    }
                }
                return status;

            }
            else if (expr is MemberSelectExpr)
            {
                var e = (MemberSelectExpr)expr;
                if (MutateCSharp.Schemata438.ReplaceBinExprOp_22(341L, e.Member, enclosingFunction))
                {
                    if (reportErrors)
                    {
                        reporter.Error(MessageSource.Resolver, expr, MutateCSharp.Schemata438.ReplaceStringConstant_1(342L, "to be tail recursive, every use of this function must be part of a tail call or a simple accumulating tail call"));
                    }
                    return Function.TailStatus.NotTailRecursive;
                }

            }
            else if (expr is LetExpr)
            {
                var e = (LetExpr)expr;
                // skip ghost subexpressions
                for (var i = MutateCSharp.Schemata438.ReplaceNumericConstant_3(343L, 0); MutateCSharp.Schemata438.ReplaceBinExprOp_15(347L, i, e.LHSs.Count); MutateCSharp.Schemata438.ReplacePostfixUnaryExprOp_16(352L, ref i))
                {
                    var pat = e.LHSs[i];
                    if (pat.Vars.ToList().Exists(bv => !bv.IsGhost))
                    {
                        if (e.Exact)
                        {
                            var s = CheckHasNoRecursiveCall(e.RHSs[i], enclosingFunction, reportErrors);
                            status = TRES_Or(status, s);
                        }
                        else
                        {
                            // We have detected the existence of a non-ghost LHS, so check the RHS
                            Contract.Assert(e.RHSs.Count == 1);
                            status = CheckHasNoRecursiveCall(e.RHSs[MutateCSharp.Schemata438.ReplaceNumericConstant_3(353L, 0)], enclosingFunction, reportErrors);
                            break;
                        }
                    }
                }
                var st = CheckHasNoRecursiveCall(e.Body, enclosingFunction, reportErrors);
                return TRES_Or(status, st);

            }
            else if (expr is DatatypeValue)
            {
                var e = (DatatypeValue)expr;
                // skip ghost subexpressions
                for (var i = MutateCSharp.Schemata438.ReplaceNumericConstant_3(357L, 0); MutateCSharp.Schemata438.ReplaceBinExprOp_15(361L, i, e.Ctor.Formals.Count); MutateCSharp.Schemata438.ReplacePostfixUnaryExprOp_16(366L, ref i))
                {
                    if (!e.Ctor.Formals[i].IsGhost)
                    {
                        var s = CheckHasNoRecursiveCall(e.Arguments[i], enclosingFunction, reportErrors);
                        status = TRES_Or(status, s);
                    }
                }
                return status;

            }

            foreach (var ee in expr.SubExpressions)
            {
                var s = CheckHasNoRecursiveCall(ee, enclosingFunction, reportErrors);
                status = TRES_Or(status, s);
            }
            return status;
        }

        #endregion CheckTailRecursiveExpr
    }
}
