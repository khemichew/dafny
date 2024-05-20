using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using Microsoft.Dafny.Auditor;
namespace MutateCSharp
{
    internal class Schemata107
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT107");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceNumericConstant_6(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_8(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.MemberDecl argument1, Microsoft.Dafny.MemberDecl argument2)
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

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public abstract class MemberDecl : Declaration
    {
        public abstract string WhatKind { get; }

        public string WhatKindAndName => $"{WhatKind} '{Name}'";
        public virtual string WhatKindMentionGhost => (IsGhost ? MutateCSharp.Schemata107.ReplaceStringConstant_0(1L, "ghost ") : "") + WhatKind;
        protected bool hasStaticKeyword;
        public bool HasStaticKeyword => hasStaticKeyword;
        public virtual bool IsStatic
        {
            get
            {
                return MutateCSharp.Schemata107.ReplaceBinExprOp_1(2L, () => HasStaticKeyword, () => EnclosingClass is DefaultClassDecl);
            }
        }

        public virtual bool IsOpaque => MutateCSharp.Schemata107.ReplaceBooleanConstant_2(8L, false);

        protected bool isGhost;
        public bool IsGhost
        {
            get { return isGhost; }
        }

        public string ModifiersAsString()
        {
            string result = "";
            if (IsGhost)
            {
                result += MutateCSharp.Schemata107.ReplaceStringConstant_0(9L, "ghost ");
            }
            if (IsStatic)
            {
                result += MutateCSharp.Schemata107.ReplaceStringConstant_0(10L, "static ");
            }
            if (IsOpaque)
            {
                result += MutateCSharp.Schemata107.ReplaceStringConstant_0(11L, "opaque ");
            }
            return result;
        }

        /// <summary>
        /// The term "instance independent" can be confusing. It means that the constant does not get its value in
        /// a constructor. (But the RHS of the const's declaration may mention "this".)
        /// </summary>
        public bool IsInstanceIndependentConstant => this is ConstantField cf && MutateCSharp.Schemata107.ReplaceBinExprOp_3(12L, cf.Rhs, null);

        public TopLevelDecl EnclosingClass;  // filled in during resolution
        [FilledInDuringResolution] public MemberDecl RefinementBase;  // filled in during the pre-resolution refinement transformation; null if the member is new here
        [FilledInDuringResolution] public MemberDecl OverriddenMember;  // non-null if the member overrides a member in a parent trait
        public virtual bool IsOverrideThatAddsBody => MutateCSharp.Schemata107.ReplaceBinExprOp_4(13L, OverriddenMember, null);

        /// <summary>
        /// Returns "true" if "this" is a (possibly transitive) override of "possiblyOverriddenMember".
        /// </summary>
        public bool Overrides(MemberDecl possiblyOverriddenMember)
        {
            Contract.Requires(possiblyOverriddenMember != null);
            for (var th = this; MutateCSharp.Schemata107.ReplaceBinExprOp_4(14L, th, null); th = th.OverriddenMember)
            {
                if (MutateCSharp.Schemata107.ReplaceBinExprOp_5(15L, th, possiblyOverriddenMember))
                {
                    return MutateCSharp.Schemata107.ReplaceBooleanConstant_2(16L, true);
                }
            }
            return MutateCSharp.Schemata107.ReplaceBooleanConstant_2(17L, false);
        }

        protected MemberDecl(Cloner cloner, MemberDecl original) : base(cloner, original)
        {
            this.hasStaticKeyword = original.hasStaticKeyword;
            this.EnclosingClass = original.EnclosingClass;
            this.isGhost = original.isGhost;
        }

        protected MemberDecl(RangeToken rangeToken, Name name, bool hasStaticKeyword, bool isGhost, Attributes attributes, bool isRefining)
          : base(rangeToken, name, attributes, isRefining)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            this.hasStaticKeyword = hasStaticKeyword;
            this.isGhost = isGhost;
        }
        /// <summary>
        /// Returns className+"."+memberName.  Available only after resolution.
        /// </summary>
        public virtual string FullDafnyName
        {
            get
            {
                Contract.Requires(EnclosingClass != null);
                Contract.Ensures(Contract.Result<string>() != null);
                string n = EnclosingClass.FullDafnyName;
                return (MutateCSharp.Schemata107.ReplaceBinExprOp_7(22L, n.Length, MutateCSharp.Schemata107.ReplaceNumericConstant_6(18L, 0)) ? n : (n + MutateCSharp.Schemata107.ReplaceStringConstant_0(27L, "."))) + Name;
            }
        }

        public virtual string FullName
        {
            get
            {
                Contract.Requires(EnclosingClass != null);
                Contract.Ensures(Contract.Result<string>() != null);

                return EnclosingClass.FullName + MutateCSharp.Schemata107.ReplaceStringConstant_0(28L, ".") + Name;
            }
        }

        public override string SanitizedName =>
          (MutateCSharp.Schemata107.ReplaceBinExprOp_8(29L, Name, EnclosingClass.Name) ? MutateCSharp.Schemata107.ReplaceStringConstant_0(30L, "_") : "") + base.SanitizedName;

        public override string GetCompileName(DafnyOptions options) => (MutateCSharp.Schemata107.ReplaceBinExprOp_8(31L, Name, EnclosingClass.Name) ? MutateCSharp.Schemata107.ReplaceStringConstant_0(32L, "_") : "") + base.GetCompileName(options);

        public virtual string FullSanitizedName
        {
            get
            {
                Contract.Requires(EnclosingClass != null);
                Contract.Ensures(Contract.Result<string>() != null);

                if (MutateCSharp.Schemata107.ReplaceBinExprOp_8(34L, Name, MutateCSharp.Schemata107.ReplaceStringConstant_0(33L, "requires")))
                {
                    return BoogieGenerator.Requires(((ArrowTypeDecl)EnclosingClass).Arity);
                }
                else if (MutateCSharp.Schemata107.ReplaceBinExprOp_8(36L, Name, MutateCSharp.Schemata107.ReplaceStringConstant_0(35L, "reads")))
                {
                    return BoogieGenerator.Reads(((ArrowTypeDecl)EnclosingClass).Arity);
                }
                else
                {
                    return EnclosingClass.FullSanitizedName + MutateCSharp.Schemata107.ReplaceStringConstant_0(37L, ".") + SanitizedName;
                }

                return default;
            }
        }

        public virtual IEnumerable<Expression> SubExpressions => Enumerable.Empty<Expression>();

        public override IEnumerable<Assumption> Assumptions(Declaration decl)
        {
            foreach (var a in base.Assumptions(this))
            {
                yield return a;
            }
            if (this.HasUserAttribute(MutateCSharp.Schemata107.ReplaceStringConstant_0(38L, "only"), out _))
            {
                yield return new Assumption(decl, tok, AssumptionDescription.MemberOnly);
            }

            yield break;
        }

        public void RecursiveCallParameters(IToken tok, List<TypeParameter> typeParams, List<Formal> ins,
          Expression receiverSubst, Dictionary<IVariable, Expression> substMap,
          out Expression receiver, out List<Expression> arguments)
        {
            Contract.Requires(tok != null);
            Contract.Requires(this != null);
            Contract.Requires(EnclosingClass is TopLevelDeclWithMembers);
            Contract.Requires(typeParams != null);
            Contract.Requires(ins != null);
            // receiverSubst is allowed to be null
            Contract.Requires(substMap != null);
            Contract.Ensures(Contract.ValueAtReturn(out receiver) != null);
            Contract.Ensures(Contract.ValueAtReturn(out arguments) != null);

            if (IsStatic)
            {
                receiver = new StaticReceiverExpr(tok, (TopLevelDeclWithMembers)EnclosingClass, MutateCSharp.Schemata107.ReplaceBooleanConstant_2(39L, true)); // this also resolves it
            }
            else if (MutateCSharp.Schemata107.ReplaceBinExprOp_3(40L, receiverSubst, null))
            {
                receiver = receiverSubst;
            }
            else
            {
                receiver = new ImplicitThisExpr(tok);
                receiver.Type = ModuleResolver.GetReceiverType(tok, this);  // resolve here
            }

            arguments = new List<Expression>();
            foreach (var inFormal in ins)
            {
                Expression inE;
                if (substMap.TryGetValue(inFormal, out inE))
                {
                    arguments.Add(inE);
                }
                else
                {
                    var ie = new IdentifierExpr(inFormal.tok, inFormal.Name);
                    ie.Var = inFormal;  // resolve here
                    ie.Type = inFormal.Type;  // resolve here
                    arguments.Add(ie);
                }
            }
        }
    }
}