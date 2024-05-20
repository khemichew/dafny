using System.Collections.Generic;
namespace MutateCSharp
{
    internal class Schemata114
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT114");
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
    public class SpecialFunction : Function, ICallable
    {
        readonly ModuleDefinition Module;
        public SpecialFunction(RangeToken rangeToken, string name, ModuleDefinition module, bool hasStaticKeyword, bool isGhost,
          List<TypeParameter> typeArgs, List<Formal> ins, Type resultType,
          List<AttributedExpression> req, Specification<FrameExpression> reads, List<AttributedExpression> ens, Specification<Expression> decreases,
          Expression body, Attributes attributes, IToken signatureEllipsis)
          : base(rangeToken, new Name(name), hasStaticKeyword, isGhost, MutateCSharp.Schemata114.ReplaceBooleanConstant_0(1L, false), typeArgs, ins, null, resultType, req, reads, ens, decreases, body, null, null, attributes, signatureEllipsis)
        {
            Module = module;
        }
        ModuleDefinition IASTVisitorContext.EnclosingModule
        {
            get { return this.Module; }
        }

        string ICallable.NameRelativeToModule
        {
            get { return Name; }
        }
    }
}