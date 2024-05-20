using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Transactions;
using DafnyCore;
using DafnyCore.Options;
using Microsoft.Boogie;
namespace MutateCSharp
{
    internal class Schemata324
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT324");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static int ReplacePostfixUnaryExprOp_15(long mutantId, ref int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1++; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1--; }
            return argument1++;
        }

        internal static bool ReplaceBinExprOp_12(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
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

        internal static bool ReplaceBinExprOp_7(long mutantId, long argument1, long argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 > argument2;
        }

        internal static bool ReplaceBooleanConstant_8(long mutantId, bool argument1)
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

        internal static uint ReplaceNumericConstant_3(long mutantId, uint argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 2)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_11(long mutantId, long argument1, long argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static int ReplaceBinExprOp_2(long mutantId, int argument1, int argument2)
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

        internal static int ReplaceNumericConstant_1(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static int ReplaceBinExprOp_10(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 8)) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 << argument2; }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1 >> argument2; }
            if (ActivatedMutantId.Value == mutantId + 6) { return argument1 | argument2; }
            if (ActivatedMutantId.Value == mutantId + 7) { return argument1 & argument2; }
            if (ActivatedMutantId.Value == mutantId + 8) { return argument1 ^ argument2; }
            return argument1 / argument2;
        }

        internal static double ReplaceNumericConstant_4(long mutantId, double argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static double ReplaceBinExprOp_5(long mutantId, double argument1, double argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            return argument1 / argument2;
        }

        internal static bool ReplaceBinExprOp_13(long mutantId, System.IO.FileInfo argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
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

        internal static double ReplaceBinExprOp_6(long mutantId, double argument1, double argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1 * argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 / argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 % argument2; }
            return argument1 * argument2;
        }

        internal static bool ReplaceBinExprOp_14(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 < argument2;
        }

        internal static bool ReplaceBinExprOp_16(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

    }
}

namespace Microsoft.Dafny
{
    public static class BoogieOptionBag
    {
        public static readonly Option<IEnumerable<string>> BoogieArguments = new(MutateCSharp.Schemata324.ReplaceStringConstant_0(1L, "--boogie"),
      MutateCSharp.Schemata324.ReplaceStringConstant_0(2L, "Specify arguments that are passed to Boogie, a tool used to verify Dafny programs."))
        {
            ArgumentHelpName = MutateCSharp.Schemata324.ReplaceStringConstant_0(3L, "arguments"),
            Arity = ArgumentArity.ZeroOrMore
        };

        public static readonly Option<uint> Cores = new(MutateCSharp.Schemata324.ReplaceStringConstant_0(4L, "--cores"), result =>
        {

            var value = result.Tokens[^MutateCSharp.Schemata324.ReplaceNumericConstant_1(5L, 1)].Value;
            if (value.EndsWith('%'))
            {
                if (double.TryParse(value.Substring(MutateCSharp.Schemata324.ReplaceNumericConstant_1(9L, 0), MutateCSharp.Schemata324.ReplaceBinExprOp_2(17L, value.Length, MutateCSharp.Schemata324.ReplaceNumericConstant_1(13L, 1))), out var percentage))
                {
                    return Math.Max(MutateCSharp.Schemata324.ReplaceNumericConstant_3(26L, 1U), (uint)(MutateCSharp.Schemata324.ReplaceBinExprOp_6(37L, MutateCSharp.Schemata324.ReplaceBinExprOp_5(33L, percentage, MutateCSharp.Schemata324.ReplaceNumericConstant_4(29L, 100.0)), Environment.ProcessorCount)));
                }

                result.ErrorMessage = $"Could not parse percentage {value}";
                return MutateCSharp.Schemata324.ReplaceNumericConstant_3(41L, 1);
            }

            if (uint.TryParse(value, out var number))
            {
                if (MutateCSharp.Schemata324.ReplaceBinExprOp_7(47L, number, MutateCSharp.Schemata324.ReplaceNumericConstant_3(44L, 0)))
                {
                    return number;
                }

                result.ErrorMessage = $"Number of cores to use must be greater than 0";
                return MutateCSharp.Schemata324.ReplaceNumericConstant_3(52L, 1);
            }
            result.ErrorMessage = $"Could not parse number {value}";
            return MutateCSharp.Schemata324.ReplaceNumericConstant_3(55L, 1);
        }, MutateCSharp.Schemata324.ReplaceBooleanConstant_8(58L, true),
      MutateCSharp.Schemata324.ReplaceStringConstant_0(59L, "Run the Dafny verifier using <n> cores, or using <XX%> of the machine's logical cores."))
        {
            ArgumentHelpName = MutateCSharp.Schemata324.ReplaceStringConstant_0(60L, "count"),
        };

