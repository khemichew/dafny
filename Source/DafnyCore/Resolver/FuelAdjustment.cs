using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Numerics;
namespace MutateCSharp
{
    internal class Schemata400
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT400");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceNumericConstant_5(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, System.Numerics.BigInteger argument1, System.Numerics.BigInteger argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, System.Collections.Generic.List<System.Collections.Generic.List<Microsoft.Dafny.Expression>> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_8(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_7(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, System.Numerics.BigInteger argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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
    public static class FuelAdjustment
    {

        public static void CheckForFuelAdjustments(ErrorReporter reporter, ModuleDefinition module)
        {
            CheckForFuelAdjustments(reporter, module.tok, module.Attributes, module);
            foreach (var clbl in ModuleDefinition.AllItersAndCallables(module.TopLevelDecls))
            {
                Statement body = null;
                if (clbl is Method method)
                {
                    body = method.Body;
                    CheckForFuelAdjustments(reporter, clbl.Tok, method.Attributes, module);
                }
                else if (clbl is IteratorDecl iteratorDecl)
                {
                    body = iteratorDecl.Body;
                    CheckForFuelAdjustments(reporter, clbl.Tok, iteratorDecl.Attributes, module);
                }
                else if (clbl is Function function)
                {
                    CheckForFuelAdjustments(reporter, clbl.Tok, function.Attributes, module);
                    var c = new FuelAdjustment_Visitor(reporter);
                    var bodyExpr = function.Body;
                    if (MutateCSharp.Schemata400.ReplaceBinExprOp_0(1L, bodyExpr, null))
                    {
                        c.Visit(bodyExpr, new FuelAdjustment_Context(module));
                    }
                }

                if (MutateCSharp.Schemata400.ReplaceBinExprOp_1(2L, body, null))
                {
                    var c = new FuelAdjustment_Visitor(reporter);
                    c.Visit(body, new FuelAdjustment_Context(module));
                }
            }
        }

        public static void CheckForFuelAdjustments(ErrorReporter reporter, IToken tok, Attributes attrs, ModuleDefinition currentModule)
        {
            List<List<Expression>> results = Attributes.FindAllExpressions(attrs, MutateCSharp.Schemata400.ReplaceStringConstant_2(3L, "fuel"));

            if (MutateCSharp.Schemata400.ReplaceBinExprOp_3(4L, results, null))
            {
                return;
            }

            foreach (var args in results)
            {
                if (MutateCSharp.Schemata400.ReplaceBinExprOp_7(15L, () => MutateCSharp.Schemata400.ReplaceBinExprOp_4(5L, args, null), () => MutateCSharp.Schemata400.ReplaceBinExprOp_6(10L, args.Count, MutateCSharp.Schemata400.ReplaceNumericConstant_5(6L, 2))))
                {
                    continue;
                }

                // Try to extract the function from the first argument
                var selectExpr = args[MutateCSharp.Schemata400.ReplaceNumericConstant_5(21L, 0)].Resolved as MemberSelectExpr;

                if (selectExpr?.Member is not Function function)
                {
                    continue;
                }

                function.IsFueled = MutateCSharp.Schemata400.ReplaceBooleanConstant_8(25L, true);
                if (MutateCSharp.Schemata400.ReplaceBinExprOp_6(30L, args.Count, MutateCSharp.Schemata400.ReplaceNumericConstant_5(26L, 3)))
                {
                    continue;
                }

                if (args[1] is not LiteralExpr { Value: BigInteger low } ||
                    args[2] is not LiteralExpr { Value: BigInteger high })
                {
                    continue;
                }

                if (!(MutateCSharp.Schemata400.ReplaceBinExprOp_7(52L, () => MutateCSharp.Schemata400.ReplaceBinExprOp_9(35L, high, low + 1), () => (MutateCSharp.Schemata400.ReplaceBinExprOp_11(46L, () => MutateCSharp.Schemata400.ReplaceBinExprOp_10(40L, low, MutateCSharp.Schemata400.ReplaceNumericConstant_5(36L, 0)), () => MutateCSharp.Schemata400.ReplaceBinExprOp_10(45L, high, MutateCSharp.Schemata400.ReplaceNumericConstant_5(41L, 0)))))))
                {
                    reporter.Error(MessageSource.Resolver, tok, MutateCSharp.Schemata400.ReplaceStringConstant_2(58L, "fuel setting for function {0} must have high value == 1 + low value"), function.Name);
                }
            }
        }
    }

    public
    class FuelAdjustment_Visitor : ResolverTopDownVisitor<FuelAdjustment_Context>
    {

        public FuelAdjustment_Visitor(ErrorReporter reporter)
          : base(reporter)
        {
        }

        protected override bool VisitOneStmt(Statement stmt, ref FuelAdjustment_Context st)
        {
            FuelAdjustment.CheckForFuelAdjustments(reporter, stmt.Tok, stmt.Attributes, st.currentModule);
            return MutateCSharp.Schemata400.ReplaceBooleanConstant_8(59L, true);
        }
    }


    public class FuelAdjustment_Context
    {
        public ModuleDefinition currentModule;
        public FuelAdjustment_Context(ModuleDefinition currentModule)
        {
            this.currentModule = currentModule;
        }
    }
}