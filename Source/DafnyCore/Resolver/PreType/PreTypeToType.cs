//-----------------------------------------------------------------------------
//
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata427
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT427");
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

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.CallStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.Expression argument1, Microsoft.Dafny.Expression argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.UpdateStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_5(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

    }
}

namespace Microsoft.Dafny
{
    public
/// <summary>
/// The purpose of the PreTypeToTypeVisitor is to fill in a type to each expression and other AST nodes where types make
/// sense. This computation of this type draws from two sources:
///    - the pre-type inferred earlier
///    - any user-supplied type
/// For most AST nodes, this will not consider subset types; instead, subset types are considered later during
/// the type refinement phase.
///
/// Of the types filled in here, two special TypeProxy's are used.
///    - TypeRefinementWrapper
///    - BottomTypePlaceholder
/// </summary>
class PreTypeToTypeVisitor : ASTVisitor<IASTVisitorContext>
    {
        public override IASTVisitorContext GetContext(IASTVisitorContext astVisitorContext, bool inFunctionPostcondition)
        {
            return astVisitorContext;
        }

        private readonly SystemModuleManager systemModuleManager;

        public PreTypeToTypeVisitor(SystemModuleManager systemModuleManager)
        {
            this.systemModuleManager = systemModuleManager;
        }

        /// <summary>
        /// This method combines the inferred pre-type with any user-supplied type for newtype, subset type,
        /// and const declarations. Those are the declarations whose signature contains inferred elements.
        /// When the other declarations are visited, it is expected that the signatures of all top-level and
        /// member declarations have types. For example, to call NormalizeExpand() on a subset type requires
        /// knowing its Rhs type, and visiting a MemberSelectExpr for a constant field requires knowing the
        /// type of the field.
        /// </summary>
        public void VisitConstantsAndRedirectingTypes(List<TopLevelDecl> declarations)
        {
            foreach (var decl in declarations)
            {
                if (decl is NewtypeDecl newtypeDecl)
                {
                    PreType2TypeUtil.Combine(newtypeDecl.BaseType, newtypeDecl.BasePreType, MutateCSharp.Schemata427.ReplaceBooleanConstant_0(1L, false));
                }
                else if (decl is SubsetTypeDecl subsetTypeDecl)
                {
                    PreType2TypeUtil.Combine(subsetTypeDecl.Var.Type, subsetTypeDecl.Var.PreType, MutateCSharp.Schemata427.ReplaceBooleanConstant_0(2L, false));
                }
                if (decl is TopLevelDeclWithMembers topLevelDeclWithMembers)
                {
                    foreach (var member in topLevelDeclWithMembers.Members.Where(member => member is ConstantField))
                    {
                        var constField = (ConstantField)member;
                        PreType2TypeUtil.Combine(constField.Type, constField.PreType, MutateCSharp.Schemata427.ReplaceBooleanConstant_0(3L, true));
                    }
                }
            }
        }

        /// <summary>
        /// This method should be called only after VisitConstantsAndRedirectingTypes has been called.
        /// </summary>
        protected override void VisitOneDeclaration(TopLevelDecl decl)
        {
            if (decl is NewtypeDecl newtypeDecl)
            {
                PreType2TypeUtil.Combine(newtypeDecl.BaseType, newtypeDecl.BasePreType, MutateCSharp.Schemata427.ReplaceBooleanConstant_0(4L, false));
            }
            else if (decl is SubsetTypeDecl subsetTypeDecl)
            {
                PreType2TypeUtil.Combine(subsetTypeDecl.Var.Type, subsetTypeDecl.Var.PreType, MutateCSharp.Schemata427.ReplaceBooleanConstant_0(5L, false));
            }

            base.VisitOneDeclaration(decl);
        }

        public override void VisitField(Field field)
        {
            if (field is ConstantField ||
                (field.EnclosingClass is IteratorDecl iteratorDecl && iteratorDecl.DecreasesFields.Contains(field)))
            {
                // The type of the const might have been omitted in the program text and then inferred.
                // Also, the automatically generated _decreases fields of an iterator have inferred types.
                PreType2TypeUtil.Combine(field.Type, field.PreType, MutateCSharp.Schemata427.ReplaceBooleanConstant_0(6L, true));
            }

            base.VisitField(field);
        }

        private static void VisitVariableList(IEnumerable<IVariable> variables, bool allowFutureRefinements)
        {
            foreach (var v in variables)
            {
                PreType2TypeUtil.Combine(v.Type, v.PreType, allowFutureRefinements);
            }
        }

