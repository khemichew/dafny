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
    internal class Schemata285
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT285");
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

    }
}

namespace Std.Arithmetic.Logarithm
{

    public partial class __default
    {
        public static BigInteger Log(BigInteger @base, BigInteger pow)
        {
            BigInteger _152___accumulator = BigInteger.Zero;
        TAIL_CALL_START:;
            if (MutateCSharp.Schemata285.ReplaceBinExprOp_0(1L, (pow), (@base)))
            {
                return (BigInteger.Zero) + (_152___accumulator);
            }
            else
            {
                _152___accumulator = (_152___accumulator) + (BigInteger.One);
                BigInteger _in44 = @base;
                BigInteger _in45 = Dafny.Helpers.EuclideanDivision(pow, @base);
                @base = _in44;
                pow = _in45;
                goto TAIL_CALL_START;
            }

            return default;
        }
    }
} // end of namespace Std.Arithmetic.Logarithm