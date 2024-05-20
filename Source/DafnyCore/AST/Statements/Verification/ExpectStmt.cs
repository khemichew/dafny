using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata174
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT174");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static string ReplaceStringConstant_3(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.IToken argument1, Microsoft.Dafny.IToken argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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
    public class ExpectStmt : PredicateStmt, ICloneable<ExpectStmt>, ICanFormat
    {
        public Expression Message;

        public ExpectStmt Clone(Cloner cloner)
        {
            return new ExpectStmt(cloner, this);
        }

        public override IToken Tok => MutateCSharp.Schemata174.ReplaceBinExprOp_0(1L, StartToken, Expr.StartToken) ? Expr.Tok : base.Tok; // TODO move up to PredicateStmt?

        public ExpectStmt(Cloner cloner, ExpectStmt original) : base(cloner, original)
        {
            Message = cloner.CloneExpr(original.Message);
        }

        public ExpectStmt(RangeToken rangeToken, Expression expr, Expression message, Attributes attrs)
          : base(rangeToken, expr, attrs)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(expr != null);
            this.Message = message;
        }

        public override IEnumerable<Expression> NonSpecificationSubExpressions
        {
            get
            {
                foreach (var e in base.NonSpecificationSubExpressions) { yield return e; }
                yield return Expr;
                if (MutateCSharp.Schemata174.ReplaceBinExprOp_1(2L, Message, null))
                {
                    yield return Message;
                }

                yield break;
            }
        }

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            return formatter.SetIndentAssertLikeStatement(this, indentBefore);
        }

        public override void GenResolve(INewOrOldResolver resolver, ResolutionContext context)
        {
            base.GenResolve(resolver, context);
            if (MutateCSharp.Schemata174.ReplaceBinExprOp_2(3L, Message, null))
            {
                Message = new StringLiteralExpr(Tok, MutateCSharp.Schemata174.ReplaceStringConstant_3(4L, "expectation violation"), MutateCSharp.Schemata174.ReplaceBooleanConstant_4(5L, false));
            }
            resolver.ResolveExpression(Message, context);
        }
    }
}