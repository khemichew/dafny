using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MutateCSharp
{
    internal class Schemata237
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT237");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
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

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
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

        internal static bool ReplaceBinExprOp_2(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

    }
}

namespace Microsoft.Dafny.Compilers
{
    public class JavaScriptBackend : ExecutableBackend
    {
        public override IReadOnlySet<string> SupportedExtensions => new HashSet<string> { MutateCSharp.Schemata237.ReplaceStringConstant_0(1L, ".js") };

        public override string TargetName => MutateCSharp.Schemata237.ReplaceStringConstant_0(2L, "JavaScript");
        public override bool IsStable => MutateCSharp.Schemata237.ReplaceBooleanConstant_1(3L, true);
        public override string TargetExtension => MutateCSharp.Schemata237.ReplaceStringConstant_0(4L, "js");

        public override bool SupportsInMemoryCompilation => MutateCSharp.Schemata237.ReplaceBooleanConstant_1(5L, true);
        public override bool TextualTargetIsExecutable => MutateCSharp.Schemata237.ReplaceBooleanConstant_1(6L, true);

        public override IReadOnlySet<string> SupportedNativeTypes =>
          new HashSet<string>(new List<string> { MutateCSharp.Schemata237.ReplaceStringConstant_0(7L, "number") });

        protected override SinglePassCodeGenerator CreateCodeGenerator()
        {
            return new JavaScriptCodeGenerator(Options, Reporter);
        }

        public override async Task<(bool Success, object CompilationResult)> CompileTargetProgram(string dafnyProgramName,
          string targetProgramText,
          string callToMain /*?*/, string targetFilename /*?*/, ReadOnlyCollection<string> otherFileNames,
          bool runAfterCompile, TextWriter outputWriter)
        {
            if (runAfterCompile)
            {
                Contract.Assert(callToMain != null);  // this is part of the contract of CompileTargetProgram
                                                      // Since the program is to be run soon, nothing further is done here. Any compilation errors (that is, any errors
                                                      // in the emitted program--this should never happen if the compiler itself is correct) will be reported as 'node'
                                                      // will run the program.
                return (MutateCSharp.Schemata237.ReplaceBooleanConstant_1(8L, true), null);
            }
            else
            {
                // compile now
                return (await SendToNewNodeProcess(dafnyProgramName, targetProgramText, null, targetFilename, otherFileNames, outputWriter), null);
            }

            return default;
        }

        public override Task<bool> RunTargetProgram(string dafnyProgramName, string targetProgramText,
          string callToMain, /*?*/
          string targetFilename, ReadOnlyCollection<string> otherFileNames,
          object compilationResult, TextWriter outputWriter, TextWriter errorWriter)
        {

            return SendToNewNodeProcess(dafnyProgramName, targetProgramText, callToMain, targetFilename, otherFileNames, outputWriter);
        }

        async Task<bool> SendToNewNodeProcess(string dafnyProgramName, string targetProgramText, string/*?*/ callToMain, string targetFilename, ReadOnlyCollection<string> otherFileNames,
          TextWriter outputWriter)
        {
            Contract.Requires(targetFilename != null || otherFileNames.Count == 0);

            var psi = new ProcessStartInfo(MutateCSharp.Schemata237.ReplaceStringConstant_0(9L, "node"), "")
            {
                RedirectStandardInput = MutateCSharp.Schemata237.ReplaceBooleanConstant_1(10L, true),
                RedirectStandardOutput = MutateCSharp.Schemata237.ReplaceBooleanConstant_1(11L, true),
                RedirectStandardError = MutateCSharp.Schemata237.ReplaceBooleanConstant_1(12L, true),
                StandardInputEncoding = Encoding.UTF8,
            };

            try
            {
                Process nodeProcess = Process.Start(psi);
                foreach (var filename in otherFileNames)
                {
                    WriteFromFile(filename, nodeProcess.StandardInput);
                }
                await nodeProcess.StandardInput.WriteAsync(targetProgramText);
                if (MutateCSharp.Schemata237.ReplaceBinExprOp_2(13L, () => callToMain != null, () => Options.RunAfterCompile))
                {
                    await nodeProcess.StandardInput.WriteLineAsync(MutateCSharp.Schemata237.ReplaceStringConstant_0(19L, "require('process').stdout.setEncoding(\"utf-8\");"));
                    await nodeProcess.StandardInput.WriteLineAsync(MutateCSharp.Schemata237.ReplaceStringConstant_0(20L, "require('process').argv = [\"node\",\"stdin\", ") + string.Join(MutateCSharp.Schemata237.ReplaceStringConstant_0(21L, ","), Options.MainArgs.Select(((JavaScriptCodeGenerator)codeGenerator).ToStringLiteral)) + MutateCSharp.Schemata237.ReplaceStringConstant_0(22L, "];"));
                    await nodeProcess.StandardInput.WriteAsync(callToMain);
                }
                await nodeProcess.StandardInput.FlushAsync();
                nodeProcess.StandardInput.Close();
                // Fixes a problem of Node on Windows, where Node does not prints to the parent console its standard outputs.
                await PassthroughBuffer(nodeProcess.StandardError, Options.ErrorWriter);
                await PassthroughBuffer(nodeProcess.StandardOutput, Options.OutputWriter);
                await nodeProcess.WaitForExitAsync();
#pragma warning disable VSTHRD00
                return MutateCSharp.Schemata237.ReplaceBinExprOp_4(27L, nodeProcess.ExitCode, MutateCSharp.Schemata237.ReplaceNumericConstant_3(23L, 0));
            }
            catch (System.ComponentModel.Win32Exception e)
            {
                await outputWriter.WriteLineAsync($"Error: Unable to start node.js ({psi.FileName}): {e.Message}");
                return MutateCSharp.Schemata237.ReplaceBooleanConstant_1(32L, false);
            }

            return default;
        }

        public JavaScriptBackend(DafnyOptions options) : base(options)
        {
        }
    }
}
