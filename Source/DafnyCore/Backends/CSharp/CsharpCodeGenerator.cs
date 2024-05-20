//-----------------------------------------------------------------------------
//
// Copyright (C) Microsoft Corporation.  All Rights Reserved.
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
using Microsoft.CodeAnalysis.CSharp;
using System.Text.RegularExpressions;
using JetBrains.Annotations;
using Microsoft.BaseTypes;
using Microsoft.Boogie;
using static Microsoft.Dafny.ConcreteSyntaxTreeUtils;
namespace MutateCSharp
{
    internal class Schemata219
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT219");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_48(long mutantId, Microsoft.Dafny.Function argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_53(long mutantId, Microsoft.Dafny.UnaryOpExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.CommonOptionBag.SystemModuleMode argument1, Microsoft.Dafny.CommonOptionBag.SystemModuleMode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_49(long mutantId, Microsoft.Dafny.Compilers.DatatypeWrapperEraser.MemberCompileStatus argument1, Microsoft.Dafny.Compilers.DatatypeWrapperEraser.MemberCompileStatus argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_43(long mutantId, System.Numerics.BigInteger argument1, ulong argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_54(long mutantId, Microsoft.Dafny.UnaryOpExpr.Opcode argument1, Microsoft.Dafny.UnaryOpExpr.Opcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_40(long mutantId, long argument1, System.Numerics.BigInteger argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_29(long mutantId, Microsoft.Dafny.NewtypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, Microsoft.Dafny.DatatypeCtor argument1, Microsoft.Dafny.DatatypeCtor argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.TypeParameter argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_24(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Type> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static int ReplacePrefixUnaryExprOp_5(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return ++argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return +argument1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return ~argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return --argument1; }
            return ++argument1;
        }

        internal static int ReplaceBinExprOp_22(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_34(long mutantId, Microsoft.Dafny.ConcreteSyntaxTree argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_30(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
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

        internal static bool ReplaceBinExprOp_23(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_39(long mutantId, System.Numerics.BigInteger argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_41(long mutantId, System.Numerics.BigInteger argument1, long argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_52(long mutantId, Microsoft.Dafny.CollectionType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.TypeParameter.ParentType argument1, Microsoft.Dafny.TopLevelDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_31(long mutantId, Microsoft.Dafny.TopLevelDeclWithMembers argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, Microsoft.Dafny.DatatypeCtor argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_36(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_33(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_50(long mutantId, Microsoft.Dafny.DatatypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.TypeParameter> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static ulong ReplaceNumericConstant_44(long mutantId, ulong argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 2)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return 0; }
            return argument1;
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

        internal static bool ReplaceBinExprOp_51(long mutantId, Microsoft.Dafny.TypeParameter.TPVariance argument1, Microsoft.Dafny.TypeParameter.TPVariance argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_25(long mutantId, Microsoft.Dafny.NativeType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_35(long mutantId, Microsoft.Dafny.ArrowType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_27(long mutantId, Microsoft.Dafny.NativeType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_37(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_7(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static int ReplaceNumericConstant_4(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static ulong ReplaceBinExprOp_46(long mutantId, ulong argument1, ulong argument2)
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

        internal static uint ReplaceNumericConstant_55(long mutantId, uint argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 2)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_42(long mutantId, ulong argument1, System.Numerics.BigInteger argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_38(long mutantId, int argument1, System.Numerics.BigInteger argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.TypeParameter> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static ulong ReplaceBinExprOp_45(long mutantId, ulong argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 >> argument2; }
            return argument1 << argument2;
        }

        internal static bool ReplaceBinExprOp_57(long mutantId, Microsoft.Dafny.MemberSelectExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_26(long mutantId, Microsoft.Dafny.SubsetTypeDecl.WKind argument1, Microsoft.Dafny.SubsetTypeDecl.WKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, Microsoft.Dafny.DatatypeCtor argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_56(long mutantId, System.Numerics.BigInteger argument1, System.Numerics.BigInteger argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_28(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_32(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_47(long mutantId, Microsoft.Dafny.Method argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.CommonOptionBag.SystemModuleMode argument1, Microsoft.Dafny.CommonOptionBag.SystemModuleMode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_19(long mutantId, int argument1, int argument2)
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
    public class CsharpCodeGenerator : SinglePassCodeGenerator
    {
        protected bool Synthesize = MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1L, false);

        public override IReadOnlySet<Feature> UnsupportedFeatures => new HashSet<Feature> {
      Feature.SubsetTypeTests,
      Feature.TuplesWiderThan20,
      Feature.ArraysWithMoreThan16Dims,
      Feature.ArrowsWithMoreThan16Arguments
    };

        public CsharpCodeGenerator(DafnyOptions options, ErrorReporter reporter) : base(options, reporter)
        {
        }

        const string DafnyISet = "Dafny.ISet";
        const string DafnyIMultiset = "Dafny.IMultiSet";
        const string DafnyISeq = "Dafny.ISequence";
        const string DafnyIMap = "Dafny.IMap";

        const string DafnySetClass = "Dafny.Set";
        const string DafnyMultiSetClass = "Dafny.MultiSet";
        const string DafnySeqClass = "Dafny.Sequence";
        const string DafnyMapClass = "Dafny.Map";

        const string DafnyHelpersClass = "Dafny.Helpers";

        static string FormatTypeDescriptorVariable(string typeVarName) => $"_td_{typeVarName}";
        string FormatTypeDescriptorVariable(TypeParameter tp) => FormatTypeDescriptorVariable(tp.GetCompileName(Options));
        const string TypeDescriptorMethodName = "_TypeDescriptor";

        string FormatDefaultTypeParameterValue(TopLevelDecl tp)
        {
            Contract.Requires(tp is TypeParameter || tp is AbstractTypeDecl);
            if (tp is AbstractTypeDecl)
            {
                // This is unusual. Typically, the compiler never needs to compile an abstract type, but this abstract type
                // is apparently an :extern (or a compiler error has already been reported and we're just trying to get to
                // the end of compilation without crashing). It's difficult to say what the compiler could do in this situation, since
                // it doesn't know how to generate code that produces a legal value of the abstract type. If we don't do
                // anything different from the common case (the "else" branch below), then the code emitted will not
                // compile (see github issue #1151). So, to do something a wee bit better, we emit a placebo value. This
                // will only work when the abstract type is in the same module and has no type parameters.
                return $"default({tp.EnclosingModuleDefinition.GetCompileName(Options) + MutateCSharp.Schemata219.ReplaceStringConstant_1(2L, ".") + tp.GetCompileName(Options)})";
            }
            else
            {
                // this is the common case
                return $"_default_{tp.GetCompileName(Options)}";
            }

            return default;
        }

        protected override void EmitHeader(Program program, ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(3L, "// Dafny program {0} compiled into C#"), program.Name);
            wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(4L, "// To recompile, you will need the libraries"));
            wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(5L, "//     System.Runtime.Numerics.dll System.Collections.Immutable.dll"));
            wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(6L, "// but the 'dotnet' tool in net6.0 should pick those up automatically."));
            wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(7L, "// Optionally, you may want to include compiler switches like"));
            wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(8L, "//     /debug /nowarn:162,164,168,183,219,436,1717,1718"));
            wr.WriteLine();
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_2(9L, program.Options.SystemModuleTranslationMode, CommonOptionBag.SystemModuleMode.OmitAllOtherModules))
            {
                wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(10L, "#if ISDAFNYRUNTIMELIB"));
            }
            wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(11L, "using System;"));
            wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(12L, "using System.Numerics;"));
            wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(13L, "using System.Collections;"));

            if (Options.Get(CommonOptionBag.ExecutionCoverageReport) != null)
            {
                wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(14L, "using System.IO;"));
            }

            if (MutateCSharp.Schemata219.ReplaceBinExprOp_2(15L, program.Options.SystemModuleTranslationMode, CommonOptionBag.SystemModuleMode.OmitAllOtherModules))
            {
                wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(16L, "#endif"));
            }
            Synthesize = ProgramHasMethodsWithAttr(program, MutateCSharp.Schemata219.ReplaceStringConstant_1(17L, "synthesize"));
            if (Synthesize)
            {
                CsharpSynthesizer.EmitImports(wr);
            }

            if (MutateCSharp.Schemata219.ReplaceBinExprOp_3(18L, program.Options.SystemModuleTranslationMode, CommonOptionBag.SystemModuleMode.OmitAllOtherModules))
            {
                EmitDafnySourceAttribute(program, wr);
            }

            if (Options.IncludeRuntime)
            {
                EmitRuntimeSource(MutateCSharp.Schemata219.ReplaceStringConstant_1(19L, "DafnyRuntimeCsharp"), wr, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(20L, false));
            }
            if (Options.Get(CommonOptionBag.UseStandardLibraries))
            {
                EmitRuntimeSource(MutateCSharp.Schemata219.ReplaceStringConstant_1(21L, "DafnyStandardLibraries_cs"), wr, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(22L, false));
            }

            if (Options.Get(CommonOptionBag.ExecutionCoverageReport) != null)
            {
                EmitCoverageReportInstrumentation(program, wr);
            }
        }

        /// <summary>
        /// Return true if the AST contains a method annotated with an attribute
        /// </summary>
        private static bool ProgramHasMethodsWithAttr(Program p, String attr)
        {
            foreach (var module in p.Modules())
            {
                foreach (ICallable callable in ModuleDefinition.AllCallables(
                           module.TopLevelDecls))
                {
                    if ((callable is Method method) &&
                        Attributes.Contains(method.Attributes, attr))
                    {
                        return MutateCSharp.Schemata219.ReplaceBooleanConstant_0(23L, true);
                    }
                }
            }
            return MutateCSharp.Schemata219.ReplaceBooleanConstant_0(24L, false);
        }

        void EmitDafnySourceAttribute(Program program, ConcreteSyntaxTree wr)
        {
            Contract.Requires(program != null);
            Contract.Requires(wr != null);

            var stringWriter = new StringWriter();
            stringWriter.NewLine = Environment.NewLine;
            var oldValue = Options.ShowEnv;
            Options.ShowEnv = ExecutionEngineOptions.ShowEnvironment.DuringPrint;
            new Printer(stringWriter, Options, PrintModes.Serialization).PrintProgramLargeStack(program, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(25L, true));
            Options.ShowEnv = oldValue;
            var programString = stringWriter.GetStringBuilder().Replace(MutateCSharp.Schemata219.ReplaceStringConstant_1(26L, "\""), MutateCSharp.Schemata219.ReplaceStringConstant_1(27L, "\"\"")).ToString();

            wr.WriteLine($"[assembly: DafnyAssembly.DafnySourceAttribute(@\"{programString}\")]");
            wr.WriteLine();
        }

        protected override void EmitBuiltInDecls(SystemModuleManager systemModuleManager, ConcreteSyntaxTree wr)
        {
            switch (Options.SystemModuleTranslationMode)
            {
                case CommonOptionBag.SystemModuleMode.Omit:
                    {
                        CheckCommonSytemModuleLimits(systemModuleManager);
                        break;
                    }

                    break;
                case CommonOptionBag.SystemModuleMode.OmitAllOtherModules:
                    {
                        CheckSystemModulePopulatedToCommonLimits(systemModuleManager);
                        break;
                    }

                    break;
            }

            // The declarations below would normally be omitted if we aren't compiling the system module,
            // but they are all marked as "internal", so they have to be included in each separately-compiled assembly.
            // In particular, FuncExtensions contain extension methods for the System.Func<> family of delegates,
            // and extension methods always only apply within the current assembly.
            //
            // Instead we just make sure to guard them with "#if ISDAFNYRUNTIMELIB" when compiling the system module,
            // so they don't become duplicates when --include-runtime is used.
            // See comment at the top of DafnyRuntime.cs.

            if (MutateCSharp.Schemata219.ReplaceBinExprOp_2(28L, Options.SystemModuleTranslationMode, CommonOptionBag.SystemModuleMode.OmitAllOtherModules))
            {
                wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(29L, "#if ISDAFNYRUNTIMELIB"));
            }

            var dafnyNamespace = CreateModule(MutateCSharp.Schemata219.ReplaceStringConstant_1(30L, "Dafny"), MutateCSharp.Schemata219.ReplaceBooleanConstant_0(31L, false), null, null, wr);
            EmitInitNewArrays(systemModuleManager, dafnyNamespace);
            if (Synthesize)
            {
                CsharpSynthesizer.EmitMultiMatcher(dafnyNamespace);
            }
            EmitFuncExtensions(systemModuleManager, wr);

            if (MutateCSharp.Schemata219.ReplaceBinExprOp_2(32L, Options.SystemModuleTranslationMode, CommonOptionBag.SystemModuleMode.OmitAllOtherModules))
            {
                wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(33L, "#endif"));
            }
        }

        // Generates casts for functions of those arities present in the program, like:
        //   public static class FuncExtensions {
        //     public static Func<U, UResult> DowncastClone<T, TResult, U, UResult>(this Func<T, TResult> F,
        //         Func<U, T> ArgConv, Func<TResult, UResult> ResConv) {
        //       return arg => ResConv(F(ArgConv(arg)));
        //     }
        //     ...
        //   }
        // They aren't in any namespace to make them universally accessible.
        private void EmitFuncExtensions(SystemModuleManager systemModuleManager, ConcreteSyntaxTree wr)
        {
            var funcExtensions = wr.NewNamedBlock(MutateCSharp.Schemata219.ReplaceStringConstant_1(34L, "internal static class FuncExtensions"));
            foreach (var kv in systemModuleManager.ArrowTypeDecls)
            {
                int arity = kv.Key;

                List<string> TypeParameterList(string prefix)
                {
                    var l = arity switch
                    {
                        1 => new List<string> { prefix },
                        _ => Enumerable.Range(MutateCSharp.Schemata219.ReplaceNumericConstant_4(35L, 1), arity).Select(i => $"{prefix}{i}").ToList()
                    };
                    l.Add($"{prefix}Result");
                    return l;
                }

                var us = TypeParameterList(MutateCSharp.Schemata219.ReplaceStringConstant_1(39L, "U"));
                var ts = TypeParameterList(MutateCSharp.Schemata219.ReplaceStringConstant_1(40L, "T"));

                string ArgConvDecl((string u, string t) tp) => $"Func<{tp.u}, {tp.t}> ArgConv";
                var argConvDecls = arity switch
                {
                    0 => "",
                    1 => $"{ArgConvDecl((MutateCSharp.Schemata219.ReplaceStringConstant_1(41L, "U"), MutateCSharp.Schemata219.ReplaceStringConstant_1(42L, "T")))}, ",
                    _ => Enumerable.Zip(us.SkipLast(MutateCSharp.Schemata219.ReplaceNumericConstant_4(43L, 1)), ts.SkipLast(MutateCSharp.Schemata219.ReplaceNumericConstant_4(47L, 1)))
                           .Comma((tp, i) => $"{ArgConvDecl(tp)}{MutateCSharp.Schemata219.ReplacePrefixUnaryExprOp_5(51L, ref i)}")
                         + MutateCSharp.Schemata219.ReplaceStringConstant_1(55L, ", "
          )
                };

                var parameters = $"this Func<{ts.Comma()}> F, {argConvDecls}Func<TResult, UResult> ResConv";
                funcExtensions.Write($"public static Func<{us.Comma()}> DowncastClone<{ts.Concat(us).Comma()}>({parameters})");

                var binder = arity switch { 1 => MutateCSharp.Schemata219.ReplaceStringConstant_1(56L, "arg"), _ => $"({Enumerable.Range(MutateCSharp.Schemata219.ReplaceNumericConstant_4(57L, 1), arity).Comma(i => $"arg{i}")})" };
                var argConvCalls = arity switch
                {
                    1 => MutateCSharp.Schemata219.ReplaceStringConstant_1(61L, "ArgConv(arg)"),
                    _ => Enumerable.Range(MutateCSharp.Schemata219.ReplaceNumericConstant_4(62L, 1), arity).Comma(i => $"ArgConv{i}(arg{i})")
                };
                funcExtensions.NewBlock().WriteLine($"return {binder} => ResConv(F({argConvCalls}));");
            }
        }

        private void EmitInitNewArrays(SystemModuleManager systemModuleManager, ConcreteSyntaxTree dafnyNamespace)
        {
            var arrayHelpers = dafnyNamespace.NewNamedBlock(MutateCSharp.Schemata219.ReplaceStringConstant_1(66L, "internal class ArrayHelpers"));
            foreach (var decl in systemModuleManager.SystemModule.TopLevelDecls)
            {
                if (decl is ArrayClassDecl classDecl)
                {
                    int dims = classDecl.Dims;

                    // Here is an overloading of the method name, where there is an initialValue parameter
                    // public static T[,] InitNewArray2<T>(T z, BigInteger size0, BigInteger size1) {
                    arrayHelpers.Write(
                      $"public static T[{Repeat("", dims, MutateCSharp.Schemata219.ReplaceStringConstant_1(67L, ","))}] InitNewArray{dims}<T>(T z, {Repeat(MutateCSharp.Schemata219.ReplaceStringConstant_1(68L, "BigInteger size{0}"), dims, MutateCSharp.Schemata219.ReplaceStringConstant_1(69L, ", "))})");

                    var w = arrayHelpers.NewBlock();
                    // int s0 = (int)size0;
                    for (int i = MutateCSharp.Schemata219.ReplaceNumericConstant_4(70L, 0); MutateCSharp.Schemata219.ReplaceBinExprOp_6(74L, i, dims); MutateCSharp.Schemata219.ReplacePostfixUnaryExprOp_7(79L, ref i))
                    {
                        w.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(80L, "int s{0} = (int)size{0};"), i);
                    }

                    // T[,] a = new T[s0, s1];
                    w.WriteLine($"T[{Repeat("", dims, MutateCSharp.Schemata219.ReplaceStringConstant_1(81L, ","))}] a = new T[{Repeat(MutateCSharp.Schemata219.ReplaceStringConstant_1(82L, "s{0}"), dims, MutateCSharp.Schemata219.ReplaceStringConstant_1(83L, ","))}];");

                    // for (int i0 = 0; i0 < s0; i0++) {
                    //   for (int i1 = 0; i1 < s1; i1++) {
                    var wLoopNest = w;
                    for (int i = MutateCSharp.Schemata219.ReplaceNumericConstant_4(84L, 0); MutateCSharp.Schemata219.ReplaceBinExprOp_6(88L, i, dims); MutateCSharp.Schemata219.ReplacePostfixUnaryExprOp_7(93L, ref i))
                    {
                        wLoopNest = wLoopNest.NewNamedBlock(MutateCSharp.Schemata219.ReplaceStringConstant_1(94L, "for (int i{0} = 0; i{0} < s{0}; i{0}++)"), i);
                    }

                    // a[i0,i1] = z;
                    wLoopNest.WriteLine($"a[{Repeat(MutateCSharp.Schemata219.ReplaceStringConstant_1(95L, "i{0}"), dims, MutateCSharp.Schemata219.ReplaceStringConstant_1(96L, ","))}] = z;");
                    // return a;
                    w.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(97L, "return a;"));
                }
            }
        }

        protected override ConcreteSyntaxTree CreateStaticMain(IClassWriter cw, string argsParameterName)
        {
            var wr = ((ClassWriter)cw).StaticMemberWriter;
            // See EmitCallToMain() - this is named differently because otherwise C# tries
            // to resolve the reference to the instance-level Main method
            return wr.NewBlock($"public static void _StaticMain(Dafny.ISequence<Dafny.ISequence<{CharTypeName}>> {argsParameterName})");
        }

        string IdProtectModule(string moduleName)
        {
            return string.Join(MutateCSharp.Schemata219.ReplaceStringConstant_1(98L, "."), moduleName.Split(MutateCSharp.Schemata219.ReplaceStringConstant_1(99L, ".")).Select(IdProtect));
        }

        protected override ConcreteSyntaxTree CreateModule(string moduleName, bool isDefault, ModuleDefinition externModule,
          string libraryName /*?*/, ConcreteSyntaxTree wr)
        {
            moduleName = IdProtectModule(moduleName);
            return wr.NewBlock($"namespace {moduleName}", MutateCSharp.Schemata219.ReplaceStringConstant_1(100L, " // end of ") + $"namespace {moduleName}");
        }

        protected override string GetHelperModuleName() => DafnyHelpersClass;

        const string DafnyTypeDescriptor = "Dafny.TypeDescriptor";

        internal string TypeParameters(List<TypeParameter>/*?*/ targs, bool addVariance = false, bool uniqueNames = false)
        {
            Contract.Requires(targs == null || cce.NonNullElements(targs));
            Contract.Ensures(Contract.Result<string>() != null);

            if (MutateCSharp.Schemata219.ReplaceBinExprOp_10(111L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_8(101L, targs, null), () => MutateCSharp.Schemata219.ReplaceBinExprOp_9(106L, targs.Count, MutateCSharp.Schemata219.ReplaceNumericConstant_4(102L, 0))))
            {
                return "";
            }

            string PrintVariance(TypeParameter.TPVariance variance)
            {
                if (addVariance)
                {
                    switch (variance)
                    {
                        case TypeParameter.TPVariance.Co:
                            return "out ";
                            break;
                        case TypeParameter.TPVariance.Contra:
                            return "in ";
                            break;
                    }
                }
                return "";
            }

            string PrintTypeParameter(TypeParameter tArg) => $"{PrintVariance(tArg.Variance)}{(uniqueNames ? MutateCSharp.Schemata219.ReplaceStringConstant_1(117L, "__") : "")}{IdName(tArg)}";

            return $"<{targs.Comma(PrintTypeParameter)}>";
        }

        protected override IClassWriter CreateClass(string moduleName, string name, bool isExtern, string /*?*/ fullPrintName,
          List<TypeParameter> typeParameters, TopLevelDecl cls, List<Type>/*?*/ superClasses, IToken tok, ConcreteSyntaxTree wr)
        {
            var wBody = WriteTypeHeader(MutateCSharp.Schemata219.ReplaceStringConstant_1(118L, "partial class"), name, typeParameters, superClasses, tok, wr);

            ConcreteSyntaxTree/*?*/ wCtorBody = null;
            if (cls is ClassLikeDecl cl)
            {
                if (cl.Members.TrueForAll(member => !(member is Constructor ctor) || !ctor.IsExtern(Options, out var _, out var _)))
                {
                    // This is a (non-default) class with no :extern constructor, so emit a C# constructor for the target class
                    EmitTypeDescriptorsForClass(typeParameters, cls, out var wTypeFields, out var wCtorParams, out _, out wCtorBody);
                    wBody.Append(wTypeFields);
                    wBody.Format($"public {name}({wCtorParams})").NewBlock().Append(wCtorBody);
                }
            }

            return new ClassWriter(this, wBody, wCtorBody);
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
        /// The method returns the number type descriptors written.
        /// </summary>
        int EmitTypeDescriptorsForClass(List<TypeParameter> typeParametersForClass, TopLevelDecl cls,
          out ConcreteSyntaxTree wTypeFields, out ConcreteSyntaxTree wCtorParams,
          out ConcreteSyntaxTree wCallArguments, out ConcreteSyntaxTree wCtorBody,
          List<TypeParameter> alternateTypeParameters = null)
        {

            wTypeFields = new ConcreteSyntaxTree();
            wCtorParams = new ConcreteSyntaxTree();
            wCallArguments = new ConcreteSyntaxTree();
            wCtorBody = new ConcreteSyntaxTree();
            int numberOfEmittedTypeDescriptors = MutateCSharp.Schemata219.ReplaceNumericConstant_4(119L, 0);
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_11(123L, typeParametersForClass, null))
            {
                var sep = "";
                foreach (var (ta, index) in TypeArgumentInstantiation.ListFromFormals(typeParametersForClass).Indexed())
                {
                    if (NeedsTypeDescriptor(ta.Formal))
                    {
                        var fieldName = FormatTypeDescriptorVariable((MutateCSharp.Schemata219.ReplaceBinExprOp_8(124L, alternateTypeParameters, null) ? ta.Formal : alternateTypeParameters[index]).GetCompileName(Options));
                        var actualType = MutateCSharp.Schemata219.ReplaceBinExprOp_8(125L, alternateTypeParameters, null) ? ta.Actual : new UserDefinedType(ta.Formal.tok, alternateTypeParameters[index]);
                        var paramName = TypeDescriptor(actualType, wCallArguments, ta.Formal.tok);
                        var decl = $"{DafnyTypeDescriptor}<{TypeName(actualType, wTypeFields, ta.Formal.tok)}> {fieldName}";

                        wTypeFields.WriteLine($"protected {decl};");
                        if (MutateCSharp.Schemata219.ReplaceBinExprOp_12(126L, ta.Formal.Parent, cls))
                        {
                            wCtorParams.Write($"{sep}{decl}");
                        }
                        wCtorBody.WriteLine($"this.{fieldName} = {paramName};");
                        wCallArguments.Write($"{sep}{paramName}");

                        sep = MutateCSharp.Schemata219.ReplaceStringConstant_1(127L, ", ");
                        MutateCSharp.Schemata219.ReplacePostfixUnaryExprOp_7(128L, ref numberOfEmittedTypeDescriptors);
                    }
                }
            }
            return numberOfEmittedTypeDescriptors;
        }

        /// <summary>
        /// Generate the "_TypeDescriptor" method for a generated class.
        /// </summary>
        private void EmitTypeDescriptorMethod(TopLevelDecl enclosingTypeDecl, ConcreteSyntaxTree wr)
        {
            Contract.Requires(enclosingTypeDecl != null);
            Contract.Requires(wr != null);

            var type = UserDefinedType.FromTopLevelDecl(enclosingTypeDecl.tok, enclosingTypeDecl);
            var initializer = DefaultValue(type, wr, enclosingTypeDecl.tok, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(129L, true));

            var targetTypeName = TypeName(type, wr, enclosingTypeDecl.tok);
            var typeDescriptorExpr = $"new {DafnyTypeDescriptor}<{targetTypeName}>({initializer})";

            if (MutateCSharp.Schemata219.ReplaceBinExprOp_9(134L, enclosingTypeDecl.TypeArgs.Count, MutateCSharp.Schemata219.ReplaceNumericConstant_4(130L, 0)))
            {
                wr.WriteLine($"private static readonly {DafnyTypeDescriptor}<{targetTypeName}> _TYPE = {typeDescriptorExpr};");
                typeDescriptorExpr = MutateCSharp.Schemata219.ReplaceStringConstant_1(139L, "_TYPE"); // use the precomputed value
            }

            List<TypeParameter> typeDescriptorParams;
            if (enclosingTypeDecl is DatatypeDecl dtDecl)
            {
                typeDescriptorParams = UsedTypeParameters(dtDecl, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(140L, true));
            }
            else
            {
                typeDescriptorParams = enclosingTypeDecl.TypeArgs;
            }

            var parameters = typeDescriptorParams.Comma(tp => $"{DafnyTypeDescriptor}<{tp.GetCompileName(Options)}> {FormatTypeDescriptorVariable(tp.GetCompileName(Options))}");
            var wTypeMethodBody = wr.Write($"public static {DafnyTypeDescriptor}<{targetTypeName}> {TypeDescriptorMethodName}({parameters})").NewBlock();
            wTypeMethodBody.WriteLine($"return {typeDescriptorExpr};");
        }

        protected override IClassWriter CreateTrait(string name, bool isExtern, List<TypeParameter> typeParameters /*?*/,
          TraitDecl trait, List<Type> superClasses /*?*/, IToken tok, ConcreteSyntaxTree wr)
        {
            var instanceMemberWriter = WriteTypeHeader(MutateCSharp.Schemata219.ReplaceStringConstant_1(141L, "interface"), name, typeParameters, superClasses, tok, wr);

            //writing the _Companion class
            wr.Write($"public class _Companion_{name}{TypeParameters(typeParameters)}");
            var staticMemberWriter = wr.NewBlock();

            return new ClassWriter(this, instanceMemberWriter, null, staticMemberWriter);
        }

        private ConcreteSyntaxTree WriteTypeHeader(string kind, string name, List<TypeParameter> typeParameters, List<Type>/*?*/ superClasses, IToken tok, ConcreteSyntaxTree wr)
        {
            wr.Write($"public {kind} {IdProtect(name)}{TypeParameters(typeParameters)}");
            var realSuperClasses = superClasses?.Where(trait => !trait.IsObject).ToList() ?? new List<Type>();
            if (realSuperClasses.Any())
            {
                wr.Write($" : {realSuperClasses.Comma(trait => TypeName(trait, wr, tok))}");
            }
            return wr.NewBlock();
        }

        protected override ConcreteSyntaxTree CreateIterator(IteratorDecl iter, ConcreteSyntaxTree wr)
        {
            // An iterator is compiled as follows:
            //   public class MyIteratorExample<T>
            //   {
            //     public T q;  // in-parameter
            //     public T x;  // yield-parameter
            //     public int y;  // yield-parameter
            //     IEnumerator<object> _iter;
            //
            //     public void _MyIteratorExample(T q) {
            //       this.q = q;
            //       _iter = TheIterator();
            //     }
            //
            //     public bool MoveNext() {
            //       return _iter.MoveNext();
            //     }
            //
            //     private IEnumerator<object> TheIterator() {
            //       // the translation of the body of the iterator, with each "yield" turning into a "yield return null;"
            //       yield break;
            //     }
            //   }

            var cw = (ClassWriter)CreateClass(IdProtect(iter.EnclosingModuleDefinition.GetCompileName(Options)), IdName(iter), iter, wr);
            var w = cw.InstanceMemberWriter;
            // here come the fields

            var constructors = iter.Members.OfType<Constructor>().ToList();

            // we're expecting just one constructor 
            var enumerable = constructors.ToList();
            Contract.Assert(enumerable.Count == 1);
            Constructor ct = constructors[MutateCSharp.Schemata219.ReplaceNumericConstant_4(142L, 0)];

            foreach (var member in iter.Members)
            {
                if (member is Field f && !f.IsGhost)
                {
                    cw.DeclareField(IdName(f), iter, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(146L, false), MutateCSharp.Schemata219.ReplaceBooleanConstant_0(147L, false), f.Type, f.tok, PlaceboValue(f.Type, w, f.tok, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(148L, true)), f);
                }
            }

            w.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(149L, "System.Collections.Generic.IEnumerator<object> _iter;"));

            // here we rely on the parameters and the corresponding fields having the same names
            var nonGhostFormals = ct.Ins.Where(p => !p.IsGhost).ToList();
            var parameters = nonGhostFormals.Comma(p => $"{TypeName(p.Type, w, p.tok)} {IdName(p)}");

            // here's the initializer method
            w.Write($"public void {IdName(ct)}({parameters})");
            var wBody = w.NewBlock();
            foreach (var p in nonGhostFormals)
            {
                wBody.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(150L, "this.{0} = {0};"), IdName(p));
            }

            wBody.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(151L, "this._iter = TheIterator();"));
            // here are the enumerator methods
            w.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(152L, "public bool MoveNext() { return _iter.MoveNext(); }"));
            var wIter = w.NewBlock(MutateCSharp.Schemata219.ReplaceStringConstant_1(153L, "private System.Collections.Generic.IEnumerator<object> TheIterator()"));
            var beforeYield = wIter.Fork();
            wIter.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(154L, "yield break;"));
            return beforeYield;
        }

        private string DtTypeName(TopLevelDecl dt, bool typeVariables = true)
        {
            var name = MutateCSharp.Schemata219.ReplaceStringConstant_1(155L, "_I") + dt.GetCompileName(Options);
            if (typeVariables) { name += TypeParameters(SelectNonGhost(dt, dt.TypeArgs)); }
            return name;
        }

        protected override IClassWriter/*?*/ DeclareDatatype(DatatypeDecl dt, ConcreteSyntaxTree wr)
        {
            var w = CompileDatatypeBase(dt, wr);
            CompileDatatypeConstructors(dt, wr);
            return w;
        }

        IClassWriter CompileDatatypeBase(DatatypeDecl dt, ConcreteSyntaxTree wr)
        {
            Contract.Requires(dt != null);
            Contract.Requires(wr != null);

            // public interface _IDt<T> { // T has variance modifier
            //   _IDt<T> _Get();  // for co-datatypes
            //
            //   bool is_Ctor0 { get; }
            //   ...
            //
            //   T0 dtor_Dtor0 { get; }
            //   ...
            //
            //   _IDt<U> DowncastClone<U>(Func<T0, U0> converter0, ...);
            //
            //   // Members that don't violate C# variance restrictions
            // }
            //
            // public abstract class Dt<T> : _IDt<T> {  // for record types: drop "abstract"
            //   public Dt() { }
            //   #if TypeArgs.Count == 0
            //     private static _IDt<T> theDefault = ...;
            //     public static _IDt<T> Default() {
            //       return theDefault;
            //     }
            //   #else
            //     public static _IDt<T> Default(values...) {
            //       return ...;
            //     }
            //   #endif
            //   public static TypeDescriptor<_IDt<T>> _TypeDescriptor(typeDescriptors...) {
            //     return new TypeDescriptor<_IDt<T>>(Default(typeDescriptors...));
            //   }
            //   public abstract _IDt<T> _Get();  // for co-datatypes
            //
            //   public static _IDt<T> create_Ctor0(field0, field1, ...) {  // for record types: create
            //     return new Dt_Ctor0(field0, field1, ...);                // for record types: new Dt
            //   }
            //   ...
            //
            //   public bool is_Ctor0 { get { return this is Dt_Ctor0; } }  // for record types: return true
            //   ...
            //
            //   // if the datatype HasFinitePossibleValues
            //   public static System.Collections.Generic.IEnumerable<_IDt<T>> AllSingletonConstructors { get {
            //     yield return _IDt<T>.create_Ctor0();
            //     ...
            //   }}
            //
            //   public T0 dtor_Dtor0 { get {
            //       var d = this;         // for inductive datatypes
            //       var d = this._Get();  // for co-inductive datatypes
            //       if (d is DT_Ctor0) { return ((DT_Ctor0)d).Dtor0; }
            //       if (d is DT_Ctor1) { return ((DT_Ctor1)d).Dtor0; }
            //       ...
            //       if (d is DT_Ctor(n-2)) { return ((DT_Ctor(n-2))d).Dtor0; }
            //       return ((DT_Ctor(n-1))d).Dtor0;  // for record types: drop cast
            //    }}
            //   ...
            //
            //   public abstract _IDt<U> DowncastClone<U>(Func<T0, U0> converter0, ...); // for record types: implementation
            //
            //   // Implementations of all members, but possibly (variance) rewritten to be static.
            // }
            var nonGhostTypeArgs = SelectNonGhost(dt, dt.TypeArgs);
            var DtT_TypeArgs = TypeParameters(nonGhostTypeArgs);
            var DtT_protected = IdName(dt) + DtT_TypeArgs;
            var simplifiedType = DatatypeWrapperEraser.SimplifyType(Options, UserDefinedType.FromTopLevelDecl(dt.tok, dt));
            var simplifiedTypeName = TypeName(simplifiedType, wr, dt.tok);

            // ConcreteSyntaxTree for the interface
            wr.Write($"public interface _I{dt.GetCompileName(Options)}{TypeParameters(nonGhostTypeArgs, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(156L, true))}");
            var superTraits = dt.ParentTypeInformation.UniqueParentTraits();
            if (superTraits.Any())
            {
                wr.Write($" : {superTraits.Comma(trait => TypeName(trait, wr, dt.tok))}");
            }
            var interfaceTree = wr.NewBlock();

            // from here on, write everything into the new block created here:
            var btw = wr.NewNamedBlock(MutateCSharp.Schemata219.ReplaceStringConstant_1(157L, "public{0} class {1} : {2}"), dt.IsRecordType ? "" : MutateCSharp.Schemata219.ReplaceStringConstant_1(158L, " abstract"), DtT_protected, DtTypeName(dt));
            wr = btw;

            // constructor
            if (dt.IsRecordType)
            {
                DatatypeFieldsAndConstructor(dt.Ctors[MutateCSharp.Schemata219.ReplaceNumericConstant_4(159L, 0)], MutateCSharp.Schemata219.ReplaceNumericConstant_4(163L, 0), wr);
            }
            else
            {
                EmitTypeDescriptorsForClass(dt.TypeArgs, dt, out var wTypeFields, out var wCtorParams, out _, out var wCtorBody);
                wr.Append(wTypeFields);
                wr.Format($"public {IdName(dt)}({wCtorParams})").NewBlock().Append(wCtorBody);
            }

            var wDefault = new ConcreteSyntaxTree();
            ConcreteSyntaxTree wDefaultTypeArguments;
            var defaultMethodTypeDescriptorCount = MutateCSharp.Schemata219.ReplaceNumericConstant_4(167L, 0);
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_9(175L, nonGhostTypeArgs.Count, MutateCSharp.Schemata219.ReplaceNumericConstant_4(171L, 0)))
            {
                wr.FormatLine($"private static readonly {simplifiedTypeName} theDefault = {wDefault};");
                var w = wr.NewBlock($"public static {simplifiedTypeName} Default()");
                w.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(180L, "return theDefault;"));
                wDefaultTypeArguments = new ConcreteSyntaxTree();
            }
            else
            {
                wr.Write($"public static {simplifiedTypeName} Default(");
                defaultMethodTypeDescriptorCount = EmitTypeDescriptorsForClass(dt.TypeArgs, dt, out _, out var wDefaultParameters, out wDefaultTypeArguments, out _);
                var usedTypeParameters = UsedTypeParameters(dt);
                var parameters = usedTypeParameters.Comma(tp => $"{tp.GetCompileName(Options)} {FormatDefaultTypeParameterValue(tp)}");
                var sep = MutateCSharp.Schemata219.ReplaceBinExprOp_14(199L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_13(185L, defaultMethodTypeDescriptorCount, MutateCSharp.Schemata219.ReplaceNumericConstant_4(181L, 0)), () => MutateCSharp.Schemata219.ReplaceBinExprOp_13(194L, usedTypeParameters.Count, MutateCSharp.Schemata219.ReplaceNumericConstant_4(190L, 0))) ? MutateCSharp.Schemata219.ReplaceStringConstant_1(205L, ", ") : "";
                wr.Write($"{wDefaultParameters}{sep}{parameters})");
                var w = wr.NewBlock();
                w.FormatLine($"return {wDefault};");
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
                if (dt is CoDatatypeDecl)
                {
                    var wCo = wDefault;
                    var count = EmitTypeDescriptorsForClass(dt.TypeArgs, dt, out _, out _, out var lazyTypeDescriptorArguments, out _);
                    var sep = MutateCSharp.Schemata219.ReplaceBinExprOp_15(210L, count, MutateCSharp.Schemata219.ReplaceNumericConstant_4(206L, 0)) ? MutateCSharp.Schemata219.ReplaceStringConstant_1(215L, ", ") : "";
                    wDefault = new ConcreteSyntaxTree();
                    wCo.Format($"new {dt.GetFullCompileName(Options)}__Lazy{DtT_TypeArgs}({lazyTypeDescriptorArguments}{sep}() => {{ return {wDefault}; }})");
                }

                var wDefaultArguments = wDefault.Write(DtCreateName(groundingCtor)).ForkInParens();
                wDefaultArguments.Append(wDefaultTypeArguments);
                var nonGhostFormals = groundingCtor.Formals.Where(f => !f.IsGhost).ToList();
                if (MutateCSharp.Schemata219.ReplaceBinExprOp_14(234L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_13(220L, defaultMethodTypeDescriptorCount, MutateCSharp.Schemata219.ReplaceNumericConstant_4(216L, 0)), () => MutateCSharp.Schemata219.ReplaceBinExprOp_13(229L, nonGhostFormals.Count, MutateCSharp.Schemata219.ReplaceNumericConstant_4(225L, 0))))
                {
                    wDefaultArguments.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(240L, ", "));
                }
                wDefaultArguments.Write(nonGhostFormals.Comma(f => DefaultValue(f.Type, wDefault, f.tok)));
            }

            EmitTypeDescriptorMethod(dt, wr);

            if (dt is CoDatatypeDecl)
            {
                interfaceTree.WriteLine($"{DtTypeName(dt)} _Get();");
                wr.WriteLine($"public abstract {DtTypeName(dt)} _Get();");
            }

            // create methods
            foreach (var ctor in dt.Ctors.Where(ctor => !ctor.IsGhost))
            {
                var typeDescriptorCount = EmitTypeDescriptorsForClass(dt.TypeArgs, dt, out _, out var wCtorParams, out var wCallArguments, out _);
                wr.Write($"public static {DtTypeName(dt)} {DtCreateName(ctor)}(");
                wr.Append(wCtorParams);
                var formalCount = WriteFormals(MutateCSharp.Schemata219.ReplaceBinExprOp_15(245L, typeDescriptorCount, MutateCSharp.Schemata219.ReplaceNumericConstant_4(241L, 0)) ? MutateCSharp.Schemata219.ReplaceStringConstant_1(250L, ", ") : "", ctor.Formals, wr);
                var sep = MutateCSharp.Schemata219.ReplaceBinExprOp_14(269L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_15(255L, typeDescriptorCount, MutateCSharp.Schemata219.ReplaceNumericConstant_4(251L, 0)), () => MutateCSharp.Schemata219.ReplaceBinExprOp_15(264L, formalCount, MutateCSharp.Schemata219.ReplaceNumericConstant_4(260L, 0))) ? MutateCSharp.Schemata219.ReplaceStringConstant_1(275L, ", ") : "";
                wr.NewBlock(MutateCSharp.Schemata219.ReplaceStringConstant_1(276L, ")"))
                  .WriteLine($"return new {DtCtorDeclarationName(ctor)}{DtT_TypeArgs}({wCallArguments}{sep}{ctor.Formals.Where(f => !f.IsGhost).Comma(FormalName)});");
            }

            if (dt.IsRecordType)
            {
                // Also emit a "create_<ctor_name>" method that thunks to "create",
                // to provide a more uniform interface.

                var ctor = dt.Ctors[MutateCSharp.Schemata219.ReplaceNumericConstant_4(277L, 0)];
                var typeDescriptorCount = EmitTypeDescriptorsForClass(dt.TypeArgs, dt, out _, out var wCtorParams, out var wCallArguments, out _);
                wr.Write($"public static {DtTypeName(dt)} create_{ctor.GetCompileName(Options)}(");
                wr.Append(wCtorParams);
                var formalCount = WriteFormals(MutateCSharp.Schemata219.ReplaceBinExprOp_15(285L, typeDescriptorCount, MutateCSharp.Schemata219.ReplaceNumericConstant_4(281L, 0)) ? MutateCSharp.Schemata219.ReplaceStringConstant_1(290L, ", ") : "", ctor.Formals, wr);
                var sep = MutateCSharp.Schemata219.ReplaceBinExprOp_14(309L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_15(295L, typeDescriptorCount, MutateCSharp.Schemata219.ReplaceNumericConstant_4(291L, 0)), () => MutateCSharp.Schemata219.ReplaceBinExprOp_15(304L, formalCount, MutateCSharp.Schemata219.ReplaceNumericConstant_4(300L, 0))) ? MutateCSharp.Schemata219.ReplaceStringConstant_1(315L, ", ") : "";
                wr.NewBlock(MutateCSharp.Schemata219.ReplaceStringConstant_1(316L, ")"))
                  .WriteLine($"return create({wCallArguments}{sep}{ctor.Formals.Where(f => !f.IsGhost).Comma(FormalName)});");
            }

            // query properties
            if (dt is TupleTypeDecl)
            {
                // omit the is_ property for tuples, since it cannot be used syntactically in the language
            }
            else
            {
                foreach (var ctor in dt.Ctors.Where(ctor => !ctor.IsGhost))
                {
                    interfaceTree.WriteLine($"bool is_{ctor.GetCompileName(Options)} {{ get; }}");

                    var returnValue = dt.IsRecordType
                      // public bool is_Ctor0 { get { return true; } }
                      ? MutateCSharp.Schemata219.ReplaceStringConstant_1(317L, "true"
          )
                      // public bool is_Ctor0 { get { return this is Dt_Ctor0; } }
                      : $"this is {dt.GetCompileName(Options)}_{ctor.GetCompileName(Options)}{DtT_TypeArgs}";
                    wr.WriteLine($"public bool is_{ctor.GetCompileName(Options)} {{ get {{ return {returnValue}; }} }}");
                }
            }

            if (dt.HasFinitePossibleValues)
            {
                Contract.Assert(nonGhostTypeArgs.Count == 0);
                var w = wr.NewNamedBlock(
                  $"public static System.Collections.Generic.IEnumerable<{DtTypeName(dt)}> AllSingletonConstructors");
                var wGet = w.NewBlock(MutateCSharp.Schemata219.ReplaceStringConstant_1(318L, "get"));
                foreach (var ctor in dt.Ctors)
                {
                    Contract.Assert(ctor.Formals.Count == 0);
                    var constructor = ctor.IsGhost
                      ? ForcePlaceboValue(UserDefinedType.FromTopLevelDecl(dt.tok, dt), wGet, dt.tok)
                      : $"{DtT_protected}.{DtCreateName(ctor)}()";
                    wGet.WriteLine($"yield return {constructor};");
                }
            }

            CompileDatatypeDestructorsAndAddToInterface(dt, wr, interfaceTree, DtT_TypeArgs);

            CompileDatatypeDowncastClone(dt, interfaceTree, nonGhostTypeArgs, toInterface: MutateCSharp.Schemata219.ReplaceBooleanConstant_0(319L, true));
            if (!dt.IsRecordType)
            {
                CompileDatatypeDowncastClone(dt, wr, nonGhostTypeArgs);
            }

            CompileDatatypeInterfaceMembers(dt, interfaceTree);

            return new ClassWriter(this, btw, null);
        }

        /// <summary>
        /// Generate the "DowncastClone" code for a generated datatype. This includes the exported signature for the interface,
        /// the abstract method for the abstract class, and the actual implementations for the constructor classes. If the
        /// datatype is a record type, there is no abstract class, so the method is directly emitted. Contravariant type
        /// parameters require a CustomReceiver-like treatment involving static methods and can thus require a jump table in
        /// the abstract class. Erasable type wrappers require the same kind of CustomReceiver-like treatment and operate
        /// on the unwrapped type.
        /// toInterface: just the signature for the interface
        /// lazy: convert the computer of a codatatype's "__Lazy" class
        /// ctor: constructor to generate the method for
        /// </summary>
        private void CompileDatatypeDowncastClone(DatatypeDecl datatype, ConcreteSyntaxTree wr,
            List<TypeParameter> nonGhostTypeArgs, bool toInterface = false, bool lazy = false, DatatypeCtor ctor = null)
        {
            bool InvalidType(Type ty, bool refTy) => MutateCSharp.Schemata219.ReplaceBinExprOp_10(339L, () => (MutateCSharp.Schemata219.ReplaceBinExprOp_14(327L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_14(321L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_16(320L, ty.AsTypeParameter, null), () => refTy), () => datatype.TypeArgs.Contains(ty.AsTypeParameter)))
      , () => ty.TypeArgs.Exists(arg => InvalidType(arg, MutateCSharp.Schemata219.ReplaceBinExprOp_10(333L, () => refTy, () => ty.IsRefType))));

            if (datatype.Ctors.Any(ctor => ctor.Formals.Any(f => MutateCSharp.Schemata219.ReplaceBinExprOp_14(346L, () => !f.IsGhost, () => InvalidType(f.SyntacticType, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(345L, false))))))
            {
                return;
            }

            var customReceiver = DowncastCloneNeedsCustomReceiver(datatype);
            var uTypeArgs = TypeParameters(nonGhostTypeArgs, uniqueNames: MutateCSharp.Schemata219.ReplaceBooleanConstant_0(352L, true));
            var typeArgs = TypeParameters(nonGhostTypeArgs);
            var typeParameterSubstMap = nonGhostTypeArgs.ToDictionary(
              tp => tp,
              tp => new TypeParameter(tp.RangeToken, tp.NameNode.Prepend(MutateCSharp.Schemata219.ReplaceStringConstant_1(353L, "_")), tp.VarianceSyntax));
            var typeSubstMap = nonGhostTypeArgs.ToDictionary(
              tp => tp,
              tp => (Type)new UserDefinedType(tp.tok, typeParameterSubstMap[tp]));
            var uTypeParameters = datatype.TypeArgs.ConvertAll(tp => typeParameterSubstMap[tp]);

            var resultType = DatatypeWrapperEraser.GetInnerTypeOfErasableDatatypeWrapper(Options, datatype, out var innerType)
              ? TypeName(innerType.Subst(typeSubstMap), wr, datatype.tok)
              : MutateCSharp.Schemata219.ReplaceStringConstant_1(354L, "_I") + datatype.GetCompileName(Options) + uTypeArgs;
            var converters = $"{nonGhostTypeArgs.Comma((_, i) => $"converter{i}")}";
            var lazyClass = $"{datatype.GetFullCompileName(Options)}__Lazy";
            string PrintConverter(TypeParameter tArg, int i)
            {
                var name = IdName(tArg);
                return $"Func<{name}, __{name}> converter{i}";
            }

            if (!toInterface)
            {
                string Modifiers(string abs, string single, string cons) =>
                  (MutateCSharp.Schemata219.ReplaceBinExprOp_10(356L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_17(355L, ctor, null), () => lazy)) ? (datatype.IsRecordType ? single : cons) : abs;
                var modifiers = customReceiver
                  ? Modifiers(MutateCSharp.Schemata219.ReplaceStringConstant_1(362L, "static "), MutateCSharp.Schemata219.ReplaceStringConstant_1(363L, "static "), MutateCSharp.Schemata219.ReplaceStringConstant_1(364L, "new static "))
                  : Modifiers(MutateCSharp.Schemata219.ReplaceStringConstant_1(365L, "abstract "), "", MutateCSharp.Schemata219.ReplaceStringConstant_1(366L, "override "));
                wr.Write($"public {modifiers}");
            }

            if (!(MutateCSharp.Schemata219.ReplaceBinExprOp_14(367L, () => toInterface, () => customReceiver)))
            {
                var typeDescriptorCount = EmitTypeDescriptorsForClass(datatype.TypeArgs, datatype,
                  out _, out var wTypeDescriptorDecls, out _, out _, uTypeParameters);

                string receiver;
                if (customReceiver)
                {
                    var simplifiedType = DatatypeWrapperEraser.SimplifyType(Options, UserDefinedType.FromTopLevelDecl(datatype.tok, datatype));
                    receiver = $"{TypeName(simplifiedType, wr, datatype.tok)} _this";
                }
                else
                {
                    receiver = "";
                }

                var comma0 = MutateCSharp.Schemata219.ReplaceBinExprOp_14(391L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_13(377L, typeDescriptorCount, MutateCSharp.Schemata219.ReplaceNumericConstant_4(373L, 0)), () => MutateCSharp.Schemata219.ReplaceBinExprOp_13(386L, receiver.Length, MutateCSharp.Schemata219.ReplaceNumericConstant_4(382L, 0))) ? MutateCSharp.Schemata219.ReplaceStringConstant_1(397L, ", ") : "";
                var comma1 = MutateCSharp.Schemata219.ReplaceBinExprOp_14(431L, () => (MutateCSharp.Schemata219.ReplaceBinExprOp_10(416L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_13(402L, typeDescriptorCount, MutateCSharp.Schemata219.ReplaceNumericConstant_4(398L, 0)), () => MutateCSharp.Schemata219.ReplaceBinExprOp_13(411L, receiver.Length, MutateCSharp.Schemata219.ReplaceNumericConstant_4(407L, 0)))), () => MutateCSharp.Schemata219.ReplaceBinExprOp_13(426L, nonGhostTypeArgs.Count, MutateCSharp.Schemata219.ReplaceNumericConstant_4(422L, 0))) ? MutateCSharp.Schemata219.ReplaceStringConstant_1(437L, ", ") : "";
                wr.Write($"{resultType} DowncastClone{uTypeArgs}({wTypeDescriptorDecls}{comma0}{receiver}{comma1}{nonGhostTypeArgs.Comma(PrintConverter)})");
            }

            if (MutateCSharp.Schemata219.ReplaceBinExprOp_14(439L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_18(438L, ctor, null), () => !lazy))
            {
                if (!customReceiver)
                {
                    wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(445L, ";"));
                }
                else if (!toInterface)
                {
                    var body = wr.NewBlock();

                    ConcreteSyntaxTree NextBlock(string comp) { return body.NewBlock($"if (_this{comp})"); }

                    void WriteReturn(ConcreteSyntaxTree wr, string staticClass)
                    {
                        var typeDescriptorCount = EmitTypeDescriptorsForClass(datatype.TypeArgs, datatype,
                          out _, out _, out var wTypeDescriptorArguments, out _, uTypeParameters);
                        var sep0 = MutateCSharp.Schemata219.ReplaceBinExprOp_13(450L, typeDescriptorCount, MutateCSharp.Schemata219.ReplaceNumericConstant_4(446L, 0)) ? MutateCSharp.Schemata219.ReplaceStringConstant_1(455L, ", ") : "";
                        var sep1 = MutateCSharp.Schemata219.ReplaceBinExprOp_13(460L, converters.Length, MutateCSharp.Schemata219.ReplaceNumericConstant_4(456L, 0)) ? MutateCSharp.Schemata219.ReplaceStringConstant_1(465L, ", ") : "";
                        wr.WriteLine($"return {staticClass}{typeArgs}.DowncastClone{uTypeArgs}({wTypeDescriptorArguments}{sep0}_this{sep1}{converters});");
                    }

                    if (datatype is CoDatatypeDecl)
                    {
                        WriteReturn(NextBlock($" is {lazyClass}{typeArgs}"), lazyClass);
                    }

                    var nonGhostConstructors = datatype.Ctors.Where(ctor => !ctor.IsGhost).ToList();
                    for (var i = MutateCSharp.Schemata219.ReplaceNumericConstant_4(466L, 0); MutateCSharp.Schemata219.ReplaceBinExprOp_6(470L, i, nonGhostConstructors.Count); MutateCSharp.Schemata219.ReplacePostfixUnaryExprOp_7(475L, ref i))
                    {
                        var ret = body;
                        //The final constructor is chosen as the default
                        if (MutateCSharp.Schemata219.ReplaceBinExprOp_6(489L, MutateCSharp.Schemata219.ReplaceBinExprOp_19(480L, i, MutateCSharp.Schemata219.ReplaceNumericConstant_4(476L, 1)), nonGhostConstructors.Count))
                        {
                            ret = NextBlock($".is_{nonGhostConstructors[i].GetCompileName(Options)}");
                        }
                        WriteReturn(ret, DtCtorDeclarationName(nonGhostConstructors[i]));
                    }
                }
                return;
            }

            string PrintConvertedExpr(string name, Type fromType)
            {
                var constructorIndex = nonGhostTypeArgs.IndexOf(fromType.AsTypeParameter);
                if (MutateCSharp.Schemata219.ReplaceBinExprOp_13(498L, constructorIndex, MutateCSharp.Schemata219.ReplaceNumericConstant_4(494L, -1)))
                {
                    return $"converter{constructorIndex}({name})";
                }

                bool ContainsTyVar(TypeParameter tp, Type ty)
                  => MutateCSharp.Schemata219.ReplaceBinExprOp_10(510L, () => (MutateCSharp.Schemata219.ReplaceBinExprOp_14(504L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_16(503L, ty.AsTypeParameter, null), () => ty.AsTypeParameter.Equals(tp)))
        , () => ty.TypeArgs.Exists(ty => ContainsTyVar(tp, ty)));
                if (nonGhostTypeArgs.Exists(ty => ContainsTyVar(ty, fromType)))
                {
                    var map = nonGhostTypeArgs.ToDictionary(
                      tp => tp,
                      tp => (Type)new UserDefinedType(tp.tok, new TypeParameter(tp.RangeToken, tp.NameNode.Prepend(MutateCSharp.Schemata219.ReplaceStringConstant_1(516L, "_")), tp.VarianceSyntax)));
                    var to = fromType.Subst(map);
                    var downcast = new ConcreteSyntaxTree();
                    EmitDowncast(fromType, to, null, downcast).Write(name);
                    return downcast.ToString();
                }

                return name;
            }

            string PrintInvocation(Formal f, int i)
            {
                var name = customReceiver
                  ? MutateCSharp.Schemata219.ReplaceBinExprOp_10(517L, () => datatype.IsRecordType, () => !f.HasName
        ) ? $"(({DtCtorDeclarationName(ctor)}{typeArgs}) _this).{FieldName(f, i)}"
                    : $"_this.{DestructorGetterName(f, ctor, i)}"
                  : FieldName(f, i);
                return PrintConvertedExpr(name, f.Type);
            }

            if (MutateCSharp.Schemata219.ReplaceBinExprOp_20(523L, innerType, null))
            {
                var wBody = wr.NewBlock("");
                wBody.WriteLine($"return {PrintConvertedExpr(MutateCSharp.Schemata219.ReplaceStringConstant_1(524L, "_this"), innerType)};");
            }
            else
            {
                var wBody = wr.NewBlock("").WriteLine($"if ({(customReceiver ? MutateCSharp.Schemata219.ReplaceStringConstant_1(525L, "_") : "")}this is {resultType} dt) {{ return dt; }}");
                var typeDescriptorCount = EmitTypeDescriptorsForClass(datatype.TypeArgs, datatype, out _, out _, out var wCallArguments, out _, uTypeParameters);
                var typeDescriptorArgumentsStrings = wCallArguments.ToString();
                string constructorArgs;
                if (!lazy)
                {
                    constructorArgs = ctor.Formals.Where(f => !f.IsGhost).Comma(PrintInvocation);
                }
                else if (customReceiver)
                {
                    var sep0 = MutateCSharp.Schemata219.ReplaceBinExprOp_13(530L, typeDescriptorCount, MutateCSharp.Schemata219.ReplaceNumericConstant_4(526L, 0)) ? MutateCSharp.Schemata219.ReplaceStringConstant_1(535L, ", ") : "";
                    var sep1 = MutateCSharp.Schemata219.ReplaceBinExprOp_13(540L, converters.Length, MutateCSharp.Schemata219.ReplaceNumericConstant_4(536L, 0)) ? MutateCSharp.Schemata219.ReplaceStringConstant_1(545L, ", ") : "";
                    constructorArgs =
                      $"() => {datatype.GetCompileName(Options)}{typeArgs}.DowncastClone{uTypeArgs}({typeDescriptorArgumentsStrings}{sep0}_this._Get(){sep1}{converters})";
                }
                else
                {
                    var sep0 = MutateCSharp.Schemata219.ReplaceBinExprOp_14(564L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_13(550L, typeDescriptorCount, MutateCSharp.Schemata219.ReplaceNumericConstant_4(546L, 0)), () => MutateCSharp.Schemata219.ReplaceBinExprOp_13(559L, converters.Length, MutateCSharp.Schemata219.ReplaceNumericConstant_4(555L, 0))) ? MutateCSharp.Schemata219.ReplaceStringConstant_1(570L, ", ") : "";
                    constructorArgs = $"() => _Get().DowncastClone{uTypeArgs}({typeDescriptorArgumentsStrings}{sep0}{converters})";
                }
                var sep = MutateCSharp.Schemata219.ReplaceBinExprOp_14(586L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_13(575L, typeDescriptorCount, MutateCSharp.Schemata219.ReplaceNumericConstant_4(571L, 0)), () => (MutateCSharp.Schemata219.ReplaceBinExprOp_10(580L, () => lazy, () => ctor.Formals.Any(f => !f.IsGhost)))) ? MutateCSharp.Schemata219.ReplaceStringConstant_1(592L, ", ") : "";
                var className = lazy ? lazyClass : DtCtorDeclarationName(ctor);
                wBody.WriteLine($"return new {className}{uTypeArgs}({typeDescriptorArgumentsStrings}{sep}{constructorArgs});");
            }
        }

        // Emits getters for both named and unnamed destructors. The named ones are grouped across constructors by their
        // name and thus QDtorM = DtorM. This is not possible for unnamed ones, as there is no guarantee about shared return
        // types, so they are treated individually and their names (QDtorM) are qualified by their respective constructors.
        private void CompileDatatypeDestructorsAndAddToInterface(DatatypeDecl dt, ConcreteSyntaxTree wr,
            ConcreteSyntaxTree interfaceTree, string DtT_TypeArgs)
        {
            foreach (var ctor in dt.Ctors)
            {
                var index = MutateCSharp.Schemata219.ReplaceNumericConstant_4(593L, 0);
                foreach (var dtor in ctor.Destructors.Where(dtor => MutateCSharp.Schemata219.ReplaceBinExprOp_21(601L, dtor.EnclosingCtors[MutateCSharp.Schemata219.ReplaceNumericConstant_4(597L, 0)], ctor)))
                {
                    var compiledConstructorCount = dtor.EnclosingCtors.Count(constructor => !constructor.IsGhost);
                    if (MutateCSharp.Schemata219.ReplaceBinExprOp_13(606L, compiledConstructorCount, MutateCSharp.Schemata219.ReplaceNumericConstant_4(602L, 0)))
                    {
                        var arg = dtor.CorrespondingFormals[MutateCSharp.Schemata219.ReplaceNumericConstant_4(611L, 0)];
                        if (!arg.IsGhost)
                        {
                            var DtorM = arg.HasName ? MutateCSharp.Schemata219.ReplaceStringConstant_1(615L, "_") + arg.CompileName : FieldName(arg, index);
                            //   TN dtor_QDtorM { get; }
                            interfaceTree.WriteLine($"{TypeName(arg.Type, wr, arg.tok)} {DestructorGetterName(arg, ctor, index)} {{ get; }}");

                            //   public TN dtor_QDtorM { get {
                            //       var d = this;         // for inductive datatypes
                            //       var d = this._Get();  // for co-inductive datatypes
                            //       if (d is DT_Ctor0) { return ((DT_Ctor0)d).DtorM; }
                            //       if (d is DT_Ctor1) { return ((DT_Ctor1)d).DtorM; }
                            //       ...
                            //       if (d is DT_Ctor(n-2)) { return ((DT_Ctor(n-2))d).DtorM; }
                            //       return ((DT_Ctor(n-1))d).DtorM;
                            //    }}
                            var wDtor =
                              wr.NewNamedBlock($"public {TypeName(arg.Type, wr, arg.tok)} {DestructorGetterName(arg, ctor, index)}");
                            var wGet = wDtor.NewBlock(MutateCSharp.Schemata219.ReplaceStringConstant_1(616L, "get"));
                            if (dt.IsRecordType)
                            {
                                if (dt is CoDatatypeDecl)
                                {
                                    wGet.WriteLine($"return this._Get().{IdProtect(DtorM)};");
                                }
                                else
                                {
                                    wGet.WriteLine($"return this.{IdProtect(DtorM)};");
                                }
                            }
                            else
                            {
                                if (dt is CoDatatypeDecl)
                                {
                                    wGet.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(617L, "var d = this._Get();"));
                                }
                                else
                                {
                                    wGet.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(618L, "var d = this;"));
                                }

                                var compiledConstructorsProcessed = MutateCSharp.Schemata219.ReplaceNumericConstant_4(619L, 0);
                                for (var i = MutateCSharp.Schemata219.ReplaceNumericConstant_4(623L, 0); MutateCSharp.Schemata219.ReplaceBinExprOp_6(627L, i, dtor.EnclosingCtors.Count); MutateCSharp.Schemata219.ReplacePostfixUnaryExprOp_7(632L, ref i))
                                {
                                    var ctor_i = dtor.EnclosingCtors[i];
                                    Contract.Assert(arg.CompileName == dtor.CorrespondingFormals[i].CompileName);
                                    if (ctor_i.IsGhost)
                                    {
                                        continue;
                                    }
                                    var type = $"{dt.GetCompileName(Options)}_{ctor_i.GetCompileName(Options)}{DtT_TypeArgs}";
                                    // TODO use pattern matching to replace cast.
                                    var returnTheValue = $"return (({type})d).{IdProtect(DtorM)};";
                                    if (MutateCSharp.Schemata219.ReplaceBinExprOp_6(646L, compiledConstructorsProcessed, MutateCSharp.Schemata219.ReplaceBinExprOp_22(637L, compiledConstructorCount, MutateCSharp.Schemata219.ReplaceNumericConstant_4(633L, 1))))
                                    {
                                        wGet.WriteLine($"if (d is {type}) {{ {returnTheValue} }}");
                                    }
                                    else
                                    {
                                        wGet.WriteLine(returnTheValue);
                                    }

                                    MutateCSharp.Schemata219.ReplacePostfixUnaryExprOp_7(651L, ref compiledConstructorsProcessed);
                                }
                            }

                            MutateCSharp.Schemata219.ReplacePostfixUnaryExprOp_7(652L, ref index);
                        }
                    }
                }
            }
        }

        private void CompileDatatypeInterfaceMembers(DatatypeDecl dt, ConcreteSyntaxTree interfaceTree)
        {
            foreach (var member in dt.Members)
            {
                if (MutateCSharp.Schemata219.ReplaceBinExprOp_10(653L, () => member.IsGhost, () => member.IsStatic)) { continue; }
                if (member is Function fn && !NeedsCustomReceiver(member))
                {
                    CreateFunction(IdName(fn), CombineAllTypeArguments(fn), fn.Ins, fn.ResultType, fn.tok, fn.IsStatic,
          MutateCSharp.Schemata219.ReplaceBooleanConstant_0(659L, false), fn, interfaceTree, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(660L, false), MutateCSharp.Schemata219.ReplaceBooleanConstant_0(661L, false));
                }
                else if (member is Method m && !NeedsCustomReceiver(member))
                {
                    CreateMethod(m, CombineAllTypeArguments(m), MutateCSharp.Schemata219.ReplaceBooleanConstant_0(662L, false), interfaceTree, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(663L, false), MutateCSharp.Schemata219.ReplaceBooleanConstant_0(664L, false));
                }
                else if (member is ConstantField c && !NeedsCustomReceiver(member))
                {
                    CreateFunctionOrGetter(c, IdName(c), dt, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(665L, false), MutateCSharp.Schemata219.ReplaceBooleanConstant_0(666L, false), MutateCSharp.Schemata219.ReplaceBooleanConstant_0(667L, false), new ClassWriter(this, interfaceTree, null));
                }
            }
        }

        string NeedsNew(TopLevelDeclWithMembers ty, string memberName)
        {
            Contract.Requires(ty != null);
            Contract.Requires(memberName != null);
            if (ty.Members.Exists(member => MutateCSharp.Schemata219.ReplaceBinExprOp_23(668L, member.Name, memberName)))
            {
                return MutateCSharp.Schemata219.ReplaceStringConstant_1(669L, "new ");
            }
            else
            {
                return "";
            }

            return default;
        }

        public override bool NeedsCustomReceiver(MemberDecl member)
        {
            //Dafny and C# have different ideas about variance, so not every datatype member can be in the interface.
            if (!member.IsStatic && member.EnclosingClass is DatatypeDecl d)
            {
                foreach (var tp in d.TypeArgs)
                {
                    bool InvalidType(Type ty) => MutateCSharp.Schemata219.ReplaceBinExprOp_10(677L, () => (MutateCSharp.Schemata219.ReplaceBinExprOp_14(671L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_16(670L, ty.AsTypeParameter, null), () => ty.AsTypeParameter.Equals(tp)))
          , () => ty.TypeArgs.Exists(InvalidType));
                    bool InvalidFormal(Formal f) => MutateCSharp.Schemata219.ReplaceBinExprOp_14(683L, () => !f.IsGhost, () => InvalidType(f.SyntacticType));
                    switch (tp.Variance)
                    {
                        //Can only be in output
                        case TypeParameter.TPVariance.Co:
                            if ((member is Function f && f.Ins.Exists(InvalidFormal))
                                || (member is Method m && m.Ins.Exists(InvalidFormal))
                                || NeedsTypeDescriptor(tp))
                            {
                                return true;
                            }
                            break;
                            break;
                        //Can only be in input
                        case TypeParameter.TPVariance.Contra:
                            if ((member is Function fn && InvalidType(fn.ResultType))
                                || (member is Method me && me.Outs.Exists(InvalidFormal))
                                || (member is ConstantField c && InvalidType(c.Type)))
                            {
                                return true;
                            }
                            break;
                            break;
                    }
                }
            }

            return base.NeedsCustomReceiver(member);
        }


        private void CompileDatatypeConstructors(DatatypeDecl dt, ConcreteSyntaxTree wrx)
        {
            Contract.Requires(dt != null);
            var nonGhostTypeArgs = SelectNonGhost(dt, dt.TypeArgs);
            string typeParams = TypeParameters(nonGhostTypeArgs);
            if (dt is CoDatatypeDecl)
            {
                // public class Dt__Lazy<T> : Dt<T> {
                //   public delegate _IDt<T> Computer();
                //   Computer c;
                //   _IDt<T> d;
                //   public Dt__Lazy(Computer c) { this.c = c; }
                //   public override _IDt<U> DowncastClone<U>(Func<T0, U0> converter0, ...) {
                //     if (this is _IDt<U> dt) { return dt; }
                //     return new Dt__Lazy<U>(() => c().DowncastClone<U>(converter0, ...));
                //   }
                //   public override _IDt<T> _Get() { if (c != null) { d = c(); c = null; } return d; }
                //   public override string ToString() { return _Get().ToString(); }
                // }
                var w = wrx.NewNamedBlock($"public class {dt.GetCompileName(Options)}__Lazy{typeParams} : {IdName(dt)}{typeParams}");
                w.WriteLine($"public {NeedsNew(dt, MutateCSharp.Schemata219.ReplaceStringConstant_1(689L, "Computer"))}delegate {DtTypeName(dt)} Computer();");
                w.WriteLine($"{NeedsNew(dt, MutateCSharp.Schemata219.ReplaceStringConstant_1(690L, "c"))}Computer c;");
                w.WriteLine($"{NeedsNew(dt, MutateCSharp.Schemata219.ReplaceStringConstant_1(691L, "d"))}{DtTypeName(dt)} d;");

                var typeDescriptorCount = EmitTypeDescriptorsForClass(dt.TypeArgs, dt, out _, out var wCtorParams, out var wBaseCallArguments, out _);
                var sep = MutateCSharp.Schemata219.ReplaceBinExprOp_15(696L, typeDescriptorCount, MutateCSharp.Schemata219.ReplaceNumericConstant_4(692L, 0)) ? MutateCSharp.Schemata219.ReplaceStringConstant_1(701L, ", ") : "";
                w.NewBlock($"public {dt.GetCompileName(Options)}__Lazy({wCtorParams}{sep}Computer c) : base({wBaseCallArguments})")
                  .WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(702L, "this.c = c;"));
                CompileDatatypeDowncastClone(dt, w, nonGhostTypeArgs, lazy: MutateCSharp.Schemata219.ReplaceBooleanConstant_0(703L, true));
                w.WriteLine($"public override {DtTypeName(dt)} _Get() {{ if (c != null) {{ d = c(); c = null; }} return d; }}");
                w.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(704L, "public override string ToString() { return _Get().ToString(); }"));
            }

            if (dt.IsRecordType)
            {
                // There is only one constructor, and it is populated by CompileDatatypeBase
                return;
            }

            int constructorIndex = MutateCSharp.Schemata219.ReplaceNumericConstant_4(705L, 0); // used to give each constructor a different name
            foreach (var ctor in dt.Ctors.Where(ctor => !ctor.IsGhost))
            {
                var wr = wrx.NewNamedBlock(
                  $"public class {DtCtorDeclarationName(ctor)}{TypeParameters(nonGhostTypeArgs)} : {IdName(dt)}{typeParams}");
                DatatypeFieldsAndConstructor(ctor, constructorIndex, wr);
                MutateCSharp.Schemata219.ReplacePostfixUnaryExprOp_7(709L, ref constructorIndex);
            }
        }

        void DatatypeFieldsAndConstructor(DatatypeCtor ctor, int constructorIndex, ConcreteSyntaxTree wr)
        {
            Contract.Requires(ctor != null);
            Contract.Requires(0 <= constructorIndex && constructorIndex < ctor.EnclosingDatatype.Ctors.Count);
            Contract.Requires(wr != null);

            var dt = ctor.EnclosingDatatype;
            // class Dt_Ctor<T> : Dt<T> {  // This line is to be added by the caller of DatatypeFieldsAndConstructor
            //   Fields;
            //   public Dt_Ctor(arguments) {  // for record types: Dt
            //     Fields = arguments;
            //   }
            //   public override _IDt<T> _Get() { return this; }  // for co-datatypes only
            //   public override _IDt<U> DowncastClone<U>(Func<T0, U0> converter0, ...) {
            //     if (this is _IDt<U> dt) {
            //       return dt;
            //     } else {
            //       return new Dt_Ctor<U>(converter0(_field0), ...);
            //     }
            //   }
            //   public override bool Equals(object other) {
            //     var oth = other as Dt_Ctor;  // for record types: Dt
            //     return oth != null && equals(_field0, oth._field0) && ... ;
            //   }
            //   public override int GetHashCode() {
            //     return base.GetHashCode();  // surely this can be improved
            //   }
            //   public override string ToString() {  // only for inductive datatypes
            //     // ...
            //   }
            // }

            var i = MutateCSharp.Schemata219.ReplaceNumericConstant_4(710L, 0);
            foreach (Formal arg in ctor.Formals)
            {
                if (!arg.IsGhost)
                {
                    wr.WriteLine($"public readonly {TypeName(arg.Type, wr, arg.tok)} {FieldName(arg, i)};");
                    MutateCSharp.Schemata219.ReplacePostfixUnaryExprOp_7(714L, ref i);
                }
            }

            var typeDescriptorCount = EmitTypeDescriptorsForClass(dt.TypeArgs, dt, out var wTypeFields, out var wCtorParams, out var wBaseCallArguments, out var wCtorBody);
            if (ctor.EnclosingDatatype.IsRecordType)
            {
                wr.Append(wTypeFields);
            }
            var wBaseCall = new ConcreteSyntaxTree();
            wr.Format($"public {DtCtorDeclarationName(ctor)}({wCtorParams}){wBaseCall}").NewBlock().Append(wCtorBody);
            if (!ctor.EnclosingDatatype.IsRecordType)
            {
                wBaseCall.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(715L, " : base")).ForkInParens().Append(wBaseCallArguments);
            }
            WriteFormals(MutateCSharp.Schemata219.ReplaceBinExprOp_15(720L, typeDescriptorCount, MutateCSharp.Schemata219.ReplaceNumericConstant_4(716L, 0)) ? MutateCSharp.Schemata219.ReplaceStringConstant_1(725L, ", ") : "", ctor.Formals, wCtorParams);
            {
                var w = wCtorBody;
                i = MutateCSharp.Schemata219.ReplaceNumericConstant_4(726L, 0);
                foreach (Formal arg in ctor.Formals)
                {
                    if (!arg.IsGhost)
                    {
                        w.WriteLine($"this.{FieldName(arg, i)} = {FormalName(arg, i)};");
                        MutateCSharp.Schemata219.ReplacePostfixUnaryExprOp_7(730L, ref i);
                    }
                }
            }

            var nonGhostTypeArgs = SelectNonGhost(dt, dt.TypeArgs);

            if (dt is CoDatatypeDecl)
            {
                wr.WriteLine($"public override {DtTypeName(dt)} _Get() {{ return this; }}");
            }

            CompileDatatypeDowncastClone(dt, wr, nonGhostTypeArgs, ctor: ctor);

            // Equals method
            {
                var w = wr.NewBlock(MutateCSharp.Schemata219.ReplaceStringConstant_1(731L, "public override bool Equals(object other)"));
                w.WriteLine($"var oth = other as {DtCtorName(ctor)}{TypeParameters(nonGhostTypeArgs)};");
                w.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(732L, "return oth != null"));
                i = MutateCSharp.Schemata219.ReplaceNumericConstant_4(733L, 0);
                foreach (var arg in ctor.Formals)
                {
                    if (!arg.IsGhost)
                    {
                        var nm = FieldName(arg, i);
                        w.Write(IsDirectlyComparable(DatatypeWrapperEraser.SimplifyType(Options, arg.Type))
                          ? $" && this.{nm} == oth.{nm}"
                          : $" && object.Equals(this.{nm}, oth.{nm})");
                        MutateCSharp.Schemata219.ReplacePostfixUnaryExprOp_7(737L, ref i);
                    }
                }

                w.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(738L, ";"));
            }

            // GetHashCode method (Uses the djb2 algorithm)
            {
                var w = wr.NewBlock(MutateCSharp.Schemata219.ReplaceStringConstant_1(739L, "public override int GetHashCode()"));
                w.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(740L, "ulong hash = 5381;"));
                w.WriteLine($"hash = ((hash << 5) + hash) + {constructorIndex};");
                i = MutateCSharp.Schemata219.ReplaceNumericConstant_4(741L, 0);
                foreach (Formal arg in ctor.Formals)
                {
                    if (!arg.IsGhost)
                    {
                        string nm = FieldName(arg, i);
                        w.WriteLine($"hash = ((hash << 5) + hash) + ((ulong){DafnyHelpersClass}.GetHashCode(this.{nm}));");
                        MutateCSharp.Schemata219.ReplacePostfixUnaryExprOp_7(745L, ref i);
                    }
                }

                w.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(746L, "return (int) hash;"));
            }

            {
                var w = wr.NewBlock(MutateCSharp.Schemata219.ReplaceStringConstant_1(747L, "public override string ToString()"));
                string nm;
                if (dt is TupleTypeDecl)
                {
                    nm = "";
                }
                else
                {
                    nm = (dt.EnclosingModuleDefinition.TryToAvoidName ? "" : dt.EnclosingModuleDefinition.Name + MutateCSharp.Schemata219.ReplaceStringConstant_1(748L, ".")) + dt.Name + MutateCSharp.Schemata219.ReplaceStringConstant_1(749L, ".") + ctor.Name;
                }

                switch (dt)
                {
                    case TupleTypeDecl tupleDt when ctor.Formals.Count == 0:
                        // here we want parentheses and no name
                        w.WriteLine("return \"()\";");
                        break;
                        break;
                    case CoDatatypeDecl _:
                        w.WriteLine($"return \"{nm}\";");
                        break;
                        break;
                    default:
                        var tempVar = GenVarName("s", ctor.Formals);
                        w.WriteLine($"string {tempVar} = \"{nm}\";");
                        if (ctor.Formals.Count != 0)
                        {
                            w.WriteLine($"{tempVar} += \"(\";");
                            i = 0;
                            foreach (var arg in ctor.Formals)
                            {
                                if (!arg.IsGhost)
                                {
                                    if (i != 0)
                                    {
                                        w.WriteLine($"{tempVar} += \", \";");
                                    }

                                    if (arg.Type.IsStringType && UnicodeCharEnabled)
                                    {
                                        w.WriteLine($"{tempVar} += this.{FieldName(arg, i)}.ToVerbatimString(true);");
                                    }
                                    else
                                    {
                                        w.WriteLine($"{tempVar} += {DafnyHelpersClass}.ToString(this.{FieldName(arg, i)});");
                                    }

                                    i++;
                                }
                            }

                            w.WriteLine($"{tempVar} += \")\";");
                        }

                        w.WriteLine($"return {tempVar};");
                        break;
                        break;
                }
            }
        }

        private string FieldName(Formal formal, int i)
        {
            Contract.Requires(formal != null);
            Contract.Ensures(Contract.Result<string>() != null);

            return IdProtect(MutateCSharp.Schemata219.ReplaceStringConstant_1(750L, "_") + (formal.HasName ? formal.CompileName : MutateCSharp.Schemata219.ReplaceStringConstant_1(751L, "a") + i));
        }

        /// <summary>
        /// Returns a protected name.
        /// </summary>
        string DtCtorDeclarationName(DatatypeCtor ctor)
        {
            Contract.Requires(ctor != null);
            Contract.Ensures(Contract.Result<string>() != null);

            var dt = ctor.EnclosingDatatype;
            return dt.IsRecordType ? IdName(dt) : dt.GetCompileName(Options) + MutateCSharp.Schemata219.ReplaceStringConstant_1(752L, "_") + ctor.GetCompileName(Options);
        }

        /// <summary>
        /// Returns a protected name with type parameters.
        /// </summary>
        string DtCtorName(DatatypeCtor ctor, List<Type> typeArgs, ConcreteSyntaxTree wr)
        {
            Contract.Requires(ctor != null);
            Contract.Ensures(Contract.Result<string>() != null);

            var s = DtCtorName(ctor);
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_14(763L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_24(753L, typeArgs, null), () => MutateCSharp.Schemata219.ReplaceBinExprOp_13(758L, typeArgs.Count, MutateCSharp.Schemata219.ReplaceNumericConstant_4(754L, 0))))
            {
                s += $"<{TypeNames(typeArgs, wr, ctor.tok)}>";
            }

            return s;
        }

        /// <summary>
        /// Returns a protected name. (No type parameters.)
        /// </summary>
        string DtCtorName(DatatypeCtor ctor)
        {
            Contract.Requires(ctor != null);
            Contract.Ensures(Contract.Result<string>() != null);

            var dt = ctor.EnclosingDatatype;
            var dtName = IdName(dt);
            if (!dt.EnclosingModuleDefinition.TryToAvoidName)
            {
                dtName = IdProtectModule(dt.EnclosingModuleDefinition.GetCompileName(Options)) + MutateCSharp.Schemata219.ReplaceStringConstant_1(769L, ".") + dtName;
            }

            return dt.IsRecordType ? dtName : dtName + MutateCSharp.Schemata219.ReplaceStringConstant_1(770L, "_") + ctor.GetCompileName(Options);
        }

        string DtCreateName(DatatypeCtor ctor)
        {
            Contract.Assert(!ctor.IsGhost); // there should never be an occasion to ask for a ghost constructor
            if (ctor.EnclosingDatatype.IsRecordType)
            {
                return MutateCSharp.Schemata219.ReplaceStringConstant_1(771L, "create");
            }
            else
            {
                return MutateCSharp.Schemata219.ReplaceStringConstant_1(772L, "create_") + ctor.GetCompileName(Options);
            }

            return default;
        }

        protected override IClassWriter DeclareNewtype(NewtypeDecl nt, ConcreteSyntaxTree wr)
        {
            var cw = (ClassWriter)CreateClass(IdProtect(nt.EnclosingModuleDefinition.GetCompileName(Options)), IdName(nt), nt, wr);
            var w = cw.StaticMemberWriter;
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_25(773L, nt.NativeType, null))
            {
                var wEnum = w.NewBlock($"public static System.Collections.Generic.IEnumerable<{GetNativeTypeName(nt.NativeType)}> IntegerRange(BigInteger lo, BigInteger hi)");
                wEnum.WriteLine($"for (var j = lo; j < hi; j++) {{ yield return ({GetNativeTypeName(nt.NativeType)})j; }}");
            }
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_26(774L, nt.WitnessKind, SubsetTypeDecl.WKind.Compiled))
            {
                var wStmts = w.Fork();
                var witness = Expr(nt.Witness, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(775L, false), wStmts).ToString();
                string typeName;
                if (MutateCSharp.Schemata219.ReplaceBinExprOp_27(776L, nt.NativeType, null))
                {
                    typeName = TypeName(nt.BaseType, cw.StaticMemberWriter, nt.tok);
                }
                else
                {
                    typeName = GetNativeTypeName(nt.NativeType);
                    witness = $"({typeName})({witness})";
                }
                DeclareField(MutateCSharp.Schemata219.ReplaceStringConstant_1(777L, "Witness"), MutateCSharp.Schemata219.ReplaceBooleanConstant_0(778L, true), MutateCSharp.Schemata219.ReplaceBooleanConstant_0(779L, true), MutateCSharp.Schemata219.ReplaceBooleanConstant_0(780L, true), typeName, witness, cw);
            }
            EmitTypeDescriptorMethod(nt, w);
            GenerateIsMethod(nt, cw.StaticMemberWriter);

            if (MutateCSharp.Schemata219.ReplaceBinExprOp_13(785L, nt.ParentTraits.Count, MutateCSharp.Schemata219.ReplaceNumericConstant_4(781L, 0)))
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

                wr.Write($"public static bool {IsMethodName}(");

                var count = EmitTypeDescriptorsForClass(declWithConstraints.TypeArgs, (TopLevelDecl)declWithConstraints,
                  out _, out var wCtorParams, out _, out _);
                if (MutateCSharp.Schemata219.ReplaceBinExprOp_13(794L, count, MutateCSharp.Schemata219.ReplaceNumericConstant_4(790L, 0)))
                {
                    wr.Write($"{wCtorParams}, ");
                }

                var sourceFormal = new Formal(declWithConstraints.tok, MutateCSharp.Schemata219.ReplaceStringConstant_1(799L, "_source"), type, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(800L, true), MutateCSharp.Schemata219.ReplaceBooleanConstant_0(801L, false), null);
                var typeName = TypeName(type, wr, declWithConstraints.tok);
                var wrBody = wr.NewBlock($"{typeName} {IdName(sourceFormal)})");
                GenerateIsMethodBody(declWithConstraints, sourceFormal, wrBody);
            }
        }

        void DeclareBoxedNewtype(NewtypeDecl nt, ConcreteSyntaxTree wr)
        {
            // instance field:  public TargetRepresentation _value;
            var targetTypeName = MutateCSharp.Schemata219.ReplaceBinExprOp_27(802L, nt.NativeType, null) ? TypeName(nt.BaseType, wr, nt.tok) : GetNativeTypeName(nt.NativeType);
            wr.WriteLine($"public {targetTypeName} _value;");

            // constructor:
            // public NewType(TargetRepresentation value) {
            //   _value = value;
            // }
            var wBody = wr.NewNamedBlock($"public {IdName(nt)}({targetTypeName} value)");
            wBody.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(803L, "_value = value;"));

            // public override string ToString() {
            //   return _value.ToString();
            // }
            wBody = wr.NewNamedBlock(MutateCSharp.Schemata219.ReplaceStringConstant_1(804L, "public override string ToString()"));
            wBody.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(805L, "return _value.ToString();"));
        }

        protected override void DeclareSubsetType(SubsetTypeDecl sst, ConcreteSyntaxTree wr)
        {
            var cw = (ClassWriter)CreateClass(IdProtect(sst.EnclosingModuleDefinition.GetCompileName(Options)), IdName(sst), sst, wr);
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_26(806L, sst.WitnessKind, SubsetTypeDecl.WKind.Compiled))
            {
                var sw = new ConcreteSyntaxTree(cw.InstanceMemberWriter.RelativeIndentLevel);
                var wStmts = cw.InstanceMemberWriter.Fork();
                sw.Append(Expr(sst.Witness, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(807L, false), wStmts));
                var witness = sw.ToString();
                var typeName = TypeName(sst.Rhs, cw.StaticMemberWriter, sst.tok);
                if (MutateCSharp.Schemata219.ReplaceBinExprOp_9(812L, sst.TypeArgs.Count, MutateCSharp.Schemata219.ReplaceNumericConstant_4(808L, 0)))
                {
                    DeclareField(MutateCSharp.Schemata219.ReplaceStringConstant_1(817L, "Witness"), MutateCSharp.Schemata219.ReplaceBooleanConstant_0(818L, false), MutateCSharp.Schemata219.ReplaceBooleanConstant_0(819L, true), MutateCSharp.Schemata219.ReplaceBooleanConstant_0(820L, true), typeName, witness, cw);
                    witness = MutateCSharp.Schemata219.ReplaceStringConstant_1(821L, "Witness");
                }
                var w = cw.StaticMemberWriter.NewBlock($"public static {typeName} Default()");
                w.WriteLine($"return {witness};");
            }
            EmitTypeDescriptorMethod(sst, cw.StaticMemberWriter);
            GenerateIsMethod(sst, cw.StaticMemberWriter);
        }

        protected override void GetNativeInfo(NativeType.Selection sel, out string name, out string literalSuffix, out bool needsCastAfterArithmetic)
        {
            switch (sel)
            {
                case NativeType.Selection.Byte:
                    name = "byte";
                    literalSuffix = "";
                    needsCastAfterArithmetic = true;
                    break;
                    break;
                case NativeType.Selection.SByte:
                    name = "sbyte";
                    literalSuffix = "";
                    needsCastAfterArithmetic = true;
                    break;
                    break;
                case NativeType.Selection.UShort:
                    name = "ushort";
                    literalSuffix = "";
                    needsCastAfterArithmetic = true;
                    break;
                    break;
                case NativeType.Selection.Short:
                    name = "short";
                    literalSuffix = "";
                    needsCastAfterArithmetic = true;
                    break;
                    break;
                case NativeType.Selection.UInt:
                    name = "uint";
                    literalSuffix = "U";
                    needsCastAfterArithmetic = false;
                    break;
                    break;
                case NativeType.Selection.Int:
                    name = "int";
                    literalSuffix = "";
                    needsCastAfterArithmetic = false;
                    break;
                    break;
                case NativeType.Selection.Number:
                    name = "number";
                    literalSuffix = "";
                    needsCastAfterArithmetic = false;
                    break;
                    break;
                case NativeType.Selection.ULong:
                    name = "ulong";
                    literalSuffix = "UL";
                    needsCastAfterArithmetic = false;
                    break;
                    break;
                case NativeType.Selection.Long:
                    name = "long";
                    literalSuffix = "L";
                    needsCastAfterArithmetic = false;
                    break;
                    break;
                default:
                    Contract.Assert(false); // unexpected native type
                    throw new cce.UnreachableException(); // to please the compiler
                    break;
            }
        }

        public class ClassWriter : IClassWriter
        {
            public readonly CsharpCodeGenerator CodeGenerator;
            public readonly ConcreteSyntaxTree InstanceMemberWriter;
            public readonly ConcreteSyntaxTree StaticMemberWriter;
            public readonly ConcreteSyntaxTree CtorBodyWriter;
            private readonly CsharpSynthesizer csharpSynthesizer;

            public ClassWriter(CsharpCodeGenerator codeGenerator, ConcreteSyntaxTree instanceMemberWriter, ConcreteSyntaxTree/*?*/ ctorBodyWriter, ConcreteSyntaxTree/*?*/ staticMemberWriter = null)
            {
                Contract.Requires(codeGenerator != null);
                Contract.Requires(instanceMemberWriter != null);
                this.CodeGenerator = codeGenerator;
                this.InstanceMemberWriter = instanceMemberWriter;
                this.CtorBodyWriter = ctorBodyWriter;
                this.StaticMemberWriter = staticMemberWriter ?? instanceMemberWriter;
                this.csharpSynthesizer = new CsharpSynthesizer(CodeGenerator, ErrorWriter());
            }

            public ConcreteSyntaxTree Writer(bool isStatic, bool createBody, MemberDecl/*?*/ member)
            {
                if (createBody)
                {
                    if (MutateCSharp.Schemata219.ReplaceBinExprOp_10(828L, () => isStatic, () => (MutateCSharp.Schemata219.ReplaceBinExprOp_14(822L, () => member?.EnclosingClass is TraitDecl, () => CodeGenerator.NeedsCustomReceiver(member)))))
                    {
                        return StaticMemberWriter;
                    }
                }

                return InstanceMemberWriter;
            }

            public ConcreteSyntaxTree /*?*/ CreateMethod(Method m, List<TypeArgumentInstantiation> typeArgs, bool createBody, bool forBodyInheritance, bool lookasideBody)
            {
                return CodeGenerator.CreateMethod(m, typeArgs, createBody, Writer(m.IsStatic, createBody, m), forBodyInheritance, lookasideBody);
            }

            public ConcreteSyntaxTree SynthesizeMethod(Method method, List<TypeArgumentInstantiation> typeArgs, bool createBody, bool forBodyInheritance,
              bool lookasideBody)
            {
                return csharpSynthesizer.SynthesizeMethod(method, typeArgs, createBody, Writer(method.IsStatic, createBody, method), forBodyInheritance, lookasideBody);
            }

            public ConcreteSyntaxTree /*?*/ CreateFunction(string name, List<TypeArgumentInstantiation> typeArgs, List<Formal> formals, Type resultType, IToken tok, bool isStatic, bool createBody, MemberDecl member, bool forBodyInheritance, bool lookasideBody)
            {
                return CodeGenerator.CreateFunction(name, typeArgs, formals, resultType, tok, isStatic, createBody, member, Writer(isStatic, createBody, member), forBodyInheritance, lookasideBody);
            }

            public ConcreteSyntaxTree /*?*/ CreateGetter(string name, TopLevelDecl enclosingDecl, Type resultType, IToken tok, bool isStatic, bool isConst, bool createBody, MemberDecl /*?*/ member, bool forBodyInheritance)
            {
                return CodeGenerator.CreateGetter(name, resultType, tok, isStatic, createBody, Writer(isStatic, createBody, member));
            }

            public ConcreteSyntaxTree /*?*/ CreateGetterSetter(string name, Type resultType, IToken tok, bool createBody, MemberDecl /*?*/ member, out ConcreteSyntaxTree setterWriter, bool forBodyInheritance)
            {
                return CodeGenerator.CreateGetterSetter(name, resultType, tok, createBody, out setterWriter, Writer(MutateCSharp.Schemata219.ReplaceBooleanConstant_0(834L, false), createBody, member));
            }

            public void DeclareField(string name, TopLevelDecl enclosingDecl, bool isStatic, bool isConst, Type type, IToken tok, string rhs, Field field)
            {
                var typeName = CodeGenerator.TypeName(type, this.StaticMemberWriter, tok);
                CodeGenerator.DeclareField(name, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(835L, true), isStatic, isConst, typeName, rhs, this);
            }

            public void InitializeField(Field field, Type instantiatedFieldType, TopLevelDeclWithMembers enclosingClass)
            {
                throw new cce.UnreachableException(); // InitializeField should be called only for those compilers that set ClassesRedeclareInheritedFields to false.
            }

            public ConcreteSyntaxTree /*?*/ ErrorWriter() => InstanceMemberWriter;

            public void Finish() { }
        }

        protected ConcreteSyntaxTree/*?*/ CreateMethod(Method m, List<TypeArgumentInstantiation> typeArgs, bool createBody, ConcreteSyntaxTree wr, bool forBodyInheritance, bool lookasideBody)
        {
            var customReceiver = MutateCSharp.Schemata219.ReplaceBinExprOp_14(842L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_14(836L, () => createBody, () => !forBodyInheritance), () => NeedsCustomReceiver(m));
            var keywords = Keywords(createBody, MutateCSharp.Schemata219.ReplaceBinExprOp_10(848L, () => m.IsStatic, () => customReceiver), MutateCSharp.Schemata219.ReplaceBooleanConstant_0(854L, false));
            var returnType = GetTargetReturnTypeReplacement(m, wr);
            AddTestCheckerIfNeeded(m.Name, m, wr);
            var typeParameters = TypeParameters(TypeArgumentInstantiation.ToFormals(ForTypeParameters(typeArgs, m, lookasideBody)));
            var parameters = GetMethodParameters(m, typeArgs, lookasideBody, customReceiver, returnType);

            if (MutateCSharp.Schemata219.ReplaceBinExprOp_14(855L, () => !createBody, () => m is Constructor)) { return null; }

            wr.Format($"{keywords}{returnType} {IdName(m)}{typeParameters}({parameters})");

            if (!createBody)
            {
                wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(861L, ";"));
                return null;
            }

            var block = wr.NewBlock(open: BlockStyle.NewlineBrace);
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_14(864L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_28(863L, returnType, MutateCSharp.Schemata219.ReplaceStringConstant_1(862L, "void")), () => !forBodyInheritance))
            {
                var beforeReturnBlock = block.Fork();
                EmitReturn(m.Outs, block);
                return beforeReturnBlock;
            }

            return block;
        }

        internal string Keywords(bool isPublic = false, bool isStatic = false, bool isExtern = false)
        {
            return (isPublic ? MutateCSharp.Schemata219.ReplaceStringConstant_1(870L, "public ") : "") + (isStatic ? MutateCSharp.Schemata219.ReplaceStringConstant_1(871L, "static ") : "") + (isExtern ? MutateCSharp.Schemata219.ReplaceStringConstant_1(872L, "extern ") : "") + (MutateCSharp.Schemata219.ReplaceBinExprOp_14(879L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_14(873L, () => Synthesize, () => !isStatic), () => isPublic) ? MutateCSharp.Schemata219.ReplaceStringConstant_1(885L, "virtual ") : "");
        }

        internal ConcreteSyntaxTree GetMethodParameters(Method m, List<TypeArgumentInstantiation> typeArgs, bool lookasideBody, bool customReceiver, string returnType)
        {
            var parameters = GetFunctionParameters(m.Ins, m, typeArgs, lookasideBody, customReceiver);
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_23(887L, returnType, MutateCSharp.Schemata219.ReplaceStringConstant_1(886L, "void")))
            {
                WriteFormals(parameters.Nodes.Any() ? MutateCSharp.Schemata219.ReplaceStringConstant_1(888L, ", ") : "", m.Outs, parameters);
            }
            return parameters;
        }

        private ConcreteSyntaxTree GetFunctionParameters(List<Formal> formals, MemberDecl m, List<TypeArgumentInstantiation> typeArgs, bool lookasideBody, bool customReceiver)
        {
            var parameters = new ConcreteSyntaxTree();
            var sep = "";
            WriteRuntimeTypeDescriptorsFormals(ForTypeDescriptors(typeArgs, m.EnclosingClass, m, lookasideBody), parameters, ref sep,
              tp => $"{DafnyTypeDescriptor}<{tp.GetCompileName(Options)}> {FormatTypeDescriptorVariable(tp)}");
            if (customReceiver)
            {
                var nt = m.EnclosingClass;
                var receiverType = UserDefinedType.FromTopLevelDecl(m.tok, nt);
                DeclareFormal(sep, MutateCSharp.Schemata219.ReplaceStringConstant_1(889L, "_this"), receiverType, m.tok, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(890L, true), parameters);
                sep = MutateCSharp.Schemata219.ReplaceStringConstant_1(891L, ", ");
            }

            WriteFormals(sep, formals, parameters);
            return parameters;
        }

        internal string GetTargetReturnTypeReplacement(Method m, ConcreteSyntaxTree wr)
        {
            string/*?*/ targetReturnTypeReplacement = null;
            foreach (var p in m.Outs)
            {
                if (!p.IsGhost)
                {
                    if (targetReturnTypeReplacement == null)
                    {
                        targetReturnTypeReplacement = TypeName(p.Type, wr, p.tok);
                    }
                    else
                    {
                        // there's more than one out-parameter, so bail
                        targetReturnTypeReplacement = null;
                        break;
                    }
                }
            }

            targetReturnTypeReplacement ??= MutateCSharp.Schemata219.ReplaceStringConstant_1(892L, "void");
            return targetReturnTypeReplacement;
        }

        protected ConcreteSyntaxTree/*?*/ CreateFunction(string name, List<TypeArgumentInstantiation> typeArgs, List<Formal> formals, Type resultType, IToken tok, bool isStatic, bool createBody, MemberDecl member, ConcreteSyntaxTree wr, bool forBodyInheritance, bool lookasideBody)
        {

            var customReceiver = MutateCSharp.Schemata219.ReplaceBinExprOp_14(899L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_14(893L, () => createBody, () => !forBodyInheritance), () => NeedsCustomReceiver(member));

            AddTestCheckerIfNeeded(name, member, wr);
            wr.Write(Keywords(createBody, MutateCSharp.Schemata219.ReplaceBinExprOp_10(905L, () => isStatic, () => customReceiver), MutateCSharp.Schemata219.ReplaceBooleanConstant_0(911L, false)));

            var typeParameters = TypeParameters(TypeArgumentInstantiation.ToFormals(ForTypeParameters(typeArgs, member, lookasideBody)));
            var parameters = GetFunctionParameters(formals, member, typeArgs, lookasideBody, customReceiver);

            wr.Write($"{TypeName(resultType, wr, tok)} {name}{typeParameters}({parameters})");
            if (!createBody)
            {
                wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(912L, ";"));
                return null;
            }

            return wr.NewBlock(open: MutateCSharp.Schemata219.ReplaceBinExprOp_15(917L, formals.Count, MutateCSharp.Schemata219.ReplaceNumericConstant_4(913L, 1)) ? BlockStyle.NewlineBrace : BlockStyle.SpaceBrace);
        }

        protected ConcreteSyntaxTree/*?*/ CreateGetter(string name, Type resultType, IToken tok, bool isStatic, bool createBody, ConcreteSyntaxTree wr)
        {
            ConcreteSyntaxTree/*?*/ result = null;
            var body = createBody ? Block(out result, close: BlockStyle.Brace) : new ConcreteSyntaxTree().Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(922L, ";"));
            wr.FormatLine($"{Keywords(createBody, isStatic)}{TypeName(resultType, wr, tok)} {name} {{ get{body} }}");
            return result;
        }

        protected ConcreteSyntaxTree/*?*/ CreateGetterSetter(string name, Type resultType, IToken tok, bool createBody, out ConcreteSyntaxTree setterWriter, ConcreteSyntaxTree wr)
        {
            wr.Write($"{Keywords(createBody)}{TypeName(resultType, wr, tok)} {name}");
            if (createBody)
            {
                var w = wr.NewBlock();
                var wGet = w.NewBlock(MutateCSharp.Schemata219.ReplaceStringConstant_1(923L, "get"));
                var wSet = w.NewBlock(MutateCSharp.Schemata219.ReplaceStringConstant_1(924L, "set"));
                setterWriter = wSet;
                return wGet;
            }
            else
            {
                wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(925L, " { get; set; }"));
                setterWriter = null;
                return null;
            }

            return default;
        }

        protected override ConcreteSyntaxTree EmitTailCallStructure(MemberDecl member, ConcreteSyntaxTree wr)
        {
            Contract.Assume(member is Method { IsTailRecursive: true } or Function { IsTailRecursive: true }); // precondition
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_14(926L, () => !member.IsStatic, () => !NeedsCustomReceiver(member)))
            {
                var receiverType = member.EnclosingClass is DatatypeDecl dt ? DtTypeName(dt) : MutateCSharp.Schemata219.ReplaceStringConstant_1(932L, "var");
                wr.WriteLine($"{receiverType} _this = this;");
            }
            wr.Fork(MutateCSharp.Schemata219.ReplaceNumericConstant_4(933L, -1)).WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(937L, "TAIL_CALL_START: ;"));
            return wr;
        }

        protected override void EmitJumpToTailCallStart(ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(938L, "goto TAIL_CALL_START;"));
        }

        internal override string TypeName(Type type, ConcreteSyntaxTree wr, IToken tok, MemberDecl/*?*/ member = null)
        {
            Contract.Ensures(Contract.Result<string>() != null);
            Contract.Assume(type != null);  // precondition; this ought to be declared as a Requires in the superclass

            var xType = DatatypeWrapperEraser.SimplifyType(Options, type);
            if (xType is BoolType)
            {
                return MutateCSharp.Schemata219.ReplaceStringConstant_1(939L, "bool");
            }
            else if (xType is CharType)
            {
                return CharTypeName;
            }
            else if (MutateCSharp.Schemata219.ReplaceBinExprOp_10(940L, () => xType is IntType, () => xType is BigOrdinalType))
            {
                return MutateCSharp.Schemata219.ReplaceStringConstant_1(946L, "BigInteger");
            }
            else if (xType is RealType)
            {
                return MutateCSharp.Schemata219.ReplaceStringConstant_1(947L, "Dafny.BigRational");
            }
            else if (xType is BitvectorType)
            {
                var t = (BitvectorType)xType;
                return MutateCSharp.Schemata219.ReplaceBinExprOp_25(948L, t.NativeType, null) ? GetNativeTypeName(t.NativeType) : MutateCSharp.Schemata219.ReplaceStringConstant_1(949L, "BigInteger");
            }
            else if (MutateCSharp.Schemata219.ReplaceBinExprOp_14(952L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_29(950L, xType.AsNewtype, null), () => MutateCSharp.Schemata219.ReplaceBinExprOp_30(951L, member, null)))
            {  // when member is given, use UserDefinedType case below
                var nativeType = xType.AsNewtype.NativeType;
                if (MutateCSharp.Schemata219.ReplaceBinExprOp_25(958L, nativeType, null))
                {
                    return GetNativeTypeName(nativeType);
                }
                return TypeName(xType.AsNewtype.BaseType, wr, tok);
            }
            else if (xType.IsObjectQ)
            {
                return MutateCSharp.Schemata219.ReplaceStringConstant_1(959L, "object");
            }
            else if (xType.IsArrayType)
            {
                ArrayClassDecl at = xType.AsArrayType;
                Contract.Assert(at != null);  // follows from type.IsArrayType
                Type elType = UserDefinedType.ArrayElementType(xType);
                TypeName_SplitArrayName(elType, wr, tok, out string typeNameSansBrackets, out string brackets);
                return typeNameSansBrackets + TypeNameArrayBrackets(at.Dims) + brackets;
            }
            else if (xType is UserDefinedType udt)
            {
                if (udt.ResolvedClass is TypeParameter tp)
                {
                    if (MutateCSharp.Schemata219.ReplaceBinExprOp_31(960L, thisContext, null) && thisContext.ParentFormalTypeParametersToActuals.TryGetValue(tp, out var instantiatedTypeParameter))
                    {
                        return TypeName(instantiatedTypeParameter, wr, tok, member);
                    }
                }
                var s = FullTypeName(udt, member);
                var cl = udt.ResolvedClass;
                return TypeName_UDT(s, udt, wr, udt.tok);
            }
            else if (xType is SetType)
            {
                Type argType = ((SetType)xType).Arg;
                return DafnyISet + MutateCSharp.Schemata219.ReplaceStringConstant_1(961L, "<") + TypeName(argType, wr, tok) + MutateCSharp.Schemata219.ReplaceStringConstant_1(962L, ">");
            }
            else if (xType is SeqType)
            {
                Type argType = ((SeqType)xType).Arg;
                return DafnyISeq + MutateCSharp.Schemata219.ReplaceStringConstant_1(963L, "<") + TypeName(argType, wr, tok) + MutateCSharp.Schemata219.ReplaceStringConstant_1(964L, ">");
            }
            else if (xType is MultiSetType)
            {
                Type argType = ((MultiSetType)xType).Arg;
                return DafnyIMultiset + MutateCSharp.Schemata219.ReplaceStringConstant_1(965L, "<") + TypeName(argType, wr, tok) + MutateCSharp.Schemata219.ReplaceStringConstant_1(966L, ">");
            }
            else if (xType is MapType)
            {
                Type domType = ((MapType)xType).Domain;
                Type ranType = ((MapType)xType).Range;
                return DafnyIMap + MutateCSharp.Schemata219.ReplaceStringConstant_1(967L, "<") + TypeName(domType, wr, tok) + MutateCSharp.Schemata219.ReplaceStringConstant_1(968L, ",") + TypeName(ranType, wr, tok) + MutateCSharp.Schemata219.ReplaceStringConstant_1(969L, ">");
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected type
            }

            return default;
        }

        // To improve readability
        private bool CharIsRune => UnicodeCharEnabled;
        private string CharTypeName => UnicodeCharEnabled ? MutateCSharp.Schemata219.ReplaceStringConstant_1(970L, "Dafny.Rune") : MutateCSharp.Schemata219.ReplaceStringConstant_1(971L, "char");
        private string CharTypeDescriptorName => DafnyHelpersClass + (UnicodeCharEnabled ? MutateCSharp.Schemata219.ReplaceStringConstant_1(972L, ".RUNE") : MutateCSharp.Schemata219.ReplaceStringConstant_1(973L, ".CHAR"));

        private void ConvertFromChar(Expression e, ConcreteSyntaxTree wr, bool inLetExprBody, ConcreteSyntaxTree wStmts)
        {
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_14(974L, () => e.Type.IsCharType, () => UnicodeCharEnabled))
            {
                wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(980L, "("));
                TrParenExpr(e, wr, inLetExprBody, wStmts);
                wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(981L, ".Value)"));
            }
            else
            {
                TrParenExpr(e, wr, inLetExprBody, wStmts);
            }
        }

        public string TypeHelperName(Type type, ConcreteSyntaxTree wr, IToken tok, Type/*?*/ otherType = null)
        {
            var xType = type.NormalizeToAncestorType();
            if (xType is SeqType seqType)
            {
                return MutateCSharp.Schemata219.ReplaceStringConstant_1(982L, "Dafny.Sequence") + MutateCSharp.Schemata219.ReplaceStringConstant_1(983L, "<") + CommonTypeName(seqType.Arg, otherType?.AsSeqType?.Arg, wr, tok) + MutateCSharp.Schemata219.ReplaceStringConstant_1(984L, ">");
            }
            else if (xType is SetType setType)
            {
                return $"{DafnySetClass}<{CommonTypeName(setType.Arg, otherType?.AsSetType?.Arg, wr, tok)}>";
            }
            else if (xType is MultiSetType msType)
            {
                return $"{DafnyMultiSetClass}<{CommonTypeName(msType.Arg, otherType?.AsMultiSetType?.Arg, wr, tok)}>";
            }
            else if (xType is MapType mapType)
            {
                var domainType = CommonTypeName(mapType.Domain, otherType?.AsMapType?.Domain, wr, tok);
                var rangeType = CommonTypeName(mapType.Range, otherType?.AsMapType?.Range, wr, tok);
                return $"{DafnyMapClass}<{domainType}, {rangeType}>";
            }
            else
            {
                return TypeName(type, wr, tok);
            }

            return default;
        }

        public string CommonTypeName(Type a, Type /*?*/ b, ConcreteSyntaxTree wr, IToken tok)
        {
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_32(985L, b, null))
            {
                return TypeName(a, wr, tok);
            }
            a = a.NormalizeExpand();
            b = b.NormalizeExpand();
            if (a.Equals(b))
            {
                return TypeName(a, wr, tok);
            }
            // It would be nice to use Meet(a, b) here. Unfortunately, Resolver.Meet also needs a Builtins argument, which we
            // don't have here.
            Contract.Assert(a.IsRefType);
            Contract.Assert(b.IsRefType);
            return MutateCSharp.Schemata219.ReplaceStringConstant_1(986L, "object");
        }

        protected override string TypeInitializationValue(Type type, ConcreteSyntaxTree wr, IToken tok, bool usePlaceboValue, bool constructTypeParameterDefaultsFromTypeDescriptors)
        {
            var xType = type.NormalizeExpandKeepConstraints();

            if (usePlaceboValue)
            {
                return $"default({TypeName(type, wr, tok)})";
            }

            if (xType is BoolType)
            {
                return MutateCSharp.Schemata219.ReplaceStringConstant_1(987L, "false");
            }
            else if (xType is CharType)
            {
                return UnicodeCharEnabled ? $"new {CharTypeName}({CharType.DefaultValueAsString})" : CharType.DefaultValueAsString;
            }
            else if (MutateCSharp.Schemata219.ReplaceBinExprOp_10(988L, () => xType is IntType, () => xType is BigOrdinalType))
            {
                return MutateCSharp.Schemata219.ReplaceStringConstant_1(994L, "BigInteger.Zero");
            }
            else if (xType is RealType)
            {
                return MutateCSharp.Schemata219.ReplaceStringConstant_1(995L, "Dafny.BigRational.ZERO");
            }
            else if (xType is BitvectorType)
            {
                var t = (BitvectorType)xType;
                return MutateCSharp.Schemata219.ReplaceBinExprOp_25(996L, t.NativeType, null) ? MutateCSharp.Schemata219.ReplaceStringConstant_1(997L, "0") : MutateCSharp.Schemata219.ReplaceStringConstant_1(998L, "BigInteger.Zero");
            }
            else if (xType is CollectionType)
            {
                return TypeHelperName(xType, wr, tok) + MutateCSharp.Schemata219.ReplaceStringConstant_1(999L, ".Empty");
            }

            var udt = (UserDefinedType)xType;
            var cl = udt.ResolvedClass;
            Contract.Assert(cl != null);
            if (cl is TypeParameter tp)
            {
                if (constructTypeParameterDefaultsFromTypeDescriptors)
                {
                    return $"{FormatTypeDescriptorVariable(tp.GetCompileName(Options))}.Default()";
                }
                else
                {
                    return FormatDefaultTypeParameterValue(tp);
                }
            }
            else if (cl is AbstractTypeDecl opaque)
            {
                return FormatDefaultTypeParameterValue(opaque);
            }
            else if (cl is NewtypeDecl)
            {
                var td = (NewtypeDecl)cl;
                if (MutateCSharp.Schemata219.ReplaceBinExprOp_33(1000L, td.Witness, null))
                {
                    return TypeName_UDT(FullTypeName(udt), udt, wr, udt.tok) + MutateCSharp.Schemata219.ReplaceStringConstant_1(1001L, ".Witness");
                }
                else if (MutateCSharp.Schemata219.ReplaceBinExprOp_25(1002L, td.NativeType, null))
                {
                    return MutateCSharp.Schemata219.ReplaceStringConstant_1(1003L, "0");
                }
                else
                {
                    return TypeInitializationValue(td.BaseType, wr, tok, usePlaceboValue, constructTypeParameterDefaultsFromTypeDescriptors);
                }
            }
            else if (cl is SubsetTypeDecl)
            {
                var td = (SubsetTypeDecl)cl;
                if (MutateCSharp.Schemata219.ReplaceBinExprOp_26(1004L, td.WitnessKind, SubsetTypeDecl.WKind.Compiled))
                {
                    return TypeName_UDT(FullTypeName(udt), udt, wr, udt.tok) + MutateCSharp.Schemata219.ReplaceStringConstant_1(1005L, ".Default()");
                }
                else if (MutateCSharp.Schemata219.ReplaceBinExprOp_26(1006L, td.WitnessKind, SubsetTypeDecl.WKind.Special))
                {
                    // WKind.Special is only used with -->, ->, and non-null types:
                    Contract.Assert(ArrowType.IsPartialArrowTypeName(td.Name) || ArrowType.IsTotalArrowTypeName(td.Name) || td is NonNullTypeDecl);
                    if (ArrowType.IsPartialArrowTypeName(td.Name))
                    {
                        return $"(({TypeName(xType, wr, udt.tok)})null)";
                    }
                    else if (ArrowType.IsTotalArrowTypeName(td.Name))
                    {
                        var rangeDefaultValue = TypeInitializationValue(udt.TypeArgs.Last(), wr, tok, usePlaceboValue, constructTypeParameterDefaultsFromTypeDescriptors);
                        // return the lambda expression ((Ty0 x0, Ty1 x1, Ty2 x2) => rangeDefaultValue)
                        var arguments = Util.Comma(MutateCSharp.Schemata219.ReplaceBinExprOp_22(1011L, udt.TypeArgs.Count, MutateCSharp.Schemata219.ReplaceNumericConstant_4(1007L, 1)), i => $"{TypeName(udt.TypeArgs[i], wr, udt.tok)} {idGenerator.FreshId(MutateCSharp.Schemata219.ReplaceStringConstant_1(1020L, "x"))}");
                        return $"(({arguments}) => {rangeDefaultValue})";
                    }
                    else if (((NonNullTypeDecl)td).Class is ArrayClassDecl arrayClass)
                    {
                        // non-null array type; we know how to initialize them
                        TypeName_SplitArrayName(udt.TypeArgs[MutateCSharp.Schemata219.ReplaceNumericConstant_4(1021L, 0)], wr, udt.tok, out var typeNameSansBrackets, out var brackets);
                        return $"new {typeNameSansBrackets}[{Util.Comma(arrayClass.Dims, _ => MutateCSharp.Schemata219.ReplaceStringConstant_1(1025L, "0"))}]{brackets}";
                    }
                    else
                    {
                        // non-null (non-array) type
                        // even though the type doesn't necessarily have a known initializer, it could be that the the compiler needs to
                        // lay down some bits to please the C#'s compiler's different definite-assignment rules.
                        return $"default({TypeName(xType, wr, udt.tok)})";
                    }
                }
                else
                {
                    return TypeInitializationValue(td.RhsWithArgument(udt.TypeArgs), wr, tok, usePlaceboValue, constructTypeParameterDefaultsFromTypeDescriptors);
                }
            }
            else if (cl is ClassLikeDecl or ArrowTypeDecl)
            {
                return $"(({TypeName(xType, wr, udt.tok)})null)";
            }
            else if (cl is DatatypeDecl dt)
            {
                var s = FullTypeName(udt, ignoreInterface: MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1026L, true));
                var nonGhostTypeArgs = SelectNonGhost(dt, udt.TypeArgs);
                if (MutateCSharp.Schemata219.ReplaceBinExprOp_13(1031L, nonGhostTypeArgs.Count, MutateCSharp.Schemata219.ReplaceNumericConstant_4(1027L, 0)))
                {
                    s += MutateCSharp.Schemata219.ReplaceStringConstant_1(1036L, "<") + TypeNames(nonGhostTypeArgs, wr, udt.tok) + MutateCSharp.Schemata219.ReplaceStringConstant_1(1037L, ">");
                }


                var wDefaultTypeArguments = new ConcreteSyntaxTree();
                var sep = "";
                WriteTypeDescriptors(dt, udt.TypeArgs, wDefaultTypeArguments, ref sep);
                var relevantTypeArgs = UsedTypeParameters(dt, udt.TypeArgs);
                var arguments = relevantTypeArgs.Comma(ta => DefaultValue(ta.Actual, wr, tok, constructTypeParameterDefaultsFromTypeDescriptors));
                if (MutateCSharp.Schemata219.ReplaceBinExprOp_9(1042L, relevantTypeArgs.Count, MutateCSharp.Schemata219.ReplaceNumericConstant_4(1038L, 0)))
                {
                    sep = "";
                }
                return string.Format($"{s}.Default({wDefaultTypeArguments}{sep}{arguments})");
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected type
            }

            return default;
        }

        protected override string TypeName_UDT(string fullCompileName, List<TypeParameter.TPVariance> variance, List<Type> typeArgs,
          ConcreteSyntaxTree wr, IToken tok, bool omitTypeArguments = false)
        {
            Contract.Assume(fullCompileName != null);  // precondition; this ought to be declared as a Requires in the superclass
            Contract.Assume(variance != null);  // precondition; this ought to be declared as a Requires in the superclass
            Contract.Assume(typeArgs != null);  // precondition; this ought to be declared as a Requires in the superclass
            Contract.Assume(variance.Count == typeArgs.Count);
            string s = IdProtect(fullCompileName);
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_13(1051L, typeArgs.Count, MutateCSharp.Schemata219.ReplaceNumericConstant_4(1047L, 0)))
            {
                s += MutateCSharp.Schemata219.ReplaceStringConstant_1(1056L, "<") + TypeNames(typeArgs, wr, tok) + MutateCSharp.Schemata219.ReplaceStringConstant_1(1057L, ">");
            }
            return s;
        }

        protected override string TypeName_Companion(Type type, ConcreteSyntaxTree wr, IToken tok, MemberDecl/*?*/ member)
        {
            type = UserDefinedType.UpcastToMemberEnclosingType(type, member);
            if (type is UserDefinedType udt)
            {
                var name = udt.ResolvedClass is TraitDecl ? udt.GetFullCompanionCompileName(Options) : FullTypeName(udt, member, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1058L, true));
                return TypeName_UDT(name, udt, wr, tok);
            }
            else
            {
                return TypeName(type, wr, tok, member);
            }

            return default;
        }

        protected override void TypeArgDescriptorUse(bool isStatic, bool lookasideBody, TopLevelDeclWithMembers cl, out bool needsTypeParameter, out bool needsTypeDescriptor)
        {
            if (cl is DatatypeDecl)
            {
                needsTypeParameter = MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1059L, false);
                needsTypeDescriptor = MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1060L, true);
            }
            else if (cl is TraitDecl)
            {
                needsTypeParameter = MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1061L, false);
                needsTypeDescriptor = MutateCSharp.Schemata219.ReplaceBinExprOp_10(1062L, () => isStatic, () => lookasideBody);
            }
            else
            {
                Contract.Assert(cl is ClassDecl);
                needsTypeParameter = MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1068L, false);
                needsTypeDescriptor = isStatic;
            }
        }

        protected override string TypeDescriptor(Type type, ConcreteSyntaxTree wr, IToken tok)
        {
            type = DatatypeWrapperEraser.SimplifyTypeAndTrimSubsetTypes(Options, type);
            if (type is BoolType)
            {
                return MutateCSharp.Schemata219.ReplaceStringConstant_1(1069L, "Dafny.Helpers.BOOL");
            }
            else if (type is CharType)
            {
                return CharTypeDescriptorName;
            }
            else if (MutateCSharp.Schemata219.ReplaceBinExprOp_10(1070L, () => type is IntType, () => type is BigOrdinalType))
            {
                return MutateCSharp.Schemata219.ReplaceStringConstant_1(1076L, "Dafny.Helpers.INT");
            }
            else if (type is RealType)
            {
                return MutateCSharp.Schemata219.ReplaceStringConstant_1(1077L, "Dafny.Helpers.REAL");
            }
            else if (type is BitvectorType)
            {
                var t = (BitvectorType)type;
                if (MutateCSharp.Schemata219.ReplaceBinExprOp_25(1078L, t.NativeType, null))
                {
                    return GetNativeTypeDescriptor(AsNativeType(type));
                }
                else
                {
                    return MutateCSharp.Schemata219.ReplaceStringConstant_1(1079L, "Dafny.Helpers.INT");
                }
            }
            else if (type is SetType setType)
            {
                return $"{DafnySetClass}<{TypeName(setType.Arg, wr, tok)}>.{TypeDescriptorMethodName}()";
            }
            else if (type is SeqType seqType)
            {
                return $"{DafnySeqClass}<{TypeName(seqType.Arg, wr, tok)}>.{TypeDescriptorMethodName}()";
            }
            else if (type is MultiSetType multisetType)
            {
                return $"{DafnyMultiSetClass}<{TypeName(multisetType.Arg, wr, tok)}>.{TypeDescriptorMethodName}()";
            }
            else if (type is MapType mapType)
            {
                return $"{DafnyMapClass}<{TypeName(mapType.Domain, wr, tok)}, {TypeName(mapType.Range, wr, tok)}>.{TypeDescriptorMethodName}()";
            }
            else if (type.IsRefType)
            {
                return $"Dafny.Helpers.NULL<{TypeName(type, wr, tok)}>()";
            }
            else if (type.IsArrayType)
            {
                ArrayClassDecl at = type.AsArrayType;
                var elType = UserDefinedType.ArrayElementType(type);
                var elTypeName = TypeName(elType, wr, tok);
                return $"Dafny.Helpers.ARRAY{(MutateCSharp.Schemata219.ReplaceBinExprOp_9(1084L, at.Dims, MutateCSharp.Schemata219.ReplaceNumericConstant_4(1080L, 1)) ? "" : $"{at.Dims}")}<{elTypeName}>()";
            }
            else if (type.IsTypeParameter)
            {
                var tp = type.AsTypeParameter;
                Contract.Assert(tp != null);
                if (MutateCSharp.Schemata219.ReplaceBinExprOp_31(1089L, thisContext, null) && thisContext.ParentFormalTypeParametersToActuals.TryGetValue(tp, out var instantiatedTypeParameter))
                {
                    return TypeDescriptor(instantiatedTypeParameter, wr, tok);
                }
                return FormatTypeDescriptorVariable(type.AsTypeParameter.GetCompileName(Options));
            }
            else if (type.IsBuiltinArrowType)
            {
                return $"Dafny.Helpers.NULL<{TypeName(type, wr, tok)}>()";
            }
            else if (type is UserDefinedType udt)
            {
                var cl = udt.ResolvedClass;
                Contract.Assert(cl != null);

                List<Type> relevantTypeArgs;
                if (cl is DatatypeDecl dt)
                {
                    relevantTypeArgs = UsedTypeParameters(dt, udt.TypeArgs, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1090L, true)).ConvertAll(ta => ta.Actual);
                }
                else
                {
                    relevantTypeArgs = type.TypeArgs;
                }

                return AddTypeDescriptorArgs(FullTypeName(udt, ignoreInterface: MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1091L, true)), udt, relevantTypeArgs, wr, tok);
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();
            }

            return default;
        }

        private string GetNativeTypeDescriptor(NativeType nt)
        {
            Contract.Assert(nt != null);
            switch (nt.Sel)
            {
                case NativeType.Selection.SByte:
                    return $"Dafny.Helpers.INT8";
                    break;
                case NativeType.Selection.Byte:
                    return $"Dafny.Helpers.UINT8";
                    break;
                case NativeType.Selection.Short:
                    return $"Dafny.Helpers.INT16";
                    break;
                case NativeType.Selection.UShort:
                    return $"Dafny.Helpers.UINT16";
                    break;
                case NativeType.Selection.Int:
                    return $"Dafny.Helpers.INT32";
                    break;
                case NativeType.Selection.UInt:
                    return $"Dafny.Helpers.UINT32";
                    break;
                case NativeType.Selection.Long:
                    return $"Dafny.Helpers.INT64";
                    break;
                case NativeType.Selection.ULong:
                    return $"Dafny.Helpers.UINT64";
                    break;
                default:
                    Contract.Assert(false);
                    throw new cce.UnreachableException();
                    break;
            }

            return default;
        }

        private string AddTypeDescriptorArgs(string fullCompileName, UserDefinedType udt, List<Type> typeDescriptors, ConcreteSyntaxTree wr, IToken tok)
        {
            Contract.Requires(fullCompileName != null);
            Contract.Requires(udt != null);
            Contract.Requires(typeDescriptors != null);
            Contract.Requires(wr != null);
            Contract.Requires(tok != null);

            var s = TypeName_UDT(fullCompileName, udt, wr, tok);
            s += $".{TypeDescriptorMethodName}({typeDescriptors.Comma(arg => TypeDescriptor(arg, wr, tok))})";
            return s;
        }

        // ----- Declarations -------------------------------------------------------------

        protected void DeclareField(string name, bool isPublic, bool isStatic, bool isConst, string typeName, string rhs, ClassWriter cw)
        {
            var publik = isPublic ? MutateCSharp.Schemata219.ReplaceStringConstant_1(1092L, "public") : MutateCSharp.Schemata219.ReplaceStringConstant_1(1093L, "private");
            var konst = isConst ? MutateCSharp.Schemata219.ReplaceStringConstant_1(1094L, " readonly") : "";
            var virtuall = Synthesize ? MutateCSharp.Schemata219.ReplaceStringConstant_1(1095L, " virtual") : "";
            if (isStatic)
            {
                cw.StaticMemberWriter.Write($"{publik} static{konst} {typeName} {name}");
                if (rhs != null)
                {
                    cw.StaticMemberWriter.Write($" = {rhs}");
                }
                cw.StaticMemberWriter.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(1096L, ";"));
            }
            else
            {
                string ending = "";
                if (isPublic)
                {
                    if (isConst)
                    {
                        cw.InstanceMemberWriter.Write(
                          $"{publik}{konst}{virtuall} {typeName} {name} {{get;}}");
                    }
                    else
                    {
                        cw.InstanceMemberWriter.Write(
                          $"{publik}{virtuall} {typeName} {name} {{get; set;}}");
                    }
                }
                else
                {
                    cw.InstanceMemberWriter.WriteLine($"{publik}{konst} {typeName} {name}");
                    ending = MutateCSharp.Schemata219.ReplaceStringConstant_1(1097L, ";");
                }
                if (MutateCSharp.Schemata219.ReplaceBinExprOp_34(1098L, cw.CtorBodyWriter, null))
                {
                    if (rhs != null)
                    {
                        cw.InstanceMemberWriter.Write($" = {rhs}");
                        ending = MutateCSharp.Schemata219.ReplaceStringConstant_1(1099L, ";");
                    }
                }
                else
                {
                    if (rhs != null)
                    {
                        cw.CtorBodyWriter.WriteLine($"this.{name} = {rhs};");
                    }
                }
                cw.InstanceMemberWriter.WriteLine(ending);
            }
        }

        protected override bool DeclareFormal(string prefix, string name, Type type, IToken tok, bool isInParam, ConcreteSyntaxTree wr)
        {
            wr.Write($"{prefix}{(isInParam ? "" : MutateCSharp.Schemata219.ReplaceStringConstant_1(1100L, "out "))}{TypeName(type, wr, tok)} {name}");
            return MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1101L, true);
        }

        protected override void DeclareLocalVar(string name, Type/*?*/ type, IToken/*?*/ tok, bool leaveRoomForRhs, string/*?*/ rhs, ConcreteSyntaxTree wr)
        {
            wr.Write($"{(MutateCSharp.Schemata219.ReplaceBinExprOp_20(1102L, type, null) ? TypeName(type, wr, tok) : MutateCSharp.Schemata219.ReplaceStringConstant_1(1103L, "var"))} {name}");
            if (leaveRoomForRhs)
            {
                Contract.Assert(rhs == null);  // follows from precondition
            }
            else if (rhs != null)
            {
                wr.WriteLine($" = {rhs};");
            }
            else
            {
                wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(1104L, ";"));
            }
        }

        protected override ConcreteSyntaxTree DeclareLocalVar(string name, Type/*?*/ type, IToken/*?*/ tok, ConcreteSyntaxTree wr)
        {
            var w = new ConcreteSyntaxTree();
            wr.FormatLine($"{(MutateCSharp.Schemata219.ReplaceBinExprOp_20(1105L, type, null) ? TypeName(type, wr, tok) : MutateCSharp.Schemata219.ReplaceStringConstant_1(1106L, "var"))} {name} = {w};");
            return w;
        }

        protected override void DeclareOutCollector(string collectorVarName, ConcreteSyntaxTree wr)
        {
            wr.Write($"var {collectorVarName} = ");
        }

        protected override void DeclareLocalOutVar(string name, Type type, IToken tok, string rhs, bool useReturnStyleOuts, ConcreteSyntaxTree wr)
        {
            if (useReturnStyleOuts)
            {
                DeclareLocalVar(name, type, tok, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1107L, false), rhs, wr);
            }
            else
            {
                EmitAssignment(name, type, rhs, null, wr);
            }
        }

        protected override void EmitActualOutArg(string actualOutParamName, ConcreteSyntaxTree wr)
        {
            wr.Write($"out {actualOutParamName}");
        }

        protected override bool UseReturnStyleOuts(Method m, int nonGhostOutCount)
        {
            return MutateCSharp.Schemata219.ReplaceBinExprOp_9(1112L, nonGhostOutCount, MutateCSharp.Schemata219.ReplaceNumericConstant_4(1108L, 1));
        }

        protected override void EmitOutParameterSplits(string outCollector, List<string> actualOutParamNames, ConcreteSyntaxTree wr)
        {
            Contract.Assert(actualOutParamNames.Count == 1);
            EmitAssignment(actualOutParamNames[MutateCSharp.Schemata219.ReplaceNumericConstant_4(1117L, 0)], null, outCollector, null, wr);
        }

        protected override void EmitActualTypeArgs(List<Type> typeArgs, IToken tok, ConcreteSyntaxTree wr)
        {
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_13(1125L, typeArgs.Count, MutateCSharp.Schemata219.ReplaceNumericConstant_4(1121L, 0)))
            {
                wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1130L, "<") + TypeNames(typeArgs, wr, tok) + MutateCSharp.Schemata219.ReplaceStringConstant_1(1131L, ">"));
            }
        }

        // ----- Statements -------------------------------------------------------------

        protected override void EmitPrintStmt(ConcreteSyntaxTree wr, Expression arg)
        {
            var wStmts = wr.Fork();
            var type = DatatypeWrapperEraser.SimplifyTypeAndTrimNewtypes(Options, arg.Type);
            var typeArgs = MutateCSharp.Schemata219.ReplaceBinExprOp_35(1132L, type.AsArrowType, null) ? "" : $"<{TypeName(type, wr, null, null)}>";
            var suffix = MutateCSharp.Schemata219.ReplaceBinExprOp_14(1133L, () => type.IsStringType, () => UnicodeCharEnabled) ? MutateCSharp.Schemata219.ReplaceStringConstant_1(1139L, ".ToVerbatimString(false)") : "";
            wr.WriteLine($"{DafnyHelpersClass}.Print{typeArgs}(({Expr(arg, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1140L, false), wStmts)}){suffix});");
        }

        protected override void EmitReturn(List<Formal> outParams, ConcreteSyntaxTree wr)
        {
            outParams = outParams.Where(f => !f.IsGhost).ToList();
            var returnExpr = MutateCSharp.Schemata219.ReplaceBinExprOp_9(1145L, outParams.Count, MutateCSharp.Schemata219.ReplaceNumericConstant_4(1141L, 1)) ? IdName(outParams[MutateCSharp.Schemata219.ReplaceNumericConstant_4(1150L, 0)]) : "";
            wr.WriteLine($"return {returnExpr};");
        }

        protected override ConcreteSyntaxTree CreateLabeledCode(string label, bool createContinueLabel, ConcreteSyntaxTree wr)
        {
            var w = wr.Fork();
            var prefix = createContinueLabel ? MutateCSharp.Schemata219.ReplaceStringConstant_1(1154L, "continue_") : MutateCSharp.Schemata219.ReplaceStringConstant_1(1155L, "after_");
            wr.Fork(MutateCSharp.Schemata219.ReplaceNumericConstant_4(1156L, -1)).WriteLine($"{prefix}{label}: ;");
            return w;
        }

        protected override void EmitBreak(string/*?*/ label, ConcreteSyntaxTree wr)
        {
            if (label == null)
            {
                wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(1160L, "break;"));
            }
            else
            {
                wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(1161L, "goto after_{0};"), label);
            }
        }

        protected override void EmitContinue(string label, ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(1162L, "goto continue_{0};"), label);
        }

        protected override void EmitYield(ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(1163L, "yield return null;"));
        }

        protected override void EmitAbsurd(string/*?*/ message, ConcreteSyntaxTree wr)
        {
            if (message == null)
            {
                message = MutateCSharp.Schemata219.ReplaceStringConstant_1(1164L, "unexpected control point");
            }
            wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(1165L, "throw new System.Exception(\"{0}\");"), message);
        }

        protected override void EmitHalt(IToken tok, Expression/*?*/ messageExpr, ConcreteSyntaxTree wr)
        {
            var exceptionMessage = Expr(messageExpr, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1166L, false), wr.Fork());
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_36(1167L, tok, null))
            {
                exceptionMessage.Prepend(new LineSegment(SymbolDisplay.FormatLiteral(tok.TokenToString(Options) + MutateCSharp.Schemata219.ReplaceStringConstant_1(1168L, ": "), MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1169L, true)) + MutateCSharp.Schemata219.ReplaceStringConstant_1(1170L, " + ")));
            }
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_14(1171L, () => UnicodeCharEnabled, () => messageExpr.Type.IsStringType))
            {
                exceptionMessage.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1177L, ".ToVerbatimString(false)"));
            }
            wr.Format($"throw new Dafny.HaltException({exceptionMessage});");
        }

        protected override ConcreteSyntaxTree EmitForStmt(IToken tok, IVariable loopIndex, bool goingUp, string /*?*/ endVarName,
          List<Statement> body, LList<Label> labels, ConcreteSyntaxTree wr)
        {

            wr.Write($"for ({TypeName(loopIndex.Type, wr, tok)} {loopIndex.CompileName} = ");
            var startWr = wr.Fork();
            wr.Write($"; ");

            ConcreteSyntaxTree bodyWr;
            if (goingUp)
            {
                wr.Write(endVarName != null ? $"{loopIndex.CompileName} < {endVarName}" : "");
                bodyWr = wr.NewBlock($"; {loopIndex.CompileName}++)");
            }
            else
            {
                wr.Write(endVarName != null ? $"{endVarName} < {loopIndex.CompileName}" : "");
                bodyWr = wr.NewBlock($"; )");
                bodyWr.WriteLine($"{loopIndex.CompileName}--;");
            }
            bodyWr = EmitContinueLabel(labels, bodyWr);
            TrStmtList(body, bodyWr);

            return startWr;
        }

        protected override ConcreteSyntaxTree CreateForLoop(string indexVar, Action<ConcreteSyntaxTree> boundAction, ConcreteSyntaxTree wr, string start = null)
        {
            start = start ?? MutateCSharp.Schemata219.ReplaceStringConstant_1(1178L, "0");
            var boundWriter = new ConcreteSyntaxTree();
            boundAction(boundWriter);
            var bound = boundWriter.ToString();
            return wr.NewNamedBlock(MutateCSharp.Schemata219.ReplaceStringConstant_1(1179L, "for (var {0} = {2}; {0} < {1}; {0}++)"), indexVar, bound, start);
        }

        protected override ConcreteSyntaxTree CreateDoublingForLoop(string indexVar, int start, ConcreteSyntaxTree wr)
        {
            return wr.NewNamedBlock(MutateCSharp.Schemata219.ReplaceStringConstant_1(1180L, "for (var {0} = new BigInteger({1}); ; {0} *= 2)"), indexVar, start);
        }

        protected override void EmitIncrementVar(string varName, ConcreteSyntaxTree wr)
        {
            wr.WriteLine($"{varName}++;");
        }

        protected override void EmitDecrementVar(string varName, ConcreteSyntaxTree wr)
        {
            wr.WriteLine($"{varName}--;");
        }

        protected override string GetQuantifierName(string bvType)
        {
            return string.Format($"{DafnyHelpersClass}.Quantifier<{bvType}>");
        }

        protected override ConcreteSyntaxTree CreateForeachLoop(string tmpVarName, Type collectionElementType, IToken tok, out ConcreteSyntaxTree collectionWriter, ConcreteSyntaxTree wr)
        {
            collectionWriter = new ConcreteSyntaxTree();
            wr.Format($"foreach ({TypeName(collectionElementType, wr, tok)} {tmpVarName} in {collectionWriter})");
            return wr.NewBlock();
        }

        protected override void EmitDowncastVariableAssignment(string boundVarName, Type boundVarType, string tmpVarName,
          Type sourceType, bool introduceBoundVar, IToken tok, ConcreteSyntaxTree wr)
        {
            var typeName = TypeName(boundVarType, wr, tok);
            wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(1181L, "{0}{1} = ({2}){3};"), introduceBoundVar ? typeName + MutateCSharp.Schemata219.ReplaceStringConstant_1(1182L, " ") : "", boundVarName, typeName, tmpVarName);
        }

        [CanBeNull]
        protected override Action<ConcreteSyntaxTree> GetSubtypeCondition(string tmpVarName, Type boundVarType, IToken tok, ConcreteSyntaxTree wPreconditions)
        {
            string typeTest;
            if (boundVarType.IsRefType)
            {
                if (MutateCSharp.Schemata219.ReplaceBinExprOp_10(1183L, () => boundVarType.IsObject, () => boundVarType.IsObjectQ))
                {
                    typeTest = MutateCSharp.Schemata219.ReplaceStringConstant_1(1189L, "true");
                }
                else
                {
                    typeTest = $"{tmpVarName} is {TypeName(boundVarType, wPreconditions, tok)}";
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
                typeTest = MutateCSharp.Schemata219.ReplaceStringConstant_1(1190L, "true");
            }

            typeTest = MutateCSharp.Schemata219.ReplaceBinExprOp_23(1192L, typeTest, MutateCSharp.Schemata219.ReplaceStringConstant_1(1191L, "true")) ? null : typeTest;
            return typeTest == null ? null : wr => wr.Write(typeTest);
        }

        protected override ConcreteSyntaxTree CreateForeachIngredientLoop(string boundVarName, int L, string tupleTypeArgs, out ConcreteSyntaxTree collectionWriter, ConcreteSyntaxTree wr)
        {
            collectionWriter = new ConcreteSyntaxTree();
            return wr.Format($"foreach (var {boundVarName} in {collectionWriter})").NewBlock();
        }

        // ----- Expressions -------------------------------------------------------------

        protected override void EmitNew(Type type, IToken tok, CallStmt initCall /*?*/, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var cl = ((UserDefinedType)type.NormalizeExpand()).ResolvedClass;
            var ctor = (Constructor)initCall?.Method;  // correctness of cast follows from precondition of "EmitNew"
            var arguments = new ConcreteSyntaxTree();
            wr.Format($"new {TypeName(type, wr, tok)}({arguments})");
            var sep = "";
            EmitTypeDescriptorsActuals(TypeArgumentInstantiation.ListFromClass(cl, type.TypeArgs), tok, arguments, ref sep);
            arguments.Write(ConstructorArguments(initCall, wStmts, ctor, sep));
        }

        protected override void EmitNewArray(Type elementType, IToken tok, List<string> dimensions,
            bool mustInitialize, [CanBeNull] string exampleElement, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var wrs = EmitNewArray(elementType, tok, dimensions.Count, mustInitialize, wr);
            for (var i = MutateCSharp.Schemata219.ReplaceNumericConstant_4(1193L, 0); MutateCSharp.Schemata219.ReplaceBinExprOp_6(1197L, i, wrs.Count); MutateCSharp.Schemata219.ReplacePostfixUnaryExprOp_7(1202L, ref i))
            {
                wrs[i].Write(dimensions[i]);
            }
        }

        private List<ConcreteSyntaxTree> EmitNewArray(Type elmtType, IToken tok, int dimCount, bool mustInitialize, ConcreteSyntaxTree wr)
        {
            ConcreteSyntaxTree EmitSizeCheckWrapper(ConcreteSyntaxTree w)
            {
                w.Write($"{DafnyHelpersClass}.ToIntChecked(");
                var wSize = w.Fork();
                w.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1203L, ", \"array size exceeds memory limit\")"));
                return wSize;
            }

            var wrs = new List<ConcreteSyntaxTree>();
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_10(1204L, () => !mustInitialize, () => HasSimpleZeroInitializer(elmtType)))
            {
                TypeName_SplitArrayName(elmtType, wr, tok, out string typeNameSansBrackets, out string brackets);
                wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1210L, "new {0}"), typeNameSansBrackets);
                string prefix = MutateCSharp.Schemata219.ReplaceStringConstant_1(1211L, "[");
                for (var d = MutateCSharp.Schemata219.ReplaceNumericConstant_4(1212L, 0); MutateCSharp.Schemata219.ReplaceBinExprOp_6(1216L, d, dimCount); MutateCSharp.Schemata219.ReplacePostfixUnaryExprOp_7(1221L, ref d))
                {
                    wr.Write(prefix);
                    wrs.Add(EmitSizeCheckWrapper(wr));
                    prefix = MutateCSharp.Schemata219.ReplaceStringConstant_1(1222L, ", ");
                }
                wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1223L, "]{0}"), brackets);
            }
            else
            {
                wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1224L, "Dafny.ArrayHelpers.InitNewArray{0}<{1}>"), dimCount, TypeName(elmtType, wr, tok));
                var inParens = wr.ForkInParens();
                inParens.Write(DefaultValue(elmtType, inParens, tok, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1225L, true)));
                for (var d = MutateCSharp.Schemata219.ReplaceNumericConstant_4(1226L, 0); MutateCSharp.Schemata219.ReplaceBinExprOp_6(1230L, d, dimCount); MutateCSharp.Schemata219.ReplacePostfixUnaryExprOp_7(1235L, ref d))
                {
                    inParens.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1236L, ", "));
                    wrs.Add(EmitSizeCheckWrapper(inParens));
                }
            }
            return wrs;
        }

        /// <summary>
        /// Return "true" if the C# all-zero bit pattern is a meaningful value for a Dafny type "t".
        /// This method is allowed to be conservative; that is, it is allowed to return "false" more often
        /// than strictly needed.
        /// </summary>
        private bool HasSimpleZeroInitializer(Type t)
        {
            Contract.Requires(t != null);

            t = t.NormalizeExpandKeepConstraints();
            if (t is CharType)
            {
                // Okay, so '\0' _is_ a value of type "char", but it's so unpleasant to deal with in test files, etc.
                // By returning false here, a different value will be chosen.
                return MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1237L, false);
            }
            else if (MutateCSharp.Schemata219.ReplaceBinExprOp_10(1256L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_10(1250L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_10(1244L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_10(1238L, () => t is BoolType, () => t is IntType), () => t is BigOrdinalType), () => t is RealType), () => t is BitvectorType))
            {
                return MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1262L, true);
            }
            else if (t is CollectionType)
            {
                return MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1263L, false);
            }

            var udt = (UserDefinedType)t;
            var cl = udt.ResolvedClass;
            Contract.Assert(cl != null);
            if (cl is NewtypeDecl)
            {
                var td = (NewtypeDecl)cl;
                return MutateCSharp.Schemata219.ReplaceBinExprOp_26(1264L, td.WitnessKind, SubsetTypeDecl.WKind.CompiledZero);
            }
            else if (cl is ClassLikeDecl { IsReferenceTypeDecl: true })
            {
                return MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1265L, true); // null is a value of this type
            }
            else
            {
                return MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1266L, false);
            }

            return default;
        }

        protected override void EmitLiteralExpr(ConcreteSyntaxTree wr, LiteralExpr e)
        {
            if (e is StaticReceiverExpr)
            {
                wr.Write(TypeName(e.Type, wr, e.tok));
            }
            else if (e.Value == null)
            {
                var cl = (e.Type.NormalizeExpand() as UserDefinedType)?.ResolvedClass;
                wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1267L, "({0})null"), TypeName(e.Type, wr, e.tok));
            }
            else if (e.Value is bool)
            {
                wr.Write((bool)e.Value ? MutateCSharp.Schemata219.ReplaceStringConstant_1(1268L, "true") : MutateCSharp.Schemata219.ReplaceStringConstant_1(1269L, "false"));
            }
            else if (e is CharLiteralExpr)
            {
                var v = (string)e.Value;
                if (UnicodeCharEnabled)
                {
                    var codePoint = Util.UnescapedCharacters(Options, v, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1270L, false)).Single();
                    if (MutateCSharp.Schemata219.ReplaceBinExprOp_15(1271L, codePoint, char.MaxValue))
                    {
                        // C# supports \U, but doesn't allow values that require two UTF-16 code units in character literals.
                        // For such values we construct the Rune value directly from the unescaped codepoint.
                        wr.Write($"new Dafny.Rune(0x{codePoint:x})");
                    }
                    else
                    {
                        wr.Write($"new Dafny.Rune('{Util.ExpandUnicodeEscapes(v, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1276L, false))}')");
                    }
                }
                else
                {
                    wr.Write($"'{v}'");
                }
            }
            else if (e is StringLiteralExpr str)
            {
                wr.Format($"{DafnySeqClass}<{CharTypeName}>.{CharMethodQualifier}FromString({StringLiteral(str)})");
            }
            else if (AsNativeType(e.Type) is { } nativeType)
            {
                GetNativeInfo(nativeType.Sel, out var nativeName, out var literalSuffix, out var needsCastAfterArithmetic);
                if (needsCastAfterArithmetic)
                {
                    wr = wr.Write($"({nativeName})").ForkInParens();
                }
                wr.Write((BigInteger)e.Value + literalSuffix);
            }
            else if (e.Value is BigInteger bigInteger)
            {
                EmitIntegerLiteral(bigInteger, wr);
            }
            else if (e.Value is BigDec n)
            {
                if (MutateCSharp.Schemata219.ReplaceBinExprOp_37(1281L, MutateCSharp.Schemata219.ReplaceNumericConstant_4(1277L, 0), n.Exponent))
                {
                    wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1286L, "new Dafny.BigRational(BigInteger.Parse(\"{0}"), n.Mantissa);
                    for (int i = MutateCSharp.Schemata219.ReplaceNumericConstant_4(1287L, 0); MutateCSharp.Schemata219.ReplaceBinExprOp_6(1291L, i, n.Exponent); MutateCSharp.Schemata219.ReplacePostfixUnaryExprOp_7(1296L, ref i))
                    {
                        wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1297L, "0"));
                    }
                    wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1298L, "\"), BigInteger.One)"));
                }
                else
                {
                    wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1299L, "new Dafny.BigRational("));
                    EmitIntegerLiteral(n.Mantissa, wr);
                    wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1300L, ", BigInteger.Parse(\"1"));
                    for (int i = n.Exponent; MutateCSharp.Schemata219.ReplaceBinExprOp_6(1305L, i, MutateCSharp.Schemata219.ReplaceNumericConstant_4(1301L, 0)); MutateCSharp.Schemata219.ReplacePostfixUnaryExprOp_7(1310L, ref i))
                    {
                        wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1311L, "0"));
                    }
                    wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1312L, "\"))"));
                }
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected literal
            }
        }

        void EmitIntegerLiteral(BigInteger i, ConcreteSyntaxTree wr)
        {
            Contract.Requires(wr != null);
            if (i.IsZero)
            {
                wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1313L, "BigInteger.Zero"));
            }
            else if (i.IsOne)
            {
                wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1314L, "BigInteger.One"));
            }
            else if (MutateCSharp.Schemata219.ReplaceBinExprOp_14(1319L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_38(1315L, int.MinValue, i), () => MutateCSharp.Schemata219.ReplaceBinExprOp_39(1317L, i, int.MaxValue)))
            {
                wr.Write($"new BigInteger({i})");
            }
            else if (MutateCSharp.Schemata219.ReplaceBinExprOp_14(1329L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_40(1325L, long.MinValue, i), () => MutateCSharp.Schemata219.ReplaceBinExprOp_41(1327L, i, long.MaxValue)))
            {
                wr.Write($"new BigInteger({i}L)");
            }
            else if (MutateCSharp.Schemata219.ReplaceBinExprOp_14(1339L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_42(1335L, ulong.MinValue, i), () => MutateCSharp.Schemata219.ReplaceBinExprOp_43(1337L, i, ulong.MaxValue)))
            {
                wr.Write($"new BigInteger({i}UL)");
            }
            else
            {
                wr.Write($"BigInteger.Parse(\"{i}\")");
            }
        }

        protected override void EmitStringLiteral(string str, bool isVerbatim, ConcreteSyntaxTree wr)
        {
            wr.Write($"{(isVerbatim ? MutateCSharp.Schemata219.ReplaceStringConstant_1(1345L, "@") : "")}\"{Util.ExpandUnicodeEscapes(str, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1346L, false))}\"");
        }

        protected override ConcreteSyntaxTree EmitBitvectorTruncation(BitvectorType bvType, [CanBeNull] NativeType nativeType,
          bool surroundByUnchecked, ConcreteSyntaxTree wr)
        {
            string nativeName = null, literalSuffix = null;
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_25(1347L, nativeType, null))
            {
                GetNativeInfo(nativeType.Sel, out nativeName, out literalSuffix, out _);
            }

            // --- Before
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_25(1348L, nativeType, null))
            {
                if (surroundByUnchecked)
                {
                    // Unfortunately, the following will apply "unchecked" to all subexpressions as well.  There
                    // shouldn't ever be any problem with this, but stylistically it would have been nice to have
                    // applied the "unchecked" only to the actual operation that may overflow.
                    wr = wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1349L, "unchecked")).ForkInParens();
                }
                wr.Write($"({nativeName})");
            }
            wr = wr.ForkInParens();
            // --- Middle
            var middle = wr.ForkInParens();
            // --- After
            // do the truncation, if needed
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_27(1350L, nativeType, null))
            {
                wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1351L, " & ((new BigInteger(1) << {0}) - 1)"), bvType.Width);
            }
            else if (MutateCSharp.Schemata219.ReplaceBinExprOp_6(1352L, bvType.Width, nativeType.Bitwidth))
            {
                // print in hex, because that looks nice
                wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1357L, " & ({2})0x{0:X}{1}"), MutateCSharp.Schemata219.ReplaceBinExprOp_46(1365L, (MutateCSharp.Schemata219.ReplaceBinExprOp_45(1361L, MutateCSharp.Schemata219.ReplaceNumericConstant_44(1358L, 1UL), bvType.Width)), MutateCSharp.Schemata219.ReplaceNumericConstant_44(1362L, 1)), literalSuffix, nativeName);
            }

            return middle;
        }

        protected override void EmitRotate(Expression e0, Expression e1, bool isRotateLeft, ConcreteSyntaxTree wr,
            bool inLetExprBody, ConcreteSyntaxTree wStmts, FCE_Arg_Translator tr)
        {
            string nativeName = null;
            bool needsCast = MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1372L, false);
            var nativeType = AsNativeType(e0.Type);
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_25(1373L, nativeType, null))
            {
                GetNativeInfo(nativeType.Sel, out nativeName, out _, out needsCast);
            }

            // ( e0 op1 e1) | (e0 op2 (width - e1))
            if (needsCast)
            {
                wr = wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1374L, "(") + nativeName + MutateCSharp.Schemata219.ReplaceStringConstant_1(1375L, ")")).ForkInParens();
            }
            EmitShift(e0, e1, isRotateLeft ? MutateCSharp.Schemata219.ReplaceStringConstant_1(1376L, "<<") : MutateCSharp.Schemata219.ReplaceStringConstant_1(1377L, ">>"), isRotateLeft, nativeType, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1378L, true), wr.ForkInParens(), inLetExprBody, wStmts, tr);

            wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1379L, " | "));

            EmitShift(e0, e1, isRotateLeft ? MutateCSharp.Schemata219.ReplaceStringConstant_1(1380L, ">>") : MutateCSharp.Schemata219.ReplaceStringConstant_1(1381L, "<<"), !isRotateLeft, nativeType, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1382L, false), wr.ForkInParens(), inLetExprBody, wStmts, tr);
        }

        private void EmitShift(Expression e0, Expression e1, string op, bool truncate, [CanBeNull] NativeType nativeType, bool firstOp,
            ConcreteSyntaxTree wr, bool inLetExprBody, ConcreteSyntaxTree wStmts, FCE_Arg_Translator tr)
        {
            var bv = e0.Type.NormalizeToAncestorType().AsBitVectorType;
            if (truncate)
            {
                wr = EmitBitvectorTruncation(bv, nativeType, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1383L, true), wr);
            }
            tr(e0, wr, inLetExprBody, wStmts);
            wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1384L, " {0} "), op);
            if (!firstOp)
            {
                wr = wr.ForkInParens().Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1385L, "{0} - "), bv.Width);
            }

            wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1386L, "(int)"));
            tr(e1, wr.ForkInParens(), inLetExprBody, wStmts);
        }

        protected override bool CompareZeroUsingSign(Type type)
        {
            return MutateCSharp.Schemata219.ReplaceBinExprOp_27(1387L, AsNativeType(type), null);
        }

        protected override ConcreteSyntaxTree EmitSign(Type type, ConcreteSyntaxTree wr)
        {
            // Should only be called when CompareZeroUsingSign is true
            Contract.Assert(AsNativeType(type) == null);

            ConcreteSyntaxTree w = wr.Fork();
            wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1388L, ".Sign"));

            return w;
        }

        protected override void EmitEmptyTupleList(string tupleTypeArgs, ConcreteSyntaxTree wr)
        {
            wr.Write($"new System.Collections.Generic.List<System.Tuple<{tupleTypeArgs}>>()");
        }

        protected override ConcreteSyntaxTree EmitAddTupleToList(string ingredients, string tupleTypeArgs, ConcreteSyntaxTree wr)
        {
            var wrTuple = new ConcreteSyntaxTree();
            wr.FormatLine($"{ingredients}.Add(new System.Tuple<{tupleTypeArgs}>({wrTuple}));");
            return wrTuple;
        }

        protected override void EmitTupleSelect(string prefix, int i, ConcreteSyntaxTree wr)
        {
            wr.Write($"{prefix}.Item{MutateCSharp.Schemata219.ReplaceBinExprOp_19(1393L, i, MutateCSharp.Schemata219.ReplaceNumericConstant_4(1389L, 1))}");
        }

        protected override string IdProtect(string name)
        {
            return PublicIdProtect(name);
        }
        public override string PublicIdProtect(string name)
        {
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_10(1408L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_23(1402L, name, ""), () => MutateCSharp.Schemata219.ReplaceBinExprOp_9(1403L, name.First(), '_')))
            {
                return name;  // no need to further protect this name -- we know it's not a C# keyword
            }
            switch (name)
            {
                // keywords
                case "base":
                case "byte":
                case "catch":
                case "checked":
                case "continue":
                case "decimal":
                case "default":
                case "delegate":
                case "do":
                case "double":
                case "enum":
                case "event":
                case "explicit":
                case "extern":
                case "finally":
                case "fixed":
                case "float":
                case "for":
                case "foreach":
                case "goto":
                case "implicit":
                case "interface":
                case "internal":
                case "is":
                case "lock":
                case "long":
                case "namespace":
                case "operator":
                case "out":
                case "override":
                case "params":
                case "private":
                case "public":
                case "readonly":
                case "ref":
                case "sbyte":
                case "sealed":
                case "short":
                case "sizeof":
                case "stackalloc":
                case "struct":
                case "switch":
                case "throw":
                case "try":
                case "typeof":
                case "uint":
                case "ulong":
                case "unchecked":
                case "unsafe":
                case "ushort":
                case "using":
                case "virtual":
                case "void":
                case "volatile":
                // contextual keywords
                case "add":
                case "alias":
                case "ascending":
                case "async":
                case "await":
                case "descending":
                case "dynamic":
                case "equals":
                case "from":
                case "get":
                case "global":
                case "group":
                case "into":
                case "join":
                case "let":
                case "nameof":
                case "on":
                case "orderby":
                case "partial":
                case "remove":
                case "select":
                case "set":
                case "value":
                case "when":
                case "where":
                    return "@" + name;
                    break;
                // methods with expected names
                case "ToString":
                case "GetHashCode":
                case "Main":
                    return "_" + name;
                    break;
                default:
                    return name;
                    break;
            }

            return default;
        }

        protected override string FullTypeName(UserDefinedType udt, MemberDecl /*?*/ member = null)
        {
            return FullTypeName(udt, member);
        }
        private string FullTypeName(UserDefinedType udt, MemberDecl/*?*/ member = null, bool ignoreInterface = false)
        {
            Contract.Assume(udt != null);  // precondition; this ought to be declared as a Requires in the superclass
            if (udt is ArrowType)
            {
                return ArrowType.Arrow_FullCompileName;
            }

            if (member != null && member.IsExtern(Options, out var qualification, out _) && qualification != null)
            {
                return qualification;
            }
            var cl = udt.ResolvedClass;
            if (cl is TypeParameter)
            {
                return IdProtect(udt.GetCompileName(Options));
            }

            //Use the interface if applicable (not handwritten, or incompatible variance)
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_14(1426L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_14(1414L, () => (cl is DatatypeDecl)
      , () => !ignoreInterface
      ), () => (MutateCSharp.Schemata219.ReplaceBinExprOp_10(1420L, () => member is null, () => !NeedsCustomReceiver(member)))))
            {
                return (cl.EnclosingModuleDefinition.TryToAvoidName ? "" : IdProtectModule(cl.EnclosingModuleDefinition.GetCompileName(Options)) + MutateCSharp.Schemata219.ReplaceStringConstant_1(1432L, ".")) + DtTypeName(cl, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1433L, false));
            }

            if (cl.EnclosingModuleDefinition.TryToAvoidName)
            {
                return IdProtect(cl.GetCompileName(Options));
            }

            if (cl.IsExtern(Options, out _, out _))
            {
                return cl.EnclosingModuleDefinition.GetCompileName(Options) + MutateCSharp.Schemata219.ReplaceStringConstant_1(1434L, ".") + cl.GetCompileName(Options);
            }
            return IdProtectModule(cl.EnclosingModuleDefinition.GetCompileName(Options)) + MutateCSharp.Schemata219.ReplaceStringConstant_1(1435L, ".") + IdProtect(cl.GetCompileName(Options));
        }

        protected override void EmitThis(ConcreteSyntaxTree wr, bool callToInheritedMember)
        {
            var custom = MutateCSharp.Schemata219.ReplaceBinExprOp_10(1480L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_10(1474L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_10(1462L, () => (MutateCSharp.Schemata219.ReplaceBinExprOp_14(1443L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_47(1436L, enclosingMethod, null), () => (MutateCSharp.Schemata219.ReplaceBinExprOp_10(1437L, () => enclosingMethod.IsTailRecursive, () => NeedsCustomReceiver(enclosingMethod))))), () => (MutateCSharp.Schemata219.ReplaceBinExprOp_14(1456L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_48(1449L, enclosingFunction, null), () => (MutateCSharp.Schemata219.ReplaceBinExprOp_10(1450L, () => enclosingFunction.IsTailRecursive, () => NeedsCustomReceiver(enclosingFunction)))))), () => (MutateCSharp.Schemata219.ReplaceBinExprOp_14(1468L, () => thisContext is NewtypeDecl, () => !callToInheritedMember))), () => thisContext is TraitDecl);
            wr.Write(custom ? MutateCSharp.Schemata219.ReplaceStringConstant_1(1486L, "_this") : MutateCSharp.Schemata219.ReplaceStringConstant_1(1487L, "this"));
        }

        protected override void EmitDatatypeValue(DatatypeValue dtv, string typeDescriptorArguments, string arguments, ConcreteSyntaxTree wr)
        {
            var dt = dtv.Ctor.EnclosingDatatype;
            var dtName = IdProtectModule(dt.EnclosingModuleDefinition.GetCompileName(Options)) + MutateCSharp.Schemata219.ReplaceStringConstant_1(1488L, ".") + IdName(dt);

            var nonGhostInferredTypeArgs = SelectNonGhost(dt, dtv.InferredTypeArgs);
            var typeParams = MutateCSharp.Schemata219.ReplaceBinExprOp_9(1493L, nonGhostInferredTypeArgs.Count, MutateCSharp.Schemata219.ReplaceNumericConstant_4(1489L, 0)) ? "" : $"<{TypeNames(nonGhostInferredTypeArgs, wr, dtv.tok)}>";
            var sep = MutateCSharp.Schemata219.ReplaceBinExprOp_14(1516L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_13(1502L, typeDescriptorArguments.Length, MutateCSharp.Schemata219.ReplaceNumericConstant_4(1498L, 0)), () => MutateCSharp.Schemata219.ReplaceBinExprOp_13(1511L, arguments.Length, MutateCSharp.Schemata219.ReplaceNumericConstant_4(1507L, 0))) ? MutateCSharp.Schemata219.ReplaceStringConstant_1(1522L, ", ") : "";
            if (!dtv.IsCoCall)
            {
                // For an ordinary constructor (that is, one that does not guard any co-recursive calls), generate:
                //   Dt.create_Cons<T>( args )
                wr.Write($"{dtName}{typeParams}.{DtCreateName(dtv.Ctor)}({typeDescriptorArguments}{sep}{arguments})");
            }
            else
            {
                var sep0 = MutateCSharp.Schemata219.ReplaceBinExprOp_13(1527L, typeDescriptorArguments.Length, MutateCSharp.Schemata219.ReplaceNumericConstant_4(1523L, 0)) ? MutateCSharp.Schemata219.ReplaceStringConstant_1(1532L, ", ") : "";
                // In the case of a co-recursive call, generate:
                //     new Dt__Lazy<T>( LAMBDA )
                // where LAMBDA is:
                //     () => { return Dt_Cons<T>( ...args... ); }
                wr.Write($"new {dtName}__Lazy{typeParams}({typeDescriptorArguments}{sep0}");
                wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1533L, "() => { return "));
                wr.Write($"new {DtCtorName(dtv.Ctor, dtv.InferredTypeArgs, wr)}({typeDescriptorArguments}{sep}{arguments})");
                wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1534L, "; })"));
            }
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
                    compiledName = idParam == null ? "Length" : $"GetLength({(int)idParam})";
                    if (id == SpecialField.ID.ArrayLength)
                    {
                        preString = "new BigInteger(";
                        postString = ")";
                    }
                    break;
                    break;
                case SpecialField.ID.Floor:
                    compiledName = "ToBigInteger()";
                    break;
                    break;
                case SpecialField.ID.IsLimit:
                    preString = "Dafny.BigOrdinal.IsLimit(";
                    postString = ")";
                    break;
                    break;
                case SpecialField.ID.IsSucc:
                    preString = "Dafny.BigOrdinal.IsSucc(";
                    postString = ")";
                    break;
                    break;
                case SpecialField.ID.Offset:
                    preString = "Dafny.BigOrdinal.Offset(";
                    postString = ")";
                    break;
                    break;
                case SpecialField.ID.IsNat:
                    preString = "Dafny.BigOrdinal.IsNat(";
                    postString = ")";
                    break;
                    break;
                case SpecialField.ID.Keys:
                    compiledName = "Keys";
                    break;
                    break;
                case SpecialField.ID.Values:
                    compiledName = "Values";
                    break;
                    break;
                case SpecialField.ID.Items:
                    var mapType = receiverType.AsMapType;
                    Contract.Assert(mapType != null);
                    var errorWr = new ConcreteSyntaxTree();
                    var domainType = TypeName(mapType.Domain, errorWr, Token.NoToken);
                    var rangeType = TypeName(mapType.Range, errorWr, Token.NoToken);
                    preString = $"{DafnyMapClass}<{domainType}, {rangeType}>.Items(";
                    postString = ")";
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
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_49(1535L, memberStatus, DatatypeWrapperEraser.MemberCompileStatus.Identity))
            {
                return SimpleLvalue(obj);
            }
            else if (MutateCSharp.Schemata219.ReplaceBinExprOp_49(1536L, memberStatus, DatatypeWrapperEraser.MemberCompileStatus.AlwaysTrue))
            {
                return SimpleLvalue(w => w.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1537L, "true")));
            }
            else if (member is SpecialField sf && !(member is ConstantField))
            {
                GetSpecialFieldInfo(sf.SpecialId, sf.IdParam, objType, out string compiledName, out string _, out string _);
                if (MutateCSharp.Schemata219.ReplaceBinExprOp_13(1542L, compiledName.Length, MutateCSharp.Schemata219.ReplaceNumericConstant_4(1538L, 0)))
                {
                    return SuffixLvalue(obj, MutateCSharp.Schemata219.ReplaceStringConstant_1(1547L, ".{0}"), compiledName);
                }
                else
                {
                    // this member selection is handled by some kind of enclosing function call, so nothing to do here
                    return SimpleLvalue(obj);
                }
            }
            else if (member is Function fn)
            {
                var wr = new ConcreteSyntaxTree();
                EmitNameAndActualTypeArgs(IdName(member), TypeArgumentInstantiation.ToActuals(ForTypeParameters(typeArgs, member, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1548L, false))), member.tok, wr);
                if (MutateCSharp.Schemata219.ReplaceBinExprOp_14(1558L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_9(1553L, typeArgs.Count, MutateCSharp.Schemata219.ReplaceNumericConstant_4(1549L, 0)), () => additionalCustomParameter == null))
                {
                    var nameAndTypeArgs = wr.ToString();
                    return SuffixLvalue(obj, $".{nameAndTypeArgs}");
                }
                else
                {
                    // We need an eta conversion to adjust for the difference in arity.
                    // (T0 a0, T1 a1, ...) => obj.F(additionalCustomParameter, a0, a1, ...)
                    var callArguments = wr.ForkInParens();
                    var sep = "";
                    EmitTypeDescriptorsActuals(ForTypeDescriptors(typeArgs, member.EnclosingClass, member, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1564L, false)), fn.tok, callArguments, ref sep);
                    if (additionalCustomParameter != null)
                    {
                        callArguments.Write($"{sep}{additionalCustomParameter}");
                        sep = MutateCSharp.Schemata219.ReplaceStringConstant_1(1565L, ", ");
                    }
                    var lambdaHeader = new ConcreteSyntaxTree();
                    var prefixSep = "";
                    var arguments = lambdaHeader.ForkInParens();
                    lambdaHeader.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1566L, " => "));

                    foreach (var arg in fn.Ins)
                    {
                        if (!arg.IsGhost)
                        {
                            var name = idGenerator.FreshId(MutateCSharp.Schemata219.ReplaceStringConstant_1(1567L, "_eta"));
                            var ty = arg.Type.Subst(typeMap);
                            arguments.Write($"{prefixSep}{TypeName(ty, arguments, arg.tok)} {name}");
                            callArguments.Write($"{sep}{name}");
                            sep = MutateCSharp.Schemata219.ReplaceStringConstant_1(1568L, ", ");
                            prefixSep = MutateCSharp.Schemata219.ReplaceStringConstant_1(1569L, ", ");
                        }
                    }
                    return EnclosedLvalue(lambdaHeader.ToString(), obj, $".{wr}");
                }
            }
            else
            {
                Contract.Assert(member is Field);
                if (member.IsStatic)
                {
                    return SimpleLvalue(w =>
                    {
                        w.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1570L, "{0}.{1}"), TypeName_Companion(objType, w, member.tok, member), IdName(member));
                        var sep = MutateCSharp.Schemata219.ReplaceStringConstant_1(1571L, "(");
                        EmitTypeDescriptorsActuals(ForTypeDescriptors(typeArgs, member.EnclosingClass, member, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1572L, false)), member.tok, w, ref sep);
                        if (MutateCSharp.Schemata219.ReplaceBinExprOp_28(1574L, sep, MutateCSharp.Schemata219.ReplaceStringConstant_1(1573L, "(")))
                        {
                            w.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1575L, ")"));
                        }
                    });
                }
                else if (MutateCSharp.Schemata219.ReplaceBinExprOp_14(1576L, () => NeedsCustomReceiver(member), () => !(member.EnclosingClass is TraitDecl)))
                {
                    // instance const in a newtype or belongs to a datatype
                    Contract.Assert(typeArgs.Count == 0 || member.EnclosingClass is DatatypeDecl);
                    return SimpleLvalue(w =>
                    {
                        w.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1582L, "{0}.{1}("), TypeName_Companion(objType, w, member.tok, member), IdName(member));
                        obj(w);
                        w.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1583L, ")"));
                    });
                }
                else if (MutateCSharp.Schemata219.ReplaceBinExprOp_14(1590L, () => internalAccess, () => (MutateCSharp.Schemata219.ReplaceBinExprOp_10(1584L, () => member is ConstantField, () => member.EnclosingClass is TraitDecl))))
                {
                    return SuffixLvalue(obj, $"._{member.GetCompileName(Options)}");
                }
                else
                {
                    return SimpleLvalue(w =>
                    {
                        obj(w);
                        w.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1596L, ".{0}"), IdName(member));
                        var sep = MutateCSharp.Schemata219.ReplaceStringConstant_1(1597L, "(");
                        EmitTypeDescriptorsActuals(ForTypeDescriptors(typeArgs, member.EnclosingClass, member, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1598L, false)), member.tok, w, ref sep);
                        if (MutateCSharp.Schemata219.ReplaceBinExprOp_28(1600L, sep, MutateCSharp.Schemata219.ReplaceStringConstant_1(1599L, "(")))
                        {
                            w.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1601L, ")"));
                        }
                    });
                }
            }

            return default;
        }

        protected override ConcreteSyntaxTree EmitArraySelect(List<Action<ConcreteSyntaxTree>> indices, Type elmtType, ConcreteSyntaxTree wr)
        {
            Contract.Assert(indices != null && 1 <= indices.Count);  // follows from precondition
            var w = wr.Fork();
            wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1602L, "["));
            var sep = "";
            foreach (var index in indices)
            {
                wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1603L, "{0}(int)("), sep);
                index(wr);
                wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1604L, ")"));
                sep = MutateCSharp.Schemata219.ReplaceStringConstant_1(1605L, ", ");
            }
            wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1606L, "]"));
            return w;
        }

        protected override ConcreteSyntaxTree EmitArraySelect(List<Expression> indices, Type elmtType, bool inLetExprBody,
          ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            Contract.Assert(indices != null && 1 <= indices.Count);  // follows from precondition
            var w = wr.Fork();
            wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1607L, "["));
            var sep = "";
            foreach (var index in indices)
            {
                wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1608L, "{0}(int)"), sep);
                TrParenExpr(index, wr, inLetExprBody, wStmts);
                sep = MutateCSharp.Schemata219.ReplaceStringConstant_1(1609L, ", ");
            }
            wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1610L, "]"));
            return w;
        }

        protected override void EmitExprAsNativeInt(Expression expr, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            TrParenExpr(MutateCSharp.Schemata219.ReplaceStringConstant_1(1611L, "(int)"), expr, wr, inLetExprBody, wStmts);
        }

        protected override void EmitIndexCollectionSelect(Expression source, Expression index, bool inLetExprBody,
          ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var xType = source.Type.NormalizeToAncestorType();
            if (xType is MapType)
            {
                var inner = wr.Write(TypeHelperName(xType, wr, source.tok) + MutateCSharp.Schemata219.ReplaceStringConstant_1(1612L, ".Select")).ForkInParens();
                inner.Append(Expr(source, inLetExprBody, wStmts));
                inner.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1613L, ","));
                inner.Append(Expr(index, inLetExprBody, wStmts));
            }
            else
            {
                TrParenExpr(source, wr, inLetExprBody, wStmts);
                TrParenExpr(MutateCSharp.Schemata219.ReplaceStringConstant_1(1614L, ".Select"), index, wr, inLetExprBody, wStmts);
            }
        }

        protected override void EmitIndexCollectionUpdate(Expression source, Expression index, Expression value,
            CollectionType resultCollectionType, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (resultCollectionType is SeqType or MapType)
            {
                wr.Write(TypeHelperName(resultCollectionType, wr, source.tok) + MutateCSharp.Schemata219.ReplaceStringConstant_1(1615L, ".Update"));
                wr.Append(ParensList(
                  Expr(source, inLetExprBody, wStmts),
                  Expr(index, inLetExprBody, wStmts),
                  CoercedExpr(value, resultCollectionType.ValueArg, inLetExprBody, wStmts)));
            }
            else
            {
                TrParenExpr(source, wr, inLetExprBody, wStmts);
                wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1616L, ".Update"));
                wr.Append(ParensList(
                  Expr(index, inLetExprBody, wStmts),
                  CoercedExpr(value, resultCollectionType.ValueArg, inLetExprBody, wStmts)));
            }
        }

        protected override void EmitSeqSelectRange(Expression source, Expression lo /*?*/, Expression hi /*?*/,
          bool fromArray, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (fromArray)
            {
                wr.Write($"{DafnyHelpersClass}.SeqFromArray");
            }
            TrParenExpr(source, wr, inLetExprBody, wStmts);
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_33(1617L, hi, null))
            {
                if (MutateCSharp.Schemata219.ReplaceBinExprOp_33(1618L, lo, null))
                {
                    wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1619L, ".Subsequence"));
                    wr.Append(ParensList(Expr(lo, inLetExprBody, wStmts), Expr(hi, inLetExprBody, wStmts)));
                }
                else
                {
                    TrParenExpr(MutateCSharp.Schemata219.ReplaceStringConstant_1(1620L, ".Take"), hi, wr, inLetExprBody, wStmts);
                }
            }
            else
            {
                if (MutateCSharp.Schemata219.ReplaceBinExprOp_33(1621L, lo, null))
                {
                    TrParenExpr(MutateCSharp.Schemata219.ReplaceStringConstant_1(1622L, ".Drop"), lo, wr, inLetExprBody, wStmts);
                }
            }
        }

        protected override void EmitSeqConstructionExpr(SeqConstructionExpr expr, bool inLetExprBody, ConcreteSyntaxTree wr,
          ConcreteSyntaxTree wStmts)
        {
            if (expr.Initializer is LambdaExpr lam)
            {
                Contract.Assert(lam.BoundVars.Count == 1);
                EmitSeqConstructionExprFromLambda(expr.N, lam.BoundVars[MutateCSharp.Schemata219.ReplaceNumericConstant_4(1623L, 0)], lam.Body, inLetExprBody, wr);
            }
            else
            {
                wr.Write($"{DafnySeqClass}<{TypeName(expr.Type.NormalizeToAncestorType().AsSeqType.Arg, wr, expr.tok)}>.Create");
                wr.Append(ParensList(Expr(expr.N, inLetExprBody, wStmts), Expr(expr.Initializer, inLetExprBody, wStmts)));
            }
        }

        protected override void EmitSeqBoundedPool(Expression of, bool includeDuplicates, string _, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            TrParenExpr(of, wr, inLetExprBody, wStmts);
            wr.Write(includeDuplicates ? MutateCSharp.Schemata219.ReplaceStringConstant_1(1627L, ".CloneAsArray()") : MutateCSharp.Schemata219.ReplaceStringConstant_1(1628L, ".UniqueElements"));
        }

        // Construct a sequence for the Dafny expression seq(N, F) in the common
        // case that f is a lambda expression.  In that case, rather than
        // something like
        //
        //   var s = Dafny.Sequence.Create(N, i => ...);
        //
        // (which will call the lambda N times), we'd rather write
        //
        //   var dim = N;
        //   var arr = new T[dim];
        //   for (int i = 0; i < dim; i++) {
        //     arr[i] = ...;
        //   }
        //   var s = Dafny.Sequence<T>.FromArray(a);
        //
        // and thus avoid method calls.  Unfortunately, since we can't add
        // statements easily, we have to settle for the slightly clunkier
        //
        //   var s = ((System.Func<Dafny.Sequence<T>>) (() => {
        //     var dim = N;
        //     var arr = new T[dim];
        //     for (int i = 0; i < dim; i++) {
        //       arr[i] = ...;
        //     }
        //     return Dafny.Sequence<T>.FromArray(a);
        //   }))();
        private void EmitSeqConstructionExprFromLambda(Expression lengthExpr, BoundVar boundVar, Expression body, bool inLetExprBody, ConcreteSyntaxTree wr)
        {
            wr.Format($"((System.Func<{TypeName(new SeqType(body.Type), wr, body.tok)}>) (() =>{ExprBlock(out ConcreteSyntaxTree wrLamBody)}))()");

            var indexType = lengthExpr.Type;
            var lengthVar = idGenerator.FreshId(MutateCSharp.Schemata219.ReplaceStringConstant_1(1629L, "dim"));
            DeclareLocalVar(lengthVar, indexType, lengthExpr.tok, lengthExpr, inLetExprBody, wrLamBody);
            var arrVar = idGenerator.FreshId(MutateCSharp.Schemata219.ReplaceStringConstant_1(1630L, "arr"));
            wrLamBody.Write($"var {arrVar} = ");
            var wrDims = EmitNewArray(body.Type, body.tok, dimCount: MutateCSharp.Schemata219.ReplaceNumericConstant_4(1631L, 1), mustInitialize: MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1635L, false), wr: wrLamBody);
            Contract.Assert(wrDims.Count == 1);
            wrDims[MutateCSharp.Schemata219.ReplaceNumericConstant_4(1636L, 0)].Write(lengthVar);
            wrLamBody.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(1640L, ";"));

            var intIxVar = idGenerator.FreshId(MutateCSharp.Schemata219.ReplaceStringConstant_1(1641L, "i"));
            var wrLoopBody = wrLamBody.NewBlock(string.Format(MutateCSharp.Schemata219.ReplaceStringConstant_1(1642L, "for (int {0} = 0; {0} < {1}; {0}++)"), intIxVar, lengthVar));
            var ixVar = IdName(boundVar);
            wrLoopBody.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(1643L, "var {0} = ({1}) {2};"),
              ixVar, TypeName(indexType, wrLoopBody, body.tok), intIxVar);
            var wrArrName = EmitArrayUpdate(new List<Action<ConcreteSyntaxTree>> { wr => wr.Write(ixVar) }, body, wrLoopBody);
            wrArrName.Write(arrVar);
            EndStmt(wrLoopBody);

            wrLamBody.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(1644L, "return {0}<{1}>.FromArray({2});"), DafnySeqClass, TypeName(body.Type, wr, body.tok), arrVar);
        }

        protected override void EmitMultiSetFormingExpr(MultiSetFormingExpr expr, bool inLetExprBody, ConcreteSyntaxTree wr,
            ConcreteSyntaxTree wStmts)
        {
            wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1645L, "{0}<{1}>"), DafnyMultiSetClass, TypeName(expr.E.Type.NormalizeToAncestorType().AsCollectionType.Arg, wr, expr.tok));
            var eeType = expr.E.Type.NormalizeToAncestorType();
            if (eeType is SeqType)
            {
                TrParenExpr(MutateCSharp.Schemata219.ReplaceStringConstant_1(1646L, ".FromSeq"), expr.E, wr, inLetExprBody, wStmts);
            }
            else if (eeType is SetType)
            {
                TrParenExpr(MutateCSharp.Schemata219.ReplaceStringConstant_1(1647L, ".FromSet"), expr.E, wr, inLetExprBody, wStmts);
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();
            }
        }

        protected override void EmitApplyExpr(Type functionType, IToken tok, Expression function, List<Expression> arguments, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write($"{DafnyHelpersClass}.Id<{TypeName(functionType, wr, tok)}>({Expr(function, inLetExprBody, wStmts)})");
            TrExprList(arguments, wr, inLetExprBody, wStmts);
        }

        protected override ConcreteSyntaxTree FromFatPointer(Type type, ConcreteSyntaxTree wr)
        {
            if (type.HasFatPointer)
            {
                var w = wr.ForkInParens();
                wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1648L, "._value"));
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

        protected override ConcreteSyntaxTree EmitDowncast(Type from, Type to, IToken tok, ConcreteSyntaxTree wr)
        {
            from = from.NormalizeExpand();
            to = to.NormalizeExpand();
            Contract.Assert(Options.Get(CommonOptionBag.GeneralTraits) != CommonOptionBag.GeneralTraitsOptions.Legacy || from.IsRefType == to.IsRefType);

            var w = new ConcreteSyntaxTree();
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_14(1650L, () => from.IsTraitType, () => MutateCSharp.Schemata219.ReplaceBinExprOp_29(1649L, to.AsNewtype, null)))
            {
                wr.Format($"(({to.AsNewtype.GetFullCompileName(Options)})({w}))");
            }
            else if (MutateCSharp.Schemata219.ReplaceBinExprOp_10(1662L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_10(1656L, () => to.IsRefType, () => to.IsTraitType), () => from.IsTraitType))
            {
                wr.Format($"(({TypeName(to, wr, tok)})({w}))");
            }
            else
            {
                Contract.Assert(Type.SameHead(from, to));

                var typeArgs = from.IsArrowType ? from.TypeArgs.Concat(to.TypeArgs).ToList() : to.TypeArgs;
                var wTypeArgs = typeArgs.Comma(ta => TypeName(ta, wr, tok));
                var argPairs = Enumerable.Zip(from.TypeArgs, to.TypeArgs);
                if (from.IsArrowType)
                {
                    argPairs = argPairs.Select((tp, i) => MutateCSharp.Schemata219.ReplaceBinExprOp_6(1672L, MutateCSharp.Schemata219.ReplacePrefixUnaryExprOp_5(1668L, ref i), to.TypeArgs.Count) ? (tp.Second, tp.First) : tp);
                }
                var wConverters = argPairs.Comma(t => DowncastConverter(t.Item1, t.Item2, wr, tok));
                DatatypeDecl dt = from.AsDatatype;
                var sep = "";
                var wTypeDescriptorArguments = new ConcreteSyntaxTree();
                if (to is UserDefinedType udt)
                {
                    WriteTypeDescriptors(udt.ResolvedClass, typeArgs, wTypeDescriptorArguments, ref sep);
                }
                if (MutateCSharp.Schemata219.ReplaceBinExprOp_14(1678L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_50(1677L, dt, null), () => DowncastCloneNeedsCustomReceiver(dt)))
                {
                    wr.Format($"{TypeName_Companion(from, wr, tok, null)}.DowncastClone<{wTypeArgs}>({wTypeDescriptorArguments}{sep}{w}, {wConverters})");
                }
                else
                {
                    wr.Format($"({w}).DowncastClone<{wTypeArgs}>({wTypeDescriptorArguments}{sep}{wConverters})");
                }
                Contract.Assert(from.TypeArgs.Count == to.TypeArgs.Count);
            }
            return w;
        }

        bool DowncastCloneNeedsCustomReceiver(DatatypeDecl dt)
        {
            return SelectNonGhost(dt, dt.TypeArgs).Any(ty => MutateCSharp.Schemata219.ReplaceBinExprOp_51(1684L, ty.Variance, TypeParameter.TPVariance.Contra)) ||
                   DatatypeWrapperEraser.IsErasableDatatypeWrapper(Options, dt, out _);
        }

        string DowncastConverter(Type from, Type to, ConcreteSyntaxTree errorWr, IToken tok)
        {
            if (IsTargetSupertype(from, to, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1685L, true)))
            {
                return $"Dafny.Helpers.Id<{TypeName(to, errorWr, tok)}>";
            }
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_52(1686L, from.NormalizeToAncestorType().AsCollectionType, null))
            {
                var sTo = TypeName(to, errorWr, tok);
                // (from x) => { return x.DowncastClone<A, B, ...>(aConverter, bConverter, ...); }
                var wr = new ConcreteSyntaxTree();
                wr.Format($"({TypeName(@from, errorWr, tok)} x) => {{ return {Downcast(from, to, tok, (LineSegment)MutateCSharp.Schemata219.ReplaceStringConstant_1(1687L, "x"))}; }}");
                return wr.ToString();
            }
            // use a type
            return $"Dafny.Helpers.CastConverter<{TypeName(from, errorWr, tok)}, {TypeName(to, errorWr, tok)}>";
        }

        protected override bool TargetLambdaCanUseEnclosingLocals => MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1688L, false);

        protected override ConcreteSyntaxTree EmitBetaRedex(List<string> boundVars, List<Expression> arguments,
          List<Type> boundTypes, Type resultType, IToken tok, bool inLetExprBody, ConcreteSyntaxTree wr,
          ref ConcreteSyntaxTree wStmts)
        {
            var tas = Util.Snoc(boundTypes, resultType);
            var typeArgs = TypeName_UDT(ArrowType.Arrow_FullCompileName, tas.ConvertAll(_ => TypeParameter.TPVariance.Non), tas, wr, tok);
            var result = new ConcreteSyntaxTree();
            wr.Format($"{DafnyHelpersClass}.Id<{typeArgs}>(({boundVars.Comma()}) => {result})");
            TrExprList(arguments, wr, inLetExprBody, wStmts);
            return result;
        }

        protected override void EmitDestructor(Action<ConcreteSyntaxTree> source, Formal dtor, int formalNonGhostIndex, DatatypeCtor ctor, List<Type> typeArgs, Type bvType, ConcreteSyntaxTree wr)
        {
            if (DatatypeWrapperEraser.IsErasableDatatypeWrapper(Options, ctor.EnclosingDatatype, out var coreDtor))
            {
                Contract.Assert(coreDtor.CorrespondingFormals.Count == 1);
                Contract.Assert(dtor == coreDtor.CorrespondingFormals[0]); // any other destructor is a ghost
                source(wr);
            }
            else
            {
                source(wr);
                wr.Write($".{DestructorGetterName(dtor, ctor, formalNonGhostIndex)}");
            }
        }

        private string DestructorGetterName(Formal dtor, DatatypeCtor ctor, int index)
        {
            return $"dtor_{(dtor.HasName ? dtor.CompileName : ctor.GetCompileName(Options) + FieldName(dtor, index))}";
        }

        protected override ConcreteSyntaxTree CreateLambda(List<Type> inTypes, IToken tok, List<string> inNames,
          Type resultType, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts, bool untyped = false)
        {
            // (
            //   (System.Func<inTypes,resultType>)  // cast, which tells C# what the various types involved are
            //   (
            //     (inNames) => {
            //       <<caller fills in body here; must end with a return statement>>
            //     }
            //   )
            // )
            wr = wr.ForkInParens();
            if (!untyped)
            {
                wr.Write($"(System.Func<{inTypes.Concat(new[] { resultType }).Comma(t => TypeName(t, wr, tok))}>)");
            }
            wr.Format($"(({inNames.Comma(nm => nm)}) =>{ExprBlock(out ConcreteSyntaxTree body)})");
            return body;
        }

        protected override void CreateIIFE(string bvName, Type bvType, IToken bvTok, Type bodyType, IToken bodyTok,
          ConcreteSyntaxTree wr, ref ConcreteSyntaxTree wStmts, out ConcreteSyntaxTree wrRhs, out ConcreteSyntaxTree wrBody)
        {
            wrRhs = new ConcreteSyntaxTree();
            wrBody = new ConcreteSyntaxTree();
            wr.Format($"{DafnyHelpersClass}.Let<{TypeName(bvType, wr, bvTok)}, {TypeName(bodyType, wr, bodyTok)}>({wrRhs}, {bvName} => {wrBody})");
        }

        protected override ConcreteSyntaxTree CreateIIFE0(Type resultType, IToken resultTok, ConcreteSyntaxTree wr,
            ConcreteSyntaxTree wStmts)
        {
            // (
            //   (System.Func<resultType>)(() => <<body>>)
            // )()
            wr.Format($"((System.Func<{TypeName(resultType, wr, resultTok)}>)(() =>{ExprBlock(out ConcreteSyntaxTree result)}))()");
            return result;
        }

        protected override ConcreteSyntaxTree CreateIIFE1(int source, Type resultType, IToken resultTok, string bvName,
            ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Format($"{DafnyHelpersClass}.Let<int, {TypeName(resultType, wr, resultTok)}>({source}, {bvName} => {Block(out ConcreteSyntaxTree result)})");
            return result;
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
                    TrParenExpr("~", expr, wr, inLetExprBody, wStmts);
                    break;
                    break;
                case ResolvedUnaryOp.Cardinality:
                    if (expr.Type.NormalizeToAncestorType().AsCollectionType is MultiSetType)
                    {
                        TrParenExpr(expr, wr, inLetExprBody, wStmts);
                        wr.Write(".ElementCount");
                    }
                    else
                    {
                        TrParenExpr("new BigInteger(", expr, wr, inLetExprBody, wStmts);
                        wr.Write(".Count)");
                    }
                    break;
                    break;
                default:
                    Contract.Assert(false); throw new cce.UnreachableException();  // unexpected unary expression
                    break;
            }
        }

        static bool IsDirectlyComparable(Type t)
        {
            Contract.Requires(t != null);
            return MutateCSharp.Schemata219.ReplaceBinExprOp_10(1726L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_10(1720L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_10(1714L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_10(1708L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_10(1701L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_10(1695L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_10(1689L, () => t.IsBoolType, () => t.IsCharType), () => t.IsIntegerType), () => t.IsRealType), () => MutateCSharp.Schemata219.ReplaceBinExprOp_29(1707L, t.AsNewtype, null)), () => t.IsBitVectorType), () => t.IsBigOrdinalType), () => t.IsRefType);
        }

        protected override void CompileBinOp(BinaryExpr.ResolvedOpcode op,
          Expression e0, Expression e1, IToken tok, Type resultType,
          out string opString,
          out string preOpString,
          out string postOpString,
          out string callString,
          out string staticCallString,
          out bool reverseArguments,
          out bool truncateResult,
          out bool convertE1_to_int,
          out bool coerceE1,
          ConcreteSyntaxTree errorWr)
        {

            opString = null;
            preOpString = "";
            postOpString = "";
            callString = null;
            staticCallString = null;
            reverseArguments = MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1732L, false);
            truncateResult = MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1733L, false);
            convertE1_to_int = MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1734L, false);
            coerceE1 = MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1735L, false);

            switch (op)
            {
                case BinaryExpr.ResolvedOpcode.EqCommon:
                    {
                        var eqType = DatatypeWrapperEraser.SimplifyType(Options, e0.Type);
                        if (eqType.IsRefType)
                        {
                            // Dafny's type rules are slightly different C#, so we may need a cast here.
                            // For example, Dafny allows x==y if x:array<T> and y:array<int> and T is some
                            // type parameter.
                            opString = "== (object)";
                        }
                        else if (IsDirectlyComparable(eqType))
                        {
                            opString = "==";
                        }
                        else
                        {
                            staticCallString = "object.Equals";
                        }
                        break;
                    }

                    break;
                case BinaryExpr.ResolvedOpcode.NeqCommon:
                    {
                        var eqType = DatatypeWrapperEraser.SimplifyType(Options, e0.Type);
                        if (eqType.IsRefType)
                        {
                            // Dafny's type rules are slightly different C#, so we may need a cast here.
                            // For example, Dafny allows x==y if x:array<T> and y:array<int> and T is some
                            // type parameter.
                            opString = "!= (object)";
                        }
                        else if (IsDirectlyComparable(eqType))
                        {
                            opString = "!=";
                        }
                        else
                        {
                            preOpString = "!";
                            staticCallString = "object.Equals";
                        }
                        break;
                    }

                    break;
                case BinaryExpr.ResolvedOpcode.LeftShift:
                    {
                        var typeBitwidth = resultType.NormalizeToAncestorType().AsBitVectorType.Width;
                        if (resultType.AsNativeType() is { Bitwidth: (32 or 64) and var targetBitwidth } && targetBitwidth <= typeBitwidth)
                        {
                            // In C#, "<< 32" on "int" and "<< 64" on "long" are the same as "<< 0".
                            staticCallString = $"{DafnyHelpersClass}.Bv{targetBitwidth}ShiftLeft";
                        }
                        else
                        {
                            opString = "<<";
                        }
                        convertE1_to_int = true;
                        truncateResult = true;
                        break;
                    }

                    break;
                case BinaryExpr.ResolvedOpcode.RightShift:
                    {
                        var typeBitwidth = resultType.NormalizeToAncestorType().AsBitVectorType.Width;
                        if (resultType.AsNativeType() is { Bitwidth: (32 or 64) and var targetBitwidth } && targetBitwidth <= typeBitwidth)
                        {
                            // In C#, ">> 32" on "int" and ">> 64" on "long" are the same as ">> 0".
                            staticCallString = $"{DafnyHelpersClass}.Bv{targetBitwidth}ShiftRight";
                        }
                        else
                        {
                            opString = ">>";
                        }
                        convertE1_to_int = true;
                        break;
                    }

                    break;
                case BinaryExpr.ResolvedOpcode.Add:
                    if (resultType.IsCharType)
                    {
                        if (CharIsRune)
                        {
                            staticCallString = $"{DafnyHelpersClass}.AddRunes";
                        }
                        else
                        {
                            opString = "+"; truncateResult = true;
                            preOpString = $"(char)(";
                            postOpString = ")";
                        }
                    }
                    else
                    {
                        opString = "+"; truncateResult = true;
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Sub:
                    if (resultType.IsCharType)
                    {
                        if (CharIsRune)
                        {
                            staticCallString = $"{DafnyHelpersClass}.SubtractRunes";
                        }
                        else
                        {
                            opString = "-"; truncateResult = true;
                            preOpString = $"(char)(";
                            postOpString = ")";
                        }
                    }
                    else
                    {
                        opString = "-"; truncateResult = true;
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Mul:
                    opString = "*"; truncateResult = true; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Div:
                    if (NeedsEuclideanDivision(resultType))
                    {
                        var suffix = AsNativeType(resultType) != null ? "_" + GetNativeTypeName(AsNativeType(resultType)) : "";
                        staticCallString = $"{DafnyHelpersClass}.EuclideanDivision{suffix}";
                    }
                    else
                    {
                        opString = "/";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Mod:
                    if (NeedsEuclideanDivision(resultType))
                    {
                        var suffix = AsNativeType(resultType) != null ? "_" + GetNativeTypeName(AsNativeType(resultType)) : "";
                        staticCallString = $"{DafnyHelpersClass}.EuclideanModulus{suffix}";
                    }
                    else
                    {
                        opString = "%";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.SetEq:
                case BinaryExpr.ResolvedOpcode.MultiSetEq:
                case BinaryExpr.ResolvedOpcode.SeqEq:
                case BinaryExpr.ResolvedOpcode.MapEq:
                    callString = "Equals"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.ProperSubset:
                case BinaryExpr.ResolvedOpcode.ProperMultiSubset:
                    staticCallString = TypeHelperName(e0.Type, errorWr, tok, e1.Type) + ".IsProperSubsetOf"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Subset:
                case BinaryExpr.ResolvedOpcode.MultiSubset:
                    staticCallString = TypeHelperName(e0.Type, errorWr, tok, e1.Type) + ".IsSubsetOf"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Disjoint:
                case BinaryExpr.ResolvedOpcode.MultiSetDisjoint:
                    staticCallString = TypeHelperName(e0.Type, errorWr, tok, e1.Type) + ".IsDisjointFrom"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.InSet:
                case BinaryExpr.ResolvedOpcode.InMultiSet:
                case BinaryExpr.ResolvedOpcode.InMap:
                case BinaryExpr.ResolvedOpcode.InSeq:
                    callString = "Contains"; reverseArguments = true; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Union:
                case BinaryExpr.ResolvedOpcode.MultiSetUnion:
                    staticCallString = TypeHelperName(resultType, errorWr, tok) + ".Union"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.MapMerge:
                    staticCallString = TypeHelperName(resultType, errorWr, tok) + ".Merge"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Intersection:
                case BinaryExpr.ResolvedOpcode.MultiSetIntersection:
                    staticCallString = TypeHelperName(resultType, errorWr, tok) + ".Intersect"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.SetDifference:
                case BinaryExpr.ResolvedOpcode.MultiSetDifference:
                    staticCallString = TypeHelperName(resultType, errorWr, tok) + ".Difference"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.MapSubtraction:
                    staticCallString = TypeHelperName(resultType, errorWr, tok) + ".Subtract"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.ProperPrefix:
                    staticCallString = TypeHelperName(e0.Type, errorWr, e0.tok) + ".IsProperPrefixOf"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Prefix:
                    staticCallString = TypeHelperName(e0.Type, errorWr, e0.tok) + ".IsPrefixOf"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Concat:
                    staticCallString = TypeHelperName(e0.Type, errorWr, e0.tok) + ".Concat"; break;
                    break;
                default:
                    base.CompileBinOp(op, e0, e1, tok, resultType,
                      out opString, out preOpString, out postOpString, out callString, out staticCallString, out reverseArguments, out truncateResult, out convertE1_to_int, out coerceE1,
                      errorWr);
                    break;
                    break;
            }
        }

        protected override void EmitIsZero(string varName, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1736L, "{0} == 0"), varName);
        }

        protected override void EmitConversionExpr(Expression fromExpr, Type fromType, Type toType, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_10(1743L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_10(1737L, () => fromType.IsNumericBased(Type.NumericPersuasion.Int), () => fromType.NormalizeToAncestorType().IsBitVectorType), () => fromType.IsCharType))
            {
                if (toType.IsNumericBased(Type.NumericPersuasion.Real))
                {
                    // (int or bv or char) -> real
                    Contract.Assert(AsNativeType(toType) == null);
                    wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1749L, "new Dafny.BigRational("));
                    if (MutateCSharp.Schemata219.ReplaceBinExprOp_25(1750L, AsNativeType(fromType), null))
                    {
                        wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1751L, "new BigInteger"));
                    }
                    ConvertFromChar(fromExpr, wr, inLetExprBody, wStmts);
                    wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1752L, ", BigInteger.One)"));
                }
                else if (toType.IsCharType)
                {
                    if (fromType.IsCharType)
                    {
                        EmitExpr(fromExpr, inLetExprBody, wr, wStmts);
                    }
                    else if (UnicodeCharEnabled)
                    {
                        wr.Write($"new {CharTypeName}((int)");
                        TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                        wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1753L, ")"));
                    }
                    else
                    {
                        wr.Write($"({CharTypeName})");
                        TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                    }
                }
                else
                {
                    // (int or bv or char) -> (int or bv or ORDINAL)
                    var fromNative = AsNativeType(fromType);
                    var toNative = AsNativeType(toType);
                    if (MutateCSharp.Schemata219.ReplaceBinExprOp_14(1756L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_27(1754L, fromNative, null), () => MutateCSharp.Schemata219.ReplaceBinExprOp_27(1755L, toNative, null)))
                    {
                        if (fromType.IsCharType)
                        {
                            // char -> big-integer (int or bv or ORDINAL)
                            wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1762L, "new BigInteger"));
                            ConvertFromChar(fromExpr, wr, inLetExprBody, wStmts);
                        }
                        else
                        {
                            // big-integer (int or bv) -> big-integer (int or bv or ORDINAL), so identity will do
                            wr.Append(Expr(fromExpr, inLetExprBody, wStmts));
                        }
                    }
                    else if (MutateCSharp.Schemata219.ReplaceBinExprOp_14(1765L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_25(1763L, fromNative, null), () => MutateCSharp.Schemata219.ReplaceBinExprOp_27(1764L, toNative, null)))
                    {
                        // native (int or bv) -> big-integer (int or bv)
                        wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1771L, "new BigInteger"));
                        TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                    }
                    else
                    {
                        GetNativeInfo(toNative.Sel, out string toNativeName, out string toNativeSuffix, out var toNativeNeedsCast);
                        // any (int or bv) -> native (int or bv)
                        // A cast would do, but we also consider some optimizations
                        wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1772L, "({0})"), toNativeName);

                        var literal = PartiallyEvaluate(fromExpr);
                        UnaryOpExpr u = fromExpr.Resolved as UnaryOpExpr;
                        MemberSelectExpr m = fromExpr.Resolved as MemberSelectExpr;
                        if (literal != null)
                        {
                            // Optimize constant to avoid intermediate BigInteger
                            wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1773L, "(") + literal + toNativeSuffix + MutateCSharp.Schemata219.ReplaceStringConstant_1(1774L, ")"));
                        }
                        else if (MutateCSharp.Schemata219.ReplaceBinExprOp_14(1777L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_53(1775L, u, null), () => MutateCSharp.Schemata219.ReplaceBinExprOp_54(1776L, u.Op, UnaryOpExpr.Opcode.Cardinality)))
                        {
                            // Optimize .Count to avoid intermediate BigInteger
                            TrParenExpr(u.E, wr, inLetExprBody, wStmts);
                            if (MutateCSharp.Schemata219.ReplaceBinExprOp_56(1786L, toNative.UpperBound, new BigInteger(MutateCSharp.Schemata219.ReplaceNumericConstant_55(1783L, 0x80000000U))))
                            {
                                wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1788L, ".Count"));
                            }
                            else
                            {
                                wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1789L, ".LongCount"));
                            }
                        }
                        else if (MutateCSharp.Schemata219.ReplaceBinExprOp_14(1799L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_14(1793L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_57(1790L, m, null), () => MutateCSharp.Schemata219.ReplaceBinExprOp_23(1792L, m.MemberName, MutateCSharp.Schemata219.ReplaceStringConstant_1(1791L, "Length"))), () => m.Obj.Type.IsArrayType))
                        {
                            // Optimize .Length to avoid intermediate BigInteger
                            TrParenExpr(m.Obj, wr, inLetExprBody, wStmts);
                            if (MutateCSharp.Schemata219.ReplaceBinExprOp_56(1808L, toNative.UpperBound, new BigInteger(MutateCSharp.Schemata219.ReplaceNumericConstant_55(1805L, 0x80000000U))))
                            {
                                wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1810L, ".Length"));
                            }
                            else
                            {
                                wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1811L, ".LongLength"));
                            }
                        }
                        else
                        {
                            // no optimization applies; use the standard translation
                            ConvertFromChar(fromExpr, wr, inLetExprBody, wStmts);
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
                else
                {
                    // real -> (int or bv or char or ordinal)
                    if (toType.IsCharType)
                    {
                        wr.Write($"({CharTypeName})");
                    }
                    else if (MutateCSharp.Schemata219.ReplaceBinExprOp_25(1812L, AsNativeType(toType), null))
                    {
                        wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1813L, "({0})"), GetNativeTypeName(AsNativeType(toType)));
                    }
                    TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                    wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1814L, ".ToBigInteger()"));
                }
            }
            else if (fromType.IsBigOrdinalType)
            {
                if (MutateCSharp.Schemata219.ReplaceBinExprOp_10(1815L, () => toType.IsNumericBased(Type.NumericPersuasion.Int), () => toType.IsBigOrdinalType))
                {
                    wr.Append(Expr(fromExpr, inLetExprBody, wStmts));
                }
                else if (toType.IsCharType)
                {
                    wr.Write($"({CharTypeName})");
                    TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                }
                else if (toType.IsNumericBased(Type.NumericPersuasion.Real))
                {
                    wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1821L, "new Dafny.BigRational("));
                    if (MutateCSharp.Schemata219.ReplaceBinExprOp_25(1822L, AsNativeType(fromType), null))
                    {
                        wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1823L, "new BigInteger"));
                        TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                        wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1824L, ", BigInteger.One)"));
                    }
                    else
                    {
                        TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                        wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1825L, ", 1)"));
                    }
                }
                else if (toType.NormalizeToAncestorType().IsBitVectorType)
                {
                    // ordinal -> bv
                    var typename = TypeName(toType, wr, null, null);
                    wr.Write($"({typename})");
                    TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                }
                else
                {
                    Contract.Assert(false, $"not implemented for C#: {fromType} -> {toType}");
                }
            }
            else if (MutateCSharp.Schemata219.ReplaceBinExprOp_10(1834L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_10(1827L, () => fromType.Equals(toType), () => MutateCSharp.Schemata219.ReplaceBinExprOp_29(1826L, fromType.AsNewtype, null)), () => MutateCSharp.Schemata219.ReplaceBinExprOp_29(1833L, toType.AsNewtype, null)))
            {
                wr.Append(Expr(fromExpr, inLetExprBody, wStmts));
            }
            else
            {
                Contract.Assert(false, $"not implemented for C#: {fromType} -> {toType}");
            }
        }

        protected override void EmitTypeTest(string localName, Type fromType, Type toType, IToken tok, ConcreteSyntaxTree wr)
        {
            // from T to U:   t is U && ...
            // from T to U?:  t is U && ...                 // since t is known to be non-null, this is fine
            // from T? to U:  t is U && ...                 // note, "is" implies non-null, so no need for explicit null check
            // from T? to U?: t == null || (t is U && ...)
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_14(1852L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_14(1846L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_14(1840L, () => fromType.IsRefType, () => !fromType.IsNonNullRefType), () => toType.IsRefType), () => !toType.IsNonNullRefType))
            {
                wr = wr.Write($"{localName} == null || ").ForkInParens();
            }

            var toTypeString = fromType.IsTraitType && toType.AsNewtype is { } newtypeDecl ? newtypeDecl.GetFullCompileName(Options) : TypeName(toType, wr, tok);
            wr.Write($"{localName} is {toTypeString}");
        }

        protected override void EmitIsIntegerTest(Expression source, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            EmitExpr(source, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1858L, false), wr.ForkInParens(), wStmts);
            wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1859L, ".IsInteger() && "));
        }

        protected override void EmitIsUnicodeScalarValueTest(Expression source, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1860L, "Dafny.Rune.IsRune"));
            EmitExpr(source, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1861L, false), wr.ForkInParens(), wStmts);
            wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1862L, " && "));
        }

        protected override void EmitIsInIntegerRange(Expression source, BigInteger lo, BigInteger hi, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            EmitLiteralExpr(wr, new LiteralExpr(source.tok, lo) { Type = Type.Int });
            wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1863L, " <= "));
            EmitExpr(source, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1864L, false), wr.ForkInParens(), wStmts);
            wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1865L, " && "));

            EmitExpr(source, MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1866L, false), wr.ForkInParens(), wStmts);
            wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1867L, " < "));
            EmitLiteralExpr(wr, new LiteralExpr(source.tok, hi) { Type = Type.Int });
            wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1868L, " && "));
        }

        protected override void EmitCollectionDisplay(CollectionType ct, IToken tok, List<Expression> elements,
            bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1869L, "{0}.FromElements"), TypeHelperName(ct, wr, tok));
            TrExprList(elements, wr, inLetExprBody, wStmts, typeAt: _ => ct.Arg);
        }

        protected override void EmitMapDisplay(MapType mt, IToken tok, List<ExpressionPair> elements,
            bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var arguments = elements.Select(p =>
            {
                var result = new ConcreteSyntaxTree();
                result.Format($"new Dafny.Pair{BracketList((LineSegment)TypeName(p.A.Type, result, p.A.tok), (LineSegment)TypeName(p.B.Type, result, p.B.tok))}");
                result.Append(ParensList(Expr(p.A, inLetExprBody, wStmts), Expr(p.B, inLetExprBody, wStmts)));
                return result;
            }).ToArray<ICanRender>();
            wr.Write($"{TypeHelperName(mt, wr, tok)}.FromElements{ParensList(arguments)}");
        }

        protected override void EmitSetBuilder_New(ConcreteSyntaxTree wr, SetComprehension e, string collectionName)
        {
            var wrVarInit = DeclareLocalVar(collectionName, null, null, wr);
            wrVarInit.Write(MutateCSharp.Schemata219.ReplaceStringConstant_1(1870L, "new System.Collections.Generic.List<{0}>()"), TypeName(e.Type.NormalizeToAncestorType().AsSetType.Arg, wrVarInit, e.tok));
        }

        protected override void EmitMapBuilder_New(ConcreteSyntaxTree wr, MapComprehension e, string collectionName)
        {
            var wrVarInit = DeclareLocalVar(collectionName, null, null, wr);
            var mt = e.Type.NormalizeToAncestorType().AsMapType;
            var domtypeName = TypeName(mt.Domain, wrVarInit, e.tok);
            var rantypeName = TypeName(mt.Range, wrVarInit, e.tok);
            wrVarInit.Write($"new System.Collections.Generic.List<Dafny.Pair<{domtypeName},{rantypeName}>>()");
        }

        protected override void EmitSetBuilder_Add(CollectionType ct, string collName, Expression elmt, bool inLetExprBody, ConcreteSyntaxTree wr)
        {
            if (ct is SetType)
            {
                var wStmts = wr.Fork();
                wr.FormatLine($"{collName}.Add({Expr(elmt, inLetExprBody, wStmts)});");
            }
            else
            {
                Contract.Assume(false);  // unexpected collection type
            }
        }

        protected override ConcreteSyntaxTree EmitMapBuilder_Add(MapType mt, IToken tok, string collName, Expression term, bool inLetExprBody, ConcreteSyntaxTree wr)
        {
            var domtypeName = TypeName(mt.Domain, wr, tok);
            var rantypeName = TypeName(mt.Range, wr, tok);
            var termLeftWriter = new ConcreteSyntaxTree();
            var wStmts = wr.Fork();
            wr.FormatLine($"{collName}.Add(new Dafny.Pair<{domtypeName},{rantypeName}>{ParensList(termLeftWriter, Expr(term, inLetExprBody, wStmts))});");
            return termLeftWriter;
        }

        protected override void GetCollectionBuilder_Build(CollectionType ct, IToken tok, string collName,
          ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmt)
        {
            if (ct is SetType)
            {
                var typeName = TypeName(ct.Arg, wr, tok);
                wr.Write(string.Format($"{DafnySetClass}<{typeName}>.FromCollection({collName})"));
            }
            else if (ct is MapType)
            {
                var mt = (MapType)ct;
                var domtypeName = TypeName(mt.Domain, wr, tok);
                var rantypeName = TypeName(mt.Range, wr, tok);
                wr.Write($"{DafnyMapClass}<{domtypeName},{rantypeName}>.FromCollection({collName})");
            }
            else
            {
                Contract.Assume(false);  // unexpected collection type
                throw new cce.UnreachableException();  // please compiler
            }
        }

        protected override void EmitSingleValueGenerator(Expression e, bool inLetExprBody, string type, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write($"{DafnyHelpersClass}.SingleValue<{type}>");
            TrParenExpr(e, wr, inLetExprBody, wStmts);
        }

        private void AddTestCheckerIfNeeded(string name, Declaration decl, ConcreteSyntaxTree wr)
        {
            if (MutateCSharp.Schemata219.ReplaceBinExprOp_10(1878L, () => MutateCSharp.Schemata219.ReplaceBinExprOp_10(1871L, () => Options.Compile, () => Options.Get(RunAllTestsMainMethod.IncludeTestRunner)), () => !Attributes.Contains(decl.Attributes, MutateCSharp.Schemata219.ReplaceStringConstant_1(1877L, "test"))))
            {
                return;
            }

            var firstReturnIsFailureCompatible = MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1884L, false);
            var returnTypesCount = MutateCSharp.Schemata219.ReplaceNumericConstant_4(1885L, 0);

            if (decl is Function func)
            {
                returnTypesCount = MutateCSharp.Schemata219.ReplaceNumericConstant_4(1889L, 1);
                firstReturnIsFailureCompatible =
                  func.ResultType?.AsTopLevelTypeWithMembers?.Members?.Any(m => MutateCSharp.Schemata219.ReplaceBinExprOp_23(1894L, m.Name, MutateCSharp.Schemata219.ReplaceStringConstant_1(1893L, "IsFailure"))) ?? MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1895L, false);
            }
            else if (decl is Method method)
            {
                returnTypesCount = method.Outs.Count;
                if (MutateCSharp.Schemata219.ReplaceBinExprOp_15(1900L, returnTypesCount, MutateCSharp.Schemata219.ReplaceNumericConstant_4(1896L, 0)))
                {
                    firstReturnIsFailureCompatible =
                      method.Outs[MutateCSharp.Schemata219.ReplaceNumericConstant_4(1905L, 0)].Type?.AsTopLevelTypeWithMembers?.Members?.Any(m => MutateCSharp.Schemata219.ReplaceBinExprOp_23(1910L, m.Name, MutateCSharp.Schemata219.ReplaceStringConstant_1(1909L, "IsFailure"))) ?? MutateCSharp.Schemata219.ReplaceBooleanConstant_0(1911L, false);
                }
            }

            wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(1912L, "[Xunit.Fact]"));
            if (!firstReturnIsFailureCompatible)
            {
                return;
            }

            wr = wr.NewNamedBlock(MutateCSharp.Schemata219.ReplaceStringConstant_1(1913L, "public static void {0}_CheckForFailureForXunit()"), name);
            var returnsString = string.Join(MutateCSharp.Schemata219.ReplaceStringConstant_1(1914L, ","), Enumerable.Range(MutateCSharp.Schemata219.ReplaceNumericConstant_4(1915L, 0), returnTypesCount).Select(i => $"r{i}"));
            wr.FormatLine($"var {returnsString} = {name}();");
            wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(1919L, "Xunit.Assert.False(r0.IsFailure(), \"Dafny test failed: \" + r0);"));

        }

        public override void EmitCallToMain(Method mainMethod, string baseName, ConcreteSyntaxTree wr)
        {
            var companion = TypeName_Companion(UserDefinedType.FromTopLevelDeclWithAllBooleanTypeParameters(mainMethod.EnclosingClass), wr, mainMethod.tok, mainMethod);
            var wClass = wr.NewNamedBlock(MutateCSharp.Schemata219.ReplaceStringConstant_1(1920L, "class __CallToMain"));
            var wBody = wClass.NewNamedBlock(MutateCSharp.Schemata219.ReplaceStringConstant_1(1921L, "public static void Main(string[] args)"));
            var modName = mainMethod.EnclosingClass.EnclosingModuleDefinition.TryToAvoidName ? MutateCSharp.Schemata219.ReplaceStringConstant_1(1922L, "_module.") : "";
            companion = modName + companion;

            var idName = IssueCreateStaticMain(mainMethod) ? MutateCSharp.Schemata219.ReplaceStringConstant_1(1923L, "_StaticMain") : IdName(mainMethod);

            Coverage.EmitSetup(wBody);
            wBody.WriteLine($"{GetHelperModuleName()}.WithHaltHandling(() => {companion}.{idName}(Dafny.Sequence<Dafny.ISequence<{CharTypeName}>>.{CharMethodQualifier}FromMainArguments(args)));");
            Coverage.EmitTearDown(wBody);
        }

        protected override void EmitHaltRecoveryStmt(Statement body, string haltMessageVarName, Statement recoveryBody, ConcreteSyntaxTree wr)
        {
            var tryBlock = wr.NewBlock(MutateCSharp.Schemata219.ReplaceStringConstant_1(1924L, "try"));
            TrStmt(body, tryBlock);
            var catchBlock = wr.NewBlock(MutateCSharp.Schemata219.ReplaceStringConstant_1(1925L, "catch (Dafny.HaltException e)"));
            catchBlock.WriteLine($"var {haltMessageVarName} = Dafny.Sequence<{CharTypeName}>.{CharMethodQualifier}FromString(e.Message);");
            TrStmt(recoveryBody, catchBlock);
        }

        protected void EmitCoverageReportInstrumentation(Program program, ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata219.ReplaceStringConstant_1(1926L, @"
namespace DafnyProfiling {
  public class CodeCoverage {
    static uint[] tallies;
    static string talliesFileName;
    public static void Setup(int size, string theTalliesFileName) {
      tallies = new uint[size];
      talliesFileName = theTalliesFileName;
    }
    public static void TearDown() {
      using TextWriter talliesWriter = new StreamWriter(
        new FileStream(talliesFileName, FileMode.Create));
      for (var i = 0; i < tallies.Length; i++) {
        talliesWriter.WriteLine(""{0}"", tallies[i]);
      }
      tallies = null;
    }
    public static bool Record(int id) {
      tallies[id]++;
      return true;
    }
  }
}"));
        }
    }
}
