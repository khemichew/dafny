using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DafnyCore;
using Microsoft.Boogie;
using VC;
namespace MutateCSharp
{
    internal class Schemata267
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT267");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, System.IO.TextWriter argument1, System.IO.TextWriter argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Boogie.CoreOptions.VerbosityLevel argument1, Microsoft.Boogie.CoreOptions.VerbosityLevel argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_2(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBooleanConstant_3(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public class DafnyConsolePrinter : ConsolePrinter
    {
        public new DafnyOptions Options
        {
            get => options;
            set
            {
                base.Options = value;
                options = value;
            }
        }

        private DafnyOptions options;

        public record ImplementationLogEntry(string Name, Boogie.IToken Tok);
        public record VCResultLogEntry(
          int VCNum,
          DateTime StartTime,
          TimeSpan RunTime,
          SolverOutcome Outcome,
          List<(Boogie.IToken Tok, string Description)> Asserts,
          IEnumerable<TrackedNodeComponent> CoveredElements,
          int ResourceCount);
        public record VerificationResultLogEntry(
          VcOutcome Outcome,
          TimeSpan RunTime,
          int ResourceCount,
          List<VCResultLogEntry> VCResults,
          List<Counterexample> Counterexamples);
        public record ConsoleLogEntry(ImplementationLogEntry Implementation, VerificationResultLogEntry Result);

        public static VerificationResultLogEntry DistillVerificationResult(ImplementationRunResult verificationResult)
        {
            return new VerificationResultLogEntry(
              verificationResult.VcOutcome, verificationResult.End - verificationResult.Start,
              verificationResult.ResourceCount, verificationResult.RunResults.Select(DistillVCResult).ToList(), verificationResult.Errors);
        }

        private static VCResultLogEntry DistillVCResult(VerificationRunResult r)
        {
            return new VCResultLogEntry(r.VcNum, r.StartTime, r.RunTime, r.Outcome,
                r.Asserts.Select(a => (a.tok, a.Description.SuccessDescription)).ToList(), r.CoveredElements,
                r.ResourceCount);
        }

        public ConcurrentBag<ConsoleLogEntry> VerificationResults { get; } = new();

        public override void AdvisoryWriteLine(TextWriter output, string format, params object[] args)
        {
            if (MutateCSharp.Schemata267.ReplaceBinExprOp_0(1L, output, Console.Out))
            {
                int foregroundColor = (int)Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                output.WriteLine(format, args);
                Console.ForegroundColor = (ConsoleColor)foregroundColor;
            }
            else
            {
                output.WriteLine(format, args);
            }
        }



        public DafnyConsolePrinter(DafnyOptions options)
        {
            Options = options;
        }

        public override void ReportBplError(Boogie.IToken tok, string message, bool error, TextWriter tw, string category = null)
        {

            if (MutateCSharp.Schemata267.ReplaceBinExprOp_1(2L, Options.Verbosity, CoreOptions.VerbosityLevel.Silent))
            {
                return;
            }

            if (category != null)
            {
                message = $"{category}: {message}";
            }

            var dafnyToken = BoogieGenerator.ToDafnyToken(options.Get(Snippets.ShowSnippets), tok);
            message = $"{dafnyToken.TokenToString(Options)}: {message}";

            if (error)
            {
                ErrorWriteLine(tw, message);
            }
            else
            {
                tw.WriteLine(message);
            }

            if (Options.Get(Snippets.ShowSnippets))
            {
                if (tok is IToken dafnyTok)
                {
                    Snippets.WriteSourceCodeSnippet(Options, dafnyTok, tw);
                }
                else
                {
                    ErrorWriteLine(tw, MutateCSharp.Schemata267.ReplaceStringConstant_2(3L, "No Dafny location information, so snippet can't be generated."));
                }
            }

            if (tok is NestedToken nestedToken)
            {
                ReportBplError(nestedToken.Inner, MutateCSharp.Schemata267.ReplaceStringConstant_2(4L, "Related location"), MutateCSharp.Schemata267.ReplaceBooleanConstant_3(5L, false), tw);
            }
        }

        public override void ReportEndVerifyImplementation(Implementation implementation, ImplementationRunResult result)
        {
            var impl = new ImplementationLogEntry(implementation.VerboseName, implementation.tok);
            VerificationResults.Add(new ConsoleLogEntry(impl, DistillVerificationResult(result)));
        }
    }
}