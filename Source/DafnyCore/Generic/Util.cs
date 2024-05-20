// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.Contracts;
using System.IO;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.Boogie;
using static Microsoft.Dafny.GenericErrors;
namespace MutateCSharp
{
    internal class Schemata319
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT319");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_14(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_38(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_30(long mutantId, Microsoft.Dafny.ProgramTraverser.ContinuationStatus argument1, Microsoft.Dafny.ProgramTraverser.ContinuationStatus argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_32(long mutantId, Microsoft.Dafny.Method argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceBinExprOp_7(long mutantId, int argument1, int argument2)
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

        internal static string ReplaceStringConstant_3(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_34(long mutantId, Microsoft.Dafny.BlockStmt argument1, Microsoft.Dafny.BlockStmt argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_33(long mutantId, Microsoft.Dafny.Method argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_4(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_22(long mutantId, Microsoft.Dafny.ModuleDefinition argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_36(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() == argument2();
        }

        internal static bool ReplaceBinExprOp_31(long mutantId, Microsoft.Dafny.Formal argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_28(long mutantId, Microsoft.Dafny.NonNullTypeDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_24(long mutantId, Microsoft.Dafny.ModuleDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceBinExprOp_12(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 + argument2;
        }

        internal static bool ReplaceBinExprOp_19(long mutantId, ulong argument1, ulong argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_35(long mutantId, Microsoft.Dafny.BlockStmt argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, Microsoft.Dafny.Expression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static bool ReplaceBinExprOp_29(long mutantId, Microsoft.Dafny.MemberDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBooleanConstant_8(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static ulong ReplaceNumericConstant_18(long mutantId, ulong argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 2)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_20(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_25(long mutantId, Microsoft.Dafny.Formal argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_26(long mutantId, Microsoft.Dafny.DatatypeCtor argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_15(long mutantId, Microsoft.Dafny.FrameExpression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 <= argument2;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_21(long mutantId, Microsoft.Dafny.Program argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_27(long mutantId, Microsoft.Dafny.TopLevelDecl argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_9(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 >= argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 > argument2; }
            return argument1 >= argument2;
        }

        internal static bool ReplaceBinExprOp_17(long mutantId, Microsoft.Dafny.AttributedExpression argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_23(long mutantId, System.Collections.Generic.IEnumerable<Microsoft.Dafny.TopLevelDecl> argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_37(long mutantId, Microsoft.Dafny.Statement argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_10(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() || argument2();
        }

    }
}


namespace Microsoft.Dafny
{
    public static class Sets
    {
        public static ISet<T> Empty<T>()
        {
            return new HashSet<T>();
        }
    }

    public static class Util
    {

        public static Task WaitForComplete<T>(this IObservable<T> observable)
        {
            var result = new TaskCompletionSource();
            observable.Subscribe(_ => { }, e => result.SetException(e), () => result.SetResult());
            return result.Task;
        }

        public static string CapitaliseFirstLetter(this string input)
        {
            if (MutateCSharp.Schemata319.ReplaceBinExprOp_1(5L, input.Length, MutateCSharp.Schemata319.ReplaceNumericConstant_0(1L, 0)))
            {
                return char.ToUpper(input[MutateCSharp.Schemata319.ReplaceNumericConstant_0(10L, 0)]) + input.Substring(MutateCSharp.Schemata319.ReplaceNumericConstant_0(14L, 1));
            }

            return input;
        }

        public static bool LessThanOrEquals<T>(this T first, T second)
          where T : IComparable<T>
        {
            return MutateCSharp.Schemata319.ReplaceBinExprOp_2(22L, first.CompareTo(second), MutateCSharp.Schemata319.ReplaceNumericConstant_0(18L, 1));
        }

        public static Task<U> SelectMany<T, U>(this Task<T> task, Func<T, Task<U>> f)
        {
#pragma warning disable VSTHRD003
            return Select(task, f).Unwrap();
#pragma warning restore VSTHRD003
        }

        public static Task<U> Select<T, U>(this Task<T> task, Func<T, U> f)
        {
#pragma warning disable VSTHRD105
            return task.ContinueWith(completedTask => f(completedTask.Result), TaskContinuationOptions.OnlyOnRanToCompletion);
#pragma warning restore VSTHRD105
        }

        public static string Comma<T>(this IEnumerable<T> l)
        {
            return Comma(l, s => s.ToString());
        }

        public static string Comma<T>(this IEnumerable<T> l, Func<T, string> f)
        {
            return Comma(MutateCSharp.Schemata319.ReplaceStringConstant_3(27L, ", "), l, (element, index) => f(element));
        }

        public static string Comma<T>(this IEnumerable<T> l, Func<T, int, string> f)
        {
            return Comma(MutateCSharp.Schemata319.ReplaceStringConstant_3(28L, ", "), l, f);
        }

        public static string Comma<T>(string comma, IEnumerable<T> l, Func<T, string> f)
        {
            return Comma(comma, l, (element, index) => f(element));
        }

        public static string Comma<T>(string comma, IEnumerable<T> l, Func<T, int, string> f)
        {
            Contract.Requires(comma != null);
            string res = "";
            string c = "";
            int index = MutateCSharp.Schemata319.ReplaceNumericConstant_0(29L, 0);
            foreach (var t in l)
            {
                res += c + f(t, index);
                c = comma;
                MutateCSharp.Schemata319.ReplacePostfixUnaryExprOp_4(33L, ref index);
            }
            return res;
        }

        public static string Comma(int count, Func<int, string> f)
        {
            Contract.Requires(0 <= count);
            return Comma(MutateCSharp.Schemata319.ReplaceStringConstant_3(34L, ", "), count, f);
        }

        public static string Comma(string comma, int count, Func<int, string> f)
        {
            Contract.Requires(comma != null);
            Contract.Requires(0 <= count);
            string res = "";
            string c = "";
            for (int i = MutateCSharp.Schemata319.ReplaceNumericConstant_0(35L, 0); MutateCSharp.Schemata319.ReplaceBinExprOp_5(39L, i, count); MutateCSharp.Schemata319.ReplacePostfixUnaryExprOp_4(44L, ref i))
            {
                res += c + f(i);
                c = comma;
            }
            return res;
        }

        public static IEnumerable<(T, int)> Indexed<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.Select((value, index) => (value, index));
        }

        public static string PrintableNameList(List<string> names, string grammaticalConjunction)
        {
            Contract.Requires(names != null);
            Contract.Requires(1 <= names.Count);
            Contract.Requires(grammaticalConjunction != null);
            var n = names.Count;
            if (MutateCSharp.Schemata319.ReplaceBinExprOp_6(49L, n, MutateCSharp.Schemata319.ReplaceNumericConstant_0(45L, 1)))
            {
                return string.Format(MutateCSharp.Schemata319.ReplaceStringConstant_3(54L, "'{0}'"), names[MutateCSharp.Schemata319.ReplaceNumericConstant_0(55L, 0)]);
            }
            else if (MutateCSharp.Schemata319.ReplaceBinExprOp_6(63L, n, MutateCSharp.Schemata319.ReplaceNumericConstant_0(59L, 2)))
            {
                return string.Format(MutateCSharp.Schemata319.ReplaceStringConstant_3(68L, "'{0}' {1} '{2}'"), names[MutateCSharp.Schemata319.ReplaceNumericConstant_0(69L, 0)], grammaticalConjunction, names[MutateCSharp.Schemata319.ReplaceNumericConstant_0(73L, 1)]);
            }
            else
            {
                var s = "";
                for (int i = MutateCSharp.Schemata319.ReplaceNumericConstant_0(77L, 0); MutateCSharp.Schemata319.ReplaceBinExprOp_5(94L, i, MutateCSharp.Schemata319.ReplaceBinExprOp_7(85L, n, MutateCSharp.Schemata319.ReplaceNumericConstant_0(81L, 1))); MutateCSharp.Schemata319.ReplacePostfixUnaryExprOp_4(99L, ref i))
                {
                    s += string.Format(MutateCSharp.Schemata319.ReplaceStringConstant_3(100L, "'{0}', "), names[i]);
                }
                return s + string.Format(MutateCSharp.Schemata319.ReplaceStringConstant_3(101L, "{0} '{1}'"), grammaticalConjunction, names[MutateCSharp.Schemata319.ReplaceBinExprOp_7(106L, n, MutateCSharp.Schemata319.ReplaceNumericConstant_0(102L, 1))]);
            }

            return default;
        }

        public static string Repeat(int count, string s)
        {
            Contract.Requires(0 <= count);
            Contract.Requires(s != null);
            // special-case trivial cases
            if (MutateCSharp.Schemata319.ReplaceBinExprOp_6(119L, count, MutateCSharp.Schemata319.ReplaceNumericConstant_0(115L, 0)))
            {
                return "";
            }
            else if (MutateCSharp.Schemata319.ReplaceBinExprOp_6(128L, count, MutateCSharp.Schemata319.ReplaceNumericConstant_0(124L, 1)))
            {
                return s;
            }
            else
            {
                return Comma("", count, _ => s);
            }

            return default;
        }

        public static string Plural(int n)
        {
            Contract.Requires(0 <= n);
            return MutateCSharp.Schemata319.ReplaceBinExprOp_6(137L, n, MutateCSharp.Schemata319.ReplaceNumericConstant_0(133L, 1)) ? "" : MutateCSharp.Schemata319.ReplaceStringConstant_3(142L, "s");
        }

        public static List<B> Map<A, B>(IEnumerable<A> xs, Func<A, B> f)
        {
            List<B> ys = new List<B>();
            foreach (A x in xs)
            {
                ys.Add(f(x));
            }
            return ys;
        }

        public static List<A> Nil<A>()
        {
            return new List<A>();
        }

        public static List<A> Singleton<A>(A x)
        {
            return new List<A> { x };
        }

        public static List<A> List<A>(params A[] xs)
        {
            return xs.ToList();
        }

        public static List<A> Cons<A>(A x, List<A> xs)
        {
            return Concat(Singleton(x), xs);
        }

        public static List<A> Snoc<A>(List<A> xs, A x)
        {
            return Concat(xs, Singleton(x));
        }

        public static List<A> Concat<A>(List<A> xs, List<A> ys)
        {
            List<A> cpy = new List<A>(xs);
            cpy.AddRange(ys);
            return cpy;
        }

        public static Dictionary<A, B> Dict<A, B>(IEnumerable<A> xs, IEnumerable<B> ys)
        {
            return Dict<A, B>(Enumerable.Zip(xs, ys).Select(x => new Tuple<A, B>(x.First, x.Second)));
        }

        public static Dictionary<A, B> Dict<A, B>(IEnumerable<Tuple<A, B>> xys)
        {
            Dictionary<A, B> res = new Dictionary<A, B>();
            foreach (var p in xys)
            {
                res[p.Item1] = p.Item2;
            }
            return res;
        }

        public static void AddToDict<A, B>(Dictionary<A, B> dict, List<A> xs, List<B> ys)
        {
            Contract.Requires(dict != null);
            Contract.Requires(xs != null);
            Contract.Requires(ys != null);
            Contract.Requires(xs.Count == ys.Count);
            for (var i = MutateCSharp.Schemata319.ReplaceNumericConstant_0(143L, 0); MutateCSharp.Schemata319.ReplaceBinExprOp_5(147L, i, xs.Count); MutateCSharp.Schemata319.ReplacePostfixUnaryExprOp_4(152L, ref i))
            {
                dict.Add(xs[i], ys[i]);
            }
        }

        /// <summary>
        /// Returns s but with all occurrences of '_' removed.
        /// </summary>
        public static string RemoveUnderscores(string s)
        {
            Contract.Requires(s != null);
            return s.Replace(MutateCSharp.Schemata319.ReplaceStringConstant_3(153L, "_"), "");
        }

        /// <summary>
        /// For "S" returns S and false.
        /// For @"S" return S and true.
        /// Assumes that s has one of these forms.
        /// </summary>
        public static string RemoveParsedStringQuotes(string s, out bool isVerbatimString)
        {
            Contract.Requires(s != null);
            var len = s.Length;
            if (MutateCSharp.Schemata319.ReplaceBinExprOp_6(158L, s[MutateCSharp.Schemata319.ReplaceNumericConstant_0(154L, 0)], '@'))
            {
                isVerbatimString = MutateCSharp.Schemata319.ReplaceBooleanConstant_8(163L, true);
                return s.Substring(MutateCSharp.Schemata319.ReplaceNumericConstant_0(164L, 2), MutateCSharp.Schemata319.ReplaceBinExprOp_7(172L, len, MutateCSharp.Schemata319.ReplaceNumericConstant_0(168L, 3)));
            }
            else
            {
                isVerbatimString = MutateCSharp.Schemata319.ReplaceBooleanConstant_8(181L, false);
                return s.Substring(MutateCSharp.Schemata319.ReplaceNumericConstant_0(182L, 1), MutateCSharp.Schemata319.ReplaceBinExprOp_7(190L, len, MutateCSharp.Schemata319.ReplaceNumericConstant_0(186L, 2)));
            }

            return default;
        }

        public static void ValidateEscaping(DafnyOptions options, IToken t, string s, bool isVerbatimString, Errors errors)
        {
            if (options.Get(CommonOptionBag.UnicodeCharacters))
            {
                foreach (var token in TokensWithEscapes(s, isVerbatimString))
                {
                    if (token.StartsWith(MutateCSharp.Schemata319.ReplaceStringConstant_3(199L, "\\u")))
                    {
                        errors.SemErr(ErrorId.g_no_old_unicode_char, t, MutateCSharp.Schemata319.ReplaceStringConstant_3(200L, "\\u escape sequences are not permitted when Unicode chars are enabled"));
                    }

                    if (token.StartsWith(MutateCSharp.Schemata319.ReplaceStringConstant_3(201L, "\\U")))
                    {
                        var hexDigits = RemoveUnderscores(token[3..^MutateCSharp.Schemata319.ReplaceNumericConstant_0(202L, 1)]);
                        if (MutateCSharp.Schemata319.ReplaceBinExprOp_1(210L, hexDigits.Length, MutateCSharp.Schemata319.ReplaceNumericConstant_0(206L, 6)))
                        {
                            errors.SemErr(ErrorId.g_unicode_escape_must_have_six_digits, t, MutateCSharp.Schemata319.ReplaceStringConstant_3(215L, "\\U{X..X} escape sequence must have at most six hex digits"));
                        }
                        else
                        {
                            var codePoint = Convert.ToInt32(hexDigits, MutateCSharp.Schemata319.ReplaceNumericConstant_0(216L, 16));
                            if (MutateCSharp.Schemata319.ReplaceBinExprOp_9(224L, codePoint, MutateCSharp.Schemata319.ReplaceNumericConstant_0(220L, 0x11_0000)))
                            {
                                errors.SemErr(ErrorId.g_unicode_escape_is_too_large, t, MutateCSharp.Schemata319.ReplaceStringConstant_3(229L, "\\U{X..X} escape sequence must be less than 0x110000"));
                            }
                            if (codePoint is >= 0xD800 and < 0xE000)
                            {
                                errors.SemErr(ErrorId.g_unicode_escape_may_not_be_surrogate, t, MutateCSharp.Schemata319.ReplaceStringConstant_3(230L, "\\U{X..X} escape sequence must not be a surrogate"));
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (var token2 in TokensWithEscapes(s, isVerbatimString))
                {
                    if (token2.StartsWith(MutateCSharp.Schemata319.ReplaceStringConstant_3(231L, "\\U")))
                    {
                        errors.SemErr(ErrorId.g_U_unicode_chars_are_disallowed, t, MutateCSharp.Schemata319.ReplaceStringConstant_3(232L, "\\U escape sequences are not permitted when Unicode chars are disabled"));
                    }
                }
            }
        }

        public static bool MightContainNonAsciiCharacters(string s, bool isVerbatimString)
        {
            // This is conservative since \u and \U escapes could be ASCII characters,
            // but that's fine since this method is just used as a conservative guard.
            return TokensWithEscapes(s, isVerbatimString).Any(e => MutateCSharp.Schemata319.ReplaceBinExprOp_10(241L, () => MutateCSharp.Schemata319.ReplaceBinExprOp_10(234L, () => e.Any(c => !char.IsAscii(c)), () => e.StartsWith(MutateCSharp.Schemata319.ReplaceStringConstant_3(233L, @"\u"))), () => e.StartsWith(MutateCSharp.Schemata319.ReplaceStringConstant_3(240L, @"\U"))));
        }

        /// <summary>
        /// Replaced any escaped characters in s by the actual character that the escaping represents.
        /// Assumes s to be a well-parsed string.
        /// </summary>
        public static string RemoveEscaping(DafnyOptions options, string s, bool isVerbatimString)
        {
            Contract.Requires(s != null);
            var sb = new StringBuilder();
            if (options.Get(CommonOptionBag.UnicodeCharacters))
            {
                UnescapedCharacters(options, s, isVerbatimString).ForEach(ch => sb.Append(new Rune(ch)));
            }
            else
            {
                UnescapedCharacters(options, s, isVerbatimString).ForEach(ch => sb.Append((char)ch));
            }
            return sb.ToString();
        }

        public static readonly Regex Utf16Escape = new Regex(MutateCSharp.Schemata319.ReplaceStringConstant_3(247L, @"\\u([0-9a-fA-F]{4})"));
        public static readonly Regex UnicodeEscape = new Regex(MutateCSharp.Schemata319.ReplaceStringConstant_3(248L, @"\\U\{([0-9a-fA-F_]+)\}"));
        private static readonly Regex NullEscape = new Regex(MutateCSharp.Schemata319.ReplaceStringConstant_3(249L, @"\\0"));

        private static string ToUtf16Escape(char c)
        {
            return $"\\u{(int)c:x4}";
        }

        public static string ReplaceTokensWithEscapes(string s, Regex pattern, MatchEvaluator evaluator)
        {
            return string.Join("",
              TokensWithEscapes(s, MutateCSharp.Schemata319.ReplaceBooleanConstant_8(250L, false))
                .Select(token => pattern.Replace(token, evaluator)));
        }

        public static string ExpandUnicodeEscapes(string s, bool lowerCaseU)
        {
            return ReplaceTokensWithEscapes(s, UnicodeEscape, match =>
            {
                var hexDigits = RemoveUnderscores(match.Groups[MutateCSharp.Schemata319.ReplaceNumericConstant_0(251L, 1)].Value);
                var padChars = MutateCSharp.Schemata319.ReplaceBinExprOp_7(259L, MutateCSharp.Schemata319.ReplaceNumericConstant_0(255L, 8), hexDigits.Length);
                return (lowerCaseU ? MutateCSharp.Schemata319.ReplaceStringConstant_3(268L, "\\u") : MutateCSharp.Schemata319.ReplaceStringConstant_3(269L, "\\U")) + new string('0', padChars) + hexDigits;
            });
        }

        public static string UnicodeEscapesToLowercase(string s)
        {
            return ReplaceTokensWithEscapes(s, UnicodeEscape, match =>
              $"\\u{{{RemoveUnderscores(match.Groups[MutateCSharp.Schemata319.ReplaceNumericConstant_0(270L, 1)].Value)}}}");
        }

        public static string UnicodeEscapesToUtf16Escapes(string s)
        {
            return ReplaceTokensWithEscapes(s, UnicodeEscape, match =>
            {
                var utf16CodeUnits = new char[MutateCSharp.Schemata319.ReplaceNumericConstant_0(274L, 2)];
                var hexDigits = RemoveUnderscores(match.Groups[MutateCSharp.Schemata319.ReplaceNumericConstant_0(278L, 1)].Value);
                var codePoint = new Rune(Convert.ToInt32(hexDigits, MutateCSharp.Schemata319.ReplaceNumericConstant_0(282L, 16)));
                var codeUnits = codePoint.EncodeToUtf16(utf16CodeUnits);
                if (MutateCSharp.Schemata319.ReplaceBinExprOp_6(290L, codeUnits, MutateCSharp.Schemata319.ReplaceNumericConstant_0(286L, 2)))
                {
                    return ToUtf16Escape(utf16CodeUnits[MutateCSharp.Schemata319.ReplaceNumericConstant_0(295L, 0)]) + ToUtf16Escape(utf16CodeUnits[MutateCSharp.Schemata319.ReplaceNumericConstant_0(299L, 1)]); ;
                }
                else
                {
                    return ToUtf16Escape(utf16CodeUnits[MutateCSharp.Schemata319.ReplaceNumericConstant_0(303L, 0)]);
                }

                return default;
            });
        }

        public static string ReplaceNullEscapesWithCharacterEscapes(string s)
        {
            return ReplaceTokensWithEscapes(s, NullEscape, match => MutateCSharp.Schemata319.ReplaceStringConstant_3(307L, "\\u0000"));
        }

        /// <summary>
        /// Returns the characters of the well-parsed string p, replacing any
        /// escaped characters by the actual characters.
        /// 
        /// It also converts surrogate pairs to their equivalent code points
        /// if --unicode-char is enabled - these are synthesized by the parser when
        /// reading the original UTF-8 source, but don't represent the true character values.
        /// </summary>
        public static IEnumerable<int> UnescapedCharacters(DafnyOptions options, string p, bool isVerbatimString)
        {
            var unicodeChars = options.Get(CommonOptionBag.UnicodeCharacters);
            if (isVerbatimString)
            {
                foreach (var s in TokensWithEscapes(p, MutateCSharp.Schemata319.ReplaceBooleanConstant_8(308L, true)))
                {
                    if (MutateCSharp.Schemata319.ReplaceBinExprOp_11(310L, s, MutateCSharp.Schemata319.ReplaceStringConstant_3(309L, "\"\"")))
                    {
                        yield return '"';
                    }
                    else
                    {
                        foreach (var c in s)
                        {
                            yield return c;
                        }
                    }
                }
            }
            else
            {
                foreach (var s in TokensWithEscapes(p, MutateCSharp.Schemata319.ReplaceBooleanConstant_8(311L, false)))
                {
                    switch (s)
                    {
                        case @"\'":
                            yield return '\''; break;
                            break;
                        case @"\""":
                            yield return '"'; break;
                            break;
                        case @"\\":
                            yield return '\\'; break;
                            break;
                        case @"\0":
                            yield return '\0'; break;
                            break;
                        case @"\n":
                            yield return '\n'; break;
                            break;
                        case @"\r":
                            yield return '\r'; break;
                            break;
                        case @"\t":
                            yield return '\t'; break;
                            break;
                        case { } when s.StartsWith(@"\u"):
                            yield return Convert.ToInt32(s[2..], 16);
                            break;
                            break;
                        case { } when s.StartsWith(@"\U"):
                            yield return Convert.ToInt32(Util.RemoveUnderscores(s[3..^1]), 16);
                            break;
                            break;
                        case { } when unicodeChars && char.IsHighSurrogate(s[0]):
                            yield return char.ConvertToUtf32(s[0], s[1]);
                            break;
                            break;
                        default:
                            foreach (var c in s)
                            {
                                yield return c;
                            }
                            break;
                            break;
                    }
                }
            }

            yield break;
        }

        /// <summary>
        /// Enumerates the sequence of regular characters and escape sequences in the given well-parsed string.
        /// For example, "ab\tuv\u12345" may be broken up as ["a", "b", "\t", "u", "v", "\u1234", "5"].
        /// Consecutive non-escaped characters may or may not be enumerated as a single string.
        /// </summary>
        public static IEnumerable<string> TokensWithEscapes(string p, bool isVerbatimString)
        {
            Contract.Requires(p != null);
            if (isVerbatimString)
            {
                var skipNext = MutateCSharp.Schemata319.ReplaceBooleanConstant_8(312L, false);
                foreach (var ch in p)
                {
                    if (skipNext)
                    {
                        skipNext = MutateCSharp.Schemata319.ReplaceBooleanConstant_8(313L, false);
                    }
                    else
                    {
                        if (MutateCSharp.Schemata319.ReplaceBinExprOp_6(314L, ch, '"'))
                        {
                            skipNext = MutateCSharp.Schemata319.ReplaceBooleanConstant_8(319L, true);
                            yield return MutateCSharp.Schemata319.ReplaceStringConstant_3(320L, "\"");
                        }
                        else
                        {
                            yield return ch.ToString();
                        }
                    }
                }
            }
            else
            {
                var i = MutateCSharp.Schemata319.ReplaceNumericConstant_0(321L, 0);
                while (MutateCSharp.Schemata319.ReplaceBinExprOp_5(325L, i, p.Length))
                {
                    if (MutateCSharp.Schemata319.ReplaceBinExprOp_6(330L, p[i], '\\'))
                    {
                        switch (p[MutateCSharp.Schemata319.ReplaceBinExprOp_12(339L, i, MutateCSharp.Schemata319.ReplaceNumericConstant_0(335L, 1))])
                        {
                            case 'u':
                                yield return p[i..(i + 6)];
                                i += 6;
                                break;
                                break;
                            case 'U':
                                var escapeEnd = p.IndexOf('}', i + 2) + 1;
                                yield return p[i..escapeEnd];
                                i = escapeEnd;
                                continue;
                                break;
                            default:
                                yield return p[i..(i + 2)];
                                i += 2;
                                break;
                                break;
                        }
                    }
                    else if (char.IsHighSurrogate(p[i]))
                    {
                        yield return p[i..(MutateCSharp.Schemata319.ReplaceBinExprOp_12(352L, i, MutateCSharp.Schemata319.ReplaceNumericConstant_0(348L, 2)))];
                        i += MutateCSharp.Schemata319.ReplaceNumericConstant_0(361L, 2);
                    }
                    else
                    {
                        yield return p[i].ToString();
                        MutateCSharp.Schemata319.ReplacePostfixUnaryExprOp_4(365L, ref i);
                    }
                }
            }

            yield break;
        }

        /// <summary>
        /// Converts a hexadecimal digit to an integer.
        /// Assumes ch does represent a hexadecimal digit; alphabetic digits can be in either case.
        /// </summary>
        public static int HexValue(char ch)
        {
            if (MutateCSharp.Schemata319.ReplaceBinExprOp_14(376L, () => MutateCSharp.Schemata319.ReplaceBinExprOp_13(366L, 'a', ch), () => MutateCSharp.Schemata319.ReplaceBinExprOp_13(371L, ch, 'f')))
            {
                return MutateCSharp.Schemata319.ReplaceBinExprOp_12(395L, MutateCSharp.Schemata319.ReplaceBinExprOp_7(382L, ch, 'a'), MutateCSharp.Schemata319.ReplaceNumericConstant_0(391L, 10));
            }
            else if (MutateCSharp.Schemata319.ReplaceBinExprOp_14(414L, () => MutateCSharp.Schemata319.ReplaceBinExprOp_13(404L, 'A', ch), () => MutateCSharp.Schemata319.ReplaceBinExprOp_13(409L, ch, 'F')))
            {
                return MutateCSharp.Schemata319.ReplaceBinExprOp_12(433L, MutateCSharp.Schemata319.ReplaceBinExprOp_7(420L, ch, 'A'), MutateCSharp.Schemata319.ReplaceNumericConstant_0(429L, 10));
            }
            else
            {
                return MutateCSharp.Schemata319.ReplaceBinExprOp_7(442L, ch, '0');
            }

            return default;
        }

        /// <summary>
        /// Add "fe" to "mod", if "performThisDeprecationCheck" is "false".
        /// Otherwise, first strip "fe" of certain easy occurrences of "this", and for each one giving a warning about
        /// that "this" is deprecated in modifies clauses of constructors.
        /// This method may modify "fe" and the subexpressions contained within "fe".
        /// </summary>
        public static void AddFrameExpression(List<FrameExpression> mod, FrameExpression fe, bool performThisDeprecationCheck, Errors errors)
        {
            Contract.Requires(mod != null);
            Contract.Requires(fe != null);
            Contract.Requires(errors != null);
            if (performThisDeprecationCheck)
            {
                if (fe.E is ThisExpr)
                {
                    errors.Deprecated(ErrorId.g_deprecated_this_in_constructor_modifies_clause, fe.E.tok, MutateCSharp.Schemata319.ReplaceStringConstant_3(451L, "constructors no longer need 'this' to be listed in modifies clauses"));
                    return;
                }
                else if (fe.E is SetDisplayExpr)
                {
                    var s = (SetDisplayExpr)fe.E;
                    var deprecated = s.Elements.FindAll(e => e is ThisExpr);
                    if (MutateCSharp.Schemata319.ReplaceBinExprOp_2(456L, deprecated.Count, MutateCSharp.Schemata319.ReplaceNumericConstant_0(452L, 0)))
                    {
                        foreach (var e in deprecated)
                        {
                            errors.Deprecated(ErrorId.g_deprecated_this_in_constructor_modifies_clause, e.tok, MutateCSharp.Schemata319.ReplaceStringConstant_3(461L, "constructors no longer need 'this' to be listed in modifies clauses"));
                        }
                        s.Elements.RemoveAll(e => e is ThisExpr);
                        if (MutateCSharp.Schemata319.ReplaceBinExprOp_6(466L, s.Elements.Count, MutateCSharp.Schemata319.ReplaceNumericConstant_0(462L, 0)))
                        {
                            return;
                        }
                    }
                }
            }
            mod.Add(fe);
        }

        public
            /// <summary>
            /// Class dedicated to traversing the function call graph
            /// </summary>
            class FunctionCallFinder : TopDownVisitor<List<Function>>
        {
            protected override bool VisitOneExpr(Expression expr, ref List<Function> calls)
            {
                if (expr is FunctionCallExpr)
                {
                    calls.Add(((FunctionCallExpr)expr).Function);
                }
                return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(471L, true);
            }
        }

        static Graph<Function> BuildFunctionCallGraph(Dafny.Program program)
        {
            Graph<Function> functionCallGraph = new Graph<Function>();
            FunctionCallFinder callFinder = new FunctionCallFinder();

            foreach (var module in program.Modules())
            {
                foreach (var decl in module.TopLevelDecls)
                {
                    if (decl is TopLevelDeclWithMembers c)
                    {
                        foreach (var member in c.Members)
                        {
                            if (member is Function f)
                            {
                                List<Function> calls = new List<Function>();
                                foreach (var e in f.Reads.Expressions) { if (MutateCSharp.Schemata319.ReplaceBinExprOp_14(474L, () => MutateCSharp.Schemata319.ReplaceBinExprOp_15(472L, e, null), () => MutateCSharp.Schemata319.ReplaceBinExprOp_16(473L, e.E, null))) { callFinder.Visit(e.E, calls); } }
                                foreach (var e in f.Req) { if (MutateCSharp.Schemata319.ReplaceBinExprOp_17(480L, e, null)) { callFinder.Visit(e, calls); } }
                                foreach (var e in f.Ens) { if (MutateCSharp.Schemata319.ReplaceBinExprOp_17(481L, e, null)) { callFinder.Visit(e, calls); } }
                                if (MutateCSharp.Schemata319.ReplaceBinExprOp_16(482L, f.Body, null))
                                {
                                    callFinder.Visit(f.Body, calls);
                                }

                                foreach (var callee in calls)
                                {
                                    functionCallGraph.AddEdge(f, callee);
                                }
                            }
                        }
                    }
                }
            }

            return functionCallGraph;
        }

        /// <summary>
        /// Prints the program's function call graph in a format suitable for consumption in other tools
        /// </summary>
        public static void PrintFunctionCallGraph(Dafny.Program program)
        {
            var functionCallGraph = BuildFunctionCallGraph(program);

            foreach (var vertex in functionCallGraph.GetVertices())
            {
                var func = vertex.N;
                program.Options.OutputWriter.Write(MutateCSharp.Schemata319.ReplaceStringConstant_3(483L, "{0},{1}="), func.SanitizedName, func.EnclosingClass.EnclosingModuleDefinition.SanitizedName);
                foreach (var callee in vertex.Successors)
                {
                    program.Options.OutputWriter.Write(MutateCSharp.Schemata319.ReplaceStringConstant_3(484L, "{0} "), callee.N.SanitizedName);
                }
                program.Options.OutputWriter.Write(MutateCSharp.Schemata319.ReplaceStringConstant_3(485L, "\n"));
            }
        }

        public static V GetOrDefault<K, V, V2>(this IReadOnlyDictionary<K, V2> dictionary, K key, Func<V> createValue)
          where V2 : V
        {
            if (dictionary.TryGetValue(key, out var result))
            {
                return result;
            }

            return createValue();
        }

        public static Action<T> Concat<T>(Action<T> first, Action<T> second)
        {
            return v =>
            {
                first(v);
                second(v);
            };
        }

        public static V AddOrUpdate<K, V>(this IDictionary<K, V> dictionary, K key, V newValue, Func<V, V, V> update)
        {
            if (dictionary.TryGetValue(key, out var existingValue))
            {
                var updated = update(existingValue, newValue);
                dictionary[key] = updated;
                return updated;
            }

            dictionary[key] = newValue;
            return newValue;
        }

        public static V GetOrCreate<K, V>(this IDictionary<K, V> dictionary, K key, Func<V> createValue)
        {
            if (dictionary.TryGetValue(key, out var result))
            {
                return result;
            }

            result = createValue();
            dictionary[key] = result;
            return result;
        }

        /// <summary>
        /// Generic statistic counter
        /// </summary>
        static void IncrementStat(IDictionary<string, ulong> stats, string stat)
        {
            if (stats.TryGetValue(stat, out var currentValue))
            {
                stats[stat] += MutateCSharp.Schemata319.ReplaceNumericConstant_18(486L, 1);
            }
            else
            {
                stats.Add(stat, MutateCSharp.Schemata319.ReplaceNumericConstant_18(489L, 1));
            }
        }

        /// <summary>
        /// Track the maximum value of some statistic
        /// </summary>
        static void UpdateMax(IDictionary<string, ulong> stats, string stat, ulong val)
        {
            if (stats.TryGetValue(stat, out var currentValue))
            {
                if (MutateCSharp.Schemata319.ReplaceBinExprOp_19(492L, val, currentValue))
                {
                    stats[stat] = val;
                }
            }
            else
            {
                stats.Add(stat, val);
            }
        }

        /// <summary>
        /// Compute various interesting statistics about the Dafny program
        /// </summary>
        public static void PrintStats(Dafny.Program program)
        {
            SortedDictionary<string, ulong> stats = new SortedDictionary<string, ulong>();

            foreach (var module in program.Modules())
            {
                IncrementStat(stats, MutateCSharp.Schemata319.ReplaceStringConstant_3(497L, "Modules"));
                UpdateMax(stats, MutateCSharp.Schemata319.ReplaceStringConstant_3(498L, "Module height (max)"), (ulong)module.Height);

                ulong num_scc = (ulong)module.CallGraph.TopologicallySortedComponents().Count;
                UpdateMax(stats, MutateCSharp.Schemata319.ReplaceStringConstant_3(499L, "Call graph width (max)"), num_scc);

                foreach (var decl in module.TopLevelDecls)
                {
                    if (decl is DatatypeDecl)
                    {
                        IncrementStat(stats, MutateCSharp.Schemata319.ReplaceStringConstant_3(500L, "Datatypes"));
                    }
                    else if (decl is ClassLikeDecl)
                    {
                        var c = (ClassLikeDecl)decl;
                        if (MutateCSharp.Schemata319.ReplaceBinExprOp_20(502L, c.Name, MutateCSharp.Schemata319.ReplaceStringConstant_3(501L, "_default")))
                        {
                            IncrementStat(stats, MutateCSharp.Schemata319.ReplaceStringConstant_3(503L, "Classes"));
                        }

                        foreach (var member in c.Members)
                        {
                            if (member is Function)
                            {
                                IncrementStat(stats, MutateCSharp.Schemata319.ReplaceStringConstant_3(504L, "Functions (total)"));
                                var f = (Function)member;
                                if (f.IsRecursive)
                                {
                                    IncrementStat(stats, MutateCSharp.Schemata319.ReplaceStringConstant_3(505L, "Functions recursive"));
                                }
                            }
                            else if (member is Method)
                            {
                                IncrementStat(stats, MutateCSharp.Schemata319.ReplaceStringConstant_3(506L, "Methods (total)"));
                                var method = (Method)member;
                                if (method.IsRecursive)
                                {
                                    IncrementStat(stats, MutateCSharp.Schemata319.ReplaceStringConstant_3(507L, "Methods recursive"));
                                }
                                if (method.IsGhost)
                                {
                                    IncrementStat(stats, MutateCSharp.Schemata319.ReplaceStringConstant_3(508L, "Methods ghost"));
                                }
                            }
                        }
                    }
                }
            }

            // Print out the results, with some nice formatting
            program.Options.OutputWriter.WriteLine("");
            program.Options.OutputWriter.WriteLine(MutateCSharp.Schemata319.ReplaceStringConstant_3(509L, "Statistics"));
            program.Options.OutputWriter.WriteLine(MutateCSharp.Schemata319.ReplaceStringConstant_3(510L, "----------"));

            int max_key_length = MutateCSharp.Schemata319.ReplaceNumericConstant_0(511L, 0);
            foreach (var key in stats.Keys)
            {
                if (MutateCSharp.Schemata319.ReplaceBinExprOp_1(515L, key.Length, max_key_length))
                {
                    max_key_length = key.Length;
                }
            }

            foreach (var keypair in stats)
            {
                string keyString = keypair.Key.PadRight(MutateCSharp.Schemata319.ReplaceBinExprOp_12(524L, max_key_length, MutateCSharp.Schemata319.ReplaceNumericConstant_0(520L, 2)));
                program.Options.OutputWriter.WriteLine(MutateCSharp.Schemata319.ReplaceStringConstant_3(533L, "{0} {1,4}"), keyString, keypair.Value);
            }
        }

        public static IEnumerable<string> Lines(TextReader reader)
        {
            return new LinesEnumerable(reader);
        }
    }

    public class DependencyMap
    {
        private Dictionary<string, SortedSet<string>> dependencies;

        public DependencyMap()
        {
            dependencies = new Dictionary<string, SortedSet<string>>();
        }

        public void AddInclude(Include include)
        {
            SortedSet<string> existingDependencies = null;
            string key = include.IncluderFilename.LocalPath ?? MutateCSharp.Schemata319.ReplaceStringConstant_3(534L, "roots");
            bool found = dependencies.TryGetValue(key, out existingDependencies);
            if (found)
            {
                existingDependencies.Add(include.CanonicalPath);
            }
            else
            {
                dependencies[key] = new SortedSet<string>() { include.CanonicalPath };
            }
        }

        public void AddIncludes(IEnumerable<Include> includes)
        {
            // Reconstruct the dependency map
            Dictionary<string, List<string>> dependencies = new Dictionary<string, List<string>>();
            foreach (Include include in includes)
            {
                AddInclude(include);
            }
        }

        public void PrintMap(DafnyOptions options)
        {
            SortedSet<string> leaves = new SortedSet<string>(); // Files that don't themselves include any files
            foreach (string target in dependencies.Keys)
            {
                options.OutputWriter.Write(target);
                foreach (string dependency in dependencies[target])
                {
                    options.OutputWriter.Write(MutateCSharp.Schemata319.ReplaceStringConstant_3(535L, ";") + dependency);
                    if (!dependencies.ContainsKey(dependency))
                    {
                        leaves.Add(dependency);
                    }
                }
                options.OutputWriter.WriteLine();
            }
            foreach (string leaf in leaves)
            {
                options.OutputWriter.WriteLine(leaf);
            }
        }
    }

    public
      class IEnumerableComparer<T> : IEqualityComparer<IEnumerable<T>>
    {
        public bool Equals(IEnumerable<T> x, IEnumerable<T> y)
        {
            return x.SequenceEqual(y);
        }

        public int GetHashCode(IEnumerable<T> obj)
        {
            var hash = new HashCode();
            foreach (T t in obj)
            {
                hash.Add(t);
            }
            return hash.ToHashCode();
        }
    }

    // Class to traverse a program top-down, especially aimed at identifying expressions and statements,
    // and in their context
    // How to use:
    // - Define a subclass of ProgramTraverser
    // - Implement the methods (TopDown|BottomUp)(Enter|Exit), override Traverse if needed.
    // - Call any Traverse() method.
    public class ProgramTraverser
    {
        public enum ContinuationStatus
        {
            Ok,    // Continue exploration
            Skip,  // Skip this node and its descendants  (valid only on entering a node)
            Stop,  // Stop the entire traversal here, but traverse ancestors in bottom-up
        }
        protected const ContinuationStatus ok = ContinuationStatus.Ok;
        protected const ContinuationStatus skip = ContinuationStatus.Skip;
        protected const ContinuationStatus stop = ContinuationStatus.Stop;
        // Returns true if statement needs to be traversed
        protected virtual ContinuationStatus OnEnter(Statement stmt, [CanBeNull] string field, [CanBeNull] object parent)
        {
            return ok;
        }
        // Returns true if expression needs to be traversed
        protected virtual ContinuationStatus OnEnter(Expression expr, [CanBeNull] string field, [CanBeNull] object parent)
        {
            return ok;
        }

        // Returns true if need to stop the traversal entirely
        protected virtual bool OnExit(Statement stmt, [CanBeNull] string field, [CanBeNull] object parent)
        {
            return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(536L, false);
        }
        // Returns true if need to stop the traversal entirely
        protected virtual bool OnExit(Expression expr, [CanBeNull] string field, [CanBeNull] object parent)
        {
            return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(537L, false);
        }

        protected virtual ContinuationStatus OnEnter(MemberDecl memberDecl, [CanBeNull] string field, [CanBeNull] object parent)
        {
            return ok;
        }

        // Traverse methods retun true to interrupt.
        public bool Traverse(Program program)
        {
            if (MutateCSharp.Schemata319.ReplaceBinExprOp_21(538L, program, null))
            {
                return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(539L, false);
            }

            return program.Modules().Any(Traverse);
        }

        public bool Traverse(ModuleDefinition moduleDefinition)
        {
            if (MutateCSharp.Schemata319.ReplaceBinExprOp_22(540L, moduleDefinition, null))
            {
                return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(541L, false);
            }

            return Traverse(moduleDefinition.TopLevelDecls);
        }

        public bool Traverse(IEnumerable<TopLevelDecl> topLevelDecls)
        {
            if (MutateCSharp.Schemata319.ReplaceBinExprOp_23(542L, topLevelDecls, null))
            {
                return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(543L, false);
            }

            foreach (var topLevelDecl in topLevelDecls)
            {
                if (Traverse(topLevelDecl))
                {
                    return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(544L, true);
                }
            }

            return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(545L, false);
        }

        public bool Traverse(ModuleDecl moduleDecl)
        {
            if (MutateCSharp.Schemata319.ReplaceBinExprOp_24(546L, moduleDecl, null))
            {
                return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(547L, false);
            }

            if (moduleDecl is LiteralModuleDecl l)
            {
                return Traverse(l.ModuleDef);
            }
            else if (moduleDecl is AbstractModuleDecl a)
            {
                return Traverse(a.CompileRoot);
            }/* else if (moduleDecl is AliasModuleDecl a) {
        
      } else if (moduleDecl is ModuleExportDecl m) {
        
      }*/

            return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(548L, false);
        }

        public bool Traverse(Formal formal)
        {
            if (MutateCSharp.Schemata319.ReplaceBinExprOp_25(549L, formal, null))
            {
                return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(550L, false);
            }

            if (MutateCSharp.Schemata319.ReplaceBinExprOp_14(553L, () => MutateCSharp.Schemata319.ReplaceBinExprOp_16(551L, formal.DefaultValue, null), () => Traverse(formal.DefaultValue, MutateCSharp.Schemata319.ReplaceStringConstant_3(552L, "DefaultValue"), formal)))
            {
                return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(559L, true);
            }

            return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(560L, false);
        }

        public bool Traverse(DatatypeCtor ctor)
        {
            if (MutateCSharp.Schemata319.ReplaceBinExprOp_26(561L, ctor, null))
            {
                return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(562L, false);
            }

            if (ctor.Formals.Any(Traverse))
            {
                return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(563L, true);
            }

            return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(564L, false);
        }

        public bool Traverse(TopLevelDecl topd)
        {
            if (MutateCSharp.Schemata319.ReplaceBinExprOp_27(565L, topd, null))
            {
                return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(566L, false);
            }

            var d = topd is ClassLikeDecl classDecl && MutateCSharp.Schemata319.ReplaceBinExprOp_28(567L, classDecl.NonNullTypeDecl, null) ? classDecl.NonNullTypeDecl : topd;

            if (d is TopLevelDeclWithMembers tdm)
            {
                // ClassDecl, DatatypeDecl, AbstractTypeDecl, NewtypeDecl 
                if (tdm.Members.Any(memberDecl => Traverse(memberDecl, MutateCSharp.Schemata319.ReplaceStringConstant_3(568L, "Members"), tdm)))
                {
                    return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(569L, true);
                }

                if (tdm is IteratorDecl iter)
                {
                    // TODO: Import this
                    if (Attributes.SubExpressions(iter.Attributes).Any(e => Traverse(e, MutateCSharp.Schemata319.ReplaceStringConstant_3(570L, "Attributes.SubExpressions"), iter)))
                    {
                        return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(571L, true);
                    }
                    if (Attributes.SubExpressions(iter.Reads.Attributes).Any(e => Traverse(e, MutateCSharp.Schemata319.ReplaceStringConstant_3(572L, "Reads.Attributes.SubExpressions"), iter)))
                    {
                        return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(573L, true);
                    }
                    if (iter.Reads.Expressions.Any(e => Traverse(e.E, MutateCSharp.Schemata319.ReplaceStringConstant_3(574L, "Reads.Expressions.E"), iter)))
                    {
                        return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(575L, true);
                    }
                    if (Attributes.SubExpressions(iter.Modifies.Attributes).Any(e => Traverse(e, MutateCSharp.Schemata319.ReplaceStringConstant_3(576L, "Modifies.Attributes.SubExpressions"), iter)))
                    {
                        return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(577L, true);
                    }
                    if (iter.Modifies.Expressions.Any(e => Traverse(e.E, MutateCSharp.Schemata319.ReplaceStringConstant_3(578L, "Modifies.Expressions.E"), iter)))
                    {
                        return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(579L, true);
                    }
                    if (Attributes.SubExpressions(iter.Decreases.Attributes).Any(e => Traverse(e, MutateCSharp.Schemata319.ReplaceStringConstant_3(580L, "Decreases.Attributes.SubExpressions"), iter)))
                    {
                        return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(581L, true);
                    }
                    if (iter.Decreases.Expressions.Any(e => Traverse(e, MutateCSharp.Schemata319.ReplaceStringConstant_3(582L, "Decreases.Expressions.E"), iter)))
                    {
                        return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(583L, true);
                    }
                    if (iter.Requires.Any(e => Traverse(e.E, MutateCSharp.Schemata319.ReplaceStringConstant_3(584L, "Requires.E"), iter)))
                    {
                        return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(585L, true);
                    }
                    if (iter.Ensures.Any(e => Traverse(e.E, MutateCSharp.Schemata319.ReplaceStringConstant_3(586L, "Ensures.E"), iter)))
                    {
                        return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(587L, true);
                    }
                    if (iter.YieldRequires.Any(e => Traverse(e.E, MutateCSharp.Schemata319.ReplaceStringConstant_3(588L, "YieldRequires.E"), iter)))
                    {
                        return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(589L, true);
                    }
                    if (iter.YieldEnsures.Any(e => Traverse(e.E, MutateCSharp.Schemata319.ReplaceStringConstant_3(590L, "YieldEnsures.E"), iter)))
                    {
                        return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(591L, true);
                    }
                    if (Traverse(iter.Body, MutateCSharp.Schemata319.ReplaceStringConstant_3(592L, "Body"), iter))
                    {
                        return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(593L, true);
                    }
                }

                if (tdm is DatatypeDecl dtd)
                {
                    if (dtd.Ctors.Any(Traverse))
                    {
                        return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(594L, true);
                    }
                }
            }
            else if (d is ModuleDecl md)
            {
                return Traverse(md);
            }
            else if (d is TypeSynonymDecl tsd)
            {
                // Nothing here.
            }

            return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(595L, false);
        }

        public bool Traverse(MemberDecl memberDeclaration, [CanBeNull] string field, [CanBeNull] object parent)
        {
            if (MutateCSharp.Schemata319.ReplaceBinExprOp_29(596L, memberDeclaration, null))
            {
                return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(597L, false);
            }

            var enterResult = OnEnter(memberDeclaration, field, parent);
            if (enterResult is stop or skip)
            {
                return MutateCSharp.Schemata319.ReplaceBinExprOp_30(598L, enterResult, stop);
            }

            if (memberDeclaration is Field fi)
            {
                if (fi.SubExpressions.Any(expr => Traverse(expr, MutateCSharp.Schemata319.ReplaceStringConstant_3(599L, "SubExpressions"), fi)))
                {
                    return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(600L, true);
                }
            }
            else if (memberDeclaration is Function f)
            {
                if (f.Ins.Any(Traverse))
                {
                    return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(601L, true);
                }
                if (MutateCSharp.Schemata319.ReplaceBinExprOp_14(611L, () => MutateCSharp.Schemata319.ReplaceBinExprOp_14(604L, () => MutateCSharp.Schemata319.ReplaceBinExprOp_31(602L, f.Result, null), () => MutateCSharp.Schemata319.ReplaceBinExprOp_16(603L, f.Result.DefaultValue, null)), () => Traverse(f.Result.DefaultValue, MutateCSharp.Schemata319.ReplaceStringConstant_3(610L, "Result.DefaultValue"), f)))
                {
                    return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(617L, true);
                }
                if (f.Req.Any(e => Traverse(e.E, MutateCSharp.Schemata319.ReplaceStringConstant_3(618L, "Req.E"), f)))
                {
                    return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(619L, true);
                }
                if (f.Reads.Expressions.Any(e => Traverse(e.E, MutateCSharp.Schemata319.ReplaceStringConstant_3(620L, "Reads.E"), f)))
                {
                    return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(621L, true);
                }
                if (f.Ens.Any(e => Traverse(e.E, MutateCSharp.Schemata319.ReplaceStringConstant_3(622L, "Ens.E"), f)))
                {
                    return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(623L, true);
                }
                if (f.Decreases.Expressions.Any(e => Traverse(e, MutateCSharp.Schemata319.ReplaceStringConstant_3(624L, "Decreases.Expressions"), f)))
                {
                    return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(625L, true);
                }
                if (Traverse(f.Body, MutateCSharp.Schemata319.ReplaceStringConstant_3(626L, "Body"), f))
                {
                    return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(627L, true);
                }

                if (MutateCSharp.Schemata319.ReplaceBinExprOp_14(630L, () => MutateCSharp.Schemata319.ReplaceBinExprOp_32(628L, f.ByMethodDecl, null), () => Traverse(f.ByMethodDecl, MutateCSharp.Schemata319.ReplaceStringConstant_3(629L, "ByMethodDecl"), f)))
                {
                    return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(636L, true);
                }

                if (MutateCSharp.Schemata319.ReplaceBinExprOp_10(639L, () => MutateCSharp.Schemata319.ReplaceBinExprOp_33(637L, f.ByMethodDecl, null), () => MutateCSharp.Schemata319.ReplaceBinExprOp_34(638L, f.ByMethodDecl.Body, f.ByMethodBody)))
                {
                    if (MutateCSharp.Schemata319.ReplaceBinExprOp_14(647L, () => MutateCSharp.Schemata319.ReplaceBinExprOp_35(645L, f.ByMethodBody, null), () => Traverse(f.ByMethodBody, MutateCSharp.Schemata319.ReplaceStringConstant_3(646L, "ByMethodBody"), f)))
                    {
                        return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(653L, true);
                    }
                }
            }
            else if (memberDeclaration is Method m)
            {
                // For example, default value of formals is non-ghost
                if (m.Ins.Any(formal => MutateCSharp.Schemata319.ReplaceBinExprOp_14(656L, () => MutateCSharp.Schemata319.ReplaceBinExprOp_16(654L, formal.DefaultValue, null
        ), () => Traverse(formal.DefaultValue, MutateCSharp.Schemata319.ReplaceStringConstant_3(655L, "Ins.DefaultValue"), m))))
                {
                    return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(662L, true);
                }
                if (m.Req.Any(e => Traverse(e.E, MutateCSharp.Schemata319.ReplaceStringConstant_3(663L, "Req.E"), m)))
                {
                    return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(664L, true);
                }
                if (m.Reads.Expressions.Any(e => Traverse(e.E, MutateCSharp.Schemata319.ReplaceStringConstant_3(665L, "Reads.E"), m)))
                {
                    return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(666L, true);
                }
                if (m.Mod.Expressions.Any(e => MutateCSharp.Schemata319.ReplaceBinExprOp_36(669L, () => Traverse(e.E, MutateCSharp.Schemata319.ReplaceStringConstant_3(667L, "Mod.E"), m), () => MutateCSharp.Schemata319.ReplaceBooleanConstant_8(668L, true))))
                {
                    return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(675L, true);
                }
                if (m.Ens.Any(e => Traverse(e.E, MutateCSharp.Schemata319.ReplaceStringConstant_3(676L, "Ens.E"), m)))
                {
                    return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(677L, true);
                }
                if (m.Decreases.Expressions.Any(e => Traverse(e, MutateCSharp.Schemata319.ReplaceStringConstant_3(678L, "Decreases.Expressions"), m)))
                {
                    return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(679L, true);
                }
                if (Traverse(m.Body, MutateCSharp.Schemata319.ReplaceStringConstant_3(680L, "Body"), m))
                {
                    return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(681L, true);
                }
            }

            return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(682L, false);
        }

        public virtual bool Traverse(Statement stmt, [CanBeNull] string field, [CanBeNull] object parent)
        {
            if (MutateCSharp.Schemata319.ReplaceBinExprOp_37(683L, stmt, null))
            {
                return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(684L, false);
            }

            var enterResult = OnEnter(stmt, field, parent);
            if (enterResult is stop or skip)
            {
                return MutateCSharp.Schemata319.ReplaceBinExprOp_30(685L, enterResult, stop);
            }

            return MutateCSharp.Schemata319.ReplaceBinExprOp_10(701L, () => MutateCSharp.Schemata319.ReplaceBinExprOp_10(695L, () => MutateCSharp.Schemata319.ReplaceBinExprOp_10(688L, () => stmt.NonSpecificationSubExpressions.Any(subExpr => Traverse(subExpr, MutateCSharp.Schemata319.ReplaceStringConstant_3(686L, "NonSpecificationSubExpressions"), stmt)), () => stmt.SpecificationSubExpressions.Any(subExpr => Traverse(subExpr, MutateCSharp.Schemata319.ReplaceStringConstant_3(687L, "SpecificationSubExpressions"), stmt))), () => stmt.SubStatements.Any(subStmt => Traverse(subStmt, MutateCSharp.Schemata319.ReplaceStringConstant_3(694L, "SubStatements"), stmt))), () => OnExit(stmt, field, parent));
        }

        public virtual bool Traverse(Expression expr, [CanBeNull] string field, [CanBeNull] object parent)
        {
            if (MutateCSharp.Schemata319.ReplaceBinExprOp_38(707L, expr, null))
            {
                return MutateCSharp.Schemata319.ReplaceBooleanConstant_8(708L, false);
            }

            var enterResult = OnEnter(expr, field, parent);
            if (enterResult is stop or skip)
            {
                return MutateCSharp.Schemata319.ReplaceBinExprOp_30(709L, enterResult, stop);
            }

            return MutateCSharp.Schemata319.ReplaceBinExprOp_10(711L, () => expr.SubExpressions.Any(subExpr => Traverse(subExpr, MutateCSharp.Schemata319.ReplaceStringConstant_3(710L, "SubExpression"), expr)), () => OnExit(expr, field, parent));
        }
    }

    public
      class LinesEnumerable : IEnumerable<string>
    {
        private readonly TextReader Reader;

        public LinesEnumerable(TextReader reader)
        {
            Reader = reader;
        }

        public IEnumerator<string> GetEnumerator()
        {
            return new LinesEnumerator(Reader);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public
      class LinesEnumerator : IEnumerator<string>
    {

        private readonly TextReader Reader;

        public LinesEnumerator(TextReader reader)
        {
            Reader = reader;
        }

        public bool MoveNext()
        {
            Current = Reader.ReadLine();
            return Current != null;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public string Current { get; internal set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}
