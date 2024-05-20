using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using Microsoft.Dafny.Auditor;
namespace MutateCSharp
{
    internal class Schemata191
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT191");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_3(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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
    public abstract class Declaration : RangeNode, IAttributeBearingDeclaration, IDeclarationOrUsage
    {
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(Name != null);
        }

        public IToken BodyStartTok = Token.NoToken;
        public IToken TokenWithTrailingDocString = Token.NoToken;
        public Name NameNode;

        public override IToken Tok => NameNode.StartToken;
        public IToken NameToken => NameNode.StartToken;

        public string Name => NameNode.Value;
        public bool IsRefining;

        private VisibilityScope opaqueScope = new();
        private VisibilityScope revealScope = new();

        private bool scopeIsInherited = MutateCSharp.Schemata191.ReplaceBooleanConstant_0(1L, false);

        protected Declaration(Cloner cloner, Declaration original) : base(cloner, original)
        {
            NameNode = original.NameNode.Clone(cloner);
            BodyStartTok = cloner.Tok(original.BodyStartTok);
            Attributes = cloner.CloneAttributes(original.Attributes);
        }

        protected Declaration(RangeToken rangeToken, Name name, Attributes attributes, bool isRefining) : base(rangeToken)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            this.NameNode = name;
            this.Attributes = attributes;
            this.IsRefining = isRefining;
        }

        public bool HasAxiomAttribute =>
          Attributes.Contains(Attributes, Attributes.AxiomAttributeName);

        public bool HasConcurrentAttribute =>
          Attributes.Contains(Attributes, Attributes.ConcurrentAttributeName);

        public bool HasExternAttribute =>
          Attributes.Contains(Attributes, Attributes.ExternAttributeName);

        public bool HasAutoGeneratedAttribute =>
          Attributes.Contains(Attributes, Attributes.AutoGeneratedAttributeName);

        public bool HasVerifyFalseAttribute =>
          Attributes.Find(Attributes, Attributes.VerifyAttributeName) is { } va &&
          va.Args.Count == 1 &&
          Expression.IsBoolLiteral(va.Args[0], out var verify) &&
      MutateCSharp.Schemata191.ReplaceBinExprOp_1(3L, () => verify, () => MutateCSharp.Schemata191.ReplaceBooleanConstant_0(2L, false));

        public override IEnumerable<Assumption> Assumptions(Declaration decl)
        {
            if (MutateCSharp.Schemata191.ReplaceBinExprOp_2(9L, () => HasAxiomAttribute, () => !HasAutoGeneratedAttribute))
            {
                yield return new Assumption(this, tok, AssumptionDescription.HasAxiomAttribute);
            }

            if (MutateCSharp.Schemata191.ReplaceBinExprOp_2(15L, () => HasVerifyFalseAttribute, () => !HasAutoGeneratedAttribute))
            {
                yield return new Assumption(this, tok, AssumptionDescription.HasVerifyFalseAttribute);
            }

            yield break;
        }

        public virtual bool CanBeExported()
        {
            return MutateCSharp.Schemata191.ReplaceBooleanConstant_0(21L, true);
        }

        public virtual bool CanBeRevealed()
        {
            return MutateCSharp.Schemata191.ReplaceBooleanConstant_0(22L, false);
        }

        public bool ScopeIsInherited
        {
            get { return scopeIsInherited; }
        }

        public void AddVisibilityScope(VisibilityScope scope, bool isOpaque)
        {
            if (isOpaque)
            {
                opaqueScope.Augment(scope);
            }
            else
            {
                revealScope.Augment(scope);
            }
        }

        public void InheritVisibility(Declaration d, bool onlyRevealed = true)
        {
            Contract.Assert(opaqueScope.IsEmpty());
            Contract.Assert(revealScope.IsEmpty());
            scopeIsInherited = MutateCSharp.Schemata191.ReplaceBooleanConstant_0(23L, false);

            revealScope = d.revealScope;

            if (!onlyRevealed)
            {
                opaqueScope = d.opaqueScope;
            }
            scopeIsInherited = MutateCSharp.Schemata191.ReplaceBooleanConstant_0(24L, true);

        }

        public bool IsRevealedInScope(VisibilityScope scope)
        {
            return revealScope.VisibleInScope(scope);
        }

        public bool IsVisibleInScope(VisibilityScope scope)
        {
            return MutateCSharp.Schemata191.ReplaceBinExprOp_3(25L, () => IsRevealedInScope(scope), () => opaqueScope.VisibleInScope(scope));
        }

        protected string sanitizedName;
        public virtual string SanitizedName => sanitizedName ??= NonglobalVariable.SanitizeName(Name);

        protected string compileName;

        public virtual string GetCompileName(DafnyOptions options)
        {
            if (compileName == null)
            {
                this.IsExtern(options, out _, out compileName);
                compileName ??= SanitizedName;
            }

            return compileName;
        }

        public Attributes Attributes;  // readonly, except during class merging in the refinement transformations and when changed by Compiler.MarkCapitalizationConflict
        Attributes IAttributeBearingDeclaration.Attributes => Attributes;

        [Pure]
        public override string ToString()
        {
            Contract.Ensures(Contract.Result<string>() != null);
            return Name;
        }

        internal FreshIdGenerator IdGenerator = new();
        public override IEnumerable<INode> Children => (MutateCSharp.Schemata191.ReplaceBinExprOp_4(31L, Attributes, null) ? new List<Node> { Attributes } : Enumerable.Empty<Node>());
        public override IEnumerable<INode> PreResolveChildren => Children;
    }
}