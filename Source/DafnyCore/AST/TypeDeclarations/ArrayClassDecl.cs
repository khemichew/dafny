using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata184
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT184");
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

        internal static int ReplaceNumericConstant_2(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public class ArrayClassDecl : ClassDecl
    {
        public override string WhatKind => MutateCSharp.Schemata184.ReplaceStringConstant_0(1L, "array type");

        public readonly int Dims;
        public ArrayClassDecl(int dims, ModuleDefinition module, Attributes attrs)
          : base(RangeToken.NoToken, new Name(SystemModuleManager.ArrayClassName(dims)), module,
            new List<TypeParameter>(new TypeParameter[] { new TypeParameter(RangeToken.NoToken, new Name(MutateCSharp.Schemata184.ReplaceStringConstant_0(2L, "arg")), TypeParameter.TPVarianceSyntax.NonVariant_Strict) }),
            new List<MemberDecl>(), attrs, MutateCSharp.Schemata184.ReplaceBooleanConstant_1(3L, false), null)
        {
            Contract.Requires(1 <= dims);
            Contract.Requires(module != null);

            Dims = dims;
            // Resolve type parameter
            Contract.Assert(TypeArgs.Count == 1);
            var tp = TypeArgs[MutateCSharp.Schemata184.ReplaceNumericConstant_2(4L, 0)];
            tp.Parent = this;
            tp.PositionalIndex = MutateCSharp.Schemata184.ReplaceNumericConstant_2(8L, 0);
        }
    }
}