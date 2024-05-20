using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace MutateCSharp
{
    internal class Schemata436
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT436");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplacePrefixUnaryExprOp_7(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return --argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return +argument1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return ~argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return ++argument1; }
            return --argument1;
        }

        internal static int ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 - argument2;
        }

        internal static bool ReplaceBinExprOp_8(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBooleanConstant_2(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_3(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1--; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1++; }
            return argument1--;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static int ReplaceNumericConstant_0(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
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

    }
}

namespace Microsoft.Dafny
{
    public class Scope<Thing> where Thing : class
    {
        private DafnyOptions options;
        [Rep]
        readonly List<string> names = new();  // a null means a marker
        [Rep]
        readonly List<Thing> things = new();
        [ContractInvariantMethod]
        void ObjectInvariant()
        {
            Contract.Invariant(names != null);
            Contract.Invariant(things != null);
            Contract.Invariant(names.Count == things.Count);
            Contract.Invariant(-1 <= scopeSizeWhereInstancesWereDisallowed && scopeSizeWhereInstancesWereDisallowed <= names.Count);
        }

        int scopeSizeWhereInstancesWereDisallowed = MutateCSharp.Schemata436.ReplaceNumericConstant_0(1L, -1);

        public Scope(DafnyOptions options)
        {
            this.options = options;
        }

        public bool AllowInstance
        {
            get { return MutateCSharp.Schemata436.ReplaceBinExprOp_1(9L, scopeSizeWhereInstancesWereDisallowed, MutateCSharp.Schemata436.ReplaceNumericConstant_0(5L, -1)); }
            set
            {
                Contract.Assume(AllowInstance && !value);  // only allowed to change from true to false (that's all that's currently needed in Dafny); Pop is what can make the change in the other direction
                scopeSizeWhereInstancesWereDisallowed = names.Count;
            }
        }

        public void PushMarker()
        {
            names.Add(null);
            things.Add(null);
        }

        public void PopMarker()
        {
            int n = names.Count;
            while (MutateCSharp.Schemata436.ReplaceBooleanConstant_2(14L, true))
            {
                MutateCSharp.Schemata436.ReplacePostfixUnaryExprOp_3(15L, ref n);
                if (names[n] == null)
                {
                    break;
                }
            }
            names.RemoveRange(n, MutateCSharp.Schemata436.ReplaceBinExprOp_4(16L, names.Count, n));
            things.RemoveRange(n, MutateCSharp.Schemata436.ReplaceBinExprOp_4(25L, things.Count, n));
            if (MutateCSharp.Schemata436.ReplaceBinExprOp_5(34L, names.Count, scopeSizeWhereInstancesWereDisallowed))
            {
                scopeSizeWhereInstancesWereDisallowed = MutateCSharp.Schemata436.ReplaceNumericConstant_0(39L, -1);
            }
        }

        public enum PushResult { Duplicate, Shadow, Success }

        /// <summary>
        /// Pushes name-->thing association and returns "Success", if name has not already been pushed since the last marker.
        /// If name already has been pushed since the last marker, does nothing and returns "Duplicate".
        /// If the appropriate command-line option is supplied, then this method will also check if "name" shadows a previous
        /// name; if it does, then it will return "Shadow" instead of "Success".
        /// </summary>
        public PushResult Push(string name, Thing thing)
        {
            Contract.Requires(name != null);
            Contract.Requires(thing != null);
            if (Find(name, MutateCSharp.Schemata436.ReplaceBooleanConstant_2(43L, true)) != null)
            {
                return PushResult.Duplicate;
            }
            else
            {
                var r = PushResult.Success;
                if (MutateCSharp.Schemata436.ReplaceBinExprOp_6(45L, () => options.WarnShadowing, () => Find(name, MutateCSharp.Schemata436.ReplaceBooleanConstant_2(44L, false)) != null))
                {
                    r = PushResult.Shadow;
                }
                names.Add(name);
                things.Add(thing);
                return r;
            }

            return default;
        }

        Thing Find(string name, bool topScopeOnly)
        {
            Contract.Requires(name != null);
            for (int n = names.Count; MutateCSharp.Schemata436.ReplaceBinExprOp_8(59L, MutateCSharp.Schemata436.ReplaceNumericConstant_0(51L, 0), MutateCSharp.Schemata436.ReplacePrefixUnaryExprOp_7(55L, ref n));)
            {
                if (names[n] == null)
                {
                    if (topScopeOnly)
                    {
                        return null;  // not present
                    }
                }
                else if (MutateCSharp.Schemata436.ReplaceBinExprOp_9(64L, names[n], name))
                {
                    Thing t = things[n];
                    Contract.Assert(t != null);
                    return t;
                }
            }
            return null;  // not present
        }

        public Thing Find(string name)
        {
            Contract.Requires(name != null);
            return Find(name, MutateCSharp.Schemata436.ReplaceBooleanConstant_2(65L, false));
        }

        public Thing FindInCurrentScope(string name)
        {
            Contract.Requires(name != null);
            return Find(name, MutateCSharp.Schemata436.ReplaceBooleanConstant_2(66L, true));
        }

        public bool ContainsDecl(Thing t)
        {
            return things.Exists(thing => thing == t);
        }
    }
}