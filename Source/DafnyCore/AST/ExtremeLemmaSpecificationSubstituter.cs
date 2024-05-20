using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata83
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT83");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
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

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument1, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.FunctionCallExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Type> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.TernaryExpr.Opcode argument1, Microsoft.Dafny.TernaryExpr.Opcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_5(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public
/// <summary>
/// The ExtremeLemmaSpecificationSubstituter clones the precondition (or postcondition) declared
/// on a least (resp. greatest) lemma, but replaces the calls and equalities in "coConclusions"
/// with corresponding prefix versions.  The resulting expression is then appropriate to be a
/// precondition (resp. postcondition) of the least (resp. greatest) lemma's corresponding prefix lemma.
/// It is assumed that the source expression has been resolved.  Note, the "k" given to the constructor
/// is not cloned with each use; it is simply used as is.
/// The resulting expression needs to be resolved by the caller.
/// </summary>
class ExtremeLemmaSpecificationSubstituter : ExtremeCloner
    {
        readonly bool isCoContext;
        readonly ISet<Expression> friendlyCalls;
        public ExtremeLemmaSpecificationSubstituter(ISet<Expression> friendlyCalls, Expression k, ErrorReporter reporter, bool isCoContext)
          : base(k, reporter)
        {
            Contract.Requires(friendlyCalls != null);
            Contract.Requires(k != null);
            Contract.Requires(reporter != null);
            this.isCoContext = isCoContext;
            this.friendlyCalls = friendlyCalls;
        }
        public override Expression CloneExpr(Expression expr)
        {
            if (MutateCSharp.Schemata83.ReplaceBinExprOp_0(1L, () => expr is NameSegment, () => expr is ExprDotName))
            {
                // make sure to clone any user-supplied type-parameter instantiations
                return base.CloneExpr(expr);
            }
            else if (expr is ApplySuffix)
            {
                var e = (ApplySuffix)expr;
                var r = e.Resolved as FunctionCallExpr;
                if (MutateCSharp.Schemata83.ReplaceBinExprOp_2(8L, () => MutateCSharp.Schemata83.ReplaceBinExprOp_1(7L, r, null), () => friendlyCalls.Contains(r)))
                {
                    return CloneCallAndAddK(e);
                }
            }
            else if (expr is SuffixExpr)
            {
                // make sure to clone any user-supplied type-parameter instantiations
                return base.CloneExpr(expr);
            }
            else if (expr is ConcreteSyntaxExpression)
            {
                var e = (ConcreteSyntaxExpression)expr;
                // Note, the ExtremeLemmaSpecificationSubstituter is an unusual cloner in that it operates on
                // resolved expressions.  Hence, we bypass the syntactic parts here, except for the ones
                // checked above.
                return CloneExpr(e.Resolved);
            }
            else if (expr is FunctionCallExpr)
            {
                var e = (FunctionCallExpr)expr;
                if (friendlyCalls.Contains(e))
                {
                    return CloneCallAndAddK(e);
                }
            }
            else if (MutateCSharp.Schemata83.ReplaceBinExprOp_2(14L, () => expr is BinaryExpr, () => isCoContext))
            {
                var e = (BinaryExpr)expr;
                if (MutateCSharp.Schemata83.ReplaceBinExprOp_2(28L, () => (MutateCSharp.Schemata83.ReplaceBinExprOp_0(22L, () => MutateCSharp.Schemata83.ReplaceBinExprOp_3(20L, e.ResolvedOp, BinaryExpr.ResolvedOpcode.EqCommon), () => MutateCSharp.Schemata83.ReplaceBinExprOp_3(21L, e.ResolvedOp, BinaryExpr.ResolvedOpcode.NeqCommon))), () => friendlyCalls.Contains(e)))
                {
                    var op = MutateCSharp.Schemata83.ReplaceBinExprOp_3(34L, e.ResolvedOp, BinaryExpr.ResolvedOpcode.EqCommon) ? TernaryExpr.Opcode.PrefixEqOp : TernaryExpr.Opcode.PrefixNeqOp;
                    var A = CloneExpr(e.E0);
                    var B = CloneExpr(e.E1);
                    var teq = new TernaryExpr(Tok(e.tok), op, k, A, B);
                    var opString = MutateCSharp.Schemata83.ReplaceBinExprOp_4(35L, op, TernaryExpr.Opcode.PrefixEqOp) ? MutateCSharp.Schemata83.ReplaceStringConstant_5(36L, "==") : MutateCSharp.Schemata83.ReplaceStringConstant_5(37L, "!=");
                    reporter.Info(MessageSource.Cloner, e.tok, opString + suffix);
                    return teq;
                }
            }
            return base.CloneExpr(expr);
        }
        public override Type CloneType(Type t)
        {
            if (t is UserDefinedType)
            {
                var tt = (UserDefinedType)t;
                // We want syntactic cloning of the Expression that is tt.NamePath, unlike the semantic (that is, post-resolved)
                // cloning that CloneExpr is doing above.
                return new UserDefinedType(Tok(tt.tok), CloneNamePathExpression(tt.NamePath));
            }
            else
            {
                return base.CloneType(t);
            }

            return default;
        }
        Expression CloneNamePathExpression(Expression expr)
        {
            Contract.Requires(expr is NameSegment || expr is ExprDotName);
            if (expr is NameSegment)
            {
                var e = (NameSegment)expr;
                return new NameSegment(this, e);
            }
            else
            {
                var e = (ExprDotName)expr;
                return new ExprDotName(Tok(e.tok), CloneNamePathExpression(e.Lhs), e.SuffixName, MutateCSharp.Schemata83.ReplaceBinExprOp_6(38L, e.OptTypeArguments, null) ? null : e.OptTypeArguments.ConvertAll(CloneType));
            }

            return default;
        }
    }
}
