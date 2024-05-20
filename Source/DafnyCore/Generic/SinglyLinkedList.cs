using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata317
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT317");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 - argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_4(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1--; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1++; }
            return argument1--;
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

        internal static bool ReplaceBooleanConstant_0(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 >= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 > argument2; }
            return argument1 >= argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public
class LinkedListEnumerator<T> : IEnumerator<T>
    {
        private Cons<T> list;

        public LinkedListEnumerator(Cons<T> list)
        {
            this.list = new Cons<T>(default, list);
        }

        public bool MoveNext()
        {
            if (list.Tail is Cons<T> tailCons)
            {
                list = tailCons;
                return MutateCSharp.Schemata317.ReplaceBooleanConstant_0(1L, true);
            }

            return MutateCSharp.Schemata317.ReplaceBooleanConstant_0(2L, false);
        }

        public void Reset()
        {
            throw new System.NotSupportedException();
        }

        public T Current => list.Head;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }

    public abstract record SinglyLinkedList<T> : IEnumerable<T>
    {
        public abstract IEnumerator<T> GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Any()
        {
            return this is not Nil<T>;
        }
    }

    public static class LinkedLists
    {
        public static SinglyLinkedList<T> Concat<T>(SinglyLinkedList<T> left, SinglyLinkedList<T> right)
        {
            return left switch
            {
                Nil<T> => right,
                Cons<T> cons => new Cons<T>(cons.Head, Concat<T>(cons.Tail, right)),
                _ => throw new ArgumentOutOfRangeException(nameof(left))
            };
        }


        public static SinglyLinkedList<T> FromList<T>(IReadOnlyList<T> values, SinglyLinkedList<T> tail = null)
        {
            SinglyLinkedList<T> result = tail ?? new Nil<T>();
            for (int i = MutateCSharp.Schemata317.ReplaceBinExprOp_2(7L, values.Count, MutateCSharp.Schemata317.ReplaceNumericConstant_1(3L, 1)); MutateCSharp.Schemata317.ReplaceBinExprOp_3(20L, i, MutateCSharp.Schemata317.ReplaceNumericConstant_1(16L, 0)); MutateCSharp.Schemata317.ReplacePostfixUnaryExprOp_4(25L, ref i))
            {
                result = new Cons<T>(values[i], result);
            }
            return result;
        }

        public static SinglyLinkedList<T> Create<T>(params T[] values)
        {
            return FromList(values);
        }
    }

    public record Cons<T>(T Head, SinglyLinkedList<T> Tail) : SinglyLinkedList<T>
    {
        public override IEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator<T>(this);
        }
    }

    public record Nil<T>() : SinglyLinkedList<T>
    {
        public override IEnumerator<T> GetEnumerator()
        {
            return Enumerable.Empty<T>().GetEnumerator();
        }
    }
}
