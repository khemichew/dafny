using System.Collections.Generic;
namespace MutateCSharp
{
    internal class Schemata60
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT60");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class ParensExpression : ConcreteSyntaxExpression, ICanFormat, ICloneable<ParensExpression>
    {
        public readonly Expression E;
        public ParensExpression(IToken tok, Expression e)
          : base(tok)
        {
            E = e;
        }

        protected ParensExpression(Cloner cloner, ParensExpression original) : base(cloner, original)
        {
            E = cloner.CloneExpr(original.E);
        }

        public override IEnumerable<Expression> SubExpressions
        {
            get
            {
                if (MutateCSharp.Schemata60.ReplaceBinExprOp_0(1L, ResolvedExpression, null))
                {
                    yield return E;
                }
                else
                {
                    yield return ResolvedExpression;
                }

                yield break;
            }
        }

        public override IEnumerable<Expression> PreResolveSubExpressions
        {
            get
            {
                yield return E;
            }
        }

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            return formatter.SetIndentParensExpression(indentBefore, OwnedTokens);
        }

        public ParensExpression Clone(Cloner cloner)
        {
            return new ParensExpression(cloner, this);
        }
    }
}