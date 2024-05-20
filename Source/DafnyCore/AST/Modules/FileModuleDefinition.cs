using System.Collections.Generic;
using System.Linq;
namespace MutateCSharp
{
    internal class Schemata123
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT123");
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

        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{

    /// <summary>
    /// This is a temporary container of everything declared at the top level of a file, including include directives.
    /// After parsing, the contents of this 'module' are moved into the default module.
    /// In the future, files may declare implicit modules and then this class will play a non-temporary role:
    /// https://github.com/dafny-lang/dafny/issues/3027
    /// </summary>
    public class FileModuleDefinition : ModuleDefinition
    {
        public List<Include> Includes { get; } = new();

        public FileModuleDefinition(IToken token) :
          base(token.ToRange(), new Name(MutateCSharp.Schemata123.ReplaceStringConstant_0(1L, "_module")), new List<IToken>(),
            ModuleKindEnum.Concrete, MutateCSharp.Schemata123.ReplaceBooleanConstant_1(2L, false), null, null, null)
        {
            {
            }
        }

        public FileModuleDefinition(Cloner cloner, FileModuleDefinition original)
          : base(cloner, original)
        {
            Includes = original.Includes;
        }
    }
}