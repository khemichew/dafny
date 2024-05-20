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
using Bpl = Microsoft.Boogie;
using BplParser = Microsoft.Boogie.Parser;
using System.Text;
using System.Threading;
using DafnyCore;
using Microsoft.Boogie;
using static Microsoft.Dafny.Util;
using DafnyCore.Verifier;
using Microsoft.Dafny.Triggers;
using PODesc = Microsoft.Dafny.ProofObligationDescription;
using static Microsoft.Dafny.GenericErrors;
namespace MutateCSharp
{
    internal class Schemata487
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT487");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_40(long mutantId, Microsoft.Dafny.Function argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_57(long mutantId, Microsoft.Dafny.ICallable argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_41(long mutantId, Microsoft.Boogie.Implementation argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_75(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 >= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 > argument2; }
            return argument1 >= argument2;
        }

        internal static bool ReplaceBinExprOp_78(long mutantId, Microsoft.Dafny.BoogieGenerator.CustomFuelSettings argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_64(long mutantId, Microsoft.Dafny.TypeSynonymDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_29(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_66(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_24(long mutantId, Microsoft.Dafny.MapType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_76(long mutantId, Microsoft.Dafny.LiteralExpr argument1, object argument2)
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

        internal static bool ReplaceBinExprOp_43(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_91(long mutantId, Microsoft.Boogie.Trigger argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_70(long mutantId, Microsoft.Dafny.IteratorDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_46(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_48(long mutantId, Microsoft.Dafny.BoogieGenerator.IsAllocType argument1, Microsoft.Dafny.BoogieGenerator.IsAllocType argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_67(long mutantId, Microsoft.Dafny.Field argument1, Microsoft.Dafny.Field argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_58(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_62(long mutantId, Microsoft.Dafny.TypeParameter.ParentType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_38(long mutantId, Microsoft.Dafny.Function argument1, Microsoft.Dafny.Function argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_42(long mutantId, Microsoft.Dafny.BoogieGenerator.ExpressionTranslator argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static bool ReplaceBinExprOp_51(long mutantId, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument1, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_28(long mutantId, Microsoft.Dafny.CoDatatypeDecl argument1, Microsoft.Dafny.CoDatatypeDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_68(long mutantId, Microsoft.Dafny.UserDefinedType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_84(long mutantId, System.Collections.Generic.Stack<Microsoft.Dafny.BoogieGenerator.FuelContext> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_30(long mutantId, Microsoft.Boogie.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_83(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_34(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_86(long mutantId, Microsoft.Dafny.TypeParameter argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_44(long mutantId, System.Collections.Generic.Dictionary<Microsoft.Dafny.IVariable, Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_32(long mutantId, Microsoft.Boogie.Expr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_61(long mutantId, Microsoft.Dafny.CommonOptionBag.AssertionShowMode argument1, Microsoft.Dafny.CommonOptionBag.AssertionShowMode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_26(long mutantId, Microsoft.Dafny.SeqType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Boogie.TypeSynonymDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_71(long mutantId, Microsoft.Dafny.Field argument1, Microsoft.Dafny.SpecialField argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_36(long mutantId, Microsoft.Boogie.Type argument1, Microsoft.Boogie.Type argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_50(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.CasePattern<Microsoft.Dafny.BoundVar>> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_60(long mutantId, Microsoft.Dafny.CommonOptionBag.AssertionShowMode argument1, Microsoft.Dafny.CommonOptionBag.AssertionShowMode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_52(long mutantId, Microsoft.Dafny.FrameExpressionUse argument1, Microsoft.Dafny.FrameExpressionUse argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_35(long mutantId, Microsoft.Dafny.BoundVar argument1, Microsoft.Dafny.IVariable argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_59(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_37(long mutantId, Microsoft.Dafny.Declaration argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Boogie.TypeCtorDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Boogie.Constant argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_74(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_72(long mutantId, System.Collections.Generic.List<Microsoft.Boogie.Function> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Boogie.GlobalVariable argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_81(long mutantId, Microsoft.Dafny.Function argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_56(long mutantId, System.Func<Microsoft.Dafny.IToken, bool> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_82(long mutantId, Microsoft.Dafny.BoogieGenerator.FuelSettingPair argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_88(long mutantId, Microsoft.Dafny.FunctionCallExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_65(long mutantId, Microsoft.Dafny.NewtypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_47(long mutantId, Microsoft.Boogie.Variable argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, Microsoft.Dafny.TopLevelDeclWithMembers argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_89(long mutantId, Microsoft.Dafny.ThisExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_90(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_23(long mutantId, Microsoft.Dafny.SetType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_87(long mutantId, Microsoft.Dafny.LetExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_55(long mutantId, Microsoft.Dafny.BoogieGenerator.ForceCheckToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, Microsoft.Dafny.NonNullTypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Boogie.Program argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_27(long mutantId, Microsoft.Dafny.CoDatatypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_6(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_80(long mutantId, Microsoft.Dafny.MemberSelectExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_8(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_54(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_79(long mutantId, System.Collections.Generic.List<System.Collections.Generic.List<Microsoft.Dafny.Expression>> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_49(long mutantId, Microsoft.Dafny.BoundVar argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_31(long mutantId, Microsoft.Boogie.Expr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, Microsoft.Boogie.QKeyValue argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Boogie.Program argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_73(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static int ReplaceBinExprOp_77(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_25(long mutantId, Microsoft.Dafny.MultiSetType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_85(long mutantId, System.Collections.Generic.Dictionary<Microsoft.Dafny.IVariable, Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_45(long mutantId, Microsoft.Dafny.Field argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_39(long mutantId, Microsoft.Dafny.BoogieGenerator.FuelConstant argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_69(long mutantId, Microsoft.Dafny.ClassLikeDecl argument1, Microsoft.Dafny.TopLevelDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.BoogieGenerator.TranslatorFlags argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, Microsoft.Boogie.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_53(long mutantId, Microsoft.Dafny.NewtypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_63(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Boogie.Function argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public partial class BoogieGenerator
    {
        private DafnyOptions options;
        public DafnyOptions Options => options;
        public const string NameSeparator = "$$";
        private bool filterOnlyMembers;

        ErrorReporter reporter;
        // TODO(wuestholz): Enable this once Dafny's recommended Z3 version includes changeset 0592e765744497a089c42021990740f303901e67.
        public bool UseOptimizationInZ3 { get; set; }

        void AddOtherDefinition(Bpl.Declaration declaration, Axiom axiom)
        {
            sink.AddTopLevelDeclaration(axiom);

            // Axioms that have triggers and bound variables do not need to be inside
            // uses clauses. Putting such axioms inside uses clauses weakens pruning
            // when the trigger contains more than one function or constant symbol combined.
            // The early return would happen whenever axiom is of the form:
            // axiom (<quantifier> <(optionally) type variables> <at least one dummy variable> :: { ... } ...
            if (axiom.Expr is Microsoft.Boogie.QuantifierExpr qe && qe.Dummies != null && qe.Dummies.Any() &&
                qe.Triggers != null && qe.Triggers.Tr != null && qe.Triggers.Tr.Any())
            {
                return;
            }

            switch (declaration)
            {
                case null:
                    break;
                    break;
                case Boogie.Function boogieFunction:
                    boogieFunction.OtherDefinitionAxioms.Add(axiom);
                    break;
                    break;
                case Boogie.Constant boogieConstant:
                    boogieConstant.DefinitionAxioms.Add(axiom);
                    break;
                    break;
                default:
                    throw new ArgumentException("Declaration must be a function or constant");
                    break;
            }
        }

        public class TranslatorFlags
        {
            public TranslatorFlags(DafnyOptions options)
            {
                InsertChecksums = MutateCSharp.Schemata487.ReplaceBinExprOp_1(5L, MutateCSharp.Schemata487.ReplaceNumericConstant_0(1L, 0), options.VerifySnapshots);
            }

            public bool InsertChecksums { get; init; }

            public string UniqueIdPrefix = null;
            public bool ReportRanges = MutateCSharp.Schemata487.ReplaceBooleanConstant_2(10L, false);
        }

        [NotDelayed]
        public BoogieGenerator(ErrorReporter reporter, ProofDependencyManager depManager, TranslatorFlags flags = null)
        {
            this.options = reporter.Options;
            this.flags = new TranslatorFlags(options);
            this.proofDependencies = depManager;
            this.reporter = reporter;
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_3(11L, flags, null))
            {
                flags = new TranslatorFlags(options)
                {
                    ReportRanges = options.Get(Snippets.ShowSnippets)
                };
            }
            this.flags = flags;
            Bpl.Program boogieProgram = ReadPrelude();
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_4(12L, boogieProgram, null))
            {
                sink = boogieProgram;
                predef = FindPredefinedDecls(boogieProgram);
            }
        }

        public void SetReporter(ErrorReporter reporter)
        {
            this.reporter = reporter;
        }

        private void EstablishModuleScope(ModuleDefinition systemModule, ModuleDefinition m)
        {
            currentScope = new VisibilityScope();
            verificationScope = new VisibilityScope();

            currentScope.Augment(m.VisibilityScope);
            verificationScope.Augment(currentScope);

            currentScope.Augment(systemModule.VisibilityScope);
            foreach (var decl in m.TopLevelDecls)
            {
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(13L, () => decl is ModuleDecl, () => !(decl is ModuleExportDecl)))
                {
                    var mdecl = (ModuleDecl)decl;
                    currentScope.Augment(mdecl.AccessibleSignature().VisibilityScope);
                }
            }

        }

        // translation state
        readonly Dictionary<TopLevelDecl/*!*/, Bpl.Constant/*!*/>/*!*/ classes = new Dictionary<TopLevelDecl/*!*/, Bpl.Constant/*!*/>();
        readonly Dictionary<TopLevelDecl, string>/*!*/ classConstants = new Dictionary<TopLevelDecl, string>();
        readonly Dictionary<Function, string> functionHandles = new Dictionary<Function, string>();
        readonly List<FuelConstant> functionFuel = new List<FuelConstant>();
        readonly Dictionary<Function, Bpl.Expr> functionReveals = new();
        readonly Dictionary<Field/*!*/, Bpl.Constant/*!*/>/*!*/ fields = new Dictionary<Field/*!*/, Bpl.Constant/*!*/>();
        readonly Dictionary<Field/*!*/, Bpl.Function/*!*/>/*!*/ fieldFunctions = new Dictionary<Field/*!*/, Bpl.Function/*!*/>();
        readonly Dictionary<string, Bpl.Constant> fieldConstants = new Dictionary<string, Constant>();
        readonly Dictionary<string, Bpl.Constant> tytagConstants = new Dictionary<string, Constant>();

        private ProofDependencyManager proofDependencies;

        // optimizing translation
        readonly ISet<MemberDecl> referencedMembers = new HashSet<MemberDecl>();

        public void AddReferencedMember(MemberDecl m)
        {
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(19L, () => m is Method, () => !InVerificationScope(m)))
            {
                referencedMembers.Add(m);
            }
        }

        FuelContext fuelContext = null;
        IsAllocContext isAllocContext = null;
        Program program;

        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(cce.NonNullDictionaryAndValues(classes));
            Contract.Invariant(cce.NonNullDictionaryAndValues(fields));
            Contract.Invariant(cce.NonNullDictionaryAndValues(fieldFunctions));
            Contract.Invariant(codeContext == null || codeContext.EnclosingModule == currentModule);
        }

        [Pure]
        bool VisibleInScope(Declaration d)
        {
            Contract.Requires(d != null);
            if (d is ClassLikeDecl { NonNullTypeDecl: { } nntd })
            {
                // "provides" is recorded in the non-null type declaration, not the class
                return nntd.IsVisibleInScope(currentScope);
            }
            return d.IsVisibleInScope(currentScope);
        }

        [Pure]
        bool VisibleInScope(Type t)
        {
            if (t is UserDefinedType udt && udt.ResolvedClass != null && !t.IsTypeParameter)
            {
                return VisibleInScope(udt.ResolvedClass);
            }
            return MutateCSharp.Schemata487.ReplaceBooleanConstant_2(25L, true);
        }

        [Pure]
        bool RevealedInScope(Declaration d)
        {
            Contract.Requires(d != null);
            return d.IsRevealedInScope(currentScope);
        }

        [Pure]
        bool RevealedInScope(RevealableTypeDecl d)
        {
            Contract.Requires(d != null);
            return RevealedInScope(d.AsTopLevelDecl);
        }

        [Pure]
        bool InVerificationScope(Declaration d)
        {
            Contract.Requires(d != null);
            if (!d.ShouldVerify(program.Compilation))
            {
                return MutateCSharp.Schemata487.ReplaceBooleanConstant_2(26L, false);
            }

            if (d.IsVisibleInScope(verificationScope))
            {
                Contract.Assert(d.IsRevealedInScope(verificationScope));
                if (d is MemberDecl m && m.EnclosingClass.EnclosingModuleDefinition is { IsFacade: true })
                {
                    return MutateCSharp.Schemata487.ReplaceBooleanConstant_2(27L, false);
                }

                return MutateCSharp.Schemata487.ReplaceBooleanConstant_2(28L, true);
            }
            return MutateCSharp.Schemata487.ReplaceBooleanConstant_2(29L, false);
        }

        [Pure]
        bool InVerificationScope(RedirectingTypeDecl d)
        {
            Contract.Requires(d != null);
            Contract.Requires(d is Declaration);
            return InVerificationScope((Declaration)d);
        }

        private Bpl.Program sink;
        private VisibilityScope currentScope;
        private VisibilityScope verificationScope;
        private Dictionary<Declaration, Bpl.Function> declarationMapping = new();

        readonly PredefinedDecls predef;

        private TranslatorFlags flags;
        private bool InsertChecksums
        {
            get { return flags.InsertChecksums; }
        }

        private string UniqueIdPrefix
        {
            get { return flags.UniqueIdPrefix; }
        }

        public class PredefinedDecls
        {
            public readonly Bpl.Type CharType;
            public readonly Bpl.Type RefType;
            public readonly Bpl.Type BoxType;
            public readonly Bpl.Type SetType;
            public readonly Bpl.Type ISetType;
            public readonly Bpl.Type MultiSetType;
            public readonly Bpl.Type SeqType;
            public readonly Bpl.Type MapType;
            public readonly Bpl.Type IMapType;
            public Bpl.Type BigOrdinalType
            {
                get { return BoxType; }
            }

            public readonly Bpl.Function ArrayLength;
            public readonly Bpl.Function RealFloor;
            public readonly Bpl.Function ORDINAL_IsLimit;
            public readonly Bpl.Function ORDINAL_IsSucc;
            public readonly Bpl.Function ORDINAL_Offset;
            public readonly Bpl.Function ORDINAL_IsNat;
            public readonly Bpl.Function MapDomain;
            public readonly Bpl.Function IMapDomain;
            public readonly Bpl.Function MapValues;
            public readonly Bpl.Function IMapValues;
            public readonly Bpl.Function MapItems;
            public readonly Bpl.Function IMapItems;
            public readonly Bpl.Function ObjectTypeConstructor;
            public readonly Bpl.Function Tuple2TypeConstructor;
            public readonly Bpl.Function Tuple2Destructors0;
            public readonly Bpl.Function Tuple2Destructors1;
            public readonly Bpl.Function Tuple2Constructor;
            private readonly Bpl.TypeCtorDecl seqTypeCtor;
            public readonly Bpl.Type Bv0Type;
            readonly Bpl.TypeCtorDecl fieldName;
            public readonly Bpl.Type HeapType;
            public readonly string HeapVarName;
            public readonly Bpl.Type ClassNameType;
            public readonly Bpl.Type NameFamilyType;
            public readonly Bpl.Type DatatypeType;
            public readonly Bpl.Type HandleType;
            public readonly Bpl.Type LayerType;
            public readonly Bpl.Type DtCtorId;
            public readonly Bpl.Type Ty;
            public readonly Bpl.Type TyTag;
            public readonly Bpl.Type TyTagFamily;
            public readonly Bpl.Expr Null;
            public readonly Bpl.Constant AllocField;
            [ContractInvariantMethod]
            void ObjectInvariant()
            {
                Contract.Invariant(CharType != null);
                Contract.Invariant(RefType != null);
                Contract.Invariant(BoxType != null);
                Contract.Invariant(SetType != null);
                Contract.Invariant(ISetType != null);
                Contract.Invariant(MultiSetType != null);
                Contract.Invariant(SeqType != null);
                Contract.Invariant(MapType != null);
                Contract.Invariant(IMapType != null);
                Contract.Invariant(ArrayLength != null);
                Contract.Invariant(RealFloor != null);
                Contract.Invariant(ORDINAL_IsLimit != null);
                Contract.Invariant(ORDINAL_IsSucc != null);
                Contract.Invariant(ORDINAL_Offset != null);
                Contract.Invariant(ORDINAL_IsNat != null);
                Contract.Invariant(MapDomain != null);
                Contract.Invariant(IMapDomain != null);
                Contract.Invariant(MapValues != null);
                Contract.Invariant(IMapValues != null);
                Contract.Invariant(MapItems != null);
                Contract.Invariant(IMapItems != null);
                Contract.Invariant(Tuple2Destructors0 != null);
                Contract.Invariant(Tuple2Destructors1 != null);
                Contract.Invariant(Tuple2Constructor != null);
                Contract.Invariant(seqTypeCtor != null);
                Contract.Invariant(fieldName != null);
                Contract.Invariant(HeapVarName != null);
                Contract.Invariant(ClassNameType != null);
                Contract.Invariant(NameFamilyType != null);
                Contract.Invariant(DatatypeType != null);
                Contract.Invariant(HandleType != null);
                Contract.Invariant(LayerType != null);
                Contract.Invariant(DtCtorId != null);
                Contract.Invariant(Ty != null);
                Contract.Invariant(TyTag != null);
                Contract.Invariant(TyTagFamily != null);
                Contract.Invariant(Null != null);
                Contract.Invariant(AllocField != null);
            }

            public Bpl.Type FieldName(Bpl.IToken tok)
            {
                Contract.Requires(tok != null);
                Contract.Ensures(Contract.Result<Bpl.Type>() != null);

                return new Bpl.CtorType(tok, fieldName, new List<Bpl.Type> { });
            }

            public Bpl.IdentifierExpr Alloc(Bpl.IToken tok)
            {
                Contract.Requires(tok != null);
                Contract.Ensures(Contract.Result<Bpl.IdentifierExpr>() != null);

                return new Bpl.IdentifierExpr(tok, AllocField);
            }

            public PredefinedDecls(Bpl.TypeCtorDecl charType, Bpl.TypeCtorDecl refType, Bpl.TypeCtorDecl boxType,
                                   Bpl.TypeSynonymDecl setTypeCtor, Bpl.TypeSynonymDecl isetTypeCtor, Bpl.TypeSynonymDecl multiSetTypeCtor,
                                   Bpl.TypeCtorDecl mapTypeCtor, Bpl.TypeCtorDecl imapTypeCtor,
                                   Bpl.Function arrayLength, Bpl.Function realFloor,
                                   Bpl.Function ORD_isLimit, Bpl.Function ORD_isSucc, Bpl.Function ORD_offset, Bpl.Function ORD_isNat,
                                   Bpl.Function mapDomain, Bpl.Function imapDomain,
                                   Bpl.Function mapValues, Bpl.Function imapValues, Bpl.Function mapItems, Bpl.Function imapItems,
                                   Bpl.Function objectTypeConstructor,
                                   Bpl.Function tuple2Destructors0, Bpl.Function tuple2Destructors1, Bpl.Function tuple2Constructor, Bpl.Function tuple2TypeConstructor,
                                   Bpl.TypeCtorDecl seqTypeCtor, Bpl.TypeSynonymDecl bv0TypeDecl,
                                   Bpl.TypeCtorDecl fieldNameType, Bpl.TypeCtorDecl tyType, Bpl.TypeCtorDecl tyTagType, Bpl.TypeCtorDecl tyTagFamilyType,
                                   Bpl.GlobalVariable heap, Bpl.TypeCtorDecl classNameType, Bpl.TypeCtorDecl nameFamilyType,
                                   Bpl.TypeCtorDecl datatypeType, Bpl.TypeCtorDecl handleType, Bpl.TypeCtorDecl layerType, Bpl.TypeCtorDecl dtCtorId,
                                   Bpl.Constant allocField)
            {
                #region Non-null preconditions on parameters
                Contract.Requires(charType != null);
                Contract.Requires(refType != null);
                Contract.Requires(boxType != null);
                Contract.Requires(setTypeCtor != null);
                Contract.Requires(isetTypeCtor != null);
                Contract.Requires(multiSetTypeCtor != null);
                Contract.Requires(mapTypeCtor != null);
                Contract.Requires(imapTypeCtor != null);
                Contract.Requires(arrayLength != null);
                Contract.Requires(realFloor != null);
                Contract.Requires(ORD_isLimit != null);
                Contract.Requires(ORD_isSucc != null);
                Contract.Requires(ORD_offset != null);
                Contract.Requires(ORD_isNat != null);
                Contract.Requires(mapDomain != null);
                Contract.Requires(imapDomain != null);
                Contract.Requires(mapValues != null);
                Contract.Requires(imapValues != null);
                Contract.Requires(mapItems != null);
                Contract.Requires(imapItems != null);
                Contract.Requires(tuple2Destructors0 != null);
                Contract.Requires(tuple2Destructors1 != null);
                Contract.Requires(tuple2Constructor != null);
                Contract.Requires(seqTypeCtor != null);
                Contract.Requires(bv0TypeDecl != null);
                Contract.Requires(fieldNameType != null);
                Contract.Requires(heap != null);
                Contract.Requires(classNameType != null);
                Contract.Requires(datatypeType != null);
                Contract.Requires(layerType != null);
                Contract.Requires(dtCtorId != null);
                Contract.Requires(allocField != null);
                Contract.Requires(tyType != null);
                Contract.Requires(tyTagType != null);
                Contract.Requires(tyTagFamilyType != null);
                #endregion

                this.CharType = new Bpl.CtorType(Token.NoToken, charType, new List<Bpl.Type>());
                Bpl.CtorType refT = new Bpl.CtorType(Token.NoToken, refType, new List<Bpl.Type>());
                this.RefType = refT;
                this.BoxType = new Bpl.CtorType(Token.NoToken, boxType, new List<Bpl.Type>());
                this.SetType = new Bpl.TypeSynonymAnnotation(Token.NoToken, setTypeCtor, new List<Bpl.Type> { });
                this.ISetType = new Bpl.TypeSynonymAnnotation(Token.NoToken, setTypeCtor, new List<Bpl.Type> { });
                this.MultiSetType = new Bpl.TypeSynonymAnnotation(Token.NoToken, multiSetTypeCtor, new List<Bpl.Type> { });
                this.SeqType = new Bpl.CtorType(Token.NoToken, seqTypeCtor, new List<Bpl.Type> { });
                this.MapType = new Bpl.CtorType(Token.NoToken, mapTypeCtor, new List<Bpl.Type> { });
                this.IMapType = new Bpl.CtorType(Token.NoToken, imapTypeCtor, new List<Bpl.Type> { });
                this.ArrayLength = arrayLength;
                this.RealFloor = realFloor;
                this.ORDINAL_IsLimit = ORD_isLimit;
                this.ORDINAL_IsSucc = ORD_isSucc;
                this.ORDINAL_Offset = ORD_offset;
                this.ORDINAL_IsNat = ORD_isNat;
                this.MapDomain = mapDomain;
                this.IMapDomain = imapDomain;
                this.MapValues = mapValues;
                this.IMapValues = imapValues;
                this.MapItems = mapItems;
                this.IMapItems = imapItems;
                this.ObjectTypeConstructor = objectTypeConstructor;
                this.Tuple2Destructors0 = tuple2Destructors0;
                this.Tuple2Destructors1 = tuple2Destructors1;
                this.Tuple2Constructor = tuple2Constructor;
                this.Tuple2TypeConstructor = tuple2TypeConstructor;
                this.seqTypeCtor = seqTypeCtor;
                this.Bv0Type = new Bpl.TypeSynonymAnnotation(Token.NoToken, bv0TypeDecl, new List<Bpl.Type>());
                this.fieldName = fieldNameType;
                this.HeapType = heap.TypedIdent.Type;
                this.HeapVarName = heap.Name;
                this.Ty = new Bpl.CtorType(Token.NoToken, tyType, new List<Bpl.Type>());
                this.TyTag = new Bpl.CtorType(Token.NoToken, tyTagType, new List<Bpl.Type>());
                this.TyTagFamily = new Bpl.CtorType(Token.NoToken, tyTagFamilyType, new List<Bpl.Type>());
                this.ClassNameType = new Bpl.CtorType(Token.NoToken, classNameType, new List<Bpl.Type>());
                this.NameFamilyType = new Bpl.CtorType(Token.NoToken, nameFamilyType, new List<Bpl.Type>());
                this.DatatypeType = new Bpl.CtorType(Token.NoToken, datatypeType, new List<Bpl.Type>());
                this.HandleType = new Bpl.CtorType(Token.NoToken, handleType, new List<Bpl.Type>());
                this.LayerType = new Bpl.CtorType(Token.NoToken, layerType, new List<Bpl.Type>());
                this.DtCtorId = new Bpl.CtorType(Token.NoToken, dtCtorId, new List<Bpl.Type>());
                this.AllocField = allocField;
                this.Null = new Bpl.IdentifierExpr(Token.NoToken, MutateCSharp.Schemata487.ReplaceStringConstant_6(30L, "null"), refT);
            }
        }

        PredefinedDecls FindPredefinedDecls(Bpl.Program prog)
        {
            Contract.Requires(prog != null);
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_7(35L, prog.Resolve(options), MutateCSharp.Schemata487.ReplaceNumericConstant_0(31L, 0)))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(40L, "Error: resolution errors encountered in Dafny prelude"));
                return null;
            }

            Bpl.TypeCtorDecl charType = null;
            Bpl.TypeCtorDecl refType = null;
            Bpl.TypeSynonymDecl setTypeCtor = null;
            Bpl.TypeSynonymDecl isetTypeCtor = null;
            Bpl.TypeSynonymDecl multiSetTypeCtor = null;
            Bpl.Function arrayLength = null;
            Bpl.Function realFloor = null;
            Bpl.Function ORDINAL_isLimit = null;
            Bpl.Function ORDINAL_isSucc = null;
            Bpl.Function ORDINAL_offset = null;
            Bpl.Function ORDINAL_isNat = null;
            Bpl.Function mapDomain = null;
            Bpl.Function imapDomain = null;
            Bpl.Function mapValues = null;
            Bpl.Function imapValues = null;
            Bpl.Function mapItems = null;
            Bpl.Function imapItems = null;
            Bpl.Function objectTypeConstructor = null;
            Bpl.Function tuple2TypeConstructor = null;
            Bpl.Function tuple2Destructors0 = null;
            Bpl.Function tuple2Destructors1 = null;
            Bpl.Function tuple2Constructor = null;
            Bpl.TypeCtorDecl seqTypeCtor = null;
            Bpl.TypeCtorDecl fieldNameType = null;
            Bpl.TypeCtorDecl classNameType = null;
            Bpl.TypeSynonymDecl bv0TypeDecl = null;
            Bpl.TypeCtorDecl tyType = null;
            Bpl.TypeCtorDecl tyTagType = null;
            Bpl.TypeCtorDecl tyTagFamilyType = null;
            Bpl.TypeCtorDecl nameFamilyType = null;
            Bpl.TypeCtorDecl datatypeType = null;
            Bpl.TypeCtorDecl handleType = null;
            Bpl.TypeCtorDecl layerType = null;
            Bpl.TypeCtorDecl dtCtorId = null;
            Bpl.TypeCtorDecl boxType = null;
            Bpl.TypeCtorDecl mapTypeCtor = null;
            Bpl.TypeCtorDecl imapTypeCtor = null;
            Bpl.GlobalVariable heap = null;
            Bpl.Constant allocField = null;
            foreach (var d in prog.TopLevelDeclarations)
            {
                if (d is Bpl.TypeCtorDecl)
                {
                    Bpl.TypeCtorDecl dt = (Bpl.TypeCtorDecl)d;
                    if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(42L, dt.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(41L, "Seq")))
                    {
                        seqTypeCtor = dt;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(44L, dt.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(43L, "Field")))
                    {
                        fieldNameType = dt;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(46L, dt.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(45L, "ClassName")))
                    {
                        classNameType = dt;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(48L, dt.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(47L, "Ty")))
                    {
                        tyType = dt;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(50L, dt.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(49L, "TyTag")))
                    {
                        tyTagType = dt;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(52L, dt.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(51L, "TyTagFamily")))
                    {
                        tyTagFamilyType = dt;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(54L, dt.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(53L, "DatatypeType")))
                    {
                        datatypeType = dt;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(56L, dt.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(55L, "HandleType")))
                    {
                        handleType = dt;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(58L, dt.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(57L, "LayerType")))
                    {
                        layerType = dt;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(60L, dt.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(59L, "DtCtorId")))
                    {
                        dtCtorId = dt;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(62L, dt.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(61L, "char")))
                    {
                        charType = dt;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(64L, dt.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(63L, "ref")))
                    {
                        refType = dt;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(66L, dt.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(65L, "NameFamily")))
                    {
                        nameFamilyType = dt;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(68L, dt.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(67L, "Box")))
                    {
                        boxType = dt;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(70L, dt.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(69L, "Map")))
                    {
                        mapTypeCtor = dt;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(72L, dt.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(71L, "IMap")))
                    {
                        imapTypeCtor = dt;
                    }
                }
                else if (d is Bpl.TypeSynonymDecl)
                {
                    Bpl.TypeSynonymDecl dt = (Bpl.TypeSynonymDecl)d;
                    if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(74L, dt.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(73L, "Set")))
                    {
                        setTypeCtor = dt;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(76L, dt.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(75L, "MultiSet")))
                    {
                        multiSetTypeCtor = dt;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(78L, dt.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(77L, "ISet")))
                    {
                        isetTypeCtor = dt;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(80L, dt.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(79L, "Bv0")))
                    {
                        bv0TypeDecl = dt;
                    }
                }
                else if (d is Bpl.Constant)
                {
                    Bpl.Constant c = (Bpl.Constant)d;
                    if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(82L, c.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(81L, "alloc")))
                    {
                        allocField = c;
                    }
                }
                else if (d is Bpl.GlobalVariable)
                {
                    Bpl.GlobalVariable v = (Bpl.GlobalVariable)d;
                    if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(84L, v.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(83L, "$Heap")))
                    {
                        heap = v;
                    }
                }
                else if (d is Bpl.Function)
                {
                    var f = (Bpl.Function)d;
                    if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(86L, f.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(85L, "_System.array.Length")))
                    {
                        arrayLength = f;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(88L, f.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(87L, "_System.real.Floor")))
                    {
                        realFloor = f;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(90L, f.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(89L, "ORD#IsLimit")))
                    {
                        ORDINAL_isLimit = f;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(92L, f.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(91L, "ORD#IsSucc")))
                    {
                        ORDINAL_isSucc = f;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(94L, f.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(93L, "ORD#Offset")))
                    {
                        ORDINAL_offset = f;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(96L, f.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(95L, "ORD#IsNat")))
                    {
                        ORDINAL_isNat = f;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(98L, f.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(97L, "Map#Domain")))
                    {
                        mapDomain = f;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(100L, f.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(99L, "IMap#Domain")))
                    {
                        imapDomain = f;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(102L, f.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(101L, "Map#Values")))
                    {
                        mapValues = f;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(104L, f.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(103L, "IMap#Values")))
                    {
                        imapValues = f;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(106L, f.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(105L, "Map#Items")))
                    {
                        mapItems = f;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(108L, f.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(107L, "IMap#Items")))
                    {
                        imapItems = f;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(110L, f.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(109L, "_System.Tuple2._0")))
                    {
                        tuple2Destructors0 = f;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(112L, f.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(111L, "_System.Tuple2._1")))
                    {
                        tuple2Destructors1 = f;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(114L, f.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(113L, "#_System._tuple#2._#Make2")))
                    {
                        tuple2Constructor = f;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(116L, f.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(115L, "Tclass._System.Tuple2")))
                    {
                        tuple2TypeConstructor = f;
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(118L, f.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(117L, "Tclass._System.object?")))
                    {
                        objectTypeConstructor = f;
                    }
                }
            }
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_9(119L, seqTypeCtor, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(120L, "Error: Dafny prelude is missing declaration of type Seq"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_10(121L, setTypeCtor, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(122L, "Error: Dafny prelude is missing declaration of type Set"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_10(123L, isetTypeCtor, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(124L, "Error: Dafny prelude is missing declaration of type ISet"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_10(125L, multiSetTypeCtor, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(126L, "Error: Dafny prelude is missing declaration of type MultiSet"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_9(127L, mapTypeCtor, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(128L, "Error: Dafny prelude is missing declaration of type Map"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_9(129L, imapTypeCtor, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(130L, "Error: Dafny prelude is missing declaration of type IMap"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_11(131L, arrayLength, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(132L, "Error: Dafny prelude is missing declaration of function _System.array.Length"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_11(133L, realFloor, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(134L, "Error: Dafny prelude is missing declaration of function _System.real.Floor"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_11(135L, ORDINAL_isLimit, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(136L, "Error: Dafny prelude is missing declaration of function ORD#IsLimit"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_11(137L, ORDINAL_isSucc, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(138L, "Error: Dafny prelude is missing declaration of function ORD#IsSucc"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_11(139L, ORDINAL_offset, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(140L, "Error: Dafny prelude is missing declaration of function ORD#Offset"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_11(141L, ORDINAL_isNat, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(142L, "Error: Dafny prelude is missing declaration of function ORD#IsNat"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_11(143L, mapDomain, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(144L, "Error: Dafny prelude is missing declaration of function Map#Domain"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_11(145L, imapDomain, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(146L, "Error: Dafny prelude is missing declaration of function IMap#Domain"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_11(147L, mapValues, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(148L, "Error: Dafny prelude is missing declaration of function Map#Values"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_11(149L, imapValues, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(150L, "Error: Dafny prelude is missing declaration of function IMap#Values"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_11(151L, mapItems, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(152L, "Error: Dafny prelude is missing declaration of function Map#Items"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_11(153L, imapItems, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(154L, "Error: Dafny prelude is missing declaration of function IMap#Items"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_11(155L, tuple2Destructors0, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(156L, "Error: Dafny prelude is missing declaration of function _System.Tuple2._0"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_11(157L, tuple2Destructors1, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(158L, "Error: Dafny prelude is missing declaration of function _System.Tuple2._1"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_11(159L, tuple2Constructor, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(160L, "Error: Dafny prelude is missing declaration of function #_System._tuple#2._#Make2"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_10(161L, bv0TypeDecl, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(162L, "Error: Dafny prelude is missing declaration of type Bv0"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_9(163L, fieldNameType, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(164L, "Error: Dafny prelude is missing declaration of type Field"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_9(165L, classNameType, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(166L, "Error: Dafny prelude is missing declaration of type ClassName"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_9(167L, tyType, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(168L, "Error: Dafny prelude is missing declaration of type Ty"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_9(169L, tyTagType, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(170L, "Error: Dafny prelude is missing declaration of type TyTag"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_9(171L, tyTagFamilyType, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(172L, "Error: Dafny prelude is missing declaration of type TyTagFamily"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_9(173L, nameFamilyType, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(174L, "Error: Dafny prelude is missing declaration of type NameFamily"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_9(175L, datatypeType, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(176L, "Error: Dafny prelude is missing declaration of type DatatypeType"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_9(177L, handleType, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(178L, "Error: Dafny prelude is missing declaration of type HandleType"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_9(179L, layerType, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(180L, "Error: Dafny prelude is missing declaration of type LayerType"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_9(181L, dtCtorId, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(182L, "Error: Dafny prelude is missing declaration of type DtCtorId"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_9(183L, charType, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(184L, "Error: Dafny prelude is missing declaration of type char"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_9(185L, refType, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(186L, "Error: Dafny prelude is missing declaration of type ref"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_9(187L, boxType, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(188L, "Error: Dafny prelude is missing declaration of type Box"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_12(189L, heap, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(190L, "Error: Dafny prelude is missing declaration of $Heap"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_13(191L, allocField, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(192L, "Error: Dafny prelude is missing declaration of constant alloc"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_11(193L, tuple2TypeConstructor, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(194L, "Error: Dafny prelude is missing declaration of tuple2TypeConstructor"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_11(195L, objectTypeConstructor, null))
            {
                options.OutputWriter.WriteLine(MutateCSharp.Schemata487.ReplaceStringConstant_6(196L, "Error: Dafny prelude is missing declaration of objectTypeConstructor"));
            }
            else
            {
                return new PredefinedDecls(charType, refType, boxType,
                                           setTypeCtor, isetTypeCtor, multiSetTypeCtor,
                                           mapTypeCtor, imapTypeCtor,
                                           arrayLength, realFloor,
                                           ORDINAL_isLimit, ORDINAL_isSucc, ORDINAL_offset, ORDINAL_isNat,
                                           mapDomain, imapDomain,
                                           mapValues, imapValues, mapItems, imapItems,
                                           objectTypeConstructor,
                                           tuple2Destructors0, tuple2Destructors1, tuple2Constructor, tuple2TypeConstructor,
                                           seqTypeCtor, bv0TypeDecl,
                                           fieldNameType, tyType, tyTagType, tyTagFamilyType,
                                           heap, classNameType, nameFamilyType,
                                           datatypeType, handleType, layerType, dtCtorId,
                                           allocField);
            }
            return null;
        }

        Bpl.Program ReadPrelude()
        {
            string preludePath = options.DafnyPrelude;
            if (preludePath == null)
            {
                //using (System.IO.Stream stream = cce.NonNull( System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DafnyPrelude.bpl")) // Use this once Spec#/VSIP supports designating a non-.resx project item as an embedded resource
                string codebase = cce.NonNull(System.IO.Path.GetDirectoryName(cce.NonNull(System.Reflection.Assembly.GetExecutingAssembly().Location)));
                preludePath = System.IO.Path.Combine(codebase, MutateCSharp.Schemata487.ReplaceStringConstant_6(197L, "DafnyPrelude.bpl"));
            }

            var defines = new List<string>();
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_14(202L, MutateCSharp.Schemata487.ReplaceNumericConstant_0(198L, 6), options.ArithMode))
            {
                defines.Add(MutateCSharp.Schemata487.ReplaceStringConstant_6(207L, "ARITH_DISTR"));
            }
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_14(212L, MutateCSharp.Schemata487.ReplaceNumericConstant_0(208L, 8), options.ArithMode))
            {
                defines.Add(MutateCSharp.Schemata487.ReplaceStringConstant_6(217L, "ARITH_MUL_DIV_MOD"));
            }
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_14(222L, MutateCSharp.Schemata487.ReplaceNumericConstant_0(218L, 9), options.ArithMode))
            {
                defines.Add(MutateCSharp.Schemata487.ReplaceStringConstant_6(227L, "ARITH_MUL_SIGN"));
            }
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_14(232L, MutateCSharp.Schemata487.ReplaceNumericConstant_0(228L, 10), options.ArithMode))
            {
                defines.Add(MutateCSharp.Schemata487.ReplaceStringConstant_6(237L, "ARITH_MUL_COMM"));
                defines.Add(MutateCSharp.Schemata487.ReplaceStringConstant_6(238L, "ARITH_MUL_ASSOC"));
            }
            if (options.Get(CommonOptionBag.UnicodeCharacters))
            {
                defines.Add(MutateCSharp.Schemata487.ReplaceStringConstant_6(239L, "UNICODE_CHAR"));
            }
            int errorCount = BplParser.Parse(preludePath, defines, out var prelude);
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_17(250L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_15(240L, prelude, null), () => MutateCSharp.Schemata487.ReplaceBinExprOp_16(245L, errorCount, MutateCSharp.Schemata487.ReplaceNumericConstant_0(241L, 0))))
            {
                return null;
            }
            else
            {
                return prelude;
            }

            return default;
        }

        public Bpl.IdentifierExpr TrVar(IToken tok, IVariable var)
        {
            Contract.Requires(var != null);
            Contract.Requires(tok != null);
            Contract.Ensures(Contract.Result<Bpl.IdentifierExpr>() != null);
            return new Bpl.IdentifierExpr(tok, var.AssignUniqueName(currentDeclaration.IdGenerator), TrType(var.Type));
        }

        public Bpl.Program DoTranslation(Program p, ModuleDefinition forModule)
        {
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_15(256L, sink, null))
            {
                return new Bpl.Program();
            }

            foreach (var plugin in p.Options.Plugins)
            {
                foreach (var rewriter in plugin.GetRewriters(p.Reporter))
                {
                    rewriter.PreVerify(forModule);
                }
            }

            program = p;
            this.forModule = forModule;
            triggersCollector = new TriggersCollector(new Dictionary<Expression, HashSet<OldExpr>>(), options, forModule);
            Type.EnableScopes();

            EstablishModuleScope(p.SystemModuleManager.SystemModule, forModule);
            Type.PushScope(this.currentScope);

            foreach (var w in program.SystemModuleManager.Bitwidths)
            {
                // type axioms
                AddBitvectorTypeAxioms(w);
                // bitwise operations
                AddBitvectorFunction(w, MutateCSharp.Schemata487.ReplaceStringConstant_6(257L, "and_bv"), MutateCSharp.Schemata487.ReplaceStringConstant_6(258L, "bvand"));
                AddBitvectorFunction(w, MutateCSharp.Schemata487.ReplaceStringConstant_6(259L, "or_bv"), MutateCSharp.Schemata487.ReplaceStringConstant_6(260L, "bvor"));
                AddBitvectorFunction(w, MutateCSharp.Schemata487.ReplaceStringConstant_6(261L, "xor_bv"), MutateCSharp.Schemata487.ReplaceStringConstant_6(262L, "bvxor"));  // Z3 supports this, but it seems not to be in the SMT-LIB 2 standard
                AddBitvectorFunction(w, MutateCSharp.Schemata487.ReplaceStringConstant_6(263L, "not_bv"), MutateCSharp.Schemata487.ReplaceStringConstant_6(264L, "bvnot"), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(265L, false));
                // arithmetic operations
                AddBitvectorFunction(w, MutateCSharp.Schemata487.ReplaceStringConstant_6(266L, "add_bv"), MutateCSharp.Schemata487.ReplaceStringConstant_6(267L, "bvadd"));
                AddBitvectorFunction(w, MutateCSharp.Schemata487.ReplaceStringConstant_6(268L, "sub_bv"), MutateCSharp.Schemata487.ReplaceStringConstant_6(269L, "bvsub"));  // Z3 supports this, but it seems not to be in the SMT-LIB 2 standard
                AddBitvectorFunction(w, MutateCSharp.Schemata487.ReplaceStringConstant_6(270L, "mul_bv"), MutateCSharp.Schemata487.ReplaceStringConstant_6(271L, "bvmul"));
                AddBitvectorFunction(w, MutateCSharp.Schemata487.ReplaceStringConstant_6(272L, "div_bv"), MutateCSharp.Schemata487.ReplaceStringConstant_6(273L, "bvudiv"));
                AddBitvectorFunction(w, MutateCSharp.Schemata487.ReplaceStringConstant_6(274L, "mod_bv"), MutateCSharp.Schemata487.ReplaceStringConstant_6(275L, "bvurem"));
                // comparisons
                AddBitvectorFunction(w, MutateCSharp.Schemata487.ReplaceStringConstant_6(276L, "lt_bv"), MutateCSharp.Schemata487.ReplaceStringConstant_6(277L, "bvult"), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(278L, true), Bpl.Type.Bool, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(279L, false));
                AddBitvectorFunction(w, MutateCSharp.Schemata487.ReplaceStringConstant_6(280L, "le_bv"), MutateCSharp.Schemata487.ReplaceStringConstant_6(281L, "bvule"), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(282L, true), Bpl.Type.Bool, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(283L, true));  // Z3 supports this, but it seems not to be in the SMT-LIB 2 standard
                AddBitvectorFunction(w, MutateCSharp.Schemata487.ReplaceStringConstant_6(284L, "ge_bv"), MutateCSharp.Schemata487.ReplaceStringConstant_6(285L, "bvuge"), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(286L, true), Bpl.Type.Bool, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(287L, true));  // Z3 supports this, but it seems not to be in the SMT-LIB 2 standard
                AddBitvectorFunction(w, MutateCSharp.Schemata487.ReplaceStringConstant_6(288L, "gt_bv"), MutateCSharp.Schemata487.ReplaceStringConstant_6(289L, "bvugt"), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(290L, true), Bpl.Type.Bool, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(291L, false));  // Z3 supports this, but it seems not to be in the SMT-LIB 2 standard
                                                                                                                                                                                                                                                                                                                          // shifts
                AddBitvectorShiftFunction(w, MutateCSharp.Schemata487.ReplaceStringConstant_6(292L, "LeftShift_bv"), MutateCSharp.Schemata487.ReplaceStringConstant_6(293L, "bvshl"));
                AddBitvectorShiftFunction(w, MutateCSharp.Schemata487.ReplaceStringConstant_6(294L, "RightShift_bv"), MutateCSharp.Schemata487.ReplaceStringConstant_6(295L, "bvlshr"));
                // rotates
                AddBitvectorShiftFunction(w, MutateCSharp.Schemata487.ReplaceStringConstant_6(296L, "LeftRotate_bv"), MutateCSharp.Schemata487.ReplaceStringConstant_6(297L, "ext_rotate_left"));
                AddBitvectorShiftFunction(w, MutateCSharp.Schemata487.ReplaceStringConstant_6(298L, "RightRotate_bv"), MutateCSharp.Schemata487.ReplaceStringConstant_6(299L, "ext_rotate_right"));
                // conversion functions
                AddBitvectorNatConversionFunction(w);
            }

            foreach (TopLevelDecl d in program.SystemModuleManager.SystemModule.TopLevelDecls)
            {
                currentDeclaration = d;
                if (d is AbstractTypeDecl abstractType)
                {
                    GetOrCreateTypeConstructor(abstractType);
                    AddClassMembers(abstractType, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(300L, true), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(301L, true));
                }
                else if (d is NewtypeDecl)
                {
                    var dd = (NewtypeDecl)d;
                    AddTypeDecl(dd);
                    AddClassMembers(dd, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(302L, true), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(303L, true));
                }
                else if (d is SubsetTypeDecl)
                {
                    AddTypeDecl((SubsetTypeDecl)d);
                }
                else if (d is TypeSynonymDecl)
                {
                    // do nothing, just bypass type synonyms in the translation
                }
                else if (d is DatatypeDecl)
                {
                    var dd = (DatatypeDecl)d;
                    AddDatatype(dd);
                    AddClassMembers(dd, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(304L, true), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(305L, true));
                }
                else if (d is ArrowTypeDecl)
                {
                    var ad = (ArrowTypeDecl)d;
                    GetClassTyCon(ad);
                    AddArrowTypeAxioms(ad);
                }
                else if (d is ClassLikeDecl)
                {
                    var cl = (ClassLikeDecl)d;
                    AddClassMembers(cl, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(306L, true), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(307L, true));
                    if (MutateCSharp.Schemata487.ReplaceBinExprOp_18(308L, cl.NonNullTypeDecl, null))
                    {
                        AddTypeDecl(cl.NonNullTypeDecl);
                    }
                }
                else
                {
                    Contract.Assert(d is ValuetypeDecl);
                }
            }

            ComputeFunctionFuel(); // compute which function needs fuel constants.

            //translate us first
            List<ModuleDefinition> mods = program.RawModules().ToList();
            mods.Remove(forModule);
            mods.Insert(MutateCSharp.Schemata487.ReplaceNumericConstant_0(309L, 0), forModule);

            var visibleTopLevelDecls =
              mods.SelectMany(m => m.TopLevelDecls.Where(VisibleInScope));

            if (visibleTopLevelDecls.Any(
                  d => d is TopLevelDeclWithMembers memberContainer &&
                       memberContainer.Members.Any(
                         member =>
                           Attributes.Contains(member.Attributes, MutateCSharp.Schemata487.ReplaceStringConstant_6(313L, "only"))
                       )))
            {
                filterOnlyMembers = MutateCSharp.Schemata487.ReplaceBooleanConstant_2(314L, true);
            }

            foreach (TopLevelDecl d in visibleTopLevelDecls)
            {
                currentDeclaration = d;
                if (d is AbstractTypeDecl abstractType)
                {
                    AddClassMembers(abstractType, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(315L, true), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(316L, true));
                }
                else if (d is ModuleDecl)
                {
                    // submodules have already been added as a top level module, ignore this.
                }
                else if (d is RevealableTypeDecl revealableTypeDecl)
                {
                    AddRevealableTypeDecl(revealableTypeDecl);
                }
                else
                {
                    Contract.Assert(false);
                }
            }

            filterOnlyMembers = MutateCSharp.Schemata487.ReplaceBooleanConstant_2(317L, false);

            foreach (var c in tytagConstants.Values)
            {
                sink.AddTopLevelDeclaration(c);
            }
            foreach (var c in fieldConstants.Values)
            {
                sink.AddTopLevelDeclaration(c);
            }

            AddTraitParentAxioms();

            if (InsertChecksums)
            {
                foreach (var impl in sink.Implementations)
                {
                    if (MutateCSharp.Schemata487.ReplaceBinExprOp_19(319L, impl.FindAttribute(MutateCSharp.Schemata487.ReplaceStringConstant_6(318L, "checksum")), null))
                    {
                        impl.AddAttribute(MutateCSharp.Schemata487.ReplaceStringConstant_6(320L, "checksum"), MutateCSharp.Schemata487.ReplaceStringConstant_6(321L, "stable"));
                    }
                }
                foreach (var func in sink.Functions)
                {
                    if (MutateCSharp.Schemata487.ReplaceBinExprOp_19(323L, func.FindAttribute(MutateCSharp.Schemata487.ReplaceStringConstant_6(322L, "checksum")), null))
                    {
                        func.AddAttribute(MutateCSharp.Schemata487.ReplaceStringConstant_6(324L, "checksum"), MutateCSharp.Schemata487.ReplaceStringConstant_6(325L, "stable"));
                    }
                }
            }

            Type.PopScope(this.currentScope);
            Type.DisableScopes();
            return sink;

        }

        // Don't verify modules which only contain other modules
        public static bool ShouldVerifyModule(Program program, ModuleDefinition m)
        {
            if (!m.ShouldVerify(program.Compilation))
            {
                return MutateCSharp.Schemata487.ReplaceBooleanConstant_2(326L, false);
            }

            foreach (var top in m.TopLevelDecls)
            {
                if (top is DefaultClassDecl)
                {
                    if (MutateCSharp.Schemata487.ReplaceBinExprOp_16(331L, ((DefaultClassDecl)top).Members.Count, MutateCSharp.Schemata487.ReplaceNumericConstant_0(327L, 0)))
                    {
                        return MutateCSharp.Schemata487.ReplaceBooleanConstant_2(336L, true);
                    }
                }
                else if (!(top is ModuleDecl))
                {
                    return MutateCSharp.Schemata487.ReplaceBooleanConstant_2(337L, true);
                }
            }
            return MutateCSharp.Schemata487.ReplaceBooleanConstant_2(338L, false);
        }

        public static IEnumerable<ModuleDefinition> VerifiableModules(Program p)
        {
            return p.RawModules().Where(m => ShouldVerifyModule(p, m));
        }

        public static IEnumerable<Tuple<string, Bpl.Program>> Translate(Program p, ErrorReporter reporter, TranslatorFlags flags = null)
        {
            Contract.Requires(p != null);
            Contract.Requires(p.ModuleSigs.Count > 0);

            Type.ResetScopes();

            foreach (ModuleDefinition outerModule in VerifiableModules(p))
            {
                var translator = new BoogieGenerator(reporter, p.ProofDependencyManager, flags);

                if (MutateCSharp.Schemata487.ReplaceBinExprOp_17(341L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_15(339L, translator.sink, null), () => MutateCSharp.Schemata487.ReplaceBinExprOp_15(340L, translator.sink, null)))
                {
                    // something went wrong during construction, which reads the prelude; an error has
                    // already been printed, so just return an empty program here (which is non-null)
                    yield return new Tuple<string, Bpl.Program>(outerModule.SanitizedName, new Bpl.Program());
                }
                yield return new Tuple<string, Bpl.Program>(outerModule.SanitizedName, translator.DoTranslation(p, outerModule));
            }

            yield break;
        }

        /// <summary>
        /// Declare and add to the sink a Boogie function named "namePrefix + w".
        /// If "binary", then the function takes two arguments; otherwise, it takes one.  Arguments have the type
        /// corresponding to the Dafny type for w-width bitvectors.
        /// The function's result type is the same as the argument type, unless "resultType" is non-null, in which
        /// case the function's result type is "resultType".
        /// For w > 0:
        ///     Attach an attribute {:bvbuiltin smtFunctionName}.
        /// For w == 0:
        ///     Attach an attribute {:inline} and add a .Body to the function.
        ///     If "resultType" is null, then use 0 as the body; otherwise, use "bodyForBv0" as the body (which
        ///     assumes "resultType" is actually Bpl.Type.Bool).
        /// </summary>
        private void AddBitvectorFunction(int w, string namePrefix, string smtFunctionName, bool binary = true, Bpl.Type resultType = null, bool bodyForBv0 = false)
        {
            Contract.Requires(0 <= w);
            Contract.Requires(namePrefix != null);
            Contract.Requires(smtFunctionName != null);
            var tok = Token.NoToken;
            var t = BplBvType(w);
            List<Bpl.Variable> args;
            if (binary)
            {
                var a0 = BplFormalVar(null, t, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(347L, true));
                var a1 = BplFormalVar(null, t, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(348L, true));
                args = new List<Variable>() { a0, a1 };
            }
            else
            {
                var a0 = BplFormalVar(null, t, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(349L, true));
                args = new List<Variable>() { a0 };
            }
            var r = BplFormalVar(null, resultType ?? t, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(350L, false));
            Bpl.QKeyValue attr;
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_20(355L, w, MutateCSharp.Schemata487.ReplaceNumericConstant_0(351L, 0)))
            {
                attr = InlineAttribute(tok);
            }
            else
            {
                attr = new Bpl.QKeyValue(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(360L, "bvbuiltin"), new List<object>() { smtFunctionName }, null);
            }
            var func = new Bpl.Function(tok, namePrefix + w, new List<TypeVariable>(), args, r, null, attr);
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_20(365L, w, MutateCSharp.Schemata487.ReplaceNumericConstant_0(361L, 0)))
            {
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_21(370L, resultType, null))
                {
                    func.Body = Bpl.Expr.Literal(bodyForBv0);
                }
                else
                {
                    func.Body = BplBvLiteralExpr(tok, BaseTypes.BigNum.ZERO, w);
                }
            }
            sink.AddTopLevelDeclaration(func);
        }

        private void AddBitvectorShiftFunction(int w, string namePrefix, string smtFunctionName)
        {
            Contract.Requires(0 <= w);
            Contract.Requires(namePrefix != null);
            Contract.Requires(smtFunctionName != null);
            var tok = Token.NoToken;
            var t = BplBvType(w);
            List<Bpl.Variable> args;
            var a0 = BplFormalVar(null, t, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(371L, true));
            var a1 = BplFormalVar(null, t, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(372L, true));
            args = new List<Variable>() { a0, a1 };
            var r = BplFormalVar(null, t, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(373L, false));
            Bpl.QKeyValue attr;
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_20(378L, w, MutateCSharp.Schemata487.ReplaceNumericConstant_0(374L, 0)))
            {
                attr = InlineAttribute(tok);
            }
            else
            {
                attr = new Bpl.QKeyValue(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(383L, "bvbuiltin"), new List<object>() { smtFunctionName }, null);
            }
            var func = new Bpl.Function(tok, namePrefix + w, new List<TypeVariable>(), args, r, null, attr);
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_20(388L, w, MutateCSharp.Schemata487.ReplaceNumericConstant_0(384L, 0)))
            {
                func.Body = BplBvLiteralExpr(tok, BaseTypes.BigNum.ZERO, w);
            }
            sink.AddTopLevelDeclaration(func);
        }

        private void AddBitvectorNatConversionFunction(int w)
        {
            Contract.Requires(0 <= w);
            var tok = Token.NoToken;
            var bv = BplBvType(w);
            Bpl.QKeyValue attr;
            Bpl.Function func;

            // function {:bvbuiltin "(_ int2bv 67)"} nat_to_bv67(int) : bv67;
            // OR:
            // function {:inline} nat_to_bv0(int) : Bv0 { ZERO }
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_20(397L, w, MutateCSharp.Schemata487.ReplaceNumericConstant_0(393L, 0)))
            {
                attr = InlineAttribute(tok);
            }
            else
            {
                var smt_int2bv = string.Format(MutateCSharp.Schemata487.ReplaceStringConstant_6(402L, "(_ int2bv {0})"), w);
                attr = new Bpl.QKeyValue(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(403L, "bvbuiltin"), new List<object>() { smt_int2bv }, null);  // SMT-LIB 2 calls this function nat2bv, but Z3 apparently calls it int2bv
            }
            func = new Bpl.Function(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(404L, "nat_to_bv") + w, new List<TypeVariable>(),
              new List<Variable>() { BplFormalVar(null, Bpl.Type.Int, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(405L, true)) }, BplFormalVar(null, bv, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(406L, false)),
              null, attr);
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_20(411L, w, MutateCSharp.Schemata487.ReplaceNumericConstant_0(407L, 0)))
            {
                func.Body = BplBvLiteralExpr(tok, BaseTypes.BigNum.ZERO, w);
            }
            sink.AddTopLevelDeclaration(func);

            if (MutateCSharp.Schemata487.ReplaceBinExprOp_20(420L, w, MutateCSharp.Schemata487.ReplaceNumericConstant_0(416L, 0)))
            {
                // function {:inline} nat_from_bv0_smt(Bv0) : int { 0 }
                attr = InlineAttribute(tok);
                func = new Bpl.Function(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(425L, "nat_from_bv") + w, new List<TypeVariable>(),
                  new List<Variable>() { BplFormalVar(null, bv, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(426L, true)) }, BplFormalVar(null, Bpl.Type.Int, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(427L, false)),
                  null, attr);
                func.Body = Bpl.Expr.Literal(MutateCSharp.Schemata487.ReplaceNumericConstant_0(428L, 0));
                sink.AddTopLevelDeclaration(func);
            }
            else
            {
                // function {:bvbuiltin "bv2int"} smt_nat_from_bv67(bv67) : int;
                attr = new Bpl.QKeyValue(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(432L, "bvbuiltin"), new List<object>() { MutateCSharp.Schemata487.ReplaceStringConstant_6(433L, "bv2int") }, null);  // SMT-LIB 2 calls this function bv2nat, but Z3 apparently calls it bv2int
                var smtFunc = new Bpl.Function(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(434L, "smt_nat_from_bv") + w, new List<TypeVariable>(),
                  new List<Variable>() { BplFormalVar(null, bv, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(435L, true)) }, BplFormalVar(null, Bpl.Type.Int, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(436L, false)),
                  null, attr);
                sink.AddTopLevelDeclaration(smtFunc);
                // function nat_from_bv67(bv67) : int;
                func = new Bpl.Function(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(437L, "nat_from_bv") + w, new List<TypeVariable>(),
                  new List<Variable>() { BplFormalVar(null, bv, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(438L, true)) }, BplFormalVar(null, Bpl.Type.Int, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(439L, false)),
                  null, null);
                sink.AddTopLevelDeclaration(func);
                // axiom (forall b: bv67 :: { nat_from_bv67(b) }
                //          0 <= nat_from_bv67(b) && nat_from_bv67(b) < 0x8_0000_0000_0000_0000 &&
                //          nat_from_bv67(b) == smt_nat_from_bv67(b));
                var bVar = new Bpl.BoundVariable(tok, new Bpl.TypedIdent(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(440L, "b"), BplBvType(w)));
                var b = new Bpl.IdentifierExpr(tok, bVar);
                var bv2nat = FunctionCall(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(441L, "nat_from_bv") + w, Bpl.Type.Int, b);
                var smt_bv2nat = FunctionCall(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(442L, "smt_nat_from_bv") + w, Bpl.Type.Int, b);
                var body = BplAnd(BplAnd(
                  Bpl.Expr.Le(Bpl.Expr.Literal(MutateCSharp.Schemata487.ReplaceNumericConstant_0(443L, 0)), bv2nat),
                  Bpl.Expr.Lt(bv2nat, Bpl.Expr.Literal(BaseTypes.BigNum.FromBigInt(BigInteger.One << w)))),
                  Bpl.Expr.Eq(bv2nat, smt_bv2nat));
                var ax = new Bpl.ForallExpr(tok, new List<Variable>() { bVar }, BplTrigger(bv2nat), body);
                sink.AddTopLevelDeclaration(new Bpl.Axiom(tok, ax));
            }
        }

        private void ComputeFunctionFuel()
        {
            foreach (ModuleDefinition m in program.RawModules())
            {
                foreach (TopLevelDecl d in m.TopLevelDecls)
                {
                    if (d is TopLevelDeclWithMembers)
                    {
                        var c = (TopLevelDeclWithMembers)d;
                        foreach (MemberDecl member in c.Members)
                        {
                            if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(447L, () => member is Function, () => RevealedInScope(member)))
                            {
                                Function f = (Function)member;
                                // declare the fuel constant
                                if (f.IsFueled)
                                {
                                    // const BaseFuel_FunctionA : LayerType
                                    Bpl.Constant baseFuel = new Bpl.Constant(f.tok, new Bpl.TypedIdent(f.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(453L, "BaseFuel_") + f.FullName, predef.LayerType), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(454L, false));
                                    sink.AddTopLevelDeclaration(baseFuel);
                                    Bpl.Expr baseFuel_expr = new Bpl.IdentifierExpr(f.tok, baseFuel);
                                    // const StartFuel_FunctionA : LayerType
                                    Bpl.Constant startFuel = new Bpl.Constant(f.tok, new Bpl.TypedIdent(f.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(455L, "StartFuel_") + f.FullName, predef.LayerType), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(456L, false));
                                    sink.AddTopLevelDeclaration(startFuel);
                                    Bpl.Expr startFuel_expr = new Bpl.IdentifierExpr(f.tok, startFuel);
                                    // const StartFuelAssert_FunctionA : LayerType
                                    Bpl.Constant startFuelAssert = new Bpl.Constant(f.tok, new Bpl.TypedIdent(f.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(457L, "StartFuelAssert_") + f.FullName, predef.LayerType), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(458L, false));
                                    sink.AddTopLevelDeclaration(startFuelAssert);
                                    Bpl.Expr startFuelAssert_expr = new Bpl.IdentifierExpr(f.tok, startFuelAssert);
                                    this.functionFuel.Add(new FuelConstant(f, baseFuel_expr, startFuel_expr, startFuelAssert_expr));
                                }

                                if (MutateCSharp.Schemata487.ReplaceBinExprOp_17(459L, () => f.IsOpaque, () => f.IsMadeImplicitlyOpaque(options)))
                                {
                                    CreateRevealableConstant(f);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void CreateRevealableConstant(Function f)
        {
            if (!this.functionReveals.ContainsKey(f))
            {
                // const reveal_FunctionA : bool
                Bpl.Constant revealTrigger =
                  new Bpl.Constant(f.tok, new Bpl.TypedIdent(f.tok, RevealStmt.RevealLemmaPrefix + f.FullName, Bpl.Type.Bool), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(465L, false));
                sink.AddTopLevelDeclaration(revealTrigger);
                Bpl.Expr revealTrigger_expr = new Bpl.IdentifierExpr(f.tok, revealTrigger);
                this.functionReveals[f] = revealTrigger_expr;

                // If this is an override, generate:
                //     axiom reveal_FunctionA ==> reveal_FunctionParent;
                if (f.OverriddenFunction is { IsOpaque: true })
                {
                    var revealParent = GetRevealConstant(f.OverriddenFunction);
                    var implication = BplImp(revealTrigger_expr, revealParent);
                    AddOtherDefinition(revealTrigger, new Axiom(f.tok, implication));
                }
            }
        }

        /// <summary>
        /// For every revealed type (class or trait) C<T> that extends a trait J<G(T)>, add:
        ///   axiom (forall T: Ty, $o: ref ::
        ///       { $Is($o, C(T)) }
        ///       $o != null && $Is($o, C(T)) ==> $Is($o, J(G(T)));
        ///   axiom (forall T: Ty, $Heap: Heap, $o: ref ::
        ///       { $IsAlloc($o, C(T), $Heap) }
        ///       $o != null && $IsAlloc($o, C(T), $Heap) ==> $IsAlloc($o, J(G(T)), $Heap);
        /// Note:
        ///   It is sometimes useful also to be able to determine the _absence_ of trait-parent relationships.
        ///   For example, suppose one can tell from the looking at the "extends" clauses in a program
        ///   that a class C does not (directly or transitively) extend a trait T. Then, given variables c and t
        ///   of static types C and T, respectively, the verifier should be able to infer c != t. This is not
        ///   possible with the axioms below. It will require an axiomatization of _all_ possible parent traits, not just
        ///   saying that some are possible. When this becomes needed, the axiomatization will need to be
        ///   embellished.
        /// </summary>
        private void AddTraitParentAxioms()
        {
            foreach (ModuleDefinition m in program.RawModules())
            {
                foreach (TopLevelDecl d in m.TopLevelDecls)
                {
                    var c = d as TopLevelDeclWithMembers;
                    if (MutateCSharp.Schemata487.ReplaceBinExprOp_17(467L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_22(466L, c, null), () => !RevealedInScope(d)))
                    {
                        continue;
                    }
                    foreach (var parentType in c.ParentTraits)
                    {
                        var childType = UserDefinedType.FromTopLevelDecl(c.tok, c);

                        Bpl.Expr heap; var heapVar = BplBoundVar(MutateCSharp.Schemata487.ReplaceStringConstant_6(473L, "$heap"), predef.HeapType, out heap);
                        Bpl.Expr o; var oVar = BplBoundVar(MutateCSharp.Schemata487.ReplaceStringConstant_6(474L, "$o"), TrType(childType), out o);
                        Bpl.Expr oNotNull = childType.IsRefType ? Bpl.Expr.Neq(o, predef.Null) : Bpl.Expr.True;

                        var oj = BoxifyForTraitParent(c.tok, o, ((UserDefinedType)parentType.NormalizeExpand()).ResolvedClass, childType);

                        List<Bpl.Expr> tyexprs;
                        var bvarsTypeParameters = MkTyParamBinders(GetTypeParams(c), out tyexprs);

                        // axiom (forall T: Ty, $o: ref ::
                        //     { $Is($o, C(T)) }
                        //     $o != null && $Is($o, C(T)) ==> $Is($o, J(G(T)));
                        var isC = MkIs(o, childType);
                        var isJ = MkIs(oj, parentType);
                        var bvs = new List<Bpl.Variable>();
                        bvs.AddRange(bvarsTypeParameters);
                        bvs.Add(oVar);
                        var tr = BplTrigger(isC);
                        var body = BplImp(BplAnd(oNotNull, isC), isJ);

                        sink.AddTopLevelDeclaration(new Bpl.Axiom(c.tok, new Bpl.ForallExpr(c.tok, bvs, tr, body),
                          $"type axiom for trait parent: {d} extends {parentType}"));

                        // axiom (forall T: Ty, $Heap: Heap, $o: ref ::
                        //     { $IsAlloc($o, C(T), $Heap) }
                        //     $o != null && $IsAlloc($o, C(T), $Heap) ==> $IsAlloc($o, J(G(T)), $Heap);
                        var isAllocC = MkIsAlloc(o, childType, heap);
                        var isAllocJ = MkIsAlloc(oj, parentType, heap);
                        bvs = new List<Bpl.Variable>();
                        bvs.AddRange(bvarsTypeParameters);
                        bvs.Add(oVar);
                        bvs.Add(heapVar);
                        tr = BplTrigger(isAllocC);
                        body = BplImp(BplAnd(oNotNull, isAllocC), isAllocJ);
                        sink.AddTopLevelDeclaration(new Bpl.Axiom(c.tok, new Bpl.ForallExpr(c.tok, bvs, tr, body),
                          $"allocation axiom for trait parent: {d} extends {parentType}"));
                    }
                }
            }
        }

        /// <summary>
        /// Construct an expression denoting the equality of e0 and e1, taking advantage of
        /// any available extensional equality based on the given Dafny type.
        /// </summary>
        public Expr TypeSpecificEqual(IToken tok, Dafny.Type type, Expr e0, Expr e1)
        {
            Contract.Requires(tok != null);
            Contract.Requires(type != null);
            Contract.Requires(e0 != null);
            Contract.Requires(e1 != null);

            type = type.NormalizeToAncestorType();
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_23(475L, type.AsSetType, null))
            {
                var finite = type.AsSetType.Finite;
                return FunctionCall(tok, finite ? BuiltinFunction.SetEqual : BuiltinFunction.ISetEqual, null, e0, e1);
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_24(476L, type.AsMapType, null))
            {
                var finite = type.AsMapType.Finite;
                return FunctionCall(tok, finite ? BuiltinFunction.MapEqual : BuiltinFunction.IMapEqual, null, e0, e1);
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_25(477L, type.AsMultiSetType, null))
            {
                return FunctionCall(tok, BuiltinFunction.MultiSetEqual, null, e0, e1);
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_26(478L, type.AsSeqType, null))
            {
                return FunctionCall(tok, BuiltinFunction.SeqEqual, null, e0, e1);
            }
            else if (type.IsIndDatatype)
            {
                return FunctionCall(tok, type.AsIndDatatype.FullSanitizedName + MutateCSharp.Schemata487.ReplaceStringConstant_6(479L, "#Equal"), Bpl.Type.Bool, e0, e1);
            }
            else
            {
                return Bpl.Expr.Eq(e0, e1);
            }

            return default;
        }

        /// <summary>
        /// Return a sequence of expressions whose conjunction denotes a memberwise equality of "dt".  Recursive
        /// codatatype equalities are written in one of the following ways:
        /// If the codatatype equality is on a type outside the SCC of "dt", then resort to ordinary equality.
        /// Else if the k==null, then:
        ///   Depending on "limited", use the #2, #1, or #0 (limited) form of codatatype equality.
        /// Else:
        ///   Depending on "limited", use the #2, #1, or #0 (limited) form of prefix equality, passing "k"
        ///   as the first argument.
        /// </summary>
        IEnumerable<Bpl.Expr> CoPrefixEquality(IToken tok, CoDatatypeDecl dt, List<Type> largs, List<Type> rargs, Bpl.Expr k, Bpl.Expr l, Bpl.Expr A, Bpl.Expr B, bool conjuncts = false)
        {
            Contract.Requires(tok != null);
            Contract.Requires(dt != null);
            Contract.Requires(A != null);
            Contract.Requires(B != null);
            Contract.Requires(l != null);
            Contract.Requires(predef != null);
            var etran = new ExpressionTranslator(this, predef, dt.tok, dt);
            // For example, for possibly infinite lists:
            //     codatatype SList<T> = Nil | SCons(head: T, tail: SList<T>);
            // produce with conjucts=false (default):
            //   (A.Nil? && B.Nil?) ||
            //   (A.Cons? && B.Cons? && A.head == B.head && Equal(k, A.tail, B.tail))
            //
            // with conjuncts=true:
            //   (A.Nil? ==> B.Nil?) &&
            //   (A.Cons? ==> (B.Cons? && A.head == B.head && Equal(k, A.tail, B.tail)))

            Dictionary<TypeParameter, Type> lsu = Util.Dict(GetTypeParams(dt), largs);
            Dictionary<TypeParameter, Type> rsu = Util.Dict(GetTypeParams(dt), rargs);

            foreach (var ctor in dt.Ctors)
            {
                Bpl.Expr aq = new Bpl.NAryExpr(tok, new Bpl.FunctionCall(GetReadonlyField(ctor.QueryField)), new List<Bpl.Expr> { A });
                Bpl.Expr bq = new Bpl.NAryExpr(tok, new Bpl.FunctionCall(GetReadonlyField(ctor.QueryField)), new List<Bpl.Expr> { B });
                Bpl.Expr chunk = Bpl.Expr.True;
                foreach (var dtor in ctor.Destructors)
                {  // note, ctor.Destructors has a field for every constructor parameter, whether or not the parameter was named in the source
                    var a = new Bpl.NAryExpr(tok, new Bpl.FunctionCall(GetReadonlyField(dtor)), new List<Bpl.Expr> { A });
                    var b = new Bpl.NAryExpr(tok, new Bpl.FunctionCall(GetReadonlyField(dtor)), new List<Bpl.Expr> { B });
                    var ty = dtor.Type;
                    Bpl.Expr q;
                    var codecl = ty.AsCoDatatype;
                    if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(482L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_27(480L, codecl, null), () => MutateCSharp.Schemata487.ReplaceBinExprOp_28(481L, codecl.SscRepr, dt.SscRepr)))
                    {
                        var lexprs = Map(ty.TypeArgs, tt => tt.Subst(lsu));
                        var rexprs = Map(ty.TypeArgs, tt => tt.Subst(rsu));
                        q = CoEqualCall(codecl, lexprs, rexprs, k, l, a, b);
                    }
                    else
                    {
                        // ordinary equality; let the usual translation machinery figure out the translation
                        var tyA = ty.Subst(lsu);
                        var tyB = ty.Subst(rsu);
                        var aa = CondApplyUnbox(tok, a, ty, tyA);
                        var bb = CondApplyUnbox(tok, b, ty, tyB);
                        var equal = new BinaryExpr(tok, BinaryExpr.Opcode.Eq, new BoogieWrapper(aa, tyA), new BoogieWrapper(bb, tyB));
                        equal.ResolvedOp = ModuleResolver.ResolveOp(equal.Op, tyA, tyB);  // resolve here
                        equal.Type = Type.Bool;  // resolve here
                        q = etran.TrExpr(equal);
                    }
                    chunk = BplAnd(chunk, q);
                }
                if (conjuncts)
                {
                    yield return Bpl.Expr.Binary(new NestedToken(tok, ctor.tok), BinaryOperator.Opcode.Imp, aq, BplAnd(bq, chunk));
                }
                else
                {
                    yield return BplAnd(BplAnd(aq, bq), BplImp(BplAnd(aq, bq), chunk));
                }
            }

            yield break;
        }

        public Bpl.Expr LayerSucc(Bpl.Expr e, int amt = 1)
        {
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_20(492L, amt, MutateCSharp.Schemata487.ReplaceNumericConstant_0(488L, 0)))
            {
                return e;
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_16(501L, amt, MutateCSharp.Schemata487.ReplaceNumericConstant_0(497L, 0)))
            {
                return FunctionCall(e.tok, BuiltinFunction.LayerSucc, null, LayerSucc(e, MutateCSharp.Schemata487.ReplaceBinExprOp_29(510L, amt, MutateCSharp.Schemata487.ReplaceNumericConstant_0(506L, 1))));
            }
            else
            {
                Contract.Assert(false);
                return null;
            }

            return default;
        }

        // Makes a call to equality, if k is null, or otherwise prefix equality. For codatatypes.
        Bpl.Expr CoEqualCall(CoDatatypeDecl codecl, List<Bpl.Expr> largs, List<Bpl.Expr> rargs, Bpl.Expr k, Bpl.Expr l, Bpl.Expr A, Bpl.Expr B, Bpl.IToken tok = null)
        {
            Contract.Requires(codecl != null);
            Contract.Requires(largs != null);
            Contract.Requires(rargs != null);
            Contract.Requires(l != null);
            Contract.Requires(A != null);
            Contract.Requires(B != null);
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_30(519L, tok, null))
            {
                tok = A.tok;
            }
            List<Bpl.Expr> args = Concat(largs, rargs);
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_31(520L, k, null))
            {
                args.Add(k);
            }
            args.AddRange(new List<Bpl.Expr> { l, A, B });
            var fn = MutateCSharp.Schemata487.ReplaceBinExprOp_32(521L, k, null) ? CoEqualName(codecl) : CoPrefixName(codecl);
            return FunctionCall(tok, fn, Bpl.Type.Bool, args);
        }

        // Same as above, but with Dafny-typed type-argument lists
        Bpl.Expr CoEqualCall(CoDatatypeDecl codecl, List<Type> largs, List<Type> rargs, Bpl.Expr k, Bpl.Expr l, Bpl.Expr A, Bpl.Expr B, IToken tok = null)
        {
            Contract.Requires(codecl != null);
            Contract.Requires(largs != null);
            Contract.Requires(rargs != null);
            Contract.Requires(l != null);
            Contract.Requires(A != null);
            Contract.Requires(B != null);
            return CoEqualCall(codecl, Map(largs, TypeToTy), Map(rargs, TypeToTy), k, l, A, B, tok);
        }

        static string CoEqualName(CoDatatypeDecl codecl)
        {
            Contract.Requires(codecl != null);
            return MutateCSharp.Schemata487.ReplaceStringConstant_6(522L, "$Eq#") + codecl.FullSanitizedName;
        }

        static string CoPrefixName(CoDatatypeDecl codecl)
        {
            Contract.Requires(codecl != null);
            return MutateCSharp.Schemata487.ReplaceStringConstant_6(523L, "$PrefixEq#") + codecl.FullSanitizedName;
        }

        void CreateBoundVariables<VT>(List<VT> formals, out List<Variable> bvs, out List<Bpl.Expr> args) where VT : IVariable
        {
            Contract.Requires(formals != null);
            Contract.Ensures(Contract.ValueAtReturn(out bvs).Count == Contract.ValueAtReturn(out args).Count);
            Contract.Ensures(Contract.ValueAtReturn(out bvs) != null);
            Contract.Ensures(cce.NonNullElements(Contract.ValueAtReturn(out args)));

            var varNameGen = CurrentIdGenerator.NestedFreshIdGenerator(MutateCSharp.Schemata487.ReplaceStringConstant_6(524L, "a#"));
            bvs = new List<Variable>();
            args = new List<Bpl.Expr>();
            foreach (var arg in formals)
            {
                Contract.Assert(arg != null);
                var nm = varNameGen.FreshId(string.Format(MutateCSharp.Schemata487.ReplaceStringConstant_6(525L, "#{0}#"), bvs.Count));
                Bpl.Variable bv = new Bpl.BoundVariable(arg.Tok, new Bpl.TypedIdent(arg.Tok, nm, TrType(arg.Type)));
                bvs.Add(bv);
                args.Add(new Bpl.IdentifierExpr(arg.Tok, bv));
            }
        }

        // This one says that this is /directly/ allocated, not that its "children" are,
        // i.e. h[x, alloc]
        public Bpl.Expr IsAlloced(IToken tok, Bpl.Expr heapExpr, Bpl.Expr e)
        {
            Contract.Requires(tok != null);
            Contract.Requires(heapExpr != null);
            Contract.Requires(e != null);
            Contract.Ensures(Contract.Result<Bpl.Expr>() != null);

            return ApplyUnbox(tok, ReadHeap(tok, heapExpr, e, predef.Alloc(tok)), Bpl.Type.Bool);
        }

        /// <summary>
        /// Returns read(heap: Heap, r: ref, f: Field) : Box.
        /// </summary>
        public Bpl.Expr ReadHeap(IToken tok, Expr heap, Expr r, Expr f)
        {
            Contract.Requires(tok != null);
            Contract.Requires(heap != null);
            Contract.Requires(r != null);
            Contract.Requires(f != null);
            Contract.Ensures(Contract.Result<Bpl.NAryExpr>() != null);

            var res = new Bpl.NAryExpr(tok,
              new Bpl.FunctionCall(new Bpl.IdentifierExpr(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(526L, "read"), predef.BoxType)),
              new List<Bpl.Expr> { heap, r, f });
            res.Type = predef.BoxType;
            return res;
        }

        public Bpl.NAryExpr ReadHeap(IToken tok, Expr heap, Expr r)
        {
            Contract.Requires(tok != null);
            Contract.Requires(heap != null);
            Contract.Requires(r != null);
            Contract.Ensures(Contract.Result<Bpl.NAryExpr>() != null);
            return new Bpl.NAryExpr(tok, new Bpl.MapSelect(tok, MutateCSharp.Schemata487.ReplaceNumericConstant_0(527L, 1)), new List<Bpl.Expr> { heap, r });
        }

        /// <summary>
        /// Returns update(h: Heap, r: ref, f: Field, v: Box) : Heap.
        /// </summary>
        public Boogie.NAryExpr UpdateHeap(IToken tok, Expr heap, Expr r, Expr f, Expr v)
        {
            Contract.Requires(tok != null);
            Contract.Requires(heap != null);
            Contract.Requires(r != null);
            Contract.Requires(f != null);
            Contract.Requires(v != null);
            Contract.Ensures(Contract.Result<Boogie.NAryExpr>() != null);


            return new Boogie.NAryExpr(tok,
              new Boogie.FunctionCall(new Boogie.IdentifierExpr(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(531L, "update"), heap.Type)),
              new List<Boogie.Expr> { heap, r, f, ApplyBox(tok, v) });
        }

        public Bpl.Expr DType(Bpl.Expr e, Bpl.Expr type)
        {
            return Bpl.Expr.Eq(FunctionCall(e.tok, BuiltinFunction.DynamicType, null, e), type);
        }

        public Bpl.Expr GetArrayIndexFieldName(IToken tok, List<Bpl.Expr> indices)
        {
            Bpl.Expr fieldName = null;
            foreach (Bpl.Expr index in indices)
            {
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_32(532L, fieldName, null))
                {
                    // the index in dimension 0:  IndexField(index0)
                    fieldName = FunctionCall(tok, BuiltinFunction.IndexField, null, index);
                }
                else
                {
                    // the index in dimension n:  MultiIndexField(...field name for first n indices..., index_n)
                    fieldName = FunctionCall(tok, BuiltinFunction.MultiIndexField, null, fieldName, index);
                }
            }
            return fieldName;
        }

        /// <summary>
        /// Returns true if the body of function "f" is available in module "context".
        /// This happens when the following conditions all hold:
        ///   - "f" has a body
        ///   - "f" is not opaque
        /// </summary>
        bool FunctionBodyIsAvailable(Function f, ModuleDefinition context, VisibilityScope scope, bool revealProtectedBody)
        {
            Contract.Requires(f != null);
            Contract.Requires(context != null);
            return MutateCSharp.Schemata487.ReplaceBinExprOp_5(540L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_5(534L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_33(533L, f.Body, null), () => !IsOpaque(f)), () => f.IsRevealedInScope(scope));
        }
        bool IsOpaque(MemberDecl f)
        {
            Contract.Requires(f != null);
            if (f is Function f1)
            {
                return MutateCSharp.Schemata487.ReplaceBinExprOp_17(553L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_17(547L, () => Attributes.Contains(f.Attributes, MutateCSharp.Schemata487.ReplaceStringConstant_6(546L, "opaque")), () => f.IsOpaque), () => f1.IsMadeImplicitlyOpaque(options));
            }
            else
            {
                return MutateCSharp.Schemata487.ReplaceBinExprOp_17(560L, () => Attributes.Contains(f.Attributes, MutateCSharp.Schemata487.ReplaceStringConstant_6(559L, "opaque")), () => f.IsOpaque);
            }

            return default;
        }
        static bool IsOpaqueRevealLemma(Method m)
        {
            Contract.Requires(m != null);
            return Attributes.Contains(m.Attributes, MutateCSharp.Schemata487.ReplaceStringConstant_6(566L, "opaque_reveal"));
        }


        void AddEnsures(List<Bpl.Ensures> list, Bpl.Ensures ens)
        {
            list.Add(ens);
            if (!ens.Free)
            {
                MutateCSharp.Schemata487.ReplacePostfixUnaryExprOp_34(567L, ref this.assertionCount);
            }
        }

        private Implementation AddImplementationWithAttributes(IToken tok, Procedure proc, List<Variable> inParams,
          List<Variable> outParams, List<Variable> localVariables, StmtList stmts, QKeyValue kv)
        {
            Bpl.Implementation impl = new Bpl.Implementation(tok, proc.Name,
              new List<Bpl.TypeVariable>(), inParams, outParams,
              localVariables, stmts, kv);
            AddVerboseNameAttribute(impl, proc.VerboseName);
            if (options.IsUsingZ3())
            {
                if (DisableNonLinearArithmetic)
                {
                    AddSmtOptionAttribute(impl, MutateCSharp.Schemata487.ReplaceStringConstant_6(568L, "smt.arith.nl"), MutateCSharp.Schemata487.ReplaceStringConstant_6(569L, "false"));
                }

                AddSmtOptionAttribute(impl, MutateCSharp.Schemata487.ReplaceStringConstant_6(570L, "smt.arith.solver"), ArithmeticSolver.ToString());
            }
            sink.AddTopLevelDeclaration(impl);
            return impl;
        }

        bool EmitImplementation(Attributes attributes)
        {
            // emit the impl only when there are proof obligations
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_16(575L, assertionCount, MutateCSharp.Schemata487.ReplaceNumericConstant_0(571L, 0)))
            {
                return MutateCSharp.Schemata487.ReplaceBooleanConstant_2(580L, true);
            }
            else
            {
                return MutateCSharp.Schemata487.ReplaceBooleanConstant_2(581L, false);
            }

            return default;
        }

        private void Reset()
        {
            currentModule = null;
            codeContext = null;
            CurrentIdGenerator.Reset();
            _tmpIEs.Clear();
            assertionCount = MutateCSharp.Schemata487.ReplaceNumericConstant_0(582L, 0);
        }

        public static Bpl.QKeyValue InlineAttribute(Bpl.IToken tok, Bpl.QKeyValue/*?*/ next = null)
        {
            Contract.Requires(tok != null);
            return new QKeyValue(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(586L, "inline"), new List<object>(), next);
        }

        public
            class Specialization
        {
            public readonly List<Formal/*!*/> Formals;
            public readonly List<Expression/*!*/> ReplacementExprs;
            public readonly List<BoundVar/*!*/> ReplacementFormals;
            public readonly Dictionary<IVariable, Expression> SubstMap;
            readonly BoogieGenerator boogieGenerator;
            [ContractInvariantMethod]
            void ObjectInvariant()
            {
                Contract.Invariant(cce.NonNullElements(Formals));
                Contract.Invariant(cce.NonNullElements(ReplacementExprs));
                Contract.Invariant(Formals.Count == ReplacementExprs.Count);
                Contract.Invariant(cce.NonNullElements(ReplacementFormals));
                Contract.Invariant(SubstMap != null);
            }

            public Specialization(IVariable formal, MatchCase mc, Specialization prev, BoogieGenerator boogieGenerator)
            {
                Contract.Requires(formal is Formal || formal is BoundVar);
                Contract.Requires(mc != null);
                Contract.Requires(prev == null || formal is BoundVar || !prev.Formals.Contains((Formal)formal));
                Contract.Requires(boogieGenerator != null);

                this.boogieGenerator = boogieGenerator;

                List<Expression> rArgs = new List<Expression>();
                foreach (BoundVar p in mc.Arguments)
                {
                    IdentifierExpr ie = new IdentifierExpr(p.tok, p.AssignUniqueName(boogieGenerator.currentDeclaration.IdGenerator));
                    ie.Var = p; ie.Type = ie.Var.Type;  // resolve it here
                    rArgs.Add(ie);
                }
                // create and resolve datatype value
                var r = new DatatypeValue(mc.tok, mc.Ctor.EnclosingDatatype.Name, mc.Ctor.Name, rArgs);
                r.Ctor = mc.Ctor;
                r.Type = new UserDefinedType(mc.tok, mc.Ctor.EnclosingDatatype.Name, new List<Type>()/*this is not right, but it seems like it won't matter here*/);

                Dictionary<IVariable, Expression> substMap = new Dictionary<IVariable, Expression>();
                substMap.Add(formal, r);

                // Fill in the fields
                Formals = new List<Formal>();
                ReplacementExprs = new List<Expression>();
                ReplacementFormals = new List<BoundVar>();
                SubstMap = new Dictionary<IVariable, Expression>();
                if (prev != null)
                {
                    Formals.AddRange(prev.Formals);
                    foreach (var e in prev.ReplacementExprs)
                    {
                        ReplacementExprs.Add(BoogieGenerator.Substitute(e, null, substMap));
                    }
                    foreach (var rf in prev.ReplacementFormals)
                    {
                        if (MutateCSharp.Schemata487.ReplaceBinExprOp_35(587L, rf, formal))
                        {
                            ReplacementFormals.Add(rf);
                        }
                    }
                    foreach (var entry in prev.SubstMap)
                    {
                        SubstMap.Add(entry.Key, BoogieGenerator.Substitute(entry.Value, null, substMap));
                    }
                }
                if (formal is Formal)
                {
                    Formals.Add((Formal)formal);
                    ReplacementExprs.Add(r);
                }
                ReplacementFormals.AddRange(mc.Arguments);
                SubstMap.Add(formal, r);
            }
        }

        (int olderParameterCount, Bpl.Expr olderCondition) OlderCondition(Function f, Bpl.Expr funcAppl, List<Bpl.Variable> inParams)
        {
            Contract.Requires(f != null);
            Contract.Requires(funcAppl != null);
            Contract.Requires(inParams != null);

            var olderParameterCount = f.Ins.Count(formal => formal.IsOlder);
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_20(592L, olderParameterCount, MutateCSharp.Schemata487.ReplaceNumericConstant_0(588L, 0)))
            {
                // nothing to do
                return (olderParameterCount, Bpl.Expr.True);
            }

            // For a function F(older x: X, y: Y), generate:
            //     (forall h: Heap :: { OlderTag(h) }
            //         IsGoodHeap(h) && OlderTag(h) && F(x, y) && IsAlloc(y, Y, h)
            //         ==>  IsAlloc(x, X, h))
            var heapVar = BplBoundVar(MutateCSharp.Schemata487.ReplaceStringConstant_6(597L, "$olderHeap"), predef.HeapType, out var heap);
            var etran = new ExpressionTranslator(this, predef, heap, f);

            var isGoodHeap = FunctionCall(f.tok, BuiltinFunction.IsGoodHeap, null, heap);
            var olderTag = FunctionCall(f.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(598L, "$OlderTag"), Bpl.Type.Bool, heap);
            Bpl.Expr older = Bpl.Expr.True;
            Bpl.Expr newer = Bpl.Expr.True;
            var i = MutateCSharp.Schemata487.ReplaceNumericConstant_0(599L, 0);
            if (!f.IsStatic)
            {
                var th = new Bpl.IdentifierExpr(f.tok, inParams[i]);
                MutateCSharp.Schemata487.ReplacePostfixUnaryExprOp_34(603L, ref i);
                var wh = GetWhereClause(f.tok, th, ModuleResolver.GetReceiverType(f.tok, f), etran, ISALLOC, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(604L, true));
                newer = BplAnd(newer, wh);
            }
            foreach (var formal in f.Ins)
            {
                var p = new Bpl.IdentifierExpr(f.tok, inParams[i]);
                MutateCSharp.Schemata487.ReplacePostfixUnaryExprOp_34(605L, ref i);
                var wh = GetWhereClause(formal.tok, p, formal.Type, etran, ISALLOC, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(606L, true));
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_31(607L, wh, null))
                {
                    if (formal.IsOlder)
                    {
                        older = BplAnd(older, wh);
                    }
                    else
                    {
                        newer = BplAnd(newer, wh);
                    }
                }
            }
            Contract.Assert(i == inParams.Count); // we should have used all the given inParams by now

            var body = BplImp(BplAnd(BplAnd(isGoodHeap, olderTag), BplAnd(funcAppl, newer)), older);
            var tr = new Bpl.Trigger(f.tok, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(608L, true), new List<Bpl.Expr> { olderTag });
            var olderCondition = new Bpl.ForallExpr(f.tok, new List<Bpl.TypeVariable>(), new List<Variable>() { heapVar }, null, tr, body);
            return (olderParameterCount, olderCondition);
        }

        Bpl.Expr AxiomActivation(Function f, ExpressionTranslator etran)
        {
            Contract.Requires(f != null);
            Contract.Requires(etran != null);
            Contract.Requires(VisibleInScope(f));
            if (InVerificationScope(f))
            {
                return
                  Bpl.Expr.Le(Bpl.Expr.Literal(forModule.CallGraph.GetSCCRepresentativePredecessorCount(f)), etran.FunctionContextHeight());
            }
            else
            {
                return Bpl.Expr.True;
            }

            return default;
        }


        Bpl.Type TrReceiverType(MemberDecl f)
        {
            Contract.Requires(f != null);
            return TrType(ModuleResolver.GetReceiverType(f.tok, f));
        }

        Bpl.Expr ReceiverNotNull(Bpl.Expr th)
        {
            Contract.Requires(th != null);
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_36(609L, th.Type, predef.RefType))
            {
                return Bpl.Expr.Neq(th, predef.Null);
            }
            else
            {
                return Bpl.Expr.True;
            }

            return default;
        }

        void AddFuelSuccSynonymAxiom(Function f, bool forHandle = false)
        {
            Contract.Requires(f != null);
            Contract.Requires(f.IsFuelAware());
            Contract.Requires(sink != null && predef != null);
            // axiom  // layer synonym axiom
            //   (forall s, $Heap, formals ::
            //       { f(Succ(s), $Heap, formals) }
            //       f(Succ(s), $Heap, formals) == f(s, $Heap, formals));

            List<Bpl.Expr> tyargs;
            var formals = MkTyParamBinders(GetTypeParams(f), out tyargs);
            var args1 = new List<Bpl.Expr>(tyargs);
            var args0 = new List<Bpl.Expr>(tyargs);

            var bv = new Bpl.BoundVariable(f.tok, new Bpl.TypedIdent(f.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(610L, "$ly"), predef.LayerType));
            formals.Add(bv);
            var s = new Bpl.IdentifierExpr(f.tok, bv);
            args1.Add(FunctionCall(f.tok, BuiltinFunction.LayerSucc, null, s));
            args0.Add(s);
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_17(611L, () => f.IsOpaque, () => f.IsMadeImplicitlyOpaque(options)))
            {
                var bvReveal = new Bpl.BoundVariable(f.tok, new Bpl.TypedIdent(f.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(617L, "$reveal"), Boogie.Type.Bool));
                formals.Add(bvReveal);
                var sReveal = new Bpl.IdentifierExpr(f.tok, bvReveal);
                args1.Add(sReveal);
                args0.Add(sReveal);
            }

            if (f is TwoStateFunction)
            {
                bv = new Bpl.BoundVariable(f.tok, new Bpl.TypedIdent(f.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(618L, "$prevHeap"), predef.HeapType));
                formals.Add(bv);
                s = new Bpl.IdentifierExpr(f.tok, bv);
                args1.Add(s);
                args0.Add(s);
            }
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(619L, () => !forHandle, () => f.ReadsHeap))
            {
                bv = new Bpl.BoundVariable(f.tok, new Bpl.TypedIdent(f.tok, predef.HeapVarName, predef.HeapType));
                formals.Add(bv);
                s = new Bpl.IdentifierExpr(f.tok, bv);
                args1.Add(s);
                args0.Add(s);
            }

            if (!f.IsStatic)
            {
                bv = new Bpl.BoundVariable(f.tok, new Bpl.TypedIdent(f.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(625L, "this"), TrReceiverType(f)));
                formals.Add(bv);
                s = new Bpl.IdentifierExpr(f.tok, bv);
                args1.Add(s);
                args0.Add(s);
            }
            if (!forHandle)
            {
                foreach (var p in f.Ins)
                {
                    bv = new Bpl.BoundVariable(p.tok, new Bpl.TypedIdent(p.tok, p.AssignUniqueName(f.IdGenerator), TrType(p.Type)));
                    formals.Add(bv);
                    s = new Bpl.IdentifierExpr(f.tok, bv);
                    args1.Add(s);
                    args0.Add(s);
                }
            }

            var name = forHandle ? f.FullSanitizedName + MutateCSharp.Schemata487.ReplaceStringConstant_6(626L, "#Handle") : f.FullSanitizedName;
            var funcID = new Bpl.FunctionCall(new Bpl.IdentifierExpr(f.tok, name, TrType(f.ResultType)));
            var funcAppl1 = new Bpl.NAryExpr(f.tok, funcID, args1);
            var funcAppl0 = new Bpl.NAryExpr(f.tok, funcID, args0);

            Bpl.Trigger tr = new Bpl.Trigger(f.tok, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(627L, true), new List<Bpl.Expr> { funcAppl1 });
            Bpl.Expr ax = new Bpl.ForallExpr(f.tok, new List<Bpl.TypeVariable>(), formals, null, tr, Bpl.Expr.Eq(funcAppl1, funcAppl0));
            AddOtherDefinition(GetOrCreateFunction(f), new Bpl.Axiom(f.tok, ax, MutateCSharp.Schemata487.ReplaceStringConstant_6(628L, "layer synonym axiom")));
        }

        void AddFuelZeroSynonymAxiom(Function f)
        {
            // axiom  // fuel axiom
            //   (forall s, $Heap, formals ::
            //       { f(AsFuelBottom(s), $Heap, formals) }
            //       f(s, $Heap, formals) == f($LZ, $Heap, formals));
            Contract.Requires(f != null);
            Contract.Requires(f.IsFuelAware());
            Contract.Requires(sink != null && predef != null);

            List<Bpl.Expr> tyargs;
            var formals = MkTyParamBinders(GetTypeParams(f), out tyargs);
            var args2 = new List<Bpl.Expr>(tyargs);
            var args1 = new List<Bpl.Expr>(tyargs);
            var args0 = new List<Bpl.Expr>(tyargs);

            var bv = new Bpl.BoundVariable(f.tok, new Bpl.TypedIdent(f.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(629L, "$ly"), predef.LayerType));
            formals.Add(bv);
            var s = new Bpl.IdentifierExpr(f.tok, bv);
            args2.Add(FunctionCall(f.tok, BuiltinFunction.AsFuelBottom, null, s));
            args1.Add(s);
            args0.Add(new Bpl.IdentifierExpr(f.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(630L, "$LZ"), predef.LayerType)); // $LZ
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_17(631L, () => f.IsOpaque, () => f.IsMadeImplicitlyOpaque(options)))
            {
                var bvReveal = new Bpl.BoundVariable(f.tok, new Bpl.TypedIdent(f.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(637L, "$reveal"), Boogie.Type.Bool));
                formals.Add(bvReveal);
                var sReveal = new Bpl.IdentifierExpr(f.tok, bvReveal);
                args2.Add(sReveal);
                args1.Add(sReveal);
                args0.Add(sReveal);
            }

            if (f is TwoStateFunction)
            {
                bv = new Bpl.BoundVariable(f.tok, new Bpl.TypedIdent(f.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(638L, "$prevHeap"), predef.HeapType));
                formals.Add(bv);
                s = new Bpl.IdentifierExpr(f.tok, bv);
                args2.Add(s);
                args1.Add(s);
                args0.Add(s);
            }
            if (f.ReadsHeap)
            {
                bv = new Bpl.BoundVariable(f.tok, new Bpl.TypedIdent(f.tok, predef.HeapVarName, predef.HeapType));
                formals.Add(bv);
                s = new Bpl.IdentifierExpr(f.tok, bv);
                args2.Add(s);
                args1.Add(s);
                args0.Add(s);
            }

            if (!f.IsStatic)
            {
                bv = new Bpl.BoundVariable(f.tok, new Bpl.TypedIdent(f.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(639L, "this"), TrReceiverType(f)));
                formals.Add(bv);
                s = new Bpl.IdentifierExpr(f.tok, bv);
                args2.Add(s);
                args1.Add(s);
                args0.Add(s);
            }
            foreach (var p in f.Ins)
            {
                bv = new Bpl.BoundVariable(p.tok, new Bpl.TypedIdent(p.tok, p.AssignUniqueName(f.IdGenerator), TrType(p.Type)));
                formals.Add(bv);
                s = new Bpl.IdentifierExpr(f.tok, bv);
                args2.Add(s);
                args1.Add(s);
                args0.Add(s);
            }

            var funcID = new Bpl.FunctionCall(new Bpl.IdentifierExpr(f.tok, f.FullSanitizedName, TrType(f.ResultType)));
            var funcAppl2 = new Bpl.NAryExpr(f.tok, funcID, args2);
            var funcAppl1 = new Bpl.NAryExpr(f.tok, funcID, args1);
            var funcAppl0 = new Bpl.NAryExpr(f.tok, funcID, args0);

            Bpl.Trigger tr = new Bpl.Trigger(f.tok, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(640L, true), new List<Bpl.Expr> { funcAppl2 });
            Bpl.Expr ax = new Bpl.ForallExpr(f.tok, new List<Bpl.TypeVariable>(), formals, null, tr, Bpl.Expr.Eq(funcAppl1, funcAppl0));
            AddOtherDefinition(GetOrCreateFunction(f), (new Bpl.Axiom(f.tok, ax, MutateCSharp.Schemata487.ReplaceStringConstant_6(641L, "fuel synonym axiom"))));
        }

        Bpl.Expr InSeqRange(IToken tok, Bpl.Expr index, Type indexType, Bpl.Expr seq, bool isSequence, Bpl.Expr lowerBound, bool includeUpperBound)
        {
            Contract.Requires(tok != null);
            Contract.Requires(index != null);
            Contract.Requires(indexType != null);
            Contract.Requires(seq != null);
            Contract.Ensures(Contract.Result<Bpl.Expr>() != null);

            if (indexType.IsBitVectorType)
            {
                index = ConvertExpression(tok, index, indexType, Type.Int);
            }
            Bpl.Expr lower;
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(643L, () => indexType.IsBitVectorType, () => MutateCSharp.Schemata487.ReplaceBinExprOp_32(642L, lowerBound, null)))
            {
                lower = Bpl.Expr.True;  // bitvectors are always non-negative
            }
            else
            {
                lower = Bpl.Expr.Le(lowerBound ?? Bpl.Expr.Literal(MutateCSharp.Schemata487.ReplaceNumericConstant_0(649L, 0)), index);
            }
            Bpl.Expr length = isSequence ?
              FunctionCall(tok, BuiltinFunction.SeqLength, null, seq) :
              ArrayLength(tok, seq, MutateCSharp.Schemata487.ReplaceNumericConstant_0(653L, 1), MutateCSharp.Schemata487.ReplaceNumericConstant_0(657L, 0));
            Bpl.Expr upper;
            if (includeUpperBound)
            {
                upper = Bpl.Expr.Le(index, length);
            }
            else
            {
                upper = Bpl.Expr.Lt(index, length);
            }
            return BplAnd(lower, upper);
        }

        ModuleDefinition currentModule = null;  // the module whose members are currently being translated
        ModuleDefinition forModule = null;  // the root module
        ICallable codeContext = null;  // the method/iterator whose implementation is currently being translated or the function whose specification is being checked for well-formedness
        Bpl.LocalVariable yieldCountVariable = null;  // non-null when an iterator body is being translated
        bool inBodyInitContext = MutateCSharp.Schemata487.ReplaceBooleanConstant_2(661L, false);  // true during the translation of the .BodyInit portion of a divided constructor body
        readonly Dictionary<string, Bpl.IdentifierExpr> definiteAssignmentTrackers = new Dictionary<string, Bpl.IdentifierExpr>();
        bool assertAsAssume = MutateCSharp.Schemata487.ReplaceBooleanConstant_2(662L, false); // generate assume statements instead of assert statements
        Func<IToken, bool> assertionOnlyFilter = null; // generate assume statements instead of assert statements if not targeted by {:only}
        public enum StmtType { NONE, ASSERT, ASSUME };
        public StmtType stmtContext = StmtType.NONE;  // the Statement that is currently being translated
        public bool adjustFuelForExists = MutateCSharp.Schemata487.ReplaceBooleanConstant_2(663L, true);  // fuel need to be adjusted for exists based on whether exists is in assert or assume stmt.

        public readonly FreshIdGenerator defaultIdGenerator = new FreshIdGenerator();

        public FreshIdGenerator CurrentIdGenerator
        {
            get
            {
                var decl = codeContext as Declaration;
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_37(664L, decl, null))
                {
                    return decl.IdGenerator;
                }
                return defaultIdGenerator;
            }
        }

        Dictionary<string, Bpl.IdentifierExpr> _tmpIEs = new Dictionary<string, Bpl.IdentifierExpr>();

        public int assertionCount = MutateCSharp.Schemata487.ReplaceNumericConstant_0(665L, 0);

        Bpl.IdentifierExpr GetTmpVar_IdExpr(Bpl.IToken tok, string name, Bpl.Type ty, List<Variable> locals)  // local variable that's shared between statements that need it
        {
            Contract.Requires(tok != null);
            Contract.Requires(name != null);
            Contract.Requires(ty != null);
            Contract.Requires(locals != null);
            Contract.Ensures(Contract.Result<Bpl.IdentifierExpr>() != null);

            Bpl.IdentifierExpr ie;
            if (_tmpIEs.TryGetValue(name, out ie))
            {
                Contract.Assume(ie.Type.Equals(ty));
            }
            else
            {
                // the "tok" and "ty" of the first request for this variable is the one we use
                var v = new Bpl.LocalVariable(tok, new Bpl.TypedIdent(tok, name, ty));  // important for the "$nw" client: no where clause (see GetNewVar_IdExpr)
                locals.Add(v);
                ie = new Bpl.IdentifierExpr(tok, v);
                _tmpIEs.Add(name, ie);
            }
            return ie;
        }

        Bpl.IdentifierExpr GetPrevHeapVar_IdExpr(IToken tok, List<Variable> locals)  // local variable that's shared between statements that need it
        {
            Contract.Requires(tok != null);
            Contract.Requires(locals != null); Contract.Requires(predef != null);
            Contract.Ensures(Contract.Result<Bpl.IdentifierExpr>() != null);

            return GetTmpVar_IdExpr(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(669L, "$prevHeap"), predef.HeapType, locals);
        }

        Bpl.IdentifierExpr GetNewVar_IdExpr(IToken tok, List<Variable> locals)  // local variable that's shared between statements that need it
        {
            Contract.Requires(tok != null);
            Contract.Requires(locals != null);
            Contract.Requires(predef != null);
            Contract.Ensures(Contract.Result<Bpl.IdentifierExpr>() != null);

            // important: the following declaration produces no where clause (that's why we're going through the trouble of setting of this variable in the first place)
            return GetTmpVar_IdExpr(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(670L, "$nw"), predef.RefType, locals);
        }

        /// <summary>
        /// Returns an expression whose value is the same as "expr", but that is guaranteed to preserve the its value passed
        /// the evaluation of other expressions.  If necessary, a new local variable called "name" with type "ty" is added to "locals" and
        /// assigned in "builder" to be used to hold the value of "expr".  It is assumed that all requests for a given "name"
        /// have the same type "ty" and that these variables can be shared.
        /// As an optimization, if "otherExprsCanAffectPreviouslyKnownExpressions" is "false", then "expr" itself is returned.
        /// </summary>
        Bpl.Expr SaveInTemp(Bpl.Expr expr, bool otherExprsCanAffectPreviouslyKnownExpressions, string name, Bpl.Type ty, BoogieStmtListBuilder builder, List<Variable> locals)
        {
            Contract.Requires(expr != null);
            Contract.Requires(name != null);
            Contract.Requires(ty != null);
            Contract.Requires(locals != null);
            Contract.Ensures(Contract.Result<Bpl.Expr>() != null);

            if (otherExprsCanAffectPreviouslyKnownExpressions)
            {
                var save = GetTmpVar_IdExpr(expr.tok, name, ty, locals);
                builder.Add(Bpl.Cmd.SimpleAssign(expr.tok, save, expr));
                return save;
            }
            else
            {
                return expr;
            }

            return default;
        }

        void InitializeFuelConstant(IToken tok, BoogieStmtListBuilder builder, ExpressionTranslator etran)
        {
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_16(675L, this.functionFuel.Count, MutateCSharp.Schemata487.ReplaceNumericConstant_0(671L, 0)))
            {
                builder.Add(new CommentCmd(MutateCSharp.Schemata487.ReplaceStringConstant_6(680L, "initialize fuel constant")));
            }
            FuelContext fuelContext = this.fuelContext;
            foreach (FuelConstant fuelConstant in this.functionFuel)
            {
                Function f = fuelConstant.f;
                Bpl.Expr baseFuel = fuelConstant.baseFuel;
                Bpl.Expr startFuel = fuelConstant.startFuel;
                Bpl.Expr startFuelAssert = fuelConstant.startFuelAssert;
                // find out what the initial value should be
                FuelSettingPair settings;
                var found = fuelContext.TryGetValue(f, out settings);
                if (!found)
                {
                    // If the context doesn't define fuel for this function, check for a fuel attribute (which supplies a default value if none is found)
                    settings = FuelSetting.FuelAttrib(f, out found);
                }

                if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(699L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_20(685L, settings.low, MutateCSharp.Schemata487.ReplaceNumericConstant_0(681L, 0)), () => MutateCSharp.Schemata487.ReplaceBinExprOp_20(694L, settings.high, MutateCSharp.Schemata487.ReplaceNumericConstant_0(690L, 0))))
                {
                    // Don't say anything about what startFuel and startFuel are set to
                    // Just add the fixpoints that allow us to shortcut to LZ:
                    // assume AsFuelBottom(startFuel) == startFuel
                    // assume AsFuelBottom(startFuelAssert) == startFuelAssert
                    builder.Add(TrAssumeCmd(tok, Bpl.Expr.Eq(FunctionCall(f.tok, BuiltinFunction.AsFuelBottom, null, startFuel), startFuel)));
                    builder.Add(TrAssumeCmd(tok, Bpl.Expr.Eq(FunctionCall(f.tok, BuiltinFunction.AsFuelBottom, null, startFuelAssert), startFuelAssert)));
                }
                else
                {
                    Bpl.Expr layer = etran.layerInterCluster.LayerN(settings.low, baseFuel);
                    Bpl.Expr layerAssert = etran.layerInterCluster.LayerN(settings.high, baseFuel);
                    builder.Add(TrAssumeCmd(tok, Bpl.Expr.Eq(startFuel, layer)));
                    builder.Add(TrAssumeCmd(tok, Bpl.Expr.Eq(startFuelAssert, layerAssert)));
                    // assume AsFuelBottom(BaseFuel_F) == BaseFuel_F;
                    builder.Add(TrAssumeCmd(tok, Bpl.Expr.Eq(FunctionCall(f.tok, BuiltinFunction.AsFuelBottom, null, baseFuel), baseFuel)));
                }
            }
        }

        bool DefineFuelConstant(IToken tok, Attributes attribs, BoogieStmtListBuilder builder, ExpressionTranslator etran)
        {
            bool defineFuel = MutateCSharp.Schemata487.ReplaceBooleanConstant_2(705L, false);
            builder.Add(new CommentCmd(MutateCSharp.Schemata487.ReplaceStringConstant_6(706L, "Assume Fuel Constant")));
            FuelContext fuelContext = new FuelContext();
            FuelSetting.FindFuelAttributes(attribs, fuelContext);
            foreach (KeyValuePair<Function, FuelSettingPair> fuel in fuelContext)
            {
                Function f = fuel.Key;
                FuelSettingPair settings = fuel.Value;
                FuelConstant fuelConstant = this.functionFuel.Find(x => MutateCSharp.Schemata487.ReplaceBinExprOp_38(707L, x.f, f));
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_39(708L, fuelConstant, null))
                {
                    Bpl.Expr startFuel = fuelConstant.startFuel;
                    Bpl.Expr startFuelAssert = fuelConstant.startFuelAssert;
                    Bpl.Expr moreFuel_expr = fuelConstant.MoreFuel(sink, predef, f.IdGenerator);
                    Bpl.Expr layer = etran.layerInterCluster.LayerN(settings.low, moreFuel_expr);
                    Bpl.Expr layerAssert = etran.layerInterCluster.LayerN(settings.high, moreFuel_expr);
                    builder.Add(TrAssumeCmd(tok, Bpl.Expr.Eq(startFuel, layer)));
                    builder.Add(TrAssumeCmd(tok, Bpl.Expr.Eq(startFuelAssert, layerAssert)));
                    defineFuel = MutateCSharp.Schemata487.ReplaceBooleanConstant_2(709L, true);
                }
            }
            return defineFuel;
        }

        internal static AssumeCmd optimizeExpr(bool minimize, Expression expr, IToken tok, ExpressionTranslator etran)
        {
            Contract.Requires(expr != null);
            Contract.Requires(expr.Type.IsIntegerType || expr.Type.IsRealType);
            Contract.Requires(tok != null && etran != null);

            var assumeCmd = new AssumeCmd(tok, Expr.True);
            assumeCmd.Attributes = new QKeyValue(expr.tok, (minimize ? MutateCSharp.Schemata487.ReplaceStringConstant_6(710L, "minimize") : MutateCSharp.Schemata487.ReplaceStringConstant_6(711L, "maximize")), new List<object> { etran.TrExpr(expr) }, null);
            return assumeCmd;
        }

        /// <summary>
        /// Return type arguments for function "f", where any type parameters are in terms of
        /// the context of "overridingFunction ?? f".
        ///
        /// In more symbols, suppose "f" is declared as follows:
        ///     class/trait Tr[A,B] {
        ///       function f[C,D](...): ...
        ///     }
        /// When "overridingFunction" is null, return:
        ///     [A, B, C, D]
        /// When "overridingFunction" is non-null and stands for:
        ///     class/trait Cl[G] extends Tr[X(G),Y(G)] {
        ///       function f[R,S](...): ...
        ///     }
        /// return:
        ///     [X(G), Y(G), R, S]
        ///
        /// See also GetTypeArgumentSubstitutionMap.
        /// </summary>
        private static List<Type> GetTypeArguments(Function f, Function/*?*/ overridingFunction)
        {
            Contract.Requires(f != null);
            Contract.Requires(overridingFunction == null || overridingFunction.EnclosingClass is TopLevelDeclWithMembers);
            Contract.Requires(overridingFunction == null || f.TypeArgs.Count == overridingFunction.TypeArgs.Count);

            List<Type> tyargs;
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_40(712L, overridingFunction, null))
            {
                tyargs = f.EnclosingClass.TypeArgs.ConvertAll(tp => (Type)new UserDefinedType(tp.tok, tp));
            }
            else
            {
                var cl = (TopLevelDeclWithMembers)overridingFunction.EnclosingClass;
                var typeMap = cl.ParentFormalTypeParametersToActuals;
                tyargs = f.EnclosingClass.TypeArgs.ConvertAll(tp => typeMap[tp]);
            }
            tyargs.AddRange((overridingFunction ?? f).TypeArgs.ConvertAll(tp => new UserDefinedType(tp.tok, tp)));
            return tyargs;
        }

        private void InsertChecksum(DatatypeDecl d, Bpl.Declaration decl)
        {
            Contract.Requires(VisibleInScope(d));
            byte[] data;
            using (var writer = new System.IO.StringWriter())
            {
                var printer = new Printer(writer, options);
                printer.PrintDatatype(d, MutateCSharp.Schemata487.ReplaceNumericConstant_0(713L, 0), null);
                data = Encoding.UTF8.GetBytes(writer.ToString());
            }

            InsertChecksum(decl, data);
        }

        private void InsertChecksum(Expression e, Bpl.Declaration decl)
        {
            byte[] data;
            using (var writer = new System.IO.StringWriter())
            {
                var printer = new Printer(writer, options);
                printer.PrintExpression(e, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(717L, false));
                data = Encoding.UTF8.GetBytes(writer.ToString());
            }

            InsertChecksum(decl, data);
        }

        private void InsertChecksum(Function f, Bpl.Declaration decl, bool specificationOnly = false)
        {
            Contract.Requires(f != null);
            Contract.Requires(decl != null);
            Contract.Requires(VisibleInScope(f));
            byte[] data;
            using (var writer = new System.IO.StringWriter())
            {
                var printer = new Printer(writer, options);
                writer.Write(f.GetFunctionDeclarationKeywords(options));
                printer.PrintAttributes(f.Attributes);
                printer.PrintFormals(f.Ins, f);
                writer.Write(MutateCSharp.Schemata487.ReplaceStringConstant_6(718L, ": "));
                printer.PrintType(f.ResultType);
                printer.PrintSpec("", f.Req, MutateCSharp.Schemata487.ReplaceNumericConstant_0(719L, 0));
                printer.PrintFrameSpecLine("", f.Reads, MutateCSharp.Schemata487.ReplaceNumericConstant_0(723L, 0));
                printer.PrintSpec("", f.Ens, MutateCSharp.Schemata487.ReplaceNumericConstant_0(727L, 0));
                printer.PrintDecreasesSpec(f.Decreases, MutateCSharp.Schemata487.ReplaceNumericConstant_0(731L, 0));
                writer.WriteLine();
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(742L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_5(736L, () => !specificationOnly, () => MutateCSharp.Schemata487.ReplaceBinExprOp_33(735L, f.Body, null)), () => RevealedInScope(f)))
                {
                    printer.PrintExpression(f.Body, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(748L, false));
                }
                data = Encoding.UTF8.GetBytes(writer.ToString());
            }

            InsertChecksum(decl, data);
        }

        private void InsertChecksum(Bpl.Declaration decl, byte[] data)
        {
            Contract.Requires(decl != null);
            Contract.Requires(data != null);
            var md5 = System.Security.Cryptography.MD5.Create();
            var hashedData = md5.ComputeHash(data);
            var checksum = BitConverter.ToString(hashedData);

            decl.AddAttribute(MutateCSharp.Schemata487.ReplaceStringConstant_6(749L, "checksum"), checksum);

            InsertUniqueIdForImplementation(decl);
        }

        public void InsertUniqueIdForImplementation(Bpl.Declaration decl)
        {
            var impl = decl as Bpl.Implementation;
            var prefix = UniqueIdPrefix ?? (decl.tok.filename == null ? "" : System.Text.RegularExpressions.Regex.Replace(decl.tok.filename, MutateCSharp.Schemata487.ReplaceStringConstant_6(750L, @".v\d+.dfy"), MutateCSharp.Schemata487.ReplaceStringConstant_6(751L, ".dfy")));
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(753L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_41(752L, impl, null), () => !string.IsNullOrEmpty(prefix)))
            {
                decl.AddAttribute(MutateCSharp.Schemata487.ReplaceStringConstant_6(759L, "id"), prefix + MutateCSharp.Schemata487.ReplaceStringConstant_6(760L, ":") + impl.Name + MutateCSharp.Schemata487.ReplaceStringConstant_6(761L, ":0"));
            }
        }

        void GenerateImplPrelude(Method m, bool wellformednessProc, List<Variable> inParams, List<Variable> outParams,
                                 BoogieStmtListBuilder builder, List<Variable> localVariables, ExpressionTranslator etran)
        {
            Contract.Requires(m != null);
            Contract.Requires(inParams != null);
            Contract.Requires(outParams != null);
            Contract.Requires(builder != null);
            Contract.Requires(localVariables != null);
            Contract.Requires(predef != null);
            Contract.Requires(wellformednessProc || m.Body != null);

            if (m is TwoStateLemma)
            {
                // $Heap := current$Heap;
                var heap = ExpressionTranslator.HeapIdentifierExpr(predef, m.tok);
                builder.Add(Bpl.Cmd.SimpleAssign(m.tok, heap, new Bpl.IdentifierExpr(m.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(762L, "current$Heap"), predef.HeapType)));
            }

            // set up the information used to verify the method's reads and modifies clauses
            if (etran.readsFrame != null)
            {
                DefineFrame(m.tok, etran.ReadsFrame(m.tok), m.Reads.Expressions, builder, localVariables, null);
            }
            DefineFrame(m.tok, etran.ModifiesFrame(m.tok), m.Mod.Expressions, builder, localVariables, null);
            if (wellformednessProc)
            {
                builder.AddCaptureState(m.tok, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(763L, false), MutateCSharp.Schemata487.ReplaceStringConstant_6(764L, "initial state"));
            }
            else
            {
                Contract.Assert(m.Body != null);  // follows from precondition and the if guard
                                                  // use the position immediately after the open-curly-brace of the body
                builder.AddCaptureState(m.Body.Tok, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(765L, true), MutateCSharp.Schemata487.ReplaceStringConstant_6(766L, "initial state"));
            }
        }

        void DefineFrame(IToken/*!*/ tok, Boogie.IdentifierExpr frameIdentifier, List<FrameExpression/*!*/>/*!*/ frameClause,
          BoogieStmtListBuilder/*!*/ builder, List<Variable>/*!*/ localVariables, string name, ExpressionTranslator/*?*/ etran = null)
        {
            Contract.Requires(tok != null);
            Contract.Requires(frameIdentifier != null);
            Contract.Requires(frameIdentifier.Type != null);
            Contract.Requires(cce.NonNullElements(frameClause));
            Contract.Requires(builder != null);
            Contract.Requires(cce.NonNullElements(localVariables));
            Contract.Requires(predef != null);

            if (MutateCSharp.Schemata487.ReplaceBinExprOp_42(767L, etran, null))
            {
                // This is the common case. It means that the frame will be defined in terms of the usual variable $Heap.
                // The one case where a frame is needed for a different heap is for lambda expressions, because they may
                // sit inside of an "old" expression.
                etran = new ExpressionTranslator(this, predef, tok, null);
            }
            // Declare a local variable $_Frame: [ref, Field]bool
            Bpl.LocalVariable frame = new Bpl.LocalVariable(tok, new Bpl.TypedIdent(tok, name ?? frameIdentifier.Name, frameIdentifier.Type));
            localVariables.Add(frame);
            // $_Frame := (lambda $o: ref, $f: Field :: $o != null && $Heap[$o,alloc] ==> ($o,$f) in Modifies/Reads-Clause);
            // $_Frame := (lambda $o: ref, $f: Field :: $o != null                    ==> ($o,$f) in Modifies/Reads-Clause);
            Bpl.BoundVariable oVar = new Bpl.BoundVariable(tok, new Bpl.TypedIdent(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(768L, "$o"), predef.RefType));
            Bpl.IdentifierExpr o = new Bpl.IdentifierExpr(tok, oVar);
            Bpl.BoundVariable fVar = new Bpl.BoundVariable(tok, new Bpl.TypedIdent(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(769L, "$f"), predef.FieldName(tok)));
            Bpl.IdentifierExpr f = new Bpl.IdentifierExpr(tok, fVar);
            Bpl.Expr oNotNull = Bpl.Expr.Neq(o, predef.Null);
            Bpl.Expr ante = BplAnd(oNotNull, etran.IsAlloced(tok, o));
            Bpl.Expr consequent = InRWClause(tok, o, f, frameClause, etran, null, null);
            Bpl.Expr lambda = new Bpl.LambdaExpr(tok, new List<TypeVariable>(), new List<Variable> { oVar, fVar }, null,
                                                 BplImp(ante, consequent));

            builder.Add(Bpl.Cmd.SimpleAssign(tok, new Bpl.IdentifierExpr(tok, frame), lambda));
        }

        void CheckFrameSubset(IToken tok, List<FrameExpression> calleeFrame,
                              Expression receiverReplacement, Dictionary<IVariable, Expression /*!*/> substMap,
                              ExpressionTranslator /*!*/ etran, Boogie.IdentifierExpr /*!*/ enclosingFrame,
                              BoogieStmtListBuilder /*!*/ builder,
                              PODesc.ProofObligationDescription desc,
                              Bpl.QKeyValue kv)
        {
            CheckFrameSubset(tok, calleeFrame, receiverReplacement, substMap, etran, enclosingFrame,
              (t, e, d, q) => builder.Add(Assert(t, e, d, q)), desc, kv);
        }

        void CheckFrameSubset(IToken tok, List<FrameExpression> calleeFrame,
                              Expression receiverReplacement, Dictionary<IVariable, Expression/*!*/> substMap,
                              ExpressionTranslator/*!*/ etran, Boogie.IdentifierExpr /*!*/ enclosingFrame,
                              Action<IToken, Bpl.Expr, PODesc.ProofObligationDescription, Bpl.QKeyValue> MakeAssert,
                              PODesc.ProofObligationDescription desc,
                              Bpl.QKeyValue kv)
        {
            Contract.Requires(tok != null);
            Contract.Requires(calleeFrame != null);
            Contract.Requires(receiverReplacement == null || substMap != null);
            Contract.Requires(etran != null);
            Contract.Requires(MakeAssert != null);
            Contract.Requires(predef != null);

            // emit: assert (forall o: ref, f: Field :: o != null && $Heap[o,alloc] && (o,f) in subFrame ==> enclosingFrame[o,f]);
            var oVar = new Bpl.BoundVariable(tok, new Bpl.TypedIdent(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(770L, "$o"), predef.RefType));
            var o = new Bpl.IdentifierExpr(tok, oVar);
            var fVar = new Bpl.BoundVariable(tok, new Bpl.TypedIdent(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(771L, "$f"), predef.FieldName(tok)));
            var f = new Bpl.IdentifierExpr(tok, fVar);
            var ante = Bpl.Expr.And(Bpl.Expr.Neq(o, predef.Null), etran.IsAlloced(tok, o));
            var oInCallee = InRWClause(tok, o, f, calleeFrame, etran, receiverReplacement, substMap);
            var inEnclosingFrame = Bpl.Expr.Select(enclosingFrame, o, f);

            var q = new Bpl.ForallExpr(tok, new List<TypeVariable>(), new List<Variable> { oVar, fVar },
                                            BplImp(BplAnd(ante, oInCallee), inEnclosingFrame));
            if (IsExprAlways(q, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(772L, true)))
            {
                return;
            }
            MakeAssert(tok, q, desc, kv);
        }

        void CheckFrameEmpty(IToken tok,
                             ExpressionTranslator/*!*/ etran, Boogie.IdentifierExpr /*!*/ frame,
                             BoogieStmtListBuilder/*!*/ builder, PODesc.ProofObligationDescription desc,
                             Bpl.QKeyValue kv)
        {
            Contract.Requires(tok != null);
            Contract.Requires(etran != null);
            Contract.Requires(frame != null);
            Contract.Requires(etran != null);
            Contract.Requires(predef != null);

            // emit: assert (forall o: ref, f: Field :: o != null && $Heap[o,alloc] ==> !frame[o,f]);
            var oVar = new Bpl.BoundVariable(tok, new Bpl.TypedIdent(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(773L, "$o"), predef.RefType));
            var o = new Bpl.IdentifierExpr(tok, oVar);
            var fVar = new Bpl.BoundVariable(tok, new Bpl.TypedIdent(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(774L, "$f"), predef.FieldName(tok)));
            var f = new Bpl.IdentifierExpr(tok, fVar);
            var ante = BplAnd(Bpl.Expr.Neq(o, predef.Null), etran.IsAlloced(tok, o));
            var inFrame = Bpl.Expr.Select(frame, o, f);
            var notInFrame = Bpl.Expr.Not(inFrame);

            var q = new Bpl.ForallExpr(tok, new List<TypeVariable>(), new List<Variable> { oVar, fVar },
              BplImp(ante, notInFrame));
            if (IsExprAlways(q, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(775L, true)))
            {
                return;
            }
            builder.Add(Assert(tok, q, desc, kv));
        }

        /// <summary>
        /// Returns true if it can statically determine that the expression q always evaluates to truth
        /// </summary>
        /// <param name="q">The expression</param>
        /// <param name="truth">The expected truth value that q might always have</param>
        /// <returns>True if q is always of the boolean value "truth"</returns>
        public static bool IsExprAlways(Bpl.Expr q, bool truth)
        {
            if (q is Bpl.ForallExpr forallExpr)
            {
                return MutateCSharp.Schemata487.ReplaceBinExprOp_5(777L, () => truth, () => IsExprAlways(forallExpr.Body, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(776L, true)));
            }
            if (q is Bpl.ExistsExpr existsExpr)
            {
                return MutateCSharp.Schemata487.ReplaceBinExprOp_5(784L, () => !truth, () => IsExprAlways(existsExpr.Body, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(783L, false)));
            }
            if (q is Bpl.LiteralExpr { isBool: true } lit && MutateCSharp.Schemata487.ReplaceBinExprOp_43(790L, () => lit.asBool, () => truth))
            {
                return MutateCSharp.Schemata487.ReplaceBooleanConstant_2(796L, true);
            }

            if (q is Bpl.NAryExpr n)
            {
                if (n.Fun is Bpl.BinaryOperator op && MutateCSharp.Schemata487.ReplaceBinExprOp_20(801L, n.Args.Count, MutateCSharp.Schemata487.ReplaceNumericConstant_0(797L, 2)))
                {
                    switch (op.Op)
                    {
                        case BinaryOperator.Opcode.And:
                            return truth
                              ? IsExprAlways(n.Args[0], true) && IsExprAlways(n.Args[1], true)
                              : IsExprAlways(n.Args[0], false) || IsExprAlways(n.Args[1], false);
                            break;
                        case BinaryOperator.Opcode.Or:
                            return truth
                              ? IsExprAlways(n.Args[0], true) || IsExprAlways(n.Args[1], true)
                              : IsExprAlways(n.Args[0], false) && IsExprAlways(n.Args[1], false);
                            break;
                        case BinaryOperator.Opcode.Imp:
                            return truth
                              ? IsExprAlways(n.Args[0], false) || IsExprAlways(n.Args[1], true)
                              : IsExprAlways(n.Args[0], true) && IsExprAlways(n.Args[1], false);
                            break;
                    }
                }
                else if (n.Fun is Bpl.UnaryOperator uop && MutateCSharp.Schemata487.ReplaceBinExprOp_20(810L, n.Args.Count, MutateCSharp.Schemata487.ReplaceNumericConstant_0(806L, 1)))
                {
                    switch (uop.Op)
                    {
                        case UnaryOperator.Opcode.Not:
                            return IsExprAlways(n.Args[0], !truth);
                            break;
                    }
                }
            }

            return MutateCSharp.Schemata487.ReplaceBooleanConstant_2(815L, false);
        }

        Bpl.Expr InRWClause(IToken tok, Bpl.Expr o, Bpl.Expr f, List<FrameExpression> rw, ExpressionTranslator etran,
                            Expression receiverReplacement, Dictionary<IVariable, Expression> substMap)
        {
            Contract.Requires(tok != null);
            Contract.Requires(o != null);
            // Contract.Requires(f != null); // f == null means approximate
            Contract.Requires(etran != null);
            Contract.Requires(cce.NonNullElements(rw));
            Contract.Requires(substMap == null || cce.NonNullDictionaryAndValues(substMap));
            Contract.Requires(predef != null);
            Contract.Requires(receiverReplacement == null || substMap != null);
            Contract.Ensures(Contract.Result<Bpl.Expr>() != null);
            return InRWClause(tok, o, f, rw, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(816L, false), etran, receiverReplacement, substMap);
        }
        Bpl.Expr InRWClause(IToken tok, Bpl.Expr o, Bpl.Expr f, List<FrameExpression> rw, bool useInUnchanged,
                            ExpressionTranslator etran,
                            Expression receiverReplacement, Dictionary<IVariable, Expression> substMap)
        {
            Contract.Requires(tok != null);
            Contract.Requires(o != null);
            // Contract.Requires(f != null); // f == null means approximate
            Contract.Requires(etran != null);
            Contract.Requires(cce.NonNullElements(rw));
            Contract.Requires(substMap == null || cce.NonNullDictionaryAndValues(substMap));
            Contract.Requires(predef != null);
            Contract.Requires(receiverReplacement == null || substMap != null);
            Contract.Ensures(Contract.Result<Bpl.Expr>() != null);
            var boxO = FunctionCall(tok, BuiltinFunction.Box, null, o);
            return InRWClause_Aux(tok, o, boxO, f, rw, useInUnchanged, etran, receiverReplacement, substMap);
        }

        /// <summary>
        /// By taking both an "o" and a "boxO" parameter, the caller has a choice of passing in either
        /// "o, Box(o)" for some "o" or "Unbox(bx), bx" for some "bx".
        /// </summary>
        Bpl.Expr InRWClause_Aux(IToken tok, Bpl.Expr o, Bpl.Expr boxO, Bpl.Expr f, List<FrameExpression> rw, bool usedInUnchanged,
                            ExpressionTranslator etran,
                            Expression receiverReplacement, Dictionary<IVariable, Expression> substMap)
        {
            Contract.Requires(tok != null);
            Contract.Requires(o != null);
            Contract.Requires(boxO != null);
            // Contract.Requires(f != null); // f == null means approximate
            Contract.Requires(etran != null);
            Contract.Requires(cce.NonNullElements(rw));
            Contract.Requires(substMap == null || cce.NonNullDictionaryAndValues(substMap));
            Contract.Requires(predef != null);
            Contract.Requires((substMap == null && receiverReplacement == null) || substMap != null);
            Contract.Ensures(Contract.Result<Bpl.Expr>() != null);

            // requires o to denote an expression of type RefType
            // "rw" is allowed to contain a WildcardExpr

            Bpl.Expr disjunction = Bpl.Expr.False;
            foreach (FrameExpression rwComponent in rw)
            {
                Expression e = rwComponent.E;
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_44(817L, substMap, null))
                {
                    e = Substitute(e, receiverReplacement, substMap);
                }

                Bpl.Expr disjunct;
                var eType = e.Type.NormalizeToAncestorType();
                if (e is WildcardExpr)
                {
                    // For /allocated:{0,1,3}, "function f(...)... reads *"
                    // is more useful if "reads *" excludes unallocated references,
                    // because otherwise, "reads *" lets f depend on unallocated state,
                    // which means that f may change whenever any new allocation occurs,
                    // which is generally undesirable.  Also, Dafny doesn't let you
                    // say "reads set o :: allocated(o)", so it's hard to work around
                    // this issue.
                    disjunct = etran.IsAlloced(tok, o);
                }
                else if (eType is SetType)
                {
                    // e[Box(o)]
                    bool pr;
                    disjunct = etran.TrInSet_Aux(tok, o, boxO, e, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(818L, true), out pr);
                }
                else if (eType is MultiSetType)
                {
                    // e[Box(o)] > 0
                    disjunct = etran.TrInMultiSet_Aux(tok, o, boxO, e, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(819L, true));
                }
                else if (eType is SeqType)
                {
                    // (exists i: int :: 0 <= i && i < Seq#Length(e) && Seq#Index(e,i) == Box(o))
                    Bpl.Variable iVar = new Bpl.BoundVariable(tok, new Bpl.TypedIdent(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(820L, "$i"), Bpl.Type.Int));
                    Bpl.Expr i = new Bpl.IdentifierExpr(tok, iVar);
                    Bpl.Expr iBounds = InSeqRange(tok, i, Type.Int, etran.TrExpr(e), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(821L, true), null, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(822L, false));
                    Bpl.Expr XsubI = FunctionCall(tok, BuiltinFunction.SeqIndex, predef.BoxType, etran.TrExpr(e), i);
                    // TODO: the equality in the next line should be changed to one that understands extensionality
                    //TRIG (exists $i: int :: 0 <= $i && $i < Seq#Length(read($h0, this, _module.DoublyLinkedList.Nodes)) && Seq#Index(read($h0, this, _module.DoublyLinkedList.Nodes), $i) == $Box($o))
                    disjunct = new Bpl.ExistsExpr(tok, new List<Variable> { iVar }, BplAnd(iBounds, Bpl.Expr.Eq(XsubI, boxO)));  // LL_TRIGGER
                }
                else
                {
                    // o == e
                    disjunct = Bpl.Expr.Eq(o, etran.TrExpr(e));
                }
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(825L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_45(823L, rwComponent.Field, null), () => MutateCSharp.Schemata487.ReplaceBinExprOp_31(824L, f, null)))
                {
                    Bpl.Expr q = Bpl.Expr.Eq(f, new Bpl.IdentifierExpr(rwComponent.E.tok, GetField(rwComponent.Field)));
                    if (usedInUnchanged)
                    {
                        q = BplOr(q,
                          Bpl.Expr.Eq(f, new Bpl.IdentifierExpr(rwComponent.E.tok, predef.AllocField)));
                    }
                    disjunct = BplAnd(disjunct, q);
                }
                disjunction = BplOr(disjunction, disjunct);
            }
            return disjunction;
        }

        void AddWellformednessCheck(DatatypeCtor ctor)
        {
            Contract.Requires(ctor != null);
            Contract.Requires(sink != null && predef != null);
            Contract.Requires(currentModule == null && codeContext == null && isAllocContext == null && fuelContext == null);
            Contract.Ensures(currentModule == null && codeContext == null && isAllocContext == null && fuelContext == null);

            proofDependencies.SetCurrentDefinition(MethodVerboseName(ctor.FullName, MethodTranslationKind.SpecWellformedness));

            if (!InVerificationScope(ctor))
            {
                // Checked in other file
                return;
            }

            // If there are no parameters with default values, there's nothing to do
            if (ctor.Formals.TrueForAll(f => MutateCSharp.Schemata487.ReplaceBinExprOp_46(831L, f.DefaultValue, null)))
            {
                return;
            }

            currentModule = ctor.EnclosingDatatype.EnclosingModuleDefinition;
            codeContext = ctor.EnclosingDatatype;
            fuelContext = FuelSetting.NewFuelContext(ctor.EnclosingDatatype);
            var etran = new ExpressionTranslator(this, predef, ctor.tok, null);

            // parameters of the procedure
            List<Variable> inParams = MkTyParamFormals(GetTypeParams(ctor.EnclosingDatatype), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(832L, true));
            foreach (var p in ctor.Formals)
            {
                Bpl.Type varType = TrType(p.Type);
                Bpl.Expr wh = GetWhereClause(p.tok, new Bpl.IdentifierExpr(p.tok, p.AssignUniqueName(ctor.IdGenerator), varType), p.Type, etran, NOALLOC);
                inParams.Add(new Bpl.Formal(p.tok, new Bpl.TypedIdent(p.tok, p.AssignUniqueName(ctor.IdGenerator), varType, wh), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(833L, true)));
            }

            // the procedure itself
            var req = new List<Bpl.Requires>();
            // free requires mh == ModuleContextHeight && fh == TypeContextHeight;
            req.Add(Requires(ctor.tok, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(834L, true), etran.HeightContext(ctor.EnclosingDatatype), null, null, null));
            var heapVar = new Bpl.IdentifierExpr(ctor.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(835L, "$Heap"), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(836L, false));
            var varlist = new List<Bpl.IdentifierExpr> { heapVar };
            var proc = new Bpl.Procedure(ctor.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(837L, "CheckWellformed") + NameSeparator + ctor.FullName, new List<Bpl.TypeVariable>(),
              inParams, new List<Variable>(),
      MutateCSharp.Schemata487.ReplaceBooleanConstant_2(838L, false), req, varlist, new List<Bpl.Ensures>(), etran.TrAttributes(ctor.Attributes, null));
            AddVerboseNameAttribute(proc, ctor.FullName, MethodTranslationKind.SpecWellformedness);
            sink.AddTopLevelDeclaration(proc);

            var implInParams = Bpl.Formal.StripWhereClauses(inParams);
            var locals = new List<Variable>();
            var builder = new BoogieStmtListBuilder(this, options);
            builder.Add(new CommentCmd(string.Format(MutateCSharp.Schemata487.ReplaceStringConstant_6(839L, "AddWellformednessCheck for datatype constructor {0}"), ctor)));
            builder.AddCaptureState(ctor.tok, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(840L, false), MutateCSharp.Schemata487.ReplaceStringConstant_6(841L, "initial state"));
            isAllocContext = new IsAllocContext(options, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(842L, true));

            DefineFrame(ctor.tok, etran.ReadsFrame(ctor.tok), new List<FrameExpression>(), builder, locals, null);

            // check well-formedness of each default-value expression
            foreach (var formal in ctor.Formals.Where(formal => MutateCSharp.Schemata487.ReplaceBinExprOp_33(843L, formal.DefaultValue, null)))
            {
                var e = formal.DefaultValue;
                CheckWellformed(e, new WFOptions(null, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(844L, true), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(845L, false), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(846L, true)), locals, builder, etran);
                builder.Add(new Bpl.AssumeCmd(e.tok, etran.CanCallAssumption(e)));
                CheckSubrange(e.tok, etran.TrExpr(e), e.Type, formal.Type, builder);
            }

            if (EmitImplementation(ctor.Attributes))
            {
                // emit the impl only when there are proof obligations.
                QKeyValue kv = etran.TrAttributes(ctor.Attributes, null);
                var implBody = builder.Collect(ctor.tok);
                AddImplementationWithAttributes(GetToken(ctor), proc, implInParams,
                  new List<Variable>(), locals, implBody, kv);
            }

            Contract.Assert(currentModule == ctor.EnclosingDatatype.EnclosingModuleDefinition);
            Contract.Assert(codeContext == ctor.EnclosingDatatype);
            isAllocContext = null;
            fuelContext = null;
            Reset();
        }

        /// <summary>
        /// If "declareLocals" is "false", then the locals are added only if they are new, that is, if
        /// they don't already exist in "locals".
        /// </summary>
        Bpl.Expr CtorInvocation(MatchCase mc, Type sourceType, ExpressionTranslator etran, List<Variable> locals, BoogieStmtListBuilder localTypeAssumptions, IsAllocType isAlloc, bool declareLocals = true)
        {
            Contract.Requires(mc != null);
            Contract.Requires(sourceType != null);
            Contract.Requires(etran != null);
            Contract.Requires(locals != null);
            Contract.Requires(localTypeAssumptions != null);
            Contract.Requires(predef != null);
            Contract.Ensures(Contract.Result<Bpl.Expr>() != null);

            sourceType = sourceType.NormalizeExpand();
            Contract.Assert(sourceType.TypeArgs.Count == mc.Ctor.EnclosingDatatype.TypeArgs.Count);
            var subst = new Dictionary<TypeParameter, Type>();
            for (var i = MutateCSharp.Schemata487.ReplaceNumericConstant_0(847L, 0); MutateCSharp.Schemata487.ReplaceBinExprOp_1(851L, i, mc.Ctor.EnclosingDatatype.TypeArgs.Count); MutateCSharp.Schemata487.ReplacePostfixUnaryExprOp_34(856L, ref i))
            {
                subst.Add(mc.Ctor.EnclosingDatatype.TypeArgs[i], sourceType.TypeArgs[i]);
            }

            List<Bpl.Expr> args = new List<Bpl.Expr>();
            for (int i = MutateCSharp.Schemata487.ReplaceNumericConstant_0(857L, 0); MutateCSharp.Schemata487.ReplaceBinExprOp_1(861L, i, mc.Arguments.Count); MutateCSharp.Schemata487.ReplacePostfixUnaryExprOp_34(866L, ref i))
            {
                BoundVar p = mc.Arguments[i];
                var nm = p.AssignUniqueName(currentDeclaration.IdGenerator);
                Bpl.Variable local = declareLocals ? null : locals.FirstOrDefault(v => MutateCSharp.Schemata487.ReplaceBinExprOp_8(867L, v.Name, nm));  // find previous local
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_47(868L, local, null))
                {
                    local = new Bpl.LocalVariable(p.tok, new Bpl.TypedIdent(p.tok, nm, TrType(p.Type)));
                    locals.Add(local);
                }
                else
                {
                    Contract.Assert(Bpl.Type.Equals(local.TypedIdent.Type, TrType(p.Type)));
                }
                var pFormalType = mc.Ctor.Formals[i].Type.Subst(subst);
                var pIsAlloc = (MutateCSharp.Schemata487.ReplaceBinExprOp_48(869L, isAlloc, ISALLOC)) ? isAllocContext.Var(p) : NOALLOC;
                Bpl.Expr wh = GetWhereClause(p.tok, new Bpl.IdentifierExpr(p.tok, local), pFormalType, etran, pIsAlloc);
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_31(870L, wh, null))
                {
                    localTypeAssumptions.Add(TrAssumeCmd(p.tok, wh));
                }
                CheckSubrange(p.tok, new Bpl.IdentifierExpr(p.tok, local), pFormalType, p.Type, localTypeAssumptions);
                args.Add(CondApplyBox(mc.tok, new Bpl.IdentifierExpr(p.tok, local), cce.NonNull(p.Type), mc.Ctor.Formals[i].Type));
            }
            Bpl.IdentifierExpr id = new Bpl.IdentifierExpr(mc.tok, mc.Ctor.FullName, predef.DatatypeType);
            return new Bpl.NAryExpr(mc.tok, new Bpl.FunctionCall(id), args);
        }

        Bpl.Expr CtorInvocation(IToken tok, DatatypeCtor ctor, ExpressionTranslator etran, List<Variable> locals, BoogieStmtListBuilder localTypeAssumptions)
        {
            Contract.Requires(tok != null);
            Contract.Requires(ctor != null);
            Contract.Requires(etran != null);
            Contract.Requires(locals != null);
            Contract.Requires(localTypeAssumptions != null);
            Contract.Requires(predef != null);
            Contract.Ensures(Contract.Result<Bpl.Expr>() != null);

            // create local variables for the formals
            var varNameGen = CurrentIdGenerator.NestedFreshIdGenerator(MutateCSharp.Schemata487.ReplaceStringConstant_6(871L, "a#"));
            var args = new List<Bpl.Expr>();
            foreach (Formal arg in ctor.Formals)
            {
                Contract.Assert(arg != null);
                var nm = varNameGen.FreshId(string.Format(MutateCSharp.Schemata487.ReplaceStringConstant_6(872L, "#{0}#"), args.Count));
                Bpl.Variable bv = new Bpl.LocalVariable(arg.tok, new Bpl.TypedIdent(arg.tok, nm, TrType(arg.Type)));
                locals.Add(bv);
                args.Add(new Bpl.IdentifierExpr(arg.tok, bv));
            }

            Bpl.IdentifierExpr id = new Bpl.IdentifierExpr(tok, ctor.FullName, predef.DatatypeType);
            return new Bpl.NAryExpr(tok, new Bpl.FunctionCall(id), args);
        }

        void AddCasePatternVarSubstitutions(CasePattern<BoundVar> pat, Bpl.Expr rhs, Dictionary<IVariable, Expression> substMap)
        {
            Contract.Requires(pat != null);
            Contract.Requires(rhs != null);
            Contract.Requires(substMap != null);
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_49(873L, pat.Var, null))
            {
                substMap.Add(pat.Var, new BoogieWrapper(rhs, pat.Var.Type));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_50(874L, pat.Arguments, null))
            {
                Contract.Assert(pat.Ctor != null);  // follows from successful resolution
                Contract.Assert(pat.Arguments.Count == pat.Ctor.Destructors.Count);  // follows from successful resolution
                for (int i = MutateCSharp.Schemata487.ReplaceNumericConstant_0(875L, 0); MutateCSharp.Schemata487.ReplaceBinExprOp_1(879L, i, pat.Arguments.Count); MutateCSharp.Schemata487.ReplacePostfixUnaryExprOp_34(884L, ref i))
                {
                    var arg = pat.Arguments[i];
                    var dtor = pat.Ctor.Destructors[i];
                    var r = new Bpl.NAryExpr(pat.tok, new Bpl.FunctionCall(GetReadonlyField(dtor)), new List<Bpl.Expr> { rhs });
                    var de = CondApplyUnbox(pat.tok, r, dtor.Type, arg.Expr.Type);
                    AddCasePatternVarSubstitutions(arg, de, substMap);
                }
            }
        }

        /// <summary>
        /// If "expr" is a binary boolean operation, then try to re-associate it to make the left argument smaller.
        /// If it is possible, then "true" is returned and "expr" returns as the re-associated expression (no boolean simplifications are performed).
        /// If not, then "false" is returned and "expr" is unchanged.
        /// </summary>
        bool ReAssociateToTheRight(ref Expression expr)
        {
            if (expr is BinaryExpr top && Expression.StripParens(top.E0) is BinaryExpr left)
            {
                // We have an expression of the form "(A oo B) pp C"
                var A = left.E0;
                var oo = left.ResolvedOp;
                var B = left.E1;
                var pp = top.ResolvedOp;
                var C = top.E1;

                if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(887L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_51(885L, oo, BinaryExpr.ResolvedOpcode.And), () => MutateCSharp.Schemata487.ReplaceBinExprOp_51(886L, pp, BinaryExpr.ResolvedOpcode.And)))
                {
                    // rewrite    (A && B) && C    into    A && (B && C)
                    expr = Expression.CreateAnd(A, Expression.CreateAnd(B, C, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(893L, false)), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(894L, false));
                    return MutateCSharp.Schemata487.ReplaceBooleanConstant_2(895L, true);
                }
                else if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(898L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_51(896L, oo, BinaryExpr.ResolvedOpcode.And), () => MutateCSharp.Schemata487.ReplaceBinExprOp_51(897L, pp, BinaryExpr.ResolvedOpcode.Imp)))
                {
                    // rewrite    (A && B) ==> C    into    A ==> (B ==> C)
                    expr = Expression.CreateImplies(A, Expression.CreateImplies(B, C, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(904L, false)), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(905L, false));
                    return MutateCSharp.Schemata487.ReplaceBooleanConstant_2(906L, true);
                }
                else if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(909L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_51(907L, oo, BinaryExpr.ResolvedOpcode.Or), () => MutateCSharp.Schemata487.ReplaceBinExprOp_51(908L, pp, BinaryExpr.ResolvedOpcode.Or)))
                {
                    // rewrite    (A || B) || C    into    A || (B || C)
                    expr = Expression.CreateOr(A, Expression.CreateOr(B, C, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(915L, false)), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(916L, false));
                    return MutateCSharp.Schemata487.ReplaceBooleanConstant_2(917L, true);
                }
                else if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(920L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_51(918L, oo, BinaryExpr.ResolvedOpcode.Imp), () => MutateCSharp.Schemata487.ReplaceBinExprOp_51(919L, pp, BinaryExpr.ResolvedOpcode.Or)))
                {
                    // rewrite    (A ==> B) || C    into    A ==> (B || C)
                    expr = Expression.CreateImplies(A, Expression.CreateOr(B, C, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(926L, false)), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(927L, false));
                    return MutateCSharp.Schemata487.ReplaceBooleanConstant_2(928L, true);
                }
            }
            return MutateCSharp.Schemata487.ReplaceBooleanConstant_2(929L, false);
        }

        void CheckCasePatternShape<VT>(CasePattern<VT> pat, Bpl.Expr rhs, IToken rhsTok, Type rhsType, BoogieStmtListBuilder builder)
          where VT : class, IVariable
        {
            Contract.Requires(pat != null);
            Contract.Requires(rhs != null);
            Contract.Requires(rhsTok != null);
            Contract.Requires(rhsType != null);
            Contract.Requires(builder != null);
            if (pat.Var != null)
            {
                CheckSubrange(rhsTok, rhs, rhsType, pat.Var.Type, builder);
            }
            else if (pat.Arguments != null)
            {
                Contract.Assert(pat.Ctor != null);  // follows from successful resolution
                Contract.Assert(pat.Arguments.Count == pat.Ctor.Destructors.Count);  // follows from successful resolution
                rhsType = rhsType.Normalize();
                Contract.Assert(rhsType is UserDefinedType && ((UserDefinedType)rhsType).ResolvedClass != null);
                var rhsTypeUdt = (UserDefinedType)rhsType;
                var typeSubstMap = TypeParameter.SubstitutionMap(rhsTypeUdt.ResolvedClass.TypeArgs, rhsTypeUdt.TypeArgs);

                var ctor = pat.Ctor;
                var correctConstructor = FunctionCall(pat.tok, ctor.QueryField.FullSanitizedName, Bpl.Type.Bool, rhs);
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_20(934L, ctor.EnclosingDatatype.Ctors.Count, MutateCSharp.Schemata487.ReplaceNumericConstant_0(930L, 1)))
                {
                    // There is only one constructor, so the value must have been constructed by it; might as well assume that here.
                    builder.Add(TrAssumeCmd(pat.tok, correctConstructor));
                }
                else
                {
                    builder.Add(Assert(pat.tok, correctConstructor, new PODesc.PatternShapeIsValid(ctor.Name)));
                }
                for (int i = MutateCSharp.Schemata487.ReplaceNumericConstant_0(939L, 0); MutateCSharp.Schemata487.ReplaceBinExprOp_1(943L, i, pat.Arguments.Count); MutateCSharp.Schemata487.ReplacePostfixUnaryExprOp_34(948L, ref i))
                {
                    var arg = pat.Arguments[i];
                    var dtor = ctor.Destructors[i];

                    var r = new Bpl.NAryExpr(arg.tok, new Bpl.FunctionCall(GetReadonlyField(dtor)), new List<Bpl.Expr> { rhs });
                    Type argType = dtor.Type.Subst(typeSubstMap);
                    var de = CondApplyUnbox(arg.tok, r, dtor.Type, argType);
                    CheckCasePatternShape(arg, de, arg.tok, argType, builder);
                }
            }
        }

        void CheckNonNull(IToken tok, Expression e, BoogieStmtListBuilder builder, ExpressionTranslator etran, Bpl.QKeyValue kv)
        {
            Contract.Requires(tok != null);
            Contract.Requires(e != null);
            Contract.Requires(builder != null);
            Contract.Requires(etran != null);
            Contract.Requires(predef != null);

            if (!e.Type.IsRefType)
            {
                // nothing to do
            }
            else if (e is ThisExpr)
            {
                // already known to be non-null
            }
            else if (e is StaticReceiverExpr)
            {
                // also ok
            }
            else
            {
                builder.Add(Assert(tok, Bpl.Expr.Neq(etran.TrExpr(e), predef.Null), new PODesc.NonNull(MutateCSharp.Schemata487.ReplaceStringConstant_6(949L, "target object"), e), kv));
            }
        }

        void CheckFunctionSelectWF(string what, BoogieStmtListBuilder builder, ExpressionTranslator etran, Expression e, string hint)
        {
            if (e is MemberSelectExpr sel && sel.Member is Function fn)
            {
                Bpl.Expr assertion = !InVerificationScope(fn) ? Bpl.Expr.True : Bpl.Expr.Not(etran.HeightContext(fn));
                builder.Add(Assert(GetToken(e), assertion, new PODesc.ValidInRecursion(what, hint)));
            }
        }

        void CloneVariableAsBoundVar(IToken tok, IVariable iv, string prefix, out BoundVar bv, out IdentifierExpr ie)
        {
            Contract.Requires(tok != null);
            Contract.Requires(iv != null);
            Contract.Requires(prefix != null);
            Contract.Ensures(Contract.ValueAtReturn(out bv) != null);
            Contract.Ensures(Contract.ValueAtReturn(out ie) != null);

            bv = new BoundVar(tok, CurrentIdGenerator.FreshId(prefix), iv.Type); // use this temporary variable counter, but for a Dafny name (the idea being that the number and the initial "_" in the name might avoid name conflicts)
            ie = new IdentifierExpr(tok, bv.Name);
            ie.Var = bv;  // resolve here
            ie.Type = bv.Type;  // resolve here
        }

        // Use trType to translate types in the args list
        Bpl.Expr ClassTyCon(UserDefinedType cl, List<Bpl.Expr> args)
        {
            Contract.Requires(cl != null);
            Contract.Requires(cce.NonNullElements(args));
            return ClassTyCon(cl.ResolvedClass, args);
        }

        Bpl.Expr ClassTyCon(TopLevelDecl cl, List<Bpl.Expr> args)
        {
            Contract.Requires(cl != null);
            Contract.Requires(cce.NonNullElements(args));
            return FunctionCall(cl.tok, GetClassTyCon(cl), predef.Ty, args);
        }

        // Takes a Bpl.Constant, which typically will be one from GetClass,
        // or some built-in type which has a class name, like Arrays or Arrows.
        // Note: Prefer to call ClassTyCon or TypeToTy instead.
        private string GetClassTyCon(TopLevelDecl dl)
        {
            Contract.Requires(dl != null);
            if (dl is InternalTypeSynonymDecl isyn)
            {
                dl = ((UserDefinedType)isyn.Rhs).ResolvedClass;
            }
            string name;
            if (classConstants.TryGetValue(dl, out name))
            {
                Contract.Assert(name != null);
            }
            else
            {
                name = AddTyAxioms(dl);
                classConstants.Add(dl, name);
            }
            return name;
        }

        public string Handle(int arity)
        {
            return MutateCSharp.Schemata487.ReplaceStringConstant_6(950L, "Handle") + arity;
        }

        public static string Apply(int arity)
        {
            return MutateCSharp.Schemata487.ReplaceStringConstant_6(951L, "Apply") + arity;
        }

        public static string Requires(int arity)
        {
            return MutateCSharp.Schemata487.ReplaceStringConstant_6(952L, "Requires") + arity;
        }

        public static string Reads(int arity)
        {
            return MutateCSharp.Schemata487.ReplaceStringConstant_6(953L, "Reads") + arity;
        }

        public string RequiresName(Function f)
        {
            return f.FullSanitizedName + MutateCSharp.Schemata487.ReplaceStringConstant_6(954L, "#requires");
        }

        private Expr NewOneHeapExpr(IToken tok)
        {
            return new Bpl.IdentifierExpr(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(955L, "$OneHeap"), predef.HeapType);
        }

        /// <summary>
        /// For expression "e" that is expected to come from a modifies/unchanged frame, return information
        /// that is useful for checking every reference from "e". More precisely,
        ///  * If "e" denotes a reference, then return
        ///       -- "description" as the string "object",
        ///       -- "type" as the type of that reference,
        ///       -- "obj" as the translation of that reference, and
        ///       -- "antecedent" as "true".
        ///  * If "e" denotes a set of references, then return
        ///       -- "description" as the string "set element",
        ///       -- "type" as the element type of that set,
        ///       -- "obj" as a new identifier of type "type", and
        ///       -- "antecedent" as "obj in e".
        ///  * If "e" denotes a multiset of references, then return
        ///       -- "description" as the string "multiset element",
        ///       -- "type" as the element type of that multiset,
        ///       -- "obj" as a new identifier of type "type", and
        ///       -- "antecedent" as "e[obj] > 0".
        ///  * If "e" denotes a sequence of references, then return
        ///       -- "description" as the string "sequence element",
        ///       -- "type" as the element type of that sequence,
        ///       -- "obj" as an expression "e[i]", where "i" is a new identifier, and
        ///       -- "antecedent" as "0 <= i < |e|".
        /// </summary>
        void EachReferenceInFrameExpression(Expression e, List<Bpl.Variable> locals, BoogieStmtListBuilder builder, ExpressionTranslator etran,
          out string description, out Type type, out Bpl.Expr obj, out Bpl.Expr antecedent)
        {
            Contract.Requires(e != null);
            Contract.Requires(locals != null);
            Contract.Requires(builder != null);
            Contract.Requires(etran != null);

            if (e.Type.IsRefType)
            {
                description = MutateCSharp.Schemata487.ReplaceStringConstant_6(956L, "object");
                type = e.Type;
                obj = etran.TrExpr(e);
                antecedent = Bpl.Expr.True;
                return;
            }

            var eType = e.Type.NormalizeToAncestorType();
            var isSetType = MutateCSharp.Schemata487.ReplaceBinExprOp_23(957L, eType.AsSetType, null);
            var isMultisetType = MutateCSharp.Schemata487.ReplaceBinExprOp_25(958L, eType.AsMultiSetType, null);
            Contract.Assert(isSetType || isMultisetType || eType.AsSeqType != null);
            var sType = eType.AsCollectionType;
            Contract.Assert(sType != null);
            type = sType.Arg;
            // var $x
            var name = CurrentIdGenerator.FreshId(MutateCSharp.Schemata487.ReplaceStringConstant_6(959L, "$unchanged#x"));
            var xVar = new Bpl.LocalVariable(e.tok, new Bpl.TypedIdent(e.tok, name, MutateCSharp.Schemata487.ReplaceBinExprOp_17(960L, () => isSetType, () => isMultisetType) ? TrType(type) : Bpl.Type.Int));
            locals.Add(xVar);
            var x = new Bpl.IdentifierExpr(e.tok, xVar);
            // havoc $x
            builder.Add(new Bpl.HavocCmd(e.tok, new List<Bpl.IdentifierExpr>() { x }));

            var s = etran.TrExpr(e);
            if (isSetType)
            {
                description = MutateCSharp.Schemata487.ReplaceStringConstant_6(966L, "set element");
                obj = x;
                antecedent = Bpl.Expr.SelectTok(e.tok, s, BoxIfNecessary(e.tok, x, type));
            }
            else if (isMultisetType)
            {
                description = MutateCSharp.Schemata487.ReplaceStringConstant_6(967L, "multiset element");
                obj = x;
                antecedent = Boogie.Expr.Gt(Bpl.Expr.SelectTok(e.tok, s, BoxIfNecessary(e.tok, x, type)), Boogie.Expr.Literal(MutateCSharp.Schemata487.ReplaceNumericConstant_0(968L, 0)));
            }
            else
            {
                description = MutateCSharp.Schemata487.ReplaceStringConstant_6(972L, "sequence element");
                obj = UnboxUnlessInherentlyBoxed(FunctionCall(e.tok, BuiltinFunction.SeqIndex, predef.BoxType, s, x), type);
                antecedent = InSeqRange(e.tok, x, Type.Int, s, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(973L, true), null, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(974L, false));
            }
        }

        private Bpl.Function GetOrCreateTypeConstructor(TopLevelDecl td)
        {
            if (declarationMapping.TryGetValue(td, out var result))
            {
                return result;
            }

            Bpl.Function func;
            if (td is TraitDecl { IsObjectTrait: true })
            {
                // the type constructor for "object" is in DafnyPrelude.bpl
                func = predef.ObjectTypeConstructor;
            }
            else if (td is TupleTypeDecl ttd && ttd.Dims == 2 && MutateCSharp.Schemata487.ReplaceBinExprOp_20(979L, ttd.NonGhostDims, MutateCSharp.Schemata487.ReplaceNumericConstant_0(975L, 2)))
            {
                // the type constructor for "Tuple2" is in DafnyPrelude.bpl
                func = this.predef.Tuple2TypeConstructor;
            }
            else
            {
                var inner_name = GetClass(td).TypedIdent.Name;
                string name = MutateCSharp.Schemata487.ReplaceStringConstant_6(984L, "T") + inner_name;

                Bpl.Variable tyVarOut = BplFormalVar(null, predef.Ty, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(985L, false));
                var args = td.TypeArgs.ConvertAll(_ => (Bpl.Variable)BplFormalVar(null, predef.Ty, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(986L, true)));
                func = new Bpl.Function(td.tok, name, args, tyVarOut);
                sink.AddTopLevelDeclaration(func);

                if (td is AbstractTypeDecl or InternalTypeSynonymDecl)
                {
                    // axiom (forall T0, T1, ... { T(T0, T1, T2) } :: WhereClause( T(T0, T1, T2) ));
                    var argBoundVars = new List<Bpl.Variable>();
                    var argExprs = td.TypeArgs.ConvertAll(ta => BplBoundVar(ta.Name, predef.Ty, argBoundVars));
                    var funcAppl = FunctionCall(td.tok, name, predef.Ty, argExprs);
                    var characteristics = td is AbstractTypeDecl ? ((AbstractTypeDecl)td).Characteristics : ((InternalTypeSynonymDecl)td).Characteristics;
                    var whereClause = GetTyWhereClause(funcAppl, characteristics);
                    if (MutateCSharp.Schemata487.ReplaceBinExprOp_31(987L, whereClause, null))
                    {
                        Bpl.Expr axiom;
                        if (MutateCSharp.Schemata487.ReplaceBinExprOp_20(992L, td.TypeArgs.Count, MutateCSharp.Schemata487.ReplaceNumericConstant_0(988L, 0)))
                        {
                            axiom = whereClause;
                        }
                        else
                        {
                            var tr = new Bpl.Trigger(td.tok, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(997L, true), new List<Bpl.Expr> { funcAppl });
                            axiom = new Bpl.ForallExpr(td.tok, new List<Bpl.TypeVariable>(), argBoundVars, null, tr, whereClause);
                        }
                        AddOtherDefinition(func, BplAxiom(axiom));
                    }
                }
            }

            declarationMapping[td] = func;
            return func;
        }

        Bpl.Constant GetClass(TopLevelDecl cl)
        {
            Contract.Requires(cl != null);
            Contract.Requires(predef != null);
            Contract.Ensures(Contract.Result<Bpl.Constant>() != null);

            if (classes.TryGetValue(cl, out var cc))
            {
                Contract.Assert(cc != null);
            }
            else
            {
                var name = cl.FullSanitizedName;
                if (cl is ClassLikeDecl { NonNullTypeDecl: { } })
                {
                    name = name + MutateCSharp.Schemata487.ReplaceStringConstant_6(998L, "?");  // TODO: this doesn't seem like the best place to do this name transformation
                }
                cc = new Bpl.Constant(cl.tok, new Bpl.TypedIdent(cl.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(999L, "class.") + name, predef.ClassNameType), !cl.EnclosingModuleDefinition.IsFacade);
                classes.Add(cl, cc);
            }
            return cc;
        }

        Bpl.Constant GetFieldNameFamily(string n)
        {
            Contract.Requires(n != null);
            Contract.Requires(predef != null);
            Contract.Ensures(Contract.Result<Bpl.Constant>() != null);

            if (fieldConstants.TryGetValue(n, out var cc))
            {
                Contract.Assert(cc != null);
            }
            else
            {
                cc = new Bpl.Constant(Token.NoToken, new Bpl.TypedIdent(Token.NoToken, MutateCSharp.Schemata487.ReplaceStringConstant_6(1000L, "field$") + n, predef.NameFamilyType), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1001L, true));
                fieldConstants.Add(n, cc);
            }
            return cc;
        }

        /// <summary>
        /// This method is expected to be called just once for each function in the program.
        /// </summary>
        Bpl.Function GetOrCreateFunction(Function f)
        {
            if (this.declarationMapping.TryGetValue(f, out var result))
            {
                return result;
            }

            Contract.Requires(f != null);
            Contract.Requires(predef != null && sink != null);

            // declare the function
            Bpl.Function func;
            {
                var formals = new List<Variable>();
                formals.AddRange(MkTyParamFormals(GetTypeParams(f), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1002L, false)));
                if (f.IsFuelAware())
                {
                    formals.Add(new Bpl.Formal(f.tok, new Bpl.TypedIdent(f.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(1003L, "$ly"), predef.LayerType), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1004L, true)));
                }

                if (MutateCSharp.Schemata487.ReplaceBinExprOp_17(1005L, () => f.IsOpaque, () => f.IsMadeImplicitlyOpaque(options)))
                {
                    formals.Add(new Bpl.Formal(f.tok, new Bpl.TypedIdent(f.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(1011L, "$reveal"), Boogie.Type.Bool), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1012L, true)));
                }
                if (f is TwoStateFunction)
                {
                    formals.Add(new Bpl.Formal(f.tok, new Bpl.TypedIdent(f.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(1013L, "$prevHeap"), predef.HeapType), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1014L, true)));
                }
                if (f.ReadsHeap)
                {
                    formals.Add(new Bpl.Formal(f.tok, new Bpl.TypedIdent(f.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(1015L, "$heap"), predef.HeapType), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1016L, true)));
                }
                if (!f.IsStatic)
                {
                    formals.Add(new Bpl.Formal(f.tok, new Bpl.TypedIdent(f.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(1017L, "this"), TrReceiverType(f)), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1018L, true)));
                }
                foreach (var p in f.Ins)
                {
                    formals.Add(new Bpl.Formal(p.tok, new Bpl.TypedIdent(p.tok, p.AssignUniqueName(f.IdGenerator), TrType(p.Type)), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1019L, true)));
                }
                var res = new Bpl.Formal(f.tok, new Bpl.TypedIdent(f.tok, Bpl.TypedIdent.NoName, TrType(f.ResultType)), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1020L, false));
                func = new Bpl.Function(f.tok, f.FullSanitizedName, new List<Bpl.TypeVariable>(), formals, res, MutateCSharp.Schemata487.ReplaceStringConstant_6(1021L, "function declaration for ") + f.FullName);
                if (InsertChecksums)
                {
                    InsertChecksum(f, func);
                }
                sink.AddTopLevelDeclaration(func);
            }

            // declare the corresponding canCall function
            {
                var formals = new List<Variable>();
                formals.AddRange(MkTyParamFormals(GetTypeParams(f), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1022L, false)));
                if (f is TwoStateFunction)
                {
                    formals.Add(new Bpl.Formal(f.tok, new Bpl.TypedIdent(f.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(1023L, "$prevHeap"), predef.HeapType), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1024L, true)));
                }
                if (f.ReadsHeap)
                {
                    formals.Add(new Bpl.Formal(f.tok, new Bpl.TypedIdent(f.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(1025L, "$heap"), predef.HeapType), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1026L, true)));
                }
                if (!f.IsStatic)
                {
                    formals.Add(new Bpl.Formal(f.tok, new Bpl.TypedIdent(f.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(1027L, "this"), TrReceiverType(f)), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1028L, true)));
                }
                foreach (var p in f.Ins)
                {
                    formals.Add(new Bpl.Formal(p.tok, new Bpl.TypedIdent(p.tok, p.AssignUniqueName(f.IdGenerator), TrType(p.Type)), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1029L, true)));
                }
                var res = new Bpl.Formal(f.tok, new Bpl.TypedIdent(f.tok, Bpl.TypedIdent.NoName, Bpl.Type.Bool), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1030L, false));
                var canCallF = new Bpl.Function(f.tok, f.FullSanitizedName + MutateCSharp.Schemata487.ReplaceStringConstant_6(1031L, "#canCall"), new List<Bpl.TypeVariable>(), formals, res);
                sink.AddTopLevelDeclaration(canCallF);
            }

            declarationMapping[f] = func;
            return func;
        }

        public
            /// <summary>
            /// A method can have several translations, suitable for different purposes.
            /// SpecWellformedness
            ///    This procedure is suitable for the wellformedness check of the
            ///    method's specification.
            ///    This means the pre- and postconditions are not filled in, since the
            ///    body of the procedure is going to check that these are well-formed in
            ///    the first place.
            /// InterModuleCall
            ///    This procedure is suitable for inter-module callers.
            ///    This means that predicate definitions inlined only for non-protected predicates.
            /// IntraModuleCall
            ///    This procedure is suitable for non-co-call intra-module callers.
            ///    This means that predicates can be inlined in the usual way.
            /// CoCall
            ///    This procedure is suitable for (intra-module) co-calls.
            ///    In these calls, some uses of greatest predicates may be replaced by
            ///    proof certificates.  Note, unless the method is a greatest lemma, there
            ///    is no reason to include a procedure for co-calls.
            /// Implementation
            ///    This procedure is suitable for checking the implementation of the
            ///    method.
            ///    If the method has no body, there is no reason to include this kind
            ///    of procedure.
            ///
            /// Note that SpecWellformedness and Implementation have procedure implementations
            /// but no callers, and vice versa for InterModuleCall, IntraModuleCall, and CoCall.
            /// </summary>
            enum MethodTranslationKind
        { SpecWellformedness, Call, CoCall, Implementation, OverrideCheck }

        private static readonly Dictionary<MethodTranslationKind, string> kindSanitizedPrefix =
          new() {
        { MethodTranslationKind.SpecWellformedness, MutateCSharp.Schemata487.ReplaceStringConstant_6(1032L, "CheckWellFormed") },
        { MethodTranslationKind.Call, MutateCSharp.Schemata487.ReplaceStringConstant_6(1033L, "Call") },
        { MethodTranslationKind.CoCall, MutateCSharp.Schemata487.ReplaceStringConstant_6(1034L, "CoCall") },
        { MethodTranslationKind.Implementation, MutateCSharp.Schemata487.ReplaceStringConstant_6(1035L, "Impl") },
        { MethodTranslationKind.OverrideCheck, MutateCSharp.Schemata487.ReplaceStringConstant_6(1036L, "OverrideCheck") },
          };

        static string MethodName(ICodeContext m, MethodTranslationKind kind)
        {
            Contract.Requires(m != null);
            return $"{kindSanitizedPrefix[kind]}{NameSeparator}{m.FullSanitizedName}";
        }

        private static readonly Dictionary<MethodTranslationKind, string> kindDescription =
          new Dictionary<MethodTranslationKind, string>() {
        {MethodTranslationKind.SpecWellformedness, MutateCSharp.Schemata487.ReplaceStringConstant_6(1037L, "well-formedness") },
        {MethodTranslationKind.Call, MutateCSharp.Schemata487.ReplaceStringConstant_6(1038L, "call") },
        {MethodTranslationKind.CoCall, MutateCSharp.Schemata487.ReplaceStringConstant_6(1039L, "co-call") },
        {MethodTranslationKind.Implementation, MutateCSharp.Schemata487.ReplaceStringConstant_6(1040L, "correctness") },
        {MethodTranslationKind.OverrideCheck, MutateCSharp.Schemata487.ReplaceStringConstant_6(1041L, "override check") },
          };

        static string MethodVerboseName(string fullName, MethodTranslationKind kind)
        {
            Contract.Requires(fullName != null);
            return $"{fullName} ({kindDescription[kind]})";
        }

        private static void AddVerboseNameAttribute(Bpl.NamedDeclaration boogieDecl, string dafnyName, MethodTranslationKind kind)
        {
            var verboseName = MethodVerboseName(dafnyName, kind);
            AddVerboseNameAttribute(boogieDecl, verboseName);
        }

        private static void AddVerboseNameAttribute(Bpl.NamedDeclaration targetDecl, string verboseName)
        {
            targetDecl.AddAttribute(MutateCSharp.Schemata487.ReplaceStringConstant_6(1042L, "verboseName"), new object[] { verboseName });
        }

        private static void AddSmtOptionAttribute(Bpl.NamedDeclaration targetDecl, string name, string value)
        {
            targetDecl.Attributes = new QKeyValue(targetDecl.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(1043L, "smt_option"), new List<object>() { name, value }, targetDecl.Attributes);
        }

        private static CallCmd Call(IToken tok, string methodName, List<Expr> ins, List<Bpl.IdentifierExpr> outs)
        {
            Contract.Requires(tok != null);
            Contract.Requires(methodName != null);
            Contract.Requires(ins != null);
            Contract.Requires(outs != null);

            CallCmd call;
            call = new CallCmd(tok, methodName, ins, outs);
            // CLEMENT enable this: call.ErrorData = "possible violation of function precondition";
            return call;
        }

        private void GenerateMethodParameters(IToken tok, Method m, MethodTranslationKind kind, ExpressionTranslator etran, List<Variable> inParams, out List<Variable> outParams)
        {
            GenerateMethodParametersChoose(tok, m, kind, !m.IsStatic, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1044L, true), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1045L, true), etran, inParams, out outParams);
        }

        private void GenerateMethodParametersChoose(IToken tok, IMethodCodeContext m, MethodTranslationKind kind, bool includeReceiver, bool includeInParams, bool includeOutParams,
          ExpressionTranslator etran, List<Variable> inParams, out List<Variable> outParams)
        {
            outParams = new List<Variable>();
            // Add type parameters first, always!
            inParams.AddRange(MkTyParamFormals(GetTypeParams(m), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1046L, true)));
            if (includeReceiver)
            {
                var receiverType = m is MemberDecl ? ModuleResolver.GetReceiverType(tok, (MemberDecl)m) : ModuleResolver.GetThisType(tok, (IteratorDecl)m);
                Contract.Assert(VisibleInScope(receiverType));

                Bpl.Expr wh;
                var receiver = new Bpl.IdentifierExpr(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(1047L, "this"), TrType(receiverType));
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1048L, () => m is Constructor, () => kind == MethodTranslationKind.Implementation))
                {
                    wh = BplAnd(
                      ReceiverNotNull(receiver),
                      GetWhereClause(tok, receiver, receiverType, etran, IsAllocType.NEVERALLOC));
                }
                else
                {
                    wh = BplAnd(
                      ReceiverNotNull(receiver),
                      (m is TwoStateLemma ? etran.Old : etran).GoodRef(tok, receiver, receiverType));
                }
                // for class constructors, the receiver is encoded as an output parameter
                Bpl.Formal thVar = new Bpl.Formal(tok, new Bpl.TypedIdent(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(1054L, "this"), TrType(receiverType), wh),
                  m is not Constructor);
                if (thVar.InComing)
                {
                    inParams.Add(thVar);
                }
                else
                {
                    outParams.Add(thVar);
                }
            }
            if (includeInParams)
            {
                foreach (Formal p in m.Ins)
                {
                    Contract.Assert(VisibleInScope(p.Type));
                    Bpl.Type varType = TrType(p.Type);
                    Bpl.Expr wh = GetExtendedWhereClause(p.tok,
                      new Bpl.IdentifierExpr(p.tok, p.AssignUniqueName(currentDeclaration.IdGenerator), varType),
                      p.Type, p.IsOld ? etran.Old : etran, isAllocContext.Var(p));
                    inParams.Add(new Bpl.Formal(p.tok, new Bpl.TypedIdent(p.tok, p.AssignUniqueName(currentDeclaration.IdGenerator), varType, wh), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1055L, true)));
                }
            }
            if (includeOutParams)
            {
                Contract.Assume(definiteAssignmentTrackers.Count == 0);
                foreach (Formal p in m.Outs)
                {
                    Contract.Assert(VisibleInScope(p.Type));
                    Contract.Assert(!p.IsOld);  // out-parameters are never old (perhaps we want to relax this condition in the future)
                    Bpl.Type varType = TrType(p.Type);
                    Bpl.Expr wh = GetWhereClause(p.tok,
                      new Bpl.IdentifierExpr(p.tok, p.AssignUniqueName(currentDeclaration.IdGenerator), varType),
                      p.Type, etran, isAllocContext.Var(p));
                    if (kind == MethodTranslationKind.Implementation)
                    {
                        var tracker = AddDefiniteAssignmentTracker(p, outParams, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1056L, true), m.IsGhost);
                        if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1059L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_31(1057L, wh, null), () => MutateCSharp.Schemata487.ReplaceBinExprOp_31(1058L, tracker, null)))
                        {
                            wh = BplImp(tracker, wh);
                        }
                    }
                    outParams.Add(new Bpl.Formal(p.tok, new Bpl.TypedIdent(p.tok, p.AssignUniqueName(currentDeclaration.IdGenerator), varType, wh), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1065L, false)));
                }
                // tear down definite-assignment trackers
                m.Outs.ForEach(RemoveDefiniteAssignmentTracker);
                Contract.Assert(definiteAssignmentTrackers.Count == 0);

                if (kind == MethodTranslationKind.Implementation)
                {
                    outParams.Add(new Bpl.Formal(tok, new Bpl.TypedIdent(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(1066L, "$_reverifyPost"), Bpl.Type.Bool), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1067L, false)));
                }
            }
        }

        public
            class BoilerplateTriple
        {  // a triple that is now a quintuple
            [ContractInvariantMethod]
            void ObjectInvariant()
            {
                Contract.Invariant(tok != null);
                Contract.Invariant(Expr != null);
                Contract.Invariant(IsFree || ErrorMessage != null);
            }

            public readonly IToken tok;
            public readonly bool IsFree;
            public readonly Bpl.Expr Expr;
            public readonly string ErrorMessage;
            public readonly string SuccessMessage;
            public readonly string Comment;


            public BoilerplateTriple(IToken tok, bool isFree, Bpl.Expr expr, string errorMessage, string successMessage, string comment)
            {
                Contract.Requires(tok != null);
                Contract.Requires(expr != null);
                Contract.Requires(isFree || errorMessage != null);
                this.tok = tok;
                IsFree = isFree;
                Expr = expr;
                ErrorMessage = errorMessage;
                SuccessMessage = successMessage;
                Comment = comment;
            }
        }

        /// <summary>
        /// There are 3 states of interest when generating two-state boilerplate:
        ///  S0. the beginning of the method or loop, which is where the modifies clause is interpreted
        ///  S1. the pre-state of the two-state interval
        ///  S2. the post-state of the two-state interval
        /// This method assumes that etranPre denotes S1, etran denotes S2, and that etranMod denotes S0.
        /// </summary>
        List<BoilerplateTriple/*!*/>/*!*/ GetTwoStateBoilerplate(IToken/*!*/ tok,
          List<FrameExpression/*!*/>/*!*/ modifiesClause, bool isGhostContext, bool canAllocate,
          ExpressionTranslator/*!*/ etranPre, ExpressionTranslator/*!*/ etran, ExpressionTranslator/*!*/ etranMod)
        {
            Contract.Requires(tok != null);
            Contract.Requires(modifiesClause != null);
            Contract.Requires(etranPre != null);
            Contract.Requires(etran != null);
            Contract.Ensures(cce.NonNullElements(Contract.Result<List<BoilerplateTriple>>()));

            var boilerplate = new List<BoilerplateTriple>();
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1077L, () => !canAllocate, () => MutateCSharp.Schemata487.ReplaceBinExprOp_20(1072L, modifiesClause.Count, MutateCSharp.Schemata487.ReplaceNumericConstant_0(1068L, 0))))
            {
                // plain and simple:  S1 == S2
                boilerplate.Add(new BoilerplateTriple(tok, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1083L, true), Bpl.Expr.Eq(etranPre.HeapExpr, etran.HeapExpr), null, null, MutateCSharp.Schemata487.ReplaceStringConstant_6(1084L, "frame condition")));
            }
            else
            {
                bool fieldGranularity = MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1085L, true);
                bool objectGranularity = !fieldGranularity;
                // the frame condition, which is free since it is checked with every heap update and call
                boilerplate.Add(new BoilerplateTriple(tok, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1086L, true), FrameCondition(tok, modifiesClause, canAllocate, FrameExpressionUse.Modifies, etranPre, etran, etranMod, objectGranularity), null, null, MutateCSharp.Schemata487.ReplaceStringConstant_6(1087L, "frame condition: object granularity")));
                if (modifiesClause.Exists(fe => fe.FieldName != null))
                {
                    boilerplate.Add(new BoilerplateTriple(tok, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1088L, true), FrameCondition(tok, modifiesClause, canAllocate, FrameExpressionUse.Modifies, etranPre, etran, etranMod, fieldGranularity), null, null, MutateCSharp.Schemata487.ReplaceStringConstant_6(1089L, "frame condition: field granularity")));
                }
                // HeapSucc(S1, S2) or HeapSuccGhost(S1, S2)
                Bpl.Expr heapSucc = HeapSucc(etranPre.HeapExpr, etran.HeapExpr, isGhostContext);
                boilerplate.Add(new BoilerplateTriple(tok, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1090L, true), heapSucc, null, null, MutateCSharp.Schemata487.ReplaceStringConstant_6(1091L, "boilerplate")));
            }
            return boilerplate;
        }

        /// <summary>
        /// There are 3 states of interest when generating a frame condition:
        ///  S0. the beginning of the method/loop, which is where the frame is interpreted
        ///  S1. the pre-state of the two-state interval
        ///  S2. the post-state of the two-state interval
        /// This method assumes that etranPre denotes S1, etran denotes S2, and that etranMod denotes S0.
        /// "use" being "Modifies" says to produce this frame condition:
        ///      if it's not in the frame, then it is unchanged
        /// "use" being "Reads" says to produce this frame condition:
        ///      if it's in the frame, then it is unchanged
        /// "use" being "Unchanged" says to produce this frame condition:
        ///      if it's in the frame, then it is unchanged,
        ///      and if it has a field designation, then furthermore 'alloc' is unchanged
        /// </summary>
        Bpl.Expr/*!*/ FrameCondition(IToken/*!*/ tok, List<FrameExpression/*!*/>/*!*/ frame, bool canAllocate, FrameExpressionUse use,
          ExpressionTranslator/*!*/ etranPre, ExpressionTranslator/*!*/ etran, ExpressionTranslator/*!*/ etranMod, bool fieldGranularity)
        {
            Contract.Requires(tok != null);
            Contract.Requires(etran != null);
            Contract.Requires(etranPre != null);
            Contract.Requires(cce.NonNullElements(frame));
            Contract.Requires(predef != null);
            Contract.Ensures(Contract.Result<Bpl.Expr>() != null);

            // read is handled in AddFrameAxiom
            //
            // if field granularity:
            // generate:
            //  (forall o: ref, f: Field :: { $Heap[o][f] }
            //      o != null
            // #if use==Modifies
            //      && old($Heap)[o][alloc]                     // include only in contexts that can allocate
            // #endif
            //      ==>
            // #if use==Modifies
            //        $Heap[o][f] == PreHeap[o][f] ||
            //        (o,f) in modifiesClause)
            // #else
            //        (o,f) in readsClause
            // #if use==Unchanged
            //        or f==alloc && there's some f' such that (o,f') in readsClause
            // #endif
            //        ==>
            //        $Heap[o][f] == PreHeap[o][f])
            // #endif
            //
            // if object granularity:
            // generate:
            //  (forall o: ref :: { $Heap[o] }
            //      o != null
            // #if use==Modifies
            //      && old($Heap)[o][alloc]                     // include only in contexts that can allocate
            // #endif
            //      ==>
            // #if use==Modifies
            //        $Heap[o] == PreHeap[o] ||
            //        o in modifiesClause)
            // #else
            //        o in readsClause
            //        ==>
            //        $Heap[o] == PreHeap[o])
            // #endif
            var oVar = new Bpl.BoundVariable(tok, new Bpl.TypedIdent(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(1092L, "$o"), predef.RefType));
            var o = new Bpl.IdentifierExpr(tok, oVar);

            Bpl.Expr f;
            List<Variable> quantifiedVars;
            List<TypeVariable> typeVars;
            Bpl.Expr heapOF;
            Bpl.Expr preHeapOF;
            if (fieldGranularity)
            {
                typeVars = new List<TypeVariable> { };
                var fVar = new Bpl.BoundVariable(tok, new Bpl.TypedIdent(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(1093L, "$f"), predef.FieldName(tok)));
                f = new Bpl.IdentifierExpr(tok, fVar);
                quantifiedVars = new List<Variable> { oVar, fVar };
                heapOF = ReadHeap(tok, etran.HeapExpr, o, f);
                preHeapOF = ReadHeap(tok, etranPre.HeapExpr, o, f);
            }
            else
            {
                // object granularity
                typeVars = new List<TypeVariable>();
                f = null;
                quantifiedVars = new List<Variable> { oVar };
                heapOF = ReadHeap(tok, etran.HeapExpr, o);
                preHeapOF = ReadHeap(tok, etranPre.HeapExpr, o);  // Box type is Bpl.Type.Bool, but no need to unbox for equality check
            }

            Bpl.Expr ante = Bpl.Expr.Neq(o, predef.Null);
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1095L, () => canAllocate, () => MutateCSharp.Schemata487.ReplaceBinExprOp_52(1094L, use, FrameExpressionUse.Modifies)))
            {
                ante = BplAnd(ante, etranMod.IsAlloced(tok, o));
            }
            var eq = Bpl.Expr.Eq(heapOF, preHeapOF);
            var ofInFrame = InRWClause(tok, o, f, frame, MutateCSharp.Schemata487.ReplaceBinExprOp_52(1101L, use, FrameExpressionUse.Unchanged), etranMod, null, null);
            Bpl.Expr consequent = MutateCSharp.Schemata487.ReplaceBinExprOp_52(1102L, use, FrameExpressionUse.Modifies) ? BplOr(eq, ofInFrame) : BplImp(ofInFrame, eq);

            var tr = new Bpl.Trigger(tok, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1103L, true), new List<Bpl.Expr> { heapOF });
            return new Bpl.ForallExpr(tok, typeVars, quantifiedVars, null, tr, BplImp(ante, consequent));
        }

        Bpl.Expr/*!*/ FrameConditionUsingDefinedFrame(IToken/*!*/ tok, ExpressionTranslator/*!*/ etranPre, ExpressionTranslator/*!*/ etran, ExpressionTranslator/*!*/ etranMod, Boogie.IdentifierExpr frameExpr)
        {
            Contract.Requires(tok != null);
            Contract.Requires(etran != null);
            Contract.Requires(etranPre != null);
            Contract.Requires(predef != null);
            Contract.Ensures(Contract.Result<Bpl.Expr>() != null);

            // generate:
            //  (forall o: ref, f: Field :: { $Heap[o,f] }
            //      o != null && old($Heap)[o,alloc] ==>
            //        $Heap[o,f] == PreHeap[o,f] ||
            //        $_Frame[o,f])
            Bpl.BoundVariable oVar = new Bpl.BoundVariable(tok, new Bpl.TypedIdent(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(1104L, "$o"), predef.RefType));
            Bpl.IdentifierExpr o = new Bpl.IdentifierExpr(tok, oVar);
            Bpl.BoundVariable fVar = new Bpl.BoundVariable(tok, new Bpl.TypedIdent(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(1105L, "$f"), predef.FieldName(tok)));
            Bpl.IdentifierExpr f = new Bpl.IdentifierExpr(tok, fVar);

            Bpl.Expr heapOF = ReadHeap(tok, etran.HeapExpr, o, f);
            Bpl.Expr preHeapOF = ReadHeap(tok, etranPre.HeapExpr, o, f);
            Bpl.Expr ante = BplAnd(Bpl.Expr.Neq(o, predef.Null), etranPre.IsAlloced(tok, o));
            Bpl.Expr consequent = Bpl.Expr.Eq(heapOF, preHeapOF);

            consequent = BplOr(consequent, Bpl.Expr.SelectTok(tok, frameExpr, o, f));

            Bpl.Trigger tr = new Bpl.Trigger(tok, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1106L, true), new List<Bpl.Expr> { heapOF });
            return new Bpl.ForallExpr(tok, new List<TypeVariable>(), new List<Variable> { oVar, fVar }, null, tr, BplImp(ante, consequent));
        }
        // ----- Type ---------------------------------------------------------------------------------
        // Translates a type into the representation Boogie type,
        // c.f. TypeToTy which translates a type to its Boogie expression
        // to be used in $Is and $IsAlloc.
        Bpl.Type TrType(Type type)
        {
            Contract.Requires(type != null);
            Contract.Requires(predef != null);
            Contract.Ensures(Contract.Result<Bpl.Type>() != null);

            while (MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1107L, true))
            {
                type = type.NormalizeExpand();
                if (type is TypeProxy)
                {
                    Contract.Assume(false);  // we assume that all proxies should have been dealt with in the resolver
                }
                var d = type.AsNewtype;
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_53(1108L, d, null))
                {
                    break;
                }
                else
                {
                    type = d.BaseType;  // the Boogie type to be used for the newtype is the same as for the base type
                }
            }

            if (type is BoolType)
            {
                return Bpl.Type.Bool;
            }
            else if (type is CharType)
            {
                return predef.CharType;
            }
            else if (type is IntType)
            {
                return Bpl.Type.Int;
            }
            else if (type is RealType)
            {
                return Bpl.Type.Real;
            }
            else if (type is BigOrdinalType)
            {
                return predef.BigOrdinalType;
            }
            else if (type is BitvectorType)
            {
                var t = (BitvectorType)type;
                return BplBvType(t.Width);
            }
            else if (type is IteratorDecl.EverIncreasingType)
            {
                return Bpl.Type.Int;
            }
            else if (type is ArrowType)
            {
                return predef.HandleType;
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_17(1109L, () => type.IsTypeParameter, () => type.IsAbstractType))
            {
                return predef.BoxType;
            }
            else if (type.IsInternalTypeSynonym)
            {
                return predef.BoxType;
            }
            else if (type.IsRefType)
            {
                // object and class types translate to ref
                return predef.RefType;
            }
            else if (type is UserDefinedType { ResolvedClass: TraitDecl })
            {
                // non-reference trait type
                return predef.BoxType;
            }
            else if (type.IsDatatype)
            {
                return predef.DatatypeType;
            }
            else if (type is SetType)
            {
                return ((SetType)type).Finite ? predef.SetType : predef.ISetType;
            }
            else if (type is MultiSetType)
            {
                return predef.MultiSetType;
            }
            else if (type is MapType)
            {
                return ((MapType)type).Finite ? predef.MapType : predef.IMapType;
            }
            else if (type is SeqType)
            {
                return predef.SeqType;
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected type
            }

            return default;
        }

        public Bpl.Expr CondApplyBox(Bpl.IToken tok, Bpl.Expr e, Type fromType, Type toType)
        {
            Contract.Requires(tok != null);
            Contract.Requires(e != null);
            Contract.Requires(fromType != null);
            Contract.Ensures(Contract.Result<Bpl.Expr>() != null);

            if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1122L, () => !ModeledAsBoxType(fromType), () => (MutateCSharp.Schemata487.ReplaceBinExprOp_17(1116L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_54(1115L, toType, null), () => ModeledAsBoxType(toType)))))
            {
                // if "e" denotes "Unbox(E): T", then just return "E"
                if (e is Bpl.NAryExpr { Fun: Bpl.TypeCoercion } coerce)
                {
                    Contract.Assert(coerce.Args.Count == 1);
                    Contract.Assert(Bpl.Type.Equals(((Bpl.TypeCoercion)coerce.Fun).Type, TrType(fromType)));
                    if (coerce.Args[MutateCSharp.Schemata487.ReplaceNumericConstant_0(1128L, 0)] is Bpl.NAryExpr { Fun: Bpl.FunctionCall { FunctionName: "$Unbox" } } call)
                    {
                        Contract.Assert(call.Args.Count == 1);
                        return call.Args[MutateCSharp.Schemata487.ReplaceNumericConstant_0(1132L, 0)];
                    }
                }
                // return "Box(e)"
                return FunctionCall(tok, BuiltinFunction.Box, null, e);
            }
            else
            {
                return e;
            }

            return default;
        }

        public Bpl.Expr BoxIfNecessary(Bpl.IToken tok, Bpl.Expr e, Type fromType)
        {
            Contract.Requires(tok != null);
            Contract.Requires(e != null);
            Contract.Requires(fromType != null);
            Contract.Ensures(Contract.Result<Bpl.Expr>() != null);

            return CondApplyBox(tok, e, fromType, null);
        }

        public Bpl.Expr CondApplyUnbox(Bpl.IToken tok, Bpl.Expr e, Type fromType, Type toType)
        {
            Contract.Requires(tok != null);
            Contract.Requires(e != null);
            Contract.Requires(fromType != null);
            Contract.Requires(toType != null);
            Contract.Ensures(Contract.Result<Bpl.Expr>() != null);

            if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1136L, () => ModeledAsBoxType(fromType), () => !ModeledAsBoxType(toType)))
            {
                return FunctionCall(tok, BuiltinFunction.Unbox, TrType(toType), e);
            }
            else
            {
                return e;
            }

            return default;
        }

        /// <summary>
        ///   If the type is not normally boxed, insert a box around it.
        ///   For lambda functions.
        /// </summary>
        public Bpl.Expr BoxIfNotNormallyBoxed(Bpl.IToken tok, Bpl.Expr e, Type t)
        {
            if (!ModeledAsBoxType(t))
            {
                return ApplyBox(tok, e);
            }
            else
            {
                return e;
            }

            return default;
        }

        /// <summary>
        ///   If the passed expression is not already boxed, box it.
        /// </summary>
        public Bpl.Expr ApplyBox(Bpl.IToken tok, Bpl.Expr e)
        {
            Contract.Assert(tok != null);
            Contract.Assert(e != null);
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_17(1143L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_36(1142L, e.Type, predef.BoxType), () => e is NAryExpr { Fun.FunctionName: "$Box" }))
            {
                return e;
            }
            return FunctionCall(tok, BuiltinFunction.Box, null, e);
        }

        /// <summary>
        ///   If the expression is boxed, but the type is not boxed, this unboxes it.
        ///   For lambda functions.
        /// KRML: The name of this method is really confusing. It seems it should be named something like UnboxUnlessInherentlyBoxed.
        /// </summary>
        public Bpl.Expr UnboxUnlessInherentlyBoxed(Bpl.Expr e, Type t)
        {
            if (!ModeledAsBoxType(t))
            {
                return FunctionCall(e.tok, BuiltinFunction.Unbox, TrType(t), e);
            }
            else
            {
                return e;
            }

            return default;
        }

        public Expr UnboxUnlessBoxType(IToken tok, Expr e, Type type)
        {
            return MutateCSharp.Schemata487.ReplaceBinExprOp_36(1149L, TrType(type), predef.BoxType) ? e : ApplyUnbox(tok, e, TrType(type));
        }

        /// <summary>
        ///   Unboxes an expression with the Box type.
        /// </summary>
        public Bpl.Expr ApplyUnbox(Bpl.IToken tok, Bpl.Expr e, Bpl.Type ty)
        {
            Contract.Assert(e != null);
            Contract.Assert(ty != null);
            Contract.Assert(tok != null);
            Contract.Assert((e.Type != null && e.Type.Equals(predef.BoxType) ||
                            (e.ShallowType != null && e.ShallowType.Equals(predef.BoxType))));
            return FunctionCall(tok, BuiltinFunction.Unbox, ty, e);
        }

        public Boogie.Expr BoxifyForTraitParent(Bpl.IToken tok, Boogie.Expr obj, MemberDecl member, Type fromType)
        {
            return BoxifyForTraitParent(tok, obj, member.EnclosingClass, fromType);
        }

        public Boogie.Expr BoxifyForTraitParent(Bpl.IToken tok, Boogie.Expr obj, TopLevelDecl topLevelDecl, Type fromType)
        {
            if (topLevelDecl is TraitDecl { IsReferenceTypeDecl: false })
            {
                return BoxIfNecessary(tok, obj, fromType);
            }
            return obj;
        }

        public static bool ModeledAsBoxType(Type t)
        {
            Contract.Requires(t != null);
            t = t.NormalizeExpand();
            if (t is TypeProxy)
            {
                // unresolved proxy
                return MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1150L, false);
            }
            var res = MutateCSharp.Schemata487.ReplaceBinExprOp_17(1169L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_17(1163L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_17(1157L, () => t.IsTypeParameter, () => (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1151L, () => t.IsTraitType, () => !t.IsRefType))), () => t.IsAbstractType), () => t.IsInternalTypeSynonym);
            Contract.Assert(t.IsArrowType ? !res : true);
            return res;
        }

        // ----- Statement ----------------------------------------------------------------------------

        /// <summary>
        /// A ForceCheckToken is a token wrapper whose purpose is to hide inheritance.
        /// </summary>
        public class ForceCheckToken : TokenWrapper
        {
            public ForceCheckToken(IToken tok)
              : base(tok)
            {
                Contract.Requires(tok != null);
            }
            public static IToken Unwrap(IToken tok)
            {
                Contract.Requires(tok != null);
                Contract.Ensures(Contract.Result<IToken>() != null);
                var ftok = tok as ForceCheckToken;
                return MutateCSharp.Schemata487.ReplaceBinExprOp_55(1175L, ftok, null) ? ftok.WrappedToken : tok;
            }

            public override IToken WithVal(string newVal)
            {
                return new ForceCheckToken(WrappedToken.WithVal(newVal));
            }
        }

        Bpl.PredicateCmd Assert(IToken tok, Bpl.Expr condition, PODesc.ProofObligationDescription description, Bpl.QKeyValue kv = null)
        {
            var cmd = Assert(tok, condition, description, tok, kv);
            return cmd;
        }

        Bpl.PredicateCmd Assert(IToken tok, Bpl.Expr condition, PODesc.ProofObligationDescription description, IToken refinesToken, Bpl.QKeyValue kv = null)
        {
            Contract.Requires(tok != null);
            Contract.Requires(condition != null);
            Contract.Ensures(Contract.Result<Bpl.PredicateCmd>() != null);

            Bpl.PredicateCmd cmd;
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_17(1202L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_17(1183L, () => assertAsAssume
      , () => (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1177L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_56(1176L, assertionOnlyFilter, null), () => !assertionOnlyFilter(tok)))
      ), () => (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1196L, () => RefinementToken.IsInherited(refinesToken, currentModule), () => (MutateCSharp.Schemata487.ReplaceBinExprOp_17(1190L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_57(1189L, codeContext, null), () => !codeContext.MustReverify))))))
            {
                // produce an assume instead
                cmd = TrAssumeCmd(tok, condition, kv);
                proofDependencies?.AddProofDependencyId(cmd, tok, new AssumedProofObligationDependency(tok, description));
            }
            else
            {
                cmd = TrAssertCmdDesc(ForceCheckToken.Unwrap(tok), condition, description, kv);
                proofDependencies?.AddProofDependencyId(cmd, tok, new ProofObligationDependency(tok, description));
            }
            return cmd;
        }

        Bpl.PredicateCmd AssertNS(IToken tok, Bpl.Expr condition, PODesc.ProofObligationDescription desc)
        {
            return AssertNS(tok, condition, desc, tok, null);
        }

        Bpl.PredicateCmd AssertNS(IToken tok, Bpl.Expr condition, PODesc.ProofObligationDescription desc, IToken refinesTok, Bpl.QKeyValue kv)
        {
            Contract.Requires(tok != null);
            Contract.Requires(desc != null);
            Contract.Requires(condition != null);
            Contract.Ensures(Contract.Result<Bpl.PredicateCmd>() != null);

            Bpl.PredicateCmd cmd;
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_17(1228L, () => (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1209L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_56(1208L, assertionOnlyFilter, null), () => !assertionOnlyFilter(tok))), () => (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1222L, () => RefinementToken.IsInherited(refinesTok, currentModule), () => (MutateCSharp.Schemata487.ReplaceBinExprOp_17(1216L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_57(1215L, codeContext, null), () => !codeContext.MustReverify))))))
            {
                // produce a "skip" instead
                cmd = TrAssumeCmd(tok, Bpl.Expr.True, kv);
            }
            else
            {
                tok = ForceCheckToken.Unwrap(tok);
                var args = new List<object>();
                args.Add(Bpl.Expr.Literal(MutateCSharp.Schemata487.ReplaceNumericConstant_0(1234L, 0)));
                cmd = TrAssertCmdDesc(tok, condition, desc, new Bpl.QKeyValue(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(1238L, "subsumption"), args, kv));
                proofDependencies?.AddProofDependencyId(cmd, tok, new ProofObligationDependency(tok, desc));
            }

            return cmd;
        }

        Bpl.Ensures EnsuresWithDependencies(IToken tok, bool free, Expression dafnyCondition, Bpl.Expr condition, string errorMessage, string successMessage, string comment)
        {
            Contract.Requires(tok != null);
            Contract.Requires(dafnyCondition != null);
            Contract.Ensures(Contract.Result<Bpl.Ensures>() != null);

            var ens = Ensures(tok, free, condition, errorMessage, successMessage, comment);
            proofDependencies?.AddProofDependencyId(ens, tok, new EnsuresDependency(tok, dafnyCondition));
            return ens;
        }

        Bpl.Ensures Ensures(IToken tok, bool free, Bpl.Expr condition, string errorMessage, string successMessage, string comment)
        {
            Contract.Requires(tok != null);
            Contract.Requires(condition != null);
            Contract.Ensures(Contract.Result<Bpl.Ensures>() != null);

            var unwrappedToken = ForceCheckToken.Unwrap(tok);
            Bpl.Ensures ens = new Bpl.Ensures(unwrappedToken, free, condition, comment);
            var description = new PODesc.EnsuresDescription(errorMessage, successMessage);
            ens.Description = description;
            if (!free)
            {
                ReportAssertion(unwrappedToken, description);
            }
            return ens;
        }

        Bpl.Requires RequiresWithDependencies(IToken tok, bool free, Expression dafnyCondition, Bpl.Expr condition, string errorMessage, string successMessage, string comment)
        {
            Contract.Requires(tok != null);
            Contract.Requires(dafnyCondition != null);
            Contract.Ensures(Contract.Result<Bpl.Ensures>() != null);

            var req = Requires(tok, free, condition, errorMessage, successMessage, comment);
            proofDependencies?.AddProofDependencyId(req, tok, new RequiresDependency(tok, dafnyCondition));
            return req;
        }

        Bpl.Requires Requires(IToken tok, bool free, Bpl.Expr condition, string errorMessage, string successMessage, string comment)
        {
            Contract.Requires(tok != null);
            Contract.Requires(condition != null);
            Contract.Ensures(Contract.Result<Bpl.Requires>() != null);
            Bpl.Requires req = new Bpl.Requires(ForceCheckToken.Unwrap(tok), free, condition, comment);
            req.Description = new PODesc.RequiresDescription(errorMessage, successMessage);
            return req;
        }

        Bpl.StmtList TrStmt2StmtList(BoogieStmtListBuilder builder, Statement block, List<Variable> locals, ExpressionTranslator etran)
        {
            Contract.Requires(builder != null);
            Contract.Requires(block != null);
            Contract.Requires(locals != null);
            Contract.Requires(etran != null);
            Contract.Requires(codeContext != null && predef != null);
            Contract.Ensures(Contract.Result<Bpl.StmtList>() != null);

            TrStmt(block, builder, locals, etran);
            return builder.Collect(block.Tok);  // TODO: would be nice to have an end-curly location for "block"
        }

        /// <summary>
        /// Add to "builder" the following:
        ///     if (*) { S ; assume false; }
        /// where "S" is the given "builderToCollect".  This method consumes what has been built up in "builderToCollect".
        /// </summary>
        void PathAsideBlock(IToken tok, BoogieStmtListBuilder builderToCollect, BoogieStmtListBuilder builder)
        {
            Contract.Requires(tok != null);
            Contract.Requires(builderToCollect != null);
            Contract.Requires(builderToCollect != null);

            builderToCollect.Add(new Bpl.AssumeCmd(tok, Bpl.Expr.False));
            var ifCmd = new Bpl.IfCmd(tok, null, builderToCollect.Collect(tok), null, null);
            builder.Add(ifCmd);
        }

        (string, string) CustomErrorMessage(Attributes attrs)
        {
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_58(1239L, attrs, null)) { return (null, null); }
            List<Expression> args = Attributes.FindExpressions(attrs, MutateCSharp.Schemata487.ReplaceStringConstant_6(1240L, "error"));
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_59(1241L, args, null)) { return (null, null); }
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_16(1246L, args.Count, MutateCSharp.Schemata487.ReplaceNumericConstant_0(1242L, 0)))
            {
                var lErr = (string)(args[MutateCSharp.Schemata487.ReplaceNumericConstant_0(1251L, 0)] as StringLiteralExpr)?.Value;
                var lSucc = MutateCSharp.Schemata487.ReplaceBinExprOp_16(1259L, args.Count, MutateCSharp.Schemata487.ReplaceNumericConstant_0(1255L, 1)) ? (string)(args[MutateCSharp.Schemata487.ReplaceNumericConstant_0(1264L, 1)] as StringLiteralExpr).Value : null;
                return (lErr, lSucc);
            }
            else
            {
                return (null, null);
            }

            return default;
        }

        /// <summary>
        /// Generates a Boogie expression "lo <= x <= hi", but leaving the lo/hi bound if null.
        /// </summary>
        private static Bpl.Expr ForLoopBounds(Bpl.Expr x, Bpl.Expr/*?*/ lo, Bpl.Expr/*?*/ hi)
        {
            Bpl.Expr r = Bpl.Expr.True;
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_31(1268L, lo, null))
            {
                r = BplAnd(r, Bpl.Expr.Le(lo, x));
            }
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_31(1269L, hi, null))
            {
                r = BplAnd(r, Bpl.Expr.Le(x, hi));
            }
            return r;
        }

        delegate Bpl.Expr ExpressionConverter(Dictionary<IVariable, Expression> substMap, ExpressionTranslator etran);

        // Note: not trying to reduce duplication between this and TrAssertCmdDesc because this one should ultimately be removed.
        Bpl.AssertCmd TrAssertCmd(IToken tok, Bpl.Expr expr, Bpl.QKeyValue attributes = null)
        {
            // TODO: move the following comment once this method disappears

            // It may be that "expr" is a Lit expression. It might seem we don't need a Lit expression
            // around the boolean expression that is being asserted. However, we keep it. For one,
            // it doesn't change the semantics of the assert command. More importantly, leaving
            // a Lit around the expression is useful to avoid sending an "assert false;" to Boogie--since
            // Boogie looks especially for "assert false;" commands and processes them in such a way
            // that loops no longer are loops (which is confusing for Dafny users).
            return MutateCSharp.Schemata487.ReplaceBinExprOp_19(1270L, attributes, null) ? new Bpl.AssertCmd(tok, expr) : new Bpl.AssertCmd(tok, expr, attributes);
        }

        Bpl.AssertCmd TrAssertCmdDesc(IToken tok, Bpl.Expr expr, PODesc.ProofObligationDescription description, Bpl.QKeyValue attributes = null)
        {
            ReportAssertion(tok, description);
            return new Bpl.AssertCmd(tok, expr, description, attributes);
        }

        private ISet<(Uri, int)> reportedAssertions = new HashSet<(Uri, int)>();
        private void ReportAssertion(IToken tok, PODesc.ProofObligationDescription description)
        {
            if (!reportedAssertions.Add((tok.Uri, tok.pos)))
            {
                return;
            }

            if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1273L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_60(1271L, options.Get(CommonOptionBag.ShowAssertions), CommonOptionBag.AssertionShowMode.None), () => description.IsImplicit))
            {
                reporter.Info(MessageSource.Translator, ToDafnyToken(MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1279L, false), tok), MutateCSharp.Schemata487.ReplaceStringConstant_6(1280L, "Implicit assertion: ") + description.ShortDescription, MutateCSharp.Schemata487.ReplaceStringConstant_6(1281L, "isAssertion"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_61(1282L, options.Get(CommonOptionBag.ShowAssertions), CommonOptionBag.AssertionShowMode.All))
            {
                reporter.Info(MessageSource.Translator, ToDafnyToken(MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1283L, false), tok), MutateCSharp.Schemata487.ReplaceStringConstant_6(1284L, "Explicit assertion: ") + description.ShortDescription, MutateCSharp.Schemata487.ReplaceStringConstant_6(1285L, "isAssertion"));
            }
        }

        delegate void BodyTranslator(BoogieStmtListBuilder builder, ExpressionTranslator etr);

        List<Bpl.Expr> trTypeArgs(Dictionary<TypeParameter, Type> tySubst, List<TypeParameter> tyArgs)
        {
            var res = new List<Bpl.Expr>();
            foreach (var p in tyArgs)
            {
                res.Add(TypeToTy(tySubst[p]));
            }
            return res;
        }

        Dictionary<IVariable, Expression> SetupBoundVarsAsLocals(List<BoundVar> boundVars, out Bpl.Expr typeAntecedent,
          BoogieStmtListBuilder builder, List<Variable> locals, ExpressionTranslator etran,
          string nameSuffix = null)
        {
            Contract.Requires(boundVars != null);
            Contract.Requires(builder != null);
            Contract.Requires(locals != null);
            Contract.Requires(etran != null);
            Contract.Ensures(Contract.ValueAtReturn(out typeAntecedent) != null);

            typeAntecedent = Bpl.Expr.True;
            var substMap = new Dictionary<IVariable, Expression>();
            foreach (BoundVar bv in boundVars)
            {
                LocalVariable local = new LocalVariable(bv.RangeToken, nameSuffix == null ? bv.Name : bv.Name + nameSuffix, bv.Type, bv.IsGhost);
                local.type = local.OptionalType;  // resolve local here
                IdentifierExpr ie = new IdentifierExpr(local.Tok, local.AssignUniqueName(currentDeclaration.IdGenerator));
                ie.Var = local; ie.Type = ie.Var.Type;  // resolve ie here
                substMap.Add(bv, ie);
                Bpl.LocalVariable bvar = new Bpl.LocalVariable(local.Tok, new Bpl.TypedIdent(local.Tok, local.AssignUniqueName(currentDeclaration.IdGenerator), TrType(local.Type)));
                locals.Add(bvar);
                var bIe = new Bpl.IdentifierExpr(bvar.tok, bvar);
                builder.Add(new Bpl.HavocCmd(bv.tok, new List<Bpl.IdentifierExpr> { bIe }));
                Bpl.Expr wh = GetWhereClause(bv.tok, bIe, local.Type, etran, IsAllocType.ISALLOC);
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_31(1286L, wh, null))
                {
                    typeAntecedent = BplAnd(typeAntecedent, wh);
                }
            }
            return substMap;
        }

        Dictionary<IVariable, Expression> SetupBoundVarsAsLocals(List<BoundVar> boundVars, BoogieStmtListBuilder builder,
          List<Variable> locals, ExpressionTranslator etran,
          string nameSuffix = null)
        {
            Contract.Requires(boundVars != null);
            Contract.Requires(builder != null);
            Contract.Requires(locals != null);
            Contract.Requires(etran != null);

            var substMap = SetupBoundVarsAsLocals(boundVars, out var typeAntecedent, builder, locals, etran, nameSuffix);
            builder.Add(TrAssumeCmd(typeAntecedent.tok, typeAntecedent));
            return substMap;
        }

        /// <summary>
        /// Clone Dafny variable "v" into a new Dafny local variable "l".
        /// Add to "substMap" the substitution from "v" to an IdentifierExpr for "l".
        /// Also, generate a Boogie variable "bvar" for "l", add "bvar" to "locals", and
        /// emit to "builder" a havoc statement for "bvar". The type antecedent for "bvar"
        /// is NOT emitted; rather, it is returned by this method.
        /// </summary>
        Bpl.Expr SetupVariableAsLocal(IVariable v, Dictionary<IVariable, Expression> substMap,
          BoogieStmtListBuilder builder, List<Bpl.Variable> locals, ExpressionTranslator etran)
        {
            Contract.Requires(v != null);
            Contract.Requires(substMap != null);
            Contract.Requires(builder != null);
            Contract.Requires(locals != null);
            Contract.Requires(etran != null);

            var local = new LocalVariable(v.RangeToken, v.Name, v.Type, v.IsGhost);
            local.type = local.OptionalType;  // resolve local here
            var ie = new IdentifierExpr(local.Tok, local.AssignUniqueName(currentDeclaration.IdGenerator));
            ie.Var = local; ie.Type = ie.Var.Type;  // resolve ie here
            substMap.Add(v, ie);

            var bvar = new Bpl.LocalVariable(local.Tok, new Bpl.TypedIdent(local.Tok, local.AssignUniqueName(currentDeclaration.IdGenerator), TrType(local.Type)));
            locals.Add(bvar);
            var bIe = new Bpl.IdentifierExpr(bvar.tok, bvar);
            builder.Add(new Bpl.HavocCmd(v.Tok, new List<Bpl.IdentifierExpr> { bIe }));
            var wh = GetWhereClause(v.Tok, bIe, local.Type, etran, ISALLOC);
            return wh ?? Bpl.Expr.True;
        }

        List<Bpl.Expr> RecordDecreasesValue(List<Expression> decreases, BoogieStmtListBuilder builder, List<Variable> locals, ExpressionTranslator etran, string varPrefix)
        {
            Contract.Requires(locals != null);
            Contract.Requires(etran != null);
            Contract.Requires(varPrefix != null);
            Contract.Requires(builder != null);
            Contract.Requires(decreases != null);
            List<Bpl.Expr> oldBfs = new List<Bpl.Expr>();
            var idGen = new FreshIdGenerator();
            foreach (Expression e in decreases)
            {
                Contract.Assert(e != null);
                Bpl.LocalVariable bfVar = new Bpl.LocalVariable(e.tok, new Bpl.TypedIdent(e.tok, idGen.FreshId(varPrefix), TrType(cce.NonNull(e.Type))));
                locals.Add(bfVar);
                Bpl.IdentifierExpr bf = new Bpl.IdentifierExpr(e.tok, bfVar);
                oldBfs.Add(bf);
                // record value of each decreases expression at beginning of the loop iteration
                Bpl.Cmd cmd = Bpl.Cmd.SimpleAssign(e.tok, bf, etran.TrExpr(e));
                builder.Add(cmd);
            }
            return oldBfs;
        }


        void AddComment(BoogieStmtListBuilder builder, Statement stmt, string comment)
        {
            Contract.Requires(builder != null);
            Contract.Requires(stmt != null);
            Contract.Requires(comment != null);
            builder.Add(new Bpl.CommentCmd(string.Format(MutateCSharp.Schemata487.ReplaceStringConstant_6(1287L, "----- {0} ----- {1}({2},{3})"), comment, stmt.Tok.Filepath, stmt.Tok.line, stmt.Tok.col)));
        }

        /// <summary>
        /// Therefore, these properties are applied to method in-parameters.
        /// For now, this only allows you to case split on incoming data type values.
        /// This used to add IsGood[Multi]Set_Extendend, but that is always
        /// added for sets & multisets now in the prelude.
        /// </summary>
        Bpl.Expr GetExtendedWhereClause(IToken tok, Bpl.Expr x, Type type, ExpressionTranslator etran, IsAllocType alloc)
        {
            Contract.Requires(tok != null);
            Contract.Requires(x != null);
            Contract.Requires(type != null);
            Contract.Requires(etran != null);
            Contract.Requires(predef != null);
            var r = GetWhereClause(tok, x, type, etran, alloc);
            type = type.NormalizeExpand();
            if (type.IsDatatype)
            {
                UserDefinedType udt = (UserDefinedType)type;
                var oneOfTheCases = FunctionCall(tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(1288L, "$IsA#") + udt.ResolvedClass.FullSanitizedName, Bpl.Type.Bool, x);
                return BplAnd(r, oneOfTheCases);
            }
            else
            {
                return r;
            }

            return default;
        }

        /// <summary>
        /// Translates an AST Type to a Boogie expression of type Ty.
        /// </summary>
        Bpl.Expr TypeToTy(Type type)
        {
            Contract.Requires(type != null);
            Contract.Ensures(Contract.Result<Bpl.Expr>() != null);

            type = type.NormalizeExpandKeepConstraints();

            if (type.IsTypeParameter)
            {
                var udt = (UserDefinedType)type;
                return TrTypeParameter((TypeParameter)udt.ResolvedClass);
            }
            else if (type.IsAbstractType)
            {
                var udt = (UserDefinedType)type;
                return TrAbstractType((AbstractTypeDecl)udt.ResolvedClass, udt.TypeArgs);
            }
            else if (type is UserDefinedType)
            {
                // Classes, (co-)datatypes, newtypes, subset types, ...
                var args = type.TypeArgs.ConvertAll(TypeToTy);
                return ClassTyCon(((UserDefinedType)type), args);
            }
            else if (type is SetType)
            {
                bool finite = ((SetType)type).Finite;
                return FunctionCall(Token.NoToken, finite ? MutateCSharp.Schemata487.ReplaceStringConstant_6(1289L, "TSet") : MutateCSharp.Schemata487.ReplaceStringConstant_6(1290L, "TISet"), predef.Ty, TypeToTy(((CollectionType)type).Arg));
            }
            else if (type is MultiSetType)
            {
                return FunctionCall(Token.NoToken, MutateCSharp.Schemata487.ReplaceStringConstant_6(1291L, "TMultiSet"), predef.Ty, TypeToTy(((CollectionType)type).Arg));
            }
            else if (type is SeqType)
            {
                return FunctionCall(Token.NoToken, MutateCSharp.Schemata487.ReplaceStringConstant_6(1292L, "TSeq"), predef.Ty, TypeToTy(((CollectionType)type).Arg));
            }
            else if (type is MapType)
            {
                bool finite = ((MapType)type).Finite;
                return FunctionCall(Token.NoToken, finite ? MutateCSharp.Schemata487.ReplaceStringConstant_6(1293L, "TMap") : MutateCSharp.Schemata487.ReplaceStringConstant_6(1294L, "TIMap"), predef.Ty,
                  TypeToTy(((MapType)type).Domain),
                  TypeToTy(((MapType)type).Range));
            }
            else if (type is BoolType)
            {
                return new Bpl.IdentifierExpr(Token.NoToken, MutateCSharp.Schemata487.ReplaceStringConstant_6(1295L, "TBool"), predef.Ty);
            }
            else if (type is CharType)
            {
                return new Bpl.IdentifierExpr(Token.NoToken, MutateCSharp.Schemata487.ReplaceStringConstant_6(1296L, "TChar"), predef.Ty);
            }
            else if (type is RealType)
            {
                return new Bpl.IdentifierExpr(Token.NoToken, MutateCSharp.Schemata487.ReplaceStringConstant_6(1297L, "TReal"), predef.Ty);
            }
            else if (type is BitvectorType)
            {
                var t = (BitvectorType)type;
                return FunctionCall(Token.NoToken, MutateCSharp.Schemata487.ReplaceStringConstant_6(1298L, "TBitvector"), predef.Ty, Bpl.Expr.Literal(t.Width));
            }
            else if (type is IntType)
            {
                return new Bpl.IdentifierExpr(Token.NoToken, MutateCSharp.Schemata487.ReplaceStringConstant_6(1299L, "TInt"), predef.Ty);
            }
            else if (type is BigOrdinalType)
            {
                return new Bpl.IdentifierExpr(Token.NoToken, MutateCSharp.Schemata487.ReplaceStringConstant_6(1300L, "TORDINAL"), predef.Ty);
            }
            else if (type is ParamTypeProxy)
            {
                return TrTypeParameter(((ParamTypeProxy)type).orig);
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected type
            }

            return default;
        }

        static string NameTypeParam(TypeParameter tp)
        {
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_62(1301L, tp.Parent, null))
            {
                return tp.Parent.FullName + MutateCSharp.Schemata487.ReplaceStringConstant_6(1302L, "$") + tp.Name;
            }
            else
            {
                // This happens for builtins, like arrays, that don't have a parent
                return MutateCSharp.Schemata487.ReplaceStringConstant_6(1303L, "#$") + tp.Name;
            }

            return default;
        }

        Bpl.Expr TrTypeParameter(TypeParameter tp)
        {
            var nm = NameTypeParam(tp);
            // return an identifier denoting a constant
            return new Bpl.IdentifierExpr(tp.tok, nm, predef.Ty);
        }

        Bpl.Expr TrAbstractType(AbstractTypeDecl abstractType, List<Type> tyArguments)
        {
            Contract.Requires(tyArguments != null);

            var fn = GetOrCreateTypeConstructor(abstractType);
            var args = tyArguments.ConvertAll(TypeToTy);
            return FunctionCall(abstractType.tok, fn.Name, predef.Ty, args);
        }

        public List<TypeParameter> GetTypeParams(IMethodCodeContext cc)
        {
            if (cc is Method)
            {
                Method m = (Method)cc;
                return Concat(GetTypeParams(m.EnclosingClass), m.TypeArgs);
            }
            else if (cc is IteratorDecl)
            {
                return cc.TypeArgs; // This one cannot be enclosed in a class
            }
            else
            {
                Contract.Assert(false);
                return null;
            }

            return default;
        }

        static public List<TypeParameter> GetTypeParams(TopLevelDecl d)
        {
            Contract.Requires(d is ClassLikeDecl || d is DatatypeDecl || d is NewtypeDecl || d is ValuetypeDecl);
            return d.TypeArgs;
        }

        static List<TypeParameter> GetTypeParams(Function f)
        {
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_63(1304L, f.EnclosingClass, null))
            {
                return f.TypeArgs;
            }
            else
            {
                return Concat(GetTypeParams(f.EnclosingClass), f.TypeArgs);
            }

            return default;
        }

        /// <summary>
        /// Return $IsBox(x, t).
        /// </summary>
        Bpl.Expr MkIsBox(Bpl.Expr x, Type t)
        {
            return MkIs(x, TypeToTy(t), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1305L, true));
        }

        // Boxes, if necessary
        Bpl.Expr MkIs(Bpl.Expr x, Type t)
        {
            return MkIs(x, TypeToTy(t), ModeledAsBoxType(t));
        }

        Bpl.Expr MkIs(Bpl.Expr x, Bpl.Expr t, bool box = false)
        {
            if (box)
            {
                return FunctionCall(x.tok, BuiltinFunction.IsBox, null, x, t);
            }
            else
            {
                return FunctionCall(x.tok, BuiltinFunction.Is, null, x, t);
            }

            return default;
        }

        // Boxes, if necessary
        Bpl.Expr MkIsAlloc(Bpl.Expr x, Type t, Bpl.Expr h)
        {
            return MkIsAlloc(x, TypeToTy(t), h, ModeledAsBoxType(t));
        }

        Bpl.Expr MkIsAllocBox(Bpl.Expr x, Type t, Bpl.Expr h)
        {
            return MkIsAlloc(x, TypeToTy(t), h, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1306L, true));
        }

        Bpl.Expr MkIsAlloc(Bpl.Expr x, Bpl.Expr t, Bpl.Expr h, bool box = false)
        {
            if (box)
            {
                return FunctionCall(x.tok, BuiltinFunction.IsAllocBox, null, x, t, h);
            }
            else
            {
                return FunctionCall(x.tok, BuiltinFunction.IsAlloc, null, x, t, h);
            }

            return default;
        }

        /// <summary>
        /// A "where" clause for a variable in Boogie turns into an assumption anytime that Boogie is tasked
        /// with assigning an arbitrary value to that variable. This happens at the beginning of a procedure
        /// implementation, after a procedure call, or as part of a "havoc" command. Each one of these can
        /// easily be followed by a manual "assume" command. However, the use-case that makes "where" clauses
        /// especially valuable is in loops, because when Boogie cuts the backedge, it inserts "havoc" commands.
        /// To do this in Dafny, Dafny would have to compute loop targets, which is better done in Boogie (which
        /// already has to do it).
        /// </summary>
        Bpl.Expr GetWhereClause(IToken tok, Bpl.Expr x, Type type, ExpressionTranslator etran, IsAllocType alloc,
          bool allocatednessOnly = false, bool alwaysUseSymbolicName = false)
        {
            Contract.Requires(tok != null);
            Contract.Requires(x != null);
            Contract.Requires(type != null);
            Contract.Requires(etran != null);
            Contract.Requires(predef != null);

            if (type.NormalizeExpand() is TypeProxy)
            {
                // Unresolved proxy
                // Omit where clause (in other places, unresolved proxies are treated as a reference type; we could do that here too, but
                // we might as well leave out the where clause altogether).
                return null;
            }

            var normType = type.NormalizeExpandKeepConstraints();
            Bpl.Expr isAlloc;
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_17(1325L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_17(1319L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_17(1313L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_17(1307L, () => type.IsNumericBased(), () => type.IsBitVectorType), () => type.IsBoolType), () => type.IsCharType), () => type.IsBigOrdinalType))
            {
                isAlloc = null;
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1333L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_48(1331L, alloc, ISALLOC), () => MutateCSharp.Schemata487.ReplaceBinExprOp_31(1332L, etran.HeapExpr, null)))
            {
                isAlloc = MkIsAlloc(x, normType, etran.HeapExpr);
            }
            else
            {
                isAlloc = null;
            }
            if (allocatednessOnly)
            {
                return isAlloc;
            }

            Bpl.Expr isPred = null;
            if (alwaysUseSymbolicName)
            {
                // go for the symbolic name
                isPred = MkIs(x, normType);
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_17(1351L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_17(1345L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_17(1339L, () => normType is BoolType, () => normType is IntType), () => normType is RealType), () => normType is BigOrdinalType))
            {
                // nothing to do
            }
            else if (normType is BitvectorType)
            {
                var t = (BitvectorType)normType;
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_20(1361L, t.Width, MutateCSharp.Schemata487.ReplaceNumericConstant_0(1357L, 0)))
                {
                    // type bv0 has only one value
                    return Bpl.Expr.Eq(BplBvLiteralExpr(tok, BaseTypes.BigNum.ZERO, t), x);
                }
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1386L, () => (MutateCSharp.Schemata487.ReplaceBinExprOp_17(1368L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_64(1366L, normType.AsTypeSynonym, null), () => MutateCSharp.Schemata487.ReplaceBinExprOp_65(1367L, normType.AsNewtype, null))), () => (MutateCSharp.Schemata487.ReplaceBinExprOp_17(1380L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_17(1374L, () => normType.IsNumericBased(), () => normType.IsBitVectorType), () => normType.IsBoolType))))
            {
                var constraint = ModuleResolver.GetImpliedTypeConstraint(new BoogieWrapper(x, normType), normType);
                isPred = etran.TrExpr(constraint);
            }
            else
            {
                // go for the symbolic name
                isPred = MkIs(x, normType);
            }
            return MutateCSharp.Schemata487.ReplaceBinExprOp_32(1392L, isAlloc, null) ? isPred : MutateCSharp.Schemata487.ReplaceBinExprOp_32(1393L, isPred, null) ? isAlloc : BplAnd(isPred, isAlloc);
        }

        // Returns an expression, which, if false, means that the two LHS expressions are
        // not distinct; if null then the LHSs are trivially distinct
        Bpl.Expr CheckDistinctness(Expression lhsa, Expression lhsb, ExpressionTranslator etran)
        {
            {
                if (lhsa is IdentifierExpr iea && lhsb is IdentifierExpr ieb)
                {
                    if (MutateCSharp.Schemata487.ReplaceBinExprOp_66(1394L, iea.Name, ieb.Name))
                    {
                        return null;
                    }

                    return Bpl.Expr.False;
                }
            }
            {
                if (lhsa is MemberSelectExpr iea && lhsb is MemberSelectExpr ieb)
                {
                    if (iea.Member is Field fa && ieb.Member is Field fb)
                    {
                        if (MutateCSharp.Schemata487.ReplaceBinExprOp_67(1395L, fa, fb))
                        {
                            return null;
                        }

                        return Bpl.Expr.Neq(etran.TrExpr(iea.Obj), etran.TrExpr(ieb.Obj));
                    }
                }
            }
            {
                if (lhsa is SeqSelectExpr iea && lhsb is SeqSelectExpr ieb)
                {
                    Bpl.Expr ex = Bpl.Expr.Neq(etran.TrExpr(iea.Seq), etran.TrExpr(ieb.Seq));
                    if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1398L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_46(1396L, iea.E1, null), () => MutateCSharp.Schemata487.ReplaceBinExprOp_46(1397L, ieb.E1, null)))
                    {
                        ex = BplOr(ex, Bpl.Expr.Neq(etran.TrExpr(iea.E0), etran.TrExpr(ieb.E0)));
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1406L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_46(1404L, iea.E1, null), () => MutateCSharp.Schemata487.ReplaceBinExprOp_33(1405L, ieb.E1, null)))
                    {
                        ex = BplOr(ex, Bpl.Expr.Le(etran.TrExpr(ieb.E1), etran.TrExpr(iea.E0)));
                        ex = BplOr(ex, Bpl.Expr.Lt(etran.TrExpr(iea.E0), etran.TrExpr(ieb.E0)));
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1414L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_33(1412L, iea.E1, null), () => MutateCSharp.Schemata487.ReplaceBinExprOp_46(1413L, ieb.E1, null)))
                    {
                        ex = BplOr(ex, Bpl.Expr.Le(etran.TrExpr(iea.E1), etran.TrExpr(ieb.E0)));
                        ex = BplOr(ex, Bpl.Expr.Lt(etran.TrExpr(ieb.E0), etran.TrExpr(iea.E0)));
                    }
                    else
                    {
                        ex = BplOr(ex, Bpl.Expr.Le(etran.TrExpr(iea.E1), etran.TrExpr(ieb.E0)));
                        ex = BplOr(ex, Bpl.Expr.Le(etran.TrExpr(ieb.E1), etran.TrExpr(iea.E0)));
                    }
                    return ex;
                }
            }
            {
                if (lhsa is MultiSelectExpr iea && lhsb is MultiSelectExpr ieb && MutateCSharp.Schemata487.ReplaceBinExprOp_20(1420L, iea.Indices.Count, ieb.Indices.Count))
                {
                    Bpl.Expr ex = Bpl.Expr.Neq(etran.TrExpr(iea.Array), etran.TrExpr(ieb.Array));
                    for (int i = MutateCSharp.Schemata487.ReplaceNumericConstant_0(1425L, 0); MutateCSharp.Schemata487.ReplaceBinExprOp_1(1429L, i, iea.Indices.Count); MutateCSharp.Schemata487.ReplacePostfixUnaryExprOp_34(1434L, ref i))
                    {
                        ex = BplOr(ex, Bpl.Expr.Neq(etran.TrExpr(iea.Indices[i]), etran.TrExpr(ieb.Indices[i])));
                    }
                    return ex;
                }
            }

            return null;
        }

        /// <summary>
        /// Returns the name of the local variable used as a stand-in for a field in the BodyInit part of a divided
        /// constructor body.
        /// </summary>
        string SurrogateName(Field field)
        {
            Contract.Requires(field != null);
            return MutateCSharp.Schemata487.ReplaceStringConstant_6(1435L, "this.") + field.Name;
        }

        Bpl.Expr GetSubrangeCheck(Bpl.Expr bSource, Type sourceType, Type targetType, out PODesc.ProofObligationDescription desc, string errorMessagePrefix = "")
        {
            Contract.Requires(bSource != null);
            Contract.Requires(sourceType != null);
            Contract.Requires(targetType != null);

            if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1448L, () => Type.IsSupertype(targetType, sourceType), () => !(MutateCSharp.Schemata487.ReplaceBinExprOp_5(1442L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_5(1436L, () => sourceType.IsRefType, () => !sourceType.IsNonNullRefType), () => !targetType.IsRefType))))
            {
                // We should always be able to use Is, but this is an optimisation.
                desc = null;
                return null;
            }
            targetType = targetType.NormalizeExpandKeepConstraints();
            var udt = targetType as UserDefinedType;
            Bpl.Expr cre;
            if (udt?.ResolvedClass is RedirectingTypeDecl redirectingTypeDecl &&
                ModeledAsBoxType((redirectingTypeDecl as NewtypeDecl)?.BaseType ?? redirectingTypeDecl.Var.Type))
            {
                cre = MkIs(BoxIfNecessary(bSource.tok, bSource, sourceType), TypeToTy(targetType), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1454L, true));
            }
            else if (ModeledAsBoxType(sourceType))
            {
                cre = MkIs(bSource, TypeToTy(targetType), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1455L, true));
            }
            else if (targetType is UserDefinedType targetUdt)
            {
                cre = MkIs(BoxifyForTraitParent(bSource.tok, bSource, udt.ResolvedClass, sourceType), targetType);
            }
            else
            {
                cre = MkIs(bSource, targetType);
            }
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1457L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_68(1456L, udt, null), () => udt.IsRefType))
            {
                var s = sourceType.NormalizeExpandKeepConstraints();
                var certain = MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1463L, false);
                string cause = null;
                if (s is UserDefinedType sudt && udt.ResolvedClass is NonNullTypeDecl nntd && MutateCSharp.Schemata487.ReplaceBinExprOp_69(1464L, nntd.Class, sudt.ResolvedClass))
                {
                    certain = MutateCSharp.Schemata487.ReplaceBinExprOp_20(1469L, udt.ResolvedClass.TypeArgs.Count, MutateCSharp.Schemata487.ReplaceNumericConstant_0(1465L, 0));
                    cause = MutateCSharp.Schemata487.ReplaceStringConstant_6(1474L, "it may be null");
                }
                desc = new PODesc.SubrangeCheck(errorMessagePrefix, sourceType.ToString(), targetType.ToString(), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1475L, false), certain, cause);
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1477L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_68(1476L, udt, null), () => ArrowType.IsTotalArrowTypeName(udt.Name)))
            {
                desc = new PODesc.SubrangeCheck(errorMessagePrefix, sourceType.ToString(), targetType.ToString(), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1483L, true), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1484L, false),
        MutateCSharp.Schemata487.ReplaceStringConstant_6(1485L, "it may be partial or have read effects"));
            }
            else if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1487L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_68(1486L, udt, null), () => ArrowType.IsPartialArrowTypeName(udt.Name)))
            {
                desc = new PODesc.SubrangeCheck(errorMessagePrefix, sourceType.ToString(), targetType.ToString(), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1493L, true), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1494L, false),
        MutateCSharp.Schemata487.ReplaceStringConstant_6(1495L, "it may have read effects"));
            }
            else
            {
                desc = new PODesc.SubrangeCheck(errorMessagePrefix, sourceType.ToString(), targetType.ToString(),
                  targetType.NormalizeExpandKeepConstraints() is UserDefinedType
                  {
                      ResolvedClass: SubsetTypeDecl or NewtypeDecl { Var: { } }
                  },
        MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1496L, false), null);
            }
            return cre;
        }

        void CheckSubrange(IToken tok, Bpl.Expr bSource, Type sourceType, Type targetType, BoogieStmtListBuilder builder, string errorMsgPrefix = "")
        {
            Contract.Requires(tok != null);
            Contract.Requires(bSource != null);
            Contract.Requires(sourceType != null);
            Contract.Requires(targetType != null);
            Contract.Requires(builder != null);

            var cre = GetSubrangeCheck(bSource, sourceType, targetType, out var desc, errorMsgPrefix);
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_31(1497L, cre, null))
            {
                builder.Add(Assert(tok, cre, desc));
            }
        }

        void Check_NewRestrictions(IToken tok, Bpl.Expr obj, Field f, Bpl.Expr rhs, BoogieStmtListBuilder builder, ExpressionTranslator etran)
        {
            Contract.Requires(tok != null);
            Contract.Requires(obj != null);
            Contract.Requires(f != null);
            Contract.Requires(rhs != null);
            Contract.Requires(builder != null);
            Contract.Requires(etran != null);
            var iter = f.EnclosingClass as IteratorDecl;
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1500L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_70(1498L, iter, null), () => MutateCSharp.Schemata487.ReplaceBinExprOp_71(1499L, f, iter.Member_New)))
            {
                // Assignments to an iterator _new field is only allowed to shrink the set, so:
                // assert Set#Subset(rhs, obj._new);
                var fId = new Bpl.IdentifierExpr(tok, GetField(f));
                var subset = FunctionCall(tok, BuiltinFunction.SetSubset, null, rhs,
                  ApplyUnbox(tok, ReadHeap(tok, etran.HeapExpr, obj, fId), predef.SetType));
                builder.Add(Assert(tok, subset, new PODesc.AssignmentShrinks(f.Name)));
            }
        }

        Bpl.AssumeCmd AssumeGoodHeap(IToken tok, ExpressionTranslator etran)
        {
            Contract.Requires(tok != null);
            Contract.Requires(etran != null);
            Contract.Ensures(Contract.Result<AssumeCmd>() != null);

            return TrAssumeCmd(tok, FunctionCall(tok, BuiltinFunction.IsGoodHeap, null, etran.HeapExpr));
        }

        /// <summary>
        /// Idempotently fills in "mc.ProjectionFunctions"
        /// </summary>
        void CreateMapComprehensionProjectionFunctions(MapComprehension mc)
        {
            Contract.Requires(mc != null && mc.TermLeft != null);
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_72(1506L, mc.ProjectionFunctions, null))
            {
                var varNameGen = CurrentIdGenerator.NestedFreshIdGenerator(string.Format(MutateCSharp.Schemata487.ReplaceStringConstant_6(1507L, "map$project${0}#"), projectionFunctionCount));
                MutateCSharp.Schemata487.ReplacePostfixUnaryExprOp_34(1508L, ref projectionFunctionCount);
                mc.ProjectionFunctions = new List<Bpl.Function>();
                foreach (var bv in mc.BoundVars)
                {
                    var arg = BplFormalVar(null, TrType(mc.TermLeft.Type), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1509L, false));
                    var res = BplFormalVar(null, TrType(bv.Type), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1510L, true));
                    var projectFn = new Bpl.Function(mc.tok, varNameGen.FreshId(string.Format(MutateCSharp.Schemata487.ReplaceStringConstant_6(1511L, "#{0}#"), bv.Name)), new List<Variable>() { arg }, res);
                    mc.ProjectionFunctions.Add(projectFn);
                    sink.AddTopLevelDeclaration(projectFn);
                }
            }
        }

        int projectionFunctionCount = MutateCSharp.Schemata487.ReplaceNumericConstant_0(1512L, 0);
        private Declaration currentDeclaration;

        public class BoogieWrapper : Expression
        {
            public readonly Bpl.Expr Expr;

            public BoogieWrapper(Bpl.Expr expr, Type dafnyType)
              : base(ToDafnyToken(MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1516L, false), expr.tok))
            {
                Contract.Requires(expr != null);
                Contract.Requires(dafnyType != null);
                RangeToken = ToDafnyToken(MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1517L, true), expr.tok).ToRange();
                Expr = expr;
                Type = dafnyType;  // resolve immediately
            }
        }

        public class BoogieFunctionCall : Expression
        {
            public readonly string FunctionName;
            public readonly bool UsesHeap;
            public readonly bool UsesOldHeap;
            public readonly List<Label> HeapAtLabels;
            public readonly List<Type> TyArgs; // Note: also has a bunch of type arguments
            public readonly List<Expression> Args;
            public BoogieFunctionCall(IToken tok, string functionName, bool usesHeap, bool usesOldHeap, List<Label> heapAtLabels, List<Expression> args, List<Type> tyArgs)
              : base(tok)
            {
                Contract.Requires(tok != null);
                Contract.Requires(functionName != null);
                Contract.Requires(heapAtLabels != null);
                Contract.Requires(args != null);
                FunctionName = functionName;
                UsesHeap = usesHeap;
                UsesOldHeap = usesOldHeap;
                HeapAtLabels = heapAtLabels;
                Args = args;
                TyArgs = tyArgs;
            }
            public override IEnumerable<Expression> SubExpressions
            {
                get
                {
                    foreach (var v in Args)
                    {
                        yield return v;
                    }

                    yield break;
                }
            }
        }

        public class SubstLetExpr : LetExpr
        {
            public LetExpr orgExpr;
            public Dictionary<IVariable, Expression> substMap;
            public Dictionary<TypeParameter, Type> typeMap;

            public SubstLetExpr(IToken tok, List<CasePattern<BoundVar>> lhss, List<Expression> rhss, Expression body, bool exact,
               LetExpr orgExpr, Dictionary<IVariable, Expression> substMap, Dictionary<TypeParameter, Type> typeMap, List<BoundedPool>/*?*/ constraintBounds)
              : base(tok, lhss, rhss, body, exact)
            {
                this.orgExpr = orgExpr;
                this.substMap = substMap;
                this.typeMap = typeMap;
                this.Constraint_Bounds = constraintBounds;
            }
        }

        public class FuelSettingPair
        {
            public int low;
            public int high;

            public FuelSettingPair(int low = (int)FuelSetting.FuelAmount.LOW, int high = (int)FuelSetting.FuelAmount.HIGH)
            {
                this.low = low;
                this.high = high;
            }
        }

        public class FuelContext : Dictionary<Function, FuelSettingPair> { }

        public class CustomFuelSettings : Dictionary<Function, FuelSetting> { }

        public class FuelConstant
        {
            public Function f;
            public Bpl.Expr baseFuel;
            public Bpl.Expr startFuel;
            public Bpl.Expr startFuelAssert;

            public FuelConstant(Function f, Bpl.Expr baseFuel, Bpl.Expr startFuel, Bpl.Expr startFuelAssert)
            {
                this.f = f;
                this.baseFuel = baseFuel;
                this.startFuel = startFuel;
                this.startFuelAssert = startFuelAssert;
            }

            public Bpl.Expr MoreFuel(Bpl.Program sink, PredefinedDecls predef, FreshIdGenerator idGen)
            {
                string uniqueId = idGen.FreshId(MutateCSharp.Schemata487.ReplaceStringConstant_6(1518L, "MoreFuel_") + f.FullName);
                Bpl.Constant moreFuel = new Bpl.Constant(f.tok, new Bpl.TypedIdent(f.tok, uniqueId, predef.LayerType), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1519L, false));
                sink.AddTopLevelDeclaration(moreFuel);
                Bpl.Expr moreFuel_expr = new Bpl.IdentifierExpr(f.tok, moreFuel);
                return moreFuel_expr;
            }
        }

        public class FuelSetting
        {

            public enum FuelAmount { NONE, LOW, HIGH };
            public static AsyncLocal<Stack<FuelContext>> SavedContexts = new();

            public static FuelSettingPair FuelAttrib(Function f, out bool found)
            {
                Contract.Requires(f != null);
                Contract.Ensures(Contract.Result<FuelSettingPair>() != null);
                FuelSettingPair setting = new FuelSettingPair();
                found = MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1520L, false);

                if (MutateCSharp.Schemata487.ReplaceBinExprOp_73(1521L, f.Attributes, null))
                {
                    List<Expression> args = Attributes.FindExpressions(f.Attributes, MutateCSharp.Schemata487.ReplaceStringConstant_6(1522L, "fuel"));
                    if (MutateCSharp.Schemata487.ReplaceBinExprOp_74(1523L, args, null))
                    {
                        found = MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1524L, true);
                        if (MutateCSharp.Schemata487.ReplaceBinExprOp_75(1529L, args.Count, MutateCSharp.Schemata487.ReplaceNumericConstant_0(1525L, 2)))
                        {
                            LiteralExpr literalLow = args[MutateCSharp.Schemata487.ReplaceNumericConstant_0(1534L, 0)] as LiteralExpr;
                            LiteralExpr literalHigh = args[MutateCSharp.Schemata487.ReplaceNumericConstant_0(1538L, 1)] as LiteralExpr;

                            if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1556L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_5(1550L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_5(1543L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_76(1542L, literalLow, null), () => literalLow.Value is BigInteger), () => MutateCSharp.Schemata487.ReplaceBinExprOp_76(1549L, literalHigh, null)), () => literalHigh.Value is BigInteger))
                            {
                                setting.low = (int)((BigInteger)literalLow.Value);
                                setting.high = (int)((BigInteger)literalHigh.Value);
                            }
                        }
                        else if (MutateCSharp.Schemata487.ReplaceBinExprOp_75(1566L, args.Count, MutateCSharp.Schemata487.ReplaceNumericConstant_0(1562L, 1)))
                        {
                            LiteralExpr literal = args[MutateCSharp.Schemata487.ReplaceNumericConstant_0(1571L, 0)] as LiteralExpr;
                            if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1576L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_76(1575L, literal, null), () => literal.Value is BigInteger))
                            {
                                setting.low = (int)((BigInteger)literal.Value);
                                setting.high = MutateCSharp.Schemata487.ReplaceBinExprOp_77(1586L, setting.low, MutateCSharp.Schemata487.ReplaceNumericConstant_0(1582L, 1));
                            }
                        }
                    }
                }

                return setting;
            }

            public int amount;        // Amount of fuel above that represented by start
            private Bpl.Expr start;   // Starting fuel argument (null indicates LZ)
            private BoogieGenerator boogieGenerator;
            private CustomFuelSettings customFuelSettings;

            public FuelSetting(BoogieGenerator boogieGenerator, int amount, Bpl.Expr start = null, CustomFuelSettings customFuelSettings = null)
            {
                this.boogieGenerator = boogieGenerator;
                this.amount = amount;
                this.start = start;
                this.customFuelSettings = customFuelSettings;
            }

            public FuelSetting Offset(int offset)
            {
                return new FuelSetting(boogieGenerator, MutateCSharp.Schemata487.ReplaceBinExprOp_77(1595L, this.amount, offset), start);
            }

            public FuelSetting Decrease(int offset)
            {
                Contract.Ensures(this.amount - offset >= 0);
                return new FuelSetting(boogieGenerator, MutateCSharp.Schemata487.ReplaceBinExprOp_29(1604L, this.amount, offset), start);
            }

            public FuelSetting WithLayer(Bpl.Expr layer)
            {
                return new FuelSetting(boogieGenerator, amount, layer);
            }

            public FuelSetting WithContext(CustomFuelSettings settings)
            {
                return new FuelSetting(boogieGenerator, amount, start, settings);
            }

            public Bpl.Expr LayerZero()
            {
                Contract.Ensures(Contract.Result<Bpl.Expr>() != null);
                return new Bpl.IdentifierExpr(Token.NoToken, MutateCSharp.Schemata487.ReplaceStringConstant_6(1613L, "$LZ"), boogieGenerator.predef.LayerType);
            }

            public Bpl.Expr LayerN(int n)
            {
                Contract.Requires(0 <= n);
                Contract.Ensures(Contract.Result<Bpl.Expr>() != null);
                return boogieGenerator.LayerSucc(LayerZero(), n);
            }

            public Bpl.Expr LayerN(int n, Bpl.Expr baseLayer)
            {
                Contract.Requires(0 <= n);
                Contract.Ensures(Contract.Result<Bpl.Expr>() != null);
                return boogieGenerator.LayerSucc(baseLayer, n);
            }

            private Bpl.Expr ToExpr(int amount)
            {
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_32(1614L, start, null))
                {
                    return LayerN(amount);
                }
                else
                {
                    return boogieGenerator.LayerSucc(start, amount);
                }

                return default;
            }

            public Bpl.Expr ToExpr()
            {
                return this.ToExpr(this.amount);
            }

            /// <summary>
            /// Get the fuel value for this function, given the ambient environment (represented by the fuel setting)
            /// the function itself, and the function call's context (if any)
            /// </summary>
            public Bpl.Expr GetFunctionFuel(Function f)
            {
                Contract.Requires(f != null);
                Bpl.Expr finalFuel;
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1616L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_78(1615L, customFuelSettings, null), () => customFuelSettings.ContainsKey(f)))
                {
                    finalFuel = customFuelSettings[f].GetFunctionFuel(f);
                }
                else if (MutateCSharp.Schemata487.ReplaceBinExprOp_20(1622L, this.amount, (int)FuelAmount.NONE))
                {
                    finalFuel = this.ToExpr();
                }
                else
                {
                    FuelSettingPair setting = null;
                    var found = boogieGenerator.fuelContext.TryGetValue(f, out setting);

                    if (!found)
                    {  // If the context doesn't define fuel for this function, check for a fuel attribute (which supplies a default value if none is found)
                        setting = FuelAttrib(f, out found);
                    }

                    FuelConstant fuelConstant = boogieGenerator.functionFuel.Find(x => MutateCSharp.Schemata487.ReplaceBinExprOp_38(1627L, x.f, f));
                    if (MutateCSharp.Schemata487.ReplaceBinExprOp_20(1628L, this.amount, (int)FuelAmount.LOW))
                    {
                        finalFuel = GetFunctionFuel(MutateCSharp.Schemata487.ReplaceBinExprOp_16(1637L, setting.low, MutateCSharp.Schemata487.ReplaceNumericConstant_0(1633L, 0)) ? setting.low : this.amount, found, fuelConstant);
                    }
                    else if (MutateCSharp.Schemata487.ReplaceBinExprOp_75(1642L, this.amount, (int)FuelAmount.HIGH))
                    {
                        finalFuel = GetFunctionFuel(MutateCSharp.Schemata487.ReplaceBinExprOp_16(1651L, setting.high, MutateCSharp.Schemata487.ReplaceNumericConstant_0(1647L, 0)) ? setting.high : this.amount, found, fuelConstant);
                    }
                    else
                    {
                        Contract.Assert(false); // Should not reach here
                        finalFuel = null;
                    }
                }
                return finalFuel;
            }

            private Bpl.Expr GetFunctionFuel(int amount, bool hasFuel, FuelConstant fuelConstant)
            {
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_39(1656L, fuelConstant, null))
                {
                    /*
                    if (hasFuel) {
                      // it has fuel context
                      return LayerN(amount, fuelConstant.baseFuel);
                    } else {
                     */
                    // startfuel
                    if (MutateCSharp.Schemata487.ReplaceBinExprOp_20(1657L, amount, (int)FuelAmount.LOW))
                    {
                        return fuelConstant.startFuel;
                    }
                    else
                    {
                        return fuelConstant.startFuelAssert;
                    }
                    //}
                }
                else
                {
                    return ToExpr(amount);
                }

                return default;
            }

            /// <summary>
            /// Finds all fuel related attributes of the form {:fuel function low [high]}
            /// Adds the setting to the context _if_ the context does not already have a setting for that function.
            /// In other words, it should be called in order from most to least specific context scope.
            /// </summary>
            public static void FindFuelAttributes(Attributes attribs, FuelContext fuelContext)
            {
                Function f = null;
                FuelSettingPair setting = null;

                if (MutateCSharp.Schemata487.ReplaceBinExprOp_73(1662L, attribs, null))
                {
                    List<List<Expression>> results = Attributes.FindAllExpressions(attribs, MutateCSharp.Schemata487.ReplaceStringConstant_6(1663L, "fuel"));

                    if (MutateCSharp.Schemata487.ReplaceBinExprOp_79(1664L, results, null))
                    {
                        foreach (List<Expression> args in results)
                        {
                            if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1675L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_74(1665L, args, null), () => MutateCSharp.Schemata487.ReplaceBinExprOp_75(1670L, args.Count, MutateCSharp.Schemata487.ReplaceNumericConstant_0(1666L, 2))))
                            {
                                // Try to extract the function from the first argument
                                MemberSelectExpr selectExpr = args[MutateCSharp.Schemata487.ReplaceNumericConstant_0(1681L, 0)].Resolved as MemberSelectExpr;
                                if (MutateCSharp.Schemata487.ReplaceBinExprOp_80(1685L, selectExpr, null))
                                {
                                    f = selectExpr.Member as Function;
                                }

                                // Try to extract the lower fuel setting
                                LiteralExpr literalLow = args[MutateCSharp.Schemata487.ReplaceNumericConstant_0(1686L, 1)] as LiteralExpr;
                                if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1691L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_76(1690L, literalLow, null), () => literalLow.Value is BigInteger))
                                {
                                    setting = new FuelSettingPair();
                                    setting.low = (int)((BigInteger)literalLow.Value);
                                }

                                // The user may supply an additional high argument; if not, it defaults to low + 1
                                if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1707L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_81(1697L, f, null), () => MutateCSharp.Schemata487.ReplaceBinExprOp_75(1702L, args.Count, MutateCSharp.Schemata487.ReplaceNumericConstant_0(1698L, 3))))
                                {
                                    LiteralExpr literalHigh = args[MutateCSharp.Schemata487.ReplaceNumericConstant_0(1713L, 2)] as LiteralExpr;
                                    if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1725L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_5(1719L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_82(1717L, setting, null), () => MutateCSharp.Schemata487.ReplaceBinExprOp_76(1718L, literalHigh, null)), () => literalHigh.Value is BigInteger))
                                    {
                                        setting.high = (int)((BigInteger)literalHigh.Value);
                                        if (!fuelContext.ContainsKey(f))
                                        {
                                            fuelContext.Add(f, setting);
                                        }
                                    }
                                }
                                else if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1733L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_81(1731L, f, null), () => MutateCSharp.Schemata487.ReplaceBinExprOp_82(1732L, setting, null)))
                                {
                                    setting.high = MutateCSharp.Schemata487.ReplaceBinExprOp_77(1743L, setting.low, MutateCSharp.Schemata487.ReplaceNumericConstant_0(1739L, 1));
                                    if (!fuelContext.ContainsKey(f))
                                    {
                                        fuelContext.Add(f, setting);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            /// <summary>
            /// Extend the given context with fuel information from the declaration itself, and enclosing modules
            /// </summary>
            private static void AddFuelContext(FuelContext context, TopLevelDecl decl)
            {
                FindFuelAttributes(decl.Attributes, context);

                var module = decl.EnclosingModuleDefinition;
                while (MutateCSharp.Schemata487.ReplaceBinExprOp_83(1752L, module, null))
                {
                    FindFuelAttributes(module.Attributes, context);
                    module = module.EnclosingModule;
                }
            }

            /// <summary>
            /// Creates a summary of all fuel settings in scope, starting from the given class declaration
            /// </summary>
            public static FuelContext NewFuelContext(TopLevelDecl decl)
            {
                FuelContext context = new FuelContext();
                AddFuelContext(context, decl);
                return context;
            }

            /// <summary>
            /// Creates a summary of all fuel settings in scope, starting from the given member declaration
            /// </summary>
            public static FuelContext NewFuelContext(MemberDecl decl)
            {
                FuelContext context = new FuelContext();

                FindFuelAttributes(decl.Attributes, context);
                AddFuelContext(context, decl.EnclosingClass);

                return context;
            }

            /// <summary>
            /// Extends the given fuel context with any new fuel settings found in attribs
            /// </summary>
            public static FuelContext ExpandFuelContext(Attributes attribs, IToken tok, FuelContext oldFuelContext, ErrorReporter reporter)
            {
                Contract.Ensures(GetSavedContexts().Count == Contract.OldValue(GetSavedContexts().Count) + 1);
                FuelContext newContext = new FuelContext();
                FindFuelAttributes(attribs, newContext);
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_16(1757L, newContext.Count, MutateCSharp.Schemata487.ReplaceNumericConstant_0(1753L, 0)))
                {
                    // first make sure that the fuel only increase relative to the oldContext
                    foreach (var pair in newContext)
                    {
                        FuelSettingPair newSetting = pair.Value;
                        FuelSettingPair oldSetting;
                        var found = oldFuelContext.TryGetValue(pair.Key, out oldSetting);
                        if (!found)
                        {    // the default is {:fuel, 1, 2}
                            oldSetting = new FuelSettingPair();
                        }
                        // make sure that the fuel can only increase within a given scope
                        if (MutateCSharp.Schemata487.ReplaceBinExprOp_17(1772L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_1(1762L, newSetting.low, oldSetting.low), () => MutateCSharp.Schemata487.ReplaceBinExprOp_1(1767L, newSetting.high, oldSetting.high)))
                        {
                            reporter.Error(MessageSource.Translator, ErrorId.g_fuel_must_increase, tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(1778L, "Fuel can only increase within a given scope."));
                        }
                    }
                    // add oldContext to newContext if it doesn't exist already
                    foreach (var pair in oldFuelContext)
                    {
                        if (!newContext.ContainsKey(pair.Key))
                        {    // Local setting takes precedence over old context
                            newContext.Add(pair.Key, pair.Value);
                        }
                    }
                }
                else
                {
                    newContext = oldFuelContext;
                }
                GetSavedContexts().Push(oldFuelContext);

                return newContext;
            }

            private static Stack<FuelContext> GetSavedContexts()
            {
                var result = SavedContexts.Value;
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_84(1779L, result, null))
                {
                    SavedContexts.Value = result = new();
                }
                return result;
            }

            public static FuelContext PopFuelContext()
            {
                Contract.Requires(GetSavedContexts().Count > 0);
                return GetSavedContexts().Pop();
            }

        }

        public enum IsAllocType { ISALLOC, NOALLOC, NEVERALLOC };  // NEVERALLOC is like NOALLOC, but overrides AlwaysAlloc
        static IsAllocType ISALLOC
        {
            get { return IsAllocType.ISALLOC; }
        }

        static IsAllocType NOALLOC
        {
            get { return IsAllocType.NOALLOC; }
        }

        private bool DisableNonLinearArithmetic => DetermineDisableNonLinearArithmetic(forModule, options);
        private int ArithmeticSolver
        {
            get
            {
                var arithmeticSolver = Attributes.Find(forModule.Attributes, MutateCSharp.Schemata487.ReplaceStringConstant_6(1780L, "z3ArithmeticSolver"));

                // The value 2 tends to lead to the best all-around arithmetic
                // performance, though some programs can be verified more quickly
                // (or verified at all) using a different solver.
                // https://microsoft.github.io/z3guide/programming/Parameters/
                var defaultSolver = MutateCSharp.Schemata487.ReplaceNumericConstant_0(1781L, 2);
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_58(1785L, arithmeticSolver, null))
                {
                    return defaultSolver;
                }

                var arg = MutateCSharp.Schemata487.ReplaceBinExprOp_16(1790L, arithmeticSolver.Args.Count, MutateCSharp.Schemata487.ReplaceNumericConstant_0(1786L, 0)) ? arithmeticSolver.Args[MutateCSharp.Schemata487.ReplaceNumericConstant_0(1795L, 0)] : null;
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_46(1799L, arg, null))
                {
                    return defaultSolver;
                }

                if (!Expression.IsIntLiteral(arg, out var value))
                {
                    return MutateCSharp.Schemata487.ReplaceNumericConstant_0(1800L, 0);
                }
                try
                {
                    return (int)value;
                }
                catch (OverflowException)
                {
                    return defaultSolver;
                }

                return default;
            }
        }

        public static bool DetermineDisableNonLinearArithmetic(ModuleDefinition module, DafnyOptions dafnyOptions)
        {
            var nlaAttribute = Attributes.Find(module.Attributes, MutateCSharp.Schemata487.ReplaceStringConstant_6(1804L, "disableNonlinearArithmetic"));
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_73(1805L, nlaAttribute, null))
            {
                var value = MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1806L, true);
                var arg = MutateCSharp.Schemata487.ReplaceBinExprOp_16(1811L, nlaAttribute.Args.Count, MutateCSharp.Schemata487.ReplaceNumericConstant_0(1807L, 0)) ? nlaAttribute.Args[MutateCSharp.Schemata487.ReplaceNumericConstant_0(1816L, 0)] : null;
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_33(1820L, arg, null))
                {
                    Expression.IsBoolLiteral(arg, out value);
                }

                return value;
            }

            return dafnyOptions.DisableNLarith;
        }

        public class IsAllocContext
        {
            private DafnyOptions options;
            internal bool allVarsGhost;

            internal IsAllocContext(DafnyOptions options, bool allVarsGhost)
            {
                this.options = options;
                this.allVarsGhost = allVarsGhost;
            }

            internal IsAllocType Var(bool isGhost)
            {
                return ISALLOC;
            }

            internal IsAllocType Var(LocalVariable local)
            {
                return Var(MutateCSharp.Schemata487.ReplaceBinExprOp_17(1821L, () => allVarsGhost, () => local.IsGhost));
            }

            internal IsAllocType Var(NonglobalVariable var)
            {
                return Var(MutateCSharp.Schemata487.ReplaceBinExprOp_17(1827L, () => allVarsGhost, () => var.IsGhost));
            }

            internal IsAllocType Var(bool ghostStmt, LocalVariable var)
            {
                return Var(MutateCSharp.Schemata487.ReplaceBinExprOp_17(1839L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_17(1833L, () => allVarsGhost, () => ghostStmt), () => var.IsGhost));
            }

            internal IsAllocType Var(bool ghostStmt, NonglobalVariable var)
            {
                return Var(MutateCSharp.Schemata487.ReplaceBinExprOp_17(1851L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_17(1845L, () => allVarsGhost, () => ghostStmt), () => var.IsGhost));
            }
        }

        List<SplitExprInfo/*!*/>/*!*/ TrSplitExpr(Expression expr, ExpressionTranslator etran, bool apply_induction, out bool splitHappened)
        {
            Contract.Requires(expr != null);
            Contract.Requires(etran != null);
            Contract.Ensures(Contract.Result<List<SplitExprInfo>>() != null);

            var splits = new List<SplitExprInfo>();
            splitHappened = TrSplitExpr(expr, splits, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1857L, true), int.MaxValue, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1858L, true), apply_induction, etran);
            return splits;
        }

        List<SplitExprInfo> TrSplitExprForMethodSpec(Expression expr, ExpressionTranslator etran, MethodTranslationKind kind)
        {
            Contract.Requires(expr != null);
            Contract.Requires(etran != null);
            Contract.Ensures(Contract.Result<List<SplitExprInfo>>() != null);

            var splits = new List<SplitExprInfo>();
            var apply_induction = kind == MethodTranslationKind.Implementation;
            bool splitHappened;  // we don't actually care
            splitHappened = TrSplitExpr(expr, splits, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1859L, true), int.MaxValue, kind != MethodTranslationKind.Call, apply_induction, etran);
            return splits;
        }

        Bpl.Trigger TrTrigger(ExpressionTranslator etran, Attributes attribs, IToken tok, Dictionary<IVariable, Expression> substMap = null)
        {
            Contract.Requires(etran != null);
            Contract.Requires(tok != null);
            var argsEtran = etran.WithNoLits();
            Bpl.Trigger tr = null;
            foreach (var trigger in attribs.AsEnumerable().Where(aa => MutateCSharp.Schemata487.ReplaceBinExprOp_8(1861L, aa.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(1860L, "trigger"))).Select(aa => aa.Args))
            {
                List<Bpl.Expr> tt = new List<Bpl.Expr>();
                foreach (var arg in trigger)
                {
                    if (MutateCSharp.Schemata487.ReplaceBinExprOp_85(1862L, substMap, null))
                    {
                        tt.Add(argsEtran.TrExpr(arg));
                    }
                    else
                    {
                        tt.Add(argsEtran.TrExpr(Substitute(arg, null, substMap)));
                    }
                }
                tr = new Bpl.Trigger(tok, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1863L, true), tt, tr);
            }
            return tr;
        }

        Bpl.Trigger TrTrigger(ExpressionTranslator etran, Attributes attribs, IToken tok, List<Variable> bvars, Dictionary<IVariable, Expression> substMap, Dictionary<TypeParameter, Type> typeMap)
        {
            Contract.Requires(etran != null);
            Contract.Requires(tok != null);
            var argsEtran = etran.WithNoLits();
            Bpl.Trigger tr = null;
            var fueledTrigger = new Dictionary<List<Expression>, bool>();
            // translate the triggers once to see if fuel or the heap is used as quantifier boundvar
            foreach (var aa in attribs.AsEnumerable())
            {
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_8(1865L, aa.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(1864L, "trigger")))
                {
                    int fuelCount = argsEtran.Statistics_CustomLayerFunctionCount;
                    foreach (var arg in aa.Args)
                    {
                        argsEtran.TrExpr(arg);
                    }
                    fueledTrigger[aa.Args] = MutateCSharp.Schemata487.ReplaceBinExprOp_16(1866L, argsEtran.Statistics_CustomLayerFunctionCount, fuelCount);
                }
            }

            bool useFuelAsQuantifier = MutateCSharp.Schemata487.ReplaceBinExprOp_16(1875L, argsEtran.Statistics_CustomLayerFunctionCount, MutateCSharp.Schemata487.ReplaceNumericConstant_0(1871L, 0));
            bool useHeapAsQuantifier = MutateCSharp.Schemata487.ReplaceBinExprOp_16(1884L, argsEtran.Statistics_HeapAsQuantifierCount, MutateCSharp.Schemata487.ReplaceNumericConstant_0(1880L, 0));
            if (useHeapAsQuantifier)
            {
                var heapExpr = BplBoundVar(CurrentIdGenerator.FreshId(MutateCSharp.Schemata487.ReplaceStringConstant_6(1889L, "tr$heap#")), predef.HeapType, bvars);
                argsEtran = new ExpressionTranslator(argsEtran, heapExpr);
            }

            // now translate it with the correct layer and heapExpr
            foreach (var trigger in attribs.AsEnumerable().Where(aa => MutateCSharp.Schemata487.ReplaceBinExprOp_8(1891L, aa.Name, MutateCSharp.Schemata487.ReplaceStringConstant_6(1890L, "trigger"))))
            {
                List<Bpl.Expr> tt = new List<Bpl.Expr>();
                foreach (var arg in trigger.Args)
                {
                    if (MutateCSharp.Schemata487.ReplaceBinExprOp_85(1892L, substMap, null))
                    {
                        tt.Add(argsEtran.TrExpr(arg));
                    }
                    else
                    {
                        tt.Add(argsEtran.TrExpr(Substitute(arg, null, substMap, typeMap)));
                    }
                }
                if (useHeapAsQuantifier)
                {
                    tt.Add(FunctionCall(tok, BuiltinFunction.IsGoodHeap, null, argsEtran.HeapExpr));
                }
                tr = new Bpl.Trigger(tok, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1893L, true), tt, tr);
            }
            return tr;
        }

        public class VariablesCollector : BottomUpVisitor
        {
            internal ISet<IVariable> variables;

            internal VariablesCollector()
            {
                this.variables = new HashSet<IVariable>();
            }

            protected override void VisitOneExpr(Expression expr)
            {
                if (expr is IdentifierExpr)
                {
                    variables.Add((expr as IdentifierExpr).Var);
                }
            }
        }

        bool TrSplitNeedsTokenAdjustment(Expression expr)
        {
            Contract.Requires(expr != null);
            return MutateCSharp.Schemata487.ReplaceBinExprOp_5(1907L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_5(1901L, () => RefinementToken.IsInherited(expr.tok, currentModule), () => (MutateCSharp.Schemata487.ReplaceBinExprOp_17(1895L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_57(1894L, codeContext, null), () => !codeContext.MustReverify))), () => RefinementTransformer.ContainsChange(expr, currentModule));
        }

        /// <summary>
        /// Return a list of variables specified by the arguments of :_induction in "attributes", if any.
        /// If an argument of :_induction is a ThisExpr, "null" is returned as the corresponding variable.
        /// </summary>
        List<VarType/*?*/> ApplyInduction<VarType>(List<VarType> boundVars, Attributes attributes) where VarType : class, IVariable
        {
            Contract.Requires(boundVars != null);
            Contract.Ensures(Contract.Result<List<VarType>>() != null);

            var args = Attributes.FindExpressions(attributes, MutateCSharp.Schemata487.ReplaceStringConstant_6(1913L, "_induction"));
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_59(1914L, args, null))
            {
                return new List<VarType>();  // don't apply induction
            }
            else
            {
                return args.ConvertAll(e => e is ThisExpr ? null : (VarType)((IdentifierExpr)e).Var);
            }

            return default;
        }

        // No expression introduces a type variable
        static void ComputeFreeTypeVariables(Expression expr, ISet<TypeParameter> fvs)
        {
            ComputeFreeTypeVariables(expr.Type, fvs);
            expr.ComponentTypes.ForEach(ty => ComputeFreeTypeVariables((Type)ty, fvs));
            expr.SubExpressions.ForEach(ee => ComputeFreeTypeVariables(ee, fvs));
        }

        static void ComputeFreeTypeVariables(Type ty, ISet<TypeParameter> fvs)
        {
            // Add type parameters
            var tp = ty.AsTypeParameter;
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_86(1915L, tp, null))
            {
                Contract.Assert(ty.TypeArgs.Count == 0);
                fvs.Add(tp);
            }
            else
            {
                ty.NormalizeExpandKeepConstraints().TypeArgs.ForEach(tt => ComputeFreeTypeVariables(tt, fvs));
            }
        }

        static void ComputeFreeTypeVariables_All(Type ty, ISet<TypeParameter> fvs)
        {
            // Add type parameters
            if (ty.IsTypeParameter)
            {
                fvs.Add(ty.AsTypeParameter);
            }
            ty.NormalizeExpandKeepConstraints().TypeArgs.ForEach(tt => ComputeFreeTypeVariables_All(tt, fvs));
        }

        public bool UsesHeap(Expression expr)
        {
            UsesHeapVisitor visitor = new UsesHeapVisitor();
            visitor.Visit(expr);
            if (visitor.foundHeap)
            {
                return MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1916L, true);
            }
            bool usesHeap = MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1917L, false), usesOldHeap = MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1918L, false);
            var FVsHeapAt = new HashSet<Label>();
            Type usesThis = null;
            FreeVariablesUtil.ComputeFreeVariables(options, expr, new HashSet<IVariable>(), ref usesHeap, ref usesOldHeap, FVsHeapAt, ref usesThis, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1919L, false));
            return MutateCSharp.Schemata487.ReplaceBinExprOp_17(1935L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_17(1920L, () => usesHeap, () => usesOldHeap), () => MutateCSharp.Schemata487.ReplaceBinExprOp_7(1930L, FVsHeapAt.Count, MutateCSharp.Schemata487.ReplaceNumericConstant_0(1926L, 0)));
        }

        public
            class UsesHeapVisitor : BottomUpVisitor
        {
            internal bool foundHeap = MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1941L, false);
            Type usesThis = null;
            protected override void VisitOneExpr(Expression expr)
            {
                LetExpr letExpr = expr as LetExpr;
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1943L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_87(1942L, letExpr, null), () => !letExpr.Exact))
                {
                    foundHeap = MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1949L, true); // see comment in LetSuchThatExprInfo: "UsesHeap = true;  // note, we ignore "usesHeap" and always record it as "true", because various type antecedents need access to the heap (hopefully, this is okay in the contexts in which the let-such-that expression is used)"
                }
                FunctionCallExpr call = expr as FunctionCallExpr;
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1958L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_5(1952L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_88(1950L, call, null), () => MutateCSharp.Schemata487.ReplaceBinExprOp_81(1951L, call.Function, null)), () => call.Function.ReadsHeap))
                {
                    foundHeap = MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1964L, true);
                }
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_17(1965L, () => expr is ApplyExpr, () => expr is SeqConstructionExpr))
                {
                    foundHeap = MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1971L, true);
                }
                ThisExpr thisExpr = expr as ThisExpr;
                if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1974L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_89(1972L, thisExpr, null), () => MutateCSharp.Schemata487.ReplaceBinExprOp_54(1973L, thisExpr.Type, null)))
                { // this shouldn't happen, but there appears to be a bug in trait resolution (see TraitCompile.dfy); it causes ComputeFreeVariables to blow up
                    foundHeap = MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1980L, true);
                }
                else if (MutateCSharp.Schemata487.ReplaceBinExprOp_5(1989L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_5(1983L, () => MutateCSharp.Schemata487.ReplaceBinExprOp_89(1981L, thisExpr, null), () => MutateCSharp.Schemata487.ReplaceBinExprOp_90(1982L, usesThis, null)), () => !thisExpr.Type.Equals(usesThis)))
                { // also causes ComputeFreeVariables to blow up (see TraitExample.dfy)
                    foundHeap = MutateCSharp.Schemata487.ReplaceBooleanConstant_2(1995L, true);
                }
                else if (MutateCSharp.Schemata487.ReplaceBinExprOp_89(1996L, thisExpr, null))
                {
                    usesThis = thisExpr.Type;
                }
            }
        }

        /// <summary>
        /// Returns an expression like "expr", but where free occurrences of "v" have been replaced by "e".
        /// </summary>
        public static Expression Substitute(Expression expr, IVariable v, Expression e)
        {
            Contract.Requires(expr != null);
            Contract.Requires(v != null);
            Contract.Requires(e != null);
            Contract.Ensures(Contract.Result<Expression>() != null);
            var substMap = new Dictionary<IVariable, Expression>();
            substMap.Add(v, e);
            return Substitute(expr, null, substMap);
        }

        public static Expression Substitute(Expression expr, Expression receiverReplacement, Dictionary<IVariable, Expression/*!*/>/*!*/ substMap,
          Dictionary<TypeParameter, Type> typeMap = null, Label oldLabel = null)
        {
            Contract.Requires(expr != null);
            Contract.Requires(cce.NonNullDictionaryAndValues(substMap));
            Contract.Ensures(Contract.Result<Expression>() != null);
            var s = new Substituter(receiverReplacement, substMap, typeMap ?? new Dictionary<TypeParameter, Type>(), oldLabel);
            return s.Substitute(expr);
        }

        public static Expression InlineLet(LetExpr letExpr)
        {
            Contract.Requires(letExpr.LHSs.All(p => p.Var != null));
            var substMap = new Dictionary<IVariable, Expression>();
            for (var i = MutateCSharp.Schemata487.ReplaceNumericConstant_0(1997L, 0); MutateCSharp.Schemata487.ReplaceBinExprOp_1(2001L, i, letExpr.LHSs.Count); MutateCSharp.Schemata487.ReplacePostfixUnaryExprOp_34(2006L, ref i))
            {
                substMap.Add(letExpr.LHSs[i].Var, letExpr.RHSs[i]);
            }
            return BoogieGenerator.Substitute(letExpr.Body, null, substMap);
        }

        Bpl.Expr HeapSameOrSucc(Bpl.Expr oldHeap, Bpl.Expr newHeap)
        {
            return BplOr(
              Bpl.Expr.Eq(oldHeap, newHeap),
              FunctionCall(newHeap.tok, BuiltinFunction.HeapSucc, null, oldHeap, newHeap));
        }
        Bpl.Expr HeapSucc(Bpl.Expr oldHeap, Bpl.Expr newHeap, bool useGhostHeapSucc = false)
        {
            return FunctionCall(newHeap.tok, useGhostHeapSucc ? BuiltinFunction.HeapSuccGhost : BuiltinFunction.HeapSucc, null, oldHeap, newHeap);
        }

        // Bpl-making-utilities

        /// <summary>
        /// Create a Boogie quantifier with body "A ==> body" and triggers "trg", but use only the subset of bound
        /// variables from "varsAndAntecedents" that actually occur free in "body" or "trg", and "A" is the conjunction of
        /// antecedents for those corresponding bound variables.  If none of the bound variables is used, "body"
        /// is returned. Also, if none of the bound variables is used in "body" (whether or not they are used in "trg"),
        /// then "body" is returned.
        /// The order of the contents of "varsAndAntecedents" matters: For any index "i" into "varsAndAntecedents", the
        /// antecedent varsAndAntecedents[i].Item2 may depend on a variable varsAndAntecedents[j].Item1 if "j GREATER-OR-EQUAL i"
        /// but not if "j LESS i".
        /// Caution: if "trg" is null, makes a forall without any triggers.
        /// </summary>
        static Bpl.Expr BplForallTrim(IEnumerable<Tuple<Bpl.Variable, Bpl.Expr/*?*/>> varsAndAntecedents, Bpl.Trigger trg, Bpl.Expr body)
        {
            Contract.Requires(varsAndAntecedents != null);
            Contract.Requires(body != null);

            // We'd like to compute the free variables if "body" and "trg". It would be nice to use the Boogie
            // routine Bpl.Expr.ComputeFreeVariables for this purpose. However, calling it requires the Boogie
            // expression to be resolved. Instead, we do the cheesy thing of computing the set of names of
            // free variables in "body" and "trg".
            var vis = new VariableNameVisitor();
            vis.Visit(body);
            if (varsAndAntecedents.All(pair => !vis.Names.Contains(pair.Item1.Name)))
            {
                // the body doesn't mention any of the bound variables, so no point in wrapping a quantifier around it
                return body;
            }
            for (var tt = trg; MutateCSharp.Schemata487.ReplaceBinExprOp_91(2007L, tt, null); tt = tt.Next)
            {
                tt.Tr.ForEach(ee => vis.Visit(ee));
            }

            var args = new List<Bpl.Variable>();
            Bpl.Expr typeAntecedent = Bpl.Expr.True;
            foreach (var pair in varsAndAntecedents)
            {
                var bv = pair.Item1;
                var wh = pair.Item2;
                if (vis.Names.Contains(bv.Name))
                {
                    args.Add(bv);
                    if (MutateCSharp.Schemata487.ReplaceBinExprOp_31(2008L, wh, null))
                    {
                        typeAntecedent = BplAnd(typeAntecedent, wh);
                        vis.Visit(wh);  // this adds to "vis.Names" the free variables of "wh"
                    }
                }
            }
            if (MutateCSharp.Schemata487.ReplaceBinExprOp_20(2013L, args.Count, MutateCSharp.Schemata487.ReplaceNumericConstant_0(2009L, 0)))
            {
                return body;
            }
            else
            {
                return new Bpl.ForallExpr(body.tok, args, trg, BplImp(typeAntecedent, body));
            }

            return default;
        }

        public class VariableNameVisitor : Boogie.StandardVisitor
        {
            public readonly HashSet<string> Names = new HashSet<string>();
            public override Expr VisitIdentifierExpr(Bpl.IdentifierExpr node)
            {
                Names.Add(node.Name);
                return base.VisitIdentifierExpr(node);
            }
            public override BinderExpr VisitBinderExpr(BinderExpr node)
            {
                var vis = new VariableNameVisitor();
                vis.Visit(node.Body);
                var dummyNames = new HashSet<string>(node.Dummies.Select(v => v.Name));
                foreach (var nm in vis.Names)
                {
                    if (!dummyNames.Contains(nm))
                    {
                        Names.Add(nm);
                    }
                }
                return (BinderExpr)base.VisitBinderExpr(node);
            }
        }

        List<Bpl.Variable> MkTyParamBinders(List<TypeParameter> args)
        {
            return MkTyParamBinders(args, out _);
        }

        List<Bpl.Variable> MkTyParamBinders(List<TypeParameter> args, out List<Bpl.Expr> exprs)
        {
            var vars = new List<Bpl.Variable>();
            exprs = new List<Bpl.Expr>();
            foreach (TypeParameter v in args)
            {
                vars.Add(BplBoundVar(NameTypeParam(v), predef.Ty, out var e));
                exprs.Add(e);
            }
            return vars;
        }

        // For incoming formals
        List<Variable> MkTyParamFormals(List<TypeParameter> args, bool includeWhereClause, bool named = true)
        {
            return MkTyParamFormals(args, out _, includeWhereClause, named);
        }

        // For incoming formals
        List<Bpl.Variable> MkTyParamFormals(List<TypeParameter> args, out List<Bpl.Expr> exprs, bool includeWhereClause, bool named)
        {
            var vars = new List<Bpl.Variable>();
            exprs = new List<Bpl.Expr>();
            foreach (TypeParameter v in args)
            {
                var whereClause = includeWhereClause ? GetTyWhereClause(new Bpl.IdentifierExpr(v.tok, NameTypeParam(v), predef.Ty), v.Characteristics) : null;
                vars.Add(BplFormalVar(named ? NameTypeParam(v) : null, predef.Ty, MutateCSharp.Schemata487.ReplaceBooleanConstant_2(2018L, true), out var e, whereClause));
                exprs.Add(e);
            }
            return vars;
        }

        public Bpl.Expr/*?*/ GetTyWhereClause(Bpl.Expr expr, TypeParameter.TypeParameterCharacteristics characteristics)
        {
            Contract.Requires(expr != null);
            if (characteristics.ContainsNoReferenceTypes)
            {
                return FunctionCall(expr.tok, MutateCSharp.Schemata487.ReplaceStringConstant_6(2019L, "$AlwaysAllocated"), Bpl.Type.Bool, expr);
            }
            return null;
        }

        public static void MapM<A>(IEnumerable<A> xs, Action<A> K)
        {
            Contract.Requires(xs != null);
            Contract.Requires(K != null);
            foreach (A x in xs)
            {
                K(x);
            }
        }

        static readonly List<Boolean> Bools = new List<Boolean> { MutateCSharp.Schemata487.ReplaceBooleanConstant_2(2020L, false), MutateCSharp.Schemata487.ReplaceBooleanConstant_2(2021L, true) };

        public Expr GetRevealConstant(Function f)
        {
            this.CreateRevealableConstant(f);
            return this.functionReveals[f];
        }
    }
}
