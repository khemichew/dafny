using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using Dafny;
namespace MutateCSharp
{
    internal class Schemata225
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT225");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny.Compilers
{
    public abstract class DafnyExecutableBackend : ExecutableBackend
    {

        protected virtual bool PreventShadowing => MutateCSharp.Schemata225.ReplaceBooleanConstant_0(1L, true);
        protected virtual bool CanEmitUncompilableCode => MutateCSharp.Schemata225.ReplaceBooleanConstant_0(2L, true);

        protected DafnyWrittenCodeGenerator DafnyCodeGenerator;

        protected DafnyExecutableBackend(DafnyOptions options) : base(options)
        {
        }

        protected override SinglePassCodeGenerator CreateCodeGenerator()
        {
            // becomes this.compiler
            return new DafnyCodeGenerator(Options, Reporter, PreventShadowing, CanEmitUncompilableCode);
        }

        protected abstract DafnyWrittenCodeGenerator CreateDafnyWrittenCompiler();

        public override void OnPreCompile(ErrorReporter reporter, ReadOnlyCollection<string> otherFileNames)
        {
            base.OnPreCompile(reporter, otherFileNames);
            DafnyCodeGenerator = CreateDafnyWrittenCompiler();
        }

        public override void Compile(Program dafnyProgram, string dafnyProgramName, ConcreteSyntaxTree output)
        {
            ProcessTranslationRecords(dafnyProgram, dafnyProgramName, output);
            CheckInstantiationReplaceableModules(dafnyProgram);
            ProcessOuterModules(dafnyProgram);

            ((DafnyCodeGenerator)codeGenerator).Start();
            codeGenerator.Compile(dafnyProgram, new ConcreteSyntaxTree());
            var dast = ((DafnyCodeGenerator)codeGenerator).Build();
            var o = DafnyCodeGenerator.Compile((Sequence<DAST.Module>)Sequence<DAST.Module>.FromArray(dast.ToArray()));
            output.Write(o.ToVerbatimString(MutateCSharp.Schemata225.ReplaceBooleanConstant_0(3L, false)));
        }

        public override void EmitCallToMain(Method mainMethod, string baseName, ConcreteSyntaxTree output)
        {
            var o = DafnyCodeGenerator.EmitCallToMain(mainMethod.FullSanitizedName);
            output.Write(o.ToVerbatimString(MutateCSharp.Schemata225.ReplaceBooleanConstant_0(4L, false)));
        }

    }
}
