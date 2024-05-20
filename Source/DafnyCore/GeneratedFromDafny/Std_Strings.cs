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
    internal class Schemata295
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT295");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Std.Strings
{

    public partial class __default
    {
        public static Dafny.ISequence<Dafny.Rune> OfNat(BigInteger n)
        {
            return Std.Strings.DecimalConversion.__default.OfNat(n);
        }
        public static Dafny.ISequence<Dafny.Rune> OfInt(BigInteger n)
        {
            return Std.Strings.DecimalConversion.__default.OfInt(n, new Dafny.Rune('-'));
        }
        public static BigInteger ToNat(Dafny.ISequence<Dafny.Rune> str)
        {
            return Std.Strings.DecimalConversion.__default.ToNat(str);
        }
        public static BigInteger ToInt(Dafny.ISequence<Dafny.Rune> str)
        {
            return Std.Strings.DecimalConversion.__default.ToInt(str, new Dafny.Rune('-'));
        }
        public static Dafny.ISequence<Dafny.Rune> EscapeQuotes(Dafny.ISequence<Dafny.Rune> str)
        {
            return Std.Strings.CharStrEscaping.__default.Escape(str, Dafny.Set<Dafny.Rune>.FromElements(new Dafny.Rune('\"'), new Dafny.Rune('\'')), new Dafny.Rune('\\'));
        }
        public static Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> UnescapeQuotes(Dafny.ISequence<Dafny.Rune> str)
        {
            return Std.Strings.CharStrEscaping.__default.Unescape(str, new Dafny.Rune('\\'));
        }
        public static Dafny.ISequence<Dafny.Rune> OfBool(bool b)
        {
            if (b)
            {
                return Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata295.ReplaceStringConstant_0(1L, "true"));
            }
            else
            {
                return Dafny.Sequence<Dafny.Rune>.UnicodeFromString(MutateCSharp.Schemata295.ReplaceStringConstant_0(2L, "false"));
            }

            return default;
        }
        public static Dafny.ISequence<Dafny.Rune> OfChar(Dafny.Rune c)
        {
            return Dafny.Sequence<Dafny.Rune>.FromElements(c);
        }
    }
} // end of namespace Std.Strings