using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using JetBrains.Annotations;
namespace MutateCSharp
{
    internal class Schemata251
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT251");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
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

        internal static int ReplaceNumericConstant_0(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_6(long mutantId, string argument1, string argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplacePostfixUnaryExprOp_2(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_5(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBinExprOp_7(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 != argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static int ReplaceBinExprOp_8(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 * argument2;
        }

        internal static int ReplaceBinExprOp_9(long mutantId, int argument1, int argument2)
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

        internal static string ReplaceStringConstant_1(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public enum BlockStyle
    {
        Nothing,
        Space,
        Newline,
        Brace,
        SpaceBrace,
        NewlineBrace
    }

    public class ConcreteSyntaxTree : ICanRender
    {
        public ConcreteSyntaxTree(int relativeIndent = 0)
        {
            RelativeIndentLevel = relativeIndent;
        }

        public readonly int RelativeIndentLevel;

        private readonly IList<ICanRender> _nodes = new List<ICanRender>();

        public IEnumerable<ICanRender> Nodes => _nodes;
        public IEnumerable<ICanRender> Descendants => Nodes.Concat(Nodes.OfType<ConcreteSyntaxTree>().SelectMany(n => n.Descendants));

        public virtual ConcreteSyntaxTree Fork(int relativeIndent = 0)
        {
            var result = new ConcreteSyntaxTree(relativeIndent);
            _nodes.Add(result);
            return result;
        }

        public void Clear()
        {
            while (_nodes.Any())
            {
                _nodes.RemoveAt(MutateCSharp.Schemata251.ReplaceNumericConstant_0(1L, 0));
            }
        }

        public T Prepend<T>(T node)
          where T : ICanRender
        {
            _nodes.Insert(MutateCSharp.Schemata251.ReplaceNumericConstant_0(5L, 0), node);
            return node;
        }

        public T Append<T>(T node)
          where T : ICanRender
        {
            Contract.Requires(node != null);
            _nodes.Add(node);
            return node;
        }

        public ConcreteSyntaxTree Write(string value)
        {
            _nodes.Add(new LineSegment(value));
            return this;
        }

        [StringFormatMethod("format")]
        public ConcreteSyntaxTree WriteLine(string format, params object[] args)
        {
            WriteLine(string.Format(format, args));
            return this;
        }

        public ConcreteSyntaxTree WriteLine(string value)
        {
            Write(value);
            WriteLine();
            return this;
        }

        public ConcreteSyntaxTree WriteLine()
        {
            _nodes.Add(new NewLine());
            return this;
        }

        public ConcreteSyntaxTree Comma<T>(IEnumerable<T> elements, Action<T> a)
        {
            return Comma(MutateCSharp.Schemata251.ReplaceStringConstant_1(9L, ", "), elements, (element, _) => a(element));
        }

        public ConcreteSyntaxTree Comma<T>(IEnumerable<T> elements, Action<T, int> a)
        {
            return Comma(MutateCSharp.Schemata251.ReplaceStringConstant_1(10L, ", "), elements, a);
        }

        public ConcreteSyntaxTree Comma<T>(string comma, IEnumerable<T> elements, Action<T> a)
        {
            return Comma(comma, elements, (element, _) => a(element));
        }

        public ConcreteSyntaxTree Comma<T>(string comma, IEnumerable<T> elements, Action<T, int> a)
        {
            var sep = "";
            var index = MutateCSharp.Schemata251.ReplaceNumericConstant_0(11L, 0);
            foreach (var element in elements)
            {
                Write(sep);
                a(element, index);
                sep = comma;
                MutateCSharp.Schemata251.ReplacePostfixUnaryExprOp_2(15L, ref index);
            }

            return this;
        }

        [StringFormatMethod("format")]
        public ConcreteSyntaxTree Write(string format, params object[] args)
        {
            Write(string.Format(format, args));
            return this;
        }

        public ConcreteSyntaxTree FormatLine(FormattableString input)
        {
            Format(input);
            return WriteLine();
        }

        static string anchorUUID = MutateCSharp.Schemata251.ReplaceStringConstant_1(16L, "20e34a49-f40b-4547-ba7a-3a1955826af2");

        public static ConcreteSyntaxTree Create(FormattableString input)
        {
            return new ConcreteSyntaxTree().Format(input);
        }

        public ConcreteSyntaxTree Format(FormattableString input)
        {
            var anchorValues = new List<ICanRender>();
            // Because template strings are difficult to process, we use the existing string.Format to do the processing
            // and we insert anchors to identify where the ConcreteSyntaxTree values are.
            // Template string processing logic can be found here: https://github.com/dotnet/runtime/blob/ae5ee8f02d6fc99469e1f194be45b5f649c2da1a/src/libraries/System.Private.CoreLib/src/System/Text/ValueStringBuilder.AppendFormat.cs#L60
            var formatArguments = Enumerable.Range(MutateCSharp.Schemata251.ReplaceNumericConstant_0(17L, 0), input.ArgumentCount).
              Select(index =>
              {
                  object argument = input.GetArgument(index)!;
                  if (argument is ICanRender treeArg)
                  {
                      anchorValues.Add(treeArg);
                      return $"{anchorUUID}{MutateCSharp.Schemata251.ReplaceBinExprOp_3(25L, anchorValues.Count, MutateCSharp.Schemata251.ReplaceNumericConstant_0(21L, 1))}";
                  }

                  return argument;
              }).ToArray();

            var anchorString = string.Format(input.Format, formatArguments);
            for (int argIndex = MutateCSharp.Schemata251.ReplaceNumericConstant_0(34L, 0); MutateCSharp.Schemata251.ReplaceBinExprOp_4(38L, argIndex, anchorValues.Count); MutateCSharp.Schemata251.ReplacePostfixUnaryExprOp_2(43L, ref argIndex))
            {
                var split = anchorString.Split($"{anchorUUID}{argIndex}");
                anchorString = MutateCSharp.Schemata251.ReplaceBinExprOp_5(48L, split.Length, MutateCSharp.Schemata251.ReplaceNumericConstant_0(44L, 1)) ? split[MutateCSharp.Schemata251.ReplaceNumericConstant_0(53L, 1)] : "";
                Write(split[MutateCSharp.Schemata251.ReplaceNumericConstant_0(57L, 0)]);
                Append(anchorValues[argIndex]);
            }

            if (MutateCSharp.Schemata251.ReplaceBinExprOp_6(61L, anchorString, ""))
            {
                Write(anchorString);
            }

            return this;
        }

        public ConcreteSyntaxTree Write(char value)
        {
            Write(new string(value, MutateCSharp.Schemata251.ReplaceNumericConstant_0(62L, 1)));
            return this;
        }

        public ConcreteSyntaxTree InParens()
        {
            return Create($"({this})");
        }

        // ----- Nested blocks ------------------------------

        public virtual ConcreteSyntaxTree ForkInParens()
        {
            var result = new ConcreteSyntaxTree();
            Write(MutateCSharp.Schemata251.ReplaceStringConstant_1(66L, "("));
            Append(result);
            Write(MutateCSharp.Schemata251.ReplaceStringConstant_1(67L, ")"));
            return result;
        }

        public ConcreteSyntaxTree NewBlock(string header = "", string footer = "",
          BlockStyle open = BlockStyle.SpaceBrace,
          BlockStyle close = BlockStyle.NewlineBrace)
        {
            Contract.Requires(header != null);
            Append(ConcreteSyntaxTreeUtils.Block(out ConcreteSyntaxTree result, header: header, footer: footer, open: open,
              close: close));
            return result;
        }

        [StringFormatMethod("headerFormat")]
        public ConcreteSyntaxTree NewNamedBlock(string headerFormat, params object[] headerArgs)
        {
            Contract.Requires(headerFormat != null);
            return NewBlock(string.Format(headerFormat, headerArgs), null);
        }

        [StringFormatMethod("headerFormat")]
        public ConcreteSyntaxTree NewExprBlock(string headerFormat, params object[] headerArgs)
        {
            Contract.Requires(headerFormat != null);
            return NewBigExprBlock(string.Format(headerFormat, headerArgs), null);
        }

        public ConcreteSyntaxTree NewBigExprBlock(string header = "", string /*?*/ footer = "")
        {
            return NewBlock(header, footer, BlockStyle.SpaceBrace, BlockStyle.Brace);
        }

        public ConcreteSyntaxTree NewFile(string filename)
        {
            var result = new FileSyntax(filename);
            _nodes.Add(result);
            return result.Tree;
        }

        // ----- Collection ------------------------------

        public override string ToString()
        {
            return MakeString();
        }

        public string MakeString(int indentSize = 2)
        {
            var sw = new StringWriter();
            var files = new Queue<FileSyntax>();
            Render(sw, MutateCSharp.Schemata251.ReplaceNumericConstant_0(68L, 0), new WriterState(), files, indentSize);
            while (MutateCSharp.Schemata251.ReplaceBinExprOp_7(76L, files.Count, MutateCSharp.Schemata251.ReplaceNumericConstant_0(72L, 0)))
            {
                var ftw = files.Dequeue();
                sw.WriteLine(MutateCSharp.Schemata251.ReplaceStringConstant_1(81L, "#file {0}"), ftw.Filename);
                ftw.Render(sw, MutateCSharp.Schemata251.ReplaceNumericConstant_0(82L, 0), new WriterState(), files, indentSize);
            }

            return sw.ToString();
        }

        public void Render(TextWriter writer, int indentation, WriterState writerState, Queue<FileSyntax> files, int indentSize = 2)
        {
            foreach (var node in _nodes)
            {
                node.Render(writer, MutateCSharp.Schemata251.ReplaceBinExprOp_9(95L, indentation, MutateCSharp.Schemata251.ReplaceBinExprOp_8(86L, RelativeIndentLevel, indentSize)), writerState, files, indentSize);
            }
        }
    }
}