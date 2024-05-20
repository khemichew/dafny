using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using JetBrains.Annotations;
namespace MutateCSharp
{
    internal class Schemata148
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT148");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplacePostfixUnaryExprOp_14(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.CalcStmt.CalcOp argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.BinaryExpr.Opcode argument1, Microsoft.Dafny.BinaryExpr.Opcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_4(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
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

        internal static bool ReplaceBinExprOp_10(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.CalcStmt.CalcOp argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceBinExprOp_17(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 + argument2;
        }

        internal static int ReplaceNumericConstant_5(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static int ReplaceBinExprOp_11(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 - argument2;
        }

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.Expression argument1, Microsoft.Dafny.Expression argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
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

    }
}

namespace Microsoft.Dafny
{
    public class CalcStmt : Statement, ICloneable<CalcStmt>, ICanFormat
    {
        public abstract class CalcOp
        {
            /// <summary>
            /// Resulting operator "x op z" if "x this y" and "y other z".
            /// Returns null if this and other are incompatible.
            /// </summary>
            [System.Diagnostics.Contracts.Pure]
            public abstract CalcOp ResultOp(CalcOp other);

            /// <summary>
            /// Returns an expression "line0 this line1".
            /// </summary>
            [System.Diagnostics.Contracts.Pure]
            public abstract Expression StepExpr(Expression line0, Expression line1);
        }

        public class BinaryCalcOp : CalcOp
        {
            public readonly BinaryExpr.Opcode Op;

            [ContractInvariantMethod]
            void ObjectInvariant()
            {
                Contract.Invariant(ValidOp(Op));
            }

            /// <summary>
            /// Is op a valid calculation operator?
            /// </summary>
            [System.Diagnostics.Contracts.Pure]
            public static bool ValidOp(BinaryExpr.Opcode op)
            {
                return MutateCSharp.Schemata148.ReplaceBinExprOp_1(37L, () => MutateCSharp.Schemata148.ReplaceBinExprOp_1(31L, () => MutateCSharp.Schemata148.ReplaceBinExprOp_1(24L, () => MutateCSharp.Schemata148.ReplaceBinExprOp_1(17L, () => MutateCSharp.Schemata148.ReplaceBinExprOp_1(10L, () => MutateCSharp.Schemata148.ReplaceBinExprOp_1(3L, () => MutateCSharp.Schemata148.ReplaceBinExprOp_0(1L, op, BinaryExpr.Opcode.Eq), () => MutateCSharp.Schemata148.ReplaceBinExprOp_0(2L, op, BinaryExpr.Opcode.Neq
                       )), () => MutateCSharp.Schemata148.ReplaceBinExprOp_0(9L, op, BinaryExpr.Opcode.Lt)), () => MutateCSharp.Schemata148.ReplaceBinExprOp_0(16L, op, BinaryExpr.Opcode.Le
                       )), () => MutateCSharp.Schemata148.ReplaceBinExprOp_0(23L, op, BinaryExpr.Opcode.Gt)), () => MutateCSharp.Schemata148.ReplaceBinExprOp_0(30L, op, BinaryExpr.Opcode.Ge
                       )), () => LogicOp(op));
            }

            /// <summary>
            /// Is op a valid operator only for Boolean lines?
            /// </summary>
            [System.Diagnostics.Contracts.Pure]
            public static bool LogicOp(BinaryExpr.Opcode op)
            {
                return MutateCSharp.Schemata148.ReplaceBinExprOp_1(52L, () => MutateCSharp.Schemata148.ReplaceBinExprOp_1(45L, () => MutateCSharp.Schemata148.ReplaceBinExprOp_0(43L, op, BinaryExpr.Opcode.Iff), () => MutateCSharp.Schemata148.ReplaceBinExprOp_0(44L, op, BinaryExpr.Opcode.Imp)), () => MutateCSharp.Schemata148.ReplaceBinExprOp_0(51L, op, BinaryExpr.Opcode.Exp));
            }

            public BinaryCalcOp(BinaryExpr.Opcode op)
            {
                Contract.Requires(ValidOp(op));
                Op = op;
            }

