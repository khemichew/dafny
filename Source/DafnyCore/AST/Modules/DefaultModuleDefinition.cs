using System;
using System.Collections.Generic;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata121
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT121");
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

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class DefaultModuleDefinition : ModuleDefinition, ICloneable<DefaultModuleDefinition>
    {
        public List<Include> Includes { get; } = new();

        public DefaultModuleDefinition(Cloner cloner, DefaultModuleDefinition original) : base(cloner, original, original.NameNode)
        {
        }

        public DefaultModuleDefinition()
          : base(RangeToken.NoToken, new Name(MutateCSharp.Schemata121.ReplaceStringConstant_0(1L, "_module")), new List<IToken>(), ModuleKindEnum.Concrete, MutateCSharp.Schemata121.ReplaceBooleanConstant_1(2L, false),
            null, null, null)
        {
        }

        public override bool IsDefaultModule => MutateCSharp.Schemata121.ReplaceBooleanConstant_1(3L, true);

        public override bool TryToAvoidName => MutateCSharp.Schemata121.ReplaceBinExprOp_2(5L, Name, MutateCSharp.Schemata121.ReplaceStringConstant_0(4L, "_module"));

        public override IEnumerable<INode> Children => Includes.Concat(base.Children);
        public override IEnumerable<INode> PreResolveChildren => Includes.Concat(base.PreResolveChildren);
        public new DefaultModuleDefinition Clone(Cloner cloner)
        {
            return new DefaultModuleDefinition(cloner, this);
        }
    }
}