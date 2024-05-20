using System.Collections.Generic;
namespace MutateCSharp
{
    internal class Schemata179
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT179");
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
    public
class SubstitutingCloner : Cloner
    {
        private readonly Dictionary<IVariable, IVariable> substitutions;

        public SubstitutingCloner(Dictionary<IVariable, IVariable> substitutions, bool cloneResolvedFields)
          : base(MutateCSharp.Schemata179.ReplaceBooleanConstant_0(1L, false), cloneResolvedFields)
        {
            this.substitutions = substitutions;
        }

        public override Expression CloneExpr(Expression expr)
        {
            if (expr is IdentifierExpr identifierExpr)
            {
                if (substitutions.TryGetValue(identifierExpr.Var, out var variableReplacement))
                {
                    // TODO consider using the code from Substituter
                    return new IdentifierExpr(expr.tok, variableReplacement);
                }
            }

            return base.CloneExpr(expr);
        }
    }
}