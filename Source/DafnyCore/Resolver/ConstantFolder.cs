//-----------------------------------------------------------------------------
//
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Diagnostics.Contracts;
using JetBrains.Annotations;
using static Microsoft.Dafny.ResolutionErrors;
namespace MutateCSharp
{
    internal class Schemata394
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT394");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.UnaryOpExpr.ResolvedOpcode argument1, Microsoft.Dafny.UnaryOpExpr.ResolvedOpcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, Microsoft.BaseTypes.BigDec argument1, Microsoft.BaseTypes.BigDec argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, System.Numerics.BigInteger argument1, System.Numerics.BigInteger argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.Type argument1, Microsoft.Dafny.Type argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, System.Numerics.BigInteger argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.NewtypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.Type argument1, Microsoft.Dafny.BoolType argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBinExprOp_10(long mutantId, System.Numerics.BigInteger argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, System.Numerics.BigInteger argument1, System.Numerics.BigInteger argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, int argument1, System.Numerics.BigInteger argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, int argument1, System.Numerics.BigInteger argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 <= argument2;
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

    }
}

namespace Microsoft.Dafny
{
    public class ConstantFolder
    {
        /// <summary>
        /// Returns the largest value that can be stored in bitvector type "t".
        /// </summary>
        public static BigInteger MaxBv(Type t)
        {
            Contract.Requires(t != null);
            Contract.Requires(t.IsBitVectorType);
            return MaxBv(t.AsBitVectorType.Width);
        }

        /// <summary>
        /// Returns the largest value that can be stored in bitvector type of "bits" width.
        /// </summary>
        public static BigInteger MaxBv(int bits)
        {
            Contract.Requires(0 <= bits);
            return BigInteger.Pow(new BigInteger(MutateCSharp.Schemata394.ReplaceNumericConstant_0(1L, 2)), bits) - BigInteger.One;
        }

        /// <summary>
        /// Folds "e" into an integer literal, if possible.
        /// Returns "null" if not possible (or not easy).
        /// </summary>
        public static BigInteger? TryFoldInteger(Expression e)
        {
            var ee = GetAnyConst(e.Resolved ?? e, new Stack<ConstantField>());
            return ee as BigInteger?;
        }

        public static bool IsUnconstrainedType(Type t)
        {
            return MutateCSharp.Schemata394.ReplaceBinExprOp_1(5L, AsUnconstrainedType(t), null);
        }

        /// <summary>
        /// Returns null if the argument is a constrained newtype (recursively)
        /// Returns the transitive base type if the argument is recursively unconstrained
        /// </summary>
        public static Type AsUnconstrainedType(Type t)
        {
            while (MutateCSharp.Schemata394.ReplaceBooleanConstant_2(6L, true))
            {
                if (MutateCSharp.Schemata394.ReplaceBinExprOp_3(7L, t.AsNewtype, null))
                {
                    return t;
                }

                if (MutateCSharp.Schemata394.ReplaceBinExprOp_4(8L, t.AsNewtype.Constraint, null))
                {
                    return null;
                }

                t = t.AsNewtype.BaseType;
            }

            return default;
        }

        /// <summary>
        /// Try to fold "e" into constants.
        /// Return null if folding is not possible.
        /// If an operation is undefined (divide by zero, conversion out of range, etc.), then null is returned.
        ///
        /// Caution: This method defines the semantics of some expressions. It is important that these be the same
        /// as what the verifier and compilers use. For example, it is essential that no undefined expressions
        /// are folded. Yet, this method is likely to receive much less testing than the verifier and compiler,
        /// since it's not common for all of these expressions to appear in expressions where folding is applied.
        /// </summary>
        [CanBeNull]
        static object GetAnyConst(Expression e, Stack<ConstantField> constants)
        {
            e = e.Resolved;