        protected override bool VisitOneExpression(Expression expr, IASTVisitorContext context)
        {
            if (expr is DatatypeUpdateExpr datatypeUpdateExpr)
            {
                // How a DatatypeUpdateExpr desugars depends on whether or not the expression is ghost, which hasn't been determined
                // yet. So, if there is a difference between the two, then pre-type resolution prepares two different resolved expressions.
                // The choice between these two is done in a later phase during resolution. For now, if there are two, we visit them both.
                // ASTVisitor arranges to visit ResolvedExpression, but we consider ResolvedCompiledExpression here.
                if (MutateCSharp.Schemata427.ReplaceBinExprOp_1(7L, datatypeUpdateExpr.ResolvedCompiledExpression, datatypeUpdateExpr.ResolvedExpression))
                {
                    VisitExpression(datatypeUpdateExpr.ResolvedCompiledExpression, context);
                }
            }
            return base.VisitOneExpression(expr, context);
        }

        protected override void PostVisitOneExpression(Expression expr, IASTVisitorContext context)
        {
            if (expr is LiteralExpr or ThisExpr)
            {
                // Note, for the LiteralExpr "null", we expect to get a possibly-null type, whereas for a reference-type ThisExpr, we expect
                // to get the non-null type. The .PreType of these two distinguish between those cases, because the latter has a .PrintablePreType
                // field that gives the non-null type.
                expr.Type = PreType2TypeUtil.PreType2FixedType(expr.PreType);
                return;
            }
            else if (expr is FunctionCallExpr functionCallExpr)
            {
                functionCallExpr.TypeApplication_AtEnclosingClass = functionCallExpr.PreTypeApplication_AtEnclosingClass.ConvertAll(PreType2TypeUtil.PreType2FixedType);
                functionCallExpr.TypeApplication_JustFunction = PreType2TypeUtil.Combine(functionCallExpr.TypeApplication_JustFunction,
                  functionCallExpr.PreTypeApplication_JustFunction, MutateCSharp.Schemata427.ReplaceBooleanConstant_0(8L, true));
            }
            else if (expr is MemberSelectExpr memberSelectExpr)
            {
                memberSelectExpr.TypeApplication_AtEnclosingClass = memberSelectExpr.PreTypeApplication_AtEnclosingClass.ConvertAll(PreType2TypeUtil.PreType2FixedType);
                memberSelectExpr.TypeApplication_JustMember =
                  PreType2TypeUtil.Combine(memberSelectExpr.TypeApplication_JustMember, memberSelectExpr.PreTypeApplication_JustMember, MutateCSharp.Schemata427.ReplaceBooleanConstant_0(9L, true));
            }
            else if (expr is ComprehensionExpr comprehensionExpr)
            {
                VisitVariableList(comprehensionExpr.BoundVars, MutateCSharp.Schemata427.ReplaceBooleanConstant_0(10L, false));
            }
            else if (expr is LetExpr letExpr)
            {
                VisitVariableList(letExpr.BoundVars, letExpr.Exact);
                foreach (var lhs in letExpr.LHSs)
                {
                    VisitPattern(lhs, context);
                }
            }
            else if (expr is DatatypeValue datatypeValue)
            {
                Contract.Assert(datatypeValue.InferredTypeArgs.Count == 0 || datatypeValue.InferredTypeArgs.Count == datatypeValue.InferredPreTypeArgs.Count);
                if (MutateCSharp.Schemata427.ReplaceBinExprOp_3(15L, datatypeValue.InferredTypeArgs.Count, MutateCSharp.Schemata427.ReplaceNumericConstant_2(11L, 0)))
                {
                    var datatypeDecl = datatypeValue.Ctor.EnclosingDatatype;
                    Contract.Assert(datatypeValue.InferredPreTypeArgs.Count == datatypeDecl.TypeArgs.Count);
                    for (var i = MutateCSharp.Schemata427.ReplaceNumericConstant_2(20L, 0); MutateCSharp.Schemata427.ReplaceBinExprOp_4(24L, i, datatypeDecl.TypeArgs.Count); MutateCSharp.Schemata427.ReplacePostfixUnaryExprOp_5(29L, ref i))
                    {
                        var formal = datatypeDecl.TypeArgs[i];
                        var actualPreType = datatypeValue.InferredPreTypeArgs[i];
                        datatypeValue.InferredTypeArgs.Add(PreType2TypeUtil.PreType2RefinableType(actualPreType, formal.Variance));
                    }
                }
            }
            else if (expr is ConversionExpr conversionExpr)
            {
                PreType2TypeUtil.Combine(conversionExpr.ToType, conversionExpr.PreType, MutateCSharp.Schemata427.ReplaceBooleanConstant_0(30L, false));
                expr.Type = conversionExpr.ToType;
                return;
            }

            if (expr.PreType is UnusedPreType)
            {
                expr.Type = new InferredTypeProxy();
                return;
            }

            // In what remains, we set the type of the expression in one of four ways:
            //   - The expression gets set to a fixed version of expr.PreType. For example, integer plus, which is
            //     always int, regardless of any subset type of the operands.
            //   - The expression gets set to a fixed subset type. For example, multiset selection returns a nat.
            //   - The expression type is fused directly with the type of some subexpression. This means that any
            //     later refinements of the type of the subexpression is immediately reflected in the type of the expression,
            //     without needing to set up any "flow". For example, the type of a ConcreteSyntaxExpression is fused
            //     with the type of its .ResolvedExpression.
            //   - The expression type gets set to a refinement-wrapper version of expr.PreType, specifically
            //     _bottom<expr.PreType> (that is, expr.PreType as a type with the strongest possible constraint).
            //     For example, IdentifierExpr, which gets a refinement-wrapper type (into which the type from the identifier's
            //     declaration will later flow).

            // Case: fuse the type
            if (expr is ConcreteSyntaxExpression { ResolvedExpression: { } resolvedExpression })
            {
                expr.UnnormalizedType = resolvedExpression.UnnormalizedType;
                return;
            }
            else if (expr is StmtExpr stmtExpr)
            {
                expr.UnnormalizedType = stmtExpr.E.UnnormalizedType;
                return;
            }

            // Case: fixed subset type
            if (expr is SeqSelectExpr { Seq: { Type: { AsMultiSetType: { } } } })
            {
                expr.UnnormalizedType = systemModuleManager.Nat();
                return;
            }

            // Case: fixed pre-type type
            if (expr is LiteralExpr or ThisExpr or UnaryExpr or BinaryExpr or NegationExpression or DisplayExpression or MapDisplayExpr)
            {
                // Note, for the LiteralExpr "null", we expect to get a possibly-null type, whereas for a reference-type ThisExpr, we expect
                // to get the non-null type. The .PreType of these two distinguish between those cases, because the latter has a .PrintablePreType
                // field that gives the non-null type.
                expr.Type = PreType2TypeUtil.PreType2FixedType(expr.PreType);
                return;
            }

            // Case: refinement-wrapper pre-type type
            expr.UnnormalizedType = PreType2TypeUtil.PreType2RefinableType(expr.PreType, TypeParameter.TPVariance.Co);
        }

