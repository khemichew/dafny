using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata136
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT136");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_2(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.Node argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.AssignStmt.NonGhostKind argument1, Microsoft.Dafny.AssignStmt.NonGhostKind argument2)
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

    }
}

namespace Microsoft.Dafny
{
    public class AssignStmt : Statement, ICloneable<AssignStmt>
    {
        public readonly Expression Lhs;
        public readonly AssignmentRhs Rhs;
        public override IEnumerable<INode> Children => new List<Node> { Lhs, Rhs }.Where(x => MutateCSharp.Schemata136.ReplaceBinExprOp_0(1L, x, null));
        public override IEnumerable<INode> PreResolveChildren => Children;
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(Lhs != null);
            Contract.Invariant(Rhs != null);
        }

        public override IToken Tok
        {
            get
            {
                var previous = Rhs.StartToken.Prev;
                // If there was a single assignment, report on the operator.
                var singleAssignment = MutateCSharp.Schemata136.ReplaceBinExprOp_2(3L, previous.val, MutateCSharp.Schemata136.ReplaceStringConstant_1(2L, ":="));
                // If there was an implicit return assignment, report on the return.
                var implicitAssignment = MutateCSharp.Schemata136.ReplaceBinExprOp_2(5L, previous.val, MutateCSharp.Schemata136.ReplaceStringConstant_1(4L, "return"));
                if (MutateCSharp.Schemata136.ReplaceBinExprOp_3(6L, () => singleAssignment, () => implicitAssignment))
                {
                    return previous;
                }
                return Rhs.StartToken;
            }
        }

        public AssignStmt Clone(Cloner cloner)
        {
            return new AssignStmt(cloner, this);
        }

        public AssignStmt(Cloner cloner, AssignStmt original) : base(cloner, original)
        {
            Lhs = cloner.CloneExpr(original.Lhs);
            Rhs = cloner.CloneRHS(original.Rhs);
        }

        public AssignStmt(RangeToken rangeToken, Expression lhs, AssignmentRhs rhs)
          : base(rangeToken)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(lhs != null);
            Contract.Requires(rhs != null);
            this.Lhs = lhs;
            this.Rhs = rhs;
        }

        public override IEnumerable<Statement> SubStatements
        {
            get
            {
                foreach (var s in Rhs.SubStatements)
                {
                    yield return s;
                }

                yield break;
            }
        }

        public override IEnumerable<Statement> PreResolveSubStatements
        {
            get
            {
                foreach (var s in Rhs.PreResolveSubStatements)
                {
                    yield return s;
                }

                yield break;
            }
        }

        public override IEnumerable<Expression> NonSpecificationSubExpressions
        {
            get
            {
                foreach (var e in base.NonSpecificationSubExpressions) { yield return e; }
                yield return Lhs;
                foreach (var ee in Rhs.NonSpecificationSubExpressions)
                {
                    yield return ee;
                }

                yield break;
            }
        }

        public override IEnumerable<Expression> SpecificationSubExpressions
        {
            get
            {
                foreach (var e in base.SpecificationSubExpressions) { yield return e; }
                foreach (var ee in Rhs.SpecificationSubExpressions)
                {
                    yield return ee;
                }

                yield break;
            }
        }

        /// <summary>
        /// This method assumes "lhs" has been successfully resolved.
        /// </summary>
        public static bool LhsIsToGhost(Expression lhs)
        {
            Contract.Requires(lhs != null);
            return MutateCSharp.Schemata136.ReplaceBinExprOp_4(12L, LhsIsToGhost_Which(lhs), NonGhostKind.IsGhost);
        }
        public static bool LhsIsToGhostOrAutoGhost(Expression lhs)
        {
            Contract.Requires(lhs != null);
            return MutateCSharp.Schemata136.ReplaceBinExprOp_3(14L, () => MutateCSharp.Schemata136.ReplaceBinExprOp_4(13L, LhsIsToGhost_Which(lhs), NonGhostKind.IsGhost), () => lhs.Resolved is AutoGhostIdentifierExpr);
        }
        public enum NonGhostKind { IsGhost, Variable, Field, ArrayElement }
        public static string NonGhostKind_To_String(NonGhostKind gk)
        {
            Contract.Requires(gk != NonGhostKind.IsGhost);
            switch (gk)
            {
                case NonGhostKind.Variable:
                    return "non-ghost variable";
                    break;
                case NonGhostKind.Field:
                    return "non-ghost field";
                    break;
                case NonGhostKind.ArrayElement:
                    return "array element";
                    break;
                default:
                    Contract.Assume(false);  // unexpected NonGhostKind
                    throw new cce.UnreachableException();  // please compiler
                    break;
            }

            return default;
        }
        /// <summary>
        /// This method assumes "lhs" has been successfully resolved.
        /// </summary>
        public static NonGhostKind LhsIsToGhost_Which(Expression lhs)
        {
            Contract.Requires(lhs != null);
            lhs = lhs.Resolved;
            if (lhs is AutoGhostIdentifierExpr)
            {
                // TODO: Should we return something different for this case?
                var x = (IdentifierExpr)lhs;
                if (!x.Var.IsGhost)
                {
                    return NonGhostKind.Variable;
                }
            }
            else if (lhs is IdentifierExpr)
            {
                var x = (IdentifierExpr)lhs;
                if (!x.Var.IsGhost)
                {
                    return NonGhostKind.Variable;
                }
            }
            else if (lhs is MemberSelectExpr)
            {
                var x = (MemberSelectExpr)lhs;
                if (!x.Member.IsGhost)
                {
                    return NonGhostKind.Field;
                }
            }
            else
            {
                // LHS denotes an array element, which is always non-ghost
                return NonGhostKind.ArrayElement;
            }
            return NonGhostKind.IsGhost;
        }
    }
}