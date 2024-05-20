using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata478
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT478");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_4(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.Triggers.TriggerTerm.TermComparison argument1, Microsoft.Dafny.Triggers.TriggerTerm.TermComparison argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.Triggers.TriggerCandidate argument1, Microsoft.Dafny.Triggers.TriggerCandidate argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny.Triggers
{
    public
/// <summary>
/// A trigger consist of a number of terms
/// </summary>
class TriggerCandidate
    {
        internal List<TriggerTerm> Terms { get; set; }
        internal string Annotation { get; set; }

        internal TriggerCandidate(List<TriggerTerm> terms)
        {
            this.Terms = terms;
        }

        public TriggerCandidate(TriggerCandidate candidate)
        {
            this.Terms = candidate.Terms;
        }

        internal bool MentionsAll(List<BoundVar> vars)
        {
            return vars.All(x => Terms.Any(term => term.Variables.Contains(x)));
        }

        private string Repr => String.Join(MutateCSharp.Schemata478.ReplaceStringConstant_0(1L, ", "), Terms);

        public override string ToString()
        {
            return MutateCSharp.Schemata478.ReplaceStringConstant_0(2L, "{") + Repr + MutateCSharp.Schemata478.ReplaceStringConstant_0(3L, "}") + (String.IsNullOrWhiteSpace(Annotation) ? "" : MutateCSharp.Schemata478.ReplaceStringConstant_0(4L, " (") + Annotation + MutateCSharp.Schemata478.ReplaceStringConstant_0(5L, ")"));
        }

        /// <summary>
        /// See section 2.2 of "Trigger Selection Strategies to Stabilize Program Verifiers" to learn
        /// how we find potentially looping subterms.
        /// 
        /// Roughly, this heuristic flags a trigger as potentially looping if
        /// instantiating the quantifier may lead to a ground term that again matches the trigger
        /// </summary>
        internal IEnumerable<TriggerMatch> LoopingSubterms(ComprehensionExpr quantifier, DafnyOptions options)
        {
            Contract.Requires(!(quantifier is QuantifierExpr) || ((QuantifierExpr)quantifier).SplitQuantifier == null); // Don't call this on a quantifier with a Split clause: it's not a real quantifier
            var matchingSubterms = MatchingSubterms(quantifier);
            var boundVars = new HashSet<BoundVar>(quantifier.BoundVars);
            return matchingSubterms.Where(tm => tm.CouldCauseLoops(Terms, boundVars, options));
        }

        private List<TriggerMatch> MatchingSubterms(ComprehensionExpr quantifier)
        {
            Contract.Requires(!(quantifier is QuantifierExpr) || ((QuantifierExpr)quantifier).SplitQuantifier == null); // Don't call this on a quantifier with a Split clause: it's not a real quantifier
            return Terms.SelectMany(term => quantifier.SubexpressionsMatchingTrigger(term.Expr)).Deduplicate(TriggerMatch.Eq);
        }

        internal bool IsStrongerThan(TriggerCandidate that)
        {
            if (MutateCSharp.Schemata478.ReplaceBinExprOp_1(6L, this, that))
            {
                return MutateCSharp.Schemata478.ReplaceBooleanConstant_2(7L, false);
            }

            var hasStrictlyStrongerTerm = MutateCSharp.Schemata478.ReplaceBooleanConstant_2(8L, false);
            foreach (var t in Terms)
            {
                var comparison = that.Terms.Select(t.CompareTo).Max();

                // All terms of `this` must be at least as strong as a term of `that`
                if (MutateCSharp.Schemata478.ReplaceBinExprOp_3(9L, comparison, TriggerTerm.TermComparison.NotStronger)) { return MutateCSharp.Schemata478.ReplaceBooleanConstant_2(10L, false); }

                // Did we find a strictly stronger term?
                hasStrictlyStrongerTerm = MutateCSharp.Schemata478.ReplaceBinExprOp_4(12L, () => hasStrictlyStrongerTerm, () => MutateCSharp.Schemata478.ReplaceBinExprOp_3(11L, comparison, TriggerTerm.TermComparison.Stronger));
            }

            return hasStrictlyStrongerTerm;
        }
    }
}