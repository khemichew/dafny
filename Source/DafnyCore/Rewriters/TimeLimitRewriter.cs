using System.Collections.Generic;
using System.Diagnostics.Contracts;
using static Microsoft.Dafny.RewriterErrors;
namespace MutateCSharp
{
    internal class Schemata466
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT466");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
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

        internal static int ReplaceNumericConstant_3(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, long argument1, long argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static uint ReplaceNumericConstant_7(long mutantId, uint argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 2)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_2(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{

    /// <summary>
    /// Replace all occurrences of attribute {:timeLimitMultiplier X} with {:timeLimit Y}
    /// where Y = X*default-time-limit or Y = X*command-line-time-limit
    /// </summary>
    public class TimeLimitRewriter : IRewriter
    {
        public TimeLimitRewriter(ErrorReporter reporter)
          : base(reporter)
        {
            Contract.Requires(reporter != null);
        }

        internal override void PreResolve(ModuleDefinition m)
        {
            foreach (var d in m.TopLevelDecls)
            {
                if (d is TopLevelDeclWithMembers tld)
                {
                    foreach (MemberDecl member in tld.Members)
                    {
                        if (MutateCSharp.Schemata466.ReplaceBinExprOp_0(1L, () => member is Function, () => member is Method))
                        {
                            // Check for the timeLimitMultiplier attribute
                            if (Attributes.Contains(member.Attributes, MutateCSharp.Schemata466.ReplaceStringConstant_1(7L, "timeLimitMultiplier")))
                            {
                                Attributes attrs = member.Attributes;
                                foreach (var attr in attrs.AsEnumerable())
                                {
                                    if (MutateCSharp.Schemata466.ReplaceBinExprOp_2(9L, attr.Name, MutateCSharp.Schemata466.ReplaceStringConstant_1(8L, "timeLimitMultiplier")))
                                    {
                                        if (MutateCSharp.Schemata466.ReplaceBinExprOp_5(23L, () => MutateCSharp.Schemata466.ReplaceBinExprOp_4(14L, attr.Args.Count, MutateCSharp.Schemata466.ReplaceNumericConstant_3(10L, 1)), () => attr.Args[MutateCSharp.Schemata466.ReplaceNumericConstant_3(19L, 0)] is LiteralExpr))
                                        {
                                            var arg = attr.Args[MutateCSharp.Schemata466.ReplaceNumericConstant_3(29L, 0)] as LiteralExpr;
                                            System.Numerics.BigInteger value = (System.Numerics.BigInteger)arg.Value;
                                            if (MutateCSharp.Schemata466.ReplaceBinExprOp_6(37L, value.Sign, MutateCSharp.Schemata466.ReplaceNumericConstant_3(33L, 0)))
                                            {
                                                uint current_limit = MutateCSharp.Schemata466.ReplaceNumericConstant_7(42L, 0);
                                                string name = "";
                                                if (MutateCSharp.Schemata466.ReplaceBinExprOp_8(48L, Reporter.Options.ResourceLimit, MutateCSharp.Schemata466.ReplaceNumericConstant_7(45L, 0)))
                                                {
                                                    // Interpret this as multiplying the resource limit
                                                    current_limit = Reporter.Options.ResourceLimit;
                                                    name = MutateCSharp.Schemata466.ReplaceStringConstant_1(53L, "rlimit");
                                                }
                                                else
                                                {
                                                    // Interpret this as multiplying the time limit
                                                    current_limit = MutateCSharp.Schemata466.ReplaceBinExprOp_8(57L, Reporter.Options.TimeLimit, MutateCSharp.Schemata466.ReplaceNumericConstant_7(54L, 0)) ? Reporter.Options.TimeLimit : MutateCSharp.Schemata466.ReplaceNumericConstant_7(62L, 10);  // Default to 10 seconds
                                                    name = MutateCSharp.Schemata466.ReplaceStringConstant_1(65L, "timeLimit");
                                                }
                                                Expression newArg = new LiteralExpr(attr.Args[MutateCSharp.Schemata466.ReplaceNumericConstant_3(66L, 0)].tok, value * current_limit);
                                                member.Attributes = new Attributes(MutateCSharp.Schemata466.ReplaceStringConstant_1(70L, "_") + name, new List<Expression>() { newArg }, attrs);
                                                if (Attributes.Contains(attrs, name))
                                                {
                                                    ReportWarning(ErrorId.rw_timelimit_multiplier, member.tok, MutateCSharp.Schemata466.ReplaceStringConstant_1(71L, "timeLimitMultiplier annotation overrides ") + name + MutateCSharp.Schemata466.ReplaceStringConstant_1(72L, " annotation"));
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}