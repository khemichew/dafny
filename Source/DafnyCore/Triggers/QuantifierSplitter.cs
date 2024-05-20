// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata474
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT474");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
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

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.UnaryOpExpr.Opcode argument1, Microsoft.Dafny.UnaryOpExpr.Opcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.BinaryExpr.Opcode argument1, Microsoft.Dafny.BinaryExpr.Opcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.IToken argument1, Microsoft.Dafny.IToken argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceNumericConstant_8(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.BinaryExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBooleanConstant_7(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_5(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny.Triggers
{
    public
      /// <summary>
      /// See section 2.3 of "Trigger Selection Strategies to Stabilize Program Verifiers" to learn
      /// why we split quantifiers
      /// </summary>
      class QuantifierSplitter : BottomUpVisitor
    {
        /// This cache was introduced because some statements (notably calc) return the same SubExpression multiple times.
        /// This ended up causing an inconsistent situation when the calc statement's subexpressions contained the same quantifier
        /// twice: on the first pass that quantifier got its SplitQuantifiers generated, and on the the second pass these
        /// split quantifiers got re-split, creating a situation where the direct children of a split quantifier were
        /// also split quantifiers.
        private readonly Dictionary<QuantifierExpr, List<Expression>> splits = new();

        private static BinaryExpr.Opcode FlipOpcode(BinaryExpr.Opcode opCode)
        {
            if (MutateCSharp.Schemata474.ReplaceBinExprOp_0(1L, opCode, BinaryExpr.Opcode.And))
            {
                return BinaryExpr.Opcode.Or;
            }
            else if (MutateCSharp.Schemata474.ReplaceBinExprOp_0(2L, opCode, BinaryExpr.Opcode.Or))
            {
                return BinaryExpr.Opcode.And;
            }
            else
            {
                throw new ArgumentException();
            }

            return default;
        }

        // NOTE: If we wanted to split quantifiers as far as possible, it would be
        // enough to put the formulas in DNF (for foralls) or CNF (for exists).
        // Unfortunately, this would cause ill-behaved quantifiers to produce
        // exponentially many smaller quantifiers. Thus we only do one step of
        // distributing, which takes care of the usual precondition case:
        //   forall x :: P(x) ==> (Q(x) && R(x))

        private static UnaryOpExpr Not(Expression expr)
        {
            return new UnaryOpExpr(expr.tok, UnaryOpExpr.Opcode.Not, expr) { Type = expr.Type };
        }

        private static IEnumerable<Expression> SplitExpr(Expression expr, BinaryExpr.Opcode separator)
        {
            expr = expr.Resolved;
            var binary = expr as BinaryExpr;

            if (expr is UnaryOpExpr unary && MutateCSharp.Schemata474.ReplaceBinExprOp_1(3L, unary.Op, UnaryOpExpr.Opcode.Not))
            {
                foreach (var e in SplitExpr(unary.E, FlipOpcode(separator))) { yield return Not(e); }
            }
            else if (MutateCSharp.Schemata474.ReplaceBinExprOp_3(6L, () => MutateCSharp.Schemata474.ReplaceBinExprOp_2(4L, binary, null), () => MutateCSharp.Schemata474.ReplaceBinExprOp_0(5L, binary.Op, separator)))
            {
                if (Expression.IsBoolLiteral(binary.E0, out var b) && (MutateCSharp.Schemata474.ReplaceBinExprOp_0(12L, binary.Op, BinaryExpr.Opcode.And) ? b : !b))
                {
                    // skip this unit element
                }
                else
                {
                    foreach (var e in SplitExpr(binary.E0, separator)) { yield return e; }
                }
                foreach (var e in SplitExpr(binary.E1, separator)) { yield return e; }
            }
            else if (MutateCSharp.Schemata474.ReplaceBinExprOp_3(22L, () => MutateCSharp.Schemata474.ReplaceBinExprOp_3(15L, () => MutateCSharp.Schemata474.ReplaceBinExprOp_2(13L, binary, null), () => MutateCSharp.Schemata474.ReplaceBinExprOp_0(14L, binary.Op, BinaryExpr.Opcode.Imp)), () => MutateCSharp.Schemata474.ReplaceBinExprOp_0(21L, separator, BinaryExpr.Opcode.Or)))
            {
                foreach (var e in SplitExpr(Not(binary.E0), separator)) { yield return e; }
                foreach (var e in SplitExpr(binary.E1, separator)) { yield return e; }
            }
            else
            {
                yield return expr;
            }

            yield break;
        }

        internal static IEnumerable<Expression> SplitAndStitch(BinaryExpr pair, BinaryExpr.Opcode separator)
        {
            foreach (var e1 in SplitExpr(pair.E1, separator))
            {
                // Notice the token. This makes triggers/splitting-picks-the-right-tokens.dfy possible
                var nestedToken = new NestedToken(pair.tok, e1.tok);
                yield return new BinaryExpr(nestedToken, pair.Op, pair.E0, e1) { ResolvedOp = pair.ResolvedOp, Type = pair.Type };
            }

            yield break;
        }

        private static IEnumerable<Expression> SplitQuantifier(ComprehensionExpr quantifier)
        {
            var body = quantifier.Term;
            var binary = body as BinaryExpr;

            if (quantifier is ForallExpr)
            {
                IEnumerable<Expression> stream;
                if (MutateCSharp.Schemata474.ReplaceBinExprOp_3(37L, () => MutateCSharp.Schemata474.ReplaceBinExprOp_2(28L, binary, null), () => (MutateCSharp.Schemata474.ReplaceBinExprOp_4(31L, () => MutateCSharp.Schemata474.ReplaceBinExprOp_0(29L, binary.Op, BinaryExpr.Opcode.Imp), () => MutateCSharp.Schemata474.ReplaceBinExprOp_0(30L, binary.Op, BinaryExpr.Opcode.Or)))))
                {
                    stream = SplitAndStitch(binary, BinaryExpr.Opcode.And);
                }
                else
                {
                    stream = SplitExpr(body, BinaryExpr.Opcode.And);
                }
                foreach (var e in stream)
                {
                    var tok = new NestedToken(quantifier.tok, e.tok, MutateCSharp.Schemata474.ReplaceStringConstant_5(43L, "in subexpression at"));
                    yield return new ForallExpr(tok, quantifier.RangeToken, quantifier.BoundVars, quantifier.Range, e, TriggerUtils.CopyAttributes(quantifier.Attributes)) { Type = quantifier.Type, Bounds = quantifier.Bounds };
                }
            }
            else if (quantifier is ExistsExpr)
            {
                IEnumerable<Expression> stream;
                if (MutateCSharp.Schemata474.ReplaceBinExprOp_3(46L, () => MutateCSharp.Schemata474.ReplaceBinExprOp_2(44L, binary, null), () => MutateCSharp.Schemata474.ReplaceBinExprOp_0(45L, binary.Op, BinaryExpr.Opcode.And)))
                {
                    stream = SplitAndStitch(binary, BinaryExpr.Opcode.Or);
                }
                else
                {
                    stream = SplitExpr(body, BinaryExpr.Opcode.Or);
                }
                foreach (var e in stream)
                {
                    var tok = MutateCSharp.Schemata474.ReplaceBinExprOp_6(52L, body?.tok, e.tok) ? quantifier.tok : new NestedToken(quantifier.tok, e.tok, MutateCSharp.Schemata474.ReplaceStringConstant_5(53L, "in subexpression at"));
                    yield return new ExistsExpr(tok, quantifier.RangeToken, quantifier.BoundVars, quantifier.Range, e, TriggerUtils.CopyAttributes(quantifier.Attributes)) { Type = quantifier.Type, Bounds = quantifier.Bounds };
                }
            }
            else
            {
                yield return quantifier;
            }

            yield break;
        }

        private static bool AllowsSplitting(ComprehensionExpr quantifier)
        {
            // allow split if attributes doesn't contains "split" or it is "split: true" and it is not an empty QuantifierExpr (boundvar.count>0)
            bool splitAttr = MutateCSharp.Schemata474.ReplaceBooleanConstant_7(54L, true);
            return (!Attributes.ContainsBool(quantifier.Attributes, MutateCSharp.Schemata474.ReplaceStringConstant_5(55L, "split"), ref splitAttr) || splitAttr) && (MutateCSharp.Schemata474.ReplaceBinExprOp_9(60L, quantifier.BoundVars.Count, MutateCSharp.Schemata474.ReplaceNumericConstant_8(56L, 0)));
        }

        protected override void VisitOneExpr(Expression expr)
        {
            if (expr is QuantifierExpr quantifier)
            {
                Contract.Assert(quantifier.SplitQuantifier == null);
                if (MutateCSharp.Schemata474.ReplaceBinExprOp_3(65L, () => !splits.ContainsKey(quantifier), () => AllowsSplitting(quantifier)))
                {
                    splits[quantifier] = SplitQuantifier(quantifier).Select(e =>
                    {
                        e.tok = new AutoGeneratedToken(e.tok);
                        e.RangeToken = e.RangeToken.MakeAutoGenerated();
                        return e;
                    }).ToList();
                }
            }

            if (expr is ITEExpr { IsBindingGuard: true } iteExpr)
            {
                splits.Remove((ExistsExpr)iteExpr.Test);
            }
        }

        protected override void VisitOneStmt(Statement stmt)
        {
            if (stmt is ForallStmt)
            {
                ForallStmt s = (ForallStmt)stmt;
                if (MutateCSharp.Schemata474.ReplaceBinExprOp_10(71L, s.EffectiveEnsuresClauses, null))
                {
                    foreach (Expression expr in s.EffectiveEnsuresClauses)
                    {
                        VisitOneExpr(expr);
                    }
                }
            }

            if (stmt is IfStmt ifStatement && ifStatement.IsBindingGuard)
            {
                splits.Remove((ExistsExpr)ifStatement.Guard);
            }
        }

        /// <summary>
        /// See comments above definition of splits for reason why this method exists
        /// </summary>
        internal void Commit()
        {
            foreach (var quantifier in splits.Keys)
            {
                quantifier.SplitQuantifier = splits[quantifier];
            }
        }
    }
}
