using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Diagnostics.Contracts;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using Bpl = Microsoft.Boogie;
using BplParser = Microsoft.Boogie.Parser;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.Boogie;
using static Microsoft.Dafny.Util;
using Core;
using DafnyCore.Verifier;
using Microsoft.BaseTypes;
using Microsoft.Dafny.Compilers;
using Microsoft.Dafny.Triggers;
using Action = System.Action;
using PODesc = Microsoft.Dafny.ProofObligationDescription;
using static Microsoft.Dafny.GenericErrors;
namespace MutateCSharp
{
    internal class Schemata489
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT489");
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

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_3(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Boogie.Expr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_5(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static int ReplacePrefixUnaryExprOp_10(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return --argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return +argument1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return ~argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return ++argument1; }
            return --argument1;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, Microsoft.Dafny.BoogieGenerator.BuiltinFunction? argument1, Microsoft.Dafny.BoogieGenerator.BuiltinFunction? argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_12(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.BoogieStmtListBuilder argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_8(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public partial class BoogieGenerator
    {


        /// <summary>
        /// Emit to "builder" a check that calleeDecreases is less than contextDecreases.  More precisely,
        /// the check is:
        ///     allowance || (calleeDecreases LESS contextDecreases).
        /// </summary>
        void CheckCallTermination(IToken tok, List<Expression> contextDecreases, List<Expression> calleeDecreases,
                                  Expression allowance,
                                  Expression receiverReplacement, Dictionary<IVariable, Expression> substMap,
                                  Dictionary<TypeParameter, Type> typeMap,
                                  ExpressionTranslator etranCurrent, bool oldCaller, BoogieStmtListBuilder builder, bool inferredDecreases, string hint)
        {
            Contract.Requires(tok != null);
            Contract.Requires(cce.NonNullElements(contextDecreases));
            Contract.Requires(cce.NonNullElements(calleeDecreases));
            Contract.Requires(cce.NonNullDictionaryAndValues(substMap));
            Contract.Requires(etranCurrent != null);
            Contract.Requires(builder != null);

            // The interpretation of the given decreases-clause expression tuples is as a lexicographic tuple, extended into
            // an infinite tuple by appending TOP elements.  The TOP element is strictly larger than any other value given
            // by a Dafny expression.  Each Dafny types has its own ordering, and these orderings are combined into a partial
            // order where elements from different Dafny types are incomparable.  Thus, as an optimization below, if two
            // components from different types are compared, the answer is taken to be false.

            if (Contract.Exists(calleeDecreases, e => e is WildcardExpr))
            {
                // no check needed
                return;
            }

            int N = Math.Min(contextDecreases.Count, calleeDecreases.Count);
            var toks = new List<IToken>();
            var types0 = new List<Type>();
            var types1 = new List<Type>();
            var callee = new List<Expr>();
            var caller = new List<Expr>();
            var oldExpressions = new List<Expression>();
            var newExpressions = new List<Expression>();
            if (MutateCSharp.Schemata489.ReplaceBinExprOp_0(1L, () => RefinementToken.IsInherited(tok, currentModule), () => contextDecreases.All(e => !RefinementToken.IsInherited(e.tok, currentModule))))
            {
                // the call site is inherited but all the context decreases expressions are new
                tok = new ForceCheckToken(tok);
            }
            for (int i = MutateCSharp.Schemata489.ReplaceNumericConstant_1(7L, 0); MutateCSharp.Schemata489.ReplaceBinExprOp_2(11L, i, N); MutateCSharp.Schemata489.ReplacePostfixUnaryExprOp_3(16L, ref i))
            {
                Expression e0 = Substitute(calleeDecreases[i], receiverReplacement, substMap, typeMap);
                Expression e1 = contextDecreases[i];
                if (oldCaller)
                {
                    e1 = new OldExpr(e1.tok, e1)
                    {
                        Type = e1.Type // To ensure that e1 stays resolved
                    };
                }
                if (!CompatibleDecreasesTypes(e0.Type, e1.Type))
                {
                    N = i;
                    break;
                }
                oldExpressions.Add(e1);
                newExpressions.Add(e0);
                toks.Add(new NestedToken(tok, e1.tok));
                types0.Add(e0.Type.NormalizeExpand());
                types1.Add(e1.Type.NormalizeExpand());
                callee.Add(etranCurrent.TrExpr(e0));
                caller.Add(etranCurrent.TrExpr(e1));
            }
            bool endsWithWinningTopComparison = MutateCSharp.Schemata489.ReplaceBinExprOp_0(27L, () => MutateCSharp.Schemata489.ReplaceBinExprOp_4(17L, N, contextDecreases.Count), () => MutateCSharp.Schemata489.ReplaceBinExprOp_2(22L, N, calleeDecreases.Count));
            Bpl.Expr decrExpr = DecreasesCheck(toks, types0, types1, callee, caller, builder, "", endsWithWinningTopComparison, MutateCSharp.Schemata489.ReplaceBooleanConstant_5(33L, false));
            if (MutateCSharp.Schemata489.ReplaceBinExprOp_6(34L, allowance, null))
            {
                decrExpr = BplOr(etranCurrent.TrExpr(allowance), decrExpr);
            }
            builder.Add(Assert(tok, decrExpr, new
              PODesc.Terminates(inferredDecreases, null, allowance,
                                oldExpressions, newExpressions, hint)));
        }

        /// <summary>
        /// Returns the expression that says whether or not the decreases function has gone down (if !allowNoChange)
        /// or has gone down or stayed the same (if allowNoChange).
        /// ee0 represents the new values and ee1 represents old values.
        /// If builder is non-null, then the check '0 ATMOST decr' is generated to builder.
        /// Requires all types in types0 and types1 to be non-proxy non-synonym types (that is, callers should invoke NormalizeExpand)
        /// </summary>
        Bpl.Expr DecreasesCheck(List<IToken> toks, List<Type> types0, List<Type> types1, List<Bpl.Expr> ee0, List<Bpl.Expr> ee1,
                                BoogieStmtListBuilder builder, string suffixMsg, bool allowNoChange, bool includeLowerBound)
        {
            Contract.Requires(cce.NonNullElements(toks));
            Contract.Requires(cce.NonNullElements(types0));
            Contract.Requires(cce.NonNullElements(types1));
            Contract.Requires(cce.NonNullElements(ee0));
            Contract.Requires(cce.NonNullElements(ee1));
            Contract.Requires(predef != null);
            Contract.Requires(types0.Count == types1.Count && types0.Count == ee0.Count && ee0.Count == ee1.Count);
            Contract.Requires(builder == null || suffixMsg != null);
            Contract.Ensures(Contract.Result<Bpl.Expr>() != null);

            int N = types0.Count;

            // compute eq and less for each component of the lexicographic tuple
            List<Bpl.Expr> Eq = new List<Bpl.Expr>(N);
            List<Bpl.Expr> Less = new List<Bpl.Expr>(N);
            for (int i = MutateCSharp.Schemata489.ReplaceNumericConstant_1(35L, 0); MutateCSharp.Schemata489.ReplaceBinExprOp_2(39L, i, N); MutateCSharp.Schemata489.ReplacePostfixUnaryExprOp_3(44L, ref i))
            {
                Bpl.Expr less, atmost, eq;
                ComputeLessEq(toks[i], types0[i], types1[i], ee0[i], ee1[i], out less, out atmost, out eq, includeLowerBound);
                Eq.Add(eq);
                Less.Add(allowNoChange ? atmost : less);
            }
            if (MutateCSharp.Schemata489.ReplaceBinExprOp_7(45L, builder, null))
            {
                // check: 0 <= ee1
                // more precisely, for component k of the lexicographic decreases function, check:
                //   ee0[0] < ee1[0] || ee0[1] < ee1[1] || ... || ee0[k-1] < ee1[k-1] || ee0[k] == ee1[k] || 0 <= ee1[k]
                for (int k = MutateCSharp.Schemata489.ReplaceNumericConstant_1(46L, 0); MutateCSharp.Schemata489.ReplaceBinExprOp_2(50L, k, N); MutateCSharp.Schemata489.ReplacePostfixUnaryExprOp_3(55L, ref k))
                {
                    // we only need to check lower bound for integers--sets, sequences, booleans, references, and datatypes all have natural lower bounds
                    Bpl.Expr prefixIsLess = Bpl.Expr.False;
                    for (int i = MutateCSharp.Schemata489.ReplaceNumericConstant_1(56L, 0); MutateCSharp.Schemata489.ReplaceBinExprOp_2(60L, i, k); MutateCSharp.Schemata489.ReplacePostfixUnaryExprOp_3(65L, ref i))
                    {
                        prefixIsLess = BplOr(prefixIsLess, Less[i]);
                    };

                    Bpl.Expr zero = null;
                    string zeroStr = null;
                    if (types0[k].IsNumericBased(Type.NumericPersuasion.Int))
                    {
                        zero = Bpl.Expr.Literal(MutateCSharp.Schemata489.ReplaceNumericConstant_1(66L, 0));
                        zeroStr = MutateCSharp.Schemata489.ReplaceStringConstant_8(70L, "0");
                    }
                    else if (types0[k].IsNumericBased(Type.NumericPersuasion.Real))
                    {
                        zero = Bpl.Expr.Literal(BaseTypes.BigDec.ZERO);
                        zeroStr = MutateCSharp.Schemata489.ReplaceStringConstant_8(71L, "0.0");
                    }
                    if (MutateCSharp.Schemata489.ReplaceBinExprOp_9(72L, zero, null))
                    {
                        Bpl.Expr bounded = Bpl.Expr.Le(zero, ee1[k]);
                        for (int i = MutateCSharp.Schemata489.ReplaceNumericConstant_1(73L, 0); MutateCSharp.Schemata489.ReplaceBinExprOp_2(77L, i, k); MutateCSharp.Schemata489.ReplacePostfixUnaryExprOp_3(82L, ref i))
                        {
                            bounded = BplOr(bounded, Less[i]);
                        }
                        Bpl.Cmd cmd = Assert(toks[k], BplOr(bounded, Eq[k]), new PODesc.DecreasesBoundedBelow(N, k, zeroStr, suffixMsg));
                        builder.Add(cmd);
                    }
                }
            }
            // check: ee0 < ee1 (or ee0 <= ee1, if allowNoChange)
            Bpl.Expr decrCheck = allowNoChange ? Bpl.Expr.True : Bpl.Expr.False;
            for (int i = N; MutateCSharp.Schemata489.ReplaceBinExprOp_11(91L, MutateCSharp.Schemata489.ReplaceNumericConstant_1(83L, 0), MutateCSharp.Schemata489.ReplacePrefixUnaryExprOp_10(87L, ref i));)
            {
                Bpl.Expr less = Less[i];
                Bpl.Expr eq = Eq[i];
                if (allowNoChange)
                {
                    // decrCheck = atmost && (eq ==> decrCheck)
                    decrCheck = BplAnd(less, BplImp(eq, decrCheck));
                }
                else
                {
                    // decrCheck = less || (eq && decrCheck)
                    decrCheck = BplOr(less, BplAnd(eq, decrCheck));
                }
            }
            return decrCheck;
        }

        bool CompatibleDecreasesTypes(Type t, Type u)
        {
            Contract.Requires(t != null);
            Contract.Requires(u != null);
            t = t.NormalizeToAncestorType();
            u = u.NormalizeToAncestorType();
            if (t is BoolType)
            {
                return u is BoolType;
            }
            else if (t is CharType)
            {
                return u is CharType;
            }
            else if (t is IntType)
            {
                // we can allow different kinds of int-based types
                return u is IntType;
            }
            else if (t is RealType)
            {
                // we can allow different kinds of real-based types
                return u is RealType;
            }
            else if (t is SetType)
            {
                return u is SetType;
            }
            else if (t is SeqType)
            {
                return MutateCSharp.Schemata489.ReplaceBinExprOp_12(96L, () => u is SeqType, () => u.IsIndDatatype);
            }
            else if (t.IsDatatype)
            {
                return MutateCSharp.Schemata489.ReplaceBinExprOp_12(108L, () => u.IsDatatype, () => (MutateCSharp.Schemata489.ReplaceBinExprOp_0(102L, () => t.IsIndDatatype, () => u is SeqType)));
            }
            else if (t.IsRefType)
            {
                return u.IsRefType;
            }
            else if (t is MultiSetType)
            {
                return u is MultiSetType;
            }
            else if (t is MapType)
            {
                return MutateCSharp.Schemata489.ReplaceBinExprOp_0(120L, () => u is MapType, () => MutateCSharp.Schemata489.ReplaceBinExprOp_13(114L, () => ((MapType)t).Finite, () => ((MapType)u).Finite));
            }
            else if (t is ArrowType)
            {
                return u is ArrowType;
            }
            else if (t is BitvectorType)
            {
                return u is BitvectorType;
            }
            else if (t is BigOrdinalType)
            {
                return u is BigOrdinalType;
            }
            else if (MutateCSharp.Schemata489.ReplaceBinExprOp_12(132L, () => MutateCSharp.Schemata489.ReplaceBinExprOp_12(126L, () => t.IsTypeParameter, () => t.IsAbstractType), () => t.IsInternalTypeSynonym))
            {
                return MutateCSharp.Schemata489.ReplaceBooleanConstant_5(138L, false);  // don't consider any type parameters to be the same (since we have no comparison function for them anyway)
            }
            else
            {
                return t.Equals(u);
            }

            return default;
        }

        Nullable<BuiltinFunction> RankFunction(Type/*!*/ ty)
        {
            Contract.Requires(ty != null);
            if (ty is SeqType)
            {
                return BuiltinFunction.SeqRank;
            }
            else if (ty.IsIndDatatype)
            {
                return BuiltinFunction.DtRank;
            }
            else
            {
                return null;
            }

            return default;
        }

        void ComputeLessEq(IToken tok, Type ty0, Type ty1, Bpl.Expr e0, Bpl.Expr e1, out Bpl.Expr less, out Bpl.Expr atmost, out Bpl.Expr eq, bool includeLowerBound)
        {
            Contract.Requires(tok != null);
            Contract.Requires(ty0 != null);
            Contract.Requires(ty1 != null);
            Contract.Requires(e0 != null);
            Contract.Requires(e1 != null);
            Contract.Requires(predef != null);
            Contract.Ensures(Contract.ValueAtReturn(out less) != null);
            Contract.Ensures(Contract.ValueAtReturn(out atmost) != null);
            Contract.Ensures(Contract.ValueAtReturn(out eq) != null);

            ty0 = ty0.NormalizeToAncestorType();
            ty1 = ty1.NormalizeToAncestorType();
            var rk0 = RankFunction(ty0);
            var rk1 = RankFunction(ty1);
            if (MutateCSharp.Schemata489.ReplaceBinExprOp_0(146L, () => MutateCSharp.Schemata489.ReplaceBinExprOp_0(139L, () => rk0 != null, () => rk1 != null), () => MutateCSharp.Schemata489.ReplaceBinExprOp_14(145L, rk0, rk1)))
            {
                eq = Bpl.Expr.False;
                Bpl.Expr b0 = FunctionCall(tok, rk0.Value, null, e0);
                Bpl.Expr b1 = FunctionCall(tok, rk1.Value, null, e1);
                less = Bpl.Expr.Lt(b0, b1);
                atmost = Bpl.Expr.Le(b0, b1);
            }
            else if (ty0 is BoolType)
            {
                eq = BplIff(e0, e1);
                less = BplAnd(Bpl.Expr.Not(e0), e1);
                atmost = BplImp(e0, e1);
            }
            else if (ty0 is CharType)
            {
                eq = Bpl.Expr.Eq(e0, e1);
                var operand0 = FunctionCall(e0.tok, BuiltinFunction.CharToInt, null, e0);
                var operand1 = FunctionCall(e0.tok, BuiltinFunction.CharToInt, null, e1);
                less = Bpl.Expr.Binary(tok, BinaryOperator.Opcode.Lt, operand0, operand1);
                atmost = Bpl.Expr.Binary(tok, BinaryOperator.Opcode.Le, operand0, operand1);
            }
            else if (MutateCSharp.Schemata489.ReplaceBinExprOp_12(158L, () => MutateCSharp.Schemata489.ReplaceBinExprOp_12(152L, () => ty0.IsNumericBased(Type.NumericPersuasion.Int), () => ty0 is SeqType), () => ty0.IsDatatype))
            {
                Bpl.Expr b0, b1;
                if (ty0.IsNumericBased(Type.NumericPersuasion.Int))
                {
                    b0 = e0;
                    b1 = e1;
                }
                else if (ty0 is SeqType)
                {
                    b0 = FunctionCall(tok, BuiltinFunction.SeqRank, null, e0);
                    b1 = FunctionCall(tok, BuiltinFunction.SeqRank, null, e1);
                }
                else if (ty0.IsDatatype)
                {
                    b0 = FunctionCall(tok, BuiltinFunction.DtRank, null, e0);
                    b1 = FunctionCall(tok, BuiltinFunction.DtRank, null, e1);
                }
                else
                {
                    Contract.Assert(false); throw new cce.UnreachableException();
                }
                eq = Bpl.Expr.Eq(b0, b1);
                less = Bpl.Expr.Lt(b0, b1);
                atmost = Bpl.Expr.Le(b0, b1);
                if (MutateCSharp.Schemata489.ReplaceBinExprOp_0(164L, () => ty0.IsNumericBased(Type.NumericPersuasion.Int), () => includeLowerBound))
                {
                    less = BplAnd(Bpl.Expr.Le(Bpl.Expr.Literal(MutateCSharp.Schemata489.ReplaceNumericConstant_1(170L, 0)), b0), less);
                    atmost = BplAnd(Bpl.Expr.Le(Bpl.Expr.Literal(MutateCSharp.Schemata489.ReplaceNumericConstant_1(174L, 0)), b0), atmost);
                }

            }
            else if (ty0.IsNumericBased(Type.NumericPersuasion.Real))
            {
                eq = Bpl.Expr.Eq(e0, e1);
                less = Bpl.Expr.Le(e0, Bpl.Expr.Sub(e1, Bpl.Expr.Literal(BaseTypes.BigDec.FromInt(MutateCSharp.Schemata489.ReplaceNumericConstant_1(178L, 1)))));
                atmost = Bpl.Expr.Le(e0, e1);
                if (includeLowerBound)
                {
                    less = BplAnd(Bpl.Expr.Le(Bpl.Expr.Literal(BaseTypes.BigDec.ZERO), e0), less);
                    atmost = BplAnd(Bpl.Expr.Le(Bpl.Expr.Literal(BaseTypes.BigDec.ZERO), e0), atmost);
                }

            }
            else if (ty0 is IteratorDecl.EverIncreasingType)
            {
                eq = Bpl.Expr.Eq(e0, e1);
                less = Bpl.Expr.Gt(e0, e1);
                atmost = Bpl.Expr.Ge(e0, e1);

            }
            else if (MutateCSharp.Schemata489.ReplaceBinExprOp_12(194L, () => (MutateCSharp.Schemata489.ReplaceBinExprOp_0(182L, () => ty0 is SetType, () => ((SetType)ty0).Finite)), () => (MutateCSharp.Schemata489.ReplaceBinExprOp_0(188L, () => ty0 is MapType, () => ((MapType)ty0).Finite))))
            {
                Bpl.Expr b0, b1;
                if (ty0 is SetType)
                {
                    b0 = e0;
                    b1 = e1;
                }
                else
                {
                    // for maps, compare their domains as sets
                    b0 = FunctionCall(tok, BuiltinFunction.MapDomain, predef.MapType, e0);
                    b1 = FunctionCall(tok, BuiltinFunction.MapDomain, predef.MapType, e1);
                }
                eq = FunctionCall(tok, BuiltinFunction.SetEqual, null, b0, b1);
                less = ProperSubset(tok, b0, b1);
                atmost = FunctionCall(tok, BuiltinFunction.SetSubset, null, b0, b1);

            }
            else if (MutateCSharp.Schemata489.ReplaceBinExprOp_12(200L, () => ty0 is SetType, () => ty0 is MapType))
            {
                Bpl.Expr b0, b1;
                if (ty0 is SetType)
                {
                    Contract.Assert(!((SetType)ty0).Finite);
                    b0 = e0;
                    b1 = e1;
                }
                else
                {
                    Contract.Assert(!((MapType)ty0).Finite);
                    // for maps, compare their domains as sets
                    b0 = FunctionCall(tok, BuiltinFunction.IMapDomain, predef.MapType, e0);
                    b1 = FunctionCall(tok, BuiltinFunction.IMapDomain, predef.MapType, e1);
                }
                eq = FunctionCall(tok, BuiltinFunction.ISetEqual, null, b0, b1);
                less = Bpl.Expr.False;
                atmost = BplOr(less, eq);

            }
            else if (ty0 is MultiSetType)
            {
                eq = FunctionCall(tok, BuiltinFunction.MultiSetEqual, null, e0, e1);
                less = ProperMultiset(tok, e0, e1);
                atmost = FunctionCall(tok, BuiltinFunction.MultiSetSubset, null, e0, e1);

            }
            else if (ty0 is ArrowType)
            {
                eq = Bpl.Expr.Eq(e0, e1);
                less = Bpl.Expr.False;  // TODO: try to do better than this
                atmost = BplOr(less, eq);

            }
            else if (ty0 is BitvectorType)
            {
                BitvectorType bv = (BitvectorType)ty0;
                eq = Bpl.Expr.Eq(e0, e1);
                less = FunctionCall(tok, MutateCSharp.Schemata489.ReplaceStringConstant_8(206L, "lt_bv") + bv.Width, Bpl.Type.Bool, e0, e1);
                atmost = FunctionCall(tok, MutateCSharp.Schemata489.ReplaceStringConstant_8(207L, "le_bv") + bv.Width, Bpl.Type.Bool, e0, e1);

            }
            else if (ty0 is BigOrdinalType)
            {
                eq = Bpl.Expr.Eq(e0, e1);
                less = FunctionCall(tok, MutateCSharp.Schemata489.ReplaceStringConstant_8(208L, "ORD#Less"), Bpl.Type.Bool, e0, e1);
                atmost = BplOr(eq, less);

            }
            else if (MutateCSharp.Schemata489.ReplaceBinExprOp_12(209L, () => ty0.IsTypeParameter, () => ty0.IsAbstractType))
            {
                eq = Bpl.Expr.Eq(e0, e1);
                less = Bpl.Expr.False;
                atmost = BplOr(less, eq);

            }
            else
            {
                // reference type
                Contract.Assert(ty0.IsRefType);  // otherwise, unexpected type
                var b0 = Bpl.Expr.Neq(e0, predef.Null);
                var b1 = Bpl.Expr.Neq(e1, predef.Null);
                eq = BplIff(b0, b1);
                less = BplAnd(Bpl.Expr.Not(b0), b1);
                atmost = BplImp(b0, b1);
            }
        }
    }
}
