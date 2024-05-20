#define TI_DEBUG_PRINT
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
using System.IO;
using System.Reflection;
using DafnyCore;
using JetBrains.Annotations;
using Microsoft.BaseTypes;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Dafny.Plugins;
namespace MutateCSharp
{
    internal class Schemata407
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT407");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_73(long mutantId, Microsoft.Dafny.ActualBinding argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_51(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_77(long mutantId, Microsoft.Dafny.MethodCallInformation argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_59(long mutantId, Microsoft.Dafny.FrameExpressionUse argument1, Microsoft.Dafny.FrameExpressionUse argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_47(long mutantId, Microsoft.Dafny.InternalTypeSynonymDecl argument1, Microsoft.Dafny.InternalTypeSynonymDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, Microsoft.Dafny.InferredTypeProxy argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_42(long mutantId, Microsoft.Dafny.SetType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_23(long mutantId, Microsoft.Dafny.UpdateStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_103(long mutantId, Microsoft.Dafny.TraitDecl argument1, Microsoft.Dafny.TraitDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_81(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.AssignmentRhs> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_39(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 >= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 > argument2; }
            return argument1 >= argument2;
        }

        internal static bool ReplaceBinExprOp_89(long mutantId, Microsoft.Dafny.ResolveTypeOptionEnum argument1, Microsoft.Dafny.ResolveTypeOptionEnum argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_62(long mutantId, Microsoft.Dafny.Label argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_36(long mutantId, Microsoft.Dafny.TypeProxy.Family argument1, Microsoft.Dafny.TypeProxy.Family argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_111(long mutantId, Microsoft.Dafny.CommonOptionBag.GeneralTraitsOptions argument1, Microsoft.Dafny.CommonOptionBag.GeneralTraitsOptions argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_31(long mutantId, Microsoft.Dafny.TypeParameter.TPVariance argument1, Microsoft.Dafny.TypeParameter.TPVariance argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_84(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_28(long mutantId, Microsoft.Dafny.TypeParameter.TPVariance argument1, Microsoft.Dafny.TypeParameter.TPVariance argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_65(long mutantId, Microsoft.Dafny.ThisExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_94(long mutantId, Microsoft.Dafny.ArrowType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_34(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() & argument2();
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

        internal static bool ReplaceBinExprOp_44(long mutantId, Microsoft.Dafny.MapType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.Method argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_61(long mutantId, Microsoft.Dafny.AssertLabel argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.BoundVar argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_96(long mutantId, Microsoft.Dafny.NonNullTypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_85(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, Microsoft.Dafny.ModuleDefinition argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_10(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 % argument2;
        }

        internal static bool ReplaceBooleanConstant_3(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_57(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, Microsoft.Dafny.ModuleDefinition argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_82(long mutantId, Microsoft.Dafny.IMethodCodeContext argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_78(long mutantId, Microsoft.Dafny.MemberSelectExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_53(long mutantId, Microsoft.Dafny.TypeProxy argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_46(long mutantId, Microsoft.Dafny.TypeParameter argument1, Microsoft.Dafny.TypeParameter argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_106(long mutantId, Microsoft.Dafny.TypeParameter.TPVarianceSyntax argument1, Microsoft.Dafny.TypeParameter.TPVarianceSyntax argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static bool ReplaceBinExprOp_88(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.FrameExpression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.TopLevelDeclWithMembers argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_116(long mutantId, Microsoft.Dafny.DatatypeCtor argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.Label argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_60(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_112(long mutantId, System.Collections.Generic.Dictionary<string, Microsoft.Dafny.DatatypeCtor> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_95(long mutantId, Microsoft.Dafny.ActualBindings argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_113(long mutantId, Microsoft.Dafny.ModuleDecl argument1, object argument2)
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

        internal static bool ReplaceBinExprOp_38(long mutantId, System.Collections.Generic.List<int> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_29(long mutantId, Microsoft.Dafny.TypeProxy argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_93(long mutantId, Microsoft.Dafny.ICallable argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_40(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_54(long mutantId, Microsoft.Dafny.Type argument1, Microsoft.Dafny.TypeProxy argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static bool ReplaceBinExprOp_24(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_33(long mutantId, Microsoft.Dafny.NewtypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_110(long mutantId, Microsoft.Dafny.TypeParameter argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_115(long mutantId, Microsoft.Dafny.Function argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_37(long mutantId, Microsoft.Dafny.Type argument1, Microsoft.Dafny.Type argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_98(long mutantId, Microsoft.Dafny.ModuleResolver.ResolveTypeReturn argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_108(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_80(long mutantId, Microsoft.Dafny.LList<Microsoft.Dafny.Label> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_91(long mutantId, Microsoft.Dafny.ModuleResolver.ResolveTypeReturn argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_97(long mutantId, Microsoft.Dafny.NonNullTypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_67(long mutantId, Microsoft.Dafny.Statement argument1, Microsoft.Dafny.Statement argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_114(long mutantId, Microsoft.Dafny.ValuetypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_86(long mutantId, Microsoft.Dafny.CalcStmt.CalcOp argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_68(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_71(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_55(long mutantId, Microsoft.Dafny.TypeProxy argument1, Microsoft.Dafny.TypeProxy argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_87(long mutantId, Microsoft.Dafny.CalcStmt.CalcOp argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_64(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_102(long mutantId, Microsoft.Dafny.ClassLikeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, Microsoft.Dafny.ArrowType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_41(long mutantId, System.Collections.Generic.List<int> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_107(long mutantId, Microsoft.Dafny.ICallable argument1, Microsoft.Dafny.ICallable argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_72(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_100(long mutantId, Microsoft.Dafny.TopLevelDeclWithMembers argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_83(long mutantId, Microsoft.Dafny.IVariable argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_76(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Type> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_48(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, Microsoft.Dafny.TopLevelDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_45(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_50(long mutantId, int argument1, int argument2)
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

        internal static int ReplacePostfixUnaryExprOp_35(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1--; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1++; }
            return argument1--;
        }

        internal static bool ReplaceBinExprOp_52(long mutantId, System.Collections.Generic.ISet<Microsoft.Dafny.TypeProxy> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.SubsetTypeDecl.WKind argument1, Microsoft.Dafny.SubsetTypeDecl.WKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_30(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.IVariable argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_79(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceBinExprOp_49(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 * argument2;
        }

        internal static bool ReplaceBinExprOp_58(long mutantId, Microsoft.Dafny.IndDatatypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_92(long mutantId, Microsoft.Dafny.Resolver_IdentifierExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_69(long mutantId, Microsoft.Dafny.AlternativeLoopStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_90(long mutantId, Microsoft.Dafny.ResolveTypeOptionEnum argument1, Microsoft.Dafny.ResolveTypeOptionEnum argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_70(long mutantId, int argument1, int argument2)
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

        internal static int ReplacePostfixUnaryExprOp_13(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_109(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.ActualBinding> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_75(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Type> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_26(long mutantId, Microsoft.Dafny.CollectionType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_66(long mutantId, Microsoft.Dafny.LList<Microsoft.Dafny.Label> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_32(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_25(long mutantId, Microsoft.Dafny.Scope<Microsoft.Dafny.TypeParameter>.PushResult argument1, Microsoft.Dafny.Scope<Microsoft.Dafny.TypeParameter>.PushResult argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_101(long mutantId, System.Collections.Generic.Dictionary<string, Microsoft.Dafny.MemberDecl> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_63(long mutantId, Microsoft.Dafny.Field argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_104(long mutantId, Microsoft.Dafny.TypeParameter argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_74(long mutantId, Microsoft.Dafny.ActualBinding argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceNumericConstant_6(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_99(long mutantId, Microsoft.Dafny.SelfType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, Microsoft.Dafny.UserDefinedType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_27(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, Microsoft.Dafny.ClassLikeDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_105(long mutantId, Microsoft.Dafny.TypeProxy argument1, Microsoft.Dafny.Type argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_56(long mutantId, Microsoft.Dafny.CoDatatypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public partial class ModuleResolver
    {
        public List<Statement> loopStack = new List<Statement>();  // the enclosing loops (from which it is possible to break out)
        public Scope<Label>/*!*/ DominatingStatementLabels { get; private set; }
        public Scope<Statement> EnclosingStatementLabels { get => enclosingStatementLabels;
      set => enclosingStatementLabels = value; }
        public List<Statement> LoopStack { get => loopStack;
      set => loopStack = value; }

        public Scope<Statement>/*!*/ enclosingStatementLabels;
        public Method currentMethod;

        Label/*?*/ ResolveDominatingLabelInExpr(IToken tok, string/*?*/ labelName, string expressionDescription, ResolutionContext resolutionContext)
        {
            Contract.Requires(tok != null);
            Contract.Requires(expressionDescription != null);
            Contract.Requires(resolutionContext != null);

            Label label = null;
            if (!resolutionContext.IsTwoState)
            {
                reporter.Error(MessageSource.Resolver, tok, $"{expressionDescription} expressions are not allowed in this context");
            }
            else if (labelName != null)
            {
                label = DominatingStatementLabels.Find(labelName);
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_0(1L, label, null))
                {
                    reporter.Error(MessageSource.Resolver, tok, $"no label '{labelName}' in scope at this time");
                }
            }
            return label;
        }

        /// <summary>
        /// There are two rounds of name resolution + type inference. The "initialRound" parameter says which one to do.
        /// </summary>
        void ResolveNamesAndInferTypes(List<TopLevelDecl> declarations, bool initialRound)
        {
            foreach (TopLevelDecl topd in declarations)
            {
                Contract.Assert(topd != null);
                Contract.Assert(VisibleInScope(topd));
                Contract.Assert(AllTypeConstraints.Count == 0);
                Contract.Assert(currentClass == null);

                allTypeParameters.PushMarker();
                ResolveTypeParameters(topd.TypeArgs, !initialRound, topd);

                if (initialRound)
                {
                    ResolveNamesAndInferTypesForOneDeclarationInitial(topd);
                }
                else
                {
                    ResolveNamesAndInferTypesForOneDeclaration(topd);
                }

                allTypeParameters.PopMarker();

                Contract.Assert(AllTypeConstraints.Count == 0);
                Contract.Assert(currentClass == null);
            }
        }

        /// <summary>
        /// Assumes type parameters of "topd" have already been pushed.
        /// </summary>
        void ResolveNamesAndInferTypesForOneDeclarationInitial(TopLevelDecl topd)
        {
            if (topd is NewtypeDecl newtypeDecl)
            {
                // this check can be done only after it has been determined that the redirected types do not involve cycles
                AddXConstraint(newtypeDecl.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2L, "NumericType"), newtypeDecl.BaseType, MutateCSharp.Schemata407.ReplaceStringConstant_1(3L, "newtypes must be based on some numeric type (got {0})"));
                // type check the constraint, if any
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_2(4L, newtypeDecl.Var, null))
                {
                    Contract.Assert(object.ReferenceEquals(newtypeDecl.Var.Type.NormalizeExpand(true), newtypeDecl.BaseType.NormalizeExpand(true)));  // follows from NewtypeDecl invariant
                    Contract.Assert(newtypeDecl.Constraint != null);  // follows from NewtypeDecl invariant

                    scope.PushMarker();
                    scope.AllowInstance = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(5L, false);
                    var added = scope.Push(newtypeDecl.Var.Name, newtypeDecl.Var);
                    Contract.Assert(added == Scope<IVariable>.PushResult.Success);
                    ResolveExpression(newtypeDecl.Constraint, new ResolutionContext(new CodeContextWrapper(newtypeDecl, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(6L, true)), MutateCSharp.Schemata407.ReplaceBooleanConstant_3(7L, false)));
                    Contract.Assert(newtypeDecl.Constraint.Type != null);  // follows from postcondition of ResolveExpression
                    ConstrainTypeExprBool(newtypeDecl.Constraint, MutateCSharp.Schemata407.ReplaceStringConstant_1(8L, "newtype constraint must be of type bool (instead got {0})"));
                    scope.PopMarker();
                }
                SolveAllTypeConstraints();

            }
            else if (topd is SubsetTypeDecl subsetTypeDecl)
            {
                // type check the constraint
                Contract.Assert(object.ReferenceEquals(subsetTypeDecl.Var.Type, subsetTypeDecl.Rhs)); // follows from SubsetTypeDecl invariant
                Contract.Assert(subsetTypeDecl.Constraint != null); // follows from SubsetTypeDecl invariant
                scope.PushMarker();
                scope.AllowInstance = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(9L, false);
                var added = scope.Push(subsetTypeDecl.Var.Name, subsetTypeDecl.Var);
                Contract.Assert(added == Scope<IVariable>.PushResult.Success);
                ResolveExpression(subsetTypeDecl.Constraint, new ResolutionContext(new CodeContextWrapper(subsetTypeDecl, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(10L, true)), MutateCSharp.Schemata407.ReplaceBooleanConstant_3(11L, false)));
                Contract.Assert(subsetTypeDecl.Constraint.Type != null); // follows from postcondition of ResolveExpression
                ConstrainTypeExprBool(subsetTypeDecl.Constraint, MutateCSharp.Schemata407.ReplaceStringConstant_1(12L, "subset-type constraint must be of type bool (instead got {0})"));
                scope.PopMarker();
                SolveAllTypeConstraints();
            }

            if (topd is TopLevelDeclWithMembers cl)
            {
                ResolveClassMemberBodiesInitial(cl);
            }
        }

        void ResolveNamesAndInferTypesForOneDeclaration(TopLevelDecl topd)
        {
            if (topd is NewtypeDecl newtypeDecl)
            {
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_4(13L, newtypeDecl.Witness, null))
                {
                    var codeContext = new CodeContextWrapper(newtypeDecl, MutateCSharp.Schemata407.ReplaceBinExprOp_5(14L, newtypeDecl.WitnessKind, SubsetTypeDecl.WKind.Ghost));
                    scope.PushMarker();
                    scope.AllowInstance = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(15L, false);
                    ResolveExpression(newtypeDecl.Witness, new ResolutionContext(codeContext, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(16L, false)));
                    scope.PopMarker();
                    ConstrainSubtypeRelation(newtypeDecl.Var.Type, newtypeDecl.Witness.Type, newtypeDecl.Witness, MutateCSharp.Schemata407.ReplaceStringConstant_1(17L, "witness expression must have type '{0}' (got '{1}')"), newtypeDecl.Var.Type, newtypeDecl.Witness.Type);
                }
                SolveAllTypeConstraints();

            }
            else if (topd is SubsetTypeDecl subsetTypeDecl)
            {
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_4(18L, subsetTypeDecl.Witness, null))
                {
                    var codeContext = new CodeContextWrapper(subsetTypeDecl, MutateCSharp.Schemata407.ReplaceBinExprOp_5(19L, subsetTypeDecl.WitnessKind, SubsetTypeDecl.WKind.Ghost));
                    scope.PushMarker();
                    scope.AllowInstance = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(20L, false);
                    ResolveExpression(subsetTypeDecl.Witness, new ResolutionContext(codeContext, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(21L, false)));
                    scope.PopMarker();
                    ConstrainSubtypeRelation(subsetTypeDecl.Var.Type, subsetTypeDecl.Witness.Type, subsetTypeDecl.Witness,
          MutateCSharp.Schemata407.ReplaceStringConstant_1(22L, "witness expression must have type '{0}' (got '{1}')"), subsetTypeDecl.Var.Type, subsetTypeDecl.Witness.Type);
                }
                SolveAllTypeConstraints();

            }
            else if (topd is IteratorDecl iteratorDecl)
            {
                ResolveIterator(iteratorDecl);

            }
            else if (topd is DatatypeDecl dt)
            {
                // resolve any default parameters
                foreach (var ctor in dt.Ctors)
                {
                    scope.PushMarker();
                    scope.AllowInstance = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(23L, false);
                    ctor.Formals.ForEach(p => scope.Push(p.Name, p));
                    ResolveAttributes(ctor, new ResolutionContext(new NoContext(topd.EnclosingModuleDefinition), MutateCSharp.Schemata407.ReplaceBooleanConstant_3(24L, false)), MutateCSharp.Schemata407.ReplaceBooleanConstant_3(25L, true));
                    ResolveParameterDefaultValues(ctor.Formals, ResolutionContext.FromCodeContext(dt));
                    scope.PopMarker();
                }
            }

            if (topd is TopLevelDeclWithMembers cl)
            {
                ResolveClassMemberBodies(cl);
            }

            // resolve attributes
            scope.PushMarker();
            Contract.Assert(currentClass == null);
            scope.AllowInstance = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(26L, false);
            if (topd is IteratorDecl iter)
            {
                iter.Ins.ForEach(p => scope.Push(p.Name, p));
            }
            ResolveAttributes(topd, new ResolutionContext(new NoContext(topd.EnclosingModuleDefinition), MutateCSharp.Schemata407.ReplaceBooleanConstant_3(27L, false)), MutateCSharp.Schemata407.ReplaceBooleanConstant_3(28L, true));
            scope.PopMarker();
        }

        void EagerAddAssignableConstraint(IToken tok, Type lhs, Type rhs, string errMsgFormat)
        {
            Contract.Requires(tok != null);
            Contract.Requires(lhs != null);
            Contract.Requires(rhs != null);
            Contract.Requires(errMsgFormat != null);
            var lhsNormalized = lhs.Normalize();
            var rhsNormalized = rhs.Normalize();
            if (lhsNormalized is TypeProxy lhsProxy && !(rhsNormalized is TypeProxy))
            {
                Contract.Assert(lhsProxy.T == null); // otherwise, lhs.Normalize() above would have kept on going
                AssignProxyAndHandleItsConstraints(lhsProxy, rhsNormalized, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(29L, true));
            }
            else
            {
                AddAssignableConstraint(tok, lhs, rhs, errMsgFormat);
            }
        }
        public void AddAssignableConstraint(IToken tok, Type lhs, Type rhs, string errMsgFormat)
        {
            Contract.Requires(tok != null);
            Contract.Requires(lhs != null);
            Contract.Requires(rhs != null);
            Contract.Requires(errMsgFormat != null);
            AddXConstraint(tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(30L, "Assignable"), lhs, rhs, errMsgFormat);
        }
        private void AddXConstraint(IToken tok, string constraintName, Type type, string errMsgFormat)
        {
            Contract.Requires(tok != null);
            Contract.Requires(constraintName != null);
            Contract.Requires(type != null);
            Contract.Requires(errMsgFormat != null);
            var types = new Type[] { type };
            AllXConstraints.Add(new XConstraint(tok, constraintName, types, new TypeConstraint.ErrorMsgWithToken(tok, errMsgFormat, types)));
        }
        void AddAssignableConstraint(IToken tok, Type lhs, Type rhs, TypeConstraint.ErrorMsg errMsg)
        {
            Contract.Requires(tok != null);
            Contract.Requires(lhs != null);
            Contract.Requires(rhs != null);
            Contract.Requires(errMsg != null);
            AddXConstraint(tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(31L, "Assignable"), lhs, rhs, errMsg);
        }

        public void AddXConstraint(IToken tok, string constraintName, Type type, TypeConstraint.ErrorMsg errMsg)
        {
            Contract.Requires(tok != null);
            Contract.Requires(constraintName != null);
            Contract.Requires(type != null);
            Contract.Requires(errMsg != null);
            var types = new Type[] { type };
            AllXConstraints.Add(new XConstraint(tok, constraintName, types, errMsg));
        }

        public void AddXConstraint(IToken tok, string constraintName, Type type0, Type type1, string errMsgFormat)
        {
            Contract.Requires(tok != null);
            Contract.Requires(constraintName != null);
            Contract.Requires(type0 != null);
            Contract.Requires(type1 != null);
            Contract.Requires(errMsgFormat != null);
            var types = new Type[] { type0, type1 };
            AllXConstraints.Add(new XConstraint(tok, constraintName, types, new TypeConstraint.ErrorMsgWithToken(tok, errMsgFormat, types)));
        }

        public void AddXConstraint(IToken tok, string constraintName, Type type0, Type type1, TypeConstraint.ErrorMsg errMsg)
        {
            Contract.Requires(tok != null);
            Contract.Requires(constraintName != null);
            Contract.Requires(type0 != null);
            Contract.Requires(type1 != null);
            Contract.Requires(errMsg != null);
            var types = new Type[] { type0, type1 };
            AllXConstraints.Add(new XConstraint(tok, constraintName, types, errMsg));
        }
        private void AddXConstraint(IToken tok, string constraintName, Type type, Expression expr0, Expression expr1, string errMsgFormat)
        {
            Contract.Requires(tok != null);
            Contract.Requires(constraintName != null);
            Contract.Requires(type != null);
            Contract.Requires(expr0 != null);
            Contract.Requires(expr1 != null);
            Contract.Requires(errMsgFormat != null);
            var types = new Type[] { type };
            var exprs = new Expression[] { expr0, expr1 };
            AllXConstraints.Add(new XConstraintWithExprs(tok, constraintName, types, exprs, new TypeConstraint.ErrorMsgWithToken(tok, errMsgFormat, types)));
        }

        [System.Diagnostics.Conditional("TI_DEBUG_PRINT")]
        void PrintTypeConstraintState(int lbl)
        {
            if (!Options.Get(CommonOptionBag.TypeInferenceDebug))
            {
                return;
            }
            Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(32L, "DEBUG: ---------- type constraints ---------- {0} {1}"), lbl, MutateCSharp.Schemata407.ReplaceBinExprOp_9(43L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_7(37L, lbl, MutateCSharp.Schemata407.ReplaceNumericConstant_6(33L, 0)), () => MutateCSharp.Schemata407.ReplaceBinExprOp_8(42L, currentMethod, null)) ? currentMethod.Name : "");
            foreach (var constraint in AllTypeConstraints)
            {
                var super = constraint.Super.Normalize();
                var sub = constraint.Sub.Normalize();
                Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(49L, "    {0} :> {1}"), super is IntVarietiesSupertype ? MutateCSharp.Schemata407.ReplaceStringConstant_1(50L, "int-like") : super is RealVarietiesSupertype ? MutateCSharp.Schemata407.ReplaceStringConstant_1(51L, "real-like") : super.ToString(), sub);
            }
            foreach (var xc in AllXConstraints)
            {
                Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(52L, "    {0}"), xc);
            }
            Options.OutputWriter.WriteLine();
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(70L, MutateCSharp.Schemata407.ReplaceBinExprOp_10(57L, lbl, MutateCSharp.Schemata407.ReplaceNumericConstant_6(53L, 2)), MutateCSharp.Schemata407.ReplaceNumericConstant_6(66L, 1)))
            {
                Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(75L, "DEBUG: --------------------------------------"));
            }
        }

        /// <summary>
        /// Attempts to fully solve all type constraints.
        /// Upon failure, reports errors.
        /// Clears all constraints.
        /// </summary>
        public void SolveAllTypeConstraints()
        {
            PrintTypeConstraintState(MutateCSharp.Schemata407.ReplaceNumericConstant_6(76L, 0));
            PartiallySolveTypeConstraints(MutateCSharp.Schemata407.ReplaceBooleanConstant_3(80L, true));
            PrintTypeConstraintState(MutateCSharp.Schemata407.ReplaceNumericConstant_6(81L, 1));
            foreach (var constraint in AllTypeConstraints)
            {
                if (Type.IsSupertype(constraint.Super, constraint.Sub))
                {
                    // unexpected condition -- PartiallySolveTypeConstraints is supposed to have continued until no more sub-typing constraints can be satisfied
                    Contract.Assume(false, string.Format("DEBUG: Unexpectedly satisfied supertype relation ({0} :> {1}) |||| ", constraint.Super, constraint.Sub));
                }
                else
                {
                    constraint.FlagAsError(this);
                }
            }
            foreach (var xc in AllXConstraints)
            {
                if (xc.Confirm(this, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(85L, true), out var convertedIntoOtherTypeConstraints, out var moreXConstraints))
                {
                    // unexpected condition -- PartiallySolveTypeConstraints is supposed to have continued until no more XConstraints were confirmable
                    Contract.Assume(false, string.Format("DEBUG: Unexpectedly confirmed XConstraint: {0} |||| ", xc));
                }
                else if (xc.CouldBeAnything())
                {
                    // suppress the error message; it will later be flagged as an underspecified type
                }
                else
                {
                    xc.errorMsg.FlagAsError(this);
                }
            }
            TypeConstraint.ReportErrors(this, reporter);
            AllTypeConstraints.Clear();
            AllXConstraints.Clear();
        }

        /// <summary>
        /// Adds type constraints for the expressions in the given attributes.
        ///
        /// If "solveConstraints" is "true", then the constraints are also solved. In this case, it is assumed on entry that there are no
        /// prior type constraints. That is, the only type constraints being solved for are the ones in the given attributes.
        /// </summary>
        public void ResolveAttributes(IAttributeBearingDeclaration attributeHost, ResolutionContext resolutionContext, bool solveConstraints = false)
        {
            Contract.Requires(resolutionContext != null);
            Contract.Requires(attributeHost != null);

            Contract.Assume(!solveConstraints || AllTypeConstraints.Count == 0);

            // order does not matter much for resolution, so resolve them in reverse order
            foreach (var attr in attributeHost.Attributes.AsEnumerable())
            {
                if (attr is UserSuppliedAttributes)
                {
                    var usa = (UserSuppliedAttributes)attr;
                    usa.Recognized = IsRecognizedAttribute(usa, attributeHost);
                }
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_11(86L, attr.Args, null))
                {
                    foreach (var arg in attr.Args)
                    {
                        Contract.Assert(arg != null);
                        if (!(MutateCSharp.Schemata407.ReplaceBinExprOp_9(94L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_9(88L, () => Attributes.Contains(attributeHost.Attributes, MutateCSharp.Schemata407.ReplaceStringConstant_1(87L, "opaque_reveal")), () => attr.Name is "revealedFunction"), () => arg is NameSegment)))
                        {
                            ResolveExpression(arg, resolutionContext);
                        }
                        else
                        {
                            ResolveRevealLemmaAttribute(arg);
                        }
                    }
                }
            }

            if (solveConstraints)
            {
                SolveAllTypeConstraints();
            }
        }

        // <summary>
        // Manually resolving NameSegments that are present in fuel attributes of reveal lemmas.
        // This is because reveal lemmas are static and we want to allow a reference to non-static original procedures
        // in static context in this setting.
        //
        // Most of the following code is copied from AnnotateRevealFunction() in OpaqueMemberRewriter.cs.
        // </summary>
        public void ResolveRevealLemmaAttribute(Expression arg)
        {
            MemberDecl member = null;
            var ret = GetClassMembers(currentClass).TryGetValue(((NameSegment)arg).Name, out member);
            Contract.Assert(ret);

            var f = (Function)member;
            Expression receiver;
            if (f.IsStatic)
            {
                receiver = new StaticReceiverExpr(f.tok, (TopLevelDeclWithMembers)f.EnclosingClass, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(100L, true));
            }
            else
            {
                receiver = new ImplicitThisExpr(f.tok);
                receiver.Type = GetThisType(f.tok, (TopLevelDeclWithMembers)member.EnclosingClass);
            }

            var typeApplication = new List<Type>();
            var typeApplication_JustForMember = new List<Type>();
            for (int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(101L, 0); MutateCSharp.Schemata407.ReplaceBinExprOp_12(105L, i, f.TypeArgs.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(110L, ref i))
            {
                // doesn't matter what type, just so we have it to make the resolver happy when resolving function member of
                // the fuel attribute. This might not be needed after fixing codeplex issue #172.
                typeApplication.Add(new IntType());
                typeApplication_JustForMember.Add(new IntType());
            }

            var rr = new MemberSelectExpr(f.tok, receiver, f.Name);
            rr.Member = f;
            rr.TypeApplication_AtEnclosingClass = typeApplication;
            rr.TypeApplication_JustMember = typeApplication_JustForMember;
            List<Type> args = new List<Type>();
            for (int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(111L, 0); MutateCSharp.Schemata407.ReplaceBinExprOp_12(115L, i, f.Ins.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(120L, ref i))
            {
                args.Add(new IntType());
            }
            rr.Type = new ArrowType(f.tok, args, new IntType());
            ((NameSegment)arg).ResolvedExpression = rr;
            arg.Type = rr.Type;
        }

        /// <summary>
        /// "IsTwoState" implies that "old" and "fresh" expressions are allowed.
        /// </summary>
        public void ResolveExpression(Expression expr, ResolutionContext resolutionContext)
        {

#if TEST_TYPE_SYNONYM_TRANSPARENCY
      ResolveExpressionX(expr, resolutionContext);
      // For testing purposes, change the type of "expr" to a type synonym (mwo-ha-ha-ha!)
      var t = expr.Type;
      Contract.Assert(t != null);
      var sd = new TypeSynonymDecl(expr.tok, "type#synonym#transparency#test", new TypeParameter.TypeParameterCharacteristics(false),
        new List<TypeParameter>(), resolutionContext.CodeContext.EnclosingModule, t, null);
      var ts = new UserDefinedType(expr.tok, "type#synonym#transparency#test", sd, new List<Type>(), null);
      expr.DebugTest_ChangeType(ts);
    }
    public void ResolveExpressionX(Expression expr, ResolutionContext resolutionContext) {
#endif
            Contract.Requires(expr != null);
            Contract.Requires(resolutionContext != null);
            Contract.Ensures(expr.Type != null);
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_14(121L, expr.Type, null))
            {
                // expression has already been resolved
                return;
            }
            DominatingStatementLabels.PushMarker();

            // The following cases will resolve the subexpressions and will attempt to assign a type of expr.  However, if errors occur
            // and it cannot be determined what the type of expr is, then it is fine to leave expr.Type as null.  In that case, the end
            // of this method will assign proxy type to the expression, which reduces the number of error messages that are produced
            // while type checking the rest of the program.

            if (expr is ParensExpression)
            {
                var e = (ParensExpression)expr;
                ResolveExpression(e.E, resolutionContext);
                var innerRange = e.E.RangeToken;
                e.ResolvedExpression = e.E; // Overwrites the range, which is not suitable for ParensExpressions
                e.E.RangeToken = innerRange;
                e.Type = e.E.Type;

            }
            else if (expr is ChainingExpression)
            {
                var e = (ChainingExpression)expr;
                ResolveExpression(e.E, resolutionContext);
                e.ResolvedExpression = e.E;
                e.Type = e.E.Type;

            }
            else if (expr is NegationExpression)
            {
                var e = (NegationExpression)expr;
                ResolveExpression(e.E, resolutionContext);
                e.Type = e.E.Type;
                AddXConstraint(e.E.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(122L, "NumericOrBitvector"), e.E.Type, MutateCSharp.Schemata407.ReplaceStringConstant_1(123L, "the argument of a unary minus must have numeric or bitvector type (instead got {0})"));
                // Note, e.ResolvedExpression will be filled in during CheckTypeInference, at which time e.Type has been determined

            }
            else if (expr is LiteralExpr)
            {
                LiteralExpr e = (LiteralExpr)expr;

                if (e is StaticReceiverExpr)
                {
                    StaticReceiverExpr eStatic = (StaticReceiverExpr)e;
                    ResolveType(eStatic.tok, eStatic.UnresolvedType, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                    eStatic.Type = eStatic.UnresolvedType;
                }
                else
                {
                    if (e.Value == null)
                    {
                        e.Type = new InferredTypeProxy();
                        AddXConstraint(e.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(124L, "IsNullableRefType"), e.Type, MutateCSharp.Schemata407.ReplaceStringConstant_1(125L, "type of 'null' is a reference type, but it is used as {0}"));
                    }
                    else if (e.Value is BigInteger)
                    {
                        var proxy = new InferredTypeProxy();
                        e.Type = proxy;
                        ConstrainSubtypeRelation(new IntVarietiesSupertype(), e.Type, e.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(126L, "integer literal used as if it had type {0}"), e.Type);
                    }
                    else if (e.Value is BaseTypes.BigDec)
                    {
                        var proxy = new InferredTypeProxy();
                        e.Type = proxy;
                        ConstrainSubtypeRelation(new RealVarietiesSupertype(), e.Type, e.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(127L, "real literal is used as if it had type {0}"), e.Type);
                    }
                    else if (e.Value is bool)
                    {
                        e.Type = Type.Bool;
                    }
                    else if (e is CharLiteralExpr)
                    {
                        e.Type = Type.Char;
                    }
                    else if (e is StringLiteralExpr)
                    {
                        e.Type = Type.String();
                        ResolveType(e.tok, e.Type, resolutionContext, ResolveTypeOptionEnum.DontInfer, null);
                    }
                    else
                    {
                        Contract.Assert(false); throw new cce.UnreachableException();  // unexpected literal type
                    }
                }
            }
            else if (expr is ThisExpr)
            {
                if (!scope.AllowInstance)
                {
                    reporter.Error(MessageSource.Resolver, expr, MutateCSharp.Schemata407.ReplaceStringConstant_1(128L, "'this' is not allowed in a 'static' context"));
                }
                if (currentClass is DefaultClassDecl)
                {
                    // there's no type
                }
                else
                {
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_15(129L, currentClass, null))
                    {
                        Contract.Assert(reporter.HasErrors);
                    }
                    else
                    {
                        expr.Type = GetThisType(expr.tok, currentClass);  // do this regardless of scope.AllowInstance, for better error reporting
                    }
                }

            }
            else if (expr is IdentifierExpr)
            {
                var e = (IdentifierExpr)expr;
                e.Var = scope.Find(e.Name);
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_16(130L, e.Var, null))
                {
                    expr.Type = e.Var.Type;
                }
                else
                {
                    reporter.Error(MessageSource.Resolver, expr, MutateCSharp.Schemata407.ReplaceStringConstant_1(131L, "Identifier does not denote a local variable, parameter, or bound variable: {0}"), e.Name);
                }

            }
            else if (expr is DatatypeValue)
            {
                DatatypeValue dtv = (DatatypeValue)expr;
                if (!moduleInfo.TopLevels.TryGetValue(dtv.DatatypeName, out var d))
                {
                    reporter.Error(MessageSource.Resolver, expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(132L, "Undeclared datatype: {0}"), dtv.DatatypeName);
                }
                else if (d is AmbiguousTopLevelDecl)
                {
                    var ad = (AmbiguousTopLevelDecl)d;
                    reporter.Error(MessageSource.Resolver, expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(133L, "The name {0} ambiguously refers to a type in one of the modules {1} (try qualifying the type name with the module name)"), dtv.DatatypeName, ad.ModuleNames());
                }
                else if (!(d is DatatypeDecl))
                {
                    reporter.Error(MessageSource.Resolver, expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(134L, "Expected datatype: {0}"), dtv.DatatypeName);
                }
                else
                {
                    ResolveDatatypeValue(resolutionContext, dtv, (DatatypeDecl)d, null);
                }

            }
            else if (expr is DisplayExpression)
            {
                DisplayExpression e = (DisplayExpression)expr;
                Type elementType = new InferredTypeProxy() { KeepConstraints = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(135L, true) };
                foreach (Expression ee in e.Elements)
                {
                    ResolveExpression(ee, resolutionContext);
                    Contract.Assert(ee.Type != null);  // follows from postcondition of ResolveExpression
                    ConstrainSubtypeRelation(elementType, ee.Type, ee.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(136L, "All elements of display must have some common supertype (got {0}, but needed type or type of previous elements is {1})"), ee.Type, elementType);
                }
                if (expr is SetDisplayExpr)
                {
                    var se = (SetDisplayExpr)expr;
                    expr.Type = new SetType(se.Finite, elementType);
                }
                else if (expr is MultiSetDisplayExpr)
                {
                    expr.Type = new MultiSetType(elementType);
                }
                else
                {
                    expr.Type = new SeqType(elementType);
                }
            }
            else if (expr is MapDisplayExpr)
            {
                MapDisplayExpr e = (MapDisplayExpr)expr;
                Type domainType = new InferredTypeProxy();
                Type rangeType = new InferredTypeProxy();
                foreach (ExpressionPair p in e.Elements)
                {
                    ResolveExpression(p.A, resolutionContext);
                    Contract.Assert(p.A.Type != null);  // follows from postcondition of ResolveExpression
                    ConstrainSubtypeRelation(domainType, p.A.Type, p.A.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(137L, "All domain elements of map display must have some common supertype (got {0}, but needed type or type of previous elements is {1})"), p.A.Type, domainType);
                    ResolveExpression(p.B, resolutionContext);
                    Contract.Assert(p.B.Type != null);  // follows from postcondition of ResolveExpression
                    ConstrainSubtypeRelation(rangeType, p.B.Type, p.B.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(138L, "All range elements of map display must have some common supertype (got {0}, but needed type or type of previous elements is {1})"), p.B.Type, rangeType);
                }
                expr.Type = new MapType(e.Finite, domainType, rangeType);
            }
            else if (expr is NameSegment)
            {
                var e = (NameSegment)expr;
                ResolveNameSegment(e, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(139L, true), null, resolutionContext, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(140L, false));

                if (e.Type is Resolver_IdentifierExpr.ResolverType_Module)
                {
                    reporter.Error(MessageSource.Resolver, e.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(141L, "name of module ({0}) is used as a variable"), e.Name);
                    e.ResetTypeAssignment();  // the rest of type checking assumes actual types
                }
                else if (e.Type is Resolver_IdentifierExpr.ResolverType_Type)
                {
                    reporter.Error(MessageSource.Resolver, e.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(142L, "name of type ({0}) is used as a variable"), e.Name);
                    e.ResetTypeAssignment();  // the rest of type checking assumes actual types
                }

            }
            else if (expr is ExprDotName)
            {
                var e = (ExprDotName)expr;
                ResolveDotSuffix(e, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(143L, true), null, resolutionContext, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(144L, false));
                if (e.Type is Resolver_IdentifierExpr.ResolverType_Module)
                {
                    reporter.Error(MessageSource.Resolver, e.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(145L, "name of module ({0}) is used as a variable"), e.SuffixName);
                    e.ResetTypeAssignment();  // the rest of type checking assumes actual types
                }
                else if (e.Type is Resolver_IdentifierExpr.ResolverType_Type)
                {
                    reporter.Error(MessageSource.Resolver, e.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(146L, "name of type ({0}) is used as a variable"), e.SuffixName);
                    e.ResetTypeAssignment();  // the rest of type checking assumes actual types
                }

            }
            else if (expr is ApplySuffix)
            {
                var e = (ApplySuffix)expr;
                ResolveApplySuffix(e, resolutionContext, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(147L, false));

            }
            else if (expr is MemberSelectExpr)
            {
                var e = (MemberSelectExpr)expr;
                ResolveExpression(e.Obj, resolutionContext);
                Contract.Assert(e.Obj.Type != null);  // follows from postcondition of ResolveExpression
                var member = ResolveMember(expr.tok, e.Obj.Type, e.MemberName, out var tentativeReceiverType);
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_17(148L, member, null))
                {
                    // error has already been reported by ResolveMember
                }
                else if (member is Function)
                {
                    var fn = member as Function;
                    e.Member = fn;
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(149L, () => fn is TwoStateFunction, () => !resolutionContext.IsTwoState))
                    {
                        reporter.Error(MessageSource.Resolver, e.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(155L, "a two-state function can be used only in a two-state context"));
                    }
                    // build the type substitution map
                    e.TypeApplication_AtEnclosingClass = tentativeReceiverType.TypeArgs;
                    e.TypeApplication_JustMember = new List<Type>();
                    Dictionary<TypeParameter, Type> subst;
                    var ctype = tentativeReceiverType as UserDefinedType;
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_18(156L, ctype, null))
                    {
                        subst = new Dictionary<TypeParameter, Type>();
                    }
                    else
                    {
                        subst = TypeParameter.SubstitutionMap(ctype.ResolvedClass.TypeArgs, ctype.TypeArgs);
                    }
                    foreach (var tp in fn.TypeArgs)
                    {
                        Type prox = new InferredTypeProxy();
                        subst[tp] = prox;
                        e.TypeApplication_JustMember.Add(prox);
                    }
                    subst = BuildTypeArgumentSubstitute(subst);
                    e.Type = SelectAppropriateArrowTypeForFunction(fn, subst, SystemModuleManager);
                }
                else if (member is Field)
                {
                    var field = (Field)member;
                    e.Member = field;
                    e.TypeApplication_AtEnclosingClass = tentativeReceiverType.TypeArgs;
                    e.TypeApplication_JustMember = new List<Type>();
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(157L, () => e.Obj is StaticReceiverExpr, () => !field.IsStatic))
                    {
                        reporter.Error(MessageSource.Resolver, expr, MutateCSharp.Schemata407.ReplaceStringConstant_1(163L, "a field must be selected via an object, not just a class name"));
                    }
                    var ctype = tentativeReceiverType as UserDefinedType;
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_18(164L, ctype, null))
                    {
                        e.Type = field.Type;
                    }
                    else
                    {
                        Contract.Assert(ctype.ResolvedClass != null); // follows from postcondition of ResolveMember
                                                                      // build the type substitution map
                        var subst = TypeParameter.SubstitutionMap(ctype.ResolvedClass.TypeArgs, ctype.TypeArgs);
                        e.Type = field.Type.Subst(subst);
                    }
                }
                else
                {
                    reporter.Error(MessageSource.Resolver, expr, MutateCSharp.Schemata407.ReplaceStringConstant_1(165L, "member {0} in type {1} does not refer to a field or a function"), e.MemberName, tentativeReceiverType);
                }

            }
            else if (expr is SeqSelectExpr)
            {
                SeqSelectExpr e = (SeqSelectExpr)expr;
                ResolveSeqSelectExpr(e, resolutionContext);

            }
            else if (expr is MultiSelectExpr)
            {
                MultiSelectExpr e = (MultiSelectExpr)expr;

                ResolveExpression(e.Array, resolutionContext);
                Contract.Assert(e.Array.Type != null);  // follows from postcondition of ResolveExpression
                Contract.Assert(e.Array.Type.TypeArgs != null);  // if it is null, should make a 1-element list with a Proxy
                Type elementType = MutateCSharp.Schemata407.ReplaceBinExprOp_19(170L, e.Array.Type.TypeArgs.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(166L, 0)) ?
                  e.Array.Type.TypeArgs[MutateCSharp.Schemata407.ReplaceNumericConstant_6(175L, 0)] :
                  new InferredTypeProxy();
                ConstrainSubtypeRelation(ResolvedArrayType(e.Array.tok, e.Indices.Count, elementType, resolutionContext, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(179L, true)), e.Array.Type, e.Array,
        MutateCSharp.Schemata407.ReplaceStringConstant_1(180L, "array selection requires an array{0} (got {1})"), e.Indices.Count, e.Array.Type);
                int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(181L, 0);
                foreach (Expression idx in e.Indices)
                {
                    Contract.Assert(idx != null);
                    ResolveExpression(idx, resolutionContext);
                    Contract.Assert(idx.Type != null);  // follows from postcondition of ResolveExpression
                    ConstrainToIntegerType(idx, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(185L, true), MutateCSharp.Schemata407.ReplaceStringConstant_1(186L, "array selection requires integer- or bitvector-based numeric indices (got {0} for index ") + i + MutateCSharp.Schemata407.ReplaceStringConstant_1(187L, ")"));
                    MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(188L, ref i);
                }
                e.Type = elementType;

            }
            else if (expr is SeqUpdateExpr)
            {
                SeqUpdateExpr e = (SeqUpdateExpr)expr;
                ResolveExpression(e.Seq, resolutionContext);
                Contract.Assert(e.Seq.Type != null);  // follows from postcondition of ResolveExpression
                ResolveExpression(e.Index, resolutionContext);
                ResolveExpression(e.Value, resolutionContext);
                AddXConstraint(expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(189L, "SeqUpdatable"), e.Seq.Type, e.Index, e.Value, MutateCSharp.Schemata407.ReplaceStringConstant_1(190L, "update requires a sequence, map, or multiset (got {0})"));
                expr.Type = new InferredTypeProxy(); // drop type constraints
                ConstrainSubtypeRelation(
                  super: expr.Type, sub: e.Seq.Type, // expr.Type generalizes e.Seq.Type by dropping constraints
                  exprForToken: expr,
                  msg: MutateCSharp.Schemata407.ReplaceStringConstant_1(191L, "Update expression used with type '{0}'"), e.Seq.Type);
            }
            else if (expr is DatatypeUpdateExpr)
            {
                var e = (DatatypeUpdateExpr)expr;
                ResolveExpression(e.Root, resolutionContext);
                var ty = PartiallyResolveTypeForMemberSelection(expr.tok, e.Root.Type);
                if (!ty.IsDatatype)
                {
                    reporter.Error(MessageSource.Resolver, expr, MutateCSharp.Schemata407.ReplaceStringConstant_1(192L, "datatype update expression requires a root expression of a datatype (got {0})"), ty);
                }
                else
                {
                    var (ghostLet, compiledLet) = ResolveDatatypeUpdate(expr.tok, e.Root, ty.AsDatatype, e.Updates, resolutionContext,
                      out var members, out var legalSourceConstructors);
                    Contract.Assert((ghostLet == null) == (compiledLet == null));
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_4(193L, ghostLet, null))
                    {
                        e.ResolvedExpression = ghostLet; // this might be replaced by e.ResolvedCompiledExpression in CheckIsCompilable
                        e.ResolvedCompiledExpression = compiledLet;
                        e.Members = members;
                        e.LegalSourceConstructors = legalSourceConstructors;
                        expr.Type = ghostLet.Type;
                    }
                }

            }
            else if (expr is FunctionCallExpr)
            {
                var e = (FunctionCallExpr)expr;
                ResolveFunctionCallExpr(e, resolutionContext);

            }
            else if (expr is ApplyExpr)
            {
                var e = (ApplyExpr)expr;
                ResolveExpression(e.Function, resolutionContext);
                foreach (var arg in e.Args)
                {
                    ResolveExpression(arg, resolutionContext);
                }

                // TODO: the following should be replaced by a type-class constraint that constrains the types of e.Function, e.Args[*], and e.Type
                var fnType = e.Function.Type.AsArrowType;
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_20(194L, fnType, null))
                {
                    reporter.Error(MessageSource.Resolver, e.tok,
          MutateCSharp.Schemata407.ReplaceStringConstant_1(195L, "non-function expression (of type {0}) is called with parameters"), e.Function.Type);
                }
                else if (MutateCSharp.Schemata407.ReplaceBinExprOp_21(196L, fnType.Arity, e.Args.Count))
                {
                    reporter.Error(MessageSource.Resolver, e.tok,
          MutateCSharp.Schemata407.ReplaceStringConstant_1(201L, "wrong number of arguments for function application (function type '{0}' expects {1}, got {2})"), fnType,
                      fnType.Arity, e.Args.Count);
                }
                else
                {
                    for (var i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(202L, 0); MutateCSharp.Schemata407.ReplaceBinExprOp_12(206L, i, fnType.Arity); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(211L, ref i))
                    {
                        AddAssignableConstraint(e.Args[i].tok, fnType.Args[i], e.Args[i].Type,
            MutateCSharp.Schemata407.ReplaceStringConstant_1(212L, "type mismatch for argument") + (MutateCSharp.Schemata407.ReplaceBinExprOp_7(217L, fnType.Arity, MutateCSharp.Schemata407.ReplaceNumericConstant_6(213L, 1)) ? "" : MutateCSharp.Schemata407.ReplaceStringConstant_1(222L, " ") + i) + MutateCSharp.Schemata407.ReplaceStringConstant_1(223L, " (function expects {0}, got {1})"));
                    }
                }

                expr.Type = MutateCSharp.Schemata407.ReplaceBinExprOp_20(224L, fnType, null) ? new InferredTypeProxy() : fnType.Result;

            }
            else if (expr is SeqConstructionExpr)
            {
                var e = (SeqConstructionExpr)expr;
                var elementType = e.ExplicitElementType ?? new InferredTypeProxy();
                ResolveType(e.tok, elementType, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                ResolveExpression(e.N, resolutionContext);
                ConstrainToIntegerType(e.N, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(225L, false), MutateCSharp.Schemata407.ReplaceStringConstant_1(226L, "sequence construction must use an integer-based expression for the sequence size (got {0})"));
                ResolveExpression(e.Initializer, resolutionContext);
                var arrowType = new ArrowType(e.tok, SystemModuleManager.ArrowTypeDecls[MutateCSharp.Schemata407.ReplaceNumericConstant_6(227L, 1)], new List<Type>() { SystemModuleManager.Nat() }, elementType);
                var hintString = MutateCSharp.Schemata407.ReplaceStringConstant_1(231L, " (perhaps write '_ =>' in front of the expression you gave in order to make it an arrow type)");
                ConstrainSubtypeRelation(arrowType, e.Initializer.Type, e.Initializer, MutateCSharp.Schemata407.ReplaceStringConstant_1(232L, "sequence-construction initializer expression expected to have type '{0}' (instead got '{1}'){2}"),
                  arrowType, e.Initializer.Type, new LazyString_OnTypeEquals(elementType, e.Initializer.Type, hintString));
                expr.Type = new SeqType(elementType);

            }
            else if (expr is MultiSetFormingExpr)
            {
                MultiSetFormingExpr e = (MultiSetFormingExpr)expr;
                ResolveExpression(e.E, resolutionContext);
                var elementType = new InferredTypeProxy();
                AddXConstraint(e.E.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(233L, "MultiSetConvertible"), e.E.Type, elementType, MutateCSharp.Schemata407.ReplaceStringConstant_1(234L, "can only form a multiset from a seq or set (got {0})"));
                expr.Type = new MultiSetType(elementType);

            }
            else if (expr is OldExpr)
            {
                var e = (OldExpr)expr;
                e.AtLabel = ResolveDominatingLabelInExpr(expr.tok, e.At, MutateCSharp.Schemata407.ReplaceStringConstant_1(235L, "old"), resolutionContext);
                ResolveExpression(e.E, new ResolutionContext(resolutionContext.CodeContext, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(236L, false)) with { InOld = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(237L, true) });
                expr.Type = e.E.Type;

            }
            else if (expr is UnchangedExpr)
            {
                var e = (UnchangedExpr)expr;
                e.AtLabel = ResolveDominatingLabelInExpr(expr.tok, e.At, MutateCSharp.Schemata407.ReplaceStringConstant_1(238L, "unchanged"), resolutionContext);
                foreach (var fe in e.Frame)
                {
                    ResolveFrameExpression(fe, FrameExpressionUse.Unchanged, resolutionContext);
                }
                expr.Type = Type.Bool;

            }
            else if (expr is FreshExpr)
            {
                var e = (FreshExpr)expr;
                ResolveExpression(e.E, resolutionContext);
                e.AtLabel = ResolveDominatingLabelInExpr(expr.tok, e.At, MutateCSharp.Schemata407.ReplaceStringConstant_1(239L, "fresh"), resolutionContext);
                // the type of e.E must be either an object or a set/seq of objects
                AddXConstraint(expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(240L, "Freshable"), e.E.Type, MutateCSharp.Schemata407.ReplaceStringConstant_1(241L, "the argument of a fresh expression must denote an object or a set or sequence of objects (instead got {0})"));
                expr.Type = Type.Bool;

            }
            else if (expr is UnaryOpExpr)
            {
                var e = (UnaryOpExpr)expr;
                ResolveExpression(e.E, resolutionContext);
                Contract.Assert(e.E.Type != null);  // follows from postcondition of ResolveExpression
                switch (e.Op)
                {
                    case UnaryOpExpr.Opcode.Not:
                        AddXConstraint(e.E.tok, "BooleanBits", e.E.Type, "logical/bitwise negation expects a boolean or bitvector argument (instead got {0})");
                        expr.Type = e.E.Type;
                        break;
                        break;
                    case UnaryOpExpr.Opcode.Cardinality:
                        AddXConstraint(expr.tok, "Sizeable", e.E.Type, "size operator expects a collection argument (instead got {0})");
                        expr.Type = Type.Int;
                        break;
                        break;
                    case UnaryOpExpr.Opcode.Allocated:
                        // the argument is allowed to have any type at all
                        expr.Type = Type.Bool;
                        if (
                          ((resolutionContext.CodeContext is Function && !resolutionContext.InOld) || resolutionContext.CodeContext is ConstantField || CodeContextWrapper.Unwrap(resolutionContext.CodeContext) is RedirectingTypeDecl))
                        {
                            var declKind = CodeContextWrapper.Unwrap(resolutionContext.CodeContext) is RedirectingTypeDecl redir ? redir.WhatKind : ((MemberDecl)resolutionContext.CodeContext).WhatKind;
                            reporter.Error(MessageSource.Resolver, expr, "a {0} definition is not allowed to depend on the set of allocated references", declKind);
                        }
                        break;
                        break;
                    default:
                        Contract.Assert(false); throw new cce.UnreachableException();  // unexpected unary operator
                        break;
                }

                // We do not have enough information to compute `e.ResolvedOp` yet.
                // For binary operators the computation happens in `CheckTypeInference`.
                // For unary operators it happens lazily in the getter of `e.ResolvedOp`.
            }
            else if (expr is ConversionExpr)
            {
                var e = (ConversionExpr)expr;
                ResolveExpression(e.E, resolutionContext);
                var prevErrorCount = reporter.Count(ErrorLevel.Error);
                ResolveType(e.tok, e.ToType, resolutionContext, new ResolveTypeOption(ResolveTypeOptionEnum.InferTypeProxies), null);
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(242L, reporter.Count(ErrorLevel.Error), prevErrorCount))
                {
                    if (e.ToType.IsNumericBased(Type.NumericPersuasion.Int))
                    {
                        AddXConstraint(expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(247L, "NumericOrBitvectorOrCharOrORDINAL"), e.E.Type, MutateCSharp.Schemata407.ReplaceStringConstant_1(248L, "type conversion to an int-based type is allowed only from numeric and bitvector types, char, and ORDINAL (got {0})"));
                    }
                    else if (e.ToType.IsNumericBased(Type.NumericPersuasion.Real))
                    {
                        AddXConstraint(expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(249L, "NumericOrBitvectorOrCharOrORDINAL"), e.E.Type, MutateCSharp.Schemata407.ReplaceStringConstant_1(250L, "type conversion to a real-based type is allowed only from numeric and bitvector types, char, and ORDINAL (got {0})"));
                    }
                    else if (e.ToType.IsBitVectorType)
                    {
                        AddXConstraint(expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(251L, "NumericOrBitvectorOrCharOrORDINAL"), e.E.Type, MutateCSharp.Schemata407.ReplaceStringConstant_1(252L, "type conversion to a bitvector-based type is allowed only from numeric and bitvector types, char, and ORDINAL (got {0})"));
                    }
                    else if (e.ToType.IsCharType)
                    {
                        AddXConstraint(expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(253L, "NumericOrBitvectorOrCharOrORDINAL"), e.E.Type, MutateCSharp.Schemata407.ReplaceStringConstant_1(254L, "type conversion to a char type is allowed only from numeric and bitvector types, char, and ORDINAL (got {0})"));
                    }
                    else if (e.ToType.IsBigOrdinalType)
                    {
                        AddXConstraint(expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(255L, "NumericOrBitvectorOrCharOrORDINAL"), e.E.Type, MutateCSharp.Schemata407.ReplaceStringConstant_1(256L, "type conversion to an ORDINAL type is allowed only from numeric and bitvector types, char, and ORDINAL (got {0})"));
                    }
                    else if (e.ToType.IsRefType)
                    {
                        AddAssignableConstraint(expr.tok, e.ToType, e.E.Type, MutateCSharp.Schemata407.ReplaceStringConstant_1(257L, "type cast to reference type '{0}' must be from an expression assignable to it (got '{1}')"));
                    }
                    else if (e.ToType.IsTraitType)
                    {
                        AddAssignableConstraint(expr.tok, e.ToType, e.E.Type, MutateCSharp.Schemata407.ReplaceStringConstant_1(258L, "type cast to trait type '{0}' must be from an expression assignable to it (got '{1}')"));
                    }
                    else
                    {
                        reporter.Error(MessageSource.Resolver, expr, MutateCSharp.Schemata407.ReplaceStringConstant_1(259L, "type conversions are not supported to this type (got {0})"), e.ToType);
                    }
                    e.Type = e.ToType;
                }
                else
                {
                    e.Type = new InferredTypeProxy();
                }

            }
            else if (expr is TypeTestExpr)
            {
                var e = (TypeTestExpr)expr;
                ResolveExpression(e.E, resolutionContext);
                var prevErrorCount = reporter.Count(ErrorLevel.Error);
                ResolveType(e.tok, e.ToType, resolutionContext, new ResolveTypeOption(ResolveTypeOptionEnum.InferTypeProxies), null);
                AddAssignableConstraint(expr.tok, e.ToType, e.E.Type, MutateCSharp.Schemata407.ReplaceStringConstant_1(260L, "type test for type '{0}' must be from an expression assignable to it (got '{1}')"));
                e.Type = Type.Bool;

            }
            else if (expr is BinaryExpr)
            {

                BinaryExpr e = (BinaryExpr)expr;
                ResolveExpression(e.E0, resolutionContext);
                Contract.Assert(e.E0.Type != null);  // follows from postcondition of ResolveExpression
                ResolveExpression(e.E1, resolutionContext);
                Contract.Assert(e.E1.Type != null);  // follows from postcondition of ResolveExpression

                switch (e.Op)
                {
                    case BinaryExpr.Opcode.Iff:
                    case BinaryExpr.Opcode.Imp:
                    case BinaryExpr.Opcode.Exp:
                    case BinaryExpr.Opcode.And:
                    case BinaryExpr.Opcode.Or:
                        {
                            ConstrainSubtypeRelation(Type.Bool, e.E0.Type, expr, "first argument to {0} must be of type bool (instead got {1})", BinaryExpr.OpcodeString(e.Op), e.E0.Type);
                            var secondArgumentDescription = e.E1.tok is QuantifiedVariableRangeToken
                              ? "range of quantified variable" : "second argument to {0}";
                            ConstrainSubtypeRelation(Type.Bool, e.E1.Type, expr, secondArgumentDescription + " must be of type bool (instead got {1})", BinaryExpr.OpcodeString(e.Op), e.E1.Type);
                            expr.Type = Type.Bool;
                            break;
                        }

                        break;
                    case BinaryExpr.Opcode.Eq:
                    case BinaryExpr.Opcode.Neq:
                        AddXConstraint(expr.tok, "Equatable", e.E0.Type, e.E1.Type, "arguments must have comparable types (got {0} and {1})");
                        expr.Type = Type.Bool;
                        break;
                        break;
                    case BinaryExpr.Opcode.Disjoint:
                        Type disjointArgumentsType = new InferredTypeProxy();
                        ConstrainSubtypeRelation(disjointArgumentsType, e.E0.Type, expr, "arguments to {2} must have a common supertype (got {0} and {1})", e.E0.Type, e.E1.Type, BinaryExpr.OpcodeString(e.Op));
                        ConstrainSubtypeRelation(disjointArgumentsType, e.E1.Type, expr, "arguments to {2} must have a common supertype (got {0} and {1})", e.E0.Type, e.E1.Type, BinaryExpr.OpcodeString(e.Op));
                        AddXConstraint(expr.tok, "Disjointable", disjointArgumentsType, "arguments must be of a set or multiset type (got {0})");
                        expr.Type = Type.Bool;
                        break;
                        break;
                    case BinaryExpr.Opcode.Lt:
                    case BinaryExpr.Opcode.Le:
                        {
                            if (e.Op == BinaryExpr.Opcode.Lt && (PartiallyResolveTypeForMemberSelection(e.E0.tok, e.E0.Type).IsIndDatatype || e.E0.Type.IsTypeParameter || PartiallyResolveTypeForMemberSelection(e.E1.tok, e.E1.Type).IsIndDatatype))
                            {
                                AddXConstraint(expr.tok, "RankOrderable", e.E0.Type, e.E1.Type, "arguments to rank comparison must be datatypes (got {0} and {1})");
                                e.ResolvedOp = BinaryExpr.ResolvedOpcode.RankLt;
                            }
                            else
                            {
                                var cmpType = new InferredTypeProxy();
                                var err = new TypeConstraint.ErrorMsgWithToken(expr.tok, "arguments to {2} must have a common supertype (got {0} and {1})", e.E0.Type, e.E1.Type, BinaryExpr.OpcodeString(e.Op));
                                ConstrainSubtypeRelation(cmpType, e.E0.Type, err);
                                ConstrainSubtypeRelation(cmpType, e.E1.Type, err);
                                AddXConstraint(expr.tok, "Orderable_Lt", e.E0.Type, e.E1.Type,
                                  "arguments to " + BinaryExpr.OpcodeString(e.Op) + " must be of a numeric type, bitvector type, ORDINAL, char, a sequence type, or a set-like type (instead got {0} and {1})");
                            }
                            expr.Type = Type.Bool;
                        }
                        break;
                        break;
                    case BinaryExpr.Opcode.Gt:
                    case BinaryExpr.Opcode.Ge:
                        {
                            if (e.Op == BinaryExpr.Opcode.Gt && (PartiallyResolveTypeForMemberSelection(e.E0.tok, e.E0.Type).IsIndDatatype || PartiallyResolveTypeForMemberSelection(e.E1.tok, e.E1.Type).IsIndDatatype || e.E1.Type.IsTypeParameter))
                            {
                                AddXConstraint(expr.tok, "RankOrderable", e.E1.Type, e.E0.Type, "arguments to rank comparison must be datatypes (got {1} and {0})");
                                e.ResolvedOp = BinaryExpr.ResolvedOpcode.RankGt;
                            }
                            else
                            {
                                var cmpType = new InferredTypeProxy();
                                var err = new TypeConstraint.ErrorMsgWithToken(expr.tok, "arguments to {2} must have a common supertype (got {0} and {1})", e.E0.Type, e.E1.Type, BinaryExpr.OpcodeString(e.Op));
                                ConstrainSubtypeRelation(cmpType, e.E0.Type, err);
                                ConstrainSubtypeRelation(cmpType, e.E1.Type, err);
                                AddXConstraint(expr.tok, "Orderable_Gt", e.E0.Type, e.E1.Type,
                                  "arguments to " + BinaryExpr.OpcodeString(e.Op) + " must be of a numeric type, bitvector type, ORDINAL, char, or a set-like type (instead got {0} and {1})");
                            }
                            expr.Type = Type.Bool;
                        }
                        break;
                        break;
                    case BinaryExpr.Opcode.LeftShift:
                    case BinaryExpr.Opcode.RightShift:
                        {
                            expr.Type = new InferredTypeProxy();
                            AddXConstraint(e.tok, "IsBitvector", expr.Type, "type of " + BinaryExpr.OpcodeString(e.Op) + " must be a bitvector type (instead got {0})");
                            ConstrainSubtypeRelation(expr.Type, e.E0.Type, expr.tok, "type of left argument to " + BinaryExpr.OpcodeString(e.Op) + " ({0}) must agree with the result type ({1})", e.E0.Type, expr.Type);
                            AddXConstraint(expr.tok, "IntLikeOrBitvector", e.E1.Type, "type of right argument to " + BinaryExpr.OpcodeString(e.Op) + " ({0}) must be an integer-numeric or bitvector type");
                        }
                        break;
                        break;
                    case BinaryExpr.Opcode.Add:
                        {
                            expr.Type = new InferredTypeProxy();
                            AddXConstraint(e.tok, "Plussable", expr.Type, "type of + must be of a numeric type, a bitvector type, ORDINAL, char, a sequence type, or a set-like or map-like type (instead got {0})");
                            ConstrainSubtypeRelation(expr.Type, e.E0.Type, expr.tok, "type of left argument to + ({0}) must agree with the result type ({1})", e.E0.Type, expr.Type);
                            ConstrainSubtypeRelation(expr.Type, e.E1.Type, expr.tok, "type of right argument to + ({0}) must agree with the result type ({1})", e.E1.Type, expr.Type);
                        }
                        break;
                        break;
                    case BinaryExpr.Opcode.Sub:
                        {
                            expr.Type = new InferredTypeProxy();
                            AddXConstraint(e.tok, "Minusable", expr.Type, "type of - must be of a numeric type, bitvector type, ORDINAL, char, or a set-like or map-like type (instead got {0})");
                            ConstrainSubtypeRelation(expr.Type, e.E0.Type, expr.tok, "type of left argument to - ({0}) must agree with the result type ({1})", e.E0.Type, expr.Type);
                            // The following handles map subtraction, but does not in an unfortunately restrictive way.
                            // First, it would be nice to delay the decision of it this is a map subtraction or not. This settles
                            // for the simple way to decide based on what is currently known about the result type, which is also
                            // done, for example, when deciding if "<" denotes rank ordering on datatypes.
                            // Second, for map subtraction, it would be nice to allow the right-hand operand to be either a set or
                            // an iset. That would also lead to further complexity in the code, so this code restricts the right-hand
                            // operand to be a set.
                            var eType = PartiallyResolveTypeForMemberSelection(expr.tok, expr.Type).AsMapType;
                            if (eType != null)
                            {
                                // allow "map - set == map"
                                var expected = new SetType(true, eType.Domain);
                                ConstrainSubtypeRelation(expected, e.E1.Type, expr.tok, "map subtraction expects right-hand operand to have type {0} (instead got {1})", expected, e.E1.Type);
                            }
                            else
                            {
                                ConstrainSubtypeRelation(expr.Type, e.E1.Type, expr.tok, "type of right argument to - ({0}) must agree with the result type ({1})", e.E1.Type, expr.Type);
                            }
                        }
                        break;
                        break;
                    case BinaryExpr.Opcode.Mul:
                        {
                            expr.Type = new InferredTypeProxy();
                            AddXConstraint(e.tok, "Mullable", expr.Type, "type of * must be of a numeric type, bitvector type, or a set-like type (instead got {0})");
                            ConstrainSubtypeRelation(expr.Type, e.E0.Type, expr.tok, "type of left argument to * ({0}) must agree with the result type ({1})", e.E0.Type, expr.Type);
                            ConstrainSubtypeRelation(expr.Type, e.E1.Type, expr.tok, "type of right argument to * ({0}) must agree with the result type ({1})", e.E1.Type, expr.Type);
                        }
                        break;
                        break;
                    case BinaryExpr.Opcode.In:
                    case BinaryExpr.Opcode.NotIn:
                        var subjectDescription = e.E1.tok is QuantifiedVariableDomainToken
                          ? "domain of quantified variable" : "second argument to \"" + BinaryExpr.OpcodeString(e.Op) + "\"";
                        AddXConstraint(expr.tok, "Innable", e.E1.Type, e.E0.Type, subjectDescription + " must be a set, multiset, or sequence with elements of type {1}, or a map with domain {1} (instead got {0})");
                        expr.Type = Type.Bool;
                        break;
                        break;
                    case BinaryExpr.Opcode.Div:
                        expr.Type = new InferredTypeProxy();
                        AddXConstraint(expr.tok, "NumericOrBitvector", expr.Type, "arguments to " + BinaryExpr.OpcodeString(e.Op) + " must be numeric or bitvector types (got {0})");
                        ConstrainSubtypeRelation(expr.Type, e.E0.Type,
                          expr, "type of left argument to " + BinaryExpr.OpcodeString(e.Op) + " ({0}) must agree with the result type ({1})",
                          e.E0.Type, expr.Type);
                        ConstrainSubtypeRelation(expr.Type, e.E1.Type,
                          expr, "type of right argument to " + BinaryExpr.OpcodeString(e.Op) + " ({0}) must agree with the result type ({1})",
                          e.E1.Type, expr.Type);
                        break;
                        break;
                    case BinaryExpr.Opcode.Mod:
                        expr.Type = new InferredTypeProxy();
                        AddXConstraint(expr.tok, "IntLikeOrBitvector", expr.Type, "arguments to " + BinaryExpr.OpcodeString(e.Op) + " must be integer-numeric or bitvector types (got {0})");
                        ConstrainSubtypeRelation(expr.Type, e.E0.Type,
                          expr, "type of left argument to " + BinaryExpr.OpcodeString(e.Op) + " ({0}) must agree with the result type ({1})",
                          e.E0.Type, expr.Type);
                        ConstrainSubtypeRelation(expr.Type, e.E1.Type,
                          expr, "type of right argument to " + BinaryExpr.OpcodeString(e.Op) + " ({0}) must agree with the result type ({1})",
                          e.E1.Type, expr.Type);
                        break;
                        break;
                    case BinaryExpr.Opcode.BitwiseAnd:
                    case BinaryExpr.Opcode.BitwiseOr:
                    case BinaryExpr.Opcode.BitwiseXor:
                        expr.Type = NewIntegerBasedProxy(expr.tok);
                        var errFormat = "first argument to " + BinaryExpr.OpcodeString(e.Op) + " must be of a bitvector type (instead got {0})";
                        ConstrainSubtypeRelation(expr.Type, e.E0.Type, expr, errFormat, e.E0.Type);
                        AddXConstraint(expr.tok, "IsBitvector", e.E0.Type, errFormat);
                        errFormat = "second argument to " + BinaryExpr.OpcodeString(e.Op) + " must be of a bitvector type (instead got {0})";
                        ConstrainSubtypeRelation(expr.Type, e.E1.Type, expr, errFormat, e.E1.Type);
                        AddXConstraint(expr.tok, "IsBitvector", e.E1.Type, errFormat);
                        break;
                        break;
                    default:
                        Contract.Assert(false); throw new cce.UnreachableException();  // unexpected operator
                        break;
                }
                // We should also fill in e.ResolvedOp, but we may not have enough information for that yet.  So, instead, delay
                // setting e.ResolvedOp until inside CheckTypeInference.

            }
            else if (expr is TernaryExpr)
            {
                var e = (TernaryExpr)expr;
                ResolveExpression(e.E0, resolutionContext);
                ResolveExpression(e.E1, resolutionContext);
                ResolveExpression(e.E2, resolutionContext);
                switch (e.Op)
                {
                    case TernaryExpr.Opcode.PrefixEqOp:
                    case TernaryExpr.Opcode.PrefixNeqOp:
                        AddXConstraint(expr.tok, "IntOrORDINAL", e.E0.Type, "prefix-equality limit argument must be an ORDINAL or integer expression (got {0})");
                        AddXConstraint(expr.tok, "Equatable", e.E1.Type, e.E2.Type, "arguments must have the same type (got {0} and {1})");
                        AddXConstraint(expr.tok, "IsCoDatatype", e.E1.Type, "arguments to prefix equality must be codatatypes (instead of {0})");
                        expr.Type = Type.Bool;
                        break;
                        break;
                    default:
                        Contract.Assert(false);  // unexpected ternary operator
                        break;
                        break;
                }

            }
            else if (expr is LetExpr)
            {
                var e = (LetExpr)expr;
                if (e.Exact)
                {
                    foreach (var rhs in e.RHSs)
                    {
                        ResolveExpression(rhs, resolutionContext);
                    }
                    scope.PushMarker();
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_21(261L, e.LHSs.Count, e.RHSs.Count))
                    {
                        reporter.Error(MessageSource.Resolver, expr, MutateCSharp.Schemata407.ReplaceStringConstant_1(266L, "let expression must have same number of LHSs (found {0}) as RHSs (found {1})"), e.LHSs.Count, e.RHSs.Count);
                    }
                    var i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(267L, 0);
                    foreach (var lhs in e.LHSs)
                    {
                        var rhsType = MutateCSharp.Schemata407.ReplaceBinExprOp_12(271L, i, e.RHSs.Count) ? e.RHSs[i].Type : new InferredTypeProxy();
                        ResolveCasePattern(lhs, rhsType, resolutionContext);
                        // Check for duplicate names now, because not until after resolving the case pattern do we know if identifiers inside it refer to bound variables or nullary constructors
                        var c = MutateCSharp.Schemata407.ReplaceNumericConstant_6(276L, 0);
                        foreach (var v in lhs.Vars)
                        {
                            ScopePushAndReport(scope, v, MutateCSharp.Schemata407.ReplaceStringConstant_1(280L, "let-variable"));
                            MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(281L, ref c);
                        }
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(286L, c, MutateCSharp.Schemata407.ReplaceNumericConstant_6(282L, 0)))
                        {
                            // Every identifier-looking thing in the pattern resolved to a constructor; that is, this LHS is a constant literal
                            reporter.Error(MessageSource.Resolver, lhs.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(291L, "LHS is a constant literal; to be legal, it must introduce at least one bound variable"));
                        }

                        MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(292L, ref i);
                    }
                }
                else
                {
                    // let-such-that expression
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_21(297L, e.RHSs.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(293L, 1)))
                    {
                        reporter.Error(MessageSource.Resolver, expr, MutateCSharp.Schemata407.ReplaceStringConstant_1(302L, "let-such-that expression must have just one RHS (found {0})"), e.RHSs.Count);
                    }
                    // the bound variables are in scope in the RHS of a let-such-that expression
                    scope.PushMarker();
                    foreach (var lhs in e.LHSs)
                    {
                        Contract.Assert(lhs.Var != null);  // the parser already checked that every LHS is a BoundVar, not a general pattern
                        var v = lhs.Var;
                        ScopePushAndReport(scope, v, MutateCSharp.Schemata407.ReplaceStringConstant_1(303L, "let-variable"));
                        ResolveType(v.tok, v.Type, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                    }
                    foreach (var rhs in e.RHSs)
                    {
                        ResolveExpression(rhs, resolutionContext);
                        ConstrainTypeExprBool(rhs, MutateCSharp.Schemata407.ReplaceStringConstant_1(304L, "type of RHS of let-such-that expression must be boolean (got {0})"));
                    }
                }
                ResolveExpression(e.Body, resolutionContext);
                ResolveAttributes(e, resolutionContext);
                scope.PopMarker();
                expr.Type = e.Body.Type;
            }
            else if (expr is LetOrFailExpr)
            {
                var e = (LetOrFailExpr)expr;
                ResolveLetOrFailExpr(e, resolutionContext);
            }
            else if (expr is QuantifierExpr)
            {
                var e = (QuantifierExpr)expr;
                Contract.Assert(e.SplitQuantifier == null); // No split quantifiers during resolution
                int prevErrorCount = reporter.Count(ErrorLevel.Error);
                scope.PushMarker();
                foreach (BoundVar v in e.BoundVars)
                {
                    ScopePushAndReport(scope, v, MutateCSharp.Schemata407.ReplaceStringConstant_1(305L, "bound-variable"));
                    var option = new ResolveTypeOption(ResolveTypeOptionEnum.InferTypeProxies);
                    ResolveType(v.tok, v.Type, resolutionContext, option, null);
                }
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_4(306L, e.Range, null))
                {
                    ResolveExpression(e.Range, resolutionContext);
                    Contract.Assert(e.Range.Type != null);  // follows from postcondition of ResolveExpression
                    ConstrainTypeExprBool(e.Range, MutateCSharp.Schemata407.ReplaceStringConstant_1(307L, "range of quantifier must be of type bool (instead got {0})"));
                }
                ResolveExpression(e.Term, resolutionContext);
                Contract.Assert(e.Term.Type != null);  // follows from postcondition of ResolveExpression
                ConstrainTypeExprBool(e.Term, MutateCSharp.Schemata407.ReplaceStringConstant_1(308L, "body of quantifier must be of type bool (instead got {0})"));
                // Since the body is more likely to infer the types of the bound variables, resolve it
                // first (above) and only then resolve the attributes (below).
                ResolveAttributes(e, resolutionContext);
                scope.PopMarker();
                expr.Type = Type.Bool;

            }
            else if (expr is SetComprehension)
            {
                var e = (SetComprehension)expr;
                int prevErrorCount = reporter.Count(ErrorLevel.Error);
                scope.PushMarker();
                foreach (BoundVar v in e.BoundVars)
                {
                    ScopePushAndReport(scope, v, MutateCSharp.Schemata407.ReplaceStringConstant_1(309L, "bound-variable"));
                    ResolveType(v.tok, v.Type, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                    var inferredProxy = v.Type as InferredTypeProxy;
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_22(310L, inferredProxy, null))
                    {
                        Contract.Assert(!inferredProxy.KeepConstraints);  // in general, this proxy is inferred to be a base type
                    }
                }
                ResolveExpression(e.Range, resolutionContext);
                Contract.Assert(e.Range.Type != null);  // follows from postcondition of ResolveExpression
                ConstrainTypeExprBool(e.Range, MutateCSharp.Schemata407.ReplaceStringConstant_1(311L, "range of comprehension must be of type bool (instead got {0})"));
                ResolveExpression(e.Term, resolutionContext);
                Contract.Assert(e.Term.Type != null);  // follows from postcondition of ResolveExpression

                ResolveAttributes(e, resolutionContext);
                scope.PopMarker();
                expr.Type = new SetType(e.Finite, e.Term.Type);

            }
            else if (expr is MapComprehension)
            {
                var e = (MapComprehension)expr;
                int prevErrorCount = reporter.Count(ErrorLevel.Error);
                scope.PushMarker();
                Contract.Assert(e.BoundVars.Count == 1 || (1 < e.BoundVars.Count && e.TermLeft != null));
                foreach (BoundVar v in e.BoundVars)
                {
                    ScopePushAndReport(scope, v, MutateCSharp.Schemata407.ReplaceStringConstant_1(312L, "bound-variable"));
                    ResolveType(v.tok, v.Type, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                    var inferredProxy = v.Type as InferredTypeProxy;
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_22(313L, inferredProxy, null))
                    {
                        Contract.Assert(!inferredProxy.KeepConstraints);  // in general, this proxy is inferred to be a base type
                    }
                }
                ResolveExpression(e.Range, resolutionContext);
                Contract.Assert(e.Range.Type != null);  // follows from postcondition of ResolveExpression
                ConstrainTypeExprBool(e.Range, MutateCSharp.Schemata407.ReplaceStringConstant_1(314L, "range of comprehension must be of type bool (instead got {0})"));
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_4(315L, e.TermLeft, null))
                {
                    ResolveExpression(e.TermLeft, resolutionContext);
                    Contract.Assert(e.TermLeft.Type != null);  // follows from postcondition of ResolveExpression
                }
                ResolveExpression(e.Term, resolutionContext);
                Contract.Assert(e.Term.Type != null);  // follows from postcondition of ResolveExpression

                ResolveAttributes(e, resolutionContext);
                scope.PopMarker();
                expr.Type = new MapType(e.Finite, MutateCSharp.Schemata407.ReplaceBinExprOp_4(316L, e.TermLeft, null) ? e.TermLeft.Type : e.BoundVars[MutateCSharp.Schemata407.ReplaceNumericConstant_6(317L, 0)].Type, e.Term.Type);

            }
            else if (expr is LambdaExpr)
            {
                var e = (LambdaExpr)expr;
                int prevErrorCount = reporter.Count(ErrorLevel.Error);
                scope.PushMarker();
                foreach (BoundVar v in e.BoundVars)
                {
                    ScopePushAndReport(scope, v, MutateCSharp.Schemata407.ReplaceStringConstant_1(321L, "bound-variable"));
                    ResolveType(v.tok, v.Type, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                }

                if (MutateCSharp.Schemata407.ReplaceBinExprOp_4(322L, e.Range, null))
                {
                    ResolveExpression(e.Range, resolutionContext);
                    Contract.Assert(e.Range.Type != null);  // follows from postcondition of ResolveExpression
                    ConstrainTypeExprBool(e.Range, MutateCSharp.Schemata407.ReplaceStringConstant_1(323L, "Precondition must be boolean (got {0})"));
                }
                foreach (var read in e.Reads.Expressions)
                {
                    ResolveFrameExpression(read, FrameExpressionUse.Reads, resolutionContext);
                }
                ResolveExpression(e.Term, resolutionContext);
                Contract.Assert(e.Term.Type != null);
                scope.PopMarker();
                expr.Type = SelectAppropriateArrowType(e.tok, e.BoundVars.ConvertAll(v => v.Type), e.Body.Type, MutateCSharp.Schemata407.ReplaceBinExprOp_21(328L, e.Reads.Expressions.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(324L, 0)), MutateCSharp.Schemata407.ReplaceBinExprOp_4(333L, e.Range, null), SystemModuleManager);
            }
            else if (expr is WildcardExpr)
            {
                expr.Type = SystemModuleManager.ObjectSetType();
            }
            else if (expr is StmtExpr)
            {
                var e = (StmtExpr)expr;
                int prevErrorCount = reporter.Count(ErrorLevel.Error);

                ResolveStatement(e.S, resolutionContext);
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(334L, reporter.Count(ErrorLevel.Error), prevErrorCount))
                {
                    var r = e.S as UpdateStmt;
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(349L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_23(339L, r, null), () => MutateCSharp.Schemata407.ReplaceBinExprOp_7(344L, r.ResolvedStatements.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(340L, 1))))
                    {
                        var call = r.ResolvedStatements[MutateCSharp.Schemata407.ReplaceNumericConstant_6(355L, 0)] as CallStmt;
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(359L, () => call.Method is TwoStateLemma, () => !resolutionContext.IsTwoState))
                        {
                            reporter.Error(MessageSource.Resolver, call, MutateCSharp.Schemata407.ReplaceStringConstant_1(365L, "two-state lemmas can only be used in two-state contexts"));
                        }
                    }
                }

                ResolveExpression(e.E, resolutionContext);
                Contract.Assert(e.E.Type != null);  // follows from postcondition of ResolveExpression
                expr.Type = e.E.Type;

            }
            else if (expr is ITEExpr)
            {
                ITEExpr e = (ITEExpr)expr;
                ResolveExpression(e.Test, resolutionContext);
                Contract.Assert(e.Test.Type != null);  // follows from postcondition of ResolveExpression
                ResolveExpression(e.Thn, resolutionContext);
                Contract.Assert(e.Thn.Type != null);  // follows from postcondition of ResolveExpression
                ResolveExpression(e.Els, resolutionContext);
                Contract.Assert(e.Els.Type != null);  // follows from postcondition of ResolveExpression
                ConstrainTypeExprBool(e.Test, MutateCSharp.Schemata407.ReplaceStringConstant_1(366L, "guard condition in if-then-else expression must be a boolean (instead got {0})"));
                expr.Type = new InferredTypeProxy();
                ConstrainSubtypeRelation(expr.Type, e.Thn.Type, expr, MutateCSharp.Schemata407.ReplaceStringConstant_1(367L, "the two branches of an if-then-else expression must have the same type (got {0} and {1})"), e.Thn.Type, e.Els.Type);
                ConstrainSubtypeRelation(expr.Type, e.Els.Type, expr, MutateCSharp.Schemata407.ReplaceStringConstant_1(368L, "the two branches of an if-then-else expression must have the same type (got {0} and {1})"), e.Thn.Type, e.Els.Type);

            }
            else if (expr is NestedMatchExpr nestedMatchExpr)
            {
                ResolveNestedMatchExpr(nestedMatchExpr, resolutionContext);
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected expression
            }

            if (MutateCSharp.Schemata407.ReplaceBinExprOp_24(369L, expr.Type, null))
            {
                // some resolution error occurred
                expr.Type = new InferredTypeProxy();
            }

            DominatingStatementLabels.PopMarker();
        }

        public void ResolveTypeParameters(List<TypeParameter/*!*/>/*!*/ tparams, bool emitErrors, TypeParameter.ParentType/*!*/ parent)
        {
            Contract.Requires(tparams != null);
            Contract.Requires(parent != null);
            // push non-duplicated type parameter names
            int index = MutateCSharp.Schemata407.ReplaceNumericConstant_6(370L, 0);
            foreach (TypeParameter tp in tparams)
            {
                if (emitErrors)
                {
                    // we're seeing this TypeParameter for the first time
                    tp.Parent = parent;
                    tp.PositionalIndex = index;
                }
                var r = allTypeParameters.Push(tp.Name, tp);
                if (emitErrors)
                {
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_25(374L, r, Scope<TypeParameter>.PushResult.Duplicate))
                    {
                        reporter.Error(MessageSource.Resolver, ParseErrors.ErrorId.none, tp, MutateCSharp.Schemata407.ReplaceStringConstant_1(375L, "Duplicate type-parameter name: {0}"), tp.Name);
                    }
                    else if (MutateCSharp.Schemata407.ReplaceBinExprOp_25(376L, r, Scope<TypeParameter>.PushResult.Shadow))
                    {
                        reporter.Warning(MessageSource.Resolver, ParseErrors.ErrorId.none, tp.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(377L, "Shadowed type-parameter name: {0}"), tp.Name);
                    }
                }
            }
        }

        public bool ConstrainSubtypeRelation(Type super, Type sub, Expression exprForToken, string msg, params object[] msgArgs)
        {
            Contract.Requires(sub != null);
            Contract.Requires(super != null);
            Contract.Requires(exprForToken != null);
            Contract.Requires(msg != null);
            Contract.Requires(msgArgs != null);
            return ConstrainSubtypeRelation(super, sub, exprForToken.tok, msg, msgArgs);
        }

        public void ConstrainTypeExprBool(Expression e, string message)
        {
            Contract.Requires(e != null);
            Contract.Requires(message != null);  // expected to have a {0} part
            ConstrainSubtypeRelation(Type.Bool, e.Type, e, message, e.Type);
        }

        public bool ConstrainSubtypeRelation(Type super, Type sub, IToken tok, string msg, params object[] msgArgs)
        {
            Contract.Requires(sub != null);
            Contract.Requires(super != null);
            Contract.Requires(tok != null);
            Contract.Requires(msg != null);
            Contract.Requires(msgArgs != null);
            return ConstrainSubtypeRelation(super, sub, new TypeConstraint.ErrorMsgWithToken(tok, msg, msgArgs));
        }

        public void ConstrainAssignable(NonProxyType lhs, Type rhs, TypeConstraint.ErrorMsg errMsg, out bool moreXConstraints, bool allowDecisions)
        {
            Contract.Requires(lhs != null);
            Contract.Requires(rhs != null);
            Contract.Requires(errMsg != null);

            DetermineRootLeaf(lhs, out var isRoot, out _, out _, out _);
            if (isRoot)
            {
                ConstrainSubtypeRelation(lhs, rhs, errMsg, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(378L, true), allowDecisions);
                moreXConstraints = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(379L, false);
            }
            else
            {
                var lhsWithProxyArgs = Type.HeadWithProxyArgs(lhs);
                ConstrainSubtypeRelation(lhsWithProxyArgs, rhs, errMsg, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(380L, false), allowDecisions);
                ConstrainAssignableTypeArgs(lhs, lhsWithProxyArgs.TypeArgs, lhs.TypeArgs, errMsg, out moreXConstraints);
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_26(381L, lhs.AsCollectionType, null))
                {
                    var sameHead = Type.SameHead(lhs, rhs);
                    if (!sameHead && lhs is UserDefinedType udtLhs && rhs is UserDefinedType udtRhs)
                    {
                        // also allow the case where lhs is a possibly-null type and rhs is a non-null type
                        sameHead = MutateCSharp.Schemata407.ReplaceBinExprOp_27(382L, udtLhs.ResolvedClass, (udtRhs.ResolvedClass as NonNullTypeDecl)?.Class);
                    }
                    if (sameHead)
                    {
                        ConstrainAssignableTypeArgs(lhs, lhs.TypeArgs, rhs.TypeArgs, errMsg, out var more2);
                        moreXConstraints = moreXConstraints || more2;
                    }
                }
            }
        }

        public void ConstrainAssignableTypeArgs(Type typeHead, List<Type> A, List<Type> B, TypeConstraint.ErrorMsg errMsg, out bool moreXConstraints)
        {
            Contract.Requires(typeHead != null);
            Contract.Requires(A != null);
            Contract.Requires(B != null);
            Contract.Requires(A.Count == B.Count);
            Contract.Requires(errMsg != null);

            var tok = errMsg.Tok;
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(387L, B.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(383L, 0)))
            {
                // all done
                moreXConstraints = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(392L, false);
            }
            else if (typeHead is MapType)
            {
                var em = new TypeConstraint.ErrorMsgWithBase(errMsg, MutateCSharp.Schemata407.ReplaceStringConstant_1(393L, "covariance for type parameter at index 0 expects {1} <: {0}"), A[MutateCSharp.Schemata407.ReplaceNumericConstant_6(394L, 0)], B[MutateCSharp.Schemata407.ReplaceNumericConstant_6(398L, 0)]);
                AddAssignableConstraint(tok, A[MutateCSharp.Schemata407.ReplaceNumericConstant_6(402L, 0)], B[MutateCSharp.Schemata407.ReplaceNumericConstant_6(406L, 0)], em);
                em = new TypeConstraint.ErrorMsgWithBase(errMsg, MutateCSharp.Schemata407.ReplaceStringConstant_1(410L, "covariance for type parameter at index 1 expects {1} <: {0}"), A[MutateCSharp.Schemata407.ReplaceNumericConstant_6(411L, 1)], B[MutateCSharp.Schemata407.ReplaceNumericConstant_6(415L, 1)]);
                AddAssignableConstraint(tok, A[MutateCSharp.Schemata407.ReplaceNumericConstant_6(419L, 1)], B[MutateCSharp.Schemata407.ReplaceNumericConstant_6(423L, 1)], em);
                moreXConstraints = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(427L, true);
            }
            else if (typeHead is CollectionType)
            {
                var em = new TypeConstraint.ErrorMsgWithBase(errMsg, MutateCSharp.Schemata407.ReplaceStringConstant_1(428L, "covariance for type parameter expects {1} <: {0}"), A[MutateCSharp.Schemata407.ReplaceNumericConstant_6(429L, 0)], B[MutateCSharp.Schemata407.ReplaceNumericConstant_6(433L, 0)]);
                AddAssignableConstraint(tok, A[MutateCSharp.Schemata407.ReplaceNumericConstant_6(437L, 0)], B[MutateCSharp.Schemata407.ReplaceNumericConstant_6(441L, 0)], em);
                moreXConstraints = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(445L, true);
            }
            else
            {
                var udt = (UserDefinedType)typeHead;  // note, collections, maps, and user-defined types are the only one with TypeArgs.Count != 0
                var cl = udt.ResolvedClass;
                Contract.Assert(cl != null);
                Contract.Assert(cl.TypeArgs.Count == B.Count);
                moreXConstraints = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(446L, false);
                for (int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(447L, 0); MutateCSharp.Schemata407.ReplaceBinExprOp_12(451L, i, B.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(456L, ref i))
                {
                    var msgFormat = MutateCSharp.Schemata407.ReplaceStringConstant_1(457L, "variance for type parameter") + (MutateCSharp.Schemata407.ReplaceBinExprOp_7(462L, B.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(458L, 1)) ? "" : MutateCSharp.Schemata407.ReplaceStringConstant_1(467L, " at index ") + i) + MutateCSharp.Schemata407.ReplaceStringConstant_1(468L, " expects {0} {1} {2}");
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_28(469L, cl.TypeArgs[i].Variance, TypeParameter.TPVariance.Co))
                    {
                        var em = new TypeConstraint.ErrorMsgWithBase(errMsg, MutateCSharp.Schemata407.ReplaceStringConstant_1(470L, "co") + msgFormat, A[i], MutateCSharp.Schemata407.ReplaceStringConstant_1(471L, ":>"), B[i]);
                        AddAssignableConstraint(tok, A[i], B[i], em);
                        moreXConstraints = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(472L, true);
                    }
                    else if (MutateCSharp.Schemata407.ReplaceBinExprOp_28(473L, cl.TypeArgs[i].Variance, TypeParameter.TPVariance.Contra))
                    {
                        var em = new TypeConstraint.ErrorMsgWithBase(errMsg, MutateCSharp.Schemata407.ReplaceStringConstant_1(474L, "contra") + msgFormat, A[i], MutateCSharp.Schemata407.ReplaceStringConstant_1(475L, "<:"), B[i]);
                        AddAssignableConstraint(tok, B[i], A[i], em);
                        moreXConstraints = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(476L, true);
                    }
                    else
                    {
                        var em = new TypeConstraint.ErrorMsgWithBase(errMsg, MutateCSharp.Schemata407.ReplaceStringConstant_1(477L, "non") + msgFormat, A[i], MutateCSharp.Schemata407.ReplaceStringConstant_1(478L, "="), B[i]);
                        ConstrainSubtypeRelation_Equal(A[i], B[i], em);
                    }
                }
            }
        }

        /// <summary>
        /// Adds the subtyping constraint that "a" and "b" are the same type.
        /// </summary>
        public void ConstrainSubtypeRelation_Equal(Type a, Type b, TypeConstraint.ErrorMsg errMsg)
        {
            Contract.Requires(a != null);
            Contract.Requires(b != null);
            Contract.Requires(errMsg != null);

            var proxy = a.Normalize() as TypeProxy;
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(491L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_9(481L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_29(479L, proxy, null), () => MutateCSharp.Schemata407.ReplaceBinExprOp_24(480L, proxy.T, null)), () => !Reaches(b, proxy, MutateCSharp.Schemata407.ReplaceNumericConstant_6(487L, 1), new HashSet<TypeProxy>())))
            {
                if (Options.Get(CommonOptionBag.TypeInferenceDebug))
                {
                    Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(497L, "DEBUG: (invariance) assigning proxy {0}.T := {1}"), proxy, b);
                }
                proxy.T = b;
            }
            proxy = b.Normalize() as TypeProxy;
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(510L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_9(500L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_29(498L, proxy, null), () => MutateCSharp.Schemata407.ReplaceBinExprOp_24(499L, proxy.T, null)), () => !Reaches(a, proxy, MutateCSharp.Schemata407.ReplaceNumericConstant_6(506L, 1), new HashSet<TypeProxy>())))
            {
                if (Options.Get(CommonOptionBag.TypeInferenceDebug))
                {
                    Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(516L, "DEBUG: (invariance) assigning proxy {0}.T := {1}"), proxy, a);
                }
                proxy.T = a;
            }

            ConstrainSubtypeRelation(a, b, errMsg, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(517L, true));
            ConstrainSubtypeRelation(b, a, errMsg, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(518L, true));
        }

        /// <summary>
        /// Adds the subtyping constraint that "sub" is a subtype of "super".
        /// If this constraint seems feasible, returns "true".  Otherwise, prints error message (either "errMsg" or something
        /// more specific) and returns "false".
        /// Note, if in doubt, this method can return "true", because the constraints will be checked for sure at a later stage.
        /// </summary>
        public bool ConstrainSubtypeRelation(Type super, Type sub, TypeConstraint.ErrorMsg errMsg, bool keepConstraints = false, bool allowDecisions = false)
        {
            Contract.Requires(sub != null);
            Contract.Requires(super != null);
            Contract.Requires(errMsg != null);

            if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(519L, () => !keepConstraints, () => super is InferredTypeProxy))
            {
                var ip = (InferredTypeProxy)super;
                if (ip.KeepConstraints)
                {
                    keepConstraints = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(525L, true);
                }
            }
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(526L, () => !keepConstraints, () => sub is InferredTypeProxy))
            {
                var ip = (InferredTypeProxy)sub;
                if (ip.KeepConstraints)
                {
                    keepConstraints = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(532L, true);
                }
            }

            super = super.NormalizeExpand(keepConstraints);
            sub = sub.NormalizeExpand(keepConstraints);
            var c = new TypeConstraint(super, sub, errMsg, keepConstraints);
            AllTypeConstraints.Add(c);
            return ConstrainSubtypeRelation_Aux(super, sub, c, keepConstraints, allowDecisions);
        }
        private bool ConstrainSubtypeRelation_Aux(Type super, Type sub, TypeConstraint c, bool keepConstraints, bool allowDecisions)
        {
            Contract.Requires(sub != null);
            Contract.Requires(!(sub is TypeProxy) || ((TypeProxy)sub).T == null);  // caller is expected to have Normalized away proxies
            Contract.Requires(super != null);
            Contract.Requires(!(super is TypeProxy) || ((TypeProxy)super).T == null);  // caller is expected to have Normalized away proxies
            Contract.Requires(c != null);

            if (object.ReferenceEquals(super, sub))
            {
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(533L, true);
            }
            else if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(534L, () => super is TypeProxy, () => sub is TypeProxy))
            {
                // both are proxies
                ((TypeProxy)sub).AddSupertype(c);
                ((TypeProxy)super).AddSubtype(c);
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(540L, true);
            }
            else if (sub is TypeProxy)
            {
                var proxy = (TypeProxy)sub;
                proxy.AddSupertype(c);
                AssignKnownEnd(proxy, keepConstraints, allowDecisions);
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(541L, true);
            }
            else if (super is TypeProxy)
            {
                var proxy = (TypeProxy)super;
                proxy.AddSubtype(c);
                AssignKnownEnd(proxy, keepConstraints, allowDecisions);
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(542L, true);
            }
            else
            {
                // two non-proxy types
                // set "headSymbolsAgree" to "false" if it's clear the head symbols couldn't be the same; "true" means they may be the same
                bool headSymbolsAgree = Type.IsHeadSupertypeOf(super.NormalizeExpand(keepConstraints), sub);
                if (!headSymbolsAgree)
                {
                    c.FlagAsError(this);
                    return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(543L, false);
                }
                // TODO: inspect type parameters in order to produce some error messages sooner
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(544L, true);
            }

            return default;
        }

        /// <summary>
        /// "root" says that the type is a non-artificial type (that is, not an ArtificialType) with no proper supertypes.
        /// "leaf" says that the only possible proper subtypes are subset types of the type. Thus, the only
        /// types that are not leaf types are traits and artificial types.
        /// The "headIs" versions speak only about the head symbols, so it is possible that the given
        /// type arguments would change the root/leaf status of the entire type.
        /// </summary>
        void DetermineRootLeaf(Type t, out bool isRoot, out bool isLeaf, out bool headIsRoot, out bool headIsLeaf)
        {
            Contract.Requires(t != null);
            Contract.Ensures(!Contract.ValueAtReturn(out isRoot) || Contract.ValueAtReturn(out headIsRoot)); // isRoot ==> headIsRoot
            Contract.Ensures(!Contract.ValueAtReturn(out isLeaf) || Contract.ValueAtReturn(out headIsLeaf)); // isLeaf ==> headIsLeaf
            t = t.NormalizeExpandKeepConstraints();
            if (t.IsObjectQ)
            {
                isRoot = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(545L, true); isLeaf = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(546L, false);
                headIsRoot = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(547L, true); headIsLeaf = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(548L, false);
            }
            else if (t is ArrowType)
            {
                var arr = (ArrowType)t;
                headIsRoot = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(549L, true); headIsLeaf = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(550L, true);  // these are definitely true
                isRoot = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(551L, true); isLeaf = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(552L, true);  // set these to true until proven otherwise
                Contract.Assert(arr.Arity + 1 == arr.TypeArgs.Count);
                for (int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(553L, 0); MutateCSharp.Schemata407.ReplaceBinExprOp_12(557L, i, arr.TypeArgs.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(562L, ref i))
                {
                    var arg = arr.TypeArgs[i];
                    DetermineRootLeaf(arg, out var r, out var l, out _, out _);
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_12(563L, i, arr.Arity))
                    {
                        isRoot &= l; isLeaf &= r;  // argument types are contravariant
                    }
                    else
                    {
                        isRoot &= r; isLeaf &= l;  // result type is covariant
                    }
                }
            }
            else if (t is UserDefinedType)
            {
                var udt = (UserDefinedType)t;
                var cl = udt.ResolvedClass;
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_30(568L, cl, null))
                {
                    if (cl is TypeParameter)
                    {
                        var tp = udt.AsTypeParameter;
                        Contract.Assert(tp != null);
                        headIsRoot = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(569L, true); headIsLeaf = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(570L, true);  // all type parameters are non-variant
                    }
                    else if (cl is SubsetTypeDecl)
                    {
                        headIsRoot = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(571L, false); headIsLeaf = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(572L, true);
                    }
                    else if (cl is NewtypeDecl)
                    {
                        headIsRoot = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(573L, true); headIsLeaf = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(574L, true);
                    }
                    else if (cl is TraitDecl)
                    {
                        headIsRoot = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(575L, false); headIsLeaf = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(576L, false);
                    }
                    else if (cl is ClassDecl)
                    {
                        headIsRoot = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(577L, false); headIsLeaf = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(578L, true);
                    }
                    else if (cl is AbstractTypeDecl)
                    {
                        headIsRoot = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(579L, true); headIsLeaf = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(580L, true);
                    }
                    else if (cl is InternalTypeSynonymDecl)
                    {
                        Contract.Assert(object.ReferenceEquals(t, t.NormalizeExpand())); // should be opaque in scope
                        headIsRoot = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(581L, true); headIsLeaf = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(582L, true);
                    }
                    else
                    {
                        Contract.Assert(cl is DatatypeDecl);
                        headIsRoot = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(583L, true); headIsLeaf = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(584L, true);
                    }
                    // for "isRoot" and "isLeaf", also take into consideration the root/leaf status of type arguments
                    isRoot = headIsRoot; isLeaf = headIsLeaf;
                    Contract.Assert(udt.TypeArgs.Count == cl.TypeArgs.Count);
                    for (int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(585L, 0); MutateCSharp.Schemata407.ReplaceBinExprOp_12(589L, i, udt.TypeArgs.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(594L, ref i))
                    {
                        var variance = cl.TypeArgs[i].Variance;
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_31(595L, variance, TypeParameter.TPVariance.Non))
                        {
                            DetermineRootLeaf(udt.TypeArgs[i], out var r, out var l, out _, out _);
                            // isRoot and isLeaf aren't duals, so Co and Contra require separate consideration beyond inversion.
                            switch (variance)
                            {
                                case TypeParameter.TPVariance.Co:
                                    { isRoot &= r; isLeaf &= l; break; }

                                    break;
                                // A invariably constructible subtype becomes a supertype, and thus the enclosing type is never a root.
                                case TypeParameter.TPVariance.Contra:
                                    { isRoot &= false; isLeaf &= r; break; }

                                    break;
                            }
                        }
                    }
                }
                else
                {
                    isRoot = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(596L, false); isLeaf = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(597L, false);  // don't know
                    headIsRoot = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(598L, false); headIsLeaf = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(599L, false);
                }
            }
            else if (MutateCSharp.Schemata407.ReplaceBinExprOp_32(631L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_32(625L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_32(619L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_32(612L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_32(606L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_32(600L, () => t.IsBoolType, () => t.IsCharType), () => t.IsIntegerType), () => t.IsRealType), () => MutateCSharp.Schemata407.ReplaceBinExprOp_33(618L, t.AsNewtype, null)), () => t.IsBitVectorType), () => t.IsBigOrdinalType))
            {
                isRoot = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(637L, true); isLeaf = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(638L, true);
                headIsRoot = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(639L, true); headIsLeaf = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(640L, true);
            }
            else if (t is ArtificialType)
            {
                isRoot = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(641L, false); isLeaf = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(642L, false);
                headIsRoot = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(643L, false); headIsLeaf = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(644L, false);
            }
            else if (t is MapType)
            {  // map, imap
                Contract.Assert(t.TypeArgs.Count == 2);
                DetermineRootLeaf(t.TypeArgs[MutateCSharp.Schemata407.ReplaceNumericConstant_6(645L, 0)], out var r0, out _, out _, out _);
                DetermineRootLeaf(t.TypeArgs[MutateCSharp.Schemata407.ReplaceNumericConstant_6(649L, 1)], out var r1, out _, out _, out _);
                isRoot = MutateCSharp.Schemata407.ReplaceBinExprOp_34(653L, () => r0, () => r1); isLeaf = MutateCSharp.Schemata407.ReplaceBinExprOp_34(659L, () => r0, () => r1);  // map types are covariant in both type arguments
                headIsRoot = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(665L, true); headIsLeaf = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(666L, true);
            }
            else if (t is CollectionType)
            {  // set, iset, multiset, seq
                Contract.Assert(t.TypeArgs.Count == 1);
                DetermineRootLeaf(t.TypeArgs[MutateCSharp.Schemata407.ReplaceNumericConstant_6(667L, 0)], out isRoot, out isLeaf, out _, out _);  // type is covariant is type argument
                headIsRoot = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(671L, true); headIsLeaf = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(672L, true);
            }
            else
            {
                isRoot = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(673L, false); isLeaf = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(674L, false);  // don't know
                headIsRoot = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(675L, false); headIsLeaf = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(676L, false);
            }
        }

        int _recursionDepth = MutateCSharp.Schemata407.ReplaceNumericConstant_6(677L, 0);

        public bool AssignProxyAndHandleItsConstraints(TypeProxy proxy, Type t, bool keepConstraints = false)
        {
            Contract.Requires(proxy != null);
            Contract.Requires(proxy.T == null);
            Contract.Requires(t != null);
            Contract.Requires(!(t is TypeProxy));
            Contract.Requires(!(t is ArtificialType));
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(685L, _recursionDepth, MutateCSharp.Schemata407.ReplaceNumericConstant_6(681L, 20000)))
            {
                Contract.Assume(false);  // possible infinite recursion
            }

            MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(690L, ref _recursionDepth);
            var b = AssignProxyAndHandleItsConstraints_aux(proxy, t, keepConstraints);
            MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_35(691L, ref _recursionDepth);
            return b;
        }
        /// <summary>
        /// This method is called if "proxy" is an unassigned proxy and "t" is a type whose head symbol is known.
        /// It always sets "proxy.T" to "t".
        /// Then, it deals with the constraints of "proxy" as follows:
        /// * If the constraint compares "t" with a non-proxy with a head comparable with that of "t",
        ///   then add constraints that the type arguments satisfy the desired subtyping constraint
        /// * If the constraint compares "t" with a non-proxy with a head not comparable with that of "t",
        ///   then report an error
        /// * If the constraint compares "t" with a proxy, then (depending on the constraint and "t") attempt
        ///   to recursively set it
        /// After this process, the proxy's .Supertypes and .Subtypes lists of constraints are no longer needed.
        /// If anything is found to be infeasible, "false" is returned (and the propagation may be interrupted);
        /// otherwise, "true" is returned.
        /// </summary>
        private bool AssignProxyAndHandleItsConstraints_aux(TypeProxy proxy, Type t, bool keepConstraints = false)
        {
            Contract.Requires(proxy != null);
            Contract.Requires(proxy.T == null);
            Contract.Requires(t != null);
            Contract.Requires(!(t is TypeProxy));
            Contract.Requires(!(t is ArtificialType));

            t = keepConstraints ? t.Normalize() : t.NormalizeExpand();
            // never violate the type constraint of a literal expression
            var followedRequestedAssignment = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(692L, true);
            foreach (var su in proxy.Supertypes)
            {
                if (su is IntVarietiesSupertype)
                {
                    var fam = TypeProxy.GetFamily(t);
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_32(702L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_32(695L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_36(693L, fam, TypeProxy.Family.IntLike), () => MutateCSharp.Schemata407.ReplaceBinExprOp_36(694L, fam, TypeProxy.Family.BitVector)), () => MutateCSharp.Schemata407.ReplaceBinExprOp_36(701L, fam, TypeProxy.Family.Ordinal)))
                    {
                        // good, let's continue with the request to equate the proxy with t
                        // unless...
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_37(708L, t, t.NormalizeExpand()))
                        {
                            // force the type to be a base type
                            if (Options.Get(CommonOptionBag.TypeInferenceDebug))
                            {
                                Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(709L, "DEBUG: hijacking {0}.T := {1} to instead assign {2}"), proxy, t, t.NormalizeExpand());
                            }
                            t = t.NormalizeExpand();
                            followedRequestedAssignment = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(710L, false);
                        }
                    }
                    else
                    {
                        // hijack the setting of proxy; to do that, we decide on a particular int variety now
                        if (Options.Get(CommonOptionBag.TypeInferenceDebug))
                        {
                            Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(711L, "DEBUG: hijacking {0}.T := {1} to instead assign {2}"), proxy, t, Type.Int);
                        }
                        t = Type.Int;
                        followedRequestedAssignment = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(712L, false);
                    }
                    break;
                }
                else if (su is RealVarietiesSupertype)
                {
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_36(713L, TypeProxy.GetFamily(t), TypeProxy.Family.RealLike))
                    {
                        // good, let's continue with the request to equate the proxy with t
                        // unless...
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_37(714L, t, t.NormalizeExpand()))
                        {
                            // force the type to be a base type
                            if (Options.Get(CommonOptionBag.TypeInferenceDebug))
                            {
                                Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(715L, "DEBUG: hijacking {0}.T := {1} to instead assign {2}"), proxy, t, t.NormalizeExpand());
                            }
                            t = t.NormalizeExpand();
                            followedRequestedAssignment = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(716L, false);
                        }
                    }
                    else
                    {
                        // hijack the setting of proxy; to do that, we decide on a particular real variety now
                        if (Options.Get(CommonOptionBag.TypeInferenceDebug))
                        {
                            Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(717L, "DEBUG: hijacking {0}.T := {1} to instead assign {2}"), proxy, t, Type.Real);
                        }
                        t = Type.Real;
                        followedRequestedAssignment = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(718L, false);
                    }
                    break;
                }
            }
            // set proxy.T right away, so that we can freely recurse without having to worry about infinite recursion
            if (Options.Get(CommonOptionBag.TypeInferenceDebug))
            {
                Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(719L, "DEBUG: setting proxy {0}.T := {1}"), proxy, t);
            }
            proxy.T = t;

            // check feasibility
            DetermineRootLeaf(t, out var isRoot, out var isLeaf, out _, out _);
            // propagate up
            foreach (var c in proxy.SupertypeConstraints)
            {
                var u = keepConstraints ? c.Super.NormalizeExpandKeepConstraints() : c.Super.NormalizeExpand();
                if (!(u is TypeProxy))
                {
                    ImposeSubtypingConstraint(u, t, c.ErrMsg);
                }
                else if (isRoot)
                {
                    // If t is a root, we might as well constrain u now.  Otherwise, we'll wait until the .Subtype constraint of u is dealt with.
                    AssignProxyAndHandleItsConstraints((TypeProxy)u, t, keepConstraints);
                }
            }
            // propagate down
            foreach (var c in proxy.SubtypeConstraints)
            {
                var u = keepConstraints ? c.Sub.NormalizeExpandKeepConstraints() : c.Sub.NormalizeExpand();
                Contract.Assert(!TypeProxy.IsSupertypeOfLiteral(u));  // these should only appear among .Supertypes
                if (!(u is TypeProxy))
                {
                    ImposeSubtypingConstraint(t, u, c.ErrMsg);
                }
                else if (isLeaf)
                {
                    // If t is a leaf (no pun intended), we might as well constrain u now.  Otherwise, we'll wait until the .Supertype constraint of u is dealt with.
                    AssignProxyAndHandleItsConstraints((TypeProxy)u, t, keepConstraints);
                }
            }

            return followedRequestedAssignment;
        }

        /// <summary>
        /// Impose constraints that "sub" is a subtype of "super", returning "false" if this leads to an overconstrained situation.
        /// In most cases, "sub" being a subtype of "super" means that "sub" and "super" have the same head symbol and, therefore, the
        /// same number of type arguments. Depending on the polarities of the type parameters, the corresponding arguments
        /// of "sub" and "super" must be in co-, in-, or contra-variant relationships to each other.
        /// There are two ways "sub" can be a subtype of "super" without the two having the same head symbol.
        /// One way is that "sub" is a subset type. In this case, the method starts by moving "sub" up toward "super".
        /// The other way is that "super" is a trait (possibly
        /// the trait "object").  By a current restriction in Dafny's type system, traits have no type parameters, so in this case, it
        /// suffices to check that the head symbol of "super" is something that derives from "sub".
        /// </summary>
        private bool ImposeSubtypingConstraint(Type super, Type sub, TypeConstraint.ErrorMsg errorMsg)
        {
            Contract.Requires(super != null && !(super is TypeProxy));
            Contract.Requires(sub != null && !(sub is TypeProxy));
            Contract.Requires(errorMsg != null);
            super = super.NormalizeExpandKeepConstraints();
            sub = sub.NormalizeExpandKeepConstraints();
            List<int> polarities = ConstrainTypeHead_Recursive(super, ref sub);
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_38(720L, polarities, null))
            {
                errorMsg.FlagAsError(this);
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(721L, false);
            }
            bool keepConstraints = KeepConstraints(super, sub);
            var p = polarities.Count;
            Contract.Assert(p == super.TypeArgs.Count);  // postcondition of ConstrainTypeHead
            Contract.Assert(p == 0 || sub.TypeArgs.Count == super.TypeArgs.Count);  // postcondition of ConstrainTypeHead
            for (int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(722L, 0); MutateCSharp.Schemata407.ReplaceBinExprOp_12(726L, i, p); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(731L, ref i))
            {
                var pol = polarities[i];
                var tp = MutateCSharp.Schemata407.ReplaceBinExprOp_7(736L, p, MutateCSharp.Schemata407.ReplaceNumericConstant_6(732L, 1)) ? "" : MutateCSharp.Schemata407.ReplaceStringConstant_1(741L, " ") + i;
                var errMsg = new TypeConstraint.ErrorMsgWithBase(errorMsg,
        MutateCSharp.Schemata407.ReplaceBinExprOp_12(746L, pol, MutateCSharp.Schemata407.ReplaceNumericConstant_6(742L, 0)) ? MutateCSharp.Schemata407.ReplaceStringConstant_1(751L, "contravariant type parameter{0} would require {1} <: {2}") : MutateCSharp.Schemata407.ReplaceBinExprOp_19(756L, pol, MutateCSharp.Schemata407.ReplaceNumericConstant_6(752L, 0)) ? MutateCSharp.Schemata407.ReplaceStringConstant_1(761L, "covariant type parameter{0} would require {2} <: {1}") : MutateCSharp.Schemata407.ReplaceStringConstant_1(762L, "non-variant type parameter{0} would require {1} = {2}"),
                  tp, super.TypeArgs[i], sub.TypeArgs[i]);
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_39(767L, pol, MutateCSharp.Schemata407.ReplaceNumericConstant_6(763L, 0)))
                {
                    if (!ConstrainSubtypeRelation(super.TypeArgs[i], sub.TypeArgs[i], errMsg, keepConstraints))
                    {
                        return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(772L, false);
                    }
                }
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_40(777L, pol, MutateCSharp.Schemata407.ReplaceNumericConstant_6(773L, 0)))
                {
                    if (!ConstrainSubtypeRelation(sub.TypeArgs[i], super.TypeArgs[i], errMsg, keepConstraints))
                    {
                        return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(782L, false);
                    }
                }
            }
            return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(783L, true);
        }

        /// <summary>
        /// This is a more liberal version of "ConstrainTypeHead" below. It is willing to move "sub"
        /// upward toward its parents until it finds a head that matches "super", if any.
        /// </summary>
        private static List<int> ConstrainTypeHead_Recursive(Type super, ref Type sub)
        {
            Contract.Requires(super != null);
            Contract.Requires(sub != null);

            super = super.NormalizeExpandKeepConstraints();
            sub = sub.NormalizeExpandKeepConstraints();

            var polarities = ConstrainTypeHead(super, sub);
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_41(784L, polarities, null))
            {
                return polarities;
            }

            foreach (var subParentType in sub.ParentTypes())
            {
                sub = subParentType;
                polarities = ConstrainTypeHead_Recursive(super, ref sub);
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_41(785L, polarities, null))
                {
                    return polarities;
                }
            }

            return null;
        }

        /// <summary>
        /// Determines if the head of "sub" can be a subtype of "super".
        /// If this is not possible, null is returned.
        /// If it is possible, return a list of polarities, one for each type argument of "sub".  Polarities
        /// indicate:
        ///     +1  co-variant
        ///      0  invariant
        ///     -1  contra-variant
        /// "sub" is of some type that can (in general) have type parameters.
        /// See also note about Dafny's current type system in the description of method "ImposeSubtypingConstraint".
        /// </summary>
        private static List<int> ConstrainTypeHead(Type super, Type sub)
        {
            Contract.Requires(super != null && !(super is TypeProxy));
            Contract.Requires(sub != null && !(sub is TypeProxy));
            if (super is IntVarietiesSupertype)
            {
                var famSub = TypeProxy.GetFamily(sub);
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_32(801L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_32(795L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_32(788L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_36(786L, famSub, TypeProxy.Family.IntLike), () => MutateCSharp.Schemata407.ReplaceBinExprOp_36(787L, famSub, TypeProxy.Family.BitVector)), () => MutateCSharp.Schemata407.ReplaceBinExprOp_36(794L, famSub, TypeProxy.Family.Ordinal)), () => super.Equals(sub)))
                {
                    return new List<int>();
                }
                else
                {
                    return null;
                }
            }
            else if (super is RealVarietiesSupertype)
            {
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_32(808L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_36(807L, TypeProxy.GetFamily(sub), TypeProxy.Family.RealLike), () => super.Equals(sub)))
                {
                    return new List<int>();
                }
                else
                {
                    return null;
                }
            }
            switch (TypeProxy.GetFamily(super))
            {
                case TypeProxy.Family.Bool:
                case TypeProxy.Family.Char:
                case TypeProxy.Family.IntLike:
                case TypeProxy.Family.RealLike:
                case TypeProxy.Family.Ordinal:
                case TypeProxy.Family.BitVector:
                    if (super.Equals(sub))
                    {
                        if (sub is UserDefinedType subUserDefinedType)
                        {
                            return subUserDefinedType.ResolvedClass.TypeArgs.ConvertAll(tp => TypeParameter.Direction(tp.Variance));
                        }
                        else
                        {
                            return new List<int>();
                        }
                    }
                    else
                    {
                        return null;
                    }

                    break;
                case TypeProxy.Family.ValueType:
                case TypeProxy.Family.Ref:
                case TypeProxy.Family.Opaque:
                    break;  // more elaborate work below
                    break;
                case TypeProxy.Family.Unknown:
                    if (super is UserDefinedType)
                    {
                        // more elaborate work below
                        break;
                    }
                    else
                    {
                        return null;
                    }

                    break;
                default:
                    Contract.Assert(false);  // unexpected type (the precondition of ConstrainTypeHead says "no proxies")
                    return null;  // please compiler
                    break;
            }
            if (super is SetType)
            {
                var tt = (SetType)super;
                var uu = sub as SetType;
                return MutateCSharp.Schemata407.ReplaceBinExprOp_9(821L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_42(814L, uu, null), () => MutateCSharp.Schemata407.ReplaceBinExprOp_43(815L, () => tt.Finite, () => uu.Finite)) ? new List<int> { MutateCSharp.Schemata407.ReplaceNumericConstant_6(827L, 1) } : null;
            }
            else if (super is SeqType)
            {
                return sub is SeqType ? new List<int> { MutateCSharp.Schemata407.ReplaceNumericConstant_6(831L, 1) } : null;
            }
            else if (super is MultiSetType)
            {
                return sub is MultiSetType ? new List<int> { MutateCSharp.Schemata407.ReplaceNumericConstant_6(835L, 1) } : null;
            }
            else if (super is MapType)
            {
                var tt = (MapType)super;
                var uu = sub as MapType;
                return MutateCSharp.Schemata407.ReplaceBinExprOp_9(846L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_44(839L, uu, null), () => MutateCSharp.Schemata407.ReplaceBinExprOp_43(840L, () => tt.Finite, () => uu.Finite)) ? new List<int> { MutateCSharp.Schemata407.ReplaceNumericConstant_6(852L, 1), MutateCSharp.Schemata407.ReplaceNumericConstant_6(856L, 1) } : null;
            }
            else if (super.IsObjectQ)
            {
                return sub.IsRefType ? new List<int>() : null;
            }
            else
            {
                // The only remaining cases are that "super" is a (co)datatype, abstract type, or non-object trait/class.
                // In each of these cases, "super" is a UserDefinedType.
                var udfSuper = (UserDefinedType)super;
                var clSuper = udfSuper.ResolvedClass;
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_45(860L, clSuper, null))
                {
                    Contract.Assert(super.TypeArgs.Count == 0);
                    if (super.IsTypeParameter)
                    {
                        // we're looking at a type parameter
                        return MutateCSharp.Schemata407.ReplaceBinExprOp_46(861L, super.AsTypeParameter, sub.AsTypeParameter) ? new List<int>() : null;
                    }
                    else
                    {
                        Contract.Assert(super.IsInternalTypeSynonym);
                        return MutateCSharp.Schemata407.ReplaceBinExprOp_47(862L, super.AsInternalTypeSynonym, sub.AsInternalTypeSynonym) ? new List<int>() : null;
                    }
                }
                var udfSub = sub as UserDefinedType;
                var clSub = MutateCSharp.Schemata407.ReplaceBinExprOp_18(863L, udfSub, null) ? null : udfSub.ResolvedClass;
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_45(864L, clSub, null))
                {
                    return null;
                }
                else if (MutateCSharp.Schemata407.ReplaceBinExprOp_48(865L, clSuper, clSub))
                {
                    // good
                    var polarities = new List<int>();
                    Contract.Assert(clSuper.TypeArgs.Count == udfSuper.TypeArgs.Count);
                    Contract.Assert(clSuper.TypeArgs.Count == udfSub.TypeArgs.Count);
                    foreach (var tp in clSuper.TypeArgs)
                    {
                        var polarity = TypeParameter.Direction(tp.Variance);
                        polarities.Add(polarity);
                    }

                    return polarities;
                }
                else if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(866L, () => udfSub.IsRefType, () => super.IsObjectQ))
                {
                    return new List<int>();
                }
                else if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(872L, () => udfSub.IsNonNullRefType, () => super.IsObject))
                {
                    return new List<int>();
                }
                else
                {
                    return null;
                }
            }

            return default;
        }
        private static bool KeepConstraints(Type super, Type sub)
        {
            Contract.Requires(super != null && !(super is TypeProxy));
            Contract.Requires(sub != null && !(sub is TypeProxy));
            if (super is IntVarietiesSupertype)
            {
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(878L, false);
            }
            else if (super is RealVarietiesSupertype)
            {
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(879L, false);
            }
            switch (TypeProxy.GetFamily(super))
            {
                case TypeProxy.Family.Bool:
                case TypeProxy.Family.Char:
                case TypeProxy.Family.IntLike:
                case TypeProxy.Family.RealLike:
                case TypeProxy.Family.Ordinal:
                case TypeProxy.Family.BitVector:
                    return false;
                    break;
                case TypeProxy.Family.ValueType:
                case TypeProxy.Family.Ref:
                case TypeProxy.Family.Opaque:
                    break;  // more elaborate work below
                    break;
                case TypeProxy.Family.Unknown:
                    return false;
                    break;
            }
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_32(892L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_32(886L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_32(880L, () => super is SetType, () => super is SeqType), () => super is MultiSetType), () => super is MapType))
            {
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(898L, true);
            }
            else if (super is ArrowType)
            {
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(899L, false);
            }
            else if (super.IsObjectQ)
            {
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(900L, false);
            }
            else
            {
                // super is UserDefinedType
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(901L, true);
            }

            return default;
        }

        public List<TypeConstraint> AllTypeConstraints = new List<TypeConstraint>();
        public List<XConstraint> AllXConstraints = new List<XConstraint>();


        /// <summary>
        /// Solves or simplifies as many type constraints as possible.
        /// If "allowDecisions" is "false", then no decisions, only determined inferences, are made; this mode is
        /// appropriate for the partial solving that's done before a member lookup.
        /// </summary>
        public void PartiallySolveTypeConstraints(bool allowDecisions)
        {
            int state = MutateCSharp.Schemata407.ReplaceNumericConstant_6(902L, 0);
            while (MutateCSharp.Schemata407.ReplaceBooleanConstant_3(906L, true))
            {
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(916L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_40(911L, MutateCSharp.Schemata407.ReplaceNumericConstant_6(907L, 2), state), () => !allowDecisions))
                {
                    // time to say goodnight to Napoli
                    return;
                }
                else if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(940L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_7(926L, AllTypeConstraints.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(922L, 0)), () => MutateCSharp.Schemata407.ReplaceBinExprOp_7(935L, AllXConstraints.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(931L, 0))))
                {
                    // we're done
                    return;
                }

                var anyNewConstraints = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(946L, false);
                var fullStrength = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(947L, false);
                // Process subtyping constraints
                PrintTypeConstraintState(MutateCSharp.Schemata407.ReplaceBinExprOp_50(965L, MutateCSharp.Schemata407.ReplaceNumericConstant_6(948L, 220), MutateCSharp.Schemata407.ReplaceBinExprOp_49(956L, MutateCSharp.Schemata407.ReplaceNumericConstant_6(952L, 2), state)));
                switch (state)
                {
                    case 0:
                        {
                            var allTypeConstraints = AllTypeConstraints;
                            AllTypeConstraints = new List<TypeConstraint>();
                            var processed = new HashSet<TypeConstraint>();
                            foreach (var c in allTypeConstraints)
                            {
                                ProcessOneSubtypingConstraintAndItsSubs(c, processed, fullStrength, ref anyNewConstraints);
                            }

                            allTypeConstraints = new List<TypeConstraint>(AllTypeConstraints);  // copy the list
                            foreach (var c in allTypeConstraints)
                            {
                                var super = c.Super.NormalizeExpand() as TypeProxy;
                                if (AssignKnownEnd(super, true, fullStrength))
                                {
                                    anyNewConstraints = true;
                                }
                                else if (super != null && fullStrength && AssignKnownEndsFullstrength(super))
                                {  // KRML: is this used any more?
                                    anyNewConstraints = true;
                                }
                            }
                        }
                        break;
                        break;
                    case 1:
                        {
                            // Process XConstraints
                            // confirm as many XConstraints as possible, setting "anyNewConstraints" to "true" if the confirmation
                            // of an XConstraint gives rise to new constraints to be handled in the loop above
                            bool generatedMoreXConstraints;
                            do
                            {
                                generatedMoreXConstraints = false;
                                var allXConstraints = AllXConstraints;
                                AllXConstraints = new List<XConstraint>();
                                foreach (var xc in allXConstraints)
                                {
                                    if (xc.Confirm(this, fullStrength, out var convertedIntoOtherTypeConstraints, out var moreXConstraints))
                                    {
                                        if (convertedIntoOtherTypeConstraints)
                                        {
                                            anyNewConstraints = true;
                                        }
                                        else
                                        {
                                            generatedMoreXConstraints = true;
                                        }
                                        if (moreXConstraints)
                                        {
                                            generatedMoreXConstraints = true;
                                        }
                                    }
                                    else
                                    {
                                        AllXConstraints.Add(xc);
                                    }
                                }
                            } while (generatedMoreXConstraints);
                        }
                        break;
                        break;
                    case 2:
                        {
                            var assignables = AllXConstraints.Where(xc => xc.ConstraintName == "Assignable").ToList();
                            var postponeForNow = new HashSet<TypeProxy>();
                            foreach (var constraint in AllTypeConstraints)
                            {
                                var lhs = constraint.Super.NormalizeExpandKeepConstraints() as NonProxyType;
                                if (lhs != null)
                                {
                                    foreach (var ta in lhs.TypeArgs)
                                    {
                                        AddAllProxies(ta, postponeForNow);
                                    }
                                }
                            }
                            foreach (var constraint in AllTypeConstraints)
                            {
                                var lhs = constraint.Super.Normalize() as TypeProxy;
                                if (lhs != null && !postponeForNow.Contains(lhs))
                                {
                                    var rhss = assignables.Where(xc => xc.Types[0].Normalize() == lhs).Select(xc => xc.Types[1]).ToList();
                                    if (ProcessAssignable(lhs, rhss))
                                    {
                                        anyNewConstraints = true;  // next time around the big loop, start with state 0 again
                                    }
                                }
                            }
                            foreach (var assignable in assignables)
                            {
                                var lhs = assignable.Types[0].Normalize() as TypeProxy;
                                if (lhs != null && !postponeForNow.Contains(lhs))
                                {
                                    var rhss = assignables.Where(xc => xc.Types[0].Normalize() == lhs).Select(xc => xc.Types[1]).ToList();
                                    if (ProcessAssignable(lhs, rhss))
                                    {
                                        anyNewConstraints = true;  // next time around the big loop, start with state 0 again
                                                                   // process only one Assignable constraint in this way
                                        break;
                                    }
                                }
                            }
                        }
                        break;
                        break;
                    case 3:
                        anyNewConstraints = ConvertAssignableToSubtypeConstraints(null);
                        break;
                        break;
                    case 4:
                        {
                            var allTC = AllTypeConstraints;
                            AllTypeConstraints = new List<TypeConstraint>();
                            var proxyProcessed = new HashSet<TypeProxy>();
                            foreach (var c in allTC)
                            {
                                ProcessFullStrength_SubDirection(c.Super, proxyProcessed, ref anyNewConstraints);
                            }
                            foreach (var xc in AllXConstraints)
                            {
                                if (xc.ConstraintName == "Assignable")
                                {
                                    ProcessFullStrength_SubDirection(xc.Types[0], proxyProcessed, ref anyNewConstraints);
                                }
                            }
                            if (!anyNewConstraints)
                            {
                                // only do super-direction if sub-direction had no effect
                                proxyProcessed = new HashSet<TypeProxy>();
                                foreach (var c in allTC)
                                {
                                    ProcessFullStrength_SuperDirection(c.Sub, proxyProcessed, ref anyNewConstraints);
                                }
                                foreach (var xc in AllXConstraints)
                                {
                                    if (xc.ConstraintName == "Assignable")
                                    {
                                        ProcessFullStrength_SuperDirection(xc.Types[1], proxyProcessed, ref anyNewConstraints);
                                    }
                                }
                            }
                            AllTypeConstraints.AddRange(allTC);
                        }
                        break;
                        break;
                    case 5:
                        {
                            // Process default numeric types
                            var allTypeConstraints = AllTypeConstraints;
                            AllTypeConstraints = new List<TypeConstraint>();
                            foreach (var c in allTypeConstraints)
                            {
                                if (c.Super is ArtificialType)
                                {
                                    var proxy = c.Sub.NormalizeExpand() as TypeProxy;
                                    if (proxy != null)
                                    {
                                        AssignProxyAndHandleItsConstraints(proxy, c.Super is IntVarietiesSupertype ? (Type)Type.Int : Type.Real);
                                        anyNewConstraints = true;
                                        continue;
                                    }
                                }
                                AllTypeConstraints.Add(c);
                            }
                        }
                        break;
                        break;
                    case 6:
                        {
                            fullStrength = true;
                            bool generatedMoreXConstraints;
                            do
                            {
                                generatedMoreXConstraints = false;
                                var allXConstraints = AllXConstraints;
                                AllXConstraints = new List<XConstraint>();
                                foreach (var xc in allXConstraints)
                                {
                                    if ((xc.ConstraintName == "Equatable" || xc.ConstraintName == "EquatableArg") && xc.Confirm(this, fullStrength, out var convertedIntoOtherTypeConstraints, out var moreXConstraints))
                                    {
                                        if (convertedIntoOtherTypeConstraints)
                                        {
                                            anyNewConstraints = true;
                                        }
                                        else
                                        {
                                            generatedMoreXConstraints = true;
                                        }
                                        if (moreXConstraints)
                                        {
                                            generatedMoreXConstraints = true;
                                        }
                                    }
                                    else
                                    {
                                        AllXConstraints.Add(xc);
                                    }
                                }
                            } while (generatedMoreXConstraints);
                        }
                        break;
                        break;
                    case 7:
                        {
                            // Process default reference types
                            var allXConstraints = AllXConstraints;
                            AllXConstraints = new List<XConstraint>();
                            foreach (var xc in allXConstraints)
                            {
                                if (xc.ConstraintName == "IsRefType" || xc.ConstraintName == "IsNullableRefType")
                                {
                                    var proxy = xc.Types[0].Normalize() as TypeProxy;  // before we started processing default types, this would have been a proxy (since it's still in the A
                                    if (proxy != null)
                                    {
                                        AssignProxyAndHandleItsConstraints(proxy, SystemModuleManager.ObjectQ());
                                        anyNewConstraints = true;
                                        continue;
                                    }
                                }
                                AllXConstraints.Add(xc);
                            }
                        }
                        break;
                        break;
                    case 8:
                        fullStrength = true; goto case 0;
                        break;
                    case 9:
                        fullStrength = true; goto case 1;
                        break;
                    case 10:
                        {
                            // Finally, collapse constraints involving only proxies, which will have the effect of trading some type error
                            // messages for type-underspecification messages.
                            var allTypeConstraints = AllTypeConstraints;
                            AllTypeConstraints = new List<TypeConstraint>();
                            foreach (var c in allTypeConstraints)
                            {
                                var super = c.Super.NormalizeExpand();
                                var sub = c.Sub.NormalizeExpand();
                                if (super == sub)
                                {
                                    continue;
                                }
                                else if (super is TypeProxy && sub is TypeProxy)
                                {
                                    var proxy = (TypeProxy)super;
                                    if (Options.Get(CommonOptionBag.TypeInferenceDebug))
                                    {
                                        Options.OutputWriter.WriteLine("DEBUG: (merge in PartiallySolve) assigning proxy {0}.T := {1}", proxy, sub);
                                    }
                                    proxy.T = sub;
                                    anyNewConstraints = true;  // signal a change in the constraints
                                    continue;
                                }
                                AllTypeConstraints.Add(c);
                            }
                        }
                        break;
                        break;
                    case 11:
                        {
                            // Last resort decisions. Sometimes get here even with some 'obvious'
                            // inferences. Before this case was added, the type inference returned with
                            // failure, so this is a conservative addition, and could be made more
                            // capable.
                            if (!allowDecisions)
                            {
                                break;
                            }

                            foreach (var c in AllXConstraints)
                            {
                                if (c.ConstraintName == "EquatableArg")
                                {
                                    ConstrainSubtypeRelation_Equal(c.Types[0], c.Types[1], c.errorMsg);
                                    anyNewConstraints = true;
                                    AllXConstraints.Remove(c);
                                    break;
                                }
                            }
                            if (anyNewConstraints)
                            {
                                break;
                            }

                            TypeConstraint.ErrorMsg oneSuperErrorMsg = null;
                            TypeConstraint.ErrorMsg oneSubErrorMsg = null;
                            var ss = new HashSet<Type>();
                            foreach (var c in AllTypeConstraints)
                            {
                                var super = c.Super.NormalizeExpand();
                                var sub = c.Sub.NormalizeExpand();
                                if (super is TypeProxy && !ss.Contains(super))
                                {
                                    ss.Add(super);
                                }
                                if (sub is TypeProxy && !ss.Contains(sub))
                                {
                                    ss.Add(sub);
                                }
                            }

                            foreach (var t in ss)
                            {
                                var lowers = new HashSet<Type>();
                                var uppers = new HashSet<Type>();
                                foreach (var c in AllTypeConstraints)
                                {
                                    var super = c.Super.NormalizeExpand();
                                    var sub = c.Sub.NormalizeExpand();
                                    if (t.Equals(super))
                                    {
                                        lowers.Add(sub);
                                        oneSubErrorMsg = c.ErrMsg;
                                    }
                                    if (t.Equals(sub))
                                    {
                                        uppers.Add(super);
                                        oneSuperErrorMsg = c.ErrMsg;
                                    }
                                }

                                bool done = false;
                                foreach (var tl in lowers)
                                {
                                    foreach (var tu in uppers)
                                    {
                                        if (tl.Equals(tu))
                                        {
                                            if (!ContainsAsTypeParameter(tu, t))
                                            {
                                                var errorMsg = new TypeConstraint.ErrorMsgWithBase(AllTypeConstraints[0].ErrMsg,
                                                  "Decision: {0} is decided to be {1} because the latter is both the upper and lower bound to the proxy",
                                                  t, tu);
                                                ConstrainSubtypeRelation_Equal(t, tu, errorMsg);
                                                // The above changes t so that it is a proxy with an assigned type
                                                anyNewConstraints = true;
                                                done = true;
                                                break;
                                            }
                                        }
                                    }
                                    if (done)
                                    {
                                        break;
                                    }
                                }
                            }
                            if (anyNewConstraints)
                            {
                                break;
                            }

                            foreach (var t in ss)
                            {
                                var lowers = new HashSet<Type>();
                                var uppers = new HashSet<Type>();
                                foreach (var c in AllTypeConstraints)
                                {
                                    var super = c.Super.NormalizeExpand();
                                    var sub = c.Sub.NormalizeExpand();
                                    if (t.Equals(super))
                                    {
                                        lowers.Add(sub);
                                    }

                                    if (t.Equals(sub))
                                    {
                                        uppers.Add(super);
                                    }
                                }

                                if (uppers.Count == 0)
                                {
                                    if (lowers.Count == 1)
                                    {
                                        var em = lowers.GetEnumerator();
                                        em.MoveNext();
                                        if (!ContainsAsTypeParameter(em.Current, t))
                                        {
                                            var errorMsg = new TypeConstraint.ErrorMsgWithBase(oneSubErrorMsg,
                                              "Decision: {0} is decided to be {1} because the latter is a lower bound to the proxy and there is no constraint with an upper bound",
                                              t, em.Current);
                                            ConstrainSubtypeRelation_Equal(t, em.Current, errorMsg);
                                            anyNewConstraints = true;
                                            break;
                                        }
                                    }
                                }
                                if (lowers.Count == 0)
                                {
                                    if (uppers.Count == 1)
                                    {
                                        var em = uppers.GetEnumerator();
                                        em.MoveNext();
                                        if (!ContainsAsTypeParameter(em.Current, t))
                                        {
                                            var errorMsg = new TypeConstraint.ErrorMsgWithBase(oneSuperErrorMsg,
                                              "Decision: {0} is decided to be {1} because the latter is an upper bound to the proxy and there is no constraint with a lower bound",
                                              t, em.Current);
                                            ConstrainSubtypeRelation_Equal(t, em.Current, errorMsg);
                                            anyNewConstraints = true;
                                            break;
                                        }
                                    }
                                }
                            }

                            break;
                        }

                        break;
                    case 12:
                        // we're so out of here
                        return;
                        break;
                }
                if (anyNewConstraints)
                {
                    state = MutateCSharp.Schemata407.ReplaceNumericConstant_6(974L, 0);
                }
                else
                {
                    MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(978L, ref state);
                }
            }
        }

        TypeProxy NewIntegerBasedProxy(IToken tok)
        {
            Contract.Requires(tok != null);
            var proxy = new InferredTypeProxy();
            ConstrainSubtypeRelation(new IntVarietiesSupertype(), proxy, tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(979L, "integer literal used as if it had type {0}"), proxy);
            return proxy;
        }

        private bool ContainsAsTypeParameter(Type t, Type u)
        {
            if (t.Equals(u))
            {
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(980L, true);
            }

            if (t is UserDefinedType udt)
            {
                foreach (var tp in udt.TypeArgs)
                {
                    if (ContainsAsTypeParameter(tp, u))
                    {
                        return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(981L, true);
                    }
                }
            }
            if (t is CollectionType st)
            {
                foreach (var tp in st.TypeArgs)
                {
                    if (ContainsAsTypeParameter(tp, u))
                    {
                        return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(982L, true);
                    }
                }
            }
            return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(983L, false);
        }

        private void AddAllProxies(Type type, HashSet<TypeProxy> proxies)
        {
            Contract.Requires(type != null);
            Contract.Requires(proxies != null);
            var proxy = type as TypeProxy;
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_29(984L, proxy, null))
            {
                proxies.Add(proxy);
            }
            else
            {
                foreach (var ta in type.TypeArgs)
                {
                    AddAllProxies(ta, proxies);
                }
            }
        }

        /// <summary>
        /// Set "lhs" to the join of "rhss" and "lhs.Subtypes, if possible.
        /// Returns "true' if something was done, or "false" otherwise.
        /// </summary>
        private bool ProcessAssignable(TypeProxy lhs, List<Type> rhss)
        {
            Contract.Requires(lhs != null && lhs.T == null);
            Contract.Requires(rhss != null);
            if (Options.Get(CommonOptionBag.TypeInferenceDebug))
            {
                Console.Write(MutateCSharp.Schemata407.ReplaceStringConstant_1(985L, "DEBUG: ProcessAssignable: {0} with rhss:"), lhs);
                foreach (var rhs in rhss)
                {
                    Options.OutputWriter.Write(MutateCSharp.Schemata407.ReplaceStringConstant_1(986L, " {0}"), rhs);
                }
                Options.OutputWriter.Write(MutateCSharp.Schemata407.ReplaceStringConstant_1(987L, " subtypes:"));
                foreach (var sub in lhs.SubtypesKeepConstraints)
                {
                    Options.OutputWriter.Write(MutateCSharp.Schemata407.ReplaceStringConstant_1(988L, " {0}"), sub);
                }
                Options.OutputWriter.WriteLine();
            }
            Type join = null;
            foreach (var rhs in rhss)
            {
                if (rhs is TypeProxy) { return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(989L, false); }
                join = MutateCSharp.Schemata407.ReplaceBinExprOp_24(990L, join, null) ? rhs : Type.Join(join, rhs, SystemModuleManager);
            }
            foreach (var sub in lhs.SubtypesKeepConstraints)
            {
                if (sub is TypeProxy) { return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(991L, false); }
                join = MutateCSharp.Schemata407.ReplaceBinExprOp_24(992L, join, null) ? sub : Type.Join(join, sub, SystemModuleManager);
            }
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_24(993L, join, null))
            {
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(994L, false);
            }
            else if (Reaches(join, lhs, MutateCSharp.Schemata407.ReplaceNumericConstant_6(995L, 1), new HashSet<TypeProxy>()))
            {
                // would cause a cycle, so don't do it
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(999L, false);
            }
            else
            {
                if (Options.Get(CommonOptionBag.TypeInferenceDebug))
                {
                    Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(1000L, "DEBUG: ProcessAssignable: assigning proxy {0}.T := {1}"), lhs, join);
                }
                lhs.T = join;
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1001L, true);
            }

            return default;
        }

        /// <summary>
        /// Convert each Assignable(A, B) constraint into a subtyping constraint A :> B,
        /// provided that:
        ///  - B is a non-proxy, and
        ///  - either "proxySpecialization" is null or some proxy in "proxySpecializations" prominently appears in A.
        /// </summary>
        bool ConvertAssignableToSubtypeConstraints(ISet<TypeProxy>/*?*/ proxySpecializations)
        {
            var anyNewConstraints = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1002L, false);
            // If (the head of) the RHS of an Assignable is known, convert the XConstraint into a subtyping constraint
            var allX = AllXConstraints;
            AllXConstraints = new List<XConstraint>();
            foreach (var xc in allX)
            {
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1009L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_51(1004L, xc.ConstraintName, MutateCSharp.Schemata407.ReplaceStringConstant_1(1003L, "Assignable")), () => xc.Types[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1005L, 1)].Normalize() is NonProxyType))
                {
                    var t0 = xc.Types[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1015L, 0)].NormalizeExpand();
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_32(1026L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_32(1020L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_52(1019L, proxySpecializations, null
          ), () => proxySpecializations.Contains(t0)
          ), () => t0.TypeArgs.Exists(ta => proxySpecializations.Contains(ta))))
                    {
                        ConstrainSubtypeRelation(t0, xc.Types[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1032L, 1)], xc.errorMsg, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1036L, true));
                        anyNewConstraints = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1037L, true);
                        continue;
                    }
                }
                AllXConstraints.Add(xc);
            }
            return anyNewConstraints;
        }

        bool TightenUpEquatable(ISet<TypeProxy> proxiesOfInterest)
        {
            Contract.Requires(proxiesOfInterest != null);
            var anyNewConstraints = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1038L, false);
            var allX = AllXConstraints;
            AllXConstraints = new List<XConstraint>();
            foreach (var xc in allX)
            {
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_32(1043L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_51(1040L, xc.ConstraintName, MutateCSharp.Schemata407.ReplaceStringConstant_1(1039L, "Equatable")), () => MutateCSharp.Schemata407.ReplaceBinExprOp_51(1042L, xc.ConstraintName, MutateCSharp.Schemata407.ReplaceStringConstant_1(1041L, "EquatableArg"))))
                {
                    var t0 = xc.Types[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1049L, 0)].NormalizeExpandKeepConstraints();
                    var t1 = xc.Types[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1053L, 1)].NormalizeExpandKeepConstraints();
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_32(1057L, () => proxiesOfInterest.Contains(t0), () => proxiesOfInterest.Contains(t1)))
                    {
                        ConstrainSubtypeRelation_Equal(t0, t1, xc.errorMsg);
                        anyNewConstraints = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1063L, true);
                        continue;
                    }
                }
                AllXConstraints.Add(xc);
            }
            return anyNewConstraints;
        }

        void ProcessOneSubtypingConstraintAndItsSubs(TypeConstraint c, ISet<TypeConstraint> processed, bool fullStrength, ref bool anyNewConstraints)
        {
            Contract.Requires(c != null);
            Contract.Requires(processed != null);
            if (processed.Contains(c))
            {
                return;  // our job has already been done, or is at least in progress
            }
            processed.Add(c);

            var super = c.Super.NormalizeExpandKeepConstraints();
            var sub = c.Sub.NormalizeExpandKeepConstraints();
            // Process all subtype types before going on
            var subProxy = sub as TypeProxy;
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_29(1064L, subProxy, null))
            {
                foreach (var cc in subProxy.SubtypeConstraints)
                {
                    ProcessOneSubtypingConstraintAndItsSubs(cc, processed, fullStrength, ref anyNewConstraints);
                }
            }
            // the processing may have assigned some proxies, so we'll refresh super and sub
            super = super.NormalizeExpandKeepConstraints();
            sub = sub.NormalizeExpandKeepConstraints();

            if (super.Equals(sub))
            {
                // the constraint is satisfied, so just drop it
            }
            else if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1071L, () => (MutateCSharp.Schemata407.ReplaceBinExprOp_32(1065L, () => super is NonProxyType, () => super is ArtificialType)), () => sub is NonProxyType))
            {
                ImposeSubtypingConstraint(super, sub, c.ErrMsg);
                anyNewConstraints = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1077L, true);
            }
            else if (AssignKnownEnd(sub as TypeProxy, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1078L, true), fullStrength))
            {
                anyNewConstraints = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1079L, true);
            }
            else if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1086L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_9(1080L, () => sub is TypeProxy, () => fullStrength), () => AssignKnownEndsFullstrength((TypeProxy)sub)))
            {
                anyNewConstraints = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1092L, true);
            }
            else
            {
                // keep the constraint for now
                AllTypeConstraints.Add(c);
            }
        }

        void ProcessFullStrength_SubDirection(Type t, ISet<TypeProxy> processed, ref bool anyNewConstraints)
        {
            Contract.Requires(t != null);
            Contract.Requires(processed != null);
            var proxy = t.NormalizeExpand() as TypeProxy;
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_29(1093L, proxy, null))
            {
                if (processed.Contains(proxy))
                {
                    return;  // our job has already been done, or is at least in progress
                }
                processed.Add(proxy);

                foreach (var u in proxy.SubtypesKeepConstraints_WithAssignable(AllXConstraints))
                {
                    ProcessFullStrength_SubDirection(u, processed, ref anyNewConstraints);
                }
                proxy = proxy.NormalizeExpand() as TypeProxy;
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1095L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_29(1094L, proxy, null), () => AssignKnownEndsFullstrength_SubDirection(proxy)))
                {
                    anyNewConstraints = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1101L, true);
                }
            }
        }

        void ProcessFullStrength_SuperDirection(Type t, ISet<TypeProxy> processed, ref bool anyNewConstraints)
        {
            Contract.Requires(t != null);
            Contract.Requires(processed != null);
            var proxy = t.NormalizeExpand() as TypeProxy;
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_29(1102L, proxy, null))
            {
                if (processed.Contains(proxy))
                {
                    return;  // our job has already been done, or is at least in progress
                }
                processed.Add(proxy);

                foreach (var u in proxy.Supertypes)
                {
                    ProcessFullStrength_SuperDirection(u, processed, ref anyNewConstraints);
                }
                proxy = proxy.NormalizeExpand() as TypeProxy;
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1104L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_29(1103L, proxy, null), () => AssignKnownEndsFullstrength_SuperDirection(proxy)))
                {
                    anyNewConstraints = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1110L, true);
                }
            }
        }

        /// <summary>
        /// Returns true if anything happened.
        /// </summary>
        bool AssignKnownEnd(TypeProxy proxy, bool keepConstraints, bool fullStrength)
        {
            Contract.Requires(proxy == null || proxy.T == null);  // caller is supposed to have called NormalizeExpand
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_53(1111L, proxy, null))
            {
                // nothing to do
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1112L, false);
            }
            // ----- first, go light; also, prefer subtypes over supertypes
            IEnumerable<Type> subTypes = keepConstraints ? proxy.SubtypesKeepConstraints : proxy.Subtypes;
            foreach (var su in subTypes)
            {
                DetermineRootLeaf(su, out var isRoot, out _, out var headRoot, out _);
                Contract.Assert(!isRoot || headRoot);  // isRoot ==> headRoot
                if (isRoot)
                {
                    if (Reaches(su, proxy, MutateCSharp.Schemata407.ReplaceNumericConstant_6(1113L, 1), new HashSet<TypeProxy>()))
                    {
                        // adding a constraint here would cause a bad cycle, so we don't
                    }
                    else
                    {
                        AssignProxyAndHandleItsConstraints(proxy, su, keepConstraints);
                        return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1117L, true);
                    }
                }
                else if (headRoot)
                {
                    if (Reaches(su, proxy, MutateCSharp.Schemata407.ReplaceNumericConstant_6(1118L, 1), new HashSet<TypeProxy>()))
                    {
                        // adding a constraint here would cause a bad cycle, so we don't
                    }
                    else
                    {
                        AssignProxyAndHandleItsConstraints(proxy, TypeProxy.HeadWithProxyArgs(su), keepConstraints);
                        return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1122L, true);
                    }
                }
            }
            if (fullStrength)
            {
                IEnumerable<Type> superTypes = keepConstraints ? proxy.SupertypesKeepConstraints : proxy.Supertypes;
                foreach (var su in superTypes)
                {
                    DetermineRootLeaf(su, out _, out var isLeaf, out _, out var headLeaf);
                    Contract.Assert(!isLeaf || headLeaf);  // isLeaf ==> headLeaf
                    if (isLeaf)
                    {
                        if (Reaches(su, proxy, MutateCSharp.Schemata407.ReplaceNumericConstant_6(1123L, -1), new HashSet<TypeProxy>()))
                        {
                            // adding a constraint here would cause a bad cycle, so we don't
                        }
                        else
                        {
                            AssignProxyAndHandleItsConstraints(proxy, su, keepConstraints);
                            return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1127L, true);
                        }
                    }
                    else if (headLeaf)
                    {
                        if (Reaches(su, proxy, MutateCSharp.Schemata407.ReplaceNumericConstant_6(1128L, -1), new HashSet<TypeProxy>()))
                        {
                            // adding a constraint here would cause a bad cycle, so we don't
                        }
                        else
                        {
                            AssignProxyAndHandleItsConstraints(proxy, TypeProxy.HeadWithProxyArgs(su), keepConstraints);
                            return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1132L, true);
                        }
                    }
                }
            }
            return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1133L, false);
        }

        bool AssignKnownEndsFullstrength(TypeProxy proxy)
        {
            Contract.Requires(proxy != null);
            // ----- continue with full strength
            // If the join of the subtypes exists, use it
            var joins = new List<Type>();
            foreach (var su in proxy.Subtypes)
            {
                if (su is TypeProxy)
                {
                    continue;  // don't include proxies in the meet computation
                }
                int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(1134L, 0);
                for (; MutateCSharp.Schemata407.ReplaceBinExprOp_12(1138L, i, joins.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(1143L, ref i))
                {
                    var j = Type.Join(joins[i], su, SystemModuleManager);
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_14(1144L, j, null))
                    {
                        joins[i] = j;
                        break;
                    }
                }
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(1145L, i, joins.Count))
                {
                    // we went to the end without finding a place to meet up
                    joins.Add(su);
                }
            }
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1167L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_7(1154L, joins.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(1150L, 1)), () => !Reaches(joins[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1159L, 0)], proxy, MutateCSharp.Schemata407.ReplaceNumericConstant_6(1163L, 1), new HashSet<TypeProxy>())))
            {
                // we were able to compute a meet of all the subtyping constraints, so use it
                AssignProxyAndHandleItsConstraints(proxy, joins[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1173L, 0)]);
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1177L, true);
            }
            // If the meet of the supertypes exists, use it
            var meets = new List<Type>();
            foreach (var su in proxy.Supertypes)
            {
                if (su is TypeProxy)
                {
                    continue;  // don't include proxies in the meet computation
                }
                int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(1178L, 0);
                for (; MutateCSharp.Schemata407.ReplaceBinExprOp_12(1182L, i, meets.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(1187L, ref i))
                {
                    var j = Type.Meet(meets[i], su, SystemModuleManager);
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_14(1188L, j, null))
                    {
                        meets[i] = j;
                        break;
                    }
                }
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(1189L, i, meets.Count))
                {
                    // we went to the end without finding a place to meet
                    meets.Add(su);
                }
            }
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1221L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_9(1207L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_7(1198L, meets.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(1194L, 1)), () => !(meets[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1203L, 0)] is ArtificialType)), () => !Reaches(meets[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1213L, 0)], proxy, MutateCSharp.Schemata407.ReplaceNumericConstant_6(1217L, -1), new HashSet<TypeProxy>())))
            {
                // we were able to compute a meet of all the subtyping constraints, so use it
                AssignProxyAndHandleItsConstraints(proxy, meets[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1227L, 0)]);
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1231L, true);
            }

            return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1232L, false);
        }

        bool AssignKnownEndsFullstrength_SubDirection(TypeProxy proxy)
        {
            Contract.Requires(proxy != null && proxy.T == null);
            // If the join the subtypes exists, use it
            var joins = new List<Type>();
            var proxySubs = new HashSet<TypeProxy>();
            proxySubs.Add(proxy);
            foreach (var su in proxy.SubtypesKeepConstraints_WithAssignable(AllXConstraints))
            {
                if (su is TypeProxy)
                {
                    proxySubs.Add((TypeProxy)su);
                }
                else
                {
                    int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(1233L, 0);
                    for (; MutateCSharp.Schemata407.ReplaceBinExprOp_12(1237L, i, joins.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(1242L, ref i))
                    {
                        var j = Type.Join(joins[i], su, SystemModuleManager);
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_14(1243L, j, null))
                        {
                            joins[i] = j;
                            break;
                        }
                    }
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(1244L, i, joins.Count))
                    {
                        // we went to the end without finding a place to join in
                        joins.Add(su);
                    }
                }
            }
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1266L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_7(1253L, joins.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(1249L, 1)), () => !Reaches(joins[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1258L, 0)], proxy, MutateCSharp.Schemata407.ReplaceNumericConstant_6(1262L, 1), new HashSet<TypeProxy>())))
            {
                // We were able to compute a join of all the subtyping constraints, so use it.
                // Well, maybe.  If "join[0]" denotes a non-null type and "proxy" is something
                // that could be assigned "null", then set "proxy" to the nullable version of "join[0]".
                // Stated differently, think of an applicable "IsNullableRefType" constraint as
                // being part of the join computation, essentially throwing in a "...?".
                // Except: If the join is a tight bound--meaning, it is also a meet--then pick it
                // after all, because that seems to give rise to less confusing error messages.
                if (joins[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1272L, 0)].IsNonNullRefType)
                {
                    Type meet = null;
                    if (MeetOfAllSupertypes(proxy, ref meet, new HashSet<TypeProxy>(), MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1276L, false)) && MutateCSharp.Schemata407.ReplaceBinExprOp_14(1277L, meet, null) && Type.SameHead(joins[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1278L, 0)], meet))
                    {
                        // leave it
                    }
                    else
                    {
                        CloseOverAssignableRhss(proxySubs);
                        if (HasApplicableNullableRefTypeConstraint(proxySubs))
                        {
                            if (Options.Get(CommonOptionBag.TypeInferenceDebug))
                            {
                                Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(1282L, "DEBUG: Found join {0} for proxy {1}, but weakening it to {2}"), joins[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1283L, 0)], proxy, joins[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1287L, 0)].NormalizeExpand());
                            }
                            AssignProxyAndHandleItsConstraints(proxy, joins[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1291L, 0)].NormalizeExpand(), MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1295L, true));
                            return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1296L, true);
                        }
                    }
                }
                AssignProxyAndHandleItsConstraints(proxy, joins[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1297L, 0)], MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1301L, true));
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1302L, true);
            }
            return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1303L, false);
        }

        private void CloseOverAssignableRhss(ISet<TypeProxy> proxySet)
        {
            Contract.Requires(proxySet != null);
            while (MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1304L, true))
            {
                var moreChanges = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1305L, false);
                foreach (var xc in AllXConstraints)
                {
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_51(1307L, xc.ConstraintName, MutateCSharp.Schemata407.ReplaceStringConstant_1(1306L, "Assignable")))
                    {
                        var source = xc.Types[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1308L, 0)].Normalize() as TypeProxy;
                        var sink = xc.Types[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1312L, 1)].Normalize() as TypeProxy;
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1330L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_9(1324L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_9(1318L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_29(1316L, source, null), () => MutateCSharp.Schemata407.ReplaceBinExprOp_29(1317L, sink, null)), () => proxySet.Contains(source)), () => !proxySet.Contains(sink)))
                        {
                            proxySet.Add(sink);
                            moreChanges = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1336L, true);
                        }
                    }
                }
                if (!moreChanges)
                {
                    return;
                }
            }
        }

        public bool HasApplicableNullableRefTypeConstraint(ISet<TypeProxy> proxySet)
        {
            Contract.Requires(proxySet != null);
            var nullableProxies = new HashSet<TypeProxy>();
            foreach (var xc in AllXConstraints)
            {
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_51(1338L, xc.ConstraintName, MutateCSharp.Schemata407.ReplaceStringConstant_1(1337L, "IsNullableRefType")))
                {
                    var npr = xc.Types[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1339L, 0)].Normalize() as TypeProxy;
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_29(1343L, npr, null))
                    {
                        nullableProxies.Add(npr);
                    }
                }
            }
            return proxySet.Any(nullableProxies.Contains);
        }

        public bool HasApplicableNullableRefTypeConstraint_SubDirection(TypeProxy proxy)
        {
            Contract.Requires(proxy != null);
            var nullableProxies = new HashSet<TypeProxy>();
            foreach (var xc in AllXConstraints)
            {
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_51(1345L, xc.ConstraintName, MutateCSharp.Schemata407.ReplaceStringConstant_1(1344L, "IsNullableRefType")))
                {
                    var npr = xc.Types[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1346L, 0)].Normalize() as TypeProxy;
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_29(1350L, npr, null))
                    {
                        nullableProxies.Add(npr);
                    }
                }
            }
            return HasApplicableNullableRefTypeConstraint_SubDirection_aux(proxy, nullableProxies, new HashSet<TypeProxy>());
        }
        private bool HasApplicableNullableRefTypeConstraint_SubDirection_aux(TypeProxy proxy, ISet<TypeProxy> nullableProxies, ISet<TypeProxy> visitedProxies)
        {
            Contract.Requires(proxy != null);
            Contract.Requires(nullableProxies != null);
            Contract.Requires(visitedProxies != null);

            if (visitedProxies.Contains(proxy))
            {
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1351L, false);
            }
            visitedProxies.Add(proxy);

            if (nullableProxies.Contains(proxy))
            {
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1352L, true);
            }

            foreach (var sub in proxy.SubtypesKeepConstraints_WithAssignable(AllXConstraints))
            {
                var psub = sub as TypeProxy;
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1354L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_29(1353L, psub, null), () => HasApplicableNullableRefTypeConstraint_SubDirection_aux(psub, nullableProxies, visitedProxies)))
                {
                    return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1360L, true);
                }
            }
            return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1361L, false);
        }

        bool AssignKnownEndsFullstrength_SuperDirection(TypeProxy proxy)
        {
            Contract.Requires(proxy != null && proxy.T == null);
            // First, compute the the join of the Assignable LHSs.  Then, compute
            // the meet of that join and the supertypes.
            var joins = new List<Type>();
            foreach (var xc in AllXConstraints)
            {
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1369L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_51(1363L, xc.ConstraintName, MutateCSharp.Schemata407.ReplaceStringConstant_1(1362L, "Assignable")), () => MutateCSharp.Schemata407.ReplaceBinExprOp_54(1368L, xc.Types[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1364L, 1)].Normalize(), proxy)))
                {
                    var su = xc.Types[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1375L, 0)].Normalize();
                    if (su is TypeProxy)
                    {
                        continue; // don't include proxies in the join computation
                    }
                    int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(1379L, 0);
                    for (; MutateCSharp.Schemata407.ReplaceBinExprOp_12(1383L, i, joins.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(1388L, ref i))
                    {
                        var j = Type.Join(joins[i], su, SystemModuleManager);
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_14(1389L, j, null))
                        {
                            joins[i] = j;
                            break;
                        }
                    }
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(1390L, i, joins.Count))
                    {
                        // we went to the end without finding a place to join in
                        joins.Add(su);
                    }
                }
            }
            // If the meet of the supertypes exists, use it
            var meets = new List<Type>(joins);
            foreach (var su in proxy.SupertypesKeepConstraints)
            {
                if (su is TypeProxy)
                {
                    continue;  // don't include proxies in the meet computation
                }
                int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(1395L, 0);
                for (; MutateCSharp.Schemata407.ReplaceBinExprOp_12(1399L, i, meets.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(1404L, ref i))
                {
                    var j = Type.Meet(meets[i], su, SystemModuleManager);
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_14(1405L, j, null))
                    {
                        meets[i] = j;
                        break;
                    }
                }
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(1406L, i, meets.Count))
                {
                    // we went to the end without finding a place to meet up
                    meets.Add(su);
                }
            }
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1438L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_9(1424L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_7(1415L, meets.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(1411L, 1)), () => !(meets[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1420L, 0)] is ArtificialType)), () => !Reaches(meets[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1430L, 0)], proxy, MutateCSharp.Schemata407.ReplaceNumericConstant_6(1434L, -1), new HashSet<TypeProxy>())))
            {
                // we were able to compute a meet of all the subtyping constraints, so use it
                AssignProxyAndHandleItsConstraints(proxy, meets[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1444L, 0)], MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1448L, true));
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1449L, true);
            }
            return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1450L, false);
        }

        int _reaches_recursion;
        private bool Reaches(Type t, TypeProxy proxy, int direction, HashSet<TypeProxy> visited)
        {
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(1455L, _reaches_recursion, MutateCSharp.Schemata407.ReplaceNumericConstant_6(1451L, 20)))
            {
                Contract.Assume(false);  // possible infinite recursion
            }

            MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(1460L, ref _reaches_recursion);
            var b = Reaches_aux(t, proxy, direction, visited);
            MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_35(1461L, ref _reaches_recursion);
            return b;
        }
        private bool Reaches_aux(Type t, TypeProxy proxy, int direction, HashSet<TypeProxy> visited)
        {
            Contract.Requires(t != null);
            Contract.Requires(proxy != null);
            Contract.Requires(visited != null);
            t = t.NormalizeExpand();
            var tproxy = t as TypeProxy;
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_53(1462L, tproxy, null))
            {
                var polarities = Type.GetPolarities(t).ConvertAll(TypeParameter.Direction);
                Contract.Assert(polarities != null);
                Contract.Assert(polarities.Count <= t.TypeArgs.Count);
                for (int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(1463L, 0); MutateCSharp.Schemata407.ReplaceBinExprOp_12(1467L, i, polarities.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(1472L, ref i))
                {
                    if (Reaches(t.TypeArgs[i], proxy, MutateCSharp.Schemata407.ReplaceBinExprOp_49(1473L, direction, polarities[i]), visited))
                    {
                        return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1482L, true);
                    }
                }
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1483L, false);
            }
            else if (MutateCSharp.Schemata407.ReplaceBinExprOp_55(1484L, tproxy, proxy))
            {
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1485L, true);
            }
            else if (visited.Contains(tproxy))
            {
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1486L, false);
            }
            else
            {
                visited.Add(tproxy);
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1496L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_40(1491L, MutateCSharp.Schemata407.ReplaceNumericConstant_6(1487L, 0), direction), () => tproxy.Subtypes.Any(su => Reaches(su, proxy, direction, visited))))
                {
                    return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1502L, true);
                }
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1512L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_40(1507L, direction, MutateCSharp.Schemata407.ReplaceNumericConstant_6(1503L, 0)), () => tproxy.Supertypes.Any(su => Reaches(su, proxy, direction, visited))))
                {
                    return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1518L, true);
                }
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1519L, false);
            }

            return default;
        }

        /// <summary>
        /// Assumes type parameters have already been pushed, and that all types in class members have been resolved
        /// </summary>
        void ResolveClassMemberBodiesInitial(TopLevelDeclWithMembers cl)
        {
            Contract.Requires(cl != null);
            Contract.Requires(currentClass == null);
            Contract.Requires(AllTypeConstraints.Count == 0);
            Contract.Ensures(currentClass == null);
            Contract.Ensures(AllTypeConstraints.Count == 0);

            currentClass = cl;
            foreach (MemberDecl member in cl.Members)
            {
                Contract.Assert(VisibleInScope(member));
                if (member is ConstantField { Rhs: { } } constantField)
                {
                    var resolutionContext = new ResolutionContext(constantField, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1520L, false));
                    scope.PushMarker();
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_32(1528L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_32(1522L, () => constantField.IsStatic, () => MutateCSharp.Schemata407.ReplaceBinExprOp_15(1521L, currentClass, null)), () => !currentClass.AcceptThis))
                    {
                        scope.AllowInstance = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1534L, false);
                    }
                    ResolveExpression(constantField.Rhs, resolutionContext);
                    scope.PopMarker();
                    AddAssignableConstraint(constantField.tok, constantField.Type, constantField.Rhs.Type,
          MutateCSharp.Schemata407.ReplaceStringConstant_1(1535L, "type for constant '") + constantField.Name + MutateCSharp.Schemata407.ReplaceStringConstant_1(1536L, "' is '{0}', but its initialization value type is '{1}'"));
                    SolveAllTypeConstraints();
                }
            }
            currentClass = null;
        }

        /// <summary>
        /// Assumes type parameters have already been pushed, and that all types in class members have been resolved
        /// </summary>
        void ResolveClassMemberBodies(TopLevelDeclWithMembers cl)
        {
            Contract.Requires(cl != null);
            Contract.Requires(currentClass == null);
            Contract.Requires(AllTypeConstraints.Count == 0);
            Contract.Ensures(currentClass == null);
            Contract.Ensures(AllTypeConstraints.Count == 0);

            currentClass = cl;
            foreach (MemberDecl member in cl.Members)
            {
                Contract.Assert(VisibleInScope(member));
                if (member.HasUserAttribute(MutateCSharp.Schemata407.ReplaceStringConstant_1(1537L, "only"), out var attribute))
                {
                    reporter.Warning(MessageSource.Verifier, ResolutionErrors.ErrorId.r_member_only_assumes_other.ToString(), attribute.RangeToken.ToToken(),
          MutateCSharp.Schemata407.ReplaceStringConstant_1(1538L, "Members with {:only} temporarily disable the verification of other members in the entire file"));
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_39(1543L, attribute.Args.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(1539L, 1)))
                    {
                        reporter.Warning(MessageSource.Verifier, ResolutionErrors.ErrorId.r_member_only_has_no_before_after.ToString(), attribute.Args[MutateCSharp.Schemata407.ReplaceNumericConstant_6(1548L, 0)].RangeToken.ToToken(),
            MutateCSharp.Schemata407.ReplaceStringConstant_1(1552L, "{:only} on members does not support arguments"));
                    }
                }
                if (member is Field)
                {
                    var resolutionContext = new ResolutionContext(new NoContext(currentClass.EnclosingModuleDefinition), MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1553L, false));
                    scope.PushMarker();
                    if (member.IsStatic)
                    {
                        scope.AllowInstance = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1554L, false);
                    }
                    ResolveAttributes(member, resolutionContext, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1555L, true));
                    scope.PopMarker();

                }
                else if (member is Function function)
                {
                    var ec = reporter.Count(ErrorLevel.Error);
                    allTypeParameters.PushMarker();
                    ResolveTypeParameters(function.TypeArgs, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1556L, false), function);

                    function.Resolve(this);
                    allTypeParameters.PopMarker();
                    if (function is ExtremePredicate { PrefixPredicate: { } prefixPredicate } && MutateCSharp.Schemata407.ReplaceBinExprOp_7(1557L, ec, reporter.Count(ErrorLevel.Error)))
                    {
                        allTypeParameters.PushMarker();
                        ResolveTypeParameters(prefixPredicate.TypeArgs, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1562L, false), prefixPredicate);
                        prefixPredicate.Resolve(this);
                        allTypeParameters.PopMarker();
                    }

                }
                else if (member is Method method)
                {
                    var ec = reporter.Count(ErrorLevel.Error);
                    allTypeParameters.PushMarker();
                    ResolveTypeParameters(method.TypeArgs, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1563L, false), method);
                    method.Resolve(this);
                    allTypeParameters.PopMarker();
                    if (method is ExtremeLemma { PrefixLemma: { } prefixLemma } && MutateCSharp.Schemata407.ReplaceBinExprOp_7(1564L, ec, reporter.Count(ErrorLevel.Error)))
                    {
                        allTypeParameters.PushMarker();
                        ResolveTypeParameters(prefixLemma.TypeArgs, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1569L, false), prefixLemma);
                        prefixLemma.Resolve(this);
                        allTypeParameters.PopMarker();
                    }

                }
                else
                {
                    Contract.Assert(false); throw new cce.UnreachableException();  // unexpected member type
                }
                Contract.Assert(AllTypeConstraints.Count == 0);
            }
            currentClass = null;
        }

        /// <summary>
        /// Assumes type parameters have already been pushed
        /// </summary>
        void ResolveCtorTypes(DatatypeDecl/*!*/ dt, Graph<IndDatatypeDecl/*!*/>/*!*/ dependencies, Graph<CoDatatypeDecl/*!*/>/*!*/ coDependencies)
        {
            Contract.Requires(dt != null);
            Contract.Requires(dependencies != null);
            Contract.Requires(coDependencies != null);
            foreach (DatatypeCtor ctor in dt.Ctors)
            {

                ctor.EnclosingDatatype = dt;

                allTypeParameters.PushMarker();
                ResolveCtorSignature(ctor, dt.TypeArgs);
                allTypeParameters.PopMarker();

                if (dt is IndDatatypeDecl)
                {
                    // The dependencies of interest among inductive datatypes are all (inductive data)types mentioned in the parameter types
                    var idt = (IndDatatypeDecl)dt;
                    dependencies.AddVertex(idt);
                    foreach (Formal p in ctor.Formals)
                    {
                        AddDatatypeDependencyEdge(idt, p.Type, dependencies);
                    }
                }
                else
                {
                    // The dependencies of interest among codatatypes are just the top-level types of parameters.
                    var codt = (CoDatatypeDecl)dt;
                    coDependencies.AddVertex(codt);
                    foreach (var p in ctor.Formals)
                    {
                        var co = p.Type.AsCoDatatype;
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1572L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_56(1570L, co, null), () => MutateCSharp.Schemata407.ReplaceBinExprOp_57(1571L, codt.EnclosingModuleDefinition, co.EnclosingModuleDefinition)))
                        {
                            coDependencies.AddEdge(codt, co);
                        }
                    }
                }
            }
        }

        void ResolveCtorSignature(DatatypeCtor ctor, List<TypeParameter> dtTypeArguments)
        {
            Contract.Requires(ctor != null);
            Contract.Requires(ctor.EnclosingDatatype != null);
            Contract.Requires(dtTypeArguments != null);
            foreach (Formal p in ctor.Formals)
            {
                ResolveType(p.tok, p.Type, ctor.EnclosingDatatype, ResolveTypeOptionEnum.AllowPrefix, dtTypeArguments);
            }
        }

        void AddDatatypeDependencyEdge(IndDatatypeDecl dt, Type tp, Graph<IndDatatypeDecl> dependencies)
        {
            Contract.Requires(dt != null);
            Contract.Requires(tp != null);
            Contract.Requires(dependencies != null);  // more expensive check: Contract.Requires(cce.NonNullElements(dependencies));

            tp = tp.NormalizeExpand();
            var dependee = tp.AsIndDatatype;
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1580L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_58(1578L, dependee, null), () => MutateCSharp.Schemata407.ReplaceBinExprOp_57(1579L, dt.EnclosingModuleDefinition, dependee.EnclosingModuleDefinition)))
            {
                dependencies.AddEdge(dt, dependee);
                foreach (var ta in ((UserDefinedType)tp).TypeArgs)
                {
                    AddDatatypeDependencyEdge(dt, ta, dependencies);
                }
            }
        }

        public void ResolveFrameExpressionTopLevel(FrameExpression fe, FrameExpressionUse use, ICodeContext codeContext)
        {
            ResolveFrameExpression(fe, use, new ResolutionContext(codeContext, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1586L, false)));
        }

        public void ResolveFrameExpression(FrameExpression fe, FrameExpressionUse use, ResolutionContext resolutionContext)
        {
            Contract.Requires(fe != null);
            Contract.Requires(resolutionContext != null);

            ResolveExpression(fe.E, resolutionContext);
            Type t = fe.E.Type;
            Contract.Assert(t != null);  // follows from postcondition of ResolveExpression
            var eventualRefType = new InferredTypeProxy();
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_59(1587L, use, FrameExpressionUse.Reads))
            {
                AddXConstraint(fe.E.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(1588L, "ReadsFrame"), t, eventualRefType,
        MutateCSharp.Schemata407.ReplaceStringConstant_1(1589L, "a reads-clause expression must denote an object, a set/iset/multiset/seq of objects, or a function to a set/iset/multiset/seq of objects (instead got {0})"));
            }
            else
            {
                AddXConstraint(fe.E.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(1590L, "ModifiesFrame"), t, eventualRefType,
        MutateCSharp.Schemata407.ReplaceBinExprOp_59(1591L, use, FrameExpressionUse.Modifies) ? MutateCSharp.Schemata407.ReplaceStringConstant_1(1592L, "a modifies-clause expression must denote an object or a set/iset/multiset/seq of objects (instead got {0})") : MutateCSharp.Schemata407.ReplaceStringConstant_1(1593L, "an unchanged expression must denote an object or a set/iset/multiset/seq of objects (instead got {0})"));
            }
            if (fe.FieldName != null)
            {
                var member = ResolveMember(fe.E.tok, eventualRefType, fe.FieldName, out var tentativeReceiverType);
                var ctype = (UserDefinedType)tentativeReceiverType;  // correctness of cast follows from the DenotesClass test above
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_17(1594L, member, null))
                {
                    // error has already been reported by ResolveMember
                }
                else if (!(member is Field))
                {
                    reporter.Error(MessageSource.Resolver, fe.E, MutateCSharp.Schemata407.ReplaceStringConstant_1(1595L, "member {0} in type {1} does not refer to a field"), fe.FieldName, ctype.Name);
                }
                else if (member is ConstantField)
                {
                    reporter.Error(MessageSource.Resolver, fe.E, MutateCSharp.Schemata407.ReplaceStringConstant_1(1596L, "expression is not allowed to refer to constant field {0}"), fe.FieldName);
                }
                else
                {
                    Contract.Assert(ctype != null && ctype.ResolvedClass != null);  // follows from postcondition of ResolveMember
                    fe.Field = (Field)member;
                }
            }
        }

        void ResolveIterator(IteratorDecl iter)
        {
            Contract.Requires(iter != null);
            Contract.Requires(currentClass == null);
            Contract.Ensures(currentClass == null);

            var initialErrorCount = reporter.Count(ErrorLevel.Error);

            // Add in-parameters to the scope, but don't care about any duplication errors, since they have already been reported
            scope.PushMarker();
            scope.AllowInstance = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1597L, false);  // disallow 'this' from use, which means that the special fields and methods added are not accessible in the syntactically given spec
            iter.Ins.ForEach(p => scope.Push(p.Name, p));
            ResolveParameterDefaultValues(iter.Ins, new ResolutionContext(iter, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1598L, false)));

            // Start resolving specification...
            // we start with the decreases clause, because the _decreases<n> fields were only given type proxies before; we'll know
            // the types only after resolving the decreases clause (and it may be that some of resolution has already seen uses of
            // these fields; so, with no further ado, here we go
            ResolveAttributes(iter.Decreases, new ResolutionContext(iter, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1599L, false)));
            Contract.Assert(iter.Decreases.Expressions.Count == iter.DecreasesFields.Count);
            for (var i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(1600L, 0); MutateCSharp.Schemata407.ReplaceBinExprOp_12(1604L, i, iter.Decreases.Expressions.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(1609L, ref i))
            {
                var e = iter.Decreases.Expressions[i];
                ResolveExpression(e, new ResolutionContext(iter, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1610L, false)));
                // any type is fine, but associate this type with the corresponding _decreases<n> field
                var d = iter.DecreasesFields[i];
                // If the following type constraint does not hold, then: Bummer, there was a use--and a bad use--of the field before, so this won't be the best of error messages
                ConstrainSubtypeRelation(d.Type, e.Type, e, MutateCSharp.Schemata407.ReplaceStringConstant_1(1611L, "type of field {0} is {1}, but has been constrained elsewhere to be of type {2}"), d.Name, e.Type, d.Type);
            }
            foreach (FrameExpression fe in iter.Reads.Expressions)
            {
                ResolveFrameExpressionTopLevel(fe, FrameExpressionUse.Reads, iter);
            }
            ResolveAttributes(iter.Modifies, new ResolutionContext(iter, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1612L, false)));
            foreach (FrameExpression fe in iter.Modifies.Expressions)
            {
                ResolveFrameExpressionTopLevel(fe, FrameExpressionUse.Modifies, iter);
            }
            foreach (AttributedExpression e in iter.Requires)
            {
                ResolveAttributes(e, new ResolutionContext(iter, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1613L, false)));
                ResolveExpression(e.E, new ResolutionContext(iter, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1614L, false)));
                Contract.Assert(e.E.Type != null);  // follows from postcondition of ResolveExpression
                ConstrainTypeExprBool(e.E, MutateCSharp.Schemata407.ReplaceStringConstant_1(1615L, "Precondition must be a boolean (got {0})"));
            }

            scope.PopMarker();  // for the in-parameters

            // We resolve the rest of the specification in an instance context.  So mentions of the in- or yield-parameters
            // get resolved as field dereferences (with an implicit "this")
            scope.PushMarker();
            currentClass = iter;
            Contract.Assert(scope.AllowInstance);

            foreach (AttributedExpression e in iter.YieldRequires)
            {
                ResolveAttributes(e, new ResolutionContext(iter, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1616L, false)));
                ResolveExpression(e.E, new ResolutionContext(iter, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1617L, false)));
                Contract.Assert(e.E.Type != null);  // follows from postcondition of ResolveExpression
                ConstrainTypeExprBool(e.E, MutateCSharp.Schemata407.ReplaceStringConstant_1(1618L, "Yield precondition must be a boolean (got {0})"));
            }
            foreach (AttributedExpression e in iter.YieldEnsures)
            {
                ResolveAttributes(e, new ResolutionContext(iter, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1619L, true)));
                ResolveExpression(e.E, new ResolutionContext(iter, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1620L, true)));
                Contract.Assert(e.E.Type != null);  // follows from postcondition of ResolveExpression
                ConstrainTypeExprBool(e.E, MutateCSharp.Schemata407.ReplaceStringConstant_1(1621L, "Yield postcondition must be a boolean (got {0})"));
            }
            foreach (AttributedExpression e in iter.Ensures)
            {
                ResolveAttributes(e, new ResolutionContext(iter, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1622L, true)));
                ResolveExpression(e.E, new ResolutionContext(iter, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1623L, true)));
                Contract.Assert(e.E.Type != null);  // follows from postcondition of ResolveExpression
                ConstrainTypeExprBool(e.E, MutateCSharp.Schemata407.ReplaceStringConstant_1(1624L, "Postcondition must be a boolean (got {0})"));
            }
            SolveAllTypeConstraints();

            var postSpecErrorCount = reporter.Count(ErrorLevel.Error);

            // Resolve body
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_60(1625L, iter.Body, null))
            {
                DominatingStatementLabels.PushMarker();
                foreach (var req in iter.Requires)
                {
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_61(1626L, req.Label, null))
                    {
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_62(1627L, DominatingStatementLabels.Find(req.Label.Name), null))
                        {
                            reporter.Error(MessageSource.Resolver, req.Label.Tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(1628L, "assert label shadows a dominating label"));
                        }
                        else
                        {
                            var rr = DominatingStatementLabels.Push(req.Label.Name, req.Label);
                            Contract.Assert(rr == Scope<Label>.PushResult.Success);  // since we just checked for duplicates, we expect the Push to succeed
                        }
                    }
                }
                ResolveBlockStatement(iter.Body, ResolutionContext.FromCodeContext(iter));
                DominatingStatementLabels.PopMarker();
                SolveAllTypeConstraints();
            }

            currentClass = null;
            scope.PopMarker();  // pop off the AllowInstance setting

            if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(1629L, postSpecErrorCount, initialErrorCount))
            {
                iter.CreateIteratorMethodSpecs(this);
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
                    reporter.Error(MessageSource.Resolver, lhs, MutateCSharp.Schemata407.ReplaceStringConstant_1(1634L, "LHS of assignment must denote a mutable variable"));
                }
            }
            else if (lhs is MemberSelectExpr)
            {
                var ll = (MemberSelectExpr)lhs;
                var field = ll.Member as Field;
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_32(1636L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_63(1635L, field, null), () => !field.IsUserMutable))
                {
                    if (resolutionContext.InFirstPhaseConstructor && field is ConstantField cf && !cf.IsStatic && MutateCSharp.Schemata407.ReplaceBinExprOp_64(1642L, cf.Rhs, null))
                    {
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_65(1643L, Expression.AsThis(ll.Obj), null))
                        {
                            // it's cool; this field can be assigned to here
                        }
                        else
                        {
                            reporter.Error(MessageSource.Resolver, lhs, MutateCSharp.Schemata407.ReplaceStringConstant_1(1644L, "LHS of assignment must denote a mutable field of 'this'"));
                        }
                    }
                    else
                    {
                        reporter.Error(MessageSource.Resolver, lhs, MutateCSharp.Schemata407.ReplaceStringConstant_1(1645L, "LHS of assignment must denote a mutable field"));
                    }
                }
            }
            else if (lhs is SeqSelectExpr)
            {
                var ll = (SeqSelectExpr)lhs;
                ConstrainSubtypeRelation(ResolvedArrayType(ll.Seq.tok, MutateCSharp.Schemata407.ReplaceNumericConstant_6(1646L, 1), new InferredTypeProxy(), resolutionContext, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1650L, true)), ll.Seq.Type, ll.Seq,
        MutateCSharp.Schemata407.ReplaceStringConstant_1(1651L, "LHS of array assignment must denote an array element (found {0})"), ll.Seq.Type);
                if (!ll.SelectOne)
                {
                    reporter.Error(MessageSource.Resolver, ll, MutateCSharp.Schemata407.ReplaceStringConstant_1(1652L, "cannot assign to a range of array elements (try the 'forall' statement)"));
                }
            }
            else if (lhs is MultiSelectExpr)
            {
                // nothing to check; this can only denote an array element
            }
            else
            {
                reporter.Error(MessageSource.Resolver, lhs, MutateCSharp.Schemata407.ReplaceStringConstant_1(1653L, "LHS of assignment must denote a mutable variable or field"));
            }
        }

        public void ResolveBlockStatement(BlockStmt blockStmt, ResolutionContext resolutionContext)
        {
            Contract.Requires(blockStmt != null);
            Contract.Requires(resolutionContext != null);

            if (blockStmt is DividedBlockStmt)
            {
                var div = (DividedBlockStmt)blockStmt;
                Contract.Assert(currentMethod is Constructor);  // divided bodies occur only in class constructors
                Contract.Assert(!resolutionContext.InFirstPhaseConstructor);  // divided bodies are never nested
                foreach (Statement ss in div.BodyInit)
                {
                    ResolveStatementWithLabels(ss, resolutionContext with { InFirstPhaseConstructor = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1654L, true) });
                }
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

        public void ResolveStatementWithLabels(Statement stmt, ResolutionContext resolutionContext)
        {
            Contract.Requires(stmt != null);
            Contract.Requires(resolutionContext != null);

            EnclosingStatementLabels.PushMarker();
            // push labels
            for (var l = stmt.Labels; MutateCSharp.Schemata407.ReplaceBinExprOp_66(1655L, l, null); l = l.Next)
            {
                var lnode = l.Data;
                Contract.Assert(lnode.Name != null);  // LabelNode's with .Label==null are added only during resolution of the break statements with 'stmt' as their target, which hasn't happened yet
                var prev = EnclosingStatementLabels.Find(lnode.Name);
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_67(1656L, prev, stmt))
                {
                    reporter.Error(MessageSource.Resolver, lnode.Tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(1657L, "duplicate label"));
                }
                else if (MutateCSharp.Schemata407.ReplaceBinExprOp_68(1658L, prev, null))
                {
                    reporter.Error(MessageSource.Resolver, lnode.Tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(1659L, "label shadows an enclosing label"));
                }
                else
                {
                    var r = EnclosingStatementLabels.Push(lnode.Name, stmt);
                    Contract.Assert(r == Scope<Statement>.PushResult.Success);  // since we just checked for duplicates, we expect the Push to succeed
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_62(1660L, DominatingStatementLabels.Find(lnode.Name), null))
                    {
                        reporter.Error(MessageSource.Resolver, lnode.Tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(1661L, "label shadows a dominating label"));
                    }
                    else
                    {
                        var rr = DominatingStatementLabels.Push(lnode.Name, lnode);
                        Contract.Assert(rr == Scope<Label>.PushResult.Success);  // since we just checked for duplicates, we expect the Push to succeed
                    }
                }
            }
            ResolveStatement(stmt, resolutionContext);
            EnclosingStatementLabels.PopMarker();
        }

        void ResolveAlternatives(List<GuardedAlternative> alternatives, AlternativeLoopStmt loopToCatchBreaks, ResolutionContext resolutionContext)
        {
            Contract.Requires(alternatives != null);
            Contract.Requires(resolutionContext != null);

            // first, resolve the guards
            foreach (var alternative in alternatives)
            {
                int prevErrorCount = reporter.Count(ErrorLevel.Error);
                ResolveExpression(alternative.Guard, resolutionContext);
                Contract.Assert(alternative.Guard.Type != null);  // follows from postcondition of ResolveExpression
                bool successfullyResolved = MutateCSharp.Schemata407.ReplaceBinExprOp_7(1662L, reporter.Count(ErrorLevel.Error), prevErrorCount);
                ConstrainTypeExprBool(alternative.Guard, MutateCSharp.Schemata407.ReplaceStringConstant_1(1667L, "condition is expected to be of type bool, but is {0}"));
            }

            if (MutateCSharp.Schemata407.ReplaceBinExprOp_69(1668L, loopToCatchBreaks, null))
            {
                LoopStack.Add(loopToCatchBreaks);  // push
            }
            foreach (var alternative in alternatives)
            {
                scope.PushMarker();
                DominatingStatementLabels.PushMarker();
                if (alternative.IsBindingGuard)
                {
                    var exists = (ExistsExpr)alternative.Guard;
                    foreach (var v in exists.BoundVars)
                    {
                        ScopePushAndReport(scope, v, MutateCSharp.Schemata407.ReplaceStringConstant_1(1669L, "bound-variable"));
                    }
                }
                ResolveAttributes(alternative, resolutionContext);
                foreach (Statement ss in alternative.Body)
                {
                    ResolveStatementWithLabels(ss, resolutionContext);
                }
                DominatingStatementLabels.PopMarker();
                scope.PopMarker();
            }
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_69(1670L, loopToCatchBreaks, null))
            {
                LoopStack.RemoveAt(MutateCSharp.Schemata407.ReplaceBinExprOp_70(1675L, LoopStack.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(1671L, 1)));  // pop
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
            bool isInitCall = MutateCSharp.Schemata407.ReplaceBinExprOp_14(1684L, receiverType, null);

            var callee = s.Method;
            Contract.Assert(callee != null);  // follows from the invariant of CallStmt
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1685L, () => !isInitCall, () => callee is Constructor))
            {
                reporter.Error(MessageSource.Resolver, s, MutateCSharp.Schemata407.ReplaceStringConstant_1(1691L, "a constructor is allowed to be called only when an object is being allocated"));
            }

            // resolve left-hand sides (the right-hand sides are resolved below)
            foreach (var lhs in s.Lhs)
            {
                Contract.Assume(lhs.Type != null);  // a sanity check that LHSs have already been resolved
            }

            bool tryToResolve = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1692L, false);
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_21(1693L, callee.Outs.Count, s.Lhs.Count))
            {
                if (isInitCall)
                {
                    reporter.Error(MessageSource.Resolver, s, MutateCSharp.Schemata407.ReplaceStringConstant_1(1698L, "a method called as an initialization method must not have any result arguments"));
                }
                else
                {
                    reporter.Error(MessageSource.Resolver, s,
          MutateCSharp.Schemata407.ReplaceStringConstant_1(1699L, "the method returns {1} value{3} but is assigned to {0} variable{2} (all return values must be assigned)"),
                      s.Lhs.Count, callee.Outs.Count, MutateCSharp.Schemata407.ReplaceBinExprOp_19(1704L, s.Lhs.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(1700L, 1)) ? MutateCSharp.Schemata407.ReplaceStringConstant_1(1709L, "s") : "", MutateCSharp.Schemata407.ReplaceBinExprOp_19(1714L, callee.Outs.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(1710L, 1)) ? MutateCSharp.Schemata407.ReplaceStringConstant_1(1719L, "s") : "");
                    tryToResolve = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1720L, true);
                }
            }
            else
            {
                if (isInitCall)
                {
                    if (callee.IsStatic)
                    {
                        reporter.Error(MessageSource.Resolver, s.Tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(1721L, "a method called as an initialization method must not be 'static'"));
                    }
                    else
                    {
                        tryToResolve = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1722L, true);
                    }
                }
                else if (!callee.IsStatic)
                {
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1723L, () => !scope.AllowInstance, () => s.Receiver is ThisExpr))
                    {
                        // The call really needs an instance, but that instance is given as 'this', which is not
                        // available in this context.  For more details, see comment in the resolution of a
                        // FunctionCallExpr.
                        reporter.Error(MessageSource.Resolver, s.Receiver, MutateCSharp.Schemata407.ReplaceStringConstant_1(1729L, "'this' is not allowed in a 'static' context"));
                    }
                    else if (s.Receiver is StaticReceiverExpr)
                    {
                        reporter.Error(MessageSource.Resolver, s.Receiver, MutateCSharp.Schemata407.ReplaceStringConstant_1(1730L, "call to instance method requires an instance"));
                    }
                    else
                    {
                        tryToResolve = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1731L, true);
                    }
                }
                else
                {
                    tryToResolve = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1732L, true);
                }
            }

            if (tryToResolve)
            {
                var typeMap = s.MethodSelect.TypeArgumentSubstitutionsAtMemberDeclaration();
                // resolve arguments
                ResolveActualParameters(s.Bindings, callee.Ins, s.Tok, callee, resolutionContext, typeMap,
                  callee.IsStatic ? null : s.Receiver);
                // type check the out-parameter arguments (in-parameters were type checked as part of ResolveActualParameters)
                for (int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(1733L, 0); MutateCSharp.Schemata407.ReplaceBinExprOp_9(1747L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_12(1737L, i, callee.Outs.Count), () => MutateCSharp.Schemata407.ReplaceBinExprOp_12(1742L, i, s.Lhs.Count)); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(1753L, ref i))
                {
                    var outFormal = callee.Outs[i];
                    var it = outFormal.Type;
                    Type st = it.Subst(typeMap);
                    var lhs = s.Lhs[i];
                    var what = GetLocationInformation(outFormal, callee.Outs.Count(), i, MutateCSharp.Schemata407.ReplaceStringConstant_1(1754L, "method out-parameter"));

                    AddAssignableConstraint(
                      s.Tok, lhs.Type, st,
                      $"incorrect return type {what} (expected {{1}}, got {{0}})");
                }
                for (int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(1755L, 0); MutateCSharp.Schemata407.ReplaceBinExprOp_12(1759L, i, s.Lhs.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(1764L, ref i))
                {
                    var lhs = s.Lhs[i];
                    // LHS must denote a mutable field.
                    CheckIsLvalue(lhs.Resolved, resolutionContext);
                }
            }
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1765L, () => Contract.Exists(callee.Decreases.Expressions, e => e is WildcardExpr), () => !resolutionContext.CodeContext.AllowsNontermination))
            {
                reporter.Error(MessageSource.Resolver, s.Tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(1771L, "a call to a possibly non-terminating method is allowed only if the calling method is also declared (with 'decreases *') to be possibly non-terminating"));
            }
        }

        /// <summary>
        /// Resolve the actual arguments given in "bindings". Then, check that there is exactly one
        /// actual for each formal, and impose assignable constraints.
        /// "typeMap" is applied to the type of each formal.
        /// This method should be called only once. That is, bindings.arguments is required to be null on entry to this method.
        /// </summary>
        void ResolveActualParameters(ActualBindings bindings, List<Formal> formals, IToken callTok, object context, ResolutionContext resolutionContext,
          Dictionary<TypeParameter, Type> typeMap, Expression/*?*/ receiver)
        {
            Contract.Requires(bindings != null);
            Contract.Requires(formals != null);
            Contract.Requires(callTok != null);
            Contract.Requires(context is Method || context is Function || context is DatatypeCtor || context is ArrowType);
            Contract.Requires(typeMap != null);
            Contract.Requires(!bindings.WasResolved);

            string whatKind;
            string name;
            if (context is Method cMethod)
            {
                whatKind = cMethod.WhatKind;
                name = $"{whatKind} '{cMethod.Name}'";
            }
            else if (context is Function cFunction)
            {
                whatKind = cFunction.WhatKind;
                name = $"{whatKind} '{cFunction.Name}'";
            }
            else if (context is DatatypeCtor cCtor)
            {
                whatKind = MutateCSharp.Schemata407.ReplaceStringConstant_1(1772L, "datatype constructor");
                name = $"{whatKind} '{cCtor.Name}'";
            }
            else
            {
                var cArrowType = (ArrowType)context;
                whatKind = MutateCSharp.Schemata407.ReplaceStringConstant_1(1773L, "function application");
                name = $"function type '{cArrowType}'";
            }

            // If all arguments are passed positionally, use simple error messages that talk about the count of arguments.
            var onlyPositionalArguments = bindings.ArgumentBindings.TrueForAll(binding => MutateCSharp.Schemata407.ReplaceBinExprOp_71(1774L, binding.FormalParameterName, null));
            var simpleErrorReported = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1775L, false);
            if (onlyPositionalArguments)
            {
                var requiredParametersCount = formals.Count(f => MutateCSharp.Schemata407.ReplaceBinExprOp_64(1776L, f.DefaultValue, null));
                var actualsCounts = bindings.ArgumentBindings.Count;
                var sig = "";
                for (int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(1777L, 0); MutateCSharp.Schemata407.ReplaceBinExprOp_12(1781L, i, formals.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(1786L, ref i))
                {
                    sig += (MutateCSharp.Schemata407.ReplaceStringConstant_1(1787L, ", ") + formals[i].Name + MutateCSharp.Schemata407.ReplaceStringConstant_1(1788L, ": ") + formals[i].Type.ToString());
                }
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_19(1793L, formals.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(1789L, 0)))
                {
                    sig = MutateCSharp.Schemata407.ReplaceStringConstant_1(1798L, ": (") + sig[2..] + MutateCSharp.Schemata407.ReplaceStringConstant_1(1799L, ")");
                }
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1810L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_40(1800L, requiredParametersCount, actualsCounts), () => MutateCSharp.Schemata407.ReplaceBinExprOp_40(1805L, actualsCounts, formals.Count)))
                {
                    // the situation is plausible
                }
                else if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(1816L, requiredParametersCount, formals.Count))
                {
                    // this is the common, classical case of no default parameter values; generate a straightforward error message
                    reporter.Error(MessageSource.Resolver, callTok, $"wrong number of arguments (got {actualsCounts}, but {name} expects {formals.Count}{sig})");
                    simpleErrorReported = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1821L, true);
                }
                else if (MutateCSharp.Schemata407.ReplaceBinExprOp_12(1822L, actualsCounts, requiredParametersCount))
                {
                    reporter.Error(MessageSource.Resolver, callTok, $"wrong number of arguments (got {actualsCounts}, but {name} expects at least {requiredParametersCount}{sig})");
                    simpleErrorReported = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1827L, true);
                }
                else
                {
                    reporter.Error(MessageSource.Resolver, callTok, $"wrong number of arguments (got {actualsCounts}, but {name} expects at most {formals.Count}{sig})");
                    simpleErrorReported = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1828L, true);
                }
            }

            // resolve given arguments and populate the "namesToActuals" map
            var namesToActuals = new Dictionary<string, ActualBinding>();
            formals.ForEach(f => namesToActuals.Add(f.Name, null)); // a name mapping to "null" says it hasn't been filled in yet
            var stillAcceptingPositionalArguments = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1829L, true);
            var bindingIndex = MutateCSharp.Schemata407.ReplaceNumericConstant_6(1830L, 0);
            foreach (var binding in bindings.ArgumentBindings)
            {
                var arg = binding.Actual;
                // insert the actual into "namesToActuals" under an appropriate name, unless there is an error
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_72(1834L, binding.FormalParameterName, null))
                {
                    var pname = binding.FormalParameterName.val;
                    stillAcceptingPositionalArguments = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1835L, false);
                    if (!namesToActuals.TryGetValue(pname, out var b))
                    {
                        reporter.Error(MessageSource.Resolver, binding.FormalParameterName, $"the binding named '{pname}' does not correspond to any formal parameter");
                    }
                    else if (MutateCSharp.Schemata407.ReplaceBinExprOp_73(1836L, b, null))
                    {
                        // all is good
                        namesToActuals[pname] = binding;
                    }
                    else if (MutateCSharp.Schemata407.ReplaceBinExprOp_71(1837L, b.FormalParameterName, null))
                    {
                        reporter.Error(MessageSource.Resolver, binding.FormalParameterName, $"the parameter named '{pname}' is already given positionally");
                    }
                    else
                    {
                        reporter.Error(MessageSource.Resolver, binding.FormalParameterName, $"duplicate binding for parameter name '{pname}'");
                    }
                }
                else if (!stillAcceptingPositionalArguments)
                {
                    reporter.Error(MessageSource.Resolver, arg.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(1838L, "a positional argument is not allowed to follow named arguments"));
                }
                else if (MutateCSharp.Schemata407.ReplaceBinExprOp_12(1839L, bindingIndex, formals.Count))
                {
                    // use the name of formal corresponding to this positional argument, unless the parameter is named-only
                    var formal = formals[bindingIndex];
                    var pname = formal.Name;
                    if (formal.IsNameOnly)
                    {
                        reporter.Error(MessageSource.Resolver, arg.tok,
                          $"nameonly parameter '{pname}' must be passed using a name binding; it cannot be passed positionally");
                    }
                    Contract.Assert(namesToActuals[pname] == null); // we expect this, since we've only filled parameters positionally so far
                    namesToActuals[pname] = binding;
                }
                else
                {
                    // too many positional arguments
                    if (onlyPositionalArguments)
                    {
                        // error was reported before the "foreach" loop
                        Contract.Assert(simpleErrorReported);
                    }
                    else if (MutateCSharp.Schemata407.ReplaceBinExprOp_12(1844L, formals.Count, bindingIndex))
                    {
                        // error was reported on a previous iteration of this "foreach" loop
                    }
                    else
                    {
                        reporter.Error(MessageSource.Resolver, callTok,
                          $"wrong number of arguments ({name} expects {formals.Count}, got {bindings.ArgumentBindings.Count})");
                    }
                }

                // resolve argument
                ResolveExpression(arg, resolutionContext);
                MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(1849L, ref bindingIndex);
            }

            var actuals = new List<Expression>();
            var formalIndex = MutateCSharp.Schemata407.ReplaceNumericConstant_6(1850L, 0);
            var substMap = new Dictionary<IVariable, Expression>();
            foreach (var formal in formals)
            {
                var b = namesToActuals[formal.Name];
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_74(1854L, b, null))
                {
                    actuals.Add(b.Actual);
                    substMap.Add(formal, b.Actual);
                    var what = GetLocationInformation(formal,
                      bindings.ArgumentBindings.Count(), bindings.ArgumentBindings.IndexOf(b),
                      whatKind + (context is Method ? MutateCSharp.Schemata407.ReplaceStringConstant_1(1855L, " in-parameter") : MutateCSharp.Schemata407.ReplaceStringConstant_1(1856L, " parameter")));

                    AddAssignableConstraint(
                      callTok, formal.Type.Subst(typeMap), b.Actual.Type,
                      $"incorrect argument type {what} (expected {{0}}, found {{1}})");
                }
                else if (MutateCSharp.Schemata407.ReplaceBinExprOp_4(1857L, formal.DefaultValue, null))
                {
                    // Note, in the following line, "substMap" is passed in, but it hasn't been fully filled in until the
                    // end of this foreach loop. Still, that's soon enough, because DefaultValueExpression won't use it
                    // until FillInDefaultValueExpressions at the end of Pass 0 of the Resolver.
                    var n = new DefaultValueExpressionType(callTok, formal, receiver, substMap, typeMap) { Type = formal.Type.Subst(typeMap) };
                    allDefaultValueExpressions.Add(n);
                    actuals.Add(n);
                    substMap.Add(formal, n);
                }
                else
                {
                    // parameter has no value
                    if (!simpleErrorReported)
                    {
                        var formalDescription = whatKind + (context is Method ? MutateCSharp.Schemata407.ReplaceStringConstant_1(1858L, " in-parameter") : MutateCSharp.Schemata407.ReplaceStringConstant_1(1859L, " parameter"));
                        var nameWithIndex = MutateCSharp.Schemata407.ReplaceBinExprOp_9(1860L, () => formal.HasName, () => formal is not ImplicitFormal) ? MutateCSharp.Schemata407.ReplaceStringConstant_1(1866L, "'") + formal.Name + MutateCSharp.Schemata407.ReplaceStringConstant_1(1867L, "'") : "";
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_32(1878L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_19(1872L, formals.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(1868L, 1)), () => MutateCSharp.Schemata407.ReplaceBinExprOp_51(1877L, nameWithIndex, "")))
                        {
                            nameWithIndex += MutateCSharp.Schemata407.ReplaceBinExprOp_51(1884L, nameWithIndex, "") ? "" : MutateCSharp.Schemata407.ReplaceStringConstant_1(1885L, " ");
                            nameWithIndex += $"at index {formalIndex}";
                        }

                        var message = $"{formalDescription} {nameWithIndex} requires an argument of type {formal.Type}";
                        reporter.Error(MessageSource.Resolver, callTok, message);
                    }
                }

                MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(1886L, ref formalIndex);
            }

            bindings.AcceptArgumentExpressionsAsExactParameterList(actuals);
        }

        private static string GetLocationInformation(Formal parameter, int bindingCount, int bindingIndex, string formalDescription)
        {
            var displayName = MutateCSharp.Schemata407.ReplaceBinExprOp_9(1887L, () => parameter.HasName, () => parameter is not ImplicitFormal);
            var description = "";
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_19(1897L, bindingCount, MutateCSharp.Schemata407.ReplaceNumericConstant_6(1893L, 1)))
            {
                description += $"at index {bindingIndex} ";
            }

            description += $"for {formalDescription}";

            if (displayName)
            {
                description += $" '{parameter.Name}'";
            }

            return description;
        }

        /// <summary>
        /// To resolve "id" in expression "E . id", do:
        ///  * If E denotes a module name M:
        ///      0. Member of module M:  sub-module (including submodules of imports), class, datatype, etc.
        ///         (if two imported types have the same name, an error message is produced here)
        ///      1. Static member of M._default denoting an async task type
        ///    (Note that in contrast to ResolveNameSegment_Type, imported modules, etc. are ignored)
        ///  * If E denotes a type:
        ///      2. a. Member of that type denoting an async task type, or:
        ///         b. If allowDanglingDotName:
        ///            Return the type "E" and the given "expr", letting the caller try to make sense of the final dot-name.
        ///
        /// Note: 1 and 2a are not used now, but they will be of interest when async task types are supported.
        /// </summary>
        ResolveTypeReturn ResolveDotSuffix_Type(ExprDotName expr, ResolutionContext resolutionContext, bool allowDanglingDotName, ResolveTypeOption option, List<TypeParameter> defaultTypeArguments)
        {
            Contract.Requires(expr != null);
            Contract.Requires(!expr.WasResolved());
            Contract.Requires(expr.Lhs is NameSegment || expr.Lhs is ExprDotName);
            Contract.Requires(resolutionContext != null);
            Contract.Ensures(Contract.Result<ResolveTypeReturn>() == null || allowDanglingDotName);

            // resolve the LHS expression
            if (expr.Lhs is NameSegment)
            {
                ResolveNameSegment_Type((NameSegment)expr.Lhs, resolutionContext, option, defaultTypeArguments);
            }
            else
            {
                ResolveDotSuffix_Type((ExprDotName)expr.Lhs, resolutionContext, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1902L, false), option, defaultTypeArguments);
            }

            if (MutateCSharp.Schemata407.ReplaceBinExprOp_75(1903L, expr.OptTypeArguments, null))
            {
                foreach (var ty in expr.OptTypeArguments)
                {
                    ResolveType(expr.tok, ty, resolutionContext, option, defaultTypeArguments);
                }
            }

            Expression r = null;  // the resolved expression, if successful

            var lhs = expr.Lhs.Resolved;
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1905L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_4(1904L, lhs, null), () => lhs.Type is Resolver_IdentifierExpr.ResolverType_Module))
            {
                var ri = (Resolver_IdentifierExpr)lhs;
                var sig = ((ModuleDecl)ri.Decl).AccessibleSignature(MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1911L, false));
                sig = GetSignature(sig);
                // For 0:

                if (sig.TopLevels.TryGetValue(expr.SuffixName, out var decl))
                {
                    // ----- 0. Member of the specified module
                    if (decl is AmbiguousTopLevelDecl)
                    {
                        var ad = (AmbiguousTopLevelDecl)decl;
                        reporter.Error(MessageSource.Resolver, expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(1912L, "The name {0} ambiguously refers to a type in one of the modules {1} (try qualifying the type name with the module name)"), expr.SuffixName, ad.ModuleNames());
                    }
                    else
                    {
                        // We have found a module name or a type name.  We create a temporary expression that will never be seen by the compiler
                        // or verifier, just to have a placeholder where we can recorded what we have found.
                        r = CreateResolver_IdentifierExpr(expr.tok, expr.SuffixName, expr.OptTypeArguments, decl);
                    }
#if ASYNC_TASK_TYPES
        } else if (sig.StaticMembers.TryGetValue(expr.SuffixName, out member)) {
          // ----- 1. static member of the specified module
          Contract.Assert(member.IsStatic); // moduleInfo.StaticMembers is supposed to contain only static members of the module's implicit class _default
          if (ReallyAmbiguousThing(ref member)) {
            reporter.Error(MessageSource.Resolver, expr.tok, "The name {0} ambiguously refers to a static member in one of the modules {1} (try qualifying the member name with the module name)", expr.SuffixName, ((AmbiguousMemberDecl)member).ModuleNames());
          } else {
            var receiver = new StaticReceiverExpr(expr.tok, (ClassLikeDecl)member.EnclosingClass);
            r = ResolveExprDotCall(expr.tok, receiver, member, expr.OptTypeArguments, opts.resolutionContext, allowMethodCall);
          }
#endif
                }
                else
                {
                    reporter.Error(MessageSource.Resolver, expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(1913L, "module '{0}' does not declare a type '{1}'"), ri.Decl.Name, expr.SuffixName);
                }

            }
            else if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1915L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_4(1914L, lhs, null), () => lhs.Type is Resolver_IdentifierExpr.ResolverType_Type))
            {
                var ri = (Resolver_IdentifierExpr)lhs;
                // ----- 2. Look up name in type
                var ty = new UserDefinedType(ri.tok, ri.Decl.Name, ri.Decl, ri.TypeArgs);
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1921L, () => allowDanglingDotName, () => ty.IsRefType))
                {
                    return new ResolveTypeReturn(ty, expr);
                }
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_64(1927L, r, null))
                {
                    reporter.Error(MessageSource.Resolver, expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(1928L, "member '{0}' does not exist in type '{1}' or cannot be part of type name"), expr.SuffixName, ri.Decl.Name);
                }
            }

            if (MutateCSharp.Schemata407.ReplaceBinExprOp_64(1929L, r, null))
            {
                // an error has been reported above; we won't fill in .ResolvedExpression, but we still must fill in .Type
                expr.Type = new InferredTypeProxy();
            }
            else
            {
                expr.ResolvedExpression = r;
                expr.Type = r.Type;
            }
            return null;
        }

        internal Resolver_IdentifierExpr CreateResolver_IdentifierExpr(IToken tok, string name, List<Type> optTypeArguments, TopLevelDecl decl)
        {
            Contract.Requires(tok != null);
            Contract.Requires(name != null);
            Contract.Requires(decl != null);
            Contract.Ensures(Contract.Result<Resolver_IdentifierExpr>() != null);

            if (!moduleInfo.IsAbstract)
            {
                if (decl is ModuleDecl md && md.Signature.IsAbstract)
                {
                    reporter.Error(MessageSource.Resolver, tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(1930L, "a compiled module is not allowed to use an abstract module ({0})"), decl.Name);
                }
            }
            var n = MutateCSharp.Schemata407.ReplaceBinExprOp_76(1931L, optTypeArguments, null) ? MutateCSharp.Schemata407.ReplaceNumericConstant_6(1932L, 0) : optTypeArguments.Count;
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_75(1936L, optTypeArguments, null))
            {
                // type arguments were supplied; they must be equal in number to those expected
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_21(1937L, n, decl.TypeArgs.Count))
                {
                    reporter.Error(MessageSource.Resolver, tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(1942L, "Wrong number of type arguments ({0} instead of {1}) passed to {2}: {3}"), n, decl.TypeArgs.Count, decl.WhatKind, name);
                }
            }
            List<Type> tpArgs = new List<Type>();
            for (int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(1943L, 0); MutateCSharp.Schemata407.ReplaceBinExprOp_12(1947L, i, decl.TypeArgs.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(1952L, ref i))
            {
                tpArgs.Add(MutateCSharp.Schemata407.ReplaceBinExprOp_12(1953L, i, n) ? optTypeArguments[i] : new InferredTypeProxy());
            }
            return new Resolver_IdentifierExpr(tok, decl, tpArgs);
        }

        public void ResolveStatement(Statement stmt, ResolutionContext resolutionContext)
        {
            Contract.Requires(stmt != null);
            Contract.Requires(resolutionContext != null);
            if (stmt is ICanResolveNewAndOld genericCanResolve)
            {
                genericCanResolve.GenResolve(this, resolutionContext);
                return;
            }

            if (stmt is ICanResolve canResolve)
            {
                canResolve.Resolve(this, resolutionContext);
                return;
            }

            if (!(MutateCSharp.Schemata407.ReplaceBinExprOp_32(1958L, () => stmt is ForallStmt, () => stmt is ForLoopStmt)))
            {  // "forall" and "for" statements do their own attribute resolution below
                ResolveAttributes(stmt, resolutionContext);
            }
            if (stmt is PrintStmt)
            {
                var s = (PrintStmt)stmt;
                s.Args.ForEach(e => ResolveExpression(e, resolutionContext));

            }
            else if (stmt is RevealStmt)
            {
                var s = (RevealStmt)stmt;
                foreach (var expr in s.Exprs)
                {
                    var name = RevealStmt.SingleName(expr);
                    var labeledAssert = name == null ? null : DominatingStatementLabels.Find(name) as AssertLabel;
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_61(1964L, labeledAssert, null))
                    {
                        s.LabeledAsserts.Add(labeledAssert);
                    }
                    else
                    {
                        var revealResolutionContext = resolutionContext with { InReveal = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1965L, true) };
                        if (expr is ApplySuffix)
                        {
                            var e = (ApplySuffix)expr;
                            var methodCallInfo = ResolveApplySuffix(e, revealResolutionContext, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1966L, true));
                            if (MutateCSharp.Schemata407.ReplaceBinExprOp_77(1967L, methodCallInfo, null))
                            {
                                // error has already been reported
                            }
                            else if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1968L, () => methodCallInfo.Callee.Member is TwoStateLemma, () => !revealResolutionContext.IsTwoState))
                            {
                                reporter.Error(MessageSource.Resolver, methodCallInfo.Tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(1974L, "a two-state function can only be revealed in a two-state context"));
                            }
                            else if (MutateCSharp.Schemata407.ReplaceBinExprOp_62(1975L, methodCallInfo.Callee.AtLabel, null))
                            {
                                Contract.Assert(methodCallInfo.Callee.Member is TwoStateLemma);
                                reporter.Error(MessageSource.Resolver, methodCallInfo.Tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(1976L, "to reveal a two-state function, do not list any parameters or @-labels"));
                            }
                            else
                            {
                                var call = new CallStmt(s.RangeToken, new List<Expression>(), methodCallInfo.Callee, methodCallInfo.ActualParameters, methodCallInfo.Tok);
                                s.ResolvedStatements.Add(call);
                            }
                        }
                        else if (expr is NameSegment or ExprDotName)
                        {
                            if (expr is NameSegment)
                            {
                                ResolveNameSegment((NameSegment)expr, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1977L, true), null, revealResolutionContext, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1978L, true));
                            }
                            else
                            {
                                ResolveDotSuffix((ExprDotName)expr, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1979L, true), null, revealResolutionContext, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(1980L, true));
                            }
                            MemberSelectExpr callee = (MemberSelectExpr)((ConcreteSyntaxExpression)expr).ResolvedExpression;
                            if (MutateCSharp.Schemata407.ReplaceBinExprOp_78(1981L, callee, null))
                            {
                            }
                            else if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1983L, () => callee.Member is Lemma or TwoStateLemma, () => Attributes.Contains(callee.Member.Attributes, MutateCSharp.Schemata407.ReplaceStringConstant_1(1982L, "axiom"))))
                            {
                                //The revealed member is a function
                                reporter.Error(MessageSource.Resolver, callee.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(1989L, "to reveal a function ({0}), append parentheses"), callee.Member.ToString().Substring(MutateCSharp.Schemata407.ReplaceNumericConstant_6(1990L, 7)));
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
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_72(1994L, s.TargetLabel, null))
                {
                    Statement target = EnclosingStatementLabels.Find(s.TargetLabel.val);
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_79(1995L, target, null))
                    {
                        reporter.Error(MessageSource.Resolver, s.TargetLabel, $"{s.Kind} label is undefined or not in scope: {s.TargetLabel.val}");
                    }
                    else if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(1996L, () => s.IsContinue, () => !(target is LoopStmt)))
                    {
                        reporter.Error(MessageSource.Resolver, s.TargetLabel, $"continue label must designate a loop: {s.TargetLabel.val}");
                    }
                    else
                    {
                        s.TargetStmt = target;
                    }
                }
                else
                {
                    Contract.Assert(1 <= s.BreakAndContinueCount); // follows from BreakStmt class invariant and the guard for this "else" branch
                    var jumpStmt = MutateCSharp.Schemata407.ReplaceBinExprOp_7(2006L, s.BreakAndContinueCount, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2002L, 1)) ?
                      $"a non-labeled '{s.Kind}' statement" :
                      $"a '{Util.Repeat(MutateCSharp.Schemata407.ReplaceBinExprOp_70(2015L, s.BreakAndContinueCount, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2011L, 1)), MutateCSharp.Schemata407.ReplaceStringConstant_1(2024L, "break "))}{s.Kind}' statement";
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(2029L, LoopStack.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2025L, 0)))
                    {
                        reporter.Error(MessageSource.Resolver, s, $"{jumpStmt} is allowed only in loops");
                    }
                    else if (MutateCSharp.Schemata407.ReplaceBinExprOp_12(2034L, LoopStack.Count, s.BreakAndContinueCount))
                    {
                        reporter.Error(MessageSource.Resolver, s,
                          $"{jumpStmt} is allowed only in contexts with {s.BreakAndContinueCount} enclosing loops, but the current context only has {LoopStack.Count}");
                    }
                    else
                    {
                        Statement target = LoopStack[MutateCSharp.Schemata407.ReplaceBinExprOp_70(2039L, LoopStack.Count, s.BreakAndContinueCount)];
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_80(2048L, target.Labels, null))
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
                var kind = stmt is YieldStmt ? MutateCSharp.Schemata407.ReplaceStringConstant_1(2049L, "yield") : MutateCSharp.Schemata407.ReplaceStringConstant_1(2050L, "return");
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(2051L, () => stmt is YieldStmt, () => !(resolutionContext.CodeContext is IteratorDecl)))
                {
                    reporter.Error(MessageSource.Resolver, stmt, MutateCSharp.Schemata407.ReplaceStringConstant_1(2057L, "yield statement is allowed only in iterators"));
                }
                else if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(2058L, () => stmt is ReturnStmt, () => !(resolutionContext.CodeContext is Method)))
                {
                    reporter.Error(MessageSource.Resolver, stmt, MutateCSharp.Schemata407.ReplaceStringConstant_1(2064L, "return statement is allowed only in method"));
                }
                else if (resolutionContext.InFirstPhaseConstructor)
                {
                    reporter.Error(MessageSource.Resolver, stmt, MutateCSharp.Schemata407.ReplaceStringConstant_1(2065L, "return statement is not allowed before 'new;' in a constructor"));
                }
                var s = (ProduceStmt)stmt;
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_81(2066L, s.Rhss, null))
                {
                    var cmc = resolutionContext.CodeContext as IMethodCodeContext;
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_82(2067L, cmc, null))
                    {
                        // an error has already been reported above
                    }
                    else if (MutateCSharp.Schemata407.ReplaceBinExprOp_21(2068L, cmc.Outs.Count, s.Rhss.Count))
                    {
                        reporter.Error(MessageSource.Resolver, s, MutateCSharp.Schemata407.ReplaceStringConstant_1(2073L, "number of {2} parameters does not match declaration (found {0}, expected {1})"), s.Rhss.Count, cmc.Outs.Count, kind);
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
                                var ident = new ImplicitIdentifierExpr(f.tok, f.Name);
                                // resolve it here to avoid capture into more closely declared local variables
                                ident.Var = f;
                                ident.Type = ident.Var.Type;
                                Contract.Assert(f.Type != null);
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
                        s.HiddenUpdate = new UpdateStmt(s.RangeToken, formals, s.Rhss, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2074L, true));
                        // resolving the update statement will check for return/yield statement specifics.
                        ResolveStatement(s.HiddenUpdate, resolutionContext);
                    }
                }
                else
                {// this is a regular return/yield statement.
                    s.HiddenUpdate = null;
                }
            }
            else if (stmt is VarDeclStmt)
            {
                var s = (VarDeclStmt)stmt;
                // We have four cases.
                Contract.Assert(s.Update == null || s.Update is AssignSuchThatStmt || s.Update is UpdateStmt || s.Update is AssignOrReturnStmt);
                // 0.  There is no .Update.  This is easy, we will just resolve the locals.
                // 1.  The .Update is an AssignSuchThatStmt.  This is also straightforward:  first
                //     resolve the locals, which adds them to the scope, and then resolve the .Update.
                // 2.  The .Update is an UpdateStmt, which, resolved, means either a CallStmt or a bunch
                //     of parallel AssignStmt's.  Here, the right-hand sides should be resolved before
                //     the local variables have been added to the scope, but the left-hand sides should
                //     resolve to the newly introduced variables.
                // 3.  The .Update is a ":-" statement, for which resolution does two steps:
                //     First, desugar, then run the regular resolution on the desugared AST.
                // To accommodate these options, we first reach into the UpdateStmt, if any, to resolve
                // the left-hand sides of the UpdateStmt.  This will have the effect of shielding them
                // from a subsequent resolution (since expression resolution will do nothing if the .Type
                // field is already assigned.
                // Alright, so it is:

                // Resolve the types of the locals
                foreach (var local in s.Locals)
                {
                    int prevErrorCount = reporter.Count(ErrorLevel.Error);
                    ResolveType(local.Tok, local.OptionalType, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(2075L, reporter.Count(ErrorLevel.Error), prevErrorCount))
                    {
                        local.type = local.OptionalType;
                    }
                    else
                    {
                        local.type = new InferredTypeProxy();
                    }
                }
                // Resolve the UpdateStmt, if any
                if (s.Update is UpdateStmt or AssignOrReturnStmt)
                {
                    // resolve the LHS
                    Contract.Assert(s.Update.Lhss.Count == s.Locals.Count);
                    for (int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(2080L, 0); MutateCSharp.Schemata407.ReplaceBinExprOp_12(2084L, i, s.Update.Lhss.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(2089L, ref i))
                    {
                        var local = s.Locals[i];
                        var lhs = (IdentifierExpr)s.Update.Lhss[i];  // the LHS in this case will be an IdentifierExpr, because that's how the parser creates the VarDeclStmt
                        Contract.Assert(lhs.Type == null);  // not yet resolved
                        lhs.Var = local;
                        lhs.Type = local.Type;
                    }
                    // resolve the whole thing
                    s.Update.Resolve(this, resolutionContext);
                }
                // Add the locals to the scope
                foreach (var local in s.Locals)
                {
                    ScopePushAndReport(scope, local, MutateCSharp.Schemata407.ReplaceStringConstant_1(2090L, "local-variable"));
                }
                // With the new locals in scope, it's now time to resolve the attributes on all the locals
                foreach (var local in s.Locals)
                {
                    ResolveAttributes(local, resolutionContext);
                }
                // Resolve the AssignSuchThatStmt, if any
                if (s.Update is AssignSuchThatStmt assignSuchThatStmt)
                {
                    assignSuchThatStmt.Resolve(this, resolutionContext);
                }
            }
            else if (stmt is VarDeclPattern)
            {
                VarDeclPattern s = (VarDeclPattern)stmt;
                foreach (var local in s.LocalVars)
                {
                    int prevErrorCount = reporter.Count(ErrorLevel.Error);
                    ResolveType(local.Tok, local.OptionalType, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(2091L, reporter.Count(ErrorLevel.Error), prevErrorCount))
                    {
                        local.type = local.OptionalType;
                    }
                    else
                    {
                        local.type = new InferredTypeProxy();
                    }
                }
                ResolveExpression(s.RHS, resolutionContext);
                ResolveCasePattern(s.LHS, s.RHS.Type, resolutionContext);
                // Check for duplicate names now, because not until after resolving the case pattern do we know if identifiers inside it refer to bound variables or nullary constructors
                var c = MutateCSharp.Schemata407.ReplaceNumericConstant_6(2096L, 0);
                foreach (var bv in s.LHS.Vars)
                {
                    ScopePushAndReport(scope, bv, MutateCSharp.Schemata407.ReplaceStringConstant_1(2100L, "local_variable"));
                    MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(2101L, ref c);
                }
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(2106L, c, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2102L, 0)))
                {
                    // Every identifier-looking thing in the pattern resolved to a constructor; that is, this LHS is a constant literal
                    reporter.Error(MessageSource.Resolver, s.LHS.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2111L, "LHS is a constant literal; to be legal, it must introduce at least one bound variable"));
                }
            }
            else if (stmt is AssignStmt)
            {
                AssignStmt s = (AssignStmt)stmt;
                int prevErrorCount = reporter.Count(ErrorLevel.Error);
                ResolveExpression(s.Lhs, resolutionContext);  // allow ghosts for now, tighted up below
                bool lhsResolvedSuccessfully = MutateCSharp.Schemata407.ReplaceBinExprOp_7(2112L, reporter.Count(ErrorLevel.Error), prevErrorCount);
                Contract.Assert(s.Lhs.Type != null);  // follows from postcondition of ResolveExpression
                                                      // check that LHS denotes a mutable variable or a field
                var lhs = s.Lhs.Resolved;
                if (lhs is IdentifierExpr)
                {
                    IVariable var = ((IdentifierExpr)lhs).Var;
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_83(2117L, var, null))
                    {
                        // the LHS didn't resolve correctly; some error would already have been reported
                    }
                    else
                    {
                        CheckIsLvalue(lhs, resolutionContext);
                    }
                }
                else if (lhs is MemberSelectExpr)
                {
                    var fse = (MemberSelectExpr)lhs;
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_84(2118L, fse.Member, null))
                    {  // otherwise, an error was reported above
                        CheckIsLvalue(fse, resolutionContext);
                    }
                }
                else if (lhs is SeqSelectExpr)
                {
                    var slhs = (SeqSelectExpr)lhs;
                    // LHS is fine, provided the "sequence" is really an array
                    if (lhsResolvedSuccessfully)
                    {
                        Contract.Assert(slhs.Seq.Type != null);
                        CheckIsLvalue(slhs, resolutionContext);
                    }
                }
                else if (lhs is MultiSelectExpr)
                {
                    CheckIsLvalue(lhs, resolutionContext);
                }
                else
                {
                    CheckIsLvalue(lhs, resolutionContext);
                }
                Type lhsType = s.Lhs.Type;
                if (s.Rhs is ExprRhs)
                {
                    ExprRhs rr = (ExprRhs)s.Rhs;
                    ResolveExpression(rr.Expr, resolutionContext);
                    Contract.Assert(rr.Expr.Type != null);  // follows from postcondition of ResolveExpression

                    if (s.Lhs is ImplicitIdentifierExpr { Var: Formal { InParam: false } })
                    {
                        AddAssignableConstraint(stmt.Tok, lhsType, rr.Expr.Type, MutateCSharp.Schemata407.ReplaceStringConstant_1(2119L, "Method return value mismatch (expected {0}, got {1})"));
                    }
                    else
                    {
                        AddAssignableConstraint(stmt.Tok, lhsType, rr.Expr.Type, MutateCSharp.Schemata407.ReplaceStringConstant_1(2120L, "RHS (of type {1}) not assignable to LHS (of type {0})"));
                    }
                }
                else if (s.Rhs is TypeRhs)
                {
                    TypeRhs rr = (TypeRhs)s.Rhs;
                    ResolveTypeRhs(rr, stmt, resolutionContext);
                    AddAssignableConstraint(stmt.Tok, lhsType, rr.Type, MutateCSharp.Schemata407.ReplaceStringConstant_1(2121L, "type {1} is not assignable to LHS (of type {0})"));
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
            else if (stmt is CallStmt)
            {
                CallStmt s = (CallStmt)stmt;
                ResolveCallStmt(s, resolutionContext, null);

            }
            else if (stmt is BlockStmt)
            {
                var s = (BlockStmt)stmt;
                scope.PushMarker();
                ResolveBlockStatement(s, resolutionContext);
                scope.PopMarker();

            }
            else if (stmt is IfStmt)
            {
                IfStmt s = (IfStmt)stmt;
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_4(2122L, s.Guard, null))
                {
                    ResolveExpression(s.Guard, resolutionContext);
                    Contract.Assert(s.Guard.Type != null);  // follows from postcondition of ResolveExpression
                    ConstrainTypeExprBool(s.Guard, MutateCSharp.Schemata407.ReplaceStringConstant_1(2123L, "condition is expected to be of type bool, but is {0}"));
                }

                scope.PushMarker();
                if (s.IsBindingGuard)
                {
                    var exists = (ExistsExpr)s.Guard;
                    foreach (var v in exists.BoundVars)
                    {
                        ScopePushAndReport(scope, v, MutateCSharp.Schemata407.ReplaceStringConstant_1(2124L, "bound-variable"));
                    }
                }
                DominatingStatementLabels.PushMarker();
                ResolveBlockStatement(s.Thn, resolutionContext);
                DominatingStatementLabels.PopMarker();
                scope.PopMarker();

                if (MutateCSharp.Schemata407.ReplaceBinExprOp_68(2125L, s.Els, null))
                {
                    DominatingStatementLabels.PushMarker();
                    ResolveStatement(s.Els, resolutionContext);
                    DominatingStatementLabels.PopMarker();
                }

            }
            else if (stmt is AlternativeStmt)
            {
                var s = (AlternativeStmt)stmt;
                ResolveAlternatives(s.Alternatives, null, resolutionContext);

            }
            else if (stmt is OneBodyLoopStmt)
            {
                var s = (OneBodyLoopStmt)stmt;
                if (s is WhileStmt whileS && MutateCSharp.Schemata407.ReplaceBinExprOp_4(2126L, whileS.Guard, null))
                {
                    ResolveExpression(whileS.Guard, resolutionContext);
                    Contract.Assert(whileS.Guard.Type != null);  // follows from postcondition of ResolveExpression
                    ConstrainTypeExprBool(whileS.Guard, MutateCSharp.Schemata407.ReplaceStringConstant_1(2127L, "condition is expected to be of type bool, but is {0}"));
                }
                else if (s is ForLoopStmt forS)
                {
                    var loopIndex = forS.LoopIndex;
                    int prevErrorCount = reporter.Count(ErrorLevel.Error);
                    ResolveType(loopIndex.Tok, loopIndex.Type, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                    var err = new TypeConstraint.ErrorMsgWithToken(loopIndex.Tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2128L, "index variable is expected to be of an integer type (got {0})"), loopIndex.Type);
                    ConstrainToIntegerType(loopIndex.Tok, loopIndex.Type, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2129L, false), err);

                    ResolveExpression(forS.Start, resolutionContext);
                    AddAssignableConstraint(forS.Start.tok, forS.LoopIndex.Type, forS.Start.Type, MutateCSharp.Schemata407.ReplaceStringConstant_1(2130L, "lower bound (of type {1}) not assignable to index variable (of type {0})"));
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_4(2131L, forS.End, null))
                    {
                        ResolveExpression(forS.End, resolutionContext);
                        AddAssignableConstraint(forS.End.tok, forS.LoopIndex.Type, forS.End.Type, MutateCSharp.Schemata407.ReplaceStringConstant_1(2132L, "upper bound (of type {1}) not assignable to index variable (of type {0})"));
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_21(2137L, forS.Decreases.Expressions.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2133L, 0)))
                        {
                            reporter.Error(MessageSource.Resolver, forS.Decreases.Expressions[MutateCSharp.Schemata407.ReplaceNumericConstant_6(2142L, 0)].tok,
              MutateCSharp.Schemata407.ReplaceStringConstant_1(2146L, "a 'for' loop is allowed an explicit 'decreases' clause only if the end-expression is '*'"));
                        }
                    }
                    else if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(2156L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_7(2151L, forS.Decreases.Expressions.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2147L, 0)), () => !resolutionContext.CodeContext.AllowsNontermination))
                    {
                        // note, the following error message is also emitted elsewhere (if the loop bears a "decreases *")
                        reporter.Error(MessageSource.Resolver, forS.Tok,
            MutateCSharp.Schemata407.ReplaceStringConstant_1(2162L, "a possibly infinite loop is allowed only if the enclosing method is declared (with 'decreases *') to be possibly non-terminating") +
            MutateCSharp.Schemata407.ReplaceStringConstant_1(2163L, " (or you can add a 'decreases' clause to this 'for' loop if you want to prove that it does indeed terminate)"));
                    }

                    // Create a new scope, add the local to the scope, and resolve the attributes
                    scope.PushMarker();
                    ScopePushAndReport(scope, loopIndex, MutateCSharp.Schemata407.ReplaceStringConstant_1(2164L, "index-variable"));
                    ResolveAttributes(s, resolutionContext);
                }

                ResolveLoopSpecificationComponents(s.Invariants, s.Decreases, s.Mod, resolutionContext);

                if (MutateCSharp.Schemata407.ReplaceBinExprOp_60(2165L, s.Body, null))
                {
                    LoopStack.Add(s);  // push
                    DominatingStatementLabels.PushMarker();
                    ResolveStatement(s.Body, resolutionContext);
                    DominatingStatementLabels.PopMarker();
                    LoopStack.RemoveAt(MutateCSharp.Schemata407.ReplaceBinExprOp_70(2170L, LoopStack.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2166L, 1)));  // pop
                }

                if (s is ForLoopStmt)
                {
                    scope.PopMarker();
                }

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

                int prevErrorCount = reporter.Count(ErrorLevel.Error);
                scope.PushMarker();
                foreach (BoundVar v in s.BoundVars)
                {
                    ScopePushAndReport(scope, v, MutateCSharp.Schemata407.ReplaceStringConstant_1(2179L, "local-variable"));
                    ResolveType(v.tok, v.Type, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                }
                ResolveExpression(s.Range, resolutionContext);
                Contract.Assert(s.Range.Type != null);  // follows from postcondition of ResolveExpression
                ConstrainTypeExprBool(s.Range, MutateCSharp.Schemata407.ReplaceStringConstant_1(2180L, "range restriction in forall statement must be of type bool (instead got {0})"));
                foreach (var ens in s.Ens)
                {
                    ResolveExpression(ens.E, resolutionContext);
                    Contract.Assert(ens.E.Type != null);  // follows from postcondition of ResolveExpression
                    ConstrainTypeExprBool(ens.E, MutateCSharp.Schemata407.ReplaceStringConstant_1(2181L, "ensures condition is expected to be of type bool, but is {0}"));
                }
                // Since the range and postconditions are more likely to infer the types of the bound variables, resolve them
                // first (above) and only then resolve the attributes (below).
                ResolveAttributes(s, resolutionContext);

                if (MutateCSharp.Schemata407.ReplaceBinExprOp_68(2182L, s.Body, null))
                {
                    // clear the labels for the duration of checking the body, because break statements are not allowed to leave a forall statement
                    var prevLblStmts = EnclosingStatementLabels;
                    var prevLoopStack = LoopStack;
                    EnclosingStatementLabels = new Scope<Statement>(Options);
                    LoopStack = new List<Statement>();
                    ResolveStatement(s.Body, resolutionContext);
                    EnclosingStatementLabels = prevLblStmts;
                    LoopStack = prevLoopStack;
                }
                scope.PopMarker();

                if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(2183L, prevErrorCount, reporter.Count(ErrorLevel.Error)))
                {
                    // determine the Kind and run some additional checks on the body
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_21(2192L, s.Ens.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2188L, 0)))
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
                                reporter.Error(MessageSource.Resolver, rhs.Tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2197L, "new allocation not supported in aggregate assignments"));
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
                            if (MutateCSharp.Schemata407.ReplaceBinExprOp_85(2198L, method.EnclosingClass.EnclosingModuleDefinition, resolutionContext.CodeContext.EnclosingModule))
                            {
                                s.CanConvert = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2199L, false);
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
                            reporter.Info(MessageSource.Resolver, s.Tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2200L, "ensures ") + Printer.ExprToString(Options, result));
                        }
                        else
                        {
                            s.Kind = ForallStmt.BodyKind.Proof;
                            if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(2210L, () => s.Body is BlockStmt, () => MutateCSharp.Schemata407.ReplaceBinExprOp_7(2205L, ((BlockStmt)s.Body).Body.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2201L, 0))))
                            {
                                // an empty statement, so don't produce any warning
                            }
                            else
                            {
                                reporter.Warning(MessageSource.Resolver, ParseErrors.ErrorId.none, s.Tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2216L, "the conclusion of the body of this forall statement will not be known outside the forall statement; consider using an 'ensures' clause"));
                            }
                        }
                    }

                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_11(2217L, s.EffectiveEnsuresClauses, null))
                    {
                        foreach (Expression expr in s.EffectiveEnsuresClauses)
                        {
                            ResolveExpression(expr, resolutionContext);
                        }
                    }
                }

            }
            else if (stmt is ModifyStmt)
            {
                var s = (ModifyStmt)stmt;
                ResolveAttributes(s.Mod, resolutionContext);
                foreach (FrameExpression fe in s.Mod.Expressions)
                {
                    ResolveFrameExpression(fe, FrameExpressionUse.Modifies, resolutionContext);
                }
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_60(2218L, s.Body, null))
                {
                    ResolveBlockStatement(s.Body, resolutionContext);
                }

            }
            else if (stmt is CalcStmt)
            {
                var prevErrorCount = reporter.Count(ErrorLevel.Error);
                CalcStmt s = (CalcStmt)stmt;
                // figure out s.Op
                Contract.Assert(s.Op == null);  // it hasn't been set yet
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_86(2219L, s.UserSuppliedOp, null))
                {
                    s.Op = s.UserSuppliedOp;
                }
                else
                {
                    s.Op = s.GetInferredDefaultOp() ?? CalcStmt.DefaultOp;
                    reporter.Info(MessageSource.Resolver, s.Tok, s.Op.ToString());
                }

                if (MutateCSharp.Schemata407.ReplaceBinExprOp_19(2224L, s.Lines.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2220L, 0)))
                {
                    Type lineType = new InferredTypeProxy();
                    var e0 = s.Lines.First();
                    ResolveExpression(e0, resolutionContext);
                    Contract.Assert(e0.Type != null);  // follows from postcondition of ResolveExpression
                    var err = new TypeConstraint.ErrorMsgWithToken(e0.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2229L, "all lines in a calculation must have the same type (got {0} after {1})"), e0.Type, lineType);
                    ConstrainSubtypeRelation(lineType, e0.Type, err);
                    for (int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(2230L, 1); MutateCSharp.Schemata407.ReplaceBinExprOp_12(2234L, i, s.Lines.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(2239L, ref i))
                    {
                        var e1 = s.Lines[i];
                        ResolveExpression(e1, resolutionContext);
                        Contract.Assert(e1.Type != null);  // follows from postcondition of ResolveExpression
                                                           // reuse the error object if we're on the dummy line; this prevents a duplicate error message
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_12(2253L, i, MutateCSharp.Schemata407.ReplaceBinExprOp_70(2244L, s.Lines.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2240L, 1))))
                        {
                            err = new TypeConstraint.ErrorMsgWithToken(e1.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2258L, "all lines in a calculation must have the same type (got {0} after {1})"), e1.Type, lineType);
                        }
                        ConstrainSubtypeRelation(lineType, e1.Type, err);
                        var step = (s.StepOps[MutateCSharp.Schemata407.ReplaceBinExprOp_70(2263L, i, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2259L, 1))] ?? s.Op).StepExpr(e0, e1); // Use custom line operator
                        ResolveExpression(step, resolutionContext);
                        s.Steps.Add(step);
                        e0 = e1;
                    }

                    // clear the labels for the duration of checking the hints, because break statements are not allowed to leave a forall statement
                    var prevLblStmts = EnclosingStatementLabels;
                    var prevLoopStack = LoopStack;
                    EnclosingStatementLabels = new Scope<Statement>(Options);
                    LoopStack = new List<Statement>();
                    foreach (var h in s.Hints)
                    {
                        foreach (var oneHint in h.Body)
                        {
                            DominatingStatementLabels.PushMarker();
                            ResolveStatement(oneHint, resolutionContext);
                            DominatingStatementLabels.PopMarker();
                        }
                    }
                    EnclosingStatementLabels = prevLblStmts;
                    LoopStack = prevLoopStack;

                }
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(2286L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_7(2272L, prevErrorCount, reporter.Count(ErrorLevel.Error)), () => MutateCSharp.Schemata407.ReplaceBinExprOp_19(2281L, s.Lines.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2277L, 0))))
                {
                    // do not build Result from the lines if there were errors, as it might be ill-typed and produce unnecessary resolution errors
                    var resultOp = s.StepOps.Aggregate(s.Op, (op0, op1) => MutateCSharp.Schemata407.ReplaceBinExprOp_87(2292L, op1, null) ? op0 : op0.ResultOp(op1));
                    s.Result = resultOp.StepExpr(s.Lines.First(), s.Lines.Last());
                }
                else
                {
                    s.Result = CalcStmt.DefaultOp.StepExpr(Expression.CreateIntLiteral(s.Tok, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2293L, 0)), Expression.CreateIntLiteral(s.Tok, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2297L, 0)));
                }
                ResolveExpression(s.Result, resolutionContext);
                Contract.Assert(s.Result != null);
                Contract.Assert(prevErrorCount != reporter.Count(ErrorLevel.Error) || s.Steps.Count == s.Hints.Count);

            }
            else if (stmt is SkeletonStatement)
            {
                var s = (SkeletonStatement)stmt;
                reporter.Error(MessageSource.Resolver, s.Tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2301L, "skeleton statements are allowed only in refining methods"));
                // nevertheless, resolve the underlying statement; hey, why not
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_68(2302L, s.S, null))
                {
                    ResolveStatement(s.S, resolutionContext);
                }
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();
            }
        }

        private void ResolveLoopSpecificationComponents(List<AttributedExpression> invariants, Specification<Expression> decreases,
          Specification<FrameExpression> modifies, ResolutionContext resolutionContext)
        {
            Contract.Requires(invariants != null);
            Contract.Requires(decreases != null);
            Contract.Requires(modifies != null);
            Contract.Requires(resolutionContext != null);

            foreach (AttributedExpression inv in invariants)
            {
                ResolveAttributes(inv, resolutionContext);
                ResolveExpression(inv.E, resolutionContext);
                Contract.Assert(inv.E.Type != null);  // follows from postcondition of ResolveExpression
                ConstrainTypeExprBool(inv.E, MutateCSharp.Schemata407.ReplaceStringConstant_1(2303L, "invariant is expected to be of type bool, but is {0}"));
            }

            ResolveAttributes(decreases, resolutionContext);
            foreach (Expression e in decreases.Expressions)
            {
                ResolveExpression(e, resolutionContext);
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(2304L, () => e is WildcardExpr, () => !resolutionContext.CodeContext.AllowsNontermination))
                {
                    reporter.Error(MessageSource.Resolver, e, MutateCSharp.Schemata407.ReplaceStringConstant_1(2310L, "a possibly infinite loop is allowed only if the enclosing method is declared (with 'decreases *') to be possibly non-terminating"));
                }
                // any type is fine
            }

            ResolveAttributes(modifies, resolutionContext);
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_88(2311L, modifies.Expressions, null))
            {
                foreach (FrameExpression fe in modifies.Expressions)
                {
                    ResolveFrameExpression(fe, FrameExpressionUse.Modifies, resolutionContext);
                }
            }
        }

        /// <summary>
        /// Resolves the default-valued expression for each formal in "formals".
        /// Solves the resulting type constraints.
        /// Assumes these are the only type constraints to be solved.
        ///
        /// Reports an error for any cyclic dependency among the default-value expressions of the formals.
        /// </summary>
        public void ResolveParameterDefaultValues(List<Formal> formals, ResolutionContext resolutionContext)
        {
            Contract.Requires(formals != null);
            Contract.Requires(resolutionContext != null);

            Contract.Assume(AllTypeConstraints.Count == 0);

            // Formal parameters have three ways to indicate how they are to be passed in:
            //   * nameonly: the only way to give a specific argument value is to name the parameter
            //   * positional only: these are nameless parameters (which are allowed only for datatype constructor parameters)
            //   * either positional or by name: this is the most common parameter
            // A parameter is either required or optional:
            //   * required: a caller has to supply an argument
            //   * optional: the parameter has a default value that is used if a caller omits passing a specific argument
            //
            // The syntax for giving a positional-only (i.e., nameless) parameter does not allow a default-value expression, so
            // a positional-only parameter is always required.
            //
            // At a call site, positional arguments are not allowed to follow named arguments. Therefore, if "x" is
            // a nameonly parameter, then there is no way to supply the parameters after "x" by position. Thus, any
            // parameter that follows "x" must either be passed by name or have a default value. That is, if a later
            // parameter does not have a default value, it is _effectively_ nameonly. We impose the rule that
            //   * an effectively nameonly parameter must be declared as nameonly
            //
            // For a positional-only parameter "x", every parameter preceding "x" is _effectively_ required. We impose
            // the rule that
            //   * an effectively required parameter must not have a default-value expression
            var dependencies = new Graph<IVariable>();
            string nameOfMostRecentNameonlyParameter = null;
            var previousParametersWithDefaultValue = new HashSet<Formal>();
            foreach (var formal in formals)
            {
                if (!formal.HasName)
                {
                    foreach (var previousFormal in previousParametersWithDefaultValue)
                    {
                        reporter.Error(MessageSource.Resolver, previousFormal.DefaultValue.tok,
                          $"because of a later nameless parameter, this default value is never used; remove it or name all subsequent parameters");
                    }
                    previousParametersWithDefaultValue.Clear();
                }
                var d = formal.DefaultValue;
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_4(2312L, d, null))
                {
                    ResolveExpression(d, resolutionContext);
                    AddAssignableConstraint(d.tok, formal.Type, d.Type, MutateCSharp.Schemata407.ReplaceStringConstant_1(2313L, "default-value expression (of type '{1}') is not assignable to formal (of type '{0}')"));
                    foreach (var v in FreeVariables(d))
                    {
                        dependencies.AddEdge(formal, v);
                    }
                    previousParametersWithDefaultValue.Add(formal);
                }
                else if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(2314L, () => nameOfMostRecentNameonlyParameter != null, () => !formal.IsNameOnly))
                {
                    // "formal" is preceded by a nameonly parameter, but itself is neither nameonly nor has a default value
                    reporter.Error(MessageSource.Resolver, formal.tok,
                      $"this parameter is effectively nameonly (because of the earlier nameonly parameter '{nameOfMostRecentNameonlyParameter}'); " +
          MutateCSharp.Schemata407.ReplaceStringConstant_1(2320L, "declare it as nameonly or give it a default-value expression"));
                }
                if (formal.IsNameOnly)
                {
                    nameOfMostRecentNameonlyParameter = formal.Name;
                }
            }
            SolveAllTypeConstraints();

            foreach (var cycle in dependencies.AllCycles())
            {
                var cy = Util.Comma(MutateCSharp.Schemata407.ReplaceStringConstant_1(2321L, " -> "), cycle, v => v.Name) + MutateCSharp.Schemata407.ReplaceStringConstant_1(2322L, " -> ") + cycle[MutateCSharp.Schemata407.ReplaceNumericConstant_6(2323L, 0)].Name;
                reporter.Error(MessageSource.Resolver, cycle[MutateCSharp.Schemata407.ReplaceNumericConstant_6(2327L, 0)], $"default-value expressions for parameters contain a cycle: {cy}");
            }
        }

        /// <summary>
        /// See ResolveTypeOption for a description of the option/defaultTypeArguments parameters.
        /// </summary>
        public void ResolveType(IToken tok, Type type, ResolutionContext resolutionContext, ResolveTypeOptionEnum eopt, List<TypeParameter> defaultTypeArguments)
        {
            Contract.Requires(tok != null);
            Contract.Requires(type != null);
            Contract.Requires(resolutionContext != null);
            Contract.Requires(eopt != ResolveTypeOptionEnum.AllowPrefixExtend);
            ResolveType(tok, type, resolutionContext, new ResolveTypeOption(eopt), defaultTypeArguments);
        }

        public void ResolveType(IToken tok, Type type, ICodeContext topLevelContext, ResolveTypeOptionEnum eopt, List<TypeParameter> defaultTypeArguments)
        {
            ResolveType(tok, type, ResolutionContext.FromCodeContext(topLevelContext), eopt, defaultTypeArguments);
        }

        public void ResolveType(IToken tok, Type type, ICodeContext topLevelContext, ResolveTypeOption option, List<TypeParameter> defaultTypeArguments)
        {
            ResolveType(tok, type, ResolutionContext.FromCodeContext(topLevelContext), option, defaultTypeArguments);
        }

        public void ResolveType(IToken tok, Type type, ResolutionContext resolutionContext, ResolveTypeOption option, List<TypeParameter> defaultTypeArguments)
        {
            Contract.Requires(tok != null);
            Contract.Requires(type != null);
            Contract.Requires(resolutionContext != null);
            Contract.Requires(option != null);
            Contract.Requires((option.Opt == ResolveTypeOptionEnum.DontInfer || option.Opt == ResolveTypeOptionEnum.InferTypeProxies) == (defaultTypeArguments == null));
            var r = ResolveTypeLenient(tok, type, resolutionContext, option, defaultTypeArguments, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2331L, false));
            Contract.Assert(r == null);
        }

        public record ResolveTypeReturn(Type ReplacementType, ExprDotName LastComponent);

        /// <summary>
        /// See ResolveTypeOption for a description of the option/defaultTypeArguments parameters.
        /// One more thing:  if "allowDanglingDotName" is true, then if the resolution would have produced
        ///   an error message that could have been avoided if "type" denoted an identifier sequence one
        ///   shorter, then return an unresolved replacement type where the identifier sequence is one
        ///   shorter.  (In all other cases, the method returns null.)
        /// </summary>
        public ResolveTypeReturn ResolveTypeLenient(IToken tok, Type type, ResolutionContext resolutionContext, ResolveTypeOption option, List<TypeParameter> defaultTypeArguments, bool allowDanglingDotName)
        {
            Contract.Requires(tok != null);
            Contract.Requires(type != null);
            Contract.Requires(resolutionContext != null);
            Contract.Requires((option.Opt == ResolveTypeOptionEnum.DontInfer || option.Opt == ResolveTypeOptionEnum.InferTypeProxies) == (defaultTypeArguments == null));
            if (type is BitvectorType)
            {
                var t = (BitvectorType)type;
                // nothing to resolve, but record the fact that this bitvector width is in use
                SystemModuleManager.Bitwidths.Add(t.Width);
            }
            else if (type is BasicType)
            {
                // nothing to resolve
            }
            else if (type is MapType)
            {
                var mt = (MapType)type;
                var errorCount = reporter.Count(ErrorLevel.Error);
                int typeArgumentCount;
                if (mt.HasTypeArg())
                {
                    ResolveType(tok, mt.Domain, resolutionContext, option, defaultTypeArguments);
                    ResolveType(tok, mt.Range, resolutionContext, option, defaultTypeArguments);
                    typeArgumentCount = MutateCSharp.Schemata407.ReplaceNumericConstant_6(2332L, 2);
                }
                else if (MutateCSharp.Schemata407.ReplaceBinExprOp_89(2336L, option.Opt, ResolveTypeOptionEnum.DontInfer))
                {
                    mt.SetTypeArgs(new InferredTypeProxy(), new InferredTypeProxy());
                    typeArgumentCount = MutateCSharp.Schemata407.ReplaceNumericConstant_6(2337L, 0);
                }
                else
                {
                    var inferredTypeArgs = new List<Type>();
                    FillInTypeArguments(tok, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2341L, 2), inferredTypeArgs, defaultTypeArguments, option);
                    Contract.Assert(inferredTypeArgs.Count <= 2);
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(2349L, inferredTypeArgs.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2345L, 1)))
                    {
                        mt.SetTypeArgs(inferredTypeArgs[MutateCSharp.Schemata407.ReplaceNumericConstant_6(2354L, 0)], new InferredTypeProxy());
                        typeArgumentCount = MutateCSharp.Schemata407.ReplaceNumericConstant_6(2358L, 1);
                    }
                    else if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(2366L, inferredTypeArgs.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2362L, 2)))
                    {
                        mt.SetTypeArgs(inferredTypeArgs[MutateCSharp.Schemata407.ReplaceNumericConstant_6(2371L, 0)], inferredTypeArgs[MutateCSharp.Schemata407.ReplaceNumericConstant_6(2375L, 1)]);
                        typeArgumentCount = MutateCSharp.Schemata407.ReplaceNumericConstant_6(2379L, 2);
                    }
                    else
                    {
                        mt.SetTypeArgs(new InferredTypeProxy(), new InferredTypeProxy());
                        typeArgumentCount = MutateCSharp.Schemata407.ReplaceNumericConstant_6(2383L, 0);
                    }
                }
                // defaults and auto have been applied; check if we now have the right number of arguments
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_21(2391L, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2387L, 2), typeArgumentCount))
                {
                    reporter.Error(MessageSource.Resolver, tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2396L, "Wrong number of type arguments ({0} instead of 2) passed to type: {1}"), typeArgumentCount, mt.CollectionTypeName);
                }
            }
            else if (type is CollectionType)
            {
                var t = (CollectionType)type;
                var errorCount = reporter.Count(ErrorLevel.Error);
                if (t.HasTypeArg())
                {
                    ResolveType(tok, t.Arg, resolutionContext, option, defaultTypeArguments);
                }
                else if (MutateCSharp.Schemata407.ReplaceBinExprOp_90(2397L, option.Opt, ResolveTypeOptionEnum.DontInfer))
                {
                    var inferredTypeArgs = new List<Type>();
                    FillInTypeArguments(tok, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2398L, 1), inferredTypeArgs, defaultTypeArguments, option);
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_21(2406L, inferredTypeArgs.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2402L, 0)))
                    {
                        Contract.Assert(inferredTypeArgs.Count == 1);
                        t.SetTypeArg(inferredTypeArgs[MutateCSharp.Schemata407.ReplaceNumericConstant_6(2411L, 0)]);
                    }
                }
                if (!t.HasTypeArg())
                {
                    // defaults and auto have been applied; check if we now have the right number of arguments
                    reporter.Error(MessageSource.Resolver, tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2415L, "Wrong number of type arguments (0 instead of 1) passed to type: {0}"), t.CollectionTypeName);
                    // add a proxy type, to make sure that CollectionType will have have a non-null Arg
                    t.SetTypeArg(new InferredTypeProxy());
                }

            }
            else if (type is UserDefinedType)
            {
                var t = (UserDefinedType)type;
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_30(2416L, t.ResolvedClass, null))
                {
                    // Apparently, this type has already been resolved
                    return null;
                }
                var prevErrorCount = reporter.Count(ErrorLevel.Error);
                if (t.NamePath is ExprDotName)
                {
                    var ret = ResolveDotSuffix_Type((ExprDotName)t.NamePath, resolutionContext, allowDanglingDotName, option, defaultTypeArguments);
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_91(2417L, ret, null))
                    {
                        return ret;
                    }
                }
                else
                {
                    var s = (NameSegment)t.NamePath;
                    ResolveNameSegment_Type(s, resolutionContext, option, defaultTypeArguments);
                }
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(2418L, reporter.Count(ErrorLevel.Error), prevErrorCount))
                {
                    var r = t.NamePath.Resolved as Resolver_IdentifierExpr;
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_32(2424L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_92(2423L, r, null), () => !(r.Type is Resolver_IdentifierExpr.ResolverType_Type)))
                    {
                        reporter.Error(MessageSource.Resolver, t.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2430L, "expected type"));
                    }
                    else if (r.Type is Resolver_IdentifierExpr.ResolverType_Type)
                    {
                        var d = r.Decl;
                        if (d is AbstractTypeDecl)
                        {
                            // resolve like a type parameter, and it may have type parameters if it's an abstract type
                            t.ResolvedClass = d;  // Store the decl, so the compiler will generate the fully qualified name
                        }
                        else if (d is RedirectingTypeDecl)
                        {
                            var dd = (RedirectingTypeDecl)d;
                            var caller = CodeContextWrapper.Unwrap(resolutionContext.CodeContext) as ICallable;
                            if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(2438L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_93(2431L, caller, null), () => !(MutateCSharp.Schemata407.ReplaceBinExprOp_9(2432L, () => d is SubsetTypeDecl, () => caller is SpecialFunction))))
                            {
                                if (caller != d)
                                {
                                }
                                else if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(2444L, () => d is TypeSynonymDecl, () => !(d is SubsetTypeDecl)))
                                {
                                    // detect self-loops here, since they don't show up in the graph's SCC methods
                                    reporter.Error(MessageSource.Resolver, d.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2450L, "type-synonym cycle: {0} -> {0}"), d.Name);
                                }
                                else
                                {
                                    // detect self-loops here, since they don't show up in the graph's SCC methods
                                    reporter.Error(MessageSource.Resolver, d.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2451L, "recursive constraint dependency involving a {0}: {1} -> {1}"), d.WhatKind, d.Name);
                                }
                            }
                            t.ResolvedClass = d;
                        }
                        else if (d is DatatypeDecl)
                        {
                            t.ResolvedClass = d;
                        }
                        else
                        {
                            // d is a type parameter, coinductive datatype, or class, and it may have type parameters
                            t.ResolvedClass = d;
                        }
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_89(2452L, option.Opt, ResolveTypeOptionEnum.DontInfer))
                        {
                            // don't add anything
                        }
                        else if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(2467L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_21(2453L, d.TypeArgs.Count, t.TypeArgs.Count), () => MutateCSharp.Schemata407.ReplaceBinExprOp_7(2462L, t.TypeArgs.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2458L, 0))))
                        {
                            FillInTypeArguments(t.tok, d.TypeArgs.Count, t.TypeArgs, defaultTypeArguments, option);
                        }
                        // defaults and auto have been applied; check if we now have the right number of arguments
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_21(2473L, d.TypeArgs.Count, t.TypeArgs.Count))
                        {
                            reporter.Error(MessageSource.Resolver, t.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2478L, "Wrong number of type arguments ({0} instead of {1}) passed to {2}: {3}"), t.TypeArgs.Count, d.TypeArgs.Count, d.WhatKind, t.Name);
                        }

                    }
                }
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_45(2479L, t.ResolvedClass, null))
                {
                    // There was some error. Still, we will set .ResolvedClass to some value to prevent some crashes in the downstream resolution.  The
                    // 0-tuple is convenient, because it is always in scope.
                    t.ResolvedClass = SystemModuleManager.TupleType(t.tok, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2480L, 0), MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2484L, false));
                    // clear out the TypeArgs since 0-tuple doesn't take TypeArg
                    t.TypeArgs = new List<Type>();
                }

            }
            else if (type is TypeProxy)
            {
                TypeProxy t = (TypeProxy)type;
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_14(2485L, t.T, null))
                {
                    ResolveType(tok, t.T, resolutionContext, option, defaultTypeArguments);
                }
            }
            else if (type is SelfType)
            {
                // do nothing.
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected type
            }
            return null;
        }

        /// <summary>
        /// Adds to "typeArgs" a list of "n" type arguments, possibly extending "defaultTypeArguments".
        /// </summary>
        static void FillInTypeArguments(IToken tok, int n, List<Type> typeArgs, List<TypeParameter> defaultTypeArguments, ResolveTypeOption option)
        {
            Contract.Requires(tok != null);
            Contract.Requires(0 <= n);
            Contract.Requires(typeArgs != null && typeArgs.Count == 0);
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_89(2486L, option.Opt, ResolveTypeOptionEnum.InferTypeProxies))
            {
                // add type arguments that will be inferred
                for (int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(2487L, 0); MutateCSharp.Schemata407.ReplaceBinExprOp_12(2491L, i, n); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(2496L, ref i))
                {
                    typeArgs.Add(new InferredTypeProxy());
                }
            }
            else if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(2503L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_89(2497L, option.Opt, ResolveTypeOptionEnum.AllowPrefix), () => MutateCSharp.Schemata407.ReplaceBinExprOp_12(2498L, defaultTypeArguments.Count, n)))
            {
                // there aren't enough default arguments, so don't do anything
            }
            else
            {
                // we'll add arguments
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_89(2509L, option.Opt, ResolveTypeOptionEnum.AllowPrefixExtend))
                {
                    // extend defaultTypeArguments, if needed
                    for (int i = defaultTypeArguments.Count; MutateCSharp.Schemata407.ReplaceBinExprOp_12(2510L, i, n); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(2515L, ref i))
                    {
                        var tp = new TypeParameter(tok.ToRange(), new Name(tok.ToRange(), MutateCSharp.Schemata407.ReplaceStringConstant_1(2516L, "_T") + i), i, option.Parent);
                        if (option.Parent is IteratorDecl)
                        {
                            tp.Characteristics.AutoInit = Type.AutoInitInfo.CompilableValue;
                        }
                        defaultTypeArguments.Add(tp);
                    }
                }
                Contract.Assert(n <= defaultTypeArguments.Count);
                // automatically supply a prefix of the arguments from defaultTypeArguments
                for (int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(2517L, 0); MutateCSharp.Schemata407.ReplaceBinExprOp_12(2521L, i, n); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(2526L, ref i))
                {
                    typeArgs.Add(new UserDefinedType(defaultTypeArguments[i]));
                }
            }
        }

        public static bool TypeConstraintsIncludeProxy(Type t, TypeProxy proxy)
        {
            return TypeConstraintsIncludeProxy_Aux(t, proxy, new HashSet<TypeProxy>());
        }
        static bool TypeConstraintsIncludeProxy_Aux(Type t, TypeProxy proxy, ISet<TypeProxy> visited)
        {
            Contract.Requires(t != null);
            Contract.Requires(!(t is TypeProxy) || ((TypeProxy)t).T == null);  // t is expected to have been normalized first
            Contract.Requires(proxy != null && proxy.T == null);
            Contract.Requires(visited != null);
            var tproxy = t as TypeProxy;
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_29(2527L, tproxy, null))
            {
                if (object.ReferenceEquals(tproxy, proxy))
                {
                    return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2528L, true);
                }
                else if (visited.Contains(tproxy))
                {
                    return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2529L, false);
                }
                visited.Add(tproxy);
                foreach (var su in tproxy.Subtypes)
                {
                    if (TypeConstraintsIncludeProxy_Aux(su, proxy, visited))
                    {
                        return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2530L, true);
                    }
                }
                foreach (var su in tproxy.Supertypes)
                {
                    if (TypeConstraintsIncludeProxy_Aux(su, proxy, visited))
                    {
                        return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2531L, true);
                    }
                }
            }
            else
            {
                // check type arguments of t
                foreach (var ta in t.TypeArgs)
                {
                    var a = ta.Normalize();
                    if (TypeConstraintsIncludeProxy_Aux(a, proxy, visited))
                    {
                        return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2532L, true);
                    }
                }
            }
            return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2533L, false);
        }

        public void ResolveTypeRhs(TypeRhs rr, Statement stmt, ResolutionContext resolutionContext)
        {
            Contract.Requires(rr != null);
            Contract.Requires(stmt != null);
            Contract.Requires(resolutionContext != null);
            Contract.Ensures(Contract.Result<Type>() != null);

            if (MutateCSharp.Schemata407.ReplaceBinExprOp_24(2534L, rr.Type, null))
            {
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_11(2535L, rr.ArrayDimensions, null))
                {
                    // ---------- new T[EE]    OR    new T[EE] (elementInit)
                    Contract.Assert(rr.Bindings == null && rr.Path == null && rr.InitCall == null);
                    ResolveType(stmt.Tok, rr.EType, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                    int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(2536L, 0);
                    foreach (Expression dim in rr.ArrayDimensions)
                    {
                        Contract.Assert(dim != null);
                        ResolveExpression(dim, resolutionContext);
                        ConstrainToIntegerType(dim, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2540L, false), string.Format(MutateCSharp.Schemata407.ReplaceStringConstant_1(2541L, "new must use an integer-based expression for the array size (got {{0}}{0})"), MutateCSharp.Schemata407.ReplaceBinExprOp_7(2546L, rr.ArrayDimensions.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2542L, 1)) ? "" : MutateCSharp.Schemata407.ReplaceStringConstant_1(2551L, " for index ") + i));
                        MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(2552L, ref i);
                    }
                    rr.Type = ResolvedArrayType(stmt.Tok, rr.ArrayDimensions.Count, rr.EType, resolutionContext, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2553L, false));
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_4(2554L, rr.ElementInit, null))
                    {
                        ResolveExpression(rr.ElementInit, resolutionContext);
                        // Check
                        //     int^N -> rr.EType  :>  rr.ElementInit.Type
                        SystemModuleManager.CreateArrowTypeDecl(rr.ArrayDimensions.Count);  // TODO: should this be done already in the parser?
                        var args = new List<Type>();
                        for (int ii = MutateCSharp.Schemata407.ReplaceNumericConstant_6(2555L, 0); MutateCSharp.Schemata407.ReplaceBinExprOp_12(2559L, ii, rr.ArrayDimensions.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(2564L, ref ii))
                        {
                            args.Add(SystemModuleManager.Nat());
                        }
                        var arrowType = new ArrowType(rr.ElementInit.tok, SystemModuleManager.ArrowTypeDecls[rr.ArrayDimensions.Count], args, rr.EType);
                        var lambdaType = rr.ElementInit.Type.AsArrowType;
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(2570L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_94(2565L, lambdaType, null), () => lambdaType.TypeArgs[MutateCSharp.Schemata407.ReplaceNumericConstant_6(2566L, 0)] is InferredTypeProxy))
                        {
                            (lambdaType.TypeArgs[MutateCSharp.Schemata407.ReplaceNumericConstant_6(2576L, 0)] as InferredTypeProxy).KeepConstraints = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2580L, true);
                        }
                        string underscores;
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(2585L, rr.ArrayDimensions.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2581L, 1)))
                        {
                            underscores = MutateCSharp.Schemata407.ReplaceStringConstant_1(2590L, "_");
                        }
                        else
                        {
                            underscores = MutateCSharp.Schemata407.ReplaceStringConstant_1(2591L, "(") + Util.Comma(rr.ArrayDimensions.Count, x => MutateCSharp.Schemata407.ReplaceStringConstant_1(2592L, "_")) + MutateCSharp.Schemata407.ReplaceStringConstant_1(2593L, ")");
                        }
                        var hintString = string.Format(MutateCSharp.Schemata407.ReplaceStringConstant_1(2594L, " (perhaps write '{0} =>' in front of the expression you gave in order to make it an arrow type)"), underscores);
                        ConstrainSubtypeRelation(arrowType, rr.ElementInit.Type, rr.ElementInit, MutateCSharp.Schemata407.ReplaceStringConstant_1(2595L, "array-allocation initialization expression expected to have type '{0}' (instead got '{1}'){2}"),
                          arrowType, rr.ElementInit.Type, new LazyString_OnTypeEquals(rr.EType, rr.ElementInit.Type, hintString));
                    }
                    else if (MutateCSharp.Schemata407.ReplaceBinExprOp_11(2596L, rr.InitDisplay, null))
                    {
                        foreach (var v in rr.InitDisplay)
                        {
                            ResolveExpression(v, resolutionContext);
                            AddAssignableConstraint(v.tok, rr.EType, v.Type, MutateCSharp.Schemata407.ReplaceStringConstant_1(2597L, "initial value must be assignable to array's elements (expected '{0}', got '{1}')"));
                        }
                    }
                }
                else
                {
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_95(2598L, rr.Bindings, null))
                    {
                        ResolveType(stmt.Tok, rr.EType, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                        var cl = (rr.EType as UserDefinedType)?.ResolvedClass as NonNullTypeDecl;
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(2606L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_96(2599L, cl, null), () => !(MutateCSharp.Schemata407.ReplaceBinExprOp_9(2600L, () => rr.EType.IsTraitType, () => !rr.EType.NormalizeExpand().IsObjectQ))))
                        {
                            // life is good
                        }
                        else
                        {
                            reporter.Error(MessageSource.Resolver, rr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2612L, "new can be applied only to class types (got {0})"), rr.EType);
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
                        var ret = ResolveTypeLenient(rr.Tok, rr.Path, resolutionContext, new ResolveTypeOption(ResolveTypeOptionEnum.InferTypeProxies), null, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2613L, true));
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_91(2614L, ret, null))
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
                            initCallName = MutateCSharp.Schemata407.ReplaceStringConstant_1(2615L, "_ctor");
                            initCallTok = rr.Tok;
                        }
                        var cl = (rr.EType as UserDefinedType)?.ResolvedClass as NonNullTypeDecl;
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_32(2617L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_97(2616L, cl, null), () => rr.EType.IsTraitType))
                        {
                            reporter.Error(MessageSource.Resolver, rr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2623L, "new can be applied only to class types (got {0})"), rr.EType);
                        }
                        else
                        {
                            // ---------- new C.Init(EE)
                            Contract.Assert(initCallName != null);
                            var prevErrorCount = reporter.Count(ErrorLevel.Error);

                            // We want to create a MemberSelectExpr for the initializing method.  To do that, we create a throw-away receiver of the appropriate
                            // type, create a dot-suffix expression around this receiver, and then resolve it in the usual way for dot-suffix expressions.
                            var lhs = new ImplicitThisExpr_ConstructorCall(initCallTok) { Type = rr.EType };
                            var callLhs = new ExprDotName(((UserDefinedType)rr.EType).tok, lhs, initCallName, MutateCSharp.Schemata407.ReplaceBinExprOp_98(2624L, ret, null) ? null : ret.LastComponent.OptTypeArguments);
                            ResolveDotSuffix(callLhs, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2625L, true), rr.Bindings.ArgumentBindings, resolutionContext, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2626L, true));
                            if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(2627L, prevErrorCount, reporter.Count(ErrorLevel.Error)))
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
                                    reporter.Error(MessageSource.Resolver, initCallTok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2632L, "object initialization must denote an initializing method or constructor ({0})"), initCallName);
                                }
                            }
                        }
                    }
                    rr.Type = rr.EType;
                }
            }
        }

        /// <summary>
        /// Resolve "memberName" in what currently is known as "receiverType". If "receiverType" is an unresolved
        /// proxy type, try to solve enough type constraints and use heuristics to figure out which type contains
        /// "memberName" and return that enclosing type as "tentativeReceiverType". However, try not to make
        /// type-inference decisions about "receiverType"; instead, lay down the further constraints that need to
        /// be satisfied in order for "tentativeReceiverType" to be where "memberName" is found.
        /// Consequently, if "memberName" is found and returned as a "MemberDecl", it may still be the case that
        /// "receiverType" is an unresolved proxy type and that, after solving more type constraints, "receiverType"
        /// eventually gets set to a type more specific than "tentativeReceiverType".
        /// </summary>
        public MemberDecl ResolveMember(IToken tok, Type receiverType, string memberName, out NonProxyType tentativeReceiverType)
        {
            Contract.Requires(tok != null);
            Contract.Requires(receiverType != null);
            Contract.Requires(memberName != null);
            Contract.Ensures(Contract.Result<MemberDecl>() == null || Contract.ValueAtReturn(out tentativeReceiverType) != null);

            receiverType = PartiallyResolveTypeForMemberSelection(tok, receiverType, memberName);

            if (receiverType is TypeProxy)
            {
                reporter.Error(MessageSource.Resolver, tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2633L, "type of the receiver is not fully determined at this program point"), receiverType);
                tentativeReceiverType = null;
                return null;
            }
            Contract.Assert(receiverType is NonProxyType);  // there are only two kinds of types: proxies and non-proxies

            foreach (var valuet in ProgramResolver.SystemModuleManager.valuetypeDecls)
            {
                if (valuet.IsThisType(receiverType))
                {
                    if (GetClassMembers(valuet).TryGetValue(memberName, out var member))
                    {
                        SelfType resultType = null;
                        if (member is SpecialFunction)
                        {
                            resultType = ((SpecialFunction)member).ResultType as SelfType;
                        }
                        else if (member is SpecialField)
                        {
                            resultType = ((SpecialField)member).Type as SelfType;
                        }
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_99(2634L, resultType, null))
                        {
                            SelfTypeSubstitution = new Dictionary<TypeParameter, Type>();
                            SelfTypeSubstitution.Add(resultType.TypeArg, receiverType);
                            resultType.ResolvedType = receiverType;
                        }
                        tentativeReceiverType = (NonProxyType)receiverType;
                        return member;
                    }
                    break;
                }
            }

            var ctype = receiverType.NormalizeExpand() as UserDefinedType;
            var cd = ctype?.AsTopLevelTypeWithMembersBypassInternalSynonym;
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_100(2635L, cd, null))
            {
                Contract.Assert(ctype.TypeArgs.Count == cd.TypeArgs.Count);  // follows from the fact that ctype was resolved
                if (!GetClassMembers(cd).TryGetValue(memberName, out var member))
                {
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_51(2637L, memberName, MutateCSharp.Schemata407.ReplaceStringConstant_1(2636L, "_ctor")))
                    {
                        reporter.Error(MessageSource.Resolver, tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2638L, "{0} {1} does not have an anonymous constructor"), cd.WhatKind, cd.Name);
                    }
                    else
                    {
                        ReportMemberNotFoundError(tok, memberName, cd);
                    }
                }
                else if (!VisibleInScope(member))
                {
                    reporter.Error(MessageSource.Resolver, tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2639L, "member '{0}' has not been imported in this scope and cannot be accessed here"), memberName);
                }
                else
                {
                    tentativeReceiverType = ctype;
                    return member;
                }
                tentativeReceiverType = null;
                return null;
            }

            reporter.Error(MessageSource.Resolver, tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2640L, "type {0} does not have a member {1}"), receiverType, memberName);
            tentativeReceiverType = null;
            return null;
        }

        private void ReportMemberNotFoundError(IToken tok, string memberName, TopLevelDecl receiverDecl)
        {
            if (memberName.StartsWith(RevealStmt.RevealLemmaPrefix))
            {
                var nameToBeRevealed = memberName[RevealStmt.RevealLemmaPrefix.Length..];
                var members = receiverDecl is TopLevelDeclWithMembers topLevelDeclWithMembers ? GetClassMembers(topLevelDeclWithMembers) : null;
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_101(2641L, members, null))
                {
                    reporter.Error(MessageSource.Resolver, tok, $"member '{nameToBeRevealed}' does not exist in {receiverDecl.WhatKind} '{receiverDecl.Name}'");
                }
                else if (!members.TryGetValue(nameToBeRevealed, out var member))
                {
                    reporter.Error(MessageSource.Resolver, tok, $"member '{nameToBeRevealed}' does not exist in {receiverDecl.WhatKind} '{receiverDecl.Name}'");
                }
                else if (member is not (ConstantField or Function))
                {
                    Contract.Assert(!member.IsOpaque);
                    reporter.Error(MessageSource.Resolver, tok,
                      $"a {member.WhatKind} ('{nameToBeRevealed}') cannot be revealed; only opaque constants and functions can be revealed");
                }
                else if (!member.IsOpaque)
                {
                    reporter.Error(MessageSource.Resolver, tok, $"{member.WhatKind} '{nameToBeRevealed}' cannot be revealed, because it is not opaque");
                }
                else if (member is Function { Body: null })
                {
                    reporter.Error(MessageSource.Resolver, tok,
                      $"{member.WhatKind} '{nameToBeRevealed}' cannot be revealed, because it has no body in {receiverDecl.WhatKind} '{receiverDecl.Name}'");
                }
                else
                {
                    reporter.Error(MessageSource.Resolver, tok, $"cannot reveal '{nameToBeRevealed}'");
                }
            }
            else
            {
                reporter.Error(MessageSource.Resolver, tok, $"member '{memberName}' does not exist in {receiverDecl.WhatKind} '{receiverDecl.Name}'");
            }
        }

        /// <summary>
        /// Roughly speaking, tries to figure out the head of the type of "t", making as few inference decisions as possible.
        /// More precisely, returns a type that contains all the members of "t"; or if "memberName" is non-null, a type
        /// that at least contains the member "memberName" of "t".  Typically, this type is the head type of "t",
        /// but it may also be a type in a super- or subtype relation to "t".
        /// In some cases, it is necessary to make some inference decisions in order to figure out the type to return.
        /// </summary>
        public Type PartiallyResolveTypeForMemberSelection(IToken tok, Type t, string memberName = null, int strength = 0)
        {
            Contract.Requires(tok != null);
            Contract.Requires(t != null);
            Contract.Ensures(Contract.Result<Type>() != null);
            Contract.Ensures(!(Contract.Result<Type>() is TypeProxy) || ((TypeProxy)Contract.Result<Type>()).T == null);
            t = t.NormalizeExpand();
            if (!(t is TypeProxy))
            {
                return t;  // we're good
            }

            // simplify constraints
            PrintTypeConstraintState(MutateCSharp.Schemata407.ReplaceNumericConstant_6(2642L, 10));
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_19(2650L, strength, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2646L, 0)))
            {
                var proxySpecializations = new HashSet<TypeProxy>();
                GetRelatedTypeProxies(t, proxySpecializations);
                var anyNewConstraintsAssignable = ConvertAssignableToSubtypeConstraints(proxySpecializations);
                var anyNewConstraintsEquatable = TightenUpEquatable(proxySpecializations);
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_32(2685L, () => (MutateCSharp.Schemata407.ReplaceBinExprOp_9(2670L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_9(2664L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_19(2659L, strength, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2655L, 1)), () => !anyNewConstraintsAssignable), () => !anyNewConstraintsEquatable)), () => MutateCSharp.Schemata407.ReplaceBinExprOp_7(2680L, strength, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2676L, 10))))
                {
                    if (t is TypeProxy)
                    {
                        // One more try
                        var r = GetBaseTypeFromProxy((TypeProxy)t, new Dictionary<TypeProxy, Type>());
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_14(2691L, r, null))
                        {
                            if (Options.Get(CommonOptionBag.TypeInferenceDebug))
                            {
                                Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(2692L, "  ----> found improvement through GetBaseTypeFromProxy: {0}"), r);
                            }
                            return r;
                        }
                    }

                    if (Options.Get(CommonOptionBag.TypeInferenceDebug))
                    {
                        Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(2693L, "  ----> found no improvement, giving up"));
                    }
                    return t;
                }
            }
            PartiallySolveTypeConstraints(MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2694L, false));
            PrintTypeConstraintState(MutateCSharp.Schemata407.ReplaceNumericConstant_6(2695L, 11));
            t = t.NormalizeExpandKeepConstraints();
            var proxy = t as TypeProxy;
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_53(2699L, proxy, null))
            {
                return t;  // simplification did the trick
            }
            if (Options.Get(CommonOptionBag.TypeInferenceDebug))
            {
                Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(2700L, "DEBUG: Member selection{3}:  {1} :> {0} :> {2}"), t,
                  Util.Comma(proxy.SupertypesKeepConstraints, su => su.ToString()),
                  Util.Comma(proxy.SubtypesKeepConstraints, su => su.ToString()),
                  memberName == null ? "" : MutateCSharp.Schemata407.ReplaceStringConstant_1(2701L, " (") + memberName + MutateCSharp.Schemata407.ReplaceStringConstant_1(2702L, ")"));
            }

            // Look for a join of head symbols among the proxy's subtypes
            Type joinType = null;
            if (JoinOfAllSubtypes(proxy, ref joinType, new HashSet<TypeProxy>()) && MutateCSharp.Schemata407.ReplaceBinExprOp_14(2703L, joinType, null))
            {
                DetermineRootLeaf(joinType, out _, out _, out var headIsRoot, out _);
                if (joinType.IsDatatype)
                {
                    if (Options.Get(CommonOptionBag.TypeInferenceDebug))
                    {
                        Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(2704L, "  ----> join is a datatype: {0}"), joinType);
                    }
                    ConstrainSubtypeRelation(t, joinType, tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2705L, "Member selection requires a supertype of {0} (got something more like {1})"), t, joinType);
                    return joinType;
                }
                else if (headIsRoot)
                {
                    // we're good to go -- by picking "join" (whose type parameters have been replaced by fresh proxies), we're not losing any generality
                    if (Options.Get(CommonOptionBag.TypeInferenceDebug))
                    {
                        Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(2706L, "  ----> improved to {0} through join"), joinType);
                    }
                    AssignProxyAndHandleItsConstraints(proxy, joinType, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2707L, true));
                    return proxy.NormalizeExpand();  // we return proxy.T instead of join, in case the assignment gets hijacked
                }
                else if (MutateCSharp.Schemata407.ReplaceBinExprOp_32(2720L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_32(2712L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_51(2709L, memberName, MutateCSharp.Schemata407.ReplaceStringConstant_1(2708L, "_#apply")), () => MutateCSharp.Schemata407.ReplaceBinExprOp_51(2711L, memberName, MutateCSharp.Schemata407.ReplaceStringConstant_1(2710L, "requires"))), () => MutateCSharp.Schemata407.ReplaceBinExprOp_51(2719L, memberName, MutateCSharp.Schemata407.ReplaceStringConstant_1(2718L, "reads"))))
                {
                    var generalArrowType = joinType.AsArrowType;  // go all the way to the base type, to get to the general arrow type, if any0
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_94(2726L, generalArrowType, null))
                    {
                        // pick the supertype "generalArrowType" of "join"
                        if (Options.Get(CommonOptionBag.TypeInferenceDebug))
                        {
                            Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(2727L, "  ----> improved to {0} through join and function application"), generalArrowType);
                        }
                        ConstrainSubtypeRelation(generalArrowType, t, tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2728L, "Function application requires a subtype of {0} (got something more like {1})"), generalArrowType, t);
                        return generalArrowType;
                    }
                }
                else if (memberName != null)
                {
                    // If "join" has a member called "memberName" and no supertype of "join" does, then we'll pick this join
                    if (joinType.IsRefType)
                    {
                        var joinExpanded = joinType.NormalizeExpand();  // go all the way to the base type, to get to the class
                        if (!joinExpanded.IsObjectQ)
                        {
                            var cl = ((UserDefinedType)joinExpanded).ResolvedClass as ClassLikeDecl;
                            if (MutateCSharp.Schemata407.ReplaceBinExprOp_102(2729L, cl, null))
                            {
                                // TODO: the following could be improved by also supplying an upper bound of the search (computed as a join of the supertypes)
                                var plausibleMembers = new HashSet<MemberDecl>();
                                FindAllMembers(cl, memberName, plausibleMembers);
                                if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(2734L, plausibleMembers.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2730L, 1)))
                                {
                                    var mbr = plausibleMembers.First();
                                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_27(2739L, mbr.EnclosingClass, cl))
                                    {
                                        if (Options.Get(CommonOptionBag.TypeInferenceDebug))
                                        {
                                            Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(2740L, "  ----> improved to {0} through member-selection join"), joinType);
                                        }
                                        var joinRoot = joinType.NormalizeExpand();  // blow passed any constraints
                                        ConstrainSubtypeRelation(joinRoot, t, tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2741L, "Member selection requires a subtype of {0} (got something more like {1})"), joinRoot, t);
                                        return joinType;
                                    }
                                    else
                                    {
                                        // pick the supertype "mbr.EnclosingClass" of "cl"
                                        Contract.Assert(mbr.EnclosingClass is TraitDecl);  // a proper supertype of a ClassDecl must be a TraitDecl
                                        var typeMapping = cl.ParentFormalTypeParametersToActuals;
                                        TopLevelDecl td = mbr.EnclosingClass;
                                        foreach (var tt in cl.TraitAncestors())
                                        {
                                            // If there is a match, the list of Type actuals is unique
                                            // (a class cannot inherit both Trait<T1> and Trait<T2> with T1 != T2).
                                            if (MutateCSharp.Schemata407.ReplaceBinExprOp_103(2742L, tt, (TraitDecl)mbr.EnclosingClass))
                                            {
                                                td = tt;
                                            }
                                        }
                                        List<Type> proxyTypeArgs = td.TypeArgs.ConvertAll(t0 => typeMapping.ContainsKey(t0) ? typeMapping[t0] : (Type)new InferredTypeProxy());
                                        var joinMapping = TypeParameter.SubstitutionMap(cl.TypeArgs, joinType.TypeArgs);
                                        proxyTypeArgs = proxyTypeArgs.ConvertAll(t0 => t0.Subst(joinMapping));
                                        proxyTypeArgs = proxyTypeArgs.ConvertAll(t0 => MutateCSharp.Schemata407.ReplaceBinExprOp_104(2743L, t0.AsTypeParameter, null) ? t0 : (Type)new InferredTypeProxy());
                                        var pickItFromHere = new UserDefinedType(tok, mbr.EnclosingClass.Name, mbr.EnclosingClass, proxyTypeArgs);
                                        if (Options.Get(CommonOptionBag.TypeInferenceDebug))
                                        {
                                            Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(2744L, "  ----> improved to {0} through join and member lookup"), pickItFromHere);
                                        }
                                        ConstrainSubtypeRelation(pickItFromHere, t, tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2745L, "Member selection requires a subtype of {0} (got something more like {1})"), pickItFromHere, t);
                                        return pickItFromHere;
                                    }
                                }
                            }
                        }
                    }
                }
                if (Options.Get(CommonOptionBag.TypeInferenceDebug))
                {
                    Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(2746L, "  ----> found no improvement, because join does not determine type enough"));
                }
            }

            // Compute the meet of the proxy's supertypes
            Type meet = null;
            if (MeetOfAllSupertypes(proxy, ref meet, new HashSet<TypeProxy>(), MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2747L, false)) && MutateCSharp.Schemata407.ReplaceBinExprOp_14(2748L, meet, null))
            {
                // If the meet does have the member, then this looks promising. It could be that the
                // type would get further constrained later to pick some subtype (in particular, a
                // subclass that overrides the member) of this meet. But this is the best we can do
                // now.
                if (meet is TypeProxy)
                {
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_105(2749L, proxy, meet.Normalize()))
                    {
                        // can this really ever happen?
                        if (Options.Get(CommonOptionBag.TypeInferenceDebug))
                        {
                            Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(2750L, "  ----> found no improvement (other than the proxy itself)"));
                        }
                        return t;
                    }
                    else
                    {
                        if (Options.Get(CommonOptionBag.TypeInferenceDebug))
                        {
                            Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(2751L, "  ----> (merging, then trying to improve further) assigning proxy {0}.T := {1}"), proxy, meet);
                        }
                        Contract.Assert(proxy != meet);
                        proxy.T = meet;
                        Contract.Assert(t.NormalizeExpand() == meet);
                        return PartiallyResolveTypeForMemberSelection(tok, t, memberName, MutateCSharp.Schemata407.ReplaceBinExprOp_50(2756L, strength, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2752L, 1)));
                    }
                }
                if (!(meet is ArtificialType))
                {
                    if (Options.Get(CommonOptionBag.TypeInferenceDebug))
                    {
                        Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(2765L, "  ----> improved to {0} through meet"), meet);
                    }
                    if (memberName != null)
                    {
                        AssignProxyAndHandleItsConstraints(proxy, meet, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2766L, true));
                        return proxy.NormalizeExpand(); // we return proxy.T instead of meet, in case the assignment gets hijacked
                    }
                    else
                    {
                        return meet;
                    }
                }
            }

            // as a last resort, act on any artificial type nearby the proxy
            var artificialSuper = proxy.InClusterOfArtificial(AllXConstraints);
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_14(2767L, artificialSuper, null))
            {
                if (Options.Get(CommonOptionBag.TypeInferenceDebug))
                {
                    Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(2768L, "  ----> use artificial supertype: {0}"), artificialSuper);
                }
                return artificialSuper;
            }

            // we weren't able to do it
            if (Options.Get(CommonOptionBag.TypeInferenceDebug))
            {
                Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(2769L, "  ----> found no improvement using simple things, trying harder once more"));
            }
            return PartiallyResolveTypeForMemberSelection(tok, t, memberName, MutateCSharp.Schemata407.ReplaceBinExprOp_50(2774L, strength, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2770L, 1)));
        }

        private Type/*?*/ GetBaseTypeFromProxy(TypeProxy proxy, Dictionary<TypeProxy, Type/*?*/> determinedProxies)
        {
            Contract.Requires(proxy != null);
            Contract.Requires(determinedProxies != null);
            if (determinedProxies.TryGetValue(proxy, out var t))
            {
                // "t" may be null (meaning search for "proxy" is underway or was unsuccessful) or non-null (search for
                // "proxy" has completed successfully), but we return it in either case
                return t;
            }
            determinedProxies.Add(proxy, null);  // record that search for "proxy" is underway
                                                 // First, go through subtype constraints, treating each as if it were an equality
            foreach (var c in AllTypeConstraints)
            {
                t = GetBaseTypeFromProxy_Eq(proxy, c.Super, c.Sub, determinedProxies);
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_14(2783L, t, null))
                {
                    determinedProxies[proxy] = t;
                    return t;
                }
            }
            // Next, check XConstraints that can be seen as equality constraints
            foreach (var xc in AllXConstraints)
            {
                switch (xc.ConstraintName)
                {
                    case "Assignable":
                    case "Equatable":
                    case "EquatableArg":
                        t = GetBaseTypeFromProxy_Eq(proxy, xc.Types[0], xc.Types[1], determinedProxies);
                        if (t != null)
                        {
                            determinedProxies[proxy] = t;
                            return t;
                        }
                        break;
                        break;
                    case "InSet":
                        // etc. TODO
                        break;
                        break;
                    default:
                        break;
                        break;
                }
            }
            return null;
        }
        /// <summary>
        /// Tries to find a non-proxy type corresponding to "proxy", under the assumption that "t" equals "u" and
        /// "determinedProxies" assumptions.  In the process, may add to "determinedProxies".
        /// </summary>
        private Type/*?*/ GetBaseTypeFromProxy_Eq(TypeProxy proxy, Type t, Type u, Dictionary<TypeProxy, Type/*?*/> determinedProxies)
        {
            Contract.Requires(proxy != null);
            Contract.Requires(determinedProxies != null);
            Contract.Requires(t != null);
            Contract.Requires(u != null);
            t = t.NormalizeExpand();
            u = u.NormalizeExpand();
            return GetBaseTypeFromProxy_EqAux(proxy, t, u, determinedProxies) ?? GetBaseTypeFromProxy_EqAux(proxy, u, t, determinedProxies);
        }
        private Type/*?*/ GetBaseTypeFromProxy_EqAux(TypeProxy proxy, Type t, Type u, Dictionary<TypeProxy, Type/*?*/> determinedProxies)
        {
            Contract.Requires(proxy != null);
            Contract.Requires(determinedProxies != null);
            Contract.Requires(t != null && (!(t is TypeProxy) || ((TypeProxy)t).T == null));
            Contract.Requires(u != null && (!(u is TypeProxy) || ((TypeProxy)u).T == null));
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_54(2784L, t, proxy))
            {
                if (u is TypeProxy)
                {
                    return GetBaseTypeFromProxy((TypeProxy)u, determinedProxies);
                }
                else
                {
                    return u;
                }
            }
            else if (t.ContainsProxy(proxy))
            {
                if (u is TypeProxy)
                {
                    u = GetBaseTypeFromProxy((TypeProxy)u, determinedProxies);
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_24(2785L, u, null))
                    {
                        return null;
                    }
                }
                if (Type.SameHead(t, u))
                {
                    Contract.Assert(t.TypeArgs.Count == u.TypeArgs.Count);
                    for (int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(2786L, 0); MutateCSharp.Schemata407.ReplaceBinExprOp_12(2790L, i, t.TypeArgs.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(2795L, ref i))
                    {
                        var r = GetBaseTypeFromProxy_Eq(proxy, t.TypeArgs[i], u.TypeArgs[i], determinedProxies);
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_14(2796L, r, null))
                        {
                            return r;
                        }
                    }
                }
            }
            return null;
        }

        private void GetRelatedTypeProxies(Type t, ISet<TypeProxy> proxies)
        {
            Contract.Requires(t != null);
            Contract.Requires(proxies != null);
            var proxy = t.Normalize() as TypeProxy;
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_32(2798L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_53(2797L, proxy, null), () => proxies.Contains(proxy)))
            {
                return;
            }
            if (Options.Get(CommonOptionBag.TypeInferenceDebug))
            {
                Options.OutputWriter.WriteLine(MutateCSharp.Schemata407.ReplaceStringConstant_1(2804L, "DEBUG: GetRelatedTypeProxies: finding {0} interesting"), proxy);
            }
            proxies.Add(proxy);
            // close over interesting constraints
            foreach (var c in AllTypeConstraints)
            {
                var super = c.Super.Normalize();
                if (super.TypeArgs.Exists(ta => MutateCSharp.Schemata407.ReplaceBinExprOp_54(2805L, ta.Normalize(), proxy)))
                {
                    GetRelatedTypeProxies(c.Sub, proxies);
                }
            }
            foreach (var xc in AllXConstraints)
            {
                var xc0 = xc.Types[MutateCSharp.Schemata407.ReplaceNumericConstant_6(2806L, 0)].Normalize();
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(2820L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_51(2811L, xc.ConstraintName, MutateCSharp.Schemata407.ReplaceStringConstant_1(2810L, "Assignable")), () => (MutateCSharp.Schemata407.ReplaceBinExprOp_32(2814L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_54(2812L, xc0, proxy), () => xc0.TypeArgs.Exists(ta => MutateCSharp.Schemata407.ReplaceBinExprOp_54(2813L, ta.Normalize(), proxy))))))
                {
                    GetRelatedTypeProxies(xc.Types[MutateCSharp.Schemata407.ReplaceNumericConstant_6(2826L, 1)], proxies);
                }
                else if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(2837L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_51(2831L, xc.ConstraintName, MutateCSharp.Schemata407.ReplaceStringConstant_1(2830L, "Innable")), () => MutateCSharp.Schemata407.ReplaceBinExprOp_54(2836L, xc.Types[MutateCSharp.Schemata407.ReplaceNumericConstant_6(2832L, 1)].Normalize(), proxy)))
                {
                    GetRelatedTypeProxies(xc.Types[MutateCSharp.Schemata407.ReplaceNumericConstant_6(2843L, 0)], proxies);
                }
                else if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(2862L, () => (MutateCSharp.Schemata407.ReplaceBinExprOp_32(2851L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_51(2848L, xc.ConstraintName, MutateCSharp.Schemata407.ReplaceStringConstant_1(2847L, "ModifiesFrame")), () => MutateCSharp.Schemata407.ReplaceBinExprOp_51(2850L, xc.ConstraintName, MutateCSharp.Schemata407.ReplaceStringConstant_1(2849L, "ReadsFrame")))), () => MutateCSharp.Schemata407.ReplaceBinExprOp_54(2861L, xc.Types[MutateCSharp.Schemata407.ReplaceNumericConstant_6(2857L, 1)].Normalize(), proxy)))
                {
                    GetRelatedTypeProxies(xc.Types[MutateCSharp.Schemata407.ReplaceNumericConstant_6(2868L, 0)], proxies);
                }
            }
        }

        /// <summary>
        /// Attempts to compute the join of "join", "t", and all of "t"'s known subtype( constraint)s.  The join
        /// ignores type parameters.  It is assumed that "join" on entry already includes the join of all proxies
        /// in "visited". The empty join is represented by "null".
        /// The return is "true" if the join exists.
        /// </summary>
        public bool JoinOfAllSubtypes(Type t, ref Type joinType, ISet<TypeProxy> visited)
        {
            Contract.Requires(t != null);
            Contract.Requires(visited != null);

            t = t.NormalizeExpandKeepConstraints();

            var proxy = t as TypeProxy;
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_29(2872L, proxy, null))
            {
                if (visited.Contains(proxy))
                {
                    return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2873L, true);
                }
                visited.Add(proxy);

                foreach (var c in proxy.SubtypeConstraints)
                {
                    var s = c.Sub.NormalizeExpandKeepConstraints();
                    if (!JoinOfAllSubtypes(s, ref joinType, visited))
                    {
                        return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2874L, false);
                    }
                }
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_24(2875L, joinType, null))
                {
                    // also consider "Assignable" constraints
                    foreach (var c in AllXConstraints)
                    {
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(2883L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_51(2877L, c.ConstraintName, MutateCSharp.Schemata407.ReplaceStringConstant_1(2876L, "Assignable")), () => MutateCSharp.Schemata407.ReplaceBinExprOp_54(2882L, c.Types[MutateCSharp.Schemata407.ReplaceNumericConstant_6(2878L, 0)].Normalize(), proxy)))
                        {
                            var s = c.Types[MutateCSharp.Schemata407.ReplaceNumericConstant_6(2889L, 1)].NormalizeExpandKeepConstraints();
                            if (!JoinOfAllSubtypes(s, ref joinType, visited))
                            {
                                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2893L, false);
                            }
                        }
                    }
                }
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2894L, true);
            }

            if (MutateCSharp.Schemata407.ReplaceBinExprOp_24(2895L, joinType, null))
            {
                // stick with what we've got
                joinType = t;
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2896L, true);
            }
            else if (Type.IsHeadSupertypeOf(joinType, t))
            {
                // stick with what we've got
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2897L, true);
            }
            else if (Type.IsHeadSupertypeOf(t, joinType))
            {
                joinType = Type.HeadWithProxyArgs(t);
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2898L, true);
            }
            else
            {
                joinType = Type.Join(joinType, Type.HeadWithProxyArgs(t), SystemModuleManager);  // the only way this can succeed is if we obtain a (non-null or nullable) trait
                Contract.Assert(joinType == null ||
                                joinType.IsObjectQ || joinType.IsObject ||
                                (joinType is UserDefinedType udt && (udt.ResolvedClass is TraitDecl || (udt.ResolvedClass is NonNullTypeDecl nntd && nntd.Class is TraitDecl))));
                return MutateCSharp.Schemata407.ReplaceBinExprOp_14(2899L, joinType, null);
            }

            return default;
        }

        /// <summary>
        /// Attempts to compute the meet of "meet", all of "t"'s known supertype( constraint)s, and, if "includeT"
        /// and "t" has no supertype( constraint)s, "t".
        /// The meet ignores type parameters. (Really?? --KRML)
        /// It is assumed that "meet" on entry already includes the meet of all proxies
        /// in "visited". The empty meet is represented by "null".
        /// The return is "true" if the meet exists.
        /// </summary>
        bool MeetOfAllSupertypes(Type t, ref Type meet, ISet<TypeProxy> visited, bool includeT)
        {
            Contract.Requires(t != null);
            Contract.Requires(visited != null);

            t = t.NormalizeExpandKeepConstraints();
            var proxy = t as TypeProxy;
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_29(2900L, proxy, null))
            {
                if (visited.Contains(proxy))
                {
                    return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2901L, true);
                }
                visited.Add(proxy);

                var delegatedToOthers = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2902L, false);
                foreach (var c in proxy.SupertypeConstraints)
                {
                    var s = c.Super.NormalizeExpandKeepConstraints();
                    delegatedToOthers = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2903L, true);
                    if (!MeetOfAllSupertypes(s, ref meet, visited, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2904L, true)))
                    {
                        return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2905L, false);
                    }
                }
                if (!delegatedToOthers)
                {
                    // also consider "Assignable" constraints
                    foreach (var c in AllXConstraints)
                    {
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(2913L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_51(2907L, c.ConstraintName, MutateCSharp.Schemata407.ReplaceStringConstant_1(2906L, "Assignable")), () => MutateCSharp.Schemata407.ReplaceBinExprOp_54(2912L, c.Types[MutateCSharp.Schemata407.ReplaceNumericConstant_6(2908L, 1)].Normalize(), proxy)))
                        {
                            var s = c.Types[MutateCSharp.Schemata407.ReplaceNumericConstant_6(2919L, 0)].NormalizeExpandKeepConstraints();
                            delegatedToOthers = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2923L, true);
                            if (!MeetOfAllSupertypes(s, ref meet, visited, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2924L, true)))
                            {
                                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2925L, false);
                            }
                        }
                    }
                }
                if (delegatedToOthers)
                {
                    return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2926L, true);
                }
                else if (!includeT)
                {
                    return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2927L, true);
                }
                else if (MutateCSharp.Schemata407.ReplaceBinExprOp_24(2928L, meet, null) || MutateCSharp.Schemata407.ReplaceBinExprOp_54(2929L, meet.Normalize(), proxy))
                {
                    meet = proxy;
                    return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2930L, true);
                }
                else
                {
                    return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2931L, false);
                }
            }

            if (MutateCSharp.Schemata407.ReplaceBinExprOp_24(2932L, meet, null))
            {
                meet = Type.HeadWithProxyArgs(t);
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2933L, true);
            }
            else if (Type.IsHeadSupertypeOf(t, meet))
            {
                // stick with what we've got
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2934L, true);
            }
            else if (Type.IsHeadSupertypeOf(meet, t))
            {
                meet = Type.HeadWithProxyArgs(t);
                return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(2935L, true);
            }
            else
            {
                meet = Type.Meet(meet, Type.HeadWithProxyArgs(t), SystemModuleManager);
                return MutateCSharp.Schemata407.ReplaceBinExprOp_14(2936L, meet, null);
            }

            return default;
        }

        /// <summary>
        /// Check that the type uses formal type parameters in a way that is agreeable with their variance specifications.
        /// "context == Co" says that "type" is allowed to vary in the positive direction.
        /// "context == Contra" says that "type" is allowed to vary in the negative direction.
        /// "context == Non" says that "type" must not vary at all.
        /// * "lax" says that the context is not strict -- type parameters declared to be strict must not be used in a lax context
        /// </summary>
        public void CheckVariance(Type type, TopLevelDecl enclosingTypeDefinition, TypeParameter.TPVariance context, bool lax)
        {
            Contract.Requires(type != null);
            Contract.Requires(enclosingTypeDefinition != null);
            Contract.Requires(!lax || enclosingTypeDefinition is ICallable);

            type = type.Normalize();  // we keep constraints, since subset types have their own type-parameter variance specifications; we also keep synonyms, since that gives rise to better error messages
            if (type is BasicType)
            {
                // fine
            }
            else if (type is MapType)
            {
                var t = (MapType)type;
                // If its an infinite map, the domain's context is lax
                CheckVariance(t.Domain, enclosingTypeDefinition, context, MutateCSharp.Schemata407.ReplaceBinExprOp_32(2937L, () => lax, () => !t.Finite));
                CheckVariance(t.Range, enclosingTypeDefinition, context, lax);
            }
            else if (type is SetType)
            {
                var t = (SetType)type;
                // If its an infinite set, the argument's context is lax
                CheckVariance(t.Arg, enclosingTypeDefinition, context, MutateCSharp.Schemata407.ReplaceBinExprOp_32(2943L, () => lax, () => !t.Finite));
            }
            else if (type is CollectionType)
            {
                var t = (CollectionType)type;
                CheckVariance(t.Arg, enclosingTypeDefinition, context, lax);
            }
            else if (type is UserDefinedType)
            {
                var t = (UserDefinedType)type;
                if (t.ResolvedClass is TypeParameter tp)
                {
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(2951L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_31(2949L, tp.Variance, TypeParameter.TPVariance.Non), () => MutateCSharp.Schemata407.ReplaceBinExprOp_31(2950L, tp.Variance, context)))
                    {
                        reporter.Error(MessageSource.Resolver, t.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2957L, "formal type parameter '{0}' is not used according to its variance specification"), tp.Name);
                    }
                    else if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(2958L, () => tp.StrictVariance, () => lax))
                    {
                        string hint;
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_106(2964L, tp.VarianceSyntax, TypeParameter.TPVarianceSyntax.NonVariant_Strict))
                        {
                            hint = string.Format(MutateCSharp.Schemata407.ReplaceStringConstant_1(2965L, " (perhaps try declaring '{0}' as '-{0}' or '!{0}')"), tp.Name);
                        }
                        else
                        {
                            Contract.Assert(tp.VarianceSyntax == TypeParameter.TPVarianceSyntax.Covariant_Strict);
                            hint = string.Format(MutateCSharp.Schemata407.ReplaceStringConstant_1(2966L, " (perhaps try changing the declaration from '+{0}' to '*{0}')"), tp.Name);
                        }
                        reporter.Error(MessageSource.Resolver, t.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2967L, "formal type parameter '{0}' is not used according to its variance specification (it is used left of an arrow){1}"), tp.Name, hint);
                    }
                }
                else
                {
                    var resolvedClass = t.ResolvedClass;
                    Contract.Assert(resolvedClass != null);  // follows from that the given type was successfully resolved
                    Contract.Assert(resolvedClass.TypeArgs.Count == t.TypeArgs.Count);
                    if (lax)
                    {
                        // we have to be careful about uses of the type being defined
                        var cg = enclosingTypeDefinition.EnclosingModuleDefinition.CallGraph;
                        if (resolvedClass is ICallable t0 && enclosingTypeDefinition is ICallable t1 && MutateCSharp.Schemata407.ReplaceBinExprOp_107(2968L, cg.GetSCCRepresentative(t0), cg.GetSCCRepresentative(t1)))
                        {
                            reporter.Error(MessageSource.Resolver, t.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2969L, "using the type being defined ('{0}') here would cause a logical inconsistency by defining a type whose cardinality exceeds itself (like the Continuum Transfunctioner, you might say its power would then be exceeded only by its mystery)"), resolvedClass.Name);
                        }
                    }
                    for (int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(2970L, 0); MutateCSharp.Schemata407.ReplaceBinExprOp_12(2974L, i, t.TypeArgs.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(2979L, ref i))
                    {
                        Type p = t.TypeArgs[i];
                        var tpFormal = resolvedClass.TypeArgs[i];
                        CheckVariance(p, enclosingTypeDefinition,
            MutateCSharp.Schemata407.ReplaceBinExprOp_28(2980L, context, TypeParameter.TPVariance.Non) ? context : MutateCSharp.Schemata407.ReplaceBinExprOp_28(2981L, context, TypeParameter.TPVariance.Co) ? tpFormal.Variance :
                          TypeParameter.Negate(tpFormal.Variance),
            MutateCSharp.Schemata407.ReplaceBinExprOp_32(2982L, () => lax, () => !tpFormal.StrictVariance));
                    }
                }
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected type
            }
        }

        /// <summary>
        /// See ConstrainToIntegerType description for the overload above.
        /// </summary>
        public void ConstrainToIntegerType(IToken tok, Type type, bool allowBitVector, TypeConstraint.ErrorMsg errorMsg)
        {
            Contract.Requires(tok != null);
            Contract.Requires(type != null);
            Contract.Requires(errorMsg != null);
            // We do two constraints: the first can aid in determining types, but allows bit-vectors; the second excludes bit-vectors.
            // However, we reuse the error message, so that only one error gets reported.
            ConstrainSubtypeRelation(new IntVarietiesSupertype(), type, errorMsg);
            if (!allowBitVector)
            {
                AddXConstraint(tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(2988L, "IntegerType"), type, errorMsg);
            }
        }

        /// <summary>
        /// Attempts to rewrite a datatype update into more primitive operations, after doing the appropriate resolution checks.
        /// Upon success, returns that rewritten expression and sets "legalSourceConstructors".
        /// Upon some resolution error, return null.
        ///
        /// Actually, the method returns two expressions (or returns "(null, null)"). The first expression is the desugaring to be
        /// used when the DatatypeUpdateExpr is used in a ghost context. The second is to be used for a compiled context. In either
        /// case, "legalSourceConstructors" contains both ghost and compiled constructors.
        ///
        /// The reason for computing both desugarings here is that it's too early to tell if the DatatypeUpdateExpr is being used in
        /// a ghost or compiled context. This is a consequence of doing the deguaring so early. But it's also convenient to do the
        /// desugaring during resolution, because then the desugaring can be constructed as a non-resolved expression on which ResolveExpression
        /// is called--this is easier than constructing an already-resolved expression.
        /// </summary>
        (Expression, Expression) ResolveDatatypeUpdate(IToken tok, Expression root, DatatypeDecl dt, List<Tuple<IToken, string, Expression>> memberUpdates,
          ResolutionContext resolutionContext, out List<MemberDecl> members, out List<DatatypeCtor> legalSourceConstructors)
        {
            Contract.Requires(tok != null);
            Contract.Requires(root != null);
            Contract.Requires(dt != null);
            Contract.Requires(memberUpdates != null);
            Contract.Requires(resolutionContext != null);

            legalSourceConstructors = null;
            members = new List<MemberDecl>();

            // First, compute the list of candidate result constructors, that is, the constructors
            // that have all of the mentioned destructors. Issue errors for duplicated names and for
            // names that are not destructors in the datatype.
            var candidateResultCtors = dt.Ctors;  // list of constructors that have all the so-far-mentioned destructors
            var memberNames = new HashSet<string>();
            var rhsBindings = new Dictionary<string, Tuple<BoundVar/*let variable*/, IdentifierExpr/*id expr for let variable*/, Expression /*RHS in given syntax*/>>();
            var subst = TypeParameter.SubstitutionMap(dt.TypeArgs, root.Type.NormalizeExpand().TypeArgs);
            foreach (var entry in memberUpdates)
            {
                var destructor_str = entry.Item2;
                if (memberNames.Contains(destructor_str))
                {
                    reporter.Error(MessageSource.Resolver, entry.Item1, MutateCSharp.Schemata407.ReplaceStringConstant_1(2989L, "duplicate update member '{0}'"), destructor_str);
                }
                else
                {
                    memberNames.Add(destructor_str);
                    if (!GetClassMembers(dt).TryGetValue(destructor_str, out var member))
                    {
                        reporter.Error(MessageSource.Resolver, entry.Item1, MutateCSharp.Schemata407.ReplaceStringConstant_1(2990L, "member '{0}' does not exist in datatype '{1}'"), destructor_str, dt.Name);
                    }
                    else if (!(member is DatatypeDestructor))
                    {
                        reporter.Error(MessageSource.Resolver, entry.Item1, MutateCSharp.Schemata407.ReplaceStringConstant_1(2991L, "member '{0}' is not a destructor in datatype '{1}'"), destructor_str, dt.Name);
                    }
                    else
                    {
                        members.Add(member);
                        var destructor = (DatatypeDestructor)member;
                        var intersection = new List<DatatypeCtor>(candidateResultCtors.Intersect(destructor.EnclosingCtors));
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(2996L, intersection.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(2992L, 0)))
                        {
                            reporter.Error(MessageSource.Resolver, entry.Item1,
              MutateCSharp.Schemata407.ReplaceStringConstant_1(3001L, "updated datatype members must belong to the same constructor (unlike the previously mentioned destructors, '{0}' does not belong to {1})"),
                              destructor_str, DatatypeDestructor.PrintableCtorNameList(candidateResultCtors, MutateCSharp.Schemata407.ReplaceStringConstant_1(3002L, "or")));
                        }
                        else
                        {
                            candidateResultCtors = intersection;
                            if (destructor.IsGhost)
                            {
                                rhsBindings.Add(destructor_str, new Tuple<BoundVar, IdentifierExpr, Expression>(null, null, entry.Item3));
                            }
                            else
                            {
                                var xName = FreshTempVarName(string.Format(MutateCSharp.Schemata407.ReplaceStringConstant_1(3003L, "dt_update#{0}#"), destructor_str), resolutionContext.CodeContext);
                                var xVar = new BoundVar(new AutoGeneratedToken(tok), xName, destructor.Type.Subst(subst));
                                var x = new IdentifierExpr(new AutoGeneratedToken(tok), xVar);
                                rhsBindings.Add(destructor_str, new Tuple<BoundVar, IdentifierExpr, Expression>(xVar, x, entry.Item3));
                            }
                        }
                    }
                }
            }
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(3008L, candidateResultCtors.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(3004L, 0)))
            {
                return (null, null);
            }

            // Check that every candidate result constructor has given a name to all of its parameters.
            var hasError = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3013L, false);
            foreach (var ctor in candidateResultCtors)
            {
                if (ctor.Formals.Exists(f => !f.HasName))
                {
                    reporter.Error(MessageSource.Resolver, tok,
          MutateCSharp.Schemata407.ReplaceStringConstant_1(3014L, "candidate result constructor '{0}' has an anonymous parameter (to use in datatype update expression, name all the parameters of the candidate result constructors)"),
                      ctor.Name);
                    hasError = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3015L, true);
                }
            }
            if (hasError)
            {
                return (null, null);
            }

            // The legal source constructors are the candidate result constructors. (Yep, two names for the same thing.)
            legalSourceConstructors = candidateResultCtors;
            Contract.Assert(1 <= legalSourceConstructors.Count);

            var desugaringForGhostContext = DesugarDatatypeUpdate(tok, root, dt, candidateResultCtors, rhsBindings, resolutionContext);
            var nonGhostConstructors = candidateResultCtors.Where(ctor => !ctor.IsGhost).ToList();
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(3016L, nonGhostConstructors.Count, candidateResultCtors.Count))
            {
                return (desugaringForGhostContext, desugaringForGhostContext);
            }
            var desugaringForCompiledContext = DesugarDatatypeUpdate(tok, root, dt, nonGhostConstructors, rhsBindings, resolutionContext);
            return (desugaringForGhostContext, desugaringForCompiledContext);
        }

        /// <summary>
        // Rewrite the datatype update root.(x := X, y := Y, ...) to:
        ///     var d := root;
        ///     var x := X;  // EXCEPT: don't do this for ghost fields
        ///     var y := Y;
        ///     ..
        ///     if d.CandidateResultConstructor0 then
        ///       CandidateResultConstructor0(x, y, ..., d.f0, d.f1, ...)  // for a ghost field x, use the expression X directly
        ///     else if d.CandidateResultConstructor1 then
        ///       CandidateResultConstructor0(x, y, ..., d.g0, d.g1, ...)
        ///     ...
        ///     else
        ///       CandidateResultConstructorN(x, y, ..., d.k0, d.k1, ...)
        /// </summary>
        private Expression DesugarDatatypeUpdate(IToken tok, Expression root, DatatypeDecl dt, List<DatatypeCtor> candidateResultCtors,
          Dictionary<string, Tuple<BoundVar, IdentifierExpr, Expression>> rhsBindings, ResolutionContext resolutionContext)
        {

            if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(3025L, candidateResultCtors.Count, MutateCSharp.Schemata407.ReplaceNumericConstant_6(3021L, 0)))
            {
                return root;
            }
            Expression rewrite = null;
            // Create a unique name for d', the variable we introduce in the let expression
            var dName = FreshTempVarName(MutateCSharp.Schemata407.ReplaceStringConstant_1(3030L, "dt_update_tmp#"), resolutionContext.CodeContext);
            var dVar = new BoundVar(new AutoGeneratedToken(tok), dName, root.Type);
            var d = new IdentifierExpr(new AutoGeneratedToken(tok), dVar);
            Expression body = null;
            candidateResultCtors.Reverse();
            foreach (var crc in candidateResultCtors)
            {
                // Build the arguments to the datatype constructor, using the updated value in the appropriate slot
                var ctorArguments = new List<Expression>();
                var actualBindings = new List<ActualBinding>();
                foreach (var f in crc.Formals)
                {
                    Expression ctorArg;
                    if (rhsBindings.TryGetValue(f.Name, out var info))
                    {
                        ctorArg = info.Item2 ?? info.Item3;
                    }
                    else
                    {
                        ctorArg = new ExprDotName(tok, d, f.Name, null);
                    }
                    ctorArguments.Add(ctorArg);
                    var bindingName = new Token(tok.line, tok.col)
                    {
                        Uri = tok.Uri,
                        val = f.Name
                    };
                    actualBindings.Add(new ActualBinding(bindingName, ctorArg));
                }
                var ctor_call = new DatatypeValue(tok, crc.EnclosingDatatype.Name, crc.Name, actualBindings);
                // in the following line, resolve to root.Type, so that type parameters get filled in appropriately
                ResolveDatatypeValue(resolutionContext, ctor_call, dt, root.Type.NormalizeExpand());

                if (MutateCSharp.Schemata407.ReplaceBinExprOp_64(3031L, body, null))
                {
                    body = ctor_call;
                }
                else
                {
                    // body = if d.crc? then ctor_call else body
                    var guard = new ExprDotName(tok, d, crc.QueryField.Name, null);
                    body = new ITEExpr(tok, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3032L, false), guard, ctor_call, body);
                }
            }
            Contract.Assert(body != null); // because there was at least one element in candidateResultCtors

            // Wrap the let's around body
            rewrite = body;
            foreach (var entry in rhsBindings)
            {
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_2(3033L, entry.Value.Item1, null))
                {
                    var lhs = new CasePattern<BoundVar>(tok, entry.Value.Item1);
                    rewrite = new LetExpr(tok, new List<CasePattern<BoundVar>>() { lhs }, new List<Expression>() { entry.Value.Item3 }, rewrite, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3034L, true));
                }
            }
            var dVarPat = new CasePattern<BoundVar>(tok, dVar);
            rewrite = new LetExpr(tok, new List<CasePattern<BoundVar>>() { dVarPat }, new List<Expression>() { root }, rewrite, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3035L, true));
            Contract.Assert(rewrite != null);
            ResolveExpression(rewrite, resolutionContext);
            return rewrite;
        }

        public Expression ResolveNameSegment(NameSegment expr, bool isLastNameSegment, List<ActualBinding> args,
          ResolutionContext resolutionContext, bool allowMethodCall, bool complain = true)
        {
            return ResolveNameSegment(expr, isLastNameSegment, args, resolutionContext, allowMethodCall, complain, out _);
        }

        /// <summary>
        /// Look up expr.Name in the following order:
        ///  0. Local variable, parameter, or bound variable.
        ///     (Language design note:  If this clashes with something of interest, one can always rename the local variable locally.)
        ///  1. Member of enclosing class (an implicit "this" is inserted, if needed)
        ///  2. If isLastNameSegment:
        ///     Unambiguous constructor name of a datatype in the enclosing module (if two constructors have the same name, an error message is produced here)
        ///     (Language design note:  If the constructor name is ambiguous or if one of the steps above takes priority, one can qualify the constructor name with the name of the datatype)
        ///  3. Member of the enclosing module (type name or the name of a module)
        ///  4. Static function or method in the enclosing module or its imports
        ///  5. If !isLastNameSegment:
        ///     Unambiguous constructor name of a datatype in the enclosing module
        ///
        /// </summary>
        /// <param name="expr"></param>
        /// <param name="isLastNameSegment">Indicates that the NameSegment is not directly enclosed in another NameSegment or ExprDotName expression.</param>
        /// <param name="args">If the NameSegment is enclosed in an ApplySuffix, then these are the arguments.  The method returns null to indicate
        /// that these arguments, if any, were not used.  If args is non-null and the method does use them, the method returns the resolved expression
        /// that incorporates these arguments.</param>
        /// <param name="resolutionContext"></param>
        /// <param name="allowMethodCall">If false, generates an error if the name denotes a method. If true and the name denotes a method, returns
        /// a MemberSelectExpr whose .Member is a Method.</param>
        /// <param name="shadowedModule">If the name being resolved shadows an imported module, then that module is reported
        /// through this parameter.  This happens when module <c>Option</c> in <c>import opened Option</c> also contains a
        /// <c>datatype Option</c>, in which case <c>Option</c> refers to the datatype, not the module
        /// (https://github.com/dafny-lang/dafny/issues/1996).</param>
        Expression ResolveNameSegment(NameSegment expr, bool isLastNameSegment, List<ActualBinding> args, ResolutionContext resolutionContext, bool allowMethodCall, bool complain, out ModuleDecl shadowedModule)
        {
            Contract.Requires(expr != null);
            Contract.Requires(!expr.WasResolved());
            Contract.Requires(resolutionContext != null);
            Contract.Ensures(Contract.Result<Expression>() == null || args != null);

            shadowedModule = null;

            if (MutateCSharp.Schemata407.ReplaceBinExprOp_75(3036L, expr.OptTypeArguments, null))
            {
                foreach (var ty in expr.OptTypeArguments)
                {
                    ResolveType(expr.tok, ty, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                }
            }

            Expression r = null;  // the resolved expression, if successful
            Expression rWithArgs = null;  // the resolved expression after incorporating "args"

            // For 0:
            IVariable v;
            // For 1:
            // For 1 and 4:
            MemberDecl member = null;
            // For 2 and 5:
            // For 3:

            var name = resolutionContext.InReveal ? RevealStmt.RevealLemmaPrefix + expr.Name : expr.Name;
            v = scope.Find(name);
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_16(3037L, v, null))
            {
                // ----- 0. local variable, parameter, or bound variable
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_75(3038L, expr.OptTypeArguments, null))
                {
                    if (complain)
                    {
                        reporter.Error(MessageSource.Resolver, expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3039L, "variable '{0}' does not take any type parameters"), name);
                    }
                    else
                    {
                        expr.ResolvedExpression = null;
                        return null;
                    }
                }
                r = new IdentifierExpr(expr.tok, v);
            }
            else if (currentClass is TopLevelDeclWithMembers cl && GetClassMembers(cl)?.TryGetValue(name, out member) == true)
            {
                // ----- 1. member of the enclosing class

                if (!member.IsStatic)
                {
                    if (!scope.AllowInstance)
                    {
                        if (complain)
                        {
                            reporter.Error(MessageSource.Resolver, expr.tok,
              MutateCSharp.Schemata407.ReplaceStringConstant_1(3040L, "'this' is not allowed in a 'static' context")); //TODO: Rephrase this
                        }
                        else
                        {
                            expr.ResolvedExpression = null;
                            return null;
                        }
                        // nevertheless, set "receiver" to a value so we can continue resolution
                    }
                }

                var token = expr.tok;
                var receiver = GetReceiver(currentClass, member, token);
                r = ResolveExprDotCall(token, receiver, null, member, args, expr.OptTypeArguments, resolutionContext, allowMethodCall);
            }
            else if (isLastNameSegment && moduleInfo.Ctors.TryGetValue(name, out var pair))
            {
                // ----- 2. datatype constructor
                if (ResolveDatatypeConstructor(expr, args, resolutionContext, complain, pair, name, ref r, ref rWithArgs))
                {
                    return null;
                }
            }
            else if (moduleInfo.TopLevels.TryGetValue(name, out var decl))
            {
                // ----- 3. Member of the enclosing module

                // Record which imported module, if any, was shadowed by `name` in the current module.
                shadowedModule = moduleInfo.ShadowedImportedModules.GetValueOrDefault(name);

                if (decl is AmbiguousTopLevelDecl)
                {
                    var ad = (AmbiguousTopLevelDecl)decl;
                    if (complain)
                    {
                        reporter.Error(MessageSource.Resolver, expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3041L, "The name {0} ambiguously refers to a type in one of the modules {1} (try qualifying the type name with the module name)"), expr.Name, ad.ModuleNames());
                    }
                    else
                    {
                        expr.ResolvedExpression = null;
                        return null;
                    }
                }
                else
                {
                    // We have found a module name or a type name, neither of which is an expression. However, the NameSegment we're
                    // looking at may be followed by a further suffix that makes this into an expresion. We postpone the rest of the
                    // resolution to any such suffix. For now, we create a temporary expression that will never be seen by the compiler
                    // or verifier, just to have a placeholder where we can recorded what we have found.
                    if (!isLastNameSegment)
                    {
                        if (decl is ClassLikeDecl cd && cd.NonNullTypeDecl != null && MutateCSharp.Schemata407.ReplaceBinExprOp_108(3042L, name, cd.NonNullTypeDecl.Name))
                        {
                            // A possibly-null type C? was mentioned. But it does not have any further members. The program should have used
                            // the name of the class, C. Report an error and continue.
                            if (complain)
                            {
                                reporter.Error(MessageSource.Resolver, expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3043L, "To access members of {0} '{1}', write '{1}', not '{2}'"), decl.WhatKind, decl.Name, name);
                            }
                            else
                            {
                                expr.ResolvedExpression = null;
                                return null;
                            }
                        }
                    }
                    r = CreateResolver_IdentifierExpr(expr.tok, name, expr.OptTypeArguments, decl);
                }

            }
            else if (moduleInfo.StaticMembers.TryGetValue(name, out member))
            {
                // ----- 4. static member of the enclosing module
                Contract.Assert(member.IsStatic); // moduleInfo.StaticMembers is supposed to contain only static members of the module's implicit class _default
                if (member is AmbiguousMemberDecl)
                {
                    var ambiguousMember = (AmbiguousMemberDecl)member;
                    if (complain)
                    {
                        reporter.Error(MessageSource.Resolver, expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3044L, "The name {0} ambiguously refers to a static member in one of the modules {1} (try qualifying the member name with the module name)"), expr.Name, ambiguousMember.ModuleNames());
                    }
                    else
                    {
                        expr.ResolvedExpression = null;
                        return null;
                    }
                }
                else
                {
                    var receiver = new StaticReceiverExpr(expr.tok, (TopLevelDeclWithMembers)member.EnclosingClass, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3045L, true));
                    r = ResolveExprDotCall(expr.tok, receiver, null, member, args, expr.OptTypeArguments, resolutionContext, allowMethodCall);
                }

            }
            else if (!isLastNameSegment && moduleInfo.Ctors.TryGetValue(name, out pair))
            {
                // ----- 5. datatype constructor
                if (ResolveDatatypeConstructor(expr, args, resolutionContext, complain, pair, name, ref r, ref rWithArgs))
                {
                    return null;
                }

            }
            else
            {
                // ----- None of the above
                if (complain)
                {
                    ReportUnresolvedIdentifierError(expr.tok, expr.Name, resolutionContext);
                }
                else
                {
                    expr.ResolvedExpression = null;
                    return null;
                }
            }

            if (MutateCSharp.Schemata407.ReplaceBinExprOp_64(3046L, r, null))
            {
                // an error has been reported above; we won't fill in .ResolvedExpression, but we still must fill in .Type
                expr.Type = new InferredTypeProxy();
            }
            else
            {
                expr.ResolvedExpression = r;
                var rt = r.Type;
                var nt = rt.UseInternalSynonym();
                expr.Type = nt;
            }
            return rWithArgs;
        }

        private void ReportUnresolvedIdentifierError(IToken tok, string name, ResolutionContext resolutionContext)
        {
            if (resolutionContext.InReveal)
            {
                var nameToReport = name.StartsWith(RevealStmt.RevealLemmaPrefix) ? name[RevealStmt.RevealLemmaPrefix.Length..] : name;
                reporter.Error(MessageSource.Resolver, tok,
        MutateCSharp.Schemata407.ReplaceStringConstant_1(3047L, "cannot reveal '{0}' because no revealable constant, function, assert label, or requires label in the current scope is named '{0}'"),
                  nameToReport);
            }
            else
            {
                reporter.Error(MessageSource.Resolver, tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3048L, "unresolved identifier: {0}"), name);
            }
        }

        public static Expression GetReceiver(TopLevelDeclWithMembers container, MemberDecl member, IToken token)
        {
            Expression receiver;
            token = new AutoGeneratedToken(token);
            if (member.IsStatic)
            {
                receiver = new StaticReceiverExpr(token,
                  UserDefinedType.FromTopLevelDecl(token, container, container.TypeArgs),
                  (TopLevelDeclWithMembers)member.EnclosingClass, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3049L, true));
            }
            else
            {
                receiver = new ImplicitThisExpr(token);
                receiver.Type = GetThisType(token, container); // resolve here
            }

            return receiver;
        }

        private bool ResolveDatatypeConstructor(NameSegment expr, List<ActualBinding>/*?*/ args, ResolutionContext resolutionContext, bool complain, Tuple<DatatypeCtor, bool> pair, string name, ref Expression r, ref Expression rWithArgs)
        {
            Contract.Requires(expr != null);
            Contract.Requires(resolutionContext != null);

            if (pair.Item2)
            {
                // there is more than one constructor with this name
                if (complain)
                {
                    reporter.Error(MessageSource.Resolver, expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3050L, "the name '{0}' denotes a datatype constructor, but does not do so uniquely; add an explicit qualification (for example, '{1}.{0}')"), expr.Name,
                      pair.Item1.EnclosingDatatype.Name);
                }
                else
                {
                    expr.ResolvedExpression = null;
                    return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3051L, true);
                }
            }
            else
            {
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_75(3052L, expr.OptTypeArguments, null))
                {
                    if (complain)
                    {
                        reporter.Error(MessageSource.Resolver, expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3053L, "datatype constructor does not take any type parameters ('{0}')"), name);
                    }
                    else
                    {
                        expr.ResolvedExpression = null;
                        return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3054L, true);
                    }
                }
                var rr = new DatatypeValue(expr.tok, pair.Item1.EnclosingDatatype.Name, name, args ?? new List<ActualBinding>());
                bool ok = ResolveDatatypeValue(resolutionContext, rr, pair.Item1.EnclosingDatatype, null, complain);
                if (!ok)
                {
                    expr.ResolvedExpression = null;
                    return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3055L, true);
                }
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_109(3056L, args, null))
                {
                    r = rr;
                }
                else
                {
                    r = rr; // this doesn't really matter, since we're returning an "rWithArgs" (but if would have been proper to have returned the ctor as a lambda)
                    rWithArgs = rr;
                }
            }
            return MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3057L, false);
        }

        /// <summary>
        /// Look up expr.Name in the following order:
        ///  0. Type parameter
        ///  1. Member of enclosing class (an implicit "this" is inserted, if needed)
        ///  2. Member of the enclosing module (type name or the name of a module)
        ///  3. Static function or method in the enclosing module or its imports
        ///
        /// Note: 1 and 3 are not used now, but they will be of interest when async task types are supported.
        /// </summary>
        void ResolveNameSegment_Type(NameSegment expr, ResolutionContext resolutionContext, ResolveTypeOption option, List<TypeParameter> defaultTypeArguments)
        {
            Contract.Requires(expr != null);
            Contract.Requires(!expr.WasResolved());
            Contract.Requires(resolutionContext != null);
            Contract.Requires((option.Opt == ResolveTypeOptionEnum.DontInfer || option.Opt == ResolveTypeOptionEnum.InferTypeProxies) == (defaultTypeArguments == null));

            if (MutateCSharp.Schemata407.ReplaceBinExprOp_75(3058L, expr.OptTypeArguments, null))
            {
                foreach (var ty in expr.OptTypeArguments)
                {
                    ResolveType(expr.tok, ty, resolutionContext, option, defaultTypeArguments);
                }
            }

            Expression r = null;  // the resolved expression, if successful

            // For 0:
            TypeParameter tp;
#if ASYNC_TASK_TYPES
      // For 1:
      Dictionary<string, MemberDecl> members;
      // For 1 and 3:
      MemberDecl member = null;
#endif
            // For 2:

            tp = allTypeParameters.Find(expr.Name);
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_110(3059L, tp, null))
            {
                // ----- 0. type parameter
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_76(3060L, expr.OptTypeArguments, null))
                {
                    r = new Resolver_IdentifierExpr(expr.tok, tp);
                }
                else
                {
                    reporter.Error(MessageSource.Resolver, expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3061L, "Type parameter expects no type arguments: {0}"), expr.Name);
                }
#if ASYNC_TASK_TYPES  // At the moment, there is no way for a class member to part of a type name, but this changes with async task types
      } else if (currentClass != null && classMembers.TryGetValue(currentClass, out members) && members.TryGetValue(expr.Name, out member)) {
        // ----- 1. member of the enclosing class
        Expression receiver;
        if (member.IsStatic) {
          receiver = new StaticReceiverExpr(expr.tok, (ClassLikeDecl)member.EnclosingClass);
        } else {
          if (!scope.AllowInstance) {
            reporter.Error(MessageSource.Resolver, expr.tok, "'this' is not allowed in a 'static' context");
            // nevertheless, set "receiver" to a value so we can continue resolution
          }
          receiver = new ImplicitThisExpr(expr.tok);
          receiver.Type = GetThisType(expr.tok, (ClassLikeDecl)member.EnclosingClass);  // resolve here
        }
        r = ResolveExprDotCall(expr.tok, receiver, member, expr.OptTypeArguments, opts.resolutionContext, allowMethodCall);
#endif
            }
            else if (moduleInfo.TopLevels.TryGetValue(expr.Name, out var decl))
            {
                // ----- 2. Member of the enclosing module
                if (decl is AmbiguousTopLevelDecl)
                {
                    var ad = (AmbiguousTopLevelDecl)decl;
                    reporter.Error(MessageSource.Resolver, expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3062L, "The name {0} ambiguously refers to a type in one of the modules {1} (try qualifying the type name with the module name)"), expr.Name, ad.ModuleNames());
                }
                else
                {
                    // We have found a module name or a type name, neither of which is a type expression. However, the NameSegment we're
                    // looking at may be followed by a further suffix that makes this into a type expresion. We postpone the rest of the
                    // resolution to any such suffix. For now, we create a temporary expression that will never be seen by the compiler
                    // or verifier, just to have a placeholder where we can recorded what we have found.
                    r = CreateResolver_IdentifierExpr(expr.tok, expr.Name, expr.OptTypeArguments, decl);
                }

#if ASYNC_TASK_TYPES  // At the moment, there is no way for a class member to part of a type name, but this changes with async task types
      } else if (moduleInfo.StaticMembers.TryGetValue(expr.Name, out member)) {
        // ----- 3. static member of the enclosing module
        Contract.Assert(member.IsStatic); // moduleInfo.StaticMembers is supposed to contain only static members of the module's implicit class _default
        if (ReallyAmbiguousThing(ref member)) {
          reporter.Error(MessageSource.Resolver, expr.tok, "The name {0} ambiguously refers to a static member in one of the modules {1} (try qualifying the member name with the module name)", expr.Name, ((AmbiguousMemberDecl)member).ModuleNames());
        } else {
          var receiver = new StaticReceiverExpr(expr.tok, (ClassLikeDecl)member.EnclosingClass);
          r = ResolveExprDotCall(expr.tok, receiver, member, expr.OptTypeArguments, opts.resolutionContext, allowMethodCall);
        }
#endif
            }
            else
            {
                // ----- None of the above
                var hint0 = MutateCSharp.Schemata407.ReplaceStringConstant_1(3063L, "(did you forget to qualify a name or declare a module import 'opened'?)");
                var hint1 = MutateCSharp.Schemata407.ReplaceStringConstant_1(3064L, " (note that names in outer modules are not visible in contained modules)");
                var hint2 = "";
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(3067L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_111(3065L, Options.Get(CommonOptionBag.GeneralTraits), CommonOptionBag.GeneralTraitsOptions.Legacy), () => expr.Name.EndsWith(MutateCSharp.Schemata407.ReplaceStringConstant_1(3066L, "?"))))
                {
                    var nameWithoutQuestionMark = expr.Name[..^MutateCSharp.Schemata407.ReplaceNumericConstant_6(3073L, 1)];
                    if (nameWithoutQuestionMark.Length != 0 &&
                        moduleInfo.TopLevels.TryGetValue(nameWithoutQuestionMark, out decl) && decl is TraitDecl)
                    {
                        hint2 =
                          $" (if you intended to refer to a possibly null '{nameWithoutQuestionMark}', " +
            MutateCSharp.Schemata407.ReplaceStringConstant_1(3077L, "then you must declare that trait with 'extends object' to make it a reference type)");
                    }
                }
                reporter.Error(MessageSource.Resolver, expr.tok, $"Type or type parameter is not declared in this scope: {expr.Name} {hint0}{hint1}{hint2}");
            }

            if (MutateCSharp.Schemata407.ReplaceBinExprOp_64(3078L, r, null))
            {
                // an error has been reported above; we won't fill in .ResolvedExpression, but we still must fill in .Type
                expr.Type = new InferredTypeProxy();
            }
            else
            {
                expr.ResolvedExpression = r;
                expr.Type = r.Type;
            }
        }

        /// <summary>
        /// To resolve "id" in expression "E . id", do:
        ///  * If E denotes a module name M:
        ///      0. If isLastNameSegment:
        ///         Unambiguous constructor name of a datatype in module M (if two constructors have the same name, an error message is produced here)
        ///         (Language design note:  If the constructor name is ambiguous or if one of the steps above takes priority, one can qualify the constructor name with the name of the datatype)
        ///      1. Member of module M:  sub-module (including submodules of imports), class, datatype, etc.
        ///         (if two imported types have the same name, an error message is produced here)
        ///      2. Static function or method of M._default
        ///    (Note that in contrast to ResolveNameSegment, imported modules, etc. are ignored)
        ///  * If E denotes a type:
        ///      3. Look up id as a member of that type
        ///  * If E denotes an expression:
        ///      4. Let T be the type of E.  Look up id in T.
        /// </summary>
        /// <param name="expr"></param>
        /// <param name="isLastNameSegment">Indicates that the ExprDotName is not directly enclosed in another ExprDotName expression.</param>
        /// <param name="args">If the ExprDotName is enclosed in an ApplySuffix, then these are the arguments.  The method returns null to indicate
        /// that these arguments, if any, were not used.  If args is non-null and the method does use them, the method returns the resolved expression
        /// that incorporates these arguments.</param>
        /// <param name="resolutionContext"></param>
        /// <param name="allowMethodCall">If false, generates an error if the name denotes a method. If true and the name denotes a method, returns
        /// a Resolver_MethodCall.</param>
        Expression ResolveDotSuffix(ExprDotName expr, bool isLastNameSegment, List<ActualBinding> args, ResolutionContext resolutionContext, bool allowMethodCall)
        {
            Contract.Requires(expr != null);
            Contract.Requires(!expr.WasResolved());
            Contract.Requires(resolutionContext != null);
            Contract.Ensures(Contract.Result<Expression>() == null || args != null);

            // resolve the LHS expression
            // LHS should not be reveal lemma
            ModuleDecl shadowedImport = null;
            ResolutionContext nonRevealOpts = resolutionContext with { InReveal = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3079L, false) };
            if (expr.Lhs is NameSegment)
            {
                ResolveNameSegment((NameSegment)expr.Lhs, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3080L, false), null, nonRevealOpts, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3081L, false), MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3082L, true), out shadowedImport);
            }
            else if (expr.Lhs is ExprDotName)
            {
                ResolveDotSuffix((ExprDotName)expr.Lhs, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3083L, false), null, nonRevealOpts, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3084L, false));
            }
            else
            {
                ResolveExpression(expr.Lhs, nonRevealOpts);
            }

            if (MutateCSharp.Schemata407.ReplaceBinExprOp_75(3085L, expr.OptTypeArguments, null))
            {
                foreach (var ty in expr.OptTypeArguments)
                {
                    ResolveType(expr.tok, ty, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                }
            }

            Expression r = null;  // the resolved expression, if successful
            Expression rWithArgs = null;  // the resolved expression after incorporating "args"
            MemberDecl member = null;

            var name = resolutionContext.InReveal ? RevealStmt.RevealLemmaPrefix + expr.SuffixName : expr.SuffixName;
            if (!expr.Lhs.WasResolved())
            {
                return null;
            }
            var lhs = expr.Lhs.Resolved;
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(3087L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_4(3086L, lhs, null), () => lhs.Type is Resolver_IdentifierExpr.ResolverType_Module))
            {
                var ri = (Resolver_IdentifierExpr)lhs;
                var sig = ((ModuleDecl)ri.Decl).AccessibleSignature(MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3093L, false));
                sig = GetSignature(sig);
                // For 0:
                // For 1:

                if (isLastNameSegment && sig.Ctors.TryGetValue(name, out var pair))
                {
                    // ----- 0. datatype constructor
                    if (pair.Item2)
                    {
                        // there is more than one constructor with this name
                        reporter.Error(MessageSource.Resolver, expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3094L, "the name '{0}' denotes a datatype constructor in module {2}, but does not do so uniquely; add an explicit qualification (for example, '{1}.{0}')"), name, pair.Item1.EnclosingDatatype.Name, ((ModuleDecl)ri.Decl).Name);
                    }
                    else
                    {
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_75(3095L, expr.OptTypeArguments, null))
                        {
                            reporter.Error(MessageSource.Resolver, expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3096L, "datatype constructor does not take any type parameters ('{0}')"), name);
                        }
                        var rr = new DatatypeValue(expr.tok, pair.Item1.EnclosingDatatype.Name, name, args ?? new List<ActualBinding>());
                        ResolveDatatypeValue(resolutionContext, rr, pair.Item1.EnclosingDatatype, null);

                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_109(3097L, args, null))
                        {
                            r = rr;
                        }
                        else
                        {
                            r = rr;  // this doesn't really matter, since we're returning an "rWithArgs" (but if would have been proper to have returned the ctor as a lambda)
                            rWithArgs = rr;
                        }
                    }
                }
                else if (sig.TopLevels.TryGetValue(name, out var decl))
                {
                    // ----- 1. Member of the specified module
                    if (decl is AmbiguousTopLevelDecl)
                    {
                        var ad = (AmbiguousTopLevelDecl)decl;
                        reporter.Error(MessageSource.Resolver, expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3098L, "The name {0} ambiguously refers to a type in one of the modules {1} (try qualifying the type name with the module name)"), expr.SuffixName, ad.ModuleNames());
                    }
                    else
                    {
                        // We have found a module name or a type name, neither of which is an expression. However, the ExprDotName we're
                        // looking at may be followed by a further suffix that makes this into an expresion. We postpone the rest of the
                        // resolution to any such suffix. For now, we create a temporary expression that will never be seen by the compiler
                        // or verifier, just to have a placeholder where we can recorded what we have found.
                        if (!isLastNameSegment)
                        {
                            if (decl is ClassLikeDecl cd && cd.NonNullTypeDecl != null && MutateCSharp.Schemata407.ReplaceBinExprOp_108(3099L, name, cd.NonNullTypeDecl.Name))
                            {
                                // A possibly-null type C? was mentioned. But it does not have any further members. The program should have used
                                // the name of the class, C. Report an error and continue.
                                reporter.Error(MessageSource.Resolver, expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3100L, "To access members of {0} '{1}', write '{1}', not '{2}'"), decl.WhatKind, decl.Name, name);
                            }
                        }
                        r = CreateResolver_IdentifierExpr(expr.tok, name, expr.OptTypeArguments, decl);
                    }
                }
                else if (sig.StaticMembers.TryGetValue(name, out member))
                {
                    // ----- 2. static member of the specified module
                    Contract.Assert(member.IsStatic); // moduleInfo.StaticMembers is supposed to contain only static members of the module's implicit class _default
                    if (member is AmbiguousMemberDecl)
                    {
                        var ambiguousMember = (AmbiguousMemberDecl)member;
                        reporter.Error(MessageSource.Resolver, expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3101L, "The name {0} ambiguously refers to a static member in one of the modules {1} (try qualifying the member name with the module name)"), expr.SuffixName, ambiguousMember.ModuleNames());
                    }
                    else
                    {
                        var receiver = new StaticReceiverExpr(expr.Lhs.tok, (TopLevelDeclWithMembers)member.EnclosingClass, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3102L, false));
                        receiver.ContainerExpression = expr.Lhs;
                        r = ResolveExprDotCall(expr.tok, receiver, null, member, args, expr.OptTypeArguments, resolutionContext, allowMethodCall);
                    }
                }
                else
                {
                    ReportUnresolvedIdentifierError(expr.tok, name, resolutionContext);
                }

            }
            else if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(3104L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_4(3103L, lhs, null), () => lhs.Type is Resolver_IdentifierExpr.ResolverType_Type))
            {
                var ri = (Resolver_IdentifierExpr)lhs;
                // ----- 3. Look up name in type
                // expand any synonyms
                var ty = new UserDefinedType(expr.tok, ri.Decl.Name, ri.Decl, ri.TypeArgs).NormalizeExpand();
                if (ty.IsDatatype)
                {
                    // ----- LHS is a datatype
                    var dt = ty.AsDatatype;
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_112(3110L, dt.ConstructorsByName, null) && dt.ConstructorsByName.TryGetValue(name, out var ctor))
                    {
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_75(3111L, expr.OptTypeArguments, null))
                        {
                            reporter.Error(MessageSource.Resolver, expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3112L, "datatype constructor does not take any type parameters ('{0}')"), name);
                        }
                        var rr = new DatatypeValue(expr.tok, ctor.EnclosingDatatype.Name, name, args ?? new List<ActualBinding>());
                        ResolveDatatypeValue(resolutionContext, rr, ctor.EnclosingDatatype, ty);
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_109(3113L, args, null))
                        {
                            r = rr;
                        }
                        else
                        {
                            r = rr;  // this doesn't really matter, since we're returning an "rWithArgs" (but if would have been proper to have returned the ctor as a lambda)
                            rWithArgs = rr;
                        }
                    }
                }
                var cd = MutateCSharp.Schemata407.ReplaceBinExprOp_64(3114L, r, null) ? ty.AsTopLevelTypeWithMembersBypassInternalSynonym : null;
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_100(3115L, cd, null))
                {
                    // ----- LHS is a type with members
                    if (GetClassMembers(cd)?.TryGetValue(name, out member) == MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3116L, true))
                    {
                        if (!VisibleInScope(member))
                        {
                            reporter.Error(MessageSource.Resolver, expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3117L, "member '{0}' has not been imported in this scope and cannot be accessed here"), name);
                        }
                        if (!member.IsStatic)
                        {
                            reporter.Error(MessageSource.Resolver, expr.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3118L, "accessing member '{0}' requires an instance expression"), name); //TODO Unify with similar error messages
                                                                                                                                                                                                       // nevertheless, continue creating an expression that approximates a correct one
                        }
                        var receiver = new StaticReceiverExpr(expr.Lhs.tok, (UserDefinedType)ty.NormalizeExpand(), (TopLevelDeclWithMembers)member.EnclosingClass, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3119L, false));
                        receiver.ContainerExpression = expr.Lhs;
                        r = ResolveExprDotCall(expr.tok, receiver, null, member, args, expr.OptTypeArguments, resolutionContext, allowMethodCall);
                    }
                }
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_64(3120L, r, null))
                {
                    ReportMemberNotFoundError(expr.tok, name, ri.Decl);
                }
            }
            else if (MutateCSharp.Schemata407.ReplaceBinExprOp_4(3121L, lhs, null))
            {
                // ----- 4. Look up name in the type of the Lhs
                member = ResolveMember(expr.tok, expr.Lhs.Type, name, out var tentativeReceiverType);
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_84(3122L, member, null))
                {
                    Expression receiver;
                    if (!member.IsStatic)
                    {
                        receiver = expr.Lhs;
                        AddAssignableConstraint(expr.tok, tentativeReceiverType, receiver.Type, MutateCSharp.Schemata407.ReplaceStringConstant_1(3123L, "receiver type ({1}) does not have a member named ") + name);
                        r = ResolveExprDotCall(expr.tok, receiver, tentativeReceiverType, member, args, expr.OptTypeArguments, resolutionContext, allowMethodCall);
                    }
                    else
                    {
                        receiver = new StaticReceiverExpr(expr.tok, (UserDefinedType)tentativeReceiverType, (TopLevelDeclWithMembers)member.EnclosingClass, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3124L, false), lhs);
                        r = ResolveExprDotCall(expr.tok, receiver, null, member, args, expr.OptTypeArguments, resolutionContext, allowMethodCall);
                    }
                }
            }

            if (MutateCSharp.Schemata407.ReplaceBinExprOp_64(3125L, r, null))
            {
                // an error has been reported above; we won't fill in .ResolvedExpression, but we still must fill in .Type
                expr.Type = new InferredTypeProxy();
            }
            else
            {
                CheckForAmbiguityInShadowedImportedModule(shadowedImport, name, expr.tok, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3126L, false), isLastNameSegment);
                expr.ResolvedExpression = r;
                expr.Type = r.Type;
            }
            return rWithArgs;
        }

        /// <summary>
        /// Check whether the name we just resolved may have been resolved differently if we didn't allow member `M.M` of
        /// module `M` to shadow `M` when the user writes `import opened M`.  Raising an error in that case allowed us to
        /// change the behavior of `import opened` without silently changing the meaning of existing programs.
        /// (https://github.com/dafny-lang/dafny/issues/1996)
        ///
        /// Note the extra care for the constructor case, which is needed because the constructors of datatype `M.M` are
        /// exposed through both `M` and `M.M`, without ambiguity.
        /// </summary>
        private void CheckForAmbiguityInShadowedImportedModule(ModuleDecl moduleDecl, string name,
          IToken tok, bool useCompileSignatures, bool isLastNameSegment)
        {
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(3128L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_113(3127L, moduleDecl, null), () => NameConflictsWithModuleContents(moduleDecl, name, useCompileSignatures, isLastNameSegment)))
            {
                reporter.Error(MessageSource.Resolver, tok,
        MutateCSharp.Schemata407.ReplaceStringConstant_1(3134L, "Reference to member '{0}' is ambiguous: name '{1}' shadows an import-opened module of the same name, and "
        ) + MutateCSharp.Schemata407.ReplaceStringConstant_1(3135L, "both have a member '{0}'. To solve this issue, give a different name to the imported module using "
        ) + MutateCSharp.Schemata407.ReplaceStringConstant_1(3136L, "`import opened XYZ = ...` instead of `import opened ...`."),
                  name, moduleDecl.Name);
            }
        }

        private bool NameConflictsWithModuleContents(ModuleDecl moduleDecl, string name, bool useCompileSignatures, bool isLastNameSegment)
        {
            var sig = GetSignature(moduleDecl.AccessibleSignature(useCompileSignatures));
            return (
              (isLastNameSegment
               && sig.Ctors.GetValueOrDefault(name) is { Item1: var constructor, Item2: var ambiguous }
               && !ambiguous && constructor.EnclosingDatatype.Name != moduleDecl.Name)
              || sig.TopLevels.ContainsKey(name)
              || sig.StaticMembers.ContainsKey(name)
            );
        }

        Expression ResolveExprDotCall(IToken tok, Expression receiver, Type receiverTypeBound/*?*/,
          MemberDecl member, List<ActualBinding> args, List<Type> optTypeArguments, ResolutionContext resolutionContext, bool allowMethodCall)
        {
            Contract.Requires(tok != null);
            Contract.Requires(receiver != null);
            Contract.Requires(receiver.WasResolved());
            Contract.Requires(member != null);
            Contract.Requires(resolutionContext != null && resolutionContext.CodeContext != null);

            var rr = new MemberSelectExpr(tok, receiver, member.Name);
            rr.Member = member;

            // Now, fill in rr.Type.  This requires taking into consideration the type parameters passed to the receiver's type as well as any type
            // parameters used in this NameSegment/ExprDotName.
            // Add to "subst" the type parameters given to the member's class/datatype
            rr.TypeApplication_AtEnclosingClass = new List<Type>();
            rr.TypeApplication_JustMember = new List<Type>();
            Dictionary<TypeParameter, Type> subst;
            var rType = (receiverTypeBound ?? receiver.Type).NormalizeExpand();
            if (rType is UserDefinedType udt && MutateCSharp.Schemata407.ReplaceBinExprOp_30(3137L, udt.ResolvedClass, null))
            {
                subst = TypeParameter.SubstitutionMap(udt.ResolvedClass.TypeArgs, udt.TypeArgs);
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_45(3138L, member.EnclosingClass, null))
                {
                    // this can happen for some special members, like real.Floor
                }
                else
                {
                    rr.TypeApplication_AtEnclosingClass.AddRange(rType.AsParentType(member.EnclosingClass).TypeArgs);
                }
            }
            else
            {
                var vtd = ProgramResolver.SystemModuleManager.AsValuetypeDecl(rType);
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_114(3139L, vtd, null))
                {
                    Contract.Assert(vtd.TypeArgs.Count == rType.TypeArgs.Count);
                    subst = TypeParameter.SubstitutionMap(vtd.TypeArgs, rType.TypeArgs);
                    rr.TypeApplication_AtEnclosingClass.AddRange(rType.TypeArgs);
                }
                else
                {
                    Contract.Assert(rType.TypeArgs.Count == 0);
                    subst = new Dictionary<TypeParameter, Type>();
                }
            }

            if (member is Field)
            {
                var field = (Field)member;
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_75(3140L, optTypeArguments, null))
                {
                    reporter.Error(MessageSource.Resolver, tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3141L, "a field ({0}) does not take any type arguments (got {1})"), field.Name, optTypeArguments.Count);
                }
                subst = BuildTypeArgumentSubstitute(subst, receiverTypeBound ?? receiver.Type);
                rr.Type = field.Type.Subst(subst);
            }
            else if (member is Function)
            {
                var fn = (Function)member;
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(3142L, () => fn is TwoStateFunction, () => !resolutionContext.IsTwoState))
                {
                    reporter.Error(MessageSource.Resolver, tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3148L, "two-state function ('{0}') can only be called in a two-state context"), member.Name);
                }
                int suppliedTypeArguments = MutateCSharp.Schemata407.ReplaceBinExprOp_76(3149L, optTypeArguments, null) ? MutateCSharp.Schemata407.ReplaceNumericConstant_6(3150L, 0) : optTypeArguments.Count;
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(3160L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_75(3154L, optTypeArguments, null), () => MutateCSharp.Schemata407.ReplaceBinExprOp_21(3155L, suppliedTypeArguments, fn.TypeArgs.Count)))
                {
                    reporter.Error(MessageSource.Resolver, tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3166L, "function '{0}' expects {1} type argument{2} (got {3})"),
                      member.Name, fn.TypeArgs.Count, Util.Plural(fn.TypeArgs.Count), suppliedTypeArguments);
                }
                for (int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(3167L, 0); MutateCSharp.Schemata407.ReplaceBinExprOp_12(3171L, i, fn.TypeArgs.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(3176L, ref i))
                {
                    var ta = MutateCSharp.Schemata407.ReplaceBinExprOp_12(3177L, i, suppliedTypeArguments) ? optTypeArguments[i] : new InferredTypeProxy();
                    rr.TypeApplication_JustMember.Add(ta);
                    subst.Add(fn.TypeArgs[i], ta);
                }
                subst = BuildTypeArgumentSubstitute(subst, receiverTypeBound ?? receiver.Type);
                rr.Type = SelectAppropriateArrowTypeForFunction(fn, subst, SystemModuleManager);
            }
            else
            {
                // the member is a method
                var m = (Method)member;
                if (!allowMethodCall)
                {
                    // it's a method and method calls are not allowed in the given context
                    reporter.Error(MessageSource.Resolver, tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3182L, "expression is not allowed to invoke a {0} ({1})"), member.WhatKind, member.Name);
                }
                int suppliedTypeArguments = MutateCSharp.Schemata407.ReplaceBinExprOp_76(3183L, optTypeArguments, null) ? MutateCSharp.Schemata407.ReplaceNumericConstant_6(3184L, 0) : optTypeArguments.Count;
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(3194L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_75(3188L, optTypeArguments, null), () => MutateCSharp.Schemata407.ReplaceBinExprOp_21(3189L, suppliedTypeArguments, m.TypeArgs.Count)))
                {
                    reporter.Error(MessageSource.Resolver, tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3200L, "method '{0}' expects {1} type argument{2} (got {3})"),
                      member.Name, m.TypeArgs.Count, Util.Plural(m.TypeArgs.Count), suppliedTypeArguments);
                }
                for (int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(3201L, 0); MutateCSharp.Schemata407.ReplaceBinExprOp_12(3205L, i, m.TypeArgs.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(3210L, ref i))
                {
                    var ta = MutateCSharp.Schemata407.ReplaceBinExprOp_12(3211L, i, suppliedTypeArguments) ? optTypeArguments[i] : new InferredTypeProxy();
                    rr.TypeApplication_JustMember.Add(ta);
                    subst.Add(m.TypeArgs[i], ta);
                }
                subst = BuildTypeArgumentSubstitute(subst, receiverTypeBound ?? receiver.Type);
                rr.ResolvedOutparameterTypes = m.Outs.ConvertAll(f => f.Type.Subst(subst));
                rr.Type = new InferredTypeProxy();  // fill in this field, in order to make "rr" resolved
            }
            return rr;
        }

        public MethodCallInformation ResolveApplySuffix(ApplySuffix e, ResolutionContext resolutionContext, bool allowMethodCall)
        {
            Contract.Requires(e != null);
            Contract.Requires(resolutionContext != null);
            Contract.Ensures(Contract.Result<MethodCallInformation>() == null || allowMethodCall);
            Expression r = null;  // upon success, the expression to which the ApplySuffix resolves
            var errorCount = reporter.Count(ErrorLevel.Error);
            if (e.Lhs is NameSegment)
            {
                r = ResolveNameSegment((NameSegment)e.Lhs, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3216L, true), e.Bindings.ArgumentBindings, resolutionContext, allowMethodCall);
                // note, if r is non-null, then e.Args have been resolved and r is a resolved expression that incorporates e.Args
            }
            else if (e.Lhs is ExprDotName)
            {
                r = ResolveDotSuffix((ExprDotName)e.Lhs, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3217L, true), e.Bindings.ArgumentBindings, resolutionContext, allowMethodCall);
                // note, if r is non-null, then e.Args have been resolved and r is a resolved expression that incorporates e.Args
            }
            else
            {
                ResolveExpression(e.Lhs, resolutionContext);
            }
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_24(3218L, e.Lhs.Type, null))
            {
                // some error had been detected during the attempted resolution of e.Lhs
                e.Lhs.Type = new InferredTypeProxy();
            }
            Label atLabel = null;
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_72(3219L, e.AtTok, null))
            {
                atLabel = DominatingStatementLabels.Find(e.AtTok.val);
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_0(3220L, atLabel, null))
                {
                    reporter.Error(MessageSource.Resolver, e.AtTok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3221L, "no label '{0}' in scope at this time"), e.AtTok.val);
                }
            }
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_64(3222L, r, null))
            {
                var improvedType = PartiallyResolveTypeForMemberSelection(e.Lhs.tok, e.Lhs.Type, MutateCSharp.Schemata407.ReplaceStringConstant_1(3223L, "_#apply"));
                var fnType = improvedType.AsArrowType;
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_20(3224L, fnType, null))
                {
                    var lhs = e.Lhs.Resolved;
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(3226L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_4(3225L, lhs, null), () => lhs.Type is Resolver_IdentifierExpr.ResolverType_Module))
                    {
                        reporter.Error(MessageSource.Resolver, e.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3232L, "name of module ({0}) is used as a function"), ((Resolver_IdentifierExpr)lhs).Decl.Name);
                    }
                    else if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(3234L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_4(3233L, lhs, null), () => lhs.Type is Resolver_IdentifierExpr.ResolverType_Type))
                    {
                        var ri = (Resolver_IdentifierExpr)lhs;
                        reporter.Error(MessageSource.Resolver, e.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3240L, "name of {0} ({1}) is used as a function"), ri.Decl.WhatKind, ri.Decl.Name);
                    }
                    else
                    {
                        if (lhs is MemberSelectExpr mse && mse.Member is Method)
                        {
                            if (MutateCSharp.Schemata407.ReplaceBinExprOp_62(3241L, atLabel, null))
                            {
                                Contract.Assert(mse != null); // assured by the parser
                                if (mse.Member is TwoStateLemma)
                                {
                                    mse.AtLabel = atLabel;
                                }
                                else
                                {
                                    reporter.Error(MessageSource.Resolver, e.AtTok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3242L, "an @-label can only be applied to a two-state lemma"));
                                }
                            }
                            if (allowMethodCall)
                            {
                                Contract.Assert(!e.Bindings.WasResolved); // we expect that .Bindings has not yet been processed, so we use just .ArgumentBindings in the next line
                                var tok = Options.Get(Snippets.ShowSnippets) ? e.RangeToken.ToToken() : e.tok;
                                var cRhs = new MethodCallInformation(tok, mse, e.Bindings.ArgumentBindings);
                                return cRhs;
                            }
                            else
                            {
                                reporter.Error(MessageSource.Resolver, e.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3243L, "{0} call is not allowed to be used in an expression context ({1})"), mse.Member.WhatKind, mse.Member.Name);
                            }
                        }
                        else if (MutateCSharp.Schemata407.ReplaceBinExprOp_4(3244L, lhs, null))
                        {  // if e.Lhs.Resolved is null, then e.Lhs was not successfully resolved and an error has already been reported
                            reporter.Error(MessageSource.Resolver, e.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3245L, "non-function expression (of type {0}) is called with parameters"), e.Lhs.Type);
                        }
                    }
                    // resolve the arguments, even in the presence of the errors above
                    foreach (var binding in e.Bindings.ArgumentBindings)
                    {
                        ResolveExpression(binding.Actual, resolutionContext);
                    }
                }
                else
                {
                    var mse = MutateCSharp.Schemata407.ReplaceBinExprOp_32(3246L, () => e.Lhs is NameSegment, () => e.Lhs is ExprDotName) ? e.Lhs.Resolved as MemberSelectExpr : null;
                    var callee = MutateCSharp.Schemata407.ReplaceBinExprOp_78(3252L, mse, null) ? null : mse.Member as Function;
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(3254L, () => MutateCSharp.Schemata407.ReplaceBinExprOp_62(3253L, atLabel, null), () => !(callee is TwoStateFunction)))
                    {
                        reporter.Error(MessageSource.Resolver, e.AtTok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3260L, "an @-label can only be applied to a two-state function"));
                        atLabel = null;
                    }
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_115(3261L, callee, null))
                    {
                        // produce a FunctionCallExpr instead of an ApplyExpr(MemberSelectExpr)
                        var rr = new FunctionCallExpr(e.Lhs.tok, callee.Name, mse.Obj, e.tok, e.CloseParen, e.Bindings, atLabel)
                        {
                            Function = callee,
                            TypeApplication_AtEnclosingClass = mse.TypeApplication_AtEnclosingClass,
                            TypeApplication_JustFunction = mse.TypeApplication_JustMember
                        };
                        var typeMap = BuildTypeArgumentSubstitute(mse.TypeArgumentSubstitutionsAtMemberDeclaration());
                        ResolveActualParameters(rr.Bindings, callee.Ins, e.tok, callee, resolutionContext, typeMap, callee.IsStatic ? null : mse.Obj);
                        rr.Type = callee.ResultType.Subst(typeMap);
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_7(3262L, errorCount, reporter.Count(ErrorLevel.Error)))
                        {
                            Contract.Assert(!(mse.Obj is StaticReceiverExpr) || callee.IsStatic);  // this should have been checked already
                            Contract.Assert(callee.Ins.Count == rr.Args.Count);  // this should have been checked already
                        }
                        r = rr;
                    }
                    else
                    {
                        List<Formal> formals;
                        if (MutateCSharp.Schemata407.ReplaceBinExprOp_115(3267L, callee, null))
                        {
                            formals = callee.Ins;
                        }
                        else
                        {
                            formals = new List<Formal>();
                            for (var i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(3268L, 0); MutateCSharp.Schemata407.ReplaceBinExprOp_12(3272L, i, fnType.Args.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(3277L, ref i))
                            {
                                var argType = fnType.Args[i];
                                var formal = new ImplicitFormal(e.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3278L, "_#p") + i, argType, MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3279L, true), MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3280L, false));
                                formals.Add(formal);
                            }
                        }
                        ResolveActualParameters(e.Bindings, formals, e.tok, fnType, resolutionContext, new Dictionary<TypeParameter, Type>(), null);
                        r = new ApplyExpr(e.Lhs.tok, e.Lhs, e.Args, e.CloseParen);
                        r.Type = fnType.Result;
                    }
                }
            }
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_64(3281L, r, null))
            {
                // an error has been reported above; we won't fill in .ResolvedExpression, but we still must fill in .Type
                e.Type = new InferredTypeProxy();
            }
            else
            {
                e.ResolvedExpression = r;
                e.Type = r.Type;
            }
            return null;
        }

        /// <summary>
        /// the return value is false iff there is an error in resolving the datatype value;
        /// if there is an error then an error message is emitted iff complain is true
        /// </summary>
        private bool ResolveDatatypeValue(ResolutionContext resolutionContext, DatatypeValue dtv, DatatypeDecl dt, Type ty, bool complain = true)
        {
            Contract.Requires(resolutionContext != null);
            Contract.Requires(dtv != null);
            Contract.Requires(dt != null);
            Contract.Requires(ty == null || (ty.AsDatatype == dt && ty.TypeArgs.Count == dt.TypeArgs.Count));

            var ok = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3282L, true);
            var gt = new List<Type>(dt.TypeArgs.Count);
            var subst = new Dictionary<TypeParameter, Type>();
            for (int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(3283L, 0); MutateCSharp.Schemata407.ReplaceBinExprOp_12(3287L, i, dt.TypeArgs.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(3292L, ref i))
            {
                Type t = MutateCSharp.Schemata407.ReplaceBinExprOp_24(3293L, ty, null) ? new InferredTypeProxy() : ty.TypeArgs[i];
                gt.Add(t);
                dtv.InferredTypeArgs.Add(t);
                subst.Add(dt.TypeArgs[i], t);
            }
            // Construct a resolved type directly, as we know the declaration is dt.
            dtv.Type = new UserDefinedType(dtv.tok, dt.Name, dt, gt);

            if (!dt.ConstructorsByName.TryGetValue(dtv.MemberName, out var ctor))
            {
                ok = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3294L, false);
                if (complain)
                {
                    reporter.Error(MessageSource.Resolver, dtv.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3295L, "undeclared constructor {0} in datatype {1}"), dtv.MemberName, dtv.DatatypeName);
                }
            }
            else
            {
                Contract.Assert(ctor != null);  // follows from postcondition of TryGetValue
                dtv.Ctor = ctor;
            }
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(3297L, () => complain, () => MutateCSharp.Schemata407.ReplaceBinExprOp_116(3296L, ctor, null)))
            {
                ResolveActualParameters(dtv.Bindings, ctor.Formals, dtv.tok, ctor, resolutionContext, subst, null);
            }
            else
            {
                // still resolve the expressions
                foreach (var binding in dtv.Bindings.ArgumentBindings)
                {
                    ResolveExpression(binding.Actual, resolutionContext);
                }
                dtv.Bindings.AcceptArgumentExpressionsAsExactParameterList();
            }

            return MutateCSharp.Schemata407.ReplaceBinExprOp_9(3308L, () => ok, () => MutateCSharp.Schemata407.ReplaceBinExprOp_7(3303L, ctor.Formals.Count, dtv.Arguments.Count));
        }

        public void ResolveFunctionCallExpr(FunctionCallExpr e, ResolutionContext resolutionContext)
        {
            Contract.Requires(e != null);
            Contract.Requires(e.Type == null);  // should not have been type checked before

            ResolveReceiver(e.Receiver, resolutionContext);
            Contract.Assert(e.Receiver.Type != null);  // follows from postcondition of ResolveExpression

            var member = ResolveMember(e.tok, e.Receiver.Type, e.Name, out var tentativeReceiverType);
#if !NO_WORK_TO_BE_DONE
            var ctype = (UserDefinedType)tentativeReceiverType;
#endif
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_17(3314L, member, null))
            {
                // error has already been reported by ResolveMember
            }
            else if (member is Method)
            {
                reporter.Error(MessageSource.Resolver, e, MutateCSharp.Schemata407.ReplaceStringConstant_1(3315L, "member {0} in type {1} refers to a method, but only functions can be used in this context"), e.Name, cce.NonNull(ctype).Name);
            }
            else if (!(member is Function))
            {
                reporter.Error(MessageSource.Resolver, e, MutateCSharp.Schemata407.ReplaceStringConstant_1(3316L, "member {0} in type {1} does not refer to a function"), e.Name, cce.NonNull(ctype).Name);
            }
            else
            {
                Function function = (Function)member;
                e.Function = function;
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(3317L, () => function is TwoStateFunction, () => !resolutionContext.IsTwoState))
                {
                    reporter.Error(MessageSource.Resolver, e.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3323L, "a two-state function can be used only in a two-state context"));
                }
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(3324L, () => e.Receiver is StaticReceiverExpr, () => !function.IsStatic))
                {
                    reporter.Error(MessageSource.Resolver, e, MutateCSharp.Schemata407.ReplaceStringConstant_1(3330L, "an instance function must be selected via an object, not just a class name"));
                }
                Contract.Assert(ctype != null);  // follows from postcondition of ResolveMember
                if (!function.IsStatic)
                {
                    if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(3331L, () => !scope.AllowInstance, () => e.Receiver is ThisExpr))
                    {
                        // The call really needs an instance, but that instance is given as 'this', which is not
                        // available in this context.  In most cases, occurrences of 'this' inside e.Receiver would
                        // have been caught in the recursive call to resolve e.Receiver, but not the specific case
                        // of e.Receiver being 'this' (explicitly or implicitly), for that case needs to be allowed
                        // in the event that a static function calls another static function (and note that we need the
                        // type of the receiver in order to find the method, so we could not have made this check
                        // earlier).
                        reporter.Error(MessageSource.Resolver, e.Receiver, MutateCSharp.Schemata407.ReplaceStringConstant_1(3337L, "'this' is not allowed in a 'static' context"));
                    }
                    else if (e.Receiver is StaticReceiverExpr)
                    {
                        reporter.Error(MessageSource.Resolver, e.Receiver, MutateCSharp.Schemata407.ReplaceStringConstant_1(3338L, "call to instance function requires an instance"));
                    }
                }
                // build the type substitution map
                var typeMap = new Dictionary<TypeParameter, Type>();
                for (int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(3339L, 0); MutateCSharp.Schemata407.ReplaceBinExprOp_12(3343L, i, ctype.TypeArgs.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(3348L, ref i))
                {
                    typeMap.Add(ctype.ResolvedClass.TypeArgs[i], ctype.TypeArgs[i]);
                }
                var typeThatEnclosesMember = ctype.AsParentType(member.EnclosingClass);
                e.TypeApplication_AtEnclosingClass = new List<Type>();
                for (int i = MutateCSharp.Schemata407.ReplaceNumericConstant_6(3349L, 0); MutateCSharp.Schemata407.ReplaceBinExprOp_12(3353L, i, typeThatEnclosesMember.TypeArgs.Count); MutateCSharp.Schemata407.ReplacePostfixUnaryExprOp_13(3358L, ref i))
                {
                    e.TypeApplication_AtEnclosingClass.Add(typeThatEnclosesMember.TypeArgs[i]);
                }
                e.TypeApplication_JustFunction = new List<Type>();
                foreach (TypeParameter p in function.TypeArgs)
                {
                    var ty = new ParamTypeProxy(p);
                    typeMap.Add(p, ty);
                    e.TypeApplication_JustFunction.Add(ty);
                }
                Dictionary<TypeParameter, Type> subst = BuildTypeArgumentSubstitute(typeMap);

                // type check the arguments
                ResolveActualParameters(e.Bindings, function.Ins, e.tok, function, resolutionContext, subst, function.IsStatic ? null : e.Receiver);

                e.Type = function.ResultType.Subst(subst).NormalizeExpand();
            }
        }

        void ResolveReceiver(Expression expr, ResolutionContext resolutionContext)
        {
            Contract.Requires(expr != null);
            Contract.Ensures(expr.Type != null);

            if (MutateCSharp.Schemata407.ReplaceBinExprOp_9(3359L, () => expr is ThisExpr, () => !expr.WasResolved()))
            {
                // Allow 'this' here, regardless of scope.AllowInstance.  The caller is responsible for
                // making sure 'this' does not really get used when it's not available.
                Contract.Assume(currentClass != null);  // this is really a precondition, in this case
                expr.Type = GetThisType(expr.tok, currentClass);
            }
            else
            {
                ResolveExpression(expr, resolutionContext);
            }
        }

        void ResolveSeqSelectExpr(SeqSelectExpr e, ResolutionContext resolutionContext)
        {
            Contract.Requires(e != null);
            if (MutateCSharp.Schemata407.ReplaceBinExprOp_14(3365L, e.Type, null))
            {
                // already resolved
                return;
            }

            ResolveExpression(e.Seq, resolutionContext);
            Contract.Assert(e.Seq.Type != null);  // follows from postcondition of ResolveExpression

            if (e.SelectOne)
            {
                AddXConstraint(e.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3366L, "Indexable"), e.Seq.Type, MutateCSharp.Schemata407.ReplaceStringConstant_1(3367L, "element selection requires a sequence, array, multiset, or map (got {0})"));
                ResolveExpression(e.E0, resolutionContext);
                AddXConstraint(e.E0.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3368L, "ContainerIndex"), e.Seq.Type, e.E0.Type, MutateCSharp.Schemata407.ReplaceStringConstant_1(3369L, "incorrect type for selection into {0} (got {1})"));
                Contract.Assert(e.E1 == null);
                e.Type = new InferredTypeProxy() { KeepConstraints = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3370L, true) };
                AddXConstraint(e.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3371L, "ContainerResult"),
                  e.Seq.Type, e.Type,
                  new SeqSelectOneErrorMsg(e.tok, e.Seq.Type, e.Type));
            }
            else
            {
                AddXConstraint(e.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3372L, "MultiIndexable"), e.Seq.Type, MutateCSharp.Schemata407.ReplaceStringConstant_1(3373L, "multi-selection of elements requires a sequence or array (got {0})"));
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_4(3374L, e.E0, null))
                {
                    ResolveExpression(e.E0, resolutionContext);
                    AddXConstraint(e.E0.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3375L, "ContainerIndex"), e.Seq.Type, e.E0.Type, MutateCSharp.Schemata407.ReplaceStringConstant_1(3376L, "incorrect type for selection into {0} (got {1})"));
                    ConstrainSubtypeRelation(NewIntegerBasedProxy(e.tok), e.E0.Type, e.E0, MutateCSharp.Schemata407.ReplaceStringConstant_1(3377L, "wrong number of indices for multi-selection"));
                }
                if (MutateCSharp.Schemata407.ReplaceBinExprOp_4(3378L, e.E1, null))
                {
                    ResolveExpression(e.E1, resolutionContext);
                    AddXConstraint(e.E1.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3379L, "ContainerIndex"), e.Seq.Type, e.E1.Type, MutateCSharp.Schemata407.ReplaceStringConstant_1(3380L, "incorrect type for selection into {0} (got {1})"));
                    ConstrainSubtypeRelation(NewIntegerBasedProxy(e.tok), e.E1.Type, e.E1, MutateCSharp.Schemata407.ReplaceStringConstant_1(3381L, "wrong number of indices for multi-selection"));
                }
                var resultType = new InferredTypeProxy() { KeepConstraints = MutateCSharp.Schemata407.ReplaceBooleanConstant_3(3382L, true) };
                e.Type = new SeqType(resultType);
                AddXConstraint(e.tok, MutateCSharp.Schemata407.ReplaceStringConstant_1(3383L, "ContainerResult"), e.Seq.Type, resultType, MutateCSharp.Schemata407.ReplaceStringConstant_1(3384L, "multi-selection has type {0} which is incompatible with expected type {1}"));
            }
        }

    }

    public record MethodCallInformation(IToken Tok, MemberSelectExpr Callee, List<ActualBinding> ActualParameters);
}
