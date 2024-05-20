using System.Diagnostics.Contracts;
using System.Text;
namespace MutateCSharp
{
    internal class Schemata252
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT252");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_5(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static string ReplaceStringConstant_3(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_2(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
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

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public static class ConcreteSyntaxTreeUtils
    {
        public static string Repeat(string template, int times, string separator = "")
        {
            Contract.Requires(times >= 0);

            var builder = new StringBuilder();
            string sep = "";
            for (int i = MutateCSharp.Schemata252.ReplaceNumericConstant_0(1L, 0); MutateCSharp.Schemata252.ReplaceBinExprOp_1(5L, i, times); MutateCSharp.Schemata252.ReplacePostfixUnaryExprOp_2(10L, ref i))
            {
                builder.Append(sep);
                builder.Append(string.Format(template, i));
                sep = separator;
            }

            return builder.ToString();
        }

        public static ConcreteSyntaxTree BracketList(params ICanRender[] elements)
        {
            var result = List(elements);
            result.Prepend<LineSegment>(MutateCSharp.Schemata252.ReplaceStringConstant_3(11L, "<"));
            result.Write(MutateCSharp.Schemata252.ReplaceStringConstant_3(12L, ">"));
            return result;
        }

        public static ConcreteSyntaxTree ParensList(params ICanRender[] elements)
        {
            var result = List(elements);
            result.Prepend<LineSegment>(MutateCSharp.Schemata252.ReplaceStringConstant_3(13L, "("));
            result.Write(MutateCSharp.Schemata252.ReplaceStringConstant_3(14L, ")"));
            return result;
        }

        public static ConcreteSyntaxTree List(params ICanRender[] elements)
        {
            var result = new ConcreteSyntaxTree();
            if (MutateCSharp.Schemata252.ReplaceBinExprOp_4(19L, elements.Length, MutateCSharp.Schemata252.ReplaceNumericConstant_0(15L, 0)))
            {
                result.Append(elements[MutateCSharp.Schemata252.ReplaceNumericConstant_0(24L, 0)]);
                for (int i = MutateCSharp.Schemata252.ReplaceNumericConstant_0(28L, 1); MutateCSharp.Schemata252.ReplaceBinExprOp_1(32L, i, elements.Length); MutateCSharp.Schemata252.ReplacePostfixUnaryExprOp_2(37L, ref i))
                {
                    result.Write(MutateCSharp.Schemata252.ReplaceStringConstant_3(38L, ", "));
                    result.Append(elements[i]);
                }
            }
            return result;
        }
        public static ConcreteSyntaxTree ExprBlock(out ConcreteSyntaxTree body, string header = "", string footer = "")
        {
            return Block(out body, header, footer, BlockStyle.SpaceBrace, BlockStyle.Brace);
        }

        public static ConcreteSyntaxTree Block(out ConcreteSyntaxTree body, string header = "", string footer = "",
          BlockStyle open = BlockStyle.SpaceBrace,
          BlockStyle close = BlockStyle.NewlineBrace)
        {
            var outer = new ConcreteSyntaxTree();

            outer.Write(header);
            switch (open)
            {
                case BlockStyle.Nothing:
                    break;
                    break;
                case BlockStyle.Space:
                    outer.Write(" ");
                    break;
                    break;
                case BlockStyle.Newline:
                    outer.WriteLine();
                    break;
                    break;
                case BlockStyle.Brace:
                    outer.WriteLine("{");
                    break;
                    break;
                case BlockStyle.SpaceBrace:
                    outer.Write(" ");
                    outer.WriteLine("{");
                    break;
                    break;
                case BlockStyle.NewlineBrace:
                    outer.WriteLine();
                    outer.WriteLine("{");
                    break;
                    break;
            }


            body = outer.Fork(MutateCSharp.Schemata252.ReplaceNumericConstant_0(39L, 1));
            switch (open)
            {
                case BlockStyle.Nothing:
                case BlockStyle.Space:
                case BlockStyle.Newline:
                    break;
                    break;
                default:
                    outer.Write("}");
                    break;
                    break;
            }

            if (MutateCSharp.Schemata252.ReplaceBinExprOp_5(43L, footer, ""))
            {
                outer.Write(footer);
            }
            switch (close)
            {
                case BlockStyle.Space:
                case BlockStyle.SpaceBrace:
                    outer.Write(" ");
                    break;
                    break;
                case BlockStyle.Newline:
                case BlockStyle.NewlineBrace:
                    outer.WriteLine();
                    break;
                    break;
            }
            return outer;
        }
    }
}