        private void VisitPattern<VT>(CasePattern<VT> casePattern, IASTVisitorContext context) where VT : class, IVariable
        {
            if (casePattern.Var != null)
            {
                PreType2TypeUtil.Combine(casePattern.Var.Type, casePattern.Var.PreType, MutateCSharp.Schemata427.ReplaceBooleanConstant_0(31L, false));
            }
            VisitExpression(casePattern.Expr, context);

            casePattern.Arguments?.ForEach(v => VisitPattern(v, context));
        }

        protected override bool VisitOneStatement(Statement stmt, IASTVisitorContext context)
        {
            if (stmt is VarDeclStmt varDeclStmt)
            {
                VisitVariableList(varDeclStmt.Locals, MutateCSharp.Schemata427.ReplaceBooleanConstant_0(32L, true));
            }
            else if (stmt is VarDeclPattern varDeclPattern)
            {
                VisitVariableList(varDeclPattern.LocalVars, MutateCSharp.Schemata427.ReplaceBooleanConstant_0(33L, true));
            }
            else if (stmt is ForLoopStmt forLoopStmt)
            {
                PreType2TypeUtil.Combine(forLoopStmt.LoopIndex.Type, forLoopStmt.LoopIndex.PreType, MutateCSharp.Schemata427.ReplaceBooleanConstant_0(34L, false));
            }
            else if (stmt is ForallStmt forallStmt)
            {
                VisitVariableList(forallStmt.BoundVars, MutateCSharp.Schemata427.ReplaceBooleanConstant_0(35L, false));
            }

            return base.VisitOneStatement(stmt, context);
        }

