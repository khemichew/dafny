using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
namespace MutateCSharp
{
    internal class Schemata322
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT322");
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

        internal static int ReplaceNumericConstant_1(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() && argument2();
        }

    }
}

namespace Microsoft.Dafny
{


    /// <summary>
    /// Stream of observables: +------1------2-----3-------------------------------|
    ///   Observable-1         :      +--A-----------------B--|
    ///   Observable-2         :             +---C---------------------D--|
    ///   Observable-3         :                   +--E----------------------F--|
    ///   Merge                : +-------A-------C----E----B-----------D-----F--|
    ///   MergeOrdered         : +-------A-----------------B--C--------D--E--F-----|
    /// </summary>
    public class MergeOrdered<T> : IObservable<T>, IObserver<IObservable<T>>, IDisposable
    {
        private readonly Queue<IObservable<T>> allUpdates = new();
        public bool Idle { get; private set; } = MutateCSharp.Schemata322.ReplaceBooleanConstant_0(1L, true);
        private bool outerCompleted;
        private readonly Subject<T> result = new();
        private readonly ReplaySubject<bool> idleStates = new(MutateCSharp.Schemata322.ReplaceNumericConstant_1(2L, 1));

        public IObservable<bool> IdleChangesIncludingLast => idleStates.DistinctUntilChanged();

        public void OnNext(IObservable<T> next)
        {
            lock (this)
            {
                if (Idle)
                {
                    Idle = MutateCSharp.Schemata322.ReplaceBooleanConstant_0(6L, false);
                    next.Subscribe(InnerNext, InnerError, InnerCompleted);
                }
                else
                {
                    allUpdates.Enqueue(next);
                }
            }
            idleStates.OnNext(Idle);
        }

        private void InnerNext(T next)
        {
            result.OnNext(next);
        }

        private void InnerError(Exception error)
        {
            result.OnError(error);
        }

        private void InnerCompleted()
        {
            lock (this)
            {
                Idle = MutateCSharp.Schemata322.ReplaceBooleanConstant_0(7L, true);
                if (allUpdates.Any())
                {
                    var next = allUpdates.Dequeue();
                    OnNext(next);
                }
            }
            idleStates.OnNext(Idle);
            CheckCompleted();
        }

        public void OnError(Exception error)
        {
            // ReSharper disable once InconsistentlySynchronizedField
            result.OnError(error);
        }

        public void OnCompleted()
        {
            outerCompleted = MutateCSharp.Schemata322.ReplaceBooleanConstant_0(8L, true);
            CheckCompleted();
        }

        private void CheckCompleted()
        {
            if (MutateCSharp.Schemata322.ReplaceBinExprOp_2(9L, () => outerCompleted, () => Idle))
            {
                // ReSharper disable once InconsistentlySynchronizedField
                result.OnCompleted();
                idleStates.OnCompleted();
            }
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            // ReSharper disable once InconsistentlySynchronizedField
            return result.Subscribe(observer);
        }

        public void Dispose()
        {
            result.Dispose();
        }
    }
}