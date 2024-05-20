using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata140
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT140");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public class ExprRhs : AssignmentRhs, ICloneable<ExprRhs>
    {
        public readonly Expression Expr;
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(Expr != null);
        }
        public ExprRhs Clone(Cloner cloner)
        {
            return new ExprRhs(cloner, this);
        }

        public ExprRhs(Cloner cloner, ExprRhs original) : base(cloner, original)
        {
            Expr = cloner.CloneExpr(original.Expr);
        }

        public ExprRhs(Expression expr, Attributes attrs = null)
          : base(expr.tok, attrs)
        {
            Contract.Requires(expr != null);
            Expr = expr;
        }
        public override bool CanAffectPreviouslyKnownExpressions
        {
            get { return MutateCSharp.Schemata140.ReplaceBooleanConstant_0(1L, false); }
        }

        public override IEnumerable<Expression> NonSpecificationSubExpressions
        {
            get
            {
                yield return Expr;
            }
        }

        public override IEnumerable<Expression> PreResolveSubExpressions
        {
            get
            {
                foreach (var expr in base.PreResolveSubExpressions)
                {
                    yield return expr;
                }

                yield return Expr;
            }
        }

        public override IEnumerable<INode> Children => new[] { Expr };
        public override IEnumerable<INode> PreResolveChildren => PreResolveSubExpressions;
    }
}