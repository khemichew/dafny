using System.Collections.Generic;
using System.IO;
namespace MutateCSharp
{
    internal class Schemata255
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT255");
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
    public
      class LineSegment : ICanRender
    {
        private readonly string _value;

        public LineSegment(string value)
        {
            this._value = value;
        }

        public static implicit operator LineSegment(string value) => new LineSegment(value);

        public void Render(TextWriter writer, int indentation, WriterState writerState, Queue<FileSyntax> files, int indentSize = 2)
        {
            if (writerState.HasNewLine)
            {
                writer.Write(new string(' ', indentation));
                writerState.HasNewLine = MutateCSharp.Schemata255.ReplaceBooleanConstant_0(1L, false);
            }

            writer.Write(_value);
        }
    }
}