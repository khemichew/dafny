//-----------------------------------------------------------------------------
//
// Copyright (C) Microsoft Corporation.  All Rights Reserved.
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.Contracts;
using Bpl = Microsoft.Boogie;
using BplParser = Microsoft.Boogie.Parser;
using Microsoft.Boogie;
using static Microsoft.Dafny.Util;
using PODesc = Microsoft.Dafny.ProofObligationDescription;
namespace MutateCSharp
{
    internal class Schemata490
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT490");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static string ReplaceStringConstant_5(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static int ReplaceNumericConstant_0(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

    }
}

namespace Microsoft.Dafny
{
    public partial class BoogieGenerator
    {

        #region Definite-assignment tracking

        bool NeedsDefiniteAssignmentTracker(bool isGhost, Type type, bool isFIeld)
        {
            Contract.Requires(type != null);

            if (MutateCSharp.Schemata490.ReplaceBinExprOp_1(5L, options.DefiniteAssignmentLevel, MutateCSharp.Schemata490.ReplaceNumericConstant_0(1L, 0)))
            {
                return MutateCSharp.Schemata490.ReplaceBooleanConstant_2(10L, false);
            }
            else if (MutateCSharp.Schemata490.ReplaceBinExprOp_4(41L, () => MutateCSharp.Schemata490.ReplaceBinExprOp_1(15L, options.DefiniteAssignmentLevel, MutateCSharp.Schemata490.ReplaceNumericConstant_0(11L, 1)), () => (MutateCSharp.Schemata490.ReplaceBinExprOp_3(35L, () => MutateCSharp.Schemata490.ReplaceBinExprOp_3(29L, () => MutateCSharp.Schemata490.ReplaceBinExprOp_1(24L, options.DefiniteAssignmentLevel, MutateCSharp.Schemata490.ReplaceNumericConstant_0(20L, 4)), () => isFIeld), () => !options.ForbidNondeterminism))))
            {
                if (MutateCSharp.Schemata490.ReplaceBinExprOp_3(47L, () => isGhost, () => type.IsNonempty))
                {
                    return MutateCSharp.Schemata490.ReplaceBooleanConstant_2(53L, false);
                }
                else if (MutateCSharp.Schemata490.ReplaceBinExprOp_3(54L, () => !isGhost, () => type.HasCompilableValue))
                {
                    return MutateCSharp.Schemata490.ReplaceBooleanConstant_2(60L, false);
                }
            }

            return MutateCSharp.Schemata490.ReplaceBooleanConstant_2(61L, true);
        }

        Bpl.Expr /*?*/ AddDefiniteAssignmentTracker(IVariable p, List<Bpl.Variable> localVariables, bool isOutParam = false,
          bool forceGhostVar = false)
        {
            Contract.Requires(p != null);
            Contract.Requires(localVariables != null);

            if (!NeedsDefiniteAssignmentTracker(MutateCSharp.Schemata490.ReplaceBinExprOp_4(62L, () => p.IsGhost, () => forceGhostVar), p.Type, MutateCSharp.Schemata490.ReplaceBooleanConstant_2(68L, false)))
            {
                return null;
            }

            Bpl.Variable tracker;
            if (isOutParam)
            {
                tracker = new Bpl.Formal(p.Tok, new Bpl.TypedIdent(p.Tok, MutateCSharp.Schemata490.ReplaceStringConstant_5(69L, "defass#") + p.UniqueName, Bpl.Type.Bool), MutateCSharp.Schemata490.ReplaceBooleanConstant_2(70L, false));
            }
            else
            {
                tracker = new Bpl.LocalVariable(p.Tok, new Bpl.TypedIdent(p.Tok, MutateCSharp.Schemata490.ReplaceStringConstant_5(71L, "defass#") + p.UniqueName, Bpl.Type.Bool));
            }

            localVariables.Add(tracker);
            var ie = new Bpl.IdentifierExpr(p.Tok, tracker);
            definiteAssignmentTrackers.Add(p.UniqueName, ie);
            return ie;
        }

        void AddExistingDefiniteAssignmentTracker(IVariable p, bool forceGhostVar)
        {
            Contract.Requires(p != null);

            if (NeedsDefiniteAssignmentTracker(MutateCSharp.Schemata490.ReplaceBinExprOp_4(72L, () => p.IsGhost, () => forceGhostVar), p.Type, MutateCSharp.Schemata490.ReplaceBooleanConstant_2(78L, false)))
            {
                var ie = new Bpl.IdentifierExpr(p.Tok, MutateCSharp.Schemata490.ReplaceStringConstant_5(79L, "defass#") + p.UniqueName, Bpl.Type.Bool);
                definiteAssignmentTrackers.Add(p.UniqueName, ie);
            }
        }

