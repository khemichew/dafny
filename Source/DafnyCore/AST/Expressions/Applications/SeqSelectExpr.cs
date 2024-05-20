using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata15
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT15");
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

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class SeqSelectExpr : Expression, ICloneable<SeqSelectExpr>
    {
        public readonly bool SelectOne;  // false means select a range
        public readonly Expression Seq;
        public readonly Expression E0;
        public readonly Expression E1;
        public readonly IToken CloseParen;

        public SeqSelectExpr(Cloner cloner, SeqSelectExpr original) : base(cloner, original)
        {
            SelectOne = original.SelectOne;
            Seq = cloner.CloneExpr(original.Seq);
            E0 = cloner.CloneExpr(original.E0);
            E1 = cloner.CloneExpr(original.E1);
            CloseParen = cloner.Tok(original.CloseParen);
        }

        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(Seq != null);
            Contract.Invariant(!SelectOne || E1 == null);
        }

        public SeqSelectExpr(IToken tok, bool selectOne, Expression seq, Expression e0, Expression e1, IToken closeParen)
          : base(tok)
        {
            Contract.Requires(tok != null);
            Contract.Requires(seq != null);
            Contract.Requires(!selectOne || e1 == null);

            SelectOne = selectOne;
            Seq = seq;
            E0 = e0;
            E1 = e1;
            CloseParen = closeParen;
            if (MutateCSharp.Schemata15.ReplaceBinExprOp_0(1L, closeParen, null))
            {
                FormatTokens = new[] { closeParen };
            }
        }

        public override IEnumerable<Expression> SubExpressions
        {
            get
            {
                yield return Seq;
                if (MutateCSharp.Schemata15.ReplaceBinExprOp_1(2L, E0, null))
                {
                    yield return E0;
                }

                if (MutateCSharp.Schemata15.ReplaceBinExprOp_1(3L, E1, null))
                {
                    yield return E1;
                }

                yield break;
            }
        }

        public SeqSelectExpr Clone(Cloner cloner)
        {
            return new SeqSelectExpr(cloner, this);
        }
    }
}