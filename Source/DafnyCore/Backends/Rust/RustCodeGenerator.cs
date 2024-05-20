using System;
using System.IO;
using System.Linq;
using Dafny;
using DCOMP;
namespace MutateCSharp
{
    internal class Schemata246
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT246");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny.Compilers
{
    public
      class RustCodeGenerator : DafnyWrittenCodeGenerator
    {

        public override ISequence<Rune> Compile(Sequence<DAST.Module> program)
        {
            var c = new COMP();
            c.__ctor(MutateCSharp.Schemata246.ReplaceBooleanConstant_0(1L, true));
            return c.Compile(program);
        }

        public override ISequence<Rune> EmitCallToMain(string fullName)
        {
            var splitByDot = fullName.Split('.');
            var convertedToUnicode = Sequence<Sequence<Rune>>.FromArray(splitByDot.Select(s => (Sequence<Rune>)Sequence<Rune>.UnicodeFromString(s)).ToArray());
            return COMP.EmitCallToMain(convertedToUnicode);
        }

    }

}