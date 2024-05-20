using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata139
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT139");
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

        internal static bool ReplaceBinExprOp_1(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static string ReplaceStringConstant_3(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{

    /// <summary>
    /// Common superclass of UpdateStmt, AssignSuchThatStmt and AssignOrReturnStmt
    /// </summary>
    public abstract class ConcreteUpdateStatement : Statement, ICanFormat
    {
        public readonly List<Expression> Lhss;

        protected ConcreteUpdateStatement(Cloner cloner, ConcreteUpdateStatement original) : base(cloner, original)
        {
            Lhss = original.Lhss.Select(cloner.CloneExpr).ToList();
        }

        public ConcreteUpdateStatement(RangeToken rangeToken, List<Expression> lhss, Attributes attrs = null)
          : base(rangeToken, attrs)
        {
            Contract.Requires(cce.NonNullElements(lhss));
            Lhss = lhss;
        }

        public override IEnumerable<INode> Children => Lhss;
        public override IEnumerable<INode> PreResolveChildren => Lhss;

        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            return formatter.SetIndentUpdateStmt(this, indentBefore, MutateCSharp.Schemata139.ReplaceBooleanConstant_0(1L, false));
        }

        public virtual void Resolve(ModuleResolver resolver, ResolutionContext context)
        {
            GenResolve(resolver, context);
        }

        public override void GenResolve(INewOrOldResolver resolver, ResolutionContext context)
        {
            foreach (var lhs in Lhss)
            {
                var ec = resolver.Reporter.Count(ErrorLevel.Error);
                resolver.ResolveExpression(lhs, context);
                if (MutateCSharp.Schemata139.ReplaceBinExprOp_1(2L, ec, resolver.Reporter.Count(ErrorLevel.Error)))
                {
                    if (MutateCSharp.Schemata139.ReplaceBinExprOp_2(7L, () => lhs is SeqSelectExpr, () => !((SeqSelectExpr)lhs).SelectOne))
                    {
                        resolver.Reporter.Error(MessageSource.Resolver, lhs, MutateCSharp.Schemata139.ReplaceStringConstant_3(13L, "cannot assign to a range of array elements (try the 'forall' statement)"));
                    }
                }
            }

            base.GenResolve(resolver, context);
        }
    }
}