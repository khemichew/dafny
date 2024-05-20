#nullable enable
using System.Collections.Generic;
using System.Linq;
using DafnyCore;
using VCGeneration;
namespace MutateCSharp
{
    internal class Schemata315
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT315");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBooleanConstant_3(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.DafnyModel argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() || argument2();
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static string ReplaceStringConstant_2(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public static class ErrorReporterExtensions
    {
        public static void ReportBoogieError(this ErrorReporter reporter, ErrorInformation error, DafnyModel? counterexampleModel = null, bool useRange = true)
        {
            var usingSnippets = reporter.Options.Get(Snippets.ShowSnippets);
            var relatedInformation = new List<DafnyRelatedInformation>();
            foreach (var auxiliaryInformation in error.Aux)
            {
                if (MutateCSharp.Schemata315.ReplaceBinExprOp_1(3L, () => MutateCSharp.Schemata315.ReplaceBinExprOp_0(1L, auxiliaryInformation.Category, RelatedMessageCategory), () => MutateCSharp.Schemata315.ReplaceBinExprOp_0(2L, auxiliaryInformation.Category, AssertedExprCategory)))
                {
                    error.Msg += MutateCSharp.Schemata315.ReplaceStringConstant_2(9L, "\n") + auxiliaryInformation.FullMsg;
                }
                else if (MutateCSharp.Schemata315.ReplaceBinExprOp_0(10L, auxiliaryInformation.Category, RelatedLocationCategory))
                {
                    relatedInformation.AddRange(CreateDiagnosticRelatedInformationFor(BoogieGenerator.ToDafnyToken(MutateCSharp.Schemata315.ReplaceBooleanConstant_3(11L, true), auxiliaryInformation.Tok), auxiliaryInformation.Msg, usingSnippets));
                }
                else
                {
                    // The execution trace is an additional auxiliary which identifies itself with
                    // line=0 and character=0. These positions cause errors when exposing them, Furthermore,
                    // the execution trace message appears to not have any interesting information.
                    if (MutateCSharp.Schemata315.ReplaceBinExprOp_5(16L, auxiliaryInformation.Tok.line, MutateCSharp.Schemata315.ReplaceNumericConstant_4(12L, 0)))
                    {
                        reporter.Info(MessageSource.Verifier, BoogieGenerator.ToDafnyToken(MutateCSharp.Schemata315.ReplaceBooleanConstant_3(21L, true), auxiliaryInformation.Tok), auxiliaryInformation.Msg);
                    }
                }
            }

            if (MutateCSharp.Schemata315.ReplaceBinExprOp_6(22L, counterexampleModel, null))
            {
                error.Msg += MutateCSharp.Schemata315.ReplaceStringConstant_2(23L, "\n") + $"Related counterexample:\n{counterexampleModel}";
            }

            if (error.Tok is NestedToken { Inner: var innerToken, Message: var msg })
            {
                relatedInformation.AddRange(CreateDiagnosticRelatedInformationFor(innerToken, msg, usingSnippets));
            }

            var dafnyToken = BoogieGenerator.ToDafnyToken(useRange, error.Tok);

            var tokens = new[] { dafnyToken }.Concat(relatedInformation.Select(i => i.Token)).ToList();
            IToken previous = tokens.Last();
            foreach (var (inner, outer) in relatedInformation.Zip(tokens).Reverse())
            {
                previous = new NestedToken(outer, previous, inner.Message);
            }
            reporter.Message(MessageSource.Verifier, ErrorLevel.Error, null, previous, error.Msg);
        }

        private const string RelatedLocationCategory = "Related location";
        public const string RelatedLocationMessage = RelatedLocationCategory;
        private const string RelatedMessageCategory = "Related message";
        public const string AssertedExprCategory = "Asserted expression";
        public static readonly string PostConditionFailingMessage = new ProofObligationDescription.EnsuresDescription(null, null).FailureDescription;
        private static string FormatRelated(string related)
        {
            return $"Could not prove: {related}";
        }

        public static IEnumerable<DafnyRelatedInformation> CreateDiagnosticRelatedInformationFor(IToken token, string? message, bool usingSnippets)
        {
            var (tokenForMessage, inner, newMessage) = token is NestedToken nestedToken ? (nestedToken.Outer, nestedToken.Inner, nestedToken.Message) : (token, null, null);
            var dafnyToken = BoogieGenerator.ToDafnyToken(MutateCSharp.Schemata315.ReplaceBooleanConstant_3(24L, true), tokenForMessage);
            if (!usingSnippets && dafnyToken is RangeToken rangeToken)
            {
                if (MutateCSharp.Schemata315.ReplaceBinExprOp_0(25L, message, PostConditionFailingMessage))
                {
                    var postcondition = rangeToken.PrintOriginal();
                    message = $"this postcondition might not hold: {postcondition}";
                }
                else if (MutateCSharp.Schemata315.ReplaceBinExprOp_1(27L, () => message == null, () => MutateCSharp.Schemata315.ReplaceBinExprOp_0(26L, message, RelatedLocationMessage)))
                {
                    message = FormatRelated(rangeToken.PrintOriginal());
                }
            }

            message ??= MutateCSharp.Schemata315.ReplaceStringConstant_2(33L, "this proposition could not be proved");

            yield return new DafnyRelatedInformation(token, message);
            if (MutateCSharp.Schemata315.ReplaceBinExprOp_7(34L, inner, null))
            {
                foreach (var nestedInformation in CreateDiagnosticRelatedInformationFor(inner, newMessage, usingSnippets))
                {
                    yield return nestedInformation;
                }
            }

            yield break;
        }
    }
}