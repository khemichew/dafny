using System.Collections.Generic;
namespace MutateCSharp
{
    internal class Schemata463
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT463");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.DafnyOptions.ContractTestingMode argument1, Microsoft.Dafny.DafnyOptions.ContractTestingMode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.CommonOptionBag.DefaultFunctionOpacityOptions argument1, Microsoft.Dafny.CommonOptionBag.DefaultFunctionOpacityOptions argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public static class RewriterCollection
    {

        public static IList<IRewriter> GetRewriters(ErrorReporter reporter, Program program)
        {
            var result = new List<IRewriter>();

            result.Add(new RefinementTransformer(reporter));
            if (reporter.Options.AuditProgram)
            {
                result.Add(new Auditor.Auditor(reporter));
            }

            result.Add(new AutoContractsRewriter(program, reporter));
            result.Add(new OpaqueMemberRewriter(reporter));
            result.Add(new AutoReqFunctionRewriter(program, reporter));
            result.Add(new TimeLimitRewriter(reporter));
            result.Add(new ForallStmtRewriter(reporter));
            result.Add(new ProvideRevealAllRewriter(reporter));
            result.Add(new MatchFlattener(reporter, program.Compilation.IdGenerator));

            if (reporter.Options.AutoTriggers)
            {
                result.Add(new QuantifierSplittingRewriter(reporter));
                result.Add(new TriggerGeneratingRewriter(reporter, program.SystemModuleManager));
            }

            if (MutateCSharp.Schemata463.ReplaceBinExprOp_0(1L, reporter.Options.TestContracts, DafnyOptions.ContractTestingMode.None))
            {
                result.Add(new ExpectContracts(reporter, program.SystemModuleManager));
            }

            if (reporter.Options.Get(RunAllTestsMainMethod.IncludeTestRunner))
            {
                result.Add(new RunAllTestsMainMethod(reporter));
            }

            result.Add(new InductionRewriter(reporter));
            result.Add(new PrintEffectEnforcement(reporter));
            result.Add(new BitvectorOptimization(program, reporter));

            if (reporter.Options.DisallowConstructorCaseWithoutParentheses)
            {
                result.Add(new ConstructorWarning(reporter));
            }

            result.Add(new LocalLinter(reporter));
            result.Add(new PrecedenceLinter(reporter, program.Compilation));

            if (MutateCSharp.Schemata463.ReplaceBinExprOp_1(2L, reporter.Options.Get(CommonOptionBag.DefaultFunctionOpacity), CommonOptionBag.DefaultFunctionOpacityOptions.AutoRevealDependencies))
            {
                result.Add(new AutoRevealFunctionDependencies(reporter));
            }

            foreach (var plugin in reporter.Options.Plugins)
            {
                result.AddRange(plugin.GetRewriters(reporter));
            }

            return result;
        }
    }
}