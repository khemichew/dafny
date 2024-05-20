using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata206
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT206");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.Type argument1, Microsoft.Dafny.Type argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBooleanConstant_4(long mutantId, bool argument1)
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

        internal static bool ReplaceBinExprOp_7(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static int ReplaceNumericConstant_6(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, Microsoft.Dafny.MapType argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

    }
}

namespace Microsoft.Dafny
{
    public class MapType : CollectionType
    {
        public bool Finite
        {
            get { return finite; }
            set { finite = value; }
        }

        private bool finite;
        public Type Range
        {
            get { return range; }
        }

        private Type range;
        public override void SetTypeArgs(Type domain, Type range)
        {
            base.SetTypeArgs(domain, range);
            Contract.Assume(this.range == null);  // Can only set once.  This is really a precondition.
            this.range = range;
        }
        public MapType(bool finite, Type domain, Type range) : base(domain, range)
        {
            Contract.Requires((domain == null && range == null) || (domain != null && range != null));
            this.finite = finite;
            this.range = range;
        }

        public MapType(Cloner cloner, MapType original) : base(cloner, original)
        {
            Finite = original.Finite;
            range = cloner.CloneType(original.Range);
            var arg = HasTypeArg() ? Arg : null;
            TypeArgs = new List<Type>() { arg, range };
        }

        public Type Domain
        {
            get { return Arg; }
        }

        public override string CollectionTypeName
        {
            get { return finite ? MutateCSharp.Schemata206.ReplaceStringConstant_0(1L, "map") : MutateCSharp.Schemata206.ReplaceStringConstant_0(2L, "imap"); }
        }

        [System.Diagnostics.Contracts.Pure]
        public override string TypeName(DafnyOptions options, ModuleDefinition context, bool parseAble)
        {
            Contract.Ensures(Contract.Result<string>() != null);
            var targs = HasTypeArg() ? this.TypeArgsToString(options, context, parseAble) : "";
            return CollectionTypeName + targs;
        }
        public override bool Equals(Type that, bool keepConstraints = false)
        {
            var t = that.NormalizeExpand(keepConstraints) as MapType;
            return MutateCSharp.Schemata206.ReplaceBinExprOp_3(22L, () => MutateCSharp.Schemata206.ReplaceBinExprOp_3(16L, () => MutateCSharp.Schemata206.ReplaceBinExprOp_3(10L, () => MutateCSharp.Schemata206.ReplaceBinExprOp_1(3L, t, null), () => MutateCSharp.Schemata206.ReplaceBinExprOp_2(4L, () => Finite, () => t.Finite)), () => Arg.Equals(t.Arg, keepConstraints)), () => Range.Equals(t.Range, keepConstraints));
        }

        public override Type Subst(IDictionary<TypeParameter, Type> subst)
        {
            var dom = Domain.Subst(subst);
            if (dom is InferredTypeProxy)
            {
                ((InferredTypeProxy)dom).KeepConstraints = MutateCSharp.Schemata206.ReplaceBooleanConstant_4(28L, true);
            }
            var ran = Range.Subst(subst);
            if (ran is InferredTypeProxy)
            {
                ((InferredTypeProxy)ran).KeepConstraints = MutateCSharp.Schemata206.ReplaceBooleanConstant_4(29L, true);
            }
            if (MutateCSharp.Schemata206.ReplaceBinExprOp_3(32L, () => MutateCSharp.Schemata206.ReplaceBinExprOp_5(30L, dom, Domain), () => MutateCSharp.Schemata206.ReplaceBinExprOp_5(31L, ran, Range)))
            {
                return this;
            }
            else
            {
                return new MapType(Finite, dom, ran);
            }

            return default;
        }

        public override Type ReplaceTypeArguments(List<Type> arguments)
        {
            return new MapType(Finite, arguments[MutateCSharp.Schemata206.ReplaceNumericConstant_6(38L, 0)], arguments[MutateCSharp.Schemata206.ReplaceNumericConstant_6(42L, 1)]);
        }

        public override bool SupportsEquality
        {
            get
            {
                // A map type supports equality if both its Keys type and Values type does.  It is checked
                // that the Keys type always supports equality, so we only need to check the Values type here.
                return range.SupportsEquality;
            }
        }

        public override bool ComputeMayInvolveReferences(ISet<DatatypeDecl> visitedDatatypes)
        {
            return MutateCSharp.Schemata206.ReplaceBinExprOp_7(46L, () => Domain.ComputeMayInvolveReferences(visitedDatatypes), () => Range.ComputeMayInvolveReferences(visitedDatatypes));
        }

        public override BinaryExpr.ResolvedOpcode ResolvedOpcodeForIn => BinaryExpr.ResolvedOpcode.InMap;
        public override CollectionBoundedPool GetBoundedPool(Expression source)
        {
            return new MapBoundedPool(source, Domain, Domain, Finite);
        }
    }
}