        public static readonly Option<bool> NoVerify = new(MutateCSharp.Schemata324.ReplaceStringConstant_0(61L, "--no-verify"), MutateCSharp.Schemata324.ReplaceStringConstant_0(62L, "Skip verification"));

        public static readonly Option<bool> HiddenNoVerify = new(MutateCSharp.Schemata324.ReplaceStringConstant_0(63L, "--hidden-no-verify"),
      MutateCSharp.Schemata324.ReplaceStringConstant_0(64L, "Allows building unverified libraries without recording that they were not verified."))
        {
            IsHidden = MutateCSharp.Schemata324.ReplaceBooleanConstant_8(65L, true
      )
        };

        public static readonly Option<uint> VerificationTimeLimit = new(MutateCSharp.Schemata324.ReplaceStringConstant_0(66L, "--verification-time-limit"),
      MutateCSharp.Schemata324.ReplaceStringConstant_0(67L, "Limit the number of seconds spent trying to verify each procedure"))
        {
            ArgumentHelpName = MutateCSharp.Schemata324.ReplaceStringConstant_0(68L, "seconds"),
        };

        public static readonly Option<int> VerificationErrorLimit =
          new(MutateCSharp.Schemata324.ReplaceStringConstant_0(69L, "--error-limit"), () => MutateCSharp.Schemata324.ReplaceNumericConstant_1(70L, 5), MutateCSharp.Schemata324.ReplaceStringConstant_0(74L, "Set the maximum number of errors to report (0 for unlimited)."));

        public static readonly Option<uint> SolverResourceLimit = new(MutateCSharp.Schemata324.ReplaceStringConstant_0(75L, "--resource-limit"),
          result =>
          {
              var value = result.Tokens[^MutateCSharp.Schemata324.ReplaceNumericConstant_1(76L, 1)].Value;

              if (DafnyOptions.TryParseResourceCount(value, out var number))
              {
                  return number;
              }

              result.ErrorMessage = $"Cannot parse resource limit: {value}";
              return MutateCSharp.Schemata324.ReplaceNumericConstant_3(80L, 0);
          },
          isDefault: MutateCSharp.Schemata324.ReplaceBooleanConstant_8(83L, false),
      MutateCSharp.Schemata324.ReplaceStringConstant_0(84L, @"Specify the maximum resource limit (rlimit) value to pass to Z3. A resource limit is a deterministic alternative to a time limit. The output produced by `--log-format csv` includes the resource use of each proof effort, which you can use to determine an appropriate limit for your program."));
        public static readonly Option<string> SolverPlugin = new(MutateCSharp.Schemata324.ReplaceStringConstant_0(85L, "--solver-plugin"),
      MutateCSharp.Schemata324.ReplaceStringConstant_0(86L, @"Dafny uses Boogie as part of its verification process. This option allows customising that part using a Boogie plugin. More information about Boogie can be found at https://github.com/boogie-org/boogie. Information on how to construct Boogie plugins can be found by looking at the code in https://github.com/boogie-org/boogie/blob/v2.16.3/Source/Provers/SMTLib/ProverUtil.cs#L316"));

        public static readonly Option<string> SolverLog =
          new(MutateCSharp.Schemata324.ReplaceStringConstant_0(87L, "--solver-log"), MutateCSharp.Schemata324.ReplaceStringConstant_0(88L, @"Specify a file to use to log the SMT-Lib text sent to the solver."))
          {
              IsHidden = MutateCSharp.Schemata324.ReplaceBooleanConstant_8(89L, true
      )
          };

        public static readonly Option<bool> IsolateAssertions = new(MutateCSharp.Schemata324.ReplaceStringConstant_0(90L, "--isolate-assertions"), MutateCSharp.Schemata324.ReplaceStringConstant_0(91L, @"Verify each assertion in isolation."));

        public static readonly Option<FileInfo> SolverPath = new(MutateCSharp.Schemata324.ReplaceStringConstant_0(92L, "--solver-path"),
      MutateCSharp.Schemata324.ReplaceStringConstant_0(93L, "Can be used to specify a custom SMT solver to use for verifying Dafny proofs."))
        {
        };
        public static readonly Option<IList<string>> SolverOption = new(MutateCSharp.Schemata324.ReplaceStringConstant_0(94L, "--solver-option"),
      MutateCSharp.Schemata324.ReplaceStringConstant_0(95L, @"Specify an option to control how the solver works. Use --solver-option-help for details on possible parameters. Note that this directly changes the internal behavior of Boogie, and some option settings do not work well or at all with Dafny. More information about Boogie can be found at https://github.com/boogie-org/boogie."))
        {
            IsHidden = MutateCSharp.Schemata324.ReplaceBooleanConstant_8(96L, true
      )
        };

