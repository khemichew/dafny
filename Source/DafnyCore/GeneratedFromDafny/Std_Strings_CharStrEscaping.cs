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
    internal class Schemata296
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT296");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_0(long mutantId, Dafny.Rune argument1, Dafny.Rune argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, System.Numerics.BigInteger argument1, System.Numerics.BigInteger argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 1)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            return argument1 > argument2;
        }

        internal static int ReplaceNumericConstant_2(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

    }
}

namespace Std.Strings.CharStrEscaping
{

    public partial class __default
    {
        public static Dafny.ISequence<Dafny.Rune> Escape(Dafny.ISequence<Dafny.Rune> str, Dafny.ISet<Dafny.Rune> mustEscape, Dafny.Rune escape)
        {
            Dafny.ISequence<Dafny.Rune> _191___accumulator = Dafny.Sequence<Dafny.Rune>.FromElements();
        TAIL_CALL_START:;
            if ((str).Equals(Dafny.Sequence<Dafny.Rune>.FromElements()))
            {
                return Dafny.Sequence<Dafny.Rune>.Concat(_191___accumulator, str);
            }
            else if ((mustEscape).Contains((str).Select(BigInteger.Zero)))
            {
                _191___accumulator = Dafny.Sequence<Dafny.Rune>.Concat(_191___accumulator, Dafny.Sequence<Dafny.Rune>.FromElements(escape, (str).Select(BigInteger.Zero)));
                Dafny.ISequence<Dafny.Rune> _in56 = (str).Drop(BigInteger.One);
                Dafny.ISet<Dafny.Rune> _in57 = mustEscape;
                Dafny.Rune _in58 = escape;
                str = _in56;
                mustEscape = _in57;
                escape = _in58;
                goto TAIL_CALL_START;
            }
            else
            {
                _191___accumulator = Dafny.Sequence<Dafny.Rune>.Concat(_191___accumulator, Dafny.Sequence<Dafny.Rune>.FromElements((str).Select(BigInteger.Zero)));
                Dafny.ISequence<Dafny.Rune> _in59 = (str).Drop(BigInteger.One);
                Dafny.ISet<Dafny.Rune> _in60 = mustEscape;
                Dafny.Rune _in61 = escape;
                str = _in59;
                mustEscape = _in60;
                escape = _in61;
                goto TAIL_CALL_START;
            }

            return default;
        }
        public static Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> Unescape(Dafny.ISequence<Dafny.Rune> str, Dafny.Rune escape)
        {
            if ((str).Equals(Dafny.Sequence<Dafny.Rune>.FromElements()))
            {
                return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_Some(str);
            }
            else if (MutateCSharp.Schemata296.ReplaceBinExprOp_0(1L, ((str).Select(BigInteger.Zero)), (escape)))
            {
                if (MutateCSharp.Schemata296.ReplaceBinExprOp_1(2L, (new BigInteger((str).Count)), (BigInteger.One)))
                {
                    Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _192_valueOrError0 = Std.Strings.CharStrEscaping.__default.Unescape((str).Drop(new BigInteger(MutateCSharp.Schemata296.ReplaceNumericConstant_2(4L, 2))), escape);
                    if ((_192_valueOrError0).IsFailure())
                    {
                        return (_192_valueOrError0).PropagateFailure<Dafny.ISequence<Dafny.Rune>>();
                    }
                    else
                    {
                        Dafny.ISequence<Dafny.Rune> _193_tl = (_192_valueOrError0).Extract();
                        return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_Some(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.FromElements((str).Select(BigInteger.One)), _193_tl));
                    }
                }
                else
                {
                    return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_None();
                }
            }
            else
            {
                Std.Wrappers._IOption<Dafny.ISequence<Dafny.Rune>> _194_valueOrError1 = Std.Strings.CharStrEscaping.__default.Unescape((str).Drop(BigInteger.One), escape);
                if ((_194_valueOrError1).IsFailure())
                {
                    return (_194_valueOrError1).PropagateFailure<Dafny.ISequence<Dafny.Rune>>();
                }
                else
                {
                    Dafny.ISequence<Dafny.Rune> _195_tl = (_194_valueOrError1).Extract();
                    return Std.Wrappers.Option<Dafny.ISequence<Dafny.Rune>>.create_Some(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.FromElements((str).Select(BigInteger.Zero)), _195_tl));
                }
            }

            return default;
        }
    }
} // end of namespace Std.Strings.CharStrEscaping