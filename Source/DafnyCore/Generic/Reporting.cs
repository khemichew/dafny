// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
#nullable enable
using System.Collections.Generic;
using System.CommandLine;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata316
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT316");
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

        internal static int ReplaceNumericConstant_1(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.ErrorLevel argument1, Microsoft.Dafny.ErrorLevel argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{

    public record MessageSourceBasedPhase(MessageSource MessageSource) : IPhase
    {
        public IPhase? Parent => null;
    }

    public record SingletonPhase(IPhase Parent, object Key) : IPhase;


    /// <summary>
    /// A phase of compilation
    /// 
    /// A phases can have a parent, and so phases form a tree.
    ///
    /// The children of a phase, are the phases that are discovered and completed as phase of that parent.
    /// </summary>
    public interface IPhase
    {
        IPhase? Parent { get; }
    }

    public enum ErrorLevel
    {
        Info, Warning, Error
    }

    public enum MessageSource
    {
        Project, Parser, Cloner, RefinementTransformer, Rewriter, Resolver, Translator, Verifier, Compiler, Documentation, TestGeneration
    }

    public record DafnyRelatedInformation(IToken Token, string Message);
    public record DafnyDiagnostic(IPhase Phase, string ErrorId, IToken Token, string Message,
      MessageSource Source, ErrorLevel Level,
      IReadOnlyList<DafnyRelatedInformation> RelatedInformation);

    public class ErrorReporterSink : ErrorReporter
    {
        public ErrorReporterSink(DafnyOptions options) : base(options) { }

        protected override bool MessageCore(MessageSource source, ErrorLevel level, string errorId, IToken tok, string msg)
        {
            return MutateCSharp.Schemata316.ReplaceBooleanConstant_0(1L, false);
        }

        public override void Error(MessageSource source, string errorId, IToken tok, string msg)
        {

        }

        public override int Count(ErrorLevel level)
        {
            return MutateCSharp.Schemata316.ReplaceNumericConstant_1(2L, 0);
        }

        public override int CountExceptVerifierAndCompiler(ErrorLevel level)
        {
            return MutateCSharp.Schemata316.ReplaceNumericConstant_1(6L, 0);
        }
    }

    public class ErrorReporterWrapper : BatchErrorReporter
    {

        private string msgPrefix;
        public readonly ErrorReporter WrappedReporter;

        public ErrorReporterWrapper(ErrorReporter reporter, string msgPrefix) : base(reporter.Options)
        {
            this.msgPrefix = msgPrefix;
            this.WrappedReporter = reporter;
        }

        protected override bool MessageCore(MessageSource source, ErrorLevel level, string errorId, IToken tok, string msg)
        {
            if (MutateCSharp.Schemata316.ReplaceBinExprOp_2(10L, level, ErrorLevel.Warning))
            {
                return MutateCSharp.Schemata316.ReplaceBooleanConstant_0(11L, false);
            }

            base.MessageCore(source, level, errorId, tok, msg);
            return WrappedReporter.Message(source, level, errorId, tok, msgPrefix + msg);
        }
    }
}
