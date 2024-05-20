using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata137
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT137");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.AttributedToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_4(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
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

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
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

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.AttributedToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class AssignSuchThatStmt : ConcreteUpdateStatement, ICloneable<AssignSuchThatStmt>, ICanResolveNewAndOld
    {
        public readonly Expression Expr;
        public readonly AttributedToken AssumeToken;

        public override IEnumerable<INode> PreResolveChildren =>
          Lhss.Concat<Node>(new List<Node>() { Expr });

        public override IToken Tok
        {
            get
            {
                var result = Expr.StartToken.Prev;
                if (char.IsLetter(result.val[MutateCSharp.Schemata137.ReplaceNumericConstant_0(1L, 0)]))
                {
                    // Jump to operator if we're on an assume keyword.
                    result = result.Prev;
                }
                return result;
            }
        }

        [FilledInDuringResolution] public List<BoundedPool> Bounds;  // null for a ghost statement
                                                                     // invariant Bounds == null || Bounds.Count == BoundVars.Count;
        [FilledInDuringResolution] public List<IVariable> MissingBounds;  // remains "null" if bounds can be found
                                                                          // invariant Bounds == null || MissingBounds == null;
        public class WiggleWaggleBound : BoundedPool
        {
            public override PoolVirtues Virtues => PoolVirtues.Enumerable | PoolVirtues.IndependentOfAlloc | PoolVirtues.IndependentOfAlloc_or_ExplicitAlloc;
            public override int Preference() => MutateCSharp.Schemata137.ReplaceNumericConstant_0(5L, 1);
            public override BoundedPool Clone(Cloner cloner)
            {
                return this;
            }
        }

        public override IEnumerable<INode> Children => Lhss.Concat<Node>(new[] { Expr });

        public AssignSuchThatStmt Clone(Cloner cloner)
        {
            return new AssignSuchThatStmt(cloner, this);
        }

        public AssignSuchThatStmt(Cloner cloner, AssignSuchThatStmt original) : base(cloner, original)
        {
            Expr = cloner.CloneExpr(original.Expr);
            AssumeToken = cloner.AttributedTok(original.AssumeToken);

            if (cloner.CloneResolvedFields)
            {
                Bounds = original.Bounds?.Select(bp => bp.Clone(cloner)).ToList();
                MissingBounds = original.MissingBounds?.Select(v => cloner.CloneIVariable(v, MutateCSharp.Schemata137.ReplaceBooleanConstant_1(9L, true))).ToList();
            }
        }

        /// <summary>
        /// "assumeToken" is allowed to be "null", in which case the verifier will check that a RHS value exists.
        /// If "assumeToken" is non-null, then it should denote the "assume" keyword used in the statement.
        /// </summary>
        public AssignSuchThatStmt(RangeToken rangeToken, List<Expression> lhss, Expression expr, AttributedToken assumeToken, Attributes attrs)
          : base(rangeToken, lhss, attrs)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(cce.NonNullElements(lhss));
            Contract.Requires(lhss.Count != 0);
            Contract.Requires(expr != null);
            Expr = expr;
            if (MutateCSharp.Schemata137.ReplaceBinExprOp_2(10L, assumeToken, null))
            {
                AssumeToken = assumeToken;
            }
        }
        public override IEnumerable<Expression> NonSpecificationSubExpressions
        {
            get
            {
                foreach (var e in base.NonSpecificationSubExpressions) { yield return e; }
                yield return Expr;
            }
        }

        public override void GenResolve(INewOrOldResolver resolver, ResolutionContext resolutionContext)
        {
            Contract.Requires(this != null);
            Contract.Requires(resolutionContext != null);

            base.GenResolve(resolver, resolutionContext);

            if (MutateCSharp.Schemata137.ReplaceBinExprOp_2(11L, AssumeToken, null))
            {
                if (MutateCSharp.Schemata137.ReplaceBinExprOp_3(12L, () => !resolver.Options.Get(CommonOptionBag.AllowAxioms), () => !AssumeToken.IsExplicitAxiom()))
                {
                    resolver.Reporter.Warning(MessageSource.Resolver, ResolutionErrors.ErrorId.none, AssumeToken.Token, MutateCSharp.Schemata137.ReplaceStringConstant_4(18L, "assume keyword in assign-such-that statement has no {:axiom} annotation"));
                }

                resolver.ResolveAttributes(AssumeToken, resolutionContext);
            }

            var lhsSimpleVariables = new HashSet<IVariable>();
            foreach (var lhs in Lhss)
            {
                if (MutateCSharp.Schemata137.ReplaceBinExprOp_5(19L, lhs.Resolved, null))
                {
                    resolver.CheckIsLvalue(lhs.Resolved, resolutionContext);
                }
                else
                {
                    Contract.Assert(resolver.Reporter.HasErrors);
                }
                if (lhs.Resolved is IdentifierExpr ide)
                {
                    if (!lhsSimpleVariables.Add(ide.Var))
                    {
                        // syntactically forbid duplicate simple-variables on the LHS
                        resolver.Reporter.Error(MessageSource.Resolver, lhs, $"variable '{ide.Var.Name}' occurs more than once as left-hand side of :|");
                    }
                }
                // to ease in the verification of the existence check, only allow local variables as LHSs
                if (MutateCSharp.Schemata137.ReplaceBinExprOp_3(21L, () => MutateCSharp.Schemata137.ReplaceBinExprOp_6(20L, AssumeToken, null), () => !(lhs.Resolved is IdentifierExpr)))
                {
                    resolver.Reporter.Error(MessageSource.Resolver, lhs, MutateCSharp.Schemata137.ReplaceStringConstant_4(27L, "an assign-such-that statement (without an 'assume' clause) currently only supports local-variable LHSs"));
                }
            }

            resolver.ResolveExpression(Expr, resolutionContext);
            resolver.ConstrainTypeExprBool(Expr, MutateCSharp.Schemata137.ReplaceStringConstant_4(28L, "type of RHS of assign-such-that statement must be boolean (got {0})"));
        }
    }
}
