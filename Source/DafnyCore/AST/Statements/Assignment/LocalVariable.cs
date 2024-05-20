using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
namespace MutateCSharp
{
    internal class Schemata142
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT142");
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

        internal static bool ReplaceBinExprOp_2(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public class LocalVariable : RangeNode, IVariable, IAttributeBearingDeclaration
    {
        readonly string name;
        public string DafnyName => Name;
        public Attributes Attributes;
        Attributes IAttributeBearingDeclaration.Attributes => Attributes;
        public bool IsGhost;
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(name != null);
            Contract.Invariant(OptionalType != null);
        }

        public override IToken Tok => RangeToken.StartToken;

        public LocalVariable(Cloner cloner, LocalVariable original)
          : base(cloner, original)
        {
            name = original.Name;
            OptionalType = cloner.CloneType(original.OptionalType);
            IsTypeExplicit = original.IsTypeExplicit;
            IsGhost = original.IsGhost;

            if (cloner.CloneResolvedFields)
            {
                type = original.type;
            }
        }

        public LocalVariable(RangeToken rangeToken, string name, Type type, bool isGhost)
          : base(rangeToken)
        {
            Contract.Requires(name != null);
            Contract.Requires(type != null);  // can be a proxy, though

            this.name = name;
            this.OptionalType = type;
            if (type is InferredTypeProxy)
            {
                ((InferredTypeProxy)type).KeepConstraints = MutateCSharp.Schemata142.ReplaceBooleanConstant_0(1L, true);
            }
            this.IsGhost = isGhost;
        }

        public string Name
        {
            get
            {
                Contract.Ensures(Contract.Result<string>() != null);
                return name;
            }
        }

        public static bool HasWildcardName(IVariable v)
        {
            Contract.Requires(v != null);
            return v.Name.StartsWith(MutateCSharp.Schemata142.ReplaceStringConstant_1(2L, "_v"));
        }
        public static string DisplayNameHelper(IVariable v)
        {
            Contract.Requires(v != null);
            return HasWildcardName(v) ? $"_ /* {v.Name} */" : v.Name;
        }
        public string DisplayName
        {
            get { return DisplayNameHelper(this); }
        }

        private string uniqueName;
        public string UniqueName => uniqueName;
        public bool HasBeenAssignedUniqueName => uniqueName != null;
        public string AssignUniqueName(FreshIdGenerator generator)
        {
            return uniqueName ??= generator.FreshId(Name + MutateCSharp.Schemata142.ReplaceStringConstant_1(3L, "#"));
        }

        private string sanitizedNameShadowable;

        public string SanitizedNameShadowable =>
          sanitizedNameShadowable ??= NonglobalVariable.SanitizeName(Name);

        private string sanitizedName;

        public string SanitizedName =>
          sanitizedName ??= $"_{IVariable.CompileNameIdGenerator.FreshNumericId()}_{SanitizedNameShadowable}";

        string compileName;
        public string CompileName =>
          compileName ??= SanitizedName;

        public readonly Type OptionalType;  // this is the type mentioned in the declaration, if any
        Type IVariable.OptionalType
        {
            get { return this.OptionalType; }
        }

        [FilledInDuringResolution]
        internal Type type;  // this is the declared or inferred type of the variable; it is non-null after resolution (even if resolution fails)
        public Type Type
        {
            get
            {
                Contract.Ensures(Contract.Result<Type>() != null);

                Contract.Assume(type != null);  /* we assume object has been resolved */
                return type.Normalize();
            }
        }

        /// <summary>
        /// For a description of the difference between .Type and .UnnormalizedType, see Expression.UnnormalizedType.
        /// </summary>
        public Type UnnormalizedType
        {
            get
            {
                Contract.Ensures(Contract.Result<Type>() != null);

                Contract.Assume(type != null);  /* we assume object has been resolved */
                return type;
            }
        }

        public PreType PreType { get; set; }

        public bool IsMutable
        {
            get
            {
                return MutateCSharp.Schemata142.ReplaceBooleanConstant_0(4L, true);
            }
        }

        bool IVariable.IsGhost
        {
            get
            {
                return this.IsGhost;
            }
        }

        /// <summary>
        /// This method retrospectively makes the LocalVariable a ghost.  It is to be used only during resolution.
        /// </summary>
        public void MakeGhost()
        {
            this.IsGhost = MutateCSharp.Schemata142.ReplaceBooleanConstant_0(5L, true);
        }

        public IToken NameToken => RangeToken.StartToken;
        public bool IsTypeExplicit = MutateCSharp.Schemata142.ReplaceBooleanConstant_0(6L, false);
        public override IEnumerable<INode> Children =>
          (MutateCSharp.Schemata142.ReplaceBinExprOp_2(7L, Attributes, null) ? new List<Node> { Attributes } : Enumerable.Empty<Node>()).Concat(
            IsTypeExplicit ? new List<Node>() { type } : Enumerable.Empty<Node>());

        public override IEnumerable<INode> PreResolveChildren =>
          (MutateCSharp.Schemata142.ReplaceBinExprOp_2(8L, Attributes, null) ? new List<Node> { Attributes } : Enumerable.Empty<Node>()).Concat(
            IsTypeExplicit ? new List<Node>() { OptionalType ?? type } : Enumerable.Empty<Node>());

        public SymbolKind Kind => SymbolKind.Variable;
        public string GetDescription(DafnyOptions options)
        {
            return this.AsText();
        }
    }
}