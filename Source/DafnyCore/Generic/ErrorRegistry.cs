// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT

using System;
using System.Collections.Generic;
namespace MutateCSharp
{
    internal class Schemata305
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT305");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static string ReplaceStringConstant_3(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.IToken argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, Microsoft.Dafny.ActionSignature argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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
    public record DafnyPosition(int Line, int Column) : IComparable<DafnyPosition>
    {
        public int CompareTo(DafnyPosition other)
        {
            var lineComparison = Line.CompareTo(other.Line);
            if (MutateCSharp.Schemata305.ReplaceBinExprOp_1(5L, lineComparison, MutateCSharp.Schemata305.ReplaceNumericConstant_0(1L, 0)))
            {
                return lineComparison;
            }

            return Column.CompareTo(other.Column);
        }
    }

    public record DafnyRange(DafnyPosition Start, DafnyPosition ExclusiveEnd)
    {
        public bool Contains(DafnyPosition position)
        {
            return MutateCSharp.Schemata305.ReplaceBinExprOp_2(10L, () => Start.LessThanOrEquals(position), () => position.LessThanOrEquals(ExclusiveEnd));
        }
    }

    /// <summary>
    /// A quick fix replaces a range with the replacing text.
    /// </summary>
    /// <param name="Range">The range to replace. The start is given by the token's start, and the length is given by the val's length.</param>
    /// <param name="Replacement"></param>
    public record DafnyCodeActionEdit(DafnyRange Range, string Replacement = "")
    {
        public DafnyCodeActionEdit(RangeToken rangeToken, string replacement = "", bool includeTrailingWhitespace = false)
          : this(rangeToken.ToDafnyRange(includeTrailingWhitespace), replacement)
        {
        }
    }


    public delegate List<DafnyAction> ActionSignature(RangeToken range);
    public delegate bool TokenPredicate(IToken token);

    public record DafnyAction(string Title, IReadOnlyList<DafnyCodeActionEdit> Edits);

    public static class ErrorRegistry
    {

        // Replace any NoneId by ParseErrors.p_... or ResolutionErrors.r_
        public static string NoneId => MutateCSharp.Schemata305.ReplaceStringConstant_3(16L, "none");
#nullable enable
        public static List<ActionSignature>? GetAction(string? errorId)
        {
            return errorId != null && codeActionMap.TryGetValue(errorId, out var value) ? new List<ActionSignature> { value } : null;
        }
#nullable disable

        public static ActionSignature InsertAfter(string newContent, string title)
        {
            return range => InsertAction(title, range, newContent);
        }

        public static ActionSignature InsertBefore(string newContent)
        {
            return range => ReplacementAction(MutateCSharp.Schemata305.ReplaceStringConstant_3(17L, "insert '") + newContent + MutateCSharp.Schemata305.ReplaceStringConstant_3(18L, "'"), range, newContent + range.PrintOriginal());
        }

        public static ActionSignature Replace(string newContent, string overrideTitle = null)
        {
            if (overrideTitle == null)
            {
                return range => ReplacementAction(MutateCSharp.Schemata305.ReplaceStringConstant_3(19L, "replace '") + range.PrintOriginal() + MutateCSharp.Schemata305.ReplaceStringConstant_3(20L, "' with '") + newContent + MutateCSharp.Schemata305.ReplaceStringConstant_3(21L, "'"), range, newContent);
            }
            return range => ReplacementAction(overrideTitle, range, newContent);
        }


        public static DafnyCodeActionEdit[] OneEdit(RangeToken range, string newContent, bool includeTrailingWhitespace = false)
        {
            return new[] { new DafnyCodeActionEdit(range, newContent, includeTrailingWhitespace) };
        }

        public static DafnyAction OneAction(string title, RangeToken range, string newContent, bool includeTrailingWhitespace = false)
        {
            return new(title, new[] { new DafnyCodeActionEdit(range, newContent, includeTrailingWhitespace) });
        }

        public static RangeToken IncludeComma(RangeToken range)
        {
            if (MutateCSharp.Schemata305.ReplaceBinExprOp_4(23L, range.EndToken.Next.val, MutateCSharp.Schemata305.ReplaceStringConstant_3(22L, ",")))
            {
                return new RangeToken(range.StartToken, range.EndToken.Next);
            }
            if (MutateCSharp.Schemata305.ReplaceBinExprOp_4(25L, range.StartToken.Prev.val, MutateCSharp.Schemata305.ReplaceStringConstant_3(24L, ",")))
            {
                return new RangeToken(range.StartToken.Prev, range.EndToken);
            }
            return range;
        }

