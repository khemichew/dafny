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
using System.IO;
using System.Diagnostics.Contracts;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using JetBrains.Annotations;
using static Microsoft.Dafny.ConcreteSyntaxTreeUtils;
namespace MutateCSharp
{
    internal class Schemata236
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT236");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_37(long mutantId, Microsoft.Dafny.Function argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_50(long mutantId, Microsoft.Dafny.UnaryOpExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_39(long mutantId, Microsoft.Dafny.Compilers.DatatypeWrapperEraser.MemberCompileStatus argument1, Microsoft.Dafny.Compilers.DatatypeWrapperEraser.MemberCompileStatus argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_51(long mutantId, Microsoft.Dafny.UnaryOpExpr.Opcode argument1, Microsoft.Dafny.UnaryOpExpr.Opcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_31(long mutantId, long argument1, System.Numerics.BigInteger argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, Microsoft.Dafny.NewtypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_45(long mutantId, Microsoft.Dafny.DatatypeCtor argument1, Microsoft.Dafny.DatatypeCtor argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_24(long mutantId, Microsoft.Dafny.ArrayClassDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_26(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Type> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static int ReplaceBinExprOp_10(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_21(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_34(long mutantId, System.Numerics.BigInteger argument1, long argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBooleanConstant_3(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_32(long mutantId, System.Numerics.BigInteger argument1, long argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 <= argument2;
        }

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_28(long mutantId, Microsoft.Dafny.TypeParameter.ParentType argument1, Microsoft.Dafny.TopLevelDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_23(long mutantId, Microsoft.Dafny.TopLevelDeclWithMembers argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_46(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_49(long mutantId, Microsoft.Dafny.Type argument1, Microsoft.Dafny.Type argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_30(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.TypeParameter> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static ulong ReplaceNumericConstant_41(long mutantId, ulong argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 2)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, Microsoft.Dafny.TypeParameter.TPVariance argument1, Microsoft.Dafny.TypeParameter.TPVariance argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, Microsoft.Dafny.NativeType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_25(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_44(long mutantId, System.Numerics.BigInteger argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 >= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 >= argument2;
        }

        internal static bool ReplaceBinExprOp_35(long mutantId, Microsoft.Dafny.NativeType.Selection argument1, Microsoft.Dafny.NativeType.Selection argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.NativeType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_33(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_6(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_48(long mutantId, Microsoft.Dafny.CollectionType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static ulong ReplaceBinExprOp_43(long mutantId, ulong argument1, ulong argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 6)) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 ^ argument2; }
            return argument1 - argument2;
        }

        internal static bool ReplaceBinExprOp_40(long mutantId, Microsoft.Dafny.SeqType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_47(long mutantId, int argument1, System.Numerics.BigInteger argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_27(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.TypeParameter> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static ulong ReplaceBinExprOp_42(long mutantId, ulong argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 >> argument2; }
            return argument1 << argument2;
        }

        internal static bool ReplaceBinExprOp_52(long mutantId, Microsoft.Dafny.MemberSelectExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.SubsetTypeDecl.WKind argument1, Microsoft.Dafny.SubsetTypeDecl.WKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_14(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_38(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_36(long mutantId, System.Numerics.BigInteger argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.Method argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_29(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceBinExprOp_11(long mutantId, int argument1, int argument2)
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

    }
}

namespace Microsoft.Dafny.Compilers
{
    public class JavaCodeGenerator : SinglePassCodeGenerator
    {
        public JavaCodeGenerator(DafnyOptions options, ErrorReporter reporter) : base(options, reporter)
        {
            IntSelect = MutateCSharp.Schemata236.ReplaceStringConstant_0(1L, ",java.math.BigInteger");
            LambdaExecute = MutateCSharp.Schemata236.ReplaceStringConstant_0(2L, ".apply");
        }

        public override IReadOnlySet<Feature> UnsupportedFeatures => new HashSet<Feature> {
      Feature.Iterators,
      Feature.SubsetTypeTests,
      Feature.MethodSynthesis,
      Feature.TuplesWiderThan20,
      Feature.ArraysWithMoreThan16Dims,
      Feature.ArrowsWithMoreThan16Arguments,
      Feature.RuntimeCoverageReport,
    };

        const string DafnySetClass = "dafny.DafnySet";
        const string DafnyMultiSetClass = "dafny.DafnyMultiset";
        const string DafnySeqClass = "dafny.DafnySequence";
        const string DafnyMapClass = "dafny.DafnyMap";

        const string DafnyBigRationalClass = "dafny.BigRational";
        const string DafnyEuclideanClass = "dafny.DafnyEuclidean";
        const string DafnyHelpersClass = "dafny.Helpers";
        const string DafnyTypeDescriptor = "dafny.TypeDescriptor";
        string FormatDefaultTypeParameterValue(TypeParameter tp) => FormatDefaultTypeParameterValueName(tp.GetCompileName(Options));
        static string FormatDefaultTypeParameterValueName(string tpName) => $"_default_{tpName}";

        const string DafnyFunctionIfacePrefix = "dafny.Function";
        const string DafnyMultiArrayClassPrefix = "dafny.Array";
        const string DafnyTupleClassPrefix = "dafny.Tuple";

        string DafnyMultiArrayClass(int dim) => DafnyMultiArrayClassPrefix + dim;
        string DafnyTupleClass(int size) => DafnyTupleClassPrefix + size;

        string DafnyFunctionIface(int arity) => MutateCSharp.Schemata236.ReplaceBinExprOp_2(7L, arity, MutateCSharp.Schemata236.ReplaceNumericConstant_1(3L, 1)) ? MutateCSharp.Schemata236.ReplaceStringConstant_0(12L, "java.util.function.Function") : DafnyFunctionIfacePrefix + arity;

        static string FormatExternBaseClassName(string externClassName) =>
          $"_ExternBase_{externClassName}";
        static string FormatTypeDescriptorVariable(string typeVarName) =>
          $"_td_{typeVarName}";
        string FormatTypeDescriptorVariable(TypeParameter tp) =>
          FormatTypeDescriptorVariable(tp.GetCompileName(Options));

        const string TypeMethodName = "_typeDescriptor";

        private string ModuleName;
        private string ModulePath;
        private int FileCount = MutateCSharp.Schemata236.ReplaceNumericConstant_1(13L, 0);
        private Import ModuleImport;

        private readonly List<Import> Imports = new List<Import>();

        //RootImportWriter writes additional imports to the main file.
        private ConcreteSyntaxTree RootImportWriter;

        public record Import(string Name, string Path);

        private readonly List<GenericCompilationInstrumenter> Instrumenters = new();

        public void AddInstrumenter(GenericCompilationInstrumenter compilationInstrumenter)
        {
            Instrumenters.Add(compilationInstrumenter);
        }

        protected override bool UseReturnStyleOuts(Method m, int nonGhostOutCount) => MutateCSharp.Schemata236.ReplaceBooleanConstant_3(17L, true);


        protected override bool SupportsAmbiguousTypeDecl => MutateCSharp.Schemata236.ReplaceBooleanConstant_3(18L, false);
        protected override bool SupportsProperties => MutateCSharp.Schemata236.ReplaceBooleanConstant_3(19L, false);

        public enum JavaNativeType { Byte, Short, Int, Long }

        private static JavaNativeType AsJavaNativeType(NativeType.Selection sel)
        {
            switch (sel)
            {
                case NativeType.Selection.Byte:
                case NativeType.Selection.SByte:
                    return JavaNativeType.Byte;
                    break;
                case NativeType.Selection.Short:
                case NativeType.Selection.UShort:
                    return JavaNativeType.Short;
                    break;
                case NativeType.Selection.Int:
                case NativeType.Selection.UInt:
                    return JavaNativeType.Int;
                    break;
                case NativeType.Selection.Long:
                case NativeType.Selection.ULong:
                    return JavaNativeType.Long;
                    break;
                default:
                    Contract.Assert(false);
                    throw new cce.UnreachableException();
                    break;
            }

            return default;
        }

        private static bool IsUnsignedJavaNativeType(NativeType nt)
        {
            Contract.Requires(nt != null);
            switch (nt.Sel)
            {
                case NativeType.Selection.Byte:
                case NativeType.Selection.UShort:
                case NativeType.Selection.UInt:
                case NativeType.Selection.ULong:
                    return true;
                    break;
                default:
                    return false;
                    break;
            }

            return default;
        }

        private static JavaNativeType AsJavaNativeType(NativeType nt)
        {
            return AsJavaNativeType(nt.Sel);
        }

        private JavaNativeType? AsJavaNativeType(Type type)
        {
            var nt = AsNativeType(type);
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_4(20L, nt, null))
            {
                return null;
            }
            else
            {
                return AsJavaNativeType(nt);
            }

            return default;
        }

        protected override void DeclareSpecificOutCollector(string collectorVarName, ConcreteSyntaxTree wr, List<Type> formalTypes, List<Type> lhsTypes)
        {
            // If the method returns an array of parameter type, and we're assigning
            // to a variable with a more specific type, we need to insert a cast:
            //
            // Array<Integer> outcollector42 = obj.Method(); // <-- you are here
            // int[] out43 = (int[]) outcollector42.unwrap();
            var returnedTypes = new List<string>();
            Contract.Assert(formalTypes.Count == lhsTypes.Count);
            for (var i = MutateCSharp.Schemata236.ReplaceNumericConstant_1(21L, 0); MutateCSharp.Schemata236.ReplaceBinExprOp_5(25L, i, formalTypes.Count); MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(30L, ref i))
            {
                var formalType = formalTypes[i];
                var lhsType = lhsTypes[i];
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(46L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_7(40L, () => formalType.IsArrayType, () => MutateCSharp.Schemata236.ReplaceBinExprOp_2(35L, formalType.AsArrayType.Dims, MutateCSharp.Schemata236.ReplaceNumericConstant_1(31L, 1))), () => UserDefinedType.ArrayElementType(formalType).IsTypeParameter))
                {
                    returnedTypes.Add(MutateCSharp.Schemata236.ReplaceStringConstant_0(52L, "java.lang.Object"));
                }
                else
                {
                    returnedTypes.Add(TypeName(lhsType, wr, Token.NoToken, boxed: MutateCSharp.Schemata236.ReplaceBinExprOp_8(57L, formalTypes.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(53L, 1))));
                }
            }
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_8(66L, formalTypes.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(62L, 1)))
            {
                wr.Write($"{DafnyTupleClass(formalTypes.Count)}<{Util.Comma(returnedTypes)}> {collectorVarName} = ");
            }
            else
            {
                wr.Write($"{returnedTypes[MutateCSharp.Schemata236.ReplaceNumericConstant_1(71L, 0)]} {collectorVarName} = ");
            }
        }
        protected override void EmitCastOutParameterSplits(string outCollector, List<string> lhsNames,
          ConcreteSyntaxTree wr, List<Type> formalTypes, List<Type> lhsTypes, IToken tok)
        {
            var wOuts = new List<ConcreteSyntaxTree>();
            for (var i = MutateCSharp.Schemata236.ReplaceNumericConstant_1(75L, 0); MutateCSharp.Schemata236.ReplaceBinExprOp_5(79L, i, lhsNames.Count); MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(84L, ref i))
            {
                wr.Write($"{lhsNames[i]} = ");
                //
                // Suppose we have:
                //
                //   method Foo<A>(a : A) returns (arr : array<A>)
                //
                // This is compiled to:
                //
                //   public <A> Object Foo(A a)
                //
                // (There's also an argument for the type descriptor, but I'm omitting
                // it for clarity.)  Foo returns Object, not A[], since A could be
                // primitive and primitives cannot be generic parameters in Java
                // (*sigh*).  So when we call it:
                //
                //   var arr : int[] := Foo(42);
                //
                // we have to add a type cast:
                //
                //   BigInteger[] arr = (BigInteger[]) Foo(new BigInteger(42));
                //
                // Things can get more complicated than this, however.  If the method returns
                // the array as part of a tuple:
                //
                //   method Foo<A>(a : A) returns (pair : (array<A>, array<A>))
                //
                // then we get:
                //
                //   public <A> Tuple2<Object, Object> Foo(A a)
                //
                // and we have to write:
                //
                //   BigInteger[] arr = (Pair<BigInteger[], BigInteger[]>) (Object) Foo(new BigInteger(42));
                //
                // (Note the extra cast to Object, since Java doesn't allow a cast to
                // change a type parameter, as that's unsound in general.  It just
                // happens to be okay here!)
                //
                // Rather than try and exhaustively check for all the circumstances
                // where a cast is necessary, for the moment we just always cast to the
                // LHS type via Object, which is redundant 99% of the time but not
                // harmful.
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_9(85L, lhsTypes[i], null))
                {
                    wr.Write($"(Object) ");
                }
                else
                {
                    wr.Write($"({TypeName(lhsTypes[i], wr, Token.NoToken)}) (Object) ");
                }

                if (MutateCSharp.Schemata236.ReplaceBinExprOp_2(90L, lhsNames.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(86L, 1)))
                {
                    wr.Write(outCollector);
                }
                else
                {
                    wr.Write($"{outCollector}.dtor__{i}()");
                }
                EndStmt(wr);
            }
        }

        protected override void EmitSeqSelect(AssignStmt s0, List<Type> tupleTypeArgsList, ConcreteSyntaxTree wr, string tup)
        {
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(95L, "("));
            var lhs = (SeqSelectExpr)s0.Lhs;
            EmitIndexCollectionUpdate(lhs.Seq.Type, out var wColl, out var wIndex, out var wValue, wr, nativeIndex: MutateCSharp.Schemata236.ReplaceBooleanConstant_3(96L, true));
            var wCoerce = EmitCoercionIfNecessary(from: NativeObjectType, to: lhs.Seq.Type, tok: s0.Tok, wr: wColl);
            wCoerce.Write($"({TypeName(lhs.Seq.Type.NormalizeExpand(), wCoerce, s0.Tok)})");
            EmitTupleSelect(tup, MutateCSharp.Schemata236.ReplaceNumericConstant_1(97L, 0), wCoerce);
            wColl.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(101L, ")"));
            var wCast = EmitCoercionToNativeInt(wIndex);
            EmitTupleSelect(tup, MutateCSharp.Schemata236.ReplaceNumericConstant_1(102L, 1), wCast);
            wValue.Write($"({TypeName(tupleTypeArgsList[MutateCSharp.Schemata236.ReplaceNumericConstant_1(106L, 2)].NormalizeExpand(), wValue, s0.Tok)})");
            EmitTupleSelect(tup, MutateCSharp.Schemata236.ReplaceNumericConstant_1(110L, 2), wValue);
            EndStmt(wr);
        }

        protected override void EmitMultiSelect(AssignStmt s0, List<Type> tupleTypeArgsList, ConcreteSyntaxTree wr, string tup, int L)
        {
            var arrayType = tupleTypeArgsList[MutateCSharp.Schemata236.ReplaceNumericConstant_1(114L, 0)];
            var rhsType = tupleTypeArgsList[MutateCSharp.Schemata236.ReplaceBinExprOp_10(122L, L, MutateCSharp.Schemata236.ReplaceNumericConstant_1(118L, 1))];

            var lhs = (MultiSelectExpr)s0.Lhs;
            var indices = new List<Action<ConcreteSyntaxTree>>();
            for (var i = MutateCSharp.Schemata236.ReplaceNumericConstant_1(131L, 0); MutateCSharp.Schemata236.ReplaceBinExprOp_5(135L, i, lhs.Indices.Count); MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(140L, ref i))
            {
                var wIndex = new ConcreteSyntaxTree();
                wIndex.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(141L, "((java.math.BigInteger)"));
                EmitTupleSelect(tup, MutateCSharp.Schemata236.ReplaceBinExprOp_11(146L, i, MutateCSharp.Schemata236.ReplaceNumericConstant_1(142L, 1)), wIndex);
                wIndex.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(155L, ")"));
                indices.Add(wr => wr.Write(wIndex.ToString()));
            }

            var (wArray, wRhs) = EmitArrayUpdate(indices, rhsType, wr);
            wArray = EmitCoercionIfNecessary(from: null, to: arrayType, tok: s0.Tok, wr: wArray);
            wArray.Write($"({TypeName(arrayType.NormalizeExpand(), wArray, s0.Tok)})");
            EmitTupleSelect(tup, MutateCSharp.Schemata236.ReplaceNumericConstant_1(156L, 0), wArray);

            wRhs.Write($"({TypeName(rhsType, wr, s0.Tok)})");
            EmitTupleSelect(tup, MutateCSharp.Schemata236.ReplaceBinExprOp_10(164L, L, MutateCSharp.Schemata236.ReplaceNumericConstant_1(160L, 1)), wRhs);

            EndStmt(wr);
        }

        protected override void WriteCast(string s, ConcreteSyntaxTree wr)
        {
            wr.Write($"({s})");
        }

        protected override ConcreteSyntaxTree EmitIngredients(ConcreteSyntaxTree wr, string ingredients, int L, string tupleTypeArgs, ForallStmt s, AssignStmt s0, Expression rhs)
        {
            var wStmts = wr.Fork();
            var wrVarInit = wr;
            wrVarInit.Write($"java.util.ArrayList<{DafnyTupleClass(L)}<{tupleTypeArgs}>> {ingredients} = ");
            Contract.Assert(L <= MaxTupleNonGhostDims);
            EmitEmptyTupleList(tupleTypeArgs, wrVarInit);
            var wrOuter = wr;
            wr = CompileGuardedLoops(s.BoundVars, s.Bounds, s.Range, wr);
            var wrTuple = EmitAddTupleToList(ingredients, tupleTypeArgs, wr);
            wrTuple.Write($"{L}<{tupleTypeArgs}>(");
            if (s0.Lhs is MemberSelectExpr lhs1)
            {
                wrTuple.Append(Expr(lhs1.Obj, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(173L, false), wStmts));
            }
            else if (s0.Lhs is SeqSelectExpr lhs2)
            {
                wrTuple.Append(Expr(lhs2.Seq, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(174L, false), wStmts));
                wrTuple.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(175L, ", "));
                TrParenExpr(lhs2.E0, wrTuple, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(176L, false), wStmts);
            }
            else
            {
                var lhs = (MultiSelectExpr)s0.Lhs;
                wrTuple.Append(Expr(lhs.Array, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(177L, false), wStmts));
                foreach (var t in lhs.Indices)
                {
                    wrTuple.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(178L, ", "));
                    TrParenExpr(t, wrTuple, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(179L, false), wStmts);
                }
            }

            wrTuple.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(180L, ", "));
            if (rhs is MultiSelectExpr)
            {
                Type t = rhs.Type.NormalizeExpand();
                wrTuple.Write($"({TypeName(t, wrTuple, rhs.tok)})");
            }

            wrTuple.Append(Expr(rhs, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(181L, false), wStmts));
            return wrOuter;
        }

        protected override void EmitHeader(Program program, ConcreteSyntaxTree wr)
        {
            if (Options.IncludeRuntime)
            {
                EmitRuntimeSource(MutateCSharp.Schemata236.ReplaceStringConstant_0(182L, "DafnyRuntimeJava"), wr);
            }
            if (Options.Get(CommonOptionBag.UseStandardLibraries))
            {
                EmitRuntimeSource(MutateCSharp.Schemata236.ReplaceStringConstant_0(183L, "DafnyStandardLibraries_java"), wr);
            }
            wr.WriteLine($"// Dafny program {program.Name} compiled into Java");
            ModuleName = MutateCSharp.Schemata236.ReplaceBinExprOp_12(184L, program.MainMethod, null) ? MutateCSharp.Schemata236.ReplaceStringConstant_0(185L, "main") : Path.GetFileNameWithoutExtension(program.Name);
            wr.WriteLine();
            // Keep the import writers so that we can import subsequent modules into the main one
            EmitImports(wr, out RootImportWriter);
            wr.WriteLine();
        }

        protected override void EmitBuiltInDecls(SystemModuleManager systemModuleManager, ConcreteSyntaxTree wr)
        {
            switch (Options.SystemModuleTranslationMode)
            {
                case CommonOptionBag.SystemModuleMode.Omit:
                    {
                        CheckCommonSytemModuleLimits(systemModuleManager);
                        return;
                    }

                    break;
                case CommonOptionBag.SystemModuleMode.OmitAllOtherModules:
                    {
                        CheckSystemModulePopulatedToCommonLimits(systemModuleManager);
                        break;
                    }

                    break;
            }

            foreach (var kv in systemModuleManager.ArrowTypeDecls)
            {
                var arity = kv.Key;
                CreateLambdaFunctionInterface(arity, wr);
            }

            foreach (var decl in systemModuleManager.SystemModule.TopLevelDecls)
            {
                if (decl is ArrayClassDecl classDecl)
                {
                    var dims = classDecl.Dims;
                    CreateDafnyArrays(dims, wr);
                }
            }
        }

        public static string TransformToClassName(string baseName)
        {
            baseName = PublicIdProtectAux(baseName);
            var sanitizedName = Regex.Replace(baseName, MutateCSharp.Schemata236.ReplaceStringConstant_0(186L, "[^_A-Za-z0-9$]"), MutateCSharp.Schemata236.ReplaceStringConstant_0(187L, "_"));
            if (!Regex.IsMatch(sanitizedName, MutateCSharp.Schemata236.ReplaceStringConstant_0(188L, "^[_A-Za-z]")))
            {
                sanitizedName = MutateCSharp.Schemata236.ReplaceStringConstant_0(189L, "_") + sanitizedName;
            }
            return sanitizedName;
        }

        public override void EmitCallToMain(Method mainMethod, string baseName, ConcreteSyntaxTree wr)
        {
            var className = TransformToClassName(baseName);
            wr = wr.NewBlock($"public class {className}");

            var companion = TypeName_Companion(UserDefinedType.FromTopLevelDeclWithAllBooleanTypeParameters(mainMethod.EnclosingClass), wr, mainMethod.tok, mainMethod);
            var wBody = wr.NewNamedBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(190L, "public static void main(String[] args)"));
            var modName = MutateCSharp.Schemata236.ReplaceBinExprOp_13(192L, mainMethod.EnclosingClass.EnclosingModuleDefinition.GetCompileName(Options), MutateCSharp.Schemata236.ReplaceStringConstant_0(191L, "_module")) ? MutateCSharp.Schemata236.ReplaceStringConstant_0(193L, "_System.") : "";
            companion = modName + companion;
            Coverage.EmitSetup(wBody);
            wBody.WriteLine($"{DafnyHelpersClass}.withHaltHandling(() -> {{ {companion}.__Main({DafnyHelpersClass}.{CharMethodQualifier}FromMainArguments(args)); }} );");
            Coverage.EmitTearDown(wBody);
        }

        void EmitImports(ConcreteSyntaxTree wr, out ConcreteSyntaxTree importWriter)
        {
            importWriter = wr.Fork();
            foreach (var import in Imports)
            {
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_14(194L, import.Name, ModuleName))
                {
                    EmitImport(import, importWriter);
                }
            }
        }

        private void EmitImport(Import import, ConcreteSyntaxTree importWriter)
        {
            importWriter.WriteLine($"import {import.Path.Replace('/', '.')}.*;");
        }

        string IdProtectModule(string moduleName)
        {
            return string.Join(MutateCSharp.Schemata236.ReplaceStringConstant_0(195L, "."), moduleName.Split(MutateCSharp.Schemata236.ReplaceStringConstant_0(196L, ".")).Select(IdProtect));
        }

        protected override ConcreteSyntaxTree CreateModule(string moduleName, bool isDefault, ModuleDefinition externModule,
          string libraryName /*?*/, ConcreteSyntaxTree wr)
        {
            moduleName = IdProtectModule(moduleName);
            if (isDefault)
            {
                // Fold the default module into the main module
                moduleName = MutateCSharp.Schemata236.ReplaceStringConstant_0(197L, "_System");
            }
            var pkgName = libraryName ?? IdProtect(moduleName);
            var path = pkgName.Replace('.', '/');
            var import = new Import(moduleName, path);
            ModuleName = IdProtect(moduleName);
            ModulePath = path;
            ModuleImport = import;
            FileCount = MutateCSharp.Schemata236.ReplaceNumericConstant_1(198L, 0);
            return wr;
        }

        protected override void FinishModule()
        {
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_8(206L, FileCount, MutateCSharp.Schemata236.ReplaceNumericConstant_1(202L, 0)))
            {
                AddImport(ModuleImport);
            }
            FileCount = MutateCSharp.Schemata236.ReplaceNumericConstant_1(211L, 0);
        }

        private void AddImport(Import import)
        {
            if (!Imports.Contains(import))
            {
                EmitImport(import, RootImportWriter);
                Imports.Add(import);
            }
        }

        protected override void DeclareSubsetType(SubsetTypeDecl sst, ConcreteSyntaxTree wr)
        {
            var cw = (ClassWriter)CreateClass(IdProtect(sst.EnclosingModuleDefinition.GetCompileName(Options)), IdName(sst), sst, wr);
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_15(215L, sst.WitnessKind, SubsetTypeDecl.WKind.Compiled))
            {
                var sw = new ConcreteSyntaxTree(cw.InstanceMemberWriter.RelativeIndentLevel);
                var wStmts = cw.InstanceMemberWriter.Fork();
                sw.Append(Expr(sst.Witness, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(216L, false), wStmts));
                var witness = sw.ToString();
                var typeName = TypeName(sst.Rhs, cw.StaticMemberWriter, sst.tok);
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_2(221L, sst.TypeArgs.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(217L, 0)))
                {
                    cw.DeclareField(MutateCSharp.Schemata236.ReplaceStringConstant_0(226L, "Witness"), sst, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(227L, true), MutateCSharp.Schemata236.ReplaceBooleanConstant_3(228L, true), sst.Rhs, sst.tok, witness, null);
                    witness = MutateCSharp.Schemata236.ReplaceStringConstant_0(229L, "Witness");
                }
                cw.StaticMemberWriter.Write($"public static {TypeParameters(sst.TypeArgs, MutateCSharp.Schemata236.ReplaceStringConstant_0(230L, " "))}{typeName} defaultValue(");
                var typeDescriptorParams = sst.TypeArgs.Where(NeedsTypeDescriptor);
                cw.StaticMemberWriter.Write(typeDescriptorParams.Comma(tp =>
                  $"{DafnyTypeDescriptor}<{tp.GetCompileName(Options)}> {FormatTypeDescriptorVariable(tp.GetCompileName(Options))}"));
                var w = cw.StaticMemberWriter.NewBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(231L, ")"));
                w.WriteLine($"return {witness};");
            }

            GenerateIsMethod(sst, cw.StaticMemberWriter);
        }

        public class ClassWriter : IClassWriter
        {
            public readonly JavaCodeGenerator CodeGenerator;
            public readonly ConcreteSyntaxTree InstanceMemberWriter;
            public readonly ConcreteSyntaxTree StaticMemberWriter;
            public readonly ConcreteSyntaxTree CtorBodyWriter;

            public ClassWriter(JavaCodeGenerator codeGenerator, ConcreteSyntaxTree instanceMemberWriter, ConcreteSyntaxTree ctorBodyWriter, ConcreteSyntaxTree staticMemberWriter = null)
            {
                Contract.Requires(codeGenerator != null);
                Contract.Requires(instanceMemberWriter != null);
                this.CodeGenerator = codeGenerator;
                this.InstanceMemberWriter = instanceMemberWriter;
                this.CtorBodyWriter = ctorBodyWriter;
                this.StaticMemberWriter = staticMemberWriter ?? instanceMemberWriter;
            }

            public ConcreteSyntaxTree Writer(bool isStatic, bool createBody, MemberDecl/*?*/ member)
            {
                if (createBody)
                {
                    if (MutateCSharp.Schemata236.ReplaceBinExprOp_17(245L, () => isStatic, () => (MutateCSharp.Schemata236.ReplaceBinExprOp_7(239L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_7(233L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_16(232L, member, null), () => member.EnclosingClass is TraitDecl), () => CodeGenerator.NeedsCustomReceiver(member)))))
                    {
                        return StaticMemberWriter;
                    }
                }
                return InstanceMemberWriter;
            }

            public ConcreteSyntaxTree/*?*/ CreateMethod(Method m, List<TypeArgumentInstantiation> typeArgs, bool createBody, bool forBodyInheritance, bool lookasideBody)
            {
                return CodeGenerator.CreateMethod(m, typeArgs, createBody, Writer(m.IsStatic, createBody, m), forBodyInheritance, lookasideBody);
            }

            public ConcreteSyntaxTree SynthesizeMethod(Method m, List<TypeArgumentInstantiation> typeArgs, bool createBody, bool forBodyInheritance, bool lookasideBody)
            {
                throw new UnsupportedFeatureException(m.tok, Feature.MethodSynthesis);
                return default;
            }

            public ConcreteSyntaxTree/*?*/ CreateFunction(string name, List<TypeArgumentInstantiation> typeArgs, List<Formal> formals, Type resultType, IToken tok, bool isStatic, bool createBody, MemberDecl member, bool forBodyInheritance, bool lookasideBody)
            {
                return CodeGenerator.CreateFunction(name, typeArgs, formals, resultType, tok, isStatic, createBody, member, Writer(isStatic, createBody, member), forBodyInheritance, lookasideBody);
            }

            public ConcreteSyntaxTree/*?*/ CreateGetter(string name, TopLevelDecl enclosingDecl, Type resultType, IToken tok, bool isStatic, bool isConst, bool createBody, MemberDecl/*?*/ member, bool forBodyInheritance)
            {
                return CodeGenerator.CreateGetter(name, resultType, tok, isStatic, createBody, Writer(isStatic, createBody, member));
            }
            public ConcreteSyntaxTree/*?*/ CreateGetterSetter(string name, Type resultType, IToken tok, bool createBody, MemberDecl/*?*/ member, out ConcreteSyntaxTree setterWriter, bool forBodyInheritance)
            {
                return CodeGenerator.CreateGetterSetter(name, resultType, tok, createBody, out setterWriter, Writer(MutateCSharp.Schemata236.ReplaceBooleanConstant_3(251L, false), createBody, member));
            }
            public void DeclareField(string name, TopLevelDecl enclosingDecl, bool isStatic, bool isConst, Type type, IToken tok, string rhs, Field field)
            {
                CodeGenerator.DeclareField(name, isStatic, isConst, type, tok, rhs, this);
            }
            public void InitializeField(Field field, Type instantiatedFieldType, TopLevelDeclWithMembers enclosingClass)
            {
                throw new cce.UnreachableException();  // InitializeField should be called only for those compilers that set ClassesRedeclareInheritedFields to false.
            }
            public ConcreteSyntaxTree/*?*/ ErrorWriter() => InstanceMemberWriter;

            public void Finish() { }
        }

        protected override bool SupportsStaticsInGenericClasses => MutateCSharp.Schemata236.ReplaceBooleanConstant_3(252L, false);

        protected ConcreteSyntaxTree CreateGetter(string name, Type resultType, IToken tok, bool isStatic,
          bool createBody, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(253L, "public {0}{1} {2}()"), isStatic ? MutateCSharp.Schemata236.ReplaceStringConstant_0(254L, "static ") : "", TypeName(resultType, wr, tok), name);
            if (createBody)
            {
                var w = wr.NewBlock("", null, BlockStyle.NewlineBrace, BlockStyle.NewlineBrace);
                return w;
            }
            else
            {
                wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(255L, ";"));
                return null;
            }

            return default;
        }

        protected override void DeclareLocalVar(string name, Type /*?*/ type, IToken /*?*/ tok, Expression rhs,
            bool inLetExprBody, ConcreteSyntaxTree wr)
        {
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_9(256L, type, null))
            {
                type = rhs.Type;
            }
            var wStmts = wr.Fork();
            var w = DeclareLocalVar(name, type, tok, wr);
            w.Append(Expr(rhs, inLetExprBody, wStmts));
        }

        public ConcreteSyntaxTree /*?*/ CreateGetterSetter(string name, Type resultType, IToken tok,
          bool createBody, out ConcreteSyntaxTree setterWriter, ConcreteSyntaxTree wr)
        {
            wr.Write($"public {TypeName(resultType, wr, tok)} {name}()");
            ConcreteSyntaxTree wGet = null;
            if (createBody)
            {
                wGet = wr.NewBlock("", null, BlockStyle.NewlineBrace, BlockStyle.NewlineBrace);
            }
            else
            {
                wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(257L, ";"));
            }
            wr.Write($"public void set_{name}({TypeName(resultType, wr, tok)} value)");
            if (createBody)
            {
                setterWriter = wr.NewBlock("", null, BlockStyle.NewlineBrace, BlockStyle.NewlineBrace);
            }
            else
            {
                wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(258L, ";"));
                setterWriter = null;
            }
            return wGet;
        }
        protected ConcreteSyntaxTree CreateMethod(Method m, List<TypeArgumentInstantiation> typeArgs, bool createBody, ConcreteSyntaxTree wr, bool forBodyInheritance, bool lookasideBody)
        {
            if (m.IsExtern(Options, out _, out _) && (MutateCSharp.Schemata236.ReplaceBinExprOp_17(259L, () => m.IsStatic, () => m is Constructor)))
            {
                // No need for an abstract version of a static method or a constructor
                return null;
            }
            string targetReturnTypeReplacement = null;
            int nonGhostOuts = MutateCSharp.Schemata236.ReplaceNumericConstant_1(265L, 0);
            int nonGhostIndex = MutateCSharp.Schemata236.ReplaceNumericConstant_1(269L, 0);
            for (int i = MutateCSharp.Schemata236.ReplaceNumericConstant_1(273L, 0); MutateCSharp.Schemata236.ReplaceBinExprOp_5(277L, i, m.Outs.Count); MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(282L, ref i))
            {
                if (!m.Outs[i].IsGhost)
                {
                    nonGhostOuts += MutateCSharp.Schemata236.ReplaceNumericConstant_1(283L, 1);
                    nonGhostIndex = i;
                }
            }
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_2(291L, nonGhostOuts, MutateCSharp.Schemata236.ReplaceNumericConstant_1(287L, 1)))
            {
                targetReturnTypeReplacement = TypeName(m.Outs[nonGhostIndex].Type, wr, m.Outs[nonGhostIndex].tok);
            }
            else if (MutateCSharp.Schemata236.ReplaceBinExprOp_8(300L, nonGhostOuts, MutateCSharp.Schemata236.ReplaceNumericConstant_1(296L, 1)))
            {
                targetReturnTypeReplacement = DafnyTupleClass(nonGhostOuts);
            }
            var customReceiver = MutateCSharp.Schemata236.ReplaceBinExprOp_7(311L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_7(305L, () => createBody, () => !forBodyInheritance), () => NeedsCustomReceiver(m));
            var receiverType = UserDefinedType.FromTopLevelDecl(m.tok, m.EnclosingClass);
            foreach (var instrumenter in Instrumenters)
            {
                instrumenter.BeforeMethod(m, wr);
            }
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(317L, "public {0}{1}"), MutateCSharp.Schemata236.ReplaceBinExprOp_7(318L, () => !createBody, () => !(m.EnclosingClass is TraitDecl)) ? MutateCSharp.Schemata236.ReplaceStringConstant_0(324L, "abstract ") : "", MutateCSharp.Schemata236.ReplaceBinExprOp_17(325L, () => m.IsStatic, () => customReceiver) ? MutateCSharp.Schemata236.ReplaceStringConstant_0(331L, "static ") : "");
            wr.Write(TypeParameters(TypeArgumentInstantiation.ToFormals(ForTypeParameters(typeArgs, m, lookasideBody)), MutateCSharp.Schemata236.ReplaceStringConstant_0(332L, " ")));
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(333L, "{0} {1}"), targetReturnTypeReplacement ?? MutateCSharp.Schemata236.ReplaceStringConstant_0(334L, "void"), IdName(m));
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(335L, "("));
            var sep = "";
            WriteRuntimeTypeDescriptorsFormals(ForTypeDescriptors(typeArgs, m.EnclosingClass, m, lookasideBody), wr, ref sep, tp => $"{DafnyTypeDescriptor}<{tp.GetCompileName(Options)}> {FormatTypeDescriptorVariable(tp)}");
            if (customReceiver)
            {
                DeclareFormal(sep, MutateCSharp.Schemata236.ReplaceStringConstant_0(336L, "_this"), receiverType, m.tok, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(337L, true), wr);
                sep = MutateCSharp.Schemata236.ReplaceStringConstant_0(338L, ", ");
            }
            WriteFormals(sep, m.Ins, wr);
            if (!createBody)
            {
                wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(339L, ");"));
                return null; // We do not want to write a function body, so instead of returning a BTW, we return null.
            }
            else
            {
                return wr.NewBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(340L, ")"), null, BlockStyle.NewlineBrace, BlockStyle.NewlineBrace);
            }

            return default;
        }

        protected override ConcreteSyntaxTree EmitMethodReturns(Method m, ConcreteSyntaxTree wr)
        {
            int nonGhostOuts = MutateCSharp.Schemata236.ReplaceNumericConstant_1(341L, 0);
            foreach (var t in m.Outs)
            {
                if (t.IsGhost)
                {
                    continue;
                }

                nonGhostOuts += MutateCSharp.Schemata236.ReplaceNumericConstant_1(345L, 1);
                break;
            }
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(364L, () => !m.Body.Body.OfType<ReturnStmt>().Any(), () => (MutateCSharp.Schemata236.ReplaceBinExprOp_17(358L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_8(353L, nonGhostOuts, MutateCSharp.Schemata236.ReplaceNumericConstant_1(349L, 0)), () => m.IsTailRecursive))))
            { // If method has out parameters or is tail-recursive but no explicit return statement in Dafny
                var beforeReturn = wr.NewBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(370L, "if(true)")); // Ensure no unreachable error is thrown for the return statement
                EmitReturn(m.Outs, wr);
                return beforeReturn;
            }
            return wr;
        }

        protected ConcreteSyntaxTree/*?*/ CreateFunction(string name, List<TypeArgumentInstantiation> typeArgs,
          List<Formal> formals, Type resultType, IToken tok, bool isStatic, bool createBody, MemberDecl member,
          ConcreteSyntaxTree wr, bool forBodyInheritance, bool lookasideBody)
        {
            if (member.IsExtern(Options, out _, out _) && isStatic)
            {
                // No need for abstract version of static method
                return null;
            }
            var customReceiver = MutateCSharp.Schemata236.ReplaceBinExprOp_7(377L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_7(371L, () => createBody, () => !forBodyInheritance), () => NeedsCustomReceiver(member));
            var receiverType = UserDefinedType.FromTopLevelDecl(member.tok, member.EnclosingClass);
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(383L, "public {0}{1}"), MutateCSharp.Schemata236.ReplaceBinExprOp_7(384L, () => !createBody, () => !(member.EnclosingClass is TraitDecl)) ? MutateCSharp.Schemata236.ReplaceStringConstant_0(390L, "abstract ") : "", MutateCSharp.Schemata236.ReplaceBinExprOp_17(391L, () => isStatic, () => customReceiver) ? MutateCSharp.Schemata236.ReplaceStringConstant_0(397L, "static ") : "");
            wr.Write(TypeParameters(TypeArgumentInstantiation.ToFormals(ForTypeParameters(typeArgs, member, lookasideBody)), MutateCSharp.Schemata236.ReplaceStringConstant_0(398L, " ")));
            wr.Write($"{TypeName(resultType, wr, tok)} {name}(");
            var sep = "";
            var argCount = WriteRuntimeTypeDescriptorsFormals(ForTypeDescriptors(typeArgs, member.EnclosingClass, member, lookasideBody), wr, ref sep, tp => $"{DafnyTypeDescriptor}<{tp.GetCompileName(Options)}> {FormatTypeDescriptorVariable(tp)}");
            if (customReceiver)
            {
                DeclareFormal(sep, MutateCSharp.Schemata236.ReplaceStringConstant_0(399L, "_this"), receiverType, tok, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(400L, true), wr);
                sep = MutateCSharp.Schemata236.ReplaceStringConstant_0(401L, ", ");
                MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(402L, ref argCount);
            }
            argCount += WriteFormals(sep, formals, wr);
            if (!createBody)
            {
                wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(403L, ");"));
                return null; // We do not want to write a function body, so instead of returning a BTW, we return null.
            }
            else
            {
                ConcreteSyntaxTree w;
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_8(408L, argCount, MutateCSharp.Schemata236.ReplaceNumericConstant_1(404L, 1)))
                {
                    w = wr.NewBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(413L, ")"), null, BlockStyle.NewlineBrace, BlockStyle.NewlineBrace);
                }
                else
                {
                    w = wr.NewBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(414L, ")"));
                }
                return w;
            }

            return default;
        }

        protected void DeclareField(string name, bool isStatic, bool isConst, Type type, IToken tok, string rhs, ClassWriter cw)
        {
            if (isStatic)
            {
                var r = rhs ?? DefaultValue(type, cw.StaticMemberWriter, tok);
                var t = StripTypeParameters(TypeName(type, cw.StaticMemberWriter, tok));
                cw.StaticMemberWriter.WriteLine($"public static {t} {name} = {r};");
            }
            else
            {
                Contract.Assert(cw.CtorBodyWriter != null, "Unexpected instance field");
                cw.InstanceMemberWriter.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(415L, "public {0} {1};"), TypeName(type, cw.InstanceMemberWriter, tok), name);
                cw.CtorBodyWriter.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(416L, "this.{0} = {1};"), name, rhs ?? PlaceboValue(type, cw.CtorBodyWriter, tok));
            }
        }

        private string StripTypeParameters(string s)
        {
            Contract.Requires(s != null);
            return Regex.Replace(s, MutateCSharp.Schemata236.ReplaceStringConstant_0(417L, @"<.+>"), "");
        }

        private void EmitSuppression(ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(418L, "@SuppressWarnings({\"unchecked\", \"deprecation\"})"));
        }

        string TypeParameters(List<TypeParameter>/*?*/ targs, string suffix = "")
        {
            Contract.Requires(targs == null || cce.NonNullElements(targs));
            Contract.Ensures(Contract.Result<string>() != null);

            if (MutateCSharp.Schemata236.ReplaceBinExprOp_17(429L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_18(419L, targs, null), () => MutateCSharp.Schemata236.ReplaceBinExprOp_2(424L, targs.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(420L, 0))))
            {
                return "";  // ignore suffix
            }
            return $"<{Util.Comma(targs, IdName)}>{suffix}";
        }

        internal override string TypeName(Type type, ConcreteSyntaxTree wr, IToken tok, MemberDecl/*?*/ member = null)
        {
            return TypeName(type, wr, tok, boxed: MutateCSharp.Schemata236.ReplaceBooleanConstant_3(435L, false), member);
        }

        private string BoxedTypeName(Type type, ConcreteSyntaxTree wr, IToken tok)
        {
            return TypeName(type, wr, tok, boxed: MutateCSharp.Schemata236.ReplaceBooleanConstant_3(436L, true));
        }

        private string ActualTypeArgument(Type type, TypeParameter.TPVariance variance, ConcreteSyntaxTree wr, IToken tok)
        {
            Contract.Requires(type != null);
            Contract.Requires(wr != null);
            Contract.Requires(tok != null);
            var typeName = BoxedTypeName(type, wr, tok);
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_19(437L, variance, TypeParameter.TPVariance.Co))
            {
                return MutateCSharp.Schemata236.ReplaceStringConstant_0(438L, "? extends ") + typeName;
            }
            else if (MutateCSharp.Schemata236.ReplaceBinExprOp_19(439L, variance, TypeParameter.TPVariance.Contra))
            {
                if (type.IsRefType)
                {
                    return MutateCSharp.Schemata236.ReplaceStringConstant_0(440L, "? super ") + typeName;
                }
            }
            return typeName;
        }

        private string BoxedTypeNames(List<Type> types, ConcreteSyntaxTree wr, IToken tok)
        {
            return Util.Comma(types, t => BoxedTypeName(t, wr, tok));
        }

        protected override string TypeArgumentName(Type type, ConcreteSyntaxTree wr, IToken tok)
        {
            return BoxedTypeName(type, wr, tok);
        }

        private string TypeName(Type type, ConcreteSyntaxTree wr, IToken tok, bool boxed, MemberDecl /*?*/ member = null)
        {
            return TypeName(type, wr, tok, boxed, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(441L, false), member);
        }

        private string CharTypeName(bool boxed)
        {
            if (UnicodeCharEnabled)
            {
                return boxed ? MutateCSharp.Schemata236.ReplaceStringConstant_0(442L, "dafny.CodePoint") : MutateCSharp.Schemata236.ReplaceStringConstant_0(443L, "int");
            }
            else
            {
                return boxed ? MutateCSharp.Schemata236.ReplaceStringConstant_0(444L, "Character") : MutateCSharp.Schemata236.ReplaceStringConstant_0(445L, "char");
            }

            return default;
        }

        private string TypeName(Type type, ConcreteSyntaxTree wr, IToken tok, bool boxed, bool erased, MemberDecl/*?*/ member = null)
        {
            Contract.Ensures(Contract.Result<string>() != null);
            Contract.Assume(type != null);  // precondition; this ought to be declared as a Requires in the superclass

            var xType = DatatypeWrapperEraser.SimplifyType(Options, type);
            if (xType is BoolType)
            {
                return boxed ? MutateCSharp.Schemata236.ReplaceStringConstant_0(446L, "Boolean") : MutateCSharp.Schemata236.ReplaceStringConstant_0(447L, "boolean");
            }
            else if (xType is CharType)
            {
                return CharTypeName(boxed);
            }
            else if (MutateCSharp.Schemata236.ReplaceBinExprOp_17(448L, () => xType is IntType, () => xType is BigOrdinalType))
            {
                return MutateCSharp.Schemata236.ReplaceStringConstant_0(454L, "java.math.BigInteger");
            }
            else if (xType is RealType)
            {
                return DafnyBigRationalClass;
            }
            else if (xType is BitvectorType)
            {
                var t = (BitvectorType)xType;
                return MutateCSharp.Schemata236.ReplaceBinExprOp_20(455L, t.NativeType, null) ? GetNativeTypeName(t.NativeType, boxed) : MutateCSharp.Schemata236.ReplaceStringConstant_0(456L, "java.math.BigInteger");
            }
            else if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(459L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_21(457L, member, null), () => MutateCSharp.Schemata236.ReplaceBinExprOp_22(458L, xType.AsNewtype, null)))
            {
                var nativeType = xType.AsNewtype.NativeType;
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_20(465L, nativeType, null))
                {
                    return GetNativeTypeName(nativeType, boxed);
                }
                return TypeName(xType.AsNewtype.BaseType, wr, tok, boxed, erased);
            }
            else if (xType.IsObjectQ)
            {
                return MutateCSharp.Schemata236.ReplaceStringConstant_0(466L, "Object");
            }
            else if (xType.IsArrayType)
            {
                ArrayClassDecl at = xType.AsArrayType;
                Contract.Assert(at != null);  // follows from type.IsArrayType
                Type elType = UserDefinedType.ArrayElementType(xType);
                return ArrayTypeName(elType, at.Dims, wr, tok, erased);
            }
            else if (xType is UserDefinedType udt)
            {
                if (udt.ResolvedClass is TypeParameter tp)
                {
                    if (MutateCSharp.Schemata236.ReplaceBinExprOp_23(467L, thisContext, null) && thisContext.ParentFormalTypeParametersToActuals.TryGetValue(tp, out var instantiatedTypeParameter))
                    {
                        return TypeName(instantiatedTypeParameter, wr, tok, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(468L, true), member);
                    }
                }
                var s = FullTypeName(udt, member);
                if (s.Equals(MutateCSharp.Schemata236.ReplaceStringConstant_0(469L, "string")))
                {
                    return MutateCSharp.Schemata236.ReplaceStringConstant_0(470L, "String");
                }
                var cl = udt.ResolvedClass;
                if (cl is TupleTypeDecl tupleDecl)
                {
                    s = DafnyTupleClass(tupleDecl.NonGhostDims);
                }
                // When accessing a static member, leave off the type arguments
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_16(471L, member, null))
                {
                    return TypeName_UDT(s, new List<TypeParameter.TPVariance>(), new List<Type>(), wr, udt.tok, erased);
                }
                else
                {
                    return TypeName_UDT(s, udt, wr, udt.tok, erased);
                }
            }
            else if (xType is SetType)
            {
                var argType = ((SetType)xType).Arg;
                if (erased)
                {
                    return DafnySetClass;
                }
                return $"{DafnySetClass}<{ActualTypeArgument(argType, TypeParameter.TPVariance.Co, wr, tok)}>";
            }
            else if (xType is SeqType)
            {
                var argType = ((SeqType)xType).Arg;
                if (erased)
                {
                    return DafnySeqClass;
                }
                return $"{DafnySeqClass}<{ActualTypeArgument(argType, TypeParameter.TPVariance.Co, wr, tok)}>";
            }
            else if (xType is MultiSetType)
            {
                var argType = ((MultiSetType)xType).Arg;
                if (erased)
                {
                    return DafnyMultiSetClass;
                }
                return $"{DafnyMultiSetClass}<{ActualTypeArgument(argType, TypeParameter.TPVariance.Co, wr, tok)}>";
            }
            else if (xType is MapType)
            {
                var domType = ((MapType)xType).Domain;
                var ranType = ((MapType)xType).Range;
                if (erased)
                {
                    return DafnyMapClass;
                }
                return $"{DafnyMapClass}<{ActualTypeArgument(domType, TypeParameter.TPVariance.Co, wr, tok)}, {ActualTypeArgument(ranType, TypeParameter.TPVariance.Co, wr, tok)}>";
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected type
            }

            return default;
        }

        string ArrayTypeName(Type elType, int dims, ConcreteSyntaxTree wr, IToken tok, bool erased)
        {
            elType = DatatypeWrapperEraser.SimplifyType(Options, elType);
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_8(476L, dims, MutateCSharp.Schemata236.ReplaceNumericConstant_1(472L, 1)))
            {
                if (erased)
                {
                    return DafnyMultiArrayClass(dims);
                }
                else
                {
                    return $"{DafnyMultiArrayClass(dims)}<{ActualTypeArgument(elType, TypeParameter.TPVariance.Non, wr, tok)}>";
                }
            }
            else if (elType.IsTypeParameter)
            {
                return MutateCSharp.Schemata236.ReplaceStringConstant_0(481L, "java.lang.Object");
            }
            else
            {
                return $"{TypeName(elType, wr, tok, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(482L, false), erased)}[]";
            }

            return default;
        }

        protected string CollectionTypeUnparameterizedName(CollectionType ct)
        {
            if (ct is SeqType)
            {
                return DafnySeqClass;
            }
            else if (ct is SetType)
            {
                return DafnySetClass;
            }
            else if (ct is MultiSetType)
            {
                return DafnyMultiSetClass;
            }
            else if (ct is MapType)
            {
                return DafnyMapClass;
            }
            else
            {
                Contract.Assert(false);  // unexpected collection type
                throw new cce.UnreachableException();  // to please the compiler
            }

            return default;
        }

        protected override string FullTypeName(UserDefinedType udt, MemberDecl /*?*/ member = null)
        {
            return FullTypeName(udt, member, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(483L, false));
        }

        protected string FullTypeName(UserDefinedType udt, MemberDecl member, bool useCompanionName)
        {
            Contract.Requires(udt != null);
            if (udt.IsBuiltinArrowType)
            {
                return DafnyFunctionIface(MutateCSharp.Schemata236.ReplaceBinExprOp_10(488L, udt.TypeArgs.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(484L, 1)));
            }

            if (member != null && member.IsExtern(Options, out var qualification, out _) && qualification != null)
            {
                return qualification;
            }
            var cl = udt.ResolvedClass;
            if (cl is NonNullTypeDecl nntd)
            {
                cl = nntd.Class;
            }
            if (cl is TypeParameter)
            {
                return IdProtect(udt.GetCompileName(Options));
            }
            else if (cl is TupleTypeDecl tupleDecl)
            {
                return DafnyTupleClass(tupleDecl.NonGhostDims);
            }
            else if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(497L, () => cl is TraitDecl, () => useCompanionName))
            {
                return IdProtect(udt.GetFullCompanionCompileName(Options));
            }
            else if (MutateCSharp.Schemata236.ReplaceBinExprOp_17(504L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_13(503L, cl.EnclosingModuleDefinition.GetCompileName(Options), ModuleName), () => cl.EnclosingModuleDefinition.TryToAvoidName))
            {
                return IdProtect(cl.GetCompileName(Options));
            }
            else
            {
                return IdProtectModule(cl.EnclosingModuleDefinition.GetCompileName(Options)) + MutateCSharp.Schemata236.ReplaceStringConstant_0(510L, ".") + IdProtect(cl.GetCompileName(Options));
            }

            return default;
        }

        protected override void TypeName_SplitArrayName(Type type, out Type innermostElementType, out string brackets)
        {
            Contract.Requires(type != null);

            type = DatatypeWrapperEraser.SimplifyType(Options, type);
            var at = type.AsArrayType;
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(531L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_7(521L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_24(511L, at, null), () => MutateCSharp.Schemata236.ReplaceBinExprOp_2(516L, at.Dims, MutateCSharp.Schemata236.ReplaceNumericConstant_1(512L, 1))), () => !DatatypeWrapperEraser.SimplifyType(Options, type.TypeArgs[MutateCSharp.Schemata236.ReplaceNumericConstant_1(527L, 0)]).IsTypeParameter))
            {
                TypeName_SplitArrayName(type.TypeArgs[MutateCSharp.Schemata236.ReplaceNumericConstant_1(537L, 0)], out innermostElementType, out brackets);
                brackets = TypeNameArrayBrackets(at.Dims) + brackets;
            }
            else
            {
                innermostElementType = type;
                brackets = "";
            }
        }

        protected override string TypeNameArrayBrackets(int dims)
        {
            return Util.Repeat(dims, MutateCSharp.Schemata236.ReplaceStringConstant_0(541L, "[]"));
        }

        protected override bool DeclareFormal(string prefix, string name, Type type, IToken tok, bool isInParam, ConcreteSyntaxTree wr)
        {
            if (!isInParam)
            {
                return MutateCSharp.Schemata236.ReplaceBooleanConstant_3(542L, false);
            }

            wr.Write($"{prefix}{TypeName(type, wr, tok)} {name}");
            return MutateCSharp.Schemata236.ReplaceBooleanConstant_3(543L, true);
        }

        protected override string TypeName_UDT(string fullCompileName, List<TypeParameter.TPVariance> variance, List<Type> typeArgs,
          ConcreteSyntaxTree wr, IToken tok, bool omitTypeArguments)
        {
            Contract.Assume(fullCompileName != null);  // precondition; this ought to be declared as a Requires in the superclass
            Contract.Assume(variance != null);  // precondition; this ought to be declared as a Requires in the superclass
            Contract.Assume(typeArgs != null);  // precondition; this ought to be declared as a Requires in the superclass
            Contract.Assume(variance.Count == typeArgs.Count);
            string s = IdProtect(fullCompileName);
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(553L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_25(548L, typeArgs.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(544L, 0)), () => !omitTypeArguments))
            {
                s += MutateCSharp.Schemata236.ReplaceStringConstant_0(559L, "<") + BoxedTypeNames(typeArgs, wr, tok) + MutateCSharp.Schemata236.ReplaceStringConstant_0(560L, ">");
            }
            return s;
        }

        // We write an extern class as a base class that the actual extern class
        // needs to extend, so the extern methods and functions need to be abstract
        // in the base class
        protected override bool IncludeExternMembers { get => MutateCSharp.Schemata236.ReplaceBooleanConstant_3(561L, true); }

        //
        // An example to show how type parameters are dealt with:
        //
        //   class Class<T /* needs auto-initializer */, U /* does not */> {
        //     private String sT; // type descriptor for T
        //
        //     // Fields are assigned in the constructor because some will
        //     // depend on a type parameter
        //     public T t;
        //     public U u;
        //
        //     public Class(String sT) {
        //       this.sT = sT;
        //       this.t = dafny.Helpers.getDefault(sT);
        //       // Note: The field must be assigned a real value before being read!
        //       this.u = null;
        //     }
        //
        //     public __ctor(U u) {
        //       this.u = u;
        //     }
        //   }
        //
        protected override IClassWriter CreateClass(string moduleName, string name, bool isExtern, string /*?*/ fullPrintName,
          List<TypeParameter> typeParameters, TopLevelDecl cls, List<Type> /*?*/ superClasses, IToken tok, ConcreteSyntaxTree wr)
        {
            var javaName = isExtern ? FormatExternBaseClassName(name) : name;
            var filename = $"{ModulePath}/{javaName}.java";
            var w = wr.NewFile(filename);
            FileCount += MutateCSharp.Schemata236.ReplaceNumericConstant_1(562L, 1);
            w.WriteLine($"// Class {javaName}");
            w.WriteLine($"// Dafny class {name} compiled into Java");
            w.WriteLine($"package {ModuleName};");
            w.WriteLine();
            EmitImports(w, out _);
            w.WriteLine();
            //TODO: Fix implementations so they do not need this suppression
            EmitSuppression(w);
            foreach (var instrumenter in Instrumenters)
            {
                instrumenter.BeforeClass(cls, w);
            }
            var abstractness = isExtern ? MutateCSharp.Schemata236.ReplaceStringConstant_0(566L, "abstract ") : "";
            w.Write($"public {abstractness}class {javaName}{TypeParameters(typeParameters)}");
            string sep;
            // Since Java does not support multiple inheritance, we are assuming a list of "superclasses" is a list of interfaces
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_26(567L, superClasses, null))
            {
                sep = MutateCSharp.Schemata236.ReplaceStringConstant_0(568L, " implements ");
                foreach (var trait in superClasses)
                {
                    if (!trait.IsObject)
                    {
                        w.Write($"{sep}{TypeName(trait, w, tok)}");
                        sep = MutateCSharp.Schemata236.ReplaceStringConstant_0(569L, ", ");
                    }
                }
            }
            var wBody = w.NewBlock("");
            var wTypeFields = wBody.Fork();

            wBody.Write($"public {javaName}(");
            var wCtorParams = wBody.Fork();
            var wCtorBody = wBody.NewBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(570L, ")"), "");

            EmitTypeDescriptorsForClass(typeParameters, cls, wTypeFields, wCtorParams, null, wCtorBody);

            // make sure the (static fields associated with the) type method come after the Witness static field
            var wTypeMethod = wBody;
            var wRestOfBody = wBody.Fork();
            if (cls is DefaultClassDecl or (ClassLikeDecl and not ArrayClassDecl))
            {
                // don't emit a type-descriptor method
            }
            else
            {
                EmitTypeDescriptorMethod(cls, typeParameters, null, null, wTypeMethod);
            }

            if (fullPrintName != null)
            {
                // By emitting a toString() method, printing an object will give the same output as with other target languages.
                EmitToString(fullPrintName, wBody);
            }

            return new ClassWriter(this, wRestOfBody, wCtorBody);
        }

        /// <summary>
        /// For each type parameter X in "typeParametersForClass" that needs a type descriptor,
        ///   * Write "protected TypeDescriptor<X> _td_X;" to wTypeFields
        ///     -- each entry is terminated by a newline
        ///   * Write "TypeDescriptor<X> _td_X" to wCtorParams
        ///     -- entries are separated by a comma
        ///   * Write "_td_X" to wCallArguments
        ///     -- entries are separated by a comma
        ///   * Write "this._td_X := _td_X;" to wCtorBody
        ///     -- each entry is terminated by a newline
        /// Any of the writer parameters may be null, so long as at least one is non-null.
        /// The method returns the number type descriptors written.
        /// </summary>
        int EmitTypeDescriptorsForClass(List<TypeParameter> typeParametersForClass, TopLevelDecl cls,
          [CanBeNull] ConcreteSyntaxTree wTypeFields, [CanBeNull] ConcreteSyntaxTree wCtorParams,
          [CanBeNull] ConcreteSyntaxTree wCallArguments, [CanBeNull] ConcreteSyntaxTree wCtorBody,
          string namePrefix = null)
        {

            namePrefix ??= "";

            var wError = wTypeFields ?? wCtorParams ?? wCallArguments ?? wCtorBody;
            int numberOfEmittedTypeDescriptors = MutateCSharp.Schemata236.ReplaceNumericConstant_1(571L, 0);
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_27(575L, typeParametersForClass, null))
            {
                var sep = "";
                foreach (var ta in TypeArgumentInstantiation.ListFromFormals(typeParametersForClass))
                {
                    if (NeedsTypeDescriptor(ta.Formal))
                    {
                        var fieldName = FormatTypeDescriptorVariable(ta.Formal.GetCompileName(Options));
                        var paramName = TypeDescriptor(ta.Actual, wError, ta.Formal.tok);
                        var decl = $"{DafnyTypeDescriptor}<{namePrefix}{BoxedTypeName(ta.Actual, wError, ta.Formal.tok)}> {fieldName}";

                        wTypeFields?.WriteLine($"protected {decl};");
                        if (MutateCSharp.Schemata236.ReplaceBinExprOp_28(576L, ta.Formal.Parent, cls))
                        {
                            wCtorParams?.Write($"{sep}{decl}");
                        }
                        wCtorBody?.WriteLine($"this.{fieldName} = {paramName};");
                        wCallArguments?.Write($"{sep}{paramName}");

                        sep = MutateCSharp.Schemata236.ReplaceStringConstant_0(577L, ", ");
                        MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(578L, ref numberOfEmittedTypeDescriptors);
                    }
                }
            }
            return numberOfEmittedTypeDescriptors;
        }

        private void EmitToString(string fullPrintName, ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(579L, "@Override"));
            wr.NewBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(580L, "public java.lang.String toString()"))
              .WriteLine($"return \"{fullPrintName}\";");
        }

        /// <summary>
        /// Generate the "_typeDescriptor" method for a generated class.
        /// "enclosingType" is allowed to be "null", in which case the target values are assumed to be references.
        /// If "enclosingType" is null, then "targetTypeName" is expected to be the name of the Java type representing the type.
        /// If "enclosingType" is non-null, then "targetTypeName" is expected to be null.
        /// </summary>
        private void EmitTypeDescriptorMethod([CanBeNull] TopLevelDecl enclosingTypeDecl, List<TypeParameter> typeParams, string targetTypeName,
          [CanBeNull] string initializer, ConcreteSyntaxTree wr)
        {
            Contract.Requires((enclosingTypeDecl != null) != (targetTypeName != null));

            string typeDescriptorExpr;
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_29(581L, enclosingTypeDecl, null))
            {
                Contract.Assert(targetTypeName != null);
                // use reference type
                typeDescriptorExpr = $"{DafnyTypeDescriptor}.referenceWithInitializer({StripTypeParameters(targetTypeName)}.class, () -> {initializer ?? MutateCSharp.Schemata236.ReplaceStringConstant_0(582L, "null")})";
            }
            else
            {
                Contract.Assert(targetTypeName == null);
                var enclosingTypeWithItsOwnTypeArguments = UserDefinedType.FromTopLevelDecl(enclosingTypeDecl.tok, enclosingTypeDecl);
                var targetType = DatatypeWrapperEraser.SimplifyTypeAndTrimSubsetTypes(Options, enclosingTypeWithItsOwnTypeArguments);
                var targetTypeIgnoringConstraints = DatatypeWrapperEraser.SimplifyType(Options, enclosingTypeWithItsOwnTypeArguments).GetRuntimeType();
                targetTypeName = BoxedTypeName(targetTypeIgnoringConstraints, wr, enclosingTypeDecl.tok);
                var w = MutateCSharp.Schemata236.ReplaceBinExprOp_30(583L, (enclosingTypeDecl as RedirectingTypeDecl)?.Witness, null) ? MutateCSharp.Schemata236.ReplaceStringConstant_0(584L, "Witness") : null;
                switch (AsJavaNativeType(targetType))
                {
                    case JavaNativeType.Byte:
                        typeDescriptorExpr = $"{DafnyTypeDescriptor}.byteWithDefault({w ?? "(byte)0"})";
                        break;
                        break;
                    case JavaNativeType.Short:
                        typeDescriptorExpr = $"{DafnyTypeDescriptor}.shortWithDefault({w ?? "(short)0"})";
                        break;
                        break;
                    case JavaNativeType.Int:
                        typeDescriptorExpr = $"{DafnyTypeDescriptor}.intWithDefault({w ?? "0"})";
                        break;
                        break;
                    case JavaNativeType.Long:
                        typeDescriptorExpr = $"{DafnyTypeDescriptor}.longWithDefault({w ?? "0L"})";
                        break;
                        break;
                    case null:
                        if (targetTypeIgnoringConstraints.IsBoolType)
                        {
                            typeDescriptorExpr = $"{DafnyTypeDescriptor}.booleanWithDefault({w ?? "false"})";
                        }
                        else if (targetTypeIgnoringConstraints.IsCharType)
                        {
                            if (UnicodeCharEnabled)
                            {
                                typeDescriptorExpr = $"{DafnyTypeDescriptor}.unicodeCharWithDefault((int){w ?? CharType.DefaultValueAsString})";
                            }
                            else
                            {
                                typeDescriptorExpr = $"{DafnyTypeDescriptor}.charWithDefault({w ?? CharType.DefaultValueAsString})";
                            }
                        }
                        else
                        {
                            var d = initializer ?? DefaultValue(targetType, wr, enclosingTypeDecl.tok, true);
                            // We'd like to say, essentially, targetTypeName.class. But this is not legal Java if targetTypeName is a type parameter.
                            // So, we detect that case here and use the corresponding type descriptor instead (because method
                            // referenceWithInitializerAndTypeDescriptor will use the .boxedClass of that type descriptor, which gives the Class<T> object
                            // we're looking for).
                            var tp = targetTypeIgnoringConstraints.AsTypeParameter;
                            if (tp == null)
                            {
                                typeDescriptorExpr = $"{DafnyTypeDescriptor}.<{targetTypeName}>referenceWithInitializer({StripTypeParameters(targetTypeName)}.class, () -> {d})";
                            }
                            else
                            {
                                var td = FormatTypeDescriptorVariable(tp.GetCompileName(Options));
                                typeDescriptorExpr = $"{DafnyTypeDescriptor}.<{targetTypeName}>referenceWithInitializerAndTypeDescriptor({td}, () -> {d})";
                            }
                        }
                        break;
                        break;
                    default:
                        Contract.Assert(false); // unexpected case
                        throw new cce.UnreachableException();
                        break;
                }
            }

            if (MutateCSharp.Schemata236.ReplaceBinExprOp_2(589L, typeParams.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(585L, 0)))
            {
                // a static context in Java does not see the enclosing type parameters
                wr.WriteLine($"private static final {DafnyTypeDescriptor}<{targetTypeName}> _TYPE = {typeDescriptorExpr};");
                typeDescriptorExpr = MutateCSharp.Schemata236.ReplaceStringConstant_0(594L, "_TYPE");
            }
            wr.Write($"public static {TypeParameters(typeParams, MutateCSharp.Schemata236.ReplaceStringConstant_0(595L, " "))}{DafnyTypeDescriptor}<{targetTypeName}> {TypeMethodName}(");
            EmitTypeDescriptorsForClass(typeParams, enclosingTypeDecl, null, wr, null, null);
            var wTypeMethodBody = wr.NewBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(596L, ")"), "");
            var typeDescriptorCast = $"({DafnyTypeDescriptor}<{targetTypeName}>) ({DafnyTypeDescriptor}<?>)";
            wTypeMethodBody.WriteLine($"return {typeDescriptorCast} {typeDescriptorExpr};");
        }

        private string CastIfSmallNativeType(Type t)
        {
            var nt = AsNativeType(t);
            return MutateCSharp.Schemata236.ReplaceBinExprOp_4(597L, nt, null) ? "" : CastIfSmallNativeType(nt);
        }

        private string CastIfSmallNativeType(NativeType nt)
        {
            switch (AsJavaNativeType(nt))
            {
                case JavaNativeType.Byte:
                    return "(byte) ";
                    break;
                case JavaNativeType.Short:
                    return "(short) ";
                    break;
                case JavaNativeType.Long:
                    return "(long) ";
                    break;
                default:
                    return "";
                    break;
            }

            return default;
        }

        private static string TranslateEscapes(string s)
        {
            s = Util.ReplaceNullEscapesWithCharacterEscapes(s);

            s = Util.UnicodeEscapesToUtf16Escapes(s);

            // Java \u escapes are translated before parsing, so we need to convert to escapes
            // that aren't for characters that will mess up paring the string or character literal.
            s = Util.ReplaceTokensWithEscapes(s, Util.Utf16Escape, match =>
            {
                return match.Value switch
                {
                    "\\u000a" => MutateCSharp.Schemata236.ReplaceStringConstant_0(598L, "\\n"),
                    "\\u000d" => MutateCSharp.Schemata236.ReplaceStringConstant_0(599L, "\\r"),
                    "\\u0022" => MutateCSharp.Schemata236.ReplaceStringConstant_0(600L, "\\\""),
                    "\\u0027" => MutateCSharp.Schemata236.ReplaceStringConstant_0(601L, "\\\'"),
                    "\\u005c" => MutateCSharp.Schemata236.ReplaceStringConstant_0(602L, "\\\\"),
                    _ => match.Value
                };
            });

            return s;
        }

        protected override void EmitLiteralExpr(ConcreteSyntaxTree wr, LiteralExpr e)
        {
            if (e is StaticReceiverExpr)
            {
                wr.Write(TypeName(e.Type, wr, e.tok));
            }
            else if (e.Value == null)
            {
                wr.Write($"({TypeName(e.Type, wr, e.tok)}) null");
            }
            else if (e.Value is bool value)
            {
                wr.Write(value ? MutateCSharp.Schemata236.ReplaceStringConstant_0(603L, "true") : MutateCSharp.Schemata236.ReplaceStringConstant_0(604L, "false"));
            }
            else if (e is CharLiteralExpr)
            {
                var v = (string)e.Value;
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(606L, () => UnicodeCharEnabled, () => Util.MightContainNonAsciiCharacters(v, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(605L, false))))
                {
                    wr.Write($"{Util.UnescapedCharacters(Options, v, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(612L, false)).Single()}");
                }
                else
                {
                    wr.Write($"'{TranslateEscapes(v)}'");
                }
            }
            else if (e is StringLiteralExpr str)
            {
                wr.Write(UnicodeCharEnabled ? $"{DafnySeqClass}.asUnicodeString(" : $"{DafnySeqClass}.asString(");
                TrStringLiteral(str, wr);
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(613L, ")"));
            }
            else if (AsNativeType(e.Type) is { } nativeType)
            {
                EmitNativeIntegerLiteral((BigInteger)e.Value, nativeType, wr);
            }
            else if (e.Value is BigInteger i)
            {
                if (i.IsZero)
                {
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(614L, "java.math.BigInteger.ZERO"));
                }
                else if (i.IsOne)
                {
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(615L, "java.math.BigInteger.ONE"));
                }
                else if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(620L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_31(616L, long.MinValue, i), () => MutateCSharp.Schemata236.ReplaceBinExprOp_32(618L, i, long.MaxValue)))
                {
                    wr.Write($"java.math.BigInteger.valueOf({i}L)");
                }
                else
                {
                    wr.Write($"new java.math.BigInteger(\"{i}\")");
                }
            }
            else if (e.Value is BaseTypes.BigDec n)
            {
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_33(630L, MutateCSharp.Schemata236.ReplaceNumericConstant_1(626L, 0), n.Exponent))
                {
                    wr.Write($"new {DafnyBigRationalClass}(new java.math.BigInteger(\"{n.Mantissa}");
                    for (int j = MutateCSharp.Schemata236.ReplaceNumericConstant_1(635L, 0); MutateCSharp.Schemata236.ReplaceBinExprOp_5(639L, j, n.Exponent); MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(644L, ref j))
                    {
                        wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(645L, "0"));
                    }
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(646L, "\"), java.math.BigInteger.ONE)"));
                }
                else
                {
                    wr.Write($"new {DafnyBigRationalClass}(");
                    wr.Write($"new java.math.BigInteger(\"{n.Mantissa}\")");
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(647L, ", new java.math.BigInteger(\"1"));
                    for (int j = n.Exponent; MutateCSharp.Schemata236.ReplaceBinExprOp_5(652L, j, MutateCSharp.Schemata236.ReplaceNumericConstant_1(648L, 0)); MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(657L, ref j))
                    {
                        wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(658L, "0"));
                    }
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(659L, "\"))"));
                }
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected literal
            }
        }

        protected override void EmitStringLiteral(string str, bool isVerbatim, ConcreteSyntaxTree wr)
        {
            if (!isVerbatim)
            {
                wr.Write($"\"{TranslateEscapes(str)}\"");
            }
            else
            {
                //TODO: This is taken from Go and JS since Java doesn't have raw string literals, modify and make better if possible.
                var n = str.Length;
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(660L, "\""));
                for (var i = MutateCSharp.Schemata236.ReplaceNumericConstant_1(661L, 0); MutateCSharp.Schemata236.ReplaceBinExprOp_5(665L, i, n); MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(670L, ref i))
                {
                    if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(718L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_7(694L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_2(671L, str[i], '\"'), () => MutateCSharp.Schemata236.ReplaceBinExprOp_5(689L, MutateCSharp.Schemata236.ReplaceBinExprOp_11(680L, i, MutateCSharp.Schemata236.ReplaceNumericConstant_1(676L, 1)), n)), () => MutateCSharp.Schemata236.ReplaceBinExprOp_2(713L, str[MutateCSharp.Schemata236.ReplaceBinExprOp_11(704L, i, MutateCSharp.Schemata236.ReplaceNumericConstant_1(700L, 1))], '\"')))
                    {
                        wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(724L, "\\\""));
                        MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(725L, ref i);
                    }
                    else if (MutateCSharp.Schemata236.ReplaceBinExprOp_2(726L, str[i], '\\'))
                    {
                        wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(731L, "\\\\"));
                    }
                    else if (MutateCSharp.Schemata236.ReplaceBinExprOp_2(732L, str[i], '\n'))
                    {
                        wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(737L, "\\n"));
                    }
                    else if (MutateCSharp.Schemata236.ReplaceBinExprOp_2(738L, str[i], '\r'))
                    {
                        wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(743L, "\\r"));
                    }
                    else
                    {
                        wr.Write(str[i]);
                    }
                }
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(744L, "\""));
            }
        }

        void EmitNativeIntegerLiteral(BigInteger value, NativeType nt, ConcreteSyntaxTree wr)
        {
            GetNativeInfo(nt.Sel, out var name, out var literalSuffix, out _);
            var intValue = value;
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_34(745L, intValue, long.MaxValue))
            {
                // The value must be a 64-bit unsigned integer, since it has a native
                // type and unsigned long is the biggest native type
                Contract.Assert(intValue <= ulong.MaxValue);

                // Represent the value as a signed 64-bit integer
                intValue -= ulong.MaxValue + BigInteger.One;
            }
            else if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(750L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_35(747L, nt.Sel, NativeType.Selection.UInt), () => MutateCSharp.Schemata236.ReplaceBinExprOp_36(748L, intValue, int.MaxValue)))
            {
                // Represent the value as a signed 32-bit integer
                intValue -= uint.MaxValue + BigInteger.One;
            }
            wr.Write($"{CastIfSmallNativeType(nt)}{intValue}{literalSuffix}");
        }

        protected string GetNativeDefault(NativeType nt)
        {
            switch (AsJavaNativeType(nt))
            {
                case JavaNativeType.Byte:
                    return "(byte) 0";
                    break;
                case JavaNativeType.Short:
                    return "(short) 0";
                    break;
                case JavaNativeType.Int:
                    return "0";
                    break;
                case JavaNativeType.Long:
                    return "0L";
                    break;
                default:
                    Contract.Assert(false);  // unexpected native type
                    throw new cce.UnreachableException();  // to please the compiler
                    break;
            }

            return default;
        }

        protected override void GetNativeInfo(NativeType.Selection sel, out string name, out string literalSuffix,
          out bool needsCastAfterArithmetic)
        {
            literalSuffix = "";
            needsCastAfterArithmetic = MutateCSharp.Schemata236.ReplaceBooleanConstant_3(756L, false);
            switch (AsJavaNativeType(sel))
            {
                case JavaNativeType.Byte:
                    name = "byte"; needsCastAfterArithmetic = true; break;
                    break;
                case JavaNativeType.Short:
                    name = "short"; needsCastAfterArithmetic = true; break;
                    break;
                case JavaNativeType.Int:
                    name = "int"; break;
                    break;
                case JavaNativeType.Long:
                    name = "long"; literalSuffix = "L"; break;
                    break;
                default:
                    Contract.Assert(false);  // unexpected native type
                    throw new cce.UnreachableException();  // to please the compiler
                    break;
            }
        }

        private string GetNativeTypeName(NativeType nt, bool boxed = false)
        {
            return boxed ? GetBoxedNativeTypeName(nt) : base.GetNativeTypeName(nt);
        }

        private string GetBoxedNativeTypeName(NativeType nt)
        {
            switch (AsJavaNativeType(nt))
            {
                case JavaNativeType.Byte:
                    return "java.lang.Byte";
                    break;
                case JavaNativeType.Short:
                    return "java.lang.Short";
                    break;
                case JavaNativeType.Int:
                    return "java.lang.Integer";
                    break;
                case JavaNativeType.Long:
                    return "java.lang.Long";
                    break;
                default:
                    Contract.Assert(false);  // unexpected native type
                    throw new cce.UnreachableException();  // to please the compiler
                    break;
            }

            return default;
        }

        // Note the (semantically iffy) distinction between a *primitive type*,
        // being one of the eight Java primitive types, and a NativeType, which can
        // only be one of the integer types.
        // Note also that in --unicode-char mode, we have our own CodePoint boxing type
        // that boxes int values that are actually Dafny char values.
        private bool IsJavaPrimitiveType(Type type)
        {
            return MutateCSharp.Schemata236.ReplaceBinExprOp_17(764L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_17(757L, () => type.IsBoolType, () => type.IsCharType), () => MutateCSharp.Schemata236.ReplaceBinExprOp_20(763L, AsNativeType(type), null));
        }

        protected override void EmitThis(ConcreteSyntaxTree wr, bool callToInheritedMember)
        {
            var custom = MutateCSharp.Schemata236.ReplaceBinExprOp_17(814L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_17(808L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_17(796L, () => (MutateCSharp.Schemata236.ReplaceBinExprOp_7(777L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_12(770L, enclosingMethod, null), () => (MutateCSharp.Schemata236.ReplaceBinExprOp_17(771L, () => enclosingMethod.IsTailRecursive, () => NeedsCustomReceiver(enclosingMethod))))), () => (MutateCSharp.Schemata236.ReplaceBinExprOp_7(790L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_37(783L, enclosingFunction, null), () => (MutateCSharp.Schemata236.ReplaceBinExprOp_17(784L, () => enclosingFunction.IsTailRecursive, () => NeedsCustomReceiver(enclosingFunction)))))), () => (MutateCSharp.Schemata236.ReplaceBinExprOp_7(802L, () => thisContext is NewtypeDecl, () => !callToInheritedMember))), () => thisContext is TraitDecl);
            wr.Write(custom ? MutateCSharp.Schemata236.ReplaceStringConstant_0(820L, "_this") : MutateCSharp.Schemata236.ReplaceStringConstant_0(821L, "this"));
        }

        protected override void DeclareLocalVar(string name, Type /*?*/ type, IToken /*?*/ tok, bool leaveRoomForRhs,
          string /*?*/ rhs, ConcreteSyntaxTree wr)
        {
            // Note that type can be null to represent the native object type.
            // See comment on NativeObjectType.
            if (type is { IsTypeParameter: true })
            {
                EmitSuppression(wr);
            }
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(822L, "{0} {1}"), MutateCSharp.Schemata236.ReplaceBinExprOp_38(823L, type, null) ? TypeName(type, wr, tok) : MutateCSharp.Schemata236.ReplaceStringConstant_0(824L, "Object"), name);
            if (leaveRoomForRhs)
            {
                Contract.Assert(rhs == null); // follows from precondition
            }
            else if (rhs != null)
            {
                wr.WriteLine($" = {rhs};");
            }
            else if (type is { IsIntegerType: true })
            {
                wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(825L, " = java.math.BigInteger.ZERO;"));
            }
            else
            {
                wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(826L, ";"));
            }
        }

        protected override void DeclareLocalVar(string name, Type /*?*/ type, IToken /*?*/ tok, bool leaveRoomForRhs,
          string /*?*/ rhs, ConcreteSyntaxTree wr, Type t)
        {
            DeclareLocalVar(name, t, tok, leaveRoomForRhs, rhs, wr);
        }

        protected override void EmitCollectionDisplay(CollectionType ct, IToken tok, List<Expression> elements,
            bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_2(831L, elements.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(827L, 0)))
            {
                wr.Write($"{CollectionTypeUnparameterizedName(ct)}.<{BoxedTypeName(ct.Arg, wr, tok)}> empty(");
                if (ct is SeqType)
                {
                    wr.Write(TypeDescriptor(ct.Arg, wr, tok));
                }
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(836L, ")"));
                return;
            }
            wr.Write($"{CollectionTypeUnparameterizedName(ct)}.<{BoxedTypeName(ct.Arg, wr, tok)}> of(");
            string sep = "";
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(849L, () => ct is SeqType, () => (MutateCSharp.Schemata236.ReplaceBinExprOp_17(843L, () => !IsJavaPrimitiveType(ct.Arg), () => (MutateCSharp.Schemata236.ReplaceBinExprOp_7(837L, () => UnicodeCharEnabled, () => ct.Arg.IsCharType))))))
            {
                wr.Write(TypeDescriptor(ct.Arg, wr, tok));
                sep = MutateCSharp.Schemata236.ReplaceStringConstant_0(855L, ", ");
            }

            if (MutateCSharp.Schemata236.ReplaceBinExprOp_25(860L, elements.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(856L, 0)))
            {
                wr.Write(sep);
            }
            TrExprList(elements, wr, inLetExprBody, wStmts, typeAt: _ => NativeObjectType, parens: MutateCSharp.Schemata236.ReplaceBooleanConstant_3(865L, false));

            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(866L, ")"));
        }

        protected override void EmitMapDisplay(MapType mt, IToken tok, List<ExpressionPair> elements, bool inLetExprBody,
            ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write($"{DafnyMapClass}.fromElements");
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(867L, "("));
            string sep = "";
            foreach (ExpressionPair p in elements)
            {
                wr.Write(sep);
                wr.Write($"new {DafnyTupleClass(MutateCSharp.Schemata236.ReplaceNumericConstant_1(868L, 2))}(");
                var coercedW = EmitCoercionIfNecessary(from: p.A.Type, to: NativeObjectType, tok: p.A.tok, wr: wr);
                coercedW.Append(Expr(p.A, inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(872L, ", "));
                coercedW = EmitCoercionIfNecessary(from: p.B.Type, to: NativeObjectType, tok: p.B.tok, wr: wr);
                coercedW.Append(Expr(p.B, inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(873L, ")"));
                sep = MutateCSharp.Schemata236.ReplaceStringConstant_0(874L, ", ");
            }
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(875L, ")"));
        }

        protected override void GetSpecialFieldInfo(SpecialField.ID id, object idParam, Type receiverType, out string compiledName, out string preString, out string postString)
        {
            compiledName = "";
            preString = "";
            postString = "";
            switch (id)
            {
                case SpecialField.ID.UseIdParam:
                    compiledName = IdProtect((string)idParam);
                    break;
                    break;
                case SpecialField.ID.ArrayLength:
                case SpecialField.ID.ArrayLengthInt:
                    if (idParam == null)
                    {
                        // Works on both fixed array types like array<int> (=> BigInteger[])
                        // or generic array types like array<A> (=> Object) and (unlike most
                        // of java.lang.reflect.Array) is fast
                        preString = "java.lang.reflect.Array.getLength(";
                        postString = ")";
                    }
                    else
                    {
                        compiledName = "dim" + (int)idParam;
                    }
                    if (id == SpecialField.ID.ArrayLength)
                    {
                        preString = "java.math.BigInteger.valueOf(" + preString;
                        postString = postString + ")";
                    }
                    break;
                    break;
                case SpecialField.ID.Floor:
                    compiledName = "ToBigInteger()";
                    break;
                    break;
                case SpecialField.ID.IsLimit:
                    preString = "dafny.BigOrdinal.IsLimit(";
                    postString = ")";
                    break;
                    break;
                case SpecialField.ID.IsSucc:
                    preString = "dafny.BigOrdinal.IsSucc(";
                    postString = ")";
                    break;
                    break;
                case SpecialField.ID.Offset:
                    preString = "dafny.BigOrdinal.Offset(";
                    postString = ")";
                    break;
                    break;
                case SpecialField.ID.IsNat:
                    preString = "dafny.BigOrdinal.IsNat(";
                    postString = ")";
                    break;
                    break;
                case SpecialField.ID.Keys:
                    compiledName = "keySet()";
                    break;
                    break;
                case SpecialField.ID.Values:
                    compiledName = "valueSet()";
                    break;
                    break;
                case SpecialField.ID.Items:
                    var mapType = receiverType.NormalizeToAncestorType().AsMapType;
                    Contract.Assert(mapType != null);
                    var errorWr = new ConcreteSyntaxTree();
                    compiledName = $"<{BoxedTypeName(mapType.Domain, errorWr, Token.NoToken)}, {BoxedTypeName(mapType.Range, errorWr, Token.NoToken)}>entrySet()";
                    break;
                    break;
                case SpecialField.ID.Reads:
                    compiledName = "_reads";
                    break;
                    break;
                case SpecialField.ID.Modifies:
                    compiledName = "_modifies";
                    break;
                    break;
                case SpecialField.ID.New:
                    compiledName = "_new";
                    break;
                    break;
                default:
                    Contract.Assert(false); // unexpected ID
                    break;
                    break;
            }
        }

        protected override ILvalue EmitMemberSelect(Action<ConcreteSyntaxTree> obj, Type objType, MemberDecl member, List<TypeArgumentInstantiation> typeArgs, Dictionary<TypeParameter, Type> typeMap,
          Type expectedType, string/*?*/ additionalCustomParameter, bool internalAccess = false)
        {
            var memberStatus = DatatypeWrapperEraser.GetMemberStatus(Options, member);
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_39(876L, memberStatus, DatatypeWrapperEraser.MemberCompileStatus.Identity))
            {
                return SimpleLvalue(obj);
            }
            else if (MutateCSharp.Schemata236.ReplaceBinExprOp_39(877L, memberStatus, DatatypeWrapperEraser.MemberCompileStatus.AlwaysTrue))
            {
                return SimpleLvalue(w => w.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(878L, "true")));
            }
            else if (member is SpecialField sf && !(member is ConstantField))
            {
                GetSpecialFieldInfo(sf.SpecialId, sf.IdParam, objType, out var compiledName, out _, out _);
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_25(883L, compiledName.Length, MutateCSharp.Schemata236.ReplaceNumericConstant_1(879L, 0)))
                {
                    if (member.EnclosingClass is DatatypeDecl)
                    {
                        if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(894L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_7(888L, () => member.EnclosingClass is TupleTypeDecl, () => sf.Type.Subst(typeMap).IsCharType), () => UnicodeCharEnabled))
                        {
                            return SuffixLvalue(obj, $".{compiledName}().value()");
                        }
                        else
                        {
                            return SuffixLvalue(obj, $".{compiledName}()");
                        }
                    }
                    else
                    {
                        return SuffixLvalue(obj, $".{compiledName}");
                    }
                }
                else
                {
                    // Assume it's already handled by the caller
                    return SimpleLvalue(obj);
                }
            }
            else if (member is Function fn)
            {
                var wr = new ConcreteSyntaxTree();
                EmitNameAndActualTypeArgs(IdName(member), TypeArgumentInstantiation.ToActuals(ForTypeParameters(typeArgs, member, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(900L, false))), member.tok, wr);
                var needsEtaConversion = MutateCSharp.Schemata236.ReplaceBinExprOp_17(919L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_17(901L, () => typeArgs.Any()
        , () => additionalCustomParameter != null
        ), () => (MutateCSharp.Schemata236.ReplaceBinExprOp_7(913L, () => UnicodeCharEnabled, () => (MutateCSharp.Schemata236.ReplaceBinExprOp_17(907L, () => fn.ResultType.IsCharType, () => fn.Ins.Any(f => f.Type.IsCharType))))));
                if (!needsEtaConversion)
                {
                    var nameAndTypeArgs = wr.ToString();
                    return SuffixLvalue(obj, $"::{nameAndTypeArgs}");
                }
                else
                {
                    // We need an eta conversion to adjust for the difference in arity or coerce inputs/outputs.
                    // (T0 a0, T1 a1, ...) -> obj.F(rtd0, rtd1, ..., additionalCustomParameter, a0, a1, ...)
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(925L, "("));
                    var sep = "";
                    EmitTypeDescriptorsActuals(ForTypeDescriptors(typeArgs, member.EnclosingClass, member, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(926L, false)), fn.tok, wr, ref sep);
                    if (additionalCustomParameter != null)
                    {
                        wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(927L, "{0}{1}"), sep, additionalCustomParameter);
                        sep = MutateCSharp.Schemata236.ReplaceStringConstant_0(928L, ", ");
                    }
                    var prefixWr = new ConcreteSyntaxTree();
                    var prefixSep = "";
                    prefixWr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(929L, "("));
                    foreach (var arg in fn.Ins)
                    {
                        if (!arg.IsGhost)
                        {
                            var name = idGenerator.FreshId(MutateCSharp.Schemata236.ReplaceStringConstant_0(930L, "_eta"));
                            var ty = arg.Type.Subst(typeMap);
                            prefixWr.Write($"{prefixSep}{BoxedTypeName(ty, prefixWr, arg.tok)} {name}");
                            wr.Write(sep);
                            var coercedWr = EmitCoercionIfNecessary(NativeObjectType, ty, arg.tok, wr);
                            coercedWr.Write(name);
                            sep = MutateCSharp.Schemata236.ReplaceStringConstant_0(931L, ", ");
                            prefixSep = MutateCSharp.Schemata236.ReplaceStringConstant_0(932L, ", ");
                        }
                    }
                    prefixWr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(933L, ") -> "));
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(934L, ")"));

                    if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(935L, () => fn.ResultType.IsCharType, () => UnicodeCharEnabled))
                    {
                        prefixWr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(941L, "dafny.CodePoint.valueOf("));
                        wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(942L, ")"));
                    }

                    return EnclosedLvalue(prefixWr.ToString(), obj, $".{wr}");
                }
            }
            else
            {
                var field = (Field)member;
                ILvalue lvalue;
                if (member.IsStatic)
                {
                    lvalue = SimpleLvalue(w =>
                    {
                        w.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(943L, "{0}.{1}("), TypeName_Companion(objType, w, member.tok, member), IdName(member));
                        EmitTypeDescriptorsActuals(ForTypeDescriptors(typeArgs, member.EnclosingClass, member, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(944L, false)), member.tok, w);
                        w.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(945L, ")"));
                    });
                }
                else if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(946L, () => NeedsCustomReceiver(member), () => !(member.EnclosingClass is TraitDecl)))
                {
                    // instance const in a newtype
                    Contract.Assert(typeArgs.Count == 0);
                    lvalue = SimpleLvalue(w =>
                    {
                        w.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(952L, "{0}.{1}("), TypeName_Companion(objType, w, member.tok, member), IdName(member));
                        obj(w);
                        w.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(953L, ")"));
                    });
                }
                else if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(960L, () => internalAccess, () => (MutateCSharp.Schemata236.ReplaceBinExprOp_17(954L, () => member is ConstantField, () => member.EnclosingClass is TraitDecl))))
                {
                    lvalue = SuffixLvalue(obj, $"._{member.GetCompileName(Options)}");
                }
                else if (internalAccess)
                {
                    lvalue = SuffixLvalue(obj, $".{IdName(member)}");
                }
                else if (member is ConstantField)
                {
                    lvalue = SimpleLvalue(w =>
                    {
                        obj(w);
                        w.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(966L, ".{0}("), IdName(member));
                        EmitTypeDescriptorsActuals(ForTypeDescriptors(typeArgs, member.EnclosingClass, member, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(967L, false)), member.tok, w);
                        w.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(968L, ")"));
                    });
                }
                else if (member.EnclosingClass is TraitDecl)
                {
                    lvalue = GetterSetterLvalue(obj, IdName(member), $"set_{IdName(member)}");
                }
                else
                {
                    lvalue = SuffixLvalue(obj, $".{IdName(member)}");
                }
                return CoercedLvalue(lvalue, field.Type, expectedType);
            }

            return default;
        }

        protected override void EmitConstructorCheck(string source, DatatypeCtor ctor, ConcreteSyntaxTree wr)
        {
            wr.Write($"{source}.is_{ctor.GetCompileName(Options)}()");
        }

        protected override string TypeName_Companion(Type type, ConcreteSyntaxTree wr, IToken tok, MemberDecl/*?*/ member)
        {
            type = UserDefinedType.UpcastToMemberEnclosingType(type, member);
            if (type is UserDefinedType udt)
            {
                var name = udt.ResolvedClass is TraitDecl ? udt.GetFullCompanionCompileName(Options) : FullTypeName(udt, member, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(969L, true));
                return TypeName_UDT(name, udt, wr, tok, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(970L, true));
            }
            else
            {
                return TypeName(type, wr, tok, member);
            }

            return default;
        }

        protected override ConcreteSyntaxTree EmitArraySelect(List<Action<ConcreteSyntaxTree>> indices, Type elmtType, ConcreteSyntaxTree wr)
        {
            Contract.Assert(indices != null && 1 <= indices.Count);  // follows from precondition
            var w = EmitArraySelect(indices.Count, out var wIndices, elmtType, wr);
            for (int i = MutateCSharp.Schemata236.ReplaceNumericConstant_1(971L, 0); MutateCSharp.Schemata236.ReplaceBinExprOp_5(975L, i, indices.Count); MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(980L, ref i))
            {
                var stringifiedIndex = new ConcreteSyntaxTree();
                indices[i](stringifiedIndex);
                var index = stringifiedIndex.ToString();
                if (!int.TryParse(index, out _))
                {
                    wIndices[i].Write($"{DafnyHelpersClass}.toInt({index})");
                }
                else
                {
                    wIndices[i].Write(index);
                }
            }
            return w;
        }

        protected override ConcreteSyntaxTree EmitArraySelect(List<Expression> indices, Type elmtType, bool inLetExprBody,
            ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            Contract.Assert(indices != null && 1 <= indices.Count);  // follows from precondition
            var w = EmitArraySelect(indices.Count, out var wIndices, elmtType, wr);

            for (int i = MutateCSharp.Schemata236.ReplaceNumericConstant_1(981L, 0); MutateCSharp.Schemata236.ReplaceBinExprOp_5(985L, i, indices.Count); MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(990L, ref i))
            {
                TrParenExprAsInt(indices[i], wIndices[i], inLetExprBody, wStmts);
            }

            return w;
        }

        private ConcreteSyntaxTree EmitArraySelect(int dimCount, out List<ConcreteSyntaxTree> wIndices, Type elmtType, ConcreteSyntaxTree wr)
        {
            elmtType = DatatypeWrapperEraser.SimplifyType(Options, elmtType);
            wIndices = new List<ConcreteSyntaxTree>();
            ConcreteSyntaxTree w;
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_2(995L, dimCount, MutateCSharp.Schemata236.ReplaceNumericConstant_1(991L, 1)))
            {
                if (elmtType.IsTypeParameter)
                {
                    wr.Write($"{FormatTypeDescriptorVariable(elmtType.AsTypeParameter)}.getArrayElement(");
                    w = wr.Fork();
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1000L, ", "));
                    wIndices.Add(wr.Fork());
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1001L, ")"));
                }
                else
                {
                    w = wr.Fork();
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1002L, "["));
                    wIndices.Add(wr.Fork());
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1003L, "]"));
                }
            }
            else
            {
                if (elmtType.IsTypeParameter)
                {
                    w = wr.Fork();
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1004L, ".get("));
                    for (int i = MutateCSharp.Schemata236.ReplaceNumericConstant_1(1005L, 0); MutateCSharp.Schemata236.ReplaceBinExprOp_5(1009L, i, dimCount); MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(1014L, ref i))
                    {
                        if (MutateCSharp.Schemata236.ReplaceBinExprOp_8(1019L, i, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1015L, 0)))
                        {
                            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1024L, ", "));
                        }
                        wIndices.Add(wr.Fork());
                    }
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1025L, ")"));
                }
                else
                {
                    wr.Write($"(({TypeName(elmtType, wr, Token.NoToken)}{Repeat(MutateCSharp.Schemata236.ReplaceStringConstant_0(1026L, "[]"), dimCount)}) ((");
                    w = wr.Fork();
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1027L, ").elmts))"));
                    for (int i = MutateCSharp.Schemata236.ReplaceNumericConstant_1(1028L, 0); MutateCSharp.Schemata236.ReplaceBinExprOp_5(1032L, i, dimCount); MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(1037L, ref i))
                    {
                        wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1038L, "["));
                        wIndices.Add(wr.Fork());
                        wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1039L, "]"));
                    }
                }
            }
            return w;
        }

        protected override (ConcreteSyntaxTree/*array*/, ConcreteSyntaxTree/*rhs*/) EmitArrayUpdate(List<Action<ConcreteSyntaxTree>> indices, Type elementType, ConcreteSyntaxTree wr)
        {
            elementType = DatatypeWrapperEraser.SimplifyType(Options, elementType);
            ConcreteSyntaxTree wArray, wRhs;
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_2(1044L, indices.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1040L, 1)))
            {
                if (elementType.IsTypeParameter)
                {
                    wr.Write($"{FormatTypeDescriptorVariable(elementType.AsTypeParameter)}.setArrayElement(");
                    wArray = wr.Fork();
                    wr.Write($", {DafnyHelpersClass}.toInt(");
                    indices[MutateCSharp.Schemata236.ReplaceNumericConstant_1(1049L, 0)](wr);
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1053L, "), "));
                    wRhs = wr.Fork();
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1054L, ")"));
                }
                else
                {
                    wArray = wr.Fork();
                    wr.Write($"[{DafnyHelpersClass}.toInt(");
                    indices[MutateCSharp.Schemata236.ReplaceNumericConstant_1(1055L, 0)](wr);
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1059L, ")] = "));
                    wRhs = wr.Fork();
                }
            }
            else
            {
                if (elementType.IsTypeParameter)
                {
                    wArray = wr.Fork();
                    wr.Write($".set(");
                    for (int i = MutateCSharp.Schemata236.ReplaceNumericConstant_1(1060L, 0); MutateCSharp.Schemata236.ReplaceBinExprOp_5(1064L, i, indices.Count); MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(1069L, ref i))
                    {
                        if (MutateCSharp.Schemata236.ReplaceBinExprOp_8(1074L, i, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1070L, 0)))
                        {
                            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1079L, ", "));
                        }
                        wr.Write($"{DafnyHelpersClass}.toInt(");
                        indices[i](wr);
                        wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1080L, ")"));
                    }
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1081L, ", "));
                    wRhs = wr.Fork();
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1082L, ")"));
                }
                else
                {
                    wr.Write($"(({TypeName(elementType, wr, Token.NoToken)}{Repeat(MutateCSharp.Schemata236.ReplaceStringConstant_0(1083L, "[]"), indices.Count)}) (");
                    wArray = wr.Fork();
                    wr.Write($").elmts)");
                    for (int i = MutateCSharp.Schemata236.ReplaceNumericConstant_1(1084L, 0); MutateCSharp.Schemata236.ReplaceBinExprOp_5(1088L, i, indices.Count); MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(1093L, ref i))
                    {
                        wr.Write($"[{DafnyHelpersClass}.toInt(");
                        indices[i](wr);
                        wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1094L, ")]"));
                    }
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1095L, " = "));
                    wRhs = wr.Fork();
                }
            }
            return (wArray, wRhs);
        }

        protected override void EmitSeqSelectRange(Expression source, Expression lo, Expression hi, bool fromArray,
            bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (fromArray)
            {
                wr.Write($"{DafnySeqClass}.fromRawArrayRange({TypeDescriptor(source.Type.NormalizeExpand().TypeArgs[MutateCSharp.Schemata236.ReplaceNumericConstant_1(1096L, 0)], wr, source.tok)}, ");
            }
            TrParenExpr(source, wr, inLetExprBody, wStmts);
            if (fromArray)
            {
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1100L, ", "));
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_30(1101L, lo, null))
                {
                    TrExprAsInt(lo, wr, inLetExprBody, wStmts);
                }
                else
                {
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1102L, "0"));
                }
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1103L, ", "));
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_30(1104L, hi, null))
                {
                    TrExprAsInt(hi, wr, inLetExprBody, wStmts);
                }
                else
                {
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1105L, "java.lang.reflect.Array.getLength"));
                    TrParenExpr(source, wr, inLetExprBody, wStmts);
                }
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1106L, ")"));
            }
            else
            {
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(1109L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_30(1107L, lo, null), () => MutateCSharp.Schemata236.ReplaceBinExprOp_30(1108L, hi, null)))
                {
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1115L, ".subsequence("));
                    TrExprAsInt(lo, wr, inLetExprBody, wStmts);
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1116L, ", "));
                    TrExprAsInt(hi, wr, inLetExprBody, wStmts);
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1117L, ")"));
                }
                else if (MutateCSharp.Schemata236.ReplaceBinExprOp_30(1118L, lo, null))
                {
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1119L, ".drop"));
                    TrParenExpr(lo, wr, inLetExprBody, wStmts);
                }
                else if (MutateCSharp.Schemata236.ReplaceBinExprOp_30(1120L, hi, null))
                {
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1121L, ".take"));
                    TrParenExpr(hi, wr, inLetExprBody, wStmts);
                }
            }
        }

        protected override void EmitIndexCollectionSelect(Expression source, Expression index, bool inLetExprBody,
            ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            // Taken from C# compiler, assuming source is a DafnySequence type.
            if (source.Type.NormalizeToAncestorType().AsMultiSetType is { } multiSetType)
            {
                wr = EmitCoercionIfNecessary(from: NativeObjectType, to: Type.Int, tok: source.tok, wr: wr);
                wr.Write($"{DafnyMultiSetClass}.<{BoxedTypeName(multiSetType.Arg, wr, Token.NoToken)}>multiplicity(");
                TrParenExpr(source, wr, inLetExprBody, wStmts);
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1122L, ", "));
                wr.Append(Expr(index, inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1123L, ")"));
            }
            else if (source.Type.NormalizeToAncestorType().AsMapType is { } mapType)
            {
                wr = EmitCoercionIfNecessary(from: NativeObjectType, to: mapType.Range, tok: source.tok, wr: wr);
                TrParenExpr(source, wr, inLetExprBody, wStmts);
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1124L, ".get("));
                var coercedWr = EmitCoercionIfNecessary(from: mapType.Domain, to: NativeObjectType, tok: source.tok, wr: wr);
                EmitExpr(index, inLetExprBody, coercedWr, wStmts);
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1125L, ")"));
            }
            else
            {
                wr = EmitCoercionIfNecessary(from: NativeObjectType, to: source.Type.NormalizeToAncestorType().AsCollectionType.Arg, tok: source.tok, wr: wr);
                TrParenExpr(source, wr, inLetExprBody, wStmts);
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1126L, ".select"));
                TrParenExprAsInt(index, wr, inLetExprBody, wStmts);
            }
        }

        protected override void EmitMultiSetFormingExpr(MultiSetFormingExpr expr, bool inLetExprBody, ConcreteSyntaxTree wr,
            ConcreteSyntaxTree wStmts)
        {
            TrParenExpr(expr.E, wr, inLetExprBody, wStmts);
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1127L, ".asDafnyMultiset()"));
        }

        protected override void EmitIndexCollectionUpdate(Expression source, Expression index, Expression value,
            CollectionType resultCollectionType, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_40(1128L, resultCollectionType.AsSeqType, null))
            {
                wr.Write($"{DafnySeqClass}.<{BoxedTypeName(resultCollectionType.Arg, wr, Token.NoToken)}>update(");
                wr.Append(Expr(source, inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1129L, ", "));
                TrExprAsInt(index, wr, inLetExprBody, wStmts);
            }
            else if (resultCollectionType.AsMapType is { } mapType)
            {
                wr.Write($"{DafnyMapClass}.<{BoxedTypeName(mapType.Domain, wr, Token.NoToken)}, {BoxedTypeName(mapType.Range, wr, Token.NoToken)}>update(");
                wr.Append(Expr(source, inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1130L, ", "));
                wr.Append(Expr(index, inLetExprBody, wStmts));
            }
            else
            {
                Contract.Assert(resultCollectionType.AsMultiSetType != null);
                wr.Write($"{DafnyMultiSetClass}.<{BoxedTypeName(resultCollectionType.Arg, wr, Token.NoToken)}>update(");
                wr.Append(Expr(source, inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1131L, ", "));
                wr.Append(Expr(index, inLetExprBody, wStmts));
            }
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1132L, ", "));
            wr.Append(CoercedExpr(value, NativeObjectType, inLetExprBody, wStmts));
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1133L, ")"));
        }

        protected override void EmitRotate(Expression e0, Expression e1, bool isRotateLeft, ConcreteSyntaxTree wr,
          bool inLetExprBody, ConcreteSyntaxTree wStmts, FCE_Arg_Translator tr)
        {
            string nativeName = null;
            bool needsCast = MutateCSharp.Schemata236.ReplaceBooleanConstant_3(1134L, false);
            var nativeType = AsNativeType(e0.Type);
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_20(1135L, nativeType, null))
            {
                GetNativeInfo(nativeType.Sel, out nativeName, out _, out needsCast);
            }
            var leftShift = MutateCSharp.Schemata236.ReplaceBinExprOp_4(1136L, nativeType, null) ? MutateCSharp.Schemata236.ReplaceStringConstant_0(1137L, ".shiftLeft") : MutateCSharp.Schemata236.ReplaceStringConstant_0(1138L, "<<");
            var rightShift = MutateCSharp.Schemata236.ReplaceBinExprOp_4(1139L, nativeType, null) ? MutateCSharp.Schemata236.ReplaceStringConstant_0(1140L, ".shiftRight") : MutateCSharp.Schemata236.ReplaceStringConstant_0(1141L, ">>>");
            // ( e0 op1 e1) | (e0 op2 (width - e1))
            if (needsCast)
            {
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1142L, "(") + nativeName + MutateCSharp.Schemata236.ReplaceStringConstant_0(1143L, ")(") + CastIfSmallNativeType(e0.Type) + MutateCSharp.Schemata236.ReplaceStringConstant_0(1144L, "("));
            }
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1145L, "("));
            EmitShift(e0, e1, isRotateLeft ? leftShift : rightShift, isRotateLeft, nativeType, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(1146L, true), wr, inLetExprBody, wStmts, tr);
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1147L, ")"));
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_4(1148L, nativeType, null))
            {
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1149L, ".or"));
            }
            else
            {
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1150L, "|"));
            }
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1151L, "("));
            EmitShift(e0, e1, isRotateLeft ? rightShift : leftShift, !isRotateLeft, nativeType, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(1152L, false), wr, inLetExprBody, wStmts, tr);
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1153L, ")))"));
            if (needsCast)
            {
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1154L, "))"));
            }
        }

        private void EmitShift(Expression e0, Expression e1, string op, bool truncate, [CanBeNull] NativeType nativeType, bool firstOp,
            ConcreteSyntaxTree wr, bool inLetExprBody, ConcreteSyntaxTree wStmts, FCE_Arg_Translator tr)
        {
            var bv = e0.Type.NormalizeToAncestorType().AsBitVectorType;
            if (truncate)
            {
                wr = EmitBitvectorTruncation(bv, nativeType, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(1155L, true), wr);
            }
            tr(e0, wr, inLetExprBody, wStmts);
            wr.Write($" {op} ");
            if (!firstOp)
            {
                wr.Write($"({bv.Width} - ");
            }
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1156L, "(("));
            tr(e1, wr, inLetExprBody, wStmts);
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1157L, ")"));
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_4(1158L, AsNativeType(e1.Type), null))
            {
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1159L, ".intValue()"));
            }
            if (!firstOp)
            {
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1160L, ")"));
            }
        }

        protected override ConcreteSyntaxTree EmitBitvectorTruncation(BitvectorType bvType, [CanBeNull] NativeType nativeType,
          bool surroundByUnchecked, ConcreteSyntaxTree wr)
        {

            string nativeName = null, literalSuffix = null;
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_20(1161L, nativeType, null))
            {
                GetNativeInfo(nativeType.Sel, out nativeName, out literalSuffix, out _);
            }
            // --- Before
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_4(1162L, nativeType, null))
            {
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1163L, "(("));
            }
            else
            {
                wr.Write($"({nativeName}) {CastIfSmallNativeType(nativeType)}((");
            }
            // --- Middle
            var middle = wr.Fork();
            // --- After
            // do the truncation, if needed
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_4(1164L, nativeType, null))
            {
                wr.Write($").and((java.math.BigInteger.ONE.shiftLeft({bvType.Width})).subtract(java.math.BigInteger.ONE)))");
            }
            else if (MutateCSharp.Schemata236.ReplaceBinExprOp_5(1165L, bvType.Width, nativeType.Bitwidth))
            {
                // print in hex, because that looks nice
                wr.Write($") & {CastIfSmallNativeType(nativeType)}0x{MutateCSharp.Schemata236.ReplaceBinExprOp_43(1177L, (MutateCSharp.Schemata236.ReplaceBinExprOp_42(1173L, MutateCSharp.Schemata236.ReplaceNumericConstant_41(1170L, 1UL), bvType.Width)), MutateCSharp.Schemata236.ReplaceNumericConstant_41(1174L, 1)):X}{literalSuffix})");
            }
            else
            {
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1184L, "))")); // close the parentheses for the cast
            }
            return middle;
        }

        protected override bool CompareZeroUsingSign(Type type)
        {
            // Everything is boxed, so everything benefits from avoiding explicit 0
            return MutateCSharp.Schemata236.ReplaceBooleanConstant_3(1185L, true);
        }

        protected override ConcreteSyntaxTree EmitSign(Type type, ConcreteSyntaxTree wr)
        {
            ConcreteSyntaxTree w;
            var nt = AsNativeType(type);
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_4(1186L, nt, null))
            {
                w = wr.Fork();
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1187L, ".signum()"));
            }
            else if (MutateCSharp.Schemata236.ReplaceBinExprOp_44(1192L, nt.LowerBound, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1188L, 0)))
            {
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1194L, "("));
                w = wr.Fork();
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1195L, " == 0 ? 0 : 1)"));
            }
            else
            {
                wr.Write($"{HelperClass(nt)}.signum(");
                w = wr.Fork();
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1196L, ")"));
            }
            return w;
        }

        protected override IClassWriter/*?*/ DeclareDatatype(DatatypeDecl dt, ConcreteSyntaxTree wr)
        {
            if (dt is TupleTypeDecl tupleTypeDecl)
            {
                // CreateTuple() produces quite different code than this method would
                // by treating a tuple declaration as just a special case of a datatype.
                // Compare to the C# compiler which just compiles tuples like datatypes
                // with a bit of special handling for the name.
                // This could be changed to match at some point, but it would break
                // code that relies on the current runtime representation of tuples in Java.
                CreateTuple(tupleTypeDecl.Dims, wr);
                return null;
            }

            var w = CompileDatatypeBase(dt, wr);
            CompileDatatypeConstructors(dt, wr);
            return w;
        }

        IClassWriter CompileDatatypeBase(DatatypeDecl dt, ConcreteSyntaxTree wr)
        {
            var DtT_TypeArgs = TypeParameters(dt.TypeArgs);
            var justTypeArgs = MutateCSharp.Schemata236.ReplaceBinExprOp_2(1201L, dt.TypeArgs.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1197L, 0)) ? "" : MutateCSharp.Schemata236.ReplaceStringConstant_0(1206L, " ") + DtT_TypeArgs;
            var DtT_protected = IdName(dt) + DtT_TypeArgs;
            var simplifiedType = DatatypeWrapperEraser.SimplifyType(Options, UserDefinedType.FromTopLevelDecl(dt.tok, dt));
            var simplifiedTypeName = TypeName(simplifiedType, wr, dt.tok);

            var filename = $"{ModulePath}/{IdName(dt)}.java";
            wr = wr.NewFile(filename);
            FileCount += MutateCSharp.Schemata236.ReplaceNumericConstant_1(1207L, 1);
            wr.WriteLine($"// Class {DtT_protected}");
            wr.WriteLine($"// Dafny class {DtT_protected} compiled into Java");
            wr.WriteLine($"package {ModuleName};");
            wr.WriteLine();
            EmitImports(wr, out _);
            wr.WriteLine();
            //TODO: Figure out how to resolve type checking warnings
            // from here on, write everything into the new block created here:
            EmitSuppression(wr);
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1211L, "public{0} class {1}"), dt.IsRecordType ? "" : MutateCSharp.Schemata236.ReplaceStringConstant_0(1212L, " abstract"), DtT_protected);
            var superTraits = dt.ParentTypeInformation.UniqueParentTraits();
            if (superTraits.Any())
            {
                wr.Write($" implements {superTraits.Comma(trait => TypeName(trait, wr, dt.tok))}");
            }
            var btw = wr.NewBlock();
            wr = btw;

            // constructor
            if (dt.IsRecordType)
            {
                DatatypeFieldsAndConstructor(dt.Ctors[MutateCSharp.Schemata236.ReplaceNumericConstant_1(1213L, 0)], MutateCSharp.Schemata236.ReplaceNumericConstant_1(1217L, 0), wr);
            }
            else
            {
                var wTypeFields = wr.Fork();
                var wCtorParams = new ConcreteSyntaxTree();
                var wCtorBody = wr.Format($"public {IdName(dt)}({wCtorParams})").NewBlock();
                EmitTypeDescriptorsForClass(dt.TypeArgs, dt, wTypeFields, wCtorParams, null, wCtorBody);
            }

            // type descriptor needs to be initialized before default value is generated (issue 3766)
            EmitTypeDescriptorMethod(dt, dt.TypeArgs, null, null, wr);

            // default value
            var wDefaultTypeArguments = new ConcreteSyntaxTree();
            var defaultMethodTypeDescriptorCount = MutateCSharp.Schemata236.ReplaceNumericConstant_1(1221L, 0);
            var usedTypeArgs = UsedTypeParameters(dt);
            ConcreteSyntaxTree wDefault;
            wr.WriteLine();
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_2(1229L, dt.TypeArgs.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1225L, 0)))
            {
                wr.Write($"private static final {simplifiedTypeName} theDefault = ");
                wDefault = wr.Fork();
                wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1234L, ";"));
                var w = wr.NewBlock($"public static {simplifiedTypeName} Default()");
                w.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1235L, "return theDefault;"));
            }
            else
            {
                wr.Write($"public static{justTypeArgs} {simplifiedTypeName} Default(");
                defaultMethodTypeDescriptorCount = EmitTypeDescriptorsForClass(dt.TypeArgs, dt, null, wr, wDefaultTypeArguments, null);
                var typeParameters = usedTypeArgs.Comma(tp => $"{tp.GetCompileName(Options)} {FormatDefaultTypeParameterValue(tp)}");
                var sep = MutateCSharp.Schemata236.ReplaceBinExprOp_7(1254L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_25(1240L, defaultMethodTypeDescriptorCount, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1236L, 0)), () => MutateCSharp.Schemata236.ReplaceBinExprOp_25(1249L, typeParameters.Length, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1245L, 0))) ? MutateCSharp.Schemata236.ReplaceStringConstant_0(1260L, ", ") : "";
                wr.Write($"{sep}{typeParameters}");
                var w = wr.NewBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(1261L, ")"));
                w.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1262L, "return "));
                wDefault = w.Fork();
                w.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1263L, ";"));
            }
            var groundingCtor = dt.GetGroundingCtor();
            if (groundingCtor.IsGhost)
            {
                wDefault.Write(ForcePlaceboValue(simplifiedType, wDefault, dt.tok));
            }
            else if (DatatypeWrapperEraser.GetInnerTypeOfErasableDatatypeWrapper(Options, dt, out var innerType))
            {
                wDefault.Write(DefaultValue(innerType, wDefault, dt.tok));
            }
            else
            {
                var nonGhostFormals = groundingCtor.Formals.Where(f => !f.IsGhost).ToList();
                var args = nonGhostFormals.Comma(f => DefaultValue(f.Type, wDefault, f.tok));
                EmitDatatypeValue(dt, groundingCtor,
                  dt.TypeArgs.ConvertAll(tp => (Type)new UserDefinedType(dt.tok, tp)),
                  dt is CoDatatypeDecl, $"{wDefaultTypeArguments}", args, wDefault);
            }

            // create methods
            foreach (var ctor in dt.Ctors.Where(ctor => !ctor.IsGhost))
            {
                var wCtorParams = new ConcreteSyntaxTree();
                var wCallArguments = new ConcreteSyntaxTree();
                var typeDescriptorCount = EmitTypeDescriptorsForClass(dt.TypeArgs, dt, null, wCtorParams, wCallArguments, null);
                wr.Write($"public static{justTypeArgs} {DtT_protected} {DtCreateName(ctor)}(");
                wr.Append(wCtorParams);
                var formalCount = WriteFormals(MutateCSharp.Schemata236.ReplaceBinExprOp_8(1268L, typeDescriptorCount, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1264L, 0)) ? MutateCSharp.Schemata236.ReplaceStringConstant_0(1273L, ", ") : "", ctor.Formals, wr);
                var sep = MutateCSharp.Schemata236.ReplaceBinExprOp_7(1292L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_8(1278L, typeDescriptorCount, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1274L, 0)), () => MutateCSharp.Schemata236.ReplaceBinExprOp_8(1287L, formalCount, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1283L, 0))) ? MutateCSharp.Schemata236.ReplaceStringConstant_0(1298L, ", ") : "";
                wr.NewBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(1299L, ")"))
                  .WriteLine($"return new {DtCtorDeclarationName(ctor, dt.TypeArgs)}({wCallArguments}{sep}{ctor.Formals.Where(f => !f.IsGhost).Comma(FormalName)});");
            }

            if (dt.IsRecordType)
            {
                // Also emit a "create_<ctor_name>" method that thunks to "create",
                // to provide a more uniform interface.

                var ctor = dt.Ctors[MutateCSharp.Schemata236.ReplaceNumericConstant_1(1300L, 0)];
                var wCtorParams = new ConcreteSyntaxTree();
                var wCallArguments = new ConcreteSyntaxTree();
                var typeDescriptorCount = EmitTypeDescriptorsForClass(dt.TypeArgs, dt, null, wCtorParams, wCallArguments, null);
                wr.Write($"public static{justTypeArgs} {DtT_protected} create_{ctor.GetCompileName(Options)}(");
                wr.Append(wCtorParams);
                var formalCount = WriteFormals(MutateCSharp.Schemata236.ReplaceBinExprOp_8(1308L, typeDescriptorCount, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1304L, 0)) ? MutateCSharp.Schemata236.ReplaceStringConstant_0(1313L, ", ") : "", ctor.Formals, wr);
                var sep = MutateCSharp.Schemata236.ReplaceBinExprOp_7(1332L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_8(1318L, typeDescriptorCount, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1314L, 0)), () => MutateCSharp.Schemata236.ReplaceBinExprOp_8(1327L, formalCount, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1323L, 0))) ? MutateCSharp.Schemata236.ReplaceStringConstant_0(1338L, ", ") : "";
                wr.NewBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(1339L, ")"))
                  .WriteLine($"return create({wCallArguments}{sep}{ctor.Formals.Where(f => !f.IsGhost).Comma(FormalName)});");
            }

            // query properties
            foreach (var ctor in dt.Ctors.Where(ctor => !ctor.IsGhost))
            {
                if (dt.IsRecordType)
                {
                    wr.WriteLine($"public boolean is_{ctor.GetCompileName(Options)}() {{ return true; }}");
                }
                else
                {
                    wr.WriteLine($"public boolean is_{ctor.GetCompileName(Options)}() {{ return this instanceof {dt.GetCompileName(Options)}_{ctor.GetCompileName(Options)}; }}");
                }
            }
            if (dt is CoDatatypeDecl)
            {
                wr.WriteLine($"public abstract {DtT_protected} Get();");
            }
            if (dt.HasFinitePossibleValues)
            {
                Contract.Assert(dt.TypeArgs.Count == 0);
                var w = wr.NewNamedBlock($"public static java.util.ArrayList<{DtT_protected}> AllSingletonConstructors()");
                string arraylist = MutateCSharp.Schemata236.ReplaceStringConstant_0(1340L, "singleton_iterator");
                w.WriteLine($"java.util.ArrayList<{DtT_protected}> {arraylist} = new java.util.ArrayList<>();");
                foreach (var ctor in dt.Ctors)
                {
                    Contract.Assert(ctor.Formals.Count == 0);
                    if (ctor.IsGhost)
                    {
                        w.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1341L, "{0}.add({1});"), arraylist, ForcePlaceboValue(UserDefinedType.FromTopLevelDecl(dt.tok, dt), w, dt.tok));
                    }
                    else
                    {
                        w.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1342L, "{0}.add(new {1}{2}());"), arraylist, DtT_protected, dt.IsRecordType ? "" : $"_{ctor.GetCompileName(Options)}");
                    }
                }
                w.WriteLine($"return {arraylist};");
            }
            // destructors
            foreach (var ctor in dt.Ctors)
            {
                foreach (var dtor in ctor.Destructors.Where(dtor => MutateCSharp.Schemata236.ReplaceBinExprOp_45(1347L, dtor.EnclosingCtors[MutateCSharp.Schemata236.ReplaceNumericConstant_1(1343L, 0)], ctor)))
                {
                    var compiledConstructorCount = dtor.EnclosingCtors.Count(constructor => !constructor.IsGhost);
                    if (MutateCSharp.Schemata236.ReplaceBinExprOp_25(1352L, compiledConstructorCount, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1348L, 0)))
                    {
                        var arg = dtor.CorrespondingFormals[MutateCSharp.Schemata236.ReplaceNumericConstant_1(1357L, 0)];
                        if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(1361L, () => !arg.IsGhost, () => arg.HasName))
                        {
                            var wDtor = wr.NewNamedBlock($"public {TypeName(arg.Type, wr, arg.tok)} dtor_{arg.CompileName}()");
                            if (dt.IsRecordType)
                            {
                                wDtor.WriteLine($"return this.{FieldName(arg, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1367L, 0))};");
                            }
                            else
                            {
                                wDtor.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1371L, "{0} d = this{1};"), DtT_protected, dt is CoDatatypeDecl ? MutateCSharp.Schemata236.ReplaceStringConstant_0(1372L, ".Get()") : "");
                                var compiledConstructorsProcessed = MutateCSharp.Schemata236.ReplaceNumericConstant_1(1373L, 0);
                                for (var i = MutateCSharp.Schemata236.ReplaceNumericConstant_1(1377L, 0); MutateCSharp.Schemata236.ReplaceBinExprOp_5(1381L, i, dtor.EnclosingCtors.Count); MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(1386L, ref i))
                                {
                                    var ctor_i = dtor.EnclosingCtors[i];
                                    Contract.Assert(arg.CompileName == dtor.CorrespondingFormals[i].CompileName);
                                    if (ctor_i.IsGhost)
                                    {
                                        continue;
                                    }
                                    if (MutateCSharp.Schemata236.ReplaceBinExprOp_5(1400L, compiledConstructorsProcessed, MutateCSharp.Schemata236.ReplaceBinExprOp_10(1391L, compiledConstructorCount, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1387L, 1))))
                                    {
                                        wDtor.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1405L, "if (d instanceof {0}_{1}) {{ return (({0}_{1}{2})d).{3}; }}"), dt.GetCompileName(Options),
                                          ctor_i.GetCompileName(Options), DtT_TypeArgs, FieldName(arg, i));
                                    }
                                    else
                                    {
                                        wDtor.WriteLine($"return (({dt.GetCompileName(Options)}_{ctor_i.GetCompileName(Options)}{DtT_TypeArgs})d).{FieldName(arg, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1406L, 0))};");
                                    }

                                    MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(1410L, ref compiledConstructorsProcessed);
                                }
                            }
                        }
                    }
                }
            }

            // FIXME: This is dodgy.  We can set the constructor body writer to null
            // only because we don't expect to use it, which is only because we don't
            // expect there to be fields.
            return new ClassWriter(this, btw, ctorBodyWriter: null);
        }

        void CompileDatatypeConstructors(DatatypeDecl dt, ConcreteSyntaxTree wrx)
        {
            Contract.Requires(dt != null);
            string typeParams = TypeParameters(dt.TypeArgs);
            if (dt.IsRecordType)
            {
                // There is only one constructor, and it is populated by CompileDatatypeBase
                return;
            }
            int constructorIndex = MutateCSharp.Schemata236.ReplaceNumericConstant_1(1411L, 0); // used to give each constructor a different name
            foreach (DatatypeCtor ctor in dt.Ctors.Where(ctor => !ctor.IsGhost))
            {
                var filename = $"{ModulePath}/{DtCtorDeclarationName(ctor)}.java";
                var wr = wrx.NewFile(filename);
                FileCount += MutateCSharp.Schemata236.ReplaceNumericConstant_1(1415L, 1);
                wr.WriteLine($"// Class {DtCtorDeclarationName(ctor, dt.TypeArgs)}");
                wr.WriteLine($"// Dafny class {DtCtorDeclarationName(ctor, dt.TypeArgs)} compiled into Java");
                wr.WriteLine($"package {ModuleName};");
                wr.WriteLine();
                EmitImports(wr, out _);
                wr.WriteLine();
                EmitSuppression(wr);
                var w = wr.NewNamedBlock($"public class {DtCtorDeclarationName(ctor, dt.TypeArgs)} extends {IdName(dt)}{typeParams}");
                DatatypeFieldsAndConstructor(ctor, constructorIndex, w);
                MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(1419L, ref constructorIndex);
            }
            if (dt is CoDatatypeDecl)
            {
                var filename = $"{ModulePath}/{dt.GetCompileName(Options)}__Lazy.java";
                var wr = wrx.NewFile(filename);
                FileCount += MutateCSharp.Schemata236.ReplaceNumericConstant_1(1420L, 1);
                wr.WriteLine($"// Class {dt.GetCompileName(Options)}__Lazy");
                wr.WriteLine($"// Dafny class {dt.GetCompileName(Options)}__Lazy compiled into Java");
                wr.WriteLine($"package {ModuleName};");
                wr.WriteLine();
                EmitImports(wr, out _);
                wr.WriteLine();
                EmitSuppression(wr); //TODO: Fix implementations so they do not need this suppression
                var w = wr.NewNamedBlock($"public class {dt.GetCompileName(Options)}__Lazy{typeParams} extends {IdName(dt)}{typeParams}");
                w.WriteLine($"public interface Computer {{ {dt.GetCompileName(Options)} run(); }}");
                w.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1424L, "Computer c;"));
                w.WriteLine($"{dt.GetCompileName(Options)}{typeParams} d;");

                var wCtorParams = new ConcreteSyntaxTree();
                var wBaseCallArguments = new ConcreteSyntaxTree();
                var typeDescriptorCount = EmitTypeDescriptorsForClass(dt.TypeArgs, dt, null, wCtorParams, wBaseCallArguments, null);
                var sep = MutateCSharp.Schemata236.ReplaceBinExprOp_8(1429L, typeDescriptorCount, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1425L, 0)) ? MutateCSharp.Schemata236.ReplaceStringConstant_0(1434L, ", ") : "";
                var wCtorBody = w.NewBlock($"public {dt.GetCompileName(Options)}__Lazy({wCtorParams}{sep}Computer c)");
                wCtorBody.WriteLine($"super({wBaseCallArguments});");
                wCtorBody.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1435L, "this.c = c;"));
                w.WriteLine($"public {dt.GetCompileName(Options)}{typeParams} Get() {{ if (c != null) {{ d = c.run(); c = null; }} return d; }}");
                w.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1436L, "public String toString() { return Get().toString(); }"));
            }
        }

        void DatatypeFieldsAndConstructor(DatatypeCtor ctor, int constructorIndex, ConcreteSyntaxTree wr)
        {
            Contract.Requires(ctor != null);
            Contract.Requires(0 <= constructorIndex && constructorIndex < ctor.EnclosingDatatype.Ctors.Count);
            Contract.Requires(wr != null);
            var dt = ctor.EnclosingDatatype;
            var i = MutateCSharp.Schemata236.ReplaceNumericConstant_1(1437L, 0);
            foreach (Formal arg in ctor.Formals)
            {
                if (!arg.IsGhost)
                {
                    wr.WriteLine($"public {TypeName(arg.Type, wr, arg.tok)} {FieldName(arg, i)};");
                    MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(1441L, ref i);
                }
            }

            var wTypeFields = wr.Fork();
            var wCtorParams = new ConcreteSyntaxTree();
            var wCtorBody = wr.Format($"public {DtCtorDeclarationName(ctor)} ({wCtorParams})").NewBlock();
            int typeDescriptorCount;
            if (ctor.EnclosingDatatype.IsRecordType)
            {
                typeDescriptorCount = EmitTypeDescriptorsForClass(dt.TypeArgs, dt, wTypeFields, wCtorParams, null, wCtorBody);
            }
            else
            {
                var wBaseCallArguments = wCtorBody.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1442L, "super")).ForkInParens();
                wCtorBody.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1443L, ";"));
                typeDescriptorCount = EmitTypeDescriptorsForClass(dt.TypeArgs, dt, null, wCtorParams, wBaseCallArguments, null);
            }
            WriteFormals(MutateCSharp.Schemata236.ReplaceBinExprOp_8(1448L, typeDescriptorCount, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1444L, 0)) ? MutateCSharp.Schemata236.ReplaceStringConstant_0(1453L, ", ") : "", ctor.Formals, wCtorParams);
            {
                var w = wCtorBody;
                i = MutateCSharp.Schemata236.ReplaceNumericConstant_1(1454L, 0);
                foreach (Formal arg in ctor.Formals)
                {
                    if (!arg.IsGhost)
                    {
                        w.WriteLine($"this.{FieldName(arg, i)} = {FormalName(arg, i)};");
                        MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(1458L, ref i);
                    }
                }
            }
            if (dt is CoDatatypeDecl)
            {
                string typeParams = TypeParameters(dt.TypeArgs);
                wr.WriteLine($"public {dt.GetCompileName(Options)}{typeParams} Get() {{ return this; }}");
            }
            // Equals method
            wr.WriteLine();
            wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1459L, "@Override"));
            {
                var w = wr.NewBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(1460L, "public boolean equals(Object other)"));
                w.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1461L, "if (this == other) return true;"));
                w.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1462L, "if (other == null) return false;"));
                w.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1463L, "if (getClass() != other.getClass()) return false;"));
                string typeParams = TypeParameters(dt.TypeArgs);
                w.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1464L, "{0} o = ({0})other;"), DtCtorDeclarationName(ctor, dt.TypeArgs));
                w.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1465L, "return true"));
                i = MutateCSharp.Schemata236.ReplaceNumericConstant_1(1466L, 0);
                foreach (var arg in ctor.Formals)
                {
                    if (!arg.IsGhost)
                    {
                        var nm = FieldName(arg, i);
                        w.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1470L, " && "));
                        if (IsDirectlyComparable(DatatypeWrapperEraser.SimplifyType(Options, arg.Type)))
                        {
                            w.Write($"this.{nm} == o.{nm}");
                        }
                        else
                        {
                            w.Write($"java.util.Objects.equals(this.{nm}, o.{nm})");
                        }

                        MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(1471L, ref i);
                    }
                }
                w.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1472L, ";"));
            }
            // GetHashCode method (Uses the djb2 algorithm)
            wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1473L, "@Override"));
            {
                var w = wr.NewBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(1474L, "public int hashCode()"));
                w.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1475L, "long hash = 5381;"));
                w.WriteLine($"hash = ((hash << 5) + hash) + {constructorIndex};");
                i = MutateCSharp.Schemata236.ReplaceNumericConstant_1(1476L, 0);
                foreach (Formal arg in ctor.Formals)
                {
                    if (!arg.IsGhost)
                    {
                        string nm = FieldName(arg, i);
                        w.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1480L, "hash = ((hash << 5) + hash) + "));
                        if (IsJavaPrimitiveType(arg.Type))
                        {
                            w.WriteLine($"{BoxedTypeName(arg.Type, w, Token.NoToken)}.hashCode(this.{nm});");
                        }
                        else
                        {
                            w.WriteLine($"java.util.Objects.hashCode(this.{nm});");
                        }

                        MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(1481L, ref i);
                    }
                }
                w.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1482L, "return (int)hash;"));
            }

            wr.WriteLine();
            wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1483L, "@Override"));
            {
                var w = wr.NewBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(1484L, "public String toString()"));
                string nm;
                if (dt is TupleTypeDecl)
                {
                    nm = "";
                }
                else
                {
                    nm = (dt.EnclosingModuleDefinition.TryToAvoidName ? "" : dt.EnclosingModuleDefinition.Name + MutateCSharp.Schemata236.ReplaceStringConstant_0(1485L, ".")) + dt.Name + MutateCSharp.Schemata236.ReplaceStringConstant_0(1486L, ".") + ctor.Name;
                }
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(1496L, () => dt is TupleTypeDecl, () => MutateCSharp.Schemata236.ReplaceBinExprOp_2(1491L, ctor.Formals.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1487L, 0))))
                {
                    // here we want parentheses and no name
                    w.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1502L, "return \"()\";"));
                }
                else if (dt is CoDatatypeDecl)
                {
                    w.WriteLine($"return \"{nm}\";");
                }
                else
                {
                    var tempVar = GenVarName(MutateCSharp.Schemata236.ReplaceStringConstant_0(1503L, "s"), ctor.Formals);
                    w.WriteLine($"StringBuilder {tempVar} = new StringBuilder();");
                    w.WriteLine($"{tempVar}.append(\"{nm}\");");
                    if (MutateCSharp.Schemata236.ReplaceBinExprOp_25(1508L, ctor.Formals.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1504L, 0)))
                    {
                        w.WriteLine($"{tempVar}.append(\"(\");");
                        i = MutateCSharp.Schemata236.ReplaceNumericConstant_1(1513L, 0);
                        foreach (var arg in ctor.Formals)
                        {
                            if (!arg.IsGhost)
                            {
                                if (MutateCSharp.Schemata236.ReplaceBinExprOp_25(1521L, i, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1517L, 0)))
                                {
                                    w.WriteLine($"{tempVar}.append(\", \");");
                                }
                                w.Write($"{tempVar}.append(");
                                var memberName = FieldName(arg, i);
                                if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(1526L, () => UnicodeCharEnabled, () => arg.Type.IsCharType))
                                {
                                    w.Write($"{DafnyHelpersClass}.ToCharLiteral(this.{memberName})");
                                }
                                else if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(1532L, () => UnicodeCharEnabled, () => arg.Type.IsStringType))
                                {
                                    w.Write($"{DafnyHelpersClass}.ToStringLiteral(this.{memberName})");
                                }
                                else if (IsJavaPrimitiveType(arg.Type))
                                {
                                    w.Write($"this.{memberName}");
                                }
                                else
                                {
                                    w.Write($"{DafnyHelpersClass}.toString(this.{memberName})");
                                }
                                w.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1538L, ");"));
                                MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(1539L, ref i);
                            }
                        }
                        w.WriteLine($"{tempVar}.append(\")\");");
                    }
                    w.WriteLine($"return {tempVar}.toString();");
                }
            }
        }

        string DtCtorDeclarationName(DatatypeCtor ctor, List<TypeParameter>/*?*/ typeParams)
        {
            Contract.Requires(ctor != null);
            Contract.Ensures(Contract.Result<string>() != null);

            return DtCtorDeclarationName(ctor) + TypeParameters(typeParams);
        }
        string DtCtorDeclarationName(DatatypeCtor ctor)
        {
            Contract.Requires(ctor != null);
            Contract.Ensures(Contract.Result<string>() != null);

            var dt = ctor.EnclosingDatatype;
            return dt.IsRecordType ? IdName(dt) : dt.GetCompileName(Options) + MutateCSharp.Schemata236.ReplaceStringConstant_0(1540L, "_") + ctor.GetCompileName(Options);
        }
        string DtCtorName(DatatypeCtor ctor, List<Type> typeArgs, ConcreteSyntaxTree wr)
        {
            Contract.Requires(ctor != null);
            Contract.Ensures(Contract.Result<string>() != null);

            var s = DtCtorName(ctor);
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(1551L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_26(1541L, typeArgs, null), () => MutateCSharp.Schemata236.ReplaceBinExprOp_25(1546L, typeArgs.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1542L, 0))))
            {
                s += MutateCSharp.Schemata236.ReplaceStringConstant_0(1557L, "<") + BoxedTypeNames(typeArgs, wr, ctor.tok) + MutateCSharp.Schemata236.ReplaceStringConstant_0(1558L, ">");
            }
            return s;
        }
        string DtCtorName(DatatypeCtor ctor)
        {
            Contract.Requires(ctor != null);
            Contract.Ensures(Contract.Result<string>() != null);

            var dt = ctor.EnclosingDatatype;
            if (dt is TupleTypeDecl tupleDecl)
            {
                return DafnyTupleClass(tupleDecl.NonGhostDims);
            }
            var dtName = IdProtectModule(dt.EnclosingModuleDefinition.GetCompileName(Options)) + MutateCSharp.Schemata236.ReplaceStringConstant_0(1559L, ".") + IdName(dt);
            return dt.IsRecordType ? dtName : dtName + MutateCSharp.Schemata236.ReplaceStringConstant_0(1560L, "_") + ctor.GetCompileName(Options);
        }
        string DtCreateName(DatatypeCtor ctor)
        {
            Contract.Assert(!ctor.IsGhost); // there should never be an occasion to ask for a ghost constructor
            if (ctor.EnclosingDatatype.IsRecordType)
            {
                return MutateCSharp.Schemata236.ReplaceStringConstant_0(1561L, "create");
            }
            return MutateCSharp.Schemata236.ReplaceStringConstant_0(1562L, "create_") + ctor.GetCompileName(Options);
        }

        private string FieldName(Formal formal, int i)
        {
            Contract.Requires(formal != null);
            Contract.Ensures(Contract.Result<string>() != null);

            return IdProtect(MutateCSharp.Schemata236.ReplaceStringConstant_0(1563L, "_") + (formal.HasName ? formal.CompileName : MutateCSharp.Schemata236.ReplaceStringConstant_0(1564L, "a") + i));
        }

        protected override void EmitPrintStmt(ConcreteSyntaxTree wr, Expression arg)
        {
            var wStmts = wr.Fork();
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1565L, "System.out.print("));
            EmitToString(wr, arg, wStmts);
            wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1566L, ");"));
        }

        protected void EmitToString(ConcreteSyntaxTree wr, Expression arg, ConcreteSyntaxTree wStmts)
        {
            if (arg.Type.IsArrowType)
            {
                var expr = arg.Resolved;
                if (expr is IdentifierExpr id)
                {
                    wr.Write(IdName(id.Var) + MutateCSharp.Schemata236.ReplaceStringConstant_0(1567L, " == null ? null : \"Function\""));
                }
                else
                {
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1568L, "\"Function\""));
                }
            }
            else
            {
                var argumentWriter = EmitToString(wr, arg.Type);
                argumentWriter.Append(Expr(arg, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(1569L, false), wStmts));
            }
        }

        private ConcreteSyntaxTree EmitToString(ConcreteSyntaxTree wr, Type type)
        {
            Contract.Requires(!type.IsArrayType);
            ConcreteSyntaxTree argumentWriter;
            type = DatatypeWrapperEraser.SimplifyTypeAndTrimNewtypes(Options, type);
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(1577L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_20(1570L, AsNativeType(type), null), () => MutateCSharp.Schemata236.ReplaceBinExprOp_44(1575L, AsNativeType(type).LowerBound, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1571L, 0))))
            {
                var nativeName = GetNativeTypeName(AsNativeType(type));
                switch (AsNativeType(type).Sel)
                {
                    case NativeType.Selection.Byte:
                        wr.Write("java.lang.Integer.toUnsignedString(java.lang.Byte.toUnsignedInt(");
                        argumentWriter = wr.Fork();
                        wr.Write("))");
                        break;
                        break;
                    case NativeType.Selection.UShort:
                        wr.Write("java.lang.Integer.toUnsignedString(java.lang.Short.toUnsignedInt(");
                        argumentWriter = wr.Fork();
                        wr.Write("))");
                        break;
                        break;
                    case NativeType.Selection.UInt:
                        wr.Write("java.lang.Integer.toUnsignedString(");
                        argumentWriter = wr.Fork();
                        wr.Write(")");
                        break;
                        break;
                    case NativeType.Selection.ULong:
                        wr.Write("java.lang.Long.toUnsignedString(");
                        argumentWriter = wr.Fork();
                        wr.Write(")");
                        break;
                        break;
                    default:
                        // Should be an unsigned type by assumption
                        Contract.Assert(false);
                        throw new cce.UnreachableException();
                        break;
                }
            }
            else
            {
                bool isGeneric = type.NormalizeToAncestorType().AsSeqType is { Arg: { IsTypeParameter: true } };
                if (type.NormalizeToAncestorType().IsStringType)
                {
                    argumentWriter = wr.ForkInParens();
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1583L, ".verbatimString()"));
                }
                else if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(1584L, () => type.NormalizeToAncestorType().IsCharType, () => UnicodeCharEnabled))
                {
                    wr.Write($"{DafnyHelpersClass}.ToCharLiteral(");
                    argumentWriter = wr.Fork();
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1590L, ")"));
                }
                else if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(1591L, () => isGeneric, () => !UnicodeCharEnabled))
                {
                    wr.Write($"((java.util.function.Function<{DafnySeqClass}<?>,String>)(_s -> (_s.elementType().defaultValue().getClass() == java.lang.Character.class ? _s.verbatimString() : String.valueOf(_s)))).apply(");
                    argumentWriter = wr.Fork();
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1597L, ")"));
                }
                else
                {
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1598L, "java.lang.String.valueOf("));
                    argumentWriter = wr.Fork();
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1599L, ")"));
                }
            }
            return argumentWriter;
        }

        protected override string IdProtect(string name)
        {
            return PublicIdProtectAux(name);
        }

        public override string PublicIdProtect(string name)
        {
            return PublicIdProtectAux(name);
        }

        private static string PublicIdProtectAux(string name)
        {
            name = name.Replace(MutateCSharp.Schemata236.ReplaceStringConstant_0(1600L, "_module"), MutateCSharp.Schemata236.ReplaceStringConstant_0(1601L, "_System"));
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_17(1608L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_13(1602L, name, ""), () => MutateCSharp.Schemata236.ReplaceBinExprOp_2(1603L, name.First(), '_')))
            {
                return name; // no need to further protect this name
            }

            // TODO: Finish with all the public IDs that need to be protected
            switch (name)
            {
                // keywords Java 8 and before
                // https://docs.oracle.com/javase/tutorial/java/nutsandbolts/_keywords.html
                case "abstract":
                case "assert":
                case "break":
                case "byte":
                case "case":
                case "catch":
                case "char":
                case "class":
                case "continue":
                case "default":
                case "do":
                case "double":
                case "else":
                case "enum":
                case "extends":
                case "final":
                case "finally":
                case "float":
                case "for":
                case "if":
                case "implements":
                case "import":
                case "instanceof":
                case "int":
                case "interface":
                case "long":
                case "native":
                case "new":
                case "package":
                case "private":
                case "public":
                case "return":
                case "short":
                case "static":
                case "strictfp":
                case "super":
                case "switch":
                case "synchronized":
                case "this":
                case "throw":
                case "throws":
                case "transient":
                case "try":
                case "void":
                case "volatile":
                case "while":
                // keywords since Java 9
                case "exports":
                case "module":
                case "requires":
                // no longer used in Java but still reserved as keywords
                case "const":
                case "goto":
                // special identifiers since Java 10
                case "var":
                // literal values
                case "false":
                case "null":
                case "true":
                case "toString":
                case "equals":
                case "hashCode":
                    return name + "_"; // TODO: figure out what to do here (C# uses @, Go uses _, JS uses _$$_)
                    break;
                default:
                    return name; // Package name is not a keyword, so it can be used
                    break;
            }

            return default;
        }

        protected override void EmitReturn(List<Formal> outParams, ConcreteSyntaxTree wr)
        {
            outParams = outParams.Where(f => !f.IsGhost).ToList();
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_2(1618L, outParams.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1614L, 0)))
            {
                wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1623L, "return;"));
            }
            else if (MutateCSharp.Schemata236.ReplaceBinExprOp_2(1628L, outParams.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1624L, 1)))
            {
                wr.WriteLine($"return {IdName(outParams[MutateCSharp.Schemata236.ReplaceNumericConstant_1(1633L, 0)])};");
            }
            else
            {
                wr.WriteLine($"return new {DafnyTupleClass(outParams.Count)}<>({Util.Comma(outParams, IdName)});");
            }
        }

        // TODO: See if more types need to be added
        bool IsDirectlyComparable(Type t)
        {
            Contract.Requires(t != null);
            return MutateCSharp.Schemata236.ReplaceBinExprOp_17(1649L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_17(1643L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_17(1637L, () => t.IsBoolType, () => t.IsCharType), () => t.IsRefType), () => AsJavaNativeType(t) != null);
        }

        protected override void EmitActualTypeArgs(List<Type> typeArgs, IToken tok, ConcreteSyntaxTree wr)
        {
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_25(1659L, typeArgs.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1655L, 0)))
            {
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1664L, "<") + BoxedTypeNames(typeArgs, wr, tok) + MutateCSharp.Schemata236.ReplaceStringConstant_0(1665L, ">"));
            }
        }

        protected override void EmitNameAndActualTypeArgs(string protectedName, List<Type> typeArgs, IToken tok, ConcreteSyntaxTree wr)
        {
            EmitActualTypeArgs(typeArgs, tok, wr);
            wr.Write(protectedName);
        }

        protected override void EmitNew(Type type, IToken tok, CallStmt initCall, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var ctor = (Constructor)initCall?.Method; // correctness of cast follows from precondition of "EmitNew"
            wr.Write($"new {TypeName(type, wr, tok)}(");
            var sep = "";
            if (type is UserDefinedType definedType)
            {
                var typeArguments = TypeArgumentInstantiation.ListFromClass(definedType.ResolvedClass, definedType.TypeArgs);
                EmitTypeDescriptorsActuals(typeArguments, tok, wr, ref sep);
            }
            wr.Write(ConstructorArguments(initCall, wStmts, ctor, sep));
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1666L, ")"));
        }

        /// <summary>
        /// Returns whether or not there is a run-time type descriptor corresponding to "tp".
        ///
        /// Note, one might think that this method should return "tp.Characteristics.HasCompiledValue".
        /// However, currently, all built-in collection types in Java use type descriptors for their arguments.
        /// To get this threaded through everywhere, all type arguments must always be passed with a
        /// corresponding type descriptor. :(  Thus, this method returns "true".
        /// </summary>
        protected override bool NeedsTypeDescriptor(TypeParameter tp)
        {
            return tp.Parent is not TupleTypeDecl;
        }

        protected override void TypeArgDescriptorUse(bool isStatic, bool lookasideBody, TopLevelDeclWithMembers cl, out bool needsTypeParameter, out bool needsTypeDescriptor)
        {
            if (cl is DatatypeDecl dt)
            {
                needsTypeParameter = isStatic || DatatypeWrapperEraser.IsErasableDatatypeWrapper(Options, dt, out _);
                needsTypeDescriptor = MutateCSharp.Schemata236.ReplaceBooleanConstant_3(1667L, true);
            }
            else if (cl is TraitDecl)
            {
                needsTypeParameter = MutateCSharp.Schemata236.ReplaceBinExprOp_17(1668L, () => isStatic, () => lookasideBody);
                needsTypeDescriptor = MutateCSharp.Schemata236.ReplaceBinExprOp_17(1674L, () => isStatic, () => lookasideBody);
            }
            else
            {
                Contract.Assert(cl is ClassDecl);
                needsTypeParameter = isStatic;
                needsTypeDescriptor = isStatic;
            }
        }

        protected override string TypeDescriptor(Type type, ConcreteSyntaxTree wr, IToken tok)
        {
            type = DatatypeWrapperEraser.SimplifyTypeAndTrimSubsetTypes(Options, type);
            if (type is BoolType)
            {
                return $"{DafnyTypeDescriptor}.BOOLEAN";
            }
            else if (type is CharType)
            {
                return UnicodeCharEnabled ? $"{DafnyTypeDescriptor}.UNICODE_CHAR" : $"{DafnyTypeDescriptor}.CHAR";
            }
            else if (type is IntType or BigOrdinalType)
            {
                return $"{DafnyTypeDescriptor}.BIG_INTEGER";
            }
            else if (type is RealType)
            {
                return $"{DafnyTypeDescriptor}.BIG_RATIONAL";
            }
            else if (type is BitvectorType)
            {
                var t = (BitvectorType)type;
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_20(1680L, t.NativeType, null))
                {
                    return GetNativeTypeDescriptor(AsNativeType(type));
                }
                else
                {
                    return $"{DafnyTypeDescriptor}.BIG_INTEGER";
                }
            }
            else if (type is SetType setType)
            {
                return AddTypeDescriptorArgs(DafnySetClass, setType.TypeArgs, setType.TypeArgs, wr, tok);
            }
            else if (type is SeqType seqType)
            {
                return AddTypeDescriptorArgs(DafnySeqClass, seqType.TypeArgs, seqType.TypeArgs, wr, tok);
            }
            else if (type is MultiSetType multiSetType)
            {
                return AddTypeDescriptorArgs(DafnyMultiSetClass, multiSetType.TypeArgs, multiSetType.TypeArgs, wr, tok);
            }
            else if (type is MapType mapType)
            {
                return AddTypeDescriptorArgs(DafnyMapClass, mapType.TypeArgs, mapType.TypeArgs, wr, tok);
            }
            else if (type.IsArrayType)
            {
                ArrayClassDecl at = type.AsArrayType;
                var elType = UserDefinedType.ArrayElementType(type);
                var elTypeName = TypeName(elType, wr, tok, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(1681L, true));
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_8(1686L, at.Dims, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1682L, 1)))
                {
                    return $"{DafnyMultiArrayClass(at.Dims)}.<{elTypeName}>{TypeMethodName}()";
                }
                else if (elType.IsBoolType)
                {
                    return $"{DafnyTypeDescriptor}.BOOLEAN_ARRAY";
                }
                else if (elType.IsCharType)
                {
                    return $"{DafnyTypeDescriptor}.CHAR_ARRAY";
                }
                else if (MutateCSharp.Schemata236.ReplaceBinExprOp_20(1691L, AsNativeType(elType), null))
                {
                    switch (AsJavaNativeType(elType))
                    {
                        case JavaNativeType.Byte:
                            return $"{DafnyTypeDescriptor}.BYTE_ARRAY";
                            break;
                        case JavaNativeType.Short:
                            return $"{DafnyTypeDescriptor}.SHORT_ARRAY";
                            break;
                        case JavaNativeType.Int:
                            return $"{DafnyTypeDescriptor}.INT_ARRAY";
                            break;
                        case JavaNativeType.Long:
                            return $"{DafnyTypeDescriptor}.LONG_ARRAY";
                            break;
                        default:
                            Contract.Assert(false);
                            throw new cce.UnreachableException();
                            break;
                    }
                }
                else
                {
                    return $"(({DafnyTypeDescriptor}<{BoxedTypeName(type, wr, tok)}>)({TypeDescriptor(elType, wr, tok)}).arrayType())";
                }
            }
            else if (MutateCSharp.Schemata236.ReplaceBinExprOp_17(1692L, () => type.IsObjectQ, () => type.IsObject))
            {
                return $"{DafnyTypeDescriptor}.OBJECT";
            }
            else if (MutateCSharp.Schemata236.ReplaceBinExprOp_17(1698L, () => type.IsRefType, () => type.IsTraitType))
            {
                var typeName = TypeName(type, wr, tok);
                var typeNameSansTypeParameters = StripTypeParameters(typeName);
                return $"(({DafnyTypeDescriptor}<{typeName}>)" +
        MutateCSharp.Schemata236.ReplaceStringConstant_0(1704L, "(java.lang.Object)") +
                       $"{DafnyTypeDescriptor}.reference({typeNameSansTypeParameters}.class))";
            }
            else if (type.IsTypeParameter)
            {
                var tp = type.AsTypeParameter;
                Contract.Assert(tp != null);
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_23(1705L, thisContext, null) && thisContext.ParentFormalTypeParametersToActuals.TryGetValue(tp, out var instantiatedTypeParameter))
                {
                    return TypeDescriptor(instantiatedTypeParameter, wr, tok);
                }
                return FormatTypeDescriptorVariable(type.AsTypeParameter.GetCompileName(Options));
            }
            else if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(1715L, () => type.IsBuiltinArrowType, () => MutateCSharp.Schemata236.ReplaceBinExprOp_2(1710L, type.AsArrowType.Arity, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1706L, 1))))
            {
                // Can't go the usual route because java.util.function.Function doesn't have a _typeDescriptor() method
                var arrowType = type.AsArrowType;
                return $"{DafnyTypeDescriptor}.function({TypeDescriptor(arrowType.Args[MutateCSharp.Schemata236.ReplaceNumericConstant_1(1721L, 0)], wr, tok)}, {TypeDescriptor(arrowType.Result, wr, tok)})";
            }
            else if (type is UserDefinedType udt)
            {
                var s = FullTypeName(udt, null, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(1725L, true));
                var cl = udt.ResolvedClass;
                Contract.Assert(cl != null);

                if (cl.IsExtern(Options, out _, out _))
                {
                    var td = $"{DafnyTypeDescriptor}.<{BoxedTypeName(type, wr, tok)}> findType({s}.class";
                    if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(1736L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_26(1726L, udt.TypeArgs, null), () => MutateCSharp.Schemata236.ReplaceBinExprOp_8(1731L, udt.TypeArgs.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1727L, 0))))
                    {
                        td += $", {Util.Comma(udt.TypeArgs, arg => TypeDescriptor(arg, wr, tok))}";
                    }
                    return td + MutateCSharp.Schemata236.ReplaceStringConstant_0(1742L, ")");
                }

                List<Type> relevantTypeArgs;
                if (type.IsBuiltinArrowType)
                {
                    relevantTypeArgs = type.TypeArgs;
                }
                else if (cl is DatatypeDecl dt)
                {
                    relevantTypeArgs = udt.TypeArgs;
                }
                else
                {
                    relevantTypeArgs = new List<Type>();
                    for (int i = MutateCSharp.Schemata236.ReplaceNumericConstant_1(1743L, 0); MutateCSharp.Schemata236.ReplaceBinExprOp_5(1747L, i, cl.TypeArgs.Count); MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(1752L, ref i))
                    {
                        if (NeedsTypeDescriptor(cl.TypeArgs[i]))
                        {
                            relevantTypeArgs.Add(udt.TypeArgs[i]);
                        }
                    }
                }

                return AddTypeDescriptorArgs(s, udt.TypeArgs, relevantTypeArgs, wr, udt.tok);
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();
            }

            return default;
        }

        private string GetNativeTypeDescriptor(NativeType nt)
        {
            switch (AsJavaNativeType(nt))
            {
                case JavaNativeType.Byte:
                    return $"{DafnyTypeDescriptor}.BYTE";
                    break;
                case JavaNativeType.Short:
                    return $"{DafnyTypeDescriptor}.SHORT";
                    break;
                case JavaNativeType.Int:
                    return $"{DafnyTypeDescriptor}.INT";
                    break;
                case JavaNativeType.Long:
                    return $"{DafnyTypeDescriptor}.LONG";
                    break;
                default:
                    Contract.Assert(false); throw new cce.UnreachableException();
                    break;
            }

            return default;
        }

        private string AddTypeDescriptorArgs(string fullCompileName, List<Type> typeArgs, List<Type> relevantTypeArgs, ConcreteSyntaxTree wr, IToken tok)
        {
            Contract.Requires(fullCompileName != null);
            Contract.Requires(typeArgs != null);
            Contract.Requires(relevantTypeArgs != null);
            Contract.Requires(wr != null);
            Contract.Requires(tok != null);

            string s = $"{IdProtect(fullCompileName)}.";
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(1763L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_26(1753L, typeArgs, null), () => MutateCSharp.Schemata236.ReplaceBinExprOp_25(1758L, typeArgs.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1754L, 0))))
            {
                s += $"<{BoxedTypeNames(typeArgs, wr, tok)}>";
            }
            s += $"{TypeMethodName}(";
            s += Util.Comma(relevantTypeArgs, arg => TypeDescriptor(arg, wr, tok));
            return s + MutateCSharp.Schemata236.ReplaceStringConstant_0(1769L, ")");
        }

        protected override void EmitSetBuilder_New(ConcreteSyntaxTree wr, SetComprehension e, string collectionName)
        {
            wr.WriteLine($"java.util.ArrayList<{BoxedTypeName(e.Type.NormalizeToAncestorType().AsSetType.Arg, wr, e.tok)}> {collectionName} = new java.util.ArrayList<>();");
        }

        protected override void EmitMapBuilder_New(ConcreteSyntaxTree wr, MapComprehension e, string collectionName)
        {
            var mt = e.Type.NormalizeToAncestorType().AsMapType;
            var domType = mt.Domain;
            var ranType = mt.Range;
            wr.WriteLine($"java.util.HashMap<{BoxedTypeName(domType, wr, e.tok)}, {BoxedTypeName(ranType, wr, e.tok)}> {collectionName} = new java.util.HashMap<>();");
        }

        protected override void OrganizeModules(Program program, out List<ModuleDefinition> modules)
        {
            modules = new List<ModuleDefinition>();
            foreach (var m in program.CompileModules)
            {
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(1771L, () => !m.IsDefaultModule, () => !m.Name.Equals(MutateCSharp.Schemata236.ReplaceStringConstant_0(1770L, "_System"))))
                {
                    modules.Add(m);
                }
            }
            foreach (var m in program.CompileModules)
            {
                if (m.Name.Equals(MutateCSharp.Schemata236.ReplaceStringConstant_0(1777L, "_System")))
                {
                    modules.Add(m);
                }
            }
            foreach (var m in program.CompileModules)
            {
                if (m.IsDefaultModule)
                {
                    modules.Add(m);
                }
            }
        }

        protected override void EmitDatatypeValue(DatatypeValue dtv, string typeDescriptorArguments, string arguments, ConcreteSyntaxTree wr)
        {
            var dt = dtv.Ctor.EnclosingDatatype;
            var typeArgs = SelectNonGhost(dt, dtv.InferredTypeArgs);
            EmitDatatypeValue(dt, dtv.Ctor, typeArgs, dtv.IsCoCall, typeDescriptorArguments, arguments, wr);
        }

        void EmitDatatypeValue(DatatypeDecl dt, DatatypeCtor ctor, List<Type> typeArgs, bool isCoCall,
          string typeDescriptorArguments, string arguments, ConcreteSyntaxTree wr)
        {
            var dtName = dt is TupleTypeDecl tupleDecl
              ? DafnyTupleClass(tupleDecl.NonGhostDims)
              : IdProtectModule(dt.EnclosingModuleDefinition.GetCompileName(Options)) + MutateCSharp.Schemata236.ReplaceStringConstant_0(1778L, ".") + IdName(dt);
            var typeParams = MutateCSharp.Schemata236.ReplaceBinExprOp_2(1783L, typeArgs.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1779L, 0)) ? "" : $"<{BoxedTypeNames(typeArgs, wr, dt.tok)}>";
            var sep = MutateCSharp.Schemata236.ReplaceBinExprOp_7(1806L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_25(1792L, typeDescriptorArguments.Length, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1788L, 0)), () => MutateCSharp.Schemata236.ReplaceBinExprOp_25(1801L, arguments.Length, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1797L, 0))) ? MutateCSharp.Schemata236.ReplaceStringConstant_0(1812L, ", ") : "";
            if (!isCoCall)
            {
                // For an ordinary constructor (that is, one that does not guard any co-recursive calls), generate:
                //   Dt.<T>create_Cons( args )
                wr.Write($"{dtName}.{typeParams}{DtCreateName(ctor)}({typeDescriptorArguments}{sep}{arguments})");
            }
            else
            {
                var sep0 = MutateCSharp.Schemata236.ReplaceBinExprOp_25(1817L, typeDescriptorArguments.Length, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1813L, 0)) ? MutateCSharp.Schemata236.ReplaceStringConstant_0(1822L, ", ") : "";
                wr.Write($"new {dt.GetCompileName(Options)}__Lazy({typeDescriptorArguments}{sep0}");
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1823L, "() -> { return "));
                wr.Write($"new {DtCtorName(ctor)}{typeParams}({typeDescriptorArguments}{sep}{arguments})");
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1824L, "; })"));
            }
        }

        protected override ConcreteSyntaxTree CreateLambda(List<Type> inTypes, IToken tok, List<string> inNames,
            Type resultType, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts, bool untyped = false)
        {
            // TODO: there may be an opportunity to share code with CreateIIFE,
            // which may be worth it given all the necessary coercions.

            wr.Write('(');
            if (!untyped)
            {
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1825L, "({0}<{1}{2}>)"), DafnyFunctionIface(inTypes.Count), Util.Comma("", inTypes, t => BoxedTypeName(t, wr, tok) + MutateCSharp.Schemata236.ReplaceStringConstant_0(1826L, ", ")), BoxedTypeName(resultType, wr, tok));
            }
            var boxedInNames = inNames.Select(inName => ProtectedFreshId(inName + MutateCSharp.Schemata236.ReplaceStringConstant_0(1827L, "_boxed"))).ToList();
            wr.Write($"({boxedInNames.Comma(nm => nm)}) ->");
            var w = wr.NewExprBlock("");
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1828L, ")"));

            for (var i = MutateCSharp.Schemata236.ReplaceNumericConstant_1(1829L, 0); MutateCSharp.Schemata236.ReplaceBinExprOp_5(1833L, i, inNames.Count); MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(1838L, ref i))
            {
                w.Write($"{TypeName(inTypes[i], w, tok)} {inNames[i]} = ");
                var coercedW = EmitCoercionIfNecessary(NativeObjectType, inTypes[i], tok, w);
                coercedW.Write(boxedInNames[i]);
                w.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1839L, ";"));
            }

            return w;
        }

        protected override ConcreteSyntaxTree CreateIIFE0(Type resultType, IToken resultTok, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write($"(({DafnyFunctionIface(MutateCSharp.Schemata236.ReplaceNumericConstant_1(1840L, 0))}<{BoxedTypeName(resultType, wr, resultTok)}>)(() ->");
            var w = wr.NewBigExprBlock("", MutateCSharp.Schemata236.ReplaceStringConstant_0(1844L, ")).apply()"));
            return w;
        }

        protected override void EmitUnaryExpr(ResolvedUnaryOp op, Expression expr, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            switch (op)
            {
                case ResolvedUnaryOp.BoolNot:
                    TrParenExpr("!", expr, wr, inLetExprBody, wStmts);
                    break;
                    break;
                case ResolvedUnaryOp.BitwiseNot:
                    if (AsNativeType(expr.Type) != null)
                    {
                        TrParenExpr(CastIfSmallNativeType(expr.Type) + "~", expr, wr, inLetExprBody, wStmts);
                    }
                    else
                    {
                        TrParenExpr("", expr, wr, inLetExprBody, wStmts);
                        wr.Write(".not()");
                    }
                    break;
                    break;
                case ResolvedUnaryOp.Cardinality:
                    {
                        var collectionType = expr.Type.NormalizeToAncestorType().AsCollectionType;
                        if (collectionType is MultiSetType)
                        {
                            TrParenExpr("", expr, wr, inLetExprBody, wStmts);
                            wr.Write(".cardinality()");
                        }
                        else if (collectionType is SetType or MapType)
                        {
                            TrParenExpr("java.math.BigInteger.valueOf(", expr, wr, inLetExprBody, wStmts);
                            wr.Write(".size())");
                        }
                        else if (expr.Type.IsArrayType)
                        {
                            TrParenExpr("java.math.BigInteger.valueOf(java.lang.reflect.Array.getLength", expr, wr, inLetExprBody, wStmts);
                            wr.Write(")");
                        }
                        else
                        {
                            TrParenExpr("java.math.BigInteger.valueOf(", expr, wr, inLetExprBody, wStmts);
                            wr.Write(".length())");
                        }
                        break;
                    }

                    break;
                default:
                    Contract.Assert(false); throw new cce.UnreachableException();  // unexpected unary expression
                    break;
            }
        }

        // Find the class with static methods like "divideUnsigned" for the type
        private string HelperClass(NativeType nt)
        {
            return AsJavaNativeType(nt) == JavaNativeType.Long ? MutateCSharp.Schemata236.ReplaceStringConstant_0(1845L, "java.lang.Long") : MutateCSharp.Schemata236.ReplaceStringConstant_0(1846L, "java.lang.Integer");
        }

        protected override void CompileBinOp(BinaryExpr.ResolvedOpcode op, Expression e0, Expression e1, IToken tok,
          Type resultType, out string opString,
          out string preOpString, out string postOpString, out string callString, out string staticCallString,
          out bool reverseArguments, out bool truncateResult, out bool convertE1_to_int, out bool coerceE1, ConcreteSyntaxTree errorWr)
        {
            opString = null;
            preOpString = "";
            postOpString = "";
            callString = null;
            staticCallString = null;
            reverseArguments = MutateCSharp.Schemata236.ReplaceBooleanConstant_3(1847L, false);
            truncateResult = MutateCSharp.Schemata236.ReplaceBooleanConstant_3(1848L, false);
            convertE1_to_int = MutateCSharp.Schemata236.ReplaceBooleanConstant_3(1849L, false);
            coerceE1 = MutateCSharp.Schemata236.ReplaceBooleanConstant_3(1850L, false);

            void doPossiblyNativeBinOp(string o, string name, out string preOpS, out string opS,
              out string postOpS, out string callS, out string staticCallS)
            {
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_20(1851L, AsNativeType(resultType), null))
                {
                    var nativeName = GetNativeTypeName(AsNativeType(resultType));
                    if (MutateCSharp.Schemata236.ReplaceBinExprOp_13(1853L, o, MutateCSharp.Schemata236.ReplaceStringConstant_0(1852L, ">>>")) && resultType.AsBitVectorType is { Width: var width and (8 or 16 or 32 or 64) })
                    {
                        // Solves https://github.com/dafny-lang/dafny/issues/3734
                        preOpS = CastIfSmallNativeType(resultType);
                        opS = null;
                        postOpS = "";
                        callS = null;
                        staticCallS = $"{DafnyHelpersClass}.bv{width}ShiftRight";
                    }
                    else if (MutateCSharp.Schemata236.ReplaceBinExprOp_13(1855L, o, MutateCSharp.Schemata236.ReplaceStringConstant_0(1854L, "<<")) && resultType.AsBitVectorType is { Width: var width2 and (32 or 64) })
                    {
                        // Solves https://github.com/dafny-lang/dafny/issues/3734
                        preOpS = CastIfSmallNativeType(resultType);
                        opS = null;
                        postOpS = "";
                        callS = null;
                        staticCallS = $"{DafnyHelpersClass}.bv{width2}ShiftLeft";
                    }
                    else
                    {
                        preOpS = $"({nativeName}) {CastIfSmallNativeType(resultType)}(";
                        opS = o;
                        postOpS = MutateCSharp.Schemata236.ReplaceStringConstant_0(1856L, ")");
                        callS = null;
                        staticCallS = null;
                    }
                }
                else
                {
                    callS = name;
                    preOpS = "";
                    opS = null;
                    postOpS = "";
                    staticCallS = null;
                }
            }

            switch (op)
            {
                case BinaryExpr.ResolvedOpcode.BitwiseAnd:
                    doPossiblyNativeBinOp("&", "and", out preOpString, out opString, out postOpString, out callString, out staticCallString);
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.BitwiseOr:
                    doPossiblyNativeBinOp("|", "or", out preOpString, out opString, out postOpString, out callString, out staticCallString);
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.BitwiseXor:
                    doPossiblyNativeBinOp("^", "xor", out preOpString, out opString, out postOpString, out callString, out staticCallString);
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.EqCommon:
                    {
                        var eqType = DatatypeWrapperEraser.SimplifyType(Options, e0.Type);
                        if (eqType.IsRefType)
                        {
                            opString = "== (Object) ";
                        }
                        else if (IsDirectlyComparable(eqType))
                        {
                            opString = "==";
                        }
                        else
                        {
                            staticCallString = "java.util.Objects.equals";
                        }
                        break;
                    }

                    break;
                case BinaryExpr.ResolvedOpcode.NeqCommon:
                    {
                        var eqType = DatatypeWrapperEraser.SimplifyType(Options, e0.Type);
                        if (eqType.IsRefType)
                        {
                            opString = "!= (Object) ";
                        }
                        else if (IsDirectlyComparable(eqType))
                        {
                            opString = "!=";
                        }
                        else
                        {
                            preOpString = "!";
                            staticCallString = "java.util.Objects.equals";
                        }
                        break;
                    }

                    break;
                case BinaryExpr.ResolvedOpcode.Lt:
                case BinaryExpr.ResolvedOpcode.Le:
                case BinaryExpr.ResolvedOpcode.Ge:
                case BinaryExpr.ResolvedOpcode.Gt:
                    var call = false;
                    var argNative = AsNativeType(e0.Type);
                    if (argNative != null && argNative.LowerBound >= 0)
                    {
                        staticCallString = HelperClass(argNative) + ".compareUnsigned";
                        call = true;
                    }
                    else if (argNative == null)
                    {
                        callString = "compareTo";
                        call = true;
                    }
                    if (call)
                    {
                        switch (op)
                        {
                            case BinaryExpr.ResolvedOpcode.Lt:
                                postOpString = " < 0";
                                break;
                            case BinaryExpr.ResolvedOpcode.Le:
                                postOpString = " <= 0";
                                break;
                            case BinaryExpr.ResolvedOpcode.Ge:
                                postOpString = " >= 0";
                                break;
                            case BinaryExpr.ResolvedOpcode.Gt:
                                postOpString = " > 0";
                                break;
                            default:
                                Contract.Assert(false);
                                throw new cce.UnreachableException();
                        }
                    }
                    else
                    {
                        switch (op)
                        {
                            case BinaryExpr.ResolvedOpcode.Lt:
                                opString = "<";
                                break;
                            case BinaryExpr.ResolvedOpcode.Le:
                                opString = "<=";
                                break;
                            case BinaryExpr.ResolvedOpcode.Ge:
                                opString = ">=";
                                break;
                            case BinaryExpr.ResolvedOpcode.Gt:
                                opString = ">";
                                break;
                            default:
                                Contract.Assert(false);
                                throw new cce.UnreachableException();
                        }
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.LeftShift:
                    doPossiblyNativeBinOp("<<", "shiftLeft", out preOpString, out opString, out postOpString, out callString, out staticCallString);
                    truncateResult = true;
                    convertE1_to_int = AsNativeType(e1.Type) == null;
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.RightShift:
                    doPossiblyNativeBinOp(">>>", "shiftRight", out preOpString, out opString, out postOpString, out callString, out staticCallString);
                    convertE1_to_int = AsNativeType(e1.Type) == null;
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Add:
                    truncateResult = true;
                    if (resultType.IsCharType)
                    {
                        preOpString = $"({CharTypeName(false)}) (";
                        postOpString = ")";
                        opString = "+";
                    }
                    else
                    {
                        doPossiblyNativeBinOp("+", "add", out preOpString, out opString, out postOpString, out callString, out staticCallString);
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Sub:
                    truncateResult = true;
                    if (resultType.IsCharType)
                    {
                        preOpString = $"({CharTypeName(false)}) (";
                        opString = "-";
                        postOpString = ")";
                    }
                    else
                    {
                        doPossiblyNativeBinOp("-", "subtract", out preOpString, out opString, out postOpString, out callString, out staticCallString);
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Mul:
                    doPossiblyNativeBinOp("*", "multiply", out preOpString, out opString, out postOpString, out callString, out staticCallString);
                    truncateResult = true;
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Div:
                    if (NeedsEuclideanDivision(resultType))
                    {
                        staticCallString = $"{DafnyEuclideanClass}.EuclideanDivision";
                    }
                    else if (AsNativeType(resultType) != null)
                    {
                        var nt = AsNativeType(resultType);
                        if (nt.Sel == NativeType.Selection.Byte)
                        {
                            staticCallString = $"{DafnyHelpersClass}.divideUnsignedByte";
                        }
                        else if (nt.Sel == NativeType.Selection.UShort)
                        {
                            staticCallString = $"{DafnyHelpersClass}.divideUnsignedShort";
                        }
                        else
                        {
                            preOpString = CastIfSmallNativeType(resultType);
                            staticCallString = HelperClass(AsNativeType(resultType)) + ".divideUnsigned";
                        }
                    }
                    else
                    {
                        callString = "divide";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Mod:
                    if (NeedsEuclideanDivision(resultType))
                    {
                        staticCallString = $"{DafnyEuclideanClass}.EuclideanModulus";
                    }
                    else if (AsNativeType(resultType) != null)
                    {
                        var nt = AsNativeType(resultType);
                        if (nt.Sel == NativeType.Selection.Byte)
                        {
                            staticCallString = $"{DafnyHelpersClass}.remainderUnsignedByte";
                        }
                        else if (nt.Sel == NativeType.Selection.UShort)
                        {
                            staticCallString = $"{DafnyHelpersClass}.remainderUnsignedShort";
                        }
                        else
                        {
                            preOpString = CastIfSmallNativeType(resultType);
                            staticCallString = HelperClass(AsNativeType(resultType)) + ".remainderUnsigned";
                        }
                    }
                    else
                    {
                        callString = "mod";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.SetEq:
                case BinaryExpr.ResolvedOpcode.MultiSetEq:
                case BinaryExpr.ResolvedOpcode.SeqEq:
                case BinaryExpr.ResolvedOpcode.MapEq:
                    callString = "equals";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.ProperSubset:
                case BinaryExpr.ResolvedOpcode.ProperMultiSubset:
                    callString = "isProperSubsetOf";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Subset:
                case BinaryExpr.ResolvedOpcode.MultiSubset:
                    callString = "isSubsetOf";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Disjoint:
                case BinaryExpr.ResolvedOpcode.MultiSetDisjoint:
                    callString = $"<{BoxedTypeName(e1.Type.NormalizeToAncestorType().AsCollectionType.Arg, errorWr, tok)}>disjoint";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.InSet:
                case BinaryExpr.ResolvedOpcode.InMultiSet:
                case BinaryExpr.ResolvedOpcode.InMap:
                    callString = $"<{BoxedTypeName(e0.Type, errorWr, tok)}>contains";
                    reverseArguments = true;
                    coerceE1 = true;
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Union:
                    staticCallString = $"{DafnySetClass}.<{BoxedTypeName(resultType.AsSetType.Arg, errorWr, tok)}>union";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.MultiSetUnion:
                    staticCallString = $"{DafnyMultiSetClass}.<{BoxedTypeName(resultType.AsMultiSetType.Arg, errorWr, tok)}>union";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.MapMerge:
                    staticCallString = $"{DafnyMapClass}.<{BoxedTypeName(resultType.AsMapType.Domain, errorWr, tok)}, {BoxedTypeName(resultType.AsMapType.Range, errorWr, tok)}>merge";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Intersection:
                    staticCallString = $"{DafnySetClass}.<{BoxedTypeName(resultType.AsSetType.Arg, errorWr, tok)}>intersection";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.MultiSetIntersection:
                    staticCallString = $"{DafnyMultiSetClass}.<{BoxedTypeName(resultType.AsMultiSetType.Arg, errorWr, tok)}>intersection";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.SetDifference:
                    staticCallString = $"{DafnySetClass}.<{BoxedTypeName(resultType.AsSetType.Arg, errorWr, tok)}>difference";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.MultiSetDifference:
                    staticCallString = $"{DafnyMultiSetClass}.<{BoxedTypeName(resultType.AsMultiSetType.Arg, errorWr, tok)}>difference";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.MapSubtraction:
                    staticCallString = $"{DafnyMapClass}.<{BoxedTypeName(resultType.AsMapType.Domain, errorWr, tok)}, {BoxedTypeName(resultType.AsMapType.Range, errorWr, tok)}>subtract";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.ProperPrefix:
                    callString = "isProperPrefixOf";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Prefix:
                    callString = "isPrefixOf";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Concat:
                    staticCallString = $"{DafnySeqClass}.<{BoxedTypeName(resultType.AsSeqType.Arg, errorWr, tok)}>concatenate";
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.InSeq:
                    callString = "contains";
                    reverseArguments = true;
                    coerceE1 = true;
                    break;
                    break;
                default:
                    base.CompileBinOp(op, e0, e1, tok, resultType,
                      out opString, out preOpString, out postOpString, out callString, out staticCallString, out reverseArguments, out truncateResult, out convertE1_to_int, out coerceE1,
                      errorWr);
                    break;
                    break;
            }
        }

        private void CreateTuple(int i, ConcreteSyntaxTree outputWr)
        {
            Contract.Requires(0 <= i);
            Contract.Requires(outputWr != null);

            var wrTop = outputWr.NewFile(Path.Combine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1857L, "dafny"), $"Tuple{i}.java"));

            wrTop.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1858L, "package dafny;"));
            wrTop.WriteLine();
            EmitSuppression(wrTop);
            wrTop.Write($"public class Tuple{i}");
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_25(1863L, i, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1859L, 0)))
            {
                wrTop.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1868L, "<{0}>"), Util.Comma(i, j => $"T{j}"));
            }

            var wr = wrTop.NewBlock("");
            for (var j = MutateCSharp.Schemata236.ReplaceNumericConstant_1(1869L, 0); MutateCSharp.Schemata236.ReplaceBinExprOp_5(1873L, j, i); MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(1878L, ref j))
            {
                wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1879L, "private T{0} _{0};"), j);
            }
            wr.WriteLine();

            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1880L, "public Tuple{0}({1}"), i, Util.Comma(i, j => $"T{j} _{j}"));
            var wrCtor = wr.NewBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(1881L, ")"));
            for (var j = MutateCSharp.Schemata236.ReplaceNumericConstant_1(1882L, 0); MutateCSharp.Schemata236.ReplaceBinExprOp_5(1886L, j, i); MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(1891L, ref j))
            {
                wrCtor.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1892L, "this._{0} = _{0};"), j);
            }

            wr.WriteLine();
            var typeParams = new List<TypeParameter>();
            for (var j = MutateCSharp.Schemata236.ReplaceNumericConstant_1(1893L, 0); MutateCSharp.Schemata236.ReplaceBinExprOp_5(1897L, j, i); MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(1902L, ref j))
            {
                typeParams.Add(new TypeParameter(RangeToken.NoToken, new Name($"T{j}"), TypeParameter.TPVarianceSyntax.Covariant_Permissive));
            }
            var typeParamString = TypeParameters(typeParams);
            var initializer = string.Format(MutateCSharp.Schemata236.ReplaceStringConstant_0(1903L, "Default({0})"), Util.Comma(i, j => $"_td_T{j}.defaultValue()"));
            EmitTypeDescriptorMethod(null, typeParams, $"Tuple{i}{typeParamString}", initializer, wr);

            // public static Tuple4<T0, T1, T2, T3> Default(dafny.TypeDescriptor<T0> _td_T0, dafny.TypeDescriptor<T1> _td_T1, dafny.TypeDescriptor<T2> _td_T2, dafny.TypeDescriptor<T3> _td_T3) {
            //   return new Tuple4<>(_td_T0.defaultValue(), _td_T1.defaultValue(), _td_T2.defaultValue(), _td_T3.defaultValue());
            // }
            wr.WriteLine();
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_2(1908L, i, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1904L, 0)))
            {
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1913L, "public static Tuple0"));
            }
            else
            {
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1914L, "public static <{1}> Tuple{0}<{1}>"), i, Util.Comma(i, j => $"T{j}"));
            }
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1915L, " Default({0})"), Util.Comma(i, j => $"T{j} {FormatDefaultTypeParameterValueName($"T{j}")}"));
            {
                var w = wr.NewBlock("");
                w.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1916L, "return create({0});"), Util.Comma(i, j => $"{FormatDefaultTypeParameterValueName($"T{j}")}"));
            }

            // create method
            wr.WriteLine();
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_2(1921L, i, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1917L, 0)))
            {
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1926L, "public static Tuple0"));
            }
            else
            {
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1927L, "public static <{1}> Tuple{0}<{1}>"), i, Util.Comma(i, j => $"T{j}"));
            }
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(1928L, " create({0})"), Util.Comma(i, j => $"T{j} _{j}"));
            {
                var w = wr.NewBlock("");
                w.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1929L, "return new Tuple{0}({1});"), i, Util.Comma(i, j => $"_{j}"));
            }

            wr.WriteLine();
            wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1930L, "@Override"));
            var wrEquals = wr.NewBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(1931L, "public boolean equals(Object obj)"));
            wrEquals.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1932L, "if (this == obj) return true;"));
            wrEquals.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1933L, "if (obj == null) return false;"));
            wrEquals.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1934L, "if (getClass() != obj.getClass()) return false;"));
            wrEquals.WriteLine($"Tuple{i} o = (Tuple{i}) obj;");
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_25(1939L, i, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1935L, 0)))
            {
                wrEquals.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1944L, "return {0};"), Util.Comma(MutateCSharp.Schemata236.ReplaceStringConstant_0(1945L, " && "), i, j => $"java.util.Objects.equals(this._{j}, o._{j})"));
            }
            else
            {
                wrEquals.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1946L, "return true;"));
            }

            wr.WriteLine();
            wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1947L, "@Override"));
            var wrToString = wr.NewBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(1948L, "public String toString()"));
            wrToString.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1949L, "StringBuilder sb = new StringBuilder();"));
            wrToString.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1950L, "sb.append(\"(\");"));
            for (int j = MutateCSharp.Schemata236.ReplaceNumericConstant_1(1951L, 0); MutateCSharp.Schemata236.ReplaceBinExprOp_5(1955L, j, i); MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(1960L, ref j))
            {
                wrToString.WriteLine($"sb.append(_{j} == null ? \"null\" : _{j}.toString());");
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_25(1974L, j, MutateCSharp.Schemata236.ReplaceBinExprOp_10(1965L, i, MutateCSharp.Schemata236.ReplaceNumericConstant_1(1961L, 1))))
                {
                    wrToString.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1979L, "sb.append(\", \");"));
                }
            }

            wrToString.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1980L, "sb.append(\")\");"));
            wrToString.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1981L, "return sb.toString();"));

            wr.WriteLine();
            wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1982L, "@Override"));
            var wrHashCode = wr.NewBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(1983L, "public int hashCode()"));
            wrHashCode.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1984L, "// GetHashCode method (Uses the djb2 algorithm)"));
            wrHashCode.WriteLine(
      MutateCSharp.Schemata236.ReplaceStringConstant_0(1985L, "// https://stackoverflow.com/questions/1579721/why-are-5381-and-33-so-important-in-the-djb2-algorithm"));
            wrHashCode.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1986L, "long hash = 5381;"));
            wrHashCode.WriteLine(
      MutateCSharp.Schemata236.ReplaceStringConstant_0(1987L, "hash = ((hash << 5) + hash) + 0;")); // this is constructor 0 (in fact, it's the only constructor)
            for (int j = MutateCSharp.Schemata236.ReplaceNumericConstant_1(1988L, 0); MutateCSharp.Schemata236.ReplaceBinExprOp_5(1992L, j, i); MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(1997L, ref j))
            {
                wrHashCode.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(1998L, "hash = ((hash << 5) + hash) + java.util.Objects.hashCode(this._") + j + MutateCSharp.Schemata236.ReplaceStringConstant_0(1999L, ");"));
            }

            wrHashCode.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2000L, "return (int)hash;"));

            for (int j = MutateCSharp.Schemata236.ReplaceNumericConstant_1(2001L, 0); MutateCSharp.Schemata236.ReplaceBinExprOp_5(2005L, j, i); MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(2010L, ref j))
            {
                wr.WriteLine();
                wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2011L, "public T") + j + MutateCSharp.Schemata236.ReplaceStringConstant_0(2012L, " dtor__") + j + MutateCSharp.Schemata236.ReplaceStringConstant_0(2013L, "() { return this._") + j + MutateCSharp.Schemata236.ReplaceStringConstant_0(2014L, "; }"));
            }
        }

        protected override string TypeInitializationValue(Type type, ConcreteSyntaxTree wr, IToken tok, bool usePlaceboValue, bool constructTypeParameterDefaultsFromTypeDescriptors)
        {
            var xType = type.NormalizeExpandKeepConstraints();
            if (xType is BoolType)
            {
                return MutateCSharp.Schemata236.ReplaceStringConstant_0(2015L, "false");
            }
            else if (xType is CharType)
            {
                return UnicodeCharEnabled ? $"((int){CharType.DefaultValueAsString})" : CharType.DefaultValueAsString;
            }
            else if (MutateCSharp.Schemata236.ReplaceBinExprOp_17(2016L, () => xType is IntType, () => xType is BigOrdinalType))
            {
                return MutateCSharp.Schemata236.ReplaceStringConstant_0(2022L, "java.math.BigInteger.ZERO");
            }
            else if (xType is RealType)
            {
                return $"{DafnyBigRationalClass}.ZERO";
            }
            else if (xType is BitvectorType)
            {
                var t = (BitvectorType)xType;
                return MutateCSharp.Schemata236.ReplaceBinExprOp_20(2023L, t.NativeType, null) ? $"{CastIfSmallNativeType(t)}0" : MutateCSharp.Schemata236.ReplaceStringConstant_0(2024L, "java.math.BigInteger.ZERO");
            }
            else if (xType is CollectionType collType)
            {
                string collName = CollectionTypeUnparameterizedName(collType);
                string argNames = BoxedTypeName(collType.Arg, wr, tok);
                if (xType is MapType mapType)
                {
                    argNames += MutateCSharp.Schemata236.ReplaceStringConstant_0(2025L, ",") + BoxedTypeName(mapType.Range, wr, tok);
                }
                string td = "";
                if (xType is SeqType)
                {
                    td = TypeDescriptor(collType.Arg, wr, tok);
                }
                return $"{collName}.<{argNames}> empty({td})";
            }

            var udt = (UserDefinedType)xType;
            var cl = udt.ResolvedClass;
            Contract.Assert(cl != null);
            if (cl is TypeParameter tp)
            {
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(2026L, () => usePlaceboValue, () => !tp.Characteristics.HasCompiledValue))
                {
                    return MutateCSharp.Schemata236.ReplaceStringConstant_0(2032L, "null");
                }
                else if (constructTypeParameterDefaultsFromTypeDescriptors)
                {
                    return $"{FormatTypeDescriptorVariable(tp.GetCompileName(Options))}.defaultValue()";
                }
                else
                {
                    return FormatDefaultTypeParameterValue(tp);
                }
            }
            else if (cl is AbstractTypeDecl opaque)
            {
                return FormatDefaultTypeParameterValueName(opaque.GetCompileName(Options));
            }
            else if (cl is NewtypeDecl)
            {
                var td = (NewtypeDecl)cl;
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_30(2033L, td.Witness, null))
                {
                    return FullTypeName(udt) + MutateCSharp.Schemata236.ReplaceStringConstant_0(2034L, ".Witness");
                }
                else if (MutateCSharp.Schemata236.ReplaceBinExprOp_20(2035L, td.NativeType, null))
                {
                    return GetNativeDefault(td.NativeType);
                }
                else
                {
                    return TypeInitializationValue(td.BaseType, wr, tok, usePlaceboValue, constructTypeParameterDefaultsFromTypeDescriptors);
                }
            }
            else if (cl is SubsetTypeDecl)
            {
                var td = (SubsetTypeDecl)cl;
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_15(2036L, td.WitnessKind, SubsetTypeDecl.WKind.Compiled))
                {
                    var relevantTypeArgs = new List<Type>();
                    for (int i = MutateCSharp.Schemata236.ReplaceNumericConstant_1(2037L, 0); MutateCSharp.Schemata236.ReplaceBinExprOp_5(2041L, i, td.TypeArgs.Count); MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(2046L, ref i))
                    {
                        if (NeedsTypeDescriptor(td.TypeArgs[i]))
                        {
                            relevantTypeArgs.Add(udt.TypeArgs[i]);
                        }
                    }
                    string typeParameters = Util.Comma(relevantTypeArgs, arg => TypeDescriptor(arg, wr, tok));
                    return $"{FullTypeName(udt)}.defaultValue({typeParameters})";
                }
                else if (MutateCSharp.Schemata236.ReplaceBinExprOp_15(2047L, td.WitnessKind, SubsetTypeDecl.WKind.Special))
                {
                    // WKind.Special is only used with -->, ->, and non-null types:
                    Contract.Assert(ArrowType.IsPartialArrowTypeName(td.Name) || ArrowType.IsTotalArrowTypeName(td.Name) || td is NonNullTypeDecl);
                    if (ArrowType.IsPartialArrowTypeName(td.Name))
                    {
                        return $"(({BoxedTypeName(xType, wr, udt.tok)}) null)";
                    }
                    else if (ArrowType.IsTotalArrowTypeName(td.Name))
                    {
                        var rangeDefaultValue = TypeInitializationValue(udt.TypeArgs.Last(), wr, tok, usePlaceboValue, constructTypeParameterDefaultsFromTypeDescriptors);
                        // return the lambda expression ((Ty0 x0, Ty1 x1, Ty2 x2) -> rangeDefaultValue)
                        return $"(({Util.Comma(MutateCSharp.Schemata236.ReplaceBinExprOp_10(2052L, udt.TypeArgs.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(2048L, 1)), i => $"{BoxedTypeName(udt.TypeArgs[i], wr, udt.tok)} {idGenerator.FreshId(MutateCSharp.Schemata236.ReplaceStringConstant_0(2061L, "x"))}")}) -> {rangeDefaultValue})";
                    }
                    else if (((NonNullTypeDecl)td).Class is ArrayClassDecl arrayClass)
                    {
                        // non-null array type; we know how to initialize them
                        var elType = udt.TypeArgs[MutateCSharp.Schemata236.ReplaceNumericConstant_1(2062L, 0)];
                        TypeName_SplitArrayName(elType, out var innermostElementType, out var brackets);
                        string bareArray;
                        brackets += Util.Repeat(MutateCSharp.Schemata236.ReplaceBinExprOp_10(2070L, arrayClass.Dims, MutateCSharp.Schemata236.ReplaceNumericConstant_1(2066L, 1)), MutateCSharp.Schemata236.ReplaceStringConstant_0(2079L, "[]"));
                        if (innermostElementType.IsTypeParameter)
                        {
                            var cast = $"(java.lang.Object{brackets})";
                            bareArray = $"{cast}{FormatTypeDescriptorVariable(innermostElementType.AsTypeParameter)}.newArray({Util.Comma(arrayClass.Dims, _ => MutateCSharp.Schemata236.ReplaceStringConstant_0(2080L, "0"))})";
                        }
                        else
                        {
                            var typeNameSansBrackets = TypeName(innermostElementType, wr, udt.tok, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2081L, false), MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2082L, true));
                            bareArray = $"new {typeNameSansBrackets}[0]{brackets}";
                        }
                        if (MutateCSharp.Schemata236.ReplaceBinExprOp_2(2087L, arrayClass.Dims, MutateCSharp.Schemata236.ReplaceNumericConstant_1(2083L, 1)))
                        {
                            return bareArray;
                        }
                        else
                        {
                            var zeros = Util.Repeat(arrayClass.Dims, MutateCSharp.Schemata236.ReplaceStringConstant_0(2092L, "0, "));
                            return $"new {DafnyMultiArrayClass(arrayClass.Dims)}<>({TypeDescriptor(elType, wr, tok)}, {zeros}{bareArray})";
                        }
                    }
                    else
                    {
                        return MutateCSharp.Schemata236.ReplaceStringConstant_0(2093L, "null");
                    }
                }
                else
                {
                    return TypeInitializationValue(td.RhsWithArgument(udt.TypeArgs), wr, tok, usePlaceboValue, constructTypeParameterDefaultsFromTypeDescriptors);
                }
            }
            else if (cl is ClassLikeDecl or ArrowTypeDecl)
            {
                return $"({BoxedTypeName(xType, wr, udt.tok)}) null";
            }
            else if (cl is DatatypeDecl dt)
            {
                if (DatatypeWrapperEraser.GetInnerTypeOfErasableDatatypeWrapper(Options, dt, out var innerType))
                {
                    var typeSubstMap = TypeParameter.SubstitutionMap(dt.TypeArgs, udt.TypeArgs);
                    return TypeInitializationValue(innerType.Subst(typeSubstMap), wr, tok, usePlaceboValue, constructTypeParameterDefaultsFromTypeDescriptors);
                }
                var s = FullTypeName(udt);
                var typeargs = "";
                var nonGhostTypeArgs = SelectNonGhost(cl, udt.TypeArgs);
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_25(2098L, nonGhostTypeArgs.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(2094L, 0)))
                {
                    typeargs = $"<{BoxedTypeNames(nonGhostTypeArgs, wr, udt.tok)}>";
                }
                // In an auto-init context (like a field initializer), we may not have
                // access to all the type descriptors, so we can't construct the
                // default value, but then null is an acceptable default, since
                // Dafny proves the value won't be accessed.
                if (usePlaceboValue)
                {
                    return $"({s}{typeargs})null";
                }
                var wDefaultTypeArguments = new ConcreteSyntaxTree();
                var sep = "";
                WriteTypeDescriptors(dt, udt.TypeArgs, wDefaultTypeArguments, ref sep);
                var relevantTypeArgs = UsedTypeParameters(dt, udt.TypeArgs);
                var arguments = relevantTypeArgs.Comma(ta => DefaultValueCoercedIfNecessary(ta.Actual, wr, tok, constructTypeParameterDefaultsFromTypeDescriptors));
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_2(2107L, relevantTypeArgs.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(2103L, 0)))
                {
                    sep = "";
                }
                return $"{s}.{typeargs}Default({wDefaultTypeArguments}{sep}{arguments})";
            }
            else
            {
                Contract.Assert(false);
                throw new cce.UnreachableException(); // unexpected type
            }

            return default;
        }

        protected override ConcreteSyntaxTree DeclareLocalVar(string name, Type type, IToken tok, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2112L, "{0} {1} = "), MutateCSharp.Schemata236.ReplaceBinExprOp_38(2113L, type, null) ? TypeName(type, wr, tok, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2114L, false), MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2115L, false), null) : MutateCSharp.Schemata236.ReplaceStringConstant_0(2116L, "var"), name);
            var w = wr.Fork();
            wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2117L, ";"));
            return w;
        }

        protected override void DeclareLocalOutVar(string name, Type type, IToken tok, string rhs, bool useReturnStyleOuts, ConcreteSyntaxTree wr)
        {
            DeclareLocalVar(name, type, tok, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2118L, false), rhs, wr);
        }

        protected override IClassWriter CreateTrait(string name, bool isExtern, List<TypeParameter> typeParameters /*?*/,
          TraitDecl trait, List<Type> superClasses, IToken tok, ConcreteSyntaxTree wr)
        {
            var filename = $"{ModulePath}/{IdProtect(name)}.java";
            var w = wr.NewFile(filename);
            FileCount += MutateCSharp.Schemata236.ReplaceNumericConstant_1(2119L, 1);
            w.WriteLine($"// Interface {name}");
            w.WriteLine($"// Dafny trait {name} compiled into Java");
            w.WriteLine($"package {ModuleName};");
            w.WriteLine();
            EmitImports(w, out _);
            w.WriteLine();
            EmitSuppression(w); //TODO: Fix implementations so they do not need this suppression
            var typeParamString = TypeParameters(typeParameters);
            w.Write($"public interface {IdProtect(name)}{typeParamString}");
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_26(2123L, superClasses, null))
            {
                string sep = MutateCSharp.Schemata236.ReplaceStringConstant_0(2124L, " extends ");
                foreach (var tr in superClasses)
                {
                    if (!tr.IsObject)
                    {
                        w.Write($"{sep}{TypeName(tr, w, tok)}");
                        sep = MutateCSharp.Schemata236.ReplaceStringConstant_0(2125L, ", ");
                    }
                }
            }
            var instanceMemberWriter = w.NewBlock("");
            //writing the _Companion class
            filename = $"{ModulePath}/_Companion_{name}.java";
            w = w.NewFile(filename);
            FileCount += MutateCSharp.Schemata236.ReplaceNumericConstant_1(2126L, 1);
            w.WriteLine($"// Interface {name}");
            w.WriteLine($"// Dafny trait {name} compiled into Java");
            w.WriteLine($"package {ModuleName};");
            w.WriteLine();
            EmitImports(w, out _);
            w.WriteLine();
            EmitSuppression(w); //TODO: Fix implementations so they do not need this suppression
            w.Write($"public class _Companion_{name}{typeParamString}");
            var staticMemberWriter = w.NewBlock("");
            var ctorBodyWriter = staticMemberWriter.NewBlock($"public _Companion_{name}()");

            return new ClassWriter(this, instanceMemberWriter, ctorBodyWriter, staticMemberWriter);
        }

        protected override void EmitDestructor(Action<ConcreteSyntaxTree> source, Formal dtor, int formalNonGhostIndex, DatatypeCtor ctor, List<Type> typeArgs, Type bvType, ConcreteSyntaxTree wr)
        {
            if (DatatypeWrapperEraser.IsErasableDatatypeWrapper(Options, ctor.EnclosingDatatype, out var coreDtor))
            {
                Contract.Assert(coreDtor.CorrespondingFormals.Count == 1);
                Contract.Assert(dtor == coreDtor.CorrespondingFormals[0]); // any other destructor is a ghost
                source(wr);
                return;
            }
            string dtorName;
            if (ctor.EnclosingDatatype is TupleTypeDecl tupleTypeDecl)
            {
                Contract.Assert(tupleTypeDecl.NonGhostDims != 1); // such a tuple is an erasable-wrapper type, handled above
                dtorName = $"dtor__{dtor.NameForCompilation}()";
                wr = EmitCoercionIfNecessary(NativeObjectType, bvType, dtor.tok, wr);
            }
            else
            {
                dtorName = FieldName(dtor, formalNonGhostIndex);
            }
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2130L, "(({0})"), DtCtorName(ctor, typeArgs, wr));
            source(wr);
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2131L, "{0}).{1}"), ctor.EnclosingDatatype is CoDatatypeDecl ? MutateCSharp.Schemata236.ReplaceStringConstant_0(2132L, ".Get()") : "", dtorName);
        }

        private void CreateLambdaFunctionInterface(int i, ConcreteSyntaxTree outputWr)
        {
            Contract.Requires(0 <= i);
            Contract.Requires(outputWr != null);

            var functionName = $"Function{i}";
            var wr = outputWr.NewFile(Path.Combine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2133L, "dafny"), $"{functionName}.java"));

            var typeArgs = MutateCSharp.Schemata236.ReplaceStringConstant_0(2134L, "<") + Util.Comma(MutateCSharp.Schemata236.ReplaceBinExprOp_11(2139L, i, MutateCSharp.Schemata236.ReplaceNumericConstant_1(2135L, 1)), j => $"T{j}") + MutateCSharp.Schemata236.ReplaceStringConstant_0(2148L, ">");

            wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2149L, "package dafny;"));
            wr.WriteLine();
            wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2150L, "@FunctionalInterface"));
            wr.Write($"public interface {functionName}{typeArgs}");
            var wrMembers = wr.NewBlock("");
            wrMembers.Write($"public T{i} apply(");
            wrMembers.Write(Util.Comma(i, j => $"T{j} t{j}"));
            wrMembers.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2151L, ");"));

            EmitSuppression(wrMembers);
            wrMembers.Write($"public static {typeArgs} {DafnyTypeDescriptor}<{functionName}{typeArgs}> {TypeMethodName}(");
            wrMembers.Write(Util.Comma(MutateCSharp.Schemata236.ReplaceBinExprOp_11(2156L, i, MutateCSharp.Schemata236.ReplaceNumericConstant_1(2152L, 1)), j => $"{DafnyTypeDescriptor}<T{j}> t{j}"));
            var wrTypeBody = wrMembers.NewBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(2165L, ")"), "");
            // XXX This seems to allow non-nullable types to have null values (since
            // arrow types are allowed as "(0)"-constrained type arguments), but it's
            // consistent with other backends.
            wrTypeBody.Write($"return ({DafnyTypeDescriptor}<{functionName}{typeArgs}>) ({DafnyTypeDescriptor}<?>) {DafnyTypeDescriptor}.reference({functionName}.class);");
        }

        private void CreateDafnyArrays(int i, ConcreteSyntaxTree outputWr)
        {
            Contract.Requires(0 <= i);
            Contract.Requires(outputWr != null);

            var wrTop = outputWr.NewFile(Path.Combine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2166L, "dafny"), $"Array{i}.java"));

            wrTop.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2167L, "package dafny;"));
            wrTop.WriteLine();

            // All brackets on the underlying "real" array type, minus the innermost
            // pair.  The innermost array must be represented as an Object since it
            // could be of primitive type.
            var outerBrackets = Repeat(MutateCSharp.Schemata236.ReplaceStringConstant_0(2168L, "[]"), MutateCSharp.Schemata236.ReplaceBinExprOp_10(2173L, i, MutateCSharp.Schemata236.ReplaceNumericConstant_1(2169L, 1)));

            var dims = Enumerable.Range(MutateCSharp.Schemata236.ReplaceNumericConstant_1(2182L, 0), i);
            var outerDims = Enumerable.Range(MutateCSharp.Schemata236.ReplaceNumericConstant_1(2186L, 0), MutateCSharp.Schemata236.ReplaceBinExprOp_10(2194L, i, MutateCSharp.Schemata236.ReplaceNumericConstant_1(2190L, 1)));

            var wr = wrTop.NewBlock($"public final class Array{i}<T>");

            wr.WriteLine($"public final Object{outerBrackets} elmts;");
            wr.WriteLine($"private final {DafnyTypeDescriptor}<T> elmtType;");

            foreach (var j in dims)
            {
                wr.WriteLine($"public final int dim{j};");
            }
            {
                var wrBody = wr.NewBlock($"public Array{i}({DafnyTypeDescriptor}<T> elmtType, {Util.Comma(dims, j => $"int dim{j}")}, Object{outerBrackets} elmts)");
                wrBody.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2203L, "assert elmts.getClass().isArray();"));
                wrBody.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2204L, "this.elmtType = elmtType;"));
                foreach (var j in dims)
                {
                    wrBody.WriteLine($"this.dim{j} = dim{j};");
                }
                wrBody.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2205L, "this.elmts = elmts;"));
            }

            {
                var wrBody = wr.NewBlock($"public T get({Util.Comma(dims, j => $"int i{j}")})");
                wrBody.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2206L, "return elmtType.getArrayElement(elmts"));
                foreach (var j in outerDims)
                {
                    wrBody.Write($"[i{j}]");
                }
                wrBody.WriteLine($", i{MutateCSharp.Schemata236.ReplaceBinExprOp_10(2211L, i, MutateCSharp.Schemata236.ReplaceNumericConstant_1(2207L, 1))});");
            }

            {
                var wrBody = wr.NewBlock($"public void set({Util.Comma(dims, j => $"int i{j}")}, T value)");
                wrBody.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2220L, "elmtType.setArrayElement(elmts"));
                foreach (var j in outerDims)
                {
                    wrBody.Write($"[i{j}]");
                }
                wrBody.WriteLine($", i{MutateCSharp.Schemata236.ReplaceBinExprOp_10(2225L, i, MutateCSharp.Schemata236.ReplaceNumericConstant_1(2221L, 1))}, value);");
            }

            {
                var body = wr.NewBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(2234L, "public void fill(T z)"));
                var forBodyWr = body;
                for (int j = MutateCSharp.Schemata236.ReplaceNumericConstant_1(2235L, 0); MutateCSharp.Schemata236.ReplaceBinExprOp_5(2252L, j, MutateCSharp.Schemata236.ReplaceBinExprOp_10(2243L, i, MutateCSharp.Schemata236.ReplaceNumericConstant_1(2239L, 1))); MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(2257L, ref j))
                {
                    forBodyWr = forBodyWr.NewBlock($"for(int i{j} = 0; i{j} < dim{j}; i{j}++)");
                }
                forBodyWr.Write($"elmtType.fillArray(elmts");
                for (int j = MutateCSharp.Schemata236.ReplaceNumericConstant_1(2258L, 0); MutateCSharp.Schemata236.ReplaceBinExprOp_5(2275L, j, MutateCSharp.Schemata236.ReplaceBinExprOp_10(2266L, i, MutateCSharp.Schemata236.ReplaceNumericConstant_1(2262L, 1))); MutateCSharp.Schemata236.ReplacePostfixUnaryExprOp_6(2280L, ref j))
                {
                    forBodyWr.Write($"[i{j}]");
                }
                forBodyWr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2281L, ", z);"));
            }

            {
                var body = wr.NewBlock($"public Array{i} fillThenReturn(T z)");
                body.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2282L, "fill(z);"));
                body.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2283L, "return this;"));
            }

            EmitSuppression(wr);
            wr.WriteLine($"private static final {DafnyTypeDescriptor}<Array{i}<?>> TYPE = ({DafnyTypeDescriptor}<Array{i}<?>>) ({DafnyTypeDescriptor}<?>) {DafnyTypeDescriptor}.reference(Array{i}.class);");
            EmitSuppression(wr);
            var wrTypeMethod = wr.NewBlock($"public static <T> {DafnyTypeDescriptor}<Array{i}<T>> {TypeMethodName}()");
            wrTypeMethod.WriteLine($"return ({DafnyTypeDescriptor}<Array{i}<T>>) ({DafnyTypeDescriptor}<?>) TYPE;");
        }

        protected override ConcreteSyntaxTree EmitTailCallStructure(MemberDecl member, ConcreteSyntaxTree wr)
        {
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(2284L, () => !member.IsStatic, () => !NeedsCustomReceiver(member)))
            {
                var receiverType = UserDefinedType.FromTopLevelDecl(member.tok, member.EnclosingClass);
                var receiverTypeName = TypeName(receiverType, wr, member.tok);
                if (member.EnclosingClass.IsExtern(Options, out _, out _))
                {
                    receiverTypeName = FormatExternBaseClassName(receiverTypeName);
                }
                wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2290L, "{0} _this = this;"), receiverTypeName);
            }
            return wr.NewBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(2291L, "TAIL_CALL_START: while (true)"));
        }

        protected override void EmitJumpToTailCallStart(ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2292L, "continue TAIL_CALL_START;"));
        }

        protected override ConcreteSyntaxTree CreateForeachLoop(
          string tmpVarName, Type collectionElementType, IToken tok, out ConcreteSyntaxTree collectionWriter, ConcreteSyntaxTree wr)
        {

            // We may have to coerce from the boxed type used in collections
            var needsCoercion = IsCoercionNecessary(NativeObjectType, collectionElementType);
            var boxedType = BoxedTypeName(collectionElementType, wr, tok);
            var loopVarName = needsCoercion ? ProtectedFreshId(tmpVarName + MutateCSharp.Schemata236.ReplaceStringConstant_0(2293L, "_boxed")) : tmpVarName;
            wr.Write($"for ({boxedType} {loopVarName} : ");
            collectionWriter = wr.Fork();
            var wwr = wr.NewBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(2294L, ")"));
            if (needsCoercion)
            {
                wwr.Write($"{TypeName(collectionElementType, wr, tok)} {tmpVarName} = ");
                var coercedWwr = EmitCoercionIfNecessary(NativeObjectType, collectionElementType, tok, wwr);
                coercedWwr.Write(loopVarName);
                wwr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2295L, ";"));
            }
            return wwr;
        }

        protected override Action<ConcreteSyntaxTree> GetSubtypeCondition(string tmpVarName, Type boundVarType, IToken tok, ConcreteSyntaxTree wPreconditions)
        {
            string typeTest;

            if (boundVarType.IsRefType)
            {
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_17(2296L, () => boundVarType.IsObject, () => boundVarType.IsObjectQ))
                {
                    typeTest = MutateCSharp.Schemata236.ReplaceStringConstant_0(2302L, "true");
                }
                else
                {
                    typeTest = $"{tmpVarName} instanceof {TypeName(boundVarType, wPreconditions, tok)}";
                }
                if (boundVarType.IsNonNullRefType)
                {
                    typeTest = $"{tmpVarName} != null && {typeTest}";
                }
                else
                {
                    typeTest = $"{tmpVarName} == null || {typeTest}";
                }
            }
            else
            {
                typeTest = MutateCSharp.Schemata236.ReplaceStringConstant_0(2303L, "true");
            }

            return typeTest == null ? null : wr => wr.Write(typeTest);
        }

        protected override void EmitDowncastVariableAssignment(string boundVarName, Type boundVarType, string tmpVarName,
          Type sourceType, bool introduceBoundVar, IToken tok, ConcreteSyntaxTree wr)
        {

            var typeName = TypeName(boundVarType, wr, tok);
            wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2304L, "{0}{1} = ({2}){3};"), introduceBoundVar ? typeName + MutateCSharp.Schemata236.ReplaceStringConstant_0(2305L, " ") : "", boundVarName, typeName, tmpVarName);
        }

        protected override ConcreteSyntaxTree CreateForeachIngredientLoop(string boundVarName, int L, string tupleTypeArgs, out ConcreteSyntaxTree collectionWriter, ConcreteSyntaxTree wr)
        {
            wr.Write($"for ({DafnyTupleClass(L)}<{tupleTypeArgs}> {boundVarName} : ");
            collectionWriter = wr.Fork();
            return wr.NewBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(2306L, ")"));
        }

        protected override void EmitSetBuilder_Add(CollectionType ct, string collName, Expression elmt, bool inLetExprBody, ConcreteSyntaxTree wr)
        {
            if (ct is SetType)
            {
                var wStmts = wr.Fork();
                wr.Write($"{collName}.add(");
                var coercedWr = EmitCoercionIfNecessary(elmt.Type, NativeObjectType, elmt.tok, wr);
                coercedWr.Append(Expr(elmt, inLetExprBody, wStmts));
                wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2307L, ");"));
            }
            else
            {
                Contract.Assume(false);  // unexpected collection type
            }
        }

        protected override void GetCollectionBuilder_Build(CollectionType ct, IToken tok, string collName,
          ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmt)
        {
            if (ct is SetType)
            {
                var typeName = BoxedTypeName(ct.Arg, wr, tok);
                wr.Write($"new {DafnySetClass}<{typeName}>({collName})");
            }
            else if (ct is MapType)
            {
                var mt = (MapType)ct;
                var domtypeName = BoxedTypeName(mt.Domain, wr, tok);
                var rantypeName = BoxedTypeName(mt.Range, wr, tok);
                wr.Write($"new {DafnyMapClass}<{domtypeName},{rantypeName}>({collName})");
            }
            else
            {
                Contract.Assume(false);  // unexpected collection type
                throw new cce.UnreachableException();  // please compiler
            }
        }

        protected override ConcreteSyntaxTree CreateLabeledCode(string label, bool createContinueLabel, ConcreteSyntaxTree wr)
        {
            var prefix = createContinueLabel ? MutateCSharp.Schemata236.ReplaceStringConstant_0(2308L, "continue_") : MutateCSharp.Schemata236.ReplaceStringConstant_0(2309L, "goto_");
            return wr.NewNamedBlock($"{prefix}{label}:");
        }

        protected override void EmitBreak(string label, ConcreteSyntaxTree wr)
        {
            wr.WriteLine(label == null ? MutateCSharp.Schemata236.ReplaceStringConstant_0(2310L, "break;") : $"break goto_{label};");
        }

        protected override void EmitContinue(string label, ConcreteSyntaxTree wr)
        {
            wr.WriteLine($"break continue_{label};");
        }

        protected override void EmitAbsurd(string message, ConcreteSyntaxTree wr)
        {
            if (message == null)
            {
                message = MutateCSharp.Schemata236.ReplaceStringConstant_0(2311L, "unexpected control point");
            }

            wr.WriteLine($"throw new IllegalArgumentException(\"{message}\");");
        }

        protected override void EmitAbsurd(string message, ConcreteSyntaxTree wr, bool needIterLimit)
        {
            if (!needIterLimit)
            {
                EmitAbsurd(message, wr);
            }
        }

        protected override void EmitHalt(IToken tok, Expression messageExpr, ConcreteSyntaxTree wr)
        {
            var wStmts = wr.Fork();
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2312L, "throw new dafny.DafnyHaltException("));
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_46(2313L, tok, null))
            {
                EmitStringLiteral(tok.TokenToString(Options) + MutateCSharp.Schemata236.ReplaceStringConstant_0(2314L, ": "), MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2315L, true), wr);
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2316L, " + "));
            }

            EmitToString(wr, messageExpr, wStmts);
            wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2317L, ");"));
        }

        protected override IClassWriter DeclareNewtype(NewtypeDecl nt, ConcreteSyntaxTree wr)
        {
            var cw = (ClassWriter)CreateClass(IdProtect(nt.EnclosingModuleDefinition.GetCompileName(Options)), IdName(nt), nt, wr);
            var w = cw.StaticMemberWriter;
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_20(2318L, nt.NativeType, null))
            {
                var nativeType = GetBoxedNativeTypeName(nt.NativeType);
                var wEnum = w.NewNamedBlock($"public static java.util.ArrayList<{nativeType}> IntegerRange(java.math.BigInteger lo, java.math.BigInteger hi)");
                wEnum.WriteLine($"java.util.ArrayList<{nativeType}> arr = new java.util.ArrayList<>();");
                var numberval = $"{GetNativeTypeName(nt.NativeType)}Value()";
                wEnum.WriteLine($"for (java.math.BigInteger j = lo; j.compareTo(hi) < 0; j = j.add(java.math.BigInteger.ONE)) {{ arr.add({nativeType}.valueOf(j.{numberval})); }}");
                wEnum.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2319L, "return arr;"));
            }
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_15(2320L, nt.WitnessKind, SubsetTypeDecl.WKind.Compiled))
            {
                var wStmts = w.Fork();
                var witness = new ConcreteSyntaxTree(w.RelativeIndentLevel);
                witness.Append(Expr(nt.Witness, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2321L, false), wStmts));
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_4(2322L, nt.NativeType, null))
                {
                    cw.DeclareField(MutateCSharp.Schemata236.ReplaceStringConstant_0(2323L, "Witness"), nt, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2324L, true), MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2325L, true), nt.BaseType, nt.tok, witness.ToString(), null);
                }
                else
                {
                    var nativeType = GetNativeTypeName(nt.NativeType);
                    // Hacky way of doing the conversion from any (including BigInteger) to any
                    w.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2326L, "public static {0} Witness = ((java.lang.Number) ("), nativeType);
                    w.Append(witness);
                    w.WriteLine($")).{nativeType}Value();");
                }
            }

            GenerateIsMethod(nt, cw.StaticMemberWriter);

            if (MutateCSharp.Schemata236.ReplaceBinExprOp_25(2331L, nt.ParentTraits.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(2327L, 0)))
            {
                DeclareBoxedNewtype(nt, cw.InstanceMemberWriter);
            }

            return cw;
        }

        void GenerateIsMethod(RedirectingTypeDecl declWithConstraints, ConcreteSyntaxTree wr)
        {
            Contract.Requires(declWithConstraints is SubsetTypeDecl or NewtypeDecl);

            if (declWithConstraints.ConstraintIsCompilable)
            {
                var type = UserDefinedType.FromTopLevelDecl(declWithConstraints.tok, (TopLevelDecl)declWithConstraints);

                wr.Write($"public static {TypeParameters(declWithConstraints.TypeArgs, MutateCSharp.Schemata236.ReplaceStringConstant_0(2336L, " "))}boolean {IsMethodName}(");

                var wCtorParams = new ConcreteSyntaxTree();
                var count = EmitTypeDescriptorsForClass(declWithConstraints.TypeArgs, (TopLevelDecl)declWithConstraints,
                  null, wCtorParams, null, null);
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_25(2341L, count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(2337L, 0)))
                {
                    wr.Write($"{wCtorParams}, ");
                }

                var sourceFormal = new Formal(declWithConstraints.tok, MutateCSharp.Schemata236.ReplaceStringConstant_0(2346L, "_source"), type, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2347L, true), MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2348L, false), null);
                var typeName = TypeName(type, wr, declWithConstraints.tok);
                var wrBody = wr.NewBlock($"{typeName} {IdName(sourceFormal)})");
                GenerateIsMethodBody(declWithConstraints, sourceFormal, wrBody);
            }
        }

        void DeclareBoxedNewtype(NewtypeDecl nt, ConcreteSyntaxTree wr)
        {
            // instance field:  public TargetRepresentation _value;
            var targetTypeName = MutateCSharp.Schemata236.ReplaceBinExprOp_4(2349L, nt.NativeType, null) ? TypeName(nt.BaseType, wr, nt.tok) : GetNativeTypeName(nt.NativeType);
            wr.WriteLine($"public {targetTypeName} _value;");

            // constructor:
            // public NewType(TargetRepresentation value) {
            //   _value = value;
            // }
            wr.NewNamedBlock($"public {IdName(nt)}({targetTypeName} value)")
              .WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2350L, "_value = value;"));

            // @Override
            // public java.lang.String toString() {
            //   return java.lang.String.valueOf(_value);
            // }
            wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2351L, "@Override"));
            var wBody = wr.NewNamedBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(2352L, "public java.lang.String toString()"));
            wBody.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2353L, "return "));
            EmitToString(wBody, UserDefinedType.FromTopLevelDecl(nt.tok, nt))
              .Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2354L, "_value"));
            wBody.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2355L, ";"));
        }

        protected override string ArrayIndexToNativeInt(string s, Type type)
        {
            var nt = AsNativeType(type);
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_4(2356L, nt, null))
            {
                return $"({s}).intValue()";
            }
            else if (MutateCSharp.Schemata236.ReplaceBinExprOp_17(2359L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_35(2357L, nt.Sel, NativeType.Selection.Int), () => MutateCSharp.Schemata236.ReplaceBinExprOp_35(2358L, nt.Sel, NativeType.Selection.UInt)))
            {
                return s;
            }
            else if (IsUnsignedJavaNativeType(nt))
            {
                return $"{DafnyHelpersClass}.unsignedToInt({s})";
            }
            else
            {
                return $"{DafnyHelpersClass}.toInt({s})";
            }

            return default;
        }

        // if checkRange is false, msg is ignored
        // if checkRange is true and msg is null and the value is out of range, a generic message is emitted
        // if checkRange is true and msg is not null and the value is out of range, msg is emitted in the error message
        private void TrExprAsInt(Expression expr, ConcreteSyntaxTree wr, bool inLetExprBody, ConcreteSyntaxTree wStmts,
          bool checkRange = false, string msg = null)
        {
            var wrExpr = new ConcreteSyntaxTree();
            wrExpr.Append(Expr(expr, inLetExprBody, wStmts));
            TrExprAsInt(wrExpr.ToString(), expr.Type, wr, checkRange, msg);
        }

        // if checkRange is false, msg is ignored
        // if checkRange is true and msg is null and the value is out of range, a generic message is emitted
        // if checkRange is true and msg is not null and the value is out of range, msg is emitted in the error message
        private void TrExprAsInt(string expr, Type type, ConcreteSyntaxTree wr, bool checkRange = false, string msg = null)
        {
            var nt = AsNativeType(type);
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_4(2365L, nt, null))
            {
                wr.Write($"{DafnyHelpersClass}.toInt" + (checkRange ? MutateCSharp.Schemata236.ReplaceStringConstant_0(2366L, "Checked(") : MutateCSharp.Schemata236.ReplaceStringConstant_0(2367L, "(")));
                wr.Write($"({expr})");
                if (checkRange)
                {
                    wr.Write(msg == null ? MutateCSharp.Schemata236.ReplaceStringConstant_0(2368L, ", null") : $", \"{msg}\"");
                }

                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2369L, ")"));
            }
            else if (MutateCSharp.Schemata236.ReplaceBinExprOp_17(2372L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_35(2370L, nt.Sel, NativeType.Selection.Int), () => MutateCSharp.Schemata236.ReplaceBinExprOp_35(2371L, nt.Sel, NativeType.Selection.UInt)))
            {
                wr.Write(expr);
            }
            else if (IsUnsignedJavaNativeType(nt))
            {
                wr.Write($"{DafnyHelpersClass}.unsignedToInt" + (checkRange ? MutateCSharp.Schemata236.ReplaceStringConstant_0(2378L, "Checked(") : MutateCSharp.Schemata236.ReplaceStringConstant_0(2379L, "(")));
                wr.Write(expr);
                if (checkRange)
                {
                    wr.Write(msg == null ? MutateCSharp.Schemata236.ReplaceStringConstant_0(2380L, ", null") : $", \"{msg}\"");
                }

                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2381L, ")"));
            }
            else
            {
                wr.Write($"{DafnyHelpersClass}.toInt" + (checkRange ? MutateCSharp.Schemata236.ReplaceStringConstant_0(2382L, "Checked(") : MutateCSharp.Schemata236.ReplaceStringConstant_0(2383L, "(")));
                wr.Write(expr);
                if (checkRange)
                {
                    wr.Write(msg == null ? MutateCSharp.Schemata236.ReplaceStringConstant_0(2384L, ", null") : $", \"{msg}\"");
                }

                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2385L, ")"));
            }
        }

        private void TrParenExprAsInt(Expression expr, ConcreteSyntaxTree wr, bool inLetExprBody, ConcreteSyntaxTree wStmts)
        {
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2386L, "("));
            TrExprAsInt(expr, wr, inLetExprBody, wStmts);
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2387L, ")"));
        }

        protected override void EmitNewArray(Type elementType, IToken tok, List<string> dimensions,
            bool mustInitialize, [CanBeNull] string exampleElement, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            // Where to put the array to be wrapped
            ConcreteSyntaxTree wBareArray;
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_8(2392L, dimensions.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(2388L, 1)))
            {
                wr.Write($"new {DafnyMultiArrayClass(dimensions.Count)}<>({TypeDescriptor(elementType, wr, tok)}, ");
                foreach (var dim in dimensions)
                {
                    TrExprAsInt(dim, Type.Int, wr, checkRange: MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2397L, true), msg: MutateCSharp.Schemata236.ReplaceStringConstant_0(2398L, "Java arrays may be no larger than the maximum 32-bit signed int"));
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2399L, ", "));
                }
                wBareArray = wr.Fork();
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2400L, ")"));
                if (mustInitialize)
                {
                    wr.Write($".fillThenReturn({DefaultValueCoercedIfNecessary(elementType, wr, tok, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2401L, true))})");
                }
            }
            else
            {
                wr.Write($"({ArrayTypeName(elementType, dimensions.Count, wr, tok, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2402L, false))}) ");
                if (mustInitialize)
                {
                    wr.Write($"{TypeDescriptor(elementType, wr, tok)}.fillThenReturnArray(");
                }
                wBareArray = wr.Fork();
                if (mustInitialize)
                {
                    wr.Write($", {DefaultValueCoercedIfNecessary(elementType, wr, tok, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2403L, true))})");
                }
            }

            if (MutateCSharp.Schemata236.ReplaceBinExprOp_8(2408L, dimensions.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(2404L, 1)))
            {
                wBareArray.Write($"(Object{Repeat(MutateCSharp.Schemata236.ReplaceStringConstant_0(2413L, "[]"), MutateCSharp.Schemata236.ReplaceBinExprOp_10(2418L, dimensions.Count, MutateCSharp.Schemata236.ReplaceNumericConstant_1(2414L, 1)))}) ");
            }
            wBareArray.Write($"{TypeDescriptor(elementType, wr, tok)}.newArray(");
            var sep = "";
            foreach (var dim in dimensions)
            {
                wBareArray.Write(sep);
                TrExprAsInt(dim, Type.Int, wBareArray, checkRange: MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2427L, true), msg: MutateCSharp.Schemata236.ReplaceStringConstant_0(2428L, "Java arrays may be no larger than the maximum 32-bit signed int"));
                sep = MutateCSharp.Schemata236.ReplaceStringConstant_0(2429L, ", ");
            }
            wBareArray.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2430L, ")"));
        }

        protected override bool TargetLambdaCanUseEnclosingLocals => MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2431L, false);

        protected override ConcreteSyntaxTree EmitBetaRedex(List<string> boundVars, List<Expression> arguments,
          List<Type> boundTypes, Type resultType, IToken resultTok, bool inLetExprBody, ConcreteSyntaxTree wr,
          ref ConcreteSyntaxTree wStmts)
        {
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2432L, "(({0}<{1}{2}>)"), DafnyFunctionIface(boundTypes.Count), Util.Comma("", boundTypes, t => BoxedTypeName(t, wr, resultTok) + MutateCSharp.Schemata236.ReplaceStringConstant_0(2433L, ", ")), BoxedTypeName(resultType, wr, resultTok));
            wr.Write($"({Util.Comma(boundVars)}) -> ");
            var w = wr.Fork();
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2434L, ").apply"));
            TrExprList(arguments, wr, inLetExprBody, wStmts);
            return w;
        }

        protected override ConcreteSyntaxTree CreateForLoop(string indexVar, Action<ConcreteSyntaxTree> boundAction, ConcreteSyntaxTree wr, string start = null)
        {
            start = start ?? MutateCSharp.Schemata236.ReplaceStringConstant_0(2435L, "java.math.BigInteger.ZERO");
            var boundWriter = new ConcreteSyntaxTree();
            boundAction(boundWriter);
            var bound = boundWriter.ToString();
            return wr.NewNamedBlock($"for (java.math.BigInteger {indexVar} = {start}; {indexVar}.compareTo({bound}) < 0; {indexVar} = {indexVar}.add(java.math.BigInteger.ONE))");
        }

        protected override ConcreteSyntaxTree EmitForStmt(IToken tok, IVariable loopIndex, bool goingUp, string /*?*/ endVarName,
          List<Statement> body, LList<Label> labels, ConcreteSyntaxTree wr)
        {

            var nativeType = AsNativeType(loopIndex.Type);

            wr.Write($"for ({TypeName(loopIndex.Type, wr, tok)} {loopIndex.CompileName} = ");
            var startWr = wr.Fork();
            wr.Write($"; ");

            ConcreteSyntaxTree bodyWr;
            if (goingUp)
            {
                if (endVarName == null)
                {
                    wr.Write("");
                }
                else if (MutateCSharp.Schemata236.ReplaceBinExprOp_4(2436L, nativeType, null))
                {
                    wr.Write($"{loopIndex.CompileName}.compareTo({endVarName}) < 0");
                }
                else if (MutateCSharp.Schemata236.ReplaceBinExprOp_47(2441L, MutateCSharp.Schemata236.ReplaceNumericConstant_1(2437L, 0), nativeType.LowerBound))
                {
                    wr.Write($"{HelperClass(nativeType)}.compareUnsigned({loopIndex.CompileName}, {endVarName}) < 0");
                }
                else
                {
                    wr.Write($"{loopIndex.CompileName} < {endVarName}");
                }
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_4(2443L, nativeType, null))
                {
                    bodyWr = wr.NewBlock($"; {loopIndex.CompileName} = {loopIndex.CompileName}.add(java.math.BigInteger.ONE))");
                }
                else
                {
                    bodyWr = wr.NewBlock($"; {loopIndex.CompileName}++)");
                }
            }
            else
            {
                if (endVarName == null)
                {
                    wr.Write("");
                }
                else if (MutateCSharp.Schemata236.ReplaceBinExprOp_4(2444L, nativeType, null))
                {
                    wr.Write($"{endVarName}.compareTo({loopIndex.CompileName}) < 0");
                }
                else if (MutateCSharp.Schemata236.ReplaceBinExprOp_47(2449L, MutateCSharp.Schemata236.ReplaceNumericConstant_1(2445L, 0), nativeType.LowerBound))
                {
                    wr.Write($"{HelperClass(nativeType)}.compareUnsigned({endVarName}, {loopIndex.CompileName}) < 0");
                }
                else
                {
                    wr.Write($"{endVarName} < {loopIndex.CompileName}");
                }
                bodyWr = wr.NewBlock($"; )");
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_4(2451L, nativeType, null))
                {
                    bodyWr.WriteLine($"{loopIndex.CompileName} = {loopIndex.CompileName}.subtract(java.math.BigInteger.ONE);");
                }
                else
                {
                    bodyWr.WriteLine($"{loopIndex.CompileName}--;");
                }
            }
            bodyWr = EmitContinueLabel(labels, bodyWr);
            TrStmtList(body, bodyWr);

            return startWr;
        }

        protected override string GetHelperModuleName() => DafnyHelpersClass;

        protected override void EmitEmptyTupleList(string tupleTypeArgs, ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2452L, "new java.util.ArrayList<>();"));
        }

        protected override ConcreteSyntaxTree EmitAddTupleToList(string ingredients, string tupleTypeArgs, ConcreteSyntaxTree wr)
        {
            // FIXME: tupleTypeArgs is wrong because it already got generated from
            // TypeName (with unboxed being the default)  :-(
            wr.Write($"{ingredients}.add(new {DafnyTupleClassPrefix}");
            var wrTuple = wr.Fork();
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2453L, "));"));
            return wrTuple;
        }

        protected override void EmitExprAsNativeInt(Expression expr, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            TrParenExpr(expr, wr, inLetExprBody, wStmts);
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2454L, ".intValue()"));
        }

        protected override void EmitTupleSelect(string prefix, int i, ConcreteSyntaxTree wr)
        {
            wr.Write($"{prefix}.dtor__{i}()");
        }

        protected override void EmitApplyExpr(Type functionType, IToken tok, Expression function, List<Expression> arguments, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr = EmitCoercionIfNecessary(NativeObjectType, functionType.AsArrowType.Result, tok, wr);
            TrParenExpr(function, wr, inLetExprBody, wStmts);
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2455L, ".apply"));
            TrExprList(arguments, wr, inLetExprBody, wStmts, typeAt: _ => NativeObjectType);
        }

        protected override bool NeedsCastFromTypeParameter => MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2456L, true);

        protected override bool TargetSubtypingRequiresEqualTypeArguments(Type type)
        {
            return MutateCSharp.Schemata236.ReplaceBinExprOp_48(2457L, type.NormalizeToAncestorType().AsCollectionType, null);
        }

        protected override bool IsCoercionNecessary(Type/*?*/ from, Type/*?*/ to)
        {
            from = MutateCSharp.Schemata236.ReplaceBinExprOp_9(2458L, from, null) ? null : DatatypeWrapperEraser.SimplifyTypeAndTrimNewtypes(Options, from);
            to = MutateCSharp.Schemata236.ReplaceBinExprOp_9(2459L, to, null) ? null : DatatypeWrapperEraser.SimplifyTypeAndTrimNewtypes(Options, to);

            if (MutateCSharp.Schemata236.ReplaceBinExprOp_49(2460L, to, NativeObjectType))
            {
                return MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2461L, false);
            }
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_49(2462L, from, NativeObjectType))
            {
                return MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2463L, true);
            }

            if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(2482L, () => UnicodeCharEnabled, () => (MutateCSharp.Schemata236.ReplaceBinExprOp_17(2476L, () => (MutateCSharp.Schemata236.ReplaceBinExprOp_7(2464L, () => IsNativeObjectType(from), () => to.IsCharType)), () => (MutateCSharp.Schemata236.ReplaceBinExprOp_7(2470L, () => from.IsCharType, () => IsNativeObjectType(to)))))))
            {
                // Need to box from int to CodePoint, or unbox from CodePoint to int
                return MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2488L, true);
            }

            if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(2489L, () => from.IsArrayType, () => to.IsArrayType))
            {
                var dims = from.AsArrayType.Dims;
                Contract.Assert(dims == to.AsArrayType.Dims);
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_8(2499L, dims, MutateCSharp.Schemata236.ReplaceNumericConstant_1(2495L, 1)))
                {
                    return MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2504L, false);
                }

                var udtFrom = (UserDefinedType)from.NormalizeExpand();
                var udtTo = (UserDefinedType)to.NormalizeExpand();
                return MutateCSharp.Schemata236.ReplaceBinExprOp_7(2513L, () => udtFrom.TypeArgs[MutateCSharp.Schemata236.ReplaceNumericConstant_1(2505L, 0)].IsTypeParameter, () => !udtTo.TypeArgs[MutateCSharp.Schemata236.ReplaceNumericConstant_1(2509L, 0)].IsTypeParameter);
            }

            return MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2519L, false);
        }

        protected override Type TypeForCoercion(Type type)
        {
            return NativeObjectType;
        }

        // We use null to represent java.lang.Object, as that's a decent
        // default native type for "no type information".
        // We don't use the SpecialNativeType approach that the Go compiler
        // uses for string because that kind of compiler-specific Type implementation
        // doesn't fit well into the generic logic on Types
        // (see for example https://github.com/dafny-lang/dafny/issues/2989).
        private static readonly Type NativeObjectType = null;

        private bool IsNativeObjectType(Type type)
        {
            return MutateCSharp.Schemata236.ReplaceBinExprOp_17(2521L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_49(2520L, type, NativeObjectType), () => type.IsTypeParameter);
        }

        protected override ConcreteSyntaxTree FromFatPointer(Type type, ConcreteSyntaxTree wr)
        {
            if (type.HasFatPointer)
            {
                var w = wr.ForkInParens();
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2527L, "._value"));
                return w;
            }
            else
            {
                return wr;
            }

            return default;
        }

        protected override ConcreteSyntaxTree ToFatPointer(Type type, ConcreteSyntaxTree wr)
        {
            if (type.HasFatPointer)
            {
                wr.Write($"new {type.AsNewtype.GetFullCompileName(Options)}");
                return wr.ForkInParens();
            }
            else
            {
                return wr;
            }

            return default;
        }

        protected override ConcreteSyntaxTree EmitCoercionIfNecessary(Type/*?*/ from, Type/*?*/ to, IToken tok, ConcreteSyntaxTree wr, Type toOrig = null)
        {
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_38(2528L, toOrig, null))
            {
                to = toOrig;
            }

            if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(2544L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_7(2537L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_7(2531L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_38(2529L, from, null), () => MutateCSharp.Schemata236.ReplaceBinExprOp_38(2530L, to, null)), () => from.IsTraitType), () => MutateCSharp.Schemata236.ReplaceBinExprOp_22(2543L, to.AsNewtype, null)))
            {
                return FromFatPointer(to, wr);
            }
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(2579L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_7(2565L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_7(2559L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_7(2552L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_38(2550L, from, null), () => MutateCSharp.Schemata236.ReplaceBinExprOp_38(2551L, to, null)), () => MutateCSharp.Schemata236.ReplaceBinExprOp_22(2558L, from.AsNewtype, null)), () => to.IsTraitType), () => (MutateCSharp.Schemata236.ReplaceBinExprOp_17(2573L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_12(2571L, enclosingMethod, null), () => MutateCSharp.Schemata236.ReplaceBinExprOp_37(2572L, enclosingFunction, null)))))
            {
                return ToFatPointer(from, wr);
            }

            from = MutateCSharp.Schemata236.ReplaceBinExprOp_9(2585L, from, null) ? null : DatatypeWrapperEraser.SimplifyTypeAndTrimNewtypes(Options, from);
            to = MutateCSharp.Schemata236.ReplaceBinExprOp_9(2586L, to, null) ? null : DatatypeWrapperEraser.SimplifyTypeAndTrimNewtypes(Options, to);

            if (UnicodeCharEnabled)
            {
                // Need to box from int to CodePoint, or unbox from CodePoint to int

                if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(2587L, () => IsNativeObjectType(from), () => to is { IsCharType: true }))
                {
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2593L, "((dafny.CodePoint)("));
                    var w = wr.Fork();
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2594L, ")).value()"));
                    return w;
                }

                if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(2595L, () => from is { IsCharType: true }, () => IsNativeObjectType(to)))
                {
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2601L, "dafny.CodePoint.valueOf("));
                    var w = wr.Fork();
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2602L, ")"));
                    return w;
                }
            }

            if (IsCoercionNecessary(from, to))
            {
                return EmitDowncast(from, to, tok, wr);
            }

            return wr;
        }

        protected override ConcreteSyntaxTree EmitDowncast(Type from, Type to, IToken tok, ConcreteSyntaxTree wr)
        {
            var w = new ConcreteSyntaxTree();
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(2618L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_7(2611L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_7(2605L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_38(2603L, from, null), () => MutateCSharp.Schemata236.ReplaceBinExprOp_38(2604L, to, null)), () => from.IsTraitType), () => MutateCSharp.Schemata236.ReplaceBinExprOp_22(2617L, to.AsNewtype, null)))
            {
                wr.Format($"(({to.AsNewtype.GetFullCompileName(Options)})({w}))");
            }
            else if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(2639L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_7(2633L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_7(2626L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_38(2624L, from, null), () => MutateCSharp.Schemata236.ReplaceBinExprOp_38(2625L, to, null)), () => MutateCSharp.Schemata236.ReplaceBinExprOp_22(2632L, from.AsNewtype, null)), () => to.IsTraitType))
            {
                wr.Format($"(({TypeName(to, wr, tok)})({w}))");
            }
            else
            {
                wr.Write($"(({TypeName(to, wr, tok)})(java.lang.Object)(");
                w = wr.Fork();
                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2645L, "))"));
            }
            return w;
        }

        protected override ConcreteSyntaxTree EmitCoercionToNativeInt(ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2646L, "((java.math.BigInteger)"));
            var w = wr.Fork();
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2647L, ").intValue()"));
            return w;
        }

        protected override ConcreteSyntaxTree CreateDoublingForLoop(string indexVar, int start, ConcreteSyntaxTree wr)
        {
            return wr.NewNamedBlock($"for (java.math.BigInteger {indexVar} = java.math.BigInteger.valueOf({start}); ; {indexVar} = {indexVar}.multiply(new java.math.BigInteger(\"2\")))");
        }

        protected override void EmitIsZero(string varName, ConcreteSyntaxTree wr)
        {
            wr.Write($"{varName}.equals(java.math.BigInteger.ZERO)");
        }

        protected override void EmitDecrementVar(string varName, ConcreteSyntaxTree wr)
        {
            wr.WriteLine($"{varName} = {varName}.subtract(java.math.BigInteger.ONE);");
        }

        protected override void EmitIncrementVar(string varName, ConcreteSyntaxTree wr)
        {
            wr.WriteLine($"{varName} = {varName}.add(java.math.BigInteger.ONE);");
        }

        protected override void EmitSingleValueGenerator(Expression e, bool inLetExprBody, string type, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2648L, "java.util.Arrays.asList"));
            TrParenExpr(e, wr, inLetExprBody, wStmts);
        }

        protected override ConcreteSyntaxTree CreateIIFE1(int source, Type resultType, IToken resultTok, string bvName,
            ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write($"((java.util.function.Function<java.math.BigInteger, {BoxedTypeName(resultType, wr, resultTok)}>)(({bvName}) ->");
            var w = wr.NewBigExprBlock("", $")).apply(java.math.BigInteger.valueOf({source}))");
            return w;
        }

        protected override ConcreteSyntaxTree EmitMapBuilder_Add(MapType mt, IToken tok, string collName, Expression term, bool inLetExprBody, ConcreteSyntaxTree wr)
        {
            var wStmts = wr.Fork();
            wr.Write($"{collName}.put(");
            var termLeftWriter = wr.Fork();
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2649L, ","));
            wr.Append(Expr(term, inLetExprBody, wStmts));
            wr.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2650L, ");"));
            return termLeftWriter;
        }

        protected override void EmitSeqConstructionExpr(SeqConstructionExpr expr, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write($"{DafnySeqClass}.Create({TypeDescriptor(expr.Type.NormalizeToAncestorType().AsCollectionType.Arg, wr, expr.tok)}, ");
            var size = expr.N;
            if (AsJavaNativeType(size.Type) is { })
            {
                size = new ConversionExpr(expr.N.tok, size, new IntType());
            }
            var sizeWr = Expr(size, inLetExprBody, wStmts);
            wr.Append(sizeWr);
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2651L, ", "));
            wr.Append(Expr(expr.Initializer, inLetExprBody, wStmts));
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2652L, ")"));
        }

        // Warning: NOT the same as NativeType.Bitwidth, which is zero except for
        // bitvector types
        private static int NativeTypeSize(NativeType nt)
        {
            switch (AsJavaNativeType(nt))
            {
                case JavaNativeType.Byte:
                    return 8;
                    break;
                case JavaNativeType.Short:
                    return 16;
                    break;
                case JavaNativeType.Int:
                    return 32;
                    break;
                case JavaNativeType.Long:
                    return 64;
                    break;
                default:
                    Contract.Assert(false); throw new cce.UnreachableException();
                    break;
            }

            return default;
        }

        protected override void EmitConversionExpr(Expression fromExpr, Type fromType, Type toType, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_17(2659L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_17(2653L, () => fromType.IsNumericBased(Type.NumericPersuasion.Int), () => fromType.NormalizeToAncestorType().IsBitVectorType), () => fromType.IsCharType))
            {
                if (toType.IsNumericBased(Type.NumericPersuasion.Real))
                {
                    // (int or bv or char) -> real
                    Contract.Assert(AsNativeType(toType) == null);
                    var fromNative = AsNativeType(fromType);
                    wr.Write($"new {DafnyBigRationalClass}(");
                    if (MutateCSharp.Schemata236.ReplaceBinExprOp_20(2665L, fromNative, null))
                    {
                        wr.Write(MutateCSharp.Schemata236.ReplaceBinExprOp_44(2670L, fromNative.LowerBound, MutateCSharp.Schemata236.ReplaceNumericConstant_1(2666L, 0
            )) ? $"{DafnyHelpersClass}.unsignedToBigInteger"
                          : MutateCSharp.Schemata236.ReplaceStringConstant_0(2672L, "java.math.BigInteger.valueOf"));
                        TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                        wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2673L, ", java.math.BigInteger.ONE)"));
                    }
                    else if (fromType.IsCharType)
                    {
                        wr.Append(Expr(fromExpr, inLetExprBody, wStmts));
                        wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2674L, ", 1)"));
                    }
                    else
                    {
                        wr.Append(Expr(fromExpr, inLetExprBody, wStmts));
                        wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2675L, ", java.math.BigInteger.ONE)"));
                    }
                }
                else if (toType.IsCharType)
                {
                    // (int or bv or char) -> char
                    // Painfully, Java sign-extends bytes when casting to chars ...
                    if (fromType.IsCharType)
                    {
                        EmitExpr(fromExpr, inLetExprBody, wr, wStmts);
                    }
                    else
                    {
                        var fromNative = AsNativeType(fromType);
                        wr.Write($"({CharTypeName(MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2676L, false))})");
                        if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(2679L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_20(2677L, fromNative, null), () => MutateCSharp.Schemata236.ReplaceBinExprOp_35(2678L, fromNative.Sel, NativeType.Selection.Byte)))
                        {
                            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2685L, "java.lang.Byte.toUnsignedInt"));
                            TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                        }
                        else
                        {
                            TrExprAsInt(fromExpr, wr, inLetExprBody, wStmts);
                        }
                    }
                }
                else
                {
                    // (int or bv or char) -> (int or bv or ORDINAL)
                    var fromNative = AsNativeType(fromType);
                    var toNative = AsNativeType(toType);
                    if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(2688L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_4(2686L, fromNative, null), () => MutateCSharp.Schemata236.ReplaceBinExprOp_4(2687L, toNative, null)))
                    {
                        if (fromType.IsCharType)
                        {
                            // char -> big-integer (int or bv or ORDINAL)
                            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2694L, "java.math.BigInteger.valueOf"));
                            TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                        }
                        else
                        {
                            // big-integer (int or bv) -> big-integer (int or bv or ORDINAL), so identity will do
                            wr.Append(Expr(fromExpr, inLetExprBody, wStmts));
                        }
                    }
                    else if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(2697L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_20(2695L, fromNative, null), () => MutateCSharp.Schemata236.ReplaceBinExprOp_4(2696L, toNative, null)))
                    {
                        // native (int or bv) -> big-integer (int or bv)
                        wr.Write(MutateCSharp.Schemata236.ReplaceBinExprOp_44(2707L, fromNative.LowerBound, MutateCSharp.Schemata236.ReplaceNumericConstant_1(2703L, 0
            )) ? $"{DafnyHelpersClass}.unsignedToBigInteger"
                          : MutateCSharp.Schemata236.ReplaceStringConstant_0(2709L, "java.math.BigInteger.valueOf"));
                        TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                    }
                    else if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(2716L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_20(2710L, fromNative, null), () => MutateCSharp.Schemata236.ReplaceBinExprOp_2(2711L, NativeTypeSize(toNative), NativeTypeSize(fromNative))))
                    {
                        // native (int or bv) -> native (int or bv)
                        // Cast between signed and unsigned, which have the same Java type
                        TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                    }
                    else
                    {
                        GetNativeInfo(toNative.Sel, out var toNativeName, out var toNativeSuffix, out var toNativeNeedsCast);
                        // any (int or bv) -> native (int or bv)
                        // A cast would do, but we also consider some optimizations
                        var literal = PartiallyEvaluate(fromExpr);
                        UnaryOpExpr u = fromExpr.Resolved as UnaryOpExpr;
                        MemberSelectExpr m = fromExpr.Resolved as MemberSelectExpr;
                        if (literal != null)
                        {
                            // Optimize constant to avoid intermediate BigInteger
                            EmitNativeIntegerLiteral((BigInteger)literal, toNative, wr);
                        }
                        else if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(2724L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_50(2722L, u, null), () => MutateCSharp.Schemata236.ReplaceBinExprOp_51(2723L, u.Op, UnaryOpExpr.Opcode.Cardinality)))
                        {
                            // Optimize || to avoid intermediate BigInteger
                            wr.Write(CastIfSmallNativeType(toType));
                            TrParenExpr("", u.E, wr, inLetExprBody, wStmts);
                            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2730L, ".cardinalityInt()"));
                        }
                        else if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(2740L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_7(2734L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_52(2731L, m, null), () => MutateCSharp.Schemata236.ReplaceBinExprOp_13(2733L, m.MemberName, MutateCSharp.Schemata236.ReplaceStringConstant_0(2732L, "Length"))), () => m.Obj.Type.IsArrayType))
                        {
                            // Optimize .length to avoid intermediate BigInteger
                            wr.Write(CastIfSmallNativeType(toType));
                            var elmtType = UserDefinedType.ArrayElementType(m.Obj.Type);
                            ConcreteSyntaxTree w;
                            if (elmtType.IsTypeParameter)
                            {
                                wr.Write($"{FormatTypeDescriptorVariable(elmtType.AsTypeParameter)}.getArrayLength(");
                                w = wr.Fork();
                                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2746L, ")"));
                            }
                            else
                            {
                                w = wr.Fork();
                                wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2747L, ".length"));
                            }
                            TrParenExpr(m.Obj, w, inLetExprBody, wStmts);
                        }
                        else
                        {
                            // no optimization applies; use the standard translation
                            if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(2766L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_7(2755L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_20(2748L, fromNative, null), () => MutateCSharp.Schemata236.ReplaceBinExprOp_44(2753L, fromNative.LowerBound, MutateCSharp.Schemata236.ReplaceNumericConstant_1(2749L, 0))), () => MutateCSharp.Schemata236.ReplaceBinExprOp_5(2761L, NativeTypeSize(fromNative), NativeTypeSize(toNative))))
                            {
                                // Widening an unsigned value; careful!!
                                wr.Write($"{CastIfSmallNativeType(toType)}{GetBoxedNativeTypeName(fromNative)}");
                                if (MutateCSharp.Schemata236.ReplaceBinExprOp_2(2776L, NativeTypeSize(toNative), MutateCSharp.Schemata236.ReplaceNumericConstant_1(2772L, 64)))
                                {
                                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2781L, ".toUnsignedLong"));
                                }
                                else
                                {
                                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2782L, ".toUnsignedInt"));
                                }
                                TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                            }
                            else
                            {
                                if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(2784L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_4(2783L, fromNative, null), () => !fromType.IsCharType))
                                {
                                    TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                                    wr.Write($".{toNativeName}Value()");
                                }
                                else
                                {
                                    wr.Write($"(({toNativeName}) ");
                                    TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2790L, ")"));
                                }
                            }
                        }
                    }
                }
            }
            else if (fromType.IsNumericBased(Type.NumericPersuasion.Real))
            {
                Contract.Assert(AsNativeType(fromType) == null);
                if (toType.IsNumericBased(Type.NumericPersuasion.Real))
                {
                    // real -> real
                    Contract.Assert(AsNativeType(toType) == null);
                    wr.Append(Expr(fromExpr, inLetExprBody, wStmts));
                }
                else if (toType.IsCharType)
                {
                    // real -> char
                    // Painfully, Java sign-extends bytes when casting to chars ...
                    wr.Write($"({CharTypeName(MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2791L, false))})");
                    TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2792L, ".ToBigInteger().intValue()"));
                }
                else if (toType.IsBigOrdinalType)
                {
                    TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2793L, ".ToBigInteger()"));
                }
                else
                {
                    // real -> (int or bv)
                    TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2794L, ".ToBigInteger()"));
                    if (MutateCSharp.Schemata236.ReplaceBinExprOp_20(2795L, AsNativeType(toType), null))
                    {
                        wr.Write($".{GetNativeTypeName(AsNativeType(toType))}Value()");
                    }
                }
            }
            else if (fromType.IsBigOrdinalType)
            {
                if (MutateCSharp.Schemata236.ReplaceBinExprOp_17(2796L, () => toType.IsNumericBased(Type.NumericPersuasion.Int), () => toType.IsCharType))
                {
                    // ordinal -> int, char
                    if (MutateCSharp.Schemata236.ReplaceBinExprOp_20(2802L, AsNativeType(toType), null))
                    {
                        TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                        wr.Write($".{GetNativeTypeName(AsNativeType(toType))}Value()");
                    }
                    else if (toType.IsCharType)
                    {
                        wr.Write($"({CharTypeName(MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2803L, false))})");
                        TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                        wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2804L, ".intValue()"));
                    }
                    else
                    {
                        TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                    }
                }
                else if (toType.IsNumericBased(Type.NumericPersuasion.Real))
                {
                    // ordinal -> real
                    wr.Write($"new {DafnyBigRationalClass}(");
                    wr.Append(Expr(fromExpr, inLetExprBody, wStmts));
                    wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2805L, ", java.math.BigInteger.ONE)"));
                }
                else if (toType.NormalizeToAncestorType().IsBitVectorType)
                {
                    // ordinal -> bv
                    if (MutateCSharp.Schemata236.ReplaceBinExprOp_20(2806L, AsNativeType(toType), null))
                    {
                        TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                        wr.Write($".{GetNativeTypeName(AsNativeType(toType))}Value()");
                    }
                    else
                    {
                        TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                    }
                }
                else if (toType.IsBigOrdinalType)
                {
                    TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                }
                else
                {
                    Contract.Assert(false, $"not implemented for java: {fromType} -> {toType}");
                }
            }
            else if (MutateCSharp.Schemata236.ReplaceBinExprOp_17(2815L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_17(2808L, () => fromType.Equals(toType), () => MutateCSharp.Schemata236.ReplaceBinExprOp_22(2807L, fromType.AsNewtype, null)), () => MutateCSharp.Schemata236.ReplaceBinExprOp_22(2814L, toType.AsNewtype, null)))
            {
                wr.Append(Expr(fromExpr, inLetExprBody, wStmts));
            }
            else
            {
                Contract.Assert(false, $"not implemented for java: {fromType} -> {toType}");
            }
        }

        protected override void EmitTypeTest(string localName, Type fromType, Type toType, IToken tok, ConcreteSyntaxTree wr)
        {
            // from T to U:   t instanceof U && ...
            // from T to U?:  t instanceof U && ...                 // since t is known to be non-null, this is fine
            // from T? to U:  t instanceof U && ...                 // note, "instanceof" implies non-null, so no need for explicit null check
            // from T? to U?: t == null || (t instanceof U && ...)
            if (MutateCSharp.Schemata236.ReplaceBinExprOp_7(2833L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_7(2827L, () => MutateCSharp.Schemata236.ReplaceBinExprOp_7(2821L, () => fromType.IsRefType, () => !fromType.IsNonNullRefType), () => toType.IsRefType), () => !toType.IsNonNullRefType))
            {
                wr = wr.Write($"{localName} == null || ").ForkInParens();
            }

            var typeName = toType.IsObject ? MutateCSharp.Schemata236.ReplaceStringConstant_0(2839L, "Object") : FullTypeName((UserDefinedType)toType.NormalizeExpand());
            wr.Write($"{localName} instanceof {typeName}");
        }

        protected override void EmitIsIntegerTest(Expression source, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            EmitExpr(source, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2840L, false), wr.ForkInParens(), wStmts);
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2841L, ".isInteger() && "));
        }

        protected override void EmitIsUnicodeScalarValueTest(Expression source, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2842L, "dafny.CodePoint.isCodePoint"));
            EmitExpr(source, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2843L, false), wr.ForkInParens(), wStmts);
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2844L, " && "));
        }

        protected override void EmitIsInIntegerRange(Expression source, BigInteger lo, BigInteger hi, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            EmitExpr(source, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2845L, false), wr.ForkInParens(), wStmts);
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2846L, ".compareTo("));
            EmitLiteralExpr(wr, new LiteralExpr(source.tok, lo) { Type = Type.Int });
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2847L, ") >= 0 && "));

            EmitExpr(source, MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2848L, false), wr.ForkInParens(), wStmts);
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2849L, ".compareTo("));
            EmitLiteralExpr(wr, new LiteralExpr(source.tok, hi) { Type = Type.Int });
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2850L, ") < 0 && "));
        }

        protected override bool IssueCreateStaticMain(Method m)
        {
            return MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2851L, true);
        }
        protected override ConcreteSyntaxTree CreateStaticMain(IClassWriter cw, string argsParameterName)
        {
            var wr = ((ClassWriter)cw).StaticMemberWriter;
            return wr.NewBlock($"public static void __Main(dafny.DafnySequence<? extends dafny.DafnySequence<? extends {CharTypeName(MutateCSharp.Schemata236.ReplaceBooleanConstant_3(2852L, true))}>> {argsParameterName})");
        }

        protected override void CreateIIFE(string bvName, Type bvType, IToken bvTok, Type bodyType, IToken bodyTok,
          ConcreteSyntaxTree wr, ref ConcreteSyntaxTree wStmts, out ConcreteSyntaxTree wrRhs, out ConcreteSyntaxTree wrBody)
        {
            wr = EmitCoercionIfNecessary(NativeObjectType, bodyType, bvTok, wr);
            var boxedBvType = BoxedTypeName(bvType, wr, bvTok);
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2853L, "{0}.<{1}, {2}>Let("), DafnyHelpersClass, boxedBvType, BoxedTypeName(bodyType, wr, bodyTok));
            wrRhs = wr.Fork();
            wrRhs = EmitCoercionIfNecessary(bvType, NativeObjectType, bvTok, wrRhs);

            var boxedBvName = idGenerator.FreshId(MutateCSharp.Schemata236.ReplaceStringConstant_0(2854L, "boxed"));
            wr.Write($", {boxedBvName} ->");
            var wrBodyWithCoercion = wr.NewBlock();
            wrBodyWithCoercion.Write($"{TypeName(bvType, wr, bvTok)} {bvName} = ");
            var wrUnboxed = EmitCoercionIfNecessary(NativeObjectType, bvType, bvTok, wrBodyWithCoercion.Fork());
            wrUnboxed.Write(boxedBvName);
            wrBodyWithCoercion.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2855L, ";"));

            wrBodyWithCoercion.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2856L, "return "));
            wrBody = wrBodyWithCoercion.Fork();
            wrBody = EmitCoercionIfNecessary(bodyType, NativeObjectType, bodyTok, wrBody);
            wrBodyWithCoercion.WriteLine(MutateCSharp.Schemata236.ReplaceStringConstant_0(2857L, ";"));
            wr.Write(MutateCSharp.Schemata236.ReplaceStringConstant_0(2858L, ")"));
        }

        protected override string GetQuantifierName(string bvType)
        {
            return $"{DafnyHelpersClass}.Quantifier";
        }

        // ABSTRACT METHOD DECLARATIONS FOR THE SAKE OF BUILDING PROGRAM

        protected override void EmitYield(ConcreteSyntaxTree wr)
        {
            throw new UnsupportedFeatureException(Token.NoToken, Feature.Iterators);
        }

        protected override ConcreteSyntaxTree CreateIterator(IteratorDecl iter, ConcreteSyntaxTree wr)
        {
            throw new UnsupportedFeatureException(iter.tok, Feature.Iterators);
            return default;
        }

        protected override void EmitHaltRecoveryStmt(Statement body, string haltMessageVarName, Statement recoveryBody, ConcreteSyntaxTree wr)
        {
            var tryBlock = wr.NewBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(2859L, "try"));
            TrStmt(body, tryBlock);
            var catchBlock = wr.NewBlock(MutateCSharp.Schemata236.ReplaceStringConstant_0(2860L, "catch (dafny.DafnyHaltException e)"));
            catchBlock.WriteLine($"dafny.DafnySequence<Character> {haltMessageVarName} = dafny.DafnySequence.asString(e.getMessage());");
            TrStmt(recoveryBody, catchBlock);
        }
    }
}
