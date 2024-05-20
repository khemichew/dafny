namespace MutateCSharp
{
    internal class Schemata402
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT402");
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

        internal static string ReplaceStringConstant_3(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
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
/// <summary>
/// This checker prevents the definition of non-terminating functions
/// by storing functions in memory (aka Landin's knots)
/// Thanks to frame information, we need not reject all assignments of
/// functions to memory, but only the ones that are know to have a 
/// read frame.
/// </summary>
class HigherOrderHeapAllocationChecker : ASTVisitor<IASTVisitorContext>
    {
        private readonly ErrorReporter reporter;

        public HigherOrderHeapAllocationChecker(ErrorReporter reporter)
        {
            this.reporter = reporter;
        }

        public override IASTVisitorContext GetContext(IASTVisitorContext astVisitorContext, bool inFunctionPostcondition)
        {
            return astVisitorContext;
        }

        /// <summary>
        /// ContainsRead is a pure function that visits a type to test
        /// for the presence of a memory-reading arrow type ( ~> ).
        /// </summary>
        private bool ContainsRead(Type rhs)
        {

            Type type = rhs.NormalizeExpandKeepConstraints();

            if (type is BasicType)
            {
                return MutateCSharp.Schemata402.ReplaceBooleanConstant_0(1L, false);
            }
            else if (type is MapType)
            {
                var t = (MapType)type;
                return MutateCSharp.Schemata402.ReplaceBinExprOp_1(2L, () => ContainsRead(t.Domain), () => ContainsRead(t.Range));
            }
            else if (type is CollectionType)
            {
                var t = (CollectionType)type;
                return ContainsRead(t.Arg);
            }
            else
            {
                var t = (UserDefinedType)type;
                if (MutateCSharp.Schemata402.ReplaceBinExprOp_2(8L, () => t.IsArrowType, () => !t.IsArrowTypeWithoutReadEffects))
                {
                    return MutateCSharp.Schemata402.ReplaceBooleanConstant_0(14L, true);
                }
                return t.TypeArgs.Exists(ContainsRead);
            }

            return default;
        }

        /// <summary>
        /// VisitOneStatement checks that we do not store in memory a function of
        /// type . ~> .
        /// </summary>
        protected override bool VisitOneStatement(Statement stmt, IASTVisitorContext context)
        {

            // Since all updates and variable declarations are eventually broken down into
            // assignments, we need only consider an AssignStmt.
            if (stmt is AssignStmt { Lhs: { } lhs, Rhs: { } rhs })
            {

                // Memory can be updated either by writing to a sequence-like collection
                // or by writing to an object's field.
                if (lhs is MemberSelectExpr or SeqSelectExpr)
                {

                    // The only case of interest is when the right hand side of the assignment 
                    // is an expression. The case where it is a type expression (new) is handled
                    // by a different check.
                    if (rhs is ExprRhs { Expr: { Type: { } type } })
                    {

                        // If the assignment contains a function with read effects, it must be rejected.
                        // It would not be enough to check that the RHS is of type . ~> . because
                        // one can hide such a function deep into another type.
                        // It is plausible that using write frame information, we could relax this check
                        // by ensuring that the read frame of the function and the write frame of the context
                        // are disjoint, but this would require an inter-procedural analysis.
                        if (ContainsRead(type))
                        {
                            reporter.Error(MessageSource.Resolver, stmt,
                MutateCSharp.Schemata402.ReplaceStringConstant_3(15L, "To prevent the creation of non-terminating functions, storing functions with read effects into memory is disallowed"));
                        }
                    }
                }
            }

            return base.VisitOneStatement(stmt, context);
        }
    }
}