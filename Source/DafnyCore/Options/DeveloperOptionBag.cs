using System.CommandLine;
using System.IO;
using DafnyCore;
namespace MutateCSharp
{
    internal class Schemata328
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT328");
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
    public class DeveloperOptionBag
    {

        public static readonly Option<string> BoogiePrint = new(MutateCSharp.Schemata328.ReplaceStringConstant_0(1L, "--bprint"),
      MutateCSharp.Schemata328.ReplaceStringConstant_0(2L, @"
Print Boogie program translated from Dafny
(use - as <file> to print to console)").TrimStart())
        {
            IsHidden = MutateCSharp.Schemata328.ReplaceBooleanConstant_1(3L, true),
            ArgumentHelpName = MutateCSharp.Schemata328.ReplaceStringConstant_0(4L, "file"),
        };

        public static readonly Option<string> PrintOption = new(MutateCSharp.Schemata328.ReplaceStringConstant_0(5L, "--print"), MutateCSharp.Schemata328.ReplaceStringConstant_0(6L, @"
Print Dafny program after parsing it.
(Use - as <file> to print to console.)").TrimStart())
        {
            IsHidden = MutateCSharp.Schemata328.ReplaceBooleanConstant_1(7L, true),
            ArgumentHelpName = MutateCSharp.Schemata328.ReplaceStringConstant_0(8L, "file"
      )
        };

        public static readonly Option<string> ResolvedPrint = new(MutateCSharp.Schemata328.ReplaceStringConstant_0(9L, "--rprint"), MutateCSharp.Schemata328.ReplaceStringConstant_0(10L, @"
Print Dafny program after resolving it.
(use - as <file> to print to console.)").TrimStart())
        {
            IsHidden = MutateCSharp.Schemata328.ReplaceBooleanConstant_1(11L, true),
            ArgumentHelpName = MutateCSharp.Schemata328.ReplaceStringConstant_0(12L, "file"),
        };

        public static readonly Option<bool> Bootstrapping = new(MutateCSharp.Schemata328.ReplaceStringConstant_0(13L, "--bootstrapping"), MutateCSharp.Schemata328.ReplaceStringConstant_0(14L, @"
(internal, may be removed in the future)
Indicates the Dafny source is part of the Dafny implementation itself,
enabling necessary special handling.").TrimStart())
        {
            IsHidden = MutateCSharp.Schemata328.ReplaceBooleanConstant_1(15L, true),
        };

        static DeveloperOptionBag()
        {
            DafnyOptions.RegisterLegacyBinding(ResolvedPrint, (options, value) =>
            {
                options.DafnyPrintResolvedFile = value;
                options.ExpandFilename(options.DafnyPrintResolvedFile, x => options.DafnyPrintResolvedFile = x, options.LogPrefix,
                  options.FileTimestamp);
            });

            DafnyOptions.RegisterLegacyBinding(PrintOption, (options, value) =>
            {
                options.DafnyPrintFile = value;
                options.ExpandFilename(options.DafnyPrintFile, x => options.DafnyPrintFile = x, options.LogPrefix,
                  options.FileTimestamp);
            });

            DafnyOptions.RegisterLegacyBinding(BoogiePrint, (options, f) =>
            {
                options.PrintFile = f;
                options.ExpandFilename(options.PrintFile, x => options.PrintFile = x, options.LogPrefix,
                  options.FileTimestamp);
            });

            DooFile.RegisterNoChecksNeeded(BoogiePrint, MutateCSharp.Schemata328.ReplaceBooleanConstant_1(16L, false));
            DooFile.RegisterNoChecksNeeded(PrintOption, MutateCSharp.Schemata328.ReplaceBooleanConstant_1(17L, false));
            DooFile.RegisterNoChecksNeeded(ResolvedPrint, MutateCSharp.Schemata328.ReplaceBooleanConstant_1(18L, false));
            DooFile.RegisterNoChecksNeeded(Bootstrapping, MutateCSharp.Schemata328.ReplaceBooleanConstant_1(19L, false));
        }
    }
}
