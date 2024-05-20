using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using DafnyCore.Verifier;
using Microsoft.Boogie;
using Bpl = Microsoft.Boogie;
using BplParser = Microsoft.Boogie.Parser;
using static Microsoft.Dafny.Util;
using PODesc = Microsoft.Dafny.ProofObligationDescription;
namespace MutateCSharp
{
    internal class Schemata500
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT500");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_34(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_47(long mutantId, System.Func<Microsoft.Dafny.IToken, bool> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBinExprOp_31(long mutantId, Microsoft.Dafny.DatatypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_40(long mutantId, System.Collections.Generic.List<Microsoft.Boogie.Expr> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.ConcreteUpdateStatement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_36(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_38(long mutantId, Microsoft.Dafny.Expression argument1, Microsoft.Dafny.Expression argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_28(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_30(long mutantId, System.Collections.Generic.Dictionary<string, Microsoft.Dafny.DatatypeCtor> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_51(long mutantId, Microsoft.Boogie.Expr argument1, Microsoft.Boogie.LiteralExpr argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_44(long mutantId, Microsoft.Dafny.ICallable argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_53(long mutantId, Microsoft.Dafny.IVariable argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_39(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.FrameExpression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_52(long mutantId, Microsoft.Dafny.ThisExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.ForallStmt.BodyKind argument1, Microsoft.Dafny.ForallStmt.BodyKind argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, Microsoft.Dafny.AssertStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_32(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
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

