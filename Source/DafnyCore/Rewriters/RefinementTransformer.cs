//-----------------------------------------------------------------------------
//
// Copyright (C) Microsoft Corporation.  All Rights Reserved.
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------
// This file contains the transformations that are applied to a module that is
// constructed as a refinement of another.  It is invoked during program resolution,
// so the transformation is done syntactically.  Upon return from the RefinementTransformer,
// the caller is expected to resolve the resulting module.
//
// As for now (and perhaps this is always the right thing to do), attributes do
// not survive the transformation.
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Diagnostics.Contracts;
using System.Linq;
using Microsoft.Dafny.Plugins;
using static Microsoft.Dafny.RefinementErrors;
namespace MutateCSharp
{
    internal class Schemata462
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT462");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_34(long mutantId, Microsoft.Dafny.TypeParameter.TPVariance argument1, Microsoft.Dafny.TypeParameter.TPVariance argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_53(long mutantId, Microsoft.Dafny.VarDeclStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBinExprOp_59(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_28(long mutantId, Microsoft.Dafny.ConstantField argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_45(long mutantId, Microsoft.Dafny.ConcreteUpdateStatement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_44(long mutantId, Microsoft.Dafny.UpdateStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_7(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_38(long mutantId, Microsoft.Dafny.PredicateStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_40(long mutantId, Microsoft.Dafny.AssumeStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_25(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_33(long mutantId, Microsoft.Dafny.TypeParameter.TPVariance argument1, Microsoft.Dafny.TypeParameter.TPVariance argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_27(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_19(long mutantId, Microsoft.Dafny.Formal argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.ModuleDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceBinExprOp_36(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.ImplementationKind argument1, Microsoft.Dafny.ImplementationKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_31(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceNumericConstant_14(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_50(long mutantId, Microsoft.Dafny.WhileStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_58(long mutantId, Microsoft.Dafny.Predicate.BodyOriginKind argument1, Microsoft.Dafny.Predicate.BodyOriginKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static bool ReplaceBinExprOp_43(long mutantId, Microsoft.Dafny.ModifyStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_32(long mutantId, Microsoft.Dafny.TypeParameter.EqualitySupportValue argument1, Microsoft.Dafny.TypeParameter.EqualitySupportValue argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_57(long mutantId, Microsoft.Dafny.Predicate argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_3(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.RefinementToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_56(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_29(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_54(long mutantId, Microsoft.Dafny.LList<Microsoft.Dafny.Label> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_23(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_41(long mutantId, Microsoft.Dafny.IfStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_37(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_12(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_49(long mutantId, Microsoft.Dafny.IfStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_30(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.BoundVar argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_52(long mutantId, Microsoft.Dafny.LList<Microsoft.Dafny.Label> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_26(long mutantId, Microsoft.Dafny.ConstantField argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_48(long mutantId, Microsoft.Dafny.IdentifierExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.RefinementToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_46(long mutantId, Microsoft.Dafny.AssignStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_55(long mutantId, Microsoft.Dafny.AssignSuchThatStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_51(long mutantId, Microsoft.Dafny.NameSegment argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_24(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.ModuleKindEnum argument1, Microsoft.Dafny.ModuleKindEnum argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, Microsoft.Dafny.ModuleDefinition argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, Microsoft.Dafny.ModuleDefinition argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_47(long mutantId, Microsoft.Dafny.AssignStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.AttributedExpression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_39(long mutantId, Microsoft.Dafny.ExpectStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_35(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_42(long mutantId, Microsoft.Dafny.WhileStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class RefinementToken : TokenWrapper
    {
        public readonly ModuleDefinition InheritingModule;

        public RefinementToken(IToken tok, ModuleDefinition m)
          : base(tok)
        {
            Contract.Requires(tok != null);
            Contract.Requires(m != null);
            this.InheritingModule = m;
        }

        public override string ToString()
        {
            return $"refinement of {WrappedToken} by {InheritingModule.Name}";
        }

        public override IToken WithVal(string newVal)
        {
            return new RefinementToken(WrappedToken.WithVal(newVal), InheritingModule);
        }

        public static bool IsInherited(IToken tok, ModuleDefinition m)
        {
            if (tok is AutoGeneratedToken agt)
            {
                tok = agt.WrappedToken;
            }
            while (tok is NestedToken)
            {
                var n = (NestedToken)tok;
                // check Outer
                var r = n.Outer as RefinementToken;
                if (MutateCSharp.Schemata462.ReplaceBinExprOp_2(3L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_0(1L, r, null), () => MutateCSharp.Schemata462.ReplaceBinExprOp_1(2L, r.InheritingModule, m)))
                {
                    return MutateCSharp.Schemata462.ReplaceBooleanConstant_3(9L, false);
                }

                // continue to check Inner
                tok = n.Inner;
                if (tok is AutoGeneratedToken nestedAtg)
                {
                    tok = nestedAtg.WrappedToken;
                }
            }

            var rtok = tok as RefinementToken;
            return MutateCSharp.Schemata462.ReplaceBinExprOp_6(12L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_4(10L, rtok, null), () => MutateCSharp.Schemata462.ReplaceBinExprOp_5(11L, rtok.InheritingModule, m));
        }

        public override string Filepath => WrappedToken.Filepath + MutateCSharp.Schemata462.ReplaceStringConstant_7(18L, "[") + InheritingModule.Name + MutateCSharp.Schemata462.ReplaceStringConstant_7(19L, "]");
    }

    /// <summary>
    /// The "RefinementTransformer" is responsible for transforming a refining module (that is,
    /// a module defined as "module Y refines X") according to the body of this module and
    /// the module used as a starting point for the refinement (here, "X"). In a nutshell,
    /// there are four kinds of transformations.
    /// 
    ///   0. "Y" can fill in some definitions that "X" omitted. For example, if "X" defines
    ///      an abstract type "type T", then "Y" can define "T" to be a particular type, like
    ///      "type T = int". As another example, if "X" omits the body of a function, then
    ///      "Y" can give it a body.
    /// 
    ///   1. "Y" can add definitions. For example, it can declare new types and it can add
    ///      members to existing types.
    ///  
    ///   2. "Y" can superimpose statements on an existing method body. The format for this
    ///      is something that confuses most people. One reason for the common confusion is
    ///      that in many other language situations, it's the original ("X") that says what
    ///      parts can be replaced. Here, it the refining module ("Y") that decides where to
    ///      "squeeze in" new statements. For example, if a method body in "X" is
    /// 
    ///          var i := 0;
    ///          while i != 10 {
    ///            i := i + 1;
    ///          }
    /// 
    ///      then the refining module can write
    ///
    ///          var j := 0;
    ///          ...;
    ///          while ...
    ///            invariant j == 2 * i
    ///          {
    ///            j := j + 2;
    ///          }
    ///
    ///      Note, the two occurrences of "..." above are concrete syntax in Dafny.
    ///
    ///      In the RefinementTransformer methods below, the former usually goes by some name like
    ///      "oldStmt", whereas the latter has some name like "skeleton". (Again, this can be confusing,
    ///      because a "skeleton" (or "template") is something you *add* things to, whereas here it is
    ///      description for *how* to add something to the "oldStmt".)
    ///
    ///      The result of combining the "oldStmt" and the "skeleton" is called the "Merge" of
    ///      the two. For the example above, the merge is:
    /// 
    ///          var j := 0;
    ///          var i := 0;
    ///          while i != 10
    ///            invariant j == 2 * i
    ///          {
    ///            j := j + 2;
    ///            i := i + 1;
    ///          }
    ///
    ///      The IDE adds hover text that shows what each "...;" or "}" in the "skeleton" expands
    ///      to.
    ///
    ///      Roughly speaking, the new program text that is being superimposed on the old is
    ///      allowed to add local variables and assignments to those (like "j" in the example above).
    ///      It is also allowed to add some forms of assertions (like the "invariant" in the
    ///      example). It cannot add statements that change the control flow, except that it
    ///      is allowed to add "return;" statements. Finally, in addition to these superimpositions,
    ///      there's a small number of refinement changes it can make. For example, it can reduce
    ///      nondeterminism in certain ways; e.g., it can change a statement "r :| 0 <= r <= 100;"
    ///      into "r := 38;". As another example of a refinement, it change change an "assume"
    ///      into an "assert" (by writing "assert ...;").
    ///
    ///      The rules about what kinds of superimpositions the language can allow has as its
    ///      guiding principle the idea that the verifier should not need to reverify anything that
    ///      was already verified in module "X". In some special cases, a superimposition needs
    ///      some condition to be verified (for example, an added "return;" statement causes the
    ///      postcondition to be reverified, but only at the point of the "return;"), so the verifier
    ///      adds the necessary additional checks.
    ///  
    ///   3. Some modifiers and other decorations may be changed. For example, a "ghost var"
    ///      field can be changed to a "var" field, and vice versa. It may seem odd that a
    ///      refinement is allowed to change these (and in either direction!), but it's fine
    ///      as long as it doesn't affect what the verifier does. The entire merged module is
    ///      passed through Resolution, which catches any errors that these small changes
    ///      may bring about. For example, it will give an error for an assignment "a := b;"
    ///      if "a" and "b" were both compiled variables in "X" and "b" has been changed to be
    ///      a ghost variable in "Y".
    ///
    /// For more information about the refinement features in Dafny, see
    ///
    ///      "Programming Language Features for Refinement"
    ///      Jason Koenig and K. Rustan M. Leino.
    ///      In EPTCS, 2016. (Post-workshop proceedings of REFINE 2015.) 
    /// </summary>
    public class RefinementTransformer : IRewriter
    {
        RefinementCloner refinementCloner; // This cloner wraps things in a RefinementToken

        public RefinementTransformer(ErrorReporter reporter)
          : base(reporter)
        {
        }

        public RefinementTransformer(Program p)
          : this(p.Reporter)
        {
        }

        private void Error(ErrorId errorId, IToken tok, string msg, params object[] args)
        {
            Reporter.Error(MessageSource.RefinementTransformer, errorId, tok, msg, args);
        }

        private void Error(ErrorId errorId, Declaration d, string msg, params object[] args)
        {
            Reporter.Error(MessageSource.RefinementTransformer, errorId, d.Tok, msg, args);
        }

        private void Error(ErrorId errorId, INode n, string msg, params object[] args)
        {
            Reporter.Error(MessageSource.RefinementTransformer, errorId, n.Tok, msg, args);
        }

        private ModuleDefinition moduleUnderConstruction;  // non-null for the duration of Construct calls
        private Queue<Action> postTasks = new Queue<Action>();  // empty whenever moduleUnderConstruction==null, these tasks are for the post-resolve phase of module moduleUnderConstruction
        public Queue<Tuple<Method, Method>> translationMethodChecks = new Queue<Tuple<Method, Method>>();  // contains all the methods that need to be checked for structural refinement.
        private Method currentMethod;
        private ModuleSignature RefinedSig;  // the intention is to use this field only after a successful PreResolve
        private ModuleSignature refinedSigOpened;

        internal override void PreResolve(ModuleDefinition m)
        {

            if (MutateCSharp.Schemata462.ReplaceBinExprOp_8(20L, m.Implements?.Target.Decl, null))
            {
                // do this also for non-refining modules
                CheckSuperfluousRefiningMarks(m.TopLevelDecls, new List<string>());
                AddDefaultBaseTypeToUnresolvedNewtypes(m.TopLevelDecls);
            }
            else
            {
                // There is a refinement parent and it resolved OK
                var refinementTarget = m.Implements.Target;
                if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(23L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_9(21L, m.Implements.Kind, ImplementationKind.Refinement), () => MutateCSharp.Schemata462.ReplaceBinExprOp_10(22L, refinementTarget.Def.ModuleKind, ModuleKindEnum.Replaceable)))
                {
                    Reporter.Error(MessageSource.RefinementTransformer, MutateCSharp.Schemata462.ReplaceStringConstant_7(29L, "refineReplaceable"), refinementTarget.Tok,
          MutateCSharp.Schemata462.ReplaceStringConstant_7(30L, "replaceable module cannot be refined"));

                    return;
                }
                RefinedSig = refinementTarget.Sig;
                Contract.Assert(RefinedSig.ModuleDef != null);
                Contract.Assert(refinementTarget.Def == RefinedSig.ModuleDef);

                // check that the openness in the imports between refinement and its base matches
                Dictionary<string, TopLevelDecl> refinedModuleTopLevelDecls = new();
                foreach (var baseDecl in refinementTarget.Def.TopLevelDecls)
                {
                    refinedModuleTopLevelDecls.Add(baseDecl.Name, baseDecl);
                }
                var declarations = m.TopLevelDecls;
                foreach (var mdecl in declarations.OfType<ModuleDecl>())
                {
                    if (refinedModuleTopLevelDecls.TryGetValue(mdecl.Name, out var baseDecl))
                    {
                        if (baseDecl is ModuleDecl baseModuleDecl)
                        {
                            if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(31L, () => mdecl.Opened, () => !baseModuleDecl.Opened))
                            {
                                Error(ErrorId.ref_refinement_import_must_match_opened_base, m.tok,
                MutateCSharp.Schemata462.ReplaceStringConstant_7(37L, "{0} in {1} cannot be imported with \"opened\" because it does not match the corresponding import in the refinement base {2}."),
                                  mdecl.Name, m.Name, m.Implements.Target.ToString());
                            }
                            else if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(38L, () => !mdecl.Opened, () => baseModuleDecl.Opened))
                            {
                                Error(ErrorId.ref_refinement_import_must_match_non_opened_base, m.tok,
                MutateCSharp.Schemata462.ReplaceStringConstant_7(44L, "{0} in {1} must be imported with \"opened\"  to match the corresponding import in its refinement base {2}."),
                                  mdecl.Name, m.Name, m.Implements.Target.ToString());
                            }
                        }
                    }
                }

