using System.Collections.Generic;
using System.Diagnostics.Contracts;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
namespace MutateCSharp
{
    internal class Schemata99
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT99");
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

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class Constructor : Method
    {
        public override string WhatKind => MutateCSharp.Schemata99.ReplaceStringConstant_0(1L, "constructor");
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(Body == null || Body is DividedBlockStmt);
        }

        public override SymbolKind Kind => SymbolKind.Constructor;
        protected override string GetQualifiedName()
        {
            return EnclosingClass.Name;
        }

        public List<Statement> BodyInit
        {
            get
            {
                if (MutateCSharp.Schemata99.ReplaceBinExprOp_1(2L, Body, null))
                {
                    return null;
                }
                else
                {
                    return ((DividedBlockStmt)Body).BodyInit;
                }

                return default;
            }
        }

        public List<Statement> BodyProper
        {
            get
            {
                if (MutateCSharp.Schemata99.ReplaceBinExprOp_1(3L, Body, null))
                {
                    return null;
                }
                else
                {
                    return ((DividedBlockStmt)Body).BodyProper;
                }

                return default;
            }
        }

        public Constructor(RangeToken rangeToken, Name name,
            bool isGhost,
            List<TypeParameter> typeArgs,
            List<Formal> ins,
            List<AttributedExpression> req,
            Specification<FrameExpression> reads,
            [Captured] Specification<FrameExpression> mod,
            List<AttributedExpression> ens,
            Specification<Expression> decreases,
            DividedBlockStmt body,
            Attributes attributes, IToken signatureEllipsis)
            : base(rangeToken, name, MutateCSharp.Schemata99.ReplaceBooleanConstant_2(4L, false), isGhost, typeArgs, ins, new List<Formal>(), req, reads, mod, ens, decreases, body, attributes, signatureEllipsis)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            Contract.Requires(cce.NonNullElements(typeArgs));
            Contract.Requires(cce.NonNullElements(ins));
            Contract.Requires(cce.NonNullElements(req));
            Contract.Requires(mod != null);
            Contract.Requires(cce.NonNullElements(ens));
            Contract.Requires(decreases != null);
        }

        public Constructor(Cloner cloner, Constructor original) : base(cloner, original)
        {
        }

        public bool HasName
        {
            get
            {
                return MutateCSharp.Schemata99.ReplaceBinExprOp_3(6L, Name, MutateCSharp.Schemata99.ReplaceStringConstant_0(5L, "_ctor"));
            }
        }
    }
}