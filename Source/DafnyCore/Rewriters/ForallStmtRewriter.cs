using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata448
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT448");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_9(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_3(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static string ReplaceStringConstant_4(long mutantId, string argument1)
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

        internal static bool ReplaceBinExprOp_13(long mutantId, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument1, Microsoft.Dafny.BinaryExpr.ResolvedOpcode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, Microsoft.Dafny.IVariable argument1, Microsoft.Dafny.BoundVar argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, Microsoft.Dafny.IdentifierExpr argument1, object argument2)
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

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBinExprOp_8(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.ForallStmtRewriter.ForAllStmtVisitor.ForallStmtTranslationValues> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{

    /// <summary>
    /// Fills the field ForallStmt.EffectiveEnsuresClauses
    /// </summary>
    public class ForallStmtRewriter : IRewriter
    {
        public ForallStmtRewriter(ErrorReporter reporter) : base(reporter)
        {
            Contract.Requires(reporter != null);
        }

        internal override void PostResolveIntermediate(ModuleDefinition m)
        {
            var forallVisitor = new ForAllStmtVisitor(Reporter);
            foreach (var decl in ModuleDefinition.AllCallablesIncludingPrefixDeclarations(m.TopLevelDecls))
            {
                forallVisitor.Visit(decl, MutateCSharp.Schemata448.ReplaceBooleanConstant_0(1L, true));
            }
        }

        public class ForAllStmtVisitor : TopDownVisitor<bool>
        {
            readonly ErrorReporter reporter;
            public ForAllStmtVisitor(ErrorReporter reporter)
            {
                Contract.Requires(reporter != null);
                this.reporter = reporter;
            }
            protected override bool VisitOneStmt(Statement stmt, ref bool st)
            {
                if (stmt is not ForallStmt { CanConvert: true } forallStmt)
                {
                    return MutateCSharp.Schemata448.ReplaceBooleanConstant_0(2L, true); //visit the sub-parts with the same "st"
                }

                switch (forallStmt.Kind)
                {
                    case ForallStmt.BodyKind.Proof:
                        VisitProof(forallStmt);
                        break;
                        break;
                    case ForallStmt.BodyKind.Assign:
                        VisitAssign(forallStmt);
                        break;
                        break;
                    case ForallStmt.BodyKind.Call:
                        VisitCall(forallStmt);
                        break;
                        break;
                    default:
                        Contract.Assert(false);  // unexpected kind
                        break;
                        break;
                }
                return MutateCSharp.Schemata448.ReplaceBooleanConstant_0(3L, true);  //visit the sub-parts with the same "st"
            }

            private static void VisitCall(ForallStmt s)
            {
                var s0 = (CallStmt)s.S0;
                var argsSubstMap = new Dictionary<IVariable, Expression>(); // maps formal arguments to actuals
                Contract.Assert(s0.Method.Ins.Count == s0.Args.Count);
                for (int i = MutateCSharp.Schemata448.ReplaceNumericConstant_1(4L, 0); MutateCSharp.Schemata448.ReplaceBinExprOp_2(8L, i, s0.Method.Ins.Count); MutateCSharp.Schemata448.ReplacePostfixUnaryExprOp_3(13L, ref i))
                {
                    argsSubstMap.Add(s0.Method.Ins[i], s0.Args[i]);
                }

                var substituter = new AlphaConvertingSubstituter(s0.Receiver, argsSubstMap,
                  s0.MethodSelect.TypeArgumentSubstitutionsWithParents());
                // Strengthen the range of the "forall" statement with the precondition of the call, suitably substituted with the actual parameters.
                if (Attributes.Contains(s.Attributes, MutateCSharp.Schemata448.ReplaceStringConstant_4(14L, "_autorequires")))
                {
                    var range = s.Range;
                    foreach (var req in s0.Method.Req)
                    {
                        var p = substituter.Substitute(req.E); // substitute the call's actuals for the method's formals
                        range = Expression.CreateAnd(range, p);
                    }

                    s.Range = range;
                }

                // substitute the call's actuals for the method's formals
                var term = MutateCSharp.Schemata448.ReplaceBinExprOp_5(19L, s0.Method.Ens.Count, MutateCSharp.Schemata448.ReplaceNumericConstant_1(15L, 0
          )) ? substituter.Substitute(s0.Method.Ens[MutateCSharp.Schemata448.ReplaceNumericConstant_1(24L, 0)].E)
                  : Expression.CreateBoolLiteral(new AutoGeneratedToken(s.Tok), MutateCSharp.Schemata448.ReplaceBooleanConstant_0(28L, true));
                for (int i = MutateCSharp.Schemata448.ReplaceNumericConstant_1(29L, 1); MutateCSharp.Schemata448.ReplaceBinExprOp_2(33L, i, s0.Method.Ens.Count); MutateCSharp.Schemata448.ReplacePostfixUnaryExprOp_3(38L, ref i))
                {
                    term = new BinaryExpr(s0.Method.Ens[i].Tok, BinaryExpr.ResolvedOpcode.And, term,
                      substituter.Substitute(s0.Method.Ens[i].E));
                }

                var expr = new ForallExpr(new AutoGeneratedToken(s.Tok), s.RangeToken, s.BoundVars, s.Range, term, s.Attributes)
                {
                    Type = Type.Bool, // resolve here
                    Bounds = s.Bounds
                };
                s.EffectiveEnsuresClauses = new List<Expression> { expr };
            }

            private void VisitAssign(ForallStmt stmt)
            {
                if (MutateCSharp.Schemata448.ReplaceBinExprOp_6(43L, stmt.BoundVars.Count, MutateCSharp.Schemata448.ReplaceNumericConstant_1(39L, 0)))
                {
                    return;
                }

                var s0 = (AssignStmt)stmt.S0;
                if (s0.Rhs is not ExprRhs exprRhs)
                {
                    return;
                }

                List<Expression> exprList = new List<Expression>();
                Expression Fi = null;
                Func<Expression, Expression> lhsBuilder = null;
                var lhs = s0.Lhs.Resolved;
                var i = stmt.BoundVars[MutateCSharp.Schemata448.ReplaceNumericConstant_1(48L, 0)];
                if (MutateCSharp.Schemata448.ReplaceBinExprOp_6(56L, stmt.BoundVars.Count, MutateCSharp.Schemata448.ReplaceNumericConstant_1(52L, 1)))
                {
                    // Detect the following cases:
                    //   0: forall i | R(i) { F(i).f := E(i); }
                    //   1: forall i | R(i) { A[F(i)] := E(i); }
                    //   2: forall i | R(i) { F(i)[N] := E(i); }
                    switch (lhs)
                    {
                        case MemberSelectExpr memberSelect:
                            Fi = memberSelect.Obj;
                            lhsBuilder = e => new MemberSelectExpr(memberSelect.tok, e, memberSelect.MemberName)
                            {
                                Member = memberSelect.Member,
                                TypeApplication_AtEnclosingClass = memberSelect.TypeApplication_AtEnclosingClass,
                                TypeApplication_JustMember = memberSelect.TypeApplication_JustMember,
                                Type = memberSelect.Type
                            };
                            break;
                            break;
                        case SeqSelectExpr ll:
                            {
                                Contract.Assert(ll.SelectOne);
                                if (!FreeVariablesUtil.ContainsFreeVariable(ll.Seq, false, i))
                                {
                                    Fi = ll.E0;
                                    lhsBuilder = e => new SeqSelectExpr(ll.tok, true, ll.Seq, e, null, ll.CloseParen)
                                    {
                                        Type = ll.Type
                                    };
                                }
                                else if (!FreeVariablesUtil.ContainsFreeVariable(ll.E0, false, i))
                                {
                                    Fi = ll.Seq;
                                    lhsBuilder = e => new SeqSelectExpr(ll.tok, true, e, ll.E0, null, ll.CloseParen)
                                    {
                                        Type = ll.Type
                                    };
                                }

                                break;
                            }

                            break;
                    }
                }

                var rhs = exprRhs.Expr;
                bool usedInversion = MutateCSharp.Schemata448.ReplaceBooleanConstant_0(61L, false);
                if (MutateCSharp.Schemata448.ReplaceBinExprOp_7(62L, Fi, null))
                {
                    var j = new BoundVar(i.tok, i.Name + MutateCSharp.Schemata448.ReplaceStringConstant_4(63L, "#inv"), Fi.Type);
                    var jj = Expression.CreateIdentExpr(j);
                    var jList = new List<BoundVar>() { j };
                    var range = Expression.CreateAnd(ModuleResolver.GetImpliedTypeConstraint(i, i.Type), stmt.Range);
                    var vals = InvertExpression(i, j, range, Fi);
#if DEBUG_PRINT
          resolve.Options.Writer.WriteLine("DEBUG: Trying to invert:");
          resolve.Options.Writer.WriteLine("DEBUG:   " + Printer.ExprToString(s.Range) + " && " + j.Name + " == " + Printer.ExprToString(Fi));
          if (vals == null) {
            resolve.Options.Writer.WriteLine("DEBUG: Can't");
          } else {
            resolve.Options.Writer.WriteLine("DEBUG: The inverse is the disjunction of the following:");
            foreach (var val in vals) {
              resolve.Options.Writer.WriteLine("DEBUG:   " + Printer.ExprToString(val.Range) + " && " + Printer.ExprToString(val.FInverse) + " == " + i.Name);
            }
          }
#endif
                    if (MutateCSharp.Schemata448.ReplaceBinExprOp_8(64L, vals, null))
                    {
                        foreach (var val in vals)
                        {
                            lhs = lhsBuilder(jj);
                            Attributes attributes = new Attributes(MutateCSharp.Schemata448.ReplaceStringConstant_4(65L, "trigger"), new List<Expression>() { lhs }, stmt.Attributes);
                            var newRhs = Substitute(rhs, i, val.FInverse);
                            var newBounds = SubstituteBoundedPoolList(stmt.Bounds, i, val.FInverse);

                            var msg = string.Format(MutateCSharp.Schemata448.ReplaceStringConstant_4(66L, "rewrite: forall {0}: {1} {2}| {3} {{ {4} := {5}; }}"),
                              j.Name,
                              j.Type.ToString(),
                              Printer.AttributesToString(reporter.Options, attributes),
                              Printer.ExprToString(reporter.Options, val.Range),
                              Printer.ExprToString(reporter.Options, lhs),
                              Printer.ExprToString(reporter.Options, newRhs));
                            reporter.Info(MessageSource.Resolver, stmt.Tok, msg);

                            var expr = new ForallExpr(stmt.Tok, stmt.RangeToken, jList, val.Range,
                              new BinaryExpr(s0.Tok, BinaryExpr.ResolvedOpcode.EqCommon, lhs, newRhs),
                              attributes)
                            {
                                Type = Type.Bool,
                                Bounds = newBounds,
                            };
                            exprList.Add(expr);
                        }

                        usedInversion = MutateCSharp.Schemata448.ReplaceBooleanConstant_0(67L, true);
                    }
                }

                if (!usedInversion)
                {
                    var expr = new ForallExpr(stmt.Tok, stmt.RangeToken, stmt.BoundVars, stmt.Range,
                      new BinaryExpr(s0.Tok, BinaryExpr.ResolvedOpcode.EqCommon, lhs, rhs),
                      stmt.Attributes)
                    {
                        Type = Type.Bool,
                        Bounds = stmt.Bounds
                    };
                    exprList.Add(expr);
                }

                stmt.EffectiveEnsuresClauses = exprList;
            }

            private static void VisitProof(ForallStmt s)
            {
                var term = MutateCSharp.Schemata448.ReplaceBinExprOp_5(72L, s.Ens.Count, MutateCSharp.Schemata448.ReplaceNumericConstant_1(68L, 0)) ? s.Ens[MutateCSharp.Schemata448.ReplaceNumericConstant_1(77L, 0)].E : Expression.CreateBoolLiteral(new AutoGeneratedToken(s.Tok), MutateCSharp.Schemata448.ReplaceBooleanConstant_0(81L, true));
                for (int i = MutateCSharp.Schemata448.ReplaceNumericConstant_1(82L, 1); MutateCSharp.Schemata448.ReplaceBinExprOp_2(86L, i, s.Ens.Count); MutateCSharp.Schemata448.ReplacePostfixUnaryExprOp_3(91L, ref i))
                {
                    term = new BinaryExpr(s.Ens[i].Tok, BinaryExpr.ResolvedOpcode.And, term, s.Ens[i].E);
                }

                s.EffectiveEnsuresClauses = new List<Expression> {
        new ForallExpr(s.Tok, s.RangeToken, s.BoundVars, s.Range, term, s.Attributes) {
          Type = Type.Bool, // resolve here
          Bounds = s.Bounds
        }
      };
            }

            public class ForallStmtTranslationValues
            {
                public readonly Expression Range;
                public readonly Expression FInverse;
                public ForallStmtTranslationValues(Expression range, Expression fInverse)
                {
                    Contract.Requires(range != null);
                    Contract.Requires(fInverse != null);
                    Range = range;
                    FInverse = fInverse;
                }
                public ForallStmtTranslationValues Subst(IVariable j, Expression e)
                {
                    Contract.Requires(j != null);
                    Contract.Requires(e != null);
                    Dictionary<TypeParameter, Type> typeMap = new Dictionary<TypeParameter, Type>();
                    var substMap = new Dictionary<IVariable, Expression>();
                    substMap.Add(j, e);
                    Substituter sub = new Substituter(null, substMap, typeMap);
                    var v = new ForallStmtTranslationValues(sub.Substitute(Range), sub.Substitute(FInverse));
                    return v;
                }
            }

            /// <summary>
            /// Find piecewise inverse of F under R.  More precisely, find lists of expressions P and F-1
            /// such that
            ///     R(i) && j == F(i)
            /// holds iff the disjunction of the following predicates holds:
            ///     P_0(j) && F-1_0(j) == i
            ///     ...
            ///     P_{n-1}(j) && F-1_{n-1}(j) == i
            /// If no such disjunction is found, return null.
            /// If such a disjunction is found, return for each disjunct:
            ///     * The predicate P_k(j), which is an expression that may have free occurrences of j (but no free occurrences of i)
            ///     * The expression F-1_k(j), which also may have free occurrences of j but not of i
            /// </summary>
            private List<ForallStmtTranslationValues> InvertExpression(BoundVar i, BoundVar j, Expression R, Expression F)
            {
                Contract.Requires(i != null);
                Contract.Requires(j != null);
                Contract.Requires(R != null);
                Contract.Requires(F != null);
                var vals = new List<ForallStmtTranslationValues>(InvertExpressionIter(i, j, R, F));
                if (MutateCSharp.Schemata448.ReplaceBinExprOp_6(96L, vals.Count, MutateCSharp.Schemata448.ReplaceNumericConstant_1(92L, 0)))
                {
                    return null;
                }
                else
                {
                    return vals;
                }

                return default;
            }
            /// <summary>
            /// See InvertExpression.
            /// </summary>
            private IEnumerable<ForallStmtTranslationValues> InvertExpressionIter(BoundVar i, BoundVar j, Expression R, Expression F)
            {
                Contract.Requires(i != null);
                Contract.Requires(j != null);
                Contract.Requires(R != null);
                Contract.Requires(F != null);
                F = F.Resolved;
                if (!FreeVariablesUtil.ContainsFreeVariable(F, MutateCSharp.Schemata448.ReplaceBooleanConstant_0(101L, false), i))
                {
                    // We're looking at R(i) && j == K.
                    // We cannot invert j == K, but if we're lucky, R(i) contains a conjunct i==G.
                    Expression r = Expression.CreateBoolLiteral(new AutoGeneratedToken(R.tok), MutateCSharp.Schemata448.ReplaceBooleanConstant_0(102L, true));
                    Expression G = null;
                    foreach (var c in Expression.Conjuncts(R))
                    {
                        if (MutateCSharp.Schemata448.ReplaceBinExprOp_10(104L, () => MutateCSharp.Schemata448.ReplaceBinExprOp_9(103L, G, null), () => c is BinaryExpr))
                        {
                            var bin = (BinaryExpr)c;
                            if (BinaryExpr.IsEqualityOp(bin.ResolvedOp))
                            {
                                var id = bin.E0.Resolved as IdentifierExpr;
                                if (MutateCSharp.Schemata448.ReplaceBinExprOp_10(112L, () => MutateCSharp.Schemata448.ReplaceBinExprOp_11(110L, id, null), () => MutateCSharp.Schemata448.ReplaceBinExprOp_12(111L, id.Var, i)))
                                {
                                    G = bin.E1;
                                    continue;
                                }
                                id = bin.E1.Resolved as IdentifierExpr;
                                if (MutateCSharp.Schemata448.ReplaceBinExprOp_10(120L, () => MutateCSharp.Schemata448.ReplaceBinExprOp_11(118L, id, null), () => MutateCSharp.Schemata448.ReplaceBinExprOp_12(119L, id.Var, i)))
                                {
                                    G = bin.E0;
                                    continue;
                                }
                            }
                        }
                        r = Expression.CreateAnd(r, c);
                    }
                    if (MutateCSharp.Schemata448.ReplaceBinExprOp_7(126L, G, null))
                    {
                        var jIsK = Expression.CreateEq(Expression.CreateIdentExpr(j), F, j.Type);
                        var rr = Substitute(r, i, G);
                        yield return new ForallStmtTranslationValues(Expression.CreateAnd(rr, jIsK), G);
                    }
                }
                else if (F is IdentifierExpr)
                {
                    var e = (IdentifierExpr)F;
                    if (MutateCSharp.Schemata448.ReplaceBinExprOp_12(127L, e.Var, i))
                    {
                        // We're looking at R(i) && j == i, which is particularly easy to invert:  R(j) && j == i
                        var jj = Expression.CreateIdentExpr(j);
                        yield return new ForallStmtTranslationValues(Substitute(R, i, jj), jj);
                    }
                }
                else if (F is BinaryExpr)
                {
                    var bin = (BinaryExpr)F;
                    if (MutateCSharp.Schemata448.ReplaceBinExprOp_10(135L, () => MutateCSharp.Schemata448.ReplaceBinExprOp_13(128L, bin.ResolvedOp, BinaryExpr.ResolvedOpcode.Add), () => (MutateCSharp.Schemata448.ReplaceBinExprOp_14(129L, () => bin.E0.Type.IsIntegerType, () => bin.E0.Type.IsRealType))))
                    {
                        if (!FreeVariablesUtil.ContainsFreeVariable(bin.E1, MutateCSharp.Schemata448.ReplaceBooleanConstant_0(141L, false), i))
                        {
                            // We're looking at:  R(i) && j == f(i) + K.
                            // By a recursive call, we'll ask to invert:  R(i) && j' == f(i).
                            // For each P_0(j') && f-1_0(j') == i we get back, we yield:
                            // P_0(j - K) && f-1_0(j - K) == i
                            var jMinusK = Expression.CreateSubtract(Expression.CreateIdentExpr(j), bin.E1);
                            foreach (var val in InvertExpression(i, j, R, bin.E0))
                            {
                                yield return val.Subst(j, jMinusK);
                            }
                        }
                        else if (!FreeVariablesUtil.ContainsFreeVariable(bin.E0, MutateCSharp.Schemata448.ReplaceBooleanConstant_0(142L, false), i))
                        {
                            // We're looking at:  R(i) && j == K + f(i)
                            // Do as in previous case, but with operands reversed.
                            var jMinusK = Expression.CreateSubtract(Expression.CreateIdentExpr(j), bin.E0);
                            foreach (var val in InvertExpression(i, j, R, bin.E1))
                            {
                                yield return val.Subst(j, jMinusK);
                            }
                        }
                    }
                    else if (MutateCSharp.Schemata448.ReplaceBinExprOp_10(150L, () => MutateCSharp.Schemata448.ReplaceBinExprOp_13(143L, bin.ResolvedOp, BinaryExpr.ResolvedOpcode.Sub), () => (MutateCSharp.Schemata448.ReplaceBinExprOp_14(144L, () => bin.E0.Type.IsIntegerType, () => bin.E0.Type.IsRealType))))
                    {
                        if (!FreeVariablesUtil.ContainsFreeVariable(bin.E1, MutateCSharp.Schemata448.ReplaceBooleanConstant_0(156L, false), i))
                        {
                            // We're looking at:  R(i) && j == f(i) - K
                            // Recurse on f(i) and then replace j := j + K
                            var jPlusK = Expression.CreateAdd(Expression.CreateIdentExpr(j), bin.E1);
                            foreach (var val in InvertExpression(i, j, R, bin.E0))
                            {
                                yield return val.Subst(j, jPlusK);
                            }
                        }
                        else if (!FreeVariablesUtil.ContainsFreeVariable(bin.E0, MutateCSharp.Schemata448.ReplaceBooleanConstant_0(157L, false), i))
                        {
                            // We're looking at:  R(i) && j == K - f(i)
                            // Recurse on f(i) and then replace j := K - j
                            var kMinusJ = Expression.CreateSubtract(bin.E0, Expression.CreateIdentExpr(j));
                            foreach (var val in InvertExpression(i, j, R, bin.E1))
                            {
                                yield return val.Subst(j, kMinusJ);
                            }
                        }
                    }
                }
                else if (F is ITEExpr)
                {
                    var ife = (ITEExpr)F;
                    // We're looking at R(i) && j == if A(i) then B(i) else C(i), which is equivalent to the disjunction of:
                    //   R(i) && A(i) && j == B(i)
                    //   R(i) && !A(i) && j == C(i)
                    // We recurse on each one, yielding the results
                    var r = Expression.CreateAnd(R, ife.Test);
                    var valsThen = InvertExpression(i, j, r, ife.Thn);
                    if (MutateCSharp.Schemata448.ReplaceBinExprOp_8(158L, valsThen, null))
                    {
                        r = Expression.CreateAnd(R, Expression.CreateNot(ife.tok, ife.Test));
                        var valsElse = InvertExpression(i, j, r, ife.Els);
                        if (MutateCSharp.Schemata448.ReplaceBinExprOp_8(159L, valsElse, null))
                        {
                            foreach (var val in valsThen) { yield return val; }
                            foreach (var val in valsElse) { yield return val; }
                        }
                    }
                }

                yield break;
            }

            Expression Substitute(Expression expr, IVariable v, Expression e)
            {
                Dictionary<IVariable, Expression/*!*/> substMap = new Dictionary<IVariable, Expression>();
                Dictionary<TypeParameter, Type> typeMap = new Dictionary<TypeParameter, Type>();
                substMap.Add(v, e);
                Substituter sub = new Substituter(null, substMap, typeMap);
                return sub.Substitute(expr);
            }

            List<BoundedPool>/*?*/ SubstituteBoundedPoolList(List<BoundedPool>/*?*/ list, IVariable v, Expression e)
            {
                Dictionary<IVariable, Expression/*!*/> substMap = new Dictionary<IVariable, Expression>();
                Dictionary<TypeParameter, Type> typeMap = new Dictionary<TypeParameter, Type>();
                substMap.Add(v, e);
                Substituter sub = new Substituter(null, substMap, typeMap);
                return sub.SubstituteBoundedPoolList(list);
            }
        }
    }
}