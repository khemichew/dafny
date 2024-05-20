namespace MutateCSharp
{
    internal class Schemata264
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT264");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.CoverageLabel argument1, Microsoft.Dafny.CoverageLabel argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() || argument2();
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.CoverageLabel argument1, Microsoft.Dafny.CoverageLabel argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_3(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}
#nullable disable

namespace Microsoft.Dafny
{
    public enum CoverageLabel
    {
        None,
        NotApplicable,
        FullyCovered,
        NotCovered,
        PartiallyCovered,
    }

    public static class CoverageLabelExtension
    {

        /// <summary>
        /// Combine coverage labels. E.g. FullyCovered + NotCovered = PartiallyCovered
        /// </summary>
        public static CoverageLabel Combine(CoverageLabel one, CoverageLabel two)
        {
            if (MutateCSharp.Schemata264.ReplaceBinExprOp_1(3L, () => MutateCSharp.Schemata264.ReplaceBinExprOp_0(1L, one, CoverageLabel.NotApplicable), () => MutateCSharp.Schemata264.ReplaceBinExprOp_0(2L, two, CoverageLabel.NotApplicable)))
            {
                return CoverageLabel.NotApplicable;
            }
            if (MutateCSharp.Schemata264.ReplaceBinExprOp_0(9L, one, CoverageLabel.None))
            {
                return two;
            }
            if (MutateCSharp.Schemata264.ReplaceBinExprOp_0(10L, two, CoverageLabel.None))
            {
                return one;
            }
            if (MutateCSharp.Schemata264.ReplaceBinExprOp_1(20L, () => MutateCSharp.Schemata264.ReplaceBinExprOp_1(13L, () => MutateCSharp.Schemata264.ReplaceBinExprOp_0(11L, one, CoverageLabel.PartiallyCovered), () => MutateCSharp.Schemata264.ReplaceBinExprOp_0(12L, two, CoverageLabel.PartiallyCovered)), () => MutateCSharp.Schemata264.ReplaceBinExprOp_2(19L, one, two)))
            {
                return CoverageLabel.PartiallyCovered;
            }
            return one;
        }

        public static string ToString(CoverageLabel label)
        {
            return label switch
            {
                CoverageLabel.FullyCovered => MutateCSharp.Schemata264.ReplaceStringConstant_3(26L, "fully covered"),
                CoverageLabel.NotCovered => MutateCSharp.Schemata264.ReplaceStringConstant_3(27L, "not covered"),
                CoverageLabel.PartiallyCovered => MutateCSharp.Schemata264.ReplaceStringConstant_3(28L, "partially covered"),
                _ => ""
            };
        }

    }
}