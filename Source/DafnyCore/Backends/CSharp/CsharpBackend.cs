using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
namespace MutateCSharp
{
    internal class Schemata218
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT218");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_4(long mutantId, System.Reflection.Assembly argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static bool ReplaceBinExprOp_6(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.CodeAnalysis.DiagnosticSeverity argument1, Microsoft.CodeAnalysis.DiagnosticSeverity argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceNumericConstant_5(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny.Compilers
{
    public class CsharpBackend : ExecutableBackend
    {

        protected override SinglePassCodeGenerator CreateCodeGenerator()
        {
            return new CsharpCodeGenerator(Options, Reporter);
        }

        public override IReadOnlySet<string> SupportedExtensions => new HashSet<string> { MutateCSharp.Schemata218.ReplaceStringConstant_0(1L, ".cs"), MutateCSharp.Schemata218.ReplaceStringConstant_0(2L, ".dll") };

        public override string TargetName => MutateCSharp.Schemata218.ReplaceStringConstant_0(3L, "C#");
        public override bool IsStable => MutateCSharp.Schemata218.ReplaceBooleanConstant_1(4L, true);
        public override string TargetExtension => MutateCSharp.Schemata218.ReplaceStringConstant_0(5L, "cs");

        // True if the most recently visited AST has a method annotated with {:synthesize}:

        public override string GetCompileName(bool isDefaultModule, string moduleName, string compileName)
        {
            return isDefaultModule
              ? PublicIdProtect(compileName)
              : base.GetCompileName(isDefaultModule, moduleName, compileName);
        }

        public override bool SupportsInMemoryCompilation => MutateCSharp.Schemata218.ReplaceBooleanConstant_1(6L, true);
        public override bool TextualTargetIsExecutable => MutateCSharp.Schemata218.ReplaceBooleanConstant_1(7L, false);

        public override async Task<(bool Success, object CompilationResult)> CompileTargetProgram(string dafnyProgramName,
          string targetProgramText,
          string callToMain /*?*/, string targetFilename /*?*/, ReadOnlyCollection<string> otherFileNames,
          bool runAfterCompile, TextWriter outputWriter)
        {

            // .NET Core does not allow C# compilation on all platforms using System.CodeDom. You need to use Roslyn libraries. Context: https://github.com/dotnet/runtime/issues/18768
            var compilation = CSharpCompilation.Create(Path.GetFileNameWithoutExtension(dafnyProgramName))
              .WithOptions(new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary))
              .AddReferences(
                MetadataReference.CreateFromFile(typeof(object).GetTypeInfo().Assembly.Location),
                MetadataReference.CreateFromFile(Assembly.Load(MutateCSharp.Schemata218.ReplaceStringConstant_0(8L, "mscorlib")).Location));

            compilation = compilation.WithOptions(compilation.Options.WithOutputKind(callToMain != null ? OutputKind.ConsoleApplication : OutputKind.DynamicallyLinkedLibrary));

            var tempCompilationResult = new CSharpCompilationResult();
            if (!Options.IncludeRuntime)
            {
                var libPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                compilation = compilation.AddReferences(MetadataReference.CreateFromFile(Path.Join(libPath, MutateCSharp.Schemata218.ReplaceStringConstant_0(9L, "DafnyRuntime.dll"))));
                compilation = compilation.AddReferences(MetadataReference.CreateFromFile(Assembly.Load(MutateCSharp.Schemata218.ReplaceStringConstant_0(10L, "netstandard")).Location));
            }

            var standardLibraries = new List<string>()
            {
                MutateCSharp.Schemata218.ReplaceStringConstant_0(11L, "System.Runtime"),
                MutateCSharp.Schemata218.ReplaceStringConstant_0(12L, "System.Runtime.Numerics"),
                MutateCSharp.Schemata218.ReplaceStringConstant_0(13L, "System.Collections"),
                MutateCSharp.Schemata218.ReplaceStringConstant_0(14L, "System.Collections.Immutable"),
                MutateCSharp.Schemata218.ReplaceStringConstant_0(15L, "System.Collections.Concurrent"),
                MutateCSharp.Schemata218.ReplaceStringConstant_0(16L, "System.Console"
        )
            };
            compilation = compilation.AddReferences(standardLibraries.Select(fileName => MetadataReference.CreateFromFile(Assembly.Load((string)fileName).Location)));

            if (Options.Optimize)
            {
                compilation = compilation.WithOptions(compilation.Options.WithOptimizationLevel(
                  Options.Optimize ? OptimizationLevel.Release : OptimizationLevel.Debug));
            }

            var otherSourceFiles = new List<string>();
            foreach (var file in otherFileNames)
            {
                string extension = Path.GetExtension(file);
                if (extension != null) { extension = extension.ToLower(); }
                if (MutateCSharp.Schemata218.ReplaceBinExprOp_2(18L, extension, MutateCSharp.Schemata218.ReplaceStringConstant_0(17L, ".cs")))
                {
                    var normalizedPath = Path.Combine(Path.GetDirectoryName(file), Path.GetFileName(file));
                    if (File.Exists(normalizedPath))
                    {
                        otherSourceFiles.Add(normalizedPath);
                    }
                    else
                    {
                        await outputWriter.WriteLineAsync($"Errors compiling program: Could not find {file}");
                        return (MutateCSharp.Schemata218.ReplaceBooleanConstant_1(19L, false), null);
                    }
                }
                else if (MutateCSharp.Schemata218.ReplaceBinExprOp_2(21L, extension, MutateCSharp.Schemata218.ReplaceStringConstant_0(20L, ".dll")))
                {
                    compilation = compilation.AddReferences(MetadataReference.CreateFromFile(Path.GetFullPath(file)));
                }
            }

            var source = callToMain == null ? targetProgramText : targetProgramText + callToMain;
            compilation = compilation.AddSyntaxTrees(CSharpSyntaxTree.ParseText(source, null, MutateCSharp.Schemata218.ReplaceStringConstant_0(22L, "source")));
            foreach (var sourceFile in otherSourceFiles)
            {
                compilation = compilation.AddSyntaxTrees(CSharpSyntaxTree.ParseText(File.ReadAllText(sourceFile), null, sourceFile));
            }
            var outputDir = targetFilename == null ? Directory.GetCurrentDirectory() : Path.GetDirectoryName(Path.GetFullPath(targetFilename));
            Directory.CreateDirectory(outputDir);
            var outputPath = Path.Join(outputDir, Path.GetFileNameWithoutExtension(Path.GetFileName(dafnyProgramName)) + MutateCSharp.Schemata218.ReplaceStringConstant_0(23L, ".dll"));
            var outputJson = Path.Join(outputDir, Path.GetFileNameWithoutExtension(Path.GetFileName(dafnyProgramName)) + MutateCSharp.Schemata218.ReplaceStringConstant_0(24L, ".runtimeconfig.json"));
            var emitResult = compilation.Emit(outputPath);

            if (emitResult.Success)
            {
                tempCompilationResult.CompiledAssembly = Assembly.LoadFile(outputPath);
                if (Options.Verbose)
                {
                    await outputWriter.WriteLineAsync($"Compiled assembly into {compilation.AssemblyName}.dll");
                }

                try
                {
                    var configuration = JsonSerializer.Serialize(
                      new
                      {
                          runtimeOptions = new
                          {
                              tfm = MutateCSharp.Schemata218.ReplaceStringConstant_0(25L, "net6.0"),
                              framework = new
                              {
                                  name = MutateCSharp.Schemata218.ReplaceStringConstant_0(26L, "Microsoft.NETCore.App"),
                                  version = MutateCSharp.Schemata218.ReplaceStringConstant_0(27L, "6.0.0"),
                                  rollForward = MutateCSharp.Schemata218.ReplaceStringConstant_0(28L, "LatestMinor"
            )
                              }
                          }
                      }, new JsonSerializerOptions() { WriteIndented = MutateCSharp.Schemata218.ReplaceBooleanConstant_1(29L, true) });
                    await File.WriteAllTextAsync(outputJson, configuration + Environment.NewLine);
                }
                catch (Exception e)
                {
                    await outputWriter.WriteLineAsync($"Error trying to write '{outputJson}': {e.Message}");
                    return (MutateCSharp.Schemata218.ReplaceBooleanConstant_1(30L, false), null);
                }
            }
            else
            {
                await outputWriter.WriteLineAsync($"Errors compiling program into {compilation.AssemblyName}");
                var errors = emitResult.Diagnostics.Where(d => MutateCSharp.Schemata218.ReplaceBinExprOp_3(31L, d.Severity, DiagnosticSeverity.Error)).ToList();
                foreach (var ce in errors)
                {
                    await outputWriter.WriteLineAsync(ce.ToString());
                    await outputWriter.WriteLineAsync();
                }

                return (MutateCSharp.Schemata218.ReplaceBooleanConstant_1(32L, false), null);
            }

            return (MutateCSharp.Schemata218.ReplaceBooleanConstant_1(33L, true), tempCompilationResult);
        }

        public class CSharpCompilationResult
        {
            public Assembly CompiledAssembly;
        }

        public override async Task<bool> RunTargetProgram(string dafnyProgramName, string targetProgramText, string callToMain,
          string targetFilename /*?*/, ReadOnlyCollection<string> otherFileNames,
          object compilationResult, TextWriter outputWriter, TextWriter errorWriter)
        {

            var crx = (CSharpCompilationResult)compilationResult;

            foreach (var otherFileName in otherFileNames)
            {
                if (MutateCSharp.Schemata218.ReplaceBinExprOp_2(35L, Path.GetExtension(otherFileName), MutateCSharp.Schemata218.ReplaceStringConstant_0(34L, ".dll")))
                {
                    var targetDirectory = Path.GetDirectoryName(crx.CompiledAssembly.Location);
                    File.Copy(otherFileName, Path.Combine(targetDirectory!, Path.GetFileName(otherFileName)), MutateCSharp.Schemata218.ReplaceBooleanConstant_1(36L, true));
                }
            }

            if (MutateCSharp.Schemata218.ReplaceBinExprOp_4(37L, crx.CompiledAssembly, null))
            {
                throw new Exception(MutateCSharp.Schemata218.ReplaceStringConstant_0(38L, "Cannot call run target program on a compilation that failed"));
            }
            var psi = PrepareProcessStartInfo(MutateCSharp.Schemata218.ReplaceStringConstant_0(39L, "dotnet"), new[] { crx.CompiledAssembly.Location }.Concat(Options.MainArgs));
            return MutateCSharp.Schemata218.ReplaceBinExprOp_6(44L, await RunProcess(psi, outputWriter, errorWriter), MutateCSharp.Schemata218.ReplaceNumericConstant_5(40L, 0));
        }

        public override void PopulateCoverageReport(CoverageReport coverageReport)
        {
            codeGenerator.Coverage.PopulateCoverageReport(coverageReport);
        }

        public CsharpBackend(DafnyOptions options) : base(options)
        {
        }
    }
}
