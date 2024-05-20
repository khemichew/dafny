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
using System.Diagnostics.Contracts;
using DafnyCore;
using JetBrains.Annotations;
using ResolutionContext = Microsoft.Dafny.ResolutionContext;
namespace MutateCSharp
{
    internal class Schemata423
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT423");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_42(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_39(long mutantId, Microsoft.Dafny.DatatypeCtor argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.PreType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.DPreType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_7(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_40(long mutantId, Microsoft.Dafny.CasePattern<Microsoft.Dafny.BoundVar> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_18(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_27(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_23(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Type> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_28(long mutantId, Microsoft.Dafny.MethodCallInformation argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_31(long mutantId, Microsoft.Dafny.DPreType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_37(long mutantId, Microsoft.Dafny.DatatypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_33(long mutantId, Microsoft.Dafny.Label argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_36(long mutantId, Microsoft.Dafny.DatatypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_30(long mutantId, Microsoft.Dafny.Label argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_34(long mutantId, Microsoft.Dafny.Function argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_25(long mutantId, System.Collections.Generic.Dictionary<string, Microsoft.Dafny.DatatypeCtor> argument1, object argument2)
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

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.Expression argument1, Microsoft.Dafny.Expression argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_26(long mutantId, Microsoft.Dafny.TopLevelDeclWithMembers argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.IVariable argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_24(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.ActualBinding> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBooleanConstant_4(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.TopLevelDeclWithMembers argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static bool ReplaceBinExprOp_19(long mutantId, System.Collections.Generic.Dictionary<string, Microsoft.Dafny.MemberDecl> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_20(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Type> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.CasePattern<Microsoft.Dafny.BoundVar> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_38(long mutantId, Microsoft.Dafny.DatatypeCtor argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_41(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, Microsoft.Dafny.Type argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_29(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, Microsoft.Dafny.PreType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
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

        internal static bool ReplaceBinExprOp_21(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceBinExprOp_11(long mutantId, int argument1, int argument2)
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

    }
}

namespace Microsoft.Dafny
{
    public partial class PreTypeResolver
    {
        // ---------------------------------------- Expressions ----------------------------------------

        public void ResolveExpression(Expression expr, ResolutionContext resolutionContext)
        {
            Contract.Requires(expr != null);
            Contract.Requires(resolutionContext != null);

            if (MutateCSharp.Schemata423.ReplaceBinExprOp_0(1L, expr.PreType, null))
            {
                // expression has already been pre-resolved
                return;
            }

            if (expr is ParensExpression)
            {
                var e = (ParensExpression)expr;
                ResolveExpression(e.E, resolutionContext);
                e.ResolvedExpression = e.E;
                e.PreType = e.E.PreType;

            }
            else if (expr is ChainingExpression)
            {
                var e = (ChainingExpression)expr;
                ResolveExpression(e.E, resolutionContext);
                e.ResolvedExpression = e.E;
                e.PreType = e.E.PreType;

            }
            else if (expr is NegationExpression)
            {
                var e = (NegationExpression)expr;
                ResolveExpression(e.E, resolutionContext);
                e.PreType = CreatePreTypeProxy(MutateCSharp.Schemata423.ReplaceStringConstant_1(2L, "result of unary -"));
                AddSubtypeConstraint(e.PreType, e.E.PreType, e.E.tok,
                  $"type of argument to unary - ({{1}}) must agree with the result type ({{0}})");
                AddConfirmation(PreTypeConstraints.CommonConfirmationBag.NumericOrBitvector, e.E.PreType, e.E.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(3L, "type of unary - must be of a numeric or bitvector type (instead got {0})"));
                // Note, e.ResolvedExpression will be filled in during CheckTypeInference, at which time e.PreType has been determined

            }
            else if (expr is LiteralExpr)
            {
                var e = (LiteralExpr)expr;

                if (e is StaticReceiverExpr eStatic)
                {
                    resolver.ResolveType(eStatic.tok, eStatic.UnresolvedType, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                    eStatic.PreType = Type2PreType(eStatic.UnresolvedType, MutateCSharp.Schemata423.ReplaceStringConstant_1(4L, "static receiver type"));
                }
                else
                {
                    if (e.Value == null)
                    {
                        e.PreType = CreatePreTypeProxy(MutateCSharp.Schemata423.ReplaceStringConstant_1(5L, "literal 'null'"));
                        Constraints.AddDefaultAdvice(e.PreType, CommonAdvice.Target.Object);
                        AddConfirmation(PreTypeConstraints.CommonConfirmationBag.IsNullableRefType, e.PreType, e.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(6L, "type of 'null' is a reference type, but it is used as {0}"));
                    }
                    else if (e.Value is BigInteger)
                    {
                        e.PreType = CreatePreTypeProxy($"integer literal '{e.Value}'");
                        Constraints.AddDefaultAdvice(e.PreType, CommonAdvice.Target.Int);
                        AddConfirmation(PreTypeConstraints.CommonConfirmationBag.IntOrBitvectorOrORDINAL, e.PreType, e.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(7L, "integer literal used as if it had type {0}"));
                    }
                    else if (e.Value is BaseTypes.BigDec)
                    {
                        e.PreType = CreatePreTypeProxy($"real literal '{e.Value}'");
                        Constraints.AddDefaultAdvice(e.PreType, CommonAdvice.Target.Real);
                        AddConfirmation(PreTypeConstraints.CommonConfirmationBag.InRealFamily, e.PreType, e.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(8L, "type of real literal is used as {0}")); // TODO: make this error message have the same form as the one for integers above
                    }
                    else if (e.Value is bool)
                    {
                        e.PreType = CreatePreTypeProxy($"boolean literal '{e.Value.ToString().ToLower()}'");
                        Constraints.AddDefaultAdvice(e.PreType, CommonAdvice.Target.Bool);
                        AddConfirmation(PreTypeConstraints.CommonConfirmationBag.InBoolFamily, e.PreType, e.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(9L, "boolean literal used as if it had type {0}"));
                    }
                    else if (e is CharLiteralExpr)
                    {
                        e.PreType = CreatePreTypeProxy($"character literal '{e.Value}'");
                        Constraints.AddDefaultAdvice(e.PreType, CommonAdvice.Target.Char);
                        AddConfirmation(PreTypeConstraints.CommonConfirmationBag.InCharFamily, e.PreType, e.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(10L, "character literal used as if it had type {0}"));
                    }
                    else if (e is StringLiteralExpr)
                    {
                        e.PreType = CreatePreTypeProxy($"string literal \"{e.Value}\"");
                        Constraints.AddDefaultAdvice(e.PreType, CommonAdvice.Target.String);
                        AddConfirmation(PreTypeConstraints.CommonConfirmationBag.InSeqFamily, e.PreType, e.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(11L, "string literal used as if it had type {0}"));
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
                    ReportError(expr, MutateCSharp.Schemata423.ReplaceStringConstant_1(12L, "'this' is not allowed in a 'static' context"));
                }
                if (currentClass is DefaultClassDecl)
                {
                    // there's no type
                }
                else if (MutateCSharp.Schemata423.ReplaceBinExprOp_2(13L, currentClass, null))
                {
                    Contract.Assert(resolver.reporter.HasErrors);
                }
                else
                {
                    var ty = ModuleResolver.GetThisType(expr.tok, currentClass);  // do this regardless of scope.AllowInstance, for better error reporting
                    expr.PreType = Type2PreType(ty, MutateCSharp.Schemata423.ReplaceStringConstant_1(14L, "type of 'this'"));
                }

            }
            else if (expr is IdentifierExpr)
            {
                var e = (IdentifierExpr)expr;
                e.Var = scope.Find(e.Name);
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_3(15L, e.Var, null))
                {
                    expr.PreType = e.Var.PreType;
                }
                else
                {
                    ReportError(expr, MutateCSharp.Schemata423.ReplaceStringConstant_1(16L, "Identifier does not denote a local variable, parameter, or bound variable: {0}"), e.Name);
                }

            }
            else if (expr is DatatypeValue)
            {
                var dtv = (DatatypeValue)expr;
                if (!resolver.moduleInfo.TopLevels.TryGetValue(dtv.DatatypeName, out var decl))
                {
                    ReportError(expr.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(17L, "Undeclared datatype: {0}"), dtv.DatatypeName);
                }
                else if (decl is AmbiguousTopLevelDecl)
                {
                    var ad = (AmbiguousTopLevelDecl)decl;
                    ReportError(expr.tok,
          MutateCSharp.Schemata423.ReplaceStringConstant_1(18L, "The name {0} ambiguously refers to a type in one of the modules {1} (try qualifying the type name with the module name)"),
                      dtv.DatatypeName, ad.ModuleNames());
                }
                else if (decl is DatatypeDecl dtd)
                {
                    ResolveDatatypeValue(resolutionContext, dtv, dtd, null);
                }
                else
                {
                    ReportError(expr.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(19L, "Expected datatype: {0}"), dtv.DatatypeName);
                }

            }
            else if (expr is DisplayExpression)
            {
                var e = (DisplayExpression)expr;
                var elementPreType = CreatePreTypeProxy(MutateCSharp.Schemata423.ReplaceStringConstant_1(20L, "display expression element type"));
                foreach (var ee in e.Elements)
                {
                    ResolveExpression(ee, resolutionContext);
                    AddSubtypeConstraint(elementPreType, ee.PreType, ee.tok,
          MutateCSharp.Schemata423.ReplaceStringConstant_1(21L, "All elements of display must have some common supertype (got {1}, but needed type or type of previous elements is {0})"));
                }
                if (expr is SetDisplayExpr setDisplayExpr)
                {
                    var confirmationFamily = setDisplayExpr.Finite
                      ? PreTypeConstraints.CommonConfirmationBag.InSetFamily
                      : PreTypeConstraints.CommonConfirmationBag.InIsetFamily;
                    ResolveCollectionProducingExpr(PreType.SetTypeName(setDisplayExpr.Finite), MutateCSharp.Schemata423.ReplaceStringConstant_1(22L, "display"), setDisplayExpr, elementPreType, confirmationFamily);
                }
                else if (expr is MultiSetDisplayExpr multiSetDisplayExpr)
                {
                    ResolveCollectionProducingExpr(PreType.TypeNameMultiset, MutateCSharp.Schemata423.ReplaceStringConstant_1(23L, "display"), e, elementPreType,
                      PreTypeConstraints.CommonConfirmationBag.InMultisetFamily);
                }
                else
                {
                    ResolveCollectionProducingExpr(PreType.TypeNameSeq, MutateCSharp.Schemata423.ReplaceStringConstant_1(24L, "display"), e, elementPreType, PreTypeConstraints.CommonConfirmationBag.InSeqFamily);
                }

            }
            else if (expr is MapDisplayExpr)
            {
                var e = (MapDisplayExpr)expr;
                var domainPreType = CreatePreTypeProxy(MutateCSharp.Schemata423.ReplaceStringConstant_1(25L, "map display expression domain type"));
                var rangePreType = CreatePreTypeProxy(MutateCSharp.Schemata423.ReplaceStringConstant_1(26L, "map display expression range type"));
                foreach (ExpressionPair p in e.Elements)
                {
                    ResolveExpression(p.A, resolutionContext);
                    AddSubtypeConstraint(domainPreType, p.A.PreType, p.A.tok,
          MutateCSharp.Schemata423.ReplaceStringConstant_1(27L, "All elements of display must have some common supertype (got {1}, but needed type or type of previous elements is {0})"));
                    ResolveExpression(p.B, resolutionContext);
                    AddSubtypeConstraint(rangePreType, p.B.PreType, p.B.tok,
          MutateCSharp.Schemata423.ReplaceStringConstant_1(28L, "All elements of display must have some common supertype (got {1}, but needed type or type of previous elements is {0})"));
                }

                ResolveMapProducingExpr(e.Finite, MutateCSharp.Schemata423.ReplaceStringConstant_1(29L, "display"), expr, domainPreType, rangePreType);

            }
            else if (expr is NameSegment)
            {
                var e = (NameSegment)expr;
                ResolveNameSegment(e, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(30L, true), null, resolutionContext, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(31L, false));

                if (e.PreType is PreTypePlaceholderModule)
                {
                    ReportError(e.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(32L, "name of module ({0}) is used as a variable"), e.Name);
                    ResetTypeAssignment(e); // the rest of type checking assumes actual types
                }
                else if (e.PreType is PreTypePlaceholderType)
                {
                    ReportError(e.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(33L, "name of type ({0}) is used as a variable"), e.Name);
                    ResetTypeAssignment(e); // the rest of type checking assumes actual types
                }

            }
            else if (expr is ExprDotName)
            {
                var e = (ExprDotName)expr;
                ResolveDotSuffix(e, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(34L, true), null, resolutionContext, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(35L, false));
                if (e.PreType is PreTypePlaceholderModule)
                {
                    ReportError(e.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(36L, "name of module ({0}) is used as a variable"), e.SuffixName);
                    ResetTypeAssignment(e);  // the rest of type checking assumes actual types
                }
                else if (e.PreType is PreTypePlaceholderType)
                {
                    ReportError(e.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(37L, "name of type ({0}) is used as a variable"), e.SuffixName);
                    ResetTypeAssignment(e);  // the rest of type checking assumes actual types
                }

            }
            else if (expr is ApplySuffix applySuffix)
            {
                ResolveApplySuffix(applySuffix, resolutionContext, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(38L, false));

            }
            else if (expr is MemberSelectExpr)
            {
                var e = (MemberSelectExpr)expr;
                Contract.Assert(false); // this case is always handled by ResolveExprDotCall

            }
            else if (expr is SeqSelectExpr)
            {
                var e = (SeqSelectExpr)expr;

                ResolveExpression(e.Seq, resolutionContext);
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_5(39L, e.E0, null))
                {
                    ResolveExpression(e.E0, resolutionContext);
                }
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_5(40L, e.E1, null))
                {
                    ResolveExpression(e.E1, resolutionContext);
                }

                if (e.SelectOne)
                {
                    Contract.Assert(e.E0 != null);
                    Contract.Assert(e.E1 == null);
                    e.PreType = ResolveSingleSelectionExpr(e.tok, e.Seq.PreType, e.E0);
                }
                else
                {
                    ResolveRangeSelectionExpr(e.tok, e.Seq.PreType, e, e.E0, e.E1);
                }

            }
            else if (expr is MultiSelectExpr)
            {
                var e = (MultiSelectExpr)expr;

                ResolveExpression(e.Array, resolutionContext);
                var elementPreType = CreatePreTypeProxy(MutateCSharp.Schemata423.ReplaceStringConstant_1(41L, "multi-dim array select"));
                var arrayPreType = BuiltInArrayType(e.Indices.Count, elementPreType);
                AddSubtypeConstraint(arrayPreType, e.Array.PreType, e.Array.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(42L, "array selection requires an {0} (got {1})"));
                int i = MutateCSharp.Schemata423.ReplaceNumericConstant_6(43L, 0);
                foreach (var indexExpression in e.Indices)
                {
                    ResolveExpression(indexExpression, resolutionContext);
                    ConstrainToIntFamilyOrBitvector(indexExpression.PreType, indexExpression.tok,
          MutateCSharp.Schemata423.ReplaceStringConstant_1(47L, "array selection requires integer- or bitvector-based numeric indices (got {0} for index ") + i + MutateCSharp.Schemata423.ReplaceStringConstant_1(48L, ")"));
                    MutateCSharp.Schemata423.ReplacePostfixUnaryExprOp_7(49L, ref i);
                }
                e.PreType = elementPreType;

            }
            else if (expr is SeqUpdateExpr)
            {
                var e = (SeqUpdateExpr)expr;
                ResolveExpression(e.Seq, resolutionContext);
                ResolveExpression(e.Index, resolutionContext);
                ResolveExpression(e.Value, resolutionContext);
                Constraints.AddGuardedConstraint(() =>
                {
                    var sourcePreType = e.Seq.PreType.NormalizeWrtScope() as DPreType;
                    var ancestorPreType = MutateCSharp.Schemata423.ReplaceBinExprOp_8(50L, sourcePreType, null) ? null : AncestorPreType(sourcePreType);
                    var familyDeclName = ancestorPreType?.Decl.Name;
                    if (MutateCSharp.Schemata423.ReplaceBinExprOp_9(51L, familyDeclName, PreType.TypeNameSeq))
                    {
                        var elementPreType = ancestorPreType.Arguments[MutateCSharp.Schemata423.ReplaceNumericConstant_6(52L, 0)];
                        ConstrainToIntFamilyOrBitvector(e.Index.PreType, e.Index.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(56L, "sequence update requires integer- or bitvector-based index (got {1})"));
                        AddSubtypeConstraint(elementPreType, e.Value.PreType, e.Value.tok,
            MutateCSharp.Schemata423.ReplaceStringConstant_1(57L, "sequence update requires the value to have the element type of the sequence (got {1})"));
                        return MutateCSharp.Schemata423.ReplaceBooleanConstant_4(58L, true);
                    }
                    else if (familyDeclName is PreType.TypeNameMap or PreType.TypeNameImap)
                    {
                        var domainPreType = ancestorPreType.Arguments[MutateCSharp.Schemata423.ReplaceNumericConstant_6(59L, 0)];
                        var rangePreType = ancestorPreType.Arguments[MutateCSharp.Schemata423.ReplaceNumericConstant_6(63L, 1)];
                        AddSubtypeConstraint(domainPreType, e.Index.PreType, e.Index.tok,
                          familyDeclName + MutateCSharp.Schemata423.ReplaceStringConstant_1(67L, " update requires domain element to be of type {0} (got {1})"));
                        AddSubtypeConstraint(rangePreType, e.Value.PreType, e.Value.tok,
                          familyDeclName + MutateCSharp.Schemata423.ReplaceStringConstant_1(68L, " update requires the value to have the range type {0} (got {1})"));
                        return MutateCSharp.Schemata423.ReplaceBooleanConstant_4(69L, true);
                    }
                    else if (MutateCSharp.Schemata423.ReplaceBinExprOp_9(70L, familyDeclName, PreType.TypeNameMultiset))
                    {
                        var elementPreType = ancestorPreType.Arguments[MutateCSharp.Schemata423.ReplaceNumericConstant_6(71L, 0)];
                        AddSubtypeConstraint(elementPreType, e.Index.PreType, e.Index.tok,
            MutateCSharp.Schemata423.ReplaceStringConstant_1(75L, "multiset update requires domain element to be of type {0} (got {1})"));
                        ConstrainToIntFamily(e.Value.PreType, e.Value.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(76L, "multiset update requires integer-based numeric value (got {0})"));
                        return MutateCSharp.Schemata423.ReplaceBooleanConstant_4(77L, true);
                    }
                    else if (familyDeclName != null)
                    {
                        ReportError(expr.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(78L, "update requires a sequence, map, or multiset (got {0})"), e.Seq.PreType);
                        return MutateCSharp.Schemata423.ReplaceBooleanConstant_4(79L, true);
                    }
                    return MutateCSharp.Schemata423.ReplaceBooleanConstant_4(80L, false);
                });
                expr.PreType = e.Seq.PreType;

            }
            else if (expr is DatatypeUpdateExpr)
            {
                var e = (DatatypeUpdateExpr)expr;
                // Resolve the root and all the updated-value expressions, since these may require lookups in the current local-variable scope
                ResolveExpression(e.Root, resolutionContext);
                expr.PreType = CreatePreTypeProxy(MutateCSharp.Schemata423.ReplaceStringConstant_1(81L, "datatype update"));
                foreach (var (_, _, updateExpr) in e.Updates)
                {
                    ResolveExpression(updateExpr, resolutionContext);
                }
                // Next, at a leisurely pace (that is, waiting until enough of the pre-type of .Root is known), resolve the update expression
                // and desugar it into some kind of nested let expression.
                Constraints.AddGuardedConstraint(() =>
                {
                    if (e.Root.PreType.NormalizeWrtScope() is DPreType tentativeRootPreType)
                    {
                        if (tentativeRootPreType.Decl is DatatypeDecl datatypeDecl)
                        {
                            var (ghostLet, compiledLet) = ResolveDatatypeUpdate(expr.tok, tentativeRootPreType, e.Root, datatypeDecl, e.Updates,
                              resolutionContext, out var members, out var legalSourceConstructors);
                            // if 'let' returns as 'null', an error has already been reported
                            if (MutateCSharp.Schemata423.ReplaceBinExprOp_5(82L, ghostLet, null))
                            {
                                e.ResolvedExpression = ghostLet;
                                e.ResolvedCompiledExpression = compiledLet;
                                e.Members = members;
                                e.LegalSourceConstructors = legalSourceConstructors;
                                Constraints.AddEqualityConstraint(expr.PreType, ghostLet.PreType, expr.tok,
                MutateCSharp.Schemata423.ReplaceStringConstant_1(83L, "result of datatype update expression of type '{1}' is used as if it were of type '{0}'"));
                                if (MutateCSharp.Schemata423.ReplaceBinExprOp_10(84L, ghostLet, compiledLet))
                                {
                                    Constraints.AddEqualityConstraint(expr.PreType, compiledLet.PreType, expr.tok,
                  MutateCSharp.Schemata423.ReplaceStringConstant_1(85L, "result of datatype update expression of type '{1}' is used as if it were of type '{0}'"));
                                }
                            }
                        }
                        else
                        {
                            ReportError(expr, MutateCSharp.Schemata423.ReplaceStringConstant_1(86L, "datatype update expression requires a root expression of a datatype (got {0})"), tentativeRootPreType);
                        }
                        return MutateCSharp.Schemata423.ReplaceBooleanConstant_4(87L, true);
                    }
                    return MutateCSharp.Schemata423.ReplaceBooleanConstant_4(88L, false);
                });

            }
            else if (expr is FunctionCallExpr)
            {
                Contract.Assert(false); // this case is always handled by ResolveExprDotCall

            }
            else if (expr is ApplyExpr)
            {
                var e = (ApplyExpr)expr;
                ResolveExpression(e.Function, resolutionContext);
                foreach (var arg in e.Args)
                {
                    ResolveExpression(arg, resolutionContext);
                }
                expr.PreType = CreatePreTypeProxy(MutateCSharp.Schemata423.ReplaceStringConstant_1(89L, "apply expression result"));

                Constraints.AddGuardedConstraint(() =>
                {
                    if (e.Function.PreType.NormalizeWrtScope() is DPreType dp)
                    {
                        if (!DPreType.IsArrowType(dp.Decl))
                        {
                            ReportError(e.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(90L, "non-function expression (of type {0}) is called with parameters"), e.Function.PreType);
                        }
                        else
                        {
                            var arity = MutateCSharp.Schemata423.ReplaceBinExprOp_11(95L, dp.Decl.TypeArgs.Count, MutateCSharp.Schemata423.ReplaceNumericConstant_6(91L, 1));
                            if (MutateCSharp.Schemata423.ReplaceBinExprOp_12(104L, arity, e.Args.Count))
                            {
                                ReportError(e.tok,
                MutateCSharp.Schemata423.ReplaceStringConstant_1(109L, "wrong number of arguments to function application (function type '{0}' expects {1}, got {2})"), e.Function.PreType,
                                  arity, e.Args.Count);
                            }
                            else
                            {
                                for (var i = MutateCSharp.Schemata423.ReplaceNumericConstant_6(110L, 0); MutateCSharp.Schemata423.ReplaceBinExprOp_13(114L, i, arity); MutateCSharp.Schemata423.ReplacePostfixUnaryExprOp_7(119L, ref i))
                                {
                                    AddSubtypeConstraint(dp.Arguments[i], e.Args[i].PreType, e.Args[i].tok,
                  MutateCSharp.Schemata423.ReplaceStringConstant_1(120L, "type mismatch for argument") + (MutateCSharp.Schemata423.ReplaceBinExprOp_14(125L, arity, MutateCSharp.Schemata423.ReplaceNumericConstant_6(121L, 1)) ? "" : MutateCSharp.Schemata423.ReplaceStringConstant_1(130L, " ") + i) + MutateCSharp.Schemata423.ReplaceStringConstant_1(131L, " (function expects {0}, got {1})"));
                                }
                                AddSubtypeConstraint(expr.PreType, dp.Arguments[arity], expr.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(132L, "function result '{1}' used as if it had type '{0}'"));
                            }
                        }
                        return MutateCSharp.Schemata423.ReplaceBooleanConstant_4(133L, true);
                    }
                    return MutateCSharp.Schemata423.ReplaceBooleanConstant_4(134L, false);
                });

            }
            else if (expr is SeqConstructionExpr)
            {
                var e = (SeqConstructionExpr)expr;
                var elementType = e.ExplicitElementType ?? new InferredTypeProxy();
                resolver.ResolveType(e.tok, elementType, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                var elementPreType = Type2PreType(elementType);
                ResolveExpression(e.N, resolutionContext);
                ConstrainToIntFamily(e.N.PreType, e.N.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(135L, "sequence construction must use an integer-based expression for the sequence size (got {0})"));
                ResolveExpression(e.Initializer, resolutionContext);
                var intPreType = Type2PreType(resolver.SystemModuleManager.Nat());
                var arrowPreType = new DPreType(BuiltInArrowTypeDecl(MutateCSharp.Schemata423.ReplaceNumericConstant_6(136L, 1)), new List<PreType>() { intPreType, elementPreType });
                Constraints.AddSubtypeConstraint(arrowPreType, e.Initializer.PreType, e.Initializer.tok,
                  () =>
                  {
                      var strFormat = MutateCSharp.Schemata423.ReplaceStringConstant_1(140L, "sequence-construction initializer expression expected to have type '{0}' (instead got '{1}')");
                      if (PreType.Same(elementPreType, e.Initializer.PreType))
                      {
                          var hintString = MutateCSharp.Schemata423.ReplaceStringConstant_1(141L, " (perhaps write '_ =>' in front of the expression you gave in order to make it an arrow type)");
                          strFormat += hintString;
                      }
                      return strFormat;
                  });
                ResolveCollectionProducingExpr(PreType.TypeNameSeq, MutateCSharp.Schemata423.ReplaceStringConstant_1(142L, "constructor"), expr, elementPreType, PreTypeConstraints.CommonConfirmationBag.InSeqFamily);

            }
            else if (expr is MultiSetFormingExpr)
            {
                var e = (MultiSetFormingExpr)expr;
                ResolveExpression(e.E, resolutionContext);
                var targetElementPreType = CreatePreTypeProxy(MutateCSharp.Schemata423.ReplaceStringConstant_1(143L, "multiset conversion element type"));
                Constraints.AddGuardedConstraint(() =>
                {
                    if (e.E.PreType.NormalizeWrtScope() is DPreType dp)
                    {
                        var familyDeclName = AncestorName(dp);
                        if (familyDeclName is PreType.TypeNameSet or PreType.TypeNameSeq)
                        {
                            var ancestorPreType = AncestorPreType(dp);
                            Contract.Assert(ancestorPreType.Arguments.Count == 1);
                            var sourceElementPreType = ancestorPreType.Arguments[MutateCSharp.Schemata423.ReplaceNumericConstant_6(144L, 0)];
                            AddSubtypeConstraint(targetElementPreType, sourceElementPreType, e.E.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(148L, "expecting element type {0} (got {1})"));
                        }
                        else
                        {
                            ReportError(e.E.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(149L, "can only form a multiset from a seq or set (got {0})"), e.E.PreType);
                        }
                        return MutateCSharp.Schemata423.ReplaceBooleanConstant_4(150L, true);
                    }
                    return MutateCSharp.Schemata423.ReplaceBooleanConstant_4(151L, false);
                });
                ResolveCollectionProducingExpr(PreType.TypeNameMultiset, MutateCSharp.Schemata423.ReplaceStringConstant_1(152L, "conversion"), expr, targetElementPreType,
                  PreTypeConstraints.CommonConfirmationBag.InMultisetFamily);

            }
            else if (expr is OldExpr)
            {
                var e = (OldExpr)expr;
                e.AtLabel = ResolveDominatingLabelInExpr(expr.tok, e.At, MutateCSharp.Schemata423.ReplaceStringConstant_1(153L, "old"), resolutionContext);
                ResolveExpression(e.E, new ResolutionContext(resolutionContext.CodeContext, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(154L, false)) with { InOld = MutateCSharp.Schemata423.ReplaceBooleanConstant_4(155L, true) });
                expr.PreType = e.E.PreType;

            }
            else if (expr is UnchangedExpr)
            {
                var e = (UnchangedExpr)expr;
                e.AtLabel = ResolveDominatingLabelInExpr(expr.tok, e.At, MutateCSharp.Schemata423.ReplaceStringConstant_1(156L, "unchanged"), resolutionContext);
                foreach (var fe in e.Frame)
                {
                    ResolveFrameExpression(fe, FrameExpressionUse.Unchanged, resolutionContext.CodeContext);
                }
                ConstrainTypeExprBool(e, MutateCSharp.Schemata423.ReplaceStringConstant_1(157L, "result of 'unchanged' is boolean, but is used as if it had type {0}"));

            }
            else if (expr is FreshExpr)
            {
                var e = (FreshExpr)expr;
                ResolveExpression(e.E, resolutionContext);
                e.AtLabel = ResolveDominatingLabelInExpr(expr.tok, e.At, MutateCSharp.Schemata423.ReplaceStringConstant_1(158L, "fresh"), resolutionContext);
                // the type of e.E must be either an object or a set/seq of objects
                AddConfirmation(PreTypeConstraints.CommonConfirmationBag.Freshable, e.E.PreType, e.E.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(159L, "the argument of a fresh expression must denote an object or a set or sequence of objects (instead got {0})"));
                ConstrainTypeExprBool(e, MutateCSharp.Schemata423.ReplaceStringConstant_1(160L, "result of 'fresh' is boolean, but is used as if it had type {0}"));

            }
            else if (expr is UnaryOpExpr)
            {
                var e = (UnaryOpExpr)expr;
                ResolveExpression(e.E, resolutionContext);
                switch (e.Op)
                {
                    case UnaryOpExpr.Opcode.Not:
                        AddConfirmation(PreTypeConstraints.CommonConfirmationBag.BooleanBits, e.E.PreType, expr.tok, "logical/bitwise negation expects a boolean or bitvector argument (instead got {0})");
                        expr.PreType = e.E.PreType;
                        Constraints.AddDefaultAdvice(e.PreType, CommonAdvice.Target.Bool);
                        break;
                        break;
                    case UnaryOpExpr.Opcode.Cardinality:
                        AddConfirmation(PreTypeConstraints.CommonConfirmationBag.Sizeable, e.E.PreType, expr.tok, "size operator expects a collection argument (instead got {0})");
                        expr.PreType = CreatePreTypeProxy("cardinality");
                        ConstrainToIntFamily(expr.PreType, expr.tok, "integer literal used as if it had type {0}");
                        break;
                        break;
                    case UnaryOpExpr.Opcode.Allocated:
                        // the argument is allowed to have any type at all
                        expr.PreType = ConstrainResultToBoolFamily(expr.tok, "allocated", "boolean literal used as if it had type {0}");
                        if ((resolutionContext.CodeContext is Function && !resolutionContext.InOld) ||
                            resolutionContext.CodeContext is ConstantField ||
                            CodeContextWrapper.Unwrap(resolutionContext.CodeContext) is RedirectingTypeDecl)
                        {
                            var declKind = CodeContextWrapper.Unwrap(resolutionContext.CodeContext) is RedirectingTypeDecl redir
                              ? redir.WhatKind
                              : ((MemberDecl)resolutionContext.CodeContext).WhatKind;
                            ReportError(expr, "a {0} definition is not allowed to depend on the set of allocated references", declKind);
                        }
                        break;
                        break;
                    default:
                        Contract.Assert(false); throw new cce.UnreachableException();  // unexpected unary operator
                        break;
                }

            }
            else if (expr is ConversionExpr)
            {
                var e = (ConversionExpr)expr;
                ResolveExpression(e.E, resolutionContext);
                var prevErrorCount = ErrorCount;
                resolver.ResolveType(e.tok, e.ToType, resolutionContext, new ModuleResolver.ResolveTypeOption(ResolveTypeOptionEnum.InferTypeProxies), null);
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_14(161L, ErrorCount, prevErrorCount))
                {
                    string errorMessageFormat;
                    var toPreType = (DPreType)Type2PreType(e.ToType);
                    var ancestorDecl = AncestorDecl(toPreType.Decl);
                    var familyDeclName = ancestorDecl.Name;
                    if (MutateCSharp.Schemata423.ReplaceBinExprOp_9(166L, familyDeclName, PreType.TypeNameInt))
                    {
                        errorMessageFormat = MutateCSharp.Schemata423.ReplaceStringConstant_1(167L, "type conversion to an int-based type is allowed only from numeric and bitvector types, char, and ORDINAL (got {1})");
                    }
                    else if (MutateCSharp.Schemata423.ReplaceBinExprOp_9(168L, familyDeclName, PreType.TypeNameReal))
                    {
                        errorMessageFormat = MutateCSharp.Schemata423.ReplaceStringConstant_1(169L, "type conversion to a real-based type is allowed only from numeric and bitvector types, char, and ORDINAL (got {1})");
                    }
                    else if (IsBitvectorName(familyDeclName))
                    {
                        errorMessageFormat = MutateCSharp.Schemata423.ReplaceStringConstant_1(170L, "type conversion to a bitvector-based type is allowed only from numeric and bitvector types, char, and ORDINAL (got {1})");
                    }
                    else if (MutateCSharp.Schemata423.ReplaceBinExprOp_9(171L, familyDeclName, PreType.TypeNameChar))
                    {
                        errorMessageFormat = MutateCSharp.Schemata423.ReplaceStringConstant_1(172L, "type conversion to a char type is allowed only from numeric and bitvector types, char, and ORDINAL (got {1})");
                    }
                    else if (MutateCSharp.Schemata423.ReplaceBinExprOp_9(173L, familyDeclName, PreType.TypeNameORDINAL))
                    {
                        errorMessageFormat = MutateCSharp.Schemata423.ReplaceStringConstant_1(174L, "type conversion to an ORDINAL type is allowed only from numeric and bitvector types, char, and ORDINAL (got {1})");
                    }
                    else if (DPreType.IsReferenceTypeDecl(ancestorDecl))
                    {
                        errorMessageFormat = MutateCSharp.Schemata423.ReplaceStringConstant_1(175L, "type cast to reference type '{0}' must be from an expression of a compatible type (got '{1}')");
                    }
                    else if (ancestorDecl is TraitDecl)
                    {
                        errorMessageFormat = MutateCSharp.Schemata423.ReplaceStringConstant_1(176L, "type cast to trait type '{0}' must be from an expression of a compatible type (got '{1}')");
                    }
                    else
                    {
                        errorMessageFormat = MutateCSharp.Schemata423.ReplaceStringConstant_1(177L, "type cast to type '{0}' must be from an expression of a compatible type (got '{1}')");
                    }
                    AddComparableConstraint(toPreType, e.E.PreType, expr.tok, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(178L, true), errorMessageFormat);
                    e.PreType = toPreType;
                }
                else
                {
                    e.PreType = CreatePreTypeProxy(MutateCSharp.Schemata423.ReplaceStringConstant_1(179L, "'as' target type"));
                }

            }
            else if (expr is TypeTestExpr)
            {
                var e = (TypeTestExpr)expr;
                ResolveExpression(e.E, resolutionContext);
                expr.PreType = ConstrainResultToBoolFamilyOperator(expr.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(180L, "is"));
                resolver.ResolveType(e.tok, e.ToType, resolutionContext, new ModuleResolver.ResolveTypeOption(ResolveTypeOptionEnum.InferTypeProxies), null);
                var toPreType = Type2PreType(e.ToType);
                AddComparableConstraint(toPreType, e.E.PreType, expr.tok, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(181L, true),
        MutateCSharp.Schemata423.ReplaceStringConstant_1(182L, "type test for type '{0}' must be from an expression assignable to it (got '{1}')"));

            }
            else if (expr is BinaryExpr)
            {
                var e = (BinaryExpr)expr;
                ResolveExpression(e.E0, resolutionContext);
                ResolveExpression(e.E1, resolutionContext);
                expr.PreType = ResolveBinaryExpr(e.tok, e.Op, e.E0, e.E1, resolutionContext);

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
                        expr.PreType = ConstrainResultToBoolFamily(expr.tok, "ternary op", "boolean literal used as if it had type {0}");
                        AddConfirmation(PreTypeConstraints.CommonConfirmationBag.IntOrORDINAL, e.E0.PreType, expr.tok, "prefix-equality limit argument must be an ORDINAL or integer expression (got {0})");
                        AddComparableConstraint(e.E1.PreType, e.E2.PreType, expr.tok, false,
                          "arguments must have the same type (got {0} and {1})");
                        AddConfirmation(PreTypeConstraints.CommonConfirmationBag.IsCoDatatype, e.E1.PreType, expr.tok, "arguments to prefix equality must be codatatypes (instead of {0})");
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
                    foreach (var bv in e.BoundVars)
                    {
                        int prevErrorCount = ErrorCount;
                        resolver.ResolveType(bv.Tok, bv.Type, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                        bv.PreType = Type2PreType(bv.Type);
                    }
                    foreach (var rhs in e.RHSs)
                    {
                        ResolveExpression(rhs, resolutionContext);
                    }
                    scope.PushMarker();
                    if (MutateCSharp.Schemata423.ReplaceBinExprOp_12(183L, e.LHSs.Count, e.RHSs.Count))
                    {
                        ReportError(expr, MutateCSharp.Schemata423.ReplaceStringConstant_1(188L, "let expression must have same number of LHSs (found {0}) as RHSs (found {1})"), e.LHSs.Count, e.RHSs.Count);
                    }
                    var i = MutateCSharp.Schemata423.ReplaceNumericConstant_6(189L, 0);
                    foreach (var lhs in e.LHSs)
                    {
                        var rhsPreType = MutateCSharp.Schemata423.ReplaceBinExprOp_13(193L, i, e.RHSs.Count) ? e.RHSs[i].PreType : CreatePreTypeProxy(MutateCSharp.Schemata423.ReplaceStringConstant_1(198L, "let RHS"));
                        ResolveCasePattern(lhs, rhsPreType, resolutionContext);
                        // Check for duplicate names now, because not until after resolving the case pattern do we know if identifiers inside it refer to bound variables or nullary constructors
                        var c = MutateCSharp.Schemata423.ReplaceNumericConstant_6(199L, 0);
                        foreach (var v in lhs.Vars)
                        {
                            ScopePushAndReport(v, MutateCSharp.Schemata423.ReplaceStringConstant_1(203L, "let-variable"), MutateCSharp.Schemata423.ReplaceBooleanConstant_4(204L, false)); // .PreType's already assigned by ResolveCasePattern
                            MutateCSharp.Schemata423.ReplacePostfixUnaryExprOp_7(205L, ref c);
                        }
                        if (MutateCSharp.Schemata423.ReplaceBinExprOp_14(210L, c, MutateCSharp.Schemata423.ReplaceNumericConstant_6(206L, 0)))
                        {
                            // Every identifier-looking thing in the pattern resolved to a constructor; that is, this LHS is a constant literal
                            ReportError(lhs.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(215L, "LHS is a constant literal; to be legal, it must introduce at least one bound variable"));
                        }

                        MutateCSharp.Schemata423.ReplacePostfixUnaryExprOp_7(216L, ref i);
                    }
                }
                else
                {
                    // let-such-that expression
                    if (MutateCSharp.Schemata423.ReplaceBinExprOp_12(221L, e.RHSs.Count, MutateCSharp.Schemata423.ReplaceNumericConstant_6(217L, 1)))
                    {
                        ReportError(expr, MutateCSharp.Schemata423.ReplaceStringConstant_1(226L, "let-such-that expression must have just one RHS (found {0})"), e.RHSs.Count);
                    }
                    // the bound variables are in scope in the RHS of a let-such-that expression
                    scope.PushMarker();
                    foreach (var lhs in e.LHSs)
                    {
                        Contract.Assert(lhs.Var != null);  // the parser already checked that every LHS is a BoundVar, not a general pattern
                        var v = lhs.Var;
                        resolver.ResolveType(v.tok, v.Type, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                        v.PreType = Type2PreType(v.Type);
                        ScopePushAndReport(v, MutateCSharp.Schemata423.ReplaceStringConstant_1(227L, "let-variable"), MutateCSharp.Schemata423.ReplaceBooleanConstant_4(228L, false));
                        lhs.AssembleExprPreType(null);
                    }
                    foreach (var rhs in e.RHSs)
                    {
                        ResolveExpression(rhs, resolutionContext);
                        ConstrainExpressionToBoolFamily(rhs, MutateCSharp.Schemata423.ReplaceStringConstant_1(229L, "type of RHS of let-such-that expression must be boolean (got {0})"));
                    }
                }
                ResolveExpression(e.Body, resolutionContext);
                ResolveAttributes(e, resolutionContext, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(230L, false));
                scope.PopMarker();
                expr.PreType = e.Body.PreType;

            }
            else if (expr is LetOrFailExpr)
            {
                var e = (LetOrFailExpr)expr;
                e.ResolvedExpression = DesugarElephantExpr(e, resolutionContext);
                ResolveExpression(e.ResolvedExpression, resolutionContext);
                e.PreType = e.ResolvedExpression.PreType;
                Constraints.AddGuardedConstraint(() =>
                {
                    if (e.Rhs.PreType.NormalizeWrtScope() is DPreType receiverPreType)
                    {
                        bool expectExtract = MutateCSharp.Schemata423.ReplaceBinExprOp_15(231L, e.Lhs, null);
                        EnsureSupportsErrorHandling(e.tok, receiverPreType, expectExtract, resolutionContext, null);
                        return MutateCSharp.Schemata423.ReplaceBooleanConstant_4(232L, true);
                    }
                    return MutateCSharp.Schemata423.ReplaceBooleanConstant_4(233L, false);
                });

            }
            else if (expr is QuantifierExpr)
            {
                var e = (QuantifierExpr)expr;
                if (resolutionContext.CodeContext is Function enclosingFunction)
                {
                    enclosingFunction.ContainsQuantifier = MutateCSharp.Schemata423.ReplaceBooleanConstant_4(234L, true);
                }
                Contract.Assert(e.SplitQuantifier == null); // No split quantifiers during resolution
                scope.PushMarker();
                foreach (var v in e.BoundVars)
                {
                    resolver.ResolveType(v.tok, v.Type, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                    ScopePushAndReport(v, MutateCSharp.Schemata423.ReplaceStringConstant_1(235L, "bound-variable"), MutateCSharp.Schemata423.ReplaceBooleanConstant_4(236L, true));
                }
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_5(237L, e.Range, null))
                {
                    ResolveExpression(e.Range, resolutionContext);
                    ConstrainTypeExprBool(e.Range, MutateCSharp.Schemata423.ReplaceStringConstant_1(238L, "range of quantifier must be of type bool (instead got {0})"));
                }
                ResolveExpression(e.Term, resolutionContext);
                ConstrainTypeExprBool(e.Term, MutateCSharp.Schemata423.ReplaceStringConstant_1(239L, "body of quantifier must be of type bool (instead got {0})"));
                // Since the body is more likely to infer the types of the bound variables, resolve it
                // first (above) and only then resolve the attributes (below).
                ResolveAttributes(e, resolutionContext, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(240L, false));
                scope.PopMarker();
                expr.PreType = ConstrainResultToBoolFamilyOperator(expr.tok, e.WhatKind);

            }
            else if (expr is SetComprehension)
            {
                var e = (SetComprehension)expr;
                scope.PushMarker();
                foreach (var v in e.BoundVars)
                {
                    resolver.ResolveType(v.tok, v.Type, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                    ScopePushAndReport(v, MutateCSharp.Schemata423.ReplaceStringConstant_1(241L, "bound-variable"), MutateCSharp.Schemata423.ReplaceBooleanConstant_4(242L, true));
                }
                ResolveExpression(e.Range, resolutionContext);
                ConstrainTypeExprBool(e.Range, MutateCSharp.Schemata423.ReplaceStringConstant_1(243L, "range of comprehension must be of type bool (instead got {0})"));
                ResolveExpression(e.Term, resolutionContext);

                ResolveAttributes(e, resolutionContext, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(244L, false));
                scope.PopMarker();

                ResolveCollectionProducingExpr(PreType.SetTypeName(e.Finite), MutateCSharp.Schemata423.ReplaceStringConstant_1(245L, "comprehension"), expr, e.Term.PreType,
                  e.Finite ? PreTypeConstraints.CommonConfirmationBag.InSetFamily : PreTypeConstraints.CommonConfirmationBag.InIsetFamily);

            }
            else if (expr is MapComprehension)
            {
                var e = (MapComprehension)expr;
                scope.PushMarker();
                Contract.Assert(e.BoundVars.Count == 1 || (1 < e.BoundVars.Count && e.TermLeft != null));
                foreach (BoundVar v in e.BoundVars)
                {
                    resolver.ResolveType(v.tok, v.Type, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                    ScopePushAndReport(v, MutateCSharp.Schemata423.ReplaceStringConstant_1(246L, "bound-variable"), MutateCSharp.Schemata423.ReplaceBooleanConstant_4(247L, true));
                }
                ResolveExpression(e.Range, resolutionContext);
                ConstrainTypeExprBool(e.Range, MutateCSharp.Schemata423.ReplaceStringConstant_1(248L, "range of comprehension must be of type bool (instead got {0})"));
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_5(249L, e.TermLeft, null))
                {
                    ResolveExpression(e.TermLeft, resolutionContext);
                }
                ResolveExpression(e.Term, resolutionContext);

                ResolveAttributes(e, resolutionContext, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(250L, false));
                scope.PopMarker();

                ResolveMapProducingExpr(e.Finite, MutateCSharp.Schemata423.ReplaceStringConstant_1(251L, "comprehension"), expr, e.TermLeft?.PreType ?? e.BoundVars[MutateCSharp.Schemata423.ReplaceNumericConstant_6(252L, 0)].PreType, e.Term.PreType);

            }
            else if (expr is LambdaExpr)
            {
                var e = (LambdaExpr)expr;
                scope.PushMarker();
                foreach (var v in e.BoundVars)
                {
                    resolver.ResolveType(v.tok, v.Type, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                    ScopePushAndReport(v, MutateCSharp.Schemata423.ReplaceStringConstant_1(256L, "bound-variable"), MutateCSharp.Schemata423.ReplaceBooleanConstant_4(257L, true));
                }

                if (MutateCSharp.Schemata423.ReplaceBinExprOp_5(258L, e.Range, null))
                {
                    ResolveExpression(e.Range, resolutionContext);
                    ConstrainTypeExprBool(e.Range, MutateCSharp.Schemata423.ReplaceStringConstant_1(259L, "precondition must be boolean (got {0})"));
                }
                foreach (var read in e.Reads.Expressions)
                {
                    ResolveFrameExpression(read, FrameExpressionUse.Reads, resolutionContext.CodeContext);
                }
                ResolveExpression(e.Term, resolutionContext);
                scope.PopMarker();
                expr.PreType = BuiltInArrowType(e.BoundVars.ConvertAll(v => v.PreType), e.Body.PreType);

            }
            else if (expr is WildcardExpr)
            {
                var obj = new DPreType(BuiltInTypeDecl(PreType.TypeNameObjectQ), new List<PreType>() { });
                expr.PreType = new DPreType(BuiltInTypeDecl(PreType.TypeNameSet), new List<PreType>() { obj });

            }
            else if (expr is StmtExpr)
            {
                var e = (StmtExpr)expr;
                int prevErrorCount = ErrorCount;
                ResolveStatement(e.S, resolutionContext);
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_14(260L, ErrorCount, prevErrorCount))
                {
                    if (e.S is UpdateStmt updateStmt && MutateCSharp.Schemata423.ReplaceBinExprOp_14(269L, updateStmt.ResolvedStatements.Count, MutateCSharp.Schemata423.ReplaceNumericConstant_6(265L, 1)))
                    {
                        var call = (CallStmt)updateStmt.ResolvedStatements[MutateCSharp.Schemata423.ReplaceNumericConstant_6(274L, 0)];
                        if (MutateCSharp.Schemata423.ReplaceBinExprOp_16(278L, () => call.Method is TwoStateLemma, () => !resolutionContext.IsTwoState))
                        {
                            ReportError(call, MutateCSharp.Schemata423.ReplaceStringConstant_1(284L, "two-state lemmas can only be used in two-state contexts"));
                        }
                    }
                }
                ResolveExpression(e.E, resolutionContext);
                expr.PreType = e.E.PreType;

            }
            else if (expr is ITEExpr)
            {
                var e = (ITEExpr)expr;
                ResolveExpression(e.Test, resolutionContext);
                ResolveExpression(e.Thn, resolutionContext);
                ResolveExpression(e.Els, resolutionContext);
                e.Test.PreType = ConstrainResultToBoolFamily(e.Test.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(285L, "if-then-else test"), MutateCSharp.Schemata423.ReplaceStringConstant_1(286L, "guard condition in if-then-else expression must be a boolean (instead got {0})"));
                expr.PreType = CreatePreTypeProxy(MutateCSharp.Schemata423.ReplaceStringConstant_1(287L, "if-then-else branches"));
                AddSubtypeConstraint(expr.PreType, e.Thn.PreType, expr.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(288L, "the two branches of an if-then-else expression must have the same type (got {0} and {1})"));
                AddSubtypeConstraint(expr.PreType, e.Els.PreType, expr.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(289L, "the two branches of an if-then-else expression must have the same type (got {0} and {1})"));

            }
            else if (expr is NestedMatchExpr)
            {
                var e = (NestedMatchExpr)expr;
                ResolveNestedMatchExpr(e, resolutionContext);

            }
            else if (expr is MatchExpr)
            {
                Contract.Assert(false); // this case is always handled via NestedMatchExpr

            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected expression
            }

            if (MutateCSharp.Schemata423.ReplaceBinExprOp_17(290L, expr.PreType, null))
            {
                // some resolution error occurred
                expr.PreType = CreatePreTypeProxy(MutateCSharp.Schemata423.ReplaceStringConstant_1(291L, "ResolveExpression didn't compute this pre-type"));
            }
        }

        private void ResolveCollectionProducingExpr(string typeName, string exprKindSuffix, Expression expr, PreType elementPreType,
          PreTypeConstraints.CommonConfirmationBag confirmationFamily)
        {
            var exprKind = $"{typeName} {exprKindSuffix}";
            SetupCollectionProducingExpr(typeName, exprKind, expr, elementPreType);
            AddConfirmation(confirmationFamily, expr.PreType, expr.tok, $"{exprKind} used as if it had type {{0}}");
        }

        private void ResolveMapProducingExpr(bool finite, string exprKindSuffix, Expression expr, PreType keyPreType, PreType valuePreType)
        {
            var typeName = PreType.MapTypeName(finite);
            PreTypeConstraints.CommonConfirmationBag confirmationFamily =
              finite ? PreTypeConstraints.CommonConfirmationBag.InMapFamily : PreTypeConstraints.CommonConfirmationBag.InImapFamily;
            var exprKind = $"{typeName} {exprKindSuffix}";

            SetupCollectionProducingExpr(typeName, exprKind, expr, keyPreType, valuePreType);
            AddConfirmation(confirmationFamily, expr.PreType, expr.tok, $"{exprKind} used as if it had type {{0}}");
        }

        private void SetupCollectionProducingExpr(string typeName, string exprKind, Expression expr, PreType elementPreType, PreType valuePreType = null)
        {
            expr.PreType = CreatePreTypeProxy(exprKind);

            var arguments = MutateCSharp.Schemata423.ReplaceBinExprOp_17(292L, valuePreType, null) ? new List<PreType>() { elementPreType } : new List<PreType>() { elementPreType, valuePreType };
            var defaultType = new DPreType(BuiltInTypeDecl(typeName), arguments);
            Constraints.AddDefaultAdvice(expr.PreType, defaultType);

            Constraints.AddGuardedConstraint(() =>
            {
                if (expr.PreType.UrAncestor(this) is DPreType dPreType)
                {
                    if (MutateCSharp.Schemata423.ReplaceBinExprOp_18(293L, dPreType.Decl.Name, typeName))
                    {
                        ReportError(expr, $"{exprKind} used as if it had type {{0}}", expr.PreType);
                    }
                    else if (MutateCSharp.Schemata423.ReplaceBinExprOp_17(294L, valuePreType, null))
                    {
                        AddSubtypeConstraint(dPreType.Arguments[MutateCSharp.Schemata423.ReplaceNumericConstant_6(295L, 0)], elementPreType, expr.tok,
                          $"element type of {exprKind} expected to be {{0}} (got {{1}})");
                    }
                    else
                    {
                        AddSubtypeConstraint(dPreType.Arguments[MutateCSharp.Schemata423.ReplaceNumericConstant_6(299L, 0)], elementPreType, expr.tok,
                          $"key type of {exprKind} expected to be {{0}} (got {{1}})");
                        AddSubtypeConstraint(dPreType.Arguments[MutateCSharp.Schemata423.ReplaceNumericConstant_6(303L, 1)], valuePreType, expr.tok,
                          $"value type of {exprKind} expected to be {{0}} (got {{1}})");
                    }
                    return MutateCSharp.Schemata423.ReplaceBooleanConstant_4(307L, true);
                }
                return MutateCSharp.Schemata423.ReplaceBooleanConstant_4(308L, false);
            });
        }

        private PreType ResolveBinaryExpr(IToken tok, BinaryExpr.Opcode opcode, Expression e0, Expression e1, ResolutionContext resolutionContext)
        {
            var opString = BinaryExpr.OpcodeString(opcode);
            PreType resultPreType;
            switch (opcode)
            {
                case BinaryExpr.Opcode.Iff:
                case BinaryExpr.Opcode.Imp:
                case BinaryExpr.Opcode.Exp:
                case BinaryExpr.Opcode.And:
                case BinaryExpr.Opcode.Or:
                    {
                        resultPreType = ConstrainResultToBoolFamilyOperator(tok, opString);
                        ConstrainOperandTypes(tok, opString, e0, e1, resultPreType);
                        break;
                    }

                    break;
                case BinaryExpr.Opcode.Eq:
                case BinaryExpr.Opcode.Neq:
                    resultPreType = ConstrainResultToBoolFamilyOperator(tok, opString);
                    AddComparableConstraint(e0.PreType, e1.PreType, tok, false, "arguments must have comparable types (got {0} and {1})");
                    break;
                    break;
                case BinaryExpr.Opcode.Disjoint:
                    resultPreType = ConstrainResultToBoolFamilyOperator(tok, opString);
                    ConstrainToCommonSupertype(tok, opString, e0.PreType, e1.PreType, null);
                    AddConfirmation(PreTypeConstraints.CommonConfirmationBag.Disjointable, e0.PreType, tok, "arguments must be of a set or multiset type (got {0})");
                    break;
                    break;
                case BinaryExpr.Opcode.Lt:
                    resultPreType = ConstrainResultToBoolFamilyOperator(tok, opString);
                    Constraints.AddGuardedConstraint(() =>
                    {
                        var left = e0.PreType.NormalizeWrtScope() as DPreType;
                        var right = e1.PreType.NormalizeWrtScope() as DPreType;
                        if (left is { Decl: IndDatatypeDecl or TypeParameter })
                        {
                            AddConfirmation(PreTypeConstraints.CommonConfirmationBag.RankOrderable, e1.PreType, tok,
                              $"arguments to rank comparison must be datatypes (got {e0.PreType} and {{0}})");
                            return true;
                        }
                        else if (right is { Decl: IndDatatypeDecl })
                        {
                            AddConfirmation(PreTypeConstraints.CommonConfirmationBag.RankOrderableOrTypeParameter, e0.PreType, tok,
                              $"arguments to rank comparison must be datatypes (got {{0}} and {e1.PreType})");
                            return true;
                        }
                        else if (left != null || right != null)
                        {
                            var commonSupertype = CreatePreTypeProxy("common supertype of < operands");
                            ConstrainToCommonSupertype(tok, opString, e0.PreType, e1.PreType, commonSupertype);
                            AddConfirmation(PreTypeConstraints.CommonConfirmationBag.OrderableLess, e0.PreType, tok,
                              "arguments to " + opString +
                              " must be of a numeric type, bitvector type, ORDINAL, char, a sequence type, or a set-like type (instead got {0})");
                            return true;
                        }
                        return false;
                    });
                    break;
                    break;
                case BinaryExpr.Opcode.Le:
                    resultPreType = ConstrainResultToBoolFamilyOperator(tok, opString);
                    ConstrainToCommonSupertype(tok, opString, e0.PreType, e1.PreType, null);
                    AddConfirmation(PreTypeConstraints.CommonConfirmationBag.OrderableLess, e0.PreType, tok,
                      "arguments to " + opString +
                      " must be of a numeric type, bitvector type, ORDINAL, char, a sequence type, or a set-like type (instead got {0})");
                    break;
                    break;
                case BinaryExpr.Opcode.Gt:
                    resultPreType = ConstrainResultToBoolFamilyOperator(tok, opString);
                    Constraints.AddGuardedConstraint(() =>
                    {
                        var left = e0.PreType.NormalizeWrtScope() as DPreType;
                        var right = e1.PreType.NormalizeWrtScope() as DPreType;
                        if (left != null && left.Decl is IndDatatypeDecl)
                        {
                            AddConfirmation(PreTypeConstraints.CommonConfirmationBag.RankOrderableOrTypeParameter, e1.PreType, tok,
                              $"arguments to rank comparison must be datatypes (got {e0.PreType} and {{0}})");
                            return true;
                        }
                        else if (right != null && (right.Decl is IndDatatypeDecl || right.Decl is TypeParameter))
                        {
                            AddConfirmation(PreTypeConstraints.CommonConfirmationBag.RankOrderable, e0.PreType, tok,
                              $"arguments to rank comparison must be datatypes (got {{0}} and {e1.PreType})");
                            return true;
                        }
                        else if (left != null || right != null)
                        {
                            var commonSupertype = CreatePreTypeProxy("common supertype of < operands");
                            ConstrainToCommonSupertype(tok, opString, e0.PreType, e1.PreType, commonSupertype);
                            AddConfirmation(PreTypeConstraints.CommonConfirmationBag.OrderableGreater, e0.PreType, tok,
                              "arguments to " + opString + " must be of a numeric type, bitvector type, ORDINAL, char, or a set-like type (instead got {0})");
                            return true;
                        }
                        return false;
                    });
                    break;
                    break;
                case BinaryExpr.Opcode.Ge:
                    resultPreType = ConstrainResultToBoolFamilyOperator(tok, opString);
                    ConstrainToCommonSupertype(tok, opString, e0.PreType, e1.PreType, null);
                    AddConfirmation(PreTypeConstraints.CommonConfirmationBag.OrderableGreater, e0.PreType, tok,
                      "arguments to " + opString + " must be of a numeric type, bitvector type, ORDINAL, char, or a set-like type (instead got {0})");
                    break;
                    break;
                case BinaryExpr.Opcode.Add:
                    resultPreType = CreatePreTypeProxy("result of +");
                    AddConfirmation(PreTypeConstraints.CommonConfirmationBag.Plussable, resultPreType, tok,
                      "type of + must be of a numeric type, a bitvector type, ORDINAL, char, a sequence type, or a set-like or map-like type (instead got {0})");
                    ConstrainOperandTypes(tok, opString, e0, e1, resultPreType);
                    break;
                    break;
                case BinaryExpr.Opcode.Sub:
                    resultPreType = CreatePreTypeProxy("result of -");
                    Constraints.AddGuardedConstraint(() =>
                    {
                        // The following cases are allowed:
                        // Uniform cases:
                        //   - int int
                        //   - real real
                        //   - bv bv
                        //   - ORDINAL ORDINAL
                        //   - char char
                        //   - set<T> set<V>
                        //   - iset<T> iset<V>
                        //   - multiset<T> multiset<T>
                        // Non-uniform cases:
                        //   - map<T, U> set<V>
                        //   - imap<T, U> set<V>
                        //
                        // The tests below distinguish between the uniform and non-uniform cases, but otherwise may allow some cases
                        // that are not included above. The after the enclosing call to AddGuardedConstraint will arrange to confirm
                        // that only the expected types are allowed.
                        var a0 = e0.PreType;
                        var a1 = e1.PreType;
                        var familyDeclNameLeft = AncestorName(a0);
                        var familyDeclNameRight = AncestorName(a1);
                        if (familyDeclNameLeft is PreType.TypeNameMap or PreType.TypeNameImap)
                        {
                            var left = (DPreType)a0.UrAncestor(this);
                            Contract.Assert(left.Arguments.Count == 2);
                            var st = new DPreType(BuiltInTypeDecl(PreType.TypeNameSet), new List<PreType>() { left.Arguments[0] });
                            Constraints.DebugPrint($"    DEBUG: guard applies: Minusable {a0} {a1}, converting to {st} :> {a1}");
                            Constraints.AddDefaultAdvice(a1, st);

                            var messageFormat = $"map subtraction expects right-hand operand to have type {st} (instead got {{0}})";
                            Constraints.AddGuardedConstraint(() =>
                            {
                                if (a1.UrAncestor(this) is DPreType dPreType)
                                {
                                    if (dPreType.Decl.Name != PreType.TypeNameSet)
                                    {
                                        ReportError(e1, messageFormat, a1);
                                    }
                                    else
                                    {
                                        AddSubtypeConstraint(dPreType.Arguments[0], left.Arguments[0], e1.tok,
                                          $"element type of {PreType.TypeNameSet} expected to be {{0}} (got {{1}})");
                                    }
                                    return true;
                                }
                                return false;
                            });
                            AddConfirmation(PreTypeConstraints.CommonConfirmationBag.InSetFamily, a1, e1.tok, messageFormat);
                            return true;
                        }
                        else if (familyDeclNameLeft != null || (familyDeclNameRight != null && familyDeclNameRight != PreType.TypeNameSet))
                        {
                            Constraints.DebugPrint($"    DEBUG: guard applies: Minusable {a0} {a1}, converting to {a0} :> {a1}");
                            AddSubtypeConstraint(a0, a1, tok, "type of right argument to - ({0}) must agree with the result type ({1})");
                            return true;
                        }
                        return false;
                    });
                    ConstrainOperandTypes(tok, opString, e0, null, resultPreType);
                    AddConfirmation(PreTypeConstraints.CommonConfirmationBag.Minusable, resultPreType, tok,
                      "type of - must be of a numeric type, a bitvector type, ORDINAL, char, or a set-like or map-like type (instead got {0})");
                    break;
                    break;
                case BinaryExpr.Opcode.Mul:
                    resultPreType = CreatePreTypeProxy("result of *");
                    AddConfirmation(PreTypeConstraints.CommonConfirmationBag.Mullable, resultPreType, tok,
                      "type of * must be of a numeric type, bitvector type, or a set-like type (instead got {0})");
                    ConstrainOperandTypes(tok, opString, e0, e1, resultPreType);
                    break;
                    break;
                case BinaryExpr.Opcode.In:
                case BinaryExpr.Opcode.NotIn:
                    resultPreType = ConstrainResultToBoolFamilyOperator(tok, "'" + opString + "'");
                    Constraints.AddGuardedConstraint(() =>
                    {
                        // For "Innable x s", if s is known, then:
                        // if s == c<a> or s == c<a, b> where c is a collection type, then a ~~ x, else error.
                        var a0 = e0.PreType.NormalizeWrtScope();
                        var a1 = e1.PreType.NormalizeWrtScope();
                        var coll = a1.UrAncestor(this).AsCollectionPreType();
                        if (coll != null)
                        {
                            Constraints.DebugPrint($"    DEBUG: guard applies: Innable {a0} {a1}");
                            AddComparableConstraint(coll.Arguments[0], a0, tok, false, "expecting element type to be assignable to {0} (got {1})");
                            return true;
                        }
                        else if (a1 is DPreType)
                        {
                            // type head is determined and it isn't a collection type
                            ReportError(tok,
                              $"second argument to '{opString}' must be a set, a multiset, " +
                              $"a sequence with elements of type {e0.PreType}, or a map with domain {e0.PreType} (instead got {e1.PreType})");
                            return true;
                        }
                        return false;
                    });
                    break;
                    break;
                case BinaryExpr.Opcode.Div:
                    resultPreType = CreatePreTypeProxy("result of / operation");
                    Constraints.AddDefaultAdvice(resultPreType, CommonAdvice.Target.Int);
                    AddConfirmation(PreTypeConstraints.CommonConfirmationBag.NumericOrBitvector, resultPreType, tok, "arguments to " + opString + " must be numeric or bitvector types (got {0})");
                    ConstrainOperandTypes(tok, opString, e0, e1, resultPreType);
                    break;
                    break;
                case BinaryExpr.Opcode.Mod:
                    resultPreType = CreatePreTypeProxy("result of % operation");
                    ConstrainToIntFamilyOrBitvector(resultPreType, tok, "type of " + opString + " must be integer-numeric or bitvector types (got {0})");
                    ConstrainOperandTypes(tok, opString, e0, e1, resultPreType);
                    break;
                    break;
                case BinaryExpr.Opcode.BitwiseAnd:
                case BinaryExpr.Opcode.BitwiseOr:
                case BinaryExpr.Opcode.BitwiseXor:
                    resultPreType = CreatePreTypeProxy("result of " + opString + " operation");
                    AddConfirmation(PreTypeConstraints.CommonConfirmationBag.IsBitvector, resultPreType, tok, "type of " + opString + " must be of a bitvector type (instead got {0})");
                    ConstrainOperandTypes(tok, opString, e0, e1, resultPreType);
                    break;
                    break;
                case BinaryExpr.Opcode.LeftShift:
                case BinaryExpr.Opcode.RightShift:
                    {
                        resultPreType = CreatePreTypeProxy("result of " + opString + " operation");
                        AddConfirmation(PreTypeConstraints.CommonConfirmationBag.IsBitvector, resultPreType, tok, "type of " + opString + " must be of a bitvector type (instead got {0})");
                        ConstrainOperandTypes(tok, opString, e0, null, resultPreType);
                        AddConfirmation(PreTypeConstraints.CommonConfirmationBag.IntLikeOrBitvector, e1.PreType, tok,
                          "type of right argument to " + opString + " ({0}) must be an integer-numeric or bitvector type");
                        break;
                    }

                    break;
                default:
                    Contract.Assert(false);
                    throw new cce.UnreachableException(); // unexpected operator
                    break;
            }
            // We should also fill in e.ResolvedOp, but we may not have enough information for that yet.  So, instead, delay
            // setting e.ResolvedOp until inside CheckTypeInference.
            return resultPreType;
        }

        public void ConstrainTypeExprBool(Expression e, string msgFormat)
        {
            Contract.Requires(e != null);
            Contract.Requires(msgFormat != null);  // may have a {0} part
            if (MutateCSharp.Schemata423.ReplaceBinExprOp_0(309L, e.PreType, null))
            {
                ConstrainExpressionToBoolFamily(e, msgFormat);
            }
            else
            {
                e.PreType = ConstrainResultToBoolFamily(e.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(310L, "<unspecified use>"), msgFormat);
            }
        }

        private PreType ConstrainResultToBoolFamilyOperator(IToken tok, string opString)
        {
            var proxyDescription = $"result of {opString} operation";
            return ConstrainResultToBoolFamily(tok, proxyDescription, MutateCSharp.Schemata423.ReplaceStringConstant_1(311L, "type of ") + opString + MutateCSharp.Schemata423.ReplaceStringConstant_1(312L, " must be a boolean (got {0})"));
        }

        private PreType ConstrainResultToBoolFamily(IToken tok, string proxyDescription, string errorFormat)
        {
            var pt = CreatePreTypeProxy(proxyDescription);
            Constraints.AddDefaultAdvice(pt, CommonAdvice.Target.Bool);
            AddConfirmation(PreTypeConstraints.CommonConfirmationBag.InBoolFamily, pt, tok, errorFormat);
            return pt;
        }

        private void ConstrainExpressionToBoolFamily(Expression expr, string errorFormat)
        {
            Contract.Assert(expr.PreType != null);
            Constraints.AddDefaultAdvice(expr.PreType, CommonAdvice.Target.Bool);
            AddConfirmation(PreTypeConstraints.CommonConfirmationBag.InBoolFamily, expr.PreType, expr.tok, errorFormat);
        }

        private void ConstrainToIntFamily(PreType preType, IToken tok, string errorFormat)
        {
            Constraints.AddDefaultAdvice(preType, CommonAdvice.Target.Int);
            AddConfirmation(PreTypeConstraints.CommonConfirmationBag.InIntFamily, preType, tok, errorFormat);
        }

        private void ConstrainToIntFamilyOrBitvector(PreType preType, IToken tok, string errorFormat)
        {
            Constraints.AddDefaultAdvice(preType, CommonAdvice.Target.Int);
            AddConfirmation(PreTypeConstraints.CommonConfirmationBag.IntLikeOrBitvector, preType, tok, errorFormat);
        }

        private void ConstrainToCommonSupertype(IToken tok, string opString, PreType a, PreType b, PreType commonSupertype)
        {
            if (MutateCSharp.Schemata423.ReplaceBinExprOp_17(313L, commonSupertype, null))
            {
                commonSupertype = CreatePreTypeProxy($"element type of common {opString} supertype");
            }
            var errorFormat = $"arguments to {opString} must have a common supertype (got {{0}} and {{1}})";
            AddSubtypeConstraint(commonSupertype, a, tok, errorFormat);
            AddSubtypeConstraint(commonSupertype, b, tok, errorFormat);
        }

        private void ConstrainOperandTypes(IToken tok, string opString, Expression e0, Expression e1, PreType resultPreType)
        {
            if (MutateCSharp.Schemata423.ReplaceBinExprOp_5(314L, e0, null))
            {
                AddSubtypeConstraint(resultPreType, e0.PreType, tok,
                  $"type of left argument to {opString} ({{1}}) must agree with the result type ({{0}})");
            }
            if (MutateCSharp.Schemata423.ReplaceBinExprOp_5(315L, e1, null))
            {
                AddSubtypeConstraint(resultPreType, e1.PreType, tok,
                  $"type of right argument to {opString} ({{1}}) must agree with the result type ({{0}})");
            }
        }

        /// <summary>
        /// Resolve "memberName" in what currently is known as "receiverPreType". If "receiverPreType" is an unresolved
        /// proxy type, try to solve enough type constraints and use heuristics to figure out which type contains
        /// "memberName" and return that enclosing type as "tentativeReceiverType". However, try not to make
        /// type-inference decisions about "receiverPreType"; instead, lay down the further constraints that need to
        /// be satisfied in order for "tentativeReceiverType" to be where "memberName" is found.
        /// Consequently, if "memberName" is found and returned as a "MemberDecl", it may still be the case that
        /// "receiverPreType" is an unresolved proxy type and that, after solving more type constraints, "receiverPreType"
        /// eventually gets set to a type more specific than "tentativeReceiverType".
        /// </summary>
        (MemberDecl /*?*/, DPreType /*?*/) FindMember(IToken tok, PreType receiverPreType, string memberName, ResolutionContext resolutionContext,
          bool reportErrorOnMissingMember = true)
        {
            Contract.Requires(tok != null);
            Contract.Requires(receiverPreType != null);
            Contract.Requires(memberName != null);

            var dReceiver = Constraints.ApproximateReceiverType(receiverPreType, memberName);
            if (MutateCSharp.Schemata423.ReplaceBinExprOp_8(316L, dReceiver, null))
            {
                ReportError(tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(317L, "type of the receiver is not fully determined at this program point"));
                return (null, null);
            }

            var receiverDecl = dReceiver.Decl;
            if (receiverDecl is TopLevelDeclWithMembers receiverDeclWithMembers)
            {
                // TODO: does this case need to do something like this?  var cd = ctype?.AsTopLevelTypeWithMembersBypassInternalSynonym;

                var members = resolver.GetClassMembers(receiverDeclWithMembers);
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_19(318L, members, null) || !members.TryGetValue(memberName, out var member))
                {
                    if (!reportErrorOnMissingMember)
                    {
                        // don't report any error
                    }
                    else if (MutateCSharp.Schemata423.ReplaceBinExprOp_9(320L, memberName, MutateCSharp.Schemata423.ReplaceStringConstant_1(319L, "_ctor")))
                    {
                        ReportError(tok, $"{receiverDecl.WhatKind} '{receiverDecl.Name}' does not have an anonymous constructor");
                    }
                    else
                    {
                        ReportMemberNotFoundError(tok, memberName, members, receiverDecl, resolutionContext);
                    }
                    return (null, null);
                }
                else if (resolver.VisibleInScope(member))
                {
                    // TODO: We should return the original "member", not an overridden member. Alternatively, we can just return "member" so that the
                    // caller can figure out the types, and then a later pass can figure out which particular "member" is intended.
                    return (member, dReceiver);
                }
            }
            if (reportErrorOnMissingMember)
            {
                ReportMemberNotFoundError(tok, memberName, null, receiverDecl, resolutionContext);
            }
            return (null, null);
        }

        private void ReportMemberNotFoundError(IToken tok, string memberName, [CanBeNull] Dictionary<string, MemberDecl> members,
          TopLevelDecl receiverDecl, ResolutionContext resolutionContext)
        {
            if (memberName.StartsWith(RevealStmt.RevealLemmaPrefix))
            {
                var nameToBeRevealed = memberName[RevealStmt.RevealLemmaPrefix.Length..];
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_19(321L, members, null))
                {
                    if (receiverDecl is TopLevelDeclWithMembers receiverDeclWithMembers)
                    {
                        // try this instead:
                        members = resolver.GetClassMembers(receiverDeclWithMembers);
                    }
                }
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_19(322L, members, null))
                {
                    ReportError(tok, $"member '{nameToBeRevealed}' does not exist in {receiverDecl.WhatKindAndName}");
                }
                else if (!members.TryGetValue(nameToBeRevealed, out var member))
                {
                    ReportError(tok, $"member '{nameToBeRevealed}' does not exist in {receiverDecl.WhatKindAndName}");
                }
                else if (member is not (ConstantField or Function))
                {
                    Contract.Assert(!member.IsOpaque);
                    ReportError(tok,
                      $"a {member.WhatKind} ('{nameToBeRevealed}') cannot be revealed; only opaque constants and functions can be revealed");
                }
                else if (!member.IsOpaque)
                {
                    ReportError(tok, $"{member.WhatKind} '{nameToBeRevealed}' cannot be revealed, because it is not opaque");
                }
                else if (member is Function { Body: null })
                {
                    ReportError(tok,
                      $"{member.WhatKind} '{nameToBeRevealed}' cannot be revealed, because it has no body in {receiverDecl.WhatKindAndName}");
                }
                else
                {
                    ReportError(tok, $"cannot reveal '{nameToBeRevealed}'");
                }
            }
            else
            {
                ReportError(tok, $"member '{memberName}' does not exist in {receiverDecl.WhatKindAndName}");
            }
        }

        /// <summary>
        /// Look up expr.Name in the following order:
        ///  0. Local variable, parameter, or bound variable.
        ///     (Language design note:  If this clashes with something of interest, one can always rename the local variable locally.)
        ///  1. Member of enclosing class (an implicit "this" is inserted, if needed)
        ///  2. If isLastNameSegment:
        ///     Unambiguous constructor name of a datatype in the enclosing module (if two constructors have the same name, an error message is produced here)
        ///     (Language design note:  If the constructor name is ambiguous or if one of the steps above takes priority, one can qualify the constructor
        ///     name with the name of the datatype.)
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
        /// <param name="complain"></param>
        /// <param name="specialOpaqueHackAllowance">If "true", treats an expression "f" where "f" is an instance function, as "this.f", even though
        /// there is no "this" in scope. This seems like a terrible hack, because it breaks scope invariants about the AST. But, for now, it's here
        /// to mimic what the legacy resolver does.</param>
        Expression ResolveNameSegment(NameSegment expr, bool isLastNameSegment, List<ActualBinding> args,
          ResolutionContext resolutionContext, bool allowMethodCall, bool complain = true, bool specialOpaqueHackAllowance = false)
        {
            Contract.Requires(expr != null);
            Contract.Requires(!expr.WasResolved());
            Contract.Requires(resolutionContext != null);
            Contract.Ensures(Contract.Result<Expression>() == null || args != null);

            if (MutateCSharp.Schemata423.ReplaceBinExprOp_20(323L, expr.OptTypeArguments, null))
            {
                foreach (var ty in expr.OptTypeArguments)
                {
                    resolver.ResolveType(expr.tok, ty, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                }
            }

            Expression r = null;  // the resolved expression, if successful
            Expression rWithArgs = null;  // the resolved expression after incorporating "args"

            // For 1 and 4:
            MemberDecl member = null;
            // For 2 and 5:
            Tuple<DatatypeCtor, bool> pair;

            var name = resolutionContext.InReveal ? RevealStmt.RevealLemmaPrefix + expr.Name : expr.Name;
            var v = scope.Find(name);
            if (MutateCSharp.Schemata423.ReplaceBinExprOp_3(324L, v, null))
            {
                // ----- 0. local variable, parameter, or bound variable
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_20(325L, expr.OptTypeArguments, null))
                {
                    if (complain)
                    {
                        ReportError(expr.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(326L, "variable '{0}' does not take any type parameters"), name);
                    }
                    else
                    {
                        expr.ResolvedExpression = null;
                        return null;
                    }
                }
                r = new IdentifierExpr(expr.tok, v)
                {
                    PreType = v.PreType
                };
            }
            else if (currentClass != null && resolver.GetClassMembers(currentClass) is { } members &&
                       members.TryGetValue(name, out member))
            {
                // ----- 1. member of the enclosing class
                Expression receiver;
                if (member.IsStatic)
                {
                    receiver = new StaticReceiverExpr(expr.tok, UserDefinedType.FromTopLevelDecl(expr.tok, currentClass, currentClass.TypeArgs),
                      (TopLevelDeclWithMembers)member.EnclosingClass, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(327L, true));
                    receiver.PreType = Type2PreType(receiver.Type);
                }
                else
                {
                    if (MutateCSharp.Schemata423.ReplaceBinExprOp_16(328L, () => !scope.AllowInstance, () => !specialOpaqueHackAllowance))
                    {
                        if (complain)
                        {
                            ReportError(expr.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(334L, "'this' is not allowed in a 'static' context")); //TODO: Rephrase this
                        }
                        else
                        {
                            expr.ResolvedExpression = null;
                            return null;
                        }
                        // nevertheless, set "receiver" to a value so we can continue resolution
                    }
                    receiver = new ImplicitThisExpr(expr.tok);
                    receiver.Type = ModuleResolver.GetThisType(expr.tok, currentClass);
                    receiver.PreType = Type2PreType(receiver.Type);
                }
                r = ResolveExprDotCall(expr.tok, receiver, null, member, args, expr.OptTypeArguments, resolutionContext, allowMethodCall);

            }
            else if (isLastNameSegment && resolver.moduleInfo.Ctors.TryGetValue(name, out pair))
            {
                // ----- 2. datatype constructor
                if (ResolveDatatypeConstructor(expr, args, resolutionContext, complain, pair, name, ref r, ref rWithArgs))
                {
                    return null;
                }

            }
            else if (resolver.moduleInfo.TopLevels.TryGetValue(name, out var decl))
            {
                // ----- 3. Member of the enclosing module
                if (decl is AmbiguousTopLevelDecl ambiguousTopLevelDecl)
                {
                    if (complain)
                    {
                        ReportError(expr.tok,
            MutateCSharp.Schemata423.ReplaceStringConstant_1(335L, "The name {0} ambiguously refers to a type in one of the modules {1} (try qualifying the type name with the module name)"),
                          expr.Name, ambiguousTopLevelDecl.ModuleNames());
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
                    // looking at may be followed by a further suffix that makes this into an expression. We postpone the rest of the
                    // resolution to any such suffix. For now, we create a temporary expression that will never be seen by the compiler
                    // or verifier, just to have a placeholder where we can recorded what we have found.
                    if (!isLastNameSegment)
                    {
                        if (decl is ClassLikeDecl cd && cd.NonNullTypeDecl != null && MutateCSharp.Schemata423.ReplaceBinExprOp_18(336L, name, cd.NonNullTypeDecl.Name))
                        {
                            // A possibly-null type C? was mentioned. But it does not have any further members. The program should have used
                            // the name of the class, C. Report an error and continue.
                            if (complain)
                            {
                                ReportError(expr.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(337L, "To access members of {0} '{1}', write '{1}', not '{2}'"), decl.WhatKind, decl.Name, name);
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
            else if (resolver.moduleInfo.StaticMembers.TryGetValue(name, out member))
            {
                // ----- 4. static member of the enclosing module
                Contract.Assert(member.IsStatic); // moduleInfo.StaticMembers is supposed to contain only static members of the module's implicit class _default
                if (member is AmbiguousMemberDecl ambiguousMember)
                {
                    if (complain)
                    {
                        ReportError(expr.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(338L, "The name {0} ambiguously refers to a static member in one of the modules {1} (try qualifying the member name with the module name)"), expr.Name, ambiguousMember.ModuleNames());
                    }
                    else
                    {
                        expr.ResolvedExpression = null;
                        return null;
                    }
                }
                else
                {
                    var receiver = new StaticReceiverExpr(expr.tok, (TopLevelDeclWithMembers)member.EnclosingClass, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(339L, true));
                    receiver.PreType = Type2PreType(receiver.Type);
                    r = ResolveExprDotCall(expr.tok, receiver, null, member, args, expr.OptTypeArguments, resolutionContext, allowMethodCall);
                }

            }
            else if (!isLastNameSegment && resolver.moduleInfo.Ctors.TryGetValue(name, out pair))
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
                    ReportUnresolvedIdentifierError(expr.tok, name, resolutionContext);
                }
                else
                {
                    expr.ResolvedExpression = null;
                    return null;
                }
            }

            if (MutateCSharp.Schemata423.ReplaceBinExprOp_21(340L, r, null))
            {
                // an error has been reported above; we won't fill in .ResolvedExpression, but we still must fill in .PreType
                expr.PreType = CreatePreTypeProxy();
            }
            else
            {
                expr.ResolvedExpression = r;
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_22(341L, r.Type, null))
                {
                    // The following may be needed to meet some .WasResolved() expectations
                    expr.Type = r.Type.UseInternalSynonym();
                }
                expr.PreType = r.PreType;
            }
            return rWithArgs;
        }

        private void ReportUnresolvedIdentifierError(IToken tok, string name, ResolutionContext resolutionContext)
        {
            if (resolutionContext.InReveal)
            {
                var nameToReport = name.StartsWith(RevealStmt.RevealLemmaPrefix) ? name[RevealStmt.RevealLemmaPrefix.Length..] : name;
                ReportError(tok,
        MutateCSharp.Schemata423.ReplaceStringConstant_1(342L, "cannot reveal '{0}' because no revealable constant, function, assert label, or requires label in the current scope is named '{0}'"),
                  nameToReport);
            }
            else
            {
                ReportError(tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(343L, "unresolved identifier: {0}"), name);
            }
        }

        private Resolver_IdentifierExpr CreateResolver_IdentifierExpr(IToken tok, string name, List<Type> optTypeArguments, TopLevelDecl decl)
        {
            Contract.Requires(tok != null);
            Contract.Requires(name != null);
            Contract.Requires(decl != null);
            Contract.Ensures(Contract.Result<Resolver_IdentifierExpr>() != null);

            if (!resolver.moduleInfo.IsAbstract)
            {
                if (decl is ModuleDecl md && md.Signature.IsAbstract)
                {
                    ReportError(tok, $"a compiled module is not allowed to use an abstract module ({decl.Name})");
                }
            }
            var n = MutateCSharp.Schemata423.ReplaceBinExprOp_23(344L, optTypeArguments, null) ? MutateCSharp.Schemata423.ReplaceNumericConstant_6(345L, 0) : optTypeArguments.Count;
            if (MutateCSharp.Schemata423.ReplaceBinExprOp_20(349L, optTypeArguments, null))
            {
                // type arguments were supplied; they must be equal in number to those expected
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_12(350L, n, decl.TypeArgs.Count))
                {
                    ReportError(tok, $"Wrong number of type arguments ({n} instead of {decl.TypeArgs.Count}) passed to {decl.WhatKind}: {name}");
                }
            }
            var typeArguments = new List<Type>();
            for (var i = MutateCSharp.Schemata423.ReplaceNumericConstant_6(355L, 0); MutateCSharp.Schemata423.ReplaceBinExprOp_13(359L, i, decl.TypeArgs.Count); MutateCSharp.Schemata423.ReplacePostfixUnaryExprOp_7(364L, ref i))
            {
                typeArguments.Add(MutateCSharp.Schemata423.ReplaceBinExprOp_13(365L, i, n) ? optTypeArguments[i] : new InferredTypeProxy());
            }
            return new Resolver_IdentifierExpr(tok, decl, typeArguments);
        }

        private bool ResolveDatatypeConstructor(NameSegment expr, List<ActualBinding>/*?*/ args, ResolutionContext resolutionContext, bool complain,
          Tuple<DatatypeCtor, bool> pair, string name, ref Expression r, ref Expression rWithArgs)
        {
            Contract.Requires(expr != null);
            Contract.Requires(resolutionContext != null);

            var datatypeDecl = pair.Item1.EnclosingDatatype;
            if (pair.Item2)
            {
                // there is more than one constructor with this name
                if (complain)
                {
                    ReportError(expr.tok,
          MutateCSharp.Schemata423.ReplaceStringConstant_1(370L, "the name '{0}' denotes a datatype constructor, but does not do so uniquely; add an explicit qualification (for example, '{1}.{0}')"),
                      expr.Name, datatypeDecl.Name);
                    return MutateCSharp.Schemata423.ReplaceBooleanConstant_4(371L, false);
                }
                else
                {
                    expr.ResolvedExpression = null;
                    return MutateCSharp.Schemata423.ReplaceBooleanConstant_4(372L, true);
                }
            }

            if (MutateCSharp.Schemata423.ReplaceBinExprOp_20(373L, expr.OptTypeArguments, null))
            {
                if (complain)
                {
                    var errorMsg = $"datatype constructor does not take any type parameters ('{name}')";
                    if (MutateCSharp.Schemata423.ReplaceBinExprOp_12(378L, datatypeDecl.TypeArgs.Count, MutateCSharp.Schemata423.ReplaceNumericConstant_6(374L, 0)))
                    {
                        // Perhaps the user intended to put the type arguments on the constructor, but didn't know the right syntax.
                        // Let's give a hint (whether or not expr.OptTypeArguments.Count == datatypeDecl.TypeArgs.Count).
                        var givenTypeArguments = Util.Comma(expr.OptTypeArguments, targ => targ.ToString());
                        errorMsg = $"{errorMsg}; did you perhaps mean to write '{datatypeDecl.Name}<{givenTypeArguments}>.{name}'?";
                    }
                    ReportError(expr.tok, errorMsg);
                    return MutateCSharp.Schemata423.ReplaceBooleanConstant_4(383L, false);
                }
                else
                {
                    expr.ResolvedExpression = null;
                    return MutateCSharp.Schemata423.ReplaceBooleanConstant_4(384L, true);
                }
            }

            ResolveDeclarationSignature(datatypeDecl);

            var rr = new DatatypeValue(expr.tok, datatypeDecl.Name, name, args ?? new List<ActualBinding>());
            var ok = ResolveDatatypeValue(resolutionContext, rr, datatypeDecl, null, complain);
            if (!ok)
            {
                expr.ResolvedExpression = null;
                return MutateCSharp.Schemata423.ReplaceBooleanConstant_4(385L, true);
            }
            if (MutateCSharp.Schemata423.ReplaceBinExprOp_24(386L, args, null))
            {
                r = rr;
            }
            else
            {
                r = rr; // this doesn't really matter, since we're returning an "rWithArgs" (but if would have been proper to have returned the ctor as a lambda)
                rWithArgs = rr;
            }
            return MutateCSharp.Schemata423.ReplaceBooleanConstant_4(387L, false);
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
            ResolutionContext nonRevealOpts = resolutionContext with { InReveal = MutateCSharp.Schemata423.ReplaceBooleanConstant_4(388L, false) };
            if (expr.Lhs is NameSegment)
            {
                ResolveNameSegment((NameSegment)expr.Lhs, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(389L, false), null, nonRevealOpts, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(390L, false));
            }
            else if (expr.Lhs is ExprDotName)
            {
                ResolveDotSuffix((ExprDotName)expr.Lhs, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(391L, false), null, nonRevealOpts, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(392L, false));
            }
            else
            {
                ResolveExpression(expr.Lhs, nonRevealOpts);
            }

            if (MutateCSharp.Schemata423.ReplaceBinExprOp_20(393L, expr.OptTypeArguments, null))
            {
                foreach (var ty in expr.OptTypeArguments)
                {
                    resolver.ResolveType(expr.tok, ty, resolutionContext, ResolveTypeOptionEnum.InferTypeProxies, null);
                }
            }

            Expression r = null;  // the resolved expression, if successful
            Expression rWithArgs = null;  // the resolved expression after incorporating "args"

            var name = resolutionContext.InReveal ? RevealStmt.RevealLemmaPrefix + expr.SuffixName : expr.SuffixName;
            var lhs = expr.Lhs.Resolved;
            if (MutateCSharp.Schemata423.ReplaceBinExprOp_16(395L, () => MutateCSharp.Schemata423.ReplaceBinExprOp_5(394L, lhs, null), () => lhs.PreType is PreTypePlaceholderModule))
            {
                var ri = (Resolver_IdentifierExpr)lhs;
                var sig = ((ModuleDecl)ri.Decl).AccessibleSignature(MutateCSharp.Schemata423.ReplaceBooleanConstant_4(401L, false));
                sig = ModuleResolver.GetSignatureExt(sig);

                if (isLastNameSegment && sig.Ctors.TryGetValue(name, out var pair))
                {
                    // ----- 0. datatype constructor
                    if (pair.Item2)
                    {
                        // there is more than one constructor with this name
                        ReportError(expr.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(402L, "the name '{0}' denotes a datatype constructor in module {2}, but does not do so uniquely; add an explicit qualification (for example, '{1}.{0}')"), name, pair.Item1.EnclosingDatatype.Name, ((ModuleDecl)ri.Decl).Name);
                    }
                    else
                    {
                        if (MutateCSharp.Schemata423.ReplaceBinExprOp_20(403L, expr.OptTypeArguments, null))
                        {
                            ReportError(expr.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(404L, "datatype constructor does not take any type parameters ('{0}')"), name);
                        }
                        var rr = new DatatypeValue(expr.tok, pair.Item1.EnclosingDatatype.Name, name, args ?? new List<ActualBinding>());
                        ResolveDatatypeValue(resolutionContext, rr, pair.Item1.EnclosingDatatype, null);

                        if (MutateCSharp.Schemata423.ReplaceBinExprOp_24(405L, args, null))
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
                        ReportError(expr.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(406L, "The name {0} ambiguously refers to a type in one of the modules {1} (try qualifying the type name with the module name)"), expr.SuffixName, ad.ModuleNames());
                    }
                    else
                    {
                        // We have found a module name or a type name, neither of which is an expression. However, the ExprDotName we're
                        // looking at may be followed by a further suffix that makes this into an expression. We postpone the rest of the
                        // resolution to any such suffix. For now, we create a temporary expression that will never be seen by the compiler
                        // or verifier, just to have a placeholder where we can recorded what we have found.
                        if (!isLastNameSegment)
                        {
                            if (decl is ClassLikeDecl cd && cd.NonNullTypeDecl != null && MutateCSharp.Schemata423.ReplaceBinExprOp_18(407L, name, cd.NonNullTypeDecl.Name))
                            {
                                // A possibly-null type C? was mentioned. But it does not have any further members. The program should have used
                                // the name of the class, C. Report an error and continue.
                                ReportError(expr.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(408L, "To access members of {0} '{1}', write '{1}', not '{2}'"), decl.WhatKind, decl.Name, name);
                            }
                        }
                        r = resolver.CreateResolver_IdentifierExpr(expr.tok, name, expr.OptTypeArguments, decl);
                    }
                }
                else if (sig.StaticMembers.TryGetValue(name, out var member))
                {
                    // ----- 2. static member of the specified module
                    Contract.Assert(member.IsStatic); // moduleInfo.StaticMembers is supposed to contain only static members of the module's implicit class _default
                    if (member is AmbiguousMemberDecl)
                    {
                        var ambiguousMember = (AmbiguousMemberDecl)member;
                        ReportError(expr.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(409L, "The name {0} ambiguously refers to a static member in one of the modules {1} (try qualifying the member name with the module name)"), expr.SuffixName, ambiguousMember.ModuleNames());
                    }
                    else
                    {
                        var receiver = new StaticReceiverExpr(expr.tok, (TopLevelDeclWithMembers)member.EnclosingClass, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(410L, true));
                        receiver.PreType = Type2PreType(receiver.Type);
                        r = ResolveExprDotCall(expr.tok, receiver, null, member, args, expr.OptTypeArguments, resolutionContext, allowMethodCall);
                    }
                }
                else
                {
                    ReportUnresolvedIdentifierError(expr.tok, name, resolutionContext);
                }

            }
            else if (MutateCSharp.Schemata423.ReplaceBinExprOp_16(412L, () => MutateCSharp.Schemata423.ReplaceBinExprOp_5(411L, lhs, null), () => lhs.PreType is PreTypePlaceholderType))
            {
                var ri = (Resolver_IdentifierExpr)lhs;
                // ----- 3. Look up name in type
                // expand any synonyms
                var ty = new UserDefinedType(expr.tok, ri.Decl.Name, ri.Decl, ri.TypeArgs).NormalizeExpand();
                if (ty.IsDatatype)
                {
                    // ----- LHS is a datatype
                    var dt = ty.AsDatatype;
                    if (MutateCSharp.Schemata423.ReplaceBinExprOp_25(418L, dt.ConstructorsByName, null) && dt.ConstructorsByName.TryGetValue(name, out var ctor))
                    {
                        if (MutateCSharp.Schemata423.ReplaceBinExprOp_20(419L, expr.OptTypeArguments, null))
                        {
                            ReportError(expr.tok, $"datatype constructor does not take any type parameters ('{name}')");
                        }
                        var rr = new DatatypeValue(expr.tok, ctor.EnclosingDatatype.Name, name, args ?? new List<ActualBinding>());
                        ResolveDatatypeValue(resolutionContext, rr, ctor.EnclosingDatatype, (DPreType)Type2PreType(ty));
                        if (MutateCSharp.Schemata423.ReplaceBinExprOp_24(420L, args, null))
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
                var cd = MutateCSharp.Schemata423.ReplaceBinExprOp_21(421L, r, null) ? ty.AsTopLevelTypeWithMembersBypassInternalSynonym : null;
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_26(422L, cd, null))
                {
                    // ----- LHS is a type with members
                    if (resolver.GetClassMembers(cd) is { } members && members.TryGetValue(name, out var member))
                    {
                        if (!resolver.VisibleInScope(member))
                        {
                            ReportError(expr.tok, $"member '{name}' has not been imported in this scope and cannot be accessed here");
                        }
                        if (!member.IsStatic)
                        {
                            ReportError(expr.tok, $"accessing member '{name}' requires an instance expression"); //TODO Unify with similar error messages
                                                                                                                 // nevertheless, continue creating an expression that approximates a correct one
                        }
                        var receiver = new StaticReceiverExpr(expr.Lhs.tok, (UserDefinedType)ty.NormalizeExpand(), (TopLevelDeclWithMembers)member.EnclosingClass, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(423L, false));
                        receiver.PreType = Type2PreType(receiver.Type);
                        r = ResolveExprDotCall(expr.tok, receiver, null, member, args, expr.OptTypeArguments, resolutionContext, allowMethodCall);
                    }
                }
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_21(424L, r, null))
                {
                    ReportMemberNotFoundError(expr.tok, name, null, ri.Decl, resolutionContext);
                }

            }
            else if (MutateCSharp.Schemata423.ReplaceBinExprOp_5(425L, lhs, null))
            {
                // ----- 4. Look up name in the type of the Lhs
                var (member, tentativeReceiverPreType) = FindMember(expr.tok, expr.Lhs.PreType, name, resolutionContext);
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_27(426L, member, null))
                {
                    if (!member.IsStatic)
                    {
                        var receiver = expr.Lhs;
                        AddSubtypeConstraint(tentativeReceiverPreType, receiver.PreType, expr.tok, $"receiver type ({{1}}) does not have a member named '{name}'");
                        r = ResolveExprDotCall(expr.tok, receiver, tentativeReceiverPreType, member, args, expr.OptTypeArguments, resolutionContext, allowMethodCall);
                    }
                    else
                    {
                        var receiver = new StaticReceiverExpr(expr.tok, new InferredTypeProxy(), MutateCSharp.Schemata423.ReplaceBooleanConstant_4(427L, true))
                        {
                            PreType = tentativeReceiverPreType,
                            ObjectToDiscard = lhs
                        };
                        r = ResolveExprDotCall(expr.tok, receiver, null, member, args, expr.OptTypeArguments, resolutionContext, allowMethodCall);
                    }
                }
            }

            if (MutateCSharp.Schemata423.ReplaceBinExprOp_21(428L, r, null))
            {
                // an error has been reported above; we won't fill in .ResolvedExpression, but we still must fill in .PreType
                expr.PreType = CreatePreTypeProxy(MutateCSharp.Schemata423.ReplaceStringConstant_1(429L, "ExprDotName error, so using proxy instead"));
            }
            else
            {
                expr.ResolvedExpression = r;
                // TODO: do we need something analogous to this for pre-types?  expr.Type = r.Type.UseInternalSynonym();
                expr.PreType = r.PreType;
            }
            return rWithArgs;
        }

        Expression ResolveExprDotCall(IToken tok, Expression receiver, DPreType receiverPreTypeBound/*?*/,
          MemberDecl member, List<ActualBinding> args, List<Type> optTypeArguments, ResolutionContext resolutionContext, bool allowMethodCall)
        {
            Contract.Requires(tok != null);
            Contract.Requires(receiver != null);
            Contract.Requires(receiver.PreType.Normalize() is DPreType);
            Contract.Requires(member != null);
            Contract.Requires(resolutionContext != null && resolutionContext != null);

            ResolvePreTypeSignature(member);

            receiverPreTypeBound ??= (DPreType)receiver.PreType.Normalize();

            var rr = new MemberSelectExpr(tok, receiver, member.Name);
            rr.Member = member;

            // Now, fill in rr.PreType.  This requires taking into consideration the type parameters passed to the receiver's type as well as any type
            // parameters used in this NameSegment/ExprDotName.
            // Add to "subst" the type parameters given to the member's class/datatype
            rr.PreTypeApplication_AtEnclosingClass = new List<PreType>();
            rr.PreTypeApplication_JustMember = new List<PreType>();
            var rType = receiverPreTypeBound;
            var subst = PreType.PreTypeSubstMap(rType.Decl.TypeArgs, rType.Arguments);
            Contract.Assert(member.EnclosingClass != null);
            rr.PreTypeApplication_AtEnclosingClass.AddRange(rType.AsParentType(member.EnclosingClass, this).Arguments);

            if (member is Field field)
            {
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_20(430L, optTypeArguments, null))
                {
                    ReportError(tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(431L, "a field ({0}) does not take any type arguments (got {1})"), field.Name, optTypeArguments.Count);
                }
                subst = BuildPreTypeArgumentSubstitute(subst, receiverPreTypeBound);
                rr.PreType = field.PreType.Substitute(subst);
            }
            else if (member is Function function)
            {
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_16(432L, () => function is TwoStateFunction, () => !resolutionContext.IsTwoState))
                {
                    ReportError(tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(438L, "two-state function ('{0}') can only be called in a two-state context"), member.Name);
                }
                int suppliedTypeArguments = MutateCSharp.Schemata423.ReplaceBinExprOp_23(439L, optTypeArguments, null) ? MutateCSharp.Schemata423.ReplaceNumericConstant_6(440L, 0) : optTypeArguments.Count;
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_20(444L, optTypeArguments, null))
                {
                    if (MutateCSharp.Schemata423.ReplaceBinExprOp_14(445L, suppliedTypeArguments, function.TypeArgs.Count))
                    {
                        // preserve the given types in the resolved MemberSelectExpr
                        rr.TypeApplication_JustMember = optTypeArguments;
                    }
                    else
                    {
                        ReportError(tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(450L, "function '{0}' expects {1} type argument{2} (got {3})"),
                          member.Name, function.TypeArgs.Count, Util.Plural(function.TypeArgs.Count), suppliedTypeArguments);
                    }
                }
                for (int i = MutateCSharp.Schemata423.ReplaceNumericConstant_6(451L, 0); MutateCSharp.Schemata423.ReplaceBinExprOp_13(455L, i, function.TypeArgs.Count); MutateCSharp.Schemata423.ReplacePostfixUnaryExprOp_7(460L, ref i))
                {
                    var ta = MutateCSharp.Schemata423.ReplaceBinExprOp_13(461L, i, suppliedTypeArguments) ? Type2PreType(optTypeArguments[i]) :
                      CreatePreTypeProxy($"function call to {function.Name}, type argument {i}");
                    rr.PreTypeApplication_JustMember.Add(ta);
                    subst.Add(function.TypeArgs[i], ta);
                }
                subst = BuildPreTypeArgumentSubstitute(subst, receiverPreTypeBound);
                var inParamTypes = function.Ins.ConvertAll(f => f.PreType.Substitute(subst));
                var resultType = Type2PreType(function.ResultType).Substitute(subst);
                rr.PreType = BuiltInArrowType(inParamTypes, resultType);
            }
            else
            {
                // the member is a method
                var method = (Method)member;
                if (!allowMethodCall)
                {
                    // it's a method and method calls are not allowed in the given resolutionContext
                    ReportError(tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(466L, "expression is not allowed to invoke a {0} ({1})"), member.WhatKind, member.Name);
                }
                int suppliedTypeArguments = MutateCSharp.Schemata423.ReplaceBinExprOp_23(467L, optTypeArguments, null) ? MutateCSharp.Schemata423.ReplaceNumericConstant_6(468L, 0) : optTypeArguments.Count;
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_20(472L, optTypeArguments, null))
                {
                    if (MutateCSharp.Schemata423.ReplaceBinExprOp_14(473L, suppliedTypeArguments, method.TypeArgs.Count))
                    {
                        // preserve the given types in the resolved MemberSelectExpr
                        rr.TypeApplication_JustMember = optTypeArguments;
                    }
                    else
                    {
                        ReportError(tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(478L, "method '{0}' expects {1} type argument{2} (got {3})"),
                          member.Name, method.TypeArgs.Count, Util.Plural(method.TypeArgs.Count), suppliedTypeArguments);
                    }
                }
                for (int i = MutateCSharp.Schemata423.ReplaceNumericConstant_6(479L, 0); MutateCSharp.Schemata423.ReplaceBinExprOp_13(483L, i, method.TypeArgs.Count); MutateCSharp.Schemata423.ReplacePostfixUnaryExprOp_7(488L, ref i))
                {
                    var ta = MutateCSharp.Schemata423.ReplaceBinExprOp_13(489L, i, suppliedTypeArguments) ? Type2PreType(optTypeArguments[i]) :
                      CreatePreTypeProxy($"method call to {method.Name}, type argument {i}");
                    rr.PreTypeApplication_JustMember.Add(ta);
                    subst.Add(method.TypeArgs[i], ta);
                }
                rr.PreType = new UnusedPreType($"call to {method.WhatKind} {method.Name}");  // fill in this field, in order to make "rr" resolved
            }
            return rr;
        }

        public MethodCallInformation ResolveApplySuffix(ApplySuffix e, ResolutionContext resolutionContext, bool allowMethodCall)
        {
            Contract.Requires(e != null);
            Contract.Requires(resolutionContext != null);
            Contract.Ensures(Contract.Result<MethodCallInformation>() == null || allowMethodCall);

            if (MutateCSharp.Schemata423.ReplaceBinExprOp_28(494L, e.MethodCallInfo, null))
            {
                return e.MethodCallInfo;
            }

            Expression r = null;  // upon success, the expression to which the ApplySuffix resolves
            var errorCount = ErrorCount;
            if (e.Lhs is NameSegment)
            {
                r = ResolveNameSegment((NameSegment)e.Lhs, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(495L, true), e.Bindings.ArgumentBindings, resolutionContext, allowMethodCall);
                // note, if r is non-null, then e.Args have been resolved and r is a resolved expression that incorporates e.Args
            }
            else if (e.Lhs is ExprDotName)
            {
                r = ResolveDotSuffix((ExprDotName)e.Lhs, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(496L, true), e.Bindings.ArgumentBindings, resolutionContext, allowMethodCall);
                // note, if r is non-null, then e.Args have been resolved and r is a resolved expression that incorporates e.Args
            }
            else
            {
                ResolveExpression(e.Lhs, resolutionContext);
            }
            if (MutateCSharp.Schemata423.ReplaceBinExprOp_17(497L, e.Lhs.PreType, null))
            {
                // some error had been detected during the attempted resolution of e.Lhs
                e.Lhs.PreType = CreatePreTypeProxy(MutateCSharp.Schemata423.ReplaceStringConstant_1(498L, "unresolved ApplySuffix LHS"));
            }
            Label atLabel = null;
            if (MutateCSharp.Schemata423.ReplaceBinExprOp_29(499L, e.AtTok, null))
            {
                atLabel = dominatingStatementLabels.Find(e.AtTok.val);
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_30(500L, atLabel, null))
                {
                    ReportError(e.AtTok, MutateCSharp.Schemata423.ReplaceStringConstant_1(501L, "no label '{0}' in scope at this time"), e.AtTok.val);
                }
            }
            if (MutateCSharp.Schemata423.ReplaceBinExprOp_21(502L, r, null))
            {
                // e.Lhs denotes a function value, or at least it's used as if it were
                var dp = Constraints.FindDefinedPreType(e.Lhs.PreType, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(503L, false));
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_16(505L, () => MutateCSharp.Schemata423.ReplaceBinExprOp_31(504L, dp, null), () => DPreType.IsArrowType(dp.Decl)))
                {
                    // e.Lhs does denote a function value
                    // In the general case, we'll resolve this as an ApplyExpr, but in the more common case of the Lhs
                    // naming a function directly, we resolve this as a FunctionCallExpr.
                    var mse = MutateCSharp.Schemata423.ReplaceBinExprOp_32(511L, () => e.Lhs is NameSegment, () => e.Lhs is ExprDotName) ? e.Lhs.Resolved as MemberSelectExpr : null;
                    var callee = mse?.Member as Function;
                    if (MutateCSharp.Schemata423.ReplaceBinExprOp_16(518L, () => MutateCSharp.Schemata423.ReplaceBinExprOp_33(517L, atLabel, null), () => !(callee is TwoStateFunction)))
                    {
                        ReportError(e.AtTok, MutateCSharp.Schemata423.ReplaceStringConstant_1(524L, "an @-label can only be applied to a two-state function"));
                        atLabel = null;
                    }
                    if (MutateCSharp.Schemata423.ReplaceBinExprOp_34(525L, callee, null))
                    {
                        // resolve as a FunctionCallExpr instead of as an ApplyExpr(MemberSelectExpr)
                        var rr = new FunctionCallExpr(e.Lhs.tok, callee.Name, mse.Obj, e.tok, e.CloseParen, e.Bindings, atLabel)
                        {
                            Function = callee,
                            PreTypeApplication_AtEnclosingClass = mse.PreTypeApplication_AtEnclosingClass,
                            PreTypeApplication_JustFunction = mse.PreTypeApplication_JustMember
                        };
                        var typeMap = mse.PreTypeArgumentSubstitutionsAtMemberDeclaration();
                        var preTypeMap = BuildPreTypeArgumentSubstitute(
                            typeMap.Keys.ToDictionary(tp => tp, tp => typeMap[tp]));
                        ResolveActualParameters(rr.Bindings, callee.Ins, e.tok, callee, resolutionContext, preTypeMap, callee.IsStatic ? null : mse.Obj);
                        rr.PreType = Type2PreType(callee.ResultType).Substitute(preTypeMap);
                        if (MutateCSharp.Schemata423.ReplaceBinExprOp_14(526L, errorCount, ErrorCount))
                        {
                            Contract.Assert(!(mse.Obj is StaticReceiverExpr) || callee.IsStatic);  // this should have been checked already
                            Contract.Assert(callee.Ins.Count == rr.Args.Count);  // this should have been checked already
                        }
                        // further bookkeeping
                        if (callee is ExtremePredicate)
                        {
                            ((ExtremePredicate)callee).Uses.Add(rr);
                        }
                        r = rr;
                        ResolveExpression(r, resolutionContext);
                    }
                    else
                    {
                        // resolve as an ApplyExpr
                        var formals = new List<Formal>();
                        for (var i = MutateCSharp.Schemata423.ReplaceNumericConstant_6(531L, 0); MutateCSharp.Schemata423.ReplaceBinExprOp_13(548L, i, MutateCSharp.Schemata423.ReplaceBinExprOp_11(539L, dp.Arguments.Count, MutateCSharp.Schemata423.ReplaceNumericConstant_6(535L, 1))); MutateCSharp.Schemata423.ReplacePostfixUnaryExprOp_7(553L, ref i))
                        {
                            var argType = dp.Arguments[i];
                            var formal = new ImplicitFormal(e.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(554L, "_#p") + i, new InferredTypeProxy(), MutateCSharp.Schemata423.ReplaceBooleanConstant_4(555L, true), MutateCSharp.Schemata423.ReplaceBooleanConstant_4(556L, false));
                            formal.PreType = argType;
                            formals.Add(formal);
                        }
                        ResolveActualParameters(e.Bindings, formals, e.tok, dp, resolutionContext, new Dictionary<TypeParameter, PreType>(), null);
                        r = new ApplyExpr(e.Lhs.tok, e.Lhs, e.Args, e.CloseParen);
                        ResolveExpression(r, resolutionContext);
                        r.PreType = dp.Arguments.Last();
                    }
                }
                else
                {
                    // e.Lhs is used as if it were a function value, but it isn't
                    var lhs = e.Lhs.Resolved;
                    if (MutateCSharp.Schemata423.ReplaceBinExprOp_16(558L, () => MutateCSharp.Schemata423.ReplaceBinExprOp_5(557L, lhs, null), () => lhs.PreType is PreTypePlaceholderModule))
                    {
                        ReportError(e.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(564L, "name of module ({0}) is used as a function"), ((Resolver_IdentifierExpr)lhs).Decl.Name);
                    }
                    else if (MutateCSharp.Schemata423.ReplaceBinExprOp_16(566L, () => MutateCSharp.Schemata423.ReplaceBinExprOp_5(565L, lhs, null), () => lhs.PreType is PreTypePlaceholderType))
                    {
                        var ri = (Resolver_IdentifierExpr)lhs;
                        ReportError(e.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(572L, "name of {0} ({1}) is used as a function"), ri.Decl.WhatKind, ri.Decl.Name);
                    }
                    else
                    {
                        if (lhs is MemberSelectExpr mse && mse.Member is Method)
                        {
                            if (MutateCSharp.Schemata423.ReplaceBinExprOp_33(573L, atLabel, null))
                            {
                                Contract.Assert(mse != null); // assured by the parser
                                if (mse.Member is TwoStateLemma)
                                {
                                    mse.AtLabel = atLabel;
                                }
                                else
                                {
                                    ReportError(e.AtTok, MutateCSharp.Schemata423.ReplaceStringConstant_1(574L, "an @-label can only be applied to a two-state lemma"));
                                }
                            }
                            if (allowMethodCall)
                            {
                                Contract.Assert(!e.Bindings.WasResolved); // we expect that .Bindings has not yet been processed, so we use just .ArgumentBindings in the next line
                                var tok = resolver.Options.Get(Snippets.ShowSnippets) ? e.RangeToken.ToToken() : e.tok;
                                e.MethodCallInfo = new MethodCallInformation(tok, mse, e.Bindings.ArgumentBindings);
                                return e.MethodCallInfo;
                            }
                            else
                            {
                                ReportError(e.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(575L, "{0} call is not allowed to be used in an expression resolutionContext ({1})"), mse.Member.WhatKind, mse.Member.Name);
                            }
                        }
                        else if (MutateCSharp.Schemata423.ReplaceBinExprOp_5(576L, lhs, null))
                        {  // if e.Lhs.Resolved is null, then e.Lhs was not successfully resolved and an error has already been reported
                            ReportError(e.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(577L, "non-function expression (of type {0}) is called with parameters"), e.Lhs.PreType);
                        }
                    }
                    // resolve the arguments, even in the presence of the errors above
                    foreach (var binding in e.Bindings.ArgumentBindings)
                    {
                        ResolveExpression(binding.Actual, resolutionContext);
                    }
                }
            }
            if (MutateCSharp.Schemata423.ReplaceBinExprOp_21(578L, r, null))
            {
                // an error has been reported above; we won't fill in .ResolvedExpression, but we still must fill in .PreType
                e.PreType = CreatePreTypeProxy(MutateCSharp.Schemata423.ReplaceStringConstant_1(579L, "unresolved ApplySuffix"));
            }
            else
            {
                e.ResolvedExpression = r;
                e.PreType = r.PreType;
            }
            return null; // not a method call
        }

        /// <summary>
        /// Attempt to rewrite a datatype update into more primitive operations, after doing the appropriate resolution checks.
        /// Upon success, return that rewritten expression and set "legalSourceConstructors".
        /// Upon some resolution error, report an error and return null (caller should not use "legalSourceConstructors").
        /// Note, "root.PreType" is allowed to be different from "rootPreType"; in particular, "root.PreType" may still be a proxy.
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
        (Expression, Expression) ResolveDatatypeUpdate(IToken tok, DPreType rootPreType, Expression root, DatatypeDecl dt,
          List<Tuple<IToken, string, Expression>> memberUpdates,
          ResolutionContext resolutionContext, out List<MemberDecl> members, out List<DatatypeCtor> legalSourceConstructors)
        {
            Contract.Requires(tok != null);
            Contract.Requires(root != null);
            Contract.Requires(rootPreType != null);
            Contract.Requires(dt != null);
            Contract.Requires(memberUpdates != null);
            Contract.Requires(resolutionContext != null);

            legalSourceConstructors = null;
            members = new List<MemberDecl>();
            Contract.Assert(rootPreType.Decl == dt);
            Contract.Assert(rootPreType.Arguments.Count == dt.TypeArgs.Count);

            // First, compute the list of candidate result constructors, that is, the constructors
            // that have all of the mentioned destructors. Issue errors for duplicated names and for
            // names that are not destructors in the datatype.
            var candidateResultCtors = dt.Ctors;  // list of constructors that have all the so-far-mentioned destructors
            var memberNames = new HashSet<string>();
            var rhsBindings = new Dictionary<string, Tuple<BoundVar/*let variable*/, IdentifierExpr/*id expr for let variable*/, Expression /*RHS in given syntax*/>>();
            foreach (var (updateToken, updateName, updateValue) in memberUpdates)
            {
                if (memberNames.Contains(updateName))
                {
                    ReportError(updateToken, $"duplicate update member '{updateName}'");
                }
                else
                {
                    memberNames.Add(updateName);
                    if (!resolver.GetClassMembers(dt).TryGetValue(updateName, out var member))
                    {
                        ReportError(updateToken, MutateCSharp.Schemata423.ReplaceStringConstant_1(580L, "member '{0}' does not exist in datatype '{1}'"), updateName, dt.Name);
                    }
                    else if (member is not DatatypeDestructor)
                    {
                        ReportError(updateToken, MutateCSharp.Schemata423.ReplaceStringConstant_1(581L, "member '{0}' is not a destructor in datatype '{1}'"), updateName, dt.Name);
                    }
                    else
                    {
                        members.Add(member);
                        var destructor = (DatatypeDestructor)member;
                        var intersection = new List<DatatypeCtor>(candidateResultCtors.Intersect(destructor.EnclosingCtors));
                        if (MutateCSharp.Schemata423.ReplaceBinExprOp_14(586L, intersection.Count, MutateCSharp.Schemata423.ReplaceNumericConstant_6(582L, 0)))
                        {
                            ReportError(updateToken,
              MutateCSharp.Schemata423.ReplaceStringConstant_1(591L, "updated datatype members must belong to the same constructor (unlike the previously mentioned destructors, '{0}' does not belong to {1})"),
                              updateName, DatatypeDestructor.PrintableCtorNameList(candidateResultCtors, MutateCSharp.Schemata423.ReplaceStringConstant_1(592L, "or")));
                        }
                        else
                        {
                            candidateResultCtors = intersection;
                            if (destructor.IsGhost)
                            {
                                rhsBindings.Add(updateName, new Tuple<BoundVar, IdentifierExpr, Expression>(null, null, updateValue));
                            }
                            else
                            {
                                var xName = resolver.FreshTempVarName($"dt_update#{updateName}#", resolutionContext.CodeContext);
                                var xVar = new BoundVar(new AutoGeneratedToken(tok), xName, new InferredTypeProxy());
                                var x = new IdentifierExpr(new AutoGeneratedToken(tok), xVar);
                                rhsBindings.Add(updateName, new Tuple<BoundVar, IdentifierExpr, Expression>(xVar, x, updateValue));
                            }
                        }
                    }
                }
            }
            if (MutateCSharp.Schemata423.ReplaceBinExprOp_14(597L, candidateResultCtors.Count, MutateCSharp.Schemata423.ReplaceNumericConstant_6(593L, 0)))
            {
                return (null, null);
            }

            // Check that every candidate result constructor has given a name to all of its parameters.
            var hasError = MutateCSharp.Schemata423.ReplaceBooleanConstant_4(602L, false);
            foreach (var ctor in candidateResultCtors)
            {
                if (ctor.Formals.Exists(f => !f.HasName))
                {
                    ReportError(tok, $"candidate result constructor '{ctor.Name}' has an anonymous parameter" +
          MutateCSharp.Schemata423.ReplaceStringConstant_1(603L, " (to use in datatype update expression, name all the parameters of the candidate result constructors)"));
                    hasError = MutateCSharp.Schemata423.ReplaceBooleanConstant_4(604L, true);
                }
            }
            if (hasError)
            {
                return (null, null);
            }

            // The legal source constructors are the candidate result constructors. (Yep, two names for the same thing.)
            legalSourceConstructors = candidateResultCtors;
            Contract.Assert(1 <= legalSourceConstructors.Count);

            var desugaringForGhostContext = DesugarDatatypeUpdate(tok, root, rootPreType, candidateResultCtors, rhsBindings, resolutionContext);
            var nonGhostConstructors = candidateResultCtors.Where(ctor => !ctor.IsGhost).ToList();
            if (MutateCSharp.Schemata423.ReplaceBinExprOp_14(605L, nonGhostConstructors.Count, candidateResultCtors.Count))
            {
                return (desugaringForGhostContext, desugaringForGhostContext);
            }
            var desugaringForCompiledContext = DesugarDatatypeUpdate(tok, root, rootPreType, nonGhostConstructors, rhsBindings, resolutionContext);
            return (desugaringForGhostContext, desugaringForCompiledContext);
        }

        /// <summary>
        /// Rewrite the datatype update root.(x := X, y := Y, ...) into a resolved expression:
        ///     var d := root;
        ///     var x := X;  // EXCEPT: don't do this for ghost fields (see below)
        ///     var y := Y;
        ///     ...
        ///     if d.CandidateResultConstructor0 then
        ///       CandidateResultConstructor0(x, y, ..., d.f0, d.f1, ...)  // for a ghost field x, use the expression X directly
        ///     else if d.CandidateResultConstructor1 then
        ///       CandidateResultConstructor0(x, y, ..., d.g0, d.g1, ...)
        ///     ...
        ///     else
        ///       CandidateResultConstructorN(x, y, ..., d.k0, d.k1, ...)
        ///
        /// </summary>
        private Expression DesugarDatatypeUpdate(IToken tok, Expression root, DPreType rootPreType,
          List<DatatypeCtor> candidateResultCtors, Dictionary<string, Tuple<BoundVar, IdentifierExpr, Expression>> rhsBindings,
          ResolutionContext resolutionContext)
        {
            Contract.Requires(1 <= candidateResultCtors.Count);

            // Create a unique name for d', the variable we introduce in the let expression
            var dName = resolver.FreshTempVarName(MutateCSharp.Schemata423.ReplaceStringConstant_1(610L, "dt_update_tmp#"), resolutionContext.CodeContext);
            var dVar = new BoundVar(new AutoGeneratedToken(tok), dName, new InferredTypeProxy());
            dVar.PreType = rootPreType;
            var d = new IdentifierExpr(new AutoGeneratedToken(tok), dVar);
            Expression body = null;
            candidateResultCtors.Reverse();
            foreach (var crc in candidateResultCtors)
            {
                // Build the arguments to the datatype constructor, using the updated value in the appropriate slot
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
                    var bindingName = new Token(tok.line, tok.col)
                    {
                        Uri = tok.Uri,
                        val = f.Name
                    };
                    actualBindings.Add(new ActualBinding(bindingName, ctorArg));
                }
                var ctorCall = new DatatypeValue(tok, crc.EnclosingDatatype.Name, crc.Name, actualBindings);
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_21(611L, body, null))
                {
                    body = ctorCall;
                }
                else
                {
                    // body := if d.crc? then ctor_call else body
                    var guard = new ExprDotName(tok, d, crc.QueryField.Name, null);
                    body = new ITEExpr(tok, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(612L, false), guard, ctorCall, body);
                }
            }
            Contract.Assert(body != null); // because there was at least one element in candidateResultCtors

            // Wrap the let bindings around body
            var rewrite = body;
            foreach (var entry in rhsBindings)
            {
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_35(613L, entry.Value.Item1, null))
                {
                    var lhs = new CasePattern<BoundVar>(tok, entry.Value.Item1);
                    rewrite = new LetExpr(tok, new List<CasePattern<BoundVar>>() { lhs }, new List<Expression>() { entry.Value.Item3 }, rewrite, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(614L, true));
                }
            }
            var dVarPat = new CasePattern<BoundVar>(tok, dVar);
            rewrite = new LetExpr(tok, new List<CasePattern<BoundVar>>() { dVarPat }, new List<Expression>() { root }, rewrite, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(615L, true));
            Contract.Assert(rewrite != null);
            ResolveExpression(rewrite, resolutionContext);
            return rewrite;
        }

        /// <summary>
        /// Resolves the case pattern "pat", figuring out if it denotes a variable or a constructor (or is in error).
        /// The caller is expected to have filled in the .type and .PreType fields of any variable occurring in "pat".
        /// </summary>
        void ResolveCasePattern<VT>(CasePattern<VT> pat, PreType sourcePreType, ResolutionContext resolutionContext) where VT : class, IVariable
        {
            Contract.Requires(pat != null);
            Contract.Requires(sourcePreType != null);
            Contract.Requires(resolutionContext != null);

            var dtd = (sourcePreType.Normalize() as DPreType)?.Decl as DatatypeDecl;
            List<PreType> sourceTypeArguments = null;
            // Find the constructor in the given datatype
            // If what was parsed was just an identifier, we will interpret it as a datatype constructor, if possible
            DatatypeCtor ctor = null;
            if (MutateCSharp.Schemata423.ReplaceBinExprOp_36(616L, dtd, null))
            {
                sourceTypeArguments = ((DPreType)sourcePreType.Normalize()).Arguments;
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_32(623L, () => pat.Var == null, () => (MutateCSharp.Schemata423.ReplaceBinExprOp_16(617L, () => pat.Var != null, () => pat.Var.Type is TypeProxy))))
                {
                    if (dtd.ConstructorsByName.TryGetValue(pat.Id, out ctor))
                    {
                        if (pat.Arguments == null)
                        {
                            if (MutateCSharp.Schemata423.ReplaceBinExprOp_12(633L, ctor.Formals.Count, MutateCSharp.Schemata423.ReplaceNumericConstant_6(629L, 0)))
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
                Contract.Assert(v.PreType != null);
                // Note, the following type constraint checks that the RHS type can be assigned to the new variable on the left. In particular, it
                // does not check that the entire RHS can be assigned to something of the type of the pattern on the left.  For example, consider
                // a type declared as "datatype Atom<T> = MakeAtom(T)", where T is a non-variant type argument.  Suppose the RHS has type Atom<nat>
                // and that the LHS is the pattern MakeAtom(x: int).  This is okay, despite the fact that Atom<nat> is not assignable to Atom<int>.
                // The reason is that the purpose of the pattern on the left is really just to provide a skeleton to introduce bound variables in.
                AddSubtypeConstraint(v.PreType, sourcePreType, v.Tok,
        MutateCSharp.Schemata423.ReplaceStringConstant_1(638L, "type of corresponding source/RHS ({1}) does not match type of bound variable ({0})"));
                pat.AssembleExprPreType(null);
                return;
            }

            if (MutateCSharp.Schemata423.ReplaceBinExprOp_37(639L, dtd, null))
            {
                // look up the name of the pattern's constructor
                if (resolver.moduleInfo.Ctors.TryGetValue(pat.Id, out var pair) && !pair.Item2)
                {
                    ctor = pair.Item1;
                    pat.Ctor = ctor;
                    dtd = ctor.EnclosingDatatype;
                    sourceTypeArguments = dtd.TypeArgs.ConvertAll(tp => (PreType)CreatePreTypeProxy($"type parameter '{tp.Name}'"));
                    var lhsPreType = new DPreType(dtd, sourceTypeArguments);
                    AddSubtypeConstraint(lhsPreType, sourcePreType, pat.tok, $"type of RHS ({{0}}) does not match type of bound variable '{pat.Id}' ({{1}})");
                }
            }
            if (MutateCSharp.Schemata423.ReplaceBinExprOp_37(640L, dtd, null))
            {
                Contract.Assert(ctor == null);
                ReportError(pat.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(641L, "to use a pattern, the type of the source/RHS expression must be a datatype (instead found {0})"), sourcePreType);
            }
            else if (MutateCSharp.Schemata423.ReplaceBinExprOp_38(642L, ctor, null))
            {
                ReportError(pat.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(643L, "constructor {0} does not exist in datatype {1}"), pat.Id, dtd.Name);
            }
            else
            {
                if (pat.Arguments == null)
                {
                    if (MutateCSharp.Schemata423.ReplaceBinExprOp_14(648L, ctor.Formals.Count, MutateCSharp.Schemata423.ReplaceNumericConstant_6(644L, 0)))
                    {
                        // The Id matches a constructor of the correct type and 0 arguments,
                        // so make it a nullary constructor, not a variable
                        pat.MakeAConstructor();
                    }
                }
                else
                {
                    if (MutateCSharp.Schemata423.ReplaceBinExprOp_12(653L, ctor.Formals.Count, pat.Arguments.Count))
                    {
                        ReportError(pat.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(658L, "pattern for constructor {0} has wrong number of formals (found {1}, expected {2})"), pat.Id, pat.Arguments.Count, ctor.Formals.Count);
                    }
                }
                // build the type-parameter substitution map for this use of the datatype
                Contract.Assert(dtd.TypeArgs.Count == sourceTypeArguments.Count);  // follows from the type previously having been successfully resolved
                var subst = PreType.PreTypeSubstMap(dtd.TypeArgs, sourceTypeArguments);
                // recursively call ResolveCasePattern on each of the arguments
                var prevErrorCount = ErrorCount;
                var j = MutateCSharp.Schemata423.ReplaceNumericConstant_6(659L, 0);
                if (pat.Arguments != null)
                {
                    foreach (var arg in pat.Arguments)
                    {
                        if (MutateCSharp.Schemata423.ReplaceBinExprOp_13(663L, j, ctor.Formals.Count))
                        {
                            var formal = ctor.Formals[j];
                            var st = formal.PreType.Substitute(subst);
                            ResolveCasePattern(arg, st, resolutionContext.WithGhost(MutateCSharp.Schemata423.ReplaceBinExprOp_32(668L, () => resolutionContext.IsGhost, () => formal.IsGhost)));
                        }

                        MutateCSharp.Schemata423.ReplacePostfixUnaryExprOp_7(674L, ref j);
                    }
                }
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_16(685L, () => MutateCSharp.Schemata423.ReplaceBinExprOp_14(675L, ErrorCount, prevErrorCount), () => MutateCSharp.Schemata423.ReplaceBinExprOp_14(680L, j, ctor.Formals.Count)))
                {
                    pat.AssembleExprPreType(sourceTypeArguments);
                }
            }
        }

        /// <summary>
        /// The return value is false iff there is an error in resolving the datatype value.
        /// If there is an error, then an error message is emitted iff complain is true.
        /// </summary>
        private bool ResolveDatatypeValue(ResolutionContext resolutionContext, DatatypeValue dtv, DatatypeDecl datatypeDecl, DPreType ty, bool complain = true)
        {
            Contract.Requires(resolutionContext != null);
            Contract.Requires(dtv != null);
            Contract.Requires(datatypeDecl != null);
            Contract.Requires(ty == null || (ty.Decl == datatypeDecl && ty.Arguments.Count == datatypeDecl.TypeArgs.Count));

            var ok = MutateCSharp.Schemata423.ReplaceBooleanConstant_4(691L, true);
            List<PreType> gt;
            if (MutateCSharp.Schemata423.ReplaceBinExprOp_8(692L, ty, null))
            {
                gt = datatypeDecl.TypeArgs.ConvertAll(tp => CreatePreTypeProxy($"datatype type parameter '{tp.Name}'"));
            }
            else
            {
                gt = ty.Arguments;
            }
            dtv.InferredPreTypeArgs.AddRange(gt);
            // Construct a resolved type directly, since we know the declaration is datatypeDecl.
            dtv.PreType = new DPreType(datatypeDecl, gt);

            if (!datatypeDecl.ConstructorsByName.TryGetValue(dtv.MemberName, out var ctor))
            {
                ok = MutateCSharp.Schemata423.ReplaceBooleanConstant_4(693L, false);
                if (complain)
                {
                    ReportError(dtv.tok, MutateCSharp.Schemata423.ReplaceStringConstant_1(694L, "undeclared constructor {0} in datatype {1}"), dtv.MemberName, dtv.DatatypeName);
                }
            }
            else
            {
                Contract.Assert(ctor != null); // follows from postcondition of TryGetValue
                dtv.Ctor = ctor;
            }
            if (MutateCSharp.Schemata423.ReplaceBinExprOp_16(696L, () => complain, () => MutateCSharp.Schemata423.ReplaceBinExprOp_39(695L, ctor, null)))
            {
                var subst = PreType.PreTypeSubstMap(datatypeDecl.TypeArgs, gt);
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

            return MutateCSharp.Schemata423.ReplaceBinExprOp_16(707L, () => ok, () => MutateCSharp.Schemata423.ReplaceBinExprOp_14(702L, ctor.Formals.Count, dtv.Arguments.Count));
        }

        PreType ResolveSingleSelectionExpr(IToken tok, PreType collectionPreType, Expression index)
        {
            var resultPreType = CreatePreTypeProxy(MutateCSharp.Schemata423.ReplaceStringConstant_1(713L, "selection []"));
            Constraints.AddGuardedConstraint(() =>
            {
                var sourcePreType = Constraints.ApproximateReceiverType(collectionPreType, null);
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_31(714L, sourcePreType, null))
                {
                    var ancestorPreType = AncestorPreType(sourcePreType);
                    var familyDeclName = ancestorPreType.Decl.Name;
                    switch (familyDeclName)
                    {
                        case PreType.TypeNameArray:
                        case PreType.TypeNameSeq:
                            ConstrainToIntFamilyOrBitvector(index.PreType, index.tok, "index expression must have an integer or bitvector type (got {0})");
                            AddSubtypeConstraint(resultPreType, ancestorPreType.Arguments[0], tok, "type does not agree with element type {1} (got {0})");
                            break;
                            break;
                        case PreType.TypeNameMultiset:
                            AddSubtypeConstraint(ancestorPreType.Arguments[0], index.PreType, index.tok, "type does not agree with element type {0} (got {1})");
                            ConstrainToIntFamily(resultPreType, tok, "multiset multiplicity must have an integer type (got {0})");
                            break;
                            break;
                        case PreType.TypeNameMap:
                        case PreType.TypeNameImap:
                            AddSubtypeConstraint(ancestorPreType.Arguments[0], index.PreType, index.tok, "type does not agree with domain type {0} (got {1})");
                            AddSubtypeConstraint(resultPreType, ancestorPreType.Arguments[1], tok, "type does not agree with value type of {1} (got {0})");
                            break;
                            break;
                        default:
                            ReportError(tok, "element selection requires a sequence, array, multiset, or map (got {0})", sourcePreType);
                            break;
                            break;
                    }
                    return MutateCSharp.Schemata423.ReplaceBooleanConstant_4(715L, true);
                }
                return MutateCSharp.Schemata423.ReplaceBooleanConstant_4(716L, false);
            });
            return resultPreType;
        }

        void ResolveRangeSelectionExpr(IToken tok, PreType sourceCollectionPreType, Expression expr, Expression e0, Expression e1)
        {
            var resultElementPreType = CreatePreTypeProxy(MutateCSharp.Schemata423.ReplaceStringConstant_1(717L, "index-range selection elements"));
            SetupCollectionProducingExpr(PreType.TypeNameSeq, MutateCSharp.Schemata423.ReplaceStringConstant_1(718L, "index-range selection"), expr, resultElementPreType);

            if (MutateCSharp.Schemata423.ReplaceBinExprOp_5(719L, e0, null))
            {
                ConstrainToIntFamilyOrBitvector(e0.PreType, e0.tok,
        MutateCSharp.Schemata423.ReplaceStringConstant_1(720L, "multi-element selection position expression must have an integer or bitvector type (got {0})"));
            }
            if (MutateCSharp.Schemata423.ReplaceBinExprOp_5(721L, e1, null))
            {
                ConstrainToIntFamilyOrBitvector(e1.PreType, e1.tok,
        MutateCSharp.Schemata423.ReplaceStringConstant_1(722L, "multi-element selection position expression must have an integer or bitvector type (got {0})"));
            }

            // In the expression s[e0..e1], correlate the type of s with the result type.
            //   - If s is a sequence type, then the result must be of the same seq or newtype-seq type, with a co-variant element pre-type
            //   - If s is an array type, then the result is allowed to be any seq or newtype-seq with a co-variant element pre-type
            Constraints.AddGuardedConstraint(() =>
            {
                if (sourceCollectionPreType.NormalizeWrtScope() is DPreType sourcePreType)
                {
                    var familyDeclName = AncestorName(sourcePreType);
                    switch (familyDeclName)
                    {
                        case PreType.TypeNameSeq:
                            AddSubtypeConstraint(expr.PreType, sourceCollectionPreType, tok,
                              "resulting sequence ({0}) type does not agree with source sequence type ({1})");
                            break;
                            break;
                        case PreType.TypeNameArray:
                            AddSubtypeConstraint(resultElementPreType, AncestorPreType(sourcePreType).Arguments[0], tok,
                              "type does not agree with element type {1} (got {0})");
                            break;
                            break;
                        default:
                            ReportError(tok, "multi-selection of elements requires a sequence or array (got {0})", sourceCollectionPreType);
                            break;
                            break;
                    }
                    return MutateCSharp.Schemata423.ReplaceBooleanConstant_4(723L, true);
                }
                return MutateCSharp.Schemata423.ReplaceBooleanConstant_4(724L, false);
            });
        }

        /// <summary>
        /// Desugar the elphant-operator expression
        ///     var x: T :- E; Body
        /// into
        ///     var burrito := E;
        ///     if button.IsFailure() then
        ///       burrito.PropagateFailure()
        ///     else
        ///       var x: T := burrito.Extract();
        ///       Body
        /// and desugar the elephant-operator expression
        ///     :- E; Body
        /// into
        ///     var burrito := E;
        ///     if button.IsFailure() then
        ///       burrito.PropagateFailure()
        ///     else
        ///       Body
        /// </summary>
        public Expression DesugarElephantExpr(LetOrFailExpr expr, ResolutionContext resolutionContext)
        {
            // Using the famous monad/burrito analogy, the following variable denotes the burrito
            var burrito = resolver.FreshTempVarName(MutateCSharp.Schemata423.ReplaceStringConstant_1(725L, "valueOrError"), resolutionContext.CodeContext);
            var burritoType = new InferredTypeProxy();
            // "var burrito := E;"
            return resolver.LetVarIn(expr.tok, burrito, burritoType, expr.Rhs,
              // "if burrito.IsFailure()"
              new ITEExpr(expr.tok, MutateCSharp.Schemata423.ReplaceBooleanConstant_4(726L, false), resolver.VarDotFunction(expr.tok, burrito, MutateCSharp.Schemata423.ReplaceStringConstant_1(727L, "IsFailure")),
                // "then burrito.PropagateFailure()"
                resolver.VarDotFunction(expr.tok, burrito, MutateCSharp.Schemata423.ReplaceStringConstant_1(728L, "PropagateFailure")),
      MutateCSharp.Schemata423.ReplaceBinExprOp_40(729L,
                // "else"
                expr.Lhs, null
      )
                  // "Body"
                  ? expr.Body
                  // "var x: T := burrito.Extract(); Body"
                  : resolver.LetPatIn(expr.tok, expr.Lhs, resolver.VarDotFunction(expr.tok, burrito, MutateCSharp.Schemata423.ReplaceStringConstant_1(730L, "Extract")), expr.Body)));
        }

        private void EnsureSupportsErrorHandling(IToken tok, DPreType burritoPreType, bool expectExtract, ResolutionContext resolutionContext, [CanBeNull] string keyword)
        {
            Contract.Requires(tok != null);
            Contract.Requires(burritoPreType != null);

            var (memberIsFailure, _) = FindMember(tok, burritoPreType, MutateCSharp.Schemata423.ReplaceStringConstant_1(731L, "IsFailure"), resolutionContext);
            var (memberPropagate, _) = FindMember(tok, burritoPreType, MutateCSharp.Schemata423.ReplaceStringConstant_1(732L, "PropagateFailure"), resolutionContext);
            var (memberExtract, _) = FindMember(tok, burritoPreType, MutateCSharp.Schemata423.ReplaceStringConstant_1(733L, "Extract"), resolutionContext, reportErrorOnMissingMember: expectExtract);

            if (keyword != null)
            {
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_32(742L, () => MutateCSharp.Schemata423.ReplaceBinExprOp_41(734L, memberIsFailure, null), () => MutateCSharp.Schemata423.ReplaceBinExprOp_42(736L, () => (MutateCSharp.Schemata423.ReplaceBinExprOp_27(735L, memberExtract, null)), () => expectExtract)))
                {
                    // more details regarding which methods are missing have already been reported by regular resolution
                    var requiredMembers = expectExtract
                      ? MutateCSharp.Schemata423.ReplaceStringConstant_1(748L, "members IsFailure() and Extract()"
          ) : MutateCSharp.Schemata423.ReplaceStringConstant_1(749L, "member IsFailure(), but not Extract()");
                    ReportError(tok, $"right-hand side of ':- {keyword}', which is of type '{burritoPreType}', must have {requiredMembers}");
                }
            }
            else
            {
                if (MutateCSharp.Schemata423.ReplaceBinExprOp_32(765L, () => MutateCSharp.Schemata423.ReplaceBinExprOp_32(752L, () => MutateCSharp.Schemata423.ReplaceBinExprOp_41(750L, memberIsFailure, null), () => MutateCSharp.Schemata423.ReplaceBinExprOp_41(751L, memberPropagate, null)), () => MutateCSharp.Schemata423.ReplaceBinExprOp_42(759L, () => (MutateCSharp.Schemata423.ReplaceBinExprOp_27(758L, memberExtract, null)), () => expectExtract)))
                {
                    // more details regarding which methods are missing have already been reported by regular resolution
                    var requiredMembers = expectExtract ? MutateCSharp.Schemata423.ReplaceStringConstant_1(771L, "IsFailure(), PropagateFailure(), and Extract()") : MutateCSharp.Schemata423.ReplaceStringConstant_1(772L, "IsFailure() and PropagateFailure(), but not Extract()");
                    ReportError(tok, $"right-hand side of :- operator, which is of type '{burritoPreType}', must have members {requiredMembers}");
                }
            }

            // The following checks are not necessary, because the ghost mismatch is caught later.
            // However, the error messages here are much clearer.
            if (MutateCSharp.Schemata423.ReplaceBinExprOp_16(774L, () => MutateCSharp.Schemata423.ReplaceBinExprOp_27(773L, memberIsFailure, null), () => memberIsFailure.IsGhost))
            {
                ReportError(tok, $"the IsFailure() member must not be ghost (type {burritoPreType} used in RHS of :- operator)");
            }
            if (MutateCSharp.Schemata423.ReplaceBinExprOp_16(787L, () => MutateCSharp.Schemata423.ReplaceBinExprOp_16(781L, () => keyword == null, () => MutateCSharp.Schemata423.ReplaceBinExprOp_27(780L, memberPropagate, null)), () => memberPropagate.IsGhost))
            {
                ReportError(tok, $"the PropagateFailure() member must not be ghost (type {burritoPreType} used in RHS of :- operator)");
            }
        }

    }
}
