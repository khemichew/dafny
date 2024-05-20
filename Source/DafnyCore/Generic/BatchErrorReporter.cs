using System.Collections.Generic;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata300
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT300");
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

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.ErrorLevel argument1, Microsoft.Dafny.ErrorLevel argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() && argument2();
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.MessageSource argument1, Microsoft.Dafny.MessageSource argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class BatchErrorReporter : ErrorReporter
    {
        public Dictionary<ErrorLevel, List<DafnyDiagnostic>> AllMessagesByLevel;
        public readonly List<DafnyDiagnostic> AllMessages = new();

        public void CopyDiagnostics(ErrorReporter intoReporter)
        {
            foreach (var diagnostic in AllMessages)
            {
                intoReporter.Message(diagnostic.Source, diagnostic.Level, diagnostic.ErrorId, diagnostic.Token, diagnostic.Message);
            }
        }

        public BatchErrorReporter(DafnyOptions options) : base(options)
        {
            ErrorsOnly = MutateCSharp.Schemata300.ReplaceBooleanConstant_0(1L, false);
            AllMessagesByLevel = new Dictionary<ErrorLevel, List<DafnyDiagnostic>>
            {
                [ErrorLevel.Error] = new(),
                [ErrorLevel.Warning] = new(),
                [ErrorLevel.Info] = new()
            };
        }

        protected override bool MessageCore(MessageSource source, ErrorLevel level, string errorId, IToken tok, string msg)
        {
            if (MutateCSharp.Schemata300.ReplaceBinExprOp_2(3L, () => ErrorsOnly, () => MutateCSharp.Schemata300.ReplaceBinExprOp_1(2L, level, ErrorLevel.Error)))
            {
                // discard the message
                return MutateCSharp.Schemata300.ReplaceBooleanConstant_0(9L, false);
            }

            var dafnyDiagnostic = new DafnyDiagnostic(new MessageSourceBasedPhase(source), errorId, tok, msg, source, level, new List<DafnyRelatedInformation>());
            AllMessages.Add(dafnyDiagnostic);
            AllMessagesByLevel[level].Add(dafnyDiagnostic);
            return MutateCSharp.Schemata300.ReplaceBooleanConstant_0(10L, true);
        }

        public override int Count(ErrorLevel level)
        {
            return AllMessagesByLevel[level].Count;
        }

        public override int CountExceptVerifierAndCompiler(ErrorLevel level)
        {
            return AllMessagesByLevel[level].Count(message => MutateCSharp.Schemata300.ReplaceBinExprOp_2(13L, () => MutateCSharp.Schemata300.ReplaceBinExprOp_3(11L, message.Source, MessageSource.Verifier), () => MutateCSharp.Schemata300.ReplaceBinExprOp_3(12L, message.Source, MessageSource.Compiler)));
        }
    }
}
