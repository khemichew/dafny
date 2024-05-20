//-----------------------------------------------------------------------------
//
// Copyright (C) Microsoft Corporation.  All Rights Reserved.
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

using System;
using System.IO;
using System.Collections.Generic;
using System.CommandLine;
using System.Diagnostics.Contracts;
using System.Numerics;
using System.Linq;
using DafnyCore;
using JetBrains.Annotations;
using Bpl = Microsoft.Boogie;
namespace MutateCSharp
{
    internal class Schemata91
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT91");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.MatchExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_25(long mutantId, Microsoft.Dafny.UnaryOpExpr.Opcode argument1, Microsoft.Dafny.UnaryOpExpr.Opcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_23(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
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

        internal static int ReplaceNumericConstant_5(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
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

        internal static int ReplacePrefixUnaryExprOp_19(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return +argument1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return ~argument1; }
            return -argument1;
        }

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static int ReplacePostfixUnaryExprOp_9(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.BoundVar argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, System.Numerics.BigInteger argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 >= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 >= argument2;
        }

        internal static bool ReplaceBinExprOp_30(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_26(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 & argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.CasePattern<Microsoft.Dafny.BoundVar> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBinExprOp_29(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_28(long mutantId, Microsoft.Dafny.BinaryExpr.Opcode argument1, Microsoft.Dafny.BinaryExpr.Opcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_27(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Type> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_7(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_24(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Boogie.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 >= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 > argument2; }
            return argument1 >= argument2;
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

        internal static bool ReplaceBinExprOp_22(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Type> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, Microsoft.Dafny.PrintModes argument1, Microsoft.Dafny.PrintModes argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{

    public partial class Printer
    {

        /// <summary>
        /// PrintExtendedExpr prints an expression, but formats top-level if-then-else and match expressions across several lines.
        /// Its intended use is thus to print the body of a function.
        /// </summary>
        public void PrintExtendedExpr(Expression expr, int indent, bool isRightmost, bool endWithCloseParen)
        {
            Contract.Requires(expr != null);
            if (expr is ITEExpr)
            {
                Indent(indent);
                while (MutateCSharp.Schemata91.ReplaceBooleanConstant_0(1L, true))
                {
                    var ite = (ITEExpr)expr;
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(2L, "if "));
                    PrintExpression(ite.Test, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(3L, false));
                    wr.WriteLine(MutateCSharp.Schemata91.ReplaceStringConstant_1(4L, " then"));
                    PrintExtendedExpr(ite.Thn, MutateCSharp.Schemata91.ReplaceBinExprOp_2(5L, indent, IndentAmount), MutateCSharp.Schemata91.ReplaceBooleanConstant_0(14L, true), MutateCSharp.Schemata91.ReplaceBooleanConstant_0(15L, false));
                    expr = ite.Els;
                    if (expr is ITEExpr)
                    {
                        Indent(indent); wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(16L, "else "));
                    }
                    else
                    {
                        Indent(indent); wr.WriteLine(MutateCSharp.Schemata91.ReplaceStringConstant_1(17L, "else"));
                        Indent(MutateCSharp.Schemata91.ReplaceBinExprOp_2(18L, indent, IndentAmount));
                        PrintExpression(expr, isRightmost, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(27L, false));
                        wr.WriteLine(endWithCloseParen ? MutateCSharp.Schemata91.ReplaceStringConstant_1(28L, ")") : "");
                        return;
                    }
                }

            }
            else if (expr is NestedMatchExpr)
            {
                var e = (NestedMatchExpr)expr;
                if (MutateCSharp.Schemata91.ReplaceBinExprOp_4(30L, () => MutateCSharp.Schemata91.ReplaceBinExprOp_3(29L, e.Flattened, null), () => options.DafnyPrintResolvedFile != null))
                {
                    wr.WriteLine();
                    if (!printingDesugared)
                    {
                        Indent(indent); wr.WriteLine(MutateCSharp.Schemata91.ReplaceStringConstant_1(36L, "/*---------- flattened ----------"));
                    }

                    var savedDesugarMode = printingDesugared;
                    printingDesugared = MutateCSharp.Schemata91.ReplaceBooleanConstant_0(37L, true);
                    PrintExtendedExpr(e.Flattened, indent, isRightmost, endWithCloseParen);
                    printingDesugared = savedDesugarMode;

                    if (!printingDesugared)
                    {
                        Indent(indent); wr.WriteLine(MutateCSharp.Schemata91.ReplaceStringConstant_1(38L, "---------- end flattened ----------*/"));
                    }
                }
                if (!printingDesugared)
                {
                    Indent(indent);
                    var parensNeeded = MutateCSharp.Schemata91.ReplaceBinExprOp_4(39L, () => !isRightmost, () => !e.UsesOptionalBraces);
                    if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(45L, "(")); }
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(46L, "match "));
                    PrintExpression(e.Source, MutateCSharp.Schemata91.ReplaceBinExprOp_4(56L, () => isRightmost, () => MutateCSharp.Schemata91.ReplaceBinExprOp_6(51L, e.Cases.Count, MutateCSharp.Schemata91.ReplaceNumericConstant_5(47L, 0))), MutateCSharp.Schemata91.ReplaceBooleanConstant_0(62L, false));
                    if (e.UsesOptionalBraces)
                    {
                        wr.WriteLine(MutateCSharp.Schemata91.ReplaceStringConstant_1(63L, " {"));
                    }
                    else if (MutateCSharp.Schemata91.ReplaceBinExprOp_4(73L, () => parensNeeded, () => MutateCSharp.Schemata91.ReplaceBinExprOp_6(68L, e.Cases.Count, MutateCSharp.Schemata91.ReplaceNumericConstant_5(64L, 0))))
                    {
                        wr.WriteLine(MutateCSharp.Schemata91.ReplaceStringConstant_1(79L, ")"));
                    }
                    else
                    {
                        wr.WriteLine();
                    }
                    int i = MutateCSharp.Schemata91.ReplaceNumericConstant_5(80L, 0);
                    int ind = MutateCSharp.Schemata91.ReplaceBinExprOp_2(88L, indent, (e.UsesOptionalBraces ? IndentAmount : MutateCSharp.Schemata91.ReplaceNumericConstant_5(84L, 0)));
                    foreach (var mc in e.Cases)
                    {
                        bool isLastCase = MutateCSharp.Schemata91.ReplaceBinExprOp_6(110L, i, MutateCSharp.Schemata91.ReplaceBinExprOp_7(101L, e.Cases.Count, MutateCSharp.Schemata91.ReplaceNumericConstant_5(97L, 1)));
                        Indent(ind);
                        wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(115L, "case"));
                        PrintAttributes(mc.Attributes);
                        wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(116L, " "));
                        PrintExtendedPattern(mc.Pat);
                        wr.WriteLine(MutateCSharp.Schemata91.ReplaceStringConstant_1(117L, " =>"));
                        PrintExtendedExpr(mc.Body, MutateCSharp.Schemata91.ReplaceBinExprOp_2(118L, ind, IndentAmount), isLastCase, MutateCSharp.Schemata91.ReplaceBinExprOp_4(133L, () => isLastCase, () => (MutateCSharp.Schemata91.ReplaceBinExprOp_8(127L, () => parensNeeded, () => endWithCloseParen))));
                        MutateCSharp.Schemata91.ReplacePostfixUnaryExprOp_9(139L, ref i);
                    }
                    if (e.UsesOptionalBraces)
                    {
                        Indent(indent);
                        wr.WriteLine(MutateCSharp.Schemata91.ReplaceStringConstant_1(140L, "}"));
                    }
                }
            }
            else if (expr is MatchExpr)
            {
                var e = (MatchExpr)expr;
                if (MutateCSharp.Schemata91.ReplaceBinExprOp_4(142L, () => options.DafnyPrintResolvedFile == null, () => MutateCSharp.Schemata91.ReplaceBinExprOp_10(141L, e.OrigUnresolved, null)))
                {
                    PrintExtendedExpr(e.OrigUnresolved, indent, isRightmost, endWithCloseParen);
                }
                else
                {
                    Indent(indent);
                    var parensNeeded = MutateCSharp.Schemata91.ReplaceBinExprOp_4(148L, () => !isRightmost, () => !e.UsesOptionalBraces);
                    if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(154L, "(")); }
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(155L, "match "));
                    PrintExpression(e.Source, MutateCSharp.Schemata91.ReplaceBinExprOp_4(165L, () => isRightmost, () => MutateCSharp.Schemata91.ReplaceBinExprOp_6(160L, e.Cases.Count, MutateCSharp.Schemata91.ReplaceNumericConstant_5(156L, 0))), MutateCSharp.Schemata91.ReplaceBooleanConstant_0(171L, false));
                    if (e.UsesOptionalBraces) { wr.WriteLine(MutateCSharp.Schemata91.ReplaceStringConstant_1(172L, " {")); } else if (MutateCSharp.Schemata91.ReplaceBinExprOp_4(182L, () => parensNeeded, () => MutateCSharp.Schemata91.ReplaceBinExprOp_6(177L, e.Cases.Count, MutateCSharp.Schemata91.ReplaceNumericConstant_5(173L, 0)))) { wr.WriteLine(MutateCSharp.Schemata91.ReplaceStringConstant_1(188L, ")")); } else { wr.WriteLine(); }
                    int i = MutateCSharp.Schemata91.ReplaceNumericConstant_5(189L, 0);
                    int ind = MutateCSharp.Schemata91.ReplaceBinExprOp_2(197L, indent, (e.UsesOptionalBraces ? IndentAmount : MutateCSharp.Schemata91.ReplaceNumericConstant_5(193L, 0)));
                    foreach (var mc in e.Cases)
                    {
                        bool isLastCase = MutateCSharp.Schemata91.ReplaceBinExprOp_6(219L, i, MutateCSharp.Schemata91.ReplaceBinExprOp_7(210L, e.Cases.Count, MutateCSharp.Schemata91.ReplaceNumericConstant_5(206L, 1)));
                        Indent(ind);
                        wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(224L, "case"));
                        PrintAttributes(mc.Attributes);
                        wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(225L, " "));
                        wr.Write(mc.Ctor.Name);
                        PrintMatchCaseArgument(mc);
                        wr.WriteLine(MutateCSharp.Schemata91.ReplaceStringConstant_1(226L, " =>"));
                        PrintExtendedExpr(mc.Body, MutateCSharp.Schemata91.ReplaceBinExprOp_2(227L, ind, IndentAmount), isLastCase, MutateCSharp.Schemata91.ReplaceBinExprOp_4(242L, () => isLastCase, () => (MutateCSharp.Schemata91.ReplaceBinExprOp_8(236L, () => parensNeeded, () => endWithCloseParen))));
                        MutateCSharp.Schemata91.ReplacePostfixUnaryExprOp_9(248L, ref i);
                    }
                    if (e.UsesOptionalBraces)
                    {
                        Indent(indent);
                        wr.WriteLine(MutateCSharp.Schemata91.ReplaceStringConstant_1(249L, "}"));
                    }
                }

            }
            else if (expr is LetExpr)
            {
                var e = (LetExpr)expr;
                Indent(indent);
                if (e.tok is AutoGeneratedToken)
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(250L, "/* "));
                }
                if (e.LHSs.Exists(lhs => MutateCSharp.Schemata91.ReplaceBinExprOp_4(259L, () => MutateCSharp.Schemata91.ReplaceBinExprOp_4(253L, () => MutateCSharp.Schemata91.ReplaceBinExprOp_11(251L, lhs, null), () => MutateCSharp.Schemata91.ReplaceBinExprOp_12(252L, lhs.Var, null)), () => lhs.Var.IsGhost))) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(265L, "ghost ")); }
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(266L, "var "));
                string sep = "";
                foreach (var lhs in e.LHSs)
                {
                    wr.Write(sep);
                    PrintCasePattern(lhs);
                    sep = MutateCSharp.Schemata91.ReplaceStringConstant_1(267L, ", ");
                }
                if (e.Exact)
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(268L, " := "));
                }
                else
                {
                    PrintAttributes(e.Attributes);
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(269L, " :| "));
                }
                PrintExpressionList(e.RHSs, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(270L, true));
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(271L, ";"));
                if (e.tok is AutoGeneratedToken)
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(272L, " */"));
                }
                wr.WriteLine();
                PrintExtendedExpr(e.Body, indent, isRightmost, endWithCloseParen);
            }
            else if (MutateCSharp.Schemata91.ReplaceBinExprOp_4(273L, () => expr is StmtExpr, () => isRightmost))
            {
                var e = (StmtExpr)expr;
                Indent(indent);
                PrintStatement(e.S, indent);
                wr.WriteLine();
                PrintExtendedExpr(e.E, indent, isRightmost, endWithCloseParen);

            }
            else if (expr is ParensExpression)
            {
                PrintExtendedExpr(((ParensExpression)expr).E, indent, isRightmost, endWithCloseParen);
            }
            else
            {
                Indent(indent);
                PrintExpression(expr, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(279L, false), indent);
                wr.WriteLine(endWithCloseParen ? MutateCSharp.Schemata91.ReplaceStringConstant_1(280L, ")") : "");
            }
        }

        public void PrintMatchCaseArgument(MatchCase mc)
        {
            Contract.Assert(mc.Arguments != null);
            if (MutateCSharp.Schemata91.ReplaceBinExprOp_13(285L, mc.Arguments.Count, MutateCSharp.Schemata91.ReplaceNumericConstant_5(281L, 0)))
            {
                string sep = MutateCSharp.Schemata91.ReplaceStringConstant_1(290L, "(");
                foreach (BoundVar bv in mc.Arguments)
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(291L, "{0}{1}"), sep, bv.DisplayName);
                    string typeName = bv.Type.TypeName(options, null, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(292L, true));
                    if (MutateCSharp.Schemata91.ReplaceBinExprOp_4(294L, () => bv.Type is NonProxyType, () => !typeName.StartsWith(MutateCSharp.Schemata91.ReplaceStringConstant_1(293L, "_"))))
                    {
                        wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(300L, ": {0}"), typeName);
                    }
                    sep = MutateCSharp.Schemata91.ReplaceStringConstant_1(301L, ", ");
                }
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(302L, ")"));
            }
        }

        public void PrintExpression(Expression expr, bool isFollowedBySemicolon)
        {
            Contract.Requires(expr != null);
            PrintExpr(expr, MutateCSharp.Schemata91.ReplaceNumericConstant_5(303L, 0), MutateCSharp.Schemata91.ReplaceBooleanConstant_0(307L, false), MutateCSharp.Schemata91.ReplaceBooleanConstant_0(308L, true), isFollowedBySemicolon, MutateCSharp.Schemata91.ReplaceNumericConstant_5(309L, -1));
        }

        public void PrintExpression(Expression expr, bool isRightmost, bool isFollowedBySemicolon)
        {
            Contract.Requires(expr != null);
            PrintExpr(expr, MutateCSharp.Schemata91.ReplaceNumericConstant_5(313L, 0), MutateCSharp.Schemata91.ReplaceBooleanConstant_0(317L, false), isRightmost, isFollowedBySemicolon, MutateCSharp.Schemata91.ReplaceNumericConstant_5(318L, -1));
        }

        /// <summary>
        /// An indent of -1 means print the entire expression on one line.
        /// </summary>
        public void PrintExpression(Expression expr, bool isFollowedBySemicolon, int indent)
        {
            Contract.Requires(expr != null);
            PrintExpr(expr, MutateCSharp.Schemata91.ReplaceNumericConstant_5(322L, 0), MutateCSharp.Schemata91.ReplaceBooleanConstant_0(326L, false), MutateCSharp.Schemata91.ReplaceBooleanConstant_0(327L, true), isFollowedBySemicolon, indent);
        }

        public void PrintExpression(Expression expr, bool isFollowedBySemicolon, string keyword)
        {
            Contract.Requires(expr != null);
            PrintExpr(expr, MutateCSharp.Schemata91.ReplaceNumericConstant_5(328L, 0), MutateCSharp.Schemata91.ReplaceBooleanConstant_0(332L, false), MutateCSharp.Schemata91.ReplaceBooleanConstant_0(333L, true), isFollowedBySemicolon, MutateCSharp.Schemata91.ReplaceNumericConstant_5(334L, -1), keyword);
        }

        private bool ParensNeeded(int opBindingStrength, int contextBindingStrength, bool fragileContext)
        {
            return MutateCSharp.Schemata91.ReplaceBinExprOp_8(354L, () => MutateCSharp.Schemata91.ReplaceBinExprOp_14(338L, opBindingStrength, contextBindingStrength), () => (MutateCSharp.Schemata91.ReplaceBinExprOp_4(348L, () => fragileContext, () => MutateCSharp.Schemata91.ReplaceBinExprOp_6(343L, opBindingStrength, contextBindingStrength))));
        }


        bool ParensMayMatter(Expression expr)
        {
            Contract.Requires(expr != null);
            int parenPairs = MutateCSharp.Schemata91.ReplaceNumericConstant_5(360L, 0);
            for (; expr is ParensExpression; MutateCSharp.Schemata91.ReplacePostfixUnaryExprOp_9(364L, ref parenPairs))
            {
                expr = ((ParensExpression)expr).E;
            }
            // If the program were resolved, we could be more precise than the following (in particular, looking
            // to see if expr denotes a MemberSelectExpr of a member that is a Function.
            return MutateCSharp.Schemata91.ReplaceBinExprOp_4(380L, () => MutateCSharp.Schemata91.ReplaceBinExprOp_13(369L, parenPairs, MutateCSharp.Schemata91.ReplaceNumericConstant_5(365L, 0)), () => (MutateCSharp.Schemata91.ReplaceBinExprOp_8(374L, () => expr is NameSegment, () => expr is ExprDotName)));
        }

        void PrintCasePattern<VT>(CasePattern<VT> pat)
          where VT : class, IVariable
        {
            Contract.Requires(pat != null);
            var v = pat.Var;
            if (v != null)
            {
                wr.Write(v.DisplayName);
                if (MutateCSharp.Schemata91.ReplaceBinExprOp_8(386L, () => v.OptionalType is NonProxyType, () => options.DafnyPrintResolvedFile != null))
                {
                    PrintType(MutateCSharp.Schemata91.ReplaceStringConstant_1(392L, ": "), v.OptionalType);
                }
            }
            else
            {
                if (pat.Id.StartsWith(SystemModuleManager.TupleTypeCtorNamePrefix))
                {
                    Contract.Assert(pat.Arguments != null);
                }
                else
                {
                    wr.Write(pat.Id);
                }
                if (pat.Arguments != null)
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(393L, "("));
                    var sep = "";
                    foreach (var arg in pat.Arguments)
                    {
                        wr.Write(sep);
                        PrintCasePattern(arg);
                        sep = MutateCSharp.Schemata91.ReplaceStringConstant_1(394L, ", ");
                    }
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(395L, ")"));
                }
            }
        }

        // Main difference with .ToString is that tuple constructors are not printed.
        void PrintExtendedPattern(ExtendedPattern pat)
        {
            Contract.Requires(pat != null);
            switch (pat)
            {
                case IdPattern idPat:
                    if (idPat.Id.StartsWith(SystemModuleManager.TupleTypeCtorNamePrefix))
                    {
                    }
                    else if (idPat.IsWildcardPattern)
                    {
                        // In case of the universal match pattern, print '_' instead of
                        // its node identifier, otherwise the printed program becomes
                        // syntactically incorrect.
                        wr.Write("_");
                        if (!idPat.IsWildcardExact)
                        {
                            wr.Write($" /* {idPat.Id} */");
                        }
                    }
                    else
                    {
                        wr.Write(idPat.Id);
                    }
                    if (idPat.Arguments != null)
                    {
                        wr.Write("(");
                        var sep = "";
                        foreach (var arg in idPat.Arguments)
                        {
                            wr.Write(sep);
                            PrintExtendedPattern(arg);
                            sep = ", ";
                        }
                        wr.Write(")");
                    }
                    else if (options.DafnyPrintResolvedFile != null && idPat.ResolvedLit != null)
                    {
                        Contract.Assert(idPat.BoundVar == null && idPat.Ctor == null);
                        wr.Write(" /*== ");
                        PrintExpression(idPat.ResolvedLit, false);
                        wr.Write("*/");
                    }
                    else if (ShowType(idPat.Type))
                    {
                        wr.Write(": ");
                        PrintType(idPat.Type);
                    }
                    break;
                    break;
                case DisjunctivePattern dPat:
                    var patSep = "";
                    foreach (var arg in dPat.Alternatives)
                    {
                        wr.Write(patSep);
                        PrintExtendedPattern(arg);
                        patSep = " | ";
                    }
                    break;
                    break;
                case LitPattern litPat:
                    wr.Write(litPat.ToString());
                    break;
                    break;
            }
        }

        private void PrintQuantifierDomain(List<BoundVar> boundVars, Attributes attrs, Expression range)
        {
            Contract.Requires(boundVars != null);
            string sep = "";
            foreach (BoundVar bv in boundVars)
            {
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(396L, "{0}"), sep);
                if (printFlags.UseOriginalDafnyNames)
                {
                    wr.Write(bv.DafnyName);
                }
                else
                {
                    wr.Write(bv.DisplayName);
                }

                PrintType(MutateCSharp.Schemata91.ReplaceStringConstant_1(397L, ": "), bv.Type);
                sep = MutateCSharp.Schemata91.ReplaceStringConstant_1(398L, ", ");
            }
            PrintAttributes(attrs);
            if (MutateCSharp.Schemata91.ReplaceBinExprOp_3(399L, range, null))
            {
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(400L, " | "));
                PrintExpression(range, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(401L, false));
            }
        }

        void PrintActualArguments(ActualBindings bindings, string/*?*/ name, Bpl.IToken/*?*/ atLabel)
        {
            Contract.Requires(bindings != null);
            var i = MutateCSharp.Schemata91.ReplaceNumericConstant_5(402L, 0);
            if (MutateCSharp.Schemata91.ReplaceBinExprOp_4(407L, () => name != null, () => name.EndsWith(MutateCSharp.Schemata91.ReplaceStringConstant_1(406L, "#"))))
            {
                Contract.Assert(atLabel == null);
                Contract.Assert(1 <= bindings.ArgumentBindings.Count);
                Contract.Assert(bindings.ArgumentBindings[0].FormalParameterName == null);
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(413L, "["));
                PrintExpression(bindings.ArgumentBindings[MutateCSharp.Schemata91.ReplaceNumericConstant_5(414L, 0)].Actual, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(418L, false));
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(419L, "]"));
                MutateCSharp.Schemata91.ReplacePostfixUnaryExprOp_9(420L, ref i);
            }
            else if (MutateCSharp.Schemata91.ReplaceBinExprOp_15(421L, atLabel, null))
            {
                wr.Write($"@{atLabel.val}");
            }
            wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(422L, "("));
            string sep = "";
            if (MutateCSharp.Schemata91.ReplaceBinExprOp_8(423L, () => options.DafnyPrintResolvedFile == null, () => !bindings.WasResolved))
            {
                for (; MutateCSharp.Schemata91.ReplaceBinExprOp_14(429L, i, bindings.ArgumentBindings.Count); MutateCSharp.Schemata91.ReplacePostfixUnaryExprOp_9(434L, ref i))
                {
                    var binding = bindings.ArgumentBindings[i];
                    wr.Write(sep);
                    sep = MutateCSharp.Schemata91.ReplaceStringConstant_1(435L, ", ");
                    if (binding.IsGhost)
                    {
                        wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(436L, "ghost "));
                    }
                    if (MutateCSharp.Schemata91.ReplaceBinExprOp_16(437L, binding.FormalParameterName, null))
                    {
                        wr.Write($"{binding.FormalParameterName.val} := ");
                    }
                    PrintExpression(binding.Actual, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(438L, false));
                }
            }
            else
            {
                // print arguments after incorporating default parameters
                for (; MutateCSharp.Schemata91.ReplaceBinExprOp_14(439L, i, bindings.Arguments.Count); MutateCSharp.Schemata91.ReplacePostfixUnaryExprOp_9(444L, ref i))
                {
                    var arg = bindings.Arguments[i];
                    if (arg is DefaultValueExpression { Resolved: null })
                    {
                        // An error was detected during resolution, so this argument was not filled in. Omit printing it.
                        continue;
                    }
                    wr.Write(sep);
                    sep = MutateCSharp.Schemata91.ReplaceStringConstant_1(445L, ", ");
                    PrintExpression(arg, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(446L, false));
                }
            }
            wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(447L, ")"));
        }

        void PrintBindings(ActualBindings bindings, bool isFollowedBySemicolon)
        {
            Contract.Requires(bindings != null);
            string sep = "";
            foreach (var binding in bindings.ArgumentBindings)
            {
                wr.Write(sep);
                sep = MutateCSharp.Schemata91.ReplaceStringConstant_1(448L, ", ");
                if (MutateCSharp.Schemata91.ReplaceBinExprOp_16(449L, binding.FormalParameterName, null))
                {
                    wr.Write($"{binding.FormalParameterName.val} := ");
                }
                PrintExpression(binding.Actual, isFollowedBySemicolon);
            }
        }

        void PrintExpressionList(List<Expression> exprs, bool isFollowedBySemicolon)
        {
            Contract.Requires(exprs != null);
            string sep = "";
            foreach (Expression e in exprs)
            {
                Contract.Assert(e != null);
                wr.Write(sep);
                sep = MutateCSharp.Schemata91.ReplaceStringConstant_1(450L, ", ");
                PrintExpression(e, isFollowedBySemicolon);
            }
        }
        void PrintExpressionPairList(List<ExpressionPair> exprs)
        {
            Contract.Requires(exprs != null);
            string sep = "";
            foreach (ExpressionPair p in exprs)
            {
                Contract.Assert(p != null);
                wr.Write(sep);
                sep = MutateCSharp.Schemata91.ReplaceStringConstant_1(451L, ", ");
                PrintExpression(p.A, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(452L, false));
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(453L, " := "));
                PrintExpression(p.B, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(454L, false));
            }
        }

        void PrintFrameExpressionList(List<FrameExpression/*!*/>/*!*/ fexprs)
        {
            Contract.Requires(fexprs != null);
            string sep = "";
            foreach (FrameExpression fe in fexprs)
            {
                Contract.Assert(fe != null);
                wr.Write(sep);
                sep = MutateCSharp.Schemata91.ReplaceStringConstant_1(455L, ", ");
                if (fe.E is ImplicitThisExpr)
                {
                    Contract.Assert(fe.FieldName != null);
                }
                else
                {
                    PrintExpression(fe.E, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(456L, true));
                }
                if (fe.FieldName != null)
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(457L, "`{0}"), fe.FieldName);
                }
            }
        }

        /// <summary>
        /// An indent of -1 means print the entire expression on one line.
        /// </summary>
        void PrintExpr(Expression expr, int contextBindingStrength, bool fragileContext, bool isRightmost, bool isFollowedBySemicolon, int indent, string keyword = null, int resolv_count = 2)
        {
            Contract.Requires(-1 <= indent);
            Contract.Requires(expr != null);

            /* When debugging:
            if (resolv_count > 0 && expr.Resolved != null) {
              PrintExpr(expr.Resolved, contextBindingStrength, fragileContext, isRightmost, isFollowedBySemicolon, indent, resolv_count - 1);
              return;
            }
            */

            if (expr is StaticReceiverExpr)
            {
                StaticReceiverExpr e = (StaticReceiverExpr)expr;
                wr.Write(e.Type);
            }
            else if (expr is LiteralExpr)
            {
                LiteralExpr e = (LiteralExpr)expr;
                if (e.Value == null)
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(458L, "null"));
                }
                else if (e.Value is bool)
                {
                    wr.Write((bool)e.Value ? MutateCSharp.Schemata91.ReplaceStringConstant_1(459L, "true") : MutateCSharp.Schemata91.ReplaceStringConstant_1(460L, "false"));
                }
                else if (e is CharLiteralExpr)
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(461L, "'{0}'"), (string)e.Value);
                }
                else if (e is StringLiteralExpr)
                {
                    var str = (StringLiteralExpr)e;
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(462L, "{0}\"{1}\""), str.IsVerbatim ? MutateCSharp.Schemata91.ReplaceStringConstant_1(463L, "@") : "", (string)e.Value);
                }
                else if (e.Value is BaseTypes.BigDec)
                {
                    BaseTypes.BigDec dec = (BaseTypes.BigDec)e.Value;
                    wr.Write((MutateCSharp.Schemata91.ReplaceBinExprOp_17(468L, dec.Mantissa, MutateCSharp.Schemata91.ReplaceNumericConstant_5(464L, 0))) ? "" : MutateCSharp.Schemata91.ReplaceStringConstant_1(470L, "-"));
                    string s = BigInteger.Abs(dec.Mantissa).ToString();
                    int digits = s.Length;
                    if (MutateCSharp.Schemata91.ReplaceBinExprOp_18(475L, dec.Exponent, MutateCSharp.Schemata91.ReplaceNumericConstant_5(471L, 0)))
                    {
                        wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(480L, "{0}{1}.0"), s, new string('0', dec.Exponent));
                    }
                    else
                    {
                        int exp = MutateCSharp.Schemata91.ReplacePrefixUnaryExprOp_19(481L, dec.Exponent);
                        if (MutateCSharp.Schemata91.ReplaceBinExprOp_14(483L, exp, digits))
                        {
                            int intDigits = MutateCSharp.Schemata91.ReplaceBinExprOp_7(488L, digits, exp);
                            int fracDigits = MutateCSharp.Schemata91.ReplaceBinExprOp_7(497L, digits, intDigits);
                            wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(506L, "{0}.{1}"), s.Substring(MutateCSharp.Schemata91.ReplaceNumericConstant_5(507L, 0), intDigits), s.Substring(intDigits, fracDigits));
                        }
                        else
                        {
                            int fracDigits = digits;
                            wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(511L, "0.{0}{1}"), new string('0', MutateCSharp.Schemata91.ReplaceBinExprOp_7(512L, exp, fracDigits)), s.Substring(MutateCSharp.Schemata91.ReplaceNumericConstant_5(521L, 0), fracDigits));
                        }
                    }
                }
                else
                {
                    wr.Write((BigInteger)e.Value);
                }

            }
            else if (expr is ThisExpr)
            {
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(525L, "this"));

            }
            else if (expr is IdentifierExpr)
            {
                var e = (IdentifierExpr)expr;
                if (printFlags.UseOriginalDafnyNames)
                {
                    wr.Write(e.DafnyName);
                }
                else
                {
                    wr.Write(e.Name);
                }

            }
            else if (expr is DatatypeValue)
            {
                var dtv = (DatatypeValue)expr;
                bool printParens;
                if (dtv.MemberName.StartsWith(SystemModuleManager.TupleTypeCtorNamePrefix))
                {
                    // we're looking at a tuple, whose printed constructor name is essentially the empty string
                    printParens = MutateCSharp.Schemata91.ReplaceBooleanConstant_0(526L, true);
                }
                else
                {
                    var typeArgs = "";
                    if (MutateCSharp.Schemata91.ReplaceBinExprOp_4(537L, () => MutateCSharp.Schemata91.ReplaceBinExprOp_20(527L, dtv.InferredTypeArgs, null), () => MutateCSharp.Schemata91.ReplaceBinExprOp_13(532L, dtv.InferredTypeArgs.Count, MutateCSharp.Schemata91.ReplaceNumericConstant_5(528L, 0))))
                    {
                        typeArgs = $"<{string.Join(MutateCSharp.Schemata91.ReplaceStringConstant_1(543L, ","), dtv.InferredTypeArgs.ConvertAll(ty => ty.ToString()))}>";
                    }
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(544L, "{0}{1}.{2}"), dtv.DatatypeName, typeArgs, dtv.MemberName);
                    printParens = MutateCSharp.Schemata91.ReplaceBinExprOp_13(549L, dtv.Arguments.Count, MutateCSharp.Schemata91.ReplaceNumericConstant_5(545L, 0));
                }
                if (printParens)
                {
                    PrintActualArguments(dtv.Bindings, null, null);
                }

            }
            else if (expr is DisplayExpression)
            {
                DisplayExpression e = (DisplayExpression)expr;
                if (e is MultiSetDisplayExpr)
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(554L, "multiset"));
                }
                else if (MutateCSharp.Schemata91.ReplaceBinExprOp_4(555L, () => e is SetDisplayExpr, () => !((SetDisplayExpr)e).Finite))
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(561L, "iset"));
                }
                wr.Write(MutateCSharp.Schemata91.ReplaceBinExprOp_8(562L, () => e is SetDisplayExpr, () => e is MultiSetDisplayExpr) ? MutateCSharp.Schemata91.ReplaceStringConstant_1(568L, "{") : MutateCSharp.Schemata91.ReplaceStringConstant_1(569L, "["));
                PrintExpressionList(e.Elements, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(570L, false));
                wr.Write(MutateCSharp.Schemata91.ReplaceBinExprOp_8(571L, () => e is SetDisplayExpr, () => e is MultiSetDisplayExpr) ? MutateCSharp.Schemata91.ReplaceStringConstant_1(577L, "}") : MutateCSharp.Schemata91.ReplaceStringConstant_1(578L, "]"));

            }
            else if (expr is MapDisplayExpr)
            {
                MapDisplayExpr e = (MapDisplayExpr)expr;
                wr.Write(e.Finite ? MutateCSharp.Schemata91.ReplaceStringConstant_1(579L, "map") : MutateCSharp.Schemata91.ReplaceStringConstant_1(580L, "imap"));
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(581L, "["));
                PrintExpressionPairList(e.Elements);
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(582L, "]"));

            }
            else if (expr is NameSegment)
            {
                var e = (NameSegment)expr;
                wr.Write(e.Name);
                if (MutateCSharp.Schemata91.ReplaceBinExprOp_20(583L, e.OptTypeArguments, null))
                {
                    PrintTypeInstantiation(e.OptTypeArguments);
                }

            }
            else if (expr is ExprDotName)
            {
                var e = (ExprDotName)expr;
                // determine if parens are needed
                int opBindingStrength = MutateCSharp.Schemata91.ReplaceNumericConstant_5(584L, 0x90);
                bool parensNeeded = MutateCSharp.Schemata91.ReplaceBinExprOp_4(588L, () => !e.Lhs.IsImplicit, () => ParensNeeded(opBindingStrength, contextBindingStrength, fragileContext));
                Contract.Assert(!parensNeeded); // KRML: I think parens are never needed

                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(594L, "(")); }
                if (!e.Lhs.IsImplicit)
                {
                    PrintExpr(e.Lhs, opBindingStrength, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(595L, false), MutateCSharp.Schemata91.ReplaceBooleanConstant_0(596L, false), MutateCSharp.Schemata91.ReplaceBinExprOp_4(597L, () => !parensNeeded, () => isFollowedBySemicolon), MutateCSharp.Schemata91.ReplaceNumericConstant_5(603L, -1), keyword);
                    if (e.Lhs.Type is Resolver_IdentifierExpr.ResolverType_Type)
                    {
                        Contract.Assert(e.Lhs is NameSegment || e.Lhs is ExprDotName);  // these are the only expressions whose .Type can be ResolverType_Type
                        if (MutateCSharp.Schemata91.ReplaceBinExprOp_4(608L, () => options.DafnyPrintResolvedFile != null, () => MutateCSharp.Schemata91.ReplaceBinExprOp_21(607L, options.PrintMode, PrintModes.Everything)))
                        {
                            // The printing of e.Lhs printed the type arguments only if they were given explicitly in the input.
                            var optionalTypeArgs = e.Lhs is NameSegment ns ? ns.OptTypeArguments : ((ExprDotName)e.Lhs).OptTypeArguments;
                            if (MutateCSharp.Schemata91.ReplaceBinExprOp_22(614L, optionalTypeArgs, null) && e.Lhs.Resolved is Resolver_IdentifierExpr ri)
                            {
                                PrintTypeInstantiation(ri.TypeArgs);
                            }
                        }
                    }
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(615L, "."));
                }
                wr.Write(e.SuffixName);
                PrintTypeInstantiation(e.OptTypeArguments);
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(616L, ")")); }

            }
            else if (expr is ApplySuffix)
            {
                var e = (ApplySuffix)expr;
                // determine if parens are needed
                int opBindingStrength = MutateCSharp.Schemata91.ReplaceNumericConstant_5(617L, 0x90);
                bool parensNeeded = MutateCSharp.Schemata91.ReplaceBinExprOp_4(621L, () => !e.Lhs.IsImplicit, () => ParensNeeded(opBindingStrength, contextBindingStrength, fragileContext));
                Contract.Assert(!parensNeeded); // KRML: I think parens are never needed

                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(627L, "(")); }
                if (ParensMayMatter(e.Lhs))
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(628L, "("));
                    PrintExpression(e.Lhs, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(629L, false));
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(630L, ")"));
                }
                else
                {
                    PrintExpr(e.Lhs, opBindingStrength, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(631L, false), MutateCSharp.Schemata91.ReplaceBooleanConstant_0(632L, false), MutateCSharp.Schemata91.ReplaceBinExprOp_4(633L, () => !parensNeeded, () => isFollowedBySemicolon), MutateCSharp.Schemata91.ReplaceNumericConstant_5(639L, -1), keyword);
                }
                string name = e.Lhs is NameSegment ? ((NameSegment)e.Lhs).Name : e.Lhs is ExprDotName ? ((ExprDotName)e.Lhs).SuffixName : null;
                PrintActualArguments(e.Bindings, name, e.AtTok);
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(643L, ")")); }

            }
            else if (expr is MemberSelectExpr)
            {
                MemberSelectExpr e = (MemberSelectExpr)expr;
                // determine if parens are needed
                int opBindingStrength = MutateCSharp.Schemata91.ReplaceNumericConstant_5(644L, 0x90);
                bool parensNeeded = MutateCSharp.Schemata91.ReplaceBinExprOp_4(648L, () => !e.Obj.IsImplicit, () => ParensNeeded(opBindingStrength, contextBindingStrength, fragileContext));

                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(654L, "(")); }
                if (!(e.Obj.IsImplicit))
                {
                    PrintExpr(e.Obj, opBindingStrength, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(655L, false), MutateCSharp.Schemata91.ReplaceBooleanConstant_0(656L, false), MutateCSharp.Schemata91.ReplaceBinExprOp_4(657L, () => !parensNeeded, () => isFollowedBySemicolon), MutateCSharp.Schemata91.ReplaceNumericConstant_5(663L, -1), keyword);
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(667L, "."));
                }
                wr.Write(e.MemberName);
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(668L, ")")); }

            }
            else if (expr is SeqSelectExpr)
            {
                SeqSelectExpr e = (SeqSelectExpr)expr;
                // determine if parens are needed
                int opBindingStrength = MutateCSharp.Schemata91.ReplaceNumericConstant_5(669L, 0x90);
                bool parensNeeded = ParensNeeded(opBindingStrength, contextBindingStrength, fragileContext);

                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(673L, "(")); }
                PrintExpr(e.Seq, opBindingStrength, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(674L, false), MutateCSharp.Schemata91.ReplaceBooleanConstant_0(675L, false), MutateCSharp.Schemata91.ReplaceBinExprOp_4(676L, () => !parensNeeded, () => isFollowedBySemicolon), indent, keyword);
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(682L, "["));
                if (e.SelectOne)
                {
                    Contract.Assert(e.E0 != null);
                    PrintExpression(e.E0, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(683L, false));
                }
                else
                {
                    if (MutateCSharp.Schemata91.ReplaceBinExprOp_3(684L, e.E0, null))
                    {
                        PrintExpression(e.E0, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(685L, false));
                    }
                    wr.Write(MutateCSharp.Schemata91.ReplaceBinExprOp_4(688L, () => MutateCSharp.Schemata91.ReplaceBinExprOp_3(686L, e.E0, null), () => MutateCSharp.Schemata91.ReplaceBinExprOp_3(687L, e.E1, null)) ? MutateCSharp.Schemata91.ReplaceStringConstant_1(694L, " .. ") : MutateCSharp.Schemata91.ReplaceStringConstant_1(695L, ".."));
                    if (MutateCSharp.Schemata91.ReplaceBinExprOp_3(696L, e.E1, null))
                    {
                        PrintExpression(e.E1, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(697L, false));
                    }
                }
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(698L, "]"));
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(699L, ")")); }

            }
            else if (expr is MultiSelectExpr)
            {
                MultiSelectExpr e = (MultiSelectExpr)expr;
                // determine if parens are needed
                int opBindingStrength = MutateCSharp.Schemata91.ReplaceNumericConstant_5(700L, 0x90);
                bool parensNeeded = ParensNeeded(opBindingStrength, contextBindingStrength, fragileContext);

                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(704L, "(")); }
                PrintExpr(e.Array, opBindingStrength, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(705L, false), MutateCSharp.Schemata91.ReplaceBooleanConstant_0(706L, false), MutateCSharp.Schemata91.ReplaceBinExprOp_4(707L, () => !parensNeeded, () => isFollowedBySemicolon), indent, keyword);
                string prefix = MutateCSharp.Schemata91.ReplaceStringConstant_1(713L, "[");
                foreach (Expression idx in e.Indices)
                {
                    Contract.Assert(idx != null);
                    wr.Write(prefix);
                    PrintExpression(idx, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(714L, false));
                    prefix = MutateCSharp.Schemata91.ReplaceStringConstant_1(715L, ", ");
                }
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(716L, "]"));
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(717L, ")")); }

            }
            else if (expr is SeqUpdateExpr)
            {
                SeqUpdateExpr e = (SeqUpdateExpr)expr;
                // determine if parens are needed
                int opBindingStrength = MutateCSharp.Schemata91.ReplaceNumericConstant_5(718L, 0x90);
                bool parensNeeded = ParensNeeded(opBindingStrength, contextBindingStrength, fragileContext);

                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(722L, "(")); }
                PrintExpr(e.Seq, opBindingStrength, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(723L, false), MutateCSharp.Schemata91.ReplaceBooleanConstant_0(724L, false), MutateCSharp.Schemata91.ReplaceBinExprOp_4(725L, () => !parensNeeded, () => isFollowedBySemicolon), indent, keyword);
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(731L, "["));
                PrintExpression(e.Index, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(732L, false));
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(733L, " := "));
                PrintExpression(e.Value, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(734L, false));
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(735L, "]"));
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(736L, ")")); }
            }
            else if (expr is DatatypeUpdateExpr)
            {
                var e = (DatatypeUpdateExpr)expr;
                // determine if parens are needed
                int opBindingStrength = MutateCSharp.Schemata91.ReplaceNumericConstant_5(737L, 0x90);
                bool parensNeeded = ParensNeeded(opBindingStrength, contextBindingStrength, fragileContext);

                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(741L, "(")); }
                PrintExpr(e.Root, opBindingStrength, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(742L, false), MutateCSharp.Schemata91.ReplaceBooleanConstant_0(743L, false), MutateCSharp.Schemata91.ReplaceBinExprOp_4(744L, () => !parensNeeded, () => isFollowedBySemicolon), indent, keyword);
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(750L, ".("));
                var sep = "";
                foreach (var update in e.Updates)
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(751L, "{0}{1} := "), sep, update.Item2);
                    PrintExpression(update.Item3, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(752L, false));
                    sep = MutateCSharp.Schemata91.ReplaceStringConstant_1(753L, ", ");
                }
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(754L, ")"));
                if (MutateCSharp.Schemata91.ReplaceBinExprOp_4(756L, () => options.DafnyPrintResolvedFile != null, () => MutateCSharp.Schemata91.ReplaceBinExprOp_21(755L, options.PrintMode, PrintModes.Everything)))
                {
                    if (MutateCSharp.Schemata91.ReplaceBinExprOp_3(762L, e.ResolvedExpression, null))
                    {
                        wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(763L, "/*"));
                        PrintExpression(e.ResolvedExpression, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(764L, false));
                        wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(765L, "*/"));
                    }
                }
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(766L, ")")); }

            }
            else if (expr is ApplyExpr)
            {
                var e = (ApplyExpr)expr;
                // determine if parens are needed
                int opBindingStrength = MutateCSharp.Schemata91.ReplaceNumericConstant_5(767L, 0x90);
                bool parensNeeded = ParensNeeded(opBindingStrength, contextBindingStrength, fragileContext);

                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(771L, "(")); }

                PrintExpr(e.Function, opBindingStrength, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(772L, false), MutateCSharp.Schemata91.ReplaceBooleanConstant_0(773L, false), MutateCSharp.Schemata91.ReplaceBinExprOp_4(774L, () => !parensNeeded, () => isFollowedBySemicolon), MutateCSharp.Schemata91.ReplaceNumericConstant_5(780L, -1), keyword);
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(784L, "("));
                PrintExpressionList(e.Args, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(785L, false));
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(786L, ")"));

                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(787L, ")")); }

            }
            else if (expr is FunctionCallExpr)
            {
                var e = (FunctionCallExpr)expr;
                // determine if parens are needed
                int opBindingStrength = MutateCSharp.Schemata91.ReplaceNumericConstant_5(788L, 0x90);
                bool parensNeeded = MutateCSharp.Schemata91.ReplaceBinExprOp_4(792L, () => !(e.Receiver.IsImplicit), () => ParensNeeded(opBindingStrength, contextBindingStrength, fragileContext));

                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(798L, "(")); }
                if (!e.Receiver.IsImplicit)
                {
                    PrintExpr(e.Receiver, opBindingStrength, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(799L, false), MutateCSharp.Schemata91.ReplaceBooleanConstant_0(800L, false), MutateCSharp.Schemata91.ReplaceBinExprOp_4(801L, () => !parensNeeded, () => isFollowedBySemicolon), MutateCSharp.Schemata91.ReplaceNumericConstant_5(807L, -1), keyword);
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(811L, "."));
                }
                wr.Write(e.Name);
                /* When debugging, this is nice to have:
                if (e.TypeArgumentSubstitutions.Count > 0) {
                  wr.Write("[");
                  wr.Write(Util.Comma(",", e.TypeArgumentSubstitutions, kv => kv.Key.FullName() + "->" + kv.Value));
                  wr.Write("]");
                }
                */
                if (MutateCSharp.Schemata91.ReplaceBinExprOp_4(822L, () => MutateCSharp.Schemata91.ReplaceBinExprOp_23(812L, e.OpenParen, null), () => MutateCSharp.Schemata91.ReplaceBinExprOp_6(817L, e.Args.Count, MutateCSharp.Schemata91.ReplaceNumericConstant_5(813L, 0))))
                {
                }
                else
                {
                    PrintActualArguments(e.Bindings, e.Name, null);
                }
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(828L, ")")); }

            }
            else if (expr is SeqConstructionExpr)
            {
                var e = (SeqConstructionExpr)expr;
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(829L, "seq"));
                if (MutateCSharp.Schemata91.ReplaceBinExprOp_24(830L, e.ExplicitElementType, null))
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(831L, "<{0}>"), e.ExplicitElementType);
                }
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(832L, "("));
                PrintExpression(e.N, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(833L, false));
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(834L, ", "));
                PrintExpression(e.Initializer, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(835L, false));
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(836L, ")"));

            }
            else if (expr is MultiSetFormingExpr)
            {
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(837L, "multiset("));
                PrintExpression(((MultiSetFormingExpr)expr).E, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(838L, false));
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(839L, ")"));

            }
            else if (expr is OldExpr)
            {
                var e = (OldExpr)expr;
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(840L, "old"));
                if (e.At != null)
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(841L, "@{0}"), e.At);
                }
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(842L, "("));
                PrintExpression(e.E, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(843L, false));
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(844L, ")"));

            }
            else if (expr is UnchangedExpr)
            {
                var e = (UnchangedExpr)expr;
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(845L, "unchanged"));
                if (e.At != null)
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(846L, "@{0}"), e.At);
                }
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(847L, "("));
                PrintFrameExpressionList(e.Frame);
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(848L, ")"));

            }
            else if (expr is FreshExpr)
            {
                var e = (FreshExpr)expr;
                var label = e.At;
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(849L, "fresh{0}("), label == null ? "" : MutateCSharp.Schemata91.ReplaceStringConstant_1(850L, "@") + label);
                PrintExpression(e.E, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(851L, false));
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(852L, ")"));

            }
            else if (expr is UnaryOpExpr)
            {
                var e = (UnaryOpExpr)expr;
                if (MutateCSharp.Schemata91.ReplaceBinExprOp_25(853L, e.Op, UnaryOpExpr.Opcode.Cardinality))
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(854L, "|"));
                    PrintExpression(e.E, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(855L, false));
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(856L, "|"));
                }
                else if (MutateCSharp.Schemata91.ReplaceBinExprOp_25(857L, e.Op, UnaryOpExpr.Opcode.Allocated))
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(858L, "allocated("));
                    PrintExpression(e.E, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(859L, false));
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(860L, ")"));
                }
                else if (MutateCSharp.Schemata91.ReplaceBinExprOp_25(861L, e.Op, UnaryOpExpr.Opcode.Lit))
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(862L, "Lit("));
                    PrintExpression(e.E, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(863L, false));
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(864L, ")"));
                }
                else
                {
                    Contract.Assert(e.Op != UnaryOpExpr.Opcode.Fresh); // this is handled is "is FreshExpr" case above
                                                                       // Prefix operator.
                                                                       // determine if parens are needed
                    string op;
                    int opBindingStrength;
                    switch (e.Op)
                    {
                        case UnaryOpExpr.Opcode.Not:
                            op = "!"; opBindingStrength = 0x80; break;
                            break;
                        default:
                            Contract.Assert(false); throw new cce.UnreachableException();  // unexpected unary opcode
                            break;
                    }
                    bool parensNeeded = ParensNeeded(opBindingStrength, contextBindingStrength, fragileContext);

                    if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(865L, "(")); }
                    wr.Write(op);
                    PrintExpr(e.E, opBindingStrength, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(866L, false), MutateCSharp.Schemata91.ReplaceBinExprOp_8(867L, () => parensNeeded, () => isRightmost), MutateCSharp.Schemata91.ReplaceBinExprOp_4(873L, () => !parensNeeded, () => isFollowedBySemicolon), MutateCSharp.Schemata91.ReplaceNumericConstant_5(879L, -1), keyword);
                    if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(883L, ")")); }
                }

            }
            else if (expr is TypeUnaryExpr)
            {
                var e = (TypeUnaryExpr)expr;
                int opBindingStrength = MutateCSharp.Schemata91.ReplaceNumericConstant_5(884L, 0x70);
                bool parensNeeded = ParensNeeded(opBindingStrength, contextBindingStrength, fragileContext);

                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(888L, "(")); }
                PrintExpr(e.E, opBindingStrength, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(889L, false), MutateCSharp.Schemata91.ReplaceBooleanConstant_0(890L, false), MutateCSharp.Schemata91.ReplaceBinExprOp_4(891L, () => !parensNeeded, () => isFollowedBySemicolon), MutateCSharp.Schemata91.ReplaceNumericConstant_5(897L, -1), keyword);
                Contract.Assert(e is ConversionExpr || e is TypeTestExpr);
                wr.Write(e is ConversionExpr ? MutateCSharp.Schemata91.ReplaceStringConstant_1(901L, " as ") : MutateCSharp.Schemata91.ReplaceStringConstant_1(902L, " is "));
                PrintType(e.ToType);
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(903L, ")")); }

            }
            else if (expr is BinaryExpr)
            {
                var e = (BinaryExpr)expr;
                // determine if parens are needed
                int opBindingStrength;
                bool fragileLeftContext = MutateCSharp.Schemata91.ReplaceBooleanConstant_0(904L, false);  // false means "allow same binding power on left without parens"
                bool fragileRightContext = MutateCSharp.Schemata91.ReplaceBooleanConstant_0(905L, false);  // false means "allow same binding power on right without parens"
                switch (e.Op)
                {
                    case BinaryExpr.Opcode.LeftShift:
                    case BinaryExpr.Opcode.RightShift:
                        opBindingStrength = 0x48; fragileRightContext = true; break;
                        break;
                    case BinaryExpr.Opcode.Add:
                        {
                            opBindingStrength = 0x40;
                            var t1 = e.E1.Type;
                            fragileRightContext = t1 == null || !(t1.IsIntegerType || t1.IsRealType || t1.IsBigOrdinalType || t1.IsBitVectorType);
                            break;
                        }

                        break;
                    case BinaryExpr.Opcode.Sub:
                        opBindingStrength = 0x40; fragileRightContext = true; break;
                        break;
                    case BinaryExpr.Opcode.Mul:
                        {
                            opBindingStrength = 0x50;
                            var t1 = e.E1.Type;
                            fragileRightContext = t1 == null || !(t1.IsIntegerType || t1.IsRealType || t1.IsBigOrdinalType || t1.IsBitVectorType);
                            break;
                        }

                        break;
                    case BinaryExpr.Opcode.Div:
                    case BinaryExpr.Opcode.Mod:
                        opBindingStrength = 0x50; fragileRightContext = true; break;
                        break;
                    case BinaryExpr.Opcode.BitwiseAnd:
                        opBindingStrength = 0x60; break;
                        break;
                    case BinaryExpr.Opcode.BitwiseOr:
                        opBindingStrength = 0x61; break;
                        break;
                    case BinaryExpr.Opcode.BitwiseXor:
                        opBindingStrength = 0x62; break;
                        break;
                    case BinaryExpr.Opcode.Eq:
                    case BinaryExpr.Opcode.Neq:
                    case BinaryExpr.Opcode.Gt:
                    case BinaryExpr.Opcode.Ge:
                    case BinaryExpr.Opcode.Lt:
                    case BinaryExpr.Opcode.Le:
                    case BinaryExpr.Opcode.Disjoint:
                    case BinaryExpr.Opcode.In:
                    case BinaryExpr.Opcode.NotIn:
                        opBindingStrength = 0x30; fragileLeftContext = fragileRightContext = true; break;
                        break;
                    case BinaryExpr.Opcode.And:
                        opBindingStrength = 0x20; break;
                        break;
                    case BinaryExpr.Opcode.Or:
                        opBindingStrength = 0x21; break;
                        break;
                    case BinaryExpr.Opcode.Imp:
                        opBindingStrength = 0x10; fragileLeftContext = true; break;
                        break;
                    case BinaryExpr.Opcode.Exp:
                        opBindingStrength = 0x11; fragileRightContext = true; break;
                        break;
                    case BinaryExpr.Opcode.Iff:
                        opBindingStrength = 0x08; break;
                        break;
                    default:
                        Contract.Assert(false); throw new cce.UnreachableException();  // unexpected binary operator
                        break;
                }
                int opBS = MutateCSharp.Schemata91.ReplaceBinExprOp_26(910L, opBindingStrength, MutateCSharp.Schemata91.ReplaceNumericConstant_5(906L, 0xF8));
                int ctxtBS = MutateCSharp.Schemata91.ReplaceBinExprOp_26(923L, contextBindingStrength, MutateCSharp.Schemata91.ReplaceNumericConstant_5(919L, 0xF8));
                bool parensNeeded = MutateCSharp.Schemata91.ReplaceBinExprOp_8(959L, () => MutateCSharp.Schemata91.ReplaceBinExprOp_14(932L, opBS, ctxtBS), () => (MutateCSharp.Schemata91.ReplaceBinExprOp_4(953L, () => MutateCSharp.Schemata91.ReplaceBinExprOp_6(937L, opBS, ctxtBS), () => (MutateCSharp.Schemata91.ReplaceBinExprOp_8(947L, () => MutateCSharp.Schemata91.ReplaceBinExprOp_13(942L, opBindingStrength, contextBindingStrength), () => fragileContext)))));

                string op = BinaryExpr.OpcodeString(e.Op);
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(965L, "(")); }
                var sem = MutateCSharp.Schemata91.ReplaceBinExprOp_4(966L, () => !parensNeeded, () => isFollowedBySemicolon);
                if (MutateCSharp.Schemata91.ReplaceBinExprOp_4(982L, () => MutateCSharp.Schemata91.ReplaceBinExprOp_27(976L, MutateCSharp.Schemata91.ReplaceNumericConstant_5(972L, 0), indent), () => MutateCSharp.Schemata91.ReplaceBinExprOp_28(981L, e.Op, BinaryExpr.Opcode.And)))
                {
                    PrintExpr(e.E0, opBindingStrength, fragileLeftContext, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(988L, false), sem, indent, keyword);
                    wr.WriteLine(MutateCSharp.Schemata91.ReplaceStringConstant_1(989L, " {0}"), op);
                    Indent(indent);
                    PrintExpr(e.E1, opBindingStrength, fragileRightContext, MutateCSharp.Schemata91.ReplaceBinExprOp_8(990L, () => parensNeeded, () => isRightmost), sem, indent, keyword);
                }
                else if (MutateCSharp.Schemata91.ReplaceBinExprOp_4(1006L, () => MutateCSharp.Schemata91.ReplaceBinExprOp_27(1000L, MutateCSharp.Schemata91.ReplaceNumericConstant_5(996L, 0), indent), () => MutateCSharp.Schemata91.ReplaceBinExprOp_28(1005L, e.Op, BinaryExpr.Opcode.Imp)))
                {
                    PrintExpr(e.E0, opBindingStrength, fragileLeftContext, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(1012L, false), sem, indent, keyword);
                    wr.WriteLine(MutateCSharp.Schemata91.ReplaceStringConstant_1(1013L, " {0}"), op);
                    int ind = MutateCSharp.Schemata91.ReplaceBinExprOp_2(1014L, indent, IndentAmount);
                    Indent(ind);
                    PrintExpr(e.E1, opBindingStrength, fragileRightContext, MutateCSharp.Schemata91.ReplaceBinExprOp_8(1023L, () => parensNeeded, () => isRightmost), sem, ind, keyword);
                }
                else if (MutateCSharp.Schemata91.ReplaceBinExprOp_4(1039L, () => MutateCSharp.Schemata91.ReplaceBinExprOp_27(1033L, MutateCSharp.Schemata91.ReplaceNumericConstant_5(1029L, 0), indent), () => MutateCSharp.Schemata91.ReplaceBinExprOp_28(1038L, e.Op, BinaryExpr.Opcode.Exp)))
                {
                    PrintExpr(e.E1, opBindingStrength, fragileLeftContext, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(1045L, false), sem, indent, keyword);
                    wr.WriteLine(MutateCSharp.Schemata91.ReplaceStringConstant_1(1046L, " {0}"), op);
                    int ind = MutateCSharp.Schemata91.ReplaceBinExprOp_2(1047L, indent, IndentAmount);
                    Indent(ind);
                    PrintExpr(e.E0, opBindingStrength, fragileRightContext, MutateCSharp.Schemata91.ReplaceBinExprOp_8(1056L, () => parensNeeded, () => isRightmost), sem, ind, keyword);
                }
                else if (MutateCSharp.Schemata91.ReplaceBinExprOp_28(1062L, e.Op, BinaryExpr.Opcode.Exp))
                {
                    PrintExpr(e.E1, opBindingStrength, fragileLeftContext, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(1063L, false), sem, MutateCSharp.Schemata91.ReplaceNumericConstant_5(1064L, -1), keyword);
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1068L, " {0} "), op);
                    PrintExpr(e.E0, opBindingStrength, fragileRightContext, MutateCSharp.Schemata91.ReplaceBinExprOp_8(1069L, () => parensNeeded, () => isRightmost), sem, MutateCSharp.Schemata91.ReplaceNumericConstant_5(1075L, -1), keyword);
                }
                else
                {
                    PrintExpr(e.E0, opBindingStrength, fragileLeftContext, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(1079L, false), sem, MutateCSharp.Schemata91.ReplaceNumericConstant_5(1080L, -1), keyword);
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1084L, " {0} "), op);
                    PrintExpr(e.E1, opBindingStrength, fragileRightContext, MutateCSharp.Schemata91.ReplaceBinExprOp_8(1085L, () => parensNeeded, () => isRightmost), sem, MutateCSharp.Schemata91.ReplaceNumericConstant_5(1091L, -1), keyword);
                }
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1095L, ")")); }

            }
            else if (expr is TernaryExpr)
            {
                var e = (TernaryExpr)expr;
                switch (e.Op)
                {
                    case TernaryExpr.Opcode.PrefixEqOp:
                    case TernaryExpr.Opcode.PrefixNeqOp:
                        var opBindingStrength = 0x30;
                        var fragileLeftContext = true;
                        var fragileRightContext = true;

                        int opBS = opBindingStrength & 0xF8;
                        int ctxtBS = contextBindingStrength & 0xF8;
                        bool parensNeeded = opBS < ctxtBS ||
                          (opBS == ctxtBS && (opBindingStrength != contextBindingStrength || fragileContext));

                        if (parensNeeded) { wr.Write("("); }
                        var sem = !parensNeeded && isFollowedBySemicolon;
                        PrintExpr(e.E1, opBindingStrength, fragileLeftContext, false, sem, -1, keyword);
                        wr.Write(" {0}#[", e.Op == TernaryExpr.Opcode.PrefixEqOp ? "==" : "!=");
                        PrintExpression(e.E0, false);
                        wr.Write("] ");
                        PrintExpr(e.E2, opBindingStrength, fragileRightContext, parensNeeded || isRightmost, sem, -1, keyword);
                        if (parensNeeded) { wr.Write(")"); }
                        break;
                        break;
                    default:
                        Contract.Assert(false);  // unexpected ternary operator
                        break;
                        break;
                }

            }
            else if (expr is ChainingExpression)
            {
                var e = (ChainingExpression)expr;
                // determine if parens are needed
                int opBindingStrength = MutateCSharp.Schemata91.ReplaceNumericConstant_5(1096L, 0x30);
                int opBS = MutateCSharp.Schemata91.ReplaceBinExprOp_26(1104L, opBindingStrength, MutateCSharp.Schemata91.ReplaceNumericConstant_5(1100L, 0xF8));
                int ctxtBS = MutateCSharp.Schemata91.ReplaceBinExprOp_26(1117L, contextBindingStrength, MutateCSharp.Schemata91.ReplaceNumericConstant_5(1113L, 0xF8));
                bool parensNeeded = MutateCSharp.Schemata91.ReplaceBinExprOp_8(1153L, () => MutateCSharp.Schemata91.ReplaceBinExprOp_14(1126L, opBS, ctxtBS), () => (MutateCSharp.Schemata91.ReplaceBinExprOp_4(1147L, () => MutateCSharp.Schemata91.ReplaceBinExprOp_6(1131L, opBS, ctxtBS), () => (MutateCSharp.Schemata91.ReplaceBinExprOp_8(1141L, () => MutateCSharp.Schemata91.ReplaceBinExprOp_13(1136L, opBindingStrength, contextBindingStrength), () => fragileContext)))));

                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1159L, "(")); }
                var sem = MutateCSharp.Schemata91.ReplaceBinExprOp_4(1160L, () => !parensNeeded, () => isFollowedBySemicolon);
                PrintExpr(e.Operands[MutateCSharp.Schemata91.ReplaceNumericConstant_5(1166L, 0)], opBindingStrength, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(1170L, true), MutateCSharp.Schemata91.ReplaceBooleanConstant_0(1171L, false), sem, MutateCSharp.Schemata91.ReplaceNumericConstant_5(1172L, -1), keyword);
                for (int i = MutateCSharp.Schemata91.ReplaceNumericConstant_5(1176L, 0); MutateCSharp.Schemata91.ReplaceBinExprOp_14(1180L, i, e.Operators.Count); MutateCSharp.Schemata91.ReplacePostfixUnaryExprOp_9(1185L, ref i))
                {
                    string op = BinaryExpr.OpcodeString(e.Operators[i]);
                    if (MutateCSharp.Schemata91.ReplaceBinExprOp_29(1186L, e.PrefixLimits[i], null))
                    {
                        wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1187L, " {0} "), op);
                    }
                    else
                    {
                        wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1188L, " {0}#["), op);
                        PrintExpression(e.PrefixLimits[i], MutateCSharp.Schemata91.ReplaceBooleanConstant_0(1189L, false));
                        wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1190L, "] "));
                    }
                    PrintExpr(e.Operands[MutateCSharp.Schemata91.ReplaceBinExprOp_2(1195L, i, MutateCSharp.Schemata91.ReplaceNumericConstant_5(1191L, 1))], opBindingStrength, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(1204L, true), MutateCSharp.Schemata91.ReplaceBinExprOp_4(1229L, () => MutateCSharp.Schemata91.ReplaceBinExprOp_6(1218L, i, MutateCSharp.Schemata91.ReplaceBinExprOp_7(1209L, e.Operators.Count, MutateCSharp.Schemata91.ReplaceNumericConstant_5(1205L, 1))), () => (MutateCSharp.Schemata91.ReplaceBinExprOp_8(1223L, () => parensNeeded, () => isRightmost))), sem, MutateCSharp.Schemata91.ReplaceNumericConstant_5(1235L, -1), keyword);
                }
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1239L, ")")); }

            }
            else if (expr is LetExpr)
            {
                var e = (LetExpr)expr;
                bool parensNeeded = !isRightmost;
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1240L, "(")); }
                if (e.tok is AutoGeneratedToken)
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1241L, "/* "));
                }
                if (e.LHSs.Exists(lhs => MutateCSharp.Schemata91.ReplaceBinExprOp_4(1250L, () => MutateCSharp.Schemata91.ReplaceBinExprOp_4(1244L, () => MutateCSharp.Schemata91.ReplaceBinExprOp_11(1242L, lhs, null), () => MutateCSharp.Schemata91.ReplaceBinExprOp_12(1243L, lhs.Var, null)), () => lhs.Var.IsGhost))) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1256L, "ghost ")); }
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1257L, "var "));
                string sep = "";
                foreach (var lhs in e.LHSs)
                {
                    wr.Write(sep);
                    PrintCasePattern(lhs);
                    sep = MutateCSharp.Schemata91.ReplaceStringConstant_1(1258L, ", ");
                }
                if (e.Exact)
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1259L, " := "));
                }
                else
                {
                    PrintAttributes(e.Attributes);
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1260L, " :| "));
                }
                PrintExpressionList(e.RHSs, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(1261L, true));
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1262L, "; "));
                if (e.tok is AutoGeneratedToken)
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1263L, "*/ "));
                }
                PrintExpression(e.Body, MutateCSharp.Schemata91.ReplaceBinExprOp_4(1264L, () => !parensNeeded, () => isFollowedBySemicolon));
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1270L, ")")); }

            }
            else if (expr is LetOrFailExpr)
            {
                // TODO should we also print the desugared version?
                // If so, should we insert newlines?
                var e = (LetOrFailExpr)expr;
                bool parensNeeded = !isRightmost;
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1271L, "(")); }
                if (MutateCSharp.Schemata91.ReplaceBinExprOp_11(1272L, e.Lhs, null))
                {
                    if (MutateCSharp.Schemata91.ReplaceBinExprOp_4(1274L, () => MutateCSharp.Schemata91.ReplaceBinExprOp_12(1273L, e.Lhs.Var, null), () => e.Lhs.Var.IsGhost)) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1280L, "ghost ")); }
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1281L, "var "));
                    PrintCasePattern(e.Lhs);
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1282L, " :- "));
                }
                else
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1283L, ":- "));
                }
                PrintExpression(e.Rhs, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(1284L, true));
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1285L, "; "));
                PrintExpression(e.Body, MutateCSharp.Schemata91.ReplaceBinExprOp_4(1286L, () => !parensNeeded, () => isFollowedBySemicolon));
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1292L, ")")); }

            }
            else if (expr is QuantifierExpr)
            {
                QuantifierExpr e = (QuantifierExpr)expr;

                if (MutateCSharp.Schemata91.ReplaceBinExprOp_30(1293L, e.SplitQuantifier, null))
                {
                    PrintExpr(e.SplitQuantifierExpression, contextBindingStrength, fragileContext, isRightmost, isFollowedBySemicolon, indent, keyword, resolv_count);
                    return;
                }

                bool parensNeeded = !isRightmost;
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1294L, "(")); }
                wr.Write(e is ForallExpr ? MutateCSharp.Schemata91.ReplaceStringConstant_1(1295L, "forall") : MutateCSharp.Schemata91.ReplaceStringConstant_1(1296L, "exists"));
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1297L, " "));
                PrintQuantifierDomain(e.BoundVars, e.Attributes, e.Range);
                if (keyword == null)
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1298L, " :: "));
                }
                else
                {
                    wr.WriteLine();
                    wr.Write(keyword);
                }
                if (MutateCSharp.Schemata91.ReplaceBinExprOp_27(1303L, MutateCSharp.Schemata91.ReplaceNumericConstant_5(1299L, 0), indent))
                {
                    int ind = MutateCSharp.Schemata91.ReplaceBinExprOp_2(1308L, indent, IndentAmount);
                    wr.WriteLine();
                    Indent(ind);
                    PrintExpression(e.Term, MutateCSharp.Schemata91.ReplaceBinExprOp_4(1317L, () => !parensNeeded, () => isFollowedBySemicolon), ind);
                }
                else
                {
                    PrintExpression(e.Term, MutateCSharp.Schemata91.ReplaceBinExprOp_4(1323L, () => !parensNeeded, () => isFollowedBySemicolon));
                }
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1329L, ")")); }

            }
            else if (expr is SetComprehension)
            {
                var e = (SetComprehension)expr;
                bool parensNeeded = !isRightmost;
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1330L, "(")); }
                if (e.Finite)
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1331L, "set "));
                }
                else
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1332L, "iset "));
                }
                string sep = "";
                foreach (BoundVar bv in e.BoundVars)
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1333L, "{0}{1}"), sep, bv.DisplayName);
                    sep = MutateCSharp.Schemata91.ReplaceStringConstant_1(1334L, ", ");
                    PrintType(MutateCSharp.Schemata91.ReplaceStringConstant_1(1335L, ": "), bv.Type);
                }
                PrintAttributes(e.Attributes);
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1336L, " | "));
                PrintExpression(e.Range, MutateCSharp.Schemata91.ReplaceBinExprOp_4(1337L, () => !parensNeeded, () => isFollowedBySemicolon));
                if (!e.TermIsImplicit)
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1343L, " :: "));
                    PrintExpression(e.Term, MutateCSharp.Schemata91.ReplaceBinExprOp_4(1344L, () => !parensNeeded, () => isFollowedBySemicolon));
                }
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1350L, ")")); }

            }
            else if (expr is MapComprehension)
            {
                var e = (MapComprehension)expr;
                bool parensNeeded = !isRightmost;
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1351L, "(")); }
                wr.Write(e.Finite ? MutateCSharp.Schemata91.ReplaceStringConstant_1(1352L, "map ") : MutateCSharp.Schemata91.ReplaceStringConstant_1(1353L, "imap "));
                string sep = "";
                foreach (BoundVar bv in e.BoundVars)
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1354L, "{0}{1}"), sep, bv.DisplayName);
                    sep = MutateCSharp.Schemata91.ReplaceStringConstant_1(1355L, ", ");
                    PrintType(MutateCSharp.Schemata91.ReplaceStringConstant_1(1356L, ": "), bv.Type);
                }
                PrintAttributes(e.Attributes);
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1357L, " | "));
                PrintExpression(e.Range, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(1358L, false));
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1359L, " :: "));
                if (MutateCSharp.Schemata91.ReplaceBinExprOp_3(1360L, e.TermLeft, null))
                {
                    PrintExpression(e.TermLeft, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(1361L, false));
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1362L, " := "));
                }
                PrintExpression(e.Term, MutateCSharp.Schemata91.ReplaceBinExprOp_4(1363L, () => !parensNeeded, () => isFollowedBySemicolon));
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1369L, ")")); }

            }
            else if (expr is LambdaExpr)
            {
                var e = (LambdaExpr)expr;
                bool parensNeeded = !isRightmost;
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1370L, "(")); }
                var skipSignatureParens = MutateCSharp.Schemata91.ReplaceBinExprOp_4(1384L, () => MutateCSharp.Schemata91.ReplaceBinExprOp_6(1375L, e.BoundVars.Count, MutateCSharp.Schemata91.ReplaceNumericConstant_5(1371L, 1)), () => !ShowType(e.BoundVars[MutateCSharp.Schemata91.ReplaceNumericConstant_5(1380L, 0)].Type));
                if (!skipSignatureParens) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1390L, "(")); }
                wr.Write(Util.Comma(e.BoundVars, bv => bv.DisplayName + (ShowType(bv.Type) ? MutateCSharp.Schemata91.ReplaceStringConstant_1(1391L, ": ") + bv.Type : "")));
                if (!skipSignatureParens) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1392L, ")")); }
                if (MutateCSharp.Schemata91.ReplaceBinExprOp_3(1393L, e.Range, null))
                {
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1394L, " requires "));
                    PrintExpression(e.Range, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(1395L, false));
                }
                var readsPrefix = MutateCSharp.Schemata91.ReplaceStringConstant_1(1396L, " reads ");
                PrintAttributes(e.Reads.Attributes);
                foreach (var read in e.Reads.Expressions)
                {
                    wr.Write(readsPrefix);
                    PrintExpression(read.E, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(1397L, false));
                    readsPrefix = MutateCSharp.Schemata91.ReplaceStringConstant_1(1398L, ", ");
                }
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1399L, " => "));
                PrintExpression(e.Term, isFollowedBySemicolon);
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1400L, ")")); }

            }
            else if (expr is WildcardExpr)
            {
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1401L, "*"));

            }
            else if (expr is StmtExpr)
            {
                var e = (StmtExpr)expr;
                bool parensNeeded;
                if (MutateCSharp.Schemata91.ReplaceBinExprOp_8(1414L, () => MutateCSharp.Schemata91.ReplaceBinExprOp_8(1408L, () => MutateCSharp.Schemata91.ReplaceBinExprOp_8(1402L, () => e.S is AssertStmt, () => e.S is ExpectStmt), () => e.S is AssumeStmt), () => e.S is CalcStmt))
                {
                    parensNeeded = !isRightmost;
                }
                else
                {
                    parensNeeded = MutateCSharp.Schemata91.ReplaceBinExprOp_8(1420L, () => !isRightmost, () => isFollowedBySemicolon);
                }
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1426L, "(")); }
                int ind = MutateCSharp.Schemata91.ReplaceBinExprOp_14(1431L, indent, MutateCSharp.Schemata91.ReplaceNumericConstant_5(1427L, 0)) ? IndentAmount : indent;  // if the expression was to be printed on one line, instead print the .S part at indentation IndentAmount (not pretty, but something)
                PrintStatement(e.S, ind);
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1436L, " "));
                PrintExpression(e.E, MutateCSharp.Schemata91.ReplaceBinExprOp_4(1437L, () => !parensNeeded, () => isFollowedBySemicolon));
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1443L, ")")); }

            }
            else if (expr is ITEExpr)
            {
                ITEExpr ite = (ITEExpr)expr;
                bool parensNeeded = !isRightmost;
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1444L, "(")); }
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1445L, "if "));
                PrintExpression(ite.Test, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(1446L, false));
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1447L, " then "));
                PrintExpression(ite.Thn, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(1448L, false));
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1449L, " else "));
                PrintExpression(ite.Els, MutateCSharp.Schemata91.ReplaceBinExprOp_4(1450L, () => !parensNeeded, () => isFollowedBySemicolon));
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1456L, ")")); }

            }
            else if (expr is ParensExpression)
            {
                var e = (ParensExpression)expr;
                // printing of parentheses is done optimally, not according to the parentheses in the given program
                PrintExpr(e.E, contextBindingStrength, fragileContext, isRightmost, isFollowedBySemicolon, indent, keyword);

            }
            else if (expr is NegationExpression)
            {
                var e = (NegationExpression)expr;
                string op = MutateCSharp.Schemata91.ReplaceStringConstant_1(1457L, "-");
                int opBindingStrength = MutateCSharp.Schemata91.ReplaceNumericConstant_5(1458L, 0x80);
                bool parensNeeded = ParensNeeded(opBindingStrength, contextBindingStrength, fragileContext);

                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1462L, "(")); }
                wr.Write(op);
                PrintExpr(e.E, opBindingStrength, MutateCSharp.Schemata91.ReplaceBooleanConstant_0(1463L, false), MutateCSharp.Schemata91.ReplaceBinExprOp_8(1464L, () => parensNeeded, () => isRightmost), MutateCSharp.Schemata91.ReplaceBinExprOp_4(1470L, () => !parensNeeded, () => isFollowedBySemicolon), MutateCSharp.Schemata91.ReplaceNumericConstant_5(1476L, -1), keyword);
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1480L, ")")); }
            }
            else if (expr is NestedMatchExpr)
            {
                var e = (NestedMatchExpr)expr;
                var parensNeeded = MutateCSharp.Schemata91.ReplaceBinExprOp_4(1481L, () => !isRightmost, () => !e.UsesOptionalBraces);
                if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1487L, "(")); }
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1488L, "match "));
                PrintExpression(e.Source, MutateCSharp.Schemata91.ReplaceBinExprOp_4(1498L, () => isRightmost, () => MutateCSharp.Schemata91.ReplaceBinExprOp_6(1493L, e.Cases.Count, MutateCSharp.Schemata91.ReplaceNumericConstant_5(1489L, 0))), MutateCSharp.Schemata91.ReplaceBinExprOp_4(1504L, () => !parensNeeded, () => isFollowedBySemicolon));
                if (e.UsesOptionalBraces) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1510L, " {")); }
                int i = MutateCSharp.Schemata91.ReplaceNumericConstant_5(1511L, 0);
                foreach (var mc in e.Cases)
                {
                    bool isLastCase = MutateCSharp.Schemata91.ReplaceBinExprOp_6(1528L, i, MutateCSharp.Schemata91.ReplaceBinExprOp_7(1519L, e.Cases.Count, MutateCSharp.Schemata91.ReplaceNumericConstant_5(1515L, 1)));
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1533L, " case"));
                    PrintAttributes(mc.Attributes);
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1534L, " "));
                    PrintExtendedPattern(mc.Pat);
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1535L, " => "));
                    PrintExpression(mc.Body, MutateCSharp.Schemata91.ReplaceBinExprOp_4(1536L, () => isRightmost, () => isLastCase), MutateCSharp.Schemata91.ReplaceBinExprOp_4(1542L, () => !parensNeeded, () => isFollowedBySemicolon));
                    MutateCSharp.Schemata91.ReplacePostfixUnaryExprOp_9(1548L, ref i);
                }
                if (e.UsesOptionalBraces) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1549L, " }")); } else if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1550L, ")")); }
                // }
            }
            else if (expr is MatchExpr)
            {
                var e = (MatchExpr)expr;
                if (MutateCSharp.Schemata91.ReplaceBinExprOp_4(1552L, () => options.DafnyPrintResolvedFile == null, () => MutateCSharp.Schemata91.ReplaceBinExprOp_10(1551L, e.OrigUnresolved, null)))
                {
                    PrintExpr(e.OrigUnresolved, contextBindingStrength, fragileContext, isRightmost, isFollowedBySemicolon, indent);
                }
                else
                {
                    var parensNeeded = MutateCSharp.Schemata91.ReplaceBinExprOp_4(1558L, () => !isRightmost, () => !e.UsesOptionalBraces);
                    if (parensNeeded) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1564L, "(")); }
                    wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1565L, "match "));
                    PrintExpression(e.Source, MutateCSharp.Schemata91.ReplaceBinExprOp_4(1575L, () => isRightmost, () => MutateCSharp.Schemata91.ReplaceBinExprOp_6(1570L, e.Cases.Count, MutateCSharp.Schemata91.ReplaceNumericConstant_5(1566L, 0))), MutateCSharp.Schemata91.ReplaceBinExprOp_4(1581L, () => !parensNeeded, () => isFollowedBySemicolon));
                    if (e.UsesOptionalBraces) { wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1587L, " {")); }
                    int i = MutateCSharp.Schemata91.ReplaceNumericConstant_5(1588L, 0);
                    foreach (var mc in e.Cases)
                    {
                        bool isLastCase = MutateCSharp.Schemata91.ReplaceBinExprOp_6(1605L, i, MutateCSharp.Schemata91.ReplaceBinExprOp_7(1596L, e.Cases.Count, MutateCSharp.Schemata91.ReplaceNumericConstant_5(1592L, 1)));
                        wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1610L, " case {0}"), mc.Ctor.Name);
                        PrintMatchCaseArgument(mc);
                        wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1611L, " => "));
                        PrintExpression(mc.Body, MutateCSharp.Schemata91.ReplaceBinExprOp_4(1612L, () => isRightmost, () => isLastCase), MutateCSharp.Schemata91.ReplaceBinExprOp_4(1618L, () => !parensNeeded, () => isFollowedBySemicolon));
                        MutateCSharp.Schemata91.ReplacePostfixUnaryExprOp_9(1624L, ref i);
                    }
                    if (e.UsesOptionalBraces)
                    {
                        wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1625L, " }"));
                    }
                    else if (parensNeeded)
                    {
                        wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1626L, ")"));
                    }
                }

            }
            else if (expr is DefaultValueExpression)
            {
                var e = (DefaultValueExpression)expr;
                // DefaultValueExpression's are introduced during resolution, so we expect .Resolved to be non-null
                Contract.Assert(e.WasResolved());
                Contract.Assert(e.Resolved != null);
                PrintExpr(e.Resolved, contextBindingStrength, fragileContext, isRightmost, isFollowedBySemicolon, indent, keyword);

            }
            else if (expr is BoxingCastExpr)
            {
                // this is not expected for a parsed program, but we may be called for /trace purposes in the translator
                var e = (BoxingCastExpr)expr;
                PrintExpr(e.E, contextBindingStrength, fragileContext, isRightmost, isFollowedBySemicolon, indent, keyword);
            }
            else if (expr is BoogieGenerator.BoogieWrapper)
            {
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1627L, "[BoogieWrapper]"));  // this is somewhat unexpected, but we can get here if the /trace switch is used, so it seems best to cover this case here
            }
            else if (expr is BoogieGenerator.BoogieFunctionCall)
            {
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1628L, "[BoogieFunctionCall]"));  // this prevents debugger watch window crash
            }
            else if (expr is Resolver_IdentifierExpr)
            {
                wr.Write(MutateCSharp.Schemata91.ReplaceStringConstant_1(1629L, "[Resolver_IdentifierExpr]"));  // we can get here in the middle of a debugging session
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected expression
            }
        }
    }
}