            /// <summary>
            /// Does this subsume other (this . other == other . this == this)?
            /// </summary>
            private bool Subsumes(BinaryCalcOp other)
            {
                Contract.Requires(other != null);
                var op1 = Op;
                var op2 = other.Op;
                if (MutateCSharp.Schemata148.ReplaceBinExprOp_1(60L, () => MutateCSharp.Schemata148.ReplaceBinExprOp_0(58L, op1, BinaryExpr.Opcode.Neq), () => MutateCSharp.Schemata148.ReplaceBinExprOp_0(59L, op2, BinaryExpr.Opcode.Neq)))
                {
                    return MutateCSharp.Schemata148.ReplaceBinExprOp_0(66L, op2, BinaryExpr.Opcode.Eq);
                }

                if (MutateCSharp.Schemata148.ReplaceBinExprOp_0(67L, op1, op2))
                {
                    return MutateCSharp.Schemata148.ReplaceBooleanConstant_2(68L, true);
                }

                if (MutateCSharp.Schemata148.ReplaceBinExprOp_1(69L, () => LogicOp(op1), () => LogicOp(op2)))
                {
                    return MutateCSharp.Schemata148.ReplaceBinExprOp_1(112L, () => MutateCSharp.Schemata148.ReplaceBinExprOp_1(98L, () => MutateCSharp.Schemata148.ReplaceBinExprOp_1(84L, () => MutateCSharp.Schemata148.ReplaceBinExprOp_0(75L, op2, BinaryExpr.Opcode.Eq), () => (MutateCSharp.Schemata148.ReplaceBinExprOp_3(78L, () => MutateCSharp.Schemata148.ReplaceBinExprOp_0(76L, op1, BinaryExpr.Opcode.Imp), () => MutateCSharp.Schemata148.ReplaceBinExprOp_0(77L, op2, BinaryExpr.Opcode.Iff)))), () => (MutateCSharp.Schemata148.ReplaceBinExprOp_3(92L, () => MutateCSharp.Schemata148.ReplaceBinExprOp_0(90L, op1, BinaryExpr.Opcode.Exp), () => MutateCSharp.Schemata148.ReplaceBinExprOp_0(91L, op2, BinaryExpr.Opcode.Iff)))), () => (MutateCSharp.Schemata148.ReplaceBinExprOp_3(106L, () => MutateCSharp.Schemata148.ReplaceBinExprOp_0(104L, op1, BinaryExpr.Opcode.Eq), () => MutateCSharp.Schemata148.ReplaceBinExprOp_0(105L, op2, BinaryExpr.Opcode.Iff))));
                }

                return MutateCSharp.Schemata148.ReplaceBinExprOp_1(141L, () => MutateCSharp.Schemata148.ReplaceBinExprOp_1(127L, () => MutateCSharp.Schemata148.ReplaceBinExprOp_0(118L, op2, BinaryExpr.Opcode.Eq), () => (MutateCSharp.Schemata148.ReplaceBinExprOp_3(121L, () => MutateCSharp.Schemata148.ReplaceBinExprOp_0(119L, op1, BinaryExpr.Opcode.Lt), () => MutateCSharp.Schemata148.ReplaceBinExprOp_0(120L, op2, BinaryExpr.Opcode.Le)))), () => (MutateCSharp.Schemata148.ReplaceBinExprOp_3(135L, () => MutateCSharp.Schemata148.ReplaceBinExprOp_0(133L, op1, BinaryExpr.Opcode.Gt), () => MutateCSharp.Schemata148.ReplaceBinExprOp_0(134L, op2, BinaryExpr.Opcode.Ge))));
            }

            public override CalcOp ResultOp(CalcOp other)
            {
                if (other is BinaryCalcOp)
                {
                    var o = (BinaryCalcOp)other;
                    if (Subsumes(o))
                    {
                        return this;
                    }
                    else if (o.Subsumes(this))
                    {
                        return other;
                    }
                    return null;
                }
                else if (other is TernaryCalcOp)
                {
                    return other.ResultOp(this);
                }
                else
                {
                    Contract.Assert(false);
                    throw new cce.UnreachableException();
                }

                return default;
            }

