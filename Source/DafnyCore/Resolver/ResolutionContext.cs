namespace MutateCSharp
{
    internal class Schemata432
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT432");
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

        internal static bool ReplaceBinExprOp_3(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

    }
}
namespace Microsoft.Dafny
{
    public record ResolutionContext(ICodeContext CodeContext, bool IsTwoState, bool InOld, bool InReveal,
      bool InFunctionPostcondition, bool InFirstPhaseConstructor)
    {

        // Invariants:
        // InOld implies !IsTwoState
        // InFirstPhaseConstructor implies codeContext is Constructor

        public bool IsGhost => CodeContext.IsGhost;

        public ResolutionContext(ICodeContext codeContext, bool isTwoState)
          : this(codeContext, isTwoState, MutateCSharp.Schemata432.ReplaceBooleanConstant_0(1L, false), MutateCSharp.Schemata432.ReplaceBooleanConstant_0(2L, false), MutateCSharp.Schemata432.ReplaceBooleanConstant_0(3L, false), MutateCSharp.Schemata432.ReplaceBooleanConstant_0(4L, false))
        {
        }

        /// <summary>
        /// Return a ResolutionContext appropriate for the body of "codeContext".
        /// </summary>
        public static ResolutionContext FromCodeContext(ICodeContext codeContext)
        {
            bool isTwoState;
            if (MutateCSharp.Schemata432.ReplaceBinExprOp_1(11L, () => MutateCSharp.Schemata432.ReplaceBinExprOp_1(5L, () => codeContext is NoContext, () => codeContext is DatatypeDecl), () => codeContext is ConstantField))
            {
                isTwoState = MutateCSharp.Schemata432.ReplaceBooleanConstant_0(17L, false);
            }
            else if (MutateCSharp.Schemata432.ReplaceBinExprOp_2(18L, () => codeContext is Function, () => !(codeContext is TwoStateFunction)))
            {
                isTwoState = MutateCSharp.Schemata432.ReplaceBooleanConstant_0(24L, false);
            }
            else
            {
                isTwoState = MutateCSharp.Schemata432.ReplaceBooleanConstant_0(25L, true);
            }
            return new ResolutionContext(codeContext, isTwoState);
        }

        public IMethodCodeContext AsMethodCodeContext => CodeContext as IMethodCodeContext;

        public Method AsMethod => CodeContext as Method;

        public ResolutionContext WithGhost(bool isGhost)
        {
            if (MutateCSharp.Schemata432.ReplaceBinExprOp_3(26L, () => CodeContext.IsGhost, () => isGhost))
            {
                return this;
            }
            return new ResolutionContext(new CodeContextWrapper(CodeContext, isGhost), IsTwoState, InOld, InReveal, InFunctionPostcondition, InFirstPhaseConstructor);
        }
    }
}