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
using System.Text.RegularExpressions;
using DafnyCore;
using JetBrains.Annotations;
using Tomlyn.Model;
using static Microsoft.Dafny.ConcreteSyntaxTreeUtils;
namespace MutateCSharp
{
    internal class Schemata233
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT233");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static ulong ReplaceBinExprOp_41(long mutantId, ulong argument1, ulong argument2)
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

        internal static bool ReplaceBinExprOp_44(long mutantId, Microsoft.Dafny.NativeType.Selection argument1, Microsoft.Dafny.NativeType.Selection argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_47(long mutantId, Microsoft.Dafny.UnaryOpExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, Microsoft.Dafny.NativeType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_38(long mutantId, System.Numerics.BigInteger argument1, long argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 <= argument2;
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

        internal static ulong ReplaceNumericConstant_39(long mutantId, ulong argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 2)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return 0; }
            return argument1;
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

        internal static int ReplaceBinExprOp_18(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.DatatypeCtor argument1, Microsoft.Dafny.DatatypeCtor argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceBinExprOp_33(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_36(long mutantId, System.Collections.Generic.Dictionary<Microsoft.Dafny.TypeParameter, Microsoft.Dafny.Type> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_28(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Type> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, Microsoft.Dafny.SubsetTypeDecl.WKind argument1, Microsoft.Dafny.SubsetTypeDecl.WKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_27(long mutantId, Microsoft.Dafny.TopLevelDeclWithMembers argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, string argument1, string argument2)
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

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_34(long mutantId, Microsoft.Dafny.TopLevelDeclWithMembers argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_35(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Formal> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_14(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, Microsoft.Dafny.Function argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_37(long mutantId, long argument1, System.Numerics.BigInteger argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_23(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_46(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_32(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 >= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 > argument2; }
            return argument1 >= argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_29(long mutantId, Microsoft.Dafny.NewtypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.TypeParameter> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, Microsoft.Dafny.NativeType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_51(long mutantId, Microsoft.Dafny.Function argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_26(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Formal> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_43(long mutantId, Microsoft.Dafny.SpecialField.ID argument1, Microsoft.Dafny.SpecialField.ID argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_42(long mutantId, Microsoft.Dafny.Compilers.DatatypeWrapperEraser.MemberCompileStatus argument1, Microsoft.Dafny.Compilers.DatatypeWrapperEraser.MemberCompileStatus argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_24(long mutantId, Microsoft.Dafny.ConcreteSyntaxTree argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_25(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static ulong ReplaceBinExprOp_40(long mutantId, ulong argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 >> argument2; }
            return argument1 << argument2;
        }

        internal static bool ReplaceBinExprOp_50(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_31(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_49(long mutantId, Microsoft.Dafny.MemberSelectExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_45(long mutantId, Microsoft.Dafny.SeqType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.Method argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_7(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_48(long mutantId, Microsoft.Dafny.UnaryOpExpr.Opcode argument1, Microsoft.Dafny.UnaryOpExpr.Opcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny.Compilers
{
    public class GoCodeGenerator : SinglePassCodeGenerator
    {
        //TODO: This is tentative, update this to point to public module once available.
        private string DafnyRuntimeGoModule = MutateCSharp.Schemata233.ReplaceStringConstant_0(1L, "github.com/dafny-lang/DafnyRuntimeGo/");

        private bool GoModuleMode;
        private string GoModuleName;
        public GoCodeGenerator(DafnyOptions options, ErrorReporter reporter) : base(options, reporter)
        {
            var goModuleName = Options.Get(GoBackend.GoModuleNameCliOption);
            GoModuleMode = goModuleName != null;
            if (GoModuleMode)
            {
                GoModuleName = goModuleName.ToString();
            }
            if (Options?.CoverageLegendFile != null)
            {
                //TODO: What's the module name for this?
                Imports.Add(new Import { Name = MutateCSharp.Schemata233.ReplaceStringConstant_0(2L, "DafnyProfiling"), Path = MutateCSharp.Schemata233.ReplaceStringConstant_0(3L, "DafnyProfiling") });
            }
        }

        public override IReadOnlySet<Feature> UnsupportedFeatures => new HashSet<Feature> {
      Feature.MethodSynthesis,
      Feature.ExternalConstructors,
      Feature.SubsetTypeTests,
      Feature.AllUnderscoreExternalModuleNames,
      Feature.RuntimeCoverageReport
    };

        public override string ModuleSeparator => MutateCSharp.Schemata233.ReplaceStringConstant_0(4L, "_");
        protected override string IsMethodName => MutateCSharp.Schemata233.ReplaceStringConstant_0(5L, "Is_");

        string FormatDefaultTypeParameterValue(TopLevelDecl tp)
        {
            Contract.Requires(tp is TypeParameter || tp is AbstractTypeDecl);
            return $"_default_{tp.GetCompileName(Options)}";
        }

        private readonly List<Import> Imports = new(StandardImports);
        private string ModuleName;
        private ConcreteSyntaxTree RootImportWriter;
        private ConcreteSyntaxTree RootImportDummyWriter;

        private string MainModuleName;
        private static List<Import> StandardImports =
          new List<Import> {
        new Import { Name = MutateCSharp.Schemata233.ReplaceStringConstant_0(6L, "os"), Path = MutateCSharp.Schemata233.ReplaceStringConstant_0(7L, "os") },
          };
        private static string DummyTypeName = MutateCSharp.Schemata233.ReplaceStringConstant_0(8L, "Dummy__");

        public struct Import
        {
            public string Name, Path;
            public ModuleDefinition ExternModule;
        }

        protected override void EmitHeader(Program program, ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(9L, "// Dafny program {0} compiled into Go"), program.Name);

            ModuleName = MainModuleName = MutateCSharp.Schemata233.ReplaceBinExprOp_1(10L, program.MainMethod, null) ? MutateCSharp.Schemata233.ReplaceStringConstant_0(11L, "main") : TransformToClassName(Path.GetFileNameWithoutExtension(program.Name));

            wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(12L, "package {0}"), ModuleName);
            wr.WriteLine();

            string path;
            if (Options.IncludeRuntime)
            {
                EmitRuntimeSource(MutateCSharp.Schemata233.ReplaceStringConstant_0(13L, "DafnyRuntimeGo"), wr);
                path = GoModuleMode ? GoModuleName + MutateCSharp.Schemata233.ReplaceStringConstant_0(14L, "/") : "";
            }
            else
            {
                path = GoModuleMode ? DafnyRuntimeGoModule : "";
            }
            Imports.Add(new Import { Name = MutateCSharp.Schemata233.ReplaceStringConstant_0(15L, "_dafny"), Path = $"{path}dafny" });

            if (Options.Get(CommonOptionBag.UseStandardLibraries))
            {
                EmitRuntimeSource(MutateCSharp.Schemata233.ReplaceStringConstant_0(16L, "DafnyStandardLibraries_go"), wr);
            }

            // Keep the import writers so that we can import subsequent modules into the main one
            EmitImports(wr, out RootImportWriter, out RootImportDummyWriter);
        }

        private string DafnyTypeDescriptor => $"{HelperModulePrefix}TypeDescriptor";

        // The implementation of seq<T> is now in DafnyRuntimeDafny/src/dafnyRuntime.dfy.
        // We have to special-case compiling this code a little bit in places to work around
        // features Dafny doesn't support, such as customizing the definition of equality.
        private bool IsDafnySequence(TopLevelDecl d) => MutateCSharp.Schemata233.ReplaceBinExprOp_3(19L, () => Options.Get(DeveloperOptionBag.Bootstrapping), () => MutateCSharp.Schemata233.ReplaceBinExprOp_2(18L, d.GetFullCompileName(Options), MutateCSharp.Schemata233.ReplaceStringConstant_0(17L, "dafny.Sequence")));

        private string DafnySequenceCompanion => $"{HelperModulePrefix}Companion_Sequence_";

        void EmitModuleHeader(ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(25L, "// Package {0}"), ModuleName);
            wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(26L, "// Dafny module {0} compiled into Go"), ModuleName);
            wr.WriteLine();
            wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(27L, "package {0}"), ModuleName);
            wr.WriteLine();
            // This is a non-main module; it only imports things declared before it, so we don't need these writers
            EmitImports(wr, out _, out _);
            wr.WriteLine();
            wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(28L, "type {0} struct{{}}"), DummyTypeName);
            wr.WriteLine();
        }

        void EmitImports(ConcreteSyntaxTree wr, out ConcreteSyntaxTree importWriter, out ConcreteSyntaxTree importDummyWriter)
        {
            wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(29L, "import ("));
            importWriter = wr.Fork(MutateCSharp.Schemata233.ReplaceNumericConstant_4(30L, 1));
            wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(34L, ")"));
            importDummyWriter = wr.Fork();
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_5(36L, ModuleName, MutateCSharp.Schemata233.ReplaceStringConstant_0(35L, "dafny")))
            {
                foreach (var import in Imports)
                {
                    EmitImport(import, importWriter, importDummyWriter);
                }
            }
        }

        public string TransformToClassName(string baseName) =>
          IdProtect(Regex.Replace(baseName, MutateCSharp.Schemata233.ReplaceStringConstant_0(37L, "[^_A-Za-z0-9$]"), MutateCSharp.Schemata233.ReplaceStringConstant_0(38L, "_")));

        public override void EmitCallToMain(Method mainMethod, string baseName, ConcreteSyntaxTree wr)
        {
            var companion = TypeName_Companion(UserDefinedType.FromTopLevelDeclWithAllBooleanTypeParameters(mainMethod.EnclosingClass), wr, mainMethod.tok, mainMethod);

            var wBody = wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(39L, "func main()"));
            wBody.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(40L, "defer _dafny.CatchHalt()"));

            var idName = IssueCreateStaticMain(mainMethod) ? MutateCSharp.Schemata233.ReplaceStringConstant_0(41L, "Main") : IdName(mainMethod);

            Coverage.EmitSetup(wBody);
            wBody.WriteLine($"{companion}.{idName}({GetHelperModuleName()}.{CharMethodQualifier}FromMainArguments(os.Args))");
            Coverage.EmitTearDown(wBody);
        }

        ConcreteSyntaxTree CreateDescribedSection(string desc, ConcreteSyntaxTree wr, params object[] args)
        {
            var body = wr.Fork();
            var str = string.Format(desc, args);
            body.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(42L, "// Definition of {0}"), str);
            wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(43L, "// End of {0}"), str);
            return body;
        }

        protected override ConcreteSyntaxTree CreateStaticMain(IClassWriter cw, string argsParameterName)
        {
            var wr = ((GoCodeGenerator.ClassWriter)cw).ConcreteMethodWriter;
            return wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(44L, "func (_this * {0}) Main({1} _dafny.Sequence)"), FormatCompanionTypeName(((GoCodeGenerator.ClassWriter)cw).ClassName), argsParameterName);
        }

        private Import CreateImport(string moduleName, bool isDefault, ModuleDefinition externModule, string /*?*/ libraryName)
        {
            string pkgName;
            if (libraryName != null)
            {
                pkgName = libraryName;
            }
            else
            {
                // Go ignores all filenames starting with underscores.  So we're forced
                // to rewrite "__default" to "default__".
                pkgName = moduleName;
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(51L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_5(45L, pkgName, ""), () => pkgName.All(c => MutateCSharp.Schemata233.ReplaceBinExprOp_6(46L, c, '_'))))
                {
                    throw new UnsupportedFeatureException(Token.NoToken, Feature.AllUnderscoreExternalModuleNames,
                      $"Cannot have a package name with only underscores: {pkgName}");
                }
                while (pkgName.StartsWith(MutateCSharp.Schemata233.ReplaceStringConstant_0(57L, "_")))
                {
                    pkgName = pkgName.Substring(MutateCSharp.Schemata233.ReplaceNumericConstant_4(58L, 1)) + MutateCSharp.Schemata233.ReplaceStringConstant_0(62L, "_");
                }
            }


            return new Import { Name = moduleName, Path = pkgName, ExternModule = externModule };
        }

        protected override ConcreteSyntaxTree CreateModule(string moduleName, bool isDefault,
          ModuleDefinition externModule,
          string libraryName /*?*/, ConcreteSyntaxTree wr)
        {
            if (isDefault)
            {
                // Fold the default module into the main module
                return wr;
            }

            var goModuleName = GoModuleMode ? GoModuleName + MutateCSharp.Schemata233.ReplaceStringConstant_0(63L, "/") : "";
            if (moduleName.Equals(MutateCSharp.Schemata233.ReplaceStringConstant_0(64L, "_System")))
            {
                if (Options.IncludeRuntime)
                {
                    goModuleName = GoModuleMode ? GoModuleName + MutateCSharp.Schemata233.ReplaceStringConstant_0(65L, "/") : "";
                }
                else
                {
                    goModuleName = GoModuleMode ? DafnyRuntimeGoModule : "";
                }
            }
            ModuleName = PublicModuleIdProtect(moduleName);
            var import = CreateImport(ModuleName, isDefault, externModule, libraryName);
            var filename = string.Format(MutateCSharp.Schemata233.ReplaceStringConstant_0(66L, "{0}/{0}.go"), import.Path);
            var w = wr.NewFile(filename);
            EmitModuleHeader(w);

            import.Path = goModuleName + import.Path;
            AddImport(import);

            return w;
        }

        protected override void DependOnModule(Program program, ModuleDefinition module, ModuleDefinition externModule,
          string libraryName)
        {
            var goModuleName = "";
            if (GoModuleMode)
            {
                // "_System" module has a special handling because although it gets translated from a Dafny module,
                // it is still part of the Dafny Runtime lib so has no associated go module name. It either uses the
                // project module name if embedded or falls back to the Runtime module name.
                if (module.GetCompileName(Options).Equals(MutateCSharp.Schemata233.ReplaceStringConstant_0(67L, "_System")))
                {
                    if (Options.IncludeRuntime)
                    {
                        goModuleName = GoModuleName + MutateCSharp.Schemata233.ReplaceStringConstant_0(68L, "/");
                    }
                    else
                    {
                        goModuleName = DafnyRuntimeGoModule;
                    }
                }
                else
                {
                    // For every other Dafny Module, fetch the associated go module name from the dtr structure.
                    var translatedRecord = program.Compilation.AlreadyTranslatedRecord;
                    translatedRecord.OptionsByModule.TryGetValue(module.FullDafnyName, out var moduleOptions);
                    object moduleName = null;
                    moduleOptions?.TryGetValue(GoBackend.GoModuleNameCliOption.Name, out moduleName);

                    goModuleName = moduleName is string name ? moduleName + MutateCSharp.Schemata233.ReplaceStringConstant_0(69L, "/") : "";
                    if (String.IsNullOrEmpty(goModuleName))
                    {
                        Reporter.Warning(MessageSource.Compiler, ResolutionErrors.ErrorId.none, Token.Cli,
                          $"Go Module Name not found for the module {module.GetCompileName(Options)}");
                    }
                }
            }

            var import = CreateImport(module.GetCompileName(Options), module.IsDefaultModule, externModule, libraryName);
            import.Path = goModuleName + import.Path;
            AddImport(import);
        }

        protected override void FinishModule()
        {
            ModuleName = MainModuleName;
        }

        private void AddImport(Import import)
        {
            // Import in root module
            EmitImport(import, RootImportWriter, RootImportDummyWriter);
            // Import in all subsequent modules
            Imports.Add(import);
        }

        private void EmitImport(Import import, ConcreteSyntaxTree importWriter, ConcreteSyntaxTree importDummyWriter)
        {
            var id = IdProtect(import.Name);
            var path = import.Path;

            importWriter.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(70L, "{0} \"{1}\""), id, path);

            bool isType;
            string memberName = null;
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_2(72L, id, MutateCSharp.Schemata233.ReplaceStringConstant_0(71L, "os")))
            {
                memberName = MutateCSharp.Schemata233.ReplaceStringConstant_0(73L, "Args");
                isType = MutateCSharp.Schemata233.ReplaceBooleanConstant_7(74L, false);
            }
            else
            {
                isType = MutateCSharp.Schemata233.ReplaceBooleanConstant_7(75L, true);
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_8(76L, import.ExternModule, null))
                {
                    var attributes = Attributes.Find(import.ExternModule.Attributes, MutateCSharp.Schemata233.ReplaceStringConstant_0(77L, "dummyImportMember"));
                    if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(88L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_9(78L, attributes, null), () => MutateCSharp.Schemata233.ReplaceBinExprOp_6(83L, attributes.Args.Count, MutateCSharp.Schemata233.ReplaceNumericConstant_4(79L, 2))))
                    {
                        if (attributes.Args[0] is LiteralExpr expr1 && expr1.Value is string isNameValue &&
                          attributes.Args[1] is LiteralExpr expr2 && expr2.Value is bool isTypeValue)
                        {
                            memberName = isNameValue;
                            isType = isTypeValue;
                        }
                    }
                }
                else
                {
                    memberName = DummyTypeName;
                }
            }

            if (memberName != null)
            {
                if (isType)
                {
                    importDummyWriter.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(94L, "var _ {0}.{1}"), id, memberName);
                }
                else
                {
                    importDummyWriter.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(95L, "var _ = {0}.{1}"), id, memberName);
                }
            }
        }

        protected override string GetHelperModuleName() => MutateCSharp.Schemata233.ReplaceStringConstant_0(96L, "_dafny");

        private string HelperModulePrefix => MutateCSharp.Schemata233.ReplaceBinExprOp_2(98L, ModuleName, MutateCSharp.Schemata233.ReplaceStringConstant_0(97L, "dafny")) ? "" : $"{GetHelperModuleName()}.";

        protected override IClassWriter CreateClass(string moduleName, string name, bool isExtern, string/*?*/ fullPrintName,
          List<TypeParameter> typeParameters, TopLevelDecl cls, List<Type>/*?*/ superClasses, IToken tok, ConcreteSyntaxTree wr)
        {
            var isDefaultClass = cls is DefaultClassDecl;

            bool isSequence = superClasses.Any(superClass => superClass is UserDefinedType udt && IsDafnySequence(udt.ResolvedClass));
            return CreateClass(cls, name, isExtern, fullPrintName, typeParameters, superClasses, tok, wr, includeRtd: !isDefaultClass, includeEquals: !isSequence, includeString: !isSequence);
        }

        // TODO Consider splitting this into two functions; most things seem to be passing includeRtd: false, includeEquals: false and includeString: true.
        private GoCodeGenerator.ClassWriter CreateClass(TopLevelDecl classContext, string name, bool isExtern, string/*?*/ fullPrintName, List<TypeParameter>/*?*/ typeParameters, List<Type>/*?*/ superClasses, IToken tok, ConcreteSyntaxTree wr, bool includeRtd, bool includeEquals, bool includeString)
        {
            // See docs/Compilation/ReferenceTypes.md for a description of how instance members of classes and traits are compiled into Go.
            //
            // func New_Class_(Type0 _dafny.TypeDescriptor, Type1 _dafny.TypeDescriptor) *Class {
            //   _this := Class{}
            //
            //   // Have to do it this way because some default values (namely type
            //   // parameters) assume that _this points to the current value
            //   _this.Type0 = Type0
            //   _this.Type1 = Type1
            //   _this.Field0 = ...
            //   _this.Field1 = ...
            //   return &_this
            // }
            //
            // func (_this *Class) InstanceMethod(param0 type0, ...) returnType {
            //   ...
            // }
            //
            // func (_this *CompanionStruct_Class) StaticMethod(param0 type0, ...) returnType {
            //   ...
            // }
            //
            // func (*Class) String() string {
            //   return "module.Class"
            // }
            //
            // func Type_Class_(Type0 _dafny.TypeDescriptor, Type1 _dafny.TypeDescriptor) _dafny.TypeDescriptor {
            //   return type_Class_{Type0, Type1}
            // }
            //
            // type type_Class_ struct{
            //   Type0 _dafny.TypeDescriptor
            //   Type1 _dafny.TypeDescriptor
            // }
            //
            // func (_this type_Class_) Default() any {
            //   return (*Class)(nil)
            // }
            //
            // func (_this type_Class_) String() string {
            //   return "module.Class"
            // }
            //
            name = Capitalize(name);

            var w = CreateDescribedSection(MutateCSharp.Schemata233.ReplaceStringConstant_0(99L, "class {0}"), wr, name);

            var instanceFieldWriter = w.NewBlock(string.Format(MutateCSharp.Schemata233.ReplaceStringConstant_0(100L, "type {0} struct"), name));

            w.WriteLine();
            CreateInitializer(classContext, name, w, out var instanceFieldInitWriter, out var traitInitWriter, out var rtdParamWriter);

            var isNewtypeWithTraits = classContext is NewtypeDecl { ParentTraits: { Count: > 0 } };

            var rtdCount = MutateCSharp.Schemata233.ReplaceNumericConstant_4(101L, 0);
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_10(105L, typeParameters, null))
            {
                rtdCount = WriteRuntimeTypeDescriptorsFields(typeParameters, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(106L, false), instanceFieldWriter, instanceFieldInitWriter, rtdParamWriter);
            }
            if (isNewtypeWithTraits)
            {
                var udt = UserDefinedType.FromTopLevelDecl(classContext.tok, classContext);
                rtdParamWriter.Write($"value {TypeName(udt, rtdParamWriter, classContext.tok)}");
            }

            w.WriteLine();
            var staticFieldWriter = w.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(107L, "type {0} struct"), FormatCompanionTypeName(name));
            var staticFieldInitWriter = w.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(108L, "var {0} = {1}"), FormatCompanionName(name), FormatCompanionTypeName(name));

            if (includeEquals)
            {
                // This Equals() is so simple that we could just use == instead, but uniformity is good and it'll get inlined anyway.

                w.WriteLine();
                var wEquals = w.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(109L, "func (_this *{0}) Equals(other *{0}) bool"), name);
                wEquals.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(110L, "return _this == other"));

                w.WriteLine();
                var wEqualsGeneric = w.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(111L, "func (_this *{0}) EqualsGeneric(x interface{{}}) bool"), name);
                wEqualsGeneric.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(112L, "other, ok := x.(*{0})"), name);
                wEqualsGeneric.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(113L, "return ok && _this.Equals(other)"));
            }

            w.WriteLine();
            if (includeString)
            {
                if (isNewtypeWithTraits)
                {
                    var wString = w.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(114L, "func (_this *{0}) String() string"), name);
                    wString.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(115L, "return _dafny.String(_this._value)"));
                }
                else
                {
                    var wString = w.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(116L, "func (*{0}) String() string"), name);
                    // Be consistent with other back ends, which don't fold _module into the main module
                    var module = MutateCSharp.Schemata233.ReplaceBinExprOp_2(117L, ModuleName, MainModuleName) ? MutateCSharp.Schemata233.ReplaceStringConstant_0(118L, "_module") : ModuleName;
                    wString.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(119L, "return \"{0}.{1}\""), module, name);
                }
            }

            if (includeRtd)
            {
                CreateRTD(name, typeParameters, out var wDefault, w);

                wDefault.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(120L, "return (*{0})(nil)"), name);
            }

            var cw = new ClassWriter(this, classContext, MutateCSharp.Schemata233.ReplaceBinExprOp_11(121L, tok, null), name, isExtern, null, w, instanceFieldWriter, instanceFieldInitWriter, traitInitWriter, staticFieldWriter, staticFieldInitWriter);

            if (MutateCSharp.Schemata233.ReplaceBinExprOp_12(122L, superClasses, null))
            {
                superClasses = superClasses.Where(trait => !trait.IsObject).ToList();
                EmitParentTraits(tok, name, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(123L, true), superClasses, w);
            }
            return cw;
        }

        private void EmitParentTraits(IToken tok, string childName, bool childIsUsedAsPointer, List<Type> parentTraits, ConcreteSyntaxTree wr)
        {
            var star = childIsUsedAsPointer ? MutateCSharp.Schemata233.ReplaceStringConstant_0(124L, "*") : "";
            var addressOf = childIsUsedAsPointer ? MutateCSharp.Schemata233.ReplaceStringConstant_0(125L, "&") : "";
            // Emit a method that returns the ID of each parent trait
            var parentTraitsWriter = wr.NewBlock($"func (_this {star}{childName}) ParentTraits_() []*{HelperModulePrefix}TraitID");
            parentTraitsWriter.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(126L, "return [](*{0}TraitID){{{1}}};"), HelperModulePrefix, Util.Comma(parentTraits, parent =>
            {
                var trait = ((UserDefinedType)parent).ResolvedClass;
                return TypeName_Companion(trait, parentTraitsWriter, tok) + MutateCSharp.Schemata233.ReplaceStringConstant_0(127L, ".TraitID_");
            }));

            foreach (Type typ in parentTraits)
            {
                // Emit a compile-time sanity check that the class emitted does indeed have the methods required by the parent trait
                wr.WriteLine($"var _ {TypeName(typ, wr, tok)} = {addressOf}{childName}{{}}");
            }

            wr.WriteLine($"var _ {HelperModulePrefix}TraitOffspring = {addressOf}{childName}{{}}");

            wr.WriteLine();
        }

        protected override IClassWriter CreateTrait(string name, bool isExtern, List<TypeParameter> typeParameters /*?*/,
          TraitDecl trait, List<Type> superClasses /*?*/, IToken tok, ConcreteSyntaxTree wr)
        {
            //
            // type Trait interface {
            //   String() string
            //   AbstractMethod0(param0 type0, ...) returnType0
            //   ...
            // }
            //
            // type companionStruct_Trait_ struct {
            //   StaticField0 type0
            //   StaticField1 type1
            //   ...
            // }
            //
            // var Companion_Trait_ = companionStruct_Trait{
            //   StaticField0: ...,
            //   StaticField1: ...,
            // }
            //
            // func (_static *companionStruct_Trait) CastTo_(x any) Trait {
            //   var t Trait
            //   t, _ = x.(Trait)
            //   return t
            // }
            //
            // func (_static *companionStruct_Trait) ConcreteInstanceMethod(_this Trait, ...) ... {
            //   ...
            // }
            //
            // func (_static *companionStruct_Trait) StaticMethod(...) ... {
            //   ...
            // }
            wr = CreateDescribedSection(MutateCSharp.Schemata233.ReplaceStringConstant_0(128L, "trait {0}"), wr, name);
            var abstractMethodWriter = wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(129L, "type {0} interface"), name);
            var concreteMethodWriter = wr.Fork();
            abstractMethodWriter.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(130L, "String() string"));
            if (IsDafnySequence(trait))
            {
                abstractMethodWriter.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(131L, "Equals(other Sequence) bool"));
                abstractMethodWriter.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(132L, "EqualsGeneric(x interface{}) bool"));
                abstractMethodWriter.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(133L, "VerbatimString(isLiteral bool) string"));
            }

            var staticFieldWriter = wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(134L, "type {0} struct"), FormatCompanionTypeName(name));
            var staticFieldInitWriter = wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(135L, "var {0} = {1}"), FormatCompanionName(name), FormatCompanionTypeName(name));
            var wCastTo = wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(136L, "func ({0}) CastTo_(x interface{{}}) {1}"), FormatCompanionTypeName(name), name);
            wCastTo.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(137L, "var t {0}"), name);
            wCastTo.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(138L, "t, _ = x.({0})"), name);
            wCastTo.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(139L, "return t"));


            var cw = new ClassWriter(this, trait, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(140L, false), name, isExtern, abstractMethodWriter, concreteMethodWriter, null, null, null, staticFieldWriter, staticFieldInitWriter);
            staticFieldWriter.WriteLine($"TraitID_ *{HelperModulePrefix}TraitID");
            staticFieldInitWriter.WriteLine($"TraitID_: &{HelperModulePrefix}TraitID{{}},");
            return cw;
        }

        protected void CreateInitializer(TopLevelDecl classContext, string name, ConcreteSyntaxTree wr,
          out ConcreteSyntaxTree instanceFieldInitWriter, out ConcreteSyntaxTree traitInitWriter, out ConcreteSyntaxTree rtdParamWriter)
        {
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(141L, "func {0}("), FormatInitializerName(name));
            rtdParamWriter = wr.Fork();
            var w = wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(142L, ") *{0}"), name);
            var parameters = classContext is NewtypeDecl { ParentTraits: { Count: > 0 } } ? MutateCSharp.Schemata233.ReplaceStringConstant_0(143L, "value") : "";
            w.WriteLine($"_this := {name}{{{parameters}}}");

            w.WriteLine();
            instanceFieldInitWriter = w.Fork();
            traitInitWriter = w.Fork();
            w.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(144L, "return &_this"));
        }

        protected override bool SupportsProperties => MutateCSharp.Schemata233.ReplaceBooleanConstant_7(145L, false);

        protected override ConcreteSyntaxTree CreateIterator(IteratorDecl iter, ConcreteSyntaxTree wr)
        {
            // FIXME: There should be tests to make sure that the finalizer mechanism achieves what I hope it does, namely allowing the iterator's goroutine to be garbage-collected along with the iterator.
            //
            // type MyIteratorExample struct {
            //   cont chan<- struct{}
            //   yielded <-chan struct{}
            //
            //   // Fields
            // }
            //
            // func (_this * MyIteratorExample) Ctor__(/* params */) {
            //   _cont := make(chan struct{})
            //   _yielded := make(chan struct{})
            //   _this.cont = _cont
            //   _this.yielded = _yielded
            //   // assign params
            //
            //   go _this.run(_cont, _yielded)
            //
            //   _dafny.SetFinalizer(this_, func(_ MyIteratorExample) {
            //     close(_cont) // will cause the iterator to return and close _yielded
            //   })
            // }
            //
            // func (_this * MyIteratorExample) MoveNext() bool {
            //   _this.cont <- struct{}{}
            //   _, ok <- _this.yielded
            //
            //   return ok
            // }
            //
            // func (_this * MyIteratorExample) run(_cont <-chan struct{}, _yielded chan<- struct{}) {
            //   defer close(_yielded)
            //
            //   var _ok bool
            //   _, _ok = <- _cont
            //   if !_ok { return }
            //
            //   // Statements ... yield becomes:
            //   _yielded <- struct{}{}
            //   _, _ok = <- _cont
            //   if !_ok { return }
            //
            //   // break becomes:
            //   return
            // }()
            var cw = CreateClass(iter, IdName(iter), MutateCSharp.Schemata233.ReplaceBooleanConstant_7(146L, false), null, iter.TypeArgs, null, null, wr, includeRtd: MutateCSharp.Schemata233.ReplaceBooleanConstant_7(147L, false), includeEquals: MutateCSharp.Schemata233.ReplaceBooleanConstant_7(148L, false), includeString: MutateCSharp.Schemata233.ReplaceBooleanConstant_7(149L, true));

            cw.InstanceFieldWriter.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(150L, "cont chan<- struct{}"));
            cw.InstanceFieldWriter.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(151L, "yielded <-chan struct{}"));

            Constructor ct = null;
            foreach (var member in iter.Members)
            {
                if (member is Field f && !f.IsGhost)
                {
                    cw.DeclareField(IdName(f), iter, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(152L, false), MutateCSharp.Schemata233.ReplaceBooleanConstant_7(153L, false), f.Type, f.tok, PlaceboValue(f.Type, wr, f.tok, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(154L, true)), f);
                }
                else if (member is Constructor c)
                {
                    Contract.Assert(ct == null);
                    ct = c;
                }
            }
            Contract.Assert(ct != null);

            cw.ConcreteMethodWriter.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(155L, "func (_this * {0}) {1}("), IdName(iter), IdName(ct));
            string sep = "";
            foreach (var p in ct.Ins)
            {
                if (!p.IsGhost)
                {
                    // here we rely on the parameters and the corresponding fields having the same names
                    cw.ConcreteMethodWriter.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(156L, "{0}{1} {2}"), sep, IdName(p), TypeName(p.Type, wr, p.tok));
                    sep = MutateCSharp.Schemata233.ReplaceStringConstant_0(157L, ", ");
                }
            }
            var wCtor = cw.ConcreteMethodWriter.NewBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(158L, ")"));
            wCtor.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(159L, "_cont := make(chan struct{})"));
            wCtor.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(160L, "_yielded := make(chan struct{})"));
            wCtor.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(161L, "_this.cont = _cont"));
            wCtor.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(162L, "_this.yielded = _yielded"));
            wCtor.WriteLine();
            foreach (var p in ct.Ins)
            {
                if (!p.IsGhost)
                {
                    wCtor.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(163L, "_this.{0} = {1}"), Capitalize(IdName(p)), IdName(p));
                }
            }
            wCtor.WriteLine();
            wCtor.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(164L, "go _this.run(_cont, _yielded)"));
            wCtor.WriteLine();
            wCtor.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(165L, "_dafny.SetFinalizer(_this, func(_ * {0}) {{ close(_cont) }})"), IdName(iter));

            var wMoveNext = cw.ConcreteMethodWriter.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(166L, "func (_this * {0}) MoveNext() bool"), IdName(iter));
            wMoveNext.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(167L, "_this.cont <- struct{}{}"));
            wMoveNext.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(168L, "_, ok := <- _this.yielded"));
            wMoveNext.WriteLine();
            wMoveNext.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(169L, "return ok"));

            var wRun = cw.ConcreteMethodWriter.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(170L, "func (_this * {0}) run(_cont <-chan struct{{}}, _yielded chan<- struct{{}})"), IdName(iter));
            wRun.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(171L, "defer close(_yielded)"));
            wRun.WriteLine();
            wRun.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(172L, "_, _ok := <- _cont"));
            wRun.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(173L, "if !_ok { return }"));
            wRun.WriteLine();

            return wRun;
        }

        protected override IClassWriter/*?*/ DeclareDatatype(DatatypeDecl dt, ConcreteSyntaxTree wr)
        {
            // ===== For inductive datatypes:
            //
            // type Dt struct {
            //   Data_Dt_
            // }
            //
            // type Data_Dt_ interface {
            //   isDt()
            // }
            //
            // // For uniformity with co-datatypes
            // func (_this Dt) Get_() Data_Dt_ {
            //   return _this.Data_Dt_
            // }
            //
            // type CompanionStruct_Dt_ struct {}
            //
            // var Companion_Dt_ = CompanionStruct_Dt_ {}
            //
            // ...
            //
            // type Dt_Ctor0 struct {
            //   Field0 type0
            //   Field1 type1
            //   ...
            // }
            //
            // func (Dt_Ctor0) isDt() {}
            //
            // func (_ CompanionStruct_Dt_) CreateCtor0(field0 type0, field1 type1) Dt {
            //   return Dt{Dt_Ctor0{type0, type1}}
            // }
            //
            // func (_this Dt) IsCtor0() bool {
            //   _, ok := _this.Data_Dt_.(Dt_Ctor0)
            //   return ok
            // }
            //
            // type Dt_Ctor1 struct {
            //   ...
            // }
            //
            // ...
            //
            // func (_this Dt) DtorDtor0() (dtor0Type, bool) {
            //   return _this.Data_Dt_.(Dt_Ctor0).Field0
            // }
            //
            // func (_this Dt) DtorDtor1() (dtor1Type, bool) {
            //   switch data := _this.Data_Dt_.(type) {
            //   case Dt_Ctor0:
            //     return data.Field1
            //   default:
            //     return data.(Dt_Ctor1).Field0
            //   }
            // }
            //
            // func (_this Dt) String() { ... }
            //
            // func (_this Dt) EqualsGeneric(other any) bool { ... }
            //
            // func (CompanionStruct_Dt_) AllSingletonConstructors() _dafny.Iterator {
            //   i := -1
            //   return func() (any, bool) {
            //     i++
            //     switch i {
            //       case 0:
            //         return Companion_Dt_.Create_Ctor0(), true
            //       case 1:
            //         return Companion_Dt_.Create_Ctor1(), true
            //       ...
            //       default:
            //         return Dt{}, false
            //     }
            //   }
            // }
            //
            // func Type_Dt_(tyArg0 Type, tyArg1 Type, ...) _dafny.TypeDescriptor {
            //   return type_Dt_{tyArg0, tyArg1, ...}
            // }
            //
            // type type_Dt_ struct {
            //   tyArg0 Type
            //   tyArg1 Type
            // }
            //
            // func (ty type_Dt_) Default() any {
            //   tyArg0 := ty.tyArg0
            //   tyArg1 := ty.tyArg1
            //   return Companion_Dt_.Create_CtorK(...)
            // }
            //
            // func (ty type_Dt_) String() string {
            //   return "module.Dt"
            // }
            //
            // TODO Optimize record types
            //
            // ===== For co-inductive datatypes:
            //
            // type Dt struct {
            //   Iface_Dt_
            // }
            //
            // type Iface_Dt_ interface {
            //   Get_() Data_Dt_
            // }
            //
            // type lazyDt struct {
            //   value Iface_Dt_
            //   init func() Dt
            // }
            //
            // func (_this * lazyDt) Get_() *Iface_Dt {
            //   if _this.value == nil {
            //      _this.value = _this.init().Get_()
            //      _this.init = nil // allow GC of values in closure
            //   }
            //   return _this.value
            // }
            //
            // ...
            //
            // func (_ CompanionStruct_Dt_) LazyDt(f func() Dt) Dt {
            //   return Dt{*lazyDt{nil, f}}
            // }
            //
            // func (_ CompanionStruct_Dt_) CreateCtor0(field0 type0, field1 type1) Dt {
            //   return Dt{*Dt_Ctor0{type0, type1}}
            // }
            //
            // func (_this * Dt_Ctor0) Get_() Dt {
            //   return _this
            // }
            if (dt is TupleTypeDecl)
            {
                // Tuple types are declared once and for all in DafnyRuntime.go
                return null;
            }

            string name = Capitalize(dt.GetCompileName(Options));
            string companionTypeName = FormatCompanionTypeName(name);
            string dataName = FormatDatatypeInterfaceName(name);
            string ifaceName = FormatLazyInterfaceName(name);
            var simplifiedType = DatatypeWrapperEraser.SimplifyType(Options, UserDefinedType.FromTopLevelDecl(dt.tok, dt));
            var simplifiedTypeName = TypeName(simplifiedType, wr, dt.tok);

            string StructOfCtor(DatatypeCtor ctor)
            {
                return string.Format(MutateCSharp.Schemata233.ReplaceStringConstant_0(174L, "{0}{1}_{2}"), dt is CoDatatypeDecl ? MutateCSharp.Schemata233.ReplaceStringConstant_0(175L, "*") : "", name, ctor.GetCompileName(Options));
            }

            // from here on, write everything into the new block created here:
            wr = CreateDescribedSection(MutateCSharp.Schemata233.ReplaceStringConstant_0(176L, "{0} {1}"), wr, dt.WhatKind, name);

            if (dt is IndDatatypeDecl)
            {
                var wStruct = wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(177L, "type {0} struct"), name);
                WriteRuntimeTypeDescriptorsFields(dt.TypeArgs, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(178L, false), wStruct, null, null);
                wStruct.WriteLine(dataName);

                wr.WriteLine();
                var wGet = wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(179L, "func (_this {0}) Get_() {1}"), name, dataName);
                wGet.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(180L, "return _this.{0}"), dataName);
            }
            else
            {
                var wDt = wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(181L, "type {0} struct"), name);
                WriteRuntimeTypeDescriptorsFields(dt.TypeArgs, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(182L, false), wDt, null, null);
                wDt.WriteLine(ifaceName);

                wr.WriteLine();
                var wIface = wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(183L, "type {0} interface"), ifaceName);
                wIface.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(184L, "Get_() {0}"), dataName);

                wr.WriteLine();
                var wLazy = wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(185L, "type lazy_{0}_ struct"), name);
                wLazy.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(186L, "value {0}"), dataName);
                wLazy.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(187L, "init func() {0}"), name);

                wr.WriteLine();
                var wLazyGet = wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(188L, "func (_this *lazy_{0}_) Get_() {1}"), name, dataName);
                var wIf = wLazyGet.NewBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(189L, "if _this.value == nil"));
                wIf.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(190L, "_this.value = _this.init().Get_()"));
                wIf.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(191L, "_this.init = nil")); // allow GC of values in closure

                wLazyGet.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(192L, "return _this.value"));

                wr.WriteLine();
                var typeDescriptorCount = WriteRuntimeTypeDescriptorsFormals(dt.TypeArgs, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(193L, false), out var wrFormals, out var wrActuals);
                var sep = MutateCSharp.Schemata233.ReplaceBinExprOp_13(198L, typeDescriptorCount, MutateCSharp.Schemata233.ReplaceNumericConstant_4(194L, 0)) ? MutateCSharp.Schemata233.ReplaceStringConstant_0(203L, ", ") : "";
                var wLazyCreate = wr.NewNamedBlock($"func ({companionTypeName}) {FormatLazyConstructorName(name)}({wrFormals}{sep}f func () {name}) {name}");
                wLazyCreate.WriteLine($"return {name}{{{wrActuals}{sep}&lazy_{name}_{{nil, f}}}}");
            }

            {
                wr.WriteLine();
                var wIface = wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(204L, "type {0} interface"), dataName);
                wIface.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(205L, "is{0}()"), name);
            }

            wr.WriteLine();
            var staticFieldWriter = wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(206L, "type {0} struct"), companionTypeName);
            var staticFieldInitWriter = wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(207L, "var {0} = {1}"), FormatCompanionName(name), companionTypeName);

            string typeDescriptorDeclarations;
            string typeDescriptorUses;
            {
                WriteRuntimeTypeDescriptorsFormals(dt.TypeArgs, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(208L, false), out var wTypeDescriptorDeclarations, out var wTypeDescriptorUses);
                typeDescriptorDeclarations = wTypeDescriptorDeclarations.ToString();
                typeDescriptorUses = wTypeDescriptorUses.ToString();
            }

            foreach (var ctor in dt.Ctors.Where(ctor => !ctor.IsGhost))
            {
                var ctorStructName = name + MutateCSharp.Schemata233.ReplaceStringConstant_0(209L, "_") + ctor.GetCompileName(Options);
                wr.WriteLine();
                var wStruct = wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(210L, "type {0} struct"), ctorStructName);
                var k = MutateCSharp.Schemata233.ReplaceNumericConstant_4(211L, 0);
                foreach (var formal in ctor.Formals)
                {
                    if (!formal.IsGhost)
                    {
                        wStruct.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(215L, "{0} {1}"), DatatypeFieldName(formal, k), TypeName(formal.Type, wr, formal.Tok));
                        MutateCSharp.Schemata233.ReplacePostfixUnaryExprOp_14(216L, ref k);
                    }
                }

                wr.WriteLine();
                wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(217L, "func ({0}{1}) is{2}() {{}}"), dt is CoDatatypeDecl ? MutateCSharp.Schemata233.ReplaceStringConstant_0(218L, "*") : "", ctorStructName, name);
                wr.WriteLine();

                wr.Write($"func ({companionTypeName}) {FormatDatatypeConstructorName(ctor.GetCompileName(Options))}({typeDescriptorDeclarations}");
                var sep = MutateCSharp.Schemata233.ReplaceBinExprOp_15(223L, typeDescriptorDeclarations.Length, MutateCSharp.Schemata233.ReplaceNumericConstant_4(219L, 0)) ? MutateCSharp.Schemata233.ReplaceStringConstant_0(228L, ", ") : "";
                var argNames = new List<string>();
                k = MutateCSharp.Schemata233.ReplaceNumericConstant_4(229L, 0);
                foreach (var formal in ctor.Formals)
                {
                    if (!formal.IsGhost)
                    {
                        var formalName = DatatypeFieldName(formal, k);

                        wr.Write($"{sep}{formalName} {TypeName(formal.Type, wr, formal.Tok)}");

                        argNames.Add(formalName);
                        sep = MutateCSharp.Schemata233.ReplaceStringConstant_0(233L, ", ");
                        MutateCSharp.Schemata233.ReplacePostfixUnaryExprOp_14(234L, ref k);
                    }
                }
                var wCreateBody = wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(235L, ") {0}"), name);
                sep = MutateCSharp.Schemata233.ReplaceBinExprOp_15(240L, typeDescriptorDeclarations.Length, MutateCSharp.Schemata233.ReplaceNumericConstant_4(236L, 0)) ? MutateCSharp.Schemata233.ReplaceStringConstant_0(245L, ", ") : "";
                var co = dt is CoDatatypeDecl ? MutateCSharp.Schemata233.ReplaceStringConstant_0(246L, "&") : "";
                wCreateBody.WriteLine($"return {name}{{{typeDescriptorUses}{sep}{co}{ctorStructName}{{{Util.Comma(argNames)}}}}}");

                wr.WriteLine();
                var wCheck = wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(247L, "func (_this {0}) {1}() bool"), name, FormatDatatypeConstructorCheckName(ctor.GetCompileName(Options)));
                wCheck.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(248L, "_, ok := _this.Get_().({0})"), StructOfCtor(ctor));
                wCheck.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(249L, "return ok"));

                if (dt is CoDatatypeDecl)
                {
                    wr.WriteLine();
                    var wGet = wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(250L, "func (_this *{0}) Get_() {1}"), ctorStructName, dataName);
                    wGet.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(251L, "return _this"));
                }
            }

            /* func (_static CompanionStruct_Dt_) Default(_default_A any, _default_B any) Dt {
             *   return Dt{Dt_GroundingCtor{...}}
             * }
             */
            wr.WriteLine();
            wr.Write($"func ({companionTypeName}) Default({typeDescriptorDeclarations}");
            var usedParameters = UsedTypeParameters(dt);
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(270L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_15(256L, typeDescriptorDeclarations.Length, MutateCSharp.Schemata233.ReplaceNumericConstant_4(252L, 0)), () => MutateCSharp.Schemata233.ReplaceBinExprOp_15(265L, usedParameters.Count, MutateCSharp.Schemata233.ReplaceNumericConstant_4(261L, 0))))
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(276L, ", "));
            }
            wr.Write(usedParameters.Comma(tp => $"{FormatDefaultTypeParameterValue(tp)} interface{{}}"));
            {
                var wDefault = wr.NewBlock($") {simplifiedTypeName}");
                wDefault.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(277L, "return "));
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
                    var arguments = nonGhostFormals.Comma(f => DefaultValue(f.Type, wDefault, f.tok));
                    EmitDatatypeValue(dt, groundingCtor, dt is CoDatatypeDecl, typeDescriptorUses, arguments, wDefault);
                }
                wDefault.WriteLine();
            }

            if (dt.HasFinitePossibleValues)
            {
                wr.WriteLine();
                var wSingles = wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(278L, "func (_ {0}) AllSingletonConstructors() _dafny.Iterator"), companionTypeName);
                wSingles.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(279L, "i := -1"));
                wSingles = wSingles.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(280L, "return func() (interface{{}}, bool)"));
                wSingles.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(281L, "i++"));
                wSingles = wSingles.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(282L, "switch i"));
                var i = MutateCSharp.Schemata233.ReplaceNumericConstant_4(283L, 0);
                foreach (var ctor in dt.Ctors.Where(ctor => !ctor.IsGhost))
                {
                    wSingles.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(287L, "case {0}: return {1}.{2}(), true"), i, FormatCompanionName(name), FormatDatatypeConstructorName(ctor.GetCompileName(Options)));
                    MutateCSharp.Schemata233.ReplacePostfixUnaryExprOp_14(288L, ref i);
                }
                wSingles.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(289L, "default: return {0}{{}}, false"), name);
            }

            // destructors
            foreach (var ctor in dt.Ctors)
            {
                foreach (var dtor in ctor.Destructors.Where(dtor => MutateCSharp.Schemata233.ReplaceBinExprOp_16(294L, dtor.EnclosingCtors[MutateCSharp.Schemata233.ReplaceNumericConstant_4(290L, 0)], ctor)))
                {
                    var compiledConstructorCount = dtor.EnclosingCtors.Count(constructor => !constructor.IsGhost);
                    if (MutateCSharp.Schemata233.ReplaceBinExprOp_15(299L, compiledConstructorCount, MutateCSharp.Schemata233.ReplaceNumericConstant_4(295L, 0)))
                    {
                        var arg = dtor.CorrespondingFormals[MutateCSharp.Schemata233.ReplaceNumericConstant_4(304L, 0)];
                        if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(308L, () => !arg.IsGhost, () => arg.HasName))
                        {
                            wr.WriteLine();
                            var wDtor = wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(314L, "func (_this {0}) {1}() {2}"), name, FormatDatatypeDestructorName(arg.CompileName), TypeName(arg.Type, wr, arg.tok));
                            var n = dtor.EnclosingCtors.Count;
                            if (MutateCSharp.Schemata233.ReplaceBinExprOp_6(319L, n, MutateCSharp.Schemata233.ReplaceNumericConstant_4(315L, 1)))
                            {
                                wDtor.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(324L, "return _this.Get_().({0}).{1}"), StructOfCtor(dtor.EnclosingCtors[MutateCSharp.Schemata233.ReplaceNumericConstant_4(325L, 0)]), DatatypeFieldName(arg));
                            }
                            else
                            {
                                wDtor = wDtor.NewBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(329L, "switch data := _this.Get_().(type)"));
                                var compiledConstructorsProcessed = MutateCSharp.Schemata233.ReplaceNumericConstant_4(330L, 0);
                                for (var i = MutateCSharp.Schemata233.ReplaceNumericConstant_4(334L, 0); MutateCSharp.Schemata233.ReplaceBinExprOp_17(338L, i, n); MutateCSharp.Schemata233.ReplacePostfixUnaryExprOp_14(343L, ref i))
                                {
                                    var ctor_i = dtor.EnclosingCtors[i];
                                    Contract.Assert(arg.CompileName == dtor.CorrespondingFormals[i].CompileName);
                                    if (ctor_i.IsGhost)
                                    {
                                        continue;
                                    }
                                    if (MutateCSharp.Schemata233.ReplaceBinExprOp_17(357L, compiledConstructorsProcessed, MutateCSharp.Schemata233.ReplaceBinExprOp_18(348L, compiledConstructorCount, MutateCSharp.Schemata233.ReplaceNumericConstant_4(344L, 1))))
                                    {
                                        wDtor.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(362L, "case {0}: return data.{1}"), StructOfCtor(ctor_i), DatatypeFieldName(arg));
                                    }
                                    else
                                    {
                                        wDtor.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(363L, "default: return data.({0}).{1}"), StructOfCtor(ctor_i), DatatypeFieldName(arg));
                                    }

                                    MutateCSharp.Schemata233.ReplacePostfixUnaryExprOp_14(364L, ref compiledConstructorsProcessed);
                                }
                            }
                        }
                    }
                }
            }

            {
                // String() method
                wr.WriteLine();
                var w = wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(365L, "func (_this {0}) String() string"), name);
                // TODO Avoid switch if only one branch
                var needData = MutateCSharp.Schemata233.ReplaceBinExprOp_3(372L, () => dt is IndDatatypeDecl, () => dt.Ctors.Exists(ctor => MutateCSharp.Schemata233.ReplaceBinExprOp_3(366L, () => !ctor.IsGhost, () => ctor.Formals.Exists(arg => !arg.IsGhost))));
                w = w.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(378L, "switch {0}_this.Get_().(type)"), needData ? MutateCSharp.Schemata233.ReplaceStringConstant_0(379L, "data := ") : "");
                w.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(380L, "case nil: return \"null\""));
                foreach (var ctor in dt.Ctors.Where(ctor => !ctor.IsGhost))
                {
                    var wCase = w.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(381L, "case {0}:"), StructOfCtor(ctor));
                    var nm = (dt.EnclosingModuleDefinition.TryToAvoidName ? "" : dt.EnclosingModuleDefinition.Name + MutateCSharp.Schemata233.ReplaceStringConstant_0(382L, ".")) + dt.Name + MutateCSharp.Schemata233.ReplaceStringConstant_0(383L, ".") + ctor.Name;
                    if (dt is CoDatatypeDecl)
                    {
                        wCase.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(384L, "return \"{0}\""), nm);
                    }
                    else
                    {
                        wCase.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(385L, "return \"{0}\""), nm);
                        var sep = MutateCSharp.Schemata233.ReplaceStringConstant_0(386L, " + \"(\" + ");
                        var anyFormals = MutateCSharp.Schemata233.ReplaceBooleanConstant_7(387L, false);
                        var k = MutateCSharp.Schemata233.ReplaceNumericConstant_4(388L, 0);
                        foreach (var arg in ctor.Formals)
                        {
                            if (!arg.IsGhost)
                            {
                                anyFormals = MutateCSharp.Schemata233.ReplaceBooleanConstant_7(392L, true);
                                if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(393L, () => UnicodeCharEnabled, () => arg.Type.IsStringType))
                                {
                                    wCase.Write($"{sep}data.{DatatypeFieldName(arg, k)}.VerbatimString(true)");
                                }
                                else
                                {
                                    wCase.Write($"{sep}{HelperModulePrefix}String(data.{DatatypeFieldName(arg, k)})");
                                }

                                sep = MutateCSharp.Schemata233.ReplaceStringConstant_0(399L, " + \", \" + ");
                                MutateCSharp.Schemata233.ReplacePostfixUnaryExprOp_14(400L, ref k);
                            }
                        }
                        if (anyFormals)
                        {
                            wCase.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(401L, " + \")\""));
                        }
                        wCase.WriteLine();
                    }
                }
                var wDefault = w.NewBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(402L, "default:"));
                if (dt is CoDatatypeDecl)
                {
                    wDefault.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(403L, "return \"{0}.{1}.unexpected\""), dt.EnclosingModuleDefinition.GetCompileName(Options), dt.GetCompileName(Options));
                }
                else
                {
                    wDefault.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(404L, "return \"<unexpected>\""));
                }
            }

            // Equals method
            {
                wr.WriteLine();
                var wEquals = wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(405L, "func (_this {0}) Equals(other {0}) bool"), name);
                // TODO: Way to implement shortcut check for address equality?
                var needData1 = dt.Ctors.Exists(ctor => MutateCSharp.Schemata233.ReplaceBinExprOp_3(406L, () => !ctor.IsGhost, () => ctor.Formals.Exists(arg => !arg.IsGhost)));

                wEquals = wEquals.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(412L, "switch {0}_this.Get_().(type)"), needData1 ? MutateCSharp.Schemata233.ReplaceStringConstant_0(413L, "data1 := ") : "");
                foreach (var ctor in dt.Ctors.Where(ctor => !ctor.IsGhost))
                {
                    var wCase = wEquals.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(414L, "case {0}:"), StructOfCtor(ctor));

                    var needData2 = ctor.Formals.Exists(arg => !arg.IsGhost);

                    wCase.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(415L, "{0}, ok := other.Get_().({1})"), needData2 ? MutateCSharp.Schemata233.ReplaceStringConstant_0(416L, "data2") : MutateCSharp.Schemata233.ReplaceStringConstant_0(417L, "_"), StructOfCtor(ctor));
                    wCase.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(418L, "return ok"));
                    var k = MutateCSharp.Schemata233.ReplaceNumericConstant_4(419L, 0);
                    foreach (Formal arg in ctor.Formals)
                    {
                        if (!arg.IsGhost)
                        {
                            wCase.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(423L, " && "));
                            string nm = DatatypeFieldName(arg, k);
                            var eqType = DatatypeWrapperEraser.SimplifyType(Options, arg.Type);
                            if (IsDirectlyComparable(eqType))
                            {
                                wCase.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(424L, "data1.{0} == data2.{0}"), nm);
                            }
                            else if (IsOrderedByCmp(eqType))
                            {
                                wCase.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(425L, "data1.{0}.Cmp(data2.{0}) == 0"), nm);
                            }
                            else if (IsComparedByEquals(eqType))
                            {
                                wCase.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(426L, "data1.{0}.Equals(data2.{0})"), nm);
                            }
                            else
                            {
                                wCase.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(427L, "{0}AreEqual(data1.{1}, data2.{1})"), HelperModulePrefix, nm);
                            }

                            MutateCSharp.Schemata233.ReplacePostfixUnaryExprOp_14(428L, ref k);
                        }
                    }
                    wCase.WriteLine();
                }
                var wDefault = wEquals.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(429L, "default:"));
                wDefault.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(430L, "return false; // unexpected"));

                wr.WriteLine();
                var wEqualsGeneric = wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(431L, "func (_this {0}) EqualsGeneric(other interface{{}}) bool"), name);
                wEqualsGeneric.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(432L, "typed, ok := other.({0})"), name);
                wEqualsGeneric.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(433L, "return ok && _this.Equals(typed)"));
            }

            // RTD
            {
                var usedOrAutoInitTypeParams = UsedTypeParameters(dt, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(434L, true));
                CreateRTD(name, usedOrAutoInitTypeParams, out var wDefault, wr);
                WriteRuntimeTypeDescriptorsLocals(usedOrAutoInitTypeParams, wDefault);

                var usedTypeParams = UsedTypeParameters(dt);
                var sep = MutateCSharp.Schemata233.ReplaceBinExprOp_3(453L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_15(439L, typeDescriptorUses.Length, MutateCSharp.Schemata233.ReplaceNumericConstant_4(435L, 0)), () => MutateCSharp.Schemata233.ReplaceBinExprOp_15(448L, usedTypeParams.Count, MutateCSharp.Schemata233.ReplaceNumericConstant_4(444L, 0))) ? MutateCSharp.Schemata233.ReplaceStringConstant_0(459L, ", ") : "";
                var arguments = usedTypeParams.Comma(tp => DefaultValue(new UserDefinedType(tp), wDefault, dt.tok, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(460L, true)));
                wDefault.WriteLine($"return {TypeName_Companion(dt, wr, dt.tok)}.Default({typeDescriptorUses}{sep}{arguments});");
            }

            EmitParentTraits(dt.tok, name, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(461L, false), dt.ParentTraits, wr);

            return new ClassWriter(this, dt, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(462L, false), name, dt.IsExtern(Options, out _, out _), null,
              wr, wr, wr, wr, staticFieldWriter, staticFieldInitWriter);
        }

        protected override IClassWriter DeclareNewtype(NewtypeDecl nt, ConcreteSyntaxTree wr)
        {
            var cw = CreateClass(nt, IdName(nt), MutateCSharp.Schemata233.ReplaceBooleanConstant_7(463L, false), null, nt.TypeArgs,
              nt.ParentTypeInformation.UniqueParentTraits(), null, wr, includeRtd: MutateCSharp.Schemata233.ReplaceBooleanConstant_7(464L, false), includeEquals: MutateCSharp.Schemata233.ReplaceBooleanConstant_7(465L, false), includeString: MutateCSharp.Schemata233.ReplaceBooleanConstant_7(466L, true));
            var w = cw.ConcreteMethodWriter;
            var nativeType = MutateCSharp.Schemata233.ReplaceBinExprOp_19(467L, nt.NativeType, null) ? GetNativeTypeName(nt.NativeType) : null;
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_19(468L, nt.NativeType, null))
            {
                var intType = $"{HelperModulePrefix}Int";
                var wIntegerRangeBody = w.NewNamedBlock($"func (_this *{FormatCompanionTypeName(IdName(nt))}) IntegerRange(lo {intType}, hi {intType}) {HelperModulePrefix}Iterator");
                wIntegerRangeBody.WriteLine($"iter := {HelperModulePrefix}IntegerRange(lo, hi)");
                var wIterFuncBody = wIntegerRangeBody.NewBlock($"return func() ({AnyType}, bool)");
                wIterFuncBody.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(469L, "next, ok := iter()"));
                wIterFuncBody.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(470L, "if !ok {{ return {0}(0), false }}"), nativeType);
                wIterFuncBody.WriteLine($"return next.({intType}).{Capitalize(nativeType)}(), true");
            }
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_20(471L, nt.WitnessKind, SubsetTypeDecl.WKind.Compiled))
            {
                var retType = nativeType ?? TypeName(nt.BaseType, w, nt.tok);
                var wWitness = w.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(472L, "func (_this *{0}) Witness() {1}"), FormatCompanionTypeName(IdName(nt)), retType);
                var wStmts = wWitness.Fork();
                wWitness.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(473L, "return "));
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_21(474L, nt.NativeType, null))
                {
                    wWitness.Append(Expr(nt.Witness, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(475L, false), wStmts));
                    wWitness.WriteLine();
                }
                else
                {
                    TrParenExpr(nt.Witness, wWitness, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(476L, false), wStmts);
                    wWitness.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(477L, ".{0}()"), Capitalize(GetNativeTypeName(nt.NativeType)));
                }
            }

            var udt = UserDefinedType.FromTopLevelDecl(nt.tok, nt);
            // RTD
            {
                CreateRTD(IdName(nt), nt.TypeArgs, out var wDefaultBody, wr);
                WriteRuntimeTypeDescriptorsLocals(nt.TypeArgs, wDefaultBody);
                var d = DefaultValue(udt, wr, nt.tok, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(478L, true));
                wDefaultBody.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(479L, "return {0}"), d);
            }

            GenerateIsMethod(nt, wr);

            if (MutateCSharp.Schemata233.ReplaceBinExprOp_15(484L, nt.ParentTraits.Count, MutateCSharp.Schemata233.ReplaceNumericConstant_4(480L, 0)))
            {
                cw.InstanceFieldWriter.WriteLine($"_value {TypeName(udt, cw.InstanceFieldWriter, nt.tok)}");
            }

            return cw;
        }

        protected override void DeclareSubsetType(SubsetTypeDecl sst, ConcreteSyntaxTree wr)
        {
            var cw = CreateClass(sst, IdName(sst), MutateCSharp.Schemata233.ReplaceBooleanConstant_7(489L, false), null, sst.TypeArgs, null, null, wr, includeRtd: MutateCSharp.Schemata233.ReplaceBooleanConstant_7(490L, false), includeEquals: MutateCSharp.Schemata233.ReplaceBooleanConstant_7(491L, false), includeString: MutateCSharp.Schemata233.ReplaceBooleanConstant_7(492L, true));
            var w = cw.ConcreteMethodWriter;
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_20(493L, sst.WitnessKind, SubsetTypeDecl.WKind.Compiled))
            {
                var witness = new ConcreteSyntaxTree(w.RelativeIndentLevel);
                var wStmts = w.Fork();
                witness.Append(Expr(sst.Witness, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(494L, false), wStmts));
                DeclareField(MutateCSharp.Schemata233.ReplaceStringConstant_0(495L, "Witness"), MutateCSharp.Schemata233.ReplaceBooleanConstant_7(496L, false), MutateCSharp.Schemata233.ReplaceBooleanConstant_7(497L, true), MutateCSharp.Schemata233.ReplaceBooleanConstant_7(498L, true), sst.Rhs, sst.tok, witness.ToString(), cw.ClassName, cw.StaticFieldWriter, cw.StaticFieldInitWriter, cw.ConcreteMethodWriter);
            }
            // RTD
            {
                CreateRTD(IdName(sst), sst.TypeArgs, out var wDefaultBody, wr);
                WriteRuntimeTypeDescriptorsLocals(sst.TypeArgs, wDefaultBody);
                var udt = UserDefinedType.FromTopLevelDecl(sst.tok, sst);
                var d = DefaultValue(udt, wr, sst.tok, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(499L, true));
                wDefaultBody.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(500L, "return {0}"), d);
            }

            GenerateIsMethod(sst, wr);
        }

        private void CreateRTD(string typeName, List<TypeParameter> usedParams, out ConcreteSyntaxTree wDefaultBody, ConcreteSyntaxTree wr)
        {
            Contract.Requires(typeName != null);
            Contract.Requires(usedParams != null);
            Contract.Requires(wr != null);
            Contract.Ensures(Contract.ValueAtReturn(out wDefaultBody) != null);

            wr.WriteLine();
            wr.Write($"func {FormatRTDName(typeName)}(");
            WriteRuntimeTypeDescriptorsFormals(usedParams, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(501L, true), out var wrFormals, out _);
            wr.Append(wrFormals);
            var wTypeMethod = wr.NewBlock($") {DafnyTypeDescriptor}");
            wTypeMethod.WriteLine($"return type_{typeName}_{{{usedParams.Comma(tp => FormatRTDName(tp.GetCompileName(Options)))}}}");

            wr.WriteLine();
            var wType = wr.NewNamedBlock($"type type_{typeName}_ struct");
            WriteRuntimeTypeDescriptorsFields(usedParams, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(502L, true), wType, null, null);

            wr.WriteLine();
            wDefaultBody = wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(503L, "func (_this type_{0}_) Default() interface{{}}"), typeName);

            wr.WriteLine();
            var wString = wr.NewNamedBlock($"func (_this type_{typeName}_) String() string");
            wString.WriteLine($"return \"{ModuleName}.{typeName}\"");
        }

        void GenerateIsMethod(RedirectingTypeDecl declWithConstraints, ConcreteSyntaxTree wr)
        {
            Contract.Requires(declWithConstraints is SubsetTypeDecl or NewtypeDecl);

            if (declWithConstraints.ConstraintIsCompilable)
            {
                var type = UserDefinedType.FromTopLevelDecl(declWithConstraints.tok, (TopLevelDecl)declWithConstraints);

                wr.Write($"func (_this *{FormatCompanionTypeName(IdName((TopLevelDecl)declWithConstraints))}) Is_(");

                var count = WriteRuntimeTypeDescriptorsFormals(declWithConstraints.TypeArgs, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(504L, false), out var wrFormals, out _);
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_15(509L, count, MutateCSharp.Schemata233.ReplaceNumericConstant_4(505L, 0)))
                {
                    wr.Write($"{wrFormals}, ");
                }

                var sourceFormal = new Formal(declWithConstraints.tok, MutateCSharp.Schemata233.ReplaceStringConstant_0(514L, "_source"), type, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(515L, true), MutateCSharp.Schemata233.ReplaceBooleanConstant_7(516L, false), null);
                var typeName = TypeName(type, wr, declWithConstraints.tok);
                var wrBody = wr.NewBlock($"{IdName(sourceFormal)} {typeName}) bool");
                GenerateIsMethodBody(declWithConstraints, sourceFormal, wrBody);
            }
        }

        protected override void GetNativeInfo(NativeType.Selection sel, out string name, out string literalSuffix, out bool needsCastAfterArithmetic)
        {
            literalSuffix = "";
            needsCastAfterArithmetic = MutateCSharp.Schemata233.ReplaceBooleanConstant_7(517L, false);
            switch (sel)
            {
                case NativeType.Selection.Byte:
                    name = "uint8";
                    break;
                    break;
                case NativeType.Selection.SByte:
                    name = "int8";
                    break;
                    break;
                case NativeType.Selection.UShort:
                    name = "uint16";
                    break;
                    break;
                case NativeType.Selection.Short:
                    name = "int16";
                    break;
                    break;
                case NativeType.Selection.UInt:
                    name = "uint32";
                    break;
                    break;
                case NativeType.Selection.Int:
                    name = "int32";
                    break;
                    break;
                case NativeType.Selection.ULong:
                    name = "uint64";
                    break;
                    break;
                case NativeType.Selection.Long:
                    name = "int64";
                    break;
                    break;
                default:
                    Contract.Assert(false);  // unexpected native type
                    throw new cce.UnreachableException();  // to please the compiler
                    break;
            }
        }

        public class ClassWriter : IClassWriter
        {
            public readonly GoCodeGenerator CodeGenerator;
            public readonly TopLevelDecl ClassContext;
            public readonly bool IsClass;
            public readonly string ClassName;
            public readonly bool IsExtern;
            public readonly ConcreteSyntaxTree/*?*/ AbstractMethodWriter, ConcreteMethodWriter, InstanceFieldWriter, InstanceFieldInitWriter, TraitInitWriter, StaticFieldWriter, StaticFieldInitWriter;
            public bool AnyInstanceFields { get; private set; } = MutateCSharp.Schemata233.ReplaceBooleanConstant_7(518L, false);

            public ClassWriter(GoCodeGenerator codeGenerator, TopLevelDecl classContext, bool isClass, string className, bool isExtern, ConcreteSyntaxTree abstractMethodWriter, ConcreteSyntaxTree concreteMethodWriter,
              ConcreteSyntaxTree/*?*/ instanceFieldWriter, ConcreteSyntaxTree/*?*/ instanceFieldInitWriter, ConcreteSyntaxTree/*?*/ traitInitWriter,
              ConcreteSyntaxTree staticFieldWriter, ConcreteSyntaxTree staticFieldInitWriter)
            {
                Contract.Requires(codeGenerator != null);
                Contract.Requires(className != null);
                this.CodeGenerator = codeGenerator;
                this.ClassContext = classContext;
                this.IsClass = isClass;
                this.ClassName = className;
                this.IsExtern = isExtern;
                this.AbstractMethodWriter = abstractMethodWriter;
                this.ConcreteMethodWriter = concreteMethodWriter;
                this.InstanceFieldWriter = instanceFieldWriter;
                this.InstanceFieldInitWriter = instanceFieldInitWriter;
                this.TraitInitWriter = traitInitWriter;
                this.StaticFieldWriter = staticFieldWriter;
                this.StaticFieldInitWriter = staticFieldInitWriter;
            }

            public ConcreteSyntaxTree FieldWriter(bool isStatic)
            {
                return isStatic ? StaticFieldWriter : InstanceFieldWriter;
            }

            public ConcreteSyntaxTree FieldInitWriter(bool isStatic)
            {
                return isStatic ? StaticFieldInitWriter : InstanceFieldInitWriter;
            }

            public ConcreteSyntaxTree/*?*/ CreateMethod(Method m, List<TypeArgumentInstantiation> typeArgs, bool createBody, bool forBodyInheritance, bool lookasideBody)
            {
                return CodeGenerator.CreateMethod(m, typeArgs, createBody, ClassContext, ClassName, AbstractMethodWriter, ConcreteMethodWriter, forBodyInheritance, lookasideBody);
            }

            public ConcreteSyntaxTree SynthesizeMethod(Method m, List<TypeArgumentInstantiation> typeArgs, bool createBody, bool forBodyInheritance, bool lookasideBody)
            {
                throw new UnsupportedFeatureException(m.tok, Feature.MethodSynthesis);
                return default;
            }

            public ConcreteSyntaxTree/*?*/ CreateFunction(string name, List<TypeArgumentInstantiation> typeArgs, List<Formal> formals, Type resultType, IToken tok, bool isStatic, bool createBody, MemberDecl member, bool forBodyInheritance, bool lookasideBody)
            {
                return CodeGenerator.CreateFunction(name, typeArgs, formals, resultType, tok, isStatic, createBody, member, ClassContext, ClassName, AbstractMethodWriter, ConcreteMethodWriter, forBodyInheritance, lookasideBody);
            }
            public ConcreteSyntaxTree/*?*/ CreateGetter(string name, TopLevelDecl enclosingDecl, Type resultType, IToken tok, bool isStatic, bool isConst, bool createBody, MemberDecl/*?*/ member, bool forBodyInheritance)
            {
                return CodeGenerator.CreateGetter(name, resultType, tok, isStatic, createBody, member, ClassContext, ClassName, AbstractMethodWriter, ConcreteMethodWriter, forBodyInheritance);
            }
            public ConcreteSyntaxTree/*?*/ CreateGetterSetter(string name, Type resultType, IToken tok, bool createBody, MemberDecl/*?*/ member, out ConcreteSyntaxTree setterWriter, bool forBodyInheritance)
            {
                return CodeGenerator.CreateGetterSetter(name, resultType, tok, createBody, member, ClassContext, ClassName, out setterWriter, AbstractMethodWriter, ConcreteMethodWriter, forBodyInheritance);
            }
            public void DeclareField(string name, TopLevelDecl enclosingDecl, bool isStatic, bool isConst, Type type, IToken tok, string rhs, Field field)
            {
                // FIXME: This should probably be done in Compiler.DeclareField().
                // Should just have these delegate methods take the ClassWriter as an
                // argument.
                if (!isStatic)
                {
                    AnyInstanceFields = MutateCSharp.Schemata233.ReplaceBooleanConstant_7(519L, true);
                }
                CodeGenerator.DeclareField(name, IsExtern, isStatic, isConst, type, tok, rhs, ClassName, FieldWriter(isStatic), FieldInitWriter(isStatic), ConcreteMethodWriter);
            }

            public void InitializeField(Field field, Type instantiatedFieldType, TopLevelDeclWithMembers enclosingClass)
            {
                var tok = field.tok;
                var lvalue = CodeGenerator.EmitMemberSelect(w => w.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(520L, "_this")), UserDefinedType.FromTopLevelDecl(tok, enclosingClass), field,
                new List<TypeArgumentInstantiation>(), enclosingClass.ParentFormalTypeParametersToActuals, instantiatedFieldType);
                var wRHS = lvalue.EmitWrite(FieldInitWriter(MutateCSharp.Schemata233.ReplaceBooleanConstant_7(521L, false)));
                CodeGenerator.EmitCoercionIfNecessary(instantiatedFieldType, field.Type, tok, wRHS);
                wRHS.Write(CodeGenerator.PlaceboValue(instantiatedFieldType, ErrorWriter(), tok));
            }

            public ConcreteSyntaxTree/*?*/ ErrorWriter() => ConcreteMethodWriter;

            public void Finish()
            {
                CodeGenerator.FinishClass(this);
            }
        }

        protected ConcreteSyntaxTree/*?*/ CreateMethod(Method m, List<TypeArgumentInstantiation> typeArgs, bool createBody,
          TopLevelDecl ownerContext, string ownerName,
          ConcreteSyntaxTree abstractWriter, ConcreteSyntaxTree concreteWriter, bool forBodyInheritance, bool lookasideBody)
        {
            var overriddenIns = MutateCSharp.Schemata233.ReplaceBinExprOp_3(522L, () => m.EnclosingClass is TraitDecl, () => !forBodyInheritance) ? null : m.OverriddenMethod?.Original.Ins;
            var overriddenOuts = MutateCSharp.Schemata233.ReplaceBinExprOp_3(528L, () => m.EnclosingClass is TraitDecl, () => !forBodyInheritance) ? null : m.OverriddenMethod?.Original.Outs;
            return CreateSubroutine(IdName(m), typeArgs, m.Ins, m.Outs, null,
              overriddenIns, overriddenOuts, null,
              m.tok, m.IsStatic, createBody, ownerContext, ownerName, m, abstractWriter, concreteWriter, forBodyInheritance, lookasideBody);
        }

        protected ConcreteSyntaxTree/*?*/ CreateFunction(string name, List<TypeArgumentInstantiation> typeArgs, List<Formal> formals, Type resultType,
          IToken tok, bool isStatic, bool createBody, MemberDecl member, TopLevelDecl ownerContext, string ownerName,
          ConcreteSyntaxTree abstractWriter, ConcreteSyntaxTree concreteWriter, bool forBodyInheritance, bool lookasideBody)
        {

            var fnOverridden = (member as Function)?.OverriddenFunction?.Original;
            return CreateSubroutine(name, typeArgs, formals, new List<Formal>(), resultType,
              fnOverridden?.Ins, MutateCSharp.Schemata233.ReplaceBinExprOp_22(534L, fnOverridden, null) ? null : new List<Formal>(), fnOverridden?.ResultType,
              tok, isStatic, createBody, ownerContext, ownerName, member, abstractWriter, concreteWriter, forBodyInheritance, lookasideBody);
        }

        private ConcreteSyntaxTree CreateSubroutine(string name, List<TypeArgumentInstantiation> typeArgs,
          List<Formal> inParams, List<Formal> outParams, Type/*?*/ resultType,
          List<Formal>/*?*/ overriddenInParams, List<Formal>/*?*/ overriddenOutParams, Type/*?*/ overriddenResultType,
          IToken tok, bool isStatic, bool createBody, TopLevelDecl ownerContext, string ownerName, MemberDecl/*?*/ member,
          ConcreteSyntaxTree abstractWriter, ConcreteSyntaxTree concreteWriter,
          bool forBodyInheritance, bool lookasideBody)
        {
            Contract.Requires(name != null);
            Contract.Requires(typeArgs != null);
            Contract.Requires(inParams != null);
            Contract.Requires(outParams != null);
            Contract.Requires(overriddenInParams == null || overriddenInParams.Count == inParams.Count);
            Contract.Requires(overriddenOutParams == null || overriddenOutParams.Count == outParams.Count);
            Contract.Requires(tok != null);
            Contract.Requires(ownerName != null);
            Contract.Requires(abstractWriter != null || concreteWriter != null);

            var customReceiver = MutateCSharp.Schemata233.ReplaceBinExprOp_3(548L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_3(542L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_3(535L, () => createBody, () => !forBodyInheritance), () => MutateCSharp.Schemata233.ReplaceBinExprOp_23(541L, member, null)), () => NeedsCustomReceiver(member));
            ConcreteSyntaxTree wr;
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_25(555L, () => createBody, () => MutateCSharp.Schemata233.ReplaceBinExprOp_24(554L, abstractWriter, null)))
            {
                wr = concreteWriter;
                string receiver = MutateCSharp.Schemata233.ReplaceBinExprOp_25(561L, () => isStatic, () => customReceiver) ? FormatCompanionTypeName(ownerName) : ownerName;
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(568L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_23(567L, member, null), () => ownerContext is DatatypeDecl))
                {
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(574L, "func ({0} {1}) "), MutateCSharp.Schemata233.ReplaceBinExprOp_25(575L, () => isStatic, () => customReceiver) ? MutateCSharp.Schemata233.ReplaceStringConstant_0(581L, "_static") : MutateCSharp.Schemata233.ReplaceStringConstant_0(582L, "_this"), receiver);
                }
                else
                {
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(583L, "func ({0} *{1}) "), MutateCSharp.Schemata233.ReplaceBinExprOp_25(584L, () => isStatic, () => customReceiver) ? MutateCSharp.Schemata233.ReplaceStringConstant_0(590L, "_static") : MutateCSharp.Schemata233.ReplaceStringConstant_0(591L, "_this"), receiver);
                }
            }
            else
            {
                wr = abstractWriter;
            }
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(592L, "{0}("), name);
            var prefix = "";
            var nTypes = WriteRuntimeTypeDescriptorsFormals(ForTypeDescriptors(typeArgs, member.EnclosingClass, member, lookasideBody), wr, ref prefix, tp => $"{FormatRTDName(tp.GetCompileName(Options))} {DafnyTypeDescriptor}");
            if (customReceiver)
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(593L, "{0}_this {1}"), MutateCSharp.Schemata233.ReplaceBinExprOp_15(598L, nTypes, MutateCSharp.Schemata233.ReplaceNumericConstant_4(594L, 0)) ? MutateCSharp.Schemata233.ReplaceStringConstant_0(603L, ", ") : "", TypeName(UserDefinedType.FromTopLevelDecl(tok, member.EnclosingClass), wr, tok));
            }
            var _ = WriteFormals(MutateCSharp.Schemata233.ReplaceBinExprOp_25(613L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_15(608L, nTypes, MutateCSharp.Schemata233.ReplaceNumericConstant_4(604L, 0)), () => customReceiver) ? MutateCSharp.Schemata233.ReplaceStringConstant_0(619L, ", ") : "", overriddenInParams ?? inParams, wr, inParams);
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(620L, ")"));

            // TODO: Maybe consider using named result parameters, since they're actually close to how Dafny method outs work
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_26(621L, overriddenOutParams, null))
            {
                WriteOutTypes(overriddenOutParams, overriddenResultType, wr, tok);
            }
            else
            {
                WriteOutTypes(outParams, resultType, wr, tok);
            }

            if (createBody)
            {
                var w = wr.NewBlock("");
                // Go doesn't have type parameters. Instead, the empty interface type is used as the type of what would have been type parameters.
                // If this is a routine inherited from a trait, then the Dafny signature of the method may have replaced the trait's type parameters.
                // Go has no direct support for this idiom. Instead, we re-declare the in-parameters with the actual type, let the re-declarations
                // shadow the given (generic) in-parameters, and then do a cast on entry to the body.
                // If the routine only contains a call to an inherited body, then we omit the conversions here.
                if (forBodyInheritance)
                {
                    // don't do any conversions
                }
                else if (MutateCSharp.Schemata233.ReplaceBinExprOp_27(622L, thisContext, null))
                {
                    w = w.NewBlock("", open: BlockStyle.Brace);
                    for (var i = MutateCSharp.Schemata233.ReplaceNumericConstant_4(623L, 0); MutateCSharp.Schemata233.ReplaceBinExprOp_17(627L, i, inParams.Count); MutateCSharp.Schemata233.ReplacePostfixUnaryExprOp_14(632L, ref i))
                    {
                        var p = (overriddenInParams ?? inParams)[i];
                        var instantiatedType = p.Type.Subst(thisContext.ParentFormalTypeParametersToActuals);
                        if (!instantiatedType.Equals(p.Type))
                        {
                            // var p instantiatedType = p.(instantiatedType)
                            var pName = IdName(inParams[i]);
                            DeclareLocalVar(pName, instantiatedType, p.tok, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(633L, true), null, w);
                            var wRhs = EmitAssignmentRhs(w);
                            wRhs = EmitCoercionIfNecessary(p.Type, instantiatedType, p.tok, wRhs);
                            wRhs.Write(pName);
                            EmitDummyVariableUse(pName, w);
                        }
                    }
                }
                else
                {
                    Contract.Assert(overriddenInParams == null);
                }
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(634L, () => outParams.Any(), () => !forBodyInheritance))
                {
                    var beforeReturn = w.Fork(MutateCSharp.Schemata233.ReplaceNumericConstant_4(640L, 0));
                    EmitReturnWithCoercions(outParams, overriddenOutParams, thisContext?.ParentFormalTypeParametersToActuals, w);
                    return beforeReturn;
                }
                return w;
            }
            else
            {
                wr.WriteLine();
                return null;
            }

            return default;
        }

        protected void WriteOutTypes(List<Formal> outParams, Type/*?*/ resultType, ConcreteSyntaxTree wr, IToken tok)
        {
            var outTypes = new List<Type>();
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_28(644L, resultType, null))
            {
                outTypes.Add(resultType);
            }

            foreach (Formal f in outParams)
            {
                if (!f.IsGhost)
                {
                    outTypes.Add(f.Type);
                }
            }
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_13(649L, outTypes.Count, MutateCSharp.Schemata233.ReplaceNumericConstant_4(645L, 0)))
            {
                wr.Write(' ');
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_13(658L, outTypes.Count, MutateCSharp.Schemata233.ReplaceNumericConstant_4(654L, 1)))
                {
                    wr.Write('(');
                }
                wr.Write(Util.Comma(outTypes, ty => TypeName(ty, wr, tok)));
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_13(667L, outTypes.Count, MutateCSharp.Schemata233.ReplaceNumericConstant_4(663L, 1)))
                {
                    wr.Write(')');
                }
            }
        }

        int WriteRuntimeTypeDescriptorsFields(List<TypeParameter> typeParams, bool useAllTypeArgs, ConcreteSyntaxTree/*?*/ wr, ConcreteSyntaxTree/*?*/ wInit, ConcreteSyntaxTree/*?*/ wParams)
        {
            Contract.Requires(typeParams != null);

            var count = MutateCSharp.Schemata233.ReplaceNumericConstant_4(672L, 0);
            var sep = "";
            foreach (var tp in typeParams)
            {
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_25(676L, () => useAllTypeArgs, () => NeedsTypeDescriptor(tp)))
                {
                    var name = FormatRTDName(tp.GetCompileName(Options));
                    wr?.WriteLine($"{name} {DafnyTypeDescriptor}");
                    wInit?.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(682L, "_this.{0} = {0}"), name);
                    wParams?.Write($"{sep}{name} {DafnyTypeDescriptor}");
                    sep = MutateCSharp.Schemata233.ReplaceStringConstant_0(683L, ", ");
                    MutateCSharp.Schemata233.ReplacePostfixUnaryExprOp_14(684L, ref count);
                }
            }
            return count;
        }

        int WriteRuntimeTypeDescriptorsFormals(List<TypeParameter> typeParams, bool useAllTypeArgs,
          out ConcreteSyntaxTree wrFormals, out ConcreteSyntaxTree wrActuals)
        {
            Contract.Requires(typeParams != null);

            wrFormals = new ConcreteSyntaxTree();
            wrActuals = new ConcreteSyntaxTree();
            var count = MutateCSharp.Schemata233.ReplaceNumericConstant_4(685L, 0);
            var prefix = "";
            foreach (var tp in typeParams)
            {
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_25(689L, () => useAllTypeArgs, () => NeedsTypeDescriptor(tp)))
                {
                    var parameterName = FormatRTDName(tp.GetCompileName(Options));
                    wrFormals.Write($"{prefix}{parameterName} {DafnyTypeDescriptor}");
                    wrActuals.Write($"{prefix}{parameterName}");
                    prefix = MutateCSharp.Schemata233.ReplaceStringConstant_0(695L, ", ");
                    MutateCSharp.Schemata233.ReplacePostfixUnaryExprOp_14(696L, ref count);
                }
            }
            return count;
        }

        void WriteRuntimeTypeDescriptorsLocals(List<TypeParameter> typeParams, ConcreteSyntaxTree wr)
        {
            Contract.Requires(typeParams != null);
            Contract.Requires(wr != null);

            foreach (var tp in typeParams)
            {
                wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(697L, "{0} := _this.{0}"), FormatRTDName(tp.GetCompileName(Options)));
                EmitDummyVariableUse(FormatRTDName(tp.GetCompileName(Options)), wr);
            }
        }

        protected override void TypeArgDescriptorUse(bool isStatic, bool lookasideBody, TopLevelDeclWithMembers cl, out bool needsTypeParameter, out bool needsTypeDescriptor)
        {
            if (cl is DatatypeDecl)
            {
                needsTypeParameter = MutateCSharp.Schemata233.ReplaceBooleanConstant_7(698L, false);
                needsTypeDescriptor = MutateCSharp.Schemata233.ReplaceBooleanConstant_7(699L, true);
            }
            else if (cl is TraitDecl)
            {
                needsTypeParameter = MutateCSharp.Schemata233.ReplaceBooleanConstant_7(700L, false);
                needsTypeDescriptor = MutateCSharp.Schemata233.ReplaceBinExprOp_25(701L, () => isStatic, () => lookasideBody);
            }
            else
            {
                Contract.Assert(cl is ClassDecl);
                needsTypeParameter = MutateCSharp.Schemata233.ReplaceBooleanConstant_7(707L, false);
                needsTypeDescriptor = isStatic;
            }
        }

        protected override string TypeDescriptor(Type type, ConcreteSyntaxTree wr, IToken tok)
        {
            var xType = DatatypeWrapperEraser.SimplifyTypeAndTrimSubsetTypes(Options, type);
            if (xType is BoolType)
            {
                return MutateCSharp.Schemata233.ReplaceStringConstant_0(708L, "_dafny.BoolType");
            }
            else if (xType is CharType)
            {
                return CharTypeDescriptorName;
            }
            else if (xType is IntType)
            {
                return MutateCSharp.Schemata233.ReplaceStringConstant_0(709L, "_dafny.IntType");
            }
            else if (xType is BigOrdinalType)
            {
                return MutateCSharp.Schemata233.ReplaceStringConstant_0(710L, "_dafny.IntType");
            }
            else if (xType is RealType)
            {
                return MutateCSharp.Schemata233.ReplaceStringConstant_0(711L, "_dafny.RealType");
            }
            else if (xType is BitvectorType)
            {
                var t = (BitvectorType)xType;
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_19(712L, t.NativeType, null))
                {
                    return string.Format(MutateCSharp.Schemata233.ReplaceStringConstant_0(713L, "_dafny.{0}Type"), Capitalize(GetNativeTypeName(t.NativeType)));
                }
                else
                {
                    return MutateCSharp.Schemata233.ReplaceStringConstant_0(714L, "_dafny.IntType");
                }
            }
            else if (xType is SetType)
            {
                return MutateCSharp.Schemata233.ReplaceStringConstant_0(715L, "_dafny.SetType");
            }
            else if (xType is MultiSetType)
            {
                return MutateCSharp.Schemata233.ReplaceStringConstant_0(716L, "_dafny.MultiSetType");
            }
            else if (xType is SeqType)
            {
                return MutateCSharp.Schemata233.ReplaceStringConstant_0(717L, "_dafny.SeqType");
            }
            else if (xType is MapType)
            {
                return MutateCSharp.Schemata233.ReplaceStringConstant_0(718L, "_dafny.MapType");
            }
            else if (xType.IsRefType)
            {
                return string.Format(MutateCSharp.Schemata233.ReplaceStringConstant_0(719L, "_dafny.CreateStandardTypeDescriptor({0})"), TypeInitializationValue(xType, wr, tok, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(720L, false), MutateCSharp.Schemata233.ReplaceBooleanConstant_7(721L, true)));
            }
            else if (xType.IsArrayType)
            {
                return MutateCSharp.Schemata233.ReplaceStringConstant_0(722L, "_dafny.ArrayType");
            }
            else if (xType.IsTypeParameter)
            {
                var tp = type.AsTypeParameter;
                Contract.Assert(tp != null);
                string th;
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(724L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_27(723L, thisContext, null), () => tp.Parent is TopLevelDeclWithMembers and not TraitDecl))
                {
                    th = MutateCSharp.Schemata233.ReplaceStringConstant_0(730L, "_this.");
                }
                else
                {
                    th = "";
                }
                return string.Format(MutateCSharp.Schemata233.ReplaceStringConstant_0(731L, "{0}{1}"), th, FormatRTDName(tp.GetCompileName(Options)));
            }
            else if (xType.IsBuiltinArrowType)
            {
                return string.Format(MutateCSharp.Schemata233.ReplaceStringConstant_0(732L, "_dafny.CreateStandardTypeDescriptor({0})"), TypeInitializationValue(xType, wr, tok, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(733L, false), MutateCSharp.Schemata233.ReplaceBooleanConstant_7(734L, true)));
            }
            else if (xType is UserDefinedType udt)
            {
                var cl = udt.ResolvedClass;
                Contract.Assert(cl != null);

                var w = new ConcreteSyntaxTree();
                w.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(735L, "{0}("), cl is TupleTypeDecl ? MutateCSharp.Schemata233.ReplaceStringConstant_0(736L, "_dafny.TupleType") : TypeName_RTD(xType, w, tok));
                var typeArgs = cl is DatatypeDecl dt ? UsedTypeParameters(dt, udt.TypeArgs, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(737L, true)) : TypeArgumentInstantiation.ListFromClass(cl, udt.TypeArgs);
                EmitTypeDescriptorsActuals(typeArgs, udt.tok, w, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(738L, true));
                w.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(739L, ")"));
                return w.ToString();

            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected type
            }

            return default;
        }

        protected ConcreteSyntaxTree/*?*/ CreateGetter(string name, Type resultType, IToken tok, bool isStatic, bool createBody,
          MemberDecl/*?*/ member, TopLevelDecl ownerContext, string ownerName,
          ConcreteSyntaxTree abstractWriter, ConcreteSyntaxTree concreteWriter, bool forBodyInheritance)
        {
            return CreateFunction(name, new List<TypeArgumentInstantiation>(), new List<Formal>(), resultType,
              tok, isStatic, createBody, member, ownerContext, ownerName, abstractWriter, concreteWriter, forBodyInheritance, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(740L, false));
        }

        protected ConcreteSyntaxTree/*?*/ CreateGetterSetter(string name, Type resultType, IToken tok, bool createBody,
          MemberDecl/*?*/ member, TopLevelDecl ownerContext, string ownerName,
          out ConcreteSyntaxTree setterWriter, ConcreteSyntaxTree abstractWriter, ConcreteSyntaxTree concreteWriter, bool forBodyInheritance)
        {

            var getterWriter = CreateGetter(name, resultType, tok, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(741L, false), createBody, member, ownerContext, ownerName, abstractWriter, concreteWriter, forBodyInheritance);

            var valueParam = new Formal(tok, MutateCSharp.Schemata233.ReplaceStringConstant_0(742L, "value"), resultType, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(743L, true), MutateCSharp.Schemata233.ReplaceBooleanConstant_7(744L, false), null);
            setterWriter = CreateSubroutine(name + MutateCSharp.Schemata233.ReplaceStringConstant_0(745L, "_set_"), new List<TypeArgumentInstantiation>(), new List<Formal>() { valueParam }, new List<Formal>(), null,
              new List<Formal>() { valueParam }, new List<Formal>(), null,
              tok, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(746L, false), createBody, ownerContext, ownerName, member,
              abstractWriter, concreteWriter, forBodyInheritance, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(747L, false));
            return getterWriter;
        }

        protected override bool SupportsStaticsInGenericClasses => MutateCSharp.Schemata233.ReplaceBooleanConstant_7(748L, false);
        protected override bool TraitRepeatsInheritedDeclarations => MutateCSharp.Schemata233.ReplaceBooleanConstant_7(749L, true);

        private void FinishClass(GoCodeGenerator.ClassWriter cw)
        {
            // Go gets weird about zero-length structs.  In particular, it likes to
            // make all pointers to a zero-length struct the same.  Irritatingly, this
            // forces us to waste space here.
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(750L, () => cw.IsClass, () => !cw.AnyInstanceFields))
            {
                cw.InstanceFieldWriter.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(756L, "dummy byte"));
            }
        }

        protected override ConcreteSyntaxTree EmitNullTest(bool testIsNull, ConcreteSyntaxTree wr)
        {
            if (!testIsNull)
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(757L, "!"));
            }
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(758L, "_dafny.IsDafnyNull"));
            return wr.ForkInParens();
        }

        protected override ConcreteSyntaxTree EmitTailCallStructure(MemberDecl member, ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(759L, "goto TAIL_CALL_START"));
            wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(760L, "TAIL_CALL_START:"));
            return wr;
        }

        protected override void EmitJumpToTailCallStart(ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(761L, "goto TAIL_CALL_START"));
        }

        private const string AnyType = "interface{}"; // In Go 1.18, this type can be written as "any"

        private string CharTypeName => $"_dafny.{CharTypeNameProper}";
        private string CharTypeDescriptorName => $"_dafny.{CharTypeNameProper}Type";
        private string CharTypeNameProper => UnicodeCharEnabled ? MutateCSharp.Schemata233.ReplaceStringConstant_0(762L, "CodePoint") : MutateCSharp.Schemata233.ReplaceStringConstant_0(763L, "Char");

        internal override string TypeName(Type type, ConcreteSyntaxTree wr, IToken tok, MemberDecl/*?*/ member = null)
        {
            Contract.Ensures(Contract.Result<string>() != null);
            Contract.Assume(type != null);  // precondition; this ought to be declared as a Requires in the superclass

            var xType = DatatypeWrapperEraser.SimplifyType(Options, type);
            if (xType is BoolType)
            {
                return MutateCSharp.Schemata233.ReplaceStringConstant_0(764L, "bool");
            }
            else if (xType is CharType)
            {
                return CharTypeName;
            }
            else if (xType is IntType)
            {
                return $"{HelperModulePrefix}Int";
            }
            else if (xType is BigOrdinalType)
            {
                return MutateCSharp.Schemata233.ReplaceStringConstant_0(765L, "_dafny.Ord");
            }
            else if (xType is RealType)
            {
                return MutateCSharp.Schemata233.ReplaceStringConstant_0(766L, "_dafny.Real");
            }
            else if (xType is BitvectorType)
            {
                var t = (BitvectorType)xType;
                return MutateCSharp.Schemata233.ReplaceBinExprOp_19(767L, t.NativeType, null) ? GetNativeTypeName(t.NativeType) : MutateCSharp.Schemata233.ReplaceStringConstant_0(768L, "_dafny.BV");
            }
            else if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(771L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_29(769L, xType.AsNewtype, null), () => MutateCSharp.Schemata233.ReplaceBinExprOp_30(770L, member, null)))
            {  // when member is given, use UserDefinedType case below
                NativeType nativeType = xType.AsNewtype.NativeType;
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_19(777L, nativeType, null))
                {
                    return GetNativeTypeName(nativeType);
                }
                return TypeName(xType.AsNewtype.BaseType, wr, tok);
            }
            else if (xType.IsObjectQ)
            {
                return AnyType;
            }
            else if (xType.IsArrayType)
            {
                return MutateCSharp.Schemata233.ReplaceStringConstant_0(778L, "_dafny.Array");
            }
            else if (xType is UserDefinedType udt)
            {
                var s = FullTypeName(udt, member);
                var cl = udt.ResolvedClass;
                if (xType is ArrowType at)
                {
                    return string.Format(MutateCSharp.Schemata233.ReplaceStringConstant_0(779L, "func ({0}) {1}"), Util.Comma(at.Args, arg => TypeName(arg, wr, tok)), TypeName(at.Result, wr, tok));
                }
                else if (udt.IsTypeParameter)
                {
                    return AnyType;
                }
                else if (cl is TupleTypeDecl tupleTypeDecl)
                {
                    return HelperModulePrefix + MutateCSharp.Schemata233.ReplaceStringConstant_0(780L, "Tuple");
                }
                if (udt.IsTraitType && udt.ResolvedClass.IsExtern(Options, out _, out _))
                {
                    // To use an external interface, we need to have values of the
                    // interface type, so we treat an extern trait as a plain interface
                    // value, not a pointer (a Go interface value is basically a typed
                    // pointer anyway).
                    //
                    // Also don't use IdProtect so that we can have it be a built-in
                    // name like error.
                    return s;
                }
                else if (MutateCSharp.Schemata233.ReplaceBinExprOp_25(781L, () => udt.IsDatatype, () => udt.IsTraitType))
                {
                    // Don't return a pointer to the datatype because the datatype is
                    // already represented using a pointer
                    return IdProtect(s);
                }
                else
                {
                    return MutateCSharp.Schemata233.ReplaceStringConstant_0(787L, "*") + IdProtect(s);
                }
            }
            else if (xType is SetType)
            {
                return HelperModulePrefix + MutateCSharp.Schemata233.ReplaceStringConstant_0(788L, "Set");
            }
            else if (xType is SeqType)
            {
                return HelperModulePrefix + MutateCSharp.Schemata233.ReplaceStringConstant_0(789L, "Sequence");
            }
            else if (xType is MultiSetType)
            {
                return HelperModulePrefix + MutateCSharp.Schemata233.ReplaceStringConstant_0(790L, "MultiSet");
            }
            else if (xType is MapType)
            {
                return MutateCSharp.Schemata233.ReplaceStringConstant_0(791L, "_dafny.Map");
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected type
            }

            return default;
        }

        protected override string TypeInitializationValue(Type type, ConcreteSyntaxTree wr, IToken tok, bool usePlaceboValue, bool constructTypeParameterDefaultsFromTypeDescriptors)
        {
            // When returning nil, explicitly cast the nil so that type assertions work
            string nil()
            {
                return string.Format(MutateCSharp.Schemata233.ReplaceStringConstant_0(792L, "({0})(nil)"), TypeName(type, wr, tok));
            }

            var xType = type.NormalizeExpandKeepConstraints();
            if (xType is BoolType)
            {
                return MutateCSharp.Schemata233.ReplaceStringConstant_0(793L, "false");
            }
            else if (xType is CharType)
            {
                return $"{CharTypeName}({CharType.DefaultValueAsString})";
            }
            else if (MutateCSharp.Schemata233.ReplaceBinExprOp_25(794L, () => xType is IntType, () => xType is BigOrdinalType))
            {
                return MutateCSharp.Schemata233.ReplaceStringConstant_0(800L, "_dafny.Zero");
            }
            else if (xType is RealType)
            {
                return MutateCSharp.Schemata233.ReplaceStringConstant_0(801L, "_dafny.ZeroReal");
            }
            else if (xType is BitvectorType)
            {
                var t = (BitvectorType)xType;
                return MutateCSharp.Schemata233.ReplaceBinExprOp_19(802L, t.NativeType, null) ? MutateCSharp.Schemata233.ReplaceStringConstant_0(803L, "0") : MutateCSharp.Schemata233.ReplaceStringConstant_0(804L, "_dafny.Zero");
            }
            else if (xType is SetType)
            {
                return MutateCSharp.Schemata233.ReplaceStringConstant_0(805L, "_dafny.EmptySet");
            }
            else if (xType is MultiSetType)
            {
                return MutateCSharp.Schemata233.ReplaceStringConstant_0(806L, "_dafny.EmptyMultiSet");
            }
            else if (xType is SeqType seq)
            {
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(807L, () => seq.Arg.IsCharType, () => !UnicodeCharEnabled))
                {
                    return MutateCSharp.Schemata233.ReplaceStringConstant_0(813L, "_dafny.EmptySeq.SetString()");
                }
                return MutateCSharp.Schemata233.ReplaceStringConstant_0(814L, "_dafny.EmptySeq");
            }
            else if (xType is MapType)
            {
                return MutateCSharp.Schemata233.ReplaceStringConstant_0(815L, "_dafny.EmptyMap");
            }

            var udt = (UserDefinedType)xType;
            var cl = udt.ResolvedClass;
            Contract.Assert(cl != null);
            if (cl is TypeParameter tp)
            {
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(816L, () => usePlaceboValue, () => !tp.Characteristics.HasCompiledValue))
                {
                    return nil();
                }
                else if (constructTypeParameterDefaultsFromTypeDescriptors)
                {
                    var w = new ConcreteSyntaxTree();
                    w = EmitCoercionIfNecessary(from: null, to: xType, tok: tok, wr: w);
                    w.Write(TypeDescriptor(udt, wr, udt.tok));
                    w.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(822L, ".Default()"));
                    return w.ToString();
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
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_31(823L, td.Witness, null))
                {
                    return TypeName_Companion(cl, wr, tok) + MutateCSharp.Schemata233.ReplaceStringConstant_0(824L, ".Witness()");
                }
                else if (MutateCSharp.Schemata233.ReplaceBinExprOp_19(825L, td.NativeType, null))
                {
                    return GetNativeTypeName(td.NativeType) + MutateCSharp.Schemata233.ReplaceStringConstant_0(826L, "(0)");
                }
                else
                {
                    return TypeInitializationValue(td.BaseType, wr, tok, usePlaceboValue, constructTypeParameterDefaultsFromTypeDescriptors);
                }
            }
            else if (cl is SubsetTypeDecl)
            {
                var td = (SubsetTypeDecl)cl;
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_20(827L, td.WitnessKind, SubsetTypeDecl.WKind.Compiled))
                {
                    return TypeName_Companion(cl, wr, tok) + MutateCSharp.Schemata233.ReplaceStringConstant_0(828L, ".Witness()");
                }
                else if (MutateCSharp.Schemata233.ReplaceBinExprOp_20(829L, td.WitnessKind, SubsetTypeDecl.WKind.Special))
                {
                    // WKind.Special is only used with -->, ->, and non-null types:
                    Contract.Assert(ArrowType.IsPartialArrowTypeName(td.Name) || ArrowType.IsTotalArrowTypeName(td.Name) || td is NonNullTypeDecl);
                    if (ArrowType.IsPartialArrowTypeName(td.Name))
                    {
                        return nil();
                    }
                    else if (ArrowType.IsTotalArrowTypeName(td.Name))
                    {
                        var rangeDefaultValue = TypeInitializationValue(udt.TypeArgs.Last(), wr, tok, usePlaceboValue, constructTypeParameterDefaultsFromTypeDescriptors);
                        // return the lambda expression ((Ty0 x0, Ty1 x1, Ty2 x2) => rangeDefaultValue)
                        return string.Format(MutateCSharp.Schemata233.ReplaceStringConstant_0(830L, "func ({0}) {1} {{ return {2}; }}"), Util.Comma(udt.TypeArgs.GetRange(MutateCSharp.Schemata233.ReplaceNumericConstant_4(831L, 0), MutateCSharp.Schemata233.ReplaceBinExprOp_18(839L, udt.TypeArgs.Count, MutateCSharp.Schemata233.ReplaceNumericConstant_4(835L, 1))), tp => TypeName(tp, wr, tok)), TypeName(udt.TypeArgs.Last(), wr, tok), rangeDefaultValue);
                    }
                    else if (((NonNullTypeDecl)td).Class is ArrayClassDecl arrayClass)
                    {
                        // non-null array type; we know how to initialize them
                        return string.Format(MutateCSharp.Schemata233.ReplaceStringConstant_0(848L, "_dafny.NewArrayWithValue(nil, {0})"), Util.Comma(arrayClass.Dims, d => string.Format(MutateCSharp.Schemata233.ReplaceStringConstant_0(849L, "_dafny.IntOf(0)"))));
                    }
                    else
                    {
                        return nil();
                    }
                }
                else
                {
                    return TypeInitializationValue(td.RhsWithArgument(udt.TypeArgs), wr, tok, usePlaceboValue, constructTypeParameterDefaultsFromTypeDescriptors);
                }
            }
            else if (cl is ClassLikeDecl or ArrowTypeDecl)
            {
                return nil();
            }
            else if (cl is DatatypeDecl)
            {
                var dt = (DatatypeDecl)cl;
                if (DatatypeWrapperEraser.GetInnerTypeOfErasableDatatypeWrapper(Options, dt, out var innerType))
                {
                    var typeSubstMap = TypeParameter.SubstitutionMap(dt.TypeArgs, udt.TypeArgs);
                    return TypeInitializationValue(innerType.Subst(typeSubstMap), wr, tok, usePlaceboValue, constructTypeParameterDefaultsFromTypeDescriptors);
                }
                // In an auto-init context (like a field initializer), we may not have
                // access to all the type descriptors, so we can't construct the
                // default value, but then an empty structure is an acceptable default, since
                // Dafny proves the value won't be accessed.
                if (usePlaceboValue)
                {
                    return string.Format(MutateCSharp.Schemata233.ReplaceStringConstant_0(850L, "{0}{{}}"), TypeName(udt, wr, tok));
                }
                var n = dt is TupleTypeDecl ? MutateCSharp.Schemata233.ReplaceStringConstant_0(851L, "_dafny.TupleOf") : $"{TypeName_Companion(dt, wr, tok)}.Default";
                var wTypeDescriptorArguments = new ConcreteSyntaxTree();
                var sep = "";
                WriteTypeDescriptors(dt, udt.TypeArgs, wTypeDescriptorArguments, ref sep);
                var relevantTypeArgs = UsedTypeParameters(dt, udt.TypeArgs);
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_6(856L, relevantTypeArgs.Count, MutateCSharp.Schemata233.ReplaceNumericConstant_4(852L, 0)))
                {
                    sep = "";
                }
                var arguments = relevantTypeArgs.Comma(ta => DefaultValue(ta.Actual, wr, tok, constructTypeParameterDefaultsFromTypeDescriptors));
                return $"{n}({wTypeDescriptorArguments}{sep}{arguments})";
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected type
            }

            return default;
        }

        protected override string TypeName_UDT(string fullCompileName, List<TypeParameter.TPVariance> variance, List<Type> typeArgs,
          ConcreteSyntaxTree wr, IToken tok, bool omitTypeArguments)
        {
            Contract.Assume(fullCompileName != null);  // precondition; this ought to be declared as a Requires in the superclass
            Contract.Assume(typeArgs != null);  // precondition; this ought to be declared as a Requires in the superclass
            string s = MutateCSharp.Schemata233.ReplaceStringConstant_0(861L, "*") + IdProtect(fullCompileName);
            return s;
        }

        protected static string FormatCompanionName(string clsName) =>
          string.Format(MutateCSharp.Schemata233.ReplaceStringConstant_0(862L, "Companion_{0}_"), clsName);
        protected static string FormatCompanionTypeName(string clsName) =>
          // Need to export this because it could be for a trait that could be
          // derived from in another module
          string.Format(MutateCSharp.Schemata233.ReplaceStringConstant_0(863L, "CompanionStruct_{0}_"), clsName);
        protected static string FormatDatatypeConstructorName(string ctorName) =>
          string.Format(MutateCSharp.Schemata233.ReplaceStringConstant_0(864L, "Create_{0}_"), ctorName);
        protected static string FormatDatatypeConstructorCheckName(string ctorName) =>
          string.Format(MutateCSharp.Schemata233.ReplaceStringConstant_0(865L, "Is_{0}"), ctorName);
        protected static string FormatDatatypeDestructorName(string dtorName) =>
          string.Format(MutateCSharp.Schemata233.ReplaceStringConstant_0(866L, "Dtor_{0}"), dtorName);
        protected static string FormatDatatypeInterfaceName(string typeName) =>
          string.Format(MutateCSharp.Schemata233.ReplaceStringConstant_0(867L, "Data_{0}_"), typeName);
        protected static string FormatDefaultName(string typeName) =>
          string.Format(MutateCSharp.Schemata233.ReplaceStringConstant_0(868L, "Default_{0}_"), typeName);
        protected static string FormatInitializerName(string clsName) =>
          string.Format(MutateCSharp.Schemata233.ReplaceStringConstant_0(869L, "New_{0}_"), clsName);
        protected static string FormatLazyConstructorName(string datatypeName) =>
          string.Format(MutateCSharp.Schemata233.ReplaceStringConstant_0(870L, "Lazy_{0}_"), datatypeName);
        protected static string FormatLazyInterfaceName(string traitName) =>
          string.Format(MutateCSharp.Schemata233.ReplaceStringConstant_0(871L, "Iface_{0}_"), traitName);
        protected static string FormatRTDName(string formalName) =>
          string.Format(MutateCSharp.Schemata233.ReplaceStringConstant_0(872L, "Type_{0}_"), formalName);

        protected string TypeName_Related(Func<string, string> formatter, Type type, ConcreteSyntaxTree wr, IToken tok, MemberDecl/*?*/ member = null)
        {
            Contract.Requires(formatter != null);
            Contract.Requires(type != null);
            Contract.Ensures(Contract.Result<string>() != null);

            // FIXME This is a hacky bit of string munging.

            string name = ClassName(type, wr, tok, member);
            string prefix, baseName;
            var periodIx = name.LastIndexOf('.');
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_32(877L, periodIx, MutateCSharp.Schemata233.ReplaceNumericConstant_4(873L, 0)))
            {
                prefix = name.Substring(MutateCSharp.Schemata233.ReplaceNumericConstant_4(882L, 0), MutateCSharp.Schemata233.ReplaceBinExprOp_33(890L, periodIx, MutateCSharp.Schemata233.ReplaceNumericConstant_4(886L, 1)));
                baseName = name.Substring(MutateCSharp.Schemata233.ReplaceBinExprOp_33(903L, periodIx, MutateCSharp.Schemata233.ReplaceNumericConstant_4(899L, 1)));
            }
            else
            {
                prefix = "";
                baseName = name;
            }

            return prefix + formatter(baseName);
        }

        protected string TypeName_Constructor(DatatypeCtor ctor, ConcreteSyntaxTree wr)
        {
            var ptr = ctor.EnclosingDatatype is CoDatatypeDecl ? MutateCSharp.Schemata233.ReplaceStringConstant_0(912L, "*") : "";
            return string.Format(MutateCSharp.Schemata233.ReplaceStringConstant_0(913L, "{0}{1}_{2}"), ptr, TypeName(UserDefinedType.FromTopLevelDecl(ctor.tok, ctor.EnclosingDatatype), wr, ctor.tok), ctor.GetCompileName(Options));
        }

        protected override string TypeName_Companion(Type type, ConcreteSyntaxTree wr, IToken tok, MemberDecl/*?*/ member)
        {
            type = UserDefinedType.UpcastToMemberEnclosingType(type, member);
            // XXX This duplicates some of the logic in UserDefinedTypeName, but if we
            // don't do it here, we end up passing the name of the module to
            // FormatCompanionName, which doesn't help anyone
            if (type is UserDefinedType udt && udt.ResolvedClass != null && IsExternMemberOfExternModule(member, udt.ResolvedClass))
            {
                // omit the default class name ("_default") in extern modules, when the class is used to qualify an extern member
                Contract.Assert(!udt.ResolvedClass.EnclosingModuleDefinition.IsDefaultModule);  // default module is not marked ":extern"
                return IdProtect(udt.ResolvedClass.EnclosingModuleDefinition.GetCompileName(Options));
            }
            return TypeName_Related(FormatCompanionName, type, wr, tok, member);
        }

        protected string TypeName_CompanionType(Type type, ConcreteSyntaxTree wr, IToken tok)
        {
            return TypeName_Related(FormatCompanionTypeName, type, wr, tok);
        }

        protected string TypeName_Initializer(Type type, ConcreteSyntaxTree wr, IToken tok)
        {
            return TypeName_Related(FormatInitializerName, type, wr, tok);
        }

        protected string TypeName_RTD(Type type, ConcreteSyntaxTree wr, IToken tok)
        {
            return TypeName_Related(FormatRTDName, type, wr, tok);
        }

        protected string ClassName(Type type, ConcreteSyntaxTree wr, IToken tok, MemberDecl/*?*/ member = null)
        {
            return type is UserDefinedType udt ? FullTypeName(udt, member) : TypeName(type, wr, tok, member);
        }

        protected string UnqualifiedClassName(Type type, ConcreteSyntaxTree wr, IToken tok)
        {
            return type is UserDefinedType udt ? UnqualifiedTypeName(udt) : TypeName(type, wr, tok);
        }

        protected string DatatypeFieldName(Formal formal, int formalNonGhostIndex)
        {
            // Don't rely on base.FormalName because it needlessly (for us) passes the
            // value through IdProtect when we're going to capitalize it
            return formal.HasName ? Capitalize(formal.CompileName) : MutateCSharp.Schemata233.ReplaceStringConstant_0(914L, "A") + formalNonGhostIndex + MutateCSharp.Schemata233.ReplaceStringConstant_0(915L, "_");
        }

        protected string DatatypeFieldName(Formal formal)
        {
            Contract.Assert(formal.HasName);
            return Capitalize(formal.CompileName);
        }

        // ----- Declarations -------------------------------------------------------------

        protected void DeclareField(string name, bool isExtern, bool isStatic, bool isConst, Type type, IToken tok, string/*?*/ rhs, string className, ConcreteSyntaxTree wr, ConcreteSyntaxTree initWriter, ConcreteSyntaxTree concreteMethodWriter)
        {
            if (isExtern)
            {
                Error(GeneratorErrors.ErrorId.c_Go_unsupported_field, tok, MutateCSharp.Schemata233.ReplaceStringConstant_0(916L, "Unsupported field {0} in extern trait"), wr, name);
            }

            if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(917L, () => isConst, () => rhs != null))
            {
                var receiver = isStatic ? FormatCompanionTypeName(className) : className;
                var wBody = concreteMethodWriter.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(923L, "func (_this *{0}) {1}() {2}"), receiver, name, TypeName(type, concreteMethodWriter, tok));
                wBody.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(924L, "return {0}"), rhs);
            }
            else
            {
                wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(925L, "{0} {1}"), name, TypeName(type, initWriter, tok));

                if (isStatic)
                {
                    initWriter.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(926L, "{0}: {1},"), name, rhs ?? PlaceboValue(type, initWriter, tok));
                }
                else if (rhs != null)
                {
                    initWriter.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(927L, "_this.{0} = {1}"), name, rhs);
                }
            }
        }

        protected override bool DeclareFormal(string prefix, string name, Type type, IToken tok, bool isInParam, ConcreteSyntaxTree wr)
        {
            if (isInParam)
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(928L, "{0}{1} {2}"), prefix, name, TypeName(type, wr, tok));
                return MutateCSharp.Schemata233.ReplaceBooleanConstant_7(929L, true);
            }
            else
            {
                return MutateCSharp.Schemata233.ReplaceBooleanConstant_7(930L, false);
            }

            return default;
        }

        private ConcreteSyntaxTree/*?*/ DeclareLocalVar(string name, Type/*?*/ type, IToken/*?*/ tok, bool includeRhs, bool leaveRoomForRhs, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(931L, "var {0}"), name);

            if (MutateCSharp.Schemata233.ReplaceBinExprOp_28(932L, type, null))
            {
                // Always specify the type in case the rhs is nil
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(933L, " {0}"), TypeName(type, wr, tok));
            }

            ConcreteSyntaxTree w;
            if (includeRhs)
            {
                if (!leaveRoomForRhs)
                {
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(934L, " = "));
                }
                w = wr.Fork();
            }
            else
            {
                w = null;
            }

            if (!leaveRoomForRhs)
            {
                wr.WriteLine();
                EmitDummyVariableUse(name, wr);
            }

            return w;
        }

        protected override void EmitDummyVariableUse(string variableName, ConcreteSyntaxTree wr)
        {
            Contract.Requires(variableName != null);
            Contract.Requires(wr != null);

            wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(935L, "_ = {0}"), variableName);
        }

        protected override void DeclareLocalVar(string name, Type type, IToken tok, bool leaveRoomForRhs, string rhs, ConcreteSyntaxTree wr)
        {
            var w = DeclareLocalVar(name, type, tok, includeRhs: (MutateCSharp.Schemata233.ReplaceBinExprOp_25(936L, () => rhs != null, () => leaveRoomForRhs)), leaveRoomForRhs: leaveRoomForRhs, wr: wr);
            if (rhs != null)
            {
                w.Write(rhs);
            }
        }

        protected override ConcreteSyntaxTree DeclareLocalVar(string name, Type/*?*/ type, IToken/*?*/ tok, ConcreteSyntaxTree wr)
        {
            return DeclareLocalVar(name, type, tok, includeRhs: MutateCSharp.Schemata233.ReplaceBooleanConstant_7(942L, true), leaveRoomForRhs: MutateCSharp.Schemata233.ReplaceBooleanConstant_7(943L, false), wr: wr);
        }

        protected override bool UseReturnStyleOuts(Method m, int nonGhostOutCount) => MutateCSharp.Schemata233.ReplaceBooleanConstant_7(944L, true);

        protected override bool NeedsCastFromTypeParameter => MutateCSharp.Schemata233.ReplaceBooleanConstant_7(945L, true);
        protected override bool SupportsMultipleReturns => MutateCSharp.Schemata233.ReplaceBooleanConstant_7(946L, true);
        protected override string StmtTerminator => "";

        protected override void DeclareLocalOutVar(string name, Type type, IToken tok, string rhs, bool useReturnStyleOuts, ConcreteSyntaxTree wr)
        {
            DeclareLocalVar(name, type, tok, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(947L, false), rhs, wr);
        }

        protected override void EmitActualTypeArgs(List<Type> typeArgs, IToken tok, ConcreteSyntaxTree wr)
        {
            // emit nothing; this is only for actual parametric polymorphism, not RTDs
        }

        // ----- Statements -------------------------------------------------------------

        protected override void EmitMultiAssignment(List<Expression> lhsExprs, List<ILvalue> wLhss, List<Type> lhsTypes, out List<ConcreteSyntaxTree> wRhss, List<Type> rhsTypes, ConcreteSyntaxTree wr)
        {
            // TODO Go actually supports multi-assignment, but that will only work
            // in the simple (but very typical) case where an lvalue represents an
            // actual lvalue that is written via an assignment statement.  (Actually,
            // currently *all* Go lvalues work this way, but in the future we could
            // implement getters and setters via ILvalueWriter.)
            //
            // Given a way to inquire whether a given lvalue is an actual lvalue in
            // the target, we could implement multi-assignment for the special case
            // where all lvalues are real lvalues.
            base.EmitMultiAssignment(lhsExprs, wLhss, lhsTypes, out wRhss, rhsTypes, wr);
        }

        protected override void EmitPrintStmt(ConcreteSyntaxTree wr, Expression arg)
        {
            var isString = DatatypeWrapperEraser.SimplifyTypeAndTrimNewtypes(Options, arg.Type).IsStringType;
            var wStmts = wr.Fork();
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(948L, () => isString, () => UnicodeCharEnabled))
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(954L, "_dafny.Print("));
                wr.Append(Expr(arg, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(955L, false), wStmts));
                wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(956L, ".VerbatimString(false))"));
            }
            else if (!isString ||
                       (arg.Resolved is MemberSelectExpr mse &&
                        mse.Member.IsExtern(Options, out _, out _)))
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(957L, "_dafny.Print("));
                wr.Append(Expr(arg, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(958L, false), wStmts));
                wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(959L, ")"));
            }
            else
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(960L, "_dafny.Print(("));
                wr.Append(Expr(arg, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(961L, false), wStmts));
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(962L, ")"));
                if (!UnicodeCharEnabled)
                {
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(963L, ".SetString()"));
                }
                wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(964L, ")"));
            }
        }

        protected override void EmitReturn(List<Formal> outParams, ConcreteSyntaxTree wr)
        {
            EmitReturnWithCoercions(outParams, null, null, wr);
        }

        protected override void EmitReturnExpr(Expression expr, Type resultType, bool inLetExprBody, ConcreteSyntaxTree wr)
        {
            var wStmts = wr.Fork();
            var w = EmitReturnExpr(wr);
            var fromType = MutateCSharp.Schemata233.ReplaceBinExprOp_34(965L, thisContext, null) ? expr.Type : expr.Type.Subst(thisContext.ParentFormalTypeParametersToActuals);
            w = EmitCoercionIfNecessary(fromType, resultType, expr.tok, w);
            w.Append(Expr(expr, inLetExprBody, wStmts));
        }

        protected void EmitReturnWithCoercions(List<Formal> outParams, List<Formal>/*?*/ overriddenOutParams, Dictionary<TypeParameter, Type>/*?*/ typeMap, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(966L, "return"));
            var sep = MutateCSharp.Schemata233.ReplaceStringConstant_0(967L, " ");
            for (var i = MutateCSharp.Schemata233.ReplaceNumericConstant_4(968L, 0); MutateCSharp.Schemata233.ReplaceBinExprOp_17(972L, i, outParams.Count); MutateCSharp.Schemata233.ReplacePostfixUnaryExprOp_14(977L, ref i))
            {
                var f = outParams[i];
                if (!f.IsGhost)
                {
                    wr.Write(sep);
                    ConcreteSyntaxTree wOutParam;
                    if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(980L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_35(978L, overriddenOutParams, null), () => MutateCSharp.Schemata233.ReplaceBinExprOp_36(979L, typeMap, null)))
                    {
                        wOutParam = EmitCoercionIfNecessary(f.Type.Subst(typeMap), f.Type, f.tok, wr);
                    }
                    else if (MutateCSharp.Schemata233.ReplaceBinExprOp_26(986L, overriddenOutParams, null))
                    {
                        // ignore typeMap
                        wOutParam = EmitCoercionIfNecessary(f.Type, overriddenOutParams[i].Type, f.tok, wr);
                    }
                    else
                    {
                        wOutParam = wr;
                    }
                    wOutParam.Write(IdName(f));
                    sep = MutateCSharp.Schemata233.ReplaceStringConstant_0(987L, ", ");
                }
            }
            wr.WriteLine();
        }

        protected override ConcreteSyntaxTree CreateLabeledCode(string label, bool createContinueLabel, ConcreteSyntaxTree wr)
        {
            var wBody = wr.NewBlock(open: BlockStyle.Brace);
            var w = wBody.Fork();
            var prefix = createContinueLabel ? MutateCSharp.Schemata233.ReplaceStringConstant_0(988L, "C") : MutateCSharp.Schemata233.ReplaceStringConstant_0(989L, "L");
            wBody.WriteLine($"goto {prefix}{label};");
            wr.Fork(MutateCSharp.Schemata233.ReplaceNumericConstant_4(990L, -1)).WriteLine($"{prefix}{label}:");
            return w;
        }

        protected override void EmitBreak(string/*?*/ label, ConcreteSyntaxTree wr)
        {
            if (label == null)
            {
                wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(994L, "break"));
            }
            else
            {
                wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(995L, "goto L{0}"), label);
            }
        }

        protected override void EmitContinue(string label, ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(996L, "goto C{0};"), label);
        }

        protected override void EmitYield(ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(997L, "_yielded <- struct{}{}"));
            wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(998L, "_, _ok = <- _cont"));
            wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(999L, "if !_ok { return }"));
        }

        protected override void EmitAbsurd(string/*?*/ message, ConcreteSyntaxTree wr)
        {
            if (message == null)
            {
                message = MutateCSharp.Schemata233.ReplaceStringConstant_0(1000L, "unexpected control point");
            }
            wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(1001L, "panic(\"{0}\")"), message);
        }

        protected override void EmitHalt(IToken tok, Expression messageExpr, ConcreteSyntaxTree wr)
        {
            var wStmts = wr.Fork();
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1002L, "panic("));
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_11(1003L, tok, null))
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1004L, "\"") + tok.TokenToString(Options) + MutateCSharp.Schemata233.ReplaceStringConstant_0(1005L, ": \" + "));
            }

            TrParenExpr(messageExpr, wr, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1006L, false), wStmts);
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1007L, () => UnicodeCharEnabled, () => messageExpr.Type.IsStringType))
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1013L, ".VerbatimString(false))"));
            }
            else
            {
                wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(1014L, ".String())"));
            }
        }

        protected override ConcreteSyntaxTree CreateWhileLoop(out ConcreteSyntaxTree guardWriter, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1015L, "for "));
            guardWriter = wr.Fork();
            var wBody = wr.NewBlock("");
            return wBody;
        }

        protected override ConcreteSyntaxTree EmitForStmt(IToken tok, IVariable loopIndex, bool goingUp, string /*?*/ endVarName,
          List<Statement> body, LList<Label> labels, ConcreteSyntaxTree wr)
        {

            wr.Write($"for {loopIndex.CompileName} := ");
            var startWr = wr.Fork();
            wr.Write($"; ");

            ConcreteSyntaxTree bodyWr;
            if (goingUp)
            {
                if (endVarName == null)
                {
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1016L, "true"));
                }
                else if (IsOrderedByCmp(loopIndex.Type))
                {
                    wr.Write($"{loopIndex.CompileName}.Cmp({endVarName}) < 0");
                }
                else
                {
                    wr.Write($"{loopIndex.CompileName} < {endVarName}");
                }
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_21(1017L, AsNativeType(loopIndex.Type), null))
                {
                    bodyWr = wr.NewBlock($"; {loopIndex.CompileName} = {loopIndex.CompileName}.Plus(_dafny.One)");
                }
                else
                {
                    bodyWr = wr.NewBlock($"; {loopIndex.CompileName}++");
                }
            }
            else
            {
                if (endVarName == null)
                {
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1018L, "true"));
                }
                else if (IsOrderedByCmp(loopIndex.Type))
                {
                    wr.Write($"{endVarName}.Cmp({loopIndex.CompileName}) < 0");
                }
                else
                {
                    wr.Write($"{endVarName} < {loopIndex.CompileName}");
                }
                bodyWr = wr.NewBlock($"; ");
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_21(1019L, AsNativeType(loopIndex.Type), null))
                {
                    bodyWr.WriteLine($"{loopIndex.CompileName} = {loopIndex.CompileName}.Minus(_dafny.One)");
                }
                else
                {
                    bodyWr.WriteLine($"{loopIndex.CompileName}--");
                }
            }
            bodyWr = EmitContinueLabel(labels, bodyWr);
            TrStmtList(body, bodyWr);

            return startWr;
        }

        protected override ConcreteSyntaxTree CreateForLoop(string indexVar, Action<ConcreteSyntaxTree> boundAction, ConcreteSyntaxTree wr, string start = null)
        {
            start = start ?? MutateCSharp.Schemata233.ReplaceStringConstant_0(1020L, "0");
            var boundWriter = new ConcreteSyntaxTree();
            boundAction(boundWriter);
            var bound = boundWriter.ToString();
            return wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(1021L, "for {0} := {2}; {0} < {1}; {0}++"), indexVar, bound, start);
        }

        protected override ConcreteSyntaxTree CreateDoublingForLoop(string indexVar, int start, ConcreteSyntaxTree wr)
        {
            return wr.NewNamedBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(1022L, "for {0} := {1}IntOf({2}); ; {0} = {0}.Times(_dafny.Two)"), indexVar, HelperModulePrefix, start);
        }

        protected override void EmitIncrementVar(string varName, ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(1023L, "{0} = {0}.Plus(_dafny.One)"), varName);
        }

        protected override void EmitDecrementVar(string varName, ConcreteSyntaxTree wr)
        {
            wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(1024L, "{0} = {0}.Minus(_dafny.One)"), varName);
        }

        protected override string GetQuantifierName(string bvType)
        {
            return MutateCSharp.Schemata233.ReplaceStringConstant_0(1025L, "_dafny.Quantifier");
        }

        protected override ConcreteSyntaxTree CreateForeachLoop(string tmpVarName, Type collectionElementType, IToken tok,
          out ConcreteSyntaxTree collectionWriter, ConcreteSyntaxTree wr)
        {

            var okVar = idGenerator.FreshId(MutateCSharp.Schemata233.ReplaceStringConstant_0(1026L, "_ok"));
            var iterVar = idGenerator.FreshId(MutateCSharp.Schemata233.ReplaceStringConstant_0(1027L, "_iter"));
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1028L, "for {0} := _dafny.Iterate("), iterVar);
            collectionWriter = wr.Fork();
            var wBody = wr.NewBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(1029L, ");;"));
            wBody.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(1030L, "{0}, {1} := {2}()"), tmpVarName, okVar, iterVar);
            wBody.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(1031L, "if !{0} {{ break }}"), okVar);
            return wBody;
        }

        [CanBeNull]
        protected override Action<ConcreteSyntaxTree> GetSubtypeCondition(string tmpVarName, Type boundVarType, IToken tok, ConcreteSyntaxTree wPreconditions)
        {
            var conditions = new List<string> { };
            if (boundVarType.IsNonNullRefType)
            {
                conditions.Add($"!_dafny.IsDafnyNull({tmpVarName})");
            }

            if (boundVarType.IsRefType)
            {
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_25(1032L, () => boundVarType.IsObject, () => boundVarType.IsObjectQ))
                {
                    // Nothing more to test
                }
                else if (boundVarType.IsTraitType)
                {
                    var trait = boundVarType.AsTraitType;
                    conditions.Add(
                      $"{HelperModulePrefix}InstanceOfTrait/*1*/({tmpVarName}.(_dafny.TraitOffspring), {TypeName_Companion(trait, wPreconditions, tok)}.TraitID_)");
                }
                else
                {
                    var typeAssertSucceeds = idGenerator.FreshId(MutateCSharp.Schemata233.ReplaceStringConstant_0(1038L, "_typeAssertSucceeds"));
                    wPreconditions.WriteLine(
                      $@"{typeAssertSucceeds} := func(param interface{{}}) bool {{ var ok bool; _, ok = param.({TypeName(boundVarType, wPreconditions, tok)}); return ok}}");
                    conditions.Add($"{typeAssertSucceeds}({tmpVarName})");
                }
            }

            if (!conditions.Any())
            {
                conditions.Add(MutateCSharp.Schemata233.ReplaceStringConstant_0(1039L, "true"));
            }

            var typeTest = string.Join(MutateCSharp.Schemata233.ReplaceStringConstant_0(1040L, "&&"), conditions);
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1049L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_3(1041L, () => boundVarType.IsRefType, () => !boundVarType.IsNonNullRefType), () => MutateCSharp.Schemata233.ReplaceBinExprOp_5(1048L, typeTest, MutateCSharp.Schemata233.ReplaceStringConstant_0(1047L, "true"))))
            {
                typeTest = $"_dafny.IsDafnyNull({tmpVarName}) || " + typeTest;
            }

            typeTest = MutateCSharp.Schemata233.ReplaceBinExprOp_2(1056L, typeTest, MutateCSharp.Schemata233.ReplaceStringConstant_0(1055L, "true")) ? null : typeTest;
            return typeTest == null ? null : wr => wr.Write(typeTest);
        }

        protected override void EmitDowncastVariableAssignment(string boundVarName, Type boundVarType, string tmpVarName,
          Type sourceType, bool introduceBoundVar, IToken tok, ConcreteSyntaxTree wr)
        {

            if (introduceBoundVar)
            {
                wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(1057L, "var {0} {1}"), boundVarName, TypeName(boundVarType, wr, tok));
            }

            var wrAssign = wr;
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1058L, () => boundVarType.IsRefType, () => !boundVarType.IsNonNullRefType))
            {
                var wIf = EmitIf($"_dafny.IsDafnyNull({tmpVarName})", MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1064L, true), wr);
                wIf.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(1065L, "{0} = ({1})(nil)"), boundVarName, TypeName(boundVarType, wr, tok));
                wrAssign = wr.NewBlock("", open: BlockStyle.Brace);
            }

            var cast = $".({TypeName(boundVarType, wrAssign, tok)})";
            tmpVarName = $"interface{{}}({tmpVarName})";
            wrAssign.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(1066L, "{0} = {1}{2}"), boundVarName, tmpVarName, cast);
        }

        protected override ConcreteSyntaxTree CreateForeachIngredientLoop(string boundVarName, int L, string tupleTypeArgs, out ConcreteSyntaxTree collectionWriter, ConcreteSyntaxTree wr)
        {
            var okVar = idGenerator.FreshId(MutateCSharp.Schemata233.ReplaceStringConstant_0(1067L, "_ok"));
            var iterVar = idGenerator.FreshId(MutateCSharp.Schemata233.ReplaceStringConstant_0(1068L, "_iter"));
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1069L, "for {0} := _dafny.Iterate("), iterVar);
            collectionWriter = wr.Fork();
            var wBody = wr.NewBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(1070L, ");;"));
            wBody.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(1071L, "{0}, {1} := {2}()"), boundVarName, okVar, iterVar);
            wBody.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(1072L, "if !{0} {{ break }}"), okVar);
            return wBody;
        }

        // ----- Expressions -------------------------------------------------------------

        protected override void EmitNew(Type type, IToken tok, CallStmt initCall /*?*/, ConcreteSyntaxTree wr,
          ConcreteSyntaxTree wStmts)
        {
            var cl = ((UserDefinedType)type.NormalizeExpand()).ResolvedClass;
            Contract.Assert(cl != null);
            if (cl is TraitDecl { IsObjectTrait: true })
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1073L, "_dafny.New_Object()"));
            }
            else
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1074L, "{0}("), TypeName_Initializer(type, wr, tok));
                EmitTypeDescriptorsActuals(TypeArgumentInstantiation.ListFromClass(cl, type.TypeArgs), tok, wr);
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1075L, ")"));
            }
        }

        protected override bool DeterminesArrayTypeFromExampleElement => MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1076L, true);

        protected override void EmitNewArray(Type elementType, IToken tok, List<string> dimensions,
            bool mustInitialize, [CanBeNull] string exampleElement, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {

            string sep;
            if (mustInitialize)
            {
                var initValue = DefaultValue(elementType, wr, tok, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1077L, true));
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1078L, "_dafny.NewArrayWithValue({0}"), initValue);
                sep = MutateCSharp.Schemata233.ReplaceStringConstant_0(1079L, ", ");
            }
            else if (exampleElement != null)
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1080L, "_dafny.NewArrayFromExample({0}, nil"), exampleElement);
                sep = MutateCSharp.Schemata233.ReplaceStringConstant_0(1081L, ", ");
            }
            else
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1082L, "_dafny.NewArray("));
                sep = "";
            }

            foreach (var dim in dimensions)
            {
                wr.Write($"{sep}{dim}");
                sep = MutateCSharp.Schemata233.ReplaceStringConstant_0(1083L, ", ");
            }

            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1084L, ")"));
        }

        protected override void EmitLiteralExpr(ConcreteSyntaxTree wr, LiteralExpr e)
        {
            if (e is StaticReceiverExpr)
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1085L, "{0}"), TypeName_Companion(((UserDefinedType)e.Type).ResolvedClass, wr, e.tok));
            }
            else if (e.Value == null)
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1086L, "({0})(nil)"), TypeName(e.Type, wr, e.tok));
            }
            else if (e.Value is bool)
            {
                wr.Write((bool)e.Value ? MutateCSharp.Schemata233.ReplaceStringConstant_0(1087L, "true") : MutateCSharp.Schemata233.ReplaceStringConstant_0(1088L, "false"));
            }
            else if (e is CharLiteralExpr chrLit)
            {
                TrCharLiteral(chrLit, wr);
            }
            else if (e is StringLiteralExpr strLit)
            {
                TrStringLiteral(strLit, wr);
            }
            else if (AsNativeType(e.Type) is NativeType nt)
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1089L, "{0}({1})"), GetNativeTypeName(nt), (BigInteger)e.Value);
            }
            else if (e.Value is BigInteger i)
            {
                EmitIntegerLiteral(i, wr);
            }
            else if (e.Value is BaseTypes.BigDec n)
            {
                var zeros = Repeat(MutateCSharp.Schemata233.ReplaceStringConstant_0(1090L, "0"), Math.Abs(n.Exponent));
                string str;
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_32(1095L, n.Exponent, MutateCSharp.Schemata233.ReplaceNumericConstant_4(1091L, 0)))
                {
                    str = n.Mantissa + zeros;
                }
                else
                {
                    str = n.Mantissa + MutateCSharp.Schemata233.ReplaceStringConstant_0(1100L, "/1") + zeros;
                }
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1101L, "_dafny.RealOfString(\"{0}\")"), str);
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
                wr.Write($"{HelperModulePrefix}Zero");
            }
            else if (i.IsOne)
            {
                wr.Write($"{HelperModulePrefix}One");
            }
            else if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1106L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_37(1102L, long.MinValue, i), () => MutateCSharp.Schemata233.ReplaceBinExprOp_38(1104L, i, long.MaxValue)))
            {
                wr.Write($"{HelperModulePrefix}IntOfInt64({i})");
            }
            else
            {
                wr.Write($"{HelperModulePrefix}IntOfString(\"{i}\")");
            }
        }

        protected void TrCharLiteral(CharLiteralExpr chr, ConcreteSyntaxTree wr)
        {
            var v = (string)chr.Value;
            wr.Write($"{CharTypeName}(");
            // See comment in TrStringLiteral for why we can't just translate directly sometimes.
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1113L, () => !UnicodeCharEnabled, () => Util.MightContainNonAsciiCharacters(v, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1112L, false))))
            {
                var c = Util.UnescapedCharacters(Options, v, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1119L, false)).Single();
                wr.Write($"{c}");
            }
            else
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1120L, "'{0}'"), TranslateEscapes(v, isChar: MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1121L, true)));
            }
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1122L, ")"));
        }

        protected override void TrStringLiteral(StringLiteralExpr str, ConcreteSyntaxTree wr)
        {
            Contract.Requires(str != null);
            Contract.Requires(wr != null);
            var s = (string)str.Value;
            if (UnicodeCharEnabled)
            {
                wr.Write($"_dafny.UnicodeSeqOfUtf8Bytes(");
                EmitStringLiteral(s, str.IsVerbatim, wr);
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1123L, ")"));
            }
            else
            {
                // When --unicode-char is false, it may not be possible to translate a Dafny string into a valid Go string,
                // since Go string literals have to be encodable in UTF-8,
                // but Dafny allows invalid sequences of surrogate characters.
                // In addition, _dafny.SeqOfString iterates over the runes in the Go string
                // rather than the equivalent UTF-16 code units.
                // That means in many cases we can't create a Dafny string value by emitting
                // _dafny.SeqOfString("..."), since there's no way to encode the right data in the Go string literal.
                // Instead, if any non-ascii characters might be present, just emit a sequence of the direct UTF-16 code units instead.
                if (Util.MightContainNonAsciiCharacters(s, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1124L, false)))
                {
                    wr.Write($"_dafny.SeqOfChars(");
                    var comma = "";
                    foreach (var c in Util.UnescapedCharacters(Options, s, str.IsVerbatim))
                    {
                        wr.Write(comma);
                        wr.Write($"{c}");
                        comma = MutateCSharp.Schemata233.ReplaceStringConstant_0(1125L, ", ");
                    }

                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1126L, ")"));
                }
                else
                {
                    wr.Write($"{HelperModulePrefix}SeqOfString(");
                    EmitStringLiteral(s, str.IsVerbatim, wr);
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1127L, ")"));
                }
            }
        }

        protected override void EmitStringLiteral(string str, bool isVerbatim, ConcreteSyntaxTree wr)
        {
            var n = str.Length;
            if (!isVerbatim)
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1128L, "\"{0}\""), TranslateEscapes(str, isChar: MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1129L, false)));
            }
            else
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1130L, "\""));
                for (var i = MutateCSharp.Schemata233.ReplaceNumericConstant_4(1131L, 0); MutateCSharp.Schemata233.ReplaceBinExprOp_17(1135L, i, n); MutateCSharp.Schemata233.ReplacePostfixUnaryExprOp_14(1140L, ref i))
                {
                    if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1188L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_3(1164L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_6(1141L, str[i], '\"'), () => MutateCSharp.Schemata233.ReplaceBinExprOp_17(1159L, MutateCSharp.Schemata233.ReplaceBinExprOp_33(1150L, i, MutateCSharp.Schemata233.ReplaceNumericConstant_4(1146L, 1)), n)), () => MutateCSharp.Schemata233.ReplaceBinExprOp_6(1183L, str[MutateCSharp.Schemata233.ReplaceBinExprOp_33(1174L, i, MutateCSharp.Schemata233.ReplaceNumericConstant_4(1170L, 1))], '\"')))
                    {
                        wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1194L, "\\\""));
                        MutateCSharp.Schemata233.ReplacePostfixUnaryExprOp_14(1195L, ref i);
                    }
                    else if (MutateCSharp.Schemata233.ReplaceBinExprOp_6(1196L, str[i], '\\'))
                    {
                        wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1201L, "\\\\"));
                    }
                    else if (MutateCSharp.Schemata233.ReplaceBinExprOp_6(1202L, str[i], '\n'))
                    {
                        wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1207L, "\\n"));
                    }
                    else if (MutateCSharp.Schemata233.ReplaceBinExprOp_6(1208L, str[i], '\r'))
                    {
                        wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1213L, "\\r"));
                    }
                    else
                    {
                        wr.Write(str[i]);
                    }
                }
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1214L, "\""));
            }
        }

        private static string TranslateEscapes(string s, bool isChar)
        {
            if (isChar)
            {
                s = s.Replace(MutateCSharp.Schemata233.ReplaceStringConstant_0(1215L, "\\\""), MutateCSharp.Schemata233.ReplaceStringConstant_0(1216L, "\""));
            }
            else
            {
                s = s.Replace(MutateCSharp.Schemata233.ReplaceStringConstant_0(1217L, "\\'"), MutateCSharp.Schemata233.ReplaceStringConstant_0(1218L, "'"));
            }

            s = Util.ReplaceNullEscapesWithCharacterEscapes(s);

            s = Util.ExpandUnicodeEscapes(s, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1219L, false));

            return s;
        }

        protected override ConcreteSyntaxTree EmitBitvectorTruncation(BitvectorType bvType, [CanBeNull] NativeType nativeType,
          bool surroundByUnchecked, ConcreteSyntaxTree wr)
        {

            string literalSuffix = null;
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_19(1220L, nativeType, null))
            {
                GetNativeInfo(nativeType.Sel, out _, out literalSuffix, out _);
            }

            if (MutateCSharp.Schemata233.ReplaceBinExprOp_21(1221L, nativeType, null))
            {
                wr.Write('(');
                var middle = wr.Fork();
                wr.Write($").Modulo(_dafny.One.Lsh({HelperModulePrefix}IntOf({bvType.Width})))");
                return middle;
            }
            else if (MutateCSharp.Schemata233.ReplaceBinExprOp_17(1222L, bvType.Width, nativeType.Bitwidth))
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1227L, "(("));
                var middle = wr.Fork();
                // print in hex, because that looks nice
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1228L, ") & 0x{0:X}{1})"), MutateCSharp.Schemata233.ReplaceBinExprOp_41(1236L, (MutateCSharp.Schemata233.ReplaceBinExprOp_40(1232L, MutateCSharp.Schemata233.ReplaceNumericConstant_39(1229L, 1UL), bvType.Width)), MutateCSharp.Schemata233.ReplaceNumericConstant_39(1233L, 1)), literalSuffix);
                return middle;
            }
            else
            {
                // no truncation needed
                return wr;
            }

            return default;
        }

        protected override void EmitRotate(Expression e0, Expression e1, bool isRotateLeft, ConcreteSyntaxTree wr,
            bool inLetExprBody, ConcreteSyntaxTree wStmts, FCE_Arg_Translator tr)
        {
            bool needsCast = MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1243L, false);
            var nativeType = AsNativeType(e0.Type);
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_19(1244L, nativeType, null))
            {
                GetNativeInfo(nativeType.Sel, out _, out _, out needsCast);
            }

            var bv = e0.Type.NormalizeToAncestorType().AsBitVectorType;
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_6(1249L, bv.Width, MutateCSharp.Schemata233.ReplaceNumericConstant_4(1245L, 0)))
            {
                tr(e0, wr, inLetExprBody, wStmts);
            }
            else
            {
                ConcreteSyntaxTree wFirstArg;
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_19(1254L, bv.NativeType, null))
                {
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1255L, "_dafny.{0}{1}("), isRotateLeft ? MutateCSharp.Schemata233.ReplaceStringConstant_0(1256L, "Lrot") : MutateCSharp.Schemata233.ReplaceStringConstant_0(1257L, "Rrot"), Capitalize(GetNativeTypeName(bv.NativeType)));
                    wFirstArg = wr.Fork();
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1258L, ", "));
                }
                else
                {
                    wr.Write('(');
                    wFirstArg = wr.Fork();
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1259L, ").{0}("), isRotateLeft ? MutateCSharp.Schemata233.ReplaceStringConstant_0(1260L, "Lrot") : MutateCSharp.Schemata233.ReplaceStringConstant_0(1261L, "Rrot"));
                }
                wFirstArg.Append(Expr(e0, inLetExprBody, wStmts));
                wr.Append(Expr(e1, inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1262L, ", {0})"), bv.Width);

                if (needsCast)
                {
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1263L, ".Int64()"));
                }
            }
        }

        protected override bool CompareZeroUsingSign(Type type)
        {
            return MutateCSharp.Schemata233.ReplaceBinExprOp_21(1264L, AsNativeType(type), null);
        }

        protected override ConcreteSyntaxTree EmitSign(Type type, ConcreteSyntaxTree wr)
        {
            // This is only called when CompareZeroUsingSign returns true
            Contract.Assert(AsNativeType(type) == null);

            var w = wr.Fork();
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1265L, ".Sign()"));
            return w;
        }

        protected override void EmitEmptyTupleList(string tupleTypeArgs, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1266L, "_dafny.NewBuilder()"));
        }

        protected override ConcreteSyntaxTree EmitAddTupleToList(string ingredients, string tupleTypeArgs, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1267L, "{0}.Add(_dafny.TupleOf("), ingredients);
            var wrTuple = wr.Fork();
            wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(1268L, "))"));
            return wrTuple;
        }

        protected override void EmitTupleSelect(string prefix, int i, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1269L, "(*({0}).IndexInt({1}))"), prefix, i);
        }

        protected override string IdName(TopLevelDecl d)
        {
            return IdName((Declaration)d);
        }

        protected override string IdName(MemberDecl member)
        {
            return IdName((Declaration)member);
        }

        private string IdName(Declaration decl)
        {
            if (HasCapitalizationConflict(decl))
            {
                // Don't use Go_ because Capitalize might use it and we know there's a conflict
                return MutateCSharp.Schemata233.ReplaceStringConstant_0(1270L, "Go__") + decl.GetCompileName(Options);
            }
            else
            {
                return Capitalize(decl.GetCompileName(Options));
            }

            return default;
        }

        protected override string PrefixForForcedCapitalization => MutateCSharp.Schemata233.ReplaceStringConstant_0(1271L, "Go_");

        protected override string IdMemberName(MemberSelectExpr mse)
        {
            return Capitalize(mse.MemberName);
        }

        protected override string IdProtect(string name)
        {
            return PublicIdProtect(name);
        }
        public override string PublicIdProtect(string name)
        {
            Contract.Requires(name != null);

            switch (name)
            {
                // Keywords
                case "break":
                case "case":
                case "chan":
                case "const":
                case "continue":
                case "default":
                case "defer":
                case "else":
                case "fallthrough":
                case "for":
                case "func":
                case "go":
                case "goto":
                case "if":
                case "import":
                case "interface":
                case "map":
                case "package":
                case "range":
                case "return":
                case "select":
                case "struct":
                case "switch":
                case "type":
                case "var":

                // Built-in functions
                case "append":
                case "cap":
                case "close":
                case "complex":
                case "copy":
                case "delete":
                case "imag":
                case "len":
                case "make":
                case "new":
                case "panic":
                case "print":
                case "println":
                case "real":
                case "recover":

                case "String":
                case "Equals":
                case "EqualsGeneric":

                // Built-in types (can also be used as functions)
                case "bool":
                case "byte":
                case "complex64":
                case "complex128":
                case "error":
                case "float32":
                case "float64":
                case "int":
                case "int8":
                case "int16":
                case "int32":
                case "int64":
                case "rune":
                case "string":
                case "uint":
                case "uint8":
                case "uint16":
                case "uint32":
                case "uint64":
                case "uintptr":
                    return name + "_";
                    break;
                default:
                    return name;
                    break;
            }

            return default;
        }

        public string PublicModuleIdProtect(string name)
        {
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_2(1273L, name, MutateCSharp.Schemata233.ReplaceStringConstant_0(1272L, "C")))
            {
                return MutateCSharp.Schemata233.ReplaceStringConstant_0(1274L, "_C");
            }
            else
            {
                return name;
            }

            return default;
        }

        protected override string FullTypeName(UserDefinedType udt, MemberDecl/*?*/ member = null)
        {
            return UserDefinedTypeName(udt, full: MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1275L, true), member: member);
        }

        private string UnqualifiedTypeName(UserDefinedType udt, MemberDecl/*?*/ member = null)
        {
            return UserDefinedTypeName(udt, full: MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1276L, false), member: member);
        }

        private string UserDefinedTypeName(UserDefinedType udt, bool full, MemberDecl/*?*/ member = null)
        {
            Contract.Requires(udt != null);
            if (udt is ArrowType)
            {
                return ArrowType.Arrow_FullCompileName;
            }
            var cl = udt.ResolvedClass;
            if (cl is TypeParameter)
            {
                return IdProtect(udt.GetCompileName(Options));
            }
            else
            {
                return UserDefinedTypeName(cl, full, member);
            }

            return default;
        }

        private string UserDefinedTypeName(TopLevelDecl cl, bool full, MemberDecl/*?*/ member = null)
        {
            var enclosingModuleDefinitionId = PublicModuleIdProtect(cl.EnclosingModuleDefinition.GetCompileName(Options));
            if (IsExternMemberOfExternModule(member, cl))
            {
                // omit the default class name ("_default") in extern modules, when the class is used to qualify an extern member
                Contract.Assert(!cl.EnclosingModuleDefinition.IsDefaultModule);  // default module is not marked ":extern"
                return enclosingModuleDefinitionId;
            }
            else
            {
                if (cl.IsExtern(Options, out var qual, out _))
                {
                    // No need to take into account the second argument to extern, since
                    // it'll already be cl.CompileName
                    if (qual == null)
                    {
                        if (MutateCSharp.Schemata233.ReplaceBinExprOp_2(1277L, this.ModuleName, enclosingModuleDefinitionId))
                        {
                            qual = "";
                        }
                        else
                        {
                            qual = enclosingModuleDefinitionId;
                        }
                    }
                    // Don't use IdName since that'll capitalize, which is unhelpful for
                    // built-in types
                    return qual + (MutateCSharp.Schemata233.ReplaceBinExprOp_2(1278L, qual, "") ? "" : MutateCSharp.Schemata233.ReplaceStringConstant_0(1279L, ".")) + cl.GetCompileName(Options);

                }
                else if (MutateCSharp.Schemata233.ReplaceBinExprOp_25(1287L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_25(1280L, () => !full, () => cl.EnclosingModuleDefinition.TryToAvoidName), () => MutateCSharp.Schemata233.ReplaceBinExprOp_2(1286L, this.ModuleName, enclosingModuleDefinitionId)))
                {
                    return IdName(cl);
                }
                else
                {
                    return enclosingModuleDefinitionId + MutateCSharp.Schemata233.ReplaceStringConstant_0(1293L, ".") + IdName(cl);
                }
            }

            return default;
        }

        private bool IsExternMemberOfExternModule(MemberDecl/*?*/ member, TopLevelDecl cl)
        {
            return MutateCSharp.Schemata233.ReplaceBinExprOp_3(1302L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_3(1295L, () => cl is DefaultClassDecl, () => Attributes.Contains(cl.EnclosingModuleDefinition.Attributes, MutateCSharp.Schemata233.ReplaceStringConstant_0(1294L, "extern"))), () => MutateCSharp.Schemata233.ReplaceBinExprOp_23(1301L, member, null)) && member.IsExtern(Options, out _, out _);
        }

        protected override void EmitThis(ConcreteSyntaxTree wr, bool callToInheritedMember)
        {
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1308L, "_this"));
        }

        protected override void EmitNull(Type type, ConcreteSyntaxTree wr)
        {
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_25(1316L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_25(1309L, () => type.IsIntegerType, () => type.IsBitVectorType), () => MutateCSharp.Schemata233.ReplaceBinExprOp_29(1315L, type.AsNewtype, null)))
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1322L, "_dafny.NilInt"));
            }
            else if (type.IsRealType)
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1323L, "_dafny.NilReal"));
            }
            else
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1324L, "({0})(nil)"), TypeName(type, wr, tok: null));
            }
        }

        protected override void EmitITE(Expression guard, Expression thn, Expression els, Type resultType, bool inLetExprBody,
            ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1325L, "(func () {0} {{ if "), TypeName(resultType, wr, null));
            wr.Append(Expr(guard, inLetExprBody, wStmts));
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1326L, " { return "));
            var wBranch = EmitCoercionIfNecessary(thn.Type, resultType, thn.tok, wr);
            wBranch.Append(Expr(thn, inLetExprBody, wStmts));
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1327L, " }; return "));
            wBranch = EmitCoercionIfNecessary(els.Type, resultType, thn.tok, wr);
            wBranch.Append(Expr(els, inLetExprBody, wStmts));
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1328L, " })() "));
        }

        protected override void EmitDatatypeValue(DatatypeValue dtv, string typeDescriptorArguments, string arguments, ConcreteSyntaxTree wr)
        {
            EmitDatatypeValue(dtv.Ctor.EnclosingDatatype, dtv.Ctor, dtv.IsCoCall, typeDescriptorArguments, arguments, wr);
        }

        void EmitDatatypeValue(DatatypeDecl dt, DatatypeCtor ctor, bool isCoCall, string typeDescriptorArguments, string arguments, ConcreteSyntaxTree wr)
        {
            var ctorName = ctor.GetCompileName(Options);
            var companionName = TypeName_Companion(dt, wr, dt.tok);

            var sep = MutateCSharp.Schemata233.ReplaceBinExprOp_3(1347L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_15(1333L, typeDescriptorArguments.Length, MutateCSharp.Schemata233.ReplaceNumericConstant_4(1329L, 0)), () => MutateCSharp.Schemata233.ReplaceBinExprOp_15(1342L, arguments.Length, MutateCSharp.Schemata233.ReplaceNumericConstant_4(1338L, 0))) ? MutateCSharp.Schemata233.ReplaceStringConstant_0(1353L, ", ") : "";
            if (dt is TupleTypeDecl)
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1354L, "_dafny.TupleOf({0})"), arguments);
            }
            else if (!isCoCall)
            {
                // Ordinary constructor (that is, one that does not guard any co-recursive calls)
                // Generate: Companion_Dt_.CreateCtor(args)
                wr.Write($"{companionName}.{FormatDatatypeConstructorName(ctorName)}({typeDescriptorArguments}{sep}{arguments})");
            }
            else
            {
                // Co-recursive call
                // Generate:  Companion_Dt_.LazyDt(func () Dt => Companion_Dt_.CreateCtor(args))
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1355L, "{0}.{1}({2}{3}func () {4} "), companionName, FormatLazyConstructorName(dt.GetCompileName(Options)),
                  typeDescriptorArguments, sep,
                  TypeName(UserDefinedType.FromTopLevelDecl(dt.tok, dt), wr, dt.tok));
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1356L, "{{ return {0}.{1}({2}{3}{4}) }}"), companionName, FormatDatatypeConstructorName(ctorName), typeDescriptorArguments, sep, arguments);
                wr.Write(')');
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
                    preString = "_dafny.ArrayLen(";
                    postString = string.Format(", {0}){1}", idParam == null ? 0 : (int)idParam,
                      id == SpecialField.ID.ArrayLengthInt ? ".Int()" : "");
                    break;
                    break;
                case SpecialField.ID.Floor:
                    compiledName = "Int()";
                    break;
                    break;
                case SpecialField.ID.IsLimit:
                    compiledName = "IsLimitOrd()";
                    break;
                    break;
                case SpecialField.ID.IsSucc:
                    compiledName = "IsSuccOrd()";
                    break;
                    break;
                case SpecialField.ID.Offset:
                    compiledName = "OrdOffset()";
                    break;
                    break;
                case SpecialField.ID.IsNat:
                    compiledName = "IsNatOrd()";
                    break;
                    break;
                case SpecialField.ID.Keys:
                    compiledName = "Keys()";
                    break;
                    break;
                case SpecialField.ID.Values:
                    compiledName = "Values()";
                    break;
                    break;
                case SpecialField.ID.Items:
                    compiledName = "Items()";
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
          Type expectedType, string/*?*/ additionalCustomParameter = null, bool internalAccess = false)
        {
            var memberStatus = DatatypeWrapperEraser.GetMemberStatus(Options, member);
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_42(1357L, memberStatus, DatatypeWrapperEraser.MemberCompileStatus.Identity))
            {
                return SimpleLvalue(obj);
            }
            else if (MutateCSharp.Schemata233.ReplaceBinExprOp_42(1358L, memberStatus, DatatypeWrapperEraser.MemberCompileStatus.AlwaysTrue))
            {
                return SimpleLvalue(w => w.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1359L, "true")));
            }
            else if (member is DatatypeDestructor dtor)
            {
                return SimpleLvalue(wr =>
                {
                    wr = EmitCoercionIfNecessary(dtor.Type, expectedType, Token.NoToken, wr);
                    if (dtor.EnclosingClass is TupleTypeDecl)
                    {
                        Contract.Assert(dtor.CorrespondingFormals.Count == 1);
                        var formal = dtor.CorrespondingFormals[MutateCSharp.Schemata233.ReplaceNumericConstant_4(1360L, 0)];
                        wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1364L, "(*("));
                        obj(wr);
                        wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1365L, ").IndexInt({0}))"), formal.NameForCompilation);
                    }
                    else
                    {
                        obj(wr);
                        wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1366L, ".{0}()"), FormatDatatypeDestructorName(dtor.GetCompileName(Options)));
                    }
                });
            }
            else if (member is SpecialField sf && MutateCSharp.Schemata233.ReplaceBinExprOp_43(1367L, sf.SpecialId, SpecialField.ID.UseIdParam))
            {
                return SimpleLvalue(wr =>
                {
                    wr = EmitCoercionIfNecessary(sf.Type, expectedType, Token.NoToken, wr);
                    obj(wr);
                    GetSpecialFieldInfo(sf.SpecialId, sf.IdParam, objType, out var compiledName, out _, out _);
                    if (MutateCSharp.Schemata233.ReplaceBinExprOp_15(1372L, compiledName.Length, MutateCSharp.Schemata233.ReplaceNumericConstant_4(1368L, 0)))
                    {
                        wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1377L, ".{0}"), Capitalize(compiledName));
                    }
                    else
                    {
                        // this member selection is handled by some kind of enclosing function call, so nothing to do here
                    }
                });
            }
            else if (member is SpecialField sf2 && sf2.SpecialId == SpecialField.ID.UseIdParam && sf2.IdParam is string fieldName && fieldName.StartsWith(MutateCSharp.Schemata233.ReplaceStringConstant_0(1378L, "is_")))
            {
                // sf2 is needed here only because the scope rules for these pattern matches are asinine: sf is *still in scope* but it's useless because it may not have been assigned to!
                return SimpleLvalue(wr =>
                {
                    wr = EmitCoercionIfNecessary(sf2.Type, expectedType, Token.NoToken, wr);
                    obj(wr);
                    // FIXME This is a pretty awful string hack.
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1379L, ".{0}()"), FormatDatatypeConstructorCheckName(fieldName.Substring(MutateCSharp.Schemata233.ReplaceNumericConstant_4(1380L, 3))));
                });
            }
            else if (member is Function fn)
            {
                typeArgs = typeArgs.Where(ta => NeedsTypeDescriptor(ta.Formal)).ToList();
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1393L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_6(1388L, typeArgs.Count, MutateCSharp.Schemata233.ReplaceNumericConstant_4(1384L, 0)), () => additionalCustomParameter == null))
                {
                    var lvalue = SuffixLvalue(obj, MutateCSharp.Schemata233.ReplaceStringConstant_0(1399L, ".{0}"), IdName(member));
                    return CoercedLvalue(lvalue, fn.GetMemberType((ArrowTypeDecl)expectedType.AsArrowType.ResolvedClass), expectedType);
                }
                else
                {
                    // We need an eta conversion to adjust for the difference in arity.
                    // func (a0 T0, a1 T1, ...) ResultType { return obj.F(rtd0, rtd1, ..., a0, a1, ...); }
                    // Start by writing to the suffix:  F(rtd0, rtd1, ...
                    var suffixWr = new ConcreteSyntaxTree();
                    suffixWr.Write(IdName(member));
                    suffixWr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1400L, "("));
                    var suffixSep = "";
                    EmitTypeDescriptorsActuals(ForTypeDescriptors(typeArgs, member.EnclosingClass, member, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1401L, false)), fn.tok, suffixWr, ref suffixSep);
                    if (additionalCustomParameter != null)
                    {
                        suffixWr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1402L, "{0}{1}"), suffixSep, additionalCustomParameter);
                        suffixSep = MutateCSharp.Schemata233.ReplaceStringConstant_0(1403L, ", ");
                    }
                    // Write the prefix and the rest of the suffix
                    var prefixWr = new ConcreteSyntaxTree();
                    var prefixSep = "";
                    prefixWr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1404L, "func ("));
                    foreach (var arg in fn.Ins)
                    {
                        if (!arg.IsGhost)
                        {
                            var name = idGenerator.FreshId(MutateCSharp.Schemata233.ReplaceStringConstant_0(1405L, "_eta"));
                            var ty = arg.Type.Subst(typeMap);
                            prefixWr.Write($"{prefixSep}{name} {TypeName(ty, prefixWr, arg.tok)}");
                            suffixWr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1406L, "{0}{1}"), suffixSep, name);
                            suffixSep = MutateCSharp.Schemata233.ReplaceStringConstant_0(1407L, ", ");
                            prefixSep = MutateCSharp.Schemata233.ReplaceStringConstant_0(1408L, ", ");
                        }
                    }
                    var resultType = fn.ResultType.Subst(typeMap);
                    prefixWr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1409L, ") {0} {{ return "), TypeName(resultType, prefixWr, fn.tok));
                    suffixWr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1410L, ")"));
                    var suffix = suffixWr.ToString();
                    return EnclosedLvalue(
                      prefixWr.ToString(),
                      wr =>
                      {
                          var wCall = EmitCoercionIfNecessary(fn.ResultType, resultType, Token.NoToken, wr: wr);
                          obj(wCall);
                          wCall.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1411L, "."));
                          wCall.Write(suffix);
                          wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1412L, "; }"));
                      },
                      "");
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
                        w.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1413L, "{0}.{1}("), TypeName_Companion(objType, w, member.tok, member), IdName(member));
                        EmitTypeDescriptorsActuals(ForTypeDescriptors(typeArgs, member.EnclosingClass, member, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1414L, false)), member.tok, w);
                        w.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1415L, ")"));
                    });
                }
                else if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1416L, () => NeedsCustomReceiver(member), () => !(member.EnclosingClass is TraitDecl)))
                {
                    // instance const in a newtype
                    Contract.Assert(typeArgs.Count == 0);
                    lvalue = SimpleLvalue(w =>
                    {
                        w.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1422L, "{0}.{1}("), TypeName_Companion(objType, w, member.tok, member), IdName(member));
                        obj(w);
                        w.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1423L, ")"));
                    });
                }
                else if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1430L, () => internalAccess, () => (MutateCSharp.Schemata233.ReplaceBinExprOp_25(1424L, () => member is ConstantField, () => member.EnclosingClass is TraitDecl))))
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
                        w.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1436L, ".{0}("), IdName(member));
                        EmitTypeDescriptorsActuals(ForTypeDescriptors(typeArgs, member.EnclosingClass, member, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1437L, false)), member.tok, w);
                        w.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1438L, ")"));
                    });
                }
                else if (member.EnclosingClass is TraitDecl)
                {
                    lvalue = GetterSetterLvalue(obj, IdName(member), $"{IdName(member)}_set_");
                }
                else
                {
                    lvalue = SuffixLvalue(obj, $".{IdName(member)}");
                }
                return CoercedLvalue(lvalue, field.Type, expectedType);
            }

            return default;
        }

        protected override string ArrayIndexToNativeInt(string s, Type type)
        {
            var nt = AsNativeType(type);
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_21(1439L, nt, null))
            {
                return $"({s}).Int()";
            }
            else
            {
                return $"int({s})";
            }

            return default;
        }

        protected override ConcreteSyntaxTree ExprToInt(Type fromType, ConcreteSyntaxTree wr)
        {
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_21(1440L, AsNativeType(fromType), null))
            {
                return wr;
            }
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1441L, "_dafny.IntOfAny"));
            return wr.ForkInParens();
        }

        /// <summary>
        /// Emit to "wr" a call
        ///     _dafny.ArrayGet( <<wArray>>, <<wArguments>> )        // if isGet
        /// or
        ///     _dafny.ArraySet( <<wArray>>, <<wArguments>> )        // if !isGet
        /// and return (wArray, wArguments). Optimize these calls based on "dimensionCount" and "elementType".
        /// "elementType" is allowed to be "null", which says to not specialize based on the element type.
        /// </summary>
        private (ConcreteSyntaxTree wArray, ConcreteSyntaxTree wArguments) CallArrayGetOrSet(bool isGet,
          int dimensionCount, [CanBeNull] Type elementType, ConcreteSyntaxTree wr)
        {

            var typeSpecialization = "";
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1452L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_6(1446L, dimensionCount, MutateCSharp.Schemata233.ReplaceNumericConstant_4(1442L, 1)), () => MutateCSharp.Schemata233.ReplaceBinExprOp_28(1451L, elementType, null)))
            {
                if (elementType.IsCharType)
                {
                    typeSpecialization = CharTypeNameProper;
                }
                else
                {
                    var nt = AsNativeType(elementType);
                    if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1460L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_19(1458L, nt, null), () => MutateCSharp.Schemata233.ReplaceBinExprOp_44(1459L, nt.Sel, NativeType.Selection.Byte)))
                    {
                        typeSpecialization = MutateCSharp.Schemata233.ReplaceStringConstant_0(1466L, "Byte");
                    }
                }
            }
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1468L, () => isGet, () => MutateCSharp.Schemata233.ReplaceBinExprOp_2(1467L, typeSpecialization, "")))
            {
                wr = EmitCoercionIfNecessary(null, elementType, Token.NoToken, wr);
            }

            ConcreteSyntaxTree wArray;
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_15(1478L, dimensionCount, MutateCSharp.Schemata233.ReplaceNumericConstant_4(1474L, 1)))
            {
                // use a general call, which uses a varargs for the indices
                wr.Write(isGet ? MutateCSharp.Schemata233.ReplaceStringConstant_0(1483L, "_dafny.ArrayGet(") : MutateCSharp.Schemata233.ReplaceStringConstant_0(1484L, "_dafny.ArraySet("));
                wArray = wr.Fork();
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1485L, ", "));
            }
            else
            {
                // specialize to a call with exactly one index argument
                wArray = wr.ForkInParens();
                wr.Write($"{(isGet ? MutateCSharp.Schemata233.ReplaceStringConstant_0(1486L, ".ArrayGet1") : MutateCSharp.Schemata233.ReplaceStringConstant_0(1487L, ".ArraySet1"))}{typeSpecialization}(");
            }
            var wArguments = wr.Fork();
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1488L, ")"));
            return (wArray, wArguments);
        }

        protected override ConcreteSyntaxTree EmitArraySelect(List<Action<ConcreteSyntaxTree>> indices, Type elmtType, ConcreteSyntaxTree wr)
        {
            // Note, the indices are formulated in the native array-index type.
            var (wArray, wArguments) = CallArrayGetOrSet(MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1489L, true), indices.Count, elmtType, wr);
            for (int i = MutateCSharp.Schemata233.ReplaceNumericConstant_4(1490L, 0); MutateCSharp.Schemata233.ReplaceBinExprOp_17(1494L, i, indices.Count); MutateCSharp.Schemata233.ReplacePostfixUnaryExprOp_14(1499L, ref i))
            {
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_13(1504L, i, MutateCSharp.Schemata233.ReplaceNumericConstant_4(1500L, 0)))
                {
                    wArguments.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1509L, ", "));
                }
                indices[i](wArguments);
            }
            return wArray;
        }

        protected override ConcreteSyntaxTree EmitArraySelect(List<Expression> indices, Type elmtType, bool inLetExprBody,
            ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            Contract.Assert(indices != null && 1 <= indices.Count);  // follows from precondition
            var (wArray, wArguments) = CallArrayGetOrSet(MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1510L, true), indices.Count, elmtType, wr);
            wArguments.Write(indices.Comma(index =>
            {
                var idx = Expr(index, inLetExprBody, wStmts).ToString();
                return ArrayIndexToNativeInt(idx, index.Type);
            }));
            return wArray;
        }

        protected override (ConcreteSyntaxTree/*array*/, ConcreteSyntaxTree/*rhs*/) EmitArrayUpdate(List<Action<ConcreteSyntaxTree>> indices, Type elementType, ConcreteSyntaxTree wr)
        {
            var (wArray, wArguments) = CallArrayGetOrSet(MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1511L, false), indices.Count, elementType, wr);
            var wRhs = wArguments.Fork();
            for (int i = MutateCSharp.Schemata233.ReplaceNumericConstant_4(1512L, 0); MutateCSharp.Schemata233.ReplaceBinExprOp_17(1516L, i, indices.Count); MutateCSharp.Schemata233.ReplacePostfixUnaryExprOp_14(1521L, ref i))
            {
                wArguments.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1522L, ", "));
                indices[i](wArguments);
            }
            return (wArray, wRhs);
        }

        protected override string ArrayIndexToInt(string arrayIndex) => $"{HelperModulePrefix}IntOf({arrayIndex})";

        protected override void EmitExprAsNativeInt(Expression expr, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (expr is LiteralExpr lit)
            {
                wr.Write(lit.Value.ToString());
            }
            else
            {
                TrParenExpr(expr, wr, inLetExprBody, wStmts);
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_21(1523L, AsNativeType(expr.Type), null))
                {
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1524L, ".Int()"));
                }
            }
        }

        // This will probably move up to the superclass once more compilers are using dafnyRuntime.dfy
        protected void TrExprToSizeT(Expression expr, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (expr is LiteralExpr lit)
            {
                wr.Write(lit.Value.ToString());
            }
            else
            {
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_21(1525L, AsNativeType(expr.Type), null))
                {
                    TrParenExpr(expr, wr, inLetExprBody, wStmts);
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1526L, ".Uint32()"));
                }
                else
                {
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1527L, "uint32("));
                    wr.Append(Expr(expr, inLetExprBody, wStmts));
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1528L, ")"));
                }
            }
        }

        protected override void EmitIndexCollectionSelect(Expression source, Expression index, bool inLetExprBody,
            ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var type = source.Type.NormalizeToAncestorType();
            if (type is SeqType seqType)
            {
                TrParenExpr(source, wr, inLetExprBody, wStmts);
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1529L, ".Select("));
                TrExprToSizeT(index, inLetExprBody, wr, wStmts);
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1530L, ").({0})"), TypeName(seqType.Arg, wr, null));
            }
            else if (type is MultiSetType)
            {
                TrParenExpr(source, wr, inLetExprBody, wStmts);
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1531L, ".Multiplicity("));
                wr.Append(Expr(index, inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1532L, ")"));
            }
            else
            {
                Contract.Assert(type is MapType);
                // map or imap
                TrParenExpr(source, wr, inLetExprBody, wStmts);
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1533L, ".Get("));
                wr.Append(Expr(index, inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1534L, ").({0})"), TypeName(((MapType)type).Range, wr, null));
            }
        }

        protected override void EmitIndexCollectionUpdate(Expression source, Expression index, Expression value,
            CollectionType resultCollectionType, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_45(1535L, resultCollectionType.AsSeqType, null))
            {
                wr.Write($"{DafnySequenceCompanion}.Update(");
                wr.Append(Expr(source, inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1536L, ", "));
                TrExprToSizeT(index, inLetExprBody, wr, wStmts);
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1537L, ", "));
                wr.Append(CoercedExpr(value, resultCollectionType.ValueArg, inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1538L, ")"));
            }
            else if (resultCollectionType.AsMapType is { } mapType)
            {
                EmitIndexCollectionUpdate(source.Type, out var wSource, out var wIndex, out var wValue, wr, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1539L, false));
                TrParenExpr(source, wSource, inLetExprBody, wSource);
                wIndex.Append(CoercedExpr(index, mapType.Domain, inLetExprBody, wSource));
                wValue.Append(CoercedExpr(value, mapType.Range, inLetExprBody, wSource));
            }
            else
            {
                Contract.Assert(resultCollectionType.AsMultiSetType != null);
                EmitIndexCollectionUpdate(source.Type, out var wSource, out var wIndex, out var wValue, wr, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1540L, false));
                TrParenExpr(source, wSource, inLetExprBody, wSource);
                wIndex.Append(CoercedExpr(index, resultCollectionType.Arg, inLetExprBody, wSource));
                wValue.Append(Expr(value, inLetExprBody, wSource));
            }
        }

        protected override void EmitIndexCollectionUpdate(Type sourceType, out ConcreteSyntaxTree wSource, out ConcreteSyntaxTree wIndex, out ConcreteSyntaxTree wValue, ConcreteSyntaxTree wr, bool nativeIndex)
        {
            if (sourceType.IsArrayType)
            {
                Contract.Assume(nativeIndex);
                (wSource, var wArguments) = CallArrayGetOrSet(MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1541L, false), MutateCSharp.Schemata233.ReplaceNumericConstant_4(1542L, 1), null, wr);
                wValue = wArguments.Fork();
                wArguments.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1546L, ", "));
                wIndex = wArguments.Fork();
            }
            else
            {
                wSource = wr.ForkInParens();
                wr.Write(nativeIndex ? MutateCSharp.Schemata233.ReplaceStringConstant_0(1547L, ".UpdateInt(") : MutateCSharp.Schemata233.ReplaceStringConstant_0(1548L, ".Update("));
                wIndex = wr.Fork();
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1549L, ", "));
                wValue = wr.Fork();
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1550L, ")"));
            }
        }

        protected override void EmitSeqSelectRange(Expression source, Expression lo /*?*/, Expression hi /*?*/,
            bool fromArray, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (fromArray)
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1551L, "_dafny.ArrayRangeToSeq("));
                wr.Append(Expr(source, inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1552L, ", "));

                if (MutateCSharp.Schemata233.ReplaceBinExprOp_46(1553L, lo, null))
                {
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1554L, "_dafny.NilInt"));
                }
                else
                {
                    TrExprToBigInt(lo, wr, inLetExprBody);
                }

                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1555L, ", "));

                if (MutateCSharp.Schemata233.ReplaceBinExprOp_46(1556L, hi, null))
                {
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1557L, "_dafny.NilInt"));
                }
                else
                {
                    TrExprToBigInt(hi, wr, inLetExprBody);
                }

                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1558L, ")"));
            }
            else
            {
                TrParenExpr(source, wr, inLetExprBody, wStmts);

                if (MutateCSharp.Schemata233.ReplaceBinExprOp_46(1559L, lo, null))
                {
                    if (MutateCSharp.Schemata233.ReplaceBinExprOp_46(1560L, hi, null))
                    {
                        return;
                    }

                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1561L, ".Take("));
                    TrExprToSizeT(hi, inLetExprBody, wr, wStmts);
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1562L, ")"));
                }
                else
                {
                    if (MutateCSharp.Schemata233.ReplaceBinExprOp_46(1563L, hi, null))
                    {
                        wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1564L, ".Drop("));
                        TrExprToSizeT(lo, inLetExprBody, wr, wStmts);
                        wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1565L, ")"));
                    }
                    else
                    {
                        wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1566L, ".Subsequence("));
                        TrExprToSizeT(lo, inLetExprBody, wr, wStmts);
                        wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1567L, ", "));
                        TrExprToSizeT(hi, inLetExprBody, wr, wStmts);
                        wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1568L, ")"));
                    }
                }
            }
        }

        void TrExprToBigInt(Expression e, ConcreteSyntaxTree wr, bool inLetExprBody)
        {
            var wStmts = wr.Fork();
            var nativeType = AsNativeType(e.Type);
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_19(1569L, nativeType, null))
            {
                wr.Write(HelperModulePrefix);
                switch (nativeType.Sel)
                {
                    case NativeType.Selection.Byte:
                        wr.Write("IntOfUint8(");
                        break;
                        break;
                    case NativeType.Selection.UShort:
                        wr.Write("IntOfUint16(");
                        break;
                        break;
                    case NativeType.Selection.UInt:
                        wr.Write("IntOfUint32(");
                        break;
                        break;
                    case NativeType.Selection.ULong:
                        wr.Write("IntOfUint64(");
                        break;
                        break;
                    case NativeType.Selection.SByte:
                        wr.Write("IntOfInt8(");
                        break;
                        break;
                    case NativeType.Selection.Short:
                        wr.Write("IntOfInt16(");
                        break;
                        break;
                    case NativeType.Selection.Int:
                        wr.Write("IntOfInt32(");
                        break;
                        break;
                    case NativeType.Selection.Long:
                        wr.Write($"IntOfInt64(");
                        break;
                        break;
                    default:
                        throw new cce.UnreachableException();  // unexpected nativeType.Selection value
                        break;
                }
            }

            TrParenExpr(e, wr, inLetExprBody, wStmts);

            if (MutateCSharp.Schemata233.ReplaceBinExprOp_19(1570L, nativeType, null))
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1571L, ")"));
            }
        }

        protected override void EmitSeqConstructionExpr(SeqConstructionExpr expr, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write($"{HelperModulePrefix}SeqCreate(");
            TrExprToSizeT(expr.N, inLetExprBody, wr, wStmts);
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1572L, ", "));
            var fromType = (ArrowType)expr.Initializer.Type.NormalizeExpand();
            var atd = (ArrowTypeDecl)fromType.ResolvedClass;
            var tParam = new UserDefinedType(expr.tok, new TypeParameter(expr.RangeToken, new Name(MutateCSharp.Schemata233.ReplaceStringConstant_0(1573L, "X")), TypeParameter.TPVarianceSyntax.NonVariant_Strict));
            var toType = new ArrowType(expr.tok, atd, new List<Type>() { Type.Int }, tParam);
            var initWr = EmitCoercionIfNecessary(fromType, toType, expr.tok, wr);
            initWr.Append(Expr(expr.Initializer, inLetExprBody, wStmts));
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1574L, ")"));
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1575L, () => fromType.Result.IsCharType, () => !UnicodeCharEnabled))
            {
                // Tag this sequence as being a string at runtime,
                // but only if --unicode-char is false.
                // See "Printing strings and characters" in docs/Compilation/StringsAndChars.md.
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1581L, ".SetString()"));
            }
        }

        protected override void EmitMultiSetFormingExpr(MultiSetFormingExpr expr, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var eeType = expr.E.Type.NormalizeToAncestorType();
            if (eeType is SeqType)
            {
                TrParenExpr(MutateCSharp.Schemata233.ReplaceStringConstant_0(1582L, "_dafny.MultiSetFromSeq"), expr.E, wr, inLetExprBody, wStmts);
            }
            else if (eeType is SetType)
            {
                TrParenExpr(MutateCSharp.Schemata233.ReplaceStringConstant_0(1583L, "_dafny.MultiSetFromSet"), expr.E, wr, inLetExprBody, wStmts);
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();
            }
        }

        protected override void EmitApplyExpr(Type functionType, IToken tok, Expression function, List<Expression> arguments,
            bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            TrParenExpr(function, wr, inLetExprBody, wStmts);
            TrExprList(arguments, wr, inLetExprBody, wStmts);
        }

        protected override ConcreteSyntaxTree EmitBetaRedex(List<string> boundVars, List<Expression> arguments,
          List<Type> boundTypes, Type type, IToken tok, bool inLetExprBody, ConcreteSyntaxTree wr,
          ref ConcreteSyntaxTree wStmts)
        {
            Contract.Assert(boundVars.Count == boundTypes.Count);
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1584L, "(func ("));
            for (int i = MutateCSharp.Schemata233.ReplaceNumericConstant_4(1585L, 0); MutateCSharp.Schemata233.ReplaceBinExprOp_17(1589L, i, boundVars.Count); MutateCSharp.Schemata233.ReplacePostfixUnaryExprOp_14(1594L, ref i))
            {
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_13(1599L, i, MutateCSharp.Schemata233.ReplaceNumericConstant_4(1595L, 0)))
                {
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1604L, ", "));
                }
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1605L, "{0} {1}"), boundVars[i], TypeName(boundTypes[i], wr, tok));
            }

            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1606L, ") {0}"), TypeName(type, wr, tok));
            var wLambdaBody = wr.NewBigExprBlock("", MutateCSharp.Schemata233.ReplaceStringConstant_0(1607L, ")"));
            var w = EmitReturnExpr(wLambdaBody);
            TrExprList(arguments, wr, inLetExprBody, wStmts);
            return w;
        }

        protected override void EmitConstructorCheck(string source, DatatypeCtor ctor, ConcreteSyntaxTree wr)
        {
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1608L, "{0}.{1}()"), source, FormatDatatypeConstructorCheckName(ctor.GetCompileName(Options)));
        }

        protected override void EmitDestructor(Action<ConcreteSyntaxTree> source, Formal dtor, int formalNonGhostIndex, DatatypeCtor ctor, List<Type> typeArgs, Type bvType, ConcreteSyntaxTree wr)
        {
            if (DatatypeWrapperEraser.IsErasableDatatypeWrapper(Options, ctor.EnclosingDatatype, out var coreDtor))
            {
                Contract.Assert(coreDtor.CorrespondingFormals.Count == 1);
                Contract.Assert(dtor == coreDtor.CorrespondingFormals[0]); // any other destructor is a ghost
                source(wr);
            }
            else if (ctor.EnclosingDatatype is TupleTypeDecl tupleTypeDecl)
            {
                Contract.Assert(tupleTypeDecl.NonGhostDims != 1); // such a tuple is an erasable-wrapper type, handled above
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1609L, "(*("));
                source(wr);
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1610L, ").IndexInt({0})).({1})"), formalNonGhostIndex, TypeName(typeArgs[formalNonGhostIndex], wr, Token.NoToken));
            }
            else
            {
                var dtorName = DatatypeFieldName(dtor, formalNonGhostIndex);
                wr = EmitCoercionIfNecessary(from: dtor.Type, to: bvType, tok: dtor.tok, wr: wr);
                source(wr);
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1611L, ".Get_().({0}).{1}"), TypeName_Constructor(ctor, wr), dtorName);
            }
        }

        protected override ConcreteSyntaxTree CreateLambda(List<Type> inTypes, IToken tok, List<string> inNames,
          Type resultType, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts, bool untyped = false)
        {
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1612L, "func ("));
            Contract.Assert(inTypes.Count == inNames.Count);  // guaranteed by precondition
            for (var i = MutateCSharp.Schemata233.ReplaceNumericConstant_4(1613L, 0); MutateCSharp.Schemata233.ReplaceBinExprOp_17(1617L, i, inNames.Count); MutateCSharp.Schemata233.ReplacePostfixUnaryExprOp_14(1622L, ref i))
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1623L, "{0}{1} {2}"), MutateCSharp.Schemata233.ReplaceBinExprOp_6(1628L, i, MutateCSharp.Schemata233.ReplaceNumericConstant_4(1624L, 0)) ? "" : MutateCSharp.Schemata233.ReplaceStringConstant_0(1633L, ", "), inNames[i], TypeName(inTypes[i], wr, tok));
            }
            var w = wr.NewExprBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(1634L, ") {0}"), TypeName(resultType, wr, tok));
            return w;
        }

        protected override void CreateIIFE(string bvName, Type bvType, IToken bvTok, Type bodyType, IToken bodyTok,
          ConcreteSyntaxTree wr, ref ConcreteSyntaxTree wStmts, out ConcreteSyntaxTree wrRhs, out ConcreteSyntaxTree wrBody)
        {
            var w = wr.NewExprBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(1635L, "func ({0} {1}) {2}"), bvName, TypeName(bvType, wr, bvTok), TypeName(bodyType, wr, bodyTok));
            wStmts = w.Fork();
            w.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1636L, "return "));
            wrBody = w.Fork();
            w.WriteLine();
            wr.Write('(');
            wrRhs = wr.Fork();
            wr.Write(')');
        }

        protected override ConcreteSyntaxTree CreateIIFE0(Type resultType, IToken resultTok, ConcreteSyntaxTree wr,
          ConcreteSyntaxTree wStmts)
        {
            var w = wr.NewBigExprBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(1637L, "func () ") + TypeName(resultType, wr, resultTok), MutateCSharp.Schemata233.ReplaceStringConstant_0(1638L, "()"));
            return w;
        }

        protected override ConcreteSyntaxTree CreateIIFE1(int source, Type resultType, IToken resultTok, string bvName,
            ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            var w = wr.NewExprBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(1639L, "func ({0} int) {1}"), bvName, TypeName(resultType, wr, resultTok));
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1640L, "({0})"), source);
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
                        wr.Write("^ ");
                        TrParenExpr(expr, wr, inLetExprBody, wStmts);
                    }
                    else
                    {
                        TrParenExpr(expr, wr, inLetExprBody, wStmts);
                        wr.Write(".Not()");
                    }
                    break;
                    break;
                case ResolvedUnaryOp.Cardinality:
                    if (expr.Type.NormalizeToAncestorType().AsSeqType != null)
                    {
                        wr.Write($"{HelperModulePrefix}IntOfUint32(");
                        TrParenExpr(expr, wr, inLetExprBody, wStmts);
                        wr.Write(".Cardinality())");
                    }
                    else
                    {
                        TrParenExpr(expr, wr, inLetExprBody, wStmts);
                        wr.Write(".Cardinality()");
                    }

                    break;
                    break;
                default:
                    Contract.Assert(false); throw new cce.UnreachableException();  // unexpected unary expression
                    break;
            }
        }

        private bool IsDirectlyComparable(Type t)
        {
            t = t.GetRuntimeType();
            return MutateCSharp.Schemata233.ReplaceBinExprOp_25(1660L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_25(1654L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_25(1648L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_25(1641L, () => t.IsBoolType, () => t.IsCharType), () => MutateCSharp.Schemata233.ReplaceBinExprOp_19(1647L, AsNativeType(t), null)), () => t.IsArrayType), () => t is UserDefinedType { ResolvedClass: ClassDecl });
        }

        private bool IsOrderedByCmp(Type t)
        {
            t = t.GetRuntimeType();
            return MutateCSharp.Schemata233.ReplaceBinExprOp_25(1684L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_25(1678L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_25(1672L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_25(1666L, () => t.IsIntegerType, () => t.IsRealType), () => t.IsBigOrdinalType), () => (t.AsBitVectorType is { NativeType: null })), () => (t.AsNewtype is { NativeType: null }));
        }

        private bool IsComparedByEquals(Type t)
        {
            t = t.GetRuntimeType();
            return MutateCSharp.Schemata233.ReplaceBinExprOp_25(1690L, () => t.IsIndDatatype, () => t is CollectionType);
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
            reverseArguments = MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1696L, false);
            truncateResult = MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1697L, false);
            convertE1_to_int = MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1698L, false);
            coerceE1 = MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1699L, false);

            switch (op)
            {
                case BinaryExpr.ResolvedOpcode.BitwiseAnd:
                    if (AsNativeType(resultType) != null)
                    {
                        opString = "&";
                    }
                    else
                    {
                        callString = "And";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.BitwiseOr:
                    if (AsNativeType(resultType) != null)
                    {
                        opString = "|";
                    }
                    else
                    {
                        callString = "Or";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.BitwiseXor:
                    if (AsNativeType(resultType) != null)
                    {
                        opString = "^";
                    }
                    else
                    {
                        callString = "Xor";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.EqCommon:
                    {
                        var eqType = DatatypeWrapperEraser.SimplifyType(Options, e0.Type);
                        if (!EqualsUpToParameters(eqType, DatatypeWrapperEraser.SimplifyType(Options, e1.Type)))
                        {
                            staticCallString = $"{HelperModulePrefix}AreEqual";
                        }
                        else if (IsOrderedByCmp(eqType))
                        {
                            callString = "Cmp";
                            postOpString = " == 0";
                        }
                        else if (IsComparedByEquals(eqType))
                        {
                            callString = "Equals";
                        }
                        else if (IsDirectlyComparable(eqType))
                        {
                            opString = "==";
                        }
                        else
                        {
                            staticCallString = $"{HelperModulePrefix}AreEqual";
                        }
                        break;
                    }

                    break;
                case BinaryExpr.ResolvedOpcode.NeqCommon:
                    {
                        var eqType = DatatypeWrapperEraser.SimplifyType(Options, e0.Type);
                        if (!EqualsUpToParameters(eqType, DatatypeWrapperEraser.SimplifyType(Options, e1.Type)))
                        {
                            preOpString = "!";
                            staticCallString = $"{HelperModulePrefix}AreEqual";
                        }
                        else if (IsDirectlyComparable(eqType))
                        {
                            opString = "!=";
                            postOpString = "/* dircomp */";
                        }
                        else if (IsOrderedByCmp(eqType))
                        {
                            callString = "Cmp";
                            postOpString = " != 0";
                        }
                        else if (IsComparedByEquals(eqType))
                        {
                            preOpString = "!";
                            callString = "Equals";
                        }
                        else
                        {
                            preOpString = "!";
                            staticCallString = $"{HelperModulePrefix}AreEqual";
                        }
                        break;
                    }

                    break;
                case BinaryExpr.ResolvedOpcode.Lt:
                    if (IsOrderedByCmp(e0.Type))
                    {
                        callString = "Cmp";
                        postOpString = " < 0";
                    }
                    else
                    {
                        opString = "<";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Le:
                    if (IsOrderedByCmp(e0.Type))
                    {
                        callString = "Cmp";
                        postOpString = " <= 0";
                    }
                    else
                    {
                        opString = "<=";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Ge:
                    if (IsOrderedByCmp(e0.Type))
                    {
                        callString = "Cmp";
                        postOpString = " >= 0";
                    }
                    else
                    {
                        opString = ">=";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Gt:
                    if (IsOrderedByCmp(e0.Type))
                    {
                        callString = "Cmp";
                        postOpString = " > 0";
                    }
                    else
                    {
                        opString = ">";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.LeftShift:
                    if (resultType.NormalizeToAncestorType().IsBitVectorType)
                    {
                        truncateResult = true;
                    }
                    if (AsNativeType(resultType) != null)
                    {
                        opString = "<<";
                        if (AsNativeType(e1.Type) == null)
                        {
                            postOpString = ".Uint64()";
                        }
                    }
                    else
                    {
                        if (AsNativeType(e1.Type) != null)
                        {
                            callString = "Lsh(_dafny.IntOfUint64(uint64";
                            postOpString = "))";
                        }
                        else
                        {
                            callString = "Lsh";
                        }
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.RightShift:
                    if (AsNativeType(resultType) != null)
                    {
                        opString = ">>";
                        if (AsNativeType(e1.Type) == null)
                        {
                            postOpString = ".Uint64()";
                        }
                    }
                    else
                    {
                        if (AsNativeType(e1.Type) != null)
                        {
                            callString = "Rsh(_dafny.IntOfUint64(uint64";
                            postOpString = "))";
                        }
                        else
                        {
                            callString = "Rsh";
                        }
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Add:
                    if (resultType.NormalizeToAncestorType().IsBitVectorType)
                    {
                        truncateResult = true;
                    }
                    if (resultType.IsCharType || AsNativeType(resultType) != null)
                    {
                        opString = "+";
                    }
                    else
                    {
                        callString = "Plus";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Sub:
                    if (resultType.NormalizeToAncestorType().IsBitVectorType)
                    {
                        truncateResult = true;
                    }
                    if (AsNativeType(resultType) != null)
                    {
                        if (AsNativeType(resultType).LowerBound == BigInteger.Zero)
                        {
                            // Go is a PITA about subtracting unsigned integers---it complains
                            // if they're constant and the substraction underflows.  Hiding
                            // one of the arguments behind a thunk is kind of hideous but
                            // it does prevent constant folding.
                            opString = string.Format("- (func () {0} {{ return ", GetNativeTypeName(AsNativeType(resultType)));
                            postOpString = " })()";
                        }
                        else
                        {
                            opString = "-";
                        }
                    }
                    else if (resultType.IsCharType)
                    {
                        opString = "-";
                    }
                    else
                    {
                        callString = "Minus";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Mul:
                    if (resultType.NormalizeToAncestorType().IsBitVectorType)
                    {
                        truncateResult = true;
                    }
                    if (AsNativeType(resultType) != null)
                    {
                        opString = "*";
                    }
                    else
                    {
                        callString = "Times";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Div:
                    if (AsNativeType(resultType) != null)
                    {
                        var nt = AsNativeType(resultType);
                        if (nt.LowerBound < BigInteger.Zero)
                        {
                            // Want Euclidean division for signed types
                            staticCallString = "_dafny.Div" + Capitalize(GetNativeTypeName(AsNativeType(resultType)));
                        }
                        else
                        {
                            // Native division is fine for unsigned
                            opString = "/";
                        }
                    }
                    else
                    {
                        callString = "DivBy";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.Mod:
                    if (AsNativeType(resultType) != null)
                    {
                        var nt = AsNativeType(resultType);
                        if (nt.LowerBound < BigInteger.Zero)
                        {
                            // Want Euclidean division for signed types
                            staticCallString = "_dafny.Mod" + Capitalize(GetNativeTypeName(AsNativeType(resultType)));
                        }
                        else
                        {
                            // Native division is fine for unsigned
                            opString = "%";
                        }
                    }
                    else
                    {
                        callString = "Modulo";
                    }
                    break;
                    break;
                case BinaryExpr.ResolvedOpcode.SetEq:
                case BinaryExpr.ResolvedOpcode.MultiSetEq:
                case BinaryExpr.ResolvedOpcode.MapEq:
                    callString = "Equals"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.SeqEq:
                    staticCallString = $"{DafnySequenceCompanion}.Equal"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.ProperSubset:
                case BinaryExpr.ResolvedOpcode.ProperMultiSubset:
                    callString = "IsProperSubsetOf"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Subset:
                case BinaryExpr.ResolvedOpcode.MultiSubset:
                    callString = "IsSubsetOf"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Disjoint:
                case BinaryExpr.ResolvedOpcode.MultiSetDisjoint:
                    callString = "IsDisjointFrom"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.InSet:
                case BinaryExpr.ResolvedOpcode.InMultiSet:
                case BinaryExpr.ResolvedOpcode.InMap:
                    callString = "Contains"; reverseArguments = true; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Union:
                case BinaryExpr.ResolvedOpcode.MultiSetUnion:
                    callString = "Union"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.MapMerge:
                    callString = "Merge"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Intersection:
                case BinaryExpr.ResolvedOpcode.MultiSetIntersection:
                    callString = "Intersection"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.SetDifference:
                case BinaryExpr.ResolvedOpcode.MultiSetDifference:
                    callString = "Difference"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.MapSubtraction:
                    callString = "Subtract"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.ProperPrefix:
                    staticCallString = $"{DafnySequenceCompanion}.IsProperPrefixOf"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Prefix:
                    staticCallString = $"{DafnySequenceCompanion}.IsPrefixOf"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.Concat:
                    staticCallString = $"{DafnySequenceCompanion}.Concatenate"; break;
                    break;
                case BinaryExpr.ResolvedOpcode.InSeq:
                    staticCallString = $"{DafnySequenceCompanion}.Contains"; reverseArguments = true; break;
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
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1700L, "{0}.Cmp(_dafny.Zero) == 0"), varName);
        }

        protected override void EmitConversionExpr(Expression fromExpr, Type fromType, Type toType, bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (toType.Equals(fromType))
            {
                TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
            }
            else if (MutateCSharp.Schemata233.ReplaceBinExprOp_25(1713L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_25(1707L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_25(1701L, () => fromType.IsNumericBased(Type.NumericPersuasion.Int), () => fromType.NormalizeToAncestorType().IsBitVectorType), () => fromType.IsCharType), () => fromType.IsBigOrdinalType))
            {
                if (toType.IsNumericBased(Type.NumericPersuasion.Real))
                {
                    // (int or bv or char) -> real
                    Contract.Assert(AsNativeType(toType) == null);
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1719L, "_dafny.RealOfFrac("));
                    ConcreteSyntaxTree w;
                    if (fromType.IsCharType)
                    {
                        wr.Write($"{HelperModulePrefix}IntOfInt32(rune");
                        w = wr.Fork();
                        wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1720L, ")"));
                    }
                    else if (AsNativeType(fromType) is NativeType nt)
                    {
                        wr.Write($"{HelperModulePrefix}IntOf{Capitalize(GetNativeTypeName(nt))}(");
                        w = wr.Fork();
                        wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1721L, ")"));
                    }
                    else
                    {
                        w = wr;
                    }
                    TrParenExpr(fromExpr, w, inLetExprBody, wStmts);
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1722L, ", _dafny.One)"));
                }
                else if (toType.IsCharType)
                {
                    if (fromType.IsCharType)
                    {
                        EmitExpr(fromExpr, inLetExprBody, wr, wStmts);
                    }
                    else
                    {
                        wr.Write($"{CharTypeName}(");
                        TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                        if (MutateCSharp.Schemata233.ReplaceBinExprOp_21(1723L, AsNativeType(fromType), null))
                        {
                            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1724L, ".Int32()"));
                        }
                        wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1725L, ")"));
                    }
                }
                else
                {
                    // (int or bv or char) -> (int or bv or ORDINAL)
                    var fromNative = AsNativeType(fromType);
                    var toNative = AsNativeType(toType);
                    if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1728L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_19(1726L, fromNative, null), () => MutateCSharp.Schemata233.ReplaceBinExprOp_19(1727L, toNative, null)))
                    {
                        // from a native, to a native -- simple!
                        wr.Write(GetNativeTypeName(toNative));
                        TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                    }
                    else if (fromType.IsCharType)
                    {
                        Contract.Assert(fromNative == null);
                        if (MutateCSharp.Schemata233.ReplaceBinExprOp_21(1734L, toNative, null))
                        {
                            // char -> big-integer (int or bv or ORDINAL)
                            wr.Write($"{HelperModulePrefix}IntOfInt32(rune(");
                            wr.Append(Expr(fromExpr, inLetExprBody, wStmts));
                            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1735L, "))"));
                        }
                        else
                        {
                            // char -> native
                            wr.Write(GetNativeTypeName(toNative));
                            TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                        }
                    }
                    else if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1738L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_21(1736L, fromNative, null), () => MutateCSharp.Schemata233.ReplaceBinExprOp_21(1737L, toNative, null)))
                    {
                        // big-integer (int or bv) -> big-integer (int or bv or ORDINAL), so identity will do
                        wr.Append(Expr(fromExpr, inLetExprBody, wStmts));
                    }
                    else if (MutateCSharp.Schemata233.ReplaceBinExprOp_19(1744L, fromNative, null))
                    {
                        Contract.Assert(toNative == null); // follows from other checks
                                                           // native (int or bv) -> big-integer (int or bv)
                        wr.Write($"{HelperModulePrefix}IntOf{Capitalize(GetNativeTypeName(fromNative))}(");
                        wr.Append(Expr(fromExpr, inLetExprBody, wStmts));
                        wr.Write(')');
                    }
                    else
                    {
                        // any (int or bv) -> native (int or bv)
                        // Consider some optimizations
                        var literal = PartiallyEvaluate(fromExpr);
                        UnaryOpExpr u = fromExpr.Resolved as UnaryOpExpr;
                        MemberSelectExpr m = fromExpr.Resolved as MemberSelectExpr;
                        if (literal != null)
                        {
                            // Optimize constant to avoid intermediate BigInteger
                            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1745L, "{0}({1})"), GetNativeTypeName(toNative), literal);
                        }
                        else if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1748L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_47(1746L, u, null), () => MutateCSharp.Schemata233.ReplaceBinExprOp_48(1747L, u.Op, UnaryOpExpr.Opcode.Cardinality)))
                        {
                            // Optimize .Count to avoid intermediate BigInteger
                            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1754L, "{0}("), GetNativeTypeName(toNative));
                            TrParenExpr(u.E, wr, inLetExprBody, wStmts);
                            wr.Write(MutateCSharp.Schemata233.ReplaceBinExprOp_45(1755L, u.E.Type.NormalizeToAncestorType().AsSeqType, null) ? MutateCSharp.Schemata233.ReplaceStringConstant_0(1756L, ".Cardinality())") : MutateCSharp.Schemata233.ReplaceStringConstant_0(1757L, ".CardinalityInt())"));
                        }
                        else if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1767L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_3(1761L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_49(1758L, m, null), () => MutateCSharp.Schemata233.ReplaceBinExprOp_2(1760L, m.MemberName, MutateCSharp.Schemata233.ReplaceStringConstant_0(1759L, "Length"))), () => m.Obj.Type.IsArrayType))
                        {
                            // Optimize .Length to avoid intermediate BigInteger
                            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1773L, "{0}(_dafny.ArrayLenInt("), GetNativeTypeName(toNative));
                            wr.Append(Expr(m.Obj, inLetExprBody, wStmts));
                            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1774L, ", 0))"));
                        }
                        else
                        {
                            // no optimization applies; use the standard translation
                            TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1775L, ".{0}()"), Capitalize(GetNativeTypeName(toNative)));
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
                    wr.Write($"{CharTypeName}(");
                    TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1776L, ".Int().Int32())"));
                }
                else
                {
                    // real -> (int or bv)
                    TrParenExpr(fromExpr, wr, inLetExprBody, wStmts);
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1777L, ".Int()"));
                    if (AsNativeType(toType) is NativeType nt)
                    {
                        wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1778L, ".{0}()"), Capitalize(GetNativeTypeName(nt)));
                    }
                }
            }
            else if (MutateCSharp.Schemata233.ReplaceBinExprOp_25(1787L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_25(1780L, () => fromType.Equals(toType), () => MutateCSharp.Schemata233.ReplaceBinExprOp_29(1779L, fromType.AsNewtype, null)), () => MutateCSharp.Schemata233.ReplaceBinExprOp_29(1786L, toType.AsNewtype, null)))
            {
                wr.Append(Expr(fromExpr, inLetExprBody, wStmts));
            }
            else
            {
                Contract.Assert(false, $"not implemented for go: {fromType} -> {toType}");
            }
        }

        protected override void EmitTypeTest(string localName, Type fromType, Type toType, IToken tok, ConcreteSyntaxTree wr)
        {
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1793L, () => fromType.IsRefType, () => !fromType.IsNonNullRefType))
            {
                Contract.Assert(toType.IsRefType);
                if (toType.IsNonNullRefType)
                {
                    wr.Write($"!_dafny.IsDafnyNull({localName}) && ");
                }
                else
                {
                    wr.Write($"_dafny.IsDafnyNull({localName}) || ");
                }
            }

            if (fromType.IsSubtypeOf(toType, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1799L, true), MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1800L, true)))
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1801L, "true"));
            }
            else if (toType.IsTraitType)
            {
                wr.Write($"{HelperModulePrefix}InstanceOfTrait({localName}.(_dafny.TraitOffspring), {TypeName_Companion(toType.AsTraitType, wr, tok)}.TraitID_)");
            }
            else if (toType.IsRefType)
            {
                wr.Write($"{HelperModulePrefix}InstanceOf({localName}, ({TypeName(toType, wr, tok)})(nil))");
            }
            else if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1803L, () => fromType.IsTraitType, () => MutateCSharp.Schemata233.ReplaceBinExprOp_29(1802L, toType.AsNewtype, null)))
            {
                wr.Write($"{HelperModulePrefix}InstanceOf({localName}, (*{ClassName(toType, wr, tok)})(nil))");
            }
            else
            {
                wr.Write($"{HelperModulePrefix}InstanceOf({localName}, {TypeName(toType, wr, tok)}{{}})");
            }
        }

        protected override void EmitIsIntegerTest(Expression source, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            EmitExpr(source, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1809L, false), wr.ForkInParens(), wStmts);
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1810L, ".IsInteger() && "));
        }

        protected override void EmitIsUnicodeScalarValueTest(Expression source, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1811L, "_dafny.IsCodePoint"));
            EmitExpr(source, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1812L, false), wr.ForkInParens(), wStmts);
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1813L, " && "));
        }

        protected override void EmitIsInIntegerRange(Expression source, BigInteger lo, BigInteger hi, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            EmitLiteralExpr(wr, new LiteralExpr(source.tok, lo) { Type = Type.Int });
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1814L, ".Cmp("));
            EmitExpr(source, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1815L, false), wr.ForkInParens(), wStmts);
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1816L, ") <= 0 && "));

            EmitExpr(source, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1817L, false), wr.ForkInParens(), wStmts);
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1818L, ".Cmp("));
            EmitLiteralExpr(wr, new LiteralExpr(source.tok, hi) { Type = Type.Int });
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1819L, ") < 0 && "));
        }

        private static bool EqualsUpToParameters(Type type1, Type type2)
        {
            // TODO Consider whether Type.SameHead should return true in this case
            return MutateCSharp.Schemata233.ReplaceBinExprOp_25(1826L, () => Type.SameHead(type1, type2), () => (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1820L, () => type1.IsArrayType, () => type1.IsArrayType)));
        }

        protected override ConcreteSyntaxTree FromFatPointer(Type type, ConcreteSyntaxTree wr)
        {
            if (type.HasFatPointer)
            {
                var w = wr.ForkInParens();
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1832L, "._value"));
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
                wr.Write(TypeName_Initializer(type, wr, type.AsNewtype.tok));
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
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_28(1833L, toOrig, null))
            {
                to = toOrig;
            }

            if (MutateCSharp.Schemata233.ReplaceBinExprOp_50(1834L, to, null))
            {
                return wr;
            }

            if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1843L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_3(1836L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_28(1835L, from, null), () => from.IsTraitType), () => MutateCSharp.Schemata233.ReplaceBinExprOp_29(1842L, to.AsNewtype, null)))
            {
                wr = FromFatPointer(to, wr);
                var w = wr.ForkInParens();
                wr.Write($".(*{UserDefinedTypeName(to.AsNewtype, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1849L, true))})");
                return w;
            }
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1872L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_3(1858L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_3(1852L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_28(1850L, from, null), () => MutateCSharp.Schemata233.ReplaceBinExprOp_29(1851L, from.AsNewtype, null)), () => to.IsTraitType), () => (MutateCSharp.Schemata233.ReplaceBinExprOp_25(1866L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_1(1864L, enclosingMethod, null), () => MutateCSharp.Schemata233.ReplaceBinExprOp_51(1865L, enclosingFunction, null)))))
            {
                return ToFatPointer(from, wr);
            }

            from = MutateCSharp.Schemata233.ReplaceBinExprOp_50(1878L, from, null) ? null : DatatypeWrapperEraser.SimplifyType(Options, from);
            to = DatatypeWrapperEraser.SimplifyType(Options, to);
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1892L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_3(1886L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_3(1880L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_28(1879L, from, null), () => from.IsArrowType), () => to.IsArrowType), () => !from.Equals(to)))
            {
                // Need to convert functions more often, so do this before the
                // EqualsUpToParameters check below
                ArrowType fat = from.AsArrowType, tat = to.AsArrowType;
                // We must wrap the whole conversion in an IIFE to avoid capturing the source expression
                var bvName = idGenerator.FreshId(MutateCSharp.Schemata233.ReplaceStringConstant_0(1898L, "coer"));
                // Nothing interesting should be written to wStmts
                var blackHole = new ConcreteSyntaxTree();
                CreateIIFE(bvName, fat, tok, tat, tok, wr, ref blackHole, out var ans, out wr);

                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1899L, "func ("));
                var sep = "";
                var args = new List<string>();
                foreach (Type toArgType in tat.Args)
                {
                    var arg = idGenerator.FreshId(MutateCSharp.Schemata233.ReplaceStringConstant_0(1900L, "arg"));
                    args.Add(arg);
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1901L, "{0}{1} {2}"), sep, arg, TypeName(toArgType, wr, tok));
                    sep = MutateCSharp.Schemata233.ReplaceStringConstant_0(1902L, ", ");
                }
                wr.Write(')');
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_28(1903L, tat.Result, null))
                {
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1904L, " {0}"), TypeName(tat.Result, wr, tok));
                }
                var wBody = wr.NewExprBlock("");
                ConcreteSyntaxTree wCall;
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_50(1905L, fat.Result, null))
                {
                    wCall = wBody;
                }
                else
                {
                    wBody.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1906L, "return "));
                    wCall = EmitCoercionIfNecessary(@from: fat.Result, to: tat.Result, tok: tok, wr: wBody);
                }
                wCall.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1907L, "{0}("), bvName);
                Contract.Assert(fat.Args.Count == tat.Args.Count);
                sep = "";
                for (int i = MutateCSharp.Schemata233.ReplaceNumericConstant_4(1908L, 0); MutateCSharp.Schemata233.ReplaceBinExprOp_17(1912L, i, fat.Args.Count); MutateCSharp.Schemata233.ReplacePostfixUnaryExprOp_14(1917L, ref i))
                {
                    var fromArgType = fat.Args[i];
                    var toArgType = tat.Args[i];
                    wCall.Write(sep);
                    var w = EmitCoercionIfNecessary(@from: toArgType, to: fromArgType, tok: tok, wr: wCall);
                    w.Write(args[i]);
                    sep = MutateCSharp.Schemata233.ReplaceStringConstant_0(1918L, ", ");
                }
                wCall.Write(')');
                wBody.WriteLine();
                return ans;
            }
            else if (MutateCSharp.Schemata233.ReplaceBinExprOp_25(1926L, () => to.IsTypeParameter, () => (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1920L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_28(1919L, from, null), () => EqualsUpToParameters(from, to)))))
            {
                // do nothing
                return wr;
            }
            else if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1935L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_28(1932L, from, null), () => from.IsSubtypeOf(to, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1933L, true), MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1934L, true))))
            {
                // upcast
                return wr;
            }
            else if (MutateCSharp.Schemata233.ReplaceBinExprOp_25(1950L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_25(1942L, () => MutateCSharp.Schemata233.ReplaceBinExprOp_50(1941L, from, null), () => from.IsTypeParameter), () => to.IsSubtypeOf(from, MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1948L, true), MutateCSharp.Schemata233.ReplaceBooleanConstant_7(1949L, true))))
            {
                // downcast (allowed?) or implicit cast from parameter
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_25(1956L, () => to.IsObjectQ, () => to.IsObject))
                {
                    // a cast to any can be omitted
                    return wr;
                }
                else if (to.IsTraitType)
                {
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1962L, "{0}.CastTo_("), TypeName_Companion(to.AsTraitType, wr, tok));
                    var w = wr.Fork();
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1963L, ")"));
                    return w;
                }
                else if (to.IsArrayType)
                {
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1964L, "_dafny.ArrayCastTo("));
                    var w = wr.Fork();
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1965L, ")"));
                    return w;
                }
                else
                {
                    var w = wr.Fork();
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1966L, ".({0})"), TypeName(to, wr, tok));
                    return w;
                }
            }
            else if (from.AsNewtype is { } fromNewtypeDecl)
            {
                var subst = TypeParameter.SubstitutionMap(fromNewtypeDecl.TypeArgs, from.TypeArgs);
                from = fromNewtypeDecl.BaseType.Subst(subst);
                return EmitCoercionIfNecessary(from, to, tok, wr, toOrig);
            }
            else
            {
                // It's unclear to me whether it's possible to hit this case with a valid Dafny program,
                // so I'm not using UnsupportedFeatureError for now.
                Error(GeneratorErrors.ErrorId.c_Go_infeasible_conversion, tok, MutateCSharp.Schemata233.ReplaceStringConstant_0(1967L, "Cannot convert from {0} to {1}"), wr, from, to);
                return wr;
            }

            return default;
        }

        protected override ConcreteSyntaxTree EmitCoercionToNativeInt(ConcreteSyntaxTree wr)
        {
            var w = wr.Fork();
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1968L, ".(int)"));
            return w;
        }

        protected override ConcreteSyntaxTree EmitCoercionToArbitraryTuple(ConcreteSyntaxTree wr)
        {
            var w = wr.Fork();
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1969L, ".(_dafny.Tuple)"));
            return w;
        }

        protected override void EmitCollectionDisplay(CollectionType ct, IToken tok, List<Expression> elements,
            bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            if (ct is SetType)
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1970L, "_dafny.SetOf"));
            }
            else if (ct is MultiSetType)
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1971L, "_dafny.MultiSetOf"));
            }
            else
            {
                Contract.Assert(ct is SeqType);  // follows from precondition
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_3(1972L, () => ct.Arg.IsCharType, () => !UnicodeCharEnabled))
                {
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1978L, "_dafny.SeqOfChars"));
                }
                else
                {
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1979L, "_dafny.SeqOf"));
                }
            }
            TrExprList(elements, wr, inLetExprBody, wStmts, typeAt: _ => ct.Arg);
        }

        protected override void EmitMapDisplay(MapType mt, IToken tok, List<ExpressionPair> elements,
            bool inLetExprBody, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1980L, "_dafny.NewMapBuilder().ToMap()"));
            foreach (ExpressionPair p in elements)
            {
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1981L, ".UpdateUnsafe("));
                wr.Append(Expr(p.A, inLetExprBody, wStmts));
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1982L, ", "));
                wr.Append(Expr(p.B, inLetExprBody, wStmts));
                wr.Write(')');
            }
        }

        protected override void EmitSetBuilder_New(ConcreteSyntaxTree wr, SetComprehension e, string collectionName)
        {
            var wrVarInit = DeclareLocalVar(collectionName, null, null, wr);
            wrVarInit.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1983L, "_dafny.NewBuilder()"));
        }

        protected override void EmitMapBuilder_New(ConcreteSyntaxTree wr, MapComprehension e, string collectionName)
        {
            var wrVarInit = DeclareLocalVar(collectionName, null, null, wr);
            wrVarInit.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1984L, "_dafny.NewMapBuilder()"));
        }

        protected override void EmitSetBuilder_Add(CollectionType ct, string collName, Expression elmt, bool inLetExprBody, ConcreteSyntaxTree wr)
        {
            Contract.Assume(ct is SetType || ct is MultiSetType);  // follows from precondition
            var wStmts = wr.Fork();
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1985L, "{0}.Add("), collName);
            wr.Append(Expr(elmt, inLetExprBody, wStmts));
            wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(1986L, ")"));
        }

        protected override ConcreteSyntaxTree EmitMapBuilder_Add(MapType mt, IToken tok, string collName, Expression term, bool inLetExprBody, ConcreteSyntaxTree wr)
        {
            var wStmts = wr.Fork();
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1987L, "{0}.Add("), collName);
            var termLeftWriter = wr.Fork();
            wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1988L, ","));
            wr.Append(Expr(term, inLetExprBody, wStmts));
            wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(1989L, ")"));
            return termLeftWriter;
        }

        protected override void GetCollectionBuilder_Build(CollectionType ct, IToken tok, string collName,
          ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmt)
        {
            if (ct is SetType)
            {
                wr.Write(collName + MutateCSharp.Schemata233.ReplaceStringConstant_0(1990L, ".ToSet()"));
            }
            else
            {
                Contract.Assert(ct is MapType);
                wr.Write(collName + MutateCSharp.Schemata233.ReplaceStringConstant_0(1991L, ".ToMap()"));
            }
        }

        protected override (Type, Action<ConcreteSyntaxTree>) EmitIntegerRange(Type type, Action<ConcreteSyntaxTree> wLo, Action<ConcreteSyntaxTree> wHi)
        {
            Type result;
            if (MutateCSharp.Schemata233.ReplaceBinExprOp_19(1992L, AsNativeType(type), null))
            {
                result = type;
            }
            else
            {
                result = new IntType();
            }

            return (result, (wr) =>
            {
                if (MutateCSharp.Schemata233.ReplaceBinExprOp_19(1993L, AsNativeType(type), null))
                {
                    wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1994L, "{0}.IntegerRange("), TypeName_Companion(type.AsNewtype, wr, tok: Token.NoToken));
                }
                else
                {
                    wr.Write($"{HelperModulePrefix}IntegerRange(");
                }

                wLo(wr);
                wr.Write(MutateCSharp.Schemata233.ReplaceStringConstant_0(1995L, ", "));
                wHi(wr);
                wr.Write(')');
            }
            );
        }

        protected override void EmitSingleValueGenerator(Expression e, bool inLetExprBody, string type, ConcreteSyntaxTree wr, ConcreteSyntaxTree wStmts)
        {
            TrParenExpr(MutateCSharp.Schemata233.ReplaceStringConstant_0(1996L, "_dafny.SingleValue"), e, wr, inLetExprBody, wStmts);
        }

        protected override void EmitHaltRecoveryStmt(Statement body, string haltMessageVarName, Statement recoveryBody, ConcreteSyntaxTree wr)
        {
            var funcBlock = wr.NewBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(1997L, "func()"), close: BlockStyle.Brace);
            var deferBlock = funcBlock.NewBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(1998L, "defer func()"), close: BlockStyle.Brace);
            var ifRecoverBlock = deferBlock.NewBlock(MutateCSharp.Schemata233.ReplaceStringConstant_0(1999L, "if r := recover(); r != nil"));
            var stringMaker = UnicodeCharEnabled ? MutateCSharp.Schemata233.ReplaceStringConstant_0(2000L, "UnicodeSeqOfUtf8Bytes") : MutateCSharp.Schemata233.ReplaceStringConstant_0(2001L, "SeqOfString");
            ifRecoverBlock.WriteLine($"var {haltMessageVarName} = {HelperModulePrefix}{stringMaker}(r.(string))");
            TrStmt(recoveryBody, ifRecoverBlock);
            funcBlock.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(2002L, "()"));
            TrStmt(body, funcBlock);
            wr.WriteLine(MutateCSharp.Schemata233.ReplaceStringConstant_0(2003L, "()"));
        }
    }
}
