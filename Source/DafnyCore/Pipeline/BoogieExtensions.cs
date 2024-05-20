using Microsoft.Dafny.LanguageServer.Workspace;
using OmniSharp.Extensions.LanguageServer.Protocol;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
using Range = OmniSharp.Extensions.LanguageServer.Protocol.Models.Range;
namespace MutateCSharp
{
    internal class Schemata332
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT332");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceBinExprOp_0(long mutantId, int argument1, int argument2)
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

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
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

        internal static int ReplaceBinExprOp_3(long mutantId, int argument1, int argument2)
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

    }
}

namespace Microsoft.Dafny
{
    /// <summary>
    /// Extension methods for the use with boogie data.
    /// </summary>
    public static class BoogieExtensions
    {
        /// <summary>
        /// The offset to convert a boogie line-number to an LSP line-number.
        /// </summary>
        public const int LineOffset = -1;

        /// <summary>
        /// The offset to convert a boogie column-number to an LSP column-number.
        /// </summary>
        public const int ColumnOffset = -1;

        public static Range ToLspRange(this DafnyRange range)
        {
            return new Range(
              range.Start.GetLspPosition(),
              range.ExclusiveEnd.GetLspPosition());
        }

        /// <summary>
        /// Gets the LSP range of the specified token.
        /// </summary>
        /// <param name="startToken">The token to get the range of.</param>
        /// <param name="endToken">An optional other token to get the end of the range of.</param>
        /// <returns>The LSP range of the token.</returns>
        public static Range ToLspRange(this RangeToken range)
        {
            return range.ToDafnyRange().ToLspRange();
        }

        /// <summary>
        /// Gets the LSP range of the specified token.
        /// </summary>
        /// <param name="startToken">The token to get the range of.</param>
        /// <param name="endToken">An optional other token to get the end of the range of.</param>
        /// <returns>The LSP range of the token.</returns>
        public static Range GetLspRange(this IToken startToken, IToken endToken)
        {
            return GetLspRangeGeneric(startToken, endToken);
        }

        private static Range GetLspRangeGeneric(this Boogie.IToken startToken, Boogie.IToken endToken)
        {
            return new Range(
              GetLspPosition(startToken),
              ToLspPosition(endToken.line, MutateCSharp.Schemata332.ReplaceBinExprOp_0(1L, endToken.col, endToken.val.Length))
            );
        }

        /// <summary>
        /// Gets the LSP range of the specified token.
        /// </summary>
        /// <param name="token">The token to get the range of.</param>
        /// <param name="endToken">An optional other token to get the end of the range of.</param>
        /// <returns>The LSP range of the token.</returns>
        public static Range GetLspRange(this Boogie.IToken token, bool nameRange = false)
        {
            if (token is NestedToken nestedToken)
            {
                return GetLspRange(nestedToken.Outer, nameRange);
            }
            var dafnyToken = BoogieGenerator.ToDafnyToken(!nameRange, token);
            if (dafnyToken is RangeToken rangeToken)
            {
                return GetLspRangeGeneric(rangeToken.StartToken, rangeToken.EndToken);
            }
            return GetLspRangeGeneric(token, token);
        }

        public static Position GetLspPosition(this DafnyPosition position)
        {
            return new Position(position.Line, position.Column);
        }

        public static Location GetLocation(this IToken token)
        {
            return new Location
            {
                Uri = DocumentUri.From(token.Uri),
                Range = token.GetLspRange(MutateCSharp.Schemata332.ReplaceBooleanConstant_1(10L, true))
            };
        }

        public static Location GetLocation(this RangeToken token)
        {
            return new Location()
            {
                Uri = DocumentUri.From(token.Uri),
                Range = token.GetLspRange()
            };
        }

        public static FilePosition GetFilePosition(this IToken token, bool end = false)
        {
            return new FilePosition(token.Uri, GetLspPosition(token, end));
        }

        /// <summary>
        /// Gets the LSP position of the specified token (i.e., the position of the first character of the token).
        /// </summary>
        /// <param name="token">The token to get the position of.</param>
        /// <param name="end">Whether to take the ending position of the token instead.</param>
        /// <returns>The LSP position of the token.</returns>
        public static Position GetLspPosition(this Boogie.IToken token, bool end = false)
        {
            return ToLspPosition(token.line, MutateCSharp.Schemata332.ReplaceBinExprOp_0(15L, token.col, (end ? token.val.Length : MutateCSharp.Schemata332.ReplaceNumericConstant_2(11L, 0))));
        }

        /// <summary>
        /// Converts a given line and column of a boogie document to its LSP counterpart.
        /// </summary>
        /// <param name="boogieLine">The line in the boogie format.</param>
        /// <param name="boogieColumn">The column in the boogie format.</param>
        /// <returns>The given boogie line and column as a LSP position.</returns>
        public static Position ToLspPosition(int boogieLine, int boogieColumn)
        {
            return new Position(MutateCSharp.Schemata332.ReplaceBinExprOp_0(24L, boogieLine, LineOffset), MutateCSharp.Schemata332.ReplaceBinExprOp_0(33L, boogieColumn, ColumnOffset));
        }

        public static (int line, int col) ToTokenLineAndCol(this Position position)
        {
            return (line: MutateCSharp.Schemata332.ReplaceBinExprOp_3(42L, position.Line, LineOffset), col: MutateCSharp.Schemata332.ReplaceBinExprOp_3(51L, position.Character, ColumnOffset));
        }
    }
}
