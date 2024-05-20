using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata43
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT43");
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

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public class DisjunctivePattern : ExtendedPattern
    {
        public readonly List<ExtendedPattern> Alternatives;
        public DisjunctivePattern(IToken tok, List<ExtendedPattern> alternatives, bool isGhost = false) : base(tok, isGhost)
        {
            Contract.Requires(alternatives != null && alternatives.Count > 0);
            this.Alternatives = alternatives;
        }

        public override IEnumerable<INode> Children => Alternatives;
        public override IEnumerable<INode> PreResolveChildren => Children;

        public override IEnumerable<Expression> SubExpressions
        {
            get
            {
                foreach (var alternative in Alternatives)
                {
                    foreach (var ee in alternative.SubExpressions)
                    {
                        yield return ee;
                    }
                }

                yield break;
            }
        }

        public override void Resolve(ModuleResolver resolver, ResolutionContext resolutionContext,
          Type sourceType, bool isGhost, bool inStatementContext,
          bool inPattern, bool inDisjunctivePattern)
        {

            if (inPattern)
            {
                resolver.reporter.Error(MessageSource.Resolver, Tok, MutateCSharp.Schemata43.ReplaceStringConstant_0(1L, "Disjunctive patterns are not allowed inside other patterns"));
            }

            foreach (var alternative in Alternatives)
            {
                alternative.Resolve(resolver, resolutionContext, sourceType, isGhost, inStatementContext, MutateCSharp.Schemata43.ReplaceBooleanConstant_1(2L, true), MutateCSharp.Schemata43.ReplaceBooleanConstant_1(3L, true));
            }
        }
    }
}