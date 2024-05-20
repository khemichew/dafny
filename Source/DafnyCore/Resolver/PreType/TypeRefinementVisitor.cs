//-----------------------------------------------------------------------------
//
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata428
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT428");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceNumericConstant_1(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.Expression argument1, Microsoft.Dafny.Expression argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_6(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.UpdateStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBooleanConstant_10(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.SeqType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_4(long mutantId, string argument1)
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
    /// The purpose of the TypeRefinementVisitor is to incorporate subset types into the types that were inferred during
    /// pre-type inference. The visitor collects constraints, which are solved by the Solve() method.
    /// </summary>
    public class TypeRefinementVisitor : ASTVisitor<IASTVisitorContext>
    {
        private string moduleDescription;
        public override IASTVisitorContext GetContext(IASTVisitorContext astVisitorContext, bool inFunctionPostcondition)
        {
            return astVisitorContext;
        }

        private readonly SystemModuleManager systemModuleManager;

        public TypeRefinementVisitor(string moduleDescription, SystemModuleManager systemModuleManager)
        {
            this.moduleDescription = moduleDescription;
            this.systemModuleManager = systemModuleManager;
        }

        private readonly List<Flow> flows = new();

        public void DebugPrint()
        {
            systemModuleManager.Options.OutputWriter.WriteLine($"--------------------------- type-refinement flows, {moduleDescription}:");
            foreach (var flow in flows)
            {
                flow.DebugPrint(systemModuleManager.Options.OutputWriter);
            }
            systemModuleManager.Options.OutputWriter.WriteLine($"------------------- (end of type-refinement flows, {moduleDescription})");
        }

        protected override bool VisitOneExpression(Expression expr, IASTVisitorContext context)
        {
            if (expr is DatatypeUpdateExpr datatypeUpdateExpr)
            {
                // How a DatatypeUpdateExpr desugars depends on whether or not the expression is ghost, which hasn't been determined
                // yet. So, if there is a difference between the two, then pre-type resolution prepares two different resolved expressions.
                // The choice between these two is done in a later phase during resolution. For now, if there are two, we visit them both.
                // ASTVisitor arranges to visit ResolvedExpression, but we consider ResolvedCompiledExpression here.
                if (MutateCSharp.Schemata428.ReplaceBinExprOp_0(1L, datatypeUpdateExpr.ResolvedCompiledExpression, datatypeUpdateExpr.ResolvedExpression))
                {
                    VisitExpression(datatypeUpdateExpr.ResolvedCompiledExpression, context);
                }
            }
            return base.VisitOneExpression(expr, context);
        }

        protected override void PostVisitOneExpression(Expression expr, IASTVisitorContext context)
        {
            if (expr is IdentifierExpr identifierExpr)
            {
                flows.Add(new FlowFromType(expr, identifierExpr.Var.UnnormalizedType, identifierExpr.Name));

            }
            else if (expr is SeqSelectExpr selectExpr)
            {
                var unnormalizedSeqType = selectExpr.Seq.UnnormalizedType;
                var seqType = selectExpr.Seq.Type.NormalizeToAncestorType();
                if (!selectExpr.SelectOne)
                {
                    var sinkType = selectExpr.Type.NormalizeToAncestorType().AsSeqType;
                    flows.Add(new FlowFromType(sinkType.Arg, seqType.TypeArgs[MutateCSharp.Schemata428.ReplaceNumericConstant_1(2L, 0)], expr.tok));
                }
                else if (MutateCSharp.Schemata428.ReplaceBinExprOp_3(7L, () => MutateCSharp.Schemata428.ReplaceBinExprOp_2(6L, seqType.AsSeqType, null), () => seqType.IsArrayType))
                {
                    flows.Add(new FlowFromTypeArgument(expr, unnormalizedSeqType, MutateCSharp.Schemata428.ReplaceNumericConstant_1(13L, 0)));
                }
                else if (MutateCSharp.Schemata428.ReplaceBinExprOp_3(17L, () => seqType.IsMapType, () => seqType.IsIMapType))
                {
                    flows.Add(new FlowFromTypeArgument(expr, unnormalizedSeqType, MutateCSharp.Schemata428.ReplaceNumericConstant_1(23L, 1)));
                }
                else
                {
                    Contract.Assert(seqType.AsMultiSetType != null);
                    // type is fixed, so no flow to set up
                }

            }
            else if (expr is MultiSelectExpr multiSelectExpr)
            {
                flows.Add(new FlowFromTypeArgument(expr, multiSelectExpr.Array.UnnormalizedType, MutateCSharp.Schemata428.ReplaceNumericConstant_1(27L, 0)));

            }
            else if (expr is ITEExpr iteExpr)
            {
                flows.Add(new FlowBetweenExpressions(expr, iteExpr.Thn, MutateCSharp.Schemata428.ReplaceStringConstant_4(31L, "if-then")));
                flows.Add(new FlowBetweenExpressions(expr, iteExpr.Els, MutateCSharp.Schemata428.ReplaceStringConstant_4(32L, "if-else")));

            }
            else if (expr is NestedMatchExpr matchExpr)
            {
                foreach (var kase in matchExpr.Cases)
                {
                    flows.Add(new FlowBetweenExpressions(expr, kase.Body, MutateCSharp.Schemata428.ReplaceStringConstant_4(33L, "case")));
                }

            }
            else if (expr is MemberSelectExpr memberSelectExpr)
            {
                if (memberSelectExpr.Member is Field field)
                {
                    var dPreType = (DPreType)memberSelectExpr.Obj.PreType.Normalize();
                    if (dPreType.Decl is ValuetypeDecl valuetypeDecl)
                    {
                        flows.Add(new FlowFromComputedType(expr, () =>
                        {
                            // TypeArgumentSubstitutionsWithParents doesn't work with ValuetypeDecl, so we roll our own type map
                            var receiverType = memberSelectExpr.Obj.Type.NormalizeExpand();
                            Contract.Assert(receiverType.TypeArgs.Count == valuetypeDecl.TypeArgs.Count);
                            var typeMap = TypeParameter.SubstitutionMap(valuetypeDecl.TypeArgs, receiverType.TypeArgs);
                            return field.Type.Subst(typeMap);
                        }, $".{memberSelectExpr.MemberName}"));
                    }
                    else
                    {
                        flows.Add(new FlowFromComputedType(expr, () =>
                        {
                            var typeMap = memberSelectExpr.TypeArgumentSubstitutionsWithParents();
                            return field.Type.Subst(typeMap);
                        }, $".{memberSelectExpr.MemberName}"));
                    }
                }
                else if (memberSelectExpr.Member is Function function)
                {
                    flows.Add(new FlowFromComputedType(expr, () =>
                    {
                        var typeMap = memberSelectExpr.TypeArgumentSubstitutionsWithParents();
                        return ModuleResolver.SelectAppropriateArrowTypeForFunction(function, typeMap, systemModuleManager);
                    }, $".{memberSelectExpr.MemberName}"));
                }

            }
            else if (expr is FunctionCallExpr functionCallExpr)
            {
                Contract.Assert(functionCallExpr.Args.Count == functionCallExpr.Function.Ins.Count);
                for (var i = MutateCSharp.Schemata428.ReplaceNumericConstant_1(34L, 0); MutateCSharp.Schemata428.ReplaceBinExprOp_5(38L, i, functionCallExpr.Args.Count); MutateCSharp.Schemata428.ReplacePostfixUnaryExprOp_6(43L, ref i))
                {
                    var formal = functionCallExpr.Function.Ins[i];
                    var actual = functionCallExpr.Args[i];
                    flows.Add(new FlowBetweenComputedTypes(() =>
                    {
                        var typeMap = functionCallExpr.TypeArgumentSubstitutionsWithParents();
                        return (TypeRefinementWrapper.NormalizeSansBottom(formal).Subst(typeMap), TypeRefinementWrapper.NormalizeSansBottom(actual));
                    }, functionCallExpr.tok, $"{functionCallExpr.Function.Name}({formal.Name} := ...)"));
                }

                flows.Add(new FlowFromComputedType(expr, () =>
                {
                    var typeMap = functionCallExpr.TypeArgumentSubstitutionsWithParents();
                    return functionCallExpr.Function.ResultType.Subst(typeMap);
                }, $"{functionCallExpr.Name}(...)"));

            }
            else if (expr is DatatypeValue datatypeValue)
            {
                var ctor = datatypeValue.Ctor;
                var datatypeDecl = ctor.EnclosingDatatype;
                for (var i = MutateCSharp.Schemata428.ReplaceNumericConstant_1(44L, 0); MutateCSharp.Schemata428.ReplaceBinExprOp_5(48L, i, datatypeValue.Arguments.Count); MutateCSharp.Schemata428.ReplacePostfixUnaryExprOp_6(53L, ref i))
                {
                    var formal = ctor.Formals[i];
                    var actual = datatypeValue.Arguments[i];
                    flows.Add(new FlowBetweenComputedTypes(() =>
                    {
                        var typeMap = TypeParameter.SubstitutionMap(datatypeDecl.TypeArgs, datatypeValue.InferredTypeArgs);
                        return (TypeRefinementWrapper.NormalizeSansBottom(formal).Subst(typeMap), TypeRefinementWrapper.NormalizeSansBottom(actual));
                    }, datatypeValue.tok, $"{ctor.Name}({formal.Name} := ...)"));
                }
                flows.Add(new FlowFromComputedType(expr,
                  () => new UserDefinedType(expr.tok, datatypeDecl.Name, datatypeDecl, datatypeValue.InferredTypeArgs),
                  ctor.Name));

            }
            else if (expr is ApplyExpr applyExpr)
            {
                flows.Add(new FlowFromTypeArgument(expr, applyExpr.Function.UnnormalizedType, applyExpr.Args.Count));

            }
            else if (expr is SetDisplayExpr setDisplayExpr)
            {
                foreach (var element in setDisplayExpr.Elements)
                {
                    flows.Add(new FlowFromComputedTypeIgnoreHeadTypes(expr, () => new SetType(setDisplayExpr.Finite, TypeRefinementWrapper.NormalizeSansBottom(element)), MutateCSharp.Schemata428.ReplaceStringConstant_4(54L, "set display")));
                }

            }
            else if (expr is MultiSetDisplayExpr multiSetDisplayExpr)
            {
                foreach (var element in multiSetDisplayExpr.Elements)
                {
                    flows.Add(new FlowFromComputedTypeIgnoreHeadTypes(expr, () => new MultiSetType(TypeRefinementWrapper.NormalizeSansBottom(element)), MutateCSharp.Schemata428.ReplaceStringConstant_4(55L, "multiset display")));
                }

            }
            else if (expr is SeqDisplayExpr seqDisplayExpr)
            {
                foreach (var element in seqDisplayExpr.Elements)
                {
                    flows.Add(new FlowFromComputedTypeIgnoreHeadTypes(expr, () => new SeqType(TypeRefinementWrapper.NormalizeSansBottom(element)), MutateCSharp.Schemata428.ReplaceStringConstant_4(56L, "sequence display")));
                }

            }
            else if (expr is MapDisplayExpr mapDisplayExpr)
            {
                foreach (var element in mapDisplayExpr.Elements)
                {
                    flows.Add(new FlowFromComputedTypeIgnoreHeadTypes(expr, () => new MapType(mapDisplayExpr.Finite,
                        TypeRefinementWrapper.NormalizeSansBottom(element.A), TypeRefinementWrapper.NormalizeSansBottom(element.B)),
            MutateCSharp.Schemata428.ReplaceStringConstant_4(57L, "map display")));
                }

            }
            else if (expr is SetComprehension setComprehension)
            {
                flows.Add(new FlowFromComputedTypeIgnoreHeadTypes(expr,
                  () => new SetType(setComprehension.Finite, TypeRefinementWrapper.NormalizeSansBottom(setComprehension.Term)),
          MutateCSharp.Schemata428.ReplaceStringConstant_4(58L, "set comprehension")));

            }
            else if (expr is MapComprehension mapComprehension)
            {
                flows.Add(new FlowFromComputedTypeIgnoreHeadTypes(expr, () =>
                {
                    Type keyType;
                    if (MutateCSharp.Schemata428.ReplaceBinExprOp_7(59L, mapComprehension.TermLeft, null))
                    {
                        keyType = TypeRefinementWrapper.NormalizeSansBottom(mapComprehension.TermLeft);
                    }
                    else
                    {
                        Contract.Assert(mapComprehension.BoundVars.Count == 1);
                        keyType = TypeRefinementWrapper.NormalizeSansBottom(mapComprehension.BoundVars[MutateCSharp.Schemata428.ReplaceNumericConstant_1(60L, 0)]);
                    }
                    return new MapType(mapComprehension.Finite, keyType, TypeRefinementWrapper.NormalizeSansBottom(mapComprehension.Term));
                }, MutateCSharp.Schemata428.ReplaceStringConstant_4(64L, "map comprehension")));

            }
            else if (expr is SeqConstructionExpr seqConstructionExpr)
            {
                flows.Add(new FlowFromComputedTypeIgnoreHeadTypes(expr,
                  () =>
                  {
                      var arrowType = (ArrowType)seqConstructionExpr.Initializer.Type.NormalizeToAncestorType();
                      Contract.Assert(arrowType.TypeArgs.Count == 2);
                      return new SeqType(TypeRefinementWrapper.NormalizeSansBottom(arrowType.TypeArgs[MutateCSharp.Schemata428.ReplaceNumericConstant_1(65L, 1)]));
                  },
          MutateCSharp.Schemata428.ReplaceStringConstant_4(69L, "seq constructor")));

            }
            else if (expr is BinaryExpr binaryExpr)
            {
                switch (binaryExpr.ResolvedOp)
                {
                    case BinaryExpr.ResolvedOpcode.Iff:
                    case BinaryExpr.ResolvedOpcode.Imp:
                    case BinaryExpr.ResolvedOpcode.And:
                    case BinaryExpr.ResolvedOpcode.Or:
                    case BinaryExpr.ResolvedOpcode.Add:
                    case BinaryExpr.ResolvedOpcode.Sub:
                    case BinaryExpr.ResolvedOpcode.Mul:
                    case BinaryExpr.ResolvedOpcode.Div:
                    case BinaryExpr.ResolvedOpcode.Mod:
                    case BinaryExpr.ResolvedOpcode.BitwiseAnd:
                    case BinaryExpr.ResolvedOpcode.BitwiseOr:
                    case BinaryExpr.ResolvedOpcode.BitwiseXor:
                    case BinaryExpr.ResolvedOpcode.Union:
                    case BinaryExpr.ResolvedOpcode.Intersection:
                    case BinaryExpr.ResolvedOpcode.MultiSetUnion:
                    case BinaryExpr.ResolvedOpcode.MultiSetIntersection:
                    case BinaryExpr.ResolvedOpcode.Concat:
                    case BinaryExpr.ResolvedOpcode.MapMerge:
                        // For these operators, the result type is the same as that of E0 and E1.
                        //
                        // Note about intersection: In general, let set<C> be the result of combining the operands set<A> and set<B>
                        // of intersection. To be precise, we would need C to be a type that conjoins the constraints of A and B.
                        // We don't have such a time, so we instead (approximate the other direction and) let C be the join of A and B.
                        flows.Add(new FlowBetweenExpressions(expr, binaryExpr.E0, BinaryExpr.OpcodeString(binaryExpr.Op)));
                        flows.Add(new FlowBetweenExpressions(expr, binaryExpr.E1, BinaryExpr.OpcodeString(binaryExpr.Op)));
                        break;
                        break;
                    case BinaryExpr.ResolvedOpcode.LeftShift:
                    case BinaryExpr.ResolvedOpcode.RightShift:
                    case BinaryExpr.ResolvedOpcode.SetDifference:
                    case BinaryExpr.ResolvedOpcode.MultiSetDifference:
                    case BinaryExpr.ResolvedOpcode.MapSubtraction:
                        // For these operators, the result type is determined by E0.
                        flows.Add(new FlowBetweenExpressions(expr, binaryExpr.E0, BinaryExpr.OpcodeString(binaryExpr.Op)));
                        break;
                        break;
                    case BinaryExpr.ResolvedOpcode.EqCommon:
                    case BinaryExpr.ResolvedOpcode.NeqCommon:
                    case BinaryExpr.ResolvedOpcode.Lt:
                    case BinaryExpr.ResolvedOpcode.Le:
                    case BinaryExpr.ResolvedOpcode.Ge:
                    case BinaryExpr.ResolvedOpcode.Gt:
                    case BinaryExpr.ResolvedOpcode.LtChar:
                    case BinaryExpr.ResolvedOpcode.LeChar:
                    case BinaryExpr.ResolvedOpcode.GeChar:
                    case BinaryExpr.ResolvedOpcode.GtChar:
                    case BinaryExpr.ResolvedOpcode.SetEq:
                    case BinaryExpr.ResolvedOpcode.SetNeq:
                    case BinaryExpr.ResolvedOpcode.ProperSubset:
                    case BinaryExpr.ResolvedOpcode.Subset:
                    case BinaryExpr.ResolvedOpcode.Superset:
                    case BinaryExpr.ResolvedOpcode.ProperSuperset:
                    case BinaryExpr.ResolvedOpcode.Disjoint:
                    case BinaryExpr.ResolvedOpcode.InSet:
                    case BinaryExpr.ResolvedOpcode.NotInSet:
                    case BinaryExpr.ResolvedOpcode.MultiSetEq:
                    case BinaryExpr.ResolvedOpcode.MultiSetNeq:
                    case BinaryExpr.ResolvedOpcode.MultiSubset:
                    case BinaryExpr.ResolvedOpcode.MultiSuperset:
                    case BinaryExpr.ResolvedOpcode.ProperMultiSubset:
                    case BinaryExpr.ResolvedOpcode.ProperMultiSuperset:
                    case BinaryExpr.ResolvedOpcode.MultiSetDisjoint:
                    case BinaryExpr.ResolvedOpcode.InMultiSet:
                    case BinaryExpr.ResolvedOpcode.NotInMultiSet:
                    case BinaryExpr.ResolvedOpcode.SeqEq:
                    case BinaryExpr.ResolvedOpcode.SeqNeq:
                    case BinaryExpr.ResolvedOpcode.ProperPrefix:
                    case BinaryExpr.ResolvedOpcode.Prefix:
                    case BinaryExpr.ResolvedOpcode.InSeq:
                    case BinaryExpr.ResolvedOpcode.NotInSeq:
                    case BinaryExpr.ResolvedOpcode.MapEq:
                    case BinaryExpr.ResolvedOpcode.MapNeq:
                    case BinaryExpr.ResolvedOpcode.InMap:
                    case BinaryExpr.ResolvedOpcode.NotInMap:
                    case BinaryExpr.ResolvedOpcode.RankLt:
                    case BinaryExpr.ResolvedOpcode.RankGt:
                        // For these operators, the result type is fixed (to be bool), so there is no flow.
                        break;
                        break;
                    case BinaryExpr.ResolvedOpcode.YetUndetermined:
                    case BinaryExpr.ResolvedOpcode.LessThanLimit:
                    default:
                        Contract.Assert(false); // unexpected operator
                        break;
                        break;
                }

            }
            else if (expr is LetExpr letExpr)
            {
                if (letExpr.Exact)
                {
                    Contract.Assert(letExpr.LHSs.Count == letExpr.RHSs.Count);
                    for (var i = MutateCSharp.Schemata428.ReplaceNumericConstant_1(70L, 0); MutateCSharp.Schemata428.ReplaceBinExprOp_5(74L, i, letExpr.LHSs.Count); MutateCSharp.Schemata428.ReplacePostfixUnaryExprOp_6(79L, ref i))
                    {
                        var rhs = letExpr.RHSs[i];
                        VisitPattern(letExpr.LHSs[i], () => TypeRefinementWrapper.NormalizeSansBottom(rhs), context);
                    }
                }
                flows.Add(new FlowBetweenExpressions(expr, letExpr.Body, MutateCSharp.Schemata428.ReplaceStringConstant_4(80L, "let")));

            }
            else if (expr is LambdaExpr lambdaExpr)
            {
                flows.Add(new FlowFromComputedType(expr, () =>
                {
                    return ModuleResolver.SelectAppropriateArrowType(lambdaExpr.tok,
                      lambdaExpr.BoundVars.ConvertAll(v => TypeRefinementWrapper.NormalizeSansBottom(v)),
                      TypeRefinementWrapper.NormalizeSansBottom(lambdaExpr.Body),
            MutateCSharp.Schemata428.ReplaceBinExprOp_8(85L, lambdaExpr.Reads.Expressions.Count, MutateCSharp.Schemata428.ReplaceNumericConstant_1(81L, 0)), MutateCSharp.Schemata428.ReplaceBinExprOp_7(90L, lambdaExpr.Range, null), systemModuleManager);
                }, lambdaExpr.WhatKind));

            }

            base.PostVisitOneExpression(expr, context);
        }

        private void VisitPattern<VT>(CasePattern<VT> casePattern, Func<Type> getPatternRhsType, IASTVisitorContext context) where VT : class, IVariable
        {
            VisitExpression(casePattern.Expr, context);

            if (casePattern.Var != null)
            {
                flows.Add(new FlowIntoVariableFromComputedType(casePattern.Var, getPatternRhsType, casePattern.tok, MutateCSharp.Schemata428.ReplaceStringConstant_4(91L, ":=")));
                Contract.Assert(casePattern.Arguments == null);
            }
            else if (casePattern.Arguments != null)
            {
                var ctor = casePattern.Ctor;
                Contract.Assert(ctor != null);

                Func<Type> GetPatternArgumentType(int argumentIndex)
                {
                    return () =>
                    {
                        var sourceType = getPatternRhsType().NormalizeExpand();
                        Contract.Assert(sourceType.IsDatatype);
                        Contract.Assert(sourceType.TypeArgs.Count == ctor.EnclosingDatatype.TypeArgs.Count);
                        var typeMap = TypeParameter.SubstitutionMap(ctor.EnclosingDatatype.TypeArgs, sourceType.TypeArgs);
                        Contract.Assert(argumentIndex < ctor.Formals.Count);
                        return ctor.Formals[argumentIndex].Type.Subst(typeMap);
                    };
                }

                for (var i = MutateCSharp.Schemata428.ReplaceNumericConstant_1(92L, 0); MutateCSharp.Schemata428.ReplaceBinExprOp_5(96L, i, casePattern.Arguments.Count); MutateCSharp.Schemata428.ReplacePostfixUnaryExprOp_6(101L, ref i))
                {
                    VisitPattern<VT>(casePattern.Arguments[i], GetPatternArgumentType(i), context);
                }
            }

        }

        protected override void PostVisitOneStatement(Statement stmt, IASTVisitorContext context)
        {
            if (stmt is VarDeclPattern varDeclPattern)
            {
                VisitPattern(varDeclPattern.LHS, () => TypeRefinementWrapper.NormalizeSansBottom(varDeclPattern.RHS), context);
            }
            else if (stmt is AssignStmt { Lhs: IdentifierExpr lhsIdentifierExpr } assignStmt)
            {
                if (assignStmt is { Rhs: ExprRhs exprRhs })
                {
                    flows.Add(new FlowIntoVariable(lhsIdentifierExpr.Var, exprRhs.Expr, assignStmt.tok, MutateCSharp.Schemata428.ReplaceStringConstant_4(102L, ":=")));
                }
                else if (assignStmt is { Rhs: TypeRhs tRhs })
                {
                    flows.Add(new FlowFromType(lhsIdentifierExpr.Var.UnnormalizedType, tRhs.Type, assignStmt.tok, MutateCSharp.Schemata428.ReplaceStringConstant_4(103L, ":= new")));
                }

            }
            else if (stmt is AssignSuchThatStmt assignSuchThatStmt)
            {
                foreach (var lhs in assignSuchThatStmt.Lhss)
                {
                    VisitExpression(lhs, context);
                }

            }
            else if (stmt is CallStmt callStmt)
            {
                Contract.Assert(callStmt.Args.Count == callStmt.Method.Ins.Count);
                for (var i = MutateCSharp.Schemata428.ReplaceNumericConstant_1(104L, 0); MutateCSharp.Schemata428.ReplaceBinExprOp_5(108L, i, callStmt.Args.Count); MutateCSharp.Schemata428.ReplacePostfixUnaryExprOp_6(113L, ref i))
                {
                    var formal = callStmt.Method.Ins[i];
                    var actual = callStmt.Args[i];
                    flows.Add(new FlowBetweenComputedTypes(() =>
                    {
                        var typeMap = callStmt.MethodSelect.TypeArgumentSubstitutionsWithParents();
                        return (TypeRefinementWrapper.NormalizeSansBottom(formal).Subst(typeMap), TypeRefinementWrapper.NormalizeSansBottom(actual));
                    }, callStmt.tok, $"{callStmt.Method.Name}({formal.Name} := ...)"));
                }

                Contract.Assert(callStmt.Lhs.Count == callStmt.Method.Outs.Count);
                for (var i = MutateCSharp.Schemata428.ReplaceNumericConstant_1(114L, 0); MutateCSharp.Schemata428.ReplaceBinExprOp_5(118L, i, callStmt.Lhs.Count); MutateCSharp.Schemata428.ReplacePostfixUnaryExprOp_6(123L, ref i))
                {
                    if (callStmt.Lhs[i] is IdentifierExpr actualIdentifierExpr)
                    {
                        var formal = callStmt.Method.Outs[i];
                        flows.Add(new FlowIntoVariableFromComputedType(actualIdentifierExpr.Var, () =>
                        {
                            var typeMap = callStmt.MethodSelect.TypeArgumentSubstitutionsWithParents();
                            return TypeRefinementWrapper.NormalizeSansBottom(formal).Subst(typeMap);
                        }, callStmt.tok, $"{actualIdentifierExpr.Var.Name} := {callStmt.Method.Name}(...)"));
                    }
                }

            }
            else if (stmt is ProduceStmt produceStmt)
            {
                if (MutateCSharp.Schemata428.ReplaceBinExprOp_9(124L, produceStmt.HiddenUpdate, null))
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
#if SOON
          UpdateIfOmitted(idPattern.BoundVar.Type, idPattern.BoundVar.PreType);
#endif
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

        public void Solve(ErrorReporter reporter, bool debugPrint)
        {
            var context = new FlowContext(systemModuleManager, reporter, debugPrint);
            bool anythingChanged;
            do
            {
                anythingChanged = MutateCSharp.Schemata428.ReplaceBooleanConstant_10(125L, false);
                foreach (var flow in flows.Where(flow => !flow.HasError))
                {
                    anythingChanged |= flow.Update(context);
                }
            } while (anythingChanged);

            if (debugPrint)
            {
                DebugPrint();
            }
        }

    }
}
