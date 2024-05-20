using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace MutateCSharp
{
    internal class Schemata245
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT245");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
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

        internal static bool ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_4(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
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

    }
}

namespace Microsoft.Dafny.Compilers
{
    public class RustBackend : DafnyExecutableBackend
    {
        protected override bool PreventShadowing => MutateCSharp.Schemata245.ReplaceBooleanConstant_0(1L, false);

        public override IReadOnlySet<string> SupportedExtensions => new HashSet<string> { MutateCSharp.Schemata245.ReplaceStringConstant_1(2L, ".rs") };
        public override string TargetName => MutateCSharp.Schemata245.ReplaceStringConstant_1(3L, "Rust");
        public override bool IsStable => MutateCSharp.Schemata245.ReplaceBooleanConstant_0(4L, true);
        public override bool IsInternal => MutateCSharp.Schemata245.ReplaceBooleanConstant_0(5L, true);
        public override string TargetExtension => MutateCSharp.Schemata245.ReplaceStringConstant_1(6L, "rs");
        public override int TargetIndentSize => MutateCSharp.Schemata245.ReplaceNumericConstant_2(7L, 4);
        public override bool SupportsInMemoryCompilation => MutateCSharp.Schemata245.ReplaceBooleanConstant_0(11L, false);
        public override bool TextualTargetIsExecutable => MutateCSharp.Schemata245.ReplaceBooleanConstant_0(12L, false);

        public override IReadOnlySet<string> SupportedNativeTypes =>
          new HashSet<string> { MutateCSharp.Schemata245.ReplaceStringConstant_1(13L, "byte"), MutateCSharp.Schemata245.ReplaceStringConstant_1(14L, "sbyte"), MutateCSharp.Schemata245.ReplaceStringConstant_1(15L, "ushort"), MutateCSharp.Schemata245.ReplaceStringConstant_1(16L, "short"), MutateCSharp.Schemata245.ReplaceStringConstant_1(17L, "uint"), MutateCSharp.Schemata245.ReplaceStringConstant_1(18L, "int"), MutateCSharp.Schemata245.ReplaceStringConstant_1(19L, "ulong"), MutateCSharp.Schemata245.ReplaceStringConstant_1(20L, "long"), MutateCSharp.Schemata245.ReplaceStringConstant_1(21L, "udoublelong"), MutateCSharp.Schemata245.ReplaceStringConstant_1(22L, "doublelong") };

        public override string TargetBasename(string dafnyProgramName) =>
          Regex.Replace(base.TargetBasename(dafnyProgramName), MutateCSharp.Schemata245.ReplaceStringConstant_1(23L, "[^_A-Za-z0-9]"), MutateCSharp.Schemata245.ReplaceStringConstant_1(24L, "_"));

        public override string TargetBaseDir(string dafnyProgramName) =>
          $"{Path.GetFileNameWithoutExtension(dafnyProgramName)}-rust/src";

        protected override DafnyWrittenCodeGenerator CreateDafnyWrittenCompiler()
        {
            return new RustCodeGenerator();
        }

        private string ComputeExeName(string targetFilename)
        {
            var targetDirectory = Path.GetDirectoryName(Path.GetDirectoryName(targetFilename));
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return Path.Combine(targetDirectory, MutateCSharp.Schemata245.ReplaceStringConstant_1(25L, "target"), MutateCSharp.Schemata245.ReplaceStringConstant_1(26L, "debug"), Path.GetFileNameWithoutExtension(targetFilename) + MutateCSharp.Schemata245.ReplaceStringConstant_1(27L, ".exe"));
            }
            else
            {
                return Path.Combine(targetDirectory, MutateCSharp.Schemata245.ReplaceStringConstant_1(28L, "target"), MutateCSharp.Schemata245.ReplaceStringConstant_1(29L, "debug"), Path.GetFileNameWithoutExtension(targetFilename));
            }

            return default;
        }

