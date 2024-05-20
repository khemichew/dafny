using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata25
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT25");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class SeqConstructionExpr : Expression, ICloneable<SeqConstructionExpr>
    {
        public Type/*?*/ ExplicitElementType;
        public Expression N;
        public Expression Initializer;

        public SeqConstructionExpr(Cloner cloner, SeqConstructionExpr original) : base(cloner, original)
        {
            var elemType = MutateCSharp.Schemata25.ReplaceBinExprOp_0(1L, original.ExplicitElementType, null) ? null : cloner.CloneType(original.ExplicitElementType);
            N = cloner.CloneExpr(original.N);
            Initializer = cloner.CloneExpr(original.Initializer);
            ExplicitElementType = elemType;
        }

        public SeqConstructionExpr(IToken tok, Type/*?*/ elementType, Expression length, Expression initializer)
          : base(tok)
        {
            Contract.Requires(tok != null);
            Contract.Requires(length != null);
            Contract.Requires(initializer != null);
            ExplicitElementType = elementType;
            N = length;
            Initializer = initializer;
        }
        public override IEnumerable<Expression> SubExpressions
        {
            get
            {
                yield return N;
                yield return Initializer;
            }
        }

        public override IEnumerable<Type> ComponentTypes
        {
            get
            {
                if (MutateCSharp.Schemata25.ReplaceBinExprOp_1(2L, ExplicitElementType, null))
                {
                    yield return ExplicitElementType;
                }

                yield break;
            }
        }

        public SeqConstructionExpr Clone(Cloner cloner)
        {
            return new SeqConstructionExpr(cloner, this);
        }
    }
}