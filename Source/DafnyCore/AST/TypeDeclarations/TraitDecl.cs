using System.Collections.Generic;
using Microsoft.Dafny.Auditor;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata199
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT199");
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

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.NonNullTypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() == argument2();
        }

    }
}

namespace Microsoft.Dafny
{
    public class TraitDecl : ClassLikeDecl
    {
        public override string WhatKind => MutateCSharp.Schemata199.ReplaceStringConstant_0(1L, "trait");
        public bool IsParent { set; get; }

        public override bool AcceptThis => MutateCSharp.Schemata199.ReplaceBooleanConstant_1(2L, true);

        internal void SetUpAsReferenceType(bool isReferenceType)
        {
            // Note, it's important to set .NonNullTypeDecl first, before calling NewSelfSynonym(), since the latter will look at the former.
            Contract.Assert(NonNullTypeDecl == null); // SetUpAsReferenceType should be called only once
            if (isReferenceType)
            {
                NonNullTypeDecl = new NonNullTypeDecl(this);
            }

            this.NewSelfSynonym();
        }

        public override bool IsReferenceTypeDecl => MutateCSharp.Schemata199.ReplaceBinExprOp_2(3L, NonNullTypeDecl, null);

        /// <summary>
        /// This constructor creates a TraitDecl object. However, before the object really functions as a TraitDecl, it is necessary
        /// to call SetUpAsReferenceType, which sets .NonNullTypeDecl (if necessary) and calls NewSelfSynonym().
        /// </summary>
        public TraitDecl(RangeToken rangeToken, Name name, ModuleDefinition module,
          List<TypeParameter> typeArgs, [Captured] List<MemberDecl> members, Attributes attributes, bool isRefining, List<Type> /*?*/ traits)
          : base(rangeToken, name, module, typeArgs, members, attributes, isRefining, traits)
        {
        }

        public override IEnumerable<Assumption> Assumptions(Declaration decl)
        {
            foreach (var assumption in base.Assumptions(this))
            {
                yield return assumption;
            }

            if (Attributes.Find(Attributes, "termination") is { } ta &&
                ta.Args.Count == 1 && Expression.IsBoolLiteral(ta.Args[0], out var termCheck) &&
        MutateCSharp.Schemata199.ReplaceBinExprOp_3(5L, () => termCheck, () => MutateCSharp.Schemata199.ReplaceBooleanConstant_1(4L, false)))
            {
                yield return new Assumption(this, tok, AssumptionDescription.HasTerminationFalseAttribute);
            }

            yield break;
        }
    }
}