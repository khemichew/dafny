using System.Collections.Generic;
using System.CommandLine;
using System.Linq;
using DafnyCore;
using DafnyCore.Options;
namespace MutateCSharp
{
    internal class Schemata109
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT109");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() || argument2();
        }

        internal static int ReplaceNumericConstant_5(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
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

        internal static bool ReplaceBinExprOp_6(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.ModuleKindEnum argument1, Microsoft.Dafny.ModuleKindEnum argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public abstract class MethodOrFunction : MemberDecl
    {
        public static readonly Option<bool> AllowExternalContracts = new(MutateCSharp.Schemata109.ReplaceStringConstant_0(1L, "--allow-external-contracts"),
      MutateCSharp.Schemata109.ReplaceStringConstant_0(2L, "Allow exporting callables with preconditions, and importing callables with postconditions"));

        static MethodOrFunction()
        {
            DooFile.RegisterLibraryCheck(AllowExternalContracts, OptionCompatibility.OptionLibraryImpliesLocalError);
        }

        public readonly List<TypeParameter> TypeArgs;
        public readonly List<AttributedExpression> Req;
        public readonly List<AttributedExpression> Ens;
        public readonly Specification<Expression> Decreases;
        public readonly List<Formal> Ins;

        protected MethodOrFunction(RangeToken rangeToken, Name name, bool hasStaticKeyword, bool isGhost,
          Attributes attributes, bool isRefining, List<TypeParameter> typeArgs, List<Formal> ins,
          List<AttributedExpression> req,
          List<AttributedExpression> ens,
          Specification<Expression> decreases)
          : base(rangeToken, name, hasStaticKeyword, isGhost, attributes, isRefining)
        {
            TypeArgs = typeArgs;
            Req = req;
            Decreases = decreases;
            Ens = ens;
            Ins = ins;
        }

        protected MethodOrFunction(Cloner cloner, MethodOrFunction original) : base(cloner, original)
        {
            this.TypeArgs = cloner.CloneResolvedFields ? original.TypeArgs : original.TypeArgs.ConvertAll(cloner.CloneTypeParam);
            this.Req = original.Req.ConvertAll(cloner.CloneAttributedExpr);
            this.Decreases = cloner.CloneSpecExpr(original.Decreases);
            this.Ens = original.Ens.ConvertAll(cloner.CloneAttributedExpr);
            this.Ins = original.Ins.ConvertAll(p => cloner.CloneFormal(p, MutateCSharp.Schemata109.ReplaceBooleanConstant_1(3L, false)));
        }

        protected abstract bool Bodyless { get; }
        protected abstract string TypeName { get; }

        public bool IsVirtual => MutateCSharp.Schemata109.ReplaceBinExprOp_2(4L, () => EnclosingClass is TraitDecl, () => !IsStatic);
        public bool IsAbstract => MutateCSharp.Schemata109.ReplaceBinExprOp_3(10L, EnclosingClass.EnclosingModuleDefinition.ModuleKind, ModuleKindEnum.Concrete);

        public virtual void Resolve(ModuleResolver resolver)
        {
            ResolveMethodOrFunction(resolver);
        }

        public abstract bool HasPostcondition { get; }

        public void ResolveMethodOrFunction(INewOrOldResolver resolver)
        {
            var isImported = MutateCSharp.Schemata109.ReplaceBinExprOp_2(17L, () => (MutateCSharp.Schemata109.ReplaceBinExprOp_4(11L, () => Bodyless, () => !ProgramResolver.ShouldCompile(this))), () => this.IsExtern(resolver.Options));
            if (MutateCSharp.Schemata109.ReplaceBinExprOp_2(35L, () => MutateCSharp.Schemata109.ReplaceBinExprOp_2(29L, () => MutateCSharp.Schemata109.ReplaceBinExprOp_2(23L, () => !resolver.Options.Get(AllowExternalContracts), () => HasPostcondition), () => isImported), () => !HasAxiomAttribute))
            {
                resolver.Reporter.Warning(MessageSource.Verifier, ResolutionErrors.ErrorId.none, Tok,
                  $"when a {WhatKind} is imported, meaning it has no body and an {{:extern}} annotation, " +
                  $"Dafny can not guarantee that its implementation satisfies its post-conditions (its ensures clauses and outputs that are subset types). " +
                  $"To silence this warning, please add an {{:axiom}} attribute or use the option '--allow-external-contracts'.");
            }

            var isExported = MutateCSharp.Schemata109.ReplaceBinExprOp_2(47L, () => MutateCSharp.Schemata109.ReplaceBinExprOp_2(41L, () => !Bodyless, () => ProgramResolver.ShouldCompile(this)), () => this.IsExtern(resolver.Options));
            if (MutateCSharp.Schemata109.ReplaceBinExprOp_2(65L, () => MutateCSharp.Schemata109.ReplaceBinExprOp_2(59L, () => MutateCSharp.Schemata109.ReplaceBinExprOp_2(53L, () => !resolver.Options.Get(AllowExternalContracts), () => HasPrecondition), () => !HasAxiomAttribute), () => isExported))
            {
                resolver.Reporter.Warning(MessageSource.Verifier, ResolutionErrors.ErrorId.none, Tok,
                  $"when a {WhatKind} is exported, meaning it has a body and an {{:extern}} annotation, " +
                  $"Dafny can not guarantee that it is called with arguments that satisfy its preconditions (its requires clauses and inputs that are subset types). " +
                  $"To silence this warning, please add an {{:axiom}} attribute or use the option '--allow-external-contracts'");
            }
            if (MutateCSharp.Schemata109.ReplaceBinExprOp_2(71L, () => !AutoGeneratedToken.Is(RangeToken), () => HasVerifyFalseAttribute))
            {
                resolver.Reporter.Warning(MessageSource.Verifier, ResolutionErrors.ErrorId.none, Tok,
                  $"The {{:verify false}} attribute should only be used during development. " +
                  $"Consider using a bodyless {WhatKind} together with the {{:axiom}} attribute instead");
            }
            else if (MutateCSharp.Schemata109.ReplaceBinExprOp_2(101L, () => MutateCSharp.Schemata109.ReplaceBinExprOp_2(95L, () => MutateCSharp.Schemata109.ReplaceBinExprOp_2(89L, () => MutateCSharp.Schemata109.ReplaceBinExprOp_2(83L, () => MutateCSharp.Schemata109.ReplaceBinExprOp_2(77L, () => !AutoGeneratedToken.Is(RangeToken), () => Bodyless), () => !IsVirtual), () => !IsAbstract
        ), () => !this.IsExtern(resolver.Options)), () => !this.IsExplicitAxiom()))
            {
                foreach (var ensures in Ens)
                {
                    if (MutateCSharp.Schemata109.ReplaceBinExprOp_2(107L, () => !ensures.IsExplicitAxiom(), () => !resolver.Options.Get(CommonOptionBag.AllowAxioms)))
                    {
                        resolver.Reporter.Warning(MessageSource.Verifier, ResolutionErrors.ErrorId.none, ensures.Tok,
                          $"This ensures clause is part of a bodyless {TypeName}. Add the {{:axiom}} attribute to it or the enclosing {TypeName} to suppress this warning");
                    }
                }

            }
        }

        public bool HasPrecondition => MutateCSharp.Schemata109.ReplaceBinExprOp_4(122L, () => MutateCSharp.Schemata109.ReplaceBinExprOp_6(117L, Req.Count, MutateCSharp.Schemata109.ReplaceNumericConstant_5(113L, 0
                                       )), () => Ins.Any(f => f.Type.AsSubsetType is not null));

        protected MethodOrFunction(RangeToken tok, Name name, bool hasStaticKeyword, bool isGhost, Attributes attributes, bool isRefining) : base(tok, name, hasStaticKeyword, isGhost, attributes, isRefining)
        {
        }
    }
}