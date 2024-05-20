namespace MutateCSharp
{
    internal class Schemata403
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT403");
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
/// by storing functions in memory (aka Landin's knots) during the 
/// creation of an object. This could also be prevented by doing 
/// a cardinality check on the type of class (similar to what is done
/// for algebraic datatypes) but at a fundamental level, the issue is
/// the creation of a Landin's knot, and it is easier and safer to catch
/// this way because of type parameters and traits.
/// Thanks to frame information, we need not reject all assignments of
/// functions to memory, but only the ones that are know to have a 
/// read frame.
/// To understand this checker, it is recommended to first look at
/// HigherOrderHeapAllocationChecker.
/// </summary>
class HigherOrderHeapAllocationCheckerConstructor : ASTVisitor<IASTVisitorContext>
    {
        private readonly ErrorReporter reporter;

        public HigherOrderHeapAllocationCheckerConstructor(ErrorReporter reporter)
        {
            this.reporter = reporter;
        }

        public override IASTVisitorContext GetContext(IASTVisitorContext astVisitorContext, bool inFunctionPostcondition)
        {
            return astVisitorContext;
        }

        /// <summary>
        /// Occurs is a pure function that visits a type (rhs) to test
        /// for the presence of an heap-allocated type (Obj) left of
        /// an arrow. 
        /// This check could be relaxed but we keep it simple until
        /// we encounter a good use case for the more general check.
        /// Recall that a cycle can only be created using a function,
        /// which is why the test is different than a traditional
        /// cardinality test.
        /// </summary>
        private bool Occurs(Type obj, Type rhs, bool left)
        {
            Type type = rhs.NormalizeExpand();
            if (type is BasicType)
            {
                return MutateCSharp.Schemata403.ReplaceBooleanConstant_0(1L, false);
            }
            else if (type is MapType)
            {
                var t = (MapType)type;
                return MutateCSharp.Schemata403.ReplaceBinExprOp_1(2L, () => Occurs(obj, t.Domain, left), () => Occurs(obj, t.Range, left));
            }
            else if (type is SetType)
            {
                var t = (SetType)type;
                return Occurs(obj, t.Arg, left);
            }
            else if (type is CollectionType)
            {
                var t = (CollectionType)type;
                return Occurs(obj, t.Arg, left);
            }
            else
            {
                var t = (UserDefinedType)type;
                if (MutateCSharp.Schemata403.ReplaceBinExprOp_2(8L, () => left, () => Type.Equal_Improved(obj, t)))
                {
                    return MutateCSharp.Schemata403.ReplaceBooleanConstant_0(14L, true);
                }
                if (MutateCSharp.Schemata403.ReplaceBinExprOp_2(15L, () => left, () => t.IsTraitType))
                {
                    return MutateCSharp.Schemata403.ReplaceBooleanConstant_0(21L, true);
                }
                var b = MutateCSharp.Schemata403.ReplaceBooleanConstant_0(22L, false);
                if (t.IsArrowType)
                {
                    var arrow = type.AsArrowType;
                    b = MutateCSharp.Schemata403.ReplaceBinExprOp_1(24L, () => b, () => arrow.TypeArgs.Exists(typeArg => Occurs(obj, typeArg, MutateCSharp.Schemata403.ReplaceBooleanConstant_0(23L, true))));
                }
                return MutateCSharp.Schemata403.ReplaceBinExprOp_1(30L, () => b, () => t.TypeArgs.Exists(typeArg => Occurs(obj, typeArg, left)));
            }

            return default;
        }

        protected override bool VisitOneStatement(Statement stmt, IASTVisitorContext context)
        {

            // Assigments to constant fields in constructors boil down to an assignment.
            if (stmt is AssignStmt assign)
            {

                var lhs = assign.Lhs;
                Type lhsType;

                // We need to make sure that if a function is written to a field
                // it does not refer to the type of the object being assigned to.
                // Note that the function may not be of type . ~> . because
                // functions of type . ~> . can be assigned to constant fields
                // of type . -> . during the object's construction.
                if (lhs is MemberSelectExpr mseLhs)
                {

                    lhsType = mseLhs.Obj.Type.NormalizeExpand();

                    var rhs = assign.Rhs;
                    if (rhs is ExprRhs eRhs)
                    {
                        var exp = eRhs.Expr;
                        var type = exp.Type;

                        if (Occurs(lhsType, type, MutateCSharp.Schemata403.ReplaceBooleanConstant_0(36L, false)))
                        {
                            reporter.Error(MessageSource.Resolver, stmt,
                MutateCSharp.Schemata403.ReplaceStringConstant_3(37L, "To prevent the creation of non-terminating functions, storing functions into an object's fields that reads the object is disallowed"));
                        }
                    }
                }
            }

            return base.VisitOneStatement(stmt, context);
        }
    }
}