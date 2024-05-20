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
using System.Diagnostics.Contracts;
using JetBrains.Annotations;
using Microsoft.Boogie;
using static Microsoft.Dafny.ResolutionErrors;
namespace MutateCSharp
{
    internal class Schemata405
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT405");
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

        internal static bool ReplaceBinExprOp_72(long mutantId, Microsoft.Dafny.DatatypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, Microsoft.Dafny.Declaration argument1, Microsoft.Dafny.Declaration argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_56(long mutantId, Microsoft.Dafny.Method argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_55(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.ModuleExportDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, Microsoft.Dafny.Declaration argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_74(long mutantId, System.Collections.Generic.Dictionary<Microsoft.Dafny.TypeParameter, Microsoft.Dafny.Type> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_29(long mutantId, Microsoft.Dafny.RedirectingTypeDecl argument1, Microsoft.Dafny.NewtypeDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_70(long mutantId, Microsoft.Dafny.CasePattern<Microsoft.Dafny.BoundVar> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_77(long mutantId, Microsoft.Dafny.IVariable argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.PrefixPredicate argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_79(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_58(long mutantId, Microsoft.Dafny.ForallStmt.BodyKind argument1, Microsoft.Dafny.ForallStmt.BodyKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static long ReplaceNumericConstant_30(long mutantId, long argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_23(long mutantId, Microsoft.Dafny.ModuleResolver argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_78(long mutantId, System.Collections.Generic.ISet<Microsoft.Dafny.IVariable> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_71(long mutantId, Microsoft.Dafny.CasePattern<Microsoft.Dafny.BoundVar> argument1, object argument2)
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

        internal static ulong ReplaceNumericConstant_31(long mutantId, ulong argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 2)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_67(long mutantId, Microsoft.Dafny.IndDatatypeDecl.ES argument1, Microsoft.Dafny.IndDatatypeDecl.ES argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_52(long mutantId, Microsoft.Dafny.PrefixLemma argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, Microsoft.Dafny.NonNullTypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_60(long mutantId, Microsoft.Dafny.TopLevelDeclWithMembers.InheritanceInformationClass argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_32(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_28(long mutantId, Microsoft.Dafny.RedirectingTypeDecl argument1, Microsoft.Dafny.TypeSynonymDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_37(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_3(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_42(long mutantId, Microsoft.Dafny.Function argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_25(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, Microsoft.Dafny.TopLevelDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_26(long mutantId, Microsoft.Dafny.ModuleDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_63(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, Microsoft.Dafny.TopLevelDeclWithMembers argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_36(long mutantId, Microsoft.Dafny.DatatypeDestructor argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_76(long mutantId, Microsoft.Dafny.UserDefinedType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_46(long mutantId, Microsoft.Dafny.TypeParameter.TPVariance argument1, Microsoft.Dafny.TypeParameter.TPVariance argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_41(long mutantId, Microsoft.Dafny.IndDatatypeDecl argument1, Microsoft.Dafny.IndDatatypeDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_43(long mutantId, Microsoft.Dafny.Function argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_66(long mutantId, Microsoft.Dafny.DatatypeCtor argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_6(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_40(long mutantId, Microsoft.Dafny.IndDatatypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_68(long mutantId, Microsoft.Dafny.TypeParameter argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_50(long mutantId, Microsoft.Dafny.Field argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_65(long mutantId, Microsoft.Dafny.DatatypeCtor argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.ModuleSignature argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_59(long mutantId, Microsoft.Dafny.TraitDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_53(long mutantId, Microsoft.Dafny.FunctionCallExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_38(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_69(long mutantId, Microsoft.Dafny.Formal argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_54(long mutantId, Microsoft.Dafny.Formal argument1, Microsoft.Dafny.Formal argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_73(long mutantId, Microsoft.Dafny.DatatypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_48(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Statement> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_51(long mutantId, Microsoft.Dafny.Field argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.TopLevelDeclWithMembers argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_34(long mutantId, Microsoft.Dafny.SubsetTypeDecl.WKind argument1, Microsoft.Dafny.SubsetTypeDecl.WKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceBinExprOp_57(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_39(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() != argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() == argument2(); }
            return argument1() != argument2();
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_62(long mutantId, Microsoft.Dafny.MemberDecl argument1, Microsoft.Dafny.MemberDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_64(long mutantId, Microsoft.Dafny.TypeParameter.EqualitySupportValue argument1, Microsoft.Dafny.TypeParameter.EqualitySupportValue argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_35(long mutantId, Microsoft.Dafny.BoundVar argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_47(long mutantId, Microsoft.Dafny.ModuleKindEnum argument1, Microsoft.Dafny.ModuleKindEnum argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.ModuleExportDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_44(long mutantId, Microsoft.Dafny.FunctionCallExpr.CoCallResolution argument1, Microsoft.Dafny.FunctionCallExpr.CoCallResolution argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_21(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, Microsoft.Dafny.TopLevelDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_27(long mutantId, Microsoft.Dafny.RedirectingTypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_45(long mutantId, Microsoft.Dafny.Function argument1, Microsoft.Dafny.Function argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_49(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_75(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_61(long mutantId, Microsoft.Dafny.TopLevelDeclWithMembers argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_24(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, Microsoft.Dafny.ModuleDefinition argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, int argument1, int argument2)
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

namespace Microsoft.Dafny
{
    public record ModuleResolutionResult(
      ModuleDecl ResolvedDeclaration,
      BatchErrorReporter ErrorReporter,
      Dictionary<ModuleDefinition, ModuleSignature> Signatures,
      Dictionary<TopLevelDeclWithMembers, Dictionary<string, MemberDecl>> ClassMembers
      );

    public interface ICanResolveNewAndOld
    {
        void GenResolve(INewOrOldResolver resolver, ResolutionContext context);
    }

    public
      interface ICanResolve
    {
        void Resolve(ModuleResolver resolver, ResolutionContext context);
    }

    public enum FrameExpressionUse { Reads, Modifies, Unchanged }

    public partial class ModuleResolver : INewOrOldResolver
    {
        public ProgramResolver ProgramResolver { get; }
        public DafnyOptions Options { get; }

        public readonly SystemModuleManager SystemModuleManager;

        public ErrorReporter reporter;
        public ModuleSignature moduleInfo = null;

        public ErrorReporter Reporter => reporter;
        public Scope<IVariable> Scope => scope;

        public List<TypeConstraint.ErrorMsg> TypeConstraintErrorsToBeReported { get; } = new();

        private bool RevealedInScope(Declaration d)
        {
            Contract.Requires(d != null);
            Contract.Requires(moduleInfo != null);
            Contract.Requires(moduleInfo.VisibilityScope != null);

            return d.IsRevealedInScope(moduleInfo.VisibilityScope);
        }

        internal bool VisibleInScope(Declaration d)
        {
            Contract.Requires(d != null);
            Contract.Requires(moduleInfo != null);
            Contract.Requires(moduleInfo.VisibilityScope != null);

            return d.IsVisibleInScope(moduleInfo.VisibilityScope);
        }

        public FreshIdGenerator defaultTempVarIdGenerator => ProgramResolver.Program.Compilation.IdGenerator;

        public string FreshTempVarName(string prefix, ICodeContext context)
        {
            var gen = context is Declaration decl ? decl.IdGenerator : defaultTempVarIdGenerator;
            var freshTempVarName = gen.FreshId(prefix);
            return freshTempVarName;
        }

        public readonly HashSet<RevealableTypeDecl> revealableTypes = new();
        //types that have been seen by the resolver - used for constraining type inference during exports

        public Dictionary<TopLevelDeclWithMembers, Dictionary<string, MemberDecl>> moduleClassMembers = new();

        public void AddClassMembers(TopLevelDeclWithMembers key, Dictionary<string, MemberDecl> members)
        {
            moduleClassMembers[key] = members;
        }

        public Dictionary<string, MemberDecl> GetClassMembers(TopLevelDeclWithMembers key)
        {
            if (moduleClassMembers.TryGetValue(key, out var result))
            {
                return result;
            }
            return ProgramResolver.GetClassMembers(key);
        }

        private Dictionary<TypeParameter, Type> SelfTypeSubstitution;

        public ModuleResolver(ProgramResolver programResolver, DafnyOptions options)
        {
            this.ProgramResolver = programResolver;
            Options = options;

            allTypeParameters = new Scope<TypeParameter>(Options);
            scope = new Scope<IVariable>(Options);
            EnclosingStatementLabels = new Scope<Statement>(Options);
            DominatingStatementLabels = new Scope<Label>(Options);

            SystemModuleManager = programResolver.SystemModuleManager;
            reporter = new BatchErrorReporter(Options);
        }

        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(SystemModuleManager != null);
        }

        public void FillInAdditionalInformation(ModuleDefinition module)
        {
            foreach (var clbl in ModuleDefinition.AllItersAndCallables(module.TopLevelDecls))
            {
                Statement body = null;
                if (clbl is ExtremeLemma)
                {
                    body = ((ExtremeLemma)clbl).PrefixLemma.Body;
                }
                else if (clbl is Method)
                {
                    body = ((Method)clbl).Body;
                }
                else if (clbl is IteratorDecl)
                {
                    body = ((IteratorDecl)clbl).Body;
                }

                if (MutateCSharp.Schemata405.ReplaceBinExprOp_0(1L, body, null))
                {
                    var c = new ReportOtherAdditionalInformation_Visitor(this);
                    c.Visit(body);
                }
            }
        }

        public void FillInDecreasesClauses(ModuleDefinition module)
        {
            // fill in default decreases clauses:  for functions and methods, and for loops
            new InferDecreasesClause(this).FillInDefaultDecreasesClauses(module);

            foreach (var clbl in ModuleDefinition.AllItersAndCallables(module.TopLevelDecls))
            {
                Statement body = null;
                if (clbl is Method)
                {
                    body = ((Method)clbl).Body;
                }
                else if (clbl is IteratorDecl)
                {
                    body = ((IteratorDecl)clbl).Body;
                }

                if (MutateCSharp.Schemata405.ReplaceBinExprOp_0(2L, body, null))
                {
                    var c = new FillInDefaultLoopDecreases_Visitor(this, clbl);
                    c.Visit(body);
                }
            }
        }

        public void ComputeIsRecursiveBit(CompilationData compilation, ModuleDefinition module, IEnumerable<IRewriter> rewriters)
        {
            // compute IsRecursive bit for mutually recursive functions and methods
            foreach (var clbl in ModuleDefinition.AllCallables(module.TopLevelDecls))
            {
                if (clbl is Function)
                {
                    var fn = (Function)clbl;
                    if (!fn.IsRecursive)
                    {
                        // note, self-recursion has already been determined
                        int n = module.CallGraph.GetSCCSize(fn);
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_2(7L, MutateCSharp.Schemata405.ReplaceNumericConstant_1(3L, 2), n))
                        {
                            // the function is mutually recursive (note, the SCC does not determine self recursion)
                            fn.IsRecursive = MutateCSharp.Schemata405.ReplaceBooleanConstant_3(12L, true);
                        }
                    }

                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(13L, () => fn.IsRecursive, () => fn is ExtremePredicate))
                    {
                        // this means the corresponding prefix predicate is also recursive
                        var prefixPred = ((ExtremePredicate)fn).PrefixPredicate;
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_5(19L, prefixPred, null))
                        {
                            prefixPred.IsRecursive = MutateCSharp.Schemata405.ReplaceBooleanConstant_3(20L, true);
                        }
                    }
                }
                else
                {
                    var m = (Method)clbl;
                    if (!m.IsRecursive)
                    {
                        // note, self-recursion has already been determined
                        int n = module.CallGraph.GetSCCSize(m);
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_2(25L, MutateCSharp.Schemata405.ReplaceNumericConstant_1(21L, 2), n))
                        {
                            // the function is mutually recursive (note, the SCC does not determine self recursion)
                        }
                    }
                }
            }

            foreach (var rewriter in rewriters)
            {
                rewriter.PostCyclicityResolve(module, Reporter);
            }
        }

        public ModuleResolutionResult ResolveModuleDeclaration(CompilationData compilation, ModuleDecl decl)
        {
            Dictionary<ModuleDefinition, ModuleSignature> signatures = new();
            if (decl is LiteralModuleDecl literalModuleDecl)
            {
                var signature = literalModuleDecl.Resolve(this, compilation);
                signatures[literalModuleDecl.ModuleDef] = signature;
            }
            else if (decl is AliasModuleDecl alias)
            {
                if (ResolveExport(alias, alias.EnclosingModuleDefinition, alias.TargetQId, alias.Exports, out var p, reporter))
                {
                    alias.Signature ??= p;
                }
                else
                {
                    alias.Signature = new ModuleSignature(); // there was an error, give it a valid but empty signature
                }
            }
            else if (decl is AbstractModuleDecl abs)
            {
                if (ResolveExport(abs, abs.EnclosingModuleDefinition, abs.QId, abs.Exports, out var originalSignature, reporter))
                {
                    abs.OriginalSignature = originalSignature;
                    abs.Signature = MakeAbstractSignature(originalSignature, abs.FullSanitizedName, abs.Height, signatures);
                }
                else
                {
                    abs.Signature = new ModuleSignature(); // there was an error, give it a valid but empty signature
                }
            }
            else if (decl is ModuleExportDecl)
            {
            }
            else
            {
                Contract.Assert(false); // Unknown kind of ModuleDecl
            }

            return new ModuleResolutionResult(decl, (BatchErrorReporter)reporter, signatures, moduleClassMembers);
        }

        // Resolve the exports and detect cycles.
        public void ResolveModuleExport(LiteralModuleDecl literalDecl, ModuleSignature sig)
        {
            ModuleDefinition m = literalDecl.ModuleDef;
            literalDecl.DefaultExport = sig;
            Graph<ModuleExportDecl> exportDependencies = new Graph<ModuleExportDecl>();
            foreach (TopLevelDecl toplevel in m.TopLevelDecls)
            {
                if (toplevel is ModuleExportDecl exportDecl)
                {
                    exportDependencies.AddVertex(exportDecl);
                    foreach (IToken s in exportDecl.Extends)
                    {
                        if (sig.ExportSets.TryGetValue(s.val, out var extend))
                        {
                            exportDecl.ExtendDecls.Add(extend);
                            exportDependencies.AddEdge(exportDecl, extend);
                        }
                        else
                        {
                            reporter.Error(MessageSource.Resolver, s, s.val + MutateCSharp.Schemata405.ReplaceStringConstant_6(30L, " must be an export of ") + m.Name + MutateCSharp.Schemata405.ReplaceStringConstant_6(31L, " to be extended"));
                        }
                    }
                }
            }

            // detect cycles in the extend
            var cycleError = MutateCSharp.Schemata405.ReplaceBooleanConstant_3(32L, false);
            foreach (var cycle in exportDependencies.AllCycles())
            {
                ReportCycleError(reporter, cycle, m => m.tok, m => m.Name, MutateCSharp.Schemata405.ReplaceStringConstant_6(33L, "module export contains a cycle"));
                cycleError = MutateCSharp.Schemata405.ReplaceBooleanConstant_3(34L, true);
            }

            if (cycleError)
            {
                return;
            } // give up on trying to resolve anything else

            // fill in the exports for the extends.
            List<ModuleExportDecl> sortedExportDecls = exportDependencies.TopologicallySortedComponents();
            ModuleExportDecl defaultExport = null;

            sig.TopLevels.TryGetValue(MutateCSharp.Schemata405.ReplaceStringConstant_6(35L, "_default"), out var defaultClass);
            Contract.Assert(defaultClass is DefaultClassDecl);
            defaultClass.AddVisibilityScope(m.VisibilityScope, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(36L, true));

            foreach (var exportDecl in sortedExportDecls)
            {

                defaultClass.AddVisibilityScope(exportDecl.ThisScope, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(37L, true));

                foreach (var eexports in exportDecl.ExtendDecls.Select(e => e.Exports))
                {
                    exportDecl.Exports.AddRange(eexports);
                }

                if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(56L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_7(42L, exportDecl.ExtendDecls.Count, MutateCSharp.Schemata405.ReplaceNumericConstant_1(38L, 0)), () => MutateCSharp.Schemata405.ReplaceBinExprOp_7(51L, exportDecl.Exports.Count, MutateCSharp.Schemata405.ReplaceNumericConstant_1(47L, 0))))
                {
                    // This is an empty export.  This is allowed, but unusual.  It could pop up, for example, if
                    // someone temporary comments out everything that the export set provides/reveals.  However,
                    // if the name of the export set coincides with something else that's declared at the top
                    // level of the module, then this export declaration is more likely an error--the user probably
                    // forgot the "provides" or "reveals" keyword.

                    // Top-level functions and methods are actually recorded as members of the _default class.  We look up the
                    // export-set name there.  If the export-set name happens to coincide with some other top-level declaration,
                    // then an error will already have been produced ("duplicate name of top-level declaration").
                    if (GetClassMembers((DefaultClassDecl)defaultClass)?.TryGetValue(exportDecl.Name, out var member) == MutateCSharp.Schemata405.ReplaceBooleanConstant_3(62L, true))
                    {
                        reporter.Warning(MessageSource.Resolver, ErrorRegistry.NoneId, exportDecl.tok,
            MutateCSharp.Schemata405.ReplaceStringConstant_6(63L, "this export set is empty (did you perhaps forget the 'provides' or 'reveals' keyword?)"));
                    }
                }

                foreach (ExportSignature export in exportDecl.Exports)
                {

                    // check to see if it is a datatype or a member or
                    // static function or method in the enclosing module or its imports

                    Declaration decl = null;
                    string name = export.Id;

                    if (export.ClassId != null)
                    {
                        if (!sig.TopLevels.TryGetValue(export.ClassId, out var cldecl))
                        {
                            reporter.Error(MessageSource.Resolver, export.ClassIdTok, MutateCSharp.Schemata405.ReplaceStringConstant_6(64L, "'{0}' is not a top-level type declaration"),
                              export.ClassId);
                            continue;
                        }

                        if (cldecl is ClassLikeDecl { NonNullTypeDecl: { } })
                        {
                            // cldecl is a possibly-null type (syntactically given with a question mark at the end)
                            reporter.Error(MessageSource.Resolver, export.ClassIdTok, MutateCSharp.Schemata405.ReplaceStringConstant_6(65L, "'{0}' is not a type that can declare members"),
                              export.ClassId);
                            continue;
                        }

                        if (cldecl is NonNullTypeDecl)
                        {
                            // cldecl was given syntactically like the name of a class, but here it's referring to the corresponding non-null subset type
                            cldecl = cldecl.ViewAsClass;
                        }

                        var mt = cldecl as TopLevelDeclWithMembers;
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_8(66L, mt, null))
                        {
                            reporter.Error(MessageSource.Resolver, export.ClassIdTok, MutateCSharp.Schemata405.ReplaceStringConstant_6(67L, "'{0}' is not a type that can declare members"),
                              export.ClassId);
                            continue;
                        }

                        var lmem = mt.Members.FirstOrDefault(l => MutateCSharp.Schemata405.ReplaceBinExprOp_9(68L, l.Name, export.Id));
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_10(69L, lmem, null))
                        {
                            reporter.Error(MessageSource.Resolver, export.Tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(70L, "No member '{0}' found in type '{1}'"), export.Id,
                              export.ClassId);
                            continue;
                        }

                        decl = lmem;
                    }
                    else if (sig.TopLevels.TryGetValue(name, out var tdecl))
                    {
                        if (tdecl is ClassLikeDecl { NonNullTypeDecl: { } nn })
                        {
                            // cldecl is a possibly-null type (syntactically given with a question mark at the end)
                            reporter.Error(MessageSource.Resolver, export.Tok,
                              export.Opaque
                                ? MutateCSharp.Schemata405.ReplaceStringConstant_6(71L, "Type '{1}' can only be revealed, not provided"
              ) : MutateCSharp.Schemata405.ReplaceStringConstant_6(72L, "Types '{0}' and '{1}' are exported together, which is accomplished by revealing the name '{0}'"),
                              nn.Name, name);
                            continue;
                        }

                        // Member of the enclosing module
                        decl = tdecl;
                    }
                    else if (sig.StaticMembers.TryGetValue(name, out var member))
                    {
                        decl = member;
                    }
                    else if (sig.ExportSets.ContainsKey(name))
                    {
                        reporter.Error(MessageSource.Resolver, export.Tok,
            MutateCSharp.Schemata405.ReplaceStringConstant_6(73L, "'{0}' is an export set and cannot be provided/revealed by another export set (did you intend to list it in an \"extends\"?)"),
                          name);
                        continue;
                    }
                    else
                    {
                        reporter.Error(MessageSource.Resolver, export.Tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(74L, "'{0}' must be a member of '{1}' to be exported"), name,
                          m.Name);
                        continue;
                    }

                    if (!decl.CanBeExported())
                    {
                        reporter.Error(MessageSource.Resolver, export.Tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(75L, "'{0}' is not a valid export of '{1}'"), name, m.Name);
                        continue;
                    }

                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(76L, () => !export.Opaque, () => !decl.CanBeRevealed()))
                    {
                        reporter.Error(MessageSource.Resolver, export.Tok,
            MutateCSharp.Schemata405.ReplaceStringConstant_6(82L, "'{0}' cannot be revealed in an export. Use \"provides\" instead."), name);
                        continue;
                    }

                    export.Decl = decl;
                    if (decl is NonNullTypeDecl nntd)
                    {
                        nntd.AddVisibilityScope(exportDecl.ThisScope, export.Opaque);
                        if (!export.Opaque)
                        {
                            nntd.Class.AddVisibilityScope(exportDecl.ThisScope, export.Opaque);
                            // add the anonymous constructor, if any
                            var anonymousConstructor = nntd.Class.Members.Find(mdecl => MutateCSharp.Schemata405.ReplaceBinExprOp_9(84L, mdecl.Name, MutateCSharp.Schemata405.ReplaceStringConstant_6(83L, "_ctor")));
                            if (MutateCSharp.Schemata405.ReplaceBinExprOp_11(85L, anonymousConstructor, null))
                            {
                                anonymousConstructor.AddVisibilityScope(exportDecl.ThisScope, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(86L, false));
                            }
                        }
                    }
                    else
                    {
                        decl.AddVisibilityScope(exportDecl.ThisScope, export.Opaque);
                    }
                }
            }

            foreach (ModuleExportDecl exportDecl in sortedExportDecls)
            {
                if (exportDecl.IsDefault)
                {
                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_12(87L, defaultExport, null))
                    {
                        defaultExport = exportDecl;
                    }
                    else
                    {
                        reporter.Error(MessageSource.Resolver, m.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(88L, "more than one default export set declared in module {0}"),
                          m.Name);
                    }
                }

                // fill in export signature
                ModuleSignature signature = exportDecl.Signature;
                if (MutateCSharp.Schemata405.ReplaceBinExprOp_13(89L, signature, null))
                {
                    signature.ModuleDef = m;
                }

                foreach (var top in sig.TopLevels)
                {
                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_14(90L, () => !top.Value.CanBeExported(), () => !top.Value.IsVisibleInScope(signature.VisibilityScope)))
                    {
                        continue;
                    }

                    signature.TopLevels.TryAdd(top.Key, top.Value);

                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(96L, () => top.Value is DatatypeDecl, () => top.Value.IsRevealedInScope(signature.VisibilityScope)))
                    {
                        foreach (var ctor in ((DatatypeDecl)top.Value).Ctors)
                        {
                            if (!signature.Ctors.ContainsKey(ctor.Name))
                            {
                                signature.Ctors.Add(ctor.Name, new Tuple<DatatypeCtor, bool>(ctor, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(102L, false)));
                            }
                        }
                    }
                }

                foreach (var mem in sig.StaticMembers.Where(t => MutateCSharp.Schemata405.ReplaceBinExprOp_4(103L, () => t.Value.IsVisibleInScope(signature.VisibilityScope), () => t.Value.CanBeExported())))
                {
                    signature.StaticMembers.TryAdd(mem.Key, (MemberDecl)mem.Value);
                }
            }

            // set the default export set, if it exists
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_15(109L, defaultExport, null))
            {
                literalDecl.DefaultExport = defaultExport.Signature;
            }
            else if (MutateCSharp.Schemata405.ReplaceBinExprOp_16(114L, sortedExportDecls.Count, MutateCSharp.Schemata405.ReplaceNumericConstant_1(110L, 0)))
            {
                literalDecl.DefaultExport = null;
            }

            // final pass to propagate visibility of exported imports
            var sigs = sortedExportDecls.Select(d => d.Signature).Append(sig);

            foreach (var s in sigs)
            {
                foreach (var decl in s.TopLevels)
                {
                    if (decl.Value is ModuleDecl modDecl and not ModuleExportDecl)
                    {
                        s.VisibilityScope.Augment(modDecl.AccessibleSignature().VisibilityScope);
                    }
                }
            }

            var exported = new HashSet<Tuple<Declaration, bool>>();

            //some decls may not be set due to resolution errors
            foreach (var e in sortedExportDecls.SelectMany(e => e.Exports).Where(e => MutateCSharp.Schemata405.ReplaceBinExprOp_17(119L, e.Decl, null)))
            {
                var decl = e.Decl;
                exported.Add(new Tuple<Declaration, bool>(decl, e.Opaque));
                if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(120L, () => !e.Opaque, () => decl.CanBeRevealed()))
                {
                    exported.Add(new Tuple<Declaration, bool>(decl, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(126L, true)));
                    if (decl is NonNullTypeDecl nntd)
                    {
                        exported.Add(new Tuple<Declaration, bool>(nntd.Class, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(127L, true)));
                    }
                }

                if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(128L, () => e.Opaque, () => (decl is DatatypeDecl or TypeSynonymDecl)))
                {
                    // Datatypes and type synonyms are marked as _provided when they appear in any provided export.  If a
                    // declaration is never provided, then either it isn't visible outside the module at all or its whole
                    // definition is.  Datatype and type-synonym declarations undergo some inference from their definitions.
                    // Such inference should not be done for provided declarations, since different views of the module
                    // would then get different inferred properties.
                    decl.Attributes = new Attributes(MutateCSharp.Schemata405.ReplaceStringConstant_6(134L, "_provided"), new List<Expression>(), decl.Attributes);
                    reporter.Info(MessageSource.Resolver, decl.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(135L, "{:_provided}"));
                }
            }

            Dictionary<RevealableTypeDecl, bool?> declScopes = new Dictionary<RevealableTypeDecl, bool?>();
            Dictionary<RevealableTypeDecl, bool?> modifies = new Dictionary<RevealableTypeDecl, bool?>();

            //of all existing types, compute the minimum visibility of them for each exported declaration's
            //body and signature
            foreach (var e in exported)
            {

                declScopes.Clear();
                modifies.Clear();

                foreach (var typ in revealableTypes)
                {
                    declScopes.Add(typ, null);
                }

                foreach (var decl in sortedExportDecls)
                {
                    if (decl.Exports.Exists(ex => MutateCSharp.Schemata405.ReplaceBinExprOp_4(143L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_18(136L, ex.Decl, e.Item1), () => (MutateCSharp.Schemata405.ReplaceBinExprOp_14(137L, () => e.Item2, () => !ex.Opaque)))))
                    {
                        //if we are revealed, consider those exports where we are provided as well
                        var scope = decl.Signature.VisibilityScope;

                        foreach (var kv in declScopes)
                        {
                            bool? isOpaque = kv.Value;
                            var typ = kv.Key;
                            if (!typ.AsTopLevelDecl.IsVisibleInScope(scope))
                            {
                                modifies[typ] = null;
                                continue;
                            }

                            if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(149L, () => isOpaque.HasValue, () => isOpaque.Value))
                            {
                                //type is visible here, but known-opaque, so do nothing
                                continue;
                            }

                            modifies[typ] = !typ.AsTopLevelDecl.IsRevealedInScope(scope);
                        }

                        foreach (var kv in modifies)
                        {
                            if (!kv.Value.HasValue)
                            {
                                declScopes.Remove(kv.Key);
                            }
                            else
                            {
                                var exvis = declScopes[kv.Key];
                                if (exvis.HasValue)
                                {
                                    declScopes[kv.Key] = MutateCSharp.Schemata405.ReplaceBinExprOp_14(155L, () => exvis.Value, () => kv.Value.Value);
                                }
                                else
                                {
                                    declScopes[kv.Key] = kv.Value;
                                }
                            }
                        }

                        modifies.Clear();
                    }
                }

                VisibilityScope newscope = new VisibilityScope(e.Item1.Name);

                foreach (var rt in declScopes)
                {
                    if (!rt.Value.HasValue)
                    {
                        continue;
                    }

                    rt.Key.AsTopLevelDecl.AddVisibilityScope(newscope, rt.Value.Value);
                }
            }
        }

        public void CheckModuleExportConsistency(CompilationData compilation, ModuleDefinition m)
        {
            //check for export consistency by resolving internal modules
            //this should be effect-free, as it only operates on clones

            var oldModuleInfo = moduleInfo;
            foreach (var exportDecl in m.TopLevelDecls.OfType<ModuleExportDecl>())
            {

                var prevErrors = reporter.Count(ErrorLevel.Error);

                foreach (var export in exportDecl.Exports)
                {
                    if (export.Decl is MemberDecl member)
                    {
                        // For classes and traits, the visibility test is performed on the corresponding non-null type
                        var enclosingType = member.EnclosingClass is ClassLikeDecl cl && MutateCSharp.Schemata405.ReplaceBinExprOp_19(161L, cl.NonNullTypeDecl, null
            ) ? cl.NonNullTypeDecl
                          : member.EnclosingClass;
                        if (!enclosingType.IsVisibleInScope(exportDecl.Signature.VisibilityScope))
                        {
                            reporter.Error(MessageSource.Resolver, export.Tok,
              MutateCSharp.Schemata405.ReplaceStringConstant_6(162L, "Cannot export type member '{0}' without providing its enclosing {1} '{2}'"), member.Name,
                              member.EnclosingClass.WhatKind, member.EnclosingClass.Name);
                        }
                        else if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(163L, () => member is Constructor, () => !member.EnclosingClass.IsRevealedInScope(exportDecl.Signature.VisibilityScope)))
                        {
                            reporter.Error(MessageSource.Resolver, export.Tok,
              MutateCSharp.Schemata405.ReplaceStringConstant_6(169L, "Cannot export constructor '{0}' without revealing its enclosing {1} '{2}'"), member.Name,
                              member.EnclosingClass.WhatKind, member.EnclosingClass.Name);
                        }
                        else if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(176L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_4(170L, () => member is Field, () => !(member is ConstantField)), () => !member.EnclosingClass.IsRevealedInScope(exportDecl.Signature.VisibilityScope)))
                        {
                            reporter.Error(MessageSource.Resolver, export.Tok,
              MutateCSharp.Schemata405.ReplaceStringConstant_6(182L, "Cannot export mutable field '{0}' without revealing its enclosing {1} '{2}'"), member.Name,
                              member.EnclosingClass.WhatKind, member.EnclosingClass.Name);
                        }
                    }
                }

                var scope = exportDecl.Signature.VisibilityScope;
                Cloner cloner = new ScopeCloner(scope);
                var exportView = cloner.CloneModuleDefinition(m, m.EnclosingModule, m.NameNode);
                if (Options.DafnyPrintExportedViews.Contains(exportDecl.FullName))
                {
                    var wr = Options.OutputWriter;
                    wr.WriteLine(MutateCSharp.Schemata405.ReplaceStringConstant_6(183L, "/* ===== export set {0}"), exportDecl.FullName);
                    var pr = new Printer(wr, Options);
                    pr.PrintTopLevelDecls(compilation, exportView.TopLevelDecls, MutateCSharp.Schemata405.ReplaceNumericConstant_1(184L, 0), null, null);
                    wr.WriteLine(MutateCSharp.Schemata405.ReplaceStringConstant_6(188L, "*/"));
                }

                if (MutateCSharp.Schemata405.ReplaceBinExprOp_20(189L, reporter.Count(ErrorLevel.Error), prevErrors))
                {
                    continue;
                }

                reporter = new ErrorReporterWrapper(reporter,
                  $"Raised while checking export set {exportDecl.Name}: ");
                var testSig = exportView.RegisterTopLevelDecls(this, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(194L, true));
                exportView.Resolve(testSig, this, exportDecl.Name);
                var wasError = MutateCSharp.Schemata405.ReplaceBinExprOp_16(199L, reporter.Count(ErrorLevel.Error), MutateCSharp.Schemata405.ReplaceNumericConstant_1(195L, 0));
                reporter = (BatchErrorReporter)((ErrorReporterWrapper)reporter).WrappedReporter;

                if (wasError)
                {
                    reporter.Error(MessageSource.Resolver, exportDecl.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(204L, "This export set is not consistent: {0}"), exportDecl.Name);
                }
                else
                {
                    exportDecl.EffectiveModule = exportView;
                }
            }

            moduleInfo = oldModuleInfo;
        }

        private static bool EquivIfPresent<T1, T2>(Dictionary<T1, T2> dic, T1 key, T2 val)
          where T2 : class
        {
            T2 val2;
            if (dic.TryGetValue(key, out val2))
            {
                return val.Equals(val2);
            }

            return MutateCSharp.Schemata405.ReplaceBooleanConstant_3(205L, true);
        }

        public static ModuleSignature MergeSignature(ModuleSignature m, ModuleSignature system)
        {
            Contract.Requires(m != null);
            Contract.Requires(system != null);
            var info = new ModuleSignature();
            // add the system-declared information, among which we know there are no duplicates
            foreach (var kv in system.TopLevels)
            {
                info.TopLevels.Add(kv.Key, kv.Value);
            }

            foreach (var kv in system.Ctors)
            {
                info.Ctors.Add(kv.Key, kv.Value);
            }

            foreach (var kv in system.StaticMembers)
            {
                info.StaticMembers.Add(kv.Key, kv.Value);
            }

            // add for the module itself
            foreach (var kv in m.TopLevels)
            {
                if (info.TopLevels.TryGetValue(kv.Key, out var infoValue))
                {
                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_21(206L, infoValue, kv.Value))
                    {
                        // This only happens if one signature contains the name C as a class C (because it
                        // provides C) and the other signature contains the name C as a non-null type decl
                        // (because it reveals C and C?). The merge output will contain the non-null type decl
                        // for the key (and we expect the mapping "C? -> class C" to be placed in the
                        // merge output as well, by the end of this loop).
                        if (infoValue is ClassLikeDecl)
                        {
                            var cd = (ClassLikeDecl)infoValue;
                            Contract.Assert(cd.NonNullTypeDecl == kv.Value);
                            info.TopLevels[kv.Key] = kv.Value;
                        }
                        else if (kv.Value is ClassDecl)
                        {
                            var cd = (ClassDecl)kv.Value;
                            Contract.Assert(cd.NonNullTypeDecl == infoValue);
                            // info.TopLevel[kv.Key] already has the right value
                        }
                        else
                        {
                            Contract.Assert(false); // unexpected
                        }

                        continue;
                    }
                }

                info.TopLevels[kv.Key] = kv.Value;
            }

            foreach (var kv in m.Ctors)
            {
                Contract.Assert(EquivIfPresent(info.Ctors, kv.Key, kv.Value));
                info.Ctors[kv.Key] = kv.Value;
            }

            foreach (var kv in m.StaticMembers)
            {
                Contract.Assert(EquivIfPresent(info.StaticMembers, kv.Key, kv.Value));
                info.StaticMembers[kv.Key] = kv.Value;
            }

            info.IsAbstract = m.IsAbstract;
            info.VisibilityScope = new VisibilityScope();
            info.VisibilityScope.Augment(m.VisibilityScope);
            info.VisibilityScope.Augment(system.VisibilityScope);
            return info;
        }

        public static void ResolveOpenedImports(ModuleSignature sig, ModuleDefinition moduleDef, ErrorReporter reporter, ModuleResolver resolver)
        {
            var declarations = sig.TopLevels.Values.ToList<TopLevelDecl>();
            var importedSigs = new HashSet<ModuleSignature>() { sig };

            var topLevelDeclReplacements = new List<TopLevelDecl>();
            foreach (var importDeclaration in declarations.OfType<ModuleDecl>().Where(d => d.Opened))
            {
                ResolveOpenedImportsWorker(reporter, sig, moduleDef, importDeclaration, importedSigs, out var topLevelDeclReplacement);
                if (MutateCSharp.Schemata405.ReplaceBinExprOp_22(207L, topLevelDeclReplacement, null))
                {
                    topLevelDeclReplacements.Add(topLevelDeclReplacement);
                }
            }
            foreach (var topLevelDeclReplacement in topLevelDeclReplacements)
            {
                if (sig.TopLevels.GetValueOrDefault(topLevelDeclReplacement.Name) is ModuleDecl moduleDecl)
                {
                    sig.ShadowedImportedModules[topLevelDeclReplacement.Name] = moduleDecl;
                }
                sig.TopLevels[topLevelDeclReplacement.Name] = topLevelDeclReplacement;
            }

            if (MutateCSharp.Schemata405.ReplaceBinExprOp_23(208L, resolver, null))
            {
                //needed because ResolveOpenedImports is used statically for a refinement check
                if (sig.TopLevels[MutateCSharp.Schemata405.ReplaceStringConstant_6(209L, "_default")] is AmbiguousTopLevelDecl)
                {
                    Contract.Assert(sig.TopLevels["_default"].WhatKind == "class");
                    var cl = new DefaultClassDecl(moduleDef, sig.StaticMembers.Values.ToList());
                    sig.TopLevels[MutateCSharp.Schemata405.ReplaceStringConstant_6(210L, "_default")] = cl;
                    resolver.AddClassMembers(cl, cl.Members.ToDictionary(m => m.Name));
                }
            }
        }

        private static TopLevelDecl ResolveAlias(TopLevelDecl dd, ErrorReporter reporter)
        {
            while (dd is AliasModuleDecl amd)
            {
                dd = amd.TargetQId.ResolveTarget(reporter);
            }
            return dd;
        }

        /// <summary>
        /// Further populate "sig" with the accessible symbols from "im".
        ///
        /// Symbols declared locally in "moduleDef" take priority over any opened-import symbols, with one
        /// exception:  for an "import opened M" where "M" contains a top-level symbol "M", unambiguously map the
        /// name "M" to that top-level symbol in "sig". To achieve the "unambiguously" part, return the desired mapping
        /// to the caller, and let the caller remap the symbol after all opened imports have been processed.
        /// </summary>
        private static void ResolveOpenedImportsWorker(ErrorReporter reporter, ModuleSignature importerSignature, ModuleDefinition importer,
          ModuleDecl import, ISet<ModuleSignature> importedSigs,
          out TopLevelDecl topLevelDeclReplacement)
        {

            topLevelDeclReplacement = null;
            var importSignature = GetSignatureExt(import.AccessibleSignature(MutateCSharp.Schemata405.ReplaceBooleanConstant_3(211L, false)));

            if (!importedSigs.Add(importSignature))
            {
                return;
            }

            // top-level declarations:
            foreach (var kv in importSignature.TopLevels)
            {
                if (!kv.Value.CanBeExported())
                {
                    continue;
                }

                if (!importerSignature.TopLevels.TryGetValue(kv.Key, out var sameNameSymbolInImporter))
                {
                    importerSignature.TopLevels.Add(kv.Key, kv.Value);
                }
                else if (MutateCSharp.Schemata405.ReplaceBinExprOp_24(212L, sameNameSymbolInImporter.EnclosingModuleDefinition, importer))
                {
                    // declarations in the importing module take priority over opened-import declarations
                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_9(213L, kv.Value.EnclosingModuleDefinition.DafnyName, kv.Key))
                    {
                        // As an exception to the rule, for an "import opened M" that contains a top-level symbol "M", unambiguously map the
                        // name "M" to that top-level symbol in "sig". To achieve the "unambiguously" part, return the desired mapping to
                        // the caller, and let the caller remap the symbol after all opened imports have been processed.
                        topLevelDeclReplacement = kv.Value;
                    }
                }
                else
                {
                    bool unambiguous = MutateCSharp.Schemata405.ReplaceBooleanConstant_3(214L, false);
                    // keep just one if they normalize to the same entity
                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_25(215L, sameNameSymbolInImporter, kv.Value))
                    {
                        unambiguous = MutateCSharp.Schemata405.ReplaceBooleanConstant_3(216L, true);
                    }
                    else if (MutateCSharp.Schemata405.ReplaceBinExprOp_14(217L, () => sameNameSymbolInImporter is ModuleDecl, () => kv.Value is ModuleDecl))
                    {
                        var dd = ResolveAlias(sameNameSymbolInImporter, reporter);
                        var dk = ResolveAlias(kv.Value, reporter);
                        unambiguous = MutateCSharp.Schemata405.ReplaceBinExprOp_25(223L, dd, dk);
                    }
                    else
                    {
                        // It's okay if "d" and "kv.Value" denote the same type. This can happen, for example,
                        // if both are type synonyms for "int".
                        var scope = Type.GetScope();
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(224L, () => sameNameSymbolInImporter.IsVisibleInScope(scope), () => kv.Value.IsVisibleInScope(scope)))
                        {
                            var dType = UserDefinedType.FromTopLevelDecl(sameNameSymbolInImporter.tok, sameNameSymbolInImporter);
                            var vType = UserDefinedType.FromTopLevelDecl(kv.Value.tok, kv.Value);
                            unambiguous = dType.Equals(vType, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(230L, true));
                        }
                    }
                    if (!unambiguous)
                    {
                        importerSignature.TopLevels[kv.Key] = AmbiguousTopLevelDecl.Create(importer, sameNameSymbolInImporter, kv.Value);
                    }
                }
            }

            // constructors:
            foreach (var kv in importSignature.Ctors)
            {
                if (importerSignature.Ctors.TryGetValue(kv.Key, out var pair))
                {
                    // The same ctor can be imported from two different imports (e.g "diamond" imports), in which case,
                    // they are not duplicates.
                    if (!ReferenceEquals(kv.Value.Item1, pair.Item1))
                    {
                        // mark it as a duplicate
                        importerSignature.Ctors[kv.Key] = new Tuple<DatatypeCtor, bool>(pair.Item1, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(231L, true));
                    }
                }
                else
                {
                    // add new
                    importerSignature.Ctors.Add(kv.Key, kv.Value);
                }
            }

            // static members:
            foreach (var kv in importSignature.StaticMembers)
            {
                if (!kv.Value.CanBeExported())
                {
                    continue;
                }

                if (importerSignature.StaticMembers.TryGetValue(kv.Key, out var md))
                {
                    importerSignature.StaticMembers[kv.Key] = AmbiguousMemberDecl.Create(importer, md, kv.Value);
                }
                else
                {
                    // add new
                    importerSignature.StaticMembers.Add(kv.Key, kv.Value);
                }
            }
        }

        public void RegisterByMethod(Function f, TopLevelDeclWithMembers cl)
        {
            Contract.Requires(f != null && f.ByMethodBody != null);

            var tok = f.ByMethodTok;
            var resultVar = f.Result ?? new Formal(tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(232L, "#result"), f.ResultType, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(233L, false), MutateCSharp.Schemata405.ReplaceBooleanConstant_3(234L, false), null);
            var r = Expression.CreateIdentExpr(resultVar);
            // To construct the receiver, we want to know if the function is static or instance. That information is ordinarily computed
            // by f.IsStatic, which looks at f.HasStaticKeyword and f.EnclosingClass. However, at this time, f.EnclosingClass hasn't yet
            // been set. Instead, we compute here directly from f.HasStaticKeyword and "cl".
            var isStatic = MutateCSharp.Schemata405.ReplaceBinExprOp_14(235L, () => f.HasStaticKeyword, () => cl is DefaultClassDecl);
            var receiver = isStatic ? (Expression)new StaticReceiverExpr(tok, cl, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(241L, true)) : new ImplicitThisExpr(tok);
            var fn = new ApplySuffix(tok, null,
              new ExprDotName(tok, receiver, f.Name, f.TypeArgs.ConvertAll(typeParameter => (Type)new UserDefinedType(f.tok, typeParameter))),
              new ActualBindings(f.Ins.ConvertAll(Expression.CreateIdentExpr)).ArgumentBindings,
              tok);
            var post = new AttributedExpression(new BinaryExpr(tok, BinaryExpr.Opcode.Eq, r, fn));
            Specification<FrameExpression> reads;
            if (Options.Get(Method.ReadsClausesOnMethods))
            {
                // If f.Reads is empty, replace it with an explicit `reads {}` so that we don't replace that
                // with the default `reads *` for methods later.
                // Alternatively, we could have a flag similar to InferredDecreases to distinguish between
                // "not given" and "explicitly empty".
                reads = f.Reads;
                if (!reads.Expressions.Any())
                {
                    reads = new Specification<FrameExpression>();
                    var emptySet = new SetDisplayExpr(tok, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(242L, true), new List<Expression>());
                    reads.Expressions.Add(new FrameExpression(tok, emptySet, null));
                }
            }
            else
            {
                reads = new Specification<FrameExpression>();
            }

            var method = new Method(f.RangeToken.MakeAutoGenerated(), new Name(new AutoGeneratedToken(f.NameNode.Tok)), f.HasStaticKeyword, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(243L, false), f.TypeArgs,
              f.Ins, new List<Formal>() { resultVar },
              f.Req, reads, new Specification<FrameExpression>(new List<FrameExpression>(), null), new List<AttributedExpression>() { post }, f.Decreases,
              f.ByMethodBody, f.Attributes, null, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(244L, true));
            Contract.Assert(f.ByMethodDecl == null);
            method.InheritVisibility(f);
            method.FunctionFromWhichThisIsByMethodDecl = f;
            f.ByMethodDecl = method;
        }

        private ModuleSignature MakeAbstractSignature(ModuleSignature p, string name, int height,
          Dictionary<ModuleDefinition, ModuleSignature> mods)
        {
            Contract.Requires(p != null);
            Contract.Requires(name != null);
            Contract.Requires(mods != null);
            var errCount = reporter.Count(ErrorLevel.Error);

            var mod = new ModuleDefinition(RangeToken.NoToken, new Name(name + MutateCSharp.Schemata405.ReplaceStringConstant_6(245L, ".Abs")), new List<IToken>(), ModuleKindEnum.Abstract, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(246L, true), null, null, null);
            mod.Height = height;
            foreach (var kv in p.TopLevels)
            {
                if (!(kv.Value is NonNullTypeDecl or DefaultClassDecl))
                {
                    var clone = CloneDeclaration(p.VisibilityScope, kv.Value, mod, mods, name);
                    mod.SourceDecls.Add(clone);
                }
            }

            var defaultClassDecl = new DefaultClassDecl(mod, p.StaticMembers.Values.ToList());
            mod.DefaultClass = (DefaultClassDecl)CloneDeclaration(p.VisibilityScope, defaultClassDecl, mod, mods, name);

            var sig = mod.RegisterTopLevelDecls(this, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(247L, true));
            sig.Refines = p.Refines;
            sig.IsAbstract = p.IsAbstract;
            mods.Add(mod, sig);
            var good = mod.Resolve(sig, this);
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(253L, () => good, () => MutateCSharp.Schemata405.ReplaceBinExprOp_7(248L, reporter.Count(ErrorLevel.Error), errCount)))
            {
                mod.SuccessfullyResolved = MutateCSharp.Schemata405.ReplaceBooleanConstant_3(259L, true);
            }

            return sig;
        }

        TopLevelDecl CloneDeclaration(VisibilityScope scope, TopLevelDecl d, ModuleDefinition newParent,
          Dictionary<ModuleDefinition, ModuleSignature> mods, string name)
        {
            Contract.Requires(d != null);
            Contract.Requires(newParent != null);
            Contract.Requires(mods != null);
            Contract.Requires(name != null);

            if (d is AbstractModuleDecl abstractDecl)
            {
                var sig = MakeAbstractSignature(abstractDecl.OriginalSignature, name + MutateCSharp.Schemata405.ReplaceStringConstant_6(260L, ".") + abstractDecl.Name, abstractDecl.Height, mods);
                var result = new AbstractModuleDecl(abstractDecl.Options, abstractDecl.RangeToken, abstractDecl.QId, abstractDecl.NameNode,
                  newParent, abstractDecl.Opened, abstractDecl.Exports, Guid.NewGuid())
                {
                    Signature = sig,
                    OriginalSignature = abstractDecl.OriginalSignature
                };
                return result;
            }
            else
            {
                return new AbstractSignatureCloner(scope).CloneDeclaration(d, newParent);
            }

            return default;
        }


        public bool ResolveExport(ModuleDecl alias, ModuleDefinition parent, ModuleQualifiedId qid,
          List<IToken> exports, out ModuleSignature p, ErrorReporter reporter)
        {
            Contract.Requires(qid != null);
            Contract.Requires(qid.Path.Count > 0);
            Contract.Requires(exports != null);

            ModuleDecl decl = qid.ResolveTarget(reporter);
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_26(261L, decl, null))
            {
                p = null;
                return MutateCSharp.Schemata405.ReplaceBooleanConstant_3(262L, false);
            }
            p = decl.Signature;
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(267L, exports.Count, MutateCSharp.Schemata405.ReplaceNumericConstant_1(263L, 0)))
            {
                if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(276L, p.ExportSets.Count, MutateCSharp.Schemata405.ReplaceNumericConstant_1(272L, 0)))
                {
                    if (decl is LiteralModuleDecl)
                    {
                        p = ((LiteralModuleDecl)decl).DefaultExport;
                    }
                    else
                    {
                        // p is OK
                    }
                }
                else
                {
                    var m = p.ExportSets.GetValueOrDefault(decl.Name, null);
                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_12(281L, m, null))
                    {
                        // no default view is specified.
                        reporter.Error(MessageSource.Resolver, qid.RootToken(), MutateCSharp.Schemata405.ReplaceStringConstant_6(282L, "no default export set declared in module: {0}"), decl.Name);
                        return MutateCSharp.Schemata405.ReplaceBooleanConstant_3(283L, false);
                    }
                    p = m.AccessibleSignature();
                }
            }
            else
            {
                ModuleExportDecl pp;
                if (decl.Signature.ExportSets.TryGetValue(exports[MutateCSharp.Schemata405.ReplaceNumericConstant_1(284L, 0)].val, out pp))
                {
                    p = pp.AccessibleSignature();
                }
                else
                {
                    reporter.Error(MessageSource.Resolver, exports[MutateCSharp.Schemata405.ReplaceNumericConstant_1(288L, 0)], MutateCSharp.Schemata405.ReplaceStringConstant_6(292L, "no export set '{0}' in module '{1}'"), exports[MutateCSharp.Schemata405.ReplaceNumericConstant_1(293L, 0)].val, decl.Name);
                    p = null;
                    return MutateCSharp.Schemata405.ReplaceBooleanConstant_3(297L, false);
                }

                foreach (IToken export in exports.Skip(MutateCSharp.Schemata405.ReplaceNumericConstant_1(298L, 1)))
                {
                    if (decl.Signature.ExportSets.TryGetValue(export.val, out pp))
                    {
                        Contract.Assert(Object.ReferenceEquals(p.ModuleDef, pp.Signature.ModuleDef));
                        ModuleSignature merged = MergeSignature(p, pp.Signature);
                        merged.ModuleDef = pp.Signature.ModuleDef;
                        p = merged;
                    }
                    else
                    {
                        reporter.Error(MessageSource.Resolver, export, MutateCSharp.Schemata405.ReplaceStringConstant_6(302L, "no export set {0} in module {1}"), export.val, decl.Name);
                        p = null;
                        return MutateCSharp.Schemata405.ReplaceBooleanConstant_3(303L, false);
                    }
                }
            }
            return MutateCSharp.Schemata405.ReplaceBooleanConstant_3(304L, true);
        }

        public void RevealAllInScope(IEnumerable<TopLevelDecl> declarations, VisibilityScope scope)
        {
            foreach (TopLevelDecl d in declarations)
            {
                d.AddVisibilityScope(scope, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(305L, false));
                if (d is TopLevelDeclWithMembers)
                {
                    var cl = (TopLevelDeclWithMembers)d;
                    foreach (var mem in cl.Members)
                    {
                        if (!mem.ScopeIsInherited)
                        {
                            mem.AddVisibilityScope(scope, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(306L, false));
                        }
                    }
                    var nnd = (cl as ClassLikeDecl)?.NonNullTypeDecl;
                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_19(307L, nnd, null))
                    {
                        nnd.AddVisibilityScope(scope, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(308L, false));
                    }
                }
            }
        }

        public void ResolveTopLevelDecls_Signatures(ModuleDefinition def, ModuleSignature sig, List<TopLevelDecl> declarations,
          Graph<IndDatatypeDecl> datatypeDependencies, Graph<CoDatatypeDecl> codatatypeDependencies)
        {
            Contract.Requires(declarations != null);
            Contract.Requires(datatypeDependencies != null);
            Contract.Requires(codatatypeDependencies != null);
            RevealAllInScope(declarations, def.VisibilityScope);

            /* Augment the scoping environment for the current module*/
            foreach (TopLevelDecl d in declarations)
            {
                if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(309L, () => d is ModuleDecl, () => !(d is ModuleExportDecl)))
                {
                    var decl = (ModuleDecl)d;
                    moduleInfo.VisibilityScope.Augment(decl.AccessibleSignature().VisibilityScope);
                    sig.VisibilityScope.Augment(decl.AccessibleSignature().VisibilityScope);
                }
            }
            /*if (sig.Refines != null) {
              moduleInfo.VisibilityScope.Augment(sig.Refines.VisibilityScope);
              sig.VisibilityScope.Augment(sig.Refines.VisibilityScope);
            }*/

            var typeRedirectionDependencies = new Graph<RedirectingTypeDecl>();  // this concerns the type directions, not their constraints (which are checked for cyclic dependencies later)
            foreach (TopLevelDecl d in declarations)
            {
                Contract.Assert(d != null);
                allTypeParameters.PushMarker();
                ResolveTypeParameters(d.TypeArgs, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(315L, true), d);
                if (d is TypeSynonymDecl)
                {
                    var dd = (TypeSynonymDecl)d;
                    ResolveType(dd.tok, dd.Rhs, dd, ResolveTypeOptionEnum.AllowPrefix, dd.TypeArgs);
                    dd.Rhs.ForeachTypeComponent(ty =>
                    {
                        var s = ty.AsRedirectingType;
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(318L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_27(316L, s, null), () => MutateCSharp.Schemata405.ReplaceBinExprOp_28(317L, s, dd)))
                        {
                            typeRedirectionDependencies.AddEdge(dd, s);
                        }
                    });
                }
                else if (d is NewtypeDecl)
                {
                    var dd = (NewtypeDecl)d;
                    ResolveType(dd.tok, dd.BaseType, dd, ResolveTypeOptionEnum.DontInfer, null);
                    dd.BaseType.ForeachTypeComponent(ty =>
                    {
                        var s = ty.AsRedirectingType;
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(326L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_27(324L, s, null), () => MutateCSharp.Schemata405.ReplaceBinExprOp_29(325L, s, dd)))
                        {
                            typeRedirectionDependencies.AddEdge(dd, s);
                        }
                    });
                    ResolveClassMemberTypes(dd);
                }
                else if (d is IteratorDecl)
                {
                    ResolveIteratorSignature((IteratorDecl)d);
                }
                else if (d is ModuleDecl)
                {
                    var decl = (ModuleDecl)d;
                    if (def.ModuleKind == ModuleKindEnum.Concrete && decl is AliasModuleDecl am && decl.Signature.IsAbstract)
                    {
                        reporter.Error(MessageSource.Resolver, am.TargetQId.RootToken(),
            MutateCSharp.Schemata405.ReplaceStringConstant_6(332L, "a compiled module ({0}) is not allowed to import an abstract module ({1})"), def.Name, am.TargetQId.ToString());
                    }
                }
                else if (d is DatatypeDecl)
                {
                    var dd = (DatatypeDecl)d;
                    ResolveCtorTypes(dd, datatypeDependencies, codatatypeDependencies);
                    ResolveClassMemberTypes(dd);
                }
                else
                {
                    ResolveClassMemberTypes((TopLevelDeclWithMembers)d);
                }
                allTypeParameters.PopMarker();
            }

            // Resolve the parent-trait types and fill in .ParentTraitHeads
            var prevErrorCount = reporter.Count(ErrorLevel.Error);
            var parentRelation = new Graph<TopLevelDeclWithMembers>();
            foreach (TopLevelDecl d in declarations)
            {
                if (d is TopLevelDeclWithMembers cl)
                {
                    ResolveParentTraitTypes(cl, parentRelation);
                }
            }
            // Check for cycles among parent traits
            foreach (var cycle in parentRelation.AllCycles())
            {
                ReportCycleError(reporter, cycle, m => m.tok, m => m.Name, MutateCSharp.Schemata405.ReplaceStringConstant_6(333L, "trait definitions contain a cycle"));
            }
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(334L, prevErrorCount, reporter.Count(ErrorLevel.Error)))
            {
                // check that only reference types (classes and some traits) inherit from 'object'
                foreach (TopLevelDecl d in declarations.Where(d => d is TopLevelDeclWithMembers and not ClassLikeDecl))
                {
                    var nonReferenceTypeDecl = (TopLevelDeclWithMembers)d;
                    foreach (var parentType in nonReferenceTypeDecl.ParentTraits.Where(t => t.IsRefType))
                    {
                        reporter.Error(MessageSource.Resolver, parentType is UserDefinedType parentUdt ? parentUdt.tok : nonReferenceTypeDecl.tok,
                          $"{nonReferenceTypeDecl.WhatKind} is not allowed to extend '{parentType}', because it is a reference type");
                        break; // one error message per "decl" is enough
                    }
                }
            }

            // perform acyclicity test on type synonyms
            foreach (var cycle in typeRedirectionDependencies.AllCycles())
            {
                ReportCycleError(reporter, cycle, rtd => rtd.tok, rtd => rtd.Name, MutateCSharp.Schemata405.ReplaceStringConstant_6(339L, "cycle among redirecting types (newtypes, subset types, type synonyms)"));
            }
        }

        public static readonly List<NativeType> NativeTypes = new List<NativeType>() {
      new NativeType(MutateCSharp.Schemata405.ReplaceStringConstant_6(340L, "byte"), 0, 0x100, MutateCSharp.Schemata405.ReplaceNumericConstant_1(341L, 8), NativeType.Selection.Byte),
      new NativeType(MutateCSharp.Schemata405.ReplaceStringConstant_6(345L, "sbyte"), -0x80, 0x80, MutateCSharp.Schemata405.ReplaceNumericConstant_1(346L, 0), NativeType.Selection.SByte),
      new NativeType(MutateCSharp.Schemata405.ReplaceStringConstant_6(350L, "ushort"), 0, 0x1_0000, MutateCSharp.Schemata405.ReplaceNumericConstant_1(351L, 16), NativeType.Selection.UShort),
      new NativeType(MutateCSharp.Schemata405.ReplaceStringConstant_6(355L, "short"), -0x8000, 0x8000, MutateCSharp.Schemata405.ReplaceNumericConstant_1(356L, 0), NativeType.Selection.Short),
      new NativeType(MutateCSharp.Schemata405.ReplaceStringConstant_6(360L, "uint"), 0, 0x1_0000_0000, MutateCSharp.Schemata405.ReplaceNumericConstant_1(361L, 32), NativeType.Selection.UInt),
      new NativeType(MutateCSharp.Schemata405.ReplaceStringConstant_6(365L, "int"), -0x8000_0000, 0x8000_0000, MutateCSharp.Schemata405.ReplaceNumericConstant_1(366L, 0), NativeType.Selection.Int),
      new NativeType(MutateCSharp.Schemata405.ReplaceStringConstant_6(370L, "number"), -0x1f_ffff_ffff_ffff, 0x20_0000_0000_0000, MutateCSharp.Schemata405.ReplaceNumericConstant_1(371L, 0), NativeType.Selection.Number),  // JavaScript integers
      new NativeType(MutateCSharp.Schemata405.ReplaceStringConstant_6(375L, "ulong"), 0, new BigInteger(MutateCSharp.Schemata405.ReplaceNumericConstant_30(376L, 0x1_0000_0000)) * new BigInteger(MutateCSharp.Schemata405.ReplaceNumericConstant_30(380L, 0x1_0000_0000)), MutateCSharp.Schemata405.ReplaceNumericConstant_1(384L, 64), NativeType.Selection.ULong),
      new NativeType(MutateCSharp.Schemata405.ReplaceStringConstant_6(388L, "long"), Int64.MinValue, 0x8000_0000_0000_0000, MutateCSharp.Schemata405.ReplaceNumericConstant_1(389L, 0), NativeType.Selection.Long),
      new NativeType(MutateCSharp.Schemata405.ReplaceStringConstant_6(393L, "udoublelong"), 0, new BigInteger(MutateCSharp.Schemata405.ReplaceNumericConstant_30(394L, 0x1_0000_0000)) * new BigInteger(MutateCSharp.Schemata405.ReplaceNumericConstant_30(398L, 0x1_0000_0000)) * new BigInteger(MutateCSharp.Schemata405.ReplaceNumericConstant_30(402L, 0x1_0000_0000)) * new BigInteger(MutateCSharp.Schemata405.ReplaceNumericConstant_30(406L, 0x1_0000_0000)), MutateCSharp.Schemata405.ReplaceNumericConstant_1(410L, 128), NativeType.Selection.UDoubleLong),
      new NativeType(MutateCSharp.Schemata405.ReplaceStringConstant_6(414L, "doublelong"), new BigInteger(MutateCSharp.Schemata405.ReplaceNumericConstant_30(415L, -0x8000_0000_0000_0000))* new BigInteger(MutateCSharp.Schemata405.ReplaceNumericConstant_30(419L, 0x1_0000_0000)) * new BigInteger(MutateCSharp.Schemata405.ReplaceNumericConstant_30(423L, 0x1_0000_0000)), new BigInteger(MutateCSharp.Schemata405.ReplaceNumericConstant_31(427L, 0x8000_0000_0000_0000))* new BigInteger(MutateCSharp.Schemata405.ReplaceNumericConstant_30(430L, 0x1_0000_0000)) * new BigInteger(MutateCSharp.Schemata405.ReplaceNumericConstant_30(434L, 0x1_0000_0000)), MutateCSharp.Schemata405.ReplaceNumericConstant_1(438L, 0), NativeType.Selection.DoubleLong),
    };

        public void ResolveTopLevelDecls_Core(List<TopLevelDecl> declarations,
          Graph<IndDatatypeDecl> datatypeDependencies, Graph<CoDatatypeDecl> codatatypeDependencies,
          string moduleDescription, bool isAnExport)
        {

            Contract.Requires(declarations != null);
            Contract.Requires(cce.NonNullElements(datatypeDependencies.GetVertices()));
            Contract.Requires(cce.NonNullElements(codatatypeDependencies.GetVertices()));
            Contract.Requires(AllTypeConstraints.Count == 0);

            Contract.Ensures(AllTypeConstraints.Count == 0);

            int prevErrorCount = reporter.Count(ErrorLevel.Error);

            // ---------------------------------- Pass 0 ----------------------------------
            // This pass:
            // * resolves names, introduces (and may solve) type constraints
            // * checks that all types were properly inferred
            // * fills in .ResolvedOp fields
            // * perform substitution for DefaultValueExpression's
            // ----------------------------------------------------------------------------

            if (Options.Get(CommonOptionBag.TypeSystemRefresh))
            {
                // Resolve all names and infer types.
                PreTypeResolver.ResolveDeclarations(declarations, this);

                if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(442L, reporter.Count(ErrorLevel.Error), prevErrorCount))
                {
                    // Look for any under-specified pre-types, and fill in all .ResolvedOp fields.
                    var u = new UnderspecificationDetector(this);
                    u.Check(declarations);
                }

                if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(447L, reporter.Count(ErrorLevel.Error), prevErrorCount))
                {
                    var preType2TypeVisitor = new PreTypeToTypeVisitor(SystemModuleManager);
                    preType2TypeVisitor.VisitConstantsAndRedirectingTypes(declarations);
                    preType2TypeVisitor.VisitDeclarations(declarations);
                }

                if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(452L, reporter.Count(ErrorLevel.Error), prevErrorCount))
                {
                    var typeAdjustor = new TypeRefinementVisitor(moduleDescription, SystemModuleManager);
                    typeAdjustor.VisitDeclarations(declarations);
                    typeAdjustor.Solve(reporter, Options.Get(CommonOptionBag.NewTypeInferenceDebug));
                }

            }
            else
            {
                InheritMembers(declarations);

                // Resolve all names and infer types. These two are done together, because name resolution depends on having type information
                // and type inference depends on having resolved names.
                // The task is first performed for (the constraints of) newtype declarations, (the constraints of) subset type declarations, and
                // (the right-hand sides of) const declarations, because type resolution sometimes needs to know the base type of newtypes and subset types
                // and needs to know the type of const fields. Doing these declarations increases the chances the right information will be provided
                // in time.
                // Once the task is done for these newtype/subset-type/const parts, the task continues with everything else.
                ResolveNamesAndInferTypes(declarations, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(457L, true));
                ResolveNamesAndInferTypes(declarations, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(458L, false));
            }

            // Check that all types have been determined. During this process, also fill in all .ResolvedOp fields.
            // Note, in the type system refresh, it can happen that the under-specification detector above finds all pre-types to
            // be specified, whereas some (necessarily unused) type arguments are still underspecified. Such will be caught by the
            // CheckTypeInferenceVisitor. (But CheckTypeInferenceVisitor could, for the type system refresh, be modified to
            // not bother setting .ResolvedOp fields, since the under-specification detector above has already set those.)
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(459L, reporter.Count(ErrorLevel.Error), prevErrorCount))
            {
                var checkTypeInferenceVisitor = new CheckTypeInferenceVisitor(this);
                checkTypeInferenceVisitor.VisitDeclarations(declarations);
            }

            // Substitute for DefaultValueExpression's
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(464L, reporter.Count(ErrorLevel.Error), prevErrorCount))
            {
                FillInDefaultValueExpressions();
            }

            // ---------------------------------- Pass 1 ----------------------------------
            // This pass does the following:
            // * desugar functions used in reads clauses
            // * fills in "reads *" clauses on methods, when --reads-clauses-on-methods is used
            // * compute .BodySurrogate for body-less loops
            // * discovers bounds
            // * builds the module's call graph.
            // * compute and checks ghosts (this makes use of bounds discovery, as done above)
            // * for newtypes, figure out native types
            // * for datatypes, check that shared destructors are in agreement in ghost matters
            // * for methods, check that any reads clause is used correctly
            // * for functions and methods, determine tail recursion
            // ----------------------------------------------------------------------------

            // Discover bounds. These are needed later to determine if certain things are ghost or compiled,
            // and thus this should be done before building the call graph.
            // The BoundsDiscoveryVisitor also desugars FrameExpressions, so that bounds discovery can
            // apply to the desugared versions.
            // This pass also computes body surrogates for body-less loops, which is a bit like desugaring
            // such loops.
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(469L, reporter.Count(ErrorLevel.Error), prevErrorCount))
            {
                var boundsDiscoveryVisitor = new BoundsDiscoveryVisitor(this);
                boundsDiscoveryVisitor.VisitDeclarations(declarations);
            }

            if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(479L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_7(474L, reporter.Count(ErrorLevel.Error), prevErrorCount), () => Options.Get(Method.ReadsClausesOnMethods)))
            {
                // Set the default of `reads *` if reads clauses on methods is enabled and this isn't a lemma.
                // Note that `reads *` is the right default for backwards-compatibility,
                // but we may want to infer a sensible default like decreases clauses instead in the future.
                foreach (var declaration in ModuleDefinition.AllCallables(declarations))
                {
                    if (declaration is Method { IsLemmaLike: false, Reads: { Expressions: var readsExpressions } } method &&
                        !readsExpressions.Any())
                    {
                        var star = new FrameExpression(method.tok, new WildcardExpr(method.tok) { Type = SystemModuleManager.ObjectSetType() }, null);
                        readsExpressions.Add(star);
                    }
                }
            }

            if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(485L, reporter.Count(ErrorLevel.Error), prevErrorCount))
            {
                CallGraphBuilder.Build(declarations, reporter);
            }

            // The call graph hasn't been completely constructed, because it's missing the edges having to do with
            // extreme predicates/lemmas. However, figuring out whether or not constraints are compilable depends on
            // there being no cycles in the call graph. Therefore, we do an initial check for cycles at this time.
            var cycleErrorHasBeenReported = new HashSet<ICallable>();
            foreach (var decl in declarations)
            {
                if (decl is RedirectingTypeDecl dd)
                {
                    CheckForCyclesAmongRedirectingTypes(dd, cycleErrorHasBeenReported);
                }
            }

            // Compute ghost interests, figure out native types, check agreement among datatype destructors, and determine tail calls.
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(490L, reporter.Count(ErrorLevel.Error), prevErrorCount))
            {
                foreach (TopLevelDecl d in declarations)
                {
                    if (d is IteratorDecl)
                    {
                        var iter = (IteratorDecl)d;
                        iter.SubExpressions.ForEach(e => CheckExpression(e, this, iter));
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_32(495L, iter.Body, null))
                        {
                            CheckExpression(iter.Body, this, iter);
                        }

                    }
                    else if (d is SubsetTypeDecl subsetTypeDecl)
                    {
                        Contract.Assert(subsetTypeDecl.Constraint != null);
                        CheckExpression(subsetTypeDecl.Constraint, this, new CodeContextWrapper(subsetTypeDecl, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(496L, true)));

                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_33(497L, subsetTypeDecl.Witness, null))
                        {
                            CheckExpression(subsetTypeDecl.Witness, this,
                              new CodeContextWrapper(subsetTypeDecl, MutateCSharp.Schemata405.ReplaceBinExprOp_34(498L, subsetTypeDecl.WitnessKind, SubsetTypeDecl.WKind.Ghost)));
                            if (MutateCSharp.Schemata405.ReplaceBinExprOp_34(499L, subsetTypeDecl.WitnessKind, SubsetTypeDecl.WKind.Compiled))
                            {
                                var codeContext = new CodeContextWrapper(subsetTypeDecl, MutateCSharp.Schemata405.ReplaceBinExprOp_34(500L, subsetTypeDecl.WitnessKind, SubsetTypeDecl.WKind.Ghost));
                                ExpressionTester.CheckIsCompilable(Options, this, subsetTypeDecl.Witness, codeContext);
                            }
                        }

                    }
                    else if (d is NewtypeDecl newtypeDecl)
                    {
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_35(501L, newtypeDecl.Var, null))
                        {
                            Contract.Assert(newtypeDecl.Constraint != null);
                            CheckExpression(newtypeDecl.Constraint, this, new CodeContextWrapper(newtypeDecl, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(502L, true)));
                        }

                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_33(503L, newtypeDecl.Witness, null))
                        {
                            CheckExpression(newtypeDecl.Witness, this, new CodeContextWrapper(newtypeDecl, MutateCSharp.Schemata405.ReplaceBinExprOp_34(504L, newtypeDecl.WitnessKind, SubsetTypeDecl.WKind.Ghost)));
                            if (MutateCSharp.Schemata405.ReplaceBinExprOp_34(505L, newtypeDecl.WitnessKind, SubsetTypeDecl.WKind.Compiled))
                            {
                                var codeContext = new CodeContextWrapper(newtypeDecl, MutateCSharp.Schemata405.ReplaceBinExprOp_34(506L, newtypeDecl.WitnessKind, SubsetTypeDecl.WKind.Ghost));
                                ExpressionTester.CheckIsCompilable(Options, this, newtypeDecl.Witness, codeContext);
                            }
                        }

                        new NativeTypeAnalysis(reporter).FigureOutNativeType(newtypeDecl, Options);

                    }
                    else if (d is DatatypeDecl)
                    {
                        var dd = (DatatypeDecl)d;
                        foreach (var member in GetClassMembers(dd)!.Values)
                        {
                            var dtor = member as DatatypeDestructor;
                            if (MutateCSharp.Schemata405.ReplaceBinExprOp_36(507L, dtor, null))
                            {
                                var rolemodel = dtor.CorrespondingFormals[MutateCSharp.Schemata405.ReplaceNumericConstant_1(508L, 0)];
                                for (int i = MutateCSharp.Schemata405.ReplaceNumericConstant_1(512L, 1); MutateCSharp.Schemata405.ReplaceBinExprOp_37(516L, i, dtor.CorrespondingFormals.Count); MutateCSharp.Schemata405.ReplacePostfixUnaryExprOp_38(521L, ref i))
                                {
                                    var other = dtor.CorrespondingFormals[i];
                                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_39(522L, () => rolemodel.IsGhost, () => other.IsGhost))
                                    {
                                        reporter.Error(MessageSource.Resolver, other,
                    MutateCSharp.Schemata405.ReplaceStringConstant_6(528L, "shared destructors must agree on whether or not they are ghost, but '{0}' is {1} in constructor '{2}' and {3} in constructor '{4}'"),
                                          rolemodel.Name,
                                          rolemodel.IsGhost ? MutateCSharp.Schemata405.ReplaceStringConstant_6(529L, "ghost") : MutateCSharp.Schemata405.ReplaceStringConstant_6(530L, "non-ghost"), dtor.EnclosingCtors[MutateCSharp.Schemata405.ReplaceNumericConstant_1(531L, 0)].Name,
                                          other.IsGhost ? MutateCSharp.Schemata405.ReplaceStringConstant_6(535L, "ghost") : MutateCSharp.Schemata405.ReplaceStringConstant_6(536L, "non-ghost"), dtor.EnclosingCtors[i].Name);
                                    }
                                }
                            }
                        }
                        foreach (var ctor in dd.Ctors)
                        {
                            CheckParameterDefaultValuesAreCompilable(ctor.Formals, dd);
                        }
                    }
                }

                AnalyzeTypeConstraints.AssignConstraintIsCompilable(declarations, Options);

                // Now that we have filled in the .ConstraintIsCompilable field of all subset types and newtypes, we're ready to
                // visit iterator bodies and members (which will make calls to CheckIsCompilable).
                foreach (TopLevelDecl d in declarations)
                {
                    if (d is IteratorDecl { Body: { } iterBody } iter)
                    {
                        ComputeGhostInterest(iter.Body, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(537L, false), null, iter);
                    }
                    if (d is TopLevelDeclWithMembers cl)
                    {
                        ResolveClassMembers_Pass1(cl);
                    }
                }
            }

            // ---------------------------------- Pass 2 ----------------------------------
            // This pass fills in various additional information.
            // * Subset type in comprehensions have a compilable constraint 
            // * Postconditions and bodies of prefix lemmas
            // * Compute postconditions and statement body of prefix lemmas
            // * Perform the stratosphere check on inductive datatypes, and compute to what extent the inductive datatypes require equality support
            // * Set the SccRepr field of codatatypes
            // * Perform the guardedness check on co-datatypes
            // * Do datatypes and type synonyms until a fixpoint is reached, same for functions and methods	
            // * Check that functions claiming to be abstemious really are
            // * Check that all == and != operators in non-ghost contexts are applied to equality-supporting types.
            // * Extreme predicate recursivity checks
            // * Verify that subset constraints are compilable if necessary
            // ----------------------------------------------------------------------------

            if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(538L, reporter.Count(ErrorLevel.Error), prevErrorCount))
            {
                // fill in the postconditions and bodies of prefix lemmas
                FillInPostConditionsAndBodiesOfPrefixLemmas(declarations);
            }

            // An inductive datatype is allowed to be defined as an empty type. For example, in
            //     predicate P(x: int) { false }
            //     type Subset = x: int | P(x) witness *
            //     datatype Record = Record(Subset)
            // Record is an empty type, because Subset is, since P(x) is always false. But if P(x)
            // was instead defined to be true for some x's, then Record would be nonempty. Determining whether or
            // not Record is empty goes well beyond the syntactic checks of the type system.
            //
            // However, if a datatype is empty because of some "obvious" cycle among datatype definitions, then
            // that is both detectable by syntactic checks and likely unintended by the programmer. Therefore,
            // we search for such type declarations and give error messages if something is found.
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(543L, reporter.Count(ErrorLevel.Error), prevErrorCount))
            {
                foreach (var dtd in declarations.ConvertAll(decl => decl as IndDatatypeDecl).Where(dtd => MutateCSharp.Schemata405.ReplaceBinExprOp_4(558L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_40(548L, dtd, null), () => MutateCSharp.Schemata405.ReplaceBinExprOp_20(553L, dtd.Ctors.Count, MutateCSharp.Schemata405.ReplaceNumericConstant_1(549L, 0)))))
                {
                    if (AreThereAnyObviousSignsOfEmptiness(UserDefinedType.FromTopLevelDecl(dtd.tok, dtd), new HashSet<IndDatatypeDecl>()))
                    {
                        reporter.Warning(MessageSource.Resolver, ResolutionErrors.ErrorId.r_empty_cyclic_datatype, dtd.tok,
                          $"because of cyclic dependencies among constructor argument types, no instances of datatype '{dtd.Name}' can be constructed");
                    }
                }
            }

            // Perform the stratosphere check on inductive datatypes, and compute to what extent the inductive datatypes require equality support
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(564L, reporter.Count(ErrorLevel.Error), prevErrorCount))
            { // because SccStratosphereCheck depends on subset-type/newtype base types being successfully resolved
                foreach (var dtd in datatypeDependencies.TopologicallySortedComponents())
                {
                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_41(569L, datatypeDependencies.GetSCCRepresentative(dtd), dtd))
                    {
                        // do the following check once per SCC, so call it on each SCC representative
                        SccStratosphereCheck(dtd, datatypeDependencies);
                        DetermineEqualitySupport(dtd, datatypeDependencies);
                    }
                }
            }

            // Set the SccRepr field of codatatypes
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(570L, reporter.Count(ErrorLevel.Error), prevErrorCount))
            {
                foreach (var repr in codatatypeDependencies.TopologicallySortedComponents())
                {
                    foreach (var codt in codatatypeDependencies.GetSCC(repr))
                    {
                        codt.SscRepr = repr;
                    }
                }
            }

            if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(575L, reporter.Count(ErrorLevel.Error), prevErrorCount))
            {  // because CheckCoCalls requires the given expression to have been successfully resolved
               // Perform the guardedness check on co-datatypes
                foreach (var repr in ModuleDefinition.AllFunctionSCCs(declarations))
                {
                    var module = repr.EnclosingModule;
                    bool dealsWithCodatatypes = MutateCSharp.Schemata405.ReplaceBooleanConstant_3(580L, false);
                    foreach (var m in module.CallGraph.GetSCC(repr))
                    {
                        var f = m as Function;
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(582L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_42(581L, f, null), () => f.ResultType.InvolvesCoDatatype))
                        {
                            dealsWithCodatatypes = MutateCSharp.Schemata405.ReplaceBooleanConstant_3(588L, true);
                            break;
                        }
                    }
                    var coCandidates = new List<CoCallResolution.CoCallInfo>();
                    var hasIntraClusterCallsInDestructiveContexts = MutateCSharp.Schemata405.ReplaceBooleanConstant_3(589L, false);
                    foreach (var m in module.CallGraph.GetSCC(repr))
                    {
                        var f = m as Function;
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(592L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_42(590L, f, null), () => MutateCSharp.Schemata405.ReplaceBinExprOp_33(591L, f.Body, null)))
                        {
                            var checker = new CoCallResolution(f, dealsWithCodatatypes);
                            checker.CheckCoCalls(f.Body);
                            coCandidates.AddRange(checker.FinalCandidates);
                            hasIntraClusterCallsInDestructiveContexts |= checker.HasIntraClusterCallsInDestructiveContexts;
                        }
                        else if (MutateCSharp.Schemata405.ReplaceBinExprOp_43(598L, f, null))
                        {
                            // the SCC contains a method, which we always consider to be a destructive context
                            hasIntraClusterCallsInDestructiveContexts = MutateCSharp.Schemata405.ReplaceBooleanConstant_3(599L, true);
                        }
                    }
                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_20(604L, coCandidates.Count, MutateCSharp.Schemata405.ReplaceNumericConstant_1(600L, 0)))
                    {
                        if (hasIntraClusterCallsInDestructiveContexts)
                        {
                            foreach (var c in coCandidates)
                            {
                                c.CandidateCall.CoCall = FunctionCallExpr.CoCallResolution.NoBecauseRecursiveCallsInDestructiveContext;
                            }
                        }
                        else
                        {
                            foreach (var c in coCandidates)
                            {
                                c.CandidateCall.CoCall = FunctionCallExpr.CoCallResolution.Yes;
                                c.EnclosingCoConstructor.IsCoCall = MutateCSharp.Schemata405.ReplaceBooleanConstant_3(609L, true);
                                reporter.Info(MessageSource.Resolver, c.CandidateCall.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(610L, "co-recursive call"));
                            }
                            // Finally, fill in the CoClusterTarget field
                            // Start by setting all the CoClusterTarget fields to CoRecursiveTargetAllTheWay.
                            foreach (var m in module.CallGraph.GetSCC(repr))
                            {
                                var f = (Function)m;  // the cast is justified on account of that we allow co-recursive calls only in clusters that have no methods at all
                                f.CoClusterTarget = Function.CoCallClusterInvolvement.CoRecursiveTargetAllTheWay;
                            }
                            // Then change the field to IsMutuallyRecursiveTarget whenever we see a non-self recursive non-co-recursive call
                            foreach (var m in module.CallGraph.GetSCC(repr))
                            {
                                var f = (Function)m;  // cast is justified just like above
                                foreach (var call in f.AllCalls)
                                {
                                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(619L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_4(613L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_44(611L, call.CoCall, FunctionCallExpr.CoCallResolution.Yes), () => MutateCSharp.Schemata405.ReplaceBinExprOp_45(612L, call.Function, f)), () => ModuleDefinition.InSameSCC(f, call.Function)))
                                    {
                                        call.Function.CoClusterTarget = Function.CoCallClusterInvolvement.IsMutuallyRecursiveTarget;
                                    }
                                }
                            }
                        }
                    }
                }

                TypeCharacteristicChecker.InferAndCheck(declarations, isAnExport, reporter);

                // Check that functions claiming to be abstemious really are, and check that 'older' parameters are used only when allowed
                foreach (var fn in ModuleDefinition.AllFunctions(declarations))
                {
                    new Abstemious(reporter).Check(fn);
                    CheckOlderParameters(fn);
                }

                // Check that extreme predicates are not recursive with non-extreme-predicate functions (and only
                // with extreme predicates of the same polarity), and
                // check that greatest lemmas are not recursive with non-greatest-lemma methods.
                // Also, check that the constraints of newtypes/subset-types do not depend on the type itself.
                // And check that const initializers are not cyclic.
                foreach (var d in declarations)
                {
                    if (d is TopLevelDeclWithMembers { Members: var members })
                    {
                        foreach (var member in members)
                        {
                            if (member is ExtremePredicate)
                            {
                                var fn = (ExtremePredicate)member;
                                // Check here for the presence of any 'ensures' clauses, which are not allowed (because we're not sure
                                // of their soundness)
                                fn.Req.ForEach(e => ExtremePredicateChecks(e.E, fn, CallingPosition.Positive));
                                fn.Decreases.Expressions.ForEach(e => ExtremePredicateChecks(e, fn, CallingPosition.Positive));
                                fn.Reads.Expressions.ForEach(e => ExtremePredicateChecks(e.E, fn, CallingPosition.Positive));
                                if (MutateCSharp.Schemata405.ReplaceBinExprOp_20(629L, fn.Ens.Count, MutateCSharp.Schemata405.ReplaceNumericConstant_1(625L, 0)))
                                {
                                    reporter.Error(MessageSource.Resolver, fn.Ens[MutateCSharp.Schemata405.ReplaceNumericConstant_1(634L, 0)].E.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(638L, "a {0} is not allowed to declare any ensures clause"), member.WhatKind);
                                }
                                if (MutateCSharp.Schemata405.ReplaceBinExprOp_33(639L, fn.Body, null))
                                {
                                    ExtremePredicateChecks(fn.Body, fn, CallingPosition.Positive);
                                }
                            }
                            else if (member is ExtremeLemma)
                            {
                                var m = (ExtremeLemma)member;
                                m.Req.ForEach(e => ExtremeLemmaChecks(e.E, m));
                                m.Ens.ForEach(e => ExtremeLemmaChecks(e.E, m));
                                m.Decreases.Expressions.ForEach(e => ExtremeLemmaChecks(e, m));

                                if (MutateCSharp.Schemata405.ReplaceBinExprOp_32(640L, m.Body, null))
                                {
                                    ExtremeLemmaChecks(m.Body, m);
                                }
                            }
                            else if (member is ConstantField)
                            {
                                var cf = (ConstantField)member;
                                if (MutateCSharp.Schemata405.ReplaceBinExprOp_20(645L, cf.EnclosingModule.CallGraph.GetSCCSize(cf), MutateCSharp.Schemata405.ReplaceNumericConstant_1(641L, 1)))
                                {
                                    var r = cf.EnclosingModule.CallGraph.GetSCCRepresentative(cf);
                                    if (cycleErrorHasBeenReported.Contains(r))
                                    {
                                        // An error has already been reported for this cycle, so don't report another.
                                        // Note, the representative, "r", may itself not be a const.
                                    }
                                    else
                                    {
                                        ReportCallGraphCycleError(cf, MutateCSharp.Schemata405.ReplaceStringConstant_6(650L, "const definition contains a cycle"));
                                        cycleErrorHasBeenReported.Add(r);
                                    }
                                }
                            }
                        }
                    }

                    if (d is RedirectingTypeDecl dd)
                    {
                        CheckForCyclesAmongRedirectingTypes(dd, cycleErrorHasBeenReported);
                    }
                }
            }

            // ---------------------------------- Pass 3 ----------------------------------
            // Further checks
            // ----------------------------------------------------------------------------

            if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(651L, reporter.Count(ErrorLevel.Error), prevErrorCount))
            {
                // Check that type-parameter variance is respected in type definitions
                foreach (TopLevelDecl d in declarations)
                {
                    if (d is ClassLikeDecl)
                    {
                        foreach (var tp in d.TypeArgs)
                        {
                            if (MutateCSharp.Schemata405.ReplaceBinExprOp_46(656L, tp.Variance, TypeParameter.TPVariance.Non))
                            {
                                reporter.Error(MessageSource.Resolver, tp.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(657L, "{0} declarations only support non-variant type parameters"), d.WhatKind);
                            }
                        }
                    }
                    else if (d is TypeSynonymDecl)
                    {
                        var dd = (TypeSynonymDecl)d;
                        CheckVariance(dd.Rhs, dd, TypeParameter.TPVariance.Co, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(658L, false));
                    }
                    else if (d is NewtypeDecl)
                    {
                        var dd = (NewtypeDecl)d;
                        CheckVariance(dd.BaseType, dd, TypeParameter.TPVariance.Co, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(659L, false));
                    }
                    else if (d is DatatypeDecl)
                    {
                        var dd = (DatatypeDecl)d;
                        foreach (var ctor in dd.Ctors)
                        {
                            ctor.Formals.ForEach(formal => CheckVariance(formal.Type, dd, TypeParameter.TPVariance.Co, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(660L, false)));
                        }
                    }

                    if (d is TopLevelDeclWithMembers topLevelDeclWithMembers)
                    {
                        foreach (var parentTrait in topLevelDeclWithMembers.ParentTraits)
                        {
                            CheckVariance(parentTrait, topLevelDeclWithMembers, TypeParameter.TPVariance.Co, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(661L, false));
                        }
                    }
                }
            }

            if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(662L, reporter.Count(ErrorLevel.Error), prevErrorCount))
            {
                // Check that class constructors are called when required.
                new ObjectConstructorChecker(reporter).VisitDeclarations(declarations);
            }

