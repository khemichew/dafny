using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.CommandLine;
using System.Diagnostics.Contracts;
using System.IO;
using System.Threading.Tasks;
namespace MutateCSharp
{
    internal class Schemata216
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT216");
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

        internal static int ReplaceNumericConstant_1(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_3(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny.Compilers
{
    public class CppBackend : ExecutableBackend
    {

        protected override SinglePassCodeGenerator CreateCodeGenerator()
        {
            return new CppCodeGenerator(Options, Reporter, OtherFileNames);
        }

        private string ComputeExeName(string targetFilename)
        {
            return Path.ChangeExtension(Path.GetFullPath(targetFilename), MutateCSharp.Schemata216.ReplaceStringConstant_0(1L, "exe"));
        }

        public override async Task<(bool Success, object CompilationResult)> CompileTargetProgram(string dafnyProgramName,
          string targetProgramText,
          string callToMain /*?*/, string targetFilename /*?*/, ReadOnlyCollection<string> otherFileNames,
          bool runAfterCompile, TextWriter outputWriter)
        {
            var assemblyLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;
            Contract.Assert(assemblyLocation != null);
            var codebase = Path.GetDirectoryName(assemblyLocation);
            Contract.Assert(codebase != null);
            var psi = PrepareProcessStartInfo(MutateCSharp.Schemata216.ReplaceStringConstant_0(2L, "g++"), new List<string> { MutateCSharp.Schemata216.ReplaceStringConstant_0(3L, "-Wall"),
MutateCSharp.Schemata216.ReplaceStringConstant_0(4L, "-Wextra"),
MutateCSharp.Schemata216.ReplaceStringConstant_0(5L, "-Wpedantic"),
MutateCSharp.Schemata216.ReplaceStringConstant_0(6L, "-Wno-unused-variable"),
MutateCSharp.Schemata216.ReplaceStringConstant_0(7L, "-Wno-deprecated-copy"),
MutateCSharp.Schemata216.ReplaceStringConstant_0(8L, "-Wno-unused-label"),
MutateCSharp.Schemata216.ReplaceStringConstant_0(9L, "-Wno-unused-but-set-variable"),
MutateCSharp.Schemata216.ReplaceStringConstant_0(10L, "-Wno-unknown-warning-option"),
MutateCSharp.Schemata216.ReplaceStringConstant_0(11L, "-g"),
MutateCSharp.Schemata216.ReplaceStringConstant_0(12L, "-std=c++17"),
MutateCSharp.Schemata216.ReplaceStringConstant_0(13L, "-I"), codebase,
MutateCSharp.Schemata216.ReplaceStringConstant_0(14L, "-o"), ComputeExeName(targetFilename),
      targetFilename
    });
            return (MutateCSharp.Schemata216.ReplaceBinExprOp_2(20L, MutateCSharp.Schemata216.ReplaceNumericConstant_1(15L, 0), await RunProcess(psi, outputWriter, outputWriter, MutateCSharp.Schemata216.ReplaceStringConstant_0(19L, "Error while compiling C++ files."))), null);
        }

        public override async Task<bool> RunTargetProgram(string dafnyProgramName, string targetProgramText,
          string callToMain, /*?*/
          string targetFilename, ReadOnlyCollection<string> otherFileNames,
          object compilationResult, TextWriter outputWriter, TextWriter errorWriter)
        {
            var psi = PrepareProcessStartInfo(ComputeExeName(targetFilename), Options.MainArgs);
            return MutateCSharp.Schemata216.ReplaceBinExprOp_2(29L, MutateCSharp.Schemata216.ReplaceNumericConstant_1(25L, 0), await RunProcess(psi, outputWriter, errorWriter));
        }

        public override Command GetCommand()
        {
            var cmd = base.GetCommand();
            cmd.Description = $@"Translate Dafny sources to {TargetName} source and build files.

This back-end has various limitations (see Docs/Compilation/Cpp.md).
This includes lack of support for BigIntegers (aka int), most higher order functions,
and advanced features like traits or co-inductive types.";
            return cmd;
        }

        public override IReadOnlySet<string> SupportedExtensions => new HashSet<string> { MutateCSharp.Schemata216.ReplaceStringConstant_0(34L, ".h") };

        public override string TargetName => MutateCSharp.Schemata216.ReplaceStringConstant_0(35L, "C++");
        public override bool IsStable => MutateCSharp.Schemata216.ReplaceBooleanConstant_3(36L, true);
        public override string TargetExtension => MutateCSharp.Schemata216.ReplaceStringConstant_0(37L, "cpp");

        public override bool SupportsInMemoryCompilation => MutateCSharp.Schemata216.ReplaceBooleanConstant_3(38L, false);

        public override bool TextualTargetIsExecutable => MutateCSharp.Schemata216.ReplaceBooleanConstant_3(39L, false);

        public CppBackend(DafnyOptions options) : base(options)
        {
        }
    }
}