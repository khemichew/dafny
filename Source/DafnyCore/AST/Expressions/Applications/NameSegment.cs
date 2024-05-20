using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata14
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT14");
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
    public class NameSegment : ConcreteSyntaxExpression, ICloneable<NameSegment>, ICanFormat
    {
        public readonly string Name;
        public readonly List<Type> OptTypeArguments;
        public NameSegment(IToken tok, string name, List<Type> optTypeArguments)
          : base(tok)
        {
            Contract.Requires(tok != null);
            Contract.Requires(name != null);
            Contract.Requires(optTypeArguments == null || optTypeArguments.Count > 0);
            Name = name;
            OptTypeArguments = optTypeArguments;
        }

        public NameSegment(Cloner cloner, NameSegment original) : base(cloner, original)
        {
            Name = original.Name;
            OptTypeArguments = original.OptTypeArguments?.ConvertAll(cloner.CloneType);
        }

        public NameSegment Clone(Cloner cloner)
        {
            return new NameSegment(cloner, this);
        }

        public override IEnumerable<INode> PreResolveChildren => OptTypeArguments ?? new List<Type>();
        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            formatter.SetTypeLikeIndentation(indentBefore, OwnedTokens);
            foreach (var subType in PreResolveChildren.OfType<Type>())
            {
                formatter.SetTypeIndentation(subType);
            }
            return MutateCSharp.Schemata14.ReplaceBooleanConstant_0(1L, false);
        }
    }
}