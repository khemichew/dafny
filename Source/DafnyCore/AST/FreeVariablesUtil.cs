using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata84
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT84");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.OldExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.Label argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.Function argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.UnaryOpExpr.Opcode argument1, Microsoft.Dafny.UnaryOpExpr.Opcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_10(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.ExtendedPattern> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.Label argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() | argument2();
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.IVariable argument1, Microsoft.Dafny.IVariable argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public static class FreeVariablesUtil
    {
        /// <summary>
        /// Returns true iff
        ///   (if 'v' is non-null) 'v' occurs as a free variable in 'expr' or
        ///   (if 'lookForReceiver' is true) 'this' occurs in 'expr'.
        /// </summary>
        public static bool ContainsFreeVariable(Expression expr, bool lookForReceiver, IVariable v)
        {
            Contract.Requires(expr != null);
            Contract.Requires(lookForReceiver || v != null);

            if (expr is ThisExpr)
            {
                return lookForReceiver;
            }
            else if (expr is IdentifierExpr)
            {
                IdentifierExpr e = (IdentifierExpr)expr;
                return MutateCSharp.Schemata84.ReplaceBinExprOp_0(1L, e.Var, v);
            }
            else
            {
                return Contract.Exists(expr.SubExpressions, ee => ContainsFreeVariable(ee, lookForReceiver, v));
            }

            return default;
        }

        public static ISet<IVariable> ComputeFreeVariables(DafnyOptions options, Expression expr)
        {
            Contract.Requires(expr != null);
            ISet<IVariable> fvs = new HashSet<IVariable>();
            ComputeFreeVariables(options, expr, fvs);
            return fvs;
        }
        public static void ComputeFreeVariables(DafnyOptions options, Expression expr, ISet<IVariable> fvs)
        {
            Contract.Requires(expr != null);
            Contract.Requires(fvs != null);
            bool dontCare0 = MutateCSharp.Schemata84.ReplaceBooleanConstant_1(2L, false), dontCare1 = MutateCSharp.Schemata84.ReplaceBooleanConstant_1(3L, false);
            Type dontCareT = null;
            var dontCareHeapAt = new HashSet<Label>();
            ComputeFreeVariables(options, expr, fvs, ref dontCare0, ref dontCare1, dontCareHeapAt, ref dontCareT, MutateCSharp.Schemata84.ReplaceBooleanConstant_1(4L, false));
        }
        public static void ComputeFreeVariables(DafnyOptions options, Expression expr, ISet<IVariable> fvs, ref bool usesHeap, bool includeStatements = false)
        {
            Contract.Requires(expr != null);
            Contract.Requires(fvs != null);
            bool dontCare1 = MutateCSharp.Schemata84.ReplaceBooleanConstant_1(5L, false);
            Type dontCareT = null;
            var dontCareHeapAt = new HashSet<Label>();
            ComputeFreeVariables(options, expr, fvs, ref usesHeap, ref dontCare1, dontCareHeapAt, ref dontCareT, includeStatements);
        }
        public static void ComputeFreeVariables(DafnyOptions options, Expression expr,
          ISet<IVariable> fvs,
          ref bool usesHeap, ref bool usesOldHeap, ISet<Label> freeHeapAtVariables, ref Type usesThis,
          bool includeStatements)
        {
            Contract.Requires(expr != null);

            if (expr is ThisExpr)
            {
                Contract.Assert(expr.Type != null);
                usesThis = expr.Type;
                return;
            }
            else if (expr is IdentifierExpr)
            {
                var e = (IdentifierExpr)expr;
                fvs.Add(e.Var);
                return;
            }
            else if (expr is MemberSelectExpr)
            {
                var e = (MemberSelectExpr)expr;
                if (e.Member is not Field { IsMutable: false })
                {
                    usesHeap = MutateCSharp.Schemata84.ReplaceBooleanConstant_1(6L, true);
                }
                if (MutateCSharp.Schemata84.ReplaceBinExprOp_2(7L, e.AtLabel, null))
                {
                    freeHeapAtVariables.Add(e.AtLabel);
                }
            }
            else if (expr is SeqSelectExpr)
            {
                var e = (SeqSelectExpr)expr;
                if (e.Seq.Type.IsArrayType)
                {
                    usesHeap = MutateCSharp.Schemata84.ReplaceBooleanConstant_1(8L, true);
                }
            }
            else if (expr is SeqUpdateExpr)
            {
                var e = (SeqUpdateExpr)expr;
                if (e.Seq.Type.IsArrayType)
                {
                    usesHeap = MutateCSharp.Schemata84.ReplaceBooleanConstant_1(9L, true);
                }
            }
            else if (expr is MultiSelectExpr)
            {
                usesHeap = MutateCSharp.Schemata84.ReplaceBooleanConstant_1(10L, true);
            }
            else if (expr is FunctionCallExpr)
            {
                var e = (FunctionCallExpr)expr;
                if (MutateCSharp.Schemata84.ReplaceBinExprOp_4(12L, () => MutateCSharp.Schemata84.ReplaceBinExprOp_3(11L, e.Function, null), () => e.Function.ReadsHeap))
                {
                    usesHeap = MutateCSharp.Schemata84.ReplaceBooleanConstant_1(18L, true);
                }
                if (MutateCSharp.Schemata84.ReplaceBinExprOp_2(19L, e.AtLabel, null))
                {
                    freeHeapAtVariables.Add(e.AtLabel);
                }
            }
            else if (expr is UnchangedExpr)
            {
                var e = (UnchangedExpr)expr;
                // Note, we don't have to look out for const fields here, because const fields
                // are not allowed in unchanged expressions.
                usesHeap = MutateCSharp.Schemata84.ReplaceBooleanConstant_1(20L, true);
                if (MutateCSharp.Schemata84.ReplaceBinExprOp_5(21L, e.AtLabel, null))
                {
                    usesOldHeap = MutateCSharp.Schemata84.ReplaceBooleanConstant_1(22L, true);
                }
                else
                {
                    freeHeapAtVariables.Add(e.AtLabel);
                }
            }
            else if (expr is ApplyExpr)
            {
                usesHeap = MutateCSharp.Schemata84.ReplaceBooleanConstant_1(23L, true); // because the translation of an ApplyExpr always throws in the heap variable
            }
            else if (expr is UnaryOpExpr)
            {
                var e = (UnaryOpExpr)expr;
                if (MutateCSharp.Schemata84.ReplaceBinExprOp_6(24L, e.Op, UnaryOpExpr.Opcode.Fresh))
                {
                    var f = (FreshExpr)e;
                    if (MutateCSharp.Schemata84.ReplaceBinExprOp_5(25L, f.AtLabel, null))
                    {
                        usesOldHeap = MutateCSharp.Schemata84.ReplaceBooleanConstant_1(26L, true);
                    }
                    else
                    {
                        freeHeapAtVariables.Add(f.AtLabel);
                    }
                }
                else if (MutateCSharp.Schemata84.ReplaceBinExprOp_6(27L, e.Op, UnaryOpExpr.Opcode.Allocated))
                {
                    usesHeap = MutateCSharp.Schemata84.ReplaceBooleanConstant_1(28L, true);
                }
            }

            // visit subexpressions
            bool uHeap = MutateCSharp.Schemata84.ReplaceBooleanConstant_1(29L, false), uOldHeap = MutateCSharp.Schemata84.ReplaceBooleanConstant_1(30L, false);
            Type uThis = null;
            if (expr is StmtExpr stmtExpr && includeStatements)
            {
                foreach (var subExpression in stmtExpr.S.SubExpressionsIncludingTransitiveSubStatements)
                {
                    ComputeFreeVariables(options, subExpression, fvs, ref uHeap, ref uOldHeap, freeHeapAtVariables, ref uThis, includeStatements);
                }
            }
            foreach (var subExpression in expr.SubExpressions)
            {
                ComputeFreeVariables(options, subExpression, fvs, ref uHeap, ref uOldHeap, freeHeapAtVariables, ref uThis, includeStatements);
            }
            Contract.Assert(usesThis == null || uThis == null || usesThis.Equals(uThis));
            usesThis = usesThis ?? uThis;
            var asOldExpr = expr as OldExpr;
            if (MutateCSharp.Schemata84.ReplaceBinExprOp_8(33L, () => MutateCSharp.Schemata84.ReplaceBinExprOp_7(31L, asOldExpr, null), () => MutateCSharp.Schemata84.ReplaceBinExprOp_5(32L, asOldExpr.AtLabel, null)))
            {
                usesOldHeap |= MutateCSharp.Schemata84.ReplaceBinExprOp_9(39L, () => uHeap, () => uOldHeap);
            }
            else if (MutateCSharp.Schemata84.ReplaceBinExprOp_7(45L, asOldExpr, null))
            {
                if (uHeap)
                {  // if not, then there was no real point in using an "old" expression
                    freeHeapAtVariables.Add(asOldExpr.AtLabel);
                }
                usesOldHeap |= uOldHeap;
            }
            else
            {
                usesHeap |= uHeap;
                usesOldHeap |= uOldHeap;
            }

            if (expr is LetExpr)
            {
                var e = (LetExpr)expr;
                foreach (var v in e.BoundVars)
                {
                    fvs.Remove(v);
                }
            }
            else if (expr is ComprehensionExpr)
            {
                var e = (ComprehensionExpr)expr;
                foreach (var v in e.BoundVars)
                {
                    fvs.Remove(v);
                }
            }
            else if (expr is MatchExpr me)
            {
                foreach (var v in me.Cases.SelectMany(c => c.Arguments))
                {
                    fvs.Remove(v);
                }
            }
            else if (expr is NestedMatchExpr nestedMatchExpr)
            {
                foreach (var v in nestedMatchExpr.Cases.
                           SelectMany(c => c.Pat.DescendantsAndSelf).
                           OfType<IdPattern>().Where(id => MutateCSharp.Schemata84.ReplaceBinExprOp_10(46L, id.Arguments, null)).
                           Select(id => id.BoundVar))
                {
                    fvs.Remove(v);
                }
            }
        }
    }
}