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
    internal class Schemata92
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT92");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_23(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_26(long mutantId, Microsoft.Dafny.ConcreteUpdateStatement argument1, object argument2)
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

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.AssertLabel argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_24(long mutantId, Microsoft.Dafny.CalcStmt.CalcOp argument1, object argument2)
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

        internal static int ReplaceBinExprOp_13(long mutantId, int argument1, int argument2)
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

        internal static int ReplaceBinExprOp_17(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.AssertStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.FrameExpression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_15(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.AssignmentRhs> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_29(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.FrameExpression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_30(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_25(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_31(long mutantId, Microsoft.Dafny.ActualBindings argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.LList<Microsoft.Dafny.Label> argument1, object argument2)
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

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.PrintModes argument1, Microsoft.Dafny.PrintModes argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_27(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_28(long mutantId, Microsoft.Dafny.AttributedToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_8(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.ExpectStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{

    public partial class Printer
    {

        /// <summary>
        /// Prints from the current position of the current line.
        /// If the statement requires several lines, subsequent lines are indented at "indent".
        /// No newline is printed after the statement.
        /// </summary>
        public void PrintStatement(Statement stmt, int indent)
        {
            Contract.Requires(stmt != null);

            if (MutateCSharp.Schemata92.ReplaceBinExprOp_1(2L, () => stmt.IsGhost, () => MutateCSharp.Schemata92.ReplaceBinExprOp_0(1L, printMode, PrintModes.NoGhost))) { return; }
            for (LList<Label> label = stmt.Labels; MutateCSharp.Schemata92.ReplaceBinExprOp_2(8L, label, null); label = label.Next)
            {
                if (label.Data.Name != null)
                {
                    wr.WriteLine(MutateCSharp.Schemata92.ReplaceStringConstant_3(9L, "label {0}:"), label.Data.Name);
                    Indent(indent);
                }
            }

            if (stmt is PredicateStmt)
            {
                if (MutateCSharp.Schemata92.ReplaceBinExprOp_0(10L, printMode, PrintModes.NoGhost)) { return; }
                Expression expr = ((PredicateStmt)stmt).Expr;
                var assertStmt = stmt as AssertStmt;
                var expectStmt = stmt as ExpectStmt;
                wr.Write(MutateCSharp.Schemata92.ReplaceBinExprOp_4(11L, assertStmt, null) ? MutateCSharp.Schemata92.ReplaceStringConstant_3(12L, "assert") : MutateCSharp.Schemata92.ReplaceBinExprOp_5(13L, expectStmt, null) ? MutateCSharp.Schemata92.ReplaceStringConstant_3(14L, "expect") : MutateCSharp.Schemata92.ReplaceStringConstant_3(15L, "assume"));
                if (MutateCSharp.Schemata92.ReplaceBinExprOp_6(16L, stmt.Attributes, null))
                {
                    PrintAttributes(stmt.Attributes);
                }
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(17L, " "));
                if (MutateCSharp.Schemata92.ReplaceBinExprOp_1(20L, () => MutateCSharp.Schemata92.ReplaceBinExprOp_4(18L, assertStmt, null), () => MutateCSharp.Schemata92.ReplaceBinExprOp_7(19L, assertStmt.Label, null)))
                {
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(26L, "{0}: "), assertStmt.Label.Name);
                }
                PrintExpression(expr, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(27L, true));
                if (MutateCSharp.Schemata92.ReplaceBinExprOp_1(30L, () => MutateCSharp.Schemata92.ReplaceBinExprOp_4(28L, assertStmt, null), () => MutateCSharp.Schemata92.ReplaceBinExprOp_9(29L, assertStmt.Proof, null)))
                {
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(36L, " by "));
                    PrintStatement(assertStmt.Proof, indent);
                }
                else if (MutateCSharp.Schemata92.ReplaceBinExprOp_1(39L, () => MutateCSharp.Schemata92.ReplaceBinExprOp_5(37L, expectStmt, null), () => MutateCSharp.Schemata92.ReplaceBinExprOp_10(38L, expectStmt.Message, null)))
                {
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(45L, ", "));
                    PrintExpression(expectStmt.Message, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(46L, true));
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(47L, ";"));
                }
                else
                {
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(48L, ";"));
                }

            }
            else if (stmt is PrintStmt)
            {
                PrintStmt s = (PrintStmt)stmt;
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(49L, "print"));
                PrintAttributeArgs(s.Args, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(50L, true));
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(51L, ";"));

            }
            else if (stmt is RevealStmt)
            {
                var s = (RevealStmt)stmt;
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(52L, "reveal "));
                var sep = "";
                foreach (var e in s.Exprs)
                {
                    wr.Write(sep);
                    sep = MutateCSharp.Schemata92.ReplaceStringConstant_3(53L, ", ");
                    if (RevealStmt.SingleName(e) != null)
                    {
                        // this will do the printing correctly for labels (or label-lookalikes) like 00_023 (which by PrintExpression below would be printed as 23)
                        wr.Write(RevealStmt.SingleName(e));
                    }
                    else
                    {
                        PrintExpression(e, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(54L, true));
                    }
                }
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(55L, ";"));

            }
            else if (stmt is BreakStmt)
            {
                var s = (BreakStmt)stmt;
                if (MutateCSharp.Schemata92.ReplaceBinExprOp_11(56L, s.TargetLabel, null))
                {
                    wr.Write($"{s.Kind} {s.TargetLabel.val};");
                }
                else
                {
                    for (int i = MutateCSharp.Schemata92.ReplaceNumericConstant_12(57L, 0); MutateCSharp.Schemata92.ReplaceBinExprOp_14(74L, i, MutateCSharp.Schemata92.ReplaceBinExprOp_13(65L, s.BreakAndContinueCount, MutateCSharp.Schemata92.ReplaceNumericConstant_12(61L, 1))); MutateCSharp.Schemata92.ReplacePostfixUnaryExprOp_15(79L, ref i))
                    {
                        wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(80L, "break "));
                    }
                    wr.Write($"{s.Kind};");
                }

            }
            else if (stmt is ProduceStmt)
            {
                var s = (ProduceStmt)stmt;
                wr.Write(s is YieldStmt ? MutateCSharp.Schemata92.ReplaceStringConstant_3(81L, "yield") : MutateCSharp.Schemata92.ReplaceStringConstant_3(82L, "return"));
                if (MutateCSharp.Schemata92.ReplaceBinExprOp_16(83L, s.Rhss, null))
                {
                    var sep = MutateCSharp.Schemata92.ReplaceStringConstant_3(84L, " ");
                    foreach (var rhs in s.Rhss)
                    {
                        wr.Write(sep);
                        PrintRhs(rhs);
                        sep = MutateCSharp.Schemata92.ReplaceStringConstant_3(85L, ", ");
                    }
                }
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(86L, ";"));

            }
            else if (stmt is AssignStmt)
            {
                AssignStmt s = (AssignStmt)stmt;
                PrintExpression(s.Lhs, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(87L, true));
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(88L, " := "));
                PrintRhs(s.Rhs);
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(89L, ";"));

            }
            else if (stmt is DividedBlockStmt)
            {
                var sbs = (DividedBlockStmt)stmt;
                wr.WriteLine(MutateCSharp.Schemata92.ReplaceStringConstant_3(90L, "{"));
                int ind = MutateCSharp.Schemata92.ReplaceBinExprOp_17(91L, indent, IndentAmount);
                foreach (Statement s in sbs.BodyInit)
                {
                    Indent(ind);
                    PrintStatement(s, ind);
                    wr.WriteLine();
                }
                if (MutateCSharp.Schemata92.ReplaceBinExprOp_19(110L, () => MutateCSharp.Schemata92.ReplaceBinExprOp_18(104L, sbs.BodyProper.Count, MutateCSharp.Schemata92.ReplaceNumericConstant_12(100L, 0)), () => MutateCSharp.Schemata92.ReplaceBinExprOp_11(109L, sbs.SeparatorTok, null)))
                {
                    Indent(MutateCSharp.Schemata92.ReplaceBinExprOp_17(116L, indent, IndentAmount));
                    wr.WriteLine(MutateCSharp.Schemata92.ReplaceStringConstant_3(125L, "new;"));
                    foreach (Statement s in sbs.BodyProper)
                    {
                        Indent(ind);
                        PrintStatement(s, ind);
                        wr.WriteLine();
                    }
                }
                Indent(indent);
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(126L, "}"));

            }
            else if (stmt is BlockStmt)
            {
                wr.WriteLine(MutateCSharp.Schemata92.ReplaceStringConstant_3(127L, "{"));
                int ind = MutateCSharp.Schemata92.ReplaceBinExprOp_17(128L, indent, IndentAmount);
                foreach (Statement s in ((BlockStmt)stmt).Body)
                {
                    Indent(ind);
                    PrintStatement(s, ind);
                    wr.WriteLine();
                }
                Indent(indent);
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(137L, "}"));

            }
            else if (stmt is IfStmt)
            {
                IfStmt s = (IfStmt)stmt;
                PrintIfStatement(indent, s, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(138L, false));

            }
            else if (stmt is AlternativeStmt)
            {
                var s = (AlternativeStmt)stmt;
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(139L, "if"));
                PrintAttributes(s.Attributes);
                if (s.UsesOptionalBraces)
                {
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(140L, " {"));
                }
                PrintAlternatives(MutateCSharp.Schemata92.ReplaceBinExprOp_17(145L, indent, (s.UsesOptionalBraces ? IndentAmount : MutateCSharp.Schemata92.ReplaceNumericConstant_12(141L, 0))), s.Alternatives);
                if (s.UsesOptionalBraces)
                {
                    wr.WriteLine();
                    Indent(indent);
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(154L, "}"));
                }
            }
            else if (stmt is WhileStmt)
            {
                var s = (WhileStmt)stmt;
                PrintWhileStatement(indent, s, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(155L, false), MutateCSharp.Schemata92.ReplaceBooleanConstant_8(156L, false));
            }
            else if (stmt is AlternativeLoopStmt)
            {
                var s = (AlternativeLoopStmt)stmt;
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(157L, "while"));
                PrintAttributes(s.Attributes);
                PrintSpec(MutateCSharp.Schemata92.ReplaceStringConstant_3(158L, "invariant"), s.Invariants, MutateCSharp.Schemata92.ReplaceBinExprOp_17(159L, indent, IndentAmount));
                PrintDecreasesSpec(s.Decreases, MutateCSharp.Schemata92.ReplaceBinExprOp_17(168L, indent, IndentAmount));
                PrintFrameSpecLine(MutateCSharp.Schemata92.ReplaceStringConstant_3(177L, "modifies"), s.Mod, MutateCSharp.Schemata92.ReplaceBinExprOp_17(178L, indent, IndentAmount));
                bool hasSpecs = MutateCSharp.Schemata92.ReplaceBinExprOp_19(219L, () => MutateCSharp.Schemata92.ReplaceBinExprOp_19(212L, () => MutateCSharp.Schemata92.ReplaceBinExprOp_18(191L, s.Invariants.Count, MutateCSharp.Schemata92.ReplaceNumericConstant_12(187L, 0)), () => (MutateCSharp.Schemata92.ReplaceBinExprOp_1(206L, () => MutateCSharp.Schemata92.ReplaceBinExprOp_20(196L, s.Decreases.Expressions, null), () => MutateCSharp.Schemata92.ReplaceBinExprOp_18(201L, s.Decreases.Expressions.Count, MutateCSharp.Schemata92.ReplaceNumericConstant_12(197L, 0))))), () => MutateCSharp.Schemata92.ReplaceBinExprOp_21(218L, s.Mod.Expressions, null));
                if (s.UsesOptionalBraces)
                {
                    if (hasSpecs)
                    {
                        wr.WriteLine();
                        Indent(indent);
                    }
                    else
                    {
                        wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(225L, " "));
                    }
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(226L, "{"));
                }
                Contract.Assert(s.Alternatives.Count != 0);
                PrintAlternatives(MutateCSharp.Schemata92.ReplaceBinExprOp_17(231L, indent, (s.UsesOptionalBraces ? IndentAmount : MutateCSharp.Schemata92.ReplaceNumericConstant_12(227L, 0))), s.Alternatives);
                if (s.UsesOptionalBraces)
                {
                    wr.WriteLine();
                    Indent(indent);
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(240L, "}"));
                }

            }
            else if (stmt is ForLoopStmt)
            {
                var s = (ForLoopStmt)stmt;
                PrintForLoopStatement(indent, s);

            }
            else if (stmt is ForallStmt)
            {
                var s = (ForallStmt)stmt;
                if (MutateCSharp.Schemata92.ReplaceBinExprOp_1(242L, () => options.DafnyPrintResolvedFile != null, () => MutateCSharp.Schemata92.ReplaceBinExprOp_20(241L, s.EffectiveEnsuresClauses, null)))
                {
                    foreach (var expr in s.EffectiveEnsuresClauses)
                    {
                        PrintExpression(expr, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(248L, false), new string(' ', MutateCSharp.Schemata92.ReplaceBinExprOp_17(249L, indent, IndentAmount)) + MutateCSharp.Schemata92.ReplaceStringConstant_3(258L, "ensures "));
                    }
                    if (MutateCSharp.Schemata92.ReplaceBinExprOp_22(259L, s.Body, null))
                    {
                        wr.WriteLine();
                        Indent(indent);
                    }
                }
                else
                {
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(260L, "forall"));
                    if (MutateCSharp.Schemata92.ReplaceBinExprOp_18(265L, s.BoundVars.Count, MutateCSharp.Schemata92.ReplaceNumericConstant_12(261L, 0)))
                    {
                        wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(270L, " "));
                        PrintQuantifierDomain(s.BoundVars, s.Attributes, s.Range);
                    }
                    PrintSpec(MutateCSharp.Schemata92.ReplaceStringConstant_3(271L, "ensures"), s.Ens, MutateCSharp.Schemata92.ReplaceBinExprOp_17(272L, indent, IndentAmount));
                    if (MutateCSharp.Schemata92.ReplaceBinExprOp_22(281L, s.Body, null))
                    {
                        if (MutateCSharp.Schemata92.ReplaceBinExprOp_23(286L, s.Ens.Count, MutateCSharp.Schemata92.ReplaceNumericConstant_12(282L, 0)))
                        {
                            wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(291L, " "));
                        }
                        else
                        {
                            wr.WriteLine();
                            Indent(indent);
                        }
                    }
                }
                if (MutateCSharp.Schemata92.ReplaceBinExprOp_22(292L, s.Body, null))
                {
                    PrintStatement(s.Body, indent);
                }

            }
            else if (stmt is ModifyStmt)
            {
                var s = (ModifyStmt)stmt;
                PrintModifyStmt(indent, s, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(293L, false));

            }
            else if (stmt is CalcStmt)
            {
                CalcStmt s = (CalcStmt)stmt;
                if (MutateCSharp.Schemata92.ReplaceBinExprOp_0(294L, printMode, PrintModes.NoGhost)) { return; }   // Calcs don't get a "ghost" attribute, but they are.
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(295L, "calc"));
                PrintAttributes(stmt.Attributes);
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(296L, " "));
                if (MutateCSharp.Schemata92.ReplaceBinExprOp_24(297L, s.UserSuppliedOp, null))
                {
                    PrintCalcOp(s.UserSuppliedOp);
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(298L, " "));
                }
                else if (MutateCSharp.Schemata92.ReplaceBinExprOp_1(300L, () => options.DafnyPrintResolvedFile != null, () => MutateCSharp.Schemata92.ReplaceBinExprOp_24(299L, s.Op, null)))
                {
                    PrintCalcOp(s.Op);
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(306L, " "));
                }
                wr.WriteLine(MutateCSharp.Schemata92.ReplaceStringConstant_3(307L, "{"));
                int lineInd = MutateCSharp.Schemata92.ReplaceBinExprOp_17(308L, indent, IndentAmount);
                int lineCount = MutateCSharp.Schemata92.ReplaceBinExprOp_23(321L, s.Lines.Count, MutateCSharp.Schemata92.ReplaceNumericConstant_12(317L, 0)) ? MutateCSharp.Schemata92.ReplaceNumericConstant_12(326L, 0) : MutateCSharp.Schemata92.ReplaceBinExprOp_13(334L, s.Lines.Count, MutateCSharp.Schemata92.ReplaceNumericConstant_12(330L, 1));  // if nonempty, .Lines always contains a duplicated last line
                                                                                                                                                                                                                                                                                                                                                           // The number of op/hints is commonly one less than the number of lines, but
                                                                                                                                                                                                                                                                                                                                                           // it can also equal the number of lines for empty calc's and for calc's with
                                                                                                                                                                                                                                                                                                                                                           // a dangling hint.
                int hintCount = MutateCSharp.Schemata92.ReplaceBinExprOp_1(361L, () => MutateCSharp.Schemata92.ReplaceBinExprOp_18(347L, s.Lines.Count, MutateCSharp.Schemata92.ReplaceNumericConstant_12(343L, 0)), () => MutateCSharp.Schemata92.ReplaceBinExprOp_23(356L, s.Hints.Last().Body.Count, MutateCSharp.Schemata92.ReplaceNumericConstant_12(352L, 0))) ? MutateCSharp.Schemata92.ReplaceBinExprOp_13(371L, lineCount, MutateCSharp.Schemata92.ReplaceNumericConstant_12(367L, 1)) : lineCount;
                for (var i = MutateCSharp.Schemata92.ReplaceNumericConstant_12(380L, 0); MutateCSharp.Schemata92.ReplaceBinExprOp_14(384L, i, lineCount); MutateCSharp.Schemata92.ReplacePostfixUnaryExprOp_15(389L, ref i))
                {
                    var e = s.Lines[i];
                    var op = s.StepOps[i];
                    var h = s.Hints[i];
                    // print the line
                    Indent(lineInd);
                    PrintExpression(e, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(390L, true), lineInd);
                    wr.WriteLine(MutateCSharp.Schemata92.ReplaceStringConstant_3(391L, ";"));
                    if (MutateCSharp.Schemata92.ReplaceBinExprOp_23(392L, i, hintCount))
                    {
                        break;
                    }
                    // print the operator, if any
                    if (MutateCSharp.Schemata92.ReplaceBinExprOp_19(405L, () => MutateCSharp.Schemata92.ReplaceBinExprOp_24(397L, op, null), () => (MutateCSharp.Schemata92.ReplaceBinExprOp_1(399L, () => options.DafnyPrintResolvedFile != null, () => MutateCSharp.Schemata92.ReplaceBinExprOp_24(398L, s.Op, null)))))
                    {
                        Indent(indent);  // this lines up with the "calc"
                        PrintCalcOp(op ?? s.Op);
                        wr.WriteLine();
                    }
                    // print the hints
                    foreach (var st in h.Body)
                    {
                        Indent(lineInd);
                        PrintStatement(st, lineInd);
                        wr.WriteLine();
                    }
                }
                Indent(indent);
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(411L, "}"));
            }
            else if (stmt is NestedMatchStmt)
            {
                // Print ResolvedStatement, if present, as comment
                var s = (NestedMatchStmt)stmt;

                if (MutateCSharp.Schemata92.ReplaceBinExprOp_1(413L, () => MutateCSharp.Schemata92.ReplaceBinExprOp_22(412L, s.Flattened, null), () => options.DafnyPrintResolvedFile != null))
                {
                    wr.WriteLine();
                    if (!printingDesugared)
                    {
                        Indent(indent); wr.WriteLine(MutateCSharp.Schemata92.ReplaceStringConstant_3(419L, "/*---------- flattened ----------"));
                    }

                    var savedDesugarMode = printingDesugared;
                    printingDesugared = MutateCSharp.Schemata92.ReplaceBooleanConstant_8(420L, true);
                    Indent(indent); PrintStatement(s.Flattened, indent);
                    wr.WriteLine();
                    printingDesugared = savedDesugarMode;

                    if (!printingDesugared)
                    {
                        Indent(indent); wr.WriteLine(MutateCSharp.Schemata92.ReplaceStringConstant_3(421L, "---------- end flattened ----------*/"));
                    }
                    Indent(indent);
                }

                if (!printingDesugared)
                {
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(422L, "match"));
                    PrintAttributes(s.Attributes);
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(423L, " "));
                    PrintExpression(s.Source, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(424L, false));
                    if (s.UsesOptionalBraces)
                    {
                        wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(425L, " {"));
                    }
                    int caseInd = MutateCSharp.Schemata92.ReplaceBinExprOp_17(430L, indent, (s.UsesOptionalBraces ? IndentAmount : MutateCSharp.Schemata92.ReplaceNumericConstant_12(426L, 0)));
                    foreach (NestedMatchCaseStmt mc in s.Cases)
                    {
                        wr.WriteLine();
                        Indent(caseInd);
                        wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(439L, "case"));
                        PrintAttributes(mc.Attributes);
                        wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(440L, " "));
                        PrintExtendedPattern(mc.Pat);
                        wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(441L, " =>"));
                        foreach (Statement bs in mc.Body)
                        {
                            wr.WriteLine();
                            Indent(MutateCSharp.Schemata92.ReplaceBinExprOp_17(442L, caseInd, IndentAmount));
                            PrintStatement(bs, MutateCSharp.Schemata92.ReplaceBinExprOp_17(451L, caseInd, IndentAmount));
                        }
                    }
                    if (s.UsesOptionalBraces)
                    {
                        wr.WriteLine();
                        Indent(indent);
                        wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(460L, "}"));
                    }
                }
            }
            else if (stmt is MatchStmt)
            {
                var s = (MatchStmt)stmt;
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(461L, "match"));
                PrintAttributes(s.Attributes);
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(462L, " "));
                PrintExpression(s.Source, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(463L, false));
                if (s.UsesOptionalBraces)
                {
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(464L, " {"));
                }

                int caseInd = MutateCSharp.Schemata92.ReplaceBinExprOp_17(469L, indent, (s.UsesOptionalBraces ? IndentAmount : MutateCSharp.Schemata92.ReplaceNumericConstant_12(465L, 0)));
                foreach (MatchCaseStmt mc in s.Cases)
                {
                    wr.WriteLine();
                    Indent(caseInd);
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(478L, "case"));
                    PrintAttributes(mc.Attributes);
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(479L, " "));
                    if (!mc.Ctor.Name.StartsWith(SystemModuleManager.TupleTypeCtorNamePrefix))
                    {
                        wr.Write(mc.Ctor.Name);
                    }

                    PrintMatchCaseArgument(mc);
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(480L, " =>"));
                    foreach (Statement bs in mc.Body)
                    {
                        wr.WriteLine();
                        Indent(MutateCSharp.Schemata92.ReplaceBinExprOp_17(481L, caseInd, IndentAmount));
                        PrintStatement(bs, MutateCSharp.Schemata92.ReplaceBinExprOp_17(490L, caseInd, IndentAmount));
                    }
                }

                if (s.UsesOptionalBraces)
                {
                    wr.WriteLine();
                    Indent(indent);
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(499L, "}"));
                }

            }
            else if (stmt is ConcreteUpdateStatement)
            {
                var s = (ConcreteUpdateStatement)stmt;
                string sep = "";
                foreach (var lhs in s.Lhss)
                {
                    wr.Write(sep);
                    PrintExpression(lhs, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(500L, true));
                    sep = MutateCSharp.Schemata92.ReplaceStringConstant_3(501L, ", ");
                }
                if (MutateCSharp.Schemata92.ReplaceBinExprOp_25(506L, s.Lhss.Count, MutateCSharp.Schemata92.ReplaceNumericConstant_12(502L, 0)))
                {
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(511L, " "));
                }
                PrintUpdateRHS(s, indent);
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(512L, ";"));

            }
            else if (stmt is CallStmt)
            {
                // Most calls are printed from their concrete syntax given in the input. However, recursive calls to
                // prefix lemmas end up as CallStmt's by the end of resolution and they may need to be printed here.
                var s = (CallStmt)stmt;
                PrintExpression(s.MethodSelect, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(513L, false));
                PrintActualArguments(s.Bindings, s.Method.Name, null);

            }
            else if (stmt is VarDeclStmt)
            {
                var s = (VarDeclStmt)stmt;
                if (MutateCSharp.Schemata92.ReplaceBinExprOp_1(515L, () => s.Locals.Exists(v => v.IsGhost), () => MutateCSharp.Schemata92.ReplaceBinExprOp_0(514L, printMode, PrintModes.NoGhost))) { return; }
                if (s.Locals.TrueForAll((v => v.IsGhost)))
                {
                    // Emit the "ghost" modifier if all of the variables are ghost. If some are ghost, but not others,
                    // then some of these ghosts are auto-converted to ghost, so we should not emit the "ghost" keyword.
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(521L, "ghost "));
                }
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(522L, "var"));
                string sep = "";
                foreach (var local in s.Locals)
                {
                    wr.Write(sep);
                    if (MutateCSharp.Schemata92.ReplaceBinExprOp_6(523L, local.Attributes, null))
                    {
                        PrintAttributes(local.Attributes);
                    }
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(524L, " {0}"), local.DisplayName);
                    PrintType(MutateCSharp.Schemata92.ReplaceStringConstant_3(525L, ": "), local.OptionalType);
                    sep = MutateCSharp.Schemata92.ReplaceStringConstant_3(526L, ",");
                }
                if (MutateCSharp.Schemata92.ReplaceBinExprOp_26(527L, s.Update, null))
                {
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(528L, " "));
                    PrintUpdateRHS(s.Update, indent);
                }
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(529L, ";"));

            }
            else if (stmt is VarDeclPattern)
            {
                var s = (VarDeclPattern)stmt;
                if (s.tok is AutoGeneratedToken)
                {
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(530L, "/* "));
                }
                if (s.HasGhostModifier)
                {
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(531L, "ghost "));
                }
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(532L, "var "));
                PrintCasePattern(s.LHS);
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(533L, " := "));
                PrintExpression(s.RHS, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(534L, true));
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(535L, ";"));
                if (s.tok is AutoGeneratedToken)
                {
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(536L, " */"));
                }

            }
            else if (stmt is SkeletonStatement)
            {
                var s = (SkeletonStatement)stmt;
                if (MutateCSharp.Schemata92.ReplaceBinExprOp_27(537L, s.S, null))
                {
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(538L, "...;"));
                }
                else if (s.S is AssertStmt)
                {
                    Contract.Assert(s.ConditionOmitted);
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(539L, "assert ...;"));
                }
                else if (s.S is ExpectStmt)
                {
                    Contract.Assert(s.ConditionOmitted);
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(540L, "expect ...;"));
                }
                else if (s.S is AssumeStmt)
                {
                    Contract.Assert(s.ConditionOmitted);
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(541L, "assume ...;"));
                }
                else if (s.S is IfStmt)
                {
                    PrintIfStatement(indent, (IfStmt)s.S, s.ConditionOmitted);
                }
                else if (s.S is WhileStmt)
                {
                    PrintWhileStatement(indent, (WhileStmt)s.S, s.ConditionOmitted, s.BodyOmitted);
                }
                else if (s.S is ModifyStmt)
                {
                    PrintModifyStmt(indent, (ModifyStmt)s.S, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(542L, true));
                }
                else
                {
                    Contract.Assert(false);
                    throw new cce.UnreachableException(); // unexpected skeleton statement
                }

            }
            else if (stmt is TryRecoverStatement haltRecoveryStatement)
            {
                // These have no actual syntax for Dafny user code, so emit something
                // clearly not parsable.
                int ind = MutateCSharp.Schemata92.ReplaceBinExprOp_17(543L, indent, IndentAmount);

                Indent(indent);
                wr.WriteLine(MutateCSharp.Schemata92.ReplaceStringConstant_3(552L, "[[ try { ]]"));
                PrintStatement(haltRecoveryStatement.TryBody, ind);
                wr.WriteLine();

                Indent(indent);
                wr.WriteLine($"[[ }} recover ({haltRecoveryStatement.HaltMessageVar.Name}) {{ ]]");
                PrintStatement(haltRecoveryStatement.RecoverBody, ind);
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(553L, "[[ } ]]"));
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected statement
            }
        }

        private void PrintModifyStmt(int indent, ModifyStmt s, bool omitFrame)
        {
            Contract.Requires(0 <= indent);
            Contract.Requires(s != null);
            Contract.Requires(!omitFrame || s.Mod.Expressions.Count == 0);

            wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(554L, "modify"));
            PrintAttributes(s.Mod.Attributes);
            wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(555L, " "));
            if (omitFrame)
            {
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(556L, "..."));
            }
            else
            {
                PrintFrameExpressionList(s.Mod.Expressions);
            }
            if (MutateCSharp.Schemata92.ReplaceBinExprOp_9(557L, s.Body, null))
            {
                // There's a possible syntactic ambiguity, namely if the frame is empty (more precisely,
                // if s.Mod.Expressions.Count is 0).  Since the statement was parsed at some point, this
                // situation can occur only if the modify statement inherited its frame by refinement
                // and we're printing the post-resolve AST.  In this special case, print an explicit
                // empty set as the frame.
                if (MutateCSharp.Schemata92.ReplaceBinExprOp_23(562L, s.Mod.Expressions.Count, MutateCSharp.Schemata92.ReplaceNumericConstant_12(558L, 0)))
                {
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(567L, " {}"));
                }
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(568L, " "));
                PrintStatement(s.Body, indent);
            }
            else
            {
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(569L, ";"));
            }
        }

        /// <summary>
        /// Does not print LHS, nor the space one might want between LHS and RHS,
        /// because if there's no LHS, we don't want to start with a space
        /// </summary>
        void PrintUpdateRHS(ConcreteUpdateStatement s, int indent)
        {
            Contract.Requires(s != null);
            if (s is UpdateStmt)
            {
                var update = (UpdateStmt)s;
                if (MutateCSharp.Schemata92.ReplaceBinExprOp_18(574L, update.Lhss.Count, MutateCSharp.Schemata92.ReplaceNumericConstant_12(570L, 0)))
                {
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(579L, ":= "));
                }
                var sep = "";
                foreach (var rhs in update.Rhss)
                {
                    wr.Write(sep);
                    PrintRhs(rhs);
                    sep = MutateCSharp.Schemata92.ReplaceStringConstant_3(580L, ", ");
                }
            }
            else if (s is AssignSuchThatStmt)
            {
                var update = (AssignSuchThatStmt)s;
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(581L, ":| "));
                if (MutateCSharp.Schemata92.ReplaceBinExprOp_28(582L, update.AssumeToken, null))
                {
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(583L, "assume"));
                    PrintAttributes(update.AssumeToken.Attrs);
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(584L, " "));
                }
                PrintExpression(update.Expr, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(585L, true));
            }
            else if (s is AssignOrReturnStmt)
            {
                var stmt = (AssignOrReturnStmt)s;
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(586L, ":-"));
                if (MutateCSharp.Schemata92.ReplaceBinExprOp_28(587L, stmt.KeywordToken, null))
                {
                    wr.Write($" {stmt.KeywordToken.Token.val}");
                    PrintAttributes(stmt.KeywordToken.Attrs);
                }
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(588L, " "));
                PrintRhs(stmt.Rhs);
                foreach (var rhs in stmt.Rhss)
                {
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(589L, ", "));
                    PrintRhs(rhs);
                }
                if (MutateCSharp.Schemata92.ReplaceBinExprOp_1(599L, () => options.DafnyPrintResolvedFile != null, () => MutateCSharp.Schemata92.ReplaceBinExprOp_25(594L, stmt.ResolvedStatements.Count, MutateCSharp.Schemata92.ReplaceNumericConstant_12(590L, 0))))
                {
                    wr.WriteLine();
                    Indent(indent); wr.WriteLine(MutateCSharp.Schemata92.ReplaceStringConstant_3(605L, "/*---------- desugared ----------"));
                    foreach (Statement r in stmt.ResolvedStatements)
                    {
                        Indent(indent);
                        PrintStatement(r, indent);
                        wr.WriteLine();
                    }
                    Indent(indent); wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(606L, "---------- end desugared ----------*/"));
                }

            }
            else
            {
                Contract.Assert(false);  // otherwise, unknown type
            }
        }

        void PrintIfStatement(int indent, IfStmt s, bool omitGuard)
        {
            wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(607L, "if"));
            PrintAttributes(s.Attributes);
            wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(608L, " "));
            if (omitGuard)
            {
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(609L, "... "));
            }
            else
            {
                PrintGuard(s.IsBindingGuard, s.Guard);
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(610L, " "));
            }
            PrintStatement(s.Thn, indent);
            if (MutateCSharp.Schemata92.ReplaceBinExprOp_22(611L, s.Els, null))
            {
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(612L, " else"));
                if (MutateCSharp.Schemata92.ReplaceBinExprOp_1(614L, () => !(s.Els is IfStmt), () => MutateCSharp.Schemata92.ReplaceBinExprOp_6(613L, s.Els.Attributes, null)))
                {
                    PrintAttributes(s.Els.Attributes);
                }
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(620L, " "));
                PrintStatement(s.Els, indent);
            }
        }

        void PrintWhileStatement(int indent, WhileStmt s, bool omitGuard, bool omitBody)
        {
            Contract.Requires(0 <= indent);
            wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(621L, "while"));
            PrintAttributes(s.Attributes);
            wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(622L, " "));
            if (omitGuard)
            {
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(623L, "..."));
            }
            else
            {
                PrintGuard(MutateCSharp.Schemata92.ReplaceBooleanConstant_8(624L, false), s.Guard);
            }

            PrintSpec(MutateCSharp.Schemata92.ReplaceStringConstant_3(625L, "invariant"), s.Invariants, MutateCSharp.Schemata92.ReplaceBinExprOp_17(626L, indent, IndentAmount));
            PrintDecreasesSpec(s.Decreases, MutateCSharp.Schemata92.ReplaceBinExprOp_17(635L, indent, IndentAmount));
            PrintFrameSpecLine(MutateCSharp.Schemata92.ReplaceStringConstant_3(644L, "modifies"), s.Mod, MutateCSharp.Schemata92.ReplaceBinExprOp_17(645L, indent, IndentAmount));
            if (omitBody)
            {
                wr.WriteLine();
                Indent(MutateCSharp.Schemata92.ReplaceBinExprOp_17(654L, indent, IndentAmount));
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(663L, "...;"));
            }
            else if (MutateCSharp.Schemata92.ReplaceBinExprOp_9(664L, s.Body, null))
            {
                if (MutateCSharp.Schemata92.ReplaceBinExprOp_1(705L, () => MutateCSharp.Schemata92.ReplaceBinExprOp_1(683L, () => MutateCSharp.Schemata92.ReplaceBinExprOp_23(669L, s.Invariants.Count, MutateCSharp.Schemata92.ReplaceNumericConstant_12(665L, 0)), () => MutateCSharp.Schemata92.ReplaceBinExprOp_23(678L, s.Decreases.Expressions.Count, MutateCSharp.Schemata92.ReplaceNumericConstant_12(674L, 0))), () => (MutateCSharp.Schemata92.ReplaceBinExprOp_19(699L, () => MutateCSharp.Schemata92.ReplaceBinExprOp_29(689L, s.Mod.Expressions, null), () => MutateCSharp.Schemata92.ReplaceBinExprOp_23(694L, s.Mod.Expressions.Count, MutateCSharp.Schemata92.ReplaceNumericConstant_12(690L, 0))))))
                {
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(711L, " "));
                }
                else
                {
                    wr.WriteLine();
                    Indent(indent);
                }
                PrintStatement(s.Body, indent);
            }
        }

        void PrintAlternatives(int indent, List<GuardedAlternative> alternatives)
        {
            var startWithLine = MutateCSharp.Schemata92.ReplaceBooleanConstant_8(712L, true);
            foreach (var alternative in alternatives)
            {
                if (startWithLine)
                {
                    wr.WriteLine();
                }
                else
                {
                    startWithLine = MutateCSharp.Schemata92.ReplaceBooleanConstant_8(713L, true);
                }
                Indent(indent);
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(714L, "case"));
                PrintAttributes(alternative.Attributes);
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(715L, " "));
                if (alternative.IsBindingGuard)
                {
                    var exists = (ExistsExpr)alternative.Guard;
                    PrintBindingGuard(exists);
                }
                else
                {
                    PrintExpression(alternative.Guard, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(716L, false));
                }
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(717L, " =>"));
                foreach (Statement s in alternative.Body)
                {
                    wr.WriteLine();
                    Indent(MutateCSharp.Schemata92.ReplaceBinExprOp_17(718L, indent, IndentAmount));
                    PrintStatement(s, MutateCSharp.Schemata92.ReplaceBinExprOp_17(727L, indent, IndentAmount));
                }
            }
        }

        void PrintForLoopStatement(int indent, ForLoopStmt s)
        {
            Contract.Requires(0 <= indent);
            Contract.Requires(s != null);
            wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(736L, "for"));
            PrintAttributes(s.Attributes);
            wr.Write($" {s.LoopIndex.Name}");
            PrintType(MutateCSharp.Schemata92.ReplaceStringConstant_3(737L, ": "), s.LoopIndex.Type);
            wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(738L, " := "));
            PrintExpression(s.Start, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(739L, false));
            wr.Write(s.GoingUp ? MutateCSharp.Schemata92.ReplaceStringConstant_3(740L, " to ") : MutateCSharp.Schemata92.ReplaceStringConstant_3(741L, " downto "));
            if (MutateCSharp.Schemata92.ReplaceBinExprOp_30(742L, s.End, null))
            {
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(743L, "*"));
            }
            else
            {
                PrintExpression(s.End, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(744L, false));
            }

            PrintSpec(MutateCSharp.Schemata92.ReplaceStringConstant_3(745L, "invariant"), s.Invariants, MutateCSharp.Schemata92.ReplaceBinExprOp_17(746L, indent, IndentAmount));
            PrintDecreasesSpec(s.Decreases, MutateCSharp.Schemata92.ReplaceBinExprOp_17(755L, indent, IndentAmount));
            if (MutateCSharp.Schemata92.ReplaceBinExprOp_21(764L, s.Mod.Expressions, null))
            {
                PrintFrameSpecLine(MutateCSharp.Schemata92.ReplaceStringConstant_3(765L, "modifies"), s.Mod, MutateCSharp.Schemata92.ReplaceBinExprOp_17(766L, indent, IndentAmount));
            }
            if (MutateCSharp.Schemata92.ReplaceBinExprOp_9(775L, s.Body, null))
            {
                if (MutateCSharp.Schemata92.ReplaceBinExprOp_1(816L, () => MutateCSharp.Schemata92.ReplaceBinExprOp_1(794L, () => MutateCSharp.Schemata92.ReplaceBinExprOp_23(780L, s.Invariants.Count, MutateCSharp.Schemata92.ReplaceNumericConstant_12(776L, 0)), () => MutateCSharp.Schemata92.ReplaceBinExprOp_23(789L, s.Decreases.Expressions.Count, MutateCSharp.Schemata92.ReplaceNumericConstant_12(785L, 0))), () => (MutateCSharp.Schemata92.ReplaceBinExprOp_19(810L, () => MutateCSharp.Schemata92.ReplaceBinExprOp_29(800L, s.Mod.Expressions, null), () => MutateCSharp.Schemata92.ReplaceBinExprOp_23(805L, s.Mod.Expressions.Count, MutateCSharp.Schemata92.ReplaceNumericConstant_12(801L, 0))))))
                {
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(822L, " "));
                }
                else
                {
                    wr.WriteLine();
                    Indent(indent);
                }
                PrintStatement(s.Body, indent);
            }
        }

        void PrintRhs(AssignmentRhs rhs)
        {
            Contract.Requires(rhs != null);
            if (rhs is ExprRhs)
            {
                PrintExpression(((ExprRhs)rhs).Expr, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(823L, true));
            }
            else if (rhs is HavocRhs)
            {
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(824L, "*"));
            }
            else if (rhs is TypeRhs)
            {
                TypeRhs t = (TypeRhs)rhs;
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(825L, "new "));
                if (MutateCSharp.Schemata92.ReplaceBinExprOp_20(826L, t.ArrayDimensions, null))
                {
                    if (ShowType(t.EType))
                    {
                        PrintType(t.EType);
                    }
                    if (MutateCSharp.Schemata92.ReplaceBinExprOp_1(853L, () => MutateCSharp.Schemata92.ReplaceBinExprOp_1(843L, () => MutateCSharp.Schemata92.ReplaceBinExprOp_1(828L, () => options.DafnyPrintResolvedFile == null, () => MutateCSharp.Schemata92.ReplaceBinExprOp_20(827L, t.InitDisplay, null)), () => MutateCSharp.Schemata92.ReplaceBinExprOp_23(838L, t.ArrayDimensions.Count, MutateCSharp.Schemata92.ReplaceNumericConstant_12(834L, 1))), () => AutoGeneratedToken.Is(t.ArrayDimensions[MutateCSharp.Schemata92.ReplaceNumericConstant_12(849L, 0)].tok)))
                    {
                        // elide the size
                        wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(859L, "[]"));
                    }
                    else
                    {
                        string s = MutateCSharp.Schemata92.ReplaceStringConstant_3(860L, "[");
                        foreach (Expression dim in t.ArrayDimensions)
                        {
                            Contract.Assume(dim != null);
                            wr.Write(s);
                            PrintExpression(dim, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(861L, false));
                            s = MutateCSharp.Schemata92.ReplaceStringConstant_3(862L, ", ");
                        }
                        wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(863L, "]"));
                    }
                    if (MutateCSharp.Schemata92.ReplaceBinExprOp_10(864L, t.ElementInit, null))
                    {
                        wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(865L, " ("));
                        PrintExpression(t.ElementInit, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(866L, false));
                        wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(867L, ")"));
                    }
                    else if (MutateCSharp.Schemata92.ReplaceBinExprOp_20(868L, t.InitDisplay, null))
                    {
                        wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(869L, " ["));
                        PrintExpressionList(t.InitDisplay, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(870L, false));
                        wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(871L, "]"));
                    }
                }
                else if (MutateCSharp.Schemata92.ReplaceBinExprOp_31(872L, t.Bindings, null))
                {
                    PrintType(t.EType);
                }
                else
                {
                    PrintType(t.Path);
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(873L, "("));
                    PrintBindings(t.Bindings, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(874L, false));
                    wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(875L, ")"));
                }
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected RHS
            }

            if (rhs.HasAttributes())
            {
                PrintAttributes(rhs.Attributes);
            }
        }

        void PrintGuard(bool isBindingGuard, Expression guard)
        {
            Contract.Requires(!isBindingGuard || (guard is ExistsExpr && ((ExistsExpr)guard).Range == null));
            if (MutateCSharp.Schemata92.ReplaceBinExprOp_30(876L, guard, null))
            {
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(877L, "*"));
            }
            else if (isBindingGuard)
            {
                var exists = (ExistsExpr)guard;
                PrintBindingGuard(exists);
            }
            else
            {
                PrintExpression(guard, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(878L, false));
            }
        }

        void PrintBindingGuard(ExistsExpr guard)
        {
            Contract.Requires(guard != null);
            Contract.Requires(guard.Range == null);
            PrintQuantifierDomain(guard.BoundVars, guard.Attributes, null);
            wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(879L, " :| "));
            PrintExpression(guard.Term, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(880L, false));
        }

        void PrintCalcOp(CalcStmt.CalcOp op)
        {
            Contract.Requires(op != null);
            wr.Write(op.ToString());
            if (op is CalcStmt.TernaryCalcOp)
            {
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(881L, "["));
                PrintExpression(((CalcStmt.TernaryCalcOp)op).Index, MutateCSharp.Schemata92.ReplaceBooleanConstant_8(882L, false));
                wr.Write(MutateCSharp.Schemata92.ReplaceStringConstant_3(883L, "]"));
            }
        }
    }
}