        internal static bool ReplaceBinExprOp_20(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, Microsoft.Dafny.AssertLabel argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, Microsoft.Dafny.BoogieStmtListBuilder argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_37(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.TestGenerationOptions.Modes argument1, Microsoft.Dafny.TestGenerationOptions.Modes argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.UpdateStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Boogie.Expr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_56(long mutantId, Microsoft.Dafny.UserDefinedType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_43(long mutantId, Microsoft.Boogie.IdentifierExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_49(long mutantId, Microsoft.Dafny.ICallable argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_55(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_50(long mutantId, Microsoft.Boogie.IdentifierExpr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.Field argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_54(long mutantId, Microsoft.Dafny.CallStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_35(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_46(long mutantId, Microsoft.Boogie.Expr argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.ConcreteUpdateStatement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_42(long mutantId, Microsoft.Boogie.Cmd argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_29(long mutantId, Microsoft.Boogie.IfCmd argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_6(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static int ReplacePrefixUnaryExprOp_24(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return --argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return +argument1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return ~argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return ++argument1; }
            return --argument1;
        }

        internal static int ReplaceBinExprOp_23(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_48(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, Microsoft.Dafny.ModuleDefinition argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_25(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
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

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.AttributedToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_41(long mutantId, Microsoft.Dafny.LList<Microsoft.Dafny.Label> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_26(long mutantId, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument1, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceBinExprOp_27(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_33(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_45(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, Microsoft.Dafny.ModuleDefinition argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, int argument1, int argument2)
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
    public partial class BoogieGenerator
    {
        private void TrStmt(Statement stmt, BoogieStmtListBuilder builder, List<Variable> locals, ExpressionTranslator etran)
        {
            Contract.Requires(stmt != null);
            Contract.Requires(builder != null);
            Contract.Requires(locals != null);
            Contract.Requires(etran != null);
            Contract.Requires(codeContext != null && predef != null);
            Contract.Ensures(fuelContext == Contract.OldValue(fuelContext));

            stmtContext = StmtType.NONE;
            adjustFuelForExists = MutateCSharp.Schemata500.ReplaceBooleanConstant_0(1L, true);  // fuel for exists might need to be adjusted based on whether it's in an assert or assume stmt.
            if (stmt is PredicateStmt predicateStmt)
            {
                TrPredicateStmt(predicateStmt, builder, locals, etran);

            }
            else if (stmt is PrintStmt)
            {
                AddComment(builder, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(2L, "print statement"));
                PrintStmt s = (PrintStmt)stmt;
                foreach (var arg in s.Args)
                {
                    TrStmt_CheckWellformed(arg, builder, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(3L, false));
                }
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_2(4L, options.TestGenOptions.Mode, TestGenerationOptions.Modes.None))
                {
                    builder.AddCaptureState(s);
                }

            }
            else if (stmt is RevealStmt)
            {
                AddComment(builder, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(5L, "reveal statement"));
                var s = (RevealStmt)stmt;
                foreach (var la in s.LabeledAsserts)
                {
                    Contract.Assert(la.E != null);  // this should have been filled in by now
                    builder.Add(new Bpl.AssumeCmd(s.Tok, la.E));
                }
                TrStmtList(s.ResolvedStatements, builder, locals, etran);

            }
            else if (stmt is BreakStmt)
            {
                var s = (BreakStmt)stmt;
                AddComment(builder, stmt, $"{s.Kind} statement");
                var lbl = (s.IsContinue ? MutateCSharp.Schemata500.ReplaceStringConstant_1(6L, "continue_") : MutateCSharp.Schemata500.ReplaceStringConstant_1(7L, "after_")) + s.TargetStmt.Labels.Data.AssignUniqueId(CurrentIdGenerator);
                builder.Add(new GotoCmd(s.Tok, new List<string> { lbl }));
            }
            else if (stmt is ReturnStmt)
            {
                var s = (ReturnStmt)stmt;
                AddComment(builder, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(8L, "return statement"));
                if (s.ReverifyPost)
                {
                    // $_reverifyPost := true;
                    builder.Add(Bpl.Cmd.SimpleAssign(s.Tok, new Bpl.IdentifierExpr(s.Tok, MutateCSharp.Schemata500.ReplaceStringConstant_1(9L, "$_reverifyPost"), Bpl.Type.Bool), Bpl.Expr.True));
                }
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_3(10L, s.HiddenUpdate, null))
                {
                    TrStmt(s.HiddenUpdate, builder, locals, etran);
                }
                if (codeContext is IMethodCodeContext)
                {
                    var method = (IMethodCodeContext)codeContext;
                    method.Outs.ForEach(p => CheckDefiniteAssignmentReturn(stmt.Tok, p, builder));
                }

                if (codeContext is Method { FunctionFromWhichThisIsByMethodDecl: { ByMethodTok: { } } fun } method2)
                {
                    AssumeCanCallForByMethodDecl(method2, builder);
                }

                builder.Add(new Bpl.ReturnCmd(stmt.Tok));
            }
            else if (stmt is YieldStmt)
            {
                var s = (YieldStmt)stmt;
                AddComment(builder, s, MutateCSharp.Schemata500.ReplaceStringConstant_1(11L, "yield statement"));
                Contract.Assert(codeContext is IteratorDecl);
                var iter = (IteratorDecl)codeContext;
                // if the yield statement has arguments, do them first
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_3(12L, s.HiddenUpdate, null))
                {
                    TrStmt(s.HiddenUpdate, builder, locals, etran);
                }
                // this.ys := this.ys + [this.y];
                var th = new ThisExpr(iter);
                Contract.Assert(iter.OutsFields.Count == iter.OutsHistoryFields.Count);
                for (int i = MutateCSharp.Schemata500.ReplaceNumericConstant_4(13L, 0); MutateCSharp.Schemata500.ReplaceBinExprOp_5(17L, i, iter.OutsFields.Count); MutateCSharp.Schemata500.ReplacePostfixUnaryExprOp_6(22L, ref i))
                {
                    var y = iter.OutsFields[i];
                    var dafnyY = new MemberSelectExpr(s.Tok, th, y);
                    var ys = iter.OutsHistoryFields[i];
                    var dafnyYs = new MemberSelectExpr(s.Tok, th, ys);
                    var dafnySingletonY = new SeqDisplayExpr(s.Tok, new List<Expression>() { dafnyY });
                    dafnySingletonY.Type = ys.Type;  // resolve here
                    var rhs = new BinaryExpr(s.Tok, BinaryExpr.Opcode.Add, dafnyYs, dafnySingletonY);
                    rhs.ResolvedOp = BinaryExpr.ResolvedOpcode.Concat;
                    rhs.Type = ys.Type;  // resolve here
                    var cmd = Bpl.Cmd.SimpleAssign(s.Tok, etran.HeapCastToIdentifierExpr,
                      UpdateHeap(s.Tok, etran.HeapExpr, etran.TrExpr(th), new Bpl.IdentifierExpr(s.Tok, GetField(ys)), etran.TrExpr(rhs)));
                    builder.Add(cmd);
                }
                // yieldCount := yieldCount + 1;  assume yieldCount == |ys|;
                var yc = new Bpl.IdentifierExpr(s.Tok, yieldCountVariable);
                var incYieldCount = Bpl.Cmd.SimpleAssign(s.Tok, yc, Bpl.Expr.Binary(s.Tok, Bpl.BinaryOperator.Opcode.Add, yc, Bpl.Expr.Literal(MutateCSharp.Schemata500.ReplaceNumericConstant_4(23L, 1))));
                builder.Add(incYieldCount);
                builder.Add(TrAssumeCmd(s.Tok, YieldCountAssumption(iter, etran)));
                // assume $IsGoodHeap($Heap);
                builder.Add(AssumeGoodHeap(s.Tok, etran));
                // assert YieldEnsures[subst];  // where 'subst' replaces "old(E)" with "E" being evaluated in $_OldIterHeap
                var yeEtran = new ExpressionTranslator(this, predef, etran.HeapExpr, new Bpl.IdentifierExpr(s.Tok, MutateCSharp.Schemata500.ReplaceStringConstant_1(27L, "$_OldIterHeap"), predef.HeapType), iter);
                foreach (var p in iter.YieldEnsures)
                {
                    var ss = TrSplitExpr(p.E, yeEtran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(28L, true), out var splitHappened);
                    foreach (var split in ss)
                    {
                        if (RefinementToken.IsInherited(split.Tok, currentModule))
                        {
                            // this postcondition was inherited into this module, so just ignore it
                        }
                        else if (split.IsChecked)
                        {
                            var yieldToken = new NestedToken(s.Tok, split.Tok);
                            var desc = new PODesc.YieldEnsures();
                            builder.Add(AssertNS(yieldToken, split.E, desc, stmt.Tok, null));
                        }
                    }
                    builder.Add(TrAssumeCmdWithDependencies(yeEtran, stmt.Tok, p.E, MutateCSharp.Schemata500.ReplaceStringConstant_1(29L, "yield ensures clause")));
                }
                YieldHavoc(iter.tok, iter, builder, etran);
                builder.AddCaptureState(s);

            }
            else if (stmt is AssignSuchThatStmt)
            {
                var s = (AssignSuchThatStmt)stmt;
                AddComment(builder, s, MutateCSharp.Schemata500.ReplaceStringConstant_1(30L, "assign-such-that statement"));
                // Essentially, treat like an assert (that values for the LHS exist), a havoc (of the LHS), and an
                // assume (of the RHS).  However, we also need to check the well-formedness of the LHS and RHS.
                // The well-formedness of the LHS is done by the havoc. The well-formedness of the RHS is most
                // easily done after that havoc, but we need to be careful about two things:
                //   - We should not generate any errors for uses of LHSs. This is not an issue for fields or
                //     array elements, because they already have values before reaching the assign-such-that statement.
                //     (Note, "this.f" is not allowed as a LHS in the first division of a constructor.)
                //     For any local variable or out-parameter x that's a LHS, we create a new variable x' and
                //     substitute x' for x in the RHS before doing the well-formedness check.
                //   - The well-formedness checks need to be able to assume that each x' has a value of its
                //     type. However, this assumption must not carry over to the existence assertion, because
                //     then everything will be provable if x' is of a known-empty type. Instead, the well-formedness
                //     check is wrapped inside an "if" whose guard is the type antecedent. After the existence
                //     check, the type antecedent is assumed of the original x, the RHS is assumed, and x is
                //     marked off has having been definitely assigned.
                //
                // So, the Dafny statement
                //     E.f, x :| RHS(x);
                // is translated into the following Boogie code:
                //     var x';
                //     Tr[[ E.f := *; ]]  // this havoc is translated like a Dafny assignment statement, which means
                //                        // the well-formedness of E is checked here
                //     if (typeAntecedent(x')) {
                //       check well-formedness of RHS(x');
                //     }
                //     assert (exists x'' :: RHS(x''));  // for ":| assume", omit this line; for ":|", LHS is only allowed to contain simple variables
                //     defass#x := true;
                //     havoc x;
                //     assume RHS(x);

                var simpleLHSs = new List<IdentifierExpr>();
                Bpl.Expr typeAntecedent = Bpl.Expr.True;
                var havocLHSs = new List<Expression>();
                var havocRHSs = new List<AssignmentRhs>();
                var substMap = new Dictionary<IVariable, Expression>();
                foreach (var lhs in s.Lhss)
                {
                    var lvalue = lhs.Resolved;
                    if (lvalue is IdentifierExpr ide)
                    {
                        simpleLHSs.Add(ide);
                        var wh = SetupVariableAsLocal(ide.Var, substMap, builder, locals, etran);
                        typeAntecedent = BplAnd(typeAntecedent, wh);
                    }
                    else
                    {
                        havocLHSs.Add(lvalue);
                        havocRHSs.Add(new HavocRhs(lhs.tok));  // note, a HavocRhs is constructed as already resolved
                    }
                }
                ProcessLhss(havocLHSs, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(31L, false), MutateCSharp.Schemata500.ReplaceBooleanConstant_0(32L, true), builder, locals, etran, stmt, out var lhsBuilder, out var bLhss, out _, out _, out _);
                ProcessRhss(lhsBuilder, bLhss, havocLHSs, havocRHSs, builder, locals, etran, stmt);

                // Here comes the well-formedness check
                var wellFormednessBuilder = new BoogieStmtListBuilder(this, options);
                var rhs = Substitute(s.Expr, null, substMap);
                TrStmt_CheckWellformed(rhs, wellFormednessBuilder, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(33L, false));
                var ifCmd = new Bpl.IfCmd(s.Tok, typeAntecedent, wellFormednessBuilder.Collect(s.Tok), null, null);
                builder.Add(ifCmd);

                // Here comes the assert part
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_7(34L, s.AssumeToken, null))
                {
                    substMap = new Dictionary<IVariable, Expression>();
                    var bvars = new List<BoundVar>();
                    foreach (var lhs in s.Lhss)
                    {
                        var l = lhs.Resolved;
                        if (l is IdentifierExpr x)
                        {
                            CloneVariableAsBoundVar(x.tok, x.Var, MutateCSharp.Schemata500.ReplaceStringConstant_1(35L, "$as#") + x.Name, out var bv, out var ie);
                            bvars.Add(bv);
                            substMap.Add(x.Var, ie);
                        }
                        else
                        {
                            // other forms of LHSs have been ruled out by the resolver (it would be possible to
                            // handle them, but it would involve heap-update expressions--the translation would take
                            // effort, and it's not certain that the existential would be successful in verification).
                            Contract.Assume(false);  // unexpected case
                        }
                    }

                    GenerateAndCheckGuesses(s.Tok, bvars, s.Bounds, Substitute(s.Expr, null, substMap), TrTrigger(etran, s.Attributes, s.Tok, substMap), builder, etran);
                }

                // Mark off the simple variables as having definitely been assigned AND THEN havoc their values. By doing them
                // in this order, the type antecedents will in effect be assumed.
                var bHavocLHSs = new List<Bpl.IdentifierExpr>();
                foreach (var lhs in simpleLHSs)
                {
                    MarkDefiniteAssignmentTracker(lhs, builder);
                    bHavocLHSs.Add((Bpl.IdentifierExpr)etran.TrExpr(lhs));
                }
                builder.Add(new Bpl.HavocCmd(s.Tok, bHavocLHSs));

                // End by doing the assume
                builder.Add(TrAssumeCmdWithDependencies(etran, s.Tok, s.Expr, MutateCSharp.Schemata500.ReplaceStringConstant_1(36L, "assign-such-that constraint")));
                builder.AddCaptureState(s);  // just do one capture state--here, at the very end (that is, don't do one before the assume)

            }
            else if (stmt is UpdateStmt)
            {
                var s = (UpdateStmt)stmt;
                // This UpdateStmt can be single-target assignment, a multi-assignment, a call statement, or
                // an array-range update.  Handle the multi-assignment here and handle the others as for .ResolvedStatements.
                var resolved = s.ResolvedStatements;
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_8(41L, resolved.Count, MutateCSharp.Schemata500.ReplaceNumericConstant_4(37L, 1)))
                {
                    TrStmt(resolved[MutateCSharp.Schemata500.ReplaceNumericConstant_4(46L, 0)], builder, locals, etran);
                }
                else
                {
                    AddComment(builder, s, MutateCSharp.Schemata500.ReplaceStringConstant_1(50L, "update statement"));
                    var assignStmts = resolved.Cast<AssignStmt>().ToList();
                    var lhss = assignStmts.Select(a => a.Lhs).ToList();
                    var rhss = assignStmts.Select(a => a.Rhs).ToList();
                    // note: because we have more than one expression, we always must assign to Boogie locals in a two
                    // phase operation. Thus rhssCanAffectPreviouslyKnownExpressions is just true.
                    Contract.Assert(1 < lhss.Count);

                    ProcessLhss(lhss, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(51L, true), MutateCSharp.Schemata500.ReplaceBooleanConstant_0(52L, false), builder, locals, etran, stmt, out var lhsBuilder, out var bLhss, out var lhsObjs, out var lhsFields, out var lhsNames);
                    // We know that, because the translation saves to a local variable, that the RHS always need to
                    // generate a new local, i.e. bLhss is just all nulls.
                    Contract.Assert(Contract.ForAll(bLhss, lhs => lhs == null));
                    // This generates the assignments, and gives them to us as finalRhss.
                    var finalRhss = ProcessUpdateAssignRhss(lhss, rhss, builder, locals, etran, stmt);
                    // ProcessLhss has laid down framing conditions and the ProcessUpdateAssignRhss will check subranges (nats),
                    // but we need to generate the distinctness condition (two LHS are equal only when the RHS is also
                    // equal). We need both the LHS and the RHS to do this, which is why we need to do it here.
                    CheckLhssDistinctness(finalRhss, s.Rhss, lhss, builder, etran, lhsObjs, lhsFields, lhsNames, s.OriginalInitialLhs);
                    // Now actually perform the assignments to the LHS.
                    for (int i = MutateCSharp.Schemata500.ReplaceNumericConstant_4(53L, 0); MutateCSharp.Schemata500.ReplaceBinExprOp_5(57L, i, lhss.Count); MutateCSharp.Schemata500.ReplacePostfixUnaryExprOp_6(62L, ref i))
                    {
                        lhsBuilder[i](finalRhss[i], s.Rhss[i] is HavocRhs, builder, etran);
                    }
                    builder.AddCaptureState(s);
                }

            }
            else if (stmt is AssignOrReturnStmt)
            {
                AddComment(builder, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(63L, "assign-or-return statement (:-)"));
                AssignOrReturnStmt s = (AssignOrReturnStmt)stmt;
                TrStmtList(s.ResolvedStatements, builder, locals, etran);

            }
            else if (stmt is AssignStmt)
            {
                AddComment(builder, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(64L, "assignment statement"));
                AssignStmt s = (AssignStmt)stmt;
                TrAssignment(stmt, s.Lhs.Resolved, s.Rhs, builder, locals, etran);

            }
            else if (stmt is CallStmt)
            {
                AddComment(builder, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(65L, "call statement"));
                TrCallStmt((CallStmt)stmt, builder, locals, etran, null);

            }
            else if (stmt is DividedBlockStmt)
            {
                var s = (DividedBlockStmt)stmt;
                AddComment(builder, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(66L, "divided block before new;"));
                var prevDefiniteAssignmentTrackerCount = definiteAssignmentTrackers.Count;
                var tok = s.SeparatorTok ?? s.Tok;
                // a DividedBlockStmt occurs only inside a Constructor body of a class
                var cl = (ClassDecl)((Constructor)codeContext).EnclosingClass;
                var fields = Concat(cl.InheritedMembers, cl.Members).ConvertAll(member => MutateCSharp.Schemata500.ReplaceBinExprOp_9(73L, () => MutateCSharp.Schemata500.ReplaceBinExprOp_9(67L, () => member is Field, () => !member.IsStatic), () => !member.IsInstanceIndependentConstant) ? (Field)member : null);
                fields.RemoveAll(f => MutateCSharp.Schemata500.ReplaceBinExprOp_10(79L, f, null));
                var localSurrogates = fields.ConvertAll(f => new Bpl.LocalVariable(f.tok, new TypedIdent(f.tok, SurrogateName(f), TrType(f.Type))));
                locals.AddRange(localSurrogates);
                fields.ForEach(f => AddDefiniteAssignmentTrackerSurrogate(f, cl, locals, MutateCSharp.Schemata500.ReplaceBinExprOp_9(80L, () => codeContext is Constructor, () => codeContext.IsGhost)));

                Contract.Assert(!inBodyInitContext);
                inBodyInitContext = MutateCSharp.Schemata500.ReplaceBooleanConstant_0(86L, true);
                TrStmtList(s.BodyInit, builder, locals, etran);
                Contract.Assert(inBodyInitContext);
                inBodyInitContext = MutateCSharp.Schemata500.ReplaceBooleanConstant_0(87L, false);

                // The "new;" translates into an allocation of "this"
                AddComment(builder, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(88L, "new;"));
                fields.ForEach(f => CheckDefiniteAssignmentSurrogate(s.SeparatorTok ?? s.RangeToken.EndToken, f, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(89L, true), builder));
                fields.ForEach(RemoveDefiniteAssignmentTrackerSurrogate);
                var th = new ThisExpr(cl);
                var bplThis = (Bpl.IdentifierExpr)etran.TrExpr(th);
                SelectAllocateObject(tok, bplThis, th.Type, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(90L, false), builder, etran);
                for (int i = MutateCSharp.Schemata500.ReplaceNumericConstant_4(91L, 0); MutateCSharp.Schemata500.ReplaceBinExprOp_5(95L, i, fields.Count); MutateCSharp.Schemata500.ReplacePostfixUnaryExprOp_6(100L, ref i))
                {
                    // assume $Heap[this, f] == this.f;
                    var mse = new MemberSelectExpr(tok, th, fields[i]);
                    Bpl.Expr surr = new Bpl.IdentifierExpr(tok, localSurrogates[i]);
                    surr = CondApplyUnbox(tok, surr, fields[i].Type, mse.Type);
                    builder.Add(new Bpl.AssumeCmd(tok, Bpl.Expr.Eq(etran.TrExpr(mse), surr)));
                }
                CommitAllocatedObject(tok, bplThis, null, builder, etran);

                AddComment(builder, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(101L, "divided block after new;"));
                TrStmtList(s.BodyProper, builder, locals, etran);
                RemoveDefiniteAssignmentTrackers(s.Body, prevDefiniteAssignmentTrackerCount);

            }
            else if (stmt is BlockStmt)
            {
                var s = (BlockStmt)stmt;
                var prevDefiniteAssignmentTrackerCount = definiteAssignmentTrackers.Count;
                TrStmtList(s.Body, builder, locals, etran);
                RemoveDefiniteAssignmentTrackers(s.Body, prevDefiniteAssignmentTrackerCount);

            }
            else if (stmt is IfStmt ifStmt)
            {
                TrIfStmt(ifStmt, builder, locals, etran);

            }
            else if (stmt is AlternativeStmt)
            {
                AddComment(builder, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(102L, "alternative statement"));
                var s = (AlternativeStmt)stmt;
                var elseCase = Assert(s.Tok, Bpl.Expr.False, new PODesc.AlternativeIsComplete());
                TrAlternatives(s.Alternatives, elseCase, null, builder, locals, etran, stmt.IsGhost);

            }
            else if (stmt is WhileStmt whileStmt)
            {
                TrWhileStmt(whileStmt, builder, locals, etran);

            }
            else if (stmt is AlternativeLoopStmt)
            {
                AddComment(builder, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(103L, "alternative loop statement"));
                var s = (AlternativeLoopStmt)stmt;
                var tru = Expression.CreateBoolLiteral(s.Tok, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(104L, true));
                TrLoop(s, tru,
                  delegate (BoogieStmtListBuilder bld, ExpressionTranslator e)
                  {
                      TrAlternatives(s.Alternatives, null, new Bpl.BreakCmd(s.Tok, null), bld, locals, e, stmt.IsGhost);
                      InsertContinueTarget(s, bld);
                  },
                  builder, locals, etran);

            }
            else if (stmt is ForLoopStmt forLoopStmt)
            {
                TrForLoop(forLoopStmt, builder, locals, etran);

            }
            else if (stmt is ModifyStmt)
            {
                AddComment(builder, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(105L, "modify statement"));
                var s = (ModifyStmt)stmt;
                // check well-formedness of the modifies clauses
                CheckFrameWellFormed(new WFOptions(), s.Mod.Expressions, locals, builder, etran);
                // check that the modifies is a subset
                CheckFrameSubset(s.Tok, s.Mod.Expressions, null, null, etran, etran.ModifiesFrame(s.Tok), builder, new PODesc.ModifyFrameSubset(MutateCSharp.Schemata500.ReplaceStringConstant_1(106L, "modify statement")), null);
                // cause the change of the heap according to the given frame
                var suffix = CurrentIdGenerator.FreshId(MutateCSharp.Schemata500.ReplaceStringConstant_1(107L, "modify#"));
                string modifyFrameName = MutateCSharp.Schemata500.ReplaceStringConstant_1(108L, "$Frame$") + suffix;
                var preModifyHeapVar = new Bpl.LocalVariable(s.Tok, new Bpl.TypedIdent(s.Tok, MutateCSharp.Schemata500.ReplaceStringConstant_1(109L, "$PreModifyHeap$") + suffix, predef.HeapType));
                locals.Add(preModifyHeapVar);
                DefineFrame(s.Tok, etran.ModifiesFrame(s.Tok), s.Mod.Expressions, builder, locals, modifyFrameName);
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_11(110L, s.Body, null))
                {
                    var preModifyHeap = new Bpl.IdentifierExpr(s.Tok, preModifyHeapVar);
                    // preModifyHeap := $Heap;
                    builder.Add(Bpl.Cmd.SimpleAssign(s.Tok, preModifyHeap, etran.HeapExpr));
                    // havoc $Heap;
                    builder.Add(new Bpl.HavocCmd(s.Tok, new List<Bpl.IdentifierExpr> { etran.HeapCastToIdentifierExpr }));
                    // assume $HeapSucc(preModifyHeap, $Heap);   OR $HeapSuccGhost
                    builder.Add(TrAssumeCmd(s.Tok, HeapSucc(preModifyHeap, etran.HeapExpr, s.IsGhost)));
                    // assume nothing outside the frame was changed
                    var etranPreLoop = new ExpressionTranslator(this, predef, preModifyHeap, this.currentDeclaration is IFrameScope fs ? fs : null);
                    var updatedFrameEtran = etran.WithModifiesFrame(modifyFrameName);
                    builder.Add(TrAssumeCmd(s.Tok, FrameConditionUsingDefinedFrame(s.Tok, etranPreLoop, etran, updatedFrameEtran, updatedFrameEtran.ModifiesFrame(s.Tok))));
                }
                else
                {
                    // do the body, but with preModifyHeapVar as the governing frame
                    var updatedFrameEtran = etran.WithModifiesFrame(modifyFrameName);
                    CurrentIdGenerator.Push();
                    TrStmt(s.Body, builder, locals, updatedFrameEtran);
                    CurrentIdGenerator.Pop();
                }
                builder.AddCaptureState(stmt);

            }
            else if (stmt is ForallStmt)
            {
                var s = (ForallStmt)stmt;
                this.fuelContext = FuelSetting.ExpandFuelContext(stmt.Attributes, stmt.Tok, this.fuelContext, this.reporter);

                CurrentIdGenerator.Push();
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_12(111L, s.Kind, ForallStmt.BodyKind.Assign))
                {
                    AddComment(builder, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(112L, "forall statement (assign)"));
                    Contract.Assert(s.Ens.Count == 0);
                    if (MutateCSharp.Schemata500.ReplaceBinExprOp_8(117L, s.BoundVars.Count, MutateCSharp.Schemata500.ReplaceNumericConstant_4(113L, 0)))
                    {
                        TrStmt(s.Body, builder, locals, etran);
                    }
                    else
                    {
                        var s0 = (AssignStmt)s.S0;
                        var definedness = new BoogieStmtListBuilder(this, options);
                        var updater = new BoogieStmtListBuilder(this, options);
                        DefineFuelConstant(stmt.Tok, stmt.Attributes, definedness, etran);
                        TrForallAssign(s, s0, definedness, updater, locals, etran);
                        // All done, so put the two pieces together
                        builder.Add(new Bpl.IfCmd(s.Tok, null, definedness.Collect(s.Tok), null, updater.Collect(s.Tok)));
                        builder.AddCaptureState(stmt);
                    }

                }
                else if (MutateCSharp.Schemata500.ReplaceBinExprOp_12(122L, s.Kind, ForallStmt.BodyKind.Call))
                {
                    AddComment(builder, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(123L, "forall statement (call)"));
                    Contract.Assert(s.Ens.Count == 0);
                    if (MutateCSharp.Schemata500.ReplaceBinExprOp_8(128L, s.BoundVars.Count, MutateCSharp.Schemata500.ReplaceNumericConstant_4(124L, 0)))
                    {
                        Contract.Assert(LiteralExpr.IsTrue(s.Range));  // follows from the invariant of ForallStmt
                        TrStmt(s.Body, builder, locals, etran);
                    }
                    else
                    {
                        var s0 = (CallStmt)s.S0;
                        if (Attributes.Contains(s.Attributes, MutateCSharp.Schemata500.ReplaceStringConstant_1(133L, "_trustWellformed")))
                        {
                            TrForallStmtCall(s.Tok, s.BoundVars, s.Bounds, s.Range, null, s.EffectiveEnsuresClauses, s0, null, builder, locals, etran);
                        }
                        else
                        {
                            var definedness = new BoogieStmtListBuilder(this, options);
                            DefineFuelConstant(stmt.Tok, stmt.Attributes, definedness, etran);
                            var exporter = new BoogieStmtListBuilder(this, options);
                            TrForallStmtCall(s.Tok, s.BoundVars, s.Bounds, s.Range, null, s.EffectiveEnsuresClauses, s0, definedness, exporter, locals, etran);
                            // All done, so put the two pieces together
                            builder.Add(new Bpl.IfCmd(s.Tok, null, definedness.Collect(s.Tok), null, exporter.Collect(s.Tok)));
                        }
                        builder.AddCaptureState(stmt);
                    }

                }
                else if (MutateCSharp.Schemata500.ReplaceBinExprOp_12(134L, s.Kind, ForallStmt.BodyKind.Proof))
                {
                    AddComment(builder, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(135L, "forall statement (proof)"));
                    var definedness = new BoogieStmtListBuilder(this, options);
                    var exporter = new BoogieStmtListBuilder(this, options);
                    DefineFuelConstant(stmt.Tok, stmt.Attributes, definedness, etran);
                    TrForallProof(s, definedness, exporter, locals, etran);
                    // All done, so put the two pieces together
                    builder.Add(new Bpl.IfCmd(s.Tok, null, definedness.Collect(s.Tok), null, exporter.Collect(s.Tok)));
                    builder.AddCaptureState(stmt);

                }
                else
                {
                    Contract.Assert(false);  // unexpected kind
                }
                CurrentIdGenerator.Pop();
                this.fuelContext = FuelSetting.PopFuelContext();

            }
            else if (stmt is CalcStmt calcStmt)
            {
                TrCalcStmt(calcStmt, builder, locals, etran);

            }
            else if (stmt is NestedMatchStmt nestedMatchStmt)
            {
                TrStmt(nestedMatchStmt.Flattened, builder, locals, etran);
            }
            else if (stmt is MatchStmt matchStmt)
            {
                TrMatchStmt(matchStmt, builder, locals, etran);
            }
            else if (stmt is VarDeclStmt)
            {
                var s = (VarDeclStmt)stmt;
                var newLocalIds = new List<Bpl.IdentifierExpr>();
                int i = MutateCSharp.Schemata500.ReplaceNumericConstant_4(136L, 0);
                foreach (var local in s.Locals)
                {
                    Bpl.Type varType = TrType(local.Type);
                    Bpl.Expr wh = GetWhereClause(local.Tok,
                      new Bpl.IdentifierExpr(local.Tok, local.AssignUniqueName(currentDeclaration.IdGenerator), varType),
                      local.Type, etran, isAllocContext.Var(stmt.IsGhost, local));
                    // if needed, register definite-assignment tracking for this local
                    var needDefiniteAssignmentTracking = MutateCSharp.Schemata500.ReplaceBinExprOp_14(141L, () => MutateCSharp.Schemata500.ReplaceBinExprOp_13(140L, s.Update, null), () => s.Update is AssignSuchThatStmt);
                    if (s.Update is UpdateStmt)
                    {
                        // there is an initial assignment, but we need to look out for "*" being that assignment
                        var us = (UpdateStmt)s.Update;
                        if (MutateCSharp.Schemata500.ReplaceBinExprOp_9(152L, () => MutateCSharp.Schemata500.ReplaceBinExprOp_5(147L, i, us.Rhss.Count), () => us.Rhss[i] is HavocRhs))
                        {
                            needDefiniteAssignmentTracking = MutateCSharp.Schemata500.ReplaceBooleanConstant_0(158L, true);
                        }
                    }
                    if (!local.Type.IsNonempty)
                    {
                        // This prevents generating an unsatisfiable where clause for possibly empty types
                        needDefiniteAssignmentTracking = MutateCSharp.Schemata500.ReplaceBooleanConstant_0(159L, true);
                    }
                    if (needDefiniteAssignmentTracking)
                    {
                        var defassExpr = AddDefiniteAssignmentTracker(local, locals);
                        if (MutateCSharp.Schemata500.ReplaceBinExprOp_9(162L, () => MutateCSharp.Schemata500.ReplaceBinExprOp_15(160L, wh, null), () => MutateCSharp.Schemata500.ReplaceBinExprOp_15(161L, defassExpr, null)))
                        {
                            // make the "where" expression be "defass ==> wh", because we don't want to assume anything
                            // before the variable has been assigned (for a variable that needs definite-assignment tracking
                            // in the first place)
                            wh = BplImp(defassExpr, wh);
                        }
                    }
                    // create the variable itself (now that "wh" may mention the definite-assignment tracker)
                    Bpl.LocalVariable var = new Bpl.LocalVariable(local.Tok, new Bpl.TypedIdent(local.Tok, local.AssignUniqueName(currentDeclaration.IdGenerator), varType, wh));
                    var.Attributes = etran.TrAttributes(local.Attributes, null);
                    newLocalIds.Add(new Bpl.IdentifierExpr(local.Tok, var));
                    locals.Add(var);
                    MutateCSharp.Schemata500.ReplacePostfixUnaryExprOp_6(168L, ref i);
                }
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_13(169L, s.Update, null))
                {
                    // it is necessary to do a havoc here in order to give the variable the correct allocation state
                    builder.Add(new HavocCmd(s.Tok, newLocalIds));
                }
                // processing of "assumption" variables happens after the variable is possibly havocked above
                foreach (var local in s.Locals)
                {
                    if (Attributes.Contains(local.Attributes, MutateCSharp.Schemata500.ReplaceStringConstant_1(170L, "assumption")))
                    {
                        Bpl.Type varType = TrType(local.Type);
                        builder.Add(new AssumeCmd(local.Tok, new Bpl.IdentifierExpr(local.Tok, local.AssignUniqueName(currentDeclaration.IdGenerator), varType), new QKeyValue(local.Tok, MutateCSharp.Schemata500.ReplaceStringConstant_1(171L, "assumption_variable_initialization"), new List<object>(), null)));
                    }
                }
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_16(172L, s.Update, null))
                {
                    TrStmt(s.Update, builder, locals, etran);
                }
            }
            else if (stmt is VarDeclPattern)
            {
                var s = (VarDeclPattern)stmt;
                foreach (var local in s.LocalVars)
                {
                    Bpl.LocalVariable bvar = new Bpl.LocalVariable(local.Tok, new Bpl.TypedIdent(local.Tok, local.AssignUniqueName(currentDeclaration.IdGenerator), TrType(local.Type)));
                    locals.Add(bvar);
                    var bIe = new Bpl.IdentifierExpr(bvar.tok, bvar);
                    builder.Add(new Bpl.HavocCmd(local.Tok, new List<Bpl.IdentifierExpr> { bIe }));
                    Bpl.Expr wh = GetWhereClause(local.Tok, bIe, local.Type, etran, isAllocContext.Var(stmt.IsGhost, local));
                    if (MutateCSharp.Schemata500.ReplaceBinExprOp_15(173L, wh, null))
                    {
                        builder.Add(TrAssumeCmd(local.Tok, wh));
                    }
                }
                var varNameGen = CurrentIdGenerator.NestedFreshIdGenerator(MutateCSharp.Schemata500.ReplaceStringConstant_1(174L, "let#"));
                var pat = s.LHS;
                var rhs = s.RHS;
                var nm = varNameGen.FreshId(string.Format(MutateCSharp.Schemata500.ReplaceStringConstant_1(175L, "#{0}#"), MutateCSharp.Schemata500.ReplaceNumericConstant_4(176L, 0)));
                var r = new Bpl.LocalVariable(pat.tok, new Bpl.TypedIdent(pat.tok, nm, TrType(rhs.Type)));
                locals.Add(r);
                var rIe = new Bpl.IdentifierExpr(rhs.tok, r);
                CheckWellformedWithResult(rhs, new WFOptions(null, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(180L, false), MutateCSharp.Schemata500.ReplaceBooleanConstant_0(181L, false)), rIe, pat.Expr.Type, locals, builder, etran, MutateCSharp.Schemata500.ReplaceStringConstant_1(182L, "variable declaration RHS"));
                CheckCasePatternShape(pat, rIe, rhs.tok, pat.Expr.Type, builder);
                builder.Add(TrAssumeCmdWithDependenciesAndExtend(etran, s.tok, pat.Expr, e => Expr.Eq(e, rIe), MutateCSharp.Schemata500.ReplaceStringConstant_1(183L, "variable declaration")));
            }
            else if (stmt is TryRecoverStatement haltRecoveryStatement)
            {
                // try/recover statements are currently internal-only AST nodes that cannot be
                // directly used in user Dafny code. They are only generated by rewriters, and verifying
                // their use is low value.
                throw new NotSupportedException(MutateCSharp.Schemata500.ReplaceStringConstant_1(184L, "Verification of try/recover statements is not supported"));
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected statement
            }
        }

        private void TrPredicateStmt(PredicateStmt stmt, BoogieStmtListBuilder builder, List<Variable> locals, ExpressionTranslator etran)
        {
            Contract.Requires(stmt != null);
            Contract.Requires(builder != null);
            Contract.Requires(locals != null);
            Contract.Requires(etran != null);

            fuelContext = FuelSetting.ExpandFuelContext(stmt.Attributes, stmt.Tok, fuelContext, reporter);
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_14(185L, () => stmt is AssertStmt, () => options.DisallowSoundnessCheating))
            {
                TrAssertStmt(stmt, builder, locals, etran);
            }
            else if (stmt is ExpectStmt expectStmt)
            {
                TrExpectStmt(builder, locals, etran, expectStmt);
            }
            else if (stmt is AssumeStmt assumeStmt)
            {
                TrAssumeStmt(assumeStmt, builder, locals, etran);
            }
            fuelContext = FuelSetting.PopFuelContext();
        }

        private void TrAssumeStmt(AssumeStmt assumeStmt, BoogieStmtListBuilder builder, List<Variable> locals, ExpressionTranslator etran)
        {
            AddComment(builder, assumeStmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(191L, "assume statement"));
            stmtContext = StmtType.ASSUME;
            TrStmt_CheckWellformed(assumeStmt.Expr, builder, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(192L, false));
            builder.Add(TrAssumeCmdWithDependencies(etran, assumeStmt.Tok, assumeStmt.Expr, MutateCSharp.Schemata500.ReplaceStringConstant_1(193L, "assume statement"), MutateCSharp.Schemata500.ReplaceBooleanConstant_0(194L, true),
              etran.TrAttributes(assumeStmt.Attributes, null)));
            stmtContext = StmtType.NONE; // done with translating assume stmt.
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_2(195L, options.TestGenOptions.Mode, TestGenerationOptions.Modes.None))
            {
                builder.AddCaptureState(assumeStmt);
            }
        }

        private void TrExpectStmt(BoogieStmtListBuilder builder, List<Variable> locals, ExpressionTranslator etran, ExpectStmt expectStmt)
        {
            AddComment(builder, expectStmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(196L, "expect statement"));
            stmtContext = StmtType.ASSUME;
            TrStmt_CheckWellformed(expectStmt.Expr, builder, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(197L, false));

            // Need to check the message is well-formed, assuming the expected expression
            // does NOT hold:
            //
            // if Not(TrExpr[[ s.Expr ]]) {
            //  CheckWellformed[[ s.Message ]]
            //  assume false;
            // }
            BoogieStmtListBuilder thnBuilder = new BoogieStmtListBuilder(this, options);
            TrStmt_CheckWellformed(expectStmt.Message, thnBuilder, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(198L, false));
            thnBuilder.Add(TrAssumeCmd(expectStmt.Tok, new Bpl.LiteralExpr(expectStmt.Tok, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(199L, false)),
              etran.TrAttributes(expectStmt.Attributes, null)));
            Bpl.StmtList thn = thnBuilder.Collect(expectStmt.Tok);
            builder.Add(new Bpl.IfCmd(expectStmt.Tok, Bpl.Expr.Not(etran.TrExpr(expectStmt.Expr)), thn, null, null));

            stmtContext = StmtType.NONE; // done with translating expect stmt.
        }

        private void TrAssertStmt(PredicateStmt stmt, BoogieStmtListBuilder builder, List<Variable> locals, ExpressionTranslator etran)
        {
            var stmtBuilder = new BoogieStmtListBuilder(this, options);
            var defineFuel = DefineFuelConstant(stmt.Tok, stmt.Attributes, stmtBuilder, etran);
            var b = defineFuel ? stmtBuilder : builder;
            var (errorMessage, successMessage) = CustomErrorMessage(stmt.Attributes);
            stmtContext = StmtType.ASSERT;
            AddComment(b, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(200L, "assert statement"));
            TrStmt_CheckWellformed(stmt.Expr, b, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(201L, false));
            IToken enclosingToken = null;
            if (Attributes.Contains(stmt.Attributes, MutateCSharp.Schemata500.ReplaceStringConstant_1(202L, "_prependAssertToken")))
            {
                enclosingToken = stmt.Tok;
            }

            BoogieStmtListBuilder proofBuilder = null;
            var assertStmt = stmt as AssertStmt;
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_17(203L, assertStmt, null))
            {
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_18(204L, assertStmt.Proof, null))
                {
                    proofBuilder = new BoogieStmtListBuilder(this, options);
                    AddComment(proofBuilder, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(205L, "assert statement proof"));
                    CurrentIdGenerator.Push();
                    TrStmt(((AssertStmt)stmt).Proof, proofBuilder, locals, etran);
                    CurrentIdGenerator.Pop();
                }
                else if (MutateCSharp.Schemata500.ReplaceBinExprOp_19(206L, assertStmt.Label, null))
                {
                    proofBuilder = new BoogieStmtListBuilder(this, options);
                    AddComment(proofBuilder, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(207L, "assert statement proof"));
                }
            }

            var splits = TrSplitExpr(stmt.Expr, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(208L, true), out var splitHappened);
            if (!splitHappened)
            {
                var tok = MutateCSharp.Schemata500.ReplaceBinExprOp_20(209L, enclosingToken, null) ? GetToken(stmt.Expr) : new NestedToken(enclosingToken, GetToken(stmt.Expr));
                var desc = new PODesc.AssertStatementDescription(assertStmt, errorMessage, successMessage);
                (proofBuilder ?? b).Add(Assert(tok, etran.TrExpr(stmt.Expr), desc, stmt.Tok,
                  etran.TrAttributes(stmt.Attributes, null)));
            }
            else
            {
                foreach (var split in splits)
                {
                    if (split.IsChecked)
                    {
                        var tok = MutateCSharp.Schemata500.ReplaceBinExprOp_20(210L, enclosingToken, null) ? split.E.tok : new NestedToken(enclosingToken, split.Tok);
                        var desc = new PODesc.AssertStatementDescription(assertStmt, errorMessage, successMessage);
                        (proofBuilder ?? b).Add(AssertNS(ToDafnyToken(flags.ReportRanges, tok), split.E, desc, stmt.Tok,
                          etran.TrAttributes(stmt.Attributes, null))); // attributes go on every split
                    }
                }
            }

            if (MutateCSharp.Schemata500.ReplaceBinExprOp_21(211L, proofBuilder, null))
            {
                PathAsideBlock(stmt.Tok, proofBuilder, b);
            }

            stmtContext = StmtType.NONE; // done with translating assert stmt
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_14(213L, () => splitHappened, () => MutateCSharp.Schemata500.ReplaceBinExprOp_21(212L, proofBuilder, null)))
            {
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_9(221L, () => MutateCSharp.Schemata500.ReplaceBinExprOp_17(219L, assertStmt, null), () => MutateCSharp.Schemata500.ReplaceBinExprOp_19(220L, assertStmt.Label, null)))
                {
                    // make copies of the variables used in the assertion
                    var name = MutateCSharp.Schemata500.ReplaceStringConstant_1(227L, "$Heap_at_") + assertStmt.Label.AssignUniqueId(CurrentIdGenerator);
                    var heapAt = new Bpl.LocalVariable(stmt.Tok, new Bpl.TypedIdent(stmt.Tok, name, predef.HeapType));
                    locals.Add(heapAt);
                    var h = new Bpl.IdentifierExpr(stmt.Tok, heapAt);
                    b.Add(Bpl.Cmd.SimpleAssign(stmt.Tok, h, etran.HeapExpr));
                    var substMap = new Dictionary<IVariable, Expression>();
                    foreach (var v in FreeVariablesUtil.ComputeFreeVariables(options, assertStmt.Expr))
                    {
                        if (v is LocalVariable)
                        {
                            var vcopy = new LocalVariable(stmt.RangeToken, string.Format(MutateCSharp.Schemata500.ReplaceStringConstant_1(228L, "##{0}#{1}"), name, v.Name), v.Type,
                              v.IsGhost);
                            vcopy.type = vcopy.OptionalType; // resolve local here
                            IdentifierExpr ie = new IdentifierExpr(vcopy.Tok,
                              vcopy.AssignUniqueName(currentDeclaration.IdGenerator));
                            ie.Var = vcopy;
                            ie.Type = ie.Var.Type; // resolve ie here
                            substMap.Add(v, ie);
                            locals.Add(new Bpl.LocalVariable(vcopy.Tok,
                              new Bpl.TypedIdent(vcopy.Tok, vcopy.AssignUniqueName(currentDeclaration.IdGenerator),
                                TrType(vcopy.Type))));
                            b.Add(Bpl.Cmd.SimpleAssign(stmt.Tok, TrVar(stmt.Tok, vcopy), TrVar(stmt.Tok, v)));
                        }
                    }

                    var exprToBeRevealed = Substitute(assertStmt.Expr, null, substMap);
                    var etr = new ExpressionTranslator(etran, h);
                    assertStmt.Label.E = etr.TrExpr(exprToBeRevealed);
                }
                else if (!defineFuel)
                {
                    // Adding the assume stmt, resetting the stmtContext
                    stmtContext = StmtType.ASSUME;
                    adjustFuelForExists = MutateCSharp.Schemata500.ReplaceBooleanConstant_0(229L, true);
                    b.Add(TrAssumeCmdWithDependencies(etran, stmt.Tok, stmt.Expr, MutateCSharp.Schemata500.ReplaceStringConstant_1(230L, "assert statement"), MutateCSharp.Schemata500.ReplaceBooleanConstant_0(231L, true)));
                    stmtContext = StmtType.NONE;
                }
            }

            if (defineFuel)
            {
                var ifCmd = new Bpl.IfCmd(stmt.Tok, null, b.Collect(stmt.Tok), null,
                  null); // BUGBUG: shouldn't this first append "assume false" to "b"? (use PathAsideBlock to do this)  --KRML
                builder.Add(ifCmd);
                // Adding the assume stmt, resetting the stmtContext
                stmtContext = StmtType.ASSUME;
                adjustFuelForExists = MutateCSharp.Schemata500.ReplaceBooleanConstant_0(232L, true);
                builder.Add(TrAssumeCmdWithDependencies(etran, stmt.Tok, stmt.Expr, MutateCSharp.Schemata500.ReplaceStringConstant_1(233L, "assert statement"), MutateCSharp.Schemata500.ReplaceBooleanConstant_0(234L, true)));
                stmtContext = StmtType.NONE;
            }

            if (MutateCSharp.Schemata500.ReplaceBinExprOp_2(235L, options.TestGenOptions.Mode, TestGenerationOptions.Modes.None))
            {
                builder.AddCaptureState(stmt);
            }
        }

        private void TrCalcStmt(CalcStmt stmt, BoogieStmtListBuilder builder, List<Variable> locals, ExpressionTranslator etran)
        {
            Contract.Requires(stmt != null);
            Contract.Requires(builder != null);
            Contract.Requires(locals != null);
            Contract.Requires(etran != null);

            /* Translate into:
              if (*) {
                  assert wf(line0);
              } else if (*) {
                  assume wf(line0);
                  // if op is ==>: assume line0;
                  hint0;
                  assert wf(line1);
                  assert line0 op line1;
                  assume false;
              } else if (*) { ...
              } else if (*) {
                  assume wf(line<n-1>);
                  // if op is ==>: assume line<n-1>;
                  hint<n-1>;
                  assert wf(line<n>);
                  assert line<n-1> op line<n>;
                  assume false;
              }
              assume line<0> op line<n>;
              */
            Contract.Assert(stmt.Steps.Count == stmt.Hints.Count); // established by the resolver
            AddComment(builder, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(236L, "calc statement"));
            this.fuelContext = FuelSetting.ExpandFuelContext(stmt.Attributes, stmt.Tok, this.fuelContext, this.reporter);
            DefineFuelConstant(stmt.Tok, stmt.Attributes, builder, etran);
            CurrentIdGenerator.Push(); // put the entire calc statement within its own sub-branch
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_22(241L, stmt.Lines.Count, MutateCSharp.Schemata500.ReplaceNumericConstant_4(237L, 0)))
            {
                Bpl.IfCmd ifCmd = null;
                BoogieStmtListBuilder b;
                // if the dangling hint is empty, do not generate anything for the dummy step
                var stepCount = MutateCSharp.Schemata500.ReplaceBinExprOp_8(250L, stmt.Hints.Last().Body.Count, MutateCSharp.Schemata500.ReplaceNumericConstant_4(246L, 0)) ? MutateCSharp.Schemata500.ReplaceBinExprOp_23(259L, stmt.Steps.Count, MutateCSharp.Schemata500.ReplaceNumericConstant_4(255L, 1)) : stmt.Steps.Count;
                // check steps:
                for (int i = stepCount; MutateCSharp.Schemata500.ReplaceBinExprOp_25(276L, MutateCSharp.Schemata500.ReplaceNumericConstant_4(268L, 0), MutateCSharp.Schemata500.ReplacePrefixUnaryExprOp_24(272L, ref i));)
                {
                    b = new BoogieStmtListBuilder(this, options);
                    // assume wf[line<i>]:
                    AddComment(b, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(281L, "assume wf[lhs]"));
                    CurrentIdGenerator.Push();
                    assertAsAssume = MutateCSharp.Schemata500.ReplaceBooleanConstant_0(282L, true);
                    TrStmt_CheckWellformed(CalcStmt.Lhs(stmt.Steps[i]), b, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(283L, false));
                    assertAsAssume = MutateCSharp.Schemata500.ReplaceBooleanConstant_0(284L, false);
                    if (MutateCSharp.Schemata500.ReplaceBinExprOp_9(286L, () => stmt.Steps[i] is BinaryExpr, () => (MutateCSharp.Schemata500.ReplaceBinExprOp_26(285L, ((BinaryExpr)stmt.Steps[i]).ResolvedOp, BinaryExpr.ResolvedOpcode.Imp))))
                    {
                        // assume line<i>:
                        AddComment(b, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(292L, "assume lhs"));
                        b.Add(TrAssumeCmdWithDependencies(etran, stmt.Tok, CalcStmt.Lhs(stmt.Steps[i]), MutateCSharp.Schemata500.ReplaceStringConstant_1(293L, "calc statement step")));
                    }
                    // hint:
                    AddComment(b, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(294L, "Hint") + i.ToString());
                    TrStmt(stmt.Hints[i], b, locals, etran);
                    if (MutateCSharp.Schemata500.ReplaceBinExprOp_5(308L, i, MutateCSharp.Schemata500.ReplaceBinExprOp_23(299L, stmt.Steps.Count, MutateCSharp.Schemata500.ReplaceNumericConstant_4(295L, 1))))
                    {
                        // non-dummy step
                        // check well formedness of the goal line:
                        AddComment(b, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(313L, "assert wf[rhs]"));
                        if (stmt.Steps[i] is TernaryExpr)
                        {
                            // check the prefix-equality limit
                            var index = ((TernaryExpr)stmt.Steps[i]).E0;
                            TrStmt_CheckWellformed(index, b, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(314L, false));
                            if (index.Type.IsNumericBased(Type.NumericPersuasion.Int))
                            {
                                var desc = new PODesc.PrefixEqualityLimit();
                                b.Add(AssertNS(index.tok, Bpl.Expr.Le(Bpl.Expr.Literal(MutateCSharp.Schemata500.ReplaceNumericConstant_4(315L, 0)), etran.TrExpr(index)), desc));
                            }
                        }
                        TrStmt_CheckWellformed(CalcStmt.Rhs(stmt.Steps[i]), b, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(319L, false));
                        var ss = TrSplitExpr(stmt.Steps[i], etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(320L, true), out var splitHappened);
                        // assert step:
                        AddComment(b, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(321L, "assert line") + i.ToString() + MutateCSharp.Schemata500.ReplaceStringConstant_1(322L, " ") + (stmt.StepOps[i] ?? stmt.Op).ToString() + MutateCSharp.Schemata500.ReplaceStringConstant_1(323L, " line") + (MutateCSharp.Schemata500.ReplaceBinExprOp_27(328L, i, MutateCSharp.Schemata500.ReplaceNumericConstant_4(324L, 1))).ToString());
                        if (!splitHappened)
                        {
                            b.Add(AssertNS(stmt.Lines[MutateCSharp.Schemata500.ReplaceBinExprOp_27(341L, i, MutateCSharp.Schemata500.ReplaceNumericConstant_4(337L, 1))].tok, etran.TrExpr(stmt.Steps[i]), new PODesc.CalculationStep()));
                        }
                        else
                        {
                            foreach (var split in ss)
                            {
                                if (split.IsChecked)
                                {
                                    b.Add(AssertNS(stmt.Lines[MutateCSharp.Schemata500.ReplaceBinExprOp_27(354L, i, MutateCSharp.Schemata500.ReplaceNumericConstant_4(350L, 1))].tok, split.E, new PODesc.CalculationStep()));
                                }
                            }
                        }
                    }
                    b.Add(TrAssumeCmd(stmt.Tok, Bpl.Expr.False));
                    ifCmd = new Bpl.IfCmd(stmt.Tok, null, b.Collect(stmt.Tok), ifCmd, null);
                    CurrentIdGenerator.Pop();
                }
                // check well formedness of the first line:
                b = new BoogieStmtListBuilder(this, options);
                AddComment(b, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(363L, "assert wf[initial]"));
                Contract.Assert(stmt.Result != null); // established by the resolver
                TrStmt_CheckWellformed(CalcStmt.Lhs(stmt.Result), b, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(364L, false));
                b.Add(TrAssumeCmd(stmt.Tok, Bpl.Expr.False));
                ifCmd = new Bpl.IfCmd(stmt.Tok, null, b.Collect(stmt.Tok), ifCmd, null);
                builder.Add(ifCmd);
                // assume result:
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_22(369L, stmt.Steps.Count, MutateCSharp.Schemata500.ReplaceNumericConstant_4(365L, 1)))
                {
                    builder.Add(TrAssumeCmdWithDependencies(etran, stmt.Tok, stmt.Result, MutateCSharp.Schemata500.ReplaceStringConstant_1(374L, "calc statement result")));
                }
            }
            CurrentIdGenerator.Pop();
            this.fuelContext = FuelSetting.PopFuelContext();
        }

        private void TrMatchStmt(MatchStmt stmt, BoogieStmtListBuilder builder, List<Variable> locals, ExpressionTranslator etran)
        {
            Contract.Requires(stmt != null);
            Contract.Requires(builder != null);
            Contract.Requires(locals != null);
            Contract.Requires(etran != null);

            FillMissingCases(stmt);

            TrStmt_CheckWellformed(stmt.Source, builder, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(375L, true));
            Bpl.Expr source = etran.TrExpr(stmt.Source);
            var b = new BoogieStmtListBuilder(this, options);
            b.Add(TrAssumeCmd(stmt.Tok, Bpl.Expr.False));
            Bpl.StmtList els = b.Collect(stmt.Tok);
            Bpl.IfCmd ifCmd = null;
            foreach (var missingCtor in stmt.MissingCases)
            {
                // havoc all bound variables
                b = new BoogieStmtListBuilder(this, options);
                List<Variable> newLocals = new List<Variable>();
                Bpl.Expr r = CtorInvocation(stmt.Tok, missingCtor, etran, newLocals, b);
                locals.AddRange(newLocals);

                if (MutateCSharp.Schemata500.ReplaceBinExprOp_28(380L, newLocals.Count, MutateCSharp.Schemata500.ReplaceNumericConstant_4(376L, 0)))
                {
                    List<Bpl.IdentifierExpr> havocIds = new List<Bpl.IdentifierExpr>();
                    foreach (Variable local in newLocals)
                    {
                        havocIds.Add(new Bpl.IdentifierExpr(local.tok, local));
                    }
                    builder.Add(new Bpl.HavocCmd(stmt.Tok, havocIds));
                }
                String missingStr = stmt.Context.FillHole(new IdCtx(missingCtor)).AbstractAllHoles()
                  .ToString();
                var desc = new PODesc.MatchIsComplete(MutateCSharp.Schemata500.ReplaceStringConstant_1(385L, "statement"), missingStr);
                b.Add(Assert(stmt.Tok, Bpl.Expr.False, desc));

                Bpl.Expr guard = Bpl.Expr.Eq(source, r);
                ifCmd = new Bpl.IfCmd(stmt.Tok, guard, b.Collect(stmt.Tok), ifCmd, els);
                els = null;
            }
            for (int i = stmt.Cases.Count; MutateCSharp.Schemata500.ReplaceBinExprOp_25(394L, MutateCSharp.Schemata500.ReplaceNumericConstant_4(386L, 0), MutateCSharp.Schemata500.ReplacePrefixUnaryExprOp_24(390L, ref i));)
            {
                var mc = (MatchCaseStmt)stmt.Cases[i];
                CurrentIdGenerator.Push();
                // havoc all bound variables
                b = new BoogieStmtListBuilder(this, options);
                List<Variable> newLocals = new List<Variable>();
                Bpl.Expr r = CtorInvocation(mc, stmt.Source.Type, etran, newLocals, b, stmt.IsGhost ? NOALLOC : ISALLOC);
                locals.AddRange(newLocals);

                if (MutateCSharp.Schemata500.ReplaceBinExprOp_28(403L, newLocals.Count, MutateCSharp.Schemata500.ReplaceNumericConstant_4(399L, 0)))
                {
                    List<Bpl.IdentifierExpr> havocIds = new List<Bpl.IdentifierExpr>();
                    foreach (Variable local in newLocals)
                    {
                        havocIds.Add(new Bpl.IdentifierExpr(local.tok, local));
                    }
                    builder.Add(new Bpl.HavocCmd(mc.tok, havocIds));
                }

                // translate the body into b
                var prevDefiniteAssignmentTrackerCount = definiteAssignmentTrackers.Count;
                TrStmtList(mc.Body, b, locals, etran);
                RemoveDefiniteAssignmentTrackers(mc.Body, prevDefiniteAssignmentTrackerCount);

                Bpl.Expr guard = Bpl.Expr.Eq(source, r);
                ifCmd = new Bpl.IfCmd(mc.tok, guard, b.Collect(mc.tok), ifCmd, els);
                els = null;
                CurrentIdGenerator.Pop();
            }
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_29(408L, ifCmd, null))
            {
                builder.Add(ifCmd);
            }
        }

        void FillMissingCases(IMatch match)
        {
            Contract.Requires(match != null);
            if (match.MissingCases.Any())
            {
                return;
            }

            var dtd = match.Source.Type.AsDatatype;
            var constructors = dtd?.ConstructorsByName;

            ISet<string> memberNamesUsed = new HashSet<string>();

            foreach (var matchCase in match.Cases)
            {
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_30(409L, constructors, null))
                {
                    Contract.Assert(dtd != null);
                    var ctorId = matchCase.Ctor.Name;
                    if (match.Source.Type.AsDatatype is TupleTypeDecl)
                    {
                        var tuple = (TupleTypeDecl)match.Source.Type.AsDatatype;
                        ctorId = SystemModuleManager.TupleTypeCtorName(tuple.Dims);
                    }

                    if (constructors.ContainsKey(ctorId))
                    {
                        memberNamesUsed.Add(ctorId); // add mc.Id to the set of names used
                    }
                }
            }
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_9(416L, () => MutateCSharp.Schemata500.ReplaceBinExprOp_31(410L, dtd, null), () => MutateCSharp.Schemata500.ReplaceBinExprOp_28(411L, memberNamesUsed.Count, dtd.Ctors.Count)))
            {
                // We could complain about the syntactic omission of constructors:
                //   Reporter.Error(MessageSource.Resolver, stmt, "match statement does not cover all constructors");
                // but instead we let the verifier do a semantic check.
                // So, for now, record the missing constructors:
                foreach (var ctr in dtd.Ctors)
                {
                    if (!memberNamesUsed.Contains(ctr.Name))
                    {
                        match.MissingCases.Add(ctr);
                    }
                }
                Contract.Assert(memberNamesUsed.Count + match.MissingCases.Count == dtd.Ctors.Count);
            }
        }

