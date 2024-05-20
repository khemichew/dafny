using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata197
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT197");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
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

        internal static bool ReplaceBinExprOp_8(long mutantId, Microsoft.Dafny.Attributes argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static bool ReplaceBinExprOp_9(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_1(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_7(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, Microsoft.Dafny.ModuleDefinition argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, System.Collections.Generic.List<Microsoft.Dafny.Expression> argument1, object argument2)
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
    public abstract class TopLevelDecl : Declaration, TypeParameter.ParentType
    {
        public abstract string WhatKind { get; }

        public string WhatKindAndName => $"{WhatKind} '{Name}'";
        public ModuleDefinition EnclosingModuleDefinition;
        public readonly List<TypeParameter> TypeArgs;
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(cce.NonNullElements(TypeArgs));
        }

        protected TopLevelDecl(Cloner cloner, TopLevelDecl original, ModuleDefinition parent) : base(cloner, original)
        {
            TypeArgs = original.TypeArgs.ConvertAll(cloner.CloneTypeParam);
            EnclosingModuleDefinition = parent;
        }

        protected TopLevelDecl(RangeToken rangeToken, Name name, ModuleDefinition enclosingModule, List<TypeParameter> typeArgs, Attributes attributes, bool isRefining)
          : base(rangeToken, name, attributes, isRefining)
        {
            Contract.Requires(rangeToken != null);
            Contract.Requires(name != null);
            Contract.Requires(cce.NonNullElements(typeArgs));
            EnclosingModuleDefinition = enclosingModule;
            TypeArgs = typeArgs;
        }

        public string FullDafnyName
        {
            get
            {
                if (MutateCSharp.Schemata197.ReplaceBinExprOp_1(2L, Name, MutateCSharp.Schemata197.ReplaceStringConstant_0(1L, "_module")))
                {
                    return "";
                }

                if (MutateCSharp.Schemata197.ReplaceBinExprOp_1(4L, Name, MutateCSharp.Schemata197.ReplaceStringConstant_0(3L, "_default")))
                {
                    return EnclosingModuleDefinition.FullDafnyName;
                }

                string n = EnclosingModuleDefinition.FullDafnyName;
                return (MutateCSharp.Schemata197.ReplaceBinExprOp_3(9L, n.Length, MutateCSharp.Schemata197.ReplaceNumericConstant_2(5L, 0)) ? n : (n + MutateCSharp.Schemata197.ReplaceStringConstant_0(14L, "."))) + Name;
            }
        }

        public virtual string FullName
        {
            get
            {
                if (EnclosingModuleDefinition is null)
                {
                    return Name;
                }
                return EnclosingModuleDefinition.FullName + MutateCSharp.Schemata197.ReplaceStringConstant_0(15L, ".") + Name;
            }
        }

        public string FullSanitizedName
        {
            get
            {
                if (EnclosingModuleDefinition is null)
                {
                    return SanitizedName;
                }
                return EnclosingModuleDefinition.SanitizedName + MutateCSharp.Schemata197.ReplaceStringConstant_0(16L, ".") + SanitizedName;
            }
        }

        public string FullNameInContext(ModuleDefinition context)
        {
            if (MutateCSharp.Schemata197.ReplaceBinExprOp_4(17L, EnclosingModuleDefinition, context))
            {
                return Name;
            }
            else
            {
                return EnclosingModuleDefinition.Name + MutateCSharp.Schemata197.ReplaceStringConstant_0(18L, ".") + Name;
            }

            return default;
        }

        public string GetFullCompileName(DafnyOptions options)
        {
            var externArgs = Attributes.FindExpressions(this.Attributes, MutateCSharp.Schemata197.ReplaceStringConstant_0(19L, "extern"));
            if (MutateCSharp.Schemata197.ReplaceBinExprOp_6(21L, () => !options.DisallowExterns, () => MutateCSharp.Schemata197.ReplaceBinExprOp_5(20L, externArgs, null)))
            {
                if (MutateCSharp.Schemata197.ReplaceBinExprOp_6(50L, () => MutateCSharp.Schemata197.ReplaceBinExprOp_6(40L, () => MutateCSharp.Schemata197.ReplaceBinExprOp_3(31L, externArgs.Count, MutateCSharp.Schemata197.ReplaceNumericConstant_2(27L, 2)), () => externArgs[MutateCSharp.Schemata197.ReplaceNumericConstant_2(36L, 0)] is StringLiteralExpr), () => externArgs[MutateCSharp.Schemata197.ReplaceNumericConstant_2(46L, 1)] is StringLiteralExpr))
                {
                    return externArgs[MutateCSharp.Schemata197.ReplaceNumericConstant_2(56L, 0)].AsStringLiteral() + MutateCSharp.Schemata197.ReplaceStringConstant_0(60L, ".") + externArgs[MutateCSharp.Schemata197.ReplaceNumericConstant_2(61L, 1)].AsStringLiteral();
                }
            }

            return options.Backend.GetCompileName(EnclosingModuleDefinition.TryToAvoidName,
              EnclosingModuleDefinition.GetCompileName(options), GetCompileName(options));
        }

        public TopLevelDecl ViewAsClass
        {
            get
            {
                if (this is NonNullTypeDecl)
                {
                    return ((NonNullTypeDecl)this).Class;
                }
                else
                {
                    return this;
                }

                return default;
            }
        }

        /// <summary>
        /// Return the list of parent types of "this", where the type parameters
        /// of "this" have been instantiated by "typeArgs". For example, for a subset
        /// type, the return value is the RHS type, appropriately instantiated. As
        /// two other examples, given
        ///     class C<X> extends J<X, int>
        /// C.ParentTypes(real) = J<real, int>    // non-null types C and J
        /// C?.ParentTypes(real) = J?<real, int>  // possibly-null type C? and J?
        /// </summary>
        public virtual List<Type> ParentTypes(List<Type> typeArgs)
        {
            Contract.Requires(typeArgs != null);
            Contract.Requires(this.TypeArgs.Count == typeArgs.Count);
            return new List<Type>();
        }

        public bool AllowsAllocation => MutateCSharp.Schemata197.ReplaceBooleanConstant_7(65L, true);
        public override IEnumerable<INode> Children => Enumerable.Empty<Node>();

        /// <summary>
        /// A top-level declaration is considered "essentially empty" if there is no way it could generate any resolution error
        /// other than introducing a duplicate name.
        /// </summary>
        public virtual bool IsEssentiallyEmpty()
        {
            return MutateCSharp.Schemata197.ReplaceBinExprOp_10(76L, () => MutateCSharp.Schemata197.ReplaceBinExprOp_8(66L, Attributes, null), () => MutateCSharp.Schemata197.ReplaceBinExprOp_9(71L, TypeArgs.Count, MutateCSharp.Schemata197.ReplaceNumericConstant_2(67L, 0)));
        }
    }
}