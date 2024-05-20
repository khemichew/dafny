using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using DafnyCore;
using DafnyCore.Options;
using Serilog.Events;
namespace MutateCSharp
{
    internal class Schemata325
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT325");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBooleanConstant_1(long mutantId, bool argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return !argument1; }
            return argument1;
        }

        internal static string ReplaceStringConstant_0(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.CommonOptionBag.TestAssumptionsMode argument1, Microsoft.Dafny.CommonOptionBag.TestAssumptionsMode argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
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

        internal static bool ReplaceBinExprOp_3(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static uint ReplaceNumericConstant_5(long mutantId, uint argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 2)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return 0; }
            return argument1;
        }

    }
}

namespace Microsoft.Dafny
{
    public class CommonOptionBag
    {

        public static void EnsureStaticConstructorHasRun() { }

        public static readonly Option<bool> ProgressOption =
          new(MutateCSharp.Schemata325.ReplaceStringConstant_0(1L, "--progress"), MutateCSharp.Schemata325.ReplaceStringConstant_0(2L, "While verifying, output information that helps track progress"))
          {
              IsHidden = MutateCSharp.Schemata325.ReplaceBooleanConstant_1(3L, true
      )
          };

        public static readonly Option<string> LogLocation =
          new(MutateCSharp.Schemata325.ReplaceStringConstant_0(4L, "--log-location"), MutateCSharp.Schemata325.ReplaceStringConstant_0(5L, "Sets the directory where to store log files"))
          {
              IsHidden = MutateCSharp.Schemata325.ReplaceBooleanConstant_1(6L, true
      )
          };

        public static readonly Option<LogEventLevel> LogLevelOption =
          new(MutateCSharp.Schemata325.ReplaceStringConstant_0(7L, "--log-level"), () => LogEventLevel.Error, MutateCSharp.Schemata325.ReplaceStringConstant_0(8L, "Sets the level at which events are logged"))
          {
              IsHidden = MutateCSharp.Schemata325.ReplaceBooleanConstant_1(9L, true
      )
          };

        public static readonly Option<bool> ManualTriggerOption =
          new(MutateCSharp.Schemata325.ReplaceStringConstant_0(10L, "--manual-triggers"), MutateCSharp.Schemata325.ReplaceStringConstant_0(11L, "Do not generate {:trigger} annotations for user-level quantifiers"))
          {
              IsHidden = MutateCSharp.Schemata325.ReplaceBooleanConstant_1(12L, true
      )
          };

        public static readonly Option<bool> ShowHints =
          new(MutateCSharp.Schemata325.ReplaceStringConstant_0(13L, "--show-hints"), () => MutateCSharp.Schemata325.ReplaceBooleanConstant_1(14L, false), MutateCSharp.Schemata325.ReplaceStringConstant_0(15L, "Show hints that might help you better understand your code, such as what triggers Dafny generators for quantifiers"))
          {
              IsHidden = MutateCSharp.Schemata325.ReplaceBooleanConstant_1(16L, true
      )
          };

        public enum AssertionShowMode { None, Implicit, All }
        public static readonly Option<AssertionShowMode> ShowAssertions = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(17L, "--show-assertions"), () => AssertionShowMode.None,
      MutateCSharp.Schemata325.ReplaceStringConstant_0(18L, "Show hints on locations where implicit assertions occur"));

        public static readonly Option<bool> AddCompileSuffix =
          new(MutateCSharp.Schemata325.ReplaceStringConstant_0(19L, "--compile-suffix"), MutateCSharp.Schemata325.ReplaceStringConstant_0(20L, "Add the suffix _Compile to module names without :extern"))
          {
              IsHidden = MutateCSharp.Schemata325.ReplaceBooleanConstant_1(21L, true
      )
          };

        public static readonly Option<bool> ManualLemmaInduction =
          new(MutateCSharp.Schemata325.ReplaceStringConstant_0(22L, "--manual-lemma-induction"), MutateCSharp.Schemata325.ReplaceStringConstant_0(23L, "Turn off automatic induction for lemmas."));

        public static readonly Option<bool> StdIn = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(24L, "--stdin"), () => MutateCSharp.Schemata325.ReplaceBooleanConstant_1(25L, false),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(26L, @"Read standard input and treat it as an input .dfy file."));

        public static readonly Option<bool> OptimizeErasableDatatypeWrapper = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(27L, "--optimize-erasable-datatype-wrapper"), () => MutateCSharp.Schemata325.ReplaceBooleanConstant_1(28L, true), MutateCSharp.Schemata325.ReplaceStringConstant_0(29L, @"
false - Include all non-ghost datatype constructors in the compiled code
true - In the compiled target code, transform any non-extern
    datatype with a single non-ghost constructor that has a single
    non-ghost parameter into just that parameter. For example, the type
        datatype Record = Record(x: int)
    is transformed into just 'int' in the target code.").TrimStart());

        public static readonly Option<bool> Verbose = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(30L, "--verbose"),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(31L, "Print additional information such as which files are emitted where."));

        public static readonly Option<bool> AllowDeprecation = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(32L, "--allow-deprecation"),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(33L, "Do not warn about the use of deprecated features."))
        {
        };

        public static readonly Option<bool> DisableNonLinearArithmetic = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(34L, "--disable-nonlinear-arithmetic"),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(35L, @"
(experimental, will be replaced in the future)
Reduce Dafny's knowledge of non-linear arithmetic (*,/,%).
  
Results in more manual work, but also produces more predictable behavior.").TrimStart());

        public static readonly Option<bool> EnforceDeterminism = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(36L, "--enforce-determinism"),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(37L, "Check that only deterministic statements are used, so that values seen during execution will be the same in every run of the program."))
        {
        };

        public static readonly Option<bool> RelaxDefiniteAssignment = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(38L, "--relax-definite-assignment"),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(39L, "Allow variables to be read before they are assigned, but only if they have an auto-initializable type or if they are ghost and have a nonempty type."))
        {
        };

        public static readonly Option<IList<string>> VerificationLogFormat = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(40L, "--log-format"), $@"
Logs verification results using the given test result format. The currently supported formats are `trx`, `csv`, and `text`. These are: the XML-based format commonly used for test results for .NET languages, a custom CSV schema, and a textual format meant for human consumption. You can provide configuration using the same string format as when using the --logger option for dotnet test, such as: --format ""trx;LogFileName=<...>"");

