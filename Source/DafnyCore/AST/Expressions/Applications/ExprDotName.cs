using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata10
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT10");
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

    /// <summary>
    /// An ExprDotName desugars into either an IdentifierExpr (if the Lhs is a static name) or a MemberSelectExpr (if the Lhs is a computed expression).
    /// </summary>
    public class ExprDotName : SuffixExpr, ICloneable<ExprDotName>
    {
        public readonly string SuffixName;
        public readonly List<Type> OptTypeArguments;

        /// <summary>
        /// Because the resolved expression only points to the final resolved declaration,
        /// but not the declaration of the Lhs, we must also include the Lhs.
        /// </summary>
        public override IEnumerable<INode> Children => MutateCSharp.Schemata10.ReplaceBinExprOp_0(1L, ResolvedExpression, null
      ) ? new[] { Lhs }
          : new[] { Lhs, ResolvedExpression };

        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(SuffixName != null);
        }

        public ExprDotName Clone(Cloner cloner)
        {
            return new ExprDotName(cloner, this);
        }

        public ExprDotName(Cloner cloner, ExprDotName original) : base(cloner, original)
        {
            SuffixName = original.SuffixName;
            OptTypeArguments = original.OptTypeArguments?.ConvertAll(cloner.CloneType);
        }

        public ExprDotName(IToken tok, Expression obj, string suffixName, List<Type> optTypeArguments)
          : base(tok, obj)
        {
            Contract.Requires(tok != null);
            Contract.Requires(obj != null);
            Contract.Requires(suffixName != null);
            this.SuffixName = suffixName;
            OptTypeArguments = optTypeArguments;
        }
    }
}