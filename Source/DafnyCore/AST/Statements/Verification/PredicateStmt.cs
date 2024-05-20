using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata176
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT176");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public abstract class PredicateStmt : Statement, ICanResolveNewAndOld
    {
        public readonly Expression Expr;
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(Expr != null);
        }

        protected PredicateStmt(Cloner cloner, PredicateStmt original) : base(cloner, original)
        {
            Expr = cloner.CloneExpr(original.Expr);
        }

        protected PredicateStmt(RangeToken rangeToken, Expression expr, Attributes attrs)
          : base(rangeToken, attrs)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(expr != null);
            this.Expr = expr;
        }

        protected PredicateStmt(RangeToken rangeToken, Expression expr)
          : this(rangeToken, expr, null)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(expr != null);
            this.Expr = expr;
        }

        public override void GenResolve(INewOrOldResolver resolver, ResolutionContext context)
        {
            base.GenResolve(resolver, context);
            resolver.ResolveExpression(Expr, context);// follows from postcondition of ResolveExpression
            resolver.ConstrainTypeExprBool(Expr, MutateCSharp.Schemata176.ReplaceStringConstant_0(1L, "condition is expected to be of type bool, but is {0}"));
        }
    }
}