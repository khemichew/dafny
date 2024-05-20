using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata71
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT71");
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

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    [DebuggerDisplay("Bound<{name}>")]
    public class BoundVar : NonglobalVariable
    {
        public override bool IsMutable => MutateCSharp.Schemata71.ReplaceBooleanConstant_0(1L, false);
        public BoundVar(IToken tok, string name, Type type)
          : base(tok, name, type, MutateCSharp.Schemata71.ReplaceBooleanConstant_0(2L, false))
        {
            Contract.Requires(tok != null);
            Contract.Requires(name != null);
            Contract.Requires(type != null);
        }
    }

    /// <summary>
    /// A QuantifiedVar is a bound variable used in a quantifier such as "forall x :: ...",
    /// a comprehension such as "set x | 0 <= x < 10", etc.
    /// In addition to its type, which may be inferred, it can have an optional domain collection expression
    /// (x <- C) and an optional range boolean expressions (x | E).
    /// </summary>
    [DebuggerDisplay("Quantified<{name}>")]
    public class QuantifiedVar : BoundVar
    {
        public readonly Expression Domain;
        public readonly Expression Range;

        public QuantifiedVar(IToken tok, string name, Type type, Expression domain, Expression range)
          : base(tok, name, type)
        {
            Contract.Requires(tok != null);
            Contract.Requires(name != null);
            Contract.Requires(type != null);
            Domain = domain;
            Range = range;
        }

        /// <summary>
        /// Map a list of quantified variables to an eqivalent list of bound variables plus a single range expression.
        /// The transformation looks like this in general:
        ///
        /// x1 <- C1 | E1, ..., xN <- CN | EN
        ///
        /// becomes:
        ///
        /// x1, ... xN | x1 in C1 && E1 && ... && xN in CN && EN
        ///
        /// Note the result will be null rather than "true" if there are no such domains or ranges.
        /// Some quantification contexts (such as comprehensions) will replace this with "true".
        /// </summary>
        public static void ExtractSingleRange(List<QuantifiedVar> qvars, out List<BoundVar> bvars, out Expression range)
        {
            bvars = new List<BoundVar>();
            range = null;

            foreach (var qvar in qvars)
            {
                BoundVar bvar = new BoundVar(qvar.tok, qvar.Name, qvar.SyntacticType);
                bvars.Add(bvar);

                if (MutateCSharp.Schemata71.ReplaceBinExprOp_1(3L, qvar.Domain, null))
                {
                    // Attach a token wrapper so we can produce a better error message if the domain is not a collection
                    var domainWithToken = QuantifiedVariableDomainCloner.Instance.CloneExpr(qvar.Domain);
                    var inDomainExpr = new BinaryExpr(domainWithToken.tok, BinaryExpr.Opcode.In, new IdentifierExpr(bvar.tok, bvar), domainWithToken);
                    range = MutateCSharp.Schemata71.ReplaceBinExprOp_2(4L, range, null) ? inDomainExpr : new BinaryExpr(domainWithToken.tok, BinaryExpr.Opcode.And, range, inDomainExpr);
                }

                if (MutateCSharp.Schemata71.ReplaceBinExprOp_1(5L, qvar.Range, null))
                {
                    // Attach a token wrapper so we can produce a better error message if the range is not a boolean expression
                    var rangeWithToken = QuantifiedVariableRangeCloner.Instance.CloneExpr(qvar.Range);
                    range = MutateCSharp.Schemata71.ReplaceBinExprOp_2(6L, range, null) ? qvar.Range : new BinaryExpr(rangeWithToken.tok, BinaryExpr.Opcode.And, range, rangeWithToken);
                }
            }
        }
    }

    /// <summary>
    /// An expression introducting bound variables
    /// </summary>
    public interface IBoundVarsBearingExpression
    {
        public IEnumerable<BoundVar> AllBoundVars { get; }
    }

    public
    class QuantifiedVariableDomainCloner : Cloner
    {
        public static readonly QuantifiedVariableDomainCloner Instance = new QuantifiedVariableDomainCloner();
        private QuantifiedVariableDomainCloner() { }
        public override IToken Tok(IToken tok)
        {
            return new QuantifiedVariableDomainToken(tok);
        }
    }

    public
    class QuantifiedVariableRangeCloner : Cloner
    {
        public static readonly QuantifiedVariableRangeCloner Instance = new QuantifiedVariableRangeCloner();
        private QuantifiedVariableRangeCloner() { }
        public override IToken Tok(IToken tok)
        {
            return new QuantifiedVariableRangeToken(tok);
        }
    }
}