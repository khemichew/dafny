//-----------------------------------------------------------------------------
//
// Copyright (C) Microsoft Corporation.  All Rights Reserved.
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using static Microsoft.Dafny.RewriterErrors;
namespace MutateCSharp
{
    internal class Schemata454
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT454");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
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

        internal static string ReplaceStringConstant_4(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
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

    }
}

namespace Microsoft.Dafny
{

    public class LocalLinter : IRewriter
    {
        internal override void PostResolveIntermediate(ModuleDefinition moduleDefinition)
        {
            base.PostResolveIntermediate(moduleDefinition);
            foreach (var topLevelDecl in moduleDefinition.TopLevelDecls.OfType<TopLevelDeclWithMembers>())
            {
                foreach (var callable in topLevelDecl.Members.OfType<ICallable>())
                {
                    var visitor = new UselessOldLinterVisitor(Reporter);
                    visitor.Visit(callable, Unit.Default);
                }
            }
        }

        public LocalLinter(ErrorReporter reporter) : base(reporter)
        {
        }
    }

    public
      class UselessOldLinterVisitor : TopDownVisitor<Unit>
    {
        private readonly ErrorReporter reporter;

        public UselessOldLinterVisitor(ErrorReporter reporter) : base(MutateCSharp.Schemata454.ReplaceBooleanConstant_0(1L, false))
        {
            this.reporter = reporter;
        }

        protected override bool VisitOneExpr(Expression expr, ref Unit st)
        {
            if (expr is OldExpr oldExpr && !AutoGeneratedToken.Is(oldExpr.tok))
            {
                var fvs = new HashSet<IVariable>();
                var usesHeap = MutateCSharp.Schemata454.ReplaceBooleanConstant_0(2L, false);
                FreeVariablesUtil.ComputeFreeVariables(reporter.Options, oldExpr.E, fvs, ref usesHeap, MutateCSharp.Schemata454.ReplaceBooleanConstant_0(3L, true));
                if (!usesHeap)
                {
                    oldExpr.Useless = MutateCSharp.Schemata454.ReplaceBooleanConstant_0(4L, true);
                    reporter.Warning(MessageSource.Rewriter, ErrorId.rw_old_argument_not_on_heap, oldExpr.tok,
                      $"Argument to 'old' does not dereference the mutable heap, so this use of 'old' has no effect");
                }
            }
            return base.VisitOneExpr(expr, ref st);
        }

        protected override bool VisitOneStmt(Statement stmt, ref Unit st)
        {
            // Check if the statement has the three tokens "assert", "!", and "(" next to each other. If so, that may
            // be a mistake, especially if the programmer is coming from Rust.
            if (stmt is AssertStmt { Expr: UnaryOpExpr { Op: UnaryOpExpr.Opcode.Not, E: ParensExpression } negationExpression })
            {
                if (MutateCSharp.Schemata454.ReplaceBinExprOp_3(18L, MutateCSharp.Schemata454.ReplaceBinExprOp_2(9L, stmt.tok.pos, MutateCSharp.Schemata454.ReplaceNumericConstant_1(5L, 6/*="assert".Length*/ )), negationExpression.tok.pos))
                {
                    reporter.Warning(MessageSource.Rewriter, ErrorId.rw_warn_negated_assertion, stmt.tok,
          MutateCSharp.Schemata454.ReplaceStringConstant_4(23L, "You have written an assert statement with a negated condition, but the lack of whitespace between 'assert' and '!' ") +
          MutateCSharp.Schemata454.ReplaceStringConstant_4(24L, "suggests you may be used to Rust and have accidentally negated the asserted condition. If you did not intend the negation, ") +
          MutateCSharp.Schemata454.ReplaceStringConstant_4(25L, "remove the '!' and the parentheses; if you do want the negation, please add a space between the 'assert' and '!'."));
                }
            }
            return base.VisitOneStmt(stmt, ref st);
        }
    }
}
