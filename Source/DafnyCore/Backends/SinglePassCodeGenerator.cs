//-----------------------------------------------------------------------------
//
// Copyright (C) Microsoft Corporation.  All Rights Reserved.
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.Linq;
using System.Numerics;
using System.IO;
using System.Diagnostics.Contracts;
using DafnyCore;
using JetBrains.Annotations;
using Microsoft.BaseTypes;
using static Microsoft.Dafny.GeneratorErrors;
namespace MutateCSharp
{
    internal class Schemata247
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT247");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_55(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_81(long mutantId, System.Numerics.BigInteger? argument1, System.Numerics.BigInteger argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceNumericConstant_3(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_23(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_61(long mutantId, Microsoft.Dafny.ConcreteUpdateStatement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_26(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.Method argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_46(long mutantId, Microsoft.Dafny.MultiSetType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_31(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_72(long mutantId, Microsoft.Dafny.SpecialField argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_24(long mutantId, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument1, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_34(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, Microsoft.Dafny.NewtypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_28(long mutantId, Microsoft.Dafny.SubsetTypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_69(long mutantId, Microsoft.Dafny.Compilers.SinglePassCodeGenerator.ILvalue argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_50(long mutantId, Microsoft.Dafny.IVariable argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_65(long mutantId, Microsoft.Dafny.TypeRhs argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.SeqType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_39(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Type> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_74(long mutantId, Microsoft.Dafny.NativeType.Selection? argument1, Microsoft.Dafny.NativeType.Selection argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_42(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_43(long mutantId, Microsoft.Dafny.Method argument1, Microsoft.Dafny.Method argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_33(long mutantId, string argument1, string argument2)
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

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.Function argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_56(long mutantId, Microsoft.Dafny.UpdateStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_53(long mutantId, Microsoft.Dafny.ArrayClassDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_45(long mutantId, Microsoft.Dafny.SetType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplacePrefixUnaryExprOp_80(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return +argument1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return ~argument1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return ++argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return --argument1; }
            return -argument1;
        }

        internal static bool ReplaceBinExprOp_51(long mutantId, Microsoft.Dafny.BinaryExpr.AccumulationOperand argument1, Microsoft.Dafny.BinaryExpr.AccumulationOperand argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_54(long mutantId, Microsoft.Dafny.TypeParameter.TPVariance argument1, Microsoft.Dafny.TypeParameter.TPVariance argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_52(long mutantId, System.Numerics.BigInteger argument1, System.Numerics.BigInteger argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_64(long mutantId, Microsoft.Dafny.IVariable argument1, Microsoft.Dafny.BoundVar argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_2(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_27(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, Microsoft.Dafny.TypeParameter.TPVariance argument1, Microsoft.Dafny.TypeParameter.TPVariance argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_59(long mutantId, Microsoft.Dafny.ForallStmt.BodyKind argument1, Microsoft.Dafny.ForallStmt.BodyKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_25(long mutantId, Microsoft.Dafny.NativeType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_30(long mutantId, Microsoft.Dafny.Compilers.SinglePassCodeGenerator.IClassWriter argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_67(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.TypeParameter> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_66(long mutantId, Microsoft.Dafny.CallStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.IndDatatypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_44(long mutantId, Microsoft.Dafny.Function.TailStatus argument1, Microsoft.Dafny.Function.TailStatus argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_57(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_40(long mutantId, Microsoft.Dafny.ConcreteSyntaxTree argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_29(long mutantId, int? argument1, int? argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_63(long mutantId, Microsoft.Dafny.MemberDecl argument1, Microsoft.Dafny.MemberDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_68(long mutantId, Microsoft.Dafny.TraitDecl argument1, Microsoft.Dafny.TraitDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_76(long mutantId, System.Action<Microsoft.Dafny.ConcreteSyntaxTree> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_36(long mutantId, Microsoft.Dafny.Method argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_7(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_32(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Formal> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_47(long mutantId, Microsoft.Dafny.Method argument1, Microsoft.Dafny.Method argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_49(long mutantId, Microsoft.Dafny.TopLevelDeclWithMembers argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_75(long mutantId, Microsoft.Dafny.BitvectorType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceBinExprOp_37(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_73(long mutantId, Microsoft.Dafny.UnaryOpExpr.ResolvedOpcode argument1, Microsoft.Dafny.UnaryOpExpr.ResolvedOpcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_58(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.Constructor argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_77(long mutantId, Microsoft.Dafny.BoundVar argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_79(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.CasePattern<Microsoft.Dafny.BoundVar>> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.ModuleKindEnum argument1, Microsoft.Dafny.ModuleKindEnum argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBinExprOp_62(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.BoundedPool> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_70(long mutantId, Microsoft.Dafny.LList<Microsoft.Dafny.Label> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_60(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_78(long mutantId, Microsoft.Dafny.BoundVar argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_71(long mutantId, System.Func<int, Microsoft.Dafny.Type> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_41(long mutantId, Microsoft.Dafny.Function argument1, Microsoft.Dafny.Function argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_48(long mutantId, Microsoft.Dafny.LocalVariable argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_38(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePrefixUnaryExprOp_10(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return ++argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return +argument1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return ~argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return --argument1; }
            return ++argument1;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_35(long mutantId, Microsoft.Dafny.TopLevelDeclWithMembers argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

    }
}

namespace Microsoft.Dafny.Compilers
{
    public
      static class SinglePassCompilerExtensions
    {
        public static bool CanCompile(this ModuleDefinition module)
        {
            return MutateCSharp.Schemata247.ReplaceBinExprOp_0(1L, module.ModuleKind, ModuleKindEnum.Concrete);
        }
    }

    public abstract class SinglePassCodeGenerator
    {
        public DafnyOptions Options { get; }

        /// <summary>
        /// Emits a call to <c>mainMethod</c> as the program's entry point, if such an explicit call is
        /// required in the target language.
        /// </summary>
        public abstract void EmitCallToMain(Method mainMethod, string baseName, ConcreteSyntaxTree callToMainTree);

        /// <summary>
        /// Change <c>name</c> into a valid identifier in the target language.
        /// </summary>
        public abstract string PublicIdProtect(string name);

        public static Plugin Plugin =
          new ConfiguredPlugin(InternalBackendsPluginConfiguration.Singleton);

        public abstract IReadOnlySet<Feature> UnsupportedFeatures { get; }

        /// <summary>
        /// Whether or not the compiler turns
        ///     datatype Record = R(oneThing: X)
        /// into just X, including the case where "Record" is a tuple type with 1 non-ghost component.
        /// </summary>
        public virtual bool SupportsDatatypeWrapperErasure => MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2L, true);
        public static string DefaultNameMain = MutateCSharp.Schemata247.ReplaceStringConstant_2(3L, "Main");

        public virtual string ModuleSeparator => MutateCSharp.Schemata247.ReplaceStringConstant_2(4L, ".");
        protected virtual string StaticClassAccessor => MutateCSharp.Schemata247.ReplaceStringConstant_2(5L, ".");
        protected virtual string InstanceClassAccessor => MutateCSharp.Schemata247.ReplaceStringConstant_2(6L, ".");
        protected virtual string IsMethodName => MutateCSharp.Schemata247.ReplaceStringConstant_2(7L, "_Is");

        public ErrorReporter Reporter;

        Stack<ConcreteSyntaxTree> copyInstrWriters = new Stack<ConcreteSyntaxTree>(); // a buffer that stores copy instructions generated by letExpr that uses out param.
        protected TopLevelDeclWithMembers thisContext;  // non-null when type members are being translated
        protected ModuleDefinition enclosingModule; // non-null when a module body is being translated
        protected Method enclosingMethod;  // non-null when a method body is being translated
        protected Function enclosingFunction;  // non-null when a function body is being translated

        protected internal readonly FreshIdGenerator idGenerator = new FreshIdGenerator();

        private protected string ProtectedFreshId(string prefix) => IdProtect(idGenerator.FreshId(prefix));
        private protected string ProtectedFreshNumericId(string prefix) => IdProtect(idGenerator.FreshNumericId(prefix));

        Dictionary<Expression, int> uniqueAstNumbers = new Dictionary<Expression, int>();
        int GetUniqueAstNumber(Expression expr)
        {
            Contract.Requires(expr != null);
            if (!uniqueAstNumbers.TryGetValue(expr, out var n))
            {
                n = uniqueAstNumbers.Count;
                uniqueAstNumbers.Add(expr, n);
            }
            return n;
        }

        public readonly CoverageInstrumenter Coverage;

        // Common limits on the size of builtins: tuple, arrow, and array types.
        // Some backends have to enforce limits so that all built-ins can be pre-compiled
        // into their runtimes.
        // See CheckCommonSytemModuleLimits().

        protected int MaxTupleNonGhostDims => MutateCSharp.Schemata247.ReplaceNumericConstant_3(8L, 20);
        // This one matches the maximum arity of the C# System.Func<> type used to implement arrows. 
        protected int MaxArrowArity => MutateCSharp.Schemata247.ReplaceNumericConstant_3(12L, 16);
        // This one is also limited by the maximum arrow arity, since a given array type
        // uses an arrow of the matching arity for initialization.
        protected int MaxArrayDims => MaxArrowArity;

        protected SinglePassCodeGenerator(DafnyOptions options, ErrorReporter reporter)
        {
            this.Options = options;
            Reporter = reporter;
            Coverage = new CoverageInstrumenter(this);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(GeneratorErrors).TypeHandle);
        }

        protected static void ReportError(ErrorId errorId, ErrorReporter reporter, IToken tok, string msg, ConcreteSyntaxTree/*?*/ wr, params object[] args)
        {
            Contract.Requires(msg != null);
            Contract.Requires(args != null);

            reporter.Error(MessageSource.Compiler, errorId, tok, msg, args);
            wr?.WriteLine(MutateCSharp.Schemata247.ReplaceStringConstant_2(16L, "/* {0} */"), string.Format(MutateCSharp.Schemata247.ReplaceStringConstant_2(17L, "Compilation error: ") + msg, args));
        }

        public void Error(ErrorId errorId, IToken tok, string msg, ConcreteSyntaxTree wr, params object[] args)
        {
            ReportError(errorId, Reporter, tok, msg, wr, args);
        }

        protected void UnsupportedFeatureError(IToken tok, Feature feature, string message = null, ConcreteSyntaxTree wr = null, params object[] args)
        {
            if (!UnsupportedFeatures.Contains(feature))
            {
                throw new Exception($"'{feature}' is not an element of the {GetType().Name} compiler's UnsupportedFeatures set");
            }

            message ??= UnsupportedFeatureException.MessagePrefix + FeatureDescriptionAttribute.GetDescription(feature).Description;
            Error(ErrorId.c_unsupported_feature, tok, message, wr, args);
        }

        protected string IntSelect = MutateCSharp.Schemata247.ReplaceStringConstant_2(18L, ",int");
        protected string LambdaExecute = "";

        protected bool UnicodeCharEnabled => Options.Get(CommonOptionBag.UnicodeCharacters);

        protected string CharMethodQualifier => UnicodeCharEnabled ? MutateCSharp.Schemata247.ReplaceStringConstant_2(19L, "Unicode") : "";

        protected virtual void EmitHeader(Program program, ConcreteSyntaxTree wr) { }
        protected virtual void EmitFooter(Program program, ConcreteSyntaxTree wr) { }
        /// <summary>
        /// Emits any supporting code necessary for built-in Dafny elements,
        /// such as the `nat` subset type, or array and arrow types of various arities.
        /// These built-in elements are generally declared in the internal _System module
        /// by the SystemModuleManager.
        /// Some of them are emitted by compiling their declarations in that module, such as tuples.
        /// Others have {:compile false} added, so they are not normally given to the compiler at all,
        /// but instead need special handling in this method.
        /// 
        /// It would likely be cleaner in the future to remove all of the {:compile false} attributes
        /// on built-in declarations, and allow compilers to handle them directly
        /// (which for many backends just means ignoring many of them).
        /// </summary>
        protected virtual void EmitBuiltInDecls(SystemModuleManager systemModuleManager, ConcreteSyntaxTree wr) { }

        protected void CheckCommonSytemModuleLimits(SystemModuleManager systemModuleManager)
        {
            // Check that the runtime already has all required builtins
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_4(20L, systemModuleManager.MaxNonGhostTupleSizeUsed, MaxTupleNonGhostDims))
            {
                UnsupportedFeatureError(systemModuleManager.MaxNonGhostTupleSizeToken, Feature.TuplesWiderThan20);
            }
            var maxArrowArity = systemModuleManager.ArrowTypeDecls.Keys.Max();
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_4(25L, maxArrowArity, MaxArrowArity))
            {
                UnsupportedFeatureError(Token.NoToken, Feature.ArrowsWithMoreThan16Arguments);
            }
            var maxArraysDims = systemModuleManager.arrayTypeDecls.Keys.Max();
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_4(30L, maxArraysDims, MaxArrayDims))
            {
                UnsupportedFeatureError(Token.NoToken, Feature.ArraysWithMoreThan16Dims);
            }
        }

        /// <summary>
        /// Checks that the system module contains all sizes of built-in types up to the maximum.
        /// See also DafnyRuntime/systemModulePopulator.dfy.
        /// </summary>
        protected void CheckSystemModulePopulatedToCommonLimits(SystemModuleManager systemModuleManager)
        {
            systemModuleManager.CheckHasAllTupleNonGhostDimsUpTo(MaxTupleNonGhostDims);
            systemModuleManager.CheckHasAllArrayDimsUpTo(MaxArrayDims);
            systemModuleManager.CheckHasAllArrowAritiesUpTo(MaxArrowArity);
        }

        /// <summary>
        /// Creates a static Main method. The caller will fill the body of this static Main with a
        /// call to the instance Main method in the enclosing class.
        /// </summary>
        protected abstract ConcreteSyntaxTree CreateStaticMain(IClassWriter wr, string argsParameterName);
        protected abstract ConcreteSyntaxTree CreateModule(string moduleName, bool isDefault, ModuleDefinition externModule,
          string libraryName /*?*/, ConcreteSyntaxTree wr);
        /// <summary>
        /// Indicates the current program depends on the given module without creating it.
        /// Called when a module is out of scope for compilation, such as when using --library.
        /// </summary>
        protected virtual void DependOnModule(Program program, ModuleDefinition module, ModuleDefinition externModule,
          string libraryName /*?*/)
        { }
        protected abstract string GetHelperModuleName();

        public interface IClassWriter
        {
            ConcreteSyntaxTree/*?*/ CreateMethod(Method m, List<TypeArgumentInstantiation> typeArgs, bool createBody, bool forBodyInheritance, bool lookasideBody);
            ConcreteSyntaxTree/*?*/ SynthesizeMethod(Method m, List<TypeArgumentInstantiation> typeArgs, bool createBody, bool forBodyInheritance, bool lookasideBody);
            ConcreteSyntaxTree/*?*/ CreateFunction(string name, List<TypeArgumentInstantiation> typeArgs, List<Formal> formals, Type resultType, IToken tok, bool isStatic, bool createBody,
              MemberDecl member, bool forBodyInheritance, bool lookasideBody);
            ConcreteSyntaxTree/*?*/ CreateGetter(string name, TopLevelDecl enclosingDecl, Type resultType, IToken tok, bool isStatic, bool isConst, bool createBody, MemberDecl/*?*/ member, bool forBodyInheritance);  // returns null iff !createBody
            ConcreteSyntaxTree/*?*/ CreateGetterSetter(string name, Type resultType, IToken tok, bool createBody, MemberDecl/*?*/ member, out ConcreteSyntaxTree setterWriter, bool forBodyInheritance);  // if createBody, then result and setterWriter are non-null, else both are null
            void DeclareField(string name, TopLevelDecl enclosingDecl, bool isStatic, bool isConst, Type type, IToken tok, string rhs, Field/*?*/ field);
            /// <summary>
            /// InitializeField is called for inherited fields. It is in lieu of calling DeclareField and is called only if
            /// ClassesRedeclareInheritedFields==false for the compiler.
            /// </summary>
            void InitializeField(Field field, Type instantiatedFieldType, TopLevelDeclWithMembers enclosingClass);
            ConcreteSyntaxTree/*?*/ ErrorWriter();
            void Finish();
        }
        protected virtual bool IncludeExternMembers { get => MutateCSharp.Schemata247.ReplaceBooleanConstant_1(35L, false); }

        protected virtual bool SupportsStaticsInGenericClasses => MutateCSharp.Schemata247.ReplaceBooleanConstant_1(36L, true);
        protected virtual bool TraitRepeatsInheritedDeclarations => MutateCSharp.Schemata247.ReplaceBooleanConstant_1(37L, false);
        protected IClassWriter CreateClass(string moduleName, string name, TopLevelDecl cls, ConcreteSyntaxTree wr)
        {
            return CreateClass(moduleName, name, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(38L, false), null, cls.TypeArgs,
              cls, (cls as TopLevelDeclWithMembers)?.ParentTypeInformation.UniqueParentTraits(), null, wr);
        }

        /// <summary>
        /// "tok" can be "null" if "superClasses" is.
        /// </summary>
        protected abstract IClassWriter CreateClass(string moduleName, string name, bool isExtern, string/*?*/ fullPrintName,
          List<TypeParameter> typeParameters, TopLevelDecl cls, List<Type>/*?*/ superClasses, IToken tok, ConcreteSyntaxTree wr);

        /// <summary>
        /// "tok" can be "null" if "superClasses" is.
        /// </summary>
        protected abstract IClassWriter CreateTrait(string name, bool isExtern, List<TypeParameter> typeParameters /*?*/,
          TraitDecl trait, List<Type> superClasses /*?*/, IToken tok, ConcreteSyntaxTree wr);
        protected virtual bool SupportsProperties => MutateCSharp.Schemata247.ReplaceBooleanConstant_1(39L, true);
        protected abstract ConcreteSyntaxTree CreateIterator(IteratorDecl iter, ConcreteSyntaxTree wr);
        /// <summary>
        /// Returns an IClassWriter that can be used to write additional members. If "dt" is already written
        /// in the DafnyRuntime.targetlanguage file, then returns "null".
        /// </summary>
        protected abstract IClassWriter/*?*/ DeclareDatatype(DatatypeDecl dt, ConcreteSyntaxTree wr);
        protected virtual bool DatatypeDeclarationAndMemberCompilationAreSeparate => MutateCSharp.Schemata247.ReplaceBooleanConstant_1(40L, true);
        /// <summary>
        /// Returns an IClassWriter that can be used to write additional members.
        /// </summary>
        protected abstract IClassWriter DeclareNewtype(NewtypeDecl nt, ConcreteSyntaxTree wr);
        protected abstract void DeclareSubsetType(SubsetTypeDecl sst, ConcreteSyntaxTree wr);
        protected string GetNativeTypeName(NativeType nt)
        {
            Contract.Requires(nt != null);
            GetNativeInfo(nt.Sel, out var nativeName, out _, out _);
            return nativeName;
        }
        protected abstract void GetNativeInfo(NativeType.Selection sel, out string name, out string literalSuffix, out bool needsCastAfterArithmetic);

        protected List<T> SelectNonGhost<T>(TopLevelDecl cl, List<T> elements)
        {
            Contract.Requires(cl != null && elements != null);
            if (cl is TupleTypeDecl tupleDecl)
            {
                Contract.Assert(elements.Count == tupleDecl.Dims);
                return elements.Where((_, i) => !tupleDecl.ArgumentGhostness[i]).ToList();
            }
            else
            {
                return elements;
            }

            return default;
        }

        protected virtual List<TypeParameter> UsedTypeParameters(DatatypeDecl dt, bool alsoIncludeAutoInitTypeParameters = false)
        {
            Contract.Requires(dt != null);

            var idt = dt as IndDatatypeDecl;
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_5(41L, idt, null))
            {
                return dt.TypeArgs;
            }
            else
            {
                Contract.Assert(idt.TypeArgs.Count == idt.TypeParametersUsedInConstructionByGroundingCtor.Length);
                var tps = new List<TypeParameter>();
                for (int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(42L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(46L, i, idt.TypeArgs.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(51L, ref i))
                {
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_9(58L, () => idt.TypeParametersUsedInConstructionByGroundingCtor[i], () => (MutateCSharp.Schemata247.ReplaceBinExprOp_8(52L, () => alsoIncludeAutoInitTypeParameters, () => NeedsTypeDescriptor(idt.TypeArgs[i])))))
                    {
                        tps.Add(idt.TypeArgs[i]);
                    }
                }
                return tps;
            }

            return default;
        }

        protected List<TypeArgumentInstantiation> UsedTypeParameters(DatatypeDecl dt, List<Type> typeArgs, bool alsoIncludeAutoInitTypeParameters = false)
        {
            Contract.Requires(dt != null);
            Contract.Requires(typeArgs != null);
            Contract.Requires(dt.TypeArgs.Count == typeArgs.Count);

            if (dt is not IndDatatypeDecl idt)
            {
                return TypeArgumentInstantiation.ListFromClass(dt, typeArgs);
            }
            else
            {
                Contract.Assert(typeArgs.Count == idt.TypeParametersUsedInConstructionByGroundingCtor.Length);
                var r = new List<TypeArgumentInstantiation>();
                for (int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(64L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(68L, i, typeArgs.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(73L, ref i))
                {
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_9(80L, () => idt.TypeParametersUsedInConstructionByGroundingCtor[i], () => (MutateCSharp.Schemata247.ReplaceBinExprOp_8(74L, () => alsoIncludeAutoInitTypeParameters, () => NeedsTypeDescriptor(idt.TypeArgs[i])))))
                    {
                        r.Add(new TypeArgumentInstantiation(dt.TypeArgs[i], typeArgs[i]));
                    }
                }
                return r;
            }

            return default;
        }

        protected bool NeedsTypeDescriptors(List<TypeArgumentInstantiation> typeArgs)
        {
            Contract.Requires(typeArgs != null);
            return typeArgs.Any(ta => NeedsTypeDescriptor(ta.Formal));
        }

        protected virtual bool NeedsTypeDescriptor(TypeParameter tp)
        {
            Contract.Requires(tp != null);
            return tp.Characteristics.HasCompiledValue;
        }

        protected abstract string TypeDescriptor(Type type, ConcreteSyntaxTree wr, IToken tok);

        protected void EmitTypeDescriptorsActuals(List<TypeArgumentInstantiation> typeArgs, IToken tok, ConcreteSyntaxTree wr, bool useAllTypeArgs = false)
        {
            var prefix = "";
            EmitTypeDescriptorsActuals(typeArgs, tok, wr, ref prefix, useAllTypeArgs);
        }

        protected void EmitTypeDescriptorsActuals(List<TypeArgumentInstantiation> typeArgs, IToken tok, ConcreteSyntaxTree wr, ref string prefix, bool useAllTypeArgs = false)
        {
            Contract.Requires(typeArgs != null);
            Contract.Requires(tok != null);
            Contract.Requires(wr != null);
            Contract.Requires(prefix != null);

            foreach (var ta in typeArgs)
            {
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_9(86L, () => useAllTypeArgs, () => NeedsTypeDescriptor(ta.Formal)))
                {
                    wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(92L, "{0}{1}"), prefix, TypeDescriptor(ta.Actual, wr, tok));
                    prefix = MutateCSharp.Schemata247.ReplaceStringConstant_2(93L, ", ");
                }
            }
        }

        protected virtual ConcreteSyntaxTree EmitNullTest(bool testIsNull, ConcreteSyntaxTree wr)
        {
            var wrTarget = wr.ForkInParens();
            wr.Write(testIsNull ? MutateCSharp.Schemata247.ReplaceStringConstant_2(94L, " == null") : MutateCSharp.Schemata247.ReplaceStringConstant_2(95L, " != null"));
            return wrTarget;
        }

        /// <summary>
        /// EmitTailCallStructure evolves "wr" into a structure that can be used as the jump target
        /// for tail calls (see EmitJumpToTailCallStart).
        /// The precondition of the method is:
        ///     (member is Method m0 && m0.IsTailRecursive) || (member is Function f0 && f0.IsTailRecursive)
        /// </summary>
        protected abstract ConcreteSyntaxTree EmitTailCallStructure(MemberDecl member, ConcreteSyntaxTree wr);
        protected abstract void EmitJumpToTailCallStart(ConcreteSyntaxTree wr);

        internal abstract string TypeName(Type type, ConcreteSyntaxTree wr, IToken tok, MemberDecl/*?*/ member = null);
        // For cases where a type looks different when it's an argument, such as (*sigh*) Java primitives
        protected virtual string TypeArgumentName(Type type, ConcreteSyntaxTree wr, IToken tok)
        {
            return TypeName(type, wr, tok);
        }
        /// <summary>
        /// This method returns the target representation of one possible value of the type.
        /// Requires: usePlaceboValue || type.HasCompilableValue
        ///
        ///   usePlaceboValue - If "true", the default value produced is one that the target language accepts as a value
        ///                  of the type, but which may not correspond to a Dafny value. This option is used when it is known
        ///                  that the Dafny program will not use the value (for example, when a field is automatically initialized
        ///                  but the Dafny program will soon assign a new value).
        /// </summary>
        protected abstract string TypeInitializationValue(Type type, ConcreteSyntaxTree wr, IToken tok, bool usePlaceboValue, bool constructTypeParameterDefaultsFromTypeDescriptors);

        protected string TypeName_UDT(string fullCompileName, UserDefinedType udt, ConcreteSyntaxTree wr, IToken tok, bool omitTypeArguments = false)
        {
            Contract.Requires(fullCompileName != null);
            Contract.Requires(udt != null);
            Contract.Requires(wr != null);
            Contract.Requires(tok != null);
            Contract.Requires(udt.TypeArgs.Count == (udt.ResolvedClass == null ? 0 : udt.ResolvedClass.TypeArgs.Count));
            var cl = udt.ResolvedClass;
            var typeParams = SelectNonGhost(cl, cl.TypeArgs);
            var typeArgs = SelectNonGhost(cl, udt.TypeArgs);
            return TypeName_UDT(fullCompileName, typeParams.ConvertAll(tp => tp.Variance), typeArgs, wr, tok, omitTypeArguments);
        }
        protected abstract string TypeName_UDT(string fullCompileName, List<TypeParameter.TPVariance> variance, List<Type> typeArgs,
          ConcreteSyntaxTree wr, IToken tok, bool omitTypeArguments);
        protected abstract string/*?*/ TypeName_Companion(Type type, ConcreteSyntaxTree wr, IToken tok, MemberDecl/*?*/ member);
        protected virtual void EmitTypeName_Companion(Type type, ConcreteSyntaxTree wr, ConcreteSyntaxTree surrounding, IToken tok, MemberDecl/*?*/ member)
        {
            wr.Write(TypeName_Companion(type, surrounding, tok, member));
        }

        protected string TypeName_Companion(TopLevelDecl cls, ConcreteSyntaxTree wr, IToken tok)
        {
            Contract.Requires(cls != null);
            Contract.Requires(wr != null);
            Contract.Requires(tok != null);
            return TypeName_Companion(UserDefinedType.FromTopLevelDecl(tok, cls), wr, tok, null);
        }
        /// Return the "native form" of a type, to which EmitCoercionToNativeForm coerces it.
        protected virtual Type NativeForm(Type type)
        {
            return type;
        }

        protected abstract bool DeclareFormal(string prefix, string name, Type type, IToken tok, bool isInParam, ConcreteSyntaxTree wr);
        /// <summary>
        /// If "leaveRoomForRhs" is false and "rhs" is null, then generates:
        ///     type name;
        /// If "leaveRoomForRhs" is false and "rhs" is non-null, then generates:
        ///     type name = rhs;
        /// If "leaveRoomForRhs" is true, in which case "rhs" must be null, then generates:
        ///     type name
        /// which is intended to be followed up by a call to EmitAssignmentRhs.
        /// In the above, if "type" is null, then it is replaced by "var" or "let".
        /// "tok" is allowed to be null if "type" is.
        /// </summary>
        protected abstract void DeclareLocalVar(string name, Type/*?*/ type, IToken /*?*/ tok, bool leaveRoomForRhs, string/*?*/ rhs, ConcreteSyntaxTree wr);

        protected virtual void DeclareLocalVar(string name, Type /*?*/ type, IToken /*?*/ tok, bool leaveRoomForRhs, string /*?*/ rhs, ConcreteSyntaxTree wr, Type t)
        {
            DeclareLocalVar(name, type, tok, leaveRoomForRhs, rhs, wr);
        }
        /// <summary>
        /// Generates:
        ///     type name = rhs;
        /// In the above, if "type" is null, then it is replaced by "var" or "let".
        /// "tok" is allowed to be null if "type" is.
        /// </summary>
        protected virtual void DeclareLocalVar(string name, Type/*?*/ type, IToken/*?*/ tok, Expression rhs, bool inLetExprBody, ConcreteSyntaxTree wr)
        {
            var wStmts = wr.Fork();
            var w = DeclareLocalVar(name, type ?? rhs.Type, tok, wr);
            EmitExpr(rhs, inLetExprBody, w, wStmts);
        }

        protected virtual void EmitDummyVariableUse(string variableName, ConcreteSyntaxTree wr)
        {
            // by default, do nothing
        }

        /// <summary>
        /// Generates
        ///     type name = <<writer returned>>;
        /// In the above, if "type" is null, then it is replaced by "var" or "let".
        /// "tok" is allowed to be null if "type" is.
        /// </summary>
        protected abstract ConcreteSyntaxTree DeclareLocalVar(string name, Type/*?*/ type, IToken/*?*/ tok, ConcreteSyntaxTree wr);
        protected virtual void DeclareOutCollector(string collectorVarName, ConcreteSyntaxTree wr) { }  // called only for return-style calls
        protected virtual void DeclareSpecificOutCollector(string collectorVarName, ConcreteSyntaxTree wr, List<Type> formalTypes, List<Type> lhsTypes) { DeclareOutCollector(collectorVarName, wr); } // for languages that don't allow "let" or "var" expressions
        protected virtual bool UseReturnStyleOuts(Method m, int nonGhostOutCount) => MutateCSharp.Schemata247.ReplaceBooleanConstant_1(96L, false);
        protected virtual ConcreteSyntaxTree EmitMethodReturns(Method m, ConcreteSyntaxTree wr) { return wr; } // for languages that need explicit return statements not provided by Dafny
        protected virtual bool SupportsMultipleReturns { get => MutateCSharp.Schemata247.ReplaceBooleanConstant_1(97L, false); }
        protected virtual bool SupportsAmbiguousTypeDecl { get => MutateCSharp.Schemata247.ReplaceBooleanConstant_1(98L, true); }

        protected virtual bool ClassesRedeclareInheritedFields => MutateCSharp.Schemata247.ReplaceBooleanConstant_1(99L, true);
        public int TargetTupleSize = MutateCSharp.Schemata247.ReplaceNumericConstant_3(100L, 0);
        /// The punctuation that comes at the end of a statement.  Note that
        /// statements are followed by newlines regardless.
        protected virtual string StmtTerminator { get => MutateCSharp.Schemata247.ReplaceStringConstant_2(104L, ";"); }
        protected virtual string True { get => MutateCSharp.Schemata247.ReplaceStringConstant_2(105L, "true"); }
        protected virtual string False { get => MutateCSharp.Schemata247.ReplaceStringConstant_2(106L, "false"); }
        protected virtual string Conj { get => MutateCSharp.Schemata247.ReplaceStringConstant_2(107L, "&&"); }
        protected virtual string AssignmentSymbol { get => MutateCSharp.Schemata247.ReplaceStringConstant_2(108L, " = "); }

        public void EndStmt(ConcreteSyntaxTree wr) { wr.WriteLine(StmtTerminator); }
        protected abstract void DeclareLocalOutVar(string name, Type type, IToken tok, string rhs, bool useReturnStyleOuts, ConcreteSyntaxTree wr);
        protected virtual void EmitActualOutArg(string actualOutParamName, ConcreteSyntaxTree wr) { }  // actualOutParamName is always the name of a local variable; called only for non-return-style outs
        protected virtual void EmitOutParameterSplits(string outCollector, List<string> actualOutParamNames, ConcreteSyntaxTree wr) { }  // called only for return-style calls
        protected virtual void EmitCastOutParameterSplits(string outCollector, List<string> actualOutParamNames, ConcreteSyntaxTree wr, List<Type> formalOutParamTypes, List<Type> lhsTypes, IToken tok)
        {
            EmitOutParameterSplits(outCollector, actualOutParamNames, wr);
        }

        protected abstract void EmitActualTypeArgs(List<Type> typeArgs, IToken tok, ConcreteSyntaxTree wr);

        protected virtual void EmitNameAndActualTypeArgs(string protectedName, List<Type> typeArgs, IToken tok, ConcreteSyntaxTree wr)
        {
            wr.Write(protectedName);
            EmitActualTypeArgs(typeArgs, tok, wr);
        }

        protected virtual ConcreteSyntaxTree EmitAssignment(ILvalue wLhs, Type lhsType /*?*/, Type rhsType /*?*/,
          ConcreteSyntaxTree wr, IToken tok)
        {
            var w = wLhs.EmitWrite(wr);

            w = EmitCoercionIfNecessary(rhsType, lhsType, tok, w);
            w = EmitDowncastIfNecessary(rhsType, lhsType, tok, w);
            return w;
        }

        protected virtual void EmitAssignment(out ConcreteSyntaxTree wLhs, Type/*?*/ lhsType, out ConcreteSyntaxTree wRhs, Type/*?*/ rhsType, ConcreteSyntaxTree wr)
        {
            wLhs = wr.Fork();
            wr.Write(AssignmentSymbol);
            var w = wr;
            w = EmitCoercionIfNecessary(rhsType, lhsType, Token.NoToken, w);
            w = EmitDowncastIfNecessary(rhsType, lhsType, Token.NoToken, w);
            wRhs = w.Fork();
            EndStmt(wr);
        }
        protected virtual void EmitAssignment(string lhs, Type/*?*/ lhsType, string rhs, Type/*?*/ rhsType, ConcreteSyntaxTree wr)
        {
            EmitAssignment(out var wLhs, lhsType, out var wRhs, rhsType, wr);
            wLhs.Write(lhs);
            wRhs.Write(rhs);
        }
        protected void EmitAssignmentRhs(string rhs, ConcreteSyntaxTree wr)
        {
            var w = EmitAssignmentRhs(wr);
            w.Write(rhs);
        }
        protected void EmitAssignmentRhs(Expression rhs, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts = null)
        {
            wStmts ??= wr.Fork();
            var w = EmitAssignmentRhs(wr);
            EmitExpr(rhs, inLetExprBody, w, wStmts);
        }

        protected virtual ConcreteSyntaxTree EmitAssignmentRhs(ConcreteSyntaxTree wr)
        {
            wr.Write(AssignmentSymbol);
            var w = wr.Fork();
            EndStmt(wr);
            return w;
        }

        protected virtual string EmitAssignmentLhs(Expression e, ConcreteSyntaxTree wr)
        {
            var wStmts = wr.Fork();
            var target = ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(109L, "_lhs"));
            EmitExpr(e, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(110L, false), DeclareLocalVar(target, e.Type, e.tok, wr), wStmts);
            return target;
        }

        protected virtual void EmitMultiAssignment(List<Expression> lhsExprs, List<ILvalue> lhss, List<Type> lhsTypes, out List<ConcreteSyntaxTree> wRhss,
          List<Type> rhsTypes, ConcreteSyntaxTree wr)
        {
            Contract.Assert(lhss.Count == lhsTypes.Count);
            Contract.Assert(lhsTypes.Count == rhsTypes.Count);

            wRhss = new List<ConcreteSyntaxTree>();
            var rhsVars = new List<string>();
            foreach (var rhsType in rhsTypes)
            {
                string target = ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(111L, "_rhs"));
                rhsVars.Add(target);
                wRhss.Add(DeclareLocalVar(target, rhsType, Token.NoToken, wr));
            }

            List<ILvalue> lhssn;
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_4(116L, lhss.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(112L, 1)))
            {
                lhssn = new List<ILvalue>();
                for (int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(121L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(125L, i, lhss.Count); MutateCSharp.Schemata247.ReplacePrefixUnaryExprOp_10(130L, ref i))
                {
                    Expression lexpr = lhsExprs[i].Resolved;
                    ILvalue lhs = lhss[i];
                    if (lexpr is IdentifierExpr)
                    {
                        lhssn.Add(lhs);

                    }
                    else if (lexpr is MemberSelectExpr memberSelectExpr)
                    {
                        string target = EmitAssignmentLhs(memberSelectExpr.Obj, wr);
                        var typeArgs = TypeArgumentInstantiation.ListFromMember(memberSelectExpr.Member,
                          null, memberSelectExpr.TypeApplication_JustMember);
                        ILvalue newLhs = EmitMemberSelect(w => EmitIdentifier(target, w), memberSelectExpr.Obj.Type, memberSelectExpr.Member, typeArgs,
                          memberSelectExpr.TypeArgumentSubstitutionsWithParents(), memberSelectExpr.Type, internalAccess: enclosingMethod is Constructor);
                        lhssn.Add(newLhs);

                    }
                    else if (lexpr is SeqSelectExpr selectExpr)
                    {
                        string targetArray = EmitAssignmentLhs(selectExpr.Seq, wr);
                        string targetIndex = EmitAssignmentLhs(selectExpr.E0, wr);
                        if (MutateCSharp.Schemata247.ReplaceBinExprOp_9(135L, () => selectExpr.Seq.Type.IsArrayType, () => MutateCSharp.Schemata247.ReplaceBinExprOp_11(134L, selectExpr.Seq.Type.NormalizeToAncestorType().AsSeqType, null)))
                        {
                            targetIndex = ArrayIndexToNativeInt(targetIndex, selectExpr.E0.Type);
                        }
                        ILvalue newLhs = new ArrayLvalueImpl(this, targetArray, new List<Action<ConcreteSyntaxTree>>() { wIndex => EmitIdentifier(targetIndex, wIndex) }, lhsTypes[i]);
                        lhssn.Add(newLhs);

                    }
                    else if (lexpr is MultiSelectExpr multiSelectExpr)
                    {
                        string targetArray = EmitAssignmentLhs(multiSelectExpr.Array, wr);
                        var targetIndices = new List<string>();
                        foreach (var index in multiSelectExpr.Indices)
                        {
                            string targetIndex = EmitAssignmentLhs(index, wr);
                            targetIndex = ArrayIndexToNativeInt(targetIndex, index.Type);
                            targetIndices.Add(targetIndex);
                        }
                        ILvalue newLhs = new ArrayLvalueImpl(this, targetArray, Util.Map<string, Action<ConcreteSyntaxTree>>(targetIndices, i => wIndex => EmitIdentifier(i, wIndex)), lhsTypes[i]);
                        lhssn.Add(newLhs);

                    }
                    else
                    {
                        Contract.Assert(false); // Unknown kind of expression
                        lhssn.Add(lhs);
                    }
                }
            }
            else
            {
                lhssn = lhss;
            }

            Contract.Assert(rhsVars.Count == lhsTypes.Count);
            for (int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(141L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(145L, i, rhsVars.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(150L, ref i))
            {
                ConcreteSyntaxTree wRhsVar = EmitAssignment(lhssn[i], lhsTypes[i], rhsTypes[i], wr, Token.NoToken);
                EmitIdentifier(rhsVars[i], wRhsVar);
            }
        }

        protected virtual void EmitSetterParameter(ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(151L, "value"));
        }
        protected abstract void EmitPrintStmt(ConcreteSyntaxTree wr, Expression arg);
        protected abstract void EmitReturn(List<Formal> outParams, ConcreteSyntaxTree wr);
        protected virtual void EmitReturnExpr(Expression expr, Type resultType, bool inLetExprBody, ConcreteSyntaxTree wr)
        {  // emits "return <expr>;" for function bodies
            var wStmts = wr.Fork();
            var w = EmitReturnExpr(wr);
            EmitExpr(expr, inLetExprBody, EmitCoercionIfNecessary(expr.Type, resultType, null, w), wStmts);
        }
        protected virtual void EmitReturnExpr(string returnExpr, ConcreteSyntaxTree wr)
        {  // emits "return <returnExpr>;" for function bodies
            var w = EmitReturnExpr(wr);
            w.Write(returnExpr);
        }
        protected virtual ConcreteSyntaxTree EmitReturnExpr(ConcreteSyntaxTree wr)
        {
            // emits "return <returnExpr>;" for function bodies
            wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(152L, "return "));
            var w = wr.Fork();
            EndStmt(wr);
            return w;
        }
        /// <summary>
        /// Labels the code written to the TargetWriter returned, in such that way that any
        /// emitted break to the label inside that code will abruptly end the execution of the code.
        /// </summary>
        protected abstract ConcreteSyntaxTree CreateLabeledCode(string label, bool createContinueLabel, ConcreteSyntaxTree wr);
        protected abstract void EmitBreak(string/*?*/ label, ConcreteSyntaxTree wr);
        protected abstract void EmitContinue(string label, ConcreteSyntaxTree wr);
        protected abstract void EmitYield(ConcreteSyntaxTree wr);
        protected abstract void EmitAbsurd(string/*?*/ message, ConcreteSyntaxTree wr);
        protected virtual void EmitAbsurd(string message, ConcreteSyntaxTree wr, bool needIterLimit)
        {
            EmitAbsurd(message, wr);
        }

        protected abstract void EmitHalt(IToken tok, Expression /*?*/ messageExpr, ConcreteSyntaxTree wr);

        protected ConcreteSyntaxTree EmitIf(string guard, bool hasElse, ConcreteSyntaxTree wr)
        {
            var thn = EmitIf(out var guardWriter, hasElse, wr);
            guardWriter.Write(guard);
            return thn;
        }
        protected virtual ConcreteSyntaxTree EmitIf(out ConcreteSyntaxTree guardWriter, bool hasElse, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(153L, "if ("));
            guardWriter = wr.Fork();
            if (hasElse)
            {
                var thn = wr.NewBlock(MutateCSharp.Schemata247.ReplaceStringConstant_2(154L, ")"), MutateCSharp.Schemata247.ReplaceStringConstant_2(155L, " else"), BlockStyle.SpaceBrace, BlockStyle.SpaceBrace);
                return thn;
            }
            else
            {
                var thn = wr.NewBlock(MutateCSharp.Schemata247.ReplaceStringConstant_2(156L, ")"));
                return thn;
            }

            return default;
        }

        protected virtual ConcreteSyntaxTree EmitBlock(ConcreteSyntaxTree wr)
        {
            return wr.NewBlock("", open: BlockStyle.Brace);
        }

        protected virtual ConcreteSyntaxTree EmitWhile(IToken tok, List<Statement> body, LList<Label> labels, ConcreteSyntaxTree wr)
        {  // returns the guard writer
            var wBody = CreateWhileLoop(out var guardWriter, wr);
            wBody = EmitContinueLabel(labels, wBody);
            Coverage.Instrument(tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(157L, "while body"), wBody);
            TrStmtList(body, wBody);
            return guardWriter;
        }

        protected abstract ConcreteSyntaxTree EmitForStmt(IToken tok, IVariable loopIndex, bool goingUp, string /*?*/ endVarName,
          List<Statement> body, LList<Label> labels, ConcreteSyntaxTree wr);

        protected virtual ConcreteSyntaxTree CreateWhileLoop(out ConcreteSyntaxTree guardWriter, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(158L, "while ("));
            guardWriter = wr.Fork();
            var wBody = wr.NewBlock(MutateCSharp.Schemata247.ReplaceStringConstant_2(159L, ")"));
            return wBody;
        }

        /// <summary>
        /// Create a for loop where the type of the index variable, along with "start" and "bound", is the native array-index type.
        /// </summary>
        protected abstract ConcreteSyntaxTree CreateForLoop(string indexVar, Action<ConcreteSyntaxTree> bound, ConcreteSyntaxTree wr, string start = null);
        protected abstract ConcreteSyntaxTree CreateDoublingForLoop(string indexVar, int start, ConcreteSyntaxTree wr);
        protected abstract void EmitIncrementVar(string varName, ConcreteSyntaxTree wr);  // increments a BigInteger by 1
        protected abstract void EmitDecrementVar(string varName, ConcreteSyntaxTree wr);  // decrements a BigInteger by 1

        protected abstract string GetQuantifierName(string bvType);

        /// <summary>
        /// Emit a loop like this:
        ///     foreach (tmpVarName:collectionElementType in [[collectionWriter]]) {
        ///       [[bodyWriter]]
        ///     }
        /// where
        ///   * "[[collectionWriter]]" is the writer returned as "collectionWriter"
        ///   * "[[bodyWriter]]" is the block writer returned
        /// </summary>
        protected abstract ConcreteSyntaxTree CreateForeachLoop(
          string tmpVarName, Type collectionElementType,
          IToken tok, out ConcreteSyntaxTree collectionWriter, ConcreteSyntaxTree wr);

        /// <summary>
        /// Creates a guarded foreach loop that iterates over a collection, and apply required subtype
        /// and compiled subset types filters. Will not emit intermediate ifs if there is no need.
        ///
        ///     foreach(collectionElementType tmpVarName in collectionWriter) {
        ///       if(tmpVarName is [boundVar.type]) {
        ///         var [IDName(boundVar)] = ([boundVar.type])(tmpvarName);
        ///         if(constraints_of_boundvar.Type([IdName(boundVar)])) {
        ///           ...
        ///         }
        ///       }
        ///     }
        /// </summary>
        /// <returns>A writer to write inside the deepest if-then</returns>
        private ConcreteSyntaxTree CreateGuardedForeachLoop(
          string tmpVarName, Type collectionElementType,
          IVariable boundVar,
          bool introduceBoundVar, bool inLetExprBody,
          IToken tok, Action<ConcreteSyntaxTree> collection, ConcreteSyntaxTree wr
          )
        {
            wr = CreateForeachLoop(tmpVarName, collectionElementType, tok, out var collectionWriter, wr);
            collection(collectionWriter);
            wr = MaybeInjectSubtypeConstraintWrtTraits(tmpVarName, collectionElementType, boundVar.Type, inLetExprBody, tok, wr);
            EmitDowncastVariableAssignment(IdName(boundVar), boundVar.Type, tmpVarName, collectionElementType,
                introduceBoundVar, tok, wr);
            wr = MaybeInjectSubsetConstraint(boundVar, boundVar.Type, inLetExprBody, tok, wr);
            return wr;
        }

        /// <summary>
        /// Returns a subtype condition like:
        ///     tmpVarName is member of type boundVarType
        /// Returns null if no condition is necessary
        /// </summary>
        [CanBeNull]
        protected abstract Action<ConcreteSyntaxTree> GetSubtypeCondition(
          string tmpVarName, Type boundVarType, IToken tok, ConcreteSyntaxTree wPreconditions);

        /// <summary>
        /// Emit an upcast or (already verified) downcast assignment like:
        ///
        ///     var boundVarName:boundVarType := tmpVarName as boundVarType;
        ///     [[bodyWriter]]
        ///
        /// where
        ///   * "[[bodyWriter]]" is where the writer wr's position will be next
        /// </summary>
        /// <param name="boundVarName">Name of the variable after casting</param>
        /// <param name="boundVarType">Expected variable type</param>
        /// <param name="tmpVarName">The collection's variable name</param>
        /// <param name="sourceType"></param>
        /// <param name="introduceBoundVar">Whether or not to declare the variable, in languages requiring declarations</param>
        /// <param name="tok">A position in the AST</param>
        /// <param name="wr">The concrete syntax tree writer</param>
        protected abstract void EmitDowncastVariableAssignment(string boundVarName, Type boundVarType, string tmpVarName,
          Type sourceType, bool introduceBoundVar, IToken tok, ConcreteSyntaxTree wr);

        /// <summary>
        /// Emit a simple foreach loop over the elements (which are known as "ingredients") of a collection assembled for
        /// the purpose of compiling a "forall" statement.
        ///
        ///     foreach (boundVarName:boundVarType in [[coll]]) {
        ///       [[body]]
        ///     }
        ///
        /// where "boundVarType" is an L-tuple whose components are "tupleTypeArgs" (see EmitIngredients). If "boundVarType" can
        /// be inferred from the ingredients emitted by EmitIngredients, then "L" and "tupleTypeArgs" can be ignored and
        /// "boundVarType" be replaced by some target-language way of saying "please infer the type" (like "var" in C#).
        /// </summary>
        protected abstract ConcreteSyntaxTree CreateForeachIngredientLoop(string boundVarName, int L, string tupleTypeArgs, out ConcreteSyntaxTree collectionWriter, ConcreteSyntaxTree wr);

        /// <summary>
        /// If "initCall" is non-null, then "initCall.Method is Constructor".
        /// </summary>
        protected abstract void EmitNew(Type type, IToken tok, CallStmt initCall /*?*/, ConcreteSyntaxTree wr,
          ConcreteSyntaxTree wStmts);

        // To support target language constructors without an additional initCall in {:extern} code, we ignore the initCall
        // and call the constructor with all arguments.
        protected string ConstructorArguments(CallStmt initCall, ConcreteSyntaxTree wStmts, Constructor ctor, string sep = "")
        {
            var arguments = Enumerable.Empty<string>();
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_12(160L, ctor, null) && ctor.IsExtern(Options, out _, out _))
            {
                // the arguments of any external constructor are placed here
                arguments = ctor.Ins.Select((f, i) => (f, i))
                  .Where(tp => !tp.f.IsGhost)
                  .Select(tp => Expr(initCall.Args[tp.i], MutateCSharp.Schemata247.ReplaceBooleanConstant_1(161L, false), wStmts).ToString());
            }
            return (arguments.Any() ? sep : "") + arguments.Comma();
        }

        protected virtual bool DeterminesArrayTypeFromExampleElement => MutateCSharp.Schemata247.ReplaceBooleanConstant_1(162L, false);

        protected virtual string ArrayIndexLiteral(int x) => x.ToString();

        /// <summary>
        /// Allocates a new array with element type "elementType" and lengths "dimensions" in each dimension.
        /// Note that "elementType" may denote a type parameter.
        ///
        /// Each string in "dimensions" is generated as a Dafny "int" (that is, a BigInteger).
        ///
        /// If "mustInitialize" is true, then fills each array element with a default value of type "elementType".
        /// In this case, "exampleElement" must be null.
        ///
        /// If "mustInitialize" is false, then the array's elements are left uninitialized.
        /// In this case, "exampleElement" may be non-null as a guide to figuring out what run-time type the array should have.
        /// Note that "exampleElement" is not written to the array.
        ///
        /// "exampleElement" is always null if "DeterminesArrayTypeFromExampleElement" is false.
        /// </summary>
        protected abstract void EmitNewArray(Type elementType, IToken tok, List<string> dimensions,
          bool mustInitialize, [CanBeNull] string exampleElement, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts);

        /// <summary>
        /// Same as the EmitNewArray overload above, except that "dimensions" is "List<Expression>" instead of "List<string>".
        /// </summary>
        protected virtual void EmitNewArray(Type elementType, IToken tok, List<Expression> dimensions,
          bool mustInitialize, [CanBeNull] string exampleElement, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {

            var dimStrings = dimensions.ConvertAll(expr =>
            {
                var wrDim = new ConcreteSyntaxTree();
                EmitExpr(expr, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(163L, false), ExprToInt(expr.Type, wrDim), wStmts);
                return wrDim.ToString();
            });
            EmitNewArray(elementType, tok, dimStrings, mustInitialize, exampleElement, wr, wStmts);
        }

        protected abstract void EmitLiteralExpr(ConcreteSyntaxTree wr, LiteralExpr e);
        protected abstract void EmitStringLiteral(string str, bool isVerbatim, ConcreteSyntaxTree wr);
        protected abstract ConcreteSyntaxTree EmitBitvectorTruncation(BitvectorType bvType, [CanBeNull] NativeType nativeType,
          bool surroundByUnchecked, ConcreteSyntaxTree wr);
        protected delegate void FCE_Arg_Translator(Expression e, ConcreteSyntaxTree wr, bool inLetExpr, ConcreteSyntaxTree wStmts);

        protected abstract void EmitRotate(Expression e0, Expression e1, bool isRotateLeft, ConcreteSyntaxTree wr,
          bool inLetExprBody, ConcreteSyntaxTree wStmts, FCE_Arg_Translator tr);
        /// <summary>
        /// Return true if x < 0 should be rendered as sign(x) < 0 when x has the
        /// given type.  Typically, this is only a win at non-native types, since
        /// BigIntegers benefit from not having to access the number zero.
        /// </summary>
        protected virtual bool CompareZeroUsingSign(Type type)
        {
            return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(164L, false);
        }
        protected virtual ConcreteSyntaxTree EmitSign(Type type, ConcreteSyntaxTree wr)
        {
            // Currently, this should only be called when CompareZeroUsingSign is true
            Contract.Assert(false);
            throw new cce.UnreachableException();
            return default;
        }
        protected abstract void EmitEmptyTupleList(string tupleTypeArgs, ConcreteSyntaxTree wr);
        protected abstract ConcreteSyntaxTree EmitAddTupleToList(string ingredients, string tupleTypeArgs, ConcreteSyntaxTree wr);
        protected abstract void EmitTupleSelect(string prefix, int i, ConcreteSyntaxTree wr);

        protected virtual bool NeedsCastFromTypeParameter => MutateCSharp.Schemata247.ReplaceBooleanConstant_1(165L, false);

        protected virtual bool TargetSubtypingRequiresEqualTypeArguments(Type type) => MutateCSharp.Schemata247.ReplaceBooleanConstant_1(166L, false);

        protected virtual bool IsCoercionNecessary(Type /*?*/ from, Type /*?*/ to)
        {
            return NeedsCastFromTypeParameter;
        }

        protected virtual Type TypeForCoercion(Type type)
        {
            return type;
        }

        /// <summary>
        /// If "from" and "to" are both given, and if a "from" needs an explicit coercion in order to become a "to", emit that coercion.
        /// Needed in languages where either
        ///   (a) we need to represent upcasts as explicit operations (like Go, or array types in Java), or
        ///   (b) there's static typing but no parametric polymorphism (like Go) so that lots of things need to be boxed and unboxed.
        /// "toOrig" is passed to represent the original, unsubstituted type, which is useful for detecting boxing situations in Java
        /// </summary>
        protected virtual ConcreteSyntaxTree EmitCoercionIfNecessary(Type/*?*/ from, Type/*?*/ to, IToken tok, ConcreteSyntaxTree wr, Type/*?*/ toOrig = null)
        {
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(182L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_8(175L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_8(169L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_13(167L, from, null), () => MutateCSharp.Schemata247.ReplaceBinExprOp_13(168L, to, null)), () => from.IsTraitType), () => MutateCSharp.Schemata247.ReplaceBinExprOp_14(181L, to.AsNewtype, null)))
            {
                return FromFatPointer(to, wr);
            }
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(217L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_8(203L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_8(197L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_8(190L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_13(188L, from, null), () => MutateCSharp.Schemata247.ReplaceBinExprOp_13(189L, to, null)), () => MutateCSharp.Schemata247.ReplaceBinExprOp_14(196L, from.AsNewtype, null)), () => to.IsTraitType), () => (MutateCSharp.Schemata247.ReplaceBinExprOp_9(211L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_15(209L, enclosingMethod, null), () => MutateCSharp.Schemata247.ReplaceBinExprOp_16(210L, enclosingFunction, null)))))
            {
                return ToFatPointer(from, wr);
            }
            return wr;
        }

        protected ConcreteSyntaxTree CoercionIfNecessary(Type/*?*/ from, Type/*?*/ to, IToken tok, ICanRender inner, Type/*?*/ toOrig = null)
        {
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_17(223L, toOrig, null))
            {
                toOrig = to;
            }

            var result = new ConcreteSyntaxTree();
            EmitCoercionIfNecessary(from, to, tok, result, toOrig).Append(inner);
            return result;
        }

        protected ConcreteSyntaxTree EmitDowncastIfNecessary(Type /*?*/ from, Type /*?*/ to, IToken tok, ConcreteSyntaxTree wr)
        {
            Contract.Requires(tok != null);
            Contract.Requires(wr != null);
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(226L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_13(224L, from, null), () => MutateCSharp.Schemata247.ReplaceBinExprOp_13(225L, to, null)))
            {
                from = DatatypeWrapperEraser.SimplifyType(Options, from);
                to = DatatypeWrapperEraser.SimplifyType(Options, to);
                if (!IsTargetSupertype(to, from))
                {
                    // By the way, it is tempting to think that IsTargetSupertype(from, to)) would hold here, but that's not true.
                    // For one, in a language with NeedsCastFromTypeParameter, "to" and "from" may contain uninstantiated formal type parameters.
                    // Also, it is possible (subject to a check enforced by the verifier) to assign Datatype<X> to Datatype<Y>,
                    // where Datatype is co-variant in its argument type and X and Y are two incomparable types with a common supertype.

                    wr = EmitDowncast(from, to, tok, wr);
                }
            }
            return wr;
        }

        protected virtual ConcreteSyntaxTree UnboxNewtypeValue(ConcreteSyntaxTree wr)
        {
            return wr;
        }

        /// <summary>
        /// Change from the fat-pointer representation of "type" to the ordinary representation of "type".
        /// If these are the same, acts as the identity.
        /// Note, the two representations are different only for newtypes, and only for newtypes that
        /// extend a trait, see Type.HasFatPointer.
        /// </summary>
        protected virtual ConcreteSyntaxTree FromFatPointer(Type type, ConcreteSyntaxTree wr)
        {
            return wr;
        }

        /// <summary>
        /// Change from the ordinary representation of "type" to the fat-pointer representation of "type".
        /// If these are the same, acts as the identity.
        /// Note, the two representations are different only for newtypes, and only for newtypes that
        /// extend a trait, see Type.HasFatPointer.
        /// </summary>
        protected virtual ConcreteSyntaxTree ToFatPointer(Type type, ConcreteSyntaxTree wr)
        {
            return wr;
        }

        /// <summary>
        /// Determine if "to" is a supertype of "from" in the target language, if "!typeEqualityOnly".
        /// Determine if "to" is equal to "from" in the target language, if "typeEqualityOnly".
        /// This to similar to Type.IsSupertype and Type.Equals, respectively, but ignores subset types (that
        /// is, always uses the base type of any subset type).
        /// </summary>
        public bool IsTargetSupertype(Type to, Type from, bool typeEqualityOnly = false)
        {
            Contract.Requires(from != null);
            Contract.Requires(to != null);
            to = to.NormalizeExpand();
            from = from.NormalizeExpand();
            if (Type.SameHead(to, from))
            {
                Contract.Assert(to.TypeArgs.Count == from.TypeArgs.Count);
                var formalTypeParameters = (to as UserDefinedType)?.ResolvedClass?.TypeArgs;
                Contract.Assert(formalTypeParameters == null || formalTypeParameters.Count == to.TypeArgs.Count);
                Contract.Assert(formalTypeParameters != null || to.TypeArgs.Count == 0 || to is CollectionType);
                for (var i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(232L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(236L, i, to.TypeArgs.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(241L, ref i))
                {
                    bool okay;
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_9(242L, () => typeEqualityOnly, () => TargetSubtypingRequiresEqualTypeArguments(to)))
                    {
                        okay = IsTargetSupertype(to.TypeArgs[i], from.TypeArgs[i], MutateCSharp.Schemata247.ReplaceBooleanConstant_1(248L, true));
                    }
                    else if (MutateCSharp.Schemata247.ReplaceBinExprOp_9(251L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_18(249L, formalTypeParameters, null), () => MutateCSharp.Schemata247.ReplaceBinExprOp_19(250L, formalTypeParameters[i].Variance, TypeParameter.TPVariance.Co)))
                    {
                        okay = IsTargetSupertype(to.TypeArgs[i], from.TypeArgs[i]);
                    }
                    else if (MutateCSharp.Schemata247.ReplaceBinExprOp_19(257L, formalTypeParameters[i].Variance, TypeParameter.TPVariance.Contra))
                    {
                        okay = IsTargetSupertype(from.TypeArgs[i], to.TypeArgs[i]);
                    }
                    else
                    {
                        okay = IsTargetSupertype(to.TypeArgs[i], from.TypeArgs[i], MutateCSharp.Schemata247.ReplaceBooleanConstant_1(258L, true));
                    }
                    if (!okay)
                    {
                        return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(259L, false);
                    }
                }
                return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(260L, true);
            }
            else if (typeEqualityOnly)
            {
                return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(261L, false);
            }
            else if (to.IsObjectQ)
            {
                return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(262L, true);
            }
            else
            {
                return from.ParentTypes().Any(fromParentType => IsTargetSupertype(to, fromParentType));
            }

            return default;
        }

        protected ConcreteSyntaxTree Downcast(Type from, Type to, IToken tok, ICanRender expression)
        {
            var result = new ConcreteSyntaxTree();
            EmitDowncast(from, to, tok, result).Append(expression);
            return result;
        }

        protected virtual ConcreteSyntaxTree EmitDowncast(Type from, Type to, IToken tok, ConcreteSyntaxTree wr)
        {
            Contract.Requires(from != null);
            Contract.Requires(to != null);
            Contract.Requires(tok != null);
            Contract.Requires(wr != null);
            Contract.Requires(!IsTargetSupertype(to, from));
            return wr;
        }

        protected virtual ConcreteSyntaxTree EmitCoercionToNativeInt(ConcreteSyntaxTree wr)
        {
            return wr;
        }
        /// <summary>
        /// Emit a coercion of a value to any tuple, returning the writer for the value to coerce.  Needed in translating ForallStmt because some of the tuple components are native ints for which we have no Type object, but Go needs to coerce the value that comes out of the iterator.  Safe to leave this alone in subclasses that don't have the same problem.
        /// </summary>
        protected virtual ConcreteSyntaxTree EmitCoercionToArbitraryTuple(ConcreteSyntaxTree wr)
        {
            return wr;
        }
        protected virtual string IdName(TopLevelDecl d)
        {
            Contract.Requires(d != null);
            return IdProtect(d.GetCompileName(Options));
        }
        protected virtual string IdName(MemberDecl member)
        {
            Contract.Requires(member != null);
            return IdProtect(member.GetCompileName(Options));
        }

        protected virtual string CompanionMemberIdName(MemberDecl member)
        {
            return IdName(member);
        }
        protected virtual string IdName(TypeParameter tp)
        {
            Contract.Requires(tp != null);
            return IdProtect(tp.GetCompileName(Options));
        }
        protected virtual string GetCompileNameNotProtected(IVariable v)
        {
            return v.CompileName;
        }
        protected virtual string IdName(IVariable v)
        {
            Contract.Requires(v != null);
            return IdProtect(GetCompileNameNotProtected(v));
        }
        protected virtual string IdMemberName(MemberSelectExpr mse)
        {
            Contract.Requires(mse != null);
            return IdProtect(mse.MemberName);
        }
        protected virtual string IdProtect(string name)
        {
            Contract.Requires(name != null);
            return name;
        }
        protected abstract string FullTypeName(UserDefinedType udt, MemberDecl/*?*/ member = null);
        protected abstract void EmitThis(ConcreteSyntaxTree wr, bool callToInheritedMember = false);
        protected virtual void EmitNull(Type type, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(263L, "null"));
        }
        protected virtual void EmitITE(Expression guard, Expression thn, Expression els, Type resultType, bool inLetExprBody,
            ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            Contract.Requires(guard != null);
            Contract.Requires(thn != null);
            Contract.Requires(thn.Type != null);
            Contract.Requires(els != null);
            Contract.Requires(resultType != null);
            Contract.Requires(wr != null);

            resultType = resultType.NormalizeExpand();
            var thenExpr = Expr(thn, inLetExprBody, wStmts);
            var castedThenExpr = resultType.Equals(thn.Type.NormalizeExpand()) ? thenExpr : Cast(resultType, thenExpr);
            var elseExpr = Expr(els, inLetExprBody, wStmts);
            var castedElseExpr = resultType.Equals(els.Type.NormalizeExpand()) ? elseExpr : Cast(resultType, elseExpr);
            wr.Format($"(({Expr(guard, inLetExprBody, wStmts)}) ? ({castedThenExpr}) : ({castedElseExpr}))");
        }

        public ConcreteSyntaxTree Cast(ICanRender toType, ConcreteSyntaxTree expr)
        {
            var result = new ConcreteSyntaxTree();
            EmitCast(toType, result).Append(expr);
            return result;
        }

        public ConcreteSyntaxTree Cast(Type toType, ConcreteSyntaxTree expr)
        {
            var result = new ConcreteSyntaxTree();
            EmitCast(new LineSegment(TypeName(toType, result, Token.NoToken)), result).Append(expr);
            return result;
        }

        protected virtual ConcreteSyntaxTree EmitCast(ICanRender toType, ConcreteSyntaxTree wr)
        {
            wr.Format($"({toType})");
            return wr.ForkInParens();
        }

        protected abstract void EmitDatatypeValue(DatatypeValue dtv, string typeDescriptorArguments, string arguments, ConcreteSyntaxTree wr);
        protected abstract void GetSpecialFieldInfo(SpecialField.ID id, object idParam, Type receiverType, out string compiledName, out string preString, out string postString);

        /// <summary>
        /// A "TypeArgumentInstantiation" is essentially a pair consisting of a formal type parameter and an actual type for that parameter.
        /// </summary>
        public class TypeArgumentInstantiation
        {
            public readonly TypeParameter Formal;
            public readonly Type Actual;

            public TypeArgumentInstantiation(TypeParameter formal, Type actual)
            {
                Contract.Requires(formal != null);
                Contract.Requires(actual != null);
                Formal = formal;
                Actual = actual;
            }

            /// <summary>
            /// Uses "formal" for both formal and actual.
            /// </summary>
            public TypeArgumentInstantiation(TypeParameter formal)
            {
                Contract.Requires(formal != null);
                Formal = formal;
                Actual = new UserDefinedType(formal);
            }

            public static List<TypeArgumentInstantiation> ListFromMember(MemberDecl member, List<Type> /*?*/ classActuals, List<Type> /*?*/ memberActuals)
            {
                Contract.Requires(classActuals == null || classActuals.Count == (member.EnclosingClass == null ? 0 : member.EnclosingClass.TypeArgs.Count));
                Contract.Requires(memberActuals == null || memberActuals.Count == (member is ICallable ic ? ic.TypeArgs.Count : 0));

                var r = new List<TypeArgumentInstantiation>();
                void add(List<TypeParameter> formals, List<Type> actuals)
                {
                    Contract.Assert(formals.Count == actuals.Count);
                    for (var i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(264L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(268L, i, formals.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(273L, ref i))
                    {
                        r.Add(new TypeArgumentInstantiation(formals[i], actuals[i]));
                    }
                };

                if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(284L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_20(274L, classActuals, null), () => MutateCSharp.Schemata247.ReplaceBinExprOp_21(279L, classActuals.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(275L, 0))))
                {
                    Contract.Assert(member.EnclosingClass.TypeArgs.TrueForAll(ta => ta.Parent is TopLevelDecl));
                    add(member.EnclosingClass.TypeArgs, classActuals);
                }
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_20(290L, memberActuals, null) && member is ICallable icallable)
                {
                    Contract.Assert(icallable.TypeArgs.TrueForAll(ta => !(ta.Parent is TopLevelDecl)));
                    add(icallable.TypeArgs, memberActuals);
                }
                return r;
            }

            public static List<TypeArgumentInstantiation> ListFromClass(TopLevelDecl cl, List<Type> actuals)
            {
                Contract.Requires(cl != null);
                Contract.Requires(actuals != null);
                Contract.Requires(cl.TypeArgs.Count == actuals.Count);

                var r = new List<TypeArgumentInstantiation>();
                for (var i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(291L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(295L, i, cl.TypeArgs.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(300L, ref i))
                {
                    r.Add(new TypeArgumentInstantiation(cl.TypeArgs[i], actuals[i]));
                }
                return r;
            }

            public static List<TypeArgumentInstantiation> ListFromFormals(List<TypeParameter> formals)
            {
                Contract.Requires(formals != null);
                return formals.ConvertAll(tp => new TypeArgumentInstantiation(tp, new UserDefinedType(tp)));
            }

            public static List<TypeParameter> ToFormals(List<TypeArgumentInstantiation> typeArgs)
            {
                Contract.Requires(typeArgs != null);
                return typeArgs.ConvertAll(ta => ta.Formal);
            }

            public static List<Type> ToActuals(List<TypeArgumentInstantiation> typeArgs)
            {
                Contract.Requires(typeArgs != null);
                return typeArgs.ConvertAll(ta => ta.Actual);
            }
        }

        /// <summary>
        /// Answers two questions whose answers are used to filter type parameters.
        /// For a member c, F, or M:
        ///     (co-)datatype/class/trait <<cl>> {
        ///       <<isStatic>> const c ...
        ///       <<isStatic>> function F ...
        ///       <<isStatic>> method M ...
        ///     }
        /// does a type parameter of "cl"
        ///  - get compiled as a type parameter of the member (needsTypeParameter)
        ///  - get compiled as a type descriptor of the member (needsTypeDescriptor)
        /// For a member of a trait with a rhs/body, if "lookasideBody" is "true", the questions are to
        /// be answered for the member emitted into the companion class, not the signature that goes into
        /// the target type.
        /// </summary>
        protected virtual void TypeArgDescriptorUse(bool isStatic, bool lookasideBody, TopLevelDeclWithMembers cl, out bool needsTypeParameter, out bool needsTypeDescriptor)
        {
            Contract.Requires(cl is DatatypeDecl || cl is ClassLikeDecl);
            // TODO: Decide whether to express this as a Feature
            throw new NotImplementedException();
        }

        protected internal List<TypeArgumentInstantiation> ForTypeParameters(List<TypeArgumentInstantiation> typeArgs, MemberDecl member, bool lookasideBody)
        {
            Contract.Requires(member is ConstantField || member is Function || member is Method);
            Contract.Requires(typeArgs != null);
            var memberHasBody =
              (member is ConstantField cf && cf.Rhs != null) ||
              (member is Function f && f.Body != null) ||
              (member is Method m && m.Body != null);
            var r = new List<TypeArgumentInstantiation>();
            foreach (var ta in typeArgs)
            {
                var tp = ta.Formal;
                if (tp.Parent is TopLevelDeclWithMembers)
                {
                    TypeArgDescriptorUse(member.IsStatic, lookasideBody, (TopLevelDeclWithMembers)member.EnclosingClass, out var needsTypeParameter, out var _);
                    if (!needsTypeParameter)
                    {
                        continue;
                    }
                }
                r.Add(ta);
            }
            return r;
        }

        protected List<TypeArgumentInstantiation> ForTypeDescriptors(List<TypeArgumentInstantiation> typeArgs, TopLevelDecl enclosingClass, MemberDecl member, bool lookasideBody)
        {
            Contract.Requires(member is ConstantField || member is Function || member is Method);
            Contract.Requires(typeArgs != null);
            var memberHasBody =
              (member is ConstantField cf && cf.Rhs != null) ||
              (member is Function f && f.Body != null) ||
              (member is Method m && m.Body != null);
            var r = new List<TypeArgumentInstantiation>();
            foreach (var ta in typeArgs)
            {
                var tp = ta.Formal;
                if (tp.Parent is TopLevelDeclWithMembers)
                {
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(302L, () => tp.Parent is not TraitDecl, () => MutateCSharp.Schemata247.ReplaceBinExprOp_22(301L, member?.OverriddenMember, null)))
                    {
                        continue;
                    }
                    TypeArgDescriptorUse(MutateCSharp.Schemata247.ReplaceBinExprOp_9(309L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_23(308L, member, null), () => member.IsStatic), lookasideBody, (TopLevelDeclWithMembers)enclosingClass, out var _, out var needsTypeDescriptor);
                    if (!needsTypeDescriptor)
                    {
                        continue;
                    }
                }
                r.Add(ta);
            }
            return r;
        }

        /// <summary>
        /// The "additionalCustomParameter" is used when the member is an instance function that requires customer-receiver support.
        /// This parameter is then to be added between any run-time type descriptors and the "normal" arguments. The caller will
        /// arrange for "additionalCustomParameter" to be properly bound.
        /// </summary>
        protected abstract ILvalue EmitMemberSelect(Action<ConcreteSyntaxTree> obj, Type objType, MemberDecl member, List<TypeArgumentInstantiation> typeArgs, Dictionary<TypeParameter, Type> typeMap,
          Type expectedType, string/*?*/ additionalCustomParameter = null, bool internalAccess = false);

        /// <summary>
        /// The "indices" are expected to already be of the native array-index type.
        /// </summary>
        protected abstract ConcreteSyntaxTree EmitArraySelect(List<Action<ConcreteSyntaxTree>> indices, Type elmtType, ConcreteSyntaxTree wr);
        protected abstract ConcreteSyntaxTree EmitArraySelect(List<Expression> indices, Type elmtType, bool inLetExprBody,
          ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts);

        /// <summary>
        /// The "indices" are expected to already be of the native array-index type.
        /// </summary>
        protected virtual (ConcreteSyntaxTree wArray, ConcreteSyntaxTree wRhs) EmitArrayUpdate(List<Action<ConcreteSyntaxTree>> indices, Type elementType, ConcreteSyntaxTree wr)
        {
            var wArray = EmitArraySelect(indices, elementType, wr);
            wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(315L, " = "));
            var wRhs = wr.Fork();
            return (wArray, wRhs);
        }
        protected ConcreteSyntaxTree EmitArrayUpdate(List<Action<ConcreteSyntaxTree>> indices, Expression rhs, ConcreteSyntaxTree wr)
        {
            var (wArray, wRhs) = EmitArrayUpdate(indices, rhs.Type, wr);
            EmitExpr(rhs, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(316L, false), wRhs, wr);
            return wArray;
        }
        /// <summary>
        /// Given a target-language expression "arrayIndex" that of the target array-index type, return an
        /// expression that denotes "arrayIndex" as a Dafny "int" (that is, a BigInteger).
        /// </summary>
        protected virtual string ArrayIndexToInt(string arrayIndex)
        {
            Contract.Requires(arrayIndex != null);
            return arrayIndex;
        }

        protected virtual ConcreteSyntaxTree ExprToInt(Type fromType, ConcreteSyntaxTree wr)
        {
            return wr;
        }
        protected virtual string ArrayIndexToNativeInt(string arrayIndex, Type fromType)
        {
            Contract.Requires(arrayIndex != null);
            Contract.Requires(fromType != null);
            return arrayIndex;
        }

        protected ConcreteSyntaxTree ExprAsNativeInt(Expression expr, bool inLetExprBody, ConcreteSyntaxTree wStmts)
        {
            var result = new ConcreteSyntaxTree();
            EmitExprAsNativeInt(expr, inLetExprBody, result, wStmts);
            return result;
        }

        protected abstract void EmitExprAsNativeInt(Expression expr, bool inLetExprBody, ConcreteSyntaxTree wr,
          ConcreteSyntaxTree wStmts);
        protected abstract void EmitIndexCollectionSelect(Expression source, Expression index, bool inLetExprBody,
          ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts);
        protected abstract void EmitIndexCollectionUpdate(Expression source, Expression index, Expression value,
          CollectionType resultCollectionType, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts);
        protected virtual void EmitIndexCollectionUpdate(Type sourceType, out ConcreteSyntaxTree wSource, out ConcreteSyntaxTree wIndex, out ConcreteSyntaxTree wValue, ConcreteSyntaxTree wr, bool nativeIndex)
        {
            wSource = wr.Fork();
            wr.Write('[');
            wIndex = wr.Fork();
            wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(317L, "] = "));
            wValue = wr.Fork();
        }
        /// <summary>
        /// If "fromArray" is false, then "source" is a sequence.
        /// If "fromArray" is true, then "source" is an array.
        /// </summary>
        protected abstract void EmitSeqSelectRange(Expression source, Expression lo /*?*/, Expression hi /*?*/,
          bool fromArray, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts);
        protected abstract void EmitSeqConstructionExpr(SeqConstructionExpr expr, bool inLetExprBody, ConcreteSyntaxTree wr,
          ConcreteSyntaxTree wStmts);
        protected abstract void EmitMultiSetFormingExpr(MultiSetFormingExpr expr, bool inLetExprBody, ConcreteSyntaxTree wr,
          ConcreteSyntaxTree wStmts);
        protected abstract void EmitApplyExpr(Type functionType, IToken tok, Expression function, List<Expression> arguments, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts);
        protected virtual bool TargetLambdaCanUseEnclosingLocals => MutateCSharp.Schemata247.ReplaceBooleanConstant_1(318L, true);
        protected abstract ConcreteSyntaxTree EmitBetaRedex(List<string> boundVars, List<Expression> arguments, List<Type> boundTypes,
          Type resultType, IToken resultTok, bool inLetExprBody, ConcreteSyntaxTree wr, ref ConcreteSyntaxTree wStmts);
        protected virtual void EmitConstructorCheck(string source, DatatypeCtor ctor, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(319L, "{0}.is_{1}"), source, ctor.GetCompileName(Options));
        }
        /// <summary>
        /// EmitDestructor is somewhat similar to following "source" with a call to EmitMemberSelect.
        /// However, EmitDestructor may also need to perform a cast on "source".
        /// Furthermore, EmitDestructor also needs to work for anonymous destructors.
        /// </summary>
        protected abstract void EmitDestructor(Action<ConcreteSyntaxTree> source, Formal dtor, int formalNonGhostIndex, DatatypeCtor ctor, List<Type> typeArgs, Type bvType, ConcreteSyntaxTree wr);
        protected abstract ConcreteSyntaxTree CreateLambda(List<Type> inTypes, IToken tok, List<string> inNames,
          Type resultType, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts, bool untyped = false);

        /// <summary>
        /// Emit an "Immediately Invoked Function Expression" with the semantics of
        ///     var bvName: bvType := <<wrRhs>>; <<wrBody>>
        /// where <<wrBody>> will have type "bodyType". In many languages, this IIFE will not be a "let" expression but a "lambda" expression like this:
        ///     ((bvName: bvType) => <<wrBody>>)(<<wrRhs>>)
        /// </summary>
        protected abstract void CreateIIFE(string bvName, Type bvType, IToken bvTok, Type bodyType, IToken bodyTok,
          ConcreteSyntaxTree wr, ref ConcreteSyntaxTree wStmts, out ConcreteSyntaxTree wrRhs, out ConcreteSyntaxTree wrBody);
        protected ConcreteSyntaxTree CreateIIFE_ExprBody(string bvName, Type bvType, IToken bvTok, Expression rhs,
          bool inLetExprBody, Type bodyType, IToken bodyTok, ConcreteSyntaxTree wr, ref ConcreteSyntaxTree wStmts)
        {
            var innerScope = wStmts.Fork();
            CreateIIFE(bvName, bvType, bvTok, bodyType, bodyTok, wr, ref wStmts, out var wrRhs, out var wrBody);
            EmitExpr(rhs, inLetExprBody, wrRhs, innerScope);
            return wrBody;
        }

        protected abstract ConcreteSyntaxTree CreateIIFE0(Type resultType, IToken resultTok, ConcreteSyntaxTree wr,
          ConcreteSyntaxTree wStmts);  // Immediately Invoked Function Expression
        protected abstract ConcreteSyntaxTree CreateIIFE1(int source, Type resultType, IToken resultTok, string bvName,
          ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts);  // Immediately Invoked Function Expression
        public enum ResolvedUnaryOp { BoolNot, BitwiseNot, Cardinality }

        protected static readonly Dictionary<UnaryOpExpr.ResolvedOpcode, ResolvedUnaryOp> UnaryOpCodeMap = new()
        {
            [UnaryOpExpr.ResolvedOpcode.BVNot] = ResolvedUnaryOp.BitwiseNot,
            [UnaryOpExpr.ResolvedOpcode.BoolNot] = ResolvedUnaryOp.BoolNot,
            [UnaryOpExpr.ResolvedOpcode.SeqLength] = ResolvedUnaryOp.Cardinality,
            [UnaryOpExpr.ResolvedOpcode.SetCard] = ResolvedUnaryOp.Cardinality,
            [UnaryOpExpr.ResolvedOpcode.MultiSetCard] = ResolvedUnaryOp.Cardinality,
            [UnaryOpExpr.ResolvedOpcode.MapCard] = ResolvedUnaryOp.Cardinality
        };

        protected abstract void EmitUnaryExpr(ResolvedUnaryOp op, Expression expr, bool inLetExprBody,
          ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts);

        protected virtual void CompileBinOp(BinaryExpr.ResolvedOpcode op,
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

            // This default implementation does not handle all cases. It handles some cases that look the same
            // in C-like languages. It also handles cases that can be solved by another operator, but reversing
            // the arguments or following the operation with a negation.
            opString = null;
            preOpString = "";
            postOpString = "";
            callString = null;
            staticCallString = null;
            reverseArguments = MutateCSharp.Schemata247.ReplaceBooleanConstant_1(320L, false);
            truncateResult = MutateCSharp.Schemata247.ReplaceBooleanConstant_1(321L, false);
            convertE1_to_int = MutateCSharp.Schemata247.ReplaceBooleanConstant_1(322L, false);
            coerceE1 = MutateCSharp.Schemata247.ReplaceBooleanConstant_1(323L, false);

            BinaryExpr.ResolvedOpcode dualOp = BinaryExpr.ResolvedOpcode.Add;  // NOTE! "Add" is used to say "there is no dual op"
            BinaryExpr.ResolvedOpcode negatedOp = BinaryExpr.ResolvedOpcode.Add;  // NOTE! "Add" is used to say "there is no negated op"

            switch (op)
            {
                case BinaryExpr.ResolvedOpcode.Iff:
                    opString = "=="; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Imp:
                    preOpString = "!"; opString = "||"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Or:
                    opString = "||"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.And:
                    opString = "&&"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.BitwiseAnd:
                    opString = "&"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.BitwiseOr:
                    opString = "|"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.BitwiseXor:
                    opString = "^"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Lt:
                case BinaryExpr.ResolvedOpcode.LtChar:
                    opString = "<"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Le:
                case BinaryExpr.ResolvedOpcode.LeChar:
                    opString = "<="; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Ge:
                case BinaryExpr.ResolvedOpcode.GeChar:
                    opString = ">="; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Gt:
                case BinaryExpr.ResolvedOpcode.GtChar:
                    opString = ">"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.SetNeq:
                    negatedOp = BinaryExpr.ResolvedOpcode.SetEq; break;
                    break;
                case BinaryExpr.ResolvedOpcode.MultiSetNeq:
                    negatedOp = BinaryExpr.ResolvedOpcode.MultiSetEq; break;
                    break;
                case BinaryExpr.ResolvedOpcode.SeqNeq:
                    negatedOp = BinaryExpr.ResolvedOpcode.SeqEq; break;
                    break;
                case BinaryExpr.ResolvedOpcode.MapNeq:
                    negatedOp = BinaryExpr.ResolvedOpcode.MapEq; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Superset:
                    dualOp = BinaryExpr.ResolvedOpcode.Subset; break;
                    break;
                case BinaryExpr.ResolvedOpcode.MultiSuperset:
                    dualOp = BinaryExpr.ResolvedOpcode.MultiSubset; break;
                    break;
                case BinaryExpr.ResolvedOpcode.ProperSuperset:
                    dualOp = BinaryExpr.ResolvedOpcode.ProperSubset; break;
                    break;
                case BinaryExpr.ResolvedOpcode.ProperMultiSuperset:
                    dualOp = BinaryExpr.ResolvedOpcode.ProperMultiSubset; break;
                    break;
                case BinaryExpr.ResolvedOpcode.NotInSet:
                    negatedOp = BinaryExpr.ResolvedOpcode.InSet; break;
                    break;
                case BinaryExpr.ResolvedOpcode.NotInMultiSet:
                    negatedOp = BinaryExpr.ResolvedOpcode.InMultiSet; break;
                    break;
                case BinaryExpr.ResolvedOpcode.NotInSeq:
                    negatedOp = BinaryExpr.ResolvedOpcode.InSeq; break;
                    break;
                case BinaryExpr.ResolvedOpcode.NotInMap:
                    negatedOp = BinaryExpr.ResolvedOpcode.InMap; break;
                    break;
                default:
                    // The operator is one that needs to be handled in the specific compilers.
                    Contract.Assert(false); throw new cce.UnreachableException();  // unexpected binary expression
                    break;
            }

            if (MutateCSharp.Schemata247.ReplaceBinExprOp_24(324L, dualOp, BinaryExpr.ResolvedOpcode.Add))
            {  // remember from above that Add stands for "there is no dual"
                Contract.Assert(negatedOp == BinaryExpr.ResolvedOpcode.Add);
                CompileBinOp(dualOp,
                  e1, e0, tok, resultType.GetRuntimeType(),
                  out opString, out preOpString, out postOpString, out callString, out staticCallString, out reverseArguments, out truncateResult, out convertE1_to_int, out coerceE1,
                  errorWr);
                reverseArguments = !reverseArguments;
            }
            else if (MutateCSharp.Schemata247.ReplaceBinExprOp_24(325L, negatedOp, BinaryExpr.ResolvedOpcode.Add))
            {  // remember from above that Add stands for "there is no negated op"
                CompileBinOp(negatedOp,
                  e0, e1, tok, resultType.GetRuntimeType(),
                  out opString, out preOpString, out postOpString, out callString, out staticCallString, out reverseArguments, out truncateResult, out convertE1_to_int, out coerceE1,
                  errorWr);
                preOpString = MutateCSharp.Schemata247.ReplaceStringConstant_2(326L, "!") + preOpString;
            }
        }

        protected abstract void EmitIsZero(string varName, ConcreteSyntaxTree wr);
        protected abstract void EmitConversionExpr(Expression fromExpr, Type fromType, Type toType, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts);

        /// <summary>
        /// "fromType" is assignable to "toType", "fromType" is not a subtype of "toType", and both "fromType" and "toType" refer to
        /// reference types or subset types thereof.
        /// This method is used only for traits and reference types.
        /// </summary>
        protected abstract void EmitTypeTest(string localName, Type fromType, Type toType, IToken tok, ConcreteSyntaxTree wr);

        /// <summary>
        /// Emit a conjunct that tests if the Dafny real number "source" is an integer, like:
        ///    "TestIsInteger(source) && "
        /// It is fine for the target code to repeat the mention of "source", if necessary.
        /// </summary>
        protected abstract void EmitIsIntegerTest(Expression source, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts);

        /// <summary>
        /// Emit a conjunct that tests if the Dafny integer "source" is a character, like:
        ///     "TestIsUnicodeScalarValue(source) && "
        /// It is fine for the target code to repeat the mention of "source", if necessary.
        /// </summary>
        protected abstract void EmitIsUnicodeScalarValueTest(Expression source, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts);

        /// <summary>
        /// Emit conjuncts that test if the Dafny integer "source" is in the range lo..hi, like:
        ///     "lo <= source && source < hi && "
        /// It is fine for the target code to repeat the mention of "source", if necessary.
        /// </summary>
        protected abstract void EmitIsInIntegerRange(Expression source, BigInteger lo, BigInteger hi, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts);

        protected abstract void EmitCollectionDisplay(CollectionType ct, IToken tok, List<Expression> elements,
          bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts);  // used for sets, multisets, and sequences
        protected abstract void EmitMapDisplay(MapType mt, IToken tok, List<ExpressionPair> elements,
          bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts);

        protected abstract void EmitSetBuilder_New(ConcreteSyntaxTree wr, SetComprehension e, string collectionName);
        protected abstract void EmitMapBuilder_New(ConcreteSyntaxTree wr, MapComprehension e, string collectionName);

        protected abstract void EmitSetBuilder_Add(CollectionType ct, string collName, Expression elmt, bool inLetExprBody, ConcreteSyntaxTree wr);
        protected abstract ConcreteSyntaxTree EmitMapBuilder_Add(MapType mt, IToken tok, string collName, Expression term, bool inLetExprBody, ConcreteSyntaxTree wr);

        /// <summary>
        /// The "ct" type is either a SetType or a MapType.
        /// </summary>
        protected abstract void GetCollectionBuilder_Build(CollectionType ct, IToken tok, string collName,
          ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmt);

        /// <summary>
        /// Returns a pair (ty, f) where
        ///   * "f" is a closure that, to a given writer, emits code that enumerates an integer-valued range from
        ///     "wLo" to "wHi" using the target type of "type"
        ///   * "ty" is a Dafny type whose target type is the same as the target type of "type"
        /// It is assumed that "type" is some integer-based type (not a bitvector type, for example).
        /// </summary>
        protected virtual (Type, Action<ConcreteSyntaxTree>) EmitIntegerRange(Type type, Action<ConcreteSyntaxTree> wLo, Action<ConcreteSyntaxTree> wHi)
        {
            Type result;
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_25(327L, AsNativeType(type), null))
            {
                result = type;
            }
            else
            {
                result = new IntType();
            }

            return (result, (wr) =>
            {
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_25(328L, AsNativeType(type), null))
                {
                    wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(329L, "{0}.IntegerRange("), IdProtect(type.AsNewtype.GetFullCompileName(Options)));
                }
                else
                {
                    wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(330L, "{0}.IntegerRange("), GetHelperModuleName());
                }

                wLo(wr);
                wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(331L, ", "));
                wHi(wr);
                wr.Write(')');
            }
            );
        }
        protected abstract void EmitSingleValueGenerator(Expression e, bool inLetExprBody, string type,
          ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts);
        protected virtual void FinishModule() { }

        protected virtual void DeclareExternType(AbstractTypeDecl d, Expression compileTypeHint, ConcreteSyntaxTree wr) { }

        protected virtual void OrganizeModules(Program program, out List<ModuleDefinition> modules)
        {
            modules = program.CompileModules.ToList();
        }

        public void Compile(Program program, ConcreteSyntaxTree wrx)
        {
            Contract.Requires(program != null);

            EmitHeader(program, wrx);
            EmitBuiltInDecls(program.SystemModuleManager, wrx);
            var temp = new List<ModuleDefinition>();
            OrganizeModules(program, out temp);
            foreach (var m in temp)
            {
                EmitModule(program, wrx, m);
            }
            EmitFooter(program, wrx);
        }

        private void EmitModule(Program program, ConcreteSyntaxTree programNode, ModuleDefinition module)
        {
            if (!module.CanCompile())
            {
                // the purpose of an abstract module is to skip compilation
                return;
            }

            DetectAndMarkCapitalizationConflicts(module);

            ModuleDefinition externModule = null;
            string libraryName = null;
            if (!Options.DisallowExterns)
            {
                var args = Attributes.FindExpressions(module.Attributes, MutateCSharp.Schemata247.ReplaceStringConstant_2(332L, "extern"));
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_26(333L, args, null))
                {
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_27(338L, args.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(334L, 2)))
                    {
                        libraryName = (string)(args[MutateCSharp.Schemata247.ReplaceNumericConstant_3(343L, 1)] as StringLiteralExpr)?.Value;
                    }

                    externModule = module;
                }
            }

            if (!module.ShouldCompile(program.Compilation))
            {
                DependOnModule(program, module, externModule, libraryName);
                return;
            }

            var wr = CreateModule(module.GetCompileName(Options), module.IsDefaultModule, externModule, libraryName, programNode);
            var v = new CheckHasNoAssumes_Visitor(this, wr);
            Contract.Assert(enclosingModule == null);
            enclosingModule = module;
            foreach (TopLevelDecl d in module.TopLevelDecls)
            {
                if (!ProgramResolver.ShouldCompile(d))
                {
                    continue;
                }

                var newLineWriter = wr.Fork();
                if (d is AbstractTypeDecl)
                {
                    var at = (AbstractTypeDecl)d;
                    bool externP = Attributes.Contains(at.Attributes, MutateCSharp.Schemata247.ReplaceStringConstant_2(347L, "extern"));
                    if (externP)
                    {
                        var exprs = Attributes.FindExpressions(at.Attributes, MutateCSharp.Schemata247.ReplaceStringConstant_2(348L, "extern"));
                        Contract.Assert(exprs != null); // because externP is true
                        if (MutateCSharp.Schemata247.ReplaceBinExprOp_27(353L, exprs.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(349L, 1)))
                        {
                            DeclareExternType(at, exprs[MutateCSharp.Schemata247.ReplaceNumericConstant_3(358L, 0)], wr);
                        }
                        else
                        {
                            Error(ErrorId.c_abstract_type_needs_hint, d.tok,
              MutateCSharp.Schemata247.ReplaceStringConstant_2(362L, "Abstract type ('{0}') with extern attribute requires a compile hint. Expected {{:extern compile_type_hint}}"),
                              wr, at.FullName);
                        }

                        v.Visit(exprs);
                    }
                    else
                    {
                        Error(ErrorId.c_abstract_type_cannot_be_compiled, d.tok,
            MutateCSharp.Schemata247.ReplaceStringConstant_2(363L, "Abstract type ('{0}') cannot be compiled; perhaps make it a type synonym or use :extern."), wr,
                          at.FullName);
                    }
                }
                else if (d is TypeSynonymDecl)
                {
                    var sst = d as SubsetTypeDecl;
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_28(364L, sst, null))
                    {
                        DeclareSubsetType(sst, wr);
                        v.Visit(sst);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (d is NewtypeDecl)
                {
                    var nt = (NewtypeDecl)d;
                    var w = DeclareNewtype(nt, wr);
                    v.Visit(nt);
                    CompileClassMembers(program, nt, w);
                    w.Finish();
                }
                else if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(380L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_8(374L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_29(369L, (d as TupleTypeDecl)?.NonGhostDims, MutateCSharp.Schemata247.ReplaceNumericConstant_3(365L, 1)), () => SupportsDatatypeWrapperErasure), () => Options.Get(CommonOptionBag.OptimizeErasableDatatypeWrapper)))
                {
                    // ignore this type declaration
                }
                else if (d is DatatypeDecl)
                {
                    var dt = (DatatypeDecl)d;

                    if (!DeclaredDatatypes.Add((module, dt.GetCompileName(Options))))
                    {
                        continue;
                    }

                    var w = DeclareDatatype(dt, wr);
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_30(386L, w, null))
                    {
                        CompileClassMembers(program, dt, w);
                        w.Finish();
                    }
                    else if (DatatypeDeclarationAndMemberCompilationAreSeparate)
                    {
                        continue;
                    }
                }
                else if (d is IteratorDecl)
                {
                    var iter = (IteratorDecl)d;
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(396L, () => Options.ForbidNondeterminism, () => MutateCSharp.Schemata247.ReplaceBinExprOp_4(391L, iter.Outs.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(387L, 0))))
                    {
                        Error(ErrorId.c_iterators_are_not_deterministic, iter.tok,
            MutateCSharp.Schemata247.ReplaceStringConstant_2(402L, "since yield parameters are initialized arbitrarily, iterators are forbidden by the --enforce-determinism option"),
                          wr);
                    }

                    var wIter = CreateIterator(iter, wr);
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_31(403L, iter.Body, null))
                    {
                        Error(ErrorId.c_iterator_has_no_body, iter.tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(404L, "iterator {0} has no body"), wIter, iter.FullName);
                    }
                    else
                    {
                        TrStmtList(iter.Body.Body, wIter);
                    }
                }
                else if (d is TraitDecl trait)
                {
                    // writing the trait
                    var w = CreateTrait(trait.GetCompileName(Options), trait.IsExtern(Options, out _, out _), trait.TypeArgs,
                      trait, trait.ParentTypeInformation.UniqueParentTraits(), trait.tok, wr);
                    CompileClassMembers(program, trait, w);
                    w.Finish();
                }
                else if (d is DefaultClassDecl defaultClassDecl)
                {
                    Contract.Assert(defaultClassDecl.InheritedMembers.Count == 0);
                    Predicate<MemberDecl> compilationMaterial = x => MutateCSharp.Schemata247.ReplaceBinExprOp_8(412L, () => !x.IsGhost, () => (MutateCSharp.Schemata247.ReplaceBinExprOp_9(406L, () => Options.DisallowExterns, () => !Attributes.Contains(x.Attributes, MutateCSharp.Schemata247.ReplaceStringConstant_2(405L, "extern")))));
                    var include = defaultClassDecl.Members.Exists(compilationMaterial);
                    var classIsExtern = MutateCSharp.Schemata247.ReplaceBooleanConstant_1(418L, false);
                    if (include)
                    {
                        classIsExtern =
            MutateCSharp.Schemata247.ReplaceBinExprOp_9(427L, () => (MutateCSharp.Schemata247.ReplaceBinExprOp_8(420L, () => !Options.DisallowExterns, () => Attributes.Contains(defaultClassDecl.Attributes, MutateCSharp.Schemata247.ReplaceStringConstant_2(419L, "extern")))), () => Attributes.Contains(defaultClassDecl.EnclosingModuleDefinition.Attributes, MutateCSharp.Schemata247.ReplaceStringConstant_2(426L, "extern")));
                        if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(440L, () => classIsExtern, () => defaultClassDecl.Members.TrueForAll(member => MutateCSharp.Schemata247.ReplaceBinExprOp_9(434L, () => member.IsGhost, () => Attributes.Contains(member.Attributes, MutateCSharp.Schemata247.ReplaceStringConstant_2(433L, "extern"))))))
                        {
                            include = MutateCSharp.Schemata247.ReplaceBooleanConstant_1(446L, false);
                        }
                    }

                    if (include)
                    {
                        var cw = CreateClass(IdProtect(d.EnclosingModuleDefinition.GetCompileName(Options)),
                          IdName(defaultClassDecl),
                          classIsExtern, defaultClassDecl.FullName,
                          defaultClassDecl.TypeArgs, defaultClassDecl,
                          defaultClassDecl.ParentTypeInformation.UniqueParentTraits(), defaultClassDecl.tok, wr);
                        CompileClassMembers(program, defaultClassDecl, cw);
                        cw.Finish();
                    }
                    else
                    {
                        // still check that given members satisfy compilation rules
                        var abyss = new NullClassWriter();
                        CompileClassMembers(program, defaultClassDecl, abyss);
                    }
                }
                else if (d is ClassLikeDecl cl)
                {
                    var include = MutateCSharp.Schemata247.ReplaceBooleanConstant_1(447L, true);
                    var classIsExtern = MutateCSharp.Schemata247.ReplaceBooleanConstant_1(448L, false);
                    if (include)
                    {
                        classIsExtern = MutateCSharp.Schemata247.ReplaceBinExprOp_8(450L, () => !Options.DisallowExterns, () => Attributes.Contains(cl.Attributes, MutateCSharp.Schemata247.ReplaceStringConstant_2(449L, "extern")));
                        if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(463L, () => classIsExtern, () => cl.Members.TrueForAll(member => MutateCSharp.Schemata247.ReplaceBinExprOp_9(457L, () => member.IsGhost, () => Attributes.Contains(member.Attributes, MutateCSharp.Schemata247.ReplaceStringConstant_2(456L, "extern"))))))
                        {
                            include = MutateCSharp.Schemata247.ReplaceBooleanConstant_1(469L, false);
                        }
                    }

                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(488L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_8(476L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_8(470L, () => Options.ForbidNondeterminism, () => !classIsExtern), () => !cl.Members.Exists(member => member is Constructor)), () => cl.Members.Exists(member => MutateCSharp.Schemata247.ReplaceBinExprOp_8(482L, () => member is Field, () => !(member is ConstantField { Rhs: not null })))))
                    {
                        Error(ErrorId.c_constructorless_class_forbidden, cl.tok,
            MutateCSharp.Schemata247.ReplaceStringConstant_2(494L, "since fields are initialized arbitrarily, constructor-less classes are forbidden by the --enforce-determinism option"),
                          wr);
                    }

                    if (include)
                    {
                        var cw = CreateClass(IdProtect(d.EnclosingModuleDefinition.GetCompileName(Options)), IdName(cl),
                          classIsExtern, cl.FullName,
                          cl.TypeArgs, cl, cl.ParentTypeInformation.UniqueParentTraits(), cl.tok, wr);
                        CompileClassMembers(program, cl, cw);
                        cw.Finish();
                    }
                    else
                    {
                        // still check that given members satisfy compilation rules
                        var abyss = new NullClassWriter();
                        CompileClassMembers(program, cl, abyss);
                    }
                }
                else if (d is ValuetypeDecl)
                {
                    // nop
                    continue;
                }
                else if (d is ModuleDecl)
                {
                    // nop
                    continue;
                }
                else
                {
                    Contract.Assert(false);
                }

                newLineWriter.WriteLine();
            }

            FinishModule();

            Contract.Assert(enclosingModule == module);
            enclosingModule = null;
        }

        private void DetectAndMarkCapitalizationConflicts(ModuleDefinition module)
        {
            foreach (TopLevelDecl d in module.TopLevelDecls)
            {
                if (d is DatatypeDecl datatypeDecl)
                {
                    CheckForCapitalizationConflicts(datatypeDecl.Ctors);
                    foreach (var ctor in datatypeDecl.Ctors)
                    {
                        CheckForCapitalizationConflicts(ctor.Destructors);
                    }
                }
                if (d is TopLevelDeclWithMembers topLevelDeclWithMembers)
                {
                    CheckForCapitalizationConflicts(topLevelDeclWithMembers.Members, topLevelDeclWithMembers.InheritedMembers);
                }
            }
        }

        public ISet<(ModuleDefinition, string)> DeclaredDatatypes { get; } = new HashSet<(ModuleDefinition, string)>();

        public class NullClassWriter : IClassWriter
        {
            private readonly ConcreteSyntaxTree abyss = new ConcreteSyntaxTree();
            private readonly ConcreteSyntaxTree block;

            public NullClassWriter()
            {
                block = abyss.NewBlock("");
            }

            public ConcreteSyntaxTree/*?*/ CreateMethod(Method m, List<TypeArgumentInstantiation> typeArgs, bool createBody, bool forBodyInheritance, bool lookasideBody)
            {
                return createBody ? block : null;
            }

            public ConcreteSyntaxTree SynthesizeMethod(Method m, List<TypeArgumentInstantiation> typeArgs, bool createBody, bool forBodyInheritance, bool lookasideBody)
            {
                throw new UnsupportedFeatureException(m.tok, Feature.MethodSynthesis);
                return default;
            }

            public ConcreteSyntaxTree/*?*/ CreateFunction(string name, List<TypeArgumentInstantiation> typeArgs, List<Formal> formals, Type resultType, IToken tok, bool isStatic, bool createBody, MemberDecl member, bool forBodyInheritance, bool lookasideBody)
            {
                return createBody ? block : null;
            }
            public ConcreteSyntaxTree/*?*/ CreateGetter(string name, TopLevelDecl enclosingDecl, Type resultType, IToken tok, bool isStatic, bool isConst, bool createBody, MemberDecl/*?*/ member, bool forBodyInheritance)
            {
                return createBody ? block : null;
            }
            public ConcreteSyntaxTree/*?*/ CreateGetterSetter(string name, Type resultType, IToken tok, bool createBody, MemberDecl/*?*/ member, out ConcreteSyntaxTree setterWriter, bool forBodyInheritance)
            {
                if (createBody)
                {
                    setterWriter = block;
                    return block;
                }
                else
                {
                    setterWriter = null;
                    return null;
                }

                return default;
            }
            public void DeclareField(string name, TopLevelDecl enclosingDecl, bool isStatic, bool isConst, Type type, IToken tok, string rhs, Field field) { }

            public void InitializeField(Field field, Type instantiatedFieldType, TopLevelDeclWithMembers enclosingClass) { }

            public ConcreteSyntaxTree/*?*/ ErrorWriter()
            {
                return null; // match the old behavior of Compile() where this is used
            }

            public void Finish() { }
        }

        protected void EmitRuntimeSource(String root, ConcreteSyntaxTree wr, bool useFiles = true)
        {
            var assembly = System.Reflection.Assembly.Load(MutateCSharp.Schemata247.ReplaceStringConstant_2(495L, "DafnyPipeline"));
            var files = assembly.GetManifestResourceNames();
            // An original source file at <root>/A/B/C.ext will become a manifest resource
            // with a name like 'DafnyPipeline.<root>.A.B.C.<ext>'
            String header = $"DafnyPipeline.{root}";
            foreach (var file in files.Where(f => f.StartsWith(header)))
            {
                var parts = file.Split('.');
                var realName = string.Join('/', parts.SkipLast(MutateCSharp.Schemata247.ReplaceNumericConstant_3(496L, 1)).Skip(MutateCSharp.Schemata247.ReplaceNumericConstant_3(500L, 2))) + MutateCSharp.Schemata247.ReplaceStringConstant_2(504L, ".") + parts.Last();
                ReadRuntimeSystem(file, useFiles ? wr.NewFile(realName) : wr);
            }
        }

        private void ReadRuntimeSystem(string filename, ConcreteSyntaxTree wr)
        {
            Contract.Requires(filename != null);
            Contract.Requires(wr != null);

            var assembly = System.Reflection.Assembly.Load(MutateCSharp.Schemata247.ReplaceStringConstant_2(505L, "DafnyPipeline"));
            var stream = assembly.GetManifestResourceStream(filename);
            if (stream is null)
            {
                throw new Exception($"Cannot find embedded resource: {filename}");
            }

            var rd = new StreamReader(stream);
            WriteFromStream(rd, wr.Append(new Verbatim()));
        }

        public static void WriteFromStream(StreamReader rd, TextWriter outputWriter)
        {
            while (MutateCSharp.Schemata247.ReplaceBooleanConstant_1(506L, true))
            {
                string s = rd.ReadLine();
                if (s == null)
                {
                    return;
                }
                outputWriter.WriteLine(s);
            }
        }

        // create a varName that is not a duplicate of formals' name
        protected string GenVarName(string root, List<Formal> formals)
        {
            bool finished = MutateCSharp.Schemata247.ReplaceBooleanConstant_1(507L, false);
            while (!finished)
            {
                finished = MutateCSharp.Schemata247.ReplaceBooleanConstant_1(508L, true);
                int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(509L, 0);
                foreach (var arg in formals)
                {
                    if (!arg.IsGhost)
                    {
                        // FormalName returns a protected name, so we compare a protected version of "root" to it
                        if (IdProtect(root).Equals(FormalName(arg, i)))
                        {
                            root += root;
                            finished = MutateCSharp.Schemata247.ReplaceBooleanConstant_1(513L, false);
                        }

                        MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(514L, ref i);
                    }
                }
            }
            return root;
        }

        protected int WriteFormals(string sep, List<Formal> formals, ConcreteSyntaxTree wr, List<Formal>/*?*/ useTheseNamesForFormals = null)
        {
            Contract.Requires(sep != null);
            Contract.Requires(formals != null);
            Contract.Requires(wr != null);
            Contract.Requires(useTheseNamesForFormals == null || useTheseNamesForFormals.Count == formals.Count);

            int n = MutateCSharp.Schemata247.ReplaceNumericConstant_3(515L, 0);
            for (var i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(519L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(523L, i, formals.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(528L, ref i))
            {
                var arg = formals[i];
                if (!arg.IsGhost)
                {
                    string name = FormalName(MutateCSharp.Schemata247.ReplaceBinExprOp_32(529L, useTheseNamesForFormals, null) ? arg : useTheseNamesForFormals[i], n);
                    if (DeclareFormal(sep, name, arg.Type, arg.tok, arg.InParam, wr))
                    {
                        sep = MutateCSharp.Schemata247.ReplaceStringConstant_2(530L, ", ");
                    }

                    MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(531L, ref n);
                }
            }
            return n;  // the number of formals written
        }

        protected string FormalName(Formal formal, int i)
        {
            Contract.Requires(formal != null);
            Contract.Ensures(Contract.Result<string>() != null);

            return IdProtect(formal.HasName ? formal.CompileName : MutateCSharp.Schemata247.ReplaceStringConstant_2(532L, "_a") + i);
        }

        public static bool HasMain(Program program, out Method mainMethod)
        {
            Contract.Ensures(Contract.Result<bool>() == (Contract.ValueAtReturn(out mainMethod) != null));
            mainMethod = null;
            bool hasMain = MutateCSharp.Schemata247.ReplaceBooleanConstant_1(533L, false);
            string name = program.Reporter.Options.MainMethod;
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(536L, () => name != null, () => MutateCSharp.Schemata247.ReplaceBinExprOp_33(535L, name, MutateCSharp.Schemata247.ReplaceStringConstant_2(534L, "-"))))
            {
                return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(542L, false);
            }

            if (!string.IsNullOrEmpty(name))
            {
                foreach (var module in program.CompileModules)
                {
                    if (!module.CanCompile())
                    {
                        // the purpose of an abstract module is to skip compilation
                        continue;
                    }
                    foreach (var decl in module.TopLevelDecls)
                    {
                        if (decl is TopLevelDeclWithMembers c)
                        {
                            foreach (MemberDecl member in c.Members)
                            {
                                if (member is Method m && MutateCSharp.Schemata247.ReplaceBinExprOp_33(543L, member.FullDafnyName, name))
                                {
                                    mainMethod = m;
                                    if (!IsPermittedAsMain(program, mainMethod, out string reason))
                                    {
                                        ReportError(ErrorId.c_method_may_not_be_main_method, program.Reporter, mainMethod.tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(544L, "The method '{0}' is not permitted as a main method ({1})."), null, name, reason);
                                        mainMethod = null;
                                        return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(545L, false);
                                    }
                                    else
                                    {
                                        return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(546L, true);
                                    }
                                }
                            }
                        }
                    }
                }
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_34(547L, name, RunAllTestsMainMethod.SyntheticTestMainName))
                {
                    ReportError(ErrorId.c_could_not_find_stipulated_main_method, program.Reporter, program.DefaultModule.tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(548L, "Could not find the method named by the -Main option: {0}"), null, name);
                }
            }
            foreach (var module in program.CompileModules)
            {
                if (!module.CanCompile())
                {
                    // the purpose of an abstract module is to skip compilation
                    continue;
                }
                foreach (var decl in module.TopLevelDecls)
                {
                    var c = decl as TopLevelDeclWithMembers;
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_35(549L, c, null))
                    {
                        foreach (var member in c.Members)
                        {
                            var m = member as Method;
                            if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(552L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_15(550L, m, null), () => Attributes.Contains(m.Attributes, MutateCSharp.Schemata247.ReplaceStringConstant_2(551L, "main"))))
                            {
                                if (MutateCSharp.Schemata247.ReplaceBinExprOp_36(558L, mainMethod, null))
                                {
                                    mainMethod = m;
                                    hasMain = MutateCSharp.Schemata247.ReplaceBooleanConstant_1(559L, true);
                                }
                                else
                                {
                                    // more than one main in the program
                                    ReportError(ErrorId.c_more_than_one_explicit_main_method, program.Reporter, m.tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(560L, "More than one method is marked {{:main}}. First declaration appeared at {0}."), null,
                                      mainMethod.tok.TokenToString(program.Options));
                                    hasMain = MutateCSharp.Schemata247.ReplaceBooleanConstant_1(561L, false);
                                }
                            }
                        }
                    }
                }
            }
            if (hasMain)
            {
                if (!IsPermittedAsMain(program, mainMethod, out string reason))
                {
                    ReportError(ErrorId.c_method_not_permitted_as_main, program.Reporter, mainMethod.tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(562L, "This method marked {{:main}} is not permitted as a main method ({0})."), null, reason);
                    mainMethod = null;
                    return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(563L, false);
                }
                else
                {
                    return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(564L, true);
                }
            }
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_15(565L, mainMethod, null))
            {
                mainMethod = null;
                return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(566L, false);
            }

            mainMethod = null;
            foreach (var module in program.CompileModules)
            {
                if (!module.CanCompile())
                {
                    // the purpose of an abstract module is to skip compilation
                    continue;
                }
                foreach (var decl in module.TopLevelDecls)
                {
                    var c = decl as TopLevelDeclWithMembers;
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_35(567L, c, null))
                    {
                        foreach (var member in c.Members)
                        {
                            var m = member as Method;
                            if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(570L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_15(568L, m, null), () => MutateCSharp.Schemata247.ReplaceBinExprOp_33(569L, m.Name, DefaultNameMain)))
                            {
                                if (MutateCSharp.Schemata247.ReplaceBinExprOp_36(576L, mainMethod, null))
                                {
                                    mainMethod = m;
                                    hasMain = MutateCSharp.Schemata247.ReplaceBooleanConstant_1(577L, true);
                                }
                                else
                                {
                                    // more than one main in the program
                                    ReportError(ErrorId.c_more_than_one_default_Main_method, program.Reporter, m.tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(578L, "More than one method is declared as '{0}'. First declaration appeared at {1}."), null,
                                      DefaultNameMain, mainMethod.tok.TokenToString(program.Options));
                                    hasMain = MutateCSharp.Schemata247.ReplaceBooleanConstant_1(579L, false);
                                }
                            }
                        }
                    }
                }
            }

            if (hasMain)
            {
                if (!IsPermittedAsMain(program, mainMethod, out string reason))
                {
                    ReportError(ErrorId.c_Main_method_not_permitted, program.Reporter, mainMethod.tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(580L, "This method 'Main' is not permitted as a main method ({0})."), null, reason);
                    return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(581L, false);
                }
                else
                {
                    return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(582L, true);
                }
            }
            else
            {
                // make sure "mainMethod" returns as null
                mainMethod = null;
                return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(583L, false);
            }

            return default;
        }

        public static bool IsPermittedAsMain(Program program, Method m, out String reason)
        {
            Contract.Requires(m.EnclosingClass is TopLevelDeclWithMembers);
            // In order to be a legal Main() method, the following must be true:
            //    The method is not a ghost method
            //    The method takes no non-ghost parameters and no type parameters
            //      except at most one array of type "array<string>"
            //    The enclosing type does not take any type parameters
            //    If the method is an instance (that is, non-static) method in a class, then the enclosing class must not declare any constructor
            // In addition, either:
            //    The method is called "Main"
            //    The method has no requires clause
            //    The method has no modifies clause
            // or:
            //    The method is annotated with {:main}
            // Note, in the case where the method is annotated with {:main}, the method is allowed to have preconditions and modifies clauses.
            // This lets the programmer add some explicit assumptions about the outside world, modeled, for example, via ghost parameters.
            var cl = (TopLevelDeclWithMembers)m.EnclosingClass;
            if (m.IsGhost)
            {
                reason = MutateCSharp.Schemata247.ReplaceStringConstant_2(584L, "the method is ghost");
                return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(585L, false);
            }
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_21(590L, m.TypeArgs.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(586L, 0)))
            {
                reason = MutateCSharp.Schemata247.ReplaceStringConstant_2(595L, "the method has type parameters");
                return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(596L, false);
            }
            if (cl is AbstractTypeDecl)
            {
                reason = MutateCSharp.Schemata247.ReplaceStringConstant_2(597L, "the enclosing type is an abstract type");
                return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(598L, false);
            }
            if (!m.IsStatic)
            {
                if (cl is TraitDecl)
                {
                    reason = MutateCSharp.Schemata247.ReplaceStringConstant_2(599L, "the method is not static and the enclosing type does not support auto-initialization");
                    return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(600L, false);
                }
                else if (cl is ClassLikeDecl)
                {
                    if (cl.Members.Exists(f => f is Constructor))
                    {
                        reason = MutateCSharp.Schemata247.ReplaceStringConstant_2(601L, "the method is not static and the enclosing class has constructors");
                        return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(602L, false);
                    }
                }
                else
                {
                    var ty = UserDefinedType.FromTopLevelDeclWithAllBooleanTypeParameters(cl);
                    if (!ty.HasCompilableValue)
                    {
                        reason = MutateCSharp.Schemata247.ReplaceStringConstant_2(603L, "the method is not static and the enclosing type does not support auto-initialization");
                        return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(604L, false);
                    }
                }
            }
            if (!m.Ins.TrueForAll(f => f.IsGhost))
            {
                var nonGhostFormals = m.Ins.Where(f => !f.IsGhost).ToList();
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_4(609L, nonGhostFormals.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(605L, 1)))
                {
                    reason = MutateCSharp.Schemata247.ReplaceStringConstant_2(614L, "the method has two or more non-ghost parameters");
                    return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(615L, false);
                }
                var typeOfUniqueFormal = nonGhostFormals[MutateCSharp.Schemata247.ReplaceNumericConstant_3(616L, 0)].Type.NormalizeExpandKeepConstraints();
                if (typeOfUniqueFormal.AsSeqType is not { } seqType ||
                    seqType.Arg.AsSeqType is not { } subSeqType ||
                    !subSeqType.Arg.IsCharType)
                {
                    reason = MutateCSharp.Schemata247.ReplaceStringConstant_2(620L, "the method's non-ghost argument type should be an seq<string>, got ") + typeOfUniqueFormal;
                    return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(621L, false);
                }
            }
            else
            {
                // Need to manually insert the args.
                var argsType = new SeqType(new SeqType(new CharType()));
                m.Ins.Add(new ImplicitFormal(m.tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(622L, "_noArgsParameter"), argsType, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(623L, true), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(624L, false)));
            }
            if (!m.Outs.TrueForAll(f => f.IsGhost))
            {
                reason = MutateCSharp.Schemata247.ReplaceStringConstant_2(625L, "the method has non-ghost out parameters");
                return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(626L, false);
            }
            if (Attributes.Contains(m.Attributes, MutateCSharp.Schemata247.ReplaceStringConstant_2(627L, "main")))
            {
                reason = "";
                return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(628L, true);
            }
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_21(633L, m.Req.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(629L, 0)))
            {
                reason = MutateCSharp.Schemata247.ReplaceStringConstant_2(638L, "the method has requires clauses");
                return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(639L, false);
            }
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_21(644L, m.Mod.Expressions.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(640L, 0)))
            {
                reason = MutateCSharp.Schemata247.ReplaceStringConstant_2(649L, "the method has modifies clauses");
                return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(650L, false);
            }
            reason = "";
            return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(651L, true);
        }

        void OrderedBySCC(List<MemberDecl> decls, TopLevelDeclWithMembers c)
        {
            List<ConstantField> consts = new List<ConstantField>();
            foreach (var decl in decls)
            {
                if (decl is ConstantField)
                {
                    consts.Add((ConstantField)decl);
                }
            }
            consts.Sort((a, b) => MutateCSharp.Schemata247.ReplaceBinExprOp_37(652L, c.EnclosingModuleDefinition.CallGraph.GetSCCRepresentativeId(a), c.EnclosingModuleDefinition.CallGraph.GetSCCRepresentativeId(b)));
            foreach (var con in consts)
            {
                decls.Remove(con);
            }
            decls.AddRange(consts);
        }

        public virtual bool NeedsCustomReceiver(MemberDecl member)
        {
            Contract.Requires(member != null);
            // One of the limitations in many target language encodings are restrictions to instance members. If an
            // instance member can't be directly expressed in the target language, we make it a static member with an
            // additional first argument specifying the `this`, giving it a `CustomReceiver`.
            if (member.IsStatic)
            {
                return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(661L, false);
            }
            else if (member.EnclosingClass is NewtypeDecl)
            {
                return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(662L, true);
            }
            else if (member.EnclosingClass is TraitDecl)
            {
                return member is ConstantField { Rhs: { } } or Function { Body: { } } or Method { Body: { } };
            }
            else if (member.EnclosingClass is DatatypeDecl datatypeDecl)
            {
                // An undefined value "o" cannot use this o.F(...) form in most languages.
                // Also, an erasable wrapper type has a receiver that's not part of the enclosing target class.
                return datatypeDecl.Ctors.Any(ctor => ctor.IsGhost) || DatatypeWrapperEraser.IsErasableDatatypeWrapper(Options, datatypeDecl, out _);
            }
            else
            {
                return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(663L, false);
            }

            return default;
        }

        void CompileClassMembers(Program program, TopLevelDeclWithMembers c, IClassWriter classWriter)
        {
            Contract.Requires(c != null);
            Contract.Requires(classWriter != null);
            Contract.Requires(thisContext == null);
            Contract.Ensures(thisContext == null);

            var errorWr = classWriter.ErrorWriter();
            var v = new CheckHasNoAssumes_Visitor(this, errorWr);

            var inheritedMembers = c.InheritedMembers;
            OrderedBySCC(inheritedMembers, c);
            OrderedBySCC(c.Members, c);

            if (MutateCSharp.Schemata247.ReplaceBinExprOp_9(664L, () => c is not TraitDecl, () => TraitRepeatsInheritedDeclarations))
            {
                thisContext = c;
                foreach (var member in inheritedMembers.Select(memberx => (memberx as Function)?.ByMethodDecl ?? memberx))
                {
                    Contract.Assert(!member.IsStatic);  // only instance members should ever be added to .InheritedMembers
                    if (member.IsGhost)
                    {
                        // skip
                    }
                    else if (c is TraitDecl)
                    {
                        RedeclareInheritedMember(member, classWriter);
                    }
                    else if (member is ConstantField)
                    {
                        var cf = (ConstantField)member;
                        var cfType = cf.Type.Subst(c.ParentFormalTypeParametersToActuals);
                        if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(671L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_38(670L, cf.Rhs, null), () => c is ClassLikeDecl))
                        {
                            // create a backing field, since this constant field may be assigned in constructors
                            Contract.Assert(!cf.IsStatic); // as checked above, only instance members can be inherited
                            classWriter.DeclareField(MutateCSharp.Schemata247.ReplaceStringConstant_2(677L, "_") + cf.GetCompileName(Options), c, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(678L, false), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(679L, false), cfType, cf.tok, PlaceboValue(cfType, errorWr, cf.tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(680L, true)), cf);
                        }
                        var w = CreateFunctionOrGetter(cf, IdName(cf), c, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(681L, false), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(682L, true), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(683L, true), classWriter);
                        Contract.Assert(w != null);  // since the previous line asked for a body
                        if (MutateCSharp.Schemata247.ReplaceBinExprOp_39(684L, cf.Rhs, null))
                        {
                            EmitCallToInheritedConstRHS(cf, w);
                        }
                        else if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(685L, () => !cf.IsStatic, () => c is ClassLikeDecl))
                        {
                            var sw = EmitReturnExpr(w);
                            sw = EmitCoercionIfNecessary(cfType, cf.Type, cf.tok, sw);
                            // get { return this._{0}; }
                            EmitThis(sw);
                            sw.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(691L, "._{0}"), cf.GetCompileName(Options));
                        }
                        else
                        {
                            EmitReturnExpr(PlaceboValue(cfType, errorWr, cf.tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(692L, true)), w);
                        }
                    }
                    else if (member is Field f)
                    {
                        var fType = f.Type.Subst(c.ParentFormalTypeParametersToActuals);
                        // every field is inherited
                        classWriter.DeclareField(MutateCSharp.Schemata247.ReplaceStringConstant_2(693L, "_") + f.GetCompileName(Options), c, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(694L, false), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(695L, false), fType, f.tok, PlaceboValue(fType, errorWr, f.tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(696L, true)), f);
                        var wGet = classWriter.CreateGetterSetter(IdName(f), f.Type, f.tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(697L, true), member, out var wSet, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(698L, true));
                        {
                            var sw = EmitReturnExpr(wGet);
                            sw = EmitCoercionIfNecessary(fType, f.Type, f.tok, sw);
                            // get { return this._{0}; }
                            EmitThis(sw);
                            sw.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(699L, "._{0}"), f.GetCompileName(Options));
                        }
                        {
                            // set { this._{0} = value; }
                            EmitThis(wSet);
                            wSet.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(700L, "._{0}"), f.GetCompileName(Options));
                            var sw = EmitAssignmentRhs(wSet);
                            sw = EmitCoercionIfNecessary(f.Type, fType, f.tok, sw);
                            EmitSetterParameter(sw);
                        }
                    }
                    else if (member is Function fn)
                    {
                        if (!Attributes.Contains(fn.Attributes, MutateCSharp.Schemata247.ReplaceStringConstant_2(701L, "extern")))
                        {
                            Contract.Assert(fn.Body != null);
                            var w = classWriter.CreateFunction(IdName(fn), CombineAllTypeArguments(fn), fn.Ins, fn.ResultType, fn.tok, fn.IsStatic, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(702L, true), fn, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(703L, true), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(704L, false));
                            EmitCallToInheritedFunction(fn, null, w);
                        }
                    }
                    else if (member is Method method)
                    {
                        if (!Attributes.Contains(method.Attributes, MutateCSharp.Schemata247.ReplaceStringConstant_2(705L, "extern")))
                        {
                            Contract.Assert(method.Body != null);
                            var w = classWriter.CreateMethod(method, CombineAllTypeArguments(member), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(706L, true), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(707L, true), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(708L, false));
                            var wBefore = w.Fork();
                            var wCall = w.Fork();
                            var wAfter = w;
                            EmitCallToInheritedMethod(method, null, wCall, wBefore, wAfter);
                        }
                    }
                    else
                    {
                        Contract.Assert(false);  // unexpected member
                    }
                }
                thisContext = null;
            }

            foreach (MemberDecl memberx in c.Members)
            {
                var member = (memberx as Function)?.ByMethodDecl ?? memberx;
                if (!member.IsStatic)
                {
                    thisContext = c;
                }
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(716L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_8(710L, () => c is TraitDecl, () => MutateCSharp.Schemata247.ReplaceBinExprOp_22(709L, member.OverriddenMember, null)), () => !member.IsOverrideThatAddsBody))
                {
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(722L, () => !member.IsGhost, () => TraitRepeatsInheritedDeclarations))
                    {
                        RedeclareInheritedMember(member, classWriter);
                    }
                    else
                    {
                        // emit nothing in the trait; this member will be emitted in the classes that extend this trait
                    }
                }
                else if (member is Field)
                {
                    var f = (Field)member;
                    if (f.IsGhost)
                    {
                        // emit nothing
                    }
                    else if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(729L, () => !Options.DisallowExterns, () => Attributes.Contains(f.Attributes, MutateCSharp.Schemata247.ReplaceStringConstant_2(728L, "extern"))))
                    {
                        // emit nothing
                    }
                    else if (f is ConstantField)
                    {
                        var cf = (ConstantField)f;
                        if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(750L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_8(735L, () => cf.IsStatic, () => !SupportsStaticsInGenericClasses), () => MutateCSharp.Schemata247.ReplaceBinExprOp_21(745L, cf.EnclosingClass.TypeArgs.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(741L, 0))))
                        {
                            var wBody = classWriter.CreateFunction(IdName(cf), CombineAllTypeArguments(cf), new List<Formal>(), cf.Type, cf.tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(756L, true), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(757L, true), member, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(758L, false), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(759L, false));
                            Contract.Assert(wBody != null);  // since the previous line asked for a body
                            if (MutateCSharp.Schemata247.ReplaceBinExprOp_39(760L, cf.Rhs, null))
                            {
                                CompileReturnBody(cf.Rhs, f.Type, wBody, null);
                            }
                            else
                            {
                                EmitReturnExpr(PlaceboValue(cf.Type, wBody, cf.tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(761L, true)), wBody);
                            }
                        }
                        else
                        {
                            ConcreteSyntaxTree wBody;
                            if (cf.IsStatic)
                            {
                                wBody = CreateFunctionOrGetter(cf, IdName(cf), c, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(762L, true), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(763L, true), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(764L, false), classWriter);
                                Contract.Assert(wBody != null);  // since the previous line asked for a body
                            }
                            else if (NeedsCustomReceiver(cf))
                            {
                                // An instance field in a newtype needs to be modeled as a static function that takes a parameter,
                                // because a newtype value is always represented as some existing type.
                                // Likewise, an instance const with a RHS in a trait needs to be modeled as a static function (in the companion class)
                                // that takes a parameter, because trait-equivalents in target languages don't allow implementations.
                                wBody = classWriter.CreateFunction(IdName(cf), CombineAllTypeArguments(cf), new List<Formal>(), cf.Type, cf.tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(765L, true), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(766L, true), cf, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(767L, false), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(768L, true));
                                Contract.Assert(wBody != null);  // since the previous line asked for a body
                                if (c is TraitDecl)
                                {
                                    // also declare a function for the field in the interface
                                    var wBodyInterface = CreateFunctionOrGetter(cf, IdName(cf), c, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(769L, false), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(770L, false), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(771L, false), classWriter);
                                    Contract.Assert(wBodyInterface == null);  // since the previous line said not to create a body
                                }
                            }
                            else if (c is TraitDecl)
                            {
                                wBody = CreateFunctionOrGetter(cf, IdName(cf), c, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(772L, false), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(773L, false), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(774L, false), classWriter);
                                Contract.Assert(wBody == null);  // since the previous line said not to create a body
                            }
                            else if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(776L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_38(775L, cf.Rhs, null), () => c is ClassLikeDecl))
                            {
                                // create a backing field, since this constant field may be assigned in constructors
                                classWriter.DeclareField(MutateCSharp.Schemata247.ReplaceStringConstant_2(782L, "_") + f.GetCompileName(Options), c, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(783L, false), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(784L, false), f.Type, f.tok, PlaceboValue(f.Type, errorWr, f.tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(785L, true)), f);
                                wBody = CreateFunctionOrGetter(cf, IdName(cf), c, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(786L, false), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(787L, true), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(788L, false), classWriter);
                                Contract.Assert(wBody != null);  // since the previous line asked for a body
                            }
                            else
                            {
                                wBody = CreateFunctionOrGetter(cf, IdName(cf), c, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(789L, false), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(790L, true), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(791L, false), classWriter);
                                Contract.Assert(wBody != null);  // since the previous line asked for a body
                            }
                            if (MutateCSharp.Schemata247.ReplaceBinExprOp_40(792L, wBody, null))
                            {
                                if (MutateCSharp.Schemata247.ReplaceBinExprOp_39(793L, cf.Rhs, null))
                                {
                                    CompileReturnBody(cf.Rhs, cf.Type, wBody, null);
                                }
                                else if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(794L, () => !cf.IsStatic, () => c is ClassLikeDecl))
                                {
                                    var sw = EmitReturnExpr(wBody);
                                    var typeSubst = new Dictionary<TypeParameter, Type>();
                                    cf.EnclosingClass.TypeArgs.ForEach(tp => typeSubst.Add(tp, (Type)new UserDefinedType(tp)));
                                    var typeArgs = CombineAllTypeArguments(cf);
                                    EmitMemberSelect(wr => EmitThis(wr), UserDefinedType.FromTopLevelDecl(c.tok, c), cf,
                                      typeArgs, typeSubst, f.Type, internalAccess: MutateCSharp.Schemata247.ReplaceBooleanConstant_1(800L, true)).EmitRead(sw);
                                }
                                else
                                {
                                    EmitReturnExpr(PlaceboValue(cf.Type, wBody, cf.tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(801L, true)), wBody);
                                }
                            }
                        }
                    }
                    else if (c is TraitDecl)
                    {
                        var wGet = classWriter.CreateGetterSetter(IdName(f), f.Type, f.tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(802L, false), member, out var wSet, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(803L, false));
                        Contract.Assert(wSet == null && wGet == null);  // since the previous line specified no body
                    }
                    else
                    {
                        // A trait field is just declared, not initialized. Any other field gets a default value if field's type is an auto-init type and
                        // gets a placebo value if the field's type is not an auto-init type.
                        var rhs = c is TraitDecl ? null : PlaceboValue(f.Type, errorWr, f.tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(804L, true));
                        classWriter.DeclareField(IdName(f), c, f.IsStatic, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(805L, false), f.Type, f.tok, rhs, f);
                    }
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(807L, () => f is ConstantField, () => MutateCSharp.Schemata247.ReplaceBinExprOp_39(806L, ((ConstantField)f).Rhs, null)))
                    {
                        v.Visit(((ConstantField)f).Rhs);
                    }
                }
                else if (member is Function)
                {
                    var f = (Function)member;
                    if (f.IsGhost)
                    {
                        if (Attributes.Contains(f.Attributes, MutateCSharp.Schemata247.ReplaceStringConstant_2(813L, "test")))
                        {
                            Error(ErrorId.c_test_function_must_be_compilable, f.tok,
              MutateCSharp.Schemata247.ReplaceStringConstant_2(814L, "Function {0} must be compiled to use the {{:test}} attribute"), errorWr, f.FullName);
                        }
                    }
                    else if (f.IsVirtual)
                    {
                        if (MutateCSharp.Schemata247.ReplaceBinExprOp_23(815L, f.OverriddenMember, null))
                        {
                            var w = classWriter.CreateFunction(IdName(f), CombineAllTypeArguments(f), f.Ins, f.ResultType, f.tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(816L, false), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(817L, false), f, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(818L, false), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(819L, false));
                            Contract.Assert(w == null); // since we requested no body
                        }
                        else if (TraitRepeatsInheritedDeclarations)
                        {
                            RedeclareInheritedMember(f, classWriter);
                        }
                        if (MutateCSharp.Schemata247.ReplaceBinExprOp_39(820L, f.Body, null))
                        {
                            CompileFunction(f, classWriter, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(821L, true));
                        }
                    }
                    else if (f.IsExtern(Options))
                    {
                        if (IncludeExternMembers)
                        {
                            CompileFunction(f, classWriter, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(822L, false));
                        }
                    }
                    else if (MutateCSharp.Schemata247.ReplaceBinExprOp_38(823L, f.Body, null))
                    {
                        Error(ErrorId.c_function_has_no_body, f.tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(824L, "Function {0} has no body so it cannot be compiled"), errorWr, f.FullName);
                    }
                    else if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(826L, () => c is NewtypeDecl, () => MutateCSharp.Schemata247.ReplaceBinExprOp_41(825L, f, f.Original)))
                    {
                        CompileFunction(f, classWriter, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(832L, false));
                        var w = classWriter.CreateFunction(IdName(f), CombineAllTypeArguments(f), f.Ins, f.ResultType, f.tok,
            MutateCSharp.Schemata247.ReplaceBooleanConstant_1(833L, false), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(834L, true), f, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(835L, true), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(836L, false));
                        EmitCallToInheritedFunction(f, c, w);
                    }
                    else
                    {
                        CompileFunction(f, classWriter, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(837L, false));
                    }
                    v.Visit(f);
                }
                else if (member is Method m)
                {
                    if (Attributes.Contains(m.Attributes, MutateCSharp.Schemata247.ReplaceStringConstant_2(838L, "synthesize")))
                    {
                        if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(855L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_8(848L, () => m.IsStatic, () => MutateCSharp.Schemata247.ReplaceBinExprOp_4(843L, m.Outs.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(839L, 0))), () => MutateCSharp.Schemata247.ReplaceBinExprOp_31(854L, m.Body, null)))
                        {
                            classWriter.SynthesizeMethod(m, CombineAllTypeArguments(m), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(861L, true), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(862L, true), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(863L, false));
                        }
                        else
                        {
                            Error(ErrorId.c_invalid_synthesize_method, m.tok,
              MutateCSharp.Schemata247.ReplaceStringConstant_2(864L, "Method {0} is annotated with :synthesize but is not static, has a body, or does not return anything"),
                              errorWr, m.FullName);
                        }
                    }
                    else if (m.IsGhost)
                    {
                    }
                    else if (m.IsVirtual)
                    {
                        if (MutateCSharp.Schemata247.ReplaceBinExprOp_23(865L, m.OverriddenMember, null))
                        {
                            var w = classWriter.CreateMethod(m, CombineAllTypeArguments(m), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(866L, false), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(867L, false), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(868L, false));
                            Contract.Assert(w == null); // since we requested no body
                        }
                        else if (TraitRepeatsInheritedDeclarations)
                        {
                            RedeclareInheritedMember(m, classWriter);
                        }
                        if (MutateCSharp.Schemata247.ReplaceBinExprOp_42(869L, m.Body, null))
                        {
                            CompileMethod(program, m, classWriter, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(870L, true));
                        }
                    }
                    else if (m.IsExtern(Options))
                    {
                        if (IncludeExternMembers)
                        {
                            CompileMethod(program, m, classWriter, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(871L, false));
                        }
                    }
                    else if (MutateCSharp.Schemata247.ReplaceBinExprOp_31(872L, m.Body, null))
                    {
                        Error(ErrorId.c_method_has_no_body, m.tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(873L, "Method {0} has no body so it cannot be compiled"), errorWr, m.FullName);
                    }
                    else if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(875L, () => c is NewtypeDecl, () => MutateCSharp.Schemata247.ReplaceBinExprOp_43(874L, m, m.Original)))
                    {
                        CompileMethod(program, m, classWriter, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(881L, false));
                        var w = classWriter.CreateMethod(m, CombineAllTypeArguments(member), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(882L, true), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(883L, true), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(884L, false));
                        var wBefore = w.Fork();
                        var wCall = w.Fork();
                        var wAfter = w;
                        EmitCallToInheritedMethod(m, c, wCall, wBefore, wAfter);
                    }
                    else
                    {
                        CompileMethod(program, m, classWriter, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(885L, false));
                    }
                    v.Visit(m);
                }
                else
                {
                    Contract.Assert(false); throw new cce.UnreachableException();  // unexpected member
                }

                thisContext = null;
            }
        }

        protected ConcreteSyntaxTree /*?*/ CreateFunctionOrGetter(ConstantField cf, string name, TopLevelDecl enclosingDecl, bool isStatic,
          bool createBody, bool forBodyInheritance, IClassWriter classWriter)
        {
            var typeArgs = CombineAllTypeArguments(cf);
            var typeDescriptors = ForTypeDescriptors(typeArgs, cf.EnclosingClass, cf, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(886L, false));
            if (NeedsTypeDescriptors(typeDescriptors))
            {
                return classWriter.CreateFunction(name, typeArgs, new List<Formal>(), cf.Type, cf.tok, isStatic, createBody, cf, forBodyInheritance, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(887L, false));
            }
            else
            {
                return classWriter.CreateGetter(name, enclosingDecl, cf.Type, cf.tok, isStatic, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(888L, true), createBody, cf, forBodyInheritance);
            }

            return default;
        }

        private void RedeclareInheritedMember(MemberDecl member, IClassWriter classWriter)
        {
            Contract.Requires(member != null);
            Contract.Requires(classWriter != null);

            if (member is ConstantField cf)
            {
                var wBody = CreateFunctionOrGetter(cf, IdName(cf), member.EnclosingClass, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(889L, false), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(890L, false), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(891L, false), classWriter);
                Contract.Assert(wBody == null); // since the previous line said not to create a body
            }
            else if (member is Field field)
            {
                var wGet = classWriter.CreateGetterSetter(IdName(field), field.Type, field.tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(892L, false), member, out var wSet, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(893L, false));
                Contract.Assert(wGet == null && wSet == null); // since the previous line said not to create a body
            }
            else if (member is Function)
            {
                var fn = ((Function)member).Original;
                var wBody = classWriter.CreateFunction(IdName(fn), CombineAllTypeArguments(fn), fn.Ins, fn.ResultType, fn.tok, fn.IsStatic, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(894L, false), fn, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(895L, false), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(896L, false));
                Contract.Assert(wBody == null); // since the previous line said not to create a body
            }
            else if (member is Method)
            {
                var method = ((Method)member).Original;
                var wBody = classWriter.CreateMethod(method, CombineAllTypeArguments(method), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(897L, false), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(898L, false), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(899L, false));
                Contract.Assert(wBody == null); // since the previous line said not to create a body
            }
            else
            {
                Contract.Assert(false); // unexpected member
            }
        }

        protected void EmitCallToInheritedConstRHS(ConstantField f, ConcreteSyntaxTree wr)
        {
            Contract.Requires(f != null);
            Contract.Requires(!f.IsStatic);
            Contract.Requires(f.EnclosingClass is TraitDecl);
            Contract.Requires(f.Rhs != null);
            Contract.Requires(wr != null);
            Contract.Requires(thisContext != null);

            var fOriginal = f;

            // In a target language that requires type coercions, the function declared in "thisContext" has
            // the same signature as in "fOriginal.EnclosingClass".
            wr = EmitReturnExpr(wr);
            wr = EmitCoercionIfNecessary(f.Type, fOriginal.Type, f.tok, wr);

            var calleeReceiverType = UserDefinedType.FromTopLevelDecl(f.tok, f.EnclosingClass).Subst(thisContext.ParentFormalTypeParametersToActuals);
            wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(900L, "{0}{1}"), TypeName_Companion(calleeReceiverType, wr, f.tok, f), StaticClassAccessor);
            var typeArgs = CombineAllTypeArguments(f, thisContext);
            EmitNameAndActualTypeArgs(IdName(f), TypeArgumentInstantiation.ToActuals(ForTypeParameters(typeArgs, f, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(901L, true))), f.tok, wr);
            wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(902L, "("));
            var sep = "";
            EmitTypeDescriptorsActuals(ForTypeDescriptors(typeArgs, f.EnclosingClass, f, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(903L, true)), f.tok, wr, ref sep);

            wr.Write(sep);
            var w = EmitCoercionIfNecessary(UserDefinedType.FromTopLevelDecl(f.tok, thisContext), calleeReceiverType, f.tok, wr);
            EmitThis(w, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(904L, true));
            wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(905L, ")"));
        }

        /// <summary>
        /// "heir" is the type declaration that inherits the function. Or, it can be "null" to indicate that the function is declared in
        /// the type itself, in which case the "call to inherited" is actually a call from the dynamically dispatched function to its implementation.
        /// </summary>
        protected void EmitCallToInheritedFunction(Function f, [CanBeNull] TopLevelDeclWithMembers heir, ConcreteSyntaxTree wr)
        {
            Contract.Requires(f != null);
            Contract.Requires(!f.IsStatic);
            Contract.Requires(f.EnclosingClass is TraitDecl);
            Contract.Requires(f.Body != null);
            Contract.Requires(wr != null);
            Contract.Requires(thisContext != null);

            // There are three types involved.
            // First, "f.Original.EnclosingClass" is the trait where the function was first declared.
            // In descendant traits from there on, the function may occur several times, each time with
            // a strengthening of the specification. Those traits do not play a role here.
            // Second, there is "f.EnclosingClass", which is the trait where the function is given a body.
            // Often, "f.EnclosingClass" and "f.Original.EnclosingClass" will be the same.
            // Third and finally, there is "thisContext", which is the class that inherits "f" and its
            // implementation, and for which we're about to generate a call to the body compiled for "f".

            // In a target language that requires type coercions, the function declared in "thisContext" has
            // the same signature as in "f.Original.EnclosingClass".
            wr = EmitReturnExpr(wr);
            wr = EmitCoercionIfNecessary(f.ResultType, f.Original.ResultType, f.tok, wr);

            var companionName = CompanionMemberIdName(f);
            var calleeReceiverType = UserDefinedType.FromTopLevelDecl(f.tok, f.EnclosingClass).Subst(thisContext.ParentFormalTypeParametersToActuals);
            wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(906L, "{0}{1}"), TypeName_Companion(calleeReceiverType, wr, f.tok, f), StaticClassAccessor);
            var typeArgs = CombineAllTypeArguments(f, thisContext);
            EmitNameAndActualTypeArgs(companionName, TypeArgumentInstantiation.ToActuals(ForTypeParameters(typeArgs, f, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(907L, true))), f.tok, wr);
            wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(908L, "("));
            var sep = "";
            EmitTypeDescriptorsActuals(ForTypeDescriptors(typeArgs, f.EnclosingClass, f, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(909L, true)), f.tok, wr, ref sep);

            wr.Write(sep);
            var w = EmitCoercionIfNecessary(UserDefinedType.FromTopLevelDecl(f.tok, thisContext), calleeReceiverType, f.tok, wr);
            EmitThis(MutateCSharp.Schemata247.ReplaceBinExprOp_35(910L, heir, null) ? FromFatPointer(UserDefinedType.FromTopLevelDecl(f.tok, heir), w) : w, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(911L, true));
            sep = MutateCSharp.Schemata247.ReplaceStringConstant_2(912L, ", ");

            for (int j = MutateCSharp.Schemata247.ReplaceNumericConstant_3(913L, 0), l = MutateCSharp.Schemata247.ReplaceNumericConstant_3(917L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(921L, j, f.Ins.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(926L, ref j))
            {
                var p = f.Ins[j];
                if (!p.IsGhost)
                {
                    wr.Write(sep);
                    w = EmitCoercionIfNecessary(f.Original.Ins[j].Type, f.Ins[j].Type, f.tok, wr);
                    w.Write(IdName(p));
                    sep = MutateCSharp.Schemata247.ReplaceStringConstant_2(927L, ", ");
                    MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(928L, ref l);
                }
            }
            wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(929L, ")"));
        }

        protected virtual void EmitCallReturnOuts(List<string> outTmps, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(930L, "{0} = "), Util.Comma(outTmps));
        }

        protected virtual void EmitMultiReturnTuple(List<Formal> outs, List<Type> outTypes, List<string> outTmps, IToken methodToken, ConcreteSyntaxTree wr)
        {
            var wrReturn = EmitReturnExpr(wr);
            var sep = "";
            for (int j = MutateCSharp.Schemata247.ReplaceNumericConstant_3(931L, 0), l = MutateCSharp.Schemata247.ReplaceNumericConstant_3(935L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(939L, j, outs.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(944L, ref j))
            {
                var p = outs[j];
                if (!p.IsGhost)
                {
                    wrReturn.Write(sep);
                    var w = EmitCoercionIfNecessary(outs[j].Type, outTypes[l], methodToken, wrReturn);
                    w.Write(outTmps[l]);
                    sep = MutateCSharp.Schemata247.ReplaceStringConstant_2(945L, ", ");
                    MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(946L, ref l);
                }
            }
        }

        /// <summary>
        /// "heir" is the type declaration that inherits the method. Or, it can be "null" to indicate that the method is declared in
        /// the type itself, in which case the "call to inherited" is actually a call from the dynamically dispatched method to its implementation.
        /// </summary>
        protected virtual void EmitCallToInheritedMethod(Method method, [CanBeNull] TopLevelDeclWithMembers heir, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts, ConcreteSyntaxTree wStmtsAfterCall)
        {
            Contract.Requires(method != null);
            Contract.Requires(!method.IsStatic);
            Contract.Requires(method.EnclosingClass is TraitDecl);
            Contract.Requires(method.Body != null);
            Contract.Requires(wr != null);
            Contract.Requires(thisContext != null);

            // There are three types involved. See comment in EmitCallToInheritedFunction.

            var nonGhostOutParameterCount = method.Outs.Count(p => !p.IsGhost);
            var returnStyleOuts = UseReturnStyleOuts(method, nonGhostOutParameterCount);
            var returnStyleOutCollector = MutateCSharp.Schemata247.ReplaceBinExprOp_8(962L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_8(956L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_4(951L, nonGhostOutParameterCount, MutateCSharp.Schemata247.ReplaceNumericConstant_3(947L, 1)), () => returnStyleOuts), () => !SupportsMultipleReturns) ? ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(968L, "_outcollector")) : null;

            var outTmps = new List<string>();  // contains a name for each non-ghost formal out-parameter
            var outTypes = new List<Type>();  // contains a type for each non-ghost formal out-parameter
            for (int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(969L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(973L, i, method.Outs.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(978L, ref i))
            {
                Formal p = method.Outs[i];
                if (!p.IsGhost)
                {
                    var target = returnStyleOutCollector != null ? IdName(p) : ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(979L, "_out"));
                    outTmps.Add(target);
                    outTypes.Add(p.Type);
                    DeclareLocalVar(target, p.Type, p.tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(980L, false), null, wStmts);
                }
            }
            Contract.Assert(outTmps.Count == nonGhostOutParameterCount && outTypes.Count == nonGhostOutParameterCount);

            if (returnStyleOutCollector != null)
            {
                DeclareSpecificOutCollector(returnStyleOutCollector, wr, outTypes, outTypes);
            }
            else if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(990L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_4(985L, nonGhostOutParameterCount, MutateCSharp.Schemata247.ReplaceNumericConstant_3(981L, 0)), () => returnStyleOuts))
            {
                EmitCallReturnOuts(outTmps, wr);
            }

            var companionName = CompanionMemberIdName(method);
            var calleeReceiverType = UserDefinedType.FromTopLevelDecl(method.tok, method.EnclosingClass).Subst(thisContext.ParentFormalTypeParametersToActuals);
            EmitTypeName_Companion(calleeReceiverType, wr, wr, method.tok, method);
            wr.Write(StaticClassAccessor);

            var typeArgs = CombineAllTypeArguments(method, thisContext);
            EmitNameAndActualTypeArgs(companionName, TypeArgumentInstantiation.ToActuals(ForTypeParameters(typeArgs, method, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(996L, true))), method.tok, wr);
            wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(997L, "("));
            var sep = "";
            EmitTypeDescriptorsActuals(ForTypeDescriptors(typeArgs, method.EnclosingClass, method, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(998L, true)), method.tok, wr, ref sep);

            wr.Write(sep);
            var w = EmitCoercionIfNecessary(UserDefinedType.FromTopLevelDecl(method.tok, thisContext), calleeReceiverType, method.tok, wr);
            EmitThis(MutateCSharp.Schemata247.ReplaceBinExprOp_35(999L, heir, null) ? FromFatPointer(UserDefinedType.FromTopLevelDecl(method.tok, heir), w) : w, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1000L, true));
            sep = MutateCSharp.Schemata247.ReplaceStringConstant_2(1001L, ", ");

            for (int j = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1002L, 0), l = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1006L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(1010L, j, method.Ins.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(1015L, ref j))
            {
                var p = method.Ins[j];
                if (!p.IsGhost)
                {
                    wr.Write(sep);
                    w = EmitCoercionIfNecessary(method.Original.Ins[j].Type, method.Ins[j].Type, method.tok, wr);
                    EmitIdentifier(IdName(p), w);
                    sep = MutateCSharp.Schemata247.ReplaceStringConstant_2(1016L, ", ");
                    MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(1017L, ref l);
                }
            }

            if (!returnStyleOuts)
            {
                foreach (var outTmp in outTmps)
                {
                    wr.Write(sep);
                    EmitActualOutArg(outTmp, wr);
                    sep = MutateCSharp.Schemata247.ReplaceStringConstant_2(1018L, ", ");
                }
            }
            wr.Write(')');
            EndStmt(wr);

            if (returnStyleOutCollector != null)
            {
                EmitCastOutParameterSplits(returnStyleOutCollector, outTmps, wStmtsAfterCall, outTypes, outTypes, method.tok);
                EmitReturn(method.Outs, wStmtsAfterCall);
            }
            else if (!returnStyleOuts)
            {
                for (int j = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1019L, 0), l = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1023L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(1027L, j, method.Outs.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(1032L, ref j))
                {
                    var p = method.Outs[j];
                    if (!p.IsGhost)
                    {
                        EmitAssignment(IdName(p), method.Outs[j].Type, outTmps[l], outTypes[l], wStmtsAfterCall);
                        MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(1033L, ref l);
                    }
                }
            }
            else
            {
                EmitMultiReturnTuple(method.Outs, outTypes, outTmps, method.tok, wStmtsAfterCall);
            }
        }

        protected List<TypeArgumentInstantiation> CombineAllTypeArguments(MemberDecl member)
        {
            Contract.Requires(member != null);
            var classActuals = member.EnclosingClass.TypeArgs.ConvertAll(tp => (Type)new UserDefinedType(tp));
            var memberActuals = member is ICallable ic ? ic.TypeArgs.ConvertAll(tp => (Type)new UserDefinedType(tp)) : null;
            return CombineAllTypeArguments(member, classActuals, memberActuals);
        }

        protected List<TypeArgumentInstantiation> CombineAllTypeArguments(MemberDecl member, TopLevelDeclWithMembers receiverContext)
        {
            Contract.Requires(member is ICallable);
            Contract.Requires(receiverContext != null);
            var classActuals = member.EnclosingClass.TypeArgs.ConvertAll(tp => receiverContext.ParentFormalTypeParametersToActuals[tp]);
            var memberActuals = ((ICallable)member).TypeArgs.ConvertAll(tp => (Type)new UserDefinedType(tp));
            return CombineAllTypeArguments(member, classActuals, memberActuals);
        }

        protected List<TypeArgumentInstantiation> CombineAllTypeArguments(MemberDecl member, List<Type> typeArgsEnclosingClass, List<Type> typeArgsMember)
        {
            Contract.Requires(member != null);
            Contract.Requires(typeArgsEnclosingClass != null);
            Contract.Requires(typeArgsMember != null);

            return TypeArgumentInstantiation.ListFromMember(member, typeArgsEnclosingClass, typeArgsMember);
        }

        protected int WriteRuntimeTypeDescriptorsFormals(List<TypeArgumentInstantiation> typeParams,
          ConcreteSyntaxTree wr, ref string prefix, Func<TypeParameter, string> formatter)
        {
            Contract.Requires(typeParams != null);
            Contract.Requires(prefix != null);
            Contract.Requires(wr != null);
            Contract.Ensures(Contract.ValueAtReturn(out prefix) != null);

            var c = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1034L, 0);
            foreach (var ta in typeParams)
            {
                var tp = ta.Formal;
                if (NeedsTypeDescriptor(tp))
                {
                    var formatted = formatter(tp);
                    wr.Write($"{prefix}{formatted}");
                    prefix = MutateCSharp.Schemata247.ReplaceStringConstant_2(1038L, ", ");
                    MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(1039L, ref c);
                }
            }
            return c;
        }

        /// <summary>
        /// Check whether two declarations have the same name if capitalized.
        /// </summary>
        /// <param name="canChange">The declarations to check.</param>
        /// <param name="cantChange">Additional declarations which may conflict, but which can't be given different names.  For example, these may be the inherited members of a class.</param>
        /// <remarks>
        /// If two elements of <paramref name="canChange"/> have the same
        /// capitalization, the lowercase one will get a
        /// <c>{:_capitalizationConflict}</c> attribute.  If
        /// <paramref name="cantChange"/> is given and one of its elements conflicts
        /// with one from <paramref name="canChange"/>, the element from
        /// <paramref name="canChange"/> gets the attribute whether it is lowercase
        /// or not.
        /// </remarks>
        /// <seealso cref="HasCapitalizationConflict"/>
        private void CheckForCapitalizationConflicts<T>(IEnumerable<T> canChange, IEnumerable<T> cantChange = null) where T : Declaration
        {
            if (cantChange == null)
            {
                cantChange = Enumerable.Empty<T>();
            }
            IDictionary<string, T> declsByCapName = new Dictionary<string, T>();
            ISet<string> fixedNames = new HashSet<string>(from decl in cantChange select Capitalize(decl.GetCompileName(Options)));

            foreach (var decl in canChange)
            {
                var name = decl.GetCompileName(Options);
                var capName = Capitalize(name);
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_33(1040L, name, capName))
                {
                    if (fixedNames.Contains(name))
                    {
                        // Normally we mark the lowercase one, but in this case we can't change that one
                        MarkCapitalizationConflict(decl);
                    }
                    else
                    {
                        if (declsByCapName.TryGetValue(name, out var other))
                        {
                            // Presume that the other is the lowercase one
                            MarkCapitalizationConflict(other);
                        }
                        else
                        {
                            declsByCapName.Add(name, decl);
                        }
                    }
                }
                else
                {
                    if (declsByCapName.ContainsKey(capName))
                    {
                        MarkCapitalizationConflict(decl);
                    }
                    else
                    {
                        declsByCapName.Add(capName, decl);
                    }
                }
            }
        }

        protected string Capitalize(string str)
        {
            if (!str.Any(c => MutateCSharp.Schemata247.ReplaceBinExprOp_21(1041L, c, '_')))
            {
                return PrefixForForcedCapitalization + str;
            }
            var origStr = str;
            while (str.StartsWith(MutateCSharp.Schemata247.ReplaceStringConstant_2(1046L, "_")))
            {
                str = str.Substring(MutateCSharp.Schemata247.ReplaceNumericConstant_3(1047L, 1)) + MutateCSharp.Schemata247.ReplaceStringConstant_2(1051L, "_");
            }
            if (!char.IsLetter(str[MutateCSharp.Schemata247.ReplaceNumericConstant_3(1052L, 0)]))
            {
                return PrefixForForcedCapitalization + origStr;
            }
            else
            {
                return char.ToUpper(str[MutateCSharp.Schemata247.ReplaceNumericConstant_3(1056L, 0)]) + str.Substring(MutateCSharp.Schemata247.ReplaceNumericConstant_3(1060L, 1));
            }

            return default;
        }

        protected virtual string PrefixForForcedCapitalization { get => MutateCSharp.Schemata247.ReplaceStringConstant_2(1064L, "Cap_"); }

        private static void MarkCapitalizationConflict(Declaration decl)
        {
            decl.Attributes = new Attributes(CapitalizationConflictAttribute, new List<Expression>(), decl.Attributes);
        }

        protected static bool HasCapitalizationConflict(Declaration decl)
        {
            return Attributes.Contains(decl.Attributes, CapitalizationConflictAttribute);
        }

        private static readonly string CapitalizationConflictAttribute = MutateCSharp.Schemata247.ReplaceStringConstant_2(1065L, "_capitalizationConflict");

        private void CompileFunction(Function f, IClassWriter cw, bool lookasideBody)
        {
            Contract.Requires(f != null);
            Contract.Requires(cw != null);
            Contract.Requires(f.Body != null || (IncludeExternMembers && Attributes.Contains(f.Attributes, "extern")));

            var w = cw.CreateFunction(IdName(f), CombineAllTypeArguments(f),
              f.Ins, f.ResultType, f.tok, f.IsStatic,
              !f.IsExtern(Options, out _, out _), f, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1066L, false), lookasideBody);
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_40(1067L, w, null))
            {
                IVariable accVar = null;
                if (f.IsTailRecursive)
                {
                    if (f.IsAccumulatorTailRecursive)
                    {
                        accVar = new LocalVariable(f.RangeToken, MutateCSharp.Schemata247.ReplaceStringConstant_2(1068L, "_accumulator"), f.ResultType, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1069L, false))
                        {
                            type = f.ResultType
                        };
                        var resultType = f.ResultType.NormalizeToAncestorType();
                        Expression unit;
                        if (MutateCSharp.Schemata247.ReplaceBinExprOp_9(1070L, () => resultType.IsNumericBased(Type.NumericPersuasion.Int), () => resultType.IsBigOrdinalType))
                        {
                            unit = new LiteralExpr(f.tok, MutateCSharp.Schemata247.ReplaceBinExprOp_44(1076L, f.TailRecursion, Function.TailStatus.Accumulate_Mul) ? MutateCSharp.Schemata247.ReplaceNumericConstant_3(1077L, 1) : MutateCSharp.Schemata247.ReplaceNumericConstant_3(1081L, 0));
                            unit.Type = f.ResultType;
                        }
                        else if (resultType.IsNumericBased(Type.NumericPersuasion.Real))
                        {
                            unit = new LiteralExpr(f.tok, MutateCSharp.Schemata247.ReplaceBinExprOp_44(1085L, f.TailRecursion, Function.TailStatus.Accumulate_Mul) ? BigDec.FromInt(MutateCSharp.Schemata247.ReplaceNumericConstant_3(1086L, 1)) : BigDec.ZERO);
                            unit.Type = f.ResultType;
                        }
                        else if (resultType.IsBitVectorType)
                        {
                            var n = MutateCSharp.Schemata247.ReplaceBinExprOp_44(1090L, f.TailRecursion, Function.TailStatus.Accumulate_Mul) ? MutateCSharp.Schemata247.ReplaceNumericConstant_3(1091L, 1) : MutateCSharp.Schemata247.ReplaceNumericConstant_3(1095L, 0);
                            unit = new LiteralExpr(f.tok, n);
                            unit.Type = f.ResultType;
                        }
                        else if (MutateCSharp.Schemata247.ReplaceBinExprOp_45(1099L, resultType.AsSetType, null))
                        {
                            unit = new SetDisplayExpr(f.tok, !resultType.IsISetType, new List<Expression>());
                            unit.Type = f.ResultType;
                        }
                        else if (MutateCSharp.Schemata247.ReplaceBinExprOp_46(1100L, resultType.AsMultiSetType, null))
                        {
                            unit = new MultiSetDisplayExpr(f.tok, new List<Expression>());
                            unit.Type = f.ResultType;
                        }
                        else if (MutateCSharp.Schemata247.ReplaceBinExprOp_11(1101L, resultType.AsSeqType, null))
                        {
                            unit = new SeqDisplayExpr(f.tok, new List<Expression>());
                            unit.Type = f.ResultType;
                        }
                        else
                        {
                            Contract.Assert(false);  // unexpected type
                            throw new cce.UnreachableException();
                        }
                        DeclareLocalVar(IdName(accVar), accVar.Type, f.tok, unit, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1102L, false), w);
                    }
                    w = EmitTailCallStructure(f, w);
                }
                Coverage.Instrument(f.Body.tok, $"entry to function {f.FullName}", w);
                Contract.Assert(enclosingFunction == null);
                enclosingFunction = f;
                CompileReturnBody(f.Body, f.Original.ResultType, w, accVar);
                Contract.Assert(enclosingFunction == f);
                enclosingFunction = null;
            }
        }

        public const string STATIC_ARGS_NAME = "args";

        private void CompileMethod(Program program, Method m, IClassWriter cw, bool lookasideBody)
        {
            Contract.Requires(cw != null);
            Contract.Requires(m != null);
            Contract.Requires(m.Body != null || (IncludeExternMembers && Attributes.Contains(m.Attributes, "extern")));

            var w = cw.CreateMethod(m, CombineAllTypeArguments(m), !m.IsExtern(Options, out _, out _), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1103L, false), lookasideBody);
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_40(1104L, w, null))
            {
                if (m.IsTailRecursive)
                {
                    w = EmitTailCallStructure(m, w);
                }

                Coverage.Instrument(m.Body.Tok, $"entry to method {m.FullName}", w);

                var nonGhostOutsCount = m.Outs.Count(p => !p.IsGhost);

                var useReturnStyleOuts = UseReturnStyleOuts(m, nonGhostOutsCount);
                foreach (var p in m.Outs)
                {
                    if (!p.IsGhost)
                    {
                        DeclareLocalOutVar(IdName(p), p.Type, p.tok, PlaceboValue(p.Type, w, p.tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1105L, true)), useReturnStyleOuts, w);
                    }
                }

                w = EmitMethodReturns(m, w);

                if (MutateCSharp.Schemata247.ReplaceBinExprOp_31(1106L, m.Body, null))
                {
                    Error(ErrorId.c_method_has_no_body, m.tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(1107L, "Method {0} has no body so it cannot be compiled"), w, m.FullName);
                }
                else
                {
                    Contract.Assert(enclosingMethod == null);
                    enclosingMethod = m;
                    TrStmtList(m.Body.Body, w);
                    Contract.Assert(enclosingMethod == m);
                    enclosingMethod = null;
                }
            }

            if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(1109L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_47(1108L, m, program.MainMethod), () => IssueCreateStaticMain(m)))
            {
                w = CreateStaticMain(cw, STATIC_ARGS_NAME);
                var ty = UserDefinedType.FromTopLevelDeclWithAllBooleanTypeParameters(m.EnclosingClass);
                LocalVariable receiver = null;
                if (!m.IsStatic)
                {
                    receiver = new LocalVariable(m.RangeToken, MutateCSharp.Schemata247.ReplaceStringConstant_2(1115L, "b"), ty, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1116L, false))
                    {
                        type = ty
                    };
                    if (m.EnclosingClass is ClassLikeDecl)
                    {
                        var wStmts = w.Fork();
                        var wRhs = DeclareLocalVar(IdName(receiver), ty, m.tok, w);
                        EmitNew(ty, m.tok, null, wRhs, wStmts);
                    }
                    else
                    {
                        TrLocalVar(receiver, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1117L, true), w);
                    }
                }
                var typeArgs = CombineAllTypeArguments(m, ty.TypeArgs, m.TypeArgs.ConvertAll(tp => (Type)Type.Bool));
                bool customReceiver = MutateCSharp.Schemata247.ReplaceBinExprOp_8(1118L, () => !(m.EnclosingClass is TraitDecl), () => NeedsCustomReceiver(m));

                if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(1125L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_48(1124L, receiver, null), () => !customReceiver))
                {
                    w.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(1131L, "{0}."), IdName(receiver));
                }
                else
                {
                    var companion = TypeName_Companion(UserDefinedType.FromTopLevelDeclWithAllBooleanTypeParameters(m.EnclosingClass), w, m.tok, m);
                    w.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(1132L, "{0}."), companion);
                }
                EmitNameAndActualTypeArgs(IdName(m), TypeArgumentInstantiation.ToActuals(ForTypeParameters(typeArgs, m, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1133L, false))), m.tok, w);
                w.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(1134L, "("));
                var sep = "";
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(1136L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_48(1135L, receiver, null), () => customReceiver))
                {
                    w.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(1142L, "{0}"), IdName(receiver));
                    sep = MutateCSharp.Schemata247.ReplaceStringConstant_2(1143L, ", ");
                }
                EmitTypeDescriptorsActuals(ForTypeDescriptors(typeArgs, m.EnclosingClass, m, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1144L, false)), m.tok, w, ref sep);
                w.Write(sep + STATIC_ARGS_NAME);
                w.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(1145L, ")"));
                EndStmt(w);
            }
        }

        protected virtual bool IssueCreateStaticMain(Method m)
        {
            return MutateCSharp.Schemata247.ReplaceBinExprOp_9(1155L, () => !m.IsStatic, () => MutateCSharp.Schemata247.ReplaceBinExprOp_21(1150L, m.EnclosingClass.TypeArgs.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1146L, 0)));
        }

        /// <summary>
        /// This method in a target statement-context version of "TrCasePattern", in the same way that "TrExprOpt" is a
        /// target statement-context version of "Expr(...)" (see comment by "TrExprOpt").
        /// </summary>
        void TrCasePatternOpt<VT>(CasePattern<VT> pat, Expression rhs, ConcreteSyntaxTree wr, bool inLetExprBody)
          where VT : class, IVariable
        {
            TrCasePatternOpt(pat, rhs, null, rhs.Type, rhs.tok, wr, inLetExprBody);
        }

        /// <summary>
        /// This method in a target statement-context version of "TrCasePattern", in the same way that "TrExprOpt" is a
        /// target statement-context version of "Expr(...)" (see comment by "TrExprOpt").
        /// </summary>
        void TrCasePatternOpt<VT>(CasePattern<VT> pat, Expression rhs, Action<ConcreteSyntaxTree> emitRhs, Type rhsType, IToken rhsTok, ConcreteSyntaxTree wr, bool inLetExprBody)
          where VT : class, IVariable
        {
            Contract.Requires(pat != null);
            Contract.Requires(pat.Var != null || rhs != null || emitRhs != null);
            Contract.Requires(rhs != null || emitRhs != null);
            Contract.Requires(rhsType != null && rhsTok != null);

            if (pat.Var != null)
            {
                // The trivial Dafny "pattern" expression
                //    var x := G
                // is translated into C# as:
                // var x := G;
                var bv = pat.Var;
                if (!bv.IsGhost)
                {
                    var wStmts = wr.Fork();
                    var w = DeclareLocalVar(IdName(bv), bv.Type, rhsTok, wr);
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_39(1161L, rhs, null))
                    {
                        w = EmitCoercionIfNecessary(from: rhs.Type, to: bv.Type, tok: rhsTok, wr: w);
                        EmitExpr(rhs, inLetExprBody, w, wStmts);
                    }
                    else
                    {
                        emitRhs(w);
                    }
                }
            }
            else if (pat.Arguments != null)
            {
                // The Dafny "pattern" expression
                //    var Pattern(x,y) := G
                // is translated into C# as:
                // var tmp := G;
                // var x := dtorX(tmp);
                // var y := dtorY(tmp);
                var ctor = pat.Ctor;
                Contract.Assert(ctor != null);  // follows from successful resolution
                Contract.Assert(pat.Arguments.Count == ctor.Formals.Count);  // follows from successful resolution

                // Create the temporary variable to hold G
                var tmp_name = ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(1162L, "_let_tmp_rhs"));
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_39(1163L, rhs, null))
                {
                    DeclareLocalVar(tmp_name, rhs.Type, rhs.tok, rhs, inLetExprBody, wr);
                }
                else
                {
                    var w = DeclareLocalVar(tmp_name, rhsType, rhsTok, wr);
                    emitRhs(w);
                }

                var dtv = (DatatypeValue)pat.Expr;
                var substMap = TypeParameter.SubstitutionMap(ctor.EnclosingDatatype.TypeArgs, dtv.InferredTypeArgs);
                var k = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1164L, 0);  // number of non-ghost formals processed
                for (int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1168L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(1172L, i, pat.Arguments.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(1177L, ref i))
                {
                    var arg = pat.Arguments[i];
                    var formal = ctor.Formals[i];
                    if (formal.IsGhost)
                    {
                        // nothing to compile, but do a sanity check
                        Contract.Assert(Contract.ForAll(arg.Vars, bv => bv.IsGhost));
                    }
                    else
                    {
                        Type targetType = formal.Type.Subst(substMap);
                        TrCasePatternOpt(arg, null, sw => EmitDestructor(wr => EmitIdentifier(tmp_name, wr), formal, k, ctor, dtv.InferredTypeArgs, arg.Expr.Type, sw), targetType, pat.Expr.tok, wr, inLetExprBody);
                        MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(1178L, ref k);
                    }
                }
            }
        }

        /// <summary>
        /// This method compiles "expr" into a statement context of the target. This typically means that, for example, Dafny let-bound variables can
        /// be compiled into local variables in the target code, and that Dafny if-then-else expressions can be compiled into if statements in the
        /// target code.
        /// In contrast, the "Expr(...)" method compiles its given expression into an expression context of the target. This can result in
        /// more complicated constructions in target languages that don't support name bindings in expressions (like most of our target
        /// languages) or that don't support if-then-else expressions (like Go).
        /// Other than the syntactic differences in the target code, the idea is that "TrExprOpt(...)" and "Expr(...)" generate code with the
        /// same semantics.
        /// </summary>
        void TrExprOpt(Expression expr, Type resultType, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts, bool inLetExprBody, [CanBeNull] IVariable accumulatorVar)
        {
            Contract.Requires(expr != null);
            Contract.Requires(wr != null);
            Contract.Requires(resultType != null);
            Contract.Requires(accumulatorVar == null || (enclosingFunction != null && enclosingFunction.IsAccumulatorTailRecursive));

            expr = expr.Resolved;
            if (expr is LetExpr)
            {
                var e = (LetExpr)expr;
                if (e.Exact)
                {
                    for (int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1179L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(1183L, i, e.LHSs.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(1188L, ref i))
                    {
                        var lhs = e.LHSs[i];
                        if (Contract.Exists(lhs.Vars, bv => !bv.IsGhost))
                        {
                            TrCasePatternOpt(lhs, e.RHSs[i], wr, inLetExprBody);
                        }
                    }
                    TrExprOpt(e.Body, resultType, wr, wStmts, inLetExprBody, accumulatorVar);
                }
                else
                {
                    // We haven't optimized the other cases, so fallback to normal compilation
                    EmitReturnExpr(e, resultType, inLetExprBody, wr);
                }

            }
            else if (expr is ITEExpr)
            {
                var e = (ITEExpr)expr;
                switch (e.HowToCompile)
                {
                    case ITEExpr.ITECompilation.CompileJustThenBranch:
                        TrExprOpt(e.Thn, resultType, wr, wStmts, inLetExprBody, accumulatorVar);
                        break;
                        break;
                    case ITEExpr.ITECompilation.CompileJustElseBranch:
                        TrExprOpt(e.Els, resultType, wr, wStmts, inLetExprBody, accumulatorVar);
                        break;
                        break;
                    case ITEExpr.ITECompilation.CompileBothBranches:
                        var thn = EmitIf(out var guardWriter, true, wr);
                        EmitExpr(e.Test, inLetExprBody, guardWriter, wStmts);
                        Coverage.Instrument(e.Thn.tok, "then branch", thn);
                        TrExprOpt(e.Thn, resultType, thn, wStmts, inLetExprBody, accumulatorVar);
                        ConcreteSyntaxTree els = wr;
                        if (!(e.Els is ITEExpr { HowToCompile: ITEExpr.ITECompilation.CompileBothBranches }))
                        {
                            els = EmitBlock(wr);
                            Coverage.Instrument(e.Thn.tok, "else branch", els);
                        }
                        TrExprOpt(e.Els, resultType, els, wStmts, inLetExprBody, accumulatorVar);
                        break;
                        break;
                }

            }
            else if (expr is NestedMatchExpr nestedMatchExpr)
            {
                TrExprOpt(nestedMatchExpr.Flattened, resultType, wr, wStmts, inLetExprBody, accumulatorVar);
            }
            else if (expr is MatchExpr)
            {
                var e = (MatchExpr)expr;
                //   var _source = E;
                //   if (source.is_Ctor0) {
                //     FormalType f0 = ((Dt_Ctor0)source._D).a0;
                //     ...
                //     return Body0;
                //   } else if (...) {
                //     ...
                //   } else if (true) {
                //     ...
                //   }
                string source = ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(1189L, "_source"));
                DeclareLocalVar(source, e.Source.Type, e.Source.tok, e.Source, inLetExprBody, wr);
                wStmts = wr.Fork();

                if (MutateCSharp.Schemata247.ReplaceBinExprOp_27(1194L, e.Cases.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1190L, 0)))
                {
                    // the verifier would have proved we never get here; still, we need some code that will compile
                    EmitAbsurd(null, wr);
                }
                else
                {
                    int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1199L, 0);
                    var sourceType = (UserDefinedType)e.Source.Type.NormalizeExpand();
                    foreach (MatchCaseExpr mc in e.Cases)
                    {
                        var w = MatchCasePrelude(source, sourceType, mc.Ctor, mc.Arguments, i, e.Cases.Count, wr);
                        TrExprOpt(mc.Body, resultType, w, wStmts, inLetExprBody, accumulatorVar);
                        MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(1203L, ref i);
                    }
                }

            }
            else if (expr is StmtExpr)
            {
                var e = (StmtExpr)expr;
                TrExprOpt(e.E, resultType, wr, wStmts, inLetExprBody, accumulatorVar);

            }
            else if (expr is FunctionCallExpr fce && fce.Function == enclosingFunction && enclosingFunction.IsTailRecursive)
            {
                var e = fce;
                // compile call as tail-recursive

                // assign the actual in-parameters to temporary variables
                var inTmps = new List<string>();
                var inTypes = new List<Type/*?*/>();
                if (!e.Function.IsStatic)
                {
                    string inTmp = ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(1204L, "_in"));
                    inTmps.Add(inTmp);
                    inTypes.Add(null);
                    DeclareLocalVar(inTmp, null, null, e.Receiver, inLetExprBody, wr);
                }
                for (int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1205L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(1209L, i, e.Function.Ins.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(1214L, ref i))
                {
                    Formal p = e.Function.Ins[i];
                    if (!p.IsGhost)
                    {
                        string inTmp = ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(1215L, "_in"));
                        inTmps.Add(inTmp);
                        inTypes.Add(e.Args[i].Type);
                        DeclareLocalVar(inTmp, e.Args[i].Type, p.tok, e.Args[i], inLetExprBody, wr);
                    }
                }
                // Now, assign to the formals
                int n = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1216L, 0);
                if (!e.Function.IsStatic)
                {
                    ConcreteSyntaxTree wRHS = EmitAssignment(IdentLvalue(MutateCSharp.Schemata247.ReplaceStringConstant_2(1220L, "_this")), null, null, wr, e.tok);
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_49(1221L, thisContext, null))
                    {
                        wRHS = wr;
                    }
                    else
                    {
                        var instantiatedType = e.Receiver.Type.Subst(thisContext.ParentFormalTypeParametersToActuals);

                        var contextType = UserDefinedType.FromTopLevelDecl(e.tok, thisContext);
                        if (contextType.ResolvedClass is ClassLikeDecl { NonNullTypeDecl: { } } cls)
                        {
                            contextType = UserDefinedType.FromTopLevelDecl(e.tok, cls.NonNullTypeDecl);
                        }

                        wRHS = EmitCoercionIfNecessary(instantiatedType, contextType, e.tok, wRHS);
                    }
                    EmitIdentifier(inTmps[n], wRHS);
                    EndStmt(wr);
                    MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(1222L, ref n);
                }
                foreach (var p in e.Function.Ins)
                {
                    if (!p.IsGhost)
                    {
                        EmitIdentifier(
                          inTmps[n],
                          EmitAssignment(IdentLvalue(IdName(p)), p.Type, inTypes[n], wr, e.tok)
                        );
                        MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(1223L, ref n);
                    }
                }
                Contract.Assert(n == inTmps.Count);
                // finally, the jump back to the head of the function
                EmitJumpToTailCallStart(wr);

            }
            else if (expr is BinaryExpr bin
                       && bin.AccumulatesForTailRecursion != BinaryExpr.AccumulationOperand.None
                       && enclosingFunction is { IsAccumulatorTailRecursive: true }
                       && MutateCSharp.Schemata247.ReplaceBinExprOp_50(1224L, accumulatorVar, null))
            {
                Expression tailTerm;
                Expression rhs;
                var acc = new IdentifierExpr(expr.tok, accumulatorVar);
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_51(1225L, bin.AccumulatesForTailRecursion, BinaryExpr.AccumulationOperand.Left))
                {
                    rhs = new BinaryExpr(bin.tok, bin.ResolvedOp, acc, bin.E0);
                    tailTerm = bin.E1;
                }
                else
                {
                    switch (bin.ResolvedOp)
                    {
                        case BinaryExpr.ResolvedOpcode.Sub:
                            rhs = new BinaryExpr(bin.tok, BinaryExpr.ResolvedOpcode.Add, bin.E1, acc);
                            break;
                            break;
                        case BinaryExpr.ResolvedOpcode.SetDifference:
                            rhs = new BinaryExpr(bin.tok, BinaryExpr.ResolvedOpcode.Union, bin.E1, acc);
                            break;
                            break;
                        case BinaryExpr.ResolvedOpcode.MultiSetDifference:
                            rhs = new BinaryExpr(bin.tok, BinaryExpr.ResolvedOpcode.MultiSetUnion, bin.E1, acc);
                            break;
                            break;
                        default:
                            rhs = new BinaryExpr(bin.tok, bin.ResolvedOp, bin.E1, acc);
                            break;
                            break;
                    }
                    tailTerm = bin.E0;
                }
                var wRhs = EmitAssignment(VariableLvalue(accumulatorVar), enclosingFunction.ResultType, enclosingFunction.ResultType, wr, expr.tok);
                EmitExpr(rhs, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1226L, false), wRhs, wStmts);
                TrExprOpt(tailTerm, resultType, wr, wStmts, inLetExprBody, accumulatorVar);

            }
            else
            {
                // We haven't optimized any other cases, so fallback to normal compilation
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(1235L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_8(1228L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_16(1227L, enclosingFunction, null), () => enclosingFunction.IsAccumulatorTailRecursive), () => MutateCSharp.Schemata247.ReplaceBinExprOp_50(1234L, accumulatorVar, null)))
                {
                    // Include the accumulator
                    var acc = new IdentifierExpr(expr.tok, accumulatorVar);
                    switch (enclosingFunction.TailRecursion)
                    {
                        case Function.TailStatus.Accumulate_Add:
                            expr = new BinaryExpr(expr.tok, BinaryExpr.ResolvedOpcode.Add, expr, acc);
                            break;
                            break;
                        case Function.TailStatus.AccumulateRight_Sub:
                            expr = new BinaryExpr(expr.tok, BinaryExpr.ResolvedOpcode.Sub, expr, acc);
                            break;
                            break;
                        case Function.TailStatus.Accumulate_Mul:
                            expr = new BinaryExpr(expr.tok, BinaryExpr.ResolvedOpcode.Mul, expr, acc);
                            break;
                            break;
                        case Function.TailStatus.Accumulate_SetUnion:
                            expr = new BinaryExpr(expr.tok, BinaryExpr.ResolvedOpcode.Union, expr, acc);
                            break;
                            break;
                        case Function.TailStatus.AccumulateRight_SetDifference:
                            expr = new BinaryExpr(expr.tok, BinaryExpr.ResolvedOpcode.SetDifference, expr, acc);
                            break;
                            break;
                        case Function.TailStatus.Accumulate_MultiSetUnion:
                            expr = new BinaryExpr(expr.tok, BinaryExpr.ResolvedOpcode.MultiSetUnion, expr, acc);
                            break;
                            break;
                        case Function.TailStatus.AccumulateRight_MultiSetDifference:
                            expr = new BinaryExpr(expr.tok, BinaryExpr.ResolvedOpcode.MultiSetDifference, expr, acc);
                            break;
                            break;
                        case Function.TailStatus.AccumulateLeft_Concat:
                            expr = new BinaryExpr(expr.tok, BinaryExpr.ResolvedOpcode.Concat, acc, expr); // note order of operands
                            break;
                            break;
                        case Function.TailStatus.AccumulateRight_Concat:
                            expr = new BinaryExpr(expr.tok, BinaryExpr.ResolvedOpcode.Concat, expr, acc);
                            break;
                            break;
                        default:
                            Contract.Assert(false); // unexpected TailStatus
                            throw new cce.UnreachableException();
                            break;
                    }
                }
                else
                {
                    Contract.Assert(accumulatorVar == null);
                }
                EmitReturnExpr(expr, resultType, inLetExprBody, wr);
            }
        }

        void CompileReturnBody(Expression body, Type originalResultType, ConcreteSyntaxTree wr, [CanBeNull] IVariable accumulatorVar)
        {
            Contract.Requires(body != null);
            Contract.Requires(originalResultType != null);
            Contract.Requires(wr != null);
            Contract.Requires(accumulatorVar == null || (enclosingFunction != null && enclosingFunction.IsAccumulatorTailRecursive));
            copyInstrWriters.Push(wr.Fork());
            var wStmts = wr.Fork();
            TrExprOpt(body.Resolved, originalResultType, wr, wStmts, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1241L, false), accumulatorVar);
            copyInstrWriters.Pop();
        }

        // ----- Type ---------------------------------------------------------------------------------

        protected NativeType AsNativeType(Type typ)
        {
            return typ.AsNativeType();
        }

        protected bool NeedsEuclideanDivision(Type typ)
        {
            if (AsNativeType(typ) is { LowerBound: var lb })
            {
                // Dafny's division differs from '/' only on negative numbers
                return MutateCSharp.Schemata247.ReplaceBinExprOp_52(1242L, lb, BigInteger.Zero);
            }
            // IsNumericBased drills past newtypes, unlike IsIntegerType
            return typ.IsNumericBased(Type.NumericPersuasion.Int);
        }

        /// <summary>
        /// Note, C# and Java reverse the order of brackets in array type names.
        /// </summary>
        protected void TypeName_SplitArrayName(Type type, ConcreteSyntaxTree wr, IToken tok, out string typeNameSansBrackets, out string brackets)
        {
            Contract.Requires(type != null);

            TypeName_SplitArrayName(type, out var innermostElementType, out brackets);
            typeNameSansBrackets = TypeName(innermostElementType, wr, tok);
        }

        protected virtual void TypeName_SplitArrayName(Type type, out Type innermostElementType, out string brackets)
        {
            Contract.Requires(type != null);

            type = DatatypeWrapperEraser.SimplifyType(Options, type);
            var at = type.AsArrayType;
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_53(1244L, at, null))
            {
                var elementType = type.TypeArgs[MutateCSharp.Schemata247.ReplaceNumericConstant_3(1245L, 0)];
                TypeName_SplitArrayName(elementType, out innermostElementType, out brackets);
                brackets = TypeNameArrayBrackets(at.Dims) + brackets;
            }
            else
            {
                innermostElementType = type;
                brackets = "";
            }
        }

        protected virtual string TypeNameArrayBrackets(int dims)
        {
            Contract.Requires(0 <= dims);
            return $"[{Util.Repeat(MutateCSharp.Schemata247.ReplaceBinExprOp_37(1253L, dims, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1249L, 1)), MutateCSharp.Schemata247.ReplaceStringConstant_2(1262L, ","))}]";
        }

        protected bool ComplicatedTypeParameterForCompilation(TypeParameter.TPVariance v, Type t)
        {
            Contract.Requires(t != null);
            return MutateCSharp.Schemata247.ReplaceBinExprOp_8(1264L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_54(1263L, v, TypeParameter.TPVariance.Non), () => t.IsTraitType);
        }

        protected string/*!*/ TypeNames(List<Type/*!*/>/*!*/ types, ConcreteSyntaxTree wr, IToken tok)
        {
            Contract.Requires(cce.NonNullElements(types));
            Contract.Ensures(Contract.Result<string>() != null);
            return Util.Comma(types, ty => TypeName(ty, wr, tok));
        }

        /// <summary>
        /// If "type" is an auto-init type, then return a default value, else return a placebo value.
        /// </summary>
        protected string PlaceboValue(Type type, ConcreteSyntaxTree wr, IToken tok, bool constructTypeParameterDefaultsFromTypeDescriptors = false)
        {
            if (type.HasCompilableValue)
            {
                return DefaultValue(type, wr, tok, constructTypeParameterDefaultsFromTypeDescriptors);
            }
            else
            {
                return ForcePlaceboValue(type, wr, tok, constructTypeParameterDefaultsFromTypeDescriptors);
            }

            return default;
        }

        protected string ForcePlaceboValue(Type type, ConcreteSyntaxTree wr, IToken tok, bool constructTypeParameterDefaultsFromTypeDescriptors = false)
        {
            Contract.Requires(type != null);
            Contract.Requires(wr != null);
            Contract.Requires(tok != null);
            Contract.Ensures(Contract.Result<string>() != null);

            type = DatatypeWrapperEraser.SimplifyTypeAndTrimSubsetTypes(Options, type);
            return TypeInitializationValue(type, wr, tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1270L, true), constructTypeParameterDefaultsFromTypeDescriptors);
        }

        protected string DefaultValue(Type type, ConcreteSyntaxTree wr, IToken tok, bool constructTypeParameterDefaultsFromTypeDescriptors = false)
        {
            Contract.Requires(type != null);
            Contract.Requires(wr != null);
            Contract.Requires(tok != null);
            Contract.Ensures(Contract.Result<string>() != null);

            // If "type" is a datatype with a ghost grounding constructor, then compile as a placebo for DatatypeWrapperEraser.SimplifyTypeAndTrimSubsetTypes(type).
            // Otherwise, get default value for DatatypeWrapperEraser.SimplifyTypeAndTrimSubsetTypes(type), which may itself have a ghost grounding constructor, in
            // which case the value we produce is a placebo.
            bool HasGhostGroundingCtor(Type ty)
            {
                return (ty.NormalizeExpandKeepConstraints() as UserDefinedType)?.ResolvedClass is DatatypeDecl dt && dt.GetGroundingCtor().IsGhost;
            }

            var simplifiedType = DatatypeWrapperEraser.SimplifyTypeAndTrimSubsetTypes(Options, type);
            var usePlaceboValue = MutateCSharp.Schemata247.ReplaceBinExprOp_9(1271L, () => HasGhostGroundingCtor(type), () => HasGhostGroundingCtor(simplifiedType));
            return TypeInitializationValue(simplifiedType, wr, tok, usePlaceboValue, constructTypeParameterDefaultsFromTypeDescriptors);
        }

        protected string DefaultValueCoercedIfNecessary(Type type, ConcreteSyntaxTree wr, IToken tok,
          bool constructTypeParameterDefaultsFromTypeDescriptors = false)
        {

            var resultWr = new ConcreteSyntaxTree();
            var coercedWr = EmitCoercionIfNecessary(type, TypeForCoercion(type), tok, resultWr);
            coercedWr.Write(DefaultValue(type, wr, tok, constructTypeParameterDefaultsFromTypeDescriptors));
            return resultWr.ToString();
        }

        // ----- Stmt ---------------------------------------------------------------------------------

        public class CheckHasNoAssumes_Visitor : BottomUpVisitor
        {
            readonly SinglePassCodeGenerator codeGenerator;
            ConcreteSyntaxTree wr;
            public CheckHasNoAssumes_Visitor(SinglePassCodeGenerator c, ConcreteSyntaxTree wr)
            {
                Contract.Requires(c != null);
                codeGenerator = c;
                this.wr = wr;
            }

            protected override void VisitOneStmt(Statement stmt)
            {
                if (stmt is ForallStmt)
                {
                    var s = (ForallStmt)stmt;
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_55(1277L, s.Body, null))
                    {
                        codeGenerator.Error(ErrorId.c_forall_statement_has_no_body, stmt.Tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(1278L, "a forall statement without a body cannot be compiled"), wr);
                    }
                }
                else if (stmt is OneBodyLoopStmt)
                {
                    var s = (OneBodyLoopStmt)stmt;
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_31(1279L, s.Body, null))
                    {
                        codeGenerator.Error(ErrorId.c_loop_has_no_body, stmt.Tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(1280L, "a loop without a body cannot be compiled"), wr);
                    }
                }
            }
        }

        void TrStmtNonempty(Statement stmt, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts = null)
        {
            Contract.Requires(stmt != null);
            Contract.Requires(wr != null);
            TrStmt(stmt, wr, wStmts);
            if (stmt.IsGhost)
            {
                TrStmtList(new List<Statement>(), EmitBlock(wr));
            }
        }

        protected void TrStmt(Statement stmt, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts = null)
        {
            Contract.Requires(stmt != null);
            Contract.Requires(wr != null);

            wStmts ??= wr.Fork();

            if (stmt.IsGhost)
            {
                return;
            }
            if (stmt is PrintStmt)
            {
                var s = (PrintStmt)stmt;
                foreach (var arg in s.Args)
                {
                    EmitPrintStmt(wr, arg);
                }
            }
            else if (stmt is BreakStmt)
            {
                var s = (BreakStmt)stmt;
                var label = s.TargetStmt.Labels.Data.AssignUniqueId(idGenerator);
                if (s.IsContinue)
                {
                    EmitContinue(label, wr);
                }
                else
                {
                    EmitBreak(label, wr);
                }
            }
            else if (stmt is ProduceStmt)
            {
                var s = (ProduceStmt)stmt;
                var isTailRecursiveResult = MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1281L, false);
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_56(1282L, s.HiddenUpdate, null))
                {
                    TrStmt(s.HiddenUpdate, wr);
                    var ss = s.HiddenUpdate.ResolvedStatements;
                    if (ss.Count == 1 && ss[0] is AssignStmt assign && assign.Rhs is ExprRhs eRhs && eRhs.Expr.Resolved is FunctionCallExpr fce && IsTailRecursiveByMethodCall(fce))
                    {
                        isTailRecursiveResult = MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1283L, true);
                    }
                }
                if (s is YieldStmt)
                {
                    EmitYield(wr);
                }
                else if (!isTailRecursiveResult)
                {
                    EmitReturn(this.enclosingMethod.Outs, wr);
                }
            }
            else if (stmt is UpdateStmt)
            {
                var s = (UpdateStmt)stmt;
                var resolved = s.ResolvedStatements;
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_27(1288L, resolved.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1284L, 1)))
                {
                    TrStmt(resolved[MutateCSharp.Schemata247.ReplaceNumericConstant_3(1293L, 0)], wr);
                }
                else
                {
                    var assignStmts = resolved.Cast<AssignStmt>().Where(assignStmt => !assignStmt.IsGhost).ToList();
                    var lhss = new List<Expression>();
                    var rhss = new List<AssignmentRhs>();

                    // multi-assignment
                    Contract.Assert(s.Lhss.Count == resolved.Count);
                    Contract.Assert(s.Rhss.Count == resolved.Count);
                    var lhsTypes = new List<Type>();
                    var rhsTypes = new List<Type>();
                    foreach (var assignStmt in assignStmts)
                    {
                        var rhs = assignStmt.Rhs;
                        if (rhs is HavocRhs)
                        {
                            if (Options.ForbidNondeterminism)
                            {
                                Error(ErrorId.c_nondeterminism_forbidden, rhs.Tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(1297L, "nondeterministic assignment forbidden by the --enforce-determinism option"), wr);
                            }
                        }
                        else
                        {
                            var lhs = assignStmt.Lhs;
                            rhss.Add(rhs);
                            lhss.Add(lhs);
                            lhsTypes.Add(lhs.Type);
                            rhsTypes.Add(TypeOfRhs(rhs));
                        }
                    }

                    var wStmtsPre = wStmts.Fork();
                    var lvalues = new List<ILvalue>();
                    foreach (Expression lhs in lhss)
                    {
                        lvalues.Add(CreateLvalue(lhs, wStmts, wStmtsPre));
                    }

                    EmitMultiAssignment(lhss, lvalues, lhsTypes, out var wRhss, rhsTypes, wr);
                    for (int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1298L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(1302L, i, wRhss.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(1307L, ref i))
                    {
                        TrRhs(rhss[i], wRhss[i], wStmts);
                    }
                }
            }
            else if (stmt is AssignStmt)
            {
                var s = (AssignStmt)stmt;
                Contract.Assert(s.Lhs is not SeqSelectExpr expr || expr.SelectOne);  // multi-element array assignments are not allowed
                if (s.Rhs is HavocRhs)
                {
                    if (Options.ForbidNondeterminism)
                    {
                        Error(ErrorId.c_nondeterminism_forbidden, s.Rhs.Tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(1308L, "nondeterministic assignment forbidden by the --enforce-determinism option"), wr);
                    }
                }
                else if (s.Rhs is ExprRhs eRhs && eRhs.Expr.Resolved is FunctionCallExpr fce && IsTailRecursiveByMethodCall(fce))
                {
                    TrTailCallStmt(s.Tok, fce.Function.ByMethodDecl, fce.Receiver, fce.Args, null, wr);
                }
                else
                {
                    var lvalue = CreateLvalue(s.Lhs, wr, wStmts);
                    wStmts = wr.Fork();
                    var wRhs = EmitAssignment(lvalue, TypeOfLhs(s.Lhs), TypeOfRhs(s.Rhs), wr, stmt.Tok);
                    TrRhs(s.Rhs, wRhs, wStmts);
                }

            }
            else if (stmt is AssignSuchThatStmt)
            {
                var s = (AssignSuchThatStmt)stmt;
                if (Options.ForbidNondeterminism)
                {
                    Error(ErrorId.c_assign_such_that_forbidden, s.Tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(1309L, "assign-such-that statement forbidden by the --enforce-determinism option"), wr);
                }
                var lhss = s.Lhss.ConvertAll(lhs => ((IdentifierExpr)lhs.Resolved).Var);  // the resolver allows only IdentifierExpr left-hand sides
                var missingBounds = BoundedPool.MissingBounds(lhss, s.Bounds, BoundedPool.PoolVirtues.Enumerable);
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_21(1314L, missingBounds.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1310L, 0)))
                {
                    foreach (var bv in missingBounds)
                    {
                        Error(ErrorId.c_assign_such_that_is_too_complex, s.Tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(1319L, "this assign-such-that statement is too advanced for the current compiler; Dafny's heuristics cannot find any bound for variable '{0}'"), wr, bv.Name);
                    }
                }
                else
                {
                    Contract.Assert(s.Bounds != null);
                    TrAssignSuchThat(lhss, s.Expr, s.Bounds, s.Tok.line, wr, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1320L, false));
                }
            }
            else if (stmt is AssignOrReturnStmt)
            {
                var s = (AssignOrReturnStmt)stmt;
                // TODO there's potential here to use target-language specific features such as exceptions
                // to make it more target-language idiomatic and improve performance
                TrStmtList(s.ResolvedStatements, wr);

            }
            else if (stmt is ExpectStmt)
            {
                var s = (ExpectStmt)stmt;
                // TODO there's potential here to use target-language specific features such as exceptions
                // to make it more target-language idiomatic and improve performance
                ConcreteSyntaxTree bodyWriter = EmitIf(out var guardWriter, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1321L, false), wr);
                var negated = new UnaryOpExpr(s.Tok, UnaryOpExpr.Opcode.Not, s.Expr);
                negated.Type = Type.Bool;
                EmitExpr(negated, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1322L, false), guardWriter, wStmts);
                EmitHalt(s.Tok, s.Message, bodyWriter);

            }
            else if (stmt is CallStmt)
            {
                var s = (CallStmt)stmt;
                var wrBefore = wr.Fork();
                var wrCall = wr.Fork();
                var wrAfter = wr;
                TrCallStmt(s, null, wrCall, wrBefore, wrAfter);

            }
            else if (stmt is BlockStmt)
            {
                var w = EmitBlock(wr);
                TrStmtList(((BlockStmt)stmt).Body, w);

            }
            else if (stmt is IfStmt)
            {
                IfStmt s = (IfStmt)stmt;
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_38(1323L, s.Guard, null))
                {
                    if (Options.ForbidNondeterminism)
                    {
                        Error(ErrorId.c_nondeterministic_if_forbidden, s.Tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(1324L, "nondeterministic if statement forbidden by the --enforce-determinism option"), wr);
                    }
                    // we can compile the branch of our choice
                    ConcreteSyntaxTree guardWriter;
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_55(1325L, s.Els, null))
                    {
                        // let's compile the "else" branch, since that involves no work
                        // (still, let's leave a marker in the source code to indicate that this is what we did)
                        Coverage.UnusedInstrumentationPoint(s.Thn.Tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(1326L, "then branch"));
                        var notFalse = (UnaryOpExpr)Expression.CreateNot(s.Thn.Tok, Expression.CreateBoolLiteral(s.Thn.Tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1327L, false)));
                        var thenWriter = EmitIf(out guardWriter, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1328L, false), wr);
                        EmitUnaryExpr(ResolvedUnaryOp.BoolNot, notFalse.E, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1329L, false), guardWriter, wStmts);
                        Coverage.Instrument(s.Tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(1330L, "implicit else branch"), wr);
                        thenWriter = EmitIf(out guardWriter, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1331L, false), thenWriter);
                        EmitUnaryExpr(ResolvedUnaryOp.BoolNot, notFalse.E, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1332L, false), guardWriter, wStmts);
                        TrStmtList(new List<Statement>(), thenWriter);
                    }
                    else
                    {
                        // let's compile the "then" branch
                        wr = EmitIf(out guardWriter, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1333L, false), wr);
                        EmitExpr(Expression.CreateBoolLiteral(s.Thn.tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1334L, true)), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1335L, false), guardWriter, wStmts);
                        Coverage.Instrument(s.Thn.Tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(1336L, "then branch"), wr);
                        TrStmtList(s.Thn.Body, wr);
                        Coverage.UnusedInstrumentationPoint(s.Els.Tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(1337L, "else branch"));
                    }
                }
                else
                {
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(1338L, () => s.IsBindingGuard, () => Options.ForbidNondeterminism))
                    {
                        Error(ErrorId.c_binding_if_forbidden, s.Tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(1344L, "binding if statement forbidden by the --enforce-determinism option"), wr);
                    }

                    var coverageForElse = MutateCSharp.Schemata247.ReplaceBinExprOp_8(1345L, () => Coverage.IsRecording, () => !(s.Els is IfStmt));
                    var thenWriter = EmitIf(out var guardWriter, MutateCSharp.Schemata247.ReplaceBinExprOp_9(1352L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_57(1351L, s.Els, null), () => coverageForElse), wr);
                    EmitExpr(s.IsBindingGuard ? ((ExistsExpr)s.Guard).AlphaRename(MutateCSharp.Schemata247.ReplaceStringConstant_2(1358L, "eg_d")) : s.Guard, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1359L, false), guardWriter, wStmts);
                    // We'd like to do "TrStmt(s.Thn, indent)", except we want the scope of any existential variables to come inside the block
                    if (s.IsBindingGuard)
                    {
                        IntroduceAndAssignBoundVars((ExistsExpr)s.Guard, thenWriter);
                    }
                    Coverage.Instrument(s.Thn.Tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(1360L, "then branch"), thenWriter);
                    TrStmtList(s.Thn.Body, thenWriter);

                    if (coverageForElse)
                    {
                        wr = EmitBlock(wr);
                        if (MutateCSharp.Schemata247.ReplaceBinExprOp_55(1361L, s.Els, null))
                        {
                            Coverage.Instrument(s.Tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(1362L, "implicit else branch"), wr);
                        }
                        else
                        {
                            Coverage.Instrument(s.Els.Tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(1363L, "else branch"), wr);
                        }
                    }
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_57(1364L, s.Els, null))
                    {
                        TrStmtNonempty(s.Els, wr, wStmts);
                    }
                }

            }
            else if (stmt is AlternativeStmt)
            {
                var s = (AlternativeStmt)stmt;
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(1374L, () => Options.ForbidNondeterminism, () => MutateCSharp.Schemata247.ReplaceBinExprOp_58(1369L, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1365L, 2), s.Alternatives.Count)))
                {
                    Error(ErrorId.c_case_based_if_forbidden, s.Tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(1380L, "case-based if statement forbidden by the --enforce-determinism option"), wr);
                }
                foreach (var alternative in s.Alternatives)
                {
                    var thn = EmitIf(out var guardWriter, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1381L, true), wr);
                    EmitExpr(alternative.IsBindingGuard ? ((ExistsExpr)alternative.Guard).AlphaRename(MutateCSharp.Schemata247.ReplaceStringConstant_2(1382L, "eg_d")) : alternative.Guard, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1383L, false), guardWriter, wStmts);
                    if (alternative.IsBindingGuard)
                    {
                        IntroduceAndAssignBoundVars((ExistsExpr)alternative.Guard, thn);
                    }
                    Coverage.Instrument(alternative.Tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(1384L, "if-case branch"), thn);
                    TrStmtList(alternative.Body, thn);
                }
                var wElse = EmitBlock(wr);
                EmitAbsurd(MutateCSharp.Schemata247.ReplaceStringConstant_2(1385L, "unreachable alternative"), wElse);

            }
            else if (stmt is WhileStmt)
            {
                WhileStmt s = (WhileStmt)stmt;
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_31(1386L, s.Body, null))
                {
                    return;
                }
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_38(1387L, s.Guard, null))
                {
                    if (Options.ForbidNondeterminism)
                    {
                        Error(ErrorId.c_non_deterministic_loop_forbidden, s.Tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(1388L, "nondeterministic loop forbidden by the --enforce-determinism option"), wr);
                    }
                    // This loop is allowed to stop iterating at any time. We choose to never iterate, but we still
                    // emit a loop structure. The structure "while (false) { }" comes to mind, but that results in
                    // an "unreachable code" error from Java, so we instead use "while (true) { break; }".
                    var wBody = CreateWhileLoop(out var guardWriter, wr);
                    EmitExpr(Expression.CreateBoolLiteral(s.Body.tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1389L, true)), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1390L, false), guardWriter, wStmts);
                    EmitBreak(null, wBody);
                    Coverage.UnusedInstrumentationPoint(s.Body.Tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(1391L, "while body"));
                }
                else
                {
                    var guardWriter = EmitWhile(s.Body.Tok, s.Body.Body, s.Labels, wr);
                    EmitExpr(s.Guard, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1392L, false), guardWriter, wStmts);
                }

            }
            else if (stmt is AlternativeLoopStmt loopStmt)
            {
                if (Options.ForbidNondeterminism)
                {
                    Error(ErrorId.c_case_based_loop_forbidden, loopStmt.Tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(1393L, "case-based loop forbidden by the --enforce-determinism option"), wr);
                }
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_21(1398L, loopStmt.Alternatives.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1394L, 0)))
                {
                    var w = CreateWhileLoop(out var whileGuardWriter, wr);
                    EmitExpr(Expression.CreateBoolLiteral(loopStmt.tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1403L, true)), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1404L, false), whileGuardWriter, wStmts);
                    w = EmitContinueLabel(loopStmt.Labels, w);
                    foreach (var alternative in loopStmt.Alternatives)
                    {
                        var thn = EmitIf(out var guardWriter, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1405L, true), w);
                        EmitExpr(alternative.Guard, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1406L, false), guardWriter, wStmts);
                        Coverage.Instrument(alternative.Tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(1407L, "while-case branch"), thn);
                        TrStmtList(alternative.Body, thn);
                    }
                    var wElse = EmitBlock(w);
                    {
                        EmitBreak(null, wElse);
                    }
                }

            }
            else if (stmt is ForLoopStmt)
            {
                var s = (ForLoopStmt)stmt;
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_31(1408L, s.Body, null))
                {
                    return;
                }
                string endVarName = null;
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_39(1409L, s.End, null))
                {
                    // introduce a variable to hold the value of the end-expression
                    endVarName = ProtectedFreshId(s.GoingUp ? MutateCSharp.Schemata247.ReplaceStringConstant_2(1410L, "_hi") : MutateCSharp.Schemata247.ReplaceStringConstant_2(1411L, "_lo"));
                    wStmts = wr.Fork();
                    EmitExpr(s.End, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1412L, false), DeclareLocalVar(endVarName, s.End.Type, s.End.tok, wr), wStmts);
                }
                var startExprWriter = EmitForStmt(s.Tok, s.LoopIndex, s.GoingUp, endVarName, s.Body.Body, s.Labels, wr);
                EmitExpr(s.Start, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1413L, false), startExprWriter, wStmts);

            }
            else if (stmt is ForallStmt)
            {
                var s = (ForallStmt)stmt;
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_59(1414L, s.Kind, ForallStmt.BodyKind.Assign))
                {
                    // Call and Proof have no side effects, so they can simply be optimized away.
                    return;
                }
                else if (MutateCSharp.Schemata247.ReplaceBinExprOp_27(1419L, s.BoundVars.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1415L, 0)))
                {
                    // the bound variables just spell out a single point, so the forall statement is equivalent to one execution of the body
                    TrStmt(s.Body, wr);
                    return;
                }
                var s0 = (AssignStmt)s.S0;
                if (s0.Rhs is HavocRhs)
                {
                    if (Options.ForbidNondeterminism)
                    {
                        Error(ErrorId.c_nondeterminism_forbidden, s0.Rhs.Tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(1424L, "nondeterministic assignment forbidden by --enforce-determinism"), wr);
                    }
                    // The forall statement says to havoc a bunch of things.  This can be efficiently compiled
                    // into doing nothing.
                    return;
                }
                var rhs = ((ExprRhs)s0.Rhs).Expr;

                if (CanSequentializeForall(s.BoundVars, s.Bounds, s.Range, s0.Lhs, rhs))
                {
                    // Just put the statement inside the loops
                    var wLoop = CompileGuardedLoops(s.BoundVars, s.Bounds, s.Range, wr);
                    TrStmt(s0, wLoop);
                }
                else
                {
                    // Compile:
                    //   forall (w,x,y,z | Range(w,x,y,z)) {
                    //     LHS(w,x,y,z) := RHS(w,x,y,z);
                    //   }
                    // where w,x,y,z have types seq<W>,set<X>,int,bool and LHS has L-1 top-level subexpressions
                    // (that is, L denotes the number of top-level subexpressions of LHS plus 1),
                    // into:
                    //   var ingredients = new List< L-Tuple >();
                    //   foreach (W w in sq.UniqueElements) {
                    //     foreach (X x in st.Elements) {
                    //       for (BigInteger y = Lo; j < Hi; j++) {
                    //         for (bool z in Helper.AllBooleans) {
                    //           if (Range(w,x,y,z)) {
                    //             ingredients.Add(new L-Tuple( LHS0(w,x,y,z), LHS1(w,x,y,z), ..., RHS(w,x,y,z) ));
                    //           }
                    //         }
                    //       }
                    //     }
                    //   }
                    //   foreach (L-Tuple l in ingredients) {
                    //     LHS[ l0, l1, l2, ..., l(L-2) ] = l(L-1);
                    //   }
                    //
                    // Note, because the .NET Tuple class only supports up to 8 components, the compiler implementation
                    // here supports arrays only up to 6 dimensions.  This does not seem like a serious practical limitation.
                    // However, it may be more noticeable if the forall statement supported forall assignments in its
                    // body.  To support cases where tuples would need more than 8 components, .NET Tuple's would have to
                    // be nested.

                    // Temporary names
                    var c = ProtectedFreshNumericId(MutateCSharp.Schemata247.ReplaceStringConstant_2(1425L, "_ingredients+_tup"));
                    string ingredients = MutateCSharp.Schemata247.ReplaceStringConstant_2(1426L, "_ingredients") + c;
                    string tup = MutateCSharp.Schemata247.ReplaceStringConstant_2(1427L, "_tup") + c;

                    // Compute L
                    int L;
                    string tupleTypeArgs;
                    List<Type> tupleTypeArgsList;
                    if (s0.Lhs is MemberSelectExpr)
                    {
                        var lhs = (MemberSelectExpr)s0.Lhs;
                        L = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1428L, 2);
                        tupleTypeArgs = TypeArgumentName(lhs.Obj.Type, wr, lhs.tok);
                        tupleTypeArgsList = new List<Type> { lhs.Obj.Type };
                    }
                    else if (s0.Lhs is SeqSelectExpr)
                    {
                        var lhs = (SeqSelectExpr)s0.Lhs;
                        L = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1432L, 3);
                        // note, we might as well do the BigInteger-to-int cast for array indices here, before putting things into the Tuple rather than when they are extracted from the Tuple
                        tupleTypeArgs = TypeArgumentName(lhs.Seq.Type, wr, lhs.tok) + IntSelect;
                        tupleTypeArgsList = new List<Type> { lhs.Seq.Type, null };
                    }
                    else
                    {
                        var lhs = (MultiSelectExpr)s0.Lhs;
                        L = MutateCSharp.Schemata247.ReplaceBinExprOp_60(1440L, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1436L, 2), lhs.Indices.Count);
                        if (MutateCSharp.Schemata247.ReplaceBinExprOp_6(1453L, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1449L, 8), L))
                        {
                            Error(ErrorId.c_no_assignments_to_seven_d_arrays, lhs.tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(1458L, "compiler currently does not support assignments to more-than-6-dimensional arrays in forall statements"), wr);
                            return;
                        }
                        tupleTypeArgs = TypeArgumentName(lhs.Array.Type, wr, lhs.tok);
                        tupleTypeArgsList = new List<Type> { lhs.Array.Type };
                        for (int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1459L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(1463L, i, lhs.Indices.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(1468L, ref i))
                        {
                            // note, we might as well do the BigInteger-to-int cast for array indices here, before putting things into the Tuple rather than when they are extracted from the Tuple
                            tupleTypeArgs += IntSelect;
                            tupleTypeArgsList.Add(null);
                        }

                    }
                    tupleTypeArgs += MutateCSharp.Schemata247.ReplaceStringConstant_2(1469L, ",") + TypeArgumentName(rhs.Type, wr, rhs.tok);
                    tupleTypeArgsList.Add(rhs.Type);

                    // declare and construct "ingredients"
                    var wrOuter = EmitIngredients(wr, ingredients, L, tupleTypeArgs, s, s0, rhs);

                    //   foreach (L-Tuple l in ingredients) {
                    //     LHS[ l0, l1, l2, ..., l(L-2) ] = l(L-1);
                    //   }
                    TargetTupleSize = L;
                    wr = CreateForeachIngredientLoop(tup, L, tupleTypeArgs, out var collWriter, wrOuter);
                    collWriter.Write(ingredients);
                    {
                        var wTup = new ConcreteSyntaxTree(wr.RelativeIndentLevel);
                        var wCoerceTup = EmitCoercionToArbitraryTuple(wTup);
                        wCoerceTup.Write(tup);
                        tup = wTup.ToString();
                    }
                    if (s0.Lhs is MemberSelectExpr)
                    {
                        EmitMemberSelect(s0, tupleTypeArgsList, wr, tup);
                    }
                    else if (s0.Lhs is SeqSelectExpr)
                    {
                        EmitSeqSelect(s0, tupleTypeArgsList, wr, tup);
                    }
                    else
                    {
                        EmitMultiSelect(s0, tupleTypeArgsList, wr, tup, L);
                    }
                }
            }
            else if (stmt is NestedMatchStmt nestedMatchStmt)
            {
                TrStmt(nestedMatchStmt.Flattened, wr, wStmts);
            }
            else if (stmt is MatchStmt)
            {
                MatchStmt s = (MatchStmt)stmt;
                // Type source = e;
                // if (source.is_Ctor0) {
                //   FormalType f0 = ((Dt_Ctor0)source._D).a0;
                //   ...
                //   Body0;
                // } else if (...) {
                //   ...
                // } else if (true) {
                //   ...
                // }
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_21(1474L, s.Cases.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1470L, 0)))
                {
                    string source = ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(1479L, "_source"));
                    DeclareLocalVar(source, s.Source.Type, s.Source.tok, s.Source, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1480L, false), wr);

                    int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1481L, 0);
                    var sourceType = (UserDefinedType)s.Source.Type.NormalizeExpand();
                    foreach (MatchCaseStmt mc in s.Cases)
                    {
                        var w = MatchCasePrelude(source, sourceType, cce.NonNull(mc.Ctor), mc.Arguments, i, s.Cases.Count, wr);
                        TrStmtList(mc.Body, w);
                        MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(1485L, ref i);
                    }
                }

            }
            else if (stmt is VarDeclStmt)
            {
                var s = (VarDeclStmt)stmt;
                var i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1486L, 0);
                foreach (var local in s.Locals)
                {
                    bool hasRhs = MutateCSharp.Schemata247.ReplaceBinExprOp_9(1490L, () => s.Update is AssignSuchThatStmt, () => s.Update is AssignOrReturnStmt);
                    if (!hasRhs && s.Update is UpdateStmt u)
                    {
                        if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(1501L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_6(1496L, i, u.Rhss.Count), () => u.Rhss[i] is HavocRhs))
                        {
                            // there's no specific initial value
                        }
                        else
                        {
                            hasRhs = MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1507L, true);
                        }
                    }
                    TrLocalVar(local, !hasRhs, wr);
                    MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(1508L, ref i);
                }
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_61(1509L, s.Update, null))
                {
                    TrStmt(s.Update, wr);
                }

            }
            else if (stmt is VarDeclPattern)
            {
                var s = (VarDeclPattern)stmt;
                if (Contract.Exists(s.LHS.Vars, bv => !bv.IsGhost))
                {
                    TrCasePatternOpt(s.LHS, s.RHS, wr, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1510L, false));
                }
            }
            else if (stmt is ModifyStmt)
            {
                var s = (ModifyStmt)stmt;
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_42(1511L, s.Body, null))
                {
                    TrStmt(s.Body, wr);
                }
                else if (Options.ForbidNondeterminism)
                {
                    Error(ErrorId.c_bodyless_modify_statement_forbidden, s.Tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(1512L, "modify statement without a body forbidden by the --enforce-determinism option"), wr);
                }
            }
            else if (stmt is TryRecoverStatement h)
            {
                EmitHaltRecoveryStmt(h.TryBody, IdName(h.HaltMessageVar), h.RecoverBody, wr);
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected statement
            }
        }

        protected virtual ConcreteSyntaxTree EmitIngredients(ConcreteSyntaxTree wr, string ingredients, int L, string tupleTypeArgs, ForallStmt s, AssignStmt s0, Expression rhs)
        {
            var wStmts = wr.Fork();
            var wrVarInit = DeclareLocalVar(ingredients, null, null, wr);
            {
                EmitEmptyTupleList(tupleTypeArgs, wrVarInit);
            }

            var wrOuter = wr;
            wr = CompileGuardedLoops(s.BoundVars, s.Bounds, s.Range, wr);

            var wrTuple = EmitAddTupleToList(ingredients, tupleTypeArgs, wr);
            {
                if (s0.Lhs is MemberSelectExpr)
                {
                    var lhs = (MemberSelectExpr)s0.Lhs;
                    EmitExpr(lhs.Obj, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1513L, false), wrTuple, wStmts);
                }
                else if (s0.Lhs is SeqSelectExpr)
                {
                    var lhs = (SeqSelectExpr)s0.Lhs;
                    EmitExpr(lhs.Seq, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1514L, false), wrTuple, wStmts);
                    wrTuple.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(1515L, ", "));
                    EmitExprAsNativeInt(lhs.E0, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1516L, false), wrTuple, wStmts);
                }
                else
                {
                    var lhs = (MultiSelectExpr)s0.Lhs;
                    EmitExpr(lhs.Array, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1517L, false), wrTuple, wStmts);
                    for (int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1518L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(1522L, i, lhs.Indices.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(1527L, ref i))
                    {
                        wrTuple.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(1528L, ", "));
                        EmitExprAsNativeInt(lhs.Indices[i], MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1529L, false), wrTuple, wStmts);
                    }
                }

                wrTuple.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(1530L, ", "));
                EmitExpr(rhs, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1531L, false), wrTuple, wStmts);
            }

            return wrOuter;
        }

        bool IsTailRecursiveByMethodCall(FunctionCallExpr fce)
        {
            Contract.Requires(fce != null);
            return MutateCSharp.Schemata247.ReplaceBinExprOp_8(1539L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_8(1533L, () => fce.IsByMethodCall, () => MutateCSharp.Schemata247.ReplaceBinExprOp_47(1532L, fce.Function.ByMethodDecl, enclosingMethod)), () => fce.Function.ByMethodDecl.IsTailRecursive);
        }

        protected virtual void EmitMemberSelect(AssignStmt s0, List<Type> tupleTypeArgsList, ConcreteSyntaxTree wr, string tup)
        {
            var lhs = (MemberSelectExpr)s0.Lhs;

            var typeArgs = TypeArgumentInstantiation.ListFromMember(lhs.Member, null, lhs.TypeApplication_JustMember);
            var lvalue = EmitMemberSelect(w =>
            {
                var wObj = EmitCoercionIfNecessary(from: null, to: tupleTypeArgsList[MutateCSharp.Schemata247.ReplaceNumericConstant_3(1545L, 0)], s0.Tok, w);
                EmitTupleSelect(tup, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1549L, 0), wObj);
            }, lhs.Obj.Type, lhs.Member, typeArgs, lhs.TypeArgumentSubstitutionsWithParents(), lhs.Type);

            var wRhs = EmitAssignment(lvalue, lhs.Type, tupleTypeArgsList[MutateCSharp.Schemata247.ReplaceNumericConstant_3(1553L, 1)], wr, s0.Tok);
            var wCoerced = EmitCoercionIfNecessary(from: null, to: tupleTypeArgsList[MutateCSharp.Schemata247.ReplaceNumericConstant_3(1557L, 1)], tok: s0.Tok, wr: wRhs);
            EmitTupleSelect(tup, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1561L, 1), wCoerced);
        }

        protected virtual void EmitSeqSelect(AssignStmt s0, List<Type> tupleTypeArgsList, ConcreteSyntaxTree wr, string tup)
        {
            var lhs = (SeqSelectExpr)s0.Lhs;
            EmitIndexCollectionUpdate(lhs.Seq.Type, out var wColl, out var wIndex, out var wValue, wr, nativeIndex: MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1565L, true));
            var wCoerce = EmitCoercionIfNecessary(from: null, to: lhs.Seq.Type, tok: s0.Tok, wr: wColl);
            EmitTupleSelect(tup, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1566L, 0), wCoerce);
            var wCast = EmitCoercionToNativeInt(wIndex);
            EmitTupleSelect(tup, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1570L, 1), wCast);
            EmitTupleSelect(tup, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1574L, 2), wValue);
            EndStmt(wr);
        }

        protected virtual void EmitMultiSelect(AssignStmt s0, List<Type> tupleTypeArgsList, ConcreteSyntaxTree wr, string tup, int L)
        {
            var lhs = (MultiSelectExpr)s0.Lhs;
            var wArray = new ConcreteSyntaxTree(wr.RelativeIndentLevel);
            var wCoerced = EmitCoercionIfNecessary(from: null, to: tupleTypeArgsList[MutateCSharp.Schemata247.ReplaceNumericConstant_3(1578L, 0)], tok: s0.Tok, wr: wArray);
            EmitTupleSelect(tup, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1582L, 0), wCoerced);
            var array = wArray.ToString();
            var indices = new List<Action<ConcreteSyntaxTree>>();
            for (int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1586L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(1590L, i, lhs.Indices.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(1595L, ref i))
            {
                var capturedI = i;
                indices.Add(wIndex => EmitTupleSelect(tup, MutateCSharp.Schemata247.ReplaceBinExprOp_60(1600L, capturedI, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1596L, 1)), EmitCoercionToNativeInt(wIndex)));
            }
            var (wrArray, wrRhs) = EmitArrayUpdate(indices, tupleTypeArgsList[MutateCSharp.Schemata247.ReplaceBinExprOp_37(1613L, L, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1609L, 1))], wr);
            EmitTupleSelect(tup, MutateCSharp.Schemata247.ReplaceBinExprOp_37(1626L, L, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1622L, 1)), wrRhs);
            wrArray.Write(array);
            EndStmt(wr);
        }

        protected ConcreteSyntaxTree CompileGuardedLoops(List<BoundVar> bvs, List<BoundedPool> bounds, Expression range, ConcreteSyntaxTree wr)
        {
            var n = bvs.Count;
            Contract.Assert(bounds.Count == n);
            for (int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1635L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(1639L, i, n); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(1644L, ref i))
            {
                var bound = bounds[i];
                var bv = bvs[i];
                var tmpVar = ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(1645L, "_guard_loop_"));
                var wStmtsLoop = wr.Fork();
                var elementType = CompileCollection(bound, bv, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1646L, false), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1647L, false), null, out var collection, wStmtsLoop, bounds, bvs, i);
                wr = CreateGuardedForeachLoop(tmpVar, elementType, bv, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1648L, true), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1649L, false), range.tok, collection, wr);
            }

            // if (range) {
            //   ingredients.Add(new L-Tuple( LHS0(w,x,y,z), LHS1(w,x,y,z), ..., RHS(w,x,y,z) ));
            // }
            ConcreteSyntaxTree guardWriter = new ConcreteSyntaxTree();
            var wStmts = guardWriter.Fork();
            wr = EmitIf(out guardWriter, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1650L, false), wr);
            foreach (var bvConstraints in bvs.Select(bv => ModuleResolver.GetImpliedTypeConstraint(bv, bv.Type)))
            {
                guardWriter = EmitAnd((wr) => TrParenExpr(bvConstraints, wr, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1651L, false), wStmts), guardWriter);
            }
            TrParenExpr(range, guardWriter, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1652L, false), wStmts);

            return wr;
        }

        protected virtual ConcreteSyntaxTree EmitAnd(Action<ConcreteSyntaxTree> lhs, ConcreteSyntaxTree wr)
        {
            lhs(wr);
            wr.Write($" {Conj} ");
            return wr;
        }

        /// <summary>
        /// Returns a type whose target type is the same as the target type of the values returned by the emitted enumeration.
        /// The output value of "collectionWriter" is an action that emits the enumeration.
        /// Note that, while the values returned bny the enumeration have the target representation of "bv.Type", they may
        /// not be legal "bv.Type" values -- that is, it could be that "bv.Type" has further constraints that need to be checked.
        /// </summary>
        Type CompileCollection(BoundedPool bound, IVariable bv, bool inLetExprBody, bool includeDuplicates,
            Substituter/*?*/ su, out Action<ConcreteSyntaxTree> collectionWriter, ConcreteSyntaxTree wStmts,
            List<BoundedPool>/*?*/ bounds = null, List<BoundVar>/*?*/ boundVars = null, int boundIndex = 0)
        {
            Contract.Requires(bound != null);
            Contract.Requires(bounds == null || (boundVars != null && bounds.Count == boundVars.Count && 0 <= boundIndex && boundIndex < bounds.Count));

            wStmts = wStmts.Fork();

            var propertySuffix = SupportsProperties ? "" : MutateCSharp.Schemata247.ReplaceStringConstant_2(1653L, "()");
            su = su ?? new Substituter(null, new Dictionary<IVariable, Expression>(), new Dictionary<TypeParameter, Type>());

            if (bound is BoolBoundedPool)
            {
                collectionWriter = (wr) => EmitBoolBoundedPool(inLetExprBody, wr, wStmts);
                return new BoolType();
            }
            else if (bound is CharBoundedPool)
            {
                collectionWriter = (wr) => EmitCharBoundedPool(inLetExprBody, wr, wStmts);
                return new CharType();
            }
            else if (bound is IntBoundedPool)
            {
                var b = (IntBoundedPool)bound;
                var res = EmitIntegerRange(bv.Type, wLo =>
                {
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_38(1654L, b.LowerBound, null))
                    {
                        EmitNull(bv.Type, wLo);
                    }
                    else if (MutateCSharp.Schemata247.ReplaceBinExprOp_62(1655L, bounds, null))
                    {
                        var low = SubstituteBound(b, bounds, boundVars, boundIndex, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1656L, true));
                        EmitExpr(su.Substitute(low), inLetExprBody, wLo, wStmts);
                    }
                    else
                    {
                        EmitExpr(su.Substitute(b.LowerBound), inLetExprBody, wLo, wStmts);
                    }
                }, wHi =>
                {
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_38(1657L, b.UpperBound, null))
                    {
                        EmitNull(bv.Type, wHi);
                    }
                    else if (MutateCSharp.Schemata247.ReplaceBinExprOp_62(1658L, bounds, null))
                    {
                        var high = SubstituteBound(b, bounds, boundVars, boundIndex, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1659L, false));
                        EmitExpr(su.Substitute(high), inLetExprBody, wHi, wStmts);
                    }
                    else
                    {
                        EmitExpr(su.Substitute(b.UpperBound), inLetExprBody, wHi, wStmts);
                    }
                });

                collectionWriter = res.Item2;

                return res.Item1;
            }
            else if (bound is AssignSuchThatStmt.WiggleWaggleBound)
            {
                collectionWriter = (wr) => EmitWiggleWaggleBoundedPool(inLetExprBody, wr, wStmts);
                return bv.Type;
            }
            else if (bound is ExactBoundedPool)
            {
                var b = (ExactBoundedPool)bound;
                collectionWriter = (wr) => EmitSingleValueGenerator(su.Substitute(b.E), inLetExprBody, TypeName(b.E.Type, wr, b.E.tok), wr, wStmts);
                return b.E.Type;
            }
            else if (bound is SetBoundedPool setBoundedPool)
            {
                collectionWriter = (wr) =>
                {
                    EmitSetBoundedPool(su.Substitute(setBoundedPool.Set), propertySuffix, inLetExprBody, wr, wStmts);
                };
                return setBoundedPool.CollectionElementType;
            }
            else if (bound is MultiSetBoundedPool)
            {
                var b = (MultiSetBoundedPool)bound;
                collectionWriter = (wr) =>
                {
                    EmitMultiSetBoundedPool(su.Substitute(b.MultiSet), includeDuplicates, propertySuffix, inLetExprBody, wr, wStmts);
                };
                return b.CollectionElementType;
            }
            else if (bound is SubSetBoundedPool)
            {
                var b = (SubSetBoundedPool)bound;
                collectionWriter = (wr) =>
                {
                    EmitSubSetBoundedPool(su.Substitute(b.UpperBound), propertySuffix, inLetExprBody, wr, wStmts);
                };
                return b.UpperBound.Type;
            }
            else if (bound is MapBoundedPool)
            {
                var b = (MapBoundedPool)bound;
                collectionWriter = (wr) =>
                {
                    EmitMapBoundedPool(su.Substitute(b.Map), propertySuffix, inLetExprBody, wr, wStmts);
                };
                return b.CollectionElementType;
            }
            else if (bound is SeqBoundedPool)
            {
                var b = (SeqBoundedPool)bound;
                collectionWriter = (wr) =>
                {
                    EmitSeqBoundedPool(su.Substitute(b.Seq), includeDuplicates, propertySuffix, inLetExprBody, wr, wStmts);
                };
                return b.CollectionElementType;
            }
            else if (bound is DatatypeBoundedPool)
            {
                var b = (DatatypeBoundedPool)bound;
                collectionWriter = (wr) => EmitDatatypeBoundedPool(bv, propertySuffix, inLetExprBody, wr, wStmts);
                return new UserDefinedType(bv.Tok, new NameSegment(bv.Tok, b.Decl.Name, new()))
                {
                    ResolvedClass = b.Decl
                };
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected BoundedPool type
            }

            return default;
        }

        protected virtual void EmitBoolBoundedPool(bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(1660L, "{0}.AllBooleans()"), GetHelperModuleName());
        }

        protected virtual void EmitCharBoundedPool(bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write($"{GetHelperModuleName()}.All{CharMethodQualifier}Chars()");
        }

        protected virtual void EmitWiggleWaggleBoundedPool(bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(1661L, "{0}.AllIntegers()"), GetHelperModuleName());
        }

        protected virtual void EmitSetBoundedPool(Expression of, string propertySuffix, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            TrParenExpr(of, wr, inLetExprBody, wStmts);
            wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(1662L, ".Elements") + propertySuffix);
        }

        protected virtual void EmitMultiSetBoundedPool(Expression of, bool includeDuplicates, string propertySuffix, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            TrParenExpr(of, wr, inLetExprBody, wStmts);
            wr.Write((includeDuplicates ? MutateCSharp.Schemata247.ReplaceStringConstant_2(1663L, ".Elements") : MutateCSharp.Schemata247.ReplaceStringConstant_2(1664L, ".UniqueElements")) + propertySuffix);
        }

        protected virtual void EmitSubSetBoundedPool(Expression of, string propertySuffix, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            TrParenExpr(of, wr, inLetExprBody, wStmts);
            wr.Write($".AllSubsets{propertySuffix}");
        }

        protected virtual void EmitMapBoundedPool(Expression map, string propertySuffix, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            TrParenExpr(map, wr, inLetExprBody, wStmts);
            GetSpecialFieldInfo(SpecialField.ID.Keys, null, null, out var keyName, out _, out _);
            wr.Write($".{keyName}.Elements{propertySuffix}");
        }

        protected virtual void EmitSeqBoundedPool(Expression of, bool includeDuplicates, string propertySuffix, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            TrParenExpr(of, wr, inLetExprBody, wStmts);
            wr.Write((includeDuplicates ? MutateCSharp.Schemata247.ReplaceStringConstant_2(1665L, ".Elements") : MutateCSharp.Schemata247.ReplaceStringConstant_2(1666L, ".UniqueElements")) + propertySuffix);
        }

        protected virtual void EmitDatatypeBoundedPool(IVariable bv, string propertySuffix, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(1667L, "{0}.AllSingletonConstructors{1}"), TypeName_Companion(bv.Type, wr, bv.Tok, null), propertySuffix);
        }

        private Expression SubstituteBound(IntBoundedPool b, List<BoundedPool> bounds, List<BoundVar> boundVars, int index, bool lowBound)
        {
            Contract.Requires(b != null);
            Contract.Requires((lowBound ? b.LowerBound : b.UpperBound) != null);
            Contract.Requires(bounds != null);
            Contract.Requires(boundVars != null);
            Contract.Requires(bounds.Count == boundVars.Count);
            Contract.Requires(0 <= index && index < boundVars.Count);
            // if the outer bound is dependent on the inner boundvar, we need to
            // substitute the inner boundvar with its bound.
            var bnd = lowBound ? b.LowerBound : b.UpperBound;
            var sm = new Dictionary<IVariable, Expression>();
            for (int i = MutateCSharp.Schemata247.ReplaceBinExprOp_60(1672L, index, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1668L, 1)); MutateCSharp.Schemata247.ReplaceBinExprOp_6(1681L, i, boundVars.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(1686L, ref i))
            {
                var bound = bounds[i];
                if (bound is IntBoundedPool)
                {
                    var ib = (IntBoundedPool)bound;
                    var bv = boundVars[i];
                    sm[bv] = lowBound ? ib.LowerBound : ib.UpperBound;
                }
            }
            var su = new Substituter(null, sm, new Dictionary<TypeParameter, Type>());
            return su.Substitute(bnd);
        }

        private void IntroduceAndAssignBoundVars(ExistsExpr exists, ConcreteSyntaxTree wr)
        {
            Contract.Requires(exists != null);
            Contract.Assume(exists.Bounds != null);  // follows from successful resolution
            Contract.Assert(exists.Range == null);  // follows from invariant of class IfStmt
            foreach (var bv in exists.BoundVars)
            {
                TrLocalVar(bv, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1687L, false), wr);
            }
            var ivars = exists.BoundVars.ConvertAll(bv => (IVariable)bv);
            TrAssignSuchThat(ivars, exists.Term, exists.Bounds, exists.tok.line, wr, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1688L, false));
        }

        private bool CanSequentializeForall(List<BoundVar> bvs, List<BoundedPool> bounds, Expression range, Expression lhs, Expression rhs)
        {
            // Given a statement
            //
            //   forall i, ... | R {
            //     L := E;
            //   }
            //
            // we sequentialize if all of these conditions hold:
            //
            //   1. There are no calls to functions which may have read effects in R,
            //      L, or E
            //   2. Each index value will be produced only once (note that this is
            //      currently always true thanks to the use of UniqueElements())
            //   3. If L has the form A[I] for some A and I, then one of the following
            //      is true:
            //      a. There are no array dereferences or array-to-sequence
            //         conversions in R, A, I, or E
            //      b. All of the following are true:
            //         i.   There is only one bound variable; call it i
            //         ii.  I is the variable i
            //         iii. Each array dereference in R, A, or E has the form B[i] for
            //              some B
            //         iv.  There are no array-to-sequence conversions in R, A, or E
            //   4. If L has the form A[I, J, ...] for some A, I, J, ... then there
            //      are no multi-D array dereferences in R, A, E, or any of the
            //      indices I, J, ...
            //   5. If L has the form O.f for some field f, then one of the following
            //      is true:
            //      a. There are no accesses of f in R, O, or E
            //      b. All of the following are true:
            //         i.   There is only one bound variable; call it i
            //         ii.  O is the variable i
            //         iii. Each access of f in R or E has the form i.f
            //
            // TODO It may be possible to weaken rule 4 by adding an alternative
            // similar to rules 3b and 5b.
            Contract.Assert(bvs.Count == bounds.Count);

            if (!noImpureFunctionCalls(lhs, rhs, range))
            {
                return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1689L, false);
            }
            else if (lhs is SeqSelectExpr sse)
            {
                return MutateCSharp.Schemata247.ReplaceBinExprOp_9(1719L, () => no1DArrayAccesses(sse.Seq, sse.E0, range, rhs), () => (MutateCSharp.Schemata247.ReplaceBinExprOp_8(1713L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_8(1703L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_27(1694L, bvs.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1690L, 1)), () => isVar(bvs[MutateCSharp.Schemata247.ReplaceNumericConstant_3(1699L, 0)], sse.E0)), () => indexIsAlwaysVar(bvs[MutateCSharp.Schemata247.ReplaceNumericConstant_3(1709L, 0)], range, sse.Seq, rhs)))); // also covers sequence conversions
            }
            else if (lhs is MultiSelectExpr mse)
            {
                return MutateCSharp.Schemata247.ReplaceBinExprOp_8(1725L, () => noMultiDArrayAccesses(mse.Array, range, rhs), () => noMultiDArrayAccesses(mse.Indices.ToArray()));
            }
            else
            {
                // !@#$#@$% scope rules won't let me call this mse ...
                var mse2 = (MemberSelectExpr)lhs;

                return MutateCSharp.Schemata247.ReplaceBinExprOp_9(1760L, () => noFieldAccesses(mse2.Member, mse2.Obj, range, rhs), () => (MutateCSharp.Schemata247.ReplaceBinExprOp_8(1754L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_8(1744L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_27(1735L, bvs.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1731L, 1)), () => isVar(bvs[MutateCSharp.Schemata247.ReplaceNumericConstant_3(1740L, 0)], mse2.Obj)), () => accessedObjectIsAlwaysVar(mse2.Member, bvs[MutateCSharp.Schemata247.ReplaceNumericConstant_3(1750L, 0)], range, rhs))));
            }

            bool noImpureFunctionCalls(params Expression[] exprs)
            {
                return exprs.All(e => Check<ApplyExpr>(e, ae =>
                {
                    var ty = (UserDefinedType)ae.Function.Type.NormalizeExpandKeepConstraints();
                    return MutateCSharp.Schemata247.ReplaceBinExprOp_9(1766L, () => ArrowType.IsPartialArrowTypeName(ty.Name), () => ArrowType.IsTotalArrowTypeName(ty.Name));
                }));
            }

            bool no1DArrayAccesses(params Expression[] exprs)
            {
                return exprs.All(e => Check<SeqSelectExpr>(e, sse => !sse.Seq.Type.IsArrayType)); // allow sequence accesses
            }

            bool noMultiDArrayAccesses(params Expression[] exprs)
            {
                return exprs.All(e => Check<MultiSelectExpr>(e, _ => MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1772L, false)));
            }

            bool noFieldAccesses(MemberDecl member, params Expression[] exprs)
            {
                return exprs.All(e => Check<MemberSelectExpr>(e, mse => MutateCSharp.Schemata247.ReplaceBinExprOp_63(1773L, mse.Member, member)));
            }

            bool isVar(BoundVar var, Expression expr)
            {
                return expr.Resolved is IdentifierExpr ie && MutateCSharp.Schemata247.ReplaceBinExprOp_64(1774L, ie.Var, var);
            }

            bool indexIsAlwaysVar(BoundVar var, params Expression[] exprs)
            {
                return exprs.All(e => Check<SeqSelectExpr>(e, sse2 => MutateCSharp.Schemata247.ReplaceBinExprOp_8(1775L, () => sse2.SelectOne, () => isVar(var, sse2.E0))));
            }

            bool accessedObjectIsAlwaysVar(MemberDecl member, BoundVar var, params Expression[] exprs)
            {
                return exprs.All(e => Check<MemberSelectExpr>(e, mse => MutateCSharp.Schemata247.ReplaceBinExprOp_9(1782L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_63(1781L, mse.Member, member), () => isVar(var, mse.Obj))));
            }

            return default;
        }

        /// <summary>
        /// Check all of the given expression's subexpressions of a given type
        /// using a predicate.  Returns true only if the predicate returns true for
        /// all subexpressions of type <typeparamref name="E"/>.
        /// </summary>
        private static bool Check<E>(Expression e, Predicate<E> pred) where E : Expression
        {
            var checker = new Checker<E>(pred);
            checker.Visit(e, null);
            return checker.Passing;
        }

        public class Checker<E> : TopDownVisitor<object> where E : Expression
        {
            private readonly Predicate<E> Pred;
            public bool Passing = MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1788L, true);

            public Checker(Predicate<E> pred)
            {
                Pred = pred;
            }

            protected override bool VisitOneExpr(Expression expr, ref object st)
            {
                if (expr is E e && !Pred(e))
                {
                    Passing = MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1789L, false);
                    return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1790L, false);
                }
                else
                {
                    return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1791L, true);
                }

                return default;
            }
        }

        private void TrAssignSuchThat(List<IVariable> lhss, Expression constraint, List<BoundedPool> bounds, int debuginfoLine, ConcreteSyntaxTree wr, bool inLetExprBody)
        {
            Contract.Requires(lhss != null);
            Contract.Requires(constraint != null);
            Contract.Requires(bounds != null);
            // For "i,j,k,l :| R(i,j,k,l);", emit something like:
            //
            // for (BigInteger iterLimit = 5; ; iterLimit *= 2) {
            //   var il$0 = iterLimit;
            //   foreach (L l' in sq.Elements) { l = l';
            //     if (il$0 == 0) { break; }  il$0--;
            //     var il$1 = iterLimit;
            //     foreach (K k' in st.Elements) { k = k';
            //       if (il$1 == 0) { break; }  il$1--;
            //       var il$2 = iterLimit;
            //       j = Lo;
            //       for (;; j++) {
            //         if (il$2 == 0) { break; }  il$2--;
            //         foreach (bool i' in Helper.AllBooleans) { i = i';
            //           if (R(i,j,k,l)) {
            //             goto ASSIGN_SUCH_THAT_<id>;
            //           }
            //         }
            //       }
            //     }
            //   }
            // }
            // throw new Exception("assign-such-that search produced no value"); // a verified program never gets here; however, we need this "throw" to please the C# compiler
            // ASSIGN_SUCH_THAT_<id>: ;
            //
            // where the iterLimit loop can be omitted if lhss.Count == 1 or if all bounds are finite.  Further optimizations could be done, but
            // are omitted for now.
            //
            var n = lhss.Count;
            Contract.Assert(bounds.Count == n);
            var c = ProtectedFreshNumericId(MutateCSharp.Schemata247.ReplaceStringConstant_2(1792L, "_ASSIGN_SUCH_THAT_+_iterLimit_"));
            var doneLabel = MutateCSharp.Schemata247.ReplaceStringConstant_2(1793L, "_ASSIGN_SUCH_THAT_") + c;
            var iterLimit = MutateCSharp.Schemata247.ReplaceStringConstant_2(1794L, "_iterLimit_") + c;

            bool needIterLimit = MutateCSharp.Schemata247.ReplaceBinExprOp_8(1804L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_21(1799L, lhss.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1795L, 1)), () => bounds.Exists(bnd => (bnd.Virtues & BoundedPool.PoolVirtues.Finite) == 0));
            var currentBlock = wr.Fork();
            wr = CreateLabeledCode(doneLabel, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1810L, false), wr);
            var wrOuter = wr;
            if (needIterLimit)
            {
                wr = CreateDoublingForLoop(iterLimit, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1811L, 5), wr);
                currentBlock = wr;
            }

            for (int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1815L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(1819L, i, n); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(1824L, ref i))
            {
                var bound = bounds[i];
                Contract.Assert((bound.Virtues & BoundedPool.PoolVirtues.Enumerable) != 0);  // if we have got this far, it must be an enumerable bound
                var bv = lhss[i];
                if (needIterLimit)
                {
                    DeclareLocalVar(string.Format(MutateCSharp.Schemata247.ReplaceStringConstant_2(1825L, "{0}_{1}"), iterLimit, i), null, null, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1826L, false), iterLimit, currentBlock, Type.Int);
                }
                var tmpVar = ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(1827L, "_assign_such_that_"));
                var wStmts = currentBlock.Fork();
                var elementType = CompileCollection(bound, bv, inLetExprBody, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1828L, true), null, out var collection, wStmts);
                wr = CreateGuardedForeachLoop(tmpVar, elementType, bv, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1829L, false), inLetExprBody, bv.Tok, collection, wr);
                currentBlock = wr;
                if (needIterLimit)
                {
                    var varName = $"{iterLimit}_{i}";
                    var thn = EmitIf(out var isZeroWriter, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1830L, false), wr);
                    EmitIsZero(varName, isZeroWriter);
                    EmitBreak(null, thn);
                    EmitDecrementVar(varName, wr);
                }
            }

            copyInstrWriters.Push(wr.Fork());
            var wStmtsIf = wr.Fork();
            var wBody = EmitIf(out var guardWriter, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1831L, false), wr);
            EmitExpr(constraint, inLetExprBody, guardWriter, wStmtsIf);
            EmitBreak(doneLabel, wBody);
            copyInstrWriters.Pop();

            // Java compiler throws unreachable error when absurd statement is written after unbounded for-loop, so we don't write it then.
            EmitAbsurd(string.Format(MutateCSharp.Schemata247.ReplaceStringConstant_2(1832L, "assign-such-that search produced no value (line {0})"), debuginfoLine), wrOuter, needIterLimit);
        }

        public interface ILvalue
        {
            void EmitRead(ConcreteSyntaxTree wr);

            /// Write an assignment expression (or equivalent) for the lvalue,
            /// returning a TargetWriter for the RHS.  IMPORTANT: Whoever calls
            /// EmitWrite is responsible for making the types match up (as by
            /// EmitCoercionIfNecessary), for example by going through the overload
            /// of EmitAssignment that takes an ILvalue.
            ConcreteSyntaxTree EmitWrite(ConcreteSyntaxTree wr);
        }

        protected ILvalue SimpleLvalue(Action<ConcreteSyntaxTree> action)
        {
            return new SimpleLvalueImpl(this, action);
        }

        protected ILvalue SimpleLvalue(Action<ConcreteSyntaxTree> lvalueAction, Action<ConcreteSyntaxTree> rvalueAction)
        {
            return new SimpleLvalueImpl(this, lvalueAction, rvalueAction);
        }

        protected ILvalue VariableLvalue(IVariable var)
        {
            return IdentLvalue(IdName(var));
        }

        protected virtual ILvalue IdentLvalue(string var)
        {
            return StringLvalue(var);
        }

        protected virtual ILvalue SeqSelectLvalue(SeqSelectExpr ll, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var arr = StabilizeExpr(ll.Seq, MutateCSharp.Schemata247.ReplaceStringConstant_2(1833L, "_arr"), wr, wStmts);
            var index = StabilizeExpr(ll.E0, MutateCSharp.Schemata247.ReplaceStringConstant_2(1834L, "_index"), wr, wStmts);
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_9(1836L, () => ll.Seq.Type.IsArrayType, () => MutateCSharp.Schemata247.ReplaceBinExprOp_11(1835L, ll.Seq.Type.NormalizeToAncestorType().AsSeqType, null)))
            {
                index = ArrayIndexToNativeInt(index, ll.E0.Type);
            }
            return new ArrayLvalueImpl(this, arr, new List<Action<ConcreteSyntaxTree>>() { wIndex => wIndex.Write(index) }, ll.Type);
        }

        protected virtual ILvalue MultiSelectLvalue(MultiSelectExpr ll, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            string arr = StabilizeExpr(ll.Array, MutateCSharp.Schemata247.ReplaceStringConstant_2(1842L, "_arr"), wr, wStmts);
            var indices = new List<string>();
            int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1843L, 0);
            foreach (var idx in ll.Indices)
            {
                var index = StabilizeExpr(idx, MutateCSharp.Schemata247.ReplaceStringConstant_2(1847L, "_index") + i + MutateCSharp.Schemata247.ReplaceStringConstant_2(1848L, "_"), wr, wStmts);
                index = ArrayIndexToNativeInt(index, idx.Type);
                indices.Add(index);
                MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(1849L, ref i);
            }
            return new ArrayLvalueImpl(this, arr, Util.Map<string, Action<ConcreteSyntaxTree>>(indices, i => wIndex => wIndex.Write(i)), ll.Type);
        }

        protected ILvalue StringLvalue(string str)
        {
            return new SimpleLvalueImpl(this, wr => wr.Write(str));
        }

        protected ILvalue SuffixLvalue(Action<ConcreteSyntaxTree> action, string str, params object[] args)
        {
            return new SimpleLvalueImpl(this, wr => { action(wr); wr.Write(str, args); });
        }

        protected ILvalue EnclosedLvalue(string prefix, Action<ConcreteSyntaxTree> action, string suffixStr, params object[] suffixArgs)
        {
            return new SimpleLvalueImpl(this, wr => { wr.Write(prefix); action(wr); wr.Write(suffixStr, suffixArgs); });
        }

        protected ILvalue CoercedLvalue(ILvalue lvalue, Type/*?*/ from, Type/*?*/ to)
        {
            return new CoercedLvalueImpl(this, lvalue, from, to);
        }

        protected ILvalue GetterSetterLvalue(Action<ConcreteSyntaxTree> obj, string getterName, string setterName)
        {
            Contract.Requires(obj != null);
            Contract.Requires(getterName != null);
            Contract.Requires(setterName != null);
            return new GetterSetterLvalueImpl(obj, getterName, setterName);
        }

        public class SimpleLvalueImpl : ILvalue
        {
            private readonly SinglePassCodeGenerator codeGenerator;
            private readonly Action<ConcreteSyntaxTree> LvalueAction, RvalueAction;

            public SimpleLvalueImpl(SinglePassCodeGenerator codeGenerator, Action<ConcreteSyntaxTree> action)
            {
                this.codeGenerator = codeGenerator;
                LvalueAction = action;
                RvalueAction = action;
            }

            public SimpleLvalueImpl(SinglePassCodeGenerator codeGenerator, Action<ConcreteSyntaxTree> lvalueAction, Action<ConcreteSyntaxTree> rvalueAction)
            {
                this.codeGenerator = codeGenerator;
                LvalueAction = lvalueAction;
                RvalueAction = rvalueAction;
            }

            public void EmitRead(ConcreteSyntaxTree wr)
            {
                RvalueAction(wr);
            }

            public ConcreteSyntaxTree EmitWrite(ConcreteSyntaxTree wr)
            {
                codeGenerator.EmitAssignment(out var wLhs, null, out var wRhs, null, wr);
                LvalueAction(wLhs);
                return wRhs;
            }
        }

        public class CoercedLvalueImpl : ILvalue
        {
            private readonly SinglePassCodeGenerator codeGenerator;
            private readonly ILvalue lvalue;
            private readonly Type /*?*/ from;
            private readonly Type /*?*/ to;

            public CoercedLvalueImpl(SinglePassCodeGenerator codeGenerator, ILvalue lvalue, Type/*?*/ from, Type/*?*/ to)
            {
                this.codeGenerator = codeGenerator;
                this.lvalue = lvalue;
                this.from = from;
                this.to = to;
            }

            public void EmitRead(ConcreteSyntaxTree wr)
            {
                wr = codeGenerator.EmitCoercionIfNecessary(from, to, Token.NoToken, wr);
                lvalue.EmitRead(wr);
            }

            public ConcreteSyntaxTree EmitWrite(ConcreteSyntaxTree wr)
            {
                return lvalue.EmitWrite(wr);
            }
        }

        public class GetterSetterLvalueImpl : ILvalue
        {
            private readonly Action<ConcreteSyntaxTree> obj;
            private readonly string getterName;
            private readonly string setterName;

            public GetterSetterLvalueImpl(Action<ConcreteSyntaxTree> obj, string getterName, string setterName)
            {
                this.obj = obj;
                this.getterName = getterName;
                this.setterName = setterName;
            }

            public void EmitRead(ConcreteSyntaxTree wr)
            {
                obj(wr);
                wr.Write($".{getterName}()");
            }

            public ConcreteSyntaxTree EmitWrite(ConcreteSyntaxTree wr)
            {
                obj(wr);
                wr.Write($".{setterName}(");
                var w = wr.Fork();
                wr.WriteLine(MutateCSharp.Schemata247.ReplaceStringConstant_2(1850L, ");"));
                return w;
            }
        }

        public class ArrayLvalueImpl : ILvalue
        {
            private readonly SinglePassCodeGenerator codeGenerator;
            private readonly string array;
            private readonly List<Action<ConcreteSyntaxTree>> indices;
            private readonly Type lhsType;

            /// <summary>
            /// The "indices" are expected to already be of the native array-index type.
            /// </summary>
            public ArrayLvalueImpl(SinglePassCodeGenerator codeGenerator, string array, List<Action<ConcreteSyntaxTree>> indices, Type lhsType)
            {
                this.codeGenerator = codeGenerator;
                this.array = array;
                this.indices = indices;
                this.lhsType = lhsType;
            }

            public void EmitRead(ConcreteSyntaxTree wr)
            {
                var wrArray = codeGenerator.EmitArraySelect(indices, lhsType, wr);
                codeGenerator.EmitIdentifier(array, wrArray);
            }

            public ConcreteSyntaxTree EmitWrite(ConcreteSyntaxTree wr)
            {
                var (wrArray, wrRhs) = codeGenerator.EmitArrayUpdate(indices, lhsType, wr);
                codeGenerator.EmitIdentifier(array, wrArray);
                codeGenerator.EndStmt(wr);
                return wrRhs;
            }
        }

        ILvalue CreateLvalue(Expression lhs, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            Contract.Requires(lhs != null);
            Contract.Requires(wr != null);

            lhs = lhs.Resolved;
            if (lhs is IdentifierExpr)
            {
                var ll = (IdentifierExpr)lhs;
                return VariableLvalue(ll.Var);
            }
            else if (lhs is MemberSelectExpr)
            {
                var ll = (MemberSelectExpr)lhs;
                Contract.Assert(!ll.Member.IsInstanceIndependentConstant);  // instance-independent const's don't have assignment statements
                var writeStabilized = EmitStabilizedExpr(
                  ll.Obj,
        MutateCSharp.Schemata247.ReplaceBinExprOp_9(1851L, () => ll.Obj.Type.IsNonNullRefType, () => !ll.Obj.Type.IsRefType) ? null : UserDefinedType.CreateNonNullType((UserDefinedType)ll.Obj.Type.NormalizeExpand()),
        MutateCSharp.Schemata247.ReplaceStringConstant_2(1857L, "_obj"), wr, wStmts
                );
                var typeArgs = TypeArgumentInstantiation.ListFromMember(ll.Member, null, ll.TypeApplication_JustMember);
                return EmitMemberSelect(writeStabilized, ll.Obj.Type, ll.Member, typeArgs, ll.TypeArgumentSubstitutionsWithParents(), lhs.Type,
                  internalAccess: enclosingMethod is Constructor);

            }
            else if (lhs is SeqSelectExpr)
            {
                var ll = (SeqSelectExpr)lhs;
                return SeqSelectLvalue(ll, wr, wStmts);
            }
            else
            {
                var ll = (MultiSelectExpr)lhs;
                return MultiSelectLvalue(ll, wr, wStmts);
            }

            return default;
        }

        private Action<ConcreteSyntaxTree> EmitStabilizedExpr(Expression e, Type coercedType, string prefix, ConcreteSyntaxTree surrounding, ConcreteSyntaxTree wStmts)
        {
            if (IsStableExpr(e))
            {
                return outWr => TrParenExpr(e, EmitCoercionIfNecessary(e.Type, coercedType, null, outWr), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1858L, false), wStmts);
            }
            else
            {
                var v = ProtectedFreshId(prefix);
                var preVarSurrounding = surrounding.Fork();
                EmitExpr(
                  e, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1859L, false),
                  EmitCoercionIfNecessary(e.Type, coercedType, null, DeclareLocalVar(v, coercedType ?? e.Type, null, surrounding)),
                  preVarSurrounding
                );
                return outWr => EmitIdentifier(v, outWr);
            }

            return default;
        }

        /// <summary>
        /// If the given expression's value is stable, translate it and return the
        /// string form.  Otherwise, output code to evaluate the expression, then
        /// return a fresh variable bound to its value.
        /// </summary>
        /// <param name="e">An expression to evaluate</param>
        /// <param name="prefix">The prefix to give the fresh variable, if
        /// needed.</param>
        /// <param name="wr">A writer in a position to write statements
        /// evaluating the expression</param>
        /// <returns>A string giving the translated value as a stable
        /// expression</returns>
        /// <seealso cref="IsStableExpr"/>
        private string StabilizeExpr(Expression e, string prefix, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var localWr = new ConcreteSyntaxTree();
            EmitStabilizedExpr(e, null, prefix, wr, wStmts)(localWr);
            return localWr.ToString();
        }

        /// <summary>
        /// Returns whether the given expression is <em>stable</em>, that is,
        /// whether its value is fixed over the course of the evaluation of an
        /// expression.  Note that anything that could be altered by a function call
        /// (say, the value of a non-constant field) is unstable.
        /// </summary>
        private bool IsStableExpr(Expression e)
        {
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_9(1866L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_9(1860L, () => e is IdentifierExpr, () => e is ThisExpr), () => e is LiteralExpr))
            {
                return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1872L, true);
            }
            else if (e is MemberSelectExpr mse)
            {
                if (!IsStableExpr(mse.Obj))
                {
                    return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1873L, false);
                }
                var member = mse.Member;
                if (member is ConstantField)
                {
                    return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1874L, true);
                }
                else if (member is SpecialField sf)
                {
                    switch (sf.SpecialId)
                    {
                        case SpecialField.ID.ArrayLength:
                        case SpecialField.ID.ArrayLengthInt:
                        case SpecialField.ID.Floor:
                        case SpecialField.ID.IsLimit:
                        case SpecialField.ID.IsSucc:
                        case SpecialField.ID.Offset:
                        case SpecialField.ID.IsNat:
                        case SpecialField.ID.Keys:
                        case SpecialField.ID.Values:
                        case SpecialField.ID.Items:
                            return true;
                            break;
                        default:
                            return false;
                            break;
                    }
                }
                else
                {
                    return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1875L, false);
                }
            }
            else if (e is ConcreteSyntaxExpression cse)
            {
                return IsStableExpr(cse.ResolvedExpression);
            }
            else
            {
                return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1876L, false);
            }

            return default;
        }

        /// <summary>
        /// Translate the right-hand side of an assignment.
        /// </summary>
        /// <param name="rhs">The RHS to translate</param>
        /// <param name="wr">The writer at the position for the translated RHS</param>
        /// <param name="wStmts">A writer at an earlier position where extra statements may be written</param>
        void TrRhs(AssignmentRhs rhs, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            Contract.Requires(!(rhs is HavocRhs));
            Contract.Requires(wr != null);

            var typeRhs = rhs as TypeRhs;

            if (MutateCSharp.Schemata247.ReplaceBinExprOp_65(1877L, typeRhs, null))
            {
                var eRhs = (ExprRhs)rhs; // it's not HavocRhs (by the precondition) or TypeRhs (by the "if" test), so it's gotta be ExprRhs
                EmitExpr(eRhs.Expr, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1878L, false), wr, wStmts);

            }
            else if (MutateCSharp.Schemata247.ReplaceBinExprOp_26(1879L, typeRhs.ArrayDimensions, null))
            {
                var nw = ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(1880L, "_nw"));
                TrRhsArray(typeRhs, nw, wr, wStmts);
                EmitIdentifier(nw, wr);

            }
            else
            {
                // Allocate and initialize a new object
                var nw = ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(1881L, "_nw"));
                var wRhs = DeclareLocalVar(nw, typeRhs.Type, rhs.Tok, wStmts);
                var constructor = typeRhs.InitCall?.Method as Constructor;
                EmitNew(typeRhs.EType, typeRhs.Tok, MutateCSharp.Schemata247.ReplaceBinExprOp_12(1882L, constructor, null) ? typeRhs.InitCall : null, wRhs, wStmts);
                // Proceed with initialization
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_66(1883L, typeRhs.InitCall, null))
                {
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_12(1884L, constructor, null) && constructor.IsExtern(Options, out _, out _))
                    {
                        // initialization was done at the time of allocation
                    }
                    else
                    {
                        var wrBefore = wStmts.Fork();
                        var wrCall = wStmts.Fork();
                        var wrAfter = wStmts;
                        TrCallStmt(typeRhs.InitCall, nw, wrCall, wrBefore, wrAfter);
                    }
                }
                // Assign to the final LHS
                EmitIdentifier(nw, wr);
            }
        }

        /// <summary>
        /// Translate the right-hand side of an assignment.
        /// </summary>
        /// <param name="rhs">The RHS to translate</param>
        /// <param name="nw">Name of the variable to hold the array to be allocated</param>
        /// <param name="wr">The writer at the position for the translated RHS</param>
        /// <param name="wStmts">A writer at an earlier position where extra statements may be written</param>
        void TrRhsArray(TypeRhs typeRhs, string nw, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            Contract.Requires(typeRhs.ArrayDimensions != null);

            if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(1902L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_38(1885L, typeRhs.ElementInit, null), () => (MutateCSharp.Schemata247.ReplaceBinExprOp_9(1896L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_67(1886L, typeRhs.InitDisplay, null), () => MutateCSharp.Schemata247.ReplaceBinExprOp_27(1891L, typeRhs.InitDisplay.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1887L, 0))))))
            {
                // This is either
                //   * an array with an auto-init element type, where no other initialization is given, or
                //   * a 0-length array (as evidenced by the given 0-length .InitDisplay or as confirmed by the verifier for a non-auto-init element type).
                var pwStmts = wStmts.Fork();
                var wRhs = DeclareLocalVar(nw, typeRhs.Type, typeRhs.Tok, wStmts);
                EmitNewArray(typeRhs.EType, typeRhs.Tok, typeRhs.ArrayDimensions,
        MutateCSharp.Schemata247.ReplaceBinExprOp_8(1908L, () => typeRhs.EType.HasCompilableValue, () => !DatatypeWrapperEraser.CanBeLeftUninitialized(Options, typeRhs.EType)),
                  null, wRhs, pwStmts);
                return;
            }

            if (MutateCSharp.Schemata247.ReplaceBinExprOp_38(1914L, typeRhs.ElementInit, null))
            {
                Contract.Assert((typeRhs.InitDisplay != null && typeRhs.InitDisplay.Count != 0) || DatatypeWrapperEraser.CanBeLeftUninitialized(Options, typeRhs.EType));

                string nwElement0;
                if (DeterminesArrayTypeFromExampleElement)
                {
                    // We use the first element of the array as an "example" for the array to be allocated
                    nwElement0 = ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(1915L, "_nwElement0_"));
                    var wrElement0 = DeclareLocalVar(nwElement0, typeRhs.EType, typeRhs.InitDisplay[MutateCSharp.Schemata247.ReplaceNumericConstant_3(1916L, 0)].tok, wStmts);
                    EmitExpr(typeRhs.InitDisplay[MutateCSharp.Schemata247.ReplaceNumericConstant_3(1920L, 0)], MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1924L, false), wrElement0, wStmts);
                }
                else
                {
                    nwElement0 = null;
                }

                var pwStmts = wStmts.Fork();
                var wRhs = DeclareLocalVar(nw, typeRhs.Type, typeRhs.Tok, wStmts);
                EmitNewArray(typeRhs.EType, typeRhs.Tok, typeRhs.ArrayDimensions, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1925L, false), nwElement0, wRhs, pwStmts);

                var ii = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1926L, 0);
                foreach (var v in typeRhs.InitDisplay)
                {
                    pwStmts = wStmts.Fork();
                    var (wArray, wElement) = EmitArrayUpdate(new List<Action<ConcreteSyntaxTree>> { wIndex => EmitExprAsNativeInt(new LiteralExpr(null, ii) {
            Type = Type.Int
          }, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1930L, false), wIndex, wStmts) }, v.Type, wStmts);
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(1940L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_27(1935L, ii, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1931L, 0)), () => nwElement0 != null))
                    {
                        EmitIdentifier(nwElement0, wElement);
                    }
                    else
                    {
                        EmitExpr(v, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1946L, false), wElement, pwStmts);
                    }
                    EmitIdentifier(nw, wArray);
                    EndStmt(wStmts);
                    MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(1947L, ref ii);
                }

            }
            else if (DeterminesArrayTypeFromExampleElement)
            {
                // For a 3-dimensional array allocation
                //     m := new X[e0, e1, e2](InitFunction);
                // generate:
                //     var _len0 := e0;
                //     var _len1 := e1;
                //     var _len2 := e2;
                //     var _nw;
                //     if e0 == 0 || e1 == 0 || e2 == 0 {
                //       _nw := NewArray(X, _len0, _len1, _len2);
                //     } else {
                //       var _init := InitFunction;
                //       var _element0 := _init(0, 0, 0);
                //       _nw := NewArrayFromExample(X, _element0, _len0, _len1, _len2);
                //       ArrayUpdate(_nw, _element0, 0, 0, 0);
                //       var _nativeLen0 := IntToArrayIndex(_len0);
                //       var _nativeLen1 := IntToArrayIndex(_len1);
                //       var _nativeLen2 := IntToArrayIndex(_len2);
                //       var _start := 1;
                //       for (var _i0 := 0; _i0 < _nativeLen0; _i0++) {
                //         for (var _i1 := 0; _i1 < _nativeLen1; _i1++) {
                //           for (var _i2 := _start; _i2 < _nativeLen2; _i2++) {
                //             ArrayUpdate(_nw, _init(_i0, _i1, _i2), _i0, _i1, _i2);
                //           }
                //           _start := 0; // omit, if there's only one dimension
                //         }
                //       }
                //     }
                // Put the array dimensions into local variables
                var dimNames = new List<string>();
                for (var d = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1948L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(1952L, d, typeRhs.ArrayDimensions.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(1957L, ref d))
                {
                    var dim = typeRhs.ArrayDimensions[d];
                    var dimName = ProtectedFreshId($"_len{d}_");
                    dimNames.Add(dimName);
                    var wrDim = DeclareLocalVar(dimName, Type.Int, dim.tok, wStmts);
                    wrDim = ExprToInt(dim.Type, wrDim);
                    EmitExpr(dim, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1958L, false), wrDim, wStmts);
                }

                // Declare the _nw variable
                DeclareLocalVar(nw, typeRhs.Type, typeRhs.Tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1959L, false), null, wStmts);

                // Generate if statement
                var wThen = EmitIf(out var guardWriter, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1960L, true), wStmts);
                for (var d = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1961L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(1965L, d, typeRhs.ArrayDimensions.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(1970L, ref d))
                {
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_21(1975L, d, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1971L, 0)))
                    {
                        guardWriter.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(1980L, " || "));
                    }
                    EmitIsZero(dimNames[d], guardWriter);
                }
                var wRhs = new ConcreteSyntaxTree();
                EmitNewArray(typeRhs.EType, typeRhs.Tok, dimNames, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1981L, false), null, wRhs, wThen);
                EmitAssignment(nw, typeRhs.Type, wRhs.ToString(), typeRhs.Type, wThen);

                var wElse = EmitBlock(wStmts);

                // Put the array-initializing function into a local variable
                string init = ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(1982L, "_init"));
                DeclareLocalVar(init, typeRhs.ElementInit.Type, typeRhs.ElementInit.tok, typeRhs.ElementInit, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1983L, false), wElse);

                // var _element0 := _init(0, 0, 0);
                var initFunctionType = typeRhs.ElementInit.Type.AsArrowType;
                Contract.Assert(initFunctionType != null && initFunctionType.Arity == typeRhs.ArrayDimensions.Count);
                var element0 = ProtectedFreshId($"_element0_");
                wRhs = DeclareLocalVar(element0, null, typeRhs.Tok, wElse);
                wRhs.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(1984L, "{0}{1}({2})"), init, LambdaExecute, initFunctionType.Args.Comma(argumentType =>
                {
                    var zero = Expression.CreateIntLiteral(typeRhs.Tok, MutateCSharp.Schemata247.ReplaceNumericConstant_3(1985L, 0), argumentType);
                    return Expr(zero, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1989L, false), wElse).ToString();
                }));

                // _nw := NewArrayFromExample(X, _element0, _len0, _len1, _len2);
                wRhs = new ConcreteSyntaxTree();
                EmitNewArray(typeRhs.EType, typeRhs.Tok, dimNames, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(1990L, false), element0, wRhs, wElse);
                EmitAssignment(nw, typeRhs.Type, wRhs.ToString(), typeRhs.Type, wElse);

                // _nw[0, 0, 0] := _element0;
                var indices = Util.Map(Enumerable.Range(MutateCSharp.Schemata247.ReplaceNumericConstant_3(1991L, 0), typeRhs.ArrayDimensions.Count), _ => ArrayIndexLiteral(MutateCSharp.Schemata247.ReplaceNumericConstant_3(1995L, 0)));
                var (wArray, wrRhs) = EmitArrayUpdate(Util.Map<string, Action<ConcreteSyntaxTree>>(indices, i => wIndex => wIndex.Write(i)), typeRhs.EType, wElse);
                EmitIdentifier(element0, wrRhs);
                EmitIdentifier(nw, wArray);
                EndStmt(wElse);

                // Compute native array dimensions
                var nativeDimNames = new List<string>();
                for (var d = MutateCSharp.Schemata247.ReplaceNumericConstant_3(1999L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(2003L, d, typeRhs.ArrayDimensions.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(2008L, ref d))
                {
                    var dim = typeRhs.ArrayDimensions[d];
                    var nativeDimName = ProtectedFreshId($"_nativeLen{d}_");
                    nativeDimNames.Add(nativeDimName);
                    var wrDim = DeclareLocalVar(nativeDimName, null, dim.tok, wElse);
                    wrDim.Write(ArrayIndexToNativeInt(dimNames[d], Type.Int));
                }

                // var _start := 1;
                string startName;
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_27(2013L, typeRhs.ArrayDimensions.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(2009L, 1)))
                {
                    startName = ArrayIndexLiteral(MutateCSharp.Schemata247.ReplaceNumericConstant_3(2018L, 1));
                }
                else
                {
                    startName = ProtectedFreshId($"_start");
                    DeclareLocalVar(startName, null, typeRhs.Tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2022L, false), ArrayIndexLiteral(MutateCSharp.Schemata247.ReplaceNumericConstant_3(2023L, 1)), wElse);
                }

                // Build a nested loop that will call the initializer for all indices
                indices = Util.Map(Enumerable.Range(MutateCSharp.Schemata247.ReplaceNumericConstant_3(2027L, 0), typeRhs.ArrayDimensions.Count), ii => ProtectedFreshId($"_i{ii}_"));
                var w = wElse;
                for (var d = MutateCSharp.Schemata247.ReplaceNumericConstant_3(2031L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(2035L, d, typeRhs.ArrayDimensions.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(2040L, ref d))
                {
                    var innerMostLoop = MutateCSharp.Schemata247.ReplaceBinExprOp_27(2054L, d, MutateCSharp.Schemata247.ReplaceBinExprOp_37(2045L, typeRhs.ArrayDimensions.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(2041L, 1)));
                    var wLoopBody = CreateForLoop(indices[d], w => EmitIdentifier(nativeDimNames[d], w), w, innerMostLoop ? startName : null);
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(2068L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_21(2063L, typeRhs.ArrayDimensions.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(2059L, 1)), () => innerMostLoop))
                    {
                        EmitAssignment(startName, Type.Int, ArrayIndexLiteral(MutateCSharp.Schemata247.ReplaceNumericConstant_3(2074L, 0)), Type.Int, w);
                    }
                    w = wLoopBody;
                }
                (wArray, wrRhs) = EmitArrayUpdate(Util.Map<string, Action<ConcreteSyntaxTree>>(indices, i => wIndex => wIndex.Write(i)), typeRhs.EType, w);
                wrRhs.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(2078L, "{0}{1}({2})"), init, LambdaExecute, Enumerable.Range(MutateCSharp.Schemata247.ReplaceNumericConstant_3(2079L, 0), indices.Count).Comma(idx => ArrayIndexToInt(indices[idx])));
                wArray.Write(nw);
                EndStmt(w);

            }
            else
            {
                // For a 3-dimensional array allocation
                //     m := new X[e0, e1, e2](InitFunction);
                // generate:
                //     var _init := InitFunction;
                //     var _nw := NewArray(X, e0, e1, e2);
                //     for (var _i0 := 0; _i0 < _nw.Length0; _i0++) {
                //       for (var _i1 := 0; _i1 < _nw.Length1; _i1++) {
                //         for (var _i2 := 0; _i2 < _nw.Length2; _i2++) {
                //           ArrayUpdate(_nw, _init(_i0, _i1, _i2), _i0, _i1, _i2);
                //         }
                //       }
                //     }

                // Put the array-initializing function into a local variable
                string init = ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(2083L, "_init"));
                DeclareLocalVar(init, typeRhs.ElementInit.Type, typeRhs.ElementInit.tok, typeRhs.ElementInit, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2084L, false), wStmts);

                var pwStmts = wStmts.Fork();
                var wRhs = DeclareLocalVar(nw, typeRhs.Type, typeRhs.Tok, wStmts);
                EmitNewArray(typeRhs.EType, typeRhs.Tok, typeRhs.ArrayDimensions, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2085L, false), null, wRhs, pwStmts);

                // Build a nested loop that will call the initializer for all indices
                var indices = Util.Map(Enumerable.Range(MutateCSharp.Schemata247.ReplaceNumericConstant_3(2086L, 0), typeRhs.ArrayDimensions.Count), ii => ProtectedFreshId($"_i{ii}_"));
                var w = wStmts;
                for (var d = MutateCSharp.Schemata247.ReplaceNumericConstant_3(2090L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(2094L, d, typeRhs.ArrayDimensions.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(2099L, ref d))
                {
                    w = CreateForLoop(indices[d], w =>
                    {
                        EmitArrayLength(w => EmitIdentifier(nw, w), typeRhs, d, w);
                    }, w);
                }
                var (wArray, wrRhs) = EmitArrayUpdate(Util.Map<string, Action<ConcreteSyntaxTree>>(indices, i => wIndex => EmitIdentifier(i, wIndex)), typeRhs.EType, w);
                wrRhs = EmitCoercionIfNecessary(TypeForCoercion(typeRhs.EType), typeRhs.EType, typeRhs.Tok, wrRhs);
                EmitLambdaApply(wrRhs, out var wLambda, out var wArg);
                EmitIdentifier(init, wLambda);
                for (var i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(2100L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(2104L, i, indices.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(2109L, ref i))
                {
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_4(2114L, i, MutateCSharp.Schemata247.ReplaceNumericConstant_3(2110L, 0)))
                    {
                        wArg.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(2119L, ", "));
                    }
                    EmitIdentifier(ArrayIndexToInt(indices[i]), wArg);
                }
                EmitIdentifier(nw, wArray);
                EndStmt(w);
            }
        }

        protected virtual void EmitArrayLength(Action<ConcreteSyntaxTree> arr, TypeRhs typeRhs, int d, ConcreteSyntaxTree w)
        {
            GetSpecialFieldInfo(SpecialField.ID.ArrayLength, MutateCSharp.Schemata247.ReplaceBinExprOp_27(2124L, typeRhs.ArrayDimensions.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(2120L, 1)) ? null : d, typeRhs.Type,
                        out var len, out var pre, out var post);
            w.Write($"{pre}");
            arr(w);
            w.Write($"{(MutateCSharp.Schemata247.ReplaceBinExprOp_33(2129L, len, "") ? "" : MutateCSharp.Schemata247.ReplaceStringConstant_2(2130L, ".") + len)}{post}");
        }

        private static Type TypeOfLhs(Expression lhs)
        {
            Contract.Requires(lhs != null);
            if (lhs is IdentifierExpr)
            {
                var e = (IdentifierExpr)lhs;
                return e.Var.Type;
            }
            else if (lhs is MemberSelectExpr)
            {
                var e = (MemberSelectExpr)lhs;
                return ((Field)e.Member).Type.Subst(e.TypeArgumentSubstitutionsWithParents());
            }
            else if (lhs is SeqSelectExpr)
            {
                var e = (SeqSelectExpr)lhs;
                return e.Seq.Type.NormalizeExpand().TypeArgs[MutateCSharp.Schemata247.ReplaceNumericConstant_3(2131L, 0)];
            }
            else
            {
                var e = (MultiSelectExpr)lhs;
                return e.Array.Type.NormalizeExpand().TypeArgs[MutateCSharp.Schemata247.ReplaceNumericConstant_3(2135L, 0)];
            }

            return default;
        }

        // to do: Make Type an abstract property of AssignmentRhs.  Unfortunately, this would first require convincing Microsoft that it makes sense for a base class to have a property that's only settable in some subclasses.  Until then, let it be known that Java's "properties" (i.e. getter/setter pairs) are more powerful >:-)
        private static Type TypeOfRhs(AssignmentRhs rhs)
        {
            if (rhs is TypeRhs tRhs)
            {
                return tRhs.Type;
            }
            else if (rhs is ExprRhs eRhs)
            {
                return eRhs.Expr.Type;
            }
            else
            {
                return null;
            }

            return default;
        }

        protected virtual void TrCallStmt(CallStmt s, string receiverReplacement, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts, ConcreteSyntaxTree wStmtsAfterCall)
        {
            Contract.Requires(s != null);
            Contract.Assert(s.Method != null);  // follows from the fact that stmt has been successfully resolved

            if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(2140L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_47(2139L, s.Method, enclosingMethod), () => enclosingMethod.IsTailRecursive))
            {
                // compile call as tail-recursive
                TrTailCallStmt(s.Tok, s.Method, s.Receiver, s.Args, receiverReplacement, wr);
            }
            else
            {
                // compile call as a regular call
                var lvalues = new List<ILvalue>();  // contains an entry for each non-ghost formal out-parameter, but the entry is null if the actual out-parameter is ghost
                Contract.Assert(s.Lhs.Count == s.Method.Outs.Count);
                for (int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(2146L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(2150L, i, s.Method.Outs.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(2155L, ref i))
                {
                    Formal p = s.Method.Outs[i];
                    if (!p.IsGhost)
                    {
                        var lhs = s.Lhs[i].Resolved;
                        if (lhs is IdentifierExpr lhsIE && lhsIE.Var.IsGhost)
                        {
                            lvalues.Add(null);
                        }
                        else if (lhs is MemberSelectExpr lhsMSE && lhsMSE.Member.IsGhost)
                        {
                            lvalues.Add(null);
                        }
                        else
                        {
                            lvalues.Add(CreateLvalue(s.Lhs[i], wStmts, wStmts));
                        }
                    }
                }
                var outTmps = new List<string>();  // contains a name for each non-ghost formal out-parameter
                var outTypes = new List<Type>();  // contains a type for each non-ghost formal out-parameter
                var outFormalTypes = new List<Type>(); // contains the type as it appears in the method type (possibly includes type parameters)
                var outLhsTypes = new List<Type>(); // contains the type as it appears on the LHS (may give types for those parameters)
                for (int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(2156L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(2160L, i, s.Method.Outs.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(2165L, ref i))
                {
                    Formal p = s.Method.Original.Outs[i];
                    if (!p.IsGhost)
                    {
                        string target = ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(2166L, "_out"));
                        outTmps.Add(target);
                        var instantiatedType = p.Type.Subst(s.MethodSelect.TypeArgumentSubstitutionsWithParents());
                        Type type;
                        if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(2167L, () => NeedsCastFromTypeParameter, () => IsCoercionNecessary(p.Type, instantiatedType)))
                        {
                            //
                            // The type of the parameter will differ from the LHS type in a
                            // situation like this:
                            //
                            //   method Gimmie<R(0)>() returns (r: R) { }
                            //
                            //   var a : int := Gimmie();
                            //
                            // The method Gimme will be compiled down to Go (or JavaScript)
                            // as a function which returns any value (some details omitted):
                            //
                            //   func Gimmie(ty _dafny.Type) any {
                            //     return ty.Default()
                            //   }
                            //
                            // If we naively translate, we get a type error:
                            //
                            //   var lhs int = Gimmie(_dafny.IntType) // error!
                            //
                            // Fortunately, we have the information at hand to do better.  The
                            // LHS does have the actual final type (int in this case), and the
                            // out parameter on the method tells us the compiled type
                            // returned.  Therefore what we want to do is this:
                            //
                            //   var lhs dafny.Int
                            //   var _out any
                            //
                            //   _out = Gimmie(dafny.IntType)
                            //
                            //   lhs = _out.(int) // type cast
                            //
                            // All we have to do now is declare the out variable with the type
                            // from the parameter; later we'll do the type cast.
                            //
                            // None of this is necessary if the language supports parametric
                            // functions to begin with (C#) or has dynamic typing so none of
                            // this comes up (JavaScript), so we only do this if
                            // NeedsCastFromTypeParameter is on.
                            //
                            // This used to just assign p.Type to type, but that was something of a hack
                            // that didn't work in all cases: if p.Type is indeed a type parameter,
                            // it won't be in scope on the caller side. That means you can't generally
                            // declare a local variable with that type; it happened to work for Go
                            // because it would just use interface{}, but Java would try to use the type
                            // parameter directly. The TypeForCoercion() hook was added as a place to
                            // explicitly swap in a target-language type such as java.lang.Object.
                            type = TypeForCoercion(p.Type);
                        }
                        else
                        {
                            type = instantiatedType;
                        }

                        outTypes.Add(type);
                        outFormalTypes.Add(p.Type);
                        outLhsTypes.Add(s.Lhs[i].Type);
                        DeclareLocalVar(target, type, s.Lhs[i].tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2173L, false), null, wStmts);
                    }
                }
                Contract.Assert(lvalues.Count == outTmps.Count);

                bool customReceiver = MutateCSharp.Schemata247.ReplaceBinExprOp_8(2174L, () => !(s.Method.EnclosingClass is TraitDecl), () => NeedsCustomReceiver(s.Method));
                Contract.Assert(receiverReplacement == null || !customReceiver);  // What would be done in this case? It doesn't ever happen, right?

                var returnStyleOuts = UseReturnStyleOuts(s.Method, outTmps.Count);
                var returnStyleOutCollector = MutateCSharp.Schemata247.ReplaceBinExprOp_8(2195L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_8(2189L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_4(2184L, outTmps.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(2180L, 1)), () => returnStyleOuts), () => !SupportsMultipleReturns) ? ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(2201L, "_outcollector")) : null;
                if (returnStyleOutCollector != null)
                {
                    DeclareSpecificOutCollector(returnStyleOutCollector, wr, outFormalTypes, outLhsTypes);
                }
                else if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(2211L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_4(2206L, outTmps.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(2202L, 0)), () => returnStyleOuts))
                {
                    EmitCallReturnOuts(outTmps, wr);
                }
                var wrOrig = wr;
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(2232L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_8(2226L, () => returnStyleOutCollector == null, () => MutateCSharp.Schemata247.ReplaceBinExprOp_27(2221L, outTmps.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(2217L, 1))), () => returnStyleOuts))
                {
                    var instantiatedFromType = outFormalTypes[MutateCSharp.Schemata247.ReplaceNumericConstant_3(2238L, 0)].Subst(s.MethodSelect.TypeArgumentSubstitutionsWithParents());
                    var toType = outTypes[MutateCSharp.Schemata247.ReplaceNumericConstant_3(2242L, 0)];
                    wr = EmitDowncastIfNecessary(instantiatedFromType, toType, s.Tok, wr);
                }
                var protectedName = MutateCSharp.Schemata247.ReplaceBinExprOp_8(2246L, () => receiverReplacement == null, () => customReceiver) ? CompanionMemberIdName(s.Method) : IdName(s.Method);
                if (receiverReplacement != null)
                {
                    EmitIdentifier(IdProtect(receiverReplacement), wr);
                    wr.Write(InstanceClassAccessor);
                }
                else if (customReceiver)
                {
                    EmitTypeName_Companion(s.Receiver.Type, wr, wr, s.Tok, s.Method);
                    wr.Write(StaticClassAccessor);
                }
                else if (!s.Method.IsStatic)
                {
                    wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(2252L, "("));
                    var wReceiver = wr;
                    if (s.Method.EnclosingClass is TraitDecl traitDecl && MutateCSharp.Schemata247.ReplaceBinExprOp_68(2253L, s.Receiver.Type.AsTraitType, traitDecl))
                    {
                        wReceiver = EmitCoercionIfNecessary(s.Receiver.Type, UserDefinedType.UpcastToMemberEnclosingType(s.Receiver.Type, s.Method), s.Tok, wr);
                    }
                    EmitExpr(s.Receiver, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2254L, false), wReceiver, wStmts);
                    wr.Write($"){InstanceClassAccessor}");
                }
                else if (s.Method.IsExtern(Options, out var qual, out var compileName) && qual != null)
                {
                    wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(2255L, "{0}{1}"), qual, StaticClassAccessor);
                    protectedName = compileName;
                }
                else
                {
                    EmitTypeName_Companion(s.Receiver.Type, wr, wr, s.Tok, s.Method);
                    wr.Write(StaticClassAccessor);
                }
                var typeArgs = CombineAllTypeArguments(s.Method, s.MethodSelect.TypeApplication_AtEnclosingClass, s.MethodSelect.TypeApplication_JustMember);
                EmitNameAndActualTypeArgs(protectedName, TypeArgumentInstantiation.ToActuals(ForTypeParameters(typeArgs, s.Method, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2256L, false))), s.Tok, wr);
                wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(2257L, "("));
                var sep = "";
                EmitTypeDescriptorsActuals(ForTypeDescriptors(typeArgs, s.Method.EnclosingClass, s.Method, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2258L, false)), s.Tok, wr, ref sep);
                if (customReceiver)
                {
                    wr.Write(sep);
                    var w = EmitCoercionIfNecessary(s.Receiver.Type, UserDefinedType.UpcastToMemberEnclosingType(s.Receiver.Type, s.Method), s.Tok, wr);
                    EmitExpr(s.Receiver, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2259L, false), w, wStmts);
                    sep = MutateCSharp.Schemata247.ReplaceStringConstant_2(2260L, ", ");
                }
                for (int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(2261L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(2265L, i, s.Method.Ins.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(2270L, ref i))
                {
                    Formal p = s.Method.Ins[i];
                    if (!p.IsGhost)
                    {
                        wr.Write(sep);
                        var fromType = s.Args[i].Type;
                        var toType = s.Method.Ins[i].Type;
                        var w = EmitCoercionIfNecessary(fromType, toType, s.Tok, wr);
                        var instantiatedToType = toType.Subst(s.MethodSelect.TypeArgumentSubstitutionsWithParents());
                        w = EmitDowncastIfNecessary(fromType, instantiatedToType, s.Tok, w);
                        EmitExpr(s.Args[i], MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2271L, false), w, wStmts);
                        sep = MutateCSharp.Schemata247.ReplaceStringConstant_2(2272L, ", ");
                    }
                }

                if (!returnStyleOuts)
                {
                    foreach (var outTmp in outTmps)
                    {
                        wr.Write(sep);
                        EmitActualOutArg(outTmp, wr);
                        sep = MutateCSharp.Schemata247.ReplaceStringConstant_2(2273L, ", ");
                    }
                }
                wr.Write(')');
                wr = wrOrig;
                EndStmt(wr);
                if (returnStyleOutCollector != null)
                {
                    EmitCastOutParameterSplits(returnStyleOutCollector, outTmps, wStmtsAfterCall, outFormalTypes, outTypes, s.Tok);
                }

                // assign to the actual LHSs
                for (int j = MutateCSharp.Schemata247.ReplaceNumericConstant_3(2274L, 0), l = MutateCSharp.Schemata247.ReplaceNumericConstant_3(2278L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(2282L, j, s.Method.Outs.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(2287L, ref j))
                {
                    var p = s.Method.Outs[j];
                    if (!p.IsGhost)
                    {
                        var lvalue = lvalues[l];
                        if (MutateCSharp.Schemata247.ReplaceBinExprOp_69(2288L, lvalue, null))
                        {
                            // The type information here takes care both of implicit upcasts and
                            // implicit downcasts from type parameters (see above).
                            ConcreteSyntaxTree wRhs = EmitAssignment(lvalue, s.Lhs[j].Type, outTypes[l], wStmtsAfterCall, s.Tok);
                            EmitIdentifier(outTmps[l], wRhs);
                            // Coercion from the out type to the LHS type is the responsibility
                            // of the EmitAssignment above
                        }

                        MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(2289L, ref l);
                    }
                }
            }
        }

        void TrTailCallStmt(IToken tok, Method method, Expression receiver, List<Expression> args, string receiverReplacement, ConcreteSyntaxTree wr)
        {
            Contract.Requires(tok != null);
            Contract.Requires(method != null);
            Contract.Requires(receiver != null);
            Contract.Requires(args != null);
            Contract.Requires(method.IsTailRecursive);
            Contract.Requires(wr != null);

            // assign the actual in-parameters to temporary variables
            var inTmps = new List<string>();
            var inTypes = new List<Type/*?*/>();
            if (receiverReplacement != null)
            {
                // TODO:  What to do here?  When does this happen, what does it mean?
            }
            else if (!method.IsStatic)
            {
                string inTmp = ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(2290L, "_in"));
                inTmps.Add(inTmp);
                inTypes.Add(null);
                DeclareLocalVar(inTmp, null, null, receiver, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2291L, false), wr);
            }
            for (int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(2292L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(2296L, i, method.Ins.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(2301L, ref i))
            {
                Formal p = method.Ins[i];
                if (!p.IsGhost)
                {
                    string inTmp = ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(2302L, "_in"));
                    inTmps.Add(inTmp);
                    inTypes.Add(args[i].Type);
                    DeclareLocalVar(inTmp, args[i].Type, p.tok, args[i], MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2303L, false), wr);
                }
            }
            // Now, assign to the formals
            int n = MutateCSharp.Schemata247.ReplaceNumericConstant_3(2304L, 0);
            if (!method.IsStatic)
            {
                ConcreteSyntaxTree wRHS = EmitAssignment(IdentLvalue(MutateCSharp.Schemata247.ReplaceStringConstant_2(2308L, "_this")), null, null, wr, tok);
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_49(2309L, thisContext, null))
                {
                    wRHS = wr;
                }
                else
                {
                    var instantiatedType = receiver.Type.Subst(thisContext.ParentFormalTypeParametersToActuals);

                    var contextType = UserDefinedType.FromTopLevelDecl(tok, thisContext);
                    if (contextType.ResolvedClass is ClassLikeDecl { NonNullTypeDecl: { } } cls)
                    {
                        contextType = UserDefinedType.FromTopLevelDecl(tok, cls.NonNullTypeDecl);
                    }

                    wRHS = EmitCoercionIfNecessary(instantiatedType, contextType, tok, wRHS);
                }
                EmitIdentifier(inTmps[n], wRHS);
                EndStmt(wr);
                MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(2310L, ref n);
            }
            foreach (var p in method.Ins)
            {
                if (!p.IsGhost)
                {
                    EmitIdentifier(
                      inTmps[n],
                      EmitAssignment(IdentLvalue(IdName(p)), p.Type, inTypes[n], wr, tok)
                    );
                    MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(2311L, ref n);
                }
            }
            Contract.Assert(n == inTmps.Count);
            // finally, the jump back to the head of the method
            EmitJumpToTailCallStart(wr);
        }

        protected virtual void TrStmtList(List<Statement> stmts, ConcreteSyntaxTree writer)
        {
            Contract.Requires(cce.NonNullElements(stmts));
            Contract.Requires(writer != null);
            foreach (Statement ss in stmts)
            {
                // label:        // if any
                //   <prelude>   // filled via copyInstrWriters -- copies out-parameters used in letexpr to local variables
                //   ss          // translation of ss has side effect of filling the top copyInstrWriters
                var w = writer;
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(2313L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_70(2312L, ss.Labels, null), () => !(ss is VarDeclPattern or VarDeclStmt)))
                {
                    // We are not breaking out of VarDeclPattern or VarDeclStmt, so the labels there are useless
                    // They were useful for verification
                    w = CreateLabeledCode(ss.Labels.Data.AssignUniqueId(idGenerator), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2319L, false), w);
                }
                var prelude = w.Fork();
                copyInstrWriters.Push(prelude);
                TrStmt(ss, w);
                copyInstrWriters.Pop();
            }
        }

        protected ConcreteSyntaxTree EmitContinueLabel(LList<Label> loopLabels, ConcreteSyntaxTree writer)
        {
            Contract.Requires(writer != null);
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_70(2320L, loopLabels, null))
            {
                writer = CreateLabeledCode(loopLabels.Data.AssignUniqueId(idGenerator), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2321L, true), writer);
            }
            return writer;
        }

        void TrLocalVar(IVariable v, bool alwaysInitialize, ConcreteSyntaxTree wr)
        {
            Contract.Requires(v != null);
            if (v.IsGhost)
            {
                // only emit non-ghosts (we get here only for local variables introduced implicitly by call statements)
                return;
            }
            DeclareLocalVar(IdName(v), v.Type, v.Tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2322L, false), alwaysInitialize ? PlaceboValue(v.Type, wr, v.Tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2323L, true)) : null, wr);
        }

        ConcreteSyntaxTree MatchCasePrelude(string source, UserDefinedType sourceType, DatatypeCtor ctor, List<BoundVar> arguments, int caseIndex, int caseCount, ConcreteSyntaxTree wr)
        {
            Contract.Requires(source != null);
            Contract.Requires(sourceType != null);
            Contract.Requires(ctor != null);
            Contract.Requires(cce.NonNullElements(arguments));
            Contract.Requires(0 <= caseIndex && caseIndex < caseCount);
            // if (source.is_Ctor0) {
            //   FormalType f0 = ((Dt_Ctor0)source._D).a0;
            //   ...
            var lastCase = MutateCSharp.Schemata247.ReplaceBinExprOp_27(2337L, caseIndex, MutateCSharp.Schemata247.ReplaceBinExprOp_37(2328L, caseCount, MutateCSharp.Schemata247.ReplaceNumericConstant_3(2324L, 1)));
            ConcreteSyntaxTree w;
            if (lastCase)
            {
                // Need to avoid if (true) because some languages (Go, someday Java)
                // pretend that an if (true) isn't a certainty, leading to a complaint
                // about a missing return statement
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_4(2346L, caseCount, MutateCSharp.Schemata247.ReplaceNumericConstant_3(2342L, 1)))
                {
                    w = EmitBlock(wr);
                }
                else
                {
                    w = wr;
                }
            }
            else
            {
                w = EmitIf(out var guardWriter, !lastCase, wr);
                EmitConstructorCheck(source, ctor, guardWriter);
            }

            int k = MutateCSharp.Schemata247.ReplaceNumericConstant_3(2351L, 0);  // number of processed non-ghost arguments
            for (int m = MutateCSharp.Schemata247.ReplaceNumericConstant_3(2355L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(2359L, m, ctor.Formals.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(2364L, ref m))
            {
                Formal arg = ctor.Formals[m];
                if (!arg.IsGhost)
                {
                    BoundVar bv = arguments[m];
                    // FormalType f0 = ((Dt_Ctor0)source._D).a0;
                    var sw = DeclareLocalVar(IdName(bv), bv.Type, bv.Tok, w);
                    EmitDestructor(wr => EmitIdentifier(source, wr), arg, k, ctor, SelectNonGhost(sourceType.ResolvedClass, sourceType.TypeArgs), bv.Type, sw);
                    MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(2365L, ref k);
                }
            }
            return w;
        }

        // ----- Expression ---------------------------------------------------------------------------

        /// <summary>
        /// Before calling TrParenExpr(expr), the caller must have spilled the let variables declared in "expr".
        /// </summary>
        protected void TrParenExpr(string prefix, Expression expr, ConcreteSyntaxTree wr, bool inLetExprBody, ConcreteSyntaxTree wStmts)
        {
            Contract.Requires(prefix != null);
            Contract.Requires(expr != null);
            Contract.Requires(wr != null);
            wr.Write(prefix);
            TrParenExpr(expr, wr, inLetExprBody, wStmts);
        }

        /// <summary>
        /// Before calling TrParenExpr(expr), the caller must have spilled the let variables declared in "expr".
        /// </summary>
        protected void TrParenExpr(Expression expr, ConcreteSyntaxTree wr, bool inLetExprBody, ConcreteSyntaxTree wStmts)
        {
            Contract.Requires(expr != null);
            Contract.Requires(wr != null);
            Contract.Requires(wStmts != null);
            EmitExpr(expr, inLetExprBody, wr.ForkInParens(), wStmts);
        }

        /// <summary>
        /// Before calling TrExprList(exprs), the caller must have spilled the let variables declared in expressions in "exprs".
        /// </summary>
        protected void TrExprList(List<Expression> exprs, ConcreteSyntaxTree wr, bool inLetExprBody, ConcreteSyntaxTree wStmts,
            Func<int, Type> typeAt = null, bool parens = true)
        {
            Contract.Requires(cce.NonNullElements(exprs));
            if (parens) { wr = wr.ForkInParens(); }

            wr.Comma(exprs, (e, index) =>
            {
                ConcreteSyntaxTree w;
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_71(2366L, typeAt, null))
                {
                    w = wr.Fork();
                    w = EmitCoercionIfNecessary(e.Type, typeAt(index), e.tok, w);
                }
                else
                {
                    w = wr;
                }
                EmitExpr(e, inLetExprBody, w, wStmts);
            });
        }

        protected virtual void WriteCast(string s, ConcreteSyntaxTree wr) { }

        protected ConcreteSyntaxTree CoercedExpr(Expression expr, Type toType, bool inLetExprBody, ConcreteSyntaxTree wStmts)
        {
            var result = new ConcreteSyntaxTree();
            var w = EmitCoercionIfNecessary(expr.Type, toType, expr.tok, result);
            EmitExpr(expr, inLetExprBody, w, wStmts);
            return result;
        }

        protected virtual void EmitIdentifier(string ident, ConcreteSyntaxTree wr)
        {
            wr.Write(ident);
        }

        public virtual ConcreteSyntaxTree Expr(Expression expr, bool inLetExprBody, ConcreteSyntaxTree wStmts)
        {
            var result = new ConcreteSyntaxTree();
            EmitExpr(expr, inLetExprBody, result, wStmts);
            return result;
        }

        public virtual void EmitExpr(Expression expr, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (expr is LiteralExpr)
            {
                LiteralExpr e = (LiteralExpr)expr;
                EmitLiteralExpr(wr, e);

            }
            else if (expr is ThisExpr)
            {
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_35(2367L, thisContext, null))
                {
                    var instantiatedType = expr.Type.Subst(thisContext.ParentFormalTypeParametersToActuals);
                    var contextType = UserDefinedType.FromTopLevelDecl(expr.tok, thisContext);
                    if (contextType.ResolvedClass is ClassLikeDecl { NonNullTypeDecl: { } } cls)
                    {
                        contextType = UserDefinedType.FromTopLevelDecl(expr.tok, cls.NonNullTypeDecl);
                    }

                    wr = EmitCoercionIfNecessary(contextType, instantiatedType, expr.tok, wr);
                }
                EmitThis(wr);

            }
            else if (expr is IdentifierExpr)
            {
                var e = (IdentifierExpr)expr;
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(2368L, () => inLetExprBody, () => !(e.Var is BoundVar)))
                {
                    // copy variable to a temp since
                    //   - C# doesn't allow out param in letExpr body, and
                    //   - Java doesn't allow any non-final variable in letExpr body.
                    var name = ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(2374L, "_pat_let_tv"));
                    EmitIdentifier(name, wr);
                    DeclareLocalVar(name, null, null, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2375L, false), IdName(e.Var), copyInstrWriters.Peek(), e.Type);
                }
                else
                {
                    EmitIdentifier(IdName(e.Var), wr);
                }
            }
            else if (expr is SetDisplayExpr)
            {
                var e = (SetDisplayExpr)expr;
                EmitCollectionDisplay(e.Type.NormalizeToAncestorType().AsSetType, e.tok, e.Elements, inLetExprBody, wr, wStmts);

            }
            else if (expr is MultiSetDisplayExpr)
            {
                var e = (MultiSetDisplayExpr)expr;
                EmitCollectionDisplay(e.Type.NormalizeToAncestorType().AsMultiSetType, e.tok, e.Elements, inLetExprBody, wr, wStmts);

            }
            else if (expr is SeqDisplayExpr)
            {
                var e = (SeqDisplayExpr)expr;
                EmitCollectionDisplay(e.Type.NormalizeToAncestorType().AsSeqType, e.tok, e.Elements, inLetExprBody, wr, wStmts);

            }
            else if (expr is MapDisplayExpr)
            {
                var e = (MapDisplayExpr)expr;
                EmitMapDisplay(e.Type.NormalizeToAncestorType().AsMapType, e.tok, e.Elements, inLetExprBody, wr, wStmts);

            }
            else if (expr is MemberSelectExpr)
            {
                MemberSelectExpr e = (MemberSelectExpr)expr;
                SpecialField sf = e.Member as SpecialField;
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_72(2376L, sf, null))
                {
                    GetSpecialFieldInfo(sf.SpecialId, sf.IdParam, e.Obj.Type, out var compiledName, out var preStr, out var postStr);
                    wr.Write(preStr);

                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(2392L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_8(2377L, () => sf.IsStatic, () => !SupportsStaticsInGenericClasses), () => MutateCSharp.Schemata247.ReplaceBinExprOp_21(2387L, sf.EnclosingClass.TypeArgs.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(2383L, 0))))
                    {
                        var typeArgs = e.TypeApplication_AtEnclosingClass;
                        Contract.Assert(typeArgs.Count == sf.EnclosingClass.TypeArgs.Count);
                        wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(2398L, "{0}."), TypeName_Companion(e.Obj.Type, wr, e.tok, sf));
                        EmitNameAndActualTypeArgs(IdName(e.Member), typeArgs, e.tok, wr);
                        var tas = TypeArgumentInstantiation.ListFromClass(sf.EnclosingClass, typeArgs);
                        EmitTypeDescriptorsActuals(tas, e.tok, wr.ForkInParens());
                    }
                    else
                    {
                        void writeObj(ConcreteSyntaxTree w)
                        {
                            //Contract.Assert(!sf.IsStatic);
                            w = EmitCoercionIfNecessary(e.Obj.Type, UserDefinedType.UpcastToMemberEnclosingType(e.Obj.Type, e.Member), e.tok, w);
                            TrParenExpr(e.Obj, w, inLetExprBody, wStmts);
                        }

                        var typeArgs = CombineAllTypeArguments(e.Member, e.TypeApplication_AtEnclosingClass, e.TypeApplication_JustMember);
                        EmitMemberSelect(writeObj, e.Obj.Type, e.Member, typeArgs, e.TypeArgumentSubstitutionsWithParents(), expr.Type).EmitRead(wr);
                    }

                    wr.Write(postStr);
                }
                else
                {
                    var typeArgs = CombineAllTypeArguments(e.Member, e.TypeApplication_AtEnclosingClass, e.TypeApplication_JustMember);
                    var typeMap = e.TypeArgumentSubstitutionsWithParents();
                    var customReceiver = MutateCSharp.Schemata247.ReplaceBinExprOp_8(2399L, () => NeedsCustomReceiver(e.Member), () => !(e.Member.EnclosingClass is TraitDecl));
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(2405L, () => !customReceiver, () => !e.Member.IsStatic))
                    {
                        Action<ConcreteSyntaxTree> obj;
                        // The eta conversion here is to avoid capture of the receiver, because the call to EmitMemberSelect below may generate
                        // a lambda expression in the target language.
                        if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(2420L, () => e.Member is Function, () => MutateCSharp.Schemata247.ReplaceBinExprOp_21(2415L, typeArgs.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(2411L, 0))))
                        {
                            // need to eta-expand wrap the receiver
                            var etaReceiver = ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(2426L, "_eta_this"));
                            wr = CreateIIFE_ExprBody(etaReceiver, e.Obj.Type, e.Obj.tok, e.Obj, inLetExprBody, e.Type.Subst(typeMap), e.tok, wr, ref wStmts);
                            obj = w => EmitIdentifier(etaReceiver, w);
                        }
                        else
                        {
                            obj = w => EmitExpr(e.Obj, inLetExprBody, w, wStmts);
                        }
                        EmitMemberSelect(obj, e.Obj.Type, e.Member, typeArgs, typeMap, expr.Type).EmitRead(wr);
                    }
                    else
                    {
                        string customReceiverName = null;
                        if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(2427L, () => customReceiver, () => e.Member is Function))
                        {
                            // need to eta-expand wrap the receiver
                            customReceiverName = ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(2433L, "_eta_this"));
                            wr = CreateIIFE_ExprBody(customReceiverName, e.Obj.Type, e.Obj.tok, e.Obj, inLetExprBody, e.Type.Subst(typeMap), e.tok, wr, ref wStmts);
                        }
                        Action<ConcreteSyntaxTree> obj = w => EmitTypeName_Companion(e.Obj.Type, w, wr, e.tok, e.Member);
                        EmitMemberSelect(obj, e.Obj.Type, e.Member, typeArgs, typeMap, expr.Type, customReceiverName).EmitRead(wr);
                    }
                }
            }
            else if (expr is SeqSelectExpr)
            {
                SeqSelectExpr e = (SeqSelectExpr)expr;
                Contract.Assert(e.Seq.Type != null);
                if (e.Seq.Type.IsArrayType)
                {
                    if (e.SelectOne)
                    {
                        Contract.Assert(e.E0 != null && e.E1 == null);
                        var w = EmitArraySelect(new List<Expression>() { e.E0 }, e.Type, inLetExprBody, wr, wStmts);
                        w = EmitCoercionIfNecessary(
                          e.Seq.Type,
            MutateCSharp.Schemata247.ReplaceBinExprOp_9(2434L, () => e.Seq.Type.IsNonNullRefType, () => !e.Seq.Type.IsRefType) ? null : UserDefinedType.CreateNonNullType((UserDefinedType)e.Seq.Type.NormalizeExpand()),
                          e.tok,
                          w
                        );
                        TrParenExpr(e.Seq, w, inLetExprBody, wStmts);
                    }
                    else
                    {
                        EmitSeqSelectRange(e.Seq, e.E0, e.E1, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2440L, true), inLetExprBody, wr, wStmts);
                    }
                }
                else if (e.SelectOne)
                {
                    Contract.Assert(e.E0 != null && e.E1 == null);
                    EmitIndexCollectionSelect(e.Seq, e.E0, inLetExprBody, wr, wStmts);
                }
                else
                {
                    EmitSeqSelectRange(e.Seq, e.E0, e.E1, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2441L, false), inLetExprBody, wr, wStmts);
                }
            }
            else if (expr is SeqConstructionExpr)
            {
                var e = (SeqConstructionExpr)expr;
                EmitSeqConstructionExpr(e, inLetExprBody, wr, wStmts);
            }
            else if (expr is MultiSetFormingExpr)
            {
                var e = (MultiSetFormingExpr)expr;
                EmitMultiSetFormingExpr(e, inLetExprBody, wr, wStmts);
            }
            else if (expr is MultiSelectExpr)
            {
                MultiSelectExpr e = (MultiSelectExpr)expr;
                WriteCast(TypeName(e.Type.NormalizeExpand(), wr, e.tok), wr);
                var w = EmitArraySelect(e.Indices, e.Type, inLetExprBody, wr, wStmts);
                TrParenExpr(e.Array, w, inLetExprBody, wStmts);

            }
            else if (expr is SeqUpdateExpr)
            {
                SeqUpdateExpr e = (SeqUpdateExpr)expr;
                var collectionType = e.Type.NormalizeToAncestorType().AsCollectionType;
                Contract.Assert(collectionType != null);
                EmitIndexCollectionUpdate(e.Seq, e.Index, e.Value, collectionType, inLetExprBody, wr, wStmts);
            }
            else if (expr is DatatypeUpdateExpr)
            {
                var e = (DatatypeUpdateExpr)expr;
                if (e.Members.All(member => member.IsGhost))
                {
                    // all fields to be updated are ghost, which doesn't change the value
                    EmitExpr(e.Root, inLetExprBody, wr, wStmts);
                    return;
                }
                if (DatatypeWrapperEraser.IsErasableDatatypeWrapper(Options, e.Root.Type.AsDatatype, out var dtor))
                {
                    var i = e.Members.IndexOf(dtor);
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_58(2446L, MutateCSharp.Schemata247.ReplaceNumericConstant_3(2442L, 0), i))
                    {
                        // the datatype is an erasable wrapper and its core destructor is part of the update (which implies everything else must be a ghost),
                        // so proceed as with the rhs
                        Contract.Assert(Enumerable.Range(0, e.Members.Count).All(j => j == i || e.Members[j].IsGhost));
                        Contract.Assert(e.Members.Count == e.Updates.Count);
                        var rhs = e.Updates[i].Item3;
                        EmitExpr(rhs, inLetExprBody, wr, wStmts);
                        return;
                    }
                }
                // the optimized cases don't apply, so proceed according to the desugaring
                EmitExpr(e.ResolvedExpression, inLetExprBody, wr, wStmts);
            }
            else if (expr is FunctionCallExpr)
            {
                FunctionCallExpr e = (FunctionCallExpr)expr;

                void EmitExpr(Expression e2, ConcreteSyntaxTree wr2, bool inLetExpr, ConcreteSyntaxTree wStmts2)
                {
                    this.EmitExpr(e2, inLetExpr, wr2, wStmts2);
                }

                if (e.Function is SpecialFunction)
                {
                    CompileSpecialFunctionCallExpr(e, wr, inLetExprBody, wStmts, EmitExpr);
                }
                else
                {
                    CompileFunctionCallExpr(e, wr, inLetExprBody, wStmts, EmitExpr);
                }

            }
            else if (expr is ApplyExpr)
            {
                var e = expr as ApplyExpr;
                EmitApplyExpr(e.Function.Type, e.tok, e.Function, e.Args, inLetExprBody, wr, wStmts);

            }
            else if (expr is DatatypeValue)
            {
                var dtv = (DatatypeValue)expr;
                Contract.Assert(dtv.Ctor != null);  // since dtv has been successfully resolved

                if (DatatypeWrapperEraser.IsErasableDatatypeWrapper(Options, dtv.Ctor.EnclosingDatatype, out var dtor))
                {
                    var i = dtv.Ctor.Destructors.IndexOf(dtor);
                    Contract.Assert(0 <= i);
                    EmitExpr(dtv.Arguments[i], inLetExprBody, wr, wStmts);
                    return;
                }

                var wrArgumentList = new ConcreteSyntaxTree();
                var wTypeDescriptorArguments = new ConcreteSyntaxTree();
                var typeSubst = TypeParameter.SubstitutionMap(dtv.Ctor.EnclosingDatatype.TypeArgs, dtv.InferredTypeArgs);
                string sep = "";
                Contract.Assert(dtv.Ctor.EnclosingDatatype.TypeArgs.Count == dtv.InferredTypeArgs.Count);
                WriteTypeDescriptors(dtv.Ctor.EnclosingDatatype, dtv.InferredTypeArgs, wTypeDescriptorArguments, ref sep);
                sep = "";
                for (var i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(2451L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(2455L, i, dtv.Arguments.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(2460L, ref i))
                {
                    var formal = dtv.Ctor.Formals[i];
                    if (!formal.IsGhost)
                    {
                        wrArgumentList.Write(sep);
                        var w = EmitCoercionIfNecessary(@from: dtv.Arguments[i].Type, to: dtv.Ctor.Formals[i].Type.Subst(typeSubst), toOrig: dtv.Ctor.Formals[i].Type, tok: dtv.tok, wr: wrArgumentList);
                        EmitExpr(dtv.Arguments[i], inLetExprBody, w, wStmts);
                        sep = MutateCSharp.Schemata247.ReplaceStringConstant_2(2461L, ", ");
                    }
                }
                EmitDatatypeValue(dtv, wTypeDescriptorArguments.ToString(), wrArgumentList.ToString(), wr);

            }
            else if (expr is OldExpr)
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // 'old' is always a ghost

            }
            else if (expr is UnaryOpExpr)
            {
                var e = (UnaryOpExpr)expr;
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_73(2462L, e.ResolvedOp, UnaryOpExpr.ResolvedOpcode.BVNot))
                {
                    wr = EmitBitvectorTruncation(e.Type.NormalizeToAncestorType().AsBitVectorType, e.Type.AsNativeType(), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2463L, true), wr);
                }
                EmitUnaryExpr(UnaryOpCodeMap[e.ResolvedOp], e.E, inLetExprBody, wr, wStmts);
            }
            else if (expr is ConversionExpr)
            {
                var e = (ConversionExpr)expr;
                var fromType = e.E.Type.GetRuntimeType();
                var toType = e.ToType.GetRuntimeType();
                Contract.Assert(Options.Get(CommonOptionBag.GeneralTraits) != CommonOptionBag.GeneralTraitsOptions.Legacy || toType.IsRefType == fromType.IsRefType);
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_9(2470L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_9(2464L, () => toType.IsRefType, () => toType.IsTraitType), () => fromType.IsTraitType))
                {
                    var w = EmitCoercionIfNecessary(e.E.Type, e.ToType, e.tok, wr);
                    w = EmitDowncastIfNecessary(e.E.Type, e.ToType, e.tok, w);
                    EmitExpr(e.E, inLetExprBody, w, wStmts);
                }
                else
                {
                    EmitConversionExpr(e.E, fromType, toType, inLetExprBody, wr, wStmts);
                }

            }
            else if (expr is TypeTestExpr typeTestExpr)
            {
                CompileTypeTest(typeTestExpr, inLetExprBody, wr, ref wStmts);

            }
            else if (expr is BinaryExpr)
            {
                var e = (BinaryExpr)expr;

                if (IsComparisonToZero(e, out var arg, out var sign, out var negated) &&
                    CompareZeroUsingSign(arg.Type))
                {
                    // Transform e.g. x < BigInteger.Zero into x.Sign == -1
                    var w = EmitSign(arg.Type, wr);
                    TrParenExpr(arg, w, inLetExprBody, wStmts);
                    wr.Write(negated ? MutateCSharp.Schemata247.ReplaceStringConstant_2(2476L, " != ") : MutateCSharp.Schemata247.ReplaceStringConstant_2(2477L, " == "));
                    wr.Write(sign.ToString());
                }
                else
                {
                    CompileBinOp(e.ResolvedOp, e.E0, e.E1, e.tok, expr.Type.GetRuntimeType(),
                      out var opString,
                      out var preOpString,
                      out var postOpString,
                      out var callString,
                      out var staticCallString,
                      out var reverseArguments,
                      out var truncateResult,
                      out var convertE1_to_int,
                      out var coerceE1,
                      wr);

                    if (truncateResult && e.Type.NormalizeToAncestorType().AsBitVectorType is { } bitvectorType)
                    {
                        wr = EmitBitvectorTruncation(bitvectorType, e.Type.AsNativeType(), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2478L, true), wr);
                    }
                    var e0 = reverseArguments ? e.E1 : e.E0;
                    var e1 = reverseArguments ? e.E0 : e.E1;

                    var left = Expr(e0, inLetExprBody, wStmts);
                    ConcreteSyntaxTree right;
                    if (convertE1_to_int)
                    {
                        right = ExprAsNativeInt(e1, inLetExprBody, wStmts);
                    }
                    else
                    {
                        right = Expr(e1, inLetExprBody, wStmts);
                        if (coerceE1)
                        {
                            right = CoercionIfNecessary(e1.Type, TypeForCoercion(e1.Type), e1.tok, right);
                        }
                    }

                    wr.Write(preOpString);
                    if (opString != null)
                    {
                        var nativeType = AsNativeType(e.Type);
                        string nativeName = null;
                        bool needsCast = MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2479L, false);
                        if (MutateCSharp.Schemata247.ReplaceBinExprOp_25(2480L, nativeType, null))
                        {
                            GetNativeInfo(nativeType.Sel, out nativeName, out _, out needsCast);
                        }

                        var opResult = ConcreteSyntaxTree.Create($"{left.InParens()} {opString} {right.InParens()}");
                        if (needsCast)
                        {
                            opResult = Cast(new LineSegment(nativeName), opResult);
                        }

                        wr.Append(opResult);
                    }
                    else if (callString != null)
                    {
                        wr.Format($"{left.InParens()}.{callString}({right})");
                    }
                    else if (staticCallString != null)
                    {
                        wr.Format($"{staticCallString}({left}, {right})");
                    }
                    wr.Write(postOpString);
                }
            }
            else if (expr is TernaryExpr)
            {
                Contract.Assume(false);  // currently, none of the ternary expressions is compilable

            }
            else if (expr is LetExpr)
            {
                var e = (LetExpr)expr;
                if (e.Exact)
                {
                    // The Dafny "let" expression
                    //    var Pattern(x,y) := G; E
                    // is translated into C# as:
                    //    LamLet(G, tmp =>
                    //      LamLet(dtorX(tmp), x =>
                    //      LamLet(dtorY(tmp), y => E)))
                    Contract.Assert(e.LHSs.Count == e.RHSs.Count);  // checked by resolution
                    var w = wr;
                    for (int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(2481L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(2485L, i, e.LHSs.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(2490L, ref i))
                    {
                        var lhs = e.LHSs[i];
                        if (Contract.Exists(lhs.Vars, bv => !bv.IsGhost))
                        {
                            var rhsName = $"_pat_let{GetUniqueAstNumber(e)}_{i}";
                            w = CreateIIFE_ExprBody(rhsName, e.RHSs[i].Type, e.RHSs[i].tok, e.RHSs[i], inLetExprBody, e.Body.Type, e.Body.tok, w, ref wStmts);
                            w = TrCasePattern(lhs, wr => EmitIdentifier(rhsName, wr), e.RHSs[i].Type, e.Body.Type, w, ref wStmts);
                        }
                    }
                    EmitExpr(e.Body, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2491L, true), w, wStmts);
                }
                else if (e.BoundVars.All(bv => bv.IsGhost))
                {
                    // The Dafny "let" expression
                    //    ghost var x,y :| Constraint; E
                    // is compiled just like E is, because the resolver has already checked that x,y (or other ghost variables, for that matter) don't
                    // occur in E (moreover, the verifier has checked that values for x,y satisfying Constraint exist).
                    EmitExpr(e.Body, inLetExprBody, wr, wStmts);
                }
                else
                {
                    // The Dafny "let" expression
                    //    var x,y :| Constraint; E
                    // is translated into C# as:
                    //    LamLet(0, dummy => {  // the only purpose of this construction here is to allow us to add some code inside an expression in C#
                    //        var x,y;
                    //        // Embark on computation that fills in x,y according to Constraint; the computation stops when the first
                    //        // such value is found, but since the verifier checks that x,y follows uniquely from Constraint, this is
                    //        // not a source of nondeterminancy.
                    //        return E;
                    //      })
                    Contract.Assert(e.RHSs.Count == 1);  // checked by resolution
                    var missingBounds = BoolBoundedPool.MissingBounds(e.BoundVars.ToList<BoundVar>(), e.Constraint_Bounds, BoundedPool.PoolVirtues.Enumerable);
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_21(2496L, missingBounds.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(2492L, 0)))
                    {
                        foreach (var bv in missingBounds)
                        {
                            Error(ErrorId.c_let_such_that_is_too_complex, e.tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(2501L, "this let-such-that expression is too advanced for the current compiler; Dafny's heuristics cannot find any bound for variable '{0}'"), wr, bv.Name);
                        }
                    }
                    else
                    {
                        var w = CreateIIFE1(MutateCSharp.Schemata247.ReplaceNumericConstant_3(2502L, 0), e.Body.Type, e.Body.tok, MutateCSharp.Schemata247.ReplaceStringConstant_2(2506L, "_let_dummy_") + GetUniqueAstNumber(e), wr, wStmts);
                        foreach (var bv in e.BoundVars)
                        {
                            DeclareLocalVar(IdName(bv), bv.Type, bv.tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2507L, false), ForcePlaceboValue(bv.Type, wr, bv.tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2508L, true)), w);
                        }
                        TrAssignSuchThat(new List<IVariable>(e.BoundVars).ConvertAll(bv => (IVariable)bv), e.RHSs[MutateCSharp.Schemata247.ReplaceNumericConstant_3(2509L, 0)], e.Constraint_Bounds, e.tok.line, w, inLetExprBody);
                        EmitReturnExpr(e.Body, e.Body.Type, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2513L, true), w);
                    }
                }
            }
            else if (expr is NestedMatchExpr nestedMatchExpr)
            {
                EmitExpr(nestedMatchExpr.Flattened, inLetExprBody, wr, wStmts);
            }
            else if (expr is MatchExpr)
            {
                var e = (MatchExpr)expr;
                // ((System.Func<SourceType, TargetType>)((SourceType _source) => {
                //   if (source.is_Ctor0) {
                //     FormalType f0 = ((Dt_Ctor0)source._D).a0;
                //     ...
                //     return Body0;
                //   } else if (...) {
                //     ...
                //   } else if (true) {
                //     ...
                //   }
                // }))(src)

                EmitLambdaApply(wr, out var wLambda, out var wArg);

                string source = ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(2514L, "_source"));
                ConcreteSyntaxTree w;
                w = CreateLambda(new List<Type>() { e.Source.Type }, e.tok, new List<string>() { source }, e.Type, wLambda, wStmts);

                if (MutateCSharp.Schemata247.ReplaceBinExprOp_27(2519L, e.Cases.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(2515L, 0)))
                {
                    // the verifier would have proved we never get here; still, we need some code that will compile
                    EmitAbsurd(null, w);
                }
                else
                {
                    int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(2524L, 0);
                    var sourceType = (UserDefinedType)e.Source.Type.NormalizeExpand();
                    foreach (MatchCaseExpr mc in e.Cases)
                    {
                        var wCase = MatchCasePrelude(source, sourceType, mc.Ctor, mc.Arguments, i, e.Cases.Count, w);
                        TrExprOpt(mc.Body, mc.Body.Type, wCase, wStmts, inLetExprBody: MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2528L, true), accumulatorVar: null);
                        MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(2529L, ref i);
                    }
                }
                // We end with applying the source expression to the delegate we just built
                EmitExpr(e.Source, inLetExprBody, wArg, wStmts);

            }
            else if (expr is QuantifierExpr)
            {
                var e = (QuantifierExpr)expr;

                // Compilation does not check whether a quantifier was split.

                wr = CaptureFreeVariables(expr, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2530L, true), out var su, inLetExprBody, wr, ref wStmts);
                var logicalBody = su.Substitute(e.LogicalBody(MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2531L, true)));

                Contract.Assert(e.Bounds != null);  // for non-ghost quantifiers, the resolver would have insisted on finding bounds
                var n = e.BoundVars.Count;
                Contract.Assert(e.Bounds.Count == n);
                var wBody = wr;
                for (int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(2532L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(2536L, i, n); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(2541L, ref i))
                {
                    var bound = e.Bounds[i];
                    var bv = e.BoundVars[i];

                    var collectionElementType = CompileCollection(bound, bv, inLetExprBody, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2542L, false), su, out var collection, wStmts, e.Bounds, e.BoundVars, i);
                    wBody = EmitQuantifierExpr(collection, expr is ForallExpr, collectionElementType, bv, wBody);
                    var native = AsNativeType(e.BoundVars[i].Type);
                    var tmpVarName = ProtectedFreshId(e is ForallExpr ? MutateCSharp.Schemata247.ReplaceStringConstant_2(2543L, "_forall_var_") : MutateCSharp.Schemata247.ReplaceStringConstant_2(2544L, "_exists_var_"));
                    ConcreteSyntaxTree newWBody = CreateLambda(new List<Type> { collectionElementType }, e.tok, new List<string> { tmpVarName }, Type.Bool, wBody, wStmts, untyped: MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2545L, true));
                    wStmts = newWBody.Fork();
                    newWBody = MaybeInjectSubtypeConstraintWrtTraits(
                      tmpVarName, collectionElementType, bv.Type,
                      inLetExprBody, e.tok, newWBody, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2546L, true), e is ForallExpr);
                    EmitDowncastVariableAssignment(
                      IdName(bv), bv.Type, tmpVarName, collectionElementType, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2547L, true), e.tok, newWBody);
                    newWBody = MaybeInjectSubsetConstraint(
                      bv, bv.Type, inLetExprBody, e.tok, newWBody, isReturning: MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2548L, true), elseReturnValue: e is ForallExpr);
                    wBody = newWBody;
                }
                EmitExpr(logicalBody, inLetExprBody, wBody, wStmts);

            }
            else if (expr is SetComprehension)
            {
                var e = (SetComprehension)expr;
                // For "set i,j,k,l | R(i,j,k,l) :: Term(i,j,k,l)" where the term has type "G", emit something like:
                // ((System.Func<Set<G>>)(() => {
                //   var _coll = new List<G>();
                //   foreach (var tmp_l in sq.Elements) { L l = (L)tmp_l;
                //     foreach (var tmp_k in st.Elements) { K k = (K)tmp_k;
                //       for (BigInteger j = Lo; j < Hi; j++) {
                //         for (bool i in Helper.AllBooleans) {
                //           if (R(i,j,k,l)) {
                //             _coll.Add(Term(i,j,k,l));
                //           }
                //         }
                //       }
                //     }
                //   }
                //   return Dafny.Set<G>.FromCollection(_coll);
                // }))()
                wr = CaptureFreeVariables(e, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2549L, true), out var su, inLetExprBody, wr, ref wStmts);
                e = (SetComprehension)su.Substitute(e);

                Contract.Assert(e.Bounds != null);  // the resolver would have insisted on finding bounds
                var collectionName = ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(2550L, "_coll"));
                var setType = e.Type.NormalizeToAncestorType().AsSetType;
                var bwr = CreateIIFE0(setType, e.tok, wr, wStmts);
                wStmts = bwr.Fork();
                wr = bwr;
                EmitSetBuilder_New(wr, e, collectionName);
                var n = e.BoundVars.Count;
                Contract.Assert(e.Bounds.Count == n);
                for (var i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(2551L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(2555L, i, n); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(2560L, ref i))
                {
                    var bound = e.Bounds[i];
                    var bv = e.BoundVars[i];
                    var tmpVar = ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(2561L, "_compr_"));
                    var wStmtsLoop = wr.Fork();
                    var elementType = CompileCollection(bound, bv, inLetExprBody, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2562L, true), null, out var collection, wStmtsLoop);
                    wr = CreateGuardedForeachLoop(tmpVar, elementType, bv, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2563L, true), inLetExprBody, e.tok, collection, wr);
                }

                var thn = EmitIf(out var guardWriter, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2564L, false), wr);
                EmitExpr(e.Range, inLetExprBody, guardWriter, wStmts);
                EmitSetBuilder_Add(setType, collectionName, e.Term, inLetExprBody, thn);
                var returned = EmitReturnExpr(bwr);
                GetCollectionBuilder_Build(setType, e.tok, collectionName, returned, wStmts);

            }
            else if (expr is MapComprehension)
            {
                var e = (MapComprehension)expr;
                // For "map i | R(i) :: Term(i)" where the term has type "V" and i has type "U", emit something like:
                // ((System.Func<Map<U, V>>)(() => {
                //   var _coll = new List<Pair<U,V>>();
                //   foreach (L l in sq.Elements) {
                //     foreach (K k in st.Elements) {
                //       for (BigInteger j = Lo; j < Hi; j++) {
                //         for (bool i in Helper.AllBooleans) {
                //           if (R(i,j,k,l)) {
                //             _coll.Add(new Pair(i, Term(i));
                //           }
                //         }
                //       }
                //     }
                //   }
                //   return Dafny.Map<U, V>.FromCollection(_coll);
                // }))()
                wr = CaptureFreeVariables(e, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2565L, true), out var su, inLetExprBody, wr, ref wStmts);
                e = (MapComprehension)su.Substitute(e);

                Contract.Assert(e.Bounds != null);  // the resolver would have insisted on finding bounds
                var mapType = e.Type.NormalizeToAncestorType().AsMapType;
                var domtypeName = TypeName(mapType.Domain, wr, e.tok);
                var rantypeName = TypeName(mapType.Range, wr, e.tok);
                var collection_name = ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(2566L, "_coll"));
                var bwr = CreateIIFE0(mapType, e.tok, wr, wStmts);
                wStmts = bwr.Fork();
                wr = bwr;
                EmitMapBuilder_New(wr, e, collection_name);
                var n = e.BoundVars.Count;
                Contract.Assert(e.Bounds.Count == n);
                for (var i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(2567L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(2571L, i, n); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(2576L, ref i))
                {
                    var bound = e.Bounds[i];
                    var bv = e.BoundVars[i];
                    var tmpVar = ProtectedFreshId(MutateCSharp.Schemata247.ReplaceStringConstant_2(2577L, "_compr_"));
                    var wStmtsLoop = wr.Fork();
                    var elementType = CompileCollection(bound, bv, inLetExprBody, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2578L, true), null, out var collection, wStmtsLoop);
                    wr = CreateGuardedForeachLoop(tmpVar, elementType, bv, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2579L, true), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2580L, false), bv.tok, collection, wr);
                }

                var thn = EmitIf(out var guardWriter, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2581L, false), wr);
                EmitExpr(e.Range, inLetExprBody, guardWriter, wStmts);
                var termLeftWriter = EmitMapBuilder_Add(mapType, e.tok, collection_name, e.Term, inLetExprBody, thn);
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_38(2582L, e.TermLeft, null))
                {
                    Contract.Assert(e.BoundVars.Count == 1);
                    EmitIdentifier(IdName(e.BoundVars[MutateCSharp.Schemata247.ReplaceNumericConstant_3(2583L, 0)]), termLeftWriter);
                }
                else
                {
                    EmitExpr(e.TermLeft, inLetExprBody, termLeftWriter, wStmts);
                }

                var returned = EmitReturnExpr(bwr);
                GetCollectionBuilder_Build(mapType, e.tok, collection_name, returned, wStmts);

            }
            else if (expr is LambdaExpr)
            {
                var e = (LambdaExpr)expr;

                wr = CaptureFreeVariables(e, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2587L, false), out var su, inLetExprBody, wr, ref wStmts);
                wr = CreateLambda(e.BoundVars.ConvertAll(bv => bv.Type), Token.NoToken, e.BoundVars.ConvertAll(IdName), e.Body.Type, wr, wStmts);
                wStmts = wr.Fork();
                wr = EmitReturnExpr(wr);
                // May need an upcast or boxing conversion to coerce to the generic arrow result type
                wr = EmitCoercionIfNecessary(e.Body.Type, TypeForCoercion(e.Type.AsArrowType.Result), e.Body.tok, wr);
                EmitExpr(su.Substitute(e.Body), inLetExprBody, wr, wStmts);

            }
            else if (expr is StmtExpr)
            {
                var e = (StmtExpr)expr;
                EmitExpr(e.E, inLetExprBody, wr, wStmts);

            }
            else if (expr is ITEExpr)
            {
                var e = (ITEExpr)expr;
                // The ghost-ITE optimization applies only to at "the top" of the expression structure of a function
                // body. Those cases are handled in TrExprOpt, so we expect the be compiling both branches here.
                Contract.Assert(e.HowToCompile == ITEExpr.ITECompilation.CompileBothBranches);
                EmitITE(e.Test, e.Thn, e.Els, e.Type, inLetExprBody, wr, wStmts);

            }
            else if (expr is ConcreteSyntaxExpression)
            {
                var e = (ConcreteSyntaxExpression)expr;
                EmitExpr(e.ResolvedExpression, inLetExprBody, wr, wStmts);

            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected expression
            }
        }

        private void CompileTypeTest(TypeTestExpr expr, bool inLetExprBody, ConcreteSyntaxTree wr, ref ConcreteSyntaxTree wStmts)
        {
            var fromType = expr.E.Type;
            if (fromType.IsSubtypeOf(expr.ToType, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2588L, false), MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2589L, false)))
            {
                // This is a special case; no checks need to be done
                EmitExpr(Expression.CreateBoolLiteral(expr.tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2590L, true)), inLetExprBody, wr, wStmts);
                return;
            }

            var toType = expr.ToType;
            var from = expr.E;

            // The "is" check consists of two parts. First, check that "expr.E" can be represented in the target representation of
            // "expr.ToType". Then, check that the constraints of "expr.ToType" are satisfied by "expr.E as expr.ToType". Note that
            // this "expr.E as expr.ToType" does a conversion to the target representation of "expr.ToType", even if the value so
            // produced does not satisfy the constraint of an "expr.ToType"; but this representation conversion has to be done before
            // the "_Is" can be called.

            // In the following, "ancestor of T" for a type "T" refers to the normalized (that is, following type proxies), expanded
            // (that is, following type synonyms and subset types), and newtype-trimmed (that is, following newtypes) base type of T.
            // "Ancestor" does not follow to trait parents.
            //
            // If the ancestor of "fromType" is a trait or a reference type, then:
            //   0. Check if "from" is of the ancestor type of "toType".
            //      Notes:
            //       a) Suppose "toType" is "C<X, Y>". Then, because of Dafny's injectivity requirement, this can be done by checking
            //          if "from" is of some type "C<_, _>". That is, there is no need to check the type arguments "X" and "Y".
            //       b) "C" can be a trait, a class, a datatype/codatatype, or (when supported by --general-traits=full) a newtype.
            //       c) In the target language, this test is typically done by an operation like "instanceof". In most cases, the test
            //          can be done by "from instanceof C", but if "toType" is a reference type, then the test needs to be
            //          "from == null || from instanceof C". However, the "from == null" disjunct can still be omitted if
            //            -- "fromType" is a non-null reference type, or
            //            -- "instanceof" in already checks non-nullness and "toType" is a non-null reference type.
            //   1. Check that the subset-type constraints of "toType" (from "toType.NormalizeExpand()" to "toType" -- there is no need
            //      to check any newtype constraints that "toType.NormalizeExpand()" may have, since those are effectively checked already
            //      by the "instanceof" check performed in step (0)) hold of "from as toType.NormalizeExpand()".
            //      Notes:
            //        - The constraint of a non-null reference type can be omitted in some cases, see note (c) above.
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_9(2591L, () => fromType.IsTraitType, () => fromType.IsRefType))
            {
                var name = $"_is_{GetUniqueAstNumber(expr)}";
                wr = CreateIIFE_ExprBody(name, fromType, expr.tok, expr.E, inLetExprBody, Type.Bool, expr.tok, wr, ref wStmts);
                EmitTypeTest(name, fromType, expr.ToType, expr.tok, wr);
                return;
            }

            var needsIntegralCheck = MutateCSharp.Schemata247.ReplaceBinExprOp_8(2597L, () => fromType.IsNumericBased(Type.NumericPersuasion.Real), () => !toType.IsNumericBased(Type.NumericPersuasion.Real));
            var needsCharCheck = MutateCSharp.Schemata247.ReplaceBinExprOp_8(2603L, () => fromType.NormalizeToAncestorType() is not CharType, () => toType.NormalizeToAncestorType() is CharType);
            var needsRangeCheck =
              (toType.NormalizeToAncestorType().AsBitVectorType is { } toBitvectorType &&
               (fromType.NormalizeExpandKeepConstraints().AsBitVectorType is not { } fromBitvectorType ||
                toBitvectorType.Width < fromBitvectorType.Width)) ||
              (MutateCSharp.Schemata247.ReplaceBinExprOp_8(2611L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_25(2609L, toType.AsNativeType(), null), () => MutateCSharp.Schemata247.ReplaceBinExprOp_74(2610L, fromType.AsNativeType()?.Sel, toType.AsNativeType().Sel)));

            if (MutateCSharp.Schemata247.ReplaceBinExprOp_9(2623L, () => MutateCSharp.Schemata247.ReplaceBinExprOp_9(2617L, () => needsIntegralCheck, () => needsCharCheck), () => needsRangeCheck))
            {
                // Introduce a name for "from", to make sure "from" is computed just once
                var boundVariableDecl = new BoundVar(from.tok, $"_is_{GetUniqueAstNumber(from)}", fromType);
                var name = IdName(boundVariableDecl);
                wr = CreateIIFE_ExprBody(name, fromType, expr.tok, expr.E, inLetExprBody, Type.Bool, expr.tok, wr, ref wStmts);
                from = new IdentifierExpr(boundVariableDecl.tok, boundVariableDecl);
            }

            if (needsIntegralCheck)
            {
                EmitIsIntegerTest(from, wr, wStmts);
                from = new ConversionExpr(from.tok, from, Type.Int) { Type = Type.Int };
            }

            if (needsCharCheck)
            {
                var fromAsInt = new ConversionExpr(from.tok, from, Type.Int) { Type = Type.Int };
                if (UnicodeCharEnabled)
                {
                    EmitIsUnicodeScalarValueTest(fromAsInt, wr, wStmts);
                }
                else
                {
                    EmitIsInIntegerRange(fromAsInt, 0, 0x1_0000, wr, wStmts);
                }
                from = new ConversionExpr(from.tok, from, Type.Char) { Type = Type.Char };
            }

            if (needsRangeCheck)
            {
                var nativeType = toType.AsNativeType();
                var bitvectorType = toType.NormalizeToAncestorType().AsBitVectorType;
                Contract.Assert(nativeType != null || bitvectorType != null);

                BigInteger lo;
                BigInteger hi;
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_75(2629L, bitvectorType, null))
                {
                    lo = nativeType.LowerBound;
                    hi = nativeType.UpperBound;
                }
                else
                {
                    lo = 0;
                    hi = BigInteger.One << bitvectorType.Width;
                    if (MutateCSharp.Schemata247.ReplaceBinExprOp_25(2630L, nativeType, null))
                    {
                        Contract.Assert(nativeType.LowerBound <= 0);
                        if (MutateCSharp.Schemata247.ReplaceBinExprOp_52(2631L, nativeType.UpperBound, hi))
                        {
                            hi = nativeType.UpperBound;
                        }
                    }
                }

                var fromAsInt = new ConversionExpr(from.tok, from, Type.Int) { Type = Type.Int };
                EmitIsInIntegerRange(fromAsInt, lo, hi, wr, wStmts);
                from = new ConversionExpr(from.tok, from, toType) { Type = toType };
            }

            if (toType.NormalizeExpandKeepConstraints() is UserDefinedType toUdt &&
                toUdt.ResolvedClass is SubsetTypeDecl or NewtypeDecl)
            {
                var declWithConstraints = (RedirectingTypeDecl)toUdt.ResolvedClass;
                // check the constraints, by calling the _Is method
                var wrArgument = EmitCallToIsMethod(declWithConstraints, toUdt.TypeArgs, wr);
                var targetRepresentationOfFrom = new ConversionExpr(from.tok, from, toType) { Type = toType };
                EmitExpr(targetRepresentationOfFrom, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2633L, false), wrArgument, wStmts);
            }
            else
            {
                EmitExpr(Expression.CreateBoolLiteral(expr.tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2634L, true)), inLetExprBody, wr, wStmts);
            }
        }

        protected virtual ConcreteSyntaxTree EmitQuantifierExpr(Action<ConcreteSyntaxTree> collection, bool isForall, Type collectionElementType, BoundVar bv, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(2635L, "{0}("), GetQuantifierName(TypeName(collectionElementType, wr, bv.tok)));
            collection(wr);
            wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(2636L, ", {0}, "), isForall ? True : False);
            var ret = wr.Fork();
            wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(2637L, ")"));
            return ret;
        }

        protected virtual void EmitLambdaApply(ConcreteSyntaxTree wr, out ConcreteSyntaxTree wLambda, out ConcreteSyntaxTree wArg)
        {
            wLambda = wr.Fork();
            wr.Write(LambdaExecute);
            wArg = wr.ForkInParens();
        }

        protected void WriteTypeDescriptors(TopLevelDecl decl, List<Type> typeArguments, ConcreteSyntaxTree wrArgumentList, ref string sep)
        {
            Contract.Requires(decl.TypeArgs.Count == typeArguments.Count);
            var typeParameters = decl.TypeArgs;
            for (var i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(2638L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(2642L, i, typeParameters.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(2647L, ref i))
            {
                if (NeedsTypeDescriptor(typeParameters[i]))
                {
                    var typeArgument = typeArguments[i];
                    wrArgumentList.Write($"{sep}{TypeDescriptor(typeArgument, wrArgumentList, typeArgument.tok)}");
                    sep = MutateCSharp.Schemata247.ReplaceStringConstant_2(2648L, ", ");
                }
            }
        }

        /// <summary>
        /// When inside an enumeration like this:
        /// 
        ///     foreach(var [tmpVarName]: [collectionElementType] in ...) {
        ///        ...
        ///     }
        /// 
        /// MaybeInjectSubtypeConstraintWrtTraits emits a subtype constraint that tmpVarName should be of type boundVarType, typically of the form
        /// 
        ///       if([tmpVarName] is [boundVarType]) {
        ///         // This is where 'wr' will write
        ///       }
        ///
        /// If isReturning is true, then it will also insert the "return" statements,
        /// to use in the lambdas used by forall and exists statements:
        ///
        ///       if([tmpVarName] is [boundVarType]) {
        ///         // This is where 'wr' will write
        ///       } else {
        ///         return [elseReturnValue];
        ///       }
        ///
        /// </summary>
        private ConcreteSyntaxTree MaybeInjectSubtypeConstraintWrtTraits(string tmpVarName, Type collectionElementType, Type boundVarType,
          bool inLetExprBody, IToken tok, ConcreteSyntaxTree wr,
          bool isReturning = false, bool elseReturnValue = false)
        {

            if (Type.IsSupertype(boundVarType, collectionElementType))
            {
                // Every value of the collection enumeration is a value of the bound variable's type, so the assignment can be done unconditionally.
                // (The caller may still need to insert an upcast, depending on the target language.)
            }
            else
            {
                // We need to perform a run-time check to see if the collection value can be assigned to the bound variable.
                var preconditions = wr.Fork();
                var conditions = GetSubtypeCondition(tmpVarName, boundVarType, tok, preconditions);
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_76(2649L, conditions, null))
                {
                    preconditions.Clear();
                }
                else
                {
                    var thenWriter = EmitIf(out var guardWriter, isReturning, wr);
                    conditions(guardWriter);
                    if (isReturning)
                    {
                        wr = EmitBlock(wr);
                        var wStmts = wr.Fork();
                        wr = EmitReturnExpr(wr);
                        var elseLiteral = Expression.CreateBoolLiteral(tok, elseReturnValue);
                        EmitExpr(elseLiteral, inLetExprBody, wr, wStmts);
                    }
                    wr = thenWriter;
                }
            }
            return wr;
        }

        /// <summary>
        /// If needed, emit an if-statement wrapper that checks that the value stored in "boundVar" satisfies any (subset-type or newtype) constraints
        /// of "boundVarType".
        /// </summary>
        private ConcreteSyntaxTree MaybeInjectSubsetConstraint(IVariable boundVar, Type boundVarType,
          bool inLetExprBody, IToken tok, ConcreteSyntaxTree wr, bool isReturning = false, bool elseReturnValue = false)
        {

            if (boundVarType.NormalizeExpandKeepConstraints() is UserDefinedType { ResolvedClass: (SubsetTypeDecl or NewtypeDecl) } udt)
            {
                var declWithConstraints = (RedirectingTypeDecl)udt.ResolvedClass;

                var thenWriter = EmitIf(out var guardWriter, hasElse: isReturning, wr);

                EmitCallToIsMethod(declWithConstraints, udt.TypeArgs, guardWriter).Write(IdName(boundVar));

                if (isReturning)
                {
                    var elseBranch = wr;
                    elseBranch = EmitBlock(elseBranch);
                    elseBranch = EmitReturnExpr(elseBranch);
                    var wStmts = elseBranch.Fork();
                    EmitExpr(Expression.CreateBoolLiteral(tok, elseReturnValue), inLetExprBody, elseBranch, wStmts);
                }
                wr = thenWriter;
            }

            if (isReturning)
            {
                wr = EmitReturnExpr(wr);
            }
            return wr;
        }

        /// <summary>
        /// Generates the body of an _Is method for a subset type or newtype.
        /// "wr" is the writer the for body.
        /// It is assumed that the caller has declared an enclosing method body that includes a parameter "sourceFormal" and having the type
        /// "declWithConstraints" (with its type parameters as type arguments).
        /// It is also assumed that the type has a compilable constraint (otherwise, no "_Is" method should be generated).
        /// </summary>
        protected void GenerateIsMethodBody(RedirectingTypeDecl declWithConstraints, Formal sourceFormal, ConcreteSyntaxTree wr)
        {
            Contract.Requires(declWithConstraints is SubsetTypeDecl or NewtypeDecl);
            Contract.Requires(declWithConstraints.ConstraintIsCompilable);

            void ReturnBoolLiteral(ConcreteSyntaxTree writer, bool value)
            {
                var wrReturn = EmitReturnExpr(writer);
                EmitLiteralExpr(wrReturn, Expression.CreateBoolLiteral(declWithConstraints.tok, value));
            }

            if (declWithConstraints is NewtypeDecl { TargetTypeCoversAllBitPatterns: true })
            {
                // newtype has trivial constraint
                ReturnBoolLiteral(wr, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2650L, true));
                return;
            }

            IVariable baseTypeVarDecl;
            Type baseType;
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_77(2651L, declWithConstraints.Var, null))
            {
                baseTypeVarDecl = declWithConstraints.Var;
                baseType = baseTypeVarDecl.Type;
            }
            else
            {
                baseType = ((NewtypeDecl)declWithConstraints).BaseType;
                baseTypeVarDecl = new BoundVar(declWithConstraints.RangeToken, MutateCSharp.Schemata247.ReplaceStringConstant_2(2652L, "_base"), baseType);
            }
            baseType = baseType.NormalizeExpandKeepConstraints();
            var baseTypeVar = new IdentifierExpr(declWithConstraints.tok, baseTypeVarDecl);

            // var _base = (BaseType)source;
            var type = UserDefinedType.FromTopLevelDecl(declWithConstraints.tok, (TopLevelDecl)declWithConstraints);
            var wStmts = wr.Fork();
            DeclareLocalVar(IdName(baseTypeVarDecl), baseType, declWithConstraints.tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2653L, true), null, wr);
            var wRhs = EmitAssignmentRhs(wr);
            var source = new IdentifierExpr(sourceFormal.tok, sourceFormal);
            EmitConversionExpr(source, type, baseType, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2654L, false), wRhs, wStmts);
            EmitDummyVariableUse(IdName(baseTypeVarDecl), wr);

            if (baseType is UserDefinedType { ResolvedClass: SubsetTypeDecl or NewtypeDecl } baseTypeUdt)
            {
                wStmts = wr.Fork();
                var thenWriter = EmitIf(out var guardWriter, hasElse: MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2655L, false), wr);
                ReturnBoolLiteral(wr, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2656L, false));

                var wrArgument = EmitCallToIsMethod((RedirectingTypeDecl)baseTypeUdt.ResolvedClass, baseTypeUdt.TypeArgs, guardWriter);
                EmitExpr(baseTypeVar, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2657L, false), wrArgument, wStmts);

                wr = thenWriter;
            }

            if (MutateCSharp.Schemata247.ReplaceBinExprOp_78(2658L, declWithConstraints.Var, null))
            {
                ReturnBoolLiteral(wr, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2659L, true));
            }
            else
            {
                var wStmtsReturn = wr.Fork();
                var wrReturn = EmitReturnExpr(wr);
                EmitExpr(declWithConstraints.Constraint, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2660L, false), wrReturn, wStmtsReturn);
            }
        }

        protected ConcreteSyntaxTree EmitCallToIsMethod(RedirectingTypeDecl declWithConstraints, List<Type> typeArguments, ConcreteSyntaxTree wr)
        {
            Contract.Requires(declWithConstraints is SubsetTypeDecl or NewtypeDecl);
            Contract.Requires(declWithConstraints.TypeArgs.Count == typeArguments.Count);
            Contract.Requires(declWithConstraints.ConstraintIsCompilable);

            if (declWithConstraints is NonNullTypeDecl)
            {
                // Non-null types don't have a special target class, so we just do the non-null constraint check here.
                return EmitNullTest(MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2661L, false), wr);
            }

            if (declWithConstraints is NewtypeDecl { TargetTypeCoversAllBitPatterns: true })
            {
                EmitLiteralExpr(wr, Expression.CreateBoolLiteral(declWithConstraints.tok, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2662L, true)));
                var abyssWriter = new ConcreteSyntaxTree();
                return abyssWriter;
            }

            // in mind that type parameters are not accessible in static methods in some target languages).
            var type = UserDefinedType.FromTopLevelDecl(declWithConstraints.tok, (TopLevelDecl)declWithConstraints, typeArguments);
            EmitTypeName_Companion(type, wr, wr, declWithConstraints.tok, null);
            wr.Write(StaticClassAccessor);
            wr.Write(IsMethodName);
            var wrArguments = wr.ForkInParens();
            var sep = "";
            EmitTypeDescriptorsActuals(TypeArgumentInstantiation.ListFromClass((TopLevelDecl)declWithConstraints, type.TypeArgs),
              declWithConstraints.tok, wrArguments, ref sep);
            wrArguments.Write(sep);
            return wrArguments;
        }

        protected ConcreteSyntaxTree CaptureFreeVariables(Expression expr, bool captureOnlyAsRequiredByTargetLanguage,
          out Substituter su, bool inLetExprBody, ConcreteSyntaxTree wr, ref ConcreteSyntaxTree wStmts)
        {
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_8(2663L, () => captureOnlyAsRequiredByTargetLanguage, () => TargetLambdaCanUseEnclosingLocals))
            {
                // nothing to do
            }
            else
            {
                CreateFreeVarSubstitution(expr, out var bvars, out var fexprs, out su);
                if (MutateCSharp.Schemata247.ReplaceBinExprOp_21(2673L, bvars.Count, MutateCSharp.Schemata247.ReplaceNumericConstant_3(2669L, 0)))
                {
                    return EmitBetaRedex(bvars.ConvertAll(IdName), fexprs, bvars.ConvertAll(bv => bv.Type), expr.Type, expr.tok, inLetExprBody, wr, ref wStmts);
                }
            }
            su = Substituter.EMPTY;
            return wr;
        }

        void CreateFreeVarSubstitution(Expression expr, out List<BoundVar> bvars, out List<Expression> fexprs, out Substituter su)
        {
            Contract.Requires(expr != null);

            var fvs = FreeVariablesUtil.ComputeFreeVariables(Options, expr);
            var sm = new Dictionary<IVariable, Expression>();

            bvars = new List<BoundVar>();
            fexprs = new List<Expression>();
            foreach (var fv in fvs)
            {
                if (fv.IsGhost)
                {
                    continue;
                }
                fexprs.Add(new IdentifierExpr(fv.Tok, fv.Name)
                {
                    Var = fv, // resolved here!
                    Type = fv.Type
                });
                var bv = new BoundVar(fv.Tok, fv.Name, fv.Type);
                bvars.Add(bv);
                sm[fv] = new IdentifierExpr(bv.Tok, bv.Name)
                {
                    Var = bv, // resolved here!
                    Type = bv.Type
                };
            }

            su = new Substituter(null, sm, new Dictionary<TypeParameter, Type>());
        }

        protected ConcreteSyntaxTree StringLiteral(StringLiteralExpr str)
        {
            var result = new ConcreteSyntaxTree();
            TrStringLiteral(str, result);
            return result;
        }

        protected virtual void TrStringLiteral(StringLiteralExpr str, ConcreteSyntaxTree wr)
        {
            Contract.Requires(str != null);
            Contract.Requires(wr != null);
            EmitStringLiteral((string)str.Value, str.IsVerbatim, wr);
        }

        /// <summary>
        /// Try to evaluate "expr" into one BigInteger.  On success, return it; otherwise, return "null".
        /// </summary>
        /// <param name="expr"></param>
        /// <returns></returns>
        public static Nullable<BigInteger> PartiallyEvaluate(Expression expr)
        {
            Contract.Requires(expr != null);
            expr = expr.Resolved;
            if (expr is LiteralExpr)
            {
                var e = (LiteralExpr)expr;
                if (e.Value is BigInteger)
                {
                    return (BigInteger)e.Value;
                }
            }
            else if (expr is BinaryExpr)
            {
                var e = (BinaryExpr)expr;
                switch (e.ResolvedOp)
                {
                    case BinaryExpr.ResolvedOpcode.Add:
                    case BinaryExpr.ResolvedOpcode.Sub:
                    case BinaryExpr.ResolvedOpcode.Mul:
                        // possibly the most important case is Sub, since that's how NegationExpression's end up
                        var arg0 = PartiallyEvaluate(e.E0);
                        var arg1 = arg0 == null ? null : PartiallyEvaluate(e.E1);
                        if (arg1 != null)
                        {
                            switch (e.ResolvedOp)
                            {
                                case BinaryExpr.ResolvedOpcode.Add:
                                    return arg0 + arg1;
                                case BinaryExpr.ResolvedOpcode.Sub:
                                    return arg0 - arg1;
                                case BinaryExpr.ResolvedOpcode.Mul:
                                    return arg0 * arg1;
                                default:
                                    Contract.Assert(false);
                                    break;  // please compiler
                            }
                        }
                        break;
                        break;
                    default:
                        break;
                        break;
                }
            }
            return null;
        }

        ConcreteSyntaxTree TrCasePattern(CasePattern<BoundVar> pat, Action<ConcreteSyntaxTree> rhs, Type rhsType, Type bodyType,
          ConcreteSyntaxTree wr, ref ConcreteSyntaxTree wStmts)
        {
            Contract.Requires(pat != null);
            Contract.Requires(rhs != null);
            Contract.Requires(rhsType != null);
            Contract.Requires(bodyType != null);
            Contract.Requires(wr != null);

            if (MutateCSharp.Schemata247.ReplaceBinExprOp_77(2678L, pat.Var, null))
            {
                var bv = pat.Var;
                if (!bv.IsGhost)
                {
                    CreateIIFE(IdName(bv), bv.Type, bv.Tok, bodyType, pat.tok, wr, ref wStmts, out var wrRhs, out var wrBody);
                    wrRhs = EmitDowncastIfNecessary(rhsType, bv.Type, bv.tok, wrRhs);
                    rhs(wrRhs);
                    return wrBody;
                }
            }
            else if (MutateCSharp.Schemata247.ReplaceBinExprOp_79(2679L, pat.Arguments, null))
            {
                var ctor = pat.Ctor;
                Contract.Assert(ctor != null);  // follows from successful resolution
                Contract.Assert(pat.Arguments.Count == ctor.Formals.Count);  // follows from successful resolution
                Contract.Assert(ctor.EnclosingDatatype.TypeArgs.Count == rhsType.NormalizeExpand().TypeArgs.Count);
                var typeSubst = TypeParameter.SubstitutionMap(ctor.EnclosingDatatype.TypeArgs, rhsType.NormalizeExpand().TypeArgs);
                var k = MutateCSharp.Schemata247.ReplaceNumericConstant_3(2680L, 0);  // number of non-ghost formals processed
                for (int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(2684L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(2688L, i, pat.Arguments.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(2693L, ref i))
                {
                    var arg = pat.Arguments[i];
                    var formal = ctor.Formals[i];
                    if (formal.IsGhost)
                    {
                        // nothing to compile, but do a sanity check
                        Contract.Assert(!Contract.Exists(arg.Vars, bv => !bv.IsGhost));
                    }
                    else
                    {
                        wr = TrCasePattern(arg, sw => EmitDestructor(rhs, formal, k, ctor, ((DatatypeValue)pat.Expr).InferredTypeArgs, arg.Expr.Type, sw), formal.Type.Subst(typeSubst), bodyType, wr, ref wStmts);
                        MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(2694L, ref k);
                    }
                }
            }
            return wr;
        }

        void CompileSpecialFunctionCallExpr(FunctionCallExpr e, ConcreteSyntaxTree wr, bool inLetExprBody,
            ConcreteSyntaxTree wStmts, FCE_Arg_Translator tr)
        {
            string name = e.Function.Name;

            if (MutateCSharp.Schemata247.ReplaceBinExprOp_33(2696L, name, MutateCSharp.Schemata247.ReplaceStringConstant_2(2695L, "RotateLeft")))
            {
                EmitRotate(e.Receiver, e.Args[MutateCSharp.Schemata247.ReplaceNumericConstant_3(2697L, 0)], MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2701L, true), wr, inLetExprBody, wStmts, tr);
            }
            else if (MutateCSharp.Schemata247.ReplaceBinExprOp_33(2703L, name, MutateCSharp.Schemata247.ReplaceStringConstant_2(2702L, "RotateRight")))
            {
                EmitRotate(e.Receiver, e.Args[MutateCSharp.Schemata247.ReplaceNumericConstant_3(2704L, 0)], MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2708L, false), wr, inLetExprBody, wStmts, tr);
            }
            else
            {
                CompileFunctionCallExpr(e, wr, inLetExprBody, wStmts, tr);
            }
        }

        protected virtual void CompileFunctionCallExpr(FunctionCallExpr e, ConcreteSyntaxTree wr, bool inLetExprBody,
            ConcreteSyntaxTree wStmts, FCE_Arg_Translator tr, bool alreadyCoerced = false)
        {
            Contract.Requires(e != null && e.Function != null);
            Contract.Requires(wr != null);
            Contract.Requires(tr != null);
            Function f = e.Function;

            if (!alreadyCoerced)
            {
                var toType = MutateCSharp.Schemata247.ReplaceBinExprOp_49(2709L, thisContext, null) ? e.Type : e.Type.Subst(thisContext.ParentFormalTypeParametersToActuals);
                wr = EmitCoercionIfNecessary(f.Original.ResultType, toType, e.tok, wr);
            }

            var customReceiver = MutateCSharp.Schemata247.ReplaceBinExprOp_8(2710L, () => !(f.EnclosingClass is TraitDecl), () => NeedsCustomReceiver(f));
            string qual = "";
            string compileName = "";
            if (f.IsExtern(Options, out qual, out compileName) && qual != null)
            {
                wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(2716L, "{0}{1}"), qual, ModuleSeparator);
            }
            else if (MutateCSharp.Schemata247.ReplaceBinExprOp_9(2717L, () => f.IsStatic, () => customReceiver))
            {
                wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(2723L, "{0}{1}"), TypeName_Companion(e.Receiver.Type, wr, e.tok, f), StaticClassAccessor);
                compileName = customReceiver ? CompanionMemberIdName(f) : IdName(f);
            }
            else
            {
                wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(2724L, "("));
                var wReceiver = wr;
                if (f.EnclosingClass is TraitDecl traitDecl && MutateCSharp.Schemata247.ReplaceBinExprOp_68(2725L, e.Receiver.Type.AsTraitType, traitDecl))
                {
                    wReceiver = EmitCoercionIfNecessary(e.Receiver.Type, UserDefinedType.UpcastToMemberEnclosingType(e.Receiver.Type, f), e.tok, wr);
                }
                tr(e.Receiver, wReceiver, inLetExprBody, wStmts);
                wr.Write($"){InstanceClassAccessor}");
                compileName = IdName(f);
            }
            var typeArgs = CombineAllTypeArguments(f, e.TypeApplication_AtEnclosingClass, e.TypeApplication_JustFunction);
            EmitNameAndActualTypeArgs(compileName, TypeArgumentInstantiation.ToActuals(ForTypeParameters(typeArgs, f, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2726L, false))), f.tok, wr);
            wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(2727L, "("));
            var sep = "";
            EmitTypeDescriptorsActuals(ForTypeDescriptors(typeArgs, f.EnclosingClass, f, MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2728L, false)), e.tok, wr, ref sep);
            if (customReceiver)
            {
                wr.Write(sep);
                var w = EmitCoercionIfNecessary(e.Receiver.Type, UserDefinedType.UpcastToMemberEnclosingType(e.Receiver.Type, e.Function), e.tok, wr);
                EmitExpr(e.Receiver, inLetExprBody, w, wStmts);
                sep = MutateCSharp.Schemata247.ReplaceStringConstant_2(2729L, ", ");
            }
            for (int i = MutateCSharp.Schemata247.ReplaceNumericConstant_3(2730L, 0); MutateCSharp.Schemata247.ReplaceBinExprOp_6(2734L, i, e.Args.Count); MutateCSharp.Schemata247.ReplacePostfixUnaryExprOp_7(2739L, ref i))
            {
                if (!e.Function.Ins[i].IsGhost)
                {
                    wr.Write(sep);
                    var fromType = e.Args[i].Type;
                    var w = EmitCoercionIfNecessary(fromType, e.Function.Ins[i].Type, tok: e.tok, wr: wr);
                    var instantiatedToType = e.Function.Ins[i].Type.Subst(e.TypeArgumentSubstitutionsWithParents());
                    w = EmitDowncastIfNecessary(fromType, instantiatedToType, e.tok, w);
                    tr(e.Args[i], w, inLetExprBody, wStmts);
                    sep = MutateCSharp.Schemata247.ReplaceStringConstant_2(2740L, ", ");
                }
            }
            wr.Write(MutateCSharp.Schemata247.ReplaceStringConstant_2(2741L, ")"));
        }

        private bool IsComparisonToZero(BinaryExpr expr, out Expression/*?*/ arg, out int sign, out bool negated)
        {
            if (IsComparisonWithZeroOnRight(expr.Op, expr.E1, out var s, out negated))
            {
                // e.g. x < 0
                arg = expr.E0;
                sign = s;
                return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2742L, true);
            }
            else if (IsComparisonWithZeroOnRight(expr.Op, expr.E0, out s, out negated))
            {
                // e.g. 0 < x, equivalent to x < 0
                arg = expr.E1;
                sign = MutateCSharp.Schemata247.ReplacePrefixUnaryExprOp_80(2743L, ref s);
                return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2747L, true);
            }
            else
            {
                arg = null;
                sign = MutateCSharp.Schemata247.ReplaceNumericConstant_3(2748L, 0);
                return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2752L, false);
            }

            return default;
        }

        private bool IsComparisonWithZeroOnRight(
          BinaryExpr.Opcode op, Expression right,
          out int sign, out bool negated)
        {

            var rightVal = PartiallyEvaluate(right);
            if (MutateCSharp.Schemata247.ReplaceBinExprOp_9(2754L, () => rightVal == null, () => MutateCSharp.Schemata247.ReplaceBinExprOp_81(2753L, rightVal, BigInteger.Zero)))
            {
                sign = MutateCSharp.Schemata247.ReplaceNumericConstant_3(2760L, 0); // need to assign something
                negated = MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2764L, true); // need to assign something
                return MutateCSharp.Schemata247.ReplaceBooleanConstant_1(2765L, false);
            }
            else
            {
                switch (op)
                {
                    case BinaryExpr.Opcode.Lt:
                        // x < 0 <==> sign(x) == -1
                        sign = -1;
                        negated = false;
                        return true;
                        break;
                    case BinaryExpr.Opcode.Le:
                        // x <= 0 <==> sign(x) != 1
                        sign = 1;
                        negated = true;
                        return true;
                        break;
                    case BinaryExpr.Opcode.Eq:
                        // x == 0 <==> sign(x) == 0
                        sign = 0;
                        negated = false;
                        return true;
                        break;
                    case BinaryExpr.Opcode.Neq:
                        // x != 0 <==> sign(x) != 0
                        sign = 0;
                        negated = true;
                        return true;
                        break;
                    case BinaryExpr.Opcode.Gt:
                        // x > 0 <==> sign(x) == 1
                        sign = 1;
                        negated = false;
                        return true;
                        break;
                    case BinaryExpr.Opcode.Ge:
                        // x >= 0 <==> sign(x) != -1
                        sign = -1;
                        negated = true;
                        return true;
                        break;
                    default:
                        sign = 0; // need to assign something
                        negated = false; // ditto
                        return false;
                        break;
                }
            }

            return default;
        }

        protected abstract void EmitHaltRecoveryStmt(Statement body, string haltMessageVarName, Statement recoveryBody, ConcreteSyntaxTree wr);
    }
}
