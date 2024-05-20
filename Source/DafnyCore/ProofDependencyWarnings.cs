using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using DafnyCore.Verifier;
using Microsoft.Boogie;
using Microsoft.Dafny.ProofObligationDescription;
using VC;
namespace MutateCSharp
{
    internal class Schemata362
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT362");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static string ReplaceStringConstant_2(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, VC.VcOutcome argument1, VC.VcOutcome argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() == argument2();
        }

        internal static bool ReplaceBooleanConstant_3(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Boogie.SolverOutcome argument1, Microsoft.Boogie.SolverOutcome argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public record VerificationTaskResult(IVerificationTask Task, VerificationRunResult Result);

    public class ProofDependencyWarnings
    {


        public static void ReportSuspiciousDependencies(DafnyOptions options, IEnumerable<VerificationTaskResult> parts,
          ErrorReporter reporter, ProofDependencyManager manager)
        {
            foreach (var resultsForScope in parts.GroupBy(p => p.Task.ScopeId))
            {
                WarnAboutSuspiciousDependenciesForImplementation(options,
                  reporter,
                  manager,
                  resultsForScope.Key,
                  resultsForScope.Select(p => p.Result).ToList());
            }
        }

        public static void WarnAboutSuspiciousDependencies(DafnyOptions dafnyOptions, ErrorReporter reporter, ProofDependencyManager depManager)
        {
            var verificationResults = (dafnyOptions.Printer as DafnyConsolePrinter).VerificationResults.ToList();
            var orderedResults =
              verificationResults.OrderBy(vr =>
                (vr.Implementation.Tok.filename, vr.Implementation.Tok.line, vr.Implementation.Tok.col));

            foreach (var (implementation, result) in orderedResults)
            {
                if (MutateCSharp.Schemata362.ReplaceBinExprOp_0(1L, result.Outcome, VcOutcome.Correct))
                {
                    continue;
                }
                Warn(dafnyOptions, reporter, depManager, implementation.Name, result.VCResults.SelectMany(r => r.CoveredElements));
            }
        }

        public static void WarnAboutSuspiciousDependenciesForImplementation(DafnyOptions dafnyOptions, ErrorReporter reporter,
          ProofDependencyManager depManager, string name,
          IReadOnlyList<VerificationRunResult> results)
        {
            if (results.Any(r => MutateCSharp.Schemata362.ReplaceBinExprOp_1(2L, r.Outcome, SolverOutcome.Valid)))
            {
                return;
            }

            var coveredElements = results.SelectMany(r => r.CoveredElements);

            Warn(dafnyOptions, reporter, depManager, name, coveredElements);
        }

        private static void Warn(DafnyOptions dafnyOptions, ErrorReporter reporter, ProofDependencyManager depManager,
          string scopeName, IEnumerable<TrackedNodeComponent> coveredElements)
        {
            var potentialDependencies = depManager.GetPotentialDependenciesForDefinition(scopeName);
            var usedDependencies =
              coveredElements
                .Select(depManager.GetFullIdDependency)
                .OrderBy(dep => dep.Range)
                .ThenBy(dep => dep.Description);
            var unusedDependencies =
              potentialDependencies
                .Except(usedDependencies)
                .OrderBy(dep => dep.Range)
                .ThenBy(dep => dep.Description).ToList();

            foreach (var unusedDependency in unusedDependencies)
            {
                if (dafnyOptions.Get(CommonOptionBag.WarnContradictoryAssumptions))
                {
                    if (unusedDependency is ProofObligationDependency obligation)
                    {
                        if (ShouldWarnVacuous(dafnyOptions, scopeName, obligation))
                        {
                            var message = $"proved using contradictory assumptions: {obligation.Description}";
                            if (obligation.ProofObligation is AssertStatementDescription)
                            {
                                message += MutateCSharp.Schemata362.ReplaceStringConstant_2(3L, ". (Use the `{:contradiction}` attribute on the `assert` statement to silence.)");
                            }
                            reporter.Warning(MessageSource.Verifier, "", obligation.Range, message);
                        }
                    }

                    if (unusedDependency is EnsuresDependency ensures)
                    {
                        if (ShouldWarnVacuous(dafnyOptions, scopeName, ensures))
                        {
                            reporter.Warning(MessageSource.Verifier, "", ensures.Range,
                              $"ensures clause proved using contradictory assumptions");
                        }
                    }
                }

                if (dafnyOptions.Get(CommonOptionBag.WarnRedundantAssumptions))
                {
                    if (unusedDependency is RequiresDependency requires)
                    {
                        reporter.Warning(MessageSource.Verifier, "", requires.Range, $"unnecessary requires clause");
                    }

                    if (unusedDependency is AssumptionDependency assumption)
                    {
                        if (ShouldWarnUnused(assumption))
                        {
                            reporter.Warning(MessageSource.Verifier, "", assumption.Range,
                              $"unnecessary (or partly unnecessary) {assumption.Description}");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Some proof obligations that don't show up in the dependency list
        /// are innocuous. Either they come about because of internal Dafny
        /// design choices that the programmer has no control over, or they
        /// just aren't meaningful in context. This method identifies cases
        /// where it doesn't make sense to issue a warning. Many of these
        /// cases should perhaps be eliminated by changing the translator
        /// to not generate vacuous proof goals, but that may be a difficult
        /// change to make.
        /// </summary>
        /// <param name="dep">the dependency to examine</param>
        /// <returns>false to skip warning about the absence of this
        /// dependency, true otherwise</returns>
        private static bool ShouldWarnVacuous(DafnyOptions options, string verboseName, ProofDependency dep)
        {
            if (dep is ProofObligationDependency poDep)
            {
                // Dafny generates some assertions about definite assignment whose
                // proofs are always vacuous. Since these aren't written by Dafny
                // programmers, it's safe to just skip them all.
                if (poDep.ProofObligation is DefiniteAssignment)
                {
                    return MutateCSharp.Schemata362.ReplaceBooleanConstant_3(4L, false);
                }

                // Some proof obligations occur in a context that the Dafny programmer
                // doesn't have control of, so warning about vacuity isn't helpful.
                if (poDep.ProofObligation.ProvedOutsideUserCode)
                {
                    return MutateCSharp.Schemata362.ReplaceBooleanConstant_3(5L, false);
                }

                // Don't warn about `assert false` being proved vacuously. If it's proved,
                // it must be vacuous, but it's also probably an attempt to prove that a
                // given branch is unreachable (often, but not always, in ghost code).
                var assertedExpr = poDep.ProofObligation.GetAssertedExpr(options);
                if (assertedExpr is not null &&
                    Expression.IsBoolLiteral(assertedExpr, out var lit) &&
          MutateCSharp.Schemata362.ReplaceBinExprOp_4(7L, () => lit, () => MutateCSharp.Schemata362.ReplaceBooleanConstant_3(6L, false)))
                {
                    return MutateCSharp.Schemata362.ReplaceBooleanConstant_3(13L, false);
                }

                if (poDep.ProofObligation is AssertStatementDescription { IsIntentionalContradiction: true })
                {
                    return MutateCSharp.Schemata362.ReplaceBooleanConstant_3(14L, false);
                }
            }

            // Ensures clauses are often proven vacuously during well-formedness checks.
            // There's unfortunately no way to identify these checks once Dafny has
            // been translated to Boogie other than looking at the name. This is a significant
            // limitation, because it means that function ensures clauses that are satisfied
            // only vacuously won't be reported. It would great if we could change the Boogie
            // encoding so that these unreachable-by-construction checks don't exist.
            if (MutateCSharp.Schemata362.ReplaceBinExprOp_5(16L, () => verboseName.Contains(MutateCSharp.Schemata362.ReplaceStringConstant_2(15L, "well-formedness")), () => dep is EnsuresDependency))
            {
                return MutateCSharp.Schemata362.ReplaceBooleanConstant_3(22L, false);
            }

            return MutateCSharp.Schemata362.ReplaceBooleanConstant_3(23L, true);
        }

        /// <summary>
        /// Some assumptions that don't show up in the dependency list
        /// are innocuous. In particular, `assume true` is often used
        /// as a place to attach attributes such as `{:split_here}`.
        /// Don't warn about such assumptions. Also don't warn about
        /// assumptions that aren't explicit (coming from `assume` or
        /// `assert` statements), for now, because they are difficult
        /// for the user to control.
        /// </summary>
        /// <param name="dep">the dependency to examine</param>
        /// <returns>false to skip warning about the absence of this
        /// dependency, true otherwise</returns>
        private static bool ShouldWarnUnused(ProofDependency dep)
        {
            if (dep is AssumptionDependency assumeDep)
            {
                if (assumeDep.Expr is not null &&
                    Expression.IsBoolLiteral(assumeDep.Expr, out var lit) &&
                    lit)
                {
                    return MutateCSharp.Schemata362.ReplaceBooleanConstant_3(24L, false);
                }

                return assumeDep.WarnWhenUnused;
            }

            return MutateCSharp.Schemata362.ReplaceBooleanConstant_3(25L, true);
        }
    }
}
