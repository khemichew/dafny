using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Microsoft.Dafny.Auditor;
namespace MutateCSharp
{
    internal class Schemata172
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT172");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.Label argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_2(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.AssertLabel argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.AssertLabel argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBinExprOp_9(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class AssertStmt : PredicateStmt, ICloneable<AssertStmt>, ICanFormat
    {
        public readonly BlockStmt Proof;
        public readonly AssertLabel Label;

        public AssertStmt Clone(Cloner cloner)
        {
            return new AssertStmt(cloner, this);
        }

        public AssertStmt(Cloner cloner, AssertStmt original) : base(cloner, original)
        {
            Proof = cloner.CloneBlockStmt(original.Proof);
            Label = MutateCSharp.Schemata172.ReplaceBinExprOp_0(1L, original.Label, null) ? null : new AssertLabel(cloner.Tok(original.Label.Tok), original.Label.Name);
        }

        public static AssertStmt CreateErrorAssert(INode node, string message, Expression guard = null)
        {
            var errorMessage = new StringLiteralExpr(node.Tok, message, MutateCSharp.Schemata172.ReplaceBooleanConstant_1(2L, true));
            errorMessage.Type = new SeqType(Type.Char);
            var attr = new Attributes(MutateCSharp.Schemata172.ReplaceStringConstant_2(3L, "error"), new List<Expression> { errorMessage }, null);
            guard ??= Expression.CreateBoolLiteral(node.Tok, MutateCSharp.Schemata172.ReplaceBooleanConstant_1(4L, false));
            var assertFalse = new AssertStmt(node.RangeToken, guard, null, null, attr);
            assertFalse.IsGhost = MutateCSharp.Schemata172.ReplaceBooleanConstant_1(5L, true);
            return assertFalse;
        }

        public AssertStmt(RangeToken rangeToken, Expression expr, BlockStmt/*?*/ proof, AssertLabel/*?*/ label, Attributes attrs)
          : base(rangeToken, expr, attrs)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(expr != null);
            Proof = proof;
            Label = label;
        }

        public override IEnumerable<Statement> SubStatements
        {
            get
            {
                if (MutateCSharp.Schemata172.ReplaceBinExprOp_3(6L, Proof, null))
                {
                    yield return Proof;
                }

                yield break;
            }
        }

        public void AddCustomizedErrorMessage(IToken tok, string s)
        {
            var args = new List<Expression>() { new StringLiteralExpr(tok, s, MutateCSharp.Schemata172.ReplaceBooleanConstant_1(7L, true)) };
            IToken openBrace = tok;
            IToken closeBrace = new Token(tok.line, MutateCSharp.Schemata172.ReplaceBinExprOp_5(34L, MutateCSharp.Schemata172.ReplaceBinExprOp_5(21L, MutateCSharp.Schemata172.ReplaceBinExprOp_5(12L, tok.col, MutateCSharp.Schemata172.ReplaceNumericConstant_4(8L, 7)), s.Length), MutateCSharp.Schemata172.ReplaceNumericConstant_4(30L, 1))); // where 7 = length(":error ")
            this.Attributes = new UserSuppliedAttributes(tok, openBrace, closeBrace, args, this.Attributes);
        }

        public override IEnumerable<Expression> SpecificationSubExpressions
        {
            get
            {
                foreach (var e in base.SpecificationSubExpressions) { yield return e; }
                yield return Expr;
            }
        }

        public override IEnumerable<Assumption> Assumptions(Declaration decl)
        {
            if (this.HasUserAttribute(MutateCSharp.Schemata172.ReplaceStringConstant_2(43L, "only"), out _))
            {
                yield return new Assumption(decl, tok, AssumptionDescription.AssertOnly);
            }

            yield break;
        }

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            return formatter.SetIndentAssertLikeStatement(this, indentBefore);
        }

        public override void GenResolve(INewOrOldResolver resolver, ResolutionContext context)
        {
            if (MutateCSharp.Schemata172.ReplaceBinExprOp_6(44L, Label, null))
            {
                if (MutateCSharp.Schemata172.ReplaceBinExprOp_7(45L, resolver.DominatingStatementLabels.Find(Label.Name), null))
                {
                    resolver.Reporter.Error(MessageSource.Resolver, Label.Tok, MutateCSharp.Schemata172.ReplaceStringConstant_2(46L, "assert label shadows a dominating label"));
                }
                else
                {
                    var rr = resolver.DominatingStatementLabels.Push(Label.Name, Label);
                    Contract.Assert(rr == Scope<Label>.PushResult.Success); // since we just checked for duplicates, we expect the Push to succeed
                }
            }

            if (this.HasUserAttribute(MutateCSharp.Schemata172.ReplaceStringConstant_2(47L, "only"), out var attribute))
            {
                resolver.Reporter.Warning(MessageSource.Verifier, ResolutionErrors.ErrorId.r_assert_only_assumes_others.ToString(), attribute.RangeToken.ToToken(),
          MutateCSharp.Schemata172.ReplaceStringConstant_2(48L, "Assertion with {:only} temporarily transforms other assertions into assumptions"));
                if (attribute.Args.Count >= 1
                    && attribute.Args[0] is LiteralExpr { Value: string value }
                    && value != "before" && MutateCSharp.Schemata172.ReplaceBinExprOp_8(50L, value, MutateCSharp.Schemata172.ReplaceStringConstant_2(49L, "after")))
                {
                    resolver.Reporter.Warning(MessageSource.Verifier, ResolutionErrors.ErrorId.r_assert_only_before_after.ToString(), attribute.Args[MutateCSharp.Schemata172.ReplaceNumericConstant_4(51L, 0)].RangeToken.ToToken(),
            MutateCSharp.Schemata172.ReplaceStringConstant_2(55L, "{:only} only accepts \"before\" or \"after\" as an optional argument"));
                }
            }

            base.GenResolve(resolver, context);

            if (MutateCSharp.Schemata172.ReplaceBinExprOp_3(56L, Proof, null))
            {
                // clear the labels for the duration of checking the proof body, because break statements are not allowed to leave a the proof body
                var prevLblStmts = resolver.EnclosingStatementLabels;
                var prevLoopStack = resolver.LoopStack;
                resolver.EnclosingStatementLabels = new Scope<Statement>(resolver.Options);
                resolver.LoopStack = new List<Statement>();
                resolver.ResolveStatement(Proof, context);
                resolver.EnclosingStatementLabels = prevLblStmts;
                resolver.LoopStack = prevLoopStack;
            }
        }

        public bool HasAssertOnlyAttribute(out AssertOnlyKind assertOnlyKind)
        {
            assertOnlyKind = AssertOnlyKind.Single;
            if (!this.HasUserAttribute("only", out var attribute))
            {
                return MutateCSharp.Schemata172.ReplaceBooleanConstant_1(57L, false);
            }

            if (MutateCSharp.Schemata172.ReplaceBinExprOp_9(62L, attribute.Args.Count, MutateCSharp.Schemata172.ReplaceNumericConstant_4(58L, 1)) || attribute.Args[0] is not LiteralExpr { Value: var value })
            {
                return MutateCSharp.Schemata172.ReplaceBooleanConstant_1(67L, true);
            }

            assertOnlyKind = value switch
            {
                "before" => AssertOnlyKind.Before,
                "after" => AssertOnlyKind.After,
                _ => assertOnlyKind
            };

            return MutateCSharp.Schemata172.ReplaceBooleanConstant_1(68L, true);
        }

        public enum AssertOnlyKind
        {
            Before,
            After,
            Single
        }
    }
}

