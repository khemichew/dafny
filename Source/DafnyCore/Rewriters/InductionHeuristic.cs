using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata449
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT449");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_5(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.IVariable argument1, Microsoft.Dafny.IVariable argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceNumericConstant_0(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_9(long mutantId, ref int argument1)
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

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.FunctionCallExpr.CoCallResolution argument1, Microsoft.Dafny.FunctionCallExpr.CoCallResolution argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBinExprOp_2(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBooleanConstant_3(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public static class InductionHeuristic
    {

        /// <summary>
        /// Returns 'true' iff by looking at 'expr' the Induction Heuristic determines that induction should be applied to 'n'.
        /// More precisely:
        ///   DafnyInductionHeuristic      Return 'true'
        ///   -----------------------      -------------
        ///        0                       always
        ///        1    if 'n' occurs as   any subexpression (of 'expr')
        ///        2    if 'n' occurs as   any subexpression of          any index argument of an array/sequence select expression or any                       argument to a recursive function
        ///        3    if 'n' occurs as   a prominent subexpression of  any index argument of an array/sequence select expression or any                       argument to a recursive function
        ///        4    if 'n' occurs as   any subexpression of                                                                       any                       argument to a recursive function
        ///        5    if 'n' occurs as   a prominent subexpression of                                                               any                       argument to a recursive function
        ///        6    if 'n' occurs as   a prominent subexpression of                                                               any decreases-influencing argument to a recursive function
        /// </summary>
        public static bool VarOccursInArgumentToRecursiveFunction(DafnyOptions options, Expression expr, IVariable n)
        {
            switch (options.InductionHeuristic)
            {
                case 0:
                    return true;
                    break;
                case 1:
                    return FreeVariablesUtil.ContainsFreeVariable(expr, false, n);
                    break;
                default:
                    return VarOccursInArgumentToRecursiveFunction(options, expr, n, false);
                    break;
            }

            return default;
        }

        /// <summary>
        /// Worker routine for VarOccursInArgumentToRecursiveFunction(expr,n), where the additional parameter 'exprIsProminent' says whether or
        /// not 'expr' has prominent status in its context.
        /// DafnyInductionHeuristic cases 0 and 1 are assumed to be handled elsewhere (i.e., a precondition of this method is DafnyInductionHeuristic is at least 2).
        /// </summary>
        static bool VarOccursInArgumentToRecursiveFunction(DafnyOptions options, Expression expr, IVariable n, bool exprIsProminent)
        {
            Contract.Requires(expr != null);
            Contract.Requires(n != null);

            // The following variable is what gets passed down to recursive calls if the subexpression does not itself acquire prominent status.
            var subExprIsProminent = MutateCSharp.Schemata449.ReplaceBinExprOp_2(19L, () => MutateCSharp.Schemata449.ReplaceBinExprOp_1(5L, options.InductionHeuristic, MutateCSharp.Schemata449.ReplaceNumericConstant_0(1L, 2)), () => MutateCSharp.Schemata449.ReplaceBinExprOp_1(14L, options.InductionHeuristic, MutateCSharp.Schemata449.ReplaceNumericConstant_0(10L, 4))) ? /*once prominent, always prominent*/exprIsProminent : /*reset the prominent status*/MutateCSharp.Schemata449.ReplaceBooleanConstant_3(25L, false);

            if (expr is IdentifierExpr)
            {
                var e = (IdentifierExpr)expr;
                return MutateCSharp.Schemata449.ReplaceBinExprOp_5(27L, () => exprIsProminent, () => MutateCSharp.Schemata449.ReplaceBinExprOp_4(26L, e.Var, n));
            }
            else if (expr is SeqSelectExpr)
            {
                var e = (SeqSelectExpr)expr;
                var q = MutateCSharp.Schemata449.ReplaceBinExprOp_2(42L, () => MutateCSharp.Schemata449.ReplaceBinExprOp_6(37L, options.InductionHeuristic, MutateCSharp.Schemata449.ReplaceNumericConstant_0(33L, 4)), () => subExprIsProminent);
                return MutateCSharp.Schemata449.ReplaceBinExprOp_2(68L, () => MutateCSharp.Schemata449.ReplaceBinExprOp_2(55L, () => VarOccursInArgumentToRecursiveFunction(options, e.Seq, n, subExprIsProminent), () => (MutateCSharp.Schemata449.ReplaceBinExprOp_5(49L, () => MutateCSharp.Schemata449.ReplaceBinExprOp_7(48L, e.E0, null), () => VarOccursInArgumentToRecursiveFunction(options, e.E0, n, q)))), () => (MutateCSharp.Schemata449.ReplaceBinExprOp_5(62L, () => MutateCSharp.Schemata449.ReplaceBinExprOp_7(61L, e.E1, null), () => VarOccursInArgumentToRecursiveFunction(options, e.E1, n, q))));    // ditto
            }
            else if (expr is MultiSelectExpr)
            {
                var e = (MultiSelectExpr)expr;
                var q = MutateCSharp.Schemata449.ReplaceBinExprOp_2(83L, () => MutateCSharp.Schemata449.ReplaceBinExprOp_6(78L, options.InductionHeuristic, MutateCSharp.Schemata449.ReplaceNumericConstant_0(74L, 4)), () => subExprIsProminent);
                return MutateCSharp.Schemata449.ReplaceBinExprOp_2(89L, () => VarOccursInArgumentToRecursiveFunction(options, e.Array, n, subExprIsProminent), () => e.Indices.Exists(exp => VarOccursInArgumentToRecursiveFunction(options, exp, n, q)));
            }
            else if (expr is FunctionCallExpr)
            {
                var e = (FunctionCallExpr)expr;
                // For recursive functions:  arguments are "prominent"
                // For non-recursive function:  arguments are "prominent" if the call is
                var rec = MutateCSharp.Schemata449.ReplaceBinExprOp_5(96L, () => e.Function.IsRecursive, () => MutateCSharp.Schemata449.ReplaceBinExprOp_8(95L, e.CoCall, FunctionCallExpr.CoCallResolution.Yes));
                var decr = e.Function.Decreases.Expressions;
                bool variantArgument;
                if (MutateCSharp.Schemata449.ReplaceBinExprOp_6(106L, options.InductionHeuristic, MutateCSharp.Schemata449.ReplaceNumericConstant_0(102L, 6)))
                {
                    variantArgument = rec;
                }
                else
                {
                    // The receiver is considered to be "variant" if the function is recursive and the receiver participates
                    // in the effective decreases clause of the function.  The receiver participates if it's a free variable
                    // of a term in the explicit decreases clause.
                    variantArgument = MutateCSharp.Schemata449.ReplaceBinExprOp_5(112L, () => rec, () => decr.Exists(ee => FreeVariablesUtil.ContainsFreeVariable(ee, MutateCSharp.Schemata449.ReplaceBooleanConstant_3(111L, true), null)));
                }
                if (VarOccursInArgumentToRecursiveFunction(options, e.Receiver, n, MutateCSharp.Schemata449.ReplaceBinExprOp_2(118L, () => variantArgument, () => subExprIsProminent)))
                {
                    return MutateCSharp.Schemata449.ReplaceBooleanConstant_3(124L, true);
                }
                Contract.Assert(e.Function.Ins.Count == e.Args.Count);
                for (int i = MutateCSharp.Schemata449.ReplaceNumericConstant_0(125L, 0); MutateCSharp.Schemata449.ReplaceBinExprOp_6(129L, i, e.Function.Ins.Count); MutateCSharp.Schemata449.ReplacePostfixUnaryExprOp_9(134L, ref i))
                {
                    var f = e.Function.Ins[i];
                    var exp = e.Args[i];
                    if (MutateCSharp.Schemata449.ReplaceBinExprOp_6(139L, options.InductionHeuristic, MutateCSharp.Schemata449.ReplaceNumericConstant_0(135L, 6)))
                    {
                        variantArgument = rec;
                    }
                    else if (rec)
                    {
                        // The argument position is considered to be "variant" if the function is recursive and...
                        // ... it has something to do with why the callee is well-founded, which happens when...
                        if (f is ImplicitFormal)
                        {
                            // ... it is the argument is the implicit _k parameter, which is always first in the effective decreases clause of a prefix lemma, or
                            variantArgument = MutateCSharp.Schemata449.ReplaceBooleanConstant_3(144L, true);
                        }
                        else if (decr.Exists(ee => FreeVariablesUtil.ContainsFreeVariable(ee, MutateCSharp.Schemata449.ReplaceBooleanConstant_3(145L, false), f)))
                        {
                            // ... it participates in the effective decreases clause of the function, which happens when it is
                            // a free variable of a term in the explicit decreases clause, or
                            variantArgument = MutateCSharp.Schemata449.ReplaceBooleanConstant_3(146L, true);
                        }
                        else
                        {
                            // ... the callee is a prefix predicate.
                            variantArgument = MutateCSharp.Schemata449.ReplaceBooleanConstant_3(147L, true);
                        }
                    }
                    if (VarOccursInArgumentToRecursiveFunction(options, exp, n, MutateCSharp.Schemata449.ReplaceBinExprOp_2(148L, () => variantArgument, () => subExprIsProminent)))
                    {
                        return MutateCSharp.Schemata449.ReplaceBooleanConstant_3(154L, true);
                    }
                }
                return MutateCSharp.Schemata449.ReplaceBooleanConstant_3(155L, false);
            }
            else if (expr is TernaryExpr)
            {
                var e = (TernaryExpr)expr;
                switch (e.Op)
                {
                    case TernaryExpr.Opcode.PrefixEqOp:
                    case TernaryExpr.Opcode.PrefixNeqOp:
                        return VarOccursInArgumentToRecursiveFunction(options, e.E0, n, true) ||
                          VarOccursInArgumentToRecursiveFunction(options, e.E1, n, subExprIsProminent) ||
                          VarOccursInArgumentToRecursiveFunction(options, e.E2, n, subExprIsProminent);
                        break;
                    default:
                        Contract.Assert(false); throw new cce.UnreachableException();  // unexpected ternary expression
                        break;
                }
            }
            else if (expr is DatatypeValue)
            {
                var e = (DatatypeValue)expr;
                var q = n.Type.IsDatatype ? exprIsProminent : subExprIsProminent;  // prominent status continues, if we're looking for a variable whose type is a datatype
                return e.Arguments.Exists(exp => VarOccursInArgumentToRecursiveFunction(options, exp, n, q));
            }
            else if (expr is UnaryExpr)
            {
                var e = (UnaryExpr)expr;
                // both Not and SeqLength preserve prominence
                return VarOccursInArgumentToRecursiveFunction(options, e.E, n, exprIsProminent);
            }
            else if (expr is BinaryExpr)
            {
                var e = (BinaryExpr)expr;
                bool q;
                switch (e.ResolvedOp)
                {
                    case BinaryExpr.ResolvedOpcode.Add:
                    case BinaryExpr.ResolvedOpcode.Sub:
                    case BinaryExpr.ResolvedOpcode.Mul:
                    case BinaryExpr.ResolvedOpcode.Div:
                    case BinaryExpr.ResolvedOpcode.Mod:
                    case BinaryExpr.ResolvedOpcode.LeftShift:
                    case BinaryExpr.ResolvedOpcode.RightShift:
                    case BinaryExpr.ResolvedOpcode.BitwiseAnd:
                    case BinaryExpr.ResolvedOpcode.BitwiseOr:
                    case BinaryExpr.ResolvedOpcode.BitwiseXor:
                    case BinaryExpr.ResolvedOpcode.Union:
                    case BinaryExpr.ResolvedOpcode.Intersection:
                    case BinaryExpr.ResolvedOpcode.SetDifference:
                    case BinaryExpr.ResolvedOpcode.Concat:
                        // these operators preserve prominence
                        q = exprIsProminent;
                        break;
                        break;
                    default:
                        // whereas all other binary operators do not
                        q = subExprIsProminent;
                        break;
                        break;
                }
                return MutateCSharp.Schemata449.ReplaceBinExprOp_2(156L, () => VarOccursInArgumentToRecursiveFunction(options, e.E0, n, q), () => VarOccursInArgumentToRecursiveFunction(options, e.E1, n, q));
            }
            else if (expr is StmtExpr)
            {
                var e = (StmtExpr)expr;
                // ignore the statement
                return VarOccursInArgumentToRecursiveFunction(options, e.E, n);

            }
            else if (expr is ITEExpr)
            {
                var e = (ITEExpr)expr;
                return MutateCSharp.Schemata449.ReplaceBinExprOp_2(168L, () => MutateCSharp.Schemata449.ReplaceBinExprOp_2(162L, () => VarOccursInArgumentToRecursiveFunction(options, e.Test, n, subExprIsProminent), () => VarOccursInArgumentToRecursiveFunction(options, e.Thn, n, exprIsProminent)), () => VarOccursInArgumentToRecursiveFunction(options, e.Els, n, exprIsProminent));
            }
            else if (MutateCSharp.Schemata449.ReplaceBinExprOp_2(186L, () => MutateCSharp.Schemata449.ReplaceBinExprOp_2(180L, () => MutateCSharp.Schemata449.ReplaceBinExprOp_2(174L, () => expr is OldExpr, () => expr is ConcreteSyntaxExpression), () => expr is BoxingCastExpr), () => expr is UnboxingCastExpr))
            {
                foreach (var exp in expr.SubExpressions)
                {
                    if (VarOccursInArgumentToRecursiveFunction(options, exp, n, exprIsProminent))
                    {  // maintain prominence
                        return MutateCSharp.Schemata449.ReplaceBooleanConstant_3(192L, true);
                    }
                }
                return MutateCSharp.Schemata449.ReplaceBooleanConstant_3(193L, false);
            }
            else
            {
                // in all other cases, reset the prominence status and recurse on the subexpressions
                foreach (var exp in expr.SubExpressions)
                {
                    if (VarOccursInArgumentToRecursiveFunction(options, exp, n, subExprIsProminent))
                    {
                        return MutateCSharp.Schemata449.ReplaceBooleanConstant_3(194L, true);
                    }
                }
                return MutateCSharp.Schemata449.ReplaceBooleanConstant_3(195L, false);
            }

            return default;
        }
    }
}