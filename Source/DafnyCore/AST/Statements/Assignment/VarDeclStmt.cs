using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata146
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT146");
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

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.ConcreteUpdateStatement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class VarDeclStmt : Statement, ICloneable<VarDeclStmt>, ICanFormat
    {
        public readonly List<LocalVariable> Locals;
        public readonly ConcreteUpdateStatement Update;
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(cce.NonNullElements(Locals));
            Contract.Invariant(Locals.Count != 0);
        }

        public VarDeclStmt Clone(Cloner cloner)
        {
            return new VarDeclStmt(cloner, this);
        }

        public VarDeclStmt(Cloner cloner, VarDeclStmt original) : base(cloner, original)
        {
            Locals = original.Locals.Select(l => cloner.CloneLocalVariable(l, MutateCSharp.Schemata146.ReplaceBooleanConstant_0(1L, false))).ToList();
            Update = (ConcreteUpdateStatement)cloner.CloneStmt(original.Update, MutateCSharp.Schemata146.ReplaceBooleanConstant_0(2L, false));
        }

        public VarDeclStmt(RangeToken rangeToken, List<LocalVariable> locals, ConcreteUpdateStatement update)
          : base(rangeToken)
        {
            Contract.Requires(locals != null);
            Contract.Requires(locals.Count != 0);

            Locals = locals;
            Update = update;
        }

        public override IEnumerable<Statement> SubStatements
        {
            get
            {
                if (MutateCSharp.Schemata146.ReplaceBinExprOp_1(3L, Update, null)) { yield return Update; }

                yield break;
            }
        }

        public override IEnumerable<Expression> SpecificationSubExpressions
        {
            get
            {
                foreach (var e in base.SpecificationSubExpressions) { yield return e; }
                foreach (var v in Locals)
                {
                    foreach (var e in Attributes.SubExpressions(v.Attributes))
                    {
                        yield return e;
                    }
                }

                if (MutateCSharp.Schemata146.ReplaceBinExprOp_1(4L, this.Update, null))
                {
                    foreach (var e in this.Update.NonSpecificationSubExpressions)
                    {
                        yield return e;
                    }
                }

                yield break;
            }
        }

        public override IEnumerable<INode> Children => Locals.Concat<Node>(SubStatements);

        public override IEnumerable<INode> PreResolveChildren => Children;
        public bool SetIndent(int indentBefore, TokenNewIndentCollector formatter)
        {
            var result = formatter.SetIndentVarDeclStmt(indentBefore, OwnedTokens, MutateCSharp.Schemata146.ReplaceBooleanConstant_0(5L, false), MutateCSharp.Schemata146.ReplaceBooleanConstant_0(6L, false));
            return MutateCSharp.Schemata146.ReplaceBinExprOp_1(7L, Update, null) ? formatter.SetIndentUpdateStmt(Update, indentBefore, MutateCSharp.Schemata146.ReplaceBooleanConstant_0(8L, true)) : result;
        }
    }
}