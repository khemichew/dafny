using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata156
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT156");
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

    }
}

namespace Microsoft.Dafny
{
    public class Label
    {
        public readonly IToken Tok;
        public readonly string Name;
        string uniqueId = null;
        public string AssignUniqueId(FreshIdGenerator idGen)
        {
            if (uniqueId == null)
            {
                uniqueId = idGen.FreshNumericId(MutateCSharp.Schemata156.ReplaceStringConstant_0(1L, "label"));
            }
            return uniqueId;
        }
        public Label(IToken tok, string/*?*/ label)
        {
            Contract.Requires(tok != null);
            Tok = tok;
            Name = label;
        }
    }
}