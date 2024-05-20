using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata54
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT54");
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
    public class OldExpr : Expression, ICloneable<OldExpr>, ICanFormat
    {
        [Peer]
        public readonly Expression E;
        public readonly string/*?*/ At;
        [FilledInDuringResolution] public Label/*?*/ AtLabel;  // after that, At==null iff AtLabel==null
        [FilledInDuringResolution]
        public bool Useless = MutateCSharp.Schemata54.ReplaceBooleanConstant_0(1L, false);
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(E != null);
        }

        public OldExpr(Cloner cloner, OldExpr original) : base(cloner, original)
        {
            E = cloner.CloneExpr(original.E);
            At = original.At;
            if (cloner.CloneResolvedFields)
            {
                AtLabel = original.AtLabel;
                Useless = original.Useless;
            }
        }

        public OldExpr Clone(Cloner cloner)
        {
            return new OldExpr(cloner, this);
        }

        [Captured]
        public OldExpr(IToken tok, Expression expr, string at = null)
          : base(tok)
        {
            Contract.Requires(tok != null);
            Contract.Requires(expr != null);
            cce.Owner.AssignSame(this, expr);
            E = expr;
            At = at;
        }

        public override IEnumerable<Expression> SubExpressions
        {
            get { yield return E; }
        }

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            return formatter.SetIndentParensExpression(indentBefore, OwnedTokens);
        }
    }
}
