using System;
using JetBrains.Annotations;
using Bpl = Microsoft.Boogie;
namespace MutateCSharp
{
    internal class Schemata470
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT470");
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

        internal static uint ReplaceNumericConstant_1(long mutantId, uint argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 2)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return 0; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{

    public class TestGenerationOptions
    {
        public const string TestInlineAttribute = "testInline";
        public const string TestEntryAttribute = "testEntry";
        public bool WarnDeadCode = MutateCSharp.Schemata470.ReplaceBooleanConstant_0(1L, false);
        public enum Modes { None, Block, InlinedBlock, Path };
        public Modes Mode = Modes.None;
        public uint SeqLengthLimit = MutateCSharp.Schemata470.ReplaceNumericConstant_1(2L, 0);
        [CanBeNull] public string PrintBpl = null;
        public bool ForcePrune = MutateCSharp.Schemata470.ReplaceBooleanConstant_0(5L, false);
        public string CoverageReport = null;
        public const uint DefaultTimeLimit = 20;
    }
}
