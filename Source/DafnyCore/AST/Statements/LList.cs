namespace MutateCSharp
{
    internal class Schemata162
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT162");
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

        internal static int ReplacePostfixUnaryExprOp_1(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

    }
}
namespace Microsoft.Dafny
{
    public class LList<T>
    {
        public readonly T Data;
        public readonly LList<T> Next;

        public LList(T d, LList<T> next)
        {
            Data = d;
            Next = next;
        }

        public static LList<T> Append(LList<T> a, LList<T> b)
        {
            if (a == null)
            {
                return b;
            }

            return new LList<T>(a.Data, Append(a.Next, b));
            // pretend this is ML
        }
        public static int Count(LList<T> n)
        {
            int count = MutateCSharp.Schemata162.ReplaceNumericConstant_0(1L, 0);
            while (n != null)
            {
                MutateCSharp.Schemata162.ReplacePostfixUnaryExprOp_1(5L, ref count);
                n = n.Next;
            }
            return count;
        }
    }
}