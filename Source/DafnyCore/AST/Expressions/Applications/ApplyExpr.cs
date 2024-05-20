using System.Collections.Generic;
namespace MutateCSharp
{
    internal class Schemata8
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT8");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class ApplyExpr : Expression, ICloneable<ApplyExpr>
    {
        // The idea is that this apply expression does not need a type argument substitution,
        // since lambda functions and anonymous functions are never polymorphic.
        // Make a FunctionCallExpr otherwise, to call a resolvable anonymous function.
        public readonly Expression Function;
        public readonly List<Expression> Args;

        public override IEnumerable<Expression> SubExpressions
        {
            get
            {
                yield return Function;
                foreach (var e in Args)
                {
                    yield return e;
                }

                yield break;
            }
        }

        public IToken CloseParen;

        public ApplyExpr(Cloner cloner, ApplyExpr original) : base(cloner, original)
        {
            Function = cloner.CloneExpr(original.Function);
            Args = original.Args.ConvertAll(cloner.CloneExpr);
            CloseParen = cloner.Tok(original.CloseParen);
        }

        public ApplyExpr(IToken tok, Expression fn, List<Expression> args, IToken closeParen)
          : base(tok)
        {
            Function = fn;
            Args = args;
            CloseParen = closeParen;
            FormatTokens = MutateCSharp.Schemata8.ReplaceBinExprOp_0(1L, closeParen, null) ? new[] { closeParen } : null;
        }

        public ApplyExpr Clone(Cloner cloner)
        {
            return new ApplyExpr(cloner, this);
        }
    }
}