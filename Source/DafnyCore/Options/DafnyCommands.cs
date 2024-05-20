using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using DafnyCore;
using Microsoft.Dafny.Plugins;
namespace MutateCSharp
{
    internal class Schemata326
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT326");
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
    public static class DafnyCommands
    {

        public static Argument<FileInfo> FileArgument { get; }
        public static Argument<List<FileInfo>> FilesArgument { get; }

        static DafnyCommands()
        {

            FileArgument = new Argument<FileInfo>(MutateCSharp.Schemata326.ReplaceStringConstant_0(1L, "file"), MutateCSharp.Schemata326.ReplaceStringConstant_0(2L, "Dafny input file or Dafny project file"));
            FilesArgument = new(MutateCSharp.Schemata326.ReplaceStringConstant_0(3L, "file"), r =>
            {
                return r.Tokens.Where(t => !string.IsNullOrEmpty(t.Value)).Select(t => new FileInfo(t.Value)).ToList();
            }, MutateCSharp.Schemata326.ReplaceBooleanConstant_1(4L, false), MutateCSharp.Schemata326.ReplaceStringConstant_0(5L, "Dafny input files and/or a Dafny project file"));
        }

        public static readonly IReadOnlyList<Option> VerificationOptions = new Option[] {
    CommonOptionBag.ProgressOption,
    CommonOptionBag.RelaxDefiniteAssignment,
    BoogieOptionBag.VerificationTimeLimit,
    CommonOptionBag.VerifyIncludedFiles,
    CommonOptionBag.ManualLemmaInduction,
    BoogieOptionBag.SolverPath,
    CommonOptionBag.DisableNonLinearArithmetic,
    BoogieOptionBag.IsolateAssertions,
    BoogieOptionBag.BoogieArguments,
    CommonOptionBag.VerificationLogFormat,
    BoogieOptionBag.SolverResourceLimit,
    BoogieOptionBag.SolverOption,
    BoogieOptionBag.SolverOptionHelp,
    BoogieOptionBag.SolverPlugin,
    BoogieOptionBag.SolverLog,
    CommonOptionBag.JsonDiagnostics,
    BoogieOptionBag.VerificationErrorLimit,
    CommonOptionBag.DefaultFunctionOpacity,
    CommonOptionBag.WarnContradictoryAssumptions,
    CommonOptionBag.WarnRedundantAssumptions,
    CommonOptionBag.NoTimeStampForCoverageReport,
    CommonOptionBag.VerificationCoverageReport,
    CommonOptionBag.ExtractCounterexample,
    CommonOptionBag.ManualTriggerOption,
    CommonOptionBag.ShowProofObligationExpressions
  }.ToList();

        public static readonly IReadOnlyList<Option> TranslationOptions = new Option[] {
    BoogieOptionBag.NoVerify,
    BoogieOptionBag.HiddenNoVerify,
    CommonOptionBag.EnforceDeterminism,
    CommonOptionBag.OptimizeErasableDatatypeWrapper,
    CommonOptionBag.TestAssumptions,
    DeveloperOptionBag.Bootstrapping,
    CommonOptionBag.AddCompileSuffix,
    CommonOptionBag.SystemModule,
    IExecutableBackend.TranslationRecords,
  }.Concat(VerificationOptions).ToList();

        public static readonly IReadOnlyList<Option> ExecutionOptions = new Option[] {
    CommonOptionBag.Target,
    CommonOptionBag.SpillTranslation,
    CommonOptionBag.InternalIncludeRuntimeOptionForExecution,
    CommonOptionBag.ExecutionCoverageReport
  }.Concat(TranslationOptions).ToList();

        public static readonly IReadOnlyList<Option> ConsoleOutputOptions = new List<Option>(new Option[] {
    Snippets.ShowSnippets,
    DeveloperOptionBag.PrintOption,
    DeveloperOptionBag.ResolvedPrint,
    DeveloperOptionBag.BoogiePrint,
    Printer.PrintMode,
    CommonOptionBag.AllowWarnings,
    CommonOptionBag.WarnAsErrors
  });

        public static readonly IReadOnlyList<Option> ParserOptions = new List<Option>(new Option[] {
    CommonOptionBag.StdIn,
    CommonOptionBag.Verbose,
    BoogieOptionBag.Cores,
    CommonOptionBag.Libraries,
    CommonOptionBag.AllowDeprecation,
    CommonOptionBag.PluginOption,
    CommonOptionBag.Prelude,
    Function.FunctionSyntaxOption,
    CommonOptionBag.QuantifierSyntax,
    CommonOptionBag.UnicodeCharacters,
    CommonOptionBag.UseBaseFileName,
    CommonOptionBag.EmitUncompilableCode,
    CommonOptionBag.GeneralTraits,
    CommonOptionBag.GeneralNewtypes,
    CommonOptionBag.TypeSystemRefresh,
    CommonOptionBag.TypeInferenceDebug,
    CommonOptionBag.NewTypeInferenceDebug,
    Method.ReadsClausesOnMethods,
    CommonOptionBag.UseStandardLibraries,
    CommonOptionBag.LogLevelOption,
    CommonOptionBag.LogLocation
  });

        public static IReadOnlyList<Option> ResolverOptions = new List<Option>(new Option[] {
    CommonOptionBag.ShowHints,
    CommonOptionBag.WarnShadowing,
    CommonOptionBag.WarnMissingConstructorParenthesis,
    PrintStmt.TrackPrintEffectsOption,
    CommonOptionBag.AllowAxioms,
    MethodOrFunction.AllowExternalContracts
  }).Concat(ParserOptions).ToList();
    }
}