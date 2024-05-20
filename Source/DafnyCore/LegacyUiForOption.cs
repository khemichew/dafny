using System;
using System.Collections.Generic;
using System.CommandLine;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace MutateCSharp
{
    internal class Schemata321
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT321");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
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

        internal static int ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
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

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
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

        internal static int ReplacePostfixUnaryExprOp_3(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
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
    public record LegacyUiForOption(Option Option, Action<Boogie.CommandLineParseState, DafnyOptions> Parse,
      string Category, string Name, string Description, string ArgumentName, object DefaultValue)
    {

        public static string GenerateHelp(string template, IEnumerable<LegacyUiForOption> options, bool oldStyle = false)
        {
            var regex = new Regex(MutateCSharp.Schemata321.ReplaceStringConstant_0(1L, @"---- ([^-]+) -+\r?\n *\r?\n"));
            var categories = regex.Matches(template).ToArray();

            var optionsByCategory = options.Where(o => !o.Option.IsHidden).
              GroupBy(option => option.Category).
              ToDictionary(g => g.Key, g => g as IEnumerable<LegacyUiForOption>);

            var output = new StringBuilder();
            var outputIndex = MutateCSharp.Schemata321.ReplaceNumericConstant_1(2L, 0);
            for (var index = MutateCSharp.Schemata321.ReplaceNumericConstant_1(6L, 0); MutateCSharp.Schemata321.ReplaceBinExprOp_2(10L, index, categories.ToArray().Length); MutateCSharp.Schemata321.ReplacePostfixUnaryExprOp_3(15L, ref index))
            {
                var category = categories.ToArray()[index];
                var preCategory = template.Substring(outputIndex, MutateCSharp.Schemata321.ReplaceBinExprOp_4(16L, category.Index, outputIndex));
                output.Append(preCategory);
                outputIndex = MutateCSharp.Schemata321.ReplaceBinExprOp_5(25L, category.Index, category.Length);
                var categoryName = category.Groups[MutateCSharp.Schemata321.ReplaceNumericConstant_1(34L, 1)].Value;
                output.Append(category.Value);
                var optionsForCategory = optionsByCategory.GetValueOrDefault(categoryName, Enumerable.Empty<LegacyUiForOption>());

                foreach (var option in optionsForCategory.OrderBy(o => o.Name))
                {
                    var prefix = oldStyle ? MutateCSharp.Schemata321.ReplaceStringConstant_0(38L, "/") : MutateCSharp.Schemata321.ReplaceStringConstant_0(39L, "--");
                    var suffix = oldStyle ? MutateCSharp.Schemata321.ReplaceStringConstant_0(40L, ":") : MutateCSharp.Schemata321.ReplaceStringConstant_0(41L, "=");
                    var optionHelpHeader = $"  {prefix}{option.Name}{suffix}<{option.ArgumentName ?? MutateCSharp.Schemata321.ReplaceStringConstant_0(42L, "value")}>";
                    var linePrefix = MutateCSharp.Schemata321.ReplaceStringConstant_0(43L, "\n      ");
                    var optionHelp = optionHelpHeader + linePrefix + string.Join(linePrefix, option.Description.Split(MutateCSharp.Schemata321.ReplaceStringConstant_0(44L, "\n"))) + MutateCSharp.Schemata321.ReplaceStringConstant_0(45L, "\n");
                    output.AppendLine(optionHelp);
                }
            }
            output.Append(template.Substring(outputIndex));

            return output.ToString();
        }
    }
}