        protected override void PostVisitOneStatement(Statement stmt, IASTVisitorContext context)
        {
            if (stmt is VarDeclPattern varDeclPattern)
            {
                VisitPattern(varDeclPattern.LHS, context);
            }
            else if (stmt is AssignStmt { Rhs: TypeRhs tRhs })
            {
                Type rhsType;
                // convert the type of the RHS, which we expect to be a reference type, and then create the non-null version of it
                var udtConvertedFromPretype = (UserDefinedType)PreType2TypeUtil.PreType2FixedType(tRhs.PreType);
                Contract.Assert(udtConvertedFromPretype.IsRefType);
                if (MutateCSharp.Schemata427.ReplaceBinExprOp_6(36L, tRhs.ArrayDimensions, null))
                {
                    // In this case, we expect tRhs.PreType (and udtConvertedFromPretype) to be an array type
                    var arrayPreType = (DPreType)tRhs.PreType.Normalize();
                    Contract.Assert(arrayPreType.Decl is ArrayClassDecl);
                    Contract.Assert(arrayPreType.Arguments.Count == 1);
                    Contract.Assert(udtConvertedFromPretype.ResolvedClass is ArrayClassDecl);
                    Contract.Assert(udtConvertedFromPretype.TypeArgs.Count == 1);

                    // The user-supplied tRhs.EType may have some components that are more exact than what's in udtConvertedFromPretype, since
                    // tRhs.EType may contain user-supplied subset types. But tRhs.EType may also be missing some type arguments altogether, because
                    // they may have been omitted in the source text. The following has the effect of filling in any such missing components with
                    // whatever was inferred during pre-type inference.
                    PreType2TypeUtil.Combine(tRhs.EType, arrayPreType.Arguments[MutateCSharp.Schemata427.ReplaceNumericConstant_2(37L, 0)], MutateCSharp.Schemata427.ReplaceBooleanConstant_0(41L, false));
                    var arrayTypeDecl = systemModuleManager.arrayTypeDecls[tRhs.ArrayDimensions.Count];
                    var rhsMaybeNullType = new UserDefinedType(stmt.tok, arrayTypeDecl.Name, arrayTypeDecl, new List<Type>() { tRhs.EType });
                    rhsType = UserDefinedType.CreateNonNullType(rhsMaybeNullType);
                }
                else
                {
                    // Fill in any missing type arguments in the user-supplied tRhs.EType.
                    PreType2TypeUtil.Combine(tRhs.EType, tRhs.PreType, MutateCSharp.Schemata427.ReplaceBooleanConstant_0(42L, false));
                    rhsType = (UserDefinedType)tRhs.EType;
                    if (MutateCSharp.Schemata427.ReplaceBinExprOp_7(43L, tRhs.InitCall, null))
                    {
                        // We want the type of tRhs.InitCall.MethodSelect.Obj to be the same as what the "new" gives, but the previous
                        // visitation of this MemberSelectExpr would have set it to the type obtained from the pre-type. Since the MemberSelectExpr
                        // won't be visited again during type refinement, we set it here once and for all.
                        tRhs.InitCall.MethodSelect.Obj.UnnormalizedType = rhsType;
                    }
                }
                tRhs.Type = rhsType;

            }
            else if (stmt is AssignSuchThatStmt assignSuchThatStmt)
            {
                foreach (var lhs in assignSuchThatStmt.Lhss)
                {
                    VisitExpression(lhs, context);
                }

            }
            else if (stmt is ProduceStmt produceStmt)
            {
                if (MutateCSharp.Schemata427.ReplaceBinExprOp_8(44L, produceStmt.HiddenUpdate, null))
                {
                    VisitStatement(produceStmt.HiddenUpdate, context);
                }

            }
            else if (stmt is CalcStmt calcStmt)
            {
                // The expression in each line has been visited, but pairs of those lines are then put together to
                // form steps. These steps (are always boolean, and) need to be visited, too. Their subexpressions
                // have already been visited, so it suffices to call PostVisitOneExpression (instead of VisitExpression)
                // here.
                foreach (var step in calcStmt.Steps)
                {
                    PostVisitOneExpression(step, context);
                }
                PostVisitOneExpression(calcStmt.Result, context);
            }

            base.PostVisitOneStatement(stmt, context);
        }

        protected override void VisitExtendedPattern(ExtendedPattern pattern, IASTVisitorContext context)
        {
            switch (pattern)
            {
                case DisjunctivePattern disjunctivePattern:
                    break;
                    break;
                case LitPattern litPattern:
                    PostVisitOneExpression(litPattern.OptimisticallyDesugaredLit, context);
                    break;
                    break;
                case IdPattern idPattern:
                    if (idPattern.BoundVar != null)
                    {
                        PreType2TypeUtil.Combine(idPattern.BoundVar.Type, idPattern.BoundVar.PreType, false);
                    }
                    if (idPattern.ResolvedLit != null)
                    {
                        PostVisitOneExpression(idPattern.ResolvedLit, context);
                    }
                    break;
                    break;
                default:
                    Contract.Assert(false); // unexpected case
                    break;
                    break;
            }
            base.VisitExtendedPattern(pattern, context);
        }

    }
}
