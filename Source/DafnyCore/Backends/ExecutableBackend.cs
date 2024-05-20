using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DafnyCore.Options;
using Microsoft.Dafny.Compilers;
using Microsoft.Dafny.Plugins;
namespace MutateCSharp
{
    internal class Schemata228
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT228");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplacePostfixUnaryExprOp_13(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_5(long mutantId, bool argument1)
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

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.Compilers.SinglePassCodeGenerator argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceBinExprOp_11(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 - argument2;
        }

        internal static int ReplaceNumericConstant_8(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, System.Text.Encoding argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.ModuleKindEnum argument1, Microsoft.Dafny.ModuleKindEnum argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, System.Collections.Generic.IList<System.IO.FileInfo> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public abstract class ExecutableBackend : IExecutableBackend
    {
        // May be null for backends that don't use the single-pass compiler logic
        protected SinglePassCodeGenerator codeGenerator;

        protected ExecutableBackend(DafnyOptions options) : base(options)
        {
        }

        public override IReadOnlySet<Feature> UnsupportedFeatures => CreateCodeGenerator().UnsupportedFeatures;

        public override bool SupportsDatatypeWrapperErasure =>
          CreateCodeGenerator()?.SupportsDatatypeWrapperErasure ?? base.SupportsDatatypeWrapperErasure;

        public override string ModuleSeparator => CodeGenerator.ModuleSeparator;

        public override void Compile(Program dafnyProgram, string dafnyProgramName, ConcreteSyntaxTree output)
        {
            ProcessTranslationRecords(dafnyProgram, dafnyProgramName, output);
            CheckInstantiationReplaceableModules(dafnyProgram);
            ProcessOuterModules(dafnyProgram);

            CodeGenerator.Compile(dafnyProgram, output);
        }

        protected void ProcessTranslationRecords(Program dafnyProgram, string dafnyProgramName, ConcreteSyntaxTree output)
        {
            // Process --translation-record options, since translation may need that data to translate correctly.
            dafnyProgram.Compilation.AlreadyTranslatedRecord = TranslationRecord.Empty(dafnyProgram);
            var records = dafnyProgram.Options.Get(TranslationRecords);
            if (MutateCSharp.Schemata228.ReplaceBinExprOp_0(1L, records, null))
            {
                foreach (var path in records)
                {
                    TranslationRecord.ReadValidateAndMerge(dafnyProgram, path.FullName, Token.Cli);
                }
            }

            // Write out the translation record for THIS translation before compiling,
            // in case the compilation process mutates the program.
            var translationRecord = new TranslationRecord(dafnyProgram);
            var baseName = Path.GetFileNameWithoutExtension(dafnyProgramName);
            var dtrFilePath = dafnyProgram.Options.Get(TranslationRecordOutput)?.FullName ?? $"{baseName}-{TargetId}.dtr";
            var dtrWriter = output.NewFile(dtrFilePath);
            translationRecord.Write(dtrWriter);
        }

        protected void CheckInstantiationReplaceableModules(Program dafnyProgram)
        {
            foreach (var compiledModule in dafnyProgram.Modules())
            {
                if (compiledModule.Implements is { Kind: ImplementationKind.Replacement })
                {
                    if (compiledModule.IsExtern(Options, out _, out var name) && name != null)
                    {
                        Reporter!.Error(MessageSource.Compiler, compiledModule.Tok,
              MutateCSharp.Schemata228.ReplaceStringConstant_1(2L, "inside a module that replaces another, {:extern} attributes may only be used without arguments"));
                    }
                }

                if (MutateCSharp.Schemata228.ReplaceBinExprOp_4(5L, () => MutateCSharp.Schemata228.ReplaceBinExprOp_2(3L, compiledModule.ModuleKind, ModuleKindEnum.Replaceable), () => MutateCSharp.Schemata228.ReplaceBinExprOp_3(4L, dafnyProgram.Replacements.GetValueOrDefault(compiledModule), null)))
                {
                    if (compiledModule.ShouldCompile(dafnyProgram.Compilation))
                    {
                        Reporter!.Error(MessageSource.Compiler, compiledModule.Tok,
                          $"when producing executable code, replaceable modules must be replaced somewhere in the program. For example, `module {compiledModule.Name}Impl replaces {compiledModule.Name} {{ ... }}`");
                    }
                }
            }
        }

        protected void ProcessOuterModules(Program dafnyProgram)
        {
            // Apply the --outer-module option from any translation records for libraries,
            // but only to top-level modules.
            var outerModules = new Dictionary<string, ModuleDefinition>();
            foreach (var module in dafnyProgram.CompileModules)
            {
                if (module.EnclosingModule is not DefaultModuleDefinition)
                {
                    continue;
                }

                var recordedOuterModuleName = (string)dafnyProgram.Compilation.AlreadyTranslatedRecord.Get(null, module.FullDafnyName, OuterModule);
                if (recordedOuterModuleName == null)
                {
                    continue;
                }

                var outerModule = outerModules.GetOrCreate(recordedOuterModuleName, () => CreateOuterModule(recordedOuterModuleName));
                module.EnclosingModule = outerModule;
            }

            // Apply the local --output-module option if there is one
            var outerModuleName = Options.Get(OuterModule);
            if (outerModuleName != null)
            {
                var rootUserModule = outerModules.GetOrCreate(outerModuleName, () => CreateOuterModule(outerModuleName));
                dafnyProgram.DefaultModuleDef.NameNode = rootUserModule.NameNode;
                dafnyProgram.DefaultModuleDef.EnclosingModule = rootUserModule.EnclosingModule;
            }

            foreach (var module in dafnyProgram.CompileModules)
            {
                module.ClearNameCache();
            }
        }

        private static ModuleDefinition CreateOuterModule(string moduleName)
        {
            var outerModules = moduleName.Split(MutateCSharp.Schemata228.ReplaceStringConstant_1(11L, "."));

            ModuleDefinition module = null;
            foreach (var outerModule in outerModules)
            {
                var thisModule = new ModuleDefinition(RangeToken.NoToken, new Name(outerModule), new List<IToken>(),
                  ModuleKindEnum.Concrete, MutateCSharp.Schemata228.ReplaceBooleanConstant_5(12L, false),
                  null, null, null)
                {
                    EnclosingModule = module
                };
                module = thisModule;
            }

            return module;
        }

        public override void OnPreCompile(ErrorReporter reporter, ReadOnlyCollection<string> otherFileNames)
        {
            base.OnPreCompile(reporter, otherFileNames);
            codeGenerator = CreateCodeGenerator();
        }

        SinglePassCodeGenerator CodeGenerator
        {
            get
            {
                if (MutateCSharp.Schemata228.ReplaceBinExprOp_6(13L, codeGenerator, null))
                {
                    codeGenerator = CreateCodeGenerator();
                }

                return codeGenerator;
            }
        }

        public override Task<bool> OnPostGenerate(string dafnyProgramName, string targetDirectory, TextWriter outputWriter)
        {
            CodeGenerator.Coverage.WriteLegendFile();
            return Task.FromResult(MutateCSharp.Schemata228.ReplaceBooleanConstant_5(14L, true));
        }

        protected abstract SinglePassCodeGenerator CreateCodeGenerator();

        public override string PublicIdProtect(string name)
        {
            return CodeGenerator.PublicIdProtect(name);
        }

        public override void EmitCallToMain(Method mainMethod, string baseName, ConcreteSyntaxTree callToMainTree)
        {
            CodeGenerator.EmitCallToMain(mainMethod, baseName, callToMainTree);
        }

        public ProcessStartInfo PrepareProcessStartInfo(string programName, IEnumerable<string> args = null)
        {
            var psi = new ProcessStartInfo(programName)
            {
                UseShellExecute = MutateCSharp.Schemata228.ReplaceBooleanConstant_5(15L, false),
                CreateNoWindow = MutateCSharp.Schemata228.ReplaceBooleanConstant_5(16L, false), // https://github.com/dotnet/runtime/issues/68259
                RedirectStandardOutput = MutateCSharp.Schemata228.ReplaceBooleanConstant_5(17L, true),
            };
            foreach (var arg in args ?? Enumerable.Empty<string>())
            {
                psi.ArgumentList.Add(arg);
            }
            return psi;
        }

        public Task<int> RunProcess(ProcessStartInfo psi,
          TextWriter outputWriter,
          TextWriter errorWriter,
          string errorMessage = null)
        {
            if (MutateCSharp.Schemata228.ReplaceBinExprOp_7(18L, OutputWriterEncoding, null))
            {
                psi.StandardOutputEncoding = OutputWriterEncoding;
            }

            return StartProcess(psi, outputWriter) is { } process ?
              WaitForExit(process, outputWriter, errorWriter, errorMessage) : Task.FromResult(MutateCSharp.Schemata228.ReplaceNumericConstant_8(19L, -1));
        }

        public virtual Encoding OutputWriterEncoding => null;

        public async Task<int> WaitForExit(Process process, TextWriter outputWriter, TextWriter errorWriter, string errorMessage = null)
        {

            await PassthroughBuffer(process.StandardError, errorWriter);
            await PassthroughBuffer(process.StandardOutput, outputWriter);
            await process.WaitForExitAsync();
            if (MutateCSharp.Schemata228.ReplaceBinExprOp_4(32L, () => MutateCSharp.Schemata228.ReplaceBinExprOp_9(27L, process.ExitCode, MutateCSharp.Schemata228.ReplaceNumericConstant_8(23L, 0)), () => errorMessage != null))
            {
                await outputWriter.WriteLineAsync($"{errorMessage} Process exited with exit code {process.ExitCode}");
            }

            return process.ExitCode;
        }


        protected static async Task PassthroughBuffer(TextReader input, TextWriter output)
        {
            char[] buffer = new char[MutateCSharp.Schemata228.ReplaceNumericConstant_8(38L, 256)];
            int readCount;
            while (MutateCSharp.Schemata228.ReplaceBinExprOp_10(46L, (readCount = await input.ReadBlockAsync(buffer)), MutateCSharp.Schemata228.ReplaceNumericConstant_8(42L, 0)))
            {
                await output.WriteAsync(buffer, MutateCSharp.Schemata228.ReplaceNumericConstant_8(51L, 0), readCount);
            }
        }

        public Process StartProcess(ProcessStartInfo psi, TextWriter outputWriter)
        {
            string additionalInfo = "";

            try
            {
                psi.RedirectStandardError = MutateCSharp.Schemata228.ReplaceBooleanConstant_5(55L, true);
                if (Process.Start(psi) is { } process)
                {
                    return process;
                }
            }
            catch (System.ComponentModel.Win32Exception e)
            {
                additionalInfo = $": {e.Message}";
            }

            outputWriter.WriteLine($"Error: Unable to start {psi.FileName}{additionalInfo}");
            return null;
        }

        public override Task<(bool Success, object CompilationResult)> CompileTargetProgram(string dafnyProgramName,
          string targetProgramText,
          string callToMain /*?*/, string targetFilename, /*?*/
          ReadOnlyCollection<string> otherFileNames,
          bool runAfterCompile, TextWriter outputWriter)
        {
            Contract.Requires(dafnyProgramName != null);
            Contract.Requires(targetProgramText != null);
            Contract.Requires(otherFileNames != null);
            Contract.Requires(otherFileNames.Count == 0 || targetFilename != null);
            Contract.Requires(this.SupportsInMemoryCompilation || targetFilename != null);
            Contract.Requires(!runAfterCompile || callToMain != null);
            Contract.Requires(outputWriter != null);

            return Task.FromResult((MutateCSharp.Schemata228.ReplaceBooleanConstant_5(56L, true), (object)null));
        }

        public override Task<bool> RunTargetProgram(string dafnyProgramName, string targetProgramText,
          string callToMain, /*?*/
          string targetFilename /*?*/, ReadOnlyCollection<string> otherFileNames,
          object compilationResult, TextWriter outputWriter, TextWriter errorWriter)
        {
            Contract.Requires(dafnyProgramName != null);
            Contract.Requires(targetProgramText != null);
            Contract.Requires(otherFileNames != null);
            Contract.Requires(otherFileNames.Count == 0 || targetFilename != null);
            Contract.Requires(outputWriter != null);
            return Task.FromResult(MutateCSharp.Schemata228.ReplaceBooleanConstant_5(57L, true));
        }

        public override void InstrumentCompiler(CompilerInstrumenter instrumenter, Program dafnyProgram)
        {
            if (MutateCSharp.Schemata228.ReplaceBinExprOp_6(58L, CodeGenerator, null))
            {
                return;
            }

            instrumenter.Instrument(this, CodeGenerator, dafnyProgram);
        }

        protected static void WriteFromFile(string inputFilename, TextWriter outputWriter)
        {
            var rd = new StreamReader(new FileStream(inputFilename, FileMode.Open, FileAccess.Read));
            SinglePassCodeGenerator.WriteFromStream(rd, outputWriter);
        }

        protected async Task<bool> RunTargetDafnyProgram(string targetFilename, TextWriter outputWriter, TextWriter errorWriter, bool verify)
        {

            /*
             * In order to work for the continuous integration, we need to call the Dafny compiler using dotnet
             * because dafny is not currently in the path
             */

            var where = System.Reflection.Assembly.GetExecutingAssembly().Location;
            where = Path.GetDirectoryName(where);
            var dafny = where + MutateCSharp.Schemata228.ReplaceStringConstant_1(59L, "/Dafny.dll");

            var opt = Options;
            var args = opt.MainArgs
              .Prepend(targetFilename);
            if (!verify)
            {
                args = args.Prepend(MutateCSharp.Schemata228.ReplaceStringConstant_1(60L, "--no-verify"));
            }
            args = args
              .Prepend(MutateCSharp.Schemata228.ReplaceStringConstant_1(61L, "--target:cs"))
              .Prepend(MutateCSharp.Schemata228.ReplaceStringConstant_1(62L, "run"))
              .Prepend(dafny);
            var psi = PrepareProcessStartInfo(MutateCSharp.Schemata228.ReplaceStringConstant_1(63L, "dotnet"), args);
            await Console.Out.WriteLineAsync(string.Join(MutateCSharp.Schemata228.ReplaceStringConstant_1(64L, ", "), psi.ArgumentList));
            /*
             * When this code was written, the Dafny compiler cannot be made completely silent.
             * This is a problem for this specific compiler and the integration tests because the second
             * call to the compiler makes unexpected writes to the output.
             * The following code is catching the output from the second compiler call (the one that executes the code)
             * and stripping out the first two lines and the last line.
             */

            psi.RedirectStandardOutput = MutateCSharp.Schemata228.ReplaceBooleanConstant_5(65L, true);
            var process = new Process();
            process.StartInfo = psi;
            var outputBuilder = new List<string>();
            var errorBuilder = new List<string>();
            process.OutputDataReceived += (sender, args) => outputBuilder.Add(args.Data);
            process.ErrorDataReceived += (sender, args) => errorBuilder.Add(args.Data);

            try
            {
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                await process.WaitForExitAsync();
                process.CancelOutputRead();
                process.CancelErrorRead();

                for (int i = MutateCSharp.Schemata228.ReplaceNumericConstant_8(66L, 2); MutateCSharp.Schemata228.ReplaceBinExprOp_12(83L, i, MutateCSharp.Schemata228.ReplaceBinExprOp_11(74L, outputBuilder.Count, MutateCSharp.Schemata228.ReplaceNumericConstant_8(70L, 1))); MutateCSharp.Schemata228.ReplacePostfixUnaryExprOp_13(88L, ref i))
                {
                    await outputWriter.WriteLineAsync(outputBuilder[i]);
                }

                for (int i = MutateCSharp.Schemata228.ReplaceNumericConstant_8(89L, 0); MutateCSharp.Schemata228.ReplaceBinExprOp_12(106L, i, MutateCSharp.Schemata228.ReplaceBinExprOp_11(97L, errorBuilder.Count, MutateCSharp.Schemata228.ReplaceNumericConstant_8(93L, 1))); MutateCSharp.Schemata228.ReplacePostfixUnaryExprOp_13(111L, ref i))
                {
                    await errorWriter.WriteLineAsync(errorBuilder[i]);
                }

                if (MutateCSharp.Schemata228.ReplaceBinExprOp_9(116L, process.ExitCode, MutateCSharp.Schemata228.ReplaceNumericConstant_8(112L, 0)))
                {
                    await outputWriter.WriteLineAsync($"Process exited with exit code {process.ExitCode}");
                    return MutateCSharp.Schemata228.ReplaceBooleanConstant_5(121L, false);
                }

            }
            catch (System.ComponentModel.Win32Exception e)
            {
                string additionalInfo = $": {e.Message}";
                await outputWriter.WriteLineAsync($"Error: Unable to start {psi.FileName}{additionalInfo}");
                return MutateCSharp.Schemata228.ReplaceBooleanConstant_5(122L, false);
            }

            return MutateCSharp.Schemata228.ReplaceBooleanConstant_5(123L, true);
        }
    }
}
