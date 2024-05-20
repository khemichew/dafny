#nullable enable
using System;
using System.Collections.Generic;
using System.Reactive.Subjects;
using System.Threading;
using DafnyCore;
using Microsoft.Dafny.LanguageServer.Workspace;
namespace MutateCSharp
{
    internal class Schemata351
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT351");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 + argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.MessageSource argument1, Microsoft.Dafny.MessageSource argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.ErrorLevel argument1, Microsoft.Dafny.ErrorLevel argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceNumericConstant_3(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

    }
}

namespace Microsoft.Dafny
{
    public class ObservableErrorReporter : ErrorReporter
    {
        private readonly Subject<NewDiagnostic> updates = new();
        public IObservable<NewDiagnostic> Updates => updates;

        private readonly Uri entryUri;
        private readonly Dictionary<ErrorLevel, int> counts = new();
        private readonly Dictionary<ErrorLevel, int> countsNotVerificationOrCompiler = new();
        private readonly ReaderWriterLockSlim rwLock = new();

        /// <summary>
        /// Creates a new instance with the given uri of the entry document.
        /// </summary>
        /// <param name="entryUri">The entry document's uri.</param>
        /// <remarks>
        /// The uri of the entry document is necessary to report general compiler errors as part of this document.
        /// </remarks>
        public ObservableErrorReporter(DafnyOptions options, Uri entryUri) : base(options)
        {
            this.entryUri = entryUri;
        }

        protected override bool MessageCore(MessageSource source, ErrorLevel level, string? errorId, IToken rootTok, string msg)
        {
            if (MutateCSharp.Schemata351.ReplaceBinExprOp_1(2L, () => ErrorsOnly, () => MutateCSharp.Schemata351.ReplaceBinExprOp_0(1L, level, ErrorLevel.Error)))
            {
                return MutateCSharp.Schemata351.ReplaceBooleanConstant_2(8L, false);
            }
            var relatedInformation = new List<DafnyRelatedInformation>();

            var usingSnippets = Options.Get(Snippets.ShowSnippets);
            if (rootTok is NestedToken nestedToken)
            {
                relatedInformation.AddRange(
                  ErrorReporterExtensions.CreateDiagnosticRelatedInformationFor(
                    nestedToken.Inner, nestedToken.Message, usingSnippets)
                );
            }

            var dafnyDiagnostic = new DafnyDiagnostic(new MessageSourceBasedPhase(source), errorId!, rootTok, msg, source, level, relatedInformation);
            AddDiagnosticForFile(dafnyDiagnostic, GetUriOrDefault(rootTok));
            return MutateCSharp.Schemata351.ReplaceBooleanConstant_2(9L, true);
        }

        public override int Count(ErrorLevel level)
        {
            rwLock.EnterReadLock();
            try
            {
                return counts.GetValueOrDefault(level, MutateCSharp.Schemata351.ReplaceNumericConstant_3(10L, 0));
            }
            finally
            {
                rwLock.ExitReadLock();
            }

            return default;
        }

        public override int CountExceptVerifierAndCompiler(ErrorLevel level)
        {
            rwLock.EnterReadLock();
            try
            {
                return countsNotVerificationOrCompiler.GetValueOrDefault(level, MutateCSharp.Schemata351.ReplaceNumericConstant_3(14L, 0));
            }
            finally
            {
                rwLock.ExitReadLock();
            }

            return default;
        }

        private void AddDiagnosticForFile(DafnyDiagnostic dafnyDiagnostic, Uri uri)
        {
            rwLock.EnterWriteLock();
            try
            {
                counts[dafnyDiagnostic.Level] = MutateCSharp.Schemata351.ReplaceBinExprOp_4(26L, counts.GetValueOrDefault(dafnyDiagnostic.Level, MutateCSharp.Schemata351.ReplaceNumericConstant_3(18L, 0)), MutateCSharp.Schemata351.ReplaceNumericConstant_3(22L, 1));
                if (MutateCSharp.Schemata351.ReplaceBinExprOp_1(37L, () => MutateCSharp.Schemata351.ReplaceBinExprOp_5(35L, dafnyDiagnostic.Source, MessageSource.Verifier), () => MutateCSharp.Schemata351.ReplaceBinExprOp_5(36L, dafnyDiagnostic.Source, MessageSource.Compiler)))
                {
                    countsNotVerificationOrCompiler[dafnyDiagnostic.Level] =
          MutateCSharp.Schemata351.ReplaceBinExprOp_4(51L, countsNotVerificationOrCompiler.GetValueOrDefault(dafnyDiagnostic.Level, MutateCSharp.Schemata351.ReplaceNumericConstant_3(43L, 0)), MutateCSharp.Schemata351.ReplaceNumericConstant_3(47L, 1));
                }
                updates.OnNext(new NewDiagnostic(uri, dafnyDiagnostic));
            }
            finally
            {
                rwLock.ExitWriteLock();
            }
        }

        private Uri GetUriOrDefault(IToken token)
        {
            return token.Filepath == null
              ? entryUri
              : token.Uri;
        }
    }
}
