using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata80
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT80");
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

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public
/// <summary>
/// This class is used only inside the resolver itself. It gets hung in the AST in uncompleted name segments.
/// </summary>
class Resolver_IdentifierExpr : Expression, IHasUsages, ICloneable<Resolver_IdentifierExpr>
    {
        public readonly TopLevelDecl Decl;
        public readonly List<Type> TypeArgs;
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(Decl != null);
            Contract.Invariant(TypeArgs != null);
            Contract.Invariant(TypeArgs.Count == Decl.TypeArgs.Count);
            Contract.Invariant(Type is ResolverType_Module || Type is ResolverType_Type);
        }

        public Resolver_IdentifierExpr(Cloner cloner, Resolver_IdentifierExpr original) : base(cloner, original)
        {
            Decl = original.Decl;
            TypeArgs = original.TypeArgs;
        }

        public override IEnumerable<INode> Children => TypeArgs.SelectMany(ta => ta.Nodes);

        public abstract class ResolverType : Type
        {
            public override bool ComputeMayInvolveReferences(ISet<DatatypeDecl>/*?*/ visitedDatatypes)
            {
                return MutateCSharp.Schemata80.ReplaceBooleanConstant_0(1L, false);
            }
            public override Type Subst(IDictionary<TypeParameter, Type> subst)
            {
                throw new NotSupportedException();
                return default;
            }

            public override Type ReplaceTypeArguments(List<Type> arguments)
            {
                throw new NotSupportedException();
                return default;
            }
        }
        public class ResolverType_Module : ResolverType
        {
            [System.Diagnostics.Contracts.Pure]
            public override string TypeName(DafnyOptions options, ModuleDefinition context, bool parseAble)
            {
                Contract.Assert(parseAble == false);
                return MutateCSharp.Schemata80.ReplaceStringConstant_1(2L, "#module");
            }
            public override bool Equals(Type that, bool keepConstraints = false)
            {
                return that.NormalizeExpand(keepConstraints) is ResolverType_Module;
            }
        }
        public class ResolverType_Type : ResolverType
        {
            [System.Diagnostics.Contracts.Pure]
            public override string TypeName(DafnyOptions options, ModuleDefinition context, bool parseAble)
            {
                Contract.Assert(parseAble == false);
                return MutateCSharp.Schemata80.ReplaceStringConstant_1(3L, "#type");
            }
            public override bool Equals(Type that, bool keepConstraints = false)
            {
                return that.NormalizeExpand(keepConstraints) is ResolverType_Type;
            }
        }

        public Resolver_IdentifierExpr(IToken tok, TopLevelDecl decl, List<Type> typeArgs)
          : base(tok)
        {
            Contract.Requires(tok != null);
            Contract.Requires(decl != null);
            Contract.Requires(typeArgs != null && typeArgs.Count == decl.TypeArgs.Count);
            Decl = decl;
            TypeArgs = typeArgs;
            Type = decl is ModuleDecl ? (Type)new ResolverType_Module() : new ResolverType_Type();
            PreType = decl is ModuleDecl ? new PreTypePlaceholderModule() : new PreTypePlaceholderType();
        }
        public Resolver_IdentifierExpr(IToken tok, TypeParameter tp)
          : this(tok, tp, new List<Type>())
        {
            Contract.Requires(tok != null);
            Contract.Requires(tp != null);
        }

        public IEnumerable<IDeclarationOrUsage> GetResolvedDeclarations()
        {
            return new[] { Decl };
        }

        public IToken NameToken => tok;
        public Resolver_IdentifierExpr Clone(Cloner cloner)
        {
            return new Resolver_IdentifierExpr(cloner, this);
        }
    }
}