        private void TrForLoop(ForLoopStmt stmt, BoogieStmtListBuilder builder, List<Variable> locals, ExpressionTranslator etran)
        {
            Contract.Requires(stmt != null);
            Contract.Requires(builder != null);
            Contract.Requires(locals != null);
            Contract.Requires(etran != null);

            AddComment(builder, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(422L, "for-loop statement"));

            var indexVar = stmt.LoopIndex;
            var indexVarName = indexVar.AssignUniqueName(currentDeclaration.IdGenerator);
            var dIndex = new IdentifierExpr(indexVar.tok, indexVar);
            var bIndexVar = new Bpl.LocalVariable(indexVar.tok, new Bpl.TypedIdent(indexVar.Tok, indexVarName, TrType(indexVar.Type)));
            locals.Add(bIndexVar);
            var bIndex = new Bpl.IdentifierExpr(indexVar.tok, indexVarName);

            var lo = stmt.GoingUp ? stmt.Start : stmt.End;
            var hi = stmt.GoingUp ? stmt.End : stmt.Start;
            Expression dLo = null;
            Expression dHi = null;
            Bpl.IdentifierExpr bLo = null;
            Bpl.IdentifierExpr bHi = null;
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_32(423L, lo, null))
            {
                var name = indexVarName + MutateCSharp.Schemata500.ReplaceStringConstant_1(424L, "#lo");
                var bLoVar = new Bpl.LocalVariable(lo.tok, new Bpl.TypedIdent(lo.tok, name, Bpl.Type.Int));
                locals.Add(bLoVar);
                bLo = new Bpl.IdentifierExpr(lo.tok, name);
                CheckWellformed(lo, new WFOptions(null, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(425L, false)), locals, builder, etran);
                builder.Add(Bpl.Cmd.SimpleAssign(lo.tok, bLo, etran.TrExpr(lo)));
                dLo = new BoogieWrapper(bLo, lo.Type);
            }
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_32(426L, hi, null))
            {
                var name = indexVarName + MutateCSharp.Schemata500.ReplaceStringConstant_1(427L, "#hi");
                var bHiVar = new Bpl.LocalVariable(hi.tok, new Bpl.TypedIdent(hi.tok, name, Bpl.Type.Int));
                locals.Add(bHiVar);
                bHi = new Bpl.IdentifierExpr(hi.tok, name);
                CheckWellformed(hi, new WFOptions(null, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(428L, false)), locals, builder, etran);
                builder.Add(Bpl.Cmd.SimpleAssign(hi.tok, bHi, etran.TrExpr(hi)));
                dHi = new BoogieWrapper(bHi, hi.Type);
            }

            // check lo <= hi
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_9(431L, () => MutateCSharp.Schemata500.ReplaceBinExprOp_32(429L, lo, null), () => MutateCSharp.Schemata500.ReplaceBinExprOp_32(430L, hi, null)))
            {
                builder.Add(Assert(lo.tok, Bpl.Expr.Le(bLo, bHi), new PODesc.ForRangeBoundsValid(lo, hi)));
            }
            // check forall x :: lo <= x <= hi ==> Is(x, typ)
            {
                // The check, if needed, is performed like this:
                //   var x: int;
                //   havoc x;
                //   assume lo <= x <= hi;
                //   assert Is(x, typ);
                var tok = indexVar.tok;
                var name = indexVarName + MutateCSharp.Schemata500.ReplaceStringConstant_1(437L, "#x");
                var xVar = new Bpl.LocalVariable(tok, new Bpl.TypedIdent(tok, name, Bpl.Type.Int));
                var x = new Bpl.IdentifierExpr(tok, name);
                var cre = GetSubrangeCheck(x, Type.Int, indexVar.Type, out var desc);
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_15(438L, cre, null))
                {
                    locals.Add(xVar);
                    builder.Add(new Bpl.HavocCmd(tok, new List<Bpl.IdentifierExpr>() { x }));
                    builder.Add(new Bpl.AssumeCmd(tok, ForLoopBounds(x, bLo, bHi)));
                    List<Expression> dafnyRangeBounds = new();
                    if (MutateCSharp.Schemata500.ReplaceBinExprOp_32(439L, lo, null))
                    {
                        dafnyRangeBounds.Add(new BinaryExpr(stmt.tok, BinaryExpr.Opcode.Le, lo, dIndex));
                    }
                    if (MutateCSharp.Schemata500.ReplaceBinExprOp_32(440L, hi, null))
                    {
                        dafnyRangeBounds.Add(new BinaryExpr(stmt.tok, BinaryExpr.Opcode.Le, dIndex, hi));
                    }

                    Expression dafnyRange = MutateCSharp.Schemata500.ReplaceBinExprOp_8(445L, dafnyRangeBounds.Count, MutateCSharp.Schemata500.ReplaceNumericConstant_4(441L, 1
          )) ? dafnyRangeBounds[MutateCSharp.Schemata500.ReplaceNumericConstant_4(450L, 0)]
                      : new BinaryExpr(stmt.tok, BinaryExpr.Opcode.And, dafnyRangeBounds[MutateCSharp.Schemata500.ReplaceNumericConstant_4(454L, 0)], dafnyRangeBounds[MutateCSharp.Schemata500.ReplaceNumericConstant_4(458L, 1)]);
                    var dafnyAssertion = new ForallExpr(stmt.tok, stmt.RangeToken, new List<BoundVar> { indexVar },
                      dafnyRange, new TypeTestExpr(indexVar.tok, dIndex, indexVar.Type), null);
                    builder.Add(Assert(tok, cre, new PODesc.ForRangeAssignable(desc, dafnyAssertion)));
                }
            }

            // initialize the index variable
            builder.Add(Bpl.Cmd.SimpleAssign(indexVar.tok, bIndex, stmt.GoingUp ? bLo : bHi));

            // build the guard expression
            Expression guard;
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_14(464L, () => MutateCSharp.Schemata500.ReplaceBinExprOp_33(462L, lo, null), () => MutateCSharp.Schemata500.ReplaceBinExprOp_33(463L, hi, null)))
            {
                guard = LiteralExpr.CreateBoolLiteral(stmt.Tok, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(470L, true));
            }
            else
            {
                guard = Expression.CreateNot(stmt.Tok, Expression.CreateEq(dIndex, stmt.GoingUp ? dHi : dLo, indexVar.Type));
            }

            // free invariant lo <= i <= hi
            var freeInvariant = ForLoopBounds(bIndex, bLo, bHi);

            BodyTranslator bodyTr = null;
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_18(471L, stmt.Body, null))
            {
                bodyTr = delegate (BoogieStmtListBuilder bld, ExpressionTranslator e)
                {
                    CurrentIdGenerator.Push();
                    if (!stmt.GoingUp)
                    {
                        bld.Add(Bpl.Cmd.SimpleAssign(stmt.Tok, bIndex, Bpl.Expr.Sub(bIndex, Bpl.Expr.Literal(MutateCSharp.Schemata500.ReplaceNumericConstant_4(472L, 1)))));
                    }
                    TrStmt(stmt.Body, bld, locals, e);
                    InsertContinueTarget(stmt, bld);
                    if (stmt.GoingUp)
                    {
                        bld.Add(Bpl.Cmd.SimpleAssign(stmt.Tok, bIndex, Bpl.Expr.Add(bIndex, Bpl.Expr.Literal(MutateCSharp.Schemata500.ReplaceNumericConstant_4(476L, 1)))));
                    }
                    CurrentIdGenerator.Pop();
                };
            }

            TrLoop(stmt, guard, bodyTr, builder, locals, etran, freeInvariant, MutateCSharp.Schemata500.ReplaceBinExprOp_28(484L, stmt.Decreases.Expressions.Count, MutateCSharp.Schemata500.ReplaceNumericConstant_4(480L, 0)));
        }

        private void TrWhileStmt(WhileStmt stmt, BoogieStmtListBuilder builder, List<Variable> locals, ExpressionTranslator etran)
        {
            Contract.Requires(stmt != null);
            Contract.Requires(builder != null);
            Contract.Requires(locals != null);
            Contract.Requires(etran != null);

            AddComment(builder, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(489L, "while statement"));
            this.fuelContext = FuelSetting.ExpandFuelContext(stmt.Attributes, stmt.Tok, this.fuelContext, this.reporter);
            DefineFuelConstant(stmt.Tok, stmt.Attributes, builder, etran);
            BodyTranslator bodyTr = null;
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_18(490L, stmt.Body, null))
            {
                bodyTr = delegate (BoogieStmtListBuilder bld, ExpressionTranslator e)
                {
                    CurrentIdGenerator.Push();
                    TrStmt(stmt.Body, bld, locals, e);
                    InsertContinueTarget(stmt, bld);
                    CurrentIdGenerator.Pop();
                };
            }
            TrLoop(stmt, stmt.Guard, bodyTr, builder, locals, etran);
            this.fuelContext = FuelSetting.PopFuelContext();
        }

        private void TrIfStmt(IfStmt stmt, BoogieStmtListBuilder builder, List<Variable> locals, ExpressionTranslator etran)
        {
            Contract.Requires(stmt != null);
            Contract.Requires(builder != null);
            Contract.Requires(locals != null);
            Contract.Requires(etran != null);

            AddComment(builder, stmt, MutateCSharp.Schemata500.ReplaceStringConstant_1(491L, "if statement"));
            Expression guard;
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_33(492L, stmt.Guard, null))
            {
                guard = null;
            }
            else
            {
                guard = stmt.IsBindingGuard ? ((ExistsExpr)stmt.Guard).AlphaRename(MutateCSharp.Schemata500.ReplaceStringConstant_1(493L, "eg$")) : stmt.Guard;
                TrStmt_CheckWellformed(guard, builder, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(494L, true));
            }
            BoogieStmtListBuilder b = new BoogieStmtListBuilder(this, options);
            if (stmt.IsBindingGuard)
            {
                CurrentIdGenerator.Push();
                var exists = (ExistsExpr)stmt.Guard; // the original (that is, not alpha-renamed) guard
                IntroduceAndAssignExistentialVars(exists, b, builder, locals, etran, stmt.IsGhost);
                CurrentIdGenerator.Pop();
            }
            CurrentIdGenerator.Push();
            Bpl.StmtList thn = TrStmt2StmtList(b, stmt.Thn, locals, etran);
            CurrentIdGenerator.Pop();
            Bpl.StmtList els;
            Bpl.IfCmd elsIf = null;
            b = new BoogieStmtListBuilder(this, options);
            if (stmt.IsBindingGuard)
            {
                b.Add(TrAssumeCmdWithDependenciesAndExtend(etran, guard.tok, guard, Expr.Not, MutateCSharp.Schemata500.ReplaceStringConstant_1(495L, "if statement binding guard")));
            }
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_34(496L, stmt.Els, null))
            {
                els = b.Collect(stmt.Tok);
            }
            else
            {
                CurrentIdGenerator.Push();
                els = TrStmt2StmtList(b, stmt.Els, locals, etran);
                CurrentIdGenerator.Pop();
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_8(501L, els.BigBlocks.Count, MutateCSharp.Schemata500.ReplaceNumericConstant_4(497L, 1)))
                {
                    Bpl.BigBlock bb = els.BigBlocks[MutateCSharp.Schemata500.ReplaceNumericConstant_4(506L, 0)];
                    if (MutateCSharp.Schemata500.ReplaceBinExprOp_9(525L, () => MutateCSharp.Schemata500.ReplaceBinExprOp_9(519L, () => bb.LabelName == null, () => MutateCSharp.Schemata500.ReplaceBinExprOp_8(514L, bb.simpleCmds.Count, MutateCSharp.Schemata500.ReplaceNumericConstant_4(510L, 0))), () => bb.ec is Bpl.IfCmd))
                    {
                        elsIf = (Bpl.IfCmd)bb.ec;
                        els = null;
                    }
                }
            }
            builder.Add(new Bpl.IfCmd(stmt.Tok, MutateCSharp.Schemata500.ReplaceBinExprOp_14(532L, () => MutateCSharp.Schemata500.ReplaceBinExprOp_33(531L, guard, null), () => stmt.IsBindingGuard) ? null : etran.TrExpr(guard), thn, elsIf, els));
        }


        void TrForallProof(ForallStmt s, BoogieStmtListBuilder definedness, BoogieStmtListBuilder exporter, List<Variable> locals, ExpressionTranslator etran)
        {
            // Translate:
            //   forall (x,y | Range(x,y))
            //     ensures Post(x,y);
            //   {
            //     Body;
            //   }
            // as:
            //   if (*) {
            //     var x,y;
            //     havoc x,y;
            //     CheckWellformed( Range );
            //     assume Range(x,y);
            //     CheckWellformed( Post );
            //     Tr( Body );       // include only if there is a Body
            //     assert Post;      // include only if there is a Body
            //     assume false;
            //   } else {
            //     assume (forall x,y :: Range(x,y) ==> Post(x,y));
            //   }

            if (MutateCSharp.Schemata500.ReplaceBinExprOp_28(542L, s.BoundVars.Count, MutateCSharp.Schemata500.ReplaceNumericConstant_4(538L, 0)))
            {
                // Note, it would be nicer (and arguably more appropriate) to do a SetupBoundVarsAsLocals
                // here (rather than a TrBoundVariables).  However, there is currently no way to apply
                // a substMap to a statement (in particular, to s.Body), so that doesn't work here.
                List<bool> freeOfAlloc = BoundedPool.HasBounds(s.Bounds, BoundedPool.PoolVirtues.IndependentOfAlloc_or_ExplicitAlloc);

                var bVars = new List<Variable>();
                var typeAntecedent = etran.TrBoundVariables(s.BoundVars, bVars, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(547L, true), freeOfAlloc);
                locals.AddRange(bVars);
                var havocIds = new List<Bpl.IdentifierExpr>();
                foreach (Bpl.Variable bv in bVars)
                {
                    havocIds.Add(new Bpl.IdentifierExpr(s.Tok, bv));
                }
                definedness.Add(new Bpl.HavocCmd(s.Tok, havocIds));
                definedness.Add(TrAssumeCmd(s.Tok, typeAntecedent));
            }
            TrStmt_CheckWellformed(s.Range, definedness, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(548L, false));
            definedness.Add(TrAssumeCmdWithDependencies(etran, s.Range.tok, s.Range, MutateCSharp.Schemata500.ReplaceStringConstant_1(549L, "forall statement range")));

            var ensuresDefinedness = new BoogieStmtListBuilder(this, options);
            foreach (var ens in s.Ens)
            {
                TrStmt_CheckWellformed(ens.E, ensuresDefinedness, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(550L, false));
                ensuresDefinedness.Add(TrAssumeCmdWithDependencies(etran, ens.E.tok, ens.E, MutateCSharp.Schemata500.ReplaceStringConstant_1(551L, "forall statement ensures clause")));
            }
            PathAsideBlock(s.Tok, ensuresDefinedness, definedness);

            if (MutateCSharp.Schemata500.ReplaceBinExprOp_35(552L, s.Body, null))
            {
                TrStmt(s.Body, definedness, locals, etran);

                // check that postconditions hold
                foreach (var ens in s.Ens)
                {
                    foreach (var split in TrSplitExpr(ens.E, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(553L, true), out var splitHappened))
                    {
                        if (split.IsChecked)
                        {
                            definedness.Add(Assert(split.Tok, split.E, new PODesc.ForallPostcondition(ens.E)));
                        }
                    }
                }
            }

            definedness.Add(TrAssumeCmd(s.Tok, Bpl.Expr.False));

            // Now for the other branch, where the ensures clauses are exported.
            // If the forall body has side effect such as call to a reveal function,
            // it needs to be exported too.
            var se = MutateCSharp.Schemata500.ReplaceBinExprOp_34(554L, s.Body, null) ? Bpl.Expr.True : TrFunctionSideEffect(s.Body, etran);
            var substMap = new Dictionary<IVariable, Expression>();
            var p = Substitute(s.EffectiveEnsuresClauses[MutateCSharp.Schemata500.ReplaceNumericConstant_4(555L, 0)], null, substMap);
            var qq = etran.TrExpr(p);
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_28(563L, s.BoundVars.Count, MutateCSharp.Schemata500.ReplaceNumericConstant_4(559L, 0)))
            {
                exporter.Add(TrAssumeCmd(s.Tok, BplAnd(se, qq)));
            }
            else
            {
                exporter.Add(TrAssumeCmd(s.Tok, BplAnd(se, ((Bpl.ForallExpr)qq).Body)));
            }
        }

        /// <summary>
        /// "lhs" is expected to be a resolved form of an expression, i.e., not a concrete-syntax expression.
        /// </summary>
        void TrAssignment(Statement stmt, Expression lhs, AssignmentRhs rhs,
          BoogieStmtListBuilder builder, List<Variable> locals, ExpressionTranslator etran)
        {
            Contract.Requires(stmt != null);
            Contract.Requires(lhs != null);
            Contract.Requires(!(lhs is ConcreteSyntaxExpression));
            Contract.Requires(!(lhs is SeqSelectExpr && !((SeqSelectExpr)lhs).SelectOne));  // these were once allowed, but their functionality is now provided by 'forall' statements
            Contract.Requires(rhs != null);
            Contract.Requires(builder != null);
            Contract.Requires(cce.NonNullElements(locals));
            Contract.Requires(etran != null);
            Contract.Requires(predef != null);

            var lhss = new List<Expression>() { lhs };
            ProcessLhss(lhss, rhs.CanAffectPreviouslyKnownExpressions, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(568L, true), builder, locals, etran, stmt,
              out var lhsBuilder, out var bLhss, out var ignore1, out var ignore2, out var ignore3);
            Contract.Assert(lhsBuilder.Count == 1 && bLhss.Count == 1);  // guaranteed by postcondition of ProcessLhss

            var rhss = new List<AssignmentRhs>() { rhs };
            ProcessRhss(lhsBuilder, bLhss, lhss, rhss, builder, locals, etran, stmt);
            builder.AddCaptureState(stmt);
        }

        void TrForallAssign(ForallStmt s, AssignStmt s0,
          BoogieStmtListBuilder definedness, BoogieStmtListBuilder updater, List<Variable> locals, ExpressionTranslator etran)
        {
            // The statement:
            //   forall (x,y | Range(x,y)) {
            //     (a)   E(x,y) . f :=  G(x,y);
            //     (b)   A(x,y) [ I0(x,y), I1(x,y), ... ] :=  G(x,y);
            //   }
            // translate into:
            //   if (*) {
            //     // check definedness of Range
            //     var x,y;
            //     havoc x,y;
            //     CheckWellformed( Range );
            //     assume Range;
            //     // check definedness of the other expressions
            //     (a)
            //       CheckWellformed( E.F );
            //       check that E.f is in the modifies frame;
            //       CheckWellformed( G );
            //       check nat restrictions for the RHS
            //     (b)
            //       CheckWellformed( A[I0,I1,...] );
            //       check that A[I0,I1,...] is in the modifies frame;
            //       CheckWellformed( G );
            //       check nat restrictions for the RHS
            //     // check for duplicate LHSs
            //     var x', y';
            //     havoc x', y';
            //     assume Range[x,y := x',y'];
            //     assume !(x == x' && y == y');
            //     (a)
            //       assert E(x,y) != E(x',y') || G(x,y) == G(x',y');
            //     (b)
            //       assert !( A(x,y)==A(x',y') && I0(x,y)==I0(x',y') && I1(x,y)==I1(x',y') && ... ) || G(x,y) == G(x',y');
            //
            //     assume false;
            //
            //   } else {
            //     var oldHeap := $Heap;
            //     havoc $Heap;
            //     assume $HeapSucc(oldHeap, $Heap);
            //     (a)
            //       assume (forall o: ref, F: Field ::
            //         { $Heap[o,F] }
            //         $Heap[o,F] = oldHeap[o,F] ||
            //         (exists x,y :: Range(x,y) && o == E(x,y) && F = f));
            //       assume (forall x,y ::  Range ==> $Heap[ E[$Heap:=oldHeap], F] == G[$Heap:=oldHeap]); (**)
            //     (b)
            //       assume (forall o: ref, F: Field ::
            //         { $Heap[o,F] }
            //         $Heap[o,F] = oldHeap[o,F] ||
            //         (exists x,y :: Range(x,y) && o == A(x,y) && F = Index(I0,I1,...)));
            //       assume (forall x,y ::  Range ==> $Heap[ A[$Heap:=oldHeap], Index(I0,I1,...)] == G[$Heap:=oldHeap]); (**)
            //   }
            //
            // Note: In order to get a good trigger for the quantifiers (**), we will attempt to make the parameters
            // that select from $Heap in the LHS of the equalities as plain as possible.  This involves taking the inverse
            // of an expression, which isn't always easy or possible, so we settle for handling some common cases.  In
            // particular, we change:
            //   0: forall i | R(i) { F(i).f := E(i); }
            //   1: forall i | R(i) { A[F(i)] := E(i); }
            //   2: forall i | R(i) { F(i)[N] := E(i); }
            // where f is some field and A and N are expressions that do not depend on i, into:
            //   0: forall j | Q(j) { j.f := E(F-1(j)); }
            //   1: forall j | Q(j) { A[j] := E(F-1(j)); }
            //   2: forall j | Q(j) { j[N] := E(F-1(j)); }
            // where we ensure that, for all i and j:
            //   R(i) && j == F(i)    <==>    Q(j) && F-1(j) == i
            // If the transformation succeeds, we use, respectively, j.f, A[j], and j[N] (each evaluated in the new heap) as
            // the trigger of the quantifier generated.

            var substMap = SetupBoundVarsAsLocals(s.BoundVars, definedness, locals, etran);
            Expression range = Substitute(s.Range, null, substMap);
            TrStmt_CheckWellformed(range, definedness, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(569L, false));
            definedness.Add(TrAssumeCmd(s.Range.tok, etran.TrExpr(range)));

            var lhs = Substitute(s0.Lhs.Resolved, null, substMap);
            TrStmt_CheckWellformed(lhs, definedness, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(570L, false));
            string description = GetObjFieldDetails(lhs, etran, out var obj, out var F);
            definedness.Add(Assert(lhs.tok, Bpl.Expr.SelectTok(lhs.tok, etran.ModifiesFrame(lhs.tok), obj, F),
              new PODesc.Modifiable(description)));
            if (s0.Rhs is ExprRhs)
            {
                var r = (ExprRhs)s0.Rhs;
                var rhs = Substitute(r.Expr, null, substMap);
                TrStmt_CheckWellformed(rhs, definedness, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(571L, false));
                // check nat restrictions for the RHS
                Type lhsType;
                if (lhs is MemberSelectExpr)
                {
                    lhsType = ((MemberSelectExpr)lhs).Type;
                }
                else if (lhs is SeqSelectExpr)
                {
                    lhsType = ((SeqSelectExpr)lhs).Type;
                }
                else
                {
                    lhsType = ((MultiSelectExpr)lhs).Type;
                }
                var translatedRhs = etran.TrExpr(rhs);
                CheckSubrange(r.Tok, translatedRhs, rhs.Type, lhsType, definedness);
                if (lhs is MemberSelectExpr)
                {
                    var fse = (MemberSelectExpr)lhs;
                    var field = fse.Member as Field;
                    Contract.Assert(field != null);
                    Check_NewRestrictions(fse.tok, obj, field, translatedRhs, definedness, etran);
                }
            }

            // check for duplicate LHSs
            if (s0.Rhs is ExprRhs)
            {  // if Rhs denotes a havoc, then no duplicate check is performed
                var substMapPrime = SetupBoundVarsAsLocals(s.BoundVars, definedness, locals, etran);
                var lhsPrime = Substitute(s0.Lhs.Resolved, null, substMapPrime);
                range = Substitute(s.Range, null, substMapPrime);
                definedness.Add(TrAssumeCmd(range.tok, etran.TrExpr(range)));
                // assume !(x == x' && y == y');
                Bpl.Expr eqs = Bpl.Expr.True;
                foreach (var bv in s.BoundVars)
                {
                    var x = substMap[bv];
                    var xPrime = substMapPrime[bv];
                    // TODO: in the following line, is the term equality okay, or does it have to include things like Set#Equal sometimes too?
                    eqs = BplAnd(eqs, Bpl.Expr.Eq(etran.TrExpr(x), etran.TrExpr(xPrime)));
                }
                definedness.Add(TrAssumeCmd(s.Tok, Bpl.Expr.Not(eqs)));
                GetObjFieldDetails(lhsPrime, etran, out var objPrime, out var FPrime);
                var Rhs = ((ExprRhs)s0.Rhs).Expr;
                var rhs = etran.TrExpr(Substitute(Rhs, null, substMap));
                var rhsPrime = etran.TrExpr(Substitute(Rhs, null, substMapPrime));
                definedness.Add(Assert(s0.Tok,
                  BplOr(
                    BplOr(Bpl.Expr.Neq(obj, objPrime), Bpl.Expr.Neq(F, FPrime)),
                    Bpl.Expr.Eq(rhs, rhsPrime)),
                  new PODesc.ForallLHSUnique()));
            }

            definedness.Add(TrAssumeCmd(s.Tok, Bpl.Expr.False));

            // Now for the translation of the update itself

            Bpl.IdentifierExpr prevHeap = GetPrevHeapVar_IdExpr(s.Tok, locals);
            var prevEtran = new ExpressionTranslator(this, predef, prevHeap, etran.scope);
            updater.Add(Bpl.Cmd.SimpleAssign(s.Tok, prevHeap, etran.HeapExpr));
            updater.Add(new Bpl.HavocCmd(s.Tok, new List<Bpl.IdentifierExpr> { etran.HeapCastToIdentifierExpr }));
            updater.Add(TrAssumeCmd(s.Tok, HeapSucc(prevHeap, etran.HeapExpr)));

            // Here comes:
            //   assume (forall o: ref, f: Field ::
            //     { $Heap[o,f] }
            //     $Heap[o,f] = oldHeap[o,f] ||
            //     (exists x,y :: Range(x,y)[$Heap:=oldHeap] &&
            //                    o == Object(x,y)[$Heap:=oldHeap] && f == Field(x,y)[$Heap:=oldHeap]));
            Bpl.BoundVariable oVar = new Bpl.BoundVariable(s.Tok, new Bpl.TypedIdent(s.Tok, MutateCSharp.Schemata500.ReplaceStringConstant_1(572L, "$o"), predef.RefType));
            Bpl.IdentifierExpr o = new Bpl.IdentifierExpr(s.Tok, oVar);
            Bpl.BoundVariable fVar = new Bpl.BoundVariable(s.Tok, new Bpl.TypedIdent(s.Tok, MutateCSharp.Schemata500.ReplaceStringConstant_1(573L, "$f"), predef.FieldName(s.Tok)));
            Bpl.IdentifierExpr f = new Bpl.IdentifierExpr(s.Tok, fVar);
            Bpl.Expr heapOF = ReadHeap(s.Tok, etran.HeapExpr, o, f);
            Bpl.Expr oldHeapOF = ReadHeap(s.Tok, prevHeap, o, f);
            List<bool> freeOfAlloc = BoundedPool.HasBounds(s.Bounds, BoundedPool.PoolVirtues.IndependentOfAlloc_or_ExplicitAlloc);
            List<Variable> xBvars = new List<Variable>();
            var xBody = etran.TrBoundVariables(s.BoundVars, xBvars, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(574L, false), freeOfAlloc);
            xBody = BplAnd(xBody, prevEtran.TrExpr(s.Range));
            GetObjFieldDetails(s0.Lhs.Resolved, prevEtran, out var xObj, out var xField);
            xBody = BplAnd(xBody, Bpl.Expr.Eq(o, xObj));
            xBody = BplAnd(xBody, Bpl.Expr.Eq(f, xField));
            //TRIG (exists k#2: int :: (k#2 == LitInt(0 - 3) || k#2 == LitInt(4)) && $o == read($prevHeap, this, _module.MyClass.arr) && $f == MultiIndexField(IndexField(i#0), j#0))
            Bpl.Expr xObjField = new Bpl.ExistsExpr(s.Tok, xBvars, xBody);  // LL_TRIGGER
            Bpl.Expr body = BplOr(Bpl.Expr.Eq(heapOF, oldHeapOF), xObjField);
            var tr = new Trigger(s.Tok, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(575L, true), new List<Expr>() { heapOF });
            Bpl.Expr qq = new Bpl.ForallExpr(s.Tok, new List<TypeVariable> { }, new List<Variable> { oVar, fVar }, null, tr, body);
            updater.Add(TrAssumeCmd(s.Tok, qq));

            if (MutateCSharp.Schemata500.ReplaceBinExprOp_36(576L, s.EffectiveEnsuresClauses, null))
            {
                foreach (ForallExpr expr in s.EffectiveEnsuresClauses)
                {
                    BinaryExpr term = (BinaryExpr)expr.Term;
                    Contract.Assert(term != null);
                    var e0 = ((BinaryExpr)term).E0.Resolved;
                    var e1 = ((BinaryExpr)term).E1;
                    qq = TrForall_NewValueAssumption(expr.tok, expr.BoundVars, expr.Bounds, expr.Range, e0, e1, expr.Attributes, etran, prevEtran);
                    updater.Add(TrAssumeCmd(s.Tok, qq));
                }
            }
        }

        /// <summary>
        /// Generate:
        ///   assume (forall x,y :: Range(x,y)[$Heap:=oldHeap] ==>
        ///                         $Heap[ Object(x,y)[$Heap:=oldHeap], Field(x,y)[$Heap:=oldHeap] ] == G[$Heap:=oldHeap] ));
        /// where
        ///   x,y           represent boundVars
        ///   Object(x,y)   is the first part of lhs
        ///   Field(x,y)    is the second part of lhs
        ///   G             is rhs
        /// If lhsAsTrigger is true, then use the LHS of the equality above as the trigger; otherwise, don't specify any trigger.
        /// </summary>
        private Bpl.Expr TrForall_NewValueAssumption(IToken tok, List<BoundVar> boundVars, List<BoundedPool> bounds, Expression range, Expression lhs, Expression rhs, Attributes attributes, ExpressionTranslator etran, ExpressionTranslator prevEtran)
        {
            Contract.Requires(tok != null);
            Contract.Requires(boundVars != null);
            Contract.Requires(bounds != null);
            Contract.Requires(range != null);
            Contract.Requires(lhs != null);
            Contract.Requires(rhs != null);
            Contract.Requires(etran != null);
            Contract.Requires(prevEtran != null);

            List<bool> freeOfAlloc = BoundedPool.HasBounds(bounds, BoundedPool.PoolVirtues.IndependentOfAlloc_or_ExplicitAlloc);
            var xBvars = new List<Variable>();
            Bpl.Expr xAnte = etran.TrBoundVariables(boundVars, xBvars, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(577L, false), freeOfAlloc);
            xAnte = BplAnd(xAnte, prevEtran.TrExpr(range));
            var g = prevEtran.TrExpr(rhs);
            GetObjFieldDetails(lhs, prevEtran, out var obj, out var field);
            var xHeapOF = ReadHeap(tok, etran.HeapExpr, obj, field);

            g = BoxIfNotNormallyBoxed(rhs.tok, g, rhs.Type);

            Bpl.Trigger tr = null;
            var argsEtran = etran.WithNoLits();
            foreach (var aa in attributes.AsEnumerable())
            {
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_37(579L, aa.Name, MutateCSharp.Schemata500.ReplaceStringConstant_1(578L, "trigger")))
                {
                    List<Bpl.Expr> tt = new List<Bpl.Expr>();
                    foreach (var arg in aa.Args)
                    {
                        if (MutateCSharp.Schemata500.ReplaceBinExprOp_38(580L, arg, lhs))
                        {
                            tt.Add(xHeapOF);
                        }
                        else
                        {
                            tt.Add(argsEtran.TrExpr(arg));
                        }
                    }
                    tr = new Bpl.Trigger(tok, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(581L, true), tt, tr);
                }
            }
            return new Bpl.ForallExpr(tok, xBvars, tr, BplImp(xAnte, Bpl.Expr.Eq(xHeapOF, g)));
        }

        void TrLoop(LoopStmt s, Expression Guard, BodyTranslator/*?*/ bodyTr,
                    BoogieStmtListBuilder builder, List<Variable> locals, ExpressionTranslator etran,
                    Bpl.Expr freeInvariant = null, bool includeTerminationCheck = true)
        {
            Contract.Requires(s != null);
            Contract.Requires(builder != null);
            Contract.Requires(locals != null);
            Contract.Requires(etran != null);

            var suffix = CurrentIdGenerator.FreshId(MutateCSharp.Schemata500.ReplaceStringConstant_1(582L, "loop#"));

            var theDecreases = s.Decreases.Expressions;

            Bpl.LocalVariable preLoopHeapVar = new Bpl.LocalVariable(s.Tok, new Bpl.TypedIdent(s.Tok, MutateCSharp.Schemata500.ReplaceStringConstant_1(583L, "$PreLoopHeap$") + suffix, predef.HeapType));
            locals.Add(preLoopHeapVar);
            Bpl.IdentifierExpr preLoopHeap = new Bpl.IdentifierExpr(s.Tok, preLoopHeapVar);
            ExpressionTranslator etranPreLoop = new ExpressionTranslator(this, predef, preLoopHeap, etran.scope);
            ExpressionTranslator updatedFrameEtran;
            string loopFrameName = MutateCSharp.Schemata500.ReplaceStringConstant_1(584L, "$Frame$") + suffix;
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_39(585L, s.Mod.Expressions, null))
            {
                updatedFrameEtran = etran.WithModifiesFrame(loopFrameName);
            }
            else
            {
                updatedFrameEtran = etran;
            }

            if (MutateCSharp.Schemata500.ReplaceBinExprOp_39(586L, s.Mod.Expressions, null))
            { // check well-formedness and that the modifies is a subset
                CheckFrameWellFormed(new WFOptions(), s.Mod.Expressions, locals, builder, etran);
                CheckFrameSubset(s.Tok, s.Mod.Expressions, null, null, etran, etran.ModifiesFrame(s.Tok), builder, new PODesc.ModifyFrameSubset(MutateCSharp.Schemata500.ReplaceStringConstant_1(587L, "loop modifies clause")), null);
                DefineFrame(s.Tok, etran.ModifiesFrame(s.Tok), s.Mod.Expressions, builder, locals, loopFrameName);
            }
            builder.Add(Bpl.Cmd.SimpleAssign(s.Tok, preLoopHeap, etran.HeapExpr));

            var daTrackersMonotonicity = new List<Tuple<Bpl.IdentifierExpr, Bpl.IdentifierExpr>>();
            foreach (var dat in definiteAssignmentTrackers.Values)
            {  // TODO: the order is non-deterministic and may change between invocations of Dafny
                var preLoopDat = new Bpl.LocalVariable(dat.tok, new Bpl.TypedIdent(dat.tok, MutateCSharp.Schemata500.ReplaceStringConstant_1(588L, "preLoop$") + suffix + MutateCSharp.Schemata500.ReplaceStringConstant_1(589L, "$") + dat.Name, dat.Type));
                locals.Add(preLoopDat);
                var ie = new Bpl.IdentifierExpr(s.Tok, preLoopDat);
                daTrackersMonotonicity.Add(new Tuple<Bpl.IdentifierExpr, Bpl.IdentifierExpr>(ie, dat));
                builder.Add(Bpl.Cmd.SimpleAssign(s.Tok, ie, dat));
            }

            List<Bpl.Expr> initDecr = null;
            if (!Contract.Exists(theDecreases, e => e is WildcardExpr))
            {
                initDecr = RecordDecreasesValue(theDecreases, builder, locals, etran, MutateCSharp.Schemata500.ReplaceStringConstant_1(590L, "$decr_init$") + suffix);
            }

            // The variable w is used to coordinate the definedness checking of the loop invariant.
            // It is also used for body-less loops to turn off invariant checking after the generated body.
            Bpl.LocalVariable wVar = new Bpl.LocalVariable(s.Tok, new Bpl.TypedIdent(s.Tok, MutateCSharp.Schemata500.ReplaceStringConstant_1(591L, "$w$") + suffix, Bpl.Type.Bool));
            Bpl.IdentifierExpr w = new Bpl.IdentifierExpr(s.Tok, wVar);
            locals.Add(wVar);
            // havoc w;
            builder.Add(new Bpl.HavocCmd(s.Tok, new List<Bpl.IdentifierExpr> { w }));

            List<Bpl.PredicateCmd> invariants = new List<Bpl.PredicateCmd>();
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_15(592L, freeInvariant, null))
            {
                invariants.Add(new Bpl.AssumeCmd(freeInvariant.tok, freeInvariant));
            }
            BoogieStmtListBuilder invDefinednessBuilder = new BoogieStmtListBuilder(this, options);
            foreach (AttributedExpression loopInv in s.Invariants)
            {
                var (errorMessage, successMessage) = CustomErrorMessage(loopInv.Attributes);
                TrStmt_CheckWellformed(loopInv.E, invDefinednessBuilder, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(593L, false));
                invDefinednessBuilder.Add(TrAssumeCmdWithDependencies(etran, loopInv.E.tok, loopInv.E, MutateCSharp.Schemata500.ReplaceStringConstant_1(594L, "loop invariant")));

                invariants.Add(TrAssumeCmd(loopInv.E.tok, BplImp(w, etran.CanCallAssumption(loopInv.E))));
                var ss = TrSplitExpr(loopInv.E, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(595L, false), out var splitHappened);
                if (!splitHappened)
                {
                    var wInv = BplImp(w, etran.TrExpr(loopInv.E));
                    invariants.Add(Assert(loopInv.E.tok, wInv, new PODesc.LoopInvariant(errorMessage, successMessage)));
                }
                else
                {
                    foreach (var split in ss)
                    {
                        var wInv = Bpl.Expr.Binary(split.E.tok, BinaryOperator.Opcode.Imp, w, split.E);
                        if (split.IsChecked)
                        {
                            invariants.Add(Assert(split.Tok, wInv, new PODesc.LoopInvariant(errorMessage, successMessage)));  // TODO: it would be fine to have this use {:subsumption 0}
                        }
                        else
                        {
                            var cmd = TrAssumeCmd(split.E.tok, wInv);
                            proofDependencies?.AddProofDependencyId(cmd, loopInv.E.tok, new InvariantDependency(loopInv.E));
                            invariants.Add(cmd);
                        }
                    }
                }
            }
            // check definedness of decreases clause
            foreach (Expression e in theDecreases)
            {
                TrStmt_CheckWellformed(e, invDefinednessBuilder, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(596L, true));
            }
            if (codeContext is IMethodCodeContext)
            {
                var modifiesClause = ((IMethodCodeContext)codeContext).Modifies.Expressions;
                if (codeContext is IteratorDecl)
                {
                    // add "this" to the explicit modifies clause
                    var explicitModifies = modifiesClause;
                    modifiesClause = new List<FrameExpression>();
                    modifiesClause.Add(new FrameExpression(s.Tok, new ThisExpr((IteratorDecl)codeContext), null));
                    modifiesClause.AddRange(explicitModifies);
                }
                // include boilerplate invariants
                foreach (BoilerplateTriple tri in GetTwoStateBoilerplate(s.Tok, modifiesClause, s.IsGhost, codeContext.AllowsAllocation, etranPreLoop, etran, etran.Old))
                {
                    if (tri.IsFree)
                    {
                        invariants.Add(TrAssumeCmd(s.Tok, tri.Expr));
                    }
                    else
                    {
                        Contract.Assert(tri.ErrorMessage != null);  // follows from BoilerplateTriple invariant
                        invariants.Add(Assert(s.Tok, tri.Expr, new PODesc.BoilerplateTriple(tri.ErrorMessage, tri.SuccessMessage, tri.Comment)));
                    }
                }
                // add a free invariant which says that the heap hasn't changed outside of the modifies clause.
                invariants.Add(TrAssumeCmd(s.Tok, FrameConditionUsingDefinedFrame(s.Tok, etranPreLoop, etran, updatedFrameEtran, updatedFrameEtran.ModifiesFrame(s.Tok))));
                // for iterators, add "fresh(_new)" as an invariant
                if (codeContext is IteratorDecl iter)
                {
                    var th = new ThisExpr(iter);
                    var thisDotNew = new MemberSelectExpr(s.Tok, th, iter.Member_New);
                    var fr = new FreshExpr(s.Tok, thisDotNew);
                    fr.Type = Type.Bool;
                    invariants.Add(TrAssertCmd(s.Tok, etran.TrExpr(fr)));
                }
            }

            // include a free invariant that says that all definite-assignment trackers have only become more "true"
            foreach (var pair in daTrackersMonotonicity)
            {
                Bpl.Expr monotonic = BplImp(pair.Item1, pair.Item2);
                invariants.Add(TrAssumeCmd(s.Tok, monotonic));
            }

            // include a free invariant that says that all completed iterations so far have only decreased the termination metric
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_40(597L, initDecr, null))
            {
                var toks = new List<IToken>();
                var types = new List<Type>();
                var decrs = new List<Expr>();
                foreach (Expression e in theDecreases)
                {
                    toks.Add(e.tok);
                    types.Add(e.Type.NormalizeExpand());
                    decrs.Add(etran.TrExpr(e));
                }
                Bpl.Expr decrCheck = DecreasesCheck(toks, types, types, decrs, initDecr, null, null, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(598L, true), MutateCSharp.Schemata500.ReplaceBooleanConstant_0(599L, false));
                invariants.Add(TrAssumeCmd(s.Tok, decrCheck));
            }

            var loopBodyBuilder = new BoogieStmtListBuilder(this, options);
            loopBodyBuilder.AddCaptureState(s.Tok, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(600L, true), CaptureStateExtensions.AfterLoopIterationsStateMarker);

            // As the first thing inside the loop, generate:  if (!w) { CheckWellformed(inv); assume false; }
            invDefinednessBuilder.Add(TrAssumeCmd(s.Tok, Bpl.Expr.False));
            loopBodyBuilder.Add(new Bpl.IfCmd(s.Tok, Bpl.Expr.Not(w), invDefinednessBuilder.Collect(s.Tok), null, null));

            // Generate:  CheckWellformed(guard); if (!guard) { break; }
            // but if this is a body-less loop, put all of that inside:  if (*) { ... }
            // Without this, Boogie's abstract interpreter may figure out that the loop guard is always false
            // on entry to the loop, and then Boogie wouldn't consider this a loop at all. (See also comment
            // in methods GuardAlwaysHoldsOnEntry_BodyLessLoop and GuardAlwaysHoldsOnEntry_LoopWithBody in
            // Test/dafny0/DirtyLoops.dfy.)
            var isBodyLessLoop = s is OneBodyLoopStmt { BodySurrogate: { } };
            var whereToBuildLoopGuard = isBodyLessLoop ? new BoogieStmtListBuilder(this, options) : loopBodyBuilder;
            Bpl.Expr guard = null;
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_32(601L, Guard, null))
            {
                TrStmt_CheckWellformed(Guard, whereToBuildLoopGuard, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(602L, true));
                guard = Bpl.Expr.Not(etran.TrExpr(Guard));
            }
            var guardBreak = new BoogieStmtListBuilder(this, options);
            guardBreak.Add(new Bpl.BreakCmd(s.Tok, null));
            whereToBuildLoopGuard.Add(new Bpl.IfCmd(s.Tok, guard, guardBreak.Collect(s.Tok), null, null));
            if (isBodyLessLoop)
            {
                loopBodyBuilder.Add(new Bpl.IfCmd(s.Tok, null, whereToBuildLoopGuard.Collect(s.Tok), null, null));
            }

            if (bodyTr != null)
            {
                // termination checking
                if (Contract.Exists(theDecreases, e => e is WildcardExpr))
                {
                    // omit termination checking for this loop
                    bodyTr(loopBodyBuilder, updatedFrameEtran);
                }
                else
                {
                    List<Bpl.Expr> oldBfs = RecordDecreasesValue(theDecreases, loopBodyBuilder, locals, etran, MutateCSharp.Schemata500.ReplaceStringConstant_1(603L, "$decr$") + suffix);
                    // time for the actual loop body
                    bodyTr(loopBodyBuilder, updatedFrameEtran);
                    // check definedness of decreases expressions
                    var toks = new List<IToken>();
                    var types = new List<Type>();
                    var decrs = new List<Expr>();
                    var oldDecreases = new List<Expression>();
                    var prevGhostLocals = new List<VarDeclStmt>();
                    foreach (Expression e in theDecreases)
                    {
                        toks.Add(e.tok);
                        types.Add(e.Type.NormalizeExpand());
                        // Note: the label "LoopEntry" doesn't exist in the program, and is
                        // useful only for explanatory purposes.
                        var (vars, olde) = TranslateToLoopEntry(s.Mod, e, MutateCSharp.Schemata500.ReplaceStringConstant_1(604L, "LoopEntry"));
                        oldDecreases.Add(olde);
                        prevGhostLocals.AddRange(vars);
                        decrs.Add(etran.TrExpr(e));
                    }
                    if (includeTerminationCheck)
                    {
                        AddComment(loopBodyBuilder, s, MutateCSharp.Schemata500.ReplaceStringConstant_1(605L, "loop termination check"));
                        Bpl.Expr decrCheck = DecreasesCheck(toks, types, types, decrs, oldBfs, loopBodyBuilder, MutateCSharp.Schemata500.ReplaceStringConstant_1(606L, " at end of loop iteration"), MutateCSharp.Schemata500.ReplaceBooleanConstant_0(607L, false), MutateCSharp.Schemata500.ReplaceBooleanConstant_0(608L, false));
                        loopBodyBuilder.Add(Assert(s.Tok, decrCheck, new
                          PODesc.Terminates(s.InferredDecreases, prevGhostLocals, null, oldDecreases, theDecreases)));
                    }
                }
            }
            else if (isBodyLessLoop)
            {
                var bodySurrogate = ((OneBodyLoopStmt)s).BodySurrogate;
                // This is a body-less loop. Havoc the targets and then set w to false, to make the loop-invariant
                // maintenance check vaccuous.
                var bplTargets = bodySurrogate.LocalLoopTargets.ConvertAll(v => TrVar(s.Tok, v));
                if (bodySurrogate.UsesHeap)
                {
                    bplTargets.Add(etran.HeapCastToIdentifierExpr);
                }
                loopBodyBuilder.Add(new Bpl.HavocCmd(s.Tok, bplTargets));
                loopBodyBuilder.Add(Bpl.Cmd.SimpleAssign(s.Tok, w, Bpl.Expr.False));
            }
            // Finally, assume the well-formedness of the invariant (which has been checked once and for all above), so that the check
            // of invariant-maintenance can use the appropriate canCall predicates. Note, it is important (see Test/git-issues/git-issue-1812.dfy)
            // that each CanCall assumption uses the preceding invariants as antecedents--this is achieved by treating all "invariant"
            // declarations as one big conjunction, because then CanCallAssumption will add the needed antecedents.
            if (s.Invariants.Any())
            {
                var allInvariants = s.Invariants.Select(inv => inv.E).Aggregate((a, b) => Expression.CreateAnd(a, b));
                loopBodyBuilder.Add(TrAssumeCmd(s.Tok, etran.CanCallAssumption(allInvariants)));
            }

            Bpl.StmtList body = loopBodyBuilder.Collect(s.Tok);
            builder.Add(new Bpl.WhileCmd(s.Tok, Bpl.Expr.True, invariants, new List<CallCmd>(), body));
        }

        // Return the version of e that holds at the beginnging of the loop,
        // Along with the local variable assignments that need to happen at
        // the beginning of the loop for it to be valid.
        private (List<VarDeclStmt>, Expression) TranslateToLoopEntry(Specification<FrameExpression> mod, Expression e, string loopLabel)
        {
            var prevGhostLocals = new List<VarDeclStmt>();
            Expression olde = new OldExpr(e.tok, e, MutateCSharp.Schemata500.ReplaceStringConstant_1(609L, "LoopEntry"))
            {
                Type = e.Type
            };

            if (MutateCSharp.Schemata500.ReplaceBinExprOp_14(610L, () => mod is null, () => mod.Expressions is null))
            {
                return (prevGhostLocals, olde);
            }

            foreach (var x in mod.Expressions)
            {
                if (x.E is IdentifierExpr { Var: LocalVariable v })
                {
                    var prevName = $"prev_{v.Name}";
                    var prevVar = new LocalVariable(RangeToken.NoToken, prevName, v.Type, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(616L, true));
                    var declStmt = Statement.CreateLocalVariable(RangeToken.NoToken, prevName, x.E);
                    prevGhostLocals.Add(declStmt);
                    var prevExpr = new IdentifierExpr(x.E.tok, prevVar);
                    olde = Substitute(olde, v, prevExpr);
                }
            }

            return (prevGhostLocals, olde);

        }

        void InsertContinueTarget(LoopStmt loop, BoogieStmtListBuilder builder)
        {
            Contract.Requires(loop != null);
            Contract.Requires(builder != null);
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_41(617L, loop.Labels, null))
            {
                builder.AddLabelCmd(MutateCSharp.Schemata500.ReplaceStringConstant_1(618L, "continue_") + loop.Labels.Data.AssignUniqueId(CurrentIdGenerator));
            }
        }

        void TrAlternatives(List<GuardedAlternative> alternatives, Bpl.Cmd elseCase0, Bpl.StructuredCmd elseCase1,
                            BoogieStmtListBuilder builder, List<Variable> locals, ExpressionTranslator etran, bool isGhost)
        {
            Contract.Requires(alternatives != null);
            Contract.Requires((elseCase0 == null) != (elseCase1 == null));  // ugly way of doing a type union
            Contract.Requires(builder != null);
            Contract.Requires(locals != null);
            Contract.Requires(etran != null);

            if (MutateCSharp.Schemata500.ReplaceBinExprOp_8(623L, alternatives.Count, MutateCSharp.Schemata500.ReplaceNumericConstant_4(619L, 0)))
            {
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_42(628L, elseCase0, null))
                {
                    builder.Add(elseCase0);
                }
                else
                {
                    builder.Add(elseCase1);
                }
                return;
            }

            // alpha-rename any binding guards
            var guards = alternatives.ConvertAll(alt => alt.IsBindingGuard ? ((ExistsExpr)alt.Guard).AlphaRename(MutateCSharp.Schemata500.ReplaceStringConstant_1(629L, "eg$")) : alt.Guard);

            // build the negation of the disjunction of all guards (that is, the conjunction of their negations)
            Bpl.Expr noGuard = Bpl.Expr.True;
            var b = new BoogieStmtListBuilder(this, options);
            foreach (var g in guards)
            {
                b.Add(TrAssumeCmd(g.tok, etran.CanCallAssumption(g)));
                noGuard = BplAnd(noGuard, Bpl.Expr.Not(etran.TrExpr(g)));
            }

            var elseTok = MutateCSharp.Schemata500.ReplaceBinExprOp_42(630L, elseCase0, null) ? elseCase0.tok : elseCase1.tok;
            b.Add(TrAssumeCmd(elseTok, noGuard));
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_42(631L, elseCase0, null))
            {
                b.Add(elseCase0);
            }
            else
            {
                b.Add(elseCase1);
            }
            Bpl.StmtList els = b.Collect(elseTok);

            Bpl.IfCmd elsIf = null;
            for (int i = alternatives.Count; MutateCSharp.Schemata500.ReplaceBinExprOp_25(640L, MutateCSharp.Schemata500.ReplaceNumericConstant_4(632L, 0), MutateCSharp.Schemata500.ReplacePrefixUnaryExprOp_24(636L, ref i));)
            {
                Contract.Assert(elsIf == null || els == null);  // loop invariant
                CurrentIdGenerator.Push();
                var alternative = alternatives[i];
                b = new BoogieStmtListBuilder(this, options);
                TrStmt_CheckWellformed(guards[i], b, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(645L, true));
                if (alternative.IsBindingGuard)
                {
                    var exists = (ExistsExpr)alternative.Guard;  // the original (that is, not alpha-renamed) guard
                    IntroduceAndAssignExistentialVars(exists, b, builder, locals, etran, isGhost);
                }
                else
                {
                    b.Add(TrAssumeCmdWithDependencies(etran, alternative.Guard.tok, alternative.Guard, MutateCSharp.Schemata500.ReplaceStringConstant_1(646L, "alternative guard")));
                }
                var prevDefiniteAssignmentTrackerCount = definiteAssignmentTrackers.Count;
                TrStmtList(alternative.Body, b, locals, etran);
                RemoveDefiniteAssignmentTrackers(alternative.Body, prevDefiniteAssignmentTrackerCount);
                Bpl.StmtList thn = b.Collect(alternative.Tok);
                elsIf = new Bpl.IfCmd(alternative.Tok, null, thn, elsIf, els);
                els = null;
                CurrentIdGenerator.Pop();
            }
            Contract.Assert(elsIf != null && els == null); // follows from loop invariant and the fact that there's more than one alternative
            builder.Add(elsIf);
        }

        void TrCallStmt(CallStmt s, BoogieStmtListBuilder builder, List<Variable> locals, ExpressionTranslator etran, Bpl.IdentifierExpr actualReceiver)
        {
            Contract.Requires(s != null);
            Contract.Requires(builder != null);
            Contract.Requires(locals != null);
            Contract.Requires(etran != null);
            Contract.Requires(!(s.Method is Constructor) || (s.Lhs.Count == 0 && actualReceiver != null));

            var tySubst = s.MethodSelect.TypeArgumentSubstitutionsWithParents();
            ProcessLhss(s.Lhs, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(647L, true), MutateCSharp.Schemata500.ReplaceBooleanConstant_0(648L, true), builder, locals, etran, s, out var lhsBuilders, out var bLhss,
              out _, out _, out _, s.OriginalInitialLhs);
            Contract.Assert(s.Lhs.Count == lhsBuilders.Count);
            Contract.Assert(s.Lhs.Count == bLhss.Count);
            var lhsTypes = new List<Type>();
            if (s.Method is Constructor)
            {
                lhsTypes.Add(s.Receiver.Type);
                bLhss.Add(actualReceiver);
            }
            else
            {
                for (int i = MutateCSharp.Schemata500.ReplaceNumericConstant_4(649L, 0); MutateCSharp.Schemata500.ReplaceBinExprOp_5(653L, i, s.Lhs.Count); MutateCSharp.Schemata500.ReplacePostfixUnaryExprOp_6(658L, ref i))
                {
                    var lhs = s.Lhs[i];
                    lhsTypes.Add(lhs.Type);
                    builder.Add(new CommentCmd(MutateCSharp.Schemata500.ReplaceStringConstant_1(659L, "TrCallStmt: Adding lhs with type ") + lhs.Type));
                    if (MutateCSharp.Schemata500.ReplaceBinExprOp_43(660L, bLhss[i], null))
                    {  // (in the current implementation, the second parameter "true" to ProcessLhss implies that all bLhss[*] will be null)
                       // create temporary local and assign it to bLhss[i]
                        string nm = CurrentIdGenerator.FreshId(MutateCSharp.Schemata500.ReplaceStringConstant_1(661L, "$rhs##"));
                        var formalOutType = s.Method.Outs[i].Type.Subst(tySubst);
                        var ty = TrType(formalOutType);
                        Bpl.LocalVariable var = new Bpl.LocalVariable(lhs.tok, new Bpl.TypedIdent(lhs.tok, nm, ty));
                        locals.Add(var);
                        bLhss[i] = new Bpl.IdentifierExpr(lhs.tok, var.Name, ty);
                    }
                }
            }
            Bpl.IdentifierExpr initHeap = null;
            if (codeContext is IteratorDecl)
            {
                // var initHeap := $Heap;
                var initHeapVar = new Bpl.LocalVariable(s.Tok, new Bpl.TypedIdent(s.Tok, CurrentIdGenerator.FreshId(MutateCSharp.Schemata500.ReplaceStringConstant_1(662L, "$initHeapCallStmt#")), predef.HeapType));
                locals.Add(initHeapVar);
                initHeap = new Bpl.IdentifierExpr(s.Tok, initHeapVar);
                // initHeap := $Heap;
                builder.Add(Bpl.Cmd.SimpleAssign(s.Tok, initHeap, etran.HeapExpr));
            }
            builder.Add(new CommentCmd(MutateCSharp.Schemata500.ReplaceStringConstant_1(663L, "TrCallStmt: Before ProcessCallStmt")));
            ProcessCallStmt(s, tySubst, actualReceiver, bLhss, lhsTypes, builder, locals, etran);
            builder.Add(new CommentCmd(MutateCSharp.Schemata500.ReplaceStringConstant_1(664L, "TrCallStmt: After ProcessCallStmt")));
            for (int i = MutateCSharp.Schemata500.ReplaceNumericConstant_4(665L, 0); MutateCSharp.Schemata500.ReplaceBinExprOp_5(669L, i, lhsBuilders.Count); MutateCSharp.Schemata500.ReplacePostfixUnaryExprOp_6(674L, ref i))
            {
                var lhs = s.Lhs[i];
                Type lhsType, rhsTypeConstraint;
                if (lhs is IdentifierExpr)
                {
                    var ide = (IdentifierExpr)lhs;
                    lhsType = ide.Var.Type;
                    rhsTypeConstraint = lhsType;
                }
                else if (lhs is MemberSelectExpr)
                {
                    var fse = (MemberSelectExpr)lhs;
                    var field = (Field)fse.Member;
                    Contract.Assert(field != null);
                    Contract.Assert(VisibleInScope(field));
                    lhsType = field.Type;
                    rhsTypeConstraint = lhsType.Subst(fse.TypeArgumentSubstitutionsWithParents());
                }
                else if (lhs is SeqSelectExpr)
                {
                    var e = (SeqSelectExpr)lhs;
                    lhsType = null;  // for arrays, always make sure the value assigned is boxed
                    rhsTypeConstraint = e.Seq.Type.TypeArgs[MutateCSharp.Schemata500.ReplaceNumericConstant_4(675L, 0)];
                }
                else
                {
                    var e = (MultiSelectExpr)lhs;
                    lhsType = null;  // for arrays, always make sure the value assigned is boxed
                    rhsTypeConstraint = e.Array.Type.TypeArgs[MutateCSharp.Schemata500.ReplaceNumericConstant_4(679L, 0)];
                }

                Bpl.Expr bRhs = bLhss[i];  // the RHS (bRhs) of the assignment to the actual call-LHS (lhs) was a LHS (bLhss[i]) in the Boogie call statement
                CheckSubrange(lhs.tok, bRhs, s.Method.Outs[i].Type.Subst(tySubst), rhsTypeConstraint, builder);
                bRhs = CondApplyBox(lhs.tok, bRhs, lhs.Type, lhsType);

                lhsBuilders[i](bRhs, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(683L, false), builder, etran);
            }
            if (codeContext is IteratorDecl)
            {
                var iter = (IteratorDecl)codeContext;
                Contract.Assert(initHeap != null);
                RecordNewObjectsIn_New(s.Tok, iter, initHeap, etran.HeapCastToIdentifierExpr, builder, locals, etran);
            }
            builder.AddCaptureState(s);
        }

        void ProcessCallStmt(CallStmt cs, Dictionary<TypeParameter, Type> tySubst, Bpl.Expr bReceiver,
          List<Bpl.IdentifierExpr> Lhss, List<Type> LhsTypes,
          BoogieStmtListBuilder builder, List<Variable> locals, ExpressionTranslator etran)
        {

            Contract.Requires(cs != null);
            Contract.Requires(Lhss != null);
            Contract.Requires(LhsTypes != null);
            // Note, a Dafny class constructor is declared to have no output parameters, but it is encoded in Boogie as
            // having an output parameter.
            Contract.Requires(cs.Method is Constructor || cs.Method.Outs.Count == Lhss.Count);
            Contract.Requires(cs.Method is Constructor || cs.Method.Outs.Count == LhsTypes.Count);
            Contract.Requires(!(cs.Method is Constructor) || (cs.Method.Outs.Count == 0 && Lhss.Count == 1 && LhsTypes.Count == 1));
            Contract.Requires(builder != null);
            Contract.Requires(locals != null);
            Contract.Requires(etran != null);
            Contract.Requires(tySubst != null);
            var tok = GetToken(cs);
            var tyArgs = GetTypeParams(cs.Method);
            var dafnyReceiver = cs.Receiver;
            var method = cs.Method;
            var atLabel = cs.MethodSelect.AtLabel;
            var Args = cs.Args;

            // Figure out if the call is recursive or not, which will be used below to determine the need for a
            // termination check and the need to include an implicit _k-1 argument.
            bool isRecursiveCall = MutateCSharp.Schemata500.ReplaceBooleanConstant_0(684L, false);
            // consult the call graph to figure out if this is a recursive call
            var module = method.EnclosingClass.EnclosingModuleDefinition;
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_9(687L, () => MutateCSharp.Schemata500.ReplaceBinExprOp_44(685L, codeContext, null), () => MutateCSharp.Schemata500.ReplaceBinExprOp_45(686L, module, currentModule)))
            {
                // Note, prefix lemmas are not recorded in the call graph, but their corresponding greatest lemmas are.
                // Similarly, an iterator is not recorded in the call graph, but its MoveNext method is.
                ICallable cllr =
                  codeContext is PrefixLemma ? ((PrefixLemma)codeContext).ExtremeLemma :
                  codeContext is IteratorDecl ? ((IteratorDecl)codeContext).Member_MoveNext :
                  codeContext;
                if (ModuleDefinition.InSameSCC(method, cllr))
                {
                    isRecursiveCall = MutateCSharp.Schemata500.ReplaceBooleanConstant_0(693L, true);
                }
            }

            MethodTranslationKind kind;
            var callee = method;
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_9(694L, () => method is ExtremeLemma, () => isRecursiveCall))
            {
                kind = MethodTranslationKind.CoCall;
                callee = ((ExtremeLemma)method).PrefixLemma;
            }
            else if (method is PrefixLemma)
            {
                // an explicit call to a prefix lemma is allowed only inside the SCC of the corresponding greatest lemma,
                // so we consider this to be a co-call
                kind = MethodTranslationKind.CoCall;
            }
            else
            {
                kind = MethodTranslationKind.Call;
            }


            var ins = new List<Bpl.Expr>();
            if (callee is TwoStateLemma)
            {
                ins.Add(etran.OldAt(atLabel).HeapExpr);
                ins.Add(etran.HeapExpr);
            }
            // Add type arguments
            ins.AddRange(trTypeArgs(tySubst, tyArgs));

            // Translate receiver argument, if any
            Expression receiver = MutateCSharp.Schemata500.ReplaceBinExprOp_46(700L, bReceiver, null) ? dafnyReceiver : new BoogieWrapper(bReceiver, dafnyReceiver.Type);
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_9(701L, () => !method.IsStatic, () => !(method is Constructor)))
            {
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_46(707L, bReceiver, null))
                {
                    TrStmt_CheckWellformed(dafnyReceiver, builder, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(708L, true));
                    if (!(dafnyReceiver is ThisExpr))
                    {
                        CheckNonNull(dafnyReceiver.tok, dafnyReceiver, builder, etran, null);
                    }
                }
                var obj = etran.TrExpr(receiver);
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_46(709L, bReceiver, null))
                {
                    obj = BoxifyForTraitParent(tok, obj, method, dafnyReceiver.Type);
                }
                ins.Add(obj);
            }
            else if (receiver is StaticReceiverExpr stexpr)
            {
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_32(710L, stexpr.ObjectToDiscard, null))
                {
                    TrStmt_CheckWellformed(stexpr.ObjectToDiscard, builder, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(711L, true));
                }
            }

            // Ideally, the modifies and decreases checks would be done after the precondition check,
            // but Boogie doesn't give us a hook for that.  So, we set up our own local variables here to
            // store the actual parameters.
            // Create a local variable for each formal parameter, and assign each actual parameter to the corresponding local
            var substMap = new Dictionary<IVariable, Expression>();
            for (int i = MutateCSharp.Schemata500.ReplaceNumericConstant_4(712L, 0); MutateCSharp.Schemata500.ReplaceBinExprOp_5(716L, i, callee.Ins.Count); MutateCSharp.Schemata500.ReplacePostfixUnaryExprOp_6(721L, ref i))
            {
                var formal = callee.Ins[i];
                var local = new LocalVariable(formal.RangeToken, formal.Name + MutateCSharp.Schemata500.ReplaceStringConstant_1(722L, "#"), formal.Type.Subst(tySubst), formal.IsGhost);
                local.type = local.OptionalType;  // resolve local here
                var ie = new IdentifierExpr(local.Tok, local.AssignUniqueName(currentDeclaration.IdGenerator));
                ie.Var = local; ie.Type = ie.Var.Type;  // resolve ie here
                substMap.Add(formal, ie);
                locals.Add(new Bpl.LocalVariable(local.Tok, new Bpl.TypedIdent(local.Tok, local.AssignUniqueName(currentDeclaration.IdGenerator), TrType(local.Type))));

                var param = (Bpl.IdentifierExpr)etran.TrExpr(ie);  // TODO: is this cast always justified?
                Bpl.Expr bActual;
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_9(738L, () => MutateCSharp.Schemata500.ReplaceBinExprOp_9(732L, () => MutateCSharp.Schemata500.ReplaceBinExprOp_8(727L, i, MutateCSharp.Schemata500.ReplaceNumericConstant_4(723L, 0)), () => method is ExtremeLemma), () => isRecursiveCall))
                {
                    // Treat this call to M(args) as a call to the corresponding prefix lemma M#(_k - 1, args), so insert an argument here.
                    var k = ((PrefixLemma)callee).K;
                    var bplK = new Bpl.IdentifierExpr(k.tok, k.AssignUniqueName(currentDeclaration.IdGenerator), TrType(k.Type));
                    if (k.Type.IsBigOrdinalType)
                    {
                        bActual = FunctionCall(k.tok, MutateCSharp.Schemata500.ReplaceStringConstant_1(744L, "ORD#Minus"), predef.BigOrdinalType,
                          bplK,
                          FunctionCall(k.tok, MutateCSharp.Schemata500.ReplaceStringConstant_1(745L, "ORD#FromNat"), predef.BigOrdinalType, Bpl.Expr.Literal(MutateCSharp.Schemata500.ReplaceNumericConstant_4(746L, 1))));
                    }
                    else
                    {
                        bActual = Bpl.Expr.Sub(bplK, Bpl.Expr.Literal(MutateCSharp.Schemata500.ReplaceNumericConstant_4(750L, 1)));
                    }
                }
                else
                {
                    Expression actual;
                    if (MutateCSharp.Schemata500.ReplaceBinExprOp_9(754L, () => method is ExtremeLemma, () => isRecursiveCall))
                    {
                        actual = Args[MutateCSharp.Schemata500.ReplaceBinExprOp_23(764L, i, MutateCSharp.Schemata500.ReplaceNumericConstant_4(760L, 1))];
                    }
                    else
                    {
                        actual = Args[i];
                    }
                    if (!(actual is DefaultValueExpression))
                    {
                        TrStmt_CheckWellformed(actual, builder, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(773L, true));
                    }
                    builder.Add(new CommentCmd(MutateCSharp.Schemata500.ReplaceStringConstant_1(774L, "ProcessCallStmt: CheckSubrange")));
                    // Check the subrange without boxing
                    var beforeBox = etran.TrExpr(actual);
                    CheckSubrange(actual.tok, beforeBox, actual.Type, formal.Type.Subst(tySubst), builder);
                    bActual = CondApplyBox(actual.tok, beforeBox, actual.Type, formal.Type.Subst(tySubst));
                }
                Bpl.Cmd cmd = Bpl.Cmd.SimpleAssign(formal.tok, param, bActual);
                builder.Add(cmd);
                ins.Add(CondApplyBox(ToDafnyToken(flags.ReportRanges, param.tok), param, formal.Type.Subst(tySubst), formal.Type));
            }

            // Check that every parameter is available in the state in which the method is invoked; this means checking that it has
            // the right type and is allocated.  These checks usually hold trivially, on account of that the Dafny language only gives
            // access to expressions of the appropriate type and that are allocated in the current state.  However, if the method is
            // invoked in the 'old' state or if the method invoked is a two-state lemma with a non-new parameter, then we need to
            // check that its arguments were all available at that time as well.
            if (etran.UsesOldHeap)
            {
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_9(775L, () => !method.IsStatic, () => !(method is Constructor)))
                {
                    Bpl.Expr wh = GetWhereClause(receiver.tok, etran.TrExpr(receiver), receiver.Type, etran, ISALLOC, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(781L, true));
                    if (MutateCSharp.Schemata500.ReplaceBinExprOp_15(782L, wh, null))
                    {
                        var desc = new PODesc.IsAllocated(MutateCSharp.Schemata500.ReplaceStringConstant_1(783L, "receiver argument"), MutateCSharp.Schemata500.ReplaceStringConstant_1(784L, "in the state in which the method is invoked"), receiver);
                        builder.Add(Assert(receiver.tok, wh, desc));
                    }
                }
                for (int i = MutateCSharp.Schemata500.ReplaceNumericConstant_4(785L, 0); MutateCSharp.Schemata500.ReplaceBinExprOp_5(789L, i, Args.Count); MutateCSharp.Schemata500.ReplacePostfixUnaryExprOp_6(794L, ref i))
                {
                    Expression ee = Args[i];
                    Bpl.Expr wh = GetWhereClause(ee.tok, etran.TrExpr(ee), ee.Type, etran, ISALLOC, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(795L, true));
                    if (MutateCSharp.Schemata500.ReplaceBinExprOp_15(796L, wh, null))
                    {
                        var desc = new PODesc.IsAllocated(MutateCSharp.Schemata500.ReplaceStringConstant_1(797L, "argument"), MutateCSharp.Schemata500.ReplaceStringConstant_1(798L, "in the state in which the method is invoked"), ee);
                        builder.Add(Assert(ee.tok, wh, desc));
                    }
                }
            }
            else if (method is TwoStateLemma)
            {
                if (!method.IsStatic)
                {
                    Bpl.Expr wh = GetWhereClause(receiver.tok, etran.TrExpr(receiver), receiver.Type, etran.OldAt(atLabel), ISALLOC, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(799L, true));
                    if (MutateCSharp.Schemata500.ReplaceBinExprOp_15(800L, wh, null))
                    {
                        var desc = new PODesc.IsAllocated(MutateCSharp.Schemata500.ReplaceStringConstant_1(801L, "receiver argument"), MutateCSharp.Schemata500.ReplaceStringConstant_1(802L, "in the two-state lemma's previous state"), receiver, atLabel);
                        builder.Add(Assert(receiver.tok, wh, desc));
                    }
                }
                Contract.Assert(callee.Ins.Count == Args.Count);
                for (int i = MutateCSharp.Schemata500.ReplaceNumericConstant_4(803L, 0); MutateCSharp.Schemata500.ReplaceBinExprOp_5(807L, i, Args.Count); MutateCSharp.Schemata500.ReplacePostfixUnaryExprOp_6(812L, ref i))
                {
                    var formal = callee.Ins[i];
                    if (formal.IsOld)
                    {
                        Expression ee = Args[i];
                        Bpl.Expr wh = GetWhereClause(ee.tok, etran.TrExpr(ee), ee.Type, etran.OldAt(atLabel), ISALLOC, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(813L, true));
                        if (MutateCSharp.Schemata500.ReplaceBinExprOp_15(814L, wh, null))
                        {
                            var pIdx = MutateCSharp.Schemata500.ReplaceBinExprOp_8(819L, Args.Count, MutateCSharp.Schemata500.ReplaceNumericConstant_4(815L, 1)) ? "" : MutateCSharp.Schemata500.ReplaceStringConstant_1(824L, " at index ") + i;
                            var desc = new PODesc.IsAllocated(
                              $"argument{pIdx} for parameter '{formal.Name}'",
              MutateCSharp.Schemata500.ReplaceStringConstant_1(825L, "in the two-state lemma's previous state") + PODesc.IsAllocated.HelperFormal(formal),
                              ee,
                              atLabel
                            );
                            builder.Add(Assert(ee.tok, wh, desc));
                        }
                    }
                }
            }

            // Check that the reads clause of a subcall is a subset of the current reads frame,
            // but support the optimization that we don't define a reads frame at all if it's `reads *`. 
            if (etran.readsFrame != null)
            {
                var readsSubst = new Substituter(null, new Dictionary<IVariable, Expression>(), tySubst);
                CheckFrameSubset(tok, callee.Reads.Expressions.ConvertAll(readsSubst.SubstFrameExpr),
                  receiver, substMap, etran, etran.ReadsFrame(tok), builder, new PODesc.ReadFrameSubset(MutateCSharp.Schemata500.ReplaceStringConstant_1(826L, "call")), null);
            }
            // Check that the modifies clause of a subcall is a subset of the current modifies frame,
            // but only if we're in a context that defines a modifies frame.
            if (codeContext is IMethodCodeContext)
            {
                var modifiesSubst = new Substituter(null, new Dictionary<IVariable, Expression>(), tySubst);
                CheckFrameSubset(tok, callee.Mod.Expressions.ConvertAll(modifiesSubst.SubstFrameExpr),
                  receiver, substMap, etran, etran.ModifiesFrame(tok), builder, new PODesc.ModifyFrameSubset(MutateCSharp.Schemata500.ReplaceStringConstant_1(827L, "call")), null);
            }

            // Check termination
            if (isRecursiveCall)
            {
                Contract.Assert(codeContext != null);
                if (codeContext is DatatypeDecl)
                {
                    builder.Add(Assert(tok, Bpl.Expr.False, new PODesc.IsNonRecursive()));
                }
                else
                {
                    List<Expression> contextDecreases = codeContext.Decreases.Expressions;
                    List<Expression> calleeDecreases = callee.Decreases.Expressions;
                    CheckCallTermination(tok, contextDecreases, calleeDecreases, null, receiver, substMap, tySubst, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(828L, true), builder, codeContext.InferredDecreases, null);
                }
            }

            // Create variables to hold the output parameters of the call, so that appropriate unboxes can be introduced.
            var outs = new List<Bpl.IdentifierExpr>();
            var tmpOuts = new List<Bpl.IdentifierExpr>();
            if (method is Constructor)
            {
                tmpOuts.Add(null);
                outs.Add(Lhss[MutateCSharp.Schemata500.ReplaceNumericConstant_4(829L, 0)]);
            }
            else
            {
                for (int i = MutateCSharp.Schemata500.ReplaceNumericConstant_4(833L, 0); MutateCSharp.Schemata500.ReplaceBinExprOp_5(837L, i, Lhss.Count); MutateCSharp.Schemata500.ReplacePostfixUnaryExprOp_6(842L, ref i))
                {
                    var bLhs = Lhss[i];
                    if (MutateCSharp.Schemata500.ReplaceBinExprOp_9(843L, () => ModeledAsBoxType(callee.Outs[i].Type), () => !ModeledAsBoxType(LhsTypes[i])))
                    {
                        // we need an Unbox
                        Bpl.LocalVariable var = new Bpl.LocalVariable(bLhs.tok, new Bpl.TypedIdent(bLhs.tok, CurrentIdGenerator.FreshId(MutateCSharp.Schemata500.ReplaceStringConstant_1(849L, "$tmp##")), predef.BoxType));
                        locals.Add(var);
                        Bpl.IdentifierExpr varIdE = new Bpl.IdentifierExpr(bLhs.tok, var.Name, predef.BoxType);
                        tmpOuts.Add(varIdE);
                        outs.Add(varIdE);
                    }
                    else
                    {
                        tmpOuts.Add(null);
                        outs.Add(bLhs);
                    }
                }
            }

            builder.Add(new CommentCmd(MutateCSharp.Schemata500.ReplaceStringConstant_1(850L, "ProcessCallStmt: Make the call")));
            // Make the call
            AddReferencedMember(callee);
            Bpl.CallCmd call = Call(tok, MethodName(callee, kind), ins, outs);
            proofDependencies?.AddProofDependencyId(call, tok, new CallDependency(cs));
            if (
      MutateCSharp.Schemata500.ReplaceBinExprOp_14(878L, () => (MutateCSharp.Schemata500.ReplaceBinExprOp_9(852L, () => MutateCSharp.Schemata500.ReplaceBinExprOp_47(851L, assertionOnlyFilter, null), () => !assertionOnlyFilter(tok))), () => (MutateCSharp.Schemata500.ReplaceBinExprOp_9(872L, () => MutateCSharp.Schemata500.ReplaceBinExprOp_9(859L, () => MutateCSharp.Schemata500.ReplaceBinExprOp_48(858L, module, currentModule), () => RefinementToken.IsInherited(tok, currentModule)), () => (MutateCSharp.Schemata500.ReplaceBinExprOp_14(866L, () => MutateCSharp.Schemata500.ReplaceBinExprOp_49(865L, codeContext, null), () => !codeContext.MustReverify))))))
            {
                // The call statement is inherited, so the refined module already checked that the precondition holds.  Note,
                // preconditions are not allowed to be strengthened, except if they use a predicate whose body has been strengthened.
                // But if the callee sits in a different module, then any predicate it uses will be treated as opaque (that is,
                // uninterpreted) anyway, so the refined module will have checked the call precondition for all possible definitions
                // of the predicate.
                call.IsFree = MutateCSharp.Schemata500.ReplaceBooleanConstant_0(884L, true);
            }
            builder.Add(call);

            // Unbox results as needed
            for (int i = MutateCSharp.Schemata500.ReplaceNumericConstant_4(885L, 0); MutateCSharp.Schemata500.ReplaceBinExprOp_5(889L, i, Lhss.Count); MutateCSharp.Schemata500.ReplacePostfixUnaryExprOp_6(894L, ref i))
            {
                Bpl.IdentifierExpr bLhs = Lhss[i];
                Bpl.IdentifierExpr tmpVarIdE = tmpOuts[i];
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_50(895L, tmpVarIdE, null))
                {
                    // Instead of an assignment:
                    //    e := UnBox(tmpVar);
                    // we use:
                    //    havoc e; assume e == UnBox(tmpVar);
                    // because that will reap the benefits of e's where clause, so that some additional type information will be known about
                    // the out-parameter.
                    Bpl.Cmd cmd = new Bpl.HavocCmd(bLhs.tok, new List<Bpl.IdentifierExpr> { bLhs });
                    builder.Add(cmd);
                    cmd = TrAssumeCmd(bLhs.tok, Bpl.Expr.Eq(bLhs, FunctionCall(bLhs.tok, BuiltinFunction.Unbox, TrType(LhsTypes[i]), tmpVarIdE)));
                    builder.Add(cmd);
                }
            }
        }

        void TrForallStmtCall(IToken tok, List<BoundVar> boundVars, List<BoundedPool> bounds,
          Expression range, ExpressionConverter additionalRange, List<Expression> forallExpressions, CallStmt s0,
          BoogieStmtListBuilder definedness, BoogieStmtListBuilder exporter, List<Variable> locals, ExpressionTranslator etran)
        {
            Contract.Requires(tok != null);
            Contract.Requires(boundVars != null);
            Contract.Requires(bounds != null);
            Contract.Requires(range != null);
            // additionalRange is allowed to be null
            Contract.Requires(s0 != null);
            // definedness is allowed to be null
            Contract.Requires(exporter != null);
            Contract.Requires(locals != null);
            Contract.Requires(etran != null);

            // Translate:
            //   forall (x,y | Range(x,y)) {
            //     E(x,y) . M( Args(x,y) );
            //   }
            // as:
            //   if (*) {
            //     var x,y;
            //     havoc x,y;
            //     CheckWellformed( Range );
            //     assume Range(x,y);
            //     assume additionalRange;
            //     Tr( Call );
            //     assume false;
            //   } else {
            //     initHeap := $Heap;
            //     advance $Heap;
            //     assume (forall x,y :: (Range(x,y) && additionalRange)[INIT] &&
            //                           ==> Post[old($Heap) := initHeap]( E(x,y)[INIT], Args(x,y)[INIT] ));
            //   }
            // where Post(this,args) is the postcondition of method M and
            // INIT is the substitution [old($Heap),$Heap := old($Heap),initHeap].

            if (MutateCSharp.Schemata500.ReplaceBinExprOp_21(896L, definedness, null))
            {
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_28(901L, boundVars.Count, MutateCSharp.Schemata500.ReplaceNumericConstant_4(897L, 0)))
                {
                    // Note, it would be nicer (and arguably more appropriate) to do a SetupBoundVarsAsLocals
                    // here (rather than a TrBoundVariables).  However, there is currently no way to apply
                    // a substMap to a statement (in particular, to s.Body), so that doesn't work here.
                    List<bool> freeOfAlloc = BoundedPool.HasBounds(bounds, BoundedPool.PoolVirtues.IndependentOfAlloc_or_ExplicitAlloc);
                    List<Variable> bvars = new List<Variable>();
                    var ante = etran.TrBoundVariables(boundVars, bvars, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(906L, true), freeOfAlloc);
                    locals.AddRange(bvars);
                    var havocIds = new List<Bpl.IdentifierExpr>();
                    foreach (Bpl.Variable bv in bvars)
                    {
                        havocIds.Add(new Bpl.IdentifierExpr(tok, bv));
                    }
                    definedness.Add(new Bpl.HavocCmd(tok, havocIds));
                    definedness.Add(TrAssumeCmd(tok, ante));
                }
                TrStmt_CheckWellformed(range, definedness, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(907L, false));
                definedness.Add(TrAssumeCmd(range.tok, etran.TrExpr(range)));
                if (additionalRange != null)
                {
                    var es = additionalRange(new Dictionary<IVariable, Expression>(), etran);
                    definedness.Add(TrAssumeCmd(es.tok, es));
                }

                TrStmt(s0, definedness, locals, etran);

                definedness.Add(TrAssumeCmd(tok, Bpl.Expr.False));
            }

            // Now for the other branch, where the postcondition of the call is exported.
            {
                var initHeapVar = new Bpl.LocalVariable(tok, new Bpl.TypedIdent(tok, CurrentIdGenerator.FreshId(MutateCSharp.Schemata500.ReplaceStringConstant_1(908L, "$initHeapForallStmt#")), predef.HeapType));
                locals.Add(initHeapVar);
                var initHeap = new Bpl.IdentifierExpr(tok, initHeapVar);
                var initEtran = new ExpressionTranslator(this, predef, initHeap, etran.Old.HeapExpr, etran.scope);
                // initHeap := $Heap;
                exporter.Add(Bpl.Cmd.SimpleAssign(tok, initHeap, etran.HeapExpr));
                var heapIdExpr = etran.HeapCastToIdentifierExpr;
                // advance $Heap;
                exporter.Add(new Bpl.HavocCmd(tok, new List<Bpl.IdentifierExpr> { heapIdExpr }));
                Contract.Assert(s0.Method.Mod.Expressions.Count == 0);  // checked by the resolver
                foreach (BoilerplateTriple tri in GetTwoStateBoilerplate(tok, new List<FrameExpression>(), s0.IsGhost, s0.Method.AllowsAllocation, initEtran, etran, initEtran))
                {
                    if (tri.IsFree)
                    {
                        exporter.Add(TrAssumeCmd(tok, tri.Expr));
                    }
                }
                if (codeContext is IteratorDecl)
                {
                    var iter = (IteratorDecl)codeContext;
                    RecordNewObjectsIn_New(tok, iter, initHeap, heapIdExpr, exporter, locals, etran);
                }

                // Note, in the following, we need to do a bit of a song and dance.  The actual arguments of the
                // call should be translated using "initEtran", whereas the method postcondition should be translated
                // using "callEtran".  To accomplish this, we translate the argument and then tuck the resulting
                // Boogie expressions into BoogieExprWrappers that are used in the DafnyExpr-to-DafnyExpr substitution.
                var bvars = new List<Variable>();
                Dictionary<IVariable, Expression> substMap;
                Bpl.Trigger antitriggerBoundVarTypes;
                Bpl.Expr ante;
                var argsSubstMap = new Dictionary<IVariable, Expression>();  // maps formal arguments to actuals
                Contract.Assert(s0.Method.Ins.Count == s0.Args.Count);
                var callEtran = new ExpressionTranslator(this, predef, etran.HeapExpr, initHeap, etran.scope);
                Bpl.Expr post = Bpl.Expr.True;
                Bpl.Trigger tr;
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_36(909L, forallExpressions, null))
                {
                    // translate based on the forallExpressions since the triggers are computed based on it already.
                    QuantifierExpr expr = (QuantifierExpr)forallExpressions[MutateCSharp.Schemata500.ReplaceNumericConstant_4(910L, 0)];
                    while (MutateCSharp.Schemata500.ReplaceBinExprOp_36(914L, expr.SplitQuantifier, null))
                    {
                        expr = (QuantifierExpr)expr.SplitQuantifierExpression;
                    }
                    boundVars = expr.BoundVars;
                    ante = initEtran.TrBoundVariablesRename(boundVars, bvars, out substMap, out antitriggerBoundVarTypes);
                    ante = BplAnd(ante, initEtran.TrExpr(Substitute(expr.Range, null, substMap)));
                    if (additionalRange != null)
                    {
                        ante = BplAnd(ante, additionalRange(substMap, initEtran));
                    }
                    tr = TrTrigger(callEtran, expr.Attributes, expr.tok, bvars, substMap, s0.MethodSelect.TypeArgumentSubstitutionsWithParents());
                    post = callEtran.TrExpr(Substitute(expr.Term, null, substMap));
                }
                else
                {
                    ante = initEtran.TrBoundVariablesRename(boundVars, bvars, out substMap, out antitriggerBoundVarTypes);
                    for (int i = MutateCSharp.Schemata500.ReplaceNumericConstant_4(915L, 0); MutateCSharp.Schemata500.ReplaceBinExprOp_5(919L, i, s0.Method.Ins.Count); MutateCSharp.Schemata500.ReplacePostfixUnaryExprOp_6(924L, ref i))
                    {
                        var arg = Substitute(s0.Args[i], null, substMap, s0.MethodSelect.TypeArgumentSubstitutionsWithParents());  // substitute the renamed bound variables for the declared ones
                        argsSubstMap.Add(s0.Method.Ins[i], new BoogieWrapper(initEtran.TrExpr(arg), s0.Args[i].Type));
                    }
                    ante = BplAnd(ante, initEtran.TrExpr(Substitute(range, null, substMap)));
                    if (additionalRange != null)
                    {
                        ante = BplAnd(ante, additionalRange(substMap, initEtran));
                    }
                    var receiver = new BoogieWrapper(initEtran.TrExpr(Substitute(s0.Receiver, null, substMap, s0.MethodSelect.TypeArgumentSubstitutionsWithParents())), s0.Receiver.Type);
                    foreach (var ens in s0.Method.Ens)
                    {
                        var p = Substitute(ens.E, receiver, argsSubstMap, s0.MethodSelect.TypeArgumentSubstitutionsWithParents());  // substitute the call's actuals for the method's formals
                        post = BplAnd(post, callEtran.TrExpr(p));
                    }
                    tr = antitriggerBoundVarTypes;
                }

                // TRIG (forall $ih#s0#0: Seq :: $Is($ih#s0#0, TSeq(TChar)) && $IsAlloc($ih#s0#0, TSeq(TChar), $initHeapForallStmt#0) && Seq#Length($ih#s0#0) != 0 && Seq#Rank($ih#s0#0) < Seq#Rank(s#0) ==> (forall i#2: int :: true ==> LitInt(0) <= i#2 && i#2 < Seq#Length($ih#s0#0) ==> char#ToInt(_module.CharChar.MinChar($LS($LZ), $Heap, this, $ih#s0#0)) <= char#ToInt($Unbox(Seq#Index($ih#s0#0, i#2)): char)))
                // TRIG (forall $ih#pat0#0: Seq, $ih#a0#0: Seq :: $Is($ih#pat0#0, TSeq(_module._default.Same0$T)) && $IsAlloc($ih#pat0#0, TSeq(_module._default.Same0$T), $initHeapForallStmt#0) && $Is($ih#a0#0, TSeq(_module._default.Same0$T)) && $IsAlloc($ih#a0#0, TSeq(_module._default.Same0$T), $initHeapForallStmt#0) && Seq#Length($ih#pat0#0) <= Seq#Length($ih#a0#0) && Seq#SameUntil($ih#pat0#0, $ih#a0#0, Seq#Length($ih#pat0#0)) && (Seq#Rank($ih#pat0#0) < Seq#Rank(pat#0) || (Seq#Rank($ih#pat0#0) == Seq#Rank(pat#0) && Seq#Rank($ih#a0#0) < Seq#Rank(a#0))) ==> _module.__default.IsRelaxedPrefixAux(_module._default.Same0$T, $LS($LZ), $Heap, $ih#pat0#0, $ih#a0#0, LitInt(1)))'
                // TRIG (forall $ih#m0#0: DatatypeType, $ih#n0#0: DatatypeType :: $Is($ih#m0#0, Tclass._module.Nat()) && $IsAlloc($ih#m0#0, Tclass._module.Nat(), $initHeapForallStmt#0) && $Is($ih#n0#0, Tclass._module.Nat()) && $IsAlloc($ih#n0#0, Tclass._module.Nat(), $initHeapForallStmt#0) && Lit(true) && (DtRank($ih#m0#0) < DtRank(m#0) || (DtRank($ih#m0#0) == DtRank(m#0) && DtRank($ih#n0#0) < DtRank(n#0))) ==> _module.__default.mult($LS($LZ), $Heap, $ih#m0#0, _module.__default.plus($LS($LZ), $Heap, $ih#n0#0, $ih#n0#0)) == _module.__default.mult($LS($LZ), $Heap, _module.__default.plus($LS($LZ), $Heap, $ih#m0#0, $ih#m0#0), $ih#n0#0))
                var qq = new Bpl.ForallExpr(tok, bvars, tr, BplImp(ante, post));  // TODO: Add a SMART_TRIGGER here.  If we can't find one, abort the attempt to do induction automatically
                exporter.Add(TrAssumeCmd(tok, qq));
            }
        }

        void RecordNewObjectsIn_New(IToken tok, IteratorDecl iter, Bpl.Expr initHeap, Bpl.IdentifierExpr currentHeap,
          BoogieStmtListBuilder builder, List<Variable> locals, ExpressionTranslator etran)
        {
            Contract.Requires(tok != null);
            Contract.Requires(iter != null);
            Contract.Requires(initHeap != null);
            Contract.Requires(currentHeap != null);
            Contract.Requires(builder != null);
            Contract.Requires(locals != null);
            Contract.Requires(etran != null);
            // Add all newly allocated objects to the set this._new
            var updatedSet = new Bpl.LocalVariable(iter.tok, new Bpl.TypedIdent(iter.tok, CurrentIdGenerator.FreshId(MutateCSharp.Schemata500.ReplaceStringConstant_1(925L, "$iter_newUpdate")), predef.SetType));
            locals.Add(updatedSet);
            var updatedSetIE = new Bpl.IdentifierExpr(iter.tok, updatedSet);
            // call $iter_newUpdate := $IterCollectNewObjects(initHeap, $Heap, this, _new);
            var th = new Bpl.IdentifierExpr(iter.tok, etran.This, predef.RefType);
            var nwField = new Bpl.IdentifierExpr(tok, GetField(iter.Member_New));
            Bpl.Cmd cmd = new CallCmd(iter.tok, MutateCSharp.Schemata500.ReplaceStringConstant_1(926L, "$IterCollectNewObjects"),
              new List<Bpl.Expr>() { initHeap, etran.HeapExpr, th, nwField },
              new List<Bpl.IdentifierExpr>() { updatedSetIE });
            builder.Add(cmd);
            // $Heap[this, _new] := $iter_newUpdate;
            cmd = Bpl.Cmd.SimpleAssign(iter.tok, currentHeap, UpdateHeap(iter.tok, currentHeap, th, nwField, updatedSetIE));
            builder.Add(cmd);
            // assume $IsGoodHeap($Heap)
            builder.Add(AssumeGoodHeap(tok, etran));
        }

        private string GetObjFieldDetails(Expression lhs, ExpressionTranslator etran, out Bpl.Expr obj, out Bpl.Expr F)
        {
            string description;
            if (lhs is MemberSelectExpr)
            {
                var fse = (MemberSelectExpr)lhs;
                obj = etran.TrExpr(fse.Obj);
                F = GetField(fse);
                description = MutateCSharp.Schemata500.ReplaceStringConstant_1(927L, "an object field");
            }
            else if (lhs is SeqSelectExpr)
            {
                var sel = (SeqSelectExpr)lhs;
                obj = etran.TrExpr(sel.Seq);
                var idx = etran.TrExpr(sel.E0);
                idx = ConvertExpression(sel.E0.tok, idx, sel.E0.Type, Type.Int);
                F = FunctionCall(sel.tok, BuiltinFunction.IndexField, null, idx);
                description = MutateCSharp.Schemata500.ReplaceStringConstant_1(928L, "an array element");
            }
            else
            {
                MultiSelectExpr mse = (MultiSelectExpr)lhs;
                obj = etran.TrExpr(mse.Array);
                F = etran.GetArrayIndexFieldName(mse.tok, mse.Indices);
                description = MutateCSharp.Schemata500.ReplaceStringConstant_1(929L, "an array element");
            }
            return description;
        }


        void ProcessRhss(List<AssignToLhs> lhsBuilder, List<Bpl.IdentifierExpr/*may be null*/> bLhss,
          List<Expression> lhss, List<AssignmentRhs> rhss,
          BoogieStmtListBuilder builder, List<Variable> locals, ExpressionTranslator etran, Statement stmt)
        {
            Contract.Requires(lhsBuilder != null);
            Contract.Requires(bLhss != null);
            Contract.Requires(cce.NonNullElements(lhss));
            Contract.Requires(cce.NonNullElements(rhss));
            Contract.Requires(builder != null);
            Contract.Requires(cce.NonNullElements(locals));
            Contract.Requires(etran != null);
            Contract.Requires(predef != null);

            var finalRhss = new List<Bpl.Expr>();
            for (int i = MutateCSharp.Schemata500.ReplaceNumericConstant_4(930L, 0); MutateCSharp.Schemata500.ReplaceBinExprOp_5(934L, i, lhss.Count); MutateCSharp.Schemata500.ReplacePostfixUnaryExprOp_6(939L, ref i))
            {
                var lhs = lhss[i];
                // the following assumes are part of the precondition, really
                Contract.Assume(!(lhs is ConcreteSyntaxExpression));
                Contract.Assume(!(lhs is SeqSelectExpr && !((SeqSelectExpr)lhs).SelectOne));  // array-range assignments are not allowed

                Type lhsType, rhsTypeConstraint;
                if (lhs is IdentifierExpr)
                {
                    var ide = (IdentifierExpr)lhs;
                    lhsType = ide.Var.Type;
                    rhsTypeConstraint = lhsType;
                }
                else if (lhs is MemberSelectExpr)
                {
                    var fse = (MemberSelectExpr)lhs;
                    var field = (Field)fse.Member;
                    Contract.Assert(VisibleInScope(field));
                    lhsType = field.Type;
                    rhsTypeConstraint = lhsType.Subst(fse.TypeArgumentSubstitutionsWithParents());
                }
                else if (lhs is SeqSelectExpr)
                {
                    var e = (SeqSelectExpr)lhs;
                    lhsType = null;  // for an array update, always make sure the value assigned is boxed
                    rhsTypeConstraint = e.Seq.Type.NormalizeExpand().TypeArgs[MutateCSharp.Schemata500.ReplaceNumericConstant_4(940L, 0)];
                }
                else
                {
                    var e = (MultiSelectExpr)lhs;
                    lhsType = null;  // for an array update, always make sure the value assigned is boxed
                    rhsTypeConstraint = e.Array.Type.NormalizeExpand().TypeArgs[MutateCSharp.Schemata500.ReplaceNumericConstant_4(944L, 0)];
                }
                var bRhs = TrAssignmentRhs(rhss[i].Tok, bLhss[i], null, lhsType, rhss[i], rhsTypeConstraint, builder, locals, etran, stmt);
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_50(948L, bLhss[i], null))
                {
                    Contract.Assert(bRhs == bLhss[i]);  // this is what the postcondition of TrAssignmentRhs promises
                                                        // assignment has already been done by TrAssignmentRhs
                    finalRhss.Add(null);
                }
                else
                {
                    Contract.Assert(bRhs != null);  // this is what the postcondition of TrAssignmentRhs promises
                    finalRhss.Add(bRhs);
                }
            }
            for (int i = MutateCSharp.Schemata500.ReplaceNumericConstant_4(949L, 0); MutateCSharp.Schemata500.ReplaceBinExprOp_5(953L, i, lhss.Count); MutateCSharp.Schemata500.ReplacePostfixUnaryExprOp_6(958L, ref i))
            {
                lhsBuilder[i](finalRhss[i], rhss[i] is HavocRhs, builder, etran);
            }
        }

        List<Bpl.Expr> ProcessUpdateAssignRhss(List<Expression> lhss, List<AssignmentRhs> rhss,
          BoogieStmtListBuilder builder, List<Variable> locals, ExpressionTranslator etran,
          Statement stmt)
        {
            Contract.Requires(cce.NonNullElements(lhss));
            Contract.Requires(cce.NonNullElements(rhss));
            Contract.Requires(builder != null);
            Contract.Requires(cce.NonNullElements(locals));
            Contract.Requires(etran != null);
            Contract.Requires(predef != null);
            Contract.Ensures(Contract.ForAll(Contract.Result<List<Bpl.Expr>>(), i => i != null));

            var finalRhss = new List<Bpl.Expr>();
            for (int i = MutateCSharp.Schemata500.ReplaceNumericConstant_4(959L, 0); MutateCSharp.Schemata500.ReplaceBinExprOp_5(963L, i, lhss.Count); MutateCSharp.Schemata500.ReplacePostfixUnaryExprOp_6(968L, ref i))
            {
                var lhs = lhss[i];
                // the following assumes are part of the precondition, really
                Contract.Assume(!(lhs is ConcreteSyntaxExpression));
                Contract.Assume(!(lhs is SeqSelectExpr && !((SeqSelectExpr)lhs).SelectOne));  // array-range assignments are not allowed

                Type lhsType, rhsTypeConstraint;
                if (lhs is IdentifierExpr)
                {
                    lhsType = ((IdentifierExpr)lhs).Var.Type;
                    rhsTypeConstraint = lhsType;
                }
                else if (lhs is MemberSelectExpr)
                {
                    var fse = (MemberSelectExpr)lhs;
                    var field = (Field)fse.Member;
                    Contract.Assert(VisibleInScope(field));
                    lhsType = field.Type;
                    rhsTypeConstraint = lhsType.Subst(fse.TypeArgumentSubstitutionsWithParents());
                }
                else if (lhs is SeqSelectExpr)
                {
                    var e = (SeqSelectExpr)lhs;
                    lhsType = null;  // for an array update, always make sure the value assigned is boxed
                    rhsTypeConstraint = e.Seq.Type.NormalizeExpand().TypeArgs[MutateCSharp.Schemata500.ReplaceNumericConstant_4(969L, 0)];
                }
                else
                {
                    var e = (MultiSelectExpr)lhs;
                    lhsType = null;  // for an array update, always make sure the value assigned is boxed
                    rhsTypeConstraint = e.Array.Type.NormalizeExpand().TypeArgs[MutateCSharp.Schemata500.ReplaceNumericConstant_4(973L, 0)];
                }
                var bRhs = TrAssignmentRhs(rhss[i].Tok, null, (lhs as IdentifierExpr)?.Var, lhsType, rhss[i], rhsTypeConstraint, builder, locals, etran, stmt);
                finalRhss.Add(bRhs);
            }
            return finalRhss;
        }


        private void CheckLhssDistinctness(List<Bpl.Expr> rhs, List<AssignmentRhs> rhsOriginal, List<Expression> lhss,
          BoogieStmtListBuilder builder, ExpressionTranslator etran,
          Bpl.Expr[] objs, Bpl.Expr[] fields, string[] names, Expression originalInitialLhs = null)
        {
            Contract.Requires(rhs != null);
            Contract.Requires(rhsOriginal != null);
            Contract.Requires(lhss != null);
            Contract.Requires(rhs.Count == rhsOriginal.Count);
            Contract.Requires(lhss.Count == rhsOriginal.Count);
            Contract.Requires(builder != null);
            Contract.Requires(etran != null);
            Contract.Requires(predef != null);

            for (int i = MutateCSharp.Schemata500.ReplaceNumericConstant_4(977L, 0); MutateCSharp.Schemata500.ReplaceBinExprOp_5(981L, i, lhss.Count); MutateCSharp.Schemata500.ReplacePostfixUnaryExprOp_6(986L, ref i))
            {
                var lhs = lhss[i];
                Contract.Assume(!(lhs is ConcreteSyntaxExpression));
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_32(987L, originalInitialLhs, null))
                {
                    // TODO - check RHS values?
                    AssertDistinctness(lhs, originalInitialLhs, builder, etran);
                }
                for (int j = MutateCSharp.Schemata500.ReplaceNumericConstant_4(988L, 0); MutateCSharp.Schemata500.ReplaceBinExprOp_5(992L, j, i); MutateCSharp.Schemata500.ReplacePostfixUnaryExprOp_6(997L, ref j))
                {
                    if (MutateCSharp.Schemata500.ReplaceBinExprOp_14(998L, () => rhsOriginal[i] is HavocRhs, () => rhsOriginal[j] is HavocRhs))
                    {
                        AssertDistinctness(lhs, lhss[j], builder, etran);
                    }
                    else
                    {
                        AssertDistinctness(lhs, lhss[j], rhs[i], rhs[j], builder, etran);
                    }
                }
            }
        }

        /// <summary>
        /// Note, if "rhs" is "null", then the assignment has already been done elsewhere. However, any other bookkeeping
        /// is still done.
        /// </summary>
        delegate void AssignToLhs(Bpl.Expr/*?*/ rhs, bool origRhsIsHavoc, BoogieStmtListBuilder builder, ExpressionTranslator etran);

        void AssertDistinctness(Expression lhsa, Expression lhsb, BoogieStmtListBuilder builder, ExpressionTranslator etran)
        {
            Bpl.Expr e = CheckDistinctness(lhsa, lhsb, etran);
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_15(1004L, e, null))
            {
                builder.Add(Assert(GetToken(lhsa), e, new PODesc.DistinctLHS(Printer.ExprToString(options, lhsa),
                  Printer.ExprToString(options, lhsb), MutateCSharp.Schemata500.ReplaceBinExprOp_51(1005L, e, Bpl.Expr.False), MutateCSharp.Schemata500.ReplaceBooleanConstant_0(1006L, false))));
            }
        }

        void AssertDistinctness(Expression lhsa, Expression lhsb, Bpl.Expr rhsa, Bpl.Expr rhsb, BoogieStmtListBuilder builder, ExpressionTranslator etran)
        {
            Bpl.Expr e = CheckDistinctness(lhsa, lhsb, etran);
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_15(1007L, e, null))
            {
                e = BplOr(e, Bpl.Expr.Eq(rhsa, rhsb));
                builder.Add(Assert(GetToken(lhsa), e, new PODesc.DistinctLHS(Printer.ExprToString(options, lhsa),
                  Printer.ExprToString(options, lhsb), MutateCSharp.Schemata500.ReplaceBooleanConstant_0(1008L, false), MutateCSharp.Schemata500.ReplaceBooleanConstant_0(1009L, true))));
            }
        }

        /// <summary>
        /// Creates a list of protected Boogie LHSs for the given Dafny LHSs.  Along the way,
        /// builds code that checks that the LHSs are well-defined,
        /// and are allowed by the enclosing reads and modifies clause.
        /// Checks that they denote different locations iff checkDistinctness is true.
        /// </summary>
        void ProcessLhss(List<Expression> lhss, bool rhsCanAffectPreviouslyKnownExpressions, bool checkDistinctness,
          BoogieStmtListBuilder builder, List<Variable> locals, ExpressionTranslator etran, Statement stmt,
          out List<AssignToLhs> lhsBuilders, out List<Bpl.IdentifierExpr/*may be null*/> bLhss,
          out Bpl.Expr[] prevObj, out Bpl.Expr[] prevIndex, out string[] prevNames, Expression originalInitialLhs = null)
        {

            Contract.Requires(cce.NonNullElements(lhss));
            Contract.Requires(builder != null);
            Contract.Requires(cce.NonNullElements(locals));
            Contract.Requires(etran != null);
            Contract.Requires(predef != null);
            Contract.Ensures(Contract.ValueAtReturn(out lhsBuilders).Count == lhss.Count);
            Contract.Ensures(Contract.ValueAtReturn(out lhsBuilders).Count == Contract.ValueAtReturn(out bLhss).Count);

            rhsCanAffectPreviouslyKnownExpressions = MutateCSharp.Schemata500.ReplaceBinExprOp_14(1019L, () => rhsCanAffectPreviouslyKnownExpressions, () => MutateCSharp.Schemata500.ReplaceBinExprOp_28(1014L, lhss.Count, MutateCSharp.Schemata500.ReplaceNumericConstant_4(1010L, 1)));

            // for each Dafny LHS, build a protected Boogie LHS for the eventual assignment
            lhsBuilders = new List<AssignToLhs>();
            bLhss = new List<Bpl.IdentifierExpr>();
            prevObj = new Bpl.Expr[lhss.Count];
            prevIndex = new Bpl.Expr[lhss.Count];
            prevNames = new string[lhss.Count];
            int i = MutateCSharp.Schemata500.ReplaceNumericConstant_4(1025L, 0);

            var lhsNameSet = new Dictionary<string, object>();

            // Note, the resolver does not check for duplicate IdentifierExpr's in LHSs, so do it here.
            foreach (var lhs in lhss)
            {
                Contract.Assume(!(lhs is ConcreteSyntaxExpression));
                if (checkDistinctness)
                {
                    if (MutateCSharp.Schemata500.ReplaceBinExprOp_32(1029L, originalInitialLhs, null))
                    {
                        AssertDistinctness(lhs, originalInitialLhs.Resolved, builder, etran);
                    }
                    for (int j = MutateCSharp.Schemata500.ReplaceNumericConstant_4(1030L, 0); MutateCSharp.Schemata500.ReplaceBinExprOp_5(1034L, j, i); MutateCSharp.Schemata500.ReplacePostfixUnaryExprOp_6(1039L, ref j))
                    {
                        AssertDistinctness(lhs, lhss[j], builder, etran);
                    }
                }

                MutateCSharp.Schemata500.ReplacePostfixUnaryExprOp_6(1040L, ref i);
            }

            i = MutateCSharp.Schemata500.ReplaceNumericConstant_4(1041L, 0);
            foreach (var lhs in lhss)
            {
                IToken tok = lhs.tok;
                TrStmt_CheckWellformed(lhs, builder, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(1045L, true), MutateCSharp.Schemata500.ReplaceBooleanConstant_0(1046L, true));

                if (lhs is IdentifierExpr)
                {
                    var ie = (IdentifierExpr)lhs;
                    prevNames[i] = ie.Name;
                    var bLhs = (Bpl.IdentifierExpr)etran.TrExpr(lhs);  // TODO: is this cast always justified?
                    bLhss.Add(rhsCanAffectPreviouslyKnownExpressions ? null : bLhs);
                    lhsBuilders.Add(delegate (Bpl.Expr rhs, bool origRhsIsHavoc, BoogieStmtListBuilder bldr, ExpressionTranslator et)
                    {
                        if (MutateCSharp.Schemata500.ReplaceBinExprOp_15(1047L, rhs, null))
                        {
                            var cmd = Bpl.Cmd.SimpleAssign(tok, bLhs, rhs);
                            proofDependencies?.AddProofDependencyId(cmd, lhs.tok, new AssignmentDependency(stmt.RangeToken));
                            bldr.Add(cmd);
                        }

                        if (MutateCSharp.Schemata500.ReplaceBinExprOp_14(1048L, () => !origRhsIsHavoc, () => ie.Type.HavocCountsAsDefiniteAssignment(ie.Var.IsGhost)))
                        {
                            MarkDefiniteAssignmentTracker(ie, bldr);
                        }
                    });

                }
                else if (lhs is MemberSelectExpr)
                {
                    var fse = (MemberSelectExpr)lhs;
                    var field = fse.Member as Field;
                    Contract.Assert(field != null);
                    Contract.Assert(VisibleInScope(field));

                    var useSurrogateLocal = MutateCSharp.Schemata500.ReplaceBinExprOp_9(1055L, () => inBodyInitContext, () => MutateCSharp.Schemata500.ReplaceBinExprOp_52(1054L, Expression.AsThis(fse.Obj), null));

                    var obj = SaveInTemp(etran.TrExpr(fse.Obj), rhsCanAffectPreviouslyKnownExpressions,
          MutateCSharp.Schemata500.ReplaceStringConstant_1(1061L, "$obj") + i, predef.RefType, builder, locals);
                    prevObj[i] = obj;
                    if (!useSurrogateLocal)
                    {
                        // check that the enclosing modifies clause allows this object to be written:  assert $_ModifiesFrame[obj]);
                        builder.Add(Assert(tok, Bpl.Expr.SelectTok(tok, etran.ModifiesFrame(tok), obj, GetField(fse)), new PODesc.Modifiable(MutateCSharp.Schemata500.ReplaceStringConstant_1(1062L, "an object"))));
                    }

                    if (useSurrogateLocal)
                    {
                        var nm = SurrogateName(field);
                        var bLhs = new Bpl.IdentifierExpr(fse.tok, nm, TrType(field.Type));
                        bLhss.Add(rhsCanAffectPreviouslyKnownExpressions ? null : bLhs);
                        lhsBuilders.Add(delegate (Bpl.Expr rhs, bool origRhsIsHavoc, BoogieStmtListBuilder bldr, ExpressionTranslator et)
                        {
                            if (MutateCSharp.Schemata500.ReplaceBinExprOp_15(1063L, rhs, null))
                            {
                                var cmd = Bpl.Cmd.SimpleAssign(tok, bLhs, rhs);
                                proofDependencies?.AddProofDependencyId(cmd, fse.tok, new AssignmentDependency(stmt.RangeToken));
                                bldr.Add(cmd);
                            }

                            if (MutateCSharp.Schemata500.ReplaceBinExprOp_14(1064L, () => !origRhsIsHavoc, () => field.Type.HavocCountsAsDefiniteAssignment(field.IsGhost)))
                            {
                                MarkDefiniteAssignmentTracker(lhs.tok, nm, bldr);
                            }
                        });
                    }
                    else
                    {
                        bLhss.Add(null);
                        lhsBuilders.Add(delegate (Bpl.Expr rhs, bool origRhsIsHavoc, BoogieStmtListBuilder bldr, ExpressionTranslator et)
                        {
                            if (MutateCSharp.Schemata500.ReplaceBinExprOp_15(1070L, rhs, null))
                            {
                                var fseField = fse.Member as Field;
                                Contract.Assert(fseField != null);
                                Check_NewRestrictions(tok, obj, fseField, rhs, bldr, et);
                                var h = (Bpl.IdentifierExpr)et.HeapExpr;  // TODO: is this cast always justified?
                                var cmd = Bpl.Cmd.SimpleAssign(tok, h, UpdateHeap(tok, h, obj, new Bpl.IdentifierExpr(tok, GetField(fseField)), rhs));
                                proofDependencies?.AddProofDependencyId(cmd, lhs.tok, new AssignmentDependency(stmt.RangeToken));
                                bldr.Add(cmd);
                                // assume $IsGoodHeap($Heap);
                                bldr.Add(AssumeGoodHeap(tok, et));
                            }
                        });
                    }

                }
                else if (lhs is SeqSelectExpr)
                {
                    SeqSelectExpr sel = (SeqSelectExpr)lhs;
                    Contract.Assert(sel.SelectOne);  // array-range assignments are not allowed
                    Contract.Assert(sel.Seq.Type != null && sel.Seq.Type.IsArrayType);
                    Contract.Assert(sel.E0 != null);
                    var obj = SaveInTemp(etran.TrExpr(sel.Seq), rhsCanAffectPreviouslyKnownExpressions,
          MutateCSharp.Schemata500.ReplaceStringConstant_1(1071L, "$obj") + i, predef.RefType, builder, locals);
                    var idx = etran.TrExpr(sel.E0);
                    idx = ConvertExpression(sel.E0.tok, idx, sel.E0.Type, Type.Int);
                    var fieldName = SaveInTemp(FunctionCall(tok, BuiltinFunction.IndexField, null, idx), rhsCanAffectPreviouslyKnownExpressions,
          MutateCSharp.Schemata500.ReplaceStringConstant_1(1072L, "$index") + i, predef.FieldName(tok), builder, locals);
                    prevObj[i] = obj;
                    prevIndex[i] = fieldName;
                    // check that the enclosing modifies clause allows this object to be written:  assert $_Frame[obj,index]);
                    builder.Add(Assert(tok, Bpl.Expr.SelectTok(tok, etran.ModifiesFrame(tok), obj, fieldName), new PODesc.Modifiable(MutateCSharp.Schemata500.ReplaceStringConstant_1(1073L, "an array element"))));

                    bLhss.Add(null);
                    lhsBuilders.Add(delegate (Bpl.Expr rhs, bool origRhsIsHavoc, BoogieStmtListBuilder bldr, ExpressionTranslator et)
                    {
                        if (MutateCSharp.Schemata500.ReplaceBinExprOp_15(1074L, rhs, null))
                        {
                            var h = (Bpl.IdentifierExpr)et.HeapExpr;  // TODO: is this cast always justified?
                            var cmd = Bpl.Cmd.SimpleAssign(tok, h, UpdateHeap(tok, h, obj, fieldName, rhs));
                            proofDependencies?.AddProofDependencyId(cmd, lhs.tok, new AssignmentDependency(stmt.RangeToken));
                            bldr.Add(cmd);
                            // assume $IsGoodHeap($Heap);
                            bldr.Add(AssumeGoodHeap(tok, et));
                        }
                    });

                }
                else
                {
                    MultiSelectExpr mse = (MultiSelectExpr)lhs;
                    Contract.Assert(mse.Array.Type != null && mse.Array.Type.IsArrayType);

                    var obj = SaveInTemp(etran.TrExpr(mse.Array), rhsCanAffectPreviouslyKnownExpressions,
          MutateCSharp.Schemata500.ReplaceStringConstant_1(1075L, "$obj") + i, predef.RefType, builder, locals);
                    var fieldName = SaveInTemp(etran.GetArrayIndexFieldName(mse.tok, mse.Indices), rhsCanAffectPreviouslyKnownExpressions,
          MutateCSharp.Schemata500.ReplaceStringConstant_1(1076L, "$index") + i, predef.FieldName(mse.tok), builder, locals);
                    prevObj[i] = obj;
                    prevIndex[i] = fieldName;
                    builder.Add(Assert(tok, Bpl.Expr.SelectTok(tok, etran.ModifiesFrame(tok), obj, fieldName), new PODesc.Modifiable(MutateCSharp.Schemata500.ReplaceStringConstant_1(1077L, "an array element"))));

                    bLhss.Add(null);
                    lhsBuilders.Add(delegate (Bpl.Expr rhs, bool origRhsIsHavoc, BoogieStmtListBuilder bldr, ExpressionTranslator et)
                    {
                        if (MutateCSharp.Schemata500.ReplaceBinExprOp_15(1078L, rhs, null))
                        {
                            var h = (Bpl.IdentifierExpr)et.HeapExpr;  // TODO: is this cast always justified?
                            var cmd = Bpl.Cmd.SimpleAssign(tok, h, UpdateHeap(tok, h, obj, fieldName, rhs));
                            proofDependencies?.AddProofDependencyId(cmd, lhs.tok, new AssignmentDependency(stmt.RangeToken));
                            bldr.Add(cmd);
                            // assume $IsGoodHeap($Heap);
                            bldr.Add(AssumeGoodHeap(tok, etran));
                        }
                    });
                }

                MutateCSharp.Schemata500.ReplacePostfixUnaryExprOp_6(1079L, ref i);
            }
        }

        /// <summary>
        /// if "bGivenLhs" is non-null, generates an assignment of the translation of "rhs" to "bGivenLhs" and then returns "bGivenLhs".
        /// If "bGivenLhs" is null, then this method will return an expression that in a stable way denotes the translation of "rhs";
        /// this is achieved by creating a new temporary Boogie variable to hold the result and returning an expression that mentions
        /// that new temporary variable.
        ///
        /// Before the assignment, the generated code will check that "rhs" obeys any subrange requirements entailed by "rhsTypeConstraint".
        ///
        /// The purpose of "lhsVar" is to determine an appropriate Boogie "where" clause for any temporary variable generated.
        /// If passed in as non-null, it says that "lhsVar" is the LHS of the assignment being translated. If the type is subject to
        /// definite-assignment rules and the RHS is "*", then the "where" clause of the temporary variable will have the form
        /// "defass#lhs ==> wh" where "defass#lhs" is the definite-assignment tracker for "lhsVar" and "wh" is the "where"
        /// clause for type "lhsType" for the temporary variable.
        ///
        /// The purpose of "lhsType" is to determine if the expression should be boxed before doing the assignment.  It is allowed to be null,
        /// which indicates that the result should always be a box.  Note that "lhsType" may refer to a formal type parameter that is not in
        /// scope; this is okay, since the purpose of "lhsType" is just to say whether or not the result should be boxed.
        /// </summary>
        Bpl.Expr TrAssignmentRhs(IToken tok, Bpl.IdentifierExpr bGivenLhs, IVariable lhsVar, Type lhsType,
                                 AssignmentRhs rhs, Type rhsTypeConstraint,
                                 BoogieStmtListBuilder builder, List<Variable> locals, ExpressionTranslator etran,
                                 Statement stmt)
        {
            Contract.Requires(tok != null);
            Contract.Requires(rhs != null);
            Contract.Requires(rhsTypeConstraint != null);
            Contract.Requires(builder != null);
            Contract.Requires(locals != null);
            Contract.Requires(etran != null);
            Contract.Requires(predef != null);
            Contract.Ensures(Contract.Result<Bpl.Expr>() != null);
            Contract.Ensures(bGivenLhs == null || Contract.Result<Bpl.Expr>() == bGivenLhs);

            Bpl.IdentifierExpr bLhs;
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_50(1080L, bGivenLhs, null))
            {
                bLhs = bGivenLhs;
            }
            else
            {
                Type localType = rhsTypeConstraint;  // this is a type that is appropriate for capturing the value of the RHS
                var ty = TrType(localType);
                var nm = CurrentIdGenerator.FreshId(MutateCSharp.Schemata500.ReplaceStringConstant_1(1081L, "$rhs#"));
                Bpl.Expr wh;
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_9(1082L, () => rhs is HavocRhs, () => localType.IsNonempty))
                {
                    wh = GetWhereClause(tok, new Bpl.IdentifierExpr(tok, nm, ty), localType, etran, NOALLOC);
                }
                else if (MutateCSharp.Schemata500.ReplaceBinExprOp_9(1096L, () => MutateCSharp.Schemata500.ReplaceBinExprOp_9(1089L, () => rhs is HavocRhs, () => MutateCSharp.Schemata500.ReplaceBinExprOp_53(1088L, lhsVar, null)), () => MutateCSharp.Schemata500.ReplaceBinExprOp_50(1095L, GetDefiniteAssignmentTracker(lhsVar), null)))
                {
                    // This "where" clause expresses that the new variable has a value of the given type only if
                    // the variable has already been definitely assigned. (If it has not already been assigned,
                    // then the variable will get a new value, but Dafny's definite-assginment rules prevent that
                    // value from being used, so it's appropriate to use effectively-"true" as the "where" clause
                    // in that case.
                    wh = BplImp(GetDefiniteAssignmentTracker(lhsVar),
                      GetWhereClause(tok, new Bpl.IdentifierExpr(tok, nm, ty), localType, etran, NOALLOC));
                }
                else
                {
                    // In this case, it could be unsound to use a "where" clause, see issue #1619.
                    // Luckily, leaving it out is harmless, because we don't need a "where" clause here in the first
                    // place--because the variable is short lived, we know it will not be havoc'ed by Boogie, so a
                    // "where" wouldn't provide additional information over the assigned value.
                    wh = null;
                }
                var v = new Bpl.LocalVariable(tok, new Bpl.TypedIdent(tok, nm, ty, wh));
                locals.Add(v);
                bLhs = new Bpl.IdentifierExpr(tok, v);
            }

            if (rhs is ExprRhs)
            {
                var e = (ExprRhs)rhs;

                TrStmt_CheckWellformed(e.Expr, builder, locals, etran, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(1102L, true));

                Bpl.Expr bRhs = etran.TrExpr(e.Expr);
                CheckSubrange(tok, bRhs, e.Expr.Type, rhsTypeConstraint, builder);
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_50(1103L, bGivenLhs, null))
                {
                    Contract.Assert(bGivenLhs == bLhs);
                    // box the RHS, then do the assignment
                    var cmd = Bpl.Cmd.SimpleAssign(tok, bGivenLhs, CondApplyBox(tok, bRhs, e.Expr.Type, lhsType));
                    proofDependencies?.AddProofDependencyId(cmd, tok, new AssignmentDependency(stmt.RangeToken));
                    builder.Add(cmd);
                    return bGivenLhs;
                }
                else
                {
                    // box from RHS type to tmp-var type, then do the assignment; then return LHS, boxed from tmp-var type to result type
                    var cmd = Bpl.Cmd.SimpleAssign(tok, bLhs, CondApplyBox(tok, bRhs, e.Expr.Type, rhsTypeConstraint));
                    proofDependencies?.AddProofDependencyId(cmd, tok, new AssignmentDependency(stmt.RangeToken));
                    builder.Add(cmd);
                    return CondApplyBox(tok, bLhs, rhsTypeConstraint, lhsType);
                }

            }
            else if (rhs is HavocRhs)
            {
                builder.Add(new Bpl.HavocCmd(tok, new List<Bpl.IdentifierExpr> { bLhs }));
                return CondApplyBox(tok, bLhs, rhsTypeConstraint, lhsType);
            }
            else
            {
                // x := new Something
                Contract.Assert(rhs is TypeRhs);  // otherwise, an unexpected AssignmentRhs
                TypeRhs tRhs = (TypeRhs)rhs;

                var callsConstructor = MutateCSharp.Schemata500.ReplaceBinExprOp_9(1105L, () => MutateCSharp.Schemata500.ReplaceBinExprOp_54(1104L, tRhs.InitCall, null), () => tRhs.InitCall.Method is Constructor);

                if (MutateCSharp.Schemata500.ReplaceBinExprOp_55(1111L, tRhs.ArrayDimensions, null))
                {
                    Contract.Assert(tRhs.ElementInit == null && tRhs.InitDisplay == null);
                }
                else
                {
                    int i = MutateCSharp.Schemata500.ReplaceNumericConstant_4(1112L, 0);
                    foreach (Expression dim in tRhs.ArrayDimensions)
                    {
                        CheckWellformed(dim, new WFOptions(), locals, builder, etran);
                        var desc = new PODesc.NonNegative(MutateCSharp.Schemata500.ReplaceBinExprOp_8(1120L, tRhs.ArrayDimensions.Count, MutateCSharp.Schemata500.ReplaceNumericConstant_4(1116L, 1
            )) ? MutateCSharp.Schemata500.ReplaceStringConstant_1(1125L, "array size") : $"array size (dimension {i})", dim);
                        builder.Add(Assert(GetToken(dim), Bpl.Expr.Le(Bpl.Expr.Literal(MutateCSharp.Schemata500.ReplaceNumericConstant_4(1126L, 0)), etran.TrExpr(dim)), desc));
                        MutateCSharp.Schemata500.ReplacePostfixUnaryExprOp_6(1130L, ref i);
                    }
                    if (MutateCSharp.Schemata500.ReplaceBinExprOp_32(1131L, tRhs.ElementInit, null))
                    {
                        CheckWellformed(tRhs.ElementInit, new WFOptions(), locals, builder, etran);
                    }
                    else if (MutateCSharp.Schemata500.ReplaceBinExprOp_36(1132L, tRhs.InitDisplay, null))
                    {
                        var dim = tRhs.ArrayDimensions[MutateCSharp.Schemata500.ReplaceNumericConstant_4(1133L, 0)];
                        var desc = new PODesc.ArrayInitSizeValid(tRhs, dim);
                        builder.Add(Assert(GetToken(dim), Bpl.Expr.Eq(etran.TrExpr(dim), Bpl.Expr.Literal(tRhs.InitDisplay.Count)), desc));
                        foreach (var v in tRhs.InitDisplay)
                        {
                            CheckWellformed(v, new WFOptions(), locals, builder, etran);
                        }
                    }
                    else if (MutateCSharp.Schemata500.ReplaceBinExprOp_8(1141L, options.DefiniteAssignmentLevel, MutateCSharp.Schemata500.ReplaceNumericConstant_4(1137L, 0)))
                    {
                        // cool
                    }
                    else if (MutateCSharp.Schemata500.ReplaceBinExprOp_14(1176L, () => MutateCSharp.Schemata500.ReplaceBinExprOp_14(1170L, () => (MutateCSharp.Schemata500.ReplaceBinExprOp_9(1164L, () => MutateCSharp.Schemata500.ReplaceBinExprOp_25(1150L, MutateCSharp.Schemata500.ReplaceNumericConstant_4(1146L, 2), options.DefiniteAssignmentLevel), () => MutateCSharp.Schemata500.ReplaceBinExprOp_28(1159L, options.DefiniteAssignmentLevel, MutateCSharp.Schemata500.ReplaceNumericConstant_4(1155L, 4)))), () => options.Get(CommonOptionBag.EnforceDeterminism)), () => !tRhs.EType.HasCompilableValue))
                    {
                        // this is allowed only if the array size is such that it has no elements
                        Bpl.Expr zeroSize = Bpl.Expr.False;
                        foreach (Expression dim in tRhs.ArrayDimensions)
                        {
                            zeroSize = BplOr(zeroSize, Bpl.Expr.Eq(Bpl.Expr.Literal(MutateCSharp.Schemata500.ReplaceNumericConstant_4(1182L, 0)), etran.TrExpr(dim)));
                        }
                        var desc = new PODesc.ArrayInitEmpty(tRhs.EType.ToString(), tRhs.ArrayDimensions);
                        builder.Add(Assert(tRhs.Tok, zeroSize, desc));
                    }
                }

                Bpl.IdentifierExpr nw = GetNewVar_IdExpr(tok, locals);
                if (!callsConstructor)
                {
                    SelectAllocateObject(tok, nw, tRhs.Type, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(1186L, true), builder, etran);
                    if (MutateCSharp.Schemata500.ReplaceBinExprOp_36(1187L, tRhs.ArrayDimensions, null))
                    {
                        int i = MutateCSharp.Schemata500.ReplaceNumericConstant_4(1188L, 0);
                        foreach (Expression dim in tRhs.ArrayDimensions)
                        {
                            // assume Array#Length($nw, i) == arraySize;
                            Bpl.Expr arrayLength = ArrayLength(tok, nw, tRhs.ArrayDimensions.Count, i);
                            builder.Add(TrAssumeCmd(tok, Bpl.Expr.Eq(arrayLength, etran.TrExpr(dim))));
                            MutateCSharp.Schemata500.ReplacePostfixUnaryExprOp_6(1192L, ref i);
                        }
                        if (MutateCSharp.Schemata500.ReplaceBinExprOp_32(1193L, tRhs.ElementInit, null))
                        {
                            CheckElementInit(tok, MutateCSharp.Schemata500.ReplaceBooleanConstant_0(1194L, true), tRhs.ArrayDimensions, tRhs.EType, tRhs.ElementInit, nw, builder, etran, new WFOptions());
                        }
                        else if (MutateCSharp.Schemata500.ReplaceBinExprOp_36(1195L, tRhs.InitDisplay, null))
                        {
                            int ii = MutateCSharp.Schemata500.ReplaceNumericConstant_4(1196L, 0);
                            foreach (var v in tRhs.InitDisplay)
                            {
                                var EE_ii = etran.TrExpr(v);
                                // assert EE_ii satisfies any subset-type constraints;
                                CheckSubrange(v.tok, EE_ii, v.Type, tRhs.EType, builder);
                                // assume nw[ii] == EE_ii;
                                var ai = ReadHeap(tok, etran.HeapExpr, nw, GetArrayIndexFieldName(tok, new List<Bpl.Expr> { Bpl.Expr.Literal(ii) }));
                                builder.Add(new Bpl.AssumeCmd(tok, Bpl.Expr.Eq(UnboxUnlessInherentlyBoxed(ai, tRhs.EType), EE_ii)));
                                MutateCSharp.Schemata500.ReplacePostfixUnaryExprOp_6(1200L, ref ii);
                            }
                        }
                    }
                    Bpl.Cmd heapAllocationRecorder = null;
                    if (codeContext is IteratorDecl)
                    {
                        var iter = (IteratorDecl)codeContext;
                        // $Heap[this, _new] := Set#UnionOne($Heap[this, _new], $Box($nw));
                        var th = new Bpl.IdentifierExpr(tok, etran.This, predef.RefType);
                        var nwField = new Bpl.IdentifierExpr(tok, GetField(iter.Member_New));
                        var thisDotNew = ApplyUnbox(tok, ReadHeap(tok, etran.HeapExpr, th, nwField), predef.SetType);
                        var unionOne = FunctionCall(tok, BuiltinFunction.SetUnionOne, predef.BoxType, thisDotNew, ApplyBox(tok, nw));
                        var heapRhs = UpdateHeap(tok, etran.HeapExpr, th, nwField, unionOne);
                        heapAllocationRecorder = Bpl.Cmd.SimpleAssign(tok, etran.HeapCastToIdentifierExpr, heapRhs);
                    }
                    CommitAllocatedObject(tok, nw, heapAllocationRecorder, builder, etran);
                }
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_54(1201L, tRhs.InitCall, null))
                {
                    AddComment(builder, tRhs.InitCall, MutateCSharp.Schemata500.ReplaceStringConstant_1(1202L, "init call statement"));
                    TrCallStmt(tRhs.InitCall, builder, locals, etran, nw);
                }
                // bLhs := $nw;
                CheckSubrange(tok, nw, tRhs.Type, rhsTypeConstraint, builder);
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_50(1203L, bGivenLhs, null))
                {
                    Contract.Assert(bGivenLhs == bLhs);
                    // box the RHS, then do the assignment
                    var cmd = Bpl.Cmd.SimpleAssign(tok, bGivenLhs, CondApplyBox(tok, nw, tRhs.Type, lhsType));
                    proofDependencies?.AddProofDependencyId(cmd, tok, new AssignmentDependency(stmt.RangeToken));
                    builder.Add(cmd);
                    return bGivenLhs;
                }
                else
                {
                    // do the assignment, then box the result
                    var cmd = Bpl.Cmd.SimpleAssign(tok, bLhs, nw);
                    proofDependencies?.AddProofDependencyId(cmd, tok, new AssignmentDependency(stmt.RangeToken));
                    builder.Add(cmd);
                    return CondApplyBox(tok, bLhs, tRhs.Type, lhsType);
                }
            }

            return default;
        }


        private void SelectAllocateObject(IToken tok, Bpl.IdentifierExpr nw, Type type, bool includeHavoc, BoogieStmtListBuilder builder, ExpressionTranslator etran)
        {
            Contract.Requires(tok != null);
            Contract.Requires(nw != null);
            Contract.Requires(type != null);
            Contract.Requires(builder != null);
            Contract.Requires(etran != null);
            var udt = type as UserDefinedType;
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_9(1205L, () => MutateCSharp.Schemata500.ReplaceBinExprOp_56(1204L, udt, null), () => udt.ResolvedClass is NonNullTypeDecl))
            {
                var nnt = (NonNullTypeDecl)udt.ResolvedClass;
                type = nnt.RhsWithArgument(type.TypeArgs);
            }
            if (includeHavoc)
            {
                // havoc $nw;
                builder.Add(new Bpl.HavocCmd(tok, new List<Bpl.IdentifierExpr> { nw }));
                // assume $nw != null && $Is($nw, type);
                var nwNotNull = Bpl.Expr.Neq(nw, predef.Null);
                // drop the $Is conjunct if the type is "object", because "new object" allocates an object of an arbitrary type
                var rightType = type.IsObjectQ ? Bpl.Expr.True : MkIs(nw, type);
                builder.Add(TrAssumeCmd(tok, BplAnd(nwNotNull, rightType)));
            }
            // assume !$Heap[$nw, alloc];
            var notAlloc = Bpl.Expr.Not(etran.IsAlloced(tok, nw));
            builder.Add(TrAssumeCmd(tok, notAlloc));
        }

        private void CommitAllocatedObject(IToken tok, Bpl.IdentifierExpr nw, Bpl.Cmd extraCmd, BoogieStmtListBuilder builder, ExpressionTranslator etran)
        {
            Contract.Requires(tok != null);
            Contract.Requires(nw != null);
            Contract.Requires(builder != null);
            Contract.Requires(etran != null);

            // $Heap[$nw, alloc] := true;
            Bpl.Expr alloc = predef.Alloc(tok);
            Bpl.IdentifierExpr heap = etran.HeapCastToIdentifierExpr;
            Bpl.Cmd cmd = Bpl.Cmd.SimpleAssign(tok, heap, UpdateHeap(tok, heap, nw, alloc, Bpl.Expr.True));
            builder.Add(cmd);
            if (MutateCSharp.Schemata500.ReplaceBinExprOp_42(1211L, extraCmd, null))
            {
                builder.Add(extraCmd);
            }
            // assume $IsGoodHeap($Heap);
            builder.Add(AssumeGoodHeap(tok, etran));
            // assume $IsHeapAnchor($Heap);
            builder.Add(new Bpl.AssumeCmd(tok, FunctionCall(tok, BuiltinFunction.IsHeapAnchor, null, etran.HeapExpr)));
        }


        private void IntroduceAndAssignExistentialVars(ExistsExpr exists, BoogieStmtListBuilder builder, BoogieStmtListBuilder builderOutsideIfConstruct, List<Variable> locals, ExpressionTranslator etran, bool isGhost)
        {
            Contract.Requires(exists != null);
            Contract.Requires(exists.Range == null);
            Contract.Requires(builder != null);
            Contract.Requires(builderOutsideIfConstruct != null);
            Contract.Requires(locals != null);
            Contract.Requires(etran != null);
            // declare and havoc the bound variables of 'exists' as local variables
            var iesForHavoc = new List<Bpl.IdentifierExpr>();
            foreach (var bv in exists.BoundVars)
            {
                Bpl.Type varType = TrType(bv.Type);
                Bpl.Expr wh = GetWhereClause(bv.Tok,
                  new Bpl.IdentifierExpr(bv.Tok, bv.AssignUniqueName(currentDeclaration.IdGenerator), varType),
                  bv.Type, etran, isAllocContext.Var(isGhost, bv));
                Bpl.Variable local = new Bpl.LocalVariable(bv.Tok, new Bpl.TypedIdent(bv.Tok, bv.AssignUniqueName(currentDeclaration.IdGenerator), varType, wh));
                locals.Add(local);
                iesForHavoc.Add(new Bpl.IdentifierExpr(local.tok, local));
            }
            builderOutsideIfConstruct.Add(new Bpl.HavocCmd(exists.tok, iesForHavoc));
            builder.Add(TrAssumeCmd(exists.tok, etran.TrExpr(exists.Term)));
        }

        void TrStmtList(List<Statement> stmts, BoogieStmtListBuilder builder, List<Variable> locals, ExpressionTranslator etran)
        {
            Contract.Requires(stmts != null);
            Contract.Requires(builder != null);
            Contract.Requires(locals != null);
            Contract.Requires(etran != null);
            foreach (Statement ss in stmts)
            {
                for (var l = ss.Labels; MutateCSharp.Schemata500.ReplaceBinExprOp_41(1212L, l, null); l = l.Next)
                {
                    var heapAt = new Bpl.LocalVariable(ss.Tok, new Bpl.TypedIdent(ss.Tok, MutateCSharp.Schemata500.ReplaceStringConstant_1(1213L, "$Heap_at_") + l.Data.AssignUniqueId(CurrentIdGenerator), predef.HeapType));
                    locals.Add(heapAt);
                    builder.Add(Bpl.Cmd.SimpleAssign(ss.Tok, new Bpl.IdentifierExpr(ss.Tok, heapAt), etran.HeapExpr));
                }
                TrStmt(ss, builder, locals, etran);
                if (MutateCSharp.Schemata500.ReplaceBinExprOp_41(1214L, ss.Labels, null))
                {
                    builder.AddLabelCmd(MutateCSharp.Schemata500.ReplaceStringConstant_1(1215L, "after_") + ss.Labels.Data.AssignUniqueId(CurrentIdGenerator));
                }
            }
        }

        void TrStmt_CheckWellformed(Expression expr, BoogieStmtListBuilder builder, List<Variable> locals, ExpressionTranslator etran, bool subsumption, bool lValueContext = false)
        {
            Contract.Requires(expr != null);
            Contract.Requires(builder != null);
            Contract.Requires(locals != null);
            Contract.Requires(etran != null);
            Contract.Requires(predef != null);

            Bpl.QKeyValue kv;
            if (subsumption)
            {
                kv = null;  // this is the default behavior of Boogie's assert
            }
            else
            {
                List<object> args = new List<object>();
                // {:subsumption 0}
                args.Add(Bpl.Expr.Literal(MutateCSharp.Schemata500.ReplaceNumericConstant_4(1216L, 0)));
                kv = new Bpl.QKeyValue(expr.tok, MutateCSharp.Schemata500.ReplaceStringConstant_1(1220L, "subsumption"), args, null);
            }
            var options = new WFOptions(kv);
            // Only do reads checks if reads clauses on methods are enabled and the reads clause is not *.
            // The latter is important to avoid any extra verification cost for backwards compatibility.
            if (etran.readsFrame != null)
            {
                options = options.WithReadsChecks(MutateCSharp.Schemata500.ReplaceBooleanConstant_0(1221L, true));
            }
            if (lValueContext)
            {
                options = options.WithLValueContext(MutateCSharp.Schemata500.ReplaceBooleanConstant_0(1222L, true));
            }
            CheckWellformed(expr, options, locals, builder, etran);
            builder.Add(TrAssumeCmd(expr.tok, etran.CanCallAssumption(expr)));
        }
    }
}