        public static RangeToken ExpandStart(RangeToken range, TokenPredicate pred, bool include)
        {
            var t = range.StartToken;
            IToken p = null;
            while (!pred(t))
            {
                p = t;
                t = t.Prev;
                if (MutateCSharp.Schemata305.ReplaceBinExprOp_5(26L, t, null))
                {
                    return range;
                }
            }
            return new RangeToken(include ? t : p, range.EndToken);
        }

        public static RangeToken ExpandEnd(RangeToken range, TokenPredicate pred, bool include)
        {
            var t = range.EndToken;
            IToken p = null;
            while (!pred(t))
            {
                p = t;
                t = t.Prev;
                if (MutateCSharp.Schemata305.ReplaceBinExprOp_5(27L, t, null))
                {
                    return range;
                }
            }
            return new RangeToken(range.StartToken, include ? t : p);
        }

        public static ActionSignature Replacements(IEnumerable<(string NewContent, string Title)> replacements)
        {
            return range =>
            {
                var actions = new List<DafnyAction>();
                foreach (var replacement in replacements)
                {
                    var edit = new[] { new DafnyCodeActionEdit(range, replacement.NewContent) };
                    var action = new DafnyAction(replacement.Title, edit);
                    actions.Add(action);
                }

                return actions;
            };
        }

        /// <summary>
        /// Default title is "remove'X'" where X is the content of the range
        /// </summary>
        public static ActionSignature Remove(bool removeTrailingSpaces, string overrideTitle = null)
        {
            if (overrideTitle == null)
            {
                return range => RemoveAction(range, removeTrailingSpaces);
            }

            return range => RemoveAction(overrideTitle, range, removeTrailingSpaces);
        }


        /// <summary>
        /// Maps an errorID (error code) to a code action and explanatory text (which could be moderately lengthy)
        /// </summary>
        private static readonly Dictionary<string, string> errorDetailMap = new();
        private static Dictionary<string, ActionSignature> codeActionMap = new();

        public static void Add(object errorId, string detail, ActionSignature codeAction = null)
        {
            errorDetailMap.Add(errorId.ToString()!, detail);
            if (MutateCSharp.Schemata305.ReplaceBinExprOp_6(28L, codeAction, null))
            {
                codeActionMap.Add(errorId.ToString()!, codeAction);
            }
        }

        private static List<DafnyAction> ReplacementAction(string title, RangeToken range, string newText)
        {
            var edit = new[] { new DafnyCodeActionEdit(range, newText) };
            var action = new DafnyAction(title, edit);
            return new List<DafnyAction> { action };
        }

        private static List<DafnyAction> ReplacementAction(RangeToken range, string newText)
        {
            string toBeReplaced = range.PrintOriginal();
            string title = MutateCSharp.Schemata305.ReplaceStringConstant_3(29L, "replace '") + toBeReplaced + MutateCSharp.Schemata305.ReplaceStringConstant_3(30L, "' with '") + newText + MutateCSharp.Schemata305.ReplaceStringConstant_3(31L, "'");
            return ReplacementAction(title, range, newText);
        }

        private static List<DafnyAction> InsertAction(string title, RangeToken range, string newText)
        {
            var edits = new[] { new DafnyCodeActionEdit(range, range.PrintOriginal() + newText) };
            var action = new DafnyAction(title, edits);
            return new List<DafnyAction> { action };
        }

        private static List<DafnyAction> RemoveAction(string title, RangeToken range, bool includeTrailingSpaces)
        {
            var edit = new[] { new DafnyCodeActionEdit(range, "", includeTrailingSpaces) };
            var action = new DafnyAction(title, edit);
            return new List<DafnyAction> { action };
        }

        private static List<DafnyAction> RemoveAction(RangeToken range, bool includeTrailingSpaces)
        {
            string toBeRemoved = range.PrintOriginal();
            string title = MutateCSharp.Schemata305.ReplaceStringConstant_3(32L, "remove '") + toBeRemoved + MutateCSharp.Schemata305.ReplaceStringConstant_3(33L, "'");
            return RemoveAction(title, range, includeTrailingSpaces);
        }

#nullable enable
        public static string? GetDetail(string? errorId)
        {
            return errorId == null ? null : errorDetailMap.GetValueOrDefault(errorId);
        }
#nullable disable
    }
}