            public override Expression StepExpr(Expression line0, Expression line1)
            {
                if (MutateCSharp.Schemata148.ReplaceBinExprOp_0(147L, Op, BinaryExpr.Opcode.Exp))
                {
                    // The order of operands is reversed so that it can be turned into implication during resolution
                    return new BinaryExpr(new AutoGeneratedToken(line0.tok), Op, line1, line0);
                }
                else
                {
                    return new BinaryExpr(new AutoGeneratedToken(line0.tok), Op, line0, line1);
                }

                return default;
            }

            public override string ToString()
            {
                return BinaryExpr.OpcodeString(Op);
            }

        }

        public class TernaryCalcOp : CalcOp
        {
            public readonly Expression Index; // the only allowed ternary operator is ==#, so we only store the index

            [ContractInvariantMethod]
            void ObjectInvariant()
            {
                Contract.Invariant(Index != null);
            }

            public TernaryCalcOp(Expression idx)
            {
                Contract.Requires(idx != null);
                Index = idx;
            }

            public override CalcOp ResultOp(CalcOp other)
            {
                if (other is BinaryCalcOp)
                {
                    if (MutateCSharp.Schemata148.ReplaceBinExprOp_0(148L, ((BinaryCalcOp)other).Op, BinaryExpr.Opcode.Eq))
                    {
                        return this;
                    }
                    return null;
                }
                else if (other is TernaryCalcOp)
                {
                    var a = Index;
                    var b = ((TernaryCalcOp)other).Index;
                    var minIndex = new ITEExpr(a.tok, MutateCSharp.Schemata148.ReplaceBooleanConstant_2(149L, false), new BinaryExpr(a.tok, BinaryExpr.Opcode.Le, a, b), a, b);
                    return new TernaryCalcOp(minIndex); // ToDo: if we could compare expressions for syntactic equality, we could use this here to optimize
                }
                else
                {
                    Contract.Assert(false);
                    throw new cce.UnreachableException();
                }

                return default;
            }

            public override Expression StepExpr(Expression line0, Expression line1)
            {
                return new TernaryExpr(new AutoGeneratedToken(line0.tok), TernaryExpr.Opcode.PrefixEqOp, Index, line0, line1);
            }

            public override string ToString()
            {
                return MutateCSharp.Schemata148.ReplaceStringConstant_4(150L, "==#");
            }

        }

        /// <summary>
        /// This method infers a default operator to be used between the steps.
        /// Usually, we'd use == as the default operator.  However, if the calculation
        /// begins or ends with a boolean literal, then we can do better by selecting ==>
        /// or <==.  Also, if the calculation begins or ends with an empty set, then we can
        /// do better by selecting <= or >=.
        /// Note, these alternative operators are chosen only if they don't clash with something
        /// supplied by the user.
        /// If the rules come up with a good inferred default operator, then that default operator
        /// is returned; otherwise, null is returned.
        /// </summary>
        [CanBeNull]
        public CalcOp GetInferredDefaultOp()
        {
            CalcOp alternativeOp = null;
            if (MutateCSharp.Schemata148.ReplaceBinExprOp_6(155L, Lines.Count, MutateCSharp.Schemata148.ReplaceNumericConstant_5(151L, 0)))
            {
                return null;
            }

            if (Expression.IsBoolLiteral(Lines.First(), out var firstOperatorIsBoolLiteral))
            {
                alternativeOp = new BinaryCalcOp(firstOperatorIsBoolLiteral ? BinaryExpr.Opcode.Imp : BinaryExpr.Opcode.Exp);
            }
            else if (Expression.IsBoolLiteral(Lines.Last(), out var lastOperatorIsBoolLiteral))
            {
                alternativeOp = new BinaryCalcOp(lastOperatorIsBoolLiteral ? BinaryExpr.Opcode.Exp : BinaryExpr.Opcode.Imp);
            }
            else if (Expression.IsEmptySetOrMultiset(Lines.First()))
            {
                alternativeOp = new BinaryCalcOp(BinaryExpr.Opcode.Ge);
            }
            else if (Expression.IsEmptySetOrMultiset(Lines.Last()))
            {
                alternativeOp = new BinaryCalcOp(BinaryExpr.Opcode.Le);
            }
            else
            {
                return null;
            }

            // Check that the alternative operator is compatible with anything supplied by the user.
            var resultOp = alternativeOp;
            foreach (var stepOp in StepOps.Where(stepOp => MutateCSharp.Schemata148.ReplaceBinExprOp_7(160L, stepOp, null)))
            {
                resultOp = resultOp.ResultOp(stepOp);
                if (MutateCSharp.Schemata148.ReplaceBinExprOp_8(161L, resultOp, null))
                {
                    // no go
                    return null;
                }
            }
            return alternativeOp;
        }

