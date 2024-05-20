using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace MutateCSharp
{
    internal class Schemata235
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT235");
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

        internal static uint ReplaceNumericConstant_6(long mutantId, uint argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 2)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, long argument1, long argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceNumericConstant_4(long mutantId, int argument1)
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
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, System.IO.Stream argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny.Compilers
{
    public class JavaBackend : ExecutableBackend
    {

        public override IReadOnlySet<string> SupportedExtensions => new HashSet<string> { MutateCSharp.Schemata235.ReplaceStringConstant_0(1L, ".java") };

        public override string TargetName => MutateCSharp.Schemata235.ReplaceStringConstant_0(2L, "Java");
        public override bool IsStable => MutateCSharp.Schemata235.ReplaceBooleanConstant_1(3L, true);
        public override string TargetExtension => MutateCSharp.Schemata235.ReplaceStringConstant_0(4L, "java");

        public override string TargetBasename(string dafnyProgramName) =>
          JavaCodeGenerator.TransformToClassName(base.TargetBasename(dafnyProgramName));

        public override string TargetBaseDir(string dafnyProgramName) =>
          $"{Path.GetFileNameWithoutExtension(dafnyProgramName)}-java";

        public override bool SupportsInMemoryCompilation => MutateCSharp.Schemata235.ReplaceBooleanConstant_1(5L, false);
        public override bool TextualTargetIsExecutable => MutateCSharp.Schemata235.ReplaceBooleanConstant_1(6L, false);

        public override void CleanSourceDirectory(string sourceDirectory)
        {
            try
            {
                Directory.Delete(sourceDirectory, MutateCSharp.Schemata235.ReplaceBooleanConstant_1(7L, true));
            }
            catch (DirectoryNotFoundException)
            {
            }
        }

        protected override SinglePassCodeGenerator CreateCodeGenerator()
        {
            return new JavaCodeGenerator(Options, Reporter);
        }

        private void EmitRuntimeJar(string targetDirectory)
        {
            // Since DafnyRuntime.jar is binary, we can't use ReadRuntimeSystem
            var jarName = MutateCSharp.Schemata235.ReplaceStringConstant_0(8L, "DafnyRuntime.jar");
            var assembly = System.Reflection.Assembly.Load(MutateCSharp.Schemata235.ReplaceStringConstant_0(9L, "DafnyPipeline"));
            var stream = assembly.GetManifestResourceStream(jarName);
            if (MutateCSharp.Schemata235.ReplaceBinExprOp_2(10L, stream, null))
            {
                throw new Exception($"Cannot find embedded resource: {jarName}");
            }

            var fullJarName = $"{targetDirectory}/{jarName}";
            FileStream outStream = new FileStream(fullJarName, FileMode.Create, FileAccess.Write);
            stream.CopyTo(outStream);
            outStream.Close();
        }

        public override async Task<(bool Success, object CompilationResult)> CompileTargetProgram(string dafnyProgramName,
          string targetProgramText,
          string callToMain /*?*/, string targetFilename, /*?*/
          ReadOnlyCollection<string> otherFileNames, bool runAfterCompile, TextWriter outputWriter)
        {
            foreach (var otherFileName in otherFileNames)
            {
                if (MutateCSharp.Schemata235.ReplaceBinExprOp_3(12L, Path.GetExtension(otherFileName), MutateCSharp.Schemata235.ReplaceStringConstant_0(11L, ".java")))
                {
                    await outputWriter.WriteLineAsync($"Unrecognized file as extra input for Java compilation: {otherFileName}");
                    return (MutateCSharp.Schemata235.ReplaceBooleanConstant_1(13L, false), null);
                }
                if (!CopyExternLibraryIntoPlace(mainProgram: targetFilename, externFilename: otherFileName, outputWriter: outputWriter))
                {
                    return (MutateCSharp.Schemata235.ReplaceBooleanConstant_1(14L, false), null);
                }
            }

            var targetDirectory = Path.GetDirectoryName(targetFilename);

            var files = new List<string>();
            foreach (string file in Directory.EnumerateFiles(targetDirectory, MutateCSharp.Schemata235.ReplaceStringConstant_0(15L, "*.java"), SearchOption.AllDirectories))
            {
                files.Add(Path.GetFullPath(file));
            }

            // Compile the generated source to .class files, adding the output directory to the classpath
            var compileProcess = PrepareProcessStartInfo(MutateCSharp.Schemata235.ReplaceStringConstant_0(16L, "javac"), new List<string> { MutateCSharp.Schemata235.ReplaceStringConstant_0(17L, "-encoding"), MutateCSharp.Schemata235.ReplaceStringConstant_0(18L, "UTF8") }.Concat(files));
            compileProcess.WorkingDirectory = Path.GetFullPath(Path.GetDirectoryName(targetFilename));
            compileProcess.EnvironmentVariables[MutateCSharp.Schemata235.ReplaceStringConstant_0(19L, "CLASSPATH")] = GetClassPath(targetFilename);
            if (MutateCSharp.Schemata235.ReplaceBinExprOp_5(25L, MutateCSharp.Schemata235.ReplaceNumericConstant_4(20L, 0), await RunProcess(compileProcess, outputWriter, outputWriter, MutateCSharp.Schemata235.ReplaceStringConstant_0(24L, "Error while compiling Java files."))))
            {
                return (MutateCSharp.Schemata235.ReplaceBooleanConstant_1(30L, false), null);
            }

            var classFiles = Directory.EnumerateFiles(targetDirectory, MutateCSharp.Schemata235.ReplaceStringConstant_0(31L, "*.class"), SearchOption.AllDirectories)
                .Select(file => Path.GetRelativePath(targetDirectory, file)).ToList();

            var simpleProgramName = Path.GetFileNameWithoutExtension(targetFilename);
            var jarPath = Path.GetFullPath(Path.ChangeExtension(dafnyProgramName, MutateCSharp.Schemata235.ReplaceStringConstant_0(32L, ".jar")));
            if (!await CreateJar(callToMain == null ? null : simpleProgramName,
                           jarPath,
                           Path.GetFullPath(Path.GetDirectoryName(targetFilename)),
                           classFiles,
                           outputWriter))
            {
                return (MutateCSharp.Schemata235.ReplaceBooleanConstant_1(33L, false), null);
            }

            // Keep the build artifacts if --spill-translation is true
            // But keep them for legacy CLI so as not to break old behavior
            if (Options.UsingNewCli)
            {
                if (MutateCSharp.Schemata235.ReplaceBinExprOp_7(37L, Options.SpillTargetCode, MutateCSharp.Schemata235.ReplaceNumericConstant_6(34L, 0)))
                {
                    Directory.Delete(targetDirectory, MutateCSharp.Schemata235.ReplaceBooleanConstant_1(42L, true));
                }
                else
                {
                    classFiles.ForEach(f => File.Delete(Path.Join(targetDirectory, f)));
                }
            }

            if (Options.Verbose)
            {
                // For the sake of tests, just write out the filename and not the directory path
                var fileKind = callToMain != null ? MutateCSharp.Schemata235.ReplaceStringConstant_0(43L, "executable") : MutateCSharp.Schemata235.ReplaceStringConstant_0(44L, "library");
                await outputWriter.WriteLineAsync($"Wrote {fileKind} jar {Path.GetFileName(jarPath)}");
            }

            return (MutateCSharp.Schemata235.ReplaceBooleanConstant_1(45L, true), null);
        }


        public async Task<bool> CreateJar(string/*?*/ entryPointName, string jarPath, string rootDirectory, List<string> files, TextWriter outputWriter)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(jarPath));
            var args = entryPointName == null ? // If null, then no entry point is added
                new List<string> { MutateCSharp.Schemata235.ReplaceStringConstant_0(46L, "cf"), jarPath }
                : new List<string> { MutateCSharp.Schemata235.ReplaceStringConstant_0(47L, "cfe"), jarPath, entryPointName };
            var jarCreationProcess = PrepareProcessStartInfo(MutateCSharp.Schemata235.ReplaceStringConstant_0(48L, "jar"), args.Concat(files));
            jarCreationProcess.WorkingDirectory = rootDirectory;
            return MutateCSharp.Schemata235.ReplaceBinExprOp_8(54L, MutateCSharp.Schemata235.ReplaceNumericConstant_4(49L, 0), await RunProcess(jarCreationProcess, outputWriter, outputWriter, MutateCSharp.Schemata235.ReplaceStringConstant_0(53L, "Error while creating jar file: ") + jarPath));
        }

        public override async Task<bool> RunTargetProgram(string dafnyProgramName, string targetProgramText, string callToMain,
          string targetFilename, /*?*/
          ReadOnlyCollection<string> otherFileNames, object compilationResult, TextWriter outputWriter,
          TextWriter errorWriter)
        {
            string jarPath = Path.ChangeExtension(dafnyProgramName, MutateCSharp.Schemata235.ReplaceStringConstant_0(59L, ".jar")); // Must match that in CompileTargetProgram
            var psi = PrepareProcessStartInfo(MutateCSharp.Schemata235.ReplaceStringConstant_0(60L, "java"),
              new List<string> { MutateCSharp.Schemata235.ReplaceStringConstant_0(61L, "-Dfile.encoding=UTF-8"), MutateCSharp.Schemata235.ReplaceStringConstant_0(62L, "-jar"), jarPath }
                .Concat(Options.MainArgs));
            // Run the target program in the user's working directory and with the user's classpath
            psi.EnvironmentVariables[MutateCSharp.Schemata235.ReplaceStringConstant_0(63L, "CLASSPATH")] = GetClassPath(null);
            return MutateCSharp.Schemata235.ReplaceBinExprOp_8(68L, MutateCSharp.Schemata235.ReplaceNumericConstant_4(64L, 0), await RunProcess(psi, outputWriter, errorWriter));
        }

        private string GetClassPath(string targetFilename)
        {
            var classpath = Environment.GetEnvironmentVariable(MutateCSharp.Schemata235.ReplaceStringConstant_0(73L, "CLASSPATH")); // String.join converts null to ""
                                                                                                                                    // Note that the items in the CLASSPATH must have absolute paths because the compilation is performed in a subfolder of where the command-line is executed
            if (targetFilename != null)
            {
                var targetDirectory = Path.GetFullPath(Path.GetDirectoryName(targetFilename));
                var parts = new List<string> { MutateCSharp.Schemata235.ReplaceStringConstant_0(74L, "."), targetDirectory, classpath };
                if (!Options.IncludeRuntime)
                {
                    EmitRuntimeJar(targetDirectory);
                    parts.Add(Path.Combine(targetDirectory, MutateCSharp.Schemata235.ReplaceStringConstant_0(75L, "DafnyRuntime.jar")));
                }
                return string.Join(Path.PathSeparator, parts);
            }

            return classpath;
        }

        bool CopyExternLibraryIntoPlace(string externFilename, string mainProgram, TextWriter outputWriter)
        {
            // Grossly, we need to look in the file to figure out where to put it
            var pkgName = FindPackageName(externFilename);
            if (pkgName == null)
            {
                outputWriter.WriteLine($"Unable to determine package name: {externFilename}");
                return MutateCSharp.Schemata235.ReplaceBooleanConstant_1(76L, false);
            }
            string baseName = Path.GetFileNameWithoutExtension(externFilename);
            var mainDir = Path.GetDirectoryName(mainProgram);
            Contract.Assert(mainDir != null);
            var tgtDir = Path.Combine(mainDir, pkgName);
            var tgtFilename = Path.Combine(tgtDir, baseName + MutateCSharp.Schemata235.ReplaceStringConstant_0(77L, ".java"));
            Directory.CreateDirectory(tgtDir);
            FileInfo file = new FileInfo(externFilename);
            file.CopyTo(tgtFilename, MutateCSharp.Schemata235.ReplaceBooleanConstant_1(78L, true));
            if (Options.Verbose)
            {
                outputWriter.WriteLine($"Additional input {externFilename} copied to {tgtFilename}");
            }
            return MutateCSharp.Schemata235.ReplaceBooleanConstant_1(79L, true);
        }

        private static string FindPackageName(string externFilename)
        {
            using var rd = new StreamReader(new FileStream(externFilename, FileMode.Open, FileAccess.Read));
            while (rd.ReadLine() is string line)
            {
                var match = PackageLine.Match(line);
                if (match.Success)
                {
                    return match.Groups[MutateCSharp.Schemata235.ReplaceNumericConstant_4(80L, 1)].Value;
                }
            }
            return null;
        }

        private static readonly Regex PackageLine = new Regex(MutateCSharp.Schemata235.ReplaceStringConstant_0(84L, @"^\s*package\s+([a-zA-Z0-9_]+)\s*;$"));

        public JavaBackend(DafnyOptions options) : base(options)
        {
        }
    }
}
