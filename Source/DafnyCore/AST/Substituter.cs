using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using JetBrains.Annotations;
namespace MutateCSharp
{
    internal class Schemata178
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT178");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_16(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_30(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Statement> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_36(long mutantId, Microsoft.Dafny.CalcStmt.CalcOp argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_32(long mutantId, Microsoft.Dafny.DividedBlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.Expression argument1, Microsoft.Dafny.Expression argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_31(long mutantId, Microsoft.Dafny.LList<Microsoft.Dafny.Label> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_26(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, Microsoft.Dafny.BoundedPool argument1, Microsoft.Dafny.BoundedPool argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.BoundedPool> argument1, System.Collections.Generic.List<Microsoft.Dafny.BoundedPool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_38(long mutantId, Microsoft.Dafny.Attributes argument1, Microsoft.Dafny.Attributes argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.BoundedPool> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_35(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.FrameExpression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_33(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_20(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static int ReplaceNumericConstant_13(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, Microsoft.Dafny.BoundedPool argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_29(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_25(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_27(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_39(long mutantId, Microsoft.Dafny.QuantifierExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_24(long mutantId, Microsoft.Dafny.CasePattern<Microsoft.Dafny.BoundVar> argument1, Microsoft.Dafny.CasePattern<Microsoft.Dafny.BoundVar> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_28(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_23(long mutantId, Microsoft.Dafny.Type argument1, Microsoft.Dafny.Type argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.IdentifierExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_37(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.RangeToken argument1, Microsoft.Dafny.RangeToken argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.BoundVar> argument1, System.Collections.Generic.List<Microsoft.Dafny.BoundVar> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.Expression argument1, Microsoft.Dafny.Expression argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Type> argument1, System.Collections.Generic.List<Microsoft.Dafny.Type> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.FrameExpression argument1, Microsoft.Dafny.FrameExpression argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.SystemModuleManager argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_6(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_40(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.BoundedPool> argument1, System.Collections.Generic.List<Microsoft.Dafny.BoundedPool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.Type argument1, Microsoft.Dafny.Type argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.CasePattern<Microsoft.Dafny.BoundVar>> argument1, System.Collections.Generic.List<Microsoft.Dafny.CasePattern<Microsoft.Dafny.BoundVar>> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_12(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.CasePattern<Microsoft.Dafny.BoundVar>> argument1, System.Collections.Generic.List<Microsoft.Dafny.CasePattern<Microsoft.Dafny.BoundVar>> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_34(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    /// <summary>
    /// The substituter has methods to create an expression from an existing one, where the new one has the indicated
    /// substitutions for "this" (receiverReplacement), variables (substMap), and types (typeMap).
    /// CAUTION:  The result of the substitution is intended for use by TrExpr, not for well-formedness checks.  In
    /// particular, the substituter does not copy parts of an expression that are used only for well-formedness checks.
    /// </summary>
    public class Substituter
    {
        protected readonly Expression receiverReplacement;
        protected readonly Dictionary<IVariable, Expression> substMap;
        protected readonly Dictionary<TypeParameter, Type> typeMap;
        protected readonly Label oldHeapLabel;
        [CanBeNull] protected readonly SystemModuleManager SystemModuleManager; // if non-null, substitutions into FunctionCallExpr's will be wrapped

        public static readonly Substituter EMPTY = new Substituter(null, new Dictionary<IVariable, Expression>(), new Dictionary<TypeParameter, Type>());

