using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata170
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT170");
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

        internal static int ReplaceNumericConstant_1(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public abstract class Statement : RangeNode, IAttributeBearingDeclaration
    {
        public override IToken Tok => PostLabelToken ?? StartToken;
        public IToken PostLabelToken { get; set; }

        public LList<Label> Labels;  // mutable during resolution

        private Attributes attributes;
        public Attributes Attributes
        {
            get
            {
                return attributes;
            }
            set
            {
                attributes = value;
            }
        }

        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(Tok != null);
        }

        [FilledInDuringResolution]
        public bool IsGhost { get; set; }

        public virtual void GenResolve(INewOrOldResolver resolver, ResolutionContext resolutionContext)
        {
            resolver.ResolveAttributes(this, resolutionContext);
        }

        protected Statement(Cloner cloner, Statement original) : base(cloner.Tok(original.RangeToken))
        {
            cloner.AddStatementClone(original, this);
            this.attributes = cloner.CloneAttributes(original.Attributes);

            if (cloner.CloneResolvedFields)
            {
                IsGhost = original.IsGhost;
                Labels = original.Labels;
            }
        }

        protected Statement(RangeToken rangeToken, Attributes attrs) : base(rangeToken)
        {
            this.attributes = attrs;
        }

        protected Statement(RangeToken rangeToken)
          : this(rangeToken, null)
        {
            Contract.Requires(rangeToken != null);
        }

        /// <summary>
        /// Returns the non-null expressions of this statement proper (that is, do not include the expressions of substatements).
        /// Filters all sub expressions that are not part of specifications
        /// </summary>
        public IEnumerable<Expression> SubExpressionsIncludingTransitiveSubStatements
        {
            get
            {
                foreach (var e in SubExpressions)
                {
                    yield return e;
                }

                foreach (var s in SubStatements)
                {
                    foreach (var e in s.SubExpressionsIncludingTransitiveSubStatements)
                    {
                        yield return e;
                    }
                }

                yield break;
            }
        }

        /// <summary>
        /// Returns the non-null substatements of the Statements.
        /// </summary>
        public virtual IEnumerable<Statement> SubStatements
        {
            get { yield break; }
        }

        /// <summary>
        /// Returns the non-null substatements of the Statements, before resolution occurs
        /// </summary>
        public virtual IEnumerable<Statement> PreResolveSubStatements => SubStatements;

        /// <summary>
        /// Returns the non-null expressions of this statement proper (that is, do not include the expressions of substatements).
        /// Includes both specification and non-specification expressions.
        /// </summary>
        public IEnumerable<Expression> SubExpressions
        {
            get
            {
                foreach (var e in SpecificationSubExpressions)
                {
                    yield return e;
                }

                foreach (var e in NonSpecificationSubExpressions)
                {
                    yield return e;
                }

                yield break;
            }
        }

        /// <summary>
        /// Same as SubExpressions but returns all the SubExpressions before resolution
        /// </summary>
        public virtual IEnumerable<Expression> PreResolveSubExpressions => SubExpressions;

        /// <summary>
        /// Returns the non-null expressions of this statement proper (that is, do not include the expressions of substatements).
        /// Filters only expressions that are always part of specifications
        /// </summary>
        public virtual IEnumerable<Expression> SpecificationSubExpressions
        {
            get
            {
                foreach (var e in Attributes.SubExpressions(Attributes))
                {
                    yield return e;
                }

                yield break;
            }
        }

        /// <summary>
        /// Returns the non-null expressions of this statement proper (that is, do not include the expressions of substatements).
        /// Filters all sub expressions that are not part of specifications
        /// </summary>
        public virtual IEnumerable<Expression> NonSpecificationSubExpressions
        {
            get
            {
                yield break;
            }
        }

        /// <summary>
        /// Create a resolved statement for an uninitialized local variable.
        /// </summary>
        public static VarDeclStmt CreateLocalVariable(IToken tok, string name, Type type)
        {
            Contract.Requires(tok != null);
            Contract.Requires(name != null);
            Contract.Requires(type != null);
            var variable = new LocalVariable(tok.ToRange(), name, type, MutateCSharp.Schemata170.ReplaceBooleanConstant_0(1L, false));
            variable.type = type;
            return new VarDeclStmt(tok.ToRange(), Util.Singleton(variable), null);
        }

        /// <summary>
        /// Create a resolved statement for a local variable with an initial value.
        /// </summary>
        public static VarDeclStmt CreateLocalVariable(IToken tok, string name, Expression value)
        {
            Contract.Requires(tok != null);
            Contract.Requires(name != null);
            Contract.Requires(value != null);
            var rangeToken = new RangeToken(tok, tok);
            var variable = new LocalVariable(rangeToken, name, value.Type, MutateCSharp.Schemata170.ReplaceBooleanConstant_0(2L, false));
            variable.type = value.Type;
            Expression variableExpr = new IdentifierExpr(tok, variable);
            var variableUpdateStmt = new UpdateStmt(rangeToken, Util.Singleton(variableExpr),
              Util.Singleton<AssignmentRhs>(new ExprRhs(value)));
            var variableAssignStmt = new AssignStmt(rangeToken, variableUpdateStmt.Lhss[MutateCSharp.Schemata170.ReplaceNumericConstant_1(3L, 0)], variableUpdateStmt.Rhss[MutateCSharp.Schemata170.ReplaceNumericConstant_1(7L, 0)]);
            variableUpdateStmt.ResolvedStatements = new List<Statement>() { variableAssignStmt };
            return new VarDeclStmt(rangeToken, Util.Singleton(variable), variableUpdateStmt);
        }

        public static PrintStmt CreatePrintStmt(IToken tok, params Expression[] exprs)
        {
            var rangeToken = new RangeToken(tok, tok);
            return new PrintStmt(rangeToken, exprs.ToList());
        }

        public override string ToString()
        {
            try
            {
                return Printer.StatementToString(DafnyOptions.DefaultImmutableOptions, this);
            }
            catch (Exception e)
            {
                return $"couldn't print stmt because: {e.Message}";
            }

            return default;
        }

        public override IEnumerable<INode> Children =>
          (MutateCSharp.Schemata170.ReplaceBinExprOp_2(11L, Attributes, null) ? new List<Node> { Attributes } : Enumerable.Empty<Node>()).Concat(
            SubStatements.Concat<Node>(SubExpressions));

        public override IEnumerable<INode> PreResolveChildren =>
          (MutateCSharp.Schemata170.ReplaceBinExprOp_2(12L, Attributes, null) ? new List<Node> { Attributes } : Enumerable.Empty<Node>()).Concat(
            PreResolveSubStatements).Concat(PreResolveSubExpressions);
    }
}