        public readonly List<Expression> Lines;    // Last line is dummy, in order to form a proper step with the dangling hint
        public readonly List<BlockStmt> Hints;     // Hints[i] comes after line i; block statement is used as a container for multiple sub-hints
        public readonly CalcOp UserSuppliedOp;     // may be null, if omitted by the user
        public readonly List<CalcOp/*?*/> StepOps; // StepOps[i] comes after line i
        [FilledInDuringResolution]
        public CalcOp Op;                          // main operator of the calculation (either UserSuppliedOp or (after resolution) an inferred CalcOp)
        [FilledInDuringResolution] public readonly List<Expression> Steps;    // expressions li op l<i + 1> (last step is dummy)
        [FilledInDuringResolution] public Expression Result;                  // expression l0 ResultOp ln

        public static readonly CalcOp DefaultOp = new BinaryCalcOp(BinaryExpr.Opcode.Eq);

        public override IEnumerable<INode> Children => Steps.Concat(MutateCSharp.Schemata148.ReplaceBinExprOp_9(162L, Result, null) ? new Node[] { Result } : new Node[] { }).Concat(Hints);
        public override IEnumerable<INode> PreResolveChildren => Lines.Take(MutateCSharp.Schemata148.ReplaceBinExprOp_10(167L, Lines.Count, MutateCSharp.Schemata148.ReplaceNumericConstant_5(163L, 0)) ? MutateCSharp.Schemata148.ReplaceBinExprOp_11(176L, Lines.Count, MutateCSharp.Schemata148.ReplaceNumericConstant_5(172L, 1)) : MutateCSharp.Schemata148.ReplaceNumericConstant_5(185L, 0)).Concat<Node>(Hints.Where(hintBatch => MutateCSharp.Schemata148.ReplaceBinExprOp_12(193L, hintBatch.Body.Count(), MutateCSharp.Schemata148.ReplaceNumericConstant_5(189L, 0))));

        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(Lines != null);
            Contract.Invariant(cce.NonNullElements(Lines));
            Contract.Invariant(Hints != null);
            Contract.Invariant(cce.NonNullElements(Hints));
            Contract.Invariant(StepOps != null);
            Contract.Invariant(Steps != null);
            Contract.Invariant(cce.NonNullElements(Steps));
            Contract.Invariant(Hints.Count == Math.Max(Lines.Count - 1, 0));
            Contract.Invariant(StepOps.Count == Hints.Count);
        }

        public CalcStmt(RangeToken rangeToken, CalcOp userSuppliedOp, List<Expression> lines, List<BlockStmt> hints, List<CalcOp/*?*/> stepOps, Attributes attrs)
          : base(rangeToken)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(lines != null);
            Contract.Requires(hints != null);
            Contract.Requires(stepOps != null);
            Contract.Requires(cce.NonNullElements(lines));
            Contract.Requires(cce.NonNullElements(hints));
            Contract.Requires(hints.Count == Math.Max(lines.Count - 1, 0));
            Contract.Requires(stepOps.Count == hints.Count);
            UserSuppliedOp = userSuppliedOp;
            Lines = lines;
            Hints = hints;
            Steps = new List<Expression>();
            StepOps = stepOps;
            Result = null;
            Attributes = attrs;
        }

        public CalcStmt Clone(Cloner cloner)
        {
            return new CalcStmt(cloner, this);
        }