        public override async Task<(bool Success, object CompilationResult)> CompileTargetProgram(string dafnyProgramName,
          string targetProgramText,
          string callToMain /*?*/, string targetFilename /*?*/, ReadOnlyCollection<string> otherFileNames,
          bool runAfterCompile, TextWriter outputWriter)
        {
            var targetDirectory = Path.GetDirectoryName(Path.GetDirectoryName(targetFilename));
            var runtimeDirectory = Path.Combine(targetDirectory, MutateCSharp.Schemata245.ReplaceStringConstant_1(30L, "runtime"));
            if (Directory.Exists(runtimeDirectory))
            {
                Directory.Delete(runtimeDirectory, MutateCSharp.Schemata245.ReplaceBooleanConstant_0(31L, true));
            }
            Directory.CreateDirectory(runtimeDirectory);

            var assembly = System.Reflection.Assembly.Load(MutateCSharp.Schemata245.ReplaceStringConstant_1(32L, "DafnyPipeline"));
            assembly.GetManifestResourceNames().Where(f => f.StartsWith(MutateCSharp.Schemata245.ReplaceStringConstant_1(33L, "DafnyPipeline.DafnyRuntimeRust"))).ToList().ForEach(f =>
            {
                var stream = assembly.GetManifestResourceStream(f);
                var dotToSlashPath = "";
                var parts = f.Replace(MutateCSharp.Schemata245.ReplaceStringConstant_1(34L, "DafnyPipeline.DafnyRuntimeRust."), "").Split('.');
                for (var i = MutateCSharp.Schemata245.ReplaceNumericConstant_2(35L, 0); MutateCSharp.Schemata245.ReplaceBinExprOp_3(39L, i, parts.Length); MutateCSharp.Schemata245.ReplacePostfixUnaryExprOp_4(44L, ref i))
                {
                    dotToSlashPath += parts[i];

                    if (MutateCSharp.Schemata245.ReplaceBinExprOp_3(58L, i, MutateCSharp.Schemata245.ReplaceBinExprOp_5(49L, parts.Length, MutateCSharp.Schemata245.ReplaceNumericConstant_2(45L, 2))))
                    {
                        dotToSlashPath += MutateCSharp.Schemata245.ReplaceStringConstant_1(63L, "/");
                    }
                    else if (MutateCSharp.Schemata245.ReplaceBinExprOp_6(77L, i, MutateCSharp.Schemata245.ReplaceBinExprOp_5(68L, parts.Length, MutateCSharp.Schemata245.ReplaceNumericConstant_2(64L, 2))))
                    {
                        // extension
                        dotToSlashPath += MutateCSharp.Schemata245.ReplaceStringConstant_1(82L, ".");
                    }
                }

                var containingDirectory = Path.Combine(runtimeDirectory, Path.GetDirectoryName(dotToSlashPath));
                if (!Directory.Exists(containingDirectory))
                {
                    Directory.CreateDirectory(containingDirectory);
                }

                using var outFile = new FileStream(Path.Combine(runtimeDirectory, dotToSlashPath), FileMode.Create, FileAccess.Write);
                stream.CopyTo(outFile);
            });

            using (var cargoToml = new FileStream(Path.Combine(targetDirectory, MutateCSharp.Schemata245.ReplaceStringConstant_1(83L, "Cargo.toml")), FileMode.Create, FileAccess.Write))
            {
                using var cargoTomlWriter = new StreamWriter(cargoToml);
                await cargoTomlWriter.WriteLineAsync(MutateCSharp.Schemata245.ReplaceStringConstant_1(84L, "[package]"));
                var packageName = Path.GetFileNameWithoutExtension(targetFilename);
                // package name cannot start with a digit
                if (char.IsDigit(packageName[MutateCSharp.Schemata245.ReplaceNumericConstant_2(85L, 0)]))
                {
                    packageName = MutateCSharp.Schemata245.ReplaceStringConstant_1(89L, "_") + packageName;
                }
                await cargoTomlWriter.WriteLineAsync($"name = \"{packageName}\"");
                await cargoTomlWriter.WriteLineAsync(MutateCSharp.Schemata245.ReplaceStringConstant_1(90L, "version = \"0.1.0\""));
                await cargoTomlWriter.WriteLineAsync(MutateCSharp.Schemata245.ReplaceStringConstant_1(91L, "edition = \"2021\""));
                await cargoTomlWriter.WriteLineAsync();
                await cargoTomlWriter.WriteLineAsync(MutateCSharp.Schemata245.ReplaceStringConstant_1(92L, "[dependencies]"));
                await cargoTomlWriter.WriteLineAsync(MutateCSharp.Schemata245.ReplaceStringConstant_1(93L, "dafny_runtime = { path = \"runtime\" }"));
                await cargoTomlWriter.WriteLineAsync();

                if (callToMain == null)
                {
                    await cargoTomlWriter.WriteLineAsync(MutateCSharp.Schemata245.ReplaceStringConstant_1(94L, "[lib]"));
                    await cargoTomlWriter.WriteLineAsync(MutateCSharp.Schemata245.ReplaceStringConstant_1(95L, "path = \"src/") + Path.GetFileName(targetFilename) + MutateCSharp.Schemata245.ReplaceStringConstant_1(96L, "\""));
                    await cargoTomlWriter.WriteLineAsync();
                }
                else
                {
                    await cargoTomlWriter.WriteLineAsync(MutateCSharp.Schemata245.ReplaceStringConstant_1(97L, "[[bin]]"));
                    await cargoTomlWriter.WriteLineAsync($"name = \"{Path.GetFileNameWithoutExtension(targetFilename)}\"");
                    await cargoTomlWriter.WriteLineAsync(MutateCSharp.Schemata245.ReplaceStringConstant_1(98L, "path = \"src/") + Path.GetFileName(targetFilename) + MutateCSharp.Schemata245.ReplaceStringConstant_1(99L, "\""));
                    await cargoTomlWriter.WriteLineAsync();
                }
            }

            var args = new List<string>
            {
                MutateCSharp.Schemata245.ReplaceStringConstant_1(100L, "build"),
                MutateCSharp.Schemata245.ReplaceStringConstant_1(101L, "--quiet"
        )
            };

            if (callToMain == null)
            {
                args.Add(MutateCSharp.Schemata245.ReplaceStringConstant_1(102L, "--lib"));
            }
            else
            {
                args.Add(MutateCSharp.Schemata245.ReplaceStringConstant_1(103L, "--bin"));
                args.Add(Path.GetFileNameWithoutExtension(targetFilename));
            }

            var psi = PrepareProcessStartInfo(MutateCSharp.Schemata245.ReplaceStringConstant_1(104L, "cargo"), args);
            psi.WorkingDirectory = targetDirectory;
            return (MutateCSharp.Schemata245.ReplaceBinExprOp_6(110L, MutateCSharp.Schemata245.ReplaceNumericConstant_2(105L, 0), await RunProcess(psi, outputWriter, outputWriter, MutateCSharp.Schemata245.ReplaceStringConstant_1(109L, "Error while compiling Rust files."))), null);
        }
        public override Encoding OutputWriterEncoding => Encoding.UTF8;

        public override async Task<bool> RunTargetProgram(string dafnyProgramName, string targetProgramText,
          string callToMain, /*?*/
          string targetFilename, ReadOnlyCollection<string> otherFileNames, object compilationResult, TextWriter outputWriter,
          TextWriter errorWriter)
        {
            Contract.Requires(targetFilename != null || otherFileNames.Count == 0);
            var psi = PrepareProcessStartInfo(ComputeExeName(targetFilename), Options.MainArgs);
            return MutateCSharp.Schemata245.ReplaceBinExprOp_6(119L, MutateCSharp.Schemata245.ReplaceNumericConstant_2(115L, 0), await RunProcess(psi, outputWriter, errorWriter));
        }

        public RustBackend(DafnyOptions options) : base(options)
        {
        }
    }
}