                PreResolveWorker(m);
            }
        }

        void PreResolveWorker(ModuleDefinition module)
        {
            Contract.Requires(module != null);

            if (MutateCSharp.Schemata462.ReplaceBinExprOp_11(45L, moduleUnderConstruction, null))
            {
                postTasks.Clear();
            }
            moduleUnderConstruction = module;
            refinementCloner = new RefinementCloner(moduleUnderConstruction);
            var refinementTarget = module.Implements.Target;
            var prev = refinementTarget.Def;

            //copy the signature, including its opened imports
            refinedSigOpened = ModuleResolver.MergeSignature(new ModuleSignature(), RefinedSig);
            ModuleResolver.ResolveOpenedImports(refinedSigOpened, prev, Reporter, null);

            // Create a simple name-to-decl dictionary.  Ignore any duplicates at this time.
            var declaredNames = new Dictionary<string, IPointer<TopLevelDecl>>();
            var pointers = module.TopLevelDeclPointers;
            foreach (var pointer in pointers)
            {
                var key = pointer.Get().Name;
                declaredNames.TryAdd(key, pointer);
            }

            // Merge the declarations of prev into the declarations of m
            List<string> processedDecl = new List<string>();
            foreach (var originalDeclaration in prev.TopLevelDecls)
            {
                processedDecl.Add(originalDeclaration.Name);
                if (!declaredNames.TryGetValue(originalDeclaration.Name, out var newPointer))
                {
                    var clone = refinementCloner.CloneDeclaration(originalDeclaration, module);
                    module.SourceDecls.Add(clone);
                }
                else
                {
                    var newDeclaration = newPointer.Get();
                    if (MutateCSharp.Schemata462.ReplaceBinExprOp_2(54L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_2(48L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_12(47L, originalDeclaration.Name, MutateCSharp.Schemata462.ReplaceStringConstant_7(46L, "_default")), () => newDeclaration.IsRefining), () => originalDeclaration is AbstractTypeDecl))
                    {
                        MergeTopLevelDecls(module, newPointer, originalDeclaration);
                    }
                    else if (newDeclaration is TypeSynonymDecl)
                    {
                        var msg = $"a type synonym ({newDeclaration.Name}) is not allowed to replace a {originalDeclaration.WhatKind} from the refined module ({module.Implements.Target}), even if it denotes the same type";
                        Error(ErrorId.ref_refinement_type_must_match_base, newDeclaration.tok, msg);
                    }
                    else if (!(originalDeclaration is AbstractModuleDecl))
                    {
                        Error(ErrorId.ref_refining_notation_needed, newDeclaration.tok, $"to redeclare and refine declaration '{originalDeclaration.Name}' from module '{module.Implements.Target}', you must use the refining (`...`) notation");
                    }
                }
            }
            CheckSuperfluousRefiningMarks(module.TopLevelDecls, processedDecl);
            AddDefaultBaseTypeToUnresolvedNewtypes(module.TopLevelDecls);

            // Merge the imports of prev
            var prevTopLevelDecls = RefinedSig.TopLevels.Values;
            foreach (var d in prevTopLevelDecls)
            {
                if (!processedDecl.Contains(d.Name) && declaredNames.TryGetValue(d.Name, out var pointer))
                {
                    // if it is redefined, we need to merge them.
                    MergeTopLevelDecls(module, pointer, d);
                }
            }
            refinementTarget.Sig = RefinedSig;

            Contract.Assert(moduleUnderConstruction == module);  // this should be as it was set earlier in this method
        }

        private void CheckSuperfluousRefiningMarks(IEnumerable<TopLevelDecl> topLevelDecls, List<string> excludeList)
        {
            Contract.Requires(topLevelDecls != null);
            Contract.Requires(excludeList != null);
            foreach (var d in topLevelDecls)
            {
                if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(60L, () => d.IsRefining, () => !excludeList.Contains(d.Name)))
                {
                    Error(ErrorId.ref_refining_notation_does_not_refine, d.tok, $"declaration '{d.Name}' indicates refining (notation `...`), but does not refine anything");
                }
            }
        }

        /// <summary>
        /// Give unresolved newtypes a reasonable default type (<c>int</c>), to avoid having to support `null` in the
        /// rest of the resolution pipeline.
        /// </summary>
        private void AddDefaultBaseTypeToUnresolvedNewtypes(IEnumerable<TopLevelDecl> topLevelDecls)
        {
            foreach (var d in topLevelDecls)
            {
                if (d is NewtypeDecl { IsRefining: true, BaseType: null } decl)
                {
                    Reporter.Info(MessageSource.RefinementTransformer, decl.tok, $"defaulting to 'int' for unspecified base type of '{decl.Name}'");
                    decl.BaseType = new IntType(); // Set `BaseType` to some reasonable default to allow resolution to proceed
                }
            }
        }

        private void MergeModuleExports(ModuleExportDecl nw, ModuleExportDecl d)
        {
            if (MutateCSharp.Schemata462.ReplaceBinExprOp_13(66L, () => nw.IsDefault, () => d.IsDefault))
            {
                Error(ErrorId.ref_default_export_unchangeable, nw, MutateCSharp.Schemata462.ReplaceStringConstant_7(72L, "can't change if a module export is default ({0})"), nw.Name);
            }

            nw.Exports.AddRange(d.Exports);
            nw.Extends.AddRange(d.Extends);
        }

        private void MergeTopLevelDecls(ModuleDefinition m, IPointer<TopLevelDecl> nwPointer, TopLevelDecl d)
        {
            var nw = nwPointer.Get();
            var commonMsg = MutateCSharp.Schemata462.ReplaceStringConstant_7(73L, "a {0} declaration ({1}) in a refinement module can only refine a {0} declaration or replace an abstract type declaration");
            // Prefix decls.

            if (d is ModuleDecl)
            {
                if (!(nw is ModuleDecl))
                {
                    Error(ErrorId.ref_module_must_refine_module, nw, MutateCSharp.Schemata462.ReplaceStringConstant_7(74L, "a module ({0}) must refine another module"), nw.Name);
                }
                else if (d is ModuleExportDecl)
                {
                    if (!(nw is ModuleExportDecl))
                    {
                        Error(ErrorId.ref_export_must_refine_export, nw, MutateCSharp.Schemata462.ReplaceStringConstant_7(75L, "a module export ({0}) must refine another export"), nw.Name);
                    }
                    else
                    {
                        MergeModuleExports((ModuleExportDecl)nw, (ModuleExportDecl)d);
                    }
                }
                else if (!(d is AbstractModuleDecl))
                {
                    Error(ErrorId.ref_base_module_must_be_facade, nw, MutateCSharp.Schemata462.ReplaceStringConstant_7(76L, "a module ({0}) can only refine a module facade"), nw.Name);
                }
                else
                {
                    // check that the new module refines the previous declaration
                    if (!CheckIsRefinement((ModuleDecl)nw, (AbstractModuleDecl)d))
                    {
                        Error(ErrorId.ref_module_must_refine_module_2, nw.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(77L, "a module ({0}) can only be replaced by a refinement of the original module"), d.Name);
                    }
                }
            }
            else if (d is AbstractTypeDecl)
            {
                if (nw is ModuleDecl)
                {
                    Error(ErrorId.ref_module_must_refine_module_2, nw, MutateCSharp.Schemata462.ReplaceStringConstant_7(78L, "a module ({0}) must refine another module"), nw.Name);
                }
                else
                {
                    var od = (AbstractTypeDecl)d;
                    postTasks.Enqueue(() =>
                    {
                        // check that od's type characteristics are respected by nw's
                        var newType = UserDefinedType.FromTopLevelDecl(nw.tok,
                          nw is ClassLikeDecl { NonNullTypeDecl: { } nonNullTypeDecl } ? nonNullTypeDecl : nw);
                        if (!CheckTypeCharacteristics_Visitor.CheckCharacteristics(od.Characteristics, newType, false, out var whatIsNeeded, out var hint, out var errorId))
                        {
                            var typeCharacteristicsSyntax = od.Characteristics.ToString();
                            Error(errorId, nw.tok,
                              $"to be a refinement of {od.WhatKind} '{od.EnclosingModuleDefinition.Name}.{od.Name}' declared with {typeCharacteristicsSyntax}, " +
                              $"{nw.WhatKind} '{m.Name}.{nw.Name}' must {whatIsNeeded}{hint}");
                        }
                    });

                    if (nw is TopLevelDeclWithMembers)
                    {
                        nwPointer.Set(MergeClass((TopLevelDeclWithMembers)nw, od));
                    }
                    else if (MutateCSharp.Schemata462.ReplaceBinExprOp_15(83L, od.Members.Count, MutateCSharp.Schemata462.ReplaceNumericConstant_14(79L, 0)))
                    {
                        Error(ErrorId.ref_mismatched_type_with_members, nw,
            MutateCSharp.Schemata462.ReplaceStringConstant_7(88L, "a {0} ({1}) cannot declare members, so it cannot refine an abstract type with members"),
                          nw.WhatKind, nw.Name);
                    }
                    else
                    {
                        CheckAgreement_TypeParameters(nw.tok, d.TypeArgs, nw.TypeArgs, nw.Name, MutateCSharp.Schemata462.ReplaceStringConstant_7(89L, "type"), MutateCSharp.Schemata462.ReplaceBooleanConstant_3(90L, false));
                    }
                }
            }
            else if (nw is AbstractTypeDecl)
            {
                Error(ErrorId.ref_mismatched_abstractness, nw,
        MutateCSharp.Schemata462.ReplaceStringConstant_7(91L, "an abstract type declaration ({0}) in a refining module cannot replace a more specific type declaration in the refinement base"), nw.Name);
            }
            else if (MutateCSharp.Schemata462.ReplaceBinExprOp_2(104L, () => (MutateCSharp.Schemata462.ReplaceBinExprOp_6(92L, () => d is IndDatatypeDecl, () => nw is IndDatatypeDecl)), () => (MutateCSharp.Schemata462.ReplaceBinExprOp_6(98L, () => d is CoDatatypeDecl, () => nw is CoDatatypeDecl))))
            {
                var (dd, nwd) = ((DatatypeDecl)d, (DatatypeDecl)nw);
                Contract.Assert(!nwd.Ctors.Any());
                nwd.Ctors.AddRange(dd.Ctors.Select(refinementCloner.CloneCtor));
                nwPointer.Set(MergeClass((DatatypeDecl)nw, (DatatypeDecl)d));
            }
            else if (nw is DatatypeDecl)
            {
                Error(ErrorId.ref_declaration_must_refine, nw, commonMsg, nw.WhatKind, nw.Name);
            }
            else if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(110L, () => d is NewtypeDecl, () => nw is NewtypeDecl))
            {
                var (dn, nwn) = ((NewtypeDecl)d, (NewtypeDecl)nw);
                Contract.Assert(nwn.BaseType == null && nwn.Var == null &&
                                nwn.Constraint == null && nwn.Witness == null);
                nwn.Var = MutateCSharp.Schemata462.ReplaceBinExprOp_16(116L, dn.Var, null) ? null : refinementCloner.CloneBoundVar(dn.Var, MutateCSharp.Schemata462.ReplaceBooleanConstant_3(117L, false));
                nwn.BaseType = nwn.Var?.Type ?? refinementCloner.CloneType(dn.BaseType); // Preserve newtype invariant that Var.Type is BaseType
                nwn.Constraint = MutateCSharp.Schemata462.ReplaceBinExprOp_17(118L, dn.Constraint, null) ? null : refinementCloner.CloneExpr(dn.Constraint);
                nwn.WitnessKind = dn.WitnessKind;
                nwn.Witness = MutateCSharp.Schemata462.ReplaceBinExprOp_17(119L, dn.Witness, null) ? null : refinementCloner.CloneExpr(dn.Witness);
                nwPointer.Set(MergeClass((NewtypeDecl)nw, (NewtypeDecl)d));
            }
            else if (nw is NewtypeDecl)
            {
                // `.Basetype` will be set in AddDefaultBaseTypeToUnresolvedNewtypes
                Error(ErrorId.ref_declaration_must_refine, nw, commonMsg, nw.WhatKind, nw.Name);
            }
            else if (nw is IteratorDecl)
            {
                if (d is IteratorDecl)
                {
                    nwPointer.Set(MergeIterator((IteratorDecl)nw, (IteratorDecl)d));
                }
                else
                {
                    Error(ErrorId.ref_iterator_must_refine_iterator, nw, MutateCSharp.Schemata462.ReplaceStringConstant_7(120L, "an iterator declaration ({0}) in a refining module cannot replace a different kind of declaration in the refinement base"), nw.Name);
                }
            }
            else if (nw is TraitDecl)
            {
                if (d is TraitDecl)
                {
                    nwPointer.Set(MergeClass((TraitDecl)nw, (TraitDecl)d));
                }
                else
                {
                    Error(ErrorId.ref_declaration_must_refine, nw, commonMsg, nw.WhatKind, nw.Name);
                }
            }
            else if (nw is ClassDecl)
            {
                if (d is ClassDecl)
                {
                    nwPointer.Set(MergeClass((ClassDecl)nw, (ClassDecl)d));
                }
                else
                {
                    Error(ErrorId.ref_declaration_must_refine, nw, commonMsg, nw.WhatKind, nw.Name);
                }
            }
            else if (nw is DefaultClassDecl)
            {
                if (d is DefaultClassDecl)
                {
                    nwPointer.Set((DefaultClassDecl)MergeClass((DefaultClassDecl)nw, (DefaultClassDecl)d));
                }
                else
                {
                    Error(ErrorId.ref_declaration_must_refine, nw, commonMsg, nw.WhatKind, nw.Name);
                }
            }
            else if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(135L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_6(128L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_6(121L, () => nw is TypeSynonymDecl, () => d is TypeSynonymDecl), () => MutateCSharp.Schemata462.ReplaceBinExprOp_18(127L, ((TypeSynonymDecl)nw).Rhs, null)), () => MutateCSharp.Schemata462.ReplaceBinExprOp_18(134L, ((TypeSynonymDecl)d).Rhs, null)))
            {
                Error(ErrorId.ref_base_type_cannot_be_refined, d,
        MutateCSharp.Schemata462.ReplaceStringConstant_7(141L, "a type ({0}) in a refining module may not replace an already defined type (even with the same value)"),
                  d.Name);
            }
            else
            {
                Contract.Assert(false);
            }
        }

        public bool CheckIsRefinement(ModuleDecl derived, AbstractModuleDecl original)
        {
            // Check explicit refinement
            // TODO syntactic analysis of export sets is not quite right
            var derivedPointer = derived.Signature.ModuleDef;
            while (MutateCSharp.Schemata462.ReplaceBinExprOp_11(142L, derivedPointer, null))
            {
                if (MutateCSharp.Schemata462.ReplaceBinExprOp_5(143L, derivedPointer, original.OriginalSignature.ModuleDef))
                {
                    HashSet<string> exports;
                    if (derived is AliasModuleDecl)
                    {
                        exports = new HashSet<string>(((AliasModuleDecl)derived).Exports.ConvertAll(t => t.val));
                    }
                    else if (derived is AbstractModuleDecl)
                    {
                        exports = new HashSet<string>(((AbstractModuleDecl)derived).Exports.ConvertAll(t => t.val));
                    }
                    else
                    {
                        Error(ErrorId.ref_base_module_must_be_abstract_or_alias, derived, MutateCSharp.Schemata462.ReplaceStringConstant_7(144L, "a module ({0}) can only be refined by an alias module or a module facade"), original.Name);
                        return MutateCSharp.Schemata462.ReplaceBooleanConstant_3(145L, false);
                    }
                    var oexports = new HashSet<string>(original.Exports.ConvertAll(t => t.val));
                    return oexports.IsSubsetOf(exports);
                }
                derivedPointer = derivedPointer.Implements.Target.Def;
            }
            return MutateCSharp.Schemata462.ReplaceBooleanConstant_3(146L, false);
        }

        internal override void PostResolveIntermediate(ModuleDefinition m)
        {
            if (MutateCSharp.Schemata462.ReplaceBinExprOp_5(147L, m, moduleUnderConstruction))
            {
                while (MutateCSharp.Schemata462.ReplaceBinExprOp_15(152L, this.postTasks.Count, MutateCSharp.Schemata462.ReplaceNumericConstant_14(148L, 0)))
                {
                    var a = postTasks.Dequeue();
                    a();
                }
            }
            else
            {
                postTasks.Clear();
            }
            moduleUnderConstruction = null;
        }

        Function CloneFunction(Function newFunction, Function previousFunction, Expression moreBody, Expression replacementBody, bool checkPrevPostconditions, Attributes moreAttributes)
        {
            Contract.Requires(moreBody == null || previousFunction is Predicate);
            Contract.Requires(moreBody == null || replacementBody == null);

            var tps = previousFunction.TypeArgs.ConvertAll(refinementCloner.CloneTypeParam);
            var formals = previousFunction.Ins.ConvertAll(p => refinementCloner.CloneFormal(p, MutateCSharp.Schemata462.ReplaceBooleanConstant_3(157L, false)));
            var req = previousFunction.Req.ConvertAll(refinementCloner.CloneAttributedExpr);
            var reads = refinementCloner.CloneSpecFrameExpr(previousFunction.Reads);
            var decreases = refinementCloner.CloneSpecExpr(previousFunction.Decreases);
            var result = previousFunction.Result ?? newFunction.Result;
            if (MutateCSharp.Schemata462.ReplaceBinExprOp_19(158L, result, null))
            {
                result = refinementCloner.CloneFormal(result, MutateCSharp.Schemata462.ReplaceBooleanConstant_3(159L, false));
            }

            var ens = refinementCloner.WithRefinementTokenWrapping(
              () => previousFunction.Ens.ConvertAll(refinementCloner.CloneAttributedExpr),
              !checkPrevPostconditions); // note, if a postcondition includes something that changes in the module, the translator will notice this and still re-check the postcondition

            if (MutateCSharp.Schemata462.ReplaceBinExprOp_20(160L, newFunction.Ens, null))
            {
                ens.AddRange(newFunction.Ens);
            }

            Expression body;
            Predicate.BodyOriginKind bodyOrigin;
            if (MutateCSharp.Schemata462.ReplaceBinExprOp_21(161L, replacementBody, null))
            {
                body = replacementBody;
                bodyOrigin = Predicate.BodyOriginKind.DelayedDefinition;
            }
            else if (MutateCSharp.Schemata462.ReplaceBinExprOp_21(162L, moreBody, null))
            {
                if (MutateCSharp.Schemata462.ReplaceBinExprOp_17(163L, previousFunction.Body, null))
                {
                    body = moreBody;
                    bodyOrigin = Predicate.BodyOriginKind.DelayedDefinition;
                }
                else
                {
                    body = new BinaryExpr(previousFunction.tok, BinaryExpr.Opcode.And, refinementCloner.CloneExpr(previousFunction.Body), moreBody);
                    bodyOrigin = Predicate.BodyOriginKind.Extension;
                }
            }
            else
            {
                body = refinementCloner.CloneExpr(previousFunction.Body);
                bodyOrigin = Predicate.BodyOriginKind.OriginalOrInherited;
            }
            var byMethodBody = refinementCloner.CloneBlockStmt(previousFunction.ByMethodBody);

            var range = newFunction.RangeToken;
            var nameNode = newFunction.NameNode;

            if (previousFunction is Predicate)
            {
                return new Predicate(range, nameNode, previousFunction.HasStaticKeyword, newFunction.IsGhost, previousFunction.IsOpaque, tps, formals, result,
                  req, reads, ens, decreases, body, bodyOrigin,
        MutateCSharp.Schemata462.ReplaceBinExprOp_22(164L, previousFunction.ByMethodTok, null) ? null : refinementCloner.Tok(previousFunction.ByMethodTok), byMethodBody,
                  refinementCloner.MergeAttributes(previousFunction.Attributes, moreAttributes), null);
            }
            else if (previousFunction is LeastPredicate)
            {
                return new LeastPredicate(range, nameNode, previousFunction.HasStaticKeyword, previousFunction.IsOpaque, ((LeastPredicate)previousFunction).TypeOfK, tps, formals, result,
                  req, reads, ens, body, refinementCloner.MergeAttributes(previousFunction.Attributes, moreAttributes), null);
            }
            else if (previousFunction is GreatestPredicate)
            {
                return new GreatestPredicate(range, nameNode, previousFunction.HasStaticKeyword, previousFunction.IsOpaque, ((GreatestPredicate)previousFunction).TypeOfK, tps, formals, result,
                  req, reads, ens, body, refinementCloner.MergeAttributes(previousFunction.Attributes, moreAttributes), null);
            }
            else if (previousFunction is TwoStatePredicate)
            {
                return new TwoStatePredicate(range, nameNode, previousFunction.HasStaticKeyword, previousFunction.IsOpaque, tps, formals, result,
                  req, reads, ens, decreases, body, refinementCloner.MergeAttributes(previousFunction.Attributes, moreAttributes), null);
            }
            else if (previousFunction is TwoStateFunction)
            {
                return new TwoStateFunction(range, nameNode, previousFunction.HasStaticKeyword, previousFunction.IsOpaque, tps, formals, result, refinementCloner.CloneType(previousFunction.ResultType),
                  req, reads, ens, decreases, body, refinementCloner.MergeAttributes(previousFunction.Attributes, moreAttributes), null);
            }
            else
            {
                return new Function(range, nameNode, previousFunction.HasStaticKeyword, newFunction.IsGhost, previousFunction.IsOpaque, tps, formals, result, refinementCloner.CloneType(previousFunction.ResultType),
                  req, reads, ens, decreases, body,
        MutateCSharp.Schemata462.ReplaceBinExprOp_22(165L, previousFunction.ByMethodTok, null) ? null : refinementCloner.Tok(previousFunction.ByMethodTok), byMethodBody,
                  refinementCloner.MergeAttributes(previousFunction.Attributes, moreAttributes), null);
            }

            return default;
        }

        Method CloneMethod(Method previousMethod, List<AttributedExpression> moreEnsures, Specification<Expression> decreases, BlockStmt newBody, bool checkPreviousPostconditions, Attributes moreAttributes)
        {
            Contract.Requires(previousMethod != null);
            Contract.Requires(!(previousMethod is Constructor) || newBody == null || newBody is DividedBlockStmt);
            Contract.Requires(decreases != null);

            var tps = previousMethod.TypeArgs.ConvertAll(refinementCloner.CloneTypeParam);
            var ins = previousMethod.Ins.ConvertAll(p => refinementCloner.CloneFormal(p, MutateCSharp.Schemata462.ReplaceBooleanConstant_3(166L, false)));
            var req = previousMethod.Req.ConvertAll(refinementCloner.CloneAttributedExpr);
            var reads = refinementCloner.CloneSpecFrameExpr(previousMethod.Reads);
            var mod = refinementCloner.CloneSpecFrameExpr(previousMethod.Mod);

            var ens = refinementCloner.WithRefinementTokenWrapping(
              () => previousMethod.Ens.ConvertAll(refinementCloner.CloneAttributedExpr), !checkPreviousPostconditions);

            if (MutateCSharp.Schemata462.ReplaceBinExprOp_20(167L, moreEnsures, null))
            {
                ens.AddRange(moreEnsures);
            }

            if (previousMethod is Constructor)
            {
                var dividedBody = (DividedBlockStmt)newBody ?? refinementCloner.CloneDividedBlockStmt((DividedBlockStmt)previousMethod.Body);
                return new Constructor(previousMethod.RangeToken.MakeRefined(moduleUnderConstruction), previousMethod.NameNode.Clone(refinementCloner), previousMethod.IsGhost, tps, ins,
                  req, reads, mod, ens, decreases, dividedBody, refinementCloner.MergeAttributes(previousMethod.Attributes, moreAttributes), null);
            }
            var body = newBody ?? refinementCloner.CloneBlockStmt(previousMethod.Body);
            var newRange = currentMethod.RangeToken.MakeRefined(moduleUnderConstruction);
            var newName = currentMethod.NameNode.Clone(refinementCloner);
            if (previousMethod is LeastLemma)
            {
                return new LeastLemma(newRange, newName, previousMethod.HasStaticKeyword, ((LeastLemma)previousMethod).TypeOfK, tps, ins,
                  previousMethod.Outs.ConvertAll(o => refinementCloner.CloneFormal(o, MutateCSharp.Schemata462.ReplaceBooleanConstant_3(168L, false))),
                  req, reads, mod, ens, decreases, body, refinementCloner.MergeAttributes(previousMethod.Attributes, moreAttributes), null);
            }
            else if (previousMethod is GreatestLemma)
            {
                return new GreatestLemma(newRange, newName, previousMethod.HasStaticKeyword, ((GreatestLemma)previousMethod).TypeOfK, tps, ins,
                  previousMethod.Outs.ConvertAll(o => refinementCloner.CloneFormal(o, MutateCSharp.Schemata462.ReplaceBooleanConstant_3(169L, false))),
                  req, reads, mod, ens, decreases, body, refinementCloner.MergeAttributes(previousMethod.Attributes, moreAttributes), null);
            }
            else if (previousMethod is Lemma)
            {
                return new Lemma(newRange, newName, previousMethod.HasStaticKeyword, tps, ins,
                  previousMethod.Outs.ConvertAll(o => refinementCloner.CloneFormal(o, MutateCSharp.Schemata462.ReplaceBooleanConstant_3(170L, false))),
                  req, reads, mod, ens, decreases, body, refinementCloner.MergeAttributes(previousMethod.Attributes, moreAttributes), null);
            }
            else if (previousMethod is TwoStateLemma)
            {
                var two = (TwoStateLemma)previousMethod;
                return new TwoStateLemma(newRange, newName, previousMethod.HasStaticKeyword, tps, ins,
                  previousMethod.Outs.ConvertAll(o => refinementCloner.CloneFormal(o, MutateCSharp.Schemata462.ReplaceBooleanConstant_3(171L, false))),
                  req, reads, mod, ens, decreases, body, refinementCloner.MergeAttributes(previousMethod.Attributes, moreAttributes), null);
            }
            else
            {
                return new Method(newRange, newName, previousMethod.HasStaticKeyword, previousMethod.IsGhost, tps, ins,
                  previousMethod.Outs.ConvertAll(o => refinementCloner.CloneFormal(o, MutateCSharp.Schemata462.ReplaceBooleanConstant_3(172L, false))),
                  req, reads, mod, ens, decreases, body, refinementCloner.MergeAttributes(previousMethod.Attributes, moreAttributes), null, previousMethod.IsByMethod);
            }

            return default;
        }

        // -------------------------------------------------- Merging ---------------------------------------------------------------

        IteratorDecl MergeIterator(IteratorDecl nw, IteratorDecl prev)
        {
            Contract.Requires(nw != null);
            Contract.Requires(prev != null);

            if (MutateCSharp.Schemata462.ReplaceBinExprOp_15(177L, nw.Requires.Count, MutateCSharp.Schemata462.ReplaceNumericConstant_14(173L, 0)))
            {
                Error(ErrorId.ref_no_new_iterator_preconditions, nw.Requires[MutateCSharp.Schemata462.ReplaceNumericConstant_14(182L, 0)].E.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(186L, "a refining iterator is not allowed to add preconditions"));
            }
            if (MutateCSharp.Schemata462.ReplaceBinExprOp_15(191L, nw.YieldRequires.Count, MutateCSharp.Schemata462.ReplaceNumericConstant_14(187L, 0)))
            {
                Error(ErrorId.ref_no_new_iterator_yield_preconditions, nw.YieldRequires[MutateCSharp.Schemata462.ReplaceNumericConstant_14(196L, 0)].E.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(200L, "a refining iterator is not allowed to add yield preconditions"));
            }
            if (MutateCSharp.Schemata462.ReplaceBinExprOp_15(205L, nw.Reads.Expressions.Count, MutateCSharp.Schemata462.ReplaceNumericConstant_14(201L, 0)))
            {
                Error(ErrorId.ref_no_new_iterator_reads, nw.Reads.Expressions[MutateCSharp.Schemata462.ReplaceNumericConstant_14(210L, 0)].E.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(214L, "a refining iterator is not allowed to extend the reads clause"));
            }
            if (MutateCSharp.Schemata462.ReplaceBinExprOp_15(219L, nw.Modifies.Expressions.Count, MutateCSharp.Schemata462.ReplaceNumericConstant_14(215L, 0)))
            {
                Error(ErrorId.ref_no_new_iterator_modifies, nw.Modifies.Expressions[MutateCSharp.Schemata462.ReplaceNumericConstant_14(224L, 0)].E.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(228L, "a refining iterator is not allowed to extend the modifies clause"));
            }
            if (MutateCSharp.Schemata462.ReplaceBinExprOp_15(233L, nw.Decreases.Expressions.Count, MutateCSharp.Schemata462.ReplaceNumericConstant_14(229L, 0)))
            {
                Error(ErrorId.ref_no_new_iterator_decreases, nw.Decreases.Expressions[MutateCSharp.Schemata462.ReplaceNumericConstant_14(238L, 0)].tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(242L, "a refining iterator is not allowed to extend the decreases clause"));
            }

            if (nw.SignatureIsOmitted)
            {
                Contract.Assert(nw.Ins.Count == 0);
                Contract.Assert(nw.Outs.Count == 0);
                Reporter.Info(MessageSource.RefinementTransformer, nw.SignatureEllipsis, Printer.IteratorSignatureToString(Reporter.Options, prev));
            }
            else
            {
                CheckAgreement_TypeParameters(nw.tok, prev.TypeArgs, nw.TypeArgs, nw.Name, MutateCSharp.Schemata462.ReplaceStringConstant_7(243L, "iterator"));
                CheckAgreement_Parameters(nw.tok, prev.Ins, nw.Ins, nw.Name, MutateCSharp.Schemata462.ReplaceStringConstant_7(244L, "iterator"), MutateCSharp.Schemata462.ReplaceStringConstant_7(245L, "in-parameter"));
                CheckAgreement_Parameters(nw.tok, prev.Outs, nw.Outs, nw.Name, MutateCSharp.Schemata462.ReplaceStringConstant_7(246L, "iterator"), MutateCSharp.Schemata462.ReplaceStringConstant_7(247L, "yield-parameter"));
            }

            BlockStmt newBody;
            if (MutateCSharp.Schemata462.ReplaceBinExprOp_23(248L, nw.Body, null))
            {
                newBody = prev.Body;
            }
            else if (MutateCSharp.Schemata462.ReplaceBinExprOp_23(249L, prev.Body, null))
            {
                newBody = nw.Body;
            }
            else
            {
                newBody = MergeBlockStmt(nw.Body, prev.Body);
            }

            var ens = refinementCloner.WithRefinementTokenWrapping(() =>
              prev.Ensures.ConvertAll(refinementCloner.CloneAttributedExpr));
            ens.AddRange(nw.Ensures);
            var yens = refinementCloner.WithRefinementTokenWrapping(() =>
              prev.YieldEnsures.ConvertAll(refinementCloner.CloneAttributedExpr));
            yens.AddRange(nw.YieldEnsures);

            return new IteratorDecl(nw.RangeToken.MakeRefined(moduleUnderConstruction),
              nw.NameNode, moduleUnderConstruction,
              nw.SignatureIsOmitted ? prev.TypeArgs.ConvertAll(refinementCloner.CloneTypeParam) : nw.TypeArgs,
              nw.SignatureIsOmitted ? prev.Ins.ConvertAll(p => refinementCloner.CloneFormal(p, MutateCSharp.Schemata462.ReplaceBooleanConstant_3(250L, false))) : nw.Ins,
              nw.SignatureIsOmitted ? prev.Outs.ConvertAll(o => refinementCloner.CloneFormal(o, MutateCSharp.Schemata462.ReplaceBooleanConstant_3(251L, false))) : nw.Outs,
              refinementCloner.CloneSpecFrameExpr(prev.Reads),
              refinementCloner.CloneSpecFrameExpr(prev.Modifies),
              refinementCloner.CloneSpecExpr(prev.Decreases),
              prev.Requires.ConvertAll(refinementCloner.CloneAttributedExpr),
              ens,
              prev.YieldRequires.ConvertAll(refinementCloner.CloneAttributedExpr),
              yens,
              newBody,
              refinementCloner.MergeAttributes(prev.Attributes, nw.Attributes),
              null);
        }

        TopLevelDeclWithMembers MergeClass(TopLevelDeclWithMembers nw, TopLevelDeclWithMembers prev)
        {
            CheckAgreement_TypeParameters(nw.tok, prev.TypeArgs, nw.TypeArgs, nw.Name, nw.WhatKind);

            prev.ParentTraits.ForEach(item => nw.ParentTraits.Add(refinementCloner.CloneType(item)));
            nw.Attributes = refinementCloner.MergeAttributes(prev.Attributes, nw.Attributes);

            // Create a simple name-to-member dictionary.  Ignore any duplicates at this time.
            var declaredNames = new Dictionary<string, int>();
            for (int i = MutateCSharp.Schemata462.ReplaceNumericConstant_14(252L, 0); MutateCSharp.Schemata462.ReplaceBinExprOp_24(256L, i, nw.Members.Count); MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(261L, ref i))
            {
                var member = nw.Members[i];
                declaredNames.TryAdd(member.Name, i);
            }

            // Merge the declarations of prev into the declarations of m
            foreach (var member in prev.Members)
            {
                if (!declaredNames.TryGetValue(member.Name, out var index))
                {
                    var nwMember = refinementCloner.CloneMember(member, MutateCSharp.Schemata462.ReplaceBooleanConstant_3(262L, false));
                    nwMember.RefinementBase = member;
                    nw.Members.Add(nwMember);
                }
                else
                {
                    var nwMember = nw.Members[index];
                    if (nwMember is ConstantField)
                    {
                        var newConst = (ConstantField)nwMember;
                        var origConst = member as ConstantField;
                        if (MutateCSharp.Schemata462.ReplaceBinExprOp_26(263L, origConst, null))
                        {
                            Error(ErrorId.ref_const_must_refine_const, nwMember, MutateCSharp.Schemata462.ReplaceStringConstant_7(264L, "a const declaration ({0}) in a refining class ({1}) must replace a const in the refinement base"), nwMember.Name, nw.Name);
                        }
                        else if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(265L, () => !(newConst.Type is InferredTypeProxy), () => !TypesAreSyntacticallyEqual(newConst.Type, origConst.Type)))
                        {
                            Error(ErrorId.ref_no_changed_const_type, nwMember, MutateCSharp.Schemata462.ReplaceStringConstant_7(271L, "the type of a const declaration ({0}) in a refining class ({1}) must be syntactically the same as for the const being refined"), nwMember.Name, nw.Name);
                        }
                        else if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(274L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_21(272L, newConst.Rhs, null), () => MutateCSharp.Schemata462.ReplaceBinExprOp_21(273L, origConst.Rhs, null)))
                        {
                            Error(ErrorId.ref_no_refining_const_initializer, nwMember, MutateCSharp.Schemata462.ReplaceStringConstant_7(280L, "a const re-declaration ({0}) can give an initializing expression only if the const in the refinement base does not"), nwMember.Name);
                        }
                        else if (MutateCSharp.Schemata462.ReplaceBinExprOp_13(281L, () => newConst.HasStaticKeyword, () => origConst.HasStaticKeyword))
                        {
                            Error(ErrorId.ref_mismatched_module_static, nwMember, MutateCSharp.Schemata462.ReplaceStringConstant_7(287L, "a const in a refining module cannot be changed from static to non-static or vice versa: {0}"), nwMember.Name);
                        }
                        else if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(288L, () => origConst.IsGhost, () => !newConst.IsGhost))
                        {
                            Error(ErrorId.ref_mismatched_const_ghost, nwMember, MutateCSharp.Schemata462.ReplaceStringConstant_7(294L, "a const re-declaration ({0}) is not allowed to remove 'ghost' from the const declaration"), nwMember.Name);
                        }
                        else if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(302L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_17(295L, newConst.Rhs, null), () => MutateCSharp.Schemata462.ReplaceBinExprOp_27(296L, () => origConst.IsGhost, () => newConst.IsGhost)))
                        {
                            Error(ErrorId.ref_refinement_must_add_const_ghost, nwMember, MutateCSharp.Schemata462.ReplaceStringConstant_7(308L, "a const re-declaration ({0}) must be to add 'ghost' to the const declaration{1}"), nwMember.Name, MutateCSharp.Schemata462.ReplaceBinExprOp_17(309L, origConst.Rhs, null) ? MutateCSharp.Schemata462.ReplaceStringConstant_7(310L, " or to provide an initializing expression") : "");
                        }
                        nwMember.RefinementBase = member;
                        // we may need to clone the given const declaration if either its type or initializing expression was omitted
                        if (MutateCSharp.Schemata462.ReplaceBinExprOp_28(311L, origConst, null))
                        {
                            if (MutateCSharp.Schemata462.ReplaceBinExprOp_2(326L, () => (MutateCSharp.Schemata462.ReplaceBinExprOp_6(312L, () => !(origConst.Type is InferredTypeProxy), () => newConst.Type is InferredTypeProxy)), () => (MutateCSharp.Schemata462.ReplaceBinExprOp_6(320L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_21(318L, origConst.Rhs, null), () => MutateCSharp.Schemata462.ReplaceBinExprOp_17(319L, newConst.Rhs, null)))))
                            {
                                var typ = newConst.Type is InferredTypeProxy ? refinementCloner.CloneType(origConst.Type) : newConst.Type;
                                var rhs = newConst.Rhs ?? origConst.Rhs;
                                nw.Members[index] = new ConstantField(newConst.RangeToken, newConst.NameNode, rhs, newConst.HasStaticKeyword, newConst.IsGhost, newConst.IsOpaque, typ, newConst.Attributes);
                            }
                        }

                    }
                    else if (nwMember is Field)
                    {
                        if (MutateCSharp.Schemata462.ReplaceBinExprOp_2(332L, () => !(member is Field), () => member is ConstantField))
                        {
                            Error(ErrorId.ref_field_must_refine_field, nwMember, MutateCSharp.Schemata462.ReplaceStringConstant_7(338L, "a field declaration ({0}) in a refining class ({1}) must replace a field in the refinement base"), nwMember.Name, nw.Name);
                        }
                        else if (!TypesAreSyntacticallyEqual(((Field)nwMember).Type, ((Field)member).Type))
                        {
                            Error(ErrorId.ref_mismatched_field_name, nwMember, MutateCSharp.Schemata462.ReplaceStringConstant_7(339L, "a field declaration ({0}) in a refining class ({1}) must repeat the syntactically same type as the field has in the refinement base"), nwMember.Name, nw.Name);
                        }
                        else if (MutateCSharp.Schemata462.ReplaceBinExprOp_2(340L, () => member.IsGhost, () => !nwMember.IsGhost))
                        {
                            Error(ErrorId.ref_refinement_field_must_add_ghost, nwMember, MutateCSharp.Schemata462.ReplaceStringConstant_7(346L, "a field re-declaration ({0}) must be to add 'ghost' to the field declaration"), nwMember.Name);
                        }
                        nwMember.RefinementBase = member;

                    }
                    else if (nwMember is Function)
                    {
                        var f = (Function)nwMember;
                        bool isPredicate = f is Predicate;
                        bool isLeastPredicate = f is LeastPredicate;
                        bool isGreatestPredicate = f is GreatestPredicate;
                        if (MutateCSharp.Schemata462.ReplaceBinExprOp_2(401L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_2(389L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_2(377L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_2(365L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_2(353L, () => !(member is Function), () => MutateCSharp.Schemata462.ReplaceBinExprOp_13(347L, () => isPredicate, () => (member is Predicate))), () => MutateCSharp.Schemata462.ReplaceBinExprOp_13(359L, () => (f is LeastPredicate), () => (member is LeastPredicate))), () => MutateCSharp.Schemata462.ReplaceBinExprOp_13(371L, () => (f is GreatestPredicate), () => (member is GreatestPredicate))), () => MutateCSharp.Schemata462.ReplaceBinExprOp_13(383L, () => (f is TwoStatePredicate), () => (member is TwoStatePredicate))), () => MutateCSharp.Schemata462.ReplaceBinExprOp_13(395L, () => (f is TwoStateFunction), () => (member is TwoStateFunction))))
                        {
                            Error(ErrorId.ref_mismatched_refinement_kind, nwMember, MutateCSharp.Schemata462.ReplaceStringConstant_7(407L, "a {0} declaration ({1}) can only refine a {0}"), f.WhatKind, nwMember.Name);
                        }
                        else
                        {
                            var prevFunction = (Function)member;
                            if (MutateCSharp.Schemata462.ReplaceBinExprOp_15(412L, f.Req.Count, MutateCSharp.Schemata462.ReplaceNumericConstant_14(408L, 0)))
                            {
                                Error(ErrorId.ref_refinement_no_new_preconditions, f.Req[MutateCSharp.Schemata462.ReplaceNumericConstant_14(417L, 0)].E.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(421L, "a refining {0} is not allowed to add preconditions"), f.WhatKind);
                            }
                            if (MutateCSharp.Schemata462.ReplaceBinExprOp_15(426L, f.Reads.Expressions.Count, MutateCSharp.Schemata462.ReplaceNumericConstant_14(422L, 0)))
                            {
                                Error(ErrorId.ref_refinement_no_new_reads, f.Reads.Expressions[MutateCSharp.Schemata462.ReplaceNumericConstant_14(431L, 0)].E.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(435L, "a refining {0} is not allowed to extend the reads clause"), f.WhatKind);
                            }
                            if (MutateCSharp.Schemata462.ReplaceBinExprOp_15(440L, f.Decreases.Expressions.Count, MutateCSharp.Schemata462.ReplaceNumericConstant_14(436L, 0)))
                            {
                                Error(ErrorId.ref_no_new_decreases, f.Decreases.Expressions[MutateCSharp.Schemata462.ReplaceNumericConstant_14(445L, 0)].tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(449L, "decreases clause on refining {0} not supported"), f.WhatKind);
                            }

                            if (MutateCSharp.Schemata462.ReplaceBinExprOp_13(450L, () => prevFunction.HasStaticKeyword, () => f.HasStaticKeyword))
                            {
                                Error(ErrorId.ref_mismatched_function_static, f, MutateCSharp.Schemata462.ReplaceStringConstant_7(456L, "a function in a refining module cannot be changed from static to non-static or vice versa: {0}"), f.Name);
                            }
                            if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(457L, () => !prevFunction.IsGhost, () => f.IsGhost))
                            {
                                Error(ErrorId.ref_mismatched_function_compile, f, MutateCSharp.Schemata462.ReplaceStringConstant_7(463L, "a compiled function cannot be changed into a ghost function in a refining module: {0}"), f.Name);
                            }
                            else if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(471L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_6(464L, () => prevFunction.IsGhost, () => !f.IsGhost), () => MutateCSharp.Schemata462.ReplaceBinExprOp_21(470L, prevFunction.Body, null)))
                            {
                                Error(ErrorId.ref_no_refinement_function_with_body, f, MutateCSharp.Schemata462.ReplaceStringConstant_7(477L, "a ghost function can be changed into a compiled function in a refining module only if the function has not yet been given a body: {0}"), f.Name);
                            }
                            if (f.SignatureIsOmitted)
                            {
                                Contract.Assert(f.TypeArgs.Count == 0);
                                Contract.Assert(f.Ins.Count == 0);
                                Reporter.Info(MessageSource.RefinementTransformer, f.SignatureEllipsis, Printer.FunctionSignatureToString(Reporter.Options, prevFunction));
                            }
                            else
                            {
                                CheckAgreement_TypeParameters(f.tok, prevFunction.TypeArgs, f.TypeArgs, f.Name, MutateCSharp.Schemata462.ReplaceStringConstant_7(478L, "function"));
                                CheckAgreement_Parameters(f.tok, prevFunction.Ins, f.Ins, f.Name, MutateCSharp.Schemata462.ReplaceStringConstant_7(479L, "function"), MutateCSharp.Schemata462.ReplaceStringConstant_7(480L, "parameter"));
                                if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(490L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_6(483L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_19(481L, prevFunction.Result, null), () => MutateCSharp.Schemata462.ReplaceBinExprOp_19(482L, f.Result, null)), () => MutateCSharp.Schemata462.ReplaceBinExprOp_29(489L, prevFunction.Result.Name, f.Result.Name)))
                                {
                                    Error(ErrorId.ref_mismatched_function_return_name, f, MutateCSharp.Schemata462.ReplaceStringConstant_7(496L, "the name of function return value '{0}'({1}) differs from the name of corresponding function return value in the module it refines ({2})"), f.Name, f.Result.Name, prevFunction.Result.Name);
                                }
                                if (!TypesAreSyntacticallyEqual(prevFunction.ResultType, f.ResultType))
                                {
                                    Error(ErrorId.ref_mismatched_function_return_type, f, MutateCSharp.Schemata462.ReplaceStringConstant_7(497L, "the result type of function '{0}' ({1}) differs from the result type of the corresponding function in the module it refines ({2})"), f.Name, f.ResultType, prevFunction.ResultType);
                                }
                            }

                            Expression moreBody = null;
                            Expression replacementBody = null;
                            if (MutateCSharp.Schemata462.ReplaceBinExprOp_17(498L, prevFunction.Body, null))
                            {
                                replacementBody = f.Body;
                            }
                            else if (MutateCSharp.Schemata462.ReplaceBinExprOp_21(499L, f.Body, null))
                            {
                                Error(ErrorId.ref_mismatched_refinement_body, nwMember, $"a refining {f.WhatKind} is not allowed to extend/change the body");
                            }
                            var newF = CloneFunction(f, prevFunction, moreBody, replacementBody, MutateCSharp.Schemata462.ReplaceBinExprOp_17(500L, prevFunction.Body, null), f.Attributes);
                            newF.RefinementBase = member;
                            nw.Members[index] = newF;
                        }

                    }
                    else
                    {
                        var m = (Method)nwMember;
                        if (!(member is Method))
                        {
                            Error(ErrorId.ref_method_refines_method, nwMember, MutateCSharp.Schemata462.ReplaceStringConstant_7(501L, "a method declaration ({0}) can only refine a method"), nwMember.Name);
                        }
                        else
                        {
                            var prevMethod = (Method)member;
                            if (MutateCSharp.Schemata462.ReplaceBinExprOp_15(506L, m.Req.Count, MutateCSharp.Schemata462.ReplaceNumericConstant_14(502L, 0)))
                            {
                                Error(ErrorId.ref_no_new_method_precondition, m.Req[MutateCSharp.Schemata462.ReplaceNumericConstant_14(511L, 0)].E.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(515L, "a refining method is not allowed to add preconditions"));
                            }
                            if (MutateCSharp.Schemata462.ReplaceBinExprOp_15(520L, m.Reads.Expressions.Count, MutateCSharp.Schemata462.ReplaceNumericConstant_14(516L, 0)))
                            {
                                Error(ErrorId.ref_no_new_method_reads, m.Reads.Expressions[MutateCSharp.Schemata462.ReplaceNumericConstant_14(525L, 0)].E.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(529L, "a refining method is not allowed to extend the reads clause"));
                            }
                            if (MutateCSharp.Schemata462.ReplaceBinExprOp_15(534L, m.Mod.Expressions.Count, MutateCSharp.Schemata462.ReplaceNumericConstant_14(530L, 0)))
                            {
                                Error(ErrorId.ref_no_new_method_modifies, m.Mod.Expressions[MutateCSharp.Schemata462.ReplaceNumericConstant_14(539L, 0)].E.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(543L, "a refining method is not allowed to extend the modifies clause"));
                            }
                            // If the previous method was not specified with "decreases *", then the new method is not allowed to provide any "decreases" clause.
                            // Any "decreases *" clause is not inherited, so if the previous method was specified with "decreases *", then the new method needs
                            // to either redeclare "decreases *", provided a termination-checking "decreases" clause, or give no "decreases" clause and thus
                            // get a default "decreases" loop.
                            Specification<Expression> decreases;
                            if (MutateCSharp.Schemata462.ReplaceBinExprOp_30(548L, m.Decreases.Expressions.Count, MutateCSharp.Schemata462.ReplaceNumericConstant_14(544L, 0)))
                            {
                                // inherited whatever the previous loop used
                                decreases = refinementCloner.CloneSpecExpr(prevMethod.Decreases);
                            }
                            else
                            {
                                if (!Contract.Exists(prevMethod.Decreases.Expressions, e => e is WildcardExpr))
                                {
                                    // If the previous loop was not specified with "decreases *", then the new loop is not allowed to provide any "decreases" clause.
                                    Error(ErrorId.ref_no_new_method_decreases, m.Decreases.Expressions[MutateCSharp.Schemata462.ReplaceNumericConstant_14(553L, 0)].tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(557L, "decreases clause on refining method not supported, unless the refined method was specified with 'decreases *'"));
                                }
                                decreases = m.Decreases;
                            }
                            if (MutateCSharp.Schemata462.ReplaceBinExprOp_13(558L, () => prevMethod.HasStaticKeyword, () => m.HasStaticKeyword))
                            {
                                Error(ErrorId.ref_mismatched_method_static, m, MutateCSharp.Schemata462.ReplaceStringConstant_7(564L, "a method in a refining module cannot be changed from static to non-static or vice versa: {0}"), m.Name);
                            }
                            if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(565L, () => prevMethod.IsGhost, () => !m.IsGhost))
                            {
                                Error(ErrorId.ref_mismatched_method_ghost, m, MutateCSharp.Schemata462.ReplaceStringConstant_7(571L, "a ghost method cannot be changed into a non-ghost method in a refining module: {0}"), m.Name);
                            }
                            else if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(572L, () => !prevMethod.IsGhost, () => m.IsGhost))
                            {
                                Error(ErrorId.ref_mismatched_method_non_ghost, m, MutateCSharp.Schemata462.ReplaceStringConstant_7(578L, "a method cannot be changed into a ghost method in a refining module: {0}"), m.Name);
                            }
                            if (m.SignatureIsOmitted)
                            {
                                Contract.Assert(m.TypeArgs.Count == 0);
                                Contract.Assert(m.Ins.Count == 0);
                                Contract.Assert(m.Outs.Count == 0);
                                Reporter.Info(MessageSource.RefinementTransformer, m.SignatureEllipsis, Printer.MethodSignatureToString(Reporter.Options, prevMethod));
                            }
                            else
                            {
                                CheckAgreement_TypeParameters(m.tok, prevMethod.TypeArgs, m.TypeArgs, m.Name, MutateCSharp.Schemata462.ReplaceStringConstant_7(579L, "method"));
                                CheckAgreement_Parameters(m.tok, prevMethod.Ins, m.Ins, m.Name, MutateCSharp.Schemata462.ReplaceStringConstant_7(580L, "method"), MutateCSharp.Schemata462.ReplaceStringConstant_7(581L, "in-parameter"));
                                CheckAgreement_Parameters(m.tok, prevMethod.Outs, m.Outs, m.Name, MutateCSharp.Schemata462.ReplaceStringConstant_7(582L, "method"), MutateCSharp.Schemata462.ReplaceStringConstant_7(583L, "out-parameter"));
                            }
                            currentMethod = m;
                            var replacementBody = m.Body;
                            if (MutateCSharp.Schemata462.ReplaceBinExprOp_31(584L, replacementBody, null))
                            {
                                if (MutateCSharp.Schemata462.ReplaceBinExprOp_23(585L, prevMethod.Body, null))
                                {
                                    // cool
                                }
                                else
                                {
                                    replacementBody = MergeBlockStmt(replacementBody, prevMethod.Body);
                                }
                            }
                            var newM = CloneMethod(prevMethod, m.Ens, decreases, replacementBody, MutateCSharp.Schemata462.ReplaceBinExprOp_23(586L, prevMethod.Body, null), m.Attributes);
                            newM.RefinementBase = member;
                            nw.Members[index] = newM;
                        }
                    }
                }
            }

            return nw;
        }
        void CheckAgreement_TypeParameters(IToken tok, List<TypeParameter> old, List<TypeParameter> nw, string name, string thing, bool checkNames = true)
        {
            Contract.Requires(tok != null);
            Contract.Requires(old != null);
            Contract.Requires(nw != null);
            Contract.Requires(name != null);
            Contract.Requires(thing != null);
            if (MutateCSharp.Schemata462.ReplaceBinExprOp_15(587L, old.Count, nw.Count))
            {
                Error(ErrorId.ref_mismatched_type_parameters_count, tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(592L, "{0} '{1}' is declared with a different number of type parameters ({2} instead of {3}) than the corresponding {0} in the module it refines"), thing, name, nw.Count, old.Count);
            }
            else
            {
                for (int i = MutateCSharp.Schemata462.ReplaceNumericConstant_14(593L, 0); MutateCSharp.Schemata462.ReplaceBinExprOp_24(597L, i, old.Count); MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(602L, ref i))
                {
                    var o = old[i];
                    var n = nw[i];
                    if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(604L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_29(603L, o.Name, n.Name), () => checkNames))
                    { // if checkNames is false, then just treat the parameters positionally.
                        Error(ErrorId.ref_mismatched_type_parameter_name, n.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(610L, "type parameters are not allowed to be renamed from the names given in the {0} in the module being refined (expected '{1}', found '{2}')"), thing, o.Name, n.Name);
                    }
                    else
                    {
                        // This explains what we want to do and why:
                        // switch (o.EqualitySupport) {
                        //   case TypeParameter.EqualitySupportValue.Required:
                        //     // here, we will insist that the new type-parameter also explicitly requires equality support (because we don't want
                        //     // to wait for the inference to run on the new module)
                        //     good = n.EqualitySupport == TypeParameter.EqualitySupportValue.Required;
                        //     break;
                        //   case TypeParameter.EqualitySupportValue.InferredRequired:
                        //     // here, we can allow anything, because even with an Unspecified value, the inference will come up with InferredRequired, like before
                        //     good = true;
                        //     break;
                        //   case TypeParameter.EqualitySupportValue.Unspecified:
                        //     // inference didn't come up with anything on the previous module, so the only value we'll allow here is Unspecified as well
                        //     good = n.EqualitySupport == TypeParameter.EqualitySupportValue.Unspecified;
                        //     break;
                        // }
                        // Here's how we actually compute it:
                        if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(613L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_32(611L, o.Characteristics.EqualitySupport, TypeParameter.EqualitySupportValue.InferredRequired), () => MutateCSharp.Schemata462.ReplaceBinExprOp_32(612L, o.Characteristics.EqualitySupport, n.Characteristics.EqualitySupport)))
                        {
                            Error(ErrorId.ref_mismatched_type_parameter_equality, n.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(619L, "type parameter '{0}' is not allowed to change the requirement of supporting equality"), n.Name);
                        }
                        if (MutateCSharp.Schemata462.ReplaceBinExprOp_13(620L, () => o.Characteristics.HasCompiledValue, () => n.Characteristics.HasCompiledValue))
                        {
                            Error(ErrorId.ref_mismatched_type_parameter_auto_init, n.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(626L, "type parameter '{0}' is not allowed to change the requirement of supporting auto-initialization"), n.Name);
                        }
                        else if (MutateCSharp.Schemata462.ReplaceBinExprOp_13(627L, () => o.Characteristics.IsNonempty, () => n.Characteristics.IsNonempty))
                        {
                            Error(ErrorId.ref_mismatched_type_parameter_nonempty, n.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(633L, "type parameter '{0}' is not allowed to change the requirement of being nonempty"), n.Name);
                        }
                        if (MutateCSharp.Schemata462.ReplaceBinExprOp_13(634L, () => o.Characteristics.ContainsNoReferenceTypes, () => n.Characteristics.ContainsNoReferenceTypes))
                        {
                            Error(ErrorId.ref_mismatched_type_parameter_not_reference, n.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(640L, "type parameter '{0}' is not allowed to change the no-reference-type requirement"), n.Name);
                        }
                        if (MutateCSharp.Schemata462.ReplaceBinExprOp_33(641L, o.Variance, n.Variance))
                        {  // syntax is allowed to be different as long as the meaning is the same (i.e., compare Variance, not VarianceSyntax)
                            var ov = MutateCSharp.Schemata462.ReplaceBinExprOp_34(642L, o.Variance, TypeParameter.TPVariance.Co) ? MutateCSharp.Schemata462.ReplaceStringConstant_7(643L, "+") : MutateCSharp.Schemata462.ReplaceBinExprOp_34(644L, o.Variance, TypeParameter.TPVariance.Contra) ? MutateCSharp.Schemata462.ReplaceStringConstant_7(645L, "-") : MutateCSharp.Schemata462.ReplaceStringConstant_7(646L, "=");
                            var nv = MutateCSharp.Schemata462.ReplaceBinExprOp_34(647L, n.Variance, TypeParameter.TPVariance.Co) ? MutateCSharp.Schemata462.ReplaceStringConstant_7(648L, "+") : MutateCSharp.Schemata462.ReplaceBinExprOp_34(649L, n.Variance, TypeParameter.TPVariance.Contra) ? MutateCSharp.Schemata462.ReplaceStringConstant_7(650L, "-") : MutateCSharp.Schemata462.ReplaceStringConstant_7(651L, "=");
                            Error(ErrorId.ref_mismatched_type_parameter_variance, n.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(652L, "type parameter '{0}' is not allowed to change variance (here, from '{1}' to '{2}')"), n.Name, ov, nv);
                        }
                    }
                }
            }
        }

        void CheckAgreement_Parameters(IToken tok, List<Formal> old, List<Formal> nw, string name, string thing, string parameterKind)
        {
            Contract.Requires(tok != null);
            Contract.Requires(old != null);
            Contract.Requires(nw != null);
            Contract.Requires(name != null);
            Contract.Requires(thing != null);
            Contract.Requires(parameterKind != null);
            if (MutateCSharp.Schemata462.ReplaceBinExprOp_15(653L, old.Count, nw.Count))
            {
                Error(ErrorId.ref_mismatched_kind_count, tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(658L, "{0} '{1}' is declared with a different number of {2} ({3} instead of {4}) than the corresponding {0} in the module it refines"), thing, name, parameterKind, nw.Count, old.Count);
            }
            else
            {
                for (int i = MutateCSharp.Schemata462.ReplaceNumericConstant_14(659L, 0); MutateCSharp.Schemata462.ReplaceBinExprOp_24(663L, i, old.Count); MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(668L, ref i))
                {
                    var o = old[i];
                    var n = nw[i];
                    if (MutateCSharp.Schemata462.ReplaceBinExprOp_29(669L, o.Name, n.Name))
                    {
                        Error(ErrorId.ref_mismatched_kind_name, n.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(670L, "there is a difference in name of {0} {1} ('{2}' versus '{3}') of {4} {5} compared to corresponding {4} in the module it refines"), parameterKind, i, n.Name, o.Name, thing, name);
                    }
                    else if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(671L, () => !o.IsGhost, () => n.IsGhost))
                    {
                        Error(ErrorId.ref_mismatched_kind_ghost, n.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(677L, "{0} '{1}' of {2} {3} cannot be changed, compared to the corresponding {2} in the module it refines, from non-ghost to ghost"), parameterKind, n.Name, thing, name);
                    }
                    else if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(678L, () => o.IsGhost, () => !n.IsGhost))
                    {
                        Error(ErrorId.ref_mismatched_kind_non_ghost, n.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(684L, "{0} '{1}' of {2} {3} cannot be changed, compared to the corresponding {2} in the module it refines, from ghost to non-ghost"), parameterKind, n.Name, thing, name);
                    }
                    else if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(685L, () => !o.IsOld, () => n.IsOld))
                    {
                        Error(ErrorId.ref_mismatched_kind_non_new, n.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(691L, "{0} '{1}' of {2} {3} cannot be changed, compared to the corresponding {2} in the module it refines, from new to non-new"), parameterKind, n.Name, thing, name);
                    }
                    else if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(692L, () => o.IsOld, () => !n.IsOld))
                    {
                        Error(ErrorId.ref_mismatched_kind_new, n.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(698L, "{0} '{1}' of {2} {3} cannot be changed, compared to the corresponding {2} in the module it refines, from non-new to new"), parameterKind, n.Name, thing, name);
                    }
                    else if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(699L, () => !o.IsOlder, () => n.IsOlder))
                    {
                        Error(ErrorId.ref_mismatched_kind_older, n.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(705L, "{0} '{1}' of {2} {3} cannot be changed, compared to the corresponding {2} in the module it refines, from non-older to older"), parameterKind, n.Name, thing, name);
                    }
                    else if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(706L, () => o.IsOlder, () => !n.IsOlder))
                    {
                        Error(ErrorId.ref_mismatched_kind_non_older, n.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(712L, "{0} '{1}' of {2} {3} cannot be changed, compared to the corresponding {2} in the module it refines, from older to non-older"), parameterKind, n.Name, thing, name);
                    }
                    else if (!TypesAreSyntacticallyEqual(o.Type, n.Type))
                    {
                        Error(ErrorId.ref_mismatched_parameter_type, n.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(713L, "the type of {0} '{1}' is different from the type of the same {0} in the corresponding {2} in the module it refines ('{3}' instead of '{4}')"), parameterKind, n.Name, thing, n.Type, o.Type);
                    }
                    else if (MutateCSharp.Schemata462.ReplaceBinExprOp_21(714L, n.DefaultValue, null))
                    {
                        Error(ErrorId.ref_refined_formal_may_not_have_default, n.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(715L, "a refining formal parameter ('{0}') in a refinement module is not allowed to give a default-value expression"), n.Name);
                    }
                }
            }
        }

        bool TypesAreSyntacticallyEqual(Type t, Type u)
        {
            Contract.Requires(t != null);
            Contract.Requires(u != null);
            return MutateCSharp.Schemata462.ReplaceBinExprOp_12(716L, t.ToString(), u.ToString());
        }

        /// <summary>
        /// This method merges the statement "oldStmt" into the template "skeleton".
        /// </summary>
        BlockStmt MergeBlockStmt(BlockStmt skeleton, BlockStmt oldStmt)
        {
            Contract.Requires(skeleton != null);
            Contract.Requires(oldStmt != null);
            Contract.Requires(skeleton is DividedBlockStmt == oldStmt is DividedBlockStmt);

            if (skeleton is DividedBlockStmt)
            {
                var sbsSkeleton = (DividedBlockStmt)skeleton;
                var sbsOldStmt = (DividedBlockStmt)oldStmt;
                var bodyInit = MergeStmtList(sbsSkeleton.BodyInit, sbsOldStmt.BodyInit, out var hoverText);
                if (MutateCSharp.Schemata462.ReplaceBinExprOp_15(721L, hoverText.Length, MutateCSharp.Schemata462.ReplaceNumericConstant_14(717L, 0)))
                {
                    Reporter.Info(MessageSource.RefinementTransformer, sbsSkeleton.SeparatorTok ?? sbsSkeleton.Tok, hoverText);
                }
                var bodyProper = MergeStmtList(sbsSkeleton.BodyProper, sbsOldStmt.BodyProper, out hoverText);
                if (MutateCSharp.Schemata462.ReplaceBinExprOp_15(730L, hoverText.Length, MutateCSharp.Schemata462.ReplaceNumericConstant_14(726L, 0)))
                {
                    Reporter.Info(MessageSource.RefinementTransformer, sbsSkeleton.RangeToken.ToToken(), hoverText);
                }
                return new DividedBlockStmt(sbsSkeleton.RangeToken, bodyInit, sbsSkeleton.SeparatorTok, bodyProper);
            }
            else
            {
                var body = MergeStmtList(skeleton.Body, oldStmt.Body, out var hoverText);
                if (MutateCSharp.Schemata462.ReplaceBinExprOp_15(739L, hoverText.Length, MutateCSharp.Schemata462.ReplaceNumericConstant_14(735L, 0)))
                {
                    Reporter.Info(MessageSource.RefinementTransformer, skeleton.RangeToken.ToToken(), hoverText);
                }
                return new BlockStmt(skeleton.RangeToken, body);
            }

            return default;
        }

        List<Statement> MergeStmtList(List<Statement> skeleton, List<Statement> oldStmt, out string hoverText)
        {
            Contract.Requires(skeleton != null);
            Contract.Requires(oldStmt != null);
            Contract.Ensures(Contract.ValueAtReturn(out hoverText) != null);
            Contract.Ensures(Contract.Result<List<Statement>>() != null);

            hoverText = "";
            var body = new List<Statement>();
            int i = MutateCSharp.Schemata462.ReplaceNumericConstant_14(744L, 0), j = MutateCSharp.Schemata462.ReplaceNumericConstant_14(748L, 0);
            while (MutateCSharp.Schemata462.ReplaceBinExprOp_24(752L, i, skeleton.Count))
            {
                var cur = skeleton[i];
                if (MutateCSharp.Schemata462.ReplaceBinExprOp_30(757L, j, oldStmt.Count))
                {
                    if (!(cur is SkeletonStatement))
                    {
                        MergeAddStatement(cur, body);
                    }
                    else if (MutateCSharp.Schemata462.ReplaceBinExprOp_35(762L, ((SkeletonStatement)cur).S, null))
                    {
                        // the "..." matches the empty statement sequence
                    }
                    else
                    {
                        Error(ErrorId.ref_mismatched_skeleton, cur.Tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(763L, "skeleton statement does not match old statement"));
                    }

                    MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(764L, ref i);
                }
                else
                {
                    var oldS = oldStmt[j];
                    /* See how the two statements match up.
                     *   oldS                         cur                         result
                     *   ------                      ------                       ------
                     *   assume E;                    assert ...;                 assert E;
                     *   assert E;                    assert ...;                 assert E;
                     *   assert E;                                                assert E;
                     *
                     *   assume E;                    assume ...;                 assume E;
                     *
                     *   var x;                       var x := E;                 var x := E;
                     *   var x := *;                  var x := E;                 var x := E;
                     *   var x :| P;                  var x := E1;                var x := E1; assert P;
                     *   var VarProduction;                                       var VarProduction;
                     *
                     *   x := *;                      x := E;                     x := E;
                     *   x :| P;                      x := E;                     x := E; assert P;
                     *
                     *   modify E;                    modify ...;                 modify E;
                     *   modify E;                    modify ... { S }            modify E { S }
                     *   modify E { S }               modify ... { S' }           modify E { Merge(S, S') }
                     *
                     *   if (G) Then' else Else'      if ... Then else Else       if (G) Merge(Then,Then') else Merge(Else,Else')
                     *   if (*) Then' else Else'      if (G) Then else Else       if (G) Merge(Then,Then') else Merge(Else,Else')
                     *
                     *   while (G) LoopSpec' Body     while ... LoopSpec ...      while (G) Merge(LoopSpec,LoopSpec') Body
                     *   while (G) LoopSpec' Body'    while ... LoopSpec Body     while (G) Merge(LoopSpec,LoopSpec') Merge(Body,Body')
                     *   while (*) LoopSpec' Body     while (G) LoopSpec ...      while (G) Merge(LoopSpec,LoopSpec') Body
                     *   while (*) LoopSpec' Body'    while (G) LoopSpec Body     while (G) Merge(LoopSpec,LoopSpec') Merge(Body,Body')
                     *
                     *   StmtThatDoesNotMatchS; S'    ... where x = e; S          StatementThatDoesNotMatchS[e/x]; Merge( ... where x = e; S , S')
                     *   StmtThatMatchesS; S'         ... where x = e; S          StmtThatMatchesS; S'
                     *
                     * Note, LoopSpec must contain only invariant declarations (as the parser ensures for the first three cases).
                     * Note, there is an implicit "...;" at the end of every block in a skeleton.
                     */
                    if (cur is SkeletonStatement)
                    {
                        var c = (SkeletonStatement)cur;
                        var S = c.S;
                        if (MutateCSharp.Schemata462.ReplaceBinExprOp_35(765L, S, null))
                        {
                            var nxt = MutateCSharp.Schemata462.ReplaceBinExprOp_30(779L, MutateCSharp.Schemata462.ReplaceBinExprOp_36(770L, i, MutateCSharp.Schemata462.ReplaceNumericConstant_14(766L, 1)), skeleton.Count) ? null : skeleton[MutateCSharp.Schemata462.ReplaceBinExprOp_36(788L, i, MutateCSharp.Schemata462.ReplaceNumericConstant_14(784L, 1))];
                            if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(805L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_6(798L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_37(797L, nxt, null), () => nxt is SkeletonStatement), () => MutateCSharp.Schemata462.ReplaceBinExprOp_35(804L, ((SkeletonStatement)nxt).S, null)))
                            {
                                // "...; ...;" is the same as just "...;", so skip this one
                            }
                            else
                            {
                                // skip up until the next thing that matches "nxt"
                                var hoverTextA = "";
                                var sepA = "";
                                while (MutateCSharp.Schemata462.ReplaceBinExprOp_2(812L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_35(811L, nxt, null), () => !PotentialMatch(nxt, oldS)))
                                {
                                    // loop invariant:  oldS == oldStmt.Body[j]
                                    var s = refinementCloner.CloneStmt(oldS, MutateCSharp.Schemata462.ReplaceBooleanConstant_3(818L, false));
                                    body.Add(s);
                                    hoverTextA += sepA + Printer.StatementToString(Reporter.Options, s);
                                    sepA = MutateCSharp.Schemata462.ReplaceStringConstant_7(819L, "\n");
                                    MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(820L, ref j);
                                    if (MutateCSharp.Schemata462.ReplaceBinExprOp_30(821L, j, oldStmt.Count)) { break; }
                                    oldS = oldStmt[j];
                                }
                                if (MutateCSharp.Schemata462.ReplaceBinExprOp_15(830L, hoverTextA.Length, MutateCSharp.Schemata462.ReplaceNumericConstant_14(826L, 0)))
                                {
                                    Reporter.Info(MessageSource.RefinementTransformer, c.Tok, hoverTextA);
                                }
                            }

                            MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(835L, ref i);

                        }
                        else if (S is AssertStmt)
                        {
                            var skel = (AssertStmt)S;
                            Contract.Assert(c.ConditionOmitted);
                            var oldAssume = oldS as PredicateStmt;
                            if (MutateCSharp.Schemata462.ReplaceBinExprOp_38(836L, oldAssume, null))
                            {
                                Error(ErrorId.ref_mismatched_assert, cur.Tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(837L, "assert template does not match inherited statement"));
                                MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(838L, ref i);
                            }
                            else
                            {
                                // Clone the expression, but among the new assert's attributes, indicate
                                // that this assertion is supposed to be translated into a check.  That is,
                                // it is not allowed to be just assumed in the translation, despite the fact
                                // that the condition is inherited.
                                var e = refinementCloner.CloneExpr(oldAssume.Expr);
                                var attrs = refinementCloner.MergeAttributes(oldAssume.Attributes, skel.Attributes);
                                body.Add(new AssertStmt(new RangeToken(new BoogieGenerator.ForceCheckToken(skel.RangeToken.StartToken), skel.RangeToken.EndToken),
                                  e, skel.Proof, skel.Label, new Attributes(MutateCSharp.Schemata462.ReplaceStringConstant_7(839L, "_prependAssertToken"), new List<Expression>(), attrs)));
                                Reporter.Info(MessageSource.RefinementTransformer, c.ConditionEllipsis, MutateCSharp.Schemata462.ReplaceStringConstant_7(840L, "assume->assert: ") + Printer.ExprToString(Reporter.Options, e));
                                MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(841L, ref i);
                                MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(842L, ref j);
                            }

                        }
                        else if (S is ExpectStmt)
                        {
                            var skel = (ExpectStmt)S;
                            Contract.Assert(c.ConditionOmitted);
                            var oldExpect = oldS as ExpectStmt;
                            if (MutateCSharp.Schemata462.ReplaceBinExprOp_39(843L, oldExpect, null))
                            {
                                Error(ErrorId.ref_mismatched_expect, cur.Tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(844L, "expect template does not match inherited statement"));
                                MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(845L, ref i);
                            }
                            else
                            {
                                var e = refinementCloner.CloneExpr(oldExpect.Expr);
                                var message = refinementCloner.CloneExpr(oldExpect.Message);
                                var attrs = refinementCloner.MergeAttributes(oldExpect.Attributes, skel.Attributes);
                                body.Add(new ExpectStmt(skel.RangeToken, e, message, attrs));
                                Reporter.Info(MessageSource.RefinementTransformer, c.ConditionEllipsis, Printer.ExprToString(Reporter.Options, e));
                                MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(846L, ref i);
                                MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(847L, ref j);
                            }

                        }
                        else if (S is AssumeStmt)
                        {
                            var skel = (AssumeStmt)S;
                            Contract.Assert(c.ConditionOmitted);
                            var oldAssume = oldS as AssumeStmt;
                            if (MutateCSharp.Schemata462.ReplaceBinExprOp_40(848L, oldAssume, null))
                            {
                                Error(ErrorId.ref_mismatched_assume, cur.Tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(849L, "assume template does not match inherited statement"));
                                MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(850L, ref i);
                            }
                            else
                            {
                                var e = refinementCloner.CloneExpr(oldAssume.Expr);
                                var attrs = refinementCloner.MergeAttributes(oldAssume.Attributes, skel.Attributes);
                                body.Add(new AssumeStmt(skel.RangeToken, e, attrs));
                                Reporter.Info(MessageSource.RefinementTransformer, c.ConditionEllipsis, Printer.ExprToString(Reporter.Options, e));
                                MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(851L, ref i);
                                MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(852L, ref j);
                            }

                        }
                        else if (S is IfStmt)
                        {
                            var skel = (IfStmt)S;
                            Contract.Assert(c.ConditionOmitted);
                            var oldIf = oldS as IfStmt;
                            if (MutateCSharp.Schemata462.ReplaceBinExprOp_41(853L, oldIf, null))
                            {
                                Error(ErrorId.ref_mismatched_if_statement, cur.Tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(854L, "if-statement template does not match inherited statement"));
                                MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(855L, ref i);
                            }
                            else
                            {
                                var resultingThen = MergeBlockStmt(skel.Thn, oldIf.Thn);
                                var resultingElse = MergeElse(skel.Els, oldIf.Els);
                                var e = refinementCloner.CloneExpr(oldIf.Guard);
                                var r = new IfStmt(skel.RangeToken, oldIf.IsBindingGuard, e, resultingThen, resultingElse);
                                body.Add(r);
                                Reporter.Info(MessageSource.RefinementTransformer, c.ConditionEllipsis, Printer.GuardToString(Reporter.Options, oldIf.IsBindingGuard, e));
                                MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(856L, ref i);
                                MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(857L, ref j);
                            }

                        }
                        else if (S is WhileStmt)
                        {
                            var skel = (WhileStmt)S;
                            var oldWhile = oldS as WhileStmt;
                            if (MutateCSharp.Schemata462.ReplaceBinExprOp_42(858L, oldWhile, null))
                            {
                                Error(ErrorId.ref_mismatched_while_statement, cur.Tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(859L, "while-statement template does not match inherited statement"));
                                MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(860L, ref i);
                            }
                            else
                            {
                                Expression guard;
                                if (c.ConditionOmitted)
                                {
                                    guard = refinementCloner.CloneExpr(oldWhile.Guard);
                                    Reporter.Info(MessageSource.RefinementTransformer, c.ConditionEllipsis, Printer.GuardToString(Reporter.Options, MutateCSharp.Schemata462.ReplaceBooleanConstant_3(861L, false), oldWhile.Guard));
                                }
                                else
                                {
                                    if (MutateCSharp.Schemata462.ReplaceBinExprOp_21(862L, oldWhile.Guard, null))
                                    {
                                        Error(ErrorId.ref_mismatched_while_statement_guard, skel.Guard.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(863L, "a skeleton while statement with a guard can only replace a while statement with a non-deterministic guard"));
                                    }
                                    guard = skel.Guard;
                                }
                                // Note, if the loop body is omitted in the skeleton, the parser will have set the loop body to an empty block,
                                // which has the same merging behavior.
                                var r = MergeWhileStmt(skel, oldWhile, guard);
                                body.Add(r);
                                MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(864L, ref i);
                                MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(865L, ref j);
                            }

                        }
                        else if (S is ModifyStmt)
                        {
                            var skel = (ModifyStmt)S;
                            Contract.Assert(c.ConditionOmitted);
                            var oldModifyStmt = oldS as ModifyStmt;
                            if (MutateCSharp.Schemata462.ReplaceBinExprOp_43(866L, oldModifyStmt, null))
                            {
                                Error(ErrorId.ref_mismatched_modify_statement, cur.Tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(867L, "modify template does not match inherited statement"));
                                MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(868L, ref i);
                            }
                            else
                            {
                                var mod = refinementCloner.CloneSpecFrameExpr(oldModifyStmt.Mod);
                                BlockStmt mbody;
                                if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(871L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_23(869L, oldModifyStmt.Body, null), () => MutateCSharp.Schemata462.ReplaceBinExprOp_23(870L, skel.Body, null)))
                                {
                                    mbody = null;
                                }
                                else if (MutateCSharp.Schemata462.ReplaceBinExprOp_23(877L, oldModifyStmt.Body, null))
                                {
                                    // Note, it is important to call MergeBlockStmt here (rather than just setting "mbody" to "skel.Body"), even
                                    // though we're passing in an empty block as its second argument. The reason for this is that MergeBlockStmt
                                    // also sets ".ReverifyPost" to "true" for any "return" statements.
                                    mbody = MergeBlockStmt(skel.Body, new BlockStmt(oldModifyStmt.RangeToken, new List<Statement>()));
                                }
                                else if (MutateCSharp.Schemata462.ReplaceBinExprOp_23(878L, skel.Body, null))
                                {
                                    Error(ErrorId.ref_mismatched_statement_body, cur.Tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(879L, "modify template must have a body if the inherited modify statement does"));
                                    mbody = null;
                                }
                                else
                                {
                                    mbody = MergeBlockStmt(skel.Body, oldModifyStmt.Body);
                                }
                                body.Add(new ModifyStmt(skel.RangeToken, mod.Expressions, mod.Attributes, mbody));
                                Reporter.Info(MessageSource.RefinementTransformer, c.ConditionEllipsis, Printer.FrameExprListToString(Reporter.Options, mod.Expressions));
                                MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(880L, ref i);
                                MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(881L, ref j);
                            }

                        }
                        else
                        {
                            Contract.Assume(false);  // unexpected skeleton statement
                        }

                    }
                    else if (cur is AssertStmt)
                    {
                        MergeAddStatement(cur, body);
                        MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(882L, ref i);

                    }
                    else if (cur is VarDeclStmt)
                    {
                        var cNew = (VarDeclStmt)cur;
                        bool doMerge = MutateCSharp.Schemata462.ReplaceBooleanConstant_3(883L, false);
                        Expression addedAssert = null;
                        if (oldS is VarDeclStmt)
                        {
                            var cOld = (VarDeclStmt)oldS;
                            if (LocalVarsAgree(cOld.Locals, cNew.Locals))
                            {
                                var update = cNew.Update as UpdateStmt;
                                if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(885L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_44(884L, update, null), () => update.Rhss.TrueForAll(rhs => !rhs.CanAffectPreviouslyKnownExpressions)))
                                {
                                    // Note, we allow switching between ghost and non-ghost, since that seems unproblematic.
                                    if (MutateCSharp.Schemata462.ReplaceBinExprOp_45(891L, cOld.Update, null))
                                    {
                                        doMerge = MutateCSharp.Schemata462.ReplaceBooleanConstant_3(892L, true);
                                    }
                                    else if (cOld.Update is AssignSuchThatStmt)
                                    {
                                        doMerge = MutateCSharp.Schemata462.ReplaceBooleanConstant_3(893L, true);
                                        addedAssert = refinementCloner.CloneExpr(((AssignSuchThatStmt)cOld.Update).Expr);
                                    }
                                    else
                                    {
                                        var updateOld = (UpdateStmt)cOld.Update;  // if cast fails, there are more ConcreteUpdateStatement subclasses than expected
                                        doMerge = MutateCSharp.Schemata462.ReplaceBooleanConstant_3(894L, true);
                                        foreach (var rhs in updateOld.Rhss)
                                        {
                                            if (!(rhs is HavocRhs))
                                            {
                                                doMerge = MutateCSharp.Schemata462.ReplaceBooleanConstant_3(895L, false);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (doMerge)
                        {
                            // Go ahead with the merge:
                            body.Add(cNew);
                            MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(896L, ref i);
                            MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(897L, ref j);
                            if (MutateCSharp.Schemata462.ReplaceBinExprOp_21(898L, addedAssert, null))
                            {
                                var tok = new BoogieGenerator.ForceCheckToken(addedAssert.RangeToken.StartToken);
                                body.Add(new AssertStmt(new RangeToken(tok, addedAssert.RangeToken.EndToken), addedAssert, null, null, null));
                            }
                        }
                        else
                        {
                            MergeAddStatement(cur, body);
                            MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(899L, ref i);
                        }

                    }
                    else if (cur is AssignStmt)
                    {
                        var cNew = (AssignStmt)cur;
                        var cOld = oldS as AssignStmt;
                        if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(901L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_46(900L, cOld, null), () => oldS is UpdateStmt))
                        {
                            var us = (UpdateStmt)oldS;
                            if (MutateCSharp.Schemata462.ReplaceBinExprOp_30(911L, us.ResolvedStatements.Count, MutateCSharp.Schemata462.ReplaceNumericConstant_14(907L, 1)))
                            {
                                cOld = us.ResolvedStatements[MutateCSharp.Schemata462.ReplaceNumericConstant_14(916L, 0)] as AssignStmt;
                            }
                        }
                        bool doMerge = MutateCSharp.Schemata462.ReplaceBooleanConstant_3(920L, false);
                        if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(928L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_6(922L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_47(921L, cOld, null), () => cNew.Lhs.WasResolved()), () => cOld.Lhs.WasResolved()))
                        {
                            var newLhs = cNew.Lhs.Resolved as IdentifierExpr;
                            var oldLhs = cOld.Lhs.Resolved as IdentifierExpr;
                            if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(943L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_6(936L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_48(934L, newLhs, null), () => MutateCSharp.Schemata462.ReplaceBinExprOp_48(935L, oldLhs, null)), () => MutateCSharp.Schemata462.ReplaceBinExprOp_12(942L, newLhs.Name, oldLhs.Name)))
                            {
                                if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(949L, () => !(cNew.Rhs is TypeRhs), () => cOld.Rhs is HavocRhs))
                                {
                                    doMerge = MutateCSharp.Schemata462.ReplaceBooleanConstant_3(955L, true);
                                }
                            }
                        }
                        if (doMerge)
                        {
                            // Go ahead with the merge:
                            body.Add(cNew);
                            MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(956L, ref i);
                            MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(957L, ref j);
                        }
                        else
                        {
                            MergeAddStatement(cur, body);
                            MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(958L, ref i);
                        }

                    }
                    else if (cur is UpdateStmt)
                    {
                        var nw = (UpdateStmt)cur;
                        List<Statement> stmtGenerated = new List<Statement>();
                        bool doMerge = MutateCSharp.Schemata462.ReplaceBooleanConstant_3(959L, false);
                        if (oldS is UpdateStmt)
                        {
                            var s = (UpdateStmt)oldS;
                            if (LeftHandSidesAgree(s.Lhss, nw.Lhss))
                            {
                                doMerge = MutateCSharp.Schemata462.ReplaceBooleanConstant_3(960L, true);
                                stmtGenerated.Add(nw);
                                foreach (var rhs in s.Rhss)
                                {
                                    if (!(rhs is HavocRhs))
                                    {
                                        doMerge = MutateCSharp.Schemata462.ReplaceBooleanConstant_3(961L, false);
                                    }
                                }
                            }
                        }
                        else if (oldS is AssignSuchThatStmt)
                        {
                            var s = (AssignSuchThatStmt)oldS;
                            if (LeftHandSidesAgree(s.Lhss, nw.Lhss))
                            {
                                doMerge = MutateCSharp.Schemata462.ReplaceBooleanConstant_3(962L, true);
                                stmtGenerated.Add(nw);
                                var addedAssert = refinementCloner.CloneExpr(s.Expr);
                                var tok = new RangeToken(addedAssert.RangeToken.StartToken, addedAssert.RangeToken.EndToken);
                                stmtGenerated.Add(new AssertStmt(tok, addedAssert, null, null, null));
                            }
                        }
                        if (doMerge)
                        {
                            // Go ahead with the merge:
                            Contract.Assert(cce.NonNullElements(stmtGenerated));
                            body.AddRange(stmtGenerated);
                            MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(963L, ref i);
                            MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(964L, ref j);
                        }
                        else
                        {
                            MergeAddStatement(cur, body);
                            MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(965L, ref i);
                        }
                    }
                    else if (cur is IfStmt)
                    {
                        var cNew = (IfStmt)cur;
                        var cOld = oldS as IfStmt;
                        if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(968L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_49(966L, cOld, null), () => MutateCSharp.Schemata462.ReplaceBinExprOp_17(967L, cOld.Guard, null)))
                        {
                            var r = new IfStmt(cNew.RangeToken, cNew.IsBindingGuard, cNew.Guard, MergeBlockStmt(cNew.Thn, cOld.Thn), MergeElse(cNew.Els, cOld.Els));
                            body.Add(r);
                            MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(974L, ref i);
                            MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(975L, ref j);
                        }
                        else
                        {
                            MergeAddStatement(cur, body);
                            MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(976L, ref i);
                        }

                    }
                    else if (cur is WhileStmt)
                    {
                        var cNew = (WhileStmt)cur;
                        var cOld = oldS as WhileStmt;
                        if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(979L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_50(977L, cOld, null), () => MutateCSharp.Schemata462.ReplaceBinExprOp_17(978L, cOld.Guard, null)))
                        {
                            var r = MergeWhileStmt(cNew, cOld, cNew.Guard);
                            body.Add(r);
                            MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(985L, ref i);
                            MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(986L, ref j);
                        }
                        else
                        {
                            MergeAddStatement(cur, body);
                            MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(987L, ref i);
                        }

                    }
                    else if (cur is BlockStmt)
                    {
                        var cNew = (BlockStmt)cur;
                        var cOld = oldS as BlockStmt;
                        if (MutateCSharp.Schemata462.ReplaceBinExprOp_31(988L, cOld, null))
                        {
                            var r = MergeBlockStmt(cNew, cOld);
                            body.Add(r);
                            MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(989L, ref i);
                            MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(990L, ref j);
                        }
                        else
                        {
                            MergeAddStatement(cur, body);
                            MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(991L, ref i);
                        }
                    }
                    else
                    {
                        MergeAddStatement(cur, body);
                        MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(992L, ref i);
                    }
                }
            }
            // implement the implicit "...;" at the end of each block statement skeleton
            var sep = "";
            for (; MutateCSharp.Schemata462.ReplaceBinExprOp_24(993L, j, oldStmt.Count); MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(998L, ref j))
            {
                var b = oldStmt[j];
                body.Add(refinementCloner.CloneStmt(b, MutateCSharp.Schemata462.ReplaceBooleanConstant_3(999L, false)));
                hoverText += sep + Printer.StatementToString(Reporter.Options, b);
                sep = MutateCSharp.Schemata462.ReplaceStringConstant_7(1000L, "\n");
            }
            return body;
        }

        private bool LeftHandSidesAgree(List<Expression> old, List<Expression> nw)
        {
            if (MutateCSharp.Schemata462.ReplaceBinExprOp_15(1001L, old.Count, nw.Count))
            {
                return MutateCSharp.Schemata462.ReplaceBooleanConstant_3(1006L, false);
            }

            for (int i = MutateCSharp.Schemata462.ReplaceNumericConstant_14(1007L, 0); MutateCSharp.Schemata462.ReplaceBinExprOp_24(1011L, i, old.Count); MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(1016L, ref i))
            {
                var a = old[i].WasResolved() ? old[i].Resolved as IdentifierExpr : null;
                var b = nw[i] as NameSegment;
                if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(1026L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_6(1019L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_48(1017L, a, null), () => MutateCSharp.Schemata462.ReplaceBinExprOp_51(1018L, b, null)), () => MutateCSharp.Schemata462.ReplaceBinExprOp_12(1025L, a.Name, b.Name)))
                {
                    // cool
                }
                else
                {
                    return MutateCSharp.Schemata462.ReplaceBooleanConstant_3(1032L, false);
                }
            }
            return MutateCSharp.Schemata462.ReplaceBooleanConstant_3(1033L, true);
        }
        private bool LocalVarsAgree(List<LocalVariable> old, List<LocalVariable> nw)
        {
            if (MutateCSharp.Schemata462.ReplaceBinExprOp_15(1034L, old.Count, nw.Count))
            {
                return MutateCSharp.Schemata462.ReplaceBooleanConstant_3(1039L, false);
            }

            for (int i = MutateCSharp.Schemata462.ReplaceNumericConstant_14(1040L, 0); MutateCSharp.Schemata462.ReplaceBinExprOp_24(1044L, i, old.Count); MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(1049L, ref i))
            {
                if (MutateCSharp.Schemata462.ReplaceBinExprOp_29(1050L, old[i].Name, nw[i].Name))
                {
                    return MutateCSharp.Schemata462.ReplaceBooleanConstant_3(1051L, false);
                }
            }
            return MutateCSharp.Schemata462.ReplaceBooleanConstant_3(1052L, true);
        }

        bool PotentialMatch(Statement nxt, Statement other)
        {
            Contract.Requires(nxt != null);
            Contract.Requires(!(nxt is SkeletonStatement) || ((SkeletonStatement)nxt).S != null);  // nxt is not "...;"
            Contract.Requires(other != null);

            if (MutateCSharp.Schemata462.ReplaceBinExprOp_52(1053L, nxt.Labels, null))
            {
                for (var olbl = other.Labels; MutateCSharp.Schemata462.ReplaceBinExprOp_52(1054L, olbl, null); olbl = olbl.Next)
                {
                    var odata = olbl.Data;
                    for (var l = nxt.Labels; MutateCSharp.Schemata462.ReplaceBinExprOp_52(1055L, l, null); l = l.Next)
                    {
                        if (MutateCSharp.Schemata462.ReplaceBinExprOp_12(1056L, odata.Name, l.Data.Name))
                        {
                            return MutateCSharp.Schemata462.ReplaceBooleanConstant_3(1057L, true);
                        }
                    }
                }
                return MutateCSharp.Schemata462.ReplaceBooleanConstant_3(1058L, false);  // labels of 'nxt' don't match any label of 'other'
            }
            else if (nxt is SkeletonStatement)
            {
                var S = ((SkeletonStatement)nxt).S;
                if (S is AssertStmt)
                {
                    return other is PredicateStmt;
                }
                else if (S is ExpectStmt)
                {
                    return other is ExpectStmt;
                }
                else if (S is AssumeStmt)
                {
                    return other is AssumeStmt;
                }
                else if (S is IfStmt)
                {
                    return other is IfStmt;
                }
                else if (S is WhileStmt)
                {
                    return other is WhileStmt;
                }
                else if (S is ModifyStmt)
                {
                    return other is ModifyStmt;
                }
                else
                {
                    Contract.Assume(false);  // unexpected skeleton
                }

            }
            else if (nxt is IfStmt)
            {
                var oth = other as IfStmt;
                return MutateCSharp.Schemata462.ReplaceBinExprOp_6(1061L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_49(1059L, oth, null), () => MutateCSharp.Schemata462.ReplaceBinExprOp_17(1060L, oth.Guard, null));
            }
            else if (nxt is WhileStmt)
            {
                var oth = other as WhileStmt;
                return MutateCSharp.Schemata462.ReplaceBinExprOp_6(1069L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_50(1067L, oth, null), () => MutateCSharp.Schemata462.ReplaceBinExprOp_17(1068L, oth.Guard, null));
            }
            else if (nxt is VarDeclStmt)
            {
                var oth = other as VarDeclStmt;
                return MutateCSharp.Schemata462.ReplaceBinExprOp_6(1076L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_53(1075L, oth, null), () => LocalVarsAgree(((VarDeclStmt)nxt).Locals, oth.Locals));
            }
            else if (nxt is BlockStmt)
            {
                var b = (BlockStmt)nxt;
                if (MutateCSharp.Schemata462.ReplaceBinExprOp_52(1082L, b.Labels, null))
                {
                    var oth = other as BlockStmt;
                    if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(1085L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_31(1083L, oth, null), () => MutateCSharp.Schemata462.ReplaceBinExprOp_52(1084L, oth.Labels, null)))
                    {
                        return MutateCSharp.Schemata462.ReplaceBinExprOp_12(1091L, b.Labels.Data.Name, oth.Labels.Data.Name); // both have the same label
                    }
                }
                else if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(1093L, () => other is BlockStmt, () => MutateCSharp.Schemata462.ReplaceBinExprOp_54(1092L, ((BlockStmt)other).Labels, null)))
                {
                    return MutateCSharp.Schemata462.ReplaceBooleanConstant_3(1099L, true); // both are unlabeled
                }
            }
            else if (nxt is UpdateStmt)
            {
                var up = (UpdateStmt)nxt;
                if (other is AssignSuchThatStmt)
                {
                    var oth = other as AssignSuchThatStmt;
                    return MutateCSharp.Schemata462.ReplaceBinExprOp_6(1101L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_55(1100L, oth, null), () => LeftHandSidesAgree(oth.Lhss, up.Lhss));
                }
            }

            // not a potential match
            return MutateCSharp.Schemata462.ReplaceBooleanConstant_3(1107L, false);
        }

        WhileStmt MergeWhileStmt(WhileStmt cNew, WhileStmt cOld, Expression guard)
        {
            Contract.Requires(cNew != null);
            Contract.Requires(cOld != null);

            // Note, the parser produces errors if there are any decreases or modifies clauses (and it creates
            // the Specification structures with a null list).
            Contract.Assume(cNew.Mod.Expressions == null);

            Specification<Expression> decr;
            if (MutateCSharp.Schemata462.ReplaceBinExprOp_30(1112L, cNew.Decreases.Expressions.Count, MutateCSharp.Schemata462.ReplaceNumericConstant_14(1108L, 0)))
            {
                // inherited whatever the previous loop used
                decr = refinementCloner.CloneSpecExpr(cOld.Decreases);
            }
            else
            {
                if (!Contract.Exists(cOld.Decreases.Expressions, e => e is WildcardExpr))
                {
                    // If the previous loop was not specified with "decreases *", then the new loop is not allowed to provide any "decreases" clause.
                    Error(ErrorId.ref_mismatched_loop_decreases, cNew.Decreases.Expressions[MutateCSharp.Schemata462.ReplaceNumericConstant_14(1117L, 0)].tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(1121L, "a refining loop can provide a decreases clause only if the loop being refined was declared with 'decreases *'"));
                }
                decr = cNew.Decreases;
            }

            var invs = cOld.Invariants.ConvertAll(refinementCloner.CloneAttributedExpr);
            invs.AddRange(cNew.Invariants);
            BlockStmt newBody;
            if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(1124L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_23(1122L, cOld.Body, null), () => MutateCSharp.Schemata462.ReplaceBinExprOp_23(1123L, cNew.Body, null)))
            {
                newBody = null;
            }
            else if (MutateCSharp.Schemata462.ReplaceBinExprOp_23(1130L, cOld.Body, null))
            {
                newBody = MergeBlockStmt(cNew.Body, new BlockStmt(cOld.RangeToken, new List<Statement>()));
            }
            else if (MutateCSharp.Schemata462.ReplaceBinExprOp_23(1131L, cNew.Body, null))
            {
                Error(ErrorId.ref_mismatched_while_body, cNew.Tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(1132L, "while template must have a body if the inherited while statement does"));
                newBody = null;
            }
            else
            {
                newBody = MergeBlockStmt(cNew.Body, cOld.Body);
            }
            return new RefinedWhileStmt(cNew.RangeToken, guard, invs, decr, refinementCloner.CloneSpecFrameExpr(cOld.Mod), newBody);
        }

        Statement MergeElse(Statement skeleton, Statement oldStmt)
        {
            Contract.Requires(skeleton == null || skeleton is BlockStmt || skeleton is IfStmt || skeleton is SkeletonStatement);
            Contract.Requires(oldStmt == null || oldStmt is BlockStmt || oldStmt is IfStmt || oldStmt is SkeletonStatement);

            if (MutateCSharp.Schemata462.ReplaceBinExprOp_35(1133L, skeleton, null))
            {
                return refinementCloner.CloneStmt(oldStmt, MutateCSharp.Schemata462.ReplaceBooleanConstant_3(1134L, false));
            }
            else if (MutateCSharp.Schemata462.ReplaceBinExprOp_2(1135L, () => skeleton is IfStmt, () => skeleton is SkeletonStatement))
            {
                // wrap a block statement around the if statement
                skeleton = new BlockStmt(skeleton.RangeToken, new List<Statement>() { skeleton });
            }

            if (MutateCSharp.Schemata462.ReplaceBinExprOp_35(1141L, oldStmt, null))
            {
                // make it into an empty block statement
                oldStmt = new BlockStmt(skeleton.RangeToken, new List<Statement>());
            }
            else if (MutateCSharp.Schemata462.ReplaceBinExprOp_2(1142L, () => oldStmt is IfStmt, () => oldStmt is SkeletonStatement))
            {
                // wrap a block statement around the if statement
                oldStmt = new BlockStmt(skeleton.RangeToken, new List<Statement>() { oldStmt });
            }

            Contract.Assert(skeleton is BlockStmt && oldStmt is BlockStmt);
            return MergeBlockStmt((BlockStmt)skeleton, (BlockStmt)oldStmt);
        }

        /// <summary>
        /// Add "s" to "stmtList", but complain if "s" contains further occurrences of "...", if "s" assigns to a
        /// variable that was not declared in the refining module, or if "s" has some control flow that jumps to a
        /// place outside "s".
        /// </summary>
        void MergeAddStatement(Statement s, List<Statement> stmtList)
        {
            Contract.Requires(s != null);
            Contract.Requires(stmtList != null);
            var prevErrorCount = Reporter.Count(ErrorLevel.Error);
            CheckIsOkayNewStatement(s, new Stack<string>(), MutateCSharp.Schemata462.ReplaceNumericConstant_14(1148L, 0));
            if (MutateCSharp.Schemata462.ReplaceBinExprOp_30(1152L, Reporter.Count(ErrorLevel.Error), prevErrorCount))
            {
                stmtList.Add(s);
            }
        }

        /// <summary>
        /// See comment on MergeAddStatement.
        /// </summary>
        void CheckIsOkayNewStatement(Statement s, Stack<string> labels, int loopLevels)
        {
            Contract.Requires(s != null);
            Contract.Requires(labels != null);
            Contract.Requires(0 <= loopLevels);

            for (LList<Label> n = s.Labels; MutateCSharp.Schemata462.ReplaceBinExprOp_52(1157L, n, null); n = n.Next)
            {
                labels.Push(n.Data.Name);
            }
            if (s is SkeletonStatement)
            {
                Error(ErrorId.ref_misplaced_skeleton, s, MutateCSharp.Schemata462.ReplaceStringConstant_7(1158L, "skeleton statement may not be used here; it does not have a matching statement in what is being replaced"));
            }
            else if (s is ReturnStmt)
            {
                // allow return statements, but make note of that this requires verifying the postcondition
                ((ReturnStmt)s).ReverifyPost = MutateCSharp.Schemata462.ReplaceBooleanConstant_3(1159L, true);
            }
            else if (s is YieldStmt)
            {
                Error(ErrorId.ref_misplaced_yield, s, MutateCSharp.Schemata462.ReplaceStringConstant_7(1160L, "yield statements are not allowed in skeletons"));
            }
            else if (s is BreakStmt)
            {
                var b = (BreakStmt)s;
                if (MutateCSharp.Schemata462.ReplaceBinExprOp_56(1161L, b.TargetLabel, null) ? !labels.Contains(b.TargetLabel.val) : MutateCSharp.Schemata462.ReplaceBinExprOp_24(1162L, loopLevels, b.BreakAndContinueCount))
                {
                    Error(ErrorId.ref_invalid_break_in_skeleton, s, $"{b.Kind} statement in skeleton is not allowed to break outside the skeleton fragment");
                }
            }
            else if (s is AssignStmt)
            {
                // TODO: To be a refinement automatically (that is, without any further verification), only variables and fields defined
                // in this module are allowed.  This needs to be checked.  If the LHS refers to an l-value that was not declared within
                // this module, then either an error should be reported or the Translator needs to know to translate new proof obligations.
                var a = (AssignStmt)s;
                Error(ErrorId.ref_misplaced_assignment, a.Tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(1167L, "cannot have assignment statement"));
            }
            else if (s is ConcreteUpdateStatement)
            {
                postTasks.Enqueue(() =>
                {
                    CheckIsOkayUpdateStmt((ConcreteUpdateStatement)s, moduleUnderConstruction);
                });
            }
            else if (s is CallStmt)
            {
                Error(ErrorId.ref_misplaced_call, s.Tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(1168L, "cannot have call statement"));
            }
            else
            {
                if (MutateCSharp.Schemata462.ReplaceBinExprOp_2(1169L, () => s is WhileStmt, () => s is AlternativeLoopStmt))
                {
                    MutateCSharp.Schemata462.ReplacePostfixUnaryExprOp_25(1175L, ref loopLevels);
                }
                foreach (var ss in s.SubStatements)
                {
                    CheckIsOkayNewStatement(ss, labels, loopLevels);
                }
            }

            for (LList<Label> n = s.Labels; MutateCSharp.Schemata462.ReplaceBinExprOp_52(1176L, n, null); n = n.Next)
            {
                labels.Pop();
            }
        }

        // Checks that statement stmt, defined in the constructed module m, is a refinement of skip in the parent module
        void CheckIsOkayUpdateStmt(ConcreteUpdateStatement stmt, ModuleDefinition m)
        {
            foreach (var lhs in stmt.Lhss)
            {
                var l = lhs.Resolved;
                if (l is IdentifierExpr)
                {
                    var ident = (IdentifierExpr)l;
                    Contract.Assert(ident.Var is LocalVariable || ident.Var is Formal); // LHS identifier expressions must be locals or out parameters (ie. formals)
                    if (MutateCSharp.Schemata462.ReplaceBinExprOp_2(1183L, () => (MutateCSharp.Schemata462.ReplaceBinExprOp_6(1177L, () => ident.Var is LocalVariable, () => RefinementToken.IsInherited(((LocalVariable)ident.Var).Tok, m))), () => ident.Var is Formal))
                    {
                        // for some reason, formals are not considered to be inherited.
                        Error(ErrorId.ref_invalid_variable_assignment, l.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(1189L, "refinement method cannot assign to variable defined in parent module ('{0}')"), ident.Var.Name);
                    }
                }
                else if (l is MemberSelectExpr)
                {
                    var member = ((MemberSelectExpr)l).Member;
                    if (RefinementToken.IsInherited(member.tok, m))
                    {
                        Error(ErrorId.ref_invalid_field_assignment, l.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(1190L, "refinement method cannot assign to a field defined in parent module ('{0}')"), member.Name);
                    }
                }
                else
                {
                    // must be an array element
                    Error(ErrorId.ref_invalid_new_assignments, l.tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(1191L, "new assignments in a refinement method can only assign to state that the module defines (which never includes array elements)"));
                }
            }
            if (stmt is UpdateStmt)
            {
                var s = (UpdateStmt)stmt;
                foreach (var rhs in s.Rhss)
                {
                    if (rhs.CanAffectPreviouslyKnownExpressions)
                    {
                        Error(ErrorId.ref_invalid_assignment_rhs, rhs.Tok, MutateCSharp.Schemata462.ReplaceStringConstant_7(1192L, "assignment RHS in refinement method is not allowed to affect previously defined state"));
                    }
                }
            }
        }
        // ---------------------- additional methods -----------------------------------------------------------------------------

        public static bool ContainsChange(Expression expr, ModuleDefinition m)
        {
            Contract.Requires(expr != null);
            Contract.Requires(m != null);

            if (expr is FunctionCallExpr)
            {
                var e = (FunctionCallExpr)expr;
                if (MutateCSharp.Schemata462.ReplaceBinExprOp_5(1193L, e.Function.EnclosingClass.EnclosingModuleDefinition, m))
                {
                    var p = e.Function as Predicate;
                    if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(1196L, () => MutateCSharp.Schemata462.ReplaceBinExprOp_57(1194L, p, null), () => MutateCSharp.Schemata462.ReplaceBinExprOp_58(1195L, p.BodyOrigin, Predicate.BodyOriginKind.Extension)))
                    {
                        return MutateCSharp.Schemata462.ReplaceBooleanConstant_3(1202L, true);
                    }
                }
            }

            foreach (var ee in expr.SubExpressions)
            {
                if (ContainsChange(ee, m))
                {
                    return MutateCSharp.Schemata462.ReplaceBooleanConstant_3(1203L, true);
                }
            }
            return MutateCSharp.Schemata462.ReplaceBooleanConstant_3(1204L, false);
        }
    }

    public
      class RefinementCloner : Cloner
    {
        readonly ModuleDefinition moduleUnderConstruction;
        private bool wrapWithRefinementToken = MutateCSharp.Schemata462.ReplaceBooleanConstant_3(1205L, true);

        public RefinementCloner(ModuleDefinition m) : base(MutateCSharp.Schemata462.ReplaceBooleanConstant_3(1206L, false), MutateCSharp.Schemata462.ReplaceBooleanConstant_3(1207L, false))
        {
            moduleUnderConstruction = m;
        }

        public override BlockStmt CloneMethodBody(Method m)
        {
            if (m.Body is DividedBlockStmt)
            {
                return CloneDividedBlockStmt((DividedBlockStmt)m.Body);
            }
            else
            {
                return CloneBlockStmt(m.Body);
            }

            return default;
        }

        [Pure]
        public T WithRefinementTokenWrapping<T>(Func<T> action, bool wrap = false)
        {
            var current = wrapWithRefinementToken;
            wrapWithRefinementToken = wrap;
            var result = action();
            wrapWithRefinementToken = current;
            return result;
        }

        public override IToken Tok(IToken tok)
        {
            if (wrapWithRefinementToken)
            {
                return new RefinementToken(tok, moduleUnderConstruction);
            }

            return tok;
        }
        public override TopLevelDecl CloneDeclaration(TopLevelDecl d, ModuleDefinition newParent)
        {
            var dd = base.CloneDeclaration(d, newParent);
            if (dd is ModuleExportDecl ddex)
            {
                // In refinement cloning, a default export set from the parent should, in the
                // refining module, retain its name but not be default, unless the refining module has the same name
                ModuleExportDecl dex = d as ModuleExportDecl;
                if (MutateCSharp.Schemata462.ReplaceBinExprOp_6(1209L, () => dex.IsDefault, () => MutateCSharp.Schemata462.ReplaceBinExprOp_29(1208L, d.Name, newParent.Name)))
                {
                    ddex = new ModuleExportDecl(ddex.Options, dex.RangeToken, d.NameNode, newParent, dex.Exports, dex.Extends,
                      dex.ProvideAll, dex.RevealAll, MutateCSharp.Schemata462.ReplaceBooleanConstant_3(1215L, false), MutateCSharp.Schemata462.ReplaceBooleanConstant_3(1216L, true), Guid.NewGuid());
                }
                ddex.SetupDefaultSignature();
                dd = ddex;
            }
            else if (d is ModuleDecl)
            {
                ((ModuleDecl)dd).Signature = ((ModuleDecl)d).Signature;
                if (d is AbstractModuleDecl)
                {
                    ((AbstractModuleDecl)dd).OriginalSignature = ((AbstractModuleDecl)d).OriginalSignature;
                }
            }
            return dd;
        }
        public virtual Attributes MergeAttributes(Attributes prevAttrs, Attributes moreAttrs)
        {
            if (MutateCSharp.Schemata462.ReplaceBinExprOp_59(1217L, moreAttrs, null))
            {
                return CloneAttributes(prevAttrs);
            }
            else if (moreAttrs is UserSuppliedAttributes)
            {
                var usa = (UserSuppliedAttributes)moreAttrs;
                return new UserSuppliedAttributes(Tok(usa.tok), Tok(usa.OpenBrace), Tok(usa.CloseBrace), moreAttrs.Args.ConvertAll(CloneExpr), MergeAttributes(prevAttrs, moreAttrs.Prev));
            }
            else
            {
                return new Attributes(moreAttrs.Name, moreAttrs.Args.ConvertAll(CloneExpr), MergeAttributes(prevAttrs, moreAttrs.Prev));
            }

            return default;
        }
    }
}
