using System.Collections.Generic;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata134
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT134");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public abstract class AssignmentRhs : TokenNode, IAttributeBearingDeclaration
    {
        private Attributes attributes;

        public Attributes Attributes
        {
            get { return attributes; }
            set { attributes = value; }
        }

        public bool HasAttributes()
        {
            return MutateCSharp.Schemata134.ReplaceBinExprOp_0(1L, Attributes, null);
        }

        internal AssignmentRhs(Cloner cloner, AssignmentRhs original)
        {
            tok = cloner.Tok(original.tok);
            Attributes = cloner.CloneAttributes(original.Attributes);
            RangeToken = cloner.Range(original.rangeToken);
        }

        internal AssignmentRhs(IToken tok, Attributes attrs = null)
        {
            this.tok = tok;
            Attributes = attrs;
        }

        public abstract bool CanAffectPreviouslyKnownExpressions { get; }

        /// <summary>
        /// Returns all (specification and non-specification) non-null expressions of the AssignmentRhs.
        /// </summary>
        public IEnumerable<Expression> SubExpressions => SpecificationSubExpressions.Concat(NonSpecificationSubExpressions);

        /// <summary>
        /// Returns the non-null non-specification subexpressions of the AssignmentRhs.
        /// </summary>
        public virtual IEnumerable<Expression> NonSpecificationSubExpressions
        {
            get { yield break; }
        }

        /// <summary>
        /// Returns the non-null specification subexpressions of the AssignmentRhs.
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
        /// Returns the non-null subexpressions before resolution of the AssignmentRhs.
        /// </summary>
        public virtual IEnumerable<Expression> PreResolveSubExpressions
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
        /// Returns the non-null sub-statements of the AssignmentRhs.
        /// </summary>
        public virtual IEnumerable<Statement> SubStatements
        {
            get { yield break; }
        }

        public virtual IEnumerable<Statement> PreResolveSubStatements => SubStatements;
    }
}