            if (e is LiteralExpr l)
            {
                return l.Value;

            }
            else if (e is UnaryOpExpr un)
            {
                if (MutateCSharp.Schemata394.ReplaceBinExprOp_5(9L, un.ResolvedOp, UnaryOpExpr.ResolvedOpcode.BoolNot) && GetAnyConst(un.E, constants) is bool b)
                {
                    return !b;
                }
                if (MutateCSharp.Schemata394.ReplaceBinExprOp_5(10L, un.ResolvedOp, UnaryOpExpr.ResolvedOpcode.BVNot) && GetAnyConst(un.E, constants) is BigInteger i)
                {
                    return ((BigInteger.One << un.Type.AsBitVectorType.Width) - 1) ^ i;
                }
                // TODO: This only handles strings; generalize to other collections?
                if (MutateCSharp.Schemata394.ReplaceBinExprOp_5(11L, un.ResolvedOp, UnaryOpExpr.ResolvedOpcode.SeqLength) && GetAnyConst(un.E, constants) is string ss)
                {
                    return (BigInteger)(ss.Length);
                }

            }
            else if (e is MemberSelectExpr m)
            {
                if (m.Member is ConstantField { IsStatic: true, Rhs: { } } c)
                {
                    // This aspect of type resolution happens before the check for cyclic references
                    // so we have to do a check here as well. If cyclic, null is silently returned,
                    // counting on the later error message to alert the user.
                    if (constants.Contains(c))
                    {
                        return null;
                    }
                    constants.Push(c);
                    var o = GetAnyConst(c.Rhs, constants);
                    constants.Pop();
                    return o;
                }
                else if (m.Member is SpecialField { Name: "Floor" })
                {
                    var ee = GetAnyConst(m.Obj, constants);
                    if (MutateCSharp.Schemata394.ReplaceBinExprOp_6(12L, () => ee != null, () => m.Obj.Type.IsNumericBased(Type.NumericPersuasion.Real)))
                    {
                        ((BaseTypes.BigDec)ee).FloorCeiling(out var f, out _);
                        return f;
                    }
                }

            }
            else if (e is BinaryExpr bin)
            {
                var e0 = GetAnyConst(bin.E0, constants);
                if (e0 == null)
                {
                    return null;
                }
                var e1 = GetAnyConst(bin.E1, constants);

                if (MutateCSharp.Schemata394.ReplaceBinExprOp_6(20L, () => MutateCSharp.Schemata394.ReplaceBinExprOp_7(18L, bin.E0.Type, Type.Bool), () => MutateCSharp.Schemata394.ReplaceBinExprOp_7(19L, bin.E1.Type, Type.Bool)))
                {
                    return FoldBoolean(bin, (bool)e0, (bool?)e1);
                }

                if (e1 == null)
                {
                    return null;
                }

                if (MutateCSharp.Schemata394.ReplaceBinExprOp_6(26L, () => bin.E0.Type.IsNumericBased(Type.NumericPersuasion.Int), () => bin.E1.Type.IsNumericBased(Type.NumericPersuasion.Int)))
                {
                    return FoldInteger(bin, (BigInteger)e0, (BigInteger)e1);
                }
                else if (MutateCSharp.Schemata394.ReplaceBinExprOp_6(38L, () => bin.E0.Type.IsBitVectorType, () => (MutateCSharp.Schemata394.ReplaceBinExprOp_8(32L, () => bin.E1.Type.IsBitVectorType, () => bin.E1.Type.IsNumericBased(Type.NumericPersuasion.Int)))))
                {
                    return FoldBitvector(bin, (BigInteger)e0, (BigInteger)e1);
                }
                else if (MutateCSharp.Schemata394.ReplaceBinExprOp_6(44L, () => bin.E0.Type.IsNumericBased(Type.NumericPersuasion.Real), () => bin.E1.Type.IsNumericBased(Type.NumericPersuasion.Real)))
                {
                    return FoldReal(bin, (BaseTypes.BigDec)e0, (BaseTypes.BigDec)e1);
                }
                else if (e0 is string s0 && e1 is string s1)
                {
                    return FoldCharOrString(bin, s0, s1);
                }

            }
            else if (e is ConversionExpr ce)
            {
                var o = GetAnyConst(ce.E, constants);
                if (o != null)
                {
                    return FoldConversion(o, ce.E.Type, ce.ToType);
                }

            }
            else if (e is SeqSelectExpr sse)
            {
                if (GetAnyConst(sse.Seq, constants) is string b && GetAnyConst(sse.E0, constants) is BigInteger index)
                {
                    if (MutateCSharp.Schemata394.ReplaceBinExprOp_6(66L, () => MutateCSharp.Schemata394.ReplaceBinExprOp_6(58L, () => MutateCSharp.Schemata394.ReplaceBinExprOp_9(54L, MutateCSharp.Schemata394.ReplaceNumericConstant_0(50L, 0), index), () => MutateCSharp.Schemata394.ReplaceBinExprOp_10(56L, index, b.Length)), () => MutateCSharp.Schemata394.ReplaceBinExprOp_11(64L, index, int.MaxValue)))
                    {
                        return b[(int)index].ToString();
                    }
                }

            }
            else if (e is ITEExpr ite)
            {
                if (GetAnyConst(ite.Test, constants) is bool b)
                {
                    return b ? GetAnyConst(ite.Thn, constants) : GetAnyConst(ite.Els, constants);
                }
            }

