using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.Dafny.Plugins;
namespace MutateCSharp
{
    internal class Schemata350
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT350");
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

    }
}

namespace Microsoft.Dafny
{
    public class NoExecutableBackend : IExecutableBackend
    {
        public override IReadOnlySet<string> SupportedExtensions => new HashSet<string>();
        public override string TargetName => throw new NotSupportedException();
        public override bool IsStable => throw new NotSupportedException();
        public override string TargetExtension => MutateCSharp.Schemata350.ReplaceStringConstant_0(1L, "doesNotExist");
        public override string PublicIdProtect(string name)
        {
            throw new NotSupportedException();
            return default;
        }

        public override bool TextualTargetIsExecutable => throw new NotSupportedException();

        public override bool SupportsInMemoryCompilation => throw new NotSupportedException();
        public override string ModuleSeparator => MutateCSharp.Schemata350.ReplaceStringConstant_0(2L, ".");

        public override void Compile(Program dafnyProgram, string dafnyProgramName, ConcreteSyntaxTree output)
        {
            throw new NotSupportedException();
        }

        public override Task<bool> OnPostGenerate(string dafnyProgramName, string targetFilename, TextWriter outputWriter)
        {
            throw new NotSupportedException();
            return default;
        }

        public override void EmitCallToMain(Method mainMethod, string baseName, ConcreteSyntaxTree callToMainTree)
        {
            throw new NotSupportedException();
        }

        public override Task<(bool Success, object CompilationResult)> CompileTargetProgram(string dafnyProgramName,
          string targetProgramText, string callToMain,
          string targetFilename,
          ReadOnlyCollection<string> otherFileNames, bool runAfterCompile, TextWriter outputWriter)
        {
            throw new NotSupportedException();
            return default;
        }

        public override Task<bool> RunTargetProgram(string dafnyProgramName, string targetProgramText, string callToMain,
          string pathsFilename,
          ReadOnlyCollection<string> otherFileNames, object compilationResult, TextWriter outputWriter,
          TextWriter errorWriter)
        {
            throw new NotSupportedException();
            return default;
        }

        public override void InstrumentCompiler(CompilerInstrumenter instrumenter, Program dafnyProgram)
        {
            throw new NotSupportedException();
        }

        public NoExecutableBackend([NotNull] DafnyOptions options) : base(options)
        {
        }
    }
}