        public Substituter(Expression receiverReplacement, Dictionary<IVariable, Expression> substMap, Dictionary<TypeParameter, Type> typeMap, Label oldHeapLabel = null, SystemModuleManager systemModuleManager = null)
        {
            Contract.Requires(substMap != null);
            Contract.Requires(typeMap != null);
            this.receiverReplacement = receiverReplacement;
            this.substMap = substMap;
            this.typeMap = typeMap;
            this.oldHeapLabel = oldHeapLabel;
            this.SystemModuleManager = systemModuleManager;
        }
        public virtual Expression Substitute(Expression expr)
        {
            Contract.Requires(expr != null);
            Contract.Ensures(Contract.Result<Expression>() != null);

            Expression newExpr = null;  // set to non-null value only if substitution has any effect; if non-null, the .Type of newExpr will be filled in at end

            if (expr is StaticReceiverExpr)
            {
                var e = (StaticReceiverExpr)expr;
                var ty = e.Type.Subst(typeMap);
                return new StaticReceiverExpr(e.tok, ty, e.IsImplicit) { Type = ty };
            }
            else if (expr is LiteralExpr literalExpr)
            {
                if (literalExpr.Value == null)
                {
                    var ty = literalExpr.Type.Subst(typeMap);
                    if (MutateCSharp.Schemata178.ReplaceBinExprOp_0(1L, ty, literalExpr.Type))
                    {
                        return new LiteralExpr(literalExpr.tok) { Type = ty };
                    }
                }
                else
                {
                    // nothing to substitute
                }
            }
            else if (expr is BoogieGenerator.BoogieWrapper)
            {
                var e = (BoogieGenerator.BoogieWrapper)expr;
                var ty = e.Type.Subst(typeMap);
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_0(2L, ty, e.Type))
                {
                    return new BoogieGenerator.BoogieWrapper(e.Expr, ty);
                }
            }
            else if (expr is WildcardExpr)
            {
                // nothing to substitute
            }
            else if (expr is ThisExpr)
            {
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_1(3L, receiverReplacement, null))
                {
                    return expr;
                }
                else
                {
                    return new ParensExpression(expr.tok, receiverReplacement)
                    {
                        ResolvedExpression = receiverReplacement,
                        RangeToken = expr.RangeToken,
                        Type = receiverReplacement.Type
                    };
                }
            }
            else if (expr is IdentifierExpr)
            {
                IdentifierExpr e = (IdentifierExpr)expr;
                if (substMap.TryGetValue(e.Var, out var substExpr))
                {
                    var substIdExpr = substExpr as IdentifierExpr;
                    Expression substExprFinal;
                    if (MutateCSharp.Schemata178.ReplaceBinExprOp_2(4L, substIdExpr, null))
                    {
                        // clone it, using the source location of the original
                        substExprFinal = new IdentifierExpr(expr.tok, substIdExpr.Var);
                    }
                    else
                    {
                        if (MutateCSharp.Schemata178.ReplaceBinExprOp_3(5L, substExpr.RangeToken, e.RangeToken))
                        {
                            var substExprParens = new ParensExpression(expr.tok, substExpr);
                            substExprParens.Type = substExpr.Type;
                            substExprParens.ResolvedExpression = substExpr;
                            substExprFinal = substExprParens;
                        }
                        else
                        {
                            substExprFinal = substExpr;
                        }
                    }

                    return cce.NonNull(substExprFinal);
                }
            }
            else if (expr is DisplayExpression)
            {
                DisplayExpression e = (DisplayExpression)expr;
                List<Expression> newElements = SubstituteExprList(e.Elements);
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_5(8L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_4(6L, newElements, e.Elements), () => MutateCSharp.Schemata178.ReplaceBinExprOp_0(7L, e.Type.Subst(typeMap), e.Type)))
                {
                    if (expr is SetDisplayExpr)
                    {
                        newExpr = new SetDisplayExpr(expr.tok, ((SetDisplayExpr)expr).Finite, newElements);
                    }
                    else if (expr is MultiSetDisplayExpr)
                    {
                        newExpr = new MultiSetDisplayExpr(expr.tok, newElements);
                    }
                    else
                    {
                        newExpr = new SeqDisplayExpr(expr.tok, newElements);
                    }
                }
            }
            else if (expr is MapDisplayExpr)
            {
                var e = (MapDisplayExpr)expr;
                var elmts = new List<ExpressionPair>();
                var anyChanges = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(14L, false);
                foreach (var ep in e.Elements)
                {
                    var a = Substitute(ep.A);
                    var b = Substitute(ep.B);
                    elmts.Add(new ExpressionPair(a, b));
                    if (MutateCSharp.Schemata178.ReplaceBinExprOp_5(17L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(15L, a, ep.A), () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(16L, b, ep.B)))
                    {
                        anyChanges = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(23L, true);
                    }
                }
                var ty = e.Type.Subst(typeMap);
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_5(25L, () => anyChanges, () => MutateCSharp.Schemata178.ReplaceBinExprOp_0(24L, ty, e.Type)))
                {
                    newExpr = new MapDisplayExpr(expr.tok, e.Finite, elmts);
                }
            }
            else if (expr is MemberSelectExpr)
            {
                var mse = (MemberSelectExpr)expr;
                var newObj = Substitute(mse.Obj);
                var newTypeApplicationAtEnclosingClass = SubstituteTypeList(mse.TypeApplication_AtEnclosingClass);
                var newTypeApplicationJustMember = SubstituteTypeList(mse.TypeApplication_JustMember);
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_5(40L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_5(33L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(31L, newObj, mse.Obj), () => MutateCSharp.Schemata178.ReplaceBinExprOp_8(32L, newTypeApplicationAtEnclosingClass, mse.TypeApplication_AtEnclosingClass)), () => MutateCSharp.Schemata178.ReplaceBinExprOp_8(39L, newTypeApplicationJustMember, mse.TypeApplication_JustMember)))
                {
                    var fseNew = new MemberSelectExpr(mse.tok, newObj, mse.MemberName)
                    {
                        Member = mse.Member,
                        TypeApplication_AtEnclosingClass = newTypeApplicationAtEnclosingClass,
                        TypeApplication_JustMember = newTypeApplicationJustMember,
                        AtLabel = mse.AtLabel ?? oldHeapLabel
                    };
                    newExpr = fseNew;
                }
            }
            else if (expr is SeqSelectExpr)
            {
                SeqSelectExpr sse = (SeqSelectExpr)expr;
                Expression seq = Substitute(sse.Seq);
                Expression e0 = MutateCSharp.Schemata178.ReplaceBinExprOp_1(46L, sse.E0, null) ? null : Substitute(sse.E0);
                Expression e1 = MutateCSharp.Schemata178.ReplaceBinExprOp_1(47L, sse.E1, null) ? null : Substitute(sse.E1);
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_5(57L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_5(50L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(48L, seq, sse.Seq), () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(49L, e0, sse.E0)), () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(56L, e1, sse.E1)))
                {
                    newExpr = new SeqSelectExpr(sse.tok, sse.SelectOne, seq, e0, e1, sse.CloseParen);
                }

            }
            else if (expr is SeqUpdateExpr)
            {
                var sse = (SeqUpdateExpr)expr;
                Expression seq = Substitute(sse.Seq);
                Expression index = Substitute(sse.Index);
                Expression val = Substitute(sse.Value);
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_5(72L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_5(65L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(63L, seq, sse.Seq), () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(64L, index, sse.Index)), () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(71L, val, sse.Value)))
                {
                    newExpr = new SeqUpdateExpr(sse.tok, seq, index, val);
                }
            }
            else if (expr is MultiSelectExpr)
            {
                MultiSelectExpr mse = (MultiSelectExpr)expr;
                Expression array = Substitute(mse.Array);
                List<Expression> newArgs = SubstituteExprList(mse.Indices);
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_5(80L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(78L, array, mse.Array), () => MutateCSharp.Schemata178.ReplaceBinExprOp_4(79L, newArgs, mse.Indices)))
                {
                    newExpr = new MultiSelectExpr(mse.tok, array, newArgs);
                }

            }
            else if (expr is FunctionCallExpr)
            {
                var e = (FunctionCallExpr)expr;
                Expression receiver = Substitute(e.Receiver);
                List<Expression> newArgs = SubstituteExprList(e.Args);
                var newTypeApplicationAtEnclosingClass = SubstituteTypeList(e.TypeApplication_AtEnclosingClass);
                var newTypeApplicationJustFunction = SubstituteTypeList(e.TypeApplication_JustFunction);
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_5(102L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_5(95L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_5(88L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(86L, receiver, e.Receiver), () => MutateCSharp.Schemata178.ReplaceBinExprOp_4(87L, newArgs, e.Args)), () => MutateCSharp.Schemata178.ReplaceBinExprOp_8(94L, newTypeApplicationAtEnclosingClass, e.TypeApplication_AtEnclosingClass)), () => MutateCSharp.Schemata178.ReplaceBinExprOp_8(101L, newTypeApplicationJustFunction, e.TypeApplication_JustFunction)))
                {
                    var newFce = new FunctionCallExpr(expr.tok, e.Name, receiver, e.OpenParen, e.CloseParen, newArgs, e.AtLabel ?? oldHeapLabel)
                    {
                        Function = e.Function, // resolve on the fly (and set newFce.Type below, at end)
                        CoCall = e.CoCall, // also copy the co-call status
                        CoCallHint = e.CoCallHint, // and any co-call hint
                        TypeApplication_AtEnclosingClass = newTypeApplicationAtEnclosingClass,
                        TypeApplication_JustFunction = newTypeApplicationJustFunction,
                        IsByMethodCall = e.IsByMethodCall
                    };
                    if (MutateCSharp.Schemata178.ReplaceBinExprOp_9(108L, SystemModuleManager, null))
                    {
                        newExpr = newFce;
                    }
                    else
                    {
                        newFce.Type = expr.Type.Subst(typeMap);
                        newExpr = Expression.WrapResolvedCall(newFce, SystemModuleManager);
                    }
                }

            }
            else if (expr is ApplyExpr)
            {
                ApplyExpr e = (ApplyExpr)expr;
                Expression fn = Substitute(e.Function);
                List<Expression> args = SubstituteExprList(e.Args);
                newExpr = new ApplyExpr(e.tok, fn, args, e.CloseParen);

            }
            else if (expr is DatatypeValue)
            {
                var dtv = (DatatypeValue)expr;
                var newArguments = SubstituteExprList(dtv.Bindings.Arguments); // substitute into the expressions, but drop any binding names (since those are no longer needed)
                var newTypeArgs = SubstituteTypeList(dtv.InferredTypeArgs);
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_5(111L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_4(109L, newArguments, dtv.Bindings.Arguments), () => MutateCSharp.Schemata178.ReplaceBinExprOp_8(110L, newTypeArgs, dtv.InferredTypeArgs)))
                {
                    var newDtv = new DatatypeValue(dtv.tok, dtv.DatatypeName, dtv.MemberName, newArguments)
                    {
                        Ctor = dtv.Ctor,
                        InferredTypeArgs = newTypeArgs
                    };
                    newExpr = newDtv;
                }

            }
            else if (expr is OldExpr)
            {
                var e = (OldExpr)expr;
                // Note, it is up to the caller to avoid variable capture.  In most cases, this is not a
                // problem, since variables have unique declarations.  However, it is an issue if the substitution
                // takes place inside an OldExpr.  In those cases (see LetExpr), the caller can use a
                // BoogieWrapper before calling Substitute.
                Expression se = Substitute(e.E);
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_7(117L, se, e.E))
                {
                    newExpr = new OldExpr(expr.tok, se, e.At)
                    {
                        AtLabel = e.AtLabel ?? oldHeapLabel,
                        Useless = e.Useless
                    };
                }
            }
            else if (expr is UnchangedExpr)
            {
                var e = (UnchangedExpr)expr;
                var fr = new List<FrameExpression>();
                var anythingChanged = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(118L, false);
                foreach (var fe in e.Frame)
                {
                    var fefe = SubstFrameExpr(fe);
                    if (MutateCSharp.Schemata178.ReplaceBinExprOp_10(119L, fefe, fe))
                    {
                        anythingChanged = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(120L, true);
                    }
                    fr.Add(fefe);
                }
                if (anythingChanged)
                {
                    newExpr = new UnchangedExpr(e.tok, fr, e.At) { AtLabel = e.AtLabel ?? oldHeapLabel };
                }
            }
            else if (expr is SeqConstructionExpr)
            {
                var e = (SeqConstructionExpr)expr;
                var sn = Substitute(e.N);
                var sinit = Substitute(e.Initializer);
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_5(123L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(121L, sn, e.N), () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(122L, sinit, e.Initializer)))
                {
                    newExpr = new SeqConstructionExpr(expr.tok, e.ExplicitElementType, sn, sinit);
                }
            }
            else if (expr is MultiSetFormingExpr)
            {
                var e = (MultiSetFormingExpr)expr;
                var se = Substitute(e.E);
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_7(129L, se, e.E))
                {
                    newExpr = new MultiSetFormingExpr(expr.tok, se);
                }
            }
            else if (expr is BoxingCastExpr)
            {
                var e = (BoxingCastExpr)expr;
                var se = Substitute(e.E);
                var fromType = e.FromType.Subst(typeMap);
                var toType = e.ToType.Subst(typeMap);
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_5(139L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_5(132L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(130L, se, e.E), () => MutateCSharp.Schemata178.ReplaceBinExprOp_0(131L, fromType, e.FromType)), () => MutateCSharp.Schemata178.ReplaceBinExprOp_0(138L, toType, e.ToType)))
                {
                    newExpr = new BoxingCastExpr(se, fromType, toType);
                }
            }
            else if (expr is UnaryExpr)
            {
                var e = (UnaryExpr)expr;
                var se = Substitute(e.E);
                if (e is TypeUnaryExpr typeUnaryExpr)
                {
                    var toType = typeUnaryExpr.ToType.Subst(typeMap);
                    if (MutateCSharp.Schemata178.ReplaceBinExprOp_5(147L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(145L, se, e.E), () => MutateCSharp.Schemata178.ReplaceBinExprOp_0(146L, toType, typeUnaryExpr.ToType)))
                    {
                        if (e is ConversionExpr)
                        {
                            var ee = (ConversionExpr)e;
                            newExpr = new ConversionExpr(expr.tok, se, toType);
                        }
                        else if (e is TypeTestExpr)
                        {
                            var ee = (TypeTestExpr)e;
                            newExpr = new TypeTestExpr(expr.tok, se, toType);
                        }
                        else
                        {
                            Contract.Assert(false); // unexpected UnaryExpr subtype
                        }
                    }
                }
                else if (MutateCSharp.Schemata178.ReplaceBinExprOp_7(153L, se, e.E))
                {
                    if (e is FreshExpr)
                    {
                        var ee = (FreshExpr)e;
                        newExpr = new FreshExpr(expr.tok, se, ee.At) { AtLabel = ee.AtLabel ?? oldHeapLabel };
                    }
                    else if (e is UnaryOpExpr)
                    {
                        var ee = (UnaryOpExpr)e;
                        newExpr = new UnaryOpExpr(expr.tok, ee.Op, se);
                    }
                    else
                    {
                        Contract.Assert(false);  // unexpected UnaryExpr subtype
                    }
                }

            }
            else if (expr is BinaryExpr)
            {
                BinaryExpr e = (BinaryExpr)expr;
                Expression e0 = Substitute(e.E0);
                Expression e1 = Substitute(e.E1);
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_5(156L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(154L, e0, e.E0), () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(155L, e1, e.E1)))
                {
                    BinaryExpr newBin = new BinaryExpr(expr.tok, e.Op, e0, e1);
                    newBin.ResolvedOp = e.ResolvedOp;  // part of what needs to be done to resolve on the fly (newBin.Type is set below, at end)
                    newExpr = newBin;
                }

            }
            else if (expr is TernaryExpr)
            {
                var e = (TernaryExpr)expr;
                var e0 = Substitute(e.E0);
                var e1 = Substitute(e.E1);
                var e2 = Substitute(e.E2);
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_5(171L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_5(164L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(162L, e0, e.E0), () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(163L, e1, e.E1)), () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(170L, e2, e.E2)))
                {
                    newExpr = new TernaryExpr(expr.tok, e.Op, e0, e1, e2);
                }

            }
            else if (expr is LetExpr letExpr)
            {
                newExpr = LetExpr(letExpr);
            }
            else if (expr is NestedMatchExpr nestedMatchExpr)
            {
                var src = Substitute(nestedMatchExpr.Source);
                bool anythingChanged = MutateCSharp.Schemata178.ReplaceBinExprOp_7(177L, src, nestedMatchExpr.Source);
                var flattened = MutateCSharp.Schemata178.ReplaceBinExprOp_1(178L, nestedMatchExpr.Flattened, null) ? null : Substitute(nestedMatchExpr.Flattened);
                anythingChanged |= MutateCSharp.Schemata178.ReplaceBinExprOp_7(179L, flattened, nestedMatchExpr.Flattened);

                var cases = new List<NestedMatchCaseExpr>();
                foreach (var mc in nestedMatchExpr.Cases)
                {

                    List<BoundVar> discoveredBvs = new();
                    ExtendedPattern SubstituteForPattern(ExtendedPattern pattern)
                    {
                        switch (pattern)
                        {
                            case DisjunctivePattern disjunctivePattern:
                                return new DisjunctivePattern(disjunctivePattern.Tok,
                                  disjunctivePattern.Alternatives.Select(SubstituteForPattern).ToList(), disjunctivePattern.IsGhost);
                                break;
                            case IdPattern idPattern:
                                if (idPattern.BoundVar == null)
                                {
                                    return new IdPattern(idPattern.Tok, idPattern.Id, idPattern.Type,
                                      idPattern.Arguments?.Select(SubstituteForPattern).ToList(), idPattern.IsGhost);
                                }

                                discoveredBvs.Add((BoundVar)idPattern.BoundVar);
                                var result = new IdPattern(idPattern.Tok, idPattern.Id, idPattern.Type, null, idPattern.IsGhost)
                                {
                                    BoundVar = CreateBoundVarSubstitutions(new[] { (BoundVar)idPattern.BoundVar }.ToList(), false)[0]
                                };
                                if (idPattern.BoundVar != result.BoundVar)
                                {
                                    anythingChanged = true;
                                }
                                return result;
                                break;
                            case LitPattern litPattern:
                                return litPattern;
                                break;
                            default:
                                throw new ArgumentOutOfRangeException(nameof(pattern));
                                break;
                        }

                        return default;
                    }
                    var pattern = SubstituteForPattern(mc.Pat);
                    var body = Substitute(mc.Body);
                    // undo any changes to substMap (could be optimized to do this only if newBoundVars != mc.Arguments)
                    foreach (var bv in discoveredBvs)
                    {
                        substMap.Remove(bv);
                    }
                    // Put things together
                    if (MutateCSharp.Schemata178.ReplaceBinExprOp_7(180L, body, mc.Body))
                    {
                        anythingChanged = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(181L, true);
                    }

                    var newCaseExpr = new NestedMatchCaseExpr(mc.Tok, pattern, body, mc.Attributes);
                    cases.Add(newCaseExpr);
                }
                if (anythingChanged)
                {
                    newExpr = new NestedMatchExpr(expr.tok, src, cases, nestedMatchExpr.UsesOptionalBraces)
                    {
                        Flattened = flattened
                    };
                }

            }
            else if (expr is MatchExpr)
            {
                var e = (MatchExpr)expr;
                var src = Substitute(e.Source);
                bool anythingChanged = MutateCSharp.Schemata178.ReplaceBinExprOp_7(182L, src, e.Source);
                var cases = new List<MatchCaseExpr>();
                foreach (var mc in e.Cases)
                {
                    var newBoundVars = CreateBoundVarSubstitutions(mc.Arguments, MutateCSharp.Schemata178.ReplaceBooleanConstant_6(183L, false));
                    var body = Substitute(mc.Body);
                    // undo any changes to substMap (could be optimized to do this only if newBoundVars != mc.Arguments)
                    foreach (var bv in mc.Arguments)
                    {
                        substMap.Remove(bv);
                    }
                    // Put things together
                    if (MutateCSharp.Schemata178.ReplaceBinExprOp_5(186L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_11(184L, newBoundVars, mc.Arguments), () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(185L, body, mc.Body)))
                    {
                        anythingChanged = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(192L, true);
                    }
                    var newCaseExpr = new MatchCaseExpr(mc.tok, mc.Ctor, mc.FromBoundVar, newBoundVars, body, mc.Attributes);
                    newCaseExpr.Ctor = mc.Ctor;  // resolve here
                    cases.Add(newCaseExpr);
                }
                if (anythingChanged)
                {
                    var newME = new MatchExpr(expr.tok, src, cases, e.UsesOptionalBraces);
                    newME.MissingCases.AddRange(e.MissingCases);
                    newExpr = newME;
                }

            }
            else if (expr is ComprehensionExpr)
            {

                newExpr = SubstituteComprehensionExpr((ComprehensionExpr)expr, MutateCSharp.Schemata178.ReplaceBooleanConstant_6(193L, true));

            }
            else if (expr is StmtExpr)
            {
                var e = (StmtExpr)expr;
                newExpr = new StmtExpr(e.tok, SubstStmt(e.S), Substitute(e.E));

            }
            else if (expr is ITEExpr)
            {
                ITEExpr e = (ITEExpr)expr;
                Expression test = Substitute(e.Test);
                Expression thn = Substitute(e.Thn);
                Expression els = Substitute(e.Els);
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_5(203L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_5(196L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(194L, test, e.Test), () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(195L, thn, e.Thn)), () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(202L, els, e.Els)))
                {
                    newExpr = new ITEExpr(expr.tok, e.IsBindingGuard, test, thn, els);
                }
            }
            else if (expr is ConcreteSyntaxExpression concreteSyntaxExpression)
            {
                Contract.Assert(concreteSyntaxExpression.ResolvedExpression != null);
                var resolvedExpression = Substitute(concreteSyntaxExpression.ResolvedExpression);
                return new ParensExpression(expr.tok, resolvedExpression)
                {
                    ResolvedExpression = resolvedExpression,
                    RangeToken = expr.RangeToken,
                    Type = resolvedExpression.Type
                };

            }
            else if (expr is BoogieGenerator.BoogieFunctionCall)
            {
                var e = (BoogieGenerator.BoogieFunctionCall)expr;
                bool anythingChanged = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(209L, false);
                var newTyArgs = new List<Type>();
                foreach (var arg in e.TyArgs)
                {
                    var newArg = arg.Subst(typeMap);
                    if (MutateCSharp.Schemata178.ReplaceBinExprOp_0(210L, newArg, arg))
                    {
                        anythingChanged = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(211L, true);
                    }
                    newTyArgs.Add(newArg);
                }
                var newArgs = new List<Expression>();
                foreach (var arg in e.Args)
                {
                    var newArg = Substitute(arg);
                    if (MutateCSharp.Schemata178.ReplaceBinExprOp_7(212L, newArg, arg))
                    {
                        anythingChanged = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(213L, true);
                    }
                    newArgs.Add(newArg);
                }
                if (anythingChanged)
                {
                    newExpr = new BoogieGenerator.BoogieFunctionCall(e.tok, e.FunctionName, e.UsesHeap, e.UsesOldHeap, e.HeapAtLabels, newArgs, newTyArgs);
                }

            }
            else
            {
                Contract.Assume(false); // unexpected Expression
            }

            if (MutateCSharp.Schemata178.ReplaceBinExprOp_1(214L, newExpr, null))
            {
                return expr;
            }
            else
            {
                newExpr.Type = expr.Type.Subst(typeMap);  // resolve on the fly (any additional resolution must be done above)
                return newExpr;
            }

            return default;
        }

        private Expression LetExpr(LetExpr letExpr)
        {
            if (letExpr.Exact)
            {
                var rhss = new List<Expression>();
                bool anythingChanged = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(215L, false);
                foreach (var rhs in letExpr.RHSs)
                {
                    var r = Substitute(rhs);
                    if (MutateCSharp.Schemata178.ReplaceBinExprOp_7(216L, r, rhs))
                    {
                        anythingChanged = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(217L, true);
                    }

                    rhss.Add(r);
                }

                // Note, CreateBoundVarSubstitutions has the side effect of updating the substitution map.
                // For an Exact let expression, this is something that needs to be done after substituting
                // in the RHSs.
                var newCasePatterns = CreateCasePatternSubstitutions(letExpr.LHSs, MutateCSharp.Schemata178.ReplaceBooleanConstant_6(218L, true));
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_12(219L, newCasePatterns, letExpr.LHSs))
                {
                    anythingChanged = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(220L, true);
                }

                var body = Substitute(letExpr.Body);
                // undo any changes to substMap (could be optimized to do this only if newBoundVars != e.Vars)
                foreach (var bv in letExpr.BoundVars)
                {
                    substMap.Remove(bv);
                }

                // Put things together
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_5(222L, () => anythingChanged, () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(221L, body, letExpr.Body)))
                {
                    return new LetExpr(letExpr.tok, newCasePatterns, rhss, body, letExpr.Exact);
                }

                return null;
            }
            else
            {
                var newLHSs = CreateCasePatternSubstitutions(letExpr.LHSs, MutateCSharp.Schemata178.ReplaceBooleanConstant_6(228L, true));
                var rhs = Substitute(letExpr.RHSs[MutateCSharp.Schemata178.ReplaceNumericConstant_13(229L, 0)]);
                var body = Substitute(letExpr.Body);
                var newBounds = SubstituteBoundedPoolList(letExpr.Constraint_Bounds);
                // undo any changes to substMap
                foreach (var bv in letExpr.BoundVars)
                {
                    substMap.Remove(bv);
                }

                if (MutateCSharp.Schemata178.ReplaceBinExprOp_16(253L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_16(246L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_16(239L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_14(233L, newLHSs, letExpr.LHSs), () => MutateCSharp.Schemata178.ReplaceBinExprOp_15(238L, rhs, letExpr.RHSs[MutateCSharp.Schemata178.ReplaceNumericConstant_13(234L, 0)])), () => MutateCSharp.Schemata178.ReplaceBinExprOp_15(245L, body, letExpr.Body)), () => MutateCSharp.Schemata178.ReplaceBinExprOp_17(252L, newBounds, letExpr.Constraint_Bounds)))
                {
                    return null;
                }

                // keep copies of the substitution maps so we can reuse them at desugaring time
                var newSubstMap = new Dictionary<IVariable, Expression>(substMap);
                var newTypeMap = new Dictionary<TypeParameter, Type>(typeMap);
                return new BoogieGenerator.SubstLetExpr(letExpr.tok, newLHSs, new List<Expression> { rhs }, body, letExpr.Exact, letExpr, newSubstMap, newTypeMap, newBounds);
            }

            return default;
        }

        /// <summary>
        /// This method calls "SubstituteBoundedPool" on each item in the possibly null list. If any of those calls returns a
        /// change from the original, then all of the results are returned in a new list; otherwise, "list" is returned.
        /// </summary>
        public List<BoundedPool>/*?*/ SubstituteBoundedPoolList(List<BoundedPool>/*?*/ list)
        {
            if (MutateCSharp.Schemata178.ReplaceBinExprOp_18(259L, list, null))
            {
                var newList = list.ConvertAll(SubstituteBoundedPool);
                for (var i = MutateCSharp.Schemata178.ReplaceNumericConstant_13(260L, 0); MutateCSharp.Schemata178.ReplaceBinExprOp_19(264L, i, list.Count); MutateCSharp.Schemata178.ReplacePostfixUnaryExprOp_20(269L, ref i))
                {
                    if (MutateCSharp.Schemata178.ReplaceBinExprOp_21(270L, list[i], newList[i]))
                    {
                        return newList;
                    }
                }
            }
            return list;
        }

        public BoundedPool SubstituteBoundedPool(BoundedPool bound)
        {
            if (MutateCSharp.Schemata178.ReplaceBinExprOp_22(271L, bound, null))
            {
                return null;
            }
            else if (bound is ExactBoundedPool)
            {
                var b = (ExactBoundedPool)bound;
                return new ExactBoundedPool(Substitute(b.E));
            }
            else if (bound is BoolBoundedPool)
            {
                return bound;  // nothing to substitute
            }
            else if (bound is CharBoundedPool)
            {
                return bound;  // nothing to substitute
            }
            else if (bound is IntBoundedPool)
            {
                var b = (IntBoundedPool)bound;
                return new IntBoundedPool(
        MutateCSharp.Schemata178.ReplaceBinExprOp_1(272L, b.LowerBound, null) ? null : Substitute(b.LowerBound),
        MutateCSharp.Schemata178.ReplaceBinExprOp_1(273L, b.UpperBound, null) ? null : Substitute(b.UpperBound));
            }
            else if (bound is SetBoundedPool)
            {
                var b = (SetBoundedPool)bound;
                return new SetBoundedPool(Substitute(b.Set), b.BoundVariableType, b.CollectionElementType, b.IsFiniteCollection);
            }
            else if (bound is MultiSetBoundedPool)
            {
                var b = (MultiSetBoundedPool)bound;
                return new MultiSetBoundedPool(Substitute(b.MultiSet), b.BoundVariableType, b.CollectionElementType);
            }
            else if (bound is SubSetBoundedPool)
            {
                var b = (SubSetBoundedPool)bound;
                return new SubSetBoundedPool(Substitute(b.UpperBound), b.IsFiniteCollection);
            }
            else if (bound is SuperSetBoundedPool)
            {
                var b = (SuperSetBoundedPool)bound;
                return new SuperSetBoundedPool(Substitute(b.LowerBound));
            }
            else if (bound is MapBoundedPool)
            {
                var b = (MapBoundedPool)bound;
                return new MapBoundedPool(Substitute(b.Map), b.BoundVariableType, b.CollectionElementType, b.IsFiniteCollection);
            }
            else if (bound is SeqBoundedPool)
            {
                var b = (SeqBoundedPool)bound;
                return new SeqBoundedPool(Substitute(b.Seq), b.BoundVariableType, b.CollectionElementType);
            }
            else if (bound is DatatypeBoundedPool)
            {
                return bound;  // nothing to substitute
            }
            else if (bound is DatatypeInclusionBoundedPool)
            {
                return bound;  // nothing to substitute
            }
            else if (bound is AllocFreeBoundedPool)
            {
                return bound;  // nothing to substitute
            }
            else if (bound is ExplicitAllocatedBoundedPool)
            {
                return bound;  // nothing to substitute
            }
            else if (bound is AssignSuchThatStmt.WiggleWaggleBound)
            {
                return bound;  // nothing to substitute
            }
            else if (bound is SpecialAllocIndependenceAllocatedBoundedPool)
            {
                return bound;  // nothing to substitute
            }
            else if (bound is OlderBoundedPool)
            {
                return bound;  // nothing to substitute
            }
            else
            {
                Contract.Assume(false);  // unexpected BoundedPool
                throw new cce.UnreachableException();  // to please compiler
            }

            return default;
        }

        /// <summary>
        /// Return a list of bound variables, of the same length as 'vars' but with possible substitutions.
        /// For any change necessary, update 'substMap' to reflect the new substitution; the caller is responsible for
        /// undoing these changes once the updated 'substMap' has been used.
        /// If no changes are necessary, the list returned is exactly 'vars' and 'substMap' is unchanged.
        /// </summary>
        protected virtual List<BoundVar> CreateBoundVarSubstitutions(List<BoundVar> vars, bool forceSubstitutionOfBoundVars)
        {
            bool anythingChanged = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(274L, false);
            var newBoundVars = new List<BoundVar>();
            foreach (var bv in vars)
            {
                var tt = bv.Type.Subst(typeMap);
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_16(276L, () => !forceSubstitutionOfBoundVars, () => MutateCSharp.Schemata178.ReplaceBinExprOp_23(275L, tt, bv.Type)))
                {
                    newBoundVars.Add(bv);
                }
                else
                {
                    anythingChanged = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(282L, true);
                    var newBv = new BoundVar(bv.tok, bv.Name, tt);
                    newBoundVars.Add(newBv);
                    // update substMap to reflect the new BoundVar substitutions
                    var ie = new IdentifierExpr(newBv.tok, newBv.Name) { Var = newBv, Type = newBv.Type };
                    substMap.Add(bv, ie);
                }
            }
            return anythingChanged ? newBoundVars : vars;
        }

        /// <summary>
        /// Return a list of local variables, of the same length as 'vars' but with possible substitutions.
        /// For any change necessary, update 'substMap' to reflect the new substitution; the caller is responsible for
        /// undoing these changes once the updated 'substMap' has been used.
        /// If no changes are necessary, the list returned is exactly 'vars' and 'substMap' is unchanged.
        /// </summary>
        protected virtual List<LocalVariable> CreateLocalVarSubstitutions(List<LocalVariable> vars, bool forceSubstitutionOfVars)
        {
            bool anythingChanged = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(283L, false);
            var newVars = new List<LocalVariable>();
            foreach (var v in vars)
            {
                var tt = v.OptionalType.Subst(typeMap);
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_16(285L, () => !forceSubstitutionOfVars, () => MutateCSharp.Schemata178.ReplaceBinExprOp_23(284L, tt, v.OptionalType)))
                {
                    newVars.Add(v);
                }
                else
                {
                    anythingChanged = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(291L, true);
                    var newVar = new LocalVariable(v.RangeToken, v.Name, tt, v.IsGhost);
                    newVar.type = tt;  // resolve here
                    newVars.Add(newVar);
                    // update substMap to reflect the new LocalVariable substitutions
                    var ie = new IdentifierExpr(newVar.Tok, newVar.Name) { Var = newVar, Type = newVar.Type };
                    substMap.Add(v, ie);
                }
            }
            return anythingChanged ? newVars : vars;
        }

        /// <summary>
        /// Return a list of case patterns, of the same length as 'patterns' but with possible substitutions.
        /// For any change necessary, update 'substMap' to reflect the new substitution; the caller is responsible for
        /// undoing these changes once the updated 'substMap' has been used.
        /// If no changes are necessary, the list returned is exactly 'patterns' and 'substMap' is unchanged.
        /// </summary>
        protected virtual List<CasePattern<BoundVar>> CreateCasePatternSubstitutions(List<CasePattern<BoundVar>> patterns, bool forceSubstitutionOfBoundVars)
        {
            bool anythingChanged = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(292L, false);
            var newPatterns = new List<CasePattern<BoundVar>>();
            foreach (var pat in patterns)
            {
                var newPat = SubstituteCasePattern(pat, forceSubstitutionOfBoundVars, CloneBoundVar);
                newPatterns.Add(newPat);
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_24(293L, newPat, pat))
                {
                    anythingChanged = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(294L, true);
                }
            }
            return anythingChanged ? newPatterns : patterns;
        }
        CasePattern<VT> SubstituteCasePattern<VT>(CasePattern<VT> pat, bool forceSubstitutionOfBoundVars,
            Func<CasePattern<VT>, Type, VT, VT> cloneVt
          ) where VT : class, IVariable
        {
            Contract.Requires(pat != null);
            if (pat.Var != null)
            {
                var bv = pat.Var;
                var tt = bv.Type.Subst(typeMap);
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_5(296L, () => forceSubstitutionOfBoundVars, () => MutateCSharp.Schemata178.ReplaceBinExprOp_0(295L, tt, bv.Type)))
                {
                    var newBv = cloneVt(pat, tt, bv);
                    // update substMap to reflect the new BoundVar substitutions
                    var ie = new IdentifierExpr(newBv.Tok, newBv.Name) { Var = newBv, Type = newBv.Type };
                    substMap.Add(bv, ie);
                    var newPat = new CasePattern<VT>(pat.tok, newBv);
                    newPat.AssembleExpr(null);
                    return newPat;
                }
            }
            else if (pat.Arguments != null)
            {
                bool anythingChanged = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(302L, false);
                var newArgs = new List<CasePattern<VT>>();
                foreach (var arg in pat.Arguments)
                {
                    var newArg = SubstituteCasePattern(arg, forceSubstitutionOfBoundVars, cloneVt);
                    newArgs.Add(newArg);
                    if (newArg != arg)
                    {
                        anythingChanged = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(303L, true);
                    }
                }
                if (anythingChanged)
                {
                    var patE = (DatatypeValue)pat.Expr;
                    var newPat = new CasePattern<VT>(pat.tok, pat.Id, newArgs);
                    newPat.Ctor = pat.Ctor;
                    newPat.AssembleExpr(patE.InferredTypeArgs.ConvertAll(tp => tp.Subst(typeMap)));
                    return newPat;
                }
            }
            return pat;
        }

        protected List<Expression/*!*/>/*!*/ SubstituteExprList(List<Expression/*!*/>/*!*/ elist)
        {
            Contract.Requires(cce.NonNullElements(elist));
            Contract.Ensures(cce.NonNullElements(Contract.Result<List<Expression>>()));

            List<Expression> newElist = null;  // initialized lazily
            for (int i = MutateCSharp.Schemata178.ReplaceNumericConstant_13(304L, 0); MutateCSharp.Schemata178.ReplaceBinExprOp_19(308L, i, elist.Count); MutateCSharp.Schemata178.ReplacePostfixUnaryExprOp_20(313L, ref i))
            {
                cce.LoopInvariant(MutateCSharp.Schemata178.ReplaceBinExprOp_5(320L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_25(314L, newElist, null), () => MutateCSharp.Schemata178.ReplaceBinExprOp_26(315L, newElist.Count, i)));

                Expression substE = Substitute(elist[i]);
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_16(328L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(326L, substE, elist[i]), () => MutateCSharp.Schemata178.ReplaceBinExprOp_25(327L, newElist, null)))
                {
                    newElist = new List<Expression>();
                    for (int j = MutateCSharp.Schemata178.ReplaceNumericConstant_13(334L, 0); MutateCSharp.Schemata178.ReplaceBinExprOp_19(338L, j, i); MutateCSharp.Schemata178.ReplacePostfixUnaryExprOp_20(343L, ref j))
                    {
                        newElist.Add(elist[j]);
                    }
                }
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_27(344L, newElist, null))
                {
                    newElist.Add(substE);
                }
            }
            if (MutateCSharp.Schemata178.ReplaceBinExprOp_25(345L, newElist, null))
            {
                return elist;
            }
            else
            {
                return newElist;
            }

            return default;
        }

        protected Dictionary<TypeParameter, Type> SubstituteTypeMap(Dictionary<TypeParameter, Type> tmap)
        {
            Contract.Requires(tmap != null);
            Contract.Ensures(Contract.Result<Dictionary<TypeParameter, Type>>() != null);
            if (MutateCSharp.Schemata178.ReplaceBinExprOp_26(350L, typeMap.Count, MutateCSharp.Schemata178.ReplaceNumericConstant_13(346L, 0)))
            {  // optimization
                return tmap;
            }
            bool anythingChanged = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(355L, false);
            var newTmap = new Dictionary<TypeParameter, Type>();
            var i = MutateCSharp.Schemata178.ReplaceNumericConstant_13(356L, 0);
            foreach (var maplet in tmap)
            {
                var tt = maplet.Value.Subst(typeMap);
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_0(360L, tt, maplet.Value))
                {
                    anythingChanged = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(361L, true);
                }
                newTmap.Add(maplet.Key, tt);
                MutateCSharp.Schemata178.ReplacePostfixUnaryExprOp_20(362L, ref i);
            }
            if (anythingChanged)
            {
                return newTmap;
            }
            else
            {
                return tmap;
            }

            return default;
        }

        protected List<Type> SubstituteTypeList(List<Type> types)
        {
            Contract.Requires(types != null);
            Contract.Ensures(Contract.Result<List<Type>>() != null);
            if (MutateCSharp.Schemata178.ReplaceBinExprOp_26(367L, types.Count, MutateCSharp.Schemata178.ReplaceNumericConstant_13(363L, 0)))
            {  // optimization
                return types;
            }
            bool anythingChanged = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(372L, false);
            var newTypes = new List<Type>();
            var i = MutateCSharp.Schemata178.ReplaceNumericConstant_13(373L, 0);
            foreach (var ty in types)
            {
                var tt = ty.Subst(typeMap);
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_0(377L, tt, ty))
                {
                    anythingChanged = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(378L, true);
                }
                newTypes.Add(tt);
                MutateCSharp.Schemata178.ReplacePostfixUnaryExprOp_20(379L, ref i);
            }
            if (anythingChanged)
            {
                return newTypes;
            }
            else
            {
                return types;
            }

            return default;
        }

        public LocalVariable CloneLocalVariable(CasePattern<LocalVariable> pat, Type tt, LocalVariable lv)
        {
            return new LocalVariable(pat.RangeToken, pat.Id, tt, lv.IsGhost);
        }
        public BoundVar CloneBoundVar(CasePattern<BoundVar> pat, Type tt, BoundVar bv)
        {
            return new BoundVar(pat.tok, pat.Id, tt);
        }
        /// <summary>
        /// This method (which currently is used only internally to class Substituter) performs substitutions in
        /// statements that can occur in a StmtExpr.  (For example, it does not bother to do anything with a
        /// PrintStmt, ReturnStmt, or YieldStmt.)
        /// </summary>
        protected virtual Statement SubstStmt(Statement stmt)
        {
            Statement r;
            if (MutateCSharp.Schemata178.ReplaceBinExprOp_28(380L, stmt, null))
            {
                return null;
            }
            else if (stmt is AssertStmt)
            {
                var s = (AssertStmt)stmt;
                r = new AssertStmt(s.RangeToken, Substitute(s.Expr), SubstBlockStmt(s.Proof), s.Label, SubstAttributes(s.Attributes));
            }
            else if (stmt is ExpectStmt)
            {
                var s = (ExpectStmt)stmt;
                r = new ExpectStmt(s.RangeToken, Substitute(s.Expr), Substitute(s.Message), SubstAttributes(s.Attributes));
            }
            else if (stmt is AssumeStmt)
            {
                var s = (AssumeStmt)stmt;
                r = new AssumeStmt(s.RangeToken, Substitute(s.Expr), SubstAttributes(s.Attributes));
            }
            else if (stmt is BreakStmt)
            {
                var s = (BreakStmt)stmt;
                BreakStmt rr;
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_29(381L, s.TargetLabel, null))
                {
                    rr = new BreakStmt(s.RangeToken, s.TargetLabel, s.IsContinue);
                }
                else
                {
                    rr = new BreakStmt(s.RangeToken, s.BreakAndContinueCount, s.IsContinue);
                }
                // r.TargetStmt will be filled in as later
                if (!BreaksToBeResolved.TryGetValue(s, out var breaks))
                {
                    breaks = new List<BreakStmt>();
                    BreaksToBeResolved.Add(s, breaks);
                }
                breaks.Add(rr);
                r = rr;
            }
            else if (stmt is AssignStmt)
            {
                var s = (AssignStmt)stmt;
                r = new AssignStmt(s.RangeToken, Substitute(s.Lhs), SubstRHS(s.Rhs));
            }
            else if (stmt is CallStmt)
            {
                var s = (CallStmt)stmt;
                var rr = new CallStmt(s.RangeToken, s.Lhs.ConvertAll(Substitute), (MemberSelectExpr)Substitute(s.MethodSelect), s.Args.ConvertAll(Substitute));
                r = rr;
            }
            else if (stmt is DividedBlockStmt)
            {
                r = SubstDividedBlockStmt((DividedBlockStmt)stmt);
            }
            else if (stmt is BlockStmt)
            {
                r = SubstBlockStmt((BlockStmt)stmt);
            }
            else if (stmt is IfStmt)
            {
                var s = (IfStmt)stmt;
                var guard = s.IsBindingGuard ? SubstituteComprehensionExpr((ExistsExpr)s.Guard, MutateCSharp.Schemata178.ReplaceBooleanConstant_6(382L, false)) : Substitute(s.Guard);
                r = new IfStmt(s.RangeToken, s.IsBindingGuard, guard, SubstBlockStmt(s.Thn), SubstStmt(s.Els));
            }
            else if (stmt is AlternativeStmt)
            {
                var s = (AlternativeStmt)stmt;
                r = new AlternativeStmt(s.RangeToken, s.Alternatives.ConvertAll(SubstGuardedAlternative), s.UsesOptionalBraces);
            }
            else if (stmt is WhileStmt)
            {
                var s = (WhileStmt)stmt;
                r = new WhileStmt(s.RangeToken, Substitute(s.Guard), s.Invariants.ConvertAll(SubstMayBeFreeExpr), SubstSpecExpr(s.Decreases), SubstSpecFrameExpr(s.Mod), SubstBlockStmt(s.Body));
            }
            else if (stmt is AlternativeLoopStmt)
            {
                var s = (AlternativeLoopStmt)stmt;
                r = new AlternativeLoopStmt(s.RangeToken, s.Invariants.ConvertAll(SubstMayBeFreeExpr), SubstSpecExpr(s.Decreases), SubstSpecFrameExpr(s.Mod), s.Alternatives.ConvertAll(SubstGuardedAlternative), s.UsesOptionalBraces);
            }
            else if (stmt is ForallStmt)
            {
                var s = (ForallStmt)stmt;
                var newBoundVars = CreateBoundVarSubstitutions(s.BoundVars, MutateCSharp.Schemata178.ReplaceBooleanConstant_6(383L, false));
                var body = SubstStmt(s.Body);
                // undo any changes to substMap (could be optimized to do this only if newBoundVars != e.Vars)
                foreach (var bv in s.BoundVars)
                {
                    substMap.Remove(bv);
                }

                // Put things together
                var rr = new ForallStmt(s.RangeToken, newBoundVars, SubstAttributes(s.Attributes), Substitute(s.Range), s.Ens.ConvertAll(SubstMayBeFreeExpr), body);
                rr.Kind = s.Kind;
                rr.CanConvert = s.CanConvert;
                rr.Bounds = SubstituteBoundedPoolList(s.Bounds);
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_27(384L, s.EffectiveEnsuresClauses, null))
                {
                    rr.EffectiveEnsuresClauses = s.EffectiveEnsuresClauses.ConvertAll(Substitute);
                }
                r = rr;
            }
            else if (stmt is CalcStmt)
            {
                var s = (CalcStmt)stmt;
                var rr = new CalcStmt(s.RangeToken, SubstCalcOp(s.UserSuppliedOp), s.Lines.ConvertAll(Substitute), s.Hints.ConvertAll(SubstBlockStmt), s.StepOps.ConvertAll(SubstCalcOp), SubstAttributes(s.Attributes));
                rr.Op = SubstCalcOp(s.Op);
                rr.Steps.AddRange(s.Steps.ConvertAll(Substitute));
                rr.Result = Substitute(s.Result);
                r = rr;
            }
            else if (stmt is MatchStmt)
            {
                var s = (MatchStmt)stmt;
                var rr = new MatchStmt(s.RangeToken, Substitute(s.Source), s.Cases.ConvertAll(SubstMatchCaseStmt), s.UsesOptionalBraces);
                rr.MissingCases.AddRange(s.MissingCases);
                r = rr;
            }
            else if (stmt is AssignSuchThatStmt)
            {
                var s = (AssignSuchThatStmt)stmt;
                r = new AssignSuchThatStmt(s.RangeToken, s.Lhss.ConvertAll(Substitute), Substitute(s.Expr), s.AssumeToken, null)
                {
                    Bounds = SubstituteBoundedPoolList(s.Bounds)
                };
            }
            else if (stmt is UpdateStmt)
            {
                var s = (UpdateStmt)stmt;
                var resolved = s.ResolvedStatements;
                UpdateStmt rr;
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_26(389L, resolved.Count, MutateCSharp.Schemata178.ReplaceNumericConstant_13(385L, 1)))
                {
                    // when later translating this UpdateStmt, the s.Lhss and s.Rhss components won't be used, only s.ResolvedStatements
                    rr = new UpdateStmt(s.RangeToken, s.Lhss, s.Rhss, s.CanMutateKnownState);
                }
                else
                {
                    rr = new UpdateStmt(s.RangeToken, s.Lhss.ConvertAll(Substitute), s.Rhss.ConvertAll(SubstRHS), s.CanMutateKnownState);
                }

                if (MutateCSharp.Schemata178.ReplaceBinExprOp_30(394L, s.ResolvedStatements, null))
                {
                    rr.ResolvedStatements = s.ResolvedStatements.ConvertAll(SubstStmt);
                }
                r = rr;
            }
            else if (stmt is VarDeclStmt)
            {
                var s = (VarDeclStmt)stmt;
                var lhss = CreateLocalVarSubstitutions(s.Locals, MutateCSharp.Schemata178.ReplaceBooleanConstant_6(395L, false));
                var rr = new VarDeclStmt(s.RangeToken, lhss, (ConcreteUpdateStatement)SubstStmt(s.Update));
                r = rr;
            }
            else if (stmt is VarDeclPattern)
            {
                var s = (VarDeclPattern)stmt;
                var lhss = SubstituteCasePattern(s.LHS, MutateCSharp.Schemata178.ReplaceBooleanConstant_6(396L, false), CloneLocalVariable);
                var rr = new VarDeclPattern(s.RangeToken, lhss, (Expression)Substitute(s.RHS), s.HasGhostModifier);
                r = rr;
            }
            else if (stmt is RevealStmt)
            {
                var s = (RevealStmt)stmt;
                // don't need to substitute s.Expr since it won't be used, only the s.ResolvedStatements are used.
                var rr = new RevealStmt(s.RangeToken, s.Exprs);
                rr.LabeledAsserts.AddRange(s.LabeledAsserts);
                rr.ResolvedStatements.AddRange(s.ResolvedStatements.ConvertAll(SubstStmt));
                r = rr;
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected statement
            }

            // add labels to the cloned statement
            AddStmtLabels(r, stmt.Labels);
            r.Attributes = SubstAttributes(stmt.Attributes);
            r.IsGhost = stmt.IsGhost;
            if (MutateCSharp.Schemata178.ReplaceBinExprOp_5(398L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_31(397L, stmt.Labels, null), () => stmt is WhileStmt))
            {
                if (BreaksToBeResolved.TryGetValue(stmt, out var breaks))
                {
                    foreach (var b in breaks)
                    {
                        b.TargetStmt = r;
                    }
                    BreaksToBeResolved.Remove(stmt);
                }
            }

            return r;
        }

        Dictionary<Statement, List<BreakStmt>> BreaksToBeResolved = new Dictionary<Statement, List<BreakStmt>>();  // old-target -> new-breaks

        protected void AddStmtLabels(Statement s, LList<Label> node)
        {
            if (MutateCSharp.Schemata178.ReplaceBinExprOp_31(404L, node, null))
            {
                AddStmtLabels(s, node.Next);
                s.Labels = new LList<Label>(node.Data, s.Labels);
            }
        }

        protected virtual DividedBlockStmt SubstDividedBlockStmt(DividedBlockStmt stmt)
        {
            return MutateCSharp.Schemata178.ReplaceBinExprOp_32(405L, stmt, null) ? null : new DividedBlockStmt(stmt.RangeToken, stmt.BodyInit.ConvertAll(SubstStmt), stmt.SeparatorTok, stmt.BodyProper.ConvertAll(SubstStmt));
        }

        protected virtual BlockStmt SubstBlockStmt(BlockStmt stmt)
        {
            if (MutateCSharp.Schemata178.ReplaceBinExprOp_33(406L, stmt, null))
            {
                return null;
            }
            var prevSubstMap = new Dictionary<IVariable, Expression>(substMap);
            var b = new BlockStmt(stmt.RangeToken, stmt.Body.ConvertAll(SubstStmt));
            if (MutateCSharp.Schemata178.ReplaceBinExprOp_34(407L, substMap.Count, prevSubstMap.Count))
            {
                // reset substMap to what it was (note that substMap is a readonly field, so we can't just change it back to prevSubstMap)
                substMap.Clear();
                foreach (var item in prevSubstMap)
                {
                    substMap.Add(item.Key, item.Value);
                }
            }
            return b;
        }

        protected GuardedAlternative SubstGuardedAlternative(GuardedAlternative alt)
        {
            Contract.Requires(alt != null);
            var guard = alt.IsBindingGuard ? SubstituteComprehensionExpr((ExistsExpr)alt.Guard, MutateCSharp.Schemata178.ReplaceBooleanConstant_6(412L, false)) : Substitute(alt.Guard);
            return new GuardedAlternative(alt.Tok, alt.IsBindingGuard, guard, alt.Body.ConvertAll(SubstStmt));
        }

        protected AttributedExpression SubstMayBeFreeExpr(AttributedExpression expr)
        {
            Contract.Requires(expr != null);
            var mfe = new AttributedExpression(Substitute(expr.E));
            mfe.Attributes = SubstAttributes(expr.Attributes);
            return mfe;
        }

        protected Specification<Expression> SubstSpecExpr(Specification<Expression> spec)
        {
            var ee = MutateCSharp.Schemata178.ReplaceBinExprOp_25(413L, spec.Expressions, null) ? null : spec.Expressions.ConvertAll(Substitute);
            return new Specification<Expression>(ee, SubstAttributes(spec.Attributes));
        }

        public Specification<FrameExpression> SubstSpecFrameExpr(Specification<FrameExpression> frame)
        {
            var ee = MutateCSharp.Schemata178.ReplaceBinExprOp_35(414L, frame.Expressions, null) ? null : frame.Expressions.ConvertAll(SubstFrameExpr);
            return new Specification<FrameExpression>(ee, SubstAttributes(frame.Attributes));
        }

        public FrameExpression SubstFrameExpr(FrameExpression frame)
        {
            Contract.Requires(frame != null);
            var fe = new FrameExpression(frame.tok, Substitute(frame.E), frame.FieldName);
            fe.Field = frame.Field;  // resolve here
            return fe;
        }

        protected AssignmentRhs SubstRHS(AssignmentRhs rhs)
        {
            AssignmentRhs c;
            if (rhs is ExprRhs)
            {
                var r = (ExprRhs)rhs;
                c = new ExprRhs(Substitute(r.Expr));
            }
            else if (rhs is HavocRhs)
            {
                c = new HavocRhs(rhs.Tok);
            }
            else
            {
                // since the Substituter is assumed to operate on statements only if they are part of a StatementExpression, then the TypeRhs case cannot occur
                Contract.Assume(false); throw new cce.UnreachableException();
            }
            c.Attributes = SubstAttributes(rhs.Attributes);
            return c;
        }

        protected MatchCaseStmt SubstMatchCaseStmt(MatchCaseStmt c)
        {
            Contract.Requires(c != null);
            var newBoundVars = CreateBoundVarSubstitutions(c.Arguments, MutateCSharp.Schemata178.ReplaceBooleanConstant_6(415L, false));
            var r = new MatchCaseStmt(c.RangeToken, c.Ctor, c.FromBoundVar, newBoundVars, c.Body.ConvertAll(SubstStmt), c.Attributes);
            r.Ctor = c.Ctor;
            // undo any changes to substMap (could be optimized to do this only if newBoundVars != e.Vars)
            foreach (var bv in c.Arguments)
            {
                substMap.Remove(bv);
            }
            return r;
        }

        protected CalcStmt.CalcOp SubstCalcOp(CalcStmt.CalcOp op)
        {
            if (MutateCSharp.Schemata178.ReplaceBinExprOp_36(416L, op, null))
            {
                return null;
            }
            else if (op is CalcStmt.BinaryCalcOp)
            {
                return new CalcStmt.BinaryCalcOp(((CalcStmt.BinaryCalcOp)op).Op);
            }
            else if (op is CalcStmt.TernaryCalcOp)
            {
                return new CalcStmt.TernaryCalcOp(Substitute(((CalcStmt.TernaryCalcOp)op).Index));
            }
            else
            {
                Contract.Assert(false);
                throw new cce.UnreachableException();
            }

            return default;
        }

        public Attributes SubstAttributes(Attributes attrs)
        {
            Contract.Requires(cce.NonNullDictionaryAndValues(substMap));
            if (MutateCSharp.Schemata178.ReplaceBinExprOp_37(417L, attrs, null))
            {
                var newArgs = new List<Expression>();  // allocate it eagerly, what the heck, it doesn't seem worth the extra complexity in the code to do it lazily for the infrequently occurring attributes
                bool anyArgSubst = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(418L, false);
                foreach (var arg in attrs.Args)
                {
                    var argToBeAdded = arg;
                    var substArg = Substitute(arg);
                    if (MutateCSharp.Schemata178.ReplaceBinExprOp_7(419L, substArg, arg))
                    {
                        argToBeAdded = substArg;
                        anyArgSubst = MutateCSharp.Schemata178.ReplaceBooleanConstant_6(420L, true);
                    }
                    newArgs.Add(argToBeAdded);
                }
                if (!anyArgSubst)
                {
                    newArgs = attrs.Args;
                }

                Attributes prev = SubstAttributes(attrs.Prev);
                if (MutateCSharp.Schemata178.ReplaceBinExprOp_5(423L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_4(421L, newArgs, attrs.Args), () => MutateCSharp.Schemata178.ReplaceBinExprOp_38(422L, prev, attrs.Prev)))
                {
                    if (attrs is UserSuppliedAttributes)
                    {
                        var usa = (UserSuppliedAttributes)attrs;
                        return new UserSuppliedAttributes(usa.tok, usa.OpenBrace, usa.CloseBrace, newArgs, prev);
                    }
                    else
                    {
                        return new Attributes(attrs.Name, newArgs, prev);
                    }
                }
            }
            return attrs;
        }

        /// <summary>
        /// Substitution in a comprehension expression. 
        /// Parameter 'forceSubstituteOfBoundVars' should be set to false if and only if
        /// the expression is a binding guard, in which case a bound variable is introduced.
        /// Such a variable must not be substituted. 
        /// </summary>
        protected Expression SubstituteComprehensionExpr(ComprehensionExpr expr, bool forceSubstituteOfBoundVars)
        {

            Expression newExpr = null;

            var e = (ComprehensionExpr)expr;
            // For quantifiers and setComprehesion we want to make sure that we don't introduce name clashes with
            // the enclosing scopes.

            var q = e as QuantifierExpr;
            if (MutateCSharp.Schemata178.ReplaceBinExprOp_16(431L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_39(429L, q, null), () => MutateCSharp.Schemata178.ReplaceBinExprOp_27(430L, q.SplitQuantifier, null)))
            {
                if (forceSubstituteOfBoundVars)
                {
                    return Substitute(q.SplitQuantifierExpression);
                }
                else
                {
                    return SubstituteComprehensionExpr((ComprehensionExpr)q.SplitQuantifierExpression, MutateCSharp.Schemata178.ReplaceBooleanConstant_6(437L, false));
                }
            }

            var newBoundVars = CreateBoundVarSubstitutions(e.BoundVars, MutateCSharp.Schemata178.ReplaceBinExprOp_16(450L, () => forceSubstituteOfBoundVars, () => (MutateCSharp.Schemata178.ReplaceBinExprOp_5(444L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_5(438L, () => expr is ForallExpr, () => expr is ExistsExpr), () => expr is SetComprehension))));
            var newRange = MutateCSharp.Schemata178.ReplaceBinExprOp_1(456L, e.Range, null) ? null : Substitute(e.Range);
            var newTerm = Substitute(e.Term);
            var newAttrs = SubstAttributes(e.Attributes);
            var newBounds = SubstituteBoundedPoolList(e.Bounds);
            if (MutateCSharp.Schemata178.ReplaceBinExprOp_5(486L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_5(480L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_5(473L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_5(466L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_5(459L, () => MutateCSharp.Schemata178.ReplaceBinExprOp_11(457L, newBoundVars, e.BoundVars), () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(458L, newRange, e.Range)), () => MutateCSharp.Schemata178.ReplaceBinExprOp_7(465L, newTerm, e.Term)), () => MutateCSharp.Schemata178.ReplaceBinExprOp_38(472L, newAttrs, e.Attributes)), () => MutateCSharp.Schemata178.ReplaceBinExprOp_40(479L, newBounds, e.Bounds)), () => !forceSubstituteOfBoundVars))
            {
                if (e is SetComprehension)
                {
                    newExpr = new SetComprehension(e.BodyStartTok, e.RangeToken, ((SetComprehension)e).Finite, newBoundVars,
                      newRange, newTerm, newAttrs);
                }
                else if (e is MapComprehension)
                {
                    var mc = (MapComprehension)e;
                    var newTermLeft = mc.IsGeneralMapComprehension ? Substitute(mc.TermLeft) : null;
                    newExpr = new MapComprehension(e.BodyStartTok, e.RangeToken, mc.Finite, newBoundVars, newRange, newTermLeft, newTerm, newAttrs);
                }
                else if (expr is ForallExpr forallExpr)
                {
                    newExpr = new ForallExpr(expr.tok, e.RangeToken, newBoundVars, newRange, newTerm, newAttrs);
                }
                else if (expr is ExistsExpr existsExpr)
                {
                    newExpr = new ExistsExpr(expr.tok, e.RangeToken, newBoundVars, newRange, newTerm, newAttrs);
                }
                else if (expr is LambdaExpr)
                {
                    var l = (LambdaExpr)expr;
                    newExpr = new LambdaExpr(e.BodyStartTok, e.RangeToken, newBoundVars, newRange,
                      SubstSpecFrameExpr(l.Reads), newTerm);
                }
                else
                {
                    Contract.Assert(false); // unexpected ComprehensionExpr
                }

              ((ComprehensionExpr)newExpr).Bounds = newBounds;
            }

            // undo any changes to substMap (could be optimized to do this only if newBoundVars != e.BoundVars)
            foreach (var bv in e.BoundVars)
            {
                substMap.Remove(bv);
            }

            return newExpr;

        }

    }
}

