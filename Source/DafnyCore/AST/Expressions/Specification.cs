using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata63
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT63");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class Specification<T> : TokenNode, IAttributeBearingDeclaration
      where T : Node
    {
        public readonly List<T> Expressions;

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(Expressions == null || cce.NonNullElements<T>(Expressions));
        }

        public Specification()
        {
            Expressions = new List<T>();
            Attributes = null;
        }

        public Specification(List<T> exprs, Attributes attrs)
        {
            Contract.Requires(exprs == null || cce.NonNullElements<T>(exprs));
            Expressions = exprs;
            Attributes = attrs;
        }

        public Attributes Attributes { get; set; }

        public bool HasAttributes()
        {
            return MutateCSharp.Schemata63.ReplaceBinExprOp_0(1L, Attributes, null);
        }

        public override IEnumerable<INode> Children => Expressions;
        public override IEnumerable<INode> PreResolveChildren => Children;
    }
}