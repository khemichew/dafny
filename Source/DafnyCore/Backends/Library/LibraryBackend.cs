using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using DafnyCore;
namespace MutateCSharp
{
    internal class Schemata239
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT239");
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

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny.Compilers
{
    public class LibraryBackend : ExecutableBackend
    {
        public LibraryBackend(DafnyOptions options) : base(options)
        {
        }

        public override IReadOnlySet<string> SupportedExtensions => new HashSet<string> { };

        public override string TargetName => MutateCSharp.Schemata239.ReplaceStringConstant_0(1L, "Dafny Library (.doo)");

        /// Some tests still fail when using the lib back-end, for example due to disallowed assumptions being present in the test,
        /// such as empty constructors with ensures clauses, generated from iterators
        public override bool IsStable => MutateCSharp.Schemata239.ReplaceBooleanConstant_1(2L, false);

        public override string TargetExtension => MutateCSharp.Schemata239.ReplaceStringConstant_0(3L, "doo");
        public override string TargetId => MutateCSharp.Schemata239.ReplaceStringConstant_0(4L, "lib");

        public override string TargetBaseDir(string dafnyProgramName) =>
          $"{Path.GetFileNameWithoutExtension(dafnyProgramName)}-lib";

        public override bool TextualTargetIsExecutable => MutateCSharp.Schemata239.ReplaceBooleanConstant_1(5L, false);

        public override bool SupportsInMemoryCompilation => MutateCSharp.Schemata239.ReplaceBooleanConstant_1(6L, false);

        public override IReadOnlySet<Feature> UnsupportedFeatures => new HashSet<Feature> {
    Feature.LegacyCLI,
    Feature.RuntimeCoverageReport
  };

        // Necessary since Compiler is null
        public override string ModuleSeparator => MutateCSharp.Schemata239.ReplaceStringConstant_0(7L, ".");

        public string DooPath { get; set; }

        protected override SinglePassCodeGenerator CreateCodeGenerator()
        {
            return null;
        }

        public override Task<bool> OnPostGenerate(string dafnyProgramName, string targetFilename, TextWriter outputWriter)
        {
            // Not calling base.OnPostCompile() since it references `compiler`
            return Task.FromResult(MutateCSharp.Schemata239.ReplaceBooleanConstant_1(8L, true));
        }

        public override string PublicIdProtect(string name)
        {
            throw new NotSupportedException();
            return default;
        }

        public override void Compile(Program dafnyProgram, string dafnyProgramName, ConcreteSyntaxTree output)
        {
            if (!Options.UsingNewCli)
            {
                throw new UnsupportedFeatureException(dafnyProgram.GetStartOfFirstFileToken(), Feature.LegacyCLI);
            }

            var dooFile = new DooFile(dafnyProgram.AfterParsingClone);
            dooFile.Write(output);
        }

        public override void EmitCallToMain(Method mainMethod, string baseName, ConcreteSyntaxTree callToMainTree)
        {
            // No-op
        }

        private string DooFilePath(string dafnyProgramName)
        {
            return Path.GetFullPath(Path.ChangeExtension(dafnyProgramName, DooFile.Extension));
        }

        public override async Task<(bool Success, object CompilationResult)> CompileTargetProgram(string dafnyProgramName,
          string targetProgramText, string callToMain,
          string targetFilename,
          ReadOnlyCollection<string> otherFileNames, bool runAfterCompile, TextWriter outputWriter)
        {

            var targetDirectory = Path.GetFullPath(Path.GetDirectoryName(targetFilename));
            DooPath = DooFilePath(dafnyProgramName);

            File.Delete(DooPath);

            try
            {
                ZipFile.CreateFromDirectory(targetDirectory, DooPath);
            }
            catch (IOException)
            {
                if (File.Exists(DooPath))
                {
                    await outputWriter.WriteLineAsync($"Failed to delete doo file at {DooPath}");
                }

                throw;
            }
            if (Options.Verbose)
            {
                await outputWriter.WriteLineAsync($"Wrote Dafny library to {DooPath}");
            }

            return (MutateCSharp.Schemata239.ReplaceBooleanConstant_1(9L, true), null);
        }

        public override Task<bool> RunTargetProgram(string dafnyProgramName, string targetProgramText, string callToMain,
          string targetFilename,
          ReadOnlyCollection<string> otherFileNames, object compilationResult, TextWriter outputWriter,
          TextWriter errorWriter)
        {
            var dooPath = DooFilePath(dafnyProgramName);
            return RunTargetDafnyProgram(dooPath, outputWriter, errorWriter, MutateCSharp.Schemata239.ReplaceBooleanConstant_1(10L, true));
        }
    }
}