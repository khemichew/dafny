#nullable enable
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
namespace MutateCSharp
{
    internal class Schemata309
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT309");
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

namespace Microsoft.Dafny
{

    /// <summary>
    /// System.Collections.Concurrent.ConcurrentDictionary does not allow you to lazily add a value if it is missing,
    /// in a way that guarantees only running the lazy computation once.
    /// </summary>
    public class LazyConcurrentDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
      where TKey : notnull
    {
        private readonly ConcurrentDictionary<TKey, Lazy<TValue>> underlyingDictionary = new();

        public TValue GetOrAdd(TKey key, Func<TValue> computeValue)
        {
            var lazyResult = underlyingDictionary.GetOrAdd(key, new Lazy<TValue>(computeValue));
            return lazyResult.Value;
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return new Enumerator(underlyingDictionary.GetEnumerator());
        }

        public
          class Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>
        {
            private readonly IEnumerator<KeyValuePair<TKey, Lazy<TValue>>> underlying;

            public Enumerator(IEnumerator<KeyValuePair<TKey, Lazy<TValue>>> underlying)
            {
                this.underlying = underlying;
            }

            public bool MoveNext()
            {
                return underlying.MoveNext();
            }

            public void Reset()
            {
                underlying.Reset();
            }

            public KeyValuePair<TKey, TValue> Current => new(underlying.Current.Key, underlying.Current.Value.Value);

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                underlying.Dispose();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool TryGetValue(TKey key, out TValue? value)
        {
            if (underlyingDictionary.TryGetValue(key, out var lazyValue))
            {
                value = lazyValue.Value;
                return MutateCSharp.Schemata309.ReplaceBooleanConstant_0(1L, true);
            }

            value = default;
            return MutateCSharp.Schemata309.ReplaceBooleanConstant_0(2L, false);
        }

        public TValue this[TKey key] => underlyingDictionary[key].Value;
    }
}