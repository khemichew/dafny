using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.CommandLine;
using System.Diagnostics.Contracts;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DafnyCore.Options;
using Microsoft.Dafny.Compilers;
namespace MutateCSharp
{
    internal class Schemata232
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT232");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
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

        internal static bool ReplaceBinExprOp_6(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static async System.Threading.Tasks.Task<bool> ReplaceBinExprOp_2(long mutantId, System.Func<System.Threading.Tasks.Task<bool>> argument1, System.Func<System.Threading.Tasks.Task<bool>> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return await argument1() && await argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return await argument1() || await argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return await argument1() | await argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return await argument1() & await argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return await argument1() ^ await argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return await argument1() == await argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return await argument1() != await argument2(); }
            return await argument1() && await argument2();
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

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static int ReplaceBinExprOp_7(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 + argument2;
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
    public class GoBackend : ExecutableBackend
    {

        public override IReadOnlySet<string> SupportedExtensions => new HashSet<string> { MutateCSharp.Schemata232.ReplaceStringConstant_0(1L, ".go") };

        public override string TargetName => MutateCSharp.Schemata232.ReplaceStringConstant_0(2L, "Go");
        public override bool IsStable => MutateCSharp.Schemata232.ReplaceBooleanConstant_1(3L, true);
        public override string TargetExtension => MutateCSharp.Schemata232.ReplaceStringConstant_0(4L, "go");

        public override string TargetBaseDir(string dafnyProgramName)
        {
            var topLevelDir = $"{Path.GetFileNameWithoutExtension(dafnyProgramName)}-go";
            if (GoModuleMode)
            {
                return topLevelDir;
            }

            return $"{topLevelDir}/src";
        }

        public override bool SupportsInMemoryCompilation => MutateCSharp.Schemata232.ReplaceBooleanConstant_1(5L, false);
        public override bool TextualTargetIsExecutable => MutateCSharp.Schemata232.ReplaceBooleanConstant_1(6L, false);

        public bool GoModuleMode { get; set; } = MutateCSharp.Schemata232.ReplaceBooleanConstant_1(7L, true);
        public string GoModuleName;

        public static readonly Option<string> GoModuleNameCliOption = new(MutateCSharp.Schemata232.ReplaceStringConstant_0(8L, "--go-module-name"),
      MutateCSharp.Schemata232.ReplaceStringConstant_0(9L, @"This Option is used to specify the Go Module Name for the translated code").TrimStart())
        {
        };
        public override IEnumerable<Option<string>> SupportedOptions => new List<Option<string>> { GoModuleNameCliOption };

        static GoBackend()
        {
            TranslationRecord.RegisterLibraryChecks(new Dictionary<Option, OptionCompatibility.OptionCheck> {
      { GoModuleNameCliOption, OptionCompatibility.NoOpOptionCheck }
    });
        }

        protected override SinglePassCodeGenerator CreateCodeGenerator()
        {
            var goModuleName = Options.Get(GoModuleNameCliOption);
            GoModuleMode = goModuleName != null;
            if (GoModuleMode)
            {
                GoModuleName = goModuleName;
            }
            return new GoCodeGenerator(Options, Reporter);
        }

        public override async Task<bool> OnPostGenerate(string dafnyProgramName, string targetDirectory, TextWriter outputWriter)
        {
            return await MutateCSharp.Schemata232.ReplaceBinExprOp_2(10L, async () => await base.OnPostGenerate(dafnyProgramName, targetDirectory, outputWriter), async () => await OptimizeImports(targetDirectory, outputWriter));
        }

        private async Task<bool> OptimizeImports(string targetFilename, TextWriter outputWriter)
        {
            var goArgs = new List<string> { MutateCSharp.Schemata232.ReplaceStringConstant_0(16L, "-w"),
      targetFilename
    };

            var writer = new StringWriter();

            var psi = PrepareProcessStartInfo(MutateCSharp.Schemata232.ReplaceStringConstant_0(17L, "goimports"), goArgs);

            var result = await RunProcess(psi, writer, writer);
            if (MutateCSharp.Schemata232.ReplaceBinExprOp_4(22L, result, MutateCSharp.Schemata232.ReplaceNumericConstant_3(18L, 0)))
            {
                await outputWriter.WriteLineAsync(MutateCSharp.Schemata232.ReplaceStringConstant_0(27L, "Error occurred while invoking goimports:"));
                await outputWriter.WriteAsync(writer.ToString());
            }
            return MutateCSharp.Schemata232.ReplaceBinExprOp_5(32L, MutateCSharp.Schemata232.ReplaceNumericConstant_3(28L, 0), result);
        }

        public override async Task<(bool Success, object CompilationResult)> CompileTargetProgram(string dafnyProgramName,
          string targetProgramText,
          string callToMain, /*?*/
          string targetFilename /*?*/, ReadOnlyCollection<string> otherFileNames,
          bool runAfterCompile, TextWriter outputWriter)
        {
            if (runAfterCompile)
            {
                Contract.Assert(callToMain != null);  // this is part of the contract of CompileTargetProgram
                                                      // Since the program is to be run soon, nothing further is done here. Any compilation errors (that is, any errors
                                                      // in the emitted program--this should never happen if the compiler itself is correct) will be reported as 'go run'
                                                      // will run the program.
                return (MutateCSharp.Schemata232.ReplaceBooleanConstant_1(37L, true), null);
            }
            else
            {
                // compile now
                return (await SendToNewGoProcess(dafnyProgramName, targetFilename, otherFileNames,
                  outputWriter, outputWriter, callToMain != null, run: MutateCSharp.Schemata232.ReplaceBooleanConstant_1(38L, false)), null);
            }

            return default;
        }

        public override Task<bool> RunTargetProgram(string dafnyProgramName, string targetProgramText,
          string callToMain, /*?*/
          string targetFilename, ReadOnlyCollection<string> otherFileNames,
          object compilationResult, TextWriter outputWriter, TextWriter errorWriter)
        {

            return SendToNewGoProcess(dafnyProgramName, targetFilename, otherFileNames, outputWriter, errorWriter, hasMain: MutateCSharp.Schemata232.ReplaceBooleanConstant_1(39L, true), run: MutateCSharp.Schemata232.ReplaceBooleanConstant_1(40L, true));
        }

        private async Task<bool> SendToNewGoProcess(string dafnyProgramName, string targetFilename,
          ReadOnlyCollection<string> otherFileNames,
          TextWriter outputWriter, TextWriter errorWriter, bool hasMain, bool run)
        {
            Contract.Requires(targetFilename != null);

            foreach (var otherFileName in otherFileNames)
            {
                if (MutateCSharp.Schemata232.ReplaceBinExprOp_6(42L, Path.GetExtension(otherFileName), MutateCSharp.Schemata232.ReplaceStringConstant_0(41L, ".go")))
                {
                    await outputWriter.WriteLineAsync($"Unrecognized file as extra input for Go compilation: {otherFileName}");
                    return MutateCSharp.Schemata232.ReplaceBooleanConstant_1(43L, false);
                }

                if (!CopyExternLibraryIntoPlace(mainProgram: targetFilename, externFilename: otherFileName, outputWriter: outputWriter))
                {
                    return MutateCSharp.Schemata232.ReplaceBooleanConstant_1(44L, false);
                }
            }

            // Dafny used to compile to the old Go package system only, but Go has moved on to a module
            // system. Although compiler has moved to new system, it still doesn't generate the go.mod file which
            // is required by go run. It also supports backwards compatability with GOPATH hence those env variables
            // are still being used while running in GOPATH mode.
            if (GoModuleMode)
            {
                Reporter.Info(MessageSource.Compiler, Token.Cli, MutateCSharp.Schemata232.ReplaceStringConstant_0(45L, "go build/run skipped in Go Module Mode"));
                return MutateCSharp.Schemata232.ReplaceBooleanConstant_1(46L, true);
            }

            List<string> goArgs = new();
            if (run)
            {
                goArgs.Add(MutateCSharp.Schemata232.ReplaceStringConstant_0(47L, "run"));
            }
            else
            {
                string output;
                var outputToFile = !Options.RunAfterCompile;

                if (outputToFile)
                {
                    string extension;
                    if (hasMain)
                    {
                        switch (Environment.OSVersion.Platform)
                        {
                            case PlatformID.Unix:
                            case PlatformID.MacOSX:
                            case (PlatformID)128: // early Mono
                                extension = null;
                                break;
                                break;
                            default:
                                extension = "exe";
                                break;
                                break;
                        }
                    }
                    else
                    {
                        extension = MutateCSharp.Schemata232.ReplaceStringConstant_0(48L, "a");
                    }
                    output = Path.ChangeExtension(dafnyProgramName, extension);
                }
                else
                {
                    // This is used when there is no main method but user has invoked dafny run.
                    switch (Environment.OSVersion.Platform)
                    {
                        case PlatformID.Unix:
                        case PlatformID.MacOSX:
                        case (PlatformID)128: // early Mono
                            output = "/dev/null";
                            break;
                            break;
                        default:
                            output = "NUL";
                            break;
                            break;
                    }
                }

                goArgs.Add(MutateCSharp.Schemata232.ReplaceStringConstant_0(49L, "build"));
                goArgs.Add(MutateCSharp.Schemata232.ReplaceStringConstant_0(50L, "-o"));
                goArgs.Add(output);
            }

            goArgs.Add(targetFilename);
            goArgs.AddRange(Options.MainArgs);

            var psi = PrepareProcessStartInfo(MutateCSharp.Schemata232.ReplaceStringConstant_0(51L, "go"), goArgs);

            psi.EnvironmentVariables[MutateCSharp.Schemata232.ReplaceStringConstant_0(52L, "GOPATH")] = GoPath(targetFilename);
            psi.EnvironmentVariables[MutateCSharp.Schemata232.ReplaceStringConstant_0(53L, "GO111MODULE")] = MutateCSharp.Schemata232.ReplaceStringConstant_0(54L, "auto");

            return MutateCSharp.Schemata232.ReplaceBinExprOp_5(59L, MutateCSharp.Schemata232.ReplaceNumericConstant_3(55L, 0), await RunProcess(psi, outputWriter, errorWriter));
        }

        static string GoPath(string filename)
        {
            var dirName = Path.GetDirectoryName(Path.GetDirectoryName(filename));

            Contract.Assert(dirName != null);

            // Filename is Foo-go/src/Foo.go, so go two directories up
            return Path.GetFullPath(dirName);
        }

        bool CopyExternLibraryIntoPlace(string externFilename, string mainProgram, TextWriter outputWriter)
        {
            // Grossly, we need to look in the file to figure out where to put it
            var pkgName = FindPackageName(externFilename);
            if (pkgName == null)
            {
                outputWriter.WriteLine(MutateCSharp.Schemata232.ReplaceStringConstant_0(64L, "Unable to determine package name: {0}"), externFilename);
                return MutateCSharp.Schemata232.ReplaceBooleanConstant_1(65L, false);
            }
            if (pkgName.StartsWith(MutateCSharp.Schemata232.ReplaceStringConstant_0(66L, "_")))
            {
                // Check this here because otherwise Go acts like the package simply doesn't exist, which is confusing
                outputWriter.WriteLine(MutateCSharp.Schemata232.ReplaceStringConstant_0(67L, "Go packages can't start with underscores: {0}"), pkgName);
                return MutateCSharp.Schemata232.ReplaceBooleanConstant_1(68L, false);
            }

            var mainDir = Path.GetDirectoryName(mainProgram);

            Contract.Assert(mainDir != null);

            var tgtDir = Path.Combine(mainDir, pkgName);
            var tgtFilename = Path.Combine(tgtDir, pkgName + MutateCSharp.Schemata232.ReplaceStringConstant_0(69L, ".go"));

            Directory.CreateDirectory(tgtDir);
            File.Copy(externFilename, tgtFilename, overwrite: MutateCSharp.Schemata232.ReplaceBooleanConstant_1(70L, true));

            string relTgtFilename;
            var cwd = Directory.GetCurrentDirectory();
            if (tgtFilename.StartsWith(cwd))
            {
                relTgtFilename = tgtFilename.Substring(MutateCSharp.Schemata232.ReplaceBinExprOp_7(75L, cwd.Length, MutateCSharp.Schemata232.ReplaceNumericConstant_3(71L, 1))); // chop off relative path and '/'
            }
            else
            {
                relTgtFilename = tgtFilename;
            }
            if (Options.Verbose)
            {
                outputWriter.WriteLine(MutateCSharp.Schemata232.ReplaceStringConstant_0(84L, "Additional input {0} copied to {1}"), externFilename, relTgtFilename);
            }
            return MutateCSharp.Schemata232.ReplaceBooleanConstant_1(85L, true);
        }

        private static string FindPackageName(string externFilename)
        {
            using var rd = new StreamReader(new FileStream(externFilename, FileMode.Open, FileAccess.Read));
            while (rd.ReadLine() is { } line)
            {
                var match = PackageLine.Match(line);
                if (match.Success)
                {
                    return match.Groups[MutateCSharp.Schemata232.ReplaceNumericConstant_3(86L, 1)].Value;
                }
            }
            return null;
        }

        private static readonly Regex PackageLine = new Regex(MutateCSharp.Schemata232.ReplaceStringConstant_0(90L, @"^\s*package\s+([a-zA-Z0-9_]+)\s*$"));

        public GoBackend(DafnyOptions options) : base(options)
        {
        }
    }
}