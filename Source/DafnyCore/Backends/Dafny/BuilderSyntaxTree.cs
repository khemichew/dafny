using System;
namespace MutateCSharp
{
    internal class Schemata222
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT222");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny.Compilers
{
    public
      class BuilderSyntaxTree<T> : ConcreteSyntaxTree
    {
        public readonly T Builder;
        public readonly DafnyCodeGenerator Compiler;

        public BuilderSyntaxTree(T builder, DafnyCodeGenerator compiler)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            Builder = builder;
            Compiler = compiler;
        }

        public override ConcreteSyntaxTree Fork(int relativeIndent = 0)
        {
            if (Builder is StatementContainer statementContainer)
            {
                return new BuilderSyntaxTree<StatementContainer>(statementContainer.Fork(), Compiler);
            }
            else
            {
                // Warning: this is an invalid operation: cannot fork builder of type Builder.GetType()
                throw new InvalidOperationException(MutateCSharp.Schemata222.ReplaceStringConstant_0(1L, "<i>Builder not StatementContainer</i> but ") + Builder.GetType().ToString());
            }

            return default;
        }

        public override ConcreteSyntaxTree ForkInParens()
        {
            // TODO(shadaj): perhaps should check if we are an expr container
            return new BuilderSyntaxTree<T>(Builder, Compiler);
        }
    }
}
