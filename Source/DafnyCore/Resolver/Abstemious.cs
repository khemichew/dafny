using System.Diagnostics.Contracts;
using Microsoft.Boogie;
using static Microsoft.Dafny.ResolutionErrors;
namespace MutateCSharp
{
    internal class Schemata363
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT363");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
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

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static string ReplaceStringConstant_2(long mutantId, string argument1)
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

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument1, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.IdentifierExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
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
    public class Abstemious
    {
        private readonly ErrorReporter reporter;

        public Abstemious(ErrorReporter reporter)
        {
            this.reporter = reporter;
        }

        public void Check(Function fn)
        {
            if (MutateCSharp.Schemata363.ReplaceBinExprOp_0(1L, fn.Body, null))
            {
                var abstemious = MutateCSharp.Schemata363.ReplaceBooleanConstant_1(2L, true);
                if (Attributes.ContainsBool(fn.Attributes, MutateCSharp.Schemata363.ReplaceStringConstant_2(3L, "abstemious"), ref abstemious) && abstemious)
                {
                    if (MutateCSharp.Schemata363.ReplaceBinExprOp_4(8L, CoCallResolution.GuaranteedCoCtors(fn), MutateCSharp.Schemata363.ReplaceNumericConstant_3(4L, 0)))
                    {
                        reporter.Error(MessageSource.Resolver, ErrorId.r_abstemious_needs_conconstructor, fn, MutateCSharp.Schemata363.ReplaceStringConstant_2(13L, "the value returned by an abstemious function must come from invoking a co-constructor"));
                    }
                    else
                    {
                        CheckDestructsAreAbstemiousCompliant(fn.Body);
                    }
                }
            }
        }

        private void CheckDestructsAreAbstemiousCompliant(Expression expr)
        {
            Contract.Assert(expr != null);
            expr = expr.Resolved;
            if (expr is MemberSelectExpr)
            {
                var e = (MemberSelectExpr)expr;
                if (e.Member.EnclosingClass is CoDatatypeDecl)
                {
                    var ide = Expression.StripParens(e.Obj).Resolved as IdentifierExpr;
                    if (MutateCSharp.Schemata363.ReplaceBinExprOp_6(15L, () => MutateCSharp.Schemata363.ReplaceBinExprOp_5(14L, ide, null), () => ide.Var is Formal))
                    {
                        // cool
                    }
                    else
                    {
                        reporter.Error(MessageSource.Resolver, ErrorId.r_bad_astemious_destructor, expr, MutateCSharp.Schemata363.ReplaceStringConstant_2(21L, "an abstemious function is allowed to invoke a codatatype destructor only on its parameters"));
                    }
                    return;
                }
            }
            else if (expr is NestedMatchExpr nestedMatchExpr)
            {
                if (nestedMatchExpr.Source.Type.IsCoDatatype)
                {
                    var ide = Expression.StripParens(nestedMatchExpr.Source).Resolved as IdentifierExpr;
                    if (MutateCSharp.Schemata363.ReplaceBinExprOp_6(23L, () => MutateCSharp.Schemata363.ReplaceBinExprOp_5(22L, ide, null), () => ide.Var is Formal))
                    {
                        // cool; fall through to check match branches
                    }
                    else
                    {
                        reporter.Error(MessageSource.Resolver, ErrorId.r_bad_astemious_nested_match, nestedMatchExpr.Source, MutateCSharp.Schemata363.ReplaceStringConstant_2(29L, "an abstemious function is allowed to codatatype-match only on its parameters"));
                        return;
                    }
                }
            }
            else if (expr is MatchExpr)
            {
                var e = (MatchExpr)expr;
                if (e.Source.Type.IsCoDatatype)
                {
                    var ide = Expression.StripParens(e.Source).Resolved as IdentifierExpr;
                    if (MutateCSharp.Schemata363.ReplaceBinExprOp_6(31L, () => MutateCSharp.Schemata363.ReplaceBinExprOp_5(30L, ide, null), () => ide.Var is Formal))
                    {
                        // cool; fall through to check match branches
                    }
                    else
                    {
                        reporter.Error(MessageSource.Resolver, ErrorId.r_bad_astemious_match, e.Source, MutateCSharp.Schemata363.ReplaceStringConstant_2(37L, "an abstemious function is allowed to codatatype-match only on its parameters"));
                        return;
                    }
                }
            }
            else if (expr is BinaryExpr)
            {
                var e = (BinaryExpr)expr;
                if (MutateCSharp.Schemata363.ReplaceBinExprOp_8(40L, () => MutateCSharp.Schemata363.ReplaceBinExprOp_7(38L, e.ResolvedOp, BinaryExpr.ResolvedOpcode.EqCommon), () => MutateCSharp.Schemata363.ReplaceBinExprOp_7(39L, e.ResolvedOp, BinaryExpr.ResolvedOpcode.NeqCommon)))
                {
                    if (e.E0.Type.IsCoDatatype)
                    {
                        reporter.Error(MessageSource.Resolver, ErrorId.r_bad_astemious_codatatype_equality, expr, MutateCSharp.Schemata363.ReplaceStringConstant_2(46L, "an abstemious function is not allowed to check codatatype equality"));
                        return;
                    }
                }
            }
            else if (expr is StmtExpr)
            {
                var e = (StmtExpr)expr;
                // ignore the statement part
                CheckDestructsAreAbstemiousCompliant(e.E);
                return;
            }
            expr.SubExpressions.ForEach(CheckDestructsAreAbstemiousCompliant);
        }
    }
}