The `trx` and `csv` formats automatically choose an output file name by default, and print the name of this file to the console. The `text` format prints its output to the console by default, but can send output to a file given the `LogFileName` option.

The `text` format also includes a more detailed breakdown of what assertions appear in each assertion batch. When combined with the {BoogieOptionBag.IsolateAssertions.Name} option, it will provide approximate time and resource use costs for each assertion, allowing identification of especially expensive assertions.".TrimStart())
        {
            ArgumentHelpName = MutateCSharp.Schemata325.ReplaceStringConstant_0(41L, "configuration"
      )
        };

        public static readonly Option<bool> JsonDiagnostics = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(42L, "--json-diagnostics"), MutateCSharp.Schemata325.ReplaceStringConstant_0(43L, @"Deprecated. Return diagnostics in a JSON format."))
        {
            IsHidden = MutateCSharp.Schemata325.ReplaceBooleanConstant_1(44L, true
      )
        };

        public static readonly Option<IList<FileInfo>> Libraries = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(45L, "--library"),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(46L, @"
The contents of this file and any files it includes can be referenced from other files as if they were included. 
However, these contents are skipped during code generation and verification.
This option is useful in a diamond dependency situation, 
to prevent code from the bottom dependency from being generated more than once.
The value may be a comma-separated list of files and folders.").TrimStart());

        public static IEnumerable<string> SplitOptionValueIntoFiles(IEnumerable<string> inputs)
        {
            var result = new HashSet<string>();
            foreach (var input in inputs)
            {
                var values = input.Split(',');
                foreach (var slice in values)
                {
                    var name = slice.Trim();
                    if (Directory.Exists(name))
                    {
                        var files = Directory.GetFiles(name, MutateCSharp.Schemata325.ReplaceStringConstant_0(47L, "*.dfy"), SearchOption.AllDirectories);
                        foreach (var file in files) { result.Add(file); }
                    }
                    else
                    {
                        result.Add(name);
                    }
                }
            }
            return result;
        }

        public static readonly Option<FileInfo> BuildFile = new(new[] { MutateCSharp.Schemata325.ReplaceStringConstant_0(48L, "--build"), MutateCSharp.Schemata325.ReplaceStringConstant_0(49L, "-b") },
      MutateCSharp.Schemata325.ReplaceStringConstant_0(50L, "Specify the filepath that determines where to place and how to name build files."))
        {
            ArgumentHelpName = MutateCSharp.Schemata325.ReplaceStringConstant_0(51L, "file"),
            IsHidden = MutateCSharp.Schemata325.ReplaceBooleanConstant_1(52L, true
      )
        };

        public static readonly Option<FileInfo> Output = new(new[] { MutateCSharp.Schemata325.ReplaceStringConstant_0(53L, "--output"), MutateCSharp.Schemata325.ReplaceStringConstant_0(54L, "-o") },
      MutateCSharp.Schemata325.ReplaceStringConstant_0(55L, "Specify the filename and location for the generated target language files."))
        {
            ArgumentHelpName = MutateCSharp.Schemata325.ReplaceStringConstant_0(56L, "file"),
        };

        public static readonly Option<IList<string>> PluginOption = new(new[] { MutateCSharp.Schemata325.ReplaceStringConstant_0(57L, "--plugin") },
      MutateCSharp.Schemata325.ReplaceStringConstant_0(58L, @"
(experimental) One path to an assembly that contains at least one
instantiatable class extending Microsoft.Dafny.Plugin.Rewriter. It
can also extend Microsoft.Dafny.Plugins.PluginConfiguration to
receive arguments. More information about what plugins do and how
to define them:

https://github.com/dafny-lang/dafny/blob/master/Source/DafnyLanguageServer/README.md#about-plugins"))
        {
            ArgumentHelpName = MutateCSharp.Schemata325.ReplaceStringConstant_0(59L, "path-to-one-assembly[,argument]*"),
            IsHidden = MutateCSharp.Schemata325.ReplaceBooleanConstant_1(60L, true
      )
        };

        public static readonly Option<FileInfo> Prelude = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(61L, "--prelude"), MutateCSharp.Schemata325.ReplaceStringConstant_0(62L, "Choose the Dafny prelude file."))
        {
            ArgumentHelpName = MutateCSharp.Schemata325.ReplaceStringConstant_0(63L, "file"),
        };

        public static readonly Option<QuantifierSyntaxOptions> QuantifierSyntax = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(64L, "--quantifier-syntax"),
          result =>
          {
              if (result.Tokens.Any())
              {
                  var value = result.Tokens[MutateCSharp.Schemata325.ReplaceNumericConstant_2(65L, 0)].Value;
                  switch (value)
                  {
                      case "3":
                          return QuantifierSyntaxOptions.Version3;
                          break;
                      case "4":
                          return QuantifierSyntaxOptions.Version4;
                          break;
                      default:
                          result.ErrorMessage = $"{value} is not a valid argument to {QuantifierSyntax.Name}";
                          return default;
                          break;
                  }
              }

              return QuantifierSyntaxOptions.Version4;
          }, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(69L, true), MutateCSharp.Schemata325.ReplaceStringConstant_0(70L, @"
The syntax for quantification domains is changing from Dafny version 3 to version 4, more specifically where quantifier ranges (|
<Range>) are allowed. This switch gives early access to the new syntax.

3 - Ranges are only allowed after all quantified variables are declared. 
    (e.g. set x, y | 0 <= x < |s| && y in s[x] && 0 <= y :: y)
4 - Ranges are allowed after each quantified variable declaration.
    (e.g. set x | 0 <= x < |s|, y <- s[x] | 0 <= y :: y)

Note that quantifier variable domains (<- <Domain>) are available in both syntax versions.").TrimStart())
        {
            ArgumentHelpName = MutateCSharp.Schemata325.ReplaceStringConstant_0(71L, "version"),
        };

        public static readonly Option<string> Target = new(new[] { MutateCSharp.Schemata325.ReplaceStringConstant_0(72L, "--target"), MutateCSharp.Schemata325.ReplaceStringConstant_0(73L, "-t") }, () => MutateCSharp.Schemata325.ReplaceStringConstant_0(74L, "cs"), MutateCSharp.Schemata325.ReplaceStringConstant_0(75L, @"
cs - Compile to .NET via C#.
go - Compile to Go.
js - Compile to JavaScript.
java - Compile to Java.
py - Compile to Python.
cpp - (experimental) Compile to C++.

Note that the C++ backend has various limitations (see Docs/Compilation/Cpp.md). This includes lack of support for BigIntegers (aka int), most higher order functions, and advanced features like traits or co-inductive types.").TrimStart()
        )
        {
            ArgumentHelpName = MutateCSharp.Schemata325.ReplaceStringConstant_0(76L, "language"),
        };

        public static readonly Option<bool> UnicodeCharacters = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(77L, "--unicode-char"), () => MutateCSharp.Schemata325.ReplaceBooleanConstant_1(78L, true),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(79L, @"
false - The char type represents any UTF-16 code unit.
true - The char type represents any Unicode scalar value.").TrimStart())
        {
            IsHidden = MutateCSharp.Schemata325.ReplaceBooleanConstant_1(80L, true
      )
        };

        public static readonly Option<bool> AllowAxioms = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(81L, "--allow-axioms"), () => MutateCSharp.Schemata325.ReplaceBooleanConstant_1(82L, false),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(83L, "Prevents a warning from being generated for axioms, such as assume statements and functions or methods without a body, that don't have an {:axiom} attribute."))
        {
        };

        public static readonly Option<bool> TypeSystemRefresh = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(84L, "--type-system-refresh"), () => MutateCSharp.Schemata325.ReplaceBooleanConstant_1(85L, false),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(86L, @"
false - The type-inference engine and supported types are those of Dafny 4.0.
true - Use an updated type-inference engine.").TrimStart())
        {
            IsHidden = MutateCSharp.Schemata325.ReplaceBooleanConstant_1(87L, true
      )
        };

        public enum GeneralTraitsOptions
        {
            Legacy,
            Datatype,
            Full
        }

        public static readonly Option<GeneralTraitsOptions> GeneralTraits = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(88L, "--general-traits"), () => GeneralTraitsOptions.Legacy,
      MutateCSharp.Schemata325.ReplaceStringConstant_0(89L, @"
legacy - Every trait implicitly extends 'object', and thus is a reference type. Only traits and reference types can extend traits.
datatype - A trait is a reference type only if it or one of its ancestor traits is 'object'. Any non-'newtype' type with members can extend traits.
full - (don't use; not yet completely supported) A trait is a reference type only if it or one of its ancestor traits is 'object'. Any type with members can extend traits.").TrimStart())
        {
            IsHidden = MutateCSharp.Schemata325.ReplaceBooleanConstant_1(90L, true
      )
        };

        public static readonly Option<bool> GeneralNewtypes = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(91L, "--general-newtypes"), () => MutateCSharp.Schemata325.ReplaceBooleanConstant_1(92L, false),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(93L, @"
false - A newtype can only be based on numeric types or another newtype.
true - (requires --type-system-refresh) A newtype case be based on any non-reference, non-trait, non-arrow, non-ORDINAL type.").TrimStart())
        {
            IsHidden = MutateCSharp.Schemata325.ReplaceBooleanConstant_1(94L, true
      )
        };

        public static readonly Option<bool> TypeInferenceDebug = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(95L, "--type-inference-trace"), () => MutateCSharp.Schemata325.ReplaceBooleanConstant_1(96L, false),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(97L, @"
false - Don't print type-inference debug information.
true - Print type-inference debug information.").TrimStart())
        {
            IsHidden = MutateCSharp.Schemata325.ReplaceBooleanConstant_1(98L, true
      )
        };

        public static readonly Option<bool> NewTypeInferenceDebug = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(99L, "--type-system-debug"), () => MutateCSharp.Schemata325.ReplaceBooleanConstant_1(100L, false),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(101L, @"
false - Don't print debug information for the new type system.
true - Print debug information for the new type system.").TrimStart())
        {
            IsHidden = MutateCSharp.Schemata325.ReplaceBooleanConstant_1(102L, true
      )
        };

        public static readonly Option<bool> VerifyIncludedFiles = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(103L, "--verify-included-files"),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(104L, "Verify code in included files."));
        public static readonly Option<bool> UseBaseFileName = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(105L, "--use-basename-for-filename"),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(106L, "When parsing use basename of file for tokens instead of the path supplied on the command line"))
        {
        };
        public static readonly Option<bool> EmitUncompilableCode = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(107L, "--emit-uncompilable-code"),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(108L, "Rather than throwing an exception, allow compilers to emit uncompilable information including what is ") +
      MutateCSharp.Schemata325.ReplaceStringConstant_0(109L, "not compilable instead of regular code. Useful when developing compilers or to document for each test what ") +
      MutateCSharp.Schemata325.ReplaceStringConstant_0(110L, "compiler feature is missing"))
        {
        };
        public static readonly Option<bool> SpillTranslation = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(111L, "--spill-translation"),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(112L, @"In case the Dafny source code is translated to another language, emit that translation."))
        {
        };

        public static readonly Option<bool> WarnAsErrors = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(113L, "--warn-as-errors"), () => MutateCSharp.Schemata325.ReplaceBooleanConstant_1(114L, true), MutateCSharp.Schemata325.ReplaceStringConstant_0(115L, "(Deprecated). Please use --allow-warnings instead"))
        {
            IsHidden = MutateCSharp.Schemata325.ReplaceBooleanConstant_1(116L, true
      )
        };

        public static readonly Option<bool> AllowWarnings = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(117L, "--allow-warnings"),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(118L, "Allow compilation to continue and succeed when warnings occur. Errors will still halt and fail compilation."));

        public static readonly Option<bool> WarnMissingConstructorParenthesis = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(119L, "--warn-missing-constructor-parentheses"),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(120L, "Emits a warning when a constructor name in a case pattern is not followed by parentheses."));
        public static readonly Option<bool> WarnShadowing = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(121L, "--warn-shadowing"),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(122L, "Emits a warning if the name of a declared variable caused another variable to be shadowed."));
        public static readonly Option<bool> WarnContradictoryAssumptions = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(123L, "--warn-contradictory-assumptions"), MutateCSharp.Schemata325.ReplaceStringConstant_0(124L, @"
(experimental) Emits a warning if any assertions are proved based on contradictory assumptions (vacuously).
May slow down verification slightly, or make it more brittle.
May produce spurious warnings.
Use the `{:contradiction}` attribute to mark any `assert` statement intended to be part of a proof by contradiction."))
        {
            IsHidden = MutateCSharp.Schemata325.ReplaceBooleanConstant_1(125L, true
      )
        };
        public static readonly Option<bool> WarnRedundantAssumptions = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(126L, "--warn-redundant-assumptions"), MutateCSharp.Schemata325.ReplaceStringConstant_0(127L, @"
(experimental) Emits a warning if any `requires` clause or `assume` statement was not needed to complete verification.
May slow down verification slightly, or make it more brittle.
May produce spurious warnings."))
        {
            IsHidden = MutateCSharp.Schemata325.ReplaceBooleanConstant_1(128L, true
      )
        };
        public static readonly Option<string> VerificationCoverageReport = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(129L, "--verification-coverage-report"),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(130L, "Emit verification coverage report to a given directory, in the same format as a test coverage report."))
        {
            ArgumentHelpName = MutateCSharp.Schemata325.ReplaceStringConstant_0(131L, "directory"
      )
        };
        public static readonly Option<bool> NoTimeStampForCoverageReport = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(132L, "--no-timestamp-for-coverage-report"),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(133L, "Write coverage report directly to the specified folder instead of creating a timestamped subdirectory."))
        {
            IsHidden = MutateCSharp.Schemata325.ReplaceBooleanConstant_1(134L, true
      )
        };
        public static readonly Option<string> ExecutionCoverageReport = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(135L, "--coverage-report"),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(136L, "Emit execution coverage report to a given directory."))
        {
            ArgumentHelpName = MutateCSharp.Schemata325.ReplaceStringConstant_0(137L, "directory"
      )
        };

        public static readonly Option<bool> IncludeRuntimeOption = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(138L, "--include-runtime"),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(139L, "Include the Dafny runtime as source in the target language."));

        /// <summary>
        /// Copy of --include-runtime for execution commands like `dafny run`,
        /// just so it can be internal only in that context:
        /// it shouldn't matter to end users but is useful for testing.
        /// </summary>
        public static readonly Option<bool> InternalIncludeRuntimeOptionForExecution = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(140L, "--include-runtime"), () => MutateCSharp.Schemata325.ReplaceBooleanConstant_1(141L, true),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(142L, "Include the Dafny runtime as source in the target language."))
        {
            IsHidden = MutateCSharp.Schemata325.ReplaceBooleanConstant_1(143L, true
      )
        };

        public enum SystemModuleMode
        {
            Include,
            Omit,
            // Used to pre-compile the System module into the runtimes
            OmitAllOtherModules
        }

        public static readonly Option<SystemModuleMode> SystemModule = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(144L, "--system-module"), () => SystemModuleMode.Omit,
      MutateCSharp.Schemata325.ReplaceStringConstant_0(145L, "How to handle the built-in _System module."))
        {
            IsHidden = MutateCSharp.Schemata325.ReplaceBooleanConstant_1(146L, true
      )
        };

        public enum TestAssumptionsMode
        {
            None,
            Externs
        }

        public static readonly Option<TestAssumptionsMode> TestAssumptions = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(147L, "--test-assumptions"), () => TestAssumptionsMode.None, MutateCSharp.Schemata325.ReplaceStringConstant_0(148L, @"
(experimental) When turned on, inserts runtime tests at locations where (implicit) assumptions occur, such as when calling or being called by external code and when using assume statements.

Functionality is still being expanded. Currently only checks contracts on every call to a function or method marked with the {:extern} attribute.").TrimStart());

        public enum DefaultFunctionOpacityOptions
        {
            Transparent,
            AutoRevealDependencies,
            Opaque
        }

        public static readonly Option<DefaultFunctionOpacityOptions> DefaultFunctionOpacity = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(149L, "--default-function-opacity"), () => DefaultFunctionOpacityOptions.Transparent,
      MutateCSharp.Schemata325.ReplaceStringConstant_0(150L, @"
Change the default opacity of functions. 
`transparent` (default) means functions are transparent, can be manually made opaque and then revealed. 
`autoRevealDependencies` makes all functions not explicitly labelled as opaque to be opaque but reveals them automatically in scopes which do not have `{:autoRevealDependencies false}`. 
`opaque` means functions are always opaque so the opaque keyword is not needed, and functions must be revealed everywhere needed for a proof.").TrimStart())
        {
        };

        public static readonly Option<bool> UseStandardLibraries = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(151L, "--standard-libraries"), () => MutateCSharp.Schemata325.ReplaceBooleanConstant_1(152L, false),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(153L, @"
Allow Dafny code to depend on the standard libraries included with the Dafny distribution.
See https://github.com/dafny-lang/dafny/blob/master/Source/DafnyStandardLibraries/README.md for more information.
Not compatible with the --unicode-char:false option.
"));

        public static readonly Option<bool> ExtractCounterexample = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(154L, "--extract-counterexample"), () => MutateCSharp.Schemata325.ReplaceBooleanConstant_1(155L, false),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(156L, @"
If verification fails, report a detailed counterexample for the first failing assertion (experimental).").TrimStart())
        {
        };

        public static readonly Option<bool> ShowProofObligationExpressions = new(MutateCSharp.Schemata325.ReplaceStringConstant_0(157L, "--show-proof-obligation-expressions"), () => MutateCSharp.Schemata325.ReplaceBooleanConstant_1(158L, false),
      MutateCSharp.Schemata325.ReplaceStringConstant_0(159L, @"
(Experimental) Show Dafny expressions corresponding to unverified proof obligations.").TrimStart())
        {
            IsHidden = MutateCSharp.Schemata325.ReplaceBooleanConstant_1(160L, true
      )
        };

        static CommonOptionBag()
        {
            DafnyOptions.RegisterLegacyBinding(WarnAsErrors, (options, value) =>
            {
                if (MutateCSharp.Schemata325.ReplaceBinExprOp_3(161L, () => !options.Get(AllowWarnings), () => !options.Get(WarnAsErrors)))
                {
                    // If allow warnings is at the default value, and warn-as-errors is not, use the warn-as-errors value
                    options.Set(AllowWarnings, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(167L, true));
                    options.FailOnWarnings = MutateCSharp.Schemata325.ReplaceBooleanConstant_1(168L, false);
                }
            });

            DafnyOptions.RegisterLegacyUi(AllowAxioms, DafnyOptions.ParseBoolean, MutateCSharp.Schemata325.ReplaceStringConstant_0(169L, "Verification options"), legacyName: MutateCSharp.Schemata325.ReplaceStringConstant_0(170L, "allowAxioms"), defaultValue: MutateCSharp.Schemata325.ReplaceBooleanConstant_1(171L, true));
            DafnyOptions.RegisterLegacyBinding(ShowHints, (options, value) =>
            {
                options.PrintTooltips = value;
            });

            DafnyOptions.RegisterLegacyBinding(ManualTriggerOption, (options, value) =>
            {
                options.AutoTriggers = !value;
            });

            DafnyOptions.RegisterLegacyUi(Target, DafnyOptions.ParseString, MutateCSharp.Schemata325.ReplaceStringConstant_0(172L, "Compilation options"), MutateCSharp.Schemata325.ReplaceStringConstant_0(173L, "compileTarget"), MutateCSharp.Schemata325.ReplaceStringConstant_0(174L, @"
cs (default) - Compile to .NET via C#.
go - Compile to Go.
js - Compile to JavaScript.
java - Compile to Java.
py - Compile to Python.
cpp - Compile to C++.
dfy - Compile to Dafny.

Note that the C++ backend has various limitations (see
Docs/Compilation/Cpp.md). This includes lack of support for
BigIntegers (aka int), most higher order functions, and advanced
features like traits or co-inductive types.").TrimStart(), MutateCSharp.Schemata325.ReplaceStringConstant_0(175L, "cs"));

            DafnyOptions.RegisterLegacyUi(OptimizeErasableDatatypeWrapper, DafnyOptions.ParseBoolean, MutateCSharp.Schemata325.ReplaceStringConstant_0(176L, "Compilation options"), MutateCSharp.Schemata325.ReplaceStringConstant_0(177L, "optimizeErasableDatatypeWrapper"), MutateCSharp.Schemata325.ReplaceStringConstant_0(178L, @"
0 - Include all non-ghost datatype constructors in the compiled code
1 (default) - In the compiled target code, transform any non-extern
    datatype with a single non-ghost constructor that has a single
    non-ghost parameter into just that parameter. For example, the type
        datatype Record = Record(x: int)
    is transformed into just 'int' in the target code.").TrimStart(), defaultValue: MutateCSharp.Schemata325.ReplaceBooleanConstant_1(179L, true));

            DafnyOptions.RegisterLegacyUi(VerificationLogFormat, DafnyOptions.ParseStringElement, MutateCSharp.Schemata325.ReplaceStringConstant_0(180L, "Verification options"), MutateCSharp.Schemata325.ReplaceStringConstant_0(181L, "verificationLogger"));
            DafnyOptions.RegisterLegacyUi(Output, DafnyOptions.ParseFileInfo, MutateCSharp.Schemata325.ReplaceStringConstant_0(182L, "Compilation options"), MutateCSharp.Schemata325.ReplaceStringConstant_0(183L, "out"));
            DafnyOptions.RegisterLegacyUi(UnicodeCharacters, DafnyOptions.ParseBoolean, MutateCSharp.Schemata325.ReplaceStringConstant_0(184L, "Language feature selection"), MutateCSharp.Schemata325.ReplaceStringConstant_0(185L, "unicodeChar"), MutateCSharp.Schemata325.ReplaceStringConstant_0(186L, @"
0 - The char type represents any UTF-16 code unit.
1 (default) - The char type represents any Unicode scalar value.").TrimStart(), defaultValue: MutateCSharp.Schemata325.ReplaceBooleanConstant_1(187L, true));
            DafnyOptions.RegisterLegacyUi(TypeSystemRefresh, DafnyOptions.ParseBoolean, MutateCSharp.Schemata325.ReplaceStringConstant_0(188L, "Language feature selection"), MutateCSharp.Schemata325.ReplaceStringConstant_0(189L, "typeSystemRefresh"), MutateCSharp.Schemata325.ReplaceStringConstant_0(190L, @"
0 (default) - The type-inference engine and supported types are those of Dafny 4.0.
1 - Use an updated type-inference engine. Warning: This mode is under construction and probably won't work at this time.").TrimStart(), defaultValue: MutateCSharp.Schemata325.ReplaceBooleanConstant_1(191L, false));
            DafnyOptions.RegisterLegacyUi(GeneralTraits, DafnyOptions.ParseGeneralTraitsOption, MutateCSharp.Schemata325.ReplaceStringConstant_0(192L, "Language feature selection"), MutateCSharp.Schemata325.ReplaceStringConstant_0(193L, "generalTraits"), MutateCSharp.Schemata325.ReplaceStringConstant_0(194L, @"
legacy (default) - Every trait implicitly extends 'object', and thus is a reference type. Only traits and reference types can extend traits.
datatype - A trait is a reference type only if it or one of its ancestor traits is 'object'. Any non-'newtype' type with members can extend traits.
full - (don't use; not yet completely supported) A trait is a reference type only if it or one of its ancestor traits is 'object'. Any type with members can extend traits.").TrimStart());
            DafnyOptions.RegisterLegacyUi(GeneralNewtypes, DafnyOptions.ParseBoolean, MutateCSharp.Schemata325.ReplaceStringConstant_0(195L, "Language feature selection"), MutateCSharp.Schemata325.ReplaceStringConstant_0(196L, "generalNewtypes"), MutateCSharp.Schemata325.ReplaceStringConstant_0(197L, @"
0 (default) - A newtype can only be based on numeric types or another newtype.
1 - (requires /typeSystemRefresh:1) A newtype case be based on any non-reference, non-trait, non-arrow, non-ORDINAL type.").TrimStart(), MutateCSharp.Schemata325.ReplaceBooleanConstant_1(198L, false));
            DafnyOptions.RegisterLegacyUi(TypeInferenceDebug, DafnyOptions.ParseBoolean, MutateCSharp.Schemata325.ReplaceStringConstant_0(199L, "Language feature selection"), MutateCSharp.Schemata325.ReplaceStringConstant_0(200L, "titrace"), MutateCSharp.Schemata325.ReplaceStringConstant_0(201L, @"
0 (default) - Don't print type-inference debug information.
1 - Print type-inference debug information.").TrimStart(), defaultValue: MutateCSharp.Schemata325.ReplaceBooleanConstant_1(202L, false));
            DafnyOptions.RegisterLegacyUi(NewTypeInferenceDebug, DafnyOptions.ParseBoolean, MutateCSharp.Schemata325.ReplaceStringConstant_0(203L, "Language feature selection"), MutateCSharp.Schemata325.ReplaceStringConstant_0(204L, "ntitrace"), MutateCSharp.Schemata325.ReplaceStringConstant_0(205L, @"
0 (default) - Don't print debug information for the new type system.
1 - Print debug information for the new type system.").TrimStart(), defaultValue: MutateCSharp.Schemata325.ReplaceBooleanConstant_1(206L, false));
            DafnyOptions.RegisterLegacyUi(UseStandardLibraries, DafnyOptions.ParseBoolean, MutateCSharp.Schemata325.ReplaceStringConstant_0(207L, "Language feature selection"), MutateCSharp.Schemata325.ReplaceStringConstant_0(208L, "standardLibraries"), MutateCSharp.Schemata325.ReplaceStringConstant_0(209L, @"
0 (default) - Do not allow Dafny code to depend on the standard libraries included with the Dafny distribution.
1 - Allow Dafny code to depend on the standard libraries included with the Dafny distribution.
See https://github.com/dafny-lang/dafny/blob/master/Source/DafnyStandardLibraries/README.md for more information.
Not compatible with the /unicodeChar:0 option.").TrimStart(), defaultValue: MutateCSharp.Schemata325.ReplaceBooleanConstant_1(210L, false));
            DafnyOptions.RegisterLegacyUi(PluginOption, DafnyOptions.ParseStringElement, MutateCSharp.Schemata325.ReplaceStringConstant_0(211L, "Plugins"), defaultValue: new List<string>());
            DafnyOptions.RegisterLegacyUi(Prelude, DafnyOptions.ParseFileInfo, MutateCSharp.Schemata325.ReplaceStringConstant_0(212L, "Input configuration"), MutateCSharp.Schemata325.ReplaceStringConstant_0(213L, "dprelude"));

            DafnyOptions.RegisterLegacyUi(Libraries, DafnyOptions.ParseFileInfoElement, MutateCSharp.Schemata325.ReplaceStringConstant_0(214L, "Compilation options"), defaultValue: new List<FileInfo>());
            DafnyOptions.RegisterLegacyUi(DeveloperOptionBag.ResolvedPrint, DafnyOptions.ParseString, MutateCSharp.Schemata325.ReplaceStringConstant_0(215L, "Overall reporting and printing"), MutateCSharp.Schemata325.ReplaceStringConstant_0(216L, "rprint"));
            DafnyOptions.RegisterLegacyUi(DeveloperOptionBag.PrintOption, DafnyOptions.ParseString, MutateCSharp.Schemata325.ReplaceStringConstant_0(217L, "Overall reporting and printing"), MutateCSharp.Schemata325.ReplaceStringConstant_0(218L, "dprint"));

            DafnyOptions.RegisterLegacyUi(Snippets.ShowSnippets, DafnyOptions.ParseBoolean, MutateCSharp.Schemata325.ReplaceStringConstant_0(219L, "Overall reporting and printing"), MutateCSharp.Schemata325.ReplaceStringConstant_0(220L, "showSnippets"), MutateCSharp.Schemata325.ReplaceStringConstant_0(221L, @"
0 (default) - Don't show source code snippets for Dafny messages.
1 - Show a source code snippet for each Dafny message.").TrimStart());

            DafnyOptions.RegisterLegacyUi(Printer.PrintMode, ParsePrintMode, MutateCSharp.Schemata325.ReplaceStringConstant_0(222L, "Overall reporting and printing"), MutateCSharp.Schemata325.ReplaceStringConstant_0(223L, "printMode"), legacyDescription: MutateCSharp.Schemata325.ReplaceStringConstant_0(224L, @"
Everything (default) - Print everything listed below.
DllEmbed - print the source that will be included in a compiled dll.
NoIncludes - disable printing of {:verify false} methods
    incorporated via the include mechanism, as well as datatypes and
    fields included from other files.
NoGhost - disable printing of functions, ghost methods, and proof
    statements in implementation methods. It also disables anything
    NoIncludes disables.").TrimStart(),
              argumentName: MutateCSharp.Schemata325.ReplaceStringConstant_0(225L, "Everything|DllEmbed|NoIncludes|NoGhost"),
              defaultValue: PrintModes.Everything);

            DafnyOptions.RegisterLegacyUi(DefaultFunctionOpacity, DafnyOptions.ParseDefaultFunctionOpacity, MutateCSharp.Schemata325.ReplaceStringConstant_0(226L, "Language feature selection"), MutateCSharp.Schemata325.ReplaceStringConstant_0(227L, "defaultFunctionOpacity"), null);

            DafnyOptions.RegisterLegacyUi(WarnContradictoryAssumptions, DafnyOptions.ParseImplicitEnable, MutateCSharp.Schemata325.ReplaceStringConstant_0(228L, "Verification options"), MutateCSharp.Schemata325.ReplaceStringConstant_0(229L, "warnContradictoryAssumptions"));
            DafnyOptions.RegisterLegacyUi(WarnRedundantAssumptions, DafnyOptions.ParseImplicitEnable, MutateCSharp.Schemata325.ReplaceStringConstant_0(230L, "Verification options"), MutateCSharp.Schemata325.ReplaceStringConstant_0(231L, "warnRedundantAssumptions"));

            void ParsePrintMode(Option<PrintModes> option, Boogie.CommandLineParseState ps, DafnyOptions options)
            {
                if (ps.ConfirmArgumentCount(MutateCSharp.Schemata325.ReplaceNumericConstant_2(232L, 1)))
                {
                    if (ps.args[ps.i].Equals(MutateCSharp.Schemata325.ReplaceStringConstant_0(236L, "Everything")))
                    {
                        options.Set(option, PrintModes.Everything);
                    }
                    else if (ps.args[ps.i].Equals(MutateCSharp.Schemata325.ReplaceStringConstant_0(237L, "NoIncludes")))
                    {
                        options.Set(option, PrintModes.NoIncludes);
                    }
                    else if (ps.args[ps.i].Equals(MutateCSharp.Schemata325.ReplaceStringConstant_0(238L, "NoGhost")))
                    {
                        options.Set(option, PrintModes.NoGhost);
                    }
                    else if (ps.args[ps.i].Equals(MutateCSharp.Schemata325.ReplaceStringConstant_0(239L, "DllEmbed")))
                    {
                        // This is called DllEmbed because it was previously only used inside Dafny-compiled .dll files for C#,
                        // but it is now used by the LibraryBackend when building .doo files as well. 
                        options.Set(option, PrintModes.Serialization);
                    }
                    else
                    {
                        DafnyOptions.InvalidArgumentError(option.Name, ps);
                    }
                }
            }

            DafnyOptions.RegisterLegacyUi(AddCompileSuffix, DafnyOptions.ParseBoolean, MutateCSharp.Schemata325.ReplaceStringConstant_0(240L, "Compilation options"), MutateCSharp.Schemata325.ReplaceStringConstant_0(241L, "compileSuffix"));

            QuantifierSyntax = QuantifierSyntax.FromAmong(MutateCSharp.Schemata325.ReplaceStringConstant_0(242L, "3"), MutateCSharp.Schemata325.ReplaceStringConstant_0(243L, "4"));
            DafnyOptions.RegisterLegacyBinding(JsonDiagnostics, (options, value) =>
            {
                if (value)
                {
                    options.Printer = new DafnyJsonConsolePrinter(options);
                    options.DiagnosticsFormat = DafnyOptions.DiagnosticsFormats.JSON;
                }
            });

            DafnyOptions.RegisterLegacyBinding(TestAssumptions, (options, value) =>
            {
                options.TestContracts = MutateCSharp.Schemata325.ReplaceBinExprOp_4(244L, value, TestAssumptionsMode.Externs) ? DafnyOptions.ContractTestingMode.Externs : DafnyOptions.ContractTestingMode.None;
            });
            DafnyOptions.RegisterLegacyBinding(ManualLemmaInduction, (options, value) =>
            {
                if (value)
                {
                    options.Induction = MutateCSharp.Schemata325.ReplaceNumericConstant_2(245L, 1);
                }
            });
            DafnyOptions.RegisterLegacyBinding(IncludeRuntimeOption, (options, value) => { options.IncludeRuntime = value; });
            DafnyOptions.RegisterLegacyBinding(InternalIncludeRuntimeOptionForExecution, (options, value) => { options.IncludeRuntime = value; });
            DafnyOptions.RegisterLegacyBinding(SystemModule, (options, value) => { options.SystemModuleTranslationMode = value; });
            DafnyOptions.RegisterLegacyBinding(UseBaseFileName, (o, f) => o.UseBaseNameForFileName = f);
            DafnyOptions.RegisterLegacyBinding(WarnShadowing, (options, value) => { options.WarnShadowing = value; });
            DafnyOptions.RegisterLegacyBinding(WarnMissingConstructorParenthesis,
              (options, value) => { options.DisallowConstructorCaseWithoutParentheses = value; });
            DafnyOptions.RegisterLegacyBinding(AllowWarnings, (options, value) => { options.FailOnWarnings = !value; });
            DafnyOptions.RegisterLegacyBinding(VerifyIncludedFiles,
              (options, value) => { options.VerifyAllModules = value; });
            DafnyOptions.RegisterLegacyBinding(WarnContradictoryAssumptions, (options, value) =>
            {
                if (value) { options.TrackVerificationCoverage = MutateCSharp.Schemata325.ReplaceBooleanConstant_1(249L, true); }
            });
            DafnyOptions.RegisterLegacyBinding(WarnRedundantAssumptions, (options, value) =>
            {
                if (value) { options.TrackVerificationCoverage = MutateCSharp.Schemata325.ReplaceBooleanConstant_1(250L, true); }
            });

            DafnyOptions.RegisterLegacyBinding(Target, (options, value) => { options.CompilerName = value; });

            DafnyOptions.RegisterLegacyBinding(QuantifierSyntax, (options, value) => { options.QuantifierSyntax = value; });

            DafnyOptions.RegisterLegacyBinding(PluginOption, (options, value) => { options.AdditionalPluginArguments = value; });

            DafnyOptions.RegisterLegacyBinding(StdIn, (options, value) =>
            {
                options.UseStdin = value;
            });

            DafnyOptions.RegisterLegacyBinding(Prelude, (options, value) =>
            {
                options.DafnyPrelude = value?.FullName;
                options.ExpandFilename(options.DafnyPrelude, x => options.DafnyPrelude = x, options.LogPrefix,
                  options.FileTimestamp);
            });

            DafnyOptions.RegisterLegacyBinding(BuildFile, (options, value) => { options.DafnyPrintCompiledFile = value?.FullName; });

            DafnyOptions.RegisterLegacyBinding(Libraries,
              (options, value) => { options.LibraryFiles = SplitOptionValueIntoFiles(value.Select(fi => fi.FullName)).ToHashSet(); });
            DafnyOptions.RegisterLegacyBinding(Output, (options, value) => { options.DafnyPrintCompiledFile = value?.FullName; });

            DafnyOptions.RegisterLegacyBinding(Verbose, (o, v) => o.Verbose = v);
            DafnyOptions.RegisterLegacyBinding(DisableNonLinearArithmetic, (o, v) => o.DisableNLarith = v);
            DafnyOptions.RegisterLegacyBinding(AllowDeprecation, (o, v) => o.DeprecationNoise = v ? MutateCSharp.Schemata325.ReplaceNumericConstant_2(251L, 0) : MutateCSharp.Schemata325.ReplaceNumericConstant_2(255L, 1));

            DafnyOptions.RegisterLegacyBinding(SpillTranslation, (o, f) => o.SpillTargetCode = f ? MutateCSharp.Schemata325.ReplaceNumericConstant_5(259L, 1U) : MutateCSharp.Schemata325.ReplaceNumericConstant_5(262L, 0U));

            DafnyOptions.RegisterLegacyBinding(EnforceDeterminism, (options, value) =>
            {
                options.ForbidNondeterminism = value;
                options.DefiniteAssignmentLevel = MutateCSharp.Schemata325.ReplaceNumericConstant_2(265L, 4);
            });
            RelaxDefiniteAssignment.AddValidator(optionResult =>
            {
                var enforceDeterminismResult = optionResult.FindResultFor(EnforceDeterminism);
                if (MutateCSharp.Schemata325.ReplaceBinExprOp_3(269L, () => enforceDeterminismResult is not null, () => enforceDeterminismResult.GetValueOrDefault<bool>()))
                {
                    optionResult.ErrorMessage =
                      $"The option {RelaxDefiniteAssignment.Name} can not be used in conjunction with {EnforceDeterminism.Name}.";
                }
            });
            DafnyOptions.RegisterLegacyBinding(RelaxDefiniteAssignment,
              (options, value) =>
              {
                  if (!options.Get(EnforceDeterminism))
                  {
                      options.DefiniteAssignmentLevel = value ? MutateCSharp.Schemata325.ReplaceNumericConstant_2(275L, 1) : MutateCSharp.Schemata325.ReplaceNumericConstant_2(279L, 4);
                  }
              });

            DafnyOptions.RegisterLegacyBinding(ExtractCounterexample, (options, value) =>
            {
                options.ExtractCounterexample = value;
                options.EnhancedErrorMessages = MutateCSharp.Schemata325.ReplaceNumericConstant_2(283L, 1);
            });

            DafnyOptions.RegisterLegacyBinding(ShowProofObligationExpressions, (options, value) =>
            {
                options.ShowProofObligationExpressions = value;
            });

            DooFile.RegisterLibraryChecks(
              new Dictionary<Option, OptionCompatibility.OptionCheck>() {
        { UnicodeCharacters, OptionCompatibility.CheckOptionMatches },
        { EnforceDeterminism, OptionCompatibility.CheckOptionLocalImpliesLibrary },
        { RelaxDefiniteAssignment, OptionCompatibility.OptionLibraryImpliesLocalError },
        { AllowAxioms, OptionCompatibility.OptionLibraryImpliesLocalError },
        { AllowWarnings, OptionCompatibility.OptionLibraryImpliesLocalWarning },
        { AllowDeprecation, OptionCompatibility.OptionLibraryImpliesLocalWarning },
        { WarnShadowing, OptionCompatibility.OptionLibraryImpliesLocalWarning },
        { UseStandardLibraries, OptionCompatibility.OptionLibraryImpliesLocalError },
              }
            );
            DooFile.RegisterNoChecksNeeded(WarnAsErrors, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(287L, false));
            DooFile.RegisterNoChecksNeeded(ProgressOption, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(288L, false));
            DooFile.RegisterNoChecksNeeded(LogLocation, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(289L, false));
            DooFile.RegisterNoChecksNeeded(LogLevelOption, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(290L, false));
            DooFile.RegisterNoChecksNeeded(ManualTriggerOption, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(291L, true));
            DooFile.RegisterNoChecksNeeded(ShowHints, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(292L, false));
            DooFile.RegisterNoChecksNeeded(Libraries, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(293L, false));
            DooFile.RegisterNoChecksNeeded(Output, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(294L, false));
            DooFile.RegisterNoChecksNeeded(PluginOption, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(295L, false));
            DooFile.RegisterNoChecksNeeded(Prelude, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(296L, false));
            DooFile.RegisterNoChecksNeeded(Target, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(297L, false));
            DooFile.RegisterNoChecksNeeded(Verbose, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(298L, false));
            DooFile.RegisterNoChecksNeeded(JsonDiagnostics, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(299L, false));
            DooFile.RegisterNoChecksNeeded(QuantifierSyntax, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(300L, true));
            DooFile.RegisterNoChecksNeeded(SpillTranslation, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(301L, false));
            DooFile.RegisterNoChecksNeeded(StdIn, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(302L, false));
            DooFile.RegisterNoChecksNeeded(TestAssumptions, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(303L, false));
            DooFile.RegisterNoChecksNeeded(ManualLemmaInduction, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(304L, true));
            DooFile.RegisterNoChecksNeeded(TypeInferenceDebug, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(305L, false));
            DooFile.RegisterNoChecksNeeded(GeneralTraits, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(306L, false));
            DooFile.RegisterNoChecksNeeded(GeneralNewtypes, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(307L, false));
            DooFile.RegisterNoChecksNeeded(TypeSystemRefresh, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(308L, false));
            DooFile.RegisterNoChecksNeeded(VerificationLogFormat, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(309L, false));
            DooFile.RegisterNoChecksNeeded(VerifyIncludedFiles, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(310L, false));
            DooFile.RegisterNoChecksNeeded(DisableNonLinearArithmetic, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(311L, true));
            DooFile.RegisterNoChecksNeeded(NewTypeInferenceDebug, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(312L, false));
            DooFile.RegisterNoChecksNeeded(UseBaseFileName, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(313L, false));
            DooFile.RegisterNoChecksNeeded(EmitUncompilableCode, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(314L, false));
            DooFile.RegisterNoChecksNeeded(WarnMissingConstructorParenthesis, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(315L, true));
            DooFile.RegisterNoChecksNeeded(IncludeRuntimeOption, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(316L, false));
            DooFile.RegisterNoChecksNeeded(InternalIncludeRuntimeOptionForExecution, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(317L, false));
            DooFile.RegisterNoChecksNeeded(WarnContradictoryAssumptions, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(318L, true));
            DooFile.RegisterNoChecksNeeded(WarnRedundantAssumptions, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(319L, true));
            DooFile.RegisterNoChecksNeeded(VerificationCoverageReport, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(320L, false));
            DooFile.RegisterNoChecksNeeded(NoTimeStampForCoverageReport, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(321L, false));
            DooFile.RegisterNoChecksNeeded(DefaultFunctionOpacity, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(322L, true));
            DooFile.RegisterNoChecksNeeded(OptimizeErasableDatatypeWrapper, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(323L, false)); // TODO needs translation record registration
            DooFile.RegisterNoChecksNeeded(AddCompileSuffix, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(324L, false));  // TODO needs translation record registration
            DooFile.RegisterNoChecksNeeded(SystemModule, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(325L, false));
            DooFile.RegisterNoChecksNeeded(ExecutionCoverageReport, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(326L, false));
            DooFile.RegisterNoChecksNeeded(ExtractCounterexample, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(327L, false));
            DooFile.RegisterNoChecksNeeded(ShowProofObligationExpressions, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(328L, false));
            DooFile.RegisterNoChecksNeeded(GoBackend.GoModuleNameCliOption, MutateCSharp.Schemata325.ReplaceBooleanConstant_1(329L, false));
        }
    }
}