        public CalcStmt(Cloner cloner, CalcStmt original) : base(cloner, original)
        {
            // calc statements have the unusual property that the last line is duplicated.  If that is the case (which
            // we expect it to be here), we share the clone of that line as well.
            var lineCount = original.Lines.Count;
            var lines = new List<Expression>(lineCount);
            for (int i = MutateCSharp.Schemata148.ReplaceNumericConstant_5(198L, 0); MutateCSharp.Schemata148.ReplaceBinExprOp_13(202L, i, lineCount); MutateCSharp.Schemata148.ReplacePostfixUnaryExprOp_14(207L, ref i))
            {
                lines.Add(MutateCSharp.Schemata148.ReplaceBinExprOp_3(255L, () => MutateCSharp.Schemata148.ReplaceBinExprOp_3(235L, () => MutateCSharp.Schemata148.ReplaceBinExprOp_6(221L, i, MutateCSharp.Schemata148.ReplaceBinExprOp_11(212L, lineCount, MutateCSharp.Schemata148.ReplaceNumericConstant_5(208L, 1))), () => MutateCSharp.Schemata148.ReplaceBinExprOp_15(230L, MutateCSharp.Schemata148.ReplaceNumericConstant_5(226L, 2), lineCount)), () => MutateCSharp.Schemata148.ReplaceBinExprOp_16(254L, original.Lines[i], original.Lines[MutateCSharp.Schemata148.ReplaceBinExprOp_11(245L, i, MutateCSharp.Schemata148.ReplaceNumericConstant_5(241L, 1))])) ? lines[MutateCSharp.Schemata148.ReplaceBinExprOp_11(265L, i, MutateCSharp.Schemata148.ReplaceNumericConstant_5(261L, 1))] : cloner.CloneExpr(original.Lines[i]));
            }
            UserSuppliedOp = cloner.CloneCalcOp(original.UserSuppliedOp);
            Lines = lines;
            StepOps = original.StepOps.ConvertAll(cloner.CloneCalcOp);
            Hints = original.Hints.ConvertAll(cloner.CloneBlockStmt);

            if (cloner.CloneResolvedFields)
            {
                Steps = original.Steps.Select(cloner.CloneExpr).ToList();
                Result = cloner.CloneExpr(original.Result);
                Op = original.Op;
            }
            else
            {
                Steps = new List<Expression>();
            }
        }

        public override IEnumerable<Statement> SubStatements
        {
            get
            {
                foreach (var h in Hints)
                {
                    yield return h;
                }

                yield break;
            }
        }

        public override IEnumerable<Expression> SpecificationSubExpressions
        {
            get
            {
                foreach (var e in base.SpecificationSubExpressions) { yield return e; }
                foreach (var e in Attributes.SubExpressions(Attributes)) { yield return e; }

                for (int i = MutateCSharp.Schemata148.ReplaceNumericConstant_5(274L, 0); MutateCSharp.Schemata148.ReplaceBinExprOp_13(291L, i, MutateCSharp.Schemata148.ReplaceBinExprOp_11(282L, Lines.Count, MutateCSharp.Schemata148.ReplaceNumericConstant_5(278L, 1))); MutateCSharp.Schemata148.ReplacePostfixUnaryExprOp_14(296L, ref i))
                {  // note, we skip the duplicated line at the end
                    yield return Lines[i];
                }
                foreach (var calcop in AllCalcOps)
                {
                    if (calcop is TernaryCalcOp o3)
                    {
                        yield return o3.Index;
                    }
                }

                if (MutateCSharp.Schemata148.ReplaceBinExprOp_9(297L, Result, null))
                {
                    yield return Result;
                }

                yield break;
            }
        }

        IEnumerable<CalcOp> AllCalcOps
        {
            get
            {
                if (MutateCSharp.Schemata148.ReplaceBinExprOp_7(298L, UserSuppliedOp, null))
                {
                    yield return UserSuppliedOp;
                }
                foreach (var stepop in StepOps)
                {
                    if (MutateCSharp.Schemata148.ReplaceBinExprOp_7(299L, stepop, null))
                    {
                        yield return stepop;
                    }
                }

                yield break;
            }
        }

        /// <summary>
        /// Left-hand side of a step expression.
        /// Note that Lhs(op.StepExpr(line0, line1)) != line0 when op is <==.
        /// </summary>
        public static Expression Lhs(Expression step)
        {
            Contract.Requires(step is BinaryExpr || step is TernaryExpr);
            if (step is BinaryExpr)
            {
                return ((BinaryExpr)step).E0;
            }
            else
            {
                return ((TernaryExpr)step).E1;
            }

            return default;
        }

