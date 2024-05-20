using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata64
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT64");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{

    /// <summary>
    /// A StmtExpr has the form S;E where S is a statement (from a restricted set) and E is an expression.
    /// The expression S;E evaluates to whatever E evaluates to, but its well-formedness comes down to
    /// executing S (which itself must be well-formed) and then checking the well-formedness of E.
    /// </summary>
    public class StmtExpr : Expression, ICanFormat, ICloneable<StmtExpr>
    {
        public readonly Statement S;
        public readonly Expression E;
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(S != null);
            Contract.Invariant(E != null);
        }

        public StmtExpr(Cloner cloner, StmtExpr original) : base(cloner, original)
        {
            E = cloner.CloneExpr(original.E);
            S = cloner.CloneStmt(original.S, MutateCSharp.Schemata64.ReplaceBooleanConstant_0(1L, false));
        }

        public override IEnumerable<INode> Children => new Node[] { S, E };

        public StmtExpr(IToken tok, Statement stmt, Expression expr)
          : base(tok)
        {
            Contract.Requires(tok != null);
            Contract.Requires(stmt != null);
            Contract.Requires(expr != null);
            S = stmt;
            E = expr;
        }
        public override IEnumerable<Expression> SubExpressions
        {
            get
            {
                // Note:  A StmtExpr is unusual in that it contains a statement.  For now, callers
                // of SubExpressions need to be aware of this and handle it specially.
                yield return E;
            }
        }

        public override IEnumerable<Expression> TerminalExpressions
        {
            get
            {
                foreach (var e in E.TerminalExpressions)
                {
                    yield return e;
                }

                yield break;
            }
        }

        /// <summary>
        /// Returns a conclusion that S gives rise to, that is, something that is known after
        /// S is executed.
        /// This method should be called only after successful resolution of the expression.
        /// </summary>
        public Expression GetSConclusion()
        {
            // this is one place where we actually investigate what kind of statement .S is
            if (S is PredicateStmt)
            {
                var s = (PredicateStmt)S;
                return s.Expr;
            }
            else if (S is CalcStmt)
            {
                var s = (CalcStmt)S;
                return s.Result;
            }
            else if (S is RevealStmt)
            {
                return CreateBoolLiteral(tok, MutateCSharp.Schemata64.ReplaceBooleanConstant_0(2L, true));  // one could use the definition axiom or the referenced labeled assertions, but "true" is conservative and much simpler :)
            }
            else if (S is UpdateStmt)
            {
                return CreateBoolLiteral(tok, MutateCSharp.Schemata64.ReplaceBooleanConstant_0(3L, true));  // one could use the postcondition of the method, suitably instantiated, but "true" is conservative and much simpler :)
            }
            else
            {
                Contract.Assert(false); throw new cce.UnreachableException();  // unexpected statement
            }

            return default;
        }

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            formatter.Visit(S, indentBefore);
            formatter.SetIndentations(S.EndToken, below: indentBefore);
            formatter.Visit(E, indentBefore);
            return MutateCSharp.Schemata64.ReplaceBooleanConstant_0(4L, false);
        }

        public StmtExpr Clone(Cloner cloner)
        {
            return new StmtExpr(cloner, this);
        }
    }
}