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
    internal class Schemata90
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT90");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_18(long mutantId, Microsoft.Dafny.SubsetTypeDecl.WKind argument1, Microsoft.Dafny.SubsetTypeDecl.WKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_14(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_42(long mutantId, Microsoft.Dafny.TypeParameter.EqualitySupportValue argument1, Microsoft.Dafny.TypeParameter.EqualitySupportValue argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_30(long mutantId, Microsoft.Dafny.ExtremeLemma argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_27(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_40(long mutantId, Microsoft.Dafny.Specification<Microsoft.Dafny.FrameExpression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_39(long mutantId, System.Uri argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_41(long mutantId, Microsoft.Dafny.AssertLabel argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.PrintModes argument1, Microsoft.Dafny.PrintModes argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_34(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_25(long mutantId, Microsoft.Dafny.Implements argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_32(long mutantId, Microsoft.Dafny.PrefixPredicate argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, Microsoft.Dafny.ModuleSignature argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_26(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_35(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.PrintModes argument1, Microsoft.Dafny.PrintModes argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceNumericConstant_2(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_33(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
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

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_29(long mutantId, Microsoft.Dafny.NonNullTypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_31(long mutantId, Microsoft.Dafny.PrefixLemma argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Boogie.ExecutionEngineOptions.ShowEnvironment argument1, Microsoft.Boogie.ExecutionEngineOptions.ShowEnvironment argument2)
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

        internal static int ReplacePostfixUnaryExprOp_9(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1--; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1++; }
            return argument1--;
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

        internal static bool ReplaceBinExprOp_13(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_37(long mutantId, Microsoft.Dafny.Formal argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_24(long mutantId, System.Collections.Generic.IEnumerable<Microsoft.Dafny.IToken> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_36(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBinExprOp_38(long mutantId, Microsoft.Dafny.Method argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
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

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceBinExprOp_16(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_17(long mutantId, Microsoft.Dafny.BoundVar argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_23(long mutantId, Microsoft.Dafny.ModuleKindEnum argument1, Microsoft.Dafny.ModuleKindEnum argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_28(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.FrameExpression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{

    public enum PrintModes
    {
        Everything,
        Serialization, // Serializing the program to a file for lossless loading later
        NoIncludes,
        NoGhost
    }


    public record PrintFlags(bool UseOriginalDafnyNames = false);

    public partial class Printer
    {
        private DafnyOptions options;
        static Printer()
        {
            DafnyOptions.RegisterLegacyBinding(PrintMode, (options, value) =>
            {
                options.PrintMode = value;
            });

            DooFile.RegisterNoChecksNeeded(PrintMode, MutateCSharp.Schemata90.ReplaceBooleanConstant_0(1L, false));
        }

        public static readonly Option<PrintModes> PrintMode = new(MutateCSharp.Schemata90.ReplaceStringConstant_1(2L, "--print-mode"), () => PrintModes.Everything, MutateCSharp.Schemata90.ReplaceStringConstant_1(3L, @"
Everything - Print everything listed below.
Serialization - print the source that will be included in a compiled dll.
NoIncludes - disable printing of {:verify false} methods
    incorporated via the include mechanism, as well as datatypes and
    fields included from other files.
NoGhost - disable printing of functions, ghost methods, and proof
    statements in implementation methods. It also disables anything
    NoIncludes disables.").TrimStart())
        {
            IsHidden = MutateCSharp.Schemata90.ReplaceBooleanConstant_0(4L, true
    )
        };

        TextWriter wr;
        PrintModes printMode;
        bool afterResolver;
        bool printingExportSet = MutateCSharp.Schemata90.ReplaceBooleanConstant_0(5L, false);
        bool printingDesugared = MutateCSharp.Schemata90.ReplaceBooleanConstant_0(6L, false);
        private readonly PrintFlags printFlags;

        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(wr != null);
        }

        public Printer(TextWriter wr, DafnyOptions options, PrintModes printMode = PrintModes.Everything, [CanBeNull] PrintFlags printFlags = null)
        {
            Contract.Requires(wr != null);
            this.wr = wr;
            this.options = options;
            this.printMode = printMode;
            this.printFlags = printFlags ?? new PrintFlags();
        }

        public static string ExprToString(DafnyOptions options, Expression expr, [CanBeNull] PrintFlags printFlags = null)
        {
            Contract.Requires(expr != null);
            using var wr = new StringWriter();
            var pr = new Printer(wr, options, printFlags: printFlags);
            pr.PrintExpression(expr, MutateCSharp.Schemata90.ReplaceBooleanConstant_0(7L, false));
            return wr.ToString();
        }

        public static string GuardToString(DafnyOptions options, bool isBindingGuard, Expression expr)
        {
            Contract.Requires(!isBindingGuard || (expr is ExistsExpr && ((ExistsExpr)expr).Range == null));
            using (var wr = new System.IO.StringWriter())
            {
                var pr = new Printer(wr, options);
                pr.PrintGuard(isBindingGuard, expr);
                return wr.ToString();
            }

            return default;
        }

        public static string ExtendedExprToString(DafnyOptions options, Expression expr)
        {
            Contract.Requires(expr != null);
            using (var wr = new System.IO.StringWriter())
            {
                var pr = new Printer(wr, options);
                pr.PrintExtendedExpr(expr, MutateCSharp.Schemata90.ReplaceNumericConstant_2(8L, 0), MutateCSharp.Schemata90.ReplaceBooleanConstant_0(12L, true), MutateCSharp.Schemata90.ReplaceBooleanConstant_0(13L, false));
                return wr.ToString();
            }

            return default;
        }

        public static string FrameExprListToString(DafnyOptions options, List<FrameExpression> fexprs)
        {
            Contract.Requires(fexprs != null);
            using var wr = new StringWriter();
            var pr = new Printer(wr, options);
            pr.PrintFrameExpressionList(fexprs);
            return wr.ToString();
        }

        public static string StatementToString(DafnyOptions options, Statement stmt)
        {
            Contract.Requires(stmt != null);
            using var wr = new StringWriter();
            var pr = new Printer(wr, options);
            pr.PrintStatement(stmt, MutateCSharp.Schemata90.ReplaceNumericConstant_2(14L, 0));
            return ToStringWithoutNewline(wr);
        }

        public static string IteratorClassToString(DafnyOptions options, IteratorDecl iter)
        {
            Contract.Requires(iter != null);
            using (var wr = new System.IO.StringWriter())
            {
                var pr = new Printer(wr, options);
                pr.PrintIteratorClass(iter, MutateCSharp.Schemata90.ReplaceNumericConstant_2(18L, 0), null);
                return ToStringWithoutNewline(wr);
            }

            return default;
        }

        public static string IteratorSignatureToString(DafnyOptions options, IteratorDecl iter)
        {
            Contract.Requires(iter != null);
            using (var wr = new System.IO.StringWriter())
            {
                var pr = new Printer(wr, options);
                pr.PrintIteratorSignature(iter, MutateCSharp.Schemata90.ReplaceNumericConstant_2(22L, 0));
                return ToStringWithoutNewline(wr);
            }

            return default;
        }

        public static string FieldToString(DafnyOptions options, Field field)
        {
            Contract.Requires(field != null);
            using (var wr = new StringWriter())
            {
                var pr = new Printer(wr, options);
                pr.PrintField(field, MutateCSharp.Schemata90.ReplaceNumericConstant_2(26L, 0));
                return ToStringWithoutNewline(wr);
            }

            return default;
        }

        public static string FunctionSignatureToString(DafnyOptions options, Function f)
        {
            Contract.Requires(f != null);
            using var wr = new StringWriter();
            var pr = new Printer(wr, options);
            pr.PrintFunction(f, MutateCSharp.Schemata90.ReplaceNumericConstant_2(30L, 0), MutateCSharp.Schemata90.ReplaceBooleanConstant_0(34L, true));
            return ToStringWithoutNewline(wr);
        }

        public static string MethodSignatureToString(DafnyOptions options, Method m)
        {
            Contract.Requires(m != null);
            using (var wr = new System.IO.StringWriter())
            {
                var pr = new Printer(wr, options);
                pr.PrintMethod(m, MutateCSharp.Schemata90.ReplaceNumericConstant_2(35L, 0), MutateCSharp.Schemata90.ReplaceBooleanConstant_0(39L, true));
                return ToStringWithoutNewline(wr);
            }

            return default;
        }

        /// <summary>
        /// Returns a string for all attributes on the list "a".  Each attribute is
        /// followed by a space.
        /// </summary>
        public static string AttributesToString(DafnyOptions options, Attributes a)
        {
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_3(40L, a, null))
            {
                return "";
            }
            else
            {
                return AttributesToString(options, a.Prev) + OneAttributeToString(options, a) + MutateCSharp.Schemata90.ReplaceStringConstant_1(41L, " ");
            }

            return default;
        }

        public static string OneAttributeToString(DafnyOptions options, Attributes a, string nameSubstitution = null)
        {
            Contract.Requires(a != null);
            using (var wr = new System.IO.StringWriter())
            {
                var pr = new Printer(wr, options);
                pr.PrintOneAttribute(a, nameSubstitution);
                return ToStringWithoutNewline(wr);
            }

            return default;
        }

        public static string ToStringWithoutNewline(System.IO.StringWriter wr)
        {
            Contract.Requires(wr != null);
            var sb = wr.GetStringBuilder();
            var len = sb.Length;
            while (MutateCSharp.Schemata90.ReplaceBinExprOp_8(93L, () => MutateCSharp.Schemata90.ReplaceBinExprOp_4(46L, len, MutateCSharp.Schemata90.ReplaceNumericConstant_2(42L, 0)), () => (MutateCSharp.Schemata90.ReplaceBinExprOp_7(87L, () => MutateCSharp.Schemata90.ReplaceBinExprOp_6(64L, sb[MutateCSharp.Schemata90.ReplaceBinExprOp_5(55L, len, MutateCSharp.Schemata90.ReplaceNumericConstant_2(51L, 1))], '\n'), () => MutateCSharp.Schemata90.ReplaceBinExprOp_6(82L, sb[MutateCSharp.Schemata90.ReplaceBinExprOp_5(73L, len, MutateCSharp.Schemata90.ReplaceNumericConstant_2(69L, 1))], '\r')))))
            {
                MutateCSharp.Schemata90.ReplacePostfixUnaryExprOp_9(99L, ref len);
            }
            return sb.ToString(MutateCSharp.Schemata90.ReplaceNumericConstant_2(100L, 0), len);
        }

        public void PrintProgramLargeStack(Program prog, bool afterResolver)
        {
#pragma warning disable VSTHRD002
            DafnyMain.LargeStackFactory.StartNew(() => PrintProgram(prog, afterResolver)).Wait();
#pragma warning restore VSTHRD002
        }

        public void PrintProgram(Program prog, bool afterResolver)
        {
            Contract.Requires(prog != null);
            this.afterResolver = afterResolver;
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_10(104L, options.ShowEnv, Bpl.ExecutionEngineOptions.ShowEnvironment.Never))
            {
                wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(105L, "// ") + options.Version);
                wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(106L, "// ") + options.Environment);
            }
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_11(107L, options.PrintMode, PrintModes.Serialization))
            {
                wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(108L, "// {0}"), prog.Name);
            }
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_8(110L, () => options.DafnyPrintResolvedFile != null, () => MutateCSharp.Schemata90.ReplaceBinExprOp_12(109L, options.PrintMode, PrintModes.Everything)))
            {
                wr.WriteLine();
                wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(116L, "/*"));
                PrintModuleDefinition(prog.Compilation, prog.SystemModuleManager.SystemModule, null, MutateCSharp.Schemata90.ReplaceNumericConstant_2(117L, 0), null, Path.GetFullPath(options.DafnyPrintResolvedFile));
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(121L, "// bitvector types in use:"));
                foreach (var w in prog.SystemModuleManager.Bitwidths)
                {
                    wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(122L, " bv{0}"), w);
                }
                wr.WriteLine();
                wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(123L, "*/"));
            }
            wr.WriteLine();
            PrintCallGraph(prog.DefaultModuleDef, MutateCSharp.Schemata90.ReplaceNumericConstant_2(124L, 0));
            PrintTopLevelDecls(prog.Compilation, prog.DefaultModuleDef.TopLevelDecls, MutateCSharp.Schemata90.ReplaceNumericConstant_2(128L, 0), null, Path.GetFullPath(prog.FullName));
            foreach (var tup in prog.DefaultModuleDef.PrefixNamedModules)
            {
                var decls = new List<TopLevelDecl>() { tup.Module };
                PrintTopLevelDecls(prog.Compilation, decls, MutateCSharp.Schemata90.ReplaceNumericConstant_2(132L, 0), tup.Parts, Path.GetFullPath(prog.FullName));
            }
            wr.Flush();
        }

        public void PrintCallGraph(ModuleDefinition module, int indent)
        {
            Contract.Requires(module != null);
            Contract.Requires(0 <= indent);
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_8(137L, () => options.DafnyPrintResolvedFile != null, () => MutateCSharp.Schemata90.ReplaceBinExprOp_12(136L, options.PrintMode, PrintModes.Everything)))
            {
                // print call graph
                Indent(indent); wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(143L, "/* CALL GRAPH for module {0}:"), module.Name);
                var SCCs = module.CallGraph.TopologicallySortedComponents();
                // Sort output SCCs in order of: descending height, then decreasing size of SCC, then alphabetical order of the name of
                // the representative element. By being this specific, we reduce changes in output from minor changes in the code. (With
                // more effort, we could be even more deterministic, if needed in the future.)
                SCCs.Sort((m, n) =>
                {
                    var mm = module.CallGraph.GetSCCRepresentativePredecessorCount(m);
                    var nn = module.CallGraph.GetSCCRepresentativePredecessorCount(n);
                    if (MutateCSharp.Schemata90.ReplaceBinExprOp_13(144L, mm, nn))
                    {
                        return MutateCSharp.Schemata90.ReplaceNumericConstant_2(149L, 1);
                    }
                    else if (MutateCSharp.Schemata90.ReplaceBinExprOp_4(153L, mm, nn))
                    {
                        return MutateCSharp.Schemata90.ReplaceNumericConstant_2(158L, -1);
                    }
                    mm = module.CallGraph.GetSCCSize(m);
                    nn = module.CallGraph.GetSCCSize(n);
                    if (MutateCSharp.Schemata90.ReplaceBinExprOp_13(162L, mm, nn))
                    {
                        return MutateCSharp.Schemata90.ReplaceNumericConstant_2(167L, 1);
                    }
                    else if (MutateCSharp.Schemata90.ReplaceBinExprOp_4(171L, mm, nn))
                    {
                        return MutateCSharp.Schemata90.ReplaceNumericConstant_2(176L, -1);
                    }
                    return string.CompareOrdinal(m.NameRelativeToModule, n.NameRelativeToModule);
                });
                foreach (var callable in SCCs)
                {
                    Indent(indent);
                    wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(180L, " * SCC at height {0}:"), module.CallGraph.GetSCCRepresentativePredecessorCount(callable));
                    var r = module.CallGraph.GetSCC(callable);
                    foreach (var m in r)
                    {
                        Indent(indent);
                        var maybeByMethod = m is Method method && method.IsByMethod ? MutateCSharp.Schemata90.ReplaceStringConstant_1(181L, " (by method)") : "";
                        wr.WriteLine($" *   {m.NameRelativeToModule}{maybeByMethod}");
                    }
                }
                Indent(indent); wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(182L, " */"));
            }
        }

        public void PrintTopLevelDecls(CompilationData compilation, IEnumerable<TopLevelDecl> decls, int indent, IEnumerable<IToken>/*?*/ prefixIds, string fileBeingPrinted)
        {
            Contract.Requires(decls != null);
            int i = MutateCSharp.Schemata90.ReplaceNumericConstant_2(183L, 0);
            foreach (TopLevelDecl d in decls)
            {
                Contract.Assert(d != null);
                if (PrintModeSkipGeneral(d.tok, fileBeingPrinted)) { continue; }
                if (d is AbstractTypeDecl)
                {
                    var at = (AbstractTypeDecl)d;
                    if (MutateCSharp.Schemata90.ReplaceBinExprOp_15(192L, MutateCSharp.Schemata90.ReplacePostfixUnaryExprOp_14(187L, ref i), MutateCSharp.Schemata90.ReplaceNumericConstant_2(188L, 0))) { wr.WriteLine(); }
                    Indent(indent);
                    PrintClassMethodHelper(MutateCSharp.Schemata90.ReplaceStringConstant_1(197L, "type"), at.Attributes, at.Name + TPCharacteristicsSuffix(at.Characteristics), d.TypeArgs);
                    PrintExtendsClause(at);
                    if (MutateCSharp.Schemata90.ReplaceBinExprOp_6(202L, at.Members.Count, MutateCSharp.Schemata90.ReplaceNumericConstant_2(198L, 0)))
                    {
                        wr.WriteLine();
                    }
                    else
                    {
                        wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(207L, " {"));
                        PrintMembers(at.Members, MutateCSharp.Schemata90.ReplaceBinExprOp_16(208L, indent, IndentAmount), fileBeingPrinted);
                        Indent(indent);
                        wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(217L, "}"));
                    }
                }
                else if (d is NewtypeDecl)
                {
                    var dd = (NewtypeDecl)d;
                    if (MutateCSharp.Schemata90.ReplaceBinExprOp_15(223L, MutateCSharp.Schemata90.ReplacePostfixUnaryExprOp_14(218L, ref i), MutateCSharp.Schemata90.ReplaceNumericConstant_2(219L, 0))) { wr.WriteLine(); }
                    Indent(indent);
                    PrintClassMethodHelper(MutateCSharp.Schemata90.ReplaceStringConstant_1(228L, "newtype"), dd.Attributes, dd.Name, new List<TypeParameter>());
                    PrintExtendsClause(dd);
                    wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(229L, " = "));
                    if (MutateCSharp.Schemata90.ReplaceBinExprOp_17(230L, dd.Var, null))
                    {
                        PrintType(dd.BaseType);
                        wr.WriteLine();
                    }
                    else
                    {
                        wr.Write(dd.Var.DisplayName);
                        if (ShowType(dd.Var.Type))
                        {
                            wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(231L, ": "));
                            PrintType(dd.BaseType);
                        }
                        wr.WriteLine();
                        Indent(MutateCSharp.Schemata90.ReplaceBinExprOp_16(232L, indent, IndentAmount));
                        wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(241L, "| "));
                        PrintExpression(dd.Constraint, MutateCSharp.Schemata90.ReplaceBooleanConstant_0(242L, true));
                        wr.WriteLine();
                        if (MutateCSharp.Schemata90.ReplaceBinExprOp_18(243L, dd.WitnessKind, SubsetTypeDecl.WKind.CompiledZero))
                        {
                            Indent(MutateCSharp.Schemata90.ReplaceBinExprOp_16(244L, indent, IndentAmount));
                            PrintWitnessClause(dd);
                            wr.WriteLine();
                        }
                    }
                    if (MutateCSharp.Schemata90.ReplaceBinExprOp_15(257L, dd.Members.Count, MutateCSharp.Schemata90.ReplaceNumericConstant_2(253L, 0)))
                    {
                        Indent(indent);
                        wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(262L, "{"));
                        PrintMembers(dd.Members, MutateCSharp.Schemata90.ReplaceBinExprOp_16(263L, indent, IndentAmount), fileBeingPrinted);
                        Indent(indent);
                        wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(272L, "}"));
                    }
                }
                else if (d is SubsetTypeDecl subsetTypeDecl)
                {
                    if (MutateCSharp.Schemata90.ReplaceBinExprOp_15(278L, MutateCSharp.Schemata90.ReplacePostfixUnaryExprOp_14(273L, ref i), MutateCSharp.Schemata90.ReplaceNumericConstant_2(274L, 0))) { wr.WriteLine(); }

                    PrintSubsetTypeDecl(subsetTypeDecl, indent);
                }
                else if (d is TypeSynonymDecl)
                {
                    var dd = (TypeSynonymDecl)d;
                    if (MutateCSharp.Schemata90.ReplaceBinExprOp_15(288L, MutateCSharp.Schemata90.ReplacePostfixUnaryExprOp_14(283L, ref i), MutateCSharp.Schemata90.ReplaceNumericConstant_2(284L, 0))) { wr.WriteLine(); }
                    Indent(indent);
                    PrintClassMethodHelper(MutateCSharp.Schemata90.ReplaceStringConstant_1(293L, "type"), dd.Attributes, dd.Name + TPCharacteristicsSuffix(dd.Characteristics), dd.TypeArgs);
                    wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(294L, " = "));
                    PrintType(dd.Rhs);
                    wr.WriteLine();
                }
                else if (d is DatatypeDecl)
                {
                    var dd = (DatatypeDecl)d;
                    if (MutateCSharp.Schemata90.ReplaceBinExprOp_15(300L, MutateCSharp.Schemata90.ReplacePostfixUnaryExprOp_14(295L, ref i), MutateCSharp.Schemata90.ReplaceNumericConstant_2(296L, 0))) { wr.WriteLine(); }
                    PrintDatatype(dd, indent, fileBeingPrinted);
                }
                else if (d is IteratorDecl)
                {
                    var iter = (IteratorDecl)d;
                    if (MutateCSharp.Schemata90.ReplaceBinExprOp_15(310L, MutateCSharp.Schemata90.ReplacePostfixUnaryExprOp_14(305L, ref i), MutateCSharp.Schemata90.ReplaceNumericConstant_2(306L, 0))) { wr.WriteLine(); }
                    PrintIteratorSignature(iter, indent);

                    if (MutateCSharp.Schemata90.ReplaceBinExprOp_19(315L, iter.Body, null))
                    {
                        Indent(indent);
                        PrintStatement(iter.Body, indent);
                        wr.WriteLine();
                    }

                    if (afterResolver)
                    {
                        // also print the members that were created as part of the interpretation of the iterator
                        Contract.Assert(iter.Members.Count != 0);  // filled in during resolution
                        Indent(indent); wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(316L, "/*---------- iterator members ----------"));
                        Indent(indent); PrintIteratorClass(iter, indent, fileBeingPrinted);
                        Indent(indent); wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(317L, "---------- iterator members ----------*/"));
                    }

                }
                else if (d is DefaultClassDecl defaultClassDecl)
                {
                    if (MutateCSharp.Schemata90.ReplaceBinExprOp_6(322L, defaultClassDecl.Members.Count, MutateCSharp.Schemata90.ReplaceNumericConstant_2(318L, 0)))
                    {
                        // print nothing
                    }
                    else
                    {
                        if (MutateCSharp.Schemata90.ReplaceBinExprOp_15(332L, MutateCSharp.Schemata90.ReplacePostfixUnaryExprOp_14(327L, ref i), MutateCSharp.Schemata90.ReplaceNumericConstant_2(328L, 0))) { wr.WriteLine(); }
                        PrintMembers(defaultClassDecl.Members, indent, fileBeingPrinted);
                    }
                }
                else if (d is ClassLikeDecl)
                {
                    var cl = (ClassLikeDecl)d;
                    if (MutateCSharp.Schemata90.ReplaceBinExprOp_15(342L, MutateCSharp.Schemata90.ReplacePostfixUnaryExprOp_14(337L, ref i), MutateCSharp.Schemata90.ReplaceNumericConstant_2(338L, 0))) { wr.WriteLine(); }
                    PrintClass(cl, indent, fileBeingPrinted);

                }
                else if (d is ClassLikeDecl)
                {
                    var cl = (ClassLikeDecl)d;
                    if (MutateCSharp.Schemata90.ReplaceBinExprOp_15(352L, MutateCSharp.Schemata90.ReplacePostfixUnaryExprOp_14(347L, ref i), MutateCSharp.Schemata90.ReplaceNumericConstant_2(348L, 0))) { wr.WriteLine(); }
                    PrintClass(cl, indent, fileBeingPrinted);

                }
                else if (d is ValuetypeDecl)
                {
                    var vtd = (ValuetypeDecl)d;
                    if (MutateCSharp.Schemata90.ReplaceBinExprOp_15(362L, MutateCSharp.Schemata90.ReplacePostfixUnaryExprOp_14(357L, ref i), MutateCSharp.Schemata90.ReplaceNumericConstant_2(358L, 0))) { wr.WriteLine(); }
                    Indent(indent);
                    PrintClassMethodHelper(MutateCSharp.Schemata90.ReplaceStringConstant_1(367L, "type"), vtd.Attributes, vtd.Name, vtd.TypeArgs);
                    if (MutateCSharp.Schemata90.ReplaceBinExprOp_6(372L, vtd.Members.Count, MutateCSharp.Schemata90.ReplaceNumericConstant_2(368L, 0)))
                    {
                        wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(377L, " { }"));
                    }
                    else
                    {
                        wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(378L, " {"));
                        PrintMembers(vtd.Members, MutateCSharp.Schemata90.ReplaceBinExprOp_16(379L, indent, IndentAmount), fileBeingPrinted);
                        Indent(indent);
                        wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(388L, "}"));
                    }

                }
                else if (d is ModuleDecl md)
                {
                    wr.WriteLine();
                    Indent(indent);
                    if (d is LiteralModuleDecl modDecl)
                    {
                        if (MutateCSharp.Schemata90.ReplaceBinExprOp_8(390L, () => MutateCSharp.Schemata90.ReplaceBinExprOp_12(389L, printMode, PrintModes.Serialization), () => !modDecl.ModuleDef.ShouldCompile(compilation)))
                        {
                            // This mode is used to losslessly serialize the source program by the C# and Library backends.
                            // Backends don't compile any code for modules not marked for compilation,
                            // so it's consistent to skip those modules here too. 
                            continue;
                        }

                        VisibilityScope scope = null;
                        if (MutateCSharp.Schemata90.ReplaceBinExprOp_20(396L, modDecl.Signature, null))
                        {
                            scope = modDecl.Signature.VisibilityScope;
                        }
                        PrintModuleDefinition(compilation, modDecl.ModuleDef, scope, indent, prefixIds, fileBeingPrinted);
                    }
                    else if (d is AliasModuleDecl)
                    {
                        var dd = (AliasModuleDecl)d;

                        wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(397L, "import"));
                        if (dd.Opened)
                        {
                            wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(398L, " opened"));
                        }
                        wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(399L, " {0}"), dd.Name);
                        if (MutateCSharp.Schemata90.ReplaceBinExprOp_21(400L, dd.Name, dd.TargetQId.ToString()))
                        {
                            wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(401L, " = {0}"), dd.TargetQId.ToString());
                        }
                        if (MutateCSharp.Schemata90.ReplaceBinExprOp_6(406L, dd.Exports.Count, MutateCSharp.Schemata90.ReplaceNumericConstant_2(402L, 1)))
                        {
                            wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(411L, "`{0}"), dd.Exports[MutateCSharp.Schemata90.ReplaceNumericConstant_2(412L, 0)].val);
                        }
                        if (MutateCSharp.Schemata90.ReplaceBinExprOp_4(420L, dd.Exports.Count, MutateCSharp.Schemata90.ReplaceNumericConstant_2(416L, 1)))
                        {
                            wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(425L, "`{{{0}}}"), Util.Comma(dd.Exports, id => id.val));
                        }
                        wr.WriteLine();
                    }
                    else if (d is AbstractModuleDecl)
                    {
                        var dd = (AbstractModuleDecl)d;

                        wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(426L, "import"));
                        if (dd.Opened)
                        {
                            wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(427L, " opened"));
                        }
                        wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(428L, " {0} "), dd.Name);
                        wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(429L, ": {0}"), dd.QId.ToString());
                        if (MutateCSharp.Schemata90.ReplaceBinExprOp_4(434L, dd.Exports.Count, MutateCSharp.Schemata90.ReplaceNumericConstant_2(430L, 0)))
                        {
                            wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(439L, "`{{{0}}}"), Util.Comma(dd.Exports, id => id.val));
                        }
                        wr.WriteLine();

                    }
                    else if (d is ModuleExportDecl)
                    {
                        ModuleExportDecl e = (ModuleExportDecl)d;
                        if (!e.IsDefault)
                        {
                            wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(440L, "export {0}"), e.Name);
                        }
                        else
                        {
                            wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(441L, "export"));
                        }

                        if (e.IsRefining)
                        {
                            wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(442L, " ..."));
                        }
                        if (MutateCSharp.Schemata90.ReplaceBinExprOp_4(447L, e.Extends.Count, MutateCSharp.Schemata90.ReplaceNumericConstant_2(443L, 0)))
                        {
                            wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(452L, " extends {0}"), Util.Comma(e.Extends, id => id.val));
                        }

                        wr.WriteLine();
                        PrintModuleExportDecl(compilation, e, MutateCSharp.Schemata90.ReplaceBinExprOp_16(453L, indent, IndentAmount), fileBeingPrinted);
                        wr.WriteLine();
                    }
                    else
                    {
                        Contract.Assert(false); // unexpected ModuleDecl
                    }
                }
                else
                {
                    Contract.Assert(false); // unexpected TopLevelDecl
                }
            }
        }

        private void PrintSubsetTypeDecl(SubsetTypeDecl dd, int indent)
        {
            Indent(indent);
            PrintClassMethodHelper(MutateCSharp.Schemata90.ReplaceStringConstant_1(462L, "type"), dd.Attributes, dd.Name + TPCharacteristicsSuffix(dd.Characteristics), dd.TypeArgs);
            wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(463L, " = "));
            wr.Write(dd.Var.DisplayName);
            if (ShowType(dd.Var.Type))
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(464L, ": "));
                PrintType(dd.Rhs);
            }

            if (dd is NonNullTypeDecl)
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(465L, " "));
            }
            else
            {
                wr.WriteLine();
                Indent(MutateCSharp.Schemata90.ReplaceBinExprOp_16(466L, indent, IndentAmount));
            }

            wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(475L, "| "));
            PrintExpression(dd.Constraint, MutateCSharp.Schemata90.ReplaceBooleanConstant_0(476L, true));
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_18(477L, dd.WitnessKind, SubsetTypeDecl.WKind.CompiledZero))
            {
                if (dd is NonNullTypeDecl)
                {
                    wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(478L, " "));
                }
                else
                {
                    wr.WriteLine();
                    Indent(MutateCSharp.Schemata90.ReplaceBinExprOp_16(479L, indent, IndentAmount));
                }

                PrintWitnessClause(dd);
            }

            wr.WriteLine();
        }

        private void PrintWitnessClause(RedirectingTypeDecl dd)
        {
            Contract.Requires(dd != null);
            Contract.Requires(dd.WitnessKind != SubsetTypeDecl.WKind.CompiledZero);

            switch (dd.WitnessKind)
            {
                case SubsetTypeDecl.WKind.Ghost:
                    wr.Write("ghost ");
                    goto case SubsetTypeDecl.WKind.Compiled;
                    break;
                case SubsetTypeDecl.WKind.Compiled:
                    wr.Write("witness ");
                    PrintExpression(dd.Witness, true);
                    break;
                    break;
                case SubsetTypeDecl.WKind.OptOut:
                    wr.Write("witness *");
                    break;
                    break;
                case SubsetTypeDecl.WKind.Special:
                    wr.Write("/*special witness*/");
                    break;
                    break;
                case SubsetTypeDecl.WKind.CompiledZero:
                default:
                    Contract.Assert(false);  // unexpected WKind
                    break;
                    break;
            }
        }

        void PrintModuleExportDecl(CompilationData compilation, ModuleExportDecl m, int indent, string fileBeingPrinted)
        {
            Contract.Requires(m != null);

            if (m.RevealAll)
            {
                Indent(indent);
                wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(488L, "reveals *"));
            }
            if (m.ProvideAll)
            {
                Indent(indent);
                wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(489L, "provides *"));
            }
            var i = MutateCSharp.Schemata90.ReplaceNumericConstant_2(490L, 0);
            while (MutateCSharp.Schemata90.ReplaceBinExprOp_13(494L, i, m.Exports.Count))
            {
                var start = i;
                var bodyKind = m.Exports[start].Opaque;
                do
                {
                    MutateCSharp.Schemata90.ReplacePostfixUnaryExprOp_14(499L, ref i);
                } while (MutateCSharp.Schemata90.ReplaceBinExprOp_8(511L, () => MutateCSharp.Schemata90.ReplaceBinExprOp_13(500L, i, m.Exports.Count), () => MutateCSharp.Schemata90.ReplaceBinExprOp_22(505L, () => m.Exports[i].Opaque, () => bodyKind)));
                // print [start..i)
                Indent(indent);
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(517L, "{0} "), bodyKind ? MutateCSharp.Schemata90.ReplaceStringConstant_1(518L, "provides") : MutateCSharp.Schemata90.ReplaceStringConstant_1(519L, "reveals"));
                wr.WriteLine(Util.Comma(MutateCSharp.Schemata90.ReplaceBinExprOp_5(520L, i, start), j => m.Exports[MutateCSharp.Schemata90.ReplaceBinExprOp_16(529L, start, j)].ToString()));

                if (options.DafnyPrintResolvedFile != null)
                {
                    Contract.Assert(!printingExportSet);
                    printingExportSet = MutateCSharp.Schemata90.ReplaceBooleanConstant_0(538L, true);
                    Indent(indent);
                    wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(539L, "/*----- exported view:"));
                    for (int j = start; MutateCSharp.Schemata90.ReplaceBinExprOp_13(540L, j, i); MutateCSharp.Schemata90.ReplacePostfixUnaryExprOp_14(545L, ref j))
                    {
                        var id = m.Exports[j];
                        if (id.Decl is TopLevelDecl)
                        {
                            PrintTopLevelDecls(compilation, new List<TopLevelDecl> { (TopLevelDecl)id.Decl }, MutateCSharp.Schemata90.ReplaceBinExprOp_16(546L, indent, IndentAmount), null, fileBeingPrinted);
                        }
                        else if (id.Decl is MemberDecl)
                        {
                            PrintMembers(new List<MemberDecl> { (MemberDecl)id.Decl }, MutateCSharp.Schemata90.ReplaceBinExprOp_16(555L, indent, IndentAmount), fileBeingPrinted);
                        }
                    }
                    Indent(indent);
                    wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(564L, "-----*/"));
                    Contract.Assert(printingExportSet);
                    printingExportSet = MutateCSharp.Schemata90.ReplaceBooleanConstant_0(565L, false);
                }
            }
        }

        public void PrintModuleDefinition(CompilationData compilation, ModuleDefinition module, VisibilityScope scope, int indent, IEnumerable<IToken>/*?*/ prefixIds, string fileBeingPrinted)
        {
            Contract.Requires(module != null);
            Contract.Requires(0 <= indent);
            Type.PushScope(scope);
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_23(566L, module.ModuleKind, ModuleKindEnum.Abstract))
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(567L, "abstract "));
            }
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_23(568L, module.ModuleKind, ModuleKindEnum.Replaceable))
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(569L, "replaceable "));
            }
            wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(570L, "module"));
            PrintAttributes(module.Attributes);
            wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(571L, " "));
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_24(572L, prefixIds, null))
            {
                foreach (var p in prefixIds)
                {
                    wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(573L, "{0}."), p.val);
                }
            }
            wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(574L, "{0} "), module.Name);
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_25(575L, module.Implements, null))
            {
                var kindString = module.Implements.Kind switch
                {
                    ImplementationKind.Refinement => MutateCSharp.Schemata90.ReplaceStringConstant_1(576L, "refines"),
                    ImplementationKind.Replacement => MutateCSharp.Schemata90.ReplaceStringConstant_1(577L, "replaces"),
                    _ => throw new ArgumentOutOfRangeException()
                };
                wr.Write($"{kindString} {module.Implements.Target} ");
            }
            if (!module.TopLevelDecls.Any())
            {
                wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(578L, "{ }"));
            }
            else
            {
                wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(579L, "{"));
                PrintCallGraph(module, MutateCSharp.Schemata90.ReplaceBinExprOp_16(580L, indent, IndentAmount));
                PrintTopLevelDeclsOrExportedView(compilation, module, indent, fileBeingPrinted);
                Indent(indent);
                wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(589L, "}"));
            }
            Type.PopScope(scope);
        }

        void PrintTopLevelDeclsOrExportedView(CompilationData compilation, ModuleDefinition module, int indent, string fileBeingPrinted)
        {
            var decls = module.TopLevelDecls;
            // only filter based on view name after resolver.
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_8(599L, () => afterResolver, () => MutateCSharp.Schemata90.ReplaceBinExprOp_15(594L, options.DafnyPrintExportedViews.Count, MutateCSharp.Schemata90.ReplaceNumericConstant_2(590L, 0))))
            {
                var views = options.DafnyPrintExportedViews.ToHashSet();
                decls = decls.Where(d => views.Contains(d.FullName));
            }
            PrintTopLevelDecls(compilation, decls, MutateCSharp.Schemata90.ReplaceBinExprOp_16(605L, indent, IndentAmount), null, fileBeingPrinted);
            foreach (var tup in module.PrefixNamedModules)
            {
                PrintTopLevelDecls(compilation, new TopLevelDecl[] { tup.Module }, MutateCSharp.Schemata90.ReplaceBinExprOp_16(614L, indent, IndentAmount), tup.Parts, fileBeingPrinted);
            }
        }

        void PrintIteratorSignature(IteratorDecl iter, int indent)
        {
            Indent(indent);
            PrintClassMethodHelper(MutateCSharp.Schemata90.ReplaceStringConstant_1(623L, "iterator"), iter.Attributes, iter.Name, iter.TypeArgs);
            if (iter.IsRefining)
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(624L, " ..."));
            }
            else
            {
                PrintFormals(iter.Ins, iter);
                if (MutateCSharp.Schemata90.ReplaceBinExprOp_15(629L, iter.Outs.Count, MutateCSharp.Schemata90.ReplaceNumericConstant_2(625L, 0)))
                {
                    if (MutateCSharp.Schemata90.ReplaceBinExprOp_26(647L, MutateCSharp.Schemata90.ReplaceBinExprOp_16(634L, iter.Ins.Count, iter.Outs.Count), MutateCSharp.Schemata90.ReplaceNumericConstant_2(643L, 3)))
                    {
                        wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(652L, " yields "));
                    }
                    else
                    {
                        wr.WriteLine();
                        Indent(MutateCSharp.Schemata90.ReplaceBinExprOp_16(666L, indent, MutateCSharp.Schemata90.ReplaceBinExprOp_27(657L, MutateCSharp.Schemata90.ReplaceNumericConstant_2(653L, 2), IndentAmount)));
                        wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(675L, "yields "));
                    }
                    PrintFormals(iter.Outs, iter);
                }
            }

            int ind = MutateCSharp.Schemata90.ReplaceBinExprOp_16(676L, indent, IndentAmount);
            PrintSpec(MutateCSharp.Schemata90.ReplaceStringConstant_1(685L, "requires"), iter.Requires, ind);
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_28(686L, iter.Reads.Expressions, null))
            {
                PrintFrameSpecLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(687L, "reads"), iter.Reads, ind);
            }
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_28(688L, iter.Modifies.Expressions, null))
            {
                PrintFrameSpecLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(689L, "modifies"), iter.Modifies, ind);
            }
            PrintSpec(MutateCSharp.Schemata90.ReplaceStringConstant_1(690L, "yield requires"), iter.YieldRequires, ind);
            PrintSpec(MutateCSharp.Schemata90.ReplaceStringConstant_1(691L, "yield ensures"), iter.YieldEnsures, ind);
            PrintSpec(MutateCSharp.Schemata90.ReplaceStringConstant_1(692L, "ensures"), iter.Ensures, ind);
            PrintDecreasesSpec(iter.Decreases, ind);
            wr.WriteLine();
        }

        private void PrintIteratorClass(IteratorDecl iter, int indent, string fileBeingPrinted)
        {
            PrintClassMethodHelper(MutateCSharp.Schemata90.ReplaceStringConstant_1(693L, "class"), null, iter.Name, iter.TypeArgs);
            wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(694L, " {"));
            PrintMembers(iter.Members, MutateCSharp.Schemata90.ReplaceBinExprOp_16(695L, indent, IndentAmount), fileBeingPrinted);
            Indent(indent); wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(704L, "}"));

            Contract.Assert(iter.NonNullTypeDecl != null);
            PrintSubsetTypeDecl(iter.NonNullTypeDecl, indent);
        }

        public void PrintClass(ClassLikeDecl c, int indent, string fileBeingPrinted)
        {
            Contract.Requires(c != null);

            Indent(indent);
            PrintClassMethodHelper((c is TraitDecl) ? MutateCSharp.Schemata90.ReplaceStringConstant_1(705L, "trait") : MutateCSharp.Schemata90.ReplaceStringConstant_1(706L, "class"), c.Attributes, c.Name, c.TypeArgs);
            if (c.IsRefining)
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(707L, " ..."));
            }
            else
            {
                PrintExtendsClause(c);
            }

            if (MutateCSharp.Schemata90.ReplaceBinExprOp_6(712L, c.Members.Count, MutateCSharp.Schemata90.ReplaceNumericConstant_2(708L, 0)))
            {
                wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(717L, " { }"));
            }
            else
            {
                wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(718L, " {"));
                PrintMembers(c.Members, MutateCSharp.Schemata90.ReplaceBinExprOp_16(719L, indent, IndentAmount), fileBeingPrinted);
                Indent(indent);
                wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(728L, "}"));
            }

            if (MutateCSharp.Schemata90.ReplaceBinExprOp_8(730L, () => options.DafnyPrintResolvedFile != null, () => MutateCSharp.Schemata90.ReplaceBinExprOp_29(729L, c.NonNullTypeDecl, null)))
            {
                if (!printingExportSet)
                {
                    Indent(indent); wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(736L, "/*-- non-null type"));
                }
                PrintSubsetTypeDecl(c.NonNullTypeDecl, indent);
                if (!printingExportSet)
                {
                    Indent(indent); wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(737L, "*/"));
                }
            }
        }

        private void PrintExtendsClause(TopLevelDeclWithMembers c)
        {
            string sep = MutateCSharp.Schemata90.ReplaceStringConstant_1(738L, " extends ");
            foreach (var trait in c.ParentTraits)
            {
                wr.Write(sep);
                PrintType(trait);
                sep = MutateCSharp.Schemata90.ReplaceStringConstant_1(739L, ", ");
            }
        }

        public void PrintMembers(List<MemberDecl> members, int indent, string fileBeingPrinted)
        {
            Contract.Requires(members != null);

            int state = MutateCSharp.Schemata90.ReplaceNumericConstant_2(740L, 0);  // 0 - no members yet; 1 - previous member was a field; 2 - previous member was non-field
            foreach (MemberDecl m in members)
            {
                if (PrintModeSkipGeneral(m.tok, fileBeingPrinted)) { continue; }
                if (MutateCSharp.Schemata90.ReplaceBinExprOp_8(746L, () => MutateCSharp.Schemata90.ReplaceBinExprOp_12(744L, printMode, PrintModes.Serialization), () => Attributes.Contains(m.Attributes, MutateCSharp.Schemata90.ReplaceStringConstant_1(745L, "auto_generated"))))
                {
                    // omit this declaration
                }
                else if (m is Method)
                {
                    if (MutateCSharp.Schemata90.ReplaceBinExprOp_15(756L, state, MutateCSharp.Schemata90.ReplaceNumericConstant_2(752L, 0))) { wr.WriteLine(); }
                    PrintMethod((Method)m, indent, MutateCSharp.Schemata90.ReplaceBooleanConstant_0(761L, false));
                    var com = m as ExtremeLemma;
                    if (MutateCSharp.Schemata90.ReplaceBinExprOp_8(764L, () => MutateCSharp.Schemata90.ReplaceBinExprOp_30(762L, com, null), () => MutateCSharp.Schemata90.ReplaceBinExprOp_31(763L, com.PrefixLemma, null)))
                    {
                        Indent(indent); wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(770L, "/***"));
                        PrintMethod(com.PrefixLemma, indent, MutateCSharp.Schemata90.ReplaceBooleanConstant_0(771L, false));
                        Indent(indent); wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(772L, "***/"));
                    }
                    state = MutateCSharp.Schemata90.ReplaceNumericConstant_2(773L, 2);
                }
                else if (m is Field)
                {
                    if (MutateCSharp.Schemata90.ReplaceBinExprOp_6(781L, state, MutateCSharp.Schemata90.ReplaceNumericConstant_2(777L, 2))) { wr.WriteLine(); }
                    PrintField((Field)m, indent);
                    state = MutateCSharp.Schemata90.ReplaceNumericConstant_2(786L, 1);
                }
                else if (m is Function)
                {
                    if (MutateCSharp.Schemata90.ReplaceBinExprOp_15(794L, state, MutateCSharp.Schemata90.ReplaceNumericConstant_2(790L, 0))) { wr.WriteLine(); }
                    PrintFunction((Function)m, indent, MutateCSharp.Schemata90.ReplaceBooleanConstant_0(799L, false));
                    if (m is ExtremePredicate fixp && MutateCSharp.Schemata90.ReplaceBinExprOp_32(800L, fixp.PrefixPredicate, null))
                    {
                        Indent(indent); wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(801L, "/*** (note, what is printed here does not show substitutions of calls to prefix predicates)"));
                        PrintFunction(fixp.PrefixPredicate, indent, MutateCSharp.Schemata90.ReplaceBooleanConstant_0(802L, false));
                        Indent(indent); wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(803L, "***/"));
                    }
                    state = MutateCSharp.Schemata90.ReplaceNumericConstant_2(804L, 2);
                }
                else
                {
                    Contract.Assert(false); throw new cce.UnreachableException();  // unexpected member
                }
            }
        }

        /// <summary>
        /// Prints no space before "kind", but does print a space before "attrs" and "name".
        /// </summary>
        void PrintClassMethodHelper(string kind, Attributes attrs, string name, List<TypeParameter> typeArgs)
        {
            Contract.Requires(kind != null);
            Contract.Requires(name != null);
            Contract.Requires(typeArgs != null);

            wr.Write(kind);
            PrintAttributes(attrs);

            if (ArrowType.IsArrowTypeName(name))
            {
                PrintArrowType(ArrowType.ANY_ARROW, name, typeArgs);
            }
            else if (ArrowType.IsPartialArrowTypeName(name))
            {
                PrintArrowType(ArrowType.PARTIAL_ARROW, name, typeArgs);
            }
            else if (ArrowType.IsTotalArrowTypeName(name))
            {
                PrintArrowType(ArrowType.TOTAL_ARROW, name, typeArgs);
            }
            else if (SystemModuleManager.IsTupleTypeName(name))
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(808L, " /*{0}*/ ({1})"), name, Util.Comma(typeArgs, TypeParamString));
            }
            else
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(809L, " {0}"), name);
                PrintTypeParams(typeArgs);
            }
        }

        private void PrintTypeParams(List<TypeParameter> typeArgs)
        {
            Contract.Requires(typeArgs != null);
            Contract.Requires(
              typeArgs.All(tp => tp.Name.StartsWith("_")) ||
              typeArgs.All(tp => !tp.Name.StartsWith("_")));

            if (MutateCSharp.Schemata90.ReplaceBinExprOp_8(824L, () => MutateCSharp.Schemata90.ReplaceBinExprOp_15(814L, typeArgs.Count, MutateCSharp.Schemata90.ReplaceNumericConstant_2(810L, 0)), () => !typeArgs[MutateCSharp.Schemata90.ReplaceNumericConstant_2(819L, 0)].Name.StartsWith(MutateCSharp.Schemata90.ReplaceStringConstant_1(823L, "_"))))
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(830L, "<{0}>"), Util.Comma(typeArgs, TypeParamString));
            }
        }

        public string TypeParamString(TypeParameter tp)
        {
            Contract.Requires(tp != null);
            string variance;
            switch (tp.VarianceSyntax)
            {
                case TypeParameter.TPVarianceSyntax.Covariant_Permissive:
                    variance = "*";
                    break;
                    break;
                case TypeParameter.TPVarianceSyntax.Covariant_Strict:
                    variance = "+";
                    break;
                    break;
                case TypeParameter.TPVarianceSyntax.NonVariant_Permissive:
                    variance = "!";
                    break;
                    break;
                case TypeParameter.TPVarianceSyntax.NonVariant_Strict:
                    variance = "";
                    break;
                    break;
                case TypeParameter.TPVarianceSyntax.Contravariance:
                    variance = "-";
                    break;
                    break;
                default:
                    Contract.Assert(false);  // unexpected VarianceSyntax
                    throw new cce.UnreachableException();
                    break;
            }
            return variance + tp.Name + TPCharacteristicsSuffix(tp.Characteristics);
        }

        private void PrintArrowType(string arrow, string internalName, List<TypeParameter> typeArgs)
        {
            Contract.Requires(arrow != null);
            Contract.Requires(internalName != null);
            Contract.Requires(typeArgs != null);
            Contract.Requires(1 <= typeArgs.Count);  // argument list ends with the result type
            wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(831L, " /*{0}*/ "), internalName);
            int arity = MutateCSharp.Schemata90.ReplaceBinExprOp_5(836L, typeArgs.Count, MutateCSharp.Schemata90.ReplaceNumericConstant_2(832L, 1));
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_15(849L, arity, MutateCSharp.Schemata90.ReplaceNumericConstant_2(845L, 1)))
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(854L, "("));
            }
            wr.Write(Util.Comma(arity, i => TypeParamString(typeArgs[i])));
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_15(859L, arity, MutateCSharp.Schemata90.ReplaceNumericConstant_2(855L, 1)))
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(864L, ")"));
            }
            wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(865L, " {0} {1}"), arrow, TypeParamString(typeArgs[arity]));
        }

        private void PrintTypeInstantiation(List<Type> typeArgs)
        {
            Contract.Requires(typeArgs == null || typeArgs.Count != 0);
            wr.Write(Type.TypeArgsToString(options, typeArgs));
        }

        public void PrintDatatype(DatatypeDecl dt, int indent, string fileBeingPrinted)
        {
            Contract.Requires(dt != null);
            Indent(indent);
            PrintClassMethodHelper(dt is IndDatatypeDecl ? MutateCSharp.Schemata90.ReplaceStringConstant_1(866L, "datatype") : MutateCSharp.Schemata90.ReplaceStringConstant_1(867L, "codatatype"), dt.Attributes, dt.Name, dt.TypeArgs);
            PrintExtendsClause(dt);
            wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(868L, " ="));
            string sep = "";
            foreach (DatatypeCtor ctor in dt.Ctors)
            {
                wr.Write(sep);
                PrintClassMethodHelper(ctor.IsGhost ? MutateCSharp.Schemata90.ReplaceStringConstant_1(869L, " ghost") : "", ctor.Attributes, ctor.Name, new List<TypeParameter>());
                if (MutateCSharp.Schemata90.ReplaceBinExprOp_15(874L, ctor.Formals.Count, MutateCSharp.Schemata90.ReplaceNumericConstant_2(870L, 0)))
                {
                    PrintFormals(ctor.Formals, null);
                }
                sep = MutateCSharp.Schemata90.ReplaceStringConstant_1(879L, " |");
            }
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_6(884L, dt.Members.Count, MutateCSharp.Schemata90.ReplaceNumericConstant_2(880L, 0)))
            {
                wr.WriteLine();
            }
            else
            {
                wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(889L, " {"));
                PrintMembers(dt.Members, MutateCSharp.Schemata90.ReplaceBinExprOp_16(890L, indent, IndentAmount), fileBeingPrinted);
                Indent(indent);
                wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(899L, "}"));
            }
        }

        /// <summary>
        /// Prints a space before each attribute.
        /// </summary>
        public void PrintAttributes(Attributes a)
        {
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_33(900L, a, null))
            {
                PrintAttributes(a.Prev);
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(901L, " "));
                PrintOneAttribute(a);
            }
        }
        public void PrintOneAttribute(Attributes a, string nameSubstitution = null)
        {
            Contract.Requires(a != null);
            var name = nameSubstitution ?? a.Name;
            var usAttribute = MutateCSharp.Schemata90.ReplaceBinExprOp_7(911L, () => name.StartsWith(MutateCSharp.Schemata90.ReplaceStringConstant_1(902L, "_")), () => (MutateCSharp.Schemata90.ReplaceBinExprOp_8(905L, () => options.DisallowExterns, () => MutateCSharp.Schemata90.ReplaceBinExprOp_34(904L, name, MutateCSharp.Schemata90.ReplaceStringConstant_1(903L, "extern")))));
            wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(917L, "{1}{{:{0}"), name, usAttribute ? MutateCSharp.Schemata90.ReplaceStringConstant_1(918L, "/*") : "");
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_35(919L, a.Args, null))
            {
                PrintAttributeArgs(a.Args, MutateCSharp.Schemata90.ReplaceBooleanConstant_0(920L, false));
            }
            wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(921L, "}}{0}"), usAttribute ? MutateCSharp.Schemata90.ReplaceStringConstant_1(922L, "*/") : "");

        }

        public void PrintAttributeArgs(List<Expression> args, bool isFollowedBySemicolon)
        {
            Contract.Requires(args != null);
            string prefix = MutateCSharp.Schemata90.ReplaceStringConstant_1(923L, " ");
            foreach (var arg in args)
            {
                Contract.Assert(arg != null);
                wr.Write(prefix);
                prefix = MutateCSharp.Schemata90.ReplaceStringConstant_1(924L, ", ");
                PrintExpression(arg, isFollowedBySemicolon);
            }
        }

        public void PrintField(Field field, int indent)
        {
            Contract.Requires(field != null);
            Indent(indent);
            if (field.HasStaticKeyword)
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(925L, "static "));
            }
            if (field.IsGhost)
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(926L, "ghost "));
            }
            if (!field.IsMutable)
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(927L, "const"));
            }
            else
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(928L, "var"));
            }
            PrintAttributes(field.Attributes);
            wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(929L, " {0}"), field.Name);
            if (ShowType(field.Type))
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(930L, ": "));
                PrintType(field.Type);
            }
            if (field is ConstantField)
            {
                var c = (ConstantField)field;
                if (MutateCSharp.Schemata90.ReplaceBinExprOp_36(931L, c.Rhs, null))
                {
                    wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(932L, " := "));
                    PrintExpression(c.Rhs, MutateCSharp.Schemata90.ReplaceBooleanConstant_0(933L, true));
                }
            }
            else if (MutateCSharp.Schemata90.ReplaceBinExprOp_8(934L, () => !field.IsUserMutable, () => field.IsMutable))
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(940L, "  // non-assignable"));
            }
            wr.WriteLine();
        }

        public void PrintFunction(Function f, int indent, bool printSignatureOnly)
        {
            Contract.Requires(f != null);

            if (PrintModeSkipFunctionOrMethod(f.IsGhost, f.Attributes, f.Name)) { return; }
            Indent(indent);
            PrintClassMethodHelper(f.GetFunctionDeclarationKeywords(options), f.Attributes, f.Name, f.TypeArgs);
            if (f.SignatureIsOmitted)
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(941L, " ..."));
            }
            else
            {
                if (f is ExtremePredicate)
                {
                    PrintKTypeIndication(((ExtremePredicate)f).TypeOfK);
                }
                PrintFormals(f.Ins, f, f.Name);
                if (MutateCSharp.Schemata90.ReplaceBinExprOp_7(961L, () => MutateCSharp.Schemata90.ReplaceBinExprOp_37(942L, f.Result, null), () => (MutateCSharp.Schemata90.ReplaceBinExprOp_8(955L, () => MutateCSharp.Schemata90.ReplaceBinExprOp_8(949L, () => MutateCSharp.Schemata90.ReplaceBinExprOp_8(943L, () => f is not Predicate, () => f is not ExtremePredicate), () => f is not TwoStatePredicate), () => f is not PrefixPredicate))))
                {
                    wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(967L, ": "));
                    if (MutateCSharp.Schemata90.ReplaceBinExprOp_37(968L, f.Result, null))
                    {
                        wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(969L, "("));
                        PrintFormal(f.Result, MutateCSharp.Schemata90.ReplaceBooleanConstant_0(970L, false));
                        wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(971L, ")"));
                    }
                    else
                    {
                        PrintType(f.ResultType);
                    }
                }
            }

            int ind = MutateCSharp.Schemata90.ReplaceBinExprOp_16(972L, indent, IndentAmount);
            PrintSpec(MutateCSharp.Schemata90.ReplaceStringConstant_1(981L, "requires"), f.Req, ind);
            PrintFrameSpecLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(982L, "reads"), f.Reads, ind);
            PrintSpec(MutateCSharp.Schemata90.ReplaceStringConstant_1(983L, "ensures"), f.Ens, ind);
            PrintDecreasesSpec(f.Decreases, ind);
            wr.WriteLine();
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_8(985L, () => MutateCSharp.Schemata90.ReplaceBinExprOp_36(984L, f.Body, null), () => !printSignatureOnly))
            {
                Indent(indent);
                wr.WriteLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(991L, "{"));
                PrintExtendedExpr(f.Body, ind, MutateCSharp.Schemata90.ReplaceBooleanConstant_0(992L, true), MutateCSharp.Schemata90.ReplaceBooleanConstant_0(993L, false));
                Indent(indent);
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(994L, "}"));
                if (MutateCSharp.Schemata90.ReplaceBinExprOp_19(995L, f.ByMethodBody, null))
                {
                    wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(996L, " by method "));
                    if (MutateCSharp.Schemata90.ReplaceBinExprOp_8(998L, () => options.DafnyPrintResolvedFile != null, () => MutateCSharp.Schemata90.ReplaceBinExprOp_38(997L, f.ByMethodDecl, null)))
                    {
                        Contract.Assert(f.ByMethodDecl.Ens.Count == 1);
                        wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(1004L, "/* ensures"));
                        PrintAttributedExpression(f.ByMethodDecl.Ens[MutateCSharp.Schemata90.ReplaceNumericConstant_2(1005L, 0)]);
                        wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(1009L, " */ "));
                    }
                    PrintStatement(f.ByMethodBody, indent);
                }
                wr.WriteLine();
            }
        }

        // ----------------------------- PrintMethod -----------------------------

        const int IndentAmount = 2; // The amount of indent for each new scope
        void Indent(int amount)
        {
            Contract.Requires(0 <= amount);
            wr.Write(new String(' ', amount));
        }

        private bool PrintModeSkipFunctionOrMethod(bool IsGhost, Attributes attributes, string name)
        {
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_8(1011L, () => MutateCSharp.Schemata90.ReplaceBinExprOp_12(1010L, printMode, PrintModes.NoGhost), () => IsGhost)) { return MutateCSharp.Schemata90.ReplaceBooleanConstant_0(1017L, true); }
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_7(1020L, () => MutateCSharp.Schemata90.ReplaceBinExprOp_12(1018L, printMode, PrintModes.NoIncludes), () => MutateCSharp.Schemata90.ReplaceBinExprOp_12(1019L, printMode, PrintModes.NoGhost)))
            {
                bool verify = MutateCSharp.Schemata90.ReplaceBooleanConstant_0(1026L, true);
                if (Attributes.ContainsBool(attributes, MutateCSharp.Schemata90.ReplaceStringConstant_1(1027L, "verify"), ref verify) && !verify) { return MutateCSharp.Schemata90.ReplaceBooleanConstant_0(1028L, true); }
                if (MutateCSharp.Schemata90.ReplaceBinExprOp_7(1030L, () => name.Contains(MutateCSharp.Schemata90.ReplaceStringConstant_1(1029L, "INTERNAL")), () => name.StartsWith(RevealStmt.RevealLemmaPrefix))) { return MutateCSharp.Schemata90.ReplaceBooleanConstant_0(1036L, true); }
            }
            return MutateCSharp.Schemata90.ReplaceBooleanConstant_0(1037L, false);
        }

        private bool PrintModeSkipGeneral(IToken tok, string fileBeingPrinted)
        {
            return MutateCSharp.Schemata90.ReplaceBinExprOp_8(1060L, () => MutateCSharp.Schemata90.ReplaceBinExprOp_8(1053L, () => MutateCSharp.Schemata90.ReplaceBinExprOp_8(1047L, () => (MutateCSharp.Schemata90.ReplaceBinExprOp_7(1040L, () => MutateCSharp.Schemata90.ReplaceBinExprOp_12(1038L, printMode, PrintModes.NoIncludes), () => MutateCSharp.Schemata90.ReplaceBinExprOp_12(1039L, printMode, PrintModes.NoGhost)))
      , () => MutateCSharp.Schemata90.ReplaceBinExprOp_39(1046L, tok.Uri, null)), () => fileBeingPrinted != null), () => MutateCSharp.Schemata90.ReplaceBinExprOp_21(1059L, tok.Uri.LocalPath, fileBeingPrinted));
        }

        public void PrintMethod(Method method, int indent, bool printSignatureOnly)
        {
            Contract.Requires(method != null);

            if (PrintModeSkipFunctionOrMethod(method.IsGhost, method.Attributes, method.Name)) { return; }
            Indent(indent);
            string k = method is Constructor ? MutateCSharp.Schemata90.ReplaceStringConstant_1(1066L, "constructor") :
              method is LeastLemma ? MutateCSharp.Schemata90.ReplaceStringConstant_1(1067L, "least lemma") :
              method is GreatestLemma ? MutateCSharp.Schemata90.ReplaceStringConstant_1(1068L, "greatest lemma") : MutateCSharp.Schemata90.ReplaceBinExprOp_7(1069L, () => method is Lemma, () => method is PrefixLemma) ? MutateCSharp.Schemata90.ReplaceStringConstant_1(1075L, "lemma") :
              method is TwoStateLemma ? MutateCSharp.Schemata90.ReplaceStringConstant_1(1076L, "twostate lemma") : MutateCSharp.Schemata90.ReplaceStringConstant_1(1077L, "method");
            if (method.HasStaticKeyword) { k = MutateCSharp.Schemata90.ReplaceStringConstant_1(1078L, "static ") + k; }
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_8(1079L, () => method.IsGhost, () => !method.IsLemmaLike))
            {
                k = MutateCSharp.Schemata90.ReplaceStringConstant_1(1085L, "ghost ") + k;
            }
            string nm = MutateCSharp.Schemata90.ReplaceBinExprOp_8(1086L, () => method is Constructor, () => !((Constructor)method).HasName) ? "" : method.Name;
            PrintClassMethodHelper(k, method.Attributes, nm, method.TypeArgs);
            if (method.SignatureIsOmitted)
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(1092L, " ..."));
            }
            else
            {
                if (method is ExtremeLemma)
                {
                    PrintKTypeIndication(((ExtremeLemma)method).TypeOfK);
                }
                PrintFormals(method.Ins, method, method.Name);
                if (MutateCSharp.Schemata90.ReplaceBinExprOp_15(1097L, method.Outs.Count, MutateCSharp.Schemata90.ReplaceNumericConstant_2(1093L, 0)))
                {
                    if (MutateCSharp.Schemata90.ReplaceBinExprOp_26(1115L, MutateCSharp.Schemata90.ReplaceBinExprOp_16(1102L, method.Ins.Count, method.Outs.Count), MutateCSharp.Schemata90.ReplaceNumericConstant_2(1111L, 3)))
                    {
                        wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(1120L, " returns "));
                    }
                    else
                    {
                        wr.WriteLine();
                        Indent(MutateCSharp.Schemata90.ReplaceBinExprOp_16(1134L, indent, MutateCSharp.Schemata90.ReplaceBinExprOp_27(1125L, MutateCSharp.Schemata90.ReplaceNumericConstant_2(1121L, 2), IndentAmount)));
                        wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(1143L, "returns "));
                    }
                    PrintFormals(method.Outs, method);
                }
            }

            int ind = MutateCSharp.Schemata90.ReplaceBinExprOp_16(1144L, indent, IndentAmount);
            PrintSpec(MutateCSharp.Schemata90.ReplaceStringConstant_1(1153L, "requires"), method.Req, ind);
            var readsExpressions = method.Reads.Expressions;
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_28(1154L, readsExpressions, null))
            {
                var isDefault = MutateCSharp.Schemata90.ReplaceBinExprOp_8(1168L, () => MutateCSharp.Schemata90.ReplaceBinExprOp_6(1159L, readsExpressions.Count, MutateCSharp.Schemata90.ReplaceNumericConstant_2(1155L, 1)), () => readsExpressions[MutateCSharp.Schemata90.ReplaceNumericConstant_2(1164L, 0)].E is WildcardExpr);
                if (!isDefault)
                {
                    PrintFrameSpecLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(1174L, "reads"), method.Reads, ind);
                }
            }
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_28(1175L, method.Mod.Expressions, null))
            {
                PrintFrameSpecLine(MutateCSharp.Schemata90.ReplaceStringConstant_1(1176L, "modifies"), method.Mod, ind);
            }
            PrintSpec(MutateCSharp.Schemata90.ReplaceStringConstant_1(1177L, "ensures"), method.Ens, ind);
            PrintDecreasesSpec(method.Decreases, ind);
            wr.WriteLine();

            if (MutateCSharp.Schemata90.ReplaceBinExprOp_8(1179L, () => MutateCSharp.Schemata90.ReplaceBinExprOp_19(1178L, method.Body, null), () => !printSignatureOnly))
            {
                Indent(indent);
                PrintStatement(method.Body, indent);
                wr.WriteLine();
            }
        }

        void PrintKTypeIndication(ExtremePredicate.KType kType)
        {
            switch (kType)
            {
                case ExtremePredicate.KType.Nat:
                    wr.Write("[nat]");
                    break;
                    break;
                case ExtremePredicate.KType.ORDINAL:
                    wr.Write("[ORDINAL]");
                    break;
                    break;
                case ExtremePredicate.KType.Unspecified:
                    break;
                    break;
                default:
                    Contract.Assume(false);  // unexpected KType value
                    break;
                    break;
            }
        }

        internal void PrintFormals(List<Formal> ff, ICallable/*?*/ context, string name = null)
        {
            Contract.Requires(ff != null);
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_8(1186L, () => name != null, () => name.EndsWith(MutateCSharp.Schemata90.ReplaceStringConstant_1(1185L, "#"))))
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(1192L, "["));
                PrintFormal(ff[MutateCSharp.Schemata90.ReplaceNumericConstant_2(1193L, 0)], MutateCSharp.Schemata90.ReplaceBooleanConstant_0(1197L, false));
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(1198L, "]"));
                ff = new List<Formal>(ff.Skip(MutateCSharp.Schemata90.ReplaceNumericConstant_2(1199L, 1)));
            }
            wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(1203L, "("));
            string sep = "";
            foreach (Formal f in ff)
            {
                Contract.Assert(f != null);
                wr.Write(sep);
                sep = MutateCSharp.Schemata90.ReplaceStringConstant_1(1204L, ", ");
                PrintFormal(f, MutateCSharp.Schemata90.ReplaceBinExprOp_8(1211L, () => (MutateCSharp.Schemata90.ReplaceBinExprOp_7(1205L, () => context is TwoStateLemma, () => context is TwoStateFunction)), () => f.InParam));
            }
            wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(1217L, ")"));
        }

        void PrintFormal(Formal f, bool showNewKeyword)
        {
            Contract.Requires(f != null);
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_8(1218L, () => showNewKeyword, () => !f.IsOld))
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(1224L, "new "));
            }
            if (f.IsOlder)
            {
                Contract.Assert(f.HasName);
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(1225L, "older "));
            }
            if (f.IsGhost)
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(1226L, "ghost "));
            }
            if (f.IsNameOnly)
            {
                Contract.Assert(f.HasName);
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(1227L, "nameonly "));
            }
            if (f.HasName)
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(1228L, "{0}: "), f.DisplayName);
            }
            PrintType(f.Type);
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_36(1229L, f.DefaultValue, null))
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(1230L, " := "));
                PrintExpression(f.DefaultValue, MutateCSharp.Schemata90.ReplaceBooleanConstant_0(1231L, false));
            }
        }

        internal void PrintDecreasesSpec(Specification<Expression> decs, int indent)
        {
            Contract.Requires(decs != null);
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_12(1232L, printMode, PrintModes.NoGhost)) { return; }
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_8(1243L, () => MutateCSharp.Schemata90.ReplaceBinExprOp_35(1233L, decs.Expressions, null), () => MutateCSharp.Schemata90.ReplaceBinExprOp_15(1238L, decs.Expressions.Count, MutateCSharp.Schemata90.ReplaceNumericConstant_2(1234L, 0))))
            {
                wr.WriteLine();
                Indent(indent);
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(1249L, "decreases"));
                if (decs.HasAttributes())
                {
                    PrintAttributes(decs.Attributes);
                }
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(1250L, " "));
                PrintExpressionList(decs.Expressions, MutateCSharp.Schemata90.ReplaceBooleanConstant_0(1251L, true));
            }
        }

        internal void PrintFrameSpecLine(string kind, Specification<FrameExpression> ee, int indent)
        {
            Contract.Requires(kind != null);
            Contract.Requires(ee != null);
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_8(1269L, () => MutateCSharp.Schemata90.ReplaceBinExprOp_8(1254L, () => MutateCSharp.Schemata90.ReplaceBinExprOp_40(1252L, ee, null), () => MutateCSharp.Schemata90.ReplaceBinExprOp_28(1253L, ee.Expressions, null)), () => MutateCSharp.Schemata90.ReplaceBinExprOp_15(1264L, ee.Expressions.Count, MutateCSharp.Schemata90.ReplaceNumericConstant_2(1260L, 0))))
            {
                wr.WriteLine();
                Indent(indent);
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(1275L, "{0}"), kind);
                PrintAttributes(ee.Attributes);
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(1276L, " "));
                PrintFrameExpressionList(ee.Expressions);
            }
        }

        internal void PrintSpec(string kind, List<AttributedExpression> ee, int indent)
        {
            Contract.Requires(kind != null);
            Contract.Requires(ee != null);
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_12(1277L, printMode, PrintModes.NoGhost)) { return; }
            foreach (AttributedExpression e in ee)
            {
                Contract.Assert(e != null);
                wr.WriteLine();
                Indent(indent);
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(1278L, "{0}"), kind);
                PrintAttributedExpression(e);
            }
        }

        void PrintAttributedExpression(AttributedExpression e)
        {
            Contract.Requires(e != null);

            if (e.HasAttributes())
            {
                PrintAttributes(e.Attributes);
            }

            wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(1279L, " "));
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_41(1280L, e.Label, null))
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(1281L, "{0}: "), e.Label.Name);
            }
            PrintExpression(e.E, MutateCSharp.Schemata90.ReplaceBooleanConstant_0(1282L, true));
        }

        // ----------------------------- PrintType -----------------------------

        public void PrintType(Type ty)
        {
            Contract.Requires(ty != null);
            wr.Write(ty.TypeName(options, null, MutateCSharp.Schemata90.ReplaceBooleanConstant_0(1283L, true)));
        }

        public void PrintType(string prefix, Type ty)
        {
            Contract.Requires(prefix != null);
            Contract.Requires(ty != null);
            if (options.DafnyPrintResolvedFile != null)
            {
                ty = TypeRefinementWrapper.NormalizeSansRefinementWrappers(ty);
            }
            string s = ty.TypeName(options, null, MutateCSharp.Schemata90.ReplaceBooleanConstant_0(1284L, true));
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_8(1286L, () => ty is TypeRefinementWrapper or not TypeProxy, () => !s.StartsWith(MutateCSharp.Schemata90.ReplaceStringConstant_1(1285L, "_"))))
            {
                wr.Write(MutateCSharp.Schemata90.ReplaceStringConstant_1(1292L, "{0}{1}"), prefix, s);
            }
        }

        public string TPCharacteristicsSuffix(TypeParameter.TypeParameterCharacteristics characteristics)
        {
            string s = null;
            if (MutateCSharp.Schemata90.ReplaceBinExprOp_7(1301L, () => MutateCSharp.Schemata90.ReplaceBinExprOp_42(1293L, characteristics.EqualitySupport, TypeParameter.EqualitySupportValue.Required), () => (MutateCSharp.Schemata90.ReplaceBinExprOp_8(1295L, () => MutateCSharp.Schemata90.ReplaceBinExprOp_42(1294L, characteristics.EqualitySupport, TypeParameter.EqualitySupportValue.InferredRequired), () => options.DafnyPrintResolvedFile != null))))
            {
                s = MutateCSharp.Schemata90.ReplaceStringConstant_1(1307L, "==");
            }
            if (characteristics.HasCompiledValue)
            {
                var prefix = s == null ? "" : s + MutateCSharp.Schemata90.ReplaceStringConstant_1(1308L, ",");
                s = prefix + MutateCSharp.Schemata90.ReplaceStringConstant_1(1309L, "0");
            }
            else if (characteristics.IsNonempty)
            {
                var prefix = s == null ? "" : s + MutateCSharp.Schemata90.ReplaceStringConstant_1(1310L, ",");
                s = prefix + MutateCSharp.Schemata90.ReplaceStringConstant_1(1311L, "00");
            }
            if (characteristics.ContainsNoReferenceTypes)
            {
                var prefix = s == null ? "" : s + MutateCSharp.Schemata90.ReplaceStringConstant_1(1312L, ",");
                s = prefix + MutateCSharp.Schemata90.ReplaceStringConstant_1(1313L, "!new");
            }
            if (s == null)
            {
                return "";
            }
            else
            {
                return MutateCSharp.Schemata90.ReplaceStringConstant_1(1314L, "(") + s + MutateCSharp.Schemata90.ReplaceStringConstant_1(1315L, ")");
            }

            return default;
        }

        bool ShowType(Type t)
        {
            Contract.Requires(t != null);
            return MutateCSharp.Schemata90.ReplaceBinExprOp_7(1316L, () => !(t is TypeProxy), () => options.DafnyPrintResolvedFile != null);
        }
    }
}
