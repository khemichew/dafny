using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MutateCSharp
{
    internal class Schemata476
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT476");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, System.Collections.Generic.IEnumerable<Microsoft.Dafny.Triggers.TriggerTerm> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny.Triggers
{
    public class TriggerAnnotation
    {
        public readonly bool IsTriggerKiller;
        internal readonly ISet<IVariable> Variables;
        internal readonly List<TriggerTerm> PrivateTerms;
        internal readonly List<TriggerTerm> ExportedTerms;

        internal TriggerAnnotation(bool isTriggerKiller,
          IEnumerable<IVariable> variables,
          IEnumerable<TriggerTerm> allTerms,
          IEnumerable<TriggerTerm> privateTerms = null)
        {
            this.IsTriggerKiller = isTriggerKiller;
            this.Variables = new HashSet<IVariable>(variables);
            this.PrivateTerms = new List<TriggerTerm>(privateTerms ?? Enumerable.Empty<TriggerTerm>());
            this.ExportedTerms = new List<TriggerTerm>(MutateCSharp.Schemata476.ReplaceBinExprOp_0(1L, allTerms, null) ? Enumerable.Empty<TriggerTerm>() : allTerms.Except(this.PrivateTerms));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string indent = MutateCSharp.Schemata476.ReplaceStringConstant_1(2L, "  {0}"), nindent = MutateCSharp.Schemata476.ReplaceStringConstant_1(3L, "\n  - {0}"), subindent = MutateCSharp.Schemata476.ReplaceStringConstant_1(4L, "\n    * {0}");

            sb.AppendFormat(indent, IsTriggerKiller);

            sb.AppendFormat(nindent, MutateCSharp.Schemata476.ReplaceStringConstant_1(5L, "Variables:"));
            foreach (var bv in Variables)
            {
                sb.AppendFormat(subindent, bv.Name);
            }

            sb.AppendFormat(nindent, MutateCSharp.Schemata476.ReplaceStringConstant_1(6L, "Exported terms:"));
            foreach (var term in ExportedTerms)
            {
                sb.AppendFormat(subindent, term);
            }

            if (PrivateTerms.Any())
            {
                sb.AppendFormat(nindent, MutateCSharp.Schemata476.ReplaceStringConstant_1(7L, "Private terms:"));
                foreach (var term in PrivateTerms)
                {
                    sb.AppendFormat(subindent, term);
                }
            }

            return sb.ToString();
        }
    }
}