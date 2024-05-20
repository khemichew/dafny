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
    internal class Schemata289
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT289");
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

        internal static bool ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

    }
}

namespace Std.Arithmetic.MulInternals
{

    public partial class __default
    {
        public static BigInteger MulPos(BigInteger x, BigInteger y)
        {
            BigInteger _149___accumulator = BigInteger.Zero;
        TAIL_CALL_START:;
            if (MutateCSharp.Schemata289.ReplaceBinExprOp_1(5L, (x).Sign, MutateCSharp.Schemata289.ReplaceNumericConstant_0(1L, 0)))
            {
                return (BigInteger.Zero) + (_149___accumulator);
            }
            else
            {
                _149___accumulator = (_149___accumulator) + (y);
                BigInteger _in32 = (x) - (BigInteger.One);
                BigInteger _in33 = y;
                x = _in32;
                y = _in33;
                goto TAIL_CALL_START;
            }

            return default;
        }
        public static BigInteger MulRecursive(BigInteger x, BigInteger y)
        {
            if (MutateCSharp.Schemata289.ReplaceBinExprOp_2(14L, (x).Sign, MutateCSharp.Schemata289.ReplaceNumericConstant_0(10L, -1)))
            {
                return Std.Arithmetic.MulInternals.__default.MulPos(x, y);
            }
            else
            {
                return (new BigInteger(MutateCSharp.Schemata289.ReplaceNumericConstant_0(19L, -1))) * (Std.Arithmetic.MulInternals.__default.MulPos((new BigInteger(MutateCSharp.Schemata289.ReplaceNumericConstant_0(23L, -1))) * (x), y));
            }

            return default;
        }
    }
} // end of namespace Std.Arithmetic.MulInternals