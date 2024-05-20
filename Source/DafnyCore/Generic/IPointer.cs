using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
namespace MutateCSharp
{
    internal class Schemata307
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT307");
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

    }
}

namespace Microsoft.Dafny
{
    public interface IPointer<T>
    {
        T Get();
        void Set(T value);
    }

    public
    record Pointer<T>(Func<T> Get, Action<T> Set) : IPointer<T>
    {
        T IPointer<T>.Get()
        {
            return Get();
        }

        void IPointer<T>.Set(T value)
        {
            Set(value);
        }
    }

    public static class PointerExtensions
    {
        public static IEnumerable<IPointer<T>> ToPointers<T>(this IList<T> values)
        {
            return Enumerable.Range(MutateCSharp.Schemata307.ReplaceNumericConstant_0(1L, 0), values.Count)
              .Select(index => new Pointer<T>(() => values[index],
                value => values[index] = value));
        }
    }
}