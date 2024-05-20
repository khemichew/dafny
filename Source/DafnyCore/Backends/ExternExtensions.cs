using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata229
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT229");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBooleanConstant_4(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
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

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

    }
}

namespace Microsoft.Dafny
{
    public static class ExternExtensions
    {

        public static bool IsExtern(this IAttributeBearingDeclaration declaration, DafnyOptions options, out string/*?*/ qualification, out string/*?*/ name)
        {
            // ensures result==false ==> qualification == null && name == null
            Contract.Ensures(Contract.Result<bool>() || (Contract.ValueAtReturn(out qualification) == null && Contract.ValueAtReturn(out name) == null));
            // ensures result==true ==> qualification != null ==> name != null
            Contract.Ensures(!Contract.Result<bool>() || Contract.ValueAtReturn(out qualification) == null || Contract.ValueAtReturn(out name) != null);

            qualification = null;
            name = null;
            if (!options.DisallowExterns)
            {
                var externArgs = Attributes.FindExpressions(declaration.Attributes, MutateCSharp.Schemata229.ReplaceStringConstant_0(1L, "extern"));
                if (MutateCSharp.Schemata229.ReplaceBinExprOp_1(2L, externArgs, null))
                {
                    if (MutateCSharp.Schemata229.ReplaceBinExprOp_3(7L, externArgs.Count, MutateCSharp.Schemata229.ReplaceNumericConstant_2(3L, 0)))
                    {
                        return MutateCSharp.Schemata229.ReplaceBooleanConstant_4(12L, true);
                    }
                    else if (MutateCSharp.Schemata229.ReplaceBinExprOp_5(26L, () => MutateCSharp.Schemata229.ReplaceBinExprOp_3(17L, externArgs.Count, MutateCSharp.Schemata229.ReplaceNumericConstant_2(13L, 1)), () => externArgs[MutateCSharp.Schemata229.ReplaceNumericConstant_2(22L, 0)] is StringLiteralExpr))
                    {
                        name = externArgs[MutateCSharp.Schemata229.ReplaceNumericConstant_2(32L, 0)].AsStringLiteral();
                        return MutateCSharp.Schemata229.ReplaceBooleanConstant_4(36L, true);
                    }
                    else if (MutateCSharp.Schemata229.ReplaceBinExprOp_5(60L, () => MutateCSharp.Schemata229.ReplaceBinExprOp_5(50L, () => MutateCSharp.Schemata229.ReplaceBinExprOp_3(41L, externArgs.Count, MutateCSharp.Schemata229.ReplaceNumericConstant_2(37L, 2)), () => externArgs[MutateCSharp.Schemata229.ReplaceNumericConstant_2(46L, 0)] is StringLiteralExpr), () => externArgs[MutateCSharp.Schemata229.ReplaceNumericConstant_2(56L, 1)] is StringLiteralExpr))
                    {
                        qualification = externArgs[MutateCSharp.Schemata229.ReplaceNumericConstant_2(66L, 0)].AsStringLiteral();
                        name = externArgs[MutateCSharp.Schemata229.ReplaceNumericConstant_2(70L, 1)].AsStringLiteral();
                        return MutateCSharp.Schemata229.ReplaceBooleanConstant_4(74L, true);
                    }
                }
            }
            return MutateCSharp.Schemata229.ReplaceBooleanConstant_4(75L, false);
        }
    }
}