            return null;
        }

        private static bool? FoldBoolean(BinaryExpr bin, bool e0, bool? e1)
        {
            switch (bin.ResolvedOp)
            {
                case BinaryExpr.ResolvedOpcode.And:
                    if (e0)
                    {
                        return e1;
                    }
                    else
                    {
                        return false;
                    }

                    break;
                case BinaryExpr.ResolvedOpcode.Or:
                    if (e0)
                    {
                        return true;
                    }
                    else
                    {
                        return e1;
                    }

                    break;
                case BinaryExpr.ResolvedOpcode.Imp:
                    if (e0)
                    {
                        return e1;
                    }
                    else
                    {
                        return true;
                    }

                    break;
                case BinaryExpr.ResolvedOpcode.Iff:
                case BinaryExpr.ResolvedOpcode.EqCommon:
                    if (e1 != null)
                    {
                        return e0 == (bool)e1;
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.NeqCommon:
                    if (e1 != null)
                    {
                        return e0 != (bool)e1;
                    }
                    break;
                    break;
            }
            return null;
        }

        private static object FoldInteger(BinaryExpr bin, BigInteger e0, BigInteger e1)
        {
            var isUnconstrained = IsUnconstrainedType(bin.Type);

            switch (bin.ResolvedOp)
            {
                case BinaryExpr.ResolvedOpcode.Add:
                    if (isUnconstrained)
                    {
                        return e0 + e1;
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Sub:
                    if (isUnconstrained)
                    {
                        return e0 - e1;
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Mul:
                    if (isUnconstrained)
                    {
                        return e0 * e1;
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Div:
                    if (isUnconstrained && e1 != 0)
                    {
                        // use Euclidean division
                        var d = e0 / e1;
                        if (0 <= e0 || e0 == d * e1)
                        {
                            return d;
                        }
                        else if (0 < e1)
                        {
                            return d - 1;
                        }
                        else
                        {
                            return d + 1;
                        }
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Mod:
                    if (isUnconstrained && e1 != 0)
                    {
                        // use Euclidean modulo
                        var a = BigInteger.Abs(e1);
                        var d = e0 % a;
                        return 0 <= e0 ? d : d + a;
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Gt:
                    return e0 > e1;
                    break;
                case BinaryExpr.ResolvedOpcode.Ge:
                    return e0 >= e1;
                    break;
                case BinaryExpr.ResolvedOpcode.Lt:
                    return e0 < e1;
                    break;
                case BinaryExpr.ResolvedOpcode.Le:
                    return e0 <= e1;
                    break;
                case BinaryExpr.ResolvedOpcode.EqCommon:
                    return e0 == e1;
                    break;
                case BinaryExpr.ResolvedOpcode.NeqCommon:
                    return e0 != e1;
                    break;
            }
            return null;
        }

        private static object FoldBitvector(BinaryExpr bin, BigInteger e0, BigInteger e1)
        {
            Contract.Assert(0 <= e0);

            switch (bin.ResolvedOp)
            {
                case BinaryExpr.ResolvedOpcode.Add:
                    // modular arithmetic
                    return (e0 + e1) & MaxBv(bin.Type);
                    break;
                case BinaryExpr.ResolvedOpcode.Sub:
                    // modular arithmetic
                    return (e0 - e1) & MaxBv(bin.Type);
                    break;
                case BinaryExpr.ResolvedOpcode.Mul:
                    // modular arithmetic
                    return (e0 * e1) & MaxBv(bin.Type);
                    break;
                case BinaryExpr.ResolvedOpcode.Div:
                    if (e1 != 0)
                    {
                        return e0 / e1;
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Mod:
                    if (e1 != 0)
                    {
                        return e0 % e1;
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.BitwiseAnd:
                    return e0 & e1;
                    break;
                case BinaryExpr.ResolvedOpcode.BitwiseOr:
                    return e0 | e1;
                    break;
                case BinaryExpr.ResolvedOpcode.BitwiseXor:
                    return e0 ^ e1;
                    break;
                case BinaryExpr.ResolvedOpcode.LeftShift:
                    if (0 <= e1 && e1 <= bin.Type.AsBitVectorType.Width)
                    {
                        return (e0 << (int)e1) & MaxBv(bin.E0.Type);
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.RightShift:
                    if (0 <= e1 && e1 <= bin.Type.AsBitVectorType.Width)
                    {
                        return e0 >> (int)e1;
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Gt:
                    return e0 > e1;
                    break;
                case BinaryExpr.ResolvedOpcode.Ge:
                    return e0 >= e1;
                    break;
                case BinaryExpr.ResolvedOpcode.Lt:
                    return e0 < e1;
                    break;
                case BinaryExpr.ResolvedOpcode.Le:
                    return e0 <= e1;
                    break;
                case BinaryExpr.ResolvedOpcode.EqCommon:
                    return e0 == e1;
                    break;
                case BinaryExpr.ResolvedOpcode.NeqCommon:
                    return e0 != e1;
                    break;
            }
            return null;
        }

        private static object FoldReal(BinaryExpr bin, BaseTypes.BigDec e0, BaseTypes.BigDec e1)
        {
            var isUnconstrained = IsUnconstrainedType(bin.Type);

            switch (bin.ResolvedOp)
            {
                case BinaryExpr.ResolvedOpcode.Add:
                    if (isUnconstrained)
                    {
                        return e0 + e1;
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Sub:
                    if (isUnconstrained)
                    {
                        return e0 - e1;
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Mul:
                    if (isUnconstrained)
                    {
                        return e0 * e1;
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Gt:
                    return e0 > e1;
                    break;
                case BinaryExpr.ResolvedOpcode.Ge:
                    return e0 >= e1;
                    break;
                case BinaryExpr.ResolvedOpcode.Lt:
                    return e0 < e1;
                    break;
                case BinaryExpr.ResolvedOpcode.Le:
                    return e0 <= e1;
                    break;
                case BinaryExpr.ResolvedOpcode.EqCommon:
                    return e0 == e1;
                    break;
                case BinaryExpr.ResolvedOpcode.NeqCommon:
                    return e0 != e1;
                    break;
            }
            return null;
        }

        private static object FoldCharOrString(BinaryExpr bin, string e0, string e1)
        {
            if (bin.E0.Type.IsCharType)
            {
                Contract.Assert(bin.E1.Type.IsCharType);
                Contract.Assert(e0.Length == 1);
                Contract.Assert(e1.Length == 1);
            }

            switch (bin.ResolvedOp)
            {
                case BinaryExpr.ResolvedOpcode.Concat:
                    return e0 + e1;
                    break;
                case BinaryExpr.ResolvedOpcode.GtChar:
                    Contract.Assert(bin.E0.Type.IsCharType);
                    return e0[0] > e1[0];
                    break;
                case BinaryExpr.ResolvedOpcode.GeChar:
                    Contract.Assert(bin.E0.Type.IsCharType);
                    return e0[0] >= e1[0];
                    break;
                case BinaryExpr.ResolvedOpcode.LtChar:
                    Contract.Assert(bin.E0.Type.IsCharType);
                    return e0[0] < e1[0];
                    break;
                case BinaryExpr.ResolvedOpcode.LeChar:
                    Contract.Assert(bin.E0.Type.IsCharType);
                    return e0[0] <= e1[0];
                    break;
                case BinaryExpr.ResolvedOpcode.ProperPrefix:
                    return e1.StartsWith(e0) && e0 != e1; ;
                    break;
                case BinaryExpr.ResolvedOpcode.Prefix:
                    return e1.StartsWith(e0);
                    break;
                case BinaryExpr.ResolvedOpcode.EqCommon:
                    Contract.Assert(bin.E0.Type.IsCharType); // the string case is handled in SeqEq
                    return e0[0] == e1[0];
                    break;
                case BinaryExpr.ResolvedOpcode.NeqCommon:
                    Contract.Assert(bin.E0.Type.IsCharType); // the string case is handled in SeqEq
                    return e0[0] != e1[0];
                    break;
                case BinaryExpr.ResolvedOpcode.SeqEq:
                    return e0 == e1;
                    break;
                case BinaryExpr.ResolvedOpcode.SeqNeq:
                    return e0 != e1;
                    break;
            }
            return null;
        }

        private static object FoldConversion(object value, Type fromType, Type toType)
        {
            if (MutateCSharp.Schemata394.ReplaceBinExprOp_12(72L, fromType, toType))
            {
                return value;
            }
            if (!IsUnconstrainedType(toType))
            {
                return null;
            }

            if (MutateCSharp.Schemata394.ReplaceBinExprOp_6(73L, () => fromType.IsNumericBased(Type.NumericPersuasion.Real), () => toType.IsBitVectorType))
            {
                ((BaseTypes.BigDec)value).FloorCeiling(out var ff, out _);
                if (MutateCSharp.Schemata394.ReplaceBinExprOp_8(87L, () => MutateCSharp.Schemata394.ReplaceBinExprOp_10(83L, ff, MutateCSharp.Schemata394.ReplaceNumericConstant_0(79L, 0)), () => MutateCSharp.Schemata394.ReplaceBinExprOp_13(85L, ff, MaxBv(toType))))
                {
                    return null; // Out of range
                }
                if (MutateCSharp.Schemata394.ReplaceBinExprOp_14(93L, ((BaseTypes.BigDec)value), BaseTypes.BigDec.FromBigInt(ff)))
                {
                    return null; // Out of range
                }
                return ff;
            }

            if (MutateCSharp.Schemata394.ReplaceBinExprOp_6(94L, () => fromType.IsNumericBased(Type.NumericPersuasion.Real), () => toType.IsNumericBased(Type.NumericPersuasion.Int)))
            {
                ((BaseTypes.BigDec)value).FloorCeiling(out var ff, out _);
                if (MutateCSharp.Schemata394.ReplaceBinExprOp_14(100L, ((BaseTypes.BigDec)value), BaseTypes.BigDec.FromBigInt(ff)))
                {
                    return null; // Argument not an integer
                }
                return ff;
            }

            if (MutateCSharp.Schemata394.ReplaceBinExprOp_6(101L, () => fromType.IsBitVectorType, () => toType.IsNumericBased(Type.NumericPersuasion.Int)))
            {
                return value;
            }

            if (MutateCSharp.Schemata394.ReplaceBinExprOp_6(107L, () => fromType.IsBitVectorType, () => toType.IsNumericBased(Type.NumericPersuasion.Real)))
            {
                return BaseTypes.BigDec.FromBigInt((BigInteger)value);
            }

            if (MutateCSharp.Schemata394.ReplaceBinExprOp_6(113L, () => fromType.IsNumericBased(Type.NumericPersuasion.Int), () => toType.IsBitVectorType))
            {
                var b = (BigInteger)value;
                if (MutateCSharp.Schemata394.ReplaceBinExprOp_8(127L, () => MutateCSharp.Schemata394.ReplaceBinExprOp_10(123L, b, MutateCSharp.Schemata394.ReplaceNumericConstant_0(119L, 0)), () => MutateCSharp.Schemata394.ReplaceBinExprOp_13(125L, b, MaxBv(toType))))
                {
                    return null; // Argument out of range
                }
                return value;
            }

            if (MutateCSharp.Schemata394.ReplaceBinExprOp_6(133L, () => fromType.IsNumericBased(Type.NumericPersuasion.Int), () => toType.IsNumericBased(Type.NumericPersuasion.Int)))
            {
                // This case includes int-based newtypes to int-based new types
                return value;
            }

            if (MutateCSharp.Schemata394.ReplaceBinExprOp_6(139L, () => fromType.IsNumericBased(Type.NumericPersuasion.Real), () => toType.IsNumericBased(Type.NumericPersuasion.Real)))
            {
                // This case includes real-based newtypes to real-based new types
                return value;
            }

            if (MutateCSharp.Schemata394.ReplaceBinExprOp_6(145L, () => fromType.IsBitVectorType, () => toType.IsBitVectorType))
            {
                var b = (BigInteger)value;
                if (MutateCSharp.Schemata394.ReplaceBinExprOp_8(159L, () => MutateCSharp.Schemata394.ReplaceBinExprOp_10(155L, b, MutateCSharp.Schemata394.ReplaceNumericConstant_0(151L, 0)), () => MutateCSharp.Schemata394.ReplaceBinExprOp_13(157L, b, MaxBv(toType))))
                {
                    return null; // Argument out of range
                }
                return value;
            }

            if (MutateCSharp.Schemata394.ReplaceBinExprOp_6(165L, () => fromType.IsNumericBased(Type.NumericPersuasion.Int), () => toType.IsNumericBased(Type.NumericPersuasion.Real)))
            {
                return BaseTypes.BigDec.FromBigInt((BigInteger)value);
            }

            if (MutateCSharp.Schemata394.ReplaceBinExprOp_6(171L, () => fromType.IsCharType, () => toType.IsNumericBased(Type.NumericPersuasion.Int)))
            {
                var c = ((String)value)[MutateCSharp.Schemata394.ReplaceNumericConstant_0(177L, 0)];
                return new BigInteger(((string)value)[MutateCSharp.Schemata394.ReplaceNumericConstant_0(181L, 0)]);
            }

            if (MutateCSharp.Schemata394.ReplaceBinExprOp_6(185L, () => fromType.IsCharType, () => toType.IsBitVectorType))
            {
                var c = ((String)value)[MutateCSharp.Schemata394.ReplaceNumericConstant_0(191L, 0)];
                if (MutateCSharp.Schemata394.ReplaceBinExprOp_15(195L, (int)c, MaxBv(toType)))
                {
                    return null; // Argument out of range
                }
                return new BigInteger(((string)value)[MutateCSharp.Schemata394.ReplaceNumericConstant_0(197L, 0)]);
            }

            if (MutateCSharp.Schemata394.ReplaceBinExprOp_6(207L, () => (MutateCSharp.Schemata394.ReplaceBinExprOp_8(201L, () => fromType.IsNumericBased(Type.NumericPersuasion.Int), () => fromType.IsBitVectorType)), () => toType.IsCharType))
            {
                var b = (BigInteger)value;
                if (MutateCSharp.Schemata394.ReplaceBinExprOp_8(221L, () => MutateCSharp.Schemata394.ReplaceBinExprOp_16(213L, b, BigInteger.Zero), () => MutateCSharp.Schemata394.ReplaceBinExprOp_13(219L, b, new BigInteger(MutateCSharp.Schemata394.ReplaceNumericConstant_0(215L, 65535)))))
                {
                    return null; // Argument out of range
                }
                return ((char)(int)b).ToString();
            }

            if (MutateCSharp.Schemata394.ReplaceBinExprOp_6(227L, () => fromType.IsCharType, () => toType.IsNumericBased(Type.NumericPersuasion.Real)))
            {
                return BaseTypes.BigDec.FromInt(((string)value)[MutateCSharp.Schemata394.ReplaceNumericConstant_0(233L, 0)]);
            }

            if (MutateCSharp.Schemata394.ReplaceBinExprOp_6(237L, () => fromType.IsNumericBased(Type.NumericPersuasion.Real), () => toType.IsCharType))
            {
                ((BaseTypes.BigDec)value).FloorCeiling(out var ff, out _);
                if (MutateCSharp.Schemata394.ReplaceBinExprOp_14(243L, ((BaseTypes.BigDec)value), BaseTypes.BigDec.FromBigInt(ff)))
                {
                    return null; // Argument not an integer
                }
                if (MutateCSharp.Schemata394.ReplaceBinExprOp_8(252L, () => MutateCSharp.Schemata394.ReplaceBinExprOp_16(244L, ff, BigInteger.Zero), () => MutateCSharp.Schemata394.ReplaceBinExprOp_13(250L, ff, new BigInteger(MutateCSharp.Schemata394.ReplaceNumericConstant_0(246L, 65535)))))
                {
                    return null; // Argument out of range
                }
                return ((char)(int)ff).ToString();
            }

            return null;
        }
    }
}
