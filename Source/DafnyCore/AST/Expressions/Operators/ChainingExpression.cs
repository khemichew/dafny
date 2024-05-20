using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata59
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT59");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBooleanConstant_7(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.BinaryExpr.Opcode argument1, Microsoft.Dafny.BinaryExpr.Opcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_3(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
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

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class ChainingExpression : ConcreteSyntaxExpression, ICloneable<ChainingExpression>, ICanFormat
    {
        public readonly List<Expression> Operands;
        public readonly List<BinaryExpr.Opcode> Operators;
        public readonly List<IToken> OperatorLocs;
        public readonly List<Expression/*?*/> PrefixLimits;
        public readonly Expression E;

        public ChainingExpression Clone(Cloner cloner)
        {
            return new ChainingExpression(cloner, this);
        }

        public ChainingExpression(Cloner cloner, ChainingExpression original) : base(cloner, original)
        {
            Operands = original.Operands.Select(cloner.CloneExpr).ToList();
            Operators = original.Operators;
            OperatorLocs = original.OperatorLocs.Select(cloner.Tok).ToList();
            PrefixLimits = original.PrefixLimits.Select(cloner.CloneExpr).ToList();
            E = ComputeDesugaring(Operands, Operators, OperatorLocs, PrefixLimits);
        }

        public ChainingExpression(IToken tok, List<Expression> operands, List<BinaryExpr.Opcode> operators, List<IToken> operatorLocs, List<Expression/*?*/> prefixLimits)
          : base(tok)
        {
            Contract.Requires(tok != null);
            Contract.Requires(operands != null);
            Contract.Requires(operators != null);
            Contract.Requires(operatorLocs != null);
            Contract.Requires(prefixLimits != null);
            Contract.Requires(1 <= operators.Count);
            Contract.Requires(operands.Count == operators.Count + 1);
            Contract.Requires(operatorLocs.Count == operators.Count);
            Contract.Requires(prefixLimits.Count == operators.Count);
            // Additional preconditions apply, see Contract.Assume's below

            Operands = operands;
            Operators = operators;
            OperatorLocs = operatorLocs;
            PrefixLimits = prefixLimits;
            E = ComputeDesugaring(operands, operators, operatorLocs, prefixLimits);
        }

        private static Expression ComputeDesugaring(List<Expression> operands, List<BinaryExpr.Opcode> operators, List<IToken> operatorLocs, List<Expression> prefixLimits)
        {
            Expression desugaring;
            // Compute the desugaring
            if (MutateCSharp.Schemata59.ReplaceBinExprOp_1(5L, operators[MutateCSharp.Schemata59.ReplaceNumericConstant_0(1L, 0)], BinaryExpr.Opcode.Disjoint))
            {
                Expression acc = operands[MutateCSharp.Schemata59.ReplaceNumericConstant_0(6L, 0)]; // invariant:  "acc" is the union of all operands[j] where j <= i
                desugaring = new BinaryExpr(operatorLocs[MutateCSharp.Schemata59.ReplaceNumericConstant_0(10L, 0)], operators[MutateCSharp.Schemata59.ReplaceNumericConstant_0(14L, 0)], operands[MutateCSharp.Schemata59.ReplaceNumericConstant_0(18L, 0)], operands[MutateCSharp.Schemata59.ReplaceNumericConstant_0(22L, 1)]);
                for (int i = MutateCSharp.Schemata59.ReplaceNumericConstant_0(26L, 0); MutateCSharp.Schemata59.ReplaceBinExprOp_2(30L, i, operators.Count); MutateCSharp.Schemata59.ReplacePostfixUnaryExprOp_3(35L, ref i))
                {
                    Contract.Assume(operators[i] == BinaryExpr.Opcode.Disjoint);
                    var opTok = operatorLocs[i];
                    var e = new BinaryExpr(opTok, BinaryExpr.Opcode.Disjoint, acc, operands[MutateCSharp.Schemata59.ReplaceBinExprOp_4(40L, i, MutateCSharp.Schemata59.ReplaceNumericConstant_0(36L, 1))]);
                    desugaring = new BinaryExpr(opTok, BinaryExpr.Opcode.And, desugaring, e);
                    acc = new BinaryExpr(opTok, BinaryExpr.Opcode.Add, acc, operands[MutateCSharp.Schemata59.ReplaceBinExprOp_4(53L, i, MutateCSharp.Schemata59.ReplaceNumericConstant_0(49L, 1))]);
                }
            }
            else
            {
                desugaring = null;
                for (int i = MutateCSharp.Schemata59.ReplaceNumericConstant_0(62L, 0); MutateCSharp.Schemata59.ReplaceBinExprOp_2(66L, i, operators.Count); MutateCSharp.Schemata59.ReplacePostfixUnaryExprOp_3(71L, ref i))
                {
                    var opTok = operatorLocs[i];
                    var op = operators[i];
                    Contract.Assume(op != BinaryExpr.Opcode.Disjoint);
                    var k = prefixLimits[i];
                    Contract.Assume(k == null || op == BinaryExpr.Opcode.Eq || op == BinaryExpr.Opcode.Neq);
                    var e0 = operands[i];
                    var e1 = operands[MutateCSharp.Schemata59.ReplaceBinExprOp_4(76L, i, MutateCSharp.Schemata59.ReplaceNumericConstant_0(72L, 1))];
                    Expression e;
                    if (MutateCSharp.Schemata59.ReplaceBinExprOp_5(85L, k, null))
                    {
                        e = new BinaryExpr(opTok, op, e0, e1);
                    }
                    else
                    {
                        e = new TernaryExpr(opTok,
              MutateCSharp.Schemata59.ReplaceBinExprOp_1(86L, op, BinaryExpr.Opcode.Eq) ? TernaryExpr.Opcode.PrefixEqOp : TernaryExpr.Opcode.PrefixNeqOp, k, e0,
                          e1);
                    }

                    desugaring = MutateCSharp.Schemata59.ReplaceBinExprOp_5(87L, desugaring, null) ? e : new BinaryExpr(opTok, BinaryExpr.Opcode.And, desugaring, e);
                }
            }

            return desugaring;
        }

        public override IEnumerable<Expression> SubExpressions
        {
            get
            {
                if (!WasResolved())
                {
                    foreach (var sub in PreResolveSubExpressions)
                    {
                        yield return sub;
                    }
                }
                else
                {
                    yield return Resolved;
                }

                yield break;
            }
        }

        public override IEnumerable<Expression> PreResolveSubExpressions
        {
            get
            {
                foreach (var sub in Operands)
                {
                    yield return sub;
                }
                foreach (var sub in PrefixLimits)
                {
                    if (MutateCSharp.Schemata59.ReplaceBinExprOp_6(88L, sub, null))
                    {
                        yield return sub;
                    }
                }

                yield break;
            }
        }

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            // Chaining expressions try to align their values if possible
            var itemIndent = formatter.GetNewTokenVisualIndent(
              Operands[MutateCSharp.Schemata59.ReplaceNumericConstant_0(89L, 0)].StartToken, indentBefore);

            foreach (var token in OwnedTokens)
            {
                switch (token.val)
                {
                    case "[":
                        break;
                        break;
                    case "#":
                        break;
                        break;
                    case "]":
                        break;
                        break;
                    default:
                        formatter.SetIndentations(token, itemIndent, Math.Max(itemIndent - token.val.Length - 1, 0), itemIndent);
                        break;
                        break;
                }
            }

            return MutateCSharp.Schemata59.ReplaceBooleanConstant_7(93L, true);
        }
    }
}