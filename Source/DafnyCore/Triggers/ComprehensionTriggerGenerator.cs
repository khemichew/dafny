// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT

using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.Contracts;
using DafnyCore.Generic;
namespace MutateCSharp
{
    internal class Schemata471
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT471");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static string ReplaceStringConstant_7(long mutantId, string argument1)
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

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_5(long mutantId, ref int argument1)
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

        internal static bool ReplaceBinExprOp_0(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

    }
}

namespace Microsoft.Dafny.Triggers
{
    public
      record QuantifierGroup(SplitPartTriggerWriter Quantifier, List<ComprehensionExpr> Expressions);

    public
      /// <summary>
      /// For a comprehension that has been split into parts, determine triggers for each part.
      ///
      /// See section 2.3 of "Trigger Selection Strategies to Stabilize Program Verifiers" to learn
      /// why we introduce these splits, and what interaction there is between the generation of their triggers.
      /// </summary>
      class ComprehensionTriggerGenerator
    {
        private readonly ErrorReporter reporter;
        private readonly ComprehensionExpr comprehension;  //  the expression where the splits are originated from
        private List<SplitPartTriggerWriter> partWriters;

        internal ComprehensionTriggerGenerator(ComprehensionExpr comprehension, IEnumerable<ComprehensionExpr> quantifiers, ErrorReporter reporter)
        {
            Contract.Requires(quantifiers.All(q => !(q is QuantifierExpr) || ((QuantifierExpr)q).SplitQuantifier == null));
            this.reporter = reporter;
            this.comprehension = comprehension;
            partWriters = quantifiers.Select(q => new SplitPartTriggerWriter(q)).ToList();
        }

        internal void ComputeTriggers(TriggersCollector triggersCollector)
        {
            CollectAndShareTriggers(triggersCollector);
            TrimInvalidTriggers();
            BuildDependenciesGraph();
            if (MutateCSharp.Schemata471.ReplaceBinExprOp_0(1L, () => DetectAndFilterLoopingCandidates(), () => RewriteMatchingLoop(triggersCollector.ForModule)))
            {
                CollectWithoutShareTriggers(triggersCollector);
                TrimInvalidTriggers();
                DetectAndFilterLoopingCandidates();
            }
            FilterWeakerTriggers();
            CombineSplitQuantifier();
        }

        private bool SubsetGenerationPredicate(TriggerTermSet terms, TriggerTerm additionalTerm)
        {
            return MutateCSharp.Schemata471.ReplaceBooleanConstant_1(7L, true); // FIXME Remove this
                                                                                //return additionalTerm.Variables.Where(v => v is BoundVar && !terms.Any(t => t.Variables.Contains(v))).Any();
        }

        /// <summary>
        /// Collect triggers from the body of each quantifier, and share them
        /// between all quantifiers. This method assumes that all quantifiers
        /// actually come from the same context, and were the result of a split that
        /// gave them all the same variables.
        /// 
        /// See section 2.1 of "Trigger Selection Strategies to Stabilize Program Verifiers" to learn
        /// how we collect triggers
        /// </summary>
        void CollectAndShareTriggers(TriggersCollector triggersCollector)
        {
            var pool = new List<TriggerTerm>();
            foreach (var triggerWriter in partWriters)
            {
                var candidates = triggersCollector.CollectTriggers(triggerWriter.Comprehension).Deduplicate(TriggerTerm.Eq);
                var greatTerms = candidates.Where(term => !triggersCollector.TranslateToFunctionCall(term.Expr)).ToList();
                if (greatTerms.Any())
                {
                    // If we have great terms, only use those
                    candidates = greatTerms;
                }
                pool.AddRange(candidates);
            }
            var distinctPool = pool.Deduplicate(TriggerTerm.Eq);

            foreach (var triggerWriter in partWriters)
            {
                triggerWriter.CandidateTerms = distinctPool; // The list of candidate terms is immutable
                triggerWriter.Candidates = TriggerTermSet.ComputeNonEmptyTriggerCandidatesTerms(LinkedLists.FromList(distinctPool), triggerWriter.Comprehension.BoundVars)
                  .Select(set => set.ToTriggerCandidate()).ToList();
            }
        }

        void CollectWithoutShareTriggers(TriggersCollector triggersCollector)
        {
            foreach (var triggerWriter in partWriters)
            {
                var candidates = triggersCollector.CollectTriggers(triggerWriter.Comprehension).Deduplicate(TriggerTerm.Eq);
                triggerWriter.CandidateTerms = candidates; // The list of candidate terms is immutable
                triggerWriter.Candidates = TriggerTermSet.ComputeNonEmptyTriggerCandidatesTerms(
                  LinkedLists.FromList(candidates), triggerWriter.Comprehension.BoundVars).
                  Select(set => set.ToTriggerCandidate()).ToList();
            }
        }

