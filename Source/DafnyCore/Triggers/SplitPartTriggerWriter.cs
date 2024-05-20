using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata475
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT475");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
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

        internal static bool ReplaceBinExprOp_9(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_5(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, System.Tuple<Microsoft.Dafny.Expression, Microsoft.Dafny.IdentifierExpr> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny.Triggers
{
    public
/// <summary>
/// Determines the triggers for a comprehension that resulted from splitting another one
/// </summary>
class SplitPartTriggerWriter
    {
        public ComprehensionExpr Comprehension { get; set; }
        public List<TriggerTerm> CandidateTerms { get; set; }
        public List<TriggerCandidate> Candidates { get; set; }
        private List<TriggerCandidate> RejectedCandidates { get; }

        private List<TriggerMatch> loopingMatches;

        private bool AllowsLoops
        {
            get
            {
                Contract.Requires(!(Comprehension is QuantifierExpr) || ((QuantifierExpr)Comprehension).SplitQuantifier == null); // Don't call this on a quantifier with a Split clause: it's not a real quantifier
                                                                                                                                  // This is different from nowarn: it won't remove loops at all, even if another trigger is available.
                return Attributes.Contains(Comprehension.Attributes, MutateCSharp.Schemata475.ReplaceStringConstant_0(1L, "matchingloop"));
            }
        }

        private bool CouldSuppressLoops { get; set; }

        internal SplitPartTriggerWriter(ComprehensionExpr comprehension)
        {
            this.Comprehension = comprehension;
            this.RejectedCandidates = new List<TriggerCandidate>();
        }

        internal void TrimInvalidTriggers()
        {
            Contract.Requires(CandidateTerms != null);
            Contract.Requires(Candidates != null);
            Candidates = Candidates.Where(tr => tr.MentionsAll(Comprehension.BoundVars)).ToList();
        }

        public bool DetectAndFilterLoopingCandidates(ErrorReporter reporter)
        {
            var looping = new List<TriggerCandidate>();
            var loopingMatches = new List<TriggerMatch>();

            var nonLoopingCandidates = new List<TriggerCandidate>();
            foreach (var candidate in Candidates)
            {
                var loopingSubterms = candidate.LoopingSubterms(Comprehension, reporter.Options).ToList();
                if (loopingSubterms.Any())
                {
                    looping.Add(candidate);
                    loopingMatches = loopingSubterms.ToList();
                    candidate.Annotation = MutateCSharp.Schemata475.ReplaceStringConstant_0(2L, "may loop with ") + string.Join(MutateCSharp.Schemata475.ReplaceStringConstant_0(3L, ", "),
                      loopingSubterms.Select(t => MutateCSharp.Schemata475.ReplaceStringConstant_0(4L, "\"") + Printer.ExprToString(reporter.Options, t.OriginalExpr) + MutateCSharp.Schemata475.ReplaceStringConstant_0(5L, "\"")));
                }
                else
                {
                    nonLoopingCandidates.Add(candidate);
                }
            }

            CouldSuppressLoops = MutateCSharp.Schemata475.ReplaceBinExprOp_2(10L, nonLoopingCandidates.Count, MutateCSharp.Schemata475.ReplaceNumericConstant_1(6L, 0));
            this.loopingMatches = loopingMatches;
            if (MutateCSharp.Schemata475.ReplaceBinExprOp_3(15L, () => !AllowsLoops, () => CouldSuppressLoops))
            {
                Candidates = nonLoopingCandidates;
                RejectedCandidates.AddRange(looping);
            }

            return MutateCSharp.Schemata475.ReplaceBinExprOp_2(25L, looping.Count, MutateCSharp.Schemata475.ReplaceNumericConstant_1(21L, 0));
        }

        public bool RewriteMatchingLoop(ErrorReporter reporter, ModuleDefinition module)
        {
            if (MutateCSharp.Schemata475.ReplaceBinExprOp_4(30L, () => !NeedsAutoTriggers(), () => !WantsMatchingLoopRewrite()))
            {
                return MutateCSharp.Schemata475.ReplaceBooleanConstant_5(36L, false);
            }

            var triggersCollector = new TriggersCollector(new(),
              reporter.Options, module);
            // rewrite quantifier to avoid matching loops
            // before:
            //    assert forall i :: 0 <= i < a.Length-1 ==> a[i] <= a[i+1];
            // after:
            //    assert forall i,j :: j == i+1 ==> 0 <= i < a.Length-1 ==> a[i] <= a[j];
            var substMap = new List<Tuple<Expression, IdentifierExpr>>();
            foreach (var triggerMatch in loopingMatches)
            {
                var e = triggerMatch.OriginalExpr;
                if (MutateCSharp.Schemata475.ReplaceBinExprOp_3(37L, () => triggersCollector.IsPotentialTriggerCandidate(e), () => triggersCollector.IsTriggerKiller(e)))
                {
                    foreach (var sub in e.SubExpressions)
                    {
                        if (MutateCSharp.Schemata475.ReplaceBinExprOp_3(43L, () => triggersCollector.IsTriggerKiller(sub), () => (!triggersCollector.IsPotentialTriggerCandidate(sub))))
                        {
                            var entry = substMap.Find(x => ExprExtensions.ExpressionEq(sub, x.Item1));
                            if (MutateCSharp.Schemata475.ReplaceBinExprOp_6(49L, entry, null))
                            {
                                var newBv = new BoundVar(sub.tok, MutateCSharp.Schemata475.ReplaceStringConstant_0(50L, "_t#") + substMap.Count, sub.Type);
                                var ie = new IdentifierExpr(sub.tok, newBv.Name);
                                ie.Var = newBv;
                                ie.Type = newBv.Type;
                                substMap.Add(new Tuple<Expression, IdentifierExpr>(sub, ie));
                            }
                        }
                    }
                }
            }

            var expr = (QuantifierExpr)Comprehension;
            if (MutateCSharp.Schemata475.ReplaceBinExprOp_2(55L, substMap.Count, MutateCSharp.Schemata475.ReplaceNumericConstant_1(51L, 0)))
            {
                var s = new ExprSubstituter(substMap);
                expr = s.Substitute(Comprehension) as QuantifierExpr;
            }
            else
            {
                // make a copy of the expr
                if (expr is ForallExpr)
                {
                    expr = new ForallExpr(expr.tok, expr.RangeToken, expr.BoundVars, expr.Range, expr.Term,
                      TriggerUtils.CopyAttributes(expr.Attributes))
                    { Type = expr.Type, Bounds = expr.Bounds };
                }
                else
                {
                    expr = new ExistsExpr(expr.tok, expr.RangeToken, expr.BoundVars, expr.Range, expr.Term,
                      TriggerUtils.CopyAttributes(expr.Attributes))
                    { Type = expr.Type, Bounds = expr.Bounds };
                }
            }
            var qq = expr;

            Comprehension = qq;
            Candidates.Clear();
            CandidateTerms.Clear();
            loopingMatches.Clear();
            RejectedCandidates.Clear();
            return MutateCSharp.Schemata475.ReplaceBooleanConstant_5(60L, true);

            // don't rewrite the quantifier if we are not auto generate triggers.
            // This is because rewriting introduces new boundvars and will cause
            // user provided triggers not mention all boundvars
        }

        // TODO Check whether this makes verification faster
        public void FilterStrongCandidates()
        {
            var newCandidates = new List<TriggerCandidate>();
            foreach (var candidate in Candidates)
            {
                var weakerCandidates = Candidates.Where(candidate.IsStrongerThan).ToList();
                if (weakerCandidates.Any())
                {
                    RejectedCandidates.Add(candidate);
                    candidate.Annotation = MutateCSharp.Schemata475.ReplaceStringConstant_0(61L, "more specific than ") + string.Join(MutateCSharp.Schemata475.ReplaceStringConstant_0(62L, ", "), weakerCandidates);
                }
                else
                {
                    newCandidates.Add(candidate);
                }
            }
            Candidates = newCandidates;
        }

        public void CommitTrigger(ErrorReporter errorReporter, int? splitPartIndex, SystemModuleManager systemModuleManager)
        {
            bool suppressWarnings = Attributes.Contains(Comprehension.Attributes, MutateCSharp.Schemata475.ReplaceStringConstant_0(63L, "nowarn"));
            var reportingToken = Comprehension.Tok;
            var warningLevel = suppressWarnings ? ErrorLevel.Info : ErrorLevel.Warning;

            if (!WantsAutoTriggers())
            {
                // NOTE: split and autotriggers attributes are passed down to Boogie
                errorReporter.Message(MessageSource.Rewriter, ErrorLevel.Info, null, reportingToken,
          MutateCSharp.Schemata475.ReplaceStringConstant_0(64L, "The attribute {:autotriggers false} may cause brittle verification. ") +
          MutateCSharp.Schemata475.ReplaceStringConstant_0(65L, "It's better to remove this attribute, or as a second option, manually define a trigger using {:trigger}. ") +
          MutateCSharp.Schemata475.ReplaceStringConstant_0(66L, "For more information, see the section quantifier instantiation rules in the reference manual."));
            }

            if (!NeedsAutoTriggers())
            {
                var triggerAttribute = Attributes.Find(Comprehension.Attributes, MutateCSharp.Schemata475.ReplaceStringConstant_0(67L, "trigger"));
                if (MutateCSharp.Schemata475.ReplaceBinExprOp_3(78L, () => MutateCSharp.Schemata475.ReplaceBinExprOp_7(68L, triggerAttribute, null), () => MutateCSharp.Schemata475.ReplaceBinExprOp_8(73L, triggerAttribute.Args.Count, MutateCSharp.Schemata475.ReplaceNumericConstant_1(69L, 0))))
                {
                    // Remove an empty trigger attribute, so it does not crash Boogie,
                    // and effectively becomes a way to silence a Dafny warning
                    triggerAttribute.Name = MutateCSharp.Schemata475.ReplaceStringConstant_0(84L, "deleted-trigger");
                }
                return;
            }

            AddTriggerAttribute(systemModuleManager);

            if (Attributes.Contains(Comprehension.Attributes, MutateCSharp.Schemata475.ReplaceStringConstant_0(85L, "auto_generated")))
            {
                return;
            }

            string InfoFirstLineEnd(int count)
            {
                return MutateCSharp.Schemata475.ReplaceBinExprOp_9(90L, count, MutateCSharp.Schemata475.ReplaceNumericConstant_1(86L, 2)) ? MutateCSharp.Schemata475.ReplaceStringConstant_0(95L, " ") : MutateCSharp.Schemata475.ReplaceStringConstant_0(96L, "\n  ");
            }

            var messages = new List<string>();
            if (splitPartIndex != null)
            {
                messages.Add($"Part #{splitPartIndex} is '{Comprehension.Term}'");
            }
            if (Candidates.Any())
            {
                messages.Add($"Selected triggers:{InfoFirstLineEnd(Candidates.Count)}{string.Join(MutateCSharp.Schemata475.ReplaceStringConstant_0(97L, ", "), Candidates)}");
            }
            if (RejectedCandidates.Any())
            {
                messages.Add($"Rejected triggers:{InfoFirstLineEnd(RejectedCandidates.Count)}{string.Join(MutateCSharp.Schemata475.ReplaceStringConstant_0(98L, "\n  "), RejectedCandidates)}");
            }

            if (messages.Any())
            {
                errorReporter.Message(MessageSource.Rewriter, ErrorLevel.Info, null, reportingToken, string.Join(MutateCSharp.Schemata475.ReplaceStringConstant_0(99L, "\n"), messages));
            }

            if (MutateCSharp.Schemata475.ReplaceBinExprOp_4(100L, () => !CandidateTerms.Any(), () => !Candidates.Any()))
            {
                errorReporter.Message(MessageSource.Rewriter, warningLevel, null, reportingToken,
                  $"Could not find a trigger for this quantifier. Without a trigger, the quantifier may cause brittle verification. " +
                  $"To silence this warning, add an explicit trigger using the {{:trigger}} attribute. " +
                  $"For more information, see the section quantifier instantiation rules in the reference manual.");
            }
            else if (MutateCSharp.Schemata475.ReplaceBinExprOp_3(106L, () => !CouldSuppressLoops, () => !AllowsLoops))
            {
                errorReporter.Message(MessageSource.Rewriter, warningLevel, null, reportingToken,
                  $"Triggers were added to this quantifier that may introduce matching loops, which may cause brittle verification. " +
                  $"To silence this warning, add an explicit trigger using the {{:trigger}} attribute. " +
                  $"For more information, see the section quantifier instantiation rules in the reference manual.");
            }
        }

        private void AddTriggerAttribute(SystemModuleManager systemModuleManager)
        {
            foreach (var candidate in Candidates)
            {
                Comprehension.Attributes = new Attributes(MutateCSharp.Schemata475.ReplaceStringConstant_0(112L, "trigger"),
                  candidate.Terms.ConvertAll(t => Expression.WrapAsParsedStructureIfNecessary(t.Expr, systemModuleManager)),
                  Comprehension.Attributes);
            }
        }

        private bool WantsAutoTriggers()
        {
            bool wantsAutoTriggers = MutateCSharp.Schemata475.ReplaceBooleanConstant_5(113L, true);
            return !Attributes.ContainsBool(Comprehension.Attributes, MutateCSharp.Schemata475.ReplaceStringConstant_0(114L, "autotriggers"), ref wantsAutoTriggers) || wantsAutoTriggers;
        }

        private bool NeedsAutoTriggers()
        {
            return MutateCSharp.Schemata475.ReplaceBinExprOp_3(116L, () => !Attributes.Contains(Comprehension.Attributes, MutateCSharp.Schemata475.ReplaceStringConstant_0(115L, "trigger")), () => WantsAutoTriggers());
        }

        bool WantsMatchingLoopRewrite()
        {
            bool wantsMatchingLoopRewrite = MutateCSharp.Schemata475.ReplaceBooleanConstant_5(122L, true);
            return (!Attributes.ContainsBool(Comprehension.Attributes, MutateCSharp.Schemata475.ReplaceStringConstant_0(123L, "matchinglooprewrite"), ref wantsMatchingLoopRewrite) || wantsMatchingLoopRewrite) && WantsAutoTriggers();
        }
    }
}