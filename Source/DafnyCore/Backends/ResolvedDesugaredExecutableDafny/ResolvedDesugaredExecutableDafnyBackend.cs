using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
namespace MutateCSharp
{
    internal class Schemata243
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT243");
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

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny.Compilers
{
    public class ResolvedDesugaredExecutableDafnyBackend : DafnyExecutableBackend
    {
        protected override bool CanEmitUncompilableCode => MutateCSharp.Schemata243.ReplaceBooleanConstant_0(1L, false);
        public override IReadOnlySet<string> SupportedExtensions => new HashSet<string> { MutateCSharp.Schemata243.ReplaceStringConstant_1(2L, ".dfy") };
        public override string TargetName => MutateCSharp.Schemata243.ReplaceStringConstant_1(3L, "ResolvedDesugaredExecutableDafny");
        public override bool IsStable => MutateCSharp.Schemata243.ReplaceBooleanConstant_0(4L, true);
        public override bool IsInternal => MutateCSharp.Schemata243.ReplaceBooleanConstant_0(5L, true);
        public override string TargetExtension => MutateCSharp.Schemata243.ReplaceStringConstant_1(6L, "dfy");
        public override bool SupportsInMemoryCompilation => MutateCSharp.Schemata243.ReplaceBooleanConstant_0(7L, false);
        public override bool TextualTargetIsExecutable => MutateCSharp.Schemata243.ReplaceBooleanConstant_0(8L, false);

        public override string TargetBaseDir(string dafnyProgramName) =>
          $"{Path.GetFileNameWithoutExtension(dafnyProgramName)}-ResolvedDesugaredExecutableDafny/src";

        protected override DafnyWrittenCodeGenerator CreateDafnyWrittenCompiler()
        {
            return new ResolvedDesugaredExecutableDafnyCodeGenerator();
        }

        public ResolvedDesugaredExecutableDafnyBackend(DafnyOptions options) : base(options)
        {
        }
    }
}
