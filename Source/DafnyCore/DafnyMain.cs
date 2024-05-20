//-----------------------------------------------------------------------------
//
// Copyright (C) Microsoft Corporation.  All Rights Reserved.
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------
using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Boogie;
namespace MutateCSharp
{
    internal class Schemata269
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT269");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_6(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() && argument2();
        }

        internal static int ReplaceNumericConstant_3(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Boogie.PipelineOutcome argument1, Microsoft.Boogie.PipelineOutcome argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_1(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_7(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
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

    public class DafnyMain
    {
        public static readonly Dictionary<string, Uri> StandardLibrariesDooUriTarget = new();
        public static readonly Uri StandardLibrariesDooUri = DafnyFile.ExposeInternalUri(MutateCSharp.Schemata269.ReplaceStringConstant_0(1L, "DafnyStandardLibraries.dfy"),
          new(MutateCSharp.Schemata269.ReplaceStringConstant_0(2L, "dllresource://DafnyPipeline/DafnyStandardLibraries.doo")));

        static DafnyMain()
        {
            foreach (var target in new[] { MutateCSharp.Schemata269.ReplaceStringConstant_0(3L, "cs"), MutateCSharp.Schemata269.ReplaceStringConstant_0(4L, "java"), MutateCSharp.Schemata269.ReplaceStringConstant_0(5L, "go"), MutateCSharp.Schemata269.ReplaceStringConstant_0(6L, "py"), MutateCSharp.Schemata269.ReplaceStringConstant_0(7L, "js"), MutateCSharp.Schemata269.ReplaceStringConstant_0(8L, "notarget") })
            {
                StandardLibrariesDooUriTarget[target] = DafnyFile.ExposeInternalUri($"DafnyStandardLibraries-{target}.dfy",
                  new($"dllresource://DafnyPipeline/DafnyStandardLibraries-{target}.doo"));
            }
        }

        public static void MaybePrintProgram(Program program, string filename, bool afterResolver)
        {
            if (filename == null)
            {
                return;
            }

            var tw = MutateCSharp.Schemata269.ReplaceBinExprOp_1(10L, filename, MutateCSharp.Schemata269.ReplaceStringConstant_0(9L, "-")) ? program.Options.OutputWriter : new StreamWriter(filename);
            var pr = new Printer(tw, program.Options, program.Options.PrintMode);
            pr.PrintProgramLargeStack(program, afterResolver);
            if (MutateCSharp.Schemata269.ReplaceBinExprOp_2(12L, filename, MutateCSharp.Schemata269.ReplaceStringConstant_0(11L, "-")))
            {
                tw.Dispose();
            }
        }

        /// <summary>
        /// Returns null on success, or an error string otherwise.
        /// </summary>
        public static async Task<(Program Program, string Error)> ParseCheck(TextReader stdIn,
            IReadOnlyList<DafnyFile /*!*/> /*!*/ files, string /*!*/ programName,
            DafnyOptions options)
        //modifies Bpl.options.XmlSink.*;
        {
            var (program, err) = await Parse(files, programName, options);
            if (err != null)
            {
                return (program, err);
            }

            return (program, Resolve(program));
        }

        public static async Task<(Program Program, string Error)> Parse(IReadOnlyList<DafnyFile> files,
          string programName, DafnyOptions options)
        {
            Contract.Requires(programName != null);
            Contract.Requires(files != null);

            ErrorReporter reporter = options.DiagnosticsFormat switch
            {
                DafnyOptions.DiagnosticsFormats.PlainText => new ConsoleErrorReporter(options),
                DafnyOptions.DiagnosticsFormats.JSON => new JsonConsoleErrorReporter(options),
                _ => throw new ArgumentOutOfRangeException()
            };

            var program = await new ProgramParser().ParseFiles(programName, files, reporter, CancellationToken.None);
            var errorCount = program.Reporter.ErrorCount;
            if (MutateCSharp.Schemata269.ReplaceBinExprOp_4(17L, errorCount, MutateCSharp.Schemata269.ReplaceNumericConstant_3(13L, 0)))
            {
                return (program, $"{errorCount} parse errors detected in {program.Name}");
            }
            return (program, null);
        }

        public static readonly CustomStackSizePoolTaskScheduler LargeThreadScheduler =
          CustomStackSizePoolTaskScheduler.Create(MutateCSharp.Schemata269.ReplaceNumericConstant_3(22L, 0x10000000), Environment.ProcessorCount);

        public static readonly TaskFactory LargeStackFactory = new(CancellationToken.None,
          TaskCreationOptions.DenyChildAttach, TaskContinuationOptions.None, LargeThreadScheduler);

        public static string Resolve(Program program)
        {
            if (MutateCSharp.Schemata269.ReplaceBinExprOp_5(26L, () => program.Options.NoResolve, () => program.Options.NoTypecheck))
            {
                return null;
            }

            if (MutateCSharp.Schemata269.ReplaceBinExprOp_6(32L, () => program.Options.Get(CommonOptionBag.GeneralNewtypes), () => !program.Options.Get(CommonOptionBag.TypeSystemRefresh)))
            {
                return MutateCSharp.Schemata269.ReplaceStringConstant_0(38L, "use of --general-newtypes requires --type-system-refresh");
            }

            var programResolver = new ProgramResolver(program);
#pragma warning disable VSTHRD002
            LargeStackFactory.StartNew(() => programResolver.Resolve(CancellationToken.None)).Wait();
#pragma warning restore VSTHRD002
            MaybePrintProgram(program, program.Options.DafnyPrintResolvedFile, MutateCSharp.Schemata269.ReplaceBooleanConstant_7(39L, true));

            var errorCount = program.Reporter.CountExceptVerifierAndCompiler(ErrorLevel.Error);
            if (MutateCSharp.Schemata269.ReplaceBinExprOp_4(44L, errorCount, MutateCSharp.Schemata269.ReplaceNumericConstant_3(40L, 0)))
            {
                return $"{errorCount} resolution/type errors detected in {program.Name}";
            }

            return null; // success
        }

        public static async Task<(PipelineOutcome Outcome, PipelineStatistics Statistics)> BoogieOnce(
          ErrorReporter errorReporter, DafnyOptions options,
          TextWriter output,
          ExecutionEngine engine,
          string baseFile,
          string moduleName,
          Boogie.Program boogieProgram, string programId)
        {
            var moduleId = (programId ?? MutateCSharp.Schemata269.ReplaceStringConstant_0(49L, "main_program_id")) + MutateCSharp.Schemata269.ReplaceStringConstant_0(50L, "_") + moduleName;

            string bplFilename;
            if (options.PrintFile != null)
            {
                bplFilename = options.PrintFile;
            }
            else
            {
                string baseName = cce.NonNull(Path.GetFileName(baseFile));
                baseName = cce.NonNull(Path.ChangeExtension(baseName, MutateCSharp.Schemata269.ReplaceStringConstant_0(51L, "bpl")));
                bplFilename = Path.Combine(Path.GetTempPath(), baseName);
            }

            bplFilename = BoogieProgramSuffix(bplFilename, moduleName);
            var (outcome, stats) = await BoogiePipelineWithRerun(options,
              output, engine, boogieProgram, bplFilename,
      MutateCSharp.Schemata269.ReplaceBinExprOp_8(56L, MutateCSharp.Schemata269.ReplaceNumericConstant_3(52L, 1), options.VerifySnapshots) ? moduleId : null);
            return (outcome, stats);
        }

        public static string BoogieProgramSuffix(string printFile, string suffix)
        {
            var baseName = Path.GetFileNameWithoutExtension(printFile);
            var dirName = Path.GetDirectoryName(printFile);

            return Path.Combine(dirName, baseName + MutateCSharp.Schemata269.ReplaceStringConstant_0(61L, "_") + suffix + Path.GetExtension(printFile));
        }

        public static bool IsBoogieVerified(PipelineOutcome outcome, PipelineStatistics statistics)
        {
            return MutateCSharp.Schemata269.ReplaceBinExprOp_6(139L, () => MutateCSharp.Schemata269.ReplaceBinExprOp_6(124L, () => MutateCSharp.Schemata269.ReplaceBinExprOp_6(109L, () => MutateCSharp.Schemata269.ReplaceBinExprOp_6(94L, () => MutateCSharp.Schemata269.ReplaceBinExprOp_6(79L, () => (MutateCSharp.Schemata269.ReplaceBinExprOp_5(64L, () => MutateCSharp.Schemata269.ReplaceBinExprOp_9(62L, outcome, PipelineOutcome.Done), () => MutateCSharp.Schemata269.ReplaceBinExprOp_9(63L, outcome, PipelineOutcome.VerificationCompleted)))
      , () => MutateCSharp.Schemata269.ReplaceBinExprOp_10(74L, statistics.ErrorCount, MutateCSharp.Schemata269.ReplaceNumericConstant_3(70L, 0
      ))), () => MutateCSharp.Schemata269.ReplaceBinExprOp_10(89L, statistics.InconclusiveCount, MutateCSharp.Schemata269.ReplaceNumericConstant_3(85L, 0
      ))), () => MutateCSharp.Schemata269.ReplaceBinExprOp_10(104L, statistics.TimeoutCount, MutateCSharp.Schemata269.ReplaceNumericConstant_3(100L, 0
      ))), () => MutateCSharp.Schemata269.ReplaceBinExprOp_10(119L, statistics.OutOfResourceCount, MutateCSharp.Schemata269.ReplaceNumericConstant_3(115L, 0
      ))), () => MutateCSharp.Schemata269.ReplaceBinExprOp_10(134L, statistics.OutOfMemoryCount, MutateCSharp.Schemata269.ReplaceNumericConstant_3(130L, 0)));
        }

        /// <summary>
        /// Resolve, type check, infer invariants for, and verify the given Boogie program.
        /// The intention is that this Boogie program has been produced by translation from something
        /// else.  Hence, any resolution errors and type checking errors are due to errors in
        /// the translation.
        /// The method prints errors for resolution and type checking errors, but still returns
        /// their error code.
        /// </summary>
        private static async Task<(PipelineOutcome Outcome, PipelineStatistics Statistics)> BoogiePipelineWithRerun(
          DafnyOptions options,
          TextWriter output, ExecutionEngine engine, Microsoft.Boogie.Program /*!*/ program, string /*!*/ bplFileName,
          string programId)
        {
            Contract.Requires(program != null);
            Contract.Requires(bplFileName != null);

            var stats = new PipelineStatistics();
            var outcome = engine.ResolveAndTypecheck(program, bplFileName, out _);
            switch (outcome)
            {
                case PipelineOutcome.Done:
                    return (outcome, stats);
                    break;
                case PipelineOutcome.ResolutionError:
                case PipelineOutcome.TypeCheckingError:
                    engine.PrintBplFile(bplFileName, program, false, false, options.PrettyPrint);
                    await options.OutputWriter.WriteLineAsync();
                    await options.OutputWriter.WriteLineAsync(
                      "*** Encountered internal translation error - re-running Boogie to get better debug information");
                    await options.OutputWriter.WriteLineAsync();

                    var /*!*/
                      fileNames = new List<string /*!*/> { bplFileName };
                    var reparsedProgram = engine.ParseBoogieProgram(fileNames, true);
                    if (reparsedProgram != null)
                    {
                        engine.ResolveAndTypecheck(reparsedProgram, bplFileName, out _);
                    }

                    return (outcome, stats);
                    break;
                case PipelineOutcome.ResolvedAndTypeChecked:
                    engine.EliminateDeadVariables(program);
                    engine.CollectModSets(program);
                    engine.CoalesceBlocks(program);
                    engine.Inline(program);
                    var inferAndVerifyOutcome = await engine.InferAndVerify(output, program, stats, programId);
                    return (inferAndVerifyOutcome, stats);
                    break;
                default:
                    Contract.Assert(false);
                    throw new cce.UnreachableException(); // unexpected outcome
                    break;
            }

            return default;
        }
    }
}