        void AddDefiniteAssignmentTrackerSurrogate(Field field, TopLevelDeclWithMembers enclosingClass,
          List<Variable> localVariables, bool forceGhostVar)
        {
            Contract.Requires(field != null);
            Contract.Requires(localVariables != null);

            var type = field.Type.Subst(enclosingClass.ParentFormalTypeParametersToActuals);
            if (!NeedsDefiniteAssignmentTracker(MutateCSharp.Schemata490.ReplaceBinExprOp_4(80L, () => field.IsGhost, () => forceGhostVar), type, MutateCSharp.Schemata490.ReplaceBooleanConstant_2(86L, true)))
            {
                return;
            }

            var nm = SurrogateName(field);
            var tracker = new Bpl.LocalVariable(field.tok, new Bpl.TypedIdent(field.tok, MutateCSharp.Schemata490.ReplaceStringConstant_5(87L, "defass#") + nm, Bpl.Type.Bool));
            localVariables.Add(tracker);
            var ie = new Bpl.IdentifierExpr(field.tok, tracker);
            definiteAssignmentTrackers.Add(nm, ie);
        }

        void RemoveDefiniteAssignmentTrackers(List<Statement> ss, int prevDefAssTrackerCount)
        {
            Contract.Requires(ss != null);
            foreach (var s in ss)
            {
                if (s is VarDeclStmt vdecl)
                {
                    if (vdecl.Update is AssignOrReturnStmt ars)
                    {
                        foreach (var sx in ars.ResolvedStatements)
                        {
                            if (sx is VarDeclStmt vdecl2)
                            {
                                vdecl2.Locals.ForEach(RemoveDefiniteAssignmentTracker);
                            }
                        }
                    }

                    vdecl.Locals.ForEach(RemoveDefiniteAssignmentTracker);
                }
                else if (s is AssignOrReturnStmt ars)
                {
                    foreach (var sx in ars.ResolvedStatements)
                    {
                        if (sx is VarDeclStmt vdecl2)
                        {
                            vdecl2.Locals.ForEach(RemoveDefiniteAssignmentTracker);
                        }
                    }
                }
            }

            Contract.Assert(prevDefAssTrackerCount == definiteAssignmentTrackers.Count);
        }

        void RemoveDefiniteAssignmentTracker(IVariable p)
        {
            Contract.Requires(p != null);
            definiteAssignmentTrackers.Remove(p.UniqueName);
        }

        void RemoveDefiniteAssignmentTrackerSurrogate(Field field)
        {
            Contract.Requires(field != null);
            definiteAssignmentTrackers.Remove(SurrogateName(field));
        }

        void MarkDefiniteAssignmentTracker(IdentifierExpr expr, BoogieStmtListBuilder builder)
        {
            Contract.Requires(expr != null);
            Contract.Requires(builder != null);
            MarkDefiniteAssignmentTracker(expr.tok, expr.Var.UniqueName, builder);
        }

        void MarkDefiniteAssignmentTracker(IToken tok, string name, BoogieStmtListBuilder builder)
        {
            Contract.Requires(tok != null);
            Contract.Requires(name != null);
            Contract.Requires(builder != null);

            Bpl.IdentifierExpr ie;
            if (definiteAssignmentTrackers.TryGetValue(name, out ie))
            {
                builder.Add(Bpl.Cmd.SimpleAssign(tok, ie, Bpl.Expr.True));
            }
        }

        internal IToken GetToken(INode node)
        {
            if (flags.ReportRanges)
            {
                // Filter against IHasUsages to only select declarations, not usages.
                if (node is IDeclarationOrUsage declarationOrUsage && node is not IHasUsages)
                {
                    return new BoogieRangeToken(node.StartToken, node.EndToken, declarationOrUsage.NameToken);
                }

                return new BoogieRangeToken(node.StartToken, node.EndToken, node.Tok);
            }
            else
            {
                // The commented line is what we want, but it changes what is translated.
                // Seems to relate to refinement and possibly RefinementToken.IsInherited and or ForceCheckToken
                // It might be better to remove calls to RefinementToken.IsInherited from this file, and instead
                // add generic attributes like {:verify false} in the refinement phases, so that refinement does not complicate
                // translation,
                //
                // return new BoogieRangeToken(node.StartToken, node.EndToken, node.Tok);
                return node.Tok;
            }

            return default;
        }

