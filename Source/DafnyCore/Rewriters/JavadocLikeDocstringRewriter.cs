using System;
using System.Text.RegularExpressions;
namespace MutateCSharp
{
    internal class Schemata453
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT453");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static int ReplacePostfixUnaryExprOp_3(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
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

    }
}

namespace Microsoft.Dafny
{

    // To use it in CLI or Dafny language server, use the option
    // --javadoclike-docstring-plugin
    // You can also create your own 
    public class JavadocLikeDocstringRewriter : Plugins.DocstringRewriter
    {
        private const string DocTableStart = "\n|  |  |\n| --- | --- |";

        public override string RewriteDocstring(string extractedDocString)
        {
            var detectJavadoc = new Regex(MutateCSharp.Schemata453.ReplaceStringConstant_0(1L, @"(\r?\n|^)\s*(@param|@return)"));
            if (!detectJavadoc.Match(extractedDocString).Success)
            {
                return null;
            }
            var documentation = "";

            var initialText = new Regex(MutateCSharp.Schemata453.ReplaceStringConstant_0(2L, @"^(?:(?!\r?\n\s*@)[\s\S])*")).Match(extractedDocString).Value.Trim();
            documentation += initialText;

            var paramsRanges = new Regex(MutateCSharp.Schemata453.ReplaceStringConstant_0(3L, @"@param\s+(?<Name>\w+)\s+(?<Description>(?:(?!\n\s*@)[\s\S])*)"));

            var matches = paramsRanges.Matches(extractedDocString);
            var tableRows = MutateCSharp.Schemata453.ReplaceNumericConstant_1(4L, 0);
            for (var i = MutateCSharp.Schemata453.ReplaceNumericConstant_1(8L, 0); MutateCSharp.Schemata453.ReplaceBinExprOp_2(12L, i, matches.Count); MutateCSharp.Schemata453.ReplacePostfixUnaryExprOp_3(17L, ref i))
            {
                var match = matches[i];
                var name = match.Groups[MutateCSharp.Schemata453.ReplaceStringConstant_0(18L, "Name")].Value;
                var description = EscapeNewlines(match.Groups[MutateCSharp.Schemata453.ReplaceStringConstant_0(19L, "Description")].Value);
                if (MutateCSharp.Schemata453.ReplaceBinExprOp_4(24L, i, MutateCSharp.Schemata453.ReplaceNumericConstant_1(20L, 0)))
                {
                    if (MutateCSharp.Schemata453.ReplaceBinExprOp_4(34L, MutateCSharp.Schemata453.ReplacePostfixUnaryExprOp_3(29L, ref tableRows), MutateCSharp.Schemata453.ReplaceNumericConstant_1(30L, 0)))
                    {
                        documentation += DocTableStart;
                    }
                    documentation += MutateCSharp.Schemata453.ReplaceStringConstant_0(39L, "\n| **Params** | ");
                }
                else
                {
                    documentation += MutateCSharp.Schemata453.ReplaceStringConstant_0(40L, "\n| | ");
                }
                documentation += $"**{name}** - {description} |";
            }
            var returnsDoc = new Regex(MutateCSharp.Schemata453.ReplaceStringConstant_0(41L, @"@returns?\s+(?<Description>(?:(?!\n\s*@)[\s\S])*)"));
            if (returnsDoc.Match(extractedDocString) is { Success: true } matched)
            {
                var description = EscapeNewlines(matched.Groups[MutateCSharp.Schemata453.ReplaceStringConstant_0(42L, "Description")].Value);
                if (MutateCSharp.Schemata453.ReplaceBinExprOp_4(47L, tableRows, MutateCSharp.Schemata453.ReplaceNumericConstant_1(43L, 0)))
                {
                    documentation += DocTableStart;
                }
                documentation += $"\n| **Returns** | {description} |";
            }

            return documentation;
        }

        private static string EscapeNewlines(string content)
        {
            var newlines = new Regex(MutateCSharp.Schemata453.ReplaceStringConstant_0(52L, @"\r?\n"));
            return newlines.Replace(content, MutateCSharp.Schemata453.ReplaceStringConstant_0(53L, "<br>"));
        }
    }
}