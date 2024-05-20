using System.Collections.Generic;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata165
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT165");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.AssignmentRhs> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.UpdateStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.UpdateStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public abstract class ProduceStmt : Statement
    {
        public List<AssignmentRhs> Rhss;
        [FilledInDuringResolution]
        public UpdateStmt HiddenUpdate;

        protected ProduceStmt(Cloner cloner, ProduceStmt original) : base(cloner, original)
        {
            if (MutateCSharp.Schemata165.ReplaceBinExprOp_0(1L, original.Rhss, null))
            {
                Rhss = original.Rhss.Select(cloner.CloneRHS).ToList();
            }
            if (cloner.CloneResolvedFields)
            {
                if (MutateCSharp.Schemata165.ReplaceBinExprOp_1(2L, original.HiddenUpdate, null))
                {
                    HiddenUpdate = new UpdateStmt(cloner, original.HiddenUpdate);
                }
            }
        }

        public ProduceStmt(RangeToken rangeToken, List<AssignmentRhs> rhss)
          : base(rangeToken)
        {
            this.Rhss = rhss;
            HiddenUpdate = null;
        }

        public override IEnumerable<INode> Children => MutateCSharp.Schemata165.ReplaceBinExprOp_2(3L, HiddenUpdate, null) ? base.Children : new Node[] { HiddenUpdate }.Concat(base.Children);

        public override IEnumerable<Expression> NonSpecificationSubExpressions
        {
            get
            {
                foreach (var e in base.NonSpecificationSubExpressions) { yield return e; }
                foreach (var rhs in Rhss ?? Enumerable.Empty<AssignmentRhs>())
                {
                    foreach (var e in rhs.NonSpecificationSubExpressions)
                    {
                        yield return e;
                    }
                }

                yield break;
            }
        }

        public override IEnumerable<Expression> SpecificationSubExpressions
        {
            get
            {
                foreach (var e in base.SpecificationSubExpressions) { yield return e; }
                foreach (var rhs in Rhss ?? Enumerable.Empty<AssignmentRhs>())
                {
                    foreach (var e in rhs.SpecificationSubExpressions)
                    {
                        yield return e;
                    }
                }

                yield break;
            }
        }

        public override IEnumerable<Statement> SubStatements
        {
            get
            {
                foreach (var rhs in Rhss ?? Enumerable.Empty<AssignmentRhs>())
                {
                    foreach (var s in rhs.SubStatements)
                    {
                        yield return s;
                    }
                }

                yield break;
            }
        }

        public override IEnumerable<Statement> PreResolveSubStatements
        {
            get
            {
                if (MutateCSharp.Schemata165.ReplaceBinExprOp_0(4L, Rhss, null))
                {
                    foreach (var rhs in Rhss)
                    {
                        foreach (var s in rhs.PreResolveSubStatements)
                        {
                            yield return s;
                        }
                    }
                }

                yield break;
            }
        }
    }
}