        void CheckDefiniteAssignment(IdentifierExpr expr, BoogieStmtListBuilder builder)
        {
            Contract.Requires(expr != null);
            Contract.Requires(builder != null);

            Bpl.IdentifierExpr ie;
            if (definiteAssignmentTrackers.TryGetValue(expr.Var.UniqueName, out ie))
            {
                builder.Add(Assert(GetToken(expr), ie, new PODesc.DefiniteAssignment($"variable '{expr.Var.Name}'", MutateCSharp.Schemata490.ReplaceStringConstant_5(88L, "here"))));
            }
        }

        /// <summary>
        /// Returns an expression denoting the definite-assignment tracker for "var", or "null" if there is none.
        /// </summary>
        Bpl.IdentifierExpr /*?*/ GetDefiniteAssignmentTracker(IVariable var)
        {
            Bpl.IdentifierExpr ie;
            if (definiteAssignmentTrackers.TryGetValue(var.UniqueName, out ie))
            {
                return ie;
            }

            return null;
        }

        void CheckDefiniteAssignmentSurrogate(IToken tok, Field field, bool atNew, BoogieStmtListBuilder builder)
        {
            Contract.Requires(tok != null);
            Contract.Requires(field != null);
            Contract.Requires(builder != null);

            var nm = SurrogateName(field);
            Bpl.IdentifierExpr ie;
            if (definiteAssignmentTrackers.TryGetValue(nm, out ie))
            {
                var desc = new PODesc.DefiniteAssignment($"field '{field.Name}'",
                  atNew ? MutateCSharp.Schemata490.ReplaceStringConstant_5(89L, "at this point in the constructor body") : MutateCSharp.Schemata490.ReplaceStringConstant_5(90L, "here"));
                builder.Add(Assert(tok, ie, desc));
            }
        }

        void AssumeCanCallForByMethodDecl(Method method, BoogieStmtListBuilder builder)
        {
            if (method?.FunctionFromWhichThisIsByMethodDecl?.ByMethodTok != null && // Otherwise nothing is checked anyway
                method.Ens.Count == 1 &&
                method.Ens[0].E is BinaryExpr { E1: var e1 } &&
                e1.Resolved is FunctionCallExpr { Args: var arguments } fnCall)
            {
                // fnCall == (m.Ens[0].E as BinaryExpr).E1;
                // fn == new FunctionCallExpr(tok, f.Name, receiver, tok, tok, f.Formals.ConvertAll(Expression.CreateIdentExpr));
                Bpl.IdentifierExpr canCallFuncID =
                  new Bpl.IdentifierExpr(method.tok, method.FullSanitizedName + MutateCSharp.Schemata490.ReplaceStringConstant_5(91L, "#canCall"), Bpl.Type.Bool);
                var etran = new ExpressionTranslator(this, predef, method.tok, method);
                List<Bpl.Expr> args = arguments.Select(arg => etran.TrExpr(arg)).ToList();
                var formals = MkTyParamBinders(GetTypeParams(method), out var tyargs);
                if (method.FunctionFromWhichThisIsByMethodDecl.ReadsHeap)
                {
                    Contract.Assert(etran.HeapExpr != null);
                    tyargs.Add(etran.HeapExpr);
                }

                if (!method.IsStatic)
                {
                    var thVar = BplBoundVar(MutateCSharp.Schemata490.ReplaceStringConstant_5(92L, "this"), TrReceiverType(method.FunctionFromWhichThisIsByMethodDecl), out var th);
                    tyargs.Add(th);
                }

                Bpl.Expr boogieAssumeCanCall =
                  new Bpl.NAryExpr(method.tok, new FunctionCall(canCallFuncID), Concat(tyargs, args));
                builder.Add(new AssumeCmd(method.tok, boogieAssumeCanCall));
            }
            else
            {
                Contract.Assert(false, "Error in shape of by-method");
            }
        }

        void CheckDefiniteAssignmentReturn(IToken tok, Formal p, BoogieStmtListBuilder builder)
        {
            Contract.Requires(tok != null);
            Contract.Requires(p != null && !p.InParam);
            Contract.Requires(builder != null);

            Bpl.IdentifierExpr ie;
            if (definiteAssignmentTrackers.TryGetValue(p.UniqueName, out ie))
            {
                var desc = new PODesc.DefiniteAssignment($"out-parameter '{p.Name}'", MutateCSharp.Schemata490.ReplaceStringConstant_5(93L, "at this return point"));
                builder.Add(Assert(tok, ie, desc));
            }
        }

        #endregion // definite-assignment tracking
    }
}
