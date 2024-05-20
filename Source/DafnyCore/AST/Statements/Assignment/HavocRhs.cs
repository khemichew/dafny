using System.Collections.Generic;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata141
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT141");
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
    public class HavocRhs : AssignmentRhs, ICloneable<HavocRhs>
    {
        public HavocRhs Clone(Cloner cloner)
        {
            return new HavocRhs(cloner, this);
        }
        public HavocRhs(IToken tok) : base(tok)
        {
        }

        private HavocRhs(Cloner cloner, HavocRhs havocRhs) : base(cloner, havocRhs)
        {
        }

        public override bool CanAffectPreviouslyKnownExpressions
        {
            get { return MutateCSharp.Schemata141.ReplaceBooleanConstant_0(1L, false); }
        }

        public override IEnumerable<INode> Children => Enumerable.Empty<Node>();
        public override IEnumerable<INode> PreResolveChildren => Enumerable.Empty<Node>();
    }
}