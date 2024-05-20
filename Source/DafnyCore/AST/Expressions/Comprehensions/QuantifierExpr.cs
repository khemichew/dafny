using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata34
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT34");
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

        internal static bool ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_3(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
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

        internal static bool ReplaceBinExprOp_4(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public abstract class QuantifierExpr : ComprehensionExpr, TypeParameter.ParentType
    {
        public override string WhatKind => MutateCSharp.Schemata34.ReplaceStringConstant_0(1L, "quantifier");

        private readonly int UniqueId;
        private static int currentQuantId = MutateCSharp.Schemata34.ReplaceNumericConstant_1(2L, -1);

        protected virtual BinaryExpr.ResolvedOpcode SplitResolvedOp => BinaryExpr.ResolvedOpcode.Or;

        private Expression SplitQuantifierToExpression()
        {
            Contract.Requires(SplitQuantifier != null && SplitQuantifier.Any());
            Expression accumulator = SplitQuantifier[MutateCSharp.Schemata34.ReplaceNumericConstant_1(6L, 0)];
            for (int tid = MutateCSharp.Schemata34.ReplaceNumericConstant_1(10L, 1); MutateCSharp.Schemata34.ReplaceBinExprOp_2(14L, tid, SplitQuantifier.Count); MutateCSharp.Schemata34.ReplacePostfixUnaryExprOp_3(19L, ref tid))
            {
                accumulator = new BinaryExpr(Term.tok, SplitResolvedOp, accumulator, SplitQuantifier[tid]);
            }
            return accumulator;
        }

        private List<Expression> _SplitQuantifier;
        public List<Expression> SplitQuantifier
        {
            get
            {
                return _SplitQuantifier;
            }
            set
            {
                Contract.Assert(!value.Contains(this)); // don't let it put into its own split quantifiers.
                _SplitQuantifier = value;
                SplitQuantifierExpression = SplitQuantifierToExpression();
            }
        }

        internal Expression SplitQuantifierExpression { get; private set; }

        static int FreshQuantId()
        {
            return System.Threading.Interlocked.Increment(ref currentQuantId);
        }

        public string FullName
        {
            get
            {
                return MutateCSharp.Schemata34.ReplaceStringConstant_0(20L, "q$") + UniqueId;
            }
        }

        public String Refresh(string prefix, FreshIdGenerator idGen)
        {
            return idGen.FreshId(prefix);
        }

        public QuantifierExpr(IToken tok, RangeToken rangeToken, List<BoundVar> bvars, Expression range, Expression term, Attributes attrs)
          : base(tok, rangeToken, bvars, range, term, attrs)
        {
            Contract.Requires(tok != null);
            Contract.Requires(cce.NonNullElements(bvars));
            Contract.Requires(term != null);
            this.UniqueId = FreshQuantId();
        }

        protected QuantifierExpr(Cloner cloner, QuantifierExpr original) : base(cloner, original)
        {
            if (cloner.CloneResolvedFields)
            {
                if (MutateCSharp.Schemata34.ReplaceBinExprOp_4(21L, original.SplitQuantifier, null))
                {
                    SplitQuantifier = original.SplitQuantifier.Select(cloner.CloneExpr).ToList();
                }
            }
            this.UniqueId = FreshQuantId();
        }

        public virtual Expression LogicalBody(bool bypassSplitQuantifier = false)
        {
            // Don't call this on a quantifier with a Split clause: it's not a real quantifier. The only exception is the Compiler.
            Contract.Requires(bypassSplitQuantifier || SplitQuantifier == null);
            throw new cce.UnreachableException(); // This body is just here for the "Requires" clause
            return default;
        }

        public override IEnumerable<INode> PreResolveChildren => base.SubExpressions;
        public IEnumerable<Expression> PreResolveSubExpressions => base.SubExpressions;

        public override IEnumerable<Expression> SubExpressions
        {
            get
            {
                foreach (var e in base.SubExpressions)
                {
                    yield return e;
                }
                foreach (var e in Attributes.SubExpressions(Attributes))
                {
                    yield return e;
                }

                if (MutateCSharp.Schemata34.ReplaceBinExprOp_4(22L, SplitQuantifier, null))
                {
                    foreach (var e in SplitQuantifier)
                    {
                        yield return e;
                    }
                }

                yield break;
            }
        }

        public IEnumerable<Expression> SplitOrSubExpressions
        {
            get
            {
                foreach (var e in Attributes.SubExpressions(Attributes))
                {
                    yield return e;
                }
                if (MutateCSharp.Schemata34.ReplaceBinExprOp_5(23L, SplitQuantifier, null))
                {
                    foreach (var e in base.SubExpressions)
                    {
                        yield return e;
                    }
                }
                else
                {
                    foreach (var e in SplitQuantifier)
                    {
                        yield return e;
                    }
                }

                yield break;
            }
        }
    }
}
