using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata185
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT185");
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

        internal static int ReplaceNumericConstant_1(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static int ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 - argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class ArrowTypeDecl : ValuetypeDecl
    {
        public override string WhatKind => MutateCSharp.Schemata185.ReplaceStringConstant_0(1L, "function type");
        public readonly int Arity;
        public readonly Function Requires;
        public readonly Function Reads;

        public ArrowTypeDecl(List<TypeParameter> tps, Function req, Function reads, ModuleDefinition module, Attributes attributes)
          : base(ArrowType.ArrowTypeName(MutateCSharp.Schemata185.ReplaceBinExprOp_2(6L, tps.Count, MutateCSharp.Schemata185.ReplaceNumericConstant_1(2L, 1))), module, tps,
            new List<MemberDecl> { req, reads }, attributes,
            ty =>
              ty.NormalizeExpandKeepConstraints() is UserDefinedType { ResolvedClass: ArrowTypeDecl arrowTypeDecl } && MutateCSharp.Schemata185.ReplaceBinExprOp_3(28L, arrowTypeDecl.Arity, MutateCSharp.Schemata185.ReplaceBinExprOp_2(19L, tps.Count, MutateCSharp.Schemata185.ReplaceNumericConstant_1(15L, 1))),
            null)
        {
            Contract.Requires(tps != null && 1 <= tps.Count);
            Contract.Requires(req != null);
            Contract.Requires(reads != null);
            Contract.Requires(module != null);
            Arity = MutateCSharp.Schemata185.ReplaceBinExprOp_2(37L, tps.Count, MutateCSharp.Schemata185.ReplaceNumericConstant_1(33L, 1));
            Requires = req;
            Reads = reads;
            Requires.EnclosingClass = this;
            Reads.EnclosingClass = this;
        }
    }
}