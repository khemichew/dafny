using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Numerics;
using System.Linq;
using JetBrains.Annotations;
namespace MutateCSharp
{
    internal class Schemata29
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT29");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
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

        internal static bool ReplaceBinExprOp_6(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
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
    /// A ComprehensionExpr has the form:
    ///   BINDER { x [: Type] [<- Domain] [Attributes] [| Range] } [:: Term(x)]
    /// Where BINDER is currently "forall", "exists", "iset"/"set", or "imap"/"map".
    ///
    /// Quantifications used to only support a single range, but now each
    /// quantified variable can have a range attached.
    /// The overall Range is now filled in by the parser by extracting any implicit
    /// "x in Domain" constraints and per-variable Range constraints into a single conjunct.
    ///
    /// The Term is optional if the expression only has one quantified variable,
    /// but required otherwise.
    ///
    /// LambdaExpr also inherits from this base class but isn't really a comprehension,
    /// and should be considered implementation inheritance.
    /// </summary>
    public abstract partial class ComprehensionExpr : Expression, IAttributeBearingDeclaration, IBoundVarsBearingExpression, ICanFormat
    {
        public virtual string WhatKind => MutateCSharp.Schemata29.ReplaceStringConstant_0(1L, "comprehension");
        public readonly List<BoundVar> BoundVars;
        public readonly Expression Range;
        public Expression Term;

        public IEnumerable<BoundVar> AllBoundVars => BoundVars;

        public IToken BodyStartTok = Token.NoToken;

        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(BoundVars != null);
            Contract.Invariant(Term != null);
        }

        public Attributes Attributes;
        Attributes IAttributeBearingDeclaration.Attributes => Attributes;

        [FilledInDuringResolution] public List<BoundedPool> Bounds;
        // invariant Bounds == null || Bounds.Count == BoundVars.Count;

        public List<BoundVar> UncompilableBoundVars()
        {
            Contract.Ensures(Contract.Result<List<BoundVar>>() != null);
            var v = BoundedPool.PoolVirtues.Finite | BoundedPool.PoolVirtues.Enumerable;
            return BoundedPool.MissingBounds(BoundVars, Bounds, v);
        }

        public ComprehensionExpr(IToken tok, RangeToken rangeToken, List<BoundVar> bvars, Expression range, Expression term, Attributes attrs)
          : base(tok)
        {
            Contract.Requires(tok != null);
            Contract.Requires(cce.NonNullElements(bvars));
            Contract.Requires(term != null);

            BoundVars = bvars;
            Range = range;
            Term = term;
            Attributes = attrs;
            BodyStartTok = tok;
            RangeToken = rangeToken;
        }

        protected ComprehensionExpr(Cloner cloner, ComprehensionExpr original) : base(cloner, original)
        {
            BoundVars = original.BoundVars.Select(bv => cloner.CloneBoundVar(bv, MutateCSharp.Schemata29.ReplaceBooleanConstant_1(2L, false))).ToList();
            Range = cloner.CloneExpr(original.Range);
            Attributes = cloner.CloneAttributes(original.Attributes);
            BodyStartTok = cloner.Tok(original.BodyStartTok);
            RangeToken = cloner.Tok(original.RangeToken);
            Term = cloner.CloneExpr(original.Term);

            if (cloner.CloneResolvedFields)
            {
                Bounds = original.Bounds?.Select(b => b?.Clone(cloner)).ToList();
            }
        }
        public override IEnumerable<INode> Children =>
          (MutateCSharp.Schemata29.ReplaceBinExprOp_2(3L, Attributes, null) ? new List<Node> { Attributes } : Enumerable.Empty<Node>()).
          Concat(BoundVars).Concat(SubExpressions);

        public override IEnumerable<INode> PreResolveChildren =>
          (MutateCSharp.Schemata29.ReplaceBinExprOp_2(4L, Attributes, null) ? new List<Node> { Attributes } : Enumerable.Empty<Node>())
          .Concat<Node>(MutateCSharp.Schemata29.ReplaceBinExprOp_6(15L, () => MutateCSharp.Schemata29.ReplaceBinExprOp_3(5L, Range, null), () => MutateCSharp.Schemata29.ReplaceBinExprOp_5(10L, Range.tok.line, MutateCSharp.Schemata29.ReplaceNumericConstant_4(6L, 0))) ? new List<Node>() { Range } : new List<Node>())
          .Concat(MutateCSharp.Schemata29.ReplaceBinExprOp_6(31L, () => MutateCSharp.Schemata29.ReplaceBinExprOp_3(21L, Term, null), () => MutateCSharp.Schemata29.ReplaceBinExprOp_5(26L, Term.tok.line, MutateCSharp.Schemata29.ReplaceNumericConstant_4(22L, 0))) ? new List<Node> { Term } : new List<Node>());

        public override IEnumerable<Expression> SubExpressions
        {
            get
            {
                foreach (var e in Attributes.SubExpressions(Attributes))
                {
                    yield return e;
                }
                if (MutateCSharp.Schemata29.ReplaceBinExprOp_3(37L, Range, null)) { yield return Range; }
                yield return Term;
            }
        }

        public override IEnumerable<Type> ComponentTypes => BoundVars.Select(bv => bv.Type);
        public virtual bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            var alreadyAligned = MutateCSharp.Schemata29.ReplaceBooleanConstant_1(38L, false);
            var assignOpIndent = indentBefore;

            foreach (var token in OwnedTokens)
            {
                switch (token.val)
                {
                    case "forall":
                    case "exists":
                    case "map":
                    case "set":
                    case "imap":
                    case "iset":
                        {
                            indentBefore = formatter.ReduceBlockiness ? indentBefore : formatter.GetNewTokenVisualIndent(token, indentBefore);
                            assignOpIndent = formatter.ReduceBlockiness ? indentBefore + formatter.SpaceTab : indentBefore;
                            formatter.SetOpeningIndentedRegion(token, indentBefore);

                            break;
                        }

                        break;
                    case ":=":
                    case "::":
                        {
                            var afterAssignIndent = (formatter.ReduceBlockiness && token.Prev.line == token.line) || token.line == token.Next.line ? assignOpIndent : assignOpIndent + formatter.SpaceTab;
                            if (alreadyAligned)
                            {
                                formatter.SetIndentations(token, afterAssignIndent, assignOpIndent, afterAssignIndent);
                            }
                            else
                            {
                                if (TokenNewIndentCollector.IsFollowedByNewline(token))
                                {
                                    formatter.SetIndentations(token, afterAssignIndent, assignOpIndent, afterAssignIndent);
                                }
                                else
                                {
                                    alreadyAligned = true;
                                    formatter.SetAlign(assignOpIndent, token, out afterAssignIndent, out assignOpIndent);
                                    assignOpIndent -= 1; // because "::" or ":=" has one more char than a comma 
                                }
                            }
                            break;
                        }

                        break;
                }
            }

            return MutateCSharp.Schemata29.ReplaceBooleanConstant_1(39L, true);
        }
    }
}