        public static readonly Option<bool> SolverOptionHelp = new(MutateCSharp.Schemata324.ReplaceStringConstant_0(97L, "--solver-option-help"),
      MutateCSharp.Schemata324.ReplaceStringConstant_0(98L, @"Describe the possible parameters to --solver-option."))
        {
            IsHidden = MutateCSharp.Schemata324.ReplaceBooleanConstant_8(99L, true
      )
        };


        static BoogieOptionBag()
        {
            Cores.SetDefaultValue((uint)(MutateCSharp.Schemata324.ReplaceBinExprOp_10(117L, (MutateCSharp.Schemata324.ReplaceBinExprOp_9(104L, Environment.ProcessorCount, MutateCSharp.Schemata324.ReplaceNumericConstant_1(100L, 1))), MutateCSharp.Schemata324.ReplaceNumericConstant_1(113L, 2))));

            DafnyOptions.RegisterLegacyBinding(BoogieArguments, (o, boogieOptions) =>
            {
                var splitOptions = boogieOptions.SelectMany(SplitArguments).ToArray();
                if (splitOptions.Any())
                {
                    o.BaseParse(splitOptions.ToArray(), MutateCSharp.Schemata324.ReplaceBooleanConstant_8(126L, false));
                }
            });
            DafnyOptions.RegisterLegacyBinding(Cores,
              (o, f) => o.VcsCores = MutateCSharp.Schemata324.ReplaceBinExprOp_11(130L, f, MutateCSharp.Schemata324.ReplaceNumericConstant_3(127L, 0)) ? MutateCSharp.Schemata324.ReplaceBinExprOp_10(152L, (MutateCSharp.Schemata324.ReplaceBinExprOp_9(139L, MutateCSharp.Schemata324.ReplaceNumericConstant_1(135L, 1), System.Environment.ProcessorCount)), MutateCSharp.Schemata324.ReplaceNumericConstant_1(148L, 2)) : (int)f);
            DafnyOptions.RegisterLegacyBinding(NoVerify, (options, value) =>
            {
                var shouldVerify = MutateCSharp.Schemata324.ReplaceBinExprOp_12(161L, () => !value, () => !options.Get(HiddenNoVerify));
                options.Verify = shouldVerify;
            });
            DafnyOptions.RegisterLegacyBinding(VerificationTimeLimit, (o, f) => o.TimeLimit = f);

            DafnyOptions.RegisterLegacyBinding(SolverPath, (options, value) =>
            {
                if (MutateCSharp.Schemata324.ReplaceBinExprOp_13(167L, value, null))
                {
                    options.ProverOptions.RemoveAll(s => s.StartsWith(MutateCSharp.Schemata324.ReplaceStringConstant_0(168L, "PROVER_PATH=")));
                    options.ProverOptions.Add($"PROVER_PATH={value?.FullName}");
                }
            });
            SolverPlugin.AddValidator(r =>
            {
                var fi = r.GetValueOrDefault<string>();
                if (!File.Exists(fi))
                {
                    r.ErrorMessage = $"--solver-plugin: File {fi} does not exist";
                }
            });
            DafnyOptions.RegisterLegacyBinding(SolverPlugin, (o, v) =>
            {
                if (v is not null)
                {
                    o.ProverDllName = v;
                    o.TheProverFactory = ProverFactory.Load(o.ProverDllName);
                }
            });
            DafnyOptions.RegisterLegacyBinding(SolverResourceLimit, (o, v) => o.ResourceLimit = v);
            DafnyOptions.RegisterLegacyBinding(SolverLog, (o, v) => o.ProverLogFilePath = v);
            DafnyOptions.RegisterLegacyBinding(SolverOption, (o, v) =>
            {
                if (v is not null)
                {
                    o.ProverOptions.AddRange(v);
                }
            });
            DafnyOptions.RegisterLegacyBinding(SolverOptionHelp, (o, v) => o.ProverHelpRequested = v);
            DafnyOptions.RegisterLegacyBinding(VerificationErrorLimit, (options, value) => { options.ErrorLimit = value; });
            DafnyOptions.RegisterLegacyBinding(IsolateAssertions, (o, v) => o.VcsSplitOnEveryAssert = v);


            DooFile.RegisterLibraryChecks(
              new Dictionary<Option, OptionCompatibility.OptionCheck> {
        { BoogieArguments, OptionCompatibility.CheckOptionMatches },
        { NoVerify, OptionCompatibility.OptionLibraryImpliesLocalError },
              }
            );
            DooFile.RegisterNoChecksNeeded(HiddenNoVerify, MutateCSharp.Schemata324.ReplaceBooleanConstant_8(169L, false));
            DooFile.RegisterNoChecksNeeded(Cores, MutateCSharp.Schemata324.ReplaceBooleanConstant_8(170L, false));
            DooFile.RegisterNoChecksNeeded(VerificationTimeLimit, MutateCSharp.Schemata324.ReplaceBooleanConstant_8(171L, false));
            DooFile.RegisterNoChecksNeeded(VerificationErrorLimit, MutateCSharp.Schemata324.ReplaceBooleanConstant_8(172L, false));
            DooFile.RegisterNoChecksNeeded(IsolateAssertions, MutateCSharp.Schemata324.ReplaceBooleanConstant_8(173L, false));
            DooFile.RegisterNoChecksNeeded(SolverLog, MutateCSharp.Schemata324.ReplaceBooleanConstant_8(174L, false));
            DooFile.RegisterNoChecksNeeded(SolverOption, MutateCSharp.Schemata324.ReplaceBooleanConstant_8(175L, false));
            DooFile.RegisterNoChecksNeeded(SolverOptionHelp, MutateCSharp.Schemata324.ReplaceBooleanConstant_8(176L, false));
            DooFile.RegisterNoChecksNeeded(SolverPath, MutateCSharp.Schemata324.ReplaceBooleanConstant_8(177L, false));
            DooFile.RegisterNoChecksNeeded(SolverPlugin, MutateCSharp.Schemata324.ReplaceBooleanConstant_8(178L, false));
            DooFile.RegisterNoChecksNeeded(SolverResourceLimit, MutateCSharp.Schemata324.ReplaceBooleanConstant_8(179L, false));
        }

