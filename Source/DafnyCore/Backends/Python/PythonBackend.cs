using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
namespace MutateCSharp
{
    internal class Schemata240
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT240");
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

        internal static bool ReplaceBinExprOp_3(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceNumericConstant_2(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
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

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny.Compilers
{
    public class PythonBackend : ExecutableBackend
    {

        public override IReadOnlySet<string> SupportedExtensions => new HashSet<string> { MutateCSharp.Schemata240.ReplaceStringConstant_0(1L, ".py") };

        public override string TargetName => MutateCSharp.Schemata240.ReplaceStringConstant_0(2L, "Python");
        public override bool IsStable => MutateCSharp.Schemata240.ReplaceBooleanConstant_1(3L, true);
        public override string TargetExtension => MutateCSharp.Schemata240.ReplaceStringConstant_0(4L, "py");
        public override int TargetIndentSize => MutateCSharp.Schemata240.ReplaceNumericConstant_2(5L, 4);

        public override string TargetBaseDir(string dafnyProgramName) =>
          $"{Path.GetFileNameWithoutExtension(dafnyProgramName)}-py";

        public override string TargetBasename(string dafnyProgramName) => MutateCSharp.Schemata240.ReplaceStringConstant_0(9L, "__main__");

        public override bool SupportsInMemoryCompilation => MutateCSharp.Schemata240.ReplaceBooleanConstant_1(10L, false);
        public override bool TextualTargetIsExecutable => MutateCSharp.Schemata240.ReplaceBooleanConstant_1(11L, true);

        public override IReadOnlySet<string> SupportedNativeTypes =>
          new HashSet<string> { MutateCSharp.Schemata240.ReplaceStringConstant_0(12L, "byte"), MutateCSharp.Schemata240.ReplaceStringConstant_0(13L, "sbyte"), MutateCSharp.Schemata240.ReplaceStringConstant_0(14L, "ushort"), MutateCSharp.Schemata240.ReplaceStringConstant_0(15L, "short"), MutateCSharp.Schemata240.ReplaceStringConstant_0(16L, "uint"), MutateCSharp.Schemata240.ReplaceStringConstant_0(17L, "int"), MutateCSharp.Schemata240.ReplaceStringConstant_0(18L, "number"), MutateCSharp.Schemata240.ReplaceStringConstant_0(19L, "ulong"), MutateCSharp.Schemata240.ReplaceStringConstant_0(20L, "long") };

        protected override SinglePassCodeGenerator CreateCodeGenerator()
        {
            return new PythonCodeGenerator(Options, Reporter);
        }

        private static readonly Regex ModuleLine = new(MutateCSharp.Schemata240.ReplaceStringConstant_0(21L, @"^\s*#\s*Module:\s+([a-zA-Z0-9_]+(.[a-zA-Z0-9_]+)*)\s*$"));

        private static string FindModuleName(string externFilename)
        {
            using var rd = new StreamReader(new FileStream(externFilename, FileMode.Open, FileAccess.Read));
            while (rd.ReadLine() is { } line)
            {
                var match = ModuleLine.Match(line);
                if (match.Success)
                {
                    rd.Close();
                    return match.Groups[MutateCSharp.Schemata240.ReplaceNumericConstant_2(22L, 1)].Value;
                }
            }
            rd.Close();
            return MutateCSharp.Schemata240.ReplaceBinExprOp_3(27L, Path.GetExtension(externFilename), MutateCSharp.Schemata240.ReplaceStringConstant_0(26L, ".py")) ? Path.GetFileNameWithoutExtension(externFilename) : null;
        }

        private static readonly Dictionary<OSPlatform, string> PlatformDefaults = new() {
    { OSPlatform.Linux, MutateCSharp.Schemata240.ReplaceStringConstant_0(28L, "python3") },
    { OSPlatform.Windows, MutateCSharp.Schemata240.ReplaceStringConstant_0(29L, "python") },
    { OSPlatform.FreeBSD, MutateCSharp.Schemata240.ReplaceStringConstant_0(30L, "python3") },
    { OSPlatform.OSX, MutateCSharp.Schemata240.ReplaceStringConstant_0(31L, "python3") },
  };
        private static string DefaultPythonCommand => PlatformDefaults.SingleOrDefault(
            kv => RuntimeInformation.IsOSPlatform(kv.Key),
            new(OSPlatform.Linux, MutateCSharp.Schemata240.ReplaceStringConstant_0(32L, "python3"))
          ).Value;

        bool CopyExternLibraryIntoPlace(string externFilename, string mainProgram, TextWriter outputWriter)
        {
            // Grossly, we need to look in the file to figure out where to put it
            var moduleName = FindModuleName(externFilename);
            if (moduleName == null)
            {
                outputWriter.WriteLine($"Unable to determine module name: {externFilename}");
                return MutateCSharp.Schemata240.ReplaceBooleanConstant_1(33L, false);
            }
            var mainDir = Path.GetDirectoryName(mainProgram);
            Contract.Assert(mainDir != null);
            var modulePath = moduleName.Replace('.', Path.DirectorySeparatorChar);
            var tgtFilename = Path.Combine(mainDir, $"{modulePath}.py");
            var file = new FileInfo(externFilename);
            Directory.CreateDirectory(Path.GetDirectoryName(tgtFilename)!);
            file.CopyTo(tgtFilename, MutateCSharp.Schemata240.ReplaceBooleanConstant_1(34L, true));
            if (Options.Verbose)
            {
                outputWriter.WriteLine($"Additional input {externFilename} copied to {tgtFilename}");
            }
            return MutateCSharp.Schemata240.ReplaceBooleanConstant_1(35L, true);
        }

        public override void CleanSourceDirectory(string sourceDirectory)
        {
            var cacheDirectory = Path.Combine(sourceDirectory, MutateCSharp.Schemata240.ReplaceStringConstant_0(36L, "__pycache__"));
            try
            {
                Directory.Delete(cacheDirectory, MutateCSharp.Schemata240.ReplaceBooleanConstant_1(37L, true));
            }
            catch (DirectoryNotFoundException)
            {
            }
        }

        public override async Task<(bool Success, object CompilationResult)> CompileTargetProgram(string dafnyProgramName,
          string targetProgramText,
          string callToMain /*?*/, string targetFilename /*?*/, ReadOnlyCollection<string> otherFileNames,
          bool runAfterCompile, TextWriter outputWriter)
        {
            foreach (var otherFileName in otherFileNames)
            {
                if (MutateCSharp.Schemata240.ReplaceBinExprOp_4(39L, Path.GetExtension(otherFileName), MutateCSharp.Schemata240.ReplaceStringConstant_0(38L, ".py")))
                {
                    await outputWriter.WriteLineAsync($"Unrecognized file as extra input for Python compilation: {otherFileName}");
                    return (MutateCSharp.Schemata240.ReplaceBooleanConstant_1(40L, false), null);
                }
                if (!CopyExternLibraryIntoPlace(otherFileName, targetFilename, outputWriter))
                {
                    return (MutateCSharp.Schemata240.ReplaceBooleanConstant_1(41L, false), null);
                }
            }
            if (!runAfterCompile)
            {
                var psi = PrepareProcessStartInfo(DefaultPythonCommand);
                psi.Arguments = $"-m compileall -q {Path.GetDirectoryName(targetFilename)}";
                return (MutateCSharp.Schemata240.ReplaceBinExprOp_5(47L, MutateCSharp.Schemata240.ReplaceNumericConstant_2(42L, 0), await RunProcess(psi, outputWriter, outputWriter, MutateCSharp.Schemata240.ReplaceStringConstant_0(46L, "Error while compiling Python files."))), null);
            }
            return (MutateCSharp.Schemata240.ReplaceBooleanConstant_1(52L, true), null);
        }

        public override async Task<bool> RunTargetProgram(string dafnyProgramName, string targetProgramText,
          string callToMain, /*?*/
          string targetFilename, ReadOnlyCollection<string> otherFileNames, object compilationResult, TextWriter outputWriter,
          TextWriter errorWriter)
        {
            Contract.Requires(targetFilename != null || otherFileNames.Count == 0);
            var psi = PrepareProcessStartInfo(DefaultPythonCommand, Options.MainArgs.Prepend(targetFilename));
            psi.EnvironmentVariables[MutateCSharp.Schemata240.ReplaceStringConstant_0(53L, "PYTHONIOENCODING")] = MutateCSharp.Schemata240.ReplaceStringConstant_0(54L, "utf8");
            return MutateCSharp.Schemata240.ReplaceBinExprOp_5(59L, MutateCSharp.Schemata240.ReplaceNumericConstant_2(55L, 0), await RunProcess(psi, outputWriter, errorWriter));
        }

        public PythonBackend(DafnyOptions options) : base(options)
        {
        }
    }
}