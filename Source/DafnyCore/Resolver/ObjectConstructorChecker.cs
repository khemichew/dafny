namespace MutateCSharp
{
    internal class Schemata412
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT412");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.ActualBindings argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, Microsoft.Dafny.ModuleDefinition argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static string ReplaceStringConstant_4(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
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

    }
}
//-----------------------------------------------------------------------------
//
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

namespace Microsoft.Dafny
{
    public
class ObjectConstructorChecker : ASTVisitor<IASTVisitorContext>
    {
        private readonly ErrorReporter reporter;

        public ObjectConstructorChecker(ErrorReporter reporter)
        {
            this.reporter = reporter;
        }

        public override IASTVisitorContext GetContext(IASTVisitorContext astVisitorContext, bool inFunctionPostcondition)
        {
            return astVisitorContext;
        }

        protected override bool VisitOneStatement(Statement stmt, IASTVisitorContext context)
        {
            if (stmt is AssignStmt { Rhs: TypeRhs rr } && rr.ArrayDimensions == null && (MutateCSharp.Schemata412.ReplaceBinExprOp_1(2L, () => MutateCSharp.Schemata412.ReplaceBinExprOp_0(1L, rr.Bindings, null), () => rr.InitCall.Method is not Constructor)))
            {
                // this is an AssignStmt that allocates one object and does not call a constructor
                var udt = (UserDefinedType)rr.EType.NormalizeExpand();
                var cl = (ClassLikeDecl)udt.ResolvedClass;
                if (MutateCSharp.Schemata412.ReplaceBinExprOp_2(8L, () => !cl.IsObjectTrait, () => !udt.IsArrayType))
                {
                    var classHasConstructor = cl is ClassDecl { HasConstructor: true };
                    if (MutateCSharp.Schemata412.ReplaceBinExprOp_1(15L, () => classHasConstructor, () => MutateCSharp.Schemata412.ReplaceBinExprOp_3(14L, cl.EnclosingModuleDefinition, context.EnclosingModule)))
                    {
                        reporter.Error(MessageSource.Resolver, stmt,
                          $"when allocating an object of {(classHasConstructor ? "" : MutateCSharp.Schemata412.ReplaceStringConstant_4(21L, "imported "))}type '{cl.Name}', one of its constructor methods must be called");
                    }
                }
            }
            return base.VisitOneStatement(stmt, context);
        }
    }
}
