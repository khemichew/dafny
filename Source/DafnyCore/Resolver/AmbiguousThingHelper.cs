using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata365
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT365");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
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
interface IAmbiguousThing<Thing>
    {
        /// <summary>
        /// Returns a plural number of non-null Thing's
        /// </summary>
        ISet<Thing> Pool { get; }
    }

    public
    class AmbiguousThingHelper<Thing> where Thing : class
    {
        public static Thing Create(ModuleDefinition m, Thing a, Thing b, IEqualityComparer<Thing> eq, out ISet<Thing> s)
        {
            Contract.Requires(a != null);
            Contract.Requires(b != null);
            Contract.Requires(eq != null);
            Contract.Ensures(Contract.Result<Thing>() != null ||
                             Contract.ValueAtReturn(out s) != null || 2 <= Contract.ValueAtReturn(out s).Count);
            s = null;
            if (eq.Equals(a, b))
            {
                return a;
            }

            ISet<Thing> sa = a is IAmbiguousThing<Thing> ? ((IAmbiguousThing<Thing>)a).Pool : new HashSet<Thing>()
    {
      a
    };
            ISet<Thing> sb = b is IAmbiguousThing<Thing> ? ((IAmbiguousThing<Thing>)b).Pool : new HashSet<Thing>()
    {
      b
    };
            var union = new HashSet<Thing>(sa.Union(sb, eq));
            if (MutateCSharp.Schemata365.ReplaceBinExprOp_0(1L, sa.Count, union.Count))
            {
                // sb is a subset of sa
                return a;
            }
            else if (MutateCSharp.Schemata365.ReplaceBinExprOp_0(6L, sb.Count, union.Count))
            {
                // sa is a subset of sb
                return b;
            }
            else
            {
                s = union;
                Contract.Assert(2 <= s.Count);
                return null;
            }

            return default;
        }

        public static string Name(ISet<Thing> s, Func<Thing, string> name)
        {
            Contract.Requires(s != null);
            Contract.Requires(s.Count != 0);
            string nm = null;
            foreach (var thing in s)
            {
                string n = name(thing);
                if (nm == null)
                {
                    nm = n;
                }
                else
                {
                    nm += MutateCSharp.Schemata365.ReplaceStringConstant_1(11L, "/") + n;
                }
            }

            return nm;
        }

        public static string ModuleNames(IAmbiguousThing<Thing> amb, Func<Thing, string> moduleName)
        {
            Contract.Requires(amb != null);
            Contract.Ensures(Contract.Result<string>() != null);
            string nm = null;
            foreach (var d in amb.Pool)
            {
                if (nm == null)
                {
                    nm = moduleName(d);
                }
                else
                {
                    nm += MutateCSharp.Schemata365.ReplaceStringConstant_1(12L, ", ") + moduleName(d);
                }
            }

            return nm;
        }
    }
}