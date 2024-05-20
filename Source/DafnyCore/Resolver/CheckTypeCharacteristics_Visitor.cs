using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata390
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT390");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplacePostfixUnaryExprOp_3(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
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

        internal static bool ReplaceBinExprOp_10(long mutantId, Microsoft.Dafny.TypeParameter.EqualitySupportValue argument1, Microsoft.Dafny.TypeParameter.EqualitySupportValue argument2)
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

        internal static string ReplaceStringConstant_9(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static int ReplaceNumericConstant_1(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.BoundVar argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, object argument2)
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

        internal static bool ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public
/// <summary>
/// This visitor checks that type characteristics are respected in all (implicitly or explicitly)
/// declared types. Note that equality-support is checked only in compiled contexts.
/// In addition, this visitor checks that operations that require equality are applied to
/// types that really do support equality; this, too, is checked only in compiled contexts.
/// </summary>
class CheckTypeCharacteristics_Visitor : ResolverTopDownVisitor<bool>
    {
        public CheckTypeCharacteristics_Visitor(ErrorReporter reporter)
          : base(reporter)
        {
            Contract.Requires(reporter != null);
        }


        public static bool CanCompareWith(Expression expr)
        {
            Contract.Requires(expr != null);
            if (expr.Type.SupportsEquality)
            {
                return MutateCSharp.Schemata390.ReplaceBooleanConstant_0(1L, true);
            }
            expr = expr.Resolved;
            if (expr is DatatypeValue datatypeValue && !datatypeValue.Ctor.EnclosingDatatype.HasGhostVariant)
            {
                for (var i = MutateCSharp.Schemata390.ReplaceNumericConstant_1(2L, 0); MutateCSharp.Schemata390.ReplaceBinExprOp_2(6L, i, datatypeValue.Ctor.Formals.Count); MutateCSharp.Schemata390.ReplacePostfixUnaryExprOp_3(11L, ref i))
                {
                    if (datatypeValue.Ctor.Formals[i].IsGhost)
                    {
                        return MutateCSharp.Schemata390.ReplaceBooleanConstant_0(12L, false);
                    }
                    else if (!CanCompareWith(datatypeValue.Arguments[i]))
                    {
                        return MutateCSharp.Schemata390.ReplaceBooleanConstant_0(13L, false);
                    }
                }
                return MutateCSharp.Schemata390.ReplaceBooleanConstant_0(14L, true);
            }
            else if (expr is DisplayExpression)
            {
                var e = (DisplayExpression)expr;
                return MutateCSharp.Schemata390.ReplaceBinExprOp_4(19L, e.Elements.Count, MutateCSharp.Schemata390.ReplaceNumericConstant_1(15L, 0));
            }
            else if (expr is MapDisplayExpr)
            {
                var e = (MapDisplayExpr)expr;
                return MutateCSharp.Schemata390.ReplaceBinExprOp_4(28L, e.Elements.Count, MutateCSharp.Schemata390.ReplaceNumericConstant_1(24L, 0));
            }
            return MutateCSharp.Schemata390.ReplaceBooleanConstant_0(33L, false);
        }

        protected override bool VisitOneStmt(Statement stmt, ref bool inGhostContext)
        {
            if (stmt.IsGhost)
            {
                inGhostContext = MutateCSharp.Schemata390.ReplaceBooleanConstant_0(34L, true);
            }
            // In the sequel, do two things:
            //  * Call VisitType on any type that occurs in the statement
            //  * If the statement introduces ghost components, handle those components here
            //    rather than letting the default visitor handle them
            if (stmt is VarDeclStmt)
            {
                var s = (VarDeclStmt)stmt;
                foreach (var v in s.Locals)
                {
                    VisitType(v.Tok, v.Type, inGhostContext || v.IsGhost);
                }
            }
            else if (stmt is VarDeclPattern)
            {
                var s = (VarDeclPattern)stmt;
                foreach (var v in s.LocalVars)
                {
                    VisitType(v.Tok, v.Type, inGhostContext || v.IsGhost);
                }
            }
            else if (stmt is AssignStmt)
            {
                var s = (AssignStmt)stmt;
                if (s.Rhs is TypeRhs tRhs)
                {
                    VisitType(tRhs.Tok, tRhs.Type, inGhostContext);
                }
            }
            else if (stmt is AssignSuchThatStmt)
            {
                var s = (AssignSuchThatStmt)stmt;
                Visit(Attributes.SubExpressions(s.Attributes), MutateCSharp.Schemata390.ReplaceBooleanConstant_0(35L, true));
                Visit(s.Expr, inGhostContext);
                foreach (var lhs in s.Lhss)
                {
                    Visit(lhs, inGhostContext);
                }
                return MutateCSharp.Schemata390.ReplaceBooleanConstant_0(36L, false);
            }
            else if (stmt is WhileStmt)
            {
                var s = (WhileStmt)stmt;
                // all subexpressions are ghost, except the guard
                Visit(s.LoopSpecificationExpressions, MutateCSharp.Schemata390.ReplaceBooleanConstant_0(37L, true));
                if (MutateCSharp.Schemata390.ReplaceBinExprOp_5(38L, s.Guard, null))
                {
                    Visit(s.Guard, inGhostContext);
                }
                Visit(s.SubStatements, inGhostContext);
                return MutateCSharp.Schemata390.ReplaceBooleanConstant_0(39L, false);
            }
            else if (stmt is AlternativeLoopStmt)
            {
                var s = (AlternativeLoopStmt)stmt;
                // all subexpressions are ghost, except the guards
                Visit(s.LoopSpecificationExpressions, MutateCSharp.Schemata390.ReplaceBooleanConstant_0(40L, true));
                foreach (var alt in s.Alternatives)
                {
                    Visit(alt.Guard, inGhostContext);
                }
                Visit(s.SubStatements, inGhostContext);
                return MutateCSharp.Schemata390.ReplaceBooleanConstant_0(41L, false);
            }
            else if (stmt is ForLoopStmt)
            {
                var s = (ForLoopStmt)stmt;
                // all subexpressions are ghost, except the bounds
                Visit(s.LoopSpecificationExpressions, MutateCSharp.Schemata390.ReplaceBooleanConstant_0(42L, true));
                Visit(s.Start, inGhostContext);
                if (MutateCSharp.Schemata390.ReplaceBinExprOp_5(43L, s.End, null))
                {
                    Visit(s.End, inGhostContext);
                }
                Visit(s.SubStatements, inGhostContext);
                return MutateCSharp.Schemata390.ReplaceBooleanConstant_0(44L, false);
            }
            else if (stmt is CallStmt)
            {
                var s = (CallStmt)stmt;
                CheckTypeInstantiation(s.Tok, s.Method.WhatKind, s.Method.Name, s.Method.TypeArgs, s.MethodSelect.TypeApplication_JustMember, inGhostContext);
                // recursively visit all subexpressions, noting that some of them may correspond to ghost formal parameters
                Contract.Assert(s.Lhs.Count == s.Method.Outs.Count);
                for (var i = MutateCSharp.Schemata390.ReplaceNumericConstant_1(45L, 0); MutateCSharp.Schemata390.ReplaceBinExprOp_2(49L, i, s.Method.Outs.Count); MutateCSharp.Schemata390.ReplacePostfixUnaryExprOp_3(54L, ref i))
                {
                    Visit(s.Lhs[i], inGhostContext || s.Method.Outs[i].IsGhost);
                }
                Visit(s.Receiver, inGhostContext);
                Contract.Assert(s.Args.Count == s.Method.Ins.Count);
                for (var i = MutateCSharp.Schemata390.ReplaceNumericConstant_1(55L, 0); MutateCSharp.Schemata390.ReplaceBinExprOp_2(59L, i, s.Method.Ins.Count); MutateCSharp.Schemata390.ReplacePostfixUnaryExprOp_3(64L, ref i))
                {
                    Visit(s.Args[i], inGhostContext || s.Method.Ins[i].IsGhost);
                }
                return MutateCSharp.Schemata390.ReplaceBooleanConstant_0(65L, false);
            }
            else if (stmt is ForallStmt)
            {
                var s = (ForallStmt)stmt;
                foreach (var v in s.BoundVars)
                {
                    VisitType(v.Tok, v.Type, inGhostContext);
                }
                // do substatements and subexpressions, noting that ensures clauses are ghost
                Visit(Attributes.SubExpressions(s.Attributes), MutateCSharp.Schemata390.ReplaceBooleanConstant_0(66L, true));
                if (MutateCSharp.Schemata390.ReplaceBinExprOp_5(67L, s.Range, null))
                {
                    Visit(s.Range, inGhostContext);
                }
                foreach (var ee in s.Ens)
                {
                    Visit(Attributes.SubExpressions(ee.Attributes), MutateCSharp.Schemata390.ReplaceBooleanConstant_0(68L, true));
                    Visit(ee.E, MutateCSharp.Schemata390.ReplaceBooleanConstant_0(69L, true));
                }
                Visit(s.SubStatements, inGhostContext);
                return MutateCSharp.Schemata390.ReplaceBooleanConstant_0(70L, false);
            }
            else if (stmt is ExpectStmt)
            {
                var s = (ExpectStmt)stmt;
                Visit(Attributes.SubExpressions(s.Attributes), MutateCSharp.Schemata390.ReplaceBooleanConstant_0(71L, true));
                Visit(s.Expr, inGhostContext);
                if (MutateCSharp.Schemata390.ReplaceBinExprOp_5(72L, s.Message, null))
                {
                    Visit(s.Message, inGhostContext);
                }
                return MutateCSharp.Schemata390.ReplaceBooleanConstant_0(73L, false);
            }
            return MutateCSharp.Schemata390.ReplaceBooleanConstant_0(74L, true);
        }

        protected override bool VisitOneExpr(Expression expr, ref bool inGhostContext)
        {
            // Do two things:
            //  * Call VisitType on any type that occurs in the statement
            //  * If the expression introduces ghost components, handle those components here
            //    rather than letting the default visitor handle them
            if (expr is BinaryExpr && !inGhostContext)
            {
                var e = (BinaryExpr)expr;
                var t0 = e.E0.Type.NormalizeExpand();
                var t1 = e.E1.Type.NormalizeExpand();
                switch (e.Op)
                {
                    case BinaryExpr.Opcode.Eq:
                    case BinaryExpr.Opcode.Neq:
                        if (t0.IsTraitType || t1.IsTraitType)
                        {
                            // Non-reference-type traits do not support equality, but reference-trait types do.
                            if (!t0.SupportsEquality)
                            {
                                reporter.Error(MessageSource.Resolver, e.E0, "{0} can only be applied to expressions of types that support equality (got {1}){2}", BinaryExpr.OpcodeString(e.Op), t0, TypeEqualityErrorMessageHint(t0));
                            }
                            else if (!t1.SupportsEquality)
                            {
                                reporter.Error(MessageSource.Resolver, e.E1, "{0} can only be applied to expressions of types that support equality (got {1}){2}", BinaryExpr.OpcodeString(e.Op), t1, TypeEqualityErrorMessageHint(t1));
                            }
                        }
                        else if (CanCompareWith(e.E0) || CanCompareWith(e.E1))
                        {
                            // These are special cases with values that can always be compared against--for example, a datatype value (like Nil) that takes no parameters
                        }
                        else if (!t0.PartiallySupportsEquality)
                        {
                            reporter.Error(MessageSource.Resolver, e.E0, "{0} can only be applied to expressions of types that support equality (got {1}){2}", BinaryExpr.OpcodeString(e.Op), t0, TypeEqualityErrorMessageHint(t0));
                        }
                        else if (!t1.PartiallySupportsEquality)
                        {
                            reporter.Error(MessageSource.Resolver, e.E1, "{0} can only be applied to expressions of types that support equality (got {1}){2}", BinaryExpr.OpcodeString(e.Op), t1, TypeEqualityErrorMessageHint(t1));
                        }
                        break;
                        break;
                    default:
                        switch (e.ResolvedOp)
                        {
                            // Note, all operations on sets, multisets, and maps are guaranteed to work because of restrictions placed on how
                            // these types are instantiated.  (Except: This guarantee does not apply to equality on maps, because the Range type
                            // of maps is not restricted, only the Domain type.  However, the equality operator is checked above.)
                            case BinaryExpr.ResolvedOpcode.InSeq:
                            case BinaryExpr.ResolvedOpcode.NotInSeq:
                            case BinaryExpr.ResolvedOpcode.Prefix:
                            case BinaryExpr.ResolvedOpcode.ProperPrefix:
                                if (!t1.SupportsEquality)
                                {
                                    reporter.Error(MessageSource.Resolver, e.E1, "{0} can only be applied to expressions of sequence types that support equality (got {1}){2}", BinaryExpr.OpcodeString(e.Op), t1, TypeEqualityErrorMessageHint(t1));
                                }
                                else if (!t0.SupportsEquality)
                                {
                                    if (e.ResolvedOp == BinaryExpr.ResolvedOpcode.InSet || e.ResolvedOp == BinaryExpr.ResolvedOpcode.NotInSeq)
                                    {
                                        reporter.Error(MessageSource.Resolver, e.E0, "{0} can only be applied to expressions of types that support equality (got {1}){2}", BinaryExpr.OpcodeString(e.Op), t0, TypeEqualityErrorMessageHint(t0));
                                    }
                                    else
                                    {
                                        reporter.Error(MessageSource.Resolver, e.E0, "{0} can only be applied to expressions of sequence types that support equality (got {1}){2}", BinaryExpr.OpcodeString(e.Op), t0, TypeEqualityErrorMessageHint(t0));
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                        break;
                }
            }
            else if (expr is ComprehensionExpr)
            {
                var e = (ComprehensionExpr)expr;
                foreach (var bv in e.BoundVars)
                {
                    VisitType(bv.tok, bv.Type, inGhostContext);
                }
            }
            else if (expr is LetExpr)
            {
                var e = (LetExpr)expr;
                Visit(Attributes.SubExpressions(e.Attributes), MutateCSharp.Schemata390.ReplaceBooleanConstant_0(75L, true));
                if (e.Exact)
                {
                    Contract.Assert(e.LHSs.Count == e.RHSs.Count);
                    for (var i = MutateCSharp.Schemata390.ReplaceNumericConstant_1(76L, 0); MutateCSharp.Schemata390.ReplaceBinExprOp_2(80L, i, e.LHSs.Count); MutateCSharp.Schemata390.ReplacePostfixUnaryExprOp_3(85L, ref i))
                    {
                        // The VisitPattern function visits all BoundVar's in a pattern and returns
                        // "true" if all variables are ghost.
                        bool VisitPattern(CasePattern<BoundVar> pat, bool patternGhostContext)
                        {
                            if (MutateCSharp.Schemata390.ReplaceBinExprOp_6(86L, pat.Var, null))
                            {
                                VisitType(pat.tok, pat.Var.Type, MutateCSharp.Schemata390.ReplaceBinExprOp_7(87L, () => patternGhostContext, () => pat.Var.IsGhost));
                                return pat.Var.IsGhost;
                            }
                            else
                            {
                                var allGhost = MutateCSharp.Schemata390.ReplaceBooleanConstant_0(93L, true);
                                Contract.Assert(pat.Ctor != null);
                                Contract.Assert(pat.Ctor.Formals.Count == pat.Arguments.Count);
                                for (var i = MutateCSharp.Schemata390.ReplaceNumericConstant_1(94L, 0); MutateCSharp.Schemata390.ReplaceBinExprOp_2(98L, i, pat.Ctor.Formals.Count); MutateCSharp.Schemata390.ReplacePostfixUnaryExprOp_3(103L, ref i))
                                {
                                    var formal = pat.Ctor.Formals[i];
                                    var arg = pat.Arguments[i];
                                    // don't use short-circuit booleans in the following line, because we want to visit all nested patterns
                                    allGhost &= VisitPattern(arg, MutateCSharp.Schemata390.ReplaceBinExprOp_7(104L, () => patternGhostContext, () => formal.IsGhost));
                                }
                                return allGhost;
                            }

                            return default;
                        }

                        var allGhosts = VisitPattern(e.LHSs[i], inGhostContext);
                        Visit(e.RHSs[i], inGhostContext || allGhosts);
                    }
                }
                else
                {
                    Contract.Assert(e.RHSs.Count == 1);
                    var allGhost = MutateCSharp.Schemata390.ReplaceBooleanConstant_0(110L, true);
                    foreach (var bv in e.BoundVars)
                    {
                        if (!bv.IsGhost)
                        {
                            allGhost = MutateCSharp.Schemata390.ReplaceBooleanConstant_0(111L, false);
                        }
                        VisitType(bv.tok, bv.Type, inGhostContext || bv.IsGhost);
                    }
                    Visit(e.RHSs[MutateCSharp.Schemata390.ReplaceNumericConstant_1(112L, 0)], inGhostContext || allGhost);
                }
                Visit(e.Body, inGhostContext);
                return MutateCSharp.Schemata390.ReplaceBooleanConstant_0(116L, false);
            }
            else if (expr is MemberSelectExpr)
            {
                var e = (MemberSelectExpr)expr;
                if (MutateCSharp.Schemata390.ReplaceBinExprOp_7(117L, () => e.Member is Function, () => e.Member is Method))
                {
                    CheckTypeInstantiation(e.tok, e.Member.WhatKind, e.Member.Name, ((ICallable)e.Member).TypeArgs, e.TypeApplication_JustMember, inGhostContext);
                }
            }
            else if (expr is FunctionCallExpr)
            {
                var e = (FunctionCallExpr)expr;
                CheckTypeInstantiation(e.tok, e.Function.WhatKind, e.Function.Name, e.Function.TypeArgs, e.TypeApplication_JustFunction, inGhostContext);
                // recursively visit all subexpressions (all actual parameters), noting which ones correspond to ghost formal parameters
                Visit(e.Receiver, inGhostContext);
                Contract.Assert(e.Args.Count == e.Function.Ins.Count);
                for (var i = MutateCSharp.Schemata390.ReplaceNumericConstant_1(123L, 0); MutateCSharp.Schemata390.ReplaceBinExprOp_2(127L, i, e.Args.Count); MutateCSharp.Schemata390.ReplacePostfixUnaryExprOp_3(132L, ref i))
                {
                    Visit(e.Args[i], inGhostContext || e.Function.Ins[i].IsGhost);
                }
                return MutateCSharp.Schemata390.ReplaceBooleanConstant_0(133L, false);  // we've done what there is to be done
            }
            else if (expr is DatatypeValue)
            {
                var e = (DatatypeValue)expr;
                VisitType(expr.tok, expr.Type, inGhostContext);
                // recursively visit all subexpressions (all actual parameters), noting which ones correspond to ghost formal parameters
                Contract.Assert(e.Arguments.Count == e.Ctor.Formals.Count);
                for (var i = MutateCSharp.Schemata390.ReplaceNumericConstant_1(134L, 0); MutateCSharp.Schemata390.ReplaceBinExprOp_2(138L, i, e.Arguments.Count); MutateCSharp.Schemata390.ReplacePostfixUnaryExprOp_3(143L, ref i))
                {
                    Visit(e.Arguments[i], inGhostContext || e.Ctor.Formals[i].IsGhost);
                }
                return MutateCSharp.Schemata390.ReplaceBooleanConstant_0(144L, false);  // we've done what there is to be done
            }
            else if (MutateCSharp.Schemata390.ReplaceBinExprOp_7(169L, () => MutateCSharp.Schemata390.ReplaceBinExprOp_7(163L, () => MutateCSharp.Schemata390.ReplaceBinExprOp_7(157L, () => MutateCSharp.Schemata390.ReplaceBinExprOp_7(151L, () => MutateCSharp.Schemata390.ReplaceBinExprOp_7(145L, () => expr is SetDisplayExpr, () => expr is MultiSetDisplayExpr), () => expr is MapDisplayExpr), () => expr is SeqConstructionExpr), () => expr is MultiSetFormingExpr), () => expr is StaticReceiverExpr))
            {
                // This catches other expressions whose type may potentially be illegal
                VisitType(expr.tok, expr.Type, inGhostContext);
            }
            else if (expr is StmtExpr)
            {
                var e = (StmtExpr)expr;
                Visit(e.S, MutateCSharp.Schemata390.ReplaceBooleanConstant_0(175L, true));
                Visit(e.E, inGhostContext);
                return MutateCSharp.Schemata390.ReplaceBooleanConstant_0(176L, false);
            }
            return MutateCSharp.Schemata390.ReplaceBooleanConstant_0(177L, true);
        }

        public void VisitType(IToken tok, Type type, bool inGhostContext)
        {
            Contract.Requires(tok != null);
            Contract.Requires(type != null);
            type = type.Normalize();  // we only do a .Normalize() here, because we want to keep stop at any type synonym or subset type
            if (type is BasicType)
            {
                // fine
            }
            else if (type is SetType)
            {
                var st = (SetType)type;
                var argType = st.Arg;
                if (MutateCSharp.Schemata390.ReplaceBinExprOp_8(178L, () => !inGhostContext, () => !argType.SupportsEquality))
                {
                    reporter.Error(MessageSource.Resolver, tok, MutateCSharp.Schemata390.ReplaceStringConstant_9(184L, "{2}set argument type must support equality (got {0}){1}"), argType, TypeEqualityErrorMessageHint(argType), st.Finite ? "" : MutateCSharp.Schemata390.ReplaceStringConstant_9(185L, "i"));
                }
                VisitType(tok, argType, inGhostContext);

            }
            else if (type is MultiSetType)
            {
                var argType = ((MultiSetType)type).Arg;
                if (MutateCSharp.Schemata390.ReplaceBinExprOp_8(186L, () => !inGhostContext, () => !argType.SupportsEquality))
                {
                    reporter.Error(MessageSource.Resolver, tok, MutateCSharp.Schemata390.ReplaceStringConstant_9(192L, "multiset argument type must support equality (got {0}){1}"), argType, TypeEqualityErrorMessageHint(argType));

                }
                VisitType(tok, argType, inGhostContext);
            }
            else if (type is MapType)
            {
                var mt = (MapType)type;
                if (MutateCSharp.Schemata390.ReplaceBinExprOp_8(193L, () => !inGhostContext, () => !mt.Domain.SupportsEquality))
                {
                    reporter.Error(MessageSource.Resolver, tok, MutateCSharp.Schemata390.ReplaceStringConstant_9(199L, "{2}map domain type must support equality (got {0}){1}"), mt.Domain, TypeEqualityErrorMessageHint(mt.Domain), mt.Finite ? "" : MutateCSharp.Schemata390.ReplaceStringConstant_9(200L, "i"));
                }
                VisitType(tok, mt.Domain, inGhostContext);
                VisitType(tok, mt.Range, inGhostContext);

            }
            else if (type is SeqType)
            {
                Type argType = ((SeqType)type).Arg;
                VisitType(tok, argType, inGhostContext);

            }
            else if (type is UserDefinedType)
            {
                var udt = (UserDefinedType)type;
                Contract.Assert(udt.ResolvedClass != null);
                var formalTypeArgs = udt.ResolvedClass.TypeArgs;
                Contract.Assert(formalTypeArgs != null);
                CheckTypeInstantiation(udt.tok, MutateCSharp.Schemata390.ReplaceStringConstant_9(201L, "type"), udt.ResolvedClass.Name, formalTypeArgs, udt.TypeArgs, inGhostContext);

            }
            else if (type is TypeProxy)
            {
                // the type was underconstrained; this is checked elsewhere, but it is not in violation of the equality-type test
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected type
            }
        }

        void CheckTypeInstantiation(IToken tok, string what, string className, List<TypeParameter> formalTypeArgs, List<Type> actualTypeArgs, bool inGhostContext)
        {
            Contract.Requires(tok != null);
            Contract.Requires(what != null);
            Contract.Requires(className != null);
            Contract.Requires(formalTypeArgs != null);
            Contract.Requires(actualTypeArgs != null);
            Contract.Requires(formalTypeArgs.Count == actualTypeArgs.Count);

            for (var i = MutateCSharp.Schemata390.ReplaceNumericConstant_1(202L, 0); MutateCSharp.Schemata390.ReplaceBinExprOp_2(206L, i, formalTypeArgs.Count); MutateCSharp.Schemata390.ReplacePostfixUnaryExprOp_3(211L, ref i))
            {
                var formal = formalTypeArgs[i];
                var actual = actualTypeArgs[i];
                if (!CheckCharacteristics(formal.Characteristics, actual, inGhostContext, out var whatIsNeeded, out var hint, out _))
                {
                    reporter.Error(MessageSource.Resolver, tok, MutateCSharp.Schemata390.ReplaceStringConstant_9(212L, "type parameter{0} ({1}) passed to {2} {3} must {4} (got {5}){6}"),
            MutateCSharp.Schemata390.ReplaceBinExprOp_4(217L, actualTypeArgs.Count, MutateCSharp.Schemata390.ReplaceNumericConstant_1(213L, 1)) ? "" : MutateCSharp.Schemata390.ReplaceStringConstant_9(222L, " ") + i, formal.Name, what, className, whatIsNeeded, actual, hint);
                }
                VisitType(tok, actual, inGhostContext);
            }
        }

        /// <summary>
        /// Grammatically, "whatIsNeeded" is an imperative that says what to do to be in compliance. Concretely, it is one of the following
        /// strings (not including the words in square brackets):
        ///     * [type X must] contain no references
        ///     * [type X must] support equality
        ///     * [type X must] support auto-initialization
        ///     * [type X must] be nonempty
        /// </summary>
        public static bool CheckCharacteristics(TypeParameter.TypeParameterCharacteristics formal, Type actual, bool inGhostContext,
          out string whatIsNeeded, out string hint, out RefinementErrors.ErrorId errorId)
        {
            Contract.Ensures(Contract.Result<bool>() || (Contract.ValueAtReturn(out whatIsNeeded) != null && Contract.ValueAtReturn(out hint) != null));
            if (MutateCSharp.Schemata390.ReplaceBinExprOp_8(230L, () => MutateCSharp.Schemata390.ReplaceBinExprOp_8(224L, () => !inGhostContext, () => MutateCSharp.Schemata390.ReplaceBinExprOp_10(223L, formal.EqualitySupport, TypeParameter.EqualitySupportValue.Unspecified)), () => !actual.SupportsEquality))
            {
                whatIsNeeded = MutateCSharp.Schemata390.ReplaceStringConstant_9(236L, "support equality");
                hint = TypeEqualityErrorMessageHint(actual);
                errorId = RefinementErrors.ErrorId.ref_mismatched_type_characteristics_equality;
                return MutateCSharp.Schemata390.ReplaceBooleanConstant_0(237L, false);
            }
            var cl = (actual.Normalize() as UserDefinedType)?.ResolvedClass;
            var tp = (TopLevelDecl)(cl as TypeParameter) ?? cl as AbstractTypeDecl;
            if (MutateCSharp.Schemata390.ReplaceBinExprOp_8(238L, () => formal.HasCompiledValue, () => (inGhostContext ? !actual.IsNonempty : !actual.HasCompilableValue)))
            {
                whatIsNeeded = MutateCSharp.Schemata390.ReplaceStringConstant_9(244L, "support auto-initialization");
                hint = MutateCSharp.Schemata390.ReplaceBinExprOp_11(245L, tp, null) ? "" :
                  string.Format(MutateCSharp.Schemata390.ReplaceStringConstant_9(246L, " (perhaps try declaring {2} '{0}' on line {1} as '{0}(0)', which says it can only be instantiated with a type that supports auto-initialization)"), tp.Name, tp.tok.line, tp.WhatKind);
                errorId = RefinementErrors.ErrorId.ref_mismatched_type_characteristics_autoinit;
                return MutateCSharp.Schemata390.ReplaceBooleanConstant_0(247L, false);
            }
            if (MutateCSharp.Schemata390.ReplaceBinExprOp_8(248L, () => formal.IsNonempty, () => !actual.IsNonempty))
            {
                whatIsNeeded = MutateCSharp.Schemata390.ReplaceStringConstant_9(254L, "be nonempty");
                hint = MutateCSharp.Schemata390.ReplaceBinExprOp_11(255L, tp, null) ? "" :
                  string.Format(MutateCSharp.Schemata390.ReplaceStringConstant_9(256L, " (perhaps try declaring {2} '{0}' on line {1} as '{0}(00)', which says it can only be instantiated with a nonempty type)"), tp.Name, tp.tok.line, tp.WhatKind);
                errorId = RefinementErrors.ErrorId.ref_mismatched_type_characteristics_nonempty;
                return MutateCSharp.Schemata390.ReplaceBooleanConstant_0(257L, false);
            }
            if (MutateCSharp.Schemata390.ReplaceBinExprOp_8(258L, () => formal.ContainsNoReferenceTypes, () => actual.MayInvolveReferences))
            {
                whatIsNeeded = MutateCSharp.Schemata390.ReplaceStringConstant_9(264L, "contain no references");
                hint = MutateCSharp.Schemata390.ReplaceBinExprOp_11(265L, tp, null) ? "" :
                  string.Format(MutateCSharp.Schemata390.ReplaceStringConstant_9(266L, " (perhaps try declaring {2} '{0}' on line {1} as '{0}(!new)', which says it can only be instantiated with a type that contains no references)"), tp.Name, tp.tok.line, tp.WhatKind);
                errorId = RefinementErrors.ErrorId.ref_mismatched_type_characteristics_noreferences;
                return MutateCSharp.Schemata390.ReplaceBooleanConstant_0(267L, false);
            }
            whatIsNeeded = null;
            hint = null;
            errorId = 0; // to please the compiler; this value will not be used by the caller
            return MutateCSharp.Schemata390.ReplaceBooleanConstant_0(268L, true);
        }

        static string TypeEqualityErrorMessageHint(Type argType)
        {
            Contract.Requires(argType != null);
            var cl = (argType.Normalize() as UserDefinedType)?.ResolvedClass;
            var tp = (TopLevelDecl)(cl as TypeParameter) ?? cl as AbstractTypeDecl;
            if (MutateCSharp.Schemata390.ReplaceBinExprOp_12(269L, tp, null))
            {
                return string.Format(MutateCSharp.Schemata390.ReplaceStringConstant_9(270L, " (perhaps try declaring {2} '{0}' on line {1} as '{0}(==)', which says it can only be instantiated with a type that supports equality)"), tp.Name, tp.tok.line, tp.WhatKind);
            }
            return "";
        }
    }
}