        /// <summary>
        /// Right-hand side of a step expression.
        /// Note that Rhs(op.StepExpr(line0, line1)) != line1 when op is REVERSE-IMPLICATION.
        /// </summary>
        public static Expression Rhs(Expression step)
        {
            Contract.Requires(step is BinaryExpr || step is TernaryExpr);
            if (step is BinaryExpr)
            {
                return ((BinaryExpr)step).E1;
            }
            else
            {
                return ((TernaryExpr)step).E2;
            }

            return default;
        }

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            var inCalc = MutateCSharp.Schemata148.ReplaceBooleanConstant_2(300L, false);
            var inOrdinal = MutateCSharp.Schemata148.ReplaceBooleanConstant_2(301L, false);
            var innerCalcIndent = MutateCSharp.Schemata148.ReplaceBinExprOp_17(302L, indentBefore, formatter.SpaceTab);
            var extraHintIndent = MutateCSharp.Schemata148.ReplaceNumericConstant_5(311L, 0);
            var ownedTokens = OwnedTokens;
            // First phase: We get the alignment
            foreach (var token in ownedTokens)
            {
                if (formatter.SetIndentLabelTokens(token, indentBefore))
                {
                    continue;
                }
                switch (token.val)
                {
                    case "calc":
                    case ";":
                    case "}":
                        {
                            break;
                        }

                        break;
                    case "{":
                        {
                            inCalc = true;
                            break;
                        }

                        break;
                    default:
                        {
                            if (inCalc)
                            {
                                if (token.val == "[")
                                {
                                    inOrdinal = true;
                                }
                                if (token.val == "]")
                                {
                                    inOrdinal = false;
                                }
                                if (!TokenNewIndentCollector.IsFollowedByNewline(token) &&
                                    (token.val != "==" || token.Next.val != "#") &&
                                    token.val != "#" &&
                                    !inOrdinal)
                                {
                                    if (token.Next.val != "{")
                                    {
                                        formatter.SetIndentations(token, inline: indentBefore);
                                        innerCalcIndent = Math.Max(innerCalcIndent, formatter.GetRightAlignIndentAfter(token, indentBefore));
                                    }
                                    else
                                    {// It's an hint! If there is no comment and no newline between them, we align the hints as well.
                                        if ((token.TrailingTrivia + token.Next.LeadingTrivia).Trim() == "" &&
                                            token.line == token.Next.line)
                                        {
                                            extraHintIndent = Math.Max(extraHintIndent, formatter.GetRightAlignIndentAfter(token, indentBefore) - (indentBefore + formatter.SpaceTab));
                                        }
                                    }
                                }
                            }

                            break;
                        }

                        break;
                }
            }

            inCalc = MutateCSharp.Schemata148.ReplaceBooleanConstant_2(315L, false);
            foreach (var token in OwnedTokens)
            {
                switch (token.val)
                {
                    case "calc":
                        {
                            break;
                        }

                        break;
                    case "{":
                        {
                            formatter.SetIndentations(token, indentBefore, indentBefore, innerCalcIndent);
                            inCalc = true;
                            break;
                        }

                        break;
                    case "}":
                        {
                            formatter.SetIndentations(token, innerCalcIndent, indentBefore, indentBefore);
                            break;
                        }

                        break;
                    case ";":
                        {
                            formatter.SetDelimiterInsideIndentedRegions(token, indentBefore);
                            break;
                        }

                        break;
                    default:
                        {
                            // It has to be an operator
                            if (inCalc)
                            {
                                formatter.SetIndentations(token, innerCalcIndent, indentBefore, innerCalcIndent);
                            }

                            break;
                        }

                        break;
                }
            }

            foreach (var hint in Hints)
            {
                // This block
                if (MutateCSharp.Schemata148.ReplaceBinExprOp_12(316L, hint.Tok.pos, hint.EndToken.pos))
                {
                    foreach (var hintStep in hint.Body)
                    {
                        formatter.SetOpeningIndentedRegion(hintStep.StartToken, MutateCSharp.Schemata148.ReplaceBinExprOp_17(330L, MutateCSharp.Schemata148.ReplaceBinExprOp_17(321L, indentBefore, formatter.SpaceTab), extraHintIndent));
                    }
                }
            }

            foreach (var expression in Lines)
            {
                formatter.SetIndentations(expression.StartToken, innerCalcIndent, innerCalcIndent, innerCalcIndent);
            }

            return MutateCSharp.Schemata148.ReplaceBooleanConstant_2(339L, true);
        }
    }
}