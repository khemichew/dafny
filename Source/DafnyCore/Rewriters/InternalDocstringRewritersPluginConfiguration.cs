using System.CommandLine;
using DafnyCore;
using Microsoft.Dafny.Compilers;
using Microsoft.Dafny.Plugins;
namespace MutateCSharp
{
    internal class Schemata451
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT451");
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
    public class InternalDocstringRewritersPluginConfiguration : Plugins.PluginConfiguration
    {
        public static readonly InternalDocstringRewritersPluginConfiguration Singleton = new();
        public static readonly Plugin Plugin = new ConfiguredPlugin(Singleton);

        static InternalDocstringRewritersPluginConfiguration()
        {
            DafnyOptions.RegisterLegacyBinding(UseJavadocLikeDocstringRewriterOption,
              (options, value) => { options.UseJavadocLikeDocstringRewriter = value; });
            DooFile.RegisterNoChecksNeeded(UseJavadocLikeDocstringRewriterOption, MutateCSharp.Schemata451.ReplaceBooleanConstant_0(1L, false));
        }

        public static readonly Option<bool> UseJavadocLikeDocstringRewriterOption = new(MutateCSharp.Schemata451.ReplaceStringConstant_1(2L, "--javadoclike-docstring-plugin"),
      MutateCSharp.Schemata451.ReplaceStringConstant_1(3L, "Rewrite docstrings using a simple Javadoc-to-markdown converter"
      ));

        public override DocstringRewriter[] GetDocstringRewriters(DafnyOptions options)
        {
            if (options.UseJavadocLikeDocstringRewriter)
            {
                return new DocstringRewriter[] {
        new JavadocLikeDocstringRewriter()
      };
            }
            else
            {
                return new DocstringRewriter[] { };
            }

            return default;
        }
    }
}