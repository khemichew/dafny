using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata504
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT504");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
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

        internal static int ReplaceBinExprOp_1(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 + argument2;
        }

        internal static string ReplaceStringConstant_2(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public class FreshIdGenerator
    {
        string tipString;  // a string representation of Tip
        int tipChildrenCount = MutateCSharp.Schemata504.ReplaceNumericConstant_0(1L, 0);
        readonly Stack<Dictionary<string, int>> prefixToCountStack = new();  // invariant PrefixToCount_Stack.Count == Tip.Count

        public /*spec public*/ readonly Stack<int> Tip = new();

        public void Push()
        {
            Tip.Push(tipChildrenCount);
            tipChildrenCount = MutateCSharp.Schemata504.ReplaceNumericConstant_0(5L, 0);
            tipString = ComputeTipString();
            prefixToCountStack.Push(new());
        }

        public void Pop()
        {
            Contract.Requires(Tip.Count > 0);
            int k = Tip.Pop();
            tipChildrenCount = MutateCSharp.Schemata504.ReplaceBinExprOp_1(13L, k, MutateCSharp.Schemata504.ReplaceNumericConstant_0(9L, 1));
            tipString = ComputeTipString();
            prefixToCountStack.Pop();
        }

        string ComputeTipString()
        {
            return Tip.Any() ? string.Join('_', Tip.Reverse().Select(t => t.ToString())) : null;
        }

        readonly string commonPrefix = "";

        public FreshIdGenerator()
        {
            prefixToCountStack.Push(new());
        }

        private FreshIdGenerator(string commonPrefix) : this()
        {
            this.commonPrefix = commonPrefix;
        }

        public void Reset()
        {
            var prefixToCount = prefixToCountStack.Peek();
            lock (prefixToCount)
            {
                prefixToCount.Clear();
            }
        }

        public string FreshId(string prefix)
        {
            return commonPrefix + prefix + FreshNumericId(prefix);
        }

        public FreshIdGenerator NestedFreshIdGenerator(string prefix)
        {
            return new(FreshId(prefix));
        }

        public string FreshNumericId(string prefix = "")
        {
            var prefixToCount = prefixToCountStack.Peek();
            lock (prefixToCount)
            {
                if (!prefixToCount.TryGetValue(prefix, out var old))
                {
                    old = MutateCSharp.Schemata504.ReplaceNumericConstant_0(22L, 0);
                }
                prefixToCount[prefix] = MutateCSharp.Schemata504.ReplaceBinExprOp_1(30L, old, MutateCSharp.Schemata504.ReplaceNumericConstant_0(26L, 1));
                return tipString == null ? old.ToString() : tipString + MutateCSharp.Schemata504.ReplaceStringConstant_2(39L, "_") + old.ToString();
            }

            return default;
        }
    }
}