        private static IReadOnlyList<string> SplitArguments(string commandLine)
        {
            if (string.IsNullOrEmpty(commandLine))
            {
                return Array.Empty<string>();
            }

            var inSingleQuote = MutateCSharp.Schemata324.ReplaceBooleanConstant_8(180L, false);
            var inDoubleQuote = MutateCSharp.Schemata324.ReplaceBooleanConstant_8(181L, false);
            var result = new List<string>();
            var start = MutateCSharp.Schemata324.ReplaceNumericConstant_1(182L, 0);
            for (var end = MutateCSharp.Schemata324.ReplaceNumericConstant_1(186L, 0); MutateCSharp.Schemata324.ReplaceBinExprOp_14(190L, end, commandLine.Length); MutateCSharp.Schemata324.ReplacePostfixUnaryExprOp_15(195L, ref end))
            {
                var store = MutateCSharp.Schemata324.ReplaceBooleanConstant_8(196L, false);
                if (MutateCSharp.Schemata324.ReplaceBinExprOp_12(202L, () => MutateCSharp.Schemata324.ReplaceBinExprOp_16(197L, commandLine[end], '"'), () => !inSingleQuote))
                {
                    store = inDoubleQuote;
                    inDoubleQuote = !inDoubleQuote;
                }
                if (MutateCSharp.Schemata324.ReplaceBinExprOp_12(213L, () => MutateCSharp.Schemata324.ReplaceBinExprOp_16(208L, commandLine[end], '\''), () => !inDoubleQuote))
                {
                    store = inSingleQuote;
                    inSingleQuote = !inSingleQuote;
                }
                if (MutateCSharp.Schemata324.ReplaceBinExprOp_12(230L, () => MutateCSharp.Schemata324.ReplaceBinExprOp_12(219L, () => !inSingleQuote, () => !inDoubleQuote), () => MutateCSharp.Schemata324.ReplaceBinExprOp_16(225L, commandLine[end], ' ')))
                {
                    store = MutateCSharp.Schemata324.ReplaceBooleanConstant_8(236L, true);
                }

                if (store)
                {
                    result.Add(commandLine.Substring(start, MutateCSharp.Schemata324.ReplaceBinExprOp_2(237L, end, start)));
                    start = MutateCSharp.Schemata324.ReplaceBinExprOp_9(250L, end, MutateCSharp.Schemata324.ReplaceNumericConstant_1(246L, 1)); // Skip the single or double quote or space in the next entry
                }
            }
            result.Add(commandLine.Substring(start, MutateCSharp.Schemata324.ReplaceBinExprOp_2(259L, commandLine.Length, start)));
            return result;
        }
    }
}
