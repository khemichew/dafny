// Dafny program the_program compiled into C#
// To recompile, you will need the libraries
//     System.Runtime.Numerics.dll System.Collections.Immutable.dll
// but the 'dotnet' tool in net6.0 should pick those up automatically.
// Optionally, you may want to include compiler switches like
//     /debug /nowarn:162,164,168,183,219,436,1717,1718

using System;
using System.Numerics;
using System.Collections;
namespace MutateCSharp
{
    internal class Schemata294
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT294");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, System.Numerics.BigInteger argument1, System.Numerics.BigInteger argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 < argument2;
        }

        internal static int ReplaceNumericConstant_1(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Std.Math
{

    public partial class __default
    {
        public static BigInteger Min(BigInteger a, BigInteger b)
        {
            if (MutateCSharp.Schemata294.ReplaceBinExprOp_0(1L, (a), (b)))
            {
                return a;
            }
            else
            {
                return b;
            }

            return default;
        }
        public static BigInteger Min3(BigInteger a, BigInteger b, BigInteger c)
        {
            return Std.Math.__default.Min(a, Std.Math.__default.Min(b, c));
        }
        public static BigInteger Max(BigInteger a, BigInteger b)
        {
            if (MutateCSharp.Schemata294.ReplaceBinExprOp_0(3L, (a), (b)))
            {
                return b;
            }
            else
            {
                return a;
            }

            return default;
        }
        public static BigInteger Max3(BigInteger a, BigInteger b, BigInteger c)
        {
            return Std.Math.__default.Max(a, Std.Math.__default.Max(b, c));
        }
        public static BigInteger Abs(BigInteger a)
        {
            if (MutateCSharp.Schemata294.ReplaceBinExprOp_2(9L, (a).Sign, MutateCSharp.Schemata294.ReplaceNumericConstant_1(5L, -1)))
            {
                return (BigInteger.Zero) - (a);
            }
            else
            {
                return a;
            }

            return default;
        }
    }
} // end of namespace Std.Math