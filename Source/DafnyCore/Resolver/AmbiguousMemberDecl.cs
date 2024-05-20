using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata364
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT364");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Microsoft.Dafny.MemberDecl argument1, Microsoft.Dafny.MemberDecl argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public
class AmbiguousMemberDecl : MemberDecl, IAmbiguousThing<MemberDecl> // only used with "classes"
    {
        public static MemberDecl Create(ModuleDefinition m, MemberDecl a, MemberDecl b)
        {
            ISet<MemberDecl> s;
            var t = AmbiguousThingHelper<MemberDecl>.Create(m, a, b, new Eq(), out s);
            return t ?? new AmbiguousMemberDecl(m, AmbiguousThingHelper<MemberDecl>.Name(s, member => member.Name), s);
        }

        public
          class Eq : IEqualityComparer<MemberDecl>
        {
            public bool Equals(MemberDecl d0, MemberDecl d1)
            {
                return MutateCSharp.Schemata364.ReplaceBinExprOp_0(1L, d0, d1);
            }

            public int GetHashCode(MemberDecl d)
            {
                return d.GetHashCode();
            }
        }

        public override string WhatKind
        {
            get { return Pool.First().WhatKind; }
        }

        readonly ISet<MemberDecl> Pool = new HashSet<MemberDecl>();

        ISet<MemberDecl> IAmbiguousThing<MemberDecl>.Pool
        {
            get { return Pool; }
        }

        private AmbiguousMemberDecl(ModuleDefinition m, string name, ISet<MemberDecl> pool)
          : base(pool.First().RangeToken, new Name(pool.First().RangeToken, name), MutateCSharp.Schemata364.ReplaceBooleanConstant_1(2L, true), pool.First().IsGhost, null, MutateCSharp.Schemata364.ReplaceBooleanConstant_1(3L, false))
        {
            Contract.Requires(name != null);
            Contract.Requires(pool != null && 2 <= pool.Count);
            Pool = pool;
        }

        public string ModuleNames()
        {
            return AmbiguousThingHelper<MemberDecl>.ModuleNames(this, d => d.EnclosingClass.EnclosingModuleDefinition.Name);
        }
    }
}