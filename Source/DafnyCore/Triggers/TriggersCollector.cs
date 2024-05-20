// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Boogie;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata481
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT481");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceNumericConstant_9(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.Triggers.TriggerAnnotation argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.CollectionType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.BinaryExpr.Opcode argument1, Microsoft.Dafny.BinaryExpr.Opcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.IVariable argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.BoundVar argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.Expression argument1, Microsoft.Dafny.Expression argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.UnaryOpExpr.Opcode argument1, Microsoft.Dafny.UnaryOpExpr.Opcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument1, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument1, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny.Triggers
{
    public class TriggersCollector
    {
        public ModuleDefinition ForModule { get; }

        private readonly DafnyOptions options;
        private readonly TriggerAnnotationsCache cache;

        internal TriggersCollector(Dictionary<Expression, HashSet<OldExpr>> exprsInOldContext, DafnyOptions options, ModuleDefinition forModule)
        {
            this.options = options;
            this.ForModule = forModule;
            this.cache = new TriggerAnnotationsCache(exprsInOldContext);
        }

        private T ReduceAnnotatedSubExpressions<T>(Expression expr, T seed, Func<TriggerAnnotation, T> map, Func<T, T, T> reduce)
        {
            return expr.SubExpressions.Select(e => map(Annotate(e)))
              .Aggregate(seed, (acc, e) => reduce(acc, e));
        }

        private List<TriggerTerm> CollectExportedCandidates(Expression expr)
        {
            return ReduceAnnotatedSubExpressions(expr, new List<TriggerTerm>(), a => a.ExportedTerms, TriggerUtils.MergeAlterFirst);
        }

        private ISet<IVariable> CollectVariables(Expression expr)
        {
            return ReduceAnnotatedSubExpressions<ISet<IVariable>>(expr, new HashSet<IVariable>(), a => a.Variables, TriggerUtils.MergeAlterFirst);
        }

        private bool CollectIsKiller(Expression expr)
        {
            return ReduceAnnotatedSubExpressions(expr, MutateCSharp.Schemata481.ReplaceBooleanConstant_0(1L, false), a => a.IsTriggerKiller, (a, b) => MutateCSharp.Schemata481.ReplaceBinExprOp_1(2L, () => a, () => b));
        }

        private IEnumerable<TriggerTerm> OnlyPrivateCandidates(List<TriggerTerm> terms, IEnumerable<IVariable> privateVars)
        {
            return terms.Where(c => privateVars.Intersect(c.Variables).Any()); //TODO Check perf
        }

        private TriggerAnnotation Annotate(Expression expr)
        {
            if (cache.Annotations.TryGetValue(expr, out var cached))
            {
                return cached;
            }

            TriggerAnnotation annotation = null; // TODO: Using ApplySuffix fixes the unresolved members problem in GenericSort

            if (expr is LetExpr)
            {
                var le = (LetExpr)expr;
                if (MutateCSharp.Schemata481.ReplaceBinExprOp_3(9L, () => le.LHSs.All(p => MutateCSharp.Schemata481.ReplaceBinExprOp_2(8L, p.Var, null)), () => le.Exact))
                {
                    // Inline the let expression before doing trigger selection.
                    annotation = Annotate(BoogieGenerator.InlineLet(le));
                }
            }

            if (MutateCSharp.Schemata481.ReplaceBinExprOp_4(15L, annotation, null))
            {
                expr.SubExpressions.ForEach(e => Annotate(e));

                if (IsPotentialTriggerCandidate(expr))
                {
                    annotation = AnnotatePotentialCandidate(expr);
                }
                else if (expr is QuantifierExpr)
                {
                    annotation = AnnotateQuantifier((QuantifierExpr)expr);
                }
                else if (expr is LetExpr)
                {
                    annotation = AnnotateLetExpr((LetExpr)expr);
                }
                else if (expr is IdentifierExpr)
                {
                    annotation = AnnotateIdentifier((IdentifierExpr)expr);
                }
                else if (expr is ApplySuffix)
                {
                    annotation = AnnotateApplySuffix((ApplySuffix)expr);
                }
                else if (expr is MatchExpr)
                {
                    annotation = AnnotateMatchExpr((MatchExpr)expr);
                }
                else if (expr is NestedMatchExpr nestedMatchExpr)
                {
                    annotation = AnnotateNestedMatchExpr(nestedMatchExpr);
                }
                else if (expr is ComprehensionExpr)
                {
                    annotation = AnnotateComprehensionExpr((ComprehensionExpr)expr);
                }
                else if (MutateCSharp.Schemata481.ReplaceBinExprOp_1(40L, () => MutateCSharp.Schemata481.ReplaceBinExprOp_1(34L, () => MutateCSharp.Schemata481.ReplaceBinExprOp_1(28L, () => MutateCSharp.Schemata481.ReplaceBinExprOp_1(22L, () => MutateCSharp.Schemata481.ReplaceBinExprOp_1(16L, () => expr is ConcreteSyntaxExpression, () => expr is LiteralExpr), () => expr is ThisExpr), () => expr is BoxingCastExpr), () => expr is MultiSetFormingExpr), () => expr is SeqConstructionExpr))
                {
                    annotation = AnnotateOther(expr, MutateCSharp.Schemata481.ReplaceBooleanConstant_0(46L, false));
                }
                else
                {
                    annotation = AnnotateOther(expr, MutateCSharp.Schemata481.ReplaceBooleanConstant_0(47L, true));
                }
            }

            cache.Annotations[expr] = annotation;
            return annotation;
        }

        public bool IsPotentialTriggerCandidate(Expression expr)
        {
            if (MutateCSharp.Schemata481.ReplaceBinExprOp_1(96L, () => MutateCSharp.Schemata481.ReplaceBinExprOp_1(90L, () => MutateCSharp.Schemata481.ReplaceBinExprOp_1(84L, () => MutateCSharp.Schemata481.ReplaceBinExprOp_1(78L, () => MutateCSharp.Schemata481.ReplaceBinExprOp_1(72L, () => MutateCSharp.Schemata481.ReplaceBinExprOp_1(66L, () => MutateCSharp.Schemata481.ReplaceBinExprOp_1(60L, () => MutateCSharp.Schemata481.ReplaceBinExprOp_1(54L, () => MutateCSharp.Schemata481.ReplaceBinExprOp_1(48L, () => expr is FunctionCallExpr, () => expr is SeqSelectExpr), () => expr is MultiSelectExpr), () => expr is MemberSelectExpr), () => (expr is OldExpr { Useless: false })), () => expr is ApplyExpr), () => expr is DisplayExpression), () => expr is MapDisplayExpr), () => expr is DatatypeValue), () => TranslateToFunctionCall(expr)))
            {
                return MutateCSharp.Schemata481.ReplaceBooleanConstant_0(102L, true);
            }
            else if (expr is BinaryExpr)
            {
                var e = (BinaryExpr)expr;
                if (MutateCSharp.Schemata481.ReplaceBinExprOp_3(112L, () => (MutateCSharp.Schemata481.ReplaceBinExprOp_1(105L, () => MutateCSharp.Schemata481.ReplaceBinExprOp_5(103L, e.Op, BinaryExpr.Opcode.NotIn), () => MutateCSharp.Schemata481.ReplaceBinExprOp_5(104L, e.Op, BinaryExpr.Opcode.In))), () => !BoogieGenerator.ExpressionTranslator.RewriteInExpr(e.E1, MutateCSharp.Schemata481.ReplaceBooleanConstant_0(111L, false))))
                {
                    return MutateCSharp.Schemata481.ReplaceBooleanConstant_0(118L, true);
                }
                else if (CandidateCollectionOperation(e))
                {
                    return MutateCSharp.Schemata481.ReplaceBooleanConstant_0(119L, true);
                }
                else if (MutateCSharp.Schemata481.ReplaceBinExprOp_3(135L, () => e.E0.Type.IsBigOrdinalType, () => (MutateCSharp.Schemata481.ReplaceBinExprOp_1(129L, () => MutateCSharp.Schemata481.ReplaceBinExprOp_1(122L, () => MutateCSharp.Schemata481.ReplaceBinExprOp_6(120L, e.ResolvedOp, BinaryExpr.ResolvedOpcode.Lt), () => MutateCSharp.Schemata481.ReplaceBinExprOp_6(121L, e.ResolvedOp, BinaryExpr.ResolvedOpcode.LessThanLimit)), () => MutateCSharp.Schemata481.ReplaceBinExprOp_6(128L, e.ResolvedOp, BinaryExpr.ResolvedOpcode.Gt)))))
                {
                    return MutateCSharp.Schemata481.ReplaceBooleanConstant_0(141L, true);
                }
                else
                {
                    return MutateCSharp.Schemata481.ReplaceBooleanConstant_0(142L, false);
                }
            }
            else if (expr is UnaryOpExpr)
            {
                var e = (UnaryOpExpr)expr;
                return MutateCSharp.Schemata481.ReplaceBinExprOp_7(143L, e.Op, UnaryOpExpr.Opcode.Cardinality);  // FIXME || e.Op == UnaryOpExpr.Opcode.Fresh doesn't work, as fresh is a pretty tricky predicate when it's not about datatypes. See translator.cs:10944
            }
            else if (expr is ConversionExpr)
            {
                var e = (ConversionExpr)expr;
                return e.ToType.IsBigOrdinalType;
            }
            else
            {
                return MutateCSharp.Schemata481.ReplaceBooleanConstant_0(144L, false);
            }

            return default;
        }

        // math operations can be turned into a Boogie-level function as in the
        // case with /noNLarith.
        public bool TranslateToFunctionCall(Expression expr)
        {
            if (!(expr is BinaryExpr))
            {
                return MutateCSharp.Schemata481.ReplaceBooleanConstant_0(145L, false);
            }
            BinaryExpr e = (BinaryExpr)expr;
            bool isReal = e.E0.Type.IsNumericBased(Type.NumericPersuasion.Real);
            var disableNonLinearArithmetic = BoogieGenerator.DetermineDisableNonLinearArithmetic(ForModule, options);
            switch (e.ResolvedOp)
            {
                case BinaryExpr.ResolvedOpcode.Lt:
                case BinaryExpr.ResolvedOpcode.Le:
                case BinaryExpr.ResolvedOpcode.Ge:
                case BinaryExpr.ResolvedOpcode.Gt:
                case BinaryExpr.ResolvedOpcode.Add:
                case BinaryExpr.ResolvedOpcode.Sub:
                    if (!isReal && !e.E0.Type.IsBitVectorType && !e.E0.Type.IsBigOrdinalType && disableNonLinearArithmetic)
                    {
                        return true;
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Mul:
                case BinaryExpr.ResolvedOpcode.Div:
                case BinaryExpr.ResolvedOpcode.Mod:
                    if (!isReal && !e.E0.Type.IsBitVectorType && !e.E0.Type.IsBigOrdinalType)
                    {
                        if (disableNonLinearArithmetic || (options.ArithMode != 0 && options.ArithMode != 3))
                        {
                            return true;
                        }
                    }
                    break;
                    break;
            }
            return MutateCSharp.Schemata481.ReplaceBooleanConstant_0(146L, false);
        }

        static bool CandidateCollectionOperation(BinaryExpr binExpr)
        {
            Contract.Requires(binExpr != null);
            var type = binExpr.E0.Type.AsCollectionType;
            if (MutateCSharp.Schemata481.ReplaceBinExprOp_8(147L, type, null))
            {
                return MutateCSharp.Schemata481.ReplaceBooleanConstant_0(148L, false);
            }
            if (type is SetType)
            {
                switch (binExpr.ResolvedOp)
                {
                    case BinaryExpr.ResolvedOpcode.Union:
                    case BinaryExpr.ResolvedOpcode.Intersection:
                    case BinaryExpr.ResolvedOpcode.SetDifference:
                    case BinaryExpr.ResolvedOpcode.ProperSubset:
                    case BinaryExpr.ResolvedOpcode.Subset:
                    case BinaryExpr.ResolvedOpcode.Superset:
                    case BinaryExpr.ResolvedOpcode.ProperSuperset:
                        return true;
                        break;
                }
            }
            else if (type is MultiSetType)
            {
                switch (binExpr.ResolvedOp)
                {
                    case BinaryExpr.ResolvedOpcode.MultiSetUnion:
                    case BinaryExpr.ResolvedOpcode.MultiSetIntersection:
                    case BinaryExpr.ResolvedOpcode.MultiSetDifference:
                    case BinaryExpr.ResolvedOpcode.ProperMultiSubset:
                    case BinaryExpr.ResolvedOpcode.MultiSubset:
                    case BinaryExpr.ResolvedOpcode.MultiSuperset:
                    case BinaryExpr.ResolvedOpcode.ProperMultiSuperset:
                        return true;
                        break;
                }
            }
            else if (type is SeqType)
            {
                switch (binExpr.ResolvedOp)
                {
                    case BinaryExpr.ResolvedOpcode.Concat:
                        return true;
                        break;
                }
            }
            else if (type is MapType)
            {
                switch (binExpr.ResolvedOp)
                {
                    case BinaryExpr.ResolvedOpcode.MapMerge:
                    case BinaryExpr.ResolvedOpcode.MapSubtraction:
                        return true;
                        break;
                }
            }
            return MutateCSharp.Schemata481.ReplaceBooleanConstant_0(149L, false);
        }

        private TriggerAnnotation AnnotatePotentialCandidate(Expression expr)
        {
            var oldExprSet = cache.ExpressionsInOldContext.GetValueOrDefault(expr);
            // oldExpr has been set to the value found
            var newExpressions = TriggerUtils.MaybeWrapInOld(PrepareExprForInclusionInTrigger(expr, out var exprIsKiller), oldExprSet);
            // We expect there to be at least one "newExpressions".
            // We also expect that the computation of new_term.Variables, collected_terms, and children_contain_killers will be the
            // same for each of the "new_exprs".
            // Therefore, we use the values of these variables from the last iteration in the expression that is ultimately returned.
            TriggerTerm newTerm = null;
            List<TriggerTerm> collectedTerms = null;
            var childrenContainKillers = MutateCSharp.Schemata481.ReplaceBooleanConstant_0(150L, false);
            foreach (var newExpression in newExpressions)
            {
                newTerm = new TriggerTerm { Expr = newExpression, OriginalExpr = expr, Variables = CollectVariables(expr) };

                collectedTerms = CollectExportedCandidates(expr);
                childrenContainKillers = CollectIsKiller(expr);

                if (!childrenContainKillers)
                {
                    // Add only if the children are not killers; the head has been cleaned up into non-killer form
                    collectedTerms.Add(newTerm);
                }
            }
            Contract.Assert(newTerm != null);  // this checks our assumption that "new_exprs" contains at least one value.

            // This new node is a killer if its children were killers, or if it's non-cleaned-up head is a killer
            return new TriggerAnnotation(MutateCSharp.Schemata481.ReplaceBinExprOp_1(151L, () => childrenContainKillers, () => exprIsKiller), newTerm.Variables, collectedTerms);
        }

        private TriggerAnnotation AnnotateApplySuffix(ApplySuffix expr)
        {
            // This is a bit tricky. A funcall node is generally meaningful as a trigger candidate,
            // but when it's part of an ApplySuffix the function call itself may not resolve properly
            // when the second round of resolving is done after modules are duplicated.
            // Thus first we annotate expr and create a trigger candidate, and then we remove the
            // candidate matching its direct subexpression if needed. Note that function calls are not the
            // only possible child here; there can be DatatypeValue nodes, for example (see vstte2012/Combinators.dfy).
            var annotation = AnnotatePotentialCandidate(expr);
            // Comparing by reference is fine here. Using sets could yield a small speedup
            annotation.ExportedTerms.RemoveAll(term => expr.SubExpressions.Contains(term.Expr));
            return annotation;
        }

        private TriggerAnnotation AnnotateQuantifierOrLetExpr(Expression expr, IEnumerable<BoundVar> boundVars)
        {
            var terms = CollectExportedCandidates(expr);
            return new TriggerAnnotation(MutateCSharp.Schemata481.ReplaceBooleanConstant_0(157L, true), CollectVariables(expr), terms, OnlyPrivateCandidates(terms, boundVars));
        }

        private TriggerAnnotation AnnotateQuantifier(QuantifierExpr expr)
        {
            return AnnotateQuantifierOrLetExpr(expr, expr.BoundVars);
        }

        private TriggerAnnotation AnnotateLetExpr(LetExpr expr)
        {
            return AnnotateQuantifierOrLetExpr(expr, expr.BoundVars);
        }

        private TriggerAnnotation AnnotateIdentifier(IdentifierExpr expr)
        {
            return new TriggerAnnotation(MutateCSharp.Schemata481.ReplaceBooleanConstant_0(158L, false), Enumerable.Repeat(expr.Var, MutateCSharp.Schemata481.ReplaceNumericConstant_9(159L, 1)), null);
        }

        private TriggerAnnotation AnnotateComprehensionExpr(ComprehensionExpr expr)
        {
            var terms = CollectExportedCandidates(expr);
            return new TriggerAnnotation(MutateCSharp.Schemata481.ReplaceBooleanConstant_0(163L, true), CollectVariables(expr), terms, OnlyPrivateCandidates(terms, expr.BoundVars));
        }

        private TriggerAnnotation AnnotateNestedMatchExpr(NestedMatchExpr expr)
        {
            var candidateTerms = CollectExportedCandidates(expr);
            // collects that argument boundvar of matchcaseexpr
            var variables = expr.Cases.SelectMany(e => e.Pat.DescendantsAndSelf).
              OfType<IdPattern>().Select(id => id.BoundVar).Where(b => MutateCSharp.Schemata481.ReplaceBinExprOp_10(164L, b, null)).ToList();
            // remove terms that mentions argument boundvar of matchcaseexpr
            var terms = candidateTerms.Where(term => variables.Any(x => !term.Variables.Contains(x))).ToList();
            return new TriggerAnnotation(MutateCSharp.Schemata481.ReplaceBooleanConstant_0(165L, true), CollectVariables(expr), terms);
        }

        private TriggerAnnotation AnnotateMatchExpr(MatchExpr expr)
        {
            var pts = CollectExportedCandidates(expr);
            // collects that argument boundvar of matchcaseexpr
            var variables = expr.Cases.Select(e => e.Arguments).
              Aggregate(new List<BoundVar>(), (acc, e) => TriggerUtils.MergeAlterFirst(acc, e));
            // remove terms that mentions argument boundvar of matchcaseexpr
            var terms = new List<TriggerTerm>();
            foreach (var term in pts)
            {
                if (!(variables.All(x => term.Variables.Contains(x))))
                {
                    terms.Add(term);
                }
            }
            return new TriggerAnnotation(MutateCSharp.Schemata481.ReplaceBooleanConstant_0(166L, true), CollectVariables(expr), terms);
        }

        private TriggerAnnotation AnnotateOther(Expression expr, bool isTriggerKiller)
        {
            return new TriggerAnnotation(MutateCSharp.Schemata481.ReplaceBinExprOp_1(167L, () => isTriggerKiller, () => CollectIsKiller(expr)), CollectVariables(expr), CollectExportedCandidates(expr));
        }

        /// <summary>
        /// Collect terms in the body of the subexpressions of the argument that look like quantifiers. The results of this function can contain duplicate terms.
        /// </summary>
        internal List<TriggerTerm> CollectTriggers(ComprehensionExpr quantifier)
        {
            Contract.Requires(!(quantifier is QuantifierExpr) || ((QuantifierExpr)quantifier).SplitQuantifier == null); // Don't call this on a quantifier with a Split clause: it's not a real quantifier
                                                                                                                        // NOTE: We could check for existing trigger attributes and return that instead
            return Annotate(quantifier).PrivateTerms;
        }

        internal bool IsTriggerKiller(Expression expr)
        {
            return Annotate(expr).IsTriggerKiller;
        }

        internal static Expression PrepareExprForInclusionInTrigger(Expression expr)
        {
            return PrepareExprForInclusionInTrigger(expr, out var @_);
        }

        private static Expression PrepareExprForInclusionInTrigger(Expression expr, out bool isKiller)
        {
            isKiller = MutateCSharp.Schemata481.ReplaceBooleanConstant_0(173L, false);

            Expression ret;
            do
            {
                ret = expr;
                if (expr is BinaryExpr bin)
                {
                    if (MutateCSharp.Schemata481.ReplaceBinExprOp_5(174L, bin.Op, BinaryExpr.Opcode.NotIn))
                    {
                        expr = new BinaryExpr(bin.tok, BinaryExpr.Opcode.In, bin.E0, bin.E1)
                        {
                            ResolvedOp = RemoveNotInBinaryExprIn(bin.ResolvedOp),
                            Type = bin.Type
                        };
                    }
                    else if (MutateCSharp.Schemata481.ReplaceBinExprOp_6(175L, bin.ResolvedOp, BinaryExpr.ResolvedOpcode.InMultiSet))
                    {
                        expr = new SeqSelectExpr(bin.tok, MutateCSharp.Schemata481.ReplaceBooleanConstant_0(176L, true), bin.E1, bin.E0, null, null)
                        {
                            Type = bin.Type
                        };
                        isKiller = MutateCSharp.Schemata481.ReplaceBooleanConstant_0(177L, true); // [a in s] becomes [s[a] > 0], which is a trigger killer
                    }
                    else
                    {
                        var newOpcode = ChangeProperToInclusiveContainment(bin.ResolvedOp);
                        if (MutateCSharp.Schemata481.ReplaceBinExprOp_11(178L, newOpcode, bin.ResolvedOp))
                        {
                            // For sets, isets, and multisets, change < to <= in triggers (and analogously
                            // > to >=), since "a < b" translates as "a <= b && !(b <= a)" or
                            // "a <= b && !(a == b)".
                            expr = new BinaryExpr(bin.tok, BinaryExpr.ResolvedOp2SyntacticOp(newOpcode), bin.E0, bin.E1)
                            {
                                ResolvedOp = newOpcode,
                                Type = bin.Type
                            };
                        }
                    }
                }
            } while (MutateCSharp.Schemata481.ReplaceBinExprOp_12(179L, ret, expr));

            return ret;
        }
        private static BinaryExpr.ResolvedOpcode RemoveNotInBinaryExprIn(BinaryExpr.ResolvedOpcode opcode)
        {
            switch (opcode)
            {
                case BinaryExpr.ResolvedOpcode.NotInMap:
                    return BinaryExpr.ResolvedOpcode.InMap;
                    break;
                case BinaryExpr.ResolvedOpcode.NotInSet:
                    return BinaryExpr.ResolvedOpcode.InSet;
                    break;
                case BinaryExpr.ResolvedOpcode.NotInSeq:
                    return BinaryExpr.ResolvedOpcode.InSeq;
                    break;
                case BinaryExpr.ResolvedOpcode.NotInMultiSet:
                    return BinaryExpr.ResolvedOpcode.InMultiSet;
                    break;
            }

            Contract.Assert(false);
            throw new ArgumentException();
            return default;
        }

        private static BinaryExpr.ResolvedOpcode ChangeProperToInclusiveContainment(BinaryExpr.ResolvedOpcode opcode)
        {
            return opcode switch
            {
                BinaryExpr.ResolvedOpcode.ProperSubset => BinaryExpr.ResolvedOpcode.Subset,
                BinaryExpr.ResolvedOpcode.ProperMultiSubset => BinaryExpr.ResolvedOpcode.MultiSubset,
                BinaryExpr.ResolvedOpcode.ProperSuperset => BinaryExpr.ResolvedOpcode.Superset,
                BinaryExpr.ResolvedOpcode.ProperMultiSuperset => BinaryExpr.ResolvedOpcode.MultiSuperset,
                _ => opcode
            };
        }
    }
}