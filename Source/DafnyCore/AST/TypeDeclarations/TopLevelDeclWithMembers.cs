using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.Contracts;
using System.Linq;
using Microsoft.Dafny.Auditor;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
namespace MutateCSharp
{
    internal class Schemata198
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT198");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
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

        internal static bool ReplaceBinExprOp_7(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBooleanConstant_5(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() || argument2();
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.TopLevelDeclWithMembers argument1, Microsoft.Dafny.TopLevelDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_3(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public abstract class TopLevelDeclWithMembers : TopLevelDecl, IHasSymbolChildren
    {
        public readonly List<MemberDecl> Members;

        // TODO remove this and instead clone the AST after parsing.
        public ImmutableList<MemberDecl> MembersBeforeResolution;

        // The following fields keep track of parent traits
        public readonly List<MemberDecl> InheritedMembers = new();  // these are instance members declared in parent traits
        public readonly List<Type> ParentTraits;  // these are the types that are parsed after the keyword 'extends'; note, for a successfully resolved program, these are UserDefinedType's where .ResolvedClass is NonNullTypeDecl
        public readonly Dictionary<TypeParameter, Type> ParentFormalTypeParametersToActuals = new Dictionary<TypeParameter, Type>();  // maps parent traits' type parameters to actuals

        /// <summary>
        /// TraitParentHeads contains the head of each distinct trait parent. It is initialized during resolution.
        /// </summary>
        public readonly List<TraitDecl> ParentTraitHeads = new List<TraitDecl>();

        internal bool HeadDerivesFrom(TopLevelDecl b)
        {
            Contract.Requires(b != null);
            return MutateCSharp.Schemata198.ReplaceBinExprOp_1(2L, () => MutateCSharp.Schemata198.ReplaceBinExprOp_0(1L, this, b), () => this.ParentTraitHeads.Exists(tr => tr.HeadDerivesFrom(b)));
        }

        public void AddParentTypeParameterSubstitutions(Dictionary<TypeParameter, Type> typeMap)
        {
            foreach (var entry in ParentFormalTypeParametersToActuals)
            {
                var v = entry.Value.Subst(typeMap);
                typeMap.Add(entry.Key, v);
            }
        }

        [FilledInDuringResolution] public InheritanceInformationClass ParentTypeInformation;
        public class InheritanceInformationClass
        {
            private readonly Dictionary<TraitDecl, List<(Type, List<TraitDecl> /*via this parent path*/)>> info = new Dictionary<TraitDecl, List<(Type, List<TraitDecl>)>>();

            /// <summary>
            /// Returns a subset of the trait's ParentTraits, but not repeating any head type.
            /// Assumes the declaration has been successfully resolved.
            /// </summary>
            public List<Type> UniqueParentTraits()
            {
                return info.ToList().ConvertAll(entry => entry.Value[MutateCSharp.Schemata198.ReplaceNumericConstant_2(8L, 0)].Item1);
            }

            public void Record(TraitDecl traitHead, UserDefinedType parentType)
            {
                Contract.Requires(traitHead != null);
                Contract.Requires(parentType != null);
                Contract.Requires(parentType.ResolvedClass is NonNullTypeDecl nntd && nntd.ViewAsClass == traitHead);

                if (!info.TryGetValue(traitHead, out var list))
                {
                    list = new List<(Type, List<TraitDecl>)>();
                    info.Add(traitHead, list);
                }
                list.Add((parentType, new List<TraitDecl>()));
            }

            public void Extend(TraitDecl parent, InheritanceInformationClass parentInfo, Dictionary<TypeParameter, Type> typeMap)
            {
                Contract.Requires(parent != null);
                Contract.Requires(parentInfo != null);
                Contract.Requires(typeMap != null);

                foreach (var entry in parentInfo.info)
                {
                    var traitHead = entry.Key;
                    if (!info.TryGetValue(traitHead, out var list))
                    {
                        list = new List<(Type, List<TraitDecl>)>();
                        info.Add(traitHead, list);
                    }
                    foreach (var pair in entry.Value)
                    {
                        var ty = pair.Item1.Subst(typeMap);
                        // prepend the path with "parent"
                        var parentPath = new List<TraitDecl>() { parent };
                        parentPath.AddRange(pair.Item2);
                        list.Add((ty, parentPath));
                    }
                }
            }

            public IEnumerable<List<(Type, List<TraitDecl>)>> GetTypeInstantiationGroups()
            {
                foreach (var pair in info.Values)
                {
                    yield return pair;
                }

                yield break;
            }
        }

        protected TopLevelDeclWithMembers(RangeToken rangeToken, Name name, ModuleDefinition module,
          List<TypeParameter> typeArgs, List<MemberDecl> members, Attributes attributes,
          bool isRefining, List<Type>/*?*/ traits = null)
          : base(rangeToken, name, module, typeArgs, attributes, isRefining)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            Contract.Requires(cce.NonNullElements(typeArgs));
            Contract.Requires(cce.NonNullElements(members));
            Members = members;
            ParentTraits = traits ?? new List<Type>();
            SetMembersBeforeResolution();
        }

        public void SetMembersBeforeResolution()
        {
            MembersBeforeResolution = Members.ToImmutableList();
        }

        public List<Type> RawTraitsWithArgument(List<Type> typeArgs)
        {
            Contract.Requires(typeArgs != null);
            Contract.Requires(typeArgs.Count == TypeArgs.Count);
            // Instantiate with the actual type arguments
            var subst = TypeParameter.SubstitutionMap(TypeArgs, typeArgs);
            return ParentTraits.ConvertAll(traitType =>
            {
                var ty = (UserDefinedType)traitType.Subst(subst);
                return (Type)UserDefinedType.CreateNullableTypeIfReferenceType(ty);
            });
        }

        public override List<Type> ParentTypes(List<Type> typeArgs)
        {
            return RawTraitsWithArgument(typeArgs);
        }

        public static List<UserDefinedType> CommonTraits(TopLevelDeclWithMembers a, TopLevelDeclWithMembers b)
        {
            Contract.Requires(a != null);
            Contract.Requires(b != null);
            var aa = a.TraitAncestors();
            var bb = b.TraitAncestors();
            aa.IntersectWith(bb);
            var types = new List<UserDefinedType>();
            foreach (var t in aa)
            {
                var typeArgs = t.TypeArgs.ConvertAll(tp => a.ParentFormalTypeParametersToActuals[tp]);
                var u = new UserDefinedType(t.Tok, t.Name + MutateCSharp.Schemata198.ReplaceStringConstant_3(12L, "?"), t, typeArgs);
                types.Add(u);
            }
            return types;
        }

        public override IEnumerable<INode> Children => ParentTraits.Concat<Node>(Members);

        public override IEnumerable<INode> PreResolveChildren => ParentTraits.Concat<Node>(MembersBeforeResolution);

        /// <summary>
        /// Returns the set of transitive parent traits (not including "this" itself).
        /// This method assumes the .ParentTraits fields have been checked for various cycle restrictions.
        /// </summary>
        public ISet<TraitDecl> TraitAncestors()
        {
            var s = new HashSet<TraitDecl>();
            AddTraitAncestors(s);
            return s;
        }
        /// <summary>
        /// Adds to "s" the transitive parent traits (not including "this" itself).
        /// This method assumes the .ParentTraits fields have been checked for various cycle restrictions.
        /// </summary>
        private void AddTraitAncestors(ISet<TraitDecl> s)
        {
            Contract.Requires(s != null);
            foreach (var parent in ParentTraits)
            {
                var udt = (UserDefinedType)parent;  // in a successfully resolved program, we expect all .ParentTraits to be a UserDefinedType
                TraitDecl tr;
                if (udt.ResolvedClass is NonNullTypeDecl nntd)
                {
                    tr = (TraitDecl)nntd.Class;
                }
                else
                {
                    tr = (TraitDecl)udt.ResolvedClass;
                }
                s.Add(tr);
                tr.AddTraitAncestors(s);
            }
        }

        // True if non-static members can access the underlying object "this"
        // False if all members are implicitly static (e.g. in a default class declaration)
        public abstract bool AcceptThis { get; }

        public override bool IsEssentiallyEmpty()
        {
            if (MutateCSharp.Schemata198.ReplaceBinExprOp_1(31L, () => MutateCSharp.Schemata198.ReplaceBinExprOp_4(17L, Members.Count, MutateCSharp.Schemata198.ReplaceNumericConstant_2(13L, 0)), () => MutateCSharp.Schemata198.ReplaceBinExprOp_4(26L, ParentTraits.Count, MutateCSharp.Schemata198.ReplaceNumericConstant_2(22L, 0))))
            {
                return MutateCSharp.Schemata198.ReplaceBooleanConstant_5(37L, false);
            }
            return base.IsEssentiallyEmpty();
        }

        public override IEnumerable<Assumption> Assumptions(Declaration decl)
        {
            return Members.SelectMany(m => m.Assumptions(this));
        }

        public void RegisterMembers(ModuleResolver resolver, Dictionary<string, MemberDecl> members)
        {
            Contract.Requires(this != null);
            Contract.Requires(members != null);

            foreach (MemberDecl m in Members)
            {
                if (!members.ContainsKey(m.Name))
                {
                    members.Add(m.Name, m);
                    if (m is Constructor)
                    {
                        Contract.Assert(this is ClassLikeDecl); // the parser ensures this condition
                        if (this is TraitDecl)
                        {
                            resolver.reporter.Error(MessageSource.Resolver, m.tok, MutateCSharp.Schemata198.ReplaceStringConstant_3(38L, "a trait is not allowed to declare a constructor"));
                        }
                        else
                        {
                            ((ClassDecl)this).HasConstructor = MutateCSharp.Schemata198.ReplaceBooleanConstant_5(39L, true);
                        }
                    }
                    else if (MutateCSharp.Schemata198.ReplaceBinExprOp_1(40L, () => m is ExtremePredicate, () => m is ExtremeLemma))
                    {
                        var extraName = m.NameNode.Append(MutateCSharp.Schemata198.ReplaceStringConstant_3(46L, "#"));
                        MemberDecl extraMember;
                        var cloner = new Cloner();
                        var formals = new List<Formal>();
                        Type typeOfK;
                        if (MutateCSharp.Schemata198.ReplaceBinExprOp_1(59L, () => (MutateCSharp.Schemata198.ReplaceBinExprOp_6(47L, () => m is ExtremePredicate, () => ((ExtremePredicate)m).KNat)), () => (MutateCSharp.Schemata198.ReplaceBinExprOp_6(53L, () => m is ExtremeLemma, () => ((ExtremeLemma)m).KNat))))
                        {
                            typeOfK = new UserDefinedType(m.tok, MutateCSharp.Schemata198.ReplaceStringConstant_3(65L, "nat"), (List<Type>)null);
                        }
                        else
                        {
                            typeOfK = new BigOrdinalType();
                        }

                        var k = new ImplicitFormal(m.tok, MutateCSharp.Schemata198.ReplaceStringConstant_3(66L, "_k"), typeOfK, MutateCSharp.Schemata198.ReplaceBooleanConstant_5(67L, true), MutateCSharp.Schemata198.ReplaceBooleanConstant_5(68L, false));
                        resolver.reporter.Info(MessageSource.Resolver, m.tok, string.Format(MutateCSharp.Schemata198.ReplaceStringConstant_3(69L, "_k: {0}"), k.Type));
                        formals.Add(k);
                        if (m is ExtremePredicate extremePredicate)
                        {
                            formals.AddRange(extremePredicate.Ins.ConvertAll(f => cloner.CloneFormal(f, MutateCSharp.Schemata198.ReplaceBooleanConstant_5(70L, false))));

                            List<TypeParameter> tyvars = extremePredicate.TypeArgs.ConvertAll(cloner.CloneTypeParam);

                            // create prefix predicate
                            extremePredicate.PrefixPredicate = new PrefixPredicate(extremePredicate.RangeToken, extraName, extremePredicate.HasStaticKeyword,
                              tyvars, k, formals,
                              extremePredicate.Req.ConvertAll(cloner.CloneAttributedExpr),
                              cloner.CloneSpecFrameExpr(extremePredicate.Reads),
                              extremePredicate.Ens.ConvertAll(cloner.CloneAttributedExpr),
                              new Specification<Expression>(new List<Expression>() { new IdentifierExpr(extremePredicate.tok, k.Name) }, null),
                              cloner.CloneExpr(extremePredicate.Body),
                              SystemModuleManager.AxiomAttribute(),
                              extremePredicate);
                            extraMember = extremePredicate.PrefixPredicate;
                        }
                        else
                        {
                            var extremeLemma = (ExtremeLemma)m;
                            // _k has already been added to 'formals', so append the original formals
                            formals.AddRange(extremeLemma.Ins.ConvertAll(f => cloner.CloneFormal(f, MutateCSharp.Schemata198.ReplaceBooleanConstant_5(71L, false))));
                            // prepend _k to the given decreases clause
                            var decr = new List<Expression>();
                            decr.Add(new IdentifierExpr(extremeLemma.tok, k.Name));
                            decr.AddRange(extremeLemma.Decreases.Expressions.ConvertAll(cloner.CloneExpr));
                            // Create prefix lemma.  Note that the body is not cloned, but simply shared.
                            // For a greatest lemma, the postconditions are filled in after the greatest lemma's postconditions have been resolved.
                            // For a least lemma, the preconditions are filled in after the least lemma's preconditions have been resolved.
                            var req = extremeLemma is GreatestLemma
                              ? extremeLemma.Req.ConvertAll(cloner.CloneAttributedExpr)
                              : new List<AttributedExpression>();
                            var ens = extremeLemma is GreatestLemma
                              ? new List<AttributedExpression>()
                              : extremeLemma.Ens.ConvertAll(cloner.CloneAttributedExpr);
                            extremeLemma.PrefixLemma = new PrefixLemma(extremeLemma.RangeToken, extraName, extremeLemma.HasStaticKeyword,
                              extremeLemma.TypeArgs.ConvertAll(cloner.CloneTypeParam), k, formals, extremeLemma.Outs.ConvertAll(f => cloner.CloneFormal(f, MutateCSharp.Schemata198.ReplaceBooleanConstant_5(72L, false))),
                              req, cloner.CloneSpecFrameExpr(extremeLemma.Reads),
                              cloner.CloneSpecFrameExpr(extremeLemma.Mod), ens,
                              new Specification<Expression>(decr, null),
                              null, // Note, the body for the prefix method will be created once the call graph has been computed and the SCC for the greatest lemma is known
                              SystemModuleManager.AxiomAttribute(cloner.CloneAttributes(extremeLemma.Attributes)), extremeLemma);
                            extraMember = extremeLemma.PrefixLemma;
                        }

                        extraMember.InheritVisibility(m, MutateCSharp.Schemata198.ReplaceBooleanConstant_5(73L, false));
                        members.Add(extraName.Value, extraMember);
                    }
                    else if (m is Function f && MutateCSharp.Schemata198.ReplaceBinExprOp_7(74L, f.ByMethodBody, null))
                    {
                        resolver.RegisterByMethod(f, this);
                    }
                }
                else if (MutateCSharp.Schemata198.ReplaceBinExprOp_6(75L, () => m is Constructor, () => !((Constructor)m).HasName))
                {
                    resolver.reporter.Error(MessageSource.Resolver, m, MutateCSharp.Schemata198.ReplaceStringConstant_3(81L, "More than one anonymous constructor"));
                }
                else
                {
                    resolver.reporter.Error(MessageSource.Resolver, m, MutateCSharp.Schemata198.ReplaceStringConstant_3(82L, "Duplicate member name: {0}"), m.Name);
                }
            }
        }
        public virtual IEnumerable<ISymbol> ChildSymbols => Members.OfType<ISymbol>();
        public virtual SymbolKind Kind => SymbolKind.Class;
        public virtual string GetDescription(DafnyOptions options)
        {
            return $"{WhatKind} {Name}";
        }
    }

    public static class RevealableTypeDeclHelper
    {
        public static InternalTypeSynonymDecl SelfSynonymDecl(this RevealableTypeDecl rtd) =>
          rtd.SynonymInfo.SelfSynonymDecl;

        public static UserDefinedType SelfSynonym(this RevealableTypeDecl rtd, List<Type> args, Expression /*?*/ namePath = null) =>
          rtd.SynonymInfo.SelfSynonym(args, namePath);

        //Internal implementations are called before extensions, so this is safe
        public static bool IsRevealedInScope(this RevealableTypeDecl rtd, VisibilityScope scope) =>
          rtd.AsTopLevelDecl.IsRevealedInScope(scope);

        public static void NewSelfSynonym(this RevealableTypeDecl rtd)
        {
            rtd.SynonymInfo = new TypeDeclSynonymInfo(rtd.AsTopLevelDecl);
        }
    }
}