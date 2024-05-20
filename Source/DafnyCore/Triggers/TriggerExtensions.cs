// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT

#define THROW_UNSUPPORTED_COMPARISONS

using Microsoft.Dafny;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using DafnyCore.Generic;
namespace MutateCSharp
{
    internal class Schemata479
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT479");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument1, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.MemberDecl argument1, Microsoft.Dafny.MemberDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, System.Type argument1, System.Type argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.IVariable argument1, Microsoft.Dafny.IVariable argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_20(long mutantId, Microsoft.Dafny.DatatypeCtor argument1, Microsoft.Dafny.DatatypeCtor argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.Function argument1, Microsoft.Dafny.Function argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_18(long mutantId, Microsoft.Dafny.IVariable argument1, Microsoft.Dafny.IVariable argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.TernaryExpr.Opcode argument1, Microsoft.Dafny.TernaryExpr.Opcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.Type argument1, Microsoft.Dafny.Type argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.BoundVar argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.UnaryOpExpr.ResolvedOpcode argument1, Microsoft.Dafny.UnaryOpExpr.ResolvedOpcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, Microsoft.Dafny.FunctionCallExpr.CoCallResolution argument1, Microsoft.Dafny.FunctionCallExpr.CoCallResolution argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny.Triggers
{
    public static class DeduplicateExtension
    {
        public static List<T> Deduplicate<T>(this IEnumerable<T> seq, Func<T, T, bool> eq)
        {
            List<T> deduplicated = new List<T>();

            foreach (var elem in seq)
            {
                if (!deduplicated.Any(other => eq(elem, other)))
                {
                    deduplicated.Add(elem);
                }
            }

            return deduplicated;
        }
    }

    public static class ExprExtensions
    {
        private static bool IsInlineable(this LetExpr expr)
        {
            return MutateCSharp.Schemata479.ReplaceBinExprOp_1(2L, () => expr.LHSs.All(p => MutateCSharp.Schemata479.ReplaceBinExprOp_0(1L, p.Var, null)), () => expr.Exact);
        }

        internal static IEnumerable<Expression> AllSubExpressions(this Expression expr, bool wrapOld, bool strict, bool inlineLets = false)
        {
            var isOld = expr is OldExpr ? new HashSet<OldExpr>() { expr as OldExpr } : null;

            if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(14L, () => MutateCSharp.Schemata479.ReplaceBinExprOp_1(8L, () => inlineLets, () => expr is LetExpr), () => ((LetExpr)expr).IsInlineable()))
            {
                var le = (LetExpr)expr;
                foreach (var subexpr in AllSubExpressions(BoogieGenerator.InlineLet(le), wrapOld, strict, inlineLets))
                {
                    yield return subexpr;
                }
                // If strict is false, then the recursive call will already yield a copy of (the inlined version) of expr,
                // so there's no need to yield expr itself below.
                yield break;
            }

            foreach (var subexpr in expr.SubExpressions)
            {
                foreach (var r_subexpr in AllSubExpressions(subexpr, wrapOld, MutateCSharp.Schemata479.ReplaceBooleanConstant_2(20L, false), inlineLets))
                {
                    foreach (var e in TriggerUtils.MaybeWrapInOld(r_subexpr, isOld))
                    {
                        yield return e;
                    }
                }
            }

            if (expr is StmtExpr)
            {
                foreach (var r_subexpr in AllSubExpressions(((StmtExpr)expr).S, wrapOld, MutateCSharp.Schemata479.ReplaceBooleanConstant_2(21L, false), inlineLets))
                {
                    foreach (var e in TriggerUtils.MaybeWrapInOld(r_subexpr, isOld))
                    {
                        yield return e;
                    }
                }
            }

            if (!strict)
            {
                yield return expr;
            }

            yield break;
        }

        internal static IEnumerable<Expression> AllSubExpressions(this Statement stmt, bool wrapOld, bool strict, bool inlineLets = false)
        {
            foreach (var subexpr in stmt.SubExpressions)
            {
                foreach (var r_subexpr in AllSubExpressions(subexpr, wrapOld, MutateCSharp.Schemata479.ReplaceBooleanConstant_2(22L, false), inlineLets))
                {
                    yield return r_subexpr;
                }
            }

            foreach (var substmt in stmt.SubStatements)
            {
                foreach (var r_subexpr in AllSubExpressions(substmt, wrapOld, MutateCSharp.Schemata479.ReplaceBooleanConstant_2(23L, false), inlineLets))
                {
                    yield return r_subexpr;
                }
            }

            yield break;
        }

        internal static bool ExpressionEq(this Expression expr1, Expression expr2)
        {
            expr1 = expr1.Resolved;
            expr2 = expr2.Resolved;

            return MutateCSharp.Schemata479.ReplaceBinExprOp_1(24L, () => ShallowEq_Top(expr1, expr2), () => expr1.SubExpressions.SequenceEqual(expr2.SubExpressions, new PredicateEqualityComparer<Expression>(ExpressionEq)));
        }

        internal static bool ExpressionEqModuloExpressionsNotInvolvingBoundVariables(this Expression expr1, Expression expr2, ISet<BoundVar> boundVars, DafnyOptions options)
        {
            expr1 = expr1.Resolved;
            expr2 = expr2.Resolved;

            if (expr1 is IdentifierExpr)
            {
                if (expr2 is IdentifierExpr)
                {
                    return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(30L, true);
                }
                else
                {
                    var freeInE2 = FreeVariablesUtil.ComputeFreeVariables(options, expr2);
                    freeInE2.IntersectWith(boundVars);
                    return !freeInE2.Any();
                }
            }

            Func<Expression, Expression, bool> comparer = (e1, e2) => ExpressionEqModuloExpressionsNotInvolvingBoundVariables(e1, e2, boundVars, options);
            return MutateCSharp.Schemata479.ReplaceBinExprOp_1(31L, () => ShallowEq_Top(expr1, expr2), () => expr1.SubExpressions.SequenceEqual(expr2.SubExpressions, new PredicateEqualityComparer<Expression>(comparer)));
        }

        internal static bool MatchesTrigger(this Expression expr, Expression trigger, ISet<BoundVar> holes, Dictionary<IVariable, Expression> bindings)
        {
            expr = expr.Resolved;
            trigger = trigger.Resolved;

            if (trigger is IdentifierExpr)
            {
                var var = ((IdentifierExpr)trigger).Var;

                if (holes.Contains(var))
                {
                    Expression existing_binding = null;
                    if (bindings.TryGetValue(var, out existing_binding))
                    {
                        return ExpressionEq(expr, existing_binding);
                    }
                    else
                    {
                        bindings[var] = expr;
                        return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(37L, true);
                    }
                }
            }

            Func<Expression, Expression, bool> comparer = (e1, e2) => MatchesTrigger(e1, e2, holes, bindings);
            return MutateCSharp.Schemata479.ReplaceBinExprOp_1(38L, () => ShallowEq_Top(expr, trigger), () => expr.SubExpressions.SequenceEqual(trigger.SubExpressions, new PredicateEqualityComparer<Expression>(comparer)));
        }

        private static TriggerMatch? MatchAgainst(this Expression expr, Expression trigger, IEnumerable<BoundVar> holes, Expression originalExpr)
        {
            var bindings = new Dictionary<IVariable, Expression>();
            if (expr.MatchesTrigger(trigger, new HashSet<BoundVar>(holes), bindings))
            {
                return new TriggerMatch { Expr = expr, OriginalExpr = originalExpr ?? expr, Bindings = bindings };
            }
            else
            {
                return null;
            }

            return default;
        }

        internal static IEnumerable<TriggerMatch> SubexpressionsMatchingTrigger(this ComprehensionExpr quantifier, Expression trigger)
        {
            return quantifier.AllSubExpressions(MutateCSharp.Schemata479.ReplaceBooleanConstant_2(44L, true), MutateCSharp.Schemata479.ReplaceBooleanConstant_2(45L, true), MutateCSharp.Schemata479.ReplaceBooleanConstant_2(46L, true))
              .Select(e => TriggersCollector.PrepareExprForInclusionInTrigger(e).MatchAgainst(trigger, quantifier.BoundVars, e))
              .Where(e => e.HasValue).Select(e => e.Value);
        }

        private static bool ShallowSameAttributes(Attributes attributes1, Attributes attributes2)
        {
            Func<Attributes, Attributes, bool> comparer = ShallowSameSingleAttribute;
            return attributes1.AsEnumerable().SequenceEqual(attributes2.AsEnumerable(), new PredicateEqualityComparer<Attributes>(comparer));
        }

        private static bool ShallowSameSingleAttribute(Attributes arg1, Attributes arg2)
        {
            return MutateCSharp.Schemata479.ReplaceBinExprOp_3(47L, arg1.Name, arg2.Name);
        }

        private static bool SameBoundVar(IVariable arg1, IVariable arg2)
        {
            return MutateCSharp.Schemata479.ReplaceBinExprOp_8(122L, () => MutateCSharp.Schemata479.ReplaceBinExprOp_4(48L, arg1, arg2), () => (MutateCSharp.Schemata479.ReplaceBinExprOp_1(116L, () => MutateCSharp.Schemata479.ReplaceBinExprOp_1(89L, () => MutateCSharp.Schemata479.ReplaceBinExprOp_1(77L, () => MutateCSharp.Schemata479.ReplaceBinExprOp_1(65L, () => MutateCSharp.Schemata479.ReplaceBinExprOp_1(58L, () => MutateCSharp.Schemata479.ReplaceBinExprOp_1(51L, () => MutateCSharp.Schemata479.ReplaceBinExprOp_3(49L, arg1.Name, arg2.Name), () => MutateCSharp.Schemata479.ReplaceBinExprOp_3(50L, arg1.CompileName, arg2.CompileName)), () => MutateCSharp.Schemata479.ReplaceBinExprOp_3(57L, arg1.DisplayName, arg2.DisplayName)), () => MutateCSharp.Schemata479.ReplaceBinExprOp_3(64L, arg1.UniqueName, arg2.UniqueName)), () => MutateCSharp.Schemata479.ReplaceBinExprOp_5(71L, () => arg1.IsGhost, () => arg2.IsGhost)), () => MutateCSharp.Schemata479.ReplaceBinExprOp_5(83L, () => arg1.IsMutable, () => arg2.IsMutable)), () => (MutateCSharp.Schemata479.ReplaceBinExprOp_8(110L, () => (MutateCSharp.Schemata479.ReplaceBinExprOp_1(97L, () => MutateCSharp.Schemata479.ReplaceBinExprOp_6(95L, arg1.Type, null), () => MutateCSharp.Schemata479.ReplaceBinExprOp_6(96L, arg2.Type, null))), () => (MutateCSharp.Schemata479.ReplaceBinExprOp_1(104L, () => MutateCSharp.Schemata479.ReplaceBinExprOp_7(103L, arg1.Type, null), () => arg1.Type.Equals(arg2.Type))))))));
        }

        /// <summary>
        /// Compares two abstract syntax expressions, looking only at their direct members. Subexpressions and substatements are not compared.
        /// </summary>
        /// <returns></returns>
        internal static bool ShallowEq_Top(Expression expr1, Expression expr2)
        {
            Contract.Requires(expr1 != null);
            Contract.Requires(expr2 != null);

            // We never compare concrete expressions
            Contract.Requires(!(expr1 is ConcreteSyntaxExpression));
            Contract.Requires(!(expr2 is ConcreteSyntaxExpression));

            // CPC: Hey future editor: the following block of code is auto-generated. Just add your own cases at the end.
            //      This could be a visitor pattern, except I need to visit a pair of nodes.
            //      It could also be implemented in each individual class. I'd have a slight preference for that.
            //      This really just wants to use double dispatch.
            if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(128L, () => expr1 is UnboxingCastExpr, () => expr2 is UnboxingCastExpr))
            {
                return ShallowEq((UnboxingCastExpr)expr1, (UnboxingCastExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(134L, () => expr1 is BoxingCastExpr, () => expr2 is BoxingCastExpr))
            {
                return ShallowEq((BoxingCastExpr)expr1, (BoxingCastExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(140L, () => expr1 is MatchExpr, () => expr2 is MatchExpr))
            {
                return ShallowEq((MatchExpr)expr1, (MatchExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(146L, () => expr1 is ITEExpr, () => expr2 is ITEExpr))
            {
                return ShallowEq((ITEExpr)expr1, (ITEExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(152L, () => expr1 is StmtExpr, () => expr2 is StmtExpr))
            {
                return ShallowEq((StmtExpr)expr1, (StmtExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(158L, () => expr1 is WildcardExpr, () => expr2 is WildcardExpr))
            {
                return ShallowEq((WildcardExpr)expr1, (WildcardExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(164L, () => expr1 is ComprehensionExpr, () => expr2 is ComprehensionExpr))
            {
                return ShallowEq((ComprehensionExpr)expr1, (ComprehensionExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(170L, () => expr1 is LetExpr, () => expr2 is LetExpr))
            {
                return ShallowEq((LetExpr)expr1, (LetExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(176L, () => expr1 is TernaryExpr, () => expr2 is TernaryExpr))
            {
                return ShallowEq((TernaryExpr)expr1, (TernaryExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(182L, () => expr1 is BinaryExpr, () => expr2 is BinaryExpr))
            {
                return ShallowEq((BinaryExpr)expr1, (BinaryExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(188L, () => expr1 is UnaryExpr, () => expr2 is UnaryExpr))
            {
                return ShallowEq((UnaryExpr)expr1, (UnaryExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(194L, () => expr1 is SeqConstructionExpr, () => expr2 is SeqConstructionExpr))
            {
                return ShallowEq((SeqConstructionExpr)expr1, (SeqConstructionExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(200L, () => expr1 is MultiSetFormingExpr, () => expr2 is MultiSetFormingExpr))
            {
                return ShallowEq((MultiSetFormingExpr)expr1, (MultiSetFormingExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(206L, () => expr1 is OldExpr, () => expr2 is OldExpr))
            {
                return ShallowEq((OldExpr)expr1, (OldExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(212L, () => expr1 is FunctionCallExpr, () => expr2 is FunctionCallExpr))
            {
                return ShallowEq((FunctionCallExpr)expr1, (FunctionCallExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(218L, () => expr1 is ApplyExpr, () => expr2 is ApplyExpr))
            {
                return ShallowEq((ApplyExpr)expr1, (ApplyExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(224L, () => expr1 is SeqUpdateExpr, () => expr2 is SeqUpdateExpr))
            {
                return ShallowEq((SeqUpdateExpr)expr1, (SeqUpdateExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(230L, () => expr1 is MultiSelectExpr, () => expr2 is MultiSelectExpr))
            {
                return ShallowEq((MultiSelectExpr)expr1, (MultiSelectExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(236L, () => expr1 is SeqSelectExpr, () => expr2 is SeqSelectExpr))
            {
                return ShallowEq((SeqSelectExpr)expr1, (SeqSelectExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(242L, () => expr1 is MemberSelectExpr, () => expr2 is MemberSelectExpr))
            {
                return ShallowEq((MemberSelectExpr)expr1, (MemberSelectExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(248L, () => expr1 is MapDisplayExpr, () => expr2 is MapDisplayExpr))
            { //Note: MapDisplayExpr is not a DisplayExpression
                return ShallowEq((MapDisplayExpr)expr1, (MapDisplayExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(254L, () => expr1 is DisplayExpression, () => expr2 is DisplayExpression))
            {
                return ShallowEq((DisplayExpression)expr1, (DisplayExpression)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(260L, () => expr1 is IdentifierExpr, () => expr2 is IdentifierExpr))
            {
                return ShallowEq((IdentifierExpr)expr1, (IdentifierExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(266L, () => expr1 is ThisExpr, () => expr2 is ThisExpr))
            {
                return ShallowEq((ThisExpr)expr1, (ThisExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(272L, () => expr1 is DatatypeValue, () => expr2 is DatatypeValue))
            {
                return ShallowEq((DatatypeValue)expr1, (DatatypeValue)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(278L, () => expr1 is LiteralExpr, () => expr2 is LiteralExpr))
            {
                return ShallowEq((LiteralExpr)expr1, (LiteralExpr)expr2);
            }
            else
            {
                // If this assertion fail, then a new abstract AST node was probably introduced but not registered here.
                Contract.Assert(expr1.GetType() != expr2.GetType());
                return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(284L, false);
            }

            return default;
        }

        private static bool ShallowEq(UnboxingCastExpr expr1, UnboxingCastExpr expr2)
        {
            Contract.Requires(false);
            throw new InvalidOperationException();
            return default;
        }

        private static bool ShallowEq(BoxingCastExpr expr1, BoxingCastExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBinExprOp_1(287L, () => MutateCSharp.Schemata479.ReplaceBinExprOp_9(285L, expr1.FromType, expr2.FromType), () => MutateCSharp.Schemata479.ReplaceBinExprOp_9(286L, expr1.ToType, expr2.ToType));
        }

        private static bool ShallowEq(MatchExpr expr1, MatchExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(293L, true);
        }

        private static bool ShallowEq(ITEExpr expr1, ITEExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(294L, true);
        }

        private static bool ShallowEq(StmtExpr expr1, StmtExpr expr2)
        {
#if THROW_UNSUPPORTED_COMPARISONS
            Contract.Assume(false); // This kind of expression never appears in a trigger
            throw new NotImplementedException();
            return default;
#else
      return expr1.S == expr2.S;
#endif
        }

        private static bool ShallowEq(WildcardExpr expr1, WildcardExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(295L, true);
        }

        private static bool ShallowEq(LambdaExpr expr1, LambdaExpr expr2)
        {
#if THROW_UNSUPPORTED_COMPARISONS
            Contract.Assume(false); // This kind of expression never appears in a trigger
            throw new NotImplementedException();
            return default;
#else
      return false;
#endif
        }

        private static bool ShallowEq(MapComprehension expr1, MapComprehension expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBinExprOp_5(296L, () => expr1.Finite, () => expr2.Finite);
        }

        private static bool ShallowEq(SetComprehension expr1, SetComprehension expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBinExprOp_1(314L, () => MutateCSharp.Schemata479.ReplaceBinExprOp_5(302L, () => expr1.TermIsImplicit, () => expr2.TermIsImplicit), () => MutateCSharp.Schemata479.ReplaceBinExprOp_5(308L, () => expr1.Finite, () => expr2.Finite));
        }

        private static bool ShallowEq(ExistsExpr expr1, ExistsExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(320L, true);
        }

        private static bool ShallowEq(ForallExpr expr1, ForallExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(321L, true);
        }

        private static bool ShallowEq(QuantifierExpr expr1, QuantifierExpr expr2)
        {
            if (!TriggerUtils.SameNullity(expr1.SplitQuantifier, expr2.SplitQuantifier))
            {
                return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(322L, false);
            }

            if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(325L, () => MutateCSharp.Schemata479.ReplaceBinExprOp_10(323L, expr1.SplitQuantifier, null), () => MutateCSharp.Schemata479.ReplaceBinExprOp_10(324L, expr2.SplitQuantifier, null)))
            {
                return ShallowEq_Top(expr1.SplitQuantifierExpression, expr2.SplitQuantifierExpression);
            }

            if (!TriggerUtils.SameNullity(expr1.Range, expr2.Range))
            {
                return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(331L, false);
            }

            if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(332L, () => expr1 is ExistsExpr, () => expr2 is ExistsExpr))
            {
                return ShallowEq((ExistsExpr)expr1, (ExistsExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(338L, () => expr1 is ForallExpr, () => expr2 is ForallExpr))
            {
                return ShallowEq((ForallExpr)expr1, (ForallExpr)expr2);
            }
            else
            {
                return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(344L, false);
            }

            return default;
        }

        private static bool ShallowEq(ComprehensionExpr expr1, ComprehensionExpr expr2)
        {
            Func<BoundVar, BoundVar, bool> comparer = SameBoundVar;
            if (MutateCSharp.Schemata479.ReplaceBinExprOp_8(351L, () => MutateCSharp.Schemata479.ReplaceBinExprOp_8(345L, () => !expr1.BoundVars.SequenceEqual(expr2.BoundVars, new PredicateEqualityComparer<BoundVar>(comparer)), () => !ShallowSameAttributes(expr1.Attributes, expr2.Attributes)), () =>
                // Filled in during resolution: !SameLists(expr1.Bounds, expr2.Bounds, ReferenceCompare) ||
                //                              !SameLists(expr1.MissingBounds, expr2.MissingBounds, SameBoundVar) ||
                !TriggerUtils.SameNullity(expr1.Range, expr2.Range)))
            { //TODO Check
                return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(357L, false);
            }

            if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(358L, () => expr1 is LambdaExpr, () => expr2 is LambdaExpr))
            {
                return ShallowEq((LambdaExpr)expr1, (LambdaExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(364L, () => expr1 is MapComprehension, () => expr2 is MapComprehension))
            {
                return ShallowEq((MapComprehension)expr1, (MapComprehension)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(370L, () => expr1 is SetComprehension, () => expr2 is SetComprehension))
            {
                return ShallowEq((SetComprehension)expr1, (SetComprehension)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(376L, () => expr1 is QuantifierExpr, () => expr2 is QuantifierExpr))
            {
                return ShallowEq((QuantifierExpr)expr1, (QuantifierExpr)expr2);
            }
            else
            {
                return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(382L, false); // ComprehensionExpr is abstract
            }

            return default;
        }

        private static bool ShallowEq(LetExpr expr1, LetExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBinExprOp_1(389L, () => MutateCSharp.Schemata479.ReplaceBinExprOp_5(383L, () => expr1.Exact, () => expr2.Exact), () => ShallowSameAttributes(expr1.Attributes, expr2.Attributes));
        }

        private static bool ShallowEq(TernaryExpr expr1, TernaryExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBinExprOp_11(395L, expr1.Op, expr2.Op);
        }

        private static bool ShallowEq(BinaryExpr expr1, BinaryExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBinExprOp_12(396L, expr1.ResolvedOp, expr2.ResolvedOp);
        }

        private static bool ShallowEq(ConversionExpr expr1, ConversionExpr expr2)
        {
            return Type.Equal_Improved(expr1.Type, expr2.Type);
        }

        private static bool ShallowEq(TypeTestExpr expr1, TypeTestExpr expr2)
        {
            return Type.Equal_Improved(expr1.Type, expr2.Type);
        }

        private static bool ShallowEq(UnaryOpExpr expr1, UnaryOpExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBinExprOp_13(397L, expr1.ResolvedOp, expr2.ResolvedOp);
        }

        private static bool ShallowEq(UnaryExpr expr1, UnaryExpr expr2)
        {
            if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(398L, () => expr1 is ConversionExpr, () => expr2 is ConversionExpr))
            {
                return ShallowEq((ConversionExpr)expr1, (ConversionExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(404L, () => expr1 is TypeTestExpr, () => expr2 is TypeTestExpr))
            {
                return ShallowEq((TypeTestExpr)expr1, (TypeTestExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(410L, () => expr1 is UnaryOpExpr, () => expr2 is UnaryOpExpr))
            {
                return ShallowEq((UnaryOpExpr)expr1, (UnaryOpExpr)expr2);
            }
            else
            {
                return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(416L, false); // UnaryExpr is abstract
            }

            return default;
        }

        private static bool ShallowEq(MultiSetFormingExpr expr1, MultiSetFormingExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(417L, true);
        }

        private static bool ShallowEq(SeqConstructionExpr expr1, SeqConstructionExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(418L, true);
        }

        private static bool ShallowEq(OldExpr expr1, OldExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(419L, true);
        }

        private static bool ShallowEq(FunctionCallExpr expr1, FunctionCallExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBinExprOp_1(429L, () => MutateCSharp.Schemata479.ReplaceBinExprOp_1(422L, () => MutateCSharp.Schemata479.ReplaceBinExprOp_3(420L, expr1.Name, expr2.Name), () => MutateCSharp.Schemata479.ReplaceBinExprOp_14(421L, expr1.CoCall, expr2.CoCall)), () => MutateCSharp.Schemata479.ReplaceBinExprOp_15(428L, expr1.Function, expr2.Function)); // TODO TypeArgumentSubstitutions?
        }

        private static bool ShallowEq(ApplyExpr expr1, ApplyExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(435L, true);
        }

        private static bool ShallowEq(SeqUpdateExpr expr1, SeqUpdateExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(436L, true);
        }

        private static bool ShallowEq(MultiSelectExpr expr1, MultiSelectExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(437L, true);
        }

        private static bool ShallowEq(SeqSelectExpr expr1, SeqSelectExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBinExprOp_1(456L, () => MutateCSharp.Schemata479.ReplaceBinExprOp_1(450L, () => MutateCSharp.Schemata479.ReplaceBinExprOp_1(444L, () => MutateCSharp.Schemata479.ReplaceBinExprOp_5(438L, () => expr1.SelectOne, () => expr2.SelectOne), () => TriggerUtils.SameNullity(expr1.Seq, expr2.Seq)), () => TriggerUtils.SameNullity(expr1.E0, expr2.E0)), () => TriggerUtils.SameNullity(expr1.E1, expr2.E1));
        }

        private static bool ShallowEq(MemberSelectExpr expr1, MemberSelectExpr expr2)
        {
            Func<Type, Type, bool> comparer = TypeEq;
            Func<Type, Type, bool> comparer1 = TypeEq;
            return MutateCSharp.Schemata479.ReplaceBinExprOp_1(476L, () => MutateCSharp.Schemata479.ReplaceBinExprOp_1(470L, () => MutateCSharp.Schemata479.ReplaceBinExprOp_1(464L, () => MutateCSharp.Schemata479.ReplaceBinExprOp_3(462L, expr1.MemberName, expr2.MemberName), () => MutateCSharp.Schemata479.ReplaceBinExprOp_16(463L, expr1.Member, expr2.Member)), () => expr1.TypeApplication_AtEnclosingClass.SequenceEqual(expr2.TypeApplication_AtEnclosingClass, new PredicateEqualityComparer<Type>(comparer))), () => expr1.TypeApplication_JustMember.SequenceEqual(expr2.TypeApplication_JustMember, new PredicateEqualityComparer<Type>(comparer1)));
        }

        internal static bool TypeEq(Type type1, Type type2)
        {
            return type1.Equals(type2);
        }

        private static bool ShallowEq(SeqDisplayExpr expr1, SeqDisplayExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(482L, true);
        }

        private static bool ShallowEq(MapDisplayExpr expr1, MapDisplayExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBinExprOp_5(483L, () => expr1.Finite, () => expr2.Finite);
        }

        private static bool ShallowEq(MultiSetDisplayExpr expr1, MultiSetDisplayExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(489L, true);
        }

        private static bool ShallowEq(SetDisplayExpr expr1, SetDisplayExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBinExprOp_5(490L, () => expr1.Finite, () => expr2.Finite);
        }

        private static bool ShallowEq(DisplayExpression expr1, DisplayExpression expr2)
        {
            if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(496L, () => expr1 is SeqDisplayExpr, () => expr2 is SeqDisplayExpr))
            {
                return ShallowEq((SeqDisplayExpr)expr1, (SeqDisplayExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(502L, () => expr1 is MultiSetDisplayExpr, () => expr2 is MultiSetDisplayExpr))
            {
                return ShallowEq((MultiSetDisplayExpr)expr1, (MultiSetDisplayExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(508L, () => expr1 is SetDisplayExpr, () => expr2 is SetDisplayExpr))
            {
                return ShallowEq((SetDisplayExpr)expr1, (SetDisplayExpr)expr2);
            }
            else
            {
                return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(514L, false);
            }

            return default;
        }

        private static bool ShallowEq(AutoGhostIdentifierExpr expr1, AutoGhostIdentifierExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(515L, true);
        }

        private static bool ShallowEq(IdentifierExpr expr1, IdentifierExpr expr2)
        {
            if (MutateCSharp.Schemata479.ReplaceBinExprOp_8(518L, () => MutateCSharp.Schemata479.ReplaceBinExprOp_17(516L, expr1.Name, expr2.Name), () => MutateCSharp.Schemata479.ReplaceBinExprOp_18(517L, expr1.Var, expr2.Var)))
            {
                return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(524L, false);
            }

            if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(525L, () => expr1 is AutoGhostIdentifierExpr, () => expr2 is AutoGhostIdentifierExpr))
            {
                return ShallowEq((AutoGhostIdentifierExpr)expr1, (AutoGhostIdentifierExpr)expr2);
            }
            else
            {
                return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(531L, true);
            }

            return default;
        }

        private static bool ShallowEq(ImplicitThisExpr expr1, ImplicitThisExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(532L, true);
        }

        private static bool ShallowEq(ThisExpr expr1, ThisExpr expr2)
        {
            if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(533L, () => expr1 is ImplicitThisExpr, () => expr2 is ImplicitThisExpr))
            {
                return ShallowEq((ImplicitThisExpr)expr1, (ImplicitThisExpr)expr2);
            }
            else
            {
                return (MutateCSharp.Schemata479.ReplaceBinExprOp_19(539L, expr1.GetType(), expr2.GetType())); // LiteralExpr is not abstract
            }

            return default;
        }

        private static bool ShallowEq(DatatypeValue expr1, DatatypeValue expr2)
        {
            Func<Type, Type, bool> comparer = TypeEq;
            return // Implied by Ctor equality: expr1.DatatypeName == expr2.DatatypeName &&
      MutateCSharp.Schemata479.ReplaceBinExprOp_1(541L, () => MutateCSharp.Schemata479.ReplaceBinExprOp_20(540L,
                   // Implied by Ctor equality: expr1.MemberName == expr2.MemberName &&
                   expr1.Ctor, expr2.Ctor), () =>
                   // Contextual information: expr1.IsCoCall == expr2.IsCoCall &&
                   expr1.InferredTypeArgs.SequenceEqual(expr2.InferredTypeArgs, new PredicateEqualityComparer<Type>(comparer)));
        }

        private static bool ShallowEq(StringLiteralExpr expr1, StringLiteralExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(547L, true);
        }

        private static bool ShallowEq(CharLiteralExpr expr1, CharLiteralExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(548L, true);
        }

        private static bool ShallowEq(StaticReceiverExpr expr1, StaticReceiverExpr expr2)
        {
            return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(549L, true);
        }

        private static bool ShallowEq(LiteralExpr expr1, LiteralExpr expr2)
        {
            if (MutateCSharp.Schemata479.ReplaceBinExprOp_8(556L, () => !TriggerUtils.SameNullity(expr1.Value, expr2.Value), () => (MutateCSharp.Schemata479.ReplaceBinExprOp_1(550L, () => expr1.Value != null, () => !expr1.Value.Equals(expr2.Value)))))
            {
                return MutateCSharp.Schemata479.ReplaceBooleanConstant_2(562L, false);
            }

            if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(563L, () => expr1 is StringLiteralExpr, () => expr2 is StringLiteralExpr))
            {
                return ShallowEq((StringLiteralExpr)expr1, (StringLiteralExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(569L, () => expr1 is CharLiteralExpr, () => expr2 is CharLiteralExpr))
            {
                return ShallowEq((CharLiteralExpr)expr1, (CharLiteralExpr)expr2);
            }
            else if (MutateCSharp.Schemata479.ReplaceBinExprOp_1(575L, () => expr1 is StaticReceiverExpr, () => expr2 is StaticReceiverExpr))
            {
                return ShallowEq((StaticReceiverExpr)expr1, (StaticReceiverExpr)expr2);
            }
            else
            {
                return (MutateCSharp.Schemata479.ReplaceBinExprOp_19(581L, expr1.GetType(), expr2.GetType())); // LiteralExpr is not abstract
            }

            return default;
        }
    }
}