            if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(667L, reporter.Count(ErrorLevel.Error), prevErrorCount))
            {
                new HigherOrderHeapAllocationChecker(reporter).VisitDeclarations(declarations);
            }

            if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(672L, reporter.Count(ErrorLevel.Error), prevErrorCount))
            {
                new HigherOrderHeapAllocationCheckerConstructor(reporter).VisitDeclarations(declarations);
            }

            if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(677L, reporter.Count(ErrorLevel.Error), prevErrorCount))
            {
                new CheckMapRangeSupportsEquality(reporter).VisitDeclarations(declarations);
            }

            if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(682L, reporter.Count(ErrorLevel.Error), prevErrorCount))
            {
                // Check that usage of "this" is restricted before "new;" in constructor bodies,
                // and that a class without any constructor only has fields with known initializers.
                // Also check that static fields (which are necessarily const) have initializers.
                var cdci = new CheckDividedConstructorInit_Visitor(reporter);
                foreach (var cl in ModuleDefinition.AllTypesWithMembers(declarations))
                {
                    // only reference types (classes and reference-type traits) are allowed to declare mutable fields
                    if (cl is not ClassLikeDecl { IsReferenceTypeDecl: true })
                    {
                        foreach (var member in cl.Members.Where(member => member is Field and not SpecialField))
                        {
                            var traitHint = cl is TraitDecl ? MutateCSharp.Schemata405.ReplaceStringConstant_6(687L, " or declaring the trait with 'extends object'") : "";
                            reporter.Error(MessageSource.Resolver, member,
                              $"mutable fields are allowed only in reference types (consider declaring the field as a 'const'{traitHint})");
                        }
                    }

                    if (cl is not ClassLikeDecl)
                    {
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(689L, () => !isAnExport, () => MutateCSharp.Schemata405.ReplaceBinExprOp_47(688L, cl.EnclosingModuleDefinition.ModuleKind, ModuleKindEnum.Concrete)))
                        {
                            // non-reference, non-trait types (datatype, newtype, opaque) don't have constructors that can initialize fields
                            foreach (var member in cl.Members)
                            {
                                if (member is ConstantField f && f.Rhs == null && !f.IsExtern(Options, out _, out _))
                                {
                                    CheckIsOkayWithoutRHS(f, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(695L, false));
                                }
                            }
                        }
                        continue;
                    }
                    if (cl is TraitDecl traitDecl)
                    {
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(697L, () => !isAnExport, () => MutateCSharp.Schemata405.ReplaceBinExprOp_47(696L, cl.EnclosingModuleDefinition.ModuleKind, ModuleKindEnum.Concrete)))
                        {
                            // check for static consts, and check for instance fields in non-reference traits
                            foreach (var member in cl.Members)
                            {
                                if (member is ConstantField f && f.Rhs == null && !f.IsExtern(Options, out _, out _))
                                {
                                    if (f.IsStatic)
                                    {
                                        CheckIsOkayWithoutRHS(f, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(703L, false));
                                    }
                                    else if (!traitDecl.IsReferenceTypeDecl)
                                    {
                                        CheckIsOkayWithoutRHS(f, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(704L, true));
                                    }
                                }
                            }
                        }
                        continue;
                    }

                    var hasConstructor = MutateCSharp.Schemata405.ReplaceBooleanConstant_3(705L, false);
                    Field fieldWithoutKnownInitializer = null;
                    foreach (var member in cl.Members)
                    {
                        if (member is Constructor)
                        {
                            hasConstructor = MutateCSharp.Schemata405.ReplaceBooleanConstant_3(706L, true);
                            var constructor = (Constructor)member;
                            if (MutateCSharp.Schemata405.ReplaceBinExprOp_48(707L, constructor.BodyInit, null))
                            {
                                cdci.CheckInit(constructor.BodyInit);
                            }
                        }
                        else if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(708L, () => member is ConstantField, () => member.IsStatic))
                        {
                            var f = (ConstantField)member;
                            if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(722L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_4(715L, () => !isAnExport, () => MutateCSharp.Schemata405.ReplaceBinExprOp_47(714L, cl.EnclosingModuleDefinition.ModuleKind, ModuleKindEnum.Concrete)), () => MutateCSharp.Schemata405.ReplaceBinExprOp_49(721L, f.Rhs, null)) && !f.IsExtern(Options, out _, out _))
                            {
                                CheckIsOkayWithoutRHS(f, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(728L, false));
                            }
                        }
                        else if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(730L, () => member is Field, () => MutateCSharp.Schemata405.ReplaceBinExprOp_50(729L, fieldWithoutKnownInitializer, null)))
                        {
                            var f = (Field)member;
                            if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(737L, () => f is ConstantField, () => MutateCSharp.Schemata405.ReplaceBinExprOp_33(736L, ((ConstantField)f).Rhs, null)))
                            {
                                // fine
                            }
                            else if (!f.Type.KnownToHaveToAValue(f.IsGhost))
                            {
                                fieldWithoutKnownInitializer = f;
                            }
                        }
                    }
                    if (!hasConstructor)
                    {
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_50(743L, fieldWithoutKnownInitializer, null))
                        {
                            // time to check inherited members
                            foreach (var member in cl.InheritedMembers)
                            {
                                if (member is Field)
                                {
                                    var f = (Field)member;
                                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(745L, () => f is ConstantField, () => MutateCSharp.Schemata405.ReplaceBinExprOp_33(744L, ((ConstantField)f).Rhs, null)))
                                    {
                                        // fine
                                    }
                                    else if (!f.Type.Subst(cl.ParentFormalTypeParametersToActuals).KnownToHaveToAValue(f.IsGhost))
                                    {
                                        fieldWithoutKnownInitializer = f;
                                        break;
                                    }
                                }
                            }
                        }
                        // go through inherited members...
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_51(751L, fieldWithoutKnownInitializer, null))
                        {
                            reporter.Error(MessageSource.Resolver, cl.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(752L, "class '{0}' with fields without known initializers, like '{1}' of type '{2}', must declare a constructor"),
                              cl.Name, fieldWithoutKnownInitializer.Name, fieldWithoutKnownInitializer.Type.Subst(cl.ParentFormalTypeParametersToActuals));
                        }
                    }
                }
            }

            if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(753L, reporter.Count(ErrorLevel.Error), prevErrorCount))
            {
                // Verifies that, in all compiled places, subset types in comprehensions have a compilable constraint
                new SubsetConstraintGhostChecker(this.Reporter).Traverse(declarations);
            }
        }

        private void CheckForCyclesAmongRedirectingTypes(RedirectingTypeDecl dd, HashSet<ICallable> cycleErrorHasBeenReported)
        {
            var enclosingModule = dd.EnclosingModule;
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_20(762L, enclosingModule.CallGraph.GetSCCSize(dd), MutateCSharp.Schemata405.ReplaceNumericConstant_1(758L, 1)))
            {
                var r = enclosingModule.CallGraph.GetSCCRepresentative(dd);
                if (cycleErrorHasBeenReported.Contains(r))
                {
                    // An error has already been reported for this cycle, so don't report another.
                    // Note, the representative, "r", may itself not be a const.
                }
                else if (dd is NewtypeDecl or SubsetTypeDecl)
                {
                    ReportCallGraphCycleError(dd, $"recursive constraint dependency involving a {dd.WhatKind}");
                    cycleErrorHasBeenReported.Add(r);
                }
            }
        }

        private void FillInPostConditionsAndBodiesOfPrefixLemmas(List<TopLevelDecl> declarations)
        {
            foreach (var com in ModuleDefinition.AllExtremeLemmas(declarations))
            {
                var prefixLemma = com.PrefixLemma;
                if (MutateCSharp.Schemata405.ReplaceBinExprOp_52(767L, prefixLemma, null))
                {
                    continue; // something went wrong during registration of the prefix lemma (probably a duplicated extreme lemma name)
                }

                var k = prefixLemma.Ins[MutateCSharp.Schemata405.ReplaceNumericConstant_1(768L, 0)];
                var focalPredicates = new HashSet<ExtremePredicate>();
                if (com is GreatestLemma)
                {
                    // compute the postconditions of the prefix lemma
                    Contract.Assume(prefixLemma.Ens.Count == 0); // these are not supposed to have been filled in before
                    foreach (var p in com.Ens)
                    {
                        var coConclusions = new HashSet<Expression>();
                        CollectFriendlyCallsInExtremeLemmaSpecification(p.E, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(772L, true), coConclusions, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(773L, true), com);
                        var subst = new ExtremeLemmaSpecificationSubstituter(coConclusions, new IdentifierExpr(k.tok, k.Name),
                          this.reporter, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(774L, true));
                        var post = subst.CloneExpr(p.E);
                        prefixLemma.Ens.Add(new AttributedExpression(post));
                        foreach (var e in coConclusions)
                        {
                            var fce = e as FunctionCallExpr;
                            if (MutateCSharp.Schemata405.ReplaceBinExprOp_53(775L, fce, null))
                            {
                                // the other possibility is that "e" is a BinaryExpr
                                GreatestPredicate predicate = (GreatestPredicate)fce.Function;
                                focalPredicates.Add(predicate);
                                // For every focal predicate P in S, add to S all greatest predicates in the same strongly connected
                                // component (in the call graph) as P
                                foreach (var node in predicate.EnclosingClass.EnclosingModuleDefinition.CallGraph.GetSCC(
                                           predicate))
                                {
                                    if (node is GreatestPredicate)
                                    {
                                        focalPredicates.Add((GreatestPredicate)node);
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    // compute the preconditions of the prefix lemma
                    Contract.Assume(prefixLemma.Req.Count == 0); // these are not supposed to have been filled in before
                    foreach (var p in com.Req)
                    {
                        var antecedents = new HashSet<Expression>();
                        CollectFriendlyCallsInExtremeLemmaSpecification(p.E, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(776L, true), antecedents, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(777L, false), com);
                        var subst = new ExtremeLemmaSpecificationSubstituter(antecedents, new IdentifierExpr(k.tok, k.Name),
                          this.reporter, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(778L, false));
                        var pre = subst.CloneExpr(p.E);
                        prefixLemma.Req.Add(new AttributedExpression(pre, p.Label, null));
                        foreach (var e in antecedents)
                        {
                            var fce = (FunctionCallExpr)e; // we expect "antecedents" to contain only FunctionCallExpr's
                            LeastPredicate predicate = (LeastPredicate)fce.Function;
                            focalPredicates.Add(predicate);
                            // For every focal predicate P in S, add to S all least predicates in the same strongly connected
                            // component (in the call graph) as P
                            foreach (var node in predicate.EnclosingClass.EnclosingModuleDefinition.CallGraph.GetSCC(predicate))
                            {
                                if (node is LeastPredicate)
                                {
                                    focalPredicates.Add((LeastPredicate)node);
                                }
                            }
                        }
                    }
                }

                reporter.Info(MessageSource.Resolver, com.tok,
        MutateCSharp.Schemata405.ReplaceBinExprOp_7(783L, focalPredicates.Count, MutateCSharp.Schemata405.ReplaceNumericConstant_1(779L, 0
        )) ? $"{com.PrefixLemma.Name} has no focal predicates"
                    : $"{com.PrefixLemma.Name} with focal predicate{Util.Plural(focalPredicates.Count)} {Util.Comma(focalPredicates, p => p.Name)}");
                // Compute the statement body of the prefix lemma
                Contract.Assume(prefixLemma.Body == null); // this is not supposed to have been filled in before
                if (MutateCSharp.Schemata405.ReplaceBinExprOp_32(788L, com.Body, null))
                {
                    var kMinusOne = new BinaryExpr(com.tok, BinaryExpr.Opcode.Sub, new IdentifierExpr(k.tok, k.Name),
                      new LiteralExpr(com.tok, MutateCSharp.Schemata405.ReplaceNumericConstant_1(789L, 1)));
                    var subst = new ExtremeLemmaBodyCloner(com, kMinusOne, focalPredicates, this.reporter);
                    var mainBody = subst.CloneBlockStmt(com.Body);
                    Expression kk;
                    Statement els;
                    if (k.Type.IsBigOrdinalType)
                    {
                        kk = new MemberSelectExpr(k.tok, new IdentifierExpr(k.tok, k.Name), MutateCSharp.Schemata405.ReplaceStringConstant_6(793L, "Offset"));
                        // As an "else" branch, we add recursive calls for the limit case.  When automatic induction is on,
                        // this get handled automatically, but we still want it in the case when automatic induction has been
                        // turned off.
                        //     forall k', params | k' < _k && Precondition {
                        //       pp(k', params);
                        //     }
                        Contract.Assume(SystemModuleManager.ORDINAL_Offset != null); // should have been filled in earlier
                        var kId = new IdentifierExpr(com.tok, k);
                        var kprimeVar = new BoundVar(com.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(794L, "_k'"), Type.BigOrdinal);
                        var kprime = new IdentifierExpr(com.tok, kprimeVar);
                        var smaller = Expression.CreateLess(kprime, kId);

                        var bvs = new List<BoundVar>(); // the following loop populates bvs with k', params
                        var substMap = new Dictionary<IVariable, Expression>();
                        foreach (var inFormal in prefixLemma.Ins)
                        {
                            if (MutateCSharp.Schemata405.ReplaceBinExprOp_54(795L, inFormal, k))
                            {
                                bvs.Add(kprimeVar);
                                substMap.Add(k, kprime);
                            }
                            else
                            {
                                var bv = new BoundVar(inFormal.tok, inFormal.Name, inFormal.Type);
                                bvs.Add(bv);
                                substMap.Add(inFormal, new IdentifierExpr(com.tok, bv));
                            }
                        }

                        prefixLemma.RecursiveCallParameters(com.tok, prefixLemma.TypeArgs, prefixLemma.Ins, null,
                          substMap, out var recursiveCallReceiver, out var recursiveCallArgs);
                        var methodSel = new MemberSelectExpr(com.tok, recursiveCallReceiver, prefixLemma.Name);
                        methodSel.Member = prefixLemma; // resolve here
                        methodSel.TypeApplication_AtEnclosingClass =
                          prefixLemma.EnclosingClass.TypeArgs.ConvertAll(tp => (Type)new UserDefinedType(tp.tok, tp));
                        methodSel.TypeApplication_JustMember =
                          prefixLemma.TypeArgs.ConvertAll(tp => (Type)new UserDefinedType(tp.tok, tp));
                        methodSel.Type = new InferredTypeProxy();
                        var recursiveCall = new CallStmt(com.RangeToken, new List<Expression>(), methodSel,
                          recursiveCallArgs.ConvertAll(e => new ActualBinding(null, e)));
                        recursiveCall.IsGhost = prefixLemma.IsGhost; // resolve here

                        var range = smaller; // The range will be strengthened later with the call's precondition, substituted
                                             // appropriately (which can only be done once the precondition has been resolved).
                        var attrs = new Attributes(MutateCSharp.Schemata405.ReplaceStringConstant_6(796L, "_autorequires"), new List<Expression>(), null);
#if VERIFY_CORRECTNESS_OF_TRANSLATION_FORALL_STATEMENT_RANGE
              // don't add the :_trustWellformed attribute
#else
                        attrs = new Attributes(MutateCSharp.Schemata405.ReplaceStringConstant_6(797L, "_trustWellformed"), new List<Expression>(), attrs);
#endif
                        attrs = new Attributes(MutateCSharp.Schemata405.ReplaceStringConstant_6(798L, "auto_generated"), new List<Expression>(), attrs);
                        var forallBody = new BlockStmt(mainBody.RangeToken, new List<Statement>() { recursiveCall });
                        var forallStmt = new ForallStmt(mainBody.RangeToken, bvs, attrs, range,
                          new List<AttributedExpression>(), forallBody);
                        els = new BlockStmt(mainBody.RangeToken, new List<Statement>() { forallStmt });
                    }
                    else
                    {
                        kk = new IdentifierExpr(k.tok, k.Name);
                        els = null;
                    }

                    var kPositive = new BinaryExpr(com.tok, BinaryExpr.Opcode.Lt, new LiteralExpr(com.tok, MutateCSharp.Schemata405.ReplaceNumericConstant_1(799L, 0)), kk);
                    var condBody = new IfStmt(mainBody.RangeToken, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(803L, false), kPositive, mainBody, els);
                    prefixLemma.Body = new BlockStmt(mainBody.RangeToken, new List<Statement>() { condBody });
                }

                // The prefix lemma now has all its components, so it's finally time we resolve it
                currentClass = (TopLevelDeclWithMembers)prefixLemma.EnclosingClass;
                allTypeParameters.PushMarker();
                ResolveTypeParameters(currentClass.TypeArgs, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(804L, false), currentClass);
                ResolveTypeParameters(prefixLemma.TypeArgs, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(805L, false), prefixLemma);
                prefixLemma.Resolve(this);
                allTypeParameters.PopMarker();
                currentClass = null;
                new CheckTypeInferenceVisitor(this).VisitMethod(prefixLemma);
                CallGraphBuilder.VisitMethod(prefixLemma, reporter);
                new BoundsDiscoveryVisitor(this).VisitMethod(prefixLemma);
            }
        }

        private void CheckIsOkayWithoutRHS(ConstantField f, bool giveNonReferenceTypeTraitHint)
        {
            var hint = MutateCSharp.Schemata405.ReplaceBinExprOp_4(806L, () => giveNonReferenceTypeTraitHint, () => !f.IsStatic
      ) ? MutateCSharp.Schemata405.ReplaceStringConstant_6(812L, " (consider changing the field to be a function, or restricting the enclosing trait to be a reference type by adding 'extends object')"
      ) : "";
            var statik = f.IsStatic ? MutateCSharp.Schemata405.ReplaceStringConstant_6(813L, "static ") : "";

            if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(814L, () => f.IsGhost, () => !f.Type.IsNonempty))
            {
                reporter.Error(MessageSource.Resolver, f.tok,
                  $"{statik}ghost const field '{f.Name}' of type '{f.Type}' (which may be empty) must give a defining value{hint}");
            }
            else if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(820L, () => !f.IsGhost, () => !f.Type.HasCompilableValue))
            {
                reporter.Error(MessageSource.Resolver, f.tok,
                  $"{statik}non-ghost const field '{f.Name}' of type '{f.Type}' (which does not have a default compiled value) must give a defining value{hint}");
            }
        }

        private void ResolveClassMembers_Pass1(TopLevelDeclWithMembers cl)
        {
            foreach (var member in cl.Members)
            {
                var prevErrCnt = reporter.Count(ErrorLevel.Error);
                if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(826L, prevErrCnt, reporter.Count(ErrorLevel.Error)))
                {
                    if (member is Method method)
                    {
                        CheckForUnnecessaryEqualitySupportDeclarations(method, method.TypeArgs);
                        CheckParameterDefaultValuesAreCompilable(method.Ins, method);
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_32(831L, method.Body, null))
                        {
                            ComputeGhostInterest(method.Body, method.IsGhost, method.IsLemmaLike ? MutateCSharp.Schemata405.ReplaceStringConstant_6(832L, "a ") + method.WhatKind : null, method);
                            CheckExpression(method.Body, this, method);
                            new TailRecursion(reporter).DetermineTailRecursion(method);
                        }

                        // check that any reads clause is used correctly
                        var readsClausesOnMethodsEnabled = Options.Get(Method.ReadsClausesOnMethods);
                        foreach (FrameExpression fe in method.Reads.Expressions)
                        {
                            if (method.IsLemmaLike)
                            {
                                reporter.Error(MessageSource.Resolver, fe.tok,
                MutateCSharp.Schemata405.ReplaceStringConstant_6(833L, "{0}s are not allowed to have reads clauses (they are allowed to read all memory locations)"), method.WhatKind);
                            }
                            else if (!readsClausesOnMethodsEnabled)
                            {
                                reporter.Error(MessageSource.Resolver, fe.tok,
                MutateCSharp.Schemata405.ReplaceStringConstant_6(834L, "reads clauses on methods are forbidden without the command-line flag `--reads-clauses-on-methods`"));
                            }
                            else if (method.IsGhost)
                            {
                                DisallowNonGhostFieldSpecifiers(fe);
                            }
                        }

                        // check that any modifies clause is used correctly
                        foreach (FrameExpression fe in method.Mod.Expressions)
                        {
                            if (method.IsLemmaLike)
                            {
                                reporter.Error(MessageSource.Resolver, fe.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(835L, "{0}s are not allowed to have modifies clauses"), method.WhatKind);
                            }
                            else if (method.IsGhost)
                            {
                                DisallowNonGhostFieldSpecifiers(fe);
                            }
                        }

                    }
                    else if (member is Function function)
                    {
                        CheckForUnnecessaryEqualitySupportDeclarations(function, function.TypeArgs);
                        CheckParameterDefaultValuesAreCompilable(function.Ins, function);
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_55(836L, function.ByMethodBody, null))
                        {
                            if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(838L, () => !function.IsGhost, () => MutateCSharp.Schemata405.ReplaceBinExprOp_33(837L, function.Body, null)))
                            {
                                ExpressionTester.CheckIsCompilable(Options, this, function.Body, function);
                            }
                            if (MutateCSharp.Schemata405.ReplaceBinExprOp_33(844L, function.Body, null))
                            {
                                new TailRecursion(reporter).DetermineTailRecursion(function);
                            }
                        }
                        else
                        {
                            var m = function.ByMethodDecl;
                            if (MutateCSharp.Schemata405.ReplaceBinExprOp_56(845L, m, null))
                            {
                                Contract.Assert(!m.IsGhost);
                                ComputeGhostInterest(m.Body, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(846L, false), null, m);
                                CheckExpression(m.Body, this, m);
                                new TailRecursion(reporter).DetermineTailRecursion(m);
                            }
                            else
                            {
                                // m should not be null, unless an error has been reported
                                // (e.g. function-by-method and method with the same name) 
                                Contract.Assert(reporter.HasErrors);
                            }
                        }

                    }
                    else if (member is ConstantField field && field.Rhs != null && !field.IsGhost)
                    {
                        ExpressionTester.CheckIsCompilable(Options, this, field.Rhs, field);
                    }

                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(852L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_7(847L, prevErrCnt, reporter.Count(ErrorLevel.Error)), () => member is ICodeContext))
                    {
                        member.SubExpressions.ForEach(e => CheckExpression(e, this, (ICodeContext)member));
                    }
                }
            }
        }

        void CheckForUnnecessaryEqualitySupportDeclarations(MemberDecl member, List<TypeParameter> typeParameters)
        {
            if (member.IsGhost)
            {
                foreach (var p in typeParameters.Where(p => p.SupportsEquality))
                {
                    reporter.Warning(MessageSource.Resolver, ErrorRegistry.NoneId, p.tok,
                      $"type parameter {p.Name} of ghost {member.WhatKind} {member.Name} is declared (==), which is unnecessary because the {member.WhatKind} doesn't contain any compiled code");
                }
            }
        }

        /// <summary>
        /// Check that default-value expressions are compilable, for non-ghost formals.
        /// </summary>
        void CheckParameterDefaultValuesAreCompilable(List<Formal> formals, ICodeContext codeContext)
        {
            Contract.Requires(formals != null);

            foreach (var formal in formals.Where(f => MutateCSharp.Schemata405.ReplaceBinExprOp_33(858L, f.DefaultValue, null)))
            {
                if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(865L, () => (MutateCSharp.Schemata405.ReplaceBinExprOp_14(859L, () => !codeContext.IsGhost, () => codeContext is DatatypeDecl)), () => !formal.IsGhost))
                {
                    ExpressionTester.CheckIsCompilable(Options, this, formal.DefaultValue, codeContext);
                }
                CheckExpression(formal.DefaultValue, this, codeContext);
            }
        }

        void ReportCallGraphCycleError(ICallable start, string msg)
        {
            Contract.Requires(start != null);
            Contract.Requires(msg != null);
            var scc = start.EnclosingModule.CallGraph.GetSCC(start);
            scc.Reverse();
            var startIndex = scc.IndexOf(start);
            Contract.Assert(0 <= startIndex);
            scc = Util.Concat(scc.GetRange(startIndex, MutateCSharp.Schemata405.ReplaceBinExprOp_57(871L, scc.Count, startIndex)), scc.GetRange(MutateCSharp.Schemata405.ReplaceNumericConstant_1(880L, 0), startIndex));
            ReportCycleError(reporter, scc, c => c.Tok, c => c.NameRelativeToModule, msg);
        }

        public static void ReportCycleError<X>(ErrorReporter reporter, List<X> cycle, Func<X, IToken> toTok, Func<X, string> toString, string msg)
        {
            Contract.Requires(cycle != null);
            Contract.Requires(cycle.Count != 0);
            Contract.Requires(toTok != null);
            Contract.Requires(toString != null);
            Contract.Requires(msg != null);

            var start = cycle[MutateCSharp.Schemata405.ReplaceNumericConstant_1(884L, 0)];
            var cy = Util.Comma(MutateCSharp.Schemata405.ReplaceStringConstant_6(888L, " -> "), cycle, toString);
            reporter.Error(MessageSource.Resolver, toTok(start), $"{msg}: {cy} -> {toString(start)}");
        }

        /// <summary>
        /// Check that the 'older' modifier on parameters is used correctly and report any errors of the contrary.
        /// </summary>
        void CheckOlderParameters(Function f)
        {
            Contract.Requires(f != null);

            if (MutateCSharp.Schemata405.ReplaceBinExprOp_14(895L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_14(889L, () => !f.ResultType.IsBoolType, () => f is PrefixPredicate), () => f is ExtremePredicate))
            {
                // parameters are not allowed to be marked 'older'
                foreach (var formal in f.Ins)
                {
                    if (formal.IsOlder)
                    {
                        reporter.Error(MessageSource.Resolver, formal.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(901L, "only predicates and two-state predicates are allowed 'older' parameters"));
                    }
                }
            }
        }

        // ------------------------------------------------------------------------------------------------------
        // ----- CheckExpression --------------------------------------------------------------------------------
        // ------------------------------------------------------------------------------------------------------
        #region CheckExpression
        /// <summary>
        /// This method computes ghost interests in the statement portion of StmtExpr's and
        /// checks for hint restrictions in any CalcStmt.
        /// </summary>
        void CheckExpression(Expression expr, ModuleResolver resolver, ICodeContext codeContext)
        {
            Contract.Requires(expr != null);
            Contract.Requires(resolver != null);
            Contract.Requires(codeContext != null);
            var v = new CheckExpression_Visitor(resolver, codeContext);
            v.Visit(expr);
        }
        /// <summary>
        /// This method computes ghost interests in the statement portion of StmtExpr's and
        /// checks for hint restrictions in any CalcStmt. In any ghost context, it also
        /// changes the bound variables of all let- and let-such-that expressions to ghost.
        /// It also performs substitutions in DefaultValueExpression's.
        /// </summary>
        void CheckExpression(Statement stmt, ModuleResolver resolver, ICodeContext codeContext)
        {
            Contract.Requires(stmt != null);
            Contract.Requires(resolver != null);
            Contract.Requires(codeContext != null);
            var v = new CheckExpression_Visitor(resolver, codeContext);
            v.Visit(stmt);
        }

        public class CheckExpression_Visitor : ResolverBottomUpVisitor
        {
            readonly ICodeContext CodeContext;
            public CheckExpression_Visitor(ModuleResolver resolver, ICodeContext codeContext)
              : base(resolver)
            {
                Contract.Requires(resolver != null);
                Contract.Requires(codeContext != null);
                CodeContext = codeContext;
            }
            protected override void VisitOneExpr(Expression expr)
            {
                if (expr is StmtExpr)
                {
                    var e = (StmtExpr)expr;
                    resolver.ComputeGhostInterest(e.S, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(902L, true), MutateCSharp.Schemata405.ReplaceStringConstant_6(903L, "a statement expression"), CodeContext);
                }
                else if (expr is LetExpr)
                {
                    var e = (LetExpr)expr;
                    if (CodeContext.IsGhost)
                    {
                        foreach (var bv in e.BoundVars)
                        {
                            bv.MakeGhost();
                        }
                    }
                }
            }

            protected override void VisitOneStmt(Statement stmt)
            {
                if (stmt is CalcStmt calc)
                {
                    foreach (var h in calc.Hints)
                    {
                        resolver.CheckLocalityUpdates(h, new HashSet<LocalVariable>(), MutateCSharp.Schemata405.ReplaceStringConstant_6(904L, "a hint"));
                    }
                }
                else if (stmt is AssertStmt astmt && MutateCSharp.Schemata405.ReplaceBinExprOp_32(905L, astmt.Proof, null))
                {
                    resolver.CheckLocalityUpdates(astmt.Proof, new HashSet<LocalVariable>(), MutateCSharp.Schemata405.ReplaceStringConstant_6(906L, "an assert-by body"));
                }
                else if (stmt is ForallStmt forall && MutateCSharp.Schemata405.ReplaceBinExprOp_0(907L, forall.Body, null))
                {
                    resolver.CheckLocalityUpdates(forall.Body, new HashSet<LocalVariable>(), MutateCSharp.Schemata405.ReplaceStringConstant_6(908L, "a forall statement"));
                }
            }
        }
        #endregion

        void ExtremePredicateChecks(Expression expr, ExtremePredicate context, CallingPosition cp)
        {
            Contract.Requires(expr != null);
            Contract.Requires(context != null);
            var v = new ExtremePredicateChecks_Visitor(reporter, context);
            v.Visit(expr, cp);
        }

        void ExtremeLemmaChecks(Statement stmt, ExtremeLemma context)
        {
            Contract.Requires(stmt != null);
            Contract.Requires(context != null);
            var v = new ExtremeLemmaChecks_Visitor(this, context);
            v.Visit(stmt);
        }
        void ExtremeLemmaChecks(Expression expr, ExtremeLemma context)
        {
            Contract.Requires(context != null);
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_49(909L, expr, null))
            {
                return;
            }

            var v = new ExtremeLemmaChecks_Visitor(this, context);
            v.Visit(expr);
        }

        public void ComputeGhostInterest(Statement stmt, bool mustBeErasable, [CanBeNull] string proofContext, ICodeContext codeContext)
        {
            Contract.Requires(stmt != null);
            Contract.Requires(codeContext != null);
            var visitor = new GhostInterestVisitor(codeContext, this, reporter, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(910L, false), codeContext is Method);
            visitor.Visit(stmt, mustBeErasable, proofContext);
        }

        public
            class ReportOtherAdditionalInformation_Visitor : ResolverBottomUpVisitor
        {
            public ReportOtherAdditionalInformation_Visitor(ModuleResolver resolver)
              : base(resolver)
            {
                Contract.Requires(resolver != null);
            }
            protected override void VisitOneStmt(Statement stmt)
            {
                if (stmt is ForallStmt)
                {
                    var s = (ForallStmt)stmt;
                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_58(911L, s.Kind, ForallStmt.BodyKind.Call))
                    {
                        var cs = (CallStmt)s.S0;
                        // show the callee's postcondition as the postcondition of the 'forall' statement
                        // TODO:  The following substitutions do not correctly take into consideration variable capture; hence, what the hover text displays may be misleading
                        var argsSubstMap = new Dictionary<IVariable, Expression>();  // maps formal arguments to actuals
                        Contract.Assert(cs.Method.Ins.Count == cs.Args.Count);
                        for (int i = MutateCSharp.Schemata405.ReplaceNumericConstant_1(912L, 0); MutateCSharp.Schemata405.ReplaceBinExprOp_37(916L, i, cs.Method.Ins.Count); MutateCSharp.Schemata405.ReplacePostfixUnaryExprOp_38(921L, ref i))
                        {
                            argsSubstMap.Add(cs.Method.Ins[i], cs.Args[i]);
                        }
                        var substituter = new AlphaConvertingSubstituter(cs.Receiver, argsSubstMap, new Dictionary<TypeParameter, Type>());
                        if (!Attributes.Contains(s.Attributes, MutateCSharp.Schemata405.ReplaceStringConstant_6(922L, "auto_generated")))
                        {
                            foreach (var ens in cs.Method.Ens)
                            {
                                var p = substituter.Substitute(ens.E);  // substitute the call's actuals for the method's formals
                                resolver.reporter.Info(MessageSource.Resolver, s.Tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(923L, "ensures ") + Printer.ExprToString(resolver.Options, p));
                            }
                        }
                    }
                }
            }
        }

        // ------------------------------------------------------------------------------------------------------
        // ------------------------------------------------------------------------------------------------------
        // ------------------------------------------------------------------------------------------------------

        private TopLevelDeclWithMembers currentClass;
        public Scope<TypeParameter>/*!*/ allTypeParameters;
        public readonly Scope<IVariable>/*!*/ scope;

        /// <summary>
        /// Resolves the types along .ParentTraits and fills in .ParentTraitHeads
        /// </summary>
        void ResolveParentTraitTypes(TopLevelDeclWithMembers cl, Graph<TopLevelDeclWithMembers> parentRelation)
        {
            Contract.Requires(cl != null);
            Contract.Requires(currentClass == null);
            Contract.Ensures(currentClass == null);

            currentClass = cl;
            allTypeParameters.PushMarker();
            ResolveTypeParameters(cl.TypeArgs, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(924L, false), cl);
            foreach (var parentTrait in cl.ParentTraits)
            {
                var prevErrorCount = reporter.Count(ErrorLevel.Error);
                ResolveType(cl.tok, parentTrait, new NoContext(cl.EnclosingModuleDefinition), ResolveTypeOptionEnum.DontInfer, null);
                if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(925L, prevErrorCount, reporter.Count(ErrorLevel.Error)))
                {
                    var parentTypeToken = parentTrait is UserDefinedType parentTraitUdt ? parentTraitUdt.tok : cl.tok;

                    var trait = parentTrait.UseInternalSynonym().IsInternalTypeSynonym ? null : (parentTrait as UserDefinedType)?.AsParentTraitDecl();
                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_59(930L, trait, null))
                    {
                        // disallowing inheritance in multi module case
                        bool termination = MutateCSharp.Schemata405.ReplaceBooleanConstant_3(931L, true);
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_14(933L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_24(932L, cl.EnclosingModuleDefinition, trait.EnclosingModuleDefinition), () => trait.IsObjectTrait) || (Attributes.ContainsBool(trait.Attributes, MutateCSharp.Schemata405.ReplaceStringConstant_6(939L, "termination"), ref termination) && !termination))
                        {
                            // all is good (or the user takes responsibility for the lack of termination checking)
                            if (!cl.ParentTraitHeads.Contains(trait))
                            {
                                cl.ParentTraitHeads.Add(trait);
                                parentRelation.AddEdge(cl, trait);
                            }
                        }
                        else
                        {
                            reporter.Error(MessageSource.Resolver, parentTypeToken,
                              $"{cl.WhatKind} '{cl.Name}' is in a different module than trait '{trait.FullName}'. A {cl.WhatKind} may only extend a trait " +
              MutateCSharp.Schemata405.ReplaceStringConstant_6(940L, "in the same module, unless the parent trait is annotated with {:termination false}."));
                        }
                    }
                    else
                    {
                        reporter.Error(MessageSource.Resolver, parentTypeToken, $"a {cl.WhatKind} can only extend traits (found '{parentTrait}')");
                    }
                }
            }
            allTypeParameters.PopMarker();
            currentClass = null;
        }

        void InheritMembers(List<TopLevelDecl> declarations)
        {
            // Register the trait members in the classes that inherit them
            foreach (var topLevelDeclWithMembers in declarations.OfType<TopLevelDeclWithMembers>())
            {
                RegisterInheritedMembers(topLevelDeclWithMembers);
            }
        }

        /// <summary>
        /// This method idempotently fills in .InheritanceInformation, .ParentFormalTypeParametersToActuals, and the
        /// name->MemberDecl table for "cl" and the transitive parent traits of "cl". It also checks that every (transitive)
        /// parent trait is instantiated with the same type parameters
        /// The method assumes that all types along .ParentTraits have been successfully resolved and .ParentTraitHeads been filled in.
        ///
        /// The "basePreType" parameter is used only with the new resolver. It can be passed in a "null" to indicate that "cl" does not
        /// have a base type or that the given/inferred base type was not legal.
        /// </summary>
        public void RegisterInheritedMembers(TopLevelDeclWithMembers cl, [CanBeNull] DPreType basePreType = null)
        {
            Contract.Requires(cl != null);

            if (MutateCSharp.Schemata405.ReplaceBinExprOp_60(941L, cl.ParentTypeInformation, null))
            {
                return;
            }
            cl.ParentTypeInformation = new TopLevelDeclWithMembers.InheritanceInformationClass();

            // populate .ParentFormalTypeParametersToActuals with the type arguments given to the base type (this applies only to newtype's)
            TopLevelDeclWithMembers baseTypeDecl = null;
            List<Type> baseTypeArguments = null;
            if (cl is NewtypeDecl newtypeDecl)
            {
                if (Options.Get(CommonOptionBag.TypeSystemRefresh))
                {
                    baseTypeDecl = basePreType?.Decl as TopLevelDeclWithMembers;
                    baseTypeArguments = basePreType?.Arguments.ConvertAll(preType => PreType2TypeUtil.PreType2Type(preType, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(942L, false), TypeParameter.TPVariance.Co));
                }
                else
                {
                    // ignore any subset types, since they have no members and thus we don't need their type-parameter mappings
                    var baseType = newtypeDecl.BaseType.NormalizeExpand();
                    baseTypeArguments = baseType.TypeArgs;
                    if (baseType is UserDefinedType udtBaseType)
                    {
                        baseTypeDecl = (TopLevelDeclWithMembers)udtBaseType.ResolvedClass;
                    }
                    else if (MutateCSharp.Schemata405.ReplaceBinExprOp_14(949L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_14(943L, () => Options.Get(CommonOptionBag.GeneralNewtypes), () => baseType.IsIntegerType), () => baseType.IsRealType))
                    {
                        baseTypeDecl = GetSystemValuetypeDecl(baseType);
                    }
                }
                if (MutateCSharp.Schemata405.ReplaceBinExprOp_61(955L, baseTypeDecl, null))
                {
                    Contract.Assert(baseTypeArguments.Count == baseTypeDecl.TypeArgs.Count);
                    for (var i = MutateCSharp.Schemata405.ReplaceNumericConstant_1(956L, 0); MutateCSharp.Schemata405.ReplaceBinExprOp_37(960L, i, baseTypeArguments.Count); MutateCSharp.Schemata405.ReplacePostfixUnaryExprOp_38(965L, ref i))
                    {
                        cl.ParentFormalTypeParametersToActuals.Add(baseTypeDecl.TypeArgs[i], baseTypeArguments[i]);
                    }
                    RegisterInheritedMembers(baseTypeDecl);
                }
            }

            // populate .ParentTypeInformation and .ParentFormalTypeParametersToActuals for the immediate parent traits
            foreach (var tt in cl.ParentTraits)
            {
                var udt = (UserDefinedType)tt;
                var trait = (TraitDecl)((udt.ResolvedClass as NonNullTypeDecl)?.ViewAsClass ?? udt.ResolvedClass);
                cl.ParentTypeInformation.Record(trait, udt);
                Contract.Assert(trait.TypeArgs.Count == udt.TypeArgs.Count);
                for (var i = MutateCSharp.Schemata405.ReplaceNumericConstant_1(966L, 0); MutateCSharp.Schemata405.ReplaceBinExprOp_37(970L, i, trait.TypeArgs.Count); MutateCSharp.Schemata405.ReplacePostfixUnaryExprOp_38(975L, ref i))
                {
                    // there may be duplicate parent traits, which haven't been checked for yet, so add mapping only for the first occurrence of each type parameter
                    if (!cl.ParentFormalTypeParametersToActuals.ContainsKey(trait.TypeArgs[i]))
                    {
                        cl.ParentFormalTypeParametersToActuals.Add(trait.TypeArgs[i], udt.TypeArgs[i]);
                    }
                }
            }

            // populate .ParentTypeInformation and .ParentFormalTypeParametersToActuals for the transitive parent traits
            foreach (var trait in cl.ParentTraitHeads)
            {
                // make sure the parent trait has been processed; then, incorporate its inheritance information
                RegisterInheritedMembers(trait);
                cl.ParentTypeInformation.Extend(trait, trait.ParentTypeInformation, cl.ParentFormalTypeParametersToActuals);
                foreach (var entry in trait.ParentFormalTypeParametersToActuals)
                {
                    var v = entry.Value.Subst(cl.ParentFormalTypeParametersToActuals);
                    if (!cl.ParentFormalTypeParametersToActuals.ContainsKey(entry.Key))
                    {
                        cl.ParentFormalTypeParametersToActuals.Add(entry.Key, v);
                    }
                }
            }

            // Check that every (transitive) parent trait is instantiated with the same type parameters
            foreach (var group in cl.ParentTypeInformation.GetTypeInstantiationGroups())
            {
                Contract.Assert(1 <= group.Count);
                var ty = group[MutateCSharp.Schemata405.ReplaceNumericConstant_1(976L, 0)].Item1;
                for (var i = MutateCSharp.Schemata405.ReplaceNumericConstant_1(980L, 1); MutateCSharp.Schemata405.ReplaceBinExprOp_37(984L, i, group.Count); MutateCSharp.Schemata405.ReplacePostfixUnaryExprOp_38(989L, ref i))
                {
                    if (!group.GetRange(MutateCSharp.Schemata405.ReplaceNumericConstant_1(990L, 0), i).Exists(pair => pair.Item1.Equals(group[i].Item1)))
                    {
                        var via0 = MutateCSharp.Schemata405.ReplaceBinExprOp_7(1002L, group[MutateCSharp.Schemata405.ReplaceNumericConstant_1(994L, 0)].Item2.Count, MutateCSharp.Schemata405.ReplaceNumericConstant_1(998L, 0)) ? "" : MutateCSharp.Schemata405.ReplaceStringConstant_6(1007L, " (via ") + Util.Comma(group[MutateCSharp.Schemata405.ReplaceNumericConstant_1(1008L, 0)].Item2, traitDecl => traitDecl.Name) + MutateCSharp.Schemata405.ReplaceStringConstant_6(1012L, ")");
                        var via1 = MutateCSharp.Schemata405.ReplaceBinExprOp_7(1017L, group[i].Item2.Count, MutateCSharp.Schemata405.ReplaceNumericConstant_1(1013L, 0)) ? "" : MutateCSharp.Schemata405.ReplaceStringConstant_6(1022L, " (via ") + Util.Comma(group[i].Item2, traitDecl => traitDecl.Name) + MutateCSharp.Schemata405.ReplaceStringConstant_6(1023L, ")");
                        reporter.Error(MessageSource.Resolver, cl.tok,
            MutateCSharp.Schemata405.ReplaceStringConstant_6(1024L, "duplicate trait parents with the same head type must also have the same type arguments; got {0}{1} and {2}{3}"),
                          ty, via0, group[i].Item1, via1);
                    }
                }
            }

            // Update the name->MemberDecl table for the class. Report an error if the same name refers to more than one member,
            // except when such duplication is purely that one member, say X, is inherited and the other is an override of X.
            var inheritedMembers = new Dictionary<string, MemberDecl>();
            var membersWithErrors = new List<string>();
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_61(1025L, baseTypeDecl, null))
            {
                AddToInheritedMembers(cl, baseTypeDecl, inheritedMembers, membersWithErrors);
            }
            foreach (var trait in cl.ParentTraitHeads)
            {
                AddToInheritedMembers(cl, trait, inheritedMembers, membersWithErrors);
            }
            // Incorporate the inherited members into the name->MemberDecl mapping of "cl"
            var members = GetClassMembers(cl);
            foreach (var entry in inheritedMembers)
            {
                var name = entry.Key;
                var traitMember = entry.Value;
                if (!members.TryGetValue(name, out var clMember))
                {
                    members.Add(name, traitMember);
                }
                else
                {
                    Contract.Assert(clMember.EnclosingClass == cl);  // sanity check
                    Contract.Assert(clMember.OverriddenMember == null);  // sanity check
                    clMember.OverriddenMember = traitMember;
                }
            }
            ProcessInheritedTraitMembers(cl, membersWithErrors);
        }

        private void AddToInheritedMembers(TopLevelDeclWithMembers cl, TopLevelDeclWithMembers baseOrParentTypeDecl,
          Dictionary<string, MemberDecl> inheritedMembers, List<string> membersWithErrors)
        {
            var members = GetClassMembers(baseOrParentTypeDecl)!;
            var sortedKeys = members.Keys.ToList();
            sortedKeys.Sort();
            foreach (var inheritedMemberName in sortedKeys)
            {
                var inheritedMember = members[inheritedMemberName];
                if (!inheritedMembers.TryGetValue(inheritedMember.Name, out var prevMember))
                {
                    // all good; record "inheritedMember" as an inherited member
                    inheritedMembers.Add(inheritedMember.Name, inheritedMember);
                }
                else if (MutateCSharp.Schemata405.ReplaceBinExprOp_62(1026L, inheritedMember, prevMember))
                {
                    // same member, inherited two different ways
                }
                else if (inheritedMember.Overrides(prevMember))
                {
                    // we're inheriting "prevMember" and "traitMember" from different parent traits, where "inheritedMember" is an override of "prevMember"
                    Contract.Assert(inheritedMember.EnclosingClass != cl && prevMember.EnclosingClass != cl &&
                                    inheritedMember.EnclosingClass != prevMember.EnclosingClass); // sanity checks
                                                                                                  // re-map "traitMember.Name" to point to the overriding member
                    inheritedMembers[inheritedMember.Name] = inheritedMember;
                }
                else if (prevMember.Overrides(inheritedMember))
                {
                    // we're inheriting "prevMember" and "inheritedMember" from different parent traits, where "prevMember" is an override of "inheritedMember"
                    Contract.Assert(inheritedMember.EnclosingClass != cl && prevMember.EnclosingClass != cl &&
                                    inheritedMember.EnclosingClass != prevMember.EnclosingClass); // sanity checks
                                                                                                  // keep the mapping to "prevMember"
                }
                else
                {
                    // "prevMember" and "inheritedMember" refer to different members (with the same name)
                    membersWithErrors.Add(inheritedMember.Name);
                    reporter.Error(MessageSource.Resolver, cl.tok,
                      $"{cl.WhatKindAndName} inherits a member named '{inheritedMember.Name}' from both " +
                      $"{prevMember.EnclosingClass.WhatKindAndName} and {inheritedMember.EnclosingClass.WhatKindAndName}");
                }
            }
        }

        [CanBeNull]
        ValuetypeDecl GetSystemValuetypeDecl(Type type)
        {
            foreach (var systemTopLevelDecl in ProgramResolver.SystemModuleManager.SystemModule.SourceDecls.OfType<ValuetypeDecl>())
            {
                if (systemTopLevelDecl.IsThisType(type))
                {
                    return systemTopLevelDecl;
                }
            }

            if (type.AsBitVectorType is { } bitvectorType)
            {
                // The declaration for this built-in bitvector type has not yet been added to SourceDecls. We create it here and add it.
                return AddBitvectorTypeDecl(bitvectorType.Name, bitvectorType.Width);
            }

            return null; // not present
        }

        public ValuetypeDecl AddBitvectorTypeDecl(string name, int width)
        {
            var bvDecl = new ValuetypeDecl(name, ProgramResolver.SystemModuleManager.SystemModule,
              t => t.AsBitVectorType is { Width: var w } && MutateCSharp.Schemata405.ReplaceBinExprOp_7(1027L, w, width),
              typeArgs => new BitvectorType(Options, width));
            AddRotateMember(bvDecl, MutateCSharp.Schemata405.ReplaceStringConstant_6(1032L, "RotateLeft"), width);
            AddRotateMember(bvDecl, MutateCSharp.Schemata405.ReplaceStringConstant_6(1033L, "RotateRight"), width);
            ProgramResolver.SystemModuleManager.SystemModule.SourceDecls.Add(bvDecl);
            var memberDictionary = bvDecl.Members.ToDictionary(member => member.Name, member => member);
            ProgramResolver.AddSystemClass(bvDecl, memberDictionary);
            return bvDecl;
        }

        private void AddRotateMember(ValuetypeDecl bitvectorTypeDecl, string name, int width)
        {
            var argumentType = ProgramResolver.SystemModuleManager.Nat();
            var formals = new List<Formal> {
        new Formal(Token.NoToken, MutateCSharp.Schemata405.ReplaceStringConstant_6(1034L, "w"), argumentType, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1035L, true), MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1036L, false), null)
      };
            var resultType = new BitvectorType(Options, width);
            var rotateMember = new SpecialFunction(RangeToken.NoToken, name, ProgramResolver.SystemModuleManager.SystemModule, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1037L, false), MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1038L, false),
              new List<TypeParameter>(), formals, resultType,
              new List<AttributedExpression>(), new Specification<FrameExpression>(), new List<AttributedExpression>(),
              new Specification<Expression>(new List<Expression>(), null), null, null, null)
            {
                EnclosingClass = bitvectorTypeDecl
            };
            rotateMember.AddVisibilityScope(ProgramResolver.SystemModuleManager.SystemModule.VisibilityScope, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1039L, false));
            bitvectorTypeDecl.Members.Add(rotateMember);
        }

        /// <summary>
        /// Assumes type parameters have already been pushed
        /// </summary>
        void ResolveClassMemberTypes(TopLevelDeclWithMembers cl)
        {
            Contract.Requires(cl != null);
            Contract.Requires(currentClass == null);
            Contract.Ensures(currentClass == null);
            currentClass = cl;

            foreach (MemberDecl member in cl.Members)
            {
                member.EnclosingClass = cl;
                if (member is Field)
                {
                    if (member is ConstantField)
                    {
                        var m = (ConstantField)member;
                        ResolveType(member.tok, ((Field)member).Type, m, ResolveTypeOptionEnum.DontInfer, null);
                    }
                    else
                    {
                        // In the following, we pass in a NoContext, because any cycle formed by a redirecting-type constraints would have to
                        // dereference the heap, and such constraints are not allowed to dereference the heap so an error will be produced
                        // even if we don't detect this cycle.
                        ResolveType(member.tok, ((Field)member).Type, new NoContext(cl.EnclosingModuleDefinition), ResolveTypeOptionEnum.DontInfer, null);
                    }
                }
                else if (member is Function)
                {
                    var f = (Function)member;
                    var ec = reporter.Count(ErrorLevel.Error);
                    allTypeParameters.PushMarker();
                    ResolveTypeParameters(f.TypeArgs, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1040L, true), f);
                    ResolveFunctionSignature(f);
                    allTypeParameters.PopMarker();
                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(1046L, () => f is ExtremePredicate, () => MutateCSharp.Schemata405.ReplaceBinExprOp_7(1041L, ec, reporter.Count(ErrorLevel.Error))))
                    {
                        var ff = ((ExtremePredicate)f).PrefixPredicate;  // note, may be null if there was an error before the prefix predicate was generated
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_5(1052L, ff, null))
                        {
                            ff.EnclosingClass = cl;
                            allTypeParameters.PushMarker();
                            ResolveTypeParameters(ff.TypeArgs, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1053L, true), ff);
                            ResolveFunctionSignature(ff);
                            allTypeParameters.PopMarker();
                        }
                    }
                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_56(1054L, f.ByMethodDecl, null))
                    {
                        f.ByMethodDecl.EnclosingClass = cl;
                    }

                }
                else if (member is Method)
                {
                    var m = (Method)member;
                    var ec = reporter.Count(ErrorLevel.Error);
                    allTypeParameters.PushMarker();
                    ResolveTypeParameters(m.TypeArgs, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1055L, true), m);
                    ResolveMethodSignature(m);
                    allTypeParameters.PopMarker();
                    if (m is ExtremeLemma com && com.PrefixLemma != null && MutateCSharp.Schemata405.ReplaceBinExprOp_7(1056L, ec, reporter.Count(ErrorLevel.Error)))
                    {
                        var mm = com.PrefixLemma;
                        // resolve signature of the prefix lemma
                        mm.EnclosingClass = cl;
                        allTypeParameters.PushMarker();
                        ResolveTypeParameters(mm.TypeArgs, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1061L, true), mm);
                        ResolveMethodSignature(mm);
                        allTypeParameters.PopMarker();
                    }

                }
                else
                {
                    Contract.Assert(false); throw new cce.UnreachableException();  // unexpected member type
                }
            }

            currentClass = null;
        }

        /// <summary>
        /// This method checks the rules for inherited and overridden members. It also populates .InheritedMembers with the
        /// non-static members that are inherited from parent traits.
        /// </summary>
        void ProcessInheritedTraitMembers(TopLevelDeclWithMembers cl, List<string> suppressNoImplErrorsForTheseMembers)
        {
            Contract.Requires(cl != null);
            Contract.Requires(cl.ParentTypeInformation != null);

            foreach (var member in GetClassMembers(cl).Values)
            {
                if (member is PrefixPredicate or PrefixLemma)
                {
                    // these are handled with the corresponding extreme predicate/lemma
                    continue;
                }
                if (MutateCSharp.Schemata405.ReplaceBinExprOp_63(1062L, member.EnclosingClass, cl))
                {
                    if (member.EnclosingClass is not TraitDecl)
                    {
                        continue;
                    }
                    // The member is the one inherited from a trait (and the class does not itself define a member with this name).  This
                    // is fine for fields and for functions and methods with bodies. However, if "cl" is not itself a trait, then for a body-less function
                    // or method, "cl" is required to at least redeclare the member with its signature.  (It should also provide a stronger specification,
                    // but that will be checked by the verifier.  And it should also have a body, but that will be checked by the compiler.)
                    if (member.IsStatic)
                    {
                        // nothing to do
                    }
                    else
                    {
                        cl.InheritedMembers.Add(member);
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_14(1071L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_14(1064L, () => member is Field, () => MutateCSharp.Schemata405.ReplaceBinExprOp_33(1063L, (member as Function)?.Body, null)), () => MutateCSharp.Schemata405.ReplaceBinExprOp_32(1070L, (member as Method)?.Body, null)))
                        {
                            // member is a field or a fully defined function or method
                        }
                        else if (cl is TraitDecl)
                        {
                            // there are no expectations that a field needs to repeat the signature of inherited body-less members
                        }
                        else if (Attributes.Contains(member.Attributes, MutateCSharp.Schemata405.ReplaceStringConstant_6(1077L, "extern")))
                        {
                            // Extern functions do not need to be reimplemented.
                            // TODO: When `:extern` is separated from `:compile false`, this should become `:compile false`.
                        }
                        else if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(1079L, () => member is Lemma, () => Attributes.Contains(member.Attributes, MutateCSharp.Schemata405.ReplaceStringConstant_6(1078L, "opaque_reveal"))))
                        {
                            // reveal lemmas do not need to be reimplemented
                        }
                        else if (!suppressNoImplErrorsForTheseMembers.Contains(member.Name))
                        {
                            reporter.Error(MessageSource.Resolver, cl.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(1085L, "{0} '{1}' does not implement trait {2} '{3}.{4}'"), cl.WhatKind, cl.Name, member.WhatKind, member.EnclosingClass.Name, member.Name);
                        }
                    }
                    continue;
                }
                if (MutateCSharp.Schemata405.ReplaceBinExprOp_10(1086L, member.OverriddenMember, null))
                {
                    // this member has nothing to do with the parent traits
                    continue;
                }

                var traitMember = member.OverriddenMember;
                var trait = traitMember.EnclosingClass;
                if (trait is not TraitDecl)
                {
                    reporter.Error(MessageSource.Resolver, member.tok,
                      $"{traitMember.WhatKindAndName} is inherited from {trait.WhatKindAndName} and is not allowed to be re-declared in {cl.WhatKindAndName}");
                }
                else if (traitMember.IsStatic)
                {
                    reporter.Error(MessageSource.Resolver, member.tok,
                      $"static {traitMember.WhatKindAndName} is inherited from trait '{trait.Name}' and is not allowed to be re-declared");
                }
                else if (member.IsStatic)
                {
                    reporter.Error(MessageSource.Resolver, member.tok,
                      $"static member '{member.Name}' overrides non-static member in trait '{trait.Name}'");
                }
                else if (traitMember is Field)
                {
                    // The class is not allowed to do anything with the field other than silently inherit it.
                    reporter.Error(MessageSource.Resolver, member.tok,
                      $"{traitMember.WhatKindAndName} is inherited from trait '{trait.Name}' and is not allowed to be re-declared");
                }
                else if (MutateCSharp.Schemata405.ReplaceBinExprOp_14(1089L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_33(1087L, (traitMember as Function)?.Body, null), () => MutateCSharp.Schemata405.ReplaceBinExprOp_32(1088L, (traitMember as Method)?.Body, null)))
                {
                    // the overridden member is a fully defined function or method, so the class is not allowed to do anything with it other than silently inherit it
                    reporter.Error(MessageSource.Resolver, member.tok,
                      $"fully defined {traitMember.WhatKindAndName} is inherited from trait '{trait.Name}' and is not allowed to be re-declared");
                }
                else if (MutateCSharp.Schemata405.ReplaceBinExprOp_14(1191L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_14(1179L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_14(1167L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_14(1155L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_14(1143L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_14(1131L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_14(1119L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_14(1107L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_39(1095L, () => member is Method, () => traitMember is Method), () => MutateCSharp.Schemata405.ReplaceBinExprOp_39(1101L, () => member is Lemma, () => traitMember is Lemma)), () => MutateCSharp.Schemata405.ReplaceBinExprOp_39(1113L, () => member is TwoStateLemma, () => traitMember is TwoStateLemma)), () => MutateCSharp.Schemata405.ReplaceBinExprOp_39(1125L, () => member is LeastLemma, () => traitMember is LeastLemma)), () => MutateCSharp.Schemata405.ReplaceBinExprOp_39(1137L, () => member is GreatestLemma, () => traitMember is GreatestLemma)), () => MutateCSharp.Schemata405.ReplaceBinExprOp_39(1149L, () => member is Function, () => traitMember is Function)), () => MutateCSharp.Schemata405.ReplaceBinExprOp_39(1161L, () => member is TwoStateFunction, () => traitMember is TwoStateFunction)), () => MutateCSharp.Schemata405.ReplaceBinExprOp_39(1173L, () => member is LeastPredicate, () => traitMember is LeastPredicate)), () => MutateCSharp.Schemata405.ReplaceBinExprOp_39(1185L, () => member is GreatestPredicate, () => traitMember is GreatestPredicate)))
                {
                    reporter.Error(MessageSource.Resolver, member.tok,
                      $"{traitMember.WhatKindAndName} in '{trait.Name}' can only be overridden by a {traitMember.WhatKind} (got {member.WhatKind})");
                }
                else if (MutateCSharp.Schemata405.ReplaceBinExprOp_39(1197L, () => member.IsGhost, () => traitMember.IsGhost))
                {
                    reporter.Error(MessageSource.Resolver, member.tok,
                      $"overridden {traitMember.WhatKindAndName} in '{cl.Name}' has different ghost/compiled status than in trait '{trait.Name}'");
                }
                else if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(1203L, () => !member.IsOpaque, () => traitMember.IsOpaque))
                {
                    reporter.Error(MessageSource.Resolver, member.tok,
                      $"overridden {traitMember.WhatKindAndName} in '{cl.Name}' must be 'opaque' since the member is 'opaque' in trait '{trait.Name}'");
                }
                else
                {
                    // Copy trait member's extern attribute onto class member if class does not provide one
                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(1211L, () => !Attributes.Contains(member.Attributes, MutateCSharp.Schemata405.ReplaceStringConstant_6(1209L, "extern")), () => Attributes.Contains(traitMember.Attributes, MutateCSharp.Schemata405.ReplaceStringConstant_6(1210L, "extern"))))
                    {
                        var traitExternArgs = Attributes.FindExpressions(traitMember.Attributes, MutateCSharp.Schemata405.ReplaceStringConstant_6(1217L, "extern"));
                        member.Attributes = new Attributes(MutateCSharp.Schemata405.ReplaceStringConstant_6(1218L, "extern"), traitExternArgs, member.Attributes);
                    }

                    if (traitMember is Method)
                    {
                        var classMethod = (Method)member;
                        var traitMethod = (Method)traitMember;
                        classMethod.OverriddenMethod = traitMethod;

                        CheckOverride_MethodParameters(classMethod, traitMethod, cl.ParentFormalTypeParametersToActuals);

                        var traitMethodAllowsNonTermination = Contract.Exists(traitMethod.Decreases.Expressions, e => e is WildcardExpr);
                        var classMethodAllowsNonTermination = Contract.Exists(classMethod.Decreases.Expressions, e => e is WildcardExpr);
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(1219L, () => classMethodAllowsNonTermination, () => !traitMethodAllowsNonTermination))
                        {
                            reporter.Error(MessageSource.Resolver, classMethod.tok,
                              $"not allowed to override a terminating method with a possibly non-terminating method ('{classMethod.Name}')");
                        }

                    }
                    else if (traitMember is Function)
                    {
                        var classFunction = (Function)member;
                        var traitFunction = (Function)traitMember;
                        classFunction.OverriddenFunction = traitFunction;

                        CheckOverride_FunctionParameters(classFunction, traitFunction, cl.ParentFormalTypeParametersToActuals);

                    }
                    else
                    {
                        Contract.Assert(false); // unexpected member
                    }
                }
            }
        }

        public void CheckOverride_FunctionParameters(Function nw, Function old, Dictionary<TypeParameter, Type> classTypeMap)
        {
            Contract.Requires(nw != null);
            Contract.Requires(old != null);
            Contract.Requires(classTypeMap != null);

            var typeMap = CheckOverride_TypeParameters(nw.tok, old.TypeArgs, nw.TypeArgs, nw.Name, MutateCSharp.Schemata405.ReplaceStringConstant_6(1225L, "function"), classTypeMap);
            if (nw is ExtremePredicate nwFix && old is ExtremePredicate oldFix && MutateCSharp.Schemata405.ReplaceBinExprOp_39(1226L, () => nwFix.KNat, () => oldFix.KNat))
            {
                reporter.Error(MessageSource.Resolver, nw,
        MutateCSharp.Schemata405.ReplaceStringConstant_6(1232L, "the type of special parameter '_k' of {0} '{1}' ({2}) must be the same as in the overridden {0} ({3})"),
                  nw.WhatKind, nw.Name, nwFix.KNat ? MutateCSharp.Schemata405.ReplaceStringConstant_6(1233L, "nat") : MutateCSharp.Schemata405.ReplaceStringConstant_6(1234L, "ORDINAL"), oldFix.KNat ? MutateCSharp.Schemata405.ReplaceStringConstant_6(1235L, "nat") : MutateCSharp.Schemata405.ReplaceStringConstant_6(1236L, "ORDINAL"));
            }
            CheckOverride_ResolvedParameters(nw.tok, old.Ins, nw.Ins, nw.Name, MutateCSharp.Schemata405.ReplaceStringConstant_6(1237L, "function"), MutateCSharp.Schemata405.ReplaceStringConstant_6(1238L, "parameter"), typeMap);
            var oldResultType = old.ResultType.Subst(typeMap);
            if (!nw.ResultType.Equals(oldResultType, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1239L, true)))
            {
                reporter.Error(MessageSource.Resolver, nw, MutateCSharp.Schemata405.ReplaceStringConstant_6(1240L, "the result type of function '{0}' ({1}) differs from that in the overridden function ({2})"),
                  nw.Name, nw.ResultType, oldResultType);
            }
        }

        public void CheckOverride_MethodParameters(Method nw, Method old, Dictionary<TypeParameter, Type> classTypeMap)
        {
            Contract.Requires(nw != null);
            Contract.Requires(old != null);
            Contract.Requires(classTypeMap != null);
            var typeMap = CheckOverride_TypeParameters(nw.tok, old.TypeArgs, nw.TypeArgs, nw.Name, MutateCSharp.Schemata405.ReplaceStringConstant_6(1241L, "method"), classTypeMap);
            if (nw is ExtremeLemma nwFix && old is ExtremeLemma oldFix && MutateCSharp.Schemata405.ReplaceBinExprOp_39(1242L, () => nwFix.KNat, () => oldFix.KNat))
            {
                reporter.Error(MessageSource.Resolver, nw,
        MutateCSharp.Schemata405.ReplaceStringConstant_6(1248L, "the type of special parameter '_k' of {0} '{1}' ({2}) must be the same as in the overridden {0} ({3})"),
                  nw.WhatKind, nw.Name, nwFix.KNat ? MutateCSharp.Schemata405.ReplaceStringConstant_6(1249L, "nat") : MutateCSharp.Schemata405.ReplaceStringConstant_6(1250L, "ORDINAL"), oldFix.KNat ? MutateCSharp.Schemata405.ReplaceStringConstant_6(1251L, "nat") : MutateCSharp.Schemata405.ReplaceStringConstant_6(1252L, "ORDINAL"));
            }
            CheckOverride_ResolvedParameters(nw.tok, old.Ins, nw.Ins, nw.Name, MutateCSharp.Schemata405.ReplaceStringConstant_6(1253L, "method"), MutateCSharp.Schemata405.ReplaceStringConstant_6(1254L, "in-parameter"), typeMap);
            CheckOverride_ResolvedParameters(nw.tok, old.Outs, nw.Outs, nw.Name, MutateCSharp.Schemata405.ReplaceStringConstant_6(1255L, "method"), MutateCSharp.Schemata405.ReplaceStringConstant_6(1256L, "out-parameter"), typeMap);
        }

        private Dictionary<TypeParameter, Type> CheckOverride_TypeParameters(IToken tok, List<TypeParameter> old, List<TypeParameter> nw, string name, string thing, Dictionary<TypeParameter, Type> classTypeMap)
        {
            Contract.Requires(tok != null);
            Contract.Requires(old != null);
            Contract.Requires(nw != null);
            Contract.Requires(name != null);
            Contract.Requires(thing != null);
            var typeMap = MutateCSharp.Schemata405.ReplaceBinExprOp_7(1261L, old.Count, MutateCSharp.Schemata405.ReplaceNumericConstant_1(1257L, 0)) ? classTypeMap : new Dictionary<TypeParameter, Type>(classTypeMap);
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_20(1266L, old.Count, nw.Count))
            {
                reporter.Error(MessageSource.Resolver, tok,
        MutateCSharp.Schemata405.ReplaceStringConstant_6(1271L, "{0} '{1}' is declared with a different number of type parameters ({2} instead of {3}) than in the overridden {0}"), thing, name, nw.Count, old.Count);
            }
            else
            {
                for (int i = MutateCSharp.Schemata405.ReplaceNumericConstant_1(1272L, 0); MutateCSharp.Schemata405.ReplaceBinExprOp_37(1276L, i, old.Count); MutateCSharp.Schemata405.ReplacePostfixUnaryExprOp_38(1281L, ref i))
                {
                    var o = old[i];
                    var n = nw[i];
                    typeMap.Add(o, new UserDefinedType(tok, n));
                    // Check type characteristics
                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(1284L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_64(1282L, o.Characteristics.EqualitySupport, TypeParameter.EqualitySupportValue.InferredRequired), () => MutateCSharp.Schemata405.ReplaceBinExprOp_64(1283L, o.Characteristics.EqualitySupport, n.Characteristics.EqualitySupport)))
                    {
                        reporter.Error(MessageSource.Resolver, n.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(1290L, "type parameter '{0}' is not allowed to change the requirement of supporting equality"), n.Name);
                    }
                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_39(1291L, () => o.Characteristics.HasCompiledValue, () => n.Characteristics.HasCompiledValue))
                    {
                        reporter.Error(MessageSource.Resolver, n.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(1297L, "type parameter '{0}' is not allowed to change the requirement of supporting auto-initialization"), n.Name);
                    }
                    else if (MutateCSharp.Schemata405.ReplaceBinExprOp_39(1298L, () => o.Characteristics.IsNonempty, () => n.Characteristics.IsNonempty))
                    {
                        reporter.Error(MessageSource.Resolver, n.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(1304L, "type parameter '{0}' is not allowed to change the requirement of being nonempty"), n.Name);
                    }
                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_39(1305L, () => o.Characteristics.ContainsNoReferenceTypes, () => n.Characteristics.ContainsNoReferenceTypes))
                    {
                        reporter.Error(MessageSource.Resolver, n.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(1311L, "type parameter '{0}' is not allowed to change the no-reference-type requirement"), n.Name);
                    }

                }
            }
            return typeMap;
        }

        private void CheckOverride_ResolvedParameters(IToken tok, List<Formal> old, List<Formal> nw, string name, string thing, string parameterKind, Dictionary<TypeParameter, Type> typeMap)
        {
            Contract.Requires(tok != null);
            Contract.Requires(old != null);
            Contract.Requires(nw != null);
            Contract.Requires(name != null);
            Contract.Requires(thing != null);
            Contract.Requires(parameterKind != null);
            Contract.Requires(typeMap != null);
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_20(1312L, old.Count, nw.Count))
            {
                reporter.Error(MessageSource.Resolver, tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(1317L, "{0} '{1}' is declared with a different number of {2} ({3} instead of {4}) than in the overridden {0}"),
                  thing, name, parameterKind, nw.Count, old.Count);
            }
            else
            {
                for (int i = MutateCSharp.Schemata405.ReplaceNumericConstant_1(1318L, 0); MutateCSharp.Schemata405.ReplaceBinExprOp_37(1322L, i, old.Count); MutateCSharp.Schemata405.ReplacePostfixUnaryExprOp_38(1327L, ref i))
                {
                    var o = old[i];
                    var n = nw[i];
                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(1328L, () => !o.IsGhost, () => n.IsGhost))
                    {
                        reporter.Error(MessageSource.Resolver, n.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(1334L, "{0} '{1}' of {2} {3} cannot be changed, compared to in the overridden {2}, from non-ghost to ghost"),
                          parameterKind, n.Name, thing, name);
                    }
                    else if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(1335L, () => o.IsGhost, () => !n.IsGhost))
                    {
                        reporter.Error(MessageSource.Resolver, n.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(1341L, "{0} '{1}' of {2} {3} cannot be changed, compared to in the overridden {2}, from ghost to non-ghost"),
                          parameterKind, n.Name, thing, name);
                    }
                    else if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(1342L, () => !o.IsOld, () => n.IsOld))
                    {
                        reporter.Error(MessageSource.Resolver, n.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(1348L, "{0} '{1}' of {2} {3} cannot be changed, compared to in the overridden {2}, from new to non-new"),
                          parameterKind, n.Name, thing, name);
                    }
                    else if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(1349L, () => o.IsOld, () => !n.IsOld))
                    {
                        reporter.Error(MessageSource.Resolver, n.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(1355L, "{0} '{1}' of {2} {3} cannot be changed, compared to in the overridden {2}, from non-new to new"),
                          parameterKind, n.Name, thing, name);
                    }
                    else if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(1356L, () => !o.IsOlder, () => n.IsOlder))
                    {
                        reporter.Error(MessageSource.Resolver, n.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(1362L, "{0} '{1}' of {2} {3} cannot be changed, compared to in the overridden {2}, from non-older to older"),
                          parameterKind, n.Name, thing, name);
                    }
                    else if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(1363L, () => o.IsOlder, () => !n.IsOlder))
                    {
                        reporter.Error(MessageSource.Resolver, n.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(1369L, "{0} '{1}' of {2} {3} cannot be changed, compared to in the overridden {2}, from older to non-older"),
                          parameterKind, n.Name, thing, name);
                    }
                    else
                    {
                        var oo = o.Type.Subst(typeMap);
                        if (!n.Type.Equals(oo, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1370L, true)))
                        {
                            reporter.Error(MessageSource.Resolver, n.tok,
              MutateCSharp.Schemata405.ReplaceStringConstant_6(1371L, "the type of {0} '{1}' is different from the type of the corresponding {0} in trait {2} ('{3}' instead of '{4}')"),
                              parameterKind, n.Name, thing, n.Type, oo);
                        }
                    }
                }
            }
        }

        private bool AreThereAnyObviousSignsOfEmptiness(Type type, ISet<IndDatatypeDecl> beingVisited)
        {
            type = type.NormalizeExpandKeepConstraints(); // cut through type proxies, type synonyms, but being mindful of what's in scope
            if (type is UserDefinedType { ResolvedClass: var cl } udt)
            {
                Contract.Assert(cl != null);
                if (cl is SubsetTypeDecl subsetTypeDecl)
                {
                    return AreThereAnyObviousSignsOfEmptiness(subsetTypeDecl.RhsWithArgument(udt.TypeArgs), beingVisited);
                }
                else if (cl is NewtypeDecl newtypeDecl)
                {
                    return AreThereAnyObviousSignsOfEmptiness(newtypeDecl.RhsWithArgument(udt.TypeArgs), beingVisited);
                }
                if (cl is IndDatatypeDecl datatypeDecl)
                {
                    if (beingVisited.Contains(datatypeDecl))
                    {
                        // This datatype may be empty, but it's definitely empty if we consider only the constructors that have been visited
                        // since AreThereAnyObviousSignsOfEmptiness was called from IsObviouslyEmpty.
                        return MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1372L, true);
                    }
                    beingVisited.Add(datatypeDecl);
                    var typeMap = TypeParameter.SubstitutionMap(datatypeDecl.TypeArgs, udt.TypeArgs);
                    var isEmpty = datatypeDecl.Ctors.TrueForAll(ctor =>
                      ctor.Formals.Exists(formal => AreThereAnyObviousSignsOfEmptiness(formal.Type.Subst(typeMap), beingVisited)));
                    beingVisited.Remove(datatypeDecl);
                    return isEmpty;
                }
            }

            return MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1373L, false);
        }

        /// <summary>
        /// Check that the SCC of 'startingPoint' can be carved up into stratospheres in such a way that each
        /// datatype has some value that can be constructed from datatypes in lower stratospheres only.
        /// The algorithm used here is quadratic in the number of datatypes in the SCC.  Since that number is
        /// deemed to be rather small, this seems okay.
        ///
        /// As a side effect of this checking, the GroundingCtor field is filled in (for every inductive datatype
        /// that passes the check).  It may be that several constructors could be used as the default, but
        /// only the first one encountered as recorded.  This particular choice is slightly more than an
        /// implementation detail, because it affects how certain cycles among inductive datatypes (having
        /// to do with the types used to instantiate type parameters of datatypes) are used.
        ///
        /// The role of the SCC here is simply to speed up this method.  It would still be correct if the
        /// equivalence classes in the given SCC were unions of actual SCC's.  In particular, this method
        /// would still work if "dependencies" consisted of one large SCC containing all the inductive
        /// datatypes in the module.
        /// </summary>
        void SccStratosphereCheck(IndDatatypeDecl startingPoint, Graph<IndDatatypeDecl/*!*/>/*!*/ dependencies)
        {
            Contract.Requires(startingPoint != null);
            Contract.Requires(dependencies != null);  // more expensive check: Contract.Requires(cce.NonNullElements(dependencies));

            var scc = dependencies.GetSCC(startingPoint);
            int totalCleared = MutateCSharp.Schemata405.ReplaceNumericConstant_1(1374L, 0);
            while (MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1378L, true))
            {
                int clearedThisRound = MutateCSharp.Schemata405.ReplaceNumericConstant_1(1379L, 0);
                foreach (var dt in scc)
                {
                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_65(1383L, dt.GroundingCtor, null))
                    {
                        // previously cleared
                    }
                    else if (ComputeGroundingCtor(dt))
                    {
                        Contract.Assert(dt.GroundingCtor != null);  // should have been set by the successful call to ComputeGroundingCtor)
                        MutateCSharp.Schemata405.ReplacePostfixUnaryExprOp_38(1384L, ref clearedThisRound);
                        MutateCSharp.Schemata405.ReplacePostfixUnaryExprOp_38(1385L, ref totalCleared);
                    }
                }
                if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(1386L, totalCleared, scc.Count))
                {
                    // all is good
                    return;
                }
                else if (MutateCSharp.Schemata405.ReplaceBinExprOp_20(1395L, clearedThisRound, MutateCSharp.Schemata405.ReplaceNumericConstant_1(1391L, 0)))
                {
                    // some progress was made, so let's keep going
                }
                else
                {
                    return;
                }
            }
        }

        /// <summary>
        /// Check if the datatype has some constructor all whose argument types can be constructed.
        /// Returns 'true' and sets dt.GroundingCtor if that is the case.
        /// </summary>
        bool ComputeGroundingCtor(IndDatatypeDecl dt)
        {
            Contract.Requires(dt != null);
            Contract.Requires(dt.GroundingCtor == null);  // the intention is that this method be called only when GroundingCtor hasn't already been set
            Contract.Ensures(!Contract.Result<bool>() || dt.GroundingCtor != null);

            // Stated differently, check that there is some constructor where no argument type goes to the same stratum.
            DatatypeCtor groundingCtor = null;
            ISet<TypeParameter> lastTypeParametersUsed = null;
            foreach (DatatypeCtor ctor in dt.Ctors)
            {
                var typeParametersUsed = new HashSet<TypeParameter>();
                foreach (Formal p in ctor.Formals)
                {
                    if (!CheckCanBeConstructed(p.Type, typeParametersUsed))
                    {
                        // the argument type (has a component which) is not yet known to be constructable
                        goto NEXT_OUTER_ITERATION;
                    }
                }
                // this constructor satisfies the requirements, check to see if it is a better fit than the
                // one found so far. Here, "better" means
                //   * a ghost constructor is better than a non-ghost constructor
                //   * among those, a constructor with fewer type arguments is better
                //   * among those, the first one is preferred.
                if (MutateCSharp.Schemata405.ReplaceBinExprOp_14(1418L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_14(1407L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_66(1400L, groundingCtor, null), () => (MutateCSharp.Schemata405.ReplaceBinExprOp_4(1401L, () => !groundingCtor.IsGhost, () => ctor.IsGhost))), () => MutateCSharp.Schemata405.ReplaceBinExprOp_37(1413L, typeParametersUsed.Count, lastTypeParametersUsed.Count)))
                {
                    groundingCtor = ctor;
                    lastTypeParametersUsed = typeParametersUsed;
                }

            NEXT_OUTER_ITERATION: { }
            }

            if (MutateCSharp.Schemata405.ReplaceBinExprOp_65(1424L, groundingCtor, null))
            {
                dt.GroundingCtor = groundingCtor;
                dt.TypeParametersUsedInConstructionByGroundingCtor = new bool[dt.TypeArgs.Count];
                for (int i = MutateCSharp.Schemata405.ReplaceNumericConstant_1(1425L, 0); MutateCSharp.Schemata405.ReplaceBinExprOp_37(1429L, i, dt.TypeArgs.Count); MutateCSharp.Schemata405.ReplacePostfixUnaryExprOp_38(1434L, ref i))
                {
                    dt.TypeParametersUsedInConstructionByGroundingCtor[i] = lastTypeParametersUsed.Contains(dt.TypeArgs[i]);
                }
                return MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1435L, true);
            }

            // no constructor satisfied the requirements, so this is an illegal datatype declaration
            return MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1436L, false);
        }

        bool CheckCanBeConstructed(Type type, ISet<TypeParameter> typeParametersUsed)
        {
            type = type.NormalizeExpandKeepConstraints();
            if (type is BasicType)
            {
                // values of primitive types can always be constructed
                return MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1437L, true);
            }
            else if (type is CollectionType)
            {
                // values of collection types can always be constructed
                return MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1438L, true);
            }

            var udt = (UserDefinedType)type;
            var cl = udt.ResolvedClass;
            Contract.Assert(cl != null);
            if (cl is TypeParameter)
            {
                // treat a type parameter like a ground type
                typeParametersUsed.Add((TypeParameter)cl);
                return MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1439L, true);
            }
            else if (cl is AbstractTypeDecl)
            {
                // an opaque is like a ground type
                return MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1440L, true);
            }
            else if (cl is InternalTypeSynonymDecl)
            {
                // a type exported as opaque from another module is like a ground type
                return MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1441L, true);
            }
            else if (cl is NewtypeDecl)
            {
                // values of a newtype can be constructed
                return MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1442L, true);
            }
            else if (cl is SubsetTypeDecl)
            {
                var td = (SubsetTypeDecl)cl;
                if (MutateCSharp.Schemata405.ReplaceBinExprOp_33(1443L, td.Witness, null))
                {
                    // a witness exists, but may depend on type parameters
                    type.AddFreeTypeParameters(typeParametersUsed);
                    return MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1444L, true);
                }
                else if (MutateCSharp.Schemata405.ReplaceBinExprOp_34(1445L, td.WitnessKind, SubsetTypeDecl.WKind.Special))
                {
                    // WKind.Special is only used with -->, ->, and non-null types:
                    Contract.Assert(ArrowType.IsPartialArrowTypeName(td.Name) || ArrowType.IsTotalArrowTypeName(td.Name) || td is NonNullTypeDecl);
                    if (ArrowType.IsTotalArrowTypeName(td.Name))
                    {
                        return CheckCanBeConstructed(udt.TypeArgs.Last(), typeParametersUsed);
                    }
                    else
                    {
                        return MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1446L, true);
                    }
                }
                else
                {
                    return CheckCanBeConstructed(td.RhsWithArgument(udt.TypeArgs), typeParametersUsed);
                }
            }
            else if (cl is TraitDecl traitDecl)
            {
                return traitDecl.IsReferenceTypeDecl; // null is a value for reference types
            }
            else if (cl is ClassDecl)
            {
                // null is a value for this possibly-null type
                return MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1447L, true);
            }
            else if (cl is ArrowTypeDecl)
            {
                return MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1448L, true);
            }
            else if (cl is CoDatatypeDecl)
            {
                // may depend on type parameters
                type.AddFreeTypeParameters(typeParametersUsed);
                return MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1449L, true);
            }

            var dependee = type.AsIndDatatype;
            Contract.Assert(dependee != null);
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_66(1450L, dependee.GroundingCtor, null))
            {
                // the type is an inductive datatype that we don't yet know how to construct
                return MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1451L, false);
            }
            // also check the type arguments of the inductive datatype
            Contract.Assert(udt.TypeArgs.Count == dependee.TypeParametersUsedInConstructionByGroundingCtor.Length);
            var i = MutateCSharp.Schemata405.ReplaceNumericConstant_1(1452L, 0);
            foreach (var ta in udt.TypeArgs)
            {
                if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(1456L, () => dependee.TypeParametersUsedInConstructionByGroundingCtor[i], () => !CheckCanBeConstructed(ta, typeParametersUsed)))
                {
                    return MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1462L, false);
                }

                MutateCSharp.Schemata405.ReplacePostfixUnaryExprOp_38(1463L, ref i);
            }
            return MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1464L, true);
        }

        void DetermineEqualitySupport(IndDatatypeDecl startingPoint, Graph<IndDatatypeDecl/*!*/>/*!*/ dependencies)
        {
            Contract.Requires(startingPoint != null);
            Contract.Requires(dependencies != null);  // more expensive check: Contract.Requires(cce.NonNullElements(dependencies));

            var scc = dependencies.GetSCC(startingPoint);

            void MarkSCCAsNotSupportingEquality()
            {
                foreach (var ddtt in scc)
                {
                    ddtt.EqualitySupport = IndDatatypeDecl.ES.Never;
                }
            }

            // Look for conditions that make the whole SCC incapable of providing the equality operation:
            //   * a datatype in the SCC has a ghost constructor
            //   * a parameter of an inductive datatype in the SCC is ghost
            //   * the type of a parameter of an inductive datatype in the SCC does not support equality
            foreach (var dt in scc)
            {
                Contract.Assume(dt.EqualitySupport == IndDatatypeDecl.ES.NotYetComputed);
                foreach (var ctor in dt.Ctors)
                {
                    if (ctor.IsGhost)
                    {
                        MarkSCCAsNotSupportingEquality();
                        return;  // we are done
                    }
                    foreach (var arg in ctor.Formals)
                    {
                        var anotherIndDt = arg.Type.AsIndDatatype;
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_14(1485L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_14(1479L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_14(1473L, () => arg.IsGhost, () => (MutateCSharp.Schemata405.ReplaceBinExprOp_4(1467L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_40(1465L, anotherIndDt, null), () => MutateCSharp.Schemata405.ReplaceBinExprOp_67(1466L, anotherIndDt.EqualitySupport, IndDatatypeDecl.ES.Never)))), () => arg.Type.IsCoDatatype), () => arg.Type.IsArrowType))
                        {
                            // arg.Type is known never to support equality
                            MarkSCCAsNotSupportingEquality();
                            return;  // we are done
                        }
                    }
                }
            }

            // Now for the more involved case:  we need to determine which type parameters determine equality support for each datatype in the SCC
            // We start by seeing where each datatype's type parameters are used in a place known to determine equality support.
            bool thingsChanged = MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1491L, false);
            foreach (var dt in scc)
            {
                if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(1496L, dt.TypeArgs.Count, MutateCSharp.Schemata405.ReplaceNumericConstant_1(1492L, 0)))
                {
                    // if the datatype has no type parameters, we certainly won't find any type parameters being used in the arguments types to the constructors
                    continue;
                }
                foreach (var ctor in dt.Ctors)
                {
                    foreach (var arg in ctor.Formals)
                    {
                        var typeArg = arg.Type.AsTypeParameter;
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_68(1501L, typeArg, null))
                        {
                            typeArg.NecessaryForEqualitySupportOfSurroundingInductiveDatatype = MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1502L, true);
                            thingsChanged = MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1503L, true);
                        }
                        else
                        {
                            var otherDt = arg.Type.AsIndDatatype;
                            if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(1506L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_40(1504L, otherDt, null), () => MutateCSharp.Schemata405.ReplaceBinExprOp_67(1505L, otherDt.EqualitySupport, IndDatatypeDecl.ES.ConsultTypeArguments)))
                            {  // datatype is in a different SCC
                                var otherUdt = (UserDefinedType)arg.Type.NormalizeExpand();
                                var i = MutateCSharp.Schemata405.ReplaceNumericConstant_1(1512L, 0);
                                foreach (var otherTp in otherDt.TypeArgs)
                                {
                                    if (otherTp.NecessaryForEqualitySupportOfSurroundingInductiveDatatype)
                                    {
                                        var tp = otherUdt.TypeArgs[i].AsTypeParameter;
                                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_68(1516L, tp, null))
                                        {
                                            tp.NecessaryForEqualitySupportOfSurroundingInductiveDatatype = MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1517L, true);
                                            thingsChanged = MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1518L, true);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            // Then we propagate this information up through the SCC
            while (thingsChanged)
            {
                thingsChanged = MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1519L, false);
                foreach (var dt in scc)
                {
                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(1524L, dt.TypeArgs.Count, MutateCSharp.Schemata405.ReplaceNumericConstant_1(1520L, 0)))
                    {
                        // if the datatype has no type parameters, we certainly won't find any type parameters being used in the arguments types to the constructors
                        continue;
                    }
                    foreach (var ctor in dt.Ctors)
                    {
                        foreach (var arg in ctor.Formals)
                        {
                            var otherDt = arg.Type.AsIndDatatype;
                            if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(1531L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_40(1529L, otherDt, null), () => MutateCSharp.Schemata405.ReplaceBinExprOp_67(1530L, otherDt.EqualitySupport, IndDatatypeDecl.ES.NotYetComputed)))
                            { // otherDt lives in the same SCC
                                var otherUdt = (UserDefinedType)arg.Type.NormalizeExpand();
                                var i = MutateCSharp.Schemata405.ReplaceNumericConstant_1(1537L, 0);
                                foreach (var otherTp in otherDt.TypeArgs)
                                {
                                    if (otherTp.NecessaryForEqualitySupportOfSurroundingInductiveDatatype)
                                    {
                                        var tp = otherUdt.TypeArgs[i].AsTypeParameter;
                                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(1542L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_68(1541L, tp, null), () => !tp.NecessaryForEqualitySupportOfSurroundingInductiveDatatype))
                                        {
                                            tp.NecessaryForEqualitySupportOfSurroundingInductiveDatatype = MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1548L, true);
                                            thingsChanged = MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1549L, true);
                                        }
                                    }

                                    MutateCSharp.Schemata405.ReplacePostfixUnaryExprOp_38(1550L, ref i);
                                }
                            }
                        }
                    }
                }
            }
            // Now that we have computed the .NecessaryForEqualitySupportOfSurroundingInductiveDatatype values, mark the datatypes as ones
            // where equality support should be checked by looking at the type arguments.
            foreach (var dt in scc)
            {
                dt.EqualitySupport = IndDatatypeDecl.ES.ConsultTypeArguments;
            }
        }

        /// <summary>
        /// Check to see if the attribute is one that is supported by Dafny.  What check performed here is,
        /// unfortunately, just an approximation, since the usage rules of a particular attribute is checked
        /// elsewhere (for example, in the compiler or verifier).  It would be nice to improve this.
        /// </summary>
        bool IsRecognizedAttribute(UserSuppliedAttributes a, IAttributeBearingDeclaration host)
        {
            Contract.Requires(a != null);
            Contract.Requires(host != null);
            switch (a.Name)
            {
                case "opaque":
                    return host is Function && !(host is ExtremePredicate);
                    break;
                case "trigger":
                    return host is ComprehensionExpr || host is SetComprehension || host is MapComprehension;
                    break;
                case "timeLimit":
                case "timeLimitMultiplier":
                    return host is TopLevelDecl;
                    break;
                case "tailrecursive":
                    return host is Method && !((Method)host).IsGhost;
                    break;
                case "autocontracts":
                    return host is ClassLikeDecl { IsReferenceTypeDecl: true };
                    break;
                case "autoreq":
                    return host is Function;
                    break;
                case "abstemious":
                    return host is Function;
                    break;
                case "options":
                    return host is ModuleDefinition;
                    break;
                default:
                    return false;
                    break;
            }

            return default;
        }

        public void ScopePushAndReport(Scope<IVariable> scope, IVariable v, string kind)
        {
            Contract.Requires(scope != null);
            Contract.Requires(v != null);
            Contract.Requires(kind != null);
            ScopePushAndReport(scope, v.Name, v, v.Tok, kind);
        }

        void ScopePushAndReport<Thing>(Scope<Thing> scope, string name, Thing thing, IToken tok, string kind) where Thing : class
        {
            Contract.Requires(scope != null);
            Contract.Requires(name != null);
            Contract.Requires(thing != null);
            Contract.Requires(tok != null);
            Contract.Requires(kind != null);
            var r = scope.Push(name, thing);
            switch (r)
            {
                case Scope<Thing>.PushResult.Success:
                    break;
                    break;
                case Scope<Thing>.PushResult.Duplicate:
                    reporter.Error(MessageSource.Resolver, ResolutionErrors.ErrorId.none, tok, "Duplicate {0} name: {1}", kind, name);
                    break;
                    break;
                case Scope<Thing>.PushResult.Shadow:
                    reporter.Warning(MessageSource.Resolver, ResolutionErrors.ErrorId.none, tok, "Shadowed {0} name: {1}", kind, name);
                    break;
                    break;
            }
        }

        /// <summary>
        /// Assumes type parameters have already been pushed
        /// </summary>
        public void ResolveFunctionSignature(Function f)
        {
            Contract.Requires(f != null);
            scope.PushMarker();
            if (f.SignatureIsOmitted)
            {
                reporter.Error(MessageSource.Resolver, f, MutateCSharp.Schemata405.ReplaceStringConstant_6(1551L, "function signature can be omitted only in refining functions"));
            }
            var option = MutateCSharp.Schemata405.ReplaceBinExprOp_7(1556L, f.TypeArgs.Count, MutateCSharp.Schemata405.ReplaceNumericConstant_1(1552L, 0)) ? new ResolveTypeOption(f) : new ResolveTypeOption(ResolveTypeOptionEnum.AllowPrefix);
            foreach (Formal p in f.Ins)
            {
                ScopePushAndReport(scope, p, MutateCSharp.Schemata405.ReplaceStringConstant_6(1561L, "parameter"));
                ResolveType(p.tok, p.Type, f, option, f.TypeArgs);
            }
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_69(1562L, f.Result, null))
            {
                ScopePushAndReport(scope, f.Result, MutateCSharp.Schemata405.ReplaceStringConstant_6(1563L, "parameter/return"));
                ResolveType(f.Result.tok, f.Result.Type, f, option, f.TypeArgs);
            }
            else
            {
                ResolveType(f.tok, f.ResultType, f, option, f.TypeArgs);
            }
            scope.PopMarker();
        }

        /// <summary>
        /// This method can be called even if the resolution of "fe" failed; in that case, this method will
        /// not issue any error message.
        /// </summary>
        public void DisallowNonGhostFieldSpecifiers(FrameExpression fe)
        {
            Contract.Requires(fe != null);
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(1565L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_51(1564L, fe.Field, null), () => !fe.Field.IsGhost))
            {
                reporter.Error(MessageSource.Resolver, fe.E, MutateCSharp.Schemata405.ReplaceStringConstant_6(1571L, "in a ghost context, only ghost fields can be mentioned as modifies frame targets ({0})"), fe.FieldName);
            }
        }

        /// <summary>
        /// Assumes type parameters have already been pushed
        /// </summary>
        public void ResolveMethodSignature(Method m)
        {
            Contract.Requires(m != null);

            scope.PushMarker();
            if (m.SignatureIsOmitted)
            {
                reporter.Error(MessageSource.Resolver, m, MutateCSharp.Schemata405.ReplaceStringConstant_6(1572L, "method signature can be omitted only in refining methods"));
            }
            var option = MutateCSharp.Schemata405.ReplaceBinExprOp_7(1577L, m.TypeArgs.Count, MutateCSharp.Schemata405.ReplaceNumericConstant_1(1573L, 0)) ? new ResolveTypeOption(m) : new ResolveTypeOption(ResolveTypeOptionEnum.AllowPrefix);
            // resolve in-parameters
            foreach (Formal p in m.Ins)
            {
                ScopePushAndReport(scope, p, MutateCSharp.Schemata405.ReplaceStringConstant_6(1582L, "parameter"));
                ResolveType(p.tok, p.Type, m, option, m.TypeArgs);
            }
            // resolve out-parameters
            foreach (Formal p in m.Outs)
            {
                ScopePushAndReport(scope, p, MutateCSharp.Schemata405.ReplaceStringConstant_6(1583L, "parameter"));
                ResolveType(p.tok, p.Type, m, option, m.TypeArgs);
            }
            scope.PopMarker();
        }

        /// <summary>
        /// Assumes type parameters have already been pushed
        /// </summary>
        void ResolveIteratorSignature(IteratorDecl iter)
        {
            Contract.Requires(iter != null);
            scope.PushMarker();
            if (iter.SignatureIsOmitted)
            {
                reporter.Error(MessageSource.Resolver, iter, MutateCSharp.Schemata405.ReplaceStringConstant_6(1584L, "iterator signature can be omitted only in refining methods"));
            }
            var initiallyNoTypeArguments = MutateCSharp.Schemata405.ReplaceBinExprOp_7(1589L, iter.TypeArgs.Count, MutateCSharp.Schemata405.ReplaceNumericConstant_1(1585L, 0));
            var option = initiallyNoTypeArguments ? new ResolveTypeOption(iter) : new ResolveTypeOption(ResolveTypeOptionEnum.AllowPrefix);
            // resolve the types of the parameters
            var prevErrorCount = reporter.Count(ErrorLevel.Error);
            foreach (var p in iter.Ins)
            {
                ResolveType(p.tok, p.Type, iter, option, iter.TypeArgs);
            }
            foreach (var p in iter.Outs)
            {
                ResolveType(p.tok, p.Type, iter, option, iter.TypeArgs);
                if (!p.Type.KnownToHaveToAValue(p.IsGhost))
                {
                    reporter.Error(MessageSource.Resolver, p.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(1594L, "type of yield-parameter must support auto-initialization (got '{0}')"), p.Type);
                }
            }
            // resolve the types of the added fields (in case some of these types would cause the addition of default type arguments)
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(1595L, prevErrorCount, reporter.Count(ErrorLevel.Error)))
            {
                foreach (var p in iter.OutsHistoryFields)
                {
                    ResolveType(p.tok, p.Type, iter, option, iter.TypeArgs);
                }
            }
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_20(1600L, iter.TypeArgs.Count, iter.NonNullTypeDecl.TypeArgs.Count))
            {
                // Apparently, the type resolution automatically added type arguments to the iterator. We'll add these to the
                // corresponding non-null type as well.
                Contract.Assert(initiallyNoTypeArguments);
                Contract.Assert(iter.NonNullTypeDecl.TypeArgs.Count == 0);
                var nnt = iter.NonNullTypeDecl;
                nnt.TypeArgs.AddRange(iter.TypeArgs.ConvertAll(tp => new TypeParameter(tp.RangeToken, tp.NameNode, tp.VarianceSyntax, tp.Characteristics)));
                var varUdt = (UserDefinedType)nnt.Var.Type;
                Contract.Assert(varUdt.TypeArgs.Count == 0);
                varUdt.TypeArgs = nnt.TypeArgs.ConvertAll(tp => (Type)new UserDefinedType(tp));
            }
            scope.PopMarker();
        }

        // Like the ResolveTypeOptionEnum, but iff the case of AllowPrefixExtend, it also
        // contains a pointer to its Parent class, to fill in default type parameters properly.
        public class ResolveTypeOption
        {
            public readonly ResolveTypeOptionEnum Opt;
            public readonly TypeParameter.ParentType Parent;
            [ContractInvariantMethod]
            void ObjectInvariant()
            {
                Contract.Invariant((Opt == ResolveTypeOptionEnum.AllowPrefixExtend) == (Parent != null));
            }

            public ResolveTypeOption(ResolveTypeOptionEnum opt)
            {
                Contract.Requires(opt != ResolveTypeOptionEnum.AllowPrefixExtend);
                Parent = null;
                Opt = opt;
            }

            public ResolveTypeOption(TypeParameter.ParentType parent)
            {
                Contract.Requires(parent != null);
                Opt = ResolveTypeOptionEnum.AllowPrefixExtend;
                Parent = parent;
            }
        }

        /// <summary>
        /// Returns a resolved type denoting an array type with dimension "dims" and element type "arg".
        /// Callers are expected to provide "arg" as an already resolved type.  (Note, a proxy type is resolved--
        /// only types that contain identifiers stand the possibility of not being resolved.)
        /// </summary>
        internal Type ResolvedArrayType(IToken tok, int dims, Type arg, ResolutionContext resolutionContext, bool useClassNameType)
        {
            Contract.Requires(tok != null);
            Contract.Requires(1 <= dims);
            Contract.Requires(arg != null);
            var (at, modBuiltins) = SystemModuleManager.ArrayType(tok, dims, new List<Type> { arg }, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1605L, false), useClassNameType);
            modBuiltins(SystemModuleManager);
            ResolveType(tok, at, resolutionContext, ResolveTypeOptionEnum.DontInfer, null);
            return at;
        }

        public Expression VarDotMethod(IToken tok, string varname, string methodname)
        {
            return new ApplySuffix(tok, null, new ExprDotName(tok, new IdentifierExpr(tok, varname), methodname, null), new List<ActualBinding>(), tok);
        }

        public Expression makeTemp(String prefix, AssignOrReturnStmt s, ResolutionContext resolutionContext, Expression ex)
        {
            var temp = FreshTempVarName(prefix, resolutionContext.CodeContext);
            var locvar = new LocalVariable(s.RangeToken, temp, ex.Type, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1606L, false));
            var id = new IdentifierExpr(s.Tok, temp);
            var idlist = new List<Expression>() { id };
            var lhss = new List<LocalVariable>() { locvar };
            var rhss = new List<AssignmentRhs>() { new ExprRhs(ex) };
            var up = new UpdateStmt(s.RangeToken, idlist, rhss);
            s.ResolvedStatements.Add(new VarDeclStmt(s.RangeToken, lhss, up));
            return id;
        }

        public void EnsureSupportsErrorHandling(IToken tok, Type tp, bool expectExtract, [CanBeNull] string keyword)
        {
            // The "method not found" errors which will be generated here were already reported while
            // resolving the statement, so we don't want them to reappear and redirect them into a sink.
            var origReporter = reporter;
            this.reporter = new ErrorReporterSink(Options);

            var isFailure = ResolveMember(tok, tp, MutateCSharp.Schemata405.ReplaceStringConstant_6(1607L, "IsFailure"), out _);
            var propagateFailure = ResolveMember(tok, tp, MutateCSharp.Schemata405.ReplaceStringConstant_6(1608L, "PropagateFailure"), out _);
            var extract = ResolveMember(tok, tp, MutateCSharp.Schemata405.ReplaceStringConstant_6(1609L, "Extract"), out _);

            if (keyword != null)
            {
                if (MutateCSharp.Schemata405.ReplaceBinExprOp_14(1618L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_10(1610L, isFailure, null), () => MutateCSharp.Schemata405.ReplaceBinExprOp_39(1612L, () => (MutateCSharp.Schemata405.ReplaceBinExprOp_11(1611L, extract, null)), () => expectExtract)))
                {
                    // more details regarding which methods are missing have already been reported by regular resolution
                    var requiredMembers = expectExtract
                      ? MutateCSharp.Schemata405.ReplaceStringConstant_6(1624L, "functions 'IsFailure()' and 'Extract()'"
          ) : MutateCSharp.Schemata405.ReplaceStringConstant_6(1625L, "function 'IsFailure()', but not 'Extract()'");
                    origReporter.Error(MessageSource.Resolver, tok,
                      $"The right-hand side of ':- {keyword}', which is of type '{tp}', with a keyword token must have {requiredMembers}");
                }
            }
            else
            {
                if (MutateCSharp.Schemata405.ReplaceBinExprOp_14(1641L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_14(1628L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_10(1626L, isFailure, null), () => MutateCSharp.Schemata405.ReplaceBinExprOp_10(1627L, propagateFailure, null)), () => MutateCSharp.Schemata405.ReplaceBinExprOp_39(1635L, () => (MutateCSharp.Schemata405.ReplaceBinExprOp_11(1634L, extract, null)), () => expectExtract)))
                {
                    // more details regarding which methods are missing have already been reported by regular resolution
                    var requiredMembers = expectExtract
                      ? MutateCSharp.Schemata405.ReplaceStringConstant_6(1647L, "functions 'IsFailure()', 'PropagateFailure()', and 'Extract()'"
          ) : MutateCSharp.Schemata405.ReplaceStringConstant_6(1648L, "functions 'IsFailure()' and 'PropagateFailure()', but not 'Extract()'");
                    origReporter.Error(MessageSource.Resolver, tok, $"The right-hand side of ':-', which is of type '{tp}', must have {requiredMembers}");
                }
            }

            void CheckIsFunction([CanBeNull] MemberDecl memberDecl, bool allowMethod)
            {
                if (MutateCSharp.Schemata405.ReplaceBinExprOp_14(1650L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_10(1649L, memberDecl, null), () => memberDecl is Function))
                {
                    // fine
                }
                else if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(1656L, () => allowMethod, () => memberDecl is Method))
                {
                    // give a deprecation warning, so we will remove this language feature around the Dafny 4 time frame
                    origReporter.Deprecated(MessageSource.Resolver, ErrorId.r_failure_methods_deprecated, tok,
                      $"Support for member '{memberDecl.Name}' in type '{tp}' (used indirectly via a :- statement) being a method is deprecated;" +
          MutateCSharp.Schemata405.ReplaceStringConstant_6(1662L, " declare it to be a function instead"));
                }
                else
                {
                    // not allowed
                    origReporter.Error(MessageSource.Resolver, tok,
                      $"Member '{memberDecl.Name}' in type '{tp}' (used indirectly via a :- statement) is expected to be a function");
                }
            }

            CheckIsFunction(isFailure, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1663L, false));
            if (keyword == null)
            {
                CheckIsFunction(propagateFailure, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1664L, true));
            }
            if (expectExtract)
            {
                CheckIsFunction(extract, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1665L, true));
            }

            this.reporter = origReporter;
        }

        /// <summary>
        /// Check that "stmt" is a valid statment for the body of an assert-by, forall,
        /// or calc-hint statement. In particular, check that the local variables assigned in
        /// the bodies of these statements are declared in the statements, not in some enclosing
        /// context. 
        /// </summary>
        public void CheckLocalityUpdates(Statement stmt, ISet<LocalVariable> localsAllowedInUpdates, string where)
        {
            // TODO it looks like this method has no side-effects and doesn't return anything.
            Contract.Requires(stmt != null);
            Contract.Requires(localsAllowedInUpdates != null);
            Contract.Requires(where != null);

            if (MutateCSharp.Schemata405.ReplaceBinExprOp_14(1678L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_14(1672L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_14(1666L, () => stmt is AssertStmt, () => stmt is ForallStmt), () => stmt is CalcStmt), () => stmt is ModifyStmt))
            {
                // don't recurse, since CheckHintRestrictions will be called on that assert-by separately
                return;
            }
            else if (stmt is AssignSuchThatStmt)
            {
                var s = (AssignSuchThatStmt)stmt;
                foreach (var lhs in s.Lhss)
                {
                    CheckLocalityUpdatesLhs(lhs, localsAllowedInUpdates, @where);
                }
            }
            else if (stmt is AssignStmt)
            {
                var s = (AssignStmt)stmt;
                CheckLocalityUpdatesLhs(s.Lhs, localsAllowedInUpdates, @where);
            }
            else if (stmt is CallStmt)
            {
                var s = (CallStmt)stmt;
                foreach (var lhs in s.Lhs)
                {
                    CheckLocalityUpdatesLhs(lhs, localsAllowedInUpdates, @where);
                }
            }
            else if (stmt is VarDeclStmt)
            {
                var s = (VarDeclStmt)stmt;
                s.Locals.ForEach(local => localsAllowedInUpdates.Add(local));
            }
            else if (stmt is ModifyStmt)
            {
                // no further complaints (note, ghost interests have already checked for 'modify' statements)
            }
            else if (stmt is BlockStmt)
            {
                localsAllowedInUpdates = new HashSet<LocalVariable>(localsAllowedInUpdates);
                // use this new set for the recursive calls
            }

            foreach (var ss in stmt.SubStatements)
            {
                CheckLocalityUpdates(ss, localsAllowedInUpdates, where);
            }
        }

        void CheckLocalityUpdatesLhs(Expression lhs, ISet<LocalVariable> localsAllowedInUpdates, string @where)
        {
            Contract.Requires(lhs != null);
            Contract.Requires(localsAllowedInUpdates != null);
            Contract.Requires(where != null);

            lhs = lhs.Resolved;
            if (lhs is IdentifierExpr idExpr && !localsAllowedInUpdates.Contains(idExpr.Var))
            {
                reporter.Error(MessageSource.Resolver, lhs.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(1684L, "{0} is not allowed to update a variable it doesn't declare"), where);
            }
        }

        public
            class LazyString_OnTypeEquals
        {
            Type t0;
            Type t1;
            string s;
            public LazyString_OnTypeEquals(Type t0, Type t1, string s)
            {
                Contract.Requires(t0 != null);
                Contract.Requires(t1 != null);
                Contract.Requires(s != null);
                this.t0 = t0;
                this.t1 = t1;
                this.s = s;
            }
            public override string ToString()
            {
                return t0.Equals(t1) ? s : "";
            }
        }

        void FindAllMembers(ClassLikeDecl cl, string memberName, ISet<MemberDecl> foundSoFar)
        {
            Contract.Requires(cl != null);
            Contract.Requires(memberName != null);
            Contract.Requires(foundSoFar != null);
            if (GetClassMembers(cl).TryGetValue(memberName, out var member))
            {
                foundSoFar.Add(member);
            }
            cl.ParentTraitHeads.ForEach(trait => FindAllMembers(trait, memberName, foundSoFar));
        }

        // TODO move
        public static UserDefinedType GetThisType(IToken tok, TopLevelDeclWithMembers cl)
        {
            Contract.Requires(tok != null);
            Contract.Requires(cl != null);
            Contract.Ensures(Contract.Result<UserDefinedType>() != null);

            if (cl is ClassLikeDecl { NonNullTypeDecl: { } } cls)
            {
                return UserDefinedType.FromTopLevelDecl(tok, cls.NonNullTypeDecl, cls.TypeArgs);
            }
            else
            {
                return UserDefinedType.FromTopLevelDecl(tok, cl, cl.TypeArgs);
            }

            return default;
        }

        // TODO move
        public static UserDefinedType GetReceiverType(IToken tok, MemberDecl member)
        {
            Contract.Requires(tok != null);
            Contract.Requires(member != null);
            Contract.Ensures(Contract.Result<UserDefinedType>() != null);

            return GetThisType(tok, (TopLevelDeclWithMembers)member.EnclosingClass);
        }

        internal Expression VarDotFunction(IToken tok, string varname, string functionname)
        {
            return new ApplySuffix(tok, null, new ExprDotName(tok, new IdentifierExpr(tok, varname), functionname, null), new List<ActualBinding>(), tok);
        }

        // TODO search for occurrences of "new LetExpr" which could benefit from this helper
        internal LetExpr LetPatIn(IToken tok, CasePattern<BoundVar> lhs, Expression rhs, Expression body)
        {
            return new LetExpr(tok, new List<CasePattern<BoundVar>>() { lhs }, new List<Expression>() { rhs }, body, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1685L, true));
        }

        internal LetExpr LetVarIn(IToken tok, string name, Type tp, Expression rhs, Expression body)
        {
            var lhs = new CasePattern<BoundVar>(tok, new BoundVar(tok, name, tp));
            return LetPatIn(tok, lhs, rhs, body);
        }

        /// <summary>
        ///  If expr.Lhs != null: Desugars "var x: T :- E; F" into "var temp := E; if temp.IsFailure() then temp.PropagateFailure() else var x: T := temp.Extract(); F"
        ///  If expr.Lhs == null: Desugars "         :- E; F" into "var temp := E; if temp.IsFailure() then temp.PropagateFailure() else                             F"
        /// </summary>
        public void ResolveLetOrFailExpr(LetOrFailExpr expr, ResolutionContext resolutionContext)
        {
            var temp = FreshTempVarName(MutateCSharp.Schemata405.ReplaceStringConstant_6(1686L, "valueOrError"), resolutionContext.CodeContext);
            var tempType = new InferredTypeProxy();
            // "var temp := E;"
            expr.ResolvedExpression = LetVarIn(expr.tok, temp, tempType, expr.Rhs,
              // "if temp.IsFailure()"
              new ITEExpr(expr.tok, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1687L, false), VarDotFunction(expr.tok, temp, MutateCSharp.Schemata405.ReplaceStringConstant_6(1688L, "IsFailure")),
                // "then temp.PropagateFailure()"
                VarDotFunction(expr.tok, temp, MutateCSharp.Schemata405.ReplaceStringConstant_6(1689L, "PropagateFailure")),
      MutateCSharp.Schemata405.ReplaceBinExprOp_70(1690L,
                // "else"
                expr.Lhs, null
      )
                  // "F"
                  ? expr.Body
                  // "var x: T := temp.Extract(); F"
                  : LetPatIn(expr.tok, expr.Lhs, VarDotFunction(expr.tok, temp, MutateCSharp.Schemata405.ReplaceStringConstant_6(1691L, "Extract")), expr.Body)));

            ResolveExpression(expr.ResolvedExpression, resolutionContext);
            expr.Type = expr.ResolvedExpression.Type;
            bool expectExtract = (MutateCSharp.Schemata405.ReplaceBinExprOp_71(1692L, expr.Lhs, null));
            EnsureSupportsErrorHandling(expr.tok, PartiallyResolveTypeForMemberSelection(expr.tok, tempType), expectExtract, null);
        }

        public static Type SelectAppropriateArrowTypeForFunction(Function function, Dictionary<TypeParameter, Type> subst, SystemModuleManager systemModuleManager)
        {
            return SelectAppropriateArrowType(function.tok,
              function.Ins.ConvertAll(formal => formal.Type.Subst(subst)),
              function.ResultType.Subst(subst),
      MutateCSharp.Schemata405.ReplaceBinExprOp_20(1697L, function.Reads.Expressions.Count, MutateCSharp.Schemata405.ReplaceNumericConstant_1(1693L, 0)), MutateCSharp.Schemata405.ReplaceBinExprOp_20(1706L, function.Req.Count, MutateCSharp.Schemata405.ReplaceNumericConstant_1(1702L, 0)),
              systemModuleManager);
        }

        public static Type SelectAppropriateArrowType(IToken tok, List<Type> typeArgs, Type resultType, bool hasReads, bool hasReq, SystemModuleManager systemModuleManager)
        {
            Contract.Requires(tok != null);
            Contract.Requires(typeArgs != null);
            Contract.Requires(resultType != null);
            var arity = typeArgs.Count;
            var typeArgsAndResult = Util.Snoc(typeArgs, resultType);
            if (hasReads)
            {
                // any arrow
                return new ArrowType(tok, systemModuleManager.ArrowTypeDecls[arity], typeArgsAndResult);
            }
            else if (hasReq)
            {
                // partial arrow
                return new UserDefinedType(tok, ArrowType.PartialArrowTypeName(arity), systemModuleManager.PartialArrowTypeDecls[arity], typeArgsAndResult);
            }
            else
            {
                // total arrow
                return new UserDefinedType(tok, ArrowType.TotalArrowTypeName(arity), systemModuleManager.TotalArrowTypeDecls[arity], typeArgsAndResult);
            }

            return default;
        }

        /// <summary>
        /// Adds appropriate type constraints that says "expr" evaluates to an integer or (if "allowBitVector" is true) a
        /// a bitvector.  The "errFormat" string can contain a "{0}", referring to the name of the type of "expr".
        /// </summary>
        public void ConstrainToIntegerType(Expression expr, bool allowBitVector, string errFormat)
        {
            Contract.Requires(expr != null);
            Contract.Requires(errFormat != null);
            var err = new TypeConstraint.ErrorMsgWithToken(expr.tok, errFormat, expr.Type);
            ConstrainToIntegerType(expr.tok, expr.Type, allowBitVector, err);
        }

        /// <summary>
        /// Resolves a NestedMatchExpr by
        /// 1 - checking that all of its patterns are linear
        /// 2 - desugaring it into a decision tree of MatchExpr and ITEEXpr (for constant matching)
        /// 3 - resolving the generated (sub)expression.
        /// </summary>
        void ResolveNestedMatchExpr(NestedMatchExpr nestedMatchExpr, ResolutionContext resolutionContext)
        {
            Contract.Requires(nestedMatchExpr != null);
            Contract.Requires(resolutionContext != null);

            nestedMatchExpr.Resolve(this, resolutionContext);
        }

        void ResolveCasePattern<VT>(CasePattern<VT> pat, Type sourceType, ResolutionContext resolutionContext)
          where VT : class, IVariable
        {
            Contract.Requires(pat != null);
            Contract.Requires(sourceType != null);
            Contract.Requires(resolutionContext != null);

            DatatypeDecl dtd = null;
            UserDefinedType udt = null;
            if (sourceType.IsDatatype)
            {
                udt = (UserDefinedType)sourceType.NormalizeExpand();
                dtd = (DatatypeDecl)udt.ResolvedClass;
            }
            // Find the constructor in the given datatype
            // If what was parsed was just an identifier, we will interpret it as a datatype constructor, if possible
            DatatypeCtor ctor = null;
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_72(1711L, dtd, null))
            {
                if (MutateCSharp.Schemata405.ReplaceBinExprOp_14(1718L, () => pat.Var == null, () => (MutateCSharp.Schemata405.ReplaceBinExprOp_4(1712L, () => pat.Var != null, () => pat.Var.Type is TypeProxy))))
                {
                    if (dtd.ConstructorsByName.TryGetValue(pat.Id, out ctor))
                    {
                        if (pat.Arguments == null)
                        {
                            if (MutateCSharp.Schemata405.ReplaceBinExprOp_20(1728L, ctor.Formals.Count, MutateCSharp.Schemata405.ReplaceNumericConstant_1(1724L, 0)))
                            {
                                // Leave this as a variable
                            }
                            else
                            {
                                // Convert to a constructor
                                pat.MakeAConstructor();
                                pat.Ctor = ctor;
                                pat.Var = default(VT);
                            }
                        }
                        else
                        {
                            pat.Ctor = ctor;
                            pat.Var = default(VT);
                        }
                    }
                }
            }

            if (pat.Var != null)
            {
                // this is a simple resolution
                var v = pat.Var;
                if (resolutionContext.IsGhost)
                {
                    v.MakeGhost();
                }
                ResolveType(v.Tok, v.Type, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                // Note, the following type constraint checks that the RHS type can be assigned to the new variable on the left. In particular, it
                // does not check that the entire RHS can be assigned to something of the type of the pattern on the left.  For example, consider
                // a type declared as "datatype Atom<T> = MakeAtom(T)", where T is a non-variant type argument.  Suppose the RHS has type Atom<nat>
                // and that the LHS is the pattern MakeAtom(x: int).  This is okay, despite the fact that Atom<nat> is not assignable to Atom<int>.
                // The reason is that the purpose of the pattern on the left is really just to provide a skeleton to introduce bound variables in.
                EagerAddAssignableConstraint(v.Tok, v.Type, sourceType, MutateCSharp.Schemata405.ReplaceStringConstant_6(1733L, "type of corresponding source/RHS ({1}) does not match type of bound variable ({0})"));
                pat.AssembleExpr(null);
                return;
            }
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_73(1734L, dtd, null))
            {
                // look up the name of the pattern's constructor
                Tuple<DatatypeCtor, bool> pair;
                if (moduleInfo.Ctors.TryGetValue(pat.Id, out pair) && !pair.Item2)
                {
                    ctor = pair.Item1;
                    pat.Ctor = ctor;
                    dtd = ctor.EnclosingDatatype;
                    var typeArgs = new List<Type>();
                    foreach (var xt in dtd.TypeArgs)
                    {
                        typeArgs.Add(new InferredTypeProxy());
                    }
                    udt = new UserDefinedType(pat.tok, dtd.Name, dtd, typeArgs);
                    ConstrainSubtypeRelation(udt, sourceType, pat.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(1735L, "type of RHS ({0}) does not match type of bound variable '{1}'"), sourceType, pat.Id);
                }
            }
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(1738L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_73(1736L, dtd, null), () => MutateCSharp.Schemata405.ReplaceBinExprOp_66(1737L, ctor, null)))
            {
                reporter.Error(MessageSource.Resolver, pat.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(1744L, "to use a pattern, the type of the source/RHS expression must be a datatype (instead found {0})"), sourceType);
            }
            else if (MutateCSharp.Schemata405.ReplaceBinExprOp_66(1745L, ctor, null))
            {
                reporter.Error(MessageSource.Resolver, pat.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(1746L, "constructor {0} does not exist in datatype {1}"), pat.Id, dtd.Name);
            }
            else
            {
                if (pat.Arguments == null)
                {
                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_7(1751L, ctor.Formals.Count, MutateCSharp.Schemata405.ReplaceNumericConstant_1(1747L, 0)))
                    {
                        // The Id matches a constructor of the correct type and 0 arguments,
                        // so make it a nullary constructor, not a variable
                        pat.MakeAConstructor();
                    }
                }
                else
                {
                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_20(1756L, ctor.Formals.Count, pat.Arguments.Count))
                    {
                        reporter.Error(MessageSource.Resolver, pat.tok, MutateCSharp.Schemata405.ReplaceStringConstant_6(1761L, "pattern for constructor {0} has wrong number of formals (found {1}, expected {2})"), pat.Id, pat.Arguments.Count, ctor.Formals.Count);
                    }
                }
                // build the type-parameter substitution map for this use of the datatype
                Contract.Assert(dtd.TypeArgs.Count == udt.TypeArgs.Count);  // follows from the type previously having been successfully resolved
                var subst = TypeParameter.SubstitutionMap(dtd.TypeArgs, udt.TypeArgs);
                // recursively call ResolveCasePattern on each of the arguments
                var prevErrorCount = reporter.Count(ErrorLevel.Error);
                var j = MutateCSharp.Schemata405.ReplaceNumericConstant_1(1762L, 0);
                if (pat.Arguments != null)
                {
                    foreach (var arg in pat.Arguments)
                    {
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_37(1766L, j, ctor.Formals.Count))
                        {
                            var formal = ctor.Formals[j];
                            Type st = formal.Type.Subst(subst);
                            ResolveCasePattern(arg, st, resolutionContext.WithGhost(MutateCSharp.Schemata405.ReplaceBinExprOp_14(1771L, () => resolutionContext.IsGhost, () => formal.IsGhost)));
                        }

                        MutateCSharp.Schemata405.ReplacePostfixUnaryExprOp_38(1777L, ref j);
                    }
                }
                if (MutateCSharp.Schemata405.ReplaceBinExprOp_4(1788L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_7(1778L, reporter.Count(ErrorLevel.Error), prevErrorCount), () => MutateCSharp.Schemata405.ReplaceBinExprOp_7(1783L, j, ctor.Formals.Count)))
                {
                    pat.AssembleExpr(udt.TypeArgs);
                }
            }
        }

        internal readonly List<DefaultValueExpression> allDefaultValueExpressions = new();

        /// <summary>
        /// This method is called at the tail end of Pass1 of the Resolver.
        /// </summary>
        void FillInDefaultValueExpressions()
        {
            var visited = new Dictionary<DefaultValueExpression, DefaultValueExpression.WorkProgress>();
            foreach (var e in allDefaultValueExpressions)
            {
                e.FillIn(this, visited);
            }
            allDefaultValueExpressions.Clear();
        }

        public Dictionary<TypeParameter, Type> BuildTypeArgumentSubstitute(Dictionary<TypeParameter, Type> typeArgumentSubstitutions,
          Type/*?*/ receiverTypeBound = null)
        {
            Contract.Requires(typeArgumentSubstitutions != null);

            var subst = new Dictionary<TypeParameter, Type>();
            foreach (var entry in typeArgumentSubstitutions)
            {
                subst.Add(entry.Key, entry.Value);
            }

            if (MutateCSharp.Schemata405.ReplaceBinExprOp_74(1794L, SelfTypeSubstitution, null))
            {
                foreach (var entry in SelfTypeSubstitution)
                {
                    subst.Add(entry.Key, entry.Value);
                }
            }

            if (MutateCSharp.Schemata405.ReplaceBinExprOp_75(1795L, receiverTypeBound, null))
            {
                subst = AddParentTypeParameterSubstitutions(subst, receiverTypeBound);
            }

            return subst;
        }

        public static Dictionary<TypeParameter, Type> AddParentTypeParameterSubstitutions(Dictionary<TypeParameter, Type> subst, Type receiverType = null)
        {
            TopLevelDeclWithMembers cl;
            var udt = receiverType?.AsNonNullRefType;
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_76(1796L, udt, null))
            {
                cl = (TopLevelDeclWithMembers)((NonNullTypeDecl)udt.ResolvedClass).ViewAsClass;
            }
            else
            {
                udt = receiverType.NormalizeExpand() as UserDefinedType;
                cl = udt?.ResolvedClass as TopLevelDeclWithMembers;
            }
            if (MutateCSharp.Schemata405.ReplaceBinExprOp_61(1797L, cl, null))
            {
                cl.AddParentTypeParameterSubstitutions(subst);
            }

            return subst;
        }

        public static string GhostPrefix(bool isGhost)
        {
            return isGhost ? MutateCSharp.Schemata405.ReplaceStringConstant_6(1798L, "ghost ") : "";
        }

        internal static ModuleSignature GetSignatureExt(ModuleSignature sig)
        {
            Contract.Requires(sig != null);
            Contract.Ensures(Contract.Result<ModuleSignature>() != null);
            return sig;
        }

        public ModuleSignature GetSignature(ModuleSignature sig)
        {
            return GetSignatureExt(sig);
        }

        public static Expression GetImpliedTypeConstraint(IVariable bv, Type type)
        {
            return GetImpliedTypeConstraint(Expression.CreateIdentExpr(bv), type);
        }

        /// <summary>
        /// Collects the constraints of all subset types and newtypes in "type" and applies these to "e".
        /// For example, given
        ///     type Even = x: int | x % 2 == 0
        ///     newtype Div6 = y: Even | y % 3 == 0
        /// GetImpliedTypeConstraint(e, Div6) returns
        ///     true && ((e as Even) % 2 == 0) && e % 3 == 0
        /// </summary>
        public static Expression GetImpliedTypeConstraint(Expression e, Type type)
        {
            Contract.Requires(e != null);
            Contract.Requires(type != null);
            type = type.NormalizeExpandKeepConstraints();
            if (type is UserDefinedType udt)
            {
                Expression CombineConstraints(Type baseType, BoundVar boundVar, Expression constraint)
                {
                    var c = GetImpliedTypeConstraint(e, baseType);
                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_35(1799L, boundVar, null))
                    {
                        var ee = new ConversionExpr(e.tok, e, boundVar.Type) { Type = boundVar.Type };
                        var substMap = new Dictionary<IVariable, Expression> { { boundVar, ee } };
                        var typeMap = TypeParameter.SubstitutionMap(udt.ResolvedClass.TypeArgs, udt.TypeArgs);
                        var substituter = new Substituter(null, substMap, typeMap);
                        c = Expression.CreateAnd(c, substituter.Substitute(constraint));
                    }
                    return c;
                }

                if (udt.ResolvedClass is NewtypeDecl newtypeDecl)
                {
                    return CombineConstraints(newtypeDecl.BaseType, newtypeDecl.Var, newtypeDecl.Constraint);
                }
                if (udt.ResolvedClass is SubsetTypeDecl subsetTypeDecl)
                {
                    return CombineConstraints(subsetTypeDecl.RhsWithArgument(udt.TypeArgs), subsetTypeDecl.Var, subsetTypeDecl.Constraint);
                }
            }
            return Expression.CreateBoolLiteral(e.tok, MutateCSharp.Schemata405.ReplaceBooleanConstant_3(1800L, true));
        }

        /// <summary>
        /// Returns the set of free variables in "expr".
        /// Requires "expr" to be successfully resolved.
        /// Ensures that the set returned has no aliases.
        /// </summary>
        public static ISet<IVariable> FreeVariables(Expression expr)
        {
            Contract.Requires(expr != null);
            Contract.Ensures(expr.Type != null);

            if (expr is IdentifierExpr)
            {
                var e = (IdentifierExpr)expr;
                return new HashSet<IVariable>() { e.Var };

            }
            else if (expr is QuantifierExpr)
            {
                var e = (QuantifierExpr)expr;
                Contract.Assert(e.SplitQuantifier == null); // No split quantifiers during resolution

                var s = FreeVariables(e.LogicalBody());
                foreach (var bv in e.BoundVars)
                {
                    s.Remove(bv);
                }
                return s;
            }
            else if (expr is NestedMatchExpr)
            {
                var e = (NestedMatchExpr)expr;
                var s = FreeVariables(e.Source);
                foreach (NestedMatchCaseExpr mc in e.Cases)
                {
                    var t = FreeVariables(mc.Body);
                    foreach (var bv in mc.Pat.Children.OfType<IdPattern>())
                    {
                        if (MutateCSharp.Schemata405.ReplaceBinExprOp_77(1801L, bv.BoundVar, null))
                        {
                            t.Remove(bv.BoundVar);
                        }
                    }
                    s.UnionWith(t);
                }
                return s;
            }
            else if (expr is MatchExpr)
            {
                var e = (MatchExpr)expr;
                var s = FreeVariables(e.Source);
                foreach (MatchCaseExpr mc in e.Cases)
                {
                    var t = FreeVariables(mc.Body);
                    foreach (var bv in mc.Arguments)
                    {
                        t.Remove(bv);
                    }
                    s.UnionWith(t);
                }
                return s;

            }
            else if (expr is LambdaExpr)
            {
                var e = (LambdaExpr)expr;
                var s = FreeVariables(e.Term);
                if (MutateCSharp.Schemata405.ReplaceBinExprOp_33(1802L, e.Range, null))
                {
                    s.UnionWith(FreeVariables(e.Range));
                }
                foreach (var fe in e.Reads.Expressions)
                {
                    s.UnionWith(FreeVariables(fe.E));
                }
                foreach (var bv in e.BoundVars)
                {
                    s.Remove(bv);
                }
                return s;

            }
            else
            {
                ISet<IVariable> s = null;
                foreach (var e in expr.SubExpressions)
                {
                    var t = FreeVariables(e);
                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_78(1803L, s, null))
                    {
                        s = t;
                    }
                    else
                    {
                        s.UnionWith(t);
                    }
                }
                return MutateCSharp.Schemata405.ReplaceBinExprOp_78(1804L, s, null) ? new HashSet<IVariable>() : s;
            }

            return default;
        }

        public class SeqSelectOneErrorMsg : TypeConstraint.ErrorMsgWithToken
        {
            private static readonly string BASE_MESSAGE_FORMAT = MutateCSharp.Schemata405.ReplaceStringConstant_6(1805L, "sequence has type {0} which is incompatible with expected type {1}");
            private static readonly string ELEMENT_DETAIL_MESSAGE_FORMAT = MutateCSharp.Schemata405.ReplaceStringConstant_6(1806L, " (element type {0} is incompatible with {1})");

            private readonly Type exprSeqType;
            private readonly Type expectedSeqType;

            public override string Msg
            {
                get
                {
                    // Resolution might resolve exprSeqType/expectedSeqType to not be sequences at all.
                    // In that case, it isn't possible to get the corresponding element types.
                    var rawExprElementType = exprSeqType.AsSeqType?.Arg;
                    var rawExpectedElementType = expectedSeqType.AsSeqType?.Arg;
                    if (MutateCSharp.Schemata405.ReplaceBinExprOp_14(1809L, () => MutateCSharp.Schemata405.ReplaceBinExprOp_79(1807L, rawExprElementType, null), () => MutateCSharp.Schemata405.ReplaceBinExprOp_79(1808L, rawExpectedElementType, null)))
                    {
                        return base.Msg;
                    }

                    var elementTypes = RemoveAmbiguity(new object[] { rawExprElementType, rawExpectedElementType });
                    Contract.Assert(elementTypes.Length == 2);
                    var exprElementType = elementTypes[MutateCSharp.Schemata405.ReplaceNumericConstant_1(1815L, 0)].ToString();
                    var expectedElementType = elementTypes[MutateCSharp.Schemata405.ReplaceNumericConstant_1(1819L, 1)].ToString();

                    string detail = string.Format(ELEMENT_DETAIL_MESSAGE_FORMAT, exprElementType, expectedElementType);
                    return base.Msg + detail;
                }
            }

            public SeqSelectOneErrorMsg(IToken tok, Type exprSeqType, Type expectedSeqType)
              : base(tok, BASE_MESSAGE_FORMAT, exprSeqType, expectedSeqType)
            {
                Contract.Requires(exprSeqType != null);
                Contract.Requires(expectedSeqType != null);
                this.exprSeqType = exprSeqType;
                this.expectedSeqType = expectedSeqType;
            }
        }

        /// <summary>
        /// Note: this method is allowed to be called even if "type" does not make sense for "op", as might be the case if
        /// resolution of the binary expression failed.  If so, an arbitrary resolved opcode is returned.
        /// Usually, the type of the right-hand operand is used to determine the resolved operator (hence, the shorter
        /// name "operandType" instead of, say, "rightOperandType").
        /// </summary>
        public static BinaryExpr.ResolvedOpcode ResolveOp(BinaryExpr.Opcode op, Type leftOperandType, Type operandType)
        {
            Contract.Requires(leftOperandType != null);
            Contract.Requires(operandType != null);
            leftOperandType = leftOperandType.NormalizeToAncestorType();
            operandType = operandType.NormalizeToAncestorType();
            switch (op)
            {
                case BinaryExpr.Opcode.Iff:
                    return BinaryExpr.ResolvedOpcode.Iff;
                    break;
                case BinaryExpr.Opcode.Imp:
                    return BinaryExpr.ResolvedOpcode.Imp;
                    break;
                case BinaryExpr.Opcode.Exp:
                    return BinaryExpr.ResolvedOpcode.Imp;
                    break;
                case BinaryExpr.Opcode.And:
                    return BinaryExpr.ResolvedOpcode.And;
                    break;
                case BinaryExpr.Opcode.Or:
                    return BinaryExpr.ResolvedOpcode.Or;
                    break;
                case BinaryExpr.Opcode.Eq:
                    if (operandType is SetType)
                    {
                        return BinaryExpr.ResolvedOpcode.SetEq;
                    }
                    else if (operandType is MultiSetType)
                    {
                        return BinaryExpr.ResolvedOpcode.MultiSetEq;
                    }
                    else if (operandType is SeqType)
                    {
                        return BinaryExpr.ResolvedOpcode.SeqEq;
                    }
                    else if (operandType is MapType)
                    {
                        return BinaryExpr.ResolvedOpcode.MapEq;
                    }
                    else
                    {
                        return BinaryExpr.ResolvedOpcode.EqCommon;
                    }

                    break;
                case BinaryExpr.Opcode.Neq:
                    if (operandType is SetType)
                    {
                        return BinaryExpr.ResolvedOpcode.SetNeq;
                    }
                    else if (operandType is MultiSetType)
                    {
                        return BinaryExpr.ResolvedOpcode.MultiSetNeq;
                    }
                    else if (operandType is SeqType)
                    {
                        return BinaryExpr.ResolvedOpcode.SeqNeq;
                    }
                    else if (operandType is MapType)
                    {
                        return BinaryExpr.ResolvedOpcode.MapNeq;
                    }
                    else
                    {
                        return BinaryExpr.ResolvedOpcode.NeqCommon;
                    }

                    break;
                case BinaryExpr.Opcode.Disjoint:
                    if (operandType is MultiSetType)
                    {
                        return BinaryExpr.ResolvedOpcode.MultiSetDisjoint;
                    }
                    else
                    {
                        return BinaryExpr.ResolvedOpcode.Disjoint;
                    }

                    break;
                case BinaryExpr.Opcode.Lt:
                    if (operandType.IsIndDatatype)
                    {
                        return BinaryExpr.ResolvedOpcode.RankLt;
                    }
                    else if (operandType is SetType)
                    {
                        return BinaryExpr.ResolvedOpcode.ProperSubset;
                    }
                    else if (operandType is MultiSetType)
                    {
                        return BinaryExpr.ResolvedOpcode.ProperMultiSubset;
                    }
                    else if (operandType is SeqType)
                    {
                        return BinaryExpr.ResolvedOpcode.ProperPrefix;
                    }
                    else if (operandType is CharType)
                    {
                        return BinaryExpr.ResolvedOpcode.LtChar;
                    }
                    else
                    {
                        return BinaryExpr.ResolvedOpcode.Lt;
                    }

                    break;
                case BinaryExpr.Opcode.Le:
                    if (operandType is SetType)
                    {
                        return BinaryExpr.ResolvedOpcode.Subset;
                    }
                    else if (operandType is MultiSetType)
                    {
                        return BinaryExpr.ResolvedOpcode.MultiSubset;
                    }
                    else if (operandType is SeqType)
                    {
                        return BinaryExpr.ResolvedOpcode.Prefix;
                    }
                    else if (operandType is CharType)
                    {
                        return BinaryExpr.ResolvedOpcode.LeChar;
                    }
                    else
                    {
                        return BinaryExpr.ResolvedOpcode.Le;
                    }

                    break;
                case BinaryExpr.Opcode.LeftShift:
                    return BinaryExpr.ResolvedOpcode.LeftShift;
                    break;
                case BinaryExpr.Opcode.RightShift:
                    return BinaryExpr.ResolvedOpcode.RightShift;
                    break;
                case BinaryExpr.Opcode.Add:
                    if (operandType is SetType)
                    {
                        return BinaryExpr.ResolvedOpcode.Union;
                    }
                    else if (operandType is MultiSetType)
                    {
                        return BinaryExpr.ResolvedOpcode.MultiSetUnion;
                    }
                    else if (operandType is MapType)
                    {
                        return BinaryExpr.ResolvedOpcode.MapMerge;
                    }
                    else if (operandType is SeqType)
                    {
                        return BinaryExpr.ResolvedOpcode.Concat;
                    }
                    else
                    {
                        return BinaryExpr.ResolvedOpcode.Add;
                    }

                    break;
                case BinaryExpr.Opcode.Sub:
                    if (leftOperandType is MapType)
                    {
                        return BinaryExpr.ResolvedOpcode.MapSubtraction;
                    }
                    else if (operandType is SetType)
                    {
                        return BinaryExpr.ResolvedOpcode.SetDifference;
                    }
                    else if (operandType is MultiSetType)
                    {
                        return BinaryExpr.ResolvedOpcode.MultiSetDifference;
                    }
                    else
                    {
                        return BinaryExpr.ResolvedOpcode.Sub;
                    }

                    break;
                case BinaryExpr.Opcode.Mul:
                    if (operandType is SetType)
                    {
                        return BinaryExpr.ResolvedOpcode.Intersection;
                    }
                    else if (operandType is MultiSetType)
                    {
                        return BinaryExpr.ResolvedOpcode.MultiSetIntersection;
                    }
                    else
                    {
                        return BinaryExpr.ResolvedOpcode.Mul;
                    }

                    break;
                case BinaryExpr.Opcode.Gt:
                    if (operandType.IsDatatype)
                    {
                        return BinaryExpr.ResolvedOpcode.RankGt;
                    }
                    else if (operandType is SetType)
                    {
                        return BinaryExpr.ResolvedOpcode.ProperSuperset;
                    }
                    else if (operandType is MultiSetType)
                    {
                        return BinaryExpr.ResolvedOpcode.ProperMultiSuperset;
                    }
                    else if (operandType is CharType)
                    {
                        return BinaryExpr.ResolvedOpcode.GtChar;
                    }
                    else
                    {
                        return BinaryExpr.ResolvedOpcode.Gt;
                    }

                    break;
                case BinaryExpr.Opcode.Ge:
                    if (operandType is SetType)
                    {
                        return BinaryExpr.ResolvedOpcode.Superset;
                    }
                    else if (operandType is MultiSetType)
                    {
                        return BinaryExpr.ResolvedOpcode.MultiSuperset;
                    }
                    else if (operandType is CharType)
                    {
                        return BinaryExpr.ResolvedOpcode.GeChar;
                    }
                    else
                    {
                        return BinaryExpr.ResolvedOpcode.Ge;
                    }

                    break;
                case BinaryExpr.Opcode.In:
                    if (operandType is SetType)
                    {
                        return BinaryExpr.ResolvedOpcode.InSet;
                    }
                    else if (operandType is MultiSetType)
                    {
                        return BinaryExpr.ResolvedOpcode.InMultiSet;
                    }
                    else if (operandType is MapType)
                    {
                        return BinaryExpr.ResolvedOpcode.InMap;
                    }
                    else
                    {
                        return BinaryExpr.ResolvedOpcode.InSeq;
                    }

                    break;
                case BinaryExpr.Opcode.NotIn:
                    if (operandType is SetType)
                    {
                        return BinaryExpr.ResolvedOpcode.NotInSet;
                    }
                    else if (operandType is MultiSetType)
                    {
                        return BinaryExpr.ResolvedOpcode.NotInMultiSet;
                    }
                    else if (operandType is MapType)
                    {
                        return BinaryExpr.ResolvedOpcode.NotInMap;
                    }
                    else
                    {
                        return BinaryExpr.ResolvedOpcode.NotInSeq;
                    }

                    break;
                case BinaryExpr.Opcode.Div:
                    return BinaryExpr.ResolvedOpcode.Div;
                    break;
                case BinaryExpr.Opcode.Mod:
                    return BinaryExpr.ResolvedOpcode.Mod;
                    break;
                case BinaryExpr.Opcode.BitwiseAnd:
                    return BinaryExpr.ResolvedOpcode.BitwiseAnd;
                    break;
                case BinaryExpr.Opcode.BitwiseOr:
                    return BinaryExpr.ResolvedOpcode.BitwiseOr;
                    break;
                case BinaryExpr.Opcode.BitwiseXor:
                    return BinaryExpr.ResolvedOpcode.BitwiseXor;
                    break;
                default:
                    Contract.Assert(false); throw new cce.UnreachableException();  // unexpected operator
                    break;
            }

            return default;
        }

        /// <summary>
        /// This method adds to "friendlyCalls" all
        ///     inductive calls                                     if !co
        ///     greatest predicate calls and codatatype equalities  if co
        /// that occur in positive positions and not under
        ///     universal quantification                            if !co
        ///     existential quantification.                         if co
        /// If "expr" is the
        ///     precondition of a least lemma                       if !co
        ///     postcondition of a greatest lemma,                  if co
        /// then the "friendlyCalls" are the subexpressions that need to be replaced in order
        /// to create the
        ///     precondition                                        if !co
        ///     postcondition                                       if co
        /// of the corresponding prefix lemma.
        /// </summary>
        void CollectFriendlyCallsInExtremeLemmaSpecification(Expression expr, bool position, ISet<Expression> friendlyCalls, bool co, ExtremeLemma context)
        {
            Contract.Requires(expr != null);
            Contract.Requires(friendlyCalls != null);
            var visitor = new CollectFriendlyCallsInSpec_Visitor(reporter, friendlyCalls, co, context);
            visitor.Visit(expr, position ? CallingPosition.Positive : CallingPosition.Negative);
        }
    }

    public
      abstract class ResolverTopDownVisitor<T> : TopDownVisitor<T>
    {
        protected ErrorReporter reporter;
        public ResolverTopDownVisitor(ErrorReporter reporter)
        {
            Contract.Requires(reporter != null);
            this.reporter = reporter;
        }
    }
}
