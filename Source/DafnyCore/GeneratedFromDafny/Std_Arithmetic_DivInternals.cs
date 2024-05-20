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
    internal class Schemata281
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT281");
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

        internal static bool ReplaceBinExprOp_2(long mutantId, System.Numerics.BigInteger argument1, System.Numerics.BigInteger argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 < argument2;
        }

    }
}

namespace Std.Arithmetic.DivInternals
{

    public partial class __default
    {
        public static BigInteger DivPos(BigInteger x, BigInteger d)
        {
            BigInteger _150___accumulator = BigInteger.Zero;
        TAIL_CALL_START:;
            if (MutateCSharp.Schemata281.ReplaceBinExprOp_1(5L, (x).Sign, MutateCSharp.Schemata281.ReplaceNumericConstant_0(1L, -1)))
            {
                _150___accumulator = (_150___accumulator) + (new BigInteger(MutateCSharp.Schemata281.ReplaceNumericConstant_0(10L, -1)));
                BigInteger _in38 = (x) + (d);
                BigInteger _in39 = d;
                x = _in38;
                d = _in39;
                goto TAIL_CALL_START;
            }
            else if (MutateCSharp.Schemata281.ReplaceBinExprOp_2(14L, (x), (d)))
            {
                return (BigInteger.Zero) + (_150___accumulator);
            }
            else
            {
                _150___accumulator = (_150___accumulator) + (BigInteger.One);
                BigInteger _in40 = (x) - (d);
                BigInteger _in41 = d;
                x = _in40;
                d = _in41;
                goto TAIL_CALL_START;
            }

            return default;
        }
        public static BigInteger DivRecursive(BigInteger x, BigInteger d)
        {
            if (MutateCSharp.Schemata281.ReplaceBinExprOp_1(20L, (d).Sign, MutateCSharp.Schemata281.ReplaceNumericConstant_0(16L, 1)))
            {
                return Std.Arithmetic.DivInternals.__default.DivPos(x, d);
            }
            else
            {
                return (new BigInteger(MutateCSharp.Schemata281.ReplaceNumericConstant_0(25L, -1))) * (Std.Arithmetic.DivInternals.__default.DivPos(x, (new BigInteger(MutateCSharp.Schemata281.ReplaceNumericConstant_0(29L, -1))) * (d)));
            }

            return default;
        }
    }
} // end of namespace Std.Arithmetic.DivInternals