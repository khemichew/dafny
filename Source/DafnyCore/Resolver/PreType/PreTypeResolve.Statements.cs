//-----------------------------------------------------------------------------
//
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.Contracts;
using JetBrains.Annotations;
namespace MutateCSharp
{
    internal class Schemata424
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT424");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_10(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_49(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_40(long mutantId, Microsoft.Dafny.Method argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_55(long mutantId, Microsoft.Dafny.ModuleResolver.ResolveTypeReturn argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_57(long mutantId, Microsoft.Dafny.PreType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_59(long mutantId, Microsoft.Dafny.ConstantField argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_16(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_29(long mutantId, Microsoft.Dafny.CalcStmt.CalcOp argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_3(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_37(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_46(long mutantId, Microsoft.Dafny.Method argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_22(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, Microsoft.Dafny.IMethodCodeContext argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_48(long mutantId, Microsoft.Dafny.ThisExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_33(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.LocalVariable> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_54(long mutantId, Microsoft.Dafny.NonNullTypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_47(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.MethodCallInformation argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_28(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_25(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceNumericConstant_12(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_60(long mutantId, Microsoft.Dafny.AlternativeLoopStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_24(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
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

        internal static bool ReplaceBinExprOp_45(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_27(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_30(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.Label argument1, object argument2)
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

        internal static bool ReplaceBinExprOp_36(long mutantId, Microsoft.Dafny.MethodCallInformation argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_43(long mutantId, Microsoft.Dafny.TopLevelDeclWithMembers argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_32(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.AssignmentRhs> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.AssignmentRhs> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_23(long mutantId, Microsoft.Dafny.IVariable argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, Microsoft.Dafny.LList<Microsoft.Dafny.Label> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_31(long mutantId, Microsoft.Dafny.CalcStmt.CalcOp argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_42(long mutantId, Microsoft.Dafny.PreType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_52(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_44(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_53(long mutantId, Microsoft.Dafny.ActualBindings argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.Statement argument1, Microsoft.Dafny.Statement argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_39(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_56(long mutantId, Microsoft.Dafny.NonNullTypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.LList<Microsoft.Dafny.Label> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_41(long mutantId, Microsoft.Dafny.AttributedToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.Label argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_58(long mutantId, Microsoft.Dafny.Field argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.MemberSelectExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_34(long mutantId, Microsoft.Dafny.ConcreteUpdateStatement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_26(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, Microsoft.Dafny.ModuleDefinition argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_35(long mutantId, Microsoft.Dafny.CallStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_38(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.FrameExpression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.AssertLabel argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePrefixUnaryExprOp_50(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return ++argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return +argument1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return ~argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return --argument1; }
            return ++argument1;
        }

        internal static bool ReplaceBinExprOp_51(long mutantId, Microsoft.Dafny.AttributedToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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
    public partial class PreTypeResolver : INewOrOldResolver
    {
        private Scope<Statement> enclosingStatementLabels;
        private readonly Scope<Label> dominatingStatementLabels;
        public Scope<Label> DominatingStatementLabels => dominatingStatementLabels;

        public Scope<Statement> EnclosingStatementLabels { get => enclosingStatementLabels;
      set => enclosingStatementLabels = value; }
        public List<Statement> LoopStack { get => loopStack;
      set => loopStack = value; }

        private List<Statement> loopStack = new();  // the enclosing loops (from which it is possible to break out)
        bool inBodyInitContext;  // "true" only if "currentMethod is Constructor"

        void ResolveBlockStatement(BlockStmt blockStmt, ResolutionContext resolutionContext)
        {
            Contract.Requires(blockStmt != null);
            Contract.Requires(resolutionContext != null);

            if (blockStmt is DividedBlockStmt div)
            {
                Contract.Assert(currentMethod is Constructor);  // divided bodies occur only in class constructors
                Contract.Assert(!inBodyInitContext);  // divided bodies are never nested
                inBodyInitContext = MutateCSharp.Schemata424.ReplaceBooleanConstant_0(1L, true);
                foreach (Statement ss in div.BodyInit)
                {
                    ResolveStatementWithLabels(ss, resolutionContext);
                }
                Contract.Assert(inBodyInitContext);
                inBodyInitContext = MutateCSharp.Schemata424.ReplaceBooleanConstant_0(2L, false);
                foreach (Statement ss in div.BodyProper)
                {
                    ResolveStatementWithLabels(ss, resolutionContext);
                }
            }
            else
            {
                foreach (Statement ss in blockStmt.Body)
                {
                    ResolveStatementWithLabels(ss, resolutionContext);
                }
            }
        }

        void ResolveStatementWithLabels(Statement stmt, ResolutionContext resolutionContext)
        {
            Contract.Requires(stmt != null);
            Contract.Requires(resolutionContext != null);

            EnclosingStatementLabels.PushMarker();
            // push labels
            for (var l = stmt.Labels; MutateCSharp.Schemata424.ReplaceBinExprOp_1(3L, l, null); l = l.Next)
            {
                var lnode = l.Data;
                Contract.Assert(lnode.Name != null);  // LabelNode's with .Label==null are added only during resolution of the break statements with 'stmt' as their target, which hasn't happened yet
                var prev = EnclosingStatementLabels.Find(lnode.Name);
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_2(4L, prev, stmt))
                {
                    ReportError(lnode.Tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(5L, "duplicate label"));
                }
                else if (MutateCSharp.Schemata424.ReplaceBinExprOp_4(6L, prev, null))
                {
                    ReportError(lnode.Tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(7L, "label shadows an enclosing label"));
                }
                else
                {
                    var r = EnclosingStatementLabels.Push(lnode.Name, stmt);
                    Contract.Assert(r == Scope<Statement>.PushResult.Success);  // since we just checked for duplicates, we expect the Push to succeed
                    if (MutateCSharp.Schemata424.ReplaceBinExprOp_5(8L, dominatingStatementLabels.Find(lnode.Name), null))
                    {
                        ReportError(lnode.Tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(9L, "label shadows a dominating label"));
                    }
                    else
                    {
                        var rr = dominatingStatementLabels.Push(lnode.Name, lnode);
                        Contract.Assert(rr == Scope<Label>.PushResult.Success);  // since we just checked for duplicates, we expect the Push to succeed
                    }
                }
            }
            ResolveStatement(stmt, resolutionContext);
            EnclosingStatementLabels.PopMarker();
        }

        Label/*?*/ ResolveDominatingLabelInExpr(IToken tok, string/*?*/ labelName, string expressionDescription, ResolutionContext resolutionContext)
        {
            Contract.Requires(tok != null);
            Contract.Requires(expressionDescription != null);
            Contract.Requires(resolutionContext != null);

            Label label = null;
            if (!resolutionContext.IsTwoState)
            {
                ReportError(tok, $"{expressionDescription} expressions are not allowed in this context");
            }
            else if (labelName != null)
            {
                label = dominatingStatementLabels.Find(labelName);
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_6(10L, label, null))
                {
                    ReportError(tok, $"no label '{labelName}' in scope at this time");
                }
            }
            return label;
        }

        public void ResolveStatement(Statement stmt, ResolutionContext resolutionContext)
        {
            Contract.Requires(stmt != null);
            Contract.Requires(resolutionContext != null);

            if (stmt is ICanResolveNewAndOld canResolve)
            {
                canResolve.GenResolve(this, resolutionContext);
                return;
            }

            if (!(MutateCSharp.Schemata424.ReplaceBinExprOp_7(11L, () => stmt is ForallStmt, () => stmt is ForLoopStmt)))
            {  // "forall" and "for" statements do their own attribute resolution below
                ResolveAttributes(stmt, resolutionContext, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(17L, false));
            }
            if (stmt is PrintStmt)
            {
                var s = (PrintStmt)stmt;
                foreach (var e in s.Args)
                {
                    ResolveExpression(e, resolutionContext);
                }

            }
            else if (stmt is RevealStmt)
            {
                var s = (RevealStmt)stmt;
                foreach (var expr in s.Exprs)
                {
                    var name = RevealStmt.SingleName(expr);
                    var labeledAssert = name == null ? null : dominatingStatementLabels.Find(name) as AssertLabel;
                    if (MutateCSharp.Schemata424.ReplaceBinExprOp_8(18L, labeledAssert, null))
                    {
                        s.LabeledAsserts.Add(labeledAssert);
                    }
                    else
                    {
                        var revealResolutionContext = resolutionContext with { InReveal = MutateCSharp.Schemata424.ReplaceBooleanConstant_0(19L, true) };
                        if (expr is ApplySuffix applySuffix)
                        {
                            var methodCallInfo = ResolveApplySuffix(applySuffix, revealResolutionContext, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(20L, true));
                            if (MutateCSharp.Schemata424.ReplaceBinExprOp_9(21L, methodCallInfo, null))
                            {
                                // error has already been reported
                            }
                            else if (MutateCSharp.Schemata424.ReplaceBinExprOp_10(22L, () => methodCallInfo.Callee.Member is TwoStateLemma, () => !revealResolutionContext.IsTwoState))
                            {
                                ReportError(methodCallInfo.Tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(28L, "a two-state function can only be revealed in a two-state context"));
                            }
                            else if (MutateCSharp.Schemata424.ReplaceBinExprOp_5(29L, methodCallInfo.Callee.AtLabel, null))
                            {
                                Contract.Assert(methodCallInfo.Callee.Member is TwoStateLemma);
                                ReportError(methodCallInfo.Tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(30L, "to reveal a two-state function, do not list any parameters or @-labels"));
                            }
                            else
                            {
                                var call = new CallStmt(s.RangeToken, new List<Expression>(), methodCallInfo.Callee, methodCallInfo.ActualParameters);
                                s.ResolvedStatements.Add(call);
                            }
                        }
                        else if (expr is NameSegment or ExprDotName)
                        {
                            if (expr is NameSegment)
                            {
                                ResolveNameSegment((NameSegment)expr, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(31L, true), null, revealResolutionContext, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(32L, true));
                            }
                            else
                            {
                                ResolveDotSuffix((ExprDotName)expr, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(33L, true), null, revealResolutionContext, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(34L, true));
                            }
                            var callee = (MemberSelectExpr)((ConcreteSyntaxExpression)expr).ResolvedExpression;
                            if (MutateCSharp.Schemata424.ReplaceBinExprOp_11(35L, callee, null))
                            {
                            }
                            else if (MutateCSharp.Schemata424.ReplaceBinExprOp_10(37L, () => callee.Member is Lemma or TwoStateLemma, () => Attributes.Contains(callee.Member.Attributes, MutateCSharp.Schemata424.ReplaceStringConstant_3(36L, "axiom"))))
                            {
                                //The revealed member is a function
                                ReportError(callee.tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(43L, "to reveal a function ({0}), append parentheses"), callee.Member.ToString().Substring(MutateCSharp.Schemata424.ReplaceNumericConstant_12(44L, 7)));
                            }
                            else
                            {
                                var call = new CallStmt(s.RangeToken, new List<Expression>(), callee, new List<ActualBinding>(), expr.tok);
                                s.ResolvedStatements.Add(call);
                            }
                        }
                        else
                        {
                            ResolveExpression(expr, revealResolutionContext);
                        }
                    }
                }
                foreach (var a in s.ResolvedStatements)
                {
                    ResolveStatement(a, resolutionContext);
                }

            }
            else if (stmt is BreakStmt)
            {
                var s = (BreakStmt)stmt;
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_13(48L, s.TargetLabel, null))
                {
                    Statement target = EnclosingStatementLabels.Find(s.TargetLabel.val);
                    if (MutateCSharp.Schemata424.ReplaceBinExprOp_14(49L, target, null))
                    {
                        ReportError(s.TargetLabel, $"{s.Kind} label is undefined or not in scope: {s.TargetLabel.val}");
                    }
                    else if (MutateCSharp.Schemata424.ReplaceBinExprOp_10(50L, () => s.IsContinue, () => !(target is LoopStmt)))
                    {
                        ReportError(s.TargetLabel, $"continue label must designate a loop: {s.TargetLabel.val}");
                    }
                    else
                    {
                        s.TargetStmt = target;
                    }
                }
                else
                {
                    Contract.Assert(1 <= s.BreakAndContinueCount); // follows from BreakStmt class invariant and the guard for this "else" branch
                    var jumpStmt = MutateCSharp.Schemata424.ReplaceBinExprOp_15(60L, s.BreakAndContinueCount, MutateCSharp.Schemata424.ReplaceNumericConstant_12(56L, 1)) ?
                      $"a non-labeled '{s.Kind}' statement" :
                      $"a '{Util.Repeat(MutateCSharp.Schemata424.ReplaceBinExprOp_16(69L, s.BreakAndContinueCount, MutateCSharp.Schemata424.ReplaceNumericConstant_12(65L, 1)), MutateCSharp.Schemata424.ReplaceStringConstant_3(78L, "break "))}{s.Kind}' statement";
                    if (MutateCSharp.Schemata424.ReplaceBinExprOp_15(83L, loopStack.Count, MutateCSharp.Schemata424.ReplaceNumericConstant_12(79L, 0)))
                    {
                        ReportError(s, $"{jumpStmt} is allowed only in loops");
                    }
                    else if (MutateCSharp.Schemata424.ReplaceBinExprOp_17(88L, loopStack.Count, s.BreakAndContinueCount))
                    {
                        ReportError(s,
                          $"{jumpStmt} is allowed only in contexts with {s.BreakAndContinueCount} enclosing loops, but the current context only has {loopStack.Count}");
                    }
                    else
                    {
                        Statement target = loopStack[MutateCSharp.Schemata424.ReplaceBinExprOp_16(93L, loopStack.Count, s.BreakAndContinueCount)];
                        if (MutateCSharp.Schemata424.ReplaceBinExprOp_18(102L, target.Labels, null))
                        {
                            // make sure there is a label, because the compiler and translator will want to see a unique ID
                            target.Labels = new LList<Label>(new Label(target.Tok, null), null);
                        }
                        s.TargetStmt = target;
                    }
                }

            }
            else if (stmt is ProduceStmt)
            {
                var kind = stmt is YieldStmt ? MutateCSharp.Schemata424.ReplaceStringConstant_3(103L, "yield") : MutateCSharp.Schemata424.ReplaceStringConstant_3(104L, "return");
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_10(105L, () => stmt is YieldStmt, () => !(resolutionContext.CodeContext is IteratorDecl)))
                {
                    ReportError(stmt, MutateCSharp.Schemata424.ReplaceStringConstant_3(111L, "yield statement is allowed only in iterators"));
                }
                else if (MutateCSharp.Schemata424.ReplaceBinExprOp_10(112L, () => stmt is ReturnStmt, () => !(resolutionContext.CodeContext is Method)))
                {
                    ReportError(stmt, MutateCSharp.Schemata424.ReplaceStringConstant_3(118L, "return statement is allowed only in method"));
                }
                else if (inBodyInitContext)
                {
                    ReportError(stmt, MutateCSharp.Schemata424.ReplaceStringConstant_3(119L, "return statement is not allowed before 'new;' in a constructor"));
                }
                var s = (ProduceStmt)stmt;
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_19(120L, s.Rhss, null))
                {
                    // this is a regular return/yield statement.
                    s.HiddenUpdate = null;
                }
                else
                {
                    var cmc = resolutionContext.AsMethodCodeContext;
                    if (MutateCSharp.Schemata424.ReplaceBinExprOp_20(121L, cmc, null))
                    {
                        // an error has already been reported above
                    }
                    else if (MutateCSharp.Schemata424.ReplaceBinExprOp_21(122L, cmc.Outs.Count, s.Rhss.Count))
                    {
                        ReportError(s, MutateCSharp.Schemata424.ReplaceStringConstant_3(127L, "number of {2} parameters does not match declaration (found {0}, expected {1})"), s.Rhss.Count, cmc.Outs.Count, kind);
                    }
                    else
                    {
                        Contract.Assert(s.Rhss.Count > 0);
                        // Create a hidden update statement using the out-parameter formals, resolve the RHS, and check that the RHS is good.
                        List<Expression> formals = new List<Expression>();
                        foreach (Formal f in cmc.Outs)
                        {
                            Expression produceLhs;
                            if (stmt is ReturnStmt)
                            {
                                var ident = new IdentifierExpr(f.tok, f.Name);
                                // resolve it here to avoid capture into more closely declared local variables
                                Contract.Assert(f.Type != null);
                                ident.Var = f;
                                ident.PreType = Type2PreType(ident.Var.Type);
                                produceLhs = ident;
                            }
                            else
                            {
                                var yieldIdent = new MemberSelectExpr(f.tok, new ImplicitThisExpr(f.tok), f.Name);
                                ResolveExpression(yieldIdent, resolutionContext);
                                produceLhs = yieldIdent;
                            }
                            formals.Add(produceLhs);
                        }
                        s.HiddenUpdate = new UpdateStmt(s.RangeToken, formals, s.Rhss, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(128L, true));
                        // resolving the update statement will check for return/yield statement specifics.
                        ResolveStatement(s.HiddenUpdate, resolutionContext);
                    }
                }

            }
            else if (stmt is ConcreteUpdateStatement concreteUpdateStatement)
            {
                ResolveConcreteUpdateStmt(concreteUpdateStatement, null, resolutionContext);

            }
            else if (stmt is VarDeclStmt varDeclStmt)
            {
                ResolveConcreteUpdateStmt(varDeclStmt.Update, varDeclStmt.Locals, resolutionContext);

            }
            else if (stmt is VarDeclPattern)
            {
                var s = (VarDeclPattern)stmt;
                foreach (var local in s.LocalVars)
                {
                    int prevErrorCount = ErrorCount;
                    resolver.ResolveType(local.Tok, local.OptionalType, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                    local.type = MutateCSharp.Schemata424.ReplaceBinExprOp_15(129L, ErrorCount, prevErrorCount) ? local.type = local.OptionalType : new InferredTypeProxy();
                    local.PreType = Type2PreType(local.type);
                }
                ResolveExpression(s.RHS, resolutionContext);
                ResolveCasePattern(s.LHS, s.RHS.PreType, resolutionContext);
                // Check for duplicate names now, because not until after resolving the case pattern do we know if identifiers inside it refer to bound variables or nullary constructors
                var c = MutateCSharp.Schemata424.ReplaceNumericConstant_12(134L, 0);
                foreach (var bv in s.LHS.Vars)
                {
                    ScopePushAndReport(scope, bv.Name, bv, bv.Tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(138L, "local variable"));
                    MutateCSharp.Schemata424.ReplacePostfixUnaryExprOp_22(139L, ref c);
                }
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_15(144L, c, MutateCSharp.Schemata424.ReplaceNumericConstant_12(140L, 0)))
                {
                    // Every identifier-looking thing in the pattern resolved to a constructor; that is, this LHS is a constant literal
                    ReportError(s.LHS.tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(149L, "LHS is a constant literal; to be legal, it must introduce at least one bound variable"));
                }

            }
            else if (stmt is AssignStmt)
            {
                var s = (AssignStmt)stmt;
                int prevErrorCount = ErrorCount;
                ResolveExpression(s.Lhs, resolutionContext);  // allow ghosts for now, tightened up below
                bool lhsResolvedSuccessfully = MutateCSharp.Schemata424.ReplaceBinExprOp_15(150L, ErrorCount, prevErrorCount);
                // check that LHS denotes a mutable variable or a field
                var lhs = s.Lhs.Resolved;
                if (lhs is IdentifierExpr)
                {
                    IVariable var = ((IdentifierExpr)lhs).Var;
                    if (MutateCSharp.Schemata424.ReplaceBinExprOp_23(155L, var, null))
                    {
                        // the LHS didn't resolve correctly; some error would already have been reported
                    }
                    else
                    {
                        CheckIsLvalue(lhs, resolutionContext);
                    }
                }
                else if (lhs is MemberSelectExpr mseLhs)
                {
                    if (MutateCSharp.Schemata424.ReplaceBinExprOp_24(156L, mseLhs.Member, null))
                    {  // otherwise, an error was reported above
                        CheckIsLvalue(mseLhs, resolutionContext);
                    }
                }
                else if (lhs is SeqSelectExpr sseLhs)
                {
                    // LHS is fine, provided the "sequence" is really an array
                    if (lhsResolvedSuccessfully)
                    {
                        CheckIsLvalue(sseLhs, resolutionContext);
                    }
                }
                else
                {
                    CheckIsLvalue(lhs, resolutionContext);
                }
                var lhsPreType = s.Lhs.PreType;
                if (s.Rhs is ExprRhs)
                {
                    var rr = (ExprRhs)s.Rhs;
                    ResolveExpression(rr.Expr, resolutionContext);
                    AddSubtypeConstraint(lhsPreType, rr.Expr.PreType, stmt.Tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(157L, "RHS (of type {1}) not assignable to LHS (of type {0})"));
                }
                else if (s.Rhs is TypeRhs)
                {
                    var rr = (TypeRhs)s.Rhs;
                    ResolveTypeRhs(rr, stmt, resolutionContext);
                    AddSubtypeConstraint(lhsPreType, rr.PreType, stmt.Tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(158L, "type {1} is not assignable to LHS (of type {0})"));
                }
                else if (s.Rhs is HavocRhs)
                {
                    // nothing else to do
                }
                else
                {
                    Contract.Assert(false); throw new cce.UnreachableException();  // unexpected RHS
                }

            }
            else if (stmt is CallStmt callStmt)
            {
                ResolveCallStmt(callStmt, resolutionContext, null);

            }
            else if (stmt is BlockStmt blockStmt)
            {
                scope.PushMarker();
                ResolveBlockStatement(blockStmt, resolutionContext);
                scope.PopMarker();

            }
            else if (stmt is IfStmt)
            {
                var s = (IfStmt)stmt;
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_25(159L, s.Guard, null))
                {
                    ResolveExpression(s.Guard, resolutionContext);
                    ConstrainTypeExprBool(s.Guard, MutateCSharp.Schemata424.ReplaceStringConstant_3(160L, "condition is expected to be of type bool, but is {0}"));
                }

                scope.PushMarker();
                if (s.IsBindingGuard)
                {
                    var exists = (ExistsExpr)s.Guard;
                    foreach (var v in exists.BoundVars)
                    {
                        ScopePushAndReport(v, MutateCSharp.Schemata424.ReplaceStringConstant_3(161L, "bound-variable"), MutateCSharp.Schemata424.ReplaceBooleanConstant_0(162L, false));
                    }
                }
                dominatingStatementLabels.PushMarker();
                ResolveBlockStatement(s.Thn, resolutionContext);
                dominatingStatementLabels.PopMarker();
                scope.PopMarker();

                if (MutateCSharp.Schemata424.ReplaceBinExprOp_4(163L, s.Els, null))
                {
                    dominatingStatementLabels.PushMarker();
                    ResolveStatement(s.Els, resolutionContext);
                    dominatingStatementLabels.PopMarker();
                }

            }
            else if (stmt is AlternativeStmt)
            {
                var s = (AlternativeStmt)stmt;
                ResolveAlternatives(s.Alternatives, null, resolutionContext);

            }
            else if (stmt is OneBodyLoopStmt oneBodyLoopStmt)
            {
                ResolveOneBodyLoopStmt(oneBodyLoopStmt, resolutionContext);

            }
            else if (stmt is AlternativeLoopStmt)
            {
                var s = (AlternativeLoopStmt)stmt;
                ResolveAlternatives(s.Alternatives, s, resolutionContext);
                ResolveLoopSpecificationComponents(s.Invariants, s.Decreases, s.Mod, resolutionContext);

            }
            else if (stmt is ForallStmt)
            {
                var s = (ForallStmt)stmt;

                int prevErrorCount = ErrorCount;
                scope.PushMarker();
                foreach (BoundVar v in s.BoundVars)
                {
                    resolver.ResolveType(v.tok, v.Type, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                    ScopePushAndReport(v, MutateCSharp.Schemata424.ReplaceStringConstant_3(164L, "local-variable"));
                }
                ResolveExpression(s.Range, resolutionContext);
                ConstrainTypeExprBool(s.Range, MutateCSharp.Schemata424.ReplaceStringConstant_3(165L, "range restriction in forall statement must be of type bool (instead got {0})"));
                foreach (var ens in s.Ens)
                {
                    ResolveExpression(ens.E, resolutionContext);
                    ConstrainTypeExprBool(ens.E, MutateCSharp.Schemata424.ReplaceStringConstant_3(166L, "ensures condition is expected to be of type bool, but is {0}"));
                }
                // Since the range and postconditions are more likely to infer the types of the bound variables, resolve them
                // first (above) and only then resolve the attributes (below).
                ResolveAttributes(s, resolutionContext, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(167L, false));

                if (MutateCSharp.Schemata424.ReplaceBinExprOp_4(168L, s.Body, null))
                {
                    // clear the labels for the duration of checking the body, because break statements are not allowed to leave a forall statement
                    var prevLblStmts = EnclosingStatementLabels;
                    var prevLoopStack = loopStack;
                    EnclosingStatementLabels = new Scope<Statement>(resolver.Options);
                    loopStack = new List<Statement>();
                    ResolveStatement(s.Body, resolutionContext);
                    EnclosingStatementLabels = prevLblStmts;
                    loopStack = prevLoopStack;
                }
                scope.PopMarker();

                if (MutateCSharp.Schemata424.ReplaceBinExprOp_15(169L, prevErrorCount, ErrorCount))
                {
                    // determine the Kind and run some additional checks on the body
                    if (MutateCSharp.Schemata424.ReplaceBinExprOp_21(178L, s.Ens.Count, MutateCSharp.Schemata424.ReplaceNumericConstant_12(174L, 0)))
                    {
                        // The only supported kind with ensures clauses is Proof.
                        s.Kind = ForallStmt.BodyKind.Proof;
                    }
                    else
                    {
                        // There are three special cases:
                        // * Assign, which is the only kind of the forall statement that allows a heap update.
                        // * Call, which is a single call statement with no side effects or output parameters.
                        // * A single calc statement, which is a special case of Proof where the postcondition can be inferred.
                        // The effect of Assign and the postcondition of Call will be seen outside the forall
                        // statement.
                        Statement s0 = s.S0;
                        if (s0 is AssignStmt)
                        {
                            s.Kind = ForallStmt.BodyKind.Assign;

                            var rhs = ((AssignStmt)s0).Rhs;
                            if (rhs is TypeRhs)
                            {
                                ReportError(rhs.Tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(183L, "new allocation not supported in aggregate assignments"));
                            }

                        }
                        else if (s0 is CallStmt)
                        {
                            s.Kind = ForallStmt.BodyKind.Call;
                            var call = (CallStmt)s.S0;
                            var method = call.Method;
                            // if the called method is not in the same module as the ForallCall stmt
                            // don't convert it to ForallExpression since the inlined called method's
                            // ensure clause might not be resolved correctly(test\dafny3\GenericSort.dfy)
                            if (MutateCSharp.Schemata424.ReplaceBinExprOp_26(184L, method.EnclosingClass.EnclosingModuleDefinition, resolutionContext.CodeContext.EnclosingModule))
                            {
                                s.CanConvert = MutateCSharp.Schemata424.ReplaceBooleanConstant_0(185L, false);
                            }
                            // Additional information (namely, the postcondition of the call) will be reported later. But it cannot be
                            // done yet, because the specification of the callee may not have been resolved yet.
                        }
                        else if (s0 is CalcStmt)
                        {
                            s.Kind = ForallStmt.BodyKind.Proof;
                            // add the conclusion of the calc as a free postcondition
                            var result = ((CalcStmt)s0).Result;
                            s.Ens.Add(new AttributedExpression(result));
                            ReportInfo(s.Tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(186L, "ensures ") + Printer.ExprToString(resolver.Options, result));
                        }
                        else
                        {
                            s.Kind = ForallStmt.BodyKind.Proof;
                            if (MutateCSharp.Schemata424.ReplaceBinExprOp_10(196L, () => s.Body is BlockStmt, () => MutateCSharp.Schemata424.ReplaceBinExprOp_15(191L, ((BlockStmt)s.Body).Body.Count, MutateCSharp.Schemata424.ReplaceNumericConstant_12(187L, 0))))
                            {
                                // an empty statement, so don't produce any warning
                            }
                            else
                            {
                                ReportWarning(s.Tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(202L, "the conclusion of the body of this forall statement will not be known outside the forall statement; consider using an 'ensures' clause"));
                            }
                        }
                    }

                    if (MutateCSharp.Schemata424.ReplaceBinExprOp_27(203L, s.EffectiveEnsuresClauses, null))
                    {
                        foreach (Expression expr in s.EffectiveEnsuresClauses)
                        {
                            ResolveExpression(expr, resolutionContext);
                        }
                    }
                }

            }
            else if (stmt is ModifyStmt modifyStmt)
            {
                ResolveAttributes(modifyStmt.Mod, resolutionContext, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(204L, false));
                foreach (FrameExpression fe in modifyStmt.Mod.Expressions)
                {
                    ResolveFrameExpression(fe, FrameExpressionUse.Modifies, resolutionContext.CodeContext);
                }
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_28(205L, modifyStmt.Body, null))
                {
                    ResolveBlockStatement(modifyStmt.Body, resolutionContext);
                }

            }
            else if (stmt is CalcStmt calcStmt)
            {
                ResolveCalc(calcStmt, resolutionContext);

            }
            else if (stmt is MatchStmt matchStmt)
            {
                Contract.Assert(false); // a plain MatchStmt isn't introduced until post-resolution

            }
            else if (stmt is NestedMatchStmt nestedMatchStmt)
            {
                ResolveNestedMatchStmt(nestedMatchStmt, resolutionContext);

            }
            else if (stmt is SkeletonStatement skeletonStatement)
            {
                ReportError(stmt.Tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(206L, "skeleton statements are allowed only in refining methods"));
                // nevertheless, resolve the underlying statement; hey, why not
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_4(207L, skeletonStatement.S, null))
                {
                    ResolveStatement(skeletonStatement.S, resolutionContext);
                }

            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();
            }
        }

        private void ResolveOneBodyLoopStmt(OneBodyLoopStmt s, ResolutionContext resolutionContext)
        {
            Contract.Requires(s != null);
            Contract.Requires(resolutionContext != null);

            if (s is WhileStmt whileS && MutateCSharp.Schemata424.ReplaceBinExprOp_25(208L, whileS.Guard, null))
            {
                ResolveExpression(whileS.Guard, resolutionContext);
                ConstrainTypeExprBool(whileS.Guard, MutateCSharp.Schemata424.ReplaceStringConstant_3(209L, "condition is expected to be of type bool, but is {0}"));

            }
            else if (s is ForLoopStmt forS)
            {
                var loopIndex = forS.LoopIndex;
                resolver.ResolveType(loopIndex.tok, loopIndex.Type, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                loopIndex.PreType = Type2PreType(loopIndex.Type);
                AddConfirmation(PreTypeConstraints.CommonConfirmationBag.InIntFamily, loopIndex.PreType, loopIndex.tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(210L, "index variable is expected to be of an integer type (got {0})"));

                ResolveExpression(forS.Start, resolutionContext);
                AddSubtypeConstraint(loopIndex.PreType, forS.Start.PreType, forS.Start.tok,
        MutateCSharp.Schemata424.ReplaceStringConstant_3(211L, "lower bound (of type {1}) not assignable to index variable (of type {0})"));
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_25(212L, forS.End, null))
                {
                    ResolveExpression(forS.End, resolutionContext);
                    AddSubtypeConstraint(loopIndex.PreType, forS.End.PreType, forS.End.tok,
          MutateCSharp.Schemata424.ReplaceStringConstant_3(213L, "upper bound (of type {1}) not assignable to index variable (of type {0})"));
                    if (MutateCSharp.Schemata424.ReplaceBinExprOp_21(218L, forS.Decreases.Expressions.Count, MutateCSharp.Schemata424.ReplaceNumericConstant_12(214L, 0)))
                    {
                        ReportError(forS.Decreases.Expressions[MutateCSharp.Schemata424.ReplaceNumericConstant_12(223L, 0)].tok,
            MutateCSharp.Schemata424.ReplaceStringConstant_3(227L, "a 'for' loop is allowed an explicit 'decreases' clause only if the end-expression is '*'"));
                    }
                }
                else if (MutateCSharp.Schemata424.ReplaceBinExprOp_10(237L, () => MutateCSharp.Schemata424.ReplaceBinExprOp_15(232L, forS.Decreases.Expressions.Count, MutateCSharp.Schemata424.ReplaceNumericConstant_12(228L, 0)), () => !resolutionContext.CodeContext.AllowsNontermination))
                {
                    // note, the following error message is also emitted elsewhere (if the loop bears a "decreases *")
                    ReportError(forS.Tok,
          MutateCSharp.Schemata424.ReplaceStringConstant_3(243L, "a possibly infinite loop is allowed only if the enclosing method is declared (with 'decreases *') to be possibly non-terminating") +
          MutateCSharp.Schemata424.ReplaceStringConstant_3(244L, " (or you can add a 'decreases' clause to this 'for' loop if you want to prove that it does indeed terminate)"));
                }

                // Create a new scope, add the local to the scope, and resolve the attributes
                scope.PushMarker();
                ScopePushAndReport(loopIndex, MutateCSharp.Schemata424.ReplaceStringConstant_3(245L, "index-variable"), MutateCSharp.Schemata424.ReplaceBooleanConstant_0(246L, false));
                ResolveAttributes(s, resolutionContext, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(247L, false));
            }

            ResolveLoopSpecificationComponents(s.Invariants, s.Decreases, s.Mod, resolutionContext);

            if (MutateCSharp.Schemata424.ReplaceBinExprOp_28(248L, s.Body, null))
            {
                loopStack.Add(s); // push
                dominatingStatementLabels.PushMarker();
                ResolveStatement(s.Body, resolutionContext);
                dominatingStatementLabels.PopMarker();
                loopStack.RemoveAt(MutateCSharp.Schemata424.ReplaceBinExprOp_16(253L, loopStack.Count, MutateCSharp.Schemata424.ReplaceNumericConstant_12(249L, 1))); // pop
            }

            if (s is ForLoopStmt)
            {
                scope.PopMarker();
            }
        }

        private void ResolveCalc(CalcStmt s, ResolutionContext resolutionContext)
        {
            var prevErrorCount = ErrorCount;
            // figure out s.Op
            Contract.Assert(s.Op == null); // it hasn't been set yet
            if (MutateCSharp.Schemata424.ReplaceBinExprOp_29(262L, s.UserSuppliedOp, null))
            {
                s.Op = s.UserSuppliedOp;
            }
            else
            {
                s.Op = s.GetInferredDefaultOp() ?? CalcStmt.DefaultOp;
                ReportInfo(s.Tok, s.Op.ToString());
            }

            if (MutateCSharp.Schemata424.ReplaceBinExprOp_30(267L, s.Lines.Count, MutateCSharp.Schemata424.ReplaceNumericConstant_12(263L, 0)))
            {
                PreType linePreType = CreatePreTypeProxy(MutateCSharp.Schemata424.ReplaceStringConstant_3(272L, "calc line"));
                var e0 = s.Lines.First();
                ResolveExpression(e0, resolutionContext);
                AddSubtypeConstraint(linePreType, e0.PreType, e0.tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(273L, "all lines in a calculation must have the same type (got {1} after {0})"));
                for (var i = MutateCSharp.Schemata424.ReplaceNumericConstant_12(274L, 1); MutateCSharp.Schemata424.ReplaceBinExprOp_17(278L, i, s.Lines.Count); MutateCSharp.Schemata424.ReplacePostfixUnaryExprOp_22(283L, ref i))
                {
                    var e1 = s.Lines[i];
                    ResolveExpression(e1, resolutionContext);
#if SOON
          // reuse the error object if we're on the dummy line; this prevents a duplicate error message
#endif
                    if (MutateCSharp.Schemata424.ReplaceBinExprOp_17(297L, i, MutateCSharp.Schemata424.ReplaceBinExprOp_16(288L, s.Lines.Count, MutateCSharp.Schemata424.ReplaceNumericConstant_12(284L, 1))))
                    {
                        AddSubtypeConstraint(linePreType, e1.PreType, e1.tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(302L, "all lines in a calculation must have the same type (got {1} after {0})"));
                    }
                    var step = (s.StepOps[MutateCSharp.Schemata424.ReplaceBinExprOp_16(307L, i, MutateCSharp.Schemata424.ReplaceNumericConstant_12(303L, 1))] ?? s.Op).StepExpr(e0, e1); // Use custom line operator
                    ResolveExpression(step, resolutionContext);
                    s.Steps.Add(step);
                    e0 = e1;
                }

                // clear the labels for the duration of checking the hints, because break statements are not allowed to leave a forall statement
                var prevLblStmts = EnclosingStatementLabels;
                var prevLoopStack = loopStack;
                EnclosingStatementLabels = new Scope<Statement>(resolver.Options);
                loopStack = new List<Statement>();
                foreach (var h in s.Hints)
                {
                    foreach (var oneHint in h.Body)
                    {
                        dominatingStatementLabels.PushMarker();
                        ResolveStatement(oneHint, resolutionContext);
                        dominatingStatementLabels.PopMarker();
                    }
                }
                EnclosingStatementLabels = prevLblStmts;
                loopStack = prevLoopStack;
            }
            if (MutateCSharp.Schemata424.ReplaceBinExprOp_10(330L, () => MutateCSharp.Schemata424.ReplaceBinExprOp_15(316L, prevErrorCount, ErrorCount), () => MutateCSharp.Schemata424.ReplaceBinExprOp_30(325L, s.Lines.Count, MutateCSharp.Schemata424.ReplaceNumericConstant_12(321L, 0))))
            {
                // do not build Result from the lines if there were errors, as it might be ill-typed and produce unnecessary resolution errors
                var resultOp = s.StepOps.Aggregate(s.Op, (op0, op1) => MutateCSharp.Schemata424.ReplaceBinExprOp_31(336L, op1, null) ? op0 : op0.ResultOp(op1));
                s.Result = resultOp.StepExpr(s.Lines.First(), s.Lines.Last());
            }
            else
            {
                s.Result = CalcStmt.DefaultOp.StepExpr(Expression.CreateIntLiteral(s.Tok, MutateCSharp.Schemata424.ReplaceNumericConstant_12(337L, 0)), Expression.CreateIntLiteral(s.Tok, MutateCSharp.Schemata424.ReplaceNumericConstant_12(341L, 0)));
            }
            ResolveExpression(s.Result, resolutionContext);
            Contract.Assert(s.Result != null);
            Contract.Assert(prevErrorCount != ErrorCount || s.Steps.Count == s.Hints.Count);
        }

        private void ResolveConcreteUpdateStmt(ConcreteUpdateStatement update, List<LocalVariable> locals, ResolutionContext resolutionContext)
        {
            Contract.Requires(update != null || locals != null);
            // We have four cases.
            Contract.Assert(update == null || update is AssignSuchThatStmt || update is UpdateStmt || update is AssignOrReturnStmt);
            // 0.  There is no update.  This is easy, we will just resolve the locals.
            // 1.  The update is an AssignSuchThatStmt.  This is also straightforward:  first
            //     resolve the locals, which adds them to the scope, and then resolve the update.
            // 2.  The update is an UpdateStmt, which, resolved, means either a CallStmt or a bunch
            //     of simultaneous AssignStmt's.  Here, the right-hand sides should be resolved before
            //     the local variables have been added to the scope, but the left-hand sides should
            //     resolve to the newly introduced variables.
            // 3.  The update is a ":-" statement, for which resolution does two steps:
            //     First, desugar, then run the regular resolution on the desugared AST.

            var errorCountBeforeCheckingStmt = ErrorCount;

            // For UpdateStmt and AssignOrReturnStmt, resolve the RHSs before adding the LHSs to the scope
            if (update is UpdateStmt updateStatement)
            {
                foreach (var rhs in updateStatement.Rhss)
                {
                    ResolveAssignmentRhs(rhs, updateStatement, resolutionContext);
                }
            }
            else if (update is AssignOrReturnStmt elephantStmt)
            {
                elephantStmt.ResolveKeywordToken(this, resolutionContext);

                ResolveAssignmentRhs(elephantStmt.Rhs, elephantStmt, resolutionContext);
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_32(345L, elephantStmt.Rhss, null))
                {
                    foreach (var rhs in elephantStmt.Rhss)
                    {
                        ResolveAssignmentRhs(rhs, elephantStmt, resolutionContext);
                    }
                }
            }

            if (MutateCSharp.Schemata424.ReplaceBinExprOp_33(346L, locals, null))
            {
                // Add the locals to the scope
                foreach (var local in locals)
                {
                    int prevErrorCount = ErrorCount;
                    resolver.ResolveType(local.Tok, local.OptionalType, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                    local.type = MutateCSharp.Schemata424.ReplaceBinExprOp_15(347L, ErrorCount, prevErrorCount) ? local.OptionalType : new InferredTypeProxy();
                    ScopePushAndReport(local, MutateCSharp.Schemata424.ReplaceStringConstant_3(352L, "local-variable"), MutateCSharp.Schemata424.ReplaceBooleanConstant_0(353L, true));
                }
                // With the new locals in scope, it's now time to resolve the attributes on all the locals
                foreach (var local in locals)
                {
                    ResolveAttributes(local, resolutionContext, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(354L, false));
                }
            }

            if (update is AssignSuchThatStmt assignSuchThatStmt)
            {
                assignSuchThatStmt.GenResolve(this, resolutionContext);
            }
            else
            {
                // Resolve the LHSs
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_34(355L, update, null))
                {
                    foreach (var lhs in update.Lhss)
                    {
                        ResolveExpression(lhs, resolutionContext);
                    }
                }

                if (update is UpdateStmt updateStmt)
                {
                    ResolveUpdateStmt(updateStmt, resolutionContext, errorCountBeforeCheckingStmt);
                }
                else if (update is AssignOrReturnStmt assignOrReturnStmt)
                {
                    ResolveAssignOrReturnStmt(assignOrReturnStmt, resolutionContext);
                }
                else
                {
                    Contract.Assert(update == null);
                }
            }
        }

        void ResolveAssignmentRhs(AssignmentRhs rhs, Statement enclosingStmt, ResolutionContext resolutionContext)
        {
            Contract.Requires(rhs != null);
            Contract.Requires(enclosingStmt != null);
            Contract.Requires(resolutionContext != null);

            if (rhs is TypeRhs tr)
            {
                ResolveTypeRhs(tr, enclosingStmt, resolutionContext);
            }
            else if (rhs is ExprRhs er)
            {
                if (er.Expr is ApplySuffix applySuffix)
                {
                    ResolveApplySuffix(applySuffix, resolutionContext, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(356L, true));
                }
                else
                {
                    ResolveExpression(er.Expr, resolutionContext);
                }
            }
            else
            {
                Contract.Assert(rhs is HavocRhs);
            }
        }

        /// <summary>
        /// Assumes that LHSs and RHSs have already been resolved.
        /// Resolve the entire UpdateStmt.
        /// errorCountBeforeCheckingStmt is passed in so that this method can determine if any resolution errors were found during
        /// LHS or RHS checking, because only if no errors were found is update.ResolvedStmt changed.
        /// </summary>
        private void ResolveUpdateStmt(UpdateStmt update, ResolutionContext resolutionContext, int errorCountBeforeCheckingStmt)
        {
            Contract.Requires(update != null);
            Contract.Requires(resolutionContext != null);
            IToken firstEffectfulRhs = null;
            MethodCallInformation methodCallInfo = null;
            update.ResolvedStatements = new();
            foreach (var rhs in update.Rhss)
            {
                bool isEffectful;
                if (rhs is TypeRhs tr)
                {
                    isEffectful = MutateCSharp.Schemata424.ReplaceBinExprOp_35(357L, tr.InitCall, null);
                }
                else if (rhs is HavocRhs)
                {
                    isEffectful = MutateCSharp.Schemata424.ReplaceBooleanConstant_0(358L, false);
                }
                else
                {
                    var er = (ExprRhs)rhs;
                    if (er.Expr is ApplySuffix applySuffix)
                    {
                        var cRhs = applySuffix.MethodCallInfo;
                        isEffectful = MutateCSharp.Schemata424.ReplaceBinExprOp_36(359L, cRhs, null);
                        methodCallInfo = methodCallInfo ?? cRhs;
                    }
                    else
                    {
                        isEffectful = MutateCSharp.Schemata424.ReplaceBooleanConstant_0(360L, false);
                    }
                }
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_10(362L, () => isEffectful, () => MutateCSharp.Schemata424.ReplaceBinExprOp_37(361L, firstEffectfulRhs, null)))
                {
                    firstEffectfulRhs = rhs.Tok;
                }

                ResolveAttributes(rhs, resolutionContext, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(368L, false));
            }

            // figure out what kind of UpdateStmt this is
            if (MutateCSharp.Schemata424.ReplaceBinExprOp_37(369L, firstEffectfulRhs, null))
            {
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_15(374L, update.Lhss.Count, MutateCSharp.Schemata424.ReplaceNumericConstant_12(370L, 0)))
                {
                    Contract.Assert(update.Rhss.Count == 1);  // guaranteed by the parser
                    ReportError(update, MutateCSharp.Schemata424.ReplaceStringConstant_3(379L, "expected method call, found expression"));
                }
                else if (MutateCSharp.Schemata424.ReplaceBinExprOp_21(380L, update.Lhss.Count, update.Rhss.Count))
                {
                    ReportError(update, MutateCSharp.Schemata424.ReplaceStringConstant_3(385L, "the number of left-hand sides ({0}) and right-hand sides ({1}) must match for a multi-assignment"),
                      update.Lhss.Count, update.Rhss.Count);
                }
                else if (MutateCSharp.Schemata424.ReplaceBinExprOp_15(386L, ErrorCount, errorCountBeforeCheckingStmt))
                {
                    // add the statements here in a sequence, but don't use that sequence later for translation (instead, should translate properly as multi-assignment)
                    for (var i = MutateCSharp.Schemata424.ReplaceNumericConstant_12(391L, 0); MutateCSharp.Schemata424.ReplaceBinExprOp_17(395L, i, update.Lhss.Count); MutateCSharp.Schemata424.ReplacePostfixUnaryExprOp_22(400L, ref i))
                    {
                        var a = new AssignStmt(update.RangeToken, update.Lhss[i].Resolved, update.Rhss[i]);
                        update.ResolvedStatements.Add(a);
                    }
                }

            }
            else if (update.CanMutateKnownState)
            {
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_17(405L, MutateCSharp.Schemata424.ReplaceNumericConstant_12(401L, 1), update.Rhss.Count))
                {
                    ReportError(firstEffectfulRhs, MutateCSharp.Schemata424.ReplaceStringConstant_3(410L, "cannot have effectful parameter in multi-return statement."));
                }
                else
                { // it might be ok, if it is a TypeRhs
                    Contract.Assert(update.Rhss.Count == 1);
                    if (MutateCSharp.Schemata424.ReplaceBinExprOp_36(411L, methodCallInfo, null))
                    {
                        ReportError(methodCallInfo.Tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(412L, "cannot have method call in return statement."));
                    }
                    else
                    {
                        // we have a TypeRhs
                        var tr = (TypeRhs)update.Rhss[MutateCSharp.Schemata424.ReplaceNumericConstant_12(413L, 0)];
                        Contract.Assert(tr.InitCall != null); // there were effects, so this must have been a call.
                        if (tr.CanAffectPreviouslyKnownExpressions)
                        {
                            ReportError(tr.Tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(417L, "can only have initialization methods which modify at most 'this'."));
                        }
                        else if (MutateCSharp.Schemata424.ReplaceBinExprOp_15(418L, ErrorCount, errorCountBeforeCheckingStmt))
                        {
                            var a = new AssignStmt(update.RangeToken, update.Lhss[MutateCSharp.Schemata424.ReplaceNumericConstant_12(423L, 0)].Resolved, tr);
                            update.ResolvedStatements.Add(a);
                        }
                    }
                }

            }
            else
            {
                // if there was an effectful RHS, that must be the only RHS
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_21(431L, update.Rhss.Count, MutateCSharp.Schemata424.ReplaceNumericConstant_12(427L, 1)))
                {
                    ReportError(firstEffectfulRhs, MutateCSharp.Schemata424.ReplaceStringConstant_3(436L, "an update statement is allowed an effectful RHS only if there is just one RHS"));
                }
                else if (MutateCSharp.Schemata424.ReplaceBinExprOp_9(437L, methodCallInfo, null))
                {
                    // must be a single TypeRhs
                    if (MutateCSharp.Schemata424.ReplaceBinExprOp_21(442L, update.Lhss.Count, MutateCSharp.Schemata424.ReplaceNumericConstant_12(438L, 1)))
                    {
                        Contract.Assert(2 <= update.Lhss.Count);  // the parser allows 0 Lhss only if the whole statement looks like an expression (not a TypeRhs)
                        ReportError(update.Lhss[MutateCSharp.Schemata424.ReplaceNumericConstant_12(447L, 1)].tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(451L, "the number of left-hand sides ({0}) and right-hand sides ({1}) must match for a multi-assignment"),
                          update.Lhss.Count, update.Rhss.Count);
                    }
                    else if (MutateCSharp.Schemata424.ReplaceBinExprOp_15(452L, ErrorCount, errorCountBeforeCheckingStmt))
                    {
                        var a = new AssignStmt(update.RangeToken, update.Lhss[MutateCSharp.Schemata424.ReplaceNumericConstant_12(457L, 0)].Resolved, update.Rhss[MutateCSharp.Schemata424.ReplaceNumericConstant_12(461L, 0)]);
                        update.ResolvedStatements.Add(a);
                    }
                }
                else if (MutateCSharp.Schemata424.ReplaceBinExprOp_15(465L, ErrorCount, errorCountBeforeCheckingStmt))
                {
                    // a call statement
                    var resolvedLhss = update.Lhss.ConvertAll(ll => ll.Resolved);
                    var a = new CallStmt(update.RangeToken, resolvedLhss, methodCallInfo.Callee, methodCallInfo.ActualParameters, methodCallInfo.Tok);
                    a.OriginalInitialLhs = update.OriginalInitialLhs;
                    update.ResolvedStatements.Add(a);
                }
            }

            foreach (var a in update.ResolvedStatements)
            {
                ResolveStatement(a, resolutionContext);
            }
        }

        private void ResolveLoopSpecificationComponents(List<AttributedExpression> invariants,
          Specification<Expression> decreases, Specification<FrameExpression> modifies,
          ResolutionContext resolutionContext)
        {
            Contract.Requires(invariants != null);
            Contract.Requires(decreases != null);
            Contract.Requires(modifies != null);
            Contract.Requires(resolutionContext != null);

            foreach (AttributedExpression inv in invariants)
            {
                ResolveAttributes(inv, resolutionContext, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(470L, false));
                ResolveExpression(inv.E, resolutionContext);
                ConstrainTypeExprBool(inv.E, MutateCSharp.Schemata424.ReplaceStringConstant_3(471L, "invariant is expected to be of type bool, but is {0}"));
            }

            ResolveAttributes(decreases, resolutionContext, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(472L, false));
            foreach (Expression e in decreases.Expressions)
            {
                ResolveExpression(e, resolutionContext);
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_10(473L, () => e is WildcardExpr, () => !resolutionContext.CodeContext.AllowsNontermination))
                {
                    ReportError(e, MutateCSharp.Schemata424.ReplaceStringConstant_3(479L, "a possibly infinite loop is allowed only if the enclosing method is declared (with 'decreases *') to be possibly non-terminating"));
                }
                // any type is fine
            }

            ResolveAttributes(modifies, resolutionContext, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(480L, false));
            if (MutateCSharp.Schemata424.ReplaceBinExprOp_38(481L, modifies.Expressions, null))
            {
                foreach (var fe in modifies.Expressions)
                {
                    ResolveFrameExpression(fe, FrameExpressionUse.Modifies, resolutionContext.CodeContext);
                }
            }
        }

        /// <summary>
        /// Resolves the given call statement.
        /// Assumes all LHSs have already been resolved (and checked for mutability).
        /// </summary>
        void ResolveCallStmt(CallStmt s, ResolutionContext resolutionContext, Type receiverType)
        {
            Contract.Requires(s != null);
            Contract.Requires(resolutionContext != null);
            bool isInitCall = MutateCSharp.Schemata424.ReplaceBinExprOp_39(482L, receiverType, null);

            var callee = s.Method;
            Contract.Assert(callee != null);  // follows from the invariant of CallStmt
            if (MutateCSharp.Schemata424.ReplaceBinExprOp_10(483L, () => !isInitCall, () => callee is Constructor))
            {
                ReportError(s, MutateCSharp.Schemata424.ReplaceStringConstant_3(489L, "a constructor is allowed to be called only when an object is being allocated"));
            }

            // resolve left-hand sides (the right-hand sides are resolved below)
            foreach (var lhs in s.Lhs)
            {
                Contract.Assume(lhs.PreType != null);  // a sanity check that LHSs have already been resolved
            }

            bool tryToResolve = MutateCSharp.Schemata424.ReplaceBooleanConstant_0(490L, false);
            if (MutateCSharp.Schemata424.ReplaceBinExprOp_21(491L, callee.Outs.Count, s.Lhs.Count))
            {
                if (isInitCall)
                {
                    ReportError(s, MutateCSharp.Schemata424.ReplaceStringConstant_3(496L, "a method called as an initialization method must not have any result arguments"));
                }
                else
                {
                    ReportError(s, MutateCSharp.Schemata424.ReplaceStringConstant_3(497L, "wrong number of method result arguments (got {0}, expected {1})"), s.Lhs.Count, callee.Outs.Count);
                    tryToResolve = MutateCSharp.Schemata424.ReplaceBooleanConstant_0(498L, true);
                }
            }
            else
            {
                if (isInitCall)
                {
                    if (callee.IsStatic)
                    {
                        ReportError(s.Tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(499L, "a method called as an initialization method must not be 'static'"));
                    }
                    else
                    {
                        tryToResolve = MutateCSharp.Schemata424.ReplaceBooleanConstant_0(500L, true);
                    }
                }
                else if (!callee.IsStatic)
                {
                    if (MutateCSharp.Schemata424.ReplaceBinExprOp_10(501L, () => !scope.AllowInstance, () => s.Receiver is ThisExpr))
                    {
                        // The call really needs an instance, but that instance is given as 'this', which is not
                        // available in this context.  For more details, see comment in the resolution of a
                        // FunctionCallExpr.
                        ReportError(s.Receiver, MutateCSharp.Schemata424.ReplaceStringConstant_3(507L, "'this' is not allowed in a 'static' context"));
                    }
                    else if (s.Receiver is StaticReceiverExpr)
                    {
                        ReportError(s.Receiver, MutateCSharp.Schemata424.ReplaceStringConstant_3(508L, "call to instance method requires an instance"));
                    }
                    else
                    {
                        tryToResolve = MutateCSharp.Schemata424.ReplaceBooleanConstant_0(509L, true);
                    }
                }
                else
                {
                    tryToResolve = MutateCSharp.Schemata424.ReplaceBooleanConstant_0(510L, true);
                }
            }

            if (tryToResolve)
            {
                var typeMap = s.MethodSelect.PreTypeArgumentSubstitutionsAtMemberDeclaration();
                // resolve arguments
                ResolveActualParameters(s.Bindings, callee.Ins, s.Tok, callee, resolutionContext, typeMap,
                  callee.IsStatic ? null : s.Receiver);
                // type check the out-parameter arguments (in-parameters were type checked as part of ResolveActualParameters)
                for (var i = MutateCSharp.Schemata424.ReplaceNumericConstant_12(511L, 0); MutateCSharp.Schemata424.ReplaceBinExprOp_10(525L, () => MutateCSharp.Schemata424.ReplaceBinExprOp_17(515L, i, callee.Outs.Count), () => MutateCSharp.Schemata424.ReplaceBinExprOp_17(520L, i, s.Lhs.Count)); MutateCSharp.Schemata424.ReplacePostfixUnaryExprOp_22(531L, ref i))
                {
                    var outFormal = callee.Outs[i];
                    var st = outFormal.PreType.Substitute(typeMap);
                    var lhs = s.Lhs[i];
                    var what = GetLocationInformation(outFormal, callee.Outs.Count, i, MutateCSharp.Schemata424.ReplaceStringConstant_3(532L, "method out-parameter"));

                    AddSubtypeConstraint(lhs.PreType, st, s.Tok, $"incorrect return type {what} (expected {{1}}, got {{0}})");
                }
                for (int i = MutateCSharp.Schemata424.ReplaceNumericConstant_12(533L, 0); MutateCSharp.Schemata424.ReplaceBinExprOp_17(537L, i, s.Lhs.Count); MutateCSharp.Schemata424.ReplacePostfixUnaryExprOp_22(542L, ref i))
                {
                    var lhs = s.Lhs[i];
                    // LHS must denote a mutable field.
                    CheckIsLvalue(lhs.Resolved, resolutionContext);
                }

#if SOON
        // Resolution termination check
        ModuleDefinition callerModule = resolutionContext.EnclosingModule;
        ModuleDefinition calleeModule = ((ICodeContext)callee).EnclosingModule;
        if (callerModule == calleeModule) {
          // intra-module call; add edge in module's call graph
          var caller = CodeContextWrapper.Unwrap(resolutionContext) as ICallable;
          if (caller == null) {
            // don't add anything to the call graph after all
          } else if (caller is IteratorDecl) {
            callerModule.CallGraph.AddEdge(((IteratorDecl)caller).Member_MoveNext, callee);
          } else {
            callerModule.CallGraph.AddEdge(caller, callee);
            if (caller == callee) {
              callee.IsRecursive = true;  // self recursion (mutual recursion is determined elsewhere)
            }
          }
        }
#endif
            }
            if (MutateCSharp.Schemata424.ReplaceBinExprOp_10(543L, () => Contract.Exists(callee.Decreases.Expressions, e => e is WildcardExpr), () => !resolutionContext.CodeContext.AllowsNontermination))
            {
                ReportError(s.Tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(549L, "a call to a possibly non-terminating method is allowed only if the calling method is also declared (with 'decreases *') to be possibly non-terminating"));
            }
        }

        /// <summary>
        /// Desugars "y, ... :- MethodOrExpression" into
        /// var temp;
        /// temp, ... := MethodOrExpression;
        /// if temp.IsFailure() { return temp.PropagateFailure(); }
        /// y := temp.Extract();
        ///
        /// If the type of MethodExpression does not have an Extract, then the desugaring is
        /// var temp;
        /// temp, y, ... := MethodOrExpression;
        /// if temp.IsFailure() { return temp.PropagateFailure(); }
        ///
        /// If there are multiple RHSs then "y, ... :- Expression, ..." becomes
        /// var temp;
        /// temp, ... := Expression, ...;
        /// if temp.IsFailure() { return temp.PropagateFailure(); }
        /// y := temp.Extract();
        /// OR
        /// var temp;
        /// temp, y, ... := Expression, ...;
        /// if temp.IsFailure() { return temp.PropagateFailure(); }
        ///
        /// and "y, ... :- expect MethodOrExpression, ..." into
        /// var temp, [y, ] ... := MethodOrExpression, ...;
        /// expect !temp.IsFailure(), temp.PropagateFailure();
        /// [y := temp.Extract();]
        ///
        /// and saves the result into s.ResolvedStatements.
        /// This is also known as the "elephant operator"
        /// </summary>
        private void ResolveAssignOrReturnStmt(AssignOrReturnStmt s, ResolutionContext resolutionContext)
        {
            // We need to figure out whether we are using a status type that has Extract or not,
            // as that determines how the AssignOrReturnStmt is desugared. Thus if the RHS is a
            // method call, then we need to know which one (to inspect its first output); if RHS is a
            // list of expressions, we need to know the type of the first one. For all of this we have
            // to do some partial type resolution.

            bool expectExtract = MutateCSharp.Schemata424.ReplaceBinExprOp_21(554L, s.Lhss.Count, MutateCSharp.Schemata424.ReplaceNumericConstant_12(550L, 0)); // default value if we cannot determine and inspect the type
            PreType firstPreType = null;
            Method callee = null;
            Contract.Assert(s.Rhss != null);
            if (MutateCSharp.Schemata424.ReplaceBinExprOp_15(563L, s.Rhss.Count, MutateCSharp.Schemata424.ReplaceNumericConstant_12(559L, 0)) && s.Rhs.Expr is ApplySuffix asx)
            {
                var methodCallInfo = ResolveApplySuffix(asx, resolutionContext, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(568L, true));
                callee = methodCallInfo?.Callee.Member as Method;
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_40(569L, callee, null))
                {
                    // We're looking at a method call
                    if (MutateCSharp.Schemata424.ReplaceBinExprOp_21(574L, callee.Outs.Count, MutateCSharp.Schemata424.ReplaceNumericConstant_12(570L, 0)))
                    {
                        var typeMap = PreType.PreTypeSubstMap(callee.TypeArgs, methodCallInfo.Callee.PreTypeApplication_JustMember);
                        firstPreType = callee.Outs[MutateCSharp.Schemata424.ReplaceNumericConstant_12(579L, 0)].PreType.Substitute(typeMap);
                    }
                    else
                    {
                        ReportError(s.Rhs.tok, $"Expected '{callee.Name}' to have a success/failure output value, but the method returns nothing.");
                    }
                }
                else
                {
                    // We're looking at a call to a function. Treat it like any other expression.
                    firstPreType = asx.PreType;
                }
            }
            else
            {
                ResolveExpression(s.Rhs.Expr, resolutionContext);
                firstPreType = s.Rhs.Expr.PreType;
            }

            var enclosingMethod = (Method)resolutionContext.CodeContext;
            if (MutateCSharp.Schemata424.ReplaceBinExprOp_10(593L, () => MutateCSharp.Schemata424.ReplaceBinExprOp_15(587L, enclosingMethod.Outs.Count, MutateCSharp.Schemata424.ReplaceNumericConstant_12(583L, 0)), () => MutateCSharp.Schemata424.ReplaceBinExprOp_41(592L, s.KeywordToken, null)))
            {
                ReportError(s.Tok, $"A method containing a :- statement must have an out-parameter ({enclosingMethod.Name})");
                return;
            }
            TopLevelDeclWithMembers failureSupportingType = null;
            if (MutateCSharp.Schemata424.ReplaceBinExprOp_42(599L, firstPreType, null))
            {
                Constraints.FindDefinedPreType(firstPreType, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(600L, true));
                failureSupportingType = (firstPreType.Normalize() as DPreType)?.Decl as TopLevelDeclWithMembers;
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_43(601L, failureSupportingType, null))
                {
                    if (MutateCSharp.Schemata424.ReplaceBinExprOp_45(604L, failureSupportingType.Members.Find(x => MutateCSharp.Schemata424.ReplaceBinExprOp_44(603L, x.Name, MutateCSharp.Schemata424.ReplaceStringConstant_3(602L, "IsFailure"))), null))
                    {
                        ReportError(s.Tok, $"member IsFailure does not exist in {firstPreType}, in :- statement");
                        return;
                    }
                    expectExtract = MutateCSharp.Schemata424.ReplaceBinExprOp_24(607L, failureSupportingType.Members.Find(x => MutateCSharp.Schemata424.ReplaceBinExprOp_44(606L, x.Name, MutateCSharp.Schemata424.ReplaceStringConstant_3(605L, "Extract"))), null);
                    if (MutateCSharp.Schemata424.ReplaceBinExprOp_10(633L, () => MutateCSharp.Schemata424.ReplaceBinExprOp_10(609L, () => expectExtract, () => MutateCSharp.Schemata424.ReplaceBinExprOp_46(608L, callee, null)), () => MutateCSharp.Schemata424.ReplaceBinExprOp_21(628L, s.Lhss.Count, MutateCSharp.Schemata424.ReplaceBinExprOp_47(619L, MutateCSharp.Schemata424.ReplaceNumericConstant_12(615L, 1), s.Rhss.Count))))
                    {
                        ReportError(s.Tok,
            MutateCSharp.Schemata424.ReplaceStringConstant_3(639L, "number of lhs ({0}) must match number of rhs ({1}) for a rhs type ({2}) with member Extract"),
                          s.Lhss.Count, MutateCSharp.Schemata424.ReplaceBinExprOp_47(644L, MutateCSharp.Schemata424.ReplaceNumericConstant_12(640L, 1), s.Rhss.Count), firstPreType);
                        return;
                    }
                    else if (MutateCSharp.Schemata424.ReplaceBinExprOp_10(665L, () => MutateCSharp.Schemata424.ReplaceBinExprOp_10(654L, () => expectExtract, () => MutateCSharp.Schemata424.ReplaceBinExprOp_40(653L, callee, null)), () => MutateCSharp.Schemata424.ReplaceBinExprOp_21(660L, s.Lhss.Count, callee.Outs.Count)))
                    {
                        ReportError(s.Tok,
            MutateCSharp.Schemata424.ReplaceStringConstant_3(671L, "wrong number of method result arguments (got {0}, expected {1}) for a rhs type ({2}) with member Extract"),
                          s.Lhss.Count, callee.Outs.Count, firstPreType);
                        return;
                    }
                    else if (MutateCSharp.Schemata424.ReplaceBinExprOp_10(684L, () => MutateCSharp.Schemata424.ReplaceBinExprOp_10(673L, () => !expectExtract, () => MutateCSharp.Schemata424.ReplaceBinExprOp_46(672L, callee, null)), () => MutateCSharp.Schemata424.ReplaceBinExprOp_21(679L, s.Lhss.Count, s.Rhss.Count)))
                    {
                        ReportError(s.Tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(690L, "number of lhs ({0}) must be one less than number of rhs ({1}) for a rhs type ({2}) without member Extract"),
                          s.Lhss.Count, MutateCSharp.Schemata424.ReplaceBinExprOp_47(695L, MutateCSharp.Schemata424.ReplaceNumericConstant_12(691L, 1), s.Rhss.Count), firstPreType);
                        return;
                    }
                    else if (MutateCSharp.Schemata424.ReplaceBinExprOp_10(729L, () => MutateCSharp.Schemata424.ReplaceBinExprOp_10(705L, () => !expectExtract, () => MutateCSharp.Schemata424.ReplaceBinExprOp_40(704L, callee, null)), () => MutateCSharp.Schemata424.ReplaceBinExprOp_21(724L, s.Lhss.Count, MutateCSharp.Schemata424.ReplaceBinExprOp_16(715L, callee.Outs.Count, MutateCSharp.Schemata424.ReplaceNumericConstant_12(711L, 1)))))
                    {
                        ReportError(s.Tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(735L, "wrong number of method result arguments (got {0}, expected {1}) for a rhs type ({2}) without member Extract"),
                          s.Lhss.Count, MutateCSharp.Schemata424.ReplaceBinExprOp_16(740L, callee.Outs.Count, MutateCSharp.Schemata424.ReplaceNumericConstant_12(736L, 1)), firstPreType);
                        return;
                    }
                }
                else
                {
                    ReportError(s.Tok,
                      $"The type of the first expression to the right of ':-' could not be determined to be a failure type (got '{firstPreType}')");
                    return;
                }
            }
            else
            {
                ReportError(s.Tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(749L, "Internal Error: Unknown failure type in :- statement"));
                return;
            }

            Expression lhsExtract = null;
            if (expectExtract)
            {
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_10(760L, () => MutateCSharp.Schemata424.ReplaceBinExprOp_15(754L, enclosingMethod.Outs.Count, MutateCSharp.Schemata424.ReplaceNumericConstant_12(750L, 0)), () => MutateCSharp.Schemata424.ReplaceBinExprOp_41(759L, s.KeywordToken, null)))
                {
                    ReportError(s.Rhs.tok, $"Expected {enclosingMethod.Name} to have a Success/Failure output value");
                    return;
                }

                lhsExtract = s.Lhss[MutateCSharp.Schemata424.ReplaceNumericConstant_12(766L, 0)];
                var lhsResolved = lhsExtract.Resolved;
                // Make a new unresolved expression
                if (lhsResolved is MemberSelectExpr lexr)
                {
                    Expression id = MutateCSharp.Schemata424.ReplaceBinExprOp_48(770L, Expression.AsThis(lexr.Obj), null) ? lexr.Obj : resolver.makeTemp(MutateCSharp.Schemata424.ReplaceStringConstant_3(771L, "recv"), s, resolutionContext, lexr.Obj);
                    var lex = lhsExtract as ExprDotName; // might be just a NameSegment
                    lhsExtract = new ExprDotName(lexr.tok, id, lexr.MemberName, lex?.OptTypeArguments);
                }
                else if (lhsResolved is SeqSelectExpr lseq)
                {
                    if (MutateCSharp.Schemata424.ReplaceBinExprOp_7(773L, () => !lseq.SelectOne, () => MutateCSharp.Schemata424.ReplaceBinExprOp_49(772L, lseq.E0, null)))
                    {
                        ReportError(s.Tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(779L, "Element ranges not allowed as l-values"));
                        return;
                    }
                    Expression id = resolver.makeTemp(MutateCSharp.Schemata424.ReplaceStringConstant_3(780L, "recv"), s, resolutionContext, lseq.Seq);
                    Expression id0 = id0 = resolver.makeTemp(MutateCSharp.Schemata424.ReplaceStringConstant_3(781L, "idx"), s, resolutionContext, lseq.E0);
                    lhsExtract = new SeqSelectExpr(lseq.tok, lseq.SelectOne, id, id0, null, lseq.CloseParen);
                    lhsExtract.Type = lseq.Type;
                }
                else if (lhsResolved is MultiSelectExpr lmulti)
                {
                    Expression id = resolver.makeTemp(MutateCSharp.Schemata424.ReplaceStringConstant_3(782L, "recv"), s, resolutionContext, lmulti.Array);
                    var idxs = new List<Expression>();
                    foreach (var i in lmulti.Indices)
                    {
                        Expression idx = resolver.makeTemp(MutateCSharp.Schemata424.ReplaceStringConstant_3(783L, "idx"), s, resolutionContext, i);
                        idxs.Add(idx);
                    }
                    lhsExtract = new MultiSelectExpr(lmulti.tok, id, idxs);
                    lhsExtract.Type = lmulti.Type;
                }
                else if (lhsResolved is IdentifierExpr)
                {
                    // do nothing
                }
                else if (MutateCSharp.Schemata424.ReplaceBinExprOp_49(784L, lhsResolved, null))
                {
                    // LHS failed to resolve. Abort trying to resolve assign or return stmt
                    return;
                }
                else
                {
                    throw new InvalidOperationException(MutateCSharp.Schemata424.ReplaceStringConstant_3(785L, "Internal error: unexpected option in AssignOrReturnStmt.Resolve"));
                }
            }
            var temp = resolver.FreshTempVarName(MutateCSharp.Schemata424.ReplaceStringConstant_3(786L, "valueOrError"), resolutionContext.CodeContext);
            var lhss = new List<LocalVariable>() { new LocalVariable(s.RangeToken, temp, new InferredTypeProxy(), MutateCSharp.Schemata424.ReplaceBooleanConstant_0(787L, false)) };
            // "var temp ;"
            s.ResolvedStatements.Add(new VarDeclStmt(s.RangeToken, lhss, null));
            var lhss2 = new List<Expression>() { new IdentifierExpr(s.Tok, temp) };
            for (int k = (expectExtract ? MutateCSharp.Schemata424.ReplaceNumericConstant_12(788L, 1) : MutateCSharp.Schemata424.ReplaceNumericConstant_12(792L, 0)); MutateCSharp.Schemata424.ReplaceBinExprOp_17(796L, k, s.Lhss.Count); MutateCSharp.Schemata424.ReplacePrefixUnaryExprOp_50(801L, ref k))
            {
                lhss2.Add(s.Lhss[k]);
            }
            List<AssignmentRhs> rhss2 = new List<AssignmentRhs>() { s.Rhs };
            rhss2.AddRange(s.Rhss);
            if (MutateCSharp.Schemata424.ReplaceBinExprOp_30(809L, s.Rhss.Count, MutateCSharp.Schemata424.ReplaceNumericConstant_12(805L, 0)))
            {
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_21(814L, lhss2.Count, rhss2.Count))
                {
                    ReportError(s.Tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(819L, "Mismatch in expected number of LHSs and RHSs"));
                    if (MutateCSharp.Schemata424.ReplaceBinExprOp_17(820L, lhss2.Count, rhss2.Count))
                    {
                        rhss2.RemoveRange(lhss2.Count, MutateCSharp.Schemata424.ReplaceBinExprOp_16(825L, rhss2.Count, lhss2.Count));
                    }
                    else
                    {
                        lhss2.RemoveRange(rhss2.Count, MutateCSharp.Schemata424.ReplaceBinExprOp_16(834L, lhss2.Count, rhss2.Count));
                    }
                }
            }
            // " temp, ... := MethodOrExpression, ...;"
            UpdateStmt up = new UpdateStmt(s.RangeToken, lhss2, rhss2);
            if (expectExtract)
            {
                up.OriginalInitialLhs = MutateCSharp.Schemata424.ReplaceBinExprOp_15(847L, s.Lhss.Count, MutateCSharp.Schemata424.ReplaceNumericConstant_12(843L, 0)) ? null : s.Lhss[MutateCSharp.Schemata424.ReplaceNumericConstant_12(852L, 0)];
            }
            s.ResolvedStatements.Add(up);

            if (MutateCSharp.Schemata424.ReplaceBinExprOp_51(856L, s.KeywordToken, null))
            {
                var notFailureExpr = new UnaryOpExpr(s.Tok, UnaryOpExpr.Opcode.Not, resolver.VarDotMethod(s.Tok, temp, MutateCSharp.Schemata424.ReplaceStringConstant_3(857L, "IsFailure")));
                Statement ss = null;
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_44(859L, s.KeywordToken.Token.val, MutateCSharp.Schemata424.ReplaceStringConstant_3(858L, "expect")))
                {
                    // "expect !temp.IsFailure(), temp"
                    ss = new ExpectStmt(new RangeToken(s.Tok, s.EndToken), notFailureExpr, new IdentifierExpr(s.Tok, temp), s.KeywordToken.Attrs);
                }
                else if (MutateCSharp.Schemata424.ReplaceBinExprOp_44(861L, s.KeywordToken.Token.val, MutateCSharp.Schemata424.ReplaceStringConstant_3(860L, "assume")))
                {
                    ss = new AssumeStmt(new RangeToken(s.Tok, s.EndToken), notFailureExpr, SystemModuleManager.AxiomAttribute(s.KeywordToken.Attrs));
                }
                else if (MutateCSharp.Schemata424.ReplaceBinExprOp_44(863L, s.KeywordToken.Token.val, MutateCSharp.Schemata424.ReplaceStringConstant_3(862L, "assert")))
                {
                    ss = new AssertStmt(new RangeToken(s.Tok, s.EndToken), notFailureExpr, null, null, s.KeywordToken.Attrs);
                }
                else
                {
                    Contract.Assert(false, $"Invalid token in :- statement: {s.KeywordToken.Token.val}");
                }
                s.ResolvedStatements.Add(ss);
            }
            else
            {
                var enclosingOutParameter = ((Method)resolutionContext.CodeContext).Outs[MutateCSharp.Schemata424.ReplaceNumericConstant_12(864L, 0)];
                var ident = new IdentifierExpr(s.Tok, enclosingOutParameter.Name)
                {
                    // resolve it here to avoid capture into more closely declared local variables
                    Var = enclosingOutParameter,
                    Type = enclosingOutParameter.Type,
                    PreType = enclosingOutParameter.PreType
                };

                s.ResolvedStatements.Add(
                  // "if temp.IsFailure()"
                  new IfStmt(s.RangeToken, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(868L, false), resolver.VarDotMethod(s.Tok, temp, MutateCSharp.Schemata424.ReplaceStringConstant_3(869L, "IsFailure")),
                    // THEN: { out := temp.PropagateFailure(); return; }
                    new BlockStmt(s.RangeToken, new List<Statement>() {
              new UpdateStmt(s.RangeToken,
                new List<Expression>() { ident },
                new List<AssignmentRhs>() {new ExprRhs(resolver.VarDotMethod(s.Tok, temp, MutateCSharp.Schemata424.ReplaceStringConstant_3(870L, "PropagateFailure")))}
              ),
              new ReturnStmt(s.RangeToken, null),
                    }),
                    // ELSE: no else block
                    null
                  ));
            }

            if (expectExtract)
            {
                // "y := temp.Extract();"
                var lhs = s.Lhss[MutateCSharp.Schemata424.ReplaceNumericConstant_12(871L, 0)];
                s.ResolvedStatements.Add(
                  new UpdateStmt(s.RangeToken,
                    new List<Expression>() { lhsExtract },
                    new List<AssignmentRhs>() { new ExprRhs(resolver.VarDotMethod(s.Tok, temp, MutateCSharp.Schemata424.ReplaceStringConstant_3(875L, "Extract"))) }
                  ));
            }

            s.ResolvedStatements.ForEach(a => ResolveStatement(a, resolutionContext));
            EnsureSupportsErrorHandling(s.Tok, failureSupportingType, expectExtract, s.KeywordToken?.Token.val);
        }

        private void EnsureSupportsErrorHandling(IToken tok, TopLevelDeclWithMembers failureSupportingType, bool expectExtract, [CanBeNull] string keyword)
        {

            var isFailure = failureSupportingType.Members.Find(x => MutateCSharp.Schemata424.ReplaceBinExprOp_44(877L, x.Name, MutateCSharp.Schemata424.ReplaceStringConstant_3(876L, "IsFailure")));
            var propagateFailure = failureSupportingType.Members.Find(x => MutateCSharp.Schemata424.ReplaceBinExprOp_44(879L, x.Name, MutateCSharp.Schemata424.ReplaceStringConstant_3(878L, "PropagateFailure")));
            var extract = failureSupportingType.Members.Find(x => MutateCSharp.Schemata424.ReplaceBinExprOp_44(881L, x.Name, MutateCSharp.Schemata424.ReplaceStringConstant_3(880L, "Extract")));

            if (keyword != null)
            {
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_7(890L, () => MutateCSharp.Schemata424.ReplaceBinExprOp_45(882L, isFailure, null), () => MutateCSharp.Schemata424.ReplaceBinExprOp_52(884L, () => (MutateCSharp.Schemata424.ReplaceBinExprOp_24(883L, extract, null)), () => expectExtract)))
                {
                    // more details regarding which methods are missing have already been reported by regular resolution
                    var requiredMembers = expectExtract
                      ? MutateCSharp.Schemata424.ReplaceStringConstant_3(896L, "functions 'IsFailure()' and 'Extract()'"
          ) : MutateCSharp.Schemata424.ReplaceStringConstant_3(897L, "function 'IsFailure()', but not 'Extract()'");
                    ReportError(tok, $"The right-hand side of ':- {keyword}', which is of type '{failureSupportingType}', must have {requiredMembers}");
                }
            }
            else
            {
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_7(913L, () => MutateCSharp.Schemata424.ReplaceBinExprOp_7(900L, () => MutateCSharp.Schemata424.ReplaceBinExprOp_45(898L, isFailure, null), () => MutateCSharp.Schemata424.ReplaceBinExprOp_45(899L, propagateFailure, null)), () => MutateCSharp.Schemata424.ReplaceBinExprOp_52(907L, () => (MutateCSharp.Schemata424.ReplaceBinExprOp_24(906L, extract, null)), () => expectExtract)))
                {
                    // more details regarding which methods are missing have already been reported by regular resolution
                    var requiredMembers = expectExtract
                      ? MutateCSharp.Schemata424.ReplaceStringConstant_3(919L, "functions 'IsFailure()', 'PropagateFailure()', and 'Extract()'"
          ) : MutateCSharp.Schemata424.ReplaceStringConstant_3(920L, "functions 'IsFailure()' and 'PropagateFailure()', but not 'Extract()'");
                    ReportError(tok, $"The right-hand side of ':-', which is of type '{failureSupportingType}', must have {requiredMembers}");
                }
            }

            void CheckIsFunction([CanBeNull] MemberDecl memberDecl, bool allowMethod)
            {
                if (memberDecl is null or Function)
                {
                    // fine
                }
                else if (MutateCSharp.Schemata424.ReplaceBinExprOp_10(921L, () => allowMethod, () => memberDecl is Method))
                {
                    // give a deprecation warning, so we will remove this language feature around the Dafny 4 time frame
                    resolver.reporter.Deprecated(MessageSource.Resolver, ResolutionErrors.ErrorId.r_failure_methods_deprecated, tok,
                      $"Support for member '{memberDecl.Name}' in type '{failureSupportingType}' (used indirectly via a :- statement) being a method is deprecated;" +
          MutateCSharp.Schemata424.ReplaceStringConstant_3(927L, " declare it to be a function instead"));
                }
                else
                {
                    // not allowed
                    resolver.reporter.Error(MessageSource.Resolver, tok,
                      $"Member '{memberDecl.Name}' in type '{failureSupportingType}' (used indirectly via a :- statement) is expected to be a function");
                }
            }

            CheckIsFunction(isFailure, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(928L, false));
            if (keyword == null)
            {
                CheckIsFunction(propagateFailure, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(929L, true));
            }
            if (expectExtract)
            {
                CheckIsFunction(extract, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(930L, true));
            }
        }

        public void ResolveTypeRhs(TypeRhs rr, Statement stmt, ResolutionContext resolutionContext)
        {
            Contract.Requires(rr != null);
            Contract.Requires(stmt != null);
            Contract.Requires(resolutionContext != null);
            Contract.Ensures(Contract.Result<Type>() != null);

            if (MutateCSharp.Schemata424.ReplaceBinExprOp_42(931L, rr.PreType, null))
            {
                // the job's already been done
                return;
            }

            if (MutateCSharp.Schemata424.ReplaceBinExprOp_27(932L, rr.ArrayDimensions, null))
            {
                // ---------- new T[EE]    OR    new T[EE] (elementInit)
                var dims = rr.ArrayDimensions.Count;
                Contract.Assert(rr.Bindings == null && rr.Path == null && rr.InitCall == null);
                resolver.ResolveType(stmt.Tok, rr.EType, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                int i = MutateCSharp.Schemata424.ReplaceNumericConstant_12(933L, 0);
                foreach (var dim in rr.ArrayDimensions)
                {
                    ResolveExpression(dim, resolutionContext);
                    var indexHint = MutateCSharp.Schemata424.ReplaceBinExprOp_15(941L, dims, MutateCSharp.Schemata424.ReplaceNumericConstant_12(937L, 1)) ? "" : MutateCSharp.Schemata424.ReplaceStringConstant_3(946L, " for index ") + i;
                    AddConfirmation(PreTypeConstraints.CommonConfirmationBag.InIntFamily, dim.PreType, dim.tok,
                      $"new must use an integer-based expression for the array size (got {{0}}{indexHint})");
                    MutateCSharp.Schemata424.ReplacePostfixUnaryExprOp_22(947L, ref i);
                }
                rr.PreType = BuiltInArrayType(dims, Type2PreType(rr.EType));
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_25(948L, rr.ElementInit, null))
                {
                    ResolveExpression(rr.ElementInit, resolutionContext);
                    // Check (the pre-type version of)
                    //     nat^N -> rr.EType  :>  rr.ElementInit.Type
                    resolver.SystemModuleManager.CreateArrowTypeDecl(dims);  // TODO: should this be done already in the parser?
                    var indexPreTypes = Enumerable.Repeat(Type2PreType(resolver.SystemModuleManager.Nat()), dims).ToList();
                    var arrowPreType = BuiltInArrowType(indexPreTypes, Type2PreType(rr.EType));
                    Constraints.AddSubtypeConstraint(arrowPreType, rr.ElementInit.PreType, rr.ElementInit.tok, () =>
                    {
                        var hintString = !PreType.Same(arrowPreType, rr.ElementInit.PreType) ? "" :
                          string.Format(MutateCSharp.Schemata424.ReplaceStringConstant_3(949L, " (perhaps write '{0} =>' in front of the expression you gave in order to make it an arrow type)"),
            MutateCSharp.Schemata424.ReplaceBinExprOp_15(954L, dims, MutateCSharp.Schemata424.ReplaceNumericConstant_12(950L, 1)) ? MutateCSharp.Schemata424.ReplaceStringConstant_3(959L, "_") : MutateCSharp.Schemata424.ReplaceStringConstant_3(960L, "(") + Util.Comma(dims, x => MutateCSharp.Schemata424.ReplaceStringConstant_3(961L, "_")) + MutateCSharp.Schemata424.ReplaceStringConstant_3(962L, ")"));
                        return $"array-allocation initialization expression expected to have type '{{0}}' (instead got '{{1}}'){hintString}";
                    });
                }
                else if (MutateCSharp.Schemata424.ReplaceBinExprOp_27(963L, rr.InitDisplay, null))
                {
                    foreach (var v in rr.InitDisplay)
                    {
                        ResolveExpression(v, resolutionContext);
                        AddSubtypeConstraint(Type2PreType(rr.EType), v.PreType, v.tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(964L, "initial value must be assignable to array's elements (expected '{0}', got '{1}')"));
                    }
                }
            }
            else
            {
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_53(965L, rr.Bindings, null))
                {
                    resolver.ResolveType(stmt.Tok, rr.EType, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                    var cl = (rr.EType as UserDefinedType)?.ResolvedClass as NonNullTypeDecl;
                    if (MutateCSharp.Schemata424.ReplaceBinExprOp_10(973L, () => MutateCSharp.Schemata424.ReplaceBinExprOp_54(966L, cl, null), () => !(MutateCSharp.Schemata424.ReplaceBinExprOp_10(967L, () => rr.EType.IsTraitType, () => !rr.EType.NormalizeExpand().IsObjectQ))))
                    {
                        // life is good
                    }
                    else
                    {
                        ReportError(rr.tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(979L, "new can be applied only to class types (got {0})"), rr.EType);
                    }
                }
                else
                {
                    string initCallName = null;
                    IToken initCallTok = null;
                    // Resolve rr.Path and do one of three things:
                    // * If rr.Path denotes a type, then set EType,initCallName to rr.Path,"_ctor", which sets up a call to the anonymous constructor.
                    // * If the all-but-last components of rr.Path denote a type, then do EType,initCallName := allButLast(EType),last(EType)
                    // * Otherwise, report an error
                    var ret = resolver.ResolveTypeLenient(rr.Tok, rr.Path, resolutionContext,
                      new ModuleResolver.ResolveTypeOption(ResolveTypeOptionEnum.InferTypeProxies), null, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(980L, true));
                    if (MutateCSharp.Schemata424.ReplaceBinExprOp_55(981L, ret, null))
                    {
                        // The all-but-last components of rr.Path denote a type (namely, ret.ReplacementType).
                        rr.EType = ret.ReplacementType;
                        initCallName = ret.LastComponent.SuffixName;
                        initCallTok = ret.LastComponent.tok;
                    }
                    else
                    {
                        // Either rr.Path resolved correctly as a type or there was no way to drop a last component to make it into something that looked
                        // like a type.  In either case, set EType,initCallName to Path,"_ctor" and continue.
                        rr.EType = rr.Path;
                        initCallName = MutateCSharp.Schemata424.ReplaceStringConstant_3(982L, "_ctor");
                        initCallTok = rr.Tok;
                    }
                    var cl = (rr.EType as UserDefinedType)?.ResolvedClass as NonNullTypeDecl;
                    if (MutateCSharp.Schemata424.ReplaceBinExprOp_7(984L, () => MutateCSharp.Schemata424.ReplaceBinExprOp_56(983L, cl, null), () => rr.EType.IsTraitType))
                    {
                        ReportError(rr.tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(990L, "new can be applied only to class types (got {0})"), rr.EType);
                    }
                    else
                    {
                        // ---------- new C.Init(EE)
                        Contract.Assert(initCallName != null);
                        var prevErrorCount = ErrorCount;

                        // We want to create a MemberSelectExpr for the initializing method.  To do that, we create a throw-away receiver of the appropriate
                        // type, create a dot-suffix expression around this receiver, and then resolve it in the usual way for dot-suffix expressions.
                        // It is important that this throw-away receiver have its .PreType filled in, because the call to ResolveDotSuffix will recursive
                        // down to resolve this "lhs"; that's a no-op if the .PreType is already filled in, whereas it could cause a "'this' not allowed in
                        // static context" error if the code tried to resolve this "this" against the enclosing environment.
                        rr.PreType = Type2PreType(rr.EType);
                        var lhs = new ImplicitThisExpr_ConstructorCall(initCallTok)
                        {
                            Type = rr.EType,
                            PreType = rr.PreType
                        };
                        var callLhs = new ExprDotName(((UserDefinedType)rr.EType).tok, lhs, initCallName, ret?.LastComponent.OptTypeArguments);
                        ResolveDotSuffix(callLhs, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(991L, true), rr.Bindings.ArgumentBindings, resolutionContext, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(992L, true));
                        if (MutateCSharp.Schemata424.ReplaceBinExprOp_15(993L, prevErrorCount, ErrorCount))
                        {
                            Contract.Assert(callLhs.ResolvedExpression is MemberSelectExpr);  // since ResolveApplySuffix succeeded and call.Lhs denotes an expression (not a module or a type)
                            var methodSel = (MemberSelectExpr)callLhs.ResolvedExpression;
                            if (methodSel.Member is Method)
                            {
                                rr.InitCall = new CallStmt(stmt.RangeToken, new List<Expression>(), methodSel, rr.Bindings.ArgumentBindings, initCallTok);
                                ResolveCallStmt(rr.InitCall, resolutionContext, rr.EType);
                            }
                            else
                            {
                                ReportError(initCallTok, MutateCSharp.Schemata424.ReplaceStringConstant_3(998L, "object initialization must denote an initializing method or constructor ({0})"), initCallName);
                            }
                        }
                    }
                }
                // set rr.PreType, unless it was already set above
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_57(999L, rr.PreType, null))
                {
                    rr.PreType = Type2PreType(rr.EType);
                }
            }
        }

        /// <summary>
        /// Checks if lhs, which is expected to be a successfully resolved expression, denotes something
        /// that can be assigned to.  In particular, this means that lhs denotes a mutable variable, field,
        /// or array element.  If a violation is detected, an error is reported.
        /// </summary>
        public void CheckIsLvalue(Expression lhs, ResolutionContext resolutionContext)
        {
            Contract.Requires(lhs != null);
            Contract.Requires(resolutionContext != null);
            if (lhs is IdentifierExpr)
            {
                var ll = (IdentifierExpr)lhs;
                if (!ll.Var.IsMutable)
                {
                    ReportError(lhs, MutateCSharp.Schemata424.ReplaceStringConstant_3(1000L, "LHS of assignment must denote a mutable variable"));
                }
            }
            else if (lhs is MemberSelectExpr)
            {
                var ll = (MemberSelectExpr)lhs;
                var field = ll.Member as Field;
                if (MutateCSharp.Schemata424.ReplaceBinExprOp_7(1002L, () => MutateCSharp.Schemata424.ReplaceBinExprOp_58(1001L, field, null), () => !field.IsUserMutable))
                {
                    var cf = field as ConstantField;
                    if (MutateCSharp.Schemata424.ReplaceBinExprOp_10(1022L, () => MutateCSharp.Schemata424.ReplaceBinExprOp_10(1015L, () => MutateCSharp.Schemata424.ReplaceBinExprOp_10(1009L, () => inBodyInitContext, () => MutateCSharp.Schemata424.ReplaceBinExprOp_59(1008L, cf, null)), () => !cf.IsStatic), () => MutateCSharp.Schemata424.ReplaceBinExprOp_49(1021L, cf.Rhs, null)))
                    {
                        if (MutateCSharp.Schemata424.ReplaceBinExprOp_48(1028L, Expression.AsThis(ll.Obj), null))
                        {
                            // it's cool; this field can be assigned to here
                        }
                        else
                        {
                            ReportError(lhs, MutateCSharp.Schemata424.ReplaceStringConstant_3(1029L, "LHS of assignment must denote a mutable field of 'this'"));
                        }
                    }
                    else
                    {
                        ReportError(lhs, MutateCSharp.Schemata424.ReplaceStringConstant_3(1030L, "LHS of assignment must denote a mutable field"));
                    }
                }
            }
            else if (lhs is SeqSelectExpr)
            {
                var ll = (SeqSelectExpr)lhs;
                var arrayType = resolver.ResolvedArrayType(ll.Seq.tok, MutateCSharp.Schemata424.ReplaceNumericConstant_12(1031L, 1), new InferredTypeProxy(), resolutionContext, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(1035L, true));
                AddSubtypeConstraint(Type2PreType(arrayType), ll.Seq.PreType, ll.Seq.tok, MutateCSharp.Schemata424.ReplaceStringConstant_3(1036L, "LHS of array assignment must denote an array element (found {1})"));
                if (!ll.SelectOne)
                {
                    ReportError(ll, MutateCSharp.Schemata424.ReplaceStringConstant_3(1037L, "cannot assign to a range of array elements (try the 'forall' statement)"));
                }
            }
            else if (lhs is MultiSelectExpr)
            {
                // nothing to check; this can only denote an array element
            }
            else
            {
                ReportError(lhs, MutateCSharp.Schemata424.ReplaceStringConstant_3(1038L, "LHS of assignment must denote a mutable variable or field"));
            }
        }

        void ResolveAlternatives(List<GuardedAlternative> alternatives, AlternativeLoopStmt loopToCatchBreaks, ResolutionContext resolutionContext)
        {
            Contract.Requires(alternatives != null);
            Contract.Requires(resolutionContext != null);

            // first, resolve the guards
            foreach (var alternative in alternatives)
            {
                ResolveExpression(alternative.Guard, resolutionContext);
                ConstrainExpressionToBoolFamily(alternative.Guard, MutateCSharp.Schemata424.ReplaceStringConstant_3(1039L, "condition is expected to be of type bool, but is {0}"));
            }

            if (MutateCSharp.Schemata424.ReplaceBinExprOp_60(1040L, loopToCatchBreaks, null))
            {
                loopStack.Add(loopToCatchBreaks);  // push
            }
            foreach (var alternative in alternatives)
            {
                scope.PushMarker();
                dominatingStatementLabels.PushMarker();
                if (alternative.IsBindingGuard)
                {
                    var exists = (ExistsExpr)alternative.Guard;
                    foreach (var v in exists.BoundVars)
                    {
                        ScopePushAndReport(v, MutateCSharp.Schemata424.ReplaceStringConstant_3(1041L, "bound-variable"), MutateCSharp.Schemata424.ReplaceBooleanConstant_0(1042L, false));
                    }
                }
                ResolveAttributes(alternative, resolutionContext, MutateCSharp.Schemata424.ReplaceBooleanConstant_0(1043L, false));
                foreach (Statement ss in alternative.Body)
                {
                    ResolveStatementWithLabels(ss, resolutionContext);
                }
                dominatingStatementLabels.PopMarker();
                scope.PopMarker();
            }
            if (MutateCSharp.Schemata424.ReplaceBinExprOp_60(1044L, loopToCatchBreaks, null))
            {
                loopStack.RemoveAt(MutateCSharp.Schemata424.ReplaceBinExprOp_16(1049L, loopStack.Count, MutateCSharp.Schemata424.ReplaceNumericConstant_12(1045L, 1)));  // pop
            }
        }
    }
}
