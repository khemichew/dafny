using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
namespace MutateCSharp
{
    internal class Schemata211
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT211");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny.Auditor
{
    public record AssumptionDescription(
      string Issue,
      string Mitigation,
      string MitigationIetf,
      bool IsExplicit
    )
    {
        public static AssumptionDescription HasAxiomAttribute = new(
          Issue: MutateCSharp.Schemata211.ReplaceStringConstant_0(1L, "Declaration has explicit [{:axiom}] attribute."),
          Mitigation: MutateCSharp.Schemata211.ReplaceStringConstant_0(2L, "Provide a proof or test."),
          MitigationIetf: MutateCSharp.Schemata211.ReplaceStringConstant_0(3L, "SHOULD provide a proof or test."),
          IsExplicit: MutateCSharp.Schemata211.ReplaceBooleanConstant_1(4L, true));
        public static AssumptionDescription HasVerifyFalseAttribute = new(
          Issue: MutateCSharp.Schemata211.ReplaceStringConstant_0(5L, "Declaration has [{:verify false}] attribute."),
          Mitigation: MutateCSharp.Schemata211.ReplaceStringConstant_0(6L, "Remove [{:verify false}] attribute and prove if possible."),
          MitigationIetf: MutateCSharp.Schemata211.ReplaceStringConstant_0(7L, "MUST remove [{:verify false}] attribute and prove."),
          IsExplicit: MutateCSharp.Schemata211.ReplaceBooleanConstant_1(8L, false));
        public static AssumptionDescription ExternFunction = new(
          Issue: MutateCSharp.Schemata211.ReplaceStringConstant_0(9L, "Function with [{:extern}] attribute."),
          Mitigation: MutateCSharp.Schemata211.ReplaceStringConstant_0(10L, "Turn into a [method] with [modifies {}] and test thoroughly for lack of side effects."),
          MitigationIetf: MutateCSharp.Schemata211.ReplaceStringConstant_0(11L, "SHOULD use [method] with [modifies {}] instead."),
          IsExplicit: MutateCSharp.Schemata211.ReplaceBooleanConstant_1(12L, false));

        public static AssumptionDescription ExternWithPrecondition = new(
          Issue: MutateCSharp.Schemata211.ReplaceStringConstant_0(13L, "Declaration with [{:extern}] has a requires clause."),
          Mitigation: MutateCSharp.Schemata211.ReplaceStringConstant_0(14L, "Test any external callers (maybe with [/testContracts])."),
          MitigationIetf: MutateCSharp.Schemata211.ReplaceStringConstant_0(15L, "MUST test any external callers."),
          IsExplicit: MutateCSharp.Schemata211.ReplaceBooleanConstant_1(16L, false));
        public static AssumptionDescription ExternWithPostcondition = new(
          Issue: MutateCSharp.Schemata211.ReplaceStringConstant_0(17L, "Declaration with [{:extern}] has a ensures clause."),
          Mitigation: MutateCSharp.Schemata211.ReplaceStringConstant_0(18L, "Test external callee (maybe with [/testContracts])."),
          MitigationIetf: MutateCSharp.Schemata211.ReplaceStringConstant_0(19L, "MUST test external callee."),
          IsExplicit: MutateCSharp.Schemata211.ReplaceBooleanConstant_1(20L, false));

        public static AssumptionDescription AssumeStatement(bool hasAxiomAttribute)
        {
            return new(
              Issue:
              hasAxiomAttribute
                ? MutateCSharp.Schemata211.ReplaceStringConstant_0(21L, "Definition has [assume {:axiom}] statement in body."
        ) : MutateCSharp.Schemata211.ReplaceStringConstant_0(22L, "Definition has [assume] statement in body."),
              Mitigation:
                hasAxiomAttribute
                  ? MutateCSharp.Schemata211.ReplaceStringConstant_0(23L, "Replace with [assert] and prove."
        ) : MutateCSharp.Schemata211.ReplaceStringConstant_0(24L, "Replace with [assert] and prove or add [{:axiom}]."),
              MitigationIetf:
                hasAxiomAttribute
                  ? MutateCSharp.Schemata211.ReplaceStringConstant_0(25L, "SHOULD replace with [assert] and prove."
        ) : MutateCSharp.Schemata211.ReplaceStringConstant_0(26L, "MUST replace with [assert] and prove or add [{:axiom}]."),
              IsExplicit: MutateCSharp.Schemata211.ReplaceBooleanConstant_1(27L, false
        ));
        }
        public static AssumptionDescription MayNotTerminate = new(
          Issue: MutateCSharp.Schemata211.ReplaceStringConstant_0(28L, "Method may not terminate (uses [decreases *])."),
          Mitigation: MutateCSharp.Schemata211.ReplaceStringConstant_0(29L, "Provide a valid [decreases] clause."),
          MitigationIetf: MutateCSharp.Schemata211.ReplaceStringConstant_0(30L, "SHOULD provide a valid [decreases] clause."),
          IsExplicit: MutateCSharp.Schemata211.ReplaceBooleanConstant_1(31L, false));
        public static AssumptionDescription HasTerminationFalseAttribute = new(
          Issue: MutateCSharp.Schemata211.ReplaceStringConstant_0(32L, "Trait method calls may not terminate (uses [{:termination false}])."),
          Mitigation: MutateCSharp.Schemata211.ReplaceStringConstant_0(33L, "Remove if possible."),
          MitigationIetf: MutateCSharp.Schemata211.ReplaceStringConstant_0(34L, "MUST remove [{:termination false}] or justify."),
          IsExplicit: MutateCSharp.Schemata211.ReplaceBooleanConstant_1(35L, false));
        public static AssumptionDescription ForallWithoutBody = new(
          Issue: MutateCSharp.Schemata211.ReplaceStringConstant_0(36L, "Definition contains [forall] statement with no body."),
          Mitigation: MutateCSharp.Schemata211.ReplaceStringConstant_0(37L, "Provide a body."),
          MitigationIetf: MutateCSharp.Schemata211.ReplaceStringConstant_0(38L, "MUST provide a body."),
          IsExplicit: MutateCSharp.Schemata211.ReplaceBooleanConstant_1(39L, false));
        public static AssumptionDescription LoopWithoutBody = new(
          Issue: MutateCSharp.Schemata211.ReplaceStringConstant_0(40L, "Definition contains loop with no body."),
          Mitigation: MutateCSharp.Schemata211.ReplaceStringConstant_0(41L, "Provide a body."),
          MitigationIetf: MutateCSharp.Schemata211.ReplaceStringConstant_0(42L, "MUST provide a body."),
          IsExplicit: MutateCSharp.Schemata211.ReplaceBooleanConstant_1(43L, false));

        public static AssumptionDescription HasAssumeConcurrentAttribute(bool isModifies)
        {
            return new AssumptionDescription(
              Issue: (isModifies ? MutateCSharp.Schemata211.ReplaceStringConstant_0(44L, "Modifies") : MutateCSharp.Schemata211.ReplaceStringConstant_0(45L, "Reads")) + MutateCSharp.Schemata211.ReplaceStringConstant_0(46L, " clause has [{:assume_concurrent}] attribute."),
              Mitigation: MutateCSharp.Schemata211.ReplaceStringConstant_0(47L, "Manually review and test in a concurrent setting."),
              MitigationIetf: MutateCSharp.Schemata211.ReplaceStringConstant_0(48L, "MUST manually review and test in a concurrent setting."),
              IsExplicit: MutateCSharp.Schemata211.ReplaceBooleanConstant_1(49L, true));
        }

        public static AssumptionDescription NoBody(bool isGhost)
        {
            return new(
              Issue: (isGhost ? MutateCSharp.Schemata211.ReplaceStringConstant_0(50L, "Ghost") : MutateCSharp.Schemata211.ReplaceStringConstant_0(51L, "Compiled")) +
        MutateCSharp.Schemata211.ReplaceStringConstant_0(52L, " declaration has no body and has an ensures clause."),
              Mitigation: MutateCSharp.Schemata211.ReplaceStringConstant_0(53L, "Provide a body or add [{:axiom}]."),
              MitigationIetf: (isGhost ? MutateCSharp.Schemata211.ReplaceStringConstant_0(54L, "MUST") : MutateCSharp.Schemata211.ReplaceStringConstant_0(55L, "SHOULD")) + MutateCSharp.Schemata211.ReplaceStringConstant_0(56L, " provide a body or add [{:axiom}]."),
              IsExplicit: MutateCSharp.Schemata211.ReplaceBooleanConstant_1(57L, false));
        }

        public static readonly AssumptionDescription AssertOnly = new(
          Issue: MutateCSharp.Schemata211.ReplaceStringConstant_0(58L, "Assertion has explicit temporary [{:only}] attribute."),
          Mitigation: MutateCSharp.Schemata211.ReplaceStringConstant_0(59L, "Remove the [{:only}] attribute."),
          MitigationIetf: MutateCSharp.Schemata211.ReplaceStringConstant_0(60L, "MUST remove the [{:only}] attribute."),
          IsExplicit: MutateCSharp.Schemata211.ReplaceBooleanConstant_1(61L, true
      ));

        public static readonly AssumptionDescription MemberOnly = new(
          Issue: MutateCSharp.Schemata211.ReplaceStringConstant_0(62L, "Member has explicit temporary [{:only}] attribute."),
          Mitigation: MutateCSharp.Schemata211.ReplaceStringConstant_0(63L, "Remove the [{:only}] attribute."),
          MitigationIetf: MutateCSharp.Schemata211.ReplaceStringConstant_0(64L, "MUST remove the [{:only}] attribute."),
          IsExplicit: MutateCSharp.Schemata211.ReplaceBooleanConstant_1(65L, true
      ));
    }
    public record Assumption(Declaration decl, IToken tok, AssumptionDescription desc)
    {
        public string Warning()
        {
            var tickIssue = UpdateVerbatim(desc.Issue, MutateCSharp.Schemata211.ReplaceStringConstant_0(66L, "`"), MutateCSharp.Schemata211.ReplaceStringConstant_0(67L, "`"));
            var tickMitigation = UpdateVerbatim(desc.Mitigation, MutateCSharp.Schemata211.ReplaceStringConstant_0(68L, "`"), MutateCSharp.Schemata211.ReplaceStringConstant_0(69L, "`"));
            return decl.Name + MutateCSharp.Schemata211.ReplaceStringConstant_0(70L, ": ") + tickIssue + MutateCSharp.Schemata211.ReplaceStringConstant_0(71L, " Possible mitigation: ") + tickMitigation;
        }

        public static string UpdateVerbatim(string text, string beg, string end)
        {
            return text.Replace(MutateCSharp.Schemata211.ReplaceStringConstant_0(72L, "["), beg).Replace(MutateCSharp.Schemata211.ReplaceStringConstant_0(73L, "]"), end);
        }
    }
}