        private void TrimInvalidTriggers()
        {
            foreach (var triggerWriter in partWriters)
            {
                triggerWriter.TrimInvalidTriggers();
            }
        }

        void BuildDependenciesGraph()
        {
            // The problem of finding matching loops between multiple-triggers is hard; it
            // seems to require one to track exponentially-sized dependencies between parts
            // of triggers and quantifiers. For now, we only do single-quantifier loop
            // detection
        }

        bool DetectAndFilterLoopingCandidates()
        {
            // NOTE: This only looks for self-loops; that is, loops involving a single
            // quantifier.

            // For a given quantifier q, we introduce a triggering relation between trigger
            // candidates by writing t1 → t2 if instantiating q from t1 introduces a ground
            // term that matches t2. Then, we notice that this relation is transitive, since
            // all triggers yield the same set of terms. This means that any matching loop
            // t1 → ... → t1 can be reduced to a self-loop t1 → t1. Detecting such
            // self-loops is then only a matter of finding terms in the body of the
            // quantifier that match a given trigger.

            // Of course, each trigger that actually appears in the body of the quantifier
            // yields a trivial self-loop (e.g. P(i) in [∀ i {P(i)} ⋅ P(i)]), so we
            // ignore this type of loops. In fact, we ignore any term in the body of the
            // quantifier that matches one of the terms of the trigger (this ensures that
            // [∀ x {f(x), f(f(x))} ⋅ f(x) = f(f(x))] is not a loop). And we even
            // ignore terms that almost match a trigger term, modulo a single variable
            // (this ensures that [∀ x y {a(x, y)} ⋅ a(x, y) == a(y, x)] is not a loop).

            // In addition, we ignore cases where the only differences between a trigger
            // and a trigger match are places where a variable is replaced with an
            // expression whose free variables do not intersect that of the quantifier
            // in which that expression is found. For examples of this behavious, see
            // triggers/literals-do-not-cause-loops.
            // This ignoring logic is implemented by the CouldCauseLoops method.
            bool foundLoop = MutateCSharp.Schemata471.ReplaceBooleanConstant_1(8L, false);
            foreach (var quantifier in partWriters)
            {
                foundLoop |= quantifier.DetectAndFilterLoopingCandidates(reporter);
            }
            return foundLoop;
        }

        private bool RewriteMatchingLoop(ModuleDefinition module)
        {
            if (comprehension is QuantifierExpr unSplitQuantifier)
            {
                bool rewritten = MutateCSharp.Schemata471.ReplaceBooleanConstant_1(9L, false);
                foreach (var triggerWriter in partWriters)
                {
                    rewritten |= triggerWriter.RewriteMatchingLoop(reporter, module);
                }
                if (rewritten)
                {
                    unSplitQuantifier.SplitQuantifier = partWriters.Select(q => (Expression)q.Comprehension).ToList();
                    return MutateCSharp.Schemata471.ReplaceBooleanConstant_1(10L, true);
                }
            }
            return MutateCSharp.Schemata471.ReplaceBooleanConstant_1(11L, false);
        }

        void FilterWeakerTriggers()
        {
            foreach (var triggerWriter in partWriters)
            {
                triggerWriter.FilterStrongCandidates();
            }
        }

        // group split quantifier by what triggers they got, and merged them back into one quantifier.
        private void CombineSplitQuantifier()
        {
            if (MutateCSharp.Schemata471.ReplaceBinExprOp_3(16L, partWriters.Count, MutateCSharp.Schemata471.ReplaceNumericConstant_2(12L, 1)))
            {
                var groups = new List<QuantifierGroup>();
                groups.Add(new QuantifierGroup(partWriters[MutateCSharp.Schemata471.ReplaceNumericConstant_2(21L, 0)], new List<ComprehensionExpr> { partWriters[MutateCSharp.Schemata471.ReplaceNumericConstant_2(25L, 0)].Comprehension }));
                for (int i = MutateCSharp.Schemata471.ReplaceNumericConstant_2(29L, 1); MutateCSharp.Schemata471.ReplaceBinExprOp_4(33L, i, partWriters.Count); MutateCSharp.Schemata471.ReplacePostfixUnaryExprOp_5(38L, ref i))
                {
                    bool found = MutateCSharp.Schemata471.ReplaceBooleanConstant_1(39L, false);
                    for (int j = MutateCSharp.Schemata471.ReplaceNumericConstant_2(40L, 0); MutateCSharp.Schemata471.ReplaceBinExprOp_4(44L, j, groups.Count); MutateCSharp.Schemata471.ReplacePostfixUnaryExprOp_5(49L, ref j))
                    {
                        if (HasSameTriggers(partWriters[i], groups[j].Quantifier))
                        {
                            // belong to the same group
                            groups[j].Expressions.Add(partWriters[i].Comprehension);
                            found = MutateCSharp.Schemata471.ReplaceBooleanConstant_1(50L, true);
                            break;
                        }
                    }
                    if (!found)
                    {
                        // start a new group
                        groups.Add(new QuantifierGroup(partWriters[i], new List<ComprehensionExpr> { partWriters[i].Comprehension }));
                    }
                }
                if (MutateCSharp.Schemata471.ReplaceBinExprOp_6(51L, groups.Count, partWriters.Count))
                {
                    // have the same number of splits, so no splits are combined.
                    return;
                }
                // merge expressions in each group back to one quantifier.
                List<SplitPartTriggerWriter> list = new List<SplitPartTriggerWriter>();
                List<Expression> splits = new List<Expression>();
                foreach (var group in groups)
                {
                    SplitPartTriggerWriter q = group.Quantifier;
                    if (q.Comprehension is ForallExpr forallExpr)
                    {
                        IToken tok = forallExpr.tok is NestedToken nestedToken ? nestedToken.Outer : forallExpr.tok;
                        Expression expr = QuantifiersToExpression(tok, BinaryExpr.ResolvedOpcode.And, group.Expressions);
                        q.Comprehension = new ForallExpr(tok, forallExpr.RangeToken, forallExpr.BoundVars, forallExpr.Range, expr, TriggerUtils.CopyAttributes(forallExpr.Attributes)) { Type = forallExpr.Type, Bounds = forallExpr.Bounds };
                    }
                    else if (q.Comprehension is ExistsExpr existsExpr)
                    {
                        IToken tok = existsExpr.tok is NestedToken nestedToken ? nestedToken.Outer : existsExpr.tok;
                        Expression expr = QuantifiersToExpression(tok, BinaryExpr.ResolvedOpcode.Or, group.Expressions);
                        q.Comprehension = new ExistsExpr(tok, existsExpr.RangeToken, existsExpr.BoundVars, existsExpr.Range, expr, TriggerUtils.CopyAttributes(existsExpr.Attributes)) { Type = existsExpr.Type, Bounds = existsExpr.Bounds };
                    }
                    list.Add(q);
                    splits.Add(q.Comprehension);
                }

                partWriters = list;
                Contract.Assert(this.comprehension is QuantifierExpr); // only QuantifierExpr has SplitQuantifier
                ((QuantifierExpr)this.comprehension).SplitQuantifier = splits;
            }
        }

        private bool HasSameTriggers(SplitPartTriggerWriter one, SplitPartTriggerWriter other)
        {
            return one.Candidates.SequenceEqual(other.Candidates, new PredicateEqualityComparer<TriggerCandidate>(SameTriggerCandidate));
        }

        private static bool SameTriggerCandidate(TriggerCandidate arg1, TriggerCandidate arg2)
        {
            Func<TriggerTerm, TriggerTerm, bool> comparer = TriggerTerm.Eq;
            return arg1.Terms.SequenceEqual(arg2.Terms, new PredicateEqualityComparer<TriggerTerm>(comparer));
        }

        private Expression QuantifiersToExpression(IToken tok, BinaryExpr.ResolvedOpcode op, List<ComprehensionExpr> expressions)
        {
            var expr = expressions[MutateCSharp.Schemata471.ReplaceNumericConstant_2(56L, 0)].Term;
            for (int i = MutateCSharp.Schemata471.ReplaceNumericConstant_2(60L, 1); MutateCSharp.Schemata471.ReplaceBinExprOp_4(64L, i, expressions.Count); MutateCSharp.Schemata471.ReplacePostfixUnaryExprOp_5(69L, ref i))
            {
                expr = new BinaryExpr(tok, op, expr, expressions[i].Term);
            }
            return expr;
        }

        internal void CommitTriggers(SystemModuleManager systemModuleManager)
        {
            if (MutateCSharp.Schemata471.ReplaceBinExprOp_3(74L, partWriters.Count, MutateCSharp.Schemata471.ReplaceNumericConstant_2(70L, 1)))
            {
                reporter.Message(MessageSource.Rewriter, ErrorLevel.Info, null,
                  comprehension.Tok, $"Quantifier was split into {partWriters.Count} parts. " +
        MutateCSharp.Schemata471.ReplaceStringConstant_7(79L, "Better verification performance and error reporting may be obtained by splitting the quantifier in source. ") +
                   $"For more information, see the section quantifier instantiation rules in the reference manual.");
            }

            for (var index = MutateCSharp.Schemata471.ReplaceNumericConstant_2(80L, 0); MutateCSharp.Schemata471.ReplaceBinExprOp_4(84L, index, partWriters.Count); MutateCSharp.Schemata471.ReplacePostfixUnaryExprOp_5(89L, ref index))
            {
                var triggerWriter = partWriters[index];
                triggerWriter.CommitTrigger(reporter, MutateCSharp.Schemata471.ReplaceBinExprOp_3(94L, partWriters.Count, MutateCSharp.Schemata471.ReplaceNumericConstant_2(90L, 1)) ? index : null, systemModuleManager